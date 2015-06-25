Public Class frmMovimientoCajaFuerte
    Dim NegErrores As New Negocio.NegManejadorErrores
    Dim NegMovimiento As New Negocio.NegMovimientos
    Dim eCaja As New Entidades.MovCajaFuerte
    Dim id_Sucursal As String
    Dim Nombre_Sucursal As String
    Dim dsMovimiento As New DataSet
    Public id_Movimiento As Integer = 0

    'Al cerrar el formulario me fijo si está abierto el form de listados, si lo está, hago foco.
    Private Sub frmMovimientoCaja_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If frmMovimientoPlanilla.Visible And id_Movimiento <> 0 Then
            frmMovimientoPlanilla.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub frmMovimientoCaja_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If frmMovimientoPlanilla.Visible And id_Movimiento <> 0 Then
            frmMovimientoPlanilla.RefrescarPlanilla()
        End If
    End Sub

    'Cuando carga el formulario.
    Private Sub frmMovimientoCajaChica_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            'Sucursal default
            id_Sucursal = My.Settings("Sucursal")
            Nombre_Sucursal = My.Settings("NombreSucursal")
            lbl_SucursalNombre.Text = Nombre_Sucursal

            'Chequeo si hay ID modifico los textos.
            If id_Movimiento <> 0 Then
                'Cargo el movimiento en los controles
                dsMovimiento = NegMovimiento.ObtenerMov(id_Movimiento, id_Sucursal, "CajaFuerte")
                txtDescripcion.Text = Replace(dsMovimiento.Tables(0).Rows(0).Item("Descripcion").ToString, "<br />", vbCrLf)
                txtMonto.Text = Format(CType(dsMovimiento.Tables(0).Rows(0).Item("Monto").ToString, Decimal), "###0.00")
                txtDate.Text = dsMovimiento.Tables(0).Rows(0).Item("Fecha").ToString

                If dsMovimiento.Tables(0).Rows(0).Item("Tipo").ToString = "Ingreso a Caja Chica." Then
                    CbTipo.SelectedItem = "Ingreso a Caja Chica."
                Else
                    CbTipo.SelectedItem = "Egreso de Caja Chica."
                End If

                btnAceptar.Text = "Modificar"
                ToolCaja.SetToolTip(btnAceptar, "Al hacer click en el botón 'Modificar' del formulario se modificará en el sistema el movimiento de caja fuerte cargado.")
            Else
                btnAceptar.Text = "Aceptar"
                ToolCaja.SetToolTip(btnAceptar, "Al hacer click en el botón 'Aceptar' del formulario se registrará en el sistema el movimiento de caja fuerte.")
            End If

            txtMonto.Focus()
            'Cambio el cursor a "NORMAL"
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha producido un error al cargar el formulario. Por favor, contáctese con el administrador", "Movimientos | Caja Fuerte", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            ErrorCaja.SetError(txtMonto, "Debe ingresar el monto en el formato permitido. Ejemplo: 725,50")
        Else
            ErrorCaja.SetError(txtMonto, Nothing)
        End If
    End Sub

    'Funcion para Limpiar Formulario.
    Sub LimpiarFormulario()
        txtDescripcion.Clear()
        txtMonto.Clear()
        txtDate.Value = Date.Now
        CbTipo.SelectedItem = Nothing
        ErrorCaja.Clear()
    End Sub

    'Cuando hace click en Cancelar
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        LimpiarFormulario()
    End Sub

    'Cuando hace click en Aceptar.
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If txtMonto.Text = "" Or txtDate.Text = "" Or CbTipo.SelectedItem Is Nothing Then
            MessageBox.Show("Debe completar los campos requeridos.", "Movimientos | Caja Fuerte", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                'Cambio el cursor a "WAIT"
                Me.Cursor = Cursors.WaitCursor

                'Si es un mov ya cargado levanto el id para hacer un update del mismo.
                If dsMovimiento.Tables.Count > 0 Then
                    eCaja.id_Movimiento = dsMovimiento.Tables(0).Rows(0).Item("id_Movimiento").ToString
                Else
                    eCaja.id_Movimiento = 0
                End If
                eCaja.id_Sucursal = id_Sucursal

                If CbTipo.SelectedItem = "Ingreso a Caja Chica." Then
                    eCaja.id_Tipo = 1
                Else
                    eCaja.id_Tipo = 2
                End If

                If Trim(txtDescripcion.Text) = "" Then
                    eCaja.Descripcion = ""
                Else
                    eCaja.Descripcion = Replace(Trim(txtDescripcion.Text), vbCrLf, "<br />")
                End If

                eCaja.Fecha = Trim(txtDate.Text)
                eCaja.Monto = Trim(txtMonto.Text)

                'controlo si hay sufiente dinero en caja para poder retirar    
                If (eCaja.id_Tipo = 1) Then
                    Dim CajaFuerteTotal As Double = 0
                    CajaFuerteTotal = NegMovimiento.ConsultarTotalCajaFuerte(id_Sucursal)
                    If (CajaFuerteTotal < eCaja.Monto) Then
                        Dim str_mensaje As String
                        str_mensaje = "No hay suficiente dinero en la caja para realizar esa operacion." + vbCrLf + "Total disponible:" + CajaFuerteTotal.ToString
                        MessageBox.Show(str_mensaje, "Dinero insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Me.Cursor = Cursors.Default
                        Exit Sub
                    End If
                End If

                'controlo si hay sufiente dinero en caja chica para para poder ingresar a la caja fuerte
                If (eCaja.id_Tipo = 2) Then
                    Dim CajaFuerteTotal As Double = 0
                    'CajaFuerteTotal = NegMovimiento.   .ConsultarTotalCajaFuerte(id_Sucursal)
                    If (CajaFuerteTotal < eCaja.Monto) Then
                        Dim str_mensaje As String
                        str_mensaje = "No hay suficiente dinero en la caja para realizar esa operacion." + vbCrLf + "Total disponible:" + CajaFuerteTotal.ToString
                        MessageBox.Show(str_mensaje, "Dinero insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Me.Cursor = Cursors.Default
                        Exit Sub
                    End If
                End If


                'Limpiar Formulario.
                LimpiarFormulario()

                'Cambio el cursor a "NORMAL"
                Me.Cursor = Cursors.Arrow

                'Ejecuto el sp.
                If (MessageBox.Show(NegMovimiento.AltaMovCajaFuerte(eCaja), "Movimientos | Caja Fuerte", MessageBoxButtons.OK, MessageBoxIcon.Information) = vbOK) Then
                    'Cierro el form
                    Me.Close()
                    Me.Dispose()
                End If

            Catch ex As Exception
                Me.Cursor = Cursors.Arrow
                MessageBox.Show("Se ha producido un error al registrar el movimiento. Por favor, intente más tarde.", "Movimientos | Caja Fuerte", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    'Selecciono el campo monto una vez que elije del combo.
    Private Sub CbTipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbTipo.SelectedIndexChanged
        txtMonto.Focus()
    End Sub

End Class