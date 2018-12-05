<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStock
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStock))
        Me.TabStock = New System.Windows.Forms.TabControl()
        Me.TabListado = New System.Windows.Forms.TabPage()
        Me.lbl_Msg = New System.Windows.Forms.Label()
        Me.GB_Buscar = New System.Windows.Forms.GroupBox()
        Me.btn_Importar = New System.Windows.Forms.Button()
        Me.btn_Exportar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.rb_Opcion = New System.Windows.Forms.RadioButton()
        Me.rb_Opcion2 = New System.Windows.Forms.RadioButton()
        Me.Cb_Sucursal = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_buscar = New System.Windows.Forms.TextBox()
        Me.btn_Restablecer = New System.Windows.Forms.Button()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.DG_Stock = New System.Windows.Forms.DataGridView()
        Me.id_Stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODUCTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Minimo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Actual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Optimo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VentaMensual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sucursal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Modificado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Modificar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Eliminar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TabAlta = New System.Windows.Forms.TabPage()
        Me.GB_Alta = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_ventaMensual = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.Btn_BuscarCodigo = New System.Windows.Forms.Button()
        Me.txt_Codigo = New System.Windows.Forms.TextBox()
        Me.lbl_Sucursal = New System.Windows.Forms.Label()
        Me.Cb_Sucursales = New System.Windows.Forms.ComboBox()
        Me.lbl_Producto = New System.Windows.Forms.Label()
        Me.lbl_Minimo = New System.Windows.Forms.Label()
        Me.lbl_Optimo = New System.Windows.Forms.Label()
        Me.lbl_Actual = New System.Windows.Forms.Label()
        Me.txt_Minimo = New System.Windows.Forms.TextBox()
        Me.txt_Optimo = New System.Windows.Forms.TextBox()
        Me.txt_Actual = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.chk_Habilitado = New System.Windows.Forms.CheckBox()
        Me.Btn_Agregar = New System.Windows.Forms.Button()
        Me.TabModificacion = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel9 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_ventaMensual_mod = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_Codigo_mod = New System.Windows.Forms.TextBox()
        Me.Btn_BuscarCodigo_mod = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_Codigo = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Cb_Sucursales_mod = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_Actual_mod = New System.Windows.Forms.TextBox()
        Me.txt_Minimo_mod = New System.Windows.Forms.TextBox()
        Me.txt_Optimo_mod = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chk_Habilitado_mod = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel10 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_Motivo = New System.Windows.Forms.TextBox()
        Me.lbl_Usuario2 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lbl_Fecha2 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Gb_Mod = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_Motivo = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbl_Usuario = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl_Fecha = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Btn_Eliminar = New System.Windows.Forms.Button()
        Me.Btn_Modificar = New System.Windows.Forms.Button()
        Me.ErrorStock = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolStock = New System.Windows.Forms.ToolTip(Me.components)
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.TabStock.SuspendLayout()
        Me.TabListado.SuspendLayout()
        Me.GB_Buscar.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.DG_Stock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabAlta.SuspendLayout()
        Me.GB_Alta.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TabModificacion.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel9.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TableLayoutPanel10.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.Gb_Mod.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        CType(Me.ErrorStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabStock
        '
        Me.TabStock.Controls.Add(Me.TabListado)
        Me.TabStock.Controls.Add(Me.TabAlta)
        Me.TabStock.Controls.Add(Me.TabModificacion)
        Me.TabStock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabStock.Location = New System.Drawing.Point(0, 0)
        Me.TabStock.Name = "TabStock"
        Me.TabStock.SelectedIndex = 0
        Me.TabStock.Size = New System.Drawing.Size(1006, 610)
        Me.TabStock.TabIndex = 0
        '
        'TabListado
        '
        Me.TabListado.Controls.Add(Me.lbl_Msg)
        Me.TabListado.Controls.Add(Me.GB_Buscar)
        Me.TabListado.Controls.Add(Me.DG_Stock)
        Me.TabListado.Location = New System.Drawing.Point(4, 29)
        Me.TabListado.Name = "TabListado"
        Me.TabListado.Padding = New System.Windows.Forms.Padding(3)
        Me.TabListado.Size = New System.Drawing.Size(998, 577)
        Me.TabListado.TabIndex = 0
        Me.TabListado.Text = "Stock"
        Me.TabListado.UseVisualStyleBackColor = True
        '
        'lbl_Msg
        '
        Me.lbl_Msg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Msg.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lbl_Msg.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Msg.Location = New System.Drawing.Point(112, 253)
        Me.lbl_Msg.Name = "lbl_Msg"
        Me.lbl_Msg.Size = New System.Drawing.Size(770, 167)
        Me.lbl_Msg.TabIndex = 1
        Me.lbl_Msg.Text = "No se ha encontrado stocks cargados."
        Me.lbl_Msg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GB_Buscar
        '
        Me.GB_Buscar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_Buscar.Controls.Add(Me.btn_Importar)
        Me.GB_Buscar.Controls.Add(Me.btn_Exportar)
        Me.GB_Buscar.Controls.Add(Me.TableLayoutPanel1)
        Me.GB_Buscar.Controls.Add(Me.btn_Restablecer)
        Me.GB_Buscar.Controls.Add(Me.btn_Buscar)
        Me.GB_Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Buscar.Location = New System.Drawing.Point(8, 6)
        Me.GB_Buscar.Name = "GB_Buscar"
        Me.GB_Buscar.Size = New System.Drawing.Size(978, 92)
        Me.GB_Buscar.TabIndex = 0
        Me.GB_Buscar.TabStop = False
        Me.GB_Buscar.Text = "Buscar Stock de productos"
        '
        'btn_Importar
        '
        Me.btn_Importar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Importar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Importar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Importar.Image = Global.SistemaCinderella.My.Resources.Recursos.Import_Excel
        Me.btn_Importar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Importar.Location = New System.Drawing.Point(658, 43)
        Me.btn_Importar.Name = "btn_Importar"
        Me.btn_Importar.Size = New System.Drawing.Size(100, 40)
        Me.btn_Importar.TabIndex = 11
        Me.btn_Importar.Text = "Importar"
        Me.btn_Importar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolStock.SetToolTip(Me.btn_Importar, "Haz click aquí para importar el stock. Esta función solo está habilitada para el " &
        "modo Online")
        Me.btn_Importar.UseVisualStyleBackColor = True
        '
        'btn_Exportar
        '
        Me.btn_Exportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Exportar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Exportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Exportar.Image = Global.SistemaCinderella.My.Resources.Recursos.export_excel
        Me.btn_Exportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Exportar.Location = New System.Drawing.Point(552, 43)
        Me.btn_Exportar.Name = "btn_Exportar"
        Me.btn_Exportar.Size = New System.Drawing.Size(100, 40)
        Me.btn_Exportar.TabIndex = 10
        Me.btn_Exportar.Text = "Exportar"
        Me.btn_Exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolStock.SetToolTip(Me.btn_Exportar, "Haz click aquí para exportar el stock. Esta función solo está habilitada para el " &
        "modo Online")
        Me.btn_Exportar.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Cb_Sucursal, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_buscar, 1, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(6, 20)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(540, 63)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.rb_Opcion, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.rb_Opcion2, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 33)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(194, 27)
        Me.TableLayoutPanel2.TabIndex = 3
        '
        'rb_Opcion
        '
        Me.rb_Opcion.AutoSize = True
        Me.rb_Opcion.Checked = True
        Me.rb_Opcion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rb_Opcion.Location = New System.Drawing.Point(3, 3)
        Me.rb_Opcion.Name = "rb_Opcion"
        Me.rb_Opcion.Size = New System.Drawing.Size(70, 19)
        Me.rb_Opcion.TabIndex = 2
        Me.rb_Opcion.TabStop = True
        Me.rb_Opcion.Text = "Nombre"
        Me.rb_Opcion.UseVisualStyleBackColor = True
        '
        'rb_Opcion2
        '
        Me.rb_Opcion2.AutoSize = True
        Me.rb_Opcion2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rb_Opcion2.Location = New System.Drawing.Point(100, 3)
        Me.rb_Opcion2.Name = "rb_Opcion2"
        Me.rb_Opcion2.Size = New System.Drawing.Size(64, 19)
        Me.rb_Opcion2.TabIndex = 3
        Me.rb_Opcion2.Text = "Codigo"
        Me.rb_Opcion2.UseVisualStyleBackColor = True
        '
        'Cb_Sucursal
        '
        Me.Cb_Sucursal.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cb_Sucursal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cb_Sucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Sucursal.Enabled = False
        Me.Cb_Sucursal.FormattingEnabled = True
        Me.Cb_Sucursal.Items.AddRange(New Object() {"Mes Completo", "Primera Quincena", "Segunda Quincena"})
        Me.Cb_Sucursal.Location = New System.Drawing.Point(203, 4)
        Me.Cb_Sucursal.Name = "Cb_Sucursal"
        Me.Cb_Sucursal.Size = New System.Drawing.Size(334, 23)
        Me.Cb_Sucursal.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(194, 15)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Sucursal"
        '
        'txt_buscar
        '
        Me.txt_buscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_buscar.Location = New System.Drawing.Point(203, 36)
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(334, 21)
        Me.txt_buscar.TabIndex = 4
        '
        'btn_Restablecer
        '
        Me.btn_Restablecer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Restablecer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Restablecer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Restablecer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Restablecer.Location = New System.Drawing.Point(764, 43)
        Me.btn_Restablecer.Name = "btn_Restablecer"
        Me.btn_Restablecer.Size = New System.Drawing.Size(100, 40)
        Me.btn_Restablecer.TabIndex = 5
        Me.btn_Restablecer.Text = "Restablecer Filtros"
        Me.ToolStock.SetToolTip(Me.btn_Restablecer, "Haz click aquí para restablecer los filtros y el listado de stocks.")
        Me.btn_Restablecer.UseVisualStyleBackColor = True
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Buscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Buscar.Image = Global.SistemaCinderella.My.Resources.Recursos.IconoBuscar32
        Me.btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Buscar.Location = New System.Drawing.Point(870, 43)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(100, 40)
        Me.btn_Buscar.TabIndex = 6
        Me.btn_Buscar.Text = "Buscar"
        Me.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolStock.SetToolTip(Me.btn_Buscar, "Haz click aquí para buscar stocks con los criterios de busqueda seleccionados.")
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'DG_Stock
        '
        Me.DG_Stock.AllowUserToAddRows = False
        Me.DG_Stock.AllowUserToDeleteRows = False
        Me.DG_Stock.AllowUserToResizeRows = False
        Me.DG_Stock.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_Stock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_Stock.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_Stock, Me.Codigo, Me.PRODUCTO, Me.Categoria, Me.Minimo, Me.Actual, Me.Optimo, Me.VentaMensual, Me.Sucursal, Me.Modificado, Me.Modificar, Me.Eliminar})
        Me.DG_Stock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DG_Stock.Location = New System.Drawing.Point(8, 104)
        Me.DG_Stock.MultiSelect = False
        Me.DG_Stock.Name = "DG_Stock"
        Me.DG_Stock.ReadOnly = True
        Me.DG_Stock.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DG_Stock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Stock.Size = New System.Drawing.Size(978, 465)
        Me.DG_Stock.TabIndex = 0
        '
        'id_Stock
        '
        Me.id_Stock.DataPropertyName = "id_Stock"
        Me.id_Stock.FillWeight = 145.4872!
        Me.id_Stock.HeaderText = "ID"
        Me.id_Stock.Name = "id_Stock"
        Me.id_Stock.ReadOnly = True
        Me.id_Stock.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Codigo
        '
        Me.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Codigo.DataPropertyName = "Codigo"
        Me.Codigo.FillWeight = 145.4872!
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        Me.Codigo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Codigo.Width = 65
        '
        'PRODUCTO
        '
        Me.PRODUCTO.DataPropertyName = "Nombre"
        Me.PRODUCTO.FillWeight = 145.4872!
        Me.PRODUCTO.HeaderText = "Producto"
        Me.PRODUCTO.Name = "PRODUCTO"
        Me.PRODUCTO.ReadOnly = True
        Me.PRODUCTO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Categoria
        '
        Me.Categoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Categoria.DataPropertyName = "Cat"
        Me.Categoria.FillWeight = 145.4872!
        Me.Categoria.HeaderText = "Categoria"
        Me.Categoria.Name = "Categoria"
        Me.Categoria.ReadOnly = True
        Me.Categoria.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Categoria.Width = 84
        '
        'Minimo
        '
        Me.Minimo.DataPropertyName = "Stock_Minimo"
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = "0"
        Me.Minimo.DefaultCellStyle = DataGridViewCellStyle1
        Me.Minimo.FillWeight = 68.06424!
        Me.Minimo.HeaderText = "Minimo"
        Me.Minimo.Name = "Minimo"
        Me.Minimo.ReadOnly = True
        Me.Minimo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Actual
        '
        Me.Actual.DataPropertyName = "Stock_Actual"
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = "0"
        Me.Actual.DefaultCellStyle = DataGridViewCellStyle2
        Me.Actual.FillWeight = 66.77616!
        Me.Actual.HeaderText = "Actual"
        Me.Actual.Name = "Actual"
        Me.Actual.ReadOnly = True
        Me.Actual.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Optimo
        '
        Me.Optimo.DataPropertyName = "Stock_Optimo"
        DataGridViewCellStyle3.Format = "N0"
        DataGridViewCellStyle3.NullValue = "0"
        Me.Optimo.DefaultCellStyle = DataGridViewCellStyle3
        Me.Optimo.FillWeight = 65.48048!
        Me.Optimo.HeaderText = "Optimo"
        Me.Optimo.Name = "Optimo"
        Me.Optimo.ReadOnly = True
        Me.Optimo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'VentaMensual
        '
        Me.VentaMensual.DataPropertyName = "Venta_Mensual"
        Me.VentaMensual.HeaderText = "Vta. Mensual"
        Me.VentaMensual.Name = "VentaMensual"
        Me.VentaMensual.ReadOnly = True
        '
        'Sucursal
        '
        Me.Sucursal.DataPropertyName = "Sucursal"
        Me.Sucursal.FillWeight = 105.0265!
        Me.Sucursal.HeaderText = "Sucursal"
        Me.Sucursal.Name = "Sucursal"
        Me.Sucursal.ReadOnly = True
        Me.Sucursal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Modificado
        '
        Me.Modificado.DataPropertyName = "Modificado"
        Me.Modificado.HeaderText = "Modificado"
        Me.Modificado.Name = "Modificado"
        Me.Modificado.ReadOnly = True
        Me.Modificado.Visible = False
        '
        'Modificar
        '
        Me.Modificar.FillWeight = 55.83759!
        Me.Modificar.HeaderText = "Modificar"
        Me.Modificar.Image = Global.SistemaCinderella.My.Resources.Recursos.Boton_Editar
        Me.Modificar.Name = "Modificar"
        Me.Modificar.ReadOnly = True
        Me.Modificar.ToolTipText = "Modificar"
        '
        'Eliminar
        '
        Me.Eliminar.FillWeight = 56.86678!
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Image = Global.SistemaCinderella.My.Resources.Recursos.Boton_Eliminar
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.ToolTipText = "Eliminar"
        '
        'TabAlta
        '
        Me.TabAlta.Controls.Add(Me.GB_Alta)
        Me.TabAlta.Location = New System.Drawing.Point(4, 29)
        Me.TabAlta.Name = "TabAlta"
        Me.TabAlta.Padding = New System.Windows.Forms.Padding(3)
        Me.TabAlta.Size = New System.Drawing.Size(998, 577)
        Me.TabAlta.TabIndex = 1
        Me.TabAlta.Text = "Alta de Stock"
        Me.TabAlta.UseVisualStyleBackColor = True
        '
        'GB_Alta
        '
        Me.GB_Alta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_Alta.Controls.Add(Me.TableLayoutPanel3)
        Me.GB_Alta.Controls.Add(Me.Btn_Agregar)
        Me.GB_Alta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Alta.Location = New System.Drawing.Point(9, 7)
        Me.GB_Alta.Name = "GB_Alta"
        Me.GB_Alta.Size = New System.Drawing.Size(981, 302)
        Me.GB_Alta.TabIndex = 0
        Me.GB_Alta.TabStop = False
        Me.GB_Alta.Text = "Formulario de Alta"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 167.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.txt_ventaMensual, 1, 5)
        Me.TableLayoutPanel3.Controls.Add(Me.Label11, 0, 5)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel5, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.lbl_Sucursal, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Cb_Sucursales, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.lbl_Producto, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.lbl_Minimo, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.lbl_Optimo, 0, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.lbl_Actual, 0, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.txt_Minimo, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.txt_Optimo, 1, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.txt_Actual, 1, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.Label7, 0, 6)
        Me.TableLayoutPanel3.Controls.Add(Me.chk_Habilitado, 1, 6)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(6, 20)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 7
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(969, 210)
        Me.TableLayoutPanel3.TabIndex = 12
        '
        'txt_ventaMensual
        '
        Me.txt_ventaMensual.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_ventaMensual.Location = New System.Drawing.Point(170, 156)
        Me.txt_ventaMensual.Name = "txt_ventaMensual"
        Me.txt_ventaMensual.Size = New System.Drawing.Size(796, 21)
        Me.txt_ventaMensual.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 159)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(161, 15)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Venta Mensual"
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.Btn_BuscarCodigo, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.txt_Codigo, 0, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(170, 33)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(796, 26)
        Me.TableLayoutPanel5.TabIndex = 13
        '
        'Btn_BuscarCodigo
        '
        Me.Btn_BuscarCodigo.Cursor = System.Windows.Forms.Cursors.Help
        Me.Btn_BuscarCodigo.FlatAppearance.BorderSize = 0
        Me.Btn_BuscarCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_BuscarCodigo.Image = Global.SistemaCinderella.My.Resources.Recursos.Lupa
        Me.Btn_BuscarCodigo.Location = New System.Drawing.Point(767, 3)
        Me.Btn_BuscarCodigo.Name = "Btn_BuscarCodigo"
        Me.Btn_BuscarCodigo.Size = New System.Drawing.Size(23, 20)
        Me.Btn_BuscarCodigo.TabIndex = 3
        Me.Btn_BuscarCodigo.UseVisualStyleBackColor = True
        '
        'txt_Codigo
        '
        Me.txt_Codigo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Codigo.Location = New System.Drawing.Point(3, 3)
        Me.txt_Codigo.Name = "txt_Codigo"
        Me.txt_Codigo.Size = New System.Drawing.Size(758, 21)
        Me.txt_Codigo.TabIndex = 2
        '
        'lbl_Sucursal
        '
        Me.lbl_Sucursal.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Sucursal.AutoSize = True
        Me.lbl_Sucursal.Location = New System.Drawing.Point(3, 7)
        Me.lbl_Sucursal.Name = "lbl_Sucursal"
        Me.lbl_Sucursal.Size = New System.Drawing.Size(161, 15)
        Me.lbl_Sucursal.TabIndex = 5
        Me.lbl_Sucursal.Text = "Sucursal"
        '
        'Cb_Sucursales
        '
        Me.Cb_Sucursales.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cb_Sucursales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cb_Sucursales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Sucursales.Enabled = False
        Me.Cb_Sucursales.FormattingEnabled = True
        Me.Cb_Sucursales.Items.AddRange(New Object() {"Mes Completo", "Primera Quincena", "Segunda Quincena"})
        Me.Cb_Sucursales.Location = New System.Drawing.Point(170, 4)
        Me.Cb_Sucursales.Name = "Cb_Sucursales"
        Me.Cb_Sucursales.Size = New System.Drawing.Size(796, 23)
        Me.Cb_Sucursales.TabIndex = 1
        '
        'lbl_Producto
        '
        Me.lbl_Producto.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Producto.AutoSize = True
        Me.lbl_Producto.Location = New System.Drawing.Point(3, 38)
        Me.lbl_Producto.Name = "lbl_Producto"
        Me.lbl_Producto.Size = New System.Drawing.Size(161, 15)
        Me.lbl_Producto.TabIndex = 6
        Me.lbl_Producto.Text = "Código de Producto (*)"
        '
        'lbl_Minimo
        '
        Me.lbl_Minimo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Minimo.AutoSize = True
        Me.lbl_Minimo.Location = New System.Drawing.Point(3, 69)
        Me.lbl_Minimo.Name = "lbl_Minimo"
        Me.lbl_Minimo.Size = New System.Drawing.Size(161, 15)
        Me.lbl_Minimo.TabIndex = 7
        Me.lbl_Minimo.Text = "Stock Minimo (*)"
        '
        'lbl_Optimo
        '
        Me.lbl_Optimo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Optimo.AutoSize = True
        Me.lbl_Optimo.Location = New System.Drawing.Point(3, 99)
        Me.lbl_Optimo.Name = "lbl_Optimo"
        Me.lbl_Optimo.Size = New System.Drawing.Size(161, 15)
        Me.lbl_Optimo.TabIndex = 9
        Me.lbl_Optimo.Text = "Stock Optimo (*)"
        '
        'lbl_Actual
        '
        Me.lbl_Actual.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Actual.AutoSize = True
        Me.lbl_Actual.Location = New System.Drawing.Point(3, 129)
        Me.lbl_Actual.Name = "lbl_Actual"
        Me.lbl_Actual.Size = New System.Drawing.Size(161, 15)
        Me.lbl_Actual.TabIndex = 8
        Me.lbl_Actual.Text = "Stock Actual (*)"
        '
        'txt_Minimo
        '
        Me.txt_Minimo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Minimo.Location = New System.Drawing.Point(170, 66)
        Me.txt_Minimo.Name = "txt_Minimo"
        Me.txt_Minimo.Size = New System.Drawing.Size(796, 21)
        Me.txt_Minimo.TabIndex = 4
        '
        'txt_Optimo
        '
        Me.txt_Optimo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Optimo.Location = New System.Drawing.Point(170, 96)
        Me.txt_Optimo.Name = "txt_Optimo"
        Me.txt_Optimo.Size = New System.Drawing.Size(796, 21)
        Me.txt_Optimo.TabIndex = 5
        '
        'txt_Actual
        '
        Me.txt_Actual.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Actual.Location = New System.Drawing.Point(170, 126)
        Me.txt_Actual.Name = "txt_Actual"
        Me.txt_Actual.Size = New System.Drawing.Size(796, 21)
        Me.txt_Actual.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 188)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(161, 15)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Habilitado"
        '
        'chk_Habilitado
        '
        Me.chk_Habilitado.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chk_Habilitado.AutoSize = True
        Me.chk_Habilitado.Checked = True
        Me.chk_Habilitado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Habilitado.Location = New System.Drawing.Point(170, 189)
        Me.chk_Habilitado.Name = "chk_Habilitado"
        Me.chk_Habilitado.Size = New System.Drawing.Size(796, 14)
        Me.chk_Habilitado.TabIndex = 12
        Me.chk_Habilitado.UseVisualStyleBackColor = True
        '
        'Btn_Agregar
        '
        Me.Btn_Agregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Agregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Agregar.Image = Global.SistemaCinderella.My.Resources.Recursos.Agregar_24
        Me.Btn_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Agregar.Location = New System.Drawing.Point(858, 250)
        Me.Btn_Agregar.Name = "Btn_Agregar"
        Me.Btn_Agregar.Size = New System.Drawing.Size(117, 46)
        Me.Btn_Agregar.TabIndex = 8
        Me.Btn_Agregar.Text = "Agregar"
        Me.Btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Agregar.UseVisualStyleBackColor = True
        '
        'TabModificacion
        '
        Me.TabModificacion.Controls.Add(Me.GroupBox1)
        Me.TabModificacion.Location = New System.Drawing.Point(4, 29)
        Me.TabModificacion.Name = "TabModificacion"
        Me.TabModificacion.Size = New System.Drawing.Size(998, 577)
        Me.TabModificacion.TabIndex = 2
        Me.TabModificacion.Text = "Modificacion de Stock"
        Me.TabModificacion.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel9)
        Me.GroupBox1.Controls.Add(Me.Btn_Eliminar)
        Me.GroupBox1.Controls.Add(Me.Btn_Modificar)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(9, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(981, 461)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Formulario de Modificación"
        '
        'TableLayoutPanel9
        '
        Me.TableLayoutPanel9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel9.ColumnCount = 1
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel9.Controls.Add(Me.TableLayoutPanel4, 0, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.TableLayoutPanel10, 0, 1)
        Me.TableLayoutPanel9.Location = New System.Drawing.Point(6, 20)
        Me.TableLayoutPanel9.Name = "TableLayoutPanel9"
        Me.TableLayoutPanel9.RowCount = 2
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 224.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel9.Size = New System.Drawing.Size(968, 382)
        Me.TableLayoutPanel9.TabIndex = 21
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 176.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.txt_ventaMensual_mod, 1, 5)
        Me.TableLayoutPanel4.Controls.Add(Me.Label12, 0, 5)
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel6, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.lbl_Codigo, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label4, 0, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.Cb_Sucursales_mod, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label2, 0, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.Label3, 0, 4)
        Me.TableLayoutPanel4.Controls.Add(Me.txt_Actual_mod, 1, 4)
        Me.TableLayoutPanel4.Controls.Add(Me.txt_Minimo_mod, 1, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.txt_Optimo_mod, 1, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.Label1, 0, 6)
        Me.TableLayoutPanel4.Controls.Add(Me.chk_Habilitado_mod, 1, 6)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 7
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(962, 218)
        Me.TableLayoutPanel4.TabIndex = 19
        '
        'txt_ventaMensual_mod
        '
        Me.txt_ventaMensual_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_ventaMensual_mod.Location = New System.Drawing.Point(179, 156)
        Me.txt_ventaMensual_mod.Name = "txt_ventaMensual_mod"
        Me.txt_ventaMensual_mod.Size = New System.Drawing.Size(780, 21)
        Me.txt_ventaMensual_mod.TabIndex = 7
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 159)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(170, 15)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Venta Mensual"
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 2
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.txt_Codigo_mod, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.Btn_BuscarCodigo_mod, 1, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(179, 33)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(780, 26)
        Me.TableLayoutPanel6.TabIndex = 20
        '
        'txt_Codigo_mod
        '
        Me.txt_Codigo_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Codigo_mod.Location = New System.Drawing.Point(3, 3)
        Me.txt_Codigo_mod.Name = "txt_Codigo_mod"
        Me.txt_Codigo_mod.Size = New System.Drawing.Size(742, 21)
        Me.txt_Codigo_mod.TabIndex = 2
        '
        'Btn_BuscarCodigo_mod
        '
        Me.Btn_BuscarCodigo_mod.Cursor = System.Windows.Forms.Cursors.Help
        Me.Btn_BuscarCodigo_mod.FlatAppearance.BorderSize = 0
        Me.Btn_BuscarCodigo_mod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_BuscarCodigo_mod.Image = Global.SistemaCinderella.My.Resources.Recursos.Lupa
        Me.Btn_BuscarCodigo_mod.Location = New System.Drawing.Point(751, 3)
        Me.Btn_BuscarCodigo_mod.Name = "Btn_BuscarCodigo_mod"
        Me.Btn_BuscarCodigo_mod.Size = New System.Drawing.Size(26, 20)
        Me.Btn_BuscarCodigo_mod.TabIndex = 3
        Me.Btn_BuscarCodigo_mod.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(170, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Sucursal"
        '
        'lbl_Codigo
        '
        Me.lbl_Codigo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Codigo.AutoSize = True
        Me.lbl_Codigo.Location = New System.Drawing.Point(3, 38)
        Me.lbl_Codigo.Name = "lbl_Codigo"
        Me.lbl_Codigo.Size = New System.Drawing.Size(170, 15)
        Me.lbl_Codigo.TabIndex = 13
        Me.lbl_Codigo.Text = "Código de Producto (*)"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(170, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Stock Minimo (*)"
        '
        'Cb_Sucursales_mod
        '
        Me.Cb_Sucursales_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cb_Sucursales_mod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cb_Sucursales_mod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Sucursales_mod.Enabled = False
        Me.Cb_Sucursales_mod.FormattingEnabled = True
        Me.Cb_Sucursales_mod.Items.AddRange(New Object() {"Mes Completo", "Primera Quincena", "Segunda Quincena"})
        Me.Cb_Sucursales_mod.Location = New System.Drawing.Point(179, 3)
        Me.Cb_Sucursales_mod.Name = "Cb_Sucursales_mod"
        Me.Cb_Sucursales_mod.Size = New System.Drawing.Size(780, 23)
        Me.Cb_Sucursales_mod.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 15)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Stock Optimo (*)"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(170, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Stock Actual (*)"
        '
        'txt_Actual_mod
        '
        Me.txt_Actual_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Actual_mod.Location = New System.Drawing.Point(179, 126)
        Me.txt_Actual_mod.Name = "txt_Actual_mod"
        Me.txt_Actual_mod.Size = New System.Drawing.Size(780, 21)
        Me.txt_Actual_mod.TabIndex = 6
        '
        'txt_Minimo_mod
        '
        Me.txt_Minimo_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Minimo_mod.Location = New System.Drawing.Point(179, 66)
        Me.txt_Minimo_mod.Name = "txt_Minimo_mod"
        Me.txt_Minimo_mod.Size = New System.Drawing.Size(780, 21)
        Me.txt_Minimo_mod.TabIndex = 4
        '
        'txt_Optimo_mod
        '
        Me.txt_Optimo_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Optimo_mod.Location = New System.Drawing.Point(179, 96)
        Me.txt_Optimo_mod.Name = "txt_Optimo_mod"
        Me.txt_Optimo_mod.Size = New System.Drawing.Size(780, 21)
        Me.txt_Optimo_mod.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 192)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 15)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Habilitado"
        '
        'chk_Habilitado_mod
        '
        Me.chk_Habilitado_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chk_Habilitado_mod.AutoSize = True
        Me.chk_Habilitado_mod.Checked = True
        Me.chk_Habilitado_mod.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Habilitado_mod.Location = New System.Drawing.Point(179, 193)
        Me.chk_Habilitado_mod.Name = "chk_Habilitado_mod"
        Me.chk_Habilitado_mod.Size = New System.Drawing.Size(780, 14)
        Me.chk_Habilitado_mod.TabIndex = 7
        Me.chk_Habilitado_mod.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel10
        '
        Me.TableLayoutPanel10.ColumnCount = 2
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel10.Controls.Add(Me.GroupBox3, 0, 0)
        Me.TableLayoutPanel10.Controls.Add(Me.Gb_Mod, 1, 0)
        Me.TableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel10.Location = New System.Drawing.Point(3, 227)
        Me.TableLayoutPanel10.Name = "TableLayoutPanel10"
        Me.TableLayoutPanel10.RowCount = 1
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel10.Size = New System.Drawing.Size(962, 152)
        Me.TableLayoutPanel10.TabIndex = 20
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.TableLayoutPanel7)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(475, 146)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos de la nueva modificación de stock"
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 2
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.txt_Motivo, 1, 2)
        Me.TableLayoutPanel7.Controls.Add(Me.lbl_Usuario2, 1, 1)
        Me.TableLayoutPanel7.Controls.Add(Me.Label13, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.lbl_Fecha2, 1, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.Label14, 0, 1)
        Me.TableLayoutPanel7.Controls.Add(Me.Label15, 0, 2)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(3, 17)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 3
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(469, 126)
        Me.TableLayoutPanel7.TabIndex = 20
        '
        'txt_Motivo
        '
        Me.txt_Motivo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Motivo.Location = New System.Drawing.Point(103, 63)
        Me.txt_Motivo.Multiline = True
        Me.txt_Motivo.Name = "txt_Motivo"
        Me.txt_Motivo.Size = New System.Drawing.Size(363, 60)
        Me.txt_Motivo.TabIndex = 8
        '
        'lbl_Usuario2
        '
        Me.lbl_Usuario2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Usuario2.AutoSize = True
        Me.lbl_Usuario2.Location = New System.Drawing.Point(103, 37)
        Me.lbl_Usuario2.Name = "lbl_Usuario2"
        Me.lbl_Usuario2.Size = New System.Drawing.Size(363, 15)
        Me.lbl_Usuario2.TabIndex = 5
        Me.lbl_Usuario2.Text = "- - - - - "
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(3, 7)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(94, 15)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Fecha"
        '
        'lbl_Fecha2
        '
        Me.lbl_Fecha2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Fecha2.AutoSize = True
        Me.lbl_Fecha2.Location = New System.Drawing.Point(103, 7)
        Me.lbl_Fecha2.Name = "lbl_Fecha2"
        Me.lbl_Fecha2.Size = New System.Drawing.Size(363, 15)
        Me.lbl_Fecha2.TabIndex = 4
        Me.lbl_Fecha2.Text = "- - - - -"
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(3, 37)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(94, 15)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Usuario"
        '
        'Label15
        '
        Me.Label15.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(3, 60)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(94, 15)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Motivo (*)"
        '
        'Gb_Mod
        '
        Me.Gb_Mod.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gb_Mod.Controls.Add(Me.TableLayoutPanel8)
        Me.Gb_Mod.Location = New System.Drawing.Point(484, 3)
        Me.Gb_Mod.Name = "Gb_Mod"
        Me.Gb_Mod.Size = New System.Drawing.Size(475, 146)
        Me.Gb_Mod.TabIndex = 17
        Me.Gb_Mod.TabStop = False
        Me.Gb_Mod.Text = "Datos de la última modificación de stock"
        Me.Gb_Mod.Visible = False
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.ColumnCount = 2
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.lbl_Motivo, 1, 2)
        Me.TableLayoutPanel8.Controls.Add(Me.Label10, 0, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.lbl_Usuario, 1, 1)
        Me.TableLayoutPanel8.Controls.Add(Me.Label9, 0, 1)
        Me.TableLayoutPanel8.Controls.Add(Me.lbl_Fecha, 1, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.Label8, 0, 2)
        Me.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(3, 17)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 3
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(469, 126)
        Me.TableLayoutPanel8.TabIndex = 20
        '
        'lbl_Motivo
        '
        Me.lbl_Motivo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Motivo.Location = New System.Drawing.Point(103, 60)
        Me.lbl_Motivo.Name = "lbl_Motivo"
        Me.lbl_Motivo.Size = New System.Drawing.Size(363, 66)
        Me.lbl_Motivo.TabIndex = 6
        Me.lbl_Motivo.Text = "- - - - - "
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 7)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 15)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Fecha"
        '
        'lbl_Usuario
        '
        Me.lbl_Usuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Usuario.AutoSize = True
        Me.lbl_Usuario.Location = New System.Drawing.Point(103, 37)
        Me.lbl_Usuario.Name = "lbl_Usuario"
        Me.lbl_Usuario.Size = New System.Drawing.Size(363, 15)
        Me.lbl_Usuario.TabIndex = 5
        Me.lbl_Usuario.Text = "- - - - - "
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 37)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 15)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Usuario"
        '
        'lbl_Fecha
        '
        Me.lbl_Fecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Fecha.AutoSize = True
        Me.lbl_Fecha.Location = New System.Drawing.Point(103, 7)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(363, 15)
        Me.lbl_Fecha.TabIndex = 4
        Me.lbl_Fecha.Text = "- - - - -"
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 15)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Motivo "
        '
        'Btn_Eliminar
        '
        Me.Btn_Eliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Eliminar.Image = Global.SistemaCinderella.My.Resources.Recursos.desconectado_32
        Me.Btn_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Eliminar.Location = New System.Drawing.Point(734, 408)
        Me.Btn_Eliminar.Name = "Btn_Eliminar"
        Me.Btn_Eliminar.Size = New System.Drawing.Size(117, 46)
        Me.Btn_Eliminar.TabIndex = 9
        Me.Btn_Eliminar.Text = "Eliminar"
        Me.Btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Eliminar.UseVisualStyleBackColor = True
        '
        'Btn_Modificar
        '
        Me.Btn_Modificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Modificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Modificar.Image = Global.SistemaCinderella.My.Resources.Recursos.Editar_24
        Me.Btn_Modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Modificar.Location = New System.Drawing.Point(857, 408)
        Me.Btn_Modificar.Name = "Btn_Modificar"
        Me.Btn_Modificar.Size = New System.Drawing.Size(117, 46)
        Me.Btn_Modificar.TabIndex = 10
        Me.Btn_Modificar.Text = "Modificar"
        Me.Btn_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Modificar.UseVisualStyleBackColor = True
        '
        'ErrorStock
        '
        Me.ErrorStock.BlinkRate = 200
        Me.ErrorStock.ContainerControl = Me
        '
        'ToolStock
        '
        Me.ToolStock.IsBalloon = True
        Me.ToolStock.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolStock.ToolTipTitle = "Ayuda"
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog"
        '
        'frmStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 610)
        Me.Controls.Add(Me.TabStock)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmStock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administración de Stock"
        Me.TabStock.ResumeLayout(False)
        Me.TabListado.ResumeLayout(False)
        Me.GB_Buscar.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.DG_Stock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabAlta.ResumeLayout(False)
        Me.GB_Alta.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.TabModificacion.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel9.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.TableLayoutPanel10.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel7.PerformLayout()
        Me.Gb_Mod.ResumeLayout(False)
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel8.PerformLayout()
        CType(Me.ErrorStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabStock As System.Windows.Forms.TabControl
    Friend WithEvents TabListado As System.Windows.Forms.TabPage
    Friend WithEvents TabAlta As System.Windows.Forms.TabPage
    Friend WithEvents TabModificacion As System.Windows.Forms.TabPage
    Friend WithEvents DG_Stock As System.Windows.Forms.DataGridView
    Friend WithEvents GB_Buscar As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Restablecer As System.Windows.Forms.Button
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents rb_Opcion2 As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Opcion As System.Windows.Forms.RadioButton
    Friend WithEvents txt_buscar As System.Windows.Forms.TextBox
    Friend WithEvents ErrorStock As System.Windows.Forms.ErrorProvider
    Friend WithEvents GB_Alta As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Optimo As System.Windows.Forms.Label
    Friend WithEvents lbl_Actual As System.Windows.Forms.Label
    Friend WithEvents lbl_Minimo As System.Windows.Forms.Label
    Friend WithEvents lbl_Producto As System.Windows.Forms.Label
    Friend WithEvents lbl_Sucursal As System.Windows.Forms.Label
    Friend WithEvents txt_Optimo As System.Windows.Forms.TextBox
    Friend WithEvents txt_Actual As System.Windows.Forms.TextBox
    Friend WithEvents txt_Minimo As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Agregar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_Modificar As System.Windows.Forms.Button
    Friend WithEvents chk_Habilitado_mod As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_Optimo_mod As System.Windows.Forms.TextBox
    Friend WithEvents txt_Actual_mod As System.Windows.Forms.TextBox
    Friend WithEvents txt_Minimo_mod As System.Windows.Forms.TextBox
    Friend WithEvents Btn_BuscarCodigo As System.Windows.Forms.Button
    Friend WithEvents txt_Codigo As System.Windows.Forms.TextBox
    Friend WithEvents txt_Codigo_mod As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Codigo As System.Windows.Forms.Label
    Friend WithEvents Btn_BuscarCodigo_mod As System.Windows.Forms.Button
    Friend WithEvents Btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents Cb_Sucursal As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbl_Msg As System.Windows.Forms.Label
    Friend WithEvents ToolStock As System.Windows.Forms.ToolTip
    Friend WithEvents Cb_Sucursales As System.Windows.Forms.ComboBox
    Friend WithEvents Cb_Sucursales_mod As System.Windows.Forms.ComboBox
    Friend WithEvents Gb_Mod As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Usuario As System.Windows.Forms.Label
    Friend WithEvents lbl_Fecha As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Usuario2 As System.Windows.Forms.Label
    Friend WithEvents lbl_Fecha2 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txt_Motivo As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Motivo As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents chk_Habilitado As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel10 As TableLayoutPanel
    Friend WithEvents btn_Importar As Button
    Friend WithEvents btn_Exportar As Button
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents SaveFileDialog As SaveFileDialog
    Friend WithEvents txt_ventaMensual As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_ventaMensual_mod As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents id_Stock As DataGridViewTextBoxColumn
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents PRODUCTO As DataGridViewTextBoxColumn
    Friend WithEvents Categoria As DataGridViewTextBoxColumn
    Friend WithEvents Minimo As DataGridViewTextBoxColumn
    Friend WithEvents Actual As DataGridViewTextBoxColumn
    Friend WithEvents Optimo As DataGridViewTextBoxColumn
    Friend WithEvents VentaMensual As DataGridViewTextBoxColumn
    Friend WithEvents Sucursal As DataGridViewTextBoxColumn
    Friend WithEvents Modificado As DataGridViewTextBoxColumn
    Friend WithEvents Modificar As DataGridViewImageColumn
    Friend WithEvents Eliminar As DataGridViewImageColumn
End Class
