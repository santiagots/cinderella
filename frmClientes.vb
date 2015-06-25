Public Class frmClientes
    Dim NegClientes As New Negocio.NegClientes
    Dim NegProvincias As New Negocio.NegProvincias
    Dim NegDistritos As New Negocio.NegDistritos
    Dim NegLocalidades As New Negocio.NegLocalidades
    Dim NegListasPrecio As New Negocio.NegListasPrecio
    Dim NegCondicionesIva As New Negocio.NegCondicionesIva
    Dim NegErrores As New Negocio.NegManejadorErrores
    Public EClientes As New Entidades.Clientes
    Dim Funciones As New Funciones

#Region "Region Validaciones"
    'Valido que se complete la razon social.
    Private Sub txt_RazonSocial_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_RazonSocial.Validating
        If txt_RazonSocial.Text = "" Then
            ErroresClie.SetError(txt_RazonSocial, "Debe completar la Razon Social.")
        Else
            ErroresClie.SetError(txt_RazonSocial, Nothing)
        End If
    End Sub

    'Valido que se complete el cuit y además que sea correcto.
    Private Sub txt_Cuit_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If txt_Cuit.Text = "" Then
            ErroresClie.SetError(txt_Cuit, "Debe completar el número de CUIT.")
        ElseIf Not NegErrores.ValidarCuit(Trim(txt_Cuit.Text)) Then
            ErroresClie.SetError(txt_Cuit, "El CUIT ingresado es incorrecto.")
        Else
            ErroresClie.SetError(txt_Cuit, Nothing)
        End If
    End Sub

    'Valido que se complete el mail y que además este en formato correcto.
    Private Sub txt_Mail_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_Mail.Validating
        If txt_Mail.Text = "" Then
            ErroresClie.SetError(txt_Mail, "Debe completar el Mail.")
        ElseIf Not NegErrores.validar_Mail(txt_Mail.Text) Then
            ErroresClie.SetError(txt_Mail, "Debe ingresar un mail válido.")
        Else
            ErroresClie.SetError(txt_Mail, Nothing)
        End If
    End Sub

    'Valido que sea solo numeros.
    Private Sub txt_CodigoPostal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_CodigoPostal.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    'Valido que ingrese el codigo postal y que además sea solo numeros.
    Private Sub txt_CodigoPostal_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_CodigoPostal.Validating

        If txt_CodigoPostal.Text = "" Then
            ErroresClie.SetError(txt_CodigoPostal, "Debe completar el Código Postal.")
        Else
            ErroresClie.SetError(txt_CodigoPostal, Nothing)
        End If
    End Sub

    'valido que ingrese la direccion.
    Private Sub txt_Direccion_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_Direccion.Validating
        If txt_Direccion.Text = "" Then
            ErroresClie.SetError(txt_Direccion, "Debe completar la Dirección.")
        Else
            ErroresClie.SetError(txt_Direccion, Nothing)
        End If
    End Sub

    'valido que se ingrese solo numeros.
    Private Sub txt_Telefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Telefono.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    'Valido que se complete la razon social.
    Private Sub txt_RazonSocial_mod_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_RazonSocial_mod.Validating
        If txt_RazonSocial_mod.Text = "" Then
            ErroresClie.SetError(txt_RazonSocial_mod, "Debe completar la Razon Social.")
        Else
            ErroresClie.SetError(txt_RazonSocial_mod, Nothing)
        End If
    End Sub

    'Valido que se complete el cuit.
    Private Sub txt_Cuit_mod_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If txt_cuit_mod.Text = "" Then
            ErroresClie.SetError(txt_cuit_mod, "Debe completar el número de CUIT.")
        ElseIf Not NegErrores.ValidarCuit(Trim(txt_cuit_mod.Text)) Then
            ErroresClie.SetError(txt_cuit_mod, "El CUIT ingresado es incorrecto.")
        Else
            ErroresClie.SetError(txt_cuit_mod, Nothing)
        End If
    End Sub

    'Valido que se complete el mail y que además este en formato correcto.
    Private Sub txt_Mail_mod_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_Mail_mod.Validating
        If txt_Mail_mod.Text = "" Then
            ErroresClie.SetError(txt_Mail_mod, "Debe completar el Mail.")
        ElseIf Not NegErrores.validar_Mail(txt_Mail_mod.Text) Then
            ErroresClie.SetError(txt_Mail_mod, "Debe ingresar un mail válido.")
        Else
            ErroresClie.SetError(txt_Mail_mod, Nothing)
        End If
    End Sub

    'Valido que sea solo numeros.
    Private Sub txt_CodigoPostal_mod_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_CodigoPostal_mod.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    'Valido que ingrese el codigo postal y que además sea solo numeros.
    Private Sub txt_CodigoPostal_mod_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_CodigoPostal_mod.Validating
        If txt_CodigoPostal_mod.Text = "" Then
            ErroresClie.SetError(txt_CodigoPostal_mod, "Debe completar el Código Postal.")
        Else
            ErroresClie.SetError(txt_CodigoPostal_mod, Nothing)
        End If
    End Sub

    'valido que ingrese la direccion.
    Private Sub txt_Direccion_mod_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_Direccion_mod.Validating
        If txt_Direccion_mod.Text = "" Then
            ErroresClie.SetError(txt_Direccion_mod, "Debe completar la Dirección.")
        Else
            ErroresClie.SetError(txt_Direccion_mod, Nothing)
        End If
    End Sub

    'valido que se ingrese solo numeros.
    Private Sub txt_Telefono_mod_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Telefono_mod.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

