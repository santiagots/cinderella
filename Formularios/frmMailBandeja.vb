Public Class frmMailBandeja
    Dim NegMensajes As New Negocio.NegMensajes
    Dim entMensaje As New Entidades.Mensajes
    Private Sub frmMailBandeja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarBandeja()
    End Sub

    Sub CargarBandeja()
        Try
            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            'Cargo el datagrid
            Dim dsMensajes As New DataSet
            dsMensajes = NegMensajes.ListarMensajes(VariablesGlobales.objUsuario.id_Usuario)
            If (dsMensajes.Tables(0).Rows.Count <> 0) Then
                DG_Mensajes.DataSource = dsMensajes.Tables(0)
                DG_Mensajes.AutoGenerateColumns = False
                DG_Mensajes.Columns("id_Mensaje").Visible = False
                DG_Mensajes.Columns("Remitente").DisplayIndex = 1
                DG_Mensajes.Columns("Asunto").DisplayIndex = 2
                DG_Mensajes.Columns("Leido").DisplayIndex = 3
                DG_Mensajes.Columns("Fecha").DisplayIndex = 4
                DG_Mensajes.Columns("Eliminar").DisplayIndex = 5
                DG_Mensajes.Refresh()
            End If

            'Cambio el cursor a NORMAL.
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show(ex.Message.ToString, "Centro de mensajes", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub DG_Mensajes_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Mensajes.CellDoubleClick
        Dim id_Mensaje As Integer = 0

        If DG_Mensajes.SelectedRows.Count > 0 Then
            If e.RowIndex >= 0 Then

                'Cambio el cursor a "WAIT"
                Me.Cursor = Cursors.WaitCursor

                id_Mensaje = DG_Mensajes.Rows(e.RowIndex).Cells("id_Mensaje").Value()

                'Abro el mail!
                'Pongo el mensaje como Leido
                NegMensajes.MensajeLeido(id_Mensaje)

                Me.WindowState = FormWindowState.Minimized
                frmMailVisor.entMensaje = NegMensajes.TraerMensaje(id_Mensaje)
                frmMailVisor.Show()

                'Cambio el cursor a NORMAL.
                Me.Cursor = Cursors.Arrow

            End If
        End If
    End Sub

    Private Sub DG_Mensajes_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Mensajes.CellContentClick
        If DG_Mensajes.Columns(e.ColumnIndex).Name = "Eliminar" Then 'Si se hace click en el boton "eliminar" de la fila.
            Dim Result As DialogResult
            Result = MessageBox.Show("¿Está seguro que desea eliminar el mensaje?", "Bandeja de Mensajes", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Result = System.Windows.Forms.DialogResult.Yes Then 'Si acepta eliminar el item
                Dim id_Mensaje As Integer = DG_Mensajes.Rows(e.RowIndex).Cells("id_Mensaje").Value
                If id_Mensaje = 0 Then
                    'si no completo la descripcion, muestro un msg de error.
                    MessageBox.Show("No se puede eliminar el mensaje.", "Bandeja de Mensajes", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    'ejecuto el sp_Mensajes_Eliminar.
                    MessageBox.Show(NegMensajes.EliminarMensaje(id_Mensaje), "Bandeja de Mensajes", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    'refresco el datagrid
                    DG_Mensajes.DataSource = NegMensajes.ListarMensajes(VariablesGlobales.objUsuario.id_Usuario).Tables(0)
                    DG_Mensajes.Refresh()
                End If
            End If
        End If
    End Sub

    Private Sub Btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cancelar.Click
        Me.Close()
    End Sub
End Class