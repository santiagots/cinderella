Imports System.ComponentModel
Imports System.Threading.Tasks
Imports AutoMapper
Imports Common.Core.Extension
Imports Common.Core.Enum
Imports Ventas.Core.Enum
Imports Ventas.Core.Model.NotaPedidoAgreggate
Imports Ventas.Core.Model.BaseAgreggate
Imports Ventas.Data.Service

Namespace Formularios.Venta
    Public Class frmNotaPedidoAdministracionViewModel
        Inherits Comunes.Common

        Private ReadOnly IdSucursal As Integer
        Public Property EstadoSeleccionado As KeyValuePair(Of NotaPedidoEstado?, String)
        Public ReadOnly Property Estado As BindingList(Of KeyValuePair(Of NotaPedidoEstado?, String))
        Public Property TipoClienteSeleccionado As KeyValuePair(Of TipoCliente?, String)
        Public ReadOnly Property TipoCliente As BindingList(Of KeyValuePair(Of TipoCliente?, String))
        Public Property TipoPagoSeleccionado As TipoPago
        Public ReadOnly Property TipoPago As BindingList(Of TipoPago)
        Public Property FechaDesde As DateTime
        Public Property FechaHasta As DateTime
        Public Property FiltrarPorFecha As Boolean
        Public Property VendedoresSeleccionado As KeyValuePair(Of Empleado, String)
        Public ReadOnly Property Vendedores As BindingList(Of KeyValuePair(Of Empleado, String))
        Public Property Numero As Integer?
        Public Property NombreCliente As String

        Public Property ValorPromedio As Decimal

        Public Property TotalSinIVA As Decimal

        Public Property Total As Decimal

        Public ReadOnly Property SinResultados() As Boolean
            Get
                Return Not _NotaPedidosItems.Any()
            End Get
        End Property

        Private _NotaPedidosItems As IList(Of NotaPedido)
        Public ReadOnly Property NotaPedidosItems As BindingList(Of NotaPedidoItemsViewModel)
            Get
                Return New BindingList(Of NotaPedidoItemsViewModel)(Mapper.Map(Of List(Of NotaPedidoItemsViewModel))(_NotaPedidosItems))
            End Get
        End Property

        Dim _Visible As Boolean
        Public Property Visible As Boolean
            Set(value As Boolean)
                _Visible = value
                NotifyPropertyChanged(NameOf(Me.Visible))
            End Set
            Get
                Return _Visible
            End Get
        End Property

        Public Property NotasPedidosOrdenadoPor As String = "Fecha"
        Public Property NotasPedidosDireccionOrdenamiento As OrdenadoDireccion = OrdenadoDireccion.DESC
        Public Property NotasPedidosPaginaActual As Integer = 1
        Public Property NotasPedidosElementosPorPagina As Integer
        Public Property NotasPedidosTotalElementos As Integer

        Sub New(IdSucursal As Integer)
            Me.IdSucursal = IdSucursal
            Visible = True
            Inicializar()
        End Sub

        Public Async Function Buscar() As Task
            Await CargarNotaPedidoAsync(Numero, EstadoSeleccionado.Key, TipoClienteSeleccionado.Key, FechaDesde, FechaHasta, VendedoresSeleccionado.Key?.Id, NombreCliente)
        End Function

        Public Async Function BuscarTotales() As Task
            Dim montoTotal As Decimal? = Await NotaPedidoService.ObtenerMontoTotal(IdSucursal, Numero, EstadoSeleccionado.Key, TipoClienteSeleccionado.Key, FechaDesde, FechaHasta, VendedoresSeleccionado.Key?.Id, NombreCliente)
            Dim montoTotalSinIva As Decimal? = Await NotaPedidoService.ObtenerMontoTotalSinIva(IdSucursal, Numero, EstadoSeleccionado.Key, TipoClienteSeleccionado.Key, FechaDesde, FechaHasta, VendedoresSeleccionado.Key?.Id, NombreCliente)

            ValorPromedio = If(NotasPedidosTotalElementos > 0, montoTotal / NotasPedidosTotalElementos, 0)
            TotalSinIVA = If(montoTotalSinIva.HasValue, montoTotalSinIva.Value, 0)
            Total = If(montoTotal.HasValue, montoTotal.Value, 0)

            NotifyPropertyChanged(NameOf(Me.ValorPromedio))
            NotifyPropertyChanged(NameOf(Me.TotalSinIVA))
            NotifyPropertyChanged(NameOf(Me.Total))

        End Function

        Public Sub CargarVenta(notaPedidoItem As NotaPedidoItemsViewModel, MdiParent As Form)
            Dim notaPedido As NotaPedido = _NotaPedidosItems.FirstOrDefault(Function(x) x.Id = notaPedidoItem.Id)
            Dim form As Form

            If (notaPedido.TipoCliente = Common.Core.Enum.TipoCliente.Mayorista.Mayorista) Then
                form = New frmNotaPedidoDetalle(notaPedido, AddressOf CargarVentaCallback)
            Else
                form = New frmVentas(notaPedido, AddressOf CargarVentaCallback)
            End If

            form.MdiParent = MdiParent
            form.Show()
            Visible = False
        End Sub

        Public Async Function CargarVentaCallback() As Task
            Visible = True
            Await CargarNotaPedidoAsync(Numero, EstadoSeleccionado.Key, TipoClienteSeleccionado.Key, FechaDesde, FechaHasta, VendedoresSeleccionado.Key?.Id, NombreCliente)
        End Function

        Public Async Function CargarDatosAsync() As Task
            Dim tareas As List(Of Task) = New List(Of Task)()
            tareas.Add(Buscar())
            tareas.Add(BuscarTotales())
            tareas.Add(CargarEmpleadosAsync())
            Await Task.WhenAll(tareas)
        End Function

        Private Sub CargarEstadosNotaPedido()
            Dim estados As List(Of KeyValuePair(Of NotaPedidoEstado?, String)) = [Enum](Of NotaPedidoEstado).ToKeyValuePairList()
            EstadoSeleccionado = estados.First()
            estados.Insert(0, New KeyValuePair(Of NotaPedidoEstado?, String)(Nothing, "Todos"))
            _Estado = New BindingList(Of KeyValuePair(Of NotaPedidoEstado?, String))(estados)
        End Sub

        Private Sub CargarTipoCliente()
            Dim tiposCliente As List(Of KeyValuePair(Of TipoCliente?, String)) = [Enum](Of TipoCliente).ToKeyValuePairList()
            tiposCliente.Insert(0, New KeyValuePair(Of TipoCliente?, String)(Nothing, "Todos"))
            _TipoCliente = New BindingList(Of KeyValuePair(Of TipoCliente?, String))(tiposCliente)
        End Sub

        Private Async Function CargarEmpleadosAsync() As Task

            Dim vendedores As List(Of Empleado) = Await EmpleadoService.ObtenerEmpleados(TipoEmpleado.Vendedor, IdSucursal)
            Dim vendedoresAux As List(Of KeyValuePair(Of Empleado, String)) = vendedores.Select(Function(x) New KeyValuePair(Of Empleado, String)(x, x.ApellidoYNombre)).ToList()
            vendedoresAux.Insert(0, New KeyValuePair(Of Empleado, String)(Nothing, "Todos"))
            _Vendedores = New BindingList(Of KeyValuePair(Of Empleado, String))(vendedoresAux)
            NotifyPropertyChanged(NameOf(Me.Vendedores))
        End Function

        Private Async Function CargarNotaPedidoAsync(numero As Integer?, estado As NotaPedidoEstado?, tipoCliente As TipoCliente?, fechaDesde As DateTime, fechaHasta As DateTime, IdVendedor As Integer?, nombreCliente As String) As Task

            _NotaPedidosItems = Await NotaPedidoService.ObtenerAsync(IdSucursal, numero, estado, tipoCliente, fechaDesde, fechaHasta, IdVendedor, nombreCliente, NotasPedidosOrdenadoPor, NotasPedidosDireccionOrdenamiento, NotasPedidosPaginaActual, NotasPedidosElementosPorPagina, NotasPedidosTotalElementos)
            NotifyPropertyChanged(NameOf(Me.NotaPedidosItems))
        End Function

        Public Async Function EliminarNotaPedidoAsync(notaPedidoItem As NotaPedidoItemsViewModel) As Task
            Dim notaPedido As NotaPedido = _NotaPedidosItems.FirstOrDefault(Function(x) x.Numero = notaPedidoItem.Numero)
            notaPedido.Eliminar()
            Await NotaPedidoService.ActualizarAsync(notaPedido)
            Await Buscar()
        End Function

        Friend Sub ImprimirNotaPedido(notaPedidoItem As NotaPedidoItemsViewModel, MdiParent As Form)
            Dim notaPedido As NotaPedido = _NotaPedidosItems.FirstOrDefault(Function(x) x.Numero = notaPedidoItem.Numero)

            Dim frmReporteResumenReserva As frmReporteTransaccion = New frmReporteTransaccion("Resumen de Nota Pedido",
                                                                                                    1,
                                                                                                    notaPedido.TipoCliente,
                                                                                                    notaPedido.Vendedor.ApellidoYNombre,
                                                                                                    notaPedidoItem.NombreCliente,
                                                                                                    notaPedido.Fecha,
                                                                                                    notaPedido.NotaPedidoItems.Cast(Of TransaccionItem).ToList(),
                                                                                                    Nothing)
            frmReporteResumenReserva.MdiParent = MdiParent
            frmReporteResumenReserva.Show()
        End Sub

        Public Sub Inicializar()
            FechaDesde = DateTime.Today
            FechaHasta = DateTime.Today
            VendedoresSeleccionado = New KeyValuePair(Of Empleado, String)(Nothing, "Todos")
            EstadoSeleccionado = New KeyValuePair(Of NotaPedidoEstado?, String)(Nothing, "Todos")
            TipoClienteSeleccionado = New KeyValuePair(Of TipoCliente?, String)(Nothing, "Todos")
            NombreCliente = String.Empty

            CargarEstadosNotaPedido()
            CargarTipoCliente()

            _NotaPedidosItems = New List(Of NotaPedido)()
        End Sub

    End Class
End Namespace
