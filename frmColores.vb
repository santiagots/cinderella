Public Class frmColores
    Dim NColores As New Negocio.NegColores
    Dim EColores As New Entidades.Colores

    'Boton Agregar.
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
            MessageBox.Show("Debe ingresar una Descripcion.", "Administración de Colores", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_descripcion.Focus()
        Else
            'Cambio el cursor a "WAIT"
            TabColores.Cursor = Cursors.WaitCursor

            Try
                'ejecuto el sp_AltaColores.
                MessageBox.Show(NColores.AltaColores(descrip, hab), "Administración de Colores", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Se ha producido un error al agregar el color. Por favor, intente más tarde.", "Administración de Colores", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            'seteo los controles en cero.
            txt_descripcion.Clear()
            chk_Habilitado.Checked = False

            'Cambio el cursor a "NORMAL"
            TabColores.Cursor = Cursors.Arrow
        End If
    End Sub

    'Load del formulario.
    Private Sub frmColores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Cambio el cursor a "WAIT"
        TabColores.Cursor = Cursors.WaitCursor

        'seteo el font a 8px
        DG_Colores.AlternatingRowsDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DG_Colores.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DG_Colores.RowHeadersDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DG_Colores.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        'seteo las imagenes
        Dim ListaImagenes = New ImageList
        ListaImagenes.ImageSize = New Size(32, 32)
        ListaImagenes.TransparentColor = Color.Blue
        ListaImagenes.ColorDepth = ColorDepth.Depth32Bit

        ListaImagenes.Images.Add(My.Resources.Recursos.Colores)
        ListaImagenes.Images.Add(My.Resources.Recursos.IconoADD)
        ListaImagenes.Images.Add(My.Resources.Recursos.Lapiz)

        TabColores.ImageList = ListaImagenes

        'icono de colores
        TbListado.ImageIndex = 0
        'icono de alta
        TbAlta.ImageIndex = 1
        'icono de edicion
        TbMod.ImageIndex = 2

        'Cargo el listado de Colores
        If (NColores.ListadoColores().Tables.Count <> 0) Then
            DG_Colores.DataSource = NColores.ListadoColores().Tables(0)
            DG_Colores.Refresh()
        End If

        'agregado para probar el funcionamiento de patentes
        Dim objusuario As New Negocio.Usuario
        '151 visualiza colores - si llego aca puede visualizarlos
        '149 crea color
        'If (objusuario.EsPatenteValida(149, VariablesGlobales.Patentes)) Then
        'Else
        '    TabColores.TabPages.Remove(Me.TbAlta)
        'End If
        ''150 modifica color
        'If (objusuario.EsPatenteValida(150, VariablesGlobales.Patentes)) Then
        'Else
        '    TabColores.TabPages.Remove(Me.TbMod)
        '    DG_Colores.Columns("Modificar").Visible = False
        'End If
        ''152 elimina color
        'If (objusuario.EsPatenteValida(152, VariablesGlobales.Patentes)) Then
        'Else
        '    TabColores.TabPages.Remove(Me.TbMod)
        '    DG_Colores.Columns("Eliminar").Visible = False
        '    DG_Buscador.Columns("Eliminar_bus").Visible = False
        'End If

        'Cambio el cursor a NORMAL.
        TabColores.Cursor = Cursors.Arrow
    End Sub

    'Valido que se complete el nombre del color. - ALTA
    Private Sub txt_Descripcion_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_descripcion.Validating
        If txt_descripcion.Text = "" Then
            ErrorColores.SetError(txt_descripcion, "Debe completar la descripcion del color.")
        Else
            ErrorColores.SetError(txt_descripcion, Nothing)
        End If
    End Sub

    'Caundo cambia el tab.
    Private Sub TabColores_Selected(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabColores.Selected
        'Cambio el cursor a "WAIT"
        TabColores.Cursor = Cursors.WaitCursor

        'Actualizo el datagrid si se selecciona el tab del listado o el tab de modificacion
        If TabColores.SelectedIndex = 0 Then 'LISTADO
            'Limpio el Formulario
            LimpiarForm()
            'Cargo el listado de Colores
            If (NColores.ListadoColores().Tables.Count <> 0) Then
                DG_Colores.DataSource = NColores.ListadoColores().Tables(0)
                DG_Colores.Refresh()
            End If
        ElseIf TabColores.SelectedIndex = 1 Then 'ALTA
            'Limpio el Formulario
            LimpiarForm()
            txt_descripcion.Focus()
        ElseIf TabColores.SelectedIndex = 2 Then 'MODIFICACION
            'Cargo el listado de Colores
            If (NColores.ListadoColores().Tables.Count <> 0) Then
                DG_Buscador.DataSource = NColores.ListadoColores().Tables(0)
                DG_Buscador.Refresh()
            End If
        End If

        'Cambio el cursor a "Normal"
        TabColores.Cursor = Cursors.Arrow
    End Sub

    'Funcion Limpiar
    Public Sub LimpiarForm()
        'seteo los controles en cero.
        txt_buscar.Clear()
        txt_descripcion.Clear()
        ErrorColores.Clear()
        chk_Habilitado.Checked = True
        chk_Habilitado_mod.Checked = False
        txt_Modificar.Clear()
    End Sub

    'Cuando hace dobleclick en el datagrid.
    Private Sub DG_Colores_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Colores.CellDoubleClick
        Dim id_Color As Integer = 0
        Dim dsColor As DataSet

        If DG_Colores.SelectedRows.Count > 0 Then
            If e.RowIndex >= 0 Then
                id_Color = DG_Colores.Rows(e.RowIndex).Cells("id_Color").Value()
                EColores.id_Color = id_Color

                'lleno la entidad colores
                dsColor = NColores.ConsultarColor(id_Color)

                'lleno los controls del tab_modificacion
                txt_Modificar.Text = dsColor.Tables(0).Rows(0).Item("Descripcion").ToString

                If dsColor.Tables(0).Rows(0).Item("Habilitado").ToString = "1" Then
                    chk_Habilitado_mod.Checked = True
                Else
                    chk_Habilitado_mod.Checked = False
                End If

                'hago foco en el tab_modificacion 
                TabColores.SelectedIndex = 2
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
        descrip = Trim(txt_Modificar.Text)
        If chk_Habilitado_mod.Checked Then
            hab = 1
        Else
            hab = 0
        End If

        If descrip = "" Then
            'si no completo la descripcion, muestro un msg de error.
            MessageBox.Show("Debe ingresar una Descripcion.", "Administración de Colores", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_Modificar.Focus()
        Else
            Dim Result As DialogResult
            Result = MessageBox.Show("¿Está seguro que desea modificar el Color?", "Administración de Colores", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Result = System.Windows.Forms.DialogResult.Yes Then 'Si acepta modificar el item

                'Cambio el cursor a "WAIT"
                TabColores.Cursor = Cursors.WaitCursor

                'lleno la entidad colores
                EColores.Descripcion = descrip
                EColores.Habilitado = hab

                Try
                    'ejecuto el sp_AltaColores.
                    MessageBox.Show(NColores.ModificacionColores(EColores), "Administración de Colores", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Se ha producido un error al modificar el color. Por favor, intente más tarde.", "Administración de Colores", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

                'refresco el datagrid
                DG_Buscador.DataSource = NColores.ListadoColores().Tables(0)
                DG_Buscador.Refresh()

                'seteo los controles en cero.
                chk_Habilitado_mod.Checked = False
                txt_Modificar.Focus()

                'Cambio el cursor a "NORMAL"
                TabColores.Cursor = Cursors.Arrow

            End If
        End If
    End Sub

    'A medida que va ingresando su busqueda, va filtrando.
    Private Sub txt_buscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_buscar.TextChanged
        Dim descrip As String
        Dim dv As DataView = NColores.ListadoColores().Tables(0).DefaultView

        'Seteo las variables.
        descrip = Trim(txt_buscar.Text.ToLower)

        If descrip = "" Then
            ErrorColores.SetError(txt_buscar, "Debe completar el campo de busqueda.")
        Else
            ErrorColores.SetError(txt_buscar, Nothing)
            'filtro el dataset por la descripcion que se va ingresando
            dv.RowFilter = "Descripcion LIKE '%" + descrip + "%'"
        End If

        'actualizo el datagrid
        DG_Buscador.DataSource = dv
        DG_Buscador.Refresh()
    End Sub

    'Al hacer click en una celda del datagrid buscador.
    Private Sub DG_Buscador_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Buscador.CellClick
        Dim id_Color As Integer = 0
        Dim dsColor As DataSet

        If DG_Buscador.SelectedRows.Count > 0 Then
            If e.RowIndex >= 0 Then
                id_Color = DG_Buscador.Rows(e.RowIndex).Cells("id_Color_bus").Value()
                EColores.id_Color = id_Color

                'lleno la entidad colores
                dsColor = NColores.ConsultarColor(id_Color)

                'lleno los controls del tab_modificacion
                txt_Modificar.Text = dsColor.Tables(0).Rows(0).Item("Descripcion").ToString

                If dsColor.Tables(0).Rows(0).Item("Habilitado").ToString = "1" Then
                    chk_Habilitado_mod.Checked = True
                Else
                    chk_Habilitado_mod.Checked = False
                End If

                'hago foco en el tab_modificacion 
                TabColores.SelectedIndex = 2
            End If
        End If
    End Sub

    'Al hacer click en el datagrid buscador...
    Private Sub DG_Buscador_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Buscador.CellContentClick

        If DG_Buscador.Columns(e.ColumnIndex).Name = "Eliminar_bus" Then 'Si se hace click en el boton de la fila.
            Dim Result As DialogResult
            Result = MessageBox.Show("¿Está seguro que desea eliminar el color?", "Colores", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Result = System.Windows.Forms.DialogResult.Yes Then 'Si acepta eliminar el item
                Dim id_Color As Integer = DG_Buscador.Rows(e.RowIndex).Cells("id_Color_bus").Value

                If id_Color = 0 Then
                    'si no completo la descripcion, muestro un msg de error.
                    MessageBox.Show("No se puede eliminar el color.", "Colores", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    'ejecuto el sp_EliminarColores.
                    MessageBox.Show(NColores.EliminarColores(id_Color), "Colores", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    'refresco el datagrid
                    DG_Buscador.DataSource = NColores.ListadoColores().Tables(0)
                    DG_Buscador.Refresh()
                End If
            End If
        End If
    End Sub

    'Al hacer click en el datagrid colores...
    Private Sub DG_Colores_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Colores.CellContentClick
        If DG_Colores.Columns(e.ColumnIndex).Name = "Eliminar" Then 'Si se hace click en el boton "eliminar" de la fila.
            Dim Result As DialogResult
            Result = MessageBox.Show("¿Está seguro que desea eliminar el color?", "Colores", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Result = System.Windows.Forms.DialogResult.Yes Then 'Si acepta eliminar el item
                Dim id_Color As Integer = DG_Colores.Rows(e.RowIndex).Cells("id_Color").Value
                If id_Color = 0 Then
                    'si no completo la descripcion, muestro un msg de error.
                    MessageBox.Show("No se puede eliminar el color.", "Colores", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    'ejecuto el sp_EliminarColores.
                    MessageBox.Show(NColores.EliminarColores(id_Color), "Colores", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    'refresco el datagrid
                    DG_Colores.DataSource = NColores.ListadoColores().Tables(0)
                    DG_Colores.Refresh()
                End If
            End If
        ElseIf DG_Colores.Columns(e.ColumnIndex).Name = "Modificar" Then 'Si se hace click en el boton "modificar" de la fila.
            Dim id_Color As Integer = DG_Colores.Rows(e.RowIndex).Cells("id_Color").Value()
            Dim dsColor As DataSet

            EColores.id_Color = id_Color

            'lleno la entidad colores
            dsColor = NColores.ConsultarColor(id_Color)

            'lleno los controls del tab_modificacion
            txt_Modificar.Text = dsColor.Tables(0).Rows(0).Item("Descripcion").ToString

            If dsColor.Tables(0).Rows(0).Item("Habilitado").ToString = "1" Then
                chk_Habilitado_mod.Checked = True
            Else
                chk_Habilitado_mod.Checked = False
            End If

            'hago foco en el tab_modificacion 
            TabColores.SelectedIndex = 2
        End If

    End Sub

    'Al hacer click en el boton buscar.
    Private Sub Btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Buscar.Click
        Dim descrip As String
        Dim dv As DataView = NColores.ListadoColores().Tables(0).DefaultView

        'Seteo las variables.
        descrip = Trim(txt_buscar.Text.ToLower)

        If descrip = "" Then
            ErrorColores.SetError(txt_buscar, "Debe completar el campo de busqueda.")
        Else
            ErrorColores.SetError(txt_buscar, Nothing)
            'filtro el dataset por la descripcion que se va ingresando
            dv.RowFilter = "Descripcion LIKE '%" + descrip + "%'"
        End If
        'actualizo el datagrid
        DG_Buscador.DataSource = dv
        DG_Buscador.Refresh()
    End Sub
End Class