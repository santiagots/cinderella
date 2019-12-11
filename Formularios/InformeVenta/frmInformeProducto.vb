Imports System.Threading.Tasks
Imports Common.Core.Enum
Imports Common.Core.Exceptions
Imports Common.Core.Model
Imports Negocio
Imports SistemaCinderella.Formularios.InformeVenta

Public Class frmInformeProducto

    Dim frmInformeProductoViewModel As frmInformeProductoViewModel

    Sub New(idSucursales As IEnumerable(Of Integer), fechaDesde As DateTime, fechaHasta As DateTime, IdProducto As Integer?, Categoria As Categoria, Subcategoria As SubCategoria)

        ' This call is required by the designer.
        InitializeComponent()

        frmInformeProductoViewModel = New frmInformeProductoViewModel(idSucursales, fechaDesde, fechaHasta, IdProducto, Categoria, Subcategoria)

    End Sub


    Private Sub frmInformeDetalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EjecutarAsync(Async Function() As Task
                          FrmInformeProductoViewModelBindingSource.DataSource = frmInformeProductoViewModel
                          Await frmInformeProductoViewModel.CargarProductoPorNombreAsync()
                          chtVentasProducto.DataSource = frmInformeProductoViewModel.ObtenerDTProductoPorNombre()
                          chtVentasProducto.DataBind()
                          ActualizarIconoOrdenamiento()
                      End Function)
    End Sub

    Private Sub dgvProductos_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvProductos.ColumnHeaderMouseClick
        EjecutarAsync(Async Function() As Task
                          If (dgvProductos.Columns(e.ColumnIndex).SortMode <> DataGridViewColumnSortMode.NotSortable) Then
                              frmInformeProductoViewModel.ProductoNombreOrdenadoPor = dgvProductos.Columns(e.ColumnIndex).DataPropertyName
                              frmInformeProductoViewModel.ProductoNombreOrdenadoDireccion = If(frmInformeProductoViewModel.ProductoNombreOrdenadoDireccion = OrdenadoDireccion.ASC, OrdenadoDireccion.DESC, OrdenadoDireccion.ASC)
                              Await frmInformeProductoViewModel.CargarProductoPorNombreAsync()
                              chtVentasProducto.DataSource = frmInformeProductoViewModel.ObtenerDTProductoPorNombre()
                              chtVentasProducto.DataBind()
                              ActualizarIconoOrdenamiento()
                          End If
                      End Function)
    End Sub

    Private Sub BindingNavigatorMoveNextItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveNextItem.Click
        EjecutarAsync(Async Function() As Task
                          frmInformeProductoViewModel.PaginasActualProductos += 1
                          Await frmInformeProductoViewModel.CargarProductoPorNombreAsync()
                          chtVentasProducto.DataSource = frmInformeProductoViewModel.ObtenerDTProductoPorNombre()
                          chtVentasProducto.DataBind()
                          ActualizarIconoOrdenamiento()
                      End Function)
    End Sub

    Private Sub BindingNavigatorMoveLastItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveLastItem.Click
        EjecutarAsync(Async Function() As Task
                          frmInformeProductoViewModel.PaginasActualProductos = frmInformeProductoViewModel.PaginasProductos.Count - 1
                          Await frmInformeProductoViewModel.CargarProductoPorNombreAsync()
                          chtVentasProducto.DataSource = frmInformeProductoViewModel.ObtenerDTProductoPorNombre()
                          chtVentasProducto.DataBind()
                          ActualizarIconoOrdenamiento()
                      End Function)
    End Sub

    Private Sub BindingNavigatorMovePreviousItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMovePreviousItem.Click
        EjecutarAsync(Async Function() As Task
                          frmInformeProductoViewModel.PaginasActualProductos -= 1
                          Await frmInformeProductoViewModel.CargarProductoPorNombreAsync()
                          chtVentasProducto.DataSource = frmInformeProductoViewModel.ObtenerDTProductoPorNombre()
                          chtVentasProducto.DataBind()
                          ActualizarIconoOrdenamiento()
                      End Function)
    End Sub

    Private Sub BindingNavigatorMoveFirstItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveFirstItem.Click
        EjecutarAsync(Async Function() As Task
                          frmInformeProductoViewModel.PaginasActualProductos = 0
                          Await frmInformeProductoViewModel.CargarProductoPorNombreAsync()
                          chtVentasProducto.DataSource = frmInformeProductoViewModel.ObtenerDTProductoPorNombre()
                          chtVentasProducto.DataBind()
                          ActualizarIconoOrdenamiento()
                      End Function)
    End Sub

    Private Sub ActualizarIconoOrdenamiento()
        ActualizarIconoOrdenamiento(dgvProductos, frmInformeProductoViewModel.ProductoNombreOrdenadoPor, frmInformeProductoViewModel.ProductoNombreOrdenadoDireccion)
    End Sub

    Private Sub ActualizarIconoOrdenamiento(datagridview As DataGridView, OrdenadoPor As String, OrdenadoDireccion As OrdenadoDireccion)
        Dim dataGridViewColumn As DataGridViewColumn = datagridview.Columns.Cast(Of DataGridViewColumn).Where(Function(x) x.DataPropertyName = OrdenadoPor).FirstOrDefault()

        dataGridViewColumn.HeaderCell.SortGlyphDirection = If(OrdenadoDireccion = OrdenadoDireccion.ASC, SortOrder.Ascending, SortOrder.Descending)
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