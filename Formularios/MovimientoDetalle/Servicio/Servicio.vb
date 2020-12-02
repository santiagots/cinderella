Imports AutoMapper
Imports Common.Core.Enum
Imports Ventas.Core.Enum
Imports Ventas.Core.Interfaces
Imports Ventas.Data
Imports Ventas.Data.Repository
Imports ModelVenta = Ventas.Core.Model.VentaAggregate

Namespace Formularios.MovimientoDetalle

    Public Class Servicio
        Private Shared NegDev As New Negocio.NegDevolucion
        Private Shared NegMov As New Negocio.NegMovimientos
        Private Shared NegEmp As New Negocio.NegEmpleados
        Private Shared NegAde As New Negocio.NegAdelantos
        Private Shared NegVen As New Negocio.NegVentas

        Friend Shared Function ObtenerDevoluciones(idSucursal As Integer, fechaDesde As DateTime, fechaHasta As DateTime) As List(Of MovimientoDevolucion)
            Dim devoluciones As List(Of MovimientoDevolucion) = New List(Of MovimientoDevolucion)
            Dim dsDevoluciones As DataSet = NegDev.ObtenerDevolucionesSucursalListado(idSucursal, fechaDesde.ToString("yyyy/MM/dd"), fechaHasta.ToString("yyyy/MM/dd"))
            For Each drDevolucion As DataRow In dsDevoluciones.Tables(0)?.Rows
                devoluciones.Add(New MovimientoDevolucion() With {
                                    .Fecha = drDevolucion("Fecha"),
                                    .FormaPago = drDevolucion("Tipo_Pago"),
                                    .Monto = drDevolucion("Precio_Total")
                                 })
            Next

            Return devoluciones
        End Function

        Friend Shared Function ObtenerGastos(idSucursal As Integer, fechaDesde As DateTime, fechaHasta As DateTime) As List(Of MovimientoGasto)
            Dim gastos As List(Of MovimientoGasto) = New List(Of MovimientoGasto)
            Dim dsGastos As DataSet = NegMov.ObtenerMovGastoFecha(idSucursal, fechaDesde.ToString("yyyy/MM/dd"), fechaHasta.ToString("yyyy/MM/dd"))
            For Each drGasto As DataRow In dsGastos.Tables(0)?.Rows
                gastos.Add(New MovimientoGasto() With {
                                    .Fecha = drGasto("Fecha"),
                                    .Tipo = drGasto("Tipo"),
                                    .Monto = drGasto("Monto")
                                 })
            Next

            Return gastos
        End Function

        Friend Shared Function ObtenerSueldos(idSucursal As Integer, fechaDesde As DateTime, fechaHasta As DateTime) As List(Of MovimientoSueldo)
            Dim sueldos As List(Of MovimientoSueldo) = New List(Of MovimientoSueldo)
            Dim dsSueldo As DataSet = NegEmp.SueldoDepositadoDetalleSucursal(idSucursal, fechaDesde.ToString("yyyy/MM/dd"), fechaHasta.ToString("yyyy/MM/dd"))
            Dim dsAdelantos As DataSet = NegAde.ObtenerAdelantosSucursalListado(idSucursal, fechaDesde.ToString("yyyy/MM/dd"), fechaHasta.ToString("yyyy/MM/dd"))

            For Each drSueldo As DataRow In dsSueldo.Tables(0)?.Rows
                sueldos.Add(New MovimientoSueldo() With {
                                    .Fecha = drSueldo("Fecha"),
                                    .Empleado = drSueldo("Empleado"),
                                    .Monto = drSueldo("Monto"),
                                    .Concepto = "Depósito de Sueldo"
                                 })
            Next

            For Each drAdelanto As DataRow In dsAdelantos.Tables(0)?.Rows
                sueldos.Add(New MovimientoSueldo() With {
                                    .Fecha = drAdelanto("Fecha"),
                                    .Empleado = drAdelanto("Empleado"),
                                    .Monto = drAdelanto("Monto"),
                                    .Concepto = "Adelanto de Sueldo"
                                 })
            Next

            Return sueldos
        End Function

        Friend Shared Function ObtenerImpuestos(idSucursal As Integer, fechaDesde As DateTime, fechaHasta As DateTime) As List(Of MovimientoImpuesto)
            Dim impuestos As List(Of MovimientoImpuesto) = New List(Of MovimientoImpuesto)
            Dim dsImpuestos As DataSet = NegMov.ObtenerMovImpuestoFecha(idSucursal, fechaDesde.ToString("yyyy/MM/dd"), fechaHasta.ToString("yyyy/MM/dd"))
            For Each drImpuesto As DataRow In dsImpuestos.Tables(0)?.Rows
                impuestos.Add(New MovimientoImpuesto() With {
                                    .Fecha = drImpuesto("Fecha"),
                                    .Tipo = drImpuesto("Tipo"),
                                    .Monto = drImpuesto("Monto")
                                 })
            Next

            Return impuestos
        End Function

        Friend Shared Function ObtenerEgresos(idSucursal As Integer, fechaDesde As DateTime, fechaHasta As DateTime, tipo As String) As List(Of MovimientoEgreso)
            Dim egreso As List(Of MovimientoEgreso) = New List(Of MovimientoEgreso)
            Dim dsEgreso As DataSet = NegMov.ObtenerMovEgresoFecha(idSucursal, fechaDesde.ToString("yyyy/MM/dd"), fechaHasta.ToString("yyyy/MM/dd"), tipo)
            For Each drEgreso As DataRow In dsEgreso.Tables(0)?.Rows
                egreso.Add(New MovimientoEgreso() With {
                                    .Fecha = drEgreso("Fecha"),
                                    .Tipo = drEgreso("Tipo"),
                                    .Subtipo = drEgreso("Subtipo").ToString(),
                                    .Monto = drEgreso("Monto")
                                 })
            Next

            Return egreso
        End Function

        Friend Shared Function ObtenerRetiroSocio(idSucursal As Integer, fechaDesde As DateTime, fechaHasta As DateTime) As List(Of MovimientoSocio)
            Dim movimientosSocios As List(Of MovimientoSocio) = New List(Of MovimientoSocio)
            Dim dsMoviminetosSocios As DataSet = NegMov.ObtenerMovRetiroFecha(idSucursal, fechaDesde.ToString("yyyy/MM/dd"), fechaHasta.ToString("yyyy/MM/dd"))
            For Each drMovimientoSocio As DataRow In dsMoviminetosSocios.Tables(0)?.Rows
                movimientosSocios.Add(New MovimientoSocio() With {
                                    .Fecha = drMovimientoSocio("Fecha"),
                                    .Monto = drMovimientoSocio("Monto"),
                                    .Encargado = drMovimientoSocio("Encargado_Retirante"),
                                    .Personal = drMovimientoSocio("Persona_Retirante")
                                 })
            Next

            Return movimientosSocios
        End Function

        Friend Shared Function ObtenerIngresoCajaFuerte(idSucursal As Integer, fechaDesde As Date, fechaHasta As Date, tipo As Integer) As List(Of MovimientoCajaFuerte)
            Dim movimientosCajaFuerte As List(Of MovimientoCajaFuerte) = New List(Of MovimientoCajaFuerte)
            Dim dsMoviminetosCajaFuerte As DataSet = NegMov.ObtenerMovCajaFuerteFecha(idSucursal, fechaDesde.ToString("yyyy/MM/dd"), fechaHasta.ToString("yyyy/MM/dd"), tipo)
            For Each drMovimientoCajaFuerte As DataRow In dsMoviminetosCajaFuerte.Tables(0)?.Rows
                movimientosCajaFuerte.Add(New MovimientoCajaFuerte() With {
                                    .Fecha = drMovimientoCajaFuerte("Fecha"),
                                    .Monto = drMovimientoCajaFuerte("Monto")
                                 })
            Next

            Return movimientosCajaFuerte
        End Function

        Friend Shared Function ObtenerAporteSocio(idSucursal As Integer, fechaDesde As DateTime, fechaHasta As DateTime) As List(Of MovimientoSocio)
            Dim movimientosSocios As List(Of MovimientoSocio) = New List(Of MovimientoSocio)
            Dim dsMoviminetosSocios As DataSet = NegMov.ObtenerMovAporteFecha(idSucursal, fechaDesde.ToString("yyyy/MM/dd"), fechaHasta.ToString("yyyy/MM/dd"))
            For Each drMovimientoSocio As DataRow In dsMoviminetosSocios.Tables(0)?.Rows
                movimientosSocios.Add(New MovimientoSocio() With {
                                    .Fecha = drMovimientoSocio("Fecha"),
                                    .Monto = drMovimientoSocio("Monto"),
                                    .Encargado = drMovimientoSocio("Encargado_Retirante"),
                                    .Personal = drMovimientoSocio("Persona_Retirante")
                                 })
            Next

            Return movimientosSocios
        End Function

        Friend Shared Function ObtenerMovimientoCaja(idSucursal As Integer, fechaDesde As DateTime, fechaHasta As DateTime, situacionCaja As CierreCajaSituacion?) As List(Of MovimientoCaja)
            Using context As VentaContext = New VentaContext()
                Dim cierreCajaRepository As ICierreCajaRepository = New CierreCajaRepository(context)
                Dim cierresCajas As List(Of ModelVenta.CierreCaja) = cierreCajaRepository.Buscar(idSucursal, fechaDesde, fechaHasta, situacionCaja)
                Return Mapper.Map(Of List(Of MovimientoCaja))(cierresCajas)
            End Using
        End Function

    End Class

End Namespace
