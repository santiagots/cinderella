Imports Negocio
Imports Entidades

Public Class frmMovimientoSocios
    Dim NegErrores As New Negocio.NegManejadorErrores
    Dim eMovimientoSocios As New Entidades.MovSocios
    Dim NegMovimiento As New Negocio.NegMovimientos
    Dim id_Sucursal As String
    Dim Nombre_Sucursal As String
    Dim cmbAccionindex As Integer
    Dim cmbTipoPagoindex As Integer
    Dim dsMovimiento As New DataSet
    Public id_Movimiento As Integer = 0
    Public Accion As Integer = 0
    Public Cheque As Entidades.Cheque = Nothing

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
            cmbAccionindex = Accion


            'Selecciono la primera forma de pago del combo.
            cmbTipoPago.SelectedIndex = 0
            cmbTipoPagoindex = 0

            'Cargo el combo de destino salida
            cmbDestinoSalida.DataSource = [Enum].GetValues(GetType(ChequeDestinoSalida)).Cast(Of ChequeDestinoSalida).Where(Function(x) x <> ChequeDestinoSalida.SinSalida).ToArray()

            'Sucursal default
            id_Sucursal = My.Settings("Sucursal")
            Nombre_Sucursal = My.Settings("NombreSucursal")
            lbl_SucursalNombre.Text = Nombre_Sucursal

            'Chequeo si hay ID modifico los textos.
            If id_Movimiento <> 0 Then
                cmbAccion.Enabled = False
                cmbTipoPago.Enabled = False
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

                'Si el movimiento tiene forma de pago en cheque
                If (dsMovimiento.Tables(0).Rows(0).Item("id_Tipo_Pago") = 4) Then
                    cmbTipoPago.SelectedItem = "Cheque"
                    Cheque = NegCheque.TraerCheque(Integer.Parse(dsMovimiento.Tables(0).Rows(0).Item("id_Cheque").ToString()))
                End If

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
        If (Not Cheque Is Nothing) Then
            Dim respuesta As DialogResult = MessageBox.Show("Se ha registrado la carga de un cheque, en caso de salir el cheque sera eliminado. Desea cerrar la pantalla?", "Movimientos | Socios", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If (respuesta = Windows.Forms.DialogResult.Yes) Then
                Try

                    Negocio.NegCheque.EleminarCheque(Cheque.IdCheque)

                Catch ex As Exception
                    MessageBox.Show("Se ha producido un error al registrar el movimiento. Por favor, intente más tarde.", "Movimientos | Socios", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

            End If
        End If
        Me.Close()
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
                eMovimientoSocios.IdTipoPago = If(cmbTipoPago.SelectedItem = "Cheque", 4, 1)

                If Trim(txtDescripcion.Text) = "" Then
                    eMovimientoSocios.Descripcion = ""
                Else
                    eMovimientoSocios.Descripcion = Replace(Trim(txtDescripcion.Text), vbCrLf, "<br />")
                End If

                'Cambio el cursor a "NORMAL"
                Me.Cursor = Cursors.Arrow

                Dim Mensaje As String

                If (cmbAccion.SelectedItem = "Aporte") Then

                    If (cmbTipoPago.Text = "Cheque") Then
                        If id_Movimiento <> 0 Then
                            'Si el ID_MOVIMIENTO es distinto a 0 se esta editando un movimiento
                            NegCheque.ModificacionCheque(Cheque)
                            MessageBox.Show("El cheque se modificó correctamente.", "Movimientos | Socios", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            'Si el ID_MOVIMIENTO es 0 se esta accedendo al alta de un movimiento
                            eMovimientoSocios.IdCheque = NegCheque.AltaCheque(Cheque)
                            MessageBox.Show("El cheque se cargó correctamente.", "Movimientos | Socios", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
                        
                    Mensaje = NegMovimiento.AltaMovAporte(eMovimientoSocios)

                Else
                    If (cmbTipoPago.Text = "Cheque") Then
                        If id_Movimiento <> 0 Then
                            'Si el ID_MOVIMIENTO es distinto a 0 se esta editando un movimiento
                            Dim ChequeAnterior As Cheque = NegCheque.TraerCheque(Integer.Parse(dsMovimiento.Tables(0).Rows(0).Item("id_Cheque").ToString()))
                            ChequeAnterior.Estado = Entidades.ChequeEstado.Ingresado
                            ChequeAnterior.FechaSalida = Nothing
                            ChequeAnterior.DestinoSalida = Entidades.ChequeDestinoSalida.SinSalida
                            ChequeAnterior.DetalleSalida = String.Empty

                            NegCheque.ModificacionCheque(ChequeAnterior)
                        End If

                        Cheque.Estado = Entidades.ChequeEstado.Salido
                        Cheque.FechaSalida = Date.Now
                        [Enum].TryParse(Of ChequeDestinoSalida)(cmbDestinoSalida.SelectedValue.ToString(), Cheque.DestinoSalida)
                        Cheque.DetalleSalida = txtDescripcion.Text

                        NegCheque.ModificacionCheque(Cheque)
                        MessageBox.Show("El cheque se actualizo correctamente.", "Movimientos | Socios", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        eMovimientoSocios.IdCheque = Cheque.IdCheque
                    End If

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

        'Limpiar Formulario.
        LimpiarFormulario()

    End Sub

    Private Sub btn_Cheque_Click(sender As Object, e As EventArgs) Handles btn_Cheque.Click

        If (cmbAccion.Text = "Aporte") Then
            Dim frmChequesAlta As frmChequesAlta = New frmChequesAlta()
            frmChequesAlta.ChequeModificar = Cheque
            frmChequesAlta.ReturnCheque = True
            frmChequesAlta.ShowDialog()

            'Si se esta editando un movimiento existente y se presiono el boton salir en la modificacion del cheque. No se tiene que actualizar la informacion del cheque
            If (Not frmChequesAlta.ChequeModificar Is Nothing) Then
                Cheque = frmChequesAlta.ChequeModificar
            End If

        Else
            Dim frmChequesAdministracion As frmChequesAdministracion = New frmChequesAdministracion()
            frmChequesAdministracion.ReturnCheque = True
            frmChequesAdministracion.ShowDialog()
            Cheque = frmChequesAdministracion.ChequeSeleccionado
        End If

        If (Cheque IsNot Nothing) Then
            txtMonto.Text = Cheque.Importe
        Else
            txtMonto.Clear()
        End If

    End Sub

    Private Sub cmbAccion_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmbAccion.SelectedIndexChanged
        If (Not Cheque Is Nothing) Then
            Dim respuesta As DialogResult = MessageBox.Show("Se ha registrado la carga de un cheque, en caso de cambiar la opción en el campo ""Acción"" la información del cheque será descartada. ¿Desea modificar la acción?", "Movimientos | Socios", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If (respuesta = Windows.Forms.DialogResult.No) Then
                RemoveHandler cmbAccion.SelectedIndexChanged, New EventHandler(AddressOf Me.cmbAccion_SelectedIndexChanged_1)
                cmbAccion.SelectedIndex = cmbAccionindex
                AddHandler cmbAccion.SelectedIndexChanged, New EventHandler(AddressOf Me.cmbAccion_SelectedIndexChanged_1)
            Else
                cmbAccionindex = cmbAccion.SelectedIndex
                Cheque = Nothing
                txtMonto.Clear()
            End If
        Else
            cmbAccionindex = cmbAccion.SelectedIndex
        End If

        If (cmbAccion.SelectedItem = "Retiro" And cmbTipoPago.Text = "Cheque") Then
            cmbDestinoSalida.Enabled = True
        Else
            cmbDestinoSalida.Enabled = False
        End If

    End Sub

    Private Sub cmbTipoPago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipoPago.SelectedIndexChanged
        If (Not Cheque Is Nothing) Then
            Dim respuesta As DialogResult = MessageBox.Show("Se ha registrado la carga de un cheque, en caso de cambiar la opción en el campo ""Tipo de Pago"" la información del cheque será descartada. ¿Desea modificar el tipo de pago?", "Movimientos | Socios", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If (respuesta = Windows.Forms.DialogResult.No) Then
                RemoveHandler cmbTipoPago.SelectedIndexChanged, New EventHandler(AddressOf Me.cmbTipoPago_SelectedIndexChanged)
                cmbTipoPago.SelectedIndex = cmbTipoPagoindex
                AddHandler cmbTipoPago.SelectedIndexChanged, New EventHandler(AddressOf Me.cmbTipoPago_SelectedIndexChanged)
            Else
                cmbTipoPagoindex = cmbTipoPago.SelectedIndex
                Cheque = Nothing
                txtMonto.Clear()
            End If
        Else
            cmbTipoPagoindex = cmbTipoPago.SelectedIndex
        End If

        If (cmbTipoPago.Text = "Cheque") Then
            btn_Cheque.Enabled = True
            txtMonto.Enabled = False
        Else
            btn_Cheque.Enabled = False
            txtMonto.Enabled = True
        End If

        If (cmbAccion.SelectedItem = "Retiro" And cmbTipoPago.Text = "Cheque") Then
            cmbDestinoSalida.Enabled = True
        Else
            cmbDestinoSalida.Enabled = False
        End If
    End Sub
End Class