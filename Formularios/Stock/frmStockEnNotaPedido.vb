Imports System.Threading.Tasks

Public Class frmStockEnNotaPedido

    Private IdProducto As Integer

    Dim frmStockEnNotaPedidoViewModel As frmStockEnNotaPedidoViewModel

    Sub New(idProducto As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.IdProducto = idProducto
    End Sub

    Private Sub frmStockEnNotaPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EjecutarAsync(Async Function() As Task
                          frmStockEnNotaPedidoViewModel = New frmStockEnNotaPedidoViewModel(My.Settings.Sucursal, IdProducto)
                          frmStockEnNotaPedidoViewModel.ElementosPorPagina = Paginado.ElementosPorPagina
                          Await frmStockEnNotaPedidoViewModel.BuscarAsync()
                          StockEnNotaPedidoItemViewModelBindingSource.DataSource = frmStockEnNotaPedidoViewModel.StockEnNotaPedidos
                      End Function)
    End Sub
End Class