Imports Common.Core.Enum
Imports Common.Core.Interfaces
Imports Common.Data
Imports Common.Data.Repository
Imports Common.Service.Facturar
Imports Ventas.Core.Enum
Imports Ventas.Core.Interfaces
Imports Ventas.Core.Model.BaseAgreggate
Imports Ventas.Core.Model.NotaPedidoAgreggate
Imports Ventas.Core.Model.VentaAggregate
Imports Ventas.Data
Imports Ventas.Data.Repository
Imports Common.Core.ValueObjects

Namespace Formularios.Reserva
    Public Class Servicio
        Public Shared Function BuscarReserva(idSucursal As Integer, entregada As Boolean, nombre As String, fechaAlta As DateTime?, fechaRetiro As DateTime?, metodoEntrega As ReservaMetodoEntrega?) As IList(Of Ventas.Core.Model.VentaAggregate.Reserva)
            Using context As VentaContext = New VentaContext()
                Dim reservaRepository As IReservaRepository = New ReservaRepository(context)
                Return reservaRepository.Buscar(idSucursal, entregada, nombre, fechaAlta, fechaRetiro, metodoEntrega)
            End Using
        End Function

        Friend Shared Function EliminarReserva(id As Long) As Object
            Using context As VentaContext = New VentaContext()
                Dim reservaRepository As IReservaRepository = New ReservaRepository(context)
                reservaRepository.Eliminar(id)
            End Using
        End Function

        Friend Shared Function ObtenerReserva(idReserva As Long) As Object
            Using context As VentaContext = New VentaContext()
                Dim reservaRepository As IReservaRepository = New ReservaRepository(context)
                Return reservaRepository.Obtener(idReserva)
            End Using
        End Function
    End Class
End Namespace