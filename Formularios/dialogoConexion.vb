Imports System.Windows.Forms

Public Class dialogoConexion
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub dialogoConexion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Setea el nombre de la aplicacion.
        Me.Text = "Sistema de Gestion " & My.Settings.Empresa & " - " & My.Settings.NombreSucursal
    End Sub
End Class
