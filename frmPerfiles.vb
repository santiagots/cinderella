Public Class frmPerfiles
    Dim NPerfiles As New Negocio.NegPerfiles
    Dim NPatentes As New Negocio.NegPatentes
    Dim NSucursales As New Negocio.NegSucursales
    Dim EPerfiles As New Entidades.Perfiles

    'Load del formulario.
    Private Sub frmPerfiles_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            'seteo el font a 8px
            DG_Perfiles.AlternatingRowsDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DG_Perfiles.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DG_Perfiles.RowHeadersDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DG_Perfiles.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

            'seteo las imagenes
            Dim ListaImagenes = New ImageList
            ListaImagenes.ImageSize = New Size(32, 32)
            ListaImagenes.TransparentColor = Color.Blue
            ListaImagenes.ColorDepth = ColorDepth.Depth32Bit

            ListaImagenes.Images.Add(My.Resources.Recursos.Perfil)
            ListaImagenes.Images.Add(My.Resources.Recursos.IconoADD)
            ListaImagenes.Images.Add(My.Resources.Recursos.Lapiz)
            TabPerfiles.ImageList = ListaImagenes

            'icono de perfiles
            TbListado.ImageIndex = 0
            'icono de alta
            TbAlta.ImageIndex = 1
            'icono de edicion
            TbMod.ImageIndex = 2

            'Cargo el datagrid
            Dim dsPerfiles As New DataSet
            dsPerfiles = NPerfiles.ListadoPerfiles()
            If dsPerfiles.Tables(0).Rows.Count > 0 Then
                DG_Perfiles.DataSource = dsPerfiles.Tables(0)
                DG_Perfiles.Columns("id_Perfil").Visible = False
                DG_Perfiles.AutoGenerateColumns = False
                DG_Perfiles.ColumnHeadersVisible = True
                DG_Perfiles.Refresh()
                lbl_Msg.Visible = False
            Else
                DG_Perfiles.DataSource = Nothing
                DG_Perfiles.ColumnHeadersVisible = True
                DG_Perfiles.Refresh()
                lbl_Msg.Visible = True
            End If

            'agregado para el funcionamiento de patentes
            Dim objusuario As New Negocio.Usuario
            '155 visualiza perfiles - si llego aca puede visualizarlos
            '153 crea perfil
            If (objusuario.EsPatenteValida(153, VariablesGlobales.Patentes)) Then
            Else
                TabPerfiles.TabPages.Remove(Me.TbAlta)
            End If
            '154 modifica perfil
            If (objusuario.EsPatenteValida(154, VariablesGlobales.Patentes)) Then
            Else
                TabPerfiles.TabPages.Remove(Me.TbMod)
                DG_Perfiles.Columns(1).Visible = False
            End If
            '156 elimina perfil
            If (objusuario.EsPatenteValida(156, VariablesGlobales.Patentes)) Then
            Else
                TabPerfiles.TabPages.Remove(Me.TbMod)
                DG_Perfiles.Columns(0).Visible = False
                DG_Perfiles.Columns("Eliminar_bus").Visible = False
            End If

            'Cambio el cursor a NORMAL.
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha producido un error al listar los perfiles.", "Administración de Perfiles", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'Solapas.
    Private Sub TabPerfiles_Selected(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPerfiles.Selected
        'Cambio el cursor a "WAIT"
        Me.Cursor = Cursors.WaitCursor

        If TabPerfiles.SelectedIndex = 0 Then  'Actualizo el datagrid si se selecciona el tab del listado

            Dim dsPerfiles As New DataSet
            dsPerfiles = NPerfiles.ListadoPerfiles()
            If dsPerfiles.Tables(0).Rows.Count > 0 Then
                DG_Perfiles.DataSource = dsPerfiles.Tables(0)
                DG_Perfiles.Columns("id_Perfil").Visible = False
                DG_Perfiles.AutoGenerateColumns = False
                DG_Perfiles.ColumnHeadersVisible = True
                DG_Perfiles.Refresh()
                lbl_Msg.Visible = False
            Else
                DG_Perfiles.DataSource = Nothing
                DG_Perfiles.ColumnHeadersVisible = True
                DG_Perfiles.Refresh()
                lbl_Msg.Visible = True
            End If

            'seteo los controles en cero.
            chk_Habilitado_mod.Checked = False
            lbl_Perfil.Text = ""
            EPerfiles.id_Perfil = 0
            ListPatentesSelecMod.ClearSelected()
            ListPatentesSelecMod.DataSource = Nothing
            ListPatentesSelecMod.Refresh()

        ElseIf TabPerfiles.SelectedIndex = 1 Then  'Actualizo el datagrid si se selecciona el tab de Alta
            Dim ds, ds_sucursales As New DataSet
            Dim dv As DataView

            'seteo los controles en cero.
            chk_Habilitado_mod.Checked = False
            lbl_Perfil.Text = ""
            EPerfiles.id_Perfil = 0
            ListPatentesSelecMod.ClearSelected()
            ListPatentesSelecMod.DataSource = Nothing
            ListPatentesSelecMod.Items.Clear()
            ListPatentesSelecMod.Refresh()

            'Cargo el listPatentes con todas las patentes del sistema.
            ds = NPatentes.ListadoPatentes()
            ListPatentes.DataSource = ds.Tables(0)
            ListPatentes.DisplayMember = "Descripcion"
            ListPatentes.ValueMember = "id_Patente"

            'Agrego el item de "Todas las patentes"
            Dim dr As DataRow
            ds_sucursales = NSucursales.ListadoSucursales()
            dr = ds_sucursales.Tables(0).NewRow()
            dr("id_Sucursal") = "-1"
            dr("Nombre") = "Todas las Patentes"
            ds_sucursales.Tables(0).Rows.Add(dr)

            'Agrego el item de "Patentes Generales"
            dr = ds_sucursales.Tables(0).NewRow()
            dr("id_Sucursal") = "0"
            dr("Nombre") = "Patentes Generales"
            ds_sucursales.Tables(0).Rows.Add(dr)

            'Cargo El Cb_Filtros con todas las sucursales + 2 opciones adicionales
            'utilizo un dataview para reordenar el dataset
            dv = New DataView(ds_sucursales.Tables(0), "", "id_Sucursal ASC", DataViewRowState.CurrentRows)
            Cb_Filtros.DataSource = dv
            dv = Nothing
            Cb_Filtros.DisplayMember = "Nombre"
            Cb_Filtros.ValueMember = "id_Sucursal"
            Cb_Filtros.Refresh()
            txt_descripcion.Focus()

            'Deselecciono items.
            ListPatentes.SelectedItem = Nothing
            ListPatentesSelec.SelectedItem = Nothing

        ElseIf TabPerfiles.SelectedIndex = 2 Then 'Actualizo el datagrid si se selecciona el tab de Modificacion
            Dim ds, ds_sucursales As New DataSet
            Dim dv As DataView

            If EPerfiles.id_Perfil > 0 Then
                'Cargo el listPatentes con todas las patentes del sistema.
                ds = NPatentes.ListadoPatentes()
                ListPatentesMod.DataSource = ds.Tables(0)
                ListPatentesMod.DisplayMember = "Descripcion"
                ListPatentesMod.ValueMember = "id_Patente"
                ListPatentesMod.Refresh()

                'Agrego el item de "Todas las patentes"
                Dim dr As DataRow
                ds_sucursales = NSucursales.ListadoSucursales()
                dr = ds_sucursales.Tables(0).NewRow()
                dr("id_Sucursal") = "-1"
                dr("Nombre") = "Todas las Patentes"
                ds_sucursales.Tables(0).Rows.Add(dr)

                'Agrego el item de "Patentes Generales"
                dr = ds_sucursales.Tables(0).NewRow()
                dr("id_Sucursal") = "0"
                dr("Nombre") = "Patentes Generales"
                ds_sucursales.Tables(0).Rows.Add(dr)

                'Cargo El Cb_Filtros con todas las sucursales + 2 opciones adicionales
                'utilizo un dataview para reordenar el dataset
                dv = New DataView(ds_sucursales.Tables(0), "", "id_Sucursal ASC", DataViewRowState.CurrentRows)
                Cb_FiltrosMod.DataSource = dv
                dv = Nothing
                Cb_FiltrosMod.DisplayMember = "Nombre"
                Cb_FiltrosMod.ValueMember = "id_Sucursal"
                Cb_FiltrosMod.Refresh()
            Else
                MessageBox.Show("Debe seleccionar previamente un perfil.", "Perfiles", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                TabPerfiles.SelectedIndex = 0
            End If
        End If

        'Cambio el cursor a NORMAL.
        Me.Cursor = Cursors.Arrow
    End Sub

    'Boton Agregar Perfil.
    Private Sub Btn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Agregar.Click
        Dim descrip As String
        Dim hab As Integer

        'Seteo las variables.
        descrip = Trim(txt_descripcion.Text).ToLower
        If chk_Habilitado.Checked Then
            hab = 1
        Else
            hab = 0
        End If

        If descrip = "" Then
            'si no completo la descripcion, muestro un msg de error.
            MessageBox.Show("Debe ingresar una Descripcion.", "Administración de Perfiles", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_descripcion.Focus()
        ElseIf ListPatentesSelec.Items.Count < 1 Then
            'si no completo al menos un perfil, muestro un msg de error.
            MessageBox.Show("Debe seleccionar al menos una patente.", "Administración de Perfiles", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else

            'Cambio el cursor a "WAIT"
            TabPerfiles.Cursor = Cursors.WaitCursor

            'lleno la entidad perfiles
            EPerfiles.Descripcion = descrip
            EPerfiles.Habilitado = hab
            EPerfiles.Patentes = ListPatentesSelec

            Try
                'ejecuto el sp_AltaColores.
                MessageBox.Show(NPerfiles.AltaPerfiles(EPerfiles), "Administración de Perfiles", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Se ha producido un error al registrar el perfil. Por favor, intente más tarde.", "Administración de Perfiles", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
           
            'Cambio el cursor a NORMAL.
            TabPerfiles.Cursor = Cursors.Arrow

            'seteo los controles en cero.
            txt_descripcion.Clear()
            chk_Habilitado.Checked = False
            ListPatentes.DataSource = NPatentes.ListadoPatentes.Tables(0)
            ListPatentes.DisplayMember = "Descripcion"
            ListPatentes.ValueMember = "id_Patente"
            ListPatentes.Refresh()
            ListPatentesSelec.ClearSelected()
            ListPatentesSelec.DataSource = Nothing
            ListPatentesSelec.Refresh()
            txt_descripcion.Focus()
        End If
    End Sub

    'Doble click en el listado.
    Private Sub DG_Perfiles_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Perfiles.CellDoubleClick
        Dim id_Perfil As Integer = 0
        Dim dsPerfil As DataSet

        If DG_Perfiles.SelectedRows.Count > 0 Then
            If e.RowIndex >= 0 Then

                'Cambio el cursor.
                Me.Cursor = Cursors.WaitCursor

                id_Perfil = DG_Perfiles.Rows(e.RowIndex).Cells("id_Perfil").Value()
                EPerfiles.id_Perfil = id_Perfil

                'lleno la entidad colores
                dsPerfil = NPerfiles.ConsultarPerfil(id_Perfil)

                'lleno los controls del tab_modificacion
                lbl_Perfil.Text = dsPerfil.Tables(0).Rows(0).Item("Descripcion").ToString

                If dsPerfil.Tables(0).Rows(0).Item("Habilitado").ToString = "1" Then
                    chk_Habilitado_mod.Checked = True
                Else
                    chk_Habilitado_mod.Checked = False
                End If

                Dim ds_patentesperfil As New DataSet
                ds_patentesperfil = NPatentes.ListadoPatentesPerfil(id_Perfil)
                If ds_patentesperfil.Tables(0).Rows.Count > 0 Then
                    ListPatentesSelecMod.DataSource = ds_patentesperfil.Tables(0)
                    ListPatentesSelecMod.DisplayMember = "Descripcion"
                    ListPatentesSelecMod.ValueMember = "id_Patente"
                    ListPatentesSelecMod.Refresh()
                End If

                'Deselecciono items.
                ListPatentesMod.SelectedItem = Nothing
                ListPatentesSelecMod.SelectedItem = Nothing

                'Botonera No visible.
                Btn_AgregarPateMod.Visible = False
                Btn_EliminarPatMod.Visible = False

                'Cambio el cursor.
                Me.Cursor = Cursors.Arrow

                'hago foco en el tab_modificacion 
                TabPerfiles.SelectedIndex = 2
            End If
        End If
    End Sub

    'Click en el listado.
    Private Sub DG_Perfiles_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Perfiles.CellContentClick
        If DG_Perfiles.Columns(e.ColumnIndex).Name = "Eliminar" Then 'Si se hace click en el boton Eliminar de la fila.
            Dim Result As DialogResult
            Dim id_Perfil As Integer = DG_Perfiles.Rows(e.RowIndex).Cells("id_Perfil").Value

            If id_Perfil = 1 Then 'si es el administrador, no dejo borrarlo.
                MessageBox.Show("El perfil administrador no puede ser eliminado.", "Administración de Perfiles", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Result = MessageBox.Show("¿Está seguro que desea eliminar el Perfil?", "Perfiles", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If Result = System.Windows.Forms.DialogResult.Yes Then 'Si acepta eliminar el item

                    If id_Perfil = 0 Then
                        'si no completo la descripcion, muestro un msg de error.
                        MessageBox.Show("No se puede eliminar el Perfil.", "Administración de Perfiles", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else
                        'ejecuto el sp_EliminarColores.
                        MessageBox.Show(NPerfiles.EliminarPerfiles(id_Perfil), "Administración de Perfiles", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        'refresco el datagrid
                        DG_Perfiles.DataSource = NPerfiles.ListadoPerfiles().Tables(0)
                        DG_Perfiles.Refresh()

                    End If
                End If
            End If
        ElseIf DG_Perfiles.Columns(e.ColumnIndex).Name = "Modificar" Then 'Si se hace click en el boton Modificar de la fila.

            'Cambio el cursor.
            Me.Cursor = Cursors.WaitCursor

            Dim id_Perfil As Integer = DG_Perfiles.Rows(e.RowIndex).Cells("id_Perfil").Value()
            Dim dsPerfil As DataSet

            EPerfiles.id_Perfil = id_Perfil

            'lleno la entidad perfiles
            dsPerfil = NPerfiles.ConsultarPerfil(id_Perfil)

            'lleno los controls del tab_modificacion
            lbl_Perfil.Text = dsPerfil.Tables(0).Rows(0).Item("Descripcion").ToString

            If dsPerfil.Tables(0).Rows(0).Item("Habilitado").ToString = "1" Then
                chk_Habilitado_mod.Checked = True
            Else
                chk_Habilitado_mod.Checked = False
            End If

            Dim ds_patentesperfil As New DataSet
            ds_patentesperfil = NPatentes.ListadoPatentesPerfil(id_Perfil)
            If ds_patentesperfil.Tables(0).Rows.Count > 0 Then
                ListPatentesSelecMod.DataSource = ds_patentesperfil.Tables(0)
                ListPatentesSelecMod.DisplayMember = "Descripcion"
                ListPatentesSelecMod.ValueMember = "id_Patente"
                ListPatentesSelecMod.Refresh()
            End If

            'Deselecciono items.
            ListPatentesMod.SelectedItem = Nothing
            ListPatentesSelecMod.SelectedItem = Nothing

            'Cambio el cursor.
            Me.Cursor = Cursors.Arrow

            'hago foco en el tab_modificacion 
            TabPerfiles.SelectedIndex = 2
        End If
    End Sub

    'Boton Modificar perfil.
    Private Sub Btn_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Modificar.Click
        Try
            'Declaracion
            Dim descrip As String
            Dim hab As Integer

            'Seteo las variables.
            descrip = Trim(lbl_Perfil.Text).ToLower
            If chk_Habilitado_mod.Checked Then
                hab = 1
            Else
                hab = 0
            End If

            If EPerfiles.id_Perfil = 1 Then
                'El perfil administrador no puede ser editado.
                MessageBox.Show("El perfil administrador no puede ser editado.", "Administración de Perfiles", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            ElseIf descrip = "" Then
                'si no completo la descripcion, muestro un msg de error.
                MessageBox.Show("Debe ingresar una Descripcion.", "Administración de Perfiles", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                lbl_Perfil.Focus()
            ElseIf ListPatentesSelecMod.Items.Count < 1 Then
                'si no completo al menos un perfil, muestro un msg de error.
                MessageBox.Show("Debe seleccionar al menos una patente.", "Administración de Perfiles", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Dim Result As DialogResult
                Result = MessageBox.Show("¿Está seguro que desea modificar el Perfil?", "Administración de Perfiles", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If Result = System.Windows.Forms.DialogResult.Yes Then 'Si acepta modificar el item
                    'Cambio el cursor a "WAIT"
                    Me.Cursor = Cursors.WaitCursor

                    'lleno la entidad colores
                    EPerfiles.Descripcion = descrip
                    EPerfiles.Habilitado = hab
                    EPerfiles.Patentes = ListPatentesSelecMod

                    'ejecuto el sp_ModificacionPerfiles.
                    MessageBox.Show(NPerfiles.ModificacionPerfiles(EPerfiles), "Administración de Perfiles", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    'seteo los controles en cero.
                    chk_Habilitado_mod.Checked = False
                    lbl_Perfil.Focus()
                    EPerfiles.id_Perfil = 0
                    ListPatentesSelecMod.ClearSelected()
                    ListPatentesSelecMod.DataSource = Nothing
                    ListPatentesSelecMod.Refresh()

                    'Cambio el cursor a NORMAL.
                    Me.Cursor = Cursors.Arrow

                    'hago foco en el tab_listado
                    TabPerfiles.SelectedIndex = 0
                End If

            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha producido un error al modificar el perfil. Por favor, intente más tarde.", "Administración de Perfiles", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'Cuando agregas patentes del List A al List B.
    Private Sub Btn_AgregarPate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_AgregarPate.Click
        If ListPatentes.SelectedItems.Count < 1 Then
            MessageBox.Show("Debe seleccionar al menos una patente.", "Administración de Perfiles", MessageBoxButtons.OK, MessageBoxIcon.Question)
        Else
            'Cambio el cursor.
            Me.Cursor = Cursors.WaitCursor

            'Agrego al ListPatentesSelect los elementos del ListPatentes
            Dim dt As New DataTable
            Dim dr As DataRow
            Dim dv As DataView

            dt.Columns.Add(New DataColumn("id_Patente", GetType(Integer)))
            dt.Columns.Add(New DataColumn("Descripcion", GetType(String)))

            'Items seleccionados en Lista A,
            For i = 0 To ListPatentes.SelectedItems.Count - 1
                dr = dt.NewRow()
                dr("id_Patente") = ListPatentes.SelectedItems(i)("id_Patente")
                dr("Descripcion") = ListPatentes.SelectedItems(i)("Descripcion")
                dt.Rows.Add(dr)
            Next

            'Agrego los items ya agregados en la Lista B.
            For i = 0 To ListPatentesSelec.Items.Count - 1
                dr = dt.NewRow()
                dr("id_Patente") = ListPatentesSelec.Items(i)("id_Patente")
                dr("Descripcion") = ListPatentesSelec.Items(i)("Descripcion")
                dt.Rows.Add(dr)
            Next

            'Asigno el Datatable al List B.
            dv = New DataView(dt, "", "Descripcion ASC", DataViewRowState.CurrentRows)
            ListPatentesSelec.DataSource = dv
            ListPatentesSelec.DisplayMember = "Descripcion"
            ListPatentesSelec.ValueMember = "id_Patente"
            ListPatentesSelec.Refresh()

            'Elimino del ListPatentes el elemento que pasa al ListPatentesSelec
            Dim dt2 As New DataTable
            Dim dr2 As DataRow

            dt2.Columns.Add(New DataColumn("id_Patente", GetType(Integer)))
            dt2.Columns.Add(New DataColumn("Descripcion", GetType(String)))
            dt2.Constraints.Add("id_Patente", dt2.Columns(0), True)

            'Cargo un datatable con todas las opciones del List A
            For i = 0 To ListPatentes.Items.Count - 1
                dr2 = dt2.NewRow()
                dr2("id_Patente") = ListPatentes.Items(i)("id_Patente")
                dr2("Descripcion") = ListPatentes.Items(i)("Descripcion")
                dt2.Rows.Add(dr2)
            Next

            'Elimino Repetidos
            For j = 0 To dt2.Rows.Count - 1
                For k = 0 To ListPatentesSelec.Items.Count - 1
                    If dt2.Rows.Contains(ListPatentesSelec.Items(k)("id_Patente")) Then
                        dt2.Rows.Remove(dt2.Rows.Find(ListPatentesSelec.Items(k)("id_Patente")))
                    End If
                Next
            Next

            'Asigno el Datatable al List A.
            dv = New DataView(dt2, "", "Descripcion ASC", DataViewRowState.CurrentRows)
            ListPatentes.DataSource = dv
            ListPatentes.DisplayMember = "Descripcion"
            ListPatentes.ValueMember = "id_Patente"
            ListPatentes.Refresh()

            'Deselecciono items.
            ListPatentes.SelectedItem = Nothing
            ListPatentesSelec.SelectedItem = Nothing
            Chk_Selected.Checked = False
            Chk_Selected2.Checked = False

            'Cambio el cursor.
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    'Cuando quito patentes del List B y las agrego al List A.
    Private Sub Btn_EliminarPate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_EliminarPate.Click
        If ListPatentesSelec.SelectedItems.Count < 1 Then
            MessageBox.Show("Debe seleccionar al menos una patente.", "Administración de Perfiles", MessageBoxButtons.OK, MessageBoxIcon.Question)
        Else
            'Cambio el cursor.
            Me.Cursor = Cursors.WaitCursor

            'Variables
            Dim dt As New DataTable
            Dim dr As DataRow
            Dim dv As DataView

            dt.Columns.Add(New DataColumn("id_Patente", GetType(Integer)))
            dt.Columns.Add(New DataColumn("Descripcion", GetType(String)))
            dt.Constraints.Add("id_Patente", dt.Columns(0), True)

            'Items en Lista B.
            For i = 0 To ListPatentesSelec.Items.Count - 1
                dr = dt.NewRow()
                dr("id_Patente") = ListPatentesSelec.Items(i)("id_Patente")
                dr("Descripcion") = ListPatentesSelec.Items(i)("Descripcion")
                dt.Rows.Add(dr)
            Next

            'Elimino del ListPatentesSelec el elemento que pasa al ListPatentes
            For j = 0 To dt.Rows.Count - 1
                For k = 0 To ListPatentesSelec.SelectedItems.Count - 1
                    If dt.Rows.Contains(ListPatentesSelec.SelectedItems(k)("id_Patente")) Then
                        dt.Rows.Remove(dt.Rows.Find(ListPatentesSelec.SelectedItems(k)("id_Patente")))
                    End If
                Next
            Next

            'Variables
            Dim dt2 As New DataTable
            Dim dr2 As DataRow
            Dim dv2 As DataView

            dt2.Columns.Add(New DataColumn("id_Patente", GetType(Integer)))
            dt2.Columns.Add(New DataColumn("Descripcion", GetType(String)))
            dt2.Constraints.Add("id_Patente", dt2.Columns(0), True)

            'Items en Lista A,
            For i = 0 To ListPatentes.Items.Count - 1
                dr2 = dt2.NewRow()
                dr2("id_Patente") = ListPatentes.Items(i)("id_Patente")
                dr2("Descripcion") = ListPatentes.Items(i)("Descripcion")
                dt2.Rows.Add(dr2)
            Next


            'Agrego al ListPatentes los elementos que pasan del ListPatentesSelec
            For k = 0 To ListPatentesSelec.SelectedItems.Count - 1
                If Not dt2.Rows.Contains(ListPatentesSelec.SelectedItems(k)("id_Patente")) Then
                    dr2 = dt2.NewRow()
                    dr2("id_Patente") = ListPatentesSelec.SelectedItems(k)("id_Patente")
                    dr2("Descripcion") = ListPatentesSelec.SelectedItems(k)("Descripcion")
                    dt2.Rows.Add(dr2)
                End If
            Next

            'Asigno el Datatable al List A.
            dv2 = New DataView(dt2, "", "Descripcion ASC", DataViewRowState.CurrentRows)
            ListPatentes.DataSource = dv2
            ListPatentes.DisplayMember = "Descripcion"
            ListPatentes.ValueMember = "id_Patente"
            ListPatentes.Refresh()

            'Asigno el Datatable al List B.
            dv = New DataView(dt, "", "Descripcion ASC", DataViewRowState.CurrentRows)
            ListPatentesSelec.DataSource = dv
            ListPatentesSelec.DisplayMember = "Descripcion"
            ListPatentesSelec.ValueMember = "id_Patente"
            ListPatentesSelec.Refresh()

            'Deselecciono items.
            ListPatentes.SelectedItem = Nothing
            ListPatentesSelec.SelectedItem = Nothing
            Chk_Selected.Checked = False
            Chk_Selected2.Checked = False

            'Cambio el cursor.
            Me.Cursor = Cursors.Arrow

        End If
    End Sub

    'Cuando cambia de opcion en el combo.
    Private Sub Cb_Filtros_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_Filtros.SelectedIndexChanged
        'Cambio el cursor.
        Me.Cursor = Cursors.WaitCursor

        Dim ds As DataSet
        If Cb_Filtros.SelectedItem("id_Sucursal") = -1 Then ' si selecciona "todas" en el combo.
            ds = NPatentes.ListadoPatentes()
        ElseIf Cb_Filtros.SelectedItem("id_Sucursal") = 0 Then ' si selecciona "generales" en el combo.
            ds = NPatentes.ListadoPatentesGenerales()
        Else 'si selecciona una especifica.
            ds = NPatentes.ListadoPatentesPorSucursal(Cb_Filtros.SelectedItem("id_Sucursal"))
        End If

        'Elimino del ListPatentes el elemento que pasa al ListPatentesSelec
        Dim dt2 As New DataTable
        Dim dr2 As DataRow
        Dim dv As DataView

        dt2.Columns.Add(New DataColumn("id_Patente", GetType(Integer)))
        dt2.Columns.Add(New DataColumn("Descripcion", GetType(String)))
        dt2.Constraints.Add("id_Patente", dt2.Columns(0), True)

        'Cargo un datatable con todas las opciones del List A
        For i = 0 To ds.Tables(0).Rows.Count - 1
            dr2 = dt2.NewRow()
            dr2("id_Patente") = ds.Tables(0).Rows(i)("id_Patente")
            dr2("Descripcion") = ds.Tables(0).Rows(i)("Descripcion")
            dt2.Rows.Add(dr2)
        Next

        'Elimino Repetidos
        For j = 0 To dt2.Rows.Count - 1
            For k = 0 To ListPatentesSelec.Items.Count - 1
                If dt2.Rows.Contains(ListPatentesSelec.Items(k)("id_Patente")) Then
                    dt2.Rows.Remove(dt2.Rows.Find(ListPatentesSelec.Items(k)("id_Patente")))
                End If
            Next
        Next

        'Asigno el Datatable al List A.
        dv = New DataView(dt2, "", "Descripcion ASC", DataViewRowState.CurrentRows)
        ListPatentes.DataSource = dv
        ListPatentes.DisplayMember = "Descripcion"
        ListPatentes.ValueMember = "id_Patente"
        ListPatentes.Refresh()

        'Deselecciono items.
        ListPatentes.SelectedItem = Nothing
        ListPatentesSelec.SelectedItem = Nothing
        Chk_Selected.Checked = False
        Chk_Selected2.Checked = False

        'Cambio el cursor.
        Me.Cursor = Cursors.Arrow
    End Sub

    'Cuando cambia de opcion en el combo - EDIT.
    Private Sub Cb_FiltrosMod_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_FiltrosMod.SelectedIndexChanged
        'Cambio el cursor.
        Me.Cursor = Cursors.WaitCursor

        Dim ds As DataSet
        If Cb_FiltrosMod.SelectedItem("id_Sucursal") = -1 Then ' si selecciona "todas" en el combo.
            ds = NPatentes.ListadoPatentes()
        ElseIf Cb_FiltrosMod.SelectedItem("id_Sucursal") = 0 Then ' si selecciona "generales" en el combo.
            ds = NPatentes.ListadoPatentesGenerales()
        Else 'si selecciona una especifica.
            ds = NPatentes.ListadoPatentesPorSucursal(Cb_FiltrosMod.SelectedItem("id_Sucursal"))
        End If

        'Elimino del ListPatentes el elemento que pasa al ListPatentesSelec
        Dim dt2 As New DataTable
        Dim dr2 As DataRow
        Dim dv As DataView

        dt2.Columns.Add(New DataColumn("id_Patente", GetType(Integer)))
        dt2.Columns.Add(New DataColumn("Descripcion", GetType(String)))
        dt2.Constraints.Add("id_Patente", dt2.Columns(0), True)

        'Cargo un datatable con todas las opciones del List A
        For i = 0 To ds.Tables(0).Rows.Count - 1
            dr2 = dt2.NewRow()
            dr2("id_Patente") = ds.Tables(0).Rows(i)("id_Patente")
            dr2("Descripcion") = ds.Tables(0).Rows(i)("Descripcion")
            dt2.Rows.Add(dr2)
        Next

        'Elimino Repetidos
        For j = 0 To dt2.Rows.Count - 1
            For k = 0 To ListPatentesSelecMod.Items.Count - 1
                If dt2.Rows.Contains(ListPatentesSelecMod.Items(k)("id_Patente")) Then
                    dt2.Rows.Remove(dt2.Rows.Find(ListPatentesSelecMod.Items(k)("id_Patente")))
                End If
            Next
        Next

        'Asigno el Datatable al List A.
        dv = New DataView(dt2, "", "Descripcion ASC", DataViewRowState.CurrentRows)
        ListPatentesMod.DataSource = dv
        ListPatentesMod.DisplayMember = "Descripcion"
        ListPatentesMod.ValueMember = "id_Patente"
        ListPatentesMod.Refresh()

        'Deselecciono items.
        ListPatentesMod.SelectedItem = Nothing
        ListPatentesSelecMod.SelectedItem = Nothing

        'Cambio el cursor.
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub ListPatentes_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListPatentes.MouseHover
        If ListPatentes.Items.Count < 1 Then
            ListPatentes.Cursor = Cursors.No
        Else
            ListPatentes.Cursor = Cursors.Arrow
        End If
    End Sub

    'Aparece/Desaparece la botonera de agregar/quitar.
    Private Sub ListPatentes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListPatentes.SelectedIndexChanged
        If ListPatentes.SelectedItems.Count >= 1 Then
            Btn_AgregarPate.Visible = True
        Else
            Btn_AgregarPate.Visible = False
        End If

        If ListPatentesSelec.SelectedItems.Count >= 1 Then
            Btn_EliminarPate.Visible = True
        Else
            Btn_EliminarPate.Visible = False
        End If
    End Sub

    Private Sub ListPatentesSelec_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListPatentesSelec.MouseHover
        If ListPatentesSelec.Items.Count < 1 Then
            ListPatentesSelec.Cursor = Cursors.No
        Else
            ListPatentesSelec.Cursor = Cursors.Arrow
        End If
    End Sub

    'Aparece/Desaparece la botonera de agregar/quitar.
    Private Sub ListPatentesSelec_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListPatentesSelec.SelectedIndexChanged
        If ListPatentesSelec.SelectedItems.Count >= 1 Then
            Btn_EliminarPate.Visible = True
        Else
            Btn_EliminarPate.Visible = False
        End If

        If ListPatentes.SelectedItems.Count >= 1 Then
            Btn_AgregarPate.Visible = True
        Else
            Btn_AgregarPate.Visible = False
        End If
    End Sub

    'Cuando agregas patentes del List A al List B - EDIT.
    Private Sub Btn_AgregarPateMod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_AgregarPateMod.Click
        If ListPatentesMod.SelectedItems.Count < 1 Then
            MessageBox.Show("Debe seleccionar al menos una patente.", "Administración de Perfiles", MessageBoxButtons.OK, MessageBoxIcon.Question)
        Else
            'Cambio el cursor.
            Me.Cursor = Cursors.WaitCursor

            'Agrego al ListPatentesSelect los elementos del ListPatentes
            Dim dt As New DataTable
            Dim dr As DataRow
            Dim dv As DataView

            dt.Columns.Add(New DataColumn("id_Patente", GetType(Integer)))
            dt.Columns.Add(New DataColumn("Descripcion", GetType(String)))

            'Items seleccionados en Lista A,
            For i = 0 To ListPatentesMod.SelectedItems.Count - 1
                dr = dt.NewRow()
                dr("id_Patente") = ListPatentesMod.SelectedItems(i)("id_Patente")
                dr("Descripcion") = ListPatentesMod.SelectedItems(i)("Descripcion")
                dt.Rows.Add(dr)
            Next

            'Agrego los items ya agregados en la Lista B.
            For i = 0 To ListPatentesSelecMod.Items.Count - 1
                dr = dt.NewRow()
                dr("id_Patente") = ListPatentesSelecMod.Items(i)("id_Patente")
                dr("Descripcion") = ListPatentesSelecMod.Items(i)("Descripcion")
                dt.Rows.Add(dr)
            Next

            'Asigno el Datatable al List B.
            dv = New DataView(dt, "", "Descripcion ASC", DataViewRowState.CurrentRows)
            ListPatentesSelecMod.DataSource = dv
            ListPatentesSelecMod.DisplayMember = "Descripcion"
            ListPatentesSelecMod.ValueMember = "id_Patente"
            ListPatentesSelecMod.Refresh()

            'Elimino del ListPatentes el elemento que pasa al ListPatentesSelec
            Dim dt2 As New DataTable
            Dim dr2 As DataRow

            dt2.Columns.Add(New DataColumn("id_Patente", GetType(Integer)))
            dt2.Columns.Add(New DataColumn("Descripcion", GetType(String)))
            dt2.Constraints.Add("id_Patente", dt2.Columns(0), True)

            'Cargo un datatable con todas las opciones del List A
            For i = 0 To ListPatentesMod.Items.Count - 1
                dr2 = dt2.NewRow()
                dr2("id_Patente") = ListPatentesMod.Items(i)("id_Patente")
                dr2("Descripcion") = ListPatentesMod.Items(i)("Descripcion")
                dt2.Rows.Add(dr2)
            Next

            'Elimino Repetidos
            For j = 0 To dt2.Rows.Count - 1
                For k = 0 To ListPatentesSelecMod.Items.Count - 1
                    If dt2.Rows.Contains(ListPatentesSelecMod.Items(k)("id_Patente")) Then
                        dt2.Rows.Remove(dt2.Rows.Find(ListPatentesSelecMod.Items(k)("id_Patente")))
                    End If
                Next
            Next

            'Asigno el Datatable al List A.
            dv = New DataView(dt2, "", "Descripcion ASC", DataViewRowState.CurrentRows)
            ListPatentesMod.DataSource = dv
            ListPatentesMod.DisplayMember = "Descripcion"
            ListPatentesMod.ValueMember = "id_Patente"
            ListPatentesMod.Refresh()

            'Deselecciono items.
            ListPatentesMod.SelectedItem = Nothing
            ListPatentesSelecMod.SelectedItem = Nothing

            'Cambio el cursor.
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    'Cuando quito patentes del List B y las agrego al List A - EDIT.
    Private Sub Btn_EliminarPatMod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_EliminarPatMod.Click
        If ListPatentesSelecMod.SelectedItems.Count < 1 Then
            MessageBox.Show("Debe seleccionar al menos una patente.", "Administración de Perfiles", MessageBoxButtons.OK, MessageBoxIcon.Question)
        Else
            'Cambio el cursor.
            Me.Cursor = Cursors.WaitCursor

            'Variables
            Dim dt As New DataTable
            Dim dr As DataRow
            Dim dv As DataView

            dt.Columns.Add(New DataColumn("id_Patente", GetType(Integer)))
            dt.Columns.Add(New DataColumn("Descripcion", GetType(String)))
            dt.Constraints.Add("id_Patente", dt.Columns(0), True)

            'Items en Lista B.
            For i = 0 To ListPatentesSelecMod.Items.Count - 1
                dr = dt.NewRow()
                dr("id_Patente") = ListPatentesSelecMod.Items(i)("id_Patente")
                dr("Descripcion") = ListPatentesSelecMod.Items(i)("Descripcion")
                dt.Rows.Add(dr)
            Next

            'Elimino del ListPatentesSelec el elemento que pasa al ListPatentes
            For j = 0 To dt.Rows.Count - 1
                For k = 0 To ListPatentesSelecMod.SelectedItems.Count - 1
                    If dt.Rows.Contains(ListPatentesSelecMod.SelectedItems(k)("id_Patente")) Then
                        dt.Rows.Remove(dt.Rows.Find(ListPatentesSelecMod.SelectedItems(k)("id_Patente")))
                    End If
                Next
            Next

            'Variables
            Dim dt2 As New DataTable
            Dim dr2 As DataRow
            Dim dv2 As DataView

            dt2.Columns.Add(New DataColumn("id_Patente", GetType(Integer)))
            dt2.Columns.Add(New DataColumn("Descripcion", GetType(String)))
            dt2.Constraints.Add("id_Patente", dt2.Columns(0), True)

            'Items en Lista A,
            For i = 0 To ListPatentesMod.Items.Count - 1
                dr2 = dt2.NewRow()
                dr2("id_Patente") = ListPatentesMod.Items(i)("id_Patente")
                dr2("Descripcion") = ListPatentesMod.Items(i)("Descripcion")
                dt2.Rows.Add(dr2)
            Next

            'Agrego al ListPatentes los elementos que pasan del ListPatentesSelec
            For j = 0 To dt2.Rows.Count - 1
                For k = 0 To ListPatentesSelecMod.SelectedItems.Count - 1
                    If Not dt2.Rows.Contains(ListPatentesSelecMod.SelectedItems(k)("id_Patente")) Then
                        dr2 = dt2.NewRow()
                        dr2("id_Patente") = ListPatentesSelecMod.SelectedItems(k)("id_Patente")
                        dr2("Descripcion") = ListPatentesSelecMod.SelectedItems(k)("Descripcion")
                        dt2.Rows.Add(dr2)
                    End If
                Next
            Next

            'Asigno el Datatable al List A.
            dv2 = New DataView(dt2, "", "Descripcion ASC", DataViewRowState.CurrentRows)
            ListPatentesMod.DataSource = dv2
            ListPatentesMod.DisplayMember = "Descripcion"
            ListPatentesMod.ValueMember = "id_Patente"
            ListPatentesMod.Refresh()

            'Asigno el Datatable al List B.
            dv = New DataView(dt, "", "Descripcion ASC", DataViewRowState.CurrentRows)
            ListPatentesSelecMod.DataSource = dv
            ListPatentesSelecMod.DisplayMember = "Descripcion"
            ListPatentesSelecMod.ValueMember = "id_Patente"
            ListPatentesSelecMod.Refresh()

            'Deselecciono items.
            ListPatentesMod.SelectedItem = Nothing
            ListPatentesSelecMod.SelectedItem = Nothing
            Chk_Selected_Mod.Checked = False
            Chk_Selected2_Mod.Checked = False

            'Cambio el cursor.
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub ListPatentesMod_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListPatentesMod.MouseHover
        If ListPatentesMod.Items.Count < 1 Then
            ListPatentesMod.Cursor = Cursors.No
        Else
            ListPatentesMod.Cursor = Cursors.Arrow
        End If
    End Sub

    'Aparece/Desaparece la botonera de agregar/quitar.
    Private Sub ListPatentesMod_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListPatentesMod.SelectedIndexChanged
        If ListPatentesMod.SelectedItems.Count >= 1 Then
            Btn_AgregarPateMod.Visible = True
        Else
            Btn_AgregarPateMod.Visible = False
        End If

        If ListPatentesSelecMod.SelectedItems.Count >= 1 Then
            Btn_EliminarPatMod.Visible = True
        Else
            Btn_EliminarPatMod.Visible = False
        End If
    End Sub

    Private Sub ListPatentesSelecMod_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListPatentesSelecMod.MouseHover
        If ListPatentesSelecMod.Items.Count < 1 Then
            ListPatentesSelecMod.Cursor = Cursors.No
        Else
            ListPatentesSelecMod.Cursor = Cursors.Arrow
        End If
    End Sub

    'Aparece/Desaparece la botonera de agregar/quitar.
    Private Sub ListPatentesSelecMod_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListPatentesSelecMod.SelectedIndexChanged
        If ListPatentesSelecMod.SelectedItems.Count >= 1 Then
            Btn_EliminarPatMod.Visible = True
        Else
            Btn_EliminarPatMod.Visible = False
        End If

        If ListPatentesMod.SelectedItems.Count >= 1 Then
            Btn_AgregarPateMod.Visible = True
        Else
            Btn_AgregarPateMod.Visible = False
        End If
    End Sub

    'Cuando busca en el listado principal.
    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        'Cambio el cursor.
        Me.Cursor = Cursors.WaitCursor

        If Trim(txt_buscar.Text) <> "" Then
            'Seteo las variables.
            Dim descrip As String
            descrip = Trim(txt_buscar.Text.ToLower)

            'filtro el dataset por la descripcion que se va ingresando
            Dim dv As DataView = NPerfiles.ListadoPerfiles().Tables(0).DefaultView
            dv.RowFilter = "Descripcion LIKE '%" + descrip + "%'"

            'actualizo el datagrid
            If dv.Count > 0 Then
                DG_Perfiles.ColumnHeadersVisible = True
                DG_Perfiles.DataSource = dv
                DG_Perfiles.Refresh()
                lbl_Msg.Visible = False
            Else
                DG_Perfiles.ColumnHeadersVisible = False
                DG_Perfiles.DataSource = Nothing
                DG_Perfiles.Refresh()
                lbl_Msg.Visible = True
            End If
        Else
            MessageBox.Show("Debe ingresar un criterio de busqueda.", "Administración de Perfiles", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        'Cambio el cursor.
        Me.Cursor = Cursors.Arrow
    End Sub

    'Boton que restablece el listado de perfiles.
    Private Sub btn_Restablecer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Restablecer.Click
        Try
            'Cursor
            Me.Cursor = Cursors.WaitCursor

            'Listo los perfiles.
            Dim dsPerfiles As New DataSet
            dsPerfiles = NPerfiles.ListadoPerfiles()
            If dsPerfiles.Tables(0).Rows.Count > 0 Then
                DG_Perfiles.DataSource = dsPerfiles.Tables(0)
                DG_Perfiles.Columns("id_Perfil").Visible = False
                DG_Perfiles.AutoGenerateColumns = False
                DG_Perfiles.ColumnHeadersVisible = True
                DG_Perfiles.Refresh()
                lbl_Msg.Visible = False
            Else
                DG_Perfiles.DataSource = Nothing
                DG_Perfiles.ColumnHeadersVisible = True
                DG_Perfiles.Refresh()
                lbl_Msg.Visible = True
            End If

            'Seteo controles en cero.
            txt_buscar.Clear()
            txt_buscar.Focus()

            'Cursor
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha producido un error al listar los perfiles.", "Administración de Perfiles", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Check que selecciona/deselecciona todos los items. - Izquierda
    Private Sub Chk_Selected_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Chk_Selected.Click
        If Chk_Selected.Checked Then
            For i As Integer = 0 To Me.ListPatentes.Items.Count - 1
                Me.ListPatentes.SetSelected(i, True)
            Next
        Else
            For i As Integer = 0 To Me.ListPatentes.Items.Count - 1
                Me.ListPatentes.SetSelected(i, False)
            Next
        End If
    End Sub

    'Check que selecciona/deselecciona todos los items. - Derecha
    Private Sub Chk_Selected2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Chk_Selected2.Click
        If Chk_Selected2.Checked Then
            For i As Integer = 0 To Me.ListPatentesSelec.Items.Count - 1
                Me.ListPatentesSelec.SetSelected(i, True)
            Next
        Else
            For i As Integer = 0 To Me.ListPatentesSelec.Items.Count - 1
                Me.ListPatentesSelec.SetSelected(i, False)
            Next
        End If
    End Sub

    'Check que selecciona/deselecciona todos los items. - Izquierda - MOD
    Private Sub Chk_Selected_Mod_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_Selected_Mod.CheckedChanged
        If Chk_Selected_Mod.Checked Then
            For i As Integer = 0 To Me.ListPatentesMod.Items.Count - 1
                Me.ListPatentesMod.SetSelected(i, True)
            Next
        Else
            For i As Integer = 0 To Me.ListPatentesMod.Items.Count - 1
                Me.ListPatentesMod.SetSelected(i, False)
            Next
        End If
    End Sub

    'Check que selecciona/deselecciona todos los items. - Derecha - MOD
    Private Sub Chk_Selected2_Mod_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_Selected2_Mod.CheckedChanged
        If Chk_Selected2_Mod.Checked Then
            For i As Integer = 0 To Me.ListPatentesSelecMod.Items.Count - 1
                Me.ListPatentesSelecMod.SetSelected(i, True)
            Next
        Else
            For i As Integer = 0 To Me.ListPatentesSelecMod.Items.Count - 1
                Me.ListPatentesSelecMod.SetSelected(i, False)
            Next
        End If
    End Sub

    Private Sub Btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cancelar.Click
        TabPerfiles.SelectedIndex = 0
    End Sub
End Class