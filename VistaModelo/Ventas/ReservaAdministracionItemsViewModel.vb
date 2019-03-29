Imports Ventas.Core.Enum

Namespace VistaModelo.Ventas
    Public Class ReservaAdministracionItemsViewModel
        Public Property Id As Long
        Public Property Nombre As String
        Public Property MontoTotal As Decimal
        Public Property MontoReserva As Decimal
        Public Property FechaAlta As DateTime
        Public Property FechaEstimadaRetiro As DateTime
        Public Property MetodoEntrega As ReservaMetodoEntrega
    End Class
End Namespace
