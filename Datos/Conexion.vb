Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Threading
Imports System.Reflection

Public Class Conexion
    Private CadenaConexion As String
    Dim miconexion As SqlConnection
    Dim miconexionRemoto As SqlConnection
    Dim encripta As New EncriptacionHelper
    Dim com As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim ds As DataSet

    Public Function ConectarLocal()
        Try
            CadenaConexion = ConfigurationManager.ConnectionStrings("SistemaCinderella.My.MySettings.Conexion").ToString
            miconexion = New SqlConnection
            miconexion.ConnectionString = String.Format(CadenaConexion, Assembly.GetEntryAssembly.GetName().Name)
            miconexion.Open()
        Catch ex As Exception
            Windows.Forms.MessageBox.Show("Error conectando con la base de datos local." & ex.ToString())
        End Try
        Return miconexion
    End Function

    Public Sub DesconectarLocal()
        miconexion.Dispose()
        miconexion.Close()
    End Sub

    Public Function ConectarRemoto()
        Try
            CadenaConexion = ConfigurationManager.ConnectionStrings("SistemaCinderella.My.MySettings.ConexionRemoto").ToString
            miconexionRemoto = New SqlConnection
            miconexionRemoto.ConnectionString = encripta.DesencriptarMD5(CadenaConexion)
            miconexionRemoto.Open()
        Catch ex As Exception
            Windows.Forms.MessageBox.Show("Error conectando con la base de datos remota." & ex.ToString())
        End Try
        Return miconexionRemoto
    End Function

    Public Function EstaDisponible(stringConexion As String) As Boolean
        Try
            miconexionRemoto = New SqlConnection
            miconexionRemoto.ConnectionString = encripta.DesencriptarMD5(stringConexion)
            miconexionRemoto.Open()
            miconexionRemoto.Close()
            Return True
        Catch ex As Exception
            Windows.Forms.MessageBox.Show("Error conectando con la base de datos remota." & ex.ToString())
        End Try
    End Function

    Public Sub DesconectarRemoto()
        miconexionRemoto.Dispose()
        miconexionRemoto.Close()
    End Sub

    Public Sub ModificarBaseLocal(ByVal query As String)
        Me.ConectarLocal()
        com.CommandText = query
        com.ExecuteNonQuery()
        Me.DesconectarLocal()
    End Sub

    Public Sub ModificarBaseRemoto(ByVal query As String)
        Me.ConectarRemoto()
        com.Connection = miconexionRemoto
        com.CommandText = query
        com.ExecuteNonQuery()
        Me.DesconectarRemoto()
    End Sub
    Public Function ConsultarBaseLocal(ByVal query As String)
        miconexion = ConectarLocal()
        ds = New DataSet()
        da = New SqlDataAdapter(query, miconexion)
        da.Fill(ds)
        Me.DesconectarLocal()
        Return ds
    End Function
    Public Function ConsultarBaseRemoto(ByVal query As String)
        miconexion = ConectarRemoto()
        ds = New DataSet()
        da = New SqlDataAdapter(query, miconexion)
        da.Fill(ds)
        Me.DesconectarRemoto()
        Return ds
    End Function

    Public Function ObtenerCalveUnica(idSucursal As Integer) As Int64
        'Duerno la ejecucion 10 ms para asegurarme que no se generen claves duplicadas
        Thread.Sleep(10)
        Return Int64.Parse(String.Format("{0}{1}", idSucursal.ToString(), DateTime.Now.ToString("yyyMMddhhmmssfff")))
    End Function

    Public Sub GuardarStringDeConexion(nombre As String, stringConexion As String)
        Dim config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
        Dim connectionString = config.ConnectionStrings.ConnectionStrings(nombre)
        'config.ConnectionStrings.SectionInformation.AllowExeDefinition = ConfigurationAllowExeDefinition.MachineToLocalUser

        If connectionString Is Nothing Then
            config.ConnectionStrings.ConnectionStrings.Add(New ConnectionStringSettings With {
                .Name = nombre,
                .ConnectionString = stringConexion,
                .ProviderName = "System.Data.SqlClient"
            })
            config.Save(ConfigurationSaveMode.Modified)
        Else
            connectionString.ConnectionString = stringConexion
        End If

        config.Save(ConfigurationSaveMode.Modified)
        ConfigurationManager.RefreshSection("connectionStrings")
    End Sub
End Class
