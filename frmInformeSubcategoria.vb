Imports Negocio

Public Class frmInformeSubcategoria
    Property sucursalesId As List(Of Integer)
    Property fechaDesde As Date
    Property fechaHasta As Date
    Property idSubcategoria As Integer
    Property nombreSubcategoria As String


    Private Sub frmInformeSubcategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GroupBox6.Text = "Ventas Subcategoria " + nombreSubcategoria

        ucPaginadoSubcategoria.OrdenColumna = dgvSubcategoria.Columns(0).DataPropertyName
        ucPaginadoSubcategoria.OrdenDireccion = SortOrder.Descending
        ucPaginadoSubcategoria.PaginaTamaño = 50
        ucPaginadoSubcategoria.PaginaActual = 1

        Subcategoria()

        chtSubcategoriaVentas.DataSource = ObtenerTodasLasPaginas(sucursalesId, fechaDesde, fechaHasta, idSubcategoria)

    End Sub

    Private Sub ucPaginadoSubcategoria_btnInicioClick(sender As Object, e As EventArgs) Handles ucPaginadoSubcategoria.btnInicioClick
        Subcategoria()
    End Sub

    Private Sub ucPaginadoSubcategoria_btnFinClick(sender As Object, e As EventArgs) Handles ucPaginadoSubcategoria.btnFinClick
        Subcategoria()
    End Sub

    Private Sub ucPaginadoSubcategoria_btnProximaClick(sender As Object, e As EventArgs) Handles ucPaginadoSubcategoria.btnProximaClick
        Subcategoria()
    End Sub

    Private Sub ucPaginadoSubcategoria_btnAnteriorClick(sender As Object, e As EventArgs) Handles ucPaginadoSubcategoria.btnAnteriorClick
        Subcategoria()
    End Sub

    Private Sub dgvSubcategoria_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvSubcategoria.DataBindingComplete
        lblMensajeSubcategoria.Visible = Not dgvSubcategoria.RowCount > 0
    End Sub

    Private Sub Subcategoria()
        Try
            Me.Cursor = Cursors.WaitCursor

            dgvSubcategoria.AutoGenerateColumns = False
            dgvSubcategoria.DataSource = NegInformes.ObtenerVentasDiaSubcategoria(sucursalesId, fechaDesde, fechaHasta, idSubcategoria, ucPaginadoSubcategoria.PaginaActual, ucPaginadoSubcategoria.PaginaTamaño, ucPaginadoSubcategoria.OrdenColumna, ucPaginadoSubcategoria.OrdenDireccion, ucPaginadoSubcategoria.TotalElementos)

        Catch ex As Exception
            MessageBox.Show("Se ha producido un error al consultar los productos. Por favor, Comuníquese con el administrador.", "Informe de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Me.Cursor = Cursors.Arrow
        End Try
    End Sub

    Private Sub dgvSubcategoria_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvSubcategoria.ColumnHeaderMouseClick
        ucPaginadoSubcategoria.OrdenColumna = dgvSubcategoria.Columns(e.ColumnIndex).DataPropertyName
        ucPaginadoSubcategoria.OrdenDireccion = If(ucPaginadoSubcategoria.OrdenDireccion = SortOrder.Ascending, SortOrder.Descending, SortOrder.Ascending)
        Subcategoria()
        dgvSubcategoria.Columns(e.ColumnIndex).HeaderCell.SortGlyphDirection = ucPaginadoSubcategoria.OrdenDireccion
    End Sub

    Private Function ObtenerTodasLasPaginas(id_Sucursales As List(Of Integer), FDesde As Date, FHasta As Date, idProducto As Integer)

        Dim paginaActual As Integer = 1
        Dim tamañoPagina As Integer = 200
        Dim totalElementos As Integer = 0
        Dim resultado As DataTable = New DataTable()
        Do
            Dim temp As DataTable = NegInformes.ObtenerVentasDiaSubcategoria(id_Sucursales, FDesde, FHasta, idProducto, paginaActual, tamañoPagina, "", SortOrder.None, totalElementos)

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