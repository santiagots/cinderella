Imports System.Configuration
Imports Datos

Public Class frmStock
    Dim Funciones As New Funciones
    Dim NegStock As New Negocio.NegStock
    Dim NegStockBitacora As New Negocio.NegStockBitacora
    Dim NegProductos As New Negocio.NegProductos
    Dim NegSucursal As New Negocio.NegSucursales
    Dim EStock As New Entidades.Stock
    Dim EStockBitacora As New Entidades.Stock_Bitacora
    Dim fuc As New Funciones
    Dim NegErrores As New Negocio.NegManejadorErrores
    Dim id_Sucursal As Integer
    Dim Nombre_Sucursal As String

#Region "Region Validaciones"
    'Valido que sea solo numeros. - STOCK MINIMO
    Private Sub txt_Minimo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Minimo.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    'Valido que sea solo numeros. - STOCK ANUAL
    Private Sub txt_Actual_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Actual.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    'Valido que sea solo numeros. - STOCK OPTIMO
    Private Sub txt_Optimo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Optimo.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    'Valido que sea solo numeros. - STOCK MINIMO - MOD
    Private Sub txt_Minimo_mod_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Minimo_mod.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    'Valido que sea solo numeros. - STOCK ANUAL - MOD
    Private Sub txt_Actual_mod_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Actual_mod.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    'Valido que sea solo numeros. - STOCK OPTIMO - MOD
    Private Sub txt_Optimo_mod_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Optimo_mod.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

#End Region

#Region "Region Funciones"
    'Limpia el formulario completamente. - ALTA
    Sub LimpiarFormAltaStock()
        txt_Actual.Clear()
        txt_Minimo.Clear()
        txt_Optimo.Clear()
        txt_Codigo.Clear()
        txt_ventaMensual.Clear()
        Cb_Sucursales.SelectedValue = id_Sucursal
        chk_Habilitado.Checked = True
    End Sub

    'Limpia el formulario completamente. - MODIFICACION
    Sub LimpiarFormModificacionStock()
        txt_Actual_mod.Clear()
        txt_Minimo_mod.Clear()
        txt_Optimo_mod.Clear()
        txt_Codigo_mod.Clear()
        txt_ventaMensual_mod.Clear()
        txt_Motivo.Clear()
        lbl_Usuario.Text = "- - - - -"
        lbl_Fecha.Text = "- - - - -"
        lbl_Motivo.Text = "- - - - -"
        Gb_Mod.Visible = False
        Cb_Sucursales_mod.SelectedValue = id_Sucursal
        chk_Habilitado_mod.Checked = True
    End Sub
#End Region

