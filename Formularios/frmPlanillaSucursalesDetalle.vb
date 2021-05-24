Public Class frmPlanillaSucursalesDetalle

    Public FDesde As String
    Public FHasta As String
    Public NombreDetalle As String
    Public DetalleDataTable As DataTable

    Private Sub frmPlanillaSucursalesDetalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DG_Planilla.DataSource = DetalleDataTable

        'Defino el color alternativo de las rows
        DG_Planilla.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 221, 235, 247)

        DG_Planilla.Columns("Nivel").Visible = False

        'Defino el formato de las columnas
        For i As Integer = 2 To DG_Planilla.Columns.Count - 1
            DG_Planilla.Columns(i).DefaultCellStyle.Format = "c"
        Next

        Me.Text = String.Format("Planilla de Movimientos de sucursal detalle {0} sucursal {1}", NombreDetalle, My.Settings("NombreSucursal"))
        Gb_Detalle.Text = String.Format("Detalle {0} entre el {1} hasta el {1}", NombreDetalle, FDesde, FHasta)

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub DG_Planilla_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DG_Planilla.CellFormatting
        If (Not IsDBNull(DG_Planilla.Rows(e.RowIndex).Cells("Nivel").Value) AndAlso DG_Planilla.Rows(e.RowIndex).Cells("Nivel").Value = 1) Then
            e.CellStyle.BackColor = Color.FromArgb(255, 91, 155, 213)
            e.CellStyle.Font = New Font(e.CellStyle.Font, FontStyle.Bold)
            e.CellStyle.ForeColor = Color.White
        ElseIf (Not IsDBNull(DG_Planilla.Rows(e.RowIndex).Cells("Nivel").Value) AndAlso DG_Planilla.Rows(e.RowIndex).Cells("Nivel").Value = 0) Then
            e.CellStyle.BackColor = Color.FromArgb(255, 91, 155, 213)
            e.CellStyle.Font = New Font(e.CellStyle.Font.Name, (e.CellStyle.Font.Size + 2), FontStyle.Bold)
            e.CellStyle.ForeColor = Color.White
        ElseIf (Not IsDBNull(DG_Planilla.Rows(e.RowIndex).Cells("Nivel").Value) AndAlso DG_Planilla.Rows(e.RowIndex).Cells("Nivel").Value = -1) Then
            e.CellStyle.BackColor = Color.FromArgb(255, 91, 155, 213)
            e.CellStyle.Font = New Font(e.CellStyle.Font, FontStyle.Bold)
            e.CellStyle.ForeColor = Color.White
            e.CellStyle.Format = "P"
        Else
            e.CellStyle.Font = New Font(e.CellStyle.Font.Name, (e.CellStyle.Font.Size - 2))
        End If

    End Sub
End Class