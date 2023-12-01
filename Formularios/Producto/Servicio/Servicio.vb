Imports Comex.Core.Interfaces
Imports Comex.Core.Model.ComexAggregate
Imports Comex.Data
Imports Comex.Data.Repository
Imports Common.Core.Enum
Imports Common.Core.Interfaces
Imports Common.Core.Model
Imports Common.Data.Repository
Imports Producto.Core.Interfaces
Imports Producto.Core.Model.ProductoAgreggate
Imports Producto.Data
Imports Producto.Data.Repository
Imports Model = Producto.Core.Model.ProductoAgreggate

Namespace Formularios.Producto
    Public Class Servicio
        Public Shared Function BuscarProductos(codigo As String, nombre As String, ordenadoPor As String, ordenarDireccion As OrdenadoDireccion, pagina As Integer, itemsPorPagina As Integer) As IList(Of Model.Producto)
            Using context As ProductoContext = New ProductoContext()
                Dim productoRepository As IProductoRepository = New ProductoRepository(context)
                Return productoRepository.Buscar(codigo, nombre, ordenadoPor, ordenarDireccion, pagina, itemsPorPagina)
            End Using
        End Function

        Public Shared Function BuscarSubcategorias(descripcion As String, categoria As Categoria, iva As IVA, habilitado As Boolean, ordenadoPor As String, ordenarDireccion As OrdenadoDireccion, pagina As Integer, itemsPorPagina As Integer, ByRef totalItems As Integer) As IList(Of SubCategoria)
            Using context As ProductoContext = New ProductoContext()
                Dim subCategoriaRepository As ISubCategoriaRepository = New SubCategoriaRepository(context)
                Return subCategoriaRepository.Buscar(descripcion, categoria, iva, habilitado, ordenadoPor, ordenarDireccion, pagina, itemsPorPagina, totalItems)
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

        Friend Shared Sub ActualizarCategorias(subCategoria As SubCategoria)
            Using context As ProductoContext = New ProductoContext()
                Dim subCategoriaRepository As ISubCategoriaRepository = New SubCategoriaRepository(context)
                subCategoriaRepository.Actualizar(subCategoria)
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

        Friend Shared Sub GuardarSubCategorias(subCategoria As SubCategoria)
            Using context As ProductoContext = New ProductoContext()
                Dim subCategoriaRepository As ISubCategoriaRepository = New SubCategoriaRepository(context)
                subCategoriaRepository.Guardar(subCategoria)
            End Using
        End Sub

        Friend Shared Function ObtenerProducto(idProducto As Integer) As Model.Producto
            Using context As ProductoContext = New ProductoContext()
                Dim productoRepository As IProductoRepository = New ProductoRepository(context)
                Return productoRepository.ObtenerProducto(idProducto)
            End Using
        End Function

        Public Shared Function ObtenerCategorias() As IList(Of Categoria)
            Using context As ProductoContext = New ProductoContext()
                Dim categoriaRepository As ICategoriaRepository = New CategoriaRepository(context)
                Return categoriaRepository.Obtener()
            End Using
        End Function

        Public Shared Function ObtenerIVAs() As IList(Of IVA)
            Using context As ProductoContext = New ProductoContext()
                Dim ivaRepository As IIVARepository = New IVARepository(context)
                Return ivaRepository.Obtener()
            End Using
        End Function

        Public Shared Function ObtenerSubcategoriasPorCategoria(idCategoria As Integer) As IList(Of SubCategoria)
            Using context As ProductoContext = New ProductoContext()
                Dim subCategoriaRepository As ISubCategoriaRepository = New SubCategoriaRepository(context)
                Return subCategoriaRepository.ObtenerPorCategoria(idCategoria)
            End Using
        End Function

        Public Shared Function ObtenerSubcategorias(idSubCategorias As Integer) As SubCategoria
            Using context As ProductoContext = New ProductoContext()
                Dim subCategoriaRepository As ISubCategoriaRepository = New SubCategoriaRepository(context)
                Return subCategoriaRepository.Obtener(idSubCategorias)
            End Using
        End Function

        Public Shared Function ObtenerProveedores() As IList(Of Model.Proveedor)
            Using context As ProductoContext = New ProductoContext()
                Dim proveedorRepository As IProveedorRepository = New ProveedorRepository(context)
                Return proveedorRepository.Obtener()
            End Using
        End Function

        Friend Shared Function BuscarColores(nombre As String) As List(Of Model.Color)
            Using context As ProductoContext = New ProductoContext()
                Dim colorRepository As IColorRepository = New ColorRepository(context)
                Return colorRepository.Buscar(nombre)
            End Using
        End Function

        Friend Shared Sub AltaColor(color As Model.Color)
            Using context As ProductoContext = New ProductoContext()
                Dim supplierRepository As IRepository(Of Model.Color) = New Repository(Of Model.Color)(context)
                supplierRepository.Insert(color)
            End Using
        End Sub

        Friend Shared Sub ModificarColor(color As Model.Color)
            Using context As ProductoContext = New ProductoContext()
                Dim colorRepository As IColorRepository = New ColorRepository(context)
                colorRepository.Actualizar(color)
            End Using
        End Sub

        Friend Shared Function ObtenerColor(id As Integer) As Model.Color
            Using context As ProductoContext = New ProductoContext()
                Dim colorRepository As IRepository(Of Model.Color) = New Repository(Of Model.Color)(context)
                Return colorRepository.GetById(id)
            End Using
        End Function

        Friend Shared Function BuscarTipoProducto(nombre As String) As List(Of Model.TipoProducto)
            Using context As ProductoContext = New ProductoContext()
                Dim tipoProductoRepository As ITipoProductoRepository = New TipoProductoRepository(context)
                Return tipoProductoRepository.Buscar(nombre)
            End Using
        End Function

        Friend Shared Sub AltaTipoProducto(tipoProducto As Model.TipoProducto)
            Using context As ProductoContext = New ProductoContext()
                Dim tipoProductoRepository As IRepository(Of Model.TipoProducto) = New Repository(Of Model.TipoProducto)(context)
                tipoProductoRepository.Insert(tipoProducto)
            End Using
        End Sub

        Friend Shared Sub ModificarTipoProducto(tipoProducto As Model.TipoProducto)
            Using context As ProductoContext = New ProductoContext()
                Dim tipoProductoRepository As ITipoProductoRepository = New TipoProductoRepository(context)
                tipoProductoRepository.Actualizar(tipoProducto)
            End Using
        End Sub

        Friend Shared Function ObtenerTipoProducto(id As Integer) As Model.TipoProducto
            Using context As ProductoContext = New ProductoContext()
                Dim tipoProductoRepository As IRepository(Of Model.TipoProducto) = New Repository(Of Model.TipoProducto)(context)
                Return tipoProductoRepository.GetById(id)
            End Using
        End Function

        Public Shared Function ObtenerSupplier(id As Long) As Supplier
            Using context As ProductoContext = New ProductoContext()
                Dim supplierRepository As IRepository(Of Supplier) = New Repository(Of Supplier)(context)
                Return supplierRepository.GetById(id)
            End Using
        End Function

        Public Shared Sub AltaSupplier(supplier As Supplier)
            Using context As ProductoContext = New ProductoContext()
                Dim supplierRepository As IRepository(Of Supplier) = New Repository(Of Supplier)(context)
                supplierRepository.Insert(supplier)
            End Using
        End Sub

        Public Shared Sub ModificarSupplier(supplier As Supplier)
            Using context As ProductoContext = New ProductoContext()
                Dim supplierRepository As ISupplierRepository = New SupplierRepository(context)
                supplierRepository.Actualizar(supplier)
            End Using
        End Sub

        Public Shared Function BuscarSupplier(nombre As String) As List(Of Supplier)
            Using context As ProductoContext = New ProductoContext()
                Dim supplierRepository As ISupplierRepository = New SupplierRepository(context)
                Return supplierRepository.Buscar(nombre)
            End Using
        End Function
    End Class
End Namespace
