Public Class DialogInput
    Public Sub New(texto As String, titulo As String)
        ' This call is required by the designer.
        InitializeComponent()

        Me.Text = titulo
        lblText.Text = texto
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = DialogResult.Cancel
        txtRespuesta.Text = String.Empty
    End Sub
End Class