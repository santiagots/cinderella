Imports System.ComponentModel
Imports System.Threading.Tasks
Imports AutoMapper
Imports Model = Producto.Core.Model.ProductoAgreggate

Namespace Formularios.Producto
    Public Class frmProductosViewModel
        Inherits Comunes.Common

        Private PaginaActual As Integer = 1
        Private TotalPaginas As Integer = 0
        Private TotalProductos As Integer = 0

        Private ItemsPorPaginas As Integer = My.Settings.PaginacionItemsPagina

        Private ProductoDetalleSeleccionadoModel As Model.Producto


        Public Property FiltroPorCodigo As Boolean
        Public Property FiltroPorNombre As Boolean
        Public Property Filtro As String
        Public Property Productos As BindingList(Of ProductoItemViewModel)
        Public Property ListaProductos As BindingList(Of ProductoItemViewModel)()
        Public Property ProductoNuevo As ProductoDetalleViewModel
        Public Property ProductoDetalle As ProductoDetalleViewModel
        Public ReadOnly Property SinResultados() As Boolean
            Get
                Return TotalProductos = 0
            End Get
        End Property
        Public Property Categorias As BindingList(Of Model.Categoria)
        Public Property SubCategorias As BindingList(Of Model.SubCategoria)
        Public Property Provedores As BindingList(Of Model.Proveedor)

        Public Sub New()
            Productos = New BindingList(Of ProductoItemViewModel)()
            ProductoNuevo = New ProductoDetalleViewModel()
            ProductoDetalle = New ProductoDetalleViewModel()
            FiltroPorCodigo = True
            ReDim Preserve ListaProductos(0)
        End Sub

        Friend Async Function AgregarProductoAsync() As Task
            Dim listadoPrecios As List(Of Model.Precio) = New List(Of Model.Precio)()
            listadoPrecios.Add(New Model.Precio(1, ProductoNuevo.ListaTigre))
            listadoPrecios.Add(New Model.Precio(2, ProductoNuevo.PorcentajeDescuentoTigre))
            listadoPrecios.Add(New Model.Precio(3, ProductoNuevo.ListaCapital))
            listadoPrecios.Add(New Model.Precio(4, ProductoNuevo.PorcentajeDescuentoCapital))
            listadoPrecios.Add(New Model.Precio(5, ProductoNuevo.Mayorista))
            listadoPrecios.Add(New Model.Precio(6, ProductoNuevo.Alternativo))

            Dim ProductoNuevoModel As Model.Producto = New Model.Producto(ProductoNuevo.Categoria,
                                                                          ProductoNuevo.SubCategoria,
                                                                          ProductoNuevo.Proveedor,
                                                                          ProductoNuevo.Nombre,
                                                                          ProductoNuevo.Descripcion,
                                                                          ProductoNuevo.Costo,
                                                                          ProductoNuevo.Origen,
                                                                          ProductoNuevo.Tamanio,
                                                                          ProductoNuevo.Codigo,
                                                                          ProductoNuevo.FotoRuta,
                                                                          ProductoNuevo.Habilitado,
                                                                          ProductoNuevo.Novedad,
                                                                          ProductoNuevo.SubirAWeb,
                                                                          listadoPrecios)

            Await Task.Run(Sub() Servicio.GuardarProducto(ProductoNuevoModel))
        End Function

        Friend Async Function ModificarProductoAsync() As Task
            ProductoDetalleSeleccionadoModel.Precios(0).ActualizarMonto(ProductoDetalle.ListaTigre)
            ProductoDetalleSeleccionadoModel.Precios(1).ActualizarMonto(ProductoDetalle.PorcentajeDescuentoTigre)
            ProductoDetalleSeleccionadoModel.Precios(2).ActualizarMonto(ProductoDetalle.ListaCapital)
            ProductoDetalleSeleccionadoModel.Precios(3).ActualizarMonto(ProductoDetalle.PorcentajeDescuentoCapital)
            ProductoDetalleSeleccionadoModel.Precios(4).ActualizarMonto(ProductoDetalle.Mayorista)
            ProductoDetalleSeleccionadoModel.Precios(5).ActualizarMonto(ProductoDetalle.Alternativo)

            ProductoDetalleSeleccionadoModel.ActualizarDatos(ProductoDetalle.Categoria,
                                                        ProductoDetalle.SubCategoria,
                                                        ProductoDetalle.Proveedor,
                                                        ProductoDetalle.Nombre,
                                                        ProductoDetalle.Descripcion,
                                                        ProductoDetalle.Costo,
                                                        ProductoDetalle.Origen,
                                                        ProductoDetalle.Tamanio,
                                                        ProductoDetalle.Codigo,
                                                        ProductoDetalle.FotoRuta,
                                                        ProductoDetalle.Habilitado,
                                                        ProductoDetalle.Novedad,
                                                        ProductoDetalle.SubirAWeb)

            Await Task.Run(Sub() Servicio.ActualizarProducto(ProductoDetalleSeleccionadoModel))
        End Function

        Friend Async Function EliminarProductoAsync(idProducto As Integer) As Task
            Await Task.Run(Sub() Servicio.EliminarProducto(idProducto))
        End Function


        Friend Async Function CargarDatosAsync() As Task
            Dim tareas As List(Of Task) = New List(Of Task)()
            tareas.Add(BuscarProductosAsync())
            tareas.Add(CargarCategoriasAsync())
            tareas.Add(CargarProveedoresAsync())
            tareas.Add(CargarTotalProductosAsync())
            Await Task.WhenAll(tareas)
        End Function

        Friend Async Function RestablecerProductosAsync() As Task
            Filtro = String.Empty
            Await BuscarProductosAsync()
        End Function

        Friend Async Function BuscarProductosAsync() As Task
            Await CargarTotalProductosAsync()
            TotalPaginas = TotalProductos / ItemsPorPaginas

            Array.Clear(ListaProductos, 0, ListaProductos.Length)
            ReDim Preserve ListaProductos(TotalPaginas)

            Await BuscarPrimerPaginaAsync()

            NotifyPropertyChanged(NameOf(Me.ListaProductos))
        End Function

        Friend Async Function BuscarPaginaSiguienteAsync() As Task
            PaginaActual += 1

            Await BuscarPaginaActualAsync(False)
        End Function

        Friend Async Function BuscarUltimaPaginaAsync() As Task
            PaginaActual = TotalPaginas

            Await BuscarPaginaActualAsync(False)
        End Function

        Friend Async Function BuscarPaginaAnteriorAsync() As Task
            PaginaActual -= 1

            Await BuscarPaginaActualAsync(False)
        End Function

        Friend Async Function BuscarPrimerPaginaAsync() As Task
            PaginaActual = 1

            Await BuscarPaginaActualAsync(False)
        End Function

        Friend Async Function BuscarPaginaActualAsync(forzarReacarga As Boolean) As Task
            If (ListaProductos(PaginaActual - 1) Is Nothing OrElse forzarReacarga) Then
                Me.ListaProductos(PaginaActual - 1) = New BindingList(Of ProductoItemViewModel)(Await CargarProductosAsync())
            End If
            Productos = Me.ListaProductos(PaginaActual - 1)
            NotifyPropertyChanged(NameOf(Me.Productos))
        End Function

        Friend Async Function CargarProductoAsync(idProducto As Integer) As Task
            Dim productosModel As Model.Producto = Await Task.Run(Function() Servicio.ObtenerProducto(idProducto))

            Await CargarSubcategoriasAsync(productosModel.IdCategoria)

            ProductoDetalleSeleccionadoModel = productosModel

            ProductoDetalle = Mapper.Map(Of ProductoDetalleViewModel)(productosModel)
        End Function

        Friend Async Function CargarProductosAsync() As Task(Of List(Of ProductoItemViewModel))
            Dim nombre As String = If(FiltroPorNombre, Filtro, Nothing)
            Dim codigo As String = If(FiltroPorCodigo, Filtro, Nothing)

            Dim productosModel As IList(Of Model.Producto) = Await Task.Run(Function() Servicio.BuscarProductos(codigo, nombre, PaginaActual, ItemsPorPaginas))
            Return Mapper.Map(Of List(Of ProductoItemViewModel))(productosModel)
        End Function

        Friend Async Function CargarTotalProductosAsync() As Task
            Dim nombre As String = If(FiltroPorNombre, Filtro, Nothing)
            Dim codigo As String = If(FiltroPorCodigo, Filtro, Nothing)

            TotalProductos = Await Task.Run(Function() Servicio.BuscarTotalProductos(codigo, nombre))
        End Function

        Public Async Function LimpiarProductoNuevo() As Task
            ProductoNuevo = New ProductoDetalleViewModel()
            ProductoNuevo.Categoria = Categorias.First()
            Await CargarSubcategoriasAsync(ProductoNuevo.Categoria.Id)
            ProductoNuevo.Proveedor = Provedores.First()
        End Function

        Private Async Function CargarCategoriasAsync() As Task
            Dim categoriaModel As IList(Of Model.Categoria) = Await Task.Run(Function() Servicio.ObtenerCategorias())

            Me.ProductoNuevo.Categoria = categoriaModel.First()
            Me.Categorias = New BindingList(Of Model.Categoria)(categoriaModel)
            NotifyPropertyChanged(NameOf(Me.Categorias))
        End Function

        Friend Async Function CargarSubcategoriasAsync(idCategoria As Integer) As Task
            Dim subCategoriaModel As IList(Of Model.SubCategoria) = Await Task.Run(Function() Servicio.ObtenerSubcategorias(idCategoria))
            Me.SubCategorias = New BindingList(Of Model.SubCategoria)(subCategoriaModel)
            NotifyPropertyChanged(NameOf(Me.SubCategorias))
        End Function

        Private Async Function CargarProveedoresAsync() As Task
            Dim proveedoresModel As IList(Of Model.Proveedor) = Await Task.Run(Function() Servicio.ObtenerProveedores())

            Me.ProductoNuevo.Proveedor = proveedoresModel.First()
            Me.Provedores = New BindingList(Of Model.Proveedor)(proveedoresModel)
            NotifyPropertyChanged(NameOf(Me.Provedores))
        End Function
    End Class
End Namespace
