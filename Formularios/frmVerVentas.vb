Public Class frmVerVentas
    Public id_Sucursal As Integer
    Public FDesde As String
    Public FHasta As String
    Dim NegVenta As New Negocio.NegVentas

    Private Sub frmVerVentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            'Cargo el datagrid
            Dim dsVentas As New DataSet
            dsVentas = NegVenta.ObtenerVentasSucursalListado(id_Sucursal, FDesde, FHasta)
            If dsVentas.Tables(0).Rows.Count > 0 Then
                DG_Comisiones.DataSource = dsVentas.Tables(0)
                DG_Comisiones.AutoGenerateColumns = False
                DG_Comisiones.Columns("Monto").DefaultCellStyle.Format = "c"
                DG_Comisiones.Refresh()
            End If

            'Empleado
            Me.Text = "Ventas de la sucursal " & My.Settings("NombreSucursal")
            Gb_Comisiones.Text = "Ventas registradas entre el " & FDesde & " hasta el " & FHasta

            'Cambio el cursor a "NORMAL"
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show(ex.Message.ToString, "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class