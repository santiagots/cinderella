Imports System.Linq

Public Class frmVerSueldosSucursal
    Public id_Sucursal As Integer
    Public FDesde As String
    Public FHasta As String
    Dim NegEmpleados As New Negocio.NegEmpleados
    Dim NegAdelantos As New Negocio.NegAdelantos

    Private Sub frmVerSueldosSucursal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            'Cargo el datagrid
            Dim dsSueldos As New DataSet
            Dim dsAdelantos As New DataSet

            dsSueldos = NegEmpleados.SueldoDepositadoDetalleSucursal(id_Sucursal, FDesde, FHasta)
            dsSueldos.Tables(0).Columns.Add("Descripcion").Expression = "'Depósito de Sueldo'"

            dsAdelantos = NegAdelantos.ObtenerAdelantosSucursalListado(id_Sucursal, FDesde, FHasta)

            dsAdelantos.Tables(0).Merge(dsSueldos.Tables(0), False)

            Dim dv As DataView = dsAdelantos.Tables(0).DefaultView()

            dv.Sort = "Fecha"

            If dsSueldos.Tables(0).Rows.Count > 0 Then
                DG_Sueldos.AutoGenerateColumns = False
                DG_Sueldos.DataSource = dv
                DG_Sueldos.Columns("Monto").DefaultCellStyle.Format = "c"
                DG_Sueldos.Refresh()
            End If

            Me.Text = "Sueldos Sucursal " & My.Settings("NombreSucursal")
            Gb_Comisiones.Text = "Sueldos depositados entre el " & FDesde & " hasta el " & FHasta

            'Cambio el cursor a "NORMAL"
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "Sueldos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class