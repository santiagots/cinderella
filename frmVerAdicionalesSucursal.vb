Public Class frmVerAdicionalesSucursal
    Public id_Sucursal As Integer
    Public FDesde As String
    Public FHasta As String
    Dim NegAdicionales As New Negocio.NegAdicionales

    Private Sub frmVerAdicionalesSucursal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            'Cargo el datagrid
            Dim dsAdelantos As New DataSet
            dsAdelantos = NegAdicionales.ObtenerAdicionalesSucursalListado(id_Sucursal, FDesde, FHasta)
            If dsAdelantos.Tables(0).Rows.Count > 0 Then
                DG_Comisiones.DataSource = dsAdelantos.Tables(0)
                DG_Comisiones.AutoGenerateColumns = False
                DG_Comisiones.Columns("Adicional").DefaultCellStyle.Format = "c"
                DG_Comisiones.Refresh()
            End If

            Me.Text = "Adicionales hechos en la sucursal " & My.Settings("NombreSucursal")
            Gb_Comisiones.Text = "Adicionales registrados entre el " & FDesde & " hasta el " & FHasta

            'Cambio el cursor a "NORMAL"
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show(ex.Message.ToString, "Adicionales", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class