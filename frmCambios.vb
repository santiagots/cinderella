Public Class frmCambios
    'Instancias
    Dim NegProductos As New Negocio.NegProductos
    Public CodigoProducto As String
    Public codigoBarras As String

    Private Sub Btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cancelar.Click
        Me.Close()
    End Sub

    Private Sub Btn_Finalizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Finalizar.Click
        Me.Cursor = Cursors.WaitCursor
        If Not txt_Codigo.Text.Trim = "" Then
            If txt_Codigo.TextLength >= 13 Then
                codigoBarras = txt_Codigo.Text.Trim
                Me.Close()
            Else
                CodigoProducto = txt_Codigo.Text.Trim
                Me.Close()
            End If
        End If
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub txt_Codigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Codigo.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            Me.Cursor = Cursors.WaitCursor
            If Not txt_Codigo.Text.Trim = "" Then
                If txt_Codigo.TextLength >= 13 Then
                    codigoBarras = txt_Codigo.Text.Trim
                    Me.Close()
                Else
                    CodigoProducto = txt_Codigo.Text.Trim
                    Me.Close()
                End If
            End If
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

End Class