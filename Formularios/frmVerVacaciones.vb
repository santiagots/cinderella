Public Class frmVerVacaciones
    Public id_Empleado As Integer
    Public id_Sucursal As Integer
    Public FDesde As String
    Public FHasta As String
    Dim NegEmpleados As New Negocio.NegEmpleados
    Dim NegRecibos As New Negocio.NegRecibos
    Dim eEmpleado As Entidades.Empleados

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub frmVerVacaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            'Cargo el datagrid
            Dim dsVacaciones As New DataSet
            dsVacaciones = NegRecibos.ListarVacacionesEmpleado(id_Empleado, id_Sucursal, FDesde, FHasta)
            If dsVacaciones.Tables(0).Rows.Count > 0 Then
                DG_Comisiones.DataSource = dsVacaciones.Tables(0)
                DG_Comisiones.AutoGenerateColumns = False
                DG_Comisiones.Columns("Monto").DefaultCellStyle.Format = "c"
                DG_Comisiones.Columns("Fecha").DefaultCellStyle.Format = "d"
                DG_Comisiones.Refresh()
            End If

            'Empleado
            eEmpleado = NegEmpleados.TraerEmpleadoPorIdEmpleado(id_Empleado)
            Me.Text = "Pago de Vacaciones de " & eEmpleado.Apellido.ToUpper & " " & eEmpleado.Nombre.ToUpper
            Gb_Comisiones.Text = "Vacaciones registradas entre el " & FDesde & " hasta el " & FHasta

            'Cambio el cursor a "NORMAL"
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "Vacaciones", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class