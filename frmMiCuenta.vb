Public Class frmMiCuenta

    'Load del formulario.
    Private Sub frmMiCuenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Cursor
            Me.Cursor = Cursors.WaitCursor

            'Seteo la información del usuario
            Dim entUsuario As New Entidades.Usuario
            entUsuario = VariablesGlobales.objUsuario
            Nombre.Text = entUsuario.Nombre
            Apellido.Text = entUsuario.Apellido
            Mail.Text = entUsuario.Mail
            Usuario.Text = entUsuario.Usuario
            Fecha.Text = entUsuario.Fecha
            Mensajes.Text = VariablesGlobales.Mensajes.ToString
            Notificaciones.Text = VariablesGlobales.Notificaciones.ToString

            'Cursor
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha encontrado un error al obtener su información.", "Mi Cuenta", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Cerrar el formulario.
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

End Class