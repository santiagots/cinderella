Imports System.Configuration
Imports System.Resources
Public Class frmEmpleados
    Dim fuc As New Funciones
    Dim NegEmpleados As New Negocio.NegEmpleados
    Dim NegProvincias As New Negocio.NegProvincias
    Dim NegDistritos As New Negocio.NegDistritos
    Dim NegLocalidades As New Negocio.NegLocalidades
    Dim NegErrores As New Negocio.NegManejadorErrores
    Dim NegSucursal As New Negocio.NegSucursales
    Dim NegTiposComision As New Negocio.NegTipoComision
    Dim NegTiposEmpleado As New Negocio.NegTipoEmpleado
    Dim EEmpleados As New Entidades.Empleados
    Dim ESucursal As New Entidades.Sucursales
    Dim id_Sucursal As String
    Dim Nombre_Sucursal As String

#Region "Región de Funciones"
    'Limpia el formulario de Alta.
    Sub LimpiarFormAltaEmpleados()
        ErrorEmpleados.Clear()
        txt_Nombre.Clear()
        txt_Apellido.Clear()
        txt_Telefono.Clear()
        txt_Telefono2.Clear()
        txt_Mail.Clear()
        txt_Observaciones.Clear()
        txt_Cuil.Clear()
        txt_CodigoPostal.Clear()
        txt_Direccion.Clear()
        txt_SueldoNormal.Clear()
        txt_SueldoFeriado.Clear()
        cb_Provincia.SelectedItem = Nothing
        fuc.SetearCheckboxlist(CheckSucursales, False)
        CheckSucursales.ClearSelected()
        cb_TipoEmpleado.SelectedItem = Nothing
        cb_Localidad.SelectedItem = Nothing
        cb_Distrito.SelectedItem = Nothing
        chk_Habilitado.Checked = True
    End Sub

    'Limpia el formulario de modificacion.
    Sub LimpiarFormModificacionEmpleados()
        ErrorEmpleados.Clear()
        txt_Nombre_mod.Clear()
        txt_Apellido_mod.Clear()
        txt_Telefono_mod.Clear()
        txt_Telefono2_mod.Clear()
        txt_Mail_mod.Clear()
        txt_Observaciones_mod.Clear()
        txt_Cuil_mod.Clear()
        txt_CodigoPostal_mod.Clear()
        txt_Direccion_mod.Clear()
        txt_SueldoNormal_mod.Clear()
        txt_SueldoFeriado_mod.Clear()
        cb_Provincia_mod.SelectedItem = Nothing
        fuc.SetearCheckboxlist(CheckSucursales_mod, False)
        CheckSucursales_mod.ClearSelected()
        cb_TipoEmpleado_mod.SelectedItem = Nothing
        cb_Localidad_mod.SelectedItem = Nothing
        cb_Distrito_mod.SelectedItem = Nothing
        chk_Habilitado_mod.Checked = True
    End Sub
#End Region

