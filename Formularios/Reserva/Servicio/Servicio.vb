Imports Ventas.Core.Enum
Imports Ventas.Core.Interfaces
Imports Ventas.Data
Imports Ventas.Data.Repository

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