Public Class frmReciboSueldo
    Dim NegEmpleados As New Negocio.NegEmpleados
    Dim NegSucursal As New Negocio.NegSucursales
    Dim NegRecibos As New Negocio.NegRecibos
    Dim NegErrores As New Negocio.NegManejadorErrores
    Dim ESucursal As New Entidades.Sucursales
    Dim ERecibo As New Entidades.Recibos
    Dim ClsFunciones As New Funciones
    Dim id_Sucursal As String
    Dim Nombre_Sucursal As String

    'Cuando carga el formulario.
    Private Sub frmReciboSueldo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            'Sucursal default
            id_Sucursal = My.Settings("Sucursal")
            ESucursal = NegSucursal.TraerSucursal(id_Sucursal)
            Nombre_Sucursal = ESucursal.Nombre

            'Cargo el cbEmpleado
            Dim dsEmpleados As New DataSet
            dsEmpleados = NegEmpleados.ListadoEmpleadosSucursal(id_Sucursal)
            If (dsEmpleados.Tables(0).Rows.Count > 0) Then
                cb_Empleados.DataSource = dsEmpleados.Tables(0)
                cb_Empleados.DisplayMember = "NombreCompleto"
                cb_Empleados.ValueMember = "id_Empleado"
                cb_Empleados.Refresh()
            End If

            'Cargo el combo con los meses.
            ClsFunciones.CargarComboMeses(Cb_Meses)

            'Cargo el combo con los anios.
            ClsFunciones.CargarComboAnios(Cb_Anios)

            'Cambio el cursor a "NORMAL"
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            MessageBox.Show("Se ha encontrado un error:" & ex.Message.ToString, "Recibo de Sueldo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Funcion para Limpiar Formulario.
    Sub LimpiarFormulario()
        Dim datetimeFormat = Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat
        Cb_Meses.SelectedItem = datetimeFormat.GetMonthName(Date.Today.Month)
        txtMonto.Clear()
        txtAguinaldo.Clear()
        txtVacaciones.Clear()
        ' cb_Empleados.SelectedItem = Nothing
        Lst_Anteriores.Items.Clear()
        Lst_Anteriores.Visible = False
        lbl_MSG.Text = "Debe seleccionar un empleado."
        lbl_MSG.Visible = True
    End Sub

    'Cuando hace click en Cancelar.
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        LimpiarFormulario()
    End Sub

    'Cuando hace click en Aceptar.
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If Cb_Meses.SelectedItem Is Nothing Or cb_Empleados.SelectedItem Is Nothing Then
            MessageBox.Show("Debe completar los campos requeridos.", "Recibo de Sueldos de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If (txtMonto.Text = "" And txtAguinaldo.Text = "" And txtVacaciones.Text = "") Then
                MessageBox.Show("Debe ingresar algún valor.", "Recibo de Sueldos de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Try
                    'Cambio el cursor a "WAIT"
                    Me.Cursor = Cursors.WaitCursor

                    'Lleno la entidad Adelantos.
                    ERecibo.Mes = Cb_Meses.SelectedItem
                    If txtMonto.Text <> "" Then
                        ERecibo.Monto = CDbl(Trim(txtMonto.Text))
                    Else
                        ERecibo.Monto = 0
                    End If

                    If txtVacaciones.Text <> "" Then
                        ERecibo.Vacaciones = CDbl((txtVacaciones.Text))
                    End If

                    If txtAguinaldo.Text <> "" Then
                        ERecibo.Aguinaldo = CDbl(Trim(txtAguinaldo.Text))
                    End If

                    ERecibo.id_Empleado = cb_Empleados.SelectedValue
                    ERecibo.id_Sucursal = id_Sucursal
                    ERecibo.Anio = Cb_Anios.SelectedItem

                    'Limpiar Formulario.
                    LimpiarFormulario()

                    'Cambio el cursor a "NORMAL"
                    Me.Cursor = Cursors.Arrow

                    'Ejecuto el sp_Adelantos_Alta.
                    MessageBox.Show(NegRecibos.AltaReciboSueldo(ERecibo), "Recibo de Sueldos de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    'Cambio el cursor a "WAIT"
                    Me.Cursor = Cursors.WaitCursor

                    'Dataset con recibos.
                    Dim DsRecibos As New DataSet
                    DsRecibos = NegRecibos.ObtenerRecibos(cb_Empleados.SelectedValue, id_Sucursal, Now.Year)

                    'Si hay datos, muestro el detalle sino muestro un mensaje.
                    If DsRecibos IsNot Nothing Then
                        Lst_Anteriores.Items.Clear()
                        For Each recibo In DsRecibos.Tables(0).Rows
                            Dim vacas As String = ""
                            Dim aguin As String = ""
                            Dim sueld As String = ""

                            If recibo.Item("Monto") > 0 Then
                                sueld = " - Sueldo: $" & Format(CType((recibo.Item("Monto")), Decimal), "###0.00")
                            End If

                            If recibo.Item("Vacaciones") > 0 Then
                                vacas = " - Vacaciones: $" & Format(CType((recibo.Item("Vacaciones")), Decimal), "###0.00")
                            End If

                            If recibo.Item("Aguinaldo") > 0 Then
                                aguin = " - Aguinaldo: $" & Format(CType((recibo.Item("Aguinaldo")), Decimal), "###0.00")
                            End If
                            Lst_Anteriores.Items.Add(recibo.Item("Anio").ToString & " - " & StrConv(recibo.Item("Mes").ToString, VbStrConv.ProperCase) & sueld & vacas & aguin)
                        Next
                        Lst_Anteriores.Visible = True
                        lbl_MSG.Text = ""
                        lbl_MSG.Visible = False
                    Else
                        Lst_Anteriores.Visible = False
                        lbl_MSG.Text = "No posee recibos de sueldo."
                        lbl_MSG.Visible = True
                    End If

                    'Cambio el cursor a "NORMAL"
                    Me.Cursor = Cursors.Arrow

                Catch ex As Exception
                    Me.Cursor = Cursors.Arrow
                    MessageBox.Show("Se ha producido un error al registrar el recibo de sueldo. Por favor, intente más tarde.", "Recibo de Sueldos de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub

    'Cuando cambia de empleado, trae todos los recibos que estén en la base.
    Private Sub cb_Empleados_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_Empleados.SelectedValueChanged
        'Cambio el cursor a "WAIT"
        Me.Cursor = Cursors.WaitCursor

        If cb_Empleados.SelectedValue.ToString <> "System.Data.DataRowView" Then
            'Dataset con recibos.
            Dim DsRecibos As New DataSet
            DsRecibos = NegRecibos.ObtenerRecibos(cb_Empleados.SelectedValue, id_Sucursal, Now.Year)

            'Si hay datos, muestro el detalle sino muestro un mensaje.
            If DsRecibos IsNot Nothing Then
                Lst_Anteriores.Items.Clear()
                For Each recibo In DsRecibos.Tables(0).Rows
                    Dim vacas As String = ""
                    Dim aguin As String = ""
                    Dim sueld As String = ""

                    If recibo.Item("Monto") > 0 Then
                        sueld = " - Sueldo: $" & Format(CType((recibo.Item("Monto")), Decimal), "###0.00")
                    End If

                    If recibo.Item("Vacaciones") > 0 Then
                        vacas = " - Vacaciones: $" & Format(CType((recibo.Item("Vacaciones")), Decimal), "###0.00")
                    End If

                    If recibo.Item("Aguinaldo") > 0 Then
                        aguin = " - Aguinaldo: $" & Format(CType((recibo.Item("Aguinaldo")), Decimal), "###0.00")
                    End If
                    Lst_Anteriores.Items.Add(recibo.Item("Anio").ToString & " - " & StrConv(recibo.Item("Mes").ToString, VbStrConv.ProperCase) & sueld & vacas & aguin)
                Next
                Lst_Anteriores.Visible = True
                lbl_MSG.Text = ""
                lbl_MSG.Visible = False
            Else
                Lst_Anteriores.Visible = False
                lbl_MSG.Text = "No posee recibos de sueldo."
                lbl_MSG.Visible = True
            End If
        End If

        'Cambio el cursor a "NORMAL"
        Me.Cursor = Cursors.Arrow
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
            ErrorRecibos.SetError(txtMonto, "Debe ingresar el monto en el formato permitido. Ejemplo: 725,50")
        Else
            ErrorRecibos.SetError(txtMonto, Nothing)
        End If
    End Sub

    'Valida solo moneda.
    Private Sub txtAguinaldo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAguinaldo.KeyPress
        If e.KeyChar.ToString() = "." Then
            e.KeyChar = CChar(",")
        End If
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloCurrency(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
            ErrorRecibos.SetError(txtAguinaldo, "Debe ingresar el monto en el formato permitido. Ejemplo: 725,50")
        Else
            ErrorRecibos.SetError(txtAguinaldo, Nothing)
        End If
    End Sub

    'Valida solo moneda.
    Private Sub txtVacaciones_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVacaciones.KeyPress
        If e.KeyChar.ToString() = "." Then
            e.KeyChar = CChar(",")
        End If
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloCurrency(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
            ErrorRecibos.SetError(txtVacaciones, "Debe ingresar el monto en el formato permitido. Ejemplo: 725,50")
        Else
            ErrorRecibos.SetError(txtVacaciones, Nothing)
        End If
    End Sub

End Class