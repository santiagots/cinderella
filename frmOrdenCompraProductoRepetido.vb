Imports Entidades
Imports Negocio

Public Class frmOrdenCompraProductoRepetido

    Dim NegOrdenCompra As NegOrdenCompra = New NegOrdenCompra()
    Dim NegProveedor As NegProveedores = New NegProveedores()
    Dim NegStock As NegStock = New NegStock()


    Public Property OrdenCompraDetalle As OrdenCompraDetalle
    Public Property OrdenCompra As List(Of OrdenCompra)
    Private Sub frmOrdenCompraProductoRepetido_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        OrdenCompraBindingSource.DataSource = OrdenCompra
        txtCantidadIngresada.Text = OrdenCompraDetalle.Cantidad
        txtCodigo.Text = OrdenCompraDetalle.Codigo
        txtNombre.Text = OrdenCompraDetalle.Nombre

        Dim proveedor As Proveedores = NegProveedor.TraerProveedor(OrdenCompra.First.idProveedor)
        Dim stock As Stock = NegStock.TraerStockProducto(OrdenCompraDetalle.idProducto, My.Settings.Sucursal)
        Dim StockYaPedido As Integer = OrdenCompra.SelectMany(Function(x) x.Detalles).Where(Function(x) x.Codigo = OrdenCompraDetalle.Codigo).Sum(Function(x) x.Cantidad).ToString()

        txtTotalPedido.Text = StockYaPedido
        txtDiferencia.Text = If(OrdenCompraDetalle.Cantidad - StockYaPedido < 1, 0, OrdenCompraDetalle.Cantidad - StockYaPedido)

    End Sub

    Private Sub dgwOrdenCompra_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgwOrdenCompra.CellFormatting
        If (dgwOrdenCompra.Columns(e.ColumnIndex).Name = "Cantidad") Then
            Dim OrdenCompra As OrdenCompra = dgwOrdenCompra.Rows(e.RowIndex).DataBoundItem

            e.Value = OrdenCompra.Detalles.Where(Function(x) x.Codigo = OrdenCompraDetalle.Codigo).Sum(Function(x) x.Cantidad).ToString()

        End If
    End Sub

    Private Sub btnMantener_Click(sender As Object, e As EventArgs) Handles btnMantener.Click
        Me.DialogResult = DialogResult.Yes
    End Sub

    Private Sub btnDiferencia_Click(sender As Object, e As EventArgs) Handles btnDiferencia.Click
        Me.DialogResult = DialogResult.Yes
        OrdenCompraDetalle.Cantidad = txtDiferencia.Text
    End Sub

    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        Me.DialogResult = DialogResult.No
    End Sub
End Class