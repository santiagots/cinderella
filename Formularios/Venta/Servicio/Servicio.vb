Imports Common.Core.Enum
Imports Ventas.Core.Interfaces
Imports Model = Ventas.Core.Model.VentaAggregate
Imports Ventas.Data
Imports Ventas.Data.Repository

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
    End Class
End Namespace