Public Class frmBuscarProducto
    Dim NegProductos As New Negocio.NegProductos
    Dim dsProductos As New DataSet
    Public TipoForm As Integer
    Public idProducto As String

    'Click en Buscar producto!.
    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        Try
            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            'Seteo las variables.
            Dim descrip As String
            descrip = Trim(txt_Buscar.Text.ToLower)
            If descrip = "" Then
                ErrorProductos.SetError(txt_Buscar, "Debe completar el campo de busqueda.")
            Else
                ErrorProductos.SetError(txt_Buscar, Nothing)
                Dim dsProdView As New DataSet
                dsProdView = dsProductos
                Dim dv As DataView = dsProdView.Tables(0).DefaultView

                If rb_Opcion.Checked = True Then 'Si selecciono nombre.
                    dv.RowFilter = "Nombre LIKE '%" + descrip + "%'"
                ElseIf rb_Opcion2.Checked = True Then 'si selecciono codigo.
                    dv.RowFilter = "Codigo LIKE '%" + descrip + "%'"
                End If

                'actualizo el datagrid
                If dv.Count > 0 Then
                    DG_Productos.ColumnHeadersVisible = True
                    DG_Productos.DataSource = dv
                    DG_Productos.Refresh()
                    lbl_Msg.Visible = False
                Else
                    DG_Productos.ColumnHeadersVisible = False
                    DG_Productos.DataSource = Nothing
                    DG_Productos.Refresh()
                    lbl_Msg.Visible = True
                End If
            End If

            'Cambio el cursor a "NORMAL"
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show(ex.Message.ToString, "Buscar Productos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DG_Productos_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Productos.CellDoubleClick
        Try
            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            If DG_Productos.SelectedRows.Count > 0 Then
                If e.RowIndex >= 0 Then
                    idProducto = DG_Productos.Rows(e.RowIndex).Cells("id_Producto").Value()
                    If idProducto <> "" AndAlso TipoForm = 3 Then
                        frmCargarMercaderiaEgreso.txt_CodigoBarra.Clear()
                        frmCargarMercaderiaEgreso.AgregarItem(idProducto, 1)
                    End If
                    Me.Close()
                End If
            End If

            'Cambio el cursor a "NORMAL"
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show(ex.Message.ToString, "Buscar Productos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Load del formulario.
    Private Sub frmBuscarProducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Seteo a cursor de espera.
            Me.Cursor = Cursors.WaitCursor

            'Cargo el datagrid
            dsProductos = NegProductos.ListadoProductosBuscadores()
            If dsProductos IsNot Nothing Then
                If (dsProductos.Tables(0).Rows.Count > 0) Then
                    DG_Productos.DataSource = dsProductos.Tables(0)
                    DG_Productos.AutoGenerateColumns = False
                    DG_Productos.ColumnHeadersVisible = True
                    DG_Productos.Columns("id_Producto").Visible = False
                    DG_Productos.Columns("CodigoBarra").Visible = False
                    DG_Productos.Refresh()
                    lbl_Msg.Visible = False
                Else
                    DG_Productos.DataSource = Nothing
                    DG_Productos.ColumnHeadersVisible = False
                    DG_Productos.Refresh()
                    lbl_Msg.Visible = True
                End If
            End If

            'seteo a cursor comun.
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show(ex.Message.ToString, "Buscar Productos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Tecla ENTER en el campo buscar.
    Private Sub txt_Buscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Buscar.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True

            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            'Seteo las variables.
            Dim descrip As String
            descrip = Trim(txt_Buscar.Text.ToLower)
            If descrip = "" Then
                ErrorProductos.SetError(txt_Buscar, "Debe completar el campo de busqueda.")
            Else
                ErrorProductos.SetError(txt_Buscar, Nothing)
                Dim dsProdView As New DataSet
                dsProdView = dsProductos
                Dim dv As DataView = dsProdView.Tables(0).DefaultView

                If rb_Opcion.Checked = True Then 'Si selecciono nombre.
                    dv.RowFilter = "Nombre LIKE '%" + descrip + "%'"
                ElseIf rb_Opcion2.Checked = True Then 'si selecciono codigo.
                    dv.RowFilter = "Codigo LIKE '%" + descrip + "%'"
                End If

                'actualizo el datagrid
                If dv.Count > 0 Then
                    DG_Productos.ColumnHeadersVisible = True
                    DG_Productos.DataSource = dv
                    DG_Productos.Refresh()
                    lbl_Msg.Visible = False
                Else
                    DG_Productos.ColumnHeadersVisible = False
                    DG_Productos.DataSource = Nothing
                    DG_Productos.Refresh()
                    lbl_Msg.Visible = True
                End If
            End If

            'Cambio el cursor a "NORMAL"
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    'Boton limpiar grid.
    Private Sub Btn_Limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Limpiar.Click
        Try
            'Seteo a cursor de espera.
            Me.Cursor = Cursors.WaitCursor

            DG_Productos.DataSource = Nothing
            DG_Productos.ClearSelection()
            DG_Productos.Refresh()

            'Cargo el datagrid
            Dim dv As DataView = dsProductos.Tables(0).DefaultView
            dv.RowFilter = ""

            If dsProductos IsNot Nothing Then
                If (dsProductos.Tables(0).Rows.Count > 0) Then
                    DG_Productos.DataSource = dv
                    DG_Productos.AutoGenerateColumns = False
                    DG_Productos.ColumnHeadersVisible = True
                    DG_Productos.Columns("id_Producto").Visible = False
                    DG_Productos.Columns("CodigoBarra").Visible = False
                    DG_Productos.Refresh()
                    lbl_Msg.Visible = False
                Else
                    DG_Productos.DataSource = Nothing
                    DG_Productos.ColumnHeadersVisible = False
                    DG_Productos.Refresh()
                    lbl_Msg.Visible = True
                End If

            End If

            rb_Opcion2.Checked = True
            rb_Opcion.Checked = False
            txt_Buscar.Clear()
            txt_Buscar.Focus()
            ErrorProductos.Clear()

            'seteo a cursor comun.
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show(ex.Message.ToString, "Buscar Productos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'seteo las opciones del buscador.
    Private Sub rb_Opcion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_Opcion.CheckedChanged
        If rb_Opcion.Checked = True Then
            rb_Opcion2.Checked = False
        Else
            rb_Opcion2.Checked = True
        End If
    End Sub

    'seteo las opciones del buscador.
    Private Sub rb_Opcion2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_Opcion2.CheckedChanged
        If rb_Opcion2.Checked = True Then
            rb_Opcion.Checked = False
        Else
            rb_Opcion.Checked = True
        End If
    End Sub

End Class