#Region "Región de Eventos"
    'Load del Formulario
    Private Sub frmEmpleados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            'seteo el font a 8px
            DG_Empleados.AlternatingRowsDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DG_Empleados.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DG_Empleados.RowHeadersDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DG_Empleados.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

            'Sucursal default
            id_Sucursal = My.Settings("Sucursal")
            ESucursal = NegSucursal.TraerSucursal(id_Sucursal)
            Nombre_Sucursal = ESucursal.Nombre

            'seteo las imagenes
            Dim ListaImagenes = New ImageList
            ListaImagenes.ImageSize = New Size(32, 32)
            ListaImagenes.TransparentColor = Color.Blue
            ListaImagenes.ColorDepth = ColorDepth.Depth32Bit

            ListaImagenes.Images.Add(My.Resources.Recursos.Empleado)
            ListaImagenes.Images.Add(My.Resources.Recursos.IconoADD)
            ListaImagenes.Images.Add(My.Resources.Recursos.Lapiz)

            TabEmpleados.ImageList = ListaImagenes

            'icono de empleado
            TbListado.ImageIndex = 0
            'icono de alta
            TbAlta.ImageIndex = 1
            'icono de edicion
            TbMod.ImageIndex = 2

            'Cargo el datagrid | depende si es admin o no cargo todos o solo los especificos para la sucursal
            If VariablesGlobales.objUsuario.id_Perfil = 1 Then
                Dim dsEmp As New DataSet
                dsEmp = NegEmpleados.ListadoEmpleados()

                If (dsEmp.Tables(0).Rows.Count > 0) Then
                    For Each emp In dsEmp.Tables(0).Rows
                        emp.item("Sucursal") = NegEmpleados.TraerSucursalesEmpleado(emp.item("id_Empleado"))
                    Next
                    DG_Empleados.DataSource = dsEmp.Tables(0)
                    DG_Empleados.AutoGenerateColumns = False
                    DG_Empleados.ColumnHeadersVisible = True
                    DG_Empleados.Columns("Telefono").Visible = False
                    DG_Empleados.Columns("id_Empleado").Visible = False
                    DG_Empleados.Columns("NombreCompleto").Visible = False
                    DG_Empleados.Columns("SueldoFeriado").Visible = False
                    DG_Empleados.Columns("SueldoNormal").Visible = False
                    DG_Empleados.Columns("Modificar").DisplayIndex = 9
                    DG_Empleados.Columns("Eliminar").DisplayIndex = 9
                    DG_Empleados.Refresh()
                    lbl_Msg.Visible = False
                Else
                    DG_Empleados.ColumnHeadersVisible = False
                    DG_Empleados.Refresh()
                    lbl_Msg.Visible = True
                End If
            Else
                Dim dsEmp As New DataSet
                dsEmp = NegEmpleados.ListadoEmpleadosSucursal(id_Sucursal)
                If (dsEmp.Tables(0).Rows.Count > 0) Then
                    DG_Empleados.DataSource = dsEmp.Tables(0)
                    DG_Empleados.AutoGenerateColumns = False
                    DG_Empleados.ColumnHeadersVisible = True
                    DG_Empleados.Columns("Telefono").Visible = False
                    DG_Empleados.Columns("id_Empleado").Visible = False
                    DG_Empleados.Columns("NombreCompleto").Visible = False
                    DG_Empleados.Columns("SueldoFeriado").Visible = False
                    DG_Empleados.Columns("SueldoNormal").Visible = False
                    DG_Empleados.Columns("Modificar").DisplayIndex = 9
                    DG_Empleados.Columns("Eliminar").DisplayIndex = 9
                    DG_Empleados.Refresh()
                    lbl_Msg.Visible = False
                Else
                    DG_Empleados.ColumnHeadersVisible = False
                    DG_Empleados.Refresh()
                    lbl_Msg.Visible = True
                End If
            End If

            'AGREGADO PARA EL FUNCIONAMIENTO CORRECTO DEPENDIENDO DE LAS PATENTES.
            Dim objusuario As New Negocio.Usuario
            Dim NegPatentes As New Negocio.NegPatentes

            'ALTA
            Dim Pat3 As New DataSet
            Pat3 = NegPatentes.ListadoPatentesPorTipo(3, 1, My.Settings("Sucursal"))
            If Pat3.Tables(0).Rows.Count > 0 Then
                For Each p In Pat3.Tables(0).Rows
                    Dim id_Patente As Integer = p.item("id_Patente").ToString()

                    If Not (objusuario.EsPatenteValida(id_Patente, VariablesGlobales.Patentes)) Then
                        TabEmpleados.TabPages.Remove(Me.TbAlta)
                    End If
                Next
            End If

            'BAJA
            Dim Pat4 As New DataSet
            Pat4 = NegPatentes.ListadoPatentesPorTipo(3, 2, My.Settings("Sucursal"))
            If Pat4.Tables(0).Rows.Count > 0 Then
                For Each p In Pat4.Tables(0).Rows
                    Dim id_Patente As Integer = p.item("id_Patente").ToString()

                    If Not (objusuario.EsPatenteValida(id_Patente, VariablesGlobales.Patentes)) Then
                        TabEmpleados.TabPages.Remove(Me.TbMod)
                        DG_Empleados.Columns("Modificar").Visible = False
                    End If
                Next
            End If

            'MODIFICACION
            Dim Pat5 As New DataSet
            Pat5 = NegPatentes.ListadoPatentesPorTipo(3, 3, My.Settings("Sucursal"))
            If Pat5.Tables(0).Rows.Count > 0 Then
                For Each p In Pat5.Tables(0).Rows
                    Dim id_Patente As Integer = p.item("id_Patente").ToString()

                    If Not (objusuario.EsPatenteValida(id_Patente, VariablesGlobales.Patentes)) Then
                        TabEmpleados.TabPages.Remove(Me.TbMod)
                        DG_Empleados.Columns("Eliminar").Visible = False
                    End If
                Next
            End If

            'Cambio el cursor a NORMAL.
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            'Cambio el cursor a NORMAL.
            Me.Cursor = Cursors.Arrow
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub Btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cancelar.Click
        'Redirecciono al listado
        TabEmpleados.SelectedIndex = 0
    End Sub

    'Boton Agregar Empleado.
    Private Sub Btn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Agregar.Click
        If txt_SueldoFeriado.Text = "" Or txt_SueldoNormal.Text = "" Or txt_Direccion.Text = "" Or txt_CodigoPostal.Text = "" Or txt_Apellido.Text = "" Or txt_Nombre.Text = "" Or cb_Provincia.SelectedItem Is Nothing Or cb_Distrito.SelectedItem Is Nothing Or cb_Localidad.SelectedItem Is Nothing Or cb_TipoEmpleado.SelectedItem Is Nothing Or CheckSucursales.SelectedItems.Count <= 0 Then
            MessageBox.Show("Debe completar los campos requeridos.", "Administración de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                'Cursors.
                Me.Cursor = Cursors.WaitCursor

                'Lleno la entidad empleado
                EEmpleados.Nombre = Trim(txt_Nombre.Text)
                EEmpleados.Apellido = Trim(txt_Apellido.Text)
                EEmpleados.Telefono = Trim(txt_Telefono.Text)
                EEmpleados.Telefono2 = Trim(txt_Telefono2.Text)
                EEmpleados.Mail = Trim(txt_Mail.Text)
                If txt_Observaciones.Text <> "" Then
                    EEmpleados.Observaciones = Replace(Trim(txt_Observaciones.Text), vbCrLf, "<br />")
                Else
                    EEmpleados.Observaciones = ""
                End If
                EEmpleados.Cuil = Trim(txt_Cuil.Text)
                EEmpleados.Codigo_Postal = Trim(txt_CodigoPostal.Text)
                EEmpleados.Direccion = Trim(txt_Direccion.Text)
                EEmpleados.SueldoFeriado = Trim(txt_SueldoFeriado.Text)
                EEmpleados.SueldoNormal = Trim(txt_SueldoNormal.Text)
                EEmpleados.id_Provincia = cb_Provincia.SelectedValue
                EEmpleados.id_TipoEmpleado = cb_TipoEmpleado.SelectedValue
                EEmpleados.id_Localidad = cb_Localidad.SelectedValue
                EEmpleados.id_Distrito = cb_Distrito.SelectedValue
                EEmpleados.FechaIngreso = FechaIngreso.Value
                EEmpleados.FechaNacimiento = FechaNacimiento.Value
                If VariablesGlobales.objUsuario.id_Perfil = 1 Then 'si es administrador
                    EEmpleados.Sucursales = CheckSucursales
                Else
                    EEmpleados.id_Sucursal = id_Sucursal
                End If

                If chk_Habilitado.Checked = True Then
                    EEmpleados.Habilitado = 1
                Else
                    EEmpleados.Habilitado = 0
                End If

                'Ejecuto el sp_Empleados_Alta
                MessageBox.Show(NegEmpleados.AltaEmpleado(EEmpleados), "Administración de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information)

                'Cursors.
                Me.Cursor = Cursors.Arrow

                'Limpio el formulario
                LimpiarFormAltaEmpleados()

            Catch ex As Exception
                Me.Cursor = Cursors.Arrow
                MessageBox.Show("Se ha producido un error al registrar el empleado. Por favor, intente más tarde.", "Administración de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    'Boton Modificar Empleado.
    Private Sub Btn_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Modificar.Click
        If txt_SueldoFeriado_mod.Text = "" Or txt_SueldoNormal_mod.Text = "" Or txt_Direccion_mod.Text = "" Or txt_CodigoPostal_mod.Text = "" Or txt_Nombre_mod.Text = "" Or txt_Apellido_mod.Text = "" Or cb_Provincia_mod.SelectedItem Is Nothing Or cb_Distrito_mod.SelectedItem Is Nothing Or cb_Localidad_mod.SelectedItem Is Nothing Or cb_TipoEmpleado_mod.SelectedItem Is Nothing Or CheckSucursales_mod.SelectedItems.Count <= 0 Then
            MessageBox.Show("Debe completar los campos requeridos.", "Administración de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                'Cursors.
                Me.Cursor = Cursors.WaitCursor

                'Lleno la entidad empleado
                EEmpleados.Nombre = Trim(txt_Nombre_mod.Text)
                EEmpleados.Apellido = Trim(txt_Apellido_mod.Text)
                EEmpleados.Telefono = Trim(txt_Telefono_mod.Text)
                EEmpleados.Telefono2 = Trim(txt_Telefono2_mod.Text)
                EEmpleados.Mail = Trim(txt_Mail_mod.Text)
                If txt_Observaciones_mod.Text <> "" Then
                    EEmpleados.Observaciones = Replace(Trim(txt_Observaciones_mod.Text), vbCrLf, "<br />")
                Else
                    EEmpleados.Observaciones = ""
                End If
                EEmpleados.Cuil = Trim(txt_Cuil_mod.Text)
                EEmpleados.Codigo_Postal = Trim(txt_CodigoPostal_mod.Text)
                EEmpleados.Direccion = Trim(txt_Direccion_mod.Text)
                EEmpleados.SueldoFeriado = Trim(txt_SueldoFeriado_mod.Text)
                EEmpleados.SueldoNormal = Trim(txt_SueldoNormal_mod.Text)
                EEmpleados.id_Provincia = cb_Provincia_mod.SelectedValue
                EEmpleados.id_TipoEmpleado = cb_TipoEmpleado_mod.SelectedValue
                EEmpleados.id_Localidad = cb_Localidad_mod.SelectedValue
                EEmpleados.id_Distrito = cb_Distrito_mod.SelectedValue
                EEmpleados.FechaIngreso = FechaIngreso_mod.Value
                EEmpleados.FechaNacimiento = FechaNacimiento_mod.Value
                If VariablesGlobales.objUsuario.id_Perfil = 1 Then 'si es administrador
                    EEmpleados.Sucursales = CheckSucursales_mod
                Else
                    EEmpleados.id_Sucursal = id_Sucursal
                End If

                If chk_Habilitado_mod.Checked = True Then
                    EEmpleados.Habilitado = 1
                Else
                    EEmpleados.Habilitado = 0
                End If

                'Ejecuto el sp_Clientes_Alta
                MessageBox.Show(NegEmpleados.ModificacionEmpleado(EEmpleados), "Administración de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information)

                'Cursors.
                Me.Cursor = Cursors.Arrow

                'Limpio el formulario
                LimpiarFormModificacionEmpleados()

            Catch ex As Exception
                Me.Cursor = Cursors.Arrow
                MessageBox.Show("Se ha producido un error al modificar el empleado. Por favor, intente más tarde.", "Administración de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            'Redirecciono al listado
            TabEmpleados.SelectedIndex = 0
        End If
    End Sub

    'Boton Buscar.
    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        'Seteo las variables.
        Dim descrip As String
        descrip = Trim(txt_buscar.Text.ToLower)

        If descrip = "" Then
            ErrorEmpleados.SetError(txt_buscar, "Debe completar el campo de busqueda.")
        Else
            ErrorEmpleados.SetError(txt_buscar, Nothing)

            Dim dv As DataView
            Dim dsEmp As New DataSet

            If VariablesGlobales.objUsuario.id_Perfil = 1 Then
                dsEmp = NegEmpleados.ListadoEmpleados()
                For Each emp In dsEmp.Tables(0).Rows
                    emp.item("Sucursal") = NegEmpleados.TraerSucursalesEmpleado(emp.item("id_Empleado"))
                Next
                dv = dsEmp.Tables(0).DefaultView
            Else
                dv = NegEmpleados.ListadoEmpleadosSucursal(id_Sucursal).Tables(0).DefaultView
            End If

            'filtro el dataset por la descripcion que se va ingresando
            dv.RowFilter = "Apellido LIKE '%" + descrip + "%'"

            'actualizo el datagrid
            If dv.Count > 0 Then
                DG_Empleados.ColumnHeadersVisible = True
                DG_Empleados.DataSource = dv
                DG_Empleados.Refresh()
                lbl_Msg.Visible = False
            Else
                DG_Empleados.ColumnHeadersVisible = False
                DG_Empleados.DataSource = Nothing
                DG_Empleados.Refresh()
                lbl_Msg.Visible = True
            End If

        End If
    End Sub

    'Solapas.
    Private Sub TabEmpleados_Selected(ByVal sender As Object, ByVal e As System.Windows.Forms.TabControlEventArgs) Handles TabEmpleados.Selected
        'Cambio el cursor a "WAIT"
        TabEmpleados.Cursor = Cursors.WaitCursor

        If TabEmpleados.SelectedIndex = 0 Then 'TAB LISTADO DE EMPLEADO
            'Actualizo el datagrid si se selecciona el tab del listado
            If VariablesGlobales.objUsuario.id_Perfil = 1 Then
                Dim DsEmpleados As New DataSet
                DsEmpleados = NegEmpleados.ListadoEmpleados()
                If DsEmpleados.Tables(0).Rows.Count > 0 Then
                    For Each emp In DsEmpleados.Tables(0).Rows
                        emp.item("Sucursal") = NegEmpleados.TraerSucursalesEmpleado(emp.item("id_Empleado"))
                    Next
                    DG_Empleados.DataSource = DsEmpleados.Tables(0)
                    DG_Empleados.AutoGenerateColumns = False
                    DG_Empleados.ColumnHeadersVisible = True
                    DG_Empleados.Columns("Telefono").Visible = False
                    DG_Empleados.Columns("id_Empleado").Visible = False
                    DG_Empleados.Columns("NombreCompleto").Visible = False
                    DG_Empleados.Columns("SueldoFeriado").Visible = False
                    DG_Empleados.Columns("SueldoNormal").Visible = False
                    DG_Empleados.Columns("Modificar").DisplayIndex = 9
                    DG_Empleados.Columns("Eliminar").DisplayIndex = 9
                    DG_Empleados.Refresh()
                    lbl_Msg.Visible = False
                Else
                    DG_Empleados.ColumnHeadersVisible = False
                    DG_Empleados.Refresh()
                    lbl_Msg.Visible = True
                End If
            Else
                Dim DsEmpleados As New DataSet
                DsEmpleados = NegEmpleados.ListadoEmpleadosSucursal(id_Sucursal)
                If DsEmpleados.Tables(0).Rows.Count > 0 Then
                    DG_Empleados.DataSource = DsEmpleados.Tables(0)
                    DG_Empleados.AutoGenerateColumns = False
                    DG_Empleados.ColumnHeadersVisible = True
                    DG_Empleados.Columns("Telefono").Visible = False
                    DG_Empleados.Columns("id_Empleado").Visible = False
                    DG_Empleados.Columns("NombreCompleto").Visible = False
                    DG_Empleados.Columns("SueldoFeriado").Visible = False
                    DG_Empleados.Columns("SueldoNormal").Visible = False
                    DG_Empleados.Columns("Modificar").DisplayIndex = 9
                    DG_Empleados.Columns("Eliminar").DisplayIndex = 9
                    DG_Empleados.Refresh()
                    lbl_Msg.Visible = False
                Else
                    DG_Empleados.ColumnHeadersVisible = False
                    DG_Empleados.Refresh()
                    lbl_Msg.Visible = True
                End If
            End If

        'Limpio los formularios
        LimpiarFormAltaEmpleados()
        LimpiarFormModificacionEmpleados()

        'Seteo el id_Empleado en cero
        EEmpleados.id_Empleado = 0

        ElseIf TabEmpleados.SelectedIndex = 1 Then 'TAB ALTA DE EMPLEADO

            'Cargo el combo de sucursales
            If VariablesGlobales.objUsuario.id_Perfil = 1 Then
                Dim DsSucursales As New DataSet
                DsSucursales = NegSucursal.ListadoSucursales()
                If DsSucursales.Tables(0).Rows.Count > 0 Then
                    CheckSucursales.DataSource = DsSucursales.Tables(0)
                    CheckSucursales.DisplayMember = "Nombre"
                    CheckSucursales.ValueMember = "id_Sucursal"
                    CheckSucursales.Refresh()
                End If

                'Chequeo la sucursal de la aplicaicon.
                For i As Integer = 0 To CheckSucursales.Items.Count - 1
                    If DirectCast(CheckSucursales.Items(i), System.Data.DataRowView).Row.ItemArray(0) = My.Settings.Sucursal Then
                        CheckSucursales.SetItemChecked(i, True)
                    End If
                Next i
            Else
                CheckSucursales.Visible = False
                lbl_Sucursal.Visible = False
            End If

            'Limpio el formulario de alta.
            LimpiarFormAltaEmpleados()

            'Seteo el id_Empleado en cero
            EEmpleados.id_Empleado = 0

        ElseIf TabEmpleados.SelectedIndex = 2 Then 'TAB MODIFICACION DE EMPLEADO
        If EEmpleados.id_Empleado > 0 Or EEmpleados.id_Empleado <> Nothing Then

        Else
            MessageBox.Show("Debe seleccionar previamente un empleado.", "Administración de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            TabEmpleados.SelectedIndex = 0
        End If
        End If

        'Cambio el cursor a NORMAL.
        TabEmpleados.Cursor = Cursors.Arrow
    End Sub

    'Click en el listado de empleados.
    Private Sub DG_Empleados_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Empleados.CellContentClick
        If DG_Empleados.Columns(e.ColumnIndex).Name = "Eliminar" Then 'Si se hace click en el boton "eliminar" de la fila.
            Dim Result As DialogResult
            Result = MessageBox.Show("¿Está seguro que desea eliminar el empleado?", "Administración de Empleados", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Result = System.Windows.Forms.DialogResult.Yes Then 'Si acepta eliminar el item

                'Cambio el cursor a "WAIT"
                TabEmpleados.Cursor = Cursors.WaitCursor

                Dim id_Empleado As Integer = DG_Empleados.Rows(e.RowIndex).Cells("id_Empleado").Value
                If id_Empleado = 0 Then
                    'si no completo la descripcion, muestro un msg de error.
                    MessageBox.Show("No se puede eliminar el empleado.", "Administración de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    'ejecuto el sp_EliminarColores.
                    MessageBox.Show(NegEmpleados.EliminarEmpleado(id_Empleado), "Administración de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    'refresco el datagrid
                    DG_Empleados.DataSource = NegEmpleados.ListadoEmpleadosSucursal(id_Sucursal).Tables(0)
                    DG_Empleados.Refresh()
                End If

                'Cambio el cursor a NORMAL.
                TabEmpleados.Cursor = Cursors.Arrow
            End If
        ElseIf DG_Empleados.Columns(e.ColumnIndex).Name = "Modificar" Then 'Si se hace click en el boton "modificar" de la fila.

            'Cambio el cursor a "WAIT"
            TabEmpleados.Cursor = Cursors.WaitCursor

            Dim id_Empleado As Integer = DG_Empleados.Rows(e.RowIndex).Cells("id_Empleado").Value()
            EEmpleados.id_Empleado = id_Empleado

            'lleno la entidad empleado
            EEmpleados = NegEmpleados.TraerEmpleado(id_Empleado)

            'lleno los controls del tab_modificacion
            txt_Nombre_mod.Text = EEmpleados.Nombre
            txt_Telefono_mod.Text = EEmpleados.Telefono
            txt_Telefono2_mod.Text = EEmpleados.Telefono2
            txt_Mail_mod.Text = EEmpleados.Mail
            txt_Apellido_mod.Text = EEmpleados.Apellido
            If EEmpleados.Observaciones <> "" Then
                txt_Observaciones_mod.Text = Replace(Trim(EEmpleados.Observaciones), "<br />", vbCrLf)
            Else
                txt_Observaciones_mod.Text = ""
            End If
            txt_Cuil_mod.Text = EEmpleados.Cuil
            txt_CodigoPostal_mod.Text = EEmpleados.Codigo_Postal
            txt_Direccion_mod.Text = EEmpleados.Direccion
            txt_SueldoFeriado_mod.Text = EEmpleados.SueldoFeriado
            txt_SueldoNormal_mod.Text = EEmpleados.SueldoNormal
            FechaNacimiento_mod.Value = EEmpleados.FechaNacimiento
            FechaIngreso_mod.Value = EEmpleados.FechaIngreso

            'Cargo el combo de Provincias
            Dim DsProvincias As New DataSet
            DsProvincias = NegProvincias.ListadoProvincias()
            If (DsProvincias.Tables(0).Rows.Count > 0) Then
                cb_Provincia_mod.DataSource = Nothing
                cb_Provincia_mod.DataSource = DsProvincias.Tables(0)
                cb_Provincia_mod.DisplayMember = "Descripcion"
                cb_Provincia_mod.ValueMember = "id_Provincia"
                cb_Provincia_mod.SelectedValue = EEmpleados.id_Provincia
                cb_Provincia_mod.Refresh()
            End If

            'Cargo el combo de Distritos
            Dim DsDistritos As New DataSet
            DsDistritos = NegDistritos.ListadoDistritos(EEmpleados.id_Provincia)
            If (DsDistritos.Tables(0).Rows.Count > 0) Then
                cb_Distrito_mod.DataSource = Nothing
                cb_Distrito_mod.DataSource = DsDistritos.Tables(0)
                cb_Distrito_mod.DisplayMember = "Descripcion"
                cb_Distrito_mod.ValueMember = "id_Departamento"
                cb_Distrito_mod.SelectedValue = EEmpleados.id_Distrito
                cb_Distrito_mod.Refresh()
            End If

            'Cargo el combo de Localidades
            Dim DsLocalidades As New DataSet
            DsLocalidades = NegLocalidades.ListadoLocalidades(EEmpleados.id_Distrito)
            If DsLocalidades.Tables(0).Rows.Count > 0 Then
                cb_Localidad_mod.DataSource = Nothing
                cb_Localidad_mod.DataSource = DsLocalidades.Tables(0)
                cb_Localidad_mod.DisplayMember = "Descripcion"
                cb_Localidad_mod.ValueMember = "id_Localidad"
                cb_Localidad_mod.SelectedValue = EEmpleados.id_Localidad
                cb_Localidad_mod.Refresh()
            End If

            'Cargo el combo de Tipos de Empleado
            Dim DsTiposEmpleados As New DataSet
            DsTiposEmpleados = NegTiposEmpleado.ListadoTipos()
            If (DsTiposEmpleados.Tables(0).Rows.Count > 0) Then
                cb_TipoEmpleado_mod.DataSource = Nothing
                cb_TipoEmpleado_mod.DataSource = DsTiposEmpleados.Tables(0)
                cb_TipoEmpleado_mod.DisplayMember = "TipoEmpleado"
                cb_TipoEmpleado_mod.ValueMember = "id_TipoEmpleado"
                cb_TipoEmpleado_mod.SelectedValue = EEmpleados.id_TipoEmpleado
                cb_TipoEmpleado_mod.Refresh()
            End If

            'Cargo el combo de sucursales
            If VariablesGlobales.objUsuario.id_Perfil = 1 Then
                Dim DsSucursales As New DataSet
                DsSucursales = NegSucursal.ListadoSucursales()
                If DsSucursales.Tables(0).Rows.Count > 0 Then
                    CheckSucursales_mod.DataSource = DsSucursales.Tables(0)
                    CheckSucursales_mod.DisplayMember = "Nombre"
                    CheckSucursales_mod.ValueMember = "id_Sucursal"
                    CheckSucursales_mod.Refresh()
                End If

                If (NegSucursal.ListadoSucursalesEmpleado(id_Empleado).Tables.Count <> 0) Then
                    For i As Integer = 0 To CheckSucursales_mod.Items.Count - 1
                        For Each DataRow In NegSucursal.ListadoSucursalesEmpleado(id_Empleado).Tables(0).Rows
                            If DirectCast(CheckSucursales_mod.Items(i), System.Data.DataRowView).Row.ItemArray(0) = DirectCast(DataRow, System.Data.DataRow).ItemArray(0) Then
                                CheckSucursales_mod.SetItemChecked(i, True)
                            End If
                        Next
                    Next i
                End If
            Else
                CheckSucursales.Visible = False
                lbl_Sucursal.Visible = False
            End If

            If EEmpleados.Habilitado = "1" Then
                chk_Habilitado_mod.Checked = True
            Else
                chk_Habilitado_mod.Checked = False
            End If

            'Cambio el cursor a NORMAL.
            TabEmpleados.Cursor = Cursors.Arrow

            'hago foco en el tab_modificacion 
            TabEmpleados.SelectedIndex = 2
        End If
    End Sub

    'Boton Eliminar Empleado.
    Private Sub Btn_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Eliminar.Click
        Dim Result As DialogResult
        Result = MessageBox.Show("¿Está seguro que desea eliminar el empleado?", "Administración de Empleados", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If Result = System.Windows.Forms.DialogResult.Yes Then 'Si acepta eliminar el item

            'Cambio el cursor a "WAIT"
            TabEmpleados.Cursor = Cursors.WaitCursor

            Dim id_Empleado As Integer = EEmpleados.id_Empleado
            If id_Empleado = 0 Then
                'si no completo la descripcion, muestro un msg de error.
                MessageBox.Show("No se puede eliminar el empleado.", "Administración de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                'ejecuto el sp_EliminarColores.
                MessageBox.Show(NegEmpleados.EliminarEmpleado(id_Empleado), "Administración de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information)

                'redirecciona al tab_listado
                TabEmpleados.SelectedIndex = 0
            End If

            'Cambio el cursor a NORMAL.
            TabEmpleados.Cursor = Cursors.Arrow
        End If
    End Sub

    'Boton Reestablecer listado
    Private Sub btn_Restablecer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Restablecer.Click
        Try
            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            'Cargo el datagrid | depende si es admin o no cargo todos o solo los especificos para la sucursal
            If VariablesGlobales.objUsuario.id_Perfil = 1 Then
                Dim dsEmp As New DataSet
                dsEmp = NegEmpleados.ListadoEmpleados()
                If (dsEmp.Tables(0).Rows.Count > 0) Then
                    For Each emp In dsEmp.Tables(0).Rows
                        emp.item("Sucursal") = NegEmpleados.TraerSucursalesEmpleado(emp.item("id_Empleado"))
                    Next
                    DG_Empleados.DataSource = dsEmp.Tables(0)
                    DG_Empleados.AutoGenerateColumns = False
                    DG_Empleados.ColumnHeadersVisible = True
                    DG_Empleados.Columns("Telefono").Visible = False
                    DG_Empleados.Columns("id_Empleado").Visible = False
                    DG_Empleados.Columns("NombreCompleto").Visible = False
                    DG_Empleados.Columns("SueldoFeriado").Visible = False
                    DG_Empleados.Columns("SueldoNormal").Visible = False
                    DG_Empleados.Columns("Modificar").DisplayIndex = 9
                    DG_Empleados.Columns("Eliminar").DisplayIndex = 9
                    DG_Empleados.Refresh()
                    lbl_Msg.Visible = False
                Else
                    DG_Empleados.ColumnHeadersVisible = False
                    DG_Empleados.Refresh()
                    lbl_Msg.Visible = True
                End If
            Else
                Dim dsEmp As New DataSet
                dsEmp = NegEmpleados.ListadoEmpleadosSucursal(id_Sucursal)
                If (dsEmp.Tables(0).Rows.Count > 0) Then
                    DG_Empleados.DataSource = dsEmp.Tables(0)
                    DG_Empleados.AutoGenerateColumns = False
                    DG_Empleados.ColumnHeadersVisible = True
                    DG_Empleados.Columns("Telefono").Visible = False
                    DG_Empleados.Columns("id_Empleado").Visible = False
                    DG_Empleados.Columns("NombreCompleto").Visible = False
                    DG_Empleados.Columns("SueldoFeriado").Visible = False
                    DG_Empleados.Columns("SueldoNormal").Visible = False
                    DG_Empleados.Columns("Modificar").DisplayIndex = 9
                    DG_Empleados.Columns("Eliminar").DisplayIndex = 9
                    DG_Empleados.Refresh()
                    lbl_Msg.Visible = False
                Else
                    DG_Empleados.ColumnHeadersVisible = False
                    DG_Empleados.Refresh()
                    lbl_Msg.Visible = True
                End If
            End If

            txt_buscar.Clear()
            txt_buscar.Focus()

            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha encontrado un error al restablecer el listado.", "Administración de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'Doble click en el listado de empleados.
    Private Sub DG_Empleados_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Empleados.CellDoubleClick
        If DG_Empleados.SelectedRows.Count > 0 Then
            If e.RowIndex >= 0 Then
                'Cambio el cursor a "WAIT"
                TabEmpleados.Cursor = Cursors.WaitCursor

                Dim id_Empleado As Integer = DG_Empleados.Rows(e.RowIndex).Cells("id_Empleado").Value()
                EEmpleados.id_Empleado = id_Empleado

                'lleno la entidad empleado
                EEmpleados = NegEmpleados.TraerEmpleado(id_Empleado)

                'lleno los controls del tab_modificacion
                txt_Nombre_mod.Text = EEmpleados.Nombre
                txt_Telefono_mod.Text = EEmpleados.Telefono
                txt_Telefono2_mod.Text = EEmpleados.Telefono2
                txt_Mail_mod.Text = EEmpleados.Mail
                txt_Apellido_mod.Text = EEmpleados.Apellido
                If EEmpleados.Observaciones <> "" Then
                    txt_Observaciones_mod.Text = Replace(Trim(EEmpleados.Observaciones), "<br />", vbCrLf)
                Else
                    txt_Observaciones_mod.Text = ""
                End If
                txt_Cuil_mod.Text = EEmpleados.Cuil
                txt_CodigoPostal_mod.Text = EEmpleados.Codigo_Postal
                txt_Direccion_mod.Text = EEmpleados.Direccion
                txt_SueldoFeriado_mod.Text = EEmpleados.SueldoFeriado
                txt_SueldoNormal_mod.Text = EEmpleados.SueldoNormal
                FechaNacimiento_mod.Value = EEmpleados.FechaNacimiento
                FechaIngreso_mod.Value = EEmpleados.FechaIngreso

                'Cargo el combo de Provincias
                Dim dsProvincias As New DataSet
                dsProvincias = NegProvincias.ListadoProvincias()
                If dsProvincias.Tables(0).Rows.Count > 0 Then
                    cb_Provincia_mod.DataSource = Nothing
                    cb_Provincia_mod.DataSource = dsProvincias.Tables(0)
                    cb_Provincia_mod.DisplayMember = "Descripcion"
                    cb_Provincia_mod.ValueMember = "id_Provincia"
                    cb_Provincia_mod.SelectedValue = EEmpleados.id_Provincia
                    cb_Provincia_mod.Refresh()
                End If

                'Cargo el combo de Distritos
                Dim dsDistritos As New DataSet
                dsDistritos = NegDistritos.ListadoDistritos(EEmpleados.id_Provincia)
                If dsDistritos.Tables(0).Rows.Count > 0 Then
                    cb_Distrito_mod.DataSource = Nothing
                    cb_Distrito_mod.DataSource = dsDistritos.Tables(0)
                    cb_Distrito_mod.DisplayMember = "Descripcion"
                    cb_Distrito_mod.ValueMember = "id_Departamento"
                    cb_Distrito_mod.SelectedValue = EEmpleados.id_Distrito
                    cb_Distrito_mod.Refresh()
                End If

                'Cargo el combo de Localidades
                Dim dsLocalidades As New DataSet
                dsLocalidades = NegLocalidades.ListadoLocalidades(EEmpleados.id_Distrito)
                If dsLocalidades.Tables(0).Rows.Count > 0 Then
                    cb_Localidad_mod.DataSource = Nothing
                    cb_Localidad_mod.DataSource = dsLocalidades.Tables(0)
                    cb_Localidad_mod.DisplayMember = "Descripcion"
                    cb_Localidad_mod.ValueMember = "id_Localidad"
                    cb_Localidad_mod.SelectedValue = EEmpleados.id_Localidad
                    cb_Localidad_mod.Refresh()
                End If

                'Cargo el combo de Tipos de Empleado
                Dim dsTipos As New DataSet
                dsTipos = NegTiposEmpleado.ListadoTipos()
                If dsTipos.Tables(0).Rows.Count > 0 Then
                    cb_TipoEmpleado_mod.DataSource = Nothing
                    cb_TipoEmpleado_mod.DataSource = dsTipos.Tables(0)
                    cb_TipoEmpleado_mod.DisplayMember = "TipoEmpleado"
                    cb_TipoEmpleado_mod.ValueMember = "id_TipoEmpleado"
                    cb_TipoEmpleado_mod.SelectedValue = EEmpleados.id_TipoEmpleado
                    cb_TipoEmpleado_mod.Refresh()
                End If

                'Cargo el combo de sucursales
                If VariablesGlobales.objUsuario.id_Perfil = 1 Then
                    Dim DsSucursales As New DataSet
                    DsSucursales = NegSucursal.ListadoSucursales()
                    If DsSucursales.Tables(0).Rows.Count > 0 Then
                        CheckSucursales_mod.DataSource = DsSucursales.Tables(0)
                        CheckSucursales_mod.DisplayMember = "Nombre"
                        CheckSucursales_mod.ValueMember = "id_Sucursal"
                        CheckSucursales_mod.Refresh()
                    End If

                    'primero hay que ver si ese producto tiene algun aroma ya cargado sino no vale la pena entrar a ningun for
                    If (NegSucursal.ListadoSucursalesEmpleado(id_Empleado).Tables.Count <> 0) Then
                        For i As Integer = 0 To CheckSucursales_mod.Items.Count - 1
                            For Each DataRow In NegSucursal.ListadoSucursalesEmpleado(id_Empleado).Tables(0).Rows
                                If DirectCast(CheckSucursales_mod.Items(i), System.Data.DataRowView).Row.ItemArray(0) = DirectCast(DataRow, System.Data.DataRow).ItemArray(0) Then
                                    CheckSucursales_mod.SetItemChecked(i, True)
                                End If
                            Next
                        Next i
                    End If
                Else
                    CheckSucursales.Visible = False
                    lbl_Sucursal.Visible = False
                End If

                If EEmpleados.Habilitado = "1" Then
                    chk_Habilitado_mod.Checked = True
                Else
                    chk_Habilitado_mod.Checked = False
                End If

                'Cambio el cursor a NORMAL.
                TabEmpleados.Cursor = Cursors.Arrow

                'hago foco en el tab_modificacion 
                TabEmpleados.SelectedIndex = 2
            End If
        End If
    End Sub
#End Region

#Region "Región Carga de Combos."
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

    'Cargo el combo de Distritos.
    Private Sub cb_Provincia_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_Provincia.SelectionChangeCommitted
        If cb_Provincia.SelectedValue <> 0 Then
            Dim dsDistritos As New DataSet
            dsDistritos = NegDistritos.ListadoDistritos(cb_Provincia.SelectedValue)
            If dsDistritos.Tables(0).Rows.Count > 0 Then
                cb_Distrito.DataSource = Nothing
                cb_Distrito.DataSource = dsDistritos.Tables(0)
                cb_Distrito.DisplayMember = "Descripcion"
                cb_Distrito.ValueMember = "id_Departamento"
                cb_Distrito.Refresh()
            End If
        End If
    End Sub

    'Cargo el combo de Localidades.
    Private Sub cb_Distrito_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_Distrito.SelectionChangeCommitted
        If cb_Distrito.SelectedValue <> 0 Then
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

    'Cargo el combo de tipos de Empleado
    Private Sub cb_TipoComision_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_TipoEmpleado.GotFocus
        Dim dsTipos As New DataSet
        dsTipos = NegTiposEmpleado.ListadoTipos()
        If dsTipos.Tables(0).Rows.Count > 0 Then
            cb_TipoEmpleado.DataSource = Nothing
            cb_TipoEmpleado.DataSource = dsTipos.Tables(0)
            cb_TipoEmpleado.DisplayMember = "TipoEmpleado"
            cb_TipoEmpleado.ValueMember = "id_TipoEmpleado"
            cb_TipoEmpleado.Refresh()
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
#End Region

#Region "Región Validaciones de formulario Alta"
    'Valido que se complete el nombre.
    Private Sub txt_Nombre_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_Nombre.Validating
        If txt_Nombre.Text = "" Then
            ErrorEmpleados.SetError(txt_Nombre, "Debe completar el Nombre.")
        Else
            ErrorEmpleados.SetError(txt_Nombre, Nothing)
        End If
    End Sub

    'Valido que se complete el apellido.
    Private Sub txt_Apellido_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_Apellido.Validating
        If txt_Apellido.Text = "" Then
            ErrorEmpleados.SetError(txt_Apellido, "Debe completar el Apellido.")
        Else
            ErrorEmpleados.SetError(txt_Apellido, Nothing)
        End If
    End Sub

    'Valido que ingrese el codigo postal.
    Private Sub txt_CodigoPostal_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_CodigoPostal.Validating
        If txt_CodigoPostal.Text = "" Then
            ErrorEmpleados.SetError(txt_CodigoPostal, "Debe completar el Código Postal.")
        Else
            ErrorEmpleados.SetError(txt_CodigoPostal, Nothing)
        End If
    End Sub

    'valido que ingrese la direccion.
    Private Sub txt_Direccion_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_Direccion.Validating
        If txt_Direccion.Text = "" Then
            ErrorEmpleados.SetError(txt_Direccion, "Debe completar la Dirección.")
        Else
            ErrorEmpleados.SetError(txt_Direccion, Nothing)
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

    'Valido que el cuil sea correcto.
    Private Sub txt_Cuil_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not NegErrores.ValidarCuit(Trim(txt_Cuil.Text)) Then
            ErrorEmpleados.SetError(txt_Cuil, "El CUIL ingresado es incorrecto.")
        Else
            ErrorEmpleados.SetError(txt_Cuil, Nothing)
        End If
    End Sub

    'valido que se ingrese solo numeros.
    Private Sub txt_Telefono2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Telefono2.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    'valido que se ingrese solo numeros.
    Private Sub txt_CodigoPostal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_CodigoPostal.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    'Valida solo moneda.
    Private Sub txt_SueldoNormal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_SueldoNormal.KeyPress
        If e.KeyChar.ToString() = "." Then
            e.KeyChar = CChar(",")
        End If
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloCurrency(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
            ErrorEmpleados.SetError(txt_SueldoNormal, "Debe ingresar el sueldo en el formato permitido. Ejemplo: 725,50")
        Else
            ErrorEmpleados.SetError(txt_SueldoNormal, Nothing)
        End If
    End Sub

    'Valida solo moneda.
    Private Sub txt_SueldoFeriado_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_SueldoFeriado.KeyPress
        If e.KeyChar.ToString() = "." Then
            e.KeyChar = CChar(",")
        End If
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloCurrency(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
            ErrorEmpleados.SetError(txt_SueldoFeriado, "Debe ingresar el sueldo en el formato permitido. Ejemplo: 725,50")
        Else
            ErrorEmpleados.SetError(txt_SueldoFeriado, Nothing)
        End If
    End Sub
#End Region

#Region "Región Validaciones de formulario Modificar"
    'Valido que se complete el nombre.
    Private Sub txt_Nombre_mod_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_Nombre_mod.Validating
        If txt_Nombre_mod.Text = "" Then
            ErrorEmpleados.SetError(txt_Nombre_mod, "Debe completar el Nombre.")
        Else
            ErrorEmpleados.SetError(txt_Nombre_mod, Nothing)
        End If
    End Sub

    'Valido que se complete el apellido.
    Private Sub txt_Apellido_mod_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_Apellido_mod.Validating
        If txt_Apellido_mod.Text = "" Then
            ErrorEmpleados.SetError(txt_Apellido_mod, "Debe completar el Apellido.")
        Else
            ErrorEmpleados.SetError(txt_Apellido_mod, Nothing)
        End If
    End Sub

    'Valido que el cuil sea correcto.
    Private Sub txt_Cuil_mod_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not NegErrores.ValidarCuit(Trim(txt_Cuil_mod.Text)) Then
            ErrorEmpleados.SetError(txt_Cuil_mod, "El CUIL ingresado es incorrecto.")
        Else
            ErrorEmpleados.SetError(txt_Cuil_mod, Nothing)
        End If
    End Sub

    'Valido que ingrese el codigo postal.
    Private Sub txt_CodigoPostal_mod_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_CodigoPostal_mod.Validating
        If txt_CodigoPostal_mod.Text = "" Then
            ErrorEmpleados.SetError(txt_CodigoPostal_mod, "Debe completar el Código Postal.")
        Else
            ErrorEmpleados.SetError(txt_CodigoPostal_mod, Nothing)
        End If
    End Sub

    'valido que se ingrese solo numeros.
    Private Sub txt_CodigoPostal_mod_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_CodigoPostal_mod.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    'valido que ingrese la direccion.
    Private Sub txt_Direccion_mod_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_Direccion_mod.Validating
        If txt_Direccion_mod.Text = "" Then
            ErrorEmpleados.SetError(txt_Direccion_mod, "Debe completar la Dirección.")
        Else
            ErrorEmpleados.SetError(txt_Direccion_mod, Nothing)
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

    'valido que se ingrese solo numeros.
    Private Sub txt_Telefono2_mod_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Telefono2_mod.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    'Valida solo moneda.
    Private Sub txt_SueldoNormal_mod_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_SueldoNormal_mod.KeyPress
        If e.KeyChar.ToString() = "." Then
            e.KeyChar = CChar(",")
        End If
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloCurrency(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
            ErrorEmpleados.SetError(txt_SueldoNormal_mod, "Debe ingresar el sueldo en el formato permitido. Ejemplo: 725,50")
        Else
            ErrorEmpleados.SetError(txt_SueldoNormal_mod, Nothing)
        End If
    End Sub

    'Valida solo moneda.
    Private Sub txt_SueldoFeriado_mod_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_SueldoFeriado_mod.KeyPress
        If e.KeyChar.ToString() = "." Then
            e.KeyChar = CChar(",")
        End If
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloCurrency(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
            ErrorEmpleados.SetError(txt_SueldoFeriado_mod, "Debe ingresar el sueldo en el formato permitido. Ejemplo: 725,50")
        Else
            ErrorEmpleados.SetError(txt_SueldoFeriado_mod, Nothing)
        End If
    End Sub
#End Region

 
End Class