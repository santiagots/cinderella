Imports System.Data.SqlClient
Imports System.IO
Imports System.Threading.Tasks
Imports Datos
Imports Negocio

Public Class frmSincronizacion

    Public conexionRemota As Boolean
    Public conexionLocal As Boolean
    Dim negSincronizacion As New Negocio.NegSincronizacion

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        conexionRemota = negSincronizacion.ProbarConectarRemoto
        conexionLocal = negSincronizacion.ProbarConectarLocal

    End Sub

    Private Sub frmSincronizacion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.CheckForIllegalCrossThreadCalls = False

        'seteo el icono
        Dim icono As System.Drawing.Icon
        icono = My.Resources.Recursos.Cinderella
        Me.Icon = icono

        ListaEstado.Columns(0).Width = 370
        ListaEstado.Columns(1).Width = 156
        ListaEstado.StateImageList = ImageList1

        'indico los estados de conexion de ambas bases
        If conexionRemota Then
            lblEstadoRemota.Text = "CONECTADO"
        Else
            lblEstadoRemota.Text = "ERROR AL CONECTAR"
        End If

        'conexion local
        If conexionLocal Then
            lblEstadoLocal.Text = "CONECTADO"
        Else
            lblEstadoLocal.Text = "ERROR AL CONECTAR"
        End If

        Me.Refresh()
    End Sub

    Private Async Sub btnSincronizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSincronizar.Click
        Try
            'limpio la lista
            ListaEstado.Items.Clear()

            Dim actualizado As New ListViewItem
            btnSincronizar.Enabled = False
            Me.Cursor = Cursors.WaitCursor

            'inicio el proceso
            actualizado.Text = "Inicializacion de actualizacion"
            actualizado.SubItems.Add("INICIADO")
            actualizado.StateImageIndex = 2
            ListaEstado.Items.Add(actualizado)

            'Dim t As Task = Task.Run(Sub() SincronizarDatos())
            't.Wait()

            If (Await SincronizarDatos()) Then
                negSincronizacion.AltaSincronizacion(My.Settings.Sucursal)
            End If

            Progreso.Value = 100
            btnSincronizar.Enabled = True
            Me.Cursor = Cursors.Default
            btn_Cerrar.Visible = True
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show("Se ha producido un error al sincronizar los datos. Por favor, Comuníquese con el administrador.", "Sincronización de Bases de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function RegistrarDatosARemoto(sincronizacion As NegSincronizacion, TablasSincronizar As List(Of Tabla), indicadorprogreso As Integer) As Integer
        Dim contador As Integer = 0
        Dim estado As Integer = 0
        Dim nombreTabla As String = String.Empty

        Dim clsDatos As New Datos.Conexion
        Dim conexionLocal As SqlConnection = clsDatos.ConectarLocal()
        Dim conexionRemota As SqlConnection = clsDatos.ConectarRemoto()

        Dim transaccionRemota As SqlTransaction = conexionRemota.BeginTransaction()
        Dim transaccionLocal As SqlTransaction = conexionLocal.BeginTransaction()

        Try
            For Each tabla In TablasSincronizar
                nombreTabla = tabla.Nombre
                tabla.Sincronizar.procesar(tabla, My.Settings.Sucursal.ToString(), conexionLocal, conexionRemota, transaccionRemota, transaccionLocal)
                AgregarItemListaEstado("Sincronizando datos " & tabla.Nombre, 0, "CORRECTO")
                contador = contador + 1
                Progreso.Increment(indicadorprogreso)
            Next

            transaccionLocal.Commit()
            transaccionRemota.Commit()

        Catch ex As Exception
            transaccionLocal.Rollback()
            transaccionRemota.Rollback()
            LogHelper.WriteLog(String.Format("ERROR Metodo: RegistrarDatosARemoto - Tabla {0}", nombreTabla) + Environment.NewLine + ex.ToString())
            Throw
        Finally
            conexionRemota.Close()
            conexionLocal.Close()
        End Try

        Return contador
    End Function

    Private Sub AgregarItemListaEstado(itemDescripcion As String, imagen As Integer, estado As String)
        Dim itemusuarios As New ListViewItem

        itemusuarios.Text = itemDescripcion
        itemusuarios.StateImageIndex = imagen
        itemusuarios.SubItems.Add(estado)

        ListaEstado.Items.Add(itemusuarios)
        ListaEstado.Items(ListaEstado.Items.Count - 1).EnsureVisible()
        ListaEstado.Refresh()
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        Me.Close()
    End Sub

    Private Async Function SincronizarDatos() As Task(Of Boolean)

        Try

            Dim sincronizacion As New NegSincronizacion
            Dim elementosSincronizados As Integer = 0
            'indico la cantidad de tablas para la barra de progreso

            Dim tablas As List(Of Tabla) = sincronizacion.GetTablas()
            Dim indicadorprogreso As Integer = Progreso.Maximum / tablas.Count

            'deshabilito las Constraint de la base de datos por las relaciones de FK
            sincronizacion.DeshabilitarConstraint()

            elementosSincronizados += RegistrarDatosARemoto(sincronizacion, tablas, indicadorprogreso)

            'habilito las Constraint de la base de datos
            sincronizacion.HabilitarConstraint()

            'finalizacion de proceso
            Dim item As New ListViewItem
            item.Text = "Se sincronizaron " + elementosSincronizados.ToString + " de " + tablas.Count.ToString() + " tablas disponibles."
            item.SubItems.Add("FINALIZADO")
            item.StateImageIndex = 2
            ListaEstado.Items.Add(item)
            ListaEstado.Refresh()

            Return True
        Catch
            Me.Cursor = Cursors.Default
            MessageBox.Show("Se ha producido un error al sincronizar los datos, el proceso fue cancelado y los datos no fueron sincronizados. Por favor, Comuníquese con el administrador.", "Sincronización de Bases de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            AgregarItemListaEstado("Proceso Cancelado ", 1, "ERROR")
            AgregarItemListaEstado("Los Datos no se han podido  sincronizar", 1, "ERROR")

            Return False
        End Try


    End Function

    Private Sub BW_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs)
        Progreso.Increment(e.ProgressPercentage)
    End Sub
End Class