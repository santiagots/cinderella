Imports System.Threading.Tasks
Imports Common.Core.Enum
Imports Common.Core.Exceptions
Imports Common.Core.Helper
Imports SistemaCinderella.Formularios.Venta

Public Class frmVerDocumentoFiscal
    Private frmVerFacturaViewModel As frmVerFacturaViewModel

    Sub New(idDocumentoFiscal As Long, tipoDocumentoFiscal As TipoDocumentoFiscal)

        ' This call is required by the designer.
        InitializeComponent()

        frmVerFacturaViewModel = New frmVerFacturaViewModel(idDocumentoFiscal, tipoDocumentoFiscal)
    End Sub

    Private Sub FrmVerDocumentoFiscal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EjecutarAsync(Async Function() As Task
                          Await frmVerFacturaViewModel.CargarDatosAsync()
                          DocumentoFiscalViewModelBindingSource.DataSource = frmVerFacturaViewModel.DocumentoFiscalViewModel
                      End Function)
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