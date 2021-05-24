Public Class Presupuesto
    Public Property id_Presupuesto As Int64
    Public Property id_Sucursal As Integer
    Public Property NombreSucursal As String
    Public Property id_TipoPago As Integer
    Public Property id_Tarjeta As Integer
    Public Property CantidadCuotas As Integer
    Public Property DescripcionTipoPago As String
    Public Property id_Empleado As Integer
    Public Property VendedorNombreyApellido As String
    Public Property id_Encargado As Integer
    Public Property id_Venta As Int64
    Public Property EncargadoNombreyApellido As String
    Public Property id_TipoVenta As Integer
    Public Property id_ListaPrecio As Integer
    Public Property id_ClienteMayorista As Integer
    Public Property RazonSocialClienteMayorista As String
    Public Property id_ClienteMinorista As Integer
    Public Property Anulado As Boolean
    Public Property DescripcionAnulado As String
    Public Property Total As Double
    Public Property Descuento As Double
    Public Property CostoFinanciero As Double
    Public Property SubTotal As Double
    Public Property Fecha As Date
    Public Property FechaAnulado As Date
    Public Property FechaEdcion As DateTime
End Class
