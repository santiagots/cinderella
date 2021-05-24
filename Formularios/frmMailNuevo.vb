Public Class frmMailNuevo
    Dim NegUsuarios As New Negocio.Usuario
    Dim NegMensajes As New Negocio.NegMensajes
    Public entMensaje As New Entidades.Mensajes

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cancelar.Click
        Me.Close()
        frmMailBandeja.CargarBandeja()
        frmMailBandeja.WindowState = FormWindowState.Normal
    End Sub

    Private Sub txt_Asunto_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_Asunto.Validating
        If txt_Asunto.Text = "" Then
            ErrorMsg.SetError(txt_Asunto, "Debe completar el asunto del Mensaje.")
        Else
            ErrorMsg.SetError(txt_Asunto, Nothing)
        End If
    End Sub

    Private Sub txt_Mensaje_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_Mensaje.Validating
        If txt_Asunto.Text = "" Then
            ErrorMsg.SetError(txt_Mensaje, "Debe completar el cuerpo del Mensaje.")
        Else
            ErrorMsg.SetError(txt_Mensaje, Nothing)
        End If
    End Sub

    Private Sub Btn_Enviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Enviar.Click
        Try
            If txt_Asunto.Text = "" Or txt_Mensaje.Text = "" Or cb_Usuarios.SelectedValue Is Nothing Then
                MessageBox.Show("Debe completar todos los campos para que el mensaje sea enviado.", "Centro de Mensajes", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else

                'Cambio el cursor a "WAIT"
                Me.Cursor = Cursors.WaitCursor

                Dim Asunto As String = txt_Asunto.Text
                Dim Mensaje As String = ""
                Dim id_Usuario As Integer = VariablesGlobales.objUsuario.id_Usuario
                Dim id_UsuarioDestino As Integer = cb_Usuarios.SelectedValue

                If Trim(txt_Mensaje.Text) = "" Then
                    Mensaje = ""
                Else
                    Mensaje = Replace(Trim(txt_Mensaje.Text), vbCrLf, "<br />")
                End If

                'ejecuto el sp_Mensajes_Alta.
                MessageBox.Show(NegMensajes.EnviarMensaje(Asunto, Mensaje, id_Usuario, id_UsuarioDestino), "Centro de Mensajes", MessageBoxButtons.OK, MessageBoxIcon.Information)

                txt_Asunto.Clear()
                txt_Mensaje.Clear()
                cb_Usuarios.SelectedItem = Nothing

                'Cambio el cursor a NORMAL.
                Me.Cursor = Cursors.Arrow
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show(ex.Message.ToString, "Centro de Mensajes", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub

    'Al momento de cerrar el form.
    Private Sub frmMailNuevo_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If frmMailBandeja.Visible Then
            frmMailBandeja.CargarBandeja()
            frmMailBandeja.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub frmMailNuevo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Cambio el cursor a "WAIT"
        Me.Cursor = Cursors.WaitCursor

        'Cargo el combo de Usuarios.
        Dim dsUsuarios As New DataSet
        dsUsuarios = NegUsuarios.ListadoUsuarios()
        If (dsUsuarios.Tables(0).Rows.Count > 0) Then
            cb_Usuarios.DataSource = Nothing
            cb_Usuarios.DataSource = dsUsuarios.Tables(0)
            cb_Usuarios.DisplayMember = "Usuario"
            cb_Usuarios.ValueMember = "id_Usuario"

            If entMensaje.id_Usuario <> 0 Then
                cb_Usuarios.SelectedValue = entMensaje.id_Usuario
            End If

            cb_Usuarios.Refresh()
        End If

        txt_Asunto.Focus()
        'Cambio el cursor a NORMAL.
        Me.Cursor = Cursors.Arrow
    End Sub
End Class