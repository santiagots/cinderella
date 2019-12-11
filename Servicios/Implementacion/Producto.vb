Imports Model = Ventas.Core.Model.BaseAgreggate
Imports System.ServiceModel
Imports AutoMapper

<ServiceBehavior(IncludeExceptionDetailInFaults:=True, UseSynchronizationContext:=False)>
Public Class Producto
    Implements IProducto

    Public Function GetProducto(ByVal idSucursal As Integer, ByVal idProducto As Integer) As EntidadProducto Implements IProducto.GetProducto
        Dim producto As Model.Producto = Servicio.ObtenerProductoCompleto(idSucursal, idProducto)
        Return Mapper.Map(Of EntidadProducto)(producto)
    End Function

    Public Function GetProductoPorCodigoBarras(ByVal idSucursal As Integer, ByVal codigoBarras As String) As EntidadProducto Implements IProducto.GetProductoPorCodigoBarras
        Dim producto As Model.Producto = Servicio.ObtenerProductoCompleto(idSucursal, codigoBarras)
        Return Mapper.Map(Of EntidadProducto)(producto)
    End Function

    Public Function GetLista() As List(Of EntidadProductoReducido) Implements IProducto.GetLista
        Dim productos As List(Of Model.Producto) = Servicio.ObtenerListaProductos()
        Return Mapper.Map(Of List(Of EntidadProductoReducido))(productos)
    End Function

End Class
