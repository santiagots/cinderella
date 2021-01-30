Imports System.Threading.Tasks
Imports SistemaCinderella.Formularios.Venta
Imports SistemaCinderella.Formularios.Venta.frmVentasViewModel
Imports Ventas.Core.Model.NotaPedidoAgreggate

Public Class frmNotaPedidoDetalle
    Inherits Comun

    Private NotaPedidoDetalleViewModel As frmNotaPedidoDetalleViewModel
    Private FinalizarDelegate As FinalizarDelegateAsync

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
    End Sub

    Private Sub Btn_Agregar_Click(sender As Object, e As EventArgs) Handles Btn_Agregar.Click
        Ejecutar(Sub()
                     NotaPedidoDetalleViewModel.AgregaItemNotaPedido(False)
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

    Private Sub Btn_Armado_Click(sender As Object, e As EventArgs) Handles Btn_Armado.Click
        EjecutarAsync(Async Function() As Task
                          Await NotaPedidoDetalleViewModel.ArmadoFinalizadoAsync()
                          MessageBox.Show(My.Resources.GuardadoOk, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                      End Function)
    End Sub

    Private Sub Btn_Venta_Click(sender As Object, e As EventArgs) Handles Btn_Venta.Click
        Ejecutar(Sub()
                     NotaPedidoDetalleViewModel.RealizarVenta(FinalizarDelegate, Me.MdiParent)
                     FinalizarDelegate = Nothing
                     Close()
                 End Sub)
    End Sub

    Private Sub Btn_Envio_Click(sender As Object, e As EventArgs) Handles Btn_Envio.Click
        EjecutarAsync(Async Function() As Task
                          Await NotaPedidoDetalleViewModel.EnvioFinalizadoAsync()
                          MessageBox.Show(My.Resources.GuardadoOk, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                      End Function)
    End Sub

    Public Function StockInsuficienteEvent(idProducto As Integer, codigoProducto As String, ByRef stockCargado As Integer) As Boolean
        Dim form As frmStockFaltante = New frmStockFaltante(idProducto, codigoProducto, My.Settings.Sucursal, stockCargado)
        form.ShowDialog()
        stockCargado = form.stockCargado
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
End Class