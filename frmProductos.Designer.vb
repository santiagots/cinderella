<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductos))
        Me.TabProductos = New System.Windows.Forms.TabControl()
        Me.TbListado = New System.Windows.Forms.TabPage()
        Me.lbl_Msg = New System.Windows.Forms.Label()
        Me.GB_Buscar = New System.Windows.Forms.GroupBox()
        Me.btn_Restore = New System.Windows.Forms.Button()
        Me.btn_Importar = New System.Windows.Forms.Button()
        Me.btn_Exportar = New System.Windows.Forms.Button()
        Me.btn_Restablecer = New System.Windows.Forms.Button()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.rb_Opcion2 = New System.Windows.Forms.RadioButton()
        Me.rb_Opcion = New System.Windows.Forms.RadioButton()
        Me.txt_buscar = New System.Windows.Forms.TextBox()
        Me.DG_Productos = New System.Windows.Forms.DataGridView()
        Me.id_Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Subcategoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Habilitado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Modificar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Eliminar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TbAlta = New System.Windows.Forms.TabPage()
        Me.GB_Alta = New System.Windows.Forms.GroupBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txt_Costo = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lbl_Colores = New System.Windows.Forms.Label()
        Me.chk_Colores = New System.Windows.Forms.CheckedListBox()
        Me.GB_Precios = New System.Windows.Forms.GroupBox()
        Me.lbl_Precio6 = New System.Windows.Forms.Label()
        Me.txt_Precio6 = New System.Windows.Forms.TextBox()
        Me.lbl_Precio5 = New System.Windows.Forms.Label()
        Me.txt_Precio4 = New System.Windows.Forms.TextBox()
        Me.txt_Precio5 = New System.Windows.Forms.TextBox()
        Me.lbl_Precio4 = New System.Windows.Forms.Label()
        Me.txt_Precio2 = New System.Windows.Forms.TextBox()
        Me.lbl_Precio1 = New System.Windows.Forms.Label()
        Me.txt_Precio3 = New System.Windows.Forms.TextBox()
        Me.lbl_Precio2 = New System.Windows.Forms.Label()
        Me.txt_Precio1 = New System.Windows.Forms.TextBox()
        Me.lbl_Precio3 = New System.Windows.Forms.Label()
        Me.lbl_Foto2 = New System.Windows.Forms.Label()
        Me.pb_foto = New System.Windows.Forms.PictureBox()
        Me.lbl_Materiales = New System.Windows.Forms.Label()
        Me.Btn_Agregar = New System.Windows.Forms.Button()
        Me.lbl_Aroma = New System.Windows.Forms.Label()
        Me.chk_Materiales = New System.Windows.Forms.CheckedListBox()
        Me.chk_Aromas = New System.Windows.Forms.CheckedListBox()
        Me.cb_Proveedores = New System.Windows.Forms.ComboBox()
        Me.lbl_Proveedor = New System.Windows.Forms.Label()
        Me.btn_Open = New System.Windows.Forms.Button()
        Me.txt_Foto = New System.Windows.Forms.TextBox()
        Me.chk_Novedad = New System.Windows.Forms.CheckBox()
        Me.lbl_Novedad = New System.Windows.Forms.Label()
        Me.chk_SubirWeb = New System.Windows.Forms.CheckBox()
        Me.lbl_SubirWeb = New System.Windows.Forms.Label()
        Me.lbl_Foto = New System.Windows.Forms.Label()
        Me.cb_Subcategoria = New System.Windows.Forms.ComboBox()
        Me.cb_Categoria = New System.Windows.Forms.ComboBox()
        Me.lbl_Subcategoria = New System.Windows.Forms.Label()
        Me.lbl_Categoria = New System.Windows.Forms.Label()
        Me.txt_Descripcion = New System.Windows.Forms.TextBox()
        Me.lbl_Descripcion = New System.Windows.Forms.Label()
        Me.txt_Codigo = New System.Windows.Forms.TextBox()
        Me.lbl_Codigo = New System.Windows.Forms.Label()
        Me.txt_Tamano = New System.Windows.Forms.TextBox()
        Me.lbl_Tamano = New System.Windows.Forms.Label()
        Me.txt_Origen = New System.Windows.Forms.TextBox()
        Me.lbl_Origen = New System.Windows.Forms.Label()
        Me.chk_Habilitado = New System.Windows.Forms.CheckBox()
        Me.txt_Nombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_Nombre = New System.Windows.Forms.Label()
        Me.TbMod = New System.Windows.Forms.TabPage()
        Me.GB_Modificacion = New System.Windows.Forms.GroupBox()
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txt_Costo_mod = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Ck_EliminarFoto = New System.Windows.Forms.CheckBox()
        Me.Btn_Eliminar = New System.Windows.Forms.Button()
        Me.lbl_CodigoBarra = New System.Windows.Forms.Label()
        Me.pb_CodigoBarra = New System.Windows.Forms.PictureBox()
        Me.lbl_Colores_mod = New System.Windows.Forms.Label()
        Me.chk_Colores_mod = New System.Windows.Forms.CheckedListBox()
        Me.Gb_Precios_mod = New System.Windows.Forms.GroupBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txt_Precio6_mod = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_Precio4_mod = New System.Windows.Forms.TextBox()
        Me.txt_Precio5_mod = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_Precio2_mod = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txt_Precio3_mod = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txt_Precio1_mod = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.chk_Novedad_mod = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chk_SubirWeb_mod = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chk_Habilitado_mod = New System.Windows.Forms.CheckBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.pb_foto_mod = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_Modificar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chk_Materiales_mod = New System.Windows.Forms.CheckedListBox()
        Me.chk_Aromas_mod = New System.Windows.Forms.CheckedListBox()
        Me.cb_Proveedor_mod = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_Open_mod = New System.Windows.Forms.Button()
        Me.txt_Foto_mod = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cb_Subcategoria_mod = New System.Windows.Forms.ComboBox()
        Me.cb_Categoria_mod = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_Descripcion_mod = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_Codigo_mod = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_Tamano_mod = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_Origen_mod = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_Nombre_mod = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Cargar = New System.Windows.Forms.OpenFileDialog()
        Me.ErrorProductos = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolProd = New System.Windows.Forms.ToolTip(Me.components)
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.TabProductos.SuspendLayout()
        Me.TbListado.SuspendLayout()
        Me.GB_Buscar.SuspendLayout()
        CType(Me.DG_Productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TbAlta.SuspendLayout()
        Me.GB_Alta.SuspendLayout()
        Me.GB_Precios.SuspendLayout()
        CType(Me.pb_foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TbMod.SuspendLayout()
        Me.GB_Modificacion.SuspendLayout()
        CType(Me.pb_CodigoBarra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gb_Precios_mod.SuspendLayout()
        CType(Me.pb_foto_mod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabProductos
        '
        Me.TabProductos.Controls.Add(Me.TbListado)
        Me.TabProductos.Controls.Add(Me.TbAlta)
        Me.TabProductos.Controls.Add(Me.TbMod)
        Me.TabProductos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabProductos.Location = New System.Drawing.Point(0, 0)
        Me.TabProductos.Name = "TabProductos"
        Me.TabProductos.SelectedIndex = 0
        Me.TabProductos.Size = New System.Drawing.Size(1006, 610)
        Me.TabProductos.TabIndex = 2
        '
        'TbListado
        '
        Me.TbListado.Controls.Add(Me.lbl_Msg)
        Me.TbListado.Controls.Add(Me.GB_Buscar)
        Me.TbListado.Controls.Add(Me.DG_Productos)
        Me.TbListado.Location = New System.Drawing.Point(4, 29)
        Me.TbListado.Name = "TbListado"
        Me.TbListado.Padding = New System.Windows.Forms.Padding(3)
        Me.TbListado.Size = New System.Drawing.Size(998, 577)
        Me.TbListado.TabIndex = 0
        Me.TbListado.Text = "Productos"
        Me.TbListado.UseVisualStyleBackColor = True
        '
        'lbl_Msg
        '
        Me.lbl_Msg.AutoSize = True
        Me.lbl_Msg.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lbl_Msg.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Msg.Location = New System.Drawing.Point(300, 282)
        Me.lbl_Msg.Name = "lbl_Msg"
        Me.lbl_Msg.Size = New System.Drawing.Size(399, 29)
        Me.lbl_Msg.TabIndex = 4
        Me.lbl_Msg.Text = "No se han encontrado productos."
        '
        'GB_Buscar
        '
        Me.GB_Buscar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_Buscar.Controls.Add(Me.btn_Restore)
        Me.GB_Buscar.Controls.Add(Me.btn_Importar)
        Me.GB_Buscar.Controls.Add(Me.btn_Exportar)
        Me.GB_Buscar.Controls.Add(Me.btn_Restablecer)
        Me.GB_Buscar.Controls.Add(Me.btn_Buscar)
        Me.GB_Buscar.Controls.Add(Me.rb_Opcion2)
        Me.GB_Buscar.Controls.Add(Me.rb_Opcion)
        Me.GB_Buscar.Controls.Add(Me.txt_buscar)
        Me.GB_Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Buscar.Location = New System.Drawing.Point(10, 6)
        Me.GB_Buscar.Name = "GB_Buscar"
        Me.GB_Buscar.Size = New System.Drawing.Size(972, 79)
        Me.GB_Buscar.TabIndex = 3
        Me.GB_Buscar.TabStop = False
        Me.GB_Buscar.Text = "Buscar Producto"
        '
        'btn_Restore
        '
        Me.btn_Restore.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Restore.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Restore.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Restore.Location = New System.Drawing.Point(654, 24)
        Me.btn_Restore.Name = "btn_Restore"
        Me.btn_Restore.Size = New System.Drawing.Size(100, 40)
        Me.btn_Restore.TabIndex = 9
        Me.btn_Restore.Text = "Restaurar Productos"
        Me.btn_Restore.UseVisualStyleBackColor = True
        '
        'btn_Importar
        '
        Me.btn_Importar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Importar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Importar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Importar.Image = Global.SistemaCinderella.My.Resources.Recursos.Import_Excel
        Me.btn_Importar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Importar.Location = New System.Drawing.Point(548, 24)
        Me.btn_Importar.Name = "btn_Importar"
        Me.btn_Importar.Size = New System.Drawing.Size(100, 40)
        Me.btn_Importar.TabIndex = 8
        Me.btn_Importar.Text = "Importar"
        Me.btn_Importar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolProd.SetToolTip(Me.btn_Importar, "Haz click aquí para importar la información  de los productos a través de Excel")
        Me.btn_Importar.UseVisualStyleBackColor = True
        '
        'btn_Exportar
        '
        Me.btn_Exportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Exportar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Exportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Exportar.Image = Global.SistemaCinderella.My.Resources.Recursos.export_excel
        Me.btn_Exportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Exportar.Location = New System.Drawing.Point(442, 24)
        Me.btn_Exportar.Name = "btn_Exportar"
        Me.btn_Exportar.Size = New System.Drawing.Size(100, 40)
        Me.btn_Exportar.TabIndex = 7
        Me.btn_Exportar.Text = "Exportar"
        Me.btn_Exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolProd.SetToolTip(Me.btn_Exportar, "Haz click aquí para exportar la información  de los productos a Excel")
        Me.btn_Exportar.UseVisualStyleBackColor = True
        '
        'btn_Restablecer
        '
        Me.btn_Restablecer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Restablecer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Restablecer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Restablecer.Location = New System.Drawing.Point(760, 23)
        Me.btn_Restablecer.Name = "btn_Restablecer"
        Me.btn_Restablecer.Size = New System.Drawing.Size(100, 40)
        Me.btn_Restablecer.TabIndex = 6
        Me.btn_Restablecer.Text = "Restablecer Filtros"
        Me.ToolProd.SetToolTip(Me.btn_Restablecer, "Haz click aquí para restablecer los filtros y el listado de productos.")
        Me.btn_Restablecer.UseVisualStyleBackColor = True
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Buscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Buscar.Image = Global.SistemaCinderella.My.Resources.Recursos.IconoBuscar32
        Me.btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Buscar.Location = New System.Drawing.Point(866, 24)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(100, 40)
        Me.btn_Buscar.TabIndex = 5
        Me.btn_Buscar.Text = "Buscar"
        Me.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolProd.SetToolTip(Me.btn_Buscar, "Haz click aquí para buscar productos con los criterios de busqueda seleccionados." &
        "")
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'rb_Opcion2
        '
        Me.rb_Opcion2.AutoSize = True
        Me.rb_Opcion2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rb_Opcion2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rb_Opcion2.Location = New System.Drawing.Point(87, 35)
        Me.rb_Opcion2.Name = "rb_Opcion2"
        Me.rb_Opcion2.Size = New System.Drawing.Size(63, 19)
        Me.rb_Opcion2.TabIndex = 4
        Me.rb_Opcion2.Text = "Codigo"
        Me.rb_Opcion2.UseVisualStyleBackColor = True
        '
        'rb_Opcion
        '
        Me.rb_Opcion.AutoSize = True
        Me.rb_Opcion.Checked = True
        Me.rb_Opcion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rb_Opcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rb_Opcion.Location = New System.Drawing.Point(20, 35)
        Me.rb_Opcion.Name = "rb_Opcion"
        Me.rb_Opcion.Size = New System.Drawing.Size(69, 19)
        Me.rb_Opcion.TabIndex = 3
        Me.rb_Opcion.TabStop = True
        Me.rb_Opcion.Text = "Nombre"
        Me.rb_Opcion.UseVisualStyleBackColor = True
        '
        'txt_buscar
        '
        Me.txt_buscar.Location = New System.Drawing.Point(156, 33)
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(276, 21)
        Me.txt_buscar.TabIndex = 1
        '
        'DG_Productos
        '
        Me.DG_Productos.AllowUserToAddRows = False
        Me.DG_Productos.AllowUserToDeleteRows = False
        Me.DG_Productos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DG_Productos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DG_Productos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_Productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_Productos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_Producto, Me.Nombre, Me.Codigo, Me.Categoria, Me.Subcategoria, Me.Proveedor, Me.Habilitado, Me.Modificar, Me.Eliminar})
        Me.DG_Productos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DG_Productos.Location = New System.Drawing.Point(6, 91)
        Me.DG_Productos.MultiSelect = False
        Me.DG_Productos.Name = "DG_Productos"
        Me.DG_Productos.ReadOnly = True
        Me.DG_Productos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DG_Productos.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DG_Productos.RowTemplate.Height = 30
        Me.DG_Productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Productos.Size = New System.Drawing.Size(974, 466)
        Me.DG_Productos.TabIndex = 0
        '
        'id_Producto
        '
        Me.id_Producto.DataPropertyName = "id_Producto"
        Me.id_Producto.HeaderText = "ID"
        Me.id_Producto.MaxInputLength = 10
        Me.id_Producto.Name = "id_Producto"
        Me.id_Producto.ReadOnly = True
        Me.id_Producto.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.MinimumWidth = 180
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Codigo
        '
        Me.Codigo.DataPropertyName = "Codigo"
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.MinimumWidth = 30
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        Me.Codigo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Categoria
        '
        Me.Categoria.DataPropertyName = "Cat"
        Me.Categoria.HeaderText = "Categoria"
        Me.Categoria.Name = "Categoria"
        Me.Categoria.ReadOnly = True
        '
        'Subcategoria
        '
        Me.Subcategoria.DataPropertyName = "Subcat"
        Me.Subcategoria.HeaderText = "Subcategoria"
        Me.Subcategoria.MaxInputLength = 150
        Me.Subcategoria.Name = "Subcategoria"
        Me.Subcategoria.ReadOnly = True
        Me.Subcategoria.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Proveedor
        '
        Me.Proveedor.DataPropertyName = "Proveedor"
        Me.Proveedor.HeaderText = "Proveedor"
        Me.Proveedor.Name = "Proveedor"
        Me.Proveedor.ReadOnly = True
        '
        'Habilitado
        '
        Me.Habilitado.DataPropertyName = "Habilitado"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Habilitado.DefaultCellStyle = DataGridViewCellStyle2
        Me.Habilitado.HeaderText = "Habilitado"
        Me.Habilitado.MaxInputLength = 10
        Me.Habilitado.MinimumWidth = 10
        Me.Habilitado.Name = "Habilitado"
        Me.Habilitado.ReadOnly = True
        Me.Habilitado.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Modificar
        '
        Me.Modificar.HeaderText = "Modificar"
        Me.Modificar.Image = Global.SistemaCinderella.My.Resources.Recursos.Boton_Editar
        Me.Modificar.MinimumWidth = 10
        Me.Modificar.Name = "Modificar"
        Me.Modificar.ReadOnly = True
        Me.Modificar.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Modificar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Image = Global.SistemaCinderella.My.Resources.Recursos.Boton_Eliminar
        Me.Eliminar.MinimumWidth = 10
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'TbAlta
        '
        Me.TbAlta.Controls.Add(Me.GB_Alta)
        Me.TbAlta.Location = New System.Drawing.Point(4, 29)
        Me.TbAlta.Name = "TbAlta"
        Me.TbAlta.Padding = New System.Windows.Forms.Padding(3)
        Me.TbAlta.Size = New System.Drawing.Size(998, 577)
        Me.TbAlta.TabIndex = 1
        Me.TbAlta.Text = "Alta de Producto"
        Me.TbAlta.UseVisualStyleBackColor = True
        '
        'GB_Alta
        '
        Me.GB_Alta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_Alta.Controls.Add(Me.Label25)
        Me.GB_Alta.Controls.Add(Me.txt_Costo)
        Me.GB_Alta.Controls.Add(Me.Label23)
        Me.GB_Alta.Controls.Add(Me.lbl_Colores)
        Me.GB_Alta.Controls.Add(Me.chk_Colores)
        Me.GB_Alta.Controls.Add(Me.GB_Precios)
        Me.GB_Alta.Controls.Add(Me.lbl_Foto2)
        Me.GB_Alta.Controls.Add(Me.pb_foto)
        Me.GB_Alta.Controls.Add(Me.lbl_Materiales)
        Me.GB_Alta.Controls.Add(Me.Btn_Agregar)
        Me.GB_Alta.Controls.Add(Me.lbl_Aroma)
        Me.GB_Alta.Controls.Add(Me.chk_Materiales)
        Me.GB_Alta.Controls.Add(Me.chk_Aromas)
        Me.GB_Alta.Controls.Add(Me.cb_Proveedores)
        Me.GB_Alta.Controls.Add(Me.lbl_Proveedor)
        Me.GB_Alta.Controls.Add(Me.btn_Open)
        Me.GB_Alta.Controls.Add(Me.txt_Foto)
        Me.GB_Alta.Controls.Add(Me.chk_Novedad)
        Me.GB_Alta.Controls.Add(Me.lbl_Novedad)
        Me.GB_Alta.Controls.Add(Me.chk_SubirWeb)
        Me.GB_Alta.Controls.Add(Me.lbl_SubirWeb)
        Me.GB_Alta.Controls.Add(Me.lbl_Foto)
        Me.GB_Alta.Controls.Add(Me.cb_Subcategoria)
        Me.GB_Alta.Controls.Add(Me.cb_Categoria)
        Me.GB_Alta.Controls.Add(Me.lbl_Subcategoria)
        Me.GB_Alta.Controls.Add(Me.lbl_Categoria)
        Me.GB_Alta.Controls.Add(Me.txt_Descripcion)
        Me.GB_Alta.Controls.Add(Me.lbl_Descripcion)
        Me.GB_Alta.Controls.Add(Me.txt_Codigo)
        Me.GB_Alta.Controls.Add(Me.lbl_Codigo)
        Me.GB_Alta.Controls.Add(Me.txt_Tamano)
        Me.GB_Alta.Controls.Add(Me.lbl_Tamano)
        Me.GB_Alta.Controls.Add(Me.txt_Origen)
        Me.GB_Alta.Controls.Add(Me.lbl_Origen)
        Me.GB_Alta.Controls.Add(Me.chk_Habilitado)
        Me.GB_Alta.Controls.Add(Me.txt_Nombre)
        Me.GB_Alta.Controls.Add(Me.Label2)
        Me.GB_Alta.Controls.Add(Me.lbl_Nombre)
        Me.GB_Alta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Alta.Location = New System.Drawing.Point(10, 6)
        Me.GB_Alta.Name = "GB_Alta"
        Me.GB_Alta.Size = New System.Drawing.Size(980, 550)
        Me.GB_Alta.TabIndex = 0
        Me.GB_Alta.TabStop = False
        Me.GB_Alta.Text = "Formulario de Alta"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(386, 517)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(117, 13)
        Me.Label25.TabIndex = 67
        Me.Label25.Text = "(*) Campos obligatorios."
        '
        'txt_Costo
        '
        Me.txt_Costo.Location = New System.Drawing.Point(118, 171)
        Me.txt_Costo.MaxLength = 255
        Me.txt_Costo.Name = "txt_Costo"
        Me.txt_Costo.Size = New System.Drawing.Size(208, 21)
        Me.txt_Costo.TabIndex = 5
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(7, 178)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(38, 15)
        Me.Label23.TabIndex = 56
        Me.Label23.Text = "Costo"
        '
        'lbl_Colores
        '
        Me.lbl_Colores.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Colores.AutoSize = True
        Me.lbl_Colores.Location = New System.Drawing.Point(778, 263)
        Me.lbl_Colores.Name = "lbl_Colores"
        Me.lbl_Colores.Size = New System.Drawing.Size(117, 15)
        Me.lbl_Colores.TabIndex = 54
        Me.lbl_Colores.Text = "Colores Disponibles"
        '
        'chk_Colores
        '
        Me.chk_Colores.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chk_Colores.CheckOnClick = True
        Me.chk_Colores.FormattingEnabled = True
        Me.chk_Colores.Location = New System.Drawing.Point(775, 287)
        Me.chk_Colores.Name = "chk_Colores"
        Me.chk_Colores.Size = New System.Drawing.Size(187, 196)
        Me.chk_Colores.TabIndex = 23
        '
        'GB_Precios
        '
        Me.GB_Precios.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_Precios.Controls.Add(Me.lbl_Precio6)
        Me.GB_Precios.Controls.Add(Me.txt_Precio6)
        Me.GB_Precios.Controls.Add(Me.lbl_Precio5)
        Me.GB_Precios.Controls.Add(Me.txt_Precio4)
        Me.GB_Precios.Controls.Add(Me.txt_Precio5)
        Me.GB_Precios.Controls.Add(Me.lbl_Precio4)
        Me.GB_Precios.Controls.Add(Me.txt_Precio2)
        Me.GB_Precios.Controls.Add(Me.lbl_Precio1)
        Me.GB_Precios.Controls.Add(Me.txt_Precio3)
        Me.GB_Precios.Controls.Add(Me.lbl_Precio2)
        Me.GB_Precios.Controls.Add(Me.txt_Precio1)
        Me.GB_Precios.Controls.Add(Me.lbl_Precio3)
        Me.GB_Precios.Location = New System.Drawing.Point(389, 14)
        Me.GB_Precios.Name = "GB_Precios"
        Me.GB_Precios.Size = New System.Drawing.Size(289, 232)
        Me.GB_Precios.TabIndex = 52
        Me.GB_Precios.TabStop = False
        Me.GB_Precios.Text = "Listas de Precios"
        '
        'lbl_Precio6
        '
        Me.lbl_Precio6.AutoSize = True
        Me.lbl_Precio6.Location = New System.Drawing.Point(6, 197)
        Me.lbl_Precio6.Name = "lbl_Precio6"
        Me.lbl_Precio6.Size = New System.Drawing.Size(63, 15)
        Me.lbl_Precio6.TabIndex = 53
        Me.lbl_Precio6.Text = "Alternativa"
        '
        'txt_Precio6
        '
        Me.txt_Precio6.Location = New System.Drawing.Point(145, 192)
        Me.txt_Precio6.Name = "txt_Precio6"
        Me.txt_Precio6.Size = New System.Drawing.Size(125, 21)
        Me.txt_Precio6.TabIndex = 20
        '
        'lbl_Precio5
        '
        Me.lbl_Precio5.AutoSize = True
        Me.lbl_Precio5.Location = New System.Drawing.Point(6, 166)
        Me.lbl_Precio5.Name = "lbl_Precio5"
        Me.lbl_Precio5.Size = New System.Drawing.Size(60, 15)
        Me.lbl_Precio5.TabIndex = 50
        Me.lbl_Precio5.Text = "Mayorista"
        '
        'txt_Precio4
        '
        Me.txt_Precio4.Location = New System.Drawing.Point(145, 128)
        Me.txt_Precio4.Name = "txt_Precio4"
        Me.txt_Precio4.Size = New System.Drawing.Size(125, 21)
        Me.txt_Precio4.TabIndex = 18
        '
        'txt_Precio5
        '
        Me.txt_Precio5.Location = New System.Drawing.Point(145, 161)
        Me.txt_Precio5.Name = "txt_Precio5"
        Me.txt_Precio5.Size = New System.Drawing.Size(125, 21)
        Me.txt_Precio5.TabIndex = 19
        '
        'lbl_Precio4
        '
        Me.lbl_Precio4.AutoSize = True
        Me.lbl_Precio4.Location = New System.Drawing.Point(6, 135)
        Me.lbl_Precio4.Name = "lbl_Precio4"
        Me.lbl_Precio4.Size = New System.Drawing.Size(86, 15)
        Me.lbl_Precio4.TabIndex = 51
        Me.lbl_Precio4.Text = "Tarjeta Capital"
        '
        'txt_Precio2
        '
        Me.txt_Precio2.Location = New System.Drawing.Point(145, 58)
        Me.txt_Precio2.Name = "txt_Precio2"
        Me.txt_Precio2.Size = New System.Drawing.Size(125, 21)
        Me.txt_Precio2.TabIndex = 16
        '
        'lbl_Precio1
        '
        Me.lbl_Precio1.AutoSize = True
        Me.lbl_Precio1.Location = New System.Drawing.Point(6, 30)
        Me.lbl_Precio1.Name = "lbl_Precio1"
        Me.lbl_Precio1.Size = New System.Drawing.Size(80, 15)
        Me.lbl_Precio1.TabIndex = 47
        Me.lbl_Precio1.Text = "Efectivo Tigre"
        '
        'txt_Precio3
        '
        Me.txt_Precio3.Location = New System.Drawing.Point(145, 93)
        Me.txt_Precio3.Name = "txt_Precio3"
        Me.txt_Precio3.Size = New System.Drawing.Size(125, 21)
        Me.txt_Precio3.TabIndex = 17
        '
        'lbl_Precio2
        '
        Me.lbl_Precio2.AutoSize = True
        Me.lbl_Precio2.Location = New System.Drawing.Point(6, 65)
        Me.lbl_Precio2.Name = "lbl_Precio2"
        Me.lbl_Precio2.Size = New System.Drawing.Size(76, 15)
        Me.lbl_Precio2.TabIndex = 48
        Me.lbl_Precio2.Text = "Tarjeta Tigre"
        '
        'txt_Precio1
        '
        Me.txt_Precio1.Location = New System.Drawing.Point(145, 23)
        Me.txt_Precio1.Name = "txt_Precio1"
        Me.txt_Precio1.Size = New System.Drawing.Size(125, 21)
        Me.txt_Precio1.TabIndex = 15
        '
        'lbl_Precio3
        '
        Me.lbl_Precio3.AutoSize = True
        Me.lbl_Precio3.Location = New System.Drawing.Point(6, 100)
        Me.lbl_Precio3.Name = "lbl_Precio3"
        Me.lbl_Precio3.Size = New System.Drawing.Size(90, 15)
        Me.lbl_Precio3.TabIndex = 49
        Me.lbl_Precio3.Text = "Efectivo Capital"
        '
        'lbl_Foto2
        '
        Me.lbl_Foto2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Foto2.AutoSize = True
        Me.lbl_Foto2.Location = New System.Drawing.Point(757, 16)
        Me.lbl_Foto2.Name = "lbl_Foto2"
        Me.lbl_Foto2.Size = New System.Drawing.Size(103, 15)
        Me.lbl_Foto2.TabIndex = 41
        Me.lbl_Foto2.Text = "Foto del Producto"
        '
        'pb_foto
        '
        Me.pb_foto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pb_foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pb_foto.Image = Global.SistemaCinderella.My.Resources.Recursos.Sinfoto
        Me.pb_foto.InitialImage = Nothing
        Me.pb_foto.Location = New System.Drawing.Point(727, 35)
        Me.pb_foto.Name = "pb_foto"
        Me.pb_foto.Size = New System.Drawing.Size(150, 150)
        Me.pb_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_foto.TabIndex = 40
        Me.pb_foto.TabStop = False
        '
        'lbl_Materiales
        '
        Me.lbl_Materiales.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Materiales.AutoSize = True
        Me.lbl_Materiales.Location = New System.Drawing.Point(386, 263)
        Me.lbl_Materiales.Name = "lbl_Materiales"
        Me.lbl_Materiales.Size = New System.Drawing.Size(133, 15)
        Me.lbl_Materiales.TabIndex = 39
        Me.lbl_Materiales.Text = "Materiales Disponibles"
        '
        'Btn_Agregar
        '
        Me.Btn_Agregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Agregar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Agregar.Image = Global.SistemaCinderella.My.Resources.Recursos.Agregar_24
        Me.Btn_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Agregar.Location = New System.Drawing.Point(862, 502)
        Me.Btn_Agregar.Name = "Btn_Agregar"
        Me.Btn_Agregar.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Agregar.TabIndex = 24
        Me.Btn_Agregar.Text = "Agregar"
        Me.Btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolProd.SetToolTip(Me.Btn_Agregar, "Agrega el producto al sistema.")
        Me.Btn_Agregar.UseVisualStyleBackColor = False
        '
        'lbl_Aroma
        '
        Me.lbl_Aroma.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Aroma.AutoSize = True
        Me.lbl_Aroma.Location = New System.Drawing.Point(579, 263)
        Me.lbl_Aroma.Name = "lbl_Aroma"
        Me.lbl_Aroma.Size = New System.Drawing.Size(117, 15)
        Me.lbl_Aroma.TabIndex = 38
        Me.lbl_Aroma.Text = "Aromas Disponibles"
        '
        'chk_Materiales
        '
        Me.chk_Materiales.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chk_Materiales.CheckOnClick = True
        Me.chk_Materiales.FormattingEnabled = True
        Me.chk_Materiales.Location = New System.Drawing.Point(389, 287)
        Me.chk_Materiales.Name = "chk_Materiales"
        Me.chk_Materiales.Size = New System.Drawing.Size(187, 196)
        Me.chk_Materiales.TabIndex = 21
        '
        'chk_Aromas
        '
        Me.chk_Aromas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chk_Aromas.CheckOnClick = True
        Me.chk_Aromas.FormattingEnabled = True
        Me.chk_Aromas.Location = New System.Drawing.Point(582, 287)
        Me.chk_Aromas.Name = "chk_Aromas"
        Me.chk_Aromas.Size = New System.Drawing.Size(187, 196)
        Me.chk_Aromas.TabIndex = 22
        '
        'cb_Proveedores
        '
        Me.cb_Proveedores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_Proveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Proveedores.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cb_Proveedores.FormattingEnabled = True
        Me.cb_Proveedores.Location = New System.Drawing.Point(121, 310)
        Me.cb_Proveedores.Name = "cb_Proveedores"
        Me.cb_Proveedores.Size = New System.Drawing.Size(205, 23)
        Me.cb_Proveedores.TabIndex = 10
        '
        'lbl_Proveedor
        '
        Me.lbl_Proveedor.AutoSize = True
        Me.lbl_Proveedor.Location = New System.Drawing.Point(7, 313)
        Me.lbl_Proveedor.Name = "lbl_Proveedor"
        Me.lbl_Proveedor.Size = New System.Drawing.Size(79, 15)
        Me.lbl_Proveedor.TabIndex = 35
        Me.lbl_Proveedor.Text = "Proveedor (*)"
        '
        'btn_Open
        '
        Me.btn_Open.Location = New System.Drawing.Point(333, 206)
        Me.btn_Open.Name = "btn_Open"
        Me.btn_Open.Size = New System.Drawing.Size(31, 23)
        Me.btn_Open.TabIndex = 7
        Me.btn_Open.Text = ". . ."
        Me.btn_Open.UseVisualStyleBackColor = True
        '
        'txt_Foto
        '
        Me.txt_Foto.Location = New System.Drawing.Point(118, 208)
        Me.txt_Foto.Name = "txt_Foto"
        Me.txt_Foto.Size = New System.Drawing.Size(209, 21)
        Me.txt_Foto.TabIndex = 6
        '
        'chk_Novedad
        '
        Me.chk_Novedad.AutoSize = True
        Me.chk_Novedad.Checked = True
        Me.chk_Novedad.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Novedad.Location = New System.Drawing.Point(121, 517)
        Me.chk_Novedad.Name = "chk_Novedad"
        Me.chk_Novedad.Size = New System.Drawing.Size(15, 14)
        Me.chk_Novedad.TabIndex = 14
        Me.chk_Novedad.UseVisualStyleBackColor = True
        '
        'lbl_Novedad
        '
        Me.lbl_Novedad.AutoSize = True
        Me.lbl_Novedad.Location = New System.Drawing.Point(7, 517)
        Me.lbl_Novedad.Name = "lbl_Novedad"
        Me.lbl_Novedad.Size = New System.Drawing.Size(56, 15)
        Me.lbl_Novedad.TabIndex = 30
        Me.lbl_Novedad.Text = "Novedad"
        '
        'chk_SubirWeb
        '
        Me.chk_SubirWeb.AutoSize = True
        Me.chk_SubirWeb.Checked = True
        Me.chk_SubirWeb.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_SubirWeb.Location = New System.Drawing.Point(121, 492)
        Me.chk_SubirWeb.Name = "chk_SubirWeb"
        Me.chk_SubirWeb.Size = New System.Drawing.Size(15, 14)
        Me.chk_SubirWeb.TabIndex = 13
        Me.chk_SubirWeb.UseVisualStyleBackColor = True
        '
        'lbl_SubirWeb
        '
        Me.lbl_SubirWeb.AutoSize = True
        Me.lbl_SubirWeb.Location = New System.Drawing.Point(7, 492)
        Me.lbl_SubirWeb.Name = "lbl_SubirWeb"
        Me.lbl_SubirWeb.Size = New System.Drawing.Size(87, 15)
        Me.lbl_SubirWeb.TabIndex = 28
        Me.lbl_SubirWeb.Text = "Subir a la Web"
        '
        'lbl_Foto
        '
        Me.lbl_Foto.AutoSize = True
        Me.lbl_Foto.Location = New System.Drawing.Point(7, 211)
        Me.lbl_Foto.Name = "lbl_Foto"
        Me.lbl_Foto.Size = New System.Drawing.Size(31, 15)
        Me.lbl_Foto.TabIndex = 27
        Me.lbl_Foto.Text = "Foto"
        '
        'cb_Subcategoria
        '
        Me.cb_Subcategoria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_Subcategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Subcategoria.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cb_Subcategoria.FormattingEnabled = True
        Me.cb_Subcategoria.Location = New System.Drawing.Point(121, 274)
        Me.cb_Subcategoria.Name = "cb_Subcategoria"
        Me.cb_Subcategoria.Size = New System.Drawing.Size(206, 23)
        Me.cb_Subcategoria.TabIndex = 9
        '
        'cb_Categoria
        '
        Me.cb_Categoria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_Categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Categoria.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cb_Categoria.FormattingEnabled = True
        Me.cb_Categoria.Location = New System.Drawing.Point(121, 243)
        Me.cb_Categoria.Name = "cb_Categoria"
        Me.cb_Categoria.Size = New System.Drawing.Size(206, 23)
        Me.cb_Categoria.TabIndex = 8
        '
        'lbl_Subcategoria
        '
        Me.lbl_Subcategoria.AutoSize = True
        Me.lbl_Subcategoria.Location = New System.Drawing.Point(7, 277)
        Me.lbl_Subcategoria.Name = "lbl_Subcategoria"
        Me.lbl_Subcategoria.Size = New System.Drawing.Size(96, 15)
        Me.lbl_Subcategoria.TabIndex = 22
        Me.lbl_Subcategoria.Text = "Subcategoría (*)"
        '
        'lbl_Categoria
        '
        Me.lbl_Categoria.AutoSize = True
        Me.lbl_Categoria.Location = New System.Drawing.Point(7, 243)
        Me.lbl_Categoria.Name = "lbl_Categoria"
        Me.lbl_Categoria.Size = New System.Drawing.Size(76, 15)
        Me.lbl_Categoria.TabIndex = 21
        Me.lbl_Categoria.Text = "Categoría (*)"
        '
        'txt_Descripcion
        '
        Me.txt_Descripcion.Location = New System.Drawing.Point(120, 345)
        Me.txt_Descripcion.MaxLength = 255
        Me.txt_Descripcion.Multiline = True
        Me.txt_Descripcion.Name = "txt_Descripcion"
        Me.txt_Descripcion.Size = New System.Drawing.Size(207, 116)
        Me.txt_Descripcion.TabIndex = 11
        '
        'lbl_Descripcion
        '
        Me.lbl_Descripcion.AutoSize = True
        Me.lbl_Descripcion.Location = New System.Drawing.Point(7, 345)
        Me.lbl_Descripcion.Name = "lbl_Descripcion"
        Me.lbl_Descripcion.Size = New System.Drawing.Size(72, 15)
        Me.lbl_Descripcion.TabIndex = 19
        Me.lbl_Descripcion.Text = "Descripcion"
        '
        'txt_Codigo
        '
        Me.txt_Codigo.Location = New System.Drawing.Point(119, 140)
        Me.txt_Codigo.MaxLength = 255
        Me.txt_Codigo.Name = "txt_Codigo"
        Me.txt_Codigo.Size = New System.Drawing.Size(208, 21)
        Me.txt_Codigo.TabIndex = 4
        '
        'lbl_Codigo
        '
        Me.lbl_Codigo.AutoSize = True
        Me.lbl_Codigo.Location = New System.Drawing.Point(7, 147)
        Me.lbl_Codigo.Name = "lbl_Codigo"
        Me.lbl_Codigo.Size = New System.Drawing.Size(62, 15)
        Me.lbl_Codigo.TabIndex = 17
        Me.lbl_Codigo.Text = "Código (*)"
        '
        'txt_Tamano
        '
        Me.txt_Tamano.Location = New System.Drawing.Point(118, 105)
        Me.txt_Tamano.MaxLength = 255
        Me.txt_Tamano.Name = "txt_Tamano"
        Me.txt_Tamano.Size = New System.Drawing.Size(209, 21)
        Me.txt_Tamano.TabIndex = 3
        '
        'lbl_Tamano
        '
        Me.lbl_Tamano.AutoSize = True
        Me.lbl_Tamano.Location = New System.Drawing.Point(7, 112)
        Me.lbl_Tamano.Name = "lbl_Tamano"
        Me.lbl_Tamano.Size = New System.Drawing.Size(53, 15)
        Me.lbl_Tamano.TabIndex = 15
        Me.lbl_Tamano.Text = "Tamaño"
        '
        'txt_Origen
        '
        Me.txt_Origen.Location = New System.Drawing.Point(119, 70)
        Me.txt_Origen.MaxLength = 255
        Me.txt_Origen.Name = "txt_Origen"
        Me.txt_Origen.Size = New System.Drawing.Size(208, 21)
        Me.txt_Origen.TabIndex = 2
        '
        'lbl_Origen
        '
        Me.lbl_Origen.AutoSize = True
        Me.lbl_Origen.Location = New System.Drawing.Point(7, 77)
        Me.lbl_Origen.Name = "lbl_Origen"
        Me.lbl_Origen.Size = New System.Drawing.Size(44, 15)
        Me.lbl_Origen.TabIndex = 7
        Me.lbl_Origen.Text = "Origen"
        '
        'chk_Habilitado
        '
        Me.chk_Habilitado.AutoSize = True
        Me.chk_Habilitado.Checked = True
        Me.chk_Habilitado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Habilitado.Location = New System.Drawing.Point(121, 467)
        Me.chk_Habilitado.Name = "chk_Habilitado"
        Me.chk_Habilitado.Size = New System.Drawing.Size(15, 14)
        Me.chk_Habilitado.TabIndex = 12
        Me.chk_Habilitado.UseVisualStyleBackColor = True
        '
        'txt_Nombre
        '
        Me.txt_Nombre.Location = New System.Drawing.Point(119, 35)
        Me.txt_Nombre.MaxLength = 255
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.Size = New System.Drawing.Size(208, 21)
        Me.txt_Nombre.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 467)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Habilitado"
        '
        'lbl_Nombre
        '
        Me.lbl_Nombre.AutoSize = True
        Me.lbl_Nombre.Location = New System.Drawing.Point(7, 40)
        Me.lbl_Nombre.Name = "lbl_Nombre"
        Me.lbl_Nombre.Size = New System.Drawing.Size(68, 15)
        Me.lbl_Nombre.TabIndex = 1
        Me.lbl_Nombre.Text = "Nombre (*)"
        '
        'TbMod
        '
        Me.TbMod.Controls.Add(Me.GB_Modificacion)
        Me.TbMod.Location = New System.Drawing.Point(4, 29)
        Me.TbMod.Name = "TbMod"
        Me.TbMod.Size = New System.Drawing.Size(998, 577)
        Me.TbMod.TabIndex = 2
        Me.TbMod.Text = "Modificación de Producto"
        Me.TbMod.UseVisualStyleBackColor = True
        '
        'GB_Modificacion
        '
        Me.GB_Modificacion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_Modificacion.Controls.Add(Me.Btn_Cancelar)
        Me.GB_Modificacion.Controls.Add(Me.Label26)
        Me.GB_Modificacion.Controls.Add(Me.txt_Costo_mod)
        Me.GB_Modificacion.Controls.Add(Me.Label24)
        Me.GB_Modificacion.Controls.Add(Me.Ck_EliminarFoto)
        Me.GB_Modificacion.Controls.Add(Me.Btn_Eliminar)
        Me.GB_Modificacion.Controls.Add(Me.lbl_CodigoBarra)
        Me.GB_Modificacion.Controls.Add(Me.pb_CodigoBarra)
        Me.GB_Modificacion.Controls.Add(Me.lbl_Colores_mod)
        Me.GB_Modificacion.Controls.Add(Me.chk_Colores_mod)
        Me.GB_Modificacion.Controls.Add(Me.Gb_Precios_mod)
        Me.GB_Modificacion.Controls.Add(Me.chk_Novedad_mod)
        Me.GB_Modificacion.Controls.Add(Me.Label5)
        Me.GB_Modificacion.Controls.Add(Me.chk_SubirWeb_mod)
        Me.GB_Modificacion.Controls.Add(Me.Label6)
        Me.GB_Modificacion.Controls.Add(Me.chk_Habilitado_mod)
        Me.GB_Modificacion.Controls.Add(Me.Label14)
        Me.GB_Modificacion.Controls.Add(Me.Label16)
        Me.GB_Modificacion.Controls.Add(Me.pb_foto_mod)
        Me.GB_Modificacion.Controls.Add(Me.Label1)
        Me.GB_Modificacion.Controls.Add(Me.btn_Modificar)
        Me.GB_Modificacion.Controls.Add(Me.Label3)
        Me.GB_Modificacion.Controls.Add(Me.chk_Materiales_mod)
        Me.GB_Modificacion.Controls.Add(Me.chk_Aromas_mod)
        Me.GB_Modificacion.Controls.Add(Me.cb_Proveedor_mod)
        Me.GB_Modificacion.Controls.Add(Me.Label4)
        Me.GB_Modificacion.Controls.Add(Me.btn_Open_mod)
        Me.GB_Modificacion.Controls.Add(Me.txt_Foto_mod)
        Me.GB_Modificacion.Controls.Add(Me.Label7)
        Me.GB_Modificacion.Controls.Add(Me.cb_Subcategoria_mod)
        Me.GB_Modificacion.Controls.Add(Me.cb_Categoria_mod)
        Me.GB_Modificacion.Controls.Add(Me.Label8)
        Me.GB_Modificacion.Controls.Add(Me.Label9)
        Me.GB_Modificacion.Controls.Add(Me.txt_Descripcion_mod)
        Me.GB_Modificacion.Controls.Add(Me.Label10)
        Me.GB_Modificacion.Controls.Add(Me.txt_Codigo_mod)
        Me.GB_Modificacion.Controls.Add(Me.Label11)
        Me.GB_Modificacion.Controls.Add(Me.txt_Tamano_mod)
        Me.GB_Modificacion.Controls.Add(Me.Label12)
        Me.GB_Modificacion.Controls.Add(Me.txt_Origen_mod)
        Me.GB_Modificacion.Controls.Add(Me.Label13)
        Me.GB_Modificacion.Controls.Add(Me.txt_Nombre_mod)
        Me.GB_Modificacion.Controls.Add(Me.Label15)
        Me.GB_Modificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Modificacion.Location = New System.Drawing.Point(10, 6)
        Me.GB_Modificacion.Name = "GB_Modificacion"
        Me.GB_Modificacion.Size = New System.Drawing.Size(980, 550)
        Me.GB_Modificacion.TabIndex = 1
        Me.GB_Modificacion.TabStop = False
        Me.GB_Modificacion.Text = "Formulario de Modificación"
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Cancelar.Image = Global.SistemaCinderella.My.Resources.Recursos.desconectado_32
        Me.Btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Cancelar.Location = New System.Drawing.Point(650, 504)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Cancelar.TabIndex = 87
        Me.Btn_Cancelar.Text = "Cancelar"
        Me.Btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolProd.SetToolTip(Me.Btn_Cancelar, "Descarta los cambios y vuelve al listado de productos")
        Me.Btn_Cancelar.UseVisualStyleBackColor = True
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(386, 514)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(117, 13)
        Me.Label26.TabIndex = 86
        Me.Label26.Text = "(*) Campos obligatorios."
        '
        'txt_Costo_mod
        '
        Me.txt_Costo_mod.Location = New System.Drawing.Point(118, 171)
        Me.txt_Costo_mod.MaxLength = 255
        Me.txt_Costo_mod.Name = "txt_Costo_mod"
        Me.txt_Costo_mod.Size = New System.Drawing.Size(208, 21)
        Me.txt_Costo_mod.TabIndex = 5
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(7, 178)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(38, 15)
        Me.Label24.TabIndex = 85
        Me.Label24.Text = "Costo"
        '
        'Ck_EliminarFoto
        '
        Me.Ck_EliminarFoto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Ck_EliminarFoto.AutoSize = True
        Me.Ck_EliminarFoto.Location = New System.Drawing.Point(802, 200)
        Me.Ck_EliminarFoto.Name = "Ck_EliminarFoto"
        Me.Ck_EliminarFoto.Size = New System.Drawing.Size(99, 19)
        Me.Ck_EliminarFoto.TabIndex = 83
        Me.Ck_EliminarFoto.Text = "Eliminar Foto"
        Me.Ck_EliminarFoto.UseVisualStyleBackColor = True
        '
        'Btn_Eliminar
        '
        Me.Btn_Eliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Eliminar.Image = Global.SistemaCinderella.My.Resources.Recursos.Limpiar_32
        Me.Btn_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Eliminar.Location = New System.Drawing.Point(756, 504)
        Me.Btn_Eliminar.Name = "Btn_Eliminar"
        Me.Btn_Eliminar.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Eliminar.TabIndex = 24
        Me.Btn_Eliminar.Text = "Eliminar"
        Me.Btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolProd.SetToolTip(Me.Btn_Eliminar, "Elimina el producto del sistema.")
        Me.Btn_Eliminar.UseVisualStyleBackColor = True
        '
        'lbl_CodigoBarra
        '
        Me.lbl_CodigoBarra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_CodigoBarra.AutoSize = True
        Me.lbl_CodigoBarra.Location = New System.Drawing.Point(675, 24)
        Me.lbl_CodigoBarra.Name = "lbl_CodigoBarra"
        Me.lbl_CodigoBarra.Size = New System.Drawing.Size(102, 15)
        Me.lbl_CodigoBarra.TabIndex = 82
        Me.lbl_CodigoBarra.Text = "Código de Barras"
        '
        'pb_CodigoBarra
        '
        Me.pb_CodigoBarra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pb_CodigoBarra.BackColor = System.Drawing.Color.White
        Me.pb_CodigoBarra.Location = New System.Drawing.Point(657, 43)
        Me.pb_CodigoBarra.Name = "pb_CodigoBarra"
        Me.pb_CodigoBarra.Size = New System.Drawing.Size(127, 96)
        Me.pb_CodigoBarra.TabIndex = 81
        Me.pb_CodigoBarra.TabStop = False
        '
        'lbl_Colores_mod
        '
        Me.lbl_Colores_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Colores_mod.AutoSize = True
        Me.lbl_Colores_mod.Location = New System.Drawing.Point(772, 255)
        Me.lbl_Colores_mod.Name = "lbl_Colores_mod"
        Me.lbl_Colores_mod.Size = New System.Drawing.Size(117, 15)
        Me.lbl_Colores_mod.TabIndex = 80
        Me.lbl_Colores_mod.Text = "Colores Disponibles"
        '
        'chk_Colores_mod
        '
        Me.chk_Colores_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chk_Colores_mod.CheckOnClick = True
        Me.chk_Colores_mod.FormattingEnabled = True
        Me.chk_Colores_mod.Location = New System.Drawing.Point(775, 279)
        Me.chk_Colores_mod.Name = "chk_Colores_mod"
        Me.chk_Colores_mod.Size = New System.Drawing.Size(187, 196)
        Me.chk_Colores_mod.TabIndex = 23
        '
        'Gb_Precios_mod
        '
        Me.Gb_Precios_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gb_Precios_mod.Controls.Add(Me.Label22)
        Me.Gb_Precios_mod.Controls.Add(Me.txt_Precio6_mod)
        Me.Gb_Precios_mod.Controls.Add(Me.Label17)
        Me.Gb_Precios_mod.Controls.Add(Me.txt_Precio4_mod)
        Me.Gb_Precios_mod.Controls.Add(Me.txt_Precio5_mod)
        Me.Gb_Precios_mod.Controls.Add(Me.Label18)
        Me.Gb_Precios_mod.Controls.Add(Me.txt_Precio2_mod)
        Me.Gb_Precios_mod.Controls.Add(Me.Label19)
        Me.Gb_Precios_mod.Controls.Add(Me.txt_Precio3_mod)
        Me.Gb_Precios_mod.Controls.Add(Me.Label20)
        Me.Gb_Precios_mod.Controls.Add(Me.txt_Precio1_mod)
        Me.Gb_Precios_mod.Controls.Add(Me.Label21)
        Me.Gb_Precios_mod.Location = New System.Drawing.Point(389, 14)
        Me.Gb_Precios_mod.Name = "Gb_Precios_mod"
        Me.Gb_Precios_mod.Size = New System.Drawing.Size(262, 221)
        Me.Gb_Precios_mod.TabIndex = 78
        Me.Gb_Precios_mod.TabStop = False
        Me.Gb_Precios_mod.Text = "Listas de Precios"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(6, 194)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(63, 15)
        Me.Label22.TabIndex = 53
        Me.Label22.Text = "Alternativa"
        '
        'txt_Precio6_mod
        '
        Me.txt_Precio6_mod.Location = New System.Drawing.Point(121, 189)
        Me.txt_Precio6_mod.Name = "txt_Precio6_mod"
        Me.txt_Precio6_mod.Size = New System.Drawing.Size(135, 21)
        Me.txt_Precio6_mod.TabIndex = 20
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 166)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(60, 15)
        Me.Label17.TabIndex = 50
        Me.Label17.Text = "Mayorista"
        '
        'txt_Precio4_mod
        '
        Me.txt_Precio4_mod.Location = New System.Drawing.Point(121, 128)
        Me.txt_Precio4_mod.Name = "txt_Precio4_mod"
        Me.txt_Precio4_mod.Size = New System.Drawing.Size(135, 21)
        Me.txt_Precio4_mod.TabIndex = 18
        '
        'txt_Precio5_mod
        '
        Me.txt_Precio5_mod.Location = New System.Drawing.Point(121, 161)
        Me.txt_Precio5_mod.Name = "txt_Precio5_mod"
        Me.txt_Precio5_mod.Size = New System.Drawing.Size(135, 21)
        Me.txt_Precio5_mod.TabIndex = 19
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 135)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(86, 15)
        Me.Label18.TabIndex = 51
        Me.Label18.Text = "Tarjeta Capital"
        '
        'txt_Precio2_mod
        '
        Me.txt_Precio2_mod.Location = New System.Drawing.Point(121, 58)
        Me.txt_Precio2_mod.Name = "txt_Precio2_mod"
        Me.txt_Precio2_mod.Size = New System.Drawing.Size(135, 21)
        Me.txt_Precio2_mod.TabIndex = 16
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(6, 30)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(80, 15)
        Me.Label19.TabIndex = 47
        Me.Label19.Text = "Efectivo Tigre"
        '
        'txt_Precio3_mod
        '
        Me.txt_Precio3_mod.Location = New System.Drawing.Point(121, 93)
        Me.txt_Precio3_mod.Name = "txt_Precio3_mod"
        Me.txt_Precio3_mod.Size = New System.Drawing.Size(135, 21)
        Me.txt_Precio3_mod.TabIndex = 17
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 65)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(76, 15)
        Me.Label20.TabIndex = 48
        Me.Label20.Text = "Tarjeta Tigre"
        '
        'txt_Precio1_mod
        '
        Me.txt_Precio1_mod.Location = New System.Drawing.Point(121, 23)
        Me.txt_Precio1_mod.Name = "txt_Precio1_mod"
        Me.txt_Precio1_mod.Size = New System.Drawing.Size(135, 21)
        Me.txt_Precio1_mod.TabIndex = 15
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(6, 100)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(90, 15)
        Me.Label21.TabIndex = 49
        Me.Label21.Text = "Efectivo Capital"
        '
        'chk_Novedad_mod
        '
        Me.chk_Novedad_mod.AutoSize = True
        Me.chk_Novedad_mod.Checked = True
        Me.chk_Novedad_mod.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Novedad_mod.Location = New System.Drawing.Point(121, 517)
        Me.chk_Novedad_mod.Name = "chk_Novedad_mod"
        Me.chk_Novedad_mod.Size = New System.Drawing.Size(15, 14)
        Me.chk_Novedad_mod.TabIndex = 14
        Me.chk_Novedad_mod.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 517)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 15)
        Me.Label5.TabIndex = 77
        Me.Label5.Text = "Novedad"
        '
        'chk_SubirWeb_mod
        '
        Me.chk_SubirWeb_mod.AutoSize = True
        Me.chk_SubirWeb_mod.Checked = True
        Me.chk_SubirWeb_mod.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_SubirWeb_mod.Location = New System.Drawing.Point(121, 492)
        Me.chk_SubirWeb_mod.Name = "chk_SubirWeb_mod"
        Me.chk_SubirWeb_mod.Size = New System.Drawing.Size(15, 14)
        Me.chk_SubirWeb_mod.TabIndex = 13
        Me.chk_SubirWeb_mod.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 492)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 15)
        Me.Label6.TabIndex = 76
        Me.Label6.Text = "Subir a la Web"
        '
        'chk_Habilitado_mod
        '
        Me.chk_Habilitado_mod.AutoSize = True
        Me.chk_Habilitado_mod.Checked = True
        Me.chk_Habilitado_mod.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Habilitado_mod.Location = New System.Drawing.Point(121, 467)
        Me.chk_Habilitado_mod.Name = "chk_Habilitado_mod"
        Me.chk_Habilitado_mod.Size = New System.Drawing.Size(15, 14)
        Me.chk_Habilitado_mod.TabIndex = 12
        Me.chk_Habilitado_mod.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(7, 467)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 15)
        Me.Label14.TabIndex = 72
        Me.Label14.Text = "Habilitado"
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(840, 24)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(103, 15)
        Me.Label16.TabIndex = 71
        Me.Label16.Text = "Foto del Producto"
        '
        'pb_foto_mod
        '
        Me.pb_foto_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pb_foto_mod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pb_foto_mod.Image = Global.SistemaCinderella.My.Resources.Recursos.Sinfoto
        Me.pb_foto_mod.InitialImage = Nothing
        Me.pb_foto_mod.Location = New System.Drawing.Point(812, 43)
        Me.pb_foto_mod.Name = "pb_foto_mod"
        Me.pb_foto_mod.Size = New System.Drawing.Size(150, 150)
        Me.pb_foto_mod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_foto_mod.TabIndex = 70
        Me.pb_foto_mod.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(386, 255)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 15)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "Materiales Disponibles"
        '
        'btn_Modificar
        '
        Me.btn_Modificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Modificar.BackColor = System.Drawing.Color.Transparent
        Me.btn_Modificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Modificar.Image = Global.SistemaCinderella.My.Resources.Recursos.Editar_24
        Me.btn_Modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Modificar.Location = New System.Drawing.Point(862, 503)
        Me.btn_Modificar.Name = "btn_Modificar"
        Me.btn_Modificar.Size = New System.Drawing.Size(100, 40)
        Me.btn_Modificar.TabIndex = 25
        Me.btn_Modificar.Text = "Modificar"
        Me.btn_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolProd.SetToolTip(Me.btn_Modificar, "Modifica el producto en el sistema.")
        Me.btn_Modificar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(579, 255)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 15)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "Aromas Disponibles"
        '
        'chk_Materiales_mod
        '
        Me.chk_Materiales_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chk_Materiales_mod.CheckOnClick = True
        Me.chk_Materiales_mod.FormattingEnabled = True
        Me.chk_Materiales_mod.Location = New System.Drawing.Point(389, 279)
        Me.chk_Materiales_mod.Name = "chk_Materiales_mod"
        Me.chk_Materiales_mod.Size = New System.Drawing.Size(187, 196)
        Me.chk_Materiales_mod.TabIndex = 21
        '
        'chk_Aromas_mod
        '
        Me.chk_Aromas_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chk_Aromas_mod.CheckOnClick = True
        Me.chk_Aromas_mod.FormattingEnabled = True
        Me.chk_Aromas_mod.Location = New System.Drawing.Point(582, 279)
        Me.chk_Aromas_mod.Name = "chk_Aromas_mod"
        Me.chk_Aromas_mod.Size = New System.Drawing.Size(187, 196)
        Me.chk_Aromas_mod.TabIndex = 22
        '
        'cb_Proveedor_mod
        '
        Me.cb_Proveedor_mod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_Proveedor_mod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Proveedor_mod.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cb_Proveedor_mod.FormattingEnabled = True
        Me.cb_Proveedor_mod.Location = New System.Drawing.Point(121, 310)
        Me.cb_Proveedor_mod.Name = "cb_Proveedor_mod"
        Me.cb_Proveedor_mod.Size = New System.Drawing.Size(205, 23)
        Me.cb_Proveedor_mod.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 313)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 15)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "Proveedor (*)"
        '
        'btn_Open_mod
        '
        Me.btn_Open_mod.Location = New System.Drawing.Point(333, 207)
        Me.btn_Open_mod.Name = "btn_Open_mod"
        Me.btn_Open_mod.Size = New System.Drawing.Size(31, 23)
        Me.btn_Open_mod.TabIndex = 7
        Me.btn_Open_mod.Text = ". . ."
        Me.btn_Open_mod.UseVisualStyleBackColor = True
        '
        'txt_Foto_mod
        '
        Me.txt_Foto_mod.Location = New System.Drawing.Point(118, 208)
        Me.txt_Foto_mod.Name = "txt_Foto_mod"
        Me.txt_Foto_mod.Size = New System.Drawing.Size(209, 21)
        Me.txt_Foto_mod.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 211)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 15)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "Foto"
        '
        'cb_Subcategoria_mod
        '
        Me.cb_Subcategoria_mod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_Subcategoria_mod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Subcategoria_mod.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cb_Subcategoria_mod.FormattingEnabled = True
        Me.cb_Subcategoria_mod.Location = New System.Drawing.Point(121, 274)
        Me.cb_Subcategoria_mod.Name = "cb_Subcategoria_mod"
        Me.cb_Subcategoria_mod.Size = New System.Drawing.Size(206, 23)
        Me.cb_Subcategoria_mod.TabIndex = 9
        '
        'cb_Categoria_mod
        '
        Me.cb_Categoria_mod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_Categoria_mod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Categoria_mod.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cb_Categoria_mod.FormattingEnabled = True
        Me.cb_Categoria_mod.Location = New System.Drawing.Point(121, 243)
        Me.cb_Categoria_mod.Name = "cb_Categoria_mod"
        Me.cb_Categoria_mod.Size = New System.Drawing.Size(206, 23)
        Me.cb_Categoria_mod.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 277)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 15)
        Me.Label8.TabIndex = 62
        Me.Label8.Text = "Subcategoría (*)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 243)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 15)
        Me.Label9.TabIndex = 61
        Me.Label9.Text = "Categoría (*)"
        '
        'txt_Descripcion_mod
        '
        Me.txt_Descripcion_mod.Location = New System.Drawing.Point(120, 345)
        Me.txt_Descripcion_mod.MaxLength = 255
        Me.txt_Descripcion_mod.Multiline = True
        Me.txt_Descripcion_mod.Name = "txt_Descripcion_mod"
        Me.txt_Descripcion_mod.Size = New System.Drawing.Size(207, 104)
        Me.txt_Descripcion_mod.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 345)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 15)
        Me.Label10.TabIndex = 60
        Me.Label10.Text = "Descripcion"
        '
        'txt_Codigo_mod
        '
        Me.txt_Codigo_mod.Location = New System.Drawing.Point(119, 140)
        Me.txt_Codigo_mod.MaxLength = 255
        Me.txt_Codigo_mod.Name = "txt_Codigo_mod"
        Me.txt_Codigo_mod.Size = New System.Drawing.Size(208, 21)
        Me.txt_Codigo_mod.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 147)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 15)
        Me.Label11.TabIndex = 59
        Me.Label11.Text = "Código (*)"
        '
        'txt_Tamano_mod
        '
        Me.txt_Tamano_mod.Location = New System.Drawing.Point(118, 105)
        Me.txt_Tamano_mod.MaxLength = 255
        Me.txt_Tamano_mod.Name = "txt_Tamano_mod"
        Me.txt_Tamano_mod.Size = New System.Drawing.Size(209, 21)
        Me.txt_Tamano_mod.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 112)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 15)
        Me.Label12.TabIndex = 58
        Me.Label12.Text = "Tamaño"
        '
        'txt_Origen_mod
        '
        Me.txt_Origen_mod.Location = New System.Drawing.Point(119, 70)
        Me.txt_Origen_mod.MaxLength = 255
        Me.txt_Origen_mod.Name = "txt_Origen_mod"
        Me.txt_Origen_mod.Size = New System.Drawing.Size(208, 21)
        Me.txt_Origen_mod.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(7, 77)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(44, 15)
        Me.Label13.TabIndex = 49
        Me.Label13.Text = "Origen"
        '
        'txt_Nombre_mod
        '
        Me.txt_Nombre_mod.Location = New System.Drawing.Point(119, 35)
        Me.txt_Nombre_mod.MaxLength = 255
        Me.txt_Nombre_mod.Name = "txt_Nombre_mod"
        Me.txt_Nombre_mod.Size = New System.Drawing.Size(208, 21)
        Me.txt_Nombre_mod.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(7, 40)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(68, 15)
        Me.Label15.TabIndex = 41
        Me.Label15.Text = "Nombre (*)"
        '
        'Cargar
        '
        Me.Cargar.FileName = "Cargar"
        '
        'ErrorProductos
        '
        Me.ErrorProductos.BlinkRate = 200
        Me.ErrorProductos.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink
        Me.ErrorProductos.ContainerControl = Me
        '
        'ToolProd
        '
        Me.ToolProd.IsBalloon = True
        Me.ToolProd.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolProd.ToolTipTitle = "Ayuda"
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog"
        '
        'frmProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 610)
        Me.Controls.Add(Me.TabProductos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administración de Productos"
        Me.TabProductos.ResumeLayout(False)
        Me.TbListado.ResumeLayout(False)
        Me.TbListado.PerformLayout()
        Me.GB_Buscar.ResumeLayout(False)
        Me.GB_Buscar.PerformLayout()
        CType(Me.DG_Productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TbAlta.ResumeLayout(False)
        Me.GB_Alta.ResumeLayout(False)
        Me.GB_Alta.PerformLayout()
        Me.GB_Precios.ResumeLayout(False)
        Me.GB_Precios.PerformLayout()
        CType(Me.pb_foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TbMod.ResumeLayout(False)
        Me.GB_Modificacion.ResumeLayout(False)
        Me.GB_Modificacion.PerformLayout()
        CType(Me.pb_CodigoBarra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gb_Precios_mod.ResumeLayout(False)
        Me.Gb_Precios_mod.PerformLayout()
        CType(Me.pb_foto_mod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabProductos As System.Windows.Forms.TabControl
    Friend WithEvents TbListado As System.Windows.Forms.TabPage
    Friend WithEvents GB_Buscar As System.Windows.Forms.GroupBox
    Friend WithEvents txt_buscar As System.Windows.Forms.TextBox
    Friend WithEvents DG_Productos As System.Windows.Forms.DataGridView
    Friend WithEvents TbAlta As System.Windows.Forms.TabPage
    Friend WithEvents GB_Alta As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Foto As System.Windows.Forms.Label
    Friend WithEvents cb_Subcategoria As System.Windows.Forms.ComboBox
    Friend WithEvents cb_Categoria As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_Subcategoria As System.Windows.Forms.Label
    Friend WithEvents lbl_Categoria As System.Windows.Forms.Label
    Friend WithEvents txt_Descripcion As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Descripcion As System.Windows.Forms.Label
    Friend WithEvents txt_Codigo As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Codigo As System.Windows.Forms.Label
    Friend WithEvents txt_Tamano As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Tamano As System.Windows.Forms.Label
    Friend WithEvents txt_Origen As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Origen As System.Windows.Forms.Label
    Friend WithEvents chk_Habilitado As System.Windows.Forms.CheckBox
    Friend WithEvents txt_Nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_Nombre As System.Windows.Forms.Label
    Friend WithEvents Btn_Agregar As System.Windows.Forms.Button
    Friend WithEvents TbMod As System.Windows.Forms.TabPage
    Friend WithEvents GB_Modificacion As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Open As System.Windows.Forms.Button
    Friend WithEvents txt_Foto As System.Windows.Forms.TextBox
    Friend WithEvents chk_Novedad As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_Novedad As System.Windows.Forms.Label
    Friend WithEvents chk_SubirWeb As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_SubirWeb As System.Windows.Forms.Label
    Friend WithEvents Cargar As System.Windows.Forms.OpenFileDialog
    Friend WithEvents cb_Proveedores As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_Proveedor As System.Windows.Forms.Label
    Friend WithEvents ErrorProductos As System.Windows.Forms.ErrorProvider
    Friend WithEvents lbl_Materiales As System.Windows.Forms.Label
    Friend WithEvents lbl_Aroma As System.Windows.Forms.Label
    Friend WithEvents chk_Materiales As System.Windows.Forms.CheckedListBox
    Friend WithEvents chk_Aromas As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_Modificar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chk_Materiales_mod As System.Windows.Forms.CheckedListBox
    Friend WithEvents chk_Aromas_mod As System.Windows.Forms.CheckedListBox
    Friend WithEvents cb_Proveedor_mod As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_Open_mod As System.Windows.Forms.Button
    Friend WithEvents txt_Foto_mod As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cb_Subcategoria_mod As System.Windows.Forms.ComboBox
    Friend WithEvents cb_Categoria_mod As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_Descripcion_mod As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_Codigo_mod As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_Tamano_mod As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_Origen_mod As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_Nombre_mod As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents rb_Opcion2 As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Opcion As System.Windows.Forms.RadioButton
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents btn_Restablecer As System.Windows.Forms.Button
    Friend WithEvents lbl_Foto2 As System.Windows.Forms.Label
    Friend WithEvents pb_foto As System.Windows.Forms.PictureBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents pb_foto_mod As System.Windows.Forms.PictureBox
    Friend WithEvents GB_Precios As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Precio5 As System.Windows.Forms.Label
    Friend WithEvents txt_Precio4 As System.Windows.Forms.TextBox
    Friend WithEvents txt_Precio5 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Precio4 As System.Windows.Forms.Label
    Friend WithEvents txt_Precio2 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Precio1 As System.Windows.Forms.Label
    Friend WithEvents txt_Precio3 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Precio2 As System.Windows.Forms.Label
    Friend WithEvents txt_Precio1 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Precio3 As System.Windows.Forms.Label
    Friend WithEvents Gb_Precios_mod As System.Windows.Forms.GroupBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txt_Precio4_mod As System.Windows.Forms.TextBox
    Friend WithEvents txt_Precio5_mod As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txt_Precio2_mod As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txt_Precio3_mod As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txt_Precio1_mod As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents chk_Novedad_mod As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chk_SubirWeb_mod As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents chk_Habilitado_mod As System.Windows.Forms.CheckBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lbl_Colores As System.Windows.Forms.Label
    Friend WithEvents chk_Colores As System.Windows.Forms.CheckedListBox
    Friend WithEvents lbl_Colores_mod As System.Windows.Forms.Label
    Friend WithEvents chk_Colores_mod As System.Windows.Forms.CheckedListBox
    Friend WithEvents lbl_CodigoBarra As System.Windows.Forms.Label
    Friend WithEvents pb_CodigoBarra As System.Windows.Forms.PictureBox
    Friend WithEvents Btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents Ck_EliminarFoto As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_Precio6 As System.Windows.Forms.Label
    Friend WithEvents txt_Precio6 As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txt_Precio6_mod As System.Windows.Forms.TextBox
    Friend WithEvents txt_Costo As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txt_Costo_mod As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents ToolProd As System.Windows.Forms.ToolTip
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents lbl_Msg As System.Windows.Forms.Label
    Friend WithEvents id_Producto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Categoria As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Subcategoria As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Proveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Habilitado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Modificar As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_Exportar As System.Windows.Forms.Button
    Friend WithEvents btn_Importar As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btn_Restore As System.Windows.Forms.Button
End Class
