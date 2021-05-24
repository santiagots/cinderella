Public Class frmVerComision
    Public FDesde As String
    Public FHasta As String
    Dim NegComision As New Negocio.NegComisiones

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub frmVerComision_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            'Cargo el datagrid
            Dim dsComi As New DataSet
            dsComi = NegComision.ObtenerComisionPorPeriodo(My.Settings.Sucursal, FDesde, FHasta)
            If dsComi.Tables(0).Rows.Count > 0 Then
                DG_Comisiones.DataSource = dsComi.Tables(0)
                DG_Comisiones.AutoGenerateColumns = False
                DG_Comisiones.Columns("Monto").DefaultCellStyle.Format = "c"
                DG_Comisiones.Columns("Comision").DefaultCellStyle.Format = "c"
                DG_Comisiones.Refresh()
            End If

            Me.Text = "Comisiones otorgadas en la sucursal " & My.Settings("NombreSucursal")
            Gb_Comisiones.Text = "Comisiones otorgadas entre el " & FDesde & " hasta el " & FHasta

            'Cambio el cursor a "NORMAL"
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show(ex.Message.ToString, "Visualización de Comisiones", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class