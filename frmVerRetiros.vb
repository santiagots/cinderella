Public Class frmVerRetiros
    Public FDesde As String
    Public FHasta As String
    Dim NegMov As New Negocio.NegMovimientos

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub frmVerRetiros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            'Cargo el datagrid
            Dim dsMov As DataSet
            dsMov = NegMov.ObtenerMovRetiroFecha(My.Settings.Sucursal, FDesde, FHasta)
            If dsMov.Tables(0).Rows.Count > 0 Then
                DG_Retiros.DataSource = dsMov.Tables(0)
                DG_Retiros.AutoGenerateColumns = False
                DG_Retiros.Columns("Monto").DefaultCellStyle.Format = "c"
                DG_Retiros.Refresh()
            End If

            Me.Text = "Retiros de socios realizados en la sucursal " & My.Settings("NombreSucursal")
            Gb_Comisiones.Text = "Retiros de socios realizados entre el " & FDesde & " hasta el " & FHasta

            'Cambio el cursor a "NORMAL"
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show(ex.Message.ToString, "Visualización de Retiros", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class