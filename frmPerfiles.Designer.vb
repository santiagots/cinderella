<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPerfiles
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPerfiles))
        Me.TabPerfiles = New System.Windows.Forms.TabControl()
        Me.TbListado = New System.Windows.Forms.TabPage()
        Me.lbl_Msg = New System.Windows.Forms.Label()
        Me.GB_Buscar = New System.Windows.Forms.GroupBox()
        Me.btn_Restablecer = New System.Windows.Forms.Button()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.txt_buscar = New System.Windows.Forms.TextBox()
        Me.lbl_descripcion_bus = New System.Windows.Forms.Label()
        Me.DG_Perfiles = New System.Windows.Forms.DataGridView()
        Me.id_Perfil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Habilitado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Modificar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Eliminar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TbAlta = New System.Windows.Forms.TabPage()
        Me.GB_Alta = New System.Windows.Forms.GroupBox()
        Me.Chk_Selected2 = New System.Windows.Forms.CheckBox()
        Me.Chk_Selected = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Cb_Filtros = New System.Windows.Forms.ComboBox()
        Me.Btn_EliminarPate = New System.Windows.Forms.Button()
        Me.Btn_AgregarPate = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ListPatentesSelec = New System.Windows.Forms.ListBox()
        Me.ListPatentes = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chk_Habilitado = New System.Windows.Forms.CheckBox()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_descripcion = New System.Windows.Forms.Label()
        Me.Btn_Agregar = New System.Windows.Forms.Button()
        Me.TbMod = New System.Windows.Forms.TabPage()
        Me.GB_Modificacion = New System.Windows.Forms.GroupBox()
        Me.Chk_Selected2_Mod = New System.Windows.Forms.CheckBox()
        Me.Chk_Selected_Mod = New System.Windows.Forms.CheckBox()
        Me.Btn_EliminarPatMod = New System.Windows.Forms.Button()
        Me.Btn_AgregarPateMod = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Cb_FiltrosMod = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ListPatentesSelecMod = New System.Windows.Forms.ListBox()
        Me.ListPatentesMod = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_Perfil = New System.Windows.Forms.Label()
        Me.chk_Habilitado_mod = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_descripcion_mod = New System.Windows.Forms.Label()
        Me.Btn_Modificar = New System.Windows.Forms.Button()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TipAgregar = New System.Windows.Forms.ToolTip(Me.components)
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.TabPerfiles.SuspendLayout()
        Me.TbListado.SuspendLayout()
        Me.GB_Buscar.SuspendLayout()
        CType(Me.DG_Perfiles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TbAlta.SuspendLayout()
        Me.GB_Alta.SuspendLayout()
        Me.TbMod.SuspendLayout()
        Me.GB_Modificacion.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPerfiles
        '
        Me.TabPerfiles.Controls.Add(Me.TbListado)
        Me.TabPerfiles.Controls.Add(Me.TbAlta)
        Me.TabPerfiles.Controls.Add(Me.TbMod)
        Me.TabPerfiles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabPerfiles.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPerfiles.Location = New System.Drawing.Point(0, 0)
        Me.TabPerfiles.Name = "TabPerfiles"
        Me.TabPerfiles.SelectedIndex = 0
        Me.TabPerfiles.Size = New System.Drawing.Size(674, 572)
        Me.TabPerfiles.TabIndex = 1
        '
        'TbListado
        '
        Me.TbListado.Controls.Add(Me.lbl_Msg)
        Me.TbListado.Controls.Add(Me.GB_Buscar)
        Me.TbListado.Controls.Add(Me.DG_Perfiles)
        Me.TbListado.Location = New System.Drawing.Point(4, 29)
        Me.TbListado.Name = "TbListado"
        Me.TbListado.Padding = New System.Windows.Forms.Padding(3)
        Me.TbListado.Size = New System.Drawing.Size(666, 539)
        Me.TbListado.TabIndex = 0
        Me.TbListado.Text = "Perfiles"
        Me.TbListado.UseVisualStyleBackColor = True
        '
        'lbl_Msg
        '
        Me.lbl_Msg.AutoSize = True
        Me.lbl_Msg.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lbl_Msg.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Msg.Location = New System.Drawing.Point(148, 294)
        Me.lbl_Msg.Name = "lbl_Msg"
        Me.lbl_Msg.Size = New System.Drawing.Size(371, 29)
        Me.lbl_Msg.TabIndex = 4
        Me.lbl_Msg.Text = "No se han encontrado perfiles."
        '
        'GB_Buscar
        '
        Me.GB_Buscar.Controls.Add(Me.btn_Restablecer)
        Me.GB_Buscar.Controls.Add(Me.btn_Buscar)
        Me.GB_Buscar.Controls.Add(Me.txt_buscar)
        Me.GB_Buscar.Controls.Add(Me.lbl_descripcion_bus)
        Me.GB_Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Buscar.Location = New System.Drawing.Point(10, 6)
        Me.GB_Buscar.Name = "GB_Buscar"
        Me.GB_Buscar.Size = New System.Drawing.Size(649, 70)
        Me.GB_Buscar.TabIndex = 3
        Me.GB_Buscar.TabStop = False
        Me.GB_Buscar.Text = "Buscador de perfiles por nombre."
        '
        'btn_Restablecer
        '
        Me.btn_Restablecer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Restablecer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Restablecer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Restablecer.Location = New System.Drawing.Point(437, 20)
        Me.btn_Restablecer.Name = "btn_Restablecer"
        Me.btn_Restablecer.Size = New System.Drawing.Size(100, 40)
        Me.btn_Restablecer.TabIndex = 9
        Me.btn_Restablecer.Text = "Restablecer Busqueda"
        Me.btn_Restablecer.UseVisualStyleBackColor = True
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Buscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Buscar.Image = Global.SistemaCinderella.My.Resources.Recursos.IconoBuscar32
        Me.btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Buscar.Location = New System.Drawing.Point(543, 20)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(100, 40)
        Me.btn_Buscar.TabIndex = 6
        Me.btn_Buscar.Text = "Buscar"
        Me.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TipAgregar.SetToolTip(Me.btn_Buscar, "Haz click aquí para buscar perfiles con los criterios de busqueda seleccionados.")
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'txt_buscar
        '
        Me.txt_buscar.Location = New System.Drawing.Point(93, 30)
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(243, 21)
        Me.txt_buscar.TabIndex = 1
        '
        'lbl_descripcion_bus
        '
        Me.lbl_descripcion_bus.AutoSize = True
        Me.lbl_descripcion_bus.Location = New System.Drawing.Point(6, 33)
        Me.lbl_descripcion_bus.Name = "lbl_descripcion_bus"
        Me.lbl_descripcion_bus.Size = New System.Drawing.Size(72, 15)
        Me.lbl_descripcion_bus.TabIndex = 0
        Me.lbl_descripcion_bus.Text = "Descripción"
        '
        'DG_Perfiles
        '
        Me.DG_Perfiles.AllowUserToAddRows = False
        Me.DG_Perfiles.AllowUserToDeleteRows = False
        Me.DG_Perfiles.AllowUserToResizeColumns = False
        Me.DG_Perfiles.AllowUserToResizeRows = False
        Me.DG_Perfiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_Perfiles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_Perfil, Me.Descripcion, Me.Habilitado, Me.Modificar, Me.Eliminar})
        Me.DG_Perfiles.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DG_Perfiles.Location = New System.Drawing.Point(10, 82)
        Me.DG_Perfiles.MultiSelect = False
        Me.DG_Perfiles.Name = "DG_Perfiles"
        Me.DG_Perfiles.ReadOnly = True
        Me.DG_Perfiles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DG_Perfiles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DG_Perfiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Perfiles.Size = New System.Drawing.Size(649, 433)
        Me.DG_Perfiles.TabIndex = 0
        '
        'id_Perfil
        '
        Me.id_Perfil.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.id_Perfil.DataPropertyName = "id_Perfil"
        Me.id_Perfil.HeaderText = "ID"
        Me.id_Perfil.MaxInputLength = 10
        Me.id_Perfil.Name = "id_Perfil"
        Me.id_Perfil.ReadOnly = True
        Me.id_Perfil.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.id_Perfil.Width = 51
        '
        'Descripcion
        '
        Me.Descripcion.DataPropertyName = "Descripcion"
        Me.Descripcion.FillWeight = 290.8403!
        Me.Descripcion.HeaderText = "Descripción"
        Me.Descripcion.MaxInputLength = 150
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Habilitado
        '
        Me.Habilitado.DataPropertyName = "Habilitado"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Habilitado.DefaultCellStyle = DataGridViewCellStyle1
        Me.Habilitado.FillWeight = 36.36364!
        Me.Habilitado.HeaderText = "Habilitado"
        Me.Habilitado.MaxInputLength = 10
        Me.Habilitado.Name = "Habilitado"
        Me.Habilitado.ReadOnly = True
        Me.Habilitado.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Modificar
        '
        Me.Modificar.FillWeight = 36.52883!
        Me.Modificar.HeaderText = "Modificar"
        Me.Modificar.Image = Global.SistemaCinderella.My.Resources.Recursos.Boton_Editar
        Me.Modificar.Name = "Modificar"
        Me.Modificar.ReadOnly = True
        Me.Modificar.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Modificar.ToolTipText = "Modificar"
        '
        'Eliminar
        '
        Me.Eliminar.FillWeight = 36.26725!
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Image = Global.SistemaCinderella.My.Resources.Recursos.Boton_Eliminar
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Eliminar.ToolTipText = "Eliminar"
        '
        'TbAlta
        '
        Me.TbAlta.Controls.Add(Me.GB_Alta)
        Me.TbAlta.Location = New System.Drawing.Point(4, 29)
        Me.TbAlta.Name = "TbAlta"
        Me.TbAlta.Padding = New System.Windows.Forms.Padding(3)
        Me.TbAlta.Size = New System.Drawing.Size(666, 539)
        Me.TbAlta.TabIndex = 1
        Me.TbAlta.Text = "Alta de Perfiles"
        Me.TbAlta.UseVisualStyleBackColor = True
        '
        'GB_Alta
        '
        Me.GB_Alta.Controls.Add(Me.Chk_Selected2)
        Me.GB_Alta.Controls.Add(Me.Chk_Selected)
        Me.GB_Alta.Controls.Add(Me.Label6)
        Me.GB_Alta.Controls.Add(Me.Cb_Filtros)
        Me.GB_Alta.Controls.Add(Me.Btn_EliminarPate)
        Me.GB_Alta.Controls.Add(Me.Btn_AgregarPate)
        Me.GB_Alta.Controls.Add(Me.Label5)
        Me.GB_Alta.Controls.Add(Me.ListPatentesSelec)
        Me.GB_Alta.Controls.Add(Me.ListPatentes)
        Me.GB_Alta.Controls.Add(Me.Label1)
        Me.GB_Alta.Controls.Add(Me.chk_Habilitado)
        Me.GB_Alta.Controls.Add(Me.txt_descripcion)
        Me.GB_Alta.Controls.Add(Me.Label2)
        Me.GB_Alta.Controls.Add(Me.lbl_descripcion)
        Me.GB_Alta.Controls.Add(Me.Btn_Agregar)
        Me.GB_Alta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Alta.Location = New System.Drawing.Point(8, 6)
        Me.GB_Alta.Name = "GB_Alta"
        Me.GB_Alta.Size = New System.Drawing.Size(651, 520)
        Me.GB_Alta.TabIndex = 0
        Me.GB_Alta.TabStop = False
        Me.GB_Alta.Text = "Formulario de alta de perfil"
        '
        'Chk_Selected2
        '
        Me.Chk_Selected2.AutoSize = True
        Me.Chk_Selected2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chk_Selected2.Location = New System.Drawing.Point(521, 449)
        Me.Chk_Selected2.Name = "Chk_Selected2"
        Me.Chk_Selected2.Size = New System.Drawing.Size(124, 19)
        Me.Chk_Selected2.TabIndex = 15
        Me.Chk_Selected2.Text = "Seleccionar todos"
        Me.Chk_Selected2.UseVisualStyleBackColor = True
        '
        'Chk_Selected
        '
        Me.Chk_Selected.AutoSize = True
        Me.Chk_Selected.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chk_Selected.Location = New System.Drawing.Point(7, 449)
        Me.Chk_Selected.Name = "Chk_Selected"
        Me.Chk_Selected.Size = New System.Drawing.Size(124, 19)
        Me.Chk_Selected.TabIndex = 14
        Me.Chk_Selected.Text = "Seleccionar todos"
        Me.Chk_Selected.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 15)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Filtrar patentes por"
        '
        'Cb_Filtros
        '
        Me.Cb_Filtros.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cb_Filtros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Filtros.FormattingEnabled = True
        Me.Cb_Filtros.Location = New System.Drawing.Point(145, 120)
        Me.Cb_Filtros.Name = "Cb_Filtros"
        Me.Cb_Filtros.Size = New System.Drawing.Size(198, 23)
        Me.Cb_Filtros.TabIndex = 3
        '
        'Btn_EliminarPate
        '
        Me.Btn_EliminarPate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_EliminarPate.FlatAppearance.BorderSize = 0
        Me.Btn_EliminarPate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_EliminarPate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_EliminarPate.Image = Global.SistemaCinderella.My.Resources.Recursos.flecha_izq
        Me.Btn_EliminarPate.Location = New System.Drawing.Point(331, 451)
        Me.Btn_EliminarPate.Name = "Btn_EliminarPate"
        Me.Btn_EliminarPate.Size = New System.Drawing.Size(56, 35)
        Me.Btn_EliminarPate.TabIndex = 7
        Me.TipAgregar.SetToolTip(Me.Btn_EliminarPate, "Quita los permisos seleccionados del perfil.")
        Me.Btn_EliminarPate.UseVisualStyleBackColor = True
        Me.Btn_EliminarPate.Visible = False
        '
        'Btn_AgregarPate
        '
        Me.Btn_AgregarPate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_AgregarPate.FlatAppearance.BorderSize = 0
        Me.Btn_AgregarPate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_AgregarPate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_AgregarPate.Image = Global.SistemaCinderella.My.Resources.Recursos.flecha_der
        Me.Btn_AgregarPate.Location = New System.Drawing.Point(265, 451)
        Me.Btn_AgregarPate.Name = "Btn_AgregarPate"
        Me.Btn_AgregarPate.Size = New System.Drawing.Size(56, 35)
        Me.Btn_AgregarPate.TabIndex = 6
        Me.TipAgregar.SetToolTip(Me.Btn_AgregarPate, "Agrega los permisos seleccionados al perfil.")
        Me.Btn_AgregarPate.UseVisualStyleBackColor = True
        Me.Btn_AgregarPate.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(328, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(179, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Listado de Permisos Asignados"
        '
        'ListPatentesSelec
        '
        Me.ListPatentesSelec.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ListPatentesSelec.FormattingEnabled = True
        Me.ListPatentesSelec.ItemHeight = 15
        Me.ListPatentesSelec.Location = New System.Drawing.Point(331, 183)
        Me.ListPatentesSelec.Name = "ListPatentesSelec"
        Me.ListPatentesSelec.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.ListPatentesSelec.Size = New System.Drawing.Size(314, 259)
        Me.ListPatentesSelec.TabIndex = 5
        '
        'ListPatentes
        '
        Me.ListPatentes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ListPatentes.FormattingEnabled = True
        Me.ListPatentes.ItemHeight = 15
        Me.ListPatentes.Location = New System.Drawing.Point(7, 183)
        Me.ListPatentes.Name = "ListPatentes"
        Me.ListPatentes.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.ListPatentes.Size = New System.Drawing.Size(314, 259)
        Me.ListPatentes.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 160)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Listado de Permisos Disponibles"
        '
        'chk_Habilitado
        '
        Me.chk_Habilitado.AutoSize = True
        Me.chk_Habilitado.Checked = True
        Me.chk_Habilitado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Habilitado.Location = New System.Drawing.Point(145, 83)
        Me.chk_Habilitado.Name = "chk_Habilitado"
        Me.chk_Habilitado.Size = New System.Drawing.Size(15, 14)
        Me.chk_Habilitado.TabIndex = 2
        Me.chk_Habilitado.UseVisualStyleBackColor = True
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New System.Drawing.Point(145, 37)
        Me.txt_descripcion.MaxLength = 255
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(198, 21)
        Me.txt_descripcion.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Habilitado"
        '
        'lbl_descripcion
        '
        Me.lbl_descripcion.AutoSize = True
        Me.lbl_descripcion.Location = New System.Drawing.Point(10, 40)
        Me.lbl_descripcion.Name = "lbl_descripcion"
        Me.lbl_descripcion.Size = New System.Drawing.Size(72, 15)
        Me.lbl_descripcion.TabIndex = 1
        Me.lbl_descripcion.Text = "Descripción"
        '
        'Btn_Agregar
        '
        Me.Btn_Agregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Agregar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Agregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Agregar.Image = Global.SistemaCinderella.My.Resources.Recursos.Agregar_24
        Me.Btn_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Agregar.Location = New System.Drawing.Point(545, 474)
        Me.Btn_Agregar.Name = "Btn_Agregar"
        Me.Btn_Agregar.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Agregar.TabIndex = 8
        Me.Btn_Agregar.Text = "Agregar"
        Me.Btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TipAgregar.SetToolTip(Me.Btn_Agregar, "Click aquí para agregar el nuevo perfil en el sistema.")
        Me.Btn_Agregar.UseVisualStyleBackColor = False
        '
        'TbMod
        '
        Me.TbMod.Controls.Add(Me.GB_Modificacion)
        Me.TbMod.Location = New System.Drawing.Point(4, 29)
        Me.TbMod.Name = "TbMod"
        Me.TbMod.Size = New System.Drawing.Size(666, 539)
        Me.TbMod.TabIndex = 2
        Me.TbMod.Text = "Modificación de Perfiles"
        Me.TbMod.UseVisualStyleBackColor = True
        '
        'GB_Modificacion
        '
        Me.GB_Modificacion.Controls.Add(Me.Btn_Cancelar)
        Me.GB_Modificacion.Controls.Add(Me.Chk_Selected2_Mod)
        Me.GB_Modificacion.Controls.Add(Me.Chk_Selected_Mod)
        Me.GB_Modificacion.Controls.Add(Me.Btn_EliminarPatMod)
        Me.GB_Modificacion.Controls.Add(Me.Btn_AgregarPateMod)
        Me.GB_Modificacion.Controls.Add(Me.Label8)
        Me.GB_Modificacion.Controls.Add(Me.Cb_FiltrosMod)
        Me.GB_Modificacion.Controls.Add(Me.Label4)
        Me.GB_Modificacion.Controls.Add(Me.ListPatentesSelecMod)
        Me.GB_Modificacion.Controls.Add(Me.ListPatentesMod)
        Me.GB_Modificacion.Controls.Add(Me.Label7)
        Me.GB_Modificacion.Controls.Add(Me.lbl_Perfil)
        Me.GB_Modificacion.Controls.Add(Me.chk_Habilitado_mod)
        Me.GB_Modificacion.Controls.Add(Me.Label3)
        Me.GB_Modificacion.Controls.Add(Me.lbl_descripcion_mod)
        Me.GB_Modificacion.Controls.Add(Me.Btn_Modificar)
        Me.GB_Modificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Modificacion.Location = New System.Drawing.Point(8, 6)
        Me.GB_Modificacion.Name = "GB_Modificacion"
        Me.GB_Modificacion.Size = New System.Drawing.Size(651, 520)
        Me.GB_Modificacion.TabIndex = 1
        Me.GB_Modificacion.TabStop = False
        Me.GB_Modificacion.Text = "Formulario de modificación de perfil."
        '
        'Chk_Selected2_Mod
        '
        Me.Chk_Selected2_Mod.AutoSize = True
        Me.Chk_Selected2_Mod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chk_Selected2_Mod.Location = New System.Drawing.Point(521, 449)
        Me.Chk_Selected2_Mod.Name = "Chk_Selected2_Mod"
        Me.Chk_Selected2_Mod.Size = New System.Drawing.Size(124, 19)
        Me.Chk_Selected2_Mod.TabIndex = 16
        Me.Chk_Selected2_Mod.Text = "Seleccionar todos"
        Me.Chk_Selected2_Mod.UseVisualStyleBackColor = True
        '
        'Chk_Selected_Mod
        '
        Me.Chk_Selected_Mod.AutoSize = True
        Me.Chk_Selected_Mod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chk_Selected_Mod.Location = New System.Drawing.Point(7, 449)
        Me.Chk_Selected_Mod.Name = "Chk_Selected_Mod"
        Me.Chk_Selected_Mod.Size = New System.Drawing.Size(124, 19)
        Me.Chk_Selected_Mod.TabIndex = 15
        Me.Chk_Selected_Mod.Text = "Seleccionar todos"
        Me.Chk_Selected_Mod.UseVisualStyleBackColor = True
        '
        'Btn_EliminarPatMod
        '
        Me.Btn_EliminarPatMod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_EliminarPatMod.FlatAppearance.BorderSize = 0
        Me.Btn_EliminarPatMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_EliminarPatMod.Image = Global.SistemaCinderella.My.Resources.Recursos.flecha_izq
        Me.Btn_EliminarPatMod.Location = New System.Drawing.Point(331, 452)
        Me.Btn_EliminarPatMod.Name = "Btn_EliminarPatMod"
        Me.Btn_EliminarPatMod.Size = New System.Drawing.Size(56, 35)
        Me.Btn_EliminarPatMod.TabIndex = 7
        Me.Btn_EliminarPatMod.Text = "<<"
        Me.TipAgregar.SetToolTip(Me.Btn_EliminarPatMod, "Quita los permisos seleccionados del perfil.")
        Me.Btn_EliminarPatMod.UseVisualStyleBackColor = True
        '
        'Btn_AgregarPateMod
        '
        Me.Btn_AgregarPateMod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_AgregarPateMod.FlatAppearance.BorderSize = 0
        Me.Btn_AgregarPateMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_AgregarPateMod.Image = Global.SistemaCinderella.My.Resources.Recursos.flecha_der
        Me.Btn_AgregarPateMod.Location = New System.Drawing.Point(265, 452)
        Me.Btn_AgregarPateMod.Name = "Btn_AgregarPateMod"
        Me.Btn_AgregarPateMod.Size = New System.Drawing.Size(56, 35)
        Me.Btn_AgregarPateMod.TabIndex = 6
        Me.TipAgregar.SetToolTip(Me.Btn_AgregarPateMod, "Agrega los permisos seleccionados al perfil.")
        Me.Btn_AgregarPateMod.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 123)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 15)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Filtrar patentes por"
        '
        'Cb_FiltrosMod
        '
        Me.Cb_FiltrosMod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cb_FiltrosMod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_FiltrosMod.FormattingEnabled = True
        Me.Cb_FiltrosMod.Location = New System.Drawing.Point(145, 120)
        Me.Cb_FiltrosMod.Name = "Cb_FiltrosMod"
        Me.Cb_FiltrosMod.Size = New System.Drawing.Size(198, 23)
        Me.Cb_FiltrosMod.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(328, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(179, 15)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Listado de Permisos Asignados"
        '
        'ListPatentesSelecMod
        '
        Me.ListPatentesSelecMod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ListPatentesSelecMod.FormattingEnabled = True
        Me.ListPatentesSelecMod.ItemHeight = 15
        Me.ListPatentesSelecMod.Location = New System.Drawing.Point(331, 184)
        Me.ListPatentesSelecMod.Name = "ListPatentesSelecMod"
        Me.ListPatentesSelecMod.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.ListPatentesSelecMod.Size = New System.Drawing.Size(314, 259)
        Me.ListPatentesSelecMod.TabIndex = 5
        '
        'ListPatentesMod
        '
        Me.ListPatentesMod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ListPatentesMod.FormattingEnabled = True
        Me.ListPatentesMod.ItemHeight = 15
        Me.ListPatentesMod.Location = New System.Drawing.Point(7, 184)
        Me.ListPatentesMod.Name = "ListPatentesMod"
        Me.ListPatentesMod.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.ListPatentesMod.Size = New System.Drawing.Size(314, 259)
        Me.ListPatentesMod.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 161)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(187, 15)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Listado de Permisos Disponibles"
        '
        'lbl_Perfil
        '
        Me.lbl_Perfil.AutoSize = True
        Me.lbl_Perfil.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Perfil.Location = New System.Drawing.Point(141, 42)
        Me.lbl_Perfil.Name = "lbl_Perfil"
        Me.lbl_Perfil.Size = New System.Drawing.Size(11, 15)
        Me.lbl_Perfil.TabIndex = 1
        Me.lbl_Perfil.Text = "-"
        '
        'chk_Habilitado_mod
        '
        Me.chk_Habilitado_mod.AutoSize = True
        Me.chk_Habilitado_mod.Location = New System.Drawing.Point(145, 83)
        Me.chk_Habilitado_mod.Name = "chk_Habilitado_mod"
        Me.chk_Habilitado_mod.Size = New System.Drawing.Size(15, 14)
        Me.chk_Habilitado_mod.TabIndex = 2
        Me.chk_Habilitado_mod.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Habilitado"
        '
        'lbl_descripcion_mod
        '
        Me.lbl_descripcion_mod.AutoSize = True
        Me.lbl_descripcion_mod.Location = New System.Drawing.Point(10, 40)
        Me.lbl_descripcion_mod.Name = "lbl_descripcion_mod"
        Me.lbl_descripcion_mod.Size = New System.Drawing.Size(72, 15)
        Me.lbl_descripcion_mod.TabIndex = 1
        Me.lbl_descripcion_mod.Text = "Descripción"
        '
        'Btn_Modificar
        '
        Me.Btn_Modificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Modificar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Modificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Modificar.Image = Global.SistemaCinderella.My.Resources.Recursos.Editar_24
        Me.Btn_Modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Modificar.Location = New System.Drawing.Point(545, 474)
        Me.Btn_Modificar.Name = "Btn_Modificar"
        Me.Btn_Modificar.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Modificar.TabIndex = 8
        Me.Btn_Modificar.Text = "Modificar"
        Me.Btn_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TipAgregar.SetToolTip(Me.Btn_Modificar, "Click aquí para modificar el perfil seleccionado.")
        Me.Btn_Modificar.UseVisualStyleBackColor = False
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Image = Global.SistemaCinderella.My.Resources.Recursos.Boton_Editar
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewImageColumn1.ToolTipText = "Modificar Perfil"
        Me.DataGridViewImageColumn1.Width = 60
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.HeaderText = ""
        Me.DataGridViewImageColumn2.Image = Global.SistemaCinderella.My.Resources.Recursos.Boton_Eliminar
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.ReadOnly = True
        Me.DataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewImageColumn2.ToolTipText = "Eliminar Perfil"
        Me.DataGridViewImageColumn2.Width = 60
        '
        'TipAgregar
        '
        Me.TipAgregar.IsBalloon = True
        Me.TipAgregar.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.TipAgregar.ToolTipTitle = "Ayuda"
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Cancelar.Image = Global.SistemaCinderella.My.Resources.Recursos.desconectado_32
        Me.Btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Cancelar.Location = New System.Drawing.Point(439, 474)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Cancelar.TabIndex = 82
        Me.Btn_Cancelar.Text = "Cancelar"
        Me.Btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TipAgregar.SetToolTip(Me.Btn_Cancelar, "Descarta los cambios y vuelve al listado de perfiles")
        Me.Btn_Cancelar.UseVisualStyleBackColor = True
        '
        'frmPerfiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 572)
        Me.Controls.Add(Me.TabPerfiles)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmPerfiles"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administración de Perfiles"
        Me.TabPerfiles.ResumeLayout(False)
        Me.TbListado.ResumeLayout(False)
        Me.TbListado.PerformLayout()
        Me.GB_Buscar.ResumeLayout(False)
        Me.GB_Buscar.PerformLayout()
        CType(Me.DG_Perfiles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TbAlta.ResumeLayout(False)
        Me.GB_Alta.ResumeLayout(False)
        Me.GB_Alta.PerformLayout()
        Me.TbMod.ResumeLayout(False)
        Me.GB_Modificacion.ResumeLayout(False)
        Me.GB_Modificacion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabPerfiles As System.Windows.Forms.TabControl
    Friend WithEvents TbListado As System.Windows.Forms.TabPage
    Friend WithEvents DG_Perfiles As System.Windows.Forms.DataGridView
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_Perfil As System.Windows.Forms.Label
    Friend WithEvents ListPatentesSelec As System.Windows.Forms.ListBox
    Friend WithEvents ListPatentes As System.Windows.Forms.ListBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Btn_EliminarPate As System.Windows.Forms.Button
    Friend WithEvents Btn_AgregarPate As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Cb_Filtros As System.Windows.Forms.ComboBox
    Friend WithEvents GB_Buscar As System.Windows.Forms.GroupBox
    Friend WithEvents txt_buscar As System.Windows.Forms.TextBox
    Friend WithEvents lbl_descripcion_bus As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Cb_FiltrosMod As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ListPatentesSelecMod As System.Windows.Forms.ListBox
    Friend WithEvents ListPatentesMod As System.Windows.Forms.ListBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Btn_EliminarPatMod As System.Windows.Forms.Button
    Friend WithEvents Btn_AgregarPateMod As System.Windows.Forms.Button
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents TipAgregar As System.Windows.Forms.ToolTip
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents btn_Restablecer As System.Windows.Forms.Button
    Friend WithEvents lbl_Msg As System.Windows.Forms.Label
    Friend WithEvents id_Perfil As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Habilitado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Modificar As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Chk_Selected2 As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_Selected As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_Selected2_Mod As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_Selected_Mod As System.Windows.Forms.CheckBox
    Friend WithEvents Btn_Cancelar As System.Windows.Forms.Button
End Class
