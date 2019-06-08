Imports Common.Core.Enum
Imports Ventas.Core.Enum

Namespace VistaModelo.Ventas
    Public Class NotaPedidoItemsViewModel
        Public Property Id As Long
        Public Property Numero As Integer
        Public Property TipoCliente As TipoCliente
        Public Property Vendedor As String
        Public Property MontoTotal As Decimal
        Public Property Fecha As DateTime
        Public Property Estado As NotaPedidoEstado
        Public Property NombreCliente As String
    End Class
End Namespace
