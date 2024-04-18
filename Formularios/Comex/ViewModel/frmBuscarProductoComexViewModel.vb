Imports System.ComponentModel
Imports System.Threading.Tasks
Imports Comex.Data.Service
Imports Common.Core.Enum
Imports Common.Core.Model
Imports Common.Data.Service
Imports Modelo = Comex.Core.Model.ComexAggregate

Namespace Formularios.Comex
    Public Class frmBuscarProductoComexViewModel
        Inherits Comunes.Common

        Private ProductosModelo As List(Of Modelo.Producto) = New List(Of Modelo.Producto)

        Public ReadOnly Property Colors As BindingList(Of KeyValuePair(Of Color, String))
        Public Property ColorSeleccionado As KeyValuePair(Of Color, String)

        Public ReadOnly Property Suppliers As BindingList(Of KeyValuePair(Of Supplier, String))
        Public Property SupplierSeleccionado As KeyValuePair(Of Supplier, String)

        Public ReadOnly Property TiposProductos As BindingList(Of KeyValuePair(Of TipoProducto, String))
        Public Property TipoProductoSeleccionado As KeyValuePair(Of TipoProducto, String)

        Public Property CantidadLuces As Integer?
        Public Property NombreCodigoProductoBusqueda As String

        Public ReadOnly Property Productos As BindingList(Of BuscarProductoComexItemViewModel)
            Get
                Return New BindingList(Of BuscarProductoComexItemViewModel)(ProductosModelo.Select(Function(x) New BuscarProductoComexItemViewModel(x)).ToList())
            End Get
        End Property

        Public ReadOnly Property SinResultados() As Boolean
            Get
                Return Not Productos.Any
            End Get
        End Property

        Sub New(nombreCodigoProducto As String)
            NombreCodigoProductoBusqueda = nombreCodigoProducto
        End Sub

        Public Async Function CargarDatosAsync() As Task
            Await Task.WhenAll(CargarSupplierAsync(),
                               CargarColoresAsync(),
                               CargarTipoProductoAsync())
        End Function

        Private Async Function CargarSupplierAsync() As Task
            Dim supplier As List(Of Supplier) = Await SupplierService.BuscarSupplier(TipoBase.Local, String.Empty)

            Dim keyValueSuppliers As List(Of KeyValuePair(Of Supplier, String)) = supplier.Select(Function(x) New KeyValuePair(Of Supplier, String)(x, x.Nombre)).ToList()
            keyValueSuppliers.Insert(0, New KeyValuePair(Of Supplier, String)(Nothing, "Seleccione un supplier..."))

            _Suppliers = New BindingList(Of KeyValuePair(Of Supplier, String))(keyValueSuppliers)
            SupplierSeleccionado = _Suppliers.FirstOrDefault()

            NotifyPropertyChanged(NameOf(Me.Suppliers))
        End Function

        Public Sub SeleccionarSupplier(supplier As Supplier)

            Dim supplierSeleccionado As KeyValuePair(Of Supplier, String) = Suppliers.FirstOrDefault(Function(x) x.Key IsNot Nothing AndAlso x.Key.Id = supplier.Id)

            If (supplierSeleccionado.Key IsNot Nothing) Then
                Me.SupplierSeleccionado = supplierSeleccionado
                NotifyPropertyChanged(NameOf(Me.SupplierSeleccionado))
            End If
        End Sub

        Private Async Function CargarColoresAsync() As Task
            Dim supplier As List(Of Color) = Await ColorService.BuscarColores(TipoBase.Local, String.Empty)

            Dim keyValueColores As List(Of KeyValuePair(Of Color, String)) = supplier.Select(Function(x) New KeyValuePair(Of Color, String)(x, x.Nombre)).ToList()
            keyValueColores.Insert(0, New KeyValuePair(Of Color, String)(Nothing, "Seleccione un color..."))

            _Colors = New BindingList(Of KeyValuePair(Of Color, String))(keyValueColores)
            ColorSeleccionado = _Colors.FirstOrDefault()

            NotifyPropertyChanged(NameOf(Me.Colors))
        End Function

        Private Async Function CargarTipoProductoAsync() As Task
            Dim tipoProductos As List(Of TipoProducto) = Await TipoProductoService.BuscarTipoProducto(TipoBase.Local, String.Empty)

            Dim keyValueTipoProductos As List(Of KeyValuePair(Of TipoProducto, String)) = tipoProductos.Select(Function(x) New KeyValuePair(Of TipoProducto, String)(x, x.Nombre)).ToList()
            keyValueTipoProductos.Insert(0, New KeyValuePair(Of TipoProducto, String)(Nothing, "Seleccione un tipo de producto..."))

            _TiposProductos = New BindingList(Of KeyValuePair(Of TipoProducto, String))(keyValueTipoProductos)
            TipoProductoSeleccionado = _TiposProductos.FirstOrDefault()

            NotifyPropertyChanged(NameOf(Me.TipoProductoSeleccionado))
        End Function

        Friend Async Function BuscarProducto() As Task
            Dim idSupplier As Integer? = If(SupplierSeleccionado.Key IsNot Nothing, SupplierSeleccionado.Key.Id, CType(Nothing, Integer?))
            Dim idColor As Integer? = If(ColorSeleccionado.Key IsNot Nothing, ColorSeleccionado.Key.Id, CType(Nothing, Integer?))
            Dim idTipoProducto As Integer? = If(TipoProductoSeleccionado.Key IsNot Nothing, TipoProductoSeleccionado.Key.Id, CType(Nothing, Integer?))

            ProductosModelo = Await ProductoService.BuscarProducto(idSupplier, idColor, idTipoProducto, CantidadLuces, NombreCodigoProductoBusqueda)
            NotifyPropertyChanged(NameOf(Me.Productos))
        End Function
    End Class
End Namespace
