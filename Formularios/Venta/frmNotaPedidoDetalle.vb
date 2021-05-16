Imports System.Threading.Tasks
Imports Negocio
Imports SistemaCinderella.Formularios.Venta
Imports SistemaCinderella.Formularios.Venta.frmVentasViewModel
Imports Ventas.Core.Model.NotaPedidoAgreggate

Public Class frmNotaPedidoDetalle
    Inherits Comun

    Private NotaPedidoDetalleViewModel As frmNotaPedidoDetalleViewModel
    Private FinalizarDelegate As FinalizarDelegateAsync
    Private Errores As NegManejadorErrores = New NegManejadorErrores()

    Sub New(notaPedido As NotaPedido, finalizarDelegate As FinalizarDelegateAsync)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.FinalizarDelegate = finalizarDelegate
        NotaPedidoDetalleViewModel = New frmNotaPedidoDetalleViewModel(
            My.Settings.Sucursal,
            notaPedido,
            My.Settings.ListaPrecio,
            My.Settings.ListaPrecioMayorista,
            AddressOf CargarNombreYCodigoDeProductosEvent,
            AddressOf StockInsuficienteEvent)
    End Sub

    Private Sub frmNotaPedidoDetalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EjecutarAsync(Async Function() As Task
                          FrmNotaPedidoDetalleViewModelBindingSource.DataSource = NotaPedidoDetalleViewModel
                          Await NotaPedidoDetalleViewModel.CargarProductoNombreYCodigoAsync()
                      End Function)

        Me.DataBindings.Add(New Binding("Visible", Me.FrmNotaPedidoDetalleViewModelBindingSource, "Visible", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    End Sub

    Private Sub Btn_Agregar_Click(sender As Object, e As EventArgs) Handles Btn_Agregar.Click
        Ejecutar(Sub()
                     NotaPedidoDetalleViewModel.AgregaItemNotaPedido()
                     Btn_Agregar.Focus()
                 End Sub)
    End Sub

    Private Sub DG_Productos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_Productos.CellContentClick
        Ejecutar(
            Sub()
                If DG_Productos.Columns(e.ColumnIndex).Name = "ProductosQuitar" Then
                    NotaPedidoDetalleViewModel.QuitarItemNotaPedido(DG_Productos.CurrentRow.DataBoundItem)
                End If
            End Sub)
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

    Private Sub Btn_Guardar_Click(sender As Object, e As EventArgs) Handles Btn_Guardar.Click
        EjecutarAsync(Async Function() As Task
                          Await NotaPedidoDetalleViewModel.GuardarFinalizadoAsync()
                          MessageBox.Show(My.Resources.GuardadoOk, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                          Close()
                      End Function)
    End Sub

    Private Sub Btn_Armado_Click(sender As Object, e As EventArgs) Handles Btn_Armado.Click
        EjecutarAsync(Async Function() As Task
                          Await NotaPedidoDetalleViewModel.ArmadoFinalizadoAsync()
                          MessageBox.Show(My.Resources.GuardadoOk, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                      End Function)
    End Sub

    Private Sub Btn_Volver_Armado_Click(sender As Object, e As EventArgs) Handles Btn_Volver_Armado.Click
        EjecutarAsync(Async Function() As Task
                          Await NotaPedidoDetalleViewModel.VolverAEstadoIngresadoAsync()
                          MessageBox.Show(My.Resources.GuardadoOk, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                      End Function)
    End Sub

    Private Sub Btn_Venta_Click(sender As Object, e As EventArgs) Handles Btn_Venta.Click
        Ejecutar(Sub()
                     NotaPedidoDetalleViewModel.RealizarVenta(Me.MdiParent)
                 End Sub)
    End Sub

    Private Sub Btn_Envio_Click(sender As Object, e As EventArgs) Handles Btn_Envio.Click
        EjecutarAsync(Async Function() As Task
                          Await NotaPedidoDetalleViewModel.EnvioFinalizadoAsync()
                          MessageBox.Show(My.Resources.GuardadoOk, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                      End Function)
    End Sub

    Private Sub btnAnular_Click(sender As Object, e As EventArgs) Handles btnAnular.Click
        EjecutarAsync(Async Function() As Task
                          Await NotaPedidoDetalleViewModel.Anular()
                          MessageBox.Show(My.Resources.GuardadoOk, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                          Close()
                      End Function)
    End Sub

    Private Sub txt_CodigoBarra_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_CodigoBarra.KeyDown
        Ejecutar(
            Sub()
                If (e.KeyData = Keys.Enter) Then
                    NotaPedidoDetalleViewModel.AgregaItemNotaPedido()
                End If
            End Sub)
    End Sub

    Public Function StockInsuficienteEvent(codigoProducto As String, stockCargado As Integer, stockDisponible As Integer) As Boolean
        Dim form As frmStockFaltante = New frmStockFaltante(codigoProducto, stockCargado, stockDisponible)
        form.ShowDialog()
        stockCargado = form.StockIngresado
        Return form.DialogResult = DialogResult.OK
    End Function

    Private Sub FrmNotaPedidoDetalle_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.FinalizarDelegate?.Invoke()
    End Sub

    Private Sub Btn_Cancelar_Click(sender As Object, e As EventArgs) Handles Btn_Cancelar.Click
        Ejecutar(Sub() Close())
    End Sub

    Private Sub Btn_Imprimir_Click(sender As Object, e As EventArgs) Handles Btn_Imprimir.Click
        Ejecutar(Sub() NotaPedidoDetalleViewModel.ImprimirNotaPedido(Me.MdiParent))
    End Sub

    Private Sub DG_Productos_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles DG_Productos.CellBeginEdit
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

                Dim columnas As List(Of String) = New List(Of String) From {"ProductosPorcentajeBonificacion", "ProductosMonto", "ProductosCantidad"}
                If (columnas.Any(Function(x) DG_Productos.Columns(e.ColumnIndex).Name = x)) Then
                    Dim verificarStock = "ProductosCantidad" = DG_Productos.Columns(e.ColumnIndex).Name
                    NotaPedidoDetalleViewModel.ActualizarItemNotaPedido(DG_Productos.CurrentRow.DataBoundItem, verificarStock)
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

    Private Sub txt_PorcentajeBonificacion_ValueChanged(sender As Object, e As EventArgs) Handles txt_PorcentajeBonificacion.ValueChanged
        Ejecutar(Sub() NotaPedidoDetalleViewModel?.PorcentajeBonificacionChange(txt_PorcentajeBonificacion.Value))
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
End Class