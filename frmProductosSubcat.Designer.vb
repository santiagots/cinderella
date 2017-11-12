<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductosSubcat
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductosSubcat))
        Me.TabSubcategorias = New System.Windows.Forms.TabControl()
        Me.TbListado = New System.Windows.Forms.TabPage()
        Me.DG_Subcategorias = New System.Windows.Forms.DataGridView()
        Me.id_Subcategoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Habilitado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Eliminar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Modificar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TbAlta = New System.Windows.Forms.TabPage()
        Me.GB_Alta = New System.Windows.Forms.GroupBox()
        Me.Cb_Categorias = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chk_Habilitado = New System.Windows.Forms.CheckBox()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_descripcion = New System.Windows.Forms.Label()
        Me.Btn_Agregar = New System.Windows.Forms.Button()
        Me.TbMod = New System.Windows.Forms.TabPage()
        Me.GB_Buscar = New System.Windows.Forms.GroupBox()
        Me.DG_Buscador = New System.Windows.Forms.DataGridView()
        Me.id_Subcategoria_Bus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion_Bus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Categoria_Bus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Habilitado_Bus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Eliminar_bus = New System.Windows.Forms.DataGridViewImageColumn()
        Me.txt_buscar = New System.Windows.Forms.TextBox()
        Me.Btn_Buscar = New System.Windows.Forms.Button()
        Me.lbl_descripcion_bus = New System.Windows.Forms.Label()
        Me.GB_Modificacion = New System.Windows.Forms.GroupBox()
        Me.txt_Descripcion_Bus = New System.Windows.Forms.TextBox()
        Me.lbl_Subcategoria = New System.Windows.Forms.Label()
        Me.Cb_Categorias_Bus = New System.Windows.Forms.ComboBox()
        Me.chk_Habilitado_mod = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_descripcion_mod = New System.Windows.Forms.Label()
        Me.Btn_Modificar = New System.Windows.Forms.Button()
        Me.ErrorSubcategorias = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TabSubcategorias.SuspendLayout()
        Me.TbListado.SuspendLayout()
        CType(Me.DG_Subcategorias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TbAlta.SuspendLayout()
        Me.GB_Alta.SuspendLayout()
        Me.TbMod.SuspendLayout()
        Me.GB_Buscar.SuspendLayout()
        CType(Me.DG_Buscador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_Modificacion.SuspendLayout()
        CType(Me.ErrorSubcategorias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabSubcategorias
        '
        Me.TabSubcategorias.Controls.Add(Me.TbListado)
        Me.TabSubcategorias.Controls.Add(Me.TbAlta)
        Me.TabSubcategorias.Controls.Add(Me.TbMod)
        Me.TabSubcategorias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabSubcategorias.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabSubcategorias.Location = New System.Drawing.Point(0, 0)
        Me.TabSubcategorias.Name = "TabSubcategorias"
        Me.TabSubcategorias.SelectedIndex = 0
        Me.TabSubcategorias.Size = New System.Drawing.Size(614, 543)
        Me.TabSubcategorias.TabIndex = 2
        '
        'TbListado
        '
        Me.TbListado.Controls.Add(Me.DG_Subcategorias)
        Me.TbListado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbListado.Location = New System.Drawing.Point(4, 29)
        Me.TbListado.Name = "TbListado"
        Me.TbListado.Padding = New System.Windows.Forms.Padding(3)
        Me.TbListado.Size = New System.Drawing.Size(606, 510)
        Me.TbListado.TabIndex = 0
        Me.TbListado.Text = "Subcategorias"
        Me.TbListado.UseVisualStyleBackColor = True
        '
        'DG_Subcategorias
        '
        Me.DG_Subcategorias.AllowUserToAddRows = False
        Me.DG_Subcategorias.AllowUserToDeleteRows = False
        Me.DG_Subcategorias.AllowUserToResizeColumns = False
        Me.DG_Subcategorias.AllowUserToResizeRows = False
        Me.DG_Subcategorias.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_Subcategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_Subcategorias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_Subcategorias.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DG_Subcategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Subcategorias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_Subcategoria, Me.Categoria, Me.Descripcion, Me.Habilitado, Me.Eliminar, Me.Modificar})
        Me.DG_Subcategorias.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DG_Subcategorias.DefaultCellStyle = DataGridViewCellStyle3
        Me.DG_Subcategorias.Location = New System.Drawing.Point(3, 6)
        Me.DG_Subcategorias.MultiSelect = False
        Me.DG_Subcategorias.Name = "DG_Subcategorias"
        Me.DG_Subcategorias.ReadOnly = True
        Me.DG_Subcategorias.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_Subcategorias.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DG_Subcategorias.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DG_Subcategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Subcategorias.Size = New System.Drawing.Size(597, 488)
        Me.DG_Subcategorias.TabIndex = 0
        '
        'id_Subcategoria
        '
        Me.id_Subcategoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.id_Subcategoria.DataPropertyName = "id_Subcategoria"
        Me.id_Subcategoria.HeaderText = "ID"
        Me.id_Subcategoria.MaxInputLength = 255
        Me.id_Subcategoria.Name = "id_Subcategoria"
        Me.id_Subcategoria.ReadOnly = True
        Me.id_Subcategoria.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.id_Subcategoria.Width = 43
        '
        'Categoria
        '
        Me.Categoria.DataPropertyName = "Categoria"
        Me.Categoria.FillWeight = 145.9455!
        Me.Categoria.HeaderText = "Categoria"
        Me.Categoria.Name = "Categoria"
        Me.Categoria.ReadOnly = True
        '
        'Descripcion
        '
        Me.Descripcion.DataPropertyName = "Descripcion"
        Me.Descripcion.FillWeight = 159.9394!
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.MaxInputLength = 150
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Habilitado
        '
        Me.Habilitado.DataPropertyName = "Habilitado"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Habilitado.DefaultCellStyle = DataGridViewCellStyle2
        Me.Habilitado.FillWeight = 81.16883!
        Me.Habilitado.HeaderText = "Habilitado"
        Me.Habilitado.MaxInputLength = 10
        Me.Habilitado.Name = "Habilitado"
        Me.Habilitado.ReadOnly = True
        Me.Habilitado.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Eliminar
        '
        Me.Eliminar.FillWeight = 52.59766!
        Me.Eliminar.HeaderText = ""
        Me.Eliminar.Image = Global.SistemaCinderella.My.Resources.Recursos.Boton_Eliminar
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Eliminar.ToolTipText = "Eliminar Color"
        '
        'Modificar
        '
        Me.Modificar.FillWeight = 60.34863!
        Me.Modificar.HeaderText = ""
        Me.Modificar.Image = Global.SistemaCinderella.My.Resources.Recursos.Boton_Editar
        Me.Modificar.Name = "Modificar"
        Me.Modificar.ReadOnly = True
        Me.Modificar.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'TbAlta
        '
        Me.TbAlta.Controls.Add(Me.GB_Alta)
        Me.TbAlta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbAlta.Location = New System.Drawing.Point(4, 29)
        Me.TbAlta.Name = "TbAlta"
        Me.TbAlta.Padding = New System.Windows.Forms.Padding(3)
        Me.TbAlta.Size = New System.Drawing.Size(606, 510)
        Me.TbAlta.TabIndex = 1
        Me.TbAlta.Text = "Alta de Subcategoría"
        Me.TbAlta.UseVisualStyleBackColor = True
        '
        'GB_Alta
        '
        Me.GB_Alta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_Alta.Controls.Add(Me.Cb_Categorias)
        Me.GB_Alta.Controls.Add(Me.Label1)
        Me.GB_Alta.Controls.Add(Me.chk_Habilitado)
        Me.GB_Alta.Controls.Add(Me.txt_descripcion)
        Me.GB_Alta.Controls.Add(Me.Label2)
        Me.GB_Alta.Controls.Add(Me.lbl_descripcion)
        Me.GB_Alta.Controls.Add(Me.Btn_Agregar)
        Me.GB_Alta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Alta.Location = New System.Drawing.Point(6, 6)
        Me.GB_Alta.Name = "GB_Alta"
        Me.GB_Alta.Size = New System.Drawing.Size(590, 189)
        Me.GB_Alta.TabIndex = 0
        Me.GB_Alta.TabStop = False
        Me.GB_Alta.Text = "Formulario de Alta"
        '
        'Cb_Categorias
        '
        Me.Cb_Categorias.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cb_Categorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Categorias.FormattingEnabled = True
        Me.Cb_Categorias.Location = New System.Drawing.Point(91, 26)
        Me.Cb_Categorias.Name = "Cb_Categorias"
        Me.Cb_Categorias.Size = New System.Drawing.Size(493, 23)
        Me.Cb_Categorias.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Categoría"
        '
        'chk_Habilitado
        '
        Me.chk_Habilitado.AutoSize = True
        Me.chk_Habilitado.Checked = True
        Me.chk_Habilitado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Habilitado.Location = New System.Drawing.Point(92, 98)
        Me.chk_Habilitado.Name = "chk_Habilitado"
        Me.chk_Habilitado.Size = New System.Drawing.Size(15, 14)
        Me.chk_Habilitado.TabIndex = 3
        Me.chk_Habilitado.UseVisualStyleBackColor = True
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_descripcion.Location = New System.Drawing.Point(91, 62)
        Me.txt_descripcion.MaxLength = 255
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(493, 21)
        Me.txt_descripcion.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Habilitado"
        '
        'lbl_descripcion
        '
        Me.lbl_descripcion.AutoSize = True
        Me.lbl_descripcion.Location = New System.Drawing.Point(6, 65)
        Me.lbl_descripcion.Name = "lbl_descripcion"
        Me.lbl_descripcion.Size = New System.Drawing.Size(72, 15)
        Me.lbl_descripcion.TabIndex = 1
        Me.lbl_descripcion.Text = "Descripción"
        '
        'Btn_Agregar
        '
        Me.Btn_Agregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Agregar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Agregar.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Btn_Agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Agregar.Image = Global.SistemaCinderella.My.Resources.Recursos.Agregar_24
        Me.Btn_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Agregar.Location = New System.Drawing.Point(484, 143)
        Me.Btn_Agregar.Name = "Btn_Agregar"
        Me.Btn_Agregar.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Agregar.TabIndex = 4
        Me.Btn_Agregar.Text = "Agregar"
        Me.Btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Agregar.UseVisualStyleBackColor = False
        '
        'TbMod
        '
        Me.TbMod.Controls.Add(Me.GB_Buscar)
        Me.TbMod.Controls.Add(Me.GB_Modificacion)
        Me.TbMod.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbMod.Location = New System.Drawing.Point(4, 29)
        Me.TbMod.Name = "TbMod"
        Me.TbMod.Size = New System.Drawing.Size(606, 510)
        Me.TbMod.TabIndex = 2
        Me.TbMod.Text = "Modificación de Subcategoría"
        Me.TbMod.UseVisualStyleBackColor = True
        '
        'GB_Buscar
        '
        Me.GB_Buscar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_Buscar.Controls.Add(Me.DG_Buscador)
        Me.GB_Buscar.Controls.Add(Me.txt_buscar)
        Me.GB_Buscar.Controls.Add(Me.Btn_Buscar)
        Me.GB_Buscar.Controls.Add(Me.lbl_descripcion_bus)
        Me.GB_Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Buscar.Location = New System.Drawing.Point(6, 6)
        Me.GB_Buscar.Name = "GB_Buscar"
        Me.GB_Buscar.Size = New System.Drawing.Size(592, 333)
        Me.GB_Buscar.TabIndex = 2
        Me.GB_Buscar.TabStop = False
        Me.GB_Buscar.Text = "Buscar Subcategoría"
        '
        'DG_Buscador
        '
        Me.DG_Buscador.AllowUserToAddRows = False
        Me.DG_Buscador.AllowUserToDeleteRows = False
        Me.DG_Buscador.AllowUserToResizeColumns = False
        Me.DG_Buscador.AllowUserToResizeRows = False
        Me.DG_Buscador.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_Buscador.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_Buscador.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
        Me.DG_Buscador.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DG_Buscador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Buscador.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_Subcategoria_Bus, Me.Descripcion_Bus, Me.Categoria_Bus, Me.Habilitado_Bus, Me.Eliminar_bus})
        Me.DG_Buscador.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DG_Buscador.Location = New System.Drawing.Point(9, 73)
        Me.DG_Buscador.MultiSelect = False
        Me.DG_Buscador.Name = "DG_Buscador"
        Me.DG_Buscador.ReadOnly = True
        Me.DG_Buscador.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DG_Buscador.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DG_Buscador.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Buscador.Size = New System.Drawing.Size(577, 251)
        Me.DG_Buscador.TabIndex = 3
        '
        'id_Subcategoria_Bus
        '
        Me.id_Subcategoria_Bus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.id_Subcategoria_Bus.DataPropertyName = "id_Subcategoria"
        Me.id_Subcategoria_Bus.HeaderText = "ID"
        Me.id_Subcategoria_Bus.MaxInputLength = 10
        Me.id_Subcategoria_Bus.Name = "id_Subcategoria_Bus"
        Me.id_Subcategoria_Bus.ReadOnly = True
        Me.id_Subcategoria_Bus.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.id_Subcategoria_Bus.Width = 44
        '
        'Descripcion_Bus
        '
        Me.Descripcion_Bus.DataPropertyName = "Descripcion"
        Me.Descripcion_Bus.FillWeight = 111.6883!
        Me.Descripcion_Bus.HeaderText = "Descripcion"
        Me.Descripcion_Bus.MaxInputLength = 200
        Me.Descripcion_Bus.Name = "Descripcion_Bus"
        Me.Descripcion_Bus.ReadOnly = True
        Me.Descripcion_Bus.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Categoria_Bus
        '
        Me.Categoria_Bus.DataPropertyName = "Categoria"
        Me.Categoria_Bus.FillWeight = 111.6883!
        Me.Categoria_Bus.HeaderText = "Categoria"
        Me.Categoria_Bus.Name = "Categoria_Bus"
        Me.Categoria_Bus.ReadOnly = True
        '
        'Habilitado_Bus
        '
        Me.Habilitado_Bus.DataPropertyName = "Habilitado"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Habilitado_Bus.DefaultCellStyle = DataGridViewCellStyle5
        Me.Habilitado_Bus.FillWeight = 64.93506!
        Me.Habilitado_Bus.HeaderText = "Habilitado"
        Me.Habilitado_Bus.MaxInputLength = 10
        Me.Habilitado_Bus.Name = "Habilitado_Bus"
        Me.Habilitado_Bus.ReadOnly = True
        Me.Habilitado_Bus.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Eliminar_bus
        '
        Me.Eliminar_bus.FillWeight = 111.6883!
        Me.Eliminar_bus.HeaderText = ""
        Me.Eliminar_bus.Image = Global.SistemaCinderella.My.Resources.Recursos.Boton_Eliminar
        Me.Eliminar_bus.Name = "Eliminar_bus"
        Me.Eliminar_bus.ReadOnly = True
        Me.Eliminar_bus.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Eliminar_bus.ToolTipText = "Eliminar Color"
        '
        'txt_buscar
        '
        Me.txt_buscar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_buscar.Location = New System.Drawing.Point(91, 28)
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(389, 21)
        Me.txt_buscar.TabIndex = 1
        '
        'Btn_Buscar
        '
        Me.Btn_Buscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Buscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Buscar.Image = Global.SistemaCinderella.My.Resources.Recursos.IconoBuscar32
        Me.Btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Buscar.Location = New System.Drawing.Point(486, 18)
        Me.Btn_Buscar.Name = "Btn_Buscar"
        Me.Btn_Buscar.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Buscar.TabIndex = 2
        Me.Btn_Buscar.Text = "Buscar"
        Me.Btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Buscar.UseVisualStyleBackColor = True
        '
        'lbl_descripcion_bus
        '
        Me.lbl_descripcion_bus.AutoSize = True
        Me.lbl_descripcion_bus.Location = New System.Drawing.Point(6, 31)
        Me.lbl_descripcion_bus.Name = "lbl_descripcion_bus"
        Me.lbl_descripcion_bus.Size = New System.Drawing.Size(72, 15)
        Me.lbl_descripcion_bus.TabIndex = 0
        Me.lbl_descripcion_bus.Text = "Descripción"
        '
        'GB_Modificacion
        '
        Me.GB_Modificacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_Modificacion.Controls.Add(Me.txt_Descripcion_Bus)
        Me.GB_Modificacion.Controls.Add(Me.lbl_Subcategoria)
        Me.GB_Modificacion.Controls.Add(Me.Cb_Categorias_Bus)
        Me.GB_Modificacion.Controls.Add(Me.chk_Habilitado_mod)
        Me.GB_Modificacion.Controls.Add(Me.Label3)
        Me.GB_Modificacion.Controls.Add(Me.lbl_descripcion_mod)
        Me.GB_Modificacion.Controls.Add(Me.Btn_Modificar)
        Me.GB_Modificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Modificacion.Location = New System.Drawing.Point(6, 345)
        Me.GB_Modificacion.Name = "GB_Modificacion"
        Me.GB_Modificacion.Size = New System.Drawing.Size(592, 157)
        Me.GB_Modificacion.TabIndex = 1
        Me.GB_Modificacion.TabStop = False
        Me.GB_Modificacion.Text = "Modificación de Subcategoría"
        '
        'txt_Descripcion_Bus
        '
        Me.txt_Descripcion_Bus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Descripcion_Bus.Location = New System.Drawing.Point(91, 73)
        Me.txt_Descripcion_Bus.Name = "txt_Descripcion_Bus"
        Me.txt_Descripcion_Bus.Size = New System.Drawing.Size(495, 21)
        Me.txt_Descripcion_Bus.TabIndex = 8
        '
        'lbl_Subcategoria
        '
        Me.lbl_Subcategoria.AutoSize = True
        Me.lbl_Subcategoria.Location = New System.Drawing.Point(15, 71)
        Me.lbl_Subcategoria.Name = "lbl_Subcategoria"
        Me.lbl_Subcategoria.Size = New System.Drawing.Size(72, 15)
        Me.lbl_Subcategoria.TabIndex = 7
        Me.lbl_Subcategoria.Text = "Descripcion"
        '
        'Cb_Categorias_Bus
        '
        Me.Cb_Categorias_Bus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cb_Categorias_Bus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Categorias_Bus.FormattingEnabled = True
        Me.Cb_Categorias_Bus.Location = New System.Drawing.Point(91, 37)
        Me.Cb_Categorias_Bus.Name = "Cb_Categorias_Bus"
        Me.Cb_Categorias_Bus.Size = New System.Drawing.Size(495, 23)
        Me.Cb_Categorias_Bus.TabIndex = 6
        '
        'chk_Habilitado_mod
        '
        Me.chk_Habilitado_mod.AutoSize = True
        Me.chk_Habilitado_mod.Checked = True
        Me.chk_Habilitado_mod.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Habilitado_mod.Location = New System.Drawing.Point(91, 100)
        Me.chk_Habilitado_mod.Name = "chk_Habilitado_mod"
        Me.chk_Habilitado_mod.Size = New System.Drawing.Size(15, 14)
        Me.chk_Habilitado_mod.TabIndex = 4
        Me.chk_Habilitado_mod.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Habilitado"
        '
        'lbl_descripcion_mod
        '
        Me.lbl_descripcion_mod.AutoSize = True
        Me.lbl_descripcion_mod.Location = New System.Drawing.Point(15, 37)
        Me.lbl_descripcion_mod.Name = "lbl_descripcion_mod"
        Me.lbl_descripcion_mod.Size = New System.Drawing.Size(60, 15)
        Me.lbl_descripcion_mod.TabIndex = 1
        Me.lbl_descripcion_mod.Tag = " "
        Me.lbl_descripcion_mod.Text = "Categoría"
        '
        'Btn_Modificar
        '
        Me.Btn_Modificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Modificar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Modificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Modificar.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Btn_Modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Modificar.Image = Global.SistemaCinderella.My.Resources.Recursos.Editar_24
        Me.Btn_Modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Modificar.Location = New System.Drawing.Point(486, 111)
        Me.Btn_Modificar.Name = "Btn_Modificar"
        Me.Btn_Modificar.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Modificar.TabIndex = 5
        Me.Btn_Modificar.Text = "Modificar"
        Me.Btn_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Modificar.UseVisualStyleBackColor = False
        '
        'ErrorSubcategorias
        '
        Me.ErrorSubcategorias.BlinkRate = 200
        Me.ErrorSubcategorias.ContainerControl = Me
        '
        'frmProductosSubcat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 543)
        Me.Controls.Add(Me.TabSubcategorias)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmProductosSubcat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administración de Subcategorias de Productos"
        Me.TabSubcategorias.ResumeLayout(False)
        Me.TbListado.ResumeLayout(False)
        CType(Me.DG_Subcategorias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TbAlta.ResumeLayout(False)
        Me.GB_Alta.ResumeLayout(False)
        Me.GB_Alta.PerformLayout()
        Me.TbMod.ResumeLayout(False)
        Me.GB_Buscar.ResumeLayout(False)
        Me.GB_Buscar.PerformLayout()
        CType(Me.DG_Buscador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_Modificacion.ResumeLayout(False)
        Me.GB_Modificacion.PerformLayout()
        CType(Me.ErrorSubcategorias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabSubcategorias As System.Windows.Forms.TabControl
    Friend WithEvents TbListado As System.Windows.Forms.TabPage
    Friend WithEvents DG_Subcategorias As System.Windows.Forms.DataGridView
    Friend WithEvents TbAlta As System.Windows.Forms.TabPage
    Friend WithEvents GB_Alta As System.Windows.Forms.GroupBox
    Friend WithEvents chk_Habilitado As System.Windows.Forms.CheckBox
    Friend WithEvents txt_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_descripcion As System.Windows.Forms.Label
    Friend WithEvents Btn_Agregar As System.Windows.Forms.Button
    Friend WithEvents TbMod As System.Windows.Forms.TabPage
    Friend WithEvents GB_Buscar As System.Windows.Forms.GroupBox
    Friend WithEvents DG_Buscador As System.Windows.Forms.DataGridView
    Friend WithEvents txt_buscar As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents lbl_descripcion_bus As System.Windows.Forms.Label
    Friend WithEvents GB_Modificacion As System.Windows.Forms.GroupBox
    Friend WithEvents chk_Habilitado_mod As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbl_descripcion_mod As System.Windows.Forms.Label
    Friend WithEvents Btn_Modificar As System.Windows.Forms.Button
    Friend WithEvents Cb_Categorias As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_Descripcion_Bus As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Subcategoria As System.Windows.Forms.Label
    Friend WithEvents Cb_Categorias_Bus As System.Windows.Forms.ComboBox
    Friend WithEvents ErrorSubcategorias As System.Windows.Forms.ErrorProvider
    Friend WithEvents id_Subcategoria As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Categoria As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Habilitado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Modificar As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents id_Subcategoria_Bus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion_Bus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Categoria_Bus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Habilitado_Bus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Eliminar_bus As System.Windows.Forms.DataGridViewImageColumn
End Class
