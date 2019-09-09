Imports System.Threading.Tasks
Imports Common.Core.Enum
Imports Ventas.Core.Interfaces
Imports Ventas.Core.Model.VentaAggregate
Imports ValueObjects = Ventas.Core.Model.ValueObjects
Imports Ventas.Core.Model.ValueObjects
Imports Ventas.Core.Enum
Imports Ventas.Data
Imports Ventas.Data.Repository

Namespace Formularios.SucursalSaldo
    Public Class Servicio
        Private Shared NegDev As New Negocio.NegDevolucion
        Private Shared NegMov As New Negocio.NegMovimientos
        Private Shared NegEmp As New Negocio.NegEmpleados
        Private Shared NegAdel As New Negocio.NegAdelantos

        Friend Shared Sub ActualizarCierreCaja(cierreCaja As CierreCaja)
            Using context As VentaContext = New VentaContext()
                Dim cierreCajaRepository As ICierreCajaRepository = New CierreCajaRepository(context)
                cierreCajaRepository.Actualizar(cierreCaja)
            End Using
        End Sub

        Friend Shared Sub GuardarCierreCaja(cierreCaja As CierreCaja)
            Using context As VentaContext = New VentaContext()
                Dim cierreCajaRepository As ICierreCajaRepository = New CierreCajaRepository(context)
                cierreCajaRepository.Alta(cierreCaja)
            End Using
        End Sub

        Friend Shared Function ObtenerCierreCaja(idSucursal As Integer, fecha As DateTime) As CierreCaja
            Using context As VentaContext = New VentaContext()
                Dim cierreCajaRepository As ICierreCajaRepository = New CierreCajaRepository(context)
                Return cierreCajaRepository.Obtener(idSucursal, fecha)
            End Using
        End Function

        Friend Shared Function ObtenerTotalDiferenciaCierreCaja(idSucursal As Integer, fechaDesde As DateTime, fechaHasta As DateTime, situacionCaja As CierreCajaSituacion) As Decimal
            Using context As VentaContext = New VentaContext()
                Dim cierreCajaRepository As ICierreCajaRepository = New CierreCajaRepository(context)
                Return cierreCajaRepository.ObtenerTotalDiferencia(idSucursal, fechaDesde, fechaHasta, situacionCaja)
            End Using
        End Function

        Friend Shared Function ObtenerUltimoCierreCaja(idSucursal As Integer) As CierreCaja
            Using context As VentaContext = New VentaContext()
                Dim cierreCajaRepository As ICierreCajaRepository = New CierreCajaRepository(context)
                Return cierreCajaRepository.ObtenerUltima(idSucursal)
            End Using
        End Function

        Friend Shared Function BuscarCierreCaja(idSucursal As Integer, fechaDesde As DateTime, fechaHasta As DateTime, situacionCaja As CierreCajaSituacion?) As List(Of CierreCaja)
            Using context As VentaContext = New VentaContext()
                Dim cierreCajaRepository As ICierreCajaRepository = New CierreCajaRepository(context)
                Return cierreCajaRepository.Buscar(idSucursal, fechaDesde, fechaHasta, situacionCaja)
            End Using
        End Function

        Friend Shared Async Function CargarSaldoAsync(idSucursal As Integer, fecha As DateTime) As Task(Of ValueObjects.SucursalSaldo)
            Dim ingreso As Ingreso = Await CargarIngresosAsync(idSucursal, fecha)
            Dim egreso As Egreso = Await CargarEgresosAsync(idSucursal, fecha)

            Dim totalCajaFuerte As Decimal = Await Task.Run(Function() NegMov.ConsultarTotalCajaFuerte(idSucursal, fecha.ToString("yyyy/MM/dd")))

            Return New ValueObjects.SucursalSaldo(ingreso, egreso, totalCajaFuerte)
        End Function

        Private Shared Async Function CargarIngresosAsync(idSucursal As Integer, fecha As DateTime) As Task(Of Ingreso)
            Dim recibidosSucursal As Double = Await Task.Run(Function() NegMov.ObtenerTotalMovEgreso(idSucursal, fecha.ToString("yyyy/MM/dd"), fecha.ToString("yyyy/MM/dd"), "Ingresos"))
            Dim egresoCajaFuerte As Double = Await Task.Run(Function() NegMov.ObtenerTotalMovCajaFuerte(idSucursal, fecha.ToString("yyyy/MM/dd"), fecha.ToString("yyyy/MM/dd"), 1))
            Dim aporteSocios As Double = Await Task.Run(Function() NegMov.TotalMovAporte(idSucursal, fecha.ToString("yyyy/MM/dd"), fecha.ToString("yyyy/MM/dd")))
            Dim totalEfectivo As Decimal = Await Task.Run(Function() Venta.Servicio.ObtenerTotalVentas(idSucursal, fecha, Nothing, TipoPago.Efectivo, Nothing))
            Dim cierreCajaAnterior As CierreCaja = Await Task.Run(Function() Servicio.ObtenerCierreCaja(idSucursal, fecha.AddDays(-1)))

            Dim cajaInicial As Decimal = If(cierreCajaAnterior = Nothing, 0, cierreCajaAnterior.Monto)
            Dim sobranteCaja As Decimal = If(cierreCajaAnterior = Nothing, 0, cierreCajaAnterior.ObtenerSobrante())

            Return New Ingreso(totalEfectivo, cajaInicial, recibidosSucursal, sobranteCaja, egresoCajaFuerte, aporteSocios)
        End Function

        Private Shared Async Function CargarEgresosAsync(idSucursal As Integer, fecha As DateTime) As Task(Of Egreso)
            Dim devoluciones As Decimal = Await Task.Run(Function() CType(NegDev.TotalDevolucionesEfectivo(idSucursal, fecha.ToString("yyyy/MM/dd"), fecha.ToString("yyyy/MM/dd")), Decimal))
            Dim mercaderia As Decimal = Await Task.Run(Function() CType(NegMov.ConsultarTotalGastoMercaderia(idSucursal, fecha.ToString("yyyy/MM/dd"), fecha.ToString("yyyy/MM/dd")), Decimal))
            Dim sueldos As Decimal = Await Task.Run(Function() CType(NegEmp.ObtenerSueldosSucursal(idSucursal, fecha.ToString("yyyy/MM/dd"), fecha.ToString("yyyy/MM/dd")), Decimal))
            Dim sueldosAdelantos As Decimal = Await Task.Run(Function() CType(NegAdel.ObtenerAdelantosSucursal(idSucursal, fecha.ToString("yyyy/MM/dd"), fecha.ToString("yyyy/MM/dd")), Decimal))
            Dim gastosEgresos As Decimal = Await Task.Run(Function() CType(NegMov.TotalMovEgresosGastos(idSucursal, fecha.ToString("yyyy/MM/dd"), fecha.ToString("yyyy/MM/dd")), Decimal))
            Dim gastosMovimientos As Decimal = Await Task.Run(Function() CType(NegMov.TotalMovGastos(idSucursal, fecha.ToString("yyyy/MM/dd"), fecha.ToString("yyyy/MM/dd")), Decimal))
            Dim impuestosEgresos As Decimal = Await Task.Run(Function() CType(NegMov.TotalMovEgresosImpuesto(idSucursal, fecha.ToString("yyyy/MM/dd"), fecha.ToString("yyyy/MM/dd")), Decimal))
            Dim impuestosMovimientos As Decimal = Await Task.Run(Function() CType(NegMov.TotalMovImpuesto(idSucursal, fecha.ToString("yyyy/MM/dd"), fecha.ToString("yyyy/MM/dd")), Decimal))
            Dim enviosSucursales As Decimal = Await Task.Run(Function() CType(NegMov.ObtenerTotalMovEgreso(idSucursal, fecha.ToString("yyyy/MM/dd"), fecha.ToString("yyyy/MM/dd"), "Egresos"), Decimal))
            Dim pendienteAutorizacion As Decimal = Await Task.Run(Function() CType(NegMov.ObtenerTotalMovEgreso(idSucursal, fecha.ToString("yyyy/MM/dd"), fecha.ToString("yyyy/MM/dd"), "EgresosPendientes"), Decimal))
            Dim ingresosCajaFuerte As Decimal = Await Task.Run(Function() CType(NegMov.ObtenerTotalMovCajaFuerte(idSucursal, fecha.ToString("yyyy/MM/dd"), fecha.ToString("yyyy/MM/dd"), 2), Decimal))
            Dim retiroSocios As Decimal = Await Task.Run(Function() CType(NegMov.TotalMovRetiro(idSucursal, fecha.ToString("yyyy/MM/dd"), fecha.ToString("yyyy/MM/dd")), Decimal))
            Dim cierreCajaAnterior As CierreCaja = Await Task.Run(Function() Servicio.ObtenerCierreCaja(idSucursal, fecha.AddDays(-1)))


            Dim faltanteCaja As Decimal = Math.Abs(If(cierreCajaAnterior = Nothing, 0, cierreCajaAnterior.ObtenerFaltante()))

            Return New Egreso(devoluciones, mercaderia, sueldos + sueldosAdelantos, gastosEgresos + gastosMovimientos, impuestosEgresos + impuestosMovimientos, enviosSucursales, faltanteCaja, pendienteAutorizacion, ingresosCajaFuerte, retiroSocios)
        End Function

    End Class
End Namespace
