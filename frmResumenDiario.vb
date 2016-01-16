Public Class frmResumenDiario
    Dim id_Sucursal As String
    Dim Fecha As String = ""
    Dim FechaAyer As String = ""
    Dim Saldo As Double = 0
    Dim NegVen As New Negocio.NegVentas
    Dim NegMov As New Negocio.NegMovimientos
    Dim NegEmp As New Negocio.NegEmpleados
    Dim NegMerca As New Negocio.NegMercaderia
    Dim NegCaja As New Negocio.NegCajaInicial
    Dim NegAdel As New Negocio.NegAdelantos
    Dim NegAdic As New Negocio.NegAdicionales
    Dim NegErrores As New Negocio.NegManejadorErrores

    'Load del formulario.
    Private Sub frmResumenDiario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor

            'Sucursal default
            lblSucursalNombre.Text = My.Settings("NombreSucursal")
            id_Sucursal = My.Settings("Sucursal")

            'Obtengo la data del dia.
            ObtenerDatos("SI")

            Me.Cursor = Cursors.Arrow

        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha producido un error al cargar el formulario.", "Resumen Diario", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
 
    End Sub

    'Funcion que limpia el formulario.
    Sub LimpiarForm()
        txt_CajaInicial.Clear()
        txt_EfectivoEgreso.Clear()
        txt_Impuesto.Clear()
        txt_RetirosCaja.Clear()
        txt_Gastos.Clear()
        txt_Sueldo.Clear()
        txt_Mercaderias.Clear()
        txt_TotalVentas.Clear()
        txt_VentasEfectivo.Clear()
        txt_VentasCheque.Clear()
        txt_VentasCredito.Clear()
        txt_VentasDebito.Clear()
        txt_TotalFacturado.Clear()
        txt_VentaMayorista.Clear()
        txt_VentaMinorista.Clear()
        txt_Faltante.Clear()
        txt_Sobrante.Clear()
        txt_Efectivo.Clear()
        txt_DevolucionesEgr.Clear()
        txt_Aporte.Clear()

    End Sub

    'Funcion que carga el formulario.
    Sub ObtenerDatos(Optional ByVal FechaHoy As String = "NO")
        Try
            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            'Muestro el form de espera..
            frmCargadorDeEspera.Show()
            frmCargadorDeEspera.Text = "Generando Resumen Diario... "
            frmCargadorDeEspera.lbl_Descripcion.Text = "Iniciando... "
            frmCargadorDeEspera.BarraProgreso.Minimum = 0
            frmCargadorDeEspera.BarraProgreso.Maximum = 21
            frmCargadorDeEspera.BarraProgreso.Value = 1
            frmCargadorDeEspera.Refresh()

            'Seteo de Formulario.
            LimpiarForm()

            'Setes
            If FechaHoy = "SI" Then
                Fecha = Now.Date.ToString("yyyy/MM/dd")
                FechaAyer = Now.Date.AddDays(-1).ToString("yyyy/MM/dd")
            Else
                Fecha = txt_Fecha.Value.ToString("yyyy/MM/dd")
                FechaAyer = txt_Fecha.Value.AddDays(-1).ToString("yyyy/MM/dd")
            End If

            Dim entCaja As New Entidades.CajaInicial
            Dim entCaja2 As New Entidades.CajaInicial
            entCaja = NegCaja.ObtenerCaja(id_Sucursal, Fecha)
            entCaja2 = NegCaja.ObtenerCaja(id_Sucursal, FechaAyer)

            txt_CajaInicial.Text = "$ " & Format(CType((entCaja2.Monto), Decimal), "###0.00") & ".-"

            'Voy seteando la barra de progreso
            frmCargadorDeEspera.lbl_Descripcion.Text = "Obteniendo caja inicial..."
            frmCargadorDeEspera.BarraProgreso.Value += 1
            frmCargadorDeEspera.Refresh()

            Dim VentasMinoristas As Double = 0
            VentasMinoristas = NegVen.TotalVentasMinoristas(id_Sucursal, Fecha)
            txt_VentaMinorista.Text = "$ " & Format(CType((VentasMinoristas), Decimal), "###0.00") & ".-"

            'Voy seteando la barra de progreso
            frmCargadorDeEspera.lbl_Descripcion.Text = "Obteniendo Aporte Socios..."
            frmCargadorDeEspera.BarraProgreso.Value += 1
            frmCargadorDeEspera.Refresh()

            Dim AporteSocios As Double = 0
            AporteSocios = NegMov.ConsultarTotalMovimiento(id_Sucursal, Fecha, Fecha, 6)
            txt_Aporte.Text = "$ " & Format(CType((AporteSocios), Decimal), "###0.00") & ".-"

            'Voy seteando la barra de progreso
            frmCargadorDeEspera.lbl_Descripcion.Text = "Obteniendo ventas minoristas..."
            frmCargadorDeEspera.BarraProgreso.Value += 1
            frmCargadorDeEspera.Refresh()

            Dim VentasMayoristas As Double = 0
            VentasMayoristas = NegVen.TotalVentasMayoristas(id_Sucursal, Fecha)
            txt_VentaMayorista.Text = "$ " & Format(CType((VentasMayoristas), Decimal), "###0.00") & ".-"

            'Voy seteando la barra de progreso
            frmCargadorDeEspera.lbl_Descripcion.Text = "Obteniendo ventas mayoristas..."
            frmCargadorDeEspera.BarraProgreso.Value += 1
            frmCargadorDeEspera.Refresh()

            Dim TotalFacturado As Double = 0
            TotalFacturado = NegVen.TotalVentasFacturado(id_Sucursal, Fecha)
            txt_TotalFacturado.Text = "$ " & Format(CType((TotalFacturado), Decimal), "###0.00") & ".-"

            'Voy seteando la barra de progreso
            frmCargadorDeEspera.lbl_Descripcion.Text = "Obteniendo el total facturado..."
            frmCargadorDeEspera.BarraProgreso.Value += 1
            frmCargadorDeEspera.Refresh()

            Dim TotalVentas As Double = 0
            TotalVentas = NegVen.TotalVentas(id_Sucursal, Fecha)
            txt_TotalVentas.Text = "$ " & Format(CType((TotalVentas), Decimal), "###0.00") & ".-"

            'Voy seteando la barra de progreso
            frmCargadorDeEspera.lbl_Descripcion.Text = "Obteniendo el total en ventas..."
            frmCargadorDeEspera.BarraProgreso.Value += 1
            frmCargadorDeEspera.Refresh()

            Dim VentasCheque As Double = 0
            VentasCheque = NegVen.TotalVentasCheque(id_Sucursal, Fecha)
            txt_VentasCheque.Text = "$ " & Format(CType((VentasCheque), Decimal), "###0.00") & ".-"

            Dim VentasEfectivo As Double = 0
            VentasEfectivo = NegVen.TotalVentasEfectivo(id_Sucursal, Fecha)
            txt_VentasEfectivo.Text = "$ " & Format(CType((VentasEfectivo), Decimal), "###0.00") & ".-"


            'Voy seteando la barra de progreso
            frmCargadorDeEspera.lbl_Descripcion.Text = "Obteniendo el total de ventas en efectivo..."
            frmCargadorDeEspera.BarraProgreso.Value += 1
            frmCargadorDeEspera.Refresh()

            Dim VentasCredito As Double = 0
            VentasCredito = NegVen.ObtenerVentasSucursalCredito(id_Sucursal, Fecha, Fecha)
            txt_VentasCredito.Text = "$ " & Format(CType((VentasCredito), Decimal), "###0.00") & ".-"

            Dim VentasDevito As Double = 0
            VentasDevito = NegVen.ObtenerVentasSucursalDebito(id_Sucursal, Fecha, Fecha)
            txt_VentasDebito.Text = "$ " & Format(CType((VentasDevito), Decimal), "###0.00") & ".-"

            'Voy seteando la barra de progreso
            frmCargadorDeEspera.lbl_Descripcion.Text = "Obteniendo el total de ventas en tarjetas..."
            frmCargadorDeEspera.BarraProgreso.Value += 1
            frmCargadorDeEspera.Refresh()

            Dim Gastos As Double = 0
            Gastos = NegMov.ConsultarTotalMovimiento(id_Sucursal, Fecha, Fecha, 1)
            txt_Gastos.Text = "$ " & Format(CType((Gastos), Decimal), "###0.00") & ".-"

            'Voy seteando la barra de progreso
            frmCargadorDeEspera.lbl_Descripcion.Text = "Obteniendo gastos..."
            frmCargadorDeEspera.BarraProgreso.Value += 1
            frmCargadorDeEspera.Refresh()

            Dim EfectivoEgreso As Double = 0
            EfectivoEgreso = NegMov.ObtenerTotalMovEgreso(id_Sucursal, Fecha, Fecha, "Egresos")
            txt_EfectivoEgreso.Text = "$ " & Format(CType((EfectivoEgreso), Decimal), "###0.00") & ".-"

            Dim PendienteAutorizar As Double = 0
            PendienteAutorizar = NegMov.ObtenerTotalMovEgreso(id_Sucursal, Date.MinValue.ToString("yyyy/MM/dd"), Fecha, "EgresosPendientes")
            txt_PendienteAutorizar.Text = "$ " & Format(CType((PendienteAutorizar), Decimal), "###0.00") & ".-"

            Dim DevolucionEgreso As Double = 0
            DevolucionEgreso = NegMov.ObtenerTotalMovEgreso(id_Sucursal, Fecha, Fecha, "Devolucion")
            txt_DevolucionesEgr.Text = "$ " & Format(CType((DevolucionEgreso), Decimal), "###0.00") & ".-"

            'Voy seteando la barra de progreso
            frmCargadorDeEspera.lbl_Descripcion.Text = "Obteniendo egresos..."
            frmCargadorDeEspera.BarraProgreso.Value += 1
            frmCargadorDeEspera.Refresh()

            Dim EfectivoIngreso As Double = 0
            EfectivoIngreso = NegMov.ObtenerTotalMovEgreso(id_Sucursal, Fecha, Fecha, "Ingresos")
            txt_Efectivo.Text = "$ " & Format(CType((EfectivoIngreso), Decimal), "###0.00") & ".-"

            'Voy seteando la barra de progreso
            frmCargadorDeEspera.lbl_Descripcion.Text = "Obteniendo ingresos..."
            frmCargadorDeEspera.BarraProgreso.Value += 1
            frmCargadorDeEspera.Refresh()

            Dim Impuesto As Double = 0
            Impuesto = NegMov.ConsultarTotalMovimiento(id_Sucursal, Fecha, Fecha, 3)
            txt_Impuesto.Text = "$ " & Format(CType((Impuesto), Decimal), "###0.00") & ".-"

            'Voy seteando la barra de progreso
            frmCargadorDeEspera.lbl_Descripcion.Text = "Obteniendo impuestos..."
            frmCargadorDeEspera.BarraProgreso.Value += 1
            frmCargadorDeEspera.Refresh()

            Dim RetirosCaja As Double = 0
            RetirosCaja = NegMov.ConsultarTotalMovimiento(id_Sucursal, Fecha, Fecha, 5)
            txt_RetirosCaja.Text = "$ " & Format(CType((RetirosCaja), Decimal), "###0.00") & ".-"

            'Voy seteando la barra de progreso
            frmCargadorDeEspera.lbl_Descripcion.Text = "Obteniendo retiros..."
            frmCargadorDeEspera.BarraProgreso.Value += 1
            frmCargadorDeEspera.Refresh()

            Dim Sobrante As Double = 0
            Sobrante = NegMov.ObtenerTotalMovCaja(id_Sucursal, Fecha, Fecha, "Sobrante")
            txt_Sobrante.Text = "$ " & Format(CType((Sobrante), Decimal), "###0.00") & ".-"

            'Voy seteando la barra de progreso
            frmCargadorDeEspera.lbl_Descripcion.Text = "Obteniendo sobrantes de caja..."
            frmCargadorDeEspera.BarraProgreso.Value += 1
            frmCargadorDeEspera.Refresh()

            Dim Faltante As Double = 0
            Faltante = NegMov.ObtenerTotalMovCaja(id_Sucursal, Fecha, Fecha, "Faltante")
            txt_Faltante.Text = "$ " & Format(CType((Faltante), Decimal), "###0.00") & ".-"

            'Voy seteando la barra de progreso
            frmCargadorDeEspera.lbl_Descripcion.Text = "Obteniendo faltantes de caja..."
            frmCargadorDeEspera.BarraProgreso.Value += 1
            frmCargadorDeEspera.Refresh()

            Dim Adelantos As Double = 0
            Dim Sueldo As Double = 0
            Adelantos = NegAdel.ObtenerAdelantosSucursal(id_Sucursal, Fecha, Fecha)
            Sueldo = NegEmp.ObtenerSueldosSucursal(id_Sucursal, Fecha, Fecha)
            txt_Sueldo.Text = "$ " & Format(CType((Sueldo + Adelantos), Decimal), "###0.00") & ".-"

            'Voy seteando la barra de progreso
            frmCargadorDeEspera.lbl_Descripcion.Text = "Obteniendo adelantos de empleados..."
            frmCargadorDeEspera.BarraProgreso.Value += 1
            frmCargadorDeEspera.Refresh()

            'Voy seteando la barra de progreso
            frmCargadorDeEspera.lbl_Descripcion.Text = "Obteniendo adicionales de empleados..."
            frmCargadorDeEspera.BarraProgreso.Value += 1
            frmCargadorDeEspera.Refresh()

            Dim Mercaderias As Double = 0
            Mercaderias = NegMov.ConsultarTotalGastoMercaderia(id_Sucursal, Fecha, Fecha)
            txt_Mercaderias.Text = "$ " & Format(CType((Mercaderias), Decimal), "###0.00") & ".-"

            'Voy seteando la barra de progreso
            frmCargadorDeEspera.lbl_Descripcion.Text = "Obteniendo total en mercaderias..."
            frmCargadorDeEspera.BarraProgreso.Value += 1
            frmCargadorDeEspera.Refresh()

            Dim EgresoCajaFuerte As Double = 0
            EgresoCajaFuerte = NegMov.ObtenerTotalMovCajaFuerte(id_Sucursal, Fecha, Fecha, 1)
            txt_CajaFuerteIng.Text = "$ " & Format(CType((EgresoCajaFuerte), Decimal), "###0.00") & ".-"

            'Voy seteando la barra de progreso
            frmCargadorDeEspera.lbl_Descripcion.Text = "Obteniendo ingresos a caja fuerte..."
            frmCargadorDeEspera.BarraProgreso.Value += 1
            frmCargadorDeEspera.Refresh()

            Dim IngresoCajaFuerte As Double = 0
            IngresoCajaFuerte = NegMov.ObtenerTotalMovCajaFuerte(id_Sucursal, Fecha, Fecha, 2)
            txt_CajaFuerteEgr.Text = "$ " & Format(CType((IngresoCajaFuerte), Decimal), "###0.00") & ".-"

            'Voy seteando la barra de progreso
            frmCargadorDeEspera.lbl_Descripcion.Text = "Obteniendo egresos a caja fuerte..."
            frmCargadorDeEspera.BarraProgreso.Value += 1
            frmCargadorDeEspera.Refresh()

            'Calculo el saldo.
            Dim Ingresos As Double = 0
            Dim Egresos As Double = 0

            Dim NegDevolucion As Negocio.NegDevolucion = New Negocio.NegDevolucion()
            Dim DevolucionesEfectivo As Double = NegDevolucion.TotalDevolucionesEfectivo(id_Sucursal, Fecha)

            Ingresos = VentasEfectivo + Sobrante + entCaja2.Monto + EfectivoIngreso + EgresoCajaFuerte + AporteSocios
            Egresos = EfectivoEgreso + Gastos + Mercaderias + Impuesto + RetirosCaja + Faltante + Adelantos + Sueldo + IngresoCajaFuerte + DevolucionesEfectivo
            Saldo = Ingresos - Egresos

            'Resto el pendiente de autorizar para el que Saldo de este dia lo contemple
            'No lo resto de la variable saldo para que este concepto no forme parte del valor del cierre de la caja
            lbl_Saldo.Text = "$ " & Format(CType((Saldo - PendienteAutorizar), Decimal), "###0.00") & ".-"
            If Saldo < 0 Then
                lbl_Saldo.ForeColor = Color.Red
            Else
                lbl_Saldo.ForeColor = Color.Green
            End If

            Dim CajaFuerteTotal As Double = 0
            CajaFuerteTotal = NegMov.ConsultarTotalCajaFuerte(id_Sucursal, Fecha)

            Dim DisponibleEfectivo As Double = 0
            DisponibleEfectivo = Saldo - PendienteAutorizar + CajaFuerteTotal

            lbl_DispoEfect.Text = "$ " & Format(CType((DisponibleEfectivo), Decimal), "###0.00") & ".-"
            lbl_DispoCheq.Text = "$ " & Format(CType((VentasCheque), Decimal), "###0.00") & ".-"

            If DisponibleEfectivo < 0 Then
                lbl_DispoEfect.ForeColor = Color.Red
            Else
                lbl_DispoEfect.ForeColor = Color.Green
            End If

            If VentasCheque < 0 Then
                lbl_DispoCheq.ForeColor = Color.Red
            Else
                lbl_DispoCheq.ForeColor = Color.Green
            End If

            'Si hay caja del dia..
            If entCaja.id_Caja > 0 Then
                lbl_Empleado.Text = entCaja.Empleado
                lbl_Fecha.Text = entCaja.Fecha
                lbl_Hora.Text = entCaja.Hora
                GB_Caja.Visible = True
                If entCaja.Abierta = 1 Then
                    lbl_Abierta.Visible = True
                Else
                    lbl_Abierta.Visible = False
                End If
            Else
                lbl_Empleado.Text = ""
                lbl_Fecha.Text = ""
                lbl_Hora.Text = ""
                lbl_Abierta.Visible = False
                GB_Caja.Visible = False
            End If

            If FechaHoy = "NO" Then
                Btn_Abrir.Enabled = False
                Btn_Cerrar.Enabled = False
            Else
                If entCaja.id_Caja > 0 Then
                    Btn_Cerrar.Enabled = False
                    Btn_Abrir.Enabled = True
                Else
                    Btn_Cerrar.Enabled = True
                    Btn_Abrir.Enabled = False
                End If
            End If

            'Voy seteando la barra de progreso
            frmCargadorDeEspera.Close()
            frmCargadorDeEspera.Dispose()

            'Cambio el cursor a "NORMAL"
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha encontrado un error al al procesar el resumen.", "Resumen Diario", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            ErrorResumen.SetError(txtMonto, "Debe ingresar el monto en el formato permitido. Ejemplo: 725,50")
        Else
            ErrorResumen.SetError(txtMonto, Nothing)
        End If
    End Sub

    'Exit.
    Private Sub Btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Salir.Click
        Me.Close()
    End Sub

    'Evento click del boton buscar!.
    Private Sub Btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Buscar.Click
        If txt_Fecha.Value.ToShortDateString = Now.Date.ToShortDateString Then
            ObtenerDatos("SI")
        Else
            ObtenerDatos()
        End If
    End Sub

    'Boton que limpia el formulario.
    Private Sub Btn_Limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Limpiar.Click
        txt_Fecha.Value = Now()
        ObtenerDatos("SI")
    End Sub

    'Boton que procesa el cierre de caja.
    Private Sub Btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cerrar.Click
        If Trim(txtMonto.Text) = "" Then
            MessageBox.Show("Por favor, para cerrar la caja diaria se debe ingresar el monto físico que se encuentra en la sucursal.", "Resumen Diario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtMonto.Focus()
        Else
            If MessageBox.Show("Está seguro que desea cerrar la caja diaria?", "Resumen Diario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                If MessageBox.Show("Realmente está seguro que desea cerrar la caja diaria?" & vbCrLf & "Éste proceso debe llevarse a cabo solamente al finalizar el día", "Resumen Diario", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                    Try
                        'Cursor.
                        Me.Cursor = Cursors.WaitCursor

                        'Calculo el saldo.
                        ObtenerDatos("SI")

                        'Monto fisico.
                        Dim MontoFisico As Double = 0
                        MontoFisico = CDbl(Trim(txtMonto.Text))

                        'Hay diferencias entre los saldos.
                        If (MontoFisico <> Saldo) Then
                            'Acepta pasar dicha diferencia a caja.
                            If (MessageBox.Show("Se han encontrado diferencias entre el saldo calculado y el ingresado. ¿Desea enviar dicha diferencia a caja?.", "Resumen Diario", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes) Then

                                'Acepto la diferencia.
                                Dim Diferencia As Double = 0

                                If Saldo < 0 Then
                                    Diferencia = (Saldo * -1) + MontoFisico
                                    If Diferencia > 0 Then 'sobrante.
                                        Dim eCaja As New Entidades.MovCaja
                                        eCaja.id_Movimiento = 0
                                        eCaja.id_Sucursal = id_Sucursal
                                        eCaja.id_Usuario = VariablesGlobales.objUsuario.id_Usuario
                                        eCaja.id_Tipo = 3
                                        eCaja.Descripcion = "Sobrante de dinero en el cierre de caja."
                                        eCaja.Fecha = Now
                                        eCaja.Monto = Diferencia
                                        NegMov.AltaMovCaja(eCaja)
                                    Else 'faltante.
                                        Dim eCaja As New Entidades.MovCaja
                                        eCaja.id_Movimiento = 0
                                        eCaja.id_Sucursal = id_Sucursal
                                        eCaja.id_Usuario = VariablesGlobales.objUsuario.id_Usuario
                                        eCaja.id_Tipo = 2
                                        eCaja.Descripcion = "Faltante de dinero en el cierre de caja."
                                        eCaja.Fecha = Now
                                        eCaja.Monto = Diferencia
                                        NegMov.AltaMovCaja(eCaja)
                                    End If

                                Else
                                    Diferencia = Saldo - MontoFisico
                                    If Diferencia < 0 Then 'sobrante.
                                        Dim eCaja As New Entidades.MovCaja
                                        eCaja.id_Movimiento = 0
                                        eCaja.id_Sucursal = id_Sucursal
                                        eCaja.id_Usuario = VariablesGlobales.objUsuario.id_Usuario
                                        eCaja.id_Tipo = 3
                                        eCaja.Descripcion = "Sobrante de dinero en el cierre de caja."
                                        eCaja.Fecha = Now
                                        eCaja.Monto = (Diferencia * -1)
                                        NegMov.AltaMovCaja(eCaja)
                                    Else 'faltante.
                                        Dim eCaja As New Entidades.MovCaja
                                        eCaja.id_Movimiento = 0
                                        eCaja.id_Sucursal = id_Sucursal
                                        eCaja.id_Usuario = VariablesGlobales.objUsuario.id_Usuario
                                        eCaja.id_Tipo = 2
                                        eCaja.Descripcion = "Faltante de dinero en el cierre de caja."
                                        eCaja.Fecha = Now
                                        eCaja.Monto = Diferencia
                                        NegMov.AltaMovCaja(eCaja)
                                    End If
                                End If

                                'Calculo el saldo nuevamente.
                                ObtenerDatos("SI")

                                'Completo la clase de la caja.
                                Dim entCajaCerrada As New Entidades.CajaInicial
                                entCajaCerrada.id_Empleado = VariablesGlobales.objUsuario.id_Usuario
                                entCajaCerrada.id_Sucursal = id_Sucursal
                                entCajaCerrada.Abierta = VariablesGlobales.CajaCerrada
                                entCajaCerrada.Empleado = VariablesGlobales.objUsuario.Usuario
                                entCajaCerrada.Monto = Saldo
                                entCajaCerrada.Fecha = Now.Date
                                entCajaCerrada.Hora = Now.Date

                                'Cierro la caja.
                                Dim Resultado As Integer = 0
                                Resultado = NegCaja.CerrarCaja(entCajaCerrada)
                                If Resultado = 1 Then
                                    Me.Cursor = Cursors.Arrow

                                    'Oculto Botones.
                                    Btn_Abrir.Enabled = True
                                    Btn_Cerrar.Enabled = False
                                    VariablesGlobales.CajaCerrada = 1

                                    'Muestro el detalle de la caja cerrada.
                                    Dim FNueva As String = ""
                                    FNueva = Now.Date.ToString("yyyy/MM/dd")
                                    Dim entCajaNueva As New Entidades.CajaInicial
                                    entCajaNueva = NegCaja.ObtenerCaja(id_Sucursal, FNueva)
                                    If entCajaNueva.id_Caja > 0 Then
                                        lbl_Empleado.Text = entCajaNueva.Empleado
                                        lbl_Fecha.Text = entCajaNueva.Fecha
                                        lbl_Hora.Text = entCajaNueva.Hora
                                        If entCajaNueva.Abierta = 1 Then
                                            lbl_Abierta.Visible = True
                                        Else
                                            lbl_Abierta.Visible = False
                                        End If
                                        GB_Caja.Visible = True
                                    Else
                                        lbl_Empleado.Text = ""
                                        lbl_Fecha.Text = ""
                                        lbl_Hora.Text = ""
                                        lbl_Abierta.Visible = False
                                        GB_Caja.Visible = False
                                    End If

                                    'Oculto los menus.
                                    MDIContenedor.MenuAccesosRapidos.Visible = False
                                    MDIContenedor.ToolsMenu.Visible = False
                                    MDIContenedor.SeguridadToolStripMenuItem.Visible = False
                                    MDIContenedor.Btn_SincronizacionMenu.Visible = False
                                    MDIContenedor.BackgroundImageLayout = ImageLayout.Stretch
                                    MDIContenedor.Btn_ResumenDiario.Visible = True
                                    MDIContenedor.Refresh()

                                    'Cursor.
                                    Me.Cursor = Cursors.Arrow

                                    'limpio el campo monto.
                                    txtMonto.Clear()

                                    MessageBox.Show("La caja diaria ha sido cerrada correctamente.", "Resumen Diario", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                ElseIf Resultado = 3 Then
                                    Me.Cursor = Cursors.Arrow
                                    MessageBox.Show("Ya existe un cierre de caja para la fecha de hoy.", "Resumen Diario", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Else
                                    Me.Cursor = Cursors.Arrow
                                    Btn_Abrir.Enabled = False
                                    Btn_Cerrar.Enabled = True
                                    MessageBox.Show("La caja no ha podido ser cerrada." & vbCrLf & "Por favor, Comuniquese con el administrador.", "Resumen Diario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                End If

                            End If
                        Else 'No hay diferencias.
                            'Completo la clase de la caja.
                            Dim entCajaCerrada As New Entidades.CajaInicial
                            entCajaCerrada.id_Empleado = VariablesGlobales.objUsuario.id_Usuario
                            entCajaCerrada.id_Sucursal = id_Sucursal
                            entCajaCerrada.Abierta = VariablesGlobales.CajaCerrada
                            entCajaCerrada.Empleado = VariablesGlobales.objUsuario.Usuario
                            entCajaCerrada.Monto = Saldo
                            entCajaCerrada.Fecha = Now.Date
                            entCajaCerrada.Hora = Now.Date

                            'Cierro la caja.
                            Dim Resultado As Integer = 0
                            Resultado = NegCaja.CerrarCaja(entCajaCerrada)
                            If Resultado = 1 Then
                                Me.Cursor = Cursors.Arrow

                                'Oculto Botones.
                                Btn_Abrir.Enabled = True
                                Btn_Cerrar.Enabled = False
                                VariablesGlobales.CajaCerrada = 1

                                'Muestro el detalle de la caja cerrada.
                                Dim FNueva As String = ""
                                FNueva = Now.Date.ToString("yyyy/MM/dd")
                                Dim entCajaNueva As New Entidades.CajaInicial
                                entCajaNueva = NegCaja.ObtenerCaja(id_Sucursal, FNueva)
                                If entCajaNueva.id_Caja > 0 Then
                                    lbl_Empleado.Text = entCajaNueva.Empleado
                                    lbl_Fecha.Text = entCajaNueva.Fecha
                                    lbl_Hora.Text = entCajaNueva.Hora
                                    If entCajaNueva.Abierta = 1 Then
                                        lbl_Abierta.Visible = True
                                    Else
                                        lbl_Abierta.Visible = False
                                    End If
                                    GB_Caja.Visible = True
                                Else
                                    lbl_Empleado.Text = ""
                                    lbl_Fecha.Text = ""
                                    lbl_Hora.Text = ""
                                    lbl_Abierta.Visible = False
                                    GB_Caja.Visible = False
                                End If

                                'Oculto los menus.
                                MDIContenedor.MenuAccesosRapidos.Visible = False
                                MDIContenedor.ToolsMenu.Visible = False
                                MDIContenedor.SeguridadToolStripMenuItem.Visible = False
                                MDIContenedor.Btn_SincronizacionMenu.Visible = False
                                MDIContenedor.BackgroundImageLayout = ImageLayout.Stretch
                                MDIContenedor.Btn_ResumenDiario.Visible = True
                                MDIContenedor.Refresh()

                                'Cursor.
                                Me.Cursor = Cursors.Arrow

                                MessageBox.Show("La caja diaria ha sido cerrada correctamente.", "Resumen Diario", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            ElseIf Resultado = 3 Then
                                Me.Cursor = Cursors.Arrow
                                MessageBox.Show("Ya existe un cierre de caja para la fecha de hoy.", "Resumen Diario", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Else
                                Me.Cursor = Cursors.Arrow
                                Btn_Abrir.Enabled = False
                                Btn_Cerrar.Enabled = True
                                MessageBox.Show("La caja no ha podido ser cerrada." & vbCrLf & "Por favor, Comuniquese con el administrador.", "Resumen Diario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            End If
                        End If
                    Catch ex As Exception
                        Me.Cursor = Cursors.Arrow
                        MessageBox.Show("Se ha encontrado un error al cerrar la caja." & vbCrLf & "Por favor, Comuniquese con el administrador.", "Resumen Diario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End Try
                End If
            End If
        End If
    End Sub

    'Boton que procesa al apertura de caja.
    Private Sub Btn_Abrir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Abrir.Click
        If MessageBox.Show("Está seguro que desea abrir la caja diaria?", "Resumen Diario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If MessageBox.Show("Realmente está seguro que desea abrir la caja diaria?" & vbCrLf & "Éste proceso debe llevarse a cabo solamente al iniciar el día", "Resumen Diario", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                Try
                    Me.Cursor = Cursors.WaitCursor

                    Dim Resultado As Integer = 0
                    Resultado = NegCaja.AbrirCaja(id_Sucursal, Now.Date.ToString("yyyy/MM/dd"))
                    If Resultado = 1 Then
                        Me.Cursor = Cursors.Arrow

                        'Muestro los menus.
                        MDIContenedor.MenuAccesosRapidos.Visible = True
                        MDIContenedor.ToolsMenu.Visible = True
                        MDIContenedor.SeguridadToolStripMenuItem.Visible = True
                        MDIContenedor.Btn_SincronizacionMenu.Visible = True
                        MDIContenedor.BackgroundImageLayout = ImageLayout.Stretch
                        MDIContenedor.Btn_ResumenDiario.Visible = False
                        MDIContenedor.Refresh()

                        MessageBox.Show("La caja diaria ha sido abierta correctamente.", "Resumen Diario", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        Me.Cursor = Cursors.Arrow
                        MessageBox.Show("No ha podido ser abierta la caja diaria.", "Resumen Diario", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                    ObtenerDatos("SI")
                Catch ex As Exception
                    Me.Cursor = Cursors.Arrow
                    MessageBox.Show("Se ha encontrado un error al abrir la caja." & vbCrLf & "Por favor, Comuniquese con el administrador.", "Resumen Diario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End Try
            End If
        End If
    End Sub

End Class