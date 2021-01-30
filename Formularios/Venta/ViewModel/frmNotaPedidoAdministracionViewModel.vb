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

        Public Property NombreCliente As String
        Public ReadOnly Property Cantidad As Integer
            Get
                Return _NotaPedidosItems.Count()
            End Get
        End Property

        Public ReadOnly Property ValorPromedio As Decimal
            Get
                If (NotaPedidosItems.Any()) Then
                    Return _NotaPedidosItems.Average(Function(x) x.MontoTotal.toDecimal())
                Else
                    Return 0
                End If
            End Get
        End Property

        Public ReadOnly Property TotalSinIVA As Decimal
            Get
                Return _NotaPedidosItems.Sum(Function(x) x.MontoTotal.Valor)
            End Get
        End Property

        Public ReadOnly Property Total As Decimal
            Get
                Return _NotaPedidosItems.Sum(Function(x) x.MontoTotal.toDecimal())
            End Get
        End Property

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
            Await CargarNotaPedidoAsync(EstadoSeleccionado.Key, TipoClienteSeleccionado.Key, FechaDesde, FechaHasta, VendedoresSeleccionado.Key?.Id, NombreCliente)
        End Function

        Public Sub CargarVenta(notaPedidoItem As NotaPedidoItemsViewModel, MdiParent As Form)
            Dim notaPedido As NotaPedido = _NotaPedidosItems.FirstOrDefault(Function(x) x.Id = notaPedidoItem.Id)
            Dim frmNotaPedidoDetalle As frmNotaPedidoDetalle = New frmNotaPedidoDetalle(notaPedido, AddressOf CargarVentaCallback)
            frmNotaPedidoDetalle.MdiParent = MdiParent
            frmNotaPedidoDetalle.Show()
            Visible = False
        End Sub

        Public Async Function CargarVentaCallback() As Task
            Visible = True
            Await CargarNotaPedidoAsync(EstadoSeleccionado.Key, TipoClienteSeleccionado.Key, FechaDesde, FechaHasta, VendedoresSeleccionado.Key?.Id, NombreCliente)
        End Function

        Public Async Function CargarDatosAsync() As Task
            Dim tareas As List(Of Task) = New List(Of Task)()
            tareas.Add(Buscar())
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

        Private Async Function CargarNotaPedidoAsync(estado As NotaPedidoEstado?, tipoCliente As TipoCliente?, fechaDesde As DateTime, fechaHasta As DateTime, IdVendedor As Integer?, nombreCliente As String) As Task
            _NotaPedidosItems = Await NotaPedidoService.ObtenerAsync(IdSucursal, estado, tipoCliente, fechaDesde, fechaHasta, IdVendedor, nombreCliente, NotasPedidosOrdenadoPor, NotasPedidosDireccionOrdenamiento, NotasPedidosPaginaActual, NotasPedidosElementosPorPagina, NotasPedidosTotalElementos)
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

        Private Sub Inicializar()
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

        Public Async Function RestablecerAsync() As Task
            Inicializar()
            Await Buscar()
        End Function

    End Class
End Namespace
