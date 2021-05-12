Imports System.ComponentModel
Imports System.Threading.Tasks
Imports Common.Core.Enum
Imports Common.Core.Exceptions
Imports Common.Core.Model
Imports Common.Data.Service
Imports Stock.Data.Service
Imports Model = Stock.Core.Model.BaseAgreggate

Namespace Formularios.Stock
    Public Class frmStockViewModel
        Inherits Comunes.Common

        Private ReadOnly IdSucursal As Integer
        Private Usuario As Usuario
        Private Productos As List(Of Model.Producto) = New List(Of Model.Producto)

        Public Property FiltroPorCodigoNombre As String
        Property Stocks As BindingList(Of StockItemViewModel)
        Property AltaStock As StockItemViewModel
        Property ModificacionStock As StockItemViewModel

        Public Property OrdenadoPor As String = "Producto.Codigo"
        Public Property DireccionOrdenamiento As OrdenadoDireccion = OrdenadoDireccion.DESC
        Public Property PaginaActual As Integer = 1
        Public Property ElementosPorPagina As Integer
        Public Property TotalElementos As Integer

        Public ReadOnly Property SinResultados As Boolean
            Get
                Return Not Stocks.Any()
            End Get
        End Property

        Public Property NombreCodigoProductos As List(Of String)

        Sub New(IdSucursal As Integer)
            Me.IdSucursal = IdSucursal
            AltaStock = New StockItemViewModel(VariablesGlobales.objUsuario.Nombre)
            ModificacionStock = New StockItemViewModel(VariablesGlobales.objUsuario.Nombre)
            Stocks = New BindingList(Of StockItemViewModel)()
        End Sub

        Friend Async Function AltaAsync() As Task
            Dim producto As Model.Producto = Productos.FirstOrDefault(Function(x) x.Codigo.ToUpper() = AltaStock.Codigo.ToUpper() _
                                                                                OrElse x.Nombre.ToUpper() = AltaStock.Codigo.ToUpper())

            If (producto Is Nothing) Then
                Throw New NegocioException("El producto ingresado no existe")
            End If

            Dim stockModel As Model.Stock = New Model.Stock(My.Settings.Sucursal, producto, AltaStock.Actual, AltaStock.Minimo, AltaStock.Optimo, AltaStock.Habilitado, Usuario)

            Await StockService.GuardarAsync(stockModel)

            AltaStock.limpiar()
        End Function

        Friend Async Function ActualizarAsync() As Task
            Dim stockModel As Model.Stock = ModificacionStock.Stock

            stockModel.Actualiza(ModificacionStock.Actual, ModificacionStock.Minimo, ModificacionStock.Optimo, Nothing, ModificacionStock.Habilitado, ModificacionStock.NuevaModificacionMotivo, False, Usuario)
            Await StockService.ActualizarAsync(stockModel)
        End Function

        Friend Async Function EliminarAsync() As Task
            Dim stockModel As Model.Stock = ModificacionStock.Stock

            stockModel.Actualiza(Nothing, Nothing, Nothing, Nothing, Nothing, ModificacionStock.NuevaModificacionMotivo, True, Usuario)
            Await StockService.ActualizarAsync(stockModel)
        End Function

        Friend Async Function BuscarAsync() As Task
            Dim stocksModel As List(Of Model.Stock) = Await StockService.BuscarAsync(IdSucursal, FiltroPorCodigoNombre, OrdenadoPor, DireccionOrdenamiento, PaginaActual, ElementosPorPagina, TotalElementos)
            Stocks = New BindingList(Of StockItemViewModel)(stocksModel.Select(Function(x) New StockItemViewModel(x, VariablesGlobales.objUsuario.Nombre)).ToList())
            NotifyPropertyChanged(NameOf(Me.Stocks))
        End Function

        Friend Async Function CargarAsync() As Task
            Await Task.WhenAll(
                CargarProductoNombreYCodigoAsync(),
                CargarUsuario())

            NotifyPropertyChanged(NameOf(Me.NombreCodigoProductos))
        End Function

        Friend Sub Modificar(stock As StockItemViewModel)
            ModificacionStock = stock
            NotifyPropertyChanged(NameOf(Me.ModificacionStock))
        End Sub

        Private Async Function CargarProductoNombreYCodigoAsync() As Task
            Productos = Await Task.Run(Function() ProductoService.ObtenerListaProductosAsync())

            NombreCodigoProductos = New List(Of String)

            Productos.ToList().ForEach(Sub(x) NombreCodigoProductos.Add(x.Codigo))
            Productos.ToList().ForEach(Sub(x) NombreCodigoProductos.Add(x.Nombre))
        End Function

        Private Async Function CargarUsuario() As Task
            Usuario = Await UsuarioService.ObtenerAsync(VariablesGlobales.objUsuario.id_Usuario)
        End Function
    End Class
End Namespace
