﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmColores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmColores))
        Me.TabColores = New System.Windows.Forms.TabControl()
        Me.TbListado = New System.Windows.Forms.TabPage()
        Me.DG_Colores = New System.Windows.Forms.DataGridView()
        Me.id_Color = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.id_Color_Bus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion_Bus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Habilitado_Bus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Eliminar_bus = New System.Windows.Forms.DataGridViewImageColumn()
        Me.txt_buscar = New System.Windows.Forms.TextBox()
        Me.Btn_Buscar = New System.Windows.Forms.Button()
        Me.lbl_descripcion_bus = New System.Windows.Forms.Label()
        Me.GB_Modificacion = New System.Windows.Forms.GroupBox()
        Me.txt_Modificar = New System.Windows.Forms.TextBox()
        Me.chk_Habilitado_mod = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_descripcion_mod = New System.Windows.Forms.Label()
        Me.Btn_Modificar = New System.Windows.Forms.Button()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn3 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ErrorColores = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TabColores.SuspendLayout()
        Me.TbListado.SuspendLayout()
        CType(Me.DG_Colores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TbAlta.SuspendLayout()
        Me.GB_Alta.SuspendLayout()
        Me.TbMod.SuspendLayout()
        Me.GB_Buscar.SuspendLayout()
        CType(Me.DG_Buscador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_Modificacion.SuspendLayout()
        CType(Me.ErrorColores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabColores
        '
        Me.TabColores.Controls.Add(Me.TbListado)
        Me.TabColores.Controls.Add(Me.TbAlta)
        Me.TabColores.Controls.Add(Me.TbMod)
        Me.TabColores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabColores.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabColores.Location = New System.Drawing.Point(0, 0)
        Me.TabColores.Name = "TabColores"
        Me.TabColores.SelectedIndex = 0
        Me.TabColores.Size = New System.Drawing.Size(574, 532)
        Me.TabColores.TabIndex = 0
        '
        'TbListado
        '
        Me.TbListado.Controls.Add(Me.DG_Colores)
        Me.TbListado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbListado.Location = New System.Drawing.Point(4, 29)
        Me.TbListado.Name = "TbListado"
        Me.TbListado.Padding = New System.Windows.Forms.Padding(3)
        Me.TbListado.Size = New System.Drawing.Size(566, 499)
        Me.TbListado.TabIndex = 0
        Me.TbListado.Text = "Colores"
        Me.TbListado.UseVisualStyleBackColor = True
        '
        'DG_Colores
        '
        Me.DG_Colores.AllowUserToAddRows = False
        Me.DG_Colores.AllowUserToDeleteRows = False
        Me.DG_Colores.AllowUserToResizeColumns = False
        Me.DG_Colores.AllowUserToResizeRows = False
        Me.DG_Colores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_Colores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_Color, Me.Descripcion, Me.Habilitado, Me.Eliminar, Me.Modificar})
        Me.DG_Colores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DG_Colores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_Colores.Location = New System.Drawing.Point(3, 3)
        Me.DG_Colores.MultiSelect = False
        Me.DG_Colores.Name = "DG_Colores"
        Me.DG_Colores.ReadOnly = True
        Me.DG_Colores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DG_Colores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DG_Colores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Colores.Size = New System.Drawing.Size(560, 493)
        Me.DG_Colores.TabIndex = 0
        '
        'id_Color
        '
        Me.id_Color.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.id_Color.DataPropertyName = "id_Color"
        Me.id_Color.HeaderText = "ID"
        Me.id_Color.MaxInputLength = 255
        Me.id_Color.Name = "id_Color"
        Me.id_Color.ReadOnly = True
        Me.id_Color.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.id_Color.Width = 43
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
        Me.TbAlta.Size = New System.Drawing.Size(566, 499)
        Me.TbAlta.TabIndex = 1
        Me.TbAlta.Text = "Alta de Color"
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
        Me.GB_Alta.Location = New System.Drawing.Point(6, 6)
        Me.GB_Alta.Name = "GB_Alta"
        Me.GB_Alta.Size = New System.Drawing.Size(552, 104)
        Me.GB_Alta.TabIndex = 0
        Me.GB_Alta.TabStop = False
        Me.GB_Alta.Text = "Formulario de Alta"
        '
        'chk_Habilitado
        '
        Me.chk_Habilitado.AutoSize = True
        Me.chk_Habilitado.Checked = True
        Me.chk_Habilitado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Habilitado.Location = New System.Drawing.Point(91, 54)
        Me.chk_Habilitado.Name = "chk_Habilitado"
        Me.chk_Habilitado.Size = New System.Drawing.Size(15, 14)
        Me.chk_Habilitado.TabIndex = 2
        Me.chk_Habilitado.UseVisualStyleBackColor = True
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_descripcion.Location = New System.Drawing.Point(91, 19)
        Me.txt_descripcion.MaxLength = 255
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(455, 20)
        Me.txt_descripcion.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Habilitado"
        '
        'lbl_descripcion
        '
        Me.lbl_descripcion.AutoSize = True
        Me.lbl_descripcion.Location = New System.Drawing.Point(6, 22)
        Me.lbl_descripcion.Name = "lbl_descripcion"
        Me.lbl_descripcion.Size = New System.Drawing.Size(63, 13)
        Me.lbl_descripcion.TabIndex = 1
        Me.lbl_descripcion.Text = "Descripción"
        '
        'Btn_Agregar
        '
        Me.Btn_Agregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Agregar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Agregar.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Btn_Agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Agregar.Image = Global.SistemaCinderella.My.Resources.Recursos.Boton_Agregar
        Me.Btn_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Agregar.Location = New System.Drawing.Point(441, 63)
        Me.Btn_Agregar.Name = "Btn_Agregar"
        Me.Btn_Agregar.Size = New System.Drawing.Size(105, 35)
        Me.Btn_Agregar.TabIndex = 3
        Me.Btn_Agregar.Text = "Agregar Color"
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
        Me.TbMod.Size = New System.Drawing.Size(566, 499)
        Me.TbMod.TabIndex = 2
        Me.TbMod.Text = "Modificación de Color"
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
        Me.GB_Buscar.Location = New System.Drawing.Point(8, 3)
        Me.GB_Buscar.Name = "GB_Buscar"
        Me.GB_Buscar.Size = New System.Drawing.Size(550, 384)
        Me.GB_Buscar.TabIndex = 2
        Me.GB_Buscar.TabStop = False
        Me.GB_Buscar.Text = "Buscar Color"
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
        Me.DG_Buscador.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_Color_Bus, Me.Descripcion_Bus, Me.Habilitado_Bus, Me.Eliminar_bus})
        Me.DG_Buscador.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DG_Buscador.Location = New System.Drawing.Point(9, 73)
        Me.DG_Buscador.MultiSelect = False
        Me.DG_Buscador.Name = "DG_Buscador"
        Me.DG_Buscador.ReadOnly = True
        Me.DG_Buscador.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DG_Buscador.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DG_Buscador.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Buscador.Size = New System.Drawing.Size(535, 302)
        Me.DG_Buscador.TabIndex = 3
        '
        'id_Color_Bus
        '
        Me.id_Color_Bus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.id_Color_Bus.DataPropertyName = "id_Color"
        Me.id_Color_Bus.HeaderText = "id_Color"
        Me.id_Color_Bus.MaxInputLength = 10
        Me.id_Color_Bus.Name = "id_Color_Bus"
        Me.id_Color_Bus.ReadOnly = True
        Me.id_Color_Bus.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.id_Color_Bus.Width = 70
        '
        'Descripcion_Bus
        '
        Me.Descripcion_Bus.DataPropertyName = "Descripcion"
        Me.Descripcion_Bus.HeaderText = "Descripcion"
        Me.Descripcion_Bus.MaxInputLength = 240
        Me.Descripcion_Bus.Name = "Descripcion_Bus"
        Me.Descripcion_Bus.ReadOnly = True
        Me.Descripcion_Bus.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Habilitado_Bus
        '
        Me.Habilitado_Bus.DataPropertyName = "Habilitado"
        Me.Habilitado_Bus.HeaderText = "Habilitado"
        Me.Habilitado_Bus.MaxInputLength = 10
        Me.Habilitado_Bus.Name = "Habilitado_Bus"
        Me.Habilitado_Bus.ReadOnly = True
        Me.Habilitado_Bus.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Eliminar_bus
        '
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
        Me.txt_buscar.Location = New System.Drawing.Point(75, 30)
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(413, 20)
        Me.txt_buscar.TabIndex = 1
        '
        'Btn_Buscar
        '
        Me.Btn_Buscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Buscar.Image = Global.SistemaCinderella.My.Resources.Recursos.IconoBuscar32
        Me.Btn_Buscar.Location = New System.Drawing.Point(494, 19)
        Me.Btn_Buscar.Name = "Btn_Buscar"
        Me.Btn_Buscar.Size = New System.Drawing.Size(50, 43)
        Me.Btn_Buscar.TabIndex = 2
        Me.Btn_Buscar.UseVisualStyleBackColor = True
        '
        'lbl_descripcion_bus
        '
        Me.lbl_descripcion_bus.AutoSize = True
        Me.lbl_descripcion_bus.Location = New System.Drawing.Point(6, 33)
        Me.lbl_descripcion_bus.Name = "lbl_descripcion_bus"
        Me.lbl_descripcion_bus.Size = New System.Drawing.Size(63, 13)
        Me.lbl_descripcion_bus.TabIndex = 0
        Me.lbl_descripcion_bus.Text = "Descripción"
        '
        'GB_Modificacion
        '
        Me.GB_Modificacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_Modificacion.Controls.Add(Me.txt_Modificar)
        Me.GB_Modificacion.Controls.Add(Me.chk_Habilitado_mod)
        Me.GB_Modificacion.Controls.Add(Me.Label3)
        Me.GB_Modificacion.Controls.Add(Me.lbl_descripcion_mod)
        Me.GB_Modificacion.Controls.Add(Me.Btn_Modificar)
        Me.GB_Modificacion.Location = New System.Drawing.Point(8, 393)
        Me.GB_Modificacion.Name = "GB_Modificacion"
        Me.GB_Modificacion.Size = New System.Drawing.Size(550, 98)
        Me.GB_Modificacion.TabIndex = 1
        Me.GB_Modificacion.TabStop = False
        Me.GB_Modificacion.Text = "Modificación de Color"
        '
        'txt_Modificar
        '
        Me.txt_Modificar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Modificar.Location = New System.Drawing.Point(91, 19)
        Me.txt_Modificar.Name = "txt_Modificar"
        Me.txt_Modificar.Size = New System.Drawing.Size(453, 20)
        Me.txt_Modificar.TabIndex = 6
        '
        'chk_Habilitado_mod
        '
        Me.chk_Habilitado_mod.AutoSize = True
        Me.chk_Habilitado_mod.Checked = True
        Me.chk_Habilitado_mod.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Habilitado_mod.Location = New System.Drawing.Point(91, 51)
        Me.chk_Habilitado_mod.Name = "chk_Habilitado_mod"
        Me.chk_Habilitado_mod.Size = New System.Drawing.Size(15, 14)
        Me.chk_Habilitado_mod.TabIndex = 4
        Me.chk_Habilitado_mod.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Habilitado"
        '
        'lbl_descripcion_mod
        '
        Me.lbl_descripcion_mod.AutoSize = True
        Me.lbl_descripcion_mod.Location = New System.Drawing.Point(6, 22)
        Me.lbl_descripcion_mod.Name = "lbl_descripcion_mod"
        Me.lbl_descripcion_mod.Size = New System.Drawing.Size(31, 13)
        Me.lbl_descripcion_mod.TabIndex = 1
        Me.lbl_descripcion_mod.Tag = " "
        Me.lbl_descripcion_mod.Text = "Color"
        '
        'Btn_Modificar
        '
        Me.Btn_Modificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Modificar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Modificar.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Btn_Modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Modificar.Image = Global.SistemaCinderella.My.Resources.Recursos.Boton_Editar
        Me.Btn_Modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Modificar.Location = New System.Drawing.Point(429, 51)
        Me.Btn_Modificar.Name = "Btn_Modificar"
        Me.Btn_Modificar.Size = New System.Drawing.Size(115, 35)
        Me.Btn_Modificar.TabIndex = 5
        Me.Btn_Modificar.Text = "Modificar Color"
        Me.Btn_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Modificar.UseVisualStyleBackColor = False
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Image = Global.SistemaCinderella.My.Resources.Recursos.Boton_Eliminar
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewImageColumn1.ToolTipText = "Eliminar Color"
        Me.DataGridViewImageColumn1.Width = 50
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.HeaderText = ""
        Me.DataGridViewImageColumn2.Image = Global.SistemaCinderella.My.Resources.Recursos.Boton_Editar
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.ReadOnly = True
        Me.DataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewImageColumn2.Width = 50
        '
        'DataGridViewImageColumn3
        '
        Me.DataGridViewImageColumn3.HeaderText = ""
        Me.DataGridViewImageColumn3.Image = Global.SistemaCinderella.My.Resources.Recursos.Boton_Eliminar
        Me.DataGridViewImageColumn3.Name = "DataGridViewImageColumn3"
        Me.DataGridViewImageColumn3.ReadOnly = True
        Me.DataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewImageColumn3.ToolTipText = "Eliminar Color"
        Me.DataGridViewImageColumn3.Width = 50
        '
        'ErrorColores
        '
        Me.ErrorColores.BlinkRate = 200
        Me.ErrorColores.ContainerControl = Me
        '
        'frmColores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 532)
        Me.Controls.Add(Me.TabColores)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmColores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administración de Colores"
        Me.TabColores.ResumeLayout(False)
        Me.TbListado.ResumeLayout(False)
        CType(Me.DG_Colores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TbAlta.ResumeLayout(False)
        Me.GB_Alta.ResumeLayout(False)
        Me.GB_Alta.PerformLayout()
        Me.TbMod.ResumeLayout(False)
        Me.GB_Buscar.ResumeLayout(False)
        Me.GB_Buscar.PerformLayout()
        CType(Me.DG_Buscador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_Modificacion.ResumeLayout(False)
        Me.GB_Modificacion.PerformLayout()
        CType(Me.ErrorColores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabColores As System.Windows.Forms.TabControl
    Friend WithEvents TbListado As System.Windows.Forms.TabPage
    Friend WithEvents DG_Colores As System.Windows.Forms.DataGridView
    Friend WithEvents TbAlta As System.Windows.Forms.TabPage
    Friend WithEvents GB_Alta As System.Windows.Forms.GroupBox
    Friend WithEvents chk_Habilitado As System.Windows.Forms.CheckBox
    Friend WithEvents txt_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_descripcion As System.Windows.Forms.Label
    Friend WithEvents Btn_Agregar As System.Windows.Forms.Button
    Friend WithEvents TbMod As System.Windows.Forms.TabPage
    Friend WithEvents GB_Modificacion As System.Windows.Forms.GroupBox
    Friend WithEvents chk_Habilitado_mod As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbl_descripcion_mod As System.Windows.Forms.Label
    Friend WithEvents Btn_Modificar As System.Windows.Forms.Button
    Friend WithEvents DG_Buscador As System.Windows.Forms.DataGridView
    Friend WithEvents GB_Buscar As System.Windows.Forms.GroupBox
    Friend WithEvents txt_buscar As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents lbl_descripcion_bus As System.Windows.Forms.Label
    Friend WithEvents id_Color_Bus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion_Bus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Habilitado_Bus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Eliminar_bus As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents id_Color As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Habilitado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Modificar As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn3 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents ErrorColores As System.Windows.Forms.ErrorProvider
    Friend WithEvents txt_Modificar As System.Windows.Forms.TextBox
End Class
