﻿Imports System.ComponentModel
Imports System.Threading.Tasks
Imports Common.Core.Enum
Imports SistemaCinderella.Comunes
Imports SistemaCinderella.Formularios.MovimientoDetalle
Imports Ventas.Core.Model.ValueObjects
Imports Ventas.Data.Service
Imports Model = Ventas.Core.Model.ValueObjects
Imports ventaModel = Ventas.Core.Model.VentaAggregate
Imports ctaCteModel = Ventas.Core.Model.CuentaCorrienteAggregate
Imports AutoMapper

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
            Dim Saldo As Model.SucursalSaldo = Await Task.Run(Function() Servicio.CargarSaldoAsync(IdSucursal, FechaDesde, FechaHasta))

            CargarResumenVentaAsync(Saldo.SucursalPagos)
            CargarIngresos(Saldo.Ingreso)
            CargarEgresos(Saldo.Egreso)

            Me.Saldo = Saldo.Total
            Me.Disponible = Saldo.Disponible
            Me.TotalCajaFuerte = Saldo.TotalCajaFuerte

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

        Friend Async Function MostrarTotalVentaMovimientoAsync(titulo As String, facturado As Boolean?, tipoPago As TipoPago?, tipoCliente As TipoCliente?) As Task
            Dim ventas As List(Of ventaModel.Venta) = Await VentaService.BuscarAsync(IdSucursal, FechaDesde, FechaHasta, facturado, tipoPago, tipoCliente)
            Dim documentosPago As List(Of ctaCteModel.DocumentoDePago) = Await DocumentoDePagoService.BuscarAsync(TipoBase.Local, IdSucursal, FechaDesde, FechaHasta, tipoPago)

            Dim ventasMovimiento As List(Of MovimientoVenta) = New List(Of MovimientoVenta)()
            ventasMovimiento.AddRange(Mapper.Map(Of List(Of MovimientoVenta))(ventas))
            ventasMovimiento.AddRange(Mapper.Map(Of List(Of MovimientoVenta))(documentosPago))

            MostrarMovimiento(titulo, ventasMovimiento)
        End Function

        Public Async Function MostrarEfectivoEgresosAsyn() As Task
            Dim efectivoEgresos As List(Of MovimientoDetalle.MovimientoEgreso) = Await Task.Run(Function() MovimientoDetalle.Servicio.ObtenerEgresos(IdSucursal, FechaDesde, FechaHasta, "Egresos"))
            Dim titulo As String = $"Egresos registrados entre el { FechaDesde.ToShortDateString() } hasta el { FechaHasta.ToShortDateString() }"
            MostrarMovimiento(titulo, efectivoEgresos)
        End Function

        Friend Async Function MostrarTotalVentaAsync() As Task
            Await MostrarTotalVentaMovimientoAsync($"Ventas registradas entre el { FechaDesde.ToShortDateString() } hasta el { FechaHasta.ToShortDateString() }", Nothing, Nothing, Nothing)
        End Function

        Friend Async Function MostrarTotalVentaEfectivoAsync() As Task
            Await MostrarTotalVentaMovimientoAsync($"Ventas en efectivo registradas entre el { FechaDesde.ToShortDateString() } hasta el { FechaHasta.ToShortDateString() }", Nothing, TipoPago.Efectivo, Nothing)
        End Function

        Friend Async Function MostrarTotalVentaChequeAsync() As Task
            Await MostrarTotalVentaMovimientoAsync($"Ventas en cheque registradas entre el { FechaDesde.ToShortDateString() } hasta el { FechaHasta.ToShortDateString() }", Nothing, TipoPago.Cheque, Nothing)
        End Function

        Friend Async Function MostrarTotalVentaDepositoAsync() As Task
            Await MostrarTotalVentaMovimientoAsync($"Ventas en deposito registradas entre el { FechaDesde.ToShortDateString() } hasta el { FechaHasta.ToShortDateString() }", Nothing, TipoPago.Deposito, Nothing)
        End Function

        Friend Async Function MostrarTotalVentaTarjetaCreditoAsync() As Task
            Await MostrarTotalVentaMovimientoAsync($"Ventas en tarjeta crédito registradas entre el { FechaDesde.ToShortDateString() } hasta el { FechaHasta.ToShortDateString() }", Nothing, TipoPago.TarjetaCrédito, Nothing)
        End Function

        Friend Async Function MostrarTotalVentaTarjetaDebitoAsync() As Task
            Await MostrarTotalVentaMovimientoAsync($"Ventas en tarjeta debito registradas entre el { FechaDesde.ToShortDateString() } hasta el { FechaHasta.ToShortDateString() }", Nothing, TipoPago.TarjetaDébito, Nothing)
        End Function

        Friend Async Function MostrarTotalVentaFacturadoAsync() As Task
            Await MostrarTotalVentaMovimientoAsync($"Ventas facturadas registradas entre el { FechaDesde.ToShortDateString() } hasta el { FechaHasta.ToShortDateString() }", True, Nothing, Nothing)
        End Function

        Friend Async Function MostrarTotalVentaSinFacturadoAsync() As Task
            Await MostrarTotalVentaMovimientoAsync($"Ventas no facturadas registradas entre el { FechaDesde.ToShortDateString() } hasta el { FechaHasta.ToShortDateString() }", False, Nothing, Nothing)
        End Function

        Friend Async Function MostrarTotalVentaMayoristaAsync() As Task
            Await MostrarTotalVentaMovimientoAsync($"Ventas mayoristas registradas entre el { FechaDesde.ToShortDateString() } hasta el { FechaHasta.ToShortDateString() }", Nothing, Nothing, TipoCliente.Mayorista)
        End Function

        Friend Async Function MostrarTotalVentaMinoristaAsync() As Task
            Await MostrarTotalVentaMovimientoAsync($"Ventas minorista registradas entre el { FechaDesde.ToShortDateString() } hasta el { FechaHasta.ToShortDateString() }", Nothing, Nothing, TipoCliente.Mayorista)
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

        Private Sub CargarResumenVentaAsync(sucursalPagos As SucursalPagos)
            Saldos.VentaTotal = sucursalPagos.VentaTotal
            Saldos.VentaEfectivo = sucursalPagos.Efectivo
            Saldos.VentaCheque = sucursalPagos.Cheque
            Saldos.VentaCredito = sucursalPagos.Credito
            Saldos.VentaDeposito = sucursalPagos.Deposito
            Saldos.VentaDebito = sucursalPagos.Debito
            Saldos.VentaCuentaCorriente = sucursalPagos.CuentaCorriente
            Saldos.VentaFacturado = sucursalPagos.FacturadoVenta
            Saldos.VentaSinFacturar = sucursalPagos.SinFacturarVenta
            Saldos.VentaMinorista = sucursalPagos.MinoristaVenta
            Saldos.VentaMayorista = sucursalPagos.MayoristaVenta
        End Sub

        Private Sub CargarIngresos(ingresos As Model.Ingreso)

            Saldos.CajaInical = ingresos.CajaInicial
            Saldos.RecibidosSucursal = ingresos.RecibidosSucursal
            Saldos.SobranteCaja = ingresos.SobranteCaja
            Saldos.EgresoCajaFuerte = ingresos.EgresosCajaFuerte
            Saldos.AporteSocios = ingresos.AporteSocios

            TotalIngreso = Saldos.VentaTotal + Saldos.RecibidosSucursal + Saldos.SobranteCaja + Saldos.EgresoCajaFuerte + Saldos.AporteSocios

            NotifyPropertyChanged(NameOf(Me.TotalIngreso))
        End Sub

        Private Sub CargarEgresos(egresos As Model.Egreso)

            Saldos.Devoluciones = egresos.Devoluciones
            Saldos.Mercaderia = egresos.Mercaderias
            Saldos.Sueldos = egresos.Sueldos
            Saldos.Gastos = egresos.Gastos
            Saldos.Impuestos = egresos.Impuestos
            Saldos.EnviosSucursales = egresos.EnviosSucursales
            Saldos.PendienteAutorizacion = egresos.PendientesAutorizacion
            Saldos.FaltanteCaja = egresos.FaltanteCaja
            Saldos.IngresosCajaFuerte = egresos.IngresoCajaFuerte
            Saldos.RetiroSocios = egresos.RetirosSocios

            TotalEgresos = Saldos.Devoluciones + Saldos.Mercaderia + Saldos.Sueldos + Saldos.Gastos + Saldos.Impuestos + Saldos.EnviosSucursales + Saldos.FaltanteCaja + Saldos.IngresosCajaFuerte + Saldos.RetiroSocios

            NotifyPropertyChanged(NameOf(Me.TotalEgresos))
        End Sub

    End Class
End Namespace
