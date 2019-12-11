Imports System.Threading.Tasks
Imports System.Windows.Forms.DataVisualization.Charting
Imports Common.Core.Enum
Imports Common.Core.Exceptions
Imports Entidades
Imports Negocio
Imports SistemaCinderella.Formularios.InformeVenta
Imports Ventas.Core.Model.BaseAgreggate

Public Class frmInformeVentas2

    Private frmInformeVentasViewModel As frmInformeVentasViewModel

    Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        frmInformeVentasViewModel = New frmInformeVentasViewModel()
    End Sub

    Private Sub frmInformeVentas2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EjecutarAsync(Async Function() As Task
                          FrmInformeVentasViewModelBindingSource.DataSource = frmInformeVentasViewModel
                          Await frmInformeVentasViewModel.CargarAsync()
                          Await frmInformeVentasViewModel.BuscarAsync()
                          CaragrListBox(Of Sucursal)(frmInformeVentasViewModel.SucursalesSeleccionadas, lbSucursales)
                          ActualizarIconoOrdenamiento()
                      End Function)
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        EjecutarAsync(Async Function() As Task
                          frmInformeVentasViewModel.SucursalesSeleccionadas = ObtenerListBox(Of Sucursal)(lbSucursales)
                          Await frmInformeVentasViewModel.BuscarAsync()
                          CaragrListBox(Of Sucursal)(frmInformeVentasViewModel.SucursalesSeleccionadas, lbSucursales)
                          ActualizarIconoOrdenamiento()
                      End Function)
    End Sub

    Private Sub BuscarProducto_Click(sender As Object, e As EventArgs) Handles BuscarProducto.Click
        EjecutarAsync(Async Function() As Task
                          frmInformeVentasViewModel.SucursalesSeleccionadas = ObtenerListBox(Of Sucursal)(lbSucursales)
                          Await frmInformeVentasViewModel.BuscarProductoAsync()
                          CaragrListBox(Of Sucursal)(frmInformeVentasViewModel.SucursalesSeleccionadas, lbSucursales)
                          ActualizarIconoOrdenamiento()
                      End Function)
    End Sub

    Private Sub btnGrafico_Click(sender As Object, e As EventArgs) Handles btnGrafico.Click
        EjecutarAsync(Async Function() As Task
                          Dim cantidad As Integer = 0
                          Dim Funciones As New Funciones

                          If (TabInformes.SelectedTab.Name = tabVentas.Name) Then
                              Dim informeGraficoVentas As FrmInformeGraficoVentas2 = New FrmInformeGraficoVentas2(frmInformeVentasViewModel.InformeVentaPorTipoVenta, frmInformeVentasViewModel.InformeVentaPorTipoPago, frmInformeVentasViewModel.InformeVentaPorFecha)
                              informeGraficoVentas.ShowDialog()
                          End If

                          If (TabInformes.SelectedTab.Name = tabProductos.Name) Then
                              Dim informeGraficoVentas As FrmInformeGraficoProducto = New FrmInformeGraficoProducto(frmInformeVentasViewModel.ObtenerIdSucursales, frmInformeVentasViewModel.FechaDesde, frmInformeVentasViewModel.FechaHasta)
                              Await informeGraficoVentas.CargarDatosAsync()
                              informeGraficoVentas.ShowDialog()
                          End If

                          If (TabInformes.SelectedTab.Name = tabEgresos.Name) Then
                              Dim informeGraficoEgresos As FrmInformeGraficoEgresos = New FrmInformeGraficoEgresos(frmInformeVentasViewModel.InformeGastos, frmInformeVentasViewModel.InformeCostos)
                              informeGraficoEgresos.ShowDialog()
                          End If
                      End Function)
    End Sub

    Private Sub dgvVentas_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvVentas.ColumnHeaderMouseClick
        EjecutarAsync(Async Function() As Task
                          If (dgvVentas.Columns(e.ColumnIndex).SortMode <> DataGridViewColumnSortMode.NotSortable) Then
                              frmInformeVentasViewModel.SucursalesSeleccionadas = ObtenerListBox(Of Sucursal)(lbSucursales)
                              frmInformeVentasViewModel.VentaPorDiaOrdenadoPor = dgvVentas.Columns(e.ColumnIndex).DataPropertyName
                              frmInformeVentasViewModel.VentaPorDiaOrdenadoDireccion = If(frmInformeVentasViewModel.VentaPorDiaOrdenadoDireccion = OrdenadoDireccion.ASC, OrdenadoDireccion.DESC, OrdenadoDireccion.ASC)
                              Await frmInformeVentasViewModel.CargarVentasPorFechaAsync()
                              CaragrListBox(Of Sucursal)(frmInformeVentasViewModel.SucursalesSeleccionadas, lbSucursales)
                              ActualizarIconoOrdenamiento()
                          End If
                      End Function)
    End Sub

    Private Sub BindingNavigatorMoveNextItemTotalPorDia_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveNextItemTotalPorDia.Click
        EjecutarAsync(Async Function() As Task
                          frmInformeVentasViewModel.SucursalesSeleccionadas = ObtenerListBox(Of Sucursal)(lbSucursales)
                          frmInformeVentasViewModel.PaginasActualTotalPorDia += 1
                          Await frmInformeVentasViewModel.CargarVentasPorFechaAsync()
                          CaragrListBox(Of Sucursal)(frmInformeVentasViewModel.SucursalesSeleccionadas, lbSucursales)
                          ActualizarIconoOrdenamiento()
                      End Function)
    End Sub

    Private Sub BindingNavigatorMoveFirstItemTotalPorDia_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveFirstItemTotalPorDia.Click
        EjecutarAsync(Async Function() As Task
                          frmInformeVentasViewModel.SucursalesSeleccionadas = ObtenerListBox(Of Sucursal)(lbSucursales)
                          frmInformeVentasViewModel.PaginasActualTotalPorDia = 0
                          Await frmInformeVentasViewModel.CargarVentasPorFechaAsync()
                          CaragrListBox(Of Sucursal)(frmInformeVentasViewModel.SucursalesSeleccionadas, lbSucursales)
                          ActualizarIconoOrdenamiento()
                      End Function)
    End Sub

    Private Sub BindingNavigatorMovePreviousItemTotalPorDia_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMovePreviousItemTotalPorDia.Click
        EjecutarAsync(Async Function() As Task
                          frmInformeVentasViewModel.SucursalesSeleccionadas = ObtenerListBox(Of Sucursal)(lbSucursales)
                          frmInformeVentasViewModel.PaginasActualTotalPorDia -= 1
                          Await frmInformeVentasViewModel.CargarVentasPorFechaAsync()
                          CaragrListBox(Of Sucursal)(frmInformeVentasViewModel.SucursalesSeleccionadas, lbSucursales)
                          ActualizarIconoOrdenamiento()
                      End Function)
    End Sub

    Private Sub BindingNavigatorMoveLastItemTotalPorDia_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveLastItemTotalPorDia.Click
        EjecutarAsync(Async Function() As Task
                          frmInformeVentasViewModel.SucursalesSeleccionadas = ObtenerListBox(Of Sucursal)(lbSucursales)
                          frmInformeVentasViewModel.PaginasActualTotalPorDia = frmInformeVentasViewModel.PaginasTotalPorDia.Count - 1
                          Await frmInformeVentasViewModel.CargarVentasPorFechaAsync()
                          CaragrListBox(Of Sucursal)(frmInformeVentasViewModel.SucursalesSeleccionadas, lbSucursales)
                          ActualizarIconoOrdenamiento()
                      End Function)
    End Sub

    Private Sub BindingNavigatorMoveNextProducto_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveNextProducto.Click
        EjecutarAsync(Async Function() As Task
                          frmInformeVentasViewModel.SucursalesSeleccionadas = ObtenerListBox(Of Sucursal)(lbSucursales)
                          frmInformeVentasViewModel.PaginasActualProductos += 1
                          Await frmInformeVentasViewModel.CargarProductoPorNombreAsync()
                          CaragrListBox(Of Sucursal)(frmInformeVentasViewModel.SucursalesSeleccionadas, lbSucursales)
                          ActualizarIconoOrdenamiento()
                      End Function)
    End Sub

    Private Sub BindingNavigatorMovePreviousProducto_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMovePreviousProducto.Click
        EjecutarAsync(Async Function() As Task
                          frmInformeVentasViewModel.SucursalesSeleccionadas = ObtenerListBox(Of Sucursal)(lbSucursales)
                          frmInformeVentasViewModel.PaginasActualProductos -= 1
                          Await frmInformeVentasViewModel.CargarProductoPorNombreAsync()
                          CaragrListBox(Of Sucursal)(frmInformeVentasViewModel.SucursalesSeleccionadas, lbSucursales)
                          ActualizarIconoOrdenamiento()
                      End Function)
    End Sub

    Private Sub BindingNavigatorMoveLastProducto_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveLastProducto.Click
        EjecutarAsync(Async Function() As Task
                          frmInformeVentasViewModel.SucursalesSeleccionadas = ObtenerListBox(Of Sucursal)(lbSucursales)
                          frmInformeVentasViewModel.PaginasActualProductos = frmInformeVentasViewModel.PaginasProductos.Count - 1
                          Await frmInformeVentasViewModel.CargarProductoPorNombreAsync()
                          CaragrListBox(Of Sucursal)(frmInformeVentasViewModel.SucursalesSeleccionadas, lbSucursales)
                          ActualizarIconoOrdenamiento()
                      End Function)
    End Sub

    Private Sub BindingNavigatorMoveFirstProducto_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveFirstProducto.Click
        EjecutarAsync(Async Function() As Task
                          frmInformeVentasViewModel.SucursalesSeleccionadas = ObtenerListBox(Of Sucursal)(lbSucursales)
                          frmInformeVentasViewModel.PaginasActualProductos = 0
                          Await frmInformeVentasViewModel.CargarProductoPorNombreAsync()
                          CaragrListBox(Of Sucursal)(frmInformeVentasViewModel.SucursalesSeleccionadas, lbSucursales)
                          ActualizarIconoOrdenamiento()
                      End Function)
    End Sub

    Private Sub dgvProductos_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvProductos.ColumnHeaderMouseClick
        EjecutarAsync(Async Function() As Task
                          frmInformeVentasViewModel.SucursalesSeleccionadas = ObtenerListBox(Of Sucursal)(lbSucursales)
                          If (dgvProductos.Columns(e.ColumnIndex).SortMode <> DataGridViewColumnSortMode.NotSortable) Then
                              frmInformeVentasViewModel.ProductoNombreOrdenadoPor = dgvProductos.Columns(e.ColumnIndex).DataPropertyName
                              frmInformeVentasViewModel.ProductoNombreOrdenadoDireccion = If(frmInformeVentasViewModel.ProductoNombreOrdenadoDireccion = OrdenadoDireccion.ASC, OrdenadoDireccion.DESC, OrdenadoDireccion.ASC)
                              Await frmInformeVentasViewModel.CargarProductoPorNombreAsync()
                              CaragrListBox(Of Sucursal)(frmInformeVentasViewModel.SucursalesSeleccionadas, lbSucursales)
                              ActualizarIconoOrdenamiento()
                          End If
                      End Function)
    End Sub

    Private Sub BindingNavigatorMoveNextCategoria_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveNextCategoria.Click
        EjecutarAsync(Async Function() As Task
                          frmInformeVentasViewModel.SucursalesSeleccionadas = ObtenerListBox(Of Sucursal)(lbSucursales)
                          frmInformeVentasViewModel.PaginasActualProductosPorCategoria += 1
                          Await frmInformeVentasViewModel.CargarProductoPorCategoriaAsync()
                          CaragrListBox(Of Sucursal)(frmInformeVentasViewModel.SucursalesSeleccionadas, lbSucursales)
                          ActualizarIconoOrdenamiento()
                      End Function)
    End Sub

    Private Sub BindingNavigatorMoveLastCategoria_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveLastCategoria.Click
        EjecutarAsync(Async Function() As Task
                          frmInformeVentasViewModel.SucursalesSeleccionadas = ObtenerListBox(Of Sucursal)(lbSucursales)
                          frmInformeVentasViewModel.PaginasActualProductosPorCategoria = frmInformeVentasViewModel.PaginasProductosPorCategoria.Count - 1
                          Await frmInformeVentasViewModel.CargarProductoPorCategoriaAsync()
                          CaragrListBox(Of Sucursal)(frmInformeVentasViewModel.SucursalesSeleccionadas, lbSucursales)
                          ActualizarIconoOrdenamiento()
                      End Function)
    End Sub

    Private Sub BindingNavigatorMovePreviousCategoria_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMovePreviousCategoria.Click
        EjecutarAsync(Async Function() As Task
                          frmInformeVentasViewModel.SucursalesSeleccionadas = ObtenerListBox(Of Sucursal)(lbSucursales)
                          frmInformeVentasViewModel.PaginasActualProductosPorCategoria -= 1
                          Await frmInformeVentasViewModel.CargarProductoPorCategoriaAsync()
                          CaragrListBox(Of Sucursal)(frmInformeVentasViewModel.SucursalesSeleccionadas, lbSucursales)
                          ActualizarIconoOrdenamiento()
                      End Function)
    End Sub

    Private Sub BindingNavigatorMoveFirstCategoria_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveFirstCategoria.Click
        EjecutarAsync(Async Function() As Task
                          frmInformeVentasViewModel.SucursalesSeleccionadas = ObtenerListBox(Of Sucursal)(lbSucursales)
                          frmInformeVentasViewModel.PaginasActualProductosPorCategoria = 0
                          Await frmInformeVentasViewModel.CargarProductoPorCategoriaAsync()
                          CaragrListBox(Of Sucursal)(frmInformeVentasViewModel.SucursalesSeleccionadas, lbSucursales)
                          ActualizarIconoOrdenamiento()
                      End Function)
    End Sub

    Private Sub dgvCategorias_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvCategorias.ColumnHeaderMouseClick
        EjecutarAsync(Async Function() As Task
                          frmInformeVentasViewModel.SucursalesSeleccionadas = ObtenerListBox(Of Sucursal)(lbSucursales)
                          If (dgvCategorias.Columns(e.ColumnIndex).SortMode <> DataGridViewColumnSortMode.NotSortable) Then
                              frmInformeVentasViewModel.ProductoCategoriaOrdenadoPor = dgvCategorias.Columns(e.ColumnIndex).DataPropertyName
                              frmInformeVentasViewModel.ProductoCategoriaOrdenadoDireccion = If(frmInformeVentasViewModel.ProductoCategoriaOrdenadoDireccion = OrdenadoDireccion.ASC, OrdenadoDireccion.DESC, OrdenadoDireccion.ASC)
                              Await frmInformeVentasViewModel.CargarProductoPorCategoriaAsync()
                              CaragrListBox(Of Sucursal)(frmInformeVentasViewModel.SucursalesSeleccionadas, lbSucursales)
                              ActualizarIconoOrdenamiento()
                          End If
                      End Function)
    End Sub

    Private Sub BindingNavigatorMoveNextSubcategoria_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveNextSubcategoria.Click
        EjecutarAsync(Async Function() As Task
                          frmInformeVentasViewModel.SucursalesSeleccionadas = ObtenerListBox(Of Sucursal)(lbSucursales)
                          frmInformeVentasViewModel.PaginasActualProductosPorSubcategoria += 1
                          Await frmInformeVentasViewModel.CargarProductoPorSubCategoriaAsync()
                          CaragrListBox(Of Sucursal)(frmInformeVentasViewModel.SucursalesSeleccionadas, lbSucursales)
                          ActualizarIconoOrdenamiento()
                      End Function)
    End Sub

    Private Sub BindingNavigatorMoveLastSubcategoria_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveLastSubcategoria.Click
        EjecutarAsync(Async Function() As Task
                          frmInformeVentasViewModel.SucursalesSeleccionadas = ObtenerListBox(Of Sucursal)(lbSucursales)
                          frmInformeVentasViewModel.PaginasActualProductosPorSubcategoria = frmInformeVentasViewModel.PaginasProductosPorSubcategoria.Count - 1
                          Await frmInformeVentasViewModel.CargarProductoPorSubCategoriaAsync()
                          CaragrListBox(Of Sucursal)(frmInformeVentasViewModel.SucursalesSeleccionadas, lbSucursales)
                          ActualizarIconoOrdenamiento()
                      End Function)

    End Sub

    Private Sub BindingNavigatorMovePreviousSubcategoria_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMovePreviousSubcategoria.Click
        EjecutarAsync(Async Function() As Task
                          frmInformeVentasViewModel.SucursalesSeleccionadas = ObtenerListBox(Of Sucursal)(lbSucursales)
                          frmInformeVentasViewModel.PaginasActualProductosPorSubcategoria -= 1
                          Await frmInformeVentasViewModel.CargarProductoPorSubCategoriaAsync()
                          CaragrListBox(Of Sucursal)(frmInformeVentasViewModel.SucursalesSeleccionadas, lbSucursales)
                          ActualizarIconoOrdenamiento()
                      End Function)
    End Sub

    Private Sub BindingNavigatorMoveFirstSubcategoria_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveFirstSubcategoria.Click
        EjecutarAsync(Async Function() As Task
                          frmInformeVentasViewModel.SucursalesSeleccionadas = ObtenerListBox(Of Sucursal)(lbSucursales)
                          frmInformeVentasViewModel.PaginasActualProductosPorSubcategoria = 0
                          Await frmInformeVentasViewModel.CargarProductoPorSubCategoriaAsync()
                          CaragrListBox(Of Sucursal)(frmInformeVentasViewModel.SucursalesSeleccionadas, lbSucursales)
                          ActualizarIconoOrdenamiento()
                      End Function)
    End Sub

    Private Sub dgvSubCategorias_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvSubCategorias.ColumnHeaderMouseClick
        EjecutarAsync(Async Function() As Task
                          frmInformeVentasViewModel.SucursalesSeleccionadas = ObtenerListBox(Of Sucursal)(lbSucursales)
                          If (dgvSubCategorias.Columns(e.ColumnIndex).SortMode <> DataGridViewColumnSortMode.NotSortable) Then
                              frmInformeVentasViewModel.ProductoSubcategOriardenadoPor = dgvSubCategorias.Columns(e.ColumnIndex).DataPropertyName
                              frmInformeVentasViewModel.ProductoSubcategoriarOrdenadoDireccion = If(frmInformeVentasViewModel.ProductoSubcategoriarOrdenadoDireccion = OrdenadoDireccion.ASC, OrdenadoDireccion.DESC, OrdenadoDireccion.ASC)
                              Await frmInformeVentasViewModel.CargarProductoPorSubCategoriaAsync()
                              CaragrListBox(Of Sucursal)(frmInformeVentasViewModel.SucursalesSeleccionadas, lbSucursales)
                              ActualizarIconoOrdenamiento()
                          End If
                      End Function)
    End Sub

    Private Sub BindingNavigatorMoveNextMercaderia_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveNextMercaderia.Click
        EjecutarAsync(Async Function() As Task
                          frmInformeVentasViewModel.SucursalesSeleccionadas = ObtenerListBox(Of Sucursal)(lbSucursales)
                          frmInformeVentasViewModel.PaginasActualMercaderia += 1
                          Await frmInformeVentasViewModel.CargarMercaderiaAsync(frmInformeVentasViewModel.TotalMontoMercaderia, frmInformeVentasViewModel.TotalMontoVenta)
                          CaragrListBox(Of Sucursal)(frmInformeVentasViewModel.SucursalesSeleccionadas, lbSucursales)
                          ActualizarIconoOrdenamiento()
                      End Function)
    End Sub

    Private Sub BindingNavigatorMoveLastMercaderia_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveLastMercaderia.Click
        EjecutarAsync(Async Function() As Task
                          frmInformeVentasViewModel.SucursalesSeleccionadas = ObtenerListBox(Of Sucursal)(lbSucursales)
                          frmInformeVentasViewModel.PaginasActualMercaderia = frmInformeVentasViewModel.PaginasMercaderia.Count - 1
                          Await frmInformeVentasViewModel.CargarMercaderiaAsync(frmInformeVentasViewModel.TotalMontoMercaderia, frmInformeVentasViewModel.TotalMontoVenta)
                          CaragrListBox(Of Sucursal)(frmInformeVentasViewModel.SucursalesSeleccionadas, lbSucursales)
                          ActualizarIconoOrdenamiento()
                      End Function)
    End Sub

    Private Sub BindingNavigatorMovePreviousMercaderia_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMovePreviousMercaderia.Click
        EjecutarAsync(Async Function() As Task
                          frmInformeVentasViewModel.SucursalesSeleccionadas = ObtenerListBox(Of Sucursal)(lbSucursales)
                          frmInformeVentasViewModel.PaginasActualMercaderia -= 1
                          Await frmInformeVentasViewModel.CargarMercaderiaAsync(frmInformeVentasViewModel.TotalMontoMercaderia, frmInformeVentasViewModel.TotalMontoVenta)
                          CaragrListBox(Of Sucursal)(frmInformeVentasViewModel.SucursalesSeleccionadas, lbSucursales)
                          ActualizarIconoOrdenamiento()
                      End Function)
    End Sub

    Private Sub BindingNavigatorMoveFirstMercaderia_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveFirstMercaderia.Click
        EjecutarAsync(Async Function() As Task
                          frmInformeVentasViewModel.SucursalesSeleccionadas = ObtenerListBox(Of Sucursal)(lbSucursales)
                          frmInformeVentasViewModel.PaginasActualMercaderia = 0
                          Await frmInformeVentasViewModel.CargarMercaderiaAsync(frmInformeVentasViewModel.TotalMontoMercaderia, frmInformeVentasViewModel.TotalMontoVenta)
                          CaragrListBox(Of Sucursal)(frmInformeVentasViewModel.SucursalesSeleccionadas, lbSucursales)
                          ActualizarIconoOrdenamiento()
                      End Function)
    End Sub

    Private Sub dgvMercaderiaRecibida_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvMercaderiaRecibida.ColumnHeaderMouseClick
        EjecutarAsync(Async Function() As Task
                          If (dgvMercaderiaRecibida.Columns(e.ColumnIndex).SortMode <> DataGridViewColumnSortMode.NotSortable) Then
                              frmInformeVentasViewModel.SucursalesSeleccionadas = ObtenerListBox(Of Sucursal)(lbSucursales)
                              frmInformeVentasViewModel.MercaderiaOriardenadoPor = dgvMercaderiaRecibida.Columns(e.ColumnIndex).DataPropertyName
                              frmInformeVentasViewModel.MercaderiaOrdenadoDireccion = If(frmInformeVentasViewModel.MercaderiaOrdenadoDireccion = OrdenadoDireccion.ASC, OrdenadoDireccion.DESC, OrdenadoDireccion.ASC)
                              Await frmInformeVentasViewModel.CargarMercaderiaAsync(frmInformeVentasViewModel.TotalMontoMercaderia, frmInformeVentasViewModel.TotalMontoVenta)
                              CaragrListBox(Of Sucursal)(frmInformeVentasViewModel.SucursalesSeleccionadas, lbSucursales)
                              ActualizarIconoOrdenamiento()
                          End If
                      End Function)
    End Sub

    Private Sub dgvProductos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductos.CellClick
        If (dgvProductos.Columns(e.ColumnIndex).Name = "ProductoDetalle") Then
            Dim producto As TotalProductoItemViewModel = dgvProductos.CurrentRow.DataBoundItem
            Dim frmInformeProducto As frmInformeProducto = New frmInformeProducto(frmInformeVentasViewModel.ObtenerIdSucursales, frmInformeVentasViewModel.FechaDesde, frmInformeVentasViewModel.FechaHasta, producto.IdProducto, frmInformeVentasViewModel.CategoriaSeleccionada.Key, frmInformeVentasViewModel.SubcategoriaSeleccionada.Key)
            frmInformeProducto.ShowDialog()
        End If
    End Sub

    Private Sub dgvProductos_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductos.CellContentDoubleClick
        Dim producto As TotalProductoItemViewModel = dgvProductos.CurrentRow.DataBoundItem
        Dim frmInformeProducto As frmInformeProducto = New frmInformeProducto(frmInformeVentasViewModel.ObtenerIdSucursales, frmInformeVentasViewModel.FechaDesde, frmInformeVentasViewModel.FechaHasta, producto.IdProducto, frmInformeVentasViewModel.CategoriaSeleccionada.Key, frmInformeVentasViewModel.SubcategoriaSeleccionada.Key)
        frmInformeProducto.ShowDialog()
    End Sub

    Private Function ObtenerListBox(Of T)(lista As ListBox) As List(Of KeyValuePair(Of T, String))
        Dim resultado As List(Of KeyValuePair(Of T, String)) = New List(Of KeyValuePair(Of T, String))
        For Each item As KeyValuePair(Of T, String) In lista.SelectedItems
            resultado.Add(item)
        Next
        Return resultado
    End Function

    Private Sub CaragrListBox(Of T)(items As List(Of KeyValuePair(Of T, String)), lista As ListBox)
        If (Not items.Any()) Then
            lista.ClearSelected()
        End If

        For Each item As KeyValuePair(Of T, String) In items
            lista.SelectedItems.Add(item)
        Next
    End Sub

    Private Sub ActualizarIconoOrdenamiento()
        ActualizarIconoOrdenamiento(dgvVentas, frmInformeVentasViewModel.VentaPorDiaOrdenadoPor, frmInformeVentasViewModel.VentaPorDiaOrdenadoDireccion)
        ActualizarIconoOrdenamiento(dgvProductos, frmInformeVentasViewModel.ProductoNombreOrdenadoPor, frmInformeVentasViewModel.ProductoNombreOrdenadoDireccion)
        ActualizarIconoOrdenamiento(dgvCategorias, frmInformeVentasViewModel.ProductoCategoriaOrdenadoPor, frmInformeVentasViewModel.ProductoCategoriaOrdenadoDireccion)
        ActualizarIconoOrdenamiento(dgvSubCategorias, frmInformeVentasViewModel.ProductoSubcategOriardenadoPor, frmInformeVentasViewModel.ProductoSubcategoriarOrdenadoDireccion)
        ActualizarIconoOrdenamiento(dgvMercaderiaRecibida, frmInformeVentasViewModel.MercaderiaOriardenadoPor, frmInformeVentasViewModel.MercaderiaOrdenadoDireccion)
    End Sub

    Private Sub ActualizarIconoOrdenamiento(datagridview As DataGridView, OrdenadoPor As String, OrdenadoDireccion As OrdenadoDireccion)
        Dim dataGridViewColumn As DataGridViewColumn = datagridview.Columns.Cast(Of DataGridViewColumn).Where(Function(x) x.DataPropertyName = OrdenadoPor).FirstOrDefault()

        dataGridViewColumn.HeaderCell.SortGlyphDirection = If(OrdenadoDireccion = OrdenadoDireccion.ASC, SortOrder.Ascending, SortOrder.Descending)
    End Sub

    Private Sub Ejecutar(accion As Action)
        Try
            Me.UseWaitCursor = True
            accion()
        Catch ex As NegocioException
            MessageBox.Show(ex.Message, "Administración de Productos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error al realizar la accion. Por favor, intente mas tarde o consulte con el administrador.", "Administración de Productos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Me.UseWaitCursor = False
        End Try
    End Sub

    Private Async Sub EjecutarAsync(accion As Func(Of Task))
        Try
            Me.UseWaitCursor = True
            Await accion()
        Catch ex As NegocioException
            MessageBox.Show(ex.Message, "Administración de Productos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error al realizar la accion. Por favor, intente mas tarde o consulte con el administrador.", "Administración de Productos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Me.UseWaitCursor = False
        End Try
    End Sub
End Class