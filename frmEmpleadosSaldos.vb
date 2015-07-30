Imports Entidades

Public Class frmEmpleadosSaldos
    Dim NegEmpleados As New Negocio.NegEmpleados
    Dim NegAdelantos As New Negocio.NegAdelantos
    Dim NegComisiones As New Negocio.NegComisiones
    Dim NegRegistros As New Negocio.NegRegistros
    Dim NegRecibos As New Negocio.NegRecibos
    Dim NegAdicionales As New Negocio.NegAdicionales
    Dim eAdelantos As New Entidades.Adelantos
    Dim eEmpleados As New Entidades.Empleados
    Dim NegErrores As New Negocio.NegManejadorErrores
    Dim estadoCuenta As EstadoCuenta
    Dim ClsFunciones As New Funciones
    Dim fuc As New Funciones
    Dim id_Sucursal As String
    Dim id_Empleado As Integer
    Dim FDesde As String
    Dim FHasta As String
    Dim SueldoPorDepositar As Double = 0
    Dim SueldoPorPagarEnMano As Double = 0

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

            FDesde = New DateTime(txtDate.Value.Year, txtDate.Value.Month, 1).ToString("yyyy/MM/dd")
            FHasta = New DateTime(txtDate.Value.Year, txtDate.Value.Month, 1).AddMonths(1).AddDays(-1).ToString("yyyy/MM/dd")
            Dim DiferenciaMeses As Integer = (txtDate.Value.Month - DateTime.Now.Month) + 12 * (txtDate.Value.Year - DateTime.Now.Year)

            SueldoPorDepositar = 0
            SueldoPorPagarEnMano = 0

            Dim DiasAusente As Integer = 0
            Dim SueldoNormal As Double = 0
            Dim SueldoFeriado As Double = 0
            Dim SueldoPresentismo As Double = 0
            Dim SueldoPorPagar As Double = 0
            Dim SubTotalTrabajado As Double = 0
            Dim SubTotalAbonado As Double = 0

            Dim Deuda As Double = 0
            Dim SueldoTotalPorLiquidar As Double = 0
            Dim formula2 As Double = 0

            'obtengo el estado de cuenta del mes en curso
            estadoCuenta = NegEmpleados.ObtenerEstadoCuenta(id_Empleado, id_Sucursal, FDesde, FHasta)

            'si la deuda del mes seleccionado no tiene valor 
            If (Not estadoCuenta.Deuda.HasValue) Then
                'y si el mes seleccionado no es un mes futuro
                If (DiferenciaMeses < 1) Then
                    'Calcula la deuda que le corresponde a este mes
                    Deuda = CalcularDeudaMesVencidos(id_Empleado, id_Sucursal, FDesde, FHasta, False)
                End If
            Else
                Deuda = estadoCuenta.Deuda.Value
            End If

            MostrarBotonesDetalle()

            SueldoNormal = estadoCuenta.CantidadDiasNormales * eEmpleados.SueldoNormal
            SueldoFeriado = estadoCuenta.CantidadDiasFeriados * eEmpleados.SueldoFeriado

            If estadoCuenta.CantidadDiasAusente = 0 Then
                SueldoPresentismo = estadoCuenta.CantidadDiasNormales * eEmpleados.SueldoPresentismo
            End If

            SubTotalTrabajado = (estadoCuenta.Comisiones + SueldoNormal + SueldoFeriado + estadoCuenta.Aguinaldo + estadoCuenta.Vacaciones + estadoCuenta.Adicionales + SueldoPresentismo)

            SubTotalAbonado = estadoCuenta.Adelantos + estadoCuenta.SueldoPago + Deuda

            CalcularSueldos(SueldoNormal, SueldoFeriado, SueldoPresentismo, Deuda)

            If SueldoPorDepositar <> 0 Then
                lblSueldoDepositarMaximo.Visible = True
                txt_Saldo.ReadOnly = False
            Else
                lblSueldoDepositarMaximo.Visible = False
                txt_Saldo.ReadOnly = True
            End If

            If SueldoPorPagarEnMano > 0 Then
                lblSueldoPagarManoMaximo.Visible = True
            Else
                lblSueldoPagarManoMaximo.Visible = False
            End If

            'Muestro
            txt_Adelantos.Text = estadoCuenta.Adelantos.ToString("c")
            txt_Adicionales.Text = estadoCuenta.Adicionales.ToString("c")
            txt_Comisiones.Text = estadoCuenta.Comisiones.ToString("c")
            txt_Dias.Text = SueldoNormal.ToString("c")
            txt_DiasFeriados.Text = SueldoFeriado.ToString("c")
            txt_Presentismo.Text = SueldoPresentismo.ToString("c")
            txt_Vacaciones.Text = estadoCuenta.Vacaciones.ToString("c")
            txt_Aguinaldo.Text = estadoCuenta.Aguinaldo.ToString("c")
            txt_subto.Text = SubTotalTrabajado.ToString("c")
            txt_sueldoMano.Text = SueldoPorPagarEnMano.ToString("c")
            txt_Saldo.Text = SueldoPorDepositar.ToString("c")
            txt_Deuda.Text = Deuda.ToString("c")
            txt_SueldosPagados.Text = estadoCuenta.SueldoPago.ToString("c")
            lblSueldoDepositarMaximo.Text = String.Format("(Máximo {0:C})", SueldoPorDepositar)
            lblSueldoPagarManoMaximo.Text = String.Format("(Sugerido {0:C})", SueldoPorPagarEnMano)

            ActualizarEstadoBotones()

            'Termino de cargar.
            GbSueldoTrabajado.Visible = True
            GbSueldoAbonado.Visible = True
            GbSueldoLiquidar.Visible = True

            'Cambio el cursor a "NORMAL"
            Me.Cursor = Cursors.Arrow

        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha encontrado un error al consultar el estado de cuenta del empleado. Por favor, intente más tarde.", "Estado de Cuenta del Empleado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
        txtDescripcionPagoMano.Clear()
        GbSueldoTrabajado.Visible = False
        GbSueldoAbonado.Visible = False
        GbSueldoLiquidar.Visible = False
    End Sub

    Sub MostrarBotonesDetalle()
        BtnAdicionales.Visible = estadoCuenta.Adicionales <> 0
        BtnComisiones.Visible = estadoCuenta.Comisiones <> 0
        BtnVacaciones.Visible = estadoCuenta.Vacaciones <> 0
        BtnAguinaldo.Visible = estadoCuenta.Aguinaldo <> 0
        BtnAdelantos.Visible = estadoCuenta.Adelantos <> 0
        BtnSueldosPagados.Visible = estadoCuenta.SueldoPago <> 0
        BtnRegulares.Visible = estadoCuenta.CantidadDiasNormales > 0
        BtnFeriados.Visible = estadoCuenta.CantidadDiasFeriados > 0
    End Sub

    Sub CalcularSueldos(ByVal SueldoNormal As Double, ByVal SueldoFeriado As Double, ByVal SueldoPresentismo As Double, ByVal Deuda As Double)

        Dim SubTotalTrabajado As Double = (estadoCuenta.Comisiones + SueldoNormal + SueldoFeriado + estadoCuenta.Aguinaldo + estadoCuenta.Vacaciones + estadoCuenta.Adicionales + SueldoPresentismo)

        Dim SubTotalAbonado As Double = estadoCuenta.Adelantos + estadoCuenta.SueldoPago + Deuda

        If (SubTotalTrabajado - SubTotalAbonado < 0) Then
            SueldoPorDepositar = 0
            SueldoPorPagarEnMano = SubTotalTrabajado - SubTotalAbonado
        Else
            If ((estadoCuenta.RecivoSueldo - estadoCuenta.SueldoPago) = 0) Then
                SueldoPorDepositar = 0
                SueldoPorPagarEnMano = SubTotalTrabajado - SubTotalAbonado

                'Si al total trabajado menos la deuda del mes pasado no llega a cubrir el recivo de sueldo
            ElseIf (SubTotalTrabajado - Deuda < estadoCuenta.RecivoSueldo) Then
                'Defino el monto posible a pagar como esa diferencia menos lo que ya se le pudo haber pagado del recivo
                SueldoPorDepositar = SubTotalTrabajado - Deuda - estadoCuenta.SueldoPago
                SueldoPorPagarEnMano = 0
            ElseIf (Deuda >= 0) Then
                SueldoPorDepositar = estadoCuenta.RecivoSueldo - Deuda - estadoCuenta.SueldoPago
                If (SueldoPorDepositar < 0) Then
                    SueldoPorDepositar = 0
                End If
                SueldoPorPagarEnMano = SubTotalTrabajado - SubTotalAbonado - SueldoPorDepositar
            Else
                SueldoPorDepositar = estadoCuenta.RecivoSueldo - estadoCuenta.SueldoPago
                If (SueldoPorDepositar < 0) Then
                    SueldoPorDepositar = 0
                End If
                SueldoPorPagarEnMano = SubTotalTrabajado - SubTotalAbonado - SueldoPorDepositar
            End If
        End If
    End Sub

    'Funcion para obtener la deuda 
    Private Function CalcularDeudaMesVencidos(ByVal id_Empleado As Integer, ByVal id_Sucursal As Integer, ByVal FechaDesde As DateTime, ByVal FechaHasta As DateTime, ByVal TuvoDeuda As Boolean) As Double
        Dim SueldoPresentismo As Double = 0
        Dim Deuda As Double = 0

        'Obtengo es tada del cuanta del mes anterior
        Dim estadoCuenta = NegEmpleados.ObtenerEstadoCuenta(id_Empleado, id_Sucursal, FechaDesde.AddMonths(-1).ToString("yyyy/MM/dd"), FechaDesde.AddDays(-1).ToString("yyyy/MM/dd"))

        'En caso que la deuda no tenga valor es porque no se tiene deuda registrada para este mes, por lo que calculo la deuda
        If (Not estadoCuenta.Deuda.HasValue) Then
            'Antes de entrar al proceso recirsivo verifico que el empleado halla tenido algun registro de deuda para tener un corte de la recursividad
            If (TuvoDeuda Or NegEmpleados.UltimaDeuda(id_Empleado, id_Sucursal, FechaDesde) = DateTime.MinValue).HasValue Then
                'Calcula la deuda que le corresponde a este mes
                Deuda = CalcularDeudaMesVencidos(id_Empleado, id_Sucursal, FechaDesde.AddMonths(-1).ToString("yyyy/MM/dd"), FechaDesde.AddDays(-1).ToString("yyyy/MM/dd"), True)
            End If
        Else
            Deuda = estadoCuenta.Deuda.Value
        End If

        If estadoCuenta.CantidadDiasAusente = 0 Then
            SueldoPresentismo = estadoCuenta.CantidadDiasNormales * eEmpleados.SueldoPresentismo
        End If

        'Calculo el total trabajado y el total abonado
        Dim SubTotalTrabajado As Double = (estadoCuenta.Comisiones + estadoCuenta.CantidadDiasNormales * eEmpleados.SueldoNormal + estadoCuenta.CantidadDiasFeriados * eEmpleados.SueldoFeriado + estadoCuenta.Aguinaldo + estadoCuenta.Vacaciones + estadoCuenta.Adicionales + SueldoPresentismo)
        Dim SubTotalAbonado As Double = estadoCuenta.Adelantos + estadoCuenta.SueldoPago + Deuda

        Deuda = -(SubTotalTrabajado - SubTotalAbonado)
        'Registro la deuda
        NegEmpleados.ActualizarDeuda(id_Empleado, id_Sucursal, Deuda, FechaDesde)
        Return Deuda
    End Function

    Sub ActualizarEstadoBotones()

        Dim fechaDesde As DateTime = New DateTime(txtDate.Value.Year, txtDate.Value.Month, 1).ToString("yyyy/MM/dd")
        Dim DiferenciaMeses As Integer = (fechaDesde.Month - DateTime.Now.Month) + 12 * (fechaDesde.Year - DateTime.Now.Year)

        'Los pagos se pueden realizar si la diferencia de meses es menor a 1 (la fecha seleccionada no puede ser en un mes posterior a la actual)
        'Los pagos se pueden realizar si la diferencia de meses es mayor a -2 (la fecha seleccionada no puede ser en 2 mes antes a la actual)
        If Not (DiferenciaMeses < 1 And DiferenciaMeses > -2) Then
            btn_depositar.Enabled = False
            ToolEmpleados.SetToolTip(btn_depositar, "No se permite realizar depósitos en el periodo seleccionado.")
            btnPagoMano.Enabled = False
            ToolEmpleados.SetToolTip(btnPagoMano, "No se permite realizar pagos en manos en el periodo seleccionado.")
            Return
        End If

        'actualizo el estado del boton en caso de que no se encuentre mas sueldo para depositar
        If (SueldoPorDepositar = 0) Then
            btn_depositar.Enabled = False
            lblSueldoDepositarMaximo.Visible = False
            ToolEmpleados.SetToolTip(btn_depositar, "No se dispone de sueldo para depositar.")
        Else
            btn_depositar.Enabled = True
            ToolEmpleados.SetToolTip(btn_depositar, "Depositar sueldo.")
        End If

        ''actualizo el estado del boton en caso de que no se encuentre mas sueldo para pagar en mano
        'If (SueldoPorPagarEnMano <= 0) Then
        '    btnPagoMano.Enabled = False
        '    lblSueldoPagarManoMaximo.Visible = False
        '    ToolEmpleados.SetToolTip(btnPagoMano, "No se dispone de sueldo para pagar en mano.")
        'Else
        btnPagoMano.Enabled = True
        ToolEmpleados.SetToolTip(btnPagoMano, "Pago en mano.")
        'End If
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
        If (SueldoPorDepositar < CDbl(txt_Saldo.Text)) Then
            MessageBox.Show("El monto ingresado en Sueldo a Depositar es mayor al Máximo permitido. Debe ingresar un monto igual o menor al Máximo. ", "Estado de Cuenta del Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        If MessageBox.Show("¿Ésta seguro que desea efectuar el deposito del sueldo del empleado " & eEmpleados.Apellido & ", " & eEmpleados.Nombre & " ?", "Estado de Cuenta del Empleado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Try
                'Cambio el cursor a "WAIT"
                Me.Cursor = Cursors.WaitCursor

                Dim sueldoDepositado As Double = CDbl(txt_Saldo.Text)

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
                eDeposito.Fecha = txtDate.Value.ToString("yyyy/MM/dd")
                eDeposito.Mes = Month(txtDate.Text)
                eDeposito.Anio = Year(txtDate.Text)
                eDeposito.Habilitado = 1
                NegEmpleados.AltaDeposito(eDeposito)

                'actualizo los valores del sueldo depositado y sueldo por depositar
                estadoCuenta.SueldoPago += sueldoDepositado
                txt_SueldosPagados.Text = estadoCuenta.SueldoPago.ToString("c")

                SueldoPorDepositar -= sueldoDepositado
                txt_Saldo.Text = (SueldoPorDepositar).ToString("c")
                lblSueldoDepositarMaximo.Text = String.Format("(Máximo {0:C})", SueldoPorDepositar)

                'El monto de la deuda se calcula con el faltante del sueldo que se debio depositar + el sueldo en mano que se pudo haber pagado de mas por la funcionalidad de adelantos o de menos por que no se liquido el total que le corresponde al empleado
                'Ambos montos se cambian de signo para que quede consistente en el calculo del proximo mes
                ActualizarDeuda(-SueldoPorDepositar + -SueldoPorPagarEnMano)

                If SueldoPorDepositar <> 0 Then
                    lblSueldoDepositarMaximo.Visible = True
                    txt_Saldo.ReadOnly = False
                Else
                    lblSueldoDepositarMaximo.Visible = False
                    txt_Saldo.ReadOnly = True
                End If

                txtDescripcionPagoMano.Clear()

                ActualizarEstadoBotones()

                MessageBox.Show("Se ha depositado correctamente el sueldo del empleado " & eEmpleados.Apellido & ", " & eEmpleados.Nombre, "Estado de Cuenta del Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information)

                'Cambio el cursor a "NORMAL"
                Me.Cursor = Cursors.Arrow

            Catch ex As Exception
                Me.Cursor = Cursors.Arrow
                MessageBox.Show("Se ha encontrado un error al depositar el sueldo del empleado. Por favor, intente más tarde.", "Estado de Cuenta del Empleado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End If

    End Sub

    Private Sub btnPagoMano_Click(sender As Object, e As EventArgs) Handles btnPagoMano.Click
        If txtDescripcionPagoMano.Text = "" Then
            MessageBox.Show("Debe completar el campos descripción para poder realizar un pago en mano.", "Estado de Cuenta del Empleado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ErrorProvider.SetError(txtDescripcionPagoMano, "El campo no puede estar vacio.")
            Return
        Else
            ErrorProvider.SetError(txtDescripcionPagoMano, String.Empty)
        End If

        If (CDbl(txt_sueldoMano.Text) < 0) Then
            MessageBox.Show("El monto ingresado en Sueldo a pagar en Mano debe ser mayor a Cero.", "Estado de Cuenta del Empleado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ErrorProvider.SetError(txt_sueldoMano, "El monto ingresado debe ser mayor a Cero.")
            Return
        Else
            ErrorProvider.SetError(txt_sueldoMano, String.Empty)
        End If

        If MessageBox.Show("¿Ésta seguro que desea efectuar el pago en mano del sueldo del empleado " & eEmpleados.Apellido & ", " & eEmpleados.Nombre & " ?", "Estado de Cuenta del Empleado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Try
                'Cambio el cursor a "WAIT"
                Me.Cursor = Cursors.WaitCursor

                Dim sueldoPagadoEnMano As Double = CDbl(txt_sueldoMano.Text)

                'Registro el pago del sueldo en mano si el mismo es mayor a 0
                Dim EAdelanto As New Entidades.Adelantos
                EAdelanto.id_Adelanto = 0
                EAdelanto.Fecha = txtDate.Value.ToString("yyyy/MM/dd")
                EAdelanto.Monto = sueldoPagadoEnMano
                EAdelanto.id_Empleado = id_Empleado
                EAdelanto.id_Sucursal = id_Sucursal
                EAdelanto.Descripcion = txtDescripcionPagoMano.Text
                NegAdelantos.AltaAdelanto(EAdelanto)

                estadoCuenta.Adelantos += sueldoPagadoEnMano
                txt_Adelantos.Text = estadoCuenta.Adelantos.ToString("c")

                SueldoPorPagarEnMano -= sueldoPagadoEnMano
                txt_sueldoMano.Text = SueldoPorPagarEnMano.ToString("c")
                lblSueldoPagarManoMaximo.Text = String.Format("(Sugerido {0:C})", SueldoPorPagarEnMano)

                'El monto de la deuda se calcula con el faltante del sueldo que se debio depositar + el sueldo en mano que se pudo haber pagado de mas por la funcionalidad de adelantos o de menos por que no se liquido el total que le corresponde al empleado
                'Ambos montos se cambian de signo para que quede consistente en el calculo del proximo mes
                ActualizarDeuda(-SueldoPorDepositar + -SueldoPorPagarEnMano)

                If SueldoPorPagarEnMano > 0 Then
                    lblSueldoPagarManoMaximo.Visible = True
                Else
                    lblSueldoPagarManoMaximo.Visible = False
                End If

                txtDescripcionPagoMano.Clear()

                ActualizarEstadoBotones()

                MessageBox.Show("Se ha pagado correctamente el sueldo en mano del empleado " & eEmpleados.Apellido & ", " & eEmpleados.Nombre, "Estado de Cuenta del Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information)

                'Cambio el cursor a "NORMAL"
                Me.Cursor = Cursors.Arrow

            Catch ex As Exception
                Me.Cursor = Cursors.Arrow
                MessageBox.Show("Se ha encontrado un error al depositar el sueldo del empleado. Por favor, intente más tarde.", "Estado de Cuenta del Empleado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End If
    End Sub

    Private Sub ActualizarDeuda(monto As Double)
        Dim fechaDeuda As DateTime = New DateTime(txtDate.Value.Year, txtDate.Value.Month, 1).AddMonths(1)
        NegEmpleados.ActualizarDeuda(id_Empleado, id_Sucursal, monto, fechaDeuda)
    End Sub

    'Valida que solo se ingresen valores numericos
    Private Sub txt_Saldo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Saldo.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_Saldo_Enter(sender As Object, e As EventArgs) Handles txt_Saldo.Enter
        If (Not txt_Saldo.ReadOnly) Then
            txt_Saldo.Text = String.Empty
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
            ErrorProvider.SetError(txt_Saldo, String.Empty)
        End If
        txt_Saldo.Text = SaldoDepositarIngresado.ToString("c")
    End Sub

    Private Sub txt_sueldoMano_Enter(sender As Object, e As EventArgs) Handles txt_sueldoMano.Enter
        If (Not txt_sueldoMano.ReadOnly) Then
            txt_sueldoMano.Text = String.Empty
        End If
    End Sub

    'Valida que solo se ingresen valores numericos
    Private Sub txt_sueldoMano_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_sueldoMano.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_sueldoMano_Leave(sender As Object, e As EventArgs) Handles txt_sueldoMano.Leave
        If (txt_sueldoMano.Text = String.Empty) Then
            txt_sueldoMano.Text = SueldoPorPagarEnMano.ToString("c")
            Return
        End If

        Dim SaldoPagoManoIngresado As Double = CDbl(txt_sueldoMano.Text)
        txt_sueldoMano.Text = SaldoPagoManoIngresado.ToString("c")
    End Sub

End Class