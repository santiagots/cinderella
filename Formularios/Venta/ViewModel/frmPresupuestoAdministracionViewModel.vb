Imports System.ComponentModel
Imports System.Threading.Tasks
Imports Common.Core.Enum
Imports Ventas.Core.Model.PresupuestoAgreggate
Imports Ventas.Data.Service

Namespace Formularios.Venta
    Public Class frmPresupuestoAdministracionViewModel
        Inherits Comunes.Common

        Private ReadOnly IdSucursal As Integer

        Public Property Numero As Integer?
        Public Property Cliente As String
        Public Property FechaDesde As DateTime
        Public Property FechaHasta As DateTime

        Private _Presupuestos As IList(Of Presupuesto)
        Public ReadOnly Property Presupuestos As BindingList(Of PresupuestoItemsViewModel)
            Get
                Return New BindingList(Of PresupuestoItemsViewModel)(_Presupuestos.Select(Function(x) New PresupuestoItemsViewModel(x)).ToList())
            End Get
        End Property

        Public Property PresupuestoDetalle As frmPresupuestoDetalleViewModel

        Public ReadOnly Property SinResultados As Boolean
            Get
                Return Not Presupuestos.Any()
            End Get
        End Property

        Public Property OrdenadoPor As String = "Fecha"
        Public Property DireccionOrdenamiento As OrdenadoDireccion = OrdenadoDireccion.DESC
        Public Property PaginaActual As Integer = 1
        Public Property ElementosPorPagina As Integer
        Public Property TotalElementos As Integer

        Sub New(IdSucursal As Integer)
            Me.IdSucursal = IdSucursal
            Inicializar()
        End Sub

        Public Sub Inicializar()
            FechaDesde = DateTime.Today.AddDays(-7)
            FechaHasta = DateTime.Today
            Cliente = String.Empty
            Numero = Nothing
            _Presupuestos = New List(Of Presupuesto)()
        End Sub

        Friend Async Function BuscarAsync() As Task
            _Presupuestos = Await PresupuestoService.BuscarAsync(IdSucursal, Numero, Cliente, FechaDesde, FechaHasta, OrdenadoPor, DireccionOrdenamiento, PaginaActual, ElementosPorPagina, TotalElementos)
            NotifyPropertyChanged(NameOf(Me.Presupuestos))
        End Function

        Friend Sub CargarPresupuesto(presupuestoVM As PresupuestoItemsViewModel)
            PresupuestoDetalle = New frmPresupuestoDetalleViewModel(presupuestoVM.PresupuestoModel)
            NotifyPropertyChanged(NameOf(Me.PresupuestoDetalle))
        End Sub

        Friend Async Function AnularAsync() As Task
            PresupuestoDetalle.PresupuestoModel.Anular(PresupuestoDetalle.AnuladaMotivo, $"{VariablesGlobales.objUsuario.Apellido}, {VariablesGlobales.objUsuario.Nombre}")
            Await PresupuestoService.GuardarAsync(PresupuestoDetalle.PresupuestoModel)
            NotifyPropertyChanged(NameOf(Me.PresupuestoDetalle))
        End Function
    End Class
End Namespace
