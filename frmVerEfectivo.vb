Public Class frmVerEfectivo
    Public FDesde As String
    Public FHasta As String
    Public Tipo As String
    Dim NegMov As New Negocio.NegMovimientos

    Private Sub frmVerEfectivo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            'Cargo el datagrid
            Dim dsMov As DataSet
            dsMov = NegMov.ObtenerMovEgresoFecha(My.Settings.Sucursal, FDesde, FHasta, Tipo)
            If dsMov.Tables(0).Rows.Count > 0 Then
                DG_Retiros.DataSource = dsMov.Tables(0)
                DG_Retiros.AutoGenerateColumns = False
                DG_Retiros.Columns("Monto").DefaultCellStyle.Format = "c"
                DG_Retiros.Refresh()
            End If

            If Tipo = "Ingresos" Then
                Me.Text = "Ingresos de efectivo en la sucursal " & My.Settings("NombreSucursal")
                Gb_Comisiones.Text = "Ingresos de efectivo entre el " & FDesde & " hasta el " & FHasta
            ElseIf Tipo = "Egresos" Then
                Me.Text = "Egresos de efectivo en la sucursal " & My.Settings("NombreSucursal")
                Gb_Comisiones.Text = "Egresos de efectivo entre el " & FDesde & " hasta el " & FHasta
            End If

            'Cambio el cursor a "NORMAL"
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show(ex.Message.ToString, "Visualización de Efectivos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

End Class