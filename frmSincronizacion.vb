Imports System.Data.SqlClient
Imports System.Threading.Tasks
Imports Negocio

Public Class frmSincronizacion

    Public conexionRemota As Boolean
    Public conexionLocal As Boolean

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        Dim negSincronizacion As New Negocio.NegSincronizacion
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

    Private Sub btnSincronizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSincronizar.Click
        Try
            'limpio la lista
            ListaEstado.Items.Clear()

            'Dim sincronizacion As New NegSincronizacion

            Dim actualizado As New ListViewItem
            btnSincronizar.Enabled = False
            Me.Cursor = Cursors.WaitCursor

            'indico la cantidad de tablas para la barra de progreso
            'Dim tablas() As String = {"REL_REGISTRO_EMPLEADOS", "REL_REGISTRO_EMPLEADOS_AUSENTES", "REL_USUARIOS_PERFILES", "STOCK", "ADELANTOS", "STOCK_BITACORA", "ADICIONALES", "SUCURSALES", "AROMAS", "SUELDOS", "BANCOS", "TIPOS_COMISIONES", "CAJA_INICIAL", "TIPOS_EGRESOS", "CHEQUE", "TIPOS_PAGO", "CLIENTES", "TIPOS_VENTAS", "COLORES", "USUARIOS", "COMISIONES", "USUARIOS_MENSAJES", "CONDICIONES_IVA", "VENTAS", "CONSUMIDORFINAL", "VENTAS_DETALLE", "CUENTA_CORRIENTE", "DEPARTAMENTOS", "DEUDA", "DEVOLUCIONES", "DEVOLUCIONES_DETALLE", "EMPLEADOS", "EMPLEADOS_DEPOSITOS", "EMPLEADOS_RECIBOS", "EMPLEADOS_REGISTROS", "EMPLEADOS_TIPOS", "FACTURACION", "FERIADOS", "LISTA_GRUPO", "LISTA_PRECIO", "LOCALIDADES", "MATERIALES", "MERCADERIAS", "MERCADERIAS_DETALLE", "MOVIMIENTOS", "MOVIMIENTOS_APORTE", "MOVIMIENTOS_CAJA", "MOVIMIENTOS_CAJA_FUERTE", "MOVIMIENTOS_EGRESOS", "MOVIMIENTOS_GASTOS", "MOVIMIENTOS_IMPUESTOS", "MOVIMIENTOS_MERCADERIAS", "MOVIMIENTOS_RETIROS", "MOVIMIENTOS_SECCIONES", "MOVIMIENTOS_SUBTIPOS", "MOVIMIENTOS_TIPOEGRESO_TIPOGASTO", "MOVIMIENTOS_TIPOS", "NOTACREDITO", "NOTAPEDIDO", "NOTAPEDIDO_DETALLE", "PATENTES", "PATENTES_GRUPO", "PERFILES", "PRECIOS", "PRECIOS_VIEJO", "PRODUCTOS", "PRODUCTOS_CATEGORIAS", "PRODUCTOS_CATEGORIAS_VIEJO", "PRODUCTOS_SUBCATEGORIAS", "PRODUCTOS_SUBCATEGORIAS_VIEJO", "PRODUCTOS_VIEJO", "PROVEEDORES", "PROVEEDORES_VIEJO", "PROVINCIAS", "REL_EMPLEADOS_SUCURSALES", "REL_PERFILES_PATENTES", "REL_PRODUCTOS_AROMAS", "REL_PRODUCTOS_COLORES", "REL_PRODUCTOS_MATERIALES"}
            'Dim indicadorprogreso As Integer = Progreso.Maximum / (tablas.Length + 3)

            'inicio el proceso
            actualizado.Text = "Inicializacion de actualizacion"
            actualizado.SubItems.Add("INICIADO")
            actualizado.StateImageIndex = 2
            ListaEstado.Items.Add(actualizado)

            ''deshabilito las Constraint de la base de datos por las relaciones de FK
            'sincronizacion.DeshabilitarConstraint()

            'RegistrarDatosARemota(sincronizacion, indicadorprogreso)

            'Dim elementosSincronizados As Integer = RegistrarDatosALocal(sincronizacion, tablas, indicadorprogreso)

            ''habilito las Constraint de la base de datos
            'sincronizacion.HabilitarConstraint()

            ''finalizacion de proceso
            'Dim item As New ListViewItem
            'item.Text = "Se sincronizaron " + elementosSincronizados.ToString + " de " + tablas.Length.ToString() + " tablas disponibles."
            'item.SubItems.Add("FINALIZADO")
            'item.StateImageIndex = 2
            'ListaEstado.Items.Add(item)
            'ListaEstado.Refresh()

            Dim t As Task = Task.Run(Sub() A())
            t.Wait()

            Progreso.Value = 100
            btnSincronizar.Enabled = True
            Me.Cursor = Cursors.Default
            btn_Cerrar.Visible = True
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show("Se ha producido un error al sincronizar los datos. Por favor, Comuníquese con el administrador.", "Sincronización de Bases de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function SincronizarTabla(nombreTabla As String, sincronizacion As NegSincronizacion) As Boolean
        Dim estado As Integer = 0

        estado = sincronizacion.Sincronizar(nombreTabla)
        Return AgregarItemListaEstado("Actualizacion de " & nombreTabla & " LOCAL", estado)
    End Function

    Private Function RegistrarDatosALocal(sincronizacion As NegSincronizacion, tablas() As String, indicadorprogreso As Integer) As Integer
        Dim contador As Integer = 0

        For Each nombreTabla As String In tablas

            If (SincronizarTabla(nombreTabla, sincronizacion)) Then
                contador = contador + 1
            End If
            Progreso.Increment(indicadorprogreso)
        Next

        Return contador
    End Function

    Private Sub RegistrarDatosARemota(sincronizacion As NegSincronizacion, indicadorprogreso As Integer)
        sincronizacion.RegistrarVentasARemota(My.Settings.Sucursal)
        AgregarItemListaEstado("Actualizacion ventas en SERVIDOR", 1)
        Progreso.Increment(indicadorprogreso)

        sincronizacion.RegistrarDevolucionesARemota(My.Settings.Sucursal)
        AgregarItemListaEstado("Actualizacion devoluciones en SERVIDOR", 1)
        Progreso.Increment(indicadorprogreso)

        sincronizacion.RegistrarChequesARemota(My.Settings.Sucursal)
        AgregarItemListaEstado("Actualizacion cheques en SERVIDOR", 1)
        Progreso.Increment(indicadorprogreso)
    End Sub

    Private Function AgregarItemListaEstado(itemDescripcion As String, estado As Integer) As Boolean

        Dim Ok = True
        Dim itemusuarios As New ListViewItem
        itemusuarios.Text = itemDescripcion
        If estado = 1 Then
            itemusuarios.StateImageIndex = 0
            itemusuarios.SubItems.Add("CORRECTO")
        ElseIf estado = 2 Then
            itemusuarios.StateImageIndex = 0
            itemusuarios.SubItems.Add("SIN DATOS PARA SINCR.")
        Else
            Ok = False
            itemusuarios.StateImageIndex = 1
            itemusuarios.SubItems.Add("FALLIDO")
        End If
        ListaEstado.Items.Add(itemusuarios)
        ListaEstado.Items(ListaEstado.Items.Count - 1).EnsureVisible()
        ListaEstado.Refresh()
        Return Ok
    End Function

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        Me.Close()
    End Sub

    Private Async Sub A()
        Dim sincronizacion As New NegSincronizacion

        'indico la cantidad de tablas para la barra de progreso
        Dim tablas() As String = {"REL_REGISTRO_EMPLEADOS", "REL_REGISTRO_EMPLEADOS_AUSENTES", "REL_USUARIOS_PERFILES", "STOCK", "ADELANTOS", "STOCK_BITACORA", "ADICIONALES", "SUCURSALES", "AROMAS", "SUELDOS", "BANCOS", "TIPOS_COMISIONES", "CAJA_INICIAL", "TIPOS_EGRESOS", "CHEQUE", "TIPOS_PAGO", "CLIENTES", "TIPOS_VENTAS", "COLORES", "USUARIOS", "COMISIONES", "USUARIOS_MENSAJES", "CONDICIONES_IVA", "VENTAS", "CONSUMIDORFINAL", "VENTAS_DETALLE", "CUENTA_CORRIENTE", "DEPARTAMENTOS", "DEUDA", "DEVOLUCIONES", "DEVOLUCIONES_DETALLE", "EMPLEADOS", "EMPLEADOS_DEPOSITOS", "EMPLEADOS_RECIBOS", "EMPLEADOS_REGISTROS", "EMPLEADOS_TIPOS", "FACTURACION", "FERIADOS", "LISTA_GRUPO", "LISTA_PRECIO", "LOCALIDADES", "MATERIALES", "MERCADERIAS", "MERCADERIAS_DETALLE", "MOVIMIENTOS", "MOVIMIENTOS_APORTE", "MOVIMIENTOS_CAJA", "MOVIMIENTOS_CAJA_FUERTE", "MOVIMIENTOS_EGRESOS", "MOVIMIENTOS_GASTOS", "MOVIMIENTOS_IMPUESTOS", "MOVIMIENTOS_MERCADERIAS", "MOVIMIENTOS_RETIROS", "MOVIMIENTOS_SECCIONES", "MOVIMIENTOS_SUBTIPOS", "MOVIMIENTOS_TIPOEGRESO_TIPOGASTO", "MOVIMIENTOS_TIPOS", "NOTACREDITO", "NOTAPEDIDO", "NOTAPEDIDO_DETALLE", "PATENTES", "PATENTES_GRUPO", "PERFILES", "PRECIOS", "PRECIOS_VIEJO", "PRODUCTOS", "PRODUCTOS_CATEGORIAS", "PRODUCTOS_CATEGORIAS_VIEJO", "PRODUCTOS_SUBCATEGORIAS", "PRODUCTOS_SUBCATEGORIAS_VIEJO", "PRODUCTOS_VIEJO", "PROVEEDORES", "PROVEEDORES_VIEJO", "PROVINCIAS", "REL_EMPLEADOS_SUCURSALES", "REL_PERFILES_PATENTES", "REL_PRODUCTOS_AROMAS", "REL_PRODUCTOS_COLORES", "REL_PRODUCTOS_MATERIALES"}
        Dim indicadorprogreso As Integer = Progreso.Maximum / (tablas.Length + 3)

        'deshabilito las Constraint de la base de datos por las relaciones de FK
        sincronizacion.DeshabilitarConstraint()

        RegistrarDatosARemota(sincronizacion, indicadorprogreso)

        Dim elementosSincronizados As Integer = RegistrarDatosALocal(sincronizacion, tablas, indicadorprogreso)

        'habilito las Constraint de la base de datos
        sincronizacion.HabilitarConstraint()

        'finalizacion de proceso
        Dim item As New ListViewItem
        item.Text = "Se sincronizaron " + elementosSincronizados.ToString + " de " + tablas.Length.ToString() + " tablas disponibles."
        item.SubItems.Add("FINALIZADO")
        item.StateImageIndex = 2
        ListaEstado.Items.Add(item)
        ListaEstado.Refresh()

    End Sub

    Private Sub BW_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs)
        Progreso.Increment(e.ProgressPercentage)
    End Sub
End Class