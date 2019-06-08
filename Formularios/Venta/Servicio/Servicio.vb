Imports Common.Core.Enum
Imports Ventas.Core.Interfaces
Imports Model = Ventas.Core.Model.VentaAggregate
Imports Ventas.Data
Imports Ventas.Data.Repository
Imports Common.Service.Facturar
Imports Common.Service.NotaCredito
Imports Common.Core.ValueObjects
Imports Ventas.Core.Model.VentaAggregate

Namespace Formularios.Venta
    Public Class Servicio

        Friend Shared Sub ActualizarVenta(venta As Model.Venta)
            Using context As VentaContext = New VentaContext()
                Dim ventaRepository As IVentaRepository = New VentaRepository(context)
                ventaRepository.Actualizar(venta)
            End Using
        End Sub

        Friend Shared Function ObtenerVenta(idVenta As Long) As Model.Venta
            Using context As VentaContext = New VentaContext()
                Dim ventaRepository As IVentaRepository = New VentaRepository(context)
                Return ventaRepository.Obtener(idVenta)
            End Using
        End Function

        Friend Shared Function ObtenerFactura(id As Long) As Model.Factura
            Using context As VentaContext = New VentaContext()
                Dim facturaRepository As IFacturaRepository = New FacturaRepository(context)
                Return facturaRepository.Obtener(id)
            End Using
        End Function

        Friend Shared Function ObtenerNotaCredito(id As Long) As Model.NotaCredito
            Using context As VentaContext = New VentaContext()
                Dim notaCreditoRepository As INotaCreditoRepository = New NotaCreditoRepository(context)
                Return notaCreditoRepository.Obtener(id)
            End Using
        End Function

        Friend Shared Sub GuardarFactura(factura As Model.Factura)
            Using context As VentaContext = New VentaContext()
                Dim facturaRepository As IFacturaRepository = New FacturaRepository(context)
                facturaRepository.Guardar(factura)
            End Using
        End Sub

        Public Shared Function BuscarVenta(idSucursal As Integer, numeroFacturaDesde As Integer?, numeroFacturaHasta As Integer?, montoDesde As Decimal?, montoHasta As Decimal?, fechaDesde As DateTime?, fechaHasta As DateTime?, anulado As Boolean?, tiposFacturas As IEnumerable(Of TipoFactura), tiposPagos As IEnumerable(Of TipoPago), tiposClientes As IEnumerable(Of TipoCliente)) As IEnumerable(Of Model.Venta)
            Using context As VentaContext = New VentaContext()
                Dim ventaRepository As IVentaRepository = New VentaRepository(context)
                Return ventaRepository.Buscar(idSucursal, numeroFacturaDesde, numeroFacturaHasta, montoDesde, montoHasta, fechaDesde, fechaHasta, anulado, tiposFacturas, tiposPagos, tiposClientes)
            End Using
        End Function

        Friend Shared Function BuscarNotaCredito(idSucursal As Integer, numeroNotaCredito As Integer?, montoDesde As Decimal?, montoHasta As Decimal?, nombre As String, cuit As Integer?, fechaDesde As Date?, fechaHasta As Date?, tiposFacturas As List(Of TipoFactura)) As IEnumerable(Of Model.NotaCredito)
            Using context As VentaContext = New VentaContext()
                Dim NotaCreditoRepository As INotaCreditoRepository = New NotaCreditoRepository(context)
                Return NotaCreditoRepository.Buscar(idSucursal, numeroNotaCredito, montoDesde, montoHasta, nombre, cuit, fechaDesde, fechaHasta, tiposFacturas)
            End Using
        End Function

        Friend Shared Function BuscarFactura(idSucursal As Integer, numeroFactura As Integer?, montoDesde As Decimal?, montoHasta As Decimal?, nombre As String, cuit? As Integer, fechaDesde As Date?, fechaHasta As Date?, tiposFacturas As List(Of TipoFactura)) As IEnumerable(Of Model.Factura)
            Using context As VentaContext = New VentaContext()
                Dim facturaRepository As IFacturaRepository = New FacturaRepository(context)
                Return facturaRepository.Buscar(idSucursal, numeroFactura, montoDesde, montoHasta, nombre, cuit, fechaDesde, fechaHasta, tiposFacturas)
            End Using
        End Function

        Public Shared Function ObtenerUltimoNumeroFactura(tipoFactura As TipoFactura) As Integer
            Using context As VentaContext = New VentaContext()
                Dim facturaRepository As IFacturaRepository = New FacturaRepository(context)
                Return facturaRepository.ObtenerUltimoNumeroFactura(tipoFactura)
            End Using
        End Function

        Friend Shared Function ObtenerReservaPorIdVenta(idVenta As Long) As Model.Reserva
            Using context As VentaContext = New VentaContext()
                Dim reservaRepository As IReservaRepository = New ReservaRepository(context)
                Return reservaRepository.ObtenerPorIdVenta(idVenta)
            End Using
        End Function

        Public Shared Function FacturarService(tipoFactura As TipoFactura, tipoCliente As TipoCliente, condicionesIVA As CondicionIVA, pagos As IEnumerable(Of TicketPago), productos As IEnumerable(Of TicketProducto), porcentajeFacturacion As Decimal, nombreYApellido As String, direccion As String, localidad As String, cuit As String) As IList(Of Integer)
            Dim facturar As FacturarService = New FacturarService(tipoFactura)
            Return facturar.ObtenerNumeroFactura(tipoCliente, condicionesIVA, pagos, productos, porcentajeFacturacion, nombreYApellido, direccion, localidad, cuit)
        End Function

        Public Shared Function NotaCreditoService(tipoFactura As TipoFactura, tipoCliente As TipoCliente, condicionesIVA As CondicionIVA, pagos As IEnumerable(Of TicketPago), productos As IEnumerable(Of TicketProducto), porcentajeFacturacion As Decimal, nombreYApellido As String, direccion As String, localidad As String, cuit As String, numeroFacturaOrigen As Integer) As IList(Of Integer)
            Dim notaCredito As NotaCreditoService = New NotaCreditoService(tipoFactura)
            Return notaCredito.ObtenerNumeroFactura(tipoCliente, condicionesIVA, pagos, productos, porcentajeFacturacion, nombreYApellido, direccion, localidad, cuit, numeroFacturaOrigen)
        End Function
    End Class
End Namespace