Imports Producto.Core.Interfaces
Imports Model = Producto.Core.Model.ProductoAgreggate
Imports Producto.Data
Imports Producto.Data.Repository
Imports Producto.Core.Model.ProductoAgreggate

Namespace Formularios.Producto
    Public Class Servicio
        Public Shared Function BuscarProductos(codigo As String, nombre As String, pagina As Integer, itemsPorPagina As Integer) As IList(Of Model.Producto)
            Using context As ProductoContext = New ProductoContext()
                Dim productoRepository As IProductoRepository = New ProductoRepository(context)
                Return productoRepository.Buscar(codigo, nombre, pagina, itemsPorPagina)
            End Using
        End Function

        Public Shared Function BuscarTotalProductos(codigo As String, nombre As String) As Integer
            Using context As ProductoContext = New ProductoContext()
                Dim productoRepository As IProductoRepository = New ProductoRepository(context)
                Return productoRepository.BuscarTotal(codigo, nombre)
            End Using
        End Function

        Friend Shared Sub ActualizarProducto(porducto As Model.Producto)
            Using context As ProductoContext = New ProductoContext()
                Dim productoRepository As IProductoRepository = New ProductoRepository(context)
                productoRepository.Actualizar(porducto)
            End Using
        End Sub

        Friend Shared Sub EliminarProducto(idProducto As Integer)
            Using context As ProductoContext = New ProductoContext()
                Dim productoRepository As IProductoRepository = New ProductoRepository(context)
                productoRepository.Eliminar(idProducto)
            End Using
        End Sub

        Friend Shared Sub GuardarProducto(porducto As Model.Producto)
            Using context As ProductoContext = New ProductoContext()
                Dim productoRepository As IProductoRepository = New ProductoRepository(context)
                productoRepository.Guardar(porducto)
            End Using
        End Sub

        Friend Shared Function ObtenerProducto(idProducto As Integer) As Model.Producto
            Using context As ProductoContext = New ProductoContext()
                Dim productoRepository As IProductoRepository = New ProductoRepository(context)
                Return productoRepository.ObtenerProducto(idProducto)
            End Using
        End Function

        Public Shared Function ObtenerCategorias() As IList(Of Model.Categoria)
            Using context As ProductoContext = New ProductoContext()
                Dim productoRepository As IProductoRepository = New ProductoRepository(context)
                Return productoRepository.ObtenerCategorias()
            End Using
        End Function

        Public Shared Function ObtenerSubcategorias(idCategoria As Integer) As IList(Of Model.SubCategoria)
            Using context As ProductoContext = New ProductoContext()
                Dim productoRepository As IProductoRepository = New ProductoRepository(context)
                Return productoRepository.ObtenerSubcategorias(idCategoria)
            End Using
        End Function

        Public Shared Function ObtenerProveedores() As IList(Of Model.Proveedor)
            Using context As ProductoContext = New ProductoContext()
                Dim productoRepository As IProductoRepository = New ProductoRepository(context)
                Return productoRepository.ObtenerProveedores()
            End Using
        End Function

    End Class
End Namespace
