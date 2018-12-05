Imports System.Configuration
Imports System.IO
Imports Datos

Public Class frmProductos
    Dim NegProductos As New Negocio.NegProductos
    Dim fuc As New Funciones
    Dim NegErrores As New Negocio.NegManejadorErrores
    Dim EProductos As New Entidades.Productos
    Dim NegProductosCat As New Negocio.NegProductosCategorias
    Dim NegProductosSubCat As New Negocio.NegProductosSubcategorias
    Dim NegProveedores As New Negocio.NegProveedores
    Dim NegAromas As New Negocio.NegAromas
    Dim NegMateriales As New Negocio.NegMateriales
    Dim NegColores As New Negocio.NegColores

#Region "Región de Validaciones"

    'Valido que se complete el nombre del producto. - ALTA
    Private Sub txt_Nombre_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_Nombre.Validating
        If txt_Nombre.Text = "" Then
            ErrorProductos.SetError(txt_Nombre, "Debe completar el nombre del producto.")
        Else
            ErrorProductos.SetError(txt_Nombre, Nothing)
        End If
    End Sub

    'Valido que se complete el codigo del producto. - ALTA
    Private Sub txt_Codigo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_Codigo.Validating
        If txt_Codigo.Text = "" Then
            ErrorProductos.SetError(txt_Codigo, "Debe completar el código del producto.")
        Else
            ErrorProductos.SetError(txt_Codigo, Nothing)
        End If
    End Sub

    'Valido que se complete el nombre del producto. - MODIFICACION
    Private Sub txt_Nombre_mod_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_Nombre_mod.Validating
        If txt_Nombre_mod.Text = "" Then
            ErrorProductos.SetError(txt_Nombre_mod, "Debe completar el nombre del producto.")
        Else
            ErrorProductos.SetError(txt_Nombre_mod, Nothing)
        End If
    End Sub

    'Valido que se complete el codigo del producto. - MODIFICACION
    Private Sub txt_Codigo_mod_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_Codigo_mod.Validating
        If txt_Codigo_mod.Text = "" Then
            ErrorProductos.SetError(txt_Codigo_mod, "Debe completar el código del producto.")
        Else
            ErrorProductos.SetError(txt_Codigo_mod, Nothing)
        End If
    End Sub

    'Valido que se ingrese solo currency en campo costo. - ALTA
    Private Sub txt_Costo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Costo.KeyPress
        If e.KeyChar.ToString() = "." Then
            e.KeyChar = CChar(",")
        End If
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloCurrency(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
            ErrorProductos.SetError(txt_Costo, "Debe ingresar el monto en el formato permitido. Ejemplo: 725,50")
        Else
            ErrorProductos.SetError(txt_Costo, Nothing)
        End If
    End Sub

    'Valido que se ingrese solo currency en campo Precio1. - ALTA
    Private Sub txt_Precio1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Precio1.KeyPress
        If e.KeyChar.ToString() = "." Then
            e.KeyChar = CChar(",")
        End If
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloCurrency(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
            ErrorProductos.SetError(txt_Precio1, "Debe ingresar el monto en el formato permitido. Ejemplo: 725,50")
        Else
            ErrorProductos.SetError(txt_Precio1, Nothing)
        End If
    End Sub

    'Valido que se ingrese solo currency en campo Precio2. - ALTA
    Private Sub txt_Precio2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Precio2.KeyPress
        If e.KeyChar.ToString() = "." Then
            e.KeyChar = CChar(",")
        End If
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloCurrency(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
            ErrorProductos.SetError(txt_Precio2, "Debe ingresar el monto en el formato permitido. Ejemplo: 725,50")
        Else
            ErrorProductos.SetError(txt_Precio2, Nothing)
        End If
    End Sub

    'Valido que se ingrese solo currency en campo Precio3. - ALTA
    Private Sub txt_Precio3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Precio3.KeyPress
        If e.KeyChar.ToString() = "." Then
            e.KeyChar = CChar(",")
        End If
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloCurrency(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
            ErrorProductos.SetError(txt_Precio3, "Debe ingresar el monto en el formato permitido. Ejemplo: 725,50")
        Else
            ErrorProductos.SetError(txt_Precio3, Nothing)
        End If
    End Sub

    'Valido que se ingrese solo currency en campo Precio4. - ALTA
    Private Sub txt_Precio4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Precio4.KeyPress
        If e.KeyChar.ToString() = "." Then
            e.KeyChar = CChar(",")
        End If
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloCurrency(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
            ErrorProductos.SetError(txt_Precio4, "Debe ingresar el monto en el formato permitido. Ejemplo: 725,50")
        Else
            ErrorProductos.SetError(txt_Precio4, Nothing)
        End If
    End Sub

    'Valido que se ingrese solo currency en campo Precio5. - ALTA
    Private Sub txt_Precio5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Precio5.KeyPress
        If e.KeyChar.ToString() = "." Then
            e.KeyChar = CChar(",")
        End If
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloCurrency(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
            ErrorProductos.SetError(txt_Precio5, "Debe ingresar el monto en el formato permitido. Ejemplo: 725,50")
        Else
            ErrorProductos.SetError(txt_Precio5, Nothing)
        End If
    End Sub

    'Valido que se ingrese solo currency en campo Precio6. - ALTA
    Private Sub txt_Precio6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Precio6.KeyPress
        If e.KeyChar.ToString() = "." Then
            e.KeyChar = CChar(",")
        End If
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloCurrency(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
            ErrorProductos.SetError(txt_Precio6, "Debe ingresar el monto en el formato permitido. Ejemplo: 725,50")
        Else
            ErrorProductos.SetError(txt_Precio6, Nothing)
        End If
    End Sub

    'Valido que se ingrese solo currency en campo Precio1. - MODIFICACION
    Private Sub txt_Precio1_mod_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Precio1_mod.KeyPress
        If e.KeyChar.ToString() = "." Then
            e.KeyChar = CChar(",")
        End If
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloCurrency(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
            ErrorProductos.SetError(txt_Precio1_mod, "Debe ingresar el monto en el formato permitido. Ejemplo: 725,50")
        Else
            ErrorProductos.SetError(txt_Precio1_mod, Nothing)
        End If
    End Sub

    'Valido que se ingrese solo currency en campo Precio2. - MODIFICACION
    Private Sub txt_Precio2_mod_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Precio2_mod.KeyPress
        If e.KeyChar.ToString() = "." Then
            e.KeyChar = CChar(",")
        End If
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloCurrency(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
            ErrorProductos.SetError(txt_Precio2_mod, "Debe ingresar el monto en el formato permitido. Ejemplo: 725,50")
        Else
            ErrorProductos.SetError(txt_Precio2_mod, Nothing)
        End If
    End Sub

    'Valido que se ingrese solo currency en campo Precio3. - MODIFICACION
    Private Sub txt_Precio3_mod_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Precio3_mod.KeyPress
        If e.KeyChar.ToString() = "." Then
            e.KeyChar = CChar(",")
        End If
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloCurrency(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
            ErrorProductos.SetError(txt_Precio3_mod, "Debe ingresar el monto en el formato permitido. Ejemplo: 725,50")
        Else
            ErrorProductos.SetError(txt_Precio3_mod, Nothing)
        End If
    End Sub

    'Valido que se ingrese solo currency en campo Precio4. - MODIFICACION
    Private Sub txt_Precio4_mod_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Precio4_mod.KeyPress
        If e.KeyChar.ToString() = "." Then
            e.KeyChar = CChar(",")
        End If
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloCurrency(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
            ErrorProductos.SetError(txt_Precio4_mod, "Debe ingresar el monto en el formato permitido. Ejemplo: 725,50")
        Else
            ErrorProductos.SetError(txt_Precio4_mod, Nothing)
        End If
    End Sub

    'Valido que se ingrese solo currency en campo Precio5. - MODIFICACION
    Private Sub txt_Precio5_mod_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Precio5_mod.KeyPress
        If e.KeyChar.ToString() = "." Then
            e.KeyChar = CChar(",")
        End If
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloCurrency(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
            ErrorProductos.SetError(txt_Precio5_mod, "Debe ingresar el monto en el formato permitido. Ejemplo: 725,50")
        Else
            ErrorProductos.SetError(txt_Precio5_mod, Nothing)
        End If
    End Sub

    'Valido que se ingrese solo currency en campo Precio6. - MODIFICACION
    Private Sub txt_Precio6_mod_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Precio6_mod.KeyPress
        If e.KeyChar.ToString() = "." Then
            e.KeyChar = CChar(",")
        End If
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloCurrency(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
            ErrorProductos.SetError(txt_Precio6_mod, "Debe ingresar el monto en el formato permitido. Ejemplo: 725,50")
        Else
            ErrorProductos.SetError(txt_Precio6_mod, Nothing)
        End If
    End Sub

    'Valido que se ingrese solo currency en campo costo. - MODIFICACION
    Private Sub txt_Costo_mod_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Costo_mod.KeyPress
        If e.KeyChar.ToString() = "." Then
            e.KeyChar = CChar(",")
        End If
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloCurrency(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
            ErrorProductos.SetError(txt_Costo_mod, "Debe ingresar el monto en el formato permitido. Ejemplo: 725,50")
        Else
            ErrorProductos.SetError(txt_Costo_mod, Nothing)
        End If
    End Sub

#End Region

#Region "Región de Funciones"
    'Limpia el formulario completamente. - ALTA
    Sub LimpiarFormAltaProductos()
        txt_Codigo.Clear()
        txt_Nombre.Clear()
        txt_Origen.Clear()
        txt_Tamano.Clear()
        txt_Costo.Clear()
        txt_Foto.Clear()
        txt_Precio1.Clear()
        txt_Precio2.Clear()
        txt_Precio3.Clear()
        txt_Precio4.Clear()
        txt_Precio5.Clear()
        txt_Precio6.Clear()
        txt_Descripcion.Clear()
        pb_foto.Image = My.Resources.Recursos.Sinfoto
        cb_Categoria.SelectedItem = Nothing
        cb_Subcategoria.SelectedItem = Nothing
        cb_Proveedores.SelectedItem = Nothing
        chk_Habilitado.Checked = True
        chk_SubirWeb.Checked = True
        chk_Novedad.Checked = True
        fuc.SetearCheckboxlist(chk_Aromas, False)
        fuc.SetearCheckboxlist(chk_Materiales, False)
        fuc.SetearCheckboxlist(chk_Colores, False)
    End Sub

    'Limpia el formulario completamente. - MODIFICACION
    Sub LimpiarFormModificacionProductos()
        txt_Codigo_mod.Clear()
        txt_Nombre_mod.Clear()
        txt_Origen_mod.Clear()
        txt_Tamano_mod.Clear()
        txt_Costo_mod.Clear()
        txt_Foto_mod.Clear()
        txt_Precio1_mod.Clear()
        txt_Precio2_mod.Clear()
        txt_Precio3_mod.Clear()
        txt_Precio4_mod.Clear()
        txt_Precio5_mod.Clear()
        txt_Precio6_mod.Clear()
        pb_foto_mod.Image = My.Resources.Recursos.Sinfoto
        txt_Descripcion_mod.Clear()
        cb_Categoria_mod.SelectedItem = Nothing
        cb_Subcategoria_mod.SelectedItem = Nothing
        cb_Proveedor_mod.SelectedItem = Nothing
        chk_Habilitado_mod.Checked = True
        chk_SubirWeb_mod.Checked = True
        Ck_EliminarFoto.Checked = False
        chk_Novedad_mod.Checked = True
        fuc.SetearCheckboxlist(chk_Aromas_mod, False)
        fuc.SetearCheckboxlist(chk_Materiales_mod, False)
        fuc.SetearCheckboxlist(chk_Colores_mod, False)
    End Sub
#End Region

#Region "Región de Eventos"

    'Load del formulario de productos.
    Private Sub frmProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Cambio el cursor a "WAIT"
        TabProductos.Cursor = Cursors.WaitCursor

        'seteo el font a 8px
        DG_Productos.AlternatingRowsDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DG_Productos.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DG_Productos.RowHeadersDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DG_Productos.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        'seteo las imagenes
        Dim ListaImagenes = New ImageList
        ListaImagenes.ImageSize = New Size(32, 32)
        ListaImagenes.TransparentColor = Color.Blue
        ListaImagenes.ColorDepth = ColorDepth.Depth32Bit

        ListaImagenes.Images.Add(My.Resources.Recursos.Productos)
        ListaImagenes.Images.Add(My.Resources.Recursos.IconoADD)
        ListaImagenes.Images.Add(My.Resources.Recursos.Lapiz)

        TabProductos.ImageList = ListaImagenes

        'icono de productos
        TbListado.ImageIndex = 0
        'icono de alta
        TbAlta.ImageIndex = 1
        'icono de edicion
        TbMod.ImageIndex = 2

        CargarProductos()

        EvaluarPermisos()

        If (System.IO.File.Exists(AppDomain.CurrentDomain.BaseDirectory + "\ProductosBKP.xml")) Then
            Me.ToolProd.SetToolTip(Me.btn_Restore, String.Format("Haz click aquí para restaurar la informacion del los productos con la ultima copia de seguridad con fecha {0}", System.IO.File.GetCreationTime(AppDomain.CurrentDomain.BaseDirectory + "\ProductosBKP.xml").ToString("dd/MM/yyyy hh:mm:ss")))
        Else
            btn_Restore.Enabled = False
        End If

        'Cambio el cursor a NORMAL.
        TabProductos.Cursor = Cursors.Arrow
    End Sub

    Private Sub CargarProductos()
        'Cargo el datagrid de productos.
        Dim dsProductos As DataSet = NegProductos.ListadoProductos(False)
        If (dsProductos.Tables(0).Rows.Count > 0) Then
            DG_Productos.DataSource = dsProductos.Tables(0)
            DG_Productos.AutoGenerateColumns = False
            DG_Productos.ColumnHeadersVisible = True
            DG_Productos.Columns("id_Producto").Visible = False
            DG_Productos.Columns("CodigoBarra").Visible = False
            DG_Productos.Columns("Nombre").DisplayIndex = 1
            DG_Productos.Columns("Codigo").DisplayIndex = 2
            DG_Productos.Columns("Categoria").DisplayIndex = 3
            DG_Productos.Columns("Subcategoria").DisplayIndex = 4
            DG_Productos.Columns("Proveedor").DisplayIndex = 5
            DG_Productos.Columns("precio1").DisplayIndex = 6
            DG_Productos.Columns("precio2").DisplayIndex = 7
            DG_Productos.Columns("precio3").DisplayIndex = 8
            DG_Productos.Columns("precio4").DisplayIndex = 9
            DG_Productos.Columns("precio5").DisplayIndex = 10
            DG_Productos.Columns("precio6").DisplayIndex = 11
            DG_Productos.Columns("Modificar").DisplayIndex = 12
            DG_Productos.Columns("Eliminar").DisplayIndex = 13
            DG_Productos.Refresh()
            lbl_Msg.Visible = False
        Else
            DG_Productos.DataSource = Nothing
            DG_Productos.ColumnHeadersVisible = False
            DG_Productos.Refresh()
            lbl_Msg.Visible = True
        End If
    End Sub

    Private Sub Btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cancelar.Click
        TabProductos.SelectedTab = TabProductos.TabPages("TbListado")
    End Sub

    'Cargo el cambo con las categorias.
    Private Sub cb_Categoria_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_Categoria.GotFocus
        Dim dsCategorias As New DataSet
        dsCategorias = NegProductosCat.ListadoCategorias()
        If dsCategorias.Tables(0).Rows.Count > 0 Then
            cb_Categoria.DataSource = Nothing
            cb_Categoria.DataSource = dsCategorias.Tables(0)
            cb_Categoria.DisplayMember = "Descripcion"
            cb_Categoria.ValueMember = "id_Categoria"
            cb_Categoria.Refresh()
            cb_Subcategoria.DataSource = Nothing
            cb_Subcategoria.Refresh()
        End If
    End Sub

    'Cargo el combo con las subcategorias. - ALTA
    Private Sub cb_Categoria_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_Categoria.SelectionChangeCommitted
        If cb_Categoria.SelectedValue <> 0 Then
            Dim dsSubcategorias As New DataSet
            dsSubcategorias = NegProductosSubCat.ListadoSubcategorias(cb_Categoria.SelectedValue)
            If dsSubcategorias.Tables(0).Rows.Count > 0 Then
                cb_Subcategoria.DataSource = Nothing
                cb_Subcategoria.DataSource = dsSubcategorias.Tables(0)
                cb_Subcategoria.DisplayMember = "Descripcion"
                cb_Subcategoria.ValueMember = "id_Subcategoria"
                cb_Subcategoria.Refresh()
            End If
        End If
    End Sub

    'Cargo el combo con las subcategorias. -MODIFICACION
    Private Sub cb_Categoria_mod_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_Categoria_mod.SelectionChangeCommitted
        If cb_Categoria_mod.SelectedValue <> 0 Then
            Dim dsSubcategorias As New DataSet
            dsSubcategorias = NegProductosSubCat.ListadoSubcategorias(cb_Categoria_mod.SelectedValue)
            If dsSubcategorias.Tables(0).Rows.Count > 0 Then
                cb_Subcategoria_mod.DataSource = Nothing
                cb_Subcategoria_mod.DataSource = dsSubcategorias.Tables(0)
                cb_Subcategoria_mod.DisplayMember = "Descripcion"
                cb_Subcategoria_mod.ValueMember = "id_Subcategoria"
                cb_Subcategoria_mod.Refresh()
            End If
        End If
    End Sub

    'Cargo el combo con los proveedores.
    Private Sub cb_Proveedores_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_Proveedores.GotFocus
        Dim dsProveedores As New DataSet
        dsProveedores = NegProveedores.ListadoProveedores()
        If dsProveedores.Tables(0).Rows.Count > 0 Then
            cb_Proveedores.DataSource = Nothing
            cb_Proveedores.DataSource = dsProveedores.Tables(0)
            cb_Proveedores.DisplayMember = "RazonSocial"
            cb_Proveedores.ValueMember = "id_Proveedor"
            cb_Proveedores.Refresh()
        End If
    End Sub

    'abro el open dialog para que seleccione una foto.
    Private Sub btn_Open_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Open.Click
        Cargar.Title = "Seleccione una Fotografía" 'Título de la ventana que se abrirá para seleccionar el archivo.
        Cargar.Filter = "Jpg|*.jpg|Png|*.png|Gif|*.gif|Todos los archivos|*.*" 'Tipo de extensiones soportadas, fijaros como en la primera parte se pone el nombre, el que se quiera, después ponemos una barra vertical a modo de separación y ponemos *."extensión", el asterisco significa que nos permitirá cualquier nombre de archivo, la extensión hay que ponerla IGUAL que las que queramos abrir, lo de todos los archivos es opcional..
        Cargar.FilterIndex = 0 'Elegimos que se quede por defecto la primera extensión a la vista.
        Cargar.InitialDirectory = "C:\Documents and Settings\" & My.User.Name & "\Escritorio" 'Con esto haremos que el directorio inicial sea nuestro escritorio, podemos modificarlo a nuestro antojo si quisieramos abrirlo en mis documentos o en algún otro lugar lo ponemos y ya está.
        Cargar.RestoreDirectory = True 'De esta forma, mientras no cerremos la aplicación se "guardará" el último directorio seleccionado para no tener que elegirlo cada vez.
        Cargar.FileName = "" 'Con esto hacemos que al abrir la ventana no haya un nombre escrito.
        If Cargar.ShowDialog() = Windows.Forms.DialogResult.OK Then 'Si pulsamos aceptar en la ventanita.
            'guardo la ruta de la imagen en el txt
            txt_Foto.Text = Cargar.FileName

            'Cargo la imagen en el picturebox.
            Dim fs As System.IO.FileStream
            fs = New System.IO.FileStream(Cargar.FileName, IO.FileMode.Open, IO.FileAccess.Read)
            pb_foto.Image = System.Drawing.Image.FromStream(fs)
            fs.Close()
        End If
    End Sub

    'Boton de alta de producto
    Private Sub Btn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Agregar.Click
        If txt_Nombre.Text = "" Or txt_Codigo.Text = "" Or cb_Categoria.SelectedItem Is Nothing Or cb_Subcategoria.SelectedItem Is Nothing Or cb_Proveedores.SelectedItem Is Nothing Then
            MessageBox.Show("Debe completar los campos requeridos.", "Administración de Productos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                'Cambio el cursor a "WAIT"
                Me.Cursor = Cursors.WaitCursor

                'Lleno la entidad productos
                EProductos.Nombre = Trim(txt_Nombre.Text)
                EProductos.Origen = Trim(txt_Origen.Text)
                EProductos.Tamano = Trim(txt_Tamano.Text)
                EProductos.Costo = Trim(txt_Costo.Text)
                EProductos.Codigo = Trim(txt_Codigo.Text)
                EProductos.Precio1 = Trim(txt_Precio1.Text)
                EProductos.Precio2 = Trim(txt_Precio2.Text)
                EProductos.Precio3 = Trim(txt_Precio3.Text)
                EProductos.Precio4 = Trim(txt_Precio4.Text)
                EProductos.Precio5 = Trim(txt_Precio5.Text)
                EProductos.Precio6 = Trim(txt_Precio6.Text)
                EProductos.Foto = Trim(txt_Foto.Text)
                If txt_Descripcion.Text <> "" Then
                    EProductos.Descripcion = Replace(Trim(txt_Descripcion.Text), vbCrLf, "<br />")
                Else
                    EProductos.Descripcion = ""
                End If
                EProductos.id_Categoria = Trim(cb_Categoria.SelectedValue)
                EProductos.id_Subcategoria = Trim(cb_Subcategoria.SelectedValue)
                EProductos.id_Proveedor = Trim(cb_Proveedores.SelectedValue)
                If chk_Habilitado.Checked = True Then
                    EProductos.Habilitado = 1
                Else
                    EProductos.Habilitado = 0
                End If

                If chk_Novedad.Checked = True Then
                    EProductos.Novedad = 1
                Else
                    EProductos.Novedad = 0
                End If

                If chk_SubirWeb.Checked = True Then
                    EProductos.SubirWeb = 1
                Else
                    EProductos.SubirWeb = 0
                End If
                EProductos.Materiales = chk_Materiales
                EProductos.Aromas = chk_Aromas
                EProductos.Colores = chk_Colores

                'Ejecuto el sp_Productos_Alta
                MessageBox.Show(NegProductos.AltaProducto(EProductos), "Administración de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)

                'Limpio el formulario
                LimpiarFormAltaProductos()

                'Cambio el cursor a "NORMAL"
                Me.Cursor = Cursors.Arrow
            Catch ex As Exception
                Me.Cursor = Cursors.Arrow
                MessageBox.Show("Se ha producido un error al registrar el producto. Por favor, intente más tarde.", "Administración de Productos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub txt_buscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_buscar.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True

            'Seteo las variables.
            Dim descrip As String
            descrip = Trim(txt_buscar.Text.ToLower)

            If descrip = "" Then
                ErrorProductos.SetError(txt_buscar, "Debe completar el campo de busqueda.")
            Else
                Me.Cursor = Cursors.WaitCursor
                ErrorProductos.SetError(txt_buscar, Nothing)
                Dim dv As DataView = NegProductos.ListadoProductos(False).Tables(0).DefaultView
                If rb_Opcion.Checked = True Then 'Si selecciono nombre.
                    dv.RowFilter = "Nombre LIKE '%" + descrip + "%'"
                ElseIf rb_Opcion2.Checked = True Then 'si selecciono codigo.
                    dv.RowFilter = "Codigo LIKE '%" + descrip + "%'"
                End If

                'actualizo el datagrid
                If dv.Count > 0 Then
                    DG_Productos.ColumnHeadersVisible = True
                    DG_Productos.DataSource = dv
                    DG_Productos.Refresh()
                    lbl_Msg.Visible = False
                Else
                    DG_Productos.ColumnHeadersVisible = False
                    DG_Productos.DataSource = Nothing
                    DG_Productos.Refresh()
                    lbl_Msg.Visible = True
                End If

                Me.Cursor = Cursors.Arrow
            End If
        End If
    End Sub

    'Solapas.
    Private Sub TabProductos_Selected(ByVal sender As Object, ByVal e As System.Windows.Forms.TabControlEventArgs) Handles TabProductos.Selected
        'Cambio el cursor a "WAIT"
        Me.Cursor = Cursors.WaitCursor

        If TabProductos.SelectedTab.Name = "TbListado" Then 'TAB LISTADO DE PRODUCTOS
            'Actualizo el datagrid si se selecciona el tab del listado
            'Cargo el datagrid de productos
            CargarProductos()

            'Limpio los formularios
            LimpiarFormAltaProductos()
            LimpiarFormModificacionProductos()

            'Seteo el id_Producto en cero
            EProductos.id_Producto = 0

        ElseIf TabProductos.SelectedTab.Name = "TbAlta" Then 'TAB ALTA DE PRODUCTOS
            'Limpio el formulario de alta.
            LimpiarFormAltaProductos()
            txt_buscar.Clear()

            'Cargo el checkboxlist con los aromas
            Dim dsAromas As New DataSet
            dsAromas = NegAromas.ListadoAromas()
            If dsAromas.Tables(0).Rows.Count > 0 Then
                chk_Aromas.DataSource = dsAromas.Tables(0)
                chk_Aromas.DisplayMember = "Descripcion"
                chk_Aromas.ValueMember = "id_Aroma"
                chk_Aromas.Refresh()
            End If

            'Cargo el checkboxlist con los aromas
            Dim dsMateriales As New DataSet
            dsMateriales = NegMateriales.ListadoMateriales()
            If dsMateriales.Tables(0).Rows.Count > 0 Then
                chk_Materiales.DataSource = dsMateriales.Tables(0)
                chk_Materiales.DisplayMember = "Descripcion"
                chk_Materiales.ValueMember = "id_Material"
                chk_Materiales.Refresh()
            End If

            'Cargo el checkboxlist con los colores
            Dim dsColores As New DataSet
            dsColores = NegColores.ListadoColores()
            If dsColores.Tables(0).Rows.Count > 0 Then
                chk_Colores.DataSource = dsColores.Tables(0)
                chk_Colores.DisplayMember = "Descripcion"
                chk_Colores.ValueMember = "id_Color"
                chk_Colores.Refresh()
            End If

            'Seteo el id_Producto en cero
            EProductos.id_Producto = 0

        ElseIf TabProductos.SelectedTab.Name = "TbMod" Then 'TAB MODIFICACION DE PRODUCTOS
            If EProductos.id_Producto > 0 Or EProductos.id_Producto <> Nothing Then
                txt_buscar.Clear()
            Else
                MessageBox.Show("Debe seleccionar previamente un producto.", "Administración de Productos", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                TabProductos.SelectedTab = TabProductos.TabPages("TbListado")
            End If
        End If

        'Cambio el cursor a NORMAL.
        Me.Cursor = Cursors.Arrow
    End Sub

    'Click en el listado de productos.
    Private Sub DG_Productos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Productos.CellContentClick
        If DG_Productos.Columns(e.ColumnIndex).Name = "Eliminar" Then 'Si se hace click en el boton "eliminar" de la fila.
            Dim Result As DialogResult
            Result = MessageBox.Show("¿Está seguro que desea eliminar el producto?", "Administración de Productos", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Result = System.Windows.Forms.DialogResult.Yes Then 'Si acepta eliminar el item
                Dim id_Producto As Integer = DG_Productos.Rows(e.RowIndex).Cells("id_Producto").Value
                If id_Producto = 0 Then
                    'si no completo la descripcion, muestro un msg de error.
                    MessageBox.Show("No se puede eliminar el producto.", "Administración de Productos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    'Cambio el cursor a "WAIT"
                    Me.Cursor = Cursors.WaitCursor

                    'ejecuto el sp_Productos_Eliminar.
                    MessageBox.Show(NegProductos.EliminarProducto(id_Producto), "Administración de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    'refresco el datagrid de productos
                    CargarProductos()

                    'Cambio el cursor a "NORMAL"
                    Me.Cursor = Cursors.Arrow
                End If
            End If
        ElseIf DG_Productos.Columns(e.ColumnIndex).Name = "Modificar" Then 'Si se hace click en el boton "modificar" de la fila.
            Dim id_Producto As Integer = DG_Productos.Rows(e.RowIndex).Cells("id_Producto").Value()

            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            'lleno la entidad productos
            EProductos = NegProductos.TraerProducto(id_Producto)

            'asigno la clase a los controles del tab_Modificacion
            txt_Nombre_mod.Text = EProductos.Nombre
            txt_Origen_mod.Text = EProductos.Origen
            txt_Tamano_mod.Text = EProductos.Tamano
            txt_Codigo_mod.Text = EProductos.Codigo
            txt_Costo_mod.Text = EProductos.Costo
            txt_Foto_mod.Text = ""

            If EProductos.Descripcion <> "" Then
                txt_Descripcion_mod.Text = Replace(Trim(EProductos.Descripcion), "<br />", vbCrLf)
            Else
                txt_Descripcion_mod.Text = ""
            End If

            If EProductos.Habilitado = 1 Then
                chk_Habilitado_mod.Checked = True
            Else
                chk_Habilitado_mod.Checked = False
            End If

            If EProductos.Novedad = 1 Then
                chk_Novedad_mod.Checked = True
            Else
                chk_Novedad_mod.Checked = False
            End If

            If EProductos.SubirWeb = 1 Then
                chk_SubirWeb_mod.Checked = True
            Else
                chk_SubirWeb_mod.Checked = False
            End If

            'Cargo los precios
            EProductos = NegProductos.TraerPrecios(EProductos)
            txt_Precio1_mod.Text = EProductos.Precio1
            txt_Precio2_mod.Text = EProductos.Precio2
            txt_Precio3_mod.Text = EProductos.Precio3
            txt_Precio4_mod.Text = EProductos.Precio4
            txt_Precio5_mod.Text = EProductos.Precio5
            txt_Precio6_mod.Text = EProductos.Precio6

            'Cargo el combo de categorias
            Dim dsCategorias As New DataSet
            dsCategorias = NegProductosCat.ListadoCategorias()
            If dsCategorias.Tables(0).Rows.Count > 0 Then
                cb_Categoria_mod.DataSource = Nothing
                cb_Categoria_mod.DataSource = dsCategorias.Tables(0)
                cb_Categoria_mod.DisplayMember = "Descripcion"
                cb_Categoria_mod.ValueMember = "id_Categoria"
                cb_Categoria_mod.SelectedValue = EProductos.id_Categoria
                cb_Categoria_mod.Refresh()
            End If

            'Cargo el combo de subcategorias
            Dim dsSubcategorias As New DataSet
            dsSubcategorias = NegProductosSubCat.ListadoSubcategorias(EProductos.id_Categoria)
            If dsSubcategorias.Tables(0).Rows.Count > 0 Then
                cb_Subcategoria_mod.DataSource = Nothing
                cb_Subcategoria_mod.DataSource = dsSubcategorias.Tables(0)
                cb_Subcategoria_mod.DisplayMember = "Descripcion"
                cb_Subcategoria_mod.ValueMember = "id_Subcategoria"
                cb_Subcategoria_mod.SelectedValue = EProductos.id_Subcategoria
                cb_Subcategoria_mod.Refresh()
            End If

            'Cargo el combo de proveedores
            Dim dsProveedores As New DataSet
            dsProveedores = NegProveedores.ListadoProveedores()
            If dsProveedores.Tables(0).Rows.Count > 0 Then
                cb_Proveedor_mod.DataSource = Nothing
                cb_Proveedor_mod.DataSource = dsProveedores.Tables(0)
                cb_Proveedor_mod.DisplayMember = "RazonSocial"
                cb_Proveedor_mod.ValueMember = "id_Proveedor"
                cb_Proveedor_mod.SelectedValue = EProductos.id_Proveedor
                cb_Proveedor_mod.Refresh()
            End If

            'Cargo el checkboxlist con los aromas
            Dim dsAromas As New DataSet
            dsAromas = NegAromas.ListadoAromas()
            If dsAromas.Tables(0).Rows.Count > 0 Then
                chk_Aromas_mod.DataSource = Nothing
                chk_Aromas_mod.DataSource = dsAromas.Tables(0)
                chk_Aromas_mod.DisplayMember = "Descripcion"
                chk_Aromas_mod.ValueMember = "id_Aroma"
                chk_Aromas_mod.Refresh()
            End If

            'primero hay que ver si ese producto tiene algun aroma ya cargado sino no vale la pena entrar a ningun for
            Dim dsAromas2 As New DataSet
            dsAromas2 = NegAromas.ListadoAromasProducto(id_Producto)
            If dsAromas2.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To chk_Aromas_mod.Items.Count - 1
                    For Each DataRow In dsAromas2.Tables(0).Rows
                        If DirectCast(chk_Aromas_mod.Items(i), System.Data.DataRowView).Row.ItemArray(0) = DirectCast(DataRow, System.Data.DataRow).ItemArray(0) Then
                            chk_Aromas_mod.SetItemChecked(i, True)
                        End If
                    Next
                Next i
            End If

            'Cargo el checkboxlist con los materiales
            Dim dsMateriales As New DataSet
            dsMateriales = NegMateriales.ListadoMateriales()
            If dsMateriales.Tables(0).Rows.Count > 0 Then
                chk_Materiales_mod.DataSource = Nothing
                chk_Materiales_mod.DataSource = dsMateriales.Tables(0)
                chk_Materiales_mod.DisplayMember = "Descripcion"
                chk_Materiales_mod.ValueMember = "id_Material"
                chk_Materiales_mod.Refresh()
            End If

            'primero hay que ver si ese producto tiene algun material ya cargado sino no vale la pena entrar a ningun for
            Dim dsMateriales2 As New DataSet
            dsMateriales2 = NegMateriales.ListadoMaterialesProducto(id_Producto)
            If dsMateriales2.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To chk_Materiales_mod.Items.Count - 1
                    For Each DataRow In dsMateriales2.Tables(0).Rows
                        If DirectCast(chk_Materiales_mod.Items(i), System.Data.DataRowView).Row.ItemArray(0) = DirectCast(DataRow, System.Data.DataRow).ItemArray(0) Then
                            chk_Materiales_mod.SetItemChecked(i, True)
                        End If
                    Next
                Next i
            End If

            'Cargo el checkboxlist con los colores
            Dim dsColores As New DataSet
            dsColores = NegColores.ListadoColores()
            If dsColores.Tables(0).Rows.Count > 0 Then
                chk_Colores_mod.DataSource = Nothing
                chk_Colores_mod.DataSource = dsColores.Tables(0)
                chk_Colores_mod.DisplayMember = "Descripcion"
                chk_Colores_mod.ValueMember = "id_Color"
            End If

            'primero hay que ver si ese producto tiene algun color ya cargado sino no vale la pena entrar a ningun for
            Dim dsColores2 As New DataSet
            dsColores2 = NegColores.ListadoColoresProducto(id_Producto)
            If dsColores2.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To chk_Colores_mod.Items.Count - 1
                    For Each DataRow In dsColores2.Tables(0).Rows
                        If DirectCast(chk_Colores_mod.Items(i), System.Data.DataRowView).Row.ItemArray(0) = DirectCast(DataRow, System.Data.DataRow).ItemArray(0) Then
                            chk_Colores_mod.SetItemChecked(i, True)
                        End If
                    Next
                Next i
            End If

            'Cargo la imagen en el picture
            Try
                Dim client As New System.Net.WebClient()
                Dim stream As New System.IO.MemoryStream()
                Dim data As Byte() = client.DownloadData("http://www.cinderelladecoracion.com/www/software_cinderella/imagenes/" & EProductos.Foto)
                client.Dispose()
                stream.Write(data, 0, data.Length)
                pb_foto_mod.Image = Image.FromStream(stream)
            Catch
                pb_foto_mod.Image = My.Resources.Recursos.Sinfoto
            End Try

            'Realizo el codigo de barras y lo asigno al picture
            'esto lo uso para los seteos, no cambiarlos, mandar estos tal cual. 
            Dim seteos As New CodigoBarras.Ean13Settings
            seteos.BarCodeHeight = 80
            seteos.BarWidth = 1
            seteos.BottomMargin = 5
            seteos.LeftMargin = 5
            seteos.RightMargin = 5
            seteos.TopMargin = 10
            seteos.Font = New Font(FontFamily.GenericSansSerif, 8, FontStyle.Regular)

            Try
                'aca genero el codigo
                Dim CodigoBarras As New CodigoBarras.Ean13(EProductos.CodigoBarra, EProductos.Nombre, EProductos.Codigo, "$" & EProductos.Precio1, seteos)
                pb_CodigoBarra.Image = CodigoBarras.Paint()
            Catch ex As Exception

            End Try

            'Cambio el cursor a "NORMAL"
            Me.Cursor = Cursors.Arrow

            'hago foco en el tab_modificacion 
            TabProductos.SelectedTab = TabProductos.TabPages("TbMod")
        End If
    End Sub

    'Doble Click en el listado de productos.
    Private Sub DG_Productos_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Productos.CellDoubleClick
        If DG_Productos.SelectedRows.Count > 0 Then
            If e.RowIndex >= 0 Then
                Dim id_Producto As Integer = DG_Productos.Rows(e.RowIndex).Cells("id_Producto").Value()

                'Cambio el cursor a "WAIT"
                TabProductos.Cursor = Cursors.WaitCursor

                'lleno la entidad productos
                EProductos = NegProductos.TraerProducto(id_Producto)

                'asigno la clase a los controles del tab_Modificacion
                txt_Nombre_mod.Text = EProductos.Nombre
                txt_Origen_mod.Text = EProductos.Origen
                txt_Tamano_mod.Text = EProductos.Tamano
                txt_Codigo_mod.Text = EProductos.Codigo
                txt_Costo_mod.Text = EProductos.Costo
                txt_Foto_mod.Text = ""

                If EProductos.Descripcion <> "" Then
                    txt_Descripcion_mod.Text = Replace(Trim(EProductos.Descripcion), "<br />", vbCrLf)
                Else
                    txt_Descripcion_mod.Text = ""
                End If

                If EProductos.Habilitado = 1 Then
                    chk_Habilitado_mod.Checked = True
                Else
                    chk_Habilitado_mod.Checked = False
                End If

                If EProductos.Novedad = 1 Then
                    chk_Novedad_mod.Checked = True
                Else
                    chk_Novedad_mod.Checked = False
                End If

                If EProductos.SubirWeb = 1 Then
                    chk_SubirWeb_mod.Checked = True
                Else
                    chk_SubirWeb_mod.Checked = False
                End If

                'Cargo los precios
                EProductos = NegProductos.TraerPrecios(EProductos)
                txt_Precio1_mod.Text = EProductos.Precio1
                txt_Precio2_mod.Text = EProductos.Precio2
                txt_Precio3_mod.Text = EProductos.Precio3
                txt_Precio4_mod.Text = EProductos.Precio4
                txt_Precio5_mod.Text = EProductos.Precio5
                txt_Precio6_mod.Text = EProductos.Precio6

                'Cargo el combo de categorias
                Dim dsCategorias As New DataSet
                dsCategorias = NegProductosCat.ListadoCategorias()
                If dsCategorias.Tables(0).Rows.Count > 0 Then
                    cb_Categoria_mod.DataSource = Nothing
                    cb_Categoria_mod.DataSource = dsCategorias.Tables(0)
                    cb_Categoria_mod.DisplayMember = "Descripcion"
                    cb_Categoria_mod.ValueMember = "id_Categoria"
                    cb_Categoria_mod.SelectedValue = EProductos.id_Categoria
                    cb_Categoria_mod.Refresh()
                End If

                'Cargo el combo de subcategorias
                Dim dsSubcategorias As New DataSet
                dsSubcategorias = NegProductosSubCat.ListadoSubcategorias(EProductos.id_Categoria)
                If dsSubcategorias.Tables(0).Rows.Count > 0 Then
                    cb_Subcategoria_mod.DataSource = Nothing
                    cb_Subcategoria_mod.DataSource = dsSubcategorias.Tables(0)
                    cb_Subcategoria_mod.DisplayMember = "Descripcion"
                    cb_Subcategoria_mod.ValueMember = "id_Subcategoria"
                    cb_Subcategoria_mod.SelectedValue = EProductos.id_Subcategoria
                    cb_Subcategoria_mod.Refresh()
                End If

                'Cargo el combo de proveedores
                Dim dsProveedores As New DataSet
                dsProveedores = NegProveedores.ListadoProveedores()
                If dsProveedores.Tables(0).Rows.Count > 0 Then
                    cb_Proveedor_mod.DataSource = Nothing
                    cb_Proveedor_mod.DataSource = dsProveedores.Tables(0)
                    cb_Proveedor_mod.DisplayMember = "RazonSocial"
                    cb_Proveedor_mod.ValueMember = "id_Proveedor"
                    cb_Proveedor_mod.SelectedValue = EProductos.id_Proveedor
                    cb_Proveedor_mod.Refresh()
                End If

                'Cargo el checkboxlist con los aromas
                Dim dsAromas As New DataSet
                dsAromas = NegAromas.ListadoAromas()
                If dsAromas.Tables(0).Rows.Count > 0 Then
                    chk_Aromas_mod.DataSource = Nothing
                    chk_Aromas_mod.DataSource = dsAromas.Tables(0)
                    chk_Aromas_mod.DisplayMember = "Descripcion"
                    chk_Aromas_mod.ValueMember = "id_Aroma"
                    chk_Aromas_mod.Refresh()
                End If

                Dim dsAroma As DataSet = NegAromas.ListadoAromasProducto(id_Producto)
                'checkeo los items de aromas que corresponden al producto.
                For i As Integer = 0 To chk_Aromas_mod.Items.Count - 1
                    For j As Integer = 0 To dsAroma.Tables(0).Rows.Count - 1
                        If dsAroma.Tables(0).Rows.Count > 0 Then
                            If DirectCast(chk_Aromas_mod.Items(i), System.Data.DataRowView).Row.ItemArray(0) = dsAroma.Tables(0).Rows(j).Item(0) Then
                                chk_Aromas_mod.SetItemChecked(i, True)
                            End If
                        End If
                    Next j
                Next i

                'Cargo el checkboxlist con los materiales
                Dim dsMateriales As New DataSet
                dsMateriales = NegMateriales.ListadoMateriales()
                If dsMateriales.Tables(0).Rows.Count > 0 Then
                    chk_Materiales_mod.DataSource = Nothing
                    chk_Materiales_mod.DataSource = dsMateriales.Tables(0)
                    chk_Materiales_mod.DisplayMember = "Descripcion"
                    chk_Materiales_mod.ValueMember = "id_Material"
                    chk_Materiales_mod.Refresh()
                End If

                Dim dsMaterial As DataSet = NegMateriales.ListadoMaterialesProducto(id_Producto)
                'checkeo los items de aromas que corresponden al producto.
                For i As Integer = 0 To chk_Materiales_mod.Items.Count - 1
                    For j As Integer = 0 To dsMaterial.Tables(0).Rows.Count - 1
                        If dsMaterial.Tables(0).Rows.Count > 0 Then
                            If DirectCast(chk_Materiales_mod.Items(i), System.Data.DataRowView).Row.ItemArray(0) = dsMaterial.Tables(0).Rows(j).Item(0) Then
                                chk_Materiales_mod.SetItemChecked(i, True)
                            End If
                        End If
                    Next j
                Next i

                'Cargo el checkboxlist con los materiales
                Dim dsColores As New DataSet
                dsColores = NegColores.ListadoColores()
                If dsColores.Tables(0).Rows.Count > 0 Then
                    chk_Colores_mod.DataSource = Nothing
                    chk_Colores_mod.DataSource = dsColores.Tables(0)
                    chk_Colores_mod.DisplayMember = "Descripcion"
                    chk_Colores_mod.ValueMember = "id_Color"
                    chk_Colores_mod.Refresh()
                End If

                Dim dsColor As DataSet = NegColores.ListadoColoresProducto(id_Producto)
                'checkeo los items de aromas que corresponden al producto.
                For i As Integer = 0 To chk_Colores_mod.Items.Count - 1
                    For j As Integer = 0 To dsColor.Tables(0).Rows.Count - 1
                        If dsColor.Tables(0).Rows.Count > 0 Then
                            If DirectCast(chk_Colores_mod.Items(i), System.Data.DataRowView).Row.ItemArray(0) = dsColor.Tables(0).Rows(j).Item(0) Then
                                chk_Colores_mod.SetItemChecked(i, True)
                            End If
                        End If
                    Next j
                Next i

                'Cargo la imagen
                Try
                    Dim client As New System.Net.WebClient()
                    Dim stream As New System.IO.MemoryStream()
                    Dim data As Byte() = client.DownloadData("http://www.cinderelladecoracion.com/software_cinderella/imagenes/" & EProductos.Foto)
                    client.Dispose()
                    stream.Write(data, 0, data.Length)
                    pb_foto_mod.Image = Image.FromStream(stream)
                Catch
                    pb_foto_mod.Image = My.Resources.Recursos.Sinfoto
                End Try

                'Realizo el codigo de barras y lo asigno al picture
                'esto lo uso para los seteos, no cambiarlos, mandar estos tal cual. 
                Dim seteos As New CodigoBarras.Ean13Settings
                seteos.BarCodeHeight = 80
                seteos.BarWidth = 1
                seteos.BottomMargin = 5
                seteos.LeftMargin = 5
                seteos.RightMargin = 5
                seteos.TopMargin = 10
                seteos.Font = New Font(FontFamily.GenericSansSerif, 8, FontStyle.Regular)

                Try
                    'aca genero el codigo
                    Dim CodigoBarras As New CodigoBarras.Ean13(EProductos.CodigoBarra, EProductos.Nombre, EProductos.Codigo, "$" & EProductos.Precio1, seteos)
                    pb_CodigoBarra.Image = CodigoBarras.Paint()
                Catch ex As Exception

                End Try

                'Cambio el cursor a "NORMAL"
                TabProductos.Cursor = Cursors.Arrow

                'hago foco en el tab_modificacion 
                TabProductos.SelectedTab = TabProductos.TabPages("TbMod")
            End If
        End If

    End Sub

    'Boton Modificar Producto.
    Private Sub btn_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Modificar.Click
        If txt_Nombre_mod.Text = "" Or txt_Codigo_mod.Text = "" Or cb_Categoria_mod.SelectedItem Is Nothing Or cb_Subcategoria_mod.SelectedItem Is Nothing Or cb_Proveedor_mod.SelectedItem Is Nothing Then
            MessageBox.Show("Debe completar los campos requeridos.", "Administración de Productos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                'Cambio el cursor a "WAIT"
                Me.Cursor = Cursors.WaitCursor

                'Lleno la entidad productos
                EProductos.Nombre = Trim(txt_Nombre_mod.Text)
                EProductos.Origen = Trim(txt_Origen_mod.Text)
                EProductos.Tamano = Trim(txt_Tamano_mod.Text)
                EProductos.Codigo = Trim(txt_Codigo_mod.Text)
                EProductos.Costo = Trim(txt_Costo_mod.Text)
                EProductos.Foto = Trim(txt_Foto_mod.Text)
                If txt_Descripcion_mod.Text <> "" Then
                    EProductos.Descripcion = Replace(Trim(txt_Descripcion_mod.Text), vbCrLf, "<br />")
                Else
                    EProductos.Descripcion = ""
                End If
                EProductos.id_Categoria = Trim(cb_Categoria_mod.SelectedValue)
                EProductos.id_Subcategoria = Trim(cb_Subcategoria_mod.SelectedValue)
                EProductos.id_Proveedor = Trim(cb_Proveedor_mod.SelectedValue)
                EProductos.Precio1 = Trim(txt_Precio1_mod.Text)
                EProductos.Precio2 = Trim(txt_Precio2_mod.Text)
                EProductos.Precio3 = Trim(txt_Precio3_mod.Text)
                EProductos.Precio4 = Trim(txt_Precio4_mod.Text)
                EProductos.Precio5 = Trim(txt_Precio5_mod.Text)
                EProductos.Precio6 = Trim(txt_Precio6_mod.Text)

                If chk_Habilitado_mod.Checked = True Then
                    EProductos.Habilitado = 1
                Else
                    EProductos.Habilitado = 0
                End If

                If chk_Novedad_mod.Checked = True Then
                    EProductos.Novedad = 1
                Else
                    EProductos.Novedad = 0
                End If

                If chk_SubirWeb_mod.Checked = True Then
                    EProductos.SubirWeb = 1
                Else
                    EProductos.SubirWeb = 0
                End If
                EProductos.Materiales = chk_Materiales_mod
                EProductos.Aromas = chk_Aromas_mod
                EProductos.Colores = chk_Colores_mod
                EProductos.EliminarFoto = Ck_EliminarFoto.Checked

                'Ejecuto el sp_Productos_Mofidicacion
                MessageBox.Show(NegProductos.ModificacionProducto(EProductos), "Administración de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)

                'Limpio el formulario
                LimpiarFormModificacionProductos()

                'Cambio el cursor a "NORMAL"
                Me.Cursor = Cursors.Arrow

                'Redirecciono al listado
                TabProductos.SelectedTab = TabProductos.TabPages("TbListado")

            Catch ex As Exception
                Me.Cursor = Cursors.Arrow
                MessageBox.Show("Se ha producido un error al modificar el producto. Por favor, intente más tarde.", "Administración de Productos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btn_Open_mod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Open_mod.Click
        Cargar.Title = "Seleccione una Fotografía" 'Título de la ventana que se abrirá para seleccionar el archivo.
        Cargar.Filter = "Jpg|*.jpg|Png|*.png|Gif|*.gif|Todos los archivos|*.*" 'Tipo de extensiones soportadas, fijaros como en la primera parte se pone el nombre, el que se quiera, después ponemos una barra vertical a modo de separación y ponemos *."extensión", el asterisco significa que nos permitirá cualquier nombre de archivo, la extensión hay que ponerla IGUAL que las que queramos abrir, lo de todos los archivos es opcional..
        Cargar.FilterIndex = 0 'Elegimos que se quede por defecto la primera extensión a la vista.
        Cargar.InitialDirectory = "C:\Documents and Settings\" & My.User.Name & "\Escritorio" 'Con esto haremos que el directorio inicial sea nuestro escritorio, podemos modificarlo a nuestro antojo si quisieramos abrirlo en mis documentos o en algún otro lugar lo ponemos y ya está.
        Cargar.RestoreDirectory = True 'De esta forma, mientras no cerremos la aplicación se "guardará" el último directorio seleccionado para no tener que elegirlo cada vez.
        Cargar.FileName = "" 'Con esto hacemos que al abrir la ventana no haya un nombre escrito.
        If Cargar.ShowDialog() = Windows.Forms.DialogResult.OK Then 'Si pulsamos aceptar en la ventanita.
            'destino = My.Application.Info.DirectoryPath & "\Fotografias Alumnos\" + IO.Path.GetFileName(Cargar.FileName)
            txt_Foto_mod.Text = Cargar.FileName

            'Cargo la imagen en el picturebox.
            Dim fs As System.IO.FileStream
            fs = New System.IO.FileStream(Cargar.FileName, IO.FileMode.Open, IO.FileAccess.Read)
            pb_foto_mod.Image = System.Drawing.Image.FromStream(fs)
            fs.Close()
        End If
    End Sub

    'seteo las opciones del buscador.
    Private Sub rb_Opcion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_Opcion.CheckedChanged
        If rb_Opcion.Checked = True Then
            rb_Opcion2.Checked = False
        Else
            rb_Opcion2.Checked = True
        End If
        txt_buscar.Focus()
    End Sub

    'seteo las opciones del buscador.
    Private Sub rb_Opcion2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_Opcion2.CheckedChanged
        If rb_Opcion2.Checked = True Then
            rb_Opcion.Checked = False
        Else
            rb_Opcion.Checked = True
        End If
        txt_buscar.Focus()
    End Sub

    'Realizo la busqueda.
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        'Seteo las variables.
        Dim descrip As String
        descrip = Trim(txt_buscar.Text.ToLower)

        If descrip = "" Then
            ErrorProductos.SetError(txt_buscar, "Debe completar el campo de busqueda.")
        Else
            Me.Cursor = Cursors.WaitCursor
            ErrorProductos.SetError(txt_buscar, Nothing)
            Dim dv As DataView = NegProductos.ListadoProductos(False).Tables(0).DefaultView
            If rb_Opcion.Checked = True Then 'Si selecciono nombre.
                dv.RowFilter = "Nombre LIKE '%" + descrip + "%'"
            ElseIf rb_Opcion2.Checked = True Then 'si selecciono codigo.
                dv.RowFilter = "Codigo LIKE '%" + descrip + "%'"
            End If

            'actualizo el datagrid
            If dv.Count > 0 Then
                DG_Productos.ColumnHeadersVisible = True
                DG_Productos.DataSource = dv
                DG_Productos.Refresh()
                lbl_Msg.Visible = False
            Else
                DG_Productos.ColumnHeadersVisible = False
                DG_Productos.DataSource = Nothing
                DG_Productos.Refresh()
                lbl_Msg.Visible = True
            End If

            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    'Limpio los filtros del buscador.
    Private Sub btn_Restablecer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Restablecer.Click
        Try
            'Cursor
            Me.Cursor = Cursors.WaitCursor

            CargarProductos()

            'Limpio controles
            rb_Opcion.Checked = True
            rb_Opcion2.Checked = False
            txt_buscar.Clear()
            txt_buscar.Focus()

            'Cursor
            Me.Cursor = Cursors.Arrow

        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha encontrado un error al cargar el listado de productos.", "Administración de Productos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Boton que elimina un producto.
    Private Sub Btn_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Eliminar.Click
        Dim Result As DialogResult
        Result = MessageBox.Show("¿Está seguro que desea eliminar el producto?", "Administración de Productos", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If Result = System.Windows.Forms.DialogResult.Yes Then 'Si acepta eliminar el item
            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            Dim id_Producto As Integer = EProductos.id_Producto
            If id_Producto = 0 Then
                'si no completo la descripcion, muestro un msg de error.
                MessageBox.Show("No se puede eliminar el producto.", "Administración de Productos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                'ejecuto el sp_Productos_Eliminar.
                MessageBox.Show(NegProductos.EliminarProducto(id_Producto), "Administración de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)

                CargarProductos()
            End If

            'Cambio el cursor a "NORMAL"
            Me.Cursor = Cursors.Arrow

            'Redirecciono al listado
            TabProductos.SelectedTab = TabProductos.TabPages("TbListado")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_Exportar.Click
        Try
            'Configuro la pantalla de guardado de archivos
            SaveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            SaveFileDialog.FileName = "Productos"
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
                NegProductos.ExportarExcel(SaveFileDialog.FileName, ConfigurationManager.AppSettings("ExportarExcelPlantillaProducto"))

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
            MessageBox.Show("Se ha producido un error en la exportación de la información. Verifique que el documento no se encuentre en uso o esté abierto. Por favor, intente más tarde.", "Administración de Productos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            LogHelper.WriteLog("ERROR Metodo: ExportarExcel" + Environment.NewLine + ex.ToString())
        End Try
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

                Dim DatosConError As DataTable = New DataTable()

                Dim Mensaje As String = NegProductos.ImportarExcel(OpenFileDialog.FileName, DatosConError)

                'Voy seteando la barra de progreso
                frmCargadorDeEspera.Close()
                frmCargadorDeEspera.Dispose()

                'Cambio el cursor a "NORMAL"
                Me.Cursor = Cursors.Arrow

                MessageBox.Show(Mensaje, "Administración de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)

                'Si se genero el backup habilito el boton de restaurar
                If (System.IO.File.Exists(AppDomain.CurrentDomain.BaseDirectory + "\ProductosBKP.xml")) Then
                    Me.ToolProd.SetToolTip(Me.btn_Restore, String.Format("Haz click aquí para restaurar la informacion del los productos con la ultima copia de seguridad con fecha {0}", System.IO.File.GetCreationTime(AppDomain.CurrentDomain.BaseDirectory + "\ProductosBKP.xml").ToString("dd/MM/yyyy hh:mm:ss")))
                Else
                    btn_Restore.Enabled = False
                End If

                'si en el proceso de importacion alguna fila modificada no fue importada por algun motivo 
                If (DatosConError.Rows.Count > 0) Then
                    'muestro en pantalla las filas con errores
                    Dim frmProductosErrorImportar As frmProductosErrorImportar = New frmProductosErrorImportar()

                    'Elimino la columna de ID para que no se muestre
                    DatosConError.Columns.RemoveAt(0)
                    frmProductosErrorImportar.productosError = DatosConError

                    frmProductosErrorImportar.ShowDialog()
                End If
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

    Private Sub btn_Restore_Click(sender As Object, e As EventArgs) Handles btn_Restore.Click

        If (MessageBox.Show("Esta seguro que desea restaurar los valores de los productos en la base de datos?", "Administración de Productos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
            Try
                'Cambio el cursor a "WAIT"
                Me.Cursor = Cursors.WaitCursor

                frmCargadorDeEspera.Show()
                frmCargadorDeEspera.Text = "Restaurando valores a la Base"
                frmCargadorDeEspera.lbl_Descripcion.Text = "iniciando..."
                frmCargadorDeEspera.BarraProgreso.Minimum = 0
                frmCargadorDeEspera.BarraProgreso.Maximum = 4
                frmCargadorDeEspera.BarraProgreso.Value = 1
                frmCargadorDeEspera.Refresh()

                AddHandler NegProductos.UpdateProgress, AddressOf UpdateProgress

                NegProductos.Restaurar()

                'Voy seteando la barra de progreso
                frmCargadorDeEspera.Close()
                frmCargadorDeEspera.Dispose()

                'Cambio el cursor a "NORMAL"
                Me.Cursor = Cursors.Arrow

                MessageBox.Show("Se han restaurado lo valores en la base de datos correctamente", "Administración de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                'Voy seteando la barra de progreso
                frmCargadorDeEspera.Close()
                frmCargadorDeEspera.Dispose()

                'Cambio el cursor a "NORMAL"
                Me.Cursor = Cursors.Arrow
                MessageBox.Show("Se ha producido un error en la restauracion de la información. Por favor, intente más tarde.", "Administración de Productos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Public Sub UpdateProgress(ProgressStep As Integer, ProgressText As String)
        frmCargadorDeEspera.lbl_Descripcion.Text = ProgressText
        frmCargadorDeEspera.BarraProgreso.Value = ProgressStep
        frmCargadorDeEspera.Refresh()
    End Sub

    Sub EvaluarPermisos()
        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Productos_Administración_Crear)) Then

        Else
            TabProductos.TabPages.Remove(TabProductos.TabPages("TbAlta"))
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Productos_Administración_Exportar)) Then
            btn_Exportar.Enabled = True
        Else
            btn_Exportar.Enabled = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Productos_Administración_Importar)) Then
            btn_Importar.Enabled = True
        Else
            btn_Importar.Enabled = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Productos_Administración_Eliminar)) Then
            Btn_Eliminar.Enabled = True
            DG_Productos.Columns("Eliminar").Visible = True
        Else
            Btn_Eliminar.Enabled = False
            DG_Productos.Columns("Eliminar").Visible = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Productos_Administración_Modificar)) Then
            DG_Productos.Columns("Modificar").Visible = True
        Else
            TabProductos.TabPages.Remove(TabProductos.TabPages("TbMod"))
            DG_Productos.Columns("Modificar").Visible = False
            RemoveHandler DG_Productos.CellDoubleClick, AddressOf DG_Productos_CellDoubleClick
        End If
    End Sub

#End Region

End Class