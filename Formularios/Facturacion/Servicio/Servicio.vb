Imports Common.Core.Enum
Imports Common.Service.Facturar
Imports Common.Service.NotaCredito
Imports Ventas.Core.Interfaces
Imports Model = Ventas.Core.Model.VentaAggregate
Imports Ventas.Data
Imports Ventas.Data.Repository
Imports Common.Core.ValueObjects

Namespace Formularios.Facturacion
    Public Class Servicio
        Friend Shared Function BuscarFactura(idSucursal As Integer, numeroFactura As Integer?, montoDesde As Decimal?, montoHasta As Decimal?, nombre As String, cuit? As Integer, fechaDesde As Date?, fechaHasta As Date?, tiposFacturas As List(Of TipoFactura)) As IEnumerable(Of Model.Factura)
            Using context As VentaContext = New VentaContext()
                Dim facturaRepository As IFacturaRepository = New FacturaRepository(context)
                Return facturaRepository.Buscar(idSucursal, numeroFactura, montoDesde, montoHasta, nombre, cuit, fechaDesde, fechaHasta, tiposFacturas)
            End Using
        End Function

        Friend Shared Function BuscarNotaCredito(idSucursal As Integer, numeroNotaCredito As Integer?, montoDesde As Decimal?, montoHasta As Decimal?, nombre As String, cuit As Integer?, fechaDesde As Date?, fechaHasta As Date?, tiposFacturas As List(Of TipoFactura)) As IEnumerable(Of Model.NotaCredito)
            Using context As VentaContext = New VentaContext()
                Dim NotaCreditoRepository As INotaCreditoRepository = New NotaCreditoRepository(context)
                Return NotaCreditoRepository.Buscar(idSucursal, numeroNotaCredito, montoDesde, montoHasta, nombre, cuit, fechaDesde, fechaHasta, tiposFacturas)
            End Using
        End Function

        Friend Shared Sub CierreZPorFecha(fechaDesde As Date, fechaHasta As Date)
            Dim facturar As FacturarService = New FacturarService(TipoFactura.Ticket)
            facturar.ObtenerCierreZPorFecha(fechaDesde, fechaHasta)
        End Sub

        Public Shared Sub CierreZ()
            Dim facturar As FacturarService = New FacturarService(TipoFactura.Ticket)
            facturar.ObtenerCierreZ()
        End Sub

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

        Public Shared Function ObtenerUltimoNumeroFactura(tipoFactura As TipoFactura) As Integer
            Using context As VentaContext = New VentaContext()
                Dim facturaRepository As IFacturaRepository = New FacturaRepository(context)
                Return facturaRepository.ObtenerUltimoNumeroFactura(tipoFactura)
            End Using
        End Function

        Public Shared Function FacturarService(tipoFactura As TipoFactura, tipoCliente As TipoCliente, condicionesIVA As CondicionIVA, pagos As IEnumerable(Of TicketPago), productos As IEnumerable(Of TicketProducto), porcentajeFacturacion As Decimal, nombreYApellido As String, direccion As String, localidad As String, cuit As String) As IList(Of Integer)
            Dim facturar As FacturarService = New FacturarService(tipoFactura)
            Return facturar.ObtenerNumeroFactura(tipoCliente, condicionesIVA, pagos, productos, porcentajeFacturacion, nombreYApellido, direccion, localidad, cuit)
        End Function

        Public Shared Function NotaCreditoService(tipoFactura As TipoFactura, tipoCliente As TipoCliente, condicionesIVA As CondicionIVA, pagos As IEnumerable(Of TicketPago), productos As IEnumerable(Of TicketProducto), porcentajeFacturacion As Decimal, nombreYApellido As String, direccion As String, localidad As String, cuit As String, numeroFacturaOrigen As Integer, puntoVentaOrigen As Integer, condicionIVAOriginal As CondicionIVA) As IList(Of Integer)
            Dim notaCredito As NotaCreditoService = New NotaCreditoService(tipoFactura)
            Return notaCredito.ObtenerNumeroFactura(tipoCliente, condicionesIVA, pagos, productos, porcentajeFacturacion, nombreYApellido, direccion, localidad, cuit, numeroFacturaOrigen, puntoVentaOrigen, condicionIVAOriginal)
        End Function
    End Class
End Namespace
