<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProductos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Subcategoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Habilitado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Modificar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Eliminar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TbAlta = New System.Windows.Forms.TabPage()
        Me.GB_Alta = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_Foto = New System.Windows.Forms.TextBox()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btn_Open = New System.Windows.Forms.Button()
        Me.lbl_Nombre = New System.Windows.Forms.Label()
        Me.lbl_Origen = New System.Windows.Forms.Label()
        Me.txt_Costo = New System.Windows.Forms.TextBox()
        Me.lbl_Tamano = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lbl_Codigo = New System.Windows.Forms.Label()
        Me.lbl_Foto = New System.Windows.Forms.Label()
        Me.lbl_Categoria = New System.Windows.Forms.Label()
        Me.lbl_Subcategoria = New System.Windows.Forms.Label()
        Me.lbl_Proveedor = New System.Windows.Forms.Label()
        Me.lbl_Descripcion = New System.Windows.Forms.Label()
        Me.chk_Novedad = New System.Windows.Forms.CheckBox()
        Me.cb_Proveedores = New System.Windows.Forms.ComboBox()
        Me.ProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.chk_SubirWeb = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chk_Habilitado = New System.Windows.Forms.CheckBox()
        Me.txt_Descripcion = New System.Windows.Forms.TextBox()
        Me.lbl_SubirWeb = New System.Windows.Forms.Label()
        Me.lbl_Novedad = New System.Windows.Forms.Label()
        Me.cb_Subcategoria = New System.Windows.Forms.ComboBox()
        Me.SubcategoriasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txt_Nombre = New System.Windows.Forms.TextBox()
        Me.cb_Categoria = New System.Windows.Forms.ComboBox()
        Me.CategoriasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txt_Origen = New System.Windows.Forms.TextBox()
        Me.txt_Tamano = New System.Windows.Forms.TextBox()
        Me.txt_Codigo = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.pb_foto = New System.Windows.Forms.PictureBox()
        Me.GB_Precios = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_Precio6 = New System.Windows.Forms.TextBox()
        Me.lbl_Precio6 = New System.Windows.Forms.Label()
        Me.txt_Precio5 = New System.Windows.Forms.TextBox()
        Me.txt_Precio4 = New System.Windows.Forms.TextBox()
        Me.lbl_Precio1 = New System.Windows.Forms.Label()
        Me.lbl_Precio2 = New System.Windows.Forms.Label()
        Me.txt_Precio3 = New System.Windows.Forms.TextBox()
        Me.txt_Precio2 = New System.Windows.Forms.TextBox()
        Me.lbl_Precio5 = New System.Windows.Forms.Label()
        Me.lbl_Precio3 = New System.Windows.Forms.Label()
        Me.txt_Precio1 = New System.Windows.Forms.TextBox()
        Me.lbl_Precio4 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Btn_Agregar = New System.Windows.Forms.Button()
        Me.TbMod = New System.Windows.Forms.TabPage()
        Me.GB_Modificacion = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel15 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel9 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_Foto_mod = New System.Windows.Forms.TextBox()
        Me.btn_Open_mod = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_Costo_mod = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.chk_Habilitado_mod = New System.Windows.Forms.CheckBox()
        Me.chk_SubirWeb_mod = New System.Windows.Forms.CheckBox()
        Me.chk_Novedad_mod = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_Descripcion_mod = New System.Windows.Forms.TextBox()
        Me.cb_Proveedor_mod = New System.Windows.Forms.ComboBox()
        Me.txt_Nombre_mod = New System.Windows.Forms.TextBox()
        Me.txt_Origen_mod = New System.Windows.Forms.TextBox()
        Me.txt_Tamano_mod = New System.Windows.Forms.TextBox()
        Me.txt_Codigo_mod = New System.Windows.Forms.TextBox()
        Me.cb_Subcategoria_mod = New System.Windows.Forms.ComboBox()
        Me.cb_Categoria_mod = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel14 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel12 = New System.Windows.Forms.TableLayoutPanel()
        Me.pb_CodigoBarra = New System.Windows.Forms.PictureBox()
        Me.pb_foto_mod = New System.Windows.Forms.PictureBox()
        Me.Ck_EliminarFoto = New System.Windows.Forms.CheckBox()
        Me.Gb_Precios_mod = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel10 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_Precio6_mod = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txt_Precio5_mod = New System.Windows.Forms.TextBox()
        Me.txt_Precio4_mod = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txt_Precio3_mod = New System.Windows.Forms.TextBox()
        Me.txt_Precio2_mod = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txt_Precio1_mod = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Btn_Eliminar = New System.Windows.Forms.Button()
        Me.btn_Modificar = New System.Windows.Forms.Button()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrigenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TamanioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FotoRutaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoriasSeleccionadaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubcategoriasSeleccionadaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProveedoresSeleccionadaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListaTigreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PorcentajeDescuentoTigreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListaCapitalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PorcentajeDescuentoCapitalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MayoristaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlternativoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cargar = New System.Windows.Forms.OpenFileDialog()
        Me.ToolProd = New System.Windows.Forms.ToolTip(Me.components)
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.TabProductos.SuspendLayout()
        Me.TbListado.SuspendLayout()
        Me.GB_Buscar.SuspendLayout()
        CType(Me.DG_Productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TbAlta.SuspendLayout()
        Me.GB_Alta.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubcategoriasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel6.SuspendLayout()
        CType(Me.pb_foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_Precios.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TbMod.SuspendLayout()
        Me.GB_Modificacion.SuspendLayout()
        Me.TableLayoutPanel15.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        Me.TableLayoutPanel9.SuspendLayout()
        Me.TableLayoutPanel14.SuspendLayout()
        Me.TableLayoutPanel12.SuspendLayout()
        CType(Me.pb_CodigoBarra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_foto_mod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gb_Precios_mod.SuspendLayout()
        Me.TableLayoutPanel10.SuspendLayout()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabProductos.TabIndex = 99
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
        Me.lbl_Msg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Msg.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lbl_Msg.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Msg.Location = New System.Drawing.Point(294, 277)
        Me.lbl_Msg.Name = "lbl_Msg"
        Me.lbl_Msg.Size = New System.Drawing.Size(399, 94)
        Me.lbl_Msg.TabIndex = 4
        Me.lbl_Msg.Text = "No se han encontrado productos."
        Me.lbl_Msg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.txt_buscar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.DG_Productos.ColumnHeadersHeight = 46
        Me.DG_Productos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Nombre, Me.id_Producto, Me.Categoria, Me.Subcategoria, Me.Proveedor, Me.precio1, Me.precio2, Me.precio3, Me.precio4, Me.precio5, Me.precio6, Me.Habilitado, Me.Modificar, Me.Eliminar})
        Me.DG_Productos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DG_Productos.Location = New System.Drawing.Point(6, 91)
        Me.DG_Productos.MultiSelect = False
        Me.DG_Productos.Name = "DG_Productos"
        Me.DG_Productos.ReadOnly = True
        Me.DG_Productos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DG_Productos.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.DG_Productos.RowTemplate.Height = 30
        Me.DG_Productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Productos.Size = New System.Drawing.Size(974, 466)
        Me.DG_Productos.TabIndex = 0
        '
        'Codigo
        '
        Me.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Codigo.DataPropertyName = "Codigo"
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.MinimumWidth = 30
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        Me.Codigo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Codigo.Width = 84
        '
        'Nombre
        '
        Me.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.MinimumWidth = 180
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 180
        '
        'id_Producto
        '
        Me.id_Producto.DataPropertyName = "id_Producto"
        Me.id_Producto.HeaderText = "ID"
        Me.id_Producto.MaxInputLength = 10
        Me.id_Producto.Name = "id_Producto"
        Me.id_Producto.ReadOnly = True
        Me.id_Producto.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.id_Producto.Visible = False
        '
        'Categoria
        '
        Me.Categoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Categoria.DataPropertyName = "Cat"
        Me.Categoria.HeaderText = "Categoria"
        Me.Categoria.Name = "Categoria"
        Me.Categoria.ReadOnly = True
        Me.Categoria.Width = 103
        '
        'Subcategoria
        '
        Me.Subcategoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Subcategoria.DataPropertyName = "Subcat"
        Me.Subcategoria.HeaderText = "Subcat."
        Me.Subcategoria.MaxInputLength = 150
        Me.Subcategoria.Name = "Subcategoria"
        Me.Subcategoria.ReadOnly = True
        Me.Subcategoria.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Subcategoria.Width = 89
        '
        'Proveedor
        '
        Me.Proveedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Proveedor.DataPropertyName = "Proveedor"
        Me.Proveedor.HeaderText = "Proveedor"
        Me.Proveedor.Name = "Proveedor"
        Me.Proveedor.ReadOnly = True
        Me.Proveedor.Width = 106
        '
        'precio1
        '
        Me.precio1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.precio1.DataPropertyName = "Precio1"
        DataGridViewCellStyle2.Format = "C2"
        Me.precio1.DefaultCellStyle = DataGridViewCellStyle2
        Me.precio1.HeaderText = "Lista Tigre"
        Me.precio1.Name = "precio1"
        Me.precio1.ReadOnly = True
        Me.precio1.Width = 98
        '
        'precio2
        '
        Me.precio2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.precio2.DataPropertyName = "Precio2"
        DataGridViewCellStyle3.Format = "P2"
        Me.precio2.DefaultCellStyle = DataGridViewCellStyle3
        Me.precio2.HeaderText = "Desc. Tigre"
        Me.precio2.Name = "precio2"
        Me.precio2.ReadOnly = True
        Me.precio2.Width = 105
        '
        'precio3
        '
        Me.precio3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.precio3.DataPropertyName = "Precio3"
        DataGridViewCellStyle4.Format = "C2"
        Me.precio3.DefaultCellStyle = DataGridViewCellStyle4
        Me.precio3.HeaderText = "Lista Capital"
        Me.precio3.Name = "precio3"
        Me.precio3.ReadOnly = True
        Me.precio3.Width = 111
        '
        'precio4
        '
        Me.precio4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.precio4.DataPropertyName = "Precio4"
        DataGridViewCellStyle5.Format = "P2"
        Me.precio4.DefaultCellStyle = DataGridViewCellStyle5
        Me.precio4.HeaderText = "Desc. Capital"
        Me.precio4.Name = "precio4"
        Me.precio4.ReadOnly = True
        Me.precio4.Width = 117
        '
        'precio5
        '
        Me.precio5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.precio5.DataPropertyName = "Precio5"
        DataGridViewCellStyle6.Format = "C2"
        Me.precio5.DefaultCellStyle = DataGridViewCellStyle6
        Me.precio5.HeaderText = "Mayorista"
        Me.precio5.Name = "precio5"
        Me.precio5.ReadOnly = True
        Me.precio5.Width = 102
        '
        'precio6
        '
        Me.precio6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.precio6.DataPropertyName = "Precio6"
        DataGridViewCellStyle7.Format = "C2"
        Me.precio6.DefaultCellStyle = DataGridViewCellStyle7
        Me.precio6.HeaderText = "Alternativo"
        Me.precio6.Name = "precio6"
        Me.precio6.ReadOnly = True
        Me.precio6.Width = 109
        '
        'Habilitado
        '
        Me.Habilitado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Habilitado.DataPropertyName = "Habilitado"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Habilitado.DefaultCellStyle = DataGridViewCellStyle8
        Me.Habilitado.HeaderText = "Habil."
        Me.Habilitado.MaxInputLength = 10
        Me.Habilitado.MinimumWidth = 10
        Me.Habilitado.Name = "Habilitado"
        Me.Habilitado.ReadOnly = True
        Me.Habilitado.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Habilitado.Width = 74
        '
        'Modificar
        '
        Me.Modificar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Modificar.HeaderText = ""
        Me.Modificar.Image = Global.SistemaCinderella.My.Resources.Recursos.Boton_Editar
        Me.Modificar.MinimumWidth = 10
        Me.Modificar.Name = "Modificar"
        Me.Modificar.ReadOnly = True
        Me.Modificar.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Modificar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Modificar.Width = 19
        '
        'Eliminar
        '
        Me.Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Eliminar.HeaderText = ""
        Me.Eliminar.Image = Global.SistemaCinderella.My.Resources.Recursos.Boton_Eliminar
        Me.Eliminar.MinimumWidth = 10
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Eliminar.Width = 19
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
        Me.GB_Alta.Controls.Add(Me.TableLayoutPanel7)
        Me.GB_Alta.Controls.Add(Me.Label25)
        Me.GB_Alta.Controls.Add(Me.Btn_Agregar)
        Me.GB_Alta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Alta.Location = New System.Drawing.Point(10, 6)
        Me.GB_Alta.Name = "GB_Alta"
        Me.GB_Alta.Size = New System.Drawing.Size(980, 563)
        Me.GB_Alta.TabIndex = 0
        Me.GB_Alta.TabStop = False
        Me.GB_Alta.Text = "Formulario de Alta"
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel7.ColumnCount = 2
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.TableLayoutPanel1, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.TableLayoutPanel6, 1, 0)
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(6, 16)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(968, 493)
        Me.TableLayoutPanel7.TabIndex = 68
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_Nombre, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_Origen, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Costo, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_Tamano, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label23, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_Codigo, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_Foto, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_Categoria, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_Subcategoria, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_Proveedor, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_Descripcion, 0, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.chk_Novedad, 1, 12)
        Me.TableLayoutPanel1.Controls.Add(Me.cb_Proveedores, 1, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.chk_SubirWeb, 1, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.chk_Habilitado, 1, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Descripcion, 1, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_SubirWeb, 0, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_Novedad, 0, 12)
        Me.TableLayoutPanel1.Controls.Add(Me.cb_Subcategoria, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Nombre, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cb_Categoria, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Origen, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Tamano, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Codigo, 1, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 13
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(478, 487)
        Me.TableLayoutPanel1.TabIndex = 68
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.txt_Foto, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_Open, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(143, 153)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(332, 29)
        Me.TableLayoutPanel2.TabIndex = 6
        '
        'txt_Foto
        '
        Me.txt_Foto.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Foto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "FotoRuta", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_Foto.Location = New System.Drawing.Point(3, 4)
        Me.txt_Foto.Name = "txt_Foto"
        Me.txt_Foto.Size = New System.Drawing.Size(286, 21)
        Me.txt_Foto.TabIndex = 6
        '
        'ProductoBindingSource
        '
        Me.ProductoBindingSource.DataSource = GetType(SistemaCinderella.VistaModelo.frmProductos.Producto)
        '
        'btn_Open
        '
        Me.btn_Open.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Open.Location = New System.Drawing.Point(299, 3)
        Me.btn_Open.Name = "btn_Open"
        Me.btn_Open.Size = New System.Drawing.Size(30, 23)
        Me.btn_Open.TabIndex = 7
        Me.btn_Open.Text = ". . ."
        Me.btn_Open.UseVisualStyleBackColor = True
        '
        'lbl_Nombre
        '
        Me.lbl_Nombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Nombre.AutoSize = True
        Me.lbl_Nombre.Location = New System.Drawing.Point(3, 7)
        Me.lbl_Nombre.Name = "lbl_Nombre"
        Me.lbl_Nombre.Size = New System.Drawing.Size(134, 15)
        Me.lbl_Nombre.TabIndex = 0
        Me.lbl_Nombre.Text = "Nombre (*)"
        '
        'lbl_Origen
        '
        Me.lbl_Origen.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Origen.AutoSize = True
        Me.lbl_Origen.Location = New System.Drawing.Point(3, 37)
        Me.lbl_Origen.Name = "lbl_Origen"
        Me.lbl_Origen.Size = New System.Drawing.Size(134, 15)
        Me.lbl_Origen.TabIndex = 0
        Me.lbl_Origen.Text = "Origen"
        '
        'txt_Costo
        '
        Me.txt_Costo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Costo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "Costo", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.txt_Costo.Location = New System.Drawing.Point(143, 124)
        Me.txt_Costo.MaxLength = 255
        Me.txt_Costo.Name = "txt_Costo"
        Me.txt_Costo.Size = New System.Drawing.Size(332, 21)
        Me.txt_Costo.TabIndex = 5
        Me.txt_Costo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl_Tamano
        '
        Me.lbl_Tamano.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Tamano.AutoSize = True
        Me.lbl_Tamano.Location = New System.Drawing.Point(3, 67)
        Me.lbl_Tamano.Name = "lbl_Tamano"
        Me.lbl_Tamano.Size = New System.Drawing.Size(134, 15)
        Me.lbl_Tamano.TabIndex = 0
        Me.lbl_Tamano.Text = "Tamaño"
        '
        'Label23
        '
        Me.Label23.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(3, 127)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(134, 15)
        Me.Label23.TabIndex = 0
        Me.Label23.Text = "Costo"
        '
        'lbl_Codigo
        '
        Me.lbl_Codigo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Codigo.AutoSize = True
        Me.lbl_Codigo.Location = New System.Drawing.Point(3, 97)
        Me.lbl_Codigo.Name = "lbl_Codigo"
        Me.lbl_Codigo.Size = New System.Drawing.Size(134, 15)
        Me.lbl_Codigo.TabIndex = 0
        Me.lbl_Codigo.Text = "Código (*)"
        '
        'lbl_Foto
        '
        Me.lbl_Foto.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Foto.AutoSize = True
        Me.lbl_Foto.Location = New System.Drawing.Point(3, 160)
        Me.lbl_Foto.Name = "lbl_Foto"
        Me.lbl_Foto.Size = New System.Drawing.Size(134, 15)
        Me.lbl_Foto.TabIndex = 0
        Me.lbl_Foto.Text = "Foto"
        '
        'lbl_Categoria
        '
        Me.lbl_Categoria.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Categoria.AutoSize = True
        Me.lbl_Categoria.Location = New System.Drawing.Point(3, 192)
        Me.lbl_Categoria.Name = "lbl_Categoria"
        Me.lbl_Categoria.Size = New System.Drawing.Size(134, 15)
        Me.lbl_Categoria.TabIndex = 0
        Me.lbl_Categoria.Text = "Categoría (*)"
        '
        'lbl_Subcategoria
        '
        Me.lbl_Subcategoria.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Subcategoria.AutoSize = True
        Me.lbl_Subcategoria.Location = New System.Drawing.Point(3, 222)
        Me.lbl_Subcategoria.Name = "lbl_Subcategoria"
        Me.lbl_Subcategoria.Size = New System.Drawing.Size(134, 15)
        Me.lbl_Subcategoria.TabIndex = 0
        Me.lbl_Subcategoria.Text = "Subcategoría (*)"
        '
        'lbl_Proveedor
        '
        Me.lbl_Proveedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Proveedor.AutoSize = True
        Me.lbl_Proveedor.Location = New System.Drawing.Point(3, 252)
        Me.lbl_Proveedor.Name = "lbl_Proveedor"
        Me.lbl_Proveedor.Size = New System.Drawing.Size(134, 15)
        Me.lbl_Proveedor.TabIndex = 0
        Me.lbl_Proveedor.Text = "Proveedor (*)"
        '
        'lbl_Descripcion
        '
        Me.lbl_Descripcion.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Descripcion.AutoSize = True
        Me.lbl_Descripcion.Location = New System.Drawing.Point(3, 328)
        Me.lbl_Descripcion.Name = "lbl_Descripcion"
        Me.lbl_Descripcion.Size = New System.Drawing.Size(134, 15)
        Me.lbl_Descripcion.TabIndex = 0
        Me.lbl_Descripcion.Text = "Descripcion"
        '
        'chk_Novedad
        '
        Me.chk_Novedad.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chk_Novedad.AutoSize = True
        Me.chk_Novedad.Checked = True
        Me.chk_Novedad.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Novedad.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.ProductoBindingSource, "Novedad", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.chk_Novedad.Location = New System.Drawing.Point(143, 465)
        Me.chk_Novedad.Name = "chk_Novedad"
        Me.chk_Novedad.Size = New System.Drawing.Size(332, 14)
        Me.chk_Novedad.TabIndex = 14
        Me.chk_Novedad.UseVisualStyleBackColor = True
        '
        'cb_Proveedores
        '
        Me.cb_Proveedores.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_Proveedores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_Proveedores.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ProductoBindingSource, "ProveedoresSeleccionada", True))
        Me.cb_Proveedores.DataSource = Me.ProveedoresBindingSource
        Me.cb_Proveedores.DisplayMember = "Value"
        Me.cb_Proveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Proveedores.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cb_Proveedores.FormattingEnabled = True
        Me.cb_Proveedores.Location = New System.Drawing.Point(143, 248)
        Me.cb_Proveedores.Name = "cb_Proveedores"
        Me.cb_Proveedores.Size = New System.Drawing.Size(332, 23)
        Me.cb_Proveedores.TabIndex = 10
        Me.cb_Proveedores.ValueMember = "Key"
        '
        'ProveedoresBindingSource
        '
        Me.ProveedoresBindingSource.DataMember = "Proveedores"
        Me.ProveedoresBindingSource.DataSource = Me.ProductoBindingSource
        '
        'chk_SubirWeb
        '
        Me.chk_SubirWeb.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chk_SubirWeb.AutoSize = True
        Me.chk_SubirWeb.Checked = True
        Me.chk_SubirWeb.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_SubirWeb.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.ProductoBindingSource, "SubirAWeb", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.chk_SubirWeb.Location = New System.Drawing.Point(143, 435)
        Me.chk_SubirWeb.Name = "chk_SubirWeb"
        Me.chk_SubirWeb.Size = New System.Drawing.Size(332, 14)
        Me.chk_SubirWeb.TabIndex = 13
        Me.chk_SubirWeb.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 404)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Habilitado"
        '
        'chk_Habilitado
        '
        Me.chk_Habilitado.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chk_Habilitado.AutoSize = True
        Me.chk_Habilitado.Checked = True
        Me.chk_Habilitado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Habilitado.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.ProductoBindingSource, "Habilitado", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.chk_Habilitado.Location = New System.Drawing.Point(143, 405)
        Me.chk_Habilitado.Name = "chk_Habilitado"
        Me.chk_Habilitado.Size = New System.Drawing.Size(332, 14)
        Me.chk_Habilitado.TabIndex = 12
        Me.chk_Habilitado.UseVisualStyleBackColor = True
        '
        'txt_Descripcion
        '
        Me.txt_Descripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "Descripcion", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_Descripcion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Descripcion.Location = New System.Drawing.Point(143, 278)
        Me.txt_Descripcion.MaxLength = 255
        Me.txt_Descripcion.Multiline = True
        Me.txt_Descripcion.Name = "txt_Descripcion"
        Me.txt_Descripcion.Size = New System.Drawing.Size(332, 116)
        Me.txt_Descripcion.TabIndex = 11
        '
        'lbl_SubirWeb
        '
        Me.lbl_SubirWeb.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_SubirWeb.AutoSize = True
        Me.lbl_SubirWeb.Location = New System.Drawing.Point(3, 434)
        Me.lbl_SubirWeb.Name = "lbl_SubirWeb"
        Me.lbl_SubirWeb.Size = New System.Drawing.Size(134, 15)
        Me.lbl_SubirWeb.TabIndex = 0
        Me.lbl_SubirWeb.Text = "Subir a la Web"
        '
        'lbl_Novedad
        '
        Me.lbl_Novedad.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Novedad.AutoSize = True
        Me.lbl_Novedad.Location = New System.Drawing.Point(3, 464)
        Me.lbl_Novedad.Name = "lbl_Novedad"
        Me.lbl_Novedad.Size = New System.Drawing.Size(134, 15)
        Me.lbl_Novedad.TabIndex = 0
        Me.lbl_Novedad.Text = "Novedad"
        '
        'cb_Subcategoria
        '
        Me.cb_Subcategoria.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_Subcategoria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_Subcategoria.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ProductoBindingSource, "SubcategoriasSeleccionada", True))
        Me.cb_Subcategoria.DataSource = Me.SubcategoriasBindingSource
        Me.cb_Subcategoria.DisplayMember = "Value"
        Me.cb_Subcategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Subcategoria.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cb_Subcategoria.FormattingEnabled = True
        Me.cb_Subcategoria.Location = New System.Drawing.Point(143, 218)
        Me.cb_Subcategoria.Name = "cb_Subcategoria"
        Me.cb_Subcategoria.Size = New System.Drawing.Size(332, 23)
        Me.cb_Subcategoria.TabIndex = 9
        Me.cb_Subcategoria.ValueMember = "Key"
        '
        'SubcategoriasBindingSource
        '
        Me.SubcategoriasBindingSource.DataMember = "Subcategorias"
        Me.SubcategoriasBindingSource.DataSource = Me.ProductoBindingSource
        '
        'txt_Nombre
        '
        Me.txt_Nombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Nombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "Nombre", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_Nombre.Location = New System.Drawing.Point(143, 4)
        Me.txt_Nombre.MaxLength = 255
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.Size = New System.Drawing.Size(332, 21)
        Me.txt_Nombre.TabIndex = 1
        '
        'cb_Categoria
        '
        Me.cb_Categoria.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_Categoria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_Categoria.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ProductoBindingSource, "CategoriasSeleccionada", True))
        Me.cb_Categoria.DataSource = Me.CategoriasBindingSource
        Me.cb_Categoria.DisplayMember = "Value"
        Me.cb_Categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Categoria.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cb_Categoria.FormattingEnabled = True
        Me.cb_Categoria.Location = New System.Drawing.Point(143, 188)
        Me.cb_Categoria.Name = "cb_Categoria"
        Me.cb_Categoria.Size = New System.Drawing.Size(332, 23)
        Me.cb_Categoria.TabIndex = 8
        Me.cb_Categoria.ValueMember = "Key"
        '
        'CategoriasBindingSource
        '
        Me.CategoriasBindingSource.DataMember = "Categorias"
        Me.CategoriasBindingSource.DataSource = Me.ProductoBindingSource
        '
        'txt_Origen
        '
        Me.txt_Origen.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Origen.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "Origen", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_Origen.Location = New System.Drawing.Point(143, 34)
        Me.txt_Origen.MaxLength = 255
        Me.txt_Origen.Name = "txt_Origen"
        Me.txt_Origen.Size = New System.Drawing.Size(332, 21)
        Me.txt_Origen.TabIndex = 2
        '
        'txt_Tamano
        '
        Me.txt_Tamano.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Tamano.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "Tamanio", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_Tamano.Location = New System.Drawing.Point(143, 64)
        Me.txt_Tamano.MaxLength = 255
        Me.txt_Tamano.Name = "txt_Tamano"
        Me.txt_Tamano.Size = New System.Drawing.Size(332, 21)
        Me.txt_Tamano.TabIndex = 3
        '
        'txt_Codigo
        '
        Me.txt_Codigo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Codigo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "Codigo", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_Codigo.Location = New System.Drawing.Point(143, 94)
        Me.txt_Codigo.MaxLength = 255
        Me.txt_Codigo.Name = "txt_Codigo"
        Me.txt_Codigo.Size = New System.Drawing.Size(332, 21)
        Me.txt_Codigo.TabIndex = 4
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 1
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.pb_foto, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.GB_Precios, 0, 1)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(487, 3)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 2
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 216.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(478, 487)
        Me.TableLayoutPanel6.TabIndex = 99
        '
        'pb_foto
        '
        Me.pb_foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pb_foto.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.ProductoBindingSource, "Foto", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.pb_foto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pb_foto.Image = Global.SistemaCinderella.My.Resources.Recursos.Sinfoto
        Me.pb_foto.InitialImage = Nothing
        Me.pb_foto.Location = New System.Drawing.Point(3, 3)
        Me.pb_foto.Name = "pb_foto"
        Me.pb_foto.Size = New System.Drawing.Size(472, 265)
        Me.pb_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_foto.TabIndex = 40
        Me.pb_foto.TabStop = False
        '
        'GB_Precios
        '
        Me.GB_Precios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_Precios.Controls.Add(Me.TableLayoutPanel4)
        Me.GB_Precios.Location = New System.Drawing.Point(3, 274)
        Me.GB_Precios.Name = "GB_Precios"
        Me.GB_Precios.Size = New System.Drawing.Size(472, 210)
        Me.GB_Precios.TabIndex = 15
        Me.GB_Precios.TabStop = False
        Me.GB_Precios.Text = "Listas de Precios"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.txt_Precio6, 1, 5)
        Me.TableLayoutPanel4.Controls.Add(Me.lbl_Precio6, 0, 5)
        Me.TableLayoutPanel4.Controls.Add(Me.txt_Precio5, 1, 4)
        Me.TableLayoutPanel4.Controls.Add(Me.txt_Precio4, 1, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.lbl_Precio1, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.lbl_Precio2, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.txt_Precio3, 1, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.txt_Precio2, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.lbl_Precio5, 0, 4)
        Me.TableLayoutPanel4.Controls.Add(Me.lbl_Precio3, 0, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.txt_Precio1, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.lbl_Precio4, 0, 3)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 17)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 6
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(466, 190)
        Me.TableLayoutPanel4.TabIndex = 15
        '
        'txt_Precio6
        '
        Me.txt_Precio6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Precio6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "Alternativo", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.txt_Precio6.Location = New System.Drawing.Point(143, 159)
        Me.txt_Precio6.Name = "txt_Precio6"
        Me.txt_Precio6.Size = New System.Drawing.Size(320, 21)
        Me.txt_Precio6.TabIndex = 20
        Me.txt_Precio6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl_Precio6
        '
        Me.lbl_Precio6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Precio6.AutoSize = True
        Me.lbl_Precio6.Location = New System.Drawing.Point(3, 162)
        Me.lbl_Precio6.Name = "lbl_Precio6"
        Me.lbl_Precio6.Size = New System.Drawing.Size(134, 15)
        Me.lbl_Precio6.TabIndex = 0
        Me.lbl_Precio6.Text = "Alternativa (*)"
        '
        'txt_Precio5
        '
        Me.txt_Precio5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Precio5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "Mayorista", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.txt_Precio5.Location = New System.Drawing.Point(143, 124)
        Me.txt_Precio5.Name = "txt_Precio5"
        Me.txt_Precio5.Size = New System.Drawing.Size(320, 21)
        Me.txt_Precio5.TabIndex = 19
        Me.txt_Precio5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_Precio4
        '
        Me.txt_Precio4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Precio4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "PorcentajeDescuentoCapital", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "P"))
        Me.txt_Precio4.Location = New System.Drawing.Point(143, 94)
        Me.txt_Precio4.Name = "txt_Precio4"
        Me.txt_Precio4.Size = New System.Drawing.Size(320, 21)
        Me.txt_Precio4.TabIndex = 18
        Me.txt_Precio4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl_Precio1
        '
        Me.lbl_Precio1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Precio1.AutoSize = True
        Me.lbl_Precio1.Location = New System.Drawing.Point(3, 7)
        Me.lbl_Precio1.Name = "lbl_Precio1"
        Me.lbl_Precio1.Size = New System.Drawing.Size(134, 15)
        Me.lbl_Precio1.TabIndex = 0
        Me.lbl_Precio1.Text = "Lista Tigre (*)"
        '
        'lbl_Precio2
        '
        Me.lbl_Precio2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Precio2.AutoSize = True
        Me.lbl_Precio2.Location = New System.Drawing.Point(3, 37)
        Me.lbl_Precio2.Name = "lbl_Precio2"
        Me.lbl_Precio2.Size = New System.Drawing.Size(134, 15)
        Me.lbl_Precio2.TabIndex = 0
        Me.lbl_Precio2.Text = "% Desc. Tigre (*)"
        '
        'txt_Precio3
        '
        Me.txt_Precio3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Precio3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "ListaCapital", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.txt_Precio3.Location = New System.Drawing.Point(143, 64)
        Me.txt_Precio3.Name = "txt_Precio3"
        Me.txt_Precio3.Size = New System.Drawing.Size(320, 21)
        Me.txt_Precio3.TabIndex = 17
        Me.txt_Precio3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_Precio2
        '
        Me.txt_Precio2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Precio2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "PorcentajeDescuentoTigre", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "P"))
        Me.txt_Precio2.Location = New System.Drawing.Point(143, 34)
        Me.txt_Precio2.Name = "txt_Precio2"
        Me.txt_Precio2.Size = New System.Drawing.Size(320, 21)
        Me.txt_Precio2.TabIndex = 16
        Me.txt_Precio2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl_Precio5
        '
        Me.lbl_Precio5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Precio5.AutoSize = True
        Me.lbl_Precio5.Location = New System.Drawing.Point(3, 127)
        Me.lbl_Precio5.Name = "lbl_Precio5"
        Me.lbl_Precio5.Size = New System.Drawing.Size(134, 15)
        Me.lbl_Precio5.TabIndex = 0
        Me.lbl_Precio5.Text = "Mayorista (*)"
        '
        'lbl_Precio3
        '
        Me.lbl_Precio3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Precio3.AutoSize = True
        Me.lbl_Precio3.Location = New System.Drawing.Point(3, 67)
        Me.lbl_Precio3.Name = "lbl_Precio3"
        Me.lbl_Precio3.Size = New System.Drawing.Size(134, 15)
        Me.lbl_Precio3.TabIndex = 0
        Me.lbl_Precio3.Text = "Lista Capital (*)"
        '
        'txt_Precio1
        '
        Me.txt_Precio1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Precio1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "ListaTigre", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.txt_Precio1.Location = New System.Drawing.Point(143, 4)
        Me.txt_Precio1.Name = "txt_Precio1"
        Me.txt_Precio1.Size = New System.Drawing.Size(320, 21)
        Me.txt_Precio1.TabIndex = 15
        Me.txt_Precio1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl_Precio4
        '
        Me.lbl_Precio4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Precio4.AutoSize = True
        Me.lbl_Precio4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_Precio4.Location = New System.Drawing.Point(3, 97)
        Me.lbl_Precio4.Name = "lbl_Precio4"
        Me.lbl_Precio4.Size = New System.Drawing.Size(134, 15)
        Me.lbl_Precio4.TabIndex = 0
        Me.lbl_Precio4.Text = "% Desc. Capital (*)"
        '
        'Label25
        '
        Me.Label25.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(6, 515)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(117, 13)
        Me.Label25.TabIndex = 67
        Me.Label25.Text = "(*) Campos obligatorios."
        '
        'Btn_Agregar
        '
        Me.Btn_Agregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Agregar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Agregar.Image = Global.SistemaCinderella.My.Resources.Recursos.Agregar_24
        Me.Btn_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Agregar.Location = New System.Drawing.Point(874, 515)
        Me.Btn_Agregar.Name = "Btn_Agregar"
        Me.Btn_Agregar.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Agregar.TabIndex = 21
        Me.Btn_Agregar.Text = "Agregar"
        Me.Btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolProd.SetToolTip(Me.Btn_Agregar, "Agrega el producto al sistema.")
        Me.Btn_Agregar.UseVisualStyleBackColor = False
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
        Me.GB_Modificacion.Controls.Add(Me.TableLayoutPanel15)
        Me.GB_Modificacion.Controls.Add(Me.Btn_Cancelar)
        Me.GB_Modificacion.Controls.Add(Me.Label26)
        Me.GB_Modificacion.Controls.Add(Me.Btn_Eliminar)
        Me.GB_Modificacion.Controls.Add(Me.btn_Modificar)
        Me.GB_Modificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Modificacion.Location = New System.Drawing.Point(10, 6)
        Me.GB_Modificacion.Name = "GB_Modificacion"
        Me.GB_Modificacion.Size = New System.Drawing.Size(980, 563)
        Me.GB_Modificacion.TabIndex = 1
        Me.GB_Modificacion.TabStop = False
        Me.GB_Modificacion.Text = "Formulario de Modificación"
        '
        'TableLayoutPanel15
        '
        Me.TableLayoutPanel15.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel15.ColumnCount = 2
        Me.TableLayoutPanel15.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel15.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel15.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel15.Controls.Add(Me.TableLayoutPanel8, 0, 0)
        Me.TableLayoutPanel15.Controls.Add(Me.TableLayoutPanel14, 1, 0)
        Me.TableLayoutPanel15.Location = New System.Drawing.Point(6, 20)
        Me.TableLayoutPanel15.Name = "TableLayoutPanel15"
        Me.TableLayoutPanel15.RowCount = 1
        Me.TableLayoutPanel15.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel15.Size = New System.Drawing.Size(968, 490)
        Me.TableLayoutPanel15.TabIndex = 93
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.ColumnCount = 2
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.TableLayoutPanel9, 1, 5)
        Me.TableLayoutPanel8.Controls.Add(Me.Label15, 0, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.Label13, 0, 1)
        Me.TableLayoutPanel8.Controls.Add(Me.Label12, 0, 2)
        Me.TableLayoutPanel8.Controls.Add(Me.txt_Costo_mod, 1, 4)
        Me.TableLayoutPanel8.Controls.Add(Me.Label11, 0, 3)
        Me.TableLayoutPanel8.Controls.Add(Me.Label24, 0, 4)
        Me.TableLayoutPanel8.Controls.Add(Me.Label7, 0, 5)
        Me.TableLayoutPanel8.Controls.Add(Me.Label9, 0, 6)
        Me.TableLayoutPanel8.Controls.Add(Me.Label8, 0, 7)
        Me.TableLayoutPanel8.Controls.Add(Me.Label4, 0, 8)
        Me.TableLayoutPanel8.Controls.Add(Me.Label10, 0, 9)
        Me.TableLayoutPanel8.Controls.Add(Me.Label14, 0, 10)
        Me.TableLayoutPanel8.Controls.Add(Me.chk_Habilitado_mod, 1, 10)
        Me.TableLayoutPanel8.Controls.Add(Me.chk_SubirWeb_mod, 1, 11)
        Me.TableLayoutPanel8.Controls.Add(Me.chk_Novedad_mod, 1, 12)
        Me.TableLayoutPanel8.Controls.Add(Me.Label6, 0, 11)
        Me.TableLayoutPanel8.Controls.Add(Me.Label5, 0, 12)
        Me.TableLayoutPanel8.Controls.Add(Me.txt_Descripcion_mod, 1, 9)
        Me.TableLayoutPanel8.Controls.Add(Me.cb_Proveedor_mod, 1, 8)
        Me.TableLayoutPanel8.Controls.Add(Me.txt_Nombre_mod, 1, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.txt_Origen_mod, 1, 1)
        Me.TableLayoutPanel8.Controls.Add(Me.txt_Tamano_mod, 1, 2)
        Me.TableLayoutPanel8.Controls.Add(Me.txt_Codigo_mod, 1, 3)
        Me.TableLayoutPanel8.Controls.Add(Me.cb_Subcategoria_mod, 1, 7)
        Me.TableLayoutPanel8.Controls.Add(Me.cb_Categoria_mod, 1, 6)
        Me.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 13
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(478, 484)
        Me.TableLayoutPanel8.TabIndex = 88
        '
        'TableLayoutPanel9
        '
        Me.TableLayoutPanel9.ColumnCount = 2
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel9.Controls.Add(Me.txt_Foto_mod, 0, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.btn_Open_mod, 1, 0)
        Me.TableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel9.Location = New System.Drawing.Point(143, 153)
        Me.TableLayoutPanel9.Name = "TableLayoutPanel9"
        Me.TableLayoutPanel9.RowCount = 1
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel9.Size = New System.Drawing.Size(332, 29)
        Me.TableLayoutPanel9.TabIndex = 6
        '
        'txt_Foto_mod
        '
        Me.txt_Foto_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Foto_mod.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "FotoRuta", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_Foto_mod.Location = New System.Drawing.Point(3, 4)
        Me.txt_Foto_mod.Name = "txt_Foto_mod"
        Me.txt_Foto_mod.Size = New System.Drawing.Size(286, 21)
        Me.txt_Foto_mod.TabIndex = 6
        '
        'btn_Open_mod
        '
        Me.btn_Open_mod.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btn_Open_mod.Location = New System.Drawing.Point(298, 3)
        Me.btn_Open_mod.Name = "btn_Open_mod"
        Me.btn_Open_mod.Size = New System.Drawing.Size(31, 23)
        Me.btn_Open_mod.TabIndex = 7
        Me.btn_Open_mod.Text = ". . ."
        Me.btn_Open_mod.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(3, 7)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(134, 15)
        Me.Label15.TabIndex = 41
        Me.Label15.Text = "Nombre (*)"
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(3, 37)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(134, 15)
        Me.Label13.TabIndex = 49
        Me.Label13.Text = "Origen"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 67)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(134, 15)
        Me.Label12.TabIndex = 58
        Me.Label12.Text = "Tamaño"
        '
        'txt_Costo_mod
        '
        Me.txt_Costo_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Costo_mod.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "Costo", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.txt_Costo_mod.Location = New System.Drawing.Point(143, 124)
        Me.txt_Costo_mod.MaxLength = 255
        Me.txt_Costo_mod.Name = "txt_Costo_mod"
        Me.txt_Costo_mod.Size = New System.Drawing.Size(332, 21)
        Me.txt_Costo_mod.TabIndex = 5
        Me.txt_Costo_mod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 97)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(134, 15)
        Me.Label11.TabIndex = 59
        Me.Label11.Text = "Código (*)"
        '
        'Label24
        '
        Me.Label24.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(3, 127)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(134, 15)
        Me.Label24.TabIndex = 85
        Me.Label24.Text = "Costo"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(134, 15)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "Foto"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 192)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(134, 15)
        Me.Label9.TabIndex = 61
        Me.Label9.Text = "Categoría (*)"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 222)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(134, 15)
        Me.Label8.TabIndex = 62
        Me.Label8.Text = "Subcategoría (*)"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 252)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 15)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "Proveedor (*)"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 327)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(134, 15)
        Me.Label10.TabIndex = 60
        Me.Label10.Text = "Descripcion"
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(3, 401)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(134, 15)
        Me.Label14.TabIndex = 72
        Me.Label14.Text = "Habilitado"
        '
        'chk_Habilitado_mod
        '
        Me.chk_Habilitado_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chk_Habilitado_mod.AutoSize = True
        Me.chk_Habilitado_mod.Checked = True
        Me.chk_Habilitado_mod.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Habilitado_mod.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.ProductoBindingSource, "Habilitado", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.chk_Habilitado_mod.Location = New System.Drawing.Point(143, 402)
        Me.chk_Habilitado_mod.Name = "chk_Habilitado_mod"
        Me.chk_Habilitado_mod.Size = New System.Drawing.Size(332, 14)
        Me.chk_Habilitado_mod.TabIndex = 12
        Me.chk_Habilitado_mod.UseVisualStyleBackColor = True
        '
        'chk_SubirWeb_mod
        '
        Me.chk_SubirWeb_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chk_SubirWeb_mod.AutoSize = True
        Me.chk_SubirWeb_mod.Checked = True
        Me.chk_SubirWeb_mod.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_SubirWeb_mod.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.ProductoBindingSource, "SubirAWeb", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.chk_SubirWeb_mod.Location = New System.Drawing.Point(143, 432)
        Me.chk_SubirWeb_mod.Name = "chk_SubirWeb_mod"
        Me.chk_SubirWeb_mod.Size = New System.Drawing.Size(332, 14)
        Me.chk_SubirWeb_mod.TabIndex = 13
        Me.chk_SubirWeb_mod.UseVisualStyleBackColor = True
        '
        'chk_Novedad_mod
        '
        Me.chk_Novedad_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chk_Novedad_mod.AutoSize = True
        Me.chk_Novedad_mod.Checked = True
        Me.chk_Novedad_mod.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Novedad_mod.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.ProductoBindingSource, "Novedad", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.chk_Novedad_mod.Location = New System.Drawing.Point(143, 462)
        Me.chk_Novedad_mod.Name = "chk_Novedad_mod"
        Me.chk_Novedad_mod.Size = New System.Drawing.Size(332, 14)
        Me.chk_Novedad_mod.TabIndex = 14
        Me.chk_Novedad_mod.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 431)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 15)
        Me.Label6.TabIndex = 76
        Me.Label6.Text = "Subir a la Web"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 461)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 15)
        Me.Label5.TabIndex = 77
        Me.Label5.Text = "Novedad"
        '
        'txt_Descripcion_mod
        '
        Me.txt_Descripcion_mod.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "Descripcion", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_Descripcion_mod.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Descripcion_mod.Location = New System.Drawing.Point(143, 278)
        Me.txt_Descripcion_mod.MaxLength = 255
        Me.txt_Descripcion_mod.Multiline = True
        Me.txt_Descripcion_mod.Name = "txt_Descripcion_mod"
        Me.txt_Descripcion_mod.Size = New System.Drawing.Size(332, 113)
        Me.txt_Descripcion_mod.TabIndex = 11
        '
        'cb_Proveedor_mod
        '
        Me.cb_Proveedor_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_Proveedor_mod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_Proveedor_mod.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ProductoBindingSource, "ProveedoresSeleccionada", True))
        Me.cb_Proveedor_mod.DataSource = Me.ProveedoresBindingSource
        Me.cb_Proveedor_mod.DisplayMember = "Value"
        Me.cb_Proveedor_mod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Proveedor_mod.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cb_Proveedor_mod.FormattingEnabled = True
        Me.cb_Proveedor_mod.Location = New System.Drawing.Point(143, 248)
        Me.cb_Proveedor_mod.Name = "cb_Proveedor_mod"
        Me.cb_Proveedor_mod.Size = New System.Drawing.Size(332, 23)
        Me.cb_Proveedor_mod.TabIndex = 10
        Me.cb_Proveedor_mod.ValueMember = "Key"
        '
        'txt_Nombre_mod
        '
        Me.txt_Nombre_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Nombre_mod.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "Nombre", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_Nombre_mod.Location = New System.Drawing.Point(143, 4)
        Me.txt_Nombre_mod.MaxLength = 255
        Me.txt_Nombre_mod.Name = "txt_Nombre_mod"
        Me.txt_Nombre_mod.Size = New System.Drawing.Size(332, 21)
        Me.txt_Nombre_mod.TabIndex = 1
        '
        'txt_Origen_mod
        '
        Me.txt_Origen_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Origen_mod.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "Origen", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_Origen_mod.Location = New System.Drawing.Point(143, 34)
        Me.txt_Origen_mod.MaxLength = 255
        Me.txt_Origen_mod.Name = "txt_Origen_mod"
        Me.txt_Origen_mod.Size = New System.Drawing.Size(332, 21)
        Me.txt_Origen_mod.TabIndex = 2
        '
        'txt_Tamano_mod
        '
        Me.txt_Tamano_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Tamano_mod.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "Tamanio", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_Tamano_mod.Location = New System.Drawing.Point(143, 64)
        Me.txt_Tamano_mod.MaxLength = 255
        Me.txt_Tamano_mod.Name = "txt_Tamano_mod"
        Me.txt_Tamano_mod.Size = New System.Drawing.Size(332, 21)
        Me.txt_Tamano_mod.TabIndex = 3
        '
        'txt_Codigo_mod
        '
        Me.txt_Codigo_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Codigo_mod.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "Codigo", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.txt_Codigo_mod.Location = New System.Drawing.Point(143, 94)
        Me.txt_Codigo_mod.MaxLength = 255
        Me.txt_Codigo_mod.Name = "txt_Codigo_mod"
        Me.txt_Codigo_mod.Size = New System.Drawing.Size(332, 21)
        Me.txt_Codigo_mod.TabIndex = 4
        '
        'cb_Subcategoria_mod
        '
        Me.cb_Subcategoria_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_Subcategoria_mod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_Subcategoria_mod.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ProductoBindingSource, "SubcategoriasSeleccionada", True))
        Me.cb_Subcategoria_mod.DataSource = Me.SubcategoriasBindingSource
        Me.cb_Subcategoria_mod.DisplayMember = "Value"
        Me.cb_Subcategoria_mod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Subcategoria_mod.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cb_Subcategoria_mod.FormattingEnabled = True
        Me.cb_Subcategoria_mod.Location = New System.Drawing.Point(143, 218)
        Me.cb_Subcategoria_mod.Name = "cb_Subcategoria_mod"
        Me.cb_Subcategoria_mod.Size = New System.Drawing.Size(332, 23)
        Me.cb_Subcategoria_mod.TabIndex = 9
        Me.cb_Subcategoria_mod.ValueMember = "Key"
        '
        'cb_Categoria_mod
        '
        Me.cb_Categoria_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_Categoria_mod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_Categoria_mod.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ProductoBindingSource, "CategoriasSeleccionada", True))
        Me.cb_Categoria_mod.DataSource = Me.CategoriasBindingSource
        Me.cb_Categoria_mod.DisplayMember = "Value"
        Me.cb_Categoria_mod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Categoria_mod.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cb_Categoria_mod.FormattingEnabled = True
        Me.cb_Categoria_mod.Location = New System.Drawing.Point(143, 188)
        Me.cb_Categoria_mod.Name = "cb_Categoria_mod"
        Me.cb_Categoria_mod.Size = New System.Drawing.Size(332, 23)
        Me.cb_Categoria_mod.TabIndex = 8
        Me.cb_Categoria_mod.ValueMember = "Key"
        '
        'TableLayoutPanel14
        '
        Me.TableLayoutPanel14.ColumnCount = 1
        Me.TableLayoutPanel14.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel14.Controls.Add(Me.TableLayoutPanel12, 0, 0)
        Me.TableLayoutPanel14.Controls.Add(Me.Gb_Precios_mod, 0, 1)
        Me.TableLayoutPanel14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel14.Location = New System.Drawing.Point(487, 3)
        Me.TableLayoutPanel14.Name = "TableLayoutPanel14"
        Me.TableLayoutPanel14.RowCount = 2
        Me.TableLayoutPanel14.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel14.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 216.0!))
        Me.TableLayoutPanel14.Size = New System.Drawing.Size(478, 484)
        Me.TableLayoutPanel14.TabIndex = 15
        '
        'TableLayoutPanel12
        '
        Me.TableLayoutPanel12.ColumnCount = 2
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel12.Controls.Add(Me.pb_CodigoBarra, 0, 0)
        Me.TableLayoutPanel12.Controls.Add(Me.pb_foto_mod, 1, 0)
        Me.TableLayoutPanel12.Controls.Add(Me.Ck_EliminarFoto, 1, 1)
        Me.TableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel12.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel12.Name = "TableLayoutPanel12"
        Me.TableLayoutPanel12.RowCount = 2
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel12.Size = New System.Drawing.Size(472, 262)
        Me.TableLayoutPanel12.TabIndex = 15
        '
        'pb_CodigoBarra
        '
        Me.pb_CodigoBarra.BackColor = System.Drawing.Color.White
        Me.pb_CodigoBarra.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.ProductoBindingSource, "CodigoBarrasImagen", True))
        Me.pb_CodigoBarra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pb_CodigoBarra.Location = New System.Drawing.Point(3, 3)
        Me.pb_CodigoBarra.Name = "pb_CodigoBarra"
        Me.pb_CodigoBarra.Size = New System.Drawing.Size(230, 231)
        Me.pb_CodigoBarra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_CodigoBarra.TabIndex = 81
        Me.pb_CodigoBarra.TabStop = False
        '
        'pb_foto_mod
        '
        Me.pb_foto_mod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pb_foto_mod.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.ProductoBindingSource, "Foto", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.pb_foto_mod.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pb_foto_mod.Image = Global.SistemaCinderella.My.Resources.Recursos.Sinfoto
        Me.pb_foto_mod.InitialImage = Nothing
        Me.pb_foto_mod.Location = New System.Drawing.Point(239, 3)
        Me.pb_foto_mod.Name = "pb_foto_mod"
        Me.pb_foto_mod.Size = New System.Drawing.Size(230, 231)
        Me.pb_foto_mod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_foto_mod.TabIndex = 70
        Me.pb_foto_mod.TabStop = False
        '
        'Ck_EliminarFoto
        '
        Me.Ck_EliminarFoto.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Ck_EliminarFoto.AutoSize = True
        Me.Ck_EliminarFoto.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.ProductoBindingSource, "EliminarFoto", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Ck_EliminarFoto.Location = New System.Drawing.Point(239, 240)
        Me.Ck_EliminarFoto.Name = "Ck_EliminarFoto"
        Me.Ck_EliminarFoto.Size = New System.Drawing.Size(230, 19)
        Me.Ck_EliminarFoto.TabIndex = 15
        Me.Ck_EliminarFoto.Text = "Eliminar Foto"
        Me.Ck_EliminarFoto.UseVisualStyleBackColor = True
        '
        'Gb_Precios_mod
        '
        Me.Gb_Precios_mod.Controls.Add(Me.TableLayoutPanel10)
        Me.Gb_Precios_mod.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Gb_Precios_mod.Location = New System.Drawing.Point(3, 271)
        Me.Gb_Precios_mod.Name = "Gb_Precios_mod"
        Me.Gb_Precios_mod.Size = New System.Drawing.Size(472, 210)
        Me.Gb_Precios_mod.TabIndex = 16
        Me.Gb_Precios_mod.TabStop = False
        Me.Gb_Precios_mod.Text = "Listas de Precios"
        '
        'TableLayoutPanel10
        '
        Me.TableLayoutPanel10.ColumnCount = 2
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel10.Controls.Add(Me.txt_Precio6_mod, 1, 5)
        Me.TableLayoutPanel10.Controls.Add(Me.Label22, 0, 5)
        Me.TableLayoutPanel10.Controls.Add(Me.txt_Precio5_mod, 1, 4)
        Me.TableLayoutPanel10.Controls.Add(Me.txt_Precio4_mod, 1, 3)
        Me.TableLayoutPanel10.Controls.Add(Me.Label19, 0, 0)
        Me.TableLayoutPanel10.Controls.Add(Me.Label20, 0, 1)
        Me.TableLayoutPanel10.Controls.Add(Me.txt_Precio3_mod, 1, 2)
        Me.TableLayoutPanel10.Controls.Add(Me.txt_Precio2_mod, 1, 1)
        Me.TableLayoutPanel10.Controls.Add(Me.Label17, 0, 4)
        Me.TableLayoutPanel10.Controls.Add(Me.Label21, 0, 2)
        Me.TableLayoutPanel10.Controls.Add(Me.txt_Precio1_mod, 1, 0)
        Me.TableLayoutPanel10.Controls.Add(Me.Label18, 0, 3)
        Me.TableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel10.Location = New System.Drawing.Point(3, 17)
        Me.TableLayoutPanel10.Name = "TableLayoutPanel10"
        Me.TableLayoutPanel10.RowCount = 6
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel10.Size = New System.Drawing.Size(466, 190)
        Me.TableLayoutPanel10.TabIndex = 16
        '
        'txt_Precio6_mod
        '
        Me.txt_Precio6_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Precio6_mod.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "Alternativo", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.txt_Precio6_mod.Location = New System.Drawing.Point(143, 159)
        Me.txt_Precio6_mod.Name = "txt_Precio6_mod"
        Me.txt_Precio6_mod.Size = New System.Drawing.Size(320, 21)
        Me.txt_Precio6_mod.TabIndex = 21
        Me.txt_Precio6_mod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label22
        '
        Me.Label22.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(3, 162)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(134, 15)
        Me.Label22.TabIndex = 53
        Me.Label22.Text = "Alternativa (*)"
        '
        'txt_Precio5_mod
        '
        Me.txt_Precio5_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Precio5_mod.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "Mayorista", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.txt_Precio5_mod.Location = New System.Drawing.Point(143, 124)
        Me.txt_Precio5_mod.Name = "txt_Precio5_mod"
        Me.txt_Precio5_mod.Size = New System.Drawing.Size(320, 21)
        Me.txt_Precio5_mod.TabIndex = 20
        Me.txt_Precio5_mod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_Precio4_mod
        '
        Me.txt_Precio4_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Precio4_mod.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "PorcentajeDescuentoCapital", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "P"))
        Me.txt_Precio4_mod.Location = New System.Drawing.Point(143, 94)
        Me.txt_Precio4_mod.Name = "txt_Precio4_mod"
        Me.txt_Precio4_mod.Size = New System.Drawing.Size(320, 21)
        Me.txt_Precio4_mod.TabIndex = 19
        Me.txt_Precio4_mod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(3, 7)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(134, 15)
        Me.Label19.TabIndex = 47
        Me.Label19.Text = "Lista Tigre (*)"
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(3, 37)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(134, 15)
        Me.Label20.TabIndex = 48
        Me.Label20.Text = "% Desc. Tigre (*)"
        '
        'txt_Precio3_mod
        '
        Me.txt_Precio3_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Precio3_mod.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "ListaCapital", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.txt_Precio3_mod.Location = New System.Drawing.Point(143, 64)
        Me.txt_Precio3_mod.Name = "txt_Precio3_mod"
        Me.txt_Precio3_mod.Size = New System.Drawing.Size(320, 21)
        Me.txt_Precio3_mod.TabIndex = 18
        Me.txt_Precio3_mod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_Precio2_mod
        '
        Me.txt_Precio2_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Precio2_mod.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "PorcentajeDescuentoTigre", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "P"))
        Me.txt_Precio2_mod.Location = New System.Drawing.Point(143, 34)
        Me.txt_Precio2_mod.Name = "txt_Precio2_mod"
        Me.txt_Precio2_mod.Size = New System.Drawing.Size(320, 21)
        Me.txt_Precio2_mod.TabIndex = 17
        Me.txt_Precio2_mod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(3, 127)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(134, 15)
        Me.Label17.TabIndex = 50
        Me.Label17.Text = "Mayorista (*)"
        '
        'Label21
        '
        Me.Label21.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(3, 67)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(134, 15)
        Me.Label21.TabIndex = 49
        Me.Label21.Text = "Lista Capital (*)"
        '
        'txt_Precio1_mod
        '
        Me.txt_Precio1_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Precio1_mod.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "ListaTigre", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.txt_Precio1_mod.Location = New System.Drawing.Point(143, 4)
        Me.txt_Precio1_mod.Name = "txt_Precio1_mod"
        Me.txt_Precio1_mod.Size = New System.Drawing.Size(320, 21)
        Me.txt_Precio1_mod.TabIndex = 16
        Me.txt_Precio1_mod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(3, 97)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(134, 15)
        Me.Label18.TabIndex = 51
        Me.Label18.Text = "% Desc. Capital (*)"
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Cancelar.Image = Global.SistemaCinderella.My.Resources.Recursos.desconectado_32
        Me.Btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Cancelar.Location = New System.Drawing.Point(662, 516)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Cancelar.TabIndex = 24
        Me.Btn_Cancelar.Text = "Cancelar"
        Me.Btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolProd.SetToolTip(Me.Btn_Cancelar, "Descarta los cambios y vuelve al listado de productos")
        Me.Btn_Cancelar.UseVisualStyleBackColor = True
        '
        'Label26
        '
        Me.Label26.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(6, 516)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(117, 13)
        Me.Label26.TabIndex = 86
        Me.Label26.Text = "(*) Campos obligatorios."
        '
        'Btn_Eliminar
        '
        Me.Btn_Eliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Eliminar.Image = Global.SistemaCinderella.My.Resources.Recursos.Limpiar_32
        Me.Btn_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Eliminar.Location = New System.Drawing.Point(768, 517)
        Me.Btn_Eliminar.Name = "Btn_Eliminar"
        Me.Btn_Eliminar.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Eliminar.TabIndex = 23
        Me.Btn_Eliminar.Text = "Eliminar"
        Me.Btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolProd.SetToolTip(Me.Btn_Eliminar, "Elimina el producto del sistema.")
        Me.Btn_Eliminar.UseVisualStyleBackColor = True
        '
        'btn_Modificar
        '
        Me.btn_Modificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Modificar.BackColor = System.Drawing.Color.Transparent
        Me.btn_Modificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Modificar.Image = Global.SistemaCinderella.My.Resources.Recursos.Editar_24
        Me.btn_Modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Modificar.Location = New System.Drawing.Point(874, 516)
        Me.btn_Modificar.Name = "btn_Modificar"
        Me.btn_Modificar.Size = New System.Drawing.Size(100, 40)
        Me.btn_Modificar.TabIndex = 22
        Me.btn_Modificar.Text = "Modificar"
        Me.btn_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolProd.SetToolTip(Me.btn_Modificar, "Modifica el producto en el sistema.")
        Me.btn_Modificar.UseVisualStyleBackColor = False
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        '
        'OrigenDataGridViewTextBoxColumn
        '
        Me.OrigenDataGridViewTextBoxColumn.Name = "OrigenDataGridViewTextBoxColumn"
        '
        'TamanioDataGridViewTextBoxColumn
        '
        Me.TamanioDataGridViewTextBoxColumn.Name = "TamanioDataGridViewTextBoxColumn"
        '
        'CodigoDataGridViewTextBoxColumn
        '
        Me.CodigoDataGridViewTextBoxColumn.Name = "CodigoDataGridViewTextBoxColumn"
        '
        'CostoDataGridViewTextBoxColumn
        '
        Me.CostoDataGridViewTextBoxColumn.Name = "CostoDataGridViewTextBoxColumn"
        '
        'FotoRutaDataGridViewTextBoxColumn
        '
        Me.FotoRutaDataGridViewTextBoxColumn.Name = "FotoRutaDataGridViewTextBoxColumn"
        '
        'CategoriasSeleccionadaDataGridViewTextBoxColumn
        '
        Me.CategoriasSeleccionadaDataGridViewTextBoxColumn.Name = "CategoriasSeleccionadaDataGridViewTextBoxColumn"
        '
        'SubcategoriasSeleccionadaDataGridViewTextBoxColumn
        '
        Me.SubcategoriasSeleccionadaDataGridViewTextBoxColumn.Name = "SubcategoriasSeleccionadaDataGridViewTextBoxColumn"
        '
        'ProveedoresSeleccionadaDataGridViewTextBoxColumn
        '
        Me.ProveedoresSeleccionadaDataGridViewTextBoxColumn.Name = "ProveedoresSeleccionadaDataGridViewTextBoxColumn"
        '
        'ListaTigreDataGridViewTextBoxColumn
        '
        Me.ListaTigreDataGridViewTextBoxColumn.Name = "ListaTigreDataGridViewTextBoxColumn"
        '
        'PorcentajeDescuentoTigreDataGridViewTextBoxColumn
        '
        Me.PorcentajeDescuentoTigreDataGridViewTextBoxColumn.Name = "PorcentajeDescuentoTigreDataGridViewTextBoxColumn"
        '
        'ListaCapitalDataGridViewTextBoxColumn
        '
        Me.ListaCapitalDataGridViewTextBoxColumn.Name = "ListaCapitalDataGridViewTextBoxColumn"
        '
        'PorcentajeDescuentoCapitalDataGridViewTextBoxColumn
        '
        Me.PorcentajeDescuentoCapitalDataGridViewTextBoxColumn.Name = "PorcentajeDescuentoCapitalDataGridViewTextBoxColumn"
        '
        'MayoristaDataGridViewTextBoxColumn
        '
        Me.MayoristaDataGridViewTextBoxColumn.Name = "MayoristaDataGridViewTextBoxColumn"
        '
        'AlternativoDataGridViewTextBoxColumn
        '
        Me.AlternativoDataGridViewTextBoxColumn.Name = "AlternativoDataGridViewTextBoxColumn"
        '
        'Cargar
        '
        Me.Cargar.FileName = "Cargar"
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
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administración de Productos"
        Me.TabProductos.ResumeLayout(False)
        Me.TbListado.ResumeLayout(False)
        Me.GB_Buscar.ResumeLayout(False)
        Me.GB_Buscar.PerformLayout()
        CType(Me.DG_Productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TbAlta.ResumeLayout(False)
        Me.GB_Alta.ResumeLayout(False)
        Me.GB_Alta.PerformLayout()
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubcategoriasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel6.ResumeLayout(False)
        CType(Me.pb_foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_Precios.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TbMod.ResumeLayout(False)
        Me.GB_Modificacion.ResumeLayout(False)
        Me.GB_Modificacion.PerformLayout()
        Me.TableLayoutPanel15.ResumeLayout(False)
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel8.PerformLayout()
        Me.TableLayoutPanel9.ResumeLayout(False)
        Me.TableLayoutPanel9.PerformLayout()
        Me.TableLayoutPanel14.ResumeLayout(False)
        Me.TableLayoutPanel12.ResumeLayout(False)
        Me.TableLayoutPanel12.PerformLayout()
        CType(Me.pb_CodigoBarra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_foto_mod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gb_Precios_mod.ResumeLayout(False)
        Me.TableLayoutPanel10.ResumeLayout(False)
        Me.TableLayoutPanel10.PerformLayout()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btn_Modificar As System.Windows.Forms.Button
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
    Friend WithEvents pb_foto As System.Windows.Forms.PictureBox
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
    Friend WithEvents Btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_Exportar As System.Windows.Forms.Button
    Friend WithEvents btn_Importar As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btn_Restore As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel10 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel15 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel14 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel12 As TableLayoutPanel
    Friend WithEvents ProductoBindingSource As BindingSource
    Friend WithEvents ProveedoresBindingSource As BindingSource
    Friend WithEvents SubcategoriasBindingSource As BindingSource
    Friend WithEvents CategoriasBindingSource As BindingSource
    Friend WithEvents ProductosBindingSource As BindingSource
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrigenDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TamanioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodigoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CostoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FotoRutaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoriasSeleccionadaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SubcategoriasSeleccionadaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProveedoresSeleccionadaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ListaTigreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PorcentajeDescuentoTigreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ListaCapitalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PorcentajeDescuentoCapitalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MayoristaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AlternativoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents id_Producto As DataGridViewTextBoxColumn
    Friend WithEvents Categoria As DataGridViewTextBoxColumn
    Friend WithEvents Subcategoria As DataGridViewTextBoxColumn
    Friend WithEvents Proveedor As DataGridViewTextBoxColumn
    Friend WithEvents precio1 As DataGridViewTextBoxColumn
    Friend WithEvents precio2 As DataGridViewTextBoxColumn
    Friend WithEvents precio3 As DataGridViewTextBoxColumn
    Friend WithEvents precio4 As DataGridViewTextBoxColumn
    Friend WithEvents precio5 As DataGridViewTextBoxColumn
    Friend WithEvents precio6 As DataGridViewTextBoxColumn
    Friend WithEvents Habilitado As DataGridViewTextBoxColumn
    Friend WithEvents Modificar As DataGridViewImageColumn
    Friend WithEvents Eliminar As DataGridViewImageColumn
End Class
