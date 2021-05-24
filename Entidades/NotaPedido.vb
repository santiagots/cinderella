Public Class NotaPedido
    Public Property id_NotaPedido As Int64
    Public Property id_Sucursal As Integer
    Public Property id_TipoPago As Integer
    Public Property id_Encargado As Integer
    Public Property id_Empleado As Integer
    Public Property EmpleadoNombreyApellido As String
    Public Property id_TipoVenta As Integer
    Public Property Id_Tarjeta As Integer
    Public Property Numero As Integer
    Public Property CantidadCuotas As Integer
    Public Property id_Cliente As Integer
    Public Property RazonSocialCliente As String
    Public Property PorcentajeFacturacion As Double
    Public Property PrecioTotal As Double
    Public Property PorcentajeDescuento As Double
    Public Property Fecha As Date
    Public Property Id_ConsumidorFinal As Int64
    Public Property ConsumidorFinalNombreYApellido As String
    Public Property Vendida As Boolean
    Public Property TipoVentaDescripcion As String
    Public Property TipoPagoDescripcion As String
    Public Property id_ListaPrecio As Integer
    Public Property FechaEdicion As DateTime
End Class
