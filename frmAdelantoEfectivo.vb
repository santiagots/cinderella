Public Class frmAdelantoEfectivo
    Dim NegEmpleados As New Negocio.NegEmpleados
    Dim NegAdelantos As New Negocio.NegAdelantos
    Dim NegErrores As New Negocio.NegManejadorErrores
    Dim ESucursal As New Entidades.Sucursales
    Dim EAdelanto As New Entidades.Adelantos
    Dim id_Sucursal As String
    Dim Nombre_Sucursal As String
    Dim Funciones As New Funciones
    Public id_Adelanto As Integer = 0

    'Cuando carga el formulario.
    Private Sub frmAdelantoEfectivo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

            'si se le pasa un id_adeanto..
            RellenarFormulario()

            'Cambio el cursor a "NORMAL"
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show(ex.Message.ToString, "Adelanto de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'Cuando hace click en Aceptar.
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If txtMonto.Text = "" Or txtDescripcion.Text = "" Or txtDate.Text = "" Or cbEmpleado.SelectedItem Is Nothing Then
            MessageBox.Show("Debe completar los campos requeridos.", "Adelanto de Efectivo a Empleados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                'Cambio el cursor a "WAIT"
                Me.Cursor = Cursors.WaitCursor

                'Lleno la entidad Adelantos.

                'Si es un mov ya cargado levanto el id para hacer un update del mismo.
                If id_Adelanto <> 0 Then
                    EAdelanto.id_Adelanto = id_Adelanto
                Else
                    EAdelanto.id_Adelanto = 0
                End If

                EAdelanto.Fecha = Trim(txtDate.Text)
                If txtDescripcion.Text <> "" Then
                    EAdelanto.Descripcion = Replace(Trim(txtDescripcion.Text), vbCrLf, "<br />")
                Else
                    EAdelanto.Descripcion = ""
                End If
                EAdelanto.Monto = Trim(txtMonto.Text)
                EAdelanto.id_Empleado = cbEmpleado.SelectedValue
                EAdelanto.id_Sucursal = id_Sucursal

                'Limpiar Formulario.
                LimpiarFormulario()

                'Cambio el cursor a "NORMAL"
                Me.Cursor = Cursors.Arrow

                'Ejecuto el sp_Adelantos_Alta.
                MessageBox.Show(NegAdelantos.AltaAdelanto(EAdelanto), "Adelanto de Efectivo a Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                Me.Cursor = Cursors.Arrow
                MessageBox.Show("Se ha producido un error al registrar el adelanto. Por favor, intente más tarde.", "Adelanto de Efectivo a Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    'Funcion para Limpiar Formulario.
    Sub LimpiarFormulario()
        txtDescripcion.Clear()
        txtMonto.Clear()
        cbEmpleado.SelectedItem = Nothing
        txtDate.Value = Date.Now
        txtDate.Enabled = True
    End Sub

    Sub RellenarFormulario()
        LimpiarFormulario()
        If id_Adelanto <> 0 Then
            Dim dsAdelanto As New DataSet
            dsAdelanto = NegAdelantos.ObtenerAdelanto(id_Adelanto, id_Sucursal)
            txtMonto.Text = dsAdelanto.Tables(0).Rows(0).Item("Monto").ToString
            txtDescripcion.Text = Replace(dsAdelanto.Tables(0).Rows(0).Item("Descripcion").ToString, "<br />", vbCrLf)
            txtDate.Value = dsAdelanto.Tables(0).Rows(0).Item("Fecha").ToString
            cbEmpleado.SelectedValue = dsAdelanto.Tables(0).Rows(0).Item("id_Empleado").ToString
            txtDate.Enabled = False
            btnAceptar.Text = "Modificar"
            ToolAdelantos.SetToolTip(btnAceptar, "Al aceptar el formulario se modificará en el sistema el adelanto al empleado seleccionado.")
        Else
            btnAceptar.Text = "Aceptar"
            ToolAdelantos.SetToolTip(btnAceptar, "Al aceptar el formulario se registrará en el sistema el adelanto al empleado seleccionado.")
        End If
    End Sub

    'Cuando hace click en Cancelar.
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        LimpiarFormulario()
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
            ErrorAdelantos.SetError(txtMonto, "Debe ingresar el monto en el formato permitido. Ejemplo: 725,50")
        Else
            ErrorAdelantos.SetError(txtMonto, Nothing)
        End If
    End Sub

    Private Sub cbEmpleado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbEmpleado.SelectedIndexChanged
        txtMonto.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Cursor = Cursors.WaitCursor
        Me.WindowState = FormWindowState.Minimized
        Funciones.ControlInstancia(frmAdelantoListado).MdiParent = MDIContenedor
        Funciones.ControlInstancia(frmAdelantoListado).Show()
        Me.Cursor = Cursors.Arrow
    End Sub

End Class