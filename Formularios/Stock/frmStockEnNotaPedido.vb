Imports System.Threading.Tasks
Imports SistemaCinderella.Formularios.Stock
Imports SistemaCinderella.Formularios.Venta.frmVentasViewModel

Public Class frmStockEnNotaPedido

    Private IdProducto As Integer
    Private ActualizarPantallaCallback As FinalizarDelegateAsync
    Private MdiParent As Form

    Dim frmStockEnNotaPedidoViewModel As frmStockEnNotaPedidoViewModel

    Sub New(idProducto As Integer, mdiParent As Form, actualizarPantallaCallback As FinalizarDelegateAsync)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.IdProducto = idProducto
        Me.ActualizarPantallaCallback = actualizarPantallaCallback
        Me.MdiParent = mdiParent
    End Sub

    Private Sub frmStockEnNotaPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EjecutarAsync(Async Function() As Task
                          frmStockEnNotaPedidoViewModel = New frmStockEnNotaPedidoViewModel(My.Settings.Sucursal, IdProducto)
                          frmStockEnNotaPedidoViewModel.ElementosPorPagina = Paginado.ElementosPorPagina
                          Await frmStockEnNotaPedidoViewModel.BuscarAsync()
                          StockEnNotaPedidoItemViewModelBindingSource.DataSource = frmStockEnNotaPedidoViewModel.StockEnNotaPedidos
                      End Function)
    End Sub

    Private Sub dgvMovimientosDetalle_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMovimientosDetalle.CellContentClick
        Ejecutar(Sub()
                     If dgvMovimientosDetalle.Columns(e.ColumnIndex).Name = "Detalle" Then
                         MostrarDetalle()
                         Me.Close()
                     End If
                 End Sub)
    End Sub

    Private Sub dgvMovimientosDetalle_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMovimientosDetalle.CellDoubleClick
        Ejecutar(Sub()
                     MostrarDetalle()
                     Me.Close()
                 End Sub)
    End Sub

    Private Sub MostrarDetalle()
        Dim stockEnNotaPedidoItemViewModel As StockEnNotaPedidoItemViewModel = dgvMovimientosDetalle.CurrentRow.DataBoundItem
        Dim form As Form

        If (stockEnNotaPedidoItemViewModel.NotaPedido.TipoCliente = Common.Core.Enum.TipoCliente.Mayorista) Then
            form = New frmNotaPedidoDetalle(stockEnNotaPedidoItemViewModel.NotaPedido, ActualizarPantallaCallback)
        Else
            form = New frmVentas(stockEnNotaPedidoItemViewModel.NotaPedido, ActualizarPantallaCallback)
        End If

        If (MdiParent IsNot Nothing) Then
            form.MdiParent = MdiParent
            form.Show()
        Else
            form.ShowDialog()
        End If
    End Sub

End Class