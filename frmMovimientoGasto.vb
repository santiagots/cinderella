Public Class frmMovimientoGasto
    Dim NegErrores As New Negocio.NegManejadorErrores
    Dim NegMovimiento As New Negocio.NegMovimientos
    Dim eGasto As New Entidades.MovGasto
    Dim id_Sucursal As String
    Dim Nombre_Sucursal As String
    Dim dsMovimiento As New DataSet
    Public id_Movimiento As Int64 = 0
    Dim Funciones As New Funciones
    Dim SoloLectura As Boolean = False

    'Al cerrar el formulario me fijo si está abierto el form de listados, si lo está, hago foco.
    Private Sub frmMovimientoGasto_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If frmMovimientoPlanilla.Visible And id_Movimiento <> 0 Then
            frmMovimientoPlanilla.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub frmMovimientoGasto_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If frmMovimientoPlanilla.Visible And id_Movimiento <> 0 Then
            frmMovimientoPlanilla.RefrescarPlanilla()
        End If
    End Sub

    'Cuando carga el formulario.
    Private Sub frmMovimientoGasto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            'Sucursal default.
            id_Sucursal = My.Settings("Sucursal")
            Nombre_Sucursal = My.Settings("NombreSucursal")
            lbl_SucursalNombre.Text = Nombre_Sucursal

            'Cargo los tipos.
            Dim dsTiposMov As New DataSet
            dsTiposMov = NegMovimiento.ListadoTiposMov(1)
            If (dsTiposMov.Tables(0).Rows.Count > 0) Then
                CbTipo.DataSource = dsTiposMov.Tables(0)
                CbTipo.DisplayMember = "Tipo"
                CbTipo.ValueMember = "id_Tipo"
                CbTipo.Refresh()
            End If

            'Chequeo si hay ID modifico los textos.
            If id_Movimiento <> 0 Then
                'Cargo el movimiento en los controles
                dsMovimiento = NegMovimiento.ObtenerMov(id_Movimiento, id_Sucursal, "Gasto")
                txtMonto.Text = Format(CType(dsMovimiento.Tables(0).Rows(0).Item("Monto").ToString, Decimal), "###0.00")
                txtDate.Text = dsMovimiento.Tables(0).Rows(0).Item("Fecha").ToString
                txtObservaciones.Text = dsMovimiento.Tables(0).Rows(0).Item("Observaciones").ToString
                CbTipo.SelectedValue = dsMovimiento.Tables(0).Rows(0).Item("id_Tipo").ToString
                btnAceptar.Text = "Modificar"
                ToolGastos.SetToolTip(btnAceptar, "Al hacer click en el botón 'Modificar' del formulario se modificará en el sistema el retiro de dinero del socio cargado.")

                txtMonto.Enabled = Not dsMovimiento.Tables(0).Rows(0).Item("SoloLectura")
                txtDate.Enabled = Not dsMovimiento.Tables(0).Rows(0).Item("SoloLectura")
                CbTipo.Enabled = Not dsMovimiento.Tables(0).Rows(0).Item("SoloLectura")
                btnAceptar.Enabled = Not dsMovimiento.Tables(0).Rows(0).Item("SoloLectura")
                SoloLectura = dsMovimiento.Tables(0).Rows(0).Item("SoloLectura")

            Else
                btnAceptar.Text = "Aceptar"
                ToolGastos.SetToolTip(btnAceptar, "Al hacer click en el botón 'Aceptar' del formulario se registrará en el sistema el retiro de dinero del socio.")
            End If

            txtMonto.Focus()

            'Cambio el cursor a "NORMAL"
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha producido un error al cargar el formulario. Por favor, contáctese con el administrador", "Movimientos | Gastos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       
    End Sub

    'Valida solo moneda.
    Private Sub txtMonto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMonto.KeyPress
        If e.KeyChar.ToString() = "." Then
            e.KeyChar = CChar(",")
        End If

        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloCurrency(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
            ErrorGastos.SetError(txtMonto, "Debe ingresar el monto en el formato permitido. Ejemplo: 725,50")
        Else
            ErrorGastos.SetError(txtMonto, Nothing)
        End If
    End Sub

    'Funcion para Limpiar Formulario.
    Sub LimpiarFormulario()
        txtMonto.Clear()
        txtDate.Value = Date.Now
        txtObservaciones.Clear()
        CbTipo.SelectedItem = Nothing
        ErrorGastos.Clear()
    End Sub

    'Cuando hace click en Cancelar
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        If (SoloLectura) Then
            Me.Close()
        Else
            LimpiarFormulario()
        End If

    End Sub

    'Cuando hace click en Aceptar.
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If txtMonto.Text = "" Or txtDate.Text = "" Or CbTipo.SelectedItem Is Nothing Then
            MessageBox.Show("Debe completar los campos requeridos.", "Movimientos | Gastos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                'Cambio el cursor a "WAIT"
                Me.Cursor = Cursors.WaitCursor

                'Si es un mov ya cargado levanto el id para hacer un update del mismo.
                If dsMovimiento.Tables.Count > 0 Then
                    eGasto.id_Movimiento = dsMovimiento.Tables(0).Rows(0).Item("id_Movimiento").ToString
                    eGasto.id_Registro = dsMovimiento.Tables(0).Rows(0).Item("id_Registro").ToString
                Else
                    eGasto.id_Movimiento = 0
                    eGasto.id_Registro = 0
                End If
                eGasto.id_Sucursal = id_Sucursal
                eGasto.id_Tipo = CbTipo.SelectedValue
                eGasto.Fecha = Trim(txtDate.Text)
                eGasto.Monto = Trim(txtMonto.Text)
                eGasto.Observaciones = Trim(txtObservaciones.Text)
                eGasto.SoloLectura = False

                'Limpiar Formulario.
                LimpiarFormulario()

                'Cambio el cursor a "NORMAL"
                Me.Cursor = Cursors.Arrow

                'Ejecuto el sp.
                If (MessageBox.Show(NegMovimiento.AltaMovGasto(eGasto), "Movimientos | Gastos", MessageBoxButtons.OK, MessageBoxIcon.Information) = vbOK) Then
                    'Cierro el form
                    Me.Close()
                    Me.Dispose()
                End If

            Catch ex As Exception
                Me.Cursor = Cursors.Arrow
                MessageBox.Show("Se ha producido un error al registrar el movimiento. Por favor, intente más tarde.", "Movimientos | Gastos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub CbTipo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbTipo.LostFocus
        If CbTipo.SelectedValue = 20 Then
            Me.Cursor = Cursors.WaitCursor
            Me.Close()
            Funciones.ControlInstancia(frmPagarCuentaCorriente).MdiParent = MDIContenedor
            Funciones.ControlInstancia(frmPagarCuentaCorriente).Show()
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    'Change del combobox.
    Private Sub CbTipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbTipo.SelectedIndexChanged   
            txtMonto.Focus()
    End Sub

End Class