#Region "Region Eventos"
    'Load del form.
    Private Sub frmStock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            'Sucursal default
            id_Sucursal = My.Settings("Sucursal")
            Nombre_Sucursal = My.Settings("NombreSucursal")

            'seteo el font a 8px
            DG_Stock.AlternatingRowsDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DG_Stock.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DG_Stock.RowHeadersDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DG_Stock.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

            'seteo las imagenes
            Dim ListaImagenes = New ImageList
            ListaImagenes.ImageSize = New Size(32, 32)
            ListaImagenes.TransparentColor = Color.Blue
            ListaImagenes.ColorDepth = ColorDepth.Depth32Bit
            ListaImagenes.Images.Add(My.Resources.Recursos.Stock)
            ListaImagenes.Images.Add(My.Resources.Recursos.IconoADD)
            ListaImagenes.Images.Add(My.Resources.Recursos.Lapiz)
            TabStock.ImageList = ListaImagenes

            'icono de productos
            TabListado.ImageIndex = 0
            'icono de alta
            TabAlta.ImageIndex = 1
            'icono de edicion
            TabModificacion.ImageIndex = 2

            'Cargo el combo con las sucursales.
            Dim DsSucursales As New DataSet
            DsSucursales = NegSucursal.ListadoSucursales()
            If DsSucursales.Tables(0).Rows.Count > 1 Then
                Cb_Sucursal.DataSource = DsSucursales.Tables(0)
                Cb_Sucursal.DisplayMember = "Nombre"
                Cb_Sucursal.ValueMember = "id_Sucursal"
                Cb_Sucursal.SelectedValue = id_Sucursal
                Cb_Sucursal.Refresh()
            End If

            'Cargo el stock
            Dim dsStock As New DataSet
            dsStock = NegStock.ListadoStockSucursal(Cb_Sucursal.SelectedValue)
            If dsStock.Tables(0).Rows.Count > 0 Then
                DG_Stock.DataSource = dsStock.Tables(0)
                DG_Stock.AutoGenerateColumns = False
                DG_Stock.ColumnHeadersVisible = True
                DG_Stock.Columns("id_Stock").Visible = False
                DG_Stock.Columns("Codigo").DisplayIndex = 1
                DG_Stock.Columns("Categoria").DisplayIndex = 2
                DG_Stock.Columns("Producto").DisplayIndex = 3
                DG_Stock.Columns("Sucursal").DisplayIndex = 4
                DG_Stock.Columns("Minimo").DisplayIndex = 5
                DG_Stock.Columns("Actual").DisplayIndex = 6
                DG_Stock.Columns("Optimo").DisplayIndex = 7
                DG_Stock.Columns("VentaMensual").DisplayIndex = 8
                DG_Stock.Columns("Modificar").DisplayIndex = 9
                DG_Stock.Columns("Eliminar").DisplayIndex = 10
                DG_Stock.Refresh()
                lbl_Msg.Visible = False
            Else
                lbl_Msg.Visible = True
                DG_Stock.ColumnHeadersVisible = False
            End If

            'Datos fijos en solapa modificacion.
            lbl_Usuario2.Text = VariablesGlobales.objUsuario.Usuario
            lbl_Fecha2.Text = Now.ToShortDateString

            'Depende si es admin o no cargo habilito o no el combo con sucursales.
            If VariablesGlobales.objUsuario.id_Perfil = 1 AndAlso Negocio.Funciones.HayInternet Then
                Cb_Sucursal.Enabled = True
                Cb_Sucursales.Enabled = True
                Cb_Sucursales_mod.Enabled = True
            Else
                Cb_Sucursal.Enabled = False
                Cb_Sucursales.Enabled = False
                Cb_Sucursales_mod.Enabled = False
            End If

            btn_Exportar.Enabled = Negocio.Funciones.HayInternet
            btn_Importar.Enabled = Negocio.Funciones.HayInternet

            'AGREGADO PARA EL FUNCIONAMIENTO CORRECTO DEPENDIENDO DE LAS PATENTES.
            Dim objusuario As New Negocio.Usuario
            'Dim NegPatentes As New Negocio.NegPatentes

            EvaluarPermisos()

            'Cambio el cursor a NORMAL.
            Me.Cursor = Cursors.Arrow

        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha encontrado un error al cargar el stock. Por favor, contactese con el administrador.", "Administración de Stock", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Limpio los filtros del buscador.
    Private Sub btn_Restablecer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Restablecer.Click
        Try
            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            rb_Opcion.Checked = True
            rb_Opcion2.Checked = False
            txt_buscar.Clear()
            Cb_Sucursal.SelectedValue = id_Sucursal

            'Cargo el datagrid
            Dim dsStock As New DataSet
            dsStock = NegStock.ListadoStockSucursal(Cb_Sucursal.SelectedValue)
            If dsStock.Tables(0).Rows.Count > 0 Then
                DG_Stock.DataSource = dsStock.Tables(0)
                DG_Stock.AutoGenerateColumns = False
                DG_Stock.ColumnHeadersVisible = True
                DG_Stock.Columns("id_Stock").Visible = False
                DG_Stock.Columns("Codigo").DisplayIndex = 1
                DG_Stock.Columns("Categoria").DisplayIndex = 2
                DG_Stock.Columns("Producto").DisplayIndex = 3
                DG_Stock.Columns("Sucursal").DisplayIndex = 4
                DG_Stock.Columns("Minimo").DisplayIndex = 5
                DG_Stock.Columns("Actual").DisplayIndex = 6
                DG_Stock.Columns("Optimo").DisplayIndex = 7
                DG_Stock.Columns("VentaMensual").DisplayIndex = 8
                DG_Stock.Columns("Modificar").DisplayIndex = 9
                DG_Stock.Columns("Eliminar").DisplayIndex = 10
                DG_Stock.Refresh()
                lbl_Msg.Visible = False
            Else
                lbl_Msg.Visible = True
                DG_Stock.ColumnHeadersVisible = False
            End If

            'Cambio el cursor a NORMAL.
            Me.Cursor = Cursors.Arrow

        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha encontrado un error al restablecer el listado de stock. Por favor, contactese con el administrador.", "Administración de Stock", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'Realizo la busqueda - ENTER.
    Private Sub txt_buscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_buscar.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True

            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            'Seteo las variables.
            Dim descrip As String
            descrip = Trim(txt_buscar.Text.ToLower)

            If Cb_Sucursal.SelectedValue = 0 Then
                ErrorStock.SetError(Cb_Sucursal, "Debe seleccionar una sucursal.")
            Else
                Dim dv As DataView = NegStock.ListadoStockSucursal(Cb_Sucursal.SelectedValue).Tables(0).DefaultView
                ErrorStock.SetError(txt_buscar, Nothing)

                If descrip <> "" Then
                    If rb_Opcion.Checked = True Then 'Si selecciono nombre.
                        dv.RowFilter = "Nombre LIKE '%" + descrip + "%'"
                    ElseIf rb_Opcion2.Checked = True Then 'si selecciono codigo.
                        dv.RowFilter = "Codigo LIKE '%" + descrip + "%'"
                    End If
                End If

                'actualizo el datagrid
                If dv.Count > 0 Then
                    DG_Stock.ColumnHeadersVisible = True
                    DG_Stock.DataSource = dv
                    DG_Stock.Refresh()
                    lbl_Msg.Visible = False
                Else
                    lbl_Msg.Visible = True
                    DG_Stock.ColumnHeadersVisible = False
                    DG_Stock.DataSource = Nothing
                    DG_Stock.Refresh()
                End If

            End If

            'Cambio el cursor a "NORMAL"
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    'Realizo la busqueda - CLICK.
    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        'Cambio el cursor a "WAIT"
        Me.Cursor = Cursors.WaitCursor

        'Seteo las variables.
        Dim descrip As String
        descrip = Trim(txt_buscar.Text.ToLower)

        If Cb_Sucursal.SelectedValue = 0 Then
            ErrorStock.SetError(Cb_Sucursal, "Debe seleccionar una sucursal.")
        Else
            Dim dv As DataView = NegStock.ListadoStockSucursal(Cb_Sucursal.SelectedValue).Tables(0).DefaultView
            ErrorStock.SetError(txt_buscar, Nothing)

            If descrip <> "" Then
                If rb_Opcion.Checked = True Then 'Si selecciono nombre.
                    dv.RowFilter = "Nombre LIKE '%" + descrip + "%'"
                ElseIf rb_Opcion2.Checked = True Then 'si selecciono codigo.
                    dv.RowFilter = "Codigo LIKE '%" + descrip + "%'"
                End If
            End If

            'actualizo el datagrid
            If dv.Count > 0 Then
                DG_Stock.ColumnHeadersVisible = True
                DG_Stock.DataSource = dv
                DG_Stock.Refresh()
                lbl_Msg.Visible = False
            Else
                lbl_Msg.Visible = True
                DG_Stock.ColumnHeadersVisible = False
                DG_Stock.DataSource = Nothing
                DG_Stock.Refresh()
            End If

        End If

        'Cambio el cursor a "NORMAL"
        Me.Cursor = Cursors.Arrow
    End Sub

    'Tabs de los forms.
    Private Sub TabStock_Selected(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabStock.Selected
        'Cambio el cursor a "WAIT"
        TabStock.Cursor = Cursors.WaitCursor

        If TabStock.SelectedTab.Name = "TabListado" Then 'TAB LISTADO DE STOCK

            Dim dsStock As New DataSet
            dsStock = NegStock.ListadoStockSucursal(Cb_Sucursal.SelectedValue)
            If dsStock.Tables(0).Rows.Count > 0 Then
                DG_Stock.DataSource = dsStock.Tables(0)
                DG_Stock.AutoGenerateColumns = False
                DG_Stock.ColumnHeadersVisible = True
                DG_Stock.Columns("id_Stock").Visible = False
                DG_Stock.Columns("Codigo").DisplayIndex = 1
                DG_Stock.Columns("Categoria").DisplayIndex = 2
                DG_Stock.Columns("Producto").DisplayIndex = 3
                DG_Stock.Columns("Sucursal").DisplayIndex = 4
                DG_Stock.Columns("Minimo").DisplayIndex = 5
                DG_Stock.Columns("Actual").DisplayIndex = 6
                DG_Stock.Columns("Optimo").DisplayIndex = 7
                DG_Stock.Columns("VentaMensual").DisplayIndex = 8
                DG_Stock.Columns("Modificar").DisplayIndex = 9
                DG_Stock.Columns("Eliminar").DisplayIndex = 10
                DG_Stock.Refresh()
                lbl_Msg.Visible = False
            Else
                lbl_Msg.Visible = True
                DG_Stock.ColumnHeadersVisible = False
            End If

            'Limpio los formularios
            LimpiarFormAltaStock()
            LimpiarFormModificacionStock()

            'Seteo el id_CLiente en cero
            EStock.id_Stock = 0

        ElseIf TabStock.SelectedTab.Name = "TabAlta" Then 'TAB ALTA DE STOCK
            'Limpio el formulario de alta.
            LimpiarFormAltaStock()

            'Cargo el combo con las sucursales.
            Dim DsSucursales As New DataSet
            DsSucursales = NegSucursal.ListadoSucursales()
            If DsSucursales.Tables(0).Rows.Count > 1 Then
                Cb_Sucursales.DataSource = DsSucursales.Tables(0)
                Cb_Sucursales.DisplayMember = "Nombre"
                Cb_Sucursales.ValueMember = "id_Sucursal"
                Cb_Sucursales.SelectedValue = id_Sucursal
                Cb_Sucursales.Refresh()
            End If

            'Seteo el id_CLiente en cero
            EStock.id_Stock = 0

        ElseIf TabStock.SelectedTab.Name = "TabModificacion" Then 'TAB MODIFICACION DE STOCK
            If EStock.id_Stock > 0 Or EStock.id_Stock <> Nothing Then
            Else
                MessageBox.Show("Debe seleccionar previamente un stock.", "Administración de Stock", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                TabStock.SelectedTab = TabStock.TabPages("TabListado")
            End If
        End If

        'Cambio el cursor a NORMAL.
        TabStock.Cursor = Cursors.Arrow
    End Sub

    'Al agregar el stock.
    Private Sub Btn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Agregar.Click
        If txt_Optimo.Text = "" Or txt_Actual.Text = "" Or txt_Minimo.Text = "" Or txt_Codigo.Text = "" Then
            MessageBox.Show("Debe completar los campos requeridos.", "Administración de Stock", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            'Cambio el cursor a "WAIT"
            TabStock.Cursor = Cursors.WaitCursor
            Try

                'Lleno la entidad productos
                EStock.id_Producto = Trim(NegProductos.TraerID(Trim(txt_Codigo.Text)))
                EStock.id_Sucursal = Cb_Sucursales.SelectedValue
                EStock.Stock_Actual = Trim(txt_Actual.Text)
                EStock.Stock_Minimo = Trim(txt_Minimo.Text)
                EStock.Stock_Optimo = Trim(txt_Optimo.Text)
                EStock.VentaMensual = If(String.IsNullOrEmpty(Trim(txt_ventaMensual.Text)), 0, Trim(txt_ventaMensual.Text))
                If chk_Habilitado.Checked = True Then
                    EStock.Habilitado = 1
                Else
                    EStock.Habilitado = 0
                End If
                EStock.id_Usuario = 0
                EStock.Modificado = 0
                EStock.Motivo = ""
                EStock.Fecha_Mod = Now


                'Ejecuto el sp_Stock_Alta
                MessageBox.Show(NegStock.AltaStock(EStock), "Administración de Stock", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("Se ha producido un error al registrar el Stock. Por favor, intente más tarde.", "Administración de Stock", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            'Cambio el cursor a "NORMAL"
            TabStock.Cursor = Cursors.Arrow

            'Limpio el formulario
            LimpiarFormAltaStock()

        End If
    End Sub

    'click en modificar o eliminar dentro del datagrid.
    Private Sub DG_Stock_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Stock.CellContentClick
        If DG_Stock.Columns(e.ColumnIndex).Name = "Eliminar" Then 'Si se hace click en el boton "eliminar" de la fila.

            Dim Result As DialogResult
            Result = MessageBox.Show("¿Está seguro que desea eliminar el Stock?", "Administración de Stock", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Result = System.Windows.Forms.DialogResult.Yes Then 'Si acepta eliminar el item
                'Cambio el cursor a "WAIT"
                TabStock.Cursor = Cursors.WaitCursor

                Dim id_Stock As Int64 = DG_Stock.Rows(e.RowIndex).Cells("id_Stock").Value
                If id_Stock = 0 Then
                    'si no completo la descripcion, muestro un msg de error.
                    MessageBox.Show("No se puede eliminar el stock.", "Administración de Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    Me.Cursor = Cursors.WaitCursor
                    Funciones.ControlInstancia(frmStockMotivo).MdiParent = MDIContenedor
                    Funciones.ControlInstancia(frmStockMotivo).Show()
                    frmStockMotivo.id_Stock = id_Stock
                    Me.Cursor = Cursors.Arrow
                End If

                'Cambio el cursor a "NORMAL"
                TabStock.Cursor = Cursors.Arrow

            End If
        ElseIf DG_Stock.Columns(e.ColumnIndex).Name = "Modificar" Then 'Si se hace click en el boton "modificar" de la fila.
            Dim id_Stock As Int64 = DG_Stock.Rows(e.RowIndex).Cells("id_Stock").Value()

            'Cambio el cursor a "WAIT"
            TabStock.Cursor = Cursors.WaitCursor

            'lleno la entidad productos
            EStock = NegStock.TraerStock(id_Stock)

            'asigno la clase a los controles del tab_Modificacion
            txt_Codigo_mod.Text = NegProductos.TraerCODIGO(EStock.id_Producto)

            'Cargo el combo con las sucursales.
            Dim DsSucursales As New DataSet
            DsSucursales = NegSucursal.ListadoSucursales()
            If DsSucursales.Tables(0).Rows.Count > 1 Then
                Cb_Sucursales_mod.DataSource = DsSucursales.Tables(0)
                Cb_Sucursales_mod.DisplayMember = "Nombre"
                Cb_Sucursales_mod.ValueMember = "id_Sucursal"
                Cb_Sucursales_mod.SelectedValue = EStock.id_Sucursal
                Cb_Sucursales_mod.Refresh()
            End If

            txt_Actual_mod.Text = EStock.Stock_Actual
            txt_Minimo_mod.Text = EStock.Stock_Minimo
            txt_Optimo_mod.Text = EStock.Stock_Optimo
            txt_ventaMensual_mod.Text = EStock.VentaMensual

            If EStock.Habilitado = 1 Then
                chk_Habilitado_mod.Checked = True
            Else
                chk_Habilitado_mod.Checked = False
            End If

            'Datos de la modificacion.
            If EStock.id_Usuario > 0 Then
                lbl_Motivo.Text = Replace(Trim(EStock.Motivo), "<br />", vbCrLf)
                lbl_Usuario.Text = EStock.Usuario
                lbl_Fecha.Text = EStock.Fecha_Mod
                Gb_Mod.Visible = True
            Else
                Gb_Mod.Visible = False
            End If

            'Cambio el cursor a "NORMAL"
            TabStock.Cursor = Cursors.Arrow

            'hago foco en el tab_modificacion 
            TabStock.SelectedTab = TabStock.TabPages("TabModificacion")
        End If
    End Sub

    'Al modificar el stock.
    Private Sub Btn_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Modificar.Click
        If txt_Optimo_mod.Text = "" Or txt_Actual_mod.Text = "" Or txt_Minimo_mod.Text = "" Or txt_Codigo_mod.Text = "" Or txt_Motivo.Text = "" Then
            MessageBox.Show("Debe completar los campos requeridos.", "Administración de Stock", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            'Cambio el cursor a "WAIT"
            TabStock.Cursor = Cursors.WaitCursor

            Try
                Dim id_Producto As Integer = 0
                Dim EStockNuevo As New Entidades.Stock

                id_Producto = Trim(NegProductos.TraerID(Trim(txt_Codigo_mod.Text)))
                'Lleno la entidad Stock.
                EStockNuevo.id_Stock = EStock.id_Stock
                EStockNuevo.id_Producto = id_Producto
                EStockNuevo.id_Sucursal = Cb_Sucursales_mod.SelectedValue
                EStockNuevo.Stock_Actual = Trim(txt_Actual_mod.Text)
                EStockNuevo.Stock_Minimo = Trim(txt_Minimo_mod.Text)
                EStockNuevo.Stock_Optimo = Trim(txt_Optimo_mod.Text)
                EStockNuevo.VentaMensual = If(String.IsNullOrWhiteSpace(Trim(txt_ventaMensual_mod.Text)), 0, Trim(txt_ventaMensual_mod.Text))
                If chk_Habilitado_mod.Checked = True Then
                    EStockNuevo.Habilitado = 1
                Else
                    EStockNuevo.Habilitado = 0
                End If
                EStockNuevo.id_Usuario = VariablesGlobales.objUsuario.id_Usuario
                EStockNuevo.Modificado = 1
                EStockNuevo.Motivo = Replace(Trim(txt_Motivo.Text), vbCrLf, "<br />")
                EStockNuevo.Fecha_Mod = Now

                'Lleno la entidad Stock_Bitacora.
                EStockBitacora.id_Stock = EStock.id_Stock
                EStockBitacora.Accion = "Modificación"
                EStockBitacora.id_Producto = id_Producto
                EStockBitacora.id_Sucursal = id_Sucursal
                EStockBitacora.Motivo = Replace(Trim(txt_Motivo.Text), vbCrLf, "<br />")
                EStockBitacora.Stock_Actual_Ant = EStock.Stock_Actual
                EStockBitacora.Stock_Minimo_Ant = EStock.Stock_Minimo
                EStockBitacora.Stock_Optimo_Ant = EStock.Stock_Optimo
                EStockBitacora.VentaMensual_Ant = EStock.VentaMensual
                EStockBitacora.Stock_Actual = Trim(txt_Actual_mod.Text)
                EStockBitacora.Stock_Minimo = Trim(txt_Minimo_mod.Text)
                EStockBitacora.Stock_Optimo = Trim(txt_Optimo_mod.Text)
                EStockBitacora.VentaMensual = Trim(txt_ventaMensual_mod.Text)
                EStockBitacora.Fecha = Now
                EStockBitacora.Habilitado = 1
                EStockBitacora.id_Usuario = VariablesGlobales.objUsuario.id_Usuario
                EStockBitacora.Usuario = VariablesGlobales.objUsuario.Usuario
                NegStockBitacora.AltaStockBitacora(EStockBitacora)

                'Ejecuto el sp_Productos_Alta
                MessageBox.Show(NegStock.ModificacionStock(EStockNuevo), "Administración de Stock", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("Se ha producido un error al modificar el stock. Por favor, intente más tarde.", "Administración de Stock", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            'Cambio el cursor a "NORMAL"
            TabStock.Cursor = Cursors.Arrow

            'Limpio el formulario
            LimpiarFormModificacionStock()

            'Redirecciono al listado
            TabStock.SelectedTab = TabStock.TabPages("TabListado")
        End If
    End Sub

    'doble click en el datagrid.
    Private Sub DG_Stock_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Stock.CellDoubleClick
        If DG_Stock.SelectedRows.Count > 0 Then
            If e.RowIndex >= 0 Then
                Dim id_Stock As Int64 = DG_Stock.Rows(e.RowIndex).Cells("id_Stock").Value()

                'Cambio el cursor a "WAIT"
                TabStock.Cursor = Cursors.WaitCursor

                'lleno la entidad productos
                EStock = NegStock.TraerStock(id_Stock)

                'asigno la clase a los controles del tab_Modificacion
                txt_Codigo_mod.Text = NegProductos.TraerCODIGO(EStock.id_Producto)

                'Cargo el combo con las sucursales.
                Dim DsSucursales As New DataSet
                DsSucursales = NegSucursal.ListadoSucursales()
                If DsSucursales.Tables(0).Rows.Count > 1 Then
                    Cb_Sucursales_mod.DataSource = DsSucursales.Tables(0)
                    Cb_Sucursales_mod.DisplayMember = "Nombre"
                    Cb_Sucursales_mod.ValueMember = "id_Sucursal"
                    Cb_Sucursales_mod.SelectedValue = EStock.id_Sucursal
                    Cb_Sucursales_mod.Refresh()
                End If

                txt_Actual_mod.Text = EStock.Stock_Actual
                txt_Minimo_mod.Text = EStock.Stock_Minimo
                txt_Optimo_mod.Text = EStock.Stock_Optimo
                txt_ventaMensual_mod.Text = EStock.VentaMensual

                If EStock.Habilitado = 1 Then
                    chk_Habilitado_mod.Checked = True
                Else
                    chk_Habilitado_mod.Checked = False
                End If

                'Datos de la modificacion.
                If EStock.id_Usuario > 0 Then
                    lbl_Motivo.Text = Replace(Trim(EStock.Motivo), "<br />", vbCrLf)
                    lbl_Usuario.Text = EStock.Usuario
                    lbl_Fecha.Text = EStock.Fecha_Mod
                    Gb_Mod.Visible = True
                Else
                    Gb_Mod.Visible = False
                End If

                'Cambio el cursor a "NORMAL"
                TabStock.Cursor = Cursors.Arrow

                'hago foco en el tab_modificacion 
                TabStock.SelectedTab = TabStock.TabPages("TabModificacion")
            End If
        End If
    End Sub

    Private Sub Btn_BuscarCodigo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_BuscarCodigo.Click
        Funciones.ControlInstancia(frmBuscarCodigoProducto).MdiParent = MDIContenedor
        Funciones.ControlInstancia(frmBuscarCodigoProducto).Show()
        frmBuscarCodigoProducto.TipoForm = 1
    End Sub

    Private Sub Btn_BuscarCodigo_mod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_BuscarCodigo_mod.Click
        Funciones.ControlInstancia(frmBuscarCodigoProducto).MdiParent = MDIContenedor
        Funciones.ControlInstancia(frmBuscarCodigoProducto).Show()
        frmBuscarCodigoProducto.TipoForm = 2
    End Sub

    Private Sub Btn_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Eliminar.Click
        Dim Result As DialogResult
        Result = MessageBox.Show("¿Está seguro que desea eliminar el Stock?", "Administración de Stock", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If Result = System.Windows.Forms.DialogResult.Yes Then 'Si acepta eliminar el item
            'Cambio el cursor a "WAIT"
            TabStock.Cursor = Cursors.WaitCursor

            Dim id_Stock As Int64 = EStock.id_Stock
            If id_Stock = 0 Then
                'si no completo la descripcion, muestro un msg de error.
                MessageBox.Show("No se puede eliminar el stock.", "Administración de Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else

                Me.Cursor = Cursors.WaitCursor
                Funciones.ControlInstancia(frmStockMotivo).MdiParent = MDIContenedor
                Funciones.ControlInstancia(frmStockMotivo).Show()
                frmStockMotivo.id_Stock = id_Stock
                Me.Cursor = Cursors.Arrow
            End If

            'Cambio el cursor a "NORMAL"
            TabStock.Cursor = Cursors.Arrow
        End If
    End Sub

    'Hago foco en la caja de busqueda.
    Private Sub rb_Opcion2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_Opcion2.CheckedChanged
        txt_buscar.Focus()
    End Sub

    'Hago foco en la caja de busqueda.
    Private Sub rb_Opcion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_Opcion.CheckedChanged
        txt_buscar.Focus()
    End Sub

    Sub EvaluarPermisos()
        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Stock_Administración_Crear)) Then

        Else
            TabStock.TabPages.Remove(TabStock.TabPages("TabAlta"))
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Stock_Administración_Eliminar)) Then
            DG_Stock.Columns("Eliminar").Visible = True
            Btn_Eliminar.Enabled = True
        Else
            DG_Stock.Columns("Eliminar").Visible = False
            Btn_Eliminar.Enabled = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Stock_Administración_Modificar)) Then
            DG_Stock.Columns("Modificar").Visible = True
        Else
            TabStock.TabPages.Remove(TabStock.TabPages("TabModificacion"))
            DG_Stock.Columns("Modificar").Visible = False
            RemoveHandler DG_Stock.CellDoubleClick, AddressOf DG_Stock_CellDoubleClick
        End If
    End Sub

    Private Sub btn_Exportar_Click(sender As Object, e As EventArgs) Handles btn_Exportar.Click
        Try
            'Configuro la pantalla de guardado de archivos
            SaveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            SaveFileDialog.FileName = String.Format("Stock_{0}", My.Settings.NombreSucursal)
            SaveFileDialog.Filter = "Excel Files|*.xlsx;"

            If SaveFileDialog.ShowDialog() = DialogResult.OK Then
                'Cambio el cursor a "WAIT"
                Me.Cursor = Cursors.WaitCursor

                frmCargadorDeEspera.Show()
                frmCargadorDeEspera.Text = "Generando Exportación a Excel "
                frmCargadorDeEspera.lbl_Descripcion.Text = "iniciando..."
                frmCargadorDeEspera.BarraProgreso.Minimum = 0
                frmCargadorDeEspera.BarraProgreso.Maximum = 5
                frmCargadorDeEspera.BarraProgreso.Value = 1
                frmCargadorDeEspera.Refresh()

                AddHandler NegProductos.UpdateProgress, AddressOf UpdateProgress

                'Exporto el listado de productos a Excel
                NegStock.ExportarExcelStock(My.Settings.Sucursal, SaveFileDialog.FileName, ConfigurationManager.AppSettings("ExportarExcelPlantillaProductoSucursal"))

                'Voy seteando la barra de progreso
                frmCargadorDeEspera.Close()
                frmCargadorDeEspera.Dispose()

                'Cambio el cursor a "NORMAL"
                Me.Cursor = Cursors.Arrow

                'si no completo la descripcion, muestro un msg de error.
                MessageBox.Show("Se ha exportado el listado de productos de forma exitosa", "Administración de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            'Voy seteando la barra de progreso
            frmCargadorDeEspera.Close()
            frmCargadorDeEspera.Dispose()

            'Cambio el cursor a "NORMAL"
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha producido un error en la exportación de la información. Verifique que el documento no se encuentre en uso o esté abierto. Por favor, intente más tarde.", "Administración de Stock", MessageBoxButtons.OK, MessageBoxIcon.Error)
            LogHelper.WriteLog("ERROR Metodo: ExportarExcelStock" + Environment.NewLine + ex.ToString())
        End Try
    End Sub

    Public Sub UpdateProgress(ProgressStep As Integer, ProgressText As String)
        frmCargadorDeEspera.lbl_Descripcion.Text = ProgressText
        frmCargadorDeEspera.BarraProgreso.Value = ProgressStep
        frmCargadorDeEspera.Refresh()
    End Sub

    Private Sub btn_Importar_Click(sender As Object, e As EventArgs) Handles btn_Importar.Click
        Try
            OpenFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            OpenFileDialog.Filter = "Excel Files|*.xlsx;"
            OpenFileDialog.FileName = String.Empty

            If OpenFileDialog.ShowDialog() = DialogResult.OK Then
                'Cambio el cursor a "WAIT"
                Me.Cursor = Cursors.WaitCursor

                frmCargadorDeEspera.Show()
                frmCargadorDeEspera.Text = "Generando Importación del Excel "
                frmCargadorDeEspera.lbl_Descripcion.Text = "iniciando..."
                frmCargadorDeEspera.BarraProgreso.Minimum = 0
                frmCargadorDeEspera.BarraProgreso.Maximum = 4
                frmCargadorDeEspera.BarraProgreso.Value = 1
                frmCargadorDeEspera.Refresh()

                AddHandler NegProductos.UpdateProgress, AddressOf UpdateProgress

                Dim Mensaje As String = NegStock.ImportarExcelStock(My.Settings.Sucursal, VariablesGlobales.objUsuario.id_Usuario, VariablesGlobales.objUsuario.Nombre, OpenFileDialog.FileName)

                'Voy seteando la barra de progreso
                frmCargadorDeEspera.Close()
                frmCargadorDeEspera.Dispose()

                'Cambio el cursor a "NORMAL"
                Me.Cursor = Cursors.Arrow

                MessageBox.Show(Mensaje, "Administración de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                btn_Restablecer_Click(Nothing, Nothing)
            End If

        Catch ex As Exception
            'Voy seteando la barra de progreso
            frmCargadorDeEspera.Close()
            frmCargadorDeEspera.Dispose()

            'Cambio el cursor a "NORMAL"
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha producido un error en la importación de la información. Por favor, intente más tarde.", "Administración de Productos", MessageBoxButtons.OK, MessageBoxIcon.Error)

            LogHelper.WriteLog("ERROR Metodo: ImportarExcel" + Environment.NewLine + ex.ToString())
        End Try
    End Sub
#End Region

End Class