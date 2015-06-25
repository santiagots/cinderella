Public Class frmVerAdelantosSucursal
    Public id_Sucursal As Integer
    Public FDesde As String
    Public FHasta As String
    Dim NegAdelantos As New Negocio.NegAdelantos

    Private Sub frmVerAdelantosSucursal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            'Cargo el datagrid
            Dim dsAdelantos As New DataSet
            dsAdelantos = NegAdelantos.ObtenerAdelantosSucursalListado(id_Sucursal, FDesde, FHasta)
            If dsAdelantos.Tables(0).Rows.Count > 0 Then
                DG_Comisiones.DataSource = dsAdelantos.Tables(0)
                DG_Comisiones.AutoGenerateColumns = False
                DG_Comisiones.Columns("Adelanto").DefaultCellStyle.Format = "c"
                DG_Comisiones.Refresh()
            End If

            Me.Text = "Adelantos hechos en la sucursal " & My.Settings("NombreSucursal")
            Gb_Comisiones.Text = "Adelantos registrados entre el " & FDesde & " hasta el " & FHasta

            'Cambio el cursor a "NORMAL"
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show(ex.Message.ToString, "Adelantos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

End Class