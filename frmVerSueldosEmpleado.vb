Public Class frmVerSueldosEmpleado
    Public id_Empleado As Integer
    Public id_Sucursal As Integer
    Public FDesde As String
    Public FHasta As String
    Dim NegComisiones As New Negocio.NegComisiones
    Dim NegEmpleados As New Negocio.NegEmpleados
    Dim eEmpleado As Entidades.Empleados
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub frmVerSueldosEmpleado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            'Cargo el datagrid
            Dim dsComisiones As New DataSet
            dsComisiones = NegEmpleados.SueldoDepositadoDetalle(id_Empleado, id_Sucursal, FDesde, FHasta)
            If dsComisiones.Tables(0).Rows.Count > 0 Then
                DG_Sueldos.AutoGenerateColumns = False
                DG_Sueldos.DataSource = dsComisiones.Tables(0)
                DG_Sueldos.Columns("Monto").DefaultCellStyle.Format = "c"
                DG_Sueldos.Refresh()
            End If

            'Empleado
            eEmpleado = NegEmpleados.TraerEmpleado(id_Empleado)
            Me.Text = "Sueldos de " & eEmpleado.Apellido.ToUpper & " " & eEmpleado.Nombre.ToUpper
            Gb_Comisiones.Text = "Sueldos depositados entre el " & FDesde & " hasta el " & FHasta

            'Cambio el cursor a "NORMAL"
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "Sueldos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class