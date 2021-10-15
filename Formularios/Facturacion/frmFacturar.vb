Imports System.Threading.Tasks
Imports Common.Core.Enum
Imports Common.Core.Exceptions
Imports Common.Core.Helper
Imports SistemaCinderella.Formularios.Facturacion

Public Class frmFacturar

    Private facturarViewModel As frmFacturarViewModel

    Public Sub New(facturarViewModel As frmFacturarViewModel)
        ' This call is required by the designer.
        InitializeComponent()

        Me.facturarViewModel = facturarViewModel
    End Sub

    Private Sub frmFacturarNueva_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EjecutarAsync(Async Function() As Task
                          FacturarBindingSource.DataSource = facturarViewModel
                          Await facturarViewModel.CargarDatosAsync()
                      End Function)
        Me.DataBindings.Add(New Binding("Visible", Me.FacturarBindingSource, "Visible", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Ejecutar(
            Sub()
                facturarViewModel.Cancelar()
                Dispose()
            End Sub)
    End Sub

    Private Sub btnFacturar_Click(sender As Object, e As EventArgs) Handles btnFacturar.Click
        EjecutarAsync(Async Function() As Task
                          If (Await facturarViewModel.FacturarAsync()) Then

                              If facturarViewModel.TiposFacturaSeleccionada = TipoFactura.Electronica Then
                                  Dim frmReporteResumenReserva As frmReporteFactura = New frmReporteFactura(facturarViewModel.ventaModel.Id, facturarViewModel.ventaModel.TipoCliente, TipoDocumentoFiscal.Factura)
                                  frmReporteResumenReserva.MdiParent = MdiParent
                                  frmReporteResumenReserva.Show()
                              End If

                              Dispose()
                          End If
                      End Function)
    End Sub

    Private Sub btnNotaCredito_Click(sender As Object, e As EventArgs) Handles btnNotaCredito.Click
        EjecutarAsync(Async Function() As Task
                          If (Await facturarViewModel.NotaCreditoAsync()) Then

                              If facturarViewModel.TiposFacturaSeleccionada = TipoFactura.Electronica Then
                                  Dim frmReporteResumenReserva As frmReporteFactura = New frmReporteFactura(facturarViewModel.ventaModel, TipoDocumentoFiscal.NotaCredito)
                                  frmReporteResumenReserva.MdiParent = MdiParent
                                  frmReporteResumenReserva.Show()
                              End If

                              Dispose()
                          End If
                      End Function)
    End Sub

    Private Sub frmFacturarNueva_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Ejecutar(Sub() facturarViewModel.Cancelar())
    End Sub

    Private Sub AgregarNumeroFactura_Click(sender As Object, e As EventArgs) Handles AgregarNumeroFactura.Click
        Ejecutar(Sub() facturarViewModel.AgregarNumeroFacturaManual())
    End Sub

    Private Sub QuitarNumeroFactura_Click(sender As Object, e As EventArgs) Handles QuitarNumeroFactura.Click
        Ejecutar(Sub() facturarViewModel.QuitarNumeroFacturaManual(FacturasList.SelectedItem))
    End Sub

    Private Sub Cb_TipoFacturacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_TipoFacturacion.SelectionChangeCommitted
        Ejecutar(Sub() facturarViewModel.TipoFacturacionChange(Cb_TipoFacturacion.SelectedItem))
    End Sub

    Private Sub Cb_IVA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_IVA.SelectionChangeCommitted
        Ejecutar(Sub() facturarViewModel.CondicionesIVAChange(Cb_IVA.SelectedItem))
    End Sub

    Private Sub Ejecutar(accion As Action)
        Try
            accion()
        Catch ex As NegocioException
            facturarViewModel.Visible = True
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
            facturarViewModel.Visible = True
            Log.Error(ex)
            MessageBox.Show(ex.Message, "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            Log.Error(ex)
            MessageBox.Show("Error al realizar la accion. Por favor, intente mas tarde o consulte con el administrador.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class