Imports System.Threading.Tasks
Imports Common.Core.Enum
Imports Common.Core.Exceptions
Imports Common.Core.Helper
Imports SistemaCinderella.Formularios.Facturacion

Public Class frmVerDocumentoFiscal
    Private frmVerFacturaViewModel As frmVerFacturaViewModel

    Sub New(idDocumentoFiscal As Long, TipoCliente As TipoCliente, tipoDocumentoFiscal As TipoDocumentoFiscal)

        ' This call is required by the designer.
        InitializeComponent()

        frmVerFacturaViewModel = New frmVerFacturaViewModel(idDocumentoFiscal, TipoCliente, tipoDocumentoFiscal)
    End Sub

    Private Sub FrmVerDocumentoFiscal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EjecutarAsync(Async Function() As Task
                          Await frmVerFacturaViewModel.CargarDatosAsync()
                          DocumentoFiscalViewModelBindingSource.DataSource = frmVerFacturaViewModel.DocumentoFiscalViewModel
                      End Function)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Ejecutar(Sub()
                     Dim frmReporteResumenReserva As frmReporteDocumentoPago = New frmReporteDocumentoPago(frmVerFacturaViewModel.IdDocuemtnoFiscal, frmVerFacturaViewModel.TipoCliente, frmVerFacturaViewModel.TipoDocumentoFiscal)
                     frmReporteResumenReserva.ShowDialog()
                 End Sub)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Dispose()
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