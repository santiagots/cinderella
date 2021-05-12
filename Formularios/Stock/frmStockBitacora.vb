Imports System.Threading.Tasks
Imports Common.Core.Enum
Imports SistemaCinderella.Formularios.Stock

Public Class frmStockBitacora
    Dim frmStockBitacoraViewModel As frmStockBitacoraViewModel
    Dim NegStockBitacora As New Negocio.NegStockBitacora
    Dim NegSucursal As New Negocio.NegSucursales
    Dim id_Sucursal As Integer

    'Load del formulario.
    Private Sub frmStockBitacora_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EjecutarAsync(Async Function() As Task
                          frmStockBitacoraViewModel = New frmStockBitacoraViewModel(My.Settings.Sucursal)
                          frmStockBitacoraViewModel.ElementosPorPagina = Paginado.ElementosPorPagina

                          FrmStockBitacoraViewModelBindingSource.DataSource = frmStockBitacoraViewModel
                          Await frmStockBitacoraViewModel.BuscarAsync()
                      End Function)
    End Sub

    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
        EjecutarAsync(Async Function() As Task
                          Await frmStockBitacoraViewModel.BuscarAsync()
                      End Function)
    End Sub

    Private Sub Paginado_PaginaAnteriorClick(sender As Object, e As EventArgs) Handles Paginado.PaginaAnteriorClick
        EjecutarAsync(Async Function() As Task
                          frmStockBitacoraViewModel.PaginaActual += -1
                          Await frmStockBitacoraViewModel.BuscarAsync()
                      End Function)
    End Sub

    Private Sub Paginado_PaginaFinalClick(sender As Object, e As EventArgs) Handles Paginado.PaginaFinalClick
        EjecutarAsync(Async Function() As Task
                          frmStockBitacoraViewModel.PaginaActual = Paginado.TotalPaginas
                          Await frmStockBitacoraViewModel.BuscarAsync()
                      End Function)
    End Sub

    Private Sub Paginado_PaginaInicalClick(sender As Object, e As EventArgs) Handles Paginado.PaginaInicalClick
        EjecutarAsync(Async Function() As Task
                          frmStockBitacoraViewModel.PaginaActual = 1
                          Await frmStockBitacoraViewModel.BuscarAsync()
                      End Function)
    End Sub

    Private Sub Paginado_PaginaSiguienteClick(sender As Object, e As EventArgs) Handles Paginado.PaginaSiguienteClick
        EjecutarAsync(Async Function() As Task
                          frmStockBitacoraViewModel.PaginaActual += 1
                          Await frmStockBitacoraViewModel.BuscarAsync()
                      End Function)
    End Sub

    Private Sub DG_Stock_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DG_Stock.ColumnHeaderMouseClick
        EjecutarAsync(Async Function() As Task
                          If (DG_Stock.Columns(e.ColumnIndex).SortMode <> DataGridViewColumnSortMode.NotSortable) Then

                              Select Case DG_Stock.Columns(e.ColumnIndex).DataPropertyName
                                  Case "ProductoCodigo"
                                      frmStockBitacoraViewModel.OrdenadoPor = "Producto.Codigo"
                                  Case "ProductoNombre"
                                      frmStockBitacoraViewModel.OrdenadoPor = "Producto.Nombre"
                                  Case "usuario"
                                      frmStockBitacoraViewModel.OrdenadoPor = "Usuario.UsuarioNombre"
                                  Case Else
                                      frmStockBitacoraViewModel.OrdenadoPor = DG_Stock.Columns(e.ColumnIndex).DataPropertyName
                              End Select

                              frmStockBitacoraViewModel.DireccionOrdenamiento = If(frmStockBitacoraViewModel.DireccionOrdenamiento = OrdenadoDireccion.ASC, OrdenadoDireccion.DESC, OrdenadoDireccion.ASC)
                              Await frmStockBitacoraViewModel.BuscarAsync()

                              DG_Stock.Columns(e.ColumnIndex).HeaderCell.SortGlyphDirection = If(frmStockBitacoraViewModel.DireccionOrdenamiento = OrdenadoDireccion.ASC, SortOrder.Ascending, SortOrder.Descending)
                          End If
                      End Function)
    End Sub
End Class