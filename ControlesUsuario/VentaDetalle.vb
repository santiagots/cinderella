Imports SistemaCinderella.Comunes

Public Class VentaDetalle
    Public Event VentaItemModificada As EventHandler(Of VentaItemModificadoEventArgs)
    Public Event VentaItemSeleccionadas As EventHandler(Of VentaItemSeleccionadasEventArgs)

    Public Property ColumnaFacturarVisible As Boolean = False
    Public Property ColumnaSeleccionarVisible As Boolean = False


    Private Sub VentaDetalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DG_Productos.Columns("Facturar").Visible = ColumnaFacturarVisible
        DG_ProductosTotales.Columns("TotalFacturar").Visible = ColumnaFacturarVisible

        DG_Productos.Columns("Seleccionada").Visible = ColumnaSeleccionarVisible
        DG_ProductosTotales.Columns("TotalSeleccionada").Visible = ColumnaSeleccionarVisible

        Dim DatagridViewCheckBoxHeaderCell As DatagridViewCheckBoxHeaderCell = DG_Productos.Columns("Seleccionada").HeaderCell
        AddHandler DatagridViewCheckBoxHeaderCell.OnCheckBoxClicked, New CheckBoxClickedHandler(AddressOf datagridViewCheckBoxHeaderCell_OnCheckBoxClicked)
    End Sub

    Private Sub datagridViewCheckBoxHeaderCell_OnCheckBoxClicked(columnIndex As Integer, state As Boolean)
        Dim ventaItemSeleccionadasEventArgs As VentaItemSeleccionadasEventArgs = New VentaItemSeleccionadasEventArgs() With {.Seleccionada = state}
        RaiseEvent VentaItemSeleccionadas(Me, ventaItemSeleccionadasEventArgs)
    End Sub

    Private Sub DG_Productos_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DG_Productos.CellEndEdit
        Dim columnas As List(Of String) = New List(Of String) From {"Seleccionada"}

        If (columnas.Any(Function(x) DG_Productos.Columns(e.ColumnIndex).Name = x)) Then

            Dim ventaItemViewModel As VentaItemViewModel = DG_Productos.CurrentRow.DataBoundItem
            ventaItemViewModel.Seleccionado = DG_Productos.Rows(e.RowIndex).Cells("Seleccionada").Value 'Actualizo el valor porque no se actualiza con el binding de la grilla
            Dim VentaItemModificadaEventArgs As VentaItemModificadoEventArgs = New VentaItemModificadoEventArgs() With {.VentaItemViewModel = ventaItemViewModel}
            RaiseEvent VentaItemModificada(sender, VentaItemModificadaEventArgs)
        End If
    End Sub

    ''Fuerzo la ejecucion del EndEdit en el click del checkbox Seleccionada
    Private Sub DG_Productos_OnCellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DG_Productos.CellMouseUp
        If (e.RowIndex < 0) Then
            Return
        End If

        If e.ColumnIndex = DG_Productos.Columns("Seleccionada").Index Then
            DG_Productos.EndEdit()
        End If
    End Sub
End Class

Public Class VentaItemModificadoEventArgs
    Inherits EventArgs

    Public Property VentaItemViewModel As VentaItemViewModel
End Class

Public Class VentaItemSeleccionadasEventArgs
    Inherits EventArgs

    Public Property Seleccionada As Boolean
End Class