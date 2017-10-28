Public Enum TipoFactura
    Ticket = 0
    Manual = 1
    Electronica = 2
End Enum


Public Class Facturacion
    Public Property id_Facturacion As Int64
    Public Property id_Venta As Int64
    Public Property id_NotaCredito As Int64
    Public Property NumeroFactura As String
    Public Property Monto As Double
    Public Property TipoFactura As String
    Public Property CondicionIva As String
    Public Property Nombre As String
    Public Property Direccion As String
    Public Property Localidad As String
    Public Property Cuit As String
    Public Property Fecha As Date
    Public Property TipoRecibo As TipoFactura
    Public Property IdSucursal As Integer
    Public Property PuntoVenta As Integer
    Public Property IVA As Double
    Public Property SubTotal As Double
End Class
