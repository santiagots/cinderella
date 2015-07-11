﻿Public Class frmEmpleadosSaldos
    Dim NegEmpleados As New Negocio.NegEmpleados
    Dim NegAdelantos As New Negocio.NegAdelantos
    Dim NegComisiones As New Negocio.NegComisiones
    Dim NegRegistros As New Negocio.NegRegistros
    Dim NegRecibos As New Negocio.NegRecibos
    Dim NegAdicionales As New Negocio.NegAdicionales
    Dim eAdelantos As New Entidades.Adelantos
    Dim eEmpleados As New Entidades.Empleados
    Dim NegErrores As New Negocio.NegManejadorErrores
    Dim fuc As New Funciones
    Dim id_Sucursal As String
    Dim id_Empleado As Integer
    Dim FDesde As String
    Dim FHasta As String
    Dim SueldoPorDepositar As Double = 0
    Dim SueldoDepositadoPago As Double = 0

    'Cuando se carga el formulario.
    Private Sub frmEmpleadosSaldos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Cambio el cursor a "WAIT"
        Me.Cursor = Cursors.WaitCursor

        'Sucursal default
        id_Sucursal = My.Settings("Sucursal")

        'Cargo el checkboxlist
        Dim dsEmpleados As New DataSet
        'Si es admin, ve todos los empleados sino solo los de la sucursal.
        If VariablesGlobales.objUsuario.id_Perfil = 1 Then
            dsEmpleados = NegEmpleados.ListadoEmpleados()
        Else
            dsEmpleados = NegEmpleados.ListadoEmpleadosSucursal(id_Sucursal)
        End If

        If dsEmpleados.Tables(0).Rows.Count > 0 Then
            CbEmpleados.DataSource = dsEmpleados.Tables(0)
            CbEmpleados.DisplayMember = "NombreCompleto"
            CbEmpleados.ValueMember = "id_Empleado"
            CbEmpleados.Refresh()
        End If

        Dim d As DateTime = DateTime.Now
        txt_FDesde.Value = "01/" & d.Month.ToString() & "/" & d.Year.ToString

        'Seteo de grafica.
        GbSueldoTrabajado.Visible = False
        GbSueldoAbonado.Visible = False
        GbSueldoLiquidar.Visible = False

        'Cambio el cursor a "NORMAL"
        Me.Cursor = Cursors.Arrow
    End Sub

    'Cuando hace click en el boton buscar.
    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        Try
            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            'Empieza a cargar.
            GbSueldoTrabajado.Visible = False
            GbSueldoAbonado.Visible = False
            GbSueldoLiquidar.Visible = False

            'Obtengo los datos.
            id_Empleado = CbEmpleados.SelectedValue
            eEmpleados = NegEmpleados.TraerEmpleado(id_Empleado)
            FDesde = txt_FDesde.Value.ToString("yyyy/MM/dd")
            FHasta = txt_FDesde.Value.AddMonths(1).AddDays(-1).ToString("yyyy/MM/dd")

            Dim Adelantos As Double = 0
            Dim Adicionales As Double = 0
            Dim Comisiones As Double = 0
            Dim Dias As Integer = 0
            Dim DiasFeriados As Integer = 0
            Dim DiasAusente As Integer = 0
            Dim SueldoNormal As Double = 0
            Dim SueldoFeriado As Double = 0
            Dim SueldoPresentismo As Double = 0
            Dim SueldoPorPagar As Double = 0
            Dim Vacaciones As Double = 0
            Dim Aguinaldo As Double = 0
            Dim Subto As Double = 0
            Dim SueldoMano As Double = 0
            Dim Sueldo As Double = 0

            Dim Deuda As Double = 0
            Dim formula1 As Double = 0
            Dim formula2 As Double = 0

            'Obtengo el total de Adelantos.
            Adelantos = NegAdelantos.ObtenerAdelantos(id_Empleado, id_Sucursal, FDesde, FHasta)
            If Adelantos <> 0 Then
                BtnAdelantos.Visible = True
            Else
                BtnAdelantos.Visible = False
            End If

            'Obtengo el total de Adicionales.
            Adicionales = NegAdicionales.ObtenerAdicionales(id_Empleado, id_Sucursal, FDesde, FHasta)
            If Adicionales <> 0 Then
                BtnAdicionales.Visible = True
            Else
                BtnAdicionales.Visible = False
            End If

            'Obtengo el total de Comisiones.
            Comisiones = NegComisiones.ObtenerComisiones(id_Empleado, id_Sucursal, FDesde, FHasta)
            If Comisiones <> 0 Then
                BtnComisiones.Visible = True
            Else
                BtnComisiones.Visible = False
            End If

            'Obtengo el total de vacaciones.
            Vacaciones = NegRecibos.ObtenerVacaciones(id_Empleado, id_Sucursal, FDesde, FHasta)
            If Vacaciones <> 0 Then
                BtnVacaciones.Visible = True
            Else
                BtnVacaciones.Visible = False
            End If

            'Obtengo el total de recibos.
            Sueldo = NegRecibos.ObtenerRecibos(id_Empleado, id_Sucursal, FDesde, FHasta)

            'Obtengo el Sueldo Depositado Pago del empleado
            SueldoDepositadoPago = NegEmpleados.SueldoDepositadoTotla(id_Empleado, id_Sucursal, FDesde, FHasta)
            If SueldoDepositadoPago <> 0 Then
                BtnSueldosPagados.Visible = True
            Else
                BtnSueldosPagados.Visible = False
            End If

            SueldoPorPagar = Sueldo - SueldoDepositadoPago
            If SueldoPorPagar <> 0 Then
                lblSueldoDepositarMaximo.Visible = True
                txt_Saldo.ReadOnly = False
            Else
                lblSueldoDepositarMaximo.Visible = False
                txt_Saldo.ReadOnly = True
            End If

            'Obtengo el total de aguinaldo.
            Aguinaldo = NegRecibos.ObtenerAguinaldo(id_Empleado, id_Sucursal, FDesde, FHasta)
            If Aguinaldo <> 0 Then
                BtnAguinaldo.Visible = True
            Else
                BtnAguinaldo.Visible = False
            End If

            'Obtengo el total de Dias Trabajados.
            Dias = NegRegistros.ObtenerDias(id_Empleado, id_Sucursal, FDesde, FHasta)
            If Dias > 0 Then
                SueldoNormal = Dias * eEmpleados.SueldoNormal
                BtnRegulares.Visible = True
            Else
                BtnRegulares.Visible = False
            End If

            'Obtengo el total de Dias Trabajados FERIADOS.
            DiasFeriados = NegRegistros.ObtenerDiasFeriados(id_Empleado, id_Sucursal, FDesde, FHasta)
            If DiasFeriados > 0 Then
                SueldoFeriado = DiasFeriados * eEmpleados.SueldoFeriado
                BtnFeriados.Visible = True
            Else
                BtnFeriados.Visible = False
            End If

            'Obtengo el total de Presentimo.
            DiasAusente = NegRegistros.ObtenerDiasAusentes(id_Empleado, id_Sucursal, FDesde, FHasta)
            If DiasAusente = 0 Then
                SueldoPresentismo = Dias * eEmpleados.SueldoPresentismo
            End If

            'Obtengo el Saldo.
            If Adelantos < 0 Then
                Adelantos = Adelantos * -1
            End If

            Subto = (Comisiones + SueldoNormal + SueldoFeriado + Aguinaldo + Vacaciones + Adicionales + SueldoPresentismo)

            formula1 = Subto - Adelantos - SueldoPorPagar
            If formula1 >= 0 Then
                formula2 = 0
            Else
                formula2 = formula1 * -1
            End If

            If (Sueldo - formula2) >= 0 Then
                SueldoPorDepositar = SueldoPorPagar - SueldoMano
            Else
                SueldoPorDepositar = 0
            End If

            If (Subto - Adelantos - SueldoPorPagar) >= 0 Then
                SueldoMano = Subto - Adelantos - SueldoPorPagar
            Else
                SueldoMano = 0
            End If

            'Muestro
            txt_Adelantos.Text = Adelantos.ToString("c")
            txt_Adicionales.Text = Adicionales.ToString("c")
            txt_Comisiones.Text = Comisiones.ToString("c")
            txt_Dias.Text = SueldoNormal.ToString("c")
            txt_DiasFeriados.Text = SueldoFeriado.ToString("c")
            txt_Presentismo.Text = SueldoPresentismo.ToString("c")
            txt_Vacaciones.Text = Vacaciones.ToString("c")
            txt_Aguinaldo.Text = Aguinaldo.ToString("c")
            txt_subto.Text = Subto.ToString("c")
            txt_sueldoMano.Text = SueldoMano.ToString("c")
            txt_Saldo.Text = SueldoPorDepositar.ToString("c")
            txt_Deuda.Text = Deuda.ToString("c")
            txt_SueldosPagados.Text = SueldoDepositadoPago.ToString("c")
            lblSueldoDepositarMaximo.Text = String.Format("(Máximo {0:C})", SueldoPorDepositar)

            If SueldoPorDepositar = 0 Then
                btn_depositar.Enabled = False
                ToolEmpleados.SetToolTip(btn_depositar, "Deposito de sueldo ya realizado.")
            Else
                btn_depositar.Enabled = True
                ToolEmpleados.SetToolTip(btn_depositar, "Depositar sueldo.")
            End If

            'Termino de cargar.
            GbSueldoTrabajado.Visible = True
            GbSueldoAbonado.Visible = True
            GbSueldoLiquidar.Visible = True

            'Cambio el cursor a "NORMAL"
            Me.Cursor = Cursors.Arrow

        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha encontrado un error al consultar el estado de cuenta del empleado. Por favor, intente más tarde.", "Visualización de movimientos de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    'Cada vez que se modifica el combo.
    Private Sub CbEmpleados_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbEmpleados.SelectedIndexChanged
        LimpiarFormulario()
    End Sub

    'Funcion que limpia el formulario.
    Sub LimpiarFormulario()
        txt_Adelantos.Clear()
        txt_Comisiones.Clear()
        txt_Dias.Clear()
        txt_Saldo.Clear()
        txt_Vacaciones.Clear()
        txt_Aguinaldo.Clear()
        GbSueldoTrabajado.Visible = False
        GbSueldoAbonado.Visible = False
        GbSueldoLiquidar.Visible = False
    End Sub

    'Link COMISIONES.
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnComisiones.Click
        Me.Cursor = Cursors.WaitCursor
        frmVerComisiones.id_Empleado = id_Empleado
        frmVerComisiones.id_Sucursal = id_Sucursal
        frmVerComisiones.FDesde = FDesde
        frmVerComisiones.FHasta = FHasta
        fuc.ControlInstancia(frmVerComisiones).MdiParent = MDIContenedor
        fuc.ControlInstancia(frmVerComisiones).Show()
        Me.Cursor = Cursors.Arrow
    End Sub

    'Link ADELANTOS.
    Private Sub BtnAdelantos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdelantos.Click
        Me.Cursor = Cursors.WaitCursor
        frmVerAdelantos.id_Empleado = id_Empleado
        frmVerAdelantos.id_Sucursal = id_Sucursal
        frmVerAdelantos.FDesde = FDesde
        frmVerAdelantos.FHasta = FHasta
        fuc.ControlInstancia(frmVerAdelantos).MdiParent = MDIContenedor
        fuc.ControlInstancia(frmVerAdelantos).Show()
        Me.Cursor = Cursors.Arrow
    End Sub

    'Link TRABAJOS REGULARES.
    Private Sub BtnRegulares_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRegulares.Click
        Me.Cursor = Cursors.WaitCursor
        frmVerRegulares.id_Empleado = id_Empleado
        frmVerRegulares.id_Sucursal = id_Sucursal
        frmVerRegulares.FDesde = FDesde
        frmVerRegulares.FHasta = FHasta
        fuc.ControlInstancia(frmVerRegulares).MdiParent = MDIContenedor
        fuc.ControlInstancia(frmVerRegulares).Show()
        Me.Cursor = Cursors.Arrow
    End Sub

    'Link TRABAJOS FERIADOS.
    Private Sub BtnFeriados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFeriados.Click
        Me.Cursor = Cursors.WaitCursor
        frmVerFeriados.id_Empleado = id_Empleado
        frmVerFeriados.id_Sucursal = id_Sucursal
        frmVerFeriados.FDesde = FDesde
        frmVerFeriados.FHasta = FHasta
        fuc.ControlInstancia(frmVerFeriados).MdiParent = MDIContenedor
        fuc.ControlInstancia(frmVerFeriados).Show()
        Me.Cursor = Cursors.Arrow
    End Sub

    'Link AGUINALDO.
    Private Sub BtnAguinaldo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAguinaldo.Click
        Me.Cursor = Cursors.WaitCursor
        frmVerAguinaldo.id_Empleado = id_Empleado
        frmVerAguinaldo.id_Sucursal = id_Sucursal
        frmVerAguinaldo.FDesde = FDesde
        frmVerAguinaldo.FHasta = FHasta
        fuc.ControlInstancia(frmVerAguinaldo).MdiParent = MDIContenedor
        fuc.ControlInstancia(frmVerAguinaldo).Show()
        Me.Cursor = Cursors.Arrow
    End Sub

    'Link VACACIONES.
    Private Sub BtnVacaciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVacaciones.Click
        Me.Cursor = Cursors.WaitCursor
        frmVerVacaciones.id_Empleado = id_Empleado
        frmVerVacaciones.id_Sucursal = id_Sucursal
        frmVerVacaciones.FDesde = FDesde
        frmVerVacaciones.FHasta = FHasta
        fuc.ControlInstancia(frmVerVacaciones).MdiParent = MDIContenedor
        fuc.ControlInstancia(frmVerVacaciones).Show()
        Me.Cursor = Cursors.Arrow
    End Sub

    'Link ADICIONALES
    Private Sub BtnAdicionales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdicionales.Click
        Me.Cursor = Cursors.WaitCursor
        frmVerAdiconales.id_Empleado = id_Empleado
        frmVerAdiconales.id_Sucursal = id_Sucursal
        frmVerAdiconales.FDesde = FDesde
        frmVerAdiconales.FHasta = FHasta
        fuc.ControlInstancia(frmVerAdiconales).MdiParent = MDIContenedor
        fuc.ControlInstancia(frmVerAdiconales).Show()
        Me.Cursor = Cursors.Arrow
    End Sub

    'Link SUELDOS PAGADOS
    Private Sub BtnSueldosPagados_Click(sender As Object, e As EventArgs) Handles BtnSueldosPagados.Click
        Me.Cursor = Cursors.WaitCursor
        frmVerSueldosEmpleado.id_Empleado = id_Empleado
        frmVerSueldosEmpleado.id_Sucursal = id_Sucursal
        frmVerSueldosEmpleado.FDesde = FDesde
        frmVerSueldosEmpleado.FHasta = FHasta
        fuc.ControlInstancia(frmVerSueldosEmpleado).MdiParent = MDIContenedor
        fuc.ControlInstancia(frmVerSueldosEmpleado).Show()
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub btn_depositar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_depositar.Click

        If MessageBox.Show("¿Ésta seguro que desea efectuar el deposito del sueldo del empleado " & eEmpleados.Apellido & ", " & eEmpleados.Nombre & " ?", "Visualización de movimientos de Empleados", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Try
                'Cambio el cursor a "WAIT"
                Me.Cursor = Cursors.WaitCursor

                Dim sueldoDepositado As Integer = CDbl(txt_Saldo.Text)

                'Agrego el gasto del sueldo a depositar.
                Dim NegMovimiento As New Negocio.NegMovimientos
                Dim eGasto As New Entidades.MovGasto
                eGasto.id_Movimiento = 0
                eGasto.id_Registro = 0
                eGasto.id_Sucursal = id_Sucursal
                eGasto.id_Tipo = 42 'tipo sueldo a depositar
                eGasto.Fecha = Now
                eGasto.Monto = sueldoDepositado
                NegMovimiento.AltaMovGasto(eGasto)

                'Agrego el retiro de socios en forma negativa.
                Dim eRetiro As New Entidades.MovRetiro
                eRetiro.id_Movimiento = 0
                eRetiro.id_Sucursal = id_Sucursal
                eRetiro.Monto = sueldoDepositado * -1
                eRetiro.Fecha = Now
                eRetiro.Encargado = "Cinderella"
                eRetiro.Persona = "Cinderella"
                eRetiro.Descripcion = "Retiro en negativo por pago de sueldo a empleado"
                NegMovimiento.AltaMovRetiro(eRetiro)

                'Agrego el deposito del empleado.
                Dim eDeposito As New Entidades.Depositos
                eDeposito.id_Sucursal = id_Sucursal
                eDeposito.id_Empleado = id_Empleado
                eDeposito.Monto = sueldoDepositado
                eDeposito.Fecha = Now
                eDeposito.Mes = Month(txt_FDesde.Text)
                eDeposito.Anio = Year(txt_FDesde.Text)
                eDeposito.Habilitado = 1
                NegEmpleados.AltaDeposito(eDeposito)

                'actualizo los valores del sueldo depositado y sueldo por depositar
                SueldoDepositadoPago += sueldoDepositado
                txt_SueldosPagados.Text = SueldoDepositadoPago.ToString("c")

                SueldoPorDepositar -= sueldoDepositado
                txt_Saldo.Text = (SueldoPorDepositar).ToString("c")
                lblSueldoDepositarMaximo.Text = String.Format("(Máximo {0:C})", SueldoPorDepositar)

                If SueldoPorDepositar <> 0 Then
                    lblSueldoDepositarMaximo.Visible = True
                    txt_Saldo.ReadOnly = False
                Else
                    lblSueldoDepositarMaximo.Visible = False
                    txt_Saldo.ReadOnly = True
                End If

                'actualizo el estado del boton en caso de que no se encuentre mas sueldo para depositar
                If SueldoPorDepositar = 0 Then
                    btn_depositar.Enabled = False
                    ToolEmpleados.SetToolTip(btn_depositar, "Deposito de sueldo ya realizado.")
                End If

                MessageBox.Show("Se ha depositado correctamente el sueldo del empleado " & eEmpleados.Apellido & ", " & eEmpleados.Nombre, "Visualización de movimientos de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information)


                'Cambio el cursor a "NORMAL"
                Me.Cursor = Cursors.Arrow

            Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha encontrado un error al depositar el sueldo del empleado. Por favor, intente más tarde.", "Visualización de movimientos de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        End If

    End Sub


    Private Sub txt_Saldo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Saldo.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_Saldo_Leave(sender As Object, e As EventArgs) Handles txt_Saldo.Leave
        If (txt_Saldo.Text = String.Empty) Then
            txt_Saldo.Text = SueldoPorDepositar.ToString("c")
            Return
        End If

        Dim SaldoDepositarIngresado As Double = CDbl(txt_Saldo.Text)

        If (SueldoPorDepositar < SaldoDepositarIngresado) Then
            ErrorProvider.SetError(txt_Saldo, "El sueldo ingresado debe ser menor o igual al Máximo.")
        Else
            txt_Saldo.Text = SaldoDepositarIngresado.ToString("c")
        End If
    End Sub

    Private Sub txt_Saldo_Enter(sender As Object, e As EventArgs) Handles txt_Saldo.Enter
        If (Not txt_Saldo.ReadOnly) Then
            txt_Saldo.Text = String.Empty
        End If
    End Sub

End Class