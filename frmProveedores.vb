Public Class frmProveedores
    Dim Negproveedores As New Negocio.NegProveedores
    Dim EProveedor As New Entidades.Proveedores
    Dim Negcondiciones As New Negocio.NegCondicionesIva
    Dim NegErrores As New Negocio.NegManejadorErrores

#Region "Región funciones"

    'Limpia el formulario de Alta.
    Sub LimpiarFormAltaProveedores()
        ErrorProveedor.Clear()
        txt_Nombre.Clear()
        txt_RazonSocial.Clear()
        txt_Telefono.Clear()
        txt_Direccion.Clear()
        txt_Mail.Clear()
        txt_MailAlternativo.Clear()
        cb_CondicionIva.SelectedItem = Nothing
        chk_Habilitado.Checked = True
    End Sub

    'Limpia el formulario de modificacion.
    Sub LimpiarFormModificacionProveedores()
        ErrorProveedor.Clear()
        txt_Nombre_mod.Clear()
        txt_RazonSocial_mod.Clear()
        txt_Telefono_mod.Clear()
        txt_Direccion_mod.Clear()
        txt_Mail_mod.Clear()
        txt_MailAlternativo_mod.Clear()
        cb_CondicionIva_mod.SelectedItem = Nothing
        chk_Habilitado_mod.Checked = True
    End Sub

#End Region

#Region "Región Validaciones"
    'Valido que ingrese el nombre.
    Private Sub txt_Nombre_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_Nombre.Validating
        If txt_Nombre.Text = "" Then
            ErrorProveedor.SetError(txt_Nombre, "Debe completar el Nombre.")
        Else
            ErrorProveedor.SetError(txt_Nombre, Nothing)
        End If
    End Sub

    'Valido que ingrese el mail.
    Private Sub txt_Mail_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_Mail.Validating
        If txt_Mail.Text = "" Then
            ErrorProveedor.SetError(txt_Mail, "Debe completar el Mail.")
        Else
            ErrorProveedor.SetError(txt_Mail, Nothing)
        End If
    End Sub

    'Valido que ingrese la razon social.
    Private Sub txt_RazonSocial_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_RazonSocial.Validating
        If txt_RazonSocial.Text = "" Then
            ErrorProveedor.SetError(txt_RazonSocial, "Debe completar la Razon Social.")
        Else
            ErrorProveedor.SetError(txt_RazonSocial, Nothing)
        End If
    End Sub

    'Valido que ingrese solo numeros en el campo de telefono.
    Private Sub txt_Telefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Telefono.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    'Valido que ingrese el nombre. - modificacion
    Private Sub txt_Nombre_mod_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_Nombre_mod.Validating
        If txt_Nombre_mod.Text = "" Then
            ErrorProveedor.SetError(txt_Nombre_mod, "Debe completar el Nombre.")
        Else
            ErrorProveedor.SetError(txt_Nombre_mod, Nothing)
        End If
    End Sub

    'Valido que ingrese el mail. - modificacion
    Private Sub txt_Mail_mod_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_Mail_mod.Validating
        If txt_Mail_mod.Text = "" Then
            ErrorProveedor.SetError(txt_Mail_mod, "Debe completar el Mail.")
        Else
            ErrorProveedor.SetError(txt_Mail_mod, Nothing)
        End If
    End Sub

    'Valido que ingrese la razon social. - modificacion
    Private Sub txt_RazonSocial_mod_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_RazonSocial_mod.Validating
        If txt_RazonSocial_mod.Text = "" Then
            ErrorProveedor.SetError(txt_RazonSocial_mod, "Debe completar la Razon Social.")
        Else
            ErrorProveedor.SetError(txt_RazonSocial_mod, Nothing)
        End If
    End Sub

    'Valido que ingrese solo numeros en el campo de telefono. - modificacion
    Private Sub txt_Telefono_mod_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Telefono_mod.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
#End Region

