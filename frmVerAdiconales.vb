Public Class frmVerAdiconales
    Public id_Empleado As Integer
    Public id_Sucursal As Integer
    Public FDesde As String
    Public FHasta As String
    Dim NegAdicionales As New Negocio.NegAdicionales
    Dim NegEmpleados As New Negocio.NegEmpleados
    Dim eEmpleado As Entidades.Empleados

    Private Sub frmVerAdiconales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            'Cargo el datagrid
            Dim dsAdicionales As New DataSet
            dsAdicionales = NegAdicionales.ListarAdicionalesEmpleado(id_Empleado, id_Sucursal, FDesde, FHasta)
            If dsAdicionales.Tables(0).Rows.Count > 0 Then
                DG_Comisiones.DataSource = dsAdicionales.Tables(0)
                DG_Comisiones.AutoGenerateColumns = False
                DG_Comisiones.Columns("Adicional").DefaultCellStyle.Format = "c"
                DG_Comisiones.Refresh()
            End If

            'Empleado
            eEmpleado = NegEmpleados.TraerEmpleado(id_Empleado)
            Me.Text = "Adicionales de " & eEmpleado.Apellido.ToUpper & " " & eEmpleado.Nombre.ToUpper
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