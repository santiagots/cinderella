Imports System.ComponentModel
Imports System.Configuration
Imports System.IO
Imports Datos
Imports Entidades
Imports SistemaCinderella.VistaModelo.frmProductos

Public Class frmProductos
    Dim NegProductos As New Negocio.NegProductos
    Dim fuc As New Funciones
    Dim NegErrores As New Negocio.NegManejadorErrores
    Dim NegProductosCat As New Negocio.NegProductosCategorias
    Dim NegProductosSubCat As New Negocio.NegProductosSubcategorias
    Dim NegProveedores As New Negocio.NegProveedores
    Dim NegAromas As New Negocio.NegAromas
    Dim NegMateriales As New Negocio.NegMateriales
    Dim NegColores As New Negocio.NegColores

    Private productoVistaModelo As Producto = New Producto()

#Region "Región de Validaciones"

    'Valido que se ingrese solo currency en campo costo. - ALTA
    Private Sub Monto_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txt_Costo.KeyPress, txt_Precio1.KeyPress, txt_Precio2.KeyPress, txt_Precio3.KeyPress, txt_Precio4.KeyPress, txt_Precio5.KeyPress, txt_Precio6.KeyPress, txt_Precio1_mod.KeyPress, txt_Precio2_mod.KeyPress, txt_Precio3_mod.KeyPress, txt_Precio4_mod.KeyPress, txt_Precio5_mod.KeyPress, txt_Precio6_mod.KeyPress, txt_Costo_mod.KeyPress
        If e.KeyChar.ToString() = "." Then
            e.KeyChar = CChar(",")
        End If
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloCurrency(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub Monto_Leave(sender As Object, e As EventArgs) Handles txt_Costo.Leave, txt_Precio1.Leave, txt_Precio3.Leave, txt_Precio5.Leave, txt_Precio6.Leave, txt_Precio1_mod.Leave, txt_Precio3_mod.Leave, txt_Precio5_mod.Leave, txt_Precio6_mod.Leave, txt_Costo_mod.Leave
        Dim txt As TextBox = CType(sender, TextBox)
        If (txt.Text = String.Empty) Then
            txt.Text = "0"
        End If
    End Sub

    Private Sub Porcentaje_Leave(sender As Object, e As EventArgs) Handles txt_Precio2.Leave, txt_Precio4.Leave, txt_Precio2_mod.Leave, txt_Precio4_mod.Leave
        Dim txt As TextBox = CType(sender, TextBox)
        If (txt.Text = String.Empty) Then
            txt.Text = "0"
        End If

        txt.Text = txt.Text.Trim().Replace("%", "") / 100
    End Sub

#End Region

#Region "Región de Funciones"

    Private Sub Buscar()
        'Seteo las variables.
        Dim descrip As String = Trim(txt_buscar.Text.ToLower)

        If descrip = "" Then
            MessageBox.Show("Debe completar el campo de busqueda.", "Administración de Productos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Me.Cursor = Cursors.WaitCursor
            Dim dv As DataView = NegProductos.ListadoProductos(False).Tables(0).DefaultView
            If rb_Opcion.Checked = True Then 'Si selecciono nombre.
                dv.RowFilter = "Nombre LIKE '%" + descrip + "%'"
            ElseIf rb_Opcion2.Checked = True Then 'si selecciono codigo.
                dv.RowFilter = "Codigo LIKE '%" + descrip + "%'"
            End If

            'actualizo el datagrid
            If dv.Count > 0 Then
                DG_Productos.DataSource = dv
                DG_Productos.Refresh()
                lbl_Msg.Visible = False
            Else
                DG_Productos.DataSource = Nothing
                DG_Productos.Refresh()
                lbl_Msg.Visible = True
            End If

            Me.Cursor = Cursors.Arrow
        End If
    End Sub
#End Region

#Region "Región de Eventos"
    'Load del formulario de productos.
    Private Sub frmProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Cambio el cursor a "WAIT"
        TabProductos.Cursor = Cursors.WaitCursor

        'seteo el font a 8px
        DG_Productos.AlternatingRowsDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DG_Productos.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DG_Productos.RowHeadersDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DG_Productos.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

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

        ProductoBindingSource.DataSource = productoVistaModelo

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
            DG_Productos.Columns("Habilitado").DisplayIndex = 12
            DG_Productos.Columns("Modificar").DisplayIndex = 13
            DG_Productos.Columns("Eliminar").DisplayIndex = 14
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

    Private Sub Categoria_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_Categoria.SelectionChangeCommitted, cb_Categoria_mod.SelectionChangeCommitted
        Dim comboBox As ComboBox = CType(sender, ComboBox)
        If comboBox.SelectedValue <> 0 Then
            productoVistaModelo.CategoriasSeleccionada = comboBox.SelectedValue
            productoVistaModelo.ActualizarSubcategorias()
        End If
    End Sub

    'abro el open dialog para que seleccione una foto.
    Private Sub btn_Open_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Open.Click, btn_Open_mod.Click
        Cargar.Title = "Seleccione una Fotografía" 'Título de la ventana que se abrirá para seleccionar el archivo.
        Cargar.Filter = "Jpg|*.jpg|Png|*.png|Gif|*.gif|Todos los archivos|*.*" 'Tipo de extensiones soportadas, fijaros como en la primera parte se pone el nombre, el que se quiera, después ponemos una barra vertical a modo de separación y ponemos *."extensión", el asterisco significa que nos permitirá cualquier nombre de archivo, la extensión hay que ponerla IGUAL que las que queramos abrir, lo de todos los archivos es opcional..
        Cargar.FilterIndex = 0 'Elegimos que se quede por defecto la primera extensión a la vista.
        Cargar.InitialDirectory = "C:\Documents and Settings\" & My.User.Name & "\Escritorio" 'Con esto haremos que el directorio inicial sea nuestro escritorio, podemos modificarlo a nuestro antojo si quisieramos abrirlo en mis documentos o en algún otro lugar lo ponemos y ya está.
        Cargar.RestoreDirectory = True 'De esta forma, mientras no cerremos la aplicación se "guardará" el último directorio seleccionado para no tener que elegirlo cada vez.
        Cargar.FileName = "" 'Con esto hacemos que al abrir la ventana no haya un nombre escrito.
        If Cargar.ShowDialog() = Windows.Forms.DialogResult.OK Then 'Si pulsamos aceptar en la ventanita.
            productoVistaModelo.ActualizarFoto(Cargar.FileName)

        End If
    End Sub

    'Boton de alta de producto
    Private Sub Btn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Agregar.Click
        If txt_Nombre.Text = "" Or txt_Codigo.Text = "" Or cb_Categoria.SelectedItem Is Nothing Or cb_Subcategoria.SelectedItem Is Nothing Or cb_Proveedores.SelectedItem Is Nothing Or txt_Precio1.Text = "" Or txt_Precio2.Text = "" Or txt_Precio3.Text = "" Or txt_Precio4.Text = "" Or txt_Precio5.Text = "" Or txt_Precio6.Text = "" Then
            MessageBox.Show("Debe completar los campos requeridos.", "Administración de Productos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                'Cambio el cursor a "WAIT"
                Me.Cursor = Cursors.WaitCursor

                'Ejecuto el sp_Productos_Alta
                MessageBox.Show(productoVistaModelo.Alta(), "Administración de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)

                'Limpio el formulario
                productoVistaModelo.Limpiar()

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

            Buscar()
        End If
    End Sub

    'Solapas.
    Private Sub TabProductos_Selected(ByVal sender As Object, ByVal e As System.Windows.Forms.TabControlEventArgs) Handles TabProductos.Selected
        'Cambio el cursor a "WAIT"
        Me.Cursor = Cursors.WaitCursor

        productoVistaModelo.Limpiar()

        If TabProductos.SelectedTab.Name = "TbListado" Then 'TAB LISTADO DE PRODUCTOS
            'Actualizo el datagrid si se selecciona el tab del listado
            'Cargo el datagrid de productos
            CargarProductos()
        ElseIf TabProductos.SelectedTab.Name = "TbMod" Then 'TAB MODIFICACION DE PRODUCTOS
            If DG_Productos.CurrentRow IsNot Nothing Then

                Dim id_Producto As Integer = DG_Productos.CurrentRow.Cells("id_Producto").Value()

                productoVistaModelo.Cargar(id_Producto)
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
                    MessageBox.Show(productoVistaModelo.Eliminar(id_Producto), "Administración de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)

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
            productoVistaModelo.Cargar(id_Producto)

            'Cambio el cursor a "NORMAL"
            Me.Cursor = Cursors.Arrow

            'hago foco en el tab_modificacion 
            TabProductos.SelectedTab = TabProductos.TabPages("TbMod")
        End If
    End Sub

    'Doble Click en el listado de productos.
    Private Sub DG_Productos_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Productos.CellDoubleClick
        TabProductos.SelectedTab = TabProductos.TabPages("TbMod")
    End Sub

    'Boton Modificar Producto.
    Private Sub btn_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Modificar.Click
        If txt_Nombre_mod.Text = "" Or txt_Codigo_mod.Text = "" Or cb_Categoria_mod.SelectedItem Is Nothing Or cb_Subcategoria_mod.SelectedItem Is Nothing Or cb_Proveedor_mod.SelectedItem Is Nothing Or txt_Precio1_mod.Text = "" Or txt_Precio2_mod.Text = "" Or txt_Precio3_mod.Text = "" Or txt_Precio4_mod.Text = "" Or txt_Precio5_mod.Text = "" Or txt_Precio6_mod.Text = "" Then
            MessageBox.Show("Debe completar los campos requeridos.", "Administración de Productos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                'Cambio el cursor a "WAIT"
                Me.Cursor = Cursors.WaitCursor

                'Ejecuto el sp_Productos_Mofidicacion
                MessageBox.Show(productoVistaModelo.Modificar(), "Administración de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)

                'Limpio el formulario
                productoVistaModelo.Limpiar()

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
        Buscar()
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

            Dim id_Producto As Integer = DG_Productos.CurrentRow.Cells("id_Producto").Value
            If id_Producto = 0 Then
                'si no completo la descripcion, muestro un msg de error.
                MessageBox.Show("No se puede eliminar el producto.", "Administración de Productos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                'ejecuto el sp_Productos_Eliminar.
                MessageBox.Show(productoVistaModelo.Eliminar(id_Producto), "Administración de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)

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