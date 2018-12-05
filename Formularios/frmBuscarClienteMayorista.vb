Imports Entidades

Public Class frmBuscarClienteMayorista
    Dim NegClientes As New Negocio.NegClienteMayorista
    Dim dsClientes As DataSet

    Public clienteMayorista As ClienteMayorista

    'Click en Buscar cliente!.
    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        Try
            'Seteo a cursor de espera.
            Me.Cursor = Cursors.WaitCursor

            ClienteMayoristaBindingSource.DataSource = NegClientes.ListadoClientes().Where(Function(x) x.Habilitado AndAlso x.RazonSocial.ToUpper().Contains(txt_Buscar.Text.ToUpper())).ToList()

            'seteo a cursor comun.
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show(ex.Message.ToString, "Buscar Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Load del formulario.
    Private Sub frmBuscarClienteMayorista_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Seteo a cursor de espera.
            Me.Cursor = Cursors.WaitCursor
            ClienteMayoristaBindingSource.DataSource = NegClientes.ListadoClientes().Where(Function(x) x.Habilitado).ToList()

            'seteo a cursor comun.
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show(ex.Message.ToString, "Buscar Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DG_Clientes_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Clientes.CellDoubleClick
        Try
            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            If DG_Clientes.SelectedRows.Count > 0 Then
                If e.RowIndex >= 0 Then
                    clienteMayorista = DG_Clientes.CurrentRow.DataBoundItem
                    Me.Close()
                End If
            End If

            'Cambio el cursor a "NORMAL"
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show(ex.Message.ToString, "Buscar Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Boton limpiar grid.
    Private Sub Btn_Limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Limpiar.Click
        Try
            'Seteo a cursor de espera.
            Me.Cursor = Cursors.WaitCursor
            ClienteMayoristaBindingSource.DataSource = NegClientes.ListadoClientes().Where(Function(x) x.Habilitado).ToList()

            txt_Buscar.Clear()

            'seteo a cursor comun.
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show(ex.Message.ToString, "Buscar Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DG_Clientes_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DG_Clientes.DataBindingComplete
        lbl_Msg.Visible = DG_Clientes.Rows.Count = 0
    End Sub
End Class