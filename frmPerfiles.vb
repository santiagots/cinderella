Public Class frmPerfiles
    Dim NPerfiles As New Negocio.NegPerfiles
    Dim NPatentes As New Negocio.NegPatentes
    Dim NSucursales As New Negocio.NegSucursales
    Dim EPerfiles As New Entidades.Perfiles

    Dim Sucursales As List(Of Entidades.Sucursales)


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

            dgPatentesModificacion.Columns("CodigoMod").Visible = False
            dgPatentes.Columns("Codigo").Visible = False

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

            'Cargo la lista de sucursales del tab Alta perfil
            Sucursales = NSucursales.ListadoSucursalesEntidad()
            Dim SucTodas As Entidades.Sucursales = New Entidades.Sucursales()
            SucTodas.Nombre = "Todas"
            Sucursales.Add(SucTodas)
            ltbFiltroGrupo.DataSource = NPatentes.ObtenerGrupos()
            ltbFiltroGrupo.ClearSelected()
            ltbFiltroGrupoModificacion.DataSource = NPatentes.ObtenerGrupos()
            ltbFiltroGrupoModificacion.ClearSelected()

            'Cargo la lista de sucursales del tab Alta perfil
            ltbFiltroSucursal.DataSource = Sucursales
            ltbFiltroSucursal.DisplayMember = "Nombre"
            ltbFiltroSucursal.ClearSelected()
            ltbFiltroSucursalModificacion.DataSource = Sucursales
            ltbFiltroSucursalModificacion.DisplayMember = "Nombre"
            ltbFiltroSucursalModificacion.ClearSelected()


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

            EvaluarPermisos()

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

        If TabPerfiles.SelectedTab.Name = "TbListado" Then  'Actualizo el datagrid si se selecciona el tab del listado

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

        ElseIf TabPerfiles.SelectedTab.Name = "TbAlta" Then  'Actualizo el datagrid si se selecciona el tab de Alta
            Dim ds, ds_sucursales As New DataSet

            dgPatentes.DataSource = NPatentes.ObtenerListadoCompoletoPorPerfil(-1)

            ltbFiltroSucursal.ClearSelected()
            ltbFiltroGrupo.ClearSelected()
            txtFiltroNombre.Clear()


        ElseIf TabPerfiles.SelectedTab.Name = "TbMod" Then 'Actualizo el datagrid si se selecciona el tab de Modificacion

            EPerfiles.id_Perfil = DG_Perfiles.CurrentRow.Cells("id_Perfil").Value()

            dgPatentesModificacion.DataSource = NPatentes.ObtenerListadoCompoletoPorPerfil(EPerfiles.id_Perfil)

            txtPerfilModificacion.Text = DG_Perfiles.CurrentRow.Cells("Descripcion").Value()

            chkHabilitado.Checked = DG_Perfiles.CurrentRow.Cells("Habilitado").Value() = "SI"

            'hago foco en el tab_modificacion 
            TabPerfiles.SelectedTab = TabPerfiles.TabPages("TbMod")

            'habilito y deshabilitos los Checks de los perfiles
            For Each row As DataGridViewRow In dgPatentesModificacion.Rows
                For Each col As DataGridViewColumn In dgPatentesModificacion.Columns
                    If (Sucursales.Any(Function(x) x.Nombre = col.Name)) Then
                        AbilitarDeshabilitarCeldas(dgPatentesModificacion, dgPatentesModificacion, row.Index, col.Index)
                    End If
                Next
            Next

            dgPatentesModificacion.Columns("CodigoMod").Visible = False

        End If

        'Cambio el cursor a NORMAL.
        Me.Cursor = Cursors.Arrow
    End Sub

    'Boton Agregar Perfil.
    Private Sub Btn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Agregar.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            If (String.IsNullOrEmpty(txtPerfil.Text)) Then
                Me.Cursor = Cursors.Arrow
                MessageBox.Show("Debe ingresar una descripción para dar de alta el perfil.", "Administración de Perfiles", MessageBoxButtons.OK, MessageBoxIcon.Question)
                Return
            End If

            Dim Patentes As List(Of Entidades.Patentes) = ObtenerPatentesSeleccionadas(dgPatentes, NPerfiles.UltimoPerfil() + 1)

            If (Patentes.Count = 0) Then
                Me.Cursor = Cursors.Arrow
                MessageBox.Show("Debe seleccionar al menos un permiso para dar de alta el perfil.", "Administración de Perfiles", MessageBoxButtons.OK, MessageBoxIcon.Question)
                Return
            End If

            Dim Respuesta As String = NPerfiles.InsertarPerfil(Patentes, txtPerfil.Text, True)
            MessageBox.Show(Respuesta, "Administración de Perfiles", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha producido un error al dar de alta el perfil. Por favor, intente más tarde.", "Administración de Perfiles", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Me.Cursor = Cursors.WaitCursor
        Try

            If EPerfiles.id_Perfil = 1 Then
                'El perfil administrador no puede ser editado.
                Me.Cursor = Cursors.Arrow
                MessageBox.Show("El perfil administrador no puede ser editado.", "Administración de Perfiles", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim Patentes As List(Of Entidades.Patentes) = ObtenerPatentesSeleccionadas(dgPatentesModificacion, EPerfiles.id_Perfil)

            If (String.IsNullOrEmpty(txtPerfilModificacion.Text)) Then
                Me.Cursor = Cursors.Arrow
                MessageBox.Show("Debe ingresar una descripción para modificar el perfil.", "Administración de Perfiles", MessageBoxButtons.OK, MessageBoxIcon.Question)
                Return
            End If

            If (Patentes.Count = 0) Then
                Me.Cursor = Cursors.Arrow
                MessageBox.Show("Debe seleccionar al menos un permiso para modificar el perfil.", "Administración de Perfiles", MessageBoxButtons.OK, MessageBoxIcon.Question)
                Return
            End If

            If MessageBox.Show("¿Está seguro que desea modificar el Perfil?", "Administración de Perfiles", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then 'Si acepta modificar el item
                Dim Respuesta As String = NPerfiles.InsertarPerfil(Patentes, txtPerfilModificacion.Text, chkHabilitado.Checked)
                MessageBox.Show(Respuesta, "Administración de Perfiles", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha producido un error al dar de modificar el perfil. Por favor, intente más tarde.", "Administración de Perfiles", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Me.Cursor = Cursors.Arrow
    End Sub

    'Doble click en el listado.
    Private Sub DG_Perfiles_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Perfiles.CellDoubleClick
        Dim id_Perfil As Integer = 0

        If DG_Perfiles.SelectedRows.Count > 0 Then
            If e.RowIndex >= 0 Then

                'Cambio el cursor.
                Me.Cursor = Cursors.WaitCursor

                id_Perfil = DG_Perfiles.Rows(e.RowIndex).Cells("id_Perfil").Value()
                EPerfiles.id_Perfil = id_Perfil

                dgPatentesModificacion.DataSource = NPatentes.ObtenerListadoCompoletoPorPerfil(id_Perfil)

                txtPerfilModificacion.Text = DG_Perfiles.Rows(e.RowIndex).Cells("Descripcion").Value()

                chkHabilitado.Checked = DG_Perfiles.Rows(e.RowIndex).Cells("Habilitado").Value() = "SI"

                'hago foco en el tab_modificacion 
                TabPerfiles.SelectedTab = TabPerfiles.TabPages("TbMod")

                'habilito y deshabilitos los Checks de los perfiles
                For Each row As DataGridViewRow In dgPatentesModificacion.Rows
                    For Each col As DataGridViewColumn In dgPatentesModificacion.Columns
                        If (Sucursales.Any(Function(x) x.Nombre = col.Name)) Then
                            AbilitarDeshabilitarCeldas(dgPatentesModificacion, dgPatentesModificacion, row.Index, col.Index)
                        End If
                    Next
                Next

                dgPatentesModificacion.Columns("CodigoMod").Visible = False
                'Cambio el cursor.
                Me.Cursor = Cursors.Arrow
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

            EPerfiles.id_Perfil = id_Perfil

            'lleno los controls del tab_modificacion
            txtPerfilModificacion.Text = DG_Perfiles.Rows(e.RowIndex).Cells("Descripcion").Value()

            chkHabilitado.Checked = DG_Perfiles.Rows(e.RowIndex).Cells("Habilitado").Value() = "SI"

            id_Perfil = DG_Perfiles.Rows(e.RowIndex).Cells("id_Perfil").Value()
            EPerfiles.id_Perfil = id_Perfil

            'recupero el listado de patentes y sus valores
            dgPatentesModificacion.DataSource = NPatentes.ObtenerListadoCompoletoPorPerfil(id_Perfil)

            'hago foco en el tab_modificacion 
            TabPerfiles.SelectedTab = TabPerfiles.TabPages("TbMod")

            'habilito y deshabilitos los Checks de los perfiles
            For Each row As DataGridViewRow In dgPatentesModificacion.Rows
                For Each col As DataGridViewColumn In dgPatentesModificacion.Columns
                    If (Sucursales.Any(Function(x) x.Nombre = col.Name)) Then
                        AbilitarDeshabilitarCeldas(dgPatentesModificacion, dgPatentesModificacion, row.Index, col.Index)
                    End If
                Next
            Next

            dgPatentesModificacion.Columns("CodigoMod").Visible = False

            'hago foco en el tab_modificacion 
            TabPerfiles.SelectedTab = TabPerfiles.TabPages("TbMod")

            'Cambio el cursor.
            Me.Cursor = Cursors.Arrow
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

    Private Sub Btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TabPerfiles.SelectedTab = TabPerfiles.TabPages("TbListado")
    End Sub

    Private Sub btnAltaBuscar_Click(sender As Object, e As EventArgs) Handles btnAltaBuscar.Click
        Dim grupos As List(Of String) = New List(Of String)()

        For Each item In ltbFiltroGrupo.SelectedItems
            grupos.Add(item.ToString)
        Next

        Dim sucursales As List(Of String) = New List(Of String)()

        For Each item As Entidades.Sucursales In ltbFiltroSucursal.SelectedItems
            sucursales.Add(item.Nombre)
        Next

        dgPatentes.CurrentCell = Nothing

        FiltrarPatentes(dgPatentes.Rows, txtFiltroNombre.Text, grupos, sucursales)
    End Sub

    Private Sub btnModificacionBuscar_Click(sender As Object, e As EventArgs) Handles btnModificacionBuscar.Click
        Dim grupos As List(Of String) = New List(Of String)()

        For Each item In ltbFiltroGrupoModificacion.SelectedItems
            grupos.Add(item.ToString)
        Next

        Dim sucursales As List(Of String) = New List(Of String)()

        For Each item As Entidades.Sucursales In ltbFiltroSucursalModificacion.SelectedItems
            sucursales.Add(item.Nombre)
        Next

        dgPatentesModificacion.CurrentCell = Nothing

        FiltrarPatentes(dgPatentesModificacion.Rows, txtFiltroNombreModificacion.Text, grupos, sucursales)
    End Sub


    Private Sub dgPatentes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgPatentes.CellContentClick
        If (Sucursales.Any(Function(x) x.Nombre = dgPatentes.Columns(e.ColumnIndex).Name)) Then
            AbilitarDeshabilitarCeldas(dgPatentes, dgPatentes, e.RowIndex, e.ColumnIndex)
        End If
    End Sub

    Private Sub dgPatentesModificacion_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgPatentesModificacion.CellContentClick
        If (Sucursales.Any(Function(x) x.Nombre = dgPatentesModificacion.Columns(e.ColumnIndex).Name)) Then
            AbilitarDeshabilitarCeldas(dgPatentesModificacion, dgPatentesModificacion, e.RowIndex, e.ColumnIndex)
        End If
    End Sub

    Private Sub btn_Restablecer_Alta_Click(sender As Object, e As EventArgs) Handles btn_Restablecer_Alta.Click
        RestablecerFiltros(dgPatentes.Rows, ltbFiltroGrupo, ltbFiltroSucursal, txtFiltroNombre)
    End Sub

    Private Sub btn_Restablecer_Alta_Modificacion_Click(sender As Object, e As EventArgs) Handles btn_Restablecer_Alta_Modificacion.Click
        RestablecerFiltros(dgPatentesModificacion.Rows, ltbFiltroGrupoModificacion, ltbFiltroSucursalModificacion, txtFiltroNombreModificacion)
    End Sub

    Private Sub RestablecerFiltros(ByRef Patentes As DataGridViewRowCollection, ByRef filtroGrupo As ListBox, ByRef filtroSucursal As ListBox, ByRef nombre As TextBox)
        filtroGrupo.ClearSelected()
        filtroSucursal.ClearSelected()
        nombre.Clear()

        For Each dr As DataGridViewRow In Patentes
            dr.Visible = True
        Next
    End Sub

    Private Sub FiltrarPatentes(ByRef Patentes As DataGridViewRowCollection, ByVal NombrePermiso As String, ByVal GruposSeleccionados As List(Of String), ByVal SucursalesSeleccionadas As List(Of String))

        For Each dr As DataGridViewRow In Patentes
            dr.Visible = True
        Next

        'Filtro las patentes con el valor ingresado en el filtro por nombre
        If (NombrePermiso.Length > 0) Then
            For Each dr As DataGridViewRow In Patentes
                If (Not dr.Cells(1).Value.ToString().ToUpper().Contains(NombrePermiso.ToUpper())) Then
                    dr.Visible = False
                End If
            Next
        End If

        'Filtro las patentes por grupo 
        If (GruposSeleccionados.Count > 0) Then
            For Each dr As DataGridViewRow In Patentes
                If (Not GruposSeleccionados.Contains(dr.Cells(2).Value.ToString())) Then
                    dr.Visible = False
                End If
            Next
        End If

        'Filtro las patentes las sucursales que tengan habilitada alguna patente
        If (SucursalesSeleccionadas.Count > 0) Then
            For Each dr As DataGridViewRow In Patentes
                For Each sucursal In SucursalesSeleccionadas
                    If (Not dr.Cells(sucursal).Value) Then
                        dr.Visible = False
                    End If
                Next
            Next
        End If
    End Sub

    Private Function ObtenerPatentesSeleccionadas(ByVal Patentes As DataGridView, ByVal perfil As Integer) As List(Of Entidades.Patentes)
        Dim PatentesSeleccionadas As List(Of Entidades.Patentes) = New List(Of Entidades.Patentes)

        For Each row As DataGridViewRow In Patentes.Rows
            For Each col As DataGridViewColumn In Patentes.Columns
                If (Sucursales.Where(Function(x) x.Nombre = col.Name).Any AndAlso col.Name <> "Todas" AndAlso row.Cells(col.Name).Value = True) Then
                    Dim patente As Entidades.Patentes = New Entidades.Patentes()
                    patente.id_Patente = row.Cells(0).Value
                    patente.id_Perfil = perfil
                    patente.id_Sucursal = Sucursales.Where(Function(x) x.Nombre = col.Name).FirstOrDefault().id_Sucursal

                    PatentesSeleccionadas.Add(patente)
                End If

                If (col.Name = "Todas" AndAlso row.Cells(col.Name).Value = True) Then
                    Dim patente As Entidades.Patentes = New Entidades.Patentes()
                    patente.id_Patente = row.Cells(0).Value
                    patente.id_Perfil = perfil
                    patente.id_Sucursal = -1

                    PatentesSeleccionadas.Add(patente)
                End If
            Next
        Next

        Return PatentesSeleccionadas
    End Function

    Sub AbilitarDeshabilitarCeldas(ByRef dgPatentes As DataGridView, ByVal dgPatentes2 As DataGridView, ByVal rowIndex As Integer, ByVal columnIndex As Integer)
        If (dgPatentes.Rows(rowIndex).Cells(columnIndex).ReadOnly) Then
            Return
        End If

        'Si se marco la opcion "Todas"
        If (dgPatentes.Rows(rowIndex).Cells(columnIndex).EditedFormattedValue And dgPatentes.Columns(columnIndex).Name = "Todas") Then
            'Desmarco los Check de las celdas que pretenecen a un sucursal y las deshabilito
            For Each sucursal As Entidades.Sucursales In Sucursales
                If (sucursal.Nombre <> "Todas") Then
                    Dim dataGridViewCheckBoxCell As DataGridViewCheckBoxCell = dgPatentes.Rows(rowIndex).Cells(sucursal.Nombre)
                    dataGridViewCheckBoxCell.ReadOnly = True
                    dataGridViewCheckBoxCell.Value = False
                    dataGridViewCheckBoxCell.FlatStyle = FlatStyle.Flat
                End If
            Next

            'Si se desmarco la opcion "Todas"
        ElseIf (Not dgPatentes.Rows(rowIndex).Cells(columnIndex).EditedFormattedValue And dgPatentes.Columns(columnIndex).Name = "Todas") Then
            'Habilito los Check de las celdas que pretenecen a un sucursal
            For Each sucursal As Entidades.Sucursales In Sucursales
                If (sucursal.Nombre <> "Todas") Then
                    Dim dataGridViewCheckBoxCell As DataGridViewCheckBoxCell = dgPatentes.Rows(rowIndex).Cells(sucursal.Nombre)
                    dataGridViewCheckBoxCell.ReadOnly = False
                    dataGridViewCheckBoxCell.FlatStyle = FlatStyle.Standard
                End If
            Next

            'Si se marco alguna sucursal
        ElseIf (dgPatentes.Rows(rowIndex).Cells(columnIndex).EditedFormattedValue And Sucursales.Any(Function(x) x.Nombre = dgPatentes2.Columns(columnIndex).Name)) Then
            'Desmarco los Check de "Todas" y la deshabilito
            Dim dataGridViewCheckBoxCell As DataGridViewCheckBoxCell = dgPatentes.Rows(rowIndex).Cells("Todas")
            dataGridViewCheckBoxCell.ReadOnly = True
            dataGridViewCheckBoxCell.Value = False
            dataGridViewCheckBoxCell.FlatStyle = FlatStyle.Flat

            'Si se desmarcaron todas las sucursales
        ElseIf (Not Sucursales.Any(Function(x) dgPatentes2.Rows(rowIndex).Cells(x.Nombre).EditedFormattedValue) And Sucursales.Any(Function(x) x.Nombre = dgPatentes2.Columns(columnIndex).Name)) Then
            'Desmarco los Check de "Todas" y la deshabilito
            Dim dataGridViewCheckBoxCell As DataGridViewCheckBoxCell = dgPatentes.Rows(rowIndex).Cells("Todas")
            dataGridViewCheckBoxCell.ReadOnly = False
            dataGridViewCheckBoxCell.FlatStyle = FlatStyle.Standard
        End If
    End Sub

    Sub EvaluarPermisos()
        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Seguridad_Perfiles_Crear)) Then

        Else
            TabPerfiles.TabPages.Remove(TabPerfiles.TabPages("TbAlta"))
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Seguridad_Perfiles_Eliminar)) Then
            DG_Perfiles.Columns("Eliminar").Visible = True
        Else
            DG_Perfiles.Columns("Eliminar").Visible = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Seguridad_Perfiles_Modificar)) Then
            DG_Perfiles.Columns("Modificar").Visible = True
        Else
            TabPerfiles.TabPages.Remove(TabPerfiles.TabPages("TbMod"))
            DG_Perfiles.Columns("Modificar").Visible = False
            RemoveHandler DG_Perfiles.CellDoubleClick, AddressOf DG_Perfiles_CellDoubleClick
        End If
    End Sub
End Class
