Imports System.ComponentModel
Imports System.Threading.Tasks
Imports Common.Core.Enum
Imports SistemaCinderella.Formularios.Stock
Imports Stock.Data.Service
Imports Ventas.Core.Model.NotaPedidoAgreggate
Imports Ventas.Data.Service

Public Class frmStockEnNotaPedidoViewModel
    Inherits Comunes.Common

    Private IdProducto As Integer
    Private IdSucursal As Integer

    Property StockEnNotaPedidos As BindingList(Of StockEnNotaPedidoItemViewModel)

    Sub New(idSucursal As Integer, idProducto As Integer)
        Me.IdSucursal = idSucursal
        Me.IdProducto = idProducto
    End Sub

    Public Property OrdenadoPor As String = "Fecha"
    Public Property DireccionOrdenamiento As OrdenadoDireccion = OrdenadoDireccion.DESC
    Public Property PaginaActual As Integer = 1
    Public Property ElementosPorPagina As Integer
    Public Property TotalElementos As Integer

    Friend Async Function BuscarAsync() As Task
        Dim estados As List(Of NotaPedidoEstado) = New List(Of NotaPedidoEstado) From {NotaPedidoEstado.Ingresada, NotaPedidoEstado.Venta}

        Dim stocksModel As List(Of NotaPedido) = Await NotaPedidoService.BuscarAsync(IdSucursal, IdProducto, estados, OrdenadoPor, DireccionOrdenamiento, PaginaActual, ElementosPorPagina, TotalElementos)
        StockEnNotaPedidos = New BindingList(Of StockEnNotaPedidoItemViewModel)(stocksModel.Select(Function(x) New StockEnNotaPedidoItemViewModel(IdProducto, x)).ToList())
        NotifyPropertyChanged(NameOf(Me.StockEnNotaPedidos))
    End Function
End Class
