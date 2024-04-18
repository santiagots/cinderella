Imports System.Threading.Tasks
Imports Comex.Core.Model.ComexAggregate
Imports Negocio
Imports SistemaCinderella.Formularios.Comex
Imports SistemaCinderella.Formularios.Venta.frmVentasViewModel

Public Class frmComexOrdenCompra
    Inherits Comun

    Private comexOrdenCompraItemsViewModel As ComexOrdenCompraItemsViewModel = New ComexOrdenCompraItemsViewModel()
    Private frmComexOrdenCompraViewModel As frmComexOrdenCompraViewModel
    Private OrdenCompra As OrdenCompra
    Private FinalizarDelegate As FinalizarDelegateAsync
    Private Errores As NegManejadorErrores = New NegManejadorErrores()
    Private CB_SupplierIndex As Integer = 0

    Sub New(finalizarDelegate As FinalizarDelegateAsync)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.FinalizarDelegate = finalizarDelegate
    End Sub

    Sub New(ordenCompra As OrdenCompra, finalizarDelegate As FinalizarDelegateAsync)
        Me.New(finalizarDelegate)
        Me.OrdenCompra = ordenCompra
    End Sub

    Private Sub frmComexCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EjecutarAsync(Async Function() As Task
                          frmComexOrdenCompraViewModel = New frmComexOrdenCompraViewModel(
                                My.Settings.Sucursal,
                                OrdenCompra,
                                AddressOf CargarNombreYCodigoDeProductosEvent,
                                AddressOf CantidadUnidadesProductoEvent)

                          FrmComexOrdenCompraViewModelBindingSource.DataSource = frmComexOrdenCompraViewModel
                          Await frmComexOrdenCompraViewModel.CargarDatosAsync()
                      End Function)
    End Sub

    Private Sub txt_CodigoBarra_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_CodigoBarra.KeyDown
        Ejecutar(
            Sub()
                If (e.KeyData = Keys.Enter) Then
                    frmComexOrdenCompraViewModel.AgregaItem()
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

    Public Function CantidadUnidadesProductoEvent(codigoProducto As String, ByRef cantidadUnidades As Integer) As Boolean
        Dim form As frmCantidadUnidadesProducto = New frmCantidadUnidadesProducto(codigoProducto)
        form.ShowDialog()
        cantidadUnidades = form.CantidadUnidades
        Return form.DialogResult = DialogResult.OK
    End Function

    Private Sub DG_Productos_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles DG_Productos.CellBeginEdit
        comexOrdenCompraItemsViewModel = DirectCast(DG_Productos.CurrentRow.DataBoundItem, ComexOrdenCompraItemsViewModel).Copiar()
    End Sub

    Private Sub DG_Productos_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DG_Productos.CellEndEdit
        Ejecutar(
            Sub()
                If (comexOrdenCompraItemsViewModel.Equals(DG_Productos.CurrentRow.DataBoundItem)) Then
                    Return
                End If

                Dim columnas As List(Of String) = New List(Of String) From {"BoxQTY"}
                If (columnas.Any(Function(x) DG_Productos.Columns(e.ColumnIndex).Name = x)) Then
                    frmComexOrdenCompraViewModel.ActualizarItem(DG_Productos.CurrentRow.DataBoundItem)
                End If
            End Sub)
    End Sub

    Private Sub DG_Productos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_Productos.CellContentClick
        Ejecutar(
            Sub()
                If DG_Productos.Columns(e.ColumnIndex).Name = "ProductosQuitar" Then
                    frmComexOrdenCompraViewModel.QuitarItem(DG_Productos.CurrentRow.DataBoundItem)
                End If
            End Sub)
    End Sub

    Private Sub DG_Productos_Scroll(sender As Object, e As ScrollEventArgs) Handles DG_Productos.Scroll
        If e.ScrollOrientation = ScrollOrientation.VerticalScroll Then Exit Sub

        Me.DG_ProductosTotales.HorizontalScrollingOffset = e.NewValue
    End Sub

    Private Sub DG_ProductosTotales_Scroll(sender As Object, e As ScrollEventArgs) Handles DG_ProductosTotales.Scroll
        If e.ScrollOrientation = ScrollOrientation.VerticalScroll Then Exit Sub

        Me.DG_Productos.HorizontalScrollingOffset = e.NewValue
    End Sub

    Private Sub Btn_Agregar_Click(sender As Object, e As EventArgs) Handles Btn_Agregar.Click
        Ejecutar(Sub()
                     frmComexOrdenCompraViewModel.AgregaItem()
                     Btn_Agregar.Focus()
                 End Sub)
    End Sub

    Private Sub CB_Supplier_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CB_Supplier.SelectionChangeCommitted
        EjecutarAsync(
            Async Function()
                If CB_Supplier.SelectedItem Is Nothing Then
                    Return
                End If

                If frmComexOrdenCompraViewModel.OrdenCompraItems.Count > 0 And CB_Supplier.SelectedIndex <> CB_SupplierIndex Then
                    Dim respuesta As DialogResult = MessageBox.Show("¿Está seguro que desea seleccionar otro supplier?\nSi selecciona otro supplier se quitaran todos los productos del listado de productos.", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                    If (respuesta = DialogResult.Yes) Then
                        Await frmComexOrdenCompraViewModel.SupplierChangeAsync(CB_Supplier.SelectedItem)
                    End If
                Else
                    Await frmComexOrdenCompraViewModel.SupplierChangeAsync(CB_Supplier.SelectedItem)
                End If
            End Function)
    End Sub

    Private Sub CB_Supplier_Enter(sender As Object, e As EventArgs) Handles CB_Supplier.Enter
        CB_SupplierIndex = CB_Supplier.SelectedIndex
    End Sub

    Private Sub Btn_Buscar_Click(sender As Object, e As EventArgs) Handles Btn_Buscar.Click
        Ejecutar(Sub()
                     frmComexOrdenCompraViewModel.BuscarItemOrdenCompra()
                 End Sub)
    End Sub

    Private Sub Btn_Borrador_Click(sender As Object, e As EventArgs) Handles Btn_Borrador.Click
        EjecutarAsync(Async Function()
                          Await frmComexOrdenCompraViewModel.Borrador()

                          MessageBox.Show(My.Resources.GuardadoOk, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                          Close()
                      End Function)
    End Sub

    Private Sub Btn_Iniciar_Click(sender As Object, e As EventArgs) Handles Btn_Iniciar.Click
        EjecutarAsync(Async Function()
                          Dim respuesta As DialogResult = MessageBox.Show("¿Está seguro que desea iniciar la orden de compra?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                          If (respuesta = DialogResult.Yes) Then
                              Await frmComexOrdenCompraViewModel.Iniciar()

                              MessageBox.Show(My.Resources.GuardadoOk, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                              Close()
                          End If
                      End Function)
    End Sub

    Private Sub Btn_Finalizar_Click(sender As Object, e As EventArgs) Handles Btn_Finalizar.Click
        EjecutarAsync(Async Function()
                          Dim respuesta As DialogResult = MessageBox.Show("¿Está seguro que desea finalizar la orden de compra?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                          If (respuesta = DialogResult.Yes) Then
                              Await frmComexOrdenCompraViewModel.Finalizar()

                              MessageBox.Show(My.Resources.GuardadoOk, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                              Close()
                          End If
                      End Function)
    End Sub

    Private Sub btnAnular_Click(sender As Object, e As EventArgs) Handles btnAnular.Click
        EjecutarAsync(Async Function()
                          Dim respuesta As DialogResult = MessageBox.Show("¿Está seguro que desea anular la orden de compra?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                          If (respuesta = DialogResult.Yes) Then
                              Await frmComexOrdenCompraViewModel.Anular()

                              MessageBox.Show(My.Resources.GuardadoOk, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                              Close()
                          End If
                      End Function)
    End Sub

    Private Sub FrmNotaPedidoDetalle_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.FinalizarDelegate?.Invoke()
    End Sub

    Private Sub DG_Productos_KeyPressEnter(sender As Object, e As KeyEventArgs) Handles DG_Productos.KeyPressEnter

        DG_Productos.NotifyCurrentCellDirty(True)
        DG_Productos.EndEdit()
        DG_Productos.NotifyCurrentCellDirty(False)

        txt_CodigoBarra.Focus()
    End Sub

    Private Sub DG_Productos_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DG_Productos.EditingControlShowing
        RemoveHandler e.Control.KeyPress, New KeyPressEventHandler(AddressOf cantidad_KeyPress)
        RemoveHandler e.Control.LostFocus, New EventHandler(AddressOf cantidad_LostFocus)

        If DG_Productos.Columns(DG_Productos.CurrentCell.ColumnIndex).Name = "BoxQTY" Then
            'agrego los eventos al control TextBox 
            Dim textBox As TextBox = TryCast(e.Control, TextBox)
            If textBox IsNot Nothing Then
                AddHandler textBox.KeyPress, New KeyPressEventHandler(AddressOf cantidad_KeyPress)
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

    Private Sub cantidad_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            Btn_Borrador.Focus()
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

    Private Sub Btn_Cancelar_Click(sender As Object, e As EventArgs) Handles Btn_Cancelar.Click
        Close()
    End Sub
End Class