<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMateriales
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMateriales))
        Me.TabMateriales = New System.Windows.Forms.TabControl()
        Me.TbListado = New System.Windows.Forms.TabPage()
        Me.DG_Materiales = New System.Windows.Forms.DataGridView()
        Me.id_Material = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.id_Material_Bus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion_Bus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Habilitado_Bus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Eliminar_bus = New System.Windows.Forms.DataGridViewImageColumn()
        Me.txt_buscar = New System.Windows.Forms.TextBox()
        Me.Btn_Buscar = New System.Windows.Forms.Button()
        Me.lbl_descripcion_bus = New System.Windows.Forms.Label()
        Me.GB_Modificacion = New System.Windows.Forms.GroupBox()
        Me.txt_Descripcion_mod = New System.Windows.Forms.TextBox()
        Me.chk_Habilitado_mod = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_descripcion_mod = New System.Windows.Forms.Label()
        Me.Btn_Modificar = New System.Windows.Forms.Button()
        Me.ErrorMaterial = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TabMateriales.SuspendLayout()
        Me.TbListado.SuspendLayout()
        CType(Me.DG_Materiales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TbAlta.SuspendLayout()
        Me.GB_Alta.SuspendLayout()
        Me.TbMod.SuspendLayout()
        Me.GB_Buscar.SuspendLayout()
        CType(Me.DG_Buscador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_Modificacion.SuspendLayout()
        CType(Me.ErrorMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabMateriales
        '
        Me.TabMateriales.Controls.Add(Me.TbListado)
        Me.TabMateriales.Controls.Add(Me.TbAlta)
        Me.TabMateriales.Controls.Add(Me.TbMod)
        Me.TabMateriales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabMateriales.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabMateriales.Location = New System.Drawing.Point(0, 0)
        Me.TabMateriales.Name = "TabMateriales"
        Me.TabMateriales.SelectedIndex = 0
        Me.TabMateriales.Size = New System.Drawing.Size(584, 543)
        Me.TabMateriales.TabIndex = 1
        '
        'TbListado
        '
        Me.TbListado.Controls.Add(Me.DG_Materiales)
        Me.TbListado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbListado.Location = New System.Drawing.Point(4, 29)
        Me.TbListado.Name = "TbListado"
        Me.TbListado.Padding = New System.Windows.Forms.Padding(3)
        Me.TbListado.Size = New System.Drawing.Size(576, 510)
        Me.TbListado.TabIndex = 0
        Me.TbListado.Text = "Materiales"
        Me.TbListado.UseVisualStyleBackColor = True
        '
        'DG_Materiales
        '
        Me.DG_Materiales.AllowUserToAddRows = False
        Me.DG_Materiales.AllowUserToDeleteRows = False
        Me.DG_Materiales.AllowUserToResizeColumns = False
        Me.DG_Materiales.AllowUserToResizeRows = False
        Me.DG_Materiales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_Materiales.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DG_Materiales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_Material, Me.Descripcion, Me.Habilitado, Me.Eliminar, Me.Modificar})
        Me.DG_Materiales.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DG_Materiales.DefaultCellStyle = DataGridViewCellStyle2
        Me.DG_Materiales.Location = New System.Drawing.Point(8, 6)
        Me.DG_Materiales.MultiSelect = False
        Me.DG_Materiales.Name = "DG_Materiales"
        Me.DG_Materiales.ReadOnly = True
        Me.DG_Materiales.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_Materiales.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DG_Materiales.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DG_Materiales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Materiales.Size = New System.Drawing.Size(560, 484)
        Me.DG_Materiales.TabIndex = 0
        '
        'id_Material
        '
        Me.id_Material.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.id_Material.DataPropertyName = "id_Material"
        Me.id_Material.HeaderText = "ID"
        Me.id_Material.MaxInputLength = 255
        Me.id_Material.Name = "id_Material"
        Me.id_Material.ReadOnly = True
        Me.id_Material.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.id_Material.Width = 43
        '
        'Descripcion
        '
        Me.Descripcion.DataPropertyName = "Descripcion"
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.MaxInputLength = 255
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Habilitado
        '
        Me.Habilitado.DataPropertyName = "Habilitado"
        Me.Habilitado.HeaderText = "Habilitado"
        Me.Habilitado.MaxInputLength = 10
        Me.Habilitado.Name = "Habilitado"
        Me.Habilitado.ReadOnly = True
        Me.Habilitado.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = ""
        Me.Eliminar.Image = Global.SistemaCinderella.My.Resources.Recursos.Boton_Eliminar
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Eliminar.ToolTipText = "Eliminar Color"
        '
        'Modificar
        '
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
        Me.TbAlta.Text = "Alta de Material"
        Me.TbAlta.UseVisualStyleBackColor = True
        '
        'GB_Alta
        '
        Me.GB_Alta.Controls.Add(Me.chk_Habilitado)
        Me.GB_Alta.Controls.Add(Me.txt_descripcion)
        Me.GB_Alta.Controls.Add(Me.Label2)
        Me.GB_Alta.Controls.Add(Me.lbl_descripcion)
        Me.GB_Alta.Controls.Add(Me.Btn_Agregar)
        Me.GB_Alta.Location = New System.Drawing.Point(27, 27)
        Me.GB_Alta.Name = "GB_Alta"
        Me.GB_Alta.Size = New System.Drawing.Size(522, 189)
        Me.GB_Alta.TabIndex = 0
        Me.GB_Alta.TabStop = False
        Me.GB_Alta.Text = "Formulario de Alta"
        '
        'chk_Habilitado
        '
        Me.chk_Habilitado.AutoSize = True
        Me.chk_Habilitado.Checked = True
        Me.chk_Habilitado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Habilitado.Location = New System.Drawing.Point(91, 100)
        Me.chk_Habilitado.Name = "chk_Habilitado"
        Me.chk_Habilitado.Size = New System.Drawing.Size(15, 14)
        Me.chk_Habilitado.TabIndex = 2
        Me.chk_Habilitado.UseVisualStyleBackColor = True
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New System.Drawing.Point(91, 43)
        Me.txt_descripcion.MaxLength = 255
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(164, 20)
        Me.txt_descripcion.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Habilitado"
        '
        'lbl_descripcion
        '
        Me.lbl_descripcion.AutoSize = True
        Me.lbl_descripcion.Location = New System.Drawing.Point(6, 46)
        Me.lbl_descripcion.Name = "lbl_descripcion"
        Me.lbl_descripcion.Size = New System.Drawing.Size(63, 13)
        Me.lbl_descripcion.TabIndex = 1
        Me.lbl_descripcion.Text = "Descripción"
        '
        'Btn_Agregar
        '
        Me.Btn_Agregar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Agregar.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Btn_Agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Agregar.Image = Global.SistemaCinderella.My.Resources.Recursos.Boton_Agregar
        Me.Btn_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Agregar.Location = New System.Drawing.Point(401, 148)
        Me.Btn_Agregar.Name = "Btn_Agregar"
        Me.Btn_Agregar.Size = New System.Drawing.Size(115, 35)
        Me.Btn_Agregar.TabIndex = 3
        Me.Btn_Agregar.Text = "Agregar Material"
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
        Me.TbMod.Text = "Modificación de Material"
        Me.TbMod.UseVisualStyleBackColor = True
        '
        'GB_Buscar
        '
        Me.GB_Buscar.Controls.Add(Me.DG_Buscador)
        Me.GB_Buscar.Controls.Add(Me.txt_buscar)
        Me.GB_Buscar.Controls.Add(Me.Btn_Buscar)
        Me.GB_Buscar.Controls.Add(Me.lbl_descripcion_bus)
        Me.GB_Buscar.Location = New System.Drawing.Point(27, 27)
        Me.GB_Buscar.Name = "GB_Buscar"
        Me.GB_Buscar.Size = New System.Drawing.Size(526, 253)
        Me.GB_Buscar.TabIndex = 2
        Me.GB_Buscar.TabStop = False
        Me.GB_Buscar.Text = "Buscar Material"
        '
        'DG_Buscador
        '
        Me.DG_Buscador.AllowUserToAddRows = False
        Me.DG_Buscador.AllowUserToDeleteRows = False
        Me.DG_Buscador.AllowUserToResizeColumns = False
        Me.DG_Buscador.AllowUserToResizeRows = False
        Me.DG_Buscador.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_Buscador.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DG_Buscador.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_Material_Bus, Me.Descripcion_Bus, Me.Habilitado_Bus, Me.Eliminar_bus})
        Me.DG_Buscador.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DG_Buscador.DefaultCellStyle = DataGridViewCellStyle5
        Me.DG_Buscador.Location = New System.Drawing.Point(9, 73)
        Me.DG_Buscador.MultiSelect = False
        Me.DG_Buscador.Name = "DG_Buscador"
        Me.DG_Buscador.ReadOnly = True
        Me.DG_Buscador.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_Buscador.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DG_Buscador.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DG_Buscador.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Buscador.Size = New System.Drawing.Size(511, 171)
        Me.DG_Buscador.TabIndex = 3
        '
        'id_Material_Bus
        '
        Me.id_Material_Bus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.id_Material_Bus.DataPropertyName = "id_Material"
        Me.id_Material_Bus.HeaderText = "ID"
        Me.id_Material_Bus.MaxInputLength = 10
        Me.id_Material_Bus.Name = "id_Material_Bus"
        Me.id_Material_Bus.ReadOnly = True
        Me.id_Material_Bus.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.id_Material_Bus.Width = 43
        '
        'Descripcion_Bus
        '
        Me.Descripcion_Bus.DataPropertyName = "Descripcion"
        Me.Descripcion_Bus.HeaderText = "Descripcion"
        Me.Descripcion_Bus.MaxInputLength = 240
        Me.Descripcion_Bus.Name = "Descripcion_Bus"
        Me.Descripcion_Bus.ReadOnly = True
        Me.Descripcion_Bus.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Descripcion_Bus.Width = 240
        '
        'Habilitado_Bus
        '
        Me.Habilitado_Bus.DataPropertyName = "Habilitado"
        Me.Habilitado_Bus.HeaderText = "Habilitado"
        Me.Habilitado_Bus.MaxInputLength = 10
        Me.Habilitado_Bus.Name = "Habilitado_Bus"
        Me.Habilitado_Bus.ReadOnly = True
        Me.Habilitado_Bus.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Habilitado_Bus.Width = 95
        '
        'Eliminar_bus
        '
        Me.Eliminar_bus.HeaderText = ""
        Me.Eliminar_bus.Image = Global.SistemaCinderella.My.Resources.Recursos.Boton_Eliminar
        Me.Eliminar_bus.Name = "Eliminar_bus"
        Me.Eliminar_bus.ReadOnly = True
        Me.Eliminar_bus.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Eliminar_bus.ToolTipText = "Eliminar Color"
        Me.Eliminar_bus.Width = 50
        '
        'txt_buscar
        '
        Me.txt_buscar.Location = New System.Drawing.Point(91, 28)
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(252, 20)
        Me.txt_buscar.TabIndex = 1
        '
        'Btn_Buscar
        '
        Me.Btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Buscar.Image = Global.SistemaCinderella.My.Resources.Recursos.IconoBuscar32
        Me.Btn_Buscar.Location = New System.Drawing.Point(437, 19)
        Me.Btn_Buscar.Name = "Btn_Buscar"
        Me.Btn_Buscar.Size = New System.Drawing.Size(83, 34)
        Me.Btn_Buscar.TabIndex = 2
        Me.Btn_Buscar.UseVisualStyleBackColor = True
        '
        'lbl_descripcion_bus
        '
        Me.lbl_descripcion_bus.AutoSize = True
        Me.lbl_descripcion_bus.Location = New System.Drawing.Point(6, 31)
        Me.lbl_descripcion_bus.Name = "lbl_descripcion_bus"
        Me.lbl_descripcion_bus.Size = New System.Drawing.Size(63, 13)
        Me.lbl_descripcion_bus.TabIndex = 0
        Me.lbl_descripcion_bus.Text = "Descripción"
        '
        'GB_Modificacion
        '
        Me.GB_Modificacion.Controls.Add(Me.txt_Descripcion_mod)
        Me.GB_Modificacion.Controls.Add(Me.chk_Habilitado_mod)
        Me.GB_Modificacion.Controls.Add(Me.Label3)
        Me.GB_Modificacion.Controls.Add(Me.lbl_descripcion_mod)
        Me.GB_Modificacion.Controls.Add(Me.Btn_Modificar)
        Me.GB_Modificacion.Location = New System.Drawing.Point(27, 301)
        Me.GB_Modificacion.Name = "GB_Modificacion"
        Me.GB_Modificacion.Size = New System.Drawing.Size(526, 157)
        Me.GB_Modificacion.TabIndex = 1
        Me.GB_Modificacion.TabStop = False
        Me.GB_Modificacion.Text = "Modificación de Material"
        '
        'txt_Descripcion_mod
        '
        Me.txt_Descripcion_mod.Location = New System.Drawing.Point(91, 46)
        Me.txt_Descripcion_mod.Name = "txt_Descripcion_mod"
        Me.txt_Descripcion_mod.Size = New System.Drawing.Size(164, 20)
        Me.txt_Descripcion_mod.TabIndex = 6
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
        Me.Label3.Location = New System.Drawing.Point(6, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Habilitado"
        '
        'lbl_descripcion_mod
        '
        Me.lbl_descripcion_mod.AutoSize = True
        Me.lbl_descripcion_mod.Location = New System.Drawing.Point(6, 46)
        Me.lbl_descripcion_mod.Name = "lbl_descripcion_mod"
        Me.lbl_descripcion_mod.Size = New System.Drawing.Size(44, 13)
        Me.lbl_descripcion_mod.TabIndex = 1
        Me.lbl_descripcion_mod.Tag = " "
        Me.lbl_descripcion_mod.Text = "Material"
        '
        'Btn_Modificar
        '
        Me.Btn_Modificar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Modificar.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Btn_Modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Modificar.Image = Global.SistemaCinderella.My.Resources.Recursos.Boton_Editar
        Me.Btn_Modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Modificar.Location = New System.Drawing.Point(405, 116)
        Me.Btn_Modificar.Name = "Btn_Modificar"
        Me.Btn_Modificar.Size = New System.Drawing.Size(115, 35)
        Me.Btn_Modificar.TabIndex = 5
        Me.Btn_Modificar.Text = "Modificar Material"
        Me.Btn_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Modificar.UseVisualStyleBackColor = False
        '
        'ErrorMaterial
        '
        Me.ErrorMaterial.BlinkRate = 200
        Me.ErrorMaterial.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink
        Me.ErrorMaterial.ContainerControl = Me
        '
        'frmMateriales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 543)
        Me.Controls.Add(Me.TabMateriales)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMateriales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administración de Materiales"
        Me.TabMateriales.ResumeLayout(False)
        Me.TbListado.ResumeLayout(False)
        CType(Me.DG_Materiales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TbAlta.ResumeLayout(False)
        Me.GB_Alta.ResumeLayout(False)
        Me.GB_Alta.PerformLayout()
        Me.TbMod.ResumeLayout(False)
        Me.GB_Buscar.ResumeLayout(False)
        Me.GB_Buscar.PerformLayout()
        CType(Me.DG_Buscador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_Modificacion.ResumeLayout(False)
        Me.GB_Modificacion.PerformLayout()
        CType(Me.ErrorMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabMateriales As System.Windows.Forms.TabControl
    Friend WithEvents TbListado As System.Windows.Forms.TabPage
    Friend WithEvents DG_Materiales As System.Windows.Forms.DataGridView
    Friend WithEvents id_Material As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Habilitado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Modificar As System.Windows.Forms.DataGridViewImageColumn
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
    Friend WithEvents ErrorMaterial As System.Windows.Forms.ErrorProvider
    Friend WithEvents id_Material_Bus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion_Bus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Habilitado_Bus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Eliminar_bus As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents txt_Descripcion_mod As System.Windows.Forms.TextBox
End Class
