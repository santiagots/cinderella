<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuarios
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsuarios))
        Me.TabUsuarios = New System.Windows.Forms.TabControl()
        Me.TbListado = New System.Windows.Forms.TabPage()
        Me.lbl_Msg = New System.Windows.Forms.Label()
        Me.DG_Usuarios = New System.Windows.Forms.DataGridView()
        Me.id_Usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Habilitado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Eliminar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Modificar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TbAlta = New System.Windows.Forms.TabPage()
        Me.GB_Alta = New System.Windows.Forms.GroupBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.lbl_Perfil = New System.Windows.Forms.Label()
        Me.cb_Perfiles = New System.Windows.Forms.ComboBox()
        Me.lbl_Usuario = New System.Windows.Forms.Label()
        Me.lbl_mail = New System.Windows.Forms.Label()
        Me.lbl_apellido = New System.Windows.Forms.Label()
        Me.lbl_pass = New System.Windows.Forms.Label()
        Me.lbl_pass2 = New System.Windows.Forms.Label()
        Me.txt_pass = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_mail = New System.Windows.Forms.TextBox()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.txt_pass2 = New System.Windows.Forms.TextBox()
        Me.chk_Habilitado = New System.Windows.Forms.CheckBox()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.Btn_Agregar = New System.Windows.Forms.Button()
        Me.TbMod = New System.Windows.Forms.TabPage()
        Me.GB_Buscar = New System.Windows.Forms.GroupBox()
        Me.btn_Restablecer = New System.Windows.Forms.Button()
        Me.lbl_Msg2 = New System.Windows.Forms.Label()
        Me.DG_Buscador = New System.Windows.Forms.DataGridView()
        Me.id_Usuario_Bus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Usuario_Bus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre_Bus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido_Bus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Habilitado_Bus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Eliminar_bus = New System.Windows.Forms.DataGridViewImageColumn()
        Me.txt_buscar = New System.Windows.Forms.TextBox()
        Me.Btn_Buscar = New System.Windows.Forms.Button()
        Me.lbl_descripcion_bus = New System.Windows.Forms.Label()
        Me.GB_Modificacion = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Cb_Perfiles_mod = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_pass2_mod = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_pass_mod = New System.Windows.Forms.TextBox()
        Me.txt_nombre_mod = New System.Windows.Forms.TextBox()
        Me.txt_apellido_mod = New System.Windows.Forms.TextBox()
        Me.txt_usuario_mod = New System.Windows.Forms.TextBox()
        Me.txt_mail_mod = New System.Windows.Forms.TextBox()
        Me.chk_Habilitado_mod = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_descripcion_mod = New System.Windows.Forms.Label()
        Me.Btn_Modificar = New System.Windows.Forms.Button()
        Me.ErrorUsuarios = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolUsuarios = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabUsuarios.SuspendLayout()
        Me.TbListado.SuspendLayout()
        CType(Me.DG_Usuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TbAlta.SuspendLayout()
        Me.GB_Alta.SuspendLayout()
        Me.TbMod.SuspendLayout()
        Me.GB_Buscar.SuspendLayout()
        CType(Me.DG_Buscador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_Modificacion.SuspendLayout()
        CType(Me.ErrorUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabUsuarios
        '
        Me.TabUsuarios.Controls.Add(Me.TbListado)
        Me.TabUsuarios.Controls.Add(Me.TbAlta)
        Me.TabUsuarios.Controls.Add(Me.TbMod)
        Me.TabUsuarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabUsuarios.Location = New System.Drawing.Point(0, 0)
        Me.TabUsuarios.Name = "TabUsuarios"
        Me.TabUsuarios.SelectedIndex = 0
        Me.TabUsuarios.Size = New System.Drawing.Size(694, 552)
        Me.TabUsuarios.TabIndex = 1
        '
        'TbListado
        '
        Me.TbListado.Controls.Add(Me.lbl_Msg)
        Me.TbListado.Controls.Add(Me.DG_Usuarios)
        Me.TbListado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbListado.Location = New System.Drawing.Point(4, 29)
        Me.TbListado.Name = "TbListado"
        Me.TbListado.Padding = New System.Windows.Forms.Padding(3)
        Me.TbListado.Size = New System.Drawing.Size(686, 519)
        Me.TbListado.TabIndex = 0
        Me.TbListado.Text = "Usuarios"
        Me.TbListado.UseVisualStyleBackColor = True
        '
        'lbl_Msg
        '
        Me.lbl_Msg.AutoSize = True
        Me.lbl_Msg.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lbl_Msg.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Msg.Location = New System.Drawing.Point(152, 255)
        Me.lbl_Msg.Name = "lbl_Msg"
        Me.lbl_Msg.Size = New System.Drawing.Size(382, 29)
        Me.lbl_Msg.TabIndex = 1
        Me.lbl_Msg.Text = "No se han encontrado usuarios."
        '
        'DG_Usuarios
        '
        Me.DG_Usuarios.AllowUserToAddRows = False
        Me.DG_Usuarios.AllowUserToDeleteRows = False
        Me.DG_Usuarios.AllowUserToResizeColumns = False
        Me.DG_Usuarios.AllowUserToResizeRows = False
        Me.DG_Usuarios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_Usuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_Usuarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DG_Usuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_Usuario, Me.Usuario, Me.Nombre, Me.Apellido, Me.Habilitado, Me.Eliminar, Me.Modificar})
        Me.DG_Usuarios.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DG_Usuarios.DefaultCellStyle = DataGridViewCellStyle3
        Me.DG_Usuarios.Location = New System.Drawing.Point(10, 6)
        Me.DG_Usuarios.MultiSelect = False
        Me.DG_Usuarios.Name = "DG_Usuarios"
        Me.DG_Usuarios.ReadOnly = True
        Me.DG_Usuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_Usuarios.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DG_Usuarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DG_Usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Usuarios.Size = New System.Drawing.Size(668, 505)
        Me.DG_Usuarios.TabIndex = 0
        '
        'id_Usuario
        '
        Me.id_Usuario.DataPropertyName = "id_Usuario"
        Me.id_Usuario.FillWeight = 123.0697!
        Me.id_Usuario.HeaderText = "ID"
        Me.id_Usuario.MaxInputLength = 255
        Me.id_Usuario.Name = "id_Usuario"
        Me.id_Usuario.ReadOnly = True
        Me.id_Usuario.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.id_Usuario.Visible = False
        '
        'Usuario
        '
        Me.Usuario.DataPropertyName = "Usuario"
        Me.Usuario.FillWeight = 123.0697!
        Me.Usuario.HeaderText = "Usuario"
        Me.Usuario.MaxInputLength = 255
        Me.Usuario.Name = "Usuario"
        Me.Usuario.ReadOnly = True
        Me.Usuario.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.FillWeight = 123.0697!
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Apellido
        '
        Me.Apellido.DataPropertyName = "Apellido"
        Me.Apellido.FillWeight = 123.0697!
        Me.Apellido.HeaderText = "Apellido"
        Me.Apellido.Name = "Apellido"
        Me.Apellido.ReadOnly = True
        Me.Apellido.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Habilitado
        '
        Me.Habilitado.DataPropertyName = "Habilitado"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Habilitado.DefaultCellStyle = DataGridViewCellStyle2
        Me.Habilitado.FillWeight = 67.45716!
        Me.Habilitado.HeaderText = "Habilitado"
        Me.Habilitado.MaxInputLength = 10
        Me.Habilitado.Name = "Habilitado"
        Me.Habilitado.ReadOnly = True
        Me.Habilitado.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Eliminar
        '
        Me.Eliminar.FillWeight = 69.19792!
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Image = Global.SistemaCinderella.My.Resources.Recursos.Boton_Eliminar
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Modificar
        '
        Me.Modificar.FillWeight = 71.06599!
        Me.Modificar.HeaderText = "Modificar"
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
        Me.TbAlta.Size = New System.Drawing.Size(686, 519)
        Me.TbAlta.TabIndex = 1
        Me.TbAlta.Text = "Alta de Usuarios"
        Me.TbAlta.UseVisualStyleBackColor = True
        '
        'GB_Alta
        '
        Me.GB_Alta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_Alta.Controls.Add(Me.Label25)
        Me.GB_Alta.Controls.Add(Me.lbl_Perfil)
        Me.GB_Alta.Controls.Add(Me.cb_Perfiles)
        Me.GB_Alta.Controls.Add(Me.lbl_Usuario)
        Me.GB_Alta.Controls.Add(Me.lbl_mail)
        Me.GB_Alta.Controls.Add(Me.lbl_apellido)
        Me.GB_Alta.Controls.Add(Me.lbl_pass)
        Me.GB_Alta.Controls.Add(Me.lbl_pass2)
        Me.GB_Alta.Controls.Add(Me.txt_pass)
        Me.GB_Alta.Controls.Add(Me.txt_nombre)
        Me.GB_Alta.Controls.Add(Me.txt_mail)
        Me.GB_Alta.Controls.Add(Me.txt_apellido)
        Me.GB_Alta.Controls.Add(Me.txt_pass2)
        Me.GB_Alta.Controls.Add(Me.chk_Habilitado)
        Me.GB_Alta.Controls.Add(Me.txt_usuario)
        Me.GB_Alta.Controls.Add(Me.Label2)
        Me.GB_Alta.Controls.Add(Me.lbl_nombre)
        Me.GB_Alta.Controls.Add(Me.Btn_Agregar)
        Me.GB_Alta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Alta.Location = New System.Drawing.Point(10, 6)
        Me.GB_Alta.Name = "GB_Alta"
        Me.GB_Alta.Size = New System.Drawing.Size(668, 495)
        Me.GB_Alta.TabIndex = 0
        Me.GB_Alta.TabStop = False
        Me.GB_Alta.Text = "Formulario de Alta"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(7, 463)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(185, 13)
        Me.Label25.TabIndex = 68
        Me.Label25.Text = "(*) Todos los campos son obligatorios."
        '
        'lbl_Perfil
        '
        Me.lbl_Perfil.AutoSize = True
        Me.lbl_Perfil.Location = New System.Drawing.Point(7, 42)
        Me.lbl_Perfil.Name = "lbl_Perfil"
        Me.lbl_Perfil.Size = New System.Drawing.Size(35, 15)
        Me.lbl_Perfil.TabIndex = 15
        Me.lbl_Perfil.Text = "Perfil"
        '
        'cb_Perfiles
        '
        Me.cb_Perfiles.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_Perfiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Perfiles.FormattingEnabled = True
        Me.cb_Perfiles.Location = New System.Drawing.Point(139, 39)
        Me.cb_Perfiles.Name = "cb_Perfiles"
        Me.cb_Perfiles.Size = New System.Drawing.Size(191, 23)
        Me.cb_Perfiles.TabIndex = 1
        '
        'lbl_Usuario
        '
        Me.lbl_Usuario.AutoSize = True
        Me.lbl_Usuario.Location = New System.Drawing.Point(7, 84)
        Me.lbl_Usuario.Name = "lbl_Usuario"
        Me.lbl_Usuario.Size = New System.Drawing.Size(50, 15)
        Me.lbl_Usuario.TabIndex = 13
        Me.lbl_Usuario.Text = "Usuario"
        '
        'lbl_mail
        '
        Me.lbl_mail.AutoSize = True
        Me.lbl_mail.Location = New System.Drawing.Point(7, 227)
        Me.lbl_mail.Name = "lbl_mail"
        Me.lbl_mail.Size = New System.Drawing.Size(31, 15)
        Me.lbl_mail.TabIndex = 12
        Me.lbl_mail.Text = "Mail"
        '
        'lbl_apellido
        '
        Me.lbl_apellido.AutoSize = True
        Me.lbl_apellido.Location = New System.Drawing.Point(7, 181)
        Me.lbl_apellido.Name = "lbl_apellido"
        Me.lbl_apellido.Size = New System.Drawing.Size(51, 15)
        Me.lbl_apellido.TabIndex = 11
        Me.lbl_apellido.Text = "Apellido"
        '
        'lbl_pass
        '
        Me.lbl_pass.AutoSize = True
        Me.lbl_pass.Location = New System.Drawing.Point(7, 278)
        Me.lbl_pass.Name = "lbl_pass"
        Me.lbl_pass.Size = New System.Drawing.Size(61, 15)
        Me.lbl_pass.TabIndex = 10
        Me.lbl_pass.Text = "Password"
        '
        'lbl_pass2
        '
        Me.lbl_pass2.AutoSize = True
        Me.lbl_pass2.Location = New System.Drawing.Point(7, 320)
        Me.lbl_pass2.Name = "lbl_pass2"
        Me.lbl_pass2.Size = New System.Drawing.Size(104, 15)
        Me.lbl_pass2.TabIndex = 9
        Me.lbl_pass2.Text = "Repetir Password"
        '
        'txt_pass
        '
        Me.txt_pass.Location = New System.Drawing.Point(139, 270)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_pass.Size = New System.Drawing.Size(191, 21)
        Me.txt_pass.TabIndex = 6
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(139, 128)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(191, 21)
        Me.txt_nombre.TabIndex = 3
        '
        'txt_mail
        '
        Me.txt_mail.Location = New System.Drawing.Point(139, 219)
        Me.txt_mail.Name = "txt_mail"
        Me.txt_mail.Size = New System.Drawing.Size(191, 21)
        Me.txt_mail.TabIndex = 5
        '
        'txt_apellido
        '
        Me.txt_apellido.Location = New System.Drawing.Point(139, 173)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(191, 21)
        Me.txt_apellido.TabIndex = 4
        '
        'txt_pass2
        '
        Me.txt_pass2.Location = New System.Drawing.Point(139, 312)
        Me.txt_pass2.Name = "txt_pass2"
        Me.txt_pass2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_pass2.Size = New System.Drawing.Size(191, 21)
        Me.txt_pass2.TabIndex = 7
        '
        'chk_Habilitado
        '
        Me.chk_Habilitado.AutoSize = True
        Me.chk_Habilitado.Checked = True
        Me.chk_Habilitado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Habilitado.Location = New System.Drawing.Point(139, 352)
        Me.chk_Habilitado.Name = "chk_Habilitado"
        Me.chk_Habilitado.Size = New System.Drawing.Size(15, 14)
        Me.chk_Habilitado.TabIndex = 8
        Me.chk_Habilitado.UseVisualStyleBackColor = True
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(139, 81)
        Me.txt_usuario.MaxLength = 255
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(191, 21)
        Me.txt_usuario.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 353)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Habilitado"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(6, 134)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(52, 15)
        Me.lbl_nombre.TabIndex = 1
        Me.lbl_nombre.Text = "Nombre"
        '
        'Btn_Agregar
        '
        Me.Btn_Agregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Agregar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Agregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Agregar.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Btn_Agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Agregar.Image = Global.SistemaCinderella.My.Resources.Recursos.Agregar_24
        Me.Btn_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Agregar.Location = New System.Drawing.Point(553, 438)
        Me.Btn_Agregar.Name = "Btn_Agregar"
        Me.Btn_Agregar.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Agregar.TabIndex = 9
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
        Me.TbMod.Size = New System.Drawing.Size(686, 519)
        Me.TbMod.TabIndex = 2
        Me.TbMod.Text = "Modificación de Usuarios"
        Me.TbMod.UseVisualStyleBackColor = True
        '
        'GB_Buscar
        '
        Me.GB_Buscar.Controls.Add(Me.btn_Restablecer)
        Me.GB_Buscar.Controls.Add(Me.lbl_Msg2)
        Me.GB_Buscar.Controls.Add(Me.DG_Buscador)
        Me.GB_Buscar.Controls.Add(Me.txt_buscar)
        Me.GB_Buscar.Controls.Add(Me.Btn_Buscar)
        Me.GB_Buscar.Controls.Add(Me.lbl_descripcion_bus)
        Me.GB_Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Buscar.Location = New System.Drawing.Point(10, 6)
        Me.GB_Buscar.Name = "GB_Buscar"
        Me.GB_Buscar.Size = New System.Drawing.Size(668, 292)
        Me.GB_Buscar.TabIndex = 0
        Me.GB_Buscar.TabStop = False
        Me.GB_Buscar.Text = "Buscar Usuario"
        '
        'btn_Restablecer
        '
        Me.btn_Restablecer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Restablecer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Restablecer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Restablecer.Location = New System.Drawing.Point(456, 20)
        Me.btn_Restablecer.Name = "btn_Restablecer"
        Me.btn_Restablecer.Size = New System.Drawing.Size(100, 40)
        Me.btn_Restablecer.TabIndex = 2
        Me.btn_Restablecer.Text = "Restablecer Filtros"
        Me.ToolUsuarios.SetToolTip(Me.btn_Restablecer, "Haz click aquí para restablecer los filtros y el listado de usuarios.")
        Me.btn_Restablecer.UseVisualStyleBackColor = True
        '
        'lbl_Msg2
        '
        Me.lbl_Msg2.AutoSize = True
        Me.lbl_Msg2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lbl_Msg2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Msg2.Location = New System.Drawing.Point(180, 174)
        Me.lbl_Msg2.Name = "lbl_Msg2"
        Me.lbl_Msg2.Size = New System.Drawing.Size(309, 24)
        Me.lbl_Msg2.TabIndex = 4
        Me.lbl_Msg2.Text = "No se han encontrado usuarios."
        '
        'DG_Buscador
        '
        Me.DG_Buscador.AllowUserToAddRows = False
        Me.DG_Buscador.AllowUserToDeleteRows = False
        Me.DG_Buscador.AllowUserToResizeColumns = False
        Me.DG_Buscador.AllowUserToResizeRows = False
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DG_Buscador.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DG_Buscador.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_Buscador.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_Buscador.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_Usuario_Bus, Me.Usuario_Bus, Me.Nombre_Bus, Me.Apellido_Bus, Me.Habilitado_Bus, Me.Eliminar_bus})
        Me.DG_Buscador.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DG_Buscador.Location = New System.Drawing.Point(10, 69)
        Me.DG_Buscador.MultiSelect = False
        Me.DG_Buscador.Name = "DG_Buscador"
        Me.DG_Buscador.ReadOnly = True
        Me.DG_Buscador.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DG_Buscador.RowsDefaultCellStyle = DataGridViewCellStyle7
        Me.DG_Buscador.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Buscador.Size = New System.Drawing.Size(652, 212)
        Me.DG_Buscador.TabIndex = 4
        '
        'id_Usuario_Bus
        '
        Me.id_Usuario_Bus.DataPropertyName = "id_Usuario"
        Me.id_Usuario_Bus.FillWeight = 118.2333!
        Me.id_Usuario_Bus.HeaderText = "id_Usuario"
        Me.id_Usuario_Bus.MaxInputLength = 10
        Me.id_Usuario_Bus.Name = "id_Usuario_Bus"
        Me.id_Usuario_Bus.ReadOnly = True
        Me.id_Usuario_Bus.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.id_Usuario_Bus.Visible = False
        '
        'Usuario_Bus
        '
        Me.Usuario_Bus.DataPropertyName = "Usuario"
        Me.Usuario_Bus.FillWeight = 118.2333!
        Me.Usuario_Bus.HeaderText = "Usuario"
        Me.Usuario_Bus.MaxInputLength = 240
        Me.Usuario_Bus.Name = "Usuario_Bus"
        Me.Usuario_Bus.ReadOnly = True
        Me.Usuario_Bus.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Nombre_Bus
        '
        Me.Nombre_Bus.DataPropertyName = "Nombre"
        Me.Nombre_Bus.FillWeight = 118.2333!
        Me.Nombre_Bus.HeaderText = "Nombre"
        Me.Nombre_Bus.Name = "Nombre_Bus"
        Me.Nombre_Bus.ReadOnly = True
        '
        'Apellido_Bus
        '
        Me.Apellido_Bus.DataPropertyName = "Apellido"
        Me.Apellido_Bus.FillWeight = 118.2333!
        Me.Apellido_Bus.HeaderText = "Apellido"
        Me.Apellido_Bus.Name = "Apellido_Bus"
        Me.Apellido_Bus.ReadOnly = True
        '
        'Habilitado_Bus
        '
        Me.Habilitado_Bus.DataPropertyName = "Habilitado"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Habilitado_Bus.DefaultCellStyle = DataGridViewCellStyle6
        Me.Habilitado_Bus.FillWeight = 67.00507!
        Me.Habilitado_Bus.HeaderText = "Habilitado"
        Me.Habilitado_Bus.MaxInputLength = 10
        Me.Habilitado_Bus.Name = "Habilitado_Bus"
        Me.Habilitado_Bus.ReadOnly = True
        Me.Habilitado_Bus.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Eliminar_bus
        '
        Me.Eliminar_bus.FillWeight = 60.0619!
        Me.Eliminar_bus.HeaderText = "Eliminar"
        Me.Eliminar_bus.Image = Global.SistemaCinderella.My.Resources.Recursos.Boton_Eliminar
        Me.Eliminar_bus.Name = "Eliminar_bus"
        Me.Eliminar_bus.ReadOnly = True
        Me.Eliminar_bus.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Eliminar_bus.ToolTipText = "Eliminar"
        '
        'txt_buscar
        '
        Me.txt_buscar.Location = New System.Drawing.Point(90, 30)
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(293, 21)
        Me.txt_buscar.TabIndex = 1
        '
        'Btn_Buscar
        '
        Me.Btn_Buscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Buscar.Image = Global.SistemaCinderella.My.Resources.Recursos.IconoBuscar32
        Me.Btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Buscar.Location = New System.Drawing.Point(562, 20)
        Me.Btn_Buscar.Name = "Btn_Buscar"
        Me.Btn_Buscar.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Buscar.TabIndex = 3
        Me.Btn_Buscar.Text = "Buscar"
        Me.Btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolUsuarios.SetToolTip(Me.Btn_Buscar, "Haz click aquí para buscar usuarios con los criterios de busqueda seleccionados.")
        Me.Btn_Buscar.UseVisualStyleBackColor = True
        '
        'lbl_descripcion_bus
        '
        Me.lbl_descripcion_bus.AutoSize = True
        Me.lbl_descripcion_bus.Location = New System.Drawing.Point(12, 33)
        Me.lbl_descripcion_bus.Name = "lbl_descripcion_bus"
        Me.lbl_descripcion_bus.Size = New System.Drawing.Size(72, 15)
        Me.lbl_descripcion_bus.TabIndex = 0
        Me.lbl_descripcion_bus.Text = "Descripción"
        '
        'GB_Modificacion
        '
        Me.GB_Modificacion.Controls.Add(Me.Label9)
        Me.GB_Modificacion.Controls.Add(Me.Label8)
        Me.GB_Modificacion.Controls.Add(Me.Cb_Perfiles_mod)
        Me.GB_Modificacion.Controls.Add(Me.Label7)
        Me.GB_Modificacion.Controls.Add(Me.txt_pass2_mod)
        Me.GB_Modificacion.Controls.Add(Me.Label6)
        Me.GB_Modificacion.Controls.Add(Me.Label5)
        Me.GB_Modificacion.Controls.Add(Me.Label4)
        Me.GB_Modificacion.Controls.Add(Me.Label1)
        Me.GB_Modificacion.Controls.Add(Me.txt_pass_mod)
        Me.GB_Modificacion.Controls.Add(Me.txt_nombre_mod)
        Me.GB_Modificacion.Controls.Add(Me.txt_apellido_mod)
        Me.GB_Modificacion.Controls.Add(Me.txt_usuario_mod)
        Me.GB_Modificacion.Controls.Add(Me.txt_mail_mod)
        Me.GB_Modificacion.Controls.Add(Me.chk_Habilitado_mod)
        Me.GB_Modificacion.Controls.Add(Me.Label3)
        Me.GB_Modificacion.Controls.Add(Me.lbl_descripcion_mod)
        Me.GB_Modificacion.Controls.Add(Me.Btn_Modificar)
        Me.GB_Modificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Modificacion.Location = New System.Drawing.Point(10, 304)
        Me.GB_Modificacion.Name = "GB_Modificacion"
        Me.GB_Modificacion.Size = New System.Drawing.Size(668, 197)
        Me.GB_Modificacion.TabIndex = 5
        Me.GB_Modificacion.TabStop = False
        Me.GB_Modificacion.Text = "Modificación de Usuario"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(330, 166)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(185, 13)
        Me.Label9.TabIndex = 68
        Me.Label9.Text = "(*) Todos los campos son obligatorios."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(330, 97)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 15)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Perfil"
        '
        'Cb_Perfiles_mod
        '
        Me.Cb_Perfiles_mod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cb_Perfiles_mod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Perfiles_mod.FormattingEnabled = True
        Me.Cb_Perfiles_mod.Location = New System.Drawing.Point(458, 94)
        Me.Cb_Perfiles_mod.Name = "Cb_Perfiles_mod"
        Me.Cb_Perfiles_mod.Size = New System.Drawing.Size(189, 23)
        Me.Cb_Perfiles_mod.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(330, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 15)
        Me.Label7.TabIndex = 16
        Me.Label7.Tag = " "
        Me.Label7.Text = "Repetir Password"
        '
        'txt_pass2_mod
        '
        Me.txt_pass2_mod.Location = New System.Drawing.Point(458, 61)
        Me.txt_pass2_mod.Name = "txt_pass2_mod"
        Me.txt_pass2_mod.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_pass2_mod.Size = New System.Drawing.Size(189, 21)
        Me.txt_pass2_mod.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(330, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 15)
        Me.Label6.TabIndex = 14
        Me.Label6.Tag = " "
        Me.Label6.Text = "Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 15)
        Me.Label5.TabIndex = 13
        Me.Label5.Tag = " "
        Me.Label5.Text = "Mail"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 15)
        Me.Label4.TabIndex = 12
        Me.Label4.Tag = " "
        Me.Label4.Text = "Usuario"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 15)
        Me.Label1.TabIndex = 11
        Me.Label1.Tag = " "
        Me.Label1.Text = "Apellido"
        '
        'txt_pass_mod
        '
        Me.txt_pass_mod.Location = New System.Drawing.Point(458, 25)
        Me.txt_pass_mod.Name = "txt_pass_mod"
        Me.txt_pass_mod.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_pass_mod.Size = New System.Drawing.Size(189, 21)
        Me.txt_pass_mod.TabIndex = 11
        '
        'txt_nombre_mod
        '
        Me.txt_nombre_mod.Location = New System.Drawing.Point(90, 25)
        Me.txt_nombre_mod.Name = "txt_nombre_mod"
        Me.txt_nombre_mod.Size = New System.Drawing.Size(193, 21)
        Me.txt_nombre_mod.TabIndex = 6
        '
        'txt_apellido_mod
        '
        Me.txt_apellido_mod.Location = New System.Drawing.Point(90, 58)
        Me.txt_apellido_mod.Name = "txt_apellido_mod"
        Me.txt_apellido_mod.Size = New System.Drawing.Size(193, 21)
        Me.txt_apellido_mod.TabIndex = 7
        '
        'txt_usuario_mod
        '
        Me.txt_usuario_mod.Location = New System.Drawing.Point(90, 91)
        Me.txt_usuario_mod.Name = "txt_usuario_mod"
        Me.txt_usuario_mod.ReadOnly = True
        Me.txt_usuario_mod.Size = New System.Drawing.Size(193, 21)
        Me.txt_usuario_mod.TabIndex = 8
        '
        'txt_mail_mod
        '
        Me.txt_mail_mod.Location = New System.Drawing.Point(90, 124)
        Me.txt_mail_mod.Name = "txt_mail_mod"
        Me.txt_mail_mod.Size = New System.Drawing.Size(193, 21)
        Me.txt_mail_mod.TabIndex = 9
        '
        'chk_Habilitado_mod
        '
        Me.chk_Habilitado_mod.AutoSize = True
        Me.chk_Habilitado_mod.Checked = True
        Me.chk_Habilitado_mod.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Habilitado_mod.Location = New System.Drawing.Point(90, 165)
        Me.chk_Habilitado_mod.Name = "chk_Habilitado_mod"
        Me.chk_Habilitado_mod.Size = New System.Drawing.Size(15, 14)
        Me.chk_Habilitado_mod.TabIndex = 10
        Me.chk_Habilitado_mod.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Habilitado"
        '
        'lbl_descripcion_mod
        '
        Me.lbl_descripcion_mod.AutoSize = True
        Me.lbl_descripcion_mod.Location = New System.Drawing.Point(16, 31)
        Me.lbl_descripcion_mod.Name = "lbl_descripcion_mod"
        Me.lbl_descripcion_mod.Size = New System.Drawing.Size(52, 15)
        Me.lbl_descripcion_mod.TabIndex = 1
        Me.lbl_descripcion_mod.Tag = " "
        Me.lbl_descripcion_mod.Text = "Nombre"
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
        Me.Btn_Modificar.Location = New System.Drawing.Point(547, 140)
        Me.Btn_Modificar.Name = "Btn_Modificar"
        Me.Btn_Modificar.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Modificar.TabIndex = 14
        Me.Btn_Modificar.Text = "Modificar"
        Me.Btn_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Modificar.UseVisualStyleBackColor = False
        '
        'ErrorUsuarios
        '
        Me.ErrorUsuarios.BlinkRate = 200
        Me.ErrorUsuarios.ContainerControl = Me
        '
        'ToolUsuarios
        '
        Me.ToolUsuarios.IsBalloon = True
        Me.ToolUsuarios.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolUsuarios.ToolTipTitle = "Ayuda."
        '
        'frmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 552)
        Me.Controls.Add(Me.TabUsuarios)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administración de Usuarios"
        Me.TabUsuarios.ResumeLayout(False)
        Me.TbListado.ResumeLayout(False)
        Me.TbListado.PerformLayout()
        CType(Me.DG_Usuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TbAlta.ResumeLayout(False)
        Me.GB_Alta.ResumeLayout(False)
        Me.GB_Alta.PerformLayout()
        Me.TbMod.ResumeLayout(False)
        Me.GB_Buscar.ResumeLayout(False)
        Me.GB_Buscar.PerformLayout()
        CType(Me.DG_Buscador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_Modificacion.ResumeLayout(False)
        Me.GB_Modificacion.PerformLayout()
        CType(Me.ErrorUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabUsuarios As System.Windows.Forms.TabControl
    Friend WithEvents TbListado As System.Windows.Forms.TabPage
    Friend WithEvents DG_Usuarios As System.Windows.Forms.DataGridView
    Friend WithEvents TbAlta As System.Windows.Forms.TabPage
    Friend WithEvents GB_Alta As System.Windows.Forms.GroupBox
    Friend WithEvents chk_Habilitado As System.Windows.Forms.CheckBox
    Friend WithEvents txt_usuario As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
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
    Friend WithEvents lbl_Usuario As System.Windows.Forms.Label
    Friend WithEvents lbl_mail As System.Windows.Forms.Label
    Friend WithEvents lbl_apellido As System.Windows.Forms.Label
    Friend WithEvents lbl_pass As System.Windows.Forms.Label
    Friend WithEvents lbl_pass2 As System.Windows.Forms.Label
    Friend WithEvents txt_pass As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents txt_mail As System.Windows.Forms.TextBox
    Friend WithEvents txt_apellido As System.Windows.Forms.TextBox
    Friend WithEvents txt_pass2 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_pass2_mod As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_pass_mod As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre_mod As System.Windows.Forms.TextBox
    Friend WithEvents txt_apellido_mod As System.Windows.Forms.TextBox
    Friend WithEvents txt_usuario_mod As System.Windows.Forms.TextBox
    Friend WithEvents txt_mail_mod As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Perfil As System.Windows.Forms.Label
    Friend WithEvents cb_Perfiles As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Cb_Perfiles_mod As System.Windows.Forms.ComboBox
    Friend WithEvents ErrorUsuarios As System.Windows.Forms.ErrorProvider
    Friend WithEvents lbl_Msg As System.Windows.Forms.Label
    Friend WithEvents lbl_Msg2 As System.Windows.Forms.Label
    Friend WithEvents btn_Restablecer As System.Windows.Forms.Button
    Friend WithEvents ToolUsuarios As System.Windows.Forms.ToolTip
    Friend WithEvents id_Usuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Usuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Apellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Habilitado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Modificar As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents id_Usuario_Bus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Usuario_Bus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre_Bus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Apellido_Bus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Habilitado_Bus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Eliminar_bus As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