#End Region

#Region "Region Funciones"

    'Limpia el formulario de Alta.
    Sub LimpiarFormAltaClientes()
        ErroresClie.Clear()
        txt_RazonSocial.Clear()
        txt_Telefono.Clear()
        txt_Transporte.Clear()
        txt_Observaciones.Clear()
        txt_Mail.Clear()
        txt_Contacto.Clear()
        txt_Cuit.Clear()
        txt_CodigoPostal.Clear()
        txt_Direccion.Clear()
        cb_Provincia.SelectedItem = Nothing
        cb_ListaPrecios.SelectedItem = Nothing
        cb_Localidad.SelectedItem = Nothing
        cb_Distrito.SelectedItem = Nothing
        cb_CondicionIva.SelectedItem = Nothing
        chk_Habilitado.Checked = True
    End Sub

    'Limpia el formulario de Modificacion.
    Sub LimpiarFormModificacionClientes()
        ErroresClie.Clear()
        txt_RazonSocial_mod.Clear()
        txt_Telefono_mod.Clear()
        txt_Transporte_mod.Clear()
        txt_Observaciones_mod.Clear()
        txt_Mail_mod.Clear()
        txt_Contacto_mod.Clear()
        txt_Cuit_mod.Clear()
        txt_CodigoPostal_mod.Clear()
        txt_Direccion_mod.Clear()
        cb_Provincia_mod.SelectedItem = Nothing
        cb_ListaPrecios_mod.SelectedItem = Nothing
        cb_Localidad_mod.SelectedItem = Nothing
        cb_Distrito_mod.SelectedItem = Nothing
        cb_CondicionIva_mod.SelectedItem = Nothing
        chk_Habilitado_mod.Checked = True
    End Sub

#End Region

