Imports System.ServiceModel

<ServiceBehavior(IncludeExceptionDetailInFaults:=True, UseSynchronizationContext:=False)>
Public Class Producto
    Implements IProducto

    Public Function GetProducto(ByVal IdProducto As Integer) As EntidadProducto Implements IProducto.GetProducto
        Negocio.Funciones.HayConexionInternet()

        Dim productosNegocio As Negocio.NegProductos = New Negocio.NegProductos()

        Dim producto As Entidades.Productos = productosNegocio.TraerProducto(IdProducto)

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

    Public Function GetProductoPorCodigoBarras(ByVal codigoBarras As String) As EntidadProducto Implements IProducto.GetProductoPorCodigoBarras
        Negocio.Funciones.HayConexionInternet()

        Dim productosNegocio As Negocio.NegProductos = New Negocio.NegProductos()

        Dim producto As Entidades.Productos = productosNegocio.TraerProductoPorCodBarra(codigoBarras)

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

    Public Function GetLista() As List(Of EntidadProductoReducido) Implements IProducto.GetLista
        Negocio.Funciones.HayConexionInternet()

        Dim productosNegocio As Negocio.NegProductos = New Negocio.NegProductos()

        Dim entidades As List(Of EntidadProductoReducido) = New List(Of EntidadProductoReducido)()

        Dim dsProductos As DataSet = productosNegocio.ListadoProductos(True)

        For Each dr As DataRow In dsProductos.Tables(0).Rows

            Dim entidad As EntidadProductoReducido = New EntidadProductoReducido()
            entidad.Codigo = dr("Codigo")
            entidad.Id = dr("id_Producto")
            entidad.Nombre = dr("Nombre")

            entidades.Add(entidad)
        Next

        Return entidades
    End Function

End Class
