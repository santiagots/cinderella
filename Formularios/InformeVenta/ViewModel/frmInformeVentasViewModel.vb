Imports System.ComponentModel
Imports System.Threading.Tasks
Imports Common.Core.Enum
Imports Common.Core.Model
Imports ModelBase = Ventas.Core.Model.BaseAgreggate
Imports Ventas.Core.Model.InformeAggregate
Imports Common.Core.Exceptions

Namespace Formularios.InformeVenta
    Public Class frmInformeVentasViewModel
        Inherits Comunes.Common

        Private Const ItemsPorPagina As Integer = 50
        Private ProductosModel As List(Of ModelBase.Producto)

        Public Property TotalMontoVenta As Decimal = 0
        Public Property TotalMontoMercaderia As Decimal = 0

        Public InformeVentaPorTipoVenta As List(Of InformeVentaPorTipoVenta)
        Public InformeVentaPorTipoPago As List(Of InformeVentaPorTipoPago)
        Public InformeVentaPorFecha As List(Of InformeVentaPorFecha)

        Public InformeGastos As List(Of InformeVentaEgresos)
        Public InformeCostos As List(Of InformeVentaEgresos)

        Public Property FechaDesde As DateTime
        Public Property FechaHasta As DateTime
        Public Property SucursalesSeleccionadas As List(Of KeyValuePair(Of ModelBase.Sucursal, String))
        Public Property Sucursales As BindingList(Of KeyValuePair(Of ModelBase.Sucursal, String))
        Public Property Producto As String
        Public Property ProductoAutoCompletado As AutoCompleteStringCollection
        Public Property CategoriaSeleccionada As KeyValuePair(Of Categoria, String)
        Public Property Categorias As BindingList(Of KeyValuePair(Of Categoria, String))
        Public Property SubcategoriaSeleccionada As KeyValuePair(Of SubCategoria, String)
        Public Property Subcategoria As BindingList(Of KeyValuePair(Of SubCategoria, String))
        Public Property TotalVentas As BindingList(Of TotalVentaItemViewModel)
        Public ReadOnly Property SinResultadosTotalVentas As Boolean
            Get
                Return Not TotalVentas.Any()
            End Get
        End Property
        Public Property TotalPorTipoCliente As SortableBindingList(Of TotalPorTipoClienteItemViewModel)
        Public ReadOnly Property SinResultadosTotalPorTipoCliente As Boolean
            Get
                Return Not TotalPorTipoCliente.Any()
            End Get
        End Property

        Public Property TotalPorFormaPago As SortableBindingList(Of TotalPorFormaPagoItemViewModel)

        Public ReadOnly Property SinResultadosTotalPorFormaPago As Boolean
            Get
                Return Not TotalPorFormaPago.Any()
            End Get
        End Property

        Public Property TotalFacturado As SortableBindingList(Of TotalFacturadoItemViewModel)
        Public ReadOnly Property SinResultadosTotalFacturado As Boolean
            Get
                Return Not TotalFacturado.Any()
            End Get
        End Property
        Public Property PaginasTotalPorDia As BindingList(Of TotalPorDiaItemViewModel)()
        Public Property PaginasActualTotalPorDia As Integer
        Public ReadOnly Property TotalPorDia As BindingList(Of TotalPorDiaItemViewModel)
            Get
                Return PaginasTotalPorDia(PaginasActualTotalPorDia)
            End Get
        End Property
        Public ReadOnly Property SinResultadosTotalPorDia As Boolean
            Get
                Return Not PaginasTotalPorDia.Length > 0
            End Get
        End Property

        Public Property PaginasProductos As BindingList(Of TotalProductoItemViewModel)()
        Public Property PaginasActualProductos As Integer
        Public ReadOnly Property Productos As BindingList(Of TotalProductoItemViewModel)
            Get
                Return PaginasProductos(PaginasActualProductos)
            End Get
        End Property
        Public ReadOnly Property SinResultadosProductos As Boolean
            Get
                Return Not PaginasProductos.Length > 0
            End Get
        End Property

        Public Property PaginasProductosPorCategoria As BindingList(Of TotalProductoItemViewModel)()
        Public Property PaginasActualProductosPorCategoria As Integer
        Public ReadOnly Property ProductosPorCategoria As BindingList(Of TotalProductoItemViewModel)
            Get
                Return PaginasProductosPorCategoria(PaginasActualProductosPorCategoria)
            End Get
        End Property
        Public ReadOnly Property SinResultadosProductosPorCategoria As Boolean
            Get
                Return Not PaginasProductosPorCategoria.Length > 0
            End Get
        End Property

        Public Property PaginasProductosPorSubcategoria As BindingList(Of TotalProductoItemViewModel)()
        Public Property PaginasActualProductosPorSubcategoria As Integer
        Public ReadOnly Property ProductosPorSubcategoria As BindingList(Of TotalProductoItemViewModel)
            Get
                Return PaginasProductosPorSubcategoria(PaginasActualProductosPorSubcategoria)
            End Get
        End Property
        Public ReadOnly Property SinResultadosProductosPorSubcategoria As Boolean
            Get
                Return Not PaginasProductosPorSubcategoria.Length > 0
            End Get
        End Property

        Public Property Costo As SortableBindingList(Of TotalEgresoItemViewModel)
        Public ReadOnly Property SinResultadosCosto As Boolean
            Get
                Return Not Costo.Any()
            End Get
        End Property

        Public Property Gasto As SortableBindingList(Of TotalEgresoItemViewModel)
        Public ReadOnly Property SinResultadosGasto As Boolean
            Get
                Return Not Gasto.Any()
            End Get
        End Property

        Public Property TotalMercaderia As BindingList(Of TotalEgresoItemViewModel)
        Public ReadOnly Property SinResultadosTotalMercaderia As Boolean
            Get
                Return Not TotalMercaderia.Any()
            End Get
        End Property

        Public Property PaginasMercaderia As BindingList(Of TotalEgresoItemViewModel)()
        Public Property PaginasActualMercaderia As Integer
        Public ReadOnly Property Mercaderia As BindingList(Of TotalEgresoItemViewModel)
            Get
                Return PaginasMercaderia(PaginasActualMercaderia)
            End Get
        End Property
        Public ReadOnly Property SinResultadosMercaderia As Boolean
            Get
                Return Not PaginasMercaderia.Length > 0
            End Get
        End Property
        Public Property VentaPorDiaOrdenadoPor As String
        Public Property VentaPorDiaOrdenadoDireccion As OrdenadoDireccion
        Public Property ProductoNombreOrdenadoPor As String
        Public Property ProductoNombreOrdenadoDireccion As OrdenadoDireccion
        Public Property ProductoCategoriaOrdenadoPor As String
        Public Property ProductoCategoriaOrdenadoDireccion As OrdenadoDireccion
        Public Property ProductoSubcategOriardenadoPor As String
        Public Property ProductoSubcategoriarOrdenadoDireccion As OrdenadoDireccion
        Public Property MercaderiaOriardenadoPor As String
        Public Property MercaderiaOrdenadoDireccion As OrdenadoDireccion

        Sub New()
            FechaDesde = Date.Now.AddDays(-30)
            FechaHasta = Date.Now

            CategoriaSeleccionada = New KeyValuePair(Of Categoria, String)(Nothing, "Todas")
            SubcategoriaSeleccionada = New KeyValuePair(Of SubCategoria, String)(Nothing, "Todas")

            TotalVentas = New BindingList(Of TotalVentaItemViewModel)()
            TotalPorTipoCliente = New SortableBindingList(Of TotalPorTipoClienteItemViewModel)()
            TotalPorFormaPago = New SortableBindingList(Of TotalPorFormaPagoItemViewModel)()
            TotalFacturado = New SortableBindingList(Of TotalFacturadoItemViewModel)()
            Costo = New SortableBindingList(Of TotalEgresoItemViewModel)()
            Gasto = New SortableBindingList(Of TotalEgresoItemViewModel)()
            TotalMercaderia = New BindingList(Of TotalEgresoItemViewModel)()

            PaginasTotalPorDia = New BindingList(Of TotalPorDiaItemViewModel)(0) {}
            PaginasActualTotalPorDia = 0

            PaginasProductos = New BindingList(Of TotalProductoItemViewModel)(0) {}
            PaginasActualProductos = 0

            PaginasProductosPorCategoria = New BindingList(Of TotalProductoItemViewModel)(0) {}
            PaginasActualProductosPorCategoria = 0

            PaginasProductosPorSubcategoria = New BindingList(Of TotalProductoItemViewModel)(0) {}
            PaginasActualProductosPorSubcategoria = 0

            PaginasMercaderia = New BindingList(Of TotalEgresoItemViewModel)(0) {}
            PaginasActualMercaderia = 0

            VentaPorDiaOrdenadoPor = "Fecha"
            VentaPorDiaOrdenadoDireccion = OrdenadoDireccion.DESC

            ProductoNombreOrdenadoPor = "Monto"
            ProductoNombreOrdenadoDireccion = OrdenadoDireccion.DESC

            ProductoCategoriaOrdenadoPor = "Monto"
            ProductoCategoriaOrdenadoDireccion = OrdenadoDireccion.DESC

            ProductoSubcategOriardenadoPor = "Monto"
            ProductoSubcategoriarOrdenadoDireccion = OrdenadoDireccion.DESC

            MercaderiaOriardenadoPor = "Monto"
            MercaderiaOrdenadoDireccion = OrdenadoDireccion.DESC
        End Sub

        Friend Async Function CargarAsync() As Task
            Dim tareas As List(Of Task) = New List(Of Task) From {
                CargarSucursalesAsync(),
                CargarCategoriasAsync(),
                CargarSubcategoriasAsync(),
                CargarProductoNombreYCodigoAsync()
            }

            Await Task.WhenAll(tareas)
        End Function

        Private Async Function CargarSubcategoriasAsync() As Task
            Dim subcategoria As IEnumerable(Of SubCategoria) = Await Task.Run(Function() Servicio.ObtenerSubcategoria())

            Dim listaSubcategoria As List(Of KeyValuePair(Of SubCategoria, String)) = subcategoria.Select(Function(x) New KeyValuePair(Of SubCategoria, String)(x, x.Descripcion)).ToList()
            listaSubcategoria.Add(New KeyValuePair(Of SubCategoria, String)(Nothing, "Todas"))

            Me.Subcategoria = New BindingList(Of KeyValuePair(Of SubCategoria, String))(listaSubcategoria)
            NotifyPropertyChanged(NameOf(Me.Subcategoria))
        End Function

        Private Async Function CargarCategoriasAsync() As Task
            Dim categoria As IEnumerable(Of Categoria) = Await Task.Run(Function() Servicio.ObtenerCategoria())

            Dim listaCategoria As List(Of KeyValuePair(Of Categoria, String)) = categoria.Select(Function(x) New KeyValuePair(Of Categoria, String)(x, x.Descripcion)).ToList()
            listaCategoria.Add(New KeyValuePair(Of Categoria, String)(Nothing, "Todas"))

            Me.Categorias = New BindingList(Of KeyValuePair(Of Categoria, String))(listaCategoria)
            NotifyPropertyChanged(NameOf(Me.Categorias))
        End Function

        Private Async Function CargarProductoNombreYCodigoAsync() As Task
            ProductosModel = Await Task.Run(Function() Formularios.Venta.Servicio.ObtenerListaProductos())

            ProductoAutoCompletado = New AutoCompleteStringCollection()
            ProductosModel.ToList().ForEach(Sub(x) ProductoAutoCompletado.Add(x.Codigo))
            ProductosModel.ToList().ForEach(Sub(x) ProductoAutoCompletado.Add(x.Nombre))

            NotifyPropertyChanged(NameOf(Me.ProductoAutoCompletado))
        End Function

        Private Async Function CargarSucursalesAsync() As Task
            Dim sucursales As IEnumerable(Of ModelBase.Sucursal) = Await Task.Run(Function() Servicio.ObtenerSucursales())

            Me.SucursalesSeleccionadas = sucursales.Select(Function(x) New KeyValuePair(Of ModelBase.Sucursal, String)(x, x.Nombre)).ToList()

            Me.Sucursales = New BindingList(Of KeyValuePair(Of ModelBase.Sucursal, String))(Me.SucursalesSeleccionadas)

            NotifyPropertyChanged(NameOf(Me.Sucursales))
        End Function

        Friend Async Function BuscarAsync() As Task

            TotalMontoVenta = Await Task.Run(Function() Servicio.ObtenerTotalVenta(ObtenerIdSucursales(), FechaDesde, FechaHasta))
            TotalMontoMercaderia = Await Task.Run(Function() Servicio.ObtenerTotalMercaderia(ObtenerIdSucursales(), FechaDesde, FechaHasta))

            Dim tareas As List(Of Task) = New List(Of Task) From {
                CargarVentaPorTipoVentaAsync(),
                CargarVentaPorFacturacionAsync(TotalMontoVenta),
                CargarVentasPorFormaPagoAsync(),
                CargarVentasPorFechaAsync(),
                CargarProductoPorNombreAsync(),
                CargarProductoPorCategoriaAsync(),
                CargarProductoPorSubCategoriaAsync(),
                CargarGastosAsync(TotalMontoVenta),
                CargarCostosAsync(TotalMontoVenta),
                CargarMercaderiaAsync(TotalMontoMercaderia, TotalMontoVenta),
                CargarMercaderiaTotalAsync(TotalMontoMercaderia, TotalMontoVenta)
            }

            Await Task.WhenAll(tareas)
        End Function

        Friend Async Function BuscarProductoAsync() As Task
            Dim tareas As List(Of Task) = New List(Of Task) From {
                CargarProductoPorNombreAsync(),
                CargarProductoPorCategoriaAsync(),
                CargarProductoPorSubCategoriaAsync()
            }

            Await Task.WhenAll(tareas)
        End Function

        Public Async Function CargarVentasPorFechaAsync() As Task
            Dim totalItemsPorFecha As Integer = 0

            InformeVentaPorFecha = Await Task.Run(Function() Servicio.BuscarInformeVentaPorFecha(ObtenerIdSucursales(), FechaDesde, FechaHasta, VentaPorDiaOrdenadoPor, VentaPorDiaOrdenadoDireccion, ItemsPorPagina, PaginasActualTotalPorDia + 1, totalItemsPorFecha))

            PaginasTotalPorDia = New BindingList(Of TotalPorDiaItemViewModel)(CalcularCantidadPaginas(totalItemsPorFecha)) {}

            PaginasTotalPorDia(PaginasActualTotalPorDia) = New BindingList(Of TotalPorDiaItemViewModel)()

            InformeVentaPorFecha.ForEach(Sub(g)
                                             PaginasTotalPorDia(PaginasActualTotalPorDia).Add(New TotalPorDiaItemViewModel() With {
                                                        .Fecha = g.Fecha,
                                                        .Cantidad = g.Cantidad,
                                                        .Monto = g.Monto})
                                         End Sub)

            NotifyPropertyChanged(NameOf(Me.TotalPorDia))
        End Function

        Public Async Function CargarVentaPorTipoVentaAsync() As Task
            InformeVentaPorTipoVenta = Await Task.Run(Function() Servicio.BuscarInformeVentaPorTipoVenta(ObtenerIdSucursales(), FechaDesde, FechaHasta))

            CargarVentasTotal(InformeVentaPorTipoVenta)
            CargarVentasPorTipoCliente(InformeVentaPorTipoVenta)
        End Function

        Public Async Function CargarVentaPorFacturacionAsync(ventaTotal As Decimal) As Task
            InformeVentaPorTipoVenta = Await Task.Run(Function() Servicio.BuscarInformeVentaPorFacturacion(ObtenerIdSucursales(), FechaDesde, FechaHasta))

            CargarVentasPorTotalFacturado(InformeVentaPorTipoVenta, ventaTotal)
        End Function

        Public Async Function CargarVentasPorFormaPagoAsync() As Task
            InformeVentaPorTipoPago = Await Task.Run(Function() Servicio.BuscarInformeVentaPorTipoPago(ObtenerIdSucursales(), FechaDesde, FechaHasta))

            TotalPorFormaPago.Clear()

            Dim informeVentaPorTipoVenta = InformeVentaPorTipoPago.GroupBy(Function(x) New With {x.TipoCliente, x.TipoPago}).ToList()

            informeVentaPorTipoVenta.ForEach(Sub(g)
                                                 TotalPorFormaPago.Add(New TotalPorFormaPagoItemViewModel() With {
                                                        .Grupo = g.Key.TipoCliente.ToString(),
                                                        .Detalle = g.Key.TipoPago.ToString(),
                                                        .Cantidad = g.Sum(Function(x) x.CantidadTotal),
                                                        .Monto = g.Sum(Function(x) x.MontoTotal),
                                                        .PorcentajeVenta = g.Sum(Function(x) x.MontoTotal) / InformeVentaPorTipoPago.Sum(Function(x) x.MontoTotal)})
                                             End Sub)

            NotifyPropertyChanged(NameOf(Me.TotalPorFormaPago))
        End Function

        Private Sub CargarVentasTotal(informeVentaPorTipoVenta As List(Of InformeVentaPorTipoVenta))
            TotalVentas.Clear()

            TotalVentas.Add(New TotalVentaItemViewModel() With {
                .Detalle = "Total",
                .Cantidad = informeVentaPorTipoVenta.Sum(Function(x) x.Cantidad),
                .Monto = informeVentaPorTipoVenta.Sum(Function(x) x.Monto)})

            NotifyPropertyChanged(NameOf(Me.TotalVentas))
        End Sub

        Private Sub CargarVentasPorTipoCliente(informeVentaPorTipoVenta As List(Of InformeVentaPorTipoVenta))
            TotalPorTipoCliente.Clear()

            Dim informeVentaPorTipoCliente = informeVentaPorTipoVenta.GroupBy(Function(x) x.TipoCliente).ToList()

            informeVentaPorTipoCliente.ForEach(Sub(g)
                                                   TotalPorTipoCliente.Add(New TotalPorTipoClienteItemViewModel() With {
                                                        .Detalle = g.Key.ToString(),
                                                        .Cantidad = g.Sum(Function(x) x.Cantidad),
                                                        .Monto = g.Sum(Function(x) x.Monto),
                                                        .PorcentajeVenta = g.Sum(Function(x) x.Monto) / informeVentaPorTipoVenta.Sum(Function(x) x.Monto)})
                                               End Sub)

            NotifyPropertyChanged(NameOf(Me.TotalPorTipoCliente))

        End Sub

        Private Sub CargarVentasPorTotalFacturado(informeVentaPorTipoVenta As List(Of InformeVentaPorTipoVenta), ventaTotal As Decimal)
            TotalFacturado.Clear()

            Dim informeVentaPorTipoCliente = informeVentaPorTipoVenta.GroupBy(Function(x) x.Facturado).ToList()

            If (informeVentaPorTipoCliente.Count > 0) Then
                informeVentaPorTipoCliente.ForEach(Sub(g)
                                                       TotalFacturado.Add(New TotalFacturadoItemViewModel() With {
                                                        .Detalle = "Facturado",
                                                        .Cantidad = g.Sum(Function(x) x.Cantidad),
                                                        .Monto = g.Sum(Function(x) x.Monto),
                                                        .PorcentajeVenta = g.Sum(Function(x) x.Monto) / ventaTotal})
                                                   End Sub)
            Else
                TotalFacturado.Add(New TotalFacturadoItemViewModel() With {
                                                        .Detalle = "Facturado",
                                                        .Cantidad = 0,
                                                        .Monto = 0,
                                                        .PorcentajeVenta = 0})
            End If

            NotifyPropertyChanged(NameOf(Me.TotalFacturado))
        End Sub

        Private Sub CargarVentasPorFormaPago(informeVentaPorTipoPago As List(Of InformeVentaPorTipoPago))
            TotalPorFormaPago.Clear()

            Dim informeVentaPorTipoVenta = informeVentaPorTipoPago.GroupBy(Function(x) New With {x.TipoCliente, x.TipoPago}).ToList()

            informeVentaPorTipoVenta.ForEach(Sub(g)
                                                 TotalPorFormaPago.Add(New TotalPorFormaPagoItemViewModel() With {
                                                        .Grupo = g.Key.TipoCliente.ToString(),
                                                        .Detalle = g.Key.TipoPago.ToString(),
                                                        .Cantidad = g.Sum(Function(x) x.CantidadTotal),
                                                        .Monto = g.Sum(Function(x) x.MontoTotal),
                                                        .PorcentajeVenta = g.Sum(Function(x) x.MontoTotal) / informeVentaPorTipoPago.Sum(Function(x) x.MontoTotal)})
                                             End Sub)

            NotifyPropertyChanged(NameOf(Me.TotalPorFormaPago))

        End Sub

        Public Async Function CargarProductoPorNombreAsync() As Task
            Dim totalItemsProductoPorNombre As Integer = 0

            Dim informeProductoPorNombre As List(Of InformeVentaPorProducto) = Await Task.Run(Function() Servicio.BuscarInformeProductoPorNombre(ObtenerIdSucursales(), FechaDesde, FechaHasta, ObtenerIdProducto(), CategoriaSeleccionada.Key, SubcategoriaSeleccionada.Key, ProductoNombreOrdenadoPor, ProductoNombreOrdenadoDireccion, ItemsPorPagina, PaginasActualProductos + 1, totalItemsProductoPorNombre))

            PaginasProductos = New BindingList(Of TotalProductoItemViewModel)(CalcularCantidadPaginas(totalItemsProductoPorNombre)) {}
            PaginasProductos(PaginasActualProductos) = New BindingList(Of TotalProductoItemViewModel)()
            If (informeProductoPorNombre.Count > 0) Then
                informeProductoPorNombre.ForEach(Sub(g)
                                                     PaginasProductos(PaginasActualProductos).Add(New TotalProductoItemViewModel() With {
                                                            .Nombre = g.Nombre,
                                                            .IdProducto = g.IdProducto,
                                                            .Monto = g.Monto,
                                                            .Cantidad = g.Cantidad})
                                                 End Sub)
            End If
            NotifyPropertyChanged(NameOf(Me.Productos))
        End Function

        Public Async Function CargarProductoPorCategoriaAsync() As Task
            Dim totalItemsProductoPorCategoria As Integer = 0

            Dim informeProductoPorCategoria As List(Of InformeVentaPorProducto) = Await Task.Run(Function() Servicio.BuscarInformeProductoPorCategoria(ObtenerIdSucursales(), FechaDesde, FechaHasta, ObtenerIdProducto(), CategoriaSeleccionada.Key, SubcategoriaSeleccionada.Key, ProductoCategoriaOrdenadoPor, ProductoCategoriaOrdenadoDireccion, ItemsPorPagina, PaginasActualProductosPorCategoria + 1, totalItemsProductoPorCategoria))

            PaginasProductosPorCategoria = New BindingList(Of TotalProductoItemViewModel)(CalcularCantidadPaginas(totalItemsProductoPorCategoria)) {}
            PaginasProductosPorCategoria(PaginasActualProductosPorCategoria) = New BindingList(Of TotalProductoItemViewModel)()

            If (informeProductoPorCategoria.Count > 0) Then
                informeProductoPorCategoria.ForEach(Sub(g)
                                                        PaginasProductosPorCategoria(PaginasActualProductosPorCategoria).Add(New TotalProductoItemViewModel() With {
                                                            .Nombre = g.Nombre,
                                                            .IdProducto = g.IdProducto,
                                                            .Monto = g.Monto,
                                                            .Cantidad = g.Cantidad})
                                                    End Sub)
            End If
            NotifyPropertyChanged(NameOf(Me.ProductosPorCategoria))
        End Function

        Public Async Function CargarProductoPorSubCategoriaAsync() As Task
            Dim totalItemsProductoPorSubCategoria As Integer = 0

            Dim informeProductoPorSubCategoria As List(Of InformeVentaPorProducto) = Await Task.Run(Function() Servicio.BuscarInformeProductoPorSubCategoria(ObtenerIdSucursales(), FechaDesde, FechaHasta, ObtenerIdProducto(), CategoriaSeleccionada.Key, SubcategoriaSeleccionada.Key, ProductoSubcategOriardenadoPor, ProductoSubcategoriarOrdenadoDireccion, ItemsPorPagina, PaginasActualProductosPorSubcategoria + 1, totalItemsProductoPorSubCategoria))

            PaginasProductosPorSubcategoria = New BindingList(Of TotalProductoItemViewModel)(CalcularCantidadPaginas(totalItemsProductoPorSubCategoria)) {}

            PaginasProductosPorSubcategoria(PaginasActualProductosPorSubcategoria) = New BindingList(Of TotalProductoItemViewModel)()
            If (informeProductoPorSubCategoria.Count > 0) Then
                informeProductoPorSubCategoria.ForEach(Sub(g)
                                                           PaginasProductosPorSubcategoria(PaginasActualProductosPorSubcategoria).Add(New TotalProductoItemViewModel() With {
                                                            .Nombre = g.Nombre,
                                                            .IdProducto = g.IdProducto,
                                                            .Monto = g.Monto,
                                                            .Cantidad = g.Cantidad})
                                                       End Sub)
            End If
            NotifyPropertyChanged(NameOf(Me.ProductosPorSubcategoria))
        End Function

        Private Async Function CargarGastosAsync(ventaTotal As Decimal) As Task
            InformeGastos = Await Task.Run(Function() Servicio.BuscarInformGastos(ObtenerIdSucursales(), FechaDesde, FechaHasta))

            Gasto.Clear()
            InformeGastos.ForEach(Sub(g)
                                      Gasto.Add(New TotalEgresoItemViewModel() With {
                                                        .Nombre = g.Nombre,
                                                        .Monto = g.Monto,
                                                        .PocentajeMonto = g.Monto / InformeGastos.Sum(Function(x) x.Monto),
                                                        .PocentajeVenta = g.Monto / ventaTotal})
                                  End Sub)

            NotifyPropertyChanged(NameOf(Me.Gasto))
        End Function

        Private Async Function CargarCostosAsync(ventaTotal As Decimal) As Task
            InformeCostos = Await Task.Run(Function() Servicio.BuscarInformeCostos(ObtenerIdSucursales(), FechaDesde, FechaHasta))

            Dim costoTotal As Decimal = InformeCostos.Sum(Function(x) x.Monto)

            Costo.Clear()
            InformeCostos.ForEach(Sub(g)
                                      Costo.Add(New TotalEgresoItemViewModel() With {
                                                        .Nombre = g.Nombre,
                                                        .Monto = g.Monto,
                                                        .PocentajeMonto = If(costoTotal <> 0, g.Monto / costoTotal, 0),
                                                        .PocentajeVenta = If(ventaTotal <> 0, g.Monto / ventaTotal, 0)})
                                  End Sub)

            NotifyPropertyChanged(NameOf(Me.Costo))
        End Function

        Public Async Function CargarMercaderiaAsync(mercaderiaTotal As Decimal, ventaTotal As Decimal) As Task
            Dim totalItemsMercaderia As Integer = 0

            Dim informeMercaderia As List(Of InformeVentaEgresos) = Await Task.Run(Function() Servicio.BuscarInformeMercaderia(ObtenerIdSucursales(), FechaDesde, FechaHasta, MercaderiaOriardenadoPor, MercaderiaOrdenadoDireccion, ItemsPorPagina, PaginasActualMercaderia + 1, totalItemsMercaderia))

            PaginasMercaderia = New BindingList(Of TotalEgresoItemViewModel)(CalcularCantidadPaginas(totalItemsMercaderia)) {}

            PaginasMercaderia(PaginasActualMercaderia) = New BindingList(Of TotalEgresoItemViewModel)()

            informeMercaderia.ForEach(Sub(g)
                                          PaginasMercaderia(PaginasActualMercaderia).Add(New TotalEgresoItemViewModel() With {
                                                        .Nombre = g.Nombre,
                                                        .Monto = g.Monto,
                                                        .PocentajeMonto = g.Monto / mercaderiaTotal,
                                                        .PocentajeVenta = g.Monto / ventaTotal})
                                      End Sub)

            NotifyPropertyChanged(NameOf(Me.Mercaderia))
        End Function

        Private Async Function CargarMercaderiaTotalAsync(mercaderiaTotal As Decimal, ventaTotal As Decimal) As Task
            TotalMercaderia.Clear()

            Dim porcentajeMonto As Decimal = If(mercaderiaTotal <> 0, mercaderiaTotal / mercaderiaTotal, 0)
            Dim pocentajeVenta As Decimal = If(ventaTotal <> 0, mercaderiaTotal / ventaTotal, 0)

            TotalMercaderia.Add(New TotalEgresoItemViewModel() With {
                          .Nombre = "Total",
                          .Monto = mercaderiaTotal,
                          .PocentajeMonto = porcentajeMonto,
                          .PocentajeVenta = pocentajeVenta})

            NotifyPropertyChanged(NameOf(Me.TotalMercaderia))
        End Function

        Public Function ObtenerIdSucursales() As List(Of Integer)
            Return SucursalesSeleccionadas?.Select(Function(x) x.Key.Id).ToList()
        End Function

        Private Function CalcularCantidadPaginas(cantidadItemas As Integer) As Integer
            Dim paginas As Integer = 0

            Do
                paginas += 1
                cantidadItemas -= ItemsPorPagina
            Loop Until (cantidadItemas <= 0)

            Return paginas - 1
        End Function

        Public Function ObtenerIdProducto() As Integer?
            Dim idProducto As Integer? = Nothing
            If (Not String.IsNullOrEmpty(Producto)) Then
                Dim ProductoModel As ModelBase.Producto = ProductosModel.Where(Function(x) x.Nombre = Producto OrElse x.Codigo = Producto OrElse x.CodigoBarra = Producto).FirstOrDefault()
                If (ProductoModel IsNot Nothing) Then
                    idProducto = ProductoModel.Id
                Else
                    Throw New NegocioException("El producto ingresado no existe")
                End If
            End If
            Return idProducto
        End Function

    End Class
End Namespace
