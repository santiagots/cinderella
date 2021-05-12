Imports System.ComponentModel
Imports System.Threading.Tasks
Imports Common.Core.Enum
Imports Stock.Core.Model.BaseAgreggate
Imports Stock.Data.Service

Namespace Formularios.Stock
    Public Class frmStockBitacoraViewModel
        Inherits Comunes.Common

        Private ReadOnly IdSucursal As Integer

        Public Property FechaDesde As Date
        Public Property FechaHasta As Date
        Property Bitacoras As BindingList(Of StockBitacoraItemViewModel) = New BindingList(Of StockBitacoraItemViewModel)()
        Public Property Total As Decimal?

        Public Property OrdenadoPor As String = "Fecha"
        Public Property DireccionOrdenamiento As OrdenadoDireccion = OrdenadoDireccion.DESC
        Public Property PaginaActual As Integer = 1
        Public Property ElementosPorPagina As Integer
        Public Property TotalElementos As Integer

        Public ReadOnly Property SinResultados As Boolean
            Get
                Return Not Bitacoras.Any()
            End Get
        End Property

        Sub New(IdSucursal As Integer)
            Me.IdSucursal = IdSucursal
            FechaDesde = Date.Now.AddDays(-30)
            FechaHasta = Date.Now
        End Sub

        Friend Async Function BuscarAsync() As Task
            Dim bitacorasModel As List(Of Bitacora) = Await BitacoraService.BuscarAsync(IdSucursal, FechaDesde, FechaHasta, OrdenadoPor, DireccionOrdenamiento, PaginaActual, ElementosPorPagina, TotalElementos)
            Bitacoras = New BindingList(Of StockBitacoraItemViewModel)(bitacorasModel.Select(Function(x) New StockBitacoraItemViewModel(x)).ToList())

            Total = Await BitacoraService.TotalAsync(IdSucursal, FechaDesde, FechaHasta)
            NotifyPropertyChanged(NameOf(Me.Bitacoras))
        End Function
    End Class
End Namespace
