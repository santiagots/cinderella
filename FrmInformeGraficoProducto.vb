Public Class FrmInformeGraficoProducto

    Public TopProductosMonto As DataTable
    Public TopProductosCantidad As DataTable
    Public TopSubcategoriaMonto As DataTable
    Public TopSubcategoriaCantidad As DataTable
    Public TopCategoriaMonto As DataTable
    Public TopCategoriaCantidad As DataTable

    Private Sub FrmInformeGraficoProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chtTopProductosMonto.DataSource = TopProductosMonto
        chtTopProductosCantidad.DataSource = TopProductosCantidad
        chtTopSubcategoriaMonto.DataSource = TopSubcategoriaMonto
        chtTopSubcategoriaCantidad.DataSource = TopSubcategoriaCantidad
        chtTopCategoriaMonto.DataSource = TopCategoriaMonto
        chtTopCategoriaCantidad.DataSource = TopCategoriaCantidad
    End Sub
End Class