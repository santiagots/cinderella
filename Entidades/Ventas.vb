Public Class Ventas
    Public Property id_Venta As Int64
    Public Property id_Sucursal As Integer
    Public Property id_TipoPago As Integer
    Public Property id_Empleado As Integer
    Public Property id_Encargado As Integer
    Public Property id_TipoVenta As Integer
    Public Property id_ListaPrecio As Integer
    Public Property id_Cliente As Integer
    Public Property id_ClienteMinorista As Integer
    Public Property id_Tarjeta As Integer
    Public Property CantidadCuotas As Integer
    Private PorcentajeFacturacion_ As Double
    Public Property PorcentajeFacturacion As Double
    Public Property Anulado As Integer
    Public Property Habilitado As Integer
    Public Property Facturado As Integer
    Public Property CantidadTotal As Integer
    Public Property PrecioTotal As Double
    Public Property Descuento As Double
    Public Property CostoFinanciero As Double
    Public Property SubTotal As Double
    Public Property Fecha As Date
    Public Property DiferenciaPagoCheque As Double
    Public Property MontoSenia As Double
    Public Property Senia As Boolean
    Public Property FechaEdicion As DateTime
End Class
