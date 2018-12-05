Public Class frmMailVisor
    Public entMensaje As New Entidades.Mensajes
    Dim NegUsuarios As New Negocio.Usuario
    Dim NegMensajes As New Negocio.NegMensajes

    Private Sub Btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cerrar.Click
        Me.Close()
        frmMailBandeja.CargarBandeja()
        frmMailBandeja.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Btn_Responder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Responder.Click
        frmMailNuevo.entMensaje = entMensaje
        Me.Close()
        frmMailNuevo.Show()
    End Sub

    Private Sub frmMailVisor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            lblAsunto.Text = entMensaje.Asunto
            lblMensaje.Text = Replace(Trim(entMensaje.Mensaje), "<br />", vbCrLf)
            lblFecha.Text = entMensaje.Fecha

            'Cargo el combo de Usuarios.
            Dim dsUsuarios As New DataSet
            dsUsuarios = NegUsuarios.ListadoUsuarios()
            If (dsUsuarios.Tables(0).Rows.Count > 0) Then
                cb_Usuarios.DataSource = Nothing
                cb_Usuarios.DataSource = dsUsuarios.Tables(0)
                cb_Usuarios.DisplayMember = "Usuario"
                cb_Usuarios.ValueMember = "id_Usuario"
                cb_Usuarios.SelectedValue = entMensaje.id_UsuarioDestino
                cb_Usuarios.Refresh()
            End If

            'Cambio el cursor a NORMAL.
            Me.Cursor = Cursors.Arrow

        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show(ex.Message.ToString, "Centro de Mensajes", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

End Class