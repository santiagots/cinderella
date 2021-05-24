<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductosCat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductosCat))
        Me.TabCategorias = New System.Windows.Forms.TabControl()
        Me.TbListado = New System.Windows.Forms.TabPage()
        Me.DG_Categorias = New System.Windows.Forms.DataGridView()
        Me.id_Categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Habilitado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Eliminar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Modificar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TbAlta = New System.Windows.Forms.TabPage()
        Me.GB_Alta = New System.Windows.Forms.GroupBox()
        Me.chk_Habilitado = New System.Windows.Forms.CheckBox()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_descripcion = New System.Windows.Forms.Label()
        Me.Btn_Agregar = New System.Windows.Forms.Button()
        Me.TbMod = New System.Windows.Forms.TabPage()
        Me.GB_Buscar = New System.Windows.Forms.GroupBox()
        Me.DG_Buscador = New System.Windows.Forms.DataGridView()
        Me.id_Categoria_Bus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion_Bus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Habilitado_Bus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Eliminar_bus = New System.Windows.Forms.DataGridViewImageColumn()
        Me.txt_buscar = New System.Windows.Forms.TextBox()
        Me.Btn_Buscar = New System.Windows.Forms.Button()
        Me.lbl_descripcion_bus = New System.Windows.Forms.Label()
        Me.GB_Modificacion = New System.Windows.Forms.GroupBox()
        Me.txt_Descripcion_Bus = New System.Windows.Forms.TextBox()
        Me.chk_Habilitado_mod = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_descripcion_mod = New System.Windows.Forms.Label()
        Me.Btn_Modificar = New System.Windows.Forms.Button()
        Me.ErrorCategorias = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TabCategorias.SuspendLayout()
        Me.TbListado.SuspendLayout()
        CType(Me.DG_Categorias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TbAlta.SuspendLayout()
        Me.GB_Alta.SuspendLayout()
        Me.TbMod.SuspendLayout()
        Me.GB_Buscar.SuspendLayout()
        CType(Me.DG_Buscador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_Modificacion.SuspendLayout()
        CType(Me.ErrorCategorias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabCategorias
        '
        Me.TabCategorias.Controls.Add(Me.TbListado)
        Me.TabCategorias.Controls.Add(Me.TbAlta)
        Me.TabCategorias.Controls.Add(Me.TbMod)
        Me.TabCategorias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabCategorias.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabCategorias.Location = New System.Drawing.Point(0, 0)
        Me.TabCategorias.Name = "TabCategorias"
        Me.TabCategorias.SelectedIndex = 0
        Me.TabCategorias.Size = New System.Drawing.Size(584, 543)
        Me.TabCategorias.TabIndex = 1
        '
        'TbListado
        '
        Me.TbListado.Controls.Add(Me.DG_Categorias)
        Me.TbListado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbListado.Location = New System.Drawing.Point(4, 29)
        Me.TbListado.Name = "TbListado"
        Me.TbListado.Padding = New System.Windows.Forms.Padding(3)
        Me.TbListado.Size = New System.Drawing.Size(576, 510)
        Me.TbListado.TabIndex = 0
        Me.TbListado.Text = "Categorias"
        Me.TbListado.UseVisualStyleBackColor = True
        '
        'DG_Categorias
        '
        Me.DG_Categorias.AllowUserToAddRows = False
        Me.DG_Categorias.AllowUserToDeleteRows = False
        Me.DG_Categorias.AllowUserToResizeColumns = False
        Me.DG_Categorias.AllowUserToResizeRows = False
        Me.DG_Categorias.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_Categorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_Categorias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_Categorias.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DG_Categorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Categorias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_Categoria, Me.Descripcion, Me.Habilitado, Me.Eliminar, Me.Modificar})
        Me.DG_Categorias.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DG_Categorias.DefaultCellStyle = DataGridViewCellStyle3
        Me.DG_Categorias.Location = New System.Drawing.Point(8, 6)
        Me.DG_Categorias.MultiSelect = False
        Me.DG_Categorias.Name = "DG_Categorias"
        Me.DG_Categorias.ReadOnly = True
        Me.DG_Categorias.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_Categorias.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DG_Categorias.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DG_Categorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Categorias.Size = New System.Drawing.Size(560, 484)
        Me.DG_Categorias.TabIndex = 0
        '
        'id_Categoria
        '
        Me.id_Categoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.id_Categoria.DataPropertyName = "id_Categoria"
        Me.id_Categoria.HeaderText = "ID"
        Me.id_Categoria.MaxInputLength = 255
        Me.id_Categoria.Name = "id_Categoria"
        Me.id_Categoria.ReadOnly = True
        Me.id_Categoria.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.id_Categoria.Width = 43
        '
        'Descripcion
        '
        Me.Descripcion.DataPropertyName = "Descripcion"
        Me.Descripcion.FillWeight = 207.7922!
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.MaxInputLength = 255
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Habilitado
        '
        Me.Habilitado.DataPropertyName = "Habilitado"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Habilitado.DefaultCellStyle = DataGridViewCellStyle2
        Me.Habilitado.FillWeight = 64.06922!
        Me.Habilitado.HeaderText = "Habilitado"
        Me.Habilitado.MaxInputLength = 10
        Me.Habilitado.Name = "Habilitado"
        Me.Habilitado.ReadOnly = True
        Me.Habilitado.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Eliminar
        '
        Me.Eliminar.FillWeight = 64.06922!
        Me.Eliminar.HeaderText = ""
        Me.Eliminar.Image = Global.SistemaCinderella.My.Resources.Recursos.Boton_Eliminar
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Eliminar.ToolTipText = "Eliminar Color"
        '
        'Modificar
        '
        Me.Modificar.FillWeight = 64.06922!
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
        Me.TbAlta.Size = New System.Drawing.Size(576, 510)
        Me.TbAlta.TabIndex = 1
        Me.TbAlta.Text = "Alta de Categoría"
        Me.TbAlta.UseVisualStyleBackColor = True
        '
        'GB_Alta
        '
        Me.GB_Alta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_Alta.Controls.Add(Me.chk_Habilitado)
        Me.GB_Alta.Controls.Add(Me.txt_descripcion)
        Me.GB_Alta.Controls.Add(Me.Label2)
        Me.GB_Alta.Controls.Add(Me.lbl_descripcion)
        Me.GB_Alta.Controls.Add(Me.Btn_Agregar)
        Me.GB_Alta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Alta.Location = New System.Drawing.Point(6, 6)
        Me.GB_Alta.Name = "GB_Alta"
        Me.GB_Alta.Size = New System.Drawing.Size(560, 128)
        Me.GB_Alta.TabIndex = 0
        Me.GB_Alta.TabStop = False
        Me.GB_Alta.Text = "Formulario de Alta"
        '
        'chk_Habilitado
        '
        Me.chk_Habilitado.AutoSize = True
        Me.chk_Habilitado.Checked = True
        Me.chk_Habilitado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Habilitado.Location = New System.Drawing.Point(91, 64)
        Me.chk_Habilitado.Name = "chk_Habilitado"
        Me.chk_Habilitado.Size = New System.Drawing.Size(15, 14)
        Me.chk_Habilitado.TabIndex = 2
        Me.chk_Habilitado.UseVisualStyleBackColor = True
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_descripcion.Location = New System.Drawing.Point(91, 30)
        Me.txt_descripcion.MaxLength = 255
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(463, 21)
        Me.txt_descripcion.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Habilitado"
        '
        'lbl_descripcion
        '
        Me.lbl_descripcion.AutoSize = True
        Me.lbl_descripcion.Location = New System.Drawing.Point(6, 33)
        Me.lbl_descripcion.Name = "lbl_descripcion"
        Me.lbl_descripcion.Size = New System.Drawing.Size(72, 15)
        Me.lbl_descripcion.TabIndex = 1
        Me.lbl_descripcion.Text = "Descripción"
        '
        'Btn_Agregar
        '
        Me.Btn_Agregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Agregar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Agregar.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Btn_Agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Agregar.Image = Global.SistemaCinderella.My.Resources.Recursos.Agregar_24
        Me.Btn_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Agregar.Location = New System.Drawing.Point(454, 82)
        Me.Btn_Agregar.Name = "Btn_Agregar"
        Me.Btn_Agregar.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Agregar.TabIndex = 3
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
        Me.TbMod.Size = New System.Drawing.Size(576, 510)
        Me.TbMod.TabIndex = 2
        Me.TbMod.Text = "Modificación de Categoría"
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
        Me.GB_Buscar.Size = New System.Drawing.Size(562, 360)
        Me.GB_Buscar.TabIndex = 2
        Me.GB_Buscar.TabStop = False
        Me.GB_Buscar.Text = "Buscar Categoría"
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
        Me.DG_Buscador.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_Categoria_Bus, Me.Descripcion_Bus, Me.Habilitado_Bus, Me.Eliminar_bus})
        Me.DG_Buscador.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DG_Buscador.Location = New System.Drawing.Point(9, 73)
        Me.DG_Buscador.MultiSelect = False
        Me.DG_Buscador.Name = "DG_Buscador"
        Me.DG_Buscador.ReadOnly = True
        Me.DG_Buscador.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DG_Buscador.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DG_Buscador.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Buscador.Size = New System.Drawing.Size(547, 278)
        Me.DG_Buscador.TabIndex = 3
        '
        'id_Categoria_Bus
        '
        Me.id_Categoria_Bus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.id_Categoria_Bus.DataPropertyName = "id_Categoria"
        Me.id_Categoria_Bus.HeaderText = "id_Categoria"
        Me.id_Categoria_Bus.MaxInputLength = 10
        Me.id_Categoria_Bus.Name = "id_Categoria_Bus"
        Me.id_Categoria_Bus.ReadOnly = True
        Me.id_Categoria_Bus.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.id_Categoria_Bus.Width = 102
        '
        'Descripcion_Bus
        '
        Me.Descripcion_Bus.DataPropertyName = "Descripcion"
        Me.Descripcion_Bus.FillWeight = 201.7096!
        Me.Descripcion_Bus.HeaderText = "Descripcion"
        Me.Descripcion_Bus.MaxInputLength = 220
        Me.Descripcion_Bus.Name = "Descripcion_Bus"
        Me.Descripcion_Bus.ReadOnly = True
        Me.Descripcion_Bus.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Habilitado_Bus
        '
        Me.Habilitado_Bus.DataPropertyName = "Habilitado"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Habilitado_Bus.DefaultCellStyle = DataGridViewCellStyle5
        Me.Habilitado_Bus.FillWeight = 56.60378!
        Me.Habilitado_Bus.HeaderText = "Habilitado"
        Me.Habilitado_Bus.MaxInputLength = 10
        Me.Habilitado_Bus.Name = "Habilitado_Bus"
        Me.Habilitado_Bus.ReadOnly = True
        Me.Habilitado_Bus.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Eliminar_bus
        '
        Me.Eliminar_bus.FillWeight = 41.68665!
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
        Me.txt_buscar.Size = New System.Drawing.Size(359, 21)
        Me.txt_buscar.TabIndex = 1
        '
        'Btn_Buscar
        '
        Me.Btn_Buscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Buscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Buscar.Image = Global.SistemaCinderella.My.Resources.Recursos.IconoBuscar32
        Me.Btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Buscar.Location = New System.Drawing.Point(456, 18)
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
        Me.GB_Modificacion.Controls.Add(Me.chk_Habilitado_mod)
        Me.GB_Modificacion.Controls.Add(Me.Label3)
        Me.GB_Modificacion.Controls.Add(Me.lbl_descripcion_mod)
        Me.GB_Modificacion.Controls.Add(Me.Btn_Modificar)
        Me.GB_Modificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Modificacion.Location = New System.Drawing.Point(6, 372)
        Me.GB_Modificacion.Name = "GB_Modificacion"
        Me.GB_Modificacion.Size = New System.Drawing.Size(562, 130)
        Me.GB_Modificacion.TabIndex = 1
        Me.GB_Modificacion.TabStop = False
        Me.GB_Modificacion.Text = "Modificación de Categoría"
        '
        'txt_Descripcion_Bus
        '
        Me.txt_Descripcion_Bus.Location = New System.Drawing.Point(91, 30)
        Me.txt_Descripcion_Bus.Name = "txt_Descripcion_Bus"
        Me.txt_Descripcion_Bus.Size = New System.Drawing.Size(465, 21)
        Me.txt_Descripcion_Bus.TabIndex = 6
        '
        'chk_Habilitado_mod
        '
        Me.chk_Habilitado_mod.AutoSize = True
        Me.chk_Habilitado_mod.Checked = True
        Me.chk_Habilitado_mod.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Habilitado_mod.Location = New System.Drawing.Point(91, 65)
        Me.chk_Habilitado_mod.Name = "chk_Habilitado_mod"
        Me.chk_Habilitado_mod.Size = New System.Drawing.Size(15, 14)
        Me.chk_Habilitado_mod.TabIndex = 4
        Me.chk_Habilitado_mod.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Habilitado"
        '
        'lbl_descripcion_mod
        '
        Me.lbl_descripcion_mod.AutoSize = True
        Me.lbl_descripcion_mod.Location = New System.Drawing.Point(6, 33)
        Me.lbl_descripcion_mod.Name = "lbl_descripcion_mod"
        Me.lbl_descripcion_mod.Size = New System.Drawing.Size(60, 15)
        Me.lbl_descripcion_mod.TabIndex = 1
        Me.lbl_descripcion_mod.Tag = " "
        Me.lbl_descripcion_mod.Text = "Categoría"
        '
        'Btn_Modificar
        '
        Me.Btn_Modificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Modificar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Modificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Modificar.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Btn_Modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Modificar.Image = Global.SistemaCinderella.My.Resources.Recursos.Editar_24
        Me.Btn_Modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Modificar.Location = New System.Drawing.Point(456, 84)
        Me.Btn_Modificar.Name = "Btn_Modificar"
        Me.Btn_Modificar.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Modificar.TabIndex = 5
        Me.Btn_Modificar.Text = "Modificar"
        Me.Btn_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Modificar.UseVisualStyleBackColor = False
        '
        'ErrorCategorias
        '
        Me.ErrorCategorias.BlinkRate = 200
        Me.ErrorCategorias.ContainerControl = Me
        '
        'frmProductosCat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 543)
        Me.Controls.Add(Me.TabCategorias)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmProductosCat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administración de Categorias de Productos"
        Me.TabCategorias.ResumeLayout(False)
        Me.TbListado.ResumeLayout(False)
        CType(Me.DG_Categorias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TbAlta.ResumeLayout(False)
        Me.GB_Alta.ResumeLayout(False)
        Me.GB_Alta.PerformLayout()
        Me.TbMod.ResumeLayout(False)
        Me.GB_Buscar.ResumeLayout(False)
        Me.GB_Buscar.PerformLayout()
        CType(Me.DG_Buscador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_Modificacion.ResumeLayout(False)
        Me.GB_Modificacion.PerformLayout()
        CType(Me.ErrorCategorias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabCategorias As System.Windows.Forms.TabControl
    Friend WithEvents TbListado As System.Windows.Forms.TabPage
    Friend WithEvents DG_Categorias As System.Windows.Forms.DataGridView
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
    Friend WithEvents ErrorCategorias As System.Windows.Forms.ErrorProvider
    Friend WithEvents txt_Descripcion_Bus As System.Windows.Forms.TextBox
    Friend WithEvents id_Categoria As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Habilitado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Modificar As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents id_Categoria_Bus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion_Bus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Habilitado_Bus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Eliminar_bus As System.Windows.Forms.DataGridViewImageColumn
End Class
