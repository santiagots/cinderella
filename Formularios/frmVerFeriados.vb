Public Class frmVerFeriados
    Public id_Empleado As Integer
    Public id_Sucursal As Integer
    Public FDesde As String
    Public FHasta As String
    Dim NegRegistros As New Negocio.NegRegistros
    Dim NegEmpleados As New Negocio.NegEmpleados
    Dim eEmpleado As Entidades.Empleados
    Private Sub frmVerFeriados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            'Cargo el datagrid
            Dim Registros As New DataSet
            Registros = NegRegistros.ListarDiasFeriadosEmpleado(id_Empleado, id_Sucursal, FDesde, FHasta)
            If Registros.Tables(0).Rows.Count > 0 Then
                DG_Dias.DataSource = Registros.Tables(0)
                DG_Dias.AutoGenerateColumns = False
                DG_Dias.Refresh()
            End If

            'Empleado
            eEmpleado = NegEmpleados.TraerEmpleadoPorIdEmpleado(id_Empleado)
            Me.Text = "Días trabajados Feriados " & eEmpleado.Apellido.ToUpper & " " & eEmpleado.Nombre.ToUpper
            Gb_Comisiones.Text = "Días trabajados entre el " & FDesde & " hasta el " & FHasta

            'Cambio el cursor a "NORMAL"
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show(ex.Message.ToString, "Feriados", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class