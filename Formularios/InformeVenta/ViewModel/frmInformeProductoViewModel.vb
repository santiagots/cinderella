Imports System.ComponentModel
Imports System.Threading.Tasks
Imports Common.Core.Enum
Imports Common.Core.Model
Imports SistemaCinderella.Formularios.InformeVenta
Imports Ventas.Core.Model.InformeAggregate

Namespace Formularios.InformeVenta
    Public Class frmInformeProductoViewModel
        Inherits Comunes.Common

        Private Const ItemsPorPagina As Integer = 50
        Private InformeProductoPorNombre As List(Of InformeVentaPorProducto)

        Private IdSucursales As IEnumerable(Of Integer)
        Private FechaDesde As DateTime
        Private FechaHasta As DateTime

        Private IdProducto As Integer?
        Private Categoria As Categoria
        Private Subcategoria As SubCategoria

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

        Public Property ProductoNombreOrdenadoPor As String
        Public Property ProductoNombreOrdenadoDireccion As OrdenadoDireccion

        Sub New(idSucursales As IEnumerable(Of Integer), fechaDesde As DateTime, fechaHasta As DateTime, IdProducto As Integer?, Categoria As Categoria, Subcategoria As SubCategoria)
            Me.IdSucursales = idSucursales
            Me.FechaDesde = fechaDesde
            Me.FechaHasta = fechaHasta
            Me.IdProducto = IdProducto
            Me.Categoria = Categoria
            Me.Subcategoria = Subcategoria

            PaginasProductos = New BindingList(Of TotalProductoItemViewModel)(0) {}
            PaginasActualProductos = 0

            ProductoNombreOrdenadoPor = "Nombre"
            ProductoNombreOrdenadoDireccion = OrdenadoDireccion.ASC
        End Sub


        Public Async Function CargarProductoPorNombreAsync() As Task
            Dim totalItemsProductoPorNombre As Integer = 0

            InformeProductoPorNombre = Await Task.Run(Function() Servicio.BuscarInformeProductoPorFecha(IdSucursales, FechaDesde, FechaHasta, IdProducto, Categoria, Subcategoria, ProductoNombreOrdenadoPor, ProductoNombreOrdenadoDireccion, ItemsPorPagina, PaginasActualProductos + 1, totalItemsProductoPorNombre))

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

        Public Function ObtenerDTProductoPorNombre() As DataTable
            Dim dt As DataTable = New DataTable()

            dt.Columns.Add("Fecha", GetType(String))
            dt.Columns.Add("Monto", GetType(Decimal))
            dt.Columns.Add("Cantidad", GetType(Integer))

            InformeProductoPorNombre.ForEach(Sub(x) dt.Rows.Add(x.Nombre, x.Monto, x.Cantidad))
            Return dt
        End Function

        Private Function CalcularCantidadPaginas(cantidadItemas As Integer) As Integer
            Dim paginas As Integer = 0

            Do
                paginas += 1
                cantidadItemas -= ItemsPorPagina
            Loop Until (cantidadItemas <= 0)

            Return paginas - 1
        End Function
    End Class
End Namespace
