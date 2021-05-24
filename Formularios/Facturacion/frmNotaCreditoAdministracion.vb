Imports System.Threading.Tasks
Imports Common.Core.Exceptions
Imports Common.Core.Helper
Imports SistemaCinderella.Formularios.Facturacion

Public Class frmNotaCreditoAdministracion

    Private frmNotaCreditoAdministracionViewModel As frmNotaCreditoAdministracionViewModel

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        AddHandler txtNotaCreditoNro.DataBindings(0).Parse, AddressOf NullParseHandler
        AddHandler txtCUIT.DataBindings(0).Parse, AddressOf NullParseHandler
        AddHandler txtMontoHasta.DataBindings(0).Parse, AddressOf NullParseHandler
        AddHandler txtMontoDesde.DataBindings(0).Parse, AddressOf NullParseHandler
        AddHandler txtMontoHasta.DataBindings(0).Parse, AddressOf NullParseHandler
    End Sub

    Private Sub frmNotaCreditoAdministracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EjecutarAsync(Async Function() As Task
                          frmNotaCreditoAdministracionViewModel = New frmNotaCreditoAdministracionViewModel(My.Settings.Sucursal, Me.MdiParent)
                          FrmNotaCreditoAdministracionViewModelBindingSource.DataSource = frmNotaCreditoAdministracionViewModel
                          Await frmNotaCreditoAdministracionViewModel.BuscarAsync()
                      End Function)
    End Sub

    Private Sub DG_NotaCredito_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_NotaCredito.CellContentClick
        EjecutarAsync(Async Function() As Task
                          If DG_NotaCredito.Columns(e.ColumnIndex).Name = "Factura" Then
                              Await frmNotaCreditoAdministracionViewModel.MostrarFacturaDetalle(DG_NotaCredito.CurrentRow.DataBoundItem)
                          End If
                      End Function)
    End Sub

    Private Sub btn_Restablecer_Click(sender As Object, e As EventArgs) Handles btn_Restablecer.Click
        EjecutarAsync(Async Function() As Task
                          Await frmNotaCreditoAdministracionViewModel.BuscarAsync()
                      End Function)
    End Sub

    Private Sub BtnFiltrar_Click(sender As Object, e As EventArgs) Handles BtnFiltrar.Click
        EjecutarAsync(Async Function() As Task
                          Await frmNotaCreditoAdministracionViewModel.BuscarAsync()
                      End Function)
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