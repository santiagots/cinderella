Public Class frmNotificaciones

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Opacity = Me.Opacity - 0.3
        If Me.Opacity <= 0 Then Me.Close()
    End Sub

    Private Sub frmNotificaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim working_area As Rectangle = SystemInformation.WorkingArea
        Dim x As Integer = working_area.Left + working_area.Width - Me.Width - 90
        Dim y As Integer = working_area.Top + working_area.Height - Me.Height - 80
        Me.Location = New Point(x, y)
    End Sub
End Class