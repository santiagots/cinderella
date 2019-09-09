Public Class frmVerImpuestos
    Public FDesde As String
    Public FHasta As String
    Dim NegMov As New Negocio.NegMovimientos

    Private Sub frmVerImpuestos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            'Cargo el datagrid
            Dim dsMov As DataSet
            dsMov = NegMov.ObtenerMovImpuestoFecha(My.Settings.Sucursal, FDesde, FHasta)
            If dsMov.Tables(0).Rows.Count > 0 Then
                DG_Comisiones.DataSource = dsMov.Tables(0)
                DG_Comisiones.AutoGenerateColumns = False
                DG_Comisiones.Columns("Monto").DefaultCellStyle.Format = "c"
                DG_Comisiones.Refresh()
            End If

            Me.Text = "Impuestos abonados por la sucursal " & My.Settings("NombreSucursal")
            Gb_Comisiones.Text = "Impuestos abonados entre el " & FDesde & " hasta el " & FHasta

            'Cambio el cursor a "NORMAL"
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show(ex.Message.ToString, "Visualización de Impuestos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

End Class