Public Class frmProductosCat
    Dim NCategorias As New Negocio.NegProductosCategorias
    Dim ECategorias As New Entidades.productos_Categorias

    'Load del formulario.
    Private Sub frmProductosCat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Cambio el cursor a "WAIT"
        TabCategorias.Cursor = Cursors.WaitCursor

        'seteo el font a 8px
        DG_Categorias.AlternatingRowsDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DG_Categorias.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DG_Categorias.RowHeadersDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DG_Categorias.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        'seteo las imagenes
        Dim ListaImagenes = New ImageList
        ListaImagenes.ImageSize = New Size(32, 32)
        ListaImagenes.TransparentColor = Color.Blue
        ListaImagenes.ColorDepth = ColorDepth.Depth32Bit

        ListaImagenes.Images.Add(My.Resources.Recursos.Productos)
        ListaImagenes.Images.Add(My.Resources.Recursos.IconoADD)
        ListaImagenes.Images.Add(My.Resources.Recursos.Lapiz)

        TabCategorias.ImageList = ListaImagenes

        'icono
        TbListado.ImageIndex = 0
        'icono de alta
        TbAlta.ImageIndex = 1
        'icono de edicion
        TbMod.ImageIndex = 2

        'Cargo el listado de Categorias de productos
        Dim dsCategorias As New DataSet
        dsCategorias = NCategorias.ListadoCategoriasCompleto()
        If (dsCategorias.Tables(0).Rows.Count > 0) Then
            DG_Categorias.DataSource = dsCategorias.Tables(0)
            DG_Categorias.Columns("id_Categoria").Visible = False
            DG_Categorias.Refresh()
        End If

        EvaluarPermisos()

        'Cambio el cursor a NORMAL.
        TabCategorias.Cursor = Cursors.Arrow
    End Sub

    'Funcion Limpiar
    Public Sub LimpiarForm()
        'seteo los controles en cero.
        txt_buscar.Clear()
        txt_descripcion.Clear()
        ErrorCategorias.Clear()
        chk_Habilitado.Checked = True
        chk_Habilitado_mod.Checked = False
        txt_Descripcion_Bus.Clear()
    End Sub

    'Valido que se complete el nombre de la categoria. - ALTA
    Private Sub txt_Descripcion_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If txt_descripcion.Text = "" Then
            ErrorCategorias.SetError(txt_descripcion, "Debe completar la descripcion de la categoría.")
        Else
            ErrorCategorias.SetError(txt_descripcion, Nothing)
        End If
    End Sub

    Private Sub DG_Categorias_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Categorias.CellDoubleClick
        Dim id_Categoria As Integer = 0
        Dim dsCategoria As DataSet

        If DG_Categorias.SelectedRows.Count > 0 Then
            If e.RowIndex >= 0 Then
                id_Categoria = DG_Categorias.Rows(e.RowIndex).Cells("id_Categoria").Value()
                ECategorias.id_Categoria = id_Categoria

                'lleno la entidad categorias
                dsCategoria = NCategorias.ConsultarCategoria(id_Categoria)

                'lleno los controls del tab_modificacion
                txt_Descripcion_Bus.Text = dsCategoria.Tables(0).Rows(0).Item("Descripcion").ToString

                If dsCategoria.Tables(0).Rows(0).Item("Habilitado").ToString = "1" Then
                    chk_Habilitado_mod.Checked = True
                Else
                    chk_Habilitado_mod.Checked = False
                End If

                'hago foco en el tab_modificacion 
                TabCategorias.SelectedTab = TabCategorias.TabPages("TbMod")
                DG_Buscador.Rows(1).Cells(0).Selected = False
                DG_Buscador.Rows(e.RowIndex).Cells(0).Selected = True
            End If
        End If
    End Sub

    'Boton Modificar.
    Private Sub Btn_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Modificar.Click
        Dim descrip As String
        Dim hab As Integer

        'Seteo las variables.
        descrip = Trim(txt_Descripcion_Bus.Text)
        If chk_Habilitado_mod.Checked Then
            hab = 1
        Else
            hab = 0
        End If

        If descrip = "" Then
            'si no completo la descripcion, muestro un msg de error.
            MessageBox.Show("Debe ingresar una Descripcion.", "Administracion de Categorias de Productos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_Descripcion_Bus.Focus()
        Else
            Dim Result As DialogResult
            Result = MessageBox.Show("¿Está seguro que desea modificar la categoría?", "Administracion de Categorias de Productos", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Result = System.Windows.Forms.DialogResult.Yes Then 'Si acepta modificar el item
                'lleno la entidad colores
                ECategorias.Descripcion = descrip
                ECategorias.Habilitado = hab

                Try
                    'ejecuto el sp_AltaCategorias.
                    MessageBox.Show(NCategorias.ModificacionCategorias(ECategorias), "Administracion de Categorias de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Se ha producido un error al modificar la categoria. Por favor, intente más tarde.", "Administracion de Categorias de Productos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

                'seteo los controles en cero.
                chk_Habilitado_mod.Checked = False
                txt_Descripcion_Bus.Focus()

                'refresco el datagrid
                DG_Buscador.DataSource = NCategorias.ListadoCategoriasCompleto().Tables(0)
                DG_Buscador.Refresh()
            End If
        End If
    End Sub

    'A medida que va ingresando su busqueda, va filtrando.
    Private Sub txt_buscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_buscar.TextChanged
        Dim descrip As String
        Dim dv As DataView = NCategorias.ListadoCategoriasCompleto().Tables(0).DefaultView

        'Seteo las variables.
        descrip = Trim(txt_buscar.Text.ToLower)

        If descrip = "" Then
            ErrorCategorias.SetError(txt_buscar, "Debe completar el campo de busqueda.")
        Else
            ErrorCategorias.SetError(txt_buscar, Nothing)
            'filtro el dataset por la descripcion que se va ingresando
            dv.RowFilter = "Descripcion LIKE '%" + descrip + "%'"
        End If

        'actualizo el datagrid
        DG_Buscador.DataSource = dv
        DG_Buscador.Refresh()
    End Sub

    'Al hacer click en una celda del datagrid buscador.
    Private Sub DG_Buscador_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Buscador.CellClick
        Dim id_Categoria As Integer = 0
        Dim dsCategoria As DataSet

        If DG_Buscador.SelectedRows.Count > 0 Then
            If e.RowIndex >= 0 Then
                id_Categoria = DG_Buscador.Rows(e.RowIndex).Cells("id_Categoria_bus").Value()
                ECategorias.id_Categoria = id_Categoria

                'lleno la entidad colores
                dsCategoria = NCategorias.ConsultarCategoria(id_Categoria)

                'lleno los controls del tab_modificacion
                txt_Descripcion_Bus.Text = dsCategoria.Tables(0).Rows(0).Item("Descripcion").ToString

                If dsCategoria.Tables(0).Rows(0).Item("Habilitado").ToString = "1" Then
                    chk_Habilitado_mod.Checked = True
                Else
                    chk_Habilitado_mod.Checked = False
                End If

                'hago foco en el tab_modificacion 
                TabCategorias.SelectedTab = TabCategorias.TabPages("TbMod")
            End If
        End If
    End Sub

    'Al hacer click en el datagrid buscador...
    Private Sub DG_Buscador_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Buscador.CellContentClick

        If DG_Buscador.Columns(e.ColumnIndex).Name = "Eliminar_bus" Then 'Si se hace click en el boton de la fila.
            Dim Result As DialogResult
            Result = MessageBox.Show("¿Está seguro que desea eliminar la categoría?", "Administracion de Categorias de Productos", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Result = System.Windows.Forms.DialogResult.Yes Then 'Si acepta eliminar el item
                Dim id_Categoria As Integer = DG_Buscador.Rows(e.RowIndex).Cells("id_Categoria_bus").Value

                If id_Categoria = 0 Then
                    'si no completo la descripcion, muestro un msg de error.
                    MessageBox.Show("No se puede eliminar la categoria.", "Administracion de Categorias de Productos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    'elimino.
                    MessageBox.Show(NCategorias.EliminarCategorias(id_Categoria), "Administracion de Categorias de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    'refresco el datagrid
                    DG_Buscador.DataSource = NCategorias.ListadoCategoriasCompleto().Tables(0)
                    DG_Buscador.Refresh()
                End If
            End If
        End If
    End Sub

    'Al hacer click en el datagrid categorias...
    Private Sub DG_Categorias_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Categorias.CellContentClick
        If DG_Categorias.Columns(e.ColumnIndex).Name = "Eliminar" Then 'Si se hace click en el boton "eliminar" de la fila.
            Dim Result As DialogResult
            Result = MessageBox.Show("¿Está seguro que desea eliminar la categoria ?", "Administracion de Categorias de Productos", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Result = System.Windows.Forms.DialogResult.Yes Then 'Si acepta eliminar el item
                Dim id_Categoria As Integer = DG_Categorias.Rows(e.RowIndex).Cells("id_Categoria").Value
                If id_Categoria = 0 Then
                    'si no completo la descripcion, muestro un msg de error.
                    MessageBox.Show("No se puede eliminar la categoría.", "Administracion de Categorias de Productos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    'ejecuto el sp_EliminarCategorias.
                    MessageBox.Show(NCategorias.EliminarCategorias(id_Categoria), "Administracion de Categorias de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    'refresco el datagrid
                    DG_Categorias.DataSource = NCategorias.ListadoCategoriasCompleto().Tables(0)
                    DG_Categorias.Refresh()
                End If
            End If
        ElseIf DG_Categorias.Columns(e.ColumnIndex).Name = "Modificar" Then 'Si se hace click en el boton "modificar" de la fila.
            Dim id_Categoria As Integer = DG_Categorias.Rows(e.RowIndex).Cells("id_Categoria").Value()
            Dim dsColor As DataSet

            ECategorias.id_Categoria = id_Categoria

            'lleno la entidad categorias
            dsColor = NCategorias.ConsultarCategoria(id_Categoria)

            'lleno los controls del tab_modificacion
            txt_Descripcion_Bus.Text = dsColor.Tables(0).Rows(0).Item("Descripcion").ToString

            If dsColor.Tables(0).Rows(0).Item("Habilitado").ToString = "1" Then
                chk_Habilitado_mod.Checked = True
            Else
                chk_Habilitado_mod.Checked = False
            End If

            'hago foco en el tab_modificacion 
            TabCategorias.SelectedTab = TabCategorias.TabPages("TbMod")
        End If

    End Sub

    'Al hacer click en el boton buscar.
    Private Sub Btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Buscar.Click
        Dim descrip As String
        Dim dv As DataView = NCategorias.ListadoCategoriasCompleto().Tables(0).DefaultView

        'Seteo las variables.
        descrip = Trim(txt_buscar.Text.ToLower)

        If descrip = "" Then
            ErrorCategorias.SetError(txt_buscar, "Debe completar el campo de busqueda.")
        Else
            ErrorCategorias.SetError(txt_buscar, Nothing)
            'filtro el dataset por la descripcion que se va ingresando
            dv.RowFilter = "Descripcion LIKE '%" + descrip + "%'"
        End If

        'actualizo el datagrid
        DG_Buscador.DataSource = dv
        DG_Buscador.Refresh()
    End Sub

    'Boton Agregar.
    Private Sub Btn_Agregar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Agregar.Click
        Dim descrip As String
        Dim hab As Integer

        'Seteo las variables.
        descrip = Trim(txt_descripcion.Text)
        If chk_Habilitado.Checked Then
            hab = 1
        Else
            hab = 0
        End If

        If descrip = "" Then
            'si no completo la descripcion, muestro un msg de error.
            MessageBox.Show("Debe ingresar una Descripcion.", "Administración de Colores", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_descripcion.Focus()
        Else

            'Cambio el cursor a "WAIT"
            TabCategorias.Cursor = Cursors.WaitCursor

            Try
                'ejecuto el sp_AltaColores.
                MessageBox.Show(NCategorias.AltaCategorias(descrip, hab), "Administración de Categorias de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Se ha producido un error al agregar la categoría. Por favor, intente más tarde.", "Administración de Categorias de Productos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try


            'Cambio el cursor a "NORMAL"
            TabCategorias.Cursor = Cursors.Arrow

            'seteo los controles en cero.
            txt_descripcion.Clear()
            chk_Habilitado.Checked = True
        End If
    End Sub

    'Caundo cambia el tab.
    Private Sub TabCategorias_Selected1(ByVal sender As Object, ByVal e As System.Windows.Forms.TabControlEventArgs) Handles TabCategorias.Selected
        'Cambio el cursor a "WAIT"
        TabCategorias.Cursor = Cursors.WaitCursor

        'Actualizo el datagrid si se selecciona el tab del listado o el tab de modificacion
        If TabCategorias.SelectedTab.Name = "TbListado" Then 'LISTADO
            'Limpio el Formulario
            LimpiarForm()
            'Cargo el listado de Categorias
            If (NCategorias.ListadoCategoriasCompleto().Tables.Count <> 0) Then
                DG_Categorias.DataSource = NCategorias.ListadoCategoriasCompleto().Tables(0)
                DG_Categorias.Columns("id_Categoria").Visible = False
                DG_Categorias.Refresh()
            End If
        ElseIf TabCategorias.SelectedTab.Name = "TbAlta" Then 'ALTA
            'Limpio el Formulario
            LimpiarForm()
            txt_descripcion.Focus()
        ElseIf TabCategorias.SelectedTab.Name = "TbMod" Then 'MODIFICACION
            'Cargo el listado de Categorias
            If (NCategorias.ListadoCategoriasCompleto().Tables.Count <> 0) Then
                DG_Buscador.DataSource = NCategorias.ListadoCategoriasCompleto().Tables(0)
                DG_Buscador.Columns("id_Categoria_Bus").Visible = False
                DG_Buscador.Refresh()
            End If
        End If

        'Cambio el cursor a "WAIT"
        TabCategorias.Cursor = Cursors.Arrow
    End Sub

    'Valido que se complete el nombre de la categoria. - MODIFICACION
    Private Sub txt_Descripcion_Bus_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_Descripcion_Bus.Validating
        If txt_Descripcion_Bus.Text = "" Then
            ErrorCategorias.SetError(txt_Descripcion_Bus, "Debe completar la descripcion de la categoría.")
        Else
            ErrorCategorias.SetError(txt_Descripcion_Bus, Nothing)
        End If
    End Sub

    Sub EvaluarPermisos()
        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Productos_Categorías_Crear)) Then

        Else
            TabCategorias.TabPages.Remove(TabCategorias.TabPages("TbAlta"))
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Productos_Categorías_Eliminar)) Then
            DG_Categorias.Columns("Eliminar").Visible = True
        Else
            DG_Categorias.Columns("Eliminar").Visible = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Productos_Categorías_Modificar)) Then
            DG_Categorias.Columns("Modificar").Visible = True
        Else
            TabCategorias.TabPages.Remove(TabCategorias.TabPages("TbMod"))
            DG_Categorias.Columns("Modificar").Visible = False
            RemoveHandler DG_Categorias.CellDoubleClick, AddressOf DG_Categorias_CellDoubleClick
        End If
    End Sub
End Class