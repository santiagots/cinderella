Imports System.ComponentModel
Imports System.Threading.Tasks
Imports Comex.Core.Enum
Imports Comex.Core.Model.ComexAggregate
Imports Comex.Data.Service
Imports Common.Core.Enum
Imports Common.Core.Extension
Imports Common.Core.Model
Imports Common.Data.Service
Imports modelo = Comex.Core.Model.ComexAggregate
Imports service = Comex.Data.Service

Namespace Formularios.Comex
    Public Class frmComexOrdenCompraAdministracionViewModel
        Inherits Comunes.Common

        Private OrdenesCompraModelo As List(Of modelo.OrdenCompra) = New List(Of modelo.OrdenCompra)

        Public Property Numero As String

        Public ReadOnly Property Suppliers As BindingList(Of KeyValuePair(Of Supplier, String))
        Public Property SupplierSeleccionado As KeyValuePair(Of Supplier, String)

        Public ReadOnly Property Encargados As BindingList(Of KeyValuePair(Of modelo.Empleado, String))
        Public Property EncargadoSeleccionado As KeyValuePair(Of modelo.Empleado, String)

        Public ReadOnly Property Estados As BindingList(Of KeyValuePair(Of EstadoOrdenCompra?, String))
        Public Property EstadoSeleccionado As KeyValuePair(Of EstadoOrdenCompra?, String)

        Public ReadOnly Property Sucursales As BindingList(Of KeyValuePair(Of modelo.Sucursal, String))
        Public Property SucursaleSeleccionado As KeyValuePair(Of modelo.Sucursal, String)

        Public Property FechaDesde As DateTime
        Public Property FechaHasta As DateTime

        Public ReadOnly Property OrdenesCompra As BindingList(Of ComexOrdenCompraAdministracionItemViewModel)
            Get
                Return New BindingList(Of ComexOrdenCompraAdministracionItemViewModel)(OrdenesCompraModelo.Select(Function(x) New ComexOrdenCompraAdministracionItemViewModel(x)).ToList())
            End Get
        End Property

        Public ReadOnly Property SinResultados() As Boolean
            Get
                Return Not OrdenesCompra.Any
            End Get
        End Property

        Public Property OrdenadoPor As String = "Fecha"
        Public Property DireccionOrdenamiento As OrdenadoDireccion = OrdenadoDireccion.DESC
        Public Property PaginaActual As Integer = 1
        Public Property ElementosPorPagina As Integer
        Public Property TotalElementos As Integer

        Dim _FormState As FormWindowState
        Public Property FormState As FormWindowState
            Set(value As FormWindowState)
                _FormState = value
                NotifyPropertyChanged(NameOf(Me.FormState))
            End Set
            Get
                Return _FormState
            End Get
        End Property

        Sub New()
            FechaDesde = DateTime.Now.AddMonths(-1)
            FechaHasta = DateTime.Now
            FormState = FormWindowState.Normal
        End Sub

        Public Async Function CargarDatosAsync() As Task
            CargarEstados()
            Await CargarEncargadosAsync()
            Await CargarSucursalesAsync()
            Await CargarSupplierAsync()
        End Function

        Friend Sub NuevaOrdenCompra()
            Dim frmBuscarProductoComex As frmComexOrdenCompra = New frmComexOrdenCompra(AddressOf ActualizarPantallaCallback)
            frmBuscarProductoComex.MdiParent = MDIContenedor
            frmBuscarProductoComex.Show()
            FormState = FormWindowState.Minimized
        End Sub

        Friend Sub CargarOrdenCompra(ordenCompra As OrdenCompra)
            Dim frmBuscarProductoComex As frmComexOrdenCompra = New frmComexOrdenCompra(ordenCompra, AddressOf ActualizarPantallaCallback)
            frmBuscarProductoComex.MdiParent = MDIContenedor
            frmBuscarProductoComex.Show()
            FormState = FormWindowState.Minimized
        End Sub

        Friend Async Function BuscarAsync() As Task
            Dim idOrden As Integer? = If(Not String.IsNullOrEmpty(Numero), CType(Numero, Integer), CType(Nothing, Integer?))
            Dim idSucursal As Integer? = If(SucursaleSeleccionado.Key IsNot Nothing, SucursaleSeleccionado.Key.Id, CType(Nothing, Integer?))
            Dim idSuplier As Integer? = If(SupplierSeleccionado.Key IsNot Nothing, SupplierSeleccionado.Key.Id, CType(Nothing, Integer?))
            Dim idEncargado As Integer? = If(EncargadoSeleccionado.Key IsNot Nothing, EncargadoSeleccionado.Key.Id, CType(Nothing, Integer?))
            Dim estado As EstadoOrdenCompra? = If(EstadoSeleccionado.Key IsNot Nothing, EstadoSeleccionado.Key, CType(Nothing, Integer?))

            OrdenesCompraModelo = Await OrdenCompraService.BuscarAsync(idOrden, idSucursal, idSuplier, idEncargado, estado, FechaDesde, FechaHasta, OrdenadoPor, DireccionOrdenamiento, PaginaActual, ElementosPorPagina, TotalElementos)
            NotifyPropertyChanged(NameOf(Me.OrdenesCompra))
        End Function

        Private Async Function CargarEncargadosAsync() As Task
            Dim encargados As List(Of modelo.Empleado) = Await service.EmpleadoService.ObtenerAsync(TipoEmpleado.Encargado, Nothing)

            Dim keyValueEncargados As List(Of KeyValuePair(Of modelo.Empleado, String)) = encargados.Select(Function(x) New KeyValuePair(Of modelo.Empleado, String)(x, x.ApellidoYNombre)).ToList()
            keyValueEncargados.Insert(0, New KeyValuePair(Of modelo.Empleado, String)(Nothing, "Todos"))

            _Encargados = New BindingList(Of KeyValuePair(Of modelo.Empleado, String))(keyValueEncargados)
            EncargadoSeleccionado = _Encargados.FirstOrDefault()

            NotifyPropertyChanged(NameOf(Me.Encargados))
        End Function

        Private Async Function CargarSucursalesAsync() As Task
            Dim sucursales As List(Of modelo.Sucursal) = Await service.SucursalService.ObtenerAsync()

            Dim keyValueSucursales As List(Of KeyValuePair(Of modelo.Sucursal, String)) = sucursales.Select(Function(x) New KeyValuePair(Of modelo.Sucursal, String)(x, x.Nombre)).ToList()
            keyValueSucursales.Insert(0, New KeyValuePair(Of modelo.Sucursal, String)(Nothing, "Todas"))

            _Sucursales = New BindingList(Of KeyValuePair(Of modelo.Sucursal, String))(keyValueSucursales)
            SucursaleSeleccionado = _Sucursales.FirstOrDefault()

            NotifyPropertyChanged(NameOf(Me.Encargados))
        End Function

        Private Function CargarEstados()
            Dim estados As List(Of KeyValuePair(Of EstadoOrdenCompra?, String)) = [Enum](Of EstadoOrdenCompra).ToKeyValuePairList()
            estados.Insert(0, New KeyValuePair(Of EstadoOrdenCompra?, String)(Nothing, "Todos"))

            _Estados = New BindingList(Of KeyValuePair(Of EstadoOrdenCompra?, String))(estados)
            EstadoSeleccionado = _Estados.FirstOrDefault()

            NotifyPropertyChanged(NameOf(Me.Estados))
        End Function

        Private Async Function CargarSupplierAsync() As Task
            Dim supplier As List(Of Supplier) = Await SupplierService.BuscarSupplier(TipoBase.Local, String.Empty)

            Dim keyValueSuppliers As List(Of KeyValuePair(Of Supplier, String)) = supplier.Select(Function(x) New KeyValuePair(Of Supplier, String)(x, x.Nombre)).ToList()
            keyValueSuppliers.Insert(0, New KeyValuePair(Of Supplier, String)(Nothing, "Todos"))

            _Suppliers = New BindingList(Of KeyValuePair(Of Supplier, String))(keyValueSuppliers)
            SupplierSeleccionado = _Suppliers.FirstOrDefault()

            NotifyPropertyChanged(NameOf(Me.Suppliers))
        End Function

        Public Async Function ActualizarPantallaCallback() As Task
            FormState = If(FormState = FormWindowState.Minimized, FormWindowState.Normal, FormState)
            Await BuscarAsync()
        End Function

    End Class

End Namespace
