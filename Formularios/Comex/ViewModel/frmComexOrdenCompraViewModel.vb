Imports System.ComponentModel
Imports System.Threading.Tasks
Imports AutoMapper
Imports Comex.Core.Enum
Imports Comex.Data.Service
Imports Common.Core.Enum
Imports Common.Core.Exceptions
Imports Common.Core.Model
Imports Common.Data.Service
Imports Modelo = Comex.Core.Model.ComexAggregate

Namespace Formularios.Comex
    Public Class frmComexOrdenCompraViewModel
        Inherits Comunes.Common

        Public Delegate Sub CargarProductoNombreyCodigoDelegate(nombreCodigoProductos As List(Of String))
        Public Delegate Function CantidadUnidadesProductoDelegate(codigoProducto As String, ByRef cantidadUnidades As Integer) As Boolean

        Private CargarProductoNombreyCodigoEvent As CargarProductoNombreyCodigoDelegate
        Private CantidadUnidadesProductoEvent As CantidadUnidadesProductoDelegate

        Private OrdenCompraModel As Modelo.OrdenCompra
        Private NombreCodigoProductos As List(Of String) = New List(Of String)()

        Public ReadOnly Property Suppliers As BindingList(Of KeyValuePair(Of Supplier, String))
        Public Property SupplierSeleccionado As KeyValuePair(Of Supplier, String)

        Public ReadOnly Property Numero As String
            Get
                Return If(OrdenCompraModel.Id > 0, OrdenCompraModel.Id, String.Empty)
            End Get
        End Property

        Public ReadOnly Property Fecha As String
            Get
                Return OrdenCompraModel.Fecha.ToShortDateString()
            End Get
        End Property

        Public ReadOnly Property Encargados As BindingList(Of KeyValuePair(Of Modelo.Empleado, String))
        Public Property EncargadoSeleccionado As KeyValuePair(Of Modelo.Empleado, String)

        Public ReadOnly Property Estado As EstadoOrdenCompra
            Get
                Return OrdenCompraModel.Estado
            End Get
        End Property

        Public ReadOnly Property OrdenCompraItems As BindingList(Of ComexOrdenCompraItemsViewModel)
            Get
                Return New BindingList(Of ComexOrdenCompraItemsViewModel)(Mapper.Map(Of List(Of ComexOrdenCompraItemsViewModel))(OrdenCompraModel.OrdenCompraItems))
            End Get
        End Property

        Public ReadOnly Property TotalOrdenCompraItems As BindingList(Of ComexOrdenCompraItemsViewModel)
            Get
                Dim VentaItemViewModel As ComexOrdenCompraItemsViewModel = New ComexOrdenCompraItemsViewModel() With {
                    .SupplierCode = "Total",
                    .TotalUSD = OrdenCompraModel.OrdenCompraItems.Sum(Function(x) x.TotalUSD),
                    .TotalRMB = OrdenCompraModel.OrdenCompraItems.Sum(Function(x) x.TotalRMB),
                    .BoxQTY = OrdenCompraModel.OrdenCompraItems.Sum(Function(x) x.CantidadCajas),
                    .TotalPCS = OrdenCompraModel.OrdenCompraItems.Sum(Function(x) x.TotalPCS),
                    .TotalCBM = OrdenCompraModel.OrdenCompraItems.Sum(Function(x) x.TotalCBM)
                    }
                Dim list As BindingList(Of ComexOrdenCompraItemsViewModel) = New BindingList(Of ComexOrdenCompraItemsViewModel)

                list.Add(VentaItemViewModel)
                Return list
            End Get
        End Property

        Public Property NombreCodigoProductoBusqueda As String
        Public Property TerminosDePago As String
        Public Property PenalidadesPorDemora As String
        Public Property FechaDeEnvio As String

        Public Property MotivoAnulado As String
        Public ReadOnly Property FechaAnulado As String
            Get
                Return OrdenCompraModel.FechaAnulado?.ToShortDateString()
            End Get
        End Property

        Public ReadOnly Property PuertoCarga As String
            Get
                Return If(SupplierSeleccionado.Key IsNot Nothing, SupplierSeleccionado.Key.POL, String.Empty)
            End Get
        End Property

        Public ReadOnly Property HabilitarAgregarProductos As Boolean
            Get
                Return HabilitarEdicion AndAlso
                    SupplierSeleccionado.Key IsNot Nothing AndAlso SupplierSeleccionado.Key.Id > 0
            End Get
        End Property

        Public ReadOnly Property HabilitarEdicion As Boolean
            Get
                Return OrdenCompraModel.Estado = EstadoOrdenCompra.Borrador
            End Get
        End Property

        Public ReadOnly Property HabilitarBorrador As Boolean
            Get
                Return OrdenCompraModel.Estado = EstadoOrdenCompra.Borrador
            End Get
        End Property

        Public ReadOnly Property HabilitarIniciar As Boolean
            Get
                Return OrdenCompraModel.Estado = EstadoOrdenCompra.Borrador
            End Get
        End Property

        Public ReadOnly Property HabilitarFinalizar As Boolean
            Get
                Return OrdenCompraModel.Estado = EstadoOrdenCompra.Iniciada
            End Get
        End Property

        Public ReadOnly Property HabilitarAnular As Boolean
            Get
                Return OrdenCompraModel.Id > 0 AndAlso OrdenCompraModel.Estado <> EstadoOrdenCompra.Finalizada AndAlso OrdenCompraModel.Estado <> EstadoOrdenCompra.Anulada
            End Get
        End Property

        Sub New(idSucursal As Integer, ordenCompra As Modelo.OrdenCompra, cargarProductoNombreyCodigo As CargarProductoNombreyCodigoDelegate, cantidadUnidadesProducto As CantidadUnidadesProductoDelegate)
            CargarProductoNombreyCodigoEvent = cargarProductoNombreyCodigo
            CantidadUnidadesProductoEvent = cantidadUnidadesProducto
            If (ordenCompra Is Nothing) Then
                OrdenCompraModel = New Modelo.OrdenCompra(idSucursal)
            Else
                OrdenCompraModel = ordenCompra
                TerminosDePago = ordenCompra.TerminosDePago
                PenalidadesPorDemora = ordenCompra.PenalidadesPorDemora
                FechaDeEnvio = ordenCompra.FechaDeEnvio
                MotivoAnulado = ordenCompra.MotivoAnulado

                SupplierSeleccionado = New KeyValuePair(Of Supplier, String)(ordenCompra.Supplier, ordenCompra.Supplier.Nombre)
                EncargadoSeleccionado = New KeyValuePair(Of Modelo.Empleado, String)(ordenCompra.Encargado, ordenCompra.Encargado.ApellidoYNombre)
            End If
        End Sub

        Public Async Function CargarDatosAsync() As Task
            Await CargarEncargadoAsync()
            Await CargarSupplierAsync()
        End Function

        Private Async Function CargarProductoNombreYCodigoAsync() As Task
            If (CargarProductoNombreyCodigoEvent IsNot Nothing AndAlso SupplierSeleccionado.Key IsNot Nothing) Then

                NombreCodigoProductos = ProductoService.ObtenerNombreYCodigoDeProductos(SupplierSeleccionado.Key.Id)

                CargarProductoNombreyCodigoEvent(NombreCodigoProductos)
            End If
        End Function

        Private Async Function CargarEncargadoAsync() As Task
            Dim encargados As List(Of Modelo.Empleado) = Await EmpleadoService.ObtenerAsync(TipoEmpleado.Encargado, OrdenCompraModel.IdSucursal)

            Dim keyValueEncargados As List(Of KeyValuePair(Of Modelo.Empleado, String)) = encargados.Select(Function(x) New KeyValuePair(Of Modelo.Empleado, String)(x, x.ApellidoYNombre)).ToList()
            keyValueEncargados.Insert(0, New KeyValuePair(Of Modelo.Empleado, String)(Nothing, "Seleccione un encargado..."))

            _Encargados = New BindingList(Of KeyValuePair(Of Modelo.Empleado, String))(keyValueEncargados)

            If (EncargadoSeleccionado.Key Is Nothing) Then
                EncargadoSeleccionado = _Encargados.FirstOrDefault()
            End If

            NotifyPropertyChanged(NameOf(Me.Encargados))
        End Function

        Private Async Function CargarSupplierAsync() As Task
            Dim supplier As List(Of Supplier) = Await SupplierService.BuscarSupplier(TipoBase.Local, String.Empty)

            Dim keyValueSuppliers As List(Of KeyValuePair(Of Supplier, String)) = supplier.Select(Function(x) New KeyValuePair(Of Supplier, String)(x, x.Nombre)).ToList()
            keyValueSuppliers.Insert(0, New KeyValuePair(Of Supplier, String)(Nothing, "Seleccione un supplier..."))

            _Suppliers = New BindingList(Of KeyValuePair(Of Supplier, String))(keyValueSuppliers)

            If (SupplierSeleccionado.Key Is Nothing) Then
                SupplierSeleccionado = _Suppliers.FirstOrDefault()
            End If

            NotifyPropertyChanged(NameOf(Me.Suppliers))
            NotifyPropertyChanged(NameOf(Me.HabilitarAgregarProductos))
        End Function

        Friend Async Sub AgregaItem()
            Dim existeProducto As Boolean = NombreCodigoProductos.Any(Function(x) x.ToUpper() = NombreCodigoProductoBusqueda.ToUpper() _
                                                                            OrElse x.ToUpper() = NombreCodigoProductoBusqueda.ToUpper() _
                                                                            OrElse x.ToUpper() = NombreCodigoProductoBusqueda.ToUpper())

            If (Not existeProducto) Then
                Throw New NegocioException("El producto ingresado no existe")
            End If

            Dim producto As Modelo.Producto = Await ProductoService.BuscarProductoPorCodigoNombreBarras(SupplierSeleccionado.Key.Id, NombreCodigoProductoBusqueda)
            Dim unidadesProducto As Integer = 0

            If (Not CantidadUnidadesProductoEvent(producto.Codigo, unidadesProducto)) Then
                Return
            End If

            OrdenCompraModel.AgregaOrdenCompraItem(producto, unidadesProducto)

            NotifyPropertyChanged(NameOf(Me.OrdenCompraItems))
            NotifyPropertyChanged(NameOf(Me.TotalOrdenCompraItems))
        End Sub

        Friend Sub QuitarItem(comexOrdenCompraItemsViewModel As ComexOrdenCompraItemsViewModel)
            OrdenCompraModel.QuitarOrdenCompraItem(comexOrdenCompraItemsViewModel.Codigo)

            NotifyPropertyChanged(NameOf(Me.OrdenCompraItems))
            NotifyPropertyChanged(NameOf(Me.TotalOrdenCompraItems))
        End Sub

        Friend Sub ActualizarItem(comexOrdenCompraItemsViewModel As ComexOrdenCompraItemsViewModel)
            OrdenCompraModel.ActualizarOrdenCompraItem(comexOrdenCompraItemsViewModel.Codigo, comexOrdenCompraItemsViewModel.BoxQTY)

            NotifyPropertyChanged(NameOf(Me.OrdenCompraItems))
            NotifyPropertyChanged(NameOf(Me.TotalOrdenCompraItems))
        End Sub

        Friend Sub BuscarItemOrdenCompra()
            Dim frmBuscarProductoComex As frmBuscarProductoComex = New frmBuscarProductoComex(SupplierSeleccionado.Key, NombreCodigoProductoBusqueda)

            If (frmBuscarProductoComex.ShowDialog() = DialogResult.OK) Then
                Dim producto As Modelo.Producto = frmBuscarProductoComex.ProductoSeleccionado
                Dim unidadesProducto As Integer = 0

                If (Not CantidadUnidadesProductoEvent(producto.Codigo, unidadesProducto)) Then
                    Return
                End If

                OrdenCompraModel.AgregaOrdenCompraItem(producto, unidadesProducto)

                NotifyPropertyChanged(NameOf(Me.OrdenCompraItems))
                NotifyPropertyChanged(NameOf(Me.TotalOrdenCompraItems))
                Return
            Else
                Return
            End If
        End Sub

        Friend Async Function SupplierChangeAsync(supplierSeleccionado As KeyValuePair(Of Supplier, String)) As Task
            Me.SupplierSeleccionado = supplierSeleccionado

            Await CargarProductoNombreYCodigoAsync()

            OrdenCompraModel.QuitarOrdenCompraItem()

            NotifyPropertyChanged(NameOf(Me.HabilitarAgregarProductos))
        End Function

        Friend Async Function Borrador() As Task
            ActualizarDatosOrdenCompra()
            OrdenCompraModel.Borrador()
            Await OrdenCompraService.GuardarAsync(OrdenCompraModel)

            NotifyPropertyChanged(NameOf(Me.HabilitarBorrador))
        End Function

        Friend Async Function Iniciar() As Task
            ActualizarDatosOrdenCompra()
            OrdenCompraModel.Iniciar()
            Await OrdenCompraService.GuardarAsync(OrdenCompraModel)

            NotifyPropertyChanged(NameOf(Me.HabilitarIniciar))
        End Function

        Friend Async Function Finalizar() As Task
            OrdenCompraModel.Finalizar()
            Await OrdenCompraService.GuardarAsync(OrdenCompraModel)

            NotifyPropertyChanged(NameOf(Me.HabilitarFinalizar))
        End Function

        Friend Async Function Anular() As Task
            OrdenCompraModel.Anular(MotivoAnulado)
            Await OrdenCompraService.GuardarAsync(OrdenCompraModel)

            NotifyPropertyChanged(NameOf(Me.HabilitarAnular))
        End Function

        Private Sub ActualizarDatosOrdenCompra()
            OrdenCompraModel.ActualizarSupplier(SupplierSeleccionado.Key)
            OrdenCompraModel.AgregarEncargado(EncargadoSeleccionado.Key)
            OrdenCompraModel.AgregarTerminosDePago(TerminosDePago)
            OrdenCompraModel.AgregarPenalidadesPorDemora(PenalidadesPorDemora)
            OrdenCompraModel.AgregarFechaDeEnvio(FechaDeEnvio)
        End Sub
    End Class
End Namespace
