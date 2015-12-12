﻿Public Class frmMovimientoSocios
    Dim NegErrores As New Negocio.NegManejadorErrores
    Dim eMovimientoSocios As New Entidades.MovSocios
    Dim NegMovimiento As New Negocio.NegMovimientos
    Dim id_Sucursal As String
    Dim Nombre_Sucursal As String
    Dim dsMovimiento As New DataSet
    Public id_Movimiento As Integer = 0
    Public Accion As Integer = 0

    'Valida solo moneda.
    Private Sub txtMonto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMonto.KeyPress
        If e.KeyChar.ToString() = "." Then
            e.KeyChar = CChar(",")
        End If
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloCurrency(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
            ErrorRetiros.SetError(txtMonto, "Debe ingresar el monto en el formato permitido. Ejemplo: 725,50")
        Else
            ErrorRetiros.SetError(txtMonto, Nothing)
        End If
    End Sub

    'Al cerrar el formulario me fijo si está abierto el form de listados, si lo está, hago foco.
    Private Sub frmMovimientoRetiro_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If frmMovimientoPlanilla.Visible And id_Movimiento <> 0 Then
            frmMovimientoPlanilla.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub frmMovimientoRetiro_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If frmMovimientoPlanilla.Visible And id_Movimiento <> 0 Then
            frmMovimientoPlanilla.RefrescarPlanilla()
        End If
    End Sub

    'Cuando carga el formulario.
    Private Sub frmMovimientoRetiro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            'Selecciono la primera accion del combo.
            cmbAccion.SelectedIndex = Accion

            'Sucursal default
            id_Sucursal = My.Settings("Sucursal")
            Nombre_Sucursal = My.Settings("NombreSucursal")
            lbl_SucursalNombre.Text = Nombre_Sucursal

            'Chequeo si hay ID modifico los textos.
            If id_Movimiento <> 0 Then
                cmbAccion.Enabled = False
                'Cargo el movimiento en los controles
                If (cmbAccion.SelectedItem = "Aporte") Then
                    dsMovimiento = NegMovimiento.ObtenerMov(id_Movimiento, id_Sucursal, "Aporte")
                Else
                    dsMovimiento = NegMovimiento.ObtenerMov(id_Movimiento, id_Sucursal, "Retiro")
                End If
                txtDescripcion.Text = Replace(dsMovimiento.Tables(0).Rows(0).Item("Descripcion").ToString, "<br />", vbCrLf)
                txtEncargado.Text = dsMovimiento.Tables(0).Rows(0).Item("Encargado_Retirante").ToString
                txtPersona.Text = dsMovimiento.Tables(0).Rows(0).Item("Persona_Retirante").ToString
                txtMonto.Text = Format(CType(dsMovimiento.Tables(0).Rows(0).Item("Monto").ToString, Decimal), "###0.00")
                txtDate.Text = dsMovimiento.Tables(0).Rows(0).Item("Fecha").ToString

                btnAceptar.Text = "Modificar"
                ToolRetiros.SetToolTip(btnAceptar, "Al hacer click en el botón 'Modificar' del formulario se modificará en el sistema el retiro de dinero del socio cargado.")
            Else
                btnAceptar.Text = "Aceptar"
                ToolRetiros.SetToolTip(btnAceptar, "Al hacer click en el botón 'Aceptar' del formulario se registrará en el sistema el retiro de dinero del socio.")
            End If

                txtEncargado.Focus()

                'Cambio el cursor a "NORMAL"
                Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha producido un error al cargar el formulario. Por favor, contáctese con el administrador", "Movimientos | Socios", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'Funcion para Limpiar Formulario.
    Sub LimpiarFormulario()
        txtDescripcion.Clear()
        txtEncargado.Clear()
        txtPersona.Clear()
        txtMonto.Clear()
        txtDate.Value = Date.Now
        ErrorRetiros.Clear()
    End Sub

    'Cuando hace click en Cancelar
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        LimpiarFormulario()
    End Sub

    'Cuando hace click en Aceptar.
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If txtMonto.Text = "" Or txtDate.Text = "" Or txtEncargado.Text = "" Or txtPersona.Text = "" Then
            MessageBox.Show("Debe completar los campos requeridos.", "Movimientos | Socios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                'Cambio el cursor a "WAIT"
                Me.Cursor = Cursors.WaitCursor

                'Si es un mov ya cargado levanto el id para hacer un update del mismo.
                If dsMovimiento.Tables.Count > 0 Then
                    eMovimientoSocios.id_Movimiento = dsMovimiento.Tables(0).Rows(0).Item("id_Movimiento").ToString
                Else
                    eMovimientoSocios.id_Movimiento = 0
                End If
                eMovimientoSocios.id_Sucursal = id_Sucursal
                eMovimientoSocios.Monto = Trim(txtMonto.Text)
                eMovimientoSocios.Fecha = txtDate.Text
                eMovimientoSocios.Encargado = Trim(txtEncargado.Text)
                eMovimientoSocios.Persona = Trim(txtPersona.Text)

                If Trim(txtDescripcion.Text) = "" Then
                    eMovimientoSocios.Descripcion = ""
                Else
                    eMovimientoSocios.Descripcion = Replace(Trim(txtDescripcion.Text), vbCrLf, "<br />")
                End If

                'Limpiar Formulario.
                LimpiarFormulario()

                'Cambio el cursor a "NORMAL"
                Me.Cursor = Cursors.Arrow

                Dim Mensaje As String

                'Ejecuto el sp.
                If (cmbAccion.SelectedItem = "Aporte") Then
                    Mensaje = NegMovimiento.AltaMovAporte(eMovimientoSocios)
                Else
                    Mensaje = NegMovimiento.AltaMovRetiro(eMovimientoSocios)
                End If

                If (MessageBox.Show(Mensaje, "Retiro de Socios", MessageBoxButtons.OK, MessageBoxIcon.Information) = vbOK) Then
                    'Cierro el form
                    Me.Close()
                    Me.Dispose()
                End If

            Catch ex As Exception
                Me.Cursor = Cursors.Arrow
                MessageBox.Show("Se ha producido un error al registrar el movimiento. Por favor, intente más tarde.", "Movimientos | Socios", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

End Class