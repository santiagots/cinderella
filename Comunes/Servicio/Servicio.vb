Imports Ventas.Data
Imports Common.Data.Repository
Imports Common.Core.Model
Imports Ventas.Data.Repository
Imports Ventas.Core.Interfaces
Imports Common.Core.Interfaces
Imports Common.Data
Imports Ventas.Core.Model.VentaAggregate

Namespace Comunes
    Public Class Servicio
        Friend Shared Sub ActualizarVenta(venta As Venta)
            Using context As VentaContext = New VentaContext()
                Dim ventaRepository As IVentaRepository = New VentaRepository(context)
                ventaRepository.Actualizar(venta)
            End Using
        End Sub

        Friend Shared Sub GuardarNotaCredito(notaCredito As NotaCredito)
            Using context As VentaContext = New VentaContext()
                Dim notaCreditoRepository As INotaCreditoRepository = New NotaCreditoRepository(context)
                notaCreditoRepository.Guardar(notaCredito)
            End Using
        End Sub

        Friend Shared Sub GuardarFactura(factura As Ventas.Core.Model.VentaAggregate.Factura)
            Using context As VentaContext = New VentaContext()
                Dim facturaRepository As IFacturaRepository = New FacturaRepository(context)
                facturaRepository.Guardar(factura)
            End Using
        End Sub

        Friend Shared Function ObtenerBancos() As IList(Of Banco)
            Using context As CommonContext = New CommonContext()
                Dim repository As Repository(Of Banco) = New Repository(Of Banco)(context)
                Return repository.List()
            End Using
        End Function

        Friend Shared Function ObtenerVenta(idVenta As Long) As Venta
            Using context As VentaContext = New VentaContext()
                Dim ventaRepository As IVentaRepository = New VentaRepository(context)
                Return ventaRepository.Obtener(idVenta)
            End Using
        End Function

        Friend Shared Function ObtenerClienteMayorista(id As Integer) As Object
            Using context As CommonContext = New CommonContext()
                Dim clienteMayoristaRepository As IClienteMayoristaRepository = New ClienteMayoristaRepository(context)
                Return clienteMayoristaRepository.Obtener(id)
            End Using
        End Function

        Friend Shared Function ObtenerReservaPorIdVenta(idVenta As Long) As Reserva
            Using context As VentaContext = New VentaContext()
                Dim reservaRepository As IReservaRepository = New ReservaRepository(context)
                Return reservaRepository.ObtenerPorIdVenta(idVenta)
            End Using
        End Function
    End Class
End Namespace