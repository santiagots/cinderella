Public Class frmBuscarClienteMayorista
    Dim NegClientes As New Negocio.NegClientes
    Dim dsClientes As DataSet

    Public idCliente As String
    Public razonSocialCliente As String
    Public idListaPrecio As String

    'Tecla ENTER en el campo buscar.
    Private Sub txt_Buscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Buscar.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True

            'Seteo a cursor de espera.
            Me.Cursor = Cursors.WaitCursor

            'Seteo las variables.
            Dim descrip As String
            descrip = Trim(txt_Buscar.Text.ToLower)

            If descrip = "" Then
                ErroresClie.SetError(txt_Buscar, "Debe completar el campo de busqueda.")
            Else
                ErroresClie.SetError(txt_Buscar, Nothing)
                Dim dsClieView As New DataSet
                dsClieView = dsClientes
                Dim dv As DataView = dsClieView.Tables(0).DefaultView
                'filtro el dataset por la descripcion.
                dv.RowFilter = "RazonSocial LIKE '%" + descrip + "%'"

                'actualizo el datagrid
                If dv.Count > 0 Then
                    DG_Clientes.ColumnHeadersVisible = True
                    DG_Clientes.DataSource = dv
                    DG_Clientes.Refresh()
                    lbl_Msg.Visible = False
                Else
                    DG_Clientes.ColumnHeadersVisible = False
                    DG_Clientes.DataSource = Nothing
                    DG_Clientes.Refresh()
                    lbl_Msg.Visible = True
                End If
            End If

            'seteo a cursor comun.
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    'Click en Buscar cliente!.
    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        Try
            'Seteo a cursor de espera.
            Me.Cursor = Cursors.WaitCursor

            'Seteo las variables.
            Dim descrip As String
            descrip = Trim(txt_Buscar.Text.ToLower)

            If descrip = "" Then
                ErroresClie.SetError(txt_Buscar, "Debe completar el campo de busqueda.")
            Else
                ErroresClie.SetError(txt_Buscar, Nothing)
                Dim dsClieView As New DataSet
                dsClieView = dsClientes
                Dim dv As DataView = dsClieView.Tables(0).DefaultView
                'filtro el dataset por la descripcion.
                dv.RowFilter = "RazonSocial LIKE '%" + descrip + "%'"

                'actualizo el datagrid
                If dv.Count > 0 Then
                    DG_Clientes.ColumnHeadersVisible = True
                    DG_Clientes.DataSource = dv
                    DG_Clientes.Refresh()
                    lbl_Msg.Visible = False
                Else
                    DG_Clientes.ColumnHeadersVisible = False
                    DG_Clientes.DataSource = Nothing
                    DG_Clientes.Refresh()
                    lbl_Msg.Visible = True
                End If
            End If

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

            'Cargo el datagrid
            dsClientes = NegClientes.ListadoClientes()
            If dsClientes IsNot Nothing Then
                If (dsClientes.Tables(0).Rows.Count > 0) Then
                    DG_Clientes.DataSource = dsClientes.Tables(0)
                    DG_Clientes.AutoGenerateColumns = False
                    DG_Clientes.ColumnHeadersVisible = True
                    DG_Clientes.Columns("RazonSocial").DisplayIndex = 1
                    DG_Clientes.Columns("Mail").DisplayIndex = 2
                    DG_Clientes.Columns("Telefono").DisplayIndex = 3
                    DG_Clientes.Columns("id_Cliente").Visible = False
                    DG_Clientes.Columns("ListaPrecio").Visible = False
                    DG_Clientes.Columns("id_ListaPrecio").Visible = False
                    DG_Clientes.Columns("Cuit").Visible = False
                    DG_Clientes.Columns("Habilitado").Visible = False
                    DG_Clientes.Columns("Direccion").Visible = False
                    DG_Clientes.Refresh()
                    lbl_Msg.Visible = False
                Else
                    DG_Clientes.DataSource = Nothing
                    DG_Clientes.ColumnHeadersVisible = False
                    DG_Clientes.Refresh()
                    lbl_Msg.Visible = True
                End If
            End If

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
                    idCliente = DG_Clientes.Rows(e.RowIndex).Cells("id_Cliente").Value()
                    razonSocialCliente = DG_Clientes.Rows(e.RowIndex).Cells("RazonSocial").Value()
                    idListaPrecio = DG_Clientes.Rows(e.RowIndex).Cells("id_ListaPrecio").Value()
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

            DG_Clientes.DataSource = Nothing
            DG_Clientes.ClearSelection()
            DG_Clientes.Refresh()

            'Cargo el datagrid
            Dim dv As DataView = dsClientes.Tables(0).DefaultView
            dv.RowFilter = ""

            If dsClientes IsNot Nothing Then
                If (dsClientes.Tables(0).Rows.Count > 0) Then
                    DG_Clientes.DataSource = dv
                    DG_Clientes.AutoGenerateColumns = False
                    DG_Clientes.ColumnHeadersVisible = True
                    DG_Clientes.Columns("RazonSocial").DisplayIndex = 1
                    DG_Clientes.Columns("Mail").DisplayIndex = 2
                    DG_Clientes.Columns("Telefono").DisplayIndex = 3
                    DG_Clientes.Columns("id_Cliente").Visible = False
                    DG_Clientes.Columns("ListaPrecio").Visible = False
                    DG_Clientes.Columns("id_ListaPrecio").Visible = False
                    DG_Clientes.Columns("Cuit").Visible = False
                    DG_Clientes.Columns("Habilitado").Visible = False
                    DG_Clientes.Columns("Direccion").Visible = False
                    DG_Clientes.Refresh()
                    lbl_Msg.Visible = False
                Else
                    DG_Clientes.DataSource = Nothing
                    DG_Clientes.ColumnHeadersVisible = False
                    DG_Clientes.Refresh()
                    lbl_Msg.Visible = True
                End If
            End If

            txt_Buscar.Clear()
            txt_Buscar.Focus()
            ErroresClie.Clear()

            'seteo a cursor comun.
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show(ex.Message.ToString, "Buscar Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class