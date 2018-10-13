Imports Negocio

Public Class frmInformeProducto

    Property sucursalesId As List(Of Integer)
    Property fechaDesde As Date
    Property fechaHasta As Date
    Property idProducto As String
    Property idCategoria As String
    Property idSubCategoria As String


    Private Sub frmInformeDetalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Public Sub inicializar()
        ucPaginadoProductos.OrdenColumna = dgvProductos.Columns(0).DataPropertyName
        ucPaginadoProductos.OrdenDireccion = SortOrder.Descending
        ucPaginadoProductos.PaginaTamaño = 50
        ucPaginadoProductos.PaginaActual = 1

        Productos()

        chtVentasProducto.DataSource = ObtenerTodasLasPaginas()
        chtVentasProducto.DataBind()
    End Sub

    Private Sub ucPaginadoProductos_btnInicioClick(sender As Object, e As EventArgs) Handles ucPaginadoProductos.btnInicioClick
        Productos()
    End Sub

    Private Sub ucPaginadoProductos_btnFinClick(sender As Object, e As EventArgs) Handles ucPaginadoProductos.btnFinClick
        Productos()
    End Sub

    Private Sub ucPaginadoProductos_btnProximaClick(sender As Object, e As EventArgs) Handles ucPaginadoProductos.btnProximaClick
        Productos()
    End Sub

    Private Sub ucPaginadoProductos_btnAnteriorClick(sender As Object, e As EventArgs) Handles ucPaginadoProductos.btnAnteriorClick
        Productos()
    End Sub

    Private Sub dgvProductos_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvProductos.DataBindingComplete
        lblMensajeProducto.Visible = Not dgvProductos.RowCount > 0
    End Sub

    Private Sub Productos()
        Try
            Me.Cursor = Cursors.WaitCursor

            dgvProductos.AutoGenerateColumns = False
            dgvProductos.DataSource = NegInformes.ObtenerVentasDia(idProducto, idCategoria, idSubCategoria, sucursalesId, fechaDesde, fechaHasta, ucPaginadoProductos.PaginaActual, ucPaginadoProductos.PaginaTamaño, ucPaginadoProductos.OrdenColumna, ucPaginadoProductos.OrdenDireccion, ucPaginadoProductos.TotalElementos)

        Catch ex As Exception
            MessageBox.Show("Se ha producido un error al consultar los productos. Por favor, Comuníquese con el administrador.", "Informe de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Me.Cursor = Cursors.Arrow
        End Try
    End Sub

    Private Sub dgvProductos_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvProductos.ColumnHeaderMouseClick
        ucPaginadoProductos.OrdenColumna = dgvProductos.Columns(e.ColumnIndex).DataPropertyName
        ucPaginadoProductos.OrdenDireccion = If(ucPaginadoProductos.OrdenDireccion = SortOrder.Ascending, SortOrder.Descending, SortOrder.Ascending)
        Productos()
        dgvProductos.Columns(e.ColumnIndex).HeaderCell.SortGlyphDirection = ucPaginadoProductos.OrdenDireccion
    End Sub

    Private Function ObtenerTodasLasPaginas()

        Dim paginaActual As Integer = 1
        Dim tamañoPagina As Integer = 200
        Dim totalElementos As Integer = 0
        Dim resultado As DataTable = New DataTable()
        Do
            Dim temp As DataTable = NegInformes.ObtenerVentasDia(idProducto, idCategoria, idSubCategoria, sucursalesId, fechaDesde, fechaHasta, paginaActual, tamañoPagina, "", SortOrder.None, totalElementos)

            If temp.Rows.Count = 0 Then
                Exit Do
            End If

            If paginaActual = 1 Then
                resultado = temp.Clone()
            End If

            paginaActual += 1

            For Each item As DataRow In temp.Rows
                resultado.ImportRow(item)
            Next
        Loop

        Return resultado
    End Function
End Class