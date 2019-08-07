Imports System.Threading.Tasks
Imports Common.Core.Enum
Imports Ventas.Core.Interfaces
Imports Model = Ventas.Core.Model.VentaAggregate
Imports ValueObjects = Ventas.Core.Model.ValueObjects
Imports Ventas.Data
Imports Ventas.Data.Repository

Namespace Formularios.ResumenDiario
    Public Class Servicio
        Private Shared NegDev As New Negocio.NegDevolucion
        Private Shared NegMov As New Negocio.NegMovimientos
        Private Shared NegEmp As New Negocio.NegEmpleados
        Private Shared NegAdel As New Negocio.NegAdelantos

        Friend Shared Sub ActualizarCierreCaja(cierreCaja As Model.CierreCaja)
            Using context As VentaContext = New VentaContext()
                Dim cierreCajaRepository As ICierreCajaRepository = New CierreCajaRepository(context)
                cierreCajaRepository.Actualizar(cierreCaja)
            End Using
        End Sub

        Friend Shared Sub GuardarCierreCaja(cierreCaja As Model.CierreCaja)
            Using context As VentaContext = New VentaContext()
                Dim cierreCajaRepository As ICierreCajaRepository = New CierreCajaRepository(context)
                cierreCajaRepository.Alta(cierreCaja)
            End Using
        End Sub

        Friend Shared Function ObtenerCierreCaja(idSucursal As Integer, fecha As DateTime) As Model.CierreCaja
            Using context As VentaContext = New VentaContext()
                Dim cierreCajaRepository As ICierreCajaRepository = New CierreCajaRepository(context)
                Return cierreCajaRepository.Obtener(idSucursal, fecha)
            End Using
        End Function

        Friend Shared Function ObtenerUltimoCierreCaja(idSucursal As Integer) As Model.CierreCaja
            Using context As VentaContext = New VentaContext()
                Dim cierreCajaRepository As ICierreCajaRepository = New CierreCajaRepository(context)
                Return cierreCajaRepository.ObtenerUltima(idSucursal)
            End Using
        End Function

        Friend Shared Async Function CargarSaldoAsync(idSucursal As Integer, fecha As DateTime) As Task(Of ValueObjects.SucursalSaldo)
            Dim venta As ValueObjects.Venta = Await CargarVentasAsync(idSucursal, fecha)
            Dim ingreso As ValueObjects.Ingreso = Await CargarIngresosAsync(idSucursal, fecha)
            Dim egreso As ValueObjects.Egreso = Await CargarEgresosAsync(idSucursal, fecha)

            Dim totalCajaFuerte As Decimal = Await Task.Run(Function() NegMov.ConsultarTotalCajaFuerte(idSucursal, fecha.ToString("yyyy/MM/dd")))
            Dim totalCarteraCheque As Decimal = Await Task.Run(Function() Cheque.Servicio.TotalCarteraCheque(idSucursal))

            Return New ValueObjects.SucursalSaldo(venta, ingreso, egreso, totalCajaFuerte, totalCarteraCheque)
        End Function

        Private Shared Async Function CargarVentasAsync(idSucursal As Integer, fecha As DateTime) As Task(Of ValueObjects.Venta)
            Dim efectivo As Task(Of Decimal) = Task.Run(Function() Venta.Servicio.ObtenerTotalVentasPorTipoPago(idSucursal, fecha, TipoPago.Efectivo))
            Dim cheques As Task(Of Decimal) = Task.Run(Function() Venta.Servicio.ObtenerTotalVentasPorTipoPago(idSucursal, fecha, TipoPago.Cheque))
            Dim credito As Task(Of Decimal) = Task.Run(Function() Venta.Servicio.ObtenerTotalVentasPorTipoPago(idSucursal, fecha, TipoPago.TarjetaCredito))
            Dim debito As Task(Of Decimal) = Task.Run(Function() Venta.Servicio.ObtenerTotalVentasPorTipoPago(idSucursal, fecha, TipoPago.TarjetaDebito))
            Dim facturado As Task(Of Decimal) = Task.Run(Function() Venta.Servicio.ObtenerTotalVentasPorPorFacturacion(idSucursal, fecha, True))
            Dim minorista As Task(Of Decimal) = Task.Run(Function() Venta.Servicio.ObtenerTotalVentasPorTipoCliente(idSucursal, fecha, TipoCliente.Minorista))
            Dim mayorista As Task(Of Decimal) = Task.Run(Function() Venta.Servicio.ObtenerTotalVentasPorTipoCliente(idSucursal, fecha, TipoCliente.Mayorista))

            Await Task.WhenAll(efectivo, cheques, credito, credito, minorista, mayorista)

            Return New ValueObjects.Venta(efectivo.Result, cheques.Result, credito.Result, debito.Result, facturado.Result, minorista.Result, mayorista.Result)
        End Function

        Private Shared Async Function CargarIngresosAsync(idSucursal As Integer, fecha As DateTime) As Task(Of ValueObjects.Ingreso)
            Dim recibidosSucursal As Decimal = Await Task.Run(Function() NegMov.ObtenerTotalMovEgreso(idSucursal, fecha.ToString("yyyy/MM/dd"), fecha.ToString("yyyy/MM/dd"), "Ingresos"))
            Dim egresoCajaFuerte As Decimal = Await Task.Run(Function() NegMov.ObtenerTotalMovCajaFuerte(idSucursal, fecha.ToString("yyyy/MM/dd"), fecha.ToString("yyyy/MM/dd"), 1))
            Dim aporteSocios As Decimal = Await Task.Run(Function() NegMov.TotalMovAporte(idSucursal, fecha.ToString("yyyy/MM/dd"), fecha.ToString("yyyy/MM/dd")))
            Dim totalVenta As Decimal = Await Task.Run(Function() Venta.Servicio.ObtenerTotalVentas(idSucursal, fecha))

            Dim cierreCajaAnterior As Model.CierreCaja = Await Task.Run(Function() ObtenerCierreCaja(idSucursal, fecha.AddDays(-1)))
            Dim cajaInicial As Decimal = If(cierreCajaAnterior = Nothing, 0, cierreCajaAnterior.Monto)
            Dim sobranteCaja As Decimal = If(cierreCajaAnterior = Nothing, 0, cierreCajaAnterior.ObtenerSobrante())

            Return New ValueObjects.Ingreso(totalVenta, cajaInicial, recibidosSucursal, sobranteCaja, egresoCajaFuerte, aporteSocios)
        End Function

        Private Shared Async Function CargarEgresosAsync(idSucursal As Integer, fecha As DateTime) As Task(Of ValueObjects.Egreso)
            Dim devoluciones As Decimal = Await Task.Run(Function() NegDev.TotalDevolucionesEfectivo(idSucursal, fecha.ToString("yyyy/MM/dd"), fecha.ToString("yyyy/MM/dd")))

            Dim mercaderia As Decimal = Await Task.Run(Function() NegMov.ConsultarTotalGastoMercaderia(idSucursal, fecha.ToString("yyyy/MM/dd"), fecha.ToString("yyyy/MM/dd")))

            Dim sueldos As Decimal = Await Task.Run(Function() NegEmp.ObtenerSueldosSucursal(idSucursal, fecha.ToString("yyyy/MM/dd"), fecha.ToString("yyyy/MM/dd")))
            sueldos += Await Task.Run(Function() NegAdel.ObtenerAdelantosSucursal(idSucursal, fecha.ToString("yyyy/MM/dd"), fecha.ToString("yyyy/MM/dd")))

            Dim gastos As Decimal = Await Task.Run(Function() NegMov.TotalMovEgresosGastos(idSucursal, fecha.ToString("yyyy/MM/dd"), fecha.ToString("yyyy/MM/dd")))
            gastos += Await Task.Run(Function() NegMov.TotalMovGastos(idSucursal, fecha.ToString("yyyy/MM/dd"), fecha.ToString("yyyy/MM/dd")))

            Dim impuestos As Decimal = Await Task.Run(Function() NegMov.TotalMovEgresosImpuesto(idSucursal, fecha.ToString("yyyy/MM/dd"), fecha.ToString("yyyy/MM/dd")))
            impuestos += Await Task.Run(Function() NegMov.TotalMovImpuesto(idSucursal, fecha.ToString("yyyy/MM/dd"), fecha.ToString("yyyy/MM/dd")))

            Dim enviosSucursales As Decimal = Await Task.Run(Function() NegMov.ObtenerTotalMovEgreso(idSucursal, fecha.ToString("yyyy/MM/dd"), fecha.ToString("yyyy/MM/dd"), "Egresos"))

            Dim pendienteAutorizacion As Decimal = Await Task.Run(Function() NegMov.ObtenerTotalMovEgreso(idSucursal, fecha.ToString("yyyy/MM/dd"), fecha.ToString("yyyy/MM/dd"), "EgresosPendientes"))

            Dim ingresosCajaFuerte As Decimal = Await Task.Run(Function() NegMov.ObtenerTotalMovCajaFuerte(idSucursal, fecha.ToString("yyyy/MM/dd"), fecha.ToString("yyyy/MM/dd"), 2))

            Dim retiroSocios As Decimal = Await Task.Run(Function() NegMov.TotalMovRetiro(idSucursal, fecha.ToString("yyyy/MM/dd"), fecha.ToString("yyyy/MM/dd")))

            Dim cierreCajaAnterior As Model.CierreCaja = Await Task.Run(Function() ObtenerCierreCaja(idSucursal, fecha.AddDays(-1)))
            Dim faltanteCaja As Decimal = If(cierreCajaAnterior = Nothing, 0, cierreCajaAnterior.ObtenerFaltante())

            Return New ValueObjects.Egreso(devoluciones, mercaderia, sueldos, gastos, impuestos, enviosSucursales, faltanteCaja, pendienteAutorizacion, ingresosCajaFuerte, retiroSocios)
        End Function

    End Class
End Namespace
