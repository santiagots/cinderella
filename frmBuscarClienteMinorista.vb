Public Class frmBuscarClienteMinorista

    Public clienteMinorista As Entidades.ClienteMinorista

    'Tecla ENTER en el campo buscar.
    Private Sub txtApellido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtApellido.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            Try
                'Seteo a cursor de espera.
                Me.Cursor = Cursors.WaitCursor

                DG_Clientes.DataSource = BuscarClienteMinorista()

                'seteo a cursor comun.
                Me.Cursor = Cursors.Arrow
            Catch ex As Exception
                Me.Cursor = Cursors.Arrow
                MessageBox.Show("Se ha encontrado un error al realizar la busqueda. Por favor, vuelva a intentar más tarde o contáctese con el Administrador", "Buscar Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    'Tecla ENTER en el campo buscar.
    Private Sub txtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            Try
                'Seteo a cursor de espera.
                Me.Cursor = Cursors.WaitCursor

                DG_Clientes.DataSource = BuscarClienteMinorista()

                'seteo a cursor comun.
                Me.Cursor = Cursors.Arrow
            Catch ex As Exception
                Me.Cursor = Cursors.Arrow
                MessageBox.Show("Se ha encontrado un error al realizar la busqueda. Por favor, vuelva a intentar más tarde o contáctese con el Administrador", "Buscar Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    'Click en Buscar cliente!.
    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        Try
            'Seteo a cursor de espera.
            Me.Cursor = Cursors.WaitCursor

            DG_Clientes.DataSource = BuscarClienteMinorista()

            'seteo a cursor comun.
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha encontrado un error al realizar la busqueda. Por favor, vuelva a intentar más tarde o contáctese con el Administrador", "Buscar Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function BuscarClienteMinorista() As IList(Of Entidades.ClienteMinorista)

        If txtApellido.Text = "" And txtNombre.Text = "" Then
            MessageBox.Show("Debe completar el/los campo de busqueda.", "Buscar Clientes", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim negClienteMinorista As Negocio.NegClienteMinorista = New Negocio.NegClienteMinorista()
            Dim Clientes As List(Of Entidades.ClienteMinorista) = negClienteMinorista.TraerCliente()

            If Not txtApellido.Text = "" Then
                Clientes = Clientes.Where(Function(x) x.Apellido.ToUpper().Contains(txtApellido.Text.ToUpper())).ToList()
            End If

            If Not txtNombre.Text = "" Then
                Clientes = Clientes.Where(Function(x) x.Nombre.ToUpper().Contains(txtNombre.Text.ToUpper())).ToList()
            End If

            Return Clientes
        End If
    End Function

    Private Sub DG_Clientes_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Clientes.CellDoubleClick
        Try
            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            clienteMinorista = DG_Clientes.CurrentRow.DataBoundItem

            Me.DialogResult = DialogResult.OK

            'Cambio el cursor a "NORMAL"
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha encontrado al seleccionar el cliente. Por favor, vuelva a intentar más tarde o contáctese con el Administrador", "Buscar Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Boton limpiar grid.
    Private Sub Btn_Limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Limpiar.Click
        Try
            'Seteo a cursor de espera.
            Me.Cursor = Cursors.WaitCursor

            DG_Clientes.DataSource = Nothing
            DG_Clientes.ClearSelection()
            DG_Clientes.Refresh()


            txtApellido.Clear()
            txtNombre.Clear()

            'seteo a cursor comun.
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha encontrado un error al limpiar el formulario. Por favor, vuelva a intentar más tarde o contáctese con el Administrador", "Buscar Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgSenia_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DG_Clientes.DataBindingComplete
        lbl_Msg.Visible = DG_Clientes.Rows.Count = 0
    End Sub
End Class