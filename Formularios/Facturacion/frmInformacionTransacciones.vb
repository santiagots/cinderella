Imports System.Threading.Tasks
Imports Common.Core.Exceptions
Imports Common.Core.Helper
Imports Negocio
Imports SistemaCinderella.Formularios.Facturacion

Public Class frmInformacionTransacciones

    Private frmInformacionTransaccionesViewModel As frmInformacionTransaccionesViewModel

    Private Sub frmInformacionTransacciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ejecutar(Sub()
                     frmInformacionTransaccionesViewModel = New frmInformacionTransaccionesViewModel()
                     FrmInformacionTransaccionesViewModelBindingSource.DataSource = frmInformacionTransaccionesViewModel
                     frmInformacionTransaccionesViewModel.ObtenerMemoriaTransacciones()
                 End Sub)

    End Sub

    Private Sub btn_BorrarJornada_Click(sender As Object, e As EventArgs) Handles btn_BorrarJornada.Click
        Ejecutar(Sub()
                     frmInformacionTransaccionesViewModel.BorrarJornada()
                     MessageBox.Show("Se han borrado las jornadas fiscales de la memoria de forma exitosa", "Información de Transacciones", MessageBoxButtons.OK, MessageBoxIcon.Information)
                 End Sub)
    End Sub

    Private Sub Ejecutar(accion As Action)
        Try
            accion()
        Catch ex As NegocioException
            Log.Error(ex)
            MessageBox.Show(ex.Message, "Información de Transacciones", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            MessageBox.Show(ex.Message, "Información de Transacciones", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            Log.Error(ex)
            MessageBox.Show("Error al realizar la accion. Por favor, intente mas tarde o consulte con el administrador.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class