#Region "Región de Eventos"

    'Load del Formulario
    Private Sub frmProveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            'seteo el font a 8px
            DG_Proveedores.AlternatingRowsDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DG_Proveedores.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DG_Proveedores.RowHeadersDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DG_Proveedores.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

            'seteo las imagenes
            Dim ListaImagenes = New ImageList
            ListaImagenes.ImageSize = New Size(32, 32)
            ListaImagenes.TransparentColor = Color.Blue
            ListaImagenes.ColorDepth = ColorDepth.Depth32Bit

            ListaImagenes.Images.Add(My.Resources.Recursos.Proveedores_2)
            ListaImagenes.Images.Add(My.Resources.Recursos.IconoADD)
            ListaImagenes.Images.Add(My.Resources.Recursos.Lapiz)

            TabProveedores.ImageList = ListaImagenes

            'icono de listado
            TbListado.ImageIndex = 0
            'icono de alta
            TbAlta.ImageIndex = 1
            'icono de edicion
            TbMod.ImageIndex = 2

            'Cargo el datagrid
            Dim dsProveedores As New DataSet
            dsProveedores = Negproveedores.ListadoProveedoresCompleto()
            If dsProveedores.Tables(0).Rows.Count > 0 Then
                DG_Proveedores.DataSource = dsProveedores.Tables(0)
                DG_Proveedores.AutoGenerateColumns = False
                DG_Proveedores.ColumnHeadersVisible = True
                DG_Proveedores.Columns("Modificar").DisplayIndex = 7
                DG_Proveedores.Columns("id_Proveedor").Visible = False
                DG_Proveedores.Columns("RazonSocial").Visible = False
                DG_Proveedores.Columns("Eliminar").DisplayIndex = 7
                DG_Proveedores.Refresh()
                lbl_Msg.Visible = False
            Else
                DG_Proveedores.ColumnHeadersVisible = False
                DG_Proveedores.DataSource = Nothing
                DG_Proveedores.Refresh()
                lbl_Msg.Visible = True
            End If

            'agregado para el funcionamiento de patentes
            Dim objusuario As New Negocio.Usuario

            '220 visualiza Proveedores - si llego aca puede visualizarlos
            '218 crea Proveedor
            If (objusuario.EsPatenteValida(218, VariablesGlobales.Patentes)) Then
            Else
                TabProveedores.TabPages.Remove(Me.TbAlta)
            End If
            '219 modifica Proveedor
            If (objusuario.EsPatenteValida(219, VariablesGlobales.Patentes)) Then
            Else
                TabProveedores.TabPages.Remove(Me.TbMod)
                DG_Proveedores.Columns("Modificar").Visible = False
            End If
            '221 elimina Proveedor
            If (objusuario.EsPatenteValida(221, VariablesGlobales.Patentes)) Then
            Else
                TabProveedores.TabPages.Remove(Me.TbMod)
                DG_Proveedores.Columns("Eliminar").Visible = False
            End If

            'Cambio el cursor a NORMAL.
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha encontrado un error al cargar el listado de proveedores.", "Administración de Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Cuando hace click en el listado de proveedores
    Private Sub DG_Proveedores_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Proveedores.CellContentClick
        If DG_Proveedores.Columns(e.ColumnIndex).Name = "Eliminar" Then 'Si se hace click en el boton "eliminar" de la fila.
            Dim Result As DialogResult
            Result = MessageBox.Show("¿Está seguro que desea eliminar el proveedor?", "Administración de Proveedores", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Result = System.Windows.Forms.DialogResult.Yes Then 'Si acepta eliminar el item

                'Cambio el cursor a "WAIT"
                Me.Cursor = Cursors.WaitCursor

                Dim id_Proveedor As Integer = DG_Proveedores.Rows(e.RowIndex).Cells("id_Proveedor").Value
                If id_Proveedor = 0 Then
                    'si no completo la descripcion, muestro un msg de error.
                    MessageBox.Show("No se puede eliminar el empleado.", "Administración de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    'ejecuto el sp_EliminarProveedor.
                    MessageBox.Show(Negproveedores.EliminarProveedor(id_Proveedor), "Administración de Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    'refresco el datagrid
                    DG_Proveedores.DataSource = Negproveedores.ListadoProveedoresCompleto().Tables(0)
                    DG_Proveedores.Refresh()
                End If

                'Cambio el cursor a NORMAL.
                Me.Cursor = Cursors.Arrow
            End If
        ElseIf DG_Proveedores.Columns(e.ColumnIndex).Name = "Modificar" Then 'Si se hace click en el boton "modificar" de la fila.

            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            Dim id_Proveedor As Integer = DG_Proveedores.Rows(e.RowIndex).Cells("id_Proveedor").Value()
            EProveedor.id_Proveedor = id_Proveedor

            'lleno la entidad proveedor
            EProveedor = Negproveedores.TraerProveedor(id_Proveedor)

            'lleno los controls del tab_modificacion
            txt_Nombre_mod.Text = EProveedor.Nombre
            txt_Telefono_mod.Text = EProveedor.Telefono
            txt_RazonSocial_mod.Text = EProveedor.RazonSocial
            txt_Direccion_mod.Text = EProveedor.Direccion
            txt_Mail_mod.Text = EProveedor.Mail
            txt_MailAlternativo_mod.Text = EProveedor.Mail_Alternativo
            txt_Direccion_mod.Text = EProveedor.Direccion

            If EProveedor.Habilitado = "1" Then
                chk_Habilitado_mod.Checked = True
            Else
                chk_Habilitado_mod.Checked = False
            End If

            'Cargo el combo de Condiciones de IVA
            Dim dsCondiciones As New DataSet
            dsCondiciones = Negcondiciones.ListadoCondiciones()
            If dsCondiciones.Tables(0).Rows.Count > 0 Then
                cb_CondicionIva_mod.DataSource = Nothing
                cb_CondicionIva_mod.DataSource = dsCondiciones.Tables(0)
                cb_CondicionIva_mod.DisplayMember = "Descripcion"
                cb_CondicionIva_mod.ValueMember = "id_CondicionIva"
                cb_CondicionIva_mod.SelectedValue = EProveedor.id_CondicionIva
                cb_CondicionIva_mod.Refresh()
            End If

            'Cambio el cursor a NORMAL.
            Me.Cursor = Cursors.Arrow

            'hago foco en el tab_modificacion 
            TabProveedores.SelectedIndex = 2
        End If
    End Sub

    'Cuando Cambia el tab seleccionado
    Private Sub TabProveedores_Selected(ByVal sender As Object, ByVal e As System.Windows.Forms.TabControlEventArgs) Handles TabProveedores.Selected
        'Cambio el cursor a "WAIT"
        Me.Cursor = Cursors.WaitCursor

        If TabProveedores.SelectedIndex = 0 Then 'TAB LISTADO

            'Cargo el datagrid
            Dim dsProveedores As New DataSet
            dsProveedores = Negproveedores.ListadoProveedoresCompleto()
            If dsProveedores.Tables(0).Rows.Count > 0 Then
                DG_Proveedores.DataSource = dsProveedores.Tables(0)
                DG_Proveedores.AutoGenerateColumns = False
                DG_Proveedores.ColumnHeadersVisible = True
                DG_Proveedores.Columns("Modificar").DisplayIndex = 7
                DG_Proveedores.Columns("id_Proveedor").Visible = False
                DG_Proveedores.Columns("RazonSocial").Visible = False
                DG_Proveedores.Columns("Eliminar").DisplayIndex = 7
                DG_Proveedores.Refresh()
                lbl_Msg.Visible = False
            Else
                DG_Proveedores.ColumnHeadersVisible = False
                DG_Proveedores.DataSource = Nothing
                DG_Proveedores.Refresh()
                lbl_Msg.Visible = True
            End If

            'Limpio los formularios
            LimpiarFormAltaProveedores()
            LimpiarFormModificacionProveedores()

            'Seteo el id_Proveedor en cero
            EProveedor.id_Proveedor = 0

        ElseIf TabProveedores.SelectedIndex = 1 Then 'TAB ALTA

            'Cargo el combo de Condiciones de IVA
            Dim dsCondiciones As New DataSet
            dsCondiciones = Negcondiciones.ListadoCondiciones()
            If dsCondiciones.Tables(0).Rows.Count > 0 Then
                cb_CondicionIva.DataSource = Nothing
                cb_CondicionIva.DataSource = dsCondiciones.Tables(0)
                cb_CondicionIva.DisplayMember = "Descripcion"
                cb_CondicionIva.ValueMember = "id_CondicionIva"
                cb_CondicionIva.Refresh()
            End If

            'Limpio el formulario de alta.
            LimpiarFormAltaProveedores()

            'Seteo el id_Proveedor en cero
            EProveedor.id_Proveedor = 0

        ElseIf TabProveedores.SelectedIndex = 2 Then 'TAB MODIFICACION
            If EProveedor.id_Proveedor <= 0 Or EProveedor.id_Proveedor = Nothing Then
                MessageBox.Show("Debe seleccionar previamente un proveedor.", "Administración de Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                TabProveedores.SelectedIndex = 0
            End If
        End If

        'Cambio el cursor a NORMAL.
        Me.Cursor = Cursors.Arrow
    End Sub

    'Boton buscar en listado de proveedores.
    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        'Seteo las variables.
        Dim descrip As String
        descrip = Trim(txt_buscar.Text.ToLower)

        If descrip = "" Then
            ErrorProveedor.SetError(txt_buscar, "Debe completar el campo de busqueda.")
        Else
            ErrorProveedor.SetError(txt_buscar, Nothing)

            Dim dv As DataView
            dv = Negproveedores.ListadoProveedoresCompleto().Tables(0).DefaultView

            'filtro el dataset por la descripcion que se va ingresando
            dv.RowFilter = "RazonSocial LIKE '%" + descrip + "%'"
            If dv.Count > 0 Then
                DG_Proveedores.ColumnHeadersVisible = True
                DG_Proveedores.DataSource = Nothing
                DG_Proveedores.DataSource = dv
                DG_Proveedores.Refresh()
                lbl_Msg.Visible = False
            Else
                DG_Proveedores.ColumnHeadersVisible = False
                DG_Proveedores.DataSource = Nothing
                DG_Proveedores.Refresh()
                lbl_Msg.Visible = True
            End If

        End If
    End Sub

    'Boton que Elimina el proveedor.
    Private Sub Btn_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Eliminar.Click
        Dim Result As DialogResult
        Result = MessageBox.Show("¿Está seguro que desea eliminar el proveedor?", "Administración de Proveedores", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If Result = System.Windows.Forms.DialogResult.Yes Then 'Si acepta eliminar el item

            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            Dim id_Proveedor As Integer = EProveedor.id_Proveedor
            If id_Proveedor = 0 Then
                'si no completo la descripcion, muestro un msg de error.
                MessageBox.Show("No se puede eliminar el proveedor.", "Administración de Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                'ejecuto el sp_EliminarColores.
                MessageBox.Show(Negproveedores.EliminarProveedor(id_Proveedor), "Administración de Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Information)

                'redirecciona al tab_listado
                TabProveedores.SelectedIndex = 0
            End If

            'Cambio el cursor a NORMAL.
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    'Boton que Modifica el proveedor.
    Private Sub Btn_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Modificar.Click
        If txt_Nombre_mod.Text = "" Or txt_RazonSocial_mod.Text = "" Or txt_Mail_mod.Text = "" Or cb_CondicionIva_mod.SelectedItem Is Nothing Then
            MessageBox.Show("Debe completar los campos requeridos.", "Administración de Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                Me.Cursor = Cursors.WaitCursor

                'Lleno la entidad empleado
                EProveedor.Nombre = Trim(txt_Nombre_mod.Text)
                EProveedor.RazonSocial = Trim(txt_RazonSocial_mod.Text)
                EProveedor.Telefono = Trim(txt_Telefono_mod.Text)
                EProveedor.Mail = Trim(txt_Mail_mod.Text)
                EProveedor.Mail_Alternativo = Trim(txt_MailAlternativo_mod.Text)
                EProveedor.Direccion = Trim(txt_Direccion_mod.Text)
                EProveedor.id_CondicionIva = Trim(cb_CondicionIva_mod.SelectedValue)

                If chk_Habilitado_mod.Checked = True Then
                    EProveedor.Habilitado = 1
                Else
                    EProveedor.Habilitado = 0
                End If

                Me.Cursor = Cursors.Arrow

                'Ejecuto el sp_Clientes_Alta
                MessageBox.Show(Negproveedores.ModificacionProveedor(EProveedor), "Administración de Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Information)

                'Limpio el formulario
                LimpiarFormModificacionProveedores()

                'Redirecciono al listado
                TabProveedores.SelectedIndex = 0

            Catch ex As Exception
                Me.Cursor = Cursors.Arrow
                MessageBox.Show("Se ha producido un error al modificar el proveedor. Por favor, intente más tarde.", "Administración de Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    'Boton que Crea el proveedor.
    Private Sub Btn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Agregar.Click
        If txt_Nombre.Text = "" Or txt_Mail.Text = "" Or txt_RazonSocial.Text = "" Or cb_CondicionIva.SelectedItem Is Nothing Then
            MessageBox.Show("Debe completar los campos requeridos.", "Administración de Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                Me.Cursor = Cursors.WaitCursor

                'Lleno la entidad empleado
                EProveedor.Nombre = Trim(txt_Nombre.Text)
                EProveedor.RazonSocial = Trim(txt_RazonSocial.Text)
                EProveedor.Telefono = Trim(txt_Telefono.Text)
                EProveedor.Mail = Trim(txt_Mail.Text)
                EProveedor.Mail_Alternativo = Trim(txt_MailAlternativo.Text)
                EProveedor.Direccion = Trim(txt_Direccion.Text)
                EProveedor.id_CondicionIva = cb_CondicionIva.SelectedValue

                If chk_Habilitado.Checked = True Then
                    EProveedor.Habilitado = 1
                Else
                    EProveedor.Habilitado = 0
                End If

                Me.Cursor = Cursors.Arrow

                'Ejecuto el sp_Empleados_Alta
                MessageBox.Show(Negproveedores.AltaProveedor(EProveedor), "Administración de Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Information)

                'Limpio el formulario
                LimpiarFormAltaProveedores()
            Catch ex As Exception
                Me.Cursor = Cursors.Arrow
                MessageBox.Show("Se ha producido un error al registrar el proveedor. Por favor, intente más tarde.", "Administración de Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If        
    End Sub

    'Restablecer los filtros en listado de proveedores.
    Private Sub btn_Restablecer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Restablecer.Click
        Try
            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            'Cargo el datagrid
            Dim dsProveedores As New DataSet
            dsProveedores = Negproveedores.ListadoProveedoresCompleto()
            If dsProveedores.Tables(0).Rows.Count > 0 Then
                DG_Proveedores.DataSource = dsProveedores.Tables(0)
                DG_Proveedores.AutoGenerateColumns = False
                DG_Proveedores.ColumnHeadersVisible = True
                DG_Proveedores.Columns("Modificar").DisplayIndex = 7
                DG_Proveedores.Columns("id_Proveedor").Visible = False
                DG_Proveedores.Columns("RazonSocial").Visible = False
                DG_Proveedores.Columns("Eliminar").DisplayIndex = 7
                DG_Proveedores.Refresh()
                lbl_Msg.Visible = False
            Else
                DG_Proveedores.ColumnHeadersVisible = False
                DG_Proveedores.DataSource = Nothing
                DG_Proveedores.Refresh()
                lbl_Msg.Visible = True
            End If

            'Borro campo busqueda y hago foco.
            txt_buscar.Clear()
            txt_buscar.Focus()

            'Cambio el cursor a NORMAL.
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha encontrado un error al cargar el listado de proveedores.", "Administración de Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Doble click en el listado de proveedores.
    Private Sub DG_Proveedores_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Proveedores.CellDoubleClick
        If DG_Proveedores.SelectedRows.Count > 0 Then
            If e.RowIndex >= 0 Then
                'Cambio el cursor a "WAIT"
                Me.Cursor = Cursors.WaitCursor

                Dim id_Proveedor As Integer = DG_Proveedores.Rows(e.RowIndex).Cells("id_Proveedor").Value()
                EProveedor.id_Proveedor = id_Proveedor

                'lleno la entidad proveedor
                EProveedor = Negproveedores.TraerProveedor(id_Proveedor)

                'lleno los controls del tab_modificacion
                txt_Nombre_mod.Text = EProveedor.Nombre
                txt_Telefono_mod.Text = EProveedor.Telefono
                txt_RazonSocial_mod.Text = EProveedor.RazonSocial
                txt_Direccion_mod.Text = EProveedor.Direccion
                txt_Mail_mod.Text = EProveedor.Mail
                txt_MailAlternativo_mod.Text = EProveedor.Mail_Alternativo
                txt_Direccion_mod.Text = EProveedor.Direccion

                If EProveedor.Habilitado = "1" Then
                    chk_Habilitado_mod.Checked = True
                Else
                    chk_Habilitado_mod.Checked = False
                End If

                'Cargo el combo de Condiciones de IVA
                Dim dsCondiciones As New DataSet
                dsCondiciones = Negcondiciones.ListadoCondiciones()
                If dsCondiciones.Tables(0).Rows.Count > 0 Then
                    cb_CondicionIva_mod.DataSource = Nothing
                    cb_CondicionIva_mod.DataSource = dsCondiciones.Tables(0)
                    cb_CondicionIva_mod.DisplayMember = "Descripcion"
                    cb_CondicionIva_mod.ValueMember = "id_CondicionIva"
                    cb_CondicionIva_mod.SelectedValue = EProveedor.id_CondicionIva
                    cb_CondicionIva_mod.Refresh()
                End If

                'Cambio el cursor a NORMAL.
                Me.Cursor = Cursors.Arrow

                'hago foco en el tab_modificacion 
                TabProveedores.SelectedIndex = 2
            End If
        End If
    End Sub

    Private Sub Btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cancelar.Click
        TabProveedores.SelectedIndex = 0
    End Sub
#End Region

End Class