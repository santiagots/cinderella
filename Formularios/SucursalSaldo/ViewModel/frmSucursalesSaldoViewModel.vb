Imports System.ComponentModel
Imports System.Threading.Tasks
Imports SistemaCinderella.Comunes
Imports SistemaCinderella.Formularios.MovimientoDetalle
Imports MovimientoDetalle = SistemaCinderella.Formularios.MovimientoDetalle
Imports ModelVenta = Ventas.Core.Model.VentaAggregate
Imports Common.Core.Enum
Imports Ventas.Core.Model.ValueObjects
Imports Ventas.Core.Model.VentaAggregate
Imports Ventas.Core.Enum

Namespace Formularios.SucursalSaldo

    Public Class frmSucursalesSaldoViewModel
        Inherits Comunes.Common

        Private NegDev As New Negocio.NegDevolucion
        Private NegMov As New Negocio.NegMovimientos
        Private NegEmp As New Negocio.NegEmpleados
        Private NegAdel As New Negocio.NegAdelantos
        Private IdSucursal As Integer

        Public Property Sucursal As String
        Public Property FechaDesde As Date
        Public Property FechaHasta As Date
        Public Property TotalEgresos As Decimal
        Public Property TotalIngreso As Decimal
        Public Property TotalCajaFuerte As Decimal
        Public Property Saldo As Decimal
        Public Property Disponible As Decimal
        Public Property Saldos As SaldoSucursalViewModel

        Sub New(idSucursal As Integer, nombreSucursal As String)
            Me.IdSucursal = idSucursal
            Me.Sucursal = nombreSucursal

            FechaDesde = DateTime.Now.AddMonths(-1)
            FechaHasta = DateTime.Now
            Saldos = New SaldoSucursalViewModel()
        End Sub

        Public Async Function CargarSaldoAsync() As Task
            Dim Saldo As Task(Of Ventas.Core.Model.ValueObjects.SucursalSaldo) = Task.Run(Function() Formularios.SucursalSaldo.Servicio.CargarSaldoAsync(IdSucursal, FechaHasta))

            Await Task.WhenAll(CargarResumenVentaAsync(), Saldo)

            CargarIngresos()
            CargarEgresos()

            Me.Saldo = Saldo.Result.Total
            Me.Disponible = Saldo.Result.Disponible
            Me.TotalCajaFuerte = Saldo.Result.TotalCajaFuerte

            NotifyPropertyChanged(NameOf(Me.Saldo))
            NotifyPropertyChanged(NameOf(Me.Disponible))
        End Function

        Friend Async Function LimpiarAsync() As Task
            FechaDesde = DateTime.Now.AddMonths(-1)
            FechaHasta = DateTime.Now
            Await CargarSaldoAsync()
        End Function

        Public Async Function MostrarDevolucionesAsyn() As Task
            Dim devoluciones As List(Of MovimientoDetalle.MovimientoDevolucion) = Await Task.Run(Function() MovimientoDetalle.Servicio.ObtenerDevoluciones(IdSucursal, FechaDesde, FechaHasta))
            Dim titulo As String = $"Devoluciones registradas entre el { FechaDesde.ToShortDateString() } hasta el { FechaHasta.ToShortDateString() }"
            MostrarMovimiento(titulo, devoluciones)
        End Function

        Public Async Function MostrarSueldosAsyn() As Task
            Dim sueldos As List(Of MovimientoDetalle.MovimientoSueldo) = Await Task.Run(Function() MovimientoDetalle.Servicio.ObtenerSueldos(IdSucursal, FechaDesde, FechaHasta))
            Dim titulo As String = $"Sueldos registrados entre el { FechaDesde.ToShortDateString() } hasta el { FechaHasta.ToShortDateString() }"
            MostrarMovimiento(titulo, sueldos)
        End Function

        Public Async Function MostrarGastosAsyn() As Task
            Dim gastos As List(Of MovimientoDetalle.MovimientoGasto) = Await Task.Run(Function() MovimientoDetalle.Servicio.ObtenerGastos(IdSucursal, FechaDesde, FechaHasta))
            Dim titulo As String = $"Gastos registrados entre el { FechaDesde.ToShortDateString() } hasta el { FechaHasta.ToShortDateString() }"
            MostrarMovimiento(titulo, gastos)
        End Function

        Public Async Function MostrarImpuestosAsyn() As Task
            Dim impuesto As List(Of MovimientoDetalle.MovimientoImpuesto) = Await Task.Run(Function() MovimientoDetalle.Servicio.ObtenerImpuestos(IdSucursal, FechaDesde, FechaHasta))
            Dim titulo As String = $"Impuestos registrados entre el { FechaDesde.ToShortDateString() } hasta el { FechaHasta.ToShortDateString() }"
            MostrarMovimiento(titulo, impuesto)
        End Function

        Friend Async Function MostrarPendienteAutorizacionEgresosAsync() As Task
            Dim pendienteAutorizacion As List(Of MovimientoDetalle.MovimientoEgreso) = Await Task.Run(Function() MovimientoDetalle.Servicio.ObtenerEgresos(IdSucursal, FechaDesde, FechaHasta, "EgresosPendientes"))
            Dim titulo As String = $"Egresos registrados entre el { FechaDesde.ToShortDateString() } hasta el { FechaHasta.ToShortDateString() }"
            MostrarMovimiento(titulo, pendienteAutorizacion)
        End Function

        Public Async Function MostrarEfectivoEgresosAsyn() As Task
            Dim efectivoEgresos As List(Of MovimientoDetalle.MovimientoEgreso) = Await Task.Run(Function() MovimientoDetalle.Servicio.ObtenerEgresos(IdSucursal, FechaDesde, FechaHasta, "Egresos"))
            Dim titulo As String = $"Egresos registrados entre el { FechaDesde.ToShortDateString() } hasta el { FechaHasta.ToShortDateString() }"
            MostrarMovimiento(titulo, efectivoEgresos)
        End Function

        Friend Async Function MostrarTotalVentaAsync() As Task
            Dim efectivoEgresos As List(Of MovimientoDetalle.MovimientoVenta) = Await Task.Run(Function() MovimientoDetalle.Servicio.ObtenerVenta(IdSucursal, FechaDesde, FechaHasta, Nothing, Nothing, Nothing))
            Dim titulo As String = $"Ventas registradas entre el { FechaDesde.ToShortDateString() } hasta el { FechaHasta.ToShortDateString() }"
            MostrarMovimiento(titulo, efectivoEgresos)
        End Function

        Friend Async Function MostrarTotalVentaEfectivoAsync() As Task
            Dim efectivoEgresos As List(Of MovimientoDetalle.MovimientoVenta) = Await Task.Run(Function() MovimientoDetalle.Servicio.ObtenerVenta(IdSucursal, FechaDesde, FechaHasta, Nothing, TipoPago.Efectivo, Nothing))
            Dim titulo As String = $"Ventas en efectivo registradas entre el { FechaDesde.ToShortDateString() } hasta el { FechaHasta.ToShortDateString() }"
            MostrarMovimiento(titulo, efectivoEgresos)
        End Function

        Friend Async Function MostrarTotalVentaChequeAsync() As Task
            Dim efectivoEgresos As List(Of MovimientoDetalle.MovimientoVenta) = Await Task.Run(Function() MovimientoDetalle.Servicio.ObtenerVenta(IdSucursal, FechaDesde, FechaHasta, Nothing, TipoPago.Cheque, Nothing))
            Dim titulo As String = $"Ventas en cheque registradas entre el { FechaDesde.ToShortDateString() } hasta el { FechaHasta.ToShortDateString() }"
            MostrarMovimiento(titulo, efectivoEgresos)
        End Function

        Friend Async Function MostrarTotalVentaDepositoAsync() As Task
            Dim efectivoEgresos As List(Of MovimientoDetalle.MovimientoVenta) = Await Task.Run(Function() MovimientoDetalle.Servicio.ObtenerVenta(IdSucursal, FechaDesde, FechaHasta, Nothing, TipoPago.Deposito, Nothing))
            Dim titulo As String = $"Ventas en deposito registradas entre el { FechaDesde.ToShortDateString() } hasta el { FechaHasta.ToShortDateString() }"
            MostrarMovimiento(titulo, efectivoEgresos)
        End Function

        Friend Async Function MostrarTotalVentaTarjetaCreditoAsync() As Task
            Dim efectivoEgresos As List(Of MovimientoDetalle.MovimientoVenta) = Await Task.Run(Function() MovimientoDetalle.Servicio.ObtenerVenta(IdSucursal, FechaDesde, FechaHasta, Nothing, TipoPago.TarjetaCrédito, Nothing))
            Dim titulo As String = $"Ventas en tarjeta crédito registradas entre el { FechaDesde.ToShortDateString() } hasta el { FechaHasta.ToShortDateString() }"
            MostrarMovimiento(titulo, efectivoEgresos)
        End Function

        Friend Async Function MostrarTotalVentaTarjetaDebitoAsync() As Task
            Dim efectivoEgresos As List(Of MovimientoDetalle.MovimientoVenta) = Await Task.Run(Function() MovimientoDetalle.Servicio.ObtenerVenta(IdSucursal, FechaDesde, FechaHasta, Nothing, TipoPago.TarjetaDébito, Nothing))
            Dim titulo As String = $"Ventas en tarjeta debito registradas entre el { FechaDesde.ToShortDateString() } hasta el { FechaHasta.ToShortDateString() }"
            MostrarMovimiento(titulo, efectivoEgresos)
        End Function

        Friend Async Function MostrarTotalVentaFacturadoAsync() As Task
            Dim efectivoEgresos As List(Of MovimientoDetalle.MovimientoVenta) = Await Task.Run(Function() MovimientoDetalle.Servicio.ObtenerVenta(IdSucursal, FechaDesde, FechaHasta, True, Nothing, Nothing))
            Dim titulo As String = $"Ventas en tarjeta debito registradas entre el { FechaDesde.ToShortDateString() } hasta el { FechaHasta.ToShortDateString() }"
            MostrarMovimiento(titulo, efectivoEgresos)
        End Function

        Friend Async Function MostrarTotalVentaMayoristaAsync() As Task
            Dim efectivoEgresos As List(Of MovimientoDetalle.MovimientoVenta) = Await Task.Run(Function() MovimientoDetalle.Servicio.ObtenerVenta(IdSucursal, FechaDesde, FechaHasta, Nothing, Nothing, TipoCliente.Mayorista))
            Dim titulo As String = $"Ventas mayoristas registradas entre el { FechaDesde.ToShortDateString() } hasta el { FechaHasta.ToShortDateString() }"
            MostrarMovimiento(titulo, efectivoEgresos)
        End Function

        Friend Async Function MostrarTotalVentaMinoristaAsync() As Task
            Dim efectivoEgresos As List(Of MovimientoDetalle.MovimientoVenta) = Await Task.Run(Function() MovimientoDetalle.Servicio.ObtenerVenta(IdSucursal, FechaDesde, FechaHasta, Nothing, Nothing, TipoCliente.Minorista))
            Dim titulo As String = $"Ventas minorista registradas entre el { FechaDesde.ToShortDateString() } hasta el { FechaHasta.ToShortDateString() }"
            MostrarMovimiento(titulo, efectivoEgresos)
        End Function

        Friend Async Function MostrarFaltanteCajaAsync() As Task
            Dim efectivoEgresos As List(Of MovimientoDetalle.MovimientoCaja) = Await Task.Run(Function() MovimientoDetalle.Servicio.ObtenerMovimientoCaja(IdSucursal, FechaDesde, FechaHasta, Ventas.Core.Enum.CierreCajaSituacion.FaltanteDinero))
            Dim titulo As String = $"Faltante de caja registradas entre el { FechaDesde.ToShortDateString() } hasta el { FechaHasta.ToShortDateString() }"
            MostrarMovimiento(titulo, efectivoEgresos)
        End Function

        Friend Async Function MostrarIngresoCajaFuerteAsync() As Task
            Dim movimientoCajaFuerte As List(Of MovimientoDetalle.MovimientoCajaFuerte) = Await Task.Run(Function() MovimientoDetalle.Servicio.ObtenerIngresoCajaFuerte(IdSucursal, FechaDesde, FechaHasta, 2))
            Dim titulo As String = $"Ingresos de caja fuerte registrados entre el { FechaDesde.ToShortDateString() } hasta el { FechaHasta.ToShortDateString() }"
            MostrarMovimiento(titulo, movimientoCajaFuerte)
        End Function

        Friend Async Function MostrarEgresoCajaFuerteAsync() As Task
            Dim movimientoCajaFuerte As List(Of MovimientoDetalle.MovimientoCajaFuerte) = Await Task.Run(Function() MovimientoDetalle.Servicio.ObtenerIngresoCajaFuerte(IdSucursal, FechaDesde, FechaHasta, 1))
            Dim titulo As String = $"Egreso de caja fuerte registrados entre el { FechaDesde.ToShortDateString() } hasta el { FechaHasta.ToShortDateString() }"
            MostrarMovimiento(titulo, movimientoCajaFuerte)
        End Function

        Friend Async Function MostrarRetiroSocioAsync() As Task
            Dim efectivoEgresos As List(Of MovimientoDetalle.MovimientoSocio) = Await Task.Run(Function() MovimientoDetalle.Servicio.ObtenerRetiroSocio(IdSucursal, FechaDesde, FechaHasta))
            Dim titulo As String = $"Retiros de socios registrados entre el { FechaDesde.ToShortDateString() } hasta el { FechaHasta.ToShortDateString() }"
            MostrarMovimiento(titulo, efectivoEgresos)
        End Function

        Public Async Function MostrarEfectivoIngresoAsyn() As Task
            Dim efectivoEgresos As List(Of MovimientoDetalle.MovimientoEgreso) = Await Task.Run(Function() MovimientoDetalle.Servicio.ObtenerEgresos(IdSucursal, FechaDesde, FechaHasta, "Ingresos"))
            Dim titulo As String = $"Ingresos registrados entre el { FechaDesde.ToShortDateString() } hasta el { FechaHasta.ToShortDateString() }"
            MostrarMovimiento(titulo, efectivoEgresos)
        End Function

        Friend Async Function MostrarSobranteCajaAsync() As Task
            Dim efectivoEgresos As List(Of MovimientoDetalle.MovimientoCaja) = Await Task.Run(Function() MovimientoDetalle.Servicio.ObtenerMovimientoCaja(IdSucursal, FechaDesde, FechaHasta, Ventas.Core.Enum.CierreCajaSituacion.SobranteDinero))
            Dim titulo As String = $"Sobrante de caja registrados entre el { FechaDesde.ToShortDateString() } hasta el { FechaHasta.ToShortDateString() }"
            MostrarMovimiento(titulo, efectivoEgresos)
        End Function

        Friend Async Function MostrarAporteSocioAsync() As Task
            Dim efectivoEgresos As List(Of MovimientoDetalle.MovimientoSocio) = Await Task.Run(Function() MovimientoDetalle.Servicio.ObtenerAporteSocio(IdSucursal, FechaDesde, FechaHasta))
            Dim titulo As String = $"Aporte de socios registrados entre el { FechaDesde.ToShortDateString() } hasta el { FechaHasta.ToShortDateString() }"
            MostrarMovimiento(titulo, efectivoEgresos)
        End Function

        Private Sub MostrarMovimiento(Of T)(titulo As String, movimientos As List(Of T))
            Dim frmMoviminetoDetalleViewModel = New frmMoviminetoDetalleViewModel(Of T)(titulo, New BindingList(Of T)(movimientos))
            Dim frmMoviminetoDetalle As frmMoviminetoDetalle(Of T) = New frmMoviminetoDetalle(Of T)(frmMoviminetoDetalleViewModel)
            frmMoviminetoDetalle.ShowDialog()
        End Sub

        Private Async Function CargarResumenVentaAsync() As Task
            Dim efectivo As Task(Of Decimal) = Task.Run(Function() Venta.Servicio.ObtenerTotalVentas(IdSucursal, FechaDesde, FechaHasta, Nothing, TipoPago.Efectivo, Nothing))
            Dim cheques As Task(Of Decimal) = Task.Run(Function() Venta.Servicio.ObtenerTotalVentas(IdSucursal, FechaDesde, FechaHasta, Nothing, TipoPago.Cheque, Nothing))
            Dim credito As Task(Of Decimal) = Task.Run(Function() Venta.Servicio.ObtenerTotalVentas(IdSucursal, FechaDesde, FechaHasta, Nothing, TipoPago.TarjetaCrédito, Nothing))
            Dim debito As Task(Of Decimal) = Task.Run(Function() Venta.Servicio.ObtenerTotalVentas(IdSucursal, FechaDesde, FechaHasta, Nothing, TipoPago.TarjetaDébito, Nothing))
            Dim deposito As Task(Of Decimal) = Task.Run(Function() Venta.Servicio.ObtenerTotalVentas(IdSucursal, FechaDesde, FechaHasta, Nothing, TipoPago.Deposito, Nothing))
            Dim facturado As Task(Of Decimal) = Task.Run(Function() Venta.Servicio.ObtenerTotalVentas(IdSucursal, FechaDesde, FechaHasta, True, Nothing, Nothing))
            Dim sinFacturar As Task(Of Decimal) = Task.Run(Function() Venta.Servicio.ObtenerTotalVentas(IdSucursal, FechaDesde, FechaHasta, False, Nothing, Nothing))
            Dim minorista As Task(Of Decimal) = Task.Run(Function() Venta.Servicio.ObtenerTotalVentas(IdSucursal, FechaDesde, FechaHasta, Nothing, Nothing, TipoCliente.Minorista))
            Dim mayorista As Task(Of Decimal) = Task.Run(Function() Venta.Servicio.ObtenerTotalVentas(IdSucursal, FechaDesde, FechaHasta, Nothing, Nothing, TipoCliente.Mayorista))
            Dim total As Task(Of Decimal) = Task.Run(Function() Venta.Servicio.ObtenerTotalVentas(IdSucursal, FechaDesde, FechaHasta, Nothing, Nothing, Nothing))

            Await Task.WhenAll(efectivo, cheques, credito, credito, minorista, mayorista, facturado, sinFacturar, total)

            Saldos.VentaEfectivo = efectivo.Result
            Saldos.VentaCheque = cheques.Result
            Saldos.VentaCredito = credito.Result
            Saldos.VentaDeposito = deposito.Result
            Saldos.VentaDebito = debito.Result
            Saldos.VentaFacturado = facturado.Result
            Saldos.VentaSinFacturar = sinFacturar.Result
            Saldos.VentaMinorista = minorista.Result
            Saldos.VentaMayorista = mayorista.Result
        End Function

        Private Sub CargarIngresos()
            Dim recibidosSucursal As Decimal = NegMov.ObtenerTotalMovEgreso(IdSucursal, FechaDesde.ToString("yyyy/MM/dd"), FechaHasta.ToString("yyyy/MM/dd"), "Ingresos")
            Dim egresoCajaFuerte As Decimal = NegMov.ObtenerTotalMovCajaFuerte(IdSucursal, FechaDesde.ToString("yyyy/MM/dd"), FechaHasta.ToString("yyyy/MM/dd"), 1)
            Dim aporteSocios As Decimal = NegMov.TotalMovAporte(IdSucursal, FechaDesde.ToString("yyyy/MM/dd"), FechaHasta.ToString("yyyy/MM/dd"))
            Dim ventaTotal As Decimal = Venta.Servicio.ObtenerTotalVentas(IdSucursal, FechaDesde, FechaHasta, Nothing, Nothing, Nothing)
            Dim cierreCajaAnterior As CierreCaja = Servicio.ObtenerCierreCaja(IdSucursal, FechaHasta.AddDays(-1))
            Dim sobranteCaja As Decimal = Servicio.ObtenerTotalDiferenciaCierreCaja(IdSucursal, FechaDesde, FechaHasta, CierreCajaSituacion.SobranteDinero)

            Dim cajaInicial As Decimal = If(cierreCajaAnterior = Nothing, 0, cierreCajaAnterior.Monto)

            Saldos.VentaTotal = ventaTotal
            Saldos.CajaInical = cajaInicial
            Saldos.RecibidosSucursal = recibidosSucursal
            Saldos.SobranteCaja = sobranteCaja
            Saldos.EgresoCajaFuerte = egresoCajaFuerte
            Saldos.AporteSocios = aporteSocios

            TotalIngreso = ventaTotal + recibidosSucursal + sobranteCaja + egresoCajaFuerte + aporteSocios

            NotifyPropertyChanged(NameOf(Me.TotalIngreso))
        End Sub

        Private Sub CargarEgresos()
            Dim devoluciones As Decimal = CType(NegDev.TotalDevolucionesEfectivo(IdSucursal, FechaDesde.ToString("yyyy/MM/dd"), FechaHasta.ToString("yyyy/MM/dd")), Decimal)
            Dim mercaderia As Decimal = CType(NegMov.ConsultarTotalGastoMercaderia(IdSucursal, FechaDesde.ToString("yyyy/MM/dd"), FechaHasta.ToString("yyyy/MM/dd")), Decimal)
            Dim sueldos As Decimal = CType(NegEmp.ObtenerSueldosSucursal(IdSucursal, FechaDesde.ToString("yyyy/MM/dd"), FechaHasta.ToString("yyyy/MM/dd")), Decimal)
            Dim sueldosAdelantos As Decimal = CType(NegAdel.ObtenerAdelantosSucursal(IdSucursal, FechaDesde.ToString("yyyy/MM/dd"), FechaHasta.ToString("yyyy/MM/dd")), Decimal)
            Dim gastosEgresos As Decimal = CType(NegMov.TotalMovEgresosGastos(IdSucursal, FechaDesde.ToString("yyyy/MM/dd"), FechaHasta.ToString("yyyy/MM/dd")), Decimal)
            Dim gastosMovimientos As Decimal = CType(NegMov.TotalMovGastos(IdSucursal, FechaDesde.ToString("yyyy/MM/dd"), FechaHasta.ToString("yyyy/MM/dd")), Decimal)
            Dim impuestosEgresos As Decimal = CType(NegMov.TotalMovEgresosImpuesto(IdSucursal, FechaDesde.ToString("yyyy/MM/dd"), FechaHasta.ToString("yyyy/MM/dd")), Decimal)
            Dim impuestosMovimientos As Decimal = CType(NegMov.TotalMovImpuesto(IdSucursal, FechaDesde.ToString("yyyy/MM/dd"), FechaHasta.ToString("yyyy/MM/dd")), Decimal)
            Dim enviosSucursales As Decimal = CType(NegMov.ObtenerTotalMovEgreso(IdSucursal, FechaDesde.ToString("yyyy/MM/dd"), FechaHasta.ToString("yyyy/MM/dd"), "Egresos"), Decimal)
            Dim pendienteAutorizacion As Decimal = CType(NegMov.ObtenerTotalMovEgreso(IdSucursal, FechaDesde.ToString("yyyy/MM/dd"), FechaHasta.ToString("yyyy/MM/dd"), "EgresosPendientes"), Decimal)
            Dim ingresosCajaFuerte As Decimal = CType(NegMov.ObtenerTotalMovCajaFuerte(IdSucursal, FechaDesde.ToString("yyyy/MM/dd"), FechaHasta.ToString("yyyy/MM/dd"), 2), Decimal)
            Dim retiroSocios As Decimal = CType(NegMov.TotalMovRetiro(IdSucursal, FechaDesde.ToString("yyyy/MM/dd"), FechaHasta.ToString("yyyy/MM/dd")), Decimal)
            Dim faltanteCaja As Decimal = Servicio.ObtenerTotalDiferenciaCierreCaja(IdSucursal, FechaDesde, FechaHasta, CierreCajaSituacion.FaltanteDinero)

            Saldos.Devoluciones = devoluciones
            Saldos.Mercaderia = mercaderia
            Saldos.Sueldos = sueldos + sueldosAdelantos
            Saldos.Gastos = gastosEgresos + gastosMovimientos
            Saldos.Impuestos = impuestosEgresos + impuestosMovimientos
            Saldos.EnviosSucursales = enviosSucursales
            Saldos.PendienteAutorizacion = pendienteAutorizacion
            Saldos.FaltanteCaja = Math.Abs(faltanteCaja)
            Saldos.IngresosCajaFuerte = ingresosCajaFuerte
            Saldos.RetiroSocios = retiroSocios

            TotalEgresos = devoluciones + mercaderia + sueldos + sueldosAdelantos + gastosEgresos + gastosMovimientos + impuestosEgresos + impuestosMovimientos + enviosSucursales + faltanteCaja + ingresosCajaFuerte + retiroSocios

            NotifyPropertyChanged(NameOf(Me.TotalEgresos))
        End Sub

    End Class
End Namespace
