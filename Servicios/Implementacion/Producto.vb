Imports System.ServiceModel

<ServiceBehavior(IncludeExceptionDetailInFaults:=True)>
Public Class Producto
    Implements IProducto

    Public Function GetProducto(ByVal codigoProducto As String) As Entidades.Productos Implements IProducto.GetProducto
        Dim productosNegocio As Negocio.NegProductos = New Negocio.NegProductos()

        Dim producto As Entidades.Productos = productosNegocio.TraerProductoPorCodigo(codigoProducto)

        Return producto
    End Function

End Class
