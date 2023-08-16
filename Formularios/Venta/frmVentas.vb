Imports System.Threading.Tasks
Imports Common.Core.Enum
Imports Negocio
Imports SistemaCinderella.Comunes
Imports SistemaCinderella.Formularios.Facturacion
Imports SistemaCinderella.Formularios.Venta
Imports SistemaCinderella.Formularios.Venta.frmVentasViewModel
Imports Ventas.Core.Model.NotaPedidoAgreggate
Imports Ventas.Core.Model.VentaAggregate

Public Class frmVentas
    Inherits Comun

    Private ventaItemViewModelEdicion As VentaItemViewModel = New VentaItemViewModel()
    Private Reserva As Reserva
    Private NotaPedido As NotaPedido
    Private FinalizarDelegate As FinalizarDelegateAsync
    Private ventaViewModel As frmVentasViewModel
    Private Errores As NegManejadorErrores = New NegManejadorErrores()

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        Dim DatagridViewCheckBoxHeaderCell As DatagridViewCheckBoxHeaderCell = DG_Productos.Columns("Seleccionado").HeaderCell
        DatagridViewCheckBoxHeaderCell.Checked = True
        AddHandler DatagridViewCheckBoxHeaderCell.OnCheckBoxClicked, New CheckBoxClickedHandler(AddressOf datagridViewCheckBoxHeaderCell_OnCheckBoxClicked)
    End Sub

    Public Sub New(notaPedido As NotaPedido, finalizarDelegate As FinalizarDelegateAsync)
        Me.New()
        Me.NotaPedido = notaPedido
        Me.FinalizarDelegate = finalizarDelegate
    End Sub

    Public Sub New(reserva As Reserva)
        Me.New()
        Me.Reserva = reserva
    End Sub

    Private Sub frmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EjecutarAsync(Async Function() As Task
                          ventaViewModel = New frmVentasViewModel(
                                            My.Settings.Sucursal,
                                            Common.Core.Enum.TipoCliente.Minorista,
                                            My.Settings.ListaPrecio,
                                            My.Settings.ListaPrecioMayorista,
                                            AddressOf CargarNombreYCodigoDeProductosEvent,
                                            AddressOf StockInsuficienteEvent,
                                            AddressOf CantidadUnidadesProductoEvent,
                                            AddressOf FacturarEvent,
                                            AddressOf TerminarVentaEvent,
                                            FinalizarDelegate)

                          VentaViewModelBindingSource.DataSource = ventaViewModel
                          Await ventaViewModel.CargarDatosAsync()

                          If NotaPedido <> Nothing Then
                              ventaViewModel.CargarNotaPedido(NotaPedido)
                          End If

                          If Reserva <> Nothing Then
                              ventaViewModel.CargarReserva(Reserva)
                          End If

                          HabilitarSegunFormaDePago(TipoPago.Efectivo)

                          Me.ActiveControl = txt_CodigoBarra
                      End Function)
        Me.DataBindings.Add(New Binding("Visible", Me.VentaViewModelBindingSource, "Visible", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    End Sub

    Private Sub Btn_Agregar_Click(sender As Object, e As EventArgs) Handles Btn_Agregar.Click
        Ejecutar(Sub()
                     ventaViewModel.AgregaItemVenta(False)
                     Btn_Agregar.Focus()
                 End Sub)
    End Sub

    Private Sub Btn_Cambiar_Click(sender As Object, e As EventArgs) Handles Btn_Cambiar.Click
        Ejecutar(Sub()
                     ventaViewModel.AgregaItemVenta(True)
                     Btn_Agregar.Focus()
                 End Sub)
    End Sub

    Private Sub Btn_Buscar_Click(sender As Object, e As EventArgs) Handles Btn_Buscar.Click
        Ejecutar(Sub()
                     If (ventaViewModel.BuscarItemVenta()) Then
                         txt_CodigoBarra.Focus()
                     End If
                 End Sub)
    End Sub

    Private Sub btnRecargarPago_Click(sender As Object, e As EventArgs) Handles btnRecargarPago.Click
        Ejecutar(Sub() ventaViewModel.CalcularPendientePago())
    End Sub

    Private Sub btnAgregaPago_Click(sender As Object, e As EventArgs) Handles btnAgregaPago.Click
        Ejecutar(Sub()
                     ventaViewModel.AgregarPago()
                 End Sub)
    End Sub

    Private Sub txt_CodigoBarra_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_CodigoBarra.KeyDown
        Ejecutar(
            Sub()
                If (e.KeyData = Keys.Enter) Then
                    ventaViewModel.AgregaItemVenta(False)
                End If
            End Sub)
    End Sub

    Private Sub txt_Cantidad_KeyDown(sender As Object, e As KeyEventArgs)
        Ejecutar(
            Sub()
                If (e.KeyData = Keys.Enter) Then
                    ventaViewModel.AgregaItemVenta(False)
                End If
            End Sub)
    End Sub

    Private Sub txt_Subtotal_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Subtotal.KeyDown
        Ejecutar(
            Sub()
                If (e.KeyData = Keys.Enter) Then
                    ventaViewModel.AgregarPago()
                End If
            End Sub)
    End Sub

    Private Sub Cb_TipoCliente_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Cb_TipoCliente.SelectionChangeCommitted
        Ejecutar(
            Sub()
                If (Cb_TipoCliente.SelectedValue Is Nothing) Then
                    Return
                End If

                ventaViewModel.TipoClienteChange(Cb_TipoCliente.SelectedValue)
                If (Cb_TipoCliente.SelectedValue = Common.Core.Enum.TipoCliente.Mayorista) Then
                    ventaViewModel.ConfigurarVentaParaClienteMayorista()
                Else
                    ventaViewModel.ConfigurarVentaParaClienteMinorista()
                End If
            End Sub)
    End Sub

    Private Sub Cb_FormaPago_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Cb_FormaPago.SelectionChangeCommitted
        Ejecutar(Sub()
                     If (Cb_FormaPago.SelectedValue Is Nothing) Then
                         Return
                     End If

                     HabilitarSegunFormaDePago(Cb_FormaPago.SelectedValue)
                     ventaViewModel.FormaPagoChange(Cb_FormaPago.SelectedValue)
                     Cb_Trajeta.SelectedItem = Nothing
                     Cb_NroCuota.SelectedItem = Nothing
                 End Sub)
    End Sub

    Private Sub Cb_Trajeta_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Cb_Trajeta.SelectionChangeCommitted
        Ejecutar(Sub()
                     If (Cb_Trajeta.SelectedValue Is Nothing) Then
                         Return
                     End If

                     ventaViewModel.TarjetaChange(Cb_Trajeta.SelectedValue)
                 End Sub)
    End Sub

    Private Sub Cb_NroCuota_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Cb_NroCuota.SelectionChangeCommitted
        Ejecutar(Sub()
                     If (Cb_NroCuota.SelectedValue Is Nothing) Then
                         Return
                     End If

                     If (Cb_NroCuota.SelectedItem IsNot Nothing) Then
                         ventaViewModel.CuotaChange(Cb_NroCuota.SelectedValue)
                         ventaViewModel.ActualizarCostoFinanciero(Cb_NroCuota.SelectedValue)
                     End If
                 End Sub)
    End Sub

    Private Sub DG_Productos_KeyPressEnter(sender As Object, e As KeyEventArgs) Handles DG_Productos.KeyPressEnter
        If (String.IsNullOrEmpty(DG_Productos.CurrentCell.EditedFormattedValue)) Then

            Dim nombreColumna As String = DG_Productos.Columns(DG_Productos.CurrentCell.ColumnIndex).Name

            If (nombreColumna = "ProductosCantidad") Then
                DG_Productos.CurrentCell.Value = 1
            End If
            If (nombreColumna = "ProductosMonto" OrElse nombreColumna = "ProductosPorcentajeBonificacion") Then
                DG_Productos.CurrentCell.Value = 0
            End If
        End If

        DG_Productos.NotifyCurrentCellDirty(True)
        DG_Productos.EndEdit()
        DG_Productos.NotifyCurrentCellDirty(False)

        txt_CodigoBarra.Focus()
    End Sub

    Private Sub DG_Productos_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles DG_Productos.CellBeginEdit
        ventaItemViewModelEdicion = DirectCast(DG_Productos.CurrentRow.DataBoundItem, VentaItemViewModel).Copiar()

        If DG_Productos.Columns(e.ColumnIndex).Name = "ProductosPorcentajeBonificacion" Then
            DG_Productos.CurrentCell.Style.Format = String.Format("N2")
            DG_Productos.CurrentCell.Value = DG_Productos.CurrentCell.Value * 100
        End If
    End Sub

    Private Sub DG_Productos_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DG_Productos.CellEndEdit
        Ejecutar(
            Sub()
                If DG_Productos.Columns(e.ColumnIndex).Name = "ProductosPorcentajeBonificacion" Then
                    DG_Productos.CurrentCell.Style.Format = String.Format("P")
                    DG_Productos.CurrentCell.Value = DG_Productos.CurrentCell.Value / 100
                End If

                If (ventaItemViewModelEdicion.Equals(DG_Productos.CurrentRow.DataBoundItem)) Then
                    Return
                End If

                Dim columnas As List(Of String) = New List(Of String) From {"ProductosPorcentajeBonificacion", "ProductosMonto", "ProductosCantidad", "Seleccionado"}
                If (columnas.Any(Function(x) DG_Productos.Columns(e.ColumnIndex).Name = x)) Then
                    Dim verificarStock = "ProductosCantidad" = DG_Productos.Columns(e.ColumnIndex).Name
                    ventaViewModel.ActualizarItemVenta(DG_Productos.CurrentRow.DataBoundItem, verificarStock)
                End If
            End Sub)
    End Sub

    ''Fuerzo la ejecucion del EndEdit en el click del checkbox facturar
    Private Sub DG_Productos_OnCellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DG_Productos.CellMouseUp
        If e.ColumnIndex = DG_Productos.Columns("Seleccionado").Index Then
            DG_Productos.EndEdit()
            DG_Productos_CellEndEdit(Nothing, New DataGridViewCellEventArgs(e.ColumnIndex, e.RowIndex))
        End If
    End Sub

    Private Sub datagridViewCheckBoxHeaderCell_OnCheckBoxClicked(columnIndex As Integer, seleccionado As Boolean)
        Ejecutar(
            Sub()
                ventaViewModel.ActualizarEstadoSeleccionadoItemsVenta(seleccionado)
            End Sub)
    End Sub

    Private Sub DG_Productos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_Productos.CellContentClick
        Ejecutar(
            Sub()
                If DG_Productos.Columns(e.ColumnIndex).Name = "ProductosQuitar" Then
                    ventaViewModel.QuitarItemVenta(DG_Productos.CurrentRow.DataBoundItem)
                End If
            End Sub)
    End Sub

    'Sobresalto la celda que se está editando.
    Private Sub DG_Productos_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DG_Productos.EditingControlShowing
        RemoveHandler e.Control.KeyPress, New KeyPressEventHandler(AddressOf moneda_KeyPress)
        RemoveHandler e.Control.LostFocus, New EventHandler(AddressOf moneda_LostFocus)
        RemoveHandler e.Control.KeyPress, New KeyPressEventHandler(AddressOf cantidad_KeyPress)
        RemoveHandler e.Control.LostFocus, New EventHandler(AddressOf cantidad_LostFocus)

        If DG_Productos.Columns(DG_Productos.CurrentCell.ColumnIndex).Name = "ProductosMonto" Then
            'agrego los eventos al control TextBox 
            Dim textBox As TextBox = TryCast(e.Control, TextBox)
            If textBox IsNot Nothing Then
                AddHandler textBox.KeyPress, New KeyPressEventHandler(AddressOf moneda_KeyPress)
                AddHandler textBox.LostFocus, New EventHandler(AddressOf moneda_LostFocus)
            End If
        End If

        If DG_Productos.Columns(DG_Productos.CurrentCell.ColumnIndex).Name = "ProductosCantidad" Then
            'agrego los eventos al control TextBox 
            Dim textBox As TextBox = TryCast(e.Control, TextBox)
            If textBox IsNot Nothing Then
                AddHandler textBox.KeyPress, New KeyPressEventHandler(AddressOf cantidad_KeyPress)
                AddHandler textBox.LostFocus, New EventHandler(AddressOf cantidad_LostFocus)
            End If
        End If

        If DG_Productos.Columns(DG_Productos.CurrentCell.ColumnIndex).Name = "ProductosPorcentajeBonificacion" Then
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

    Private Sub moneda_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim txt As TextBox = TryCast(sender, TextBox)
        If txt.Text.Trim = "" Then
            txt.Text = "0"
        End If
    End Sub

    Private Sub moneda_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
        End If

        Dim txt As TextBox = TryCast(sender, TextBox)
        Dim texto As String = txt.Text + e.KeyChar
        Dim cantidadComas = texto.Count(Function(x) x = ",")

        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(Errores.SoloCurrency(KeyAscii))
        If KeyAscii = 0 OrElse cantidadComas > 1 Then
            e.Handled = True
        End If
    End Sub

    Private Sub cantidad_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            Btn_Finalizar.Focus()
        End If

        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(Errores.SoloNumeros(KeyAscii))
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

    Private Sub dgPagos_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgPagos.CellFormatting
        Try
            Dim pagoViewModel As PagoViewModel = dgPagos.Rows(e.RowIndex).DataBoundItem
            If dgPagos.Columns(e.ColumnIndex).Name = "PagoCorregir" Then
                If (pagoViewModel.Resto = 0) Then
                    e.Value = New Bitmap(1, 1)
                End If
            End If
            If dgPagos.Columns(e.ColumnIndex).Name = "PagoQuitar" Then
                If (Not pagoViewModel.Habilitado) Then
                    e.Value = New Bitmap(1, 1)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgPagos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgPagos.CellContentClick
        Ejecutar(
            Sub()
                If (dgPagos.Columns(e.ColumnIndex).Name = "PagoQuitar") Then
                    ventaViewModel.QuitarPago(dgPagos.CurrentRow.DataBoundItem)
                End If
                If (dgPagos.Columns(e.ColumnIndex).Name = "PagoCorregir") Then
                    ventaViewModel.CorregirPago(dgPagos.CurrentRow.DataBoundItem)
                End If
            End Sub)
    End Sub

    Private Sub txt_PorcentajeBonificacion_ValueChanged(sender As Object, e As EventArgs) Handles txt_PorcentajeBonificacion.ValueChanged
        Ejecutar(Sub() ventaViewModel?.PorcentajeBonificacionChange(txt_PorcentajeBonificacion.Value))
    End Sub

    Private Sub txt_PorcentajeFacturacion_ValueChanged(sender As Object, e As EventArgs) Handles txt_PorcentajeFacturacion.ValueChanged
        Ejecutar(Sub() ventaViewModel?.PorcentajeFacturacionChange(txt_PorcentajeFacturacion.Value))
    End Sub

    Private Sub Btn_Finalizar_Click(sender As Object, e As EventArgs) Handles Btn_Finalizar.Click
        EjecutarAsync(
            Async Function() As Task
                If MessageBox.Show("¿Desea efectuar la venta?", "Registro de Ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    Await ventaViewModel.FinalizarVentaAsyn(False)
                End If
            End Function)
    End Sub

    Private Sub Btn_NotaPedido_Click(sender As Object, e As EventArgs) Handles Btn_NotaPedido.Click
        EjecutarAsync(
            Async Function()
                If MessageBox.Show("¿Desea efectuar la nota de pedido?", "Registro de Ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    If (Await ventaViewModel.NotaPedidoAsync()) Then

                        Dim Funciones As New Funciones
                        Await Funciones.ActualizarNotasPedidosVentasAsync()

                        MessageBox.Show("Los datos se han guardado de forma correcta.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Dispose()
                    End If
                End If
            End Function)
    End Sub

    Private Sub BtnReserva_Click(sender As Object, e As EventArgs) Handles BtnReserva.Click
        EjecutarAsync(Async Function() As Task
                          Await ventaViewModel.ReservaAsyn()
                      End Function)
    End Sub

    Private Sub Btn_BuscarCliente_Click(sender As Object, e As EventArgs) Handles Btn_BuscarCliente.Click
        Dim frmBuscarClienteMayorista As frmClienteMayoristaBuscar = New frmClienteMayoristaBuscar()
        frmBuscarClienteMayorista.ShowDialog()
        If frmBuscarClienteMayorista.ClienteMayorista IsNot Nothing Then
            ventaViewModel.ClienteMayoristaChange(frmBuscarClienteMayorista.ClienteMayorista)
        End If
    End Sub

    Private Sub FrmVentas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.FinalizarDelegate?.Invoke()
    End Sub

    Public Sub CargarNombreYCodigoDeProductosEvent(nombreCodigoProductos As List(Of String))
        txt_CodigoBarra.BeginInvoke(
            Sub()
                Dim AutoCompleteStringCollection As AutoCompleteStringCollection = New AutoCompleteStringCollection()
                nombreCodigoProductos.ForEach(Sub(x) AutoCompleteStringCollection.Add(x))
                txt_CodigoBarra.AutoCompleteCustomSource = AutoCompleteStringCollection
                txt_CodigoBarra.Enabled = True
            End Sub)
    End Sub

    Public Function StockInsuficienteEvent(codigoProducto As String, ByRef stockCargado As Integer, stockDisponible As Integer) As Boolean
        Dim form As frmStockFaltante = New frmStockFaltante(codigoProducto, stockCargado, stockDisponible)
        form.ShowDialog()
        stockCargado = form.StockIngresado
        Return form.DialogResult = DialogResult.OK
    End Function

    Public Function CantidadUnidadesProductoEvent(codigoProducto As String, ByRef cantidadUnidades As Integer) As Boolean
        Dim form As frmCantidadUnidadesProducto = New frmCantidadUnidadesProducto(codigoProducto)
        form.ShowDialog()
        cantidadUnidades = form.CantidadUnidades
        Return form.DialogResult = DialogResult.OK
    End Function

    Public Function CantidadProductosEvent(codigoProducto As String, stockCargado As Integer, stockDisponible As Integer) As Boolean
        Dim form As frmStockFaltante = New frmStockFaltante(codigoProducto, stockCargado, stockDisponible)
        form.ShowDialog()
        stockCargado = form.StockIngresado
        Return form.DialogResult = DialogResult.OK
    End Function

    Public Sub TerminarVentaEvent()
        MessageBox.Show("Los datos se han guardado de forma correcta.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        VentaViewModelBindingSource.Dispose()
        Me.Dispose()
    End Sub

    Public Sub FacturarEvent(facturarViewModel As frmFacturarViewModel)
        EjecutarAsync(
            Async Function() As Task
                If (MessageBox.Show("¿Desea facturar la venta?", "Registro de Ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) = vbYes) Then
                    ventaViewModel.Visible = False
                    Dim frmFacturarNueva As frmFacturar = New frmFacturar(facturarViewModel)
                    frmFacturarNueva.MdiParent = Me.MdiParent
                    frmFacturarNueva.Show()
                Else
                    Await ventaViewModel.GuardarAsync()
                End If
            End Function)
    End Sub

    Private Sub HabilitarSegunFormaDePago(tipoPago As TipoPago)
        ventaViewModel.FormaPagoSeleccionado = Cb_FormaPago.SelectedValue
        Cb_Trajeta.Enabled = tipoPago = TipoPago.TarjetaCrédito OrElse tipoPago = TipoPago.TarjetaDébito
        Cb_NroCuota.Enabled = tipoPago = TipoPago.TarjetaCrédito
    End Sub

    Private Sub Btn_Cancelar_Click(sender As Object, e As EventArgs) Handles Btn_Cancelar.Click
        Me.Close()
    End Sub
End Class