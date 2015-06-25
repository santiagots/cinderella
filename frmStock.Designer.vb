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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Cb_Sucursal = New System.Windows.Forms.ComboBox()
        Me.btn_Restablecer = New System.Windows.Forms.Button()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.rb_Opcion2 = New System.Windows.Forms.RadioButton()
        Me.rb_Opcion = New System.Windows.Forms.RadioButton()
        Me.txt_buscar = New System.Windows.Forms.TextBox()
        Me.DG_Stock = New System.Windows.Forms.DataGridView()
        Me.id_Stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODUCTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Minimo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Actual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Optimo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sucursal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Modificado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Modificar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Eliminar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TabAlta = New System.Windows.Forms.TabPage()
        Me.GB_Alta = New System.Windows.Forms.GroupBox()
        Me.Cb_Sucursales = New System.Windows.Forms.ComboBox()
        Me.Btn_BuscarCodigo = New System.Windows.Forms.Button()
        Me.txt_Codigo = New System.Windows.Forms.TextBox()
        Me.Btn_Agregar = New System.Windows.Forms.Button()
        Me.chk_Habilitado = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_Optimo = New System.Windows.Forms.Label()
        Me.lbl_Actual = New System.Windows.Forms.Label()
        Me.lbl_Minimo = New System.Windows.Forms.Label()
        Me.lbl_Producto = New System.Windows.Forms.Label()
        Me.lbl_Sucursal = New System.Windows.Forms.Label()
        Me.txt_Optimo = New System.Windows.Forms.TextBox()
        Me.txt_Actual = New System.Windows.Forms.TextBox()
        Me.txt_Minimo = New System.Windows.Forms.TextBox()
        Me.TabModificacion = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lbl_Usuario2 = New System.Windows.Forms.Label()
        Me.lbl_Fecha2 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_Motivo = New System.Windows.Forms.TextBox()
        Me.Gb_Mod = New System.Windows.Forms.GroupBox()
        Me.lbl_Motivo = New System.Windows.Forms.Label()
        Me.lbl_Usuario = New System.Windows.Forms.Label()
        Me.lbl_Fecha = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Cb_Sucursales_mod = New System.Windows.Forms.ComboBox()
        Me.Btn_Eliminar = New System.Windows.Forms.Button()
        Me.Btn_BuscarCodigo_mod = New System.Windows.Forms.Button()
        Me.txt_Codigo_mod = New System.Windows.Forms.TextBox()
        Me.lbl_Codigo = New System.Windows.Forms.Label()
        Me.Btn_Modificar = New System.Windows.Forms.Button()
        Me.chk_Habilitado_mod = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_Optimo_mod = New System.Windows.Forms.TextBox()
        Me.txt_Actual_mod = New System.Windows.Forms.TextBox()
        Me.txt_Minimo_mod = New System.Windows.Forms.TextBox()
        Me.ErrorStock = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolStock = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabStock.SuspendLayout()
        Me.TabListado.SuspendLayout()
        Me.GB_Buscar.SuspendLayout()
        CType(Me.DG_Stock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabAlta.SuspendLayout()
        Me.GB_Alta.SuspendLayout()
        Me.TabModificacion.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Gb_Mod.SuspendLayout()
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
        Me.TabStock.Size = New System.Drawing.Size(694, 472)
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
        Me.TabListado.Size = New System.Drawing.Size(686, 439)
        Me.TabListado.TabIndex = 0
        Me.TabListado.Text = "Stock"
        Me.TabListado.UseVisualStyleBackColor = True
        '
        'lbl_Msg
        '
        Me.lbl_Msg.AutoSize = True
        Me.lbl_Msg.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lbl_Msg.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Msg.Location = New System.Drawing.Point(114, 244)
        Me.lbl_Msg.Name = "lbl_Msg"
        Me.lbl_Msg.Size = New System.Drawing.Size(458, 29)
        Me.lbl_Msg.TabIndex = 1
        Me.lbl_Msg.Text = "No se ha encontrado stocks cargados."
        '
        'GB_Buscar
        '
        Me.GB_Buscar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_Buscar.Controls.Add(Me.Label5)
        Me.GB_Buscar.Controls.Add(Me.Cb_Sucursal)
        Me.GB_Buscar.Controls.Add(Me.btn_Restablecer)
        Me.GB_Buscar.Controls.Add(Me.btn_Buscar)
        Me.GB_Buscar.Controls.Add(Me.rb_Opcion2)
        Me.GB_Buscar.Controls.Add(Me.rb_Opcion)
        Me.GB_Buscar.Controls.Add(Me.txt_buscar)
        Me.GB_Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Buscar.Location = New System.Drawing.Point(8, 6)
        Me.GB_Buscar.Name = "GB_Buscar"
        Me.GB_Buscar.Size = New System.Drawing.Size(666, 105)
        Me.GB_Buscar.TabIndex = 0
        Me.GB_Buscar.TabStop = False
        Me.GB_Buscar.Text = "Buscar Stock de productos"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 15)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Sucursal"
        '
        'Cb_Sucursal
        '
        Me.Cb_Sucursal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cb_Sucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Sucursal.FormattingEnabled = True
        Me.Cb_Sucursal.Items.AddRange(New Object() {"Mes Completo", "Primera Quincena", "Segunda Quincena"})
        Me.Cb_Sucursal.Location = New System.Drawing.Point(152, 30)
        Me.Cb_Sucursal.Name = "Cb_Sucursal"
        Me.Cb_Sucursal.Size = New System.Drawing.Size(182, 23)
        Me.Cb_Sucursal.TabIndex = 1
        '
        'btn_Restablecer
        '
        Me.btn_Restablecer.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btn_Restablecer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Restablecer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Restablecer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Restablecer.Location = New System.Drawing.Point(452, 38)
        Me.btn_Restablecer.Name = "btn_Restablecer"
        Me.btn_Restablecer.Size = New System.Drawing.Size(100, 40)
        Me.btn_Restablecer.TabIndex = 5
        Me.btn_Restablecer.Text = "Restablecer Filtros"
        Me.ToolStock.SetToolTip(Me.btn_Restablecer, "Haz click aquí para restablecer los filtros y el listado de stocks.")
        Me.btn_Restablecer.UseVisualStyleBackColor = True
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btn_Buscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Buscar.Image = Global.SistemaCinderella.My.Resources.Recursos.IconoBuscar32
        Me.btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Buscar.Location = New System.Drawing.Point(558, 38)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(100, 40)
        Me.btn_Buscar.TabIndex = 6
        Me.btn_Buscar.Text = "Buscar"
        Me.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolStock.SetToolTip(Me.btn_Buscar, "Haz click aquí para buscar stocks con los criterios de busqueda seleccionados.")
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'rb_Opcion2
        '
        Me.rb_Opcion2.AutoSize = True
        Me.rb_Opcion2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rb_Opcion2.Location = New System.Drawing.Point(82, 67)
        Me.rb_Opcion2.Name = "rb_Opcion2"
        Me.rb_Opcion2.Size = New System.Drawing.Size(64, 19)
        Me.rb_Opcion2.TabIndex = 3
        Me.rb_Opcion2.Text = "Codigo"
        Me.rb_Opcion2.UseVisualStyleBackColor = True
        '
        'rb_Opcion
        '
        Me.rb_Opcion.AutoSize = True
        Me.rb_Opcion.Checked = True
        Me.rb_Opcion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rb_Opcion.Location = New System.Drawing.Point(6, 66)
        Me.rb_Opcion.Name = "rb_Opcion"
        Me.rb_Opcion.Size = New System.Drawing.Size(70, 19)
        Me.rb_Opcion.TabIndex = 2
        Me.rb_Opcion.TabStop = True
        Me.rb_Opcion.Text = "Nombre"
        Me.rb_Opcion.UseVisualStyleBackColor = True
        '
        'txt_buscar
        '
        Me.txt_buscar.Location = New System.Drawing.Point(152, 64)
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(182, 21)
        Me.txt_buscar.TabIndex = 4
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
        Me.DG_Stock.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_Stock, Me.PRODUCTO, Me.Categoria, Me.Codigo, Me.Minimo, Me.Actual, Me.Optimo, Me.Sucursal, Me.Modificado, Me.Modificar, Me.Eliminar})
        Me.DG_Stock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DG_Stock.Location = New System.Drawing.Point(8, 117)
        Me.DG_Stock.MultiSelect = False
        Me.DG_Stock.Name = "DG_Stock"
        Me.DG_Stock.ReadOnly = True
        Me.DG_Stock.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DG_Stock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Stock.Size = New System.Drawing.Size(666, 314)
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
        Me.Categoria.DataPropertyName = "Cat"
        Me.Categoria.FillWeight = 145.4872!
        Me.Categoria.HeaderText = "Categoria"
        Me.Categoria.Name = "Categoria"
        Me.Categoria.ReadOnly = True
        Me.Categoria.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Codigo
        '
        Me.Codigo.DataPropertyName = "Codigo"
        Me.Codigo.FillWeight = 145.4872!
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        Me.Codigo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
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
        Me.TabAlta.Size = New System.Drawing.Size(686, 439)
        Me.TabAlta.TabIndex = 1
        Me.TabAlta.Text = "Alta de Stock"
        Me.TabAlta.UseVisualStyleBackColor = True
        '
        'GB_Alta
        '
        Me.GB_Alta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_Alta.Controls.Add(Me.Cb_Sucursales)
        Me.GB_Alta.Controls.Add(Me.Btn_BuscarCodigo)
        Me.GB_Alta.Controls.Add(Me.txt_Codigo)
        Me.GB_Alta.Controls.Add(Me.Btn_Agregar)
        Me.GB_Alta.Controls.Add(Me.chk_Habilitado)
        Me.GB_Alta.Controls.Add(Me.Label7)
        Me.GB_Alta.Controls.Add(Me.lbl_Optimo)
        Me.GB_Alta.Controls.Add(Me.lbl_Actual)
        Me.GB_Alta.Controls.Add(Me.lbl_Minimo)
        Me.GB_Alta.Controls.Add(Me.lbl_Producto)
        Me.GB_Alta.Controls.Add(Me.lbl_Sucursal)
        Me.GB_Alta.Controls.Add(Me.txt_Optimo)
        Me.GB_Alta.Controls.Add(Me.txt_Actual)
        Me.GB_Alta.Controls.Add(Me.txt_Minimo)
        Me.GB_Alta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Alta.Location = New System.Drawing.Point(9, 7)
        Me.GB_Alta.Name = "GB_Alta"
        Me.GB_Alta.Size = New System.Drawing.Size(668, 418)
        Me.GB_Alta.TabIndex = 0
        Me.GB_Alta.TabStop = False
        Me.GB_Alta.Text = "Formulario de Alta"
        '
        'Cb_Sucursales
        '
        Me.Cb_Sucursales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cb_Sucursales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Sucursales.FormattingEnabled = True
        Me.Cb_Sucursales.Items.AddRange(New Object() {"Mes Completo", "Primera Quincena", "Segunda Quincena"})
        Me.Cb_Sucursales.Location = New System.Drawing.Point(182, 33)
        Me.Cb_Sucursales.Name = "Cb_Sucursales"
        Me.Cb_Sucursales.Size = New System.Drawing.Size(182, 23)
        Me.Cb_Sucursales.TabIndex = 1
        '
        'Btn_BuscarCodigo
        '
        Me.Btn_BuscarCodigo.Cursor = System.Windows.Forms.Cursors.Help
        Me.Btn_BuscarCodigo.FlatAppearance.BorderSize = 0
        Me.Btn_BuscarCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_BuscarCodigo.Image = Global.SistemaCinderella.My.Resources.Recursos.Lupa
        Me.Btn_BuscarCodigo.Location = New System.Drawing.Point(331, 67)
        Me.Btn_BuscarCodigo.Name = "Btn_BuscarCodigo"
        Me.Btn_BuscarCodigo.Size = New System.Drawing.Size(38, 43)
        Me.Btn_BuscarCodigo.TabIndex = 3
        Me.Btn_BuscarCodigo.UseVisualStyleBackColor = True
        '
        'txt_Codigo
        '
        Me.txt_Codigo.Location = New System.Drawing.Point(182, 79)
        Me.txt_Codigo.Name = "txt_Codigo"
        Me.txt_Codigo.Size = New System.Drawing.Size(143, 21)
        Me.txt_Codigo.TabIndex = 2
        '
        'Btn_Agregar
        '
        Me.Btn_Agregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Agregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Agregar.Image = Global.SistemaCinderella.My.Resources.Recursos.Agregar_24
        Me.Btn_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Agregar.Location = New System.Drawing.Point(545, 365)
        Me.Btn_Agregar.Name = "Btn_Agregar"
        Me.Btn_Agregar.Size = New System.Drawing.Size(117, 46)
        Me.Btn_Agregar.TabIndex = 8
        Me.Btn_Agregar.Text = "Agregar"
        Me.Btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Agregar.UseVisualStyleBackColor = True
        '
        'chk_Habilitado
        '
        Me.chk_Habilitado.AutoSize = True
        Me.chk_Habilitado.Checked = True
        Me.chk_Habilitado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Habilitado.Location = New System.Drawing.Point(182, 249)
        Me.chk_Habilitado.Name = "chk_Habilitado"
        Me.chk_Habilitado.Size = New System.Drawing.Size(15, 14)
        Me.chk_Habilitado.TabIndex = 7
        Me.chk_Habilitado.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 249)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 15)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Habilitado"
        '
        'lbl_Optimo
        '
        Me.lbl_Optimo.AutoSize = True
        Me.lbl_Optimo.Location = New System.Drawing.Point(6, 164)
        Me.lbl_Optimo.Name = "lbl_Optimo"
        Me.lbl_Optimo.Size = New System.Drawing.Size(96, 15)
        Me.lbl_Optimo.TabIndex = 9
        Me.lbl_Optimo.Text = "Stock Optimo (*)"
        '
        'lbl_Actual
        '
        Me.lbl_Actual.AutoSize = True
        Me.lbl_Actual.Location = New System.Drawing.Point(6, 207)
        Me.lbl_Actual.Name = "lbl_Actual"
        Me.lbl_Actual.Size = New System.Drawing.Size(89, 15)
        Me.lbl_Actual.TabIndex = 8
        Me.lbl_Actual.Text = "Stock Actual (*)"
        '
        'lbl_Minimo
        '
        Me.lbl_Minimo.AutoSize = True
        Me.lbl_Minimo.Location = New System.Drawing.Point(6, 121)
        Me.lbl_Minimo.Name = "lbl_Minimo"
        Me.lbl_Minimo.Size = New System.Drawing.Size(98, 15)
        Me.lbl_Minimo.TabIndex = 7
        Me.lbl_Minimo.Text = "Stock Minimo (*)"
        '
        'lbl_Producto
        '
        Me.lbl_Producto.AutoSize = True
        Me.lbl_Producto.Location = New System.Drawing.Point(6, 79)
        Me.lbl_Producto.Name = "lbl_Producto"
        Me.lbl_Producto.Size = New System.Drawing.Size(131, 15)
        Me.lbl_Producto.TabIndex = 6
        Me.lbl_Producto.Text = "Código de Producto (*)"
        '
        'lbl_Sucursal
        '
        Me.lbl_Sucursal.AutoSize = True
        Me.lbl_Sucursal.Location = New System.Drawing.Point(6, 36)
        Me.lbl_Sucursal.Name = "lbl_Sucursal"
        Me.lbl_Sucursal.Size = New System.Drawing.Size(55, 15)
        Me.lbl_Sucursal.TabIndex = 5
        Me.lbl_Sucursal.Text = "Sucursal"
        '
        'txt_Optimo
        '
        Me.txt_Optimo.Location = New System.Drawing.Point(182, 160)
        Me.txt_Optimo.Name = "txt_Optimo"
        Me.txt_Optimo.Size = New System.Drawing.Size(93, 21)
        Me.txt_Optimo.TabIndex = 5
        '
        'txt_Actual
        '
        Me.txt_Actual.Location = New System.Drawing.Point(182, 203)
        Me.txt_Actual.Name = "txt_Actual"
        Me.txt_Actual.Size = New System.Drawing.Size(93, 21)
        Me.txt_Actual.TabIndex = 6
        '
        'txt_Minimo
        '
        Me.txt_Minimo.Location = New System.Drawing.Point(182, 117)
        Me.txt_Minimo.Name = "txt_Minimo"
        Me.txt_Minimo.Size = New System.Drawing.Size(93, 21)
        Me.txt_Minimo.TabIndex = 4
        '
        'TabModificacion
        '
        Me.TabModificacion.Controls.Add(Me.GroupBox1)
        Me.TabModificacion.Location = New System.Drawing.Point(4, 29)
        Me.TabModificacion.Name = "TabModificacion"
        Me.TabModificacion.Size = New System.Drawing.Size(686, 439)
        Me.TabModificacion.TabIndex = 2
        Me.TabModificacion.Text = "Modificacion de Stock"
        Me.TabModificacion.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.Gb_Mod)
        Me.GroupBox1.Controls.Add(Me.Cb_Sucursales_mod)
        Me.GroupBox1.Controls.Add(Me.Btn_Eliminar)
        Me.GroupBox1.Controls.Add(Me.Btn_BuscarCodigo_mod)
        Me.GroupBox1.Controls.Add(Me.txt_Codigo_mod)
        Me.GroupBox1.Controls.Add(Me.lbl_Codigo)
        Me.GroupBox1.Controls.Add(Me.Btn_Modificar)
        Me.GroupBox1.Controls.Add(Me.chk_Habilitado_mod)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txt_Optimo_mod)
        Me.GroupBox1.Controls.Add(Me.txt_Actual_mod)
        Me.GroupBox1.Controls.Add(Me.txt_Minimo_mod)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(9, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(668, 418)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Formulario de Modificación"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lbl_Usuario2)
        Me.GroupBox3.Controls.Add(Me.lbl_Fecha2)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.txt_Motivo)
        Me.GroupBox3.Location = New System.Drawing.Point(362, 34)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(299, 150)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos de la nueva modificación de stock"
        '
        'lbl_Usuario2
        '
        Me.lbl_Usuario2.AutoSize = True
        Me.lbl_Usuario2.Location = New System.Drawing.Point(75, 42)
        Me.lbl_Usuario2.Name = "lbl_Usuario2"
        Me.lbl_Usuario2.Size = New System.Drawing.Size(42, 15)
        Me.lbl_Usuario2.TabIndex = 5
        Me.lbl_Usuario2.Text = "- - - - - "
        '
        'lbl_Fecha2
        '
        Me.lbl_Fecha2.AutoSize = True
        Me.lbl_Fecha2.Location = New System.Drawing.Point(75, 17)
        Me.lbl_Fecha2.Name = "lbl_Fecha2"
        Me.lbl_Fecha2.Size = New System.Drawing.Size(39, 15)
        Me.lbl_Fecha2.TabIndex = 4
        Me.lbl_Fecha2.Text = "- - - - -"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 17)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 15)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Fecha"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 42)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(50, 15)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Usuario"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 67)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(59, 15)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Motivo (*)"
        '
        'txt_Motivo
        '
        Me.txt_Motivo.Location = New System.Drawing.Point(78, 68)
        Me.txt_Motivo.Multiline = True
        Me.txt_Motivo.Name = "txt_Motivo"
        Me.txt_Motivo.Size = New System.Drawing.Size(210, 60)
        Me.txt_Motivo.TabIndex = 8
        '
        'Gb_Mod
        '
        Me.Gb_Mod.Controls.Add(Me.lbl_Motivo)
        Me.Gb_Mod.Controls.Add(Me.lbl_Usuario)
        Me.Gb_Mod.Controls.Add(Me.lbl_Fecha)
        Me.Gb_Mod.Controls.Add(Me.Label10)
        Me.Gb_Mod.Controls.Add(Me.Label9)
        Me.Gb_Mod.Controls.Add(Me.Label8)
        Me.Gb_Mod.Location = New System.Drawing.Point(362, 190)
        Me.Gb_Mod.Name = "Gb_Mod"
        Me.Gb_Mod.Size = New System.Drawing.Size(299, 150)
        Me.Gb_Mod.TabIndex = 17
        Me.Gb_Mod.TabStop = False
        Me.Gb_Mod.Text = "Datos de la última modificación de stock"
        Me.Gb_Mod.Visible = False
        '
        'lbl_Motivo
        '
        Me.lbl_Motivo.Location = New System.Drawing.Point(75, 67)
        Me.lbl_Motivo.Name = "lbl_Motivo"
        Me.lbl_Motivo.Size = New System.Drawing.Size(210, 60)
        Me.lbl_Motivo.TabIndex = 6
        Me.lbl_Motivo.Text = "- - - - - "
        '
        'lbl_Usuario
        '
        Me.lbl_Usuario.AutoSize = True
        Me.lbl_Usuario.Location = New System.Drawing.Point(75, 42)
        Me.lbl_Usuario.Name = "lbl_Usuario"
        Me.lbl_Usuario.Size = New System.Drawing.Size(42, 15)
        Me.lbl_Usuario.TabIndex = 5
        Me.lbl_Usuario.Text = "- - - - - "
        '
        'lbl_Fecha
        '
        Me.lbl_Fecha.AutoSize = True
        Me.lbl_Fecha.Location = New System.Drawing.Point(75, 17)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(39, 15)
        Me.lbl_Fecha.TabIndex = 4
        Me.lbl_Fecha.Text = "- - - - -"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 15)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Fecha"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 42)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 15)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Usuario"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 67)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 15)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Motivo "
        '
        'Cb_Sucursales_mod
        '
        Me.Cb_Sucursales_mod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cb_Sucursales_mod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Sucursales_mod.FormattingEnabled = True
        Me.Cb_Sucursales_mod.Items.AddRange(New Object() {"Mes Completo", "Primera Quincena", "Segunda Quincena"})
        Me.Cb_Sucursales_mod.Location = New System.Drawing.Point(173, 34)
        Me.Cb_Sucursales_mod.Name = "Cb_Sucursales_mod"
        Me.Cb_Sucursales_mod.Size = New System.Drawing.Size(182, 23)
        Me.Cb_Sucursales_mod.TabIndex = 1
        '
        'Btn_Eliminar
        '
        Me.Btn_Eliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Eliminar.Image = Global.SistemaCinderella.My.Resources.Recursos.desconectado_32
        Me.Btn_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Eliminar.Location = New System.Drawing.Point(421, 365)
        Me.Btn_Eliminar.Name = "Btn_Eliminar"
        Me.Btn_Eliminar.Size = New System.Drawing.Size(117, 46)
        Me.Btn_Eliminar.TabIndex = 9
        Me.Btn_Eliminar.Text = "Eliminar"
        Me.Btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Eliminar.UseVisualStyleBackColor = True
        '
        'Btn_BuscarCodigo_mod
        '
        Me.Btn_BuscarCodigo_mod.Cursor = System.Windows.Forms.Cursors.Help
        Me.Btn_BuscarCodigo_mod.FlatAppearance.BorderSize = 0
        Me.Btn_BuscarCodigo_mod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_BuscarCodigo_mod.Image = Global.SistemaCinderella.My.Resources.Recursos.Lupa
        Me.Btn_BuscarCodigo_mod.Location = New System.Drawing.Point(318, 65)
        Me.Btn_BuscarCodigo_mod.Name = "Btn_BuscarCodigo_mod"
        Me.Btn_BuscarCodigo_mod.Size = New System.Drawing.Size(38, 43)
        Me.Btn_BuscarCodigo_mod.TabIndex = 3
        Me.Btn_BuscarCodigo_mod.UseVisualStyleBackColor = True
        '
        'txt_Codigo_mod
        '
        Me.txt_Codigo_mod.Location = New System.Drawing.Point(173, 77)
        Me.txt_Codigo_mod.Name = "txt_Codigo_mod"
        Me.txt_Codigo_mod.Size = New System.Drawing.Size(143, 21)
        Me.txt_Codigo_mod.TabIndex = 2
        '
        'lbl_Codigo
        '
        Me.lbl_Codigo.AutoSize = True
        Me.lbl_Codigo.Location = New System.Drawing.Point(6, 81)
        Me.lbl_Codigo.Name = "lbl_Codigo"
        Me.lbl_Codigo.Size = New System.Drawing.Size(131, 15)
        Me.lbl_Codigo.TabIndex = 13
        Me.lbl_Codigo.Text = "Código de Producto (*)"
        '
        'Btn_Modificar
        '
        Me.Btn_Modificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Modificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Modificar.Image = Global.SistemaCinderella.My.Resources.Recursos.Editar_24
        Me.Btn_Modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Modificar.Location = New System.Drawing.Point(544, 365)
        Me.Btn_Modificar.Name = "Btn_Modificar"
        Me.Btn_Modificar.Size = New System.Drawing.Size(117, 46)
        Me.Btn_Modificar.TabIndex = 10
        Me.Btn_Modificar.Text = "Modificar"
        Me.Btn_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Modificar.UseVisualStyleBackColor = True
        '
        'chk_Habilitado_mod
        '
        Me.chk_Habilitado_mod.AutoSize = True
        Me.chk_Habilitado_mod.Checked = True
        Me.chk_Habilitado_mod.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Habilitado_mod.Location = New System.Drawing.Point(173, 251)
        Me.chk_Habilitado_mod.Name = "chk_Habilitado_mod"
        Me.chk_Habilitado_mod.Size = New System.Drawing.Size(15, 14)
        Me.chk_Habilitado_mod.TabIndex = 7
        Me.chk_Habilitado_mod.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 250)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 15)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Habilitado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 15)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Stock Optimo (*)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 208)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Stock Actual (*)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Stock Minimo (*)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Sucursal"
        '
        'txt_Optimo_mod
        '
        Me.txt_Optimo_mod.Location = New System.Drawing.Point(173, 163)
        Me.txt_Optimo_mod.Name = "txt_Optimo_mod"
        Me.txt_Optimo_mod.Size = New System.Drawing.Size(93, 21)
        Me.txt_Optimo_mod.TabIndex = 5
        '
        'txt_Actual_mod
        '
        Me.txt_Actual_mod.Location = New System.Drawing.Point(173, 205)
        Me.txt_Actual_mod.Name = "txt_Actual_mod"
        Me.txt_Actual_mod.Size = New System.Drawing.Size(93, 21)
        Me.txt_Actual_mod.TabIndex = 6
        '
        'txt_Minimo_mod
        '
        Me.txt_Minimo_mod.Location = New System.Drawing.Point(173, 119)
        Me.txt_Minimo_mod.Name = "txt_Minimo_mod"
        Me.txt_Minimo_mod.Size = New System.Drawing.Size(93, 21)
        Me.txt_Minimo_mod.TabIndex = 4
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
        'frmStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 472)
        Me.Controls.Add(Me.TabStock)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmStock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administración de Stock"
        Me.TabStock.ResumeLayout(False)
        Me.TabListado.ResumeLayout(False)
        Me.TabListado.PerformLayout()
        Me.GB_Buscar.ResumeLayout(False)
        Me.GB_Buscar.PerformLayout()
        CType(Me.DG_Stock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabAlta.ResumeLayout(False)
        Me.GB_Alta.ResumeLayout(False)
        Me.GB_Alta.PerformLayout()
        Me.TabModificacion.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Gb_Mod.ResumeLayout(False)
        Me.Gb_Mod.PerformLayout()
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
    Friend WithEvents chk_Habilitado As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
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
    Friend WithEvents id_Stock As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODUCTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Categoria As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Minimo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Actual As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Optimo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sucursal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Modificado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Modificar As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewImageColumn
End Class
