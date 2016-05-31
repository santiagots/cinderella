Public Class frmProductosSubcat
    Dim NSubcategorias As New Negocio.NegProductosSubcategorias
    Dim NCategorias As New Negocio.NegProductosCategorias
    Dim ESubcategorias As New Entidades.Productos_Subcategorias

    'Load del formulario
    Private Sub frmProductosSubcat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Cambio el cursor a "WAIT"
        TabSubcategorias.Cursor = Cursors.WaitCursor

        'seteo el font a 8px
        DG_Subcategorias.AlternatingRowsDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DG_Subcategorias.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DG_Subcategorias.RowHeadersDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DG_Subcategorias.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        'seteo las imagenes
        Dim ListaImagenes = New ImageList
        ListaImagenes.ImageSize = New Size(32, 32)
        ListaImagenes.TransparentColor = Color.Blue
        ListaImagenes.ColorDepth = ColorDepth.Depth32Bit

        ListaImagenes.Images.Add(My.Resources.Recursos.Productos)
        ListaImagenes.Images.Add(My.Resources.Recursos.IconoADD)
        ListaImagenes.Images.Add(My.Resources.Recursos.Lapiz)

        TabSubcategorias.ImageList = ListaImagenes

        'icono
        TbListado.ImageIndex = 0
        'icono de alta
        TbAlta.ImageIndex = 1
        'icono de edicion
        TbMod.ImageIndex = 2

        'Cargo el listado de subcategorias
        Dim dsSubcategorias As New DataSet
        dsSubcategorias = NSubcategorias.ListadoSubcategoriasCompleto()
        If (dsSubcategorias.Tables(0).Rows.Count <> 0) Then
            DG_Subcategorias.DataSource = dsSubcategorias.Tables(0)
            DG_Subcategorias.Columns("id_Subcategoria").Visible = False
            DG_Subcategorias.Columns("Categoria").DisplayIndex = 0
            DG_Subcategorias.Columns("Descripcion").DisplayIndex = 1
            DG_Subcategorias.Columns("Habilitado").DisplayIndex = 2
            DG_Subcategorias.Columns("Modificar").DisplayIndex = 3
            DG_Subcategorias.Columns("Eliminar").DisplayIndex = 4
            DG_Subcategorias.Refresh()
        End If

        EvaluarPermisos()

        'Cambio el cursor a NORMAL.
        TabSubcategorias.Cursor = Cursors.Arrow
    End Sub

    'Cuando realiza el tab
    Private Sub TabSubcategorias_Selected(ByVal sender As Object, ByVal e As System.Windows.Forms.TabControlEventArgs) Handles TabSubcategorias.Selected
        'Cambio el cursor a "WAIT"
        TabSubcategorias.Cursor = Cursors.WaitCursor

        'Actualizo el datagrid si se selecciona el tab del listado o el tab de modificacion
        If TabSubcategorias.SelectedTab.Name = "TbListado" Then 'LISTADO
            'Limpio el Formulario
            LimpiarForm()
            'Cargo el listado de Categorias
            If (NSubcategorias.ListadoSubcategoriasCompleto().Tables.Count <> 0) Then
                DG_Subcategorias.DataSource = NSubcategorias.ListadoSubcategoriasCompleto().Tables(0)
                DG_Subcategorias.Columns("id_Subcategoria").Visible = False
                DG_Subcategorias.Columns("Categoria").DisplayIndex = 0
                DG_Subcategorias.Columns("Descripcion").DisplayIndex = 1
                DG_Subcategorias.Columns("Habilitado").DisplayIndex = 2
                DG_Subcategorias.Columns("Modificar").DisplayIndex = 3
                DG_Subcategorias.Columns("Eliminar").DisplayIndex = 4
                DG_Subcategorias.Refresh()
            End If
        ElseIf TabSubcategorias.SelectedTab.Name = "TbAlta" Then 'ALTA
            'Limpio el Formulario
            LimpiarForm()
            txt_descripcion.Focus()

            'Cargo el listado de categorias
            If (NCategorias.ListadoCategorias().Tables.Count <> 0) Then
                Cb_Categorias.DataSource = NCategorias.ListadoCategorias().Tables(0)
                Cb_Categorias.DisplayMember = "Descripcion"
                Cb_Categorias.ValueMember = "id_Categoria"
                Cb_Categorias.Refresh()
            End If

        ElseIf TabSubcategorias.SelectedTab.Name = "TbMod" Then 'MODIFICACION
            'Cargo el listado de subcategorias
            If (NSubcategorias.ListadoSubcategoriasCompleto().Tables.Count <> 0) Then
                DG_Buscador.DataSource = NSubcategorias.ListadoSubcategoriasCompleto().Tables(0)
                DG_Buscador.Columns("id_Subcategoria_Bus").Visible = False
                DG_Buscador.Columns("Categoria_Bus").DisplayIndex = 0
                DG_Buscador.Columns("Descripcion_Bus").DisplayIndex = 1
                DG_Buscador.Columns("Habilitado_Bus").DisplayIndex = 2
                DG_Buscador.Columns("Eliminar_Bus").DisplayIndex = 3
                DG_Buscador.Refresh()
            End If
        End If

        'Cambio el cursor a "WAIT"
        TabSubcategorias.Cursor = Cursors.Arrow
    End Sub

    'Funcion Limpiar
    Public Sub LimpiarForm()
        'seteo los controles en cero.
        txt_buscar.Clear()
        txt_descripcion.Clear()
        ErrorSubcategorias.Clear()
        chk_Habilitado.Checked = True
        chk_Habilitado_mod.Checked = True
    End Sub

    'Alta de subcategoria
    Private Sub Btn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Agregar.Click
        Dim descrip As String
        Dim hab, categoria As Integer

        'Seteo las variables.
        descrip = Trim(txt_descripcion.Text)
        categoria = Cb_Categorias.SelectedValue
        If chk_Habilitado.Checked Then
            hab = 1
        Else
            hab = 0
        End If

        If descrip = "" Then
            'si no completo la descripcion, muestro un msg de error.
            MessageBox.Show("Debe ingresar una Categoría y una Descripción.", "Administración de Subcateogrias de Productos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_descripcion.Focus()
        Else

            'Cambio el cursor a "WAIT"
            TabSubcategorias.Cursor = Cursors.WaitCursor

            Try
                'ejecuto el sp_AltaColores.
                MessageBox.Show(NSubcategorias.AltaSubcategorias(descrip, categoria, hab), "Administración de Subcateogrias de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Se ha producido un error al agregar la subcategoría. Por favor, intente más tarde.", "Administración de Subcateogrias de Productos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try


            'Cambio el cursor a "NORMAL"
            TabSubcategorias.Cursor = Cursors.Arrow

            'seteo los controles en cero.
            txt_descripcion.Clear()
            Cb_Categorias.SelectedItem = Nothing
            chk_Habilitado.Checked = True
        End If
    End Sub

    'Al hacer click en el datagrid subcategorias...
    Private Sub DG_Subcategorias_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Subcategorias.CellContentClick
        If DG_Subcategorias.Columns(e.ColumnIndex).Name = "Eliminar" Then 'Si se hace click en el boton "eliminar" de la fila.
            Dim Result As DialogResult
            Result = MessageBox.Show("¿Está seguro que desea eliminar la subcategoria ?", "Administracion de Subcategorias de Productos", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Result = System.Windows.Forms.DialogResult.Yes Then 'Si acepta eliminar el item
                Dim id_Subcategoria As Integer = DG_Subcategorias.Rows(e.RowIndex).Cells("id_Subcategoria").Value
                If id_Subcategoria = 0 Then
                    'si no completo la descripcion, muestro un msg de error.
                    MessageBox.Show("No se puede eliminar la subcategoría.", "Administracion de Subcategorias de Productos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    'ejecuto el sp_EliminarCategorias.
                    MessageBox.Show(NSubcategorias.EliminarSubCategorias(id_Subcategoria), "Administracion de Subcategorias de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    'refresco el datagrid
                    DG_Subcategorias.DataSource = NSubcategorias.ListadoSubcategoriasCompleto().Tables(0)
                    DG_Subcategorias.Refresh()
                End If
            End If
        ElseIf DG_Subcategorias.Columns(e.ColumnIndex).Name = "Modificar" Then 'Si se hace click en el boton "modificar" de la fila.
            Dim id_Subcategoria As Integer = DG_Subcategorias.Rows(e.RowIndex).Cells("id_Subcategoria").Value()
            Dim dsSubcat As DataSet

            ESubcategorias.id_Subcategoria = id_Subcategoria

            'lleno la entidad subcategoria
            dsSubcat = NSubcategorias.ConsultarSubcategoria(id_Subcategoria)

            'lleno los controls del tab_modificacion
            txt_Descripcion_Bus.Text = dsSubcat.Tables(0).Rows(0).Item("Descripcion").ToString
            'Cargo el listado de categorias
            If (NCategorias.ListadoCategorias().Tables.Count <> 0) Then
                Cb_Categorias_Bus.DataSource = NCategorias.ListadoCategorias().Tables(0)
                Cb_Categorias_Bus.DisplayMember = "Descripcion"
                Cb_Categorias_Bus.ValueMember = "id_Categoria"
                Cb_Categorias_Bus.SelectedValue = dsSubcat.Tables(0).Rows(0).Item("id_Categoria").ToString
                Cb_Categorias_Bus.Refresh()
            End If

            If dsSubcat.Tables(0).Rows(0).Item("Habilitado").ToString = "1" Then
                chk_Habilitado_mod.Checked = True
            Else
                chk_Habilitado_mod.Checked = False
            End If

            'hago foco en el tab_modificacion 
            TabSubcategorias.SelectedTab = TabSubcategorias.TabPages("TbMod")
        End If
    End Sub

    'Al hacer DOBLEclick en el datagrid subcategorias...
    Private Sub DG_Subcategorias_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Subcategorias.CellDoubleClick
        Dim id_Subcategoria As Integer = 0
        Dim dsSubcategoria As DataSet

        If DG_Subcategorias.SelectedRows.Count > 0 Then
            If e.RowIndex >= 0 Then
                id_Subcategoria = DG_Subcategorias.Rows(e.RowIndex).Cells("id_Subcategoria").Value()
                ESubcategorias.id_Subcategoria = id_Subcategoria

                'lleno la entidad subcategorias
                dsSubcategoria = NSubcategorias.ConsultarSubcategoria(id_Subcategoria)

                'lleno los controls del tab_modificacion
                txt_Descripcion_Bus.Text = dsSubcategoria.Tables(0).Rows(0).Item("Descripcion").ToString
                'Cargo el listado de categorias
                If (NCategorias.ListadoCategorias().Tables.Count <> 0) Then
                    Cb_Categorias_Bus.DataSource = NCategorias.ListadoCategorias().Tables(0)
                    Cb_Categorias_Bus.DisplayMember = "Descripcion"
                    Cb_Categorias_Bus.ValueMember = "id_Categoria"
                    Cb_Categorias_Bus.SelectedValue = dsSubcategoria.Tables(0).Rows(0).Item("id_Categoria").ToString
                    Cb_Categorias_Bus.Refresh()
                End If
                If dsSubcategoria.Tables(0).Rows(0).Item("Habilitado").ToString = "1" Then
                    chk_Habilitado_mod.Checked = True
                Else
                    chk_Habilitado_mod.Checked = False
                End If

                'hago foco en el tab_modificacion 
                TabSubcategorias.SelectedTab = TabSubcategorias.TabPages("TbMod")
                DG_Buscador.Rows(1).Cells(0).Selected = False
                DG_Buscador.Rows(e.RowIndex).Selected = True
            End If
        End If
    End Sub

    'Modificacion de subcategoria
    Private Sub Btn_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Modificar.Click
        Dim descrip As String
        Dim hab, categoria As Integer

        'Seteo las variables.
        descrip = Trim(txt_Descripcion_Bus.Text)
        categoria = Cb_Categorias_Bus.SelectedValue
        If chk_Habilitado_mod.Checked Then
            hab = 1
        Else
            hab = 0
        End If

        If descrip = "" Then
            'si no completo la descripcion, muestro un msg de error.
            MessageBox.Show("Debe ingresar una Categoría y una Descripción.", "Administracion de Subcategorias de Productos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_Descripcion_Bus.Focus()
        Else
            Dim Result As DialogResult
            Result = MessageBox.Show("¿Está seguro que desea modificar la subcategoría?", "Administracion de Subcategorias de Productos", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Result = System.Windows.Forms.DialogResult.Yes Then 'Si acepta modificar el item
                'lleno la entidad colores
                ESubcategorias.Descripcion = descrip
                ESubcategorias.id_Categoria = categoria
                ESubcategorias.Habilitado = hab

                'Try
                '    'ejecuto el sp_AltaCategorias.
                '    MessageBox.Show(NSubcategorias.ModificacionSubcategorias(ESubcategorias), "Administracion de Categorias de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'Catch ex As Exception
                '    MessageBox.Show("Se ha producido un error al modificar la subcategoría. Por favor, intente más tarde.", "Administracion de Categorias de Productos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'End Try

                'seteo los controles en cero.
                chk_Habilitado_mod.Checked = False
                txt_Descripcion_Bus.Clear()
                txt_Descripcion_Bus.Focus()
                Cb_Categorias_Bus.SelectedItem = Nothing

                'refresco el datagrid
                DG_Buscador.DataSource = NSubcategorias.ListadoSubcategoriasCompleto().Tables(0)
                DG_Buscador.Refresh()
            End If
        End If
    End Sub

    'Valido que se complete el nombre de la subcategoria. - ALTA
    Private Sub txt_descripcion_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_descripcion.Validating
        If txt_descripcion.Text = "" Then
            ErrorSubcategorias.SetError(txt_descripcion, "Debe completar la descripcion de la subcategoría.")
        Else
            ErrorSubcategorias.SetError(txt_descripcion, Nothing)
        End If
    End Sub

    'Valido que se complete el nombre de la subcategoria. - MODIFICACION
    Private Sub txt_Descripcion_Bus_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_Descripcion_Bus.Validating
        If txt_Descripcion_Bus.Text = "" Then
            ErrorSubcategorias.SetError(txt_Descripcion_Bus, "Debe completar la descripcion de la subcategoría.")
        Else
            ErrorSubcategorias.SetError(txt_Descripcion_Bus, Nothing)
        End If
    End Sub

    'Al hacer click en el boton buscar.
    Private Sub Btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Buscar.Click
        Dim descrip As String
        Dim dv As DataView = NSubcategorias.ListadoSubcategoriasCompleto().Tables(0).DefaultView

        'Seteo las variables.
        descrip = Trim(txt_buscar.Text.ToLower)

        If descrip = "" Then
            ErrorSubcategorias.SetError(txt_buscar, "Debe completar el campo de busqueda.")
        Else
            ErrorSubcategorias.SetError(txt_buscar, Nothing)
            'filtro el dataset por la descripcion que se va ingresando
            dv.RowFilter = "Descripcion LIKE '%" + descrip + "%'"
        End If

        'actualizo el datagrid
        DG_Buscador.DataSource = dv
        DG_Buscador.Refresh()
    End Sub

    'A medida que va ingresando su busqueda, va filtrando.
    Private Sub txt_buscar_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_buscar.TextChanged
        Dim descrip As String
        Dim dv As DataView = NSubcategorias.ListadoSubcategoriasCompleto().Tables(0).DefaultView

        'Seteo las variables.
        descrip = Trim(txt_buscar.Text.ToLower)

        If descrip = "" Then
            ErrorSubcategorias.SetError(txt_buscar, "Debe completar el campo de busqueda.")
        Else
            ErrorSubcategorias.SetError(txt_buscar, Nothing)
            'filtro el dataset por la descripcion que se va ingresando
            dv.RowFilter = "Descripcion LIKE '%" + descrip + "%'"
        End If

        'actualizo el datagrid
        DG_Buscador.DataSource = dv
        DG_Buscador.Refresh()
    End Sub

    Private Sub DG_Buscador_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Buscador.CellClick
        Dim id_Subcategoria As Integer = 0
        Dim dsSubcategoria As DataSet

        If DG_Buscador.SelectedRows.Count > 0 Then
            If e.RowIndex >= 0 Then
                id_Subcategoria = DG_Buscador.Rows(e.RowIndex).Cells("id_Subcategoria_Bus").Value()
                ESubcategorias.id_Subcategoria = id_Subcategoria

                'lleno la entidad colores
                dsSubcategoria = NSubcategorias.ConsultarSubcategoria(id_Subcategoria)

                'lleno los controls del tab_modificacion
                txt_Descripcion_Bus.Text = dsSubcategoria.Tables(0).Rows(0).Item("Descripcion").ToString
                'Cargo el listado de categorias
                If (NCategorias.ListadoCategorias().Tables.Count <> 0) Then
                    Cb_Categorias_Bus.DataSource = NCategorias.ListadoCategorias().Tables(0)
                    Cb_Categorias_Bus.DisplayMember = "Descripcion"
                    Cb_Categorias_Bus.ValueMember = "id_Categoria"
                    Cb_Categorias_Bus.SelectedValue = dsSubcategoria.Tables(0).Rows(0).Item("id_Categoria").ToString
                    Cb_Categorias_Bus.Refresh()
                End If
                If dsSubcategoria.Tables(0).Rows(0).Item("Habilitado").ToString = "1" Then
                    chk_Habilitado_mod.Checked = True
                Else
                    chk_Habilitado_mod.Checked = False
                End If

                'hago foco en el tab_modificacion 
                TabSubcategorias.SelectedTab = TabSubcategorias.TabPages("TbMod")
            End If
        End If
    End Sub

    'Al hacer click en el datagrid buscador...
    Private Sub DG_Buscador_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Buscador.CellContentClick
        If DG_Buscador.Columns(e.ColumnIndex).Name = "Eliminar_bus" Then 'Si se hace click en el boton de la fila.
            Dim Result As DialogResult
            Result = MessageBox.Show("¿Está seguro que desea eliminar la subcategoría?", "Administracion de Subcategorias de Productos", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Result = System.Windows.Forms.DialogResult.Yes Then 'Si acepta eliminar el item
                Dim id_Subcategoria As Integer = DG_Buscador.Rows(e.RowIndex).Cells("id_Subcategoria_bus").Value

                If id_Subcategoria = 0 Then
                    'si no completo la descripcion, muestro un msg de error.
                    MessageBox.Show("No se puede eliminar la subcategoria.", "Administracion de Subcategorias de Productos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    'elimino
                    MessageBox.Show(NSubcategorias.EliminarSubCategorias(id_Subcategoria), "Administracion de Subcategorias de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    'refresco el datagrid
                    DG_Buscador.DataSource = NSubcategorias.ListadoSubcategoriasCompleto().Tables(0)
                    DG_Buscador.Refresh()
                End If
            End If
        End If
    End Sub

    Sub EvaluarPermisos()
        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Productos_Subcategoría_Crear)) Then

        Else
            TabSubcategorias.TabPages.Remove(TabSubcategorias.TabPages("TbAlta"))
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Productos_Subcategoría_Eliminar)) Then
            DG_Subcategorias.Columns("Eliminar").Visible = True
            DG_Buscador.Columns("Eliminar_bus").Visible = True
        Else
            DG_Subcategorias.Columns("Eliminar").Visible = False
            DG_Buscador.Columns("Eliminar_bus").Visible = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Productos_Subcategoría_Modificar)) Then
            DG_Subcategorias.Columns("Modificar").Visible = True
        Else
            TabSubcategorias.TabPages.Remove(TabSubcategorias.TabPages("TbMod"))
            DG_Subcategorias.Columns("Modificar").Visible = False
            RemoveHandler DG_Subcategorias.CellDoubleClick, AddressOf DG_Subcategorias_CellDoubleClick
        End If
    End Sub
End Class