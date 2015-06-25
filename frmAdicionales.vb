Public Class frmAdicionales
    Dim id_Sucursal As String
    Dim Nombre_Sucursal As String
    Dim NegEmpleados As New Negocio.NegEmpleados
    Dim NegErrores As New Negocio.NegManejadorErrores
    Dim EAdicional As New Entidades.Adicionales
    Dim NegAdicionales As New Negocio.NegAdicionales

    'Cuando hace click en Cancelar.
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        LimpiarFormulario()
    End Sub

    'Funcion para Limpiar Formulario.
    Sub LimpiarFormulario()
        txtDescripcion.Clear()
        txtMonto.Clear()
        cbEmpleado.SelectedItem = Nothing
        txtDate.Value = Date.Now
        txtDate.Enabled = True
    End Sub

    Private Sub frmAdicionales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            'Sucursal default
            id_Sucursal = My.Settings("Sucursal")
            Nombre_Sucursal = My.Settings("NombreSucursal")

            'Cargo el cbEmpleado
            Dim dsEmpleados As New DataSet
            dsEmpleados = NegEmpleados.ListadoEmpleadosSucursal(id_Sucursal)
            If (dsEmpleados.Tables(0).Rows.Count > 0) Then
                cbEmpleado.DataSource = Nothing
                cbEmpleado.DataSource = dsEmpleados.Tables(0)
                cbEmpleado.DisplayMember = "NombreCompleto"
                cbEmpleado.ValueMember = "id_Empleado"
                cbEmpleado.Refresh()
            Else
                cbEmpleado.Items.Add("No hay empleados disponibles.")
                cbEmpleado.SelectedItem = "No hay empleados disponibles."
            End If

            'Cambio el cursor a "NORMAL"
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show(ex.Message.ToString, "Pago de Adicionales", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Valida solo moneda.
    Private Sub txtMonto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMonto.KeyPress
        If e.KeyChar.ToString() = "." Then
            e.KeyChar = CChar(",")
        End If
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloCurrencyNegative(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
            ErrorAdicionales.SetError(txtMonto, "Debe ingresar el monto en el formato permitido. Ejemplo: 725,50")
        Else
            ErrorAdicionales.SetError(txtMonto, Nothing)
        End If
    End Sub

    Private Sub cbEmpleado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbEmpleado.SelectedIndexChanged
        txtMonto.Focus()
    End Sub

    'Cuando hace click en Aceptar.
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If txtMonto.Text = "" Or txtDescripcion.Text = "" Or txtDate.Text = "" Or cbEmpleado.SelectedItem Is Nothing Then
            MessageBox.Show("Debe completar los campos requeridos.", "Pago de Adicionales", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                'Cambio el cursor a "WAIT"
                Me.Cursor = Cursors.WaitCursor

                'Lleno la entidad Adelantos.
                EAdicional.id_Adicional = 0
                EAdicional.Fecha = Trim(txtDate.Text)
                If txtDescripcion.Text <> "" Then
                    EAdicional.Descripcion = Replace(Trim(txtDescripcion.Text), vbCrLf, "<br />")
                Else
                    EAdicional.Descripcion = ""
                End If
                EAdicional.Monto = Trim(txtMonto.Text)
                EAdicional.id_Empleado = cbEmpleado.SelectedValue
                EAdicional.id_Sucursal = id_Sucursal

                'Limpiar Formulario.
                LimpiarFormulario()

                'Cambio el cursor a "NORMAL"
                Me.Cursor = Cursors.Arrow

                'Ejecuto el sp_Adelantos_Alta.
                MessageBox.Show(NegAdicionales.AltaAdicional(EAdicional), "Pago de Adicionales", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                Me.Cursor = Cursors.Arrow
                MessageBox.Show("Se ha producido un error al registrar el adicional. Por favor, intente más tarde.", "Pago de Adicionales", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

End Class