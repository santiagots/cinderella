Imports Common.Core.Enum

Namespace Formularios.Venta
    Public Class VentaAdministracionItemViewModel
        Public Property Id As Long
        Public Property Numero As String
        Public Property NumeroFactura As String
        Public Property TipoCliente As TipoCliente
        Public Property TipoPago As String
        Public Property TipoFactura As String
        Public Property NombreVendedor As String
        Public Property NombreClienteMayorista As String
        Public Property MontoTotal As Decimal
        Public Property Fecha As DateTime
        Public Property Anulado As Boolean
    End Class
End Namespace
