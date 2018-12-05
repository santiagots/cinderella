Public Class DialogSincronizar
    Private Sub btn_Aceptar_Click(sender As Object, e As EventArgs) Handles btn_Aceptar.Click
        DialogResult = DialogResult.OK
    End Sub

    Private Sub btn_Posponer_Click(sender As Object, e As EventArgs) Handles btn_Posponer.Click
        DialogResult = DialogResult.Cancel
    End Sub
End Class