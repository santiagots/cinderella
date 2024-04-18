Imports System.Threading.Tasks
Imports Negocio
Imports SistemaCinderella.Formularios.Comex

Public Class frmComexOrdenCompraAdministracion
    Inherits Comun

    Private Errores As NegManejadorErrores = New NegManejadorErrores()
    Private frmComexOrdenCompraAdministracionViewModel As frmComexOrdenCompraAdministracionViewModel

    Private Sub frmComexOrdenCompraAdministracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EjecutarAsync(Async Function() As Task
                          frmComexOrdenCompraAdministracionViewModel = New frmComexOrdenCompraAdministracionViewModel()
                          frmComexOrdenCompraAdministracionViewModel.ElementosPorPagina = Paginado.ElementosPorPagina
                          FrmComexOrdenCompraAdministracionViewModelBindingSource.DataSource = frmComexOrdenCompraAdministracionViewModel

                          Await frmComexOrdenCompraAdministracionViewModel.CargarDatosAsync()
                          Await frmComexOrdenCompraAdministracionViewModel.BuscarAsync()
                      End Function)
    End Sub

    Private Sub BtnFiltrar_Click(sender As Object, e As EventArgs) Handles BtnFiltrar.Click
        EjecutarAsync(Async Function() As Task
                          Await frmComexOrdenCompraAdministracionViewModel.BuscarAsync()
                      End Function)
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Ejecutar(Async Sub()
                     frmComexOrdenCompraAdministracionViewModel.NuevaOrdenCompra()
                 End Sub)
    End Sub

    Private Sub Paginado_PaginaAnteriorClick(sender As Object, e As EventArgs) Handles Paginado.PaginaAnteriorClick
        EjecutarAsync(Async Function() As Task
                          frmComexOrdenCompraAdministracionViewModel.PaginaActual += -1
                          Await frmComexOrdenCompraAdministracionViewModel.BuscarAsync()
                      End Function)
    End Sub

    Private Sub Paginado_PaginaFinalClick(sender As Object, e As EventArgs) Handles Paginado.PaginaFinalClick
        EjecutarAsync(Async Function() As Task
                          frmComexOrdenCompraAdministracionViewModel.PaginaActual = Paginado.TotalPaginas
                          Await frmComexOrdenCompraAdministracionViewModel.BuscarAsync()
                      End Function)
    End Sub

    Private Sub Paginado_PaginaInicalClick(sender As Object, e As EventArgs) Handles Paginado.PaginaInicalClick
        EjecutarAsync(Async Function() As Task
                          frmComexOrdenCompraAdministracionViewModel.PaginaActual = 1
                          Await frmComexOrdenCompraAdministracionViewModel.BuscarAsync()
                      End Function)
    End Sub

    Private Sub Paginado_PaginaSiguienteClick(sender As Object, e As EventArgs) Handles Paginado.PaginaSiguienteClick
        EjecutarAsync(Async Function() As Task
                          frmComexOrdenCompraAdministracionViewModel.PaginaActual += 1
                          Await frmComexOrdenCompraAdministracionViewModel.BuscarAsync()
                      End Function)
    End Sub

    Private Sub DG_OrdenCompra_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_OrdenCompra.CellDoubleClick
        Ejecutar(Sub()
                     Dim ComexOrdenCompraAdministracionItemViewModel As ComexOrdenCompraAdministracionItemViewModel = DG_OrdenCompra.CurrentRow.DataBoundItem
                     frmComexOrdenCompraAdministracionViewModel.CargarOrdenCompra(ComexOrdenCompraAdministracionItemViewModel.OrdenCompra)
                 End Sub)
    End Sub

    Private Sub txt_numero_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txt_numero.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            BtnFiltrar.Focus()
        End If

        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(Errores.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
End Class