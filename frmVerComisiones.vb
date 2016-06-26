Public Class frmVerComisiones
    Public id_Empleado As Integer
    Public id_Sucursal As Integer
    Public FDesde As String
    Public FHasta As String
    Dim NegComisiones As New Negocio.NegComisiones
    Dim NegEmpleados As New Negocio.NegEmpleados
    Dim eEmpleado As Entidades.Empleados

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub frmVerComisiones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            'Cargo el datagrid
            Dim dsComisiones As New DataSet
            dsComisiones = NegComisiones.ListarComisionesEmpleado(id_Empleado, id_Sucursal, FDesde, FHasta)
            If dsComisiones.Tables(0).Rows.Count > 0 Then
                DG_Comisiones.DataSource = dsComisiones.Tables(0)
                DG_Comisiones.AutoGenerateColumns = False
                DG_Comisiones.Columns("Comision").DefaultCellStyle.Format = "c"
                DG_Comisiones.Columns("Precio_Total").DefaultCellStyle.Format = "c"
                DG_Comisiones.Refresh()
            End If

            'Empleado
            eEmpleado = NegEmpleados.TraerEmpleadoPorIdEmpleado(id_Empleado)
            Me.Text = "Comisiones de " & eEmpleado.Apellido.ToUpper & " " & eEmpleado.Nombre.ToUpper
            Gb_Comisiones.Text = "Comisiones registradas entre el " & FDesde & " hasta el " & FHasta

            'Cambio el cursor a "NORMAL"
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "Comisiones", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class