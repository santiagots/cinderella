Imports System.ComponentModel

Public Class CustomDataGrid
    Inherits DataGridView

    Public Delegate Sub keyEventHandler(ByVal sender As Object, ByVal e As KeyEventArgs)

    ''' <summary>
    ''' Captura el evento enter en una celda en edición
    ''' </summary>
    <Browsable(True)>
    Public Event KeyPressEnter As keyEventHandler

    'Capturo el ENTER en la grilla
    Protected Overrides Function ProcessDialogKey(ByVal keyData As Keys) As Boolean
        If keyData = Keys.Enter Then
            RaiseEvent KeyPressEnter(Me, New KeyEventArgs(keyData))
            Return True
        End If

        Return MyBase.ProcessDialogKey(keyData)
    End Function
End Class

