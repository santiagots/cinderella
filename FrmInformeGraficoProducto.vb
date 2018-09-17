Public Class FrmInformeGraficoProducto

    Public TopProductosMonto As DataTable
    Public TopProductosCantidad As DataTable
    Public TopSubcategoriaMonto As DataTable
    Public TopSubcategoriaCantidad As DataTable

    Private Sub FrmInformeGraficoProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chtTopProductosMonto.DataSource = TopProductosMonto
        chtTopProductosCantidad.DataSource = TopProductosCantidad
        chtTopSubcategoriaMonto.DataSource = TopSubcategoriaMonto
        chtTopSubcategoriaCantidad.DataSource = TopSubcategoriaCantidad
    End Sub
End Class