Imports System.Threading.Tasks
Imports Common.Core.Exceptions
Imports Common.Core.Helper

Public Class Comun
    Public Sub Ejecutar(accion As Action)
        Try
            Me.UseWaitCursor = True
            accion()
        Catch ex As NegocioException
            Log.Error(ex)
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            Log.Error(ex)
            MessageBox.Show("Error al realizar la accion. Por favor, intente mas tarde o consulte con el administrador.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Me.UseWaitCursor = False
        End Try
    End Sub

    Public Async Sub EjecutarAsync(accion As Func(Of Task))
        Try
            Me.Cursor = Cursors.WaitCursor
            Await accion()
        Catch ex As NegocioException
            Log.Error(ex)
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            Log.Error(ex)
            MessageBox.Show("Error al realizar la accion. Por favor, intente mas tarde o consulte con el administrador.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
End Class