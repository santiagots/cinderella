Imports System.ComponentModel
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Threading.Tasks
Imports Common.Core.Enum
Imports Common.Core.Exceptions
Imports Datos

Namespace Formularios.Comun
    Public Class frmConfiguracionBaseDatosViewModel
        Inherits Comunes.Common

        Private Const NOMBRE_BASE_DATOS As String = "CINDERELLA_LOCAL"

        Private Const NOMBRE_BASE_DATOS_MASTER As String = "master"

        Public Property TipoConexionBaseLocal As TipoConexionBaseLocal
        Public ReadOnly Property HabilitarServidoresRed As Boolean
            Get
                Return TipoConexionBaseLocal = TipoConexionBaseLocal.Red
            End Get
        End Property
        Public Property Servidores As BindingList(Of ServidorBaseDatos) = New BindingList(Of ServidorBaseDatos)
        Public Property ServidorLocalRed As String
        Public Property InstanciaLocalRed As String
        Public Property NombreBaseDatosLocalRed As String = NOMBRE_BASE_DATOS
        Public Property UsuarioLocalRed As String
        Public Property ContraseniaLocalRed As String
        Public Property StringConeccionBaseRemota As String

        Sub New()
            TipoConexionBaseLocal = My.Settings.TipoConexionBaseLocal

            If (TipoConexionBaseLocal = TipoConexionBaseLocal.Red) Then
                Dim connectionString As SqlConnectionStringBuilder = New SqlConnectionStringBuilder(My.Settings.Conexion)
                Dim connectionStringDataSource As String() = connectionString.DataSource.Split("\")
                If (connectionStringDataSource.Length >= 2) Then
                    ServidorLocalRed = connectionStringDataSource(0)
                    InstanciaLocalRed = connectionStringDataSource(1)
                    NombreBaseDatosLocalRed = connectionString.InitialCatalog
                End If
            End If

            StringConeccionBaseRemota = My.Settings.ConexionRemoto

        End Sub

        Friend Async Function CrearBaseDatosLocal() As Task
            Await Task.Run(Sub()
                               Dim mensajeError As String = String.Empty
                               If (Not Conexion.CrearBaseDatos(ObtenerStringDeConexionLocal(NOMBRE_BASE_DATOS_MASTER), NombreBaseDatosLocalRed, mensajeError)) Then
                                   Throw New NegocioException($"Ha habido un error al crear la base de datos.{Environment.NewLine}Error Conexion:{Environment.NewLine + mensajeError}")
                               End If
                           End Sub)
        End Function

        Public Async Function CopiarEsquemaBaseDatos() As Task
            Await Task.Run(Sub()
                               ''SqlConnectionStringBuilder valida que el string de coneccion sea correcto
                               Dim SqlConnectionStringBuilder As SqlConnectionStringBuilder = New SqlConnectionStringBuilder(ObtenerStringDeConexionRemoto())

                               Conexion.CopiarEsquemaBaseDatos(SqlConnectionStringBuilder.ToString(),
                                                         ObtenerStringDeConexionLocal(NOMBRE_BASE_DATOS_MASTER),
                                                             SqlConnectionStringBuilder.InitialCatalog,
                                                             NombreBaseDatosLocalRed)
                           End Sub)
        End Function

        Public Async Function ActualizarTipoConexionBaseLocal(tipoConexionBaseLocal As TipoConexionBaseLocal) As Task
            Me.TipoConexionBaseLocal = tipoConexionBaseLocal
            If (Me.TipoConexionBaseLocal = TipoConexionBaseLocal.Red) Then
                Await CargarServidoresAsync()
            Else
                Servidores.Clear()
            End If

            NotifyPropertyChanged(NameOf(Me.HabilitarServidoresRed))
        End Function

        Public Async Function CargarServidoresAsync() As Task
            Await Task.Run(Sub()
                               Dim table As DataTable = System.Data.Sql.SqlDataSourceEnumerator.Instance.GetDataSources()

                               If (table.Rows.Count = 0) Then
                                   Throw New NegocioException("No se han encontrado servidores de base de datos. Verifique que no halla errores de configuración.")
                               End If

                               For Each server As DataRow In table.Rows
                                   Servidores.Add(New ServidorBaseDatos(server(table.Columns("ServerName")).ToString(), server(table.Columns("InstanceName")).ToString(), server(table.Columns("Version")).ToString()))
                               Next

                               ActualizarServidorSeleccionado(Servidores.First())
                           End Sub)

            NotifyPropertyChanged(NameOf(Me.Servidores))
        End Function

        Public Async Function ActualizarConfiguracion() As Task
            Dim nombreBaseDatos As String
            If (Me.TipoConexionBaseLocal = TipoConexionBaseLocal.Red) Then
                nombreBaseDatos = NombreBaseDatosLocalRed
            Else
                nombreBaseDatos = NOMBRE_BASE_DATOS
            End If

            Dim mensajeError As String = String.Empty
            Dim stringConeccionLocal As String = ObtenerStringDeConexionLocal(nombreBaseDatos)
            Dim stringConeccionRemoto As String = ObtenerStringDeConexionRemoto()

            Await VerificarConexionBaseDatos(stringConeccionLocal)

            Await VerificarConexionBaseDatos(stringConeccionRemoto)

            My.Settings.Conexion = stringConeccionLocal
            My.Settings.ConexionRemoto = EncriptacionHelper.EncriptarMD5(stringConeccionRemoto)
            My.Settings.TipoConexionBaseLocal = TipoConexionBaseLocal
            My.Settings.Save()
        End Function

        Public Function ObtenerStringDeConexionLocal(nombreBaseDatos As String) As String

            If (Me.TipoConexionBaseLocal = TipoConexionBaseLocal.Red) Then
                If (String.IsNullOrEmpty(ServidorLocalRed) OrElse String.IsNullOrEmpty(InstanciaLocalRed) OrElse String.IsNullOrEmpty(NombreBaseDatosLocalRed) OrElse String.IsNullOrEmpty(UsuarioLocalRed) OrElse String.IsNullOrEmpty(ContraseniaLocalRed)) Then
                    Throw New NegocioException("Uno o varios de los campos requeridos se encuentran vacíos. Por favor, complete todos los campos requeridos")
                End If
#If DEBUG Then
                Dim stringConeccion As SqlConnectionStringBuilder = New SqlConnectionStringBuilder() With {
                .DataSource = $"{ServidorLocalRed}\{InstanciaLocalRed}",
                .InitialCatalog = nombreBaseDatos,
                .IntegratedSecurity = True,
                .MultipleActiveResultSets = False,
                .PersistSecurityInfo = True
                }
#Else
                Dim stringConeccion As SqlConnectionStringBuilder = New SqlConnectionStringBuilder() With {
                .DataSource = $"{ServidorLocalRed}\{InstanciaLocalRed}",
                .InitialCatalog = nombreBaseDatos,
                .IntegratedSecurity = False,
                .MultipleActiveResultSets = False,
                .PersistSecurityInfo = True,
                .UserID = UsuarioLocalRed,
                .Password = ContraseniaLocalRed
                }
#End If

                Return stringConeccion.ToString()
            Else
                Return ConfigurationManager.ConnectionStrings("default").ToString()
            End If
        End Function

        Public Function ObtenerStringDeConexionRemoto() As String
            If (String.IsNullOrWhiteSpace(StringConeccionBaseRemota)) Then
                Throw New NegocioException("Uno o varios de los campos requeridos se encuentran vacíos. Por favor, complete todos los campos requeridos")
            End If

            Return EncriptacionHelper.DesencriptarMD5(StringConeccionBaseRemota)
        End Function

        Friend Sub ActualizarServidorSeleccionado(servidorSeleccionado As ServidorBaseDatos)
            ServidorLocalRed = servidorSeleccionado.Nombre
            InstanciaLocalRed = servidorSeleccionado.Instancia


            NotifyPropertyChanged(NameOf(Me.ServidorLocalRed))
            NotifyPropertyChanged(NameOf(Me.InstanciaLocalRed))
        End Sub

        Public Async Function VerificarConexionBaseDatos(stringDeConexion As String) As Task
            Await Task.Run(Sub()
                               Dim mensajeError As String = String.Empty
                               If (Not Conexion.EstaDisponible(stringDeConexion, False, mensajeError)) Then
                                   Throw New NegocioException($"Ha habido un error al realizar la conexión. Por favor, verifique que los datos ingresados sean correctos.{Environment.NewLine}Error Conexion:{Environment.NewLine + mensajeError}")
                               End If
                           End Sub)
        End Function
    End Class
End Namespace
