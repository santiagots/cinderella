Imports System.Threading.Tasks
Imports Common.Core.Enum
Imports SistemaCinderella.Formularios.Cliente

Public Class frmTransporte
    Inherits Comun

    Private frmTrasporteViewModel As frmTrasporteViewModel = New frmTrasporteViewModel()

    Private Sub frmTransporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EjecutarAsync(Async Function() As Task
                          frmTrasporteViewModel.ElementosPorPagina = Paginado.ElementosPorPagina

                          FrmTrasporteViewModelBindingSource.DataSource = frmTrasporteViewModel
                          NuevoTransporteViewModelBindingSource.DataSource = frmTrasporteViewModel.TransportesAlta
                          ModificarTransporteViewModelBindingSource.DataSource = frmTrasporteViewModel.TransportesModificacion

                          Await frmTrasporteViewModel.CargarDatosAsync()

                          NuevoTransporteViewModelBindingSource.ResetBindings(False)
                          ModificarTransporteViewModelBindingSource.ResetBindings(False)
                      End Function)
    End Sub

    Private Sub Cb_Alt_Provincia_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Cb_Alt_Provincia.SelectionChangeCommitted
        EjecutarAsync(Async Function() As Task
                          If Cb_Alt_Provincia.SelectedItem Is Nothing Then
                              Return
                          End If

                          frmTrasporteViewModel.TransportesAlta.ProvinciasSaleccionada = Cb_Alt_Provincia.SelectedItem.Key
                          Await frmTrasporteViewModel.CargarDistritoAsync(frmTrasporteViewModel.TransportesAlta, frmTrasporteViewModel.TransportesAlta.ProvinciasSaleccionada, True)
                          Await frmTrasporteViewModel.CargarLocalidadAsync(frmTrasporteViewModel.TransportesAlta, frmTrasporteViewModel.TransportesAlta.DistritosSaleccionada, True)

                          NuevoTransporteViewModelBindingSource.ResetBindings(False)
                      End Function)
    End Sub

    Private Sub Cb_Alt_Distrito_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Cb_Alt_Distrito.SelectionChangeCommitted
        EjecutarAsync(Async Function() As Task
                          If Cb_Alt_Distrito.SelectedItem Is Nothing Then
                              Return
                          End If

                          frmTrasporteViewModel.TransportesAlta.DistritosSaleccionada = Cb_Alt_Distrito.SelectedItem.Key
                          Await frmTrasporteViewModel.CargarLocalidadAsync(frmTrasporteViewModel.TransportesAlta, frmTrasporteViewModel.TransportesAlta.DistritosSaleccionada, True)

                          NuevoTransporteViewModelBindingSource.ResetBindings(False)
                      End Function)
    End Sub

    Private Sub Cb_Mod_Provincia_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Cb_Mod_Provincia.SelectionChangeCommitted
        EjecutarAsync(Async Function() As Task
                          If Cb_Alt_Provincia.SelectedItem Is Nothing Then
                              Return
                          End If

                          frmTrasporteViewModel.TransportesModificacion.ProvinciasSaleccionada = Cb_Mod_Provincia.SelectedItem.Key
                          Await frmTrasporteViewModel.CargarDistritoAsync(frmTrasporteViewModel.TransportesModificacion, frmTrasporteViewModel.TransportesModificacion.ProvinciasSaleccionada, True)
                          Await frmTrasporteViewModel.CargarLocalidadAsync(frmTrasporteViewModel.TransportesModificacion, frmTrasporteViewModel.TransportesModificacion.DistritosSaleccionada, True)

                          ModificarTransporteViewModelBindingSource.ResetBindings(False)
                      End Function)
    End Sub

    Private Sub Cb_Mod_Distrito_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Cb_Mod_Distrito.SelectionChangeCommitted
        EjecutarAsync(Async Function() As Task
                          If Cb_Alt_Distrito.SelectedItem Is Nothing Then
                              Return
                          End If

                          frmTrasporteViewModel.TransportesModificacion.DistritosSaleccionada = Cb_Mod_Distrito.SelectedItem.Key
                          Await frmTrasporteViewModel.CargarLocalidadAsync(frmTrasporteViewModel.TransportesModificacion, frmTrasporteViewModel.TransportesModificacion.DistritosSaleccionada, True)

                          ModificarTransporteViewModelBindingSource.ResetBindings(False)
                      End Function)
    End Sub

    Private Sub Paginado_PaginaAnteriorClick(sender As Object, e As EventArgs) Handles Paginado.PaginaAnteriorClick
        EjecutarAsync(Async Function() As Task
                          frmTrasporteViewModel.PaginaActual += -1
                          Await frmTrasporteViewModel.BuscarAsync()
                      End Function)
    End Sub

    Private Sub Paginado_PaginaFinalClick(sender As Object, e As EventArgs) Handles Paginado.PaginaFinalClick
        EjecutarAsync(Async Function() As Task
                          frmTrasporteViewModel.PaginaActual = Paginado.TotalPaginas
                          Await frmTrasporteViewModel.BuscarAsync()
                      End Function)
    End Sub

    Private Sub Paginado_PaginaInicalClick(sender As Object, e As EventArgs) Handles Paginado.PaginaInicalClick
        EjecutarAsync(Async Function() As Task
                          frmTrasporteViewModel.PaginaActual = 1
                          Await frmTrasporteViewModel.BuscarAsync()
                      End Function)
    End Sub

    Private Sub Paginado_PaginaSiguienteClick(sender As Object, e As EventArgs) Handles Paginado.PaginaSiguienteClick
        EjecutarAsync(Async Function() As Task
                          frmTrasporteViewModel.PaginaActual += 1
                          Await frmTrasporteViewModel.BuscarAsync()
                      End Function)
    End Sub

    Private Sub DG_Transporte_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DG_Transporte.ColumnHeaderMouseClick
        EjecutarAsync(Async Function() As Task
                          If (DG_Transporte.Columns(e.ColumnIndex).SortMode <> DataGridViewColumnSortMode.NotSortable) Then
                              frmTrasporteViewModel.OrdenadoPor = DG_Transporte.Columns(e.ColumnIndex).DataPropertyName
                              frmTrasporteViewModel.DireccionOrdenamiento = If(frmTrasporteViewModel.DireccionOrdenamiento = OrdenadoDireccion.ASC, OrdenadoDireccion.DESC, OrdenadoDireccion.ASC)

                              Await frmTrasporteViewModel.BuscarAsync()

                              DG_Transporte.Columns(e.ColumnIndex).HeaderCell.SortGlyphDirection = If(frmTrasporteViewModel.DireccionOrdenamiento = OrdenadoDireccion.ASC, SortOrder.Ascending, SortOrder.Descending)
                          End If
                      End Function)
    End Sub

    Private Sub DG_Productos_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Transporte.CellDoubleClick
        TabTransporte.SelectedTab = TbMod
    End Sub

    Private Sub TabProductos_Selected(ByVal sender As Object, ByVal e As System.Windows.Forms.TabControlEventArgs) Handles TabTransporte.Selected
        If TabTransporte.SelectedTab Is TbMod AndAlso DG_Transporte.CurrentRow IsNot Nothing Then
            EjecutarAsync(Async Function() As Task
                              Dim transporteViewModel As TransporteViewModel = CType(DG_Transporte.CurrentRow.DataBoundItem, TransporteViewModel)
                              Await frmTrasporteViewModel.ModificarAsync(transporteViewModel)

                              ModificarTransporteViewModelBindingSource.DataSource = frmTrasporteViewModel.TransportesModificacion
                          End Function)
        End If
    End Sub

    Private Sub Btn_Agregar_Click(sender As Object, e As EventArgs) Handles Btn_Agregar.Click
        EjecutarAsync(Async Function() As Task
                          Await frmTrasporteViewModel.AgregarAsync()
                          MessageBox.Show(My.Resources.GuardadoOk, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                          TabTransporte.SelectedTab = TbListado
                          Await frmTrasporteViewModel.BuscarAsync()
                      End Function)
    End Sub

    Private Sub Btn_Modificar_Click(sender As Object, e As EventArgs) Handles Btn_Modificar.Click
        EjecutarAsync(Async Function() As Task
                          Await frmTrasporteViewModel.ModificarAsync()
                          MessageBox.Show(My.Resources.GuardadoOk, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                          TabTransporte.SelectedTab = TbListado
                          Await frmTrasporteViewModel.BuscarAsync()
                      End Function)
    End Sub

    Private Sub Btn_Buscar_Click(sender As Object, e As EventArgs) Handles Btn_Buscar.Click
        EjecutarAsync(Async Function() As Task
                          Await frmTrasporteViewModel.BuscarAsync()
                      End Function)
    End Sub
End Class