Imports System.ServiceModel

<ServiceBehavior(IncludeExceptionDetailInFaults:=True)>
Public Class Producto
    Implements IProducto

    Public Function GetProducto(ByVal codigoProducto As String) As EntidadProducto Implements IProducto.GetProducto
        Dim productosNegocio As Negocio.NegProductos = New Negocio.NegProductos()

        Dim producto As Entidades.Productos = productosNegocio.TraerProductoPorCodigo(codigoProducto)

        Dim entProducto As EntidadProducto = New EntidadProducto()
        entProducto.Codigo = producto.Codigo
        entProducto.id_Producto = producto.id_Producto
        entProducto.Nombre = producto.Nombre
        entProducto.Precio1 = producto.Precio1
        entProducto.Precio2 = producto.Precio2
        entProducto.Precio3 = producto.Precio3
        entProducto.Precio4 = producto.Precio4
        entProducto.Precio5 = producto.Precio5
        entProducto.Precio6 = producto.Precio6

        Return entProducto
    End Function

End Class
