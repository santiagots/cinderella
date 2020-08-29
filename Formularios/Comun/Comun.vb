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
            MessageBox.Show(ex.Message, "Administración de Productos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            Log.Error(ex)
            MessageBox.Show("Error al realizar la accion. Por favor, intente mas tarde o consulte con el administrador.", "Administración de Productos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Me.UseWaitCursor = False
        End Try
    End Sub

    Public Async Sub EjecutarAsync(accion As Func(Of Task))
        Try
            Me.UseWaitCursor = True
            Await accion()
        Catch ex As NegocioException
            Log.Error(ex)
            MessageBox.Show(ex.Message, "Administración de Productos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            Log.Error(ex)
            MessageBox.Show("Error al realizar la accion. Por favor, intente mas tarde o consulte con el administrador.", "Administración de Productos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Me.UseWaitCursor = False
        End Try
    End Sub
End Class