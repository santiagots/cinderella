Imports System.ComponentModel
Imports SistemaCinderella.Formularios.MovimientoDetalle

Public Class frmMoviminetoDetalle(Of T)

    Sub New(frmMoviminetoDetalleViewModel As frmMoviminetoDetalleViewModel(Of T))
        ' This call is required by the designer.
        InitializeComponent()

        Me.GroupBox.Text = frmMoviminetoDetalleViewModel.Titulo
        Me.dgvMovimientosDetalle.DataSource = frmMoviminetoDetalleViewModel.MovimientoDetalle
    End Sub

    Private Sub dgvMovimientosDetalle_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvMovimientosDetalle.CellFormatting
        If Me.dgvMovimientosDetalle.Columns(e.ColumnIndex).ValueType = GetType(Decimal) Then
            e.CellStyle.Format = "C2"
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class