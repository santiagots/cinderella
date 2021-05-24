Imports System.Threading.Tasks
Imports Common.Core.Exceptions
Imports Common.Core.Helper
Imports Entidades
Imports Negocio
Imports SistemaCinderella.Formularios.Cheque

Public Class frmChequeAlta

    Private frmChequeAltaViewModel As frmChequeAltaViewModel

    Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        frmChequeAltaViewModel = New frmChequeAltaViewModel(My.Settings.Sucursal)
    End Sub

    Private Sub frmChequesAlta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EjecutarAsync(Async Function() As Task
                          ucChequeDetalle.AutoScaleMode = AutoScaleMode.None
                          Await frmChequeAltaViewModel.CargarDatosAsync()
                          ucChequeDetalle.ChequeDetalleViewModelBindingSource.DataSource = frmChequeAltaViewModel.ChequeDetalle
                      End Function)
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        EjecutarAsync(Async Function() As Task
                          Await frmChequeAltaViewModel.Alta()
                          MessageBox.Show("Los datos se han guardado de forma correcta.", "Alta de Cheques", MessageBoxButtons.OK, MessageBoxIcon.Information)
                          Close()
                      End Function)
    End Sub

    Private Sub Btn_Salir_Click(sender As Object, e As EventArgs) Handles Btn_Salir.Click
        Close()
    End Sub

    Private Async Sub EjecutarAsync(accion As Func(Of Task))
        Try
            Await accion()
        Catch ex As NegocioException
            Log.Error(ex)
            MessageBox.Show(ex.Message, "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            Log.Error(ex)
            MessageBox.Show("Error al realizar la accion. Por favor, intente mas tarde o consulte con el administrador." + ex.ToString(), "Administración de Cheques", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class