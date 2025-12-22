Imports System.Threading.Tasks
Imports Entidades
Imports SistemaCinderella.Formularios.Venta

Public Class frmPresupuestoAdministracion
    Inherits Comun

    Private PresupuestoAdministracionViewModel As frmPresupuestoAdministracionViewModel = New frmPresupuestoAdministracionViewModel(My.Settings.Sucursal)

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        AddHandler txtNumeroPresupuesto.DataBindings(0).Parse, AddressOf NullParseHandler
    End Sub

    Private Sub PresupuestoAdministracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EjecutarAsync(Async Function() As Task
                          FrmPresupuestoAdministracionViewModelBindingSource.DataSource = PresupuestoAdministracionViewModel
                          PresupuestoAdministracionViewModel.ElementosPorPagina = Paginado.ElementosPorPagina
                          Await PresupuestoAdministracionViewModel.BuscarAsync()
                      End Function)
    End Sub

    Private Sub BtnFiltrar_Click(sender As Object, e As EventArgs) Handles BtnFiltrar.Click
        EjecutarAsync(Async Function() As Task
                          Await PresupuestoAdministracionViewModel.BuscarAsync()
                      End Function)
    End Sub

    Private Sub btn_Restablecer_Click(sender As Object, e As EventArgs) Handles btn_Restablecer.Click
        EjecutarAsync(Async Function() As Task
                          PresupuestoAdministracionViewModel.Inicializar()
                          Await PresupuestoAdministracionViewModel.BuscarAsync()
                      End Function)
    End Sub

    Private Sub dgPresupuesto_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgPresupuesto.CellDoubleClick
        TabAdministracionPresupuesto.SelectedTab = TabDetalle
    End Sub

    Private Sub CargarDetallePresupuesto()
        Ejecutar(Sub()
                     Dim presupuesto As PresupuestoItemsViewModel = CType(dgPresupuesto.CurrentRow.DataBoundItem, PresupuestoItemsViewModel)
                     PresupuestoAdministracionViewModel.CargarPresupuesto(presupuesto)
                     FrmPresupuestoDetalleViewModelBindingSource.DataSource = PresupuestoAdministracionViewModel.PresupuestoDetalle
                 End Sub)
    End Sub

    Private Sub dgPresupuesto_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgPresupuesto.CellContentClick
        If dgPresupuesto.Columns(e.ColumnIndex).Name = "Imprimir" Then 'Si se hace click en el boton "eliminar" de la fila.
            Me.Cursor = Cursors.WaitCursor
            Dim presupuesto As PresupuestoItemsViewModel = CType(dgPresupuesto.CurrentRow.DataBoundItem, PresupuestoItemsViewModel)
            Dim frmReportePresupuesto As frmReportePresupuesto = New frmReportePresupuesto(presupuesto.PresupuestoModel)
            frmReportePresupuesto.ShowDialog()
            Me.Cursor = Cursors.Arrow
        End If
    End Sub


    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Dim frmReportePresupuesto As frmReportePresupuesto = New frmReportePresupuesto(PresupuestoAdministracionViewModel.PresupuestoDetalle.PresupuestoModel)
        frmReportePresupuesto.ShowDialog()
    End Sub

    Private Sub TabAdministracionPresupuesto_Selected(sender As Object, e As TabControlEventArgs) Handles TabAdministracionPresupuesto.Selected
        If TabAdministracionPresupuesto.SelectedIndex = 1 AndAlso dgPresupuesto.CurrentRow Is Nothing Then
            MessageBox.Show("Debe seleccionar previamente una presupuestos.", "Administración de Presupuestos", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            TabAdministracionPresupuesto.SelectedIndex = 0
        Else
            CargarDetallePresupuesto()
        End If
    End Sub

    Private Sub BtnAnular_Click(sender As Object, e As EventArgs) Handles BtnAnular.Click
        EjecutarAsync(Async Function() As Task
                          If MessageBox.Show("¿Está seguro que desea anular el Presupuesto?", "Administración de Presupuestos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then 'Si acepta anular la venta
                              Await PresupuestoAdministracionViewModel.AnularAsync()
                              FrmPresupuestoDetalleViewModelBindingSource.ResetBindings(False)
                              MessageBox.Show(My.Resources.GuardadoOk, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                          End If
                      End Function)
    End Sub

    Sub EvaluarPermisos()
        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Presupuesto_Administración_Visualizar)) Then

        Else
            TabAdministracionPresupuesto.TabPages.Remove(TabDetalle)
            RemoveHandler dgPresupuesto.CellDoubleClick, AddressOf dgPresupuesto_CellDoubleClick
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Presupuesto_Administración_Detalle_Anular)) Then
            BtnAnular.Visible = True
        Else
            BtnAnular.Visible = False
        End If
    End Sub

    Private Sub Paginado_PaginaAnteriorClick(sender As Object, e As EventArgs) Handles Paginado.PaginaAnteriorClick
        EjecutarAsync(Async Function() As Task
                          PresupuestoAdministracionViewModel.PaginaActual += -1
                          Await PresupuestoAdministracionViewModel.BuscarAsync()
                      End Function)
    End Sub

    Private Sub Paginado_PaginaFinalClick(sender As Object, e As EventArgs) Handles Paginado.PaginaFinalClick
        EjecutarAsync(Async Function() As Task
                          PresupuestoAdministracionViewModel.PaginaActual = Paginado.TotalPaginas
                          Await PresupuestoAdministracionViewModel.BuscarAsync()
                      End Function)
    End Sub

    Private Sub Paginado_PaginaInicalClick(sender As Object, e As EventArgs) Handles Paginado.PaginaInicalClick
        EjecutarAsync(Async Function() As Task
                          PresupuestoAdministracionViewModel.PaginaActual = 1
                          Await PresupuestoAdministracionViewModel.BuscarAsync()
                      End Function)
    End Sub

    Private Sub Paginado_PaginaSiguienteClick(sender As Object, e As EventArgs) Handles Paginado.PaginaSiguienteClick
        EjecutarAsync(Async Function() As Task
                          PresupuestoAdministracionViewModel.PaginaActual += 1
                          Await PresupuestoAdministracionViewModel.BuscarAsync()
                      End Function)
    End Sub

    Private Sub NullParseHandler(ByVal sender As Object, ByVal e As ConvertEventArgs)
        If e.Value IsNot Nothing AndAlso String.IsNullOrEmpty(e.Value.ToString()) Then e.Value = Nothing
    End Sub
End Class