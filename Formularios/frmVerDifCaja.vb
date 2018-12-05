Public Class frmVerDifCaja
    Public FDesde As String
    Public FHasta As String
    Public Tipo As Integer
    Dim NegMov As New Negocio.NegMovimientos

    Private Sub frmVerDifCaja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            'Cargo el datagrid
            Dim dsMov As DataSet
            dsMov = NegMov.ObtenerMovCajaFecha(My.Settings.Sucursal, FDesde, FHasta, Tipo)
            If dsMov.Tables(0).Rows.Count > 0 Then
                DG_Retiros.DataSource = dsMov.Tables(0)
                DG_Retiros.AutoGenerateColumns = False
                DG_Retiros.Columns("Monto").DefaultCellStyle.Format = "c"
                DG_Retiros.Refresh()
            End If

            If Tipo = 3 Then
                Me.Text = "Sobrantes de caja en la sucursal " & My.Settings("NombreSucursal")
                Gb_Comisiones.Text = "Sobrantes de caja entre el " & FDesde & " hasta el " & FHasta
            Else
                Me.Text = "Faltantes de caja en la sucursal " & My.Settings("NombreSucursal")
                Gb_Comisiones.Text = "Faltantes de caja entre el " & FDesde & " hasta el " & FHasta
            End If

            'Cambio el cursor a "NORMAL"
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show(ex.Message.ToString, "Visualización de Diferencias de Caja", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

End Class