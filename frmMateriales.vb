Public Class frmMateriales
    Dim NMateriales As New Negocio.NegMateriales
    Dim EMateriales As New Entidades.Materiales

    'Load del Formulario.
    Private Sub frmMateriales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Cambio el cursor a "WAIT"
        TabMateriales.Cursor = Cursors.WaitCursor

        'seteo el font a 8px
        DG_Materiales.AlternatingRowsDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DG_Materiales.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DG_Materiales.RowHeadersDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DG_Materiales.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        'seteo las imagenes
        Dim ListaImagenes = New ImageList
        ListaImagenes.ImageSize = New Size(32, 32)
        ListaImagenes.TransparentColor = Color.Blue
        ListaImagenes.ColorDepth = ColorDepth.Depth32Bit

        ListaImagenes.Images.Add(My.Resources.Recursos.materiales)
        ListaImagenes.Images.Add(My.Resources.Recursos.IconoADD)
        ListaImagenes.Images.Add(My.Resources.Recursos.Lapiz)

        TabMateriales.ImageList = ListaImagenes

        'icono de materiales
        TbListado.ImageIndex = 0
        'icono de alta
        TbAlta.ImageIndex = 1
        'icono de edicion
        TbMod.ImageIndex = 2

        'Cargo el listado de Materiales
        If (NMateriales.ListadoMaterialesCompleto().Tables.Count <> 0) Then
            DG_Materiales.DataSource = NMateriales.ListadoMaterialesCompleto().Tables(0)
            DG_Materiales.Refresh()
        End If

        'agregado para probar el funcionamiento de patentes
        Dim objusuario As New Negocio.Usuario
        '203 visualiza Material - si llego aca puede visualizarlos
        '201 crear Material
        If (objusuario.EsPatenteValida(201, VariablesGlobales.Patentes)) Then
        Else
            TabMateriales.TabPages.Remove(Me.TbAlta)
        End If
        '202 modificar Material
        If (objusuario.EsPatenteValida(202, VariablesGlobales.Patentes)) Then
        Else
            TabMateriales.TabPages.Remove(Me.TbMod)
            DG_Materiales.Columns(1).Visible = False
        End If
        '201 eliminar Material
        If (objusuario.EsPatenteValida(201, VariablesGlobales.Patentes)) Then
        Else
            TabMateriales.TabPages.Remove(Me.TbMod)
            DG_Materiales.Columns(0).Visible = False
            DG_Buscador.Columns("Eliminar_bus").Visible = False
        End If

        'Cambio el cursor a NORMAL.
        TabMateriales.Cursor = Cursors.Arrow
    End Sub

    'Boton Agregar Material.
    Private Sub Btn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Agregar.Click
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
            MessageBox.Show("Debe ingresar una Descripcion.", "Administración de Materiales", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_descripcion.Focus()
        Else

            'Cambio el cursor a "WAIT"
            TabMateriales.Cursor = Cursors.WaitCursor

            Try
                'ejecuto el sp_AltaColores.
                MessageBox.Show(NMateriales.AltaMaterial(descrip, hab), "Administración de Materiales", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Se ha producido un error al agregar el material. Por favor, intente más tarde.", "Administración de Materiales", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            'Cambio el cursor a "NORMAL"
            TabMateriales.Cursor = Cursors.Arrow

            'seteo los controles en cero.
            txt_descripcion.Clear()
            chk_Habilitado.Checked = False
        End If
    End Sub

    'Boton Modificar Material.
    Private Sub Btn_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Modificar.Click
        Dim descrip As String
        Dim hab As Integer

        'Seteo las variables.
        descrip = Trim(txt_Descripcion_mod.Text)
        If chk_Habilitado_mod.Checked Then
            hab = 1
        Else
            hab = 0
        End If

        If descrip = "" Then
            'si no completo la descripcion, muestro un msg de error.
            MessageBox.Show("Debe ingresar una Descripcion.", "Administración de Materiales", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_Descripcion_mod.Focus()
        Else
            Dim Result As DialogResult
            Result = MessageBox.Show("¿Está seguro que desea modificar el Material?", "Administración de Materiales", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Result = System.Windows.Forms.DialogResult.Yes Then 'Si acepta modificar el item

                'lleno la entidad Materiales
                EMateriales.Descripcion = descrip
                EMateriales.Habilitado = hab

                Try
                    'ejecuto el sp_Material_Modificacion.
                    MessageBox.Show(NMateriales.ModificacionMaterial(EMateriales), "Administración de Materiales", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Se ha producido un error al modificar el material. Por favor, intente más tarde.", "Administración de Materiales", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

                'seteo los controles en cero.
                chk_Habilitado_mod.Checked = False
                txt_Descripcion_mod.Clear()
                txt_Descripcion_mod.Focus()

                'refresco el datagrid de Materiales
                If (NMateriales.ListadoMaterialesCompleto().Tables.Count <> 0) Then
                    DG_Buscador.DataSource = NMateriales.ListadoMaterialesCompleto().Tables(0)
                    DG_Buscador.Refresh()
                End If
            End If
        End If
    End Sub

    'Cuando hace dobleclick en el datagrid.
    Private Sub DG_Materiales_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Materiales.CellDoubleClick
        Dim id_Material As Integer = 0
        Dim dsMaterial As DataSet

        If DG_Materiales.SelectedRows.Count > 0 Then
            If e.RowIndex >= 0 Then
                id_Material = DG_Materiales.Rows(e.RowIndex).Cells("id_Material").Value()
                EMateriales.id_Material = id_Material

                'lleno la entidad colores
                dsMaterial = NMateriales.ConsultarMaterial(id_Material)

                'lleno los controls del tab_modificacion
                txt_Descripcion_mod.Text = dsMaterial.Tables(0).Rows(0).Item("Descripcion").ToString

                If dsMaterial.Tables(0).Rows(0).Item("Habilitado").ToString = "1" Then
                    chk_Habilitado_mod.Checked = True
                Else
                    chk_Habilitado_mod.Checked = False
                End If

                'hago foco en el tab_modificacion 
                TabMateriales.SelectedIndex = 2
                DG_Buscador.Rows(1).Cells(0).Selected = False
                DG_Buscador.Rows(e.RowIndex).Cells(0).Selected = True
            End If
        End If
    End Sub

    'Valido que se complete el nombre del color. - ALTA
    Private Sub txt_Descripcion_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_descripcion.Validating
        If txt_descripcion.Text = "" Then
            ErrorMaterial.SetError(txt_descripcion, "Debe completar la descripcion del material.")
        Else
            ErrorMaterial.SetError(txt_descripcion, Nothing)
        End If
    End Sub

    'Cuando cambia el tab.
    Private Sub TabMateriales_Selected(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabMateriales.Selected
        'Cambio el cursor a "WAIT"
        TabMateriales.Cursor = Cursors.WaitCursor

        'Actualizo el datagrid si se selecciona el tab del listado o el tab de modificacion
        If TabMateriales.SelectedIndex = 0 Then 'LISTADO
            'refresco el datagrid de Materiales
            If (NMateriales.ListadoMaterialesCompleto().Tables.Count <> 0) Then
                DG_Materiales.DataSource = NMateriales.ListadoMaterialesCompleto().Tables(0)
                DG_Materiales.Refresh()
            End If
            'Limpio el Formulario
            LimpiarForm()
        ElseIf TabMateriales.SelectedIndex = 1 Then 'ALTA
            'Limpio el Formulario
            LimpiarForm()
            txt_descripcion.Focus()
        ElseIf TabMateriales.SelectedIndex = 2 Then 'MODIFICACION
            'refresco el datagrid de Materiales
            If (NMateriales.ListadoMaterialesCompleto().Tables.Count <> 0) Then
                DG_Buscador.DataSource = NMateriales.ListadoMaterialesCompleto().Tables(0)
                DG_Buscador.Refresh()
            End If
        End If

        'Cambio el cursor a "WAIT"
        TabMateriales.Cursor = Cursors.Arrow
    End Sub

    'A medida que va ingresando su busqueda, va filtrando.
    Private Sub txt_buscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_buscar.TextChanged
        Dim descrip As String
        Dim dv As DataView = NMateriales.ListadoMateriales().Tables(0).DefaultView

        'Seteo las variables.
        descrip = Trim(txt_buscar.Text.ToLower)

        If descrip = "" Then
            ErrorMaterial.SetError(txt_buscar, "Debe completar el campo de busqueda.")
        Else
            ErrorMaterial.SetError(txt_buscar, Nothing)
            'filtro el dataset por la descripcion que se va ingresando
            dv.RowFilter = "Descripcion LIKE '%" + descrip + "%'"
        End If

        'actualizo el datagrid
        DG_Buscador.DataSource = dv
        DG_Buscador.Refresh()
    End Sub

    'Al hacer click en una celda del datagrid buscador.
    Private Sub DG_Buscador_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Buscador.CellClick
        Dim id_Material As Integer = 0
        Dim dsMaterial As DataSet

        If DG_Buscador.SelectedRows.Count > 0 Then
            If e.RowIndex >= 0 Then
                id_Material = DG_Buscador.Rows(e.RowIndex).Cells("id_Material_bus").Value()
                EMateriales.id_Material = id_Material

                'lleno la entidad materiales
                dsMaterial = NMateriales.ConsultarMaterial(id_Material)

                'lleno los controls del tab_modificacion
                txt_Descripcion_mod.Text = dsMaterial.Tables(0).Rows(0).Item("Descripcion").ToString

                If dsMaterial.Tables(0).Rows(0).Item("Habilitado").ToString = "1" Then
                    chk_Habilitado_mod.Checked = True
                Else
                    chk_Habilitado_mod.Checked = False
                End If

                'hago foco en el tab_modificacion 
                TabMateriales.SelectedIndex = 2
            End If
        End If
    End Sub

    'Al hacer click en el datagrid buscador...
    Private Sub DG_Buscador_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Buscador.CellContentClick

        If DG_Buscador.Columns(e.ColumnIndex).Name = "Eliminar_bus" Then 'Si se hace click en el boton de la fila.
            Dim Result As DialogResult
            Result = MessageBox.Show("¿Está seguro que desea eliminar el material?", "Administración de Materiales", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Result = System.Windows.Forms.DialogResult.Yes Then 'Si acepta eliminar el item
                Dim id_Material As Integer = DG_Buscador.Rows(e.RowIndex).Cells("id_Material_bus").Value

                If id_Material = 0 Then
                    'si no completo la descripcion, muestro un msg de error.
                    MessageBox.Show("No se puede eliminar el material.", "Administración de Materiales", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    'ejecuto el sp_Materiales_Eliminar.
                    MessageBox.Show(NMateriales.EliminarMaterial(id_Material), "Administración de Materiales", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    'refresco el datagrid de Materiales
                    If (NMateriales.ListadoMaterialesCompleto().Tables.Count <> 0) Then
                        DG_Buscador.DataSource = NMateriales.ListadoMaterialesCompleto().Tables(0)
                        DG_Buscador.Refresh()
                    End If
                End If
            End If
        End If
    End Sub

    'Al hacer click en el datagrid Materiales...
    Private Sub DG_Colores_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Materiales.CellContentClick
        If DG_Materiales.Columns(e.ColumnIndex).Name = "Eliminar" Then 'Si se hace click en el boton "eliminar" de la fila.
            Dim Result As DialogResult
            Result = MessageBox.Show("¿Está seguro que desea eliminar el material?", "Administración de Materiales", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Result = System.Windows.Forms.DialogResult.Yes Then 'Si acepta eliminar el item
                Dim id_Material As Integer = DG_Materiales.Rows(e.RowIndex).Cells("id_Material").Value
                If id_Material = 0 Then
                    'si no completo la descripcion, muestro un msg de error.
                    MessageBox.Show("No se puede eliminar el material.", "Administración de Materiales", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    'ejecuto el sp_EliminarColores.
                    MessageBox.Show(NMateriales.EliminarMaterial(id_Material), "Administración de Materiales", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    'refresco el datagrid de Materiales
                    If (NMateriales.ListadoMaterialesCompleto().Tables.Count <> 0) Then
                        DG_Materiales.DataSource = NMateriales.ListadoMaterialesCompleto().Tables(0)
                        DG_Materiales.Refresh()
                    End If
                End If
            End If
        ElseIf DG_Materiales.Columns(e.ColumnIndex).Name = "Modificar" Then 'Si se hace click en el boton "modificar" de la fila.
            Dim id_Material As Integer = DG_Materiales.Rows(e.RowIndex).Cells("id_Material").Value()
            Dim dsMaterial As DataSet

            EMateriales.id_Material = id_Material

            'lleno la entidad materiales
            dsMaterial = NMateriales.ConsultarMaterial(id_Material)

            'lleno los controls del tab_modificacion
            txt_Descripcion_mod.Text = dsMaterial.Tables(0).Rows(0).Item("Descripcion").ToString

            If dsMaterial.Tables(0).Rows(0).Item("Habilitado").ToString = "1" Then
                chk_Habilitado_mod.Checked = True
            Else
                chk_Habilitado_mod.Checked = False
            End If

            'hago foco en el tab_modificacion 
            TabMateriales.SelectedIndex = 2
        End If

    End Sub

    'Al hacer click en el boton buscar.
    Private Sub Btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Buscar.Click
        Dim descrip As String
        Dim dv As DataView = NMateriales.ListadoMaterialesCompleto().Tables(0).DefaultView

        'Seteo las variables.
        descrip = Trim(txt_buscar.Text.ToLower)

        If descrip = "" Then
            ErrorMaterial.SetError(txt_buscar, "Debe completar el campo de busqueda.")
        Else
            ErrorMaterial.SetError(txt_buscar, Nothing)
            'filtro el dataset por la descripcion que se va ingresando
            dv.RowFilter = "Descripcion LIKE '%" + descrip + "%'"
        End If
        'actualizo el datagrid
        DG_Buscador.DataSource = dv
        DG_Buscador.Refresh()
    End Sub

    'Funcion Limpiar
    Public Sub LimpiarForm()
        'seteo los controles en cero.
        txt_buscar.Clear()
        txt_descripcion.Clear()
        ErrorMaterial.Clear()
        chk_Habilitado.Checked = True
        chk_Habilitado_mod.Checked = False
        txt_Descripcion_mod.Clear()
    End Sub

End Class