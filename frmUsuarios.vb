Public Class frmUsuarios
    Dim NUsuarios As New Negocio.Usuario
    Dim EUsuarios As New Entidades.Usuario
    Dim NEncripta As New Negocio.ClsEncriptacion
    Dim NPerfiles As New Negocio.NegPerfiles
    Dim func As New Funciones

#Region "Región Funciones"
    Sub LimpiarFormAlta()
        txt_usuario.Clear()
        txt_nombre.Clear()
        txt_apellido.Clear()
        txt_mail.Clear()
        txt_pass.Clear()
        txt_pass2.Clear()
        ErrorUsuarios.Clear()
        cb_Perfiles.SelectedItem = Nothing
        chk_Habilitado.Checked = False
    End Sub

    Sub LimpiarFormModificacion()
        txt_usuario_mod.Clear()
        txt_nombre_mod.Clear()
        txt_apellido_mod.Clear()
        txt_mail_mod.Clear()
        txt_pass_mod.Clear()
        txt_pass2_mod.Clear()
        Cb_Perfiles_mod.SelectedItem = Nothing
        chk_Habilitado_mod.Checked = False
        ErrorUsuarios.Clear()
    End Sub
#End Region

#Region "Región Eventos"
    'Click en Agregar Usuario.
    Private Sub Btn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Agregar.Click
        Try
            'Cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            'Declaro variables.
            Dim usu, nom, ape, mail, pass, pass2 As String
            Dim hab, id_perfil As Integer
            Dim mailValido As Boolean

            'Seteo las variables.
            usu = Trim(txt_usuario.Text).ToLower
            id_perfil = cb_Perfiles.SelectedValue
            nom = Trim(txt_nombre.Text).ToLower
            ape = Trim(txt_apellido.Text).ToLower
            mail = Trim(txt_mail.Text).ToLower
            pass = NEncripta.EncriptarMD5(Trim(txt_pass.Text).ToLower)
            pass2 = NEncripta.EncriptarMD5(Trim(txt_pass2.Text).ToLower)
            mailValido = func.IsValidEmail(mail)

            If chk_Habilitado.Checked Then
                hab = 1
            Else
                hab = 0
            End If

            If pass <> pass2 Then
                'si las contraseñas no coinciden, muestro un msg de error.
                MessageBox.Show("Las contraseñas ingresas no coinciden.", "Administración de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txt_pass.Clear()
                txt_pass2.Clear()
                txt_pass.Focus()
            ElseIf (usu = "" Or nom = "" Or ape = "" Or mail = "") Then
                'si hay campos vacios, muestro un msg de error.
                MessageBox.Show("Todos los campos son requeridos, por favor, complételos.", "Administración de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf (mailValido = False) Then
                'si el mail es incorrecto, muestro un msg de error.
                MessageBox.Show("El mail ingresado es incorrecto.", "Administración de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txt_mail.Focus()
            Else
                'completo la entidad usuarios
                EUsuarios.Apellido = ape
                EUsuarios.Nombre = nom
                EUsuarios.Usuario = usu
                EUsuarios.PWD = pass
                EUsuarios.Mail = mail
                EUsuarios.Habilitado = hab
                EUsuarios.id_Perfil = id_perfil

                'Limpio el formulario.
                LimpiarFormAlta()

                'Cursor a "NORMAL"
                Me.Cursor = Cursors.Arrow

                'ejecuto el sp_AltaUsuarios.
                MessageBox.Show(NUsuarios.AltaUsuarios(EUsuarios), "Administración de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information)

                'Redirecciono de tab.
                TabUsuarios.SelectedTab = TbListado
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha encontrado un error al procesar el alta.", "Administración de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Click en Modificar Usuario.
    Private Sub Btn_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Modificar.Click
        Try
            'Cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            'Declaro variables.
            Dim usu, nom, ape, mail, pass, pass2 As String
            Dim hab, id_perfil As Integer
            Dim mailValido As Boolean

            'Seteo variables.
            usu = Trim(txt_usuario_mod.Text).ToLower
            nom = Trim(txt_nombre_mod.Text).ToLower
            ape = Trim(txt_apellido_mod.Text).ToLower
            id_perfil = Cb_Perfiles_mod.SelectedValue
            mail = Trim(txt_mail_mod.Text).ToLower
            pass = NEncripta.EncriptarMD5(Trim(txt_pass_mod.Text).ToLower)
            pass2 = NEncripta.EncriptarMD5(Trim(txt_pass2_mod.Text).ToLower)
            mailValido = func.IsValidEmail(mail)

            If chk_Habilitado_mod.Checked Then
                hab = 1
            Else
                hab = 0
            End If

            If pass <> pass2 Then
                'si las contraseñas no coinciden, muestro un msg de error.
                Me.Cursor = Cursors.Arrow
                MessageBox.Show("Las contraseñas ingresas no coinciden.", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txt_pass.Clear()
                txt_pass2.Clear()
                txt_pass.Focus()
            ElseIf (usu = "" Or nom = "" Or ape = "" Or mail = "") Then
                'si hay campos vacios, muestro un msg de error.
                Me.Cursor = Cursors.Arrow
                MessageBox.Show("Todos los campos son requeridos, por favor, complételos.", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf (mailValido = False) Then
                'si el mail es incorrecto, muestro un msg de error.
                Me.Cursor = Cursors.Arrow
                MessageBox.Show("El mail ingresado es incorrecto.", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txt_mail.Focus()
            Else
                'completo la entidad usuarios
                EUsuarios.Apellido = ape
                EUsuarios.Nombre = nom
                EUsuarios.Usuario = usu
                EUsuarios.PWD = pass
                EUsuarios.Mail = mail
                EUsuarios.Habilitado = hab
                EUsuarios.id_Perfil = id_perfil

                'seteo los controles en cero.
                LimpiarFormModificacion()

                'Cursor a "NORMAL"
                Me.Cursor = Cursors.Arrow

                'ejecuto el sp_ModificacionUsuarios.
                MessageBox.Show(NUsuarios.ModificacionUsuarios(EUsuarios), "Administración de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information)

                'Refresco el datagrid de usuarios
                Dim dsUsuarios As New DataSet
                dsUsuarios = NUsuarios.ListadoUsuariosCompleto()
                If dsUsuarios.Tables(0).Rows.Count > 0 Then
                    DG_Buscador.DataSource = dsUsuarios.Tables(0)
                    DG_Buscador.AutoGenerateColumns = False
                    DG_Buscador.ColumnHeadersVisible = True
                    DG_Buscador.Columns("Habilitado_bus").DisplayIndex = 5
                    DG_Buscador.Columns("Eliminar_bus").DisplayIndex = 5
                    DG_Buscador.Refresh()
                    lbl_Msg2.Visible = False
                Else
                    DG_Buscador.DataSource = Nothing
                    DG_Buscador.ColumnHeadersVisible = False
                    DG_Buscador.Refresh()
                    lbl_Msg2.Visible = True
                End If
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha encontrado un error al procesar la modificación.", "Administración de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Load del form.
    Private Sub frmUsuarios_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            'seteo las imagenes
            Dim ListaImagenes = New ImageList
            ListaImagenes.ImageSize = New Size(32, 32)
            ListaImagenes.TransparentColor = Color.Blue
            ListaImagenes.ColorDepth = ColorDepth.Depth32Bit
            ListaImagenes.Images.Add(My.Resources.Recursos.Usuarios)
            ListaImagenes.Images.Add(My.Resources.Recursos.IconoADD)
            ListaImagenes.Images.Add(My.Resources.Recursos.Lapiz)
            TabUsuarios.ImageList = ListaImagenes

            'icono de colores
            TbListado.ImageIndex = 0
            'icono de alta
            TbAlta.ImageIndex = 1
            'icono de edicion
            TbMod.ImageIndex = 2

            'Cargo el datagrid
            Dim dsUsuarios As New DataSet
            dsUsuarios = NUsuarios.ListadoUsuariosCompleto()
            If dsUsuarios.Tables(0).Rows.Count > 0 Then
                DG_Usuarios.DataSource = dsUsuarios.Tables(0)
                DG_Usuarios.AutoGenerateColumns = False
                DG_Usuarios.ColumnHeadersVisible = True
                DG_Usuarios.Columns("Habilitado").DisplayIndex = 6
                DG_Usuarios.Columns("Modificar").DisplayIndex = 6
                DG_Usuarios.Columns("Eliminar").DisplayIndex = 6
                DG_Usuarios.Refresh()
                lbl_Msg.visible = False
            Else
                DG_Usuarios.DataSource = Nothing
                DG_Usuarios.ColumnHeadersVisible = False
                DG_Usuarios.Refresh()
                lbl_Msg.visible = True
            End If

            'agregado para probar el funcionamiento de patentes
            Dim objusuario As New Negocio.Usuario
            '3 visualiza usuarios - si llego aca puede visualizarlos
            '1 crea usuario
            If (objusuario.EsPatenteValida(1, VariablesGlobales.Patentes)) Then
            Else
                TabUsuarios.TabPages.Remove(Me.TbAlta)
            End If
            '2 modifica usuario
            If (objusuario.EsPatenteValida(2, VariablesGlobales.Patentes)) Then
            Else
                TabUsuarios.TabPages.Remove(Me.TbMod)
                DG_Usuarios.Columns(1).Visible = False
            End If
            '4 elimina usuario
            If (objusuario.EsPatenteValida(4, VariablesGlobales.Patentes)) Then
            Else
                TabUsuarios.TabPages.Remove(Me.TbMod)
                DG_Usuarios.Columns(0).Visible = False
                DG_Buscador.Columns("Eliminar_bus").Visible = False
            End If

            'Cambio el cursor a "NORMAL"
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha encontrado un error al cargar el listado de usuarios", "Administración de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'Solapas.
    Private Sub TabUsuarios_Selected(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabUsuarios.Selected
        'Cambio el cursor a "WAIT"
        Me.Cursor = Cursors.WaitCursor

        'Actualizo el datagrid si se selecciona el tab del listado o el tab de modificacion
        If TabUsuarios.SelectedIndex = 0 Then 'LISTADO
            'Cargo el datagrid de usuarios
            Dim dsUsuarios As New DataSet
            dsUsuarios = NUsuarios.ListadoUsuariosCompleto()
            If dsUsuarios.Tables(0).Rows.Count > 0 Then
                DG_Usuarios.DataSource = dsUsuarios.Tables(0)
                DG_Usuarios.AutoGenerateColumns = False
                DG_Usuarios.ColumnHeadersVisible = True
                DG_Usuarios.Columns("Habilitado").DisplayIndex = 6
                DG_Usuarios.Columns("Modificar").DisplayIndex = 6
                DG_Usuarios.Columns("Eliminar").DisplayIndex = 6
                DG_Usuarios.Refresh()
                lbl_Msg.Visible = False
            Else
                DG_Usuarios.DataSource = Nothing
                DG_Usuarios.ColumnHeadersVisible = False
                DG_Usuarios.Refresh()
                lbl_Msg.Visible = True
            End If
            'Limpio los Formularios
            LimpiarFormAlta()
            LimpiarFormModificacion()

        ElseIf TabUsuarios.SelectedIndex = 1 Then 'ALTA
            LimpiarFormAlta()
            LimpiarFormModificacion()
        ElseIf TabUsuarios.SelectedIndex = 2 Then 'MODIFICACION
            'Cargo el datagrid de usuarios
            Dim dsUsuarios As New DataSet
            dsUsuarios = NUsuarios.ListadoUsuariosCompleto()
            If dsUsuarios.Tables(0).Rows.Count > 0 Then
                DG_Buscador.DataSource = dsUsuarios.Tables(0)
                DG_Buscador.AutoGenerateColumns = False
                DG_Buscador.ColumnHeadersVisible = True
                DG_Buscador.Columns("Habilitado_bus").DisplayIndex = 5
                DG_Buscador.Columns("Eliminar_bus").DisplayIndex = 5
                DG_Buscador.Refresh()
                lbl_Msg2.Visible = False
            Else
                DG_Buscador.DataSource = Nothing
                DG_Buscador.ColumnHeadersVisible = False
                DG_Buscador.Refresh()
                lbl_Msg2.Visible = True
            End If
        End If

        'Cambio el cursor a "NORMAL"
        Me.Cursor = Cursors.Arrow
    End Sub

    'Enter en textbox buscar usuarios.
    Private Sub txt_buscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_buscar.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True

            'Seteo las variables.
            Dim descrip As String
            descrip = Trim(txt_buscar.Text.ToLower)

            If descrip = "" Then
                ErrorUsuarios.SetError(txt_buscar, "Debe completar el campo de busqueda.")
            Else
                Me.Cursor = Cursors.WaitCursor
                ErrorUsuarios.SetError(txt_buscar, Nothing)
                Dim dv As DataView = NUsuarios.ListadoUsuariosCompleto().Tables(0).DefaultView

                'filtro el dataset por la descripcion que se va ingresando
                dv.RowFilter = "Usuario LIKE '%" + descrip + "%'"

                'actualizo el datagrid
                If dv.Count > 0 Then
                    DG_Buscador.ColumnHeadersVisible = True
                    DG_Buscador.DataSource = dv
                    DG_Buscador.Refresh()
                    lbl_Msg.Visible = False
                Else
                    DG_Buscador.ColumnHeadersVisible = False
                    DG_Buscador.DataSource = Nothing
                    DG_Buscador.Refresh()
                    lbl_Msg.Visible = True
                End If

                Me.Cursor = Cursors.Arrow
            End If
        End If
    End Sub

    'Click en el listado de usuarios.
    Private Sub DG_Usuarios_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Usuarios.CellContentClick
        Try
            'Cursor
            Me.Cursor = Cursors.WaitCursor

            If DG_Usuarios.Columns(e.ColumnIndex).Name = "Eliminar" Then 'Si se hace click en el boton "eliminar" de la fila.
                Dim Result As DialogResult
                Me.Cursor = Cursors.Arrow
                Result = MessageBox.Show("¿Está seguro que desea eliminar el usuario?", "Administración de Usuarios", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If Result = System.Windows.Forms.DialogResult.Yes Then 'Si acepta eliminar el item
                    Dim id_Usuario As Integer = DG_Usuarios.Rows(e.RowIndex).Cells("id_Usuario").Value
                    If id_Usuario = 0 Then
                        'si no completo la descripcion, muestro un msg de error.
                        Me.Cursor = Cursors.Arrow
                        MessageBox.Show("No se puede eliminar el usuario.", "Administración de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else
                        'ejecuto el sp_EliminarColores.
                        Me.Cursor = Cursors.Arrow
                        MessageBox.Show(NUsuarios.EliminarUsuarios(id_Usuario), "Administración de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        'Refresco el datagrid de usuarios
                        Dim dsUsuarios As New DataSet
                        dsUsuarios = NUsuarios.ListadoUsuariosCompleto()
                        If dsUsuarios.Tables(0).Rows.Count > 0 Then
                            DG_Buscador.DataSource = dsUsuarios.Tables(0)
                            DG_Buscador.AutoGenerateColumns = False
                            DG_Buscador.ColumnHeadersVisible = True
                            DG_Buscador.Columns("Habilitado_bus").DisplayIndex = 5
                            DG_Buscador.Columns("Eliminar_bus").DisplayIndex = 5
                            DG_Buscador.Refresh()
                            lbl_Msg2.Visible = False
                        Else
                            DG_Buscador.DataSource = Nothing
                            DG_Buscador.ColumnHeadersVisible = False
                            DG_Buscador.Refresh()
                            lbl_Msg2.Visible = True
                        End If
                    End If
                End If
            ElseIf DG_Usuarios.Columns(e.ColumnIndex).Name = "Modificar" Then 'Si se hace click en el boton "modificar" de la fila.

                Dim id_Usuario As Integer = DG_Usuarios.Rows(e.RowIndex).Cells("id_Usuario").Value()
                Dim EntUsuario As New Entidades.Usuario

                EUsuarios.id_Usuario = id_Usuario

                'lleno la entidad colores
                EntUsuario = NUsuarios.TraerUsuario(id_Usuario)

                'lleno los controls del tab_modificacion
                txt_nombre_mod.Text = EntUsuario.Nombre
                txt_apellido_mod.Text = EntUsuario.Apellido
                txt_usuario_mod.Text = EntUsuario.Usuario
                txt_mail_mod.Text = EntUsuario.Mail

                If EntUsuario.Habilitado = "1" Then
                    chk_Habilitado_mod.Checked = True
                Else
                    chk_Habilitado_mod.Checked = False
                End If

                Dim dsPerfiles As New DataSet
                dsPerfiles = NPerfiles.ListadoPerfiles()
                If dsPerfiles.Tables(0).Rows.Count > 0 Then
                    Cb_Perfiles_mod.DataSource = dsPerfiles.Tables(0)
                    Cb_Perfiles_mod.ValueMember = "id_Perfil"
                    Cb_Perfiles_mod.DisplayMember = "Descripcion"
                    Cb_Perfiles_mod.SelectedValue = EntUsuario.id_Perfil
                    Cb_Perfiles_mod.Refresh()
                End If

                'Cursor
                Me.Cursor = Cursors.Arrow

                'hago foco en el tab_modificacion 
                TabUsuarios.SelectedIndex = 2
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha encontrado un error al procesar la acción.", "Administración de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Click en el listado de usuarios en la solapa modificacion.
    Private Sub DG_Buscador_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Buscador.CellContentClick
        Try
            If DG_Buscador.Columns(e.ColumnIndex).Name = "Eliminar_bus" Then 'Si se hace click en el boton de la fila.
                Dim Result As DialogResult
                Result = MessageBox.Show("¿Está seguro que desea eliminar el usuario?", "Administración de Usuarios", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If Result = System.Windows.Forms.DialogResult.Yes Then 'Si acepta eliminar el item
                    Dim id_Usuario As Integer = DG_Buscador.Rows(e.RowIndex).Cells("id_Usuario_bus").Value

                    If id_Usuario = 0 Then
                        'si no completo la descripcion, muestro un msg de error.
                        MessageBox.Show("No se puede eliminar el usuario.", "Administración de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else
                        'ejecuto el sp_EliminarColores.
                        MessageBox.Show(NUsuarios.EliminarUsuarios(id_Usuario), "Administración de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        'Refresco el datagrid de usuarios
                        Dim dsUsuarios As New DataSet
                        dsUsuarios = NUsuarios.ListadoUsuariosCompleto()
                        If dsUsuarios.Tables(0).Rows.Count > 0 Then
                            DG_Buscador.DataSource = dsUsuarios.Tables(0)
                            DG_Buscador.AutoGenerateColumns = False
                            DG_Buscador.ColumnHeadersVisible = True
                            DG_Buscador.Columns("Habilitado_bus").DisplayIndex = 5
                            DG_Buscador.Columns("Eliminar_bus").DisplayIndex = 5
                            DG_Buscador.Refresh()
                            lbl_Msg2.Visible = False
                        Else
                            DG_Buscador.DataSource = Nothing
                            DG_Buscador.ColumnHeadersVisible = False
                            DG_Buscador.Refresh()
                            lbl_Msg2.Visible = True
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha encontrado un error al eliminar el usuario.", "Administración de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Doble click en el listado de usuarios en la solapa modificacion.
    Private Sub DG_Buscador_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Buscador.CellClick
        Try
            Dim id_Usuario As Integer = 0
            Dim EntUsuario As New Entidades.Usuario

            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            If DG_Buscador.SelectedRows.Count > 0 Then
                If e.RowIndex >= 0 Then
                    id_Usuario = DG_Buscador.Rows(e.RowIndex).Cells("id_Usuario_bus").Value()
                    EUsuarios.id_Usuario = id_Usuario

                    'lleno la entidad usuario
                    EntUsuario = NUsuarios.TraerUsuario(id_Usuario)

                    'lleno los controls del tab_modificacion
                    txt_nombre_mod.Text = EntUsuario.Nombre
                    txt_apellido_mod.Text = EntUsuario.Apellido
                    txt_usuario_mod.Text = EntUsuario.Usuario
                    txt_mail_mod.Text = EntUsuario.Mail

                    If EntUsuario.Habilitado = "1" Then
                        chk_Habilitado_mod.Checked = True
                    Else
                        chk_Habilitado_mod.Checked = False
                    End If

                    Dim dsPerfiles As New DataSet
                    dsPerfiles = NPerfiles.ListadoPerfiles()
                    If dsPerfiles.Tables(0).Rows.Count > 0 Then
                        Cb_Perfiles_mod.DataSource = dsPerfiles.Tables(0)
                        Cb_Perfiles_mod.ValueMember = "id_Perfil"
                        Cb_Perfiles_mod.DisplayMember = "Descripcion"
                        Cb_Perfiles_mod.SelectedValue = EntUsuario.id_Perfil
                        Cb_Perfiles_mod.Refresh()
                    End If

                    'hago foco en el tab_modificacion 
                    TabUsuarios.SelectedIndex = 2
                End If
            End If

            'Cambio el cursor a "NORMAL"
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha encontrado un error al procesar la acción.", "Administración de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Doble click en el listado de usuarios.
    Private Sub DG_Usuarios_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Usuarios.CellDoubleClick
        Try
            Dim id_Usuario As Integer = 0
            Dim EntUsuario As New Entidades.Usuario

            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            If DG_Usuarios.SelectedRows.Count > 0 Then
                If e.RowIndex >= 0 Then
                    id_Usuario = DG_Usuarios.Rows(e.RowIndex).Cells("id_Usuario").Value()
                    EUsuarios.id_Usuario = id_Usuario

                    'lleno la entidad usuarios
                    EntUsuario = NUsuarios.TraerUsuario(id_Usuario)

                    'lleno los controls del tab_modificacion
                    txt_nombre_mod.Text = EntUsuario.Nombre
                    txt_apellido_mod.Text = EntUsuario.Apellido
                    txt_usuario_mod.Text = EntUsuario.Usuario
                    txt_mail_mod.Text = EntUsuario.Mail

                    If EntUsuario.Habilitado = "1" Then
                        chk_Habilitado_mod.Checked = True
                    Else
                        chk_Habilitado_mod.Checked = False
                    End If

                    Cb_Perfiles_mod.DataSource = NPerfiles.ListadoPerfiles().Tables(0)
                    Cb_Perfiles_mod.ValueMember = "id_Perfil"
                    Cb_Perfiles_mod.DisplayMember = "Descripcion"
                    Cb_Perfiles_mod.SelectedValue = EntUsuario.id_Perfil
                    Cb_Perfiles_mod.Refresh()

                    'hago foco en el tab_modificacion 
                    TabUsuarios.SelectedIndex = 2
                    DG_Buscador.Rows(1).Cells(0).Selected = False
                    DG_Buscador.Rows(e.RowIndex).Cells(0).Selected = True
                End If
            End If

            'Cambio el cursor a "NORMAL"
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha encontrado un error al procesar la acción.", "Administración de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Click en Buscar Usuario.
    Private Sub Btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Buscar.Click
        'Seteo las variables.
        Dim descrip As String
        descrip = Trim(txt_buscar.Text.ToLower)

        If descrip = "" Then
            ErrorUsuarios.SetError(txt_buscar, "Debe completar el campo de busqueda.")
        Else
            Me.Cursor = Cursors.WaitCursor
            ErrorUsuarios.SetError(txt_buscar, Nothing)
            Dim dv As DataView = NUsuarios.ListadoUsuariosCompleto().Tables(0).DefaultView

            'filtro el dataset por la descripcion que se va ingresando
            dv.RowFilter = "Usuario LIKE '%" + descrip + "%'"

            'actualizo el datagrid
            If dv.Count > 0 Then
                DG_Buscador.ColumnHeadersVisible = True
                DG_Buscador.DataSource = dv
                DG_Buscador.Refresh()
                lbl_Msg.Visible = False
            Else
                DG_Buscador.ColumnHeadersVisible = False
                DG_Buscador.DataSource = Nothing
                DG_Buscador.Refresh()
                lbl_Msg.Visible = True
            End If

            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    'Restablecer listado de usuario
    Private Sub btn_Restablecer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Restablecer.Click
        Try
            'Cursor
            Me.Cursor = Cursors.WaitCursor

            'Cargo el dataset de productos.
            Dim dsUsuarios As New DataSet
            dsUsuarios = NUsuarios.ListadoUsuariosCompleto()
            If dsUsuarios.Tables(0).Rows.Count > 0 Then
                DG_Buscador.DataSource = dsUsuarios.Tables(0)
                DG_Buscador.AutoGenerateColumns = False
                DG_Buscador.ColumnHeadersVisible = True
                DG_Buscador.Columns("Habilitado_bus").DisplayIndex = 5
                DG_Buscador.Columns("Eliminar_bus").DisplayIndex = 5
                DG_Buscador.Refresh()
                lbl_Msg2.Visible = False
            Else
                DG_Buscador.DataSource = Nothing
                DG_Buscador.ColumnHeadersVisible = False
                DG_Buscador.Refresh()
                lbl_Msg2.Visible = True
            End If

            'Limpio controles
            txt_buscar.Clear()
            txt_buscar.Focus()

            'Cursor
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha encontrado un error al cargar el listado de usuarios.", "Administración de Productos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Cargo el combo perfiles, al hacer foco.
    Private Sub cb_Perfiles_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_Perfiles.GotFocus
        'Cargo el combo de perfiles
        Dim dsPerfiles As New DataSet
        dsPerfiles = NPerfiles.ListadoPerfiles()
        If dsPerfiles.Tables(0).Rows.Count > 0 Then
            cb_Perfiles.DataSource = dsPerfiles.Tables(0)
            cb_Perfiles.ValueMember = "id_Perfil"
            cb_Perfiles.DisplayMember = "Descripcion"
            cb_Perfiles.Refresh()
        End If
    End Sub
#End Region

#Region "Región Validaciones"
    Private Sub txt_usuario_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_usuario.Validating
        If txt_usuario.Text = "" Then
            ErrorUsuarios.SetError(txt_usuario, "Debe completar el Usuario.")
        Else
            ErrorUsuarios.SetError(txt_usuario, Nothing)
        End If
    End Sub

    Private Sub txt_nombre_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_nombre.Validating
        If txt_nombre.Text = "" Then
            ErrorUsuarios.SetError(txt_nombre, "Debe completar el Nombre.")
        Else
            ErrorUsuarios.SetError(txt_nombre, Nothing)
        End If
    End Sub

    Private Sub txt_mail_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_mail.Validating
        If txt_mail.Text = "" Then
            ErrorUsuarios.SetError(txt_mail, "Debe completar el Mail.")
        Else
            ErrorUsuarios.SetError(txt_mail, Nothing)
        End If
    End Sub

    Private Sub txt_apellido_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_apellido.Validating
        If txt_apellido.Text = "" Then
            ErrorUsuarios.SetError(txt_apellido, "Debe completar el Apellido.")
        Else
            ErrorUsuarios.SetError(txt_apellido, Nothing)
        End If
    End Sub

    Private Sub txt_usuario_mod_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_usuario_mod.Validating
        If txt_usuario_mod.Text = "" Then
            ErrorUsuarios.SetError(txt_usuario_mod, "Debe completar el Usuario.")
        Else
            ErrorUsuarios.SetError(txt_usuario_mod, Nothing)
        End If
    End Sub

    Private Sub txt_nombre_mod_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_nombre_mod.Validating
        If txt_nombre_mod.Text = "" Then
            ErrorUsuarios.SetError(txt_nombre_mod, "Debe completar el Nombre.")
        Else
            ErrorUsuarios.SetError(txt_nombre_mod, Nothing)
        End If
    End Sub

    Private Sub txt_mail_mod_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_mail_mod.Validating
        If txt_mail_mod.Text = "" Then
            ErrorUsuarios.SetError(txt_mail_mod, "Debe completar el Mail.")
        Else
            ErrorUsuarios.SetError(txt_mail_mod, Nothing)
        End If
    End Sub

    Private Sub txt_apellido_mod_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_apellido_mod.Validating
        If txt_apellido_mod.Text = "" Then
            ErrorUsuarios.SetError(txt_apellido_mod, "Debe completar el Apellido.")
        Else
            ErrorUsuarios.SetError(txt_apellido_mod, Nothing)
        End If
    End Sub
#End Region

End Class