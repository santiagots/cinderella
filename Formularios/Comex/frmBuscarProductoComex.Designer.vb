<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBuscarProductoComex

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.FrmBuscarProductoComexViewModelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.SuppliersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TiposProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cb_ListaPrecio = New System.Windows.Forms.ComboBox()
        Me.ColorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_Msg = New System.Windows.Forms.Label()
        Me.Btn_Limpiar = New System.Windows.Forms.Button()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.DG_Productos = New SistemaCinderella.CustomDataGrid()
        Me.SupplierCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QtyOfLightsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BoxSizeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModeloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductSizeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FOBUSDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FOBRMBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InPackingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PackingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UCBMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.FrmBuscarProductoComexViewModelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuppliersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TiposProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_Productos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox1.Controls.Add(Me.lbl_Msg)
        Me.GroupBox1.Controls.Add(Me.Btn_Limpiar)
        Me.GroupBox1.Controls.Add(Me.btn_Buscar)
        Me.GroupBox1.Controls.Add(Me.DG_Productos)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(776, 559)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar Producto"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 8
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox1, 7, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox3, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ComboBox3, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ComboBox1, 7, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cb_ListaPrecio, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 6, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 6, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(13, 20)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(757, 71)
        Me.TableLayoutPanel1.TabIndex = 12
        '
        'txtCodigo
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmBuscarProductoComexViewModelBindingSource, "CantidadLuces", True))
        Me.TextBox1.Location = New System.Drawing.Point(610, 42)
        Me.TextBox1.Name = "txtCodigo"
        Me.TextBox1.Size = New System.Drawing.Size(144, 21)
        Me.TextBox1.TabIndex = 13
        '
        'FrmBuscarProductoComexViewModelBindingSource
        '
        Me.FrmBuscarProductoComexViewModelBindingSource.DataSource = GetType(SistemaCinderella.Formularios.Comex.frmBuscarProductoComexViewModel)
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.SetColumnSpan(Me.TextBox3, 4)
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmBuscarProductoComexViewModelBindingSource, "NombreCodigoProductoBusqueda", True))
        Me.TextBox3.Location = New System.Drawing.Point(93, 42)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(401, 21)
        Me.TextBox3.TabIndex = 1
        '
        'ComboBox3
        '
        Me.ComboBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComboBox3.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.FrmBuscarProductoComexViewModelBindingSource, "SupplierSeleccionado", True))
        Me.ComboBox3.DataSource = Me.SuppliersBindingSource
        Me.ComboBox3.DisplayMember = "Value"
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.Enabled = False
        Me.ComboBox3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ComboBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(93, 6)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(143, 23)
        Me.ComboBox3.TabIndex = 19
        Me.ComboBox3.ValueMember = "Key"
        '
        'SuppliersBindingSource
        '
        Me.SuppliersBindingSource.DataMember = "Suppliers"
        Me.SuppliersBindingSource.DataSource = Me.FrmBuscarProductoComexViewModelBindingSource
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.FrmBuscarProductoComexViewModelBindingSource, "TipoProductoSeleccionado", True))
        Me.ComboBox1.DataSource = Me.TiposProductosBindingSource
        Me.ComboBox1.DisplayMember = "Value"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(610, 6)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(144, 23)
        Me.ComboBox1.TabIndex = 13
        Me.ComboBox1.ValueMember = "Key"
        '
        'TiposProductosBindingSource
        '
        Me.TiposProductosBindingSource.DataMember = "TiposProductos"
        Me.TiposProductosBindingSource.DataSource = Me.FrmBuscarProductoComexViewModelBindingSource
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(262, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 15)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Color"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 15)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Supplier"
        '
        'Cb_ListaPrecio
        '
        Me.Cb_ListaPrecio.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cb_ListaPrecio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cb_ListaPrecio.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.FrmBuscarProductoComexViewModelBindingSource, "ColorSeleccionado", True))
        Me.Cb_ListaPrecio.DataSource = Me.ColorsBindingSource
        Me.Cb_ListaPrecio.DisplayMember = "Value"
        Me.Cb_ListaPrecio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_ListaPrecio.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Cb_ListaPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_ListaPrecio.FormattingEnabled = True
        Me.Cb_ListaPrecio.Location = New System.Drawing.Point(352, 6)
        Me.Cb_ListaPrecio.Name = "Cb_ListaPrecio"
        Me.Cb_ListaPrecio.Size = New System.Drawing.Size(142, 23)
        Me.Cb_ListaPrecio.TabIndex = 17
        Me.Cb_ListaPrecio.ValueMember = "Key"
        '
        'ColorsBindingSource
        '
        Me.ColorsBindingSource.DataMember = "Colors"
        Me.ColorsBindingSource.DataSource = Me.FrmBuscarProductoComexViewModelBindingSource
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(520, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 15)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Product Type"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(520, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 15)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Qty of Lights"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 45)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 15)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Nombre"
        '
        'lbl_Msg
        '
        Me.lbl_Msg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Msg.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lbl_Msg.DataBindings.Add(New System.Windows.Forms.Binding("Visible", Me.FrmBuscarProductoComexViewModelBindingSource, "SinResultados", True))
        Me.lbl_Msg.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Msg.Location = New System.Drawing.Point(82, 313)
        Me.lbl_Msg.Name = "lbl_Msg"
        Me.lbl_Msg.Size = New System.Drawing.Size(605, 89)
        Me.lbl_Msg.TabIndex = 11
        Me.lbl_Msg.Text = "No se han encontrado productos."
        Me.lbl_Msg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Btn_Limpiar
        '
        Me.Btn_Limpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Limpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Limpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Limpiar.Image = Global.SistemaCinderella.My.Resources.Recursos.desconectado_32
        Me.Btn_Limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Limpiar.Location = New System.Drawing.Point(584, 97)
        Me.Btn_Limpiar.Name = "Btn_Limpiar"
        Me.Btn_Limpiar.Size = New System.Drawing.Size(90, 40)
        Me.Btn_Limpiar.TabIndex = 8
        Me.Btn_Limpiar.Text = "Limpiar"
        Me.Btn_Limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Limpiar.UseVisualStyleBackColor = True
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Buscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Buscar.Image = Global.SistemaCinderella.My.Resources.Recursos.IconoBuscar32
        Me.btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Buscar.Location = New System.Drawing.Point(680, 97)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(90, 40)
        Me.btn_Buscar.TabIndex = 2
        Me.btn_Buscar.Text = "Buscar"
        Me.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'DG_Productos
        '
        Me.DG_Productos.AllowUserToAddRows = False
        Me.DG_Productos.AllowUserToDeleteRows = False
        Me.DG_Productos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_Productos.AutoGenerateColumns = False
        Me.DG_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Productos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SupplierCodeDataGridViewTextBoxColumn, Me.ProductTypeDataGridViewTextBoxColumn, Me.QtyOfLightsDataGridViewTextBoxColumn, Me.BoxSizeDataGridViewTextBoxColumn, Me.CodigoDataGridViewTextBoxColumn, Me.ModeloDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.ColorDataGridViewTextBoxColumn, Me.ProductSizeDataGridViewTextBoxColumn, Me.FOBUSDDataGridViewTextBoxColumn, Me.FOBRMBDataGridViewTextBoxColumn, Me.InPackingDataGridViewTextBoxColumn, Me.PackingDataGridViewTextBoxColumn, Me.UCBMDataGridViewTextBoxColumn})
        Me.DG_Productos.DataSource = Me.ProductosBindingSource
        Me.DG_Productos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DG_Productos.Location = New System.Drawing.Point(13, 143)
        Me.DG_Productos.Name = "DG_Productos"
        Me.DG_Productos.RowHeadersVisible = False
        Me.DG_Productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Productos.Size = New System.Drawing.Size(754, 410)
        Me.DG_Productos.TabIndex = 13
        '
        'SupplierCodeDataGridViewTextBoxColumn
        '
        Me.SupplierCodeDataGridViewTextBoxColumn.DataPropertyName = "SupplierCode"
        Me.SupplierCodeDataGridViewTextBoxColumn.HeaderText = "SupplierCode"
        Me.SupplierCodeDataGridViewTextBoxColumn.Name = "SupplierCodeDataGridViewTextBoxColumn"
        Me.SupplierCodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductTypeDataGridViewTextBoxColumn
        '
        Me.ProductTypeDataGridViewTextBoxColumn.DataPropertyName = "ProductType"
        Me.ProductTypeDataGridViewTextBoxColumn.HeaderText = "ProductType"
        Me.ProductTypeDataGridViewTextBoxColumn.Name = "ProductTypeDataGridViewTextBoxColumn"
        Me.ProductTypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'QtyOfLightsDataGridViewTextBoxColumn
        '
        Me.QtyOfLightsDataGridViewTextBoxColumn.DataPropertyName = "QtyOfLights"
        Me.QtyOfLightsDataGridViewTextBoxColumn.HeaderText = "QtyOfLights"
        Me.QtyOfLightsDataGridViewTextBoxColumn.Name = "QtyOfLightsDataGridViewTextBoxColumn"
        Me.QtyOfLightsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BoxSizeDataGridViewTextBoxColumn
        '
        Me.BoxSizeDataGridViewTextBoxColumn.DataPropertyName = "BoxSize"
        Me.BoxSizeDataGridViewTextBoxColumn.HeaderText = "BoxSize"
        Me.BoxSizeDataGridViewTextBoxColumn.Name = "BoxSizeDataGridViewTextBoxColumn"
        Me.BoxSizeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CodigoDataGridViewTextBoxColumn
        '
        Me.CodigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.Name = "CodigoDataGridViewTextBoxColumn"
        Me.CodigoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ModeloDataGridViewTextBoxColumn
        '
        Me.ModeloDataGridViewTextBoxColumn.DataPropertyName = "Modelo"
        Me.ModeloDataGridViewTextBoxColumn.HeaderText = "Modelo"
        Me.ModeloDataGridViewTextBoxColumn.Name = "ModeloDataGridViewTextBoxColumn"
        Me.ModeloDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ColorDataGridViewTextBoxColumn
        '
        Me.ColorDataGridViewTextBoxColumn.DataPropertyName = "Color"
        Me.ColorDataGridViewTextBoxColumn.HeaderText = "Color"
        Me.ColorDataGridViewTextBoxColumn.Name = "ColorDataGridViewTextBoxColumn"
        Me.ColorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductSizeDataGridViewTextBoxColumn
        '
        Me.ProductSizeDataGridViewTextBoxColumn.DataPropertyName = "ProductSize"
        Me.ProductSizeDataGridViewTextBoxColumn.HeaderText = "ProductSize"
        Me.ProductSizeDataGridViewTextBoxColumn.Name = "ProductSizeDataGridViewTextBoxColumn"
        Me.ProductSizeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FOBUSDDataGridViewTextBoxColumn
        '
        Me.FOBUSDDataGridViewTextBoxColumn.DataPropertyName = "FOBUSD"
        Me.FOBUSDDataGridViewTextBoxColumn.HeaderText = "FOBUSD"
        Me.FOBUSDDataGridViewTextBoxColumn.Name = "FOBUSDDataGridViewTextBoxColumn"
        Me.FOBUSDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FOBRMBDataGridViewTextBoxColumn
        '
        Me.FOBRMBDataGridViewTextBoxColumn.DataPropertyName = "FOBRMB"
        Me.FOBRMBDataGridViewTextBoxColumn.HeaderText = "FOBRMB"
        Me.FOBRMBDataGridViewTextBoxColumn.Name = "FOBRMBDataGridViewTextBoxColumn"
        Me.FOBRMBDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InPackingDataGridViewTextBoxColumn
        '
        Me.InPackingDataGridViewTextBoxColumn.DataPropertyName = "InPacking"
        Me.InPackingDataGridViewTextBoxColumn.HeaderText = "InPacking"
        Me.InPackingDataGridViewTextBoxColumn.Name = "InPackingDataGridViewTextBoxColumn"
        Me.InPackingDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PackingDataGridViewTextBoxColumn
        '
        Me.PackingDataGridViewTextBoxColumn.DataPropertyName = "Packing"
        Me.PackingDataGridViewTextBoxColumn.HeaderText = "Packing"
        Me.PackingDataGridViewTextBoxColumn.Name = "PackingDataGridViewTextBoxColumn"
        Me.PackingDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UCBMDataGridViewTextBoxColumn
        '
        Me.UCBMDataGridViewTextBoxColumn.DataPropertyName = "UCBM"
        Me.UCBMDataGridViewTextBoxColumn.HeaderText = "UCBM"
        Me.UCBMDataGridViewTextBoxColumn.Name = "UCBMDataGridViewTextBoxColumn"
        Me.UCBMDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "Productos"
        Me.ProductosBindingSource.DataSource = Me.FrmBuscarProductoComexViewModelBindingSource
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_Producto"
        Me.DataGridViewTextBoxColumn1.FillWeight = 47.63173!
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 123
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn2.FillWeight = 169.4452!
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 437
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Codigo"
        Me.DataGridViewTextBoxColumn3.FillWeight = 61.09564!
        Me.DataGridViewTextBoxColumn3.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 158
        '
        'frmBuscarProductoComex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 583)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmBuscarProductoComex"
        Me.Text = "frmBuscarProductoComex"
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.FrmBuscarProductoComexViewModelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuppliersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TiposProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_Productos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbl_Msg As Label
    Friend WithEvents Btn_Limpiar As Button
    Friend WithEvents btn_Buscar As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Cb_ListaPrecio As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents FrmBuscarProductoComexViewModelBindingSource As BindingSource
    Friend WithEvents SuppliersBindingSource As BindingSource
    Friend WithEvents TiposProductosBindingSource As BindingSource
    Friend WithEvents ColorsBindingSource As BindingSource
    Friend WithEvents ProductosBindingSource As BindingSource
    Friend WithEvents SupplierCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QtyOfLightsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BoxSizeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodigoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ModeloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ColorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductSizeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FOBUSDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalUSDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FOBRMBDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalRMBDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InPackingDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PackingDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BoxQTYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalPCSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UCBMDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalCBMDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DG_Productos As CustomDataGrid
End Class
