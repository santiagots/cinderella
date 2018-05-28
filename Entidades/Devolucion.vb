Public Class Devolucion
    Public Property id_Devolucion As Int64
    Public Property id_Sucursal As Integer
    Public Property id_TipoPago As Integer
    Public Property id_Empleado As Integer
    Public Property id_Encargado As Integer
    Public Property id_TipoDevolucion As Integer
    Public Property id_Cliente As Integer
    Public Property Habilitado As Integer
    Public Property NotaCredito As Integer
    Public Property CantidadTotal As Integer
    Public Property PrecioTotal As Double
    Public Property Descuento As Double
    Public Property PorcentajeFacturacion As Double
    Public Property SubTotal As Double
    Public Property Fecha As Date
    Public Property FechaEdicion As Date
    Public Property Detalle As List(Of Entidades.Devolucion_Detalle)
End Class
