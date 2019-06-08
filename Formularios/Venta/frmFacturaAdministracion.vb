Imports System.Threading.Tasks
Imports Common.Core.Exceptions
Imports Common.Core.Helper
Imports Entidades
Imports Negocio
Imports SistemaCinderella.Formularios.Venta

Public Class frmFacturaAdministracion

    Private frmFacturaAdministracionViewModel As frmFacturaAdministracionViewModel

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        AddHandler txtFacturaNro.DataBindings(0).Parse, AddressOf NullParseHandler
        AddHandler txtCUIT.DataBindings(0).Parse, AddressOf NullParseHandler
        AddHandler txtMontoHasta.DataBindings(0).Parse, AddressOf NullParseHandler
        AddHandler txtMontoDesde.DataBindings(0).Parse, AddressOf NullParseHandler
        AddHandler txtMontoHasta.DataBindings(0).Parse, AddressOf NullParseHandler
    End Sub

    Private Sub FrmFacturaAdministracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EjecutarAsync(Async Function() As Task
                          frmFacturaAdministracionViewModel = New frmFacturaAdministracionViewModel(My.Settings.Sucursal, Me.MdiParent)
                          FrmFacturaAdministracionViewModelBindingSource.DataSource = frmFacturaAdministracionViewModel
                          Await frmFacturaAdministracionViewModel.BuscarAsync()
                      End Function)
        Me.DataBindings.Add(New Binding("Visible", Me.FrmFacturaAdministracionViewModelBindingSource, "Visible", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    End Sub

    Private Sub TabAdministracionFacturas_Selected(sender As Object, e As TabControlEventArgs) Handles TabAdministracionFacturas.Selected
        EjecutarAsync(Async Function() As Task
                          If (TabAdministracionFacturas.SelectedTab.Name = TabDetalle.Name) Then
                              If (DG_facturas.CurrentRow Is Nothing) Then
                                  MessageBox.Show("No se encuentra una venta seleccionada. Para ver el detalle de una venta debe seleccionar una.", "Administración de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                  TabAdministracionFacturas.SelectedTab = TabFacturas
                                  Return
                              End If
                              Await frmFacturaAdministracionViewModel.CargarVentaAsync(DG_facturas.CurrentRow.DataBoundItem)
                              VentaDetalle.VentaDetalleBindingSource.DataSource = frmFacturaAdministracionViewModel.VentaDetalleSeleccionada
                          End If
                      End Function)
    End Sub

    Private Sub BtnFiltrar_Click(sender As Object, e As EventArgs) Handles BtnFiltrar.Click
        EjecutarAsync(Async Function() As Task
                          Await frmFacturaAdministracionViewModel.BuscarAsync()
                      End Function)
    End Sub

    Private Sub btn_Restablecer_Click(sender As Object, e As EventArgs) Handles btn_Restablecer.Click
        EjecutarAsync(Async Function() As Task
                          Await frmFacturaAdministracionViewModel.RestablecerAsync()
                      End Function)
    End Sub

    Private Sub BtnAnular_Click(sender As Object, e As EventArgs) Handles BtnAnular.Click
        EjecutarAsync(Async Function() As Task
                          Dim respuesta As DialogResult = MessageBox.Show("¿Está seguro que desea anular la venta?", "Administración de Ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                          If respuesta = DialogResult.Yes Then
                              Await frmFacturaAdministracionViewModel.AnularAsync()
                          End If
                      End Function)
    End Sub

    Private Sub BtnEmitirFactura_Click(sender As Object, e As EventArgs) Handles BtnEmitirFactura.Click
        Ejecutar(Sub() frmFacturaAdministracionViewModel.Faturar())
    End Sub

    Private Sub BtnFacturaDetalle_Click(sender As Object, e As EventArgs) Handles BtnFacturaDetalle.Click
        Ejecutar(Sub() frmFacturaAdministracionViewModel.MostrarFacturaDetalle())
    End Sub

    Private Sub BtnNotaCreditoDetalle_Click(sender As Object, e As EventArgs) Handles BtnNotaCreditoDetalle.Click
        Ejecutar(Sub() frmFacturaAdministracionViewModel.MostrarNotaCreditoDetalle())
    End Sub

    Private Sub DG_facturas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_facturas.CellDoubleClick
        Ejecutar(Sub() TabAdministracionFacturas.SelectedTab = TabDetalle)
    End Sub

    Private Sub btnReporteVenta_Click(sender As Object, e As EventArgs) Handles btnReporteVenta.Click
        Ejecutar(Sub() frmFacturaAdministracionViewModel.Imprimir())
    End Sub

    Private Sub NullParseHandler(ByVal sender As Object, ByVal e As ConvertEventArgs)
        If e.Value IsNot Nothing AndAlso String.IsNullOrEmpty(e.Value.ToString()) Then e.Value = Nothing
    End Sub

    Private Sub Ejecutar(accion As Action)
        Try
            accion()
        Catch ex As NegocioException
            Log.Error(ex)
            MessageBox.Show(ex.Message, "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            Log.Error(ex)
            MessageBox.Show("Error al realizar la accion. Por favor, intente mas tarde o consulte con el administrador.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Async Sub EjecutarAsync(accion As Func(Of Task))
        Try
            Await accion()
        Catch ex As NegocioException
            Log.Error(ex)
            MessageBox.Show(ex.Message, "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            Log.Error(ex)
            MessageBox.Show("Error al realizar la accion. Por favor, intente mas tarde o consulte con el administrador.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class