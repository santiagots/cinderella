Public Class frmMovimientoImpuesto
    Dim NegErrores As New Negocio.NegManejadorErrores
    Dim NegMovimiento As New Negocio.NegMovimientos
    Dim eImpuesto As New Entidades.MovImpuesto
    Dim id_Sucursal As String
    Dim Nombre_Sucursal As String
    Dim dsMovimiento As New DataSet
    Public id_Movimiento As Integer = 0

    'Al cerrar el formulario me fijo si está abierto el form de listados, si lo está, hago foco.
    Private Sub frmMovimientoImpuesto_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If frmMovimientoPlanilla.Visible And id_Movimiento <> 0 Then
            frmMovimientoPlanilla.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub frmMovimientoImpuesto_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If frmMovimientoPlanilla.Visible And id_Movimiento <> 0 Then
            frmMovimientoPlanilla.RefrescarPlanilla()
        End If
    End Sub

    'Cuando carga el formulario.
    Private Sub frmMovimientoImpuesto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            'Sucursal default
            id_Sucursal = My.Settings("Sucursal")
            Nombre_Sucursal = My.Settings("NombreSucursal")
            lbl_SucursalNombre.Text = Nombre_Sucursal

            'Cargo los tipos de impuestos.
            Dim dsTiposMov As New DataSet
            dsTiposMov = NegMovimiento.ListadoTiposMov(3)
            If (dsTiposMov.Tables(0).Rows.Count > 0) Then
                CbTipo.DataSource = dsTiposMov.Tables(0)
                CbTipo.DisplayMember = "Tipo"
                CbTipo.ValueMember = "id_Tipo"
                CbTipo.Refresh()
            End If

            'Chequeo si hay ID modifico los textos.
            If id_Movimiento <> 0 Then
                'Cargo el movimiento en los controles
                dsMovimiento = NegMovimiento.ObtenerMov(id_Movimiento, id_Sucursal, "Impuesto")
                CbTipo.SelectedValue = dsMovimiento.Tables(0).Rows(0).Item("id_Tipo").ToString
                txtMonto.Text = Format(CType(dsMovimiento.Tables(0).Rows(0).Item("Monto").ToString, Decimal), "###0.00")
                txtDate.Text = dsMovimiento.Tables(0).Rows(0).Item("Fecha").ToString

                btnAceptar.Text = "Modificar"
                ToolImpuestos.SetToolTip(btnAceptar, "Al hacer click en el botón 'Modificar' del formulario se modificará en el sistema el retiro de dinero del socio cargado.")
            Else
                btnAceptar.Text = "Aceptar"
                ToolImpuestos.SetToolTip(btnAceptar, "Al hacer click en el botón 'Aceptar' del formulario se registrará en el sistema el retiro de dinero del socio.")
            End If

            txtMonto.Focus()

            'Cambio el cursor a "NORMAL"
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha producido un error al cargar el formulario. Por favor, contáctese con el administrador", "Movimientos | Impuestos", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            ErrorImpuestos.SetError(txtMonto, "Debe ingresar el monto en el formato permitido. Ejemplo: 725,50")
        Else
            ErrorImpuestos.SetError(txtMonto, Nothing)
        End If
    End Sub

    'Funcion para Limpiar Formulario.
    Sub LimpiarFormulario()
        txtMonto.Clear()
        txtDate.Value = Date.Now
        CbTipo.SelectedItem = Nothing
        ErrorImpuestos.Clear()
    End Sub

    'Cuando hace click en Cancelar
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        LimpiarFormulario()
    End Sub

    'Cuando hace click en Aceptar.
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If txtMonto.Text = "" Or txtDate.Text = "" Or CbTipo.SelectedItem Is Nothing Then
            MessageBox.Show("Debe completar los campos requeridos.", "Movimientos | Impuestos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                'Cambio el cursor a "WAIT"
                Me.Cursor = Cursors.WaitCursor

                'Si es un mov ya cargado levanto el id para hacer un update del mismo.
                If dsMovimiento.Tables.Count > 0 Then
                    eImpuesto.id_Movimiento = dsMovimiento.Tables(0).Rows(0).Item("id_Movimiento").ToString
                Else
                    eImpuesto.id_Movimiento = 0
                End If
                eImpuesto.id_Sucursal = id_Sucursal
                eImpuesto.id_Tipo = CbTipo.SelectedValue
                eImpuesto.Fecha = Trim(txtDate.Text)
                eImpuesto.Monto = Trim(txtMonto.Text)

                'Limpiar Formulario.
                LimpiarFormulario()

                'Cambio el cursor a "NORMAL"
                Me.Cursor = Cursors.Arrow

                'Ejecuto el sp.
                If (MessageBox.Show(NegMovimiento.AltaMovImpuesto(eImpuesto), "Movimientos | Impuestos", MessageBoxButtons.OK, MessageBoxIcon.Information) = vbOK) Then
                    'Cierro el form
                    Me.Close()
                    Me.Dispose()
                End If

            Catch ex As Exception
                Me.Cursor = Cursors.Arrow
                MessageBox.Show("Se ha producido un error al registrar el movimiento. Por favor, intente más tarde.", "Movimientos | Impuestos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub CbTipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbTipo.SelectedIndexChanged
        txtMonto.Focus()
    End Sub
End Class