#Region "Region Carga de combos"
    'Cargo el combo de Localidades.
    Private Sub cb_Distrito_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_Distrito.SelectionChangeCommitted
        If cb_Provincia.SelectedValue <> 0 Then
            Dim dsLocalidades As New DataSet
            dsLocalidades = NegLocalidades.ListadoLocalidades(cb_Distrito.SelectedValue)
            If dsLocalidades.Tables(0).Rows.Count > 0 Then
                cb_Localidad.DataSource = Nothing
                cb_Localidad.DataSource = dsLocalidades.Tables(0)
                cb_Localidad.DisplayMember = "Descripcion"
                cb_Localidad.ValueMember = "id_Localidad"
                cb_Localidad.Refresh()
            End If
        End If
    End Sub

    'Cargo el combo de Provincias.
    Private Sub cb_Provincia_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_Provincia.GotFocus
        Dim dsProvincias As New DataSet
        dsProvincias = NegProvincias.ListadoProvincias()
        If dsProvincias.Tables(0).Rows.Count > 0 Then
            cb_Provincia.DataSource = Nothing
            cb_Provincia.DataSource = dsProvincias.Tables(0)
            cb_Provincia.DisplayMember = "Descripcion"
            cb_Provincia.ValueMember = "id_Provincia"
            cb_Provincia.Refresh()
            cb_Localidad.DataSource = Nothing
            cb_Localidad.Refresh()
        End If
    End Sub

    'Cargo el combo de Condiciones de iva.
    Private Sub cb_CondicionIva_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_CondicionIva.GotFocus
        Dim dsCondiciones As New DataSet
        dsCondiciones = NegCondicionesIva.ListadoCondiciones()
        If dsCondiciones.Tables(0).Rows.Count > 0 Then
            cb_CondicionIva.DataSource = Nothing
            cb_CondicionIva.DataSource = dsCondiciones.Tables(0)
            cb_CondicionIva.DisplayMember = "Descripcion"
            cb_CondicionIva.ValueMember = "id_CondicionIva"
            cb_CondicionIva.Refresh()
        End If
    End Sub

    'Cargo el combo de Precios.
    Private Sub cb_ListaPrecios_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_ListaPrecios.GotFocus
        Dim dsListas As New DataSet
        dsListas = NegListasPrecio.ListadoListasPrecios()
        If dsListas.Tables(0).Rows.Count > 0 Then
            cb_ListaPrecios.DataSource = Nothing
            cb_ListaPrecios.DataSource = dsListas.Tables(0)
            cb_ListaPrecios.DisplayMember = "ListaPrecio"
            cb_ListaPrecios.ValueMember = "id_Lista"
            cb_ListaPrecios.Refresh()
        End If
    End Sub

    'Cargo el combo de Distritos.
    Private Sub cb_Provincia_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_Provincia.SelectionChangeCommitted
        If cb_Provincia.SelectedValue <> 0 Then
            Dim dsProvincias As New DataSet
            dsProvincias = NegDistritos.ListadoDistritos(cb_Provincia.SelectedValue)
            If dsProvincias.Tables(0).Rows.Count > 0 Then
                cb_Distrito.DataSource = Nothing
                cb_Distrito.DataSource = dsProvincias.Tables(0)
                cb_Distrito.DisplayMember = "Descripcion"
                cb_Distrito.ValueMember = "id_Departamento"
                cb_Distrito.Refresh()
            End If
        End If
    End Sub

    'Cargo el combo de Localidades.
    Private Sub cb_Distrito_mod_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_Distrito_mod.SelectionChangeCommitted
        If cb_Provincia_mod.SelectedValue <> 0 Then
            Dim dsLocalidades As New DataSet
            dsLocalidades = NegLocalidades.ListadoLocalidades(cb_Distrito_mod.SelectedValue)
            If dsLocalidades.Tables(0).Rows.Count > 0 Then
                cb_Localidad_mod.DataSource = Nothing
                cb_Localidad_mod.DataSource = dsLocalidades.Tables(0)
                cb_Localidad_mod.DisplayMember = "Descripcion"
                cb_Localidad_mod.ValueMember = "id_Localidad"
                cb_Localidad_mod.Refresh()
            End If
        End If
    End Sub

    'Cargo el combo de Provincias.
    Private Sub cb_Provincia_mod_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_Provincia_mod.GotFocus
        Dim dsProvincias As New DataSet
        dsProvincias = NegProvincias.ListadoProvincias()
        If dsProvincias.Tables(0).Rows.Count > 0 Then
            cb_Provincia_mod.DataSource = Nothing
            cb_Provincia_mod.DataSource = dsProvincias.Tables(0)
            cb_Provincia_mod.DisplayMember = "Descripcion"
            cb_Provincia_mod.ValueMember = "id_Provincia"
            cb_Provincia_mod.Refresh()
            cb_Localidad_mod.DataSource = Nothing
            cb_Localidad_mod.Refresh()
        End If
    End Sub

    'Cargo el combo de Condiciones de iva.
    Private Sub cb_CondicionIva_mod_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_CondicionIva_mod.GotFocus
        Dim dsCondiciones As New DataSet
        dsCondiciones = NegCondicionesIva.ListadoCondiciones()
        If dsCondiciones.Tables(0).Rows.Count > 0 Then
            cb_CondicionIva_mod.DataSource = Nothing
            cb_CondicionIva_mod.DataSource = dsCondiciones.Tables(0)
            cb_CondicionIva_mod.DisplayMember = "Descripcion"
            cb_CondicionIva_mod.ValueMember = "id_CondicionIva"
            cb_CondicionIva_mod.Refresh()
        End If
    End Sub

    'Cargo el combo de Precios.
    Private Sub cb_ListaPrecios_mod_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_ListaPrecios_mod.GotFocus
        Dim dsListas As New DataSet
        dsListas = NegListasPrecio.ListadoListasPrecios()
        If dsListas.Tables(0).Rows.Count > 0 Then
            cb_ListaPrecios_mod.DataSource = Nothing
            cb_ListaPrecios_mod.DataSource = dsListas.Tables(0)
            cb_ListaPrecios_mod.DisplayMember = "ListaPrecio"
            cb_ListaPrecios_mod.ValueMember = "id_Lista"
            cb_ListaPrecios_mod.Refresh()
        End If
    End Sub

    'Cargo el combo de Distritos.
    Private Sub cb_Provincia_mod_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_Provincia_mod.SelectionChangeCommitted
        If cb_Provincia_mod.SelectedValue <> 0 Then
            Dim dsDistritos As New DataSet
            dsDistritos = NegDistritos.ListadoDistritos(cb_Provincia_mod.SelectedValue)
            If dsDistritos.Tables(0).Rows.Count > 0 Then
                cb_Distrito_mod.DataSource = Nothing
                cb_Distrito_mod.DataSource = dsDistritos.Tables(0)
                cb_Distrito_mod.DisplayMember = "Descripcion"
                cb_Distrito_mod.ValueMember = "id_Departamento"
                cb_Distrito_mod.Refresh()
            End If
        End If
    End Sub

#End Region

