Public Class frmAromas
    Dim NAromas As New Negocio.NegAromas
    Dim EAromas As New Entidades.Aromas

    'Load del Formulario.
    Private Sub frmAromas_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Cambio el cursor a "WAIT"
        TabAromas.Cursor = Cursors.WaitCursor

        'seteo el font a 8px
        DG_Aromas.AlternatingRowsDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DG_Aromas.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DG_Aromas.RowHeadersDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DG_Aromas.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        'seteo las imagenes
        Dim ListaImagenes = New ImageList
        ListaImagenes.ImageSize = New Size(32, 32)
        ListaImagenes.TransparentColor = Color.Blue
        ListaImagenes.ColorDepth = ColorDepth.Depth32Bit

        ListaImagenes.Images.Add(My.Resources.Recursos.materiales)
        ListaImagenes.Images.Add(My.Resources.Recursos.IconoADD)
        ListaImagenes.Images.Add(My.Resources.Recursos.Lapiz)

        TabAromas.ImageList = ListaImagenes

        'icono de materiales
        TbListado.ImageIndex = 0
        'icono de alta
        TbAlta.ImageIndex = 1
        'icono de edicion
        TbMod.ImageIndex = 2

        'Cargo el listado de Aromas
        If (NAromas.ListadoAromasCompleto().Tables.Count <> 0) Then
            DG_Aromas.DataSource = NAromas.ListadoAromasCompleto().Tables(0)
            DG_Aromas.Refresh()
        End If

        'agregado para probar el funcionamiento de patentes
        Dim objusuario As New Negocio.Usuario
        '207 visualiza Aroma - si llego aca puede visualizarlos
        '205 crear Aroma
        If (objusuario.EsPatenteValida(205, VariablesGlobales.Patentes)) Then
        Else
            TabAromas.TabPages.Remove(Me.TbAlta)
        End If
        '206 modificar Aroma
        If (objusuario.EsPatenteValida(206, VariablesGlobales.Patentes)) Then
        Else
            TabAromas.TabPages.Remove(Me.TbMod)
            DG_Aromas.Columns(1).Visible = False
        End If
        '208 eliminar Aroma
        If (objusuario.EsPatenteValida(208, VariablesGlobales.Patentes)) Then
        Else
            TabAromas.TabPages.Remove(Me.TbMod)
            DG_Aromas.Columns(0).Visible = False
            DG_Buscador.Columns("Eliminar_bus").Visible = False
        End If

        'Cambio el cursor a NORMAL.
        TabAromas.Cursor = Cursors.Arrow
    End Sub

    'Valido que se complete el nombre del aroma. - ALTA
    Private Sub txt_Descripcion_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If txt_descripcion.Text = "" Then
            ErrorAroma.SetError(txt_descripcion, "Debe completar la descripcion del aroma.")
        Else
            ErrorAroma.SetError(txt_descripcion, Nothing)
        End If
    End Sub

    Private Sub TabAromas_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabAromas.LostFocus

        If TabAromas.SelectedIndex = 0 Then 'LISTADO
        ElseIf TabAromas.SelectedIndex = 1 Then 'ALTA
        ElseIf TabAromas.SelectedIndex = 2 Then 'MODIFICACION

        End If
    End Sub

    'Cuando cambia el tab.
    Private Sub TabAromas_Selected(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabAromas.Selected
        'Cambio el cursor a "WAIT"
        TabAromas.Cursor = Cursors.WaitCursor

        'Actualizo el datagrid si se selecciona el tab del listado o el tab de modificacion
        If TabAromas.SelectedIndex = 0 Then 'LISTADO
            'Limpio el Formulario
            LimpiarForm()
            'Cargo el listado de Aromas
            If (NAromas.ListadoAromasCompleto().Tables.Count <> 0) Then
                DG_Aromas.DataSource = NAromas.ListadoAromasCompleto().Tables(0)
                DG_Aromas.Refresh()
            End If
        ElseIf TabAromas.SelectedIndex = 1 Then 'ALTA
            'Limpio el Formulario
            LimpiarForm()
            txt_descripcion.Focus()
        ElseIf TabAromas.SelectedIndex = 2 Then 'MODIFICACION
            'Cargo el listado de Aromas
            If (NAromas.ListadoAromasCompleto().Tables.Count <> 0) Then
                DG_Buscador.DataSource = NAromas.ListadoAromasCompleto().Tables(0)
                DG_Buscador.Refresh()
            End If
        End If

        'Cambio el cursor a "WAIT"
        TabAromas.Cursor = Cursors.Arrow
    End Sub

    'A medida que va ingresando su busqueda, va filtrando.
    Private Sub txt_buscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Aroma.TextChanged
        Dim descrip As String
        Dim dv As DataView = NAromas.ListadoAromas().Tables(0).DefaultView

        'Seteo las variables.
        descrip = Trim(txt_Aroma.Text.ToLower)

        If descrip = "" Then
            'ErrorAroma.SetError(txt_Aroma, "Debe completar el campo de busqueda.")
        Else
            'ErrorAroma.SetError(txt_Aroma, Nothing)
            'filtro el dataset por la descripcion que se va ingresando
            dv.RowFilter = "Descripcion LIKE '%" + descrip + "%'"
        End If

        'actualizo el datagrid
        DG_Buscador.DataSource = dv
        DG_Buscador.Refresh()
    End Sub

    'Al hacer click en una celda del datagrid buscador.
    Private Sub DG_Buscador_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Buscador.CellClick
        Dim id_Aroma As Integer = 0
        Dim dsAroma As DataSet

        If DG_Buscador.SelectedRows.Count > 0 Then
            If e.RowIndex >= 0 Then
                id_Aroma = DG_Buscador.Rows(e.RowIndex).Cells("id_Aroma_bus").Value()
                EAromas.id_Aroma = id_Aroma

                'lleno la entidad materiales
                dsAroma = NAromas.ConsultarAroma(id_Aroma)

                'lleno los controls del tab_modificacion
                txt_Modificar.Text = dsAroma.Tables(0).Rows(0).Item("Descripcion").ToString

                If dsAroma.Tables(0).Rows(0).Item("Habilitado").ToString = "1" Then
                    chk_Habilitado_mod.Checked = True
                Else
                    chk_Habilitado_mod.Checked = False
                End If

                'hago foco en el tab_modificacion 
                '   TabAromas.SelectedIndex = 2
            End If
        End If
    End Sub

    'Al hacer click en el datagrid buscador...
    Private Sub DG_Buscador_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Buscador.CellContentClick

        If DG_Buscador.Columns(e.ColumnIndex).Name = "Eliminar_bus" Then 'Si se hace click en el boton de la fila.
            Dim Result As DialogResult
            Result = MessageBox.Show("¿Está seguro que desea eliminar el aroma?", "Administración de Aromas", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Result = System.Windows.Forms.DialogResult.Yes Then 'Si acepta eliminar el item
                Dim id_Aroma As Integer = DG_Buscador.Rows(e.RowIndex).Cells("id_Aroma_Bus").Value

                If id_Aroma = 0 Then
                    'si no completo la descripcion, muestro un msg de error.
                    MessageBox.Show("No se puede eliminar el aroma.", "Administración de Aromas", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    'ejecuto el sp_Aromas_Eliminar.
                    MessageBox.Show(NAromas.EliminarAroma(id_Aroma), "Administración de Aromas", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    'Cargo el listado de Aromas
                    If (NAromas.ListadoAromasCompleto().Tables.Count <> 0) Then
                        DG_Buscador.DataSource = NAromas.ListadoAromasCompleto().Tables(0)
                        DG_Buscador.Refresh()
                    End If
                End If
            End If
        End If
    End Sub

    'Al hacer click en el datagrid aromas...
    Private Sub DG_Aromas_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Aromas.CellContentClick
        If DG_Aromas.Columns(e.ColumnIndex).Name = "Eliminar" Then 'Si se hace click en el boton "eliminar" de la fila.
            Dim Result As DialogResult
            Result = MessageBox.Show("¿Está seguro que desea eliminar el aroma?", "Administración de Aromas", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Result = System.Windows.Forms.DialogResult.Yes Then 'Si acepta eliminar el item
                Dim id_Aroma As Integer = DG_Aromas.Rows(e.RowIndex).Cells("id_Aroma").Value
                If id_Aroma = 0 Then
                    'si no completo la descripcion, muestro un msg de error.
                    MessageBox.Show("No se puede eliminar el aroma.", "Administración de Aromas", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    'ejecuto el sp_EliminarAroma.
                    MessageBox.Show(NAromas.EliminarAroma(id_Aroma), "Administración de Aromas", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    'refresco el datagrid
                    'Cargo el listado de Aromas
                    If (NAromas.ListadoAromasCompleto().Tables.Count <> 0) Then
                        DG_Aromas.DataSource = NAromas.ListadoAromasCompleto().Tables(0)
                        DG_Aromas.Refresh()
                    End If
                End If
            End If
        ElseIf DG_Aromas.Columns(e.ColumnIndex).Name = "Modificar" Then 'Si se hace click en el boton "modificar" de la fila.
            Dim id_Aroma As Integer = DG_Aromas.Rows(e.RowIndex).Cells("id_Aroma").Value()
            Dim dsAromas As DataSet

            EAromas.id_Aroma = id_Aroma

            'lleno la entidad aroma
            dsAromas = NAromas.ConsultarAroma(id_Aroma)

            'lleno los controls del tab_modificacion
            txt_Modificar.Text = dsAromas.Tables(0).Rows(0).Item("Descripcion").ToString

            If dsAromas.Tables(0).Rows(0).Item("Habilitado").ToString = "1" Then
                chk_Habilitado_mod.Checked = True
            Else
                chk_Habilitado_mod.Checked = False
            End If

            'hago foco en el tab_modificacion 
            TabAromas.SelectedIndex = 2
        End If

    End Sub

    'Al hacer click en el boton buscar.
    Private Sub Btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Buscar.Click
        Dim descrip As String
        Dim dv As DataView = NAromas.ListadoAromasCompleto().Tables(0).DefaultView

        'Seteo las variables.
        descrip = Trim(txt_Aroma.Text.ToLower)

        If descrip = "" Then
            ErrorAroma.SetError(txt_Aroma, "Debe completar el campo de busqueda.")
        Else
            ErrorAroma.SetError(txt_Aroma, Nothing)
            'filtro el dataset por la descripcion que se va ingresando
            dv.RowFilter = "Descripcion LIKE '%" + descrip + "%'"
        End If

        'actualizo el datagrid
        DG_Buscador.DataSource = dv
        DG_Buscador.Refresh()
    End Sub

    'Boton Agregar Aroma.
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
            MessageBox.Show("Debe ingresar una Descripcion.", "Administración de Aromas", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_descripcion.Focus()
        Else

            'Cambio el cursor a "WAIT"
            TabAromas.Cursor = Cursors.WaitCursor

            Try
                'ejecuto el sp_AltaAroma
                MessageBox.Show(NAromas.AltaAroma(descrip, hab), "Administración de Aromas", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Se ha producido un error al agregar el material. Por favor, intente más tarde.", "Administración de Aromas", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            'Cambio el cursor a "NORMAL"
            TabAromas.Cursor = Cursors.Arrow

            'seteo los controles en cero.
            txt_descripcion.Clear()
            chk_Habilitado.Checked = False
        End If
    End Sub

    'Boton Modificar Aroma.
    Private Sub Btn_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Modificar.Click
        Dim descrip As String
        Dim hab As Integer

        'Seteo las variables.
        descrip = Trim(txt_Modificar.Text)
        If chk_Habilitado_mod.Checked Then
            hab = 1
        Else
            hab = 0
        End If

        If descrip = "" Then
            'si no completo la descripcion, muestro un msg de error.
            MessageBox.Show("Debe ingresar una Descripcion.", "Administración de Aromas", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_Aroma.Focus()
        Else
            Dim Result As DialogResult
            Result = MessageBox.Show("¿Está seguro que desea modificar el Aroma?", "Administración de Aromas", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Result = System.Windows.Forms.DialogResult.Yes Then 'Si acepta modificar el item

                'lleno la entidad Aromas
                EAromas.Descripcion = descrip
                EAromas.Habilitado = hab

                Try
                    'ejecuto el sp_Material_Modificacion.
                    MessageBox.Show(NAromas.ModificacionAroma(EAromas), "Administración de Aromas", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Se ha producido un error al modificar el material. Por favor, intente más tarde.", "Administración de Aromas", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

                'seteo los controles en cero.
                chk_Habilitado_mod.Checked = False
                txt_Aroma.Focus()

                'refresco el datagrid
                'Cargo el listado de Aromas
                If (NAromas.ListadoAromasCompleto().Tables.Count <> 0) Then
                    DG_Buscador.DataSource = NAromas.ListadoAromasCompleto().Tables(0)
                    DG_Buscador.Refresh()
                End If
            End If
        End If
    End Sub

    'Cuando hace dobleclick en el datagrid.
    Private Sub DG_Aromas_CellDoubleClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Aromas.CellDoubleClick
        Dim id_Aroma As Integer = 0
        Dim dsAroma As DataSet

        If DG_Aromas.SelectedRows.Count > 0 Then
            If e.RowIndex >= 0 Then
                id_Aroma = DG_Aromas.Rows(e.RowIndex).Cells("id_Aroma").Value()
                EAromas.id_Aroma = id_Aroma

                'lleno la entidad aromas
                dsAroma = NAromas.ConsultarAroma(id_Aroma)

                'lleno los controls del tab_modificacion
                txt_Modificar.Text = dsAroma.Tables(0).Rows(0).Item("Descripcion").ToString

                If dsAroma.Tables(0).Rows(0).Item("Habilitado").ToString = "1" Then
                    chk_Habilitado_mod.Checked = True
                Else
                    chk_Habilitado_mod.Checked = False
                End If

                'hago foco en el tab_modificacion 
                TabAromas.SelectedIndex = 2
                DG_Buscador.Rows(1).Cells(0).Selected = False
                DG_Buscador.Rows(e.RowIndex).Cells(0).Selected = True
            End If
        End If
    End Sub

    'Funcion Limpiar
    Public Sub LimpiarForm()
        'seteo los controles en cero.
        txt_Aroma.Clear()
        txt_descripcion.Clear()
        ErrorAroma.Clear()
        chk_Habilitado.Checked = True
        chk_Habilitado_mod.Checked = False
        txt_Aroma.Clear()
        txt_Modificar.Clear()
    End Sub
End Class