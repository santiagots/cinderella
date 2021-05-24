Public Class OrdenCompra
    Public Property idOrdenCompra As Int64
    Public Property idEncargado As Integer
    Public Property NombreEncargado As String
    Public Property Fecha As DateTime
    Public Property idProveedor As Integer
    Public Property NombreProveedor As String
    Public Property idSucursal As Integer
    Public Property NombreSucursal As String
    Public Property Detalles As List(Of OrdenCompraDetalle)
    Public Property FechaEdicion As DateTime
    Public Property Estado As OrdenCompraPedidoEstado
    Public Property Tipo As OrdenCompraPedidoTipo
End Class