#Region "Region Eventos"

    'Load del Formulario.
    Private Sub frmClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            'seteo el font a 8px
            DG_Clientes.AlternatingRowsDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DG_Clientes.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DG_Clientes.RowHeadersDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DG_Clientes.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

            'seteo las imagenes
            Dim ListaImagenes = New ImageList
            ListaImagenes.ImageSize = New Size(32, 32)
            ListaImagenes.TransparentColor = Color.Blue
            ListaImagenes.ColorDepth = ColorDepth.Depth32Bit

            ListaImagenes.Images.Add(My.Resources.Recursos.Clientes)
            ListaImagenes.Images.Add(My.Resources.Recursos.IconoADD)
            ListaImagenes.Images.Add(My.Resources.Recursos.Lapiz)

            TabClientes.ImageList = ListaImagenes

            'icono de clientes
            TbListado.ImageIndex = 0
            'icono de alta
            TbAlta.ImageIndex = 1
            'icono de edicion
            TbMod.ImageIndex = 2

            'Cargo el datagrid
            Dim dsClientes As New DataSet
            dsClientes = NegClientes.ListadoClientesCompleto()
            If (dsClientes.Tables(0).Rows.Count <> 0) Then
                DG_Clientes.DataSource = dsClientes.Tables(0)
                DG_Clientes.AutoGenerateColumns = False
                DG_Clientes.Columns("RazonSocial").DisplayIndex = 1
                DG_Clientes.Columns("Mail").DisplayIndex = 2
                DG_Clientes.Columns("Telefono").DisplayIndex = 3
                DG_Clientes.Columns("Direccion").Visible = False
                DG_Clientes.Columns("Cuit").Visible = False
                DG_Clientes.Columns("id_Cliente").Visible = False
                DG_Clientes.Columns("Modificar").DisplayIndex = 9
                DG_Clientes.Columns("Eliminar").DisplayIndex = 9
                DG_Clientes.Columns("Compras").DisplayIndex = 9
                DG_Clientes.Refresh()
            End If

            'agregado para el funcionamiento de patentes
            Dim objusuario As New Negocio.Usuario
            '19 visualiza clientes - si llego aca puede visualizarlos
            '17 crea cliente
            If (objusuario.EsPatenteValida(17, VariablesGlobales.Patentes)) Then
            Else
                TabClientes.TabPages.Remove(Me.TbAlta)
            End If
            '18 modifica cliente
            If (objusuario.EsPatenteValida(18, VariablesGlobales.Patentes)) Then
            Else
                TabClientes.TabPages.Remove(Me.TbMod)
                DG_Clientes.Columns("Modificar").Visible = False
            End If
            '20 elimina cliente
            If (objusuario.EsPatenteValida(20, VariablesGlobales.Patentes)) Then
            Else
                TabClientes.TabPages.Remove(Me.TbMod)
                DG_Clientes.Columns("Eliminar").Visible = False
            End If

            'Cambio el cursor a NORMAL.
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha encontrado un error al cargar el listado de clientes.", "Administración de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cancelar.Click
        'Redirecciono al listado
        TabClientes.SelectedIndex = 0
    End Sub

    'Solapas.
    Private Sub TabClientes_Selected(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabClientes.Selected
        'Cambio el cursor a "WAIT"
        Me.Cursor = Cursors.WaitCursor

        If TabClientes.SelectedIndex = 0 Then 'TAB LISTADO DE CLIENTE
            'Actualizo el datagrid si se selecciona el tab del listado
            Dim dsClientes As New DataSet
            dsClientes = NegClientes.ListadoClientesCompleto()
            If (dsClientes.Tables(0).Rows.Count > 0) Then
                DG_Clientes.DataSource = dsClientes.Tables(0)
                DG_Clientes.AutoGenerateColumns = False
                DG_Clientes.Columns("RazonSocial").DisplayIndex = 1
                DG_Clientes.Columns("Mail").DisplayIndex = 2
                DG_Clientes.Columns("Telefono").DisplayIndex = 3
                DG_Clientes.Columns("Direccion").Visible = False
                DG_Clientes.Columns("Cuit").Visible = False
                DG_Clientes.Columns("id_Cliente").Visible = False
                DG_Clientes.Columns("Modificar").DisplayIndex = 9
                DG_Clientes.Columns("Eliminar").DisplayIndex = 9
                DG_Clientes.Columns("Compras").DisplayIndex = 9
                DG_Clientes.Refresh()
            End If

            'Limpio los formularios
            LimpiarFormAltaClientes()
            LimpiarFormModificacionClientes()

            'Seteo el id_CLiente en cero
            EClientes.id_Cliente = 0

        ElseIf TabClientes.SelectedIndex = 1 Then 'TAB ALTA DE CLIENTE
            'Limpio el formulario de alta.
            LimpiarFormAltaClientes()

            'Seteo el id_CLiente en cero
            EClientes.id_Cliente = 0

        ElseIf TabClientes.SelectedIndex = 2 Then 'TAB MODIFICACION DE CLIENTE
            If EClientes.id_Cliente > 0 Or EClientes.id_Cliente <> Nothing Then

            Else
                MessageBox.Show("Debe seleccionar previamente un cliente.", "Administración de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                TabClientes.SelectedIndex = 0
            End If
        End If

        'Cambio el cursor a NORMAL.
        Me.Cursor = Cursors.Arrow
    End Sub

    'Boton Agregar Cliente.
    Private Sub Btn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Agregar.Click
        If txt_Direccion.Text = "" Or txt_CodigoPostal.Text = "" Or txt_Mail.Text = "" Or txt_Cuit.Text = "" Or txt_RazonSocial.Text = "" Or cb_Provincia.SelectedItem Is Nothing Or cb_Distrito.SelectedItem Is Nothing Or cb_Localidad.SelectedItem Is Nothing Or cb_CondicionIva.SelectedItem Is Nothing Or cb_ListaPrecios.SelectedItem Is Nothing Then
            MessageBox.Show("Debe completar los campos requeridos.", "Administración de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                'Lleno la entidad clientes
                EClientes.RazonSocial = Trim(txt_RazonSocial.Text)
                EClientes.Telefono = Trim(txt_Telefono.Text)
                EClientes.Transporte = Trim(txt_Transporte.Text)
                If txt_Observaciones.Text <> "" Then
                    EClientes.Observaciones = Replace(Trim(txt_Observaciones.Text), vbCrLf, "<br />")
                Else
                    EClientes.Observaciones = ""
                End If
                EClientes.Mail = Trim(txt_Mail.Text)
                EClientes.Contacto = Trim(txt_Contacto.Text)
                EClientes.Cuit = Trim(txt_Cuit.Text)
                EClientes.Codigo_Postal = Trim(txt_CodigoPostal.Text)
                EClientes.Direccion = Trim(txt_Direccion.Text)
                EClientes.id_Provincia = cb_Provincia.SelectedValue
                EClientes.id_Precio = cb_ListaPrecios.SelectedValue
                EClientes.id_Localidad = cb_Localidad.SelectedValue
                EClientes.id_Distrito = cb_Distrito.SelectedValue
                EClientes.id_CondicionIva = cb_CondicionIva.SelectedValue
                If chk_Habilitado.Checked = True Then
                    EClientes.Habilitado = 1
                Else
                    EClientes.Habilitado = 0
                End If

                'Ejecuto el sp_Clientes_Alta
                MessageBox.Show(NegClientes.AltaCliente(EClientes), "Administración de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("Se ha producido un error al registrar el cliente. Por favor, intente más tarde.", "Administración de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            'Limpio el formulario
            LimpiarFormAltaClientes()

        End If
    End Sub

    'Evento cuando realiza un click en el DG_Clientes.
    Private Sub DG_Clientes_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Clientes.CellContentClick
        If DG_Clientes.Columns(e.ColumnIndex).Name = "Eliminar" Then 'Si se hace click en el boton "eliminar" de la fila.
            Dim Result As DialogResult
            Result = MessageBox.Show("¿Está seguro que desea eliminar el cliente?", "Administración de Clientes", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If Result = System.Windows.Forms.DialogResult.Yes Then 'Si acepta eliminar el item
                Try
                    Dim id_Cliente As Integer = DG_Clientes.Rows(e.RowIndex).Cells("id_Cliente").Value
                    If id_Cliente = 0 Then
                        'si no completo la descripcion, muestro un msg de error.
                        MessageBox.Show("No se puede eliminar el cliente.", "Administración de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else
                        'Cambio el cursor a "WAIT"
                        Me.Cursor = Cursors.WaitCursor

                        'ejecuto el sp_EliminarColores.
                        MessageBox.Show(NegClientes.EliminarCliente(id_Cliente), "Administración de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        'Cargo el datagrid de cliente
                        Dim dsClientes As New DataSet
                        dsClientes = NegClientes.ListadoClientesCompleto()
                        If dsClientes.Tables(0).Rows.Count > 0 Then
                            DG_Clientes.DataSource = dsClientes.Tables(0)
                            DG_Clientes.AutoGenerateColumns = False
                            DG_Clientes.Columns("RazonSocial").DisplayIndex = 1
                            DG_Clientes.Columns("Mail").DisplayIndex = 2
                            DG_Clientes.Columns("Telefono").DisplayIndex = 3
                            DG_Clientes.Columns("Cuit").Visible = False
                            DG_Clientes.Columns("Modificar").DisplayIndex = 9
                            DG_Clientes.Columns("Eliminar").DisplayIndex = 9
                            DG_Clientes.Refresh()
                        End If
                    End If

                    'Cambio el cursor a NORMAL.
                    Me.Cursor = Cursors.Arrow

                Catch ex As Exception
                    Me.Cursor = Cursors.Arrow
                    MessageBox.Show("Se ha producido un error al eliminar el cliente.", "Administración de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        ElseIf DG_Clientes.Columns(e.ColumnIndex).Name = "Modificar" Then 'Si se hace click en el boton "modificar" de la fila.

            Try
                'Cambio el cursor a "WAIT"
                Me.Cursor = Cursors.WaitCursor

                Dim id_Cliente As Integer = DG_Clientes.Rows(e.RowIndex).Cells("id_Cliente").Value()
                EClientes.id_Cliente = id_Cliente

                'lleno la entidad colores
                EClientes = NegClientes.TraerCliente(id_Cliente)

                'lleno los controls del tab_modificacion
                txt_RazonSocial_mod.Text = EClientes.RazonSocial
                txt_Telefono_mod.Text = EClientes.Telefono
                txt_Transporte_mod.Text = EClientes.Transporte
                If EClientes.Observaciones <> "" Then
                    txt_Observaciones_mod.Text = Replace(Trim(EClientes.Observaciones), "<br />", vbCrLf)
                Else
                    txt_Observaciones_mod.Text = ""
                End If
                txt_Mail_mod.Text = EClientes.Mail
                txt_Contacto_mod.Text = EClientes.Contacto
                txt_Cuit_mod.Text = EClientes.Cuit
                txt_CodigoPostal_mod.Text = EClientes.Codigo_Postal
                txt_Direccion_mod.Text = EClientes.Direccion

                'Cargo el combo de Provincias
                Dim dsProvincias As New DataSet
                dsProvincias = NegProvincias.ListadoProvincias()
                If dsProvincias.Tables(0).Rows.Count > 0 Then
                    cb_Provincia_mod.DataSource = Nothing
                    cb_Provincia_mod.DataSource = dsProvincias.Tables(0)
                    cb_Provincia_mod.DisplayMember = "Descripcion"
                    cb_Provincia_mod.ValueMember = "id_Provincia"
                    cb_Provincia_mod.SelectedValue = EClientes.id_Provincia
                    cb_Provincia_mod.Refresh()
                End If

                'Cargo el combo de Distritos
                Dim dsDistritos As New DataSet
                dsDistritos = NegDistritos.ListadoDistritos(EClientes.id_Provincia)
                If dsDistritos.Tables(0).Rows.Count > 0 Then
                    cb_Distrito_mod.DataSource = Nothing
                    cb_Distrito_mod.DataSource = dsDistritos.Tables(0)
                    cb_Distrito_mod.DisplayMember = "Descripcion"
                    cb_Distrito_mod.ValueMember = "id_Departamento"
                    cb_Distrito_mod.SelectedValue = EClientes.id_Distrito
                    cb_Distrito_mod.Refresh()
                End If

                'Cargo el combo de Localidades
                Dim dsLocalidades As New DataSet
                dsLocalidades = NegLocalidades.ListadoLocalidades(EClientes.id_Distrito)
                If dsLocalidades.Tables(0).Rows.Count > 0 Then
                    cb_Localidad_mod.DataSource = Nothing
                    cb_Localidad_mod.DataSource = dsLocalidades.Tables(0)
                    cb_Localidad_mod.DisplayMember = "Descripcion"
                    cb_Localidad_mod.ValueMember = "id_Localidad"
                    cb_Localidad_mod.SelectedValue = EClientes.id_Localidad
                    cb_Localidad_mod.Refresh()
                End If

                'Cargo el combo de condiciones de iva
                Dim dsCondiciones As New DataSet
                dsCondiciones = NegCondicionesIva.ListadoCondiciones()
                If dsCondiciones.Tables(0).Rows.Count > 0 Then
                    cb_CondicionIva_mod.DataSource = Nothing
                    cb_CondicionIva_mod.DataSource = dsCondiciones.Tables(0)
                    cb_CondicionIva_mod.DisplayMember = "Descripcion"
                    cb_CondicionIva_mod.ValueMember = "id_CondicionIva"
                    cb_CondicionIva_mod.SelectedValue = EClientes.id_CondicionIva
                    cb_CondicionIva_mod.Refresh()
                End If

                'Cargo el combo de listado de precios
                Dim dsListas As New DataSet
                dsListas = NegListasPrecio.ListadoListasPrecios()
                If dsListas.Tables(0).Rows.Count > 0 Then
                    cb_ListaPrecios_mod.DataSource = Nothing
                    cb_ListaPrecios_mod.DataSource = dsListas.Tables(0)
                    cb_ListaPrecios_mod.DisplayMember = "ListaPrecio"
                    cb_ListaPrecios_mod.ValueMember = "id_Lista"
                    cb_ListaPrecios_mod.SelectedValue = EClientes.id_Precio
                    cb_ListaPrecios_mod.Refresh()
                End If

                If EClientes.Habilitado = "1" Then
                    chk_Habilitado_mod.Checked = True
                Else
                    chk_Habilitado_mod.Checked = False
                End If

                'Cambio el cursor a NORMAL.
                Me.Cursor = Cursors.Arrow

                'hago foco en el tab_modificacion 
                TabClientes.SelectedIndex = 2
            Catch ex As Exception
                Me.Cursor = Cursors.Arrow
                MessageBox.Show("Se ha producido un error al cargar el cliente seleccionado.", "Administración de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        ElseIf DG_Clientes.Columns(e.ColumnIndex).Name = "Compras" Then 'Si se hace click en el boton "compras" de la fila.

            Try
                'Cambio el cursor a "WAIT"
                Me.Cursor = Cursors.WaitCursor

                Dim id_Cliente As Integer = DG_Clientes.Rows(e.RowIndex).Cells("id_Cliente").Value()
                EClientes.id_Cliente = id_Cliente

                Me.WindowState = FormWindowState.Minimized
                frmVerComprasCliente.id_Cliente = id_Cliente
                Funciones.ControlInstancia(frmVerComprasCliente).MdiParent = MDIContenedor
                Funciones.ControlInstancia(frmVerComprasCliente).Show()

                'Cambio el cursor a NORMAL.
                Me.Cursor = Cursors.Arrow
            Catch ex As Exception
                Me.Cursor = Cursors.Arrow
                MessageBox.Show("Se ha producido un error al cargar las compras del cliente seleccionado.", "Administración de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If
    End Sub

    'Boton Modificar Clientes.
    Private Sub Btn_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Modificar.Click
        If txt_Direccion_mod.Text = "" Or txt_CodigoPostal_mod.Text = "" Or txt_Mail_mod.Text = "" Or txt_Cuit_mod.Text = "" Or txt_RazonSocial_mod.Text = "" Or cb_Provincia_mod.SelectedItem Is Nothing Or cb_Distrito_mod.SelectedItem Is Nothing Or cb_Localidad_mod.SelectedItem Is Nothing Or cb_CondicionIva_mod.SelectedItem Is Nothing Or cb_ListaPrecios_mod.SelectedItem Is Nothing Then
            MessageBox.Show("Debe completar los campos requeridos.", "Administración de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                'Lleno la entidad clientes.
                EClientes.RazonSocial = Trim(txt_RazonSocial_mod.Text)
                EClientes.Telefono = Trim(txt_Telefono_mod.Text)
                EClientes.Transporte = Trim(txt_Transporte_mod.Text)
                If txt_Observaciones_mod.Text <> "" Then
                    EClientes.Observaciones = Replace(Trim(txt_Observaciones_mod.Text), vbCrLf, "<br />")
                Else
                    EClientes.Observaciones = ""
                End If
                EClientes.Mail = Trim(txt_Mail_mod.Text)
                EClientes.Contacto = Trim(txt_Contacto_mod.Text)
                EClientes.Cuit = Trim(txt_Cuit_mod.Text)
                EClientes.Codigo_Postal = Trim(txt_CodigoPostal_mod.Text)
                EClientes.Direccion = Trim(txt_Direccion_mod.Text)
                EClientes.id_Provincia = cb_Provincia_mod.SelectedValue
                EClientes.id_Precio = cb_ListaPrecios_mod.SelectedValue
                EClientes.id_Localidad = cb_Localidad_mod.SelectedValue
                EClientes.id_Distrito = cb_Distrito_mod.SelectedValue
                EClientes.id_CondicionIva = cb_CondicionIva_mod.SelectedValue
                If chk_Habilitado_mod.Checked = True Then
                    EClientes.Habilitado = 1
                Else
                    EClientes.Habilitado = 0
                End If

                'Ejecuto el sp_Clientes_Modificar.
                MessageBox.Show(NegClientes.ModificacionCliente(EClientes), "Administración de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("Se ha producido un error al modificar el cliente. Por favor, intente más tarde.", "Administración de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            'Limpio el formulario.
            LimpiarFormModificacionClientes()

            'Redirecciono al listado.
            TabClientes.SelectedIndex = 0
        End If
    End Sub

    'Actualizo el listado de clientes dependiendo de lo que haya ingresado.
    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        'Seteo las variables.
        Dim descrip As String
        descrip = Trim(txt_buscar.Text.ToLower)

        If descrip = "" Then
            ErroresClie.SetError(txt_buscar, "Debe completar el campo de busqueda.")
        Else
            ErroresClie.SetError(txt_buscar, Nothing)

            'filtro el dataset por la descripcion que se va ingresando
            Dim dv As DataView = NegClientes.ListadoClientesCompleto().Tables(0).DefaultView
            dv.RowFilter = "RazonSocial LIKE '%" + descrip + "%'"

            'actualizo el datagrid
            DG_Clientes.DataSource = dv
            DG_Clientes.Refresh()
        End If
    End Sub

    'Evento cuando realiza doble click en el DG_Clientes.
    Private Sub DG_Clientes_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Clientes.CellDoubleClick
        Try
            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            Dim id_Cliente As Integer = DG_Clientes.Rows(e.RowIndex).Cells("id_Cliente").Value()
            EClientes.id_Cliente = id_Cliente

            'lleno la entidad colores
            EClientes = NegClientes.TraerCliente(id_Cliente)

            'lleno los controls del tab_modificacion
            txt_RazonSocial_mod.Text = EClientes.RazonSocial
            txt_Telefono_mod.Text = EClientes.Telefono
            txt_Transporte_mod.Text = EClientes.Transporte
            If EClientes.Observaciones <> "" Then
                txt_Observaciones_mod.Text = Replace(Trim(EClientes.Observaciones), "<br />", vbCrLf)
            Else
                txt_Observaciones_mod.Text = ""
            End If
            txt_Mail_mod.Text = EClientes.Mail
            txt_Contacto_mod.Text = EClientes.Contacto
            txt_Cuit_mod.Text = EClientes.Cuit
            txt_CodigoPostal_mod.Text = EClientes.Codigo_Postal
            txt_Direccion_mod.Text = EClientes.Direccion

            'Cargo el combo de Provincias
            Dim dsProvincias As New DataSet
            dsProvincias = NegProvincias.ListadoProvincias()
            If dsProvincias.Tables(0).Rows.Count > 0 Then
                cb_Provincia_mod.DataSource = Nothing
                cb_Provincia_mod.DataSource = dsProvincias.Tables(0)
                cb_Provincia_mod.DisplayMember = "Descripcion"
                cb_Provincia_mod.ValueMember = "id_Provincia"
                cb_Provincia_mod.SelectedValue = EClientes.id_Provincia
                cb_Provincia_mod.Refresh()
            End If

            'Cargo el combo de Distritos
            Dim dsDistritos As New DataSet
            dsDistritos = NegDistritos.ListadoDistritos(EClientes.id_Provincia)
            If dsDistritos.Tables(0).Rows.Count > 0 Then
                cb_Distrito_mod.DataSource = Nothing
                cb_Distrito_mod.DataSource = dsDistritos.Tables(0)
                cb_Distrito_mod.DisplayMember = "Descripcion"
                cb_Distrito_mod.ValueMember = "id_Departamento"
                cb_Distrito_mod.SelectedValue = EClientes.id_Distrito
                cb_Distrito_mod.Refresh()
            End If

            'Cargo el combo de Localidades
            Dim dsLocalidades As New DataSet
            dsLocalidades = NegLocalidades.ListadoLocalidades(EClientes.id_Distrito)
            If dsLocalidades.Tables(0).Rows.Count > 0 Then
                cb_Localidad_mod.DataSource = Nothing
                cb_Localidad_mod.DataSource = dsLocalidades.Tables(0)
                cb_Localidad_mod.DisplayMember = "Descripcion"
                cb_Localidad_mod.ValueMember = "id_Localidad"
                cb_Localidad_mod.SelectedValue = EClientes.id_Localidad
                cb_Localidad_mod.Refresh()
            End If

            'Cargo el combo de condiciones de iva
            Dim dsCondiciones As New DataSet
            dsCondiciones = NegCondicionesIva.ListadoCondiciones()
            If dsCondiciones.Tables(0).Rows.Count > 0 Then
                cb_CondicionIva_mod.DataSource = Nothing
                cb_CondicionIva_mod.DataSource = dsCondiciones.Tables(0)
                cb_CondicionIva_mod.DisplayMember = "Descripcion"
                cb_CondicionIva_mod.ValueMember = "id_CondicionIva"
                cb_CondicionIva_mod.SelectedValue = EClientes.id_CondicionIva
                cb_CondicionIva_mod.Refresh()
            End If

            'Cargo el combo de listado de precios
            Dim dsListas As New DataSet
            dsListas = NegListasPrecio.ListadoListasPrecios()
            If dsListas.Tables(0).Rows.Count > 0 Then
                cb_ListaPrecios_mod.DataSource = Nothing
                cb_ListaPrecios_mod.DataSource = dsListas.Tables(0)
                cb_ListaPrecios_mod.DisplayMember = "ListaPrecio"
                cb_ListaPrecios_mod.ValueMember = "id_Lista"
                cb_ListaPrecios_mod.SelectedValue = EClientes.id_Precio
                cb_ListaPrecios_mod.Refresh()
            End If

            If EClientes.Habilitado = "1" Then
                chk_Habilitado_mod.Checked = True
            Else
                chk_Habilitado_mod.Checked = False
            End If

            'Cambio el cursor a NORMAL.
            Me.Cursor = Cursors.Arrow

            'hago foco en el tab_modificacion 
            TabClientes.SelectedIndex = 2
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha producido un error al cargar el cliente seleccionado.", "Administración de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'Boton Eliminar Cliente.
    Private Sub Btn_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Eliminar.Click
        Dim Result As DialogResult
        Result = MessageBox.Show("¿Está seguro que desea eliminar el cliente?", "Administración de Clientes", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If Result = System.Windows.Forms.DialogResult.Yes Then 'Si acepta eliminar el item
            If EClientes.id_Cliente = 0 Then
                'si no completo la descripcion, muestro un msg de error.
                MessageBox.Show("No se puede eliminar el cliente.", "Administración de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                'ejecuto el sp_Clientes_Eliminar.
                MessageBox.Show(NegClientes.EliminarCliente(EClientes.id_Cliente), "Administración de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information)

                'Cargo el datagrid de cliente
                Dim dsClientes As New DataSet
                dsClientes = NegClientes.ListadoClientesCompleto()
                If dsClientes.Tables(0).Rows.Count > 0 Then
                    DG_Clientes.DataSource = dsClientes.Tables(0)
                    DG_Clientes.AutoGenerateColumns = False
                    DG_Clientes.Columns("RazonSocial").DisplayIndex = 1
                    DG_Clientes.Columns("Mail").DisplayIndex = 2
                    DG_Clientes.Columns("Telefono").DisplayIndex = 3
                    DG_Clientes.Columns("Direccion").Visible = False
                    DG_Clientes.Columns("Cuit").Visible = False
                    DG_Clientes.Columns("id_Cliente").Visible = False
                    DG_Clientes.Columns("Modificar").DisplayIndex = 9
                    DG_Clientes.Columns("Eliminar").DisplayIndex = 9
                    DG_Clientes.Columns("Compras").DisplayIndex = 9
                    DG_Clientes.Refresh()
                End If

                'hago foco en el tab_listado 
                TabClientes.SelectedIndex = 0

            End If
        End If
    End Sub

    'Boton restablecer listado.
    Private Sub btn_Restablecer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Restablecer.Click
        Try
            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            'Cargo el datagrid
            Dim dsClientes As New DataSet
            dsClientes = NegClientes.ListadoClientesCompleto()
            If (dsClientes.Tables(0).Rows.Count <> 0) Then
                DG_Clientes.DataSource = dsClientes.Tables(0)
                DG_Clientes.AutoGenerateColumns = False
                DG_Clientes.Columns("RazonSocial").DisplayIndex = 1
                DG_Clientes.Columns("Mail").DisplayIndex = 2
                DG_Clientes.Columns("Telefono").DisplayIndex = 3
                DG_Clientes.Columns("Direccion").Visible = False
                DG_Clientes.Columns("Cuit").Visible = False
                DG_Clientes.Columns("id_Cliente").Visible = False
                DG_Clientes.Columns("Modificar").DisplayIndex = 9
                DG_Clientes.Columns("Eliminar").DisplayIndex = 9
                DG_Clientes.Columns("Compras").DisplayIndex = 9
                DG_Clientes.Refresh()
            End If

            txt_buscar.Clear()
            txt_buscar.Focus()

            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha encontrado un error al restablecer el listado.", "Administración de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

End Class