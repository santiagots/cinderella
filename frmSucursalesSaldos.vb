Public Class frmSucursalesSaldos
    Dim fuc As New Funciones
    Dim id_Sucursal As String
    Dim FDesde As String
    Dim FHasta As String
    Dim NegMov As New Negocio.NegMovimientos
    Dim NegAdel As New Negocio.NegAdelantos
    Dim NegAdic As New Negocio.NegAdicionales
    Dim NegVen As New Negocio.NegVentas
    Dim NegEmp As New Negocio.NegEmpleados
    Dim Funciones As New Funciones

    'Cuando se carga el formulario.
    Private Sub frmSucursalesSaldos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Cambio el cursor a "WAIT"
        Me.Cursor = Cursors.WaitCursor

        'Sucursal default
        lblSucursalNombre.Text = My.Settings("NombreSucursal")
        id_Sucursal = My.Settings("Sucursal")

        'Seteo de Formulario.
        LimpiarForm()
        'Cambio el cursor a "NORMAL"
        Me.Cursor = Cursors.Arrow
    End Sub

    'Cuando hace click en el boton buscar.
    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Buscar.Click
        Try
            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            'Empieza a cargar.
            GbDetalle.Visible = False
            GbDetalleVenta.Visible = False

            'Declaracion de Variables
            Dim Ingresos As Double = 0
            Dim Egresos As Double = 0

            Dim Ventas As Double = 0
            Dim VentasMinorista As Double = 0
            Dim VentasMayorista As Double = 0
            Dim VentasEfectivo As Double = 0
            Dim VentasCheque As Double = 0
            Dim VentasCredito As Double = 0
            Dim VentasDebito As Double = 0
            Dim VentasFacturado As Double = 0
            Dim Sobrante As Double = 0
            Dim EfectivoIngreso As Double = 0
            Dim Mercaderias As Double = 0

            Dim DevolucionEgreso As Double = 0
            Dim Adelantos As Double = 0
            Dim Sueldo As Double = 0
            Dim Impuesto As Double = 0
            Dim Faltante As Double = 0
            Dim Gasto As Double = 0
            Dim Retiro As Double = 0
            Dim Aporte As Double = 0
            Dim EfectivoEgreso As Double = 0
            Dim PendienteAutorizar As Double = 0
            Dim Saldo As Double = 0

            '--------OBTENGO LOS DATOS-------'
            FDesde = txt_FDesde.Value.ToString("yyyy/MM/dd")
            FHasta = txt_FHasta.Value.ToString("yyyy/MM/dd")

            '---------INGRESOS---------------'
            'obtengo las ventas de la sucursal.
            Ventas = NegVen.ObtenerVentasSucursal(id_Sucursal, FDesde, FHasta)
            VentasMinorista = NegVen.ObtenerVentasSucursalMinoristas(id_Sucursal, FDesde, FHasta)
            VentasMayorista = NegVen.ObtenerVentasSucursalMayoristas(id_Sucursal, FDesde, FHasta)
            VentasEfectivo = NegVen.ObtenerVentasSucursalEfectivo(id_Sucursal, FDesde, FHasta)
            VentasCredito = NegVen.ObtenerVentasSucursalCredito(id_Sucursal, FDesde, FHasta)
            VentasDebito = NegVen.ObtenerVentasSucursalDebito(id_Sucursal, FDesde, FHasta)
            VentasCheque = NegVen.ObtenerVentasSucursalCheque(id_Sucursal, FDesde, FHasta)
            VentasFacturado = NegVen.ObtenerVentasSucursalFacturado(id_Sucursal, FDesde, FHasta)
            Sobrante = NegMov.ObtenerTotalMovCaja(id_Sucursal, FDesde, FHasta, "Sobrante")
            EfectivoIngreso = NegMov.ObtenerTotalMovEgreso(id_Sucursal, FDesde, FHasta, "Ingresos")
            Aporte = NegMov.ConsultarTotalMovimiento(id_Sucursal, FDesde, FHasta, 6)
            Ingresos = Ventas + Sobrante + EfectivoIngreso + Aporte

            '----------EGRESOS---------------'
            DevolucionEgreso = NegMov.ObtenerTotalMovEgreso(id_Sucursal, FDesde, FHasta, "Devolucion")
            Adelantos = NegAdel.ObtenerAdelantosSucursal(id_Sucursal, FDesde, FHasta)
            Sueldo = NegEmp.ObtenerSueldosSucursal(id_Sucursal, FDesde, FHasta)
            Impuesto = NegMov.ConsultarTotalMovimiento(id_Sucursal, FDesde, FHasta, 3)
            Gasto = NegMov.ConsultarTotalMovimiento(id_Sucursal, FDesde, FHasta, 1)
            Retiro = NegMov.ConsultarTotalMovimiento(id_Sucursal, FDesde, FHasta, 5)
            Faltante = NegMov.ObtenerTotalMovCaja(id_Sucursal, FDesde, FHasta, "Faltante")
            EfectivoEgreso = NegMov.ObtenerTotalMovEgreso(id_Sucursal, FDesde, FHasta, "Egresos")
            PendienteAutorizar = NegMov.ObtenerTotalMovEgreso(id_Sucursal, FDesde, FHasta, "EgresosPendientes")
            Mercaderias = NegMov.ConsultarTotalGastoMercaderia(id_Sucursal, FDesde, FHasta)

            Egresos = Adelantos + DevolucionEgreso + Sueldo + Impuesto + Faltante + Gasto + Retiro + EfectivoEgreso + Mercaderias

            '------------SALDO---------------'
            Saldo = NegMov.ConsultaSaldo(id_Sucursal, FHasta)


            '------------DISPONIBLE TOTAL---------------'
            Dim CajaFuerteTotal As Double = 0
            CajaFuerteTotal = NegMov.ConsultarTotalCajaFuerte(id_Sucursal, FHasta)

            Dim DisponibleTotal As Double = 0
            DisponibleTotal = Saldo + CajaFuerteTotal
            lbl_DisponibleTotal.Text = "$ " & Format(CType((DisponibleTotal), Decimal), "###0.00") & ".-"

            '--------ASIGNO LOS RESULT-------'
            txt_Venta.Text = "$ " & Format(CType((Ventas), Decimal), "###0.00") & ".-"
            txt_VentaMinorista.Text = "$ " & Format(CType((VentasMinorista), Decimal), "###0.00") & ".-"
            txt_VentaMayorista.Text = "$ " & Format(CType((VentasMayorista), Decimal), "###0.00") & ".-"
            txt_VentasEfectivo.Text = "$ " & Format(CType((VentasEfectivo), Decimal), "###0.00") & ".-"
            txt_VentasCredito.Text = "$ " & Format(CType((VentasCredito), Decimal), "###0.00") & ".-"
            txt_VentasCheque.Text = "$ " & Format(CType((VentasCheque), Decimal), "###0.00") & ".-"
            txt_VentasDebito.Text = "$ " & Format(CType((VentasDebito), Decimal), "###0.00") & ".-"
            txt_VentasFacturado.Text = "$ " & Format(CType((VentasFacturado), Decimal), "###0.00") & ".-"
            txt_Sobrante.Text = "$ " & Format(CType((Sobrante), Decimal), "###0.00") & ".-"
            txt_Efectivo.Text = "$ " & Format(CType((EfectivoIngreso), Decimal), "###0.00") & ".-"
            txt_DevolucionesEgr.Text = "$ " & Format(CType((DevolucionEgreso), Decimal), "###0.00") & ".-"
            txt_Sueldo.Text = "$ " & Format(CType((Sueldo + Adelantos), Decimal), "###0.00") & ".-"
            txt_Impuesto.Text = "$ " & Format(CType((Impuesto), Decimal), "###0.00") & ".-"
            txt_Faltante.Text = "$ " & Format(CType((Faltante), Decimal), "###0.00") & ".-"
            txt_Gasto.Text = "$ " & Format(CType((Gasto), Decimal), "###0.00") & ".-"
            txt_Retiro.Text = "$ " & Format(CType((Retiro), Decimal), "###0.00") & ".-"
            txt_EfectivoEgreso.Text = "$ " & Format(CType((EfectivoEgreso), Decimal), "###0.00") & ".-"
            txt_PendienteAutorizar.Text = "$ " & Format(CType((PendienteAutorizar), Decimal), "###0.00") & ".-"
            txt_Mercaderias.Text = "$ " & Format(CType((Mercaderias), Decimal), "###0.00") & ".-"
            txt_Aporte.Text = "$ " & Format(CType((Aporte), Decimal), "###0.00") & ".-"
            lbl_Saldo.Text = "$ " & Format(CType((Saldo), Decimal), "###0.00") & ".-"
            lbl_TotalIngresos.Text = "$ " & Format(CType((Ingresos), Decimal), "###0.00") & ".-"
            lbl_TotalEgresos.Text = "$ " & Format(CType((Egresos), Decimal), "###0.00") & ".-"

            If Saldo < 0 Then
                lbl_Saldo.ForeColor = Color.Red
            Else
                lbl_Saldo.ForeColor = Color.Green
            End If

            If DisponibleTotal < 0 Then
                lbl_DisponibleTotal.ForeColor = Color.Red
            Else
                lbl_DisponibleTotal.ForeColor = Color.Green
            End If


            '--------MUESTRO EL GBDET--------'
            Me.Height = 600
            Me.Refresh()
            Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
            Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
            GbDetalle.Visible = True
            GbDetalleVenta.Visible = True

            'Cambio el cursor a "NORMAL"
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha encontrado un error al consultar los movimientos de la sucursal. Por favor, intente más tarde.", "Estado de Cuenta de la Sucursal " & My.Settings.NombreSucursal, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub

    Private Sub Btn_Limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Limpiar.Click
        LimpiarForm()
    End Sub

    Sub LimpiarForm()
        txt_Efectivo.Clear()
        txt_Faltante.Clear()
        txt_Gasto.Clear()
        txt_Impuesto.Clear()
        txt_Retiro.Clear()
        txt_Sobrante.Clear()
        txt_Sueldo.Clear()
        txt_Venta.Clear()
        txt_FDesde.Value = Today.AddMonths(-1)
        txt_FHasta.Value = Today

        Me.Height = 200
        Me.Refresh()
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
        GbDetalle.Visible = False
        GbDetalleVenta.Visible = False
    End Sub

    Private Sub Btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Salir.Click
        Me.Close()
    End Sub

    'LINKS HECHOS
    'Link VENTAS.
    Private Sub BtnVentas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Venta.Click
        Me.Cursor = Cursors.WaitCursor
        frmVerVentas.id_Sucursal = id_Sucursal
        frmVerVentas.FDesde = FDesde
        frmVerVentas.FHasta = FHasta
        Funciones.ControlInstancia(frmVerVentas).MdiParent = MDIContenedor
        Funciones.ControlInstancia(frmVerVentas).Show()
        Me.Cursor = Cursors.Arrow
    End Sub

    'LINK IMPUESTOS.
    Private Sub Btn_Impuesto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Impuesto.Click
        Me.Cursor = Cursors.WaitCursor
        frmVerImpuestos.FDesde = FDesde
        frmVerImpuestos.FHasta = FHasta
        Funciones.ControlInstancia(frmVerImpuestos).MdiParent = MDIContenedor
        Funciones.ControlInstancia(frmVerImpuestos).Show()
        Me.Cursor = Cursors.Arrow
    End Sub

    'LINK GASTOS.
    Private Sub Btn_Gasto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Gasto.Click
        Me.Cursor = Cursors.WaitCursor
        frmVerGastos.FDesde = FDesde
        frmVerGastos.FHasta = FHasta
        Funciones.ControlInstancia(frmVerGastos).MdiParent = MDIContenedor
        Funciones.ControlInstancia(frmVerGastos).Show()
        Me.Cursor = Cursors.Arrow
    End Sub

    'LINK RETIROS.
    Private Sub Btn_Retiro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Retiro.Click
        Me.Cursor = Cursors.WaitCursor
        frmVerMovimientosSocios.FDesde = FDesde
        frmVerMovimientosSocios.FHasta = FHasta
        frmVerMovimientosSocios.tipoMovimiento = Entidades.MoviminetoSocios.Retiro
        Funciones.ControlInstancia(frmVerMovimientosSocios).MdiParent = MDIContenedor
        Funciones.ControlInstancia(frmVerMovimientosSocios).Show()
        Me.Cursor = Cursors.Arrow
    End Sub

    'LINK FALTANTES.
    Private Sub Btn_Faltante_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Faltante.Click
        Me.Cursor = Cursors.WaitCursor
        frmVerDifCaja.FDesde = FDesde
        frmVerDifCaja.FHasta = FHasta
        frmVerDifCaja.Tipo = 2
        Funciones.ControlInstancia(frmVerDifCaja).MdiParent = MDIContenedor
        Funciones.ControlInstancia(frmVerDifCaja).Show()
        Me.Cursor = Cursors.Arrow
    End Sub

    'LINK SOBRANTES.
    Private Sub Btn_Sobrante_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Sobrante.Click
        Me.Cursor = Cursors.WaitCursor
        frmVerDifCaja.FDesde = FDesde
        frmVerDifCaja.FHasta = FHasta
        frmVerDifCaja.Tipo = 3
        Funciones.ControlInstancia(frmVerDifCaja).MdiParent = MDIContenedor
        Funciones.ControlInstancia(frmVerDifCaja).Show()
        Me.Cursor = Cursors.Arrow
    End Sub

    'LINK EFECTIVOS EGRESO.
    Private Sub Btn_EfectivoEgreso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_EfectivoEgreso.Click
        Me.Cursor = Cursors.WaitCursor
        frmVerEfectivo.FDesde = FDesde
        frmVerEfectivo.FHasta = FHasta
        frmVerEfectivo.Tipo = "Egresos"
        Funciones.ControlInstancia(frmVerEfectivo).MdiParent = MDIContenedor
        Funciones.ControlInstancia(frmVerEfectivo).Show()
        Me.Cursor = Cursors.Arrow
    End Sub

    'LINK EFECTIVOS INGRESO.
    Private Sub Btn_EfectivoIngreso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_EfectivoIngreso.Click
        Me.Cursor = Cursors.WaitCursor
        frmVerEfectivo.FDesde = FDesde
        frmVerEfectivo.FHasta = FHasta
        frmVerEfectivo.Tipo = "Ingresos"
        Funciones.ControlInstancia(frmVerEfectivo).MdiParent = MDIContenedor
        Funciones.ControlInstancia(frmVerEfectivo).Show()
        Me.Cursor = Cursors.Arrow
    End Sub

    'LINK SUELDOS.
    Private Sub Btn_Sueldo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Sueldo.Click
        frmVerSueldosSucursal.id_Sucursal = id_Sucursal
        frmVerSueldosSucursal.FDesde = FDesde
        frmVerSueldosSucursal.FHasta = FHasta
        fuc.ControlInstancia(frmVerSueldosSucursal).MdiParent = MDIContenedor
        fuc.ControlInstancia(frmVerSueldosSucursal).Show()
        Me.Cursor = Cursors.Arrow
    End Sub

    'LINK ADICIONALES
    Private Sub Btn_Adicional_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Cursor = Cursors.WaitCursor
        frmVerAdicionalesSucursal.id_Sucursal = id_Sucursal
        frmVerAdicionalesSucursal.FDesde = FDesde
        frmVerAdicionalesSucursal.FHasta = FHasta
        Funciones.ControlInstancia(frmVerAdicionalesSucursal).MdiParent = MDIContenedor
        Funciones.ControlInstancia(frmVerAdicionalesSucursal).Show()
        Me.Cursor = Cursors.Arrow
    End Sub

    'LINK APORTE
    Private Sub Btn_Aporte_Click(sender As Object, e As EventArgs) Handles Btn_Aporte.Click
        Me.Cursor = Cursors.WaitCursor
        frmVerMovimientosSocios.FDesde = FDesde
        frmVerMovimientosSocios.FHasta = FHasta
        frmVerMovimientosSocios.tipoMovimiento = Entidades.MoviminetoSocios.Aporte
        Funciones.ControlInstancia(frmVerMovimientosSocios).MdiParent = MDIContenedor
        Funciones.ControlInstancia(frmVerMovimientosSocios).Show()
        Me.Cursor = Cursors.Arrow
    End Sub

    'LINK DEVOLUCIONES
    Private Sub Btn_Devoluciones_Click(sender As Object, e As EventArgs) Handles Btn_Devoluciones.Click
        Me.Cursor = Cursors.WaitCursor
        frmVerDevoluciones.id_Sucursal = id_Sucursal
        frmVerDevoluciones.FDesde = FDesde
        frmVerDevoluciones.FHasta = FHasta
        Funciones.ControlInstancia(frmVerDevoluciones).MdiParent = MDIContenedor
        Funciones.ControlInstancia(frmVerDevoluciones).Show()
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Me.Cursor = Cursors.WaitCursor
        frmVerEfectivo.FDesde = FDesde
        frmVerEfectivo.FHasta = FHasta
        frmVerEfectivo.Tipo = "EgresosPendientes"
        Funciones.ControlInstancia(frmVerEfectivo).MdiParent = MDIContenedor
        Funciones.ControlInstancia(frmVerEfectivo).Show()
        Me.Cursor = Cursors.Arrow
    End Sub
End Class