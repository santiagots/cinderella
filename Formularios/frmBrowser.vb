Public Class frmBrowser

    Private Sub frmBrowser_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If frmPlanillaPrecios.WindowState = FormWindowState.Minimized Then
            frmPlanillaPrecios.WindowState = FormWindowState.Normal
        End If
    End Sub

End Class