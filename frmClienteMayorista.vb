Imports System.Reflection
Imports Entidades
Imports Negocio

Public Class frmClienteMayorista

    Private Sub TextBox_Validacion_Email(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt_Mail_Facturacion.Validating, txt_Mail_Facturacion_Mod.Validating
        Dim NegErrores As NegManejadorErrores = New NegManejadorErrores()
        If CType(sender, TextBox).Text <> String.Empty AndAlso Not NegErrores.validar_Mail(CType(sender, TextBox).Text) Then
            ErrorCliente.SetError(sender, "Campo incorrecto, el email ingresado no es valido")
            e.Cancel = True
        Else
            ErrorCliente.SetError(sender, "")
        End If
    End Sub

    Private Sub TextBox_Validacion_SoloNumeros(sender As Object, e As KeyPressEventArgs) Handles txt_Bonificacion.KeyPress, txt_Lista.KeyPress, txt_Comision.KeyPress, txt_Bonificacion_Mod.KeyPress, txt_Lista_Mod.KeyPress, txt_Comision_Mod.KeyPress, txt_Bonificacion_Buscar.KeyPress, txt_Comision_Buscar.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        Dim NegErrores As NegManejadorErrores = New NegManejadorErrores()
        KeyAscii = CShort(NegErrores.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox_Validacion_SoloNumerosConEspacio(sender As Object, e As KeyPressEventArgs) Handles txt_Telefono_Buscar.KeyPress, txt_Telefono_Facturacion.KeyPress, txt_Telefono_Facturacion_Mod.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        Dim NegErrores As NegManejadorErrores = New NegManejadorErrores()
        KeyAscii = CShort(NegErrores.SoloNumerosConEspacio(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox_Validacion_Requerido(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt_RazonSocial.Validating, txt_Direccion_Facturacion.Validating, txt_CodigoPostal_Facturacion.Validating, txt_Nombre.Validating, txt_Lista.Validating, txt_Bonificacion.Validating, txt_Comision.Validating, txt_Nombre_Mod.Validating, txt_RazonSocial_mod.Validating, txt_Lista_Mod.Validating, txt_Direccion_Facturacion_Mod.Validating, txt_Comision_Mod.Validating, txt_CodigoPostal_Facturacion_Mod.Validating, txt_Bonificacion_Mod.Validating
        If Not ValidarRequerido(CType(sender, TextBox).Text, sender) Then
            e.Cancel = True
        Else
            e.Cancel = False
        End If
    End Sub

    Private Sub TextBox_Validacion_Porcentaje(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt_Lista.Validating, txt_Bonificacion.Validating, txt_Comision.Validating, txt_Lista_Mod.Validating, txt_Bonificacion_Mod.Validating, txt_Comision_Mod.Validating
        If (CType(sender, TextBox).Text = String.Empty) Then
            Return
        End If

        If CType(CType(sender, TextBox).Text, Integer) > 100 Then
            ErrorCliente.SetError(sender, "Campo incorrecto, el valor debe ser menor a 100")
            e.Cancel = True
        Else
            ErrorCliente.SetError(sender, "")
            e.Cancel = False
        End If
    End Sub

    Private Sub Masked_Validacion_Requerido(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt_Cuit.Validating, txt_Cuit_Mod.Validating
        If Not ValidarRequerido(CType(sender, MaskedTextBox).Text, sender) Then
            e.Cancel = True
        Else
            e.Cancel = False
        End If

        If Not e.Cancel Then
            If Not CType(sender, MaskedTextBox).MaskFull Then
                ErrorCliente.SetError(sender, "Campo incompleto, debe completar el campo")
                e.Cancel = True
            Else
                ErrorCliente.SetError(sender, String.Empty)
                e.Cancel = False
            End If
        End If
    End Sub

    Private Sub ComboBox_Validacion_Requerido(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cb_Provincia_Facturacion.Validating, cb_Localidad_Facturacion.Validating, cb_Distrito_Facturacion.Validating, cb_CondicionIva.Validating, cb_ListaPrecios.Validating, cb_CondicionIva_Mod.Validating, cb_Provincia_Facturacion_Mod.Validating, cb_Localidad_Facturacion_Mod.Validating, cb_ListaPrecios_Mod.Validating, cb_Distrito_Facturacion_Mod.Validating
        If (Not ValidarRequerido(CType(CType(sender, ComboBox).SelectedValue, Integer), sender)) Then
            e.Cancel = True
        Else
            e.Cancel = False
        End If
    End Sub

    Private Function ValidarRequerido(Valor As String, Control As Object) As Boolean
        If (Valor = String.Empty) Then
            ErrorCliente.SetError(Control, String.Format("Campo requerido, debe ingresar un valor"))
            Return False
        Else
            ErrorCliente.SetError(Control, String.Empty)
            Return True
        End If
    End Function

    Private Function ValidarRequerido(Valor As Integer, Control As Object) As Boolean
        If (Valor <= 0) Then
            ErrorCliente.SetError(Control, String.Format("Campo requerido, debe seleccionar un valor"))
            Return False
        Else
            ErrorCliente.SetError(Control, String.Empty)
            Return True
        End If
    End Function

    Private Sub Btn_Agregar_Click(sender As Object, e As EventArgs) Handles Btn_Agregar.Click
        Try
            If (ValidarTodosLosControles(GB_Alta.Controls)) Then
                Me.Cursor = Cursors.WaitCursor
                Dim NegCliente As Negocio.NegClienteMayorista = New Negocio.NegClienteMayorista()
                Dim NegDireccion As Negocio.NegDireccion = New Negocio.NegDireccion()
                Dim cliente As ClienteMayorista = ClientesMayoristaAltaBindingSource.DataSource

                cliente.IdDireccionFacturacion = NegDireccion.Alta(DireccionFacturacionAltaBindingSource.DataSource)

                Dim DireccionEntrega As Direccion = DireccionEntregaAltaBindingSource.DataSource

                If (DireccionEntrega.IdProvincia > 0 AndAlso DireccionEntrega.IdDistito > 0 AndAlso DireccionEntrega.IdLocalidad > 0) Then
                    cliente.IdDireccionEntrega = NegDireccion.Alta(DireccionEntregaAltaBindingSource.DataSource)
                End If

                cliente.Habilitado = True

                NegCliente.AltaCliente(ClientesMayoristaAltaBindingSource.DataSource)

                MessageBox.Show("El Cliente se ha registrado correctamente.", "Administración cliente mayorista", MessageBoxButtons.OK, MessageBoxIcon.Information)

                LimpiarControlesNuevoCliente()
                BuscarCliente()
                tabControl.SelectedTab = TbListado
                Me.Cursor = Cursors.Arrow
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha encontrado un error al agregar el cliente. Por favor, vuelva a intentar más tarde o contáctese con el Administrador ", "Administración cliente mayorista", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Btn_Modificar_Click(sender As Object, e As EventArgs) Handles Btn_Modificar.Click
        Try
            If (ValidarTodosLosControles(GB_Modificacion.Controls)) Then
                Me.Cursor = Cursors.WaitCursor
                Dim NegCliente As Negocio.NegClienteMayorista = New Negocio.NegClienteMayorista()
                NegCliente.ModificacionCliente(ClienteMayoristaModificacionBindingSource.DataSource)

                Dim NegDireccion As Negocio.NegDireccion = New Negocio.NegDireccion()
                NegDireccion.Modificacion(DireccionFacturacionModificacionBindingSource.DataSource)
                NegDireccion.Modificacion(DireccionEntregaModificacionBindingSource.DataSource)

                MessageBox.Show("El Cliente se ha modificado correctamente.", "Administración cliente mayorista", MessageBoxButtons.OK, MessageBoxIcon.Information)
                tabControl.SelectedTab = TbListado
                BuscarCliente()
                Me.Cursor = Cursors.Arrow
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha encontrado un error al modificar el cliente. Por favor, vuelva a intentar más tarde o contáctese con el Administrador ", "Administración cliente mayorista", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Btn_Eliminar_Click(sender As Object, e As EventArgs) Handles Btn_Eliminar.Click
        Try
            Dim Result As DialogResult
            Result = MessageBox.Show("¿Está seguro que desea eliminar el cliente seleccionado?", "Administración cliente mayorista", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Result = System.Windows.Forms.DialogResult.Yes Then 'Si acepta eliminar el item
                Me.Cursor = Cursors.WaitCursor
                EliminarCliente()
                tabControl.SelectedTab = TbListado
                BuscarCliente()
                Me.Cursor = Cursors.Arrow
                MessageBox.Show("El Cliente se ha eliminado correctamente.", "Administración cliente mayorista", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha encontrado un error al eliminar el cliente. Por favor, vuelva a intentar más tarde o contáctese con el Administrador ", "Administración cliente mayorista", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub EliminarCliente()
        Dim negCliente As Negocio.NegClienteMayorista = New Negocio.NegClienteMayorista()
        Dim cliente As ClienteMayorista = DG_Clientes.CurrentRow.DataBoundItem
        negCliente.EliminarCliente(cliente.Id)

        Dim NegDireccion As Negocio.NegDireccion = New Negocio.NegDireccion()
        NegDireccion.Eliminar(cliente.IdDireccionFacturacion)
        NegDireccion.Eliminar(cliente.IdDireccionEntrega)
    End Sub

    Private Sub Btn_Cancelar_Click(sender As Object, e As EventArgs) Handles Btn_Cancelar.Click
        Try
            Dim Result As DialogResult
            Result = MessageBox.Show("¿Está seguro que desea cancelar la modificación del cliente?", "Administración cliente mayorista", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Result = System.Windows.Forms.DialogResult.Yes Then 'Si acepta eliminar el item
                Me.Cursor = Cursors.WaitCursor
                tabControl.SelectedTab = TbListado
                BuscarCliente()
                Me.Cursor = Cursors.Arrow
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha encontrado un error al eliminar el cliente. Por favor, vuelva a intentar más tarde o contáctese con el Administrador ", "Administración cliente mayorista", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Function ValidarTodosLosControles(Controls As Control.ControlCollection) As Boolean

        Dim resultado As Boolean = True

        For Each cont As Control In Controls
            If cont.HasChildren Then
                If Not ValidarTodosLosControles(cont.Controls) Then
                    resultado = False
                End If
            End If

            Dim eventArg As System.ComponentModel.CancelEventArgs = New System.ComponentModel.CancelEventArgs()
            Dim onValidating As MethodInfo = cont.GetType().GetMethod("OnValidating", BindingFlags.Instance Or BindingFlags.NonPublic)
            onValidating.Invoke(cont, New Object() {eventArg})

            If eventArg.Cancel Then
                resultado = False
            End If

        Next

        Return resultado
    End Function

    Private Sub frmClienteMayorista_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor

            RemoveHandler DG_Clientes.SelectionChanged, AddressOf DG_Clientes_SelectionChanged

            Dim NegCliente As Negocio.NegClienteMayorista = New Negocio.NegClienteMayorista()
            ClienteMayoristaGrillaBindingSource.DataSource = NegCliente.ListadoClientes()

            AddHandler DG_Clientes.SelectionChanged, AddressOf DG_Clientes_SelectionChanged

            Dim clienteMayorista As ClienteMayorista = New ClienteMayorista With {.IdCondicionIva = -1, .IdCorredor = -1, .IdEmpresa = -1, .IdListaPrecio = -1}
            ClientesMayoristaAltaBindingSource.DataSource = clienteMayorista

            Dim DireccionFacturacion As Direccion = New Direccion With {.IdProvincia = -1, .IdDistito = -1, .IdLocalidad = -1}
            DireccionFacturacionAltaBindingSource.DataSource = DireccionFacturacion

            Dim DireccionEntrega As Direccion = New Direccion With {.IdProvincia = -1, .IdDistito = -1, .IdLocalidad = -1}
            DireccionEntregaAltaBindingSource.DataSource = DireccionEntrega

            Dim NegListasPrecio As NegListasPrecio = New NegListasPrecio()
            Dim dsListas As DataSet = NegListasPrecio.ListadoPreciosPorGrupo(3)

            cargarCombo(cb_ListaPrecios, dsListas.Tables(0).Copy(), "ListaPrecio", "id_Lista")
            cargarCombo(cb_ListaPrecios_Mod, dsListas.Tables(0).Copy(), "ListaPrecio", "id_Lista")
            cargarCombo(cmb_ListaPrecio_Buscar, dsListas.Tables(0).Copy(), "ListaPrecio", "id_Lista")
            cargarCombo(cmb_ListaPrecios_Filtro, dsListas.Tables(0).Copy(), "ListaPrecio", "id_Lista")

            Dim NegProvincias As NegProvincias = New NegProvincias()
            Dim dsProvincias As New DataSet
            dsProvincias = NegProvincias.ListadoProvincias()

            cargarCombo(cb_Provincia_Facturacion, dsProvincias.Tables(0).Copy(), "Descripcion", "id_Provincia")
            cargarCombo(cb_Provincia_Entrega, dsProvincias.Tables(0).Copy(), "Descripcion", "id_Provincia")
            cargarCombo(cb_Provincia_Facturacion_Mod, dsProvincias.Tables(0).Copy(), "Descripcion", "id_Provincia")
            cargarCombo(cb_Provincia_Entrega_Mod, dsProvincias.Tables(0).Copy(), "Descripcion", "id_Provincia")

            Dim NegCondicionesIva As NegCondicionesIva = New NegCondicionesIva()
            Dim dsCondiciones As New DataSet
            dsCondiciones = NegCondicionesIva.ListadoCondiciones()

            cargarCombo(cb_CondicionIva, dsCondiciones.Tables(0).Copy(), "Descripcion", "id_CondicionIva")
            cargarCombo(cb_CondicionIva_Mod, dsCondiciones.Tables(0).Copy(), "Descripcion", "id_CondicionIva")
            cargarCombo(cmb_CondicionIVA_Buscar, dsCondiciones.Tables(0).Copy(), "Descripcion", "id_CondicionIva")
            cargarCombo(cmb_CondicionIVA_Filtro, dsCondiciones.Tables(0).Copy(), "Descripcion", "id_CondicionIva")

            LimpiarControlesNuevoCliente()
            EvaluarPermisos()

            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha encontrado un error al cargar los clientes. Por favor, vuelva a intentar más tarde o contáctese con el Administrador ", "Administración cliente mayorista", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cb_Provincia_Facturacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_Provincia_Facturacion.SelectedIndexChanged
        Me.Cursor = Cursors.WaitCursor
        CargarDistritoPorProviencia(cb_Provincia_Facturacion, cb_Distrito_Facturacion, cb_Localidad_Facturacion)
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub cb_Provincia_Entrega_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_Provincia_Entrega.SelectedIndexChanged
        Me.Cursor = Cursors.WaitCursor
        CargarDistritoPorProviencia(cb_Provincia_Entrega, cb_Distrito_Entrega, cb_Localidad_Entrega)
        If (cb_Provincia_Entrega.SelectedValue > 0) Then
            AddHandler cb_Distrito_Entrega.Validating, AddressOf ComboBox_Validacion_Requerido
        Else
            RemoveHandler cb_Distrito_Entrega.Validating, AddressOf ComboBox_Validacion_Requerido
            ErrorCliente.SetError(cb_Distrito_Entrega, String.Empty)
        End If

        RemoveHandler cb_Localidad_Entrega.Validating, AddressOf ComboBox_Validacion_Requerido
        ErrorCliente.SetError(cb_Localidad_Entrega, String.Empty)

        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub cb_Provincia_Facturacion_Mod_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cb_Provincia_Facturacion_Mod.SelectionChangeCommitted
        Me.Cursor = Cursors.WaitCursor
        CargarDistritoPorProviencia(cb_Provincia_Facturacion_Mod, cb_Distrito_Facturacion_Mod, cb_Localidad_Facturacion_Mod)
        CType(DireccionFacturacionModificacionBindingSource.DataSource, Direccion).IdDistito = -1
        CType(DireccionFacturacionModificacionBindingSource.DataSource, Direccion).IdLocalidad = -1
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub cb_Provincia_Entrega_Mod_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cb_Provincia_Entrega_Mod.SelectionChangeCommitted
        Me.Cursor = Cursors.WaitCursor
        CargarDistritoPorProviencia(cb_Provincia_Entrega_Mod, cb_Distrito_Entrega_Mod, cb_Localidad_Entrega_Mod)
        CType(DireccionEntregaModificacionBindingSource.DataSource, Direccion).IdDistito = -1
        CType(DireccionEntregaModificacionBindingSource.DataSource, Direccion).IdLocalidad = -1

        If (cb_Provincia_Entrega_Mod.SelectedValue > 0) Then
            AddHandler cb_Distrito_Entrega_Mod.Validating, AddressOf ComboBox_Validacion_Requerido
        Else
            RemoveHandler cb_Distrito_Entrega_Mod.Validating, AddressOf ComboBox_Validacion_Requerido
            ErrorCliente.SetError(cb_Distrito_Entrega_Mod, String.Empty)
        End If

        RemoveHandler cb_Localidad_Entrega_Mod.Validating, AddressOf ComboBox_Validacion_Requerido
        ErrorCliente.SetError(cb_Localidad_Entrega_Mod, String.Empty)

        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub CargarDistritoPorProviencia(provincia As ComboBox, distrito As ComboBox, localidad As ComboBox)
        If (TypeOf provincia.SelectedValue Is Integer) Then
            If (provincia.SelectedValue > 0) Then
                Dim NegDistritos As NegDistritos = New NegDistritos()
                Dim DsDistritos As New DataSet
                DsDistritos = NegDistritos.ListadoDistritos(provincia.SelectedValue)

                cargarCombo(distrito, DsDistritos.Tables(0), "Descripcion", "id_Departamento")
                distrito.SelectedValue = -1

                localidad.DataSource = Nothing
                localidad.SelectedValue = -1
            Else
                distrito.DataSource = Nothing
                distrito.SelectedValue = -1

                localidad.DataSource = Nothing
                localidad.SelectedValue = -1
            End If
        End If
    End Sub

    Private Sub cb_Distrito_Facturacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_Distrito_Facturacion.SelectedIndexChanged
        Me.Cursor = Cursors.WaitCursor
        CargarLocalidadPorDistrito(cb_Distrito_Facturacion, cb_Localidad_Facturacion)
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub cb_Distrito_Entrega_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_Distrito_Entrega.SelectedIndexChanged
        Me.Cursor = Cursors.WaitCursor
        CargarLocalidadPorDistrito(cb_Distrito_Entrega, cb_Localidad_Entrega)

        If (TypeOf cb_Distrito_Entrega.SelectedValue Is Integer AndAlso cb_Distrito_Entrega.SelectedValue > 0) Then
            AddHandler cb_Localidad_Entrega.Validating, AddressOf ComboBox_Validacion_Requerido
        Else
            RemoveHandler cb_Localidad_Entrega.Validating, AddressOf ComboBox_Validacion_Requerido
            ErrorCliente.SetError(cb_Localidad_Entrega, String.Empty)
        End If
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub cb_Distrito_Facturacion_Mod_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cb_Distrito_Facturacion_Mod.SelectionChangeCommitted
        Me.Cursor = Cursors.WaitCursor
        CargarLocalidadPorDistrito(cb_Distrito_Facturacion_Mod, cb_Localidad_Facturacion_Mod)
        CType(DireccionFacturacionModificacionBindingSource.DataSource, Direccion).IdLocalidad = -1
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub cb_Distrito_Entrega_Mod_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cb_Distrito_Entrega_Mod.SelectionChangeCommitted
        Me.Cursor = Cursors.WaitCursor
        CargarLocalidadPorDistrito(cb_Distrito_Entrega_Mod, cb_Localidad_Entrega_Mod)
        CType(DireccionEntregaModificacionBindingSource.DataSource, Direccion).IdLocalidad = -1

        If (TypeOf cb_Distrito_Entrega_Mod.SelectedValue Is Integer AndAlso cb_Distrito_Entrega_Mod.SelectedValue > 0) Then
            AddHandler cb_Localidad_Entrega_Mod.Validating, AddressOf ComboBox_Validacion_Requerido
        Else
            RemoveHandler cb_Localidad_Entrega.Validating, AddressOf ComboBox_Validacion_Requerido
            ErrorCliente.SetError(cb_Localidad_Entrega_Mod, String.Empty)
        End If
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub CargarLocalidadPorDistrito(distrito As ComboBox, localidad As ComboBox)
        If (TypeOf distrito.SelectedValue Is Integer) Then
            If (distrito.SelectedValue > 0) Then
                Dim NegLocalidades As NegLocalidades = New NegLocalidades()
                Dim DsLocalidades As New DataSet
                DsLocalidades = NegLocalidades.ListadoLocalidades(distrito.SelectedValue)

                cargarCombo(localidad, DsLocalidades.Tables(0), "Descripcion", "id_Localidad")

                localidad.SelectedValue = -1
            Else
                localidad.DataSource = Nothing
                localidad.SelectedValue = -1
            End If
        End If
    End Sub

    Private Sub frmClienteMayorista_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
        Me.Cursor = Cursors.WaitCursor
        BuscarCliente()
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub BuscarCliente()
        Dim NegCliente As Negocio.NegClienteMayorista = New Negocio.NegClienteMayorista()
        Dim clientes As List(Of Entidades.ClienteMayorista) = NegCliente.ListadoClientes()

        If (Not String.IsNullOrEmpty(txt_RazonSocial_Filtro.Text)) Then
            clientes = clientes.Where(Function(x) x.RazonSocial.Contains(txt_RazonSocial_Filtro.Text)).ToList()
        End If

        If (Not String.IsNullOrEmpty(txt_Cuit_Filtro.Text)) Then
            clientes = clientes.Where(Function(x) x.Cuit.ToString().Contains(txt_Cuit_Filtro.Text)).ToList()
        End If

        If (cmb_Corredor_Filtro.SelectedValue > 0) Then
            clientes = clientes.Where(Function(x) x.IdCorredor = cmb_Corredor_Filtro.SelectedValue).ToList()
        End If

        If (cmb_CondicionIVA_Filtro.SelectedValue > 0) Then
            clientes = clientes.Where(Function(x) x.IdCondicionIva = cmb_CondicionIVA_Filtro.SelectedValue).ToList()
        End If

        If (cmb_ListaPrecios_Filtro.SelectedValue > 0) Then
            clientes = clientes.Where(Function(x) x.IdListaPrecio = cmb_ListaPrecios_Filtro.SelectedValue).ToList()
        End If

        If (Rb_Habilitado_Si.Checked) Then
            clientes = clientes.Where(Function(x) x.Habilitado).ToList()
        End If

        If (Rb_Habilitado_No.Checked) Then
            clientes = clientes.Where(Function(x) Not x.Habilitado).ToList()
        End If

        ClienteMayoristaGrillaBindingSource.DataSource = clientes
    End Sub

    Private Sub btn_Restablecer_Click(sender As Object, e As EventArgs) Handles btn_Restablecer.Click
        txt_Cuit_Filtro.Clear()
        txt_RazonSocial_Filtro.Clear()
        Rb_Habilitado_Todos.Checked = True
    End Sub

    Private Sub DG_Clientes_SelectionChanged(sender As Object, e As EventArgs) Handles DG_Clientes.SelectionChanged
        If (DG_Clientes.CurrentRow IsNot Nothing) Then
            Dim cliente As ClienteMayorista = DG_Clientes.CurrentRow.DataBoundItem

            Dim negDireccion As NegDireccion = New NegDireccion()

            DireccionFacturacionModificacionBindingSource.DataSource = negDireccion.Consulta(cliente.IdDireccionFacturacion)
            DireccionEntregaModificacionBindingSource.DataSource = negDireccion.Consulta(cliente.IdDireccionEntrega)
            ClienteMayoristaModificacionBindingSource.DataSource = cliente

        End If
    End Sub

    Private Sub DG_Clientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_Clientes.CellContentClick
        Try
            If DG_Clientes.Columns(e.ColumnIndex).Name.ToUpper() = "ELIMINAR" Then 'Si se hace click en el boton "eliminar" de la fila.
                Dim Result As DialogResult
                Result = MessageBox.Show("¿Está seguro que desea eliminar el cliente seleccionado?", "Administración cliente mayorista", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If Result = System.Windows.Forms.DialogResult.Yes Then 'Si acepta eliminar el item
                    Me.Cursor = Cursors.WaitCursor
                    EliminarCliente()
                    BuscarCliente()
                    Me.Cursor = Cursors.Arrow
                    MessageBox.Show("El Cliente se ha eliminado correctamente.", "Administración cliente mayorista", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If

            If DG_Clientes.Columns(e.ColumnIndex).Name.ToUpper() = "MODIFICAR" Then 'Si se hace click en el boton "modificar" de la fila.
                tabControl.SelectedTab = TbMod
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha encontrado un error al eliminar el cliente. Por favor, vuelva a intentar más tarde o contáctese con el Administrador ", "Administración cliente mayorista", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DG_Clientes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_Clientes.CellDoubleClick
        tabControl.SelectedTab = TbMod
    End Sub

    Private Sub LimpiarControlesNuevoCliente()

        Dim clienteMayorista As ClienteMayorista = New ClienteMayorista With {.IdCondicionIva = -1, .IdCorredor = -1, .IdEmpresa = -1, .IdListaPrecio = -1}
        ClientesMayoristaAltaBindingSource.DataSource = clienteMayorista

        Dim DireccionFacturacion As Direccion = New Direccion With {.IdProvincia = -1, .IdDistito = -1, .IdLocalidad = -1}
        DireccionFacturacionAltaBindingSource.DataSource = DireccionFacturacion

        Dim DireccionEntrega As Direccion = New Direccion With {.IdProvincia = -1, .IdDistito = -1, .IdLocalidad = -1}
        DireccionEntregaAltaBindingSource.DataSource = DireccionEntrega

        cmb_Corredor.SelectedIndex = 0
        cmb_Corredor_Filtro.SelectedIndex = 0
        cmb_Corredor_Mod.SelectedIndex = 0

        cmb_Empresa.SelectedIndex = 0
        cmb_Empresa_Filtro.SelectedIndex = 0
        cmb_Empresa_Mod.SelectedIndex = 0
    End Sub

    Private Sub tabControl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabControl.SelectedIndexChanged
        If (tabControl.SelectedTab.Name = "TbMod") Then

            Dim direccionFacturacionMod As Direccion = DireccionFacturacionModificacionBindingSource.DataSource
            Dim direccionEntegaMod As Direccion = DireccionEntregaModificacionBindingSource.DataSource

            Dim NegDistritos As NegDistritos = New NegDistritos()
            Dim DsDistritos As New DataSet
            DsDistritos = NegDistritos.ListadoDistritos(direccionFacturacionMod.IdProvincia)
            cargarCombo(cb_Distrito_Facturacion_Mod, DsDistritos.Tables(0).Copy(), "Descripcion", "id_Departamento")
            cb_Distrito_Facturacion_Mod.SelectedValue = direccionFacturacionMod.IdDistito

            DsDistritos = NegDistritos.ListadoDistritos(direccionEntegaMod.IdProvincia)
            cargarCombo(cb_Distrito_Entrega_Mod, DsDistritos.Tables(0).Copy(), "Descripcion", "id_Departamento")
            cb_Distrito_Entrega_Mod.SelectedValue = direccionEntegaMod.IdDistito

            Dim NegLocalidades As NegLocalidades = New NegLocalidades()
            Dim DsLocalidades As New DataSet
            DsLocalidades = NegLocalidades.ListadoLocalidades(direccionFacturacionMod.IdDistito)
            cargarCombo(cb_Localidad_Facturacion_Mod, DsLocalidades.Tables(0).Copy(), "Descripcion", "id_Localidad")
            cb_Localidad_Facturacion_Mod.SelectedValue = direccionFacturacionMod.IdLocalidad

            DsLocalidades = NegLocalidades.ListadoLocalidades(direccionEntegaMod.IdDistito)
            cargarCombo(cb_Localidad_Entrega_Mod, DsLocalidades.Tables(0).Copy(), "Descripcion", "id_Localidad")
            cb_Localidad_Entrega_Mod.SelectedValue = direccionEntegaMod.IdLocalidad
        End If
    End Sub

    Private Sub DG_Clientes_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DG_Clientes.DataBindingComplete
        Dim sumaSaldoCuentaCorriente As Decimal = 0

        For Each row As DataGridViewRow In DG_Clientes.Rows
            Dim cliente As ClienteMayorista = row.DataBoundItem
            sumaSaldoCuentaCorriente += cliente.SaldoCuentaCorriente
        Next

        txt_TotalSaldoCuentaCorriente.Text = sumaSaldoCuentaCorriente.ToString("C2")

        lbl_Msg.Visible = DG_Clientes.Rows.Count = 0

        If (DG_Clientes.Rows.Count = 0) Then
            DireccionFacturacionModificacionBindingSource.DataSource = New Direccion()
            DireccionEntregaModificacionBindingSource.DataSource = New Direccion()
            ClienteMayoristaModificacionBindingSource.DataSource = New ClienteMayorista()
        End If
    End Sub

    Private Sub cargarCombo(control As ComboBox, dataTable As DataTable, displayMember As String, valueMember As String)
        Dim dr As DataRow = dataTable.NewRow
        dr(displayMember) = "Seleccione una opción"
        dr(valueMember) = -1
        dataTable.Rows.InsertAt(dr, 0)

        control.DataSource = dataTable
        control.DisplayMember = displayMember
        control.ValueMember = valueMember
    End Sub

    Sub EvaluarPermisos()
        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Cliente_Mayorista_Crear)) Then

        Else
            tabControl.TabPages.Remove(TbAlta)
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Cliente_Mayorista_Eliminar)) Then
            Btn_Eliminar.Enabled = True
            DG_Clientes.Columns("Eliminar").Visible = True
        Else
            Btn_Eliminar.Enabled = False
            DG_Clientes.Columns("Eliminar").Visible = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Cliente_Mayorista_Modificar)) Then
            DG_Clientes.Columns("Modificar").Visible = True
        Else
            tabControl.TabPages.Remove(TbMod)
            DG_Clientes.Columns("Modificar").Visible = False
            RemoveHandler DG_Clientes.CellDoubleClick, AddressOf DG_Clientes_CellDoubleClick
        End If
    End Sub
End Class