Imports System.Threading.Tasks
Imports Common.Core.Enum
Imports SistemaCinderella.Formularios.Venta

Public Class frmNotaPedidoAdministracion
    Inherits Comun

    Public notaPedidoViewModel As frmNotaPedidoAdministracionViewModel

    Private Sub frmNotaPedidoAdministracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EjecutarAsync(Async Function() As Task
                          notaPedidoViewModel = New frmNotaPedidoAdministracionViewModel(My.Settings.Sucursal)

                          NotaPedidoBindingSource.DataSource = notaPedidoViewModel
                          notaPedidoViewModel.NotasPedidosElementosPorPagina = Paginado.ElementosPorPagina
                          Await notaPedidoViewModel.CargarDatosAsync()
                      End Function)
        Me.DataBindings.Add(New Binding("Visible", Me.NotaPedidoBindingSource, "Visible", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    End Sub

    Private Sub BtnFiltrar_Click(sender As Object, e As EventArgs) Handles BtnFiltrar.Click
        EjecutarAsync(Async Function() As Task
                          Await notaPedidoViewModel.Buscar()
                      End Function)
    End Sub

    Private Sub btn_Restablecer_Click(sender As Object, e As EventArgs) Handles btn_Restablecer.Click
        EjecutarAsync(Async Function() As Task
                          Await notaPedidoViewModel.RestablecerAsync()
                      End Function)
    End Sub


    Private Sub dgNotasPedidos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgNotasPedidos.CellContentClick
        EjecutarAsync(
            Async Function() As Task
                If dgNotasPedidos.Columns(e.ColumnIndex).Name = "Eliminar" Then
                    If (DialogResult.Yes = MessageBox.Show("¿Está seguro que desea eliminar la Nota de Pedido?", "Administración Nota Pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) Then
                        Await notaPedidoViewModel.EliminarNotaPedidoAsync(dgNotasPedidos.CurrentRow.DataBoundItem)
                        MessageBox.Show("Se ha eliminado la nota de pedido correctamente", "Administración Nota Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
                If dgNotasPedidos.Columns(e.ColumnIndex).Name = "Imprimir" Then
                    notaPedidoViewModel.ImprimirNotaPedido(dgNotasPedidos.CurrentRow.DataBoundItem, Me.MdiParent)
                End If
            End Function)
    End Sub

    Private Sub dgNotasPedidos_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgNotasPedidos.CellContentDoubleClick
        Ejecutar(Sub() notaPedidoViewModel.CargarVenta(dgNotasPedidos.CurrentRow.DataBoundItem, Me.MdiParent))
    End Sub

    Private Sub Paginado_PaginaAnteriorClick(sender As Object, e As EventArgs) Handles Paginado.PaginaAnteriorClick
        EjecutarAsync(Async Function() As Task
                          notaPedidoViewModel.NotasPedidosPaginaActual += -1
                          Await notaPedidoViewModel.Buscar()
                      End Function)
    End Sub

    Private Sub Paginado_PaginaFinalClick(sender As Object, e As EventArgs) Handles Paginado.PaginaFinalClick
        EjecutarAsync(Async Function() As Task
                          notaPedidoViewModel.NotasPedidosPaginaActual = Paginado.TotalPaginas
                          Await notaPedidoViewModel.Buscar()
                      End Function)
    End Sub

    Private Sub Paginado_PaginaInicalClick(sender As Object, e As EventArgs) Handles Paginado.PaginaInicalClick
        EjecutarAsync(Async Function() As Task
                          notaPedidoViewModel.NotasPedidosPaginaActual = 1
                          Await notaPedidoViewModel.Buscar()
                      End Function)
    End Sub

    Private Sub Paginado_PaginaSiguienteClick(sender As Object, e As EventArgs) Handles Paginado.PaginaSiguienteClick
        EjecutarAsync(Async Function() As Task
                          notaPedidoViewModel.NotasPedidosPaginaActual += 1
                          Await notaPedidoViewModel.Buscar()
                      End Function)
    End Sub

    Private Sub dgNotasPedidos_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgNotasPedidos.ColumnHeaderMouseClick
        EjecutarAsync(Async Function() As Task
                          If (dgNotasPedidos.Columns(e.ColumnIndex).SortMode <> DataGridViewColumnSortMode.NotSortable) Then

                              Select Case dgNotasPedidos.Columns(e.ColumnIndex).HeaderText
                                  Case "Numero"
                                      notaPedidoViewModel.NotasPedidosOrdenadoPor = "Numero"
                                  Case "Tipo Cliente"
                                      notaPedidoViewModel.NotasPedidosOrdenadoPor = "TipoCliente"
                                  Case "Vendedor"
                                      notaPedidoViewModel.NotasPedidosOrdenadoPor = "Vendedor.Apellido"
                                  Case "Fecha"
                                      notaPedidoViewModel.NotasPedidosOrdenadoPor = "Fecha"
                                  Case "Estado"
                                      notaPedidoViewModel.NotasPedidosOrdenadoPor = "Estado"
                              End Select

                              notaPedidoViewModel.NotasPedidosDireccionOrdenamiento = If(notaPedidoViewModel.NotasPedidosDireccionOrdenamiento = OrdenadoDireccion.ASC, OrdenadoDireccion.DESC, OrdenadoDireccion.ASC)
                              Await notaPedidoViewModel.Buscar()

                              dgNotasPedidos.Columns(e.ColumnIndex).HeaderCell.SortGlyphDirection = If(notaPedidoViewModel.NotasPedidosDireccionOrdenamiento = OrdenadoDireccion.ASC, SortOrder.Ascending, SortOrder.Descending)
                          End If
                      End Function)
    End Sub
End Class