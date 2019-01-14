Imports Entidades
Imports System.Linq
Imports System.Threading.Tasks
Imports Negocio
Imports Entidades.ClienteMayorista
Imports System.ComponentModel
Imports SistemaCinderella.VistaModelo.frmVentas
Imports Comunes.Comunes.Excepciones

Public Class frmVentas
    'Instancias
    Dim NegSucursal As New Negocio.NegSucursales
    Dim EntSucursal As Entidades.Sucursales
    Dim NegProductos As New Negocio.NegProductos
    Dim NegEmpleados As New Negocio.NegEmpleados
    Dim NegTiposPagos As New Negocio.NegTipoPago
    Dim NegVentas As New Negocio.NegVentas
    Dim NegStock As New Negocio.NegStock
    Dim NegComisiones As New Negocio.NegComisiones
    Dim NegMensajes As New Negocio.NegMensajes
    Dim NegErrores As New Negocio.NegManejadorErrores
    Dim negSenia As NegSenia = New NegSenia
    Dim NegFacturacion As NegFacturacion = New NegFacturacion
    Dim EntProducto As New Entidades.Productos
    Dim NegListasPrecio As New Negocio.NegListasPrecio
    Dim NegDevolucion As New Negocio.NegDevolucion
    Dim EntVentas As New Entidades.Ventas
    Dim EntDevolucion As New Entidades.Devolucion
    Dim Funciones As New Funciones

    Dim id_Sucursal As Integer
    Dim Nombre_Sucursal As String
    Dim ProductoCantidadAnterior As Integer
    Dim dsProductos As DataSet
    Dim PorcentajeFacturacionIngresado As Double = 100
    Public NotaPedido As NotaPedido
    Public Senia As Senia


    Private ventaVistaModelo As VistaModelo.frmVentas.Venta
    Private NuevaSenia As Senia
    Private id_Venta As Int64

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub


    'Funcion que calcula el total con descuento
    Sub CalcularTotales(tipoCliente As TipoCliente)
        ventaVistaModelo.SubTotal = ventaVistaModelo.ObtenerSubTotalFaltantePago()
        ventaVistaModelo.CalcularTotal(ventaVistaModelo.SubTotal)
        ventaVistaModelo.ActualizarTotalProducto(tipoCliente)
        HabilitarPagos()
    End Sub

    'Private Sub PosicionarListaPreciosSegunFormaDePago()
    '    If ventaVistaModelo.TipoClienteSeleccionado = TipoCliente.Minorista Then
    '        If (ventaVistaModelo.FormaPagoSeleccionado = 1) Then
    '            Dim tarjeta As KeyValuePair(Of Integer, String) = ventaVistaModelo.ListaPrecios.FirstOrDefault(Function(x) x.Value.Contains("Efectivo"))
    '            ventaVistaModelo.ListaPrecioSeleccionado = tarjeta.Key
    '            Cb_ListaPrecio.SelectedValue = tarjeta.Key
    '        Else
    '            Dim tarjeta As KeyValuePair(Of Integer, String) = ventaVistaModelo.ListaPrecios.FirstOrDefault(Function(x) x.Value.Contains("Tarjeta"))
    '            ventaVistaModelo.ListaPrecioSeleccionado = tarjeta.Key
    '            Cb_ListaPrecio.SelectedValue = tarjeta.Key
    '        End If
    '    End If
    'End Sub

    '    'Funcion que invoca el formulario de carga de cheques de forma asincornica para no bloquear el funcionamiento de la aplicacion a la espera de que se cierre la carga de los cheques 
    '    Async Function CargarCheques(ByVal Facturar As Boolean, ByVal MontoTotal As Double) As Task(Of Double)
    '        Me.Hide()

    '        Dim respuesta As Double = Await Task.Run((Function() (Me.abrirForm(Facturar, MontoTotal))))
    '        Me.Show()
    '        Return respuesta
    '    End Function

    '    'Funcion que muestra la pantalla de cheques
    '    Private Function abrirForm(factura As Boolean, monto As Double) As Double
    '        Dim frmChequesAltaMasiva As frmChequesAltaMasiva = New frmChequesAltaMasiva()
    '        frmChequesAltaMasiva.Facturado = factura
    '        frmChequesAltaMasiva.MontoVenta = monto
    '        frmChequesAltaMasiva.Focus()
    '        If (frmChequesAltaMasiva.ShowDialog() = Windows.Forms.DialogResult.OK) Then
    '            Return frmChequesAltaMasiva.DiferenciaPagoCheques
    '        End If
    '        Return -1
    '    End Function

    '#End Region

    'Cancela la venta, setea variables por default.
    Private Sub Btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If MessageBox.Show("Ésta seguro que desea cancelar la venta?", "Registro de Ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub Btn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Agregar.Click
        Me.Cursor = Cursors.WaitCursor
        BuscarProducto()
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub Btn_Cambiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cambiar.Click
        Me.Cursor = Cursors.WaitCursor
        BuscarProducto(True)
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub DG_Productos_KeyPressEnter(sender As Object, e As KeyEventArgs) Handles DG_Productos.KeyPressEnter
        If (String.IsNullOrEmpty(DG_Productos.CurrentCell.EditedFormattedValue)) Then

            Dim nombreColumna As String = DG_Productos.Columns(DG_Productos.CurrentCell.ColumnIndex).Name

            If (nombreColumna = "ProductoCantidad") Then
                DG_Productos.CurrentCell.Value = 1
            End If
            If (nombreColumna = "ProductoPrecio" OrElse nombreColumna = "ProductoMonto") Then
                DG_Productos.CurrentCell.Value = 0
            End If
        End If

        DG_Productos.NotifyCurrentCellDirty(True)
        DG_Productos.EndEdit()
        DG_Productos.NotifyCurrentCellDirty(False)

    End Sub

    Private Sub DG_Productos_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles DG_Productos.CellBeginEdit
        If DG_Productos.Columns(e.ColumnIndex).Name = "PorcentajeBonificacion" Then
            DG_Productos.CurrentCell.Style.Format = String.Format("N2")
            DG_Productos.CurrentCell.Value = DG_Productos.CurrentCell.Value * 100
        End If
    End Sub

    'Programo para cuando modifica la cantidad de un producto se actualice el grid.
    Private Sub DG_Productos_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Productos.CellEndEdit

        Dim productoEditado As VistaModelo.frmVentas.Producto = DG_Productos.CurrentRow.DataBoundItem
        Dim PorcentajeFacturacion As Double = ventaVistaModelo.PorcentajeFacturacion / 100

        If DG_Productos.Columns(e.ColumnIndex).Name = "PorcentajeBonificacion" Then
            DG_Productos.CurrentCell.Style.Format = String.Format("P")

            If (DG_Productos.CurrentCell.Value > 100) Then
                DG_Productos.CurrentCell.Value = 100
            End If

            DG_Productos.CurrentCell.Value = DG_Productos.CurrentCell.Value / 100
        End If

        If DG_Productos.Columns(e.ColumnIndex).Name = "ProductoCantidad" Then 'Si se modifica la cantidad de un producto
            'Verifico si hay stock disponible de la cantidad ingresada del producto
            If (Not NegStock.ComprobarStock(productoEditado.Id, productoEditado.Cantidad, id_Sucursal)) Then
                'Si no hay producto muestro un mensaje de alerta para que el usuario decida que hacer
                Dim frmStockFaltante As frmStockFaltante = New frmStockFaltante(productoEditado.Id, productoEditado.Codigo, id_Sucursal, productoEditado.Cantidad)
                'Si retorna Ok es porque el usuario decidio cargar una cantidad de productos
                If (frmStockFaltante.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                    productoEditado.Cantidad = frmStockFaltante.stockCargado
                Else
                    productoEditado.Cantidad = ProductoCantidadAnterior
                    Return
                End If
            End If
        End If

        productoEditado.ActualizarSubtotal(ventaVistaModelo.TipoClienteSeleccionado, PorcentajeFacturacion)
        ventaVistaModelo.ActualizarTotalProducto(ventaVistaModelo.TipoClienteSeleccionado)
        CalcularTotales(ventaVistaModelo.TipoClienteSeleccionado)
    End Sub

    'Sobresalto la celda que se está editando.
    Private Sub DG_Productos_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DG_Productos.EditingControlShowing
        RemoveHandler e.Control.KeyPress, New KeyPressEventHandler(AddressOf moneda_KeyPress)
        RemoveHandler e.Control.LostFocus, New EventHandler(AddressOf moneda_LostFocus)
        RemoveHandler e.Control.KeyPress, New KeyPressEventHandler(AddressOf cantidad_KeyPress)
        RemoveHandler e.Control.LostFocus, New EventHandler(AddressOf cantidad_LostFocus)

        If DG_Productos.Columns(DG_Productos.CurrentCell.ColumnIndex).Name = "ProductoPrecio" OrElse DG_Productos.Columns(DG_Productos.CurrentCell.ColumnIndex).Name = "ProductoMonto" Then
            'agrego los eventos al control TextBox 
            Dim textBox As TextBox = TryCast(e.Control, TextBox)
            If textBox IsNot Nothing Then
                AddHandler textBox.KeyPress, New KeyPressEventHandler(AddressOf moneda_KeyPress)
                AddHandler textBox.LostFocus, New EventHandler(AddressOf moneda_LostFocus)
            End If
        End If

        If DG_Productos.Columns(DG_Productos.CurrentCell.ColumnIndex).Name = "ProductoCantidad" Then
            'agrego los eventos al control TextBox 
            Dim textBox As TextBox = TryCast(e.Control, TextBox)
            If textBox IsNot Nothing Then
                AddHandler textBox.KeyPress, New KeyPressEventHandler(AddressOf cantidad_KeyPress)
                AddHandler textBox.LostFocus, New EventHandler(AddressOf cantidad_LostFocus)
            End If
        End If

        If DG_Productos.Columns(DG_Productos.CurrentCell.ColumnIndex).Name = "PorcentajeBonificacion" Then
            'agrego los eventos al control TextBox 
            Dim textBox As TextBox = TryCast(e.Control, TextBox)
            If textBox IsNot Nothing Then
                AddHandler textBox.KeyPress, New KeyPressEventHandler(AddressOf moneda_KeyPress)
                AddHandler textBox.LostFocus, New EventHandler(AddressOf cantidad_LostFocus)
            End If
        End If

        ' Obtenemos el estilo de la celda actual
        Dim style As DataGridViewCellStyle = e.CellStyle
        ' Mientras se edita la celda, aumentaremos la fuente
        ' y rellenaremos el color de fondo de la celda actual.
        With style
            .Font = New Font(style.Font.FontFamily, 10, FontStyle.Bold)
            .BackColor = Color.Red
            .ForeColor = Color.White
        End With
    End Sub

    Private Sub DG_Productos_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Productos.CellClick
        DG_Productos.EditMode = DataGridViewEditMode.EditProgrammatically
        DG_Productos.CurrentCell = DG_Productos.CurrentCell
        DG_Productos.BeginEdit(True)
        'Si va a iniciar a modifica la cantidad de un producto
        If DG_Productos.Columns(e.ColumnIndex).Name = "ProductoCantidad" Then
            'Guardo la cantidad antes de iniciar la modificacion
            ProductoCantidadAnterior = CType(DG_Productos.CurrentRow.DataBoundItem, VistaModelo.frmVentas.Producto).Cantidad
        End If
    End Sub

    'Cuando realiza un click dentro del datagrid de productos.
    Private Sub DG_Productos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Productos.CellContentClick
        If DG_Productos.Columns(e.ColumnIndex).Name = "ProductoQuitar" Then 'Si se hace click en el boton "eliminar" de la fila.
            Dim Result As DialogResult
            Result = MessageBox.Show("¿Está seguro que desea eliminar el item seleccionado?", "Registro de Ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Result = System.Windows.Forms.DialogResult.Yes Then 'Si acepta eliminar el item

                Dim productoQuitar As VistaModelo.frmVentas.Producto = DG_Productos.CurrentRow.DataBoundItem
                ventaVistaModelo.QuitarProducto(productoQuitar)
                ventaVistaModelo.ActualizarTotalProducto(ventaVistaModelo.TipoClienteSeleccionado)
                CalcularTotales(ventaVistaModelo.TipoClienteSeleccionado) 'Recalculo el Total y lo muestro en el label
                txt_CodigoBarra.Focus()
            End If
        End If
    End Sub

    Private Sub frmVentas_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
    End Sub

    'Cuando Carga el formulario de ventas.
    Private Sub frmVentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim sw As Stopwatch = New Stopwatch()

        sw.Start()

        DG_ProductosTotales.DefaultCellStyle.SelectionBackColor = DG_ProductosTotales.DefaultCellStyle.BackColor
        DG_ProductosTotales.DefaultCellStyle.SelectionForeColor = DG_ProductosTotales.DefaultCellStyle.ForeColor

        dgPagosTotales.DefaultCellStyle.SelectionBackColor = dgPagosTotales.DefaultCellStyle.BackColor
        dgPagosTotales.DefaultCellStyle.SelectionForeColor = dgPagosTotales.DefaultCellStyle.ForeColor

        RemoveHandler Cb_TipoCliente.SelectedIndexChanged, AddressOf Cb_TipoCliente_SelectedIndexChanged
        RemoveHandler Cb_Banco.SelectedIndexChanged, AddressOf Cb_Banco_SelectedIndexChanged
        RemoveHandler Cb_FormaPago.SelectedIndexChanged, AddressOf Cb_FormaPago_SelectedIndexChanged
        RemoveHandler Cb_NroCuota.SelectedIndexChanged, AddressOf Cb_NroCuota_SelectedIndexChanged

        'Sucursal default
        id_Sucursal = My.Settings("Sucursal")
        Nombre_Sucursal = My.Settings("NombreSucursal")

        CargraListaProductos()

        ventaVistaModelo = New VistaModelo.frmVentas.Venta()

        VentasBindingSource.DataSource = ventaVistaModelo

        ventaVistaModelo.Encargados = New BindingList(Of KeyValuePair(Of Integer, String))(ObtenerEncargados())
        ventaVistaModelo.Vendedores = New BindingList(Of KeyValuePair(Of Integer, String))(ObtenerVendedores())
        ventaVistaModelo.ListaPrecios = New BindingList(Of KeyValuePair(Of Integer, String))(ObtenerListaPrecios(TipoCliente.Minorista))
        ventaVistaModelo.ListaPrecioSeleccionado = ventaVistaModelo.ListaPrecios.First().Key
        ventaVistaModelo.FormasPagos = New BindingList(Of KeyValuePair(Of FormaPago, String))(ObtenerFormasPagos(TipoCliente.Minorista))
        ventaVistaModelo.ListaBancos = New BindingList(Of Tarjeta)(ObtenerListaBancos())
        ventaVistaModelo.FormaPagoSeleccionado = 1

        Cb_FormaPago.SelectedValue = ventaVistaModelo.FormaPagoSeleccionado

        DG_ProductosTotales.ClearSelection()

        HabilitarPagos()

        'Dim listaCuotas As List(Of CostoFinanciero) = New List(Of CostoFinanciero)()
        'listaCuotas.Add(New CostoFinanciero() With {.CostoFinancieroId = 0, .NumeroCuotas = 0})
        'ventaVistaModelo.ListaCuotas = New BindingList(Of CostoFinanciero)(listaCuotas)

        'If (NotaPedido IsNot Nothing) Then
        '    CargarNotaPedido()
        'End If

        'If (Senia IsNot Nothing) Then
        '    CargarSenia(DsVendedores, DsEncargados)
        'End If

        AddHandler Cb_TipoCliente.SelectedIndexChanged, AddressOf Cb_TipoCliente_SelectedIndexChanged
        AddHandler Cb_Banco.SelectedIndexChanged, AddressOf Cb_Banco_SelectedIndexChanged
        AddHandler Cb_FormaPago.SelectedIndexChanged, AddressOf Cb_FormaPago_SelectedIndexChanged
        AddHandler Cb_NroCuota.SelectedIndexChanged, AddressOf Cb_NroCuota_SelectedIndexChanged

        Debug.WriteLine(sw.ElapsedMilliseconds)
        sw.Stop()

    End Sub

    Private Sub CargraListaProductos()
        'Obtengo el listado de productos guardados en cache
        dsProductos = NegProductos.ListadoProductos(True)

        'Armo una lista que contiene los nombres y codigos de todos los producto
        Dim listaNombreCodigoProductos As AutoCompleteStringCollection = New AutoCompleteStringCollection()

        listaNombreCodigoProductos.AddRange(dsProductos.Tables(0).Rows.Cast(Of DataRow).Select(Function(x) x.Item("Nombre").ToString).ToArray())
        listaNombreCodigoProductos.AddRange(dsProductos.Tables(0).Rows.Cast(Of DataRow).Select(Function(x) x.Item("Codigo").ToString).ToArray())

        txt_CodigoBarra.AutoCompleteCustomSource = listaNombreCodigoProductos
    End Sub

    Private Function ObtenerFormasPagos(tipoCliente As TipoCliente) As List(Of KeyValuePair(Of FormaPago, String))
        Dim dsTiposPagos As DataSet = NegTiposPagos.ListadoTiposPagos()
        Dim dv As DataView = dsTiposPagos.Tables(0).DefaultView
        dv.Sort = "id_TipoPago"

        If tipoCliente = TipoCliente.Minorista Then
            dv.RowFilter = "id_TipoPago in (1, 2, 3)"
        Else
            dv.RowFilter = "id_TipoPago in (1, 4, 5)"
        End If

        dsTiposPagos = New DataSet()
        Dim dt As DataTable = dv.ToTable()
        dsTiposPagos.Tables.Add(dt)

        Dim opciones As List(Of KeyValuePair(Of FormaPago, String)) = New List(Of KeyValuePair(Of FormaPago, String))()

        For Each items As DataRow In dsTiposPagos.Tables(0).Rows
            opciones.Add(New KeyValuePair(Of FormaPago, String)(items("id_TipoPago"), items("Descripcion")))
        Next

        Return opciones
    End Function

    Private Function ObtenerListaBancos() As List(Of Tarjeta)
        Dim Tarjetas As List(Of Tarjeta) = NegTarjeta.TraerTarjetas().Where(Function(x) x.Habilitado).ToList()
        Tarjetas.Insert(0, New Tarjeta() With {.TarjetaId = 0, .Nombre = "Seleccione una Tarjeta..."})

        Return Tarjetas
    End Function

    Private Function ObtenerListaPrecios(tipoCliente As TipoCliente) As List(Of KeyValuePair(Of Integer, String))
        Dim dsListaPrecio As DataSet

        If tipoCliente = TipoCliente.Mayorista Then
            dsListaPrecio = NegListasPrecio.ListadoPreciosPorGrupo(3)
        Else
            dsListaPrecio = NegListasPrecio.ListadoPreciosPorGrupo(My.Settings("ListaPrecio"))
        End If

        Return ObtenerOpcionesParaCombo(dsListaPrecio.Tables(0), "id_Lista", "ListaPrecio", String.Empty)

    End Function

    Private Function ObtenerVendedores() As List(Of KeyValuePair(Of Integer, String))

        'busco los vendedores que asistieron hoy
        Dim DsVendedores = NegEmpleados.ListadoVendedoresSucursalAsistencia(id_Sucursal)

        'si no recupero ningun registro
        If DsVendedores.Tables(0).Rows.Count = 0 Then
            'busco los vendedores que pretenecen a la sucursal
            DsVendedores = NegEmpleados.ListadoVendedoresSucursal(id_Sucursal)
        End If

        'busco los encargados que asistieron hoy
        Dim DsEncargados = NegEmpleados.ListadoEncargadosSucursalAsistencia(id_Sucursal)

        'si no recupero ningun registro
        If DsEncargados.Tables(0).Rows.Count = 0 Then
            'busco los encargados que pretenecen a la sucursal
            DsEncargados = NegEmpleados.ListadoEncargadosSucursal(id_Sucursal)
        End If

        'Agrego los Encagados a la lista de vendedores ya que un encargado puede participar de la venta como vendedor
        DsVendedores.Tables(0).Merge(DsEncargados.Tables(0))

        Dim opcionesEncargado As List(Of KeyValuePair(Of Integer, String)) = ObtenerOpcionesParaCombo(DsVendedores.Tables(0), "id_Empleado", "NombreCompleto")

        'Si hay un unico encargado devuelvo esta unica opcion
        If DsVendedores.Tables(0).Rows.Count = 1 Then
            Return opcionesEncargado.Where(Function(x) x.Key > 0).ToList()
        End If

        Return opcionesEncargado

    End Function

    Private Function ObtenerEncargados() As List(Of KeyValuePair(Of Integer, String))

        'busco los encargados que asistieron hoy
        Dim DsEncargados = NegEmpleados.ListadoEncargadosSucursalAsistencia(id_Sucursal)

        'si no recupero ningun registro
        If DsEncargados.Tables(0).Rows.Count = 0 Then
            'busco los encargados que pretenecen a la sucursal
            DsEncargados = NegEmpleados.ListadoEncargadosSucursal(id_Sucursal)
        End If

        Dim opcionesEncargado As List(Of KeyValuePair(Of Integer, String)) = ObtenerOpcionesParaCombo(DsEncargados.Tables(0), "id_Empleado", "NombreCompleto")

        'Si hay un unico encargado devuelvo esta unica opcion
        If DsEncargados.Tables(0).Rows.Count = 1 Then
            Return opcionesEncargado.Where(Function(x) x.Key > 0).ToList()
        End If

        Return opcionesEncargado
    End Function

    Private Shared Function ObtenerOpcionesParaCombo(dataTable As DataTable, campoValor As String, campoDescripcion As String, Optional leyendaInicial As String = "Seleccione una opción", Optional leyendaSinDatos As String = "No hay opciones disponibles.") As List(Of KeyValuePair(Of Integer, String))
        Dim Opciones As List(Of KeyValuePair(Of Integer, String)) = New List(Of KeyValuePair(Of Integer, String))()

        For Each items As DataRow In dataTable.Rows
            Opciones.Add(New KeyValuePair(Of Integer, String)(items(campoValor), items(campoDescripcion)))
        Next

        If (Opciones.Count = 0) Then
            Opciones.Insert(0, New KeyValuePair(Of Integer, String)(0, leyendaSinDatos))
        ElseIf (Not String.IsNullOrEmpty(leyendaInicial)) Then
            Opciones.Insert(0, New KeyValuePair(Of Integer, String)(0, leyendaInicial))
        End If

        Return Opciones
    End Function

    '    'Carga la venta con la nota de pedido
    '    Private Sub CargarNotaPedido()
    '        Dim ds As DataSet = NegEmpleados.ListadoEmpleados()

    '        If Cb_Vendedores.Items.Contains(NotaPedido.id_Empleado) Then
    '            Cb_Vendedores.SelectedValue = NotaPedido.id_Empleado
    '        Else
    '            Dim drEmpleado As DataRow = ds.Tables(0).Rows.Cast(Of DataRow).Where(Function(x) x("id_empleado") = NotaPedido.id_Empleado).FirstOrDefault()
    '            If (drEmpleado IsNot Nothing) Then
    '                Dim tb As DataTable = Cb_Vendedores.DataSource
    '                Dim row As DataRow = tb.NewRow()
    '                row.Item("id_Empleado") = drEmpleado("id_empleado")
    '                row.Item("NombreCompleto") = String.Format("{0}, {1}", drEmpleado("apellido"), drEmpleado("nombre"))
    '                tb.Rows.Add(row)
    '                Cb_Vendedores.SelectedValue = drEmpleado("id_empleado")
    '            End If
    '        End If

    '        If Cb_Encargados.Items.Contains(NotaPedido.id_Encargado) Then
    '            Cb_Encargados.SelectedValue = NotaPedido.id_Encargado
    '        Else
    '            Dim drEmpleado As DataRow = ds.Tables(0).Rows.Cast(Of DataRow).Where(Function(x) x("id_empleado") = NotaPedido.id_Encargado).FirstOrDefault()
    '            If (drEmpleado IsNot Nothing) Then
    '                Dim tb As DataTable = Cb_Encargados.DataSource
    '                Dim row As DataRow = tb.NewRow()
    '                row.Item("id_Empleado") = drEmpleado("id_empleado")
    '                row.Item("NombreCompleto") = String.Format("{0}, {1}", drEmpleado("apellido"), drEmpleado("nombre"))
    '                tb.Rows.Add(row)
    '                Cb_Encargados.SelectedValue = drEmpleado("id_empleado")
    '            End If
    '        End If

    '        If NotaPedido.id_TipoVenta = 1 Then
    '            cb_Tipo.SelectedItem = "Minorista"
    '        Else
    '            cb_Tipo.SelectedItem = "Mayorista"
    '        End If

    '        Cb_ListaPrecio.SelectedValue = NotaPedido.id_ListaPrecio

    '        txt_PorcentajeBonificacion.Value = NotaPedido.PorcentajeDescuento

    '        'TODO: CARGAR FORMA DE PAGO DESDE NOTA DE PEDIDO
    '        'Cb_TipoPago.SelectedValue = NotaPedido.id_TipoPago
    '        'Cb_Tarjeta.SelectedValue = NotaPedido.Id_Tarjeta

    '        'If (Cb_Tarjeta.SelectedValue > 0) Then
    '        '    Dim costosFinancieros As List(Of CostoFinanciero) = NegTarjeta.TraerCostosFinancieros(Cb_Tarjeta.SelectedValue)
    '        '    CostoFinancieroBindingSource.DataSource = costosFinancieros
    '        '    Dim costoFinanciero As CostoFinanciero = costosFinancieros.Where(Function(x) x.NumeroCuotas = NotaPedido.CantidadCuotas).FirstOrDefault()
    '        '    If (costoFinanciero IsNot Nothing) Then
    '        '        Cb_NumeroCuota.SelectedValue = costoFinanciero.CostoFinancieroId
    '        '        Cb_NumeroCuota_SelectedIndexChanged(Nothing, Nothing)
    '        '    End If
    '        'End If

    '        'si la nota de pedido tiene un cliente
    '        If (NotaPedido.id_Cliente > 0) Then
    '            'cargo la informacion del cliente
    '            txt_id_Cliente.Text = NotaPedido.id_Cliente
    '            txt_RazonSocial.Text = NotaPedido.RazonSocialCliente
    '            PorcentajeFacturacionIngresado = NotaPedido.PorcentajeFacturacion
    '            txt_PorcentajeFacturacion.Text = PorcentajeFacturacionIngresado
    '        End If

    '        AgregarItemDesdeNotaPedido()

    '    End Sub

    '    Private Sub AgregarItemDesdeNotaPedido()

    '        Dim negNotaPedido As Negocio.NegNotaPedido = New Negocio.NegNotaPedido()

    '        Dim notaPedidoDetalles As List(Of NotaPedido_Detalle) = negNotaPedido.TraerDetalle(NotaPedido.id_NotaPedido)

    '        Dim NumeroFila As Integer = 0

    '        For Each detalle As NotaPedido_Detalle In notaPedidoDetalles

    '            Dim entProducto As Entidades.Productos = NegProductos.TraerProducto(detalle.id_Producto)

    '            NumeroFila += 1

    '            AgregarItemAGrilla(entProducto, 1, NumeroFila, detalle.Cantidad, detalle.Precio, detalle.Iva, detalle.Monto)
    '        Next

    '        CalcularTotales()
    '    End Sub

    '    Private Sub CargarSenia(DsVendedores As DataSet, DsEncargados As DataSet)
    '        Dim dsVentas As DataSet = NegVentas.TraerVenta(Senia.IdVentaSenia)

    '        If Cb_Vendedores.Items.Contains(Integer.Parse(dsVentas.Tables(0).Rows(0).Item("id_Empleado"))) Then
    '            Cb_Vendedores.SelectedValue = Integer.Parse(dsVentas.Tables(0).Rows(0).Item("id_Empleado"))
    '        Else
    '            Dim tb As DataTable = Cb_Vendedores.DataSource
    '            Dim row As DataRow = tb.NewRow()
    '            row.Item("id_Empleado") = dsVentas.Tables(0).Rows(0).Item("id_Empleado")
    '            row.Item("NombreCompleto") = dsVentas.Tables(0).Rows(0).Item("Empleado")
    '            tb.Rows.Add(row)
    '            Cb_Vendedores.SelectedValue = Integer.Parse(dsVentas.Tables(0).Rows(0).Item("id_Empleado"))
    '        End If

    '        Cb_Encargados.SelectedValue = Integer.Parse(dsVentas.Tables(0).Rows(0).Item("id_Encargado"))
    '        If Cb_Encargados.Items.Contains(Integer.Parse(dsVentas.Tables(0).Rows(0).Item("id_Encargado"))) Then
    '            Cb_Encargados.SelectedValue = Integer.Parse(dsVentas.Tables(0).Rows(0).Item("id_Encargado"))
    '        Else
    '            Dim tb As DataTable = Cb_Encargados.DataSource
    '            Dim row As DataRow = tb.NewRow()
    '            row.Item("id_Empleado") = dsVentas.Tables(0).Rows(0).Item("id_Encargado")
    '            row.Item("NombreCompleto") = dsVentas.Tables(0).Rows(0).Item("Encargado")
    '            tb.Rows.Add(row)
    '            Cb_Encargados.SelectedValue = Integer.Parse(dsVentas.Tables(0).Rows(0).Item("id_Encargado"))
    '        End If

    '        Cb_ListaPrecio.SelectedValue = Integer.Parse(dsVentas.Tables(0).Rows(0).Item("id_ListaPrecio"))

    '        Dim DsTiposPagos As DataSet = NegTiposPagos.ListadoTiposPagos()
    '        Dim TipoPagoRow = DsTiposPagos.Tables(0).Rows.Cast(Of DataRow).Where(Function(x) x.Item("Descripcion") = dsVentas.Tables(0).Rows(0).Item("TiposPago")).FirstOrDefault()
    '        If (TipoPagoRow IsNot Nothing) Then
    '            'TODO: Cargar forma de pago
    '            'Cb_TipoPago.SelectedValue = TipoPagoRow.Item("id_TipoPago")
    '        End If

    '        cb_Tipo.SelectedItem = dsVentas.Tables(0).Rows(0).Item("TiposVenta")

    '        Dim Subtotal = CType(dsVentas.Tables(0).Rows(0).Item("Subtotal"), Decimal)
    '        Dim Descuento = CType(dsVentas.Tables(0).Rows(0).Item("Descuento"), Decimal)
    '        Dim Total = CType(dsVentas.Tables(0).Rows(0).Item("Precio_Total"), Decimal)
    '        Dim SeniaMonto = CType(dsVentas.Tables(0).Rows(0).Item("MontoSenia"), Decimal)
    '        Dim PorcentajeFacturacion = CType(dsVentas.Tables(0).Rows(0).Item("PorcentajeFacturacion"), Decimal)

    '        AgregarItemDesdeSenia()

    '        If (dsVentas.Tables(0).Rows(0).Item("TiposVenta") = "Minorista") Then
    '            txt_SeniaMinorista.Text = Format(SeniaMonto, "###0.00")
    '            lblSeniaMinorista.Visible = True
    '            lblSeniaMinoristaMoneda.Visible = True
    '            txt_SeniaMinorista.Visible = True
    '            txt_SubtotalMinorista.Text = Format(Subtotal, "###0.00")
    '            txt_DescuentoMinorista.Text = Format(Descuento, "###0.00")
    '            txt_TotalMinorista.Text = Format(Total - SeniaMonto, "###0.00")
    '            txt_PorcentajeBonificacion.Text = Math.Round((CType(txt_DescuentoMinorista.Text, Double) / CalcularPrecioTotal()) * 100, 2, MidpointRounding.ToEven)
    '        Else
    '            txt_DescuentoMayorista.Text = Format(Descuento, "###0.00")
    '            txt_SeniaMayorista.Text = Format(SeniaMonto, "###0.00")
    '            lblSeniaMayorista.Visible = True
    '            lblSeniaMayoristaMoneda.Visible = True
    '            txt_SeniaMayorista.Visible = True
    '            txt_SubtotalMayorista.Text = Format(Subtotal, "###0.00")
    '            txt_ivaTotalMayorista.Text = Format(Subtotal * 0.21 * (PorcentajeFacturacion / 100), "###0.00")
    '            txt_TotalMayorista.Text = Format(Total - SeniaMonto, "###0.00")

    '            txt_id_Cliente.Text = Senia.IdClienteMayorista
    '            txt_RazonSocial.Text = Senia.RazonSocial
    '            PorcentajeFacturacionIngresado = PorcentajeFacturacion
    '            txt_PorcentajeFacturacion.Text = PorcentajeFacturacionIngresado
    '            txt_PorcentajeBonificacion.Text = Math.Round((CType(txt_DescuentoMayorista.Text, Double) / CalcularPrecioTotal()) * 100, 2, MidpointRounding.ToEven)
    '        End If

    '        cb_Tipo.Enabled = False
    '        txt_id_Cliente.Enabled = False
    '        txt_RazonSocial.Enabled = False
    '        Btn_BuscarCliente.Enabled = False
    '        txt_PorcentajeFacturacion.Enabled = False

    '        Btn_Finalizar.Visible = True
    '        Btn_NotaPedido.Visible = False
    '        GB_Pagos.Visible = False

    '    End Sub

    '    Private Sub AgregarItemDesdeSenia()
    '        Dim NumeroFila As Integer = 0
    '        Dim dsVentasDetalle = NegVentas.TraerVentaDetalle(Senia.IdVentaSenia)

    '        For Each ventaDetalle In dsVentasDetalle.Tables(0).Rows

    '            Dim entProducto As Entidades.Productos = NegProductos.TraerProducto(ventaDetalle.item("id_Producto"))

    '            NumeroFila += 1
    '            Dim precio As Decimal = CType(ventaDetalle.item("Precio").ToString, Decimal)
    '            Dim iva As Decimal = CType(ventaDetalle.item("Iva").ToString, Decimal)
    '            Dim monto As Decimal = CType(ventaDetalle.item("Monto").ToString, Decimal)
    '            Dim cantidad As Decimal = CType(ventaDetalle.item("Cantidad").ToString, Decimal)

    '            AgregarItemAGrilla(entProducto, 1, NumeroFila, cantidad, precio, iva, monto)
    '        Next

    '    End Sub

    'Dependiendo para que tipo de cliente es la venta, muestro o oculto el panel de clientes.
    Private Sub Cb_TipoCliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_TipoCliente.SelectedIndexChanged
        RemoveHandler Cb_TipoCliente.SelectedIndexChanged, AddressOf Cb_TipoCliente_SelectedIndexChanged
        ventaVistaModelo.TipoClienteSeleccionado = Cb_TipoCliente.SelectedValue

        ventaVistaModelo.FormasPagos = New BindingList(Of KeyValuePair(Of FormaPago, String))(ObtenerFormasPagos(ventaVistaModelo.TipoClienteSeleccionado))
        ventaVistaModelo.Pagos.Clear()

        If ventaVistaModelo.TipoClienteSeleccionado = TipoCliente.Mayorista Then
            DG_Productos.Columns("ProductoMonto").ReadOnly = True
            DG_Productos.Columns("ProductoPrecio").ReadOnly = False
            DG_Productos.Columns("ProductoPrecio").Visible = True
            DG_Productos.Columns("ProductoIVA").Visible = True

            DG_ProductosTotales.Columns("ProductoPrecioTotal").Visible = True
            DG_ProductosTotales.Columns("ProductoIVATotal").Visible = True
            Gb_Cliente.Enabled = True

            For Each producto As VistaModelo.frmVentas.Producto In ventaVistaModelo.Productos
                producto.PorcentajeBonificacion = ventaVistaModelo.ProcentajeBonificacionClienteMayorista / 100
            Next
        Else
            'Minorista
            txt_RazonSocial.Clear()
            txt_id_Cliente.Clear()
            DG_Productos.Columns("ProductoMonto").ReadOnly = False
            DG_Productos.Columns("ProductoPrecio").ReadOnly = True
            DG_Productos.Columns("ProductoPrecio").Visible = False
            DG_Productos.Columns("ProductoIVA").Visible = False

            DG_ProductosTotales.Columns("ProductoPrecioTotal").Visible = False
            DG_ProductosTotales.Columns("ProductoIVATotal").Visible = False
            Gb_Cliente.Enabled = False
        End If

        ventaVistaModelo.PorcentajeFacturacion = 100
        ventaVistaModelo.Descuento = 0

        ventaVistaModelo.ListaPrecios = New BindingList(Of KeyValuePair(Of Integer, String))(ObtenerListaPrecios(ventaVistaModelo.TipoClienteSeleccionado))
        ventaVistaModelo.ListaPrecioSeleccionado = ventaVistaModelo.ListaPrecios.First.Key
        'Cb_ListaPrecio.SelectedValue = ventaVistaModelo.ListaPrecioSeleccionado
        'PosicionarListaPreciosSegunFormaDePago()

        ventaVistaModelo.ActualizarPrecioProductos()
        CalcularTotales(ventaVistaModelo.TipoClienteSeleccionado)
        ventaVistaModelo.ActualizarTotalProducto(ventaVistaModelo.TipoClienteSeleccionado)
        AddHandler Cb_TipoCliente.SelectedIndexChanged, AddressOf Cb_TipoCliente_SelectedIndexChanged
    End Sub


    'Si desea buscar un cliente mayorista se visualiza el formulario.
    Private Sub Btn_BuscarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_BuscarCliente.Click
        Me.Cursor = Cursors.WaitCursor
        Dim frmBuscarClienteMayorista As frmBuscarClienteMayorista = New frmBuscarClienteMayorista()
        frmBuscarClienteMayorista.ShowDialog()


        If frmBuscarClienteMayorista.clienteMayorista IsNot Nothing Then
            ventaVistaModelo.IdClienteMayorista = frmBuscarClienteMayorista.clienteMayorista.Id
            ventaVistaModelo.NombreClienteMayorista = frmBuscarClienteMayorista.clienteMayorista.RazonSocial
            ventaVistaModelo.ListaPrecioSeleccionado = frmBuscarClienteMayorista.clienteMayorista.IdListaPrecio
            ventaVistaModelo.ProcentajeBonificacionClienteMayorista = frmBuscarClienteMayorista.clienteMayorista.Bonificacion

            PorcentajeFacturacionIngresado = If(frmBuscarClienteMayorista.clienteMayorista.Lista = 0, 100, frmBuscarClienteMayorista.clienteMayorista.Lista)
            txt_PorcentajeFacturacion.Text = PorcentajeFacturacionIngresado

            For Each producto As VistaModelo.frmVentas.Producto In ventaVistaModelo.Productos
                producto.PorcentajeBonificacion = ventaVistaModelo.ProcentajeBonificacionClienteMayorista / 100
            Next

            ventaVistaModelo.ActualizarPrecioProductos()
            CalcularTotales(ventaVistaModelo.TipoClienteSeleccionado)

        End If
        Me.Cursor = Cursors.Arrow
    End Sub


    'Al finalizar la venta.
    Private Sub Btn_Finalizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Finalizar.Click
        Try
            If (ventaVistaModelo.PorcentajeFacturacion > 0 AndAlso MessageBox.Show("¿Desea facturar la venta?", "Registro de Ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) = vbYes) Then
                facturar()
            End If

            FinalizarVenta(Nothing, Nothing)

        Catch ex As ValidationErrorException
            MessageBox.Show(ex.Message, "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Se ha encontrado un error al finalizar la venta. Por favor, vuelva a intentar más tarde o contáctese con el Administrador ", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub facturar()
        ''cuando se cierre el formulario redirijo a la funcion de registrar para que genere la venta
        AddHandler frmFacturar.FormClosed, AddressOf FinalizarVenta

        frmFacturar.VentaDetalle = ventaVistaModelo.Productos.Select(Function(x) New Ventas_Detalle() With {
            .Cantidad = x.Cantidad,
            .id_Producto = x.Id,
            .Iva = x.IVA,
            .Monto = x.Monto,
            .Nombre = x.Nombre,
            .Precio = x.Precio}).ToList()
        frmFacturar.MdiParent = Funciones.ControlInstancia(MDIContenedor)
        frmFacturar.id_Cliente = ventaVistaModelo.IdClienteMayorista
        frmFacturar.Monto = ventaVistaModelo.Pagos.Sum(Function(x) x.SubTotal)
        frmFacturar.Descuento = ventaVistaModelo.Pagos.Sum(Function(x) x.Descuento)
        frmFacturar.CostoFinanciero = ventaVistaModelo.Pagos.Sum(Function(x) x.CostoFinanciero)
        frmFacturar.IvaTotal = ventaVistaModelo.Pagos.Sum(Function(x) x.IVA)
        frmFacturar.SubTotal = ventaVistaModelo.Pagos.Sum(Function(x) x.Total)
        frmFacturar.TipoPago = "!!!!TIPO DE PAGO VER!!!!!"
        frmFacturar.TipoCliente = ventaVistaModelo.TipoClienteSeleccionado
        frmFacturar.EsSenia = False
        frmFacturar.PorcentajeFacturacion = ventaVistaModelo.PorcentajeFacturacion / 100

        Me.Hide()
        frmFacturar.Show()
    End Sub

    Public Sub FinalizarVenta(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim facturas As List(Of Facturacion) = New List(Of Facturacion)()
        Dim facturada As Boolean = False 'Variable que indica si la venta ´facturará o no.

        If (sender IsNot Nothing) Then
            Me.Show()
            Dim fmrfactura As frmFacturar = CType(sender, frmFacturar)

            ' Si confirmo la factura cargo los valores para registrar la factura
            If fmrfactura.DialogResult = DialogResult.OK Then
                facturas = fmrfactura.Facturas
                facturada = True

                ' Si hubo un problema en el proceso de facturacion marco como que no se facturo para que se registre la venta
            ElseIf fmrfactura.DialogResult = DialogResult.Abort Then
                facturada = False

                ' Si se calcelo la pantalla de facturacion no registro la venta
            Else
                Return
            End If
        End If


        ''TODO:REGISTRAR CHEQUES!!!




    End Sub

    'Public Async Sub FinalizarVenta(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        Me.Cursor = Cursors.WaitCursor

    '        'Obtengo toda la informacion.
    '        Dim facturas As List(Of Facturacion) = New List(Of Facturacion)()
    '        Dim TipoVenta As Integer = 0 'Tipo de Venta.
    '        Dim TipoPago As Integer = 1 'TODO:CARGAR TIPOS DE PAGOS Cb_TipoPago.SelectedValue 'Tipo de Pago.
    '        Dim id_Empleado As Integer = Cb_Vendedores.SelectedValue 'ID de Vendedor.
    '        Dim id_Encargado As Integer = Cb_Encargados.SelectedValue 'ID de Encargado.
    '        Dim id_Cliente As Integer = 0 'ID de Cliente.
    '        Dim id_ListaPrecio As Integer = Cb_ListaPrecio.SelectedValue
    '        Dim Id_Tarjeta As Integer = 0
    '        Dim NumerCuotas As Integer = 0
    '        Dim facturada As Boolean = False 'Variable que indica si la venta ´facturará o no.
    '        Dim Descuento As Double = 0 'Descuento ingresado.
    '        Dim CostoFinanciero As Double = 0
    '        Dim SubTotal As Double = 0 'Monto total de la venta.
    '        Dim MontoTotal As Double = 0 'Monto total de la venta menos el descuento.
    '        Dim CantidadTotal As Integer = CalcularCantidadTotal() 'Cantidad total de articulos.
    '        Dim DiferenciaPagoCheque As Double = 0 'Es el importe que falta cubrir de los cheques recividos como pago
    '        Dim PorcentajeFacturacion As Double = 0
    '        Dim IvaTotal As Double = 0 'Iva total de la vental
    '        Dim MontoSenia As Double = 0
    '        Dim IdClienteMinorista As Int64 = 0

    '        If (sender IsNot Nothing) Then
    '            Me.Show()
    '            Dim fmrfactura As frmFacturar = CType(sender, frmFacturar)

    '            ' Si confirmo la factura cargo los valores para registrar la factura
    '            If fmrfactura.DialogResult = DialogResult.OK Then
    '                facturas = fmrfactura.Facturas
    '                facturada = True

    '                ' Si hubo un problema en el proceso de facturacion marco como que no se facturo para que se registre la venta
    '            ElseIf fmrfactura.DialogResult = DialogResult.Abort Then
    '                facturada = False

    '                ' Si se calcelo la pantalla de facturacion no registro la venta
    '            Else
    '                Return
    '            End If
    '        End If

    '        'Seteo TipoVenta
    '        If cb_Tipo.SelectedItem = "Minorista" Then
    '            TipoVenta = 1
    '            PorcentajeFacturacion = 1
    '            SubTotal = CType(txt_SubtotalMinorista.Text, Decimal)
    '            Descuento = CType(txt_DescuentoMinorista.Text, Decimal)
    '            CostoFinanciero = CType(txt_CFTMinorista.Text, Decimal)
    '            MontoTotal = CType(txt_TotalMinorista.Text, Decimal)
    '            MontoSenia = CType(txt_SeniaMinorista.Text, Decimal)
    '            IdClienteMinorista = If(NotaPedido IsNot Nothing, NotaPedido.Id_ConsumidorFinal, 0)
    '        Else
    '            TipoVenta = 2
    '            PorcentajeFacturacion = CType(txt_PorcentajeFacturacion.Text, Decimal) / 100
    '            Descuento = CType(txt_DescuentoMayorista.Text, Decimal)
    '            CostoFinanciero = CType(txt_CFTMayorista.Text, Decimal)
    '            SubTotal = CType(txt_SubtotalMayorista.Text, Decimal)
    '            IvaTotal = CType(txt_ivaTotalMayorista.Text, Decimal)
    '            MontoTotal = CType(txt_TotalMayorista.Text, Decimal)
    '            MontoSenia = CType(txt_SeniaMayorista.Text, Decimal)
    '        End If

    '        'TODO:CARGAR numero de cuotas y tarjeta
    '        'si el pago es con tarjeta de credito
    '        'If TipoPago = 2 Then
    '        '    Dim entCostoFinanciero As CostoFinanciero = CType(Cb_NumeroCuota.SelectedItem, CostoFinanciero)
    '        '    Id_Tarjeta = entCostoFinanciero.Tarjeta
    '        '    NumerCuotas = entCostoFinanciero.NumeroCuotas
    '        'End If

    '        'Seteo ID Cliente
    '        If txt_id_Cliente.Text = "" Then
    '            id_Cliente = 0
    '        Else
    '            id_Cliente = CInt(txt_id_Cliente.Text)
    '        End If

    '        'Si el tipo de pago es cheque abro la ventana para cargar ingresar el cheque
    '        If TipoPago = 4 Then
    '            'invoca la pantalla de carga de cheques y quedo a la espera del cierre
    '            DiferenciaPagoCheque = Await CargarCheques(facturada, MontoTotal)
    '            'en caso que la diferencia de pago en cheques sea -1 es porque el usuario cancelo la carga de los cheques y se cancela la alta de la venta
    '            If (DiferenciaPagoCheque = -1) Then
    '                Return
    '            End If
    '        End If

    '        Dim id_Venta As Int64 = RegistrarVenta(facturada, TipoVenta, TipoPago, id_Empleado, id_Encargado, id_Cliente, IdClienteMinorista, Id_Tarjeta, NumerCuotas, PorcentajeFacturacion * 100, id_ListaPrecio, Descuento, CostoFinanciero, SubTotal, MontoTotal, CantidadTotal, DiferenciaPagoCheque, MontoSenia, False)

    '        If id_Venta > 0 Then
    '            'si esto realizando una venta a partir de una seña
    '            If (Me.Senia IsNot Nothing) Then
    '                Senia.IdVentaRetiro = id_Venta
    '                Senia.Entregada = True
    '                negSenia.ActualizarSenia(Senia)

    '                ActualizarStockDesdeSenia()
    '            Else
    '                ActualizarStock()
    '            End If

    '            For Each factura As Facturacion In facturas
    '                factura.id_Venta = id_Venta
    '                NegFacturacion.NuevaFacturacion(factura)
    '            Next

    '            RegistrarComisionesEncargadoEmpleado(id_Empleado, id_Encargado, id_Cliente, MontoTotal, id_Venta)

    '            'Seteo el cursor.
    '            Me.Cursor = Cursors.Arrow

    '            'Muestro Mensaje.
    '            AutoClosingMessageBox.Show("La venta ha sido registrada correctamente.", "Registro de Ventas", 1000, MessageBoxButtons.OK, MessageBoxIcon.Question)

    '            If (NotaPedido IsNot Nothing) Then
    '                Dim negNotaPedido As NegNotaPedido = New NegNotaPedido()
    '                NotaPedido.Vendida = True
    '                NotaPedido.id_Cliente = id_Cliente
    '                NotaPedido.id_Empleado = id_Empleado
    '                NotaPedido.id_Encargado = id_Encargado
    '                If Not negNotaPedido.ActualizarNotaPedido(NotaPedido, ObtenerDetalleNotaPedido(), id_Sucursal) Then
    '                    MessageBox.Show("La nota de pedido no se a podido cerrar. Por favor, Comuniquese con el administrador.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                Else
    '                    Dim frmNotaPedido As frmNotaPedidoAdministracion = Funciones.ControlInstancia(frmNotaPedidoAdministracion)
    '                    'Elimino la nota de pedido del la grilla de Administracion Notas Pedido
    '                    frmNotaPedido.RemoverNotaPedido(NotaPedido)
    '                End If
    '            End If

    '            'Si no se factura el 100% de la venta armo un presupuesto por el monto no facturado
    '            If facturada AndAlso PorcentajeFacturacion < 1 AndAlso MessageBox.Show("¿Desea Generar un presupuesto por el monto no facturado?", "Registro de Ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
    '                'TODO: PASAR FORMA DE PAGO
    '                'AltaPresupuesto(id_Venta, TipoVenta, TipoPago, Cb_TipoPago.Text, id_Empleado, id_Encargado, id_Cliente, id_ListaPrecio, Id_Tarjeta, NumerCuotas, Descuento, CostoFinanciero, SubTotal, MontoTotal, PorcentajeFacturacion, MontoSenia)
    '                AltaPresupuesto(id_Venta, TipoVenta, TipoPago, "FORMA PAGO", id_Empleado, id_Encargado, id_Cliente, id_ListaPrecio, Id_Tarjeta, NumerCuotas, Descuento, CostoFinanciero, SubTotal, MontoTotal, PorcentajeFacturacion, MontoSenia)
    '            End If

    '            If cb_Tipo.SelectedItem = "Mayorista" AndAlso MessageBox.Show("¿Desea Generar un Resumen de Venta?", "Registro de Ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
    '                Dim frmReporteResumenVenta As frmReporteResumenVenta = New frmReporteResumenVenta()
    '                frmReporteResumenVenta.idVenta = id_Venta
    '                frmReporteResumenVenta.MdiParent = Funciones.ControlInstancia(MDIContenedor)
    '                frmReporteResumenVenta.Show()
    '            End If

    '            'Fin de la venta.
    '            Me.Close()

    '            'si esto realizando una venta a partir de una seña
    '            If (Me.Senia IsNot Nothing) Then
    '                Me.Close()
    '                Funciones.ControlInstancia(frmSeniaAdministracion).Close()
    '            End If

    '        Else
    '            'Muestro Mensaje.
    '            MessageBox.Show("Se ha producido un error al registrar la venta. Por favor, Comuniquese con el administrador.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        End If

    '        Me.Cursor = Cursors.Arrow

    '    Catch ex As Exception
    '        'Seteo el cursor.
    '        Me.Cursor = Cursors.Arrow
    '        'Muestro Mensaje.
    '        MessageBox.Show("Se ha producido un error al confirmar la venta. Por favor, Comuniquese con el administrador.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    '    Private Sub AltaPresupuesto(id_Venta As Int64, TipoVenta As Integer, TipoPago As Integer, DescripcionTipoPago As String, id_Empleado As Integer, id_Encargado As Integer, id_Cliente As Integer, id_ListaPrecio As Integer, id_Banco As Integer, CantidadCuotas As Integer, Descuento As Double, CostoFinanciero As Double, SubTotal As Double, MontoTotal As Double, PorcentajeFacturacion As Double, MontoSenia As Double)
    '        Dim MontoSeñaSinIva As Double = MontoSenia / ((0.21 * PorcentajeFacturacion) + 1)
    '        Dim DescuentoTotal As Double = Descuento + MontoSeñaSinIva

    '        Dim Presupuesto As Presupuesto = New Presupuesto()
    '        Presupuesto.Fecha = Date.Now
    '        Presupuesto.id_Venta = id_Venta
    '        Presupuesto.id_ClienteMayorista = id_Cliente
    '        Presupuesto.id_Empleado = id_Empleado
    '        Presupuesto.id_Encargado = id_Encargado
    '        Presupuesto.id_ListaPrecio = id_ListaPrecio
    '        Presupuesto.id_Sucursal = id_Sucursal
    '        Presupuesto.id_TipoPago = TipoPago
    '        Presupuesto.DescripcionTipoPago = DescripcionTipoPago
    '        Presupuesto.id_TipoVenta = TipoVenta
    '        Presupuesto.id_Tarjeta = id_Banco
    '        Presupuesto.CantidadCuotas = CantidadCuotas
    '        Presupuesto.Total = Math.Round((CalcularPrecioTotal() - DescuentoTotal + CostoFinanciero) * (1 - PorcentajeFacturacion), 2)
    '        Presupuesto.SubTotal = Math.Round((CalcularPrecioTotal()) * (1 - PorcentajeFacturacion), 2)
    '        Presupuesto.Descuento = Math.Round(DescuentoTotal * (1 - PorcentajeFacturacion), 2)
    '        Presupuesto.CostoFinanciero = Math.Round(CostoFinanciero * (1 - PorcentajeFacturacion), 2)
    '        Presupuesto.VendedorNombreyApellido = Cb_Vendedores.Text
    '        Presupuesto.RazonSocialClienteMayorista = txt_RazonSocial.Text

    '        Dim NegPresupuesto As NegPresupuesto = New NegPresupuesto()

    '        Presupuesto.id_Presupuesto = NegPresupuesto.Alta(Presupuesto, ObtenerDetallePresupuesto(1 - PorcentajeFacturacion))

    '        Dim frmReportePresupuesto As frmReportePresupuesto = New frmReportePresupuesto()
    '        frmReportePresupuesto.presupuesto = Presupuesto
    '        frmReportePresupuesto.MdiParent = Funciones.ControlInstancia(MDIContenedor)
    '        frmReportePresupuesto.Show()
    '    End Sub

    '    Private Sub AltaPresupuestoSenia(id_Venta As Int64, TipoVenta As Integer, TipoPago As Integer, DescripcionTipoPago As String, id_Empleado As Integer, id_Encargado As Integer, id_Cliente As Integer, id_ListaPrecio As Integer, PorcentajeFacturacion As Double, MontoSenia As Double, id_Banco As Integer, CantidadCuotas As Integer, CostoFinanciero As Double)
    '        Dim MontoSeñaSinIva As Double = MontoSenia / ((0.21 * PorcentajeFacturacion) + 1)

    '        Dim Presupuesto As Presupuesto = New Presupuesto()
    '        Presupuesto.id_Venta = id_Venta
    '        Presupuesto.Fecha = Date.Now
    '        Presupuesto.id_ClienteMayorista = id_Cliente
    '        Presupuesto.id_Empleado = id_Empleado
    '        Presupuesto.id_Encargado = id_Encargado
    '        Presupuesto.id_ListaPrecio = id_ListaPrecio
    '        Presupuesto.id_Sucursal = id_Sucursal
    '        Presupuesto.id_TipoPago = TipoPago
    '        Presupuesto.id_TipoVenta = TipoVenta
    '        Presupuesto.Total = Math.Round(MontoSeñaSinIva * (1 - PorcentajeFacturacion), 2)
    '        Presupuesto.SubTotal = 0
    '        Presupuesto.Descuento = 0
    '        Presupuesto.VendedorNombreyApellido = Cb_Vendedores.Text
    '        Presupuesto.RazonSocialClienteMayorista = txt_RazonSocial.Text
    '        Presupuesto.DescripcionTipoPago = DescripcionTipoPago
    '        Presupuesto.id_Tarjeta = id_Banco
    '        Presupuesto.CantidadCuotas = CantidadCuotas
    '        Presupuesto.CostoFinanciero = CostoFinanciero


    '        Dim NegPresupuesto As NegPresupuesto = New NegPresupuesto()

    '        Dim presupuestoDetalle As List(Of Presupuesto_Detalle) = New List(Of Presupuesto_Detalle)

    '        Presupuesto.id_Presupuesto = NegPresupuesto.Alta(Presupuesto, ObtenerDetallePresupuesto(0))

    '        Dim frmReportePresupuesto As frmReportePresupuesto = New frmReportePresupuesto()
    '        frmReportePresupuesto.presupuesto = Presupuesto
    '        frmReportePresupuesto.MdiParent = Funciones.ControlInstancia(MDIContenedor)
    '        frmReportePresupuesto.Show()
    '    End Sub

    '    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_NotaPedido.Click
    '        Try
    '            If (Not VentaValida("nota de pedido")) Then
    '                Return
    '            End If

    '            If (NotaPedido IsNot Nothing) Then
    '                If MessageBox.Show("¿Desea actualizar la nota de pedido?", "Registro de Ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
    '                    ActualizarNotaPedido()

    '                    Funciones.ControlInstancia(frmNotaPedidoAdministracion).MdiParent = Funciones.ControlInstancia(MDIContenedor)
    '                    Funciones.ControlInstancia(frmNotaPedidoAdministracion).Show()
    '                End If
    '            Else
    '                If MessageBox.Show("¿Desea efectuar la nota de pedido?", "Registro de Ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
    '                    CrearNuevaNotaPedido()
    '                End If
    '            End If

    '        Catch ex As Exception
    '            'Seteo el cursor.
    '            Me.Cursor = Cursors.Arrow
    '            'Muestro Mensaje.
    '            MessageBox.Show("Se ha producido un error al generado la nota de pedido. Por favor, Comuniquese con el administrador.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        End Try
    '    End Sub

    '    Private Sub CrearNuevaNotaPedido()
    '        Dim TipoPago As Integer = 1 'TODO:CARGAR TIPOS DE PAGOS Cb_TipoPago.SelectedValue 'Tipo de Pago.
    '        Dim id_Empleado As Integer = Cb_Vendedores.SelectedValue 'ID de Vendedor.
    '        Dim id_Encargado As Integer = Cb_Encargados.SelectedValue 'ID de Encargado.
    '        Dim id_ListaPrecio As Integer = Cb_ListaPrecio.SelectedValue
    '        Dim ConsumidorFinal As ConsumidorFinal = New ConsumidorFinal()
    '        Dim ClienteNegocio As NegClienteMayorista = New NegClienteMayorista()
    '        Dim NotaPedidoNegocio As Negocio.NegNotaPedido = New Negocio.NegNotaPedido()
    '        Dim NotaPedido As NotaPedido = New NotaPedido()

    '        If cb_Tipo.SelectedItem = "Minorista" Then
    '            Dim frmDatosClienteMinorista As frmDatosClienteMinorista = New frmDatosClienteMinorista()
    '            If frmDatosClienteMinorista.ShowDialog() = DialogResult.Cancel Then
    '                Return
    '            End If

    '            ConsumidorFinal.Apellido = frmDatosClienteMinorista.txt_Apellido.Text
    '            ConsumidorFinal.Email = String.Empty
    '            ConsumidorFinal.Nombre = frmDatosClienteMinorista.txt_Nombre.Text

    '            NotaPedido.Id_ConsumidorFinal = ClienteNegocio.AltaClienteConsumidorFinal(ConsumidorFinal, id_Sucursal)
    '            NotaPedido.id_TipoVenta = 1
    '            NotaPedido.PrecioTotal = CType(txt_TotalMinorista.Text, Decimal)
    '            NotaPedido.id_Cliente = 0
    '            NotaPedido.RazonSocialCliente = String.Empty
    '            NotaPedido.PorcentajeFacturacion = 0
    '            NotaPedido.ConsumidorFinalNombreYApellido = ConsumidorFinal.Apellido + ", " + ConsumidorFinal.Nombre
    '        Else
    '            NotaPedido.id_TipoVenta = 2
    '            NotaPedido.PrecioTotal = CType(txt_TotalMayorista.Text, Decimal)
    '            NotaPedido.id_Cliente = CInt(txt_id_Cliente.Text)
    '            NotaPedido.RazonSocialCliente = txt_RazonSocial.Text
    '            NotaPedido.PorcentajeFacturacion = txt_PorcentajeFacturacion.Text
    '            NotaPedido.PorcentajeDescuento = txt_PorcentajeBonificacion.Value
    '            NotaPedido.Id_ConsumidorFinal = 0
    '            NotaPedido.ConsumidorFinalNombreYApellido = String.Empty
    '        End If

    '        NotaPedido.id_Empleado = id_Empleado
    '        NotaPedido.id_Encargado = id_Encargado
    '        NotaPedido.id_ListaPrecio = id_ListaPrecio
    '        NotaPedido.id_Sucursal = id_Sucursal
    '        NotaPedido.id_TipoPago = TipoPago
    '        NotaPedido.Vendida = False

    '        'TODO:CARGAR numero de cuotas y tarjeta
    '        'si el pago es con tarjeta de credito
    '        'If TipoPago = 2 Then
    '        '    Dim entCostoFinanciero As CostoFinanciero = CType(Cb_NumeroCuota.SelectedItem, CostoFinanciero)
    '        '    NotaPedido.Id_Tarjeta = entCostoFinanciero.Tarjeta
    '        '    NotaPedido.CantidadCuotas = entCostoFinanciero.NumeroCuotas
    '        'End If

    '        NotaPedido.Fecha = DateTime.Now
    '        NotaPedido.id_NotaPedido = NotaPedidoNegocio.NuevaNotaPedido(NotaPedido, ObtenerDetalleNotaPedido(), id_Sucursal)
    '        Me.Cursor = Cursors.Arrow
    '        AutoClosingMessageBox.Show("Se ha generado la nota de pedido correctamente.", "Registro de Ventas", 1000, MessageBoxButtons.OK, MessageBoxIcon.Question)
    '        Me.Close()

    '    End Sub

    '    Private Sub ActualizarNotaPedido()
    '        Dim TipoPago As Integer = 1 'TODO:CARGAR TIPOS DE PAGOS Cb_TipoPago.SelectedValue 'Tipo de Pago.
    '        Dim id_Empleado As Integer = Cb_Vendedores.SelectedValue 'ID de Vendedor.
    '        Dim id_Encargado As Integer = Cb_Encargados.SelectedValue 'ID de Encargado.
    '        Dim id_ListaPrecio As Integer = Cb_ListaPrecio.SelectedValue
    '        Dim ConsumidorFinal As ConsumidorFinal = New ConsumidorFinal()
    '        Dim ClienteNegocio As NegClienteMayorista = New NegClienteMayorista()
    '        Dim NotaPedidoNegocio As Negocio.NegNotaPedido = New Negocio.NegNotaPedido()

    '        If cb_Tipo.SelectedItem = "Minorista" Then
    '            ConsumidorFinal = ClienteNegocio.ConsultaClienteConsumidorFinal(NotaPedido.Id_ConsumidorFinal)
    '            Dim frmDatosClienteMinorista As frmDatosClienteMinorista = New frmDatosClienteMinorista()
    '            frmDatosClienteMinorista.txt_Apellido.Text = ConsumidorFinal.Apellido
    '            frmDatosClienteMinorista.txt_Nombre.Text = ConsumidorFinal.Nombre


    '            If frmDatosClienteMinorista.ShowDialog() = DialogResult.Cancel Then
    '                Return
    '            End If

    '            If (ConsumidorFinal.Apellido <> frmDatosClienteMinorista.txt_Apellido.Text Or ConsumidorFinal.Nombre <> frmDatosClienteMinorista.txt_Nombre.Text) Then
    '                ConsumidorFinal.Apellido = frmDatosClienteMinorista.txt_Apellido.Text
    '                ConsumidorFinal.Email = String.Empty
    '                ConsumidorFinal.Nombre = frmDatosClienteMinorista.txt_Nombre.Text

    '                NotaPedido.Id_ConsumidorFinal = ClienteNegocio.AltaClienteConsumidorFinal(ConsumidorFinal, id_Sucursal)
    '            End If

    '            NotaPedido.id_TipoVenta = 1
    '            NotaPedido.PrecioTotal = CType(txt_TotalMinorista.Text, Decimal)
    '            NotaPedido.id_Cliente = 0
    '            NotaPedido.RazonSocialCliente = String.Empty
    '            NotaPedido.PorcentajeFacturacion = 0
    '            NotaPedido.ConsumidorFinalNombreYApellido = ConsumidorFinal.Apellido + ", " + ConsumidorFinal.Nombre
    '        Else
    '            NotaPedido.id_TipoVenta = 2
    '            NotaPedido.PrecioTotal = CType(txt_TotalMayorista.Text, Decimal)
    '            NotaPedido.id_Cliente = CInt(txt_id_Cliente.Text)
    '            NotaPedido.PorcentajeFacturacion = CDbl(txt_PorcentajeFacturacion.Text)
    '            NotaPedido.RazonSocialCliente = txt_RazonSocial.Text
    '            NotaPedido.Id_ConsumidorFinal = 0
    '            NotaPedido.ConsumidorFinalNombreYApellido = String.Empty
    '        End If

    '        'TODO:CARGAR numero de cuotas y tarjeta
    '        'si el pago es con tarjeta de credito
    '        'If TipoPago = 2 Then
    '        '    Dim entCostoFinanciero As CostoFinanciero = CType(Cb_NumeroCuota.SelectedItem, CostoFinanciero)
    '        '    NotaPedido.Id_Tarjeta = entCostoFinanciero.Tarjeta
    '        '    NotaPedido.CantidadCuotas = entCostoFinanciero.NumeroCuotas
    '        'End If

    '        NotaPedido.EmpleadoNombreyApellido = Cb_Vendedores.Text
    '        NotaPedido.id_Empleado = id_Empleado
    '        NotaPedido.id_Encargado = id_Encargado
    '        NotaPedido.id_ListaPrecio = id_ListaPrecio
    '        NotaPedido.id_Sucursal = id_Sucursal
    '        NotaPedido.id_TipoPago = TipoPago
    '        NotaPedido.Vendida = False

    '        NotaPedidoNegocio.ActualizarNotaPedido(NotaPedido, ObtenerDetalleNotaPedido(), id_Sucursal)
    '        Me.Cursor = Cursors.Arrow
    '        MessageBox.Show("Se ha actualizado la nota de pedido correctamente.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        Dim form As Form = Funciones.ControlInstancia(frmNotaPedidoAdministracion)
    '        If (form IsNot Nothing) Then
    '            form.Refresh()
    '            form.Show()
    '        End If
    '        Close()
    '    End Sub

    '    Private Function ObtenerDetalleVenta() As List(Of Ventas_Detalle)
    '        Dim detalleVenta As List(Of Entidades.Ventas_Detalle) = New List(Of Entidades.Ventas_Detalle)()

    '        For i = 0 To DG_Productos.Rows.Count - 1
    '            If CInt(DG_Productos.Rows(i).Cells.Item("ID").Value) > 0 And CInt(DG_Productos.Rows(i).Cells.Item("CANTIDAD").Value) > 0 Then
    '                Dim detalle As Entidades.Ventas_Detalle = New Entidades.Ventas_Detalle()
    '                detalle.Nombre = DG_Productos.Rows(i).Cells.Item("NOMBRE").Value
    '                detalle.Cantidad = CInt(DG_Productos.Rows(i).Cells.Item("CANTIDAD").Value)
    '                detalle.id_Producto = CInt(DG_Productos.Rows(i).Cells.Item("ID").Value)
    '                detalle.Precio = CDbl(DG_Productos.Rows(i).Cells.Item("PRECIO").Value)
    '                detalle.Iva = CDbl(DG_Productos.Rows(i).Cells.Item("IVA").Value)
    '                detalle.Monto = CDbl(DG_Productos.Rows(i).Cells.Item("MONTO").Value)

    '                detalleVenta.Add(detalle)
    '            End If
    '        Next

    '        Return detalleVenta
    '    End Function

    '    Private Function ObtenerDetalleNotaPedido() As List(Of NotaPedido_Detalle)
    '        Dim detalleNotaPedido As List(Of Entidades.NotaPedido_Detalle) = New List(Of Entidades.NotaPedido_Detalle)()

    '        For i = 0 To DG_Productos.Rows.Count - 1
    '            If CInt(DG_Productos.Rows(i).Cells.Item("ID").Value) > 0 And CInt(DG_Productos.Rows(i).Cells.Item("CANTIDAD").Value) > 0 Then
    '                Dim detalle As Entidades.NotaPedido_Detalle = New Entidades.NotaPedido_Detalle()
    '                detalle.Cantidad = CInt(DG_Productos.Rows(i).Cells.Item("CANTIDAD").Value)
    '                detalle.id_Producto = CInt(DG_Productos.Rows(i).Cells.Item("ID").Value)
    '                detalle.Precio = CDbl(DG_Productos.Rows(i).Cells.Item("PRECIO").Value)
    '                detalle.Iva = CDbl(DG_Productos.Rows(i).Cells.Item("IVA").Value)
    '                detalle.Monto = CDbl(DG_Productos.Rows(i).Cells.Item("MONTO").Value)

    '                detalleNotaPedido.Add(detalle)
    '            End If
    '        Next

    '        Return detalleNotaPedido
    '    End Function

    '    Private Function ObtenerDetallePresupuesto(porcentaje As Double) As List(Of Presupuesto_Detalle)
    '        Dim detalleNotaPedido As List(Of Entidades.Presupuesto_Detalle) = New List(Of Entidades.Presupuesto_Detalle)()

    '        For i = 0 To DG_Productos.Rows.Count - 1
    '            If CInt(DG_Productos.Rows(i).Cells.Item("ID").Value) > 0 And CInt(DG_Productos.Rows(i).Cells.Item("CANTIDAD").Value) > 0 Then
    '                Dim detalle As Entidades.Presupuesto_Detalle = New Entidades.Presupuesto_Detalle()
    '                detalle.Cantidad = CInt(DG_Productos.Rows(i).Cells.Item("CANTIDAD").Value)
    '                detalle.id_Producto = CInt(DG_Productos.Rows(i).Cells.Item("ID").Value)
    '                detalle.Precio = CDbl(DG_Productos.Rows(i).Cells.Item("PRECIO").Value) * porcentaje
    '                detalle.Iva = 0
    '                detalle.Monto = CDbl(DG_Productos.Rows(i).Cells.Item("PRECIO").Value) * porcentaje

    '                detalleNotaPedido.Add(detalle)
    '            End If
    '        Next

    '        Return detalleNotaPedido
    '    End Function

    '    Private Sub BtnSenia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSenia.Click
    '        Try
    '            ''Obtengo toda la informacion.
    '            Dim facturas As List(Of Facturacion) = New List(Of Facturacion)()
    '            Dim id_Empleado As Integer = Cb_Vendedores.SelectedValue 'ID de Vendedor.
    '            Dim id_Encargado As Integer = Cb_Encargados.SelectedValue 'ID de Encargado.
    '            Dim TipoVenta As Integer = 0 'Tipo de Venta.
    '            Dim TipoPago As Integer = 1 'TODO:CARGAR TIPOS DE PAGOS Cb_TipoPago.SelectedValue 'Tipo de Pago.
    '            Dim id_Cliente As Integer = 0 'ID de Cliente.
    '            Dim Descuento As Double = 0 'Descuento ingresado.
    '            Dim CostoFinanciero As Double = 0
    '            Dim SubTotal As Double = 0 'Monto total de la venta.
    '            Dim MontoTotal As Double = 0 'Monto total de la venta menos el descuento.
    '            Dim PorcentajeFacturacion As Double = 0
    '            Dim IvaTotal As Double = 0 'Iva total de la vental
    '            Dim MontoSenia As Double = 0
    '            Dim DiferenciaPagoCheque As Double = 0 'Es el importe que falta cubrir de los cheques recividos como pago
    '            Dim Facturar As Boolean = False 'Variable que indica si la venta ´facturará o no.
    '            Dim dtProductos As DataTable = ConvertirDataGridViewADataTable(DG_Productos)
    '            Dim MontoTotalSinDescuento As Double = 0 'Monto total de la venta.

    '            If (Not VentaReserva()) Then
    '                Return
    '            End If

    '            'Seteo TipoVenta
    '            If cb_Tipo.SelectedItem = "Minorista" Then
    '                TipoVenta = 1
    '                PorcentajeFacturacion = 1
    '                MontoTotalSinDescuento = CType(txt_SubtotalMinorista.Text, Decimal)
    '                Descuento = CType(txt_DescuentoMinorista.Text, Decimal)
    '                MontoTotal = CType(txt_TotalMinorista.Text, Decimal) - CType(txt_CFTMinorista.Text, Decimal)
    '                'TODO:obtener el monto de la seña
    '                'MontoSenia = CType(txt_Senia.Text, Decimal)
    '            Else
    '                TipoVenta = 2
    '                PorcentajeFacturacion = CType(txt_PorcentajeFacturacion.Text, Decimal) / 100
    '                Descuento = CType(txt_DescuentoMayorista.Text, Decimal)
    '                MontoTotalSinDescuento = CType(txt_SubtotalMayorista.Text, Decimal) - CType(txt_CFTMayorista.Text, Decimal)
    '                IvaTotal = CType(txt_ivaTotalMayorista.Text, Decimal) - (CType(txt_CFTMayorista.Text, Decimal) * 0.21)
    '                MontoTotal = CType(txt_TotalMayorista.Text, Decimal) - (CType(txt_CFTMayorista.Text, Decimal) * 1.21)
    '                'TODO:obtener el monto de la seña
    '                'MontoSenia = CType(txt_Senia.Text, Decimal)
    '            End If

    '            If txt_id_Cliente.Text = "" Then
    '                id_Cliente = 0
    '            Else
    '                id_Cliente = CInt(txt_id_Cliente.Text)
    '            End If

    '            If MessageBox.Show("¿Ésta seguro que desea efectuar la reserva?", "Registro de Ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then

    '                'TODO: PASAR FORMAS DE PAGO
    '                'Dim frmSeniaDatos As frmSeniaDatos = New frmSeniaDatos(If(TipoVenta = 1, TipoCliente.Minorista, TipoCliente.Mayorista), id_Empleado, id_Empleado, Cb_TipoPago.SelectedText, Facturar, id_Cliente, MontoTotalSinDescuento, Descuento, MontoSenia, MontoTotal, IvaTotal, PorcentajeFacturacion * 100, dtProductos, Date.Now)
    '                Dim frmSeniaDatos As frmSeniaDatos = New frmSeniaDatos(If(TipoVenta = 1, TipoCliente.Minorista, TipoCliente.Mayorista), id_Empleado, id_Empleado, "FORMA DE PAGO", Facturar, id_Cliente, MontoTotalSinDescuento, Descuento, MontoSenia, MontoTotal, IvaTotal, PorcentajeFacturacion * 100, dtProductos, Date.Now)
    '                If (Not frmSeniaDatos.ShowDialog() = DialogResult.OK) Then
    '                    Return
    '                End If

    '                NuevaSenia = frmSeniaDatos.Senia

    '                If (MessageBox.Show("¿Desea facturar la reserva?", "Registro de Ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) = vbYes) Then
    '                    MostrarPantallaFacturacionSenia(TipoPago, id_Cliente, MontoSenia, CostoFinanciero, PorcentajeFacturacion, ObtenerDetalleVenta(), AddressOf FinalizarSenia)
    '                Else
    '                    FinalizarSenia(Nothing, Nothing)
    '                End If
    '            End If

    '        Catch ex As Exception
    '            'Seteo el cursor.
    '            Me.Cursor = Cursors.Arrow
    '            'Muestro Mensaje.
    '            MessageBox.Show("Se ha producido un error al confirmar la venta. Por favor, Comuniquese con el administrador.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        End Try
    '    End Sub

    '    Private Async Sub FinalizarSenia(sender As Object, e As EventArgs)
    '        Try
    '            Me.Cursor = Cursors.WaitCursor

    '            'Obtengo toda la informacion.
    '            Dim facturas As List(Of Facturacion) = New List(Of Facturacion)()
    '            Dim TipoVenta As Integer = 0 'Tipo de Venta.
    '            Dim TipoPago As Integer = 1 'TODO:CARGAR TIPOS DE PAGOS Cb_TipoPago.SelectedValue 'Tipo de Pago.Cb_TipoPago.SelectedValue 'Tipo de Pago.
    '            Dim id_Empleado As Integer = Cb_Vendedores.SelectedValue 'ID de Vendedor.
    '            Dim id_Encargado As Integer = Cb_Encargados.SelectedValue 'ID de Encargado.
    '            Dim id_ListaPrecio As Integer = Cb_ListaPrecio.SelectedValue
    '            Dim id_Cliente As Integer = 0 'ID de Cliente.
    '            Dim Id_Tarjeta As Integer = 0
    '            Dim NumerCuotas As Integer = 0
    '            Dim facturada As Boolean = False 'Variable que indica si la venta ´facturará o no.
    '            Dim Descuento As Double = 0 'Descuento ingresado.
    '            Dim CostoFinanciero As Double = 0 'TODO: CARGAR EL COSTO FINANCIERO DE LA SEÑA CType(txt_SeniaCostoFinanciero.Text, Decimal)
    '            Dim MontoTotalSinDescuento As Double = 0 'Monto total de la venta.
    '            Dim MontoTotal As Double = 0 'Monto total de la venta menos el descuento.
    '            Dim MontoSenia As Double = 0 'Monto total de la seña.
    '            Dim CantidadTotal As Integer = CalcularCantidadTotal() 'Cantidad total de articulos.
    '            Dim TipoPagoControlador As String = "" 'Variable que se imprime en el tique fiscal.
    '            Dim DiferenciaPagoCheque As Double = 0 'Es el importe que falta cubrir de los cheques recividos como pago
    '            Dim IvaTotal As Double = 0 'Iva total de la vental
    '            Dim PorcentajeFacturacion As Double = 0
    '            Dim IdClienteMinorista As Int64 = 0

    '            If (sender IsNot Nothing) Then
    '                Me.Show()
    '                Dim fmrfactura As frmFacturar = CType(sender, frmFacturar)

    '                ' Si confirmo la factura cargo los valores para registrar la factura
    '                If fmrfactura.DialogResult = DialogResult.OK Then
    '                    facturas = fmrfactura.Facturas
    '                    facturada = True

    '                    ' Si hubo un problema en el proceso de facturacion marco como que no se facturo para que se registre la venta
    '                ElseIf fmrfactura.DialogResult = DialogResult.Abort Then
    '                    facturada = False

    '                    ' Si se calcelo la pantalla de facturacion no registro la venta
    '                Else
    '                    Return
    '                End If
    '            End If



    '            'Seteo TipoVenta
    '            If cb_Tipo.SelectedItem = "Minorista" Then
    '                TipoVenta = 1
    '                PorcentajeFacturacion = 1
    '                MontoTotalSinDescuento = CType(txt_SubtotalMinorista.Text, Decimal)
    '                Descuento = CType(txt_DescuentoMinorista.Text, Decimal)
    '                MontoTotal = CType(txt_TotalMinorista.Text, Decimal) - CType(txt_CFTMinorista.Text, Decimal)
    '                MontoSenia = 0 'TODO:OBTENER MONTO SEÑIA CType(txt_Senia.Text, Decimal)
    '                IdClienteMinorista = If(NotaPedido IsNot Nothing, NotaPedido.Id_ConsumidorFinal, 0)
    '            Else
    '                TipoVenta = 2
    '                PorcentajeFacturacion = CType(txt_PorcentajeFacturacion.Text, Decimal) / 100
    '                Descuento = CType(txt_DescuentoMayorista.Text, Decimal)
    '                MontoTotalSinDescuento = CType(txt_SubtotalMayorista.Text, Decimal) - CType(txt_CFTMayorista.Text, Decimal)
    '                IvaTotal = CType(txt_ivaTotalMayorista.Text, Decimal) - (CType(txt_CFTMayorista.Text, Decimal) * 0.21)
    '                MontoTotal = CType(txt_TotalMayorista.Text, Decimal) - (CType(txt_CFTMayorista.Text, Decimal) * 1.21)
    '                MontoSenia = 0 'TODO:OBTENER MONTO SEÑIA CType(txt_Senia.Text, Decimal)
    '            End If

    '            'TODO:CARGAR numero de cuotas y tarjeta
    '            'si el pago es con tarjeta de credito
    '            'If TipoPago = 2 Then
    '            '    Dim entCostoFinanciero As CostoFinanciero = CType(Cb_NumeroCuota.SelectedItem, CostoFinanciero)
    '            '    Id_Tarjeta = entCostoFinanciero.Tarjeta
    '            '    NumerCuotas = entCostoFinanciero.NumeroCuotas
    '            'End If

    '            'Seteo ID Cliente
    '            If txt_id_Cliente.Text = "" Then
    '                id_Cliente = 0
    '            Else
    '                id_Cliente = CInt(txt_id_Cliente.Text)
    '            End If

    '            'Si el tipo de pago es cheque abro la ventana para cargar ingresar el cheque
    '            If TipoPago = 4 Then
    '                'invoca la pantalla de carga de cheques y quedo a la espera del cierre
    '                DiferenciaPagoCheque = Await CargarCheques(facturada, MontoSenia)
    '                'en caso que la diferencia de pago en cheques sea -1 es porque el usuario cancelo la carga de los cheques y se cancela la alta de la venta
    '                If (DiferenciaPagoCheque = -1) Then
    '                    Return
    '                End If
    '            End If

    '            Dim id_Venta As Int64 = RegistrarVenta(facturada, TipoVenta, TipoPago, id_Empleado, id_Encargado, id_Cliente, IdClienteMinorista, Id_Tarjeta, NumerCuotas, PorcentajeFacturacion * 100, id_ListaPrecio, Descuento, CostoFinanciero, MontoTotalSinDescuento, MontoTotal, CantidadTotal, DiferenciaPagoCheque, MontoSenia, True)
    '            If id_Venta > 0 Then

    '                ActualizarStock()

    '                NuevaSenia.IdVentaSenia = id_Venta
    '                negSenia.CrearSenia(NuevaSenia)
    '                NuevaSenia = Nothing

    '                For Each factura As Facturacion In facturas
    '                    factura.id_Venta = id_Venta
    '                    NegFacturacion.NuevaFacturacion(factura)
    '                Next

    '                RegistrarComisionesEncargadoEmpleado(id_Empleado, id_Encargado, id_Cliente, MontoSenia, id_Venta)

    '                'Seteo el cursor.
    '                Me.Cursor = Cursors.Arrow

    '                'Muestro Mensaje.
    '                AutoClosingMessageBox.Show("La reserva ha sido generada correctamente.", "Registro de Ventas", 1000, MessageBoxButtons.OK, MessageBoxIcon.Question)

    '                'Si no se factura el 100% de la venta armo un presupuesto por el monto no facturado
    '                If facturada AndAlso PorcentajeFacturacion < 1 AndAlso MessageBox.Show("¿Desea Generar un presupuesto por el monto no facturado?", "Registro de Ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
    '                    'TODO: PASAR FORMAS DE PAGOS
    '                    'AltaPresupuestoSenia(id_Venta, TipoVenta, TipoPago, Cb_TipoPago.Text, id_Empleado, id_Encargado, id_Cliente, id_ListaPrecio, PorcentajeFacturacion, MontoSenia, Id_Tarjeta, NumerCuotas, CostoFinanciero)
    '                    AltaPresupuestoSenia(id_Venta, TipoVenta, TipoPago, "FORMA DE PAGO", id_Empleado, id_Encargado, id_Cliente, id_ListaPrecio, PorcentajeFacturacion, MontoSenia, Id_Tarjeta, NumerCuotas, CostoFinanciero)
    '                End If

    '                'Fin de la venta.
    '                Me.Close()
    '            Else
    '                'Muestro Mensaje.
    '                MessageBox.Show("Se ha producido un error al registrar la venta. Por favor, Comuniquese con el administrador.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            End If

    '            Me.Cursor = Cursors.Arrow

    '        Catch ex As Exception
    '            'Seteo el cursor.
    '            Me.Cursor = Cursors.Arrow
    '            'Muestro Mensaje.
    '            MessageBox.Show("Se ha producido un error al confirmar la venta. Por favor, Comuniquese con el administrador.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        End Try
    '    End Sub

    '    Private Function ConvertirDataGridViewADataTable(dataGridView As DataGridView) As DataTable
    '        Dim dtProductos As New DataTable

    '        For Each column As DataGridViewColumn In dataGridView.Columns
    '            dtProductos.Columns.Add(column.Name)
    '        Next

    '        For Each row As DataGridViewRow In dataGridView.Rows
    '            Dim dataRow As DataRow = dtProductos.NewRow()
    '            For Each cell As DataGridViewCell In row.Cells
    '                dataRow(cell.ColumnIndex) = cell.Value
    '            Next
    '            dtProductos.Rows.Add(dataRow)
    '        Next

    '        Return dtProductos
    '    End Function

    Private Function VentaReserva() As Boolean
        'TODO: REVISAR TODAS LAS VALIDACIONES
        'Dim TotalProductos As Integer = DG_Productos.Rows.Count 'Total de productos cargados.

        ''Chequeo que haya al menos un producto cargado.
        'If TotalProductos <= 0 Then
        '    'Muestro Mensaje.
        '    MessageBox.Show("La reserva no puede efectuarse. No hay productos cargados !!", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        '    Return False
        'End If
        ''Tiene al menos un producto.
        ''Chequeo que haya asignado al menos un vendedor a la venta.
        'If Cb_Vendedores.SelectedValue <= 0 Then
        '    'Muestro Mensaje.
        '    MessageBox.Show("La reserva no puede efectuarse. Debe seleccionar un vendedor responsable de la venta.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        '    Return False
        'End If
        'If Cb_Encargados.SelectedValue <= 0 Then
        '    'Muestro Mensaje.
        '    MessageBox.Show("La reserva no puede efectuarse. Debe seleccionar un encargado responsable de la venta.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        '    Return False
        'End If
        'If Cb_TipoPago.SelectedValue <= 0 Then
        '    'Muestro Mensaje.
        '    MessageBox.Show("La reserva no puede efectuarse. Debe seleccionar un tipo de pago a la venta.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        '    Return False
        'End If
        ''Chequeo que el monto de la seña sea mayor a 0
        'If CType(txt_Senia.Text, Decimal) = 0 Then
        '    'Muestro Mensaje.
        '    MessageBox.Show("La reserva no puede efectuarse. El monto de la seña debe ser mayor a cero.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        '    Return False
        'End If

        'If (cb_Tipo.SelectedItem = "Minorista") Then
        '    'Chequeo que el monto de la seña no supere el monto de la venta
        '    If CType(txt_Senia.Text, Decimal) > CType(txt_TotalMinorista.Text, Decimal) Then
        '        'Muestro Mensaje.
        '        MessageBox.Show("La reserva no puede efectuarse. El monto de la seña debe ser menor al importe a abonar.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        '        Return False
        '    End If
        'Else
        '    If CType(txt_Senia.Text, Decimal) > CType(txt_TotalMayorista.Text, Decimal) Then
        '        'Muestro Mensaje.
        '        MessageBox.Show("La reserva no puede efectuarse. El monto de la seña debe ser menor al importe a abonar.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        '        Return False
        '    End If
        'End If
        Return True
    End Function

    '    Private Function RegistrarVenta(facturado As Boolean, TipoVenta As Integer, TipoPago As Integer, id_Empleado As Integer, id_Encargado As Integer, id_Cliente As Integer, id_ClienteMinorista As Int64, Id_Tarjeta As Integer, CantidadCuotas As Integer, PorcentajeFacturacion As Double, id_ListaPrecio As Integer, Descuento As Double, CostoFinanciero As Double, MontoTotalSinDescuento As Double, MontoTotal As Double, CantidadTotal As Integer, DiferenciaPagoCheque As Double, MontoSenia As Double, EsSenia As Boolean) As Int64

    '        'Seteo el cursor.
    '        Me.Cursor = Cursors.WaitCursor

    '        'Datos de la venta.
    '        EntVentas.id_Cliente = id_Cliente
    '        EntVentas.id_ClienteMinorista = id_ClienteMinorista
    '        EntVentas.PorcentajeFacturacion = PorcentajeFacturacion
    '        EntVentas.id_Empleado = id_Empleado
    '        EntVentas.id_Encargado = id_Encargado
    '        EntVentas.id_Sucursal = id_Sucursal
    '        EntVentas.id_TipoPago = TipoPago
    '        EntVentas.id_TipoVenta = TipoVenta
    '        EntVentas.id_ListaPrecio = id_ListaPrecio
    '        EntVentas.id_Tarjeta = Id_Tarjeta
    '        EntVentas.CantidadCuotas = CantidadCuotas
    '        EntVentas.CantidadTotal = CantidadTotal
    '        EntVentas.Descuento = Descuento
    '        EntVentas.CostoFinanciero = CostoFinanciero
    '        EntVentas.SubTotal = MontoTotalSinDescuento
    '        EntVentas.PrecioTotal = MontoTotal - DiferenciaPagoCheque
    '        EntVentas.Anulado = 0
    '        EntVentas.Habilitado = 1
    '        EntVentas.Facturado = If(facturado, 1, 0)
    '        EntVentas.DiferenciaPagoCheque = DiferenciaPagoCheque
    '        EntVentas.MontoSenia = MontoSenia
    '        EntVentas.Senia = EsSenia

    '        'Numero de Venta.
    '        Dim id_Venta As Int64 = NegVentas.NuevaVenta(EntVentas, ObtenerDetalleVenta())

    '        Me.Cursor = Cursors.Arrow

    '        Return id_Venta
    '    End Function

    '    Private Function obtenerEntidadVenta(facturado As Boolean, TipoVenta As Integer, TipoPago As Integer, id_Empleado As Integer, id_Encargado As Integer, id_Cliente As Integer, id_ClienteMinorista As Integer, Id_Tarjeta As Integer, CantidadCuotas As Integer, PorcentajeFacturacion As Double, id_ListaPrecio As Integer, Descuento As Double, CostoFinanciero As Double, MontoTotalSinDescuento As Double, MontoTotal As Double, CantidadTotal As Integer, DiferenciaPagoCheque As Double, MontoSenia As Double, EsSenia As Boolean) As Ventas

    '        'Seteo el cursor.
    '        Me.Cursor = Cursors.WaitCursor

    '        'Datos de la venta.
    '        EntVentas.id_Cliente = id_Cliente
    '        EntVentas.id_ClienteMinorista = id_ClienteMinorista
    '        EntVentas.PorcentajeFacturacion = PorcentajeFacturacion
    '        EntVentas.id_Empleado = id_Empleado
    '        EntVentas.id_Encargado = id_Encargado
    '        EntVentas.id_Sucursal = id_Sucursal
    '        EntVentas.id_TipoPago = TipoPago
    '        EntVentas.id_TipoVenta = TipoVenta
    '        EntVentas.id_ListaPrecio = id_ListaPrecio
    '        EntVentas.id_Tarjeta = Id_Tarjeta
    '        EntVentas.CantidadCuotas = CantidadCuotas
    '        EntVentas.CantidadTotal = CantidadTotal
    '        EntVentas.Descuento = Descuento
    '        EntVentas.CostoFinanciero = CostoFinanciero
    '        EntVentas.SubTotal = MontoTotalSinDescuento
    '        EntVentas.PrecioTotal = MontoTotal - DiferenciaPagoCheque
    '        EntVentas.Anulado = 0
    '        EntVentas.Habilitado = 1
    '        EntVentas.Facturado = facturado
    '        EntVentas.DiferenciaPagoCheque = DiferenciaPagoCheque
    '        EntVentas.MontoSenia = MontoSenia
    '        EntVentas.Senia = EsSenia

    '        Return EntVentas
    '    End Function

    '    Private Sub ActualizarStock()
    '        For i = 0 To DG_Productos.Rows.Count - 1
    '            'Descuento el stock de los productos si el precio es positivo, y agrego el stock si el precio es negativo ( será un cambio ).
    '            If CDbl(DG_Productos.Rows(i).Cells.Item("PRECIO").Value) < 0 Then
    '                NegStock.AgregarStock(CInt(DG_Productos.Rows(i).Cells.Item("ID").Value), id_Sucursal, CInt(DG_Productos.Rows(i).Cells.Item("CANTIDAD").Value))
    '            Else
    '                NegStock.DisminuirStock(CInt(DG_Productos.Rows(i).Cells.Item("ID").Value), CInt(DG_Productos.Rows(i).Cells.Item("CANTIDAD").Value), id_Sucursal)
    '            End If
    '        Next
    '    End Sub

    '    Private Sub ActualizarStockDesdeSenia()
    '        Dim SeniaDetalle As DataSet = NegVentas.TraerVentaDetalle(Me.Senia.IdVentaSenia)

    '        'Controlo si se agrega un nuevo producto a los productos señados o si se modifica la cantidad para actualizar el stock
    '        For i = 0 To DG_Productos.Rows.Count - 1

    '            Dim ProductoSeniado As DataRow = SeniaDetalle.Tables(0).Rows.Cast(Of DataRow).Where(Function(x) x("id_Producto") = DG_Productos.Rows(i).Cells.Item("ID").Value).FirstOrDefault()

    '            'Si es un producto que no fue señado
    '            If (ProductoSeniado Is Nothing) Then

    '                'Descuento el stock de los productos si el precio es positivo, y agrego el stock si el precio es negativo ( será un cambio ).
    '                If CDbl(DG_Productos.Rows(i).Cells.Item("PRECIO").Value) < 0 Then
    '                    NegStock.AgregarStock(CInt(DG_Productos.Rows(i).Cells.Item("ID").Value), id_Sucursal, CInt(DG_Productos.Rows(i).Cells.Item("CANTIDAD").Value))
    '                Else
    '                    NegStock.DisminuirStock(CInt(DG_Productos.Rows(i).Cells.Item("ID").Value), CInt(DG_Productos.Rows(i).Cells.Item("CANTIDAD").Value), id_Sucursal)
    '                End If

    '                'Si es un producto que fue señado
    '            Else
    '                'Verifico si hay alguna diferencia en las cantidades 
    '                Dim diferenciaCantiadad As Integer = CInt(ProductoSeniado("Cantidad") - CInt(DG_Productos.Rows(i).Cells.Item("CANTIDAD").Value))
    '                'Si la diferencia es positiva aumento el stock
    '                If (diferenciaCantiadad > 0) Then
    '                    NegStock.AgregarStock(CInt(DG_Productos.Rows(i).Cells.Item("ID").Value), id_Sucursal, diferenciaCantiadad)
    '                    'Si la diferencia es negativa disminuyo el stock
    '                ElseIf (diferenciaCantiadad < 0) Then
    '                    NegStock.DisminuirStock(CInt(DG_Productos.Rows(i).Cells.Item("ID").Value), Math.Abs(diferenciaCantiadad), id_Sucursal)
    '                End If
    '            End If
    '        Next

    '        'Controlo si un producto se quitaron a los productos señados para actualizar el stock
    '        For i = 0 To SeniaDetalle.Tables(0).Rows.Count - 1
    '            Dim idProductoSeniado As Integer = SeniaDetalle.Tables(0).Rows(i)("id_Producto")
    '            'Si el producto señado fue quitado hay que incrementar su stock
    '            If (Not DG_Productos.Rows.Cast(Of DataGridViewRow).Any(Function(x) CInt(x.Cells.Item("ID").Value) = idProductoSeniado)) Then
    '                NegStock.AgregarStock(idProductoSeniado, id_Sucursal, CInt(SeniaDetalle.Tables(0).Rows(i)("Cantidad")))
    '            End If
    '        Next
    '    End Sub

    '    Private Function RegistrarComisionesEncargadoEmpleado(id_Empleado As Integer, id_Encargado As Integer, id_Cliente As Integer, MontoTotal As Double, id_Venta As Int64) As Double
    '        Dim Monto As Double
    '        'Comisiones para el vendedor.
    '        Dim EntComisiones As New Entidades.Comisiones

    '        Dim ComisionVendedor As Double = 0
    '        Dim ComisionEncargado As Double = 0

    '        'Obtengo las comisions del vendedor y encargado determinada por la sucursal y el dia de la semana.
    '        NegComisiones.ObtenerComision(id_Sucursal, id_Cliente, ComisionVendedor, ComisionEncargado)

    '        'Calculo el monto para el empleado dependiendo de la comision
    '        Monto = (MontoTotal * ComisionVendedor) / 100

    '        'Completo la Clase de Comisiones 
    '        EntComisiones.id_Sucursal = id_Sucursal
    '        EntComisiones.id_Venta = id_Venta
    '        EntComisiones.id_Empleado = id_Empleado
    '        EntComisiones.Comision = ComisionVendedor
    '        EntComisiones.Monto = Monto

    '        'Agrego la Comision
    '        NegComisiones.AgregarComision(EntComisiones)

    '        'Comisiones para el encargado.
    '        Dim EntComisiones2 As New Entidades.Comisiones

    '        'Calculo el monto para el empleado dependiendo de la comision
    '        Monto = (MontoTotal * ComisionEncargado) / 100

    '        'Completo la Clase de Comisiones 
    '        EntComisiones2.id_Sucursal = id_Sucursal
    '        EntComisiones2.id_Venta = id_Venta
    '        EntComisiones2.id_Empleado = id_Encargado
    '        EntComisiones2.Comision = ComisionEncargado
    '        EntComisiones2.Monto = Monto

    '        'Agrego la Comision
    '        NegComisiones.AgregarComision(EntComisiones2)
    '        Return Monto
    '    End Function

    '    Private Sub MostrarPantallaFacturacionSenia(TipoPago As Integer, id_Cliente As Integer, MontoSenia As Double, CostoFinanciero As Double, PorcentajeFacturacion As Double, VentaDetalle As List(Of Ventas_Detalle), FacturacionClose As FormClosedEventHandler)
    '        Dim TipoPagoControlador As String

    '        'Seteo Tipo de Pago para la controladora fiscal
    '        If TipoPago = 1 Then
    '            TipoPagoControlador = "EFECTIVO"
    '        ElseIf TipoPago = 2 Then
    '            TipoPagoControlador = "CREDITO"
    '        ElseIf TipoPago = 3 Then
    '            TipoPagoControlador = "DEBITO"
    '        Else
    '            TipoPagoControlador = "CHEQUE"
    '        End If

    '        Dim frmFacturar As frmFacturar = New frmFacturar()

    '        frmFacturar.VentaDetalle = VentaDetalle
    '        frmFacturar.MdiParent = Me.MdiParent
    '        AddHandler frmFacturar.FormClosed, FacturacionClose

    '        If (cb_Tipo.SelectedItem = "Minorista") Then
    '            frmFacturar.id_Cliente = id_Cliente
    '            frmFacturar.TipoPago = TipoPagoControlador
    '            frmFacturar.TipoCliente = TipoCliente.Minorista
    '            frmFacturar.CostoFinanciero = CostoFinanciero
    '            frmFacturar.SubTotal = MontoSenia
    '            frmFacturar.Monto = MontoSenia + CostoFinanciero
    '            frmFacturar.MontoSenia = MontoSenia
    '            frmFacturar.EsSenia = True
    '            frmFacturar.PorcentajeFacturacion = 1
    '        Else

    '            Dim MontoSeñaSinIva As Double = MontoSenia / ((0.21 * PorcentajeFacturacion) + 1)
    '            Dim CostoFinancieroSinIva As Double = CostoFinanciero / ((0.21 * PorcentajeFacturacion) + 1)
    '            frmFacturar.id_Cliente = id_Cliente
    '            frmFacturar.TipoPago = TipoPagoControlador
    '            frmFacturar.TipoCliente = TipoCliente.Mayorista
    '            frmFacturar.CostoFinanciero = Math.Round(CostoFinancieroSinIva, 2)
    '            frmFacturar.SubTotal = Math.Round((MontoSeñaSinIva + CostoFinancieroSinIva) * PorcentajeFacturacion, 2)
    '            frmFacturar.IvaTotal = Math.Round(frmFacturar.SubTotal * 0.21, 2)
    '            frmFacturar.Monto = Math.Round(frmFacturar.SubTotal + frmFacturar.IvaTotal, 2)
    '            frmFacturar.MontoSenia = Math.Round(MontoSeñaSinIva * PorcentajeFacturacion * 1.21, 2)
    '            frmFacturar.EsSenia = True
    '            frmFacturar.PorcentajeFacturacion = PorcentajeFacturacion
    '        End If

    '        frmFacturar.Show()
    '        Me.Hide()
    '    End Sub

    Private Sub txt_CodigoBarra_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_CodigoBarra.KeyDown
        If e.KeyData = Keys.Enter Then
            Me.Cursor = Cursors.WaitCursor
            BuscarProducto()
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub dgPagos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgPagos.CellContentClick
        If dgPagos.Columns(e.ColumnIndex).Name = "PagoQuitar" Then 'Si se hace click en el boton "eliminar" de la fila.
            Dim Result As DialogResult
            Result = MessageBox.Show("¿Está seguro que desea quitar el pago?", "Registro de Ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Result = System.Windows.Forms.DialogResult.Yes Then 'Si acepta eliminar el item
                ventaVistaModelo.QuitarPago(dgPagos.CurrentRow.DataBoundItem)
                ventaVistaModelo.ActualizarTotalPagos()
                HabilitarPagos()
            End If
        End If
    End Sub

    Private Sub moneda_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim txt As TextBox = TryCast(sender, TextBox)
        If txt.Text.Trim = "" Then
            txt.Text = "0"
        End If
    End Sub

    Private Sub moneda_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If e.KeyChar.ToString() = "." Then
            e.KeyChar = CChar(",")
        ElseIf e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            Btn_Finalizar.Focus()
        End If

        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloCurrency(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub cantidad_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            Btn_Finalizar.Focus()
        End If

        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub cantidad_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim txt As TextBox = TryCast(sender, TextBox)
        If txt.Text.Trim = "" Then
            txt.Text = "0"
        End If
    End Sub


    Private Sub txt_PorcentajeFacturacion_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_PorcentajeFacturacion.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            e.SuppressKeyPress = True
            txt_CodigoBarra.Focus()
        End If
    End Sub

    Private Sub txt_PorcentajeDesceunto_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_PorcentajeBonificacion.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            e.SuppressKeyPress = True
            txt_CodigoBarra.Focus()
        End If
    End Sub

    '    Private Sub Btn_Cambiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cambiar.Click
    '        Me.Cursor = Cursors.WaitCursor
    '        Dim frmCambios As frmCambios = New frmCambios()
    '        frmCambios.ShowDialog()
    '        If (frmCambios.DialogResult = DialogResult.OK) Then
    '            AgregarItem(frmCambios.IdProducto, 1, 2)
    '        End If
    '        Me.Cursor = Cursors.Arrow
    '    End Sub

    'Private Sub Cb_ListaPrecio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_ListaPrecio.SelectedIndexChanged
    '    RemoveHandler Cb_ListaPrecio.SelectedIndexChanged, AddressOf Cb_ListaPrecio_SelectedIndexChanged
    '    ventaVistaModelo.ListaPrecioSeleccionado = Cb_ListaPrecio.SelectedValue

    '    ventaVistaModelo.ActualizarProductos()
    '    CalcularPago(ventaVistaModelo.TipoClienteSeleccionado)

    '    AddHandler Cb_ListaPrecio.SelectedIndexChanged, AddressOf Cb_ListaPrecio_SelectedIndexChanged
    'End Sub

    Private Sub BuscarProducto(Optional cambio As Boolean = False)
        Try
            Dim dr As DataRow = dsProductos.Tables(0).Rows.Cast(Of DataRow).Where(Function(x) x.Item("Nombre").ToString().ToUpper() = txt_CodigoBarra.Text.ToUpper() Or x.Item("Codigo").ToString().ToUpper() = txt_CodigoBarra.Text.ToUpper()).FirstOrDefault()
            If (dr Is Nothing) Then
                MessageBox.Show("El código o nombre de producto no existe. Por favor verifique la información ingresada sea la correcta.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim productoEntidad As Entidades.Productos = NegProductos.TraerProductoPorCodigo(dr(1)) 'Traigo el producto.  

            Dim productoIngresado As VistaModelo.frmVentas.Producto = ventaVistaModelo.Productos.FirstOrDefault(Function(x) x.Codigo = productoEntidad.Codigo)
            If (Not cambio) Then
                'Me fijo si ya se encuentra agregado. Si está aumento su cantidad.
                If (productoIngresado IsNot Nothing) Then

                    'Chequeo si se posee stock del producto
                    If Not NegStock.ComprobarStock(productoIngresado.Id, productoIngresado.Cantidad + 1, id_Sucursal) Then
                        'Si no hay producto muestro un mensaje de alerta para que el usuario decida que hacer
                        Dim frmStockFaltante As frmStockFaltante = New frmStockFaltante(productoIngresado.Id, productoIngresado.Codigo, id_Sucursal, productoIngresado.Cantidad + 1)

                        'Si retorna Ok es porque el usuario decidio cargar una cantidad de productos
                        If (frmStockFaltante.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                            productoIngresado.Cantidad = frmStockFaltante.stockCargado
                        End If
                    Else
                        Dim frmStockIngreso As frmStockIngreso = New frmStockIngreso(productoEntidad.id_Producto, productoEntidad.Codigo, id_Sucursal, productoIngresado.Cantidad + 1)
                        If (frmStockIngreso.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                            productoIngresado.Cantidad = frmStockIngreso.stockCargado
                        End If
                    End If
                    productoIngresado.ActualizarSubtotal(ventaVistaModelo.TipoClienteSeleccionado, ventaVistaModelo.PorcentajeFacturacion / 100)

                    'Si es un producto nuevo
                Else
                    Dim cantidad As Integer = 0
                    'Chequeo si se posee stock del producto, como el produto no esta repetido consulto por si hay 1
                    If Not NegStock.ComprobarStock(productoEntidad.id_Producto, 1, id_Sucursal) Then

                        'Si no hay producto muestro un mensaje de alerta para que el usuario decida que hacer
                        Dim frmStockFaltante As frmStockFaltante = New frmStockFaltante(productoEntidad.id_Producto, productoEntidad.Codigo, id_Sucursal, 1)

                        'Si retorna Ok es porque el usuario decidio cargar una cantidad de productos
                        If (frmStockFaltante.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                            cantidad = frmStockFaltante.stockCargado
                        End If
                    Else
                        Dim frmStockIngreso As frmStockIngreso = New frmStockIngreso(productoEntidad.id_Producto, productoEntidad.Codigo, id_Sucursal, 1)
                        If (frmStockIngreso.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                            cantidad = frmStockIngreso.stockCargado
                        End If
                    End If
                    ventaVistaModelo.AgregarProducto(cantidad, productoEntidad)
                End If
            Else
                If (productoIngresado IsNot Nothing) Then
                    productoIngresado.Cantidad += 1
                Else
                    ventaVistaModelo.AgregarProducto(1, productoEntidad, cambio)
                End If
            End If

            CalcularTotales(ventaVistaModelo.TipoClienteSeleccionado)
            'Borro el textbox
            ventaVistaModelo.ProductoIngresado = ""
            txt_CodigoBarra.Focus()
        Catch ex As Exception
            MessageBox.Show("Se ha producido un error al agregar el producto.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txt_PorcentajeFacturacion_Leave(sender As Object, e As EventArgs) Handles txt_PorcentajeFacturacion.Leave
        If txt_PorcentajeFacturacion.Text.Trim = "" Then
            txt_PorcentajeFacturacion.Text = "0"
        End If

        If (DG_Productos.Rows.Count > 0) Then
            ventaVistaModelo.ActualizarSubtotalProductos()
            ventaVistaModelo.ActualizarTotalPagos()
            CalcularTotales(ventaVistaModelo.TipoClienteSeleccionado)
        End If
    End Sub

    Private Sub txt_PorcentajeDesceunto_Leave(sender As Object, e As EventArgs) Handles txt_PorcentajeBonificacion.Leave
        If txt_PorcentajeBonificacion.Text.Trim = "" Then
            txt_PorcentajeBonificacion.Text = "0"
        End If

        For Each producto As VistaModelo.frmVentas.Producto In ventaVistaModelo.Productos
            producto.PorcentajeBonificacion = ventaVistaModelo.ProcentajeBonificacionClienteMayorista / 100
        Next

    End Sub

    '    Private Sub Cb_Banco_SelectedIndexChanged(sender As Object, e As EventArgs)
    '        ''TODO: Ver esta funcionalidad en una nueva pantalla para seleccionar el banco de la tarjeta de credito
    '        'If (Cb_Tarjeta.SelectedValue > 0) Then
    '        '    CostoFinancieroBindingSource.DataSource = NegTarjeta.TraerCostosFinancieros(Cb_Tarjeta.SelectedValue)
    '        '    Cb_NumeroCuota_SelectedIndexChanged(Nothing, Nothing)
    '        'Else
    '        '    Dim CosotosFinancieros As List(Of CostoFinanciero) = New List(Of CostoFinanciero)
    '        '    CosotosFinancieros.Add(New CostoFinanciero() With {.Tarjeta = 0, .CostoFinancieroId = 0, .NumeroCuotas = 0, .PorcentajeRecargo = 0})
    '        '    CostoFinancieroBindingSource.DataSource = CosotosFinancieros
    '        '    txt_CostoFinanciero.Text = Format(0, "P")
    '        'End If
    '    End Sub

    '    Private Sub Cb_NumeroCuota_SelectedIndexChanged(sender As Object, e As EventArgs)
    '        ''TODO: Ver esta funcionalidad en una nueva pantalla para seleccionar el numero de cuotas
    '        'If (Cb_NumeroCuota.SelectedItem IsNot Nothing) Then
    '        '    txt_CostoFinanciero.Text = CType(Cb_NumeroCuota.SelectedItem, CostoFinanciero).PorcentajeRecargo.ToString("P")
    '        'Else
    '        '    txt_CostoFinanciero.Text = 0.ToString("P")
    '        'End If
    '        'txt_SeniaCostoFinanciero.Text = Format((ObtenerCostoFinanciero() * Decimal.Parse(txt_Senia.Text)), "###0.00")
    '        'CalcularTotales()
    '    End Sub

    '    Private Sub txt_Senia_Leave(sender As Object, e As EventArgs)
    '        ''TODO: ver como modificar las señas
    '        'txt_SeniaCostoFinanciero.Text = Format((ObtenerCostoFinanciero() * Decimal.Parse(txt_Senia.Text)), "###0.00")
    '    End Sub

    '    Private Sub enableAllControls(con As Control, enable As Boolean)

    '        For Each c As Control In con.Controls
    '            enableAllControls(c, enable)
    '        Next

    '        If TypeOf con IsNot TableLayoutPanel And TypeOf con IsNot GroupBox And Not String.IsNullOrEmpty(con.Name) Then
    '            con.Enabled = enable
    '        End If

    '    End Sub



    Private Sub btnAgregaPago_Click(sender As Object, e As EventArgs) Handles btnAgregaPago.Click
        AgregaPago()
    End Sub

    Private Sub AgregaPago()
        Try
            ventaVistaModelo.AgregarPago()
            ventaVistaModelo.ActualizarTotalPagos()
            HabilitarPagos()
        Catch ex As ValidationErrorException
            MessageBox.Show(ex.Message, "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Se ha encontrado un error al agregar el pago. Por favor, vuelva a intentar más tarde o contáctese con el Administrador ", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Cb_FormaPago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_FormaPago.SelectedIndexChanged
        RemoveHandler Cb_FormaPago.SelectedIndexChanged, AddressOf Cb_FormaPago_SelectedIndexChanged

        ventaVistaModelo.FormaPagoSeleccionado = Cb_FormaPago.SelectedValue

        If (ventaVistaModelo.TipoClienteSeleccionado = TipoCliente.Mayorista AndAlso ventaVistaModelo.FormaPagoSeleccionado = FormaPago.Efectivo) Then
            txt_PorcentajeFacturacion.Enabled = True
        Else
            txt_PorcentajeFacturacion.Enabled = False
            ventaVistaModelo.PorcentajeFacturacion = 100
        End If

        Cb_Banco.Enabled = ventaVistaModelo.FormaPagoSeleccionado = FormaPago.TarjetaCredito OrElse ventaVistaModelo.FormaPagoSeleccionado = FormaPago.TarjetaDebito
        Cb_Banco.SelectedValue = 0
        ventaVistaModelo.ListaBancoSeleccionado = 0

        Cb_NroCuota.Enabled = ventaVistaModelo.FormaPagoSeleccionado = FormaPago.TarjetaCredito
        Cb_NroCuota.SelectedValue = 0
        ventaVistaModelo.ListaCuotaSeleccionado = 0

        ventaVistaModelo.CFTCuota = 0
        ventaVistaModelo.CalcularTotal(ventaVistaModelo.SubTotal)

        AddHandler Cb_FormaPago.SelectedIndexChanged, AddressOf Cb_FormaPago_SelectedIndexChanged
    End Sub

    Private Sub Cb_Banco_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_Banco.SelectedIndexChanged
        If (Cb_Banco.SelectedValue > 0) Then
            RemoveHandler Cb_Banco.SelectedIndexChanged, AddressOf Cb_Banco_SelectedIndexChanged

            ventaVistaModelo.ListaBancoSeleccionado = Cb_Banco.SelectedValue

            ventaVistaModelo.ListaCuotas = New BindingList(Of CostoFinanciero)(NegTarjeta.TraerCostosFinancieros(ventaVistaModelo.ListaBancoSeleccionado))
            ventaVistaModelo.ListaCuotaSeleccionado = ventaVistaModelo.ListaCuotas.First.CostoFinancieroId
            Cb_NroCuota.SelectedValue = ventaVistaModelo.ListaCuotaSeleccionado

            AddHandler Cb_Banco.SelectedIndexChanged, AddressOf Cb_Banco_SelectedIndexChanged
        End If
    End Sub

    Private Sub Cb_NroCuota_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_NroCuota.SelectedIndexChanged
        If (Cb_NroCuota.SelectedValue <> Nothing OrElse Cb_NroCuota.SelectedValue > 0) Then
            RemoveHandler Cb_NroCuota.SelectedIndexChanged, AddressOf Cb_NroCuota_SelectedIndexChanged

            ventaVistaModelo.ListaCuotaSeleccionado = Cb_NroCuota.SelectedValue
            ventaVistaModelo.CFTCuota = ventaVistaModelo.CuotaPorcentajeRecargo()
            ventaVistaModelo.CalcularTotal(ventaVistaModelo.SubTotal)

            AddHandler Cb_NroCuota.SelectedIndexChanged, AddressOf Cb_NroCuota_SelectedIndexChanged
        End If
    End Sub

    Private Sub txt_Total_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Total.LostFocus
        Dim txt As TextBox = TryCast(sender, TextBox)
        If txt.Text.Trim = "" Then
            txt.Text = "0"
        End If

        ventaVistaModelo.CalcularSubtotal(ventaVistaModelo.Total)
    End Sub

    Private Sub txt_Total_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Total.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            e.SuppressKeyPress = True
            ventaVistaModelo.CalcularSubtotal(ventaVistaModelo.Total)
            AgregaPago()
            Btn_Finalizar.Focus()
        End If
    End Sub

    Private Sub txt_Subtotal_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Subtotal.LostFocus
        Dim txt As TextBox = TryCast(sender, TextBox)
        If txt.Text.Trim = "" Then
            txt.Text = "0"
        End If

        ventaVistaModelo.CalcularTotal(ventaVistaModelo.SubTotal)
    End Sub

    Private Sub txt_Subtotal_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Subtotal.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            e.SuppressKeyPress = True
            ventaVistaModelo.CalcularTotal(ventaVistaModelo.SubTotal)
            AgregaPago()
            Btn_Finalizar.Focus()
        End If
    End Sub

    Private Sub clearTxt_GotFocus(ByVal sender As Object, ByVal e As EventArgs) Handles txt_Subtotal.GotFocus, txt_Total.GotFocus
        TryCast(sender, TextBox).Clear()
    End Sub

    Private Sub btnRecargarPago_Click(sender As Object, e As EventArgs) Handles btnRecargarPago.Click
        ventaVistaModelo.SubTotal = ventaVistaModelo.ObtenerSubTotalFaltantePago()
        ventaVistaModelo.CalcularTotal(ventaVistaModelo.SubTotal)
    End Sub

    Private Sub HabilitarPagos()
        btnAgregaPago.Enabled = ventaVistaModelo.SubTotal > 0
        btnRecargarPago.Enabled = ventaVistaModelo.SubTotal > 0
        txt_Subtotal.Enabled = ventaVistaModelo.SubTotal > 0
        txt_Total.Enabled = ventaVistaModelo.SubTotal > 0
    End Sub

    Private Sub NoImplementado_Click(sender As Object, e As EventArgs) Handles BtnSenia.Click, Btn_NotaPedido.Click
        MessageBox.Show("Acción no iplementada :)", "Demo", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class