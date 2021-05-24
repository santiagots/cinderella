Imports Common.Core.Enum
Imports Ventas.Core.Interfaces
Imports Model = Ventas.Core.Model.VentaAggregate
Imports Ventas.Data
Imports Ventas.Data.Repository
Imports System.Text
Imports Factura.Service.Factura
Imports Common.Core.Interfaces
Imports Common.Data.Repository
Imports Common.Core.Model

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
            Dim facturar As FacturarService = New FacturarService(TipoFactura.Ticket, "", "")
            facturar.ObtenerCierreZPorFecha(fechaDesde, fechaHasta)
        End Sub

        Friend Shared Sub CierreZPorJornada(controladorFiscalJornadaDesde As Integer, controladorFiscalJornadaHasta As Integer)
            Dim facturar As FacturarService = New FacturarService(TipoFactura.Ticket, "", "")
            facturar.ObtenerCierreZPorJornada(controladorFiscalJornadaDesde, controladorFiscalJornadaHasta)
        End Sub

        Friend Shared Sub CintaTestigoDigitalPorFecha(fechaDesde As Date, fechaHasta As Date, ByRef nombre As String, ByRef datos As StringBuilder)
            Dim facturar As FacturarService = New FacturarService(TipoFactura.Ticket, "", "")
            facturar.ObtenerCintaTestigoDigitalPorFecha(fechaDesde, fechaHasta, nombre, datos)
        End Sub

        Friend Shared Sub CintaTestigoDigitalPorJornada(ControladorFiscalJornadaDesde As Integer, ControladorFiscalJornadaHasta As Integer, ByRef nombre As String, ByRef datos As StringBuilder)
            Dim facturar As FacturarService = New FacturarService(TipoFactura.Ticket, "", "")
            facturar.ObtenerCintaTestigoDigitalPorJornada(ControladorFiscalJornadaDesde, ControladorFiscalJornadaHasta, nombre, datos)
        End Sub

        Friend Shared Sub BorradoJornadasMemoriaTransacciones(borradasJornadasHasta As Integer)
            Dim facturar As FacturarService = New FacturarService(TipoFactura.Ticket, "", "")
            facturar.BorradoJornadasMemoriaTransacciones(borradasJornadasHasta)
        End Sub

        Friend Shared Sub DuplicadosDocumentosTipoAPorFecha(fechaDesde As Date, fechaHasta As Date, ByRef nombre As String, ByRef datos As StringBuilder)
            Dim facturar As FacturarService = New FacturarService(TipoFactura.Ticket, "", "")
            facturar.ObtenerDuplicadosDocumentosTipoAPorFecha(fechaDesde, fechaHasta, nombre, datos)
        End Sub

        Friend Shared Sub DuplicadosDocumentosTipoAPorJornada(ControladorFiscalJornadaDesde As Integer, ControladorFiscalJornadaHasta As Integer, ByRef nombre As String, ByRef datos As StringBuilder)
            Dim facturar As FacturarService = New FacturarService(TipoFactura.Ticket, "", "")
            facturar.ObtenerDuplicadosDocumentosTipoAPorJornada(ControladorFiscalJornadaDesde, ControladorFiscalJornadaHasta, nombre, datos)
        End Sub

        Friend Shared Sub ResumenTotalesPorRangoDeFecha(fechaDesde As Date, fechaHasta As Date, ByRef nombre As String, ByRef datos As StringBuilder)
            Dim facturar As FacturarService = New FacturarService(TipoFactura.Ticket, "", "")
            facturar.ObtenerResumenTotalesPorRangoDeFecha(fechaDesde, fechaHasta, nombre, datos)
        End Sub

        Friend Shared Sub ResumenTotalesPorRangoDeJornadaFiscal(ControladorFiscalJornadaDesde As Integer, ControladorFiscalJornadaHasta As Integer, ByRef nombre As String, ByRef datos As StringBuilder)
            Dim facturar As FacturarService = New FacturarService(TipoFactura.Ticket, "", "")
            facturar.ObtenerResumenTotalesPorRangoDeJornadaFiscal(ControladorFiscalJornadaDesde, ControladorFiscalJornadaHasta, nombre, datos)
        End Sub

        Public Shared Sub CierreZ()
            Dim facturar As FacturarService = New FacturarService(TipoFactura.Ticket, "", "")
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

        Public Shared Function ObtenerUltimoNumeroFactura(idSucursal As Integer, tipoFactura As TipoFactura) As Integer
            Using context As VentaContext = New VentaContext()
                Dim facturaRepository As IFacturaRepository = New FacturaRepository(context)
                Return facturaRepository.ObtenerUltimoNumeroFactura(idSucursal, tipoFactura)
            End Using
        End Function

        Public Shared Sub ObtenerMemoriaTransacciones(ByRef cintaTestigoDigitalDisponiblesDesde As Integer,
                                                           ByRef cintaTestigoDigitalDisponiblesHasta As Integer,
                                                           ByRef descargarDuplicadosTipoADisponiblesDesde As Integer,
                                                           ByRef descargarDuplicadosTipoADisponiblesHasta As Integer,
                                                           ByRef resumenTotalesDisponiblesDesde As Integer,
                                                           ByRef resumenTotalesDisponiblesHasta As Integer,
                                                           ByRef jornadasDescargadasCompletamenteDesde As Integer,
                                                           ByRef jornadasDescargadasCompletamenteHasta As Integer,
                                                           ByRef jornadasBorradasDesde As Integer,
                                                           ByRef jornadasBorradasHasta As Integer)

            Dim facturar As FacturarService = New FacturarService(TipoFactura.Ticket, "", "")

            facturar.ObtenerMemoriaTransacciones(cintaTestigoDigitalDisponiblesDesde,
                                                 cintaTestigoDigitalDisponiblesHasta,
                                                 descargarDuplicadosTipoADisponiblesDesde,
                                                 descargarDuplicadosTipoADisponiblesHasta,
                                                 resumenTotalesDisponiblesDesde,
                                                 resumenTotalesDisponiblesHasta,
                                                 jornadasDescargadasCompletamenteDesde,
                                                 jornadasDescargadasCompletamenteHasta,
                                                 jornadasBorradasDesde,
                                                 jornadasBorradasHasta)
        End Sub

        Public Shared Function ObtenerIVA(porcentaje As Decimal) As IVA
            Using context As VentaContext = New VentaContext()
                Dim ivaRepository As IIVARepository = New IVARepository(context)
                Return ivaRepository.Obtener(porcentaje)
            End Using
        End Function

    End Class
End Namespace
