<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProveedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProveedores))
        Me.TabProveedores = New System.Windows.Forms.TabControl()
        Me.TbListado = New System.Windows.Forms.TabPage()
        Me.lbl_Msg = New System.Windows.Forms.Label()
        Me.DG_Proveedores = New System.Windows.Forms.DataGridView()
        Me.id_Proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RazonSocial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Habilitado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Modificar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Eliminar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.GB_Buscar = New System.Windows.Forms.GroupBox()
        Me.btn_Restablecer = New System.Windows.Forms.Button()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.txt_buscar = New System.Windows.Forms.TextBox()
        Me.lbl_descripcion_bus = New System.Windows.Forms.Label()
        Me.TbAlta = New System.Windows.Forms.TabPage()
        Me.GB_Alta = New System.Windows.Forms.GroupBox()
        Me.cb_CondicionIva = New System.Windows.Forms.ComboBox()
        Me.lbl_CondicionIva = New System.Windows.Forms.Label()
        Me.txt_Telefono = New System.Windows.Forms.TextBox()
        Me.lbl_Telefono = New System.Windows.Forms.Label()
        Me.txt_MailAlternativo = New System.Windows.Forms.TextBox()
        Me.lbl_MailAlternativo = New System.Windows.Forms.Label()
        Me.txt_Direccion = New System.Windows.Forms.TextBox()
        Me.lbl_Direccion = New System.Windows.Forms.Label()
        Me.txt_Mail = New System.Windows.Forms.TextBox()
        Me.lbl_Mail = New System.Windows.Forms.Label()
        Me.txt_RazonSocial = New System.Windows.Forms.TextBox()
        Me.lbl_RazonSocial = New System.Windows.Forms.Label()
        Me.chk_Habilitado = New System.Windows.Forms.CheckBox()
        Me.txt_Nombre = New System.Windows.Forms.TextBox()
        Me.lbl_Habilitado = New System.Windows.Forms.Label()
        Me.lbl_Nombre = New System.Windows.Forms.Label()
        Me.Btn_Agregar = New System.Windows.Forms.Button()
        Me.TbMod = New System.Windows.Forms.TabPage()
        Me.GB_Modificacion = New System.Windows.Forms.GroupBox()
        Me.cb_CondicionIva_mod = New System.Windows.Forms.ComboBox()
        Me.lbl_Condicion_mod = New System.Windows.Forms.Label()
        Me.txt_Telefono_mod = New System.Windows.Forms.TextBox()
        Me.lbl_Telefono_mod = New System.Windows.Forms.Label()
        Me.txt_MailAlternativo_mod = New System.Windows.Forms.TextBox()
        Me.lbl_MailAlternativo_mod = New System.Windows.Forms.Label()
        Me.txt_Direccion_mod = New System.Windows.Forms.TextBox()
        Me.lbl_Direccion_mod = New System.Windows.Forms.Label()
        Me.txt_Mail_mod = New System.Windows.Forms.TextBox()
        Me.lbl_Mail_mod = New System.Windows.Forms.Label()
        Me.txt_RazonSocial_mod = New System.Windows.Forms.TextBox()
        Me.lbl_RazonSocial_mod = New System.Windows.Forms.Label()
        Me.chk_Habilitado_mod = New System.Windows.Forms.CheckBox()
        Me.txt_Nombre_mod = New System.Windows.Forms.TextBox()
        Me.lbl_Habilitado_mod = New System.Windows.Forms.Label()
        Me.lbl_Nombre_mod = New System.Windows.Forms.Label()
        Me.Btn_Eliminar = New System.Windows.Forms.Button()
        Me.Btn_Modificar = New System.Windows.Forms.Button()
        Me.ErrorProveedor = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolProv = New System.Windows.Forms.ToolTip(Me.components)
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.TabProveedores.SuspendLayout()
        Me.TbListado.SuspendLayout()
        CType(Me.DG_Proveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_Buscar.SuspendLayout()
        Me.TbAlta.SuspendLayout()
        Me.GB_Alta.SuspendLayout()
        Me.TbMod.SuspendLayout()
        Me.GB_Modificacion.SuspendLayout()
        CType(Me.ErrorProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabProveedores
        '
        Me.TabProveedores.Controls.Add(Me.TbListado)
        Me.TabProveedores.Controls.Add(Me.TbAlta)
        Me.TabProveedores.Controls.Add(Me.TbMod)
        Me.TabProveedores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabProveedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabProveedores.Location = New System.Drawing.Point(0, 0)
        Me.TabProveedores.Name = "TabProveedores"
        Me.TabProveedores.SelectedIndex = 0
        Me.TabProveedores.Size = New System.Drawing.Size(694, 572)
        Me.TabProveedores.TabIndex = 3
        '
        'TbListado
        '
        Me.TbListado.Controls.Add(Me.lbl_Msg)
        Me.TbListado.Controls.Add(Me.DG_Proveedores)
        Me.TbListado.Controls.Add(Me.GB_Buscar)
        Me.TbListado.Location = New System.Drawing.Point(4, 29)
        Me.TbListado.Name = "TbListado"
        Me.TbListado.Padding = New System.Windows.Forms.Padding(3)
        Me.TbListado.Size = New System.Drawing.Size(686, 539)
        Me.TbListado.TabIndex = 0
        Me.TbListado.Text = "Proveedores"
        Me.TbListado.UseVisualStyleBackColor = True
        '
        'lbl_Msg
        '
        Me.lbl_Msg.AutoSize = True
        Me.lbl_Msg.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lbl_Msg.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Msg.Location = New System.Drawing.Point(128, 297)
        Me.lbl_Msg.Name = "lbl_Msg"
        Me.lbl_Msg.Size = New System.Drawing.Size(431, 29)
        Me.lbl_Msg.TabIndex = 4
        Me.lbl_Msg.Text = "No se han encontrado proveedores."
        '
        'DG_Proveedores
        '
        Me.DG_Proveedores.AllowUserToAddRows = False
        Me.DG_Proveedores.AllowUserToDeleteRows = False
        Me.DG_Proveedores.AllowUserToResizeRows = False
        Me.DG_Proveedores.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_Proveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_Proveedores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DG_Proveedores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_Proveedor, Me.Nombre, Me.RazonSocial, Me.Telefono, Me.Mail, Me.Habilitado, Me.Modificar, Me.Eliminar})
        Me.DG_Proveedores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DG_Proveedores.Location = New System.Drawing.Point(10, 85)
        Me.DG_Proveedores.MultiSelect = False
        Me.DG_Proveedores.Name = "DG_Proveedores"
        Me.DG_Proveedores.ReadOnly = True
        Me.DG_Proveedores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DG_Proveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Proveedores.Size = New System.Drawing.Size(670, 446)
        Me.DG_Proveedores.TabIndex = 4
        '
        'id_Proveedor
        '
        Me.id_Proveedor.DataPropertyName = "id_Proveedor"
        Me.id_Proveedor.FillWeight = 128.6731!
        Me.id_Proveedor.HeaderText = "ID"
        Me.id_Proveedor.Name = "id_Proveedor"
        Me.id_Proveedor.ReadOnly = True
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.FillWeight = 128.6731!
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'RazonSocial
        '
        Me.RazonSocial.DataPropertyName = "RazonSocial"
        Me.RazonSocial.FillWeight = 128.6731!
        Me.RazonSocial.HeaderText = "Razon Social"
        Me.RazonSocial.Name = "RazonSocial"
        Me.RazonSocial.ReadOnly = True
        '
        'Telefono
        '
        Me.Telefono.DataPropertyName = "Telefono"
        Me.Telefono.FillWeight = 128.6731!
        Me.Telefono.HeaderText = "Telefono"
        Me.Telefono.Name = "Telefono"
        Me.Telefono.ReadOnly = True
        '
        'Mail
        '
        Me.Mail.DataPropertyName = "Mail"
        Me.Mail.FillWeight = 128.6731!
        Me.Mail.HeaderText = "Mail"
        Me.Mail.Name = "Mail"
        Me.Mail.ReadOnly = True
        '
        'Habilitado
        '
        Me.Habilitado.DataPropertyName = "Habilitado"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Habilitado.DefaultCellStyle = DataGridViewCellStyle1
        Me.Habilitado.FillWeight = 52.79188!
        Me.Habilitado.HeaderText = "Habilitado"
        Me.Habilitado.Name = "Habilitado"
        Me.Habilitado.ReadOnly = True
        '
        'Modificar
        '
        Me.Modificar.FillWeight = 52.21733!
        Me.Modificar.HeaderText = "Modificar"
        Me.Modificar.Image = Global.SistemaCinderella.My.Resources.Recursos.Boton_Editar
        Me.Modificar.Name = "Modificar"
        Me.Modificar.ReadOnly = True
        Me.Modificar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Modificar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Eliminar
        '
        Me.Eliminar.FillWeight = 51.62534!
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Image = Global.SistemaCinderella.My.Resources.Recursos.Boton_Eliminar
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
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
        Me.GB_Buscar.Size = New System.Drawing.Size(670, 73)
        Me.GB_Buscar.TabIndex = 0
        Me.GB_Buscar.TabStop = False
        Me.GB_Buscar.Text = "Buscar Proveedores"
        '
        'btn_Restablecer
        '
        Me.btn_Restablecer.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btn_Restablecer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Restablecer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Restablecer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Restablecer.Location = New System.Drawing.Point(458, 19)
        Me.btn_Restablecer.Name = "btn_Restablecer"
        Me.btn_Restablecer.Size = New System.Drawing.Size(100, 40)
        Me.btn_Restablecer.TabIndex = 2
        Me.btn_Restablecer.Text = "Restablecer Filtros"
        Me.ToolProv.SetToolTip(Me.btn_Restablecer, "Haz click aquí para restablecer el listado de proveedores.")
        Me.btn_Restablecer.UseVisualStyleBackColor = True
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Buscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Buscar.Image = Global.SistemaCinderella.My.Resources.Recursos.IconoBuscar32
        Me.btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Buscar.Location = New System.Drawing.Point(564, 19)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(100, 40)
        Me.btn_Buscar.TabIndex = 3
        Me.btn_Buscar.Text = "Buscar"
        Me.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolProv.SetToolTip(Me.btn_Buscar, "Haz click aquí para buscar proveedores con los criterios de busqueda seleccionado" & _
                "s.")
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'txt_buscar
        '
        Me.txt_buscar.Location = New System.Drawing.Point(103, 31)
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(280, 21)
        Me.txt_buscar.TabIndex = 1
        '
        'lbl_descripcion_bus
        '
        Me.lbl_descripcion_bus.AutoSize = True
        Me.lbl_descripcion_bus.Location = New System.Drawing.Point(17, 34)
        Me.lbl_descripcion_bus.Name = "lbl_descripcion_bus"
        Me.lbl_descripcion_bus.Size = New System.Drawing.Size(80, 15)
        Me.lbl_descripcion_bus.TabIndex = 0
        Me.lbl_descripcion_bus.Text = "Razon Social"
        '
        'TbAlta
        '
        Me.TbAlta.Controls.Add(Me.GB_Alta)
        Me.TbAlta.Location = New System.Drawing.Point(4, 29)
        Me.TbAlta.Name = "TbAlta"
        Me.TbAlta.Padding = New System.Windows.Forms.Padding(3)
        Me.TbAlta.Size = New System.Drawing.Size(686, 539)
        Me.TbAlta.TabIndex = 1
        Me.TbAlta.Text = "Alta de Proveedor"
        Me.TbAlta.UseVisualStyleBackColor = True
        '
        'GB_Alta
        '
        Me.GB_Alta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_Alta.Controls.Add(Me.cb_CondicionIva)
        Me.GB_Alta.Controls.Add(Me.lbl_CondicionIva)
        Me.GB_Alta.Controls.Add(Me.txt_Telefono)
        Me.GB_Alta.Controls.Add(Me.lbl_Telefono)
        Me.GB_Alta.Controls.Add(Me.txt_MailAlternativo)
        Me.GB_Alta.Controls.Add(Me.lbl_MailAlternativo)
        Me.GB_Alta.Controls.Add(Me.txt_Direccion)
        Me.GB_Alta.Controls.Add(Me.lbl_Direccion)
        Me.GB_Alta.Controls.Add(Me.txt_Mail)
        Me.GB_Alta.Controls.Add(Me.lbl_Mail)
        Me.GB_Alta.Controls.Add(Me.txt_RazonSocial)
        Me.GB_Alta.Controls.Add(Me.lbl_RazonSocial)
        Me.GB_Alta.Controls.Add(Me.chk_Habilitado)
        Me.GB_Alta.Controls.Add(Me.txt_Nombre)
        Me.GB_Alta.Controls.Add(Me.lbl_Habilitado)
        Me.GB_Alta.Controls.Add(Me.lbl_Nombre)
        Me.GB_Alta.Controls.Add(Me.Btn_Agregar)
        Me.GB_Alta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Alta.Location = New System.Drawing.Point(6, 6)
        Me.GB_Alta.Name = "GB_Alta"
        Me.GB_Alta.Size = New System.Drawing.Size(674, 525)
        Me.GB_Alta.TabIndex = 0
        Me.GB_Alta.TabStop = False
        Me.GB_Alta.Text = "Formulario de Alta"
        '
        'cb_CondicionIva
        '
        Me.cb_CondicionIva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_CondicionIva.FormattingEnabled = True
        Me.cb_CondicionIva.Location = New System.Drawing.Point(116, 206)
        Me.cb_CondicionIva.Name = "cb_CondicionIva"
        Me.cb_CondicionIva.Size = New System.Drawing.Size(264, 21)
        Me.cb_CondicionIva.TabIndex = 6
        '
        'lbl_CondicionIva
        '
        Me.lbl_CondicionIva.AutoSize = True
        Me.lbl_CondicionIva.Location = New System.Drawing.Point(8, 209)
        Me.lbl_CondicionIva.Name = "lbl_CondicionIva"
        Me.lbl_CondicionIva.Size = New System.Drawing.Size(102, 13)
        Me.lbl_CondicionIva.TabIndex = 21
        Me.lbl_CondicionIva.Text = "Condición de IVA (*)"
        '
        'txt_Telefono
        '
        Me.txt_Telefono.Location = New System.Drawing.Point(116, 171)
        Me.txt_Telefono.MaxLength = 255
        Me.txt_Telefono.Name = "txt_Telefono"
        Me.txt_Telefono.Size = New System.Drawing.Size(264, 20)
        Me.txt_Telefono.TabIndex = 5
        '
        'lbl_Telefono
        '
        Me.lbl_Telefono.AutoSize = True
        Me.lbl_Telefono.Location = New System.Drawing.Point(8, 174)
        Me.lbl_Telefono.Name = "lbl_Telefono"
        Me.lbl_Telefono.Size = New System.Drawing.Size(49, 13)
        Me.lbl_Telefono.TabIndex = 15
        Me.lbl_Telefono.Text = "Teléfono"
        '
        'txt_MailAlternativo
        '
        Me.txt_MailAlternativo.Location = New System.Drawing.Point(116, 136)
        Me.txt_MailAlternativo.MaxLength = 255
        Me.txt_MailAlternativo.Name = "txt_MailAlternativo"
        Me.txt_MailAlternativo.Size = New System.Drawing.Size(263, 20)
        Me.txt_MailAlternativo.TabIndex = 4
        '
        'lbl_MailAlternativo
        '
        Me.lbl_MailAlternativo.AutoSize = True
        Me.lbl_MailAlternativo.Location = New System.Drawing.Point(8, 139)
        Me.lbl_MailAlternativo.Name = "lbl_MailAlternativo"
        Me.lbl_MailAlternativo.Size = New System.Drawing.Size(85, 13)
        Me.lbl_MailAlternativo.TabIndex = 13
        Me.lbl_MailAlternativo.Text = "Mail (Alternativo)"
        '
        'txt_Direccion
        '
        Me.txt_Direccion.Location = New System.Drawing.Point(116, 241)
        Me.txt_Direccion.MaxLength = 255
        Me.txt_Direccion.Name = "txt_Direccion"
        Me.txt_Direccion.Size = New System.Drawing.Size(263, 20)
        Me.txt_Direccion.TabIndex = 7
        '
        'lbl_Direccion
        '
        Me.lbl_Direccion.AutoSize = True
        Me.lbl_Direccion.Location = New System.Drawing.Point(8, 244)
        Me.lbl_Direccion.Name = "lbl_Direccion"
        Me.lbl_Direccion.Size = New System.Drawing.Size(52, 13)
        Me.lbl_Direccion.TabIndex = 11
        Me.lbl_Direccion.Text = "Direccion"
        '
        'txt_Mail
        '
        Me.txt_Mail.Location = New System.Drawing.Point(116, 101)
        Me.txt_Mail.MaxLength = 255
        Me.txt_Mail.Name = "txt_Mail"
        Me.txt_Mail.Size = New System.Drawing.Size(263, 20)
        Me.txt_Mail.TabIndex = 3
        '
        'lbl_Mail
        '
        Me.lbl_Mail.AutoSize = True
        Me.lbl_Mail.Location = New System.Drawing.Point(8, 104)
        Me.lbl_Mail.Name = "lbl_Mail"
        Me.lbl_Mail.Size = New System.Drawing.Size(39, 13)
        Me.lbl_Mail.TabIndex = 7
        Me.lbl_Mail.Text = "Mail (*)"
        '
        'txt_RazonSocial
        '
        Me.txt_RazonSocial.Location = New System.Drawing.Point(116, 66)
        Me.txt_RazonSocial.MaxLength = 255
        Me.txt_RazonSocial.Name = "txt_RazonSocial"
        Me.txt_RazonSocial.Size = New System.Drawing.Size(263, 20)
        Me.txt_RazonSocial.TabIndex = 2
        '
        'lbl_RazonSocial
        '
        Me.lbl_RazonSocial.AutoSize = True
        Me.lbl_RazonSocial.Location = New System.Drawing.Point(8, 69)
        Me.lbl_RazonSocial.Name = "lbl_RazonSocial"
        Me.lbl_RazonSocial.Size = New System.Drawing.Size(83, 13)
        Me.lbl_RazonSocial.TabIndex = 5
        Me.lbl_RazonSocial.Text = "Razon Social (*)"
        '
        'chk_Habilitado
        '
        Me.chk_Habilitado.AutoSize = True
        Me.chk_Habilitado.Checked = True
        Me.chk_Habilitado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Habilitado.Location = New System.Drawing.Point(116, 279)
        Me.chk_Habilitado.Name = "chk_Habilitado"
        Me.chk_Habilitado.Size = New System.Drawing.Size(15, 14)
        Me.chk_Habilitado.TabIndex = 8
        Me.chk_Habilitado.UseVisualStyleBackColor = True
        '
        'txt_Nombre
        '
        Me.txt_Nombre.Location = New System.Drawing.Point(116, 31)
        Me.txt_Nombre.MaxLength = 255
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.Size = New System.Drawing.Size(264, 20)
        Me.txt_Nombre.TabIndex = 1
        '
        'lbl_Habilitado
        '
        Me.lbl_Habilitado.AutoSize = True
        Me.lbl_Habilitado.Location = New System.Drawing.Point(8, 279)
        Me.lbl_Habilitado.Name = "lbl_Habilitado"
        Me.lbl_Habilitado.Size = New System.Drawing.Size(54, 13)
        Me.lbl_Habilitado.TabIndex = 2
        Me.lbl_Habilitado.Text = "Habilitado"
        '
        'lbl_Nombre
        '
        Me.lbl_Nombre.AutoSize = True
        Me.lbl_Nombre.Location = New System.Drawing.Point(8, 34)
        Me.lbl_Nombre.Name = "lbl_Nombre"
        Me.lbl_Nombre.Size = New System.Drawing.Size(57, 13)
        Me.lbl_Nombre.TabIndex = 1
        Me.lbl_Nombre.Text = "Nombre (*)"
        '
        'Btn_Agregar
        '
        Me.Btn_Agregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Agregar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Agregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Agregar.Image = Global.SistemaCinderella.My.Resources.Recursos.Agregar_24
        Me.Btn_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Agregar.Location = New System.Drawing.Point(568, 479)
        Me.Btn_Agregar.Name = "Btn_Agregar"
        Me.Btn_Agregar.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Agregar.TabIndex = 9
        Me.Btn_Agregar.Text = "Agregar"
        Me.Btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Agregar.UseVisualStyleBackColor = False
        '
        'TbMod
        '
        Me.TbMod.Controls.Add(Me.GB_Modificacion)
        Me.TbMod.Location = New System.Drawing.Point(4, 29)
        Me.TbMod.Name = "TbMod"
        Me.TbMod.Size = New System.Drawing.Size(686, 539)
        Me.TbMod.TabIndex = 2
        Me.TbMod.Text = "Modificación de Proveedor"
        Me.TbMod.UseVisualStyleBackColor = True
        '
        'GB_Modificacion
        '
        Me.GB_Modificacion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_Modificacion.Controls.Add(Me.Btn_Cancelar)
        Me.GB_Modificacion.Controls.Add(Me.cb_CondicionIva_mod)
        Me.GB_Modificacion.Controls.Add(Me.lbl_Condicion_mod)
        Me.GB_Modificacion.Controls.Add(Me.txt_Telefono_mod)
        Me.GB_Modificacion.Controls.Add(Me.lbl_Telefono_mod)
        Me.GB_Modificacion.Controls.Add(Me.txt_MailAlternativo_mod)
        Me.GB_Modificacion.Controls.Add(Me.lbl_MailAlternativo_mod)
        Me.GB_Modificacion.Controls.Add(Me.txt_Direccion_mod)
        Me.GB_Modificacion.Controls.Add(Me.lbl_Direccion_mod)
        Me.GB_Modificacion.Controls.Add(Me.txt_Mail_mod)
        Me.GB_Modificacion.Controls.Add(Me.lbl_Mail_mod)
        Me.GB_Modificacion.Controls.Add(Me.txt_RazonSocial_mod)
        Me.GB_Modificacion.Controls.Add(Me.lbl_RazonSocial_mod)
        Me.GB_Modificacion.Controls.Add(Me.chk_Habilitado_mod)
        Me.GB_Modificacion.Controls.Add(Me.txt_Nombre_mod)
        Me.GB_Modificacion.Controls.Add(Me.lbl_Habilitado_mod)
        Me.GB_Modificacion.Controls.Add(Me.lbl_Nombre_mod)
        Me.GB_Modificacion.Controls.Add(Me.Btn_Eliminar)
        Me.GB_Modificacion.Controls.Add(Me.Btn_Modificar)
        Me.GB_Modificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Modificacion.Location = New System.Drawing.Point(6, 6)
        Me.GB_Modificacion.Name = "GB_Modificacion"
        Me.GB_Modificacion.Size = New System.Drawing.Size(670, 525)
        Me.GB_Modificacion.TabIndex = 1
        Me.GB_Modificacion.TabStop = False
        Me.GB_Modificacion.Text = "Formulario de Modificación"
        '
        'cb_CondicionIva_mod
        '
        Me.cb_CondicionIva_mod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_CondicionIva_mod.FormattingEnabled = True
        Me.cb_CondicionIva_mod.Location = New System.Drawing.Point(111, 207)
        Me.cb_CondicionIva_mod.Name = "cb_CondicionIva_mod"
        Me.cb_CondicionIva_mod.Size = New System.Drawing.Size(264, 21)
        Me.cb_CondicionIva_mod.TabIndex = 30
        '
        'lbl_Condicion_mod
        '
        Me.lbl_Condicion_mod.AutoSize = True
        Me.lbl_Condicion_mod.Location = New System.Drawing.Point(6, 207)
        Me.lbl_Condicion_mod.Name = "lbl_Condicion_mod"
        Me.lbl_Condicion_mod.Size = New System.Drawing.Size(102, 13)
        Me.lbl_Condicion_mod.TabIndex = 37
        Me.lbl_Condicion_mod.Text = "Condición de IVA (*)"
        '
        'txt_Telefono_mod
        '
        Me.txt_Telefono_mod.Location = New System.Drawing.Point(111, 172)
        Me.txt_Telefono_mod.MaxLength = 255
        Me.txt_Telefono_mod.Name = "txt_Telefono_mod"
        Me.txt_Telefono_mod.Size = New System.Drawing.Size(264, 20)
        Me.txt_Telefono_mod.TabIndex = 29
        '
        'lbl_Telefono_mod
        '
        Me.lbl_Telefono_mod.AutoSize = True
        Me.lbl_Telefono_mod.Location = New System.Drawing.Point(6, 172)
        Me.lbl_Telefono_mod.Name = "lbl_Telefono_mod"
        Me.lbl_Telefono_mod.Size = New System.Drawing.Size(49, 13)
        Me.lbl_Telefono_mod.TabIndex = 36
        Me.lbl_Telefono_mod.Text = "Teléfono"
        '
        'txt_MailAlternativo_mod
        '
        Me.txt_MailAlternativo_mod.Location = New System.Drawing.Point(111, 137)
        Me.txt_MailAlternativo_mod.MaxLength = 255
        Me.txt_MailAlternativo_mod.Name = "txt_MailAlternativo_mod"
        Me.txt_MailAlternativo_mod.Size = New System.Drawing.Size(263, 20)
        Me.txt_MailAlternativo_mod.TabIndex = 27
        '
        'lbl_MailAlternativo_mod
        '
        Me.lbl_MailAlternativo_mod.AutoSize = True
        Me.lbl_MailAlternativo_mod.Location = New System.Drawing.Point(6, 137)
        Me.lbl_MailAlternativo_mod.Name = "lbl_MailAlternativo_mod"
        Me.lbl_MailAlternativo_mod.Size = New System.Drawing.Size(85, 13)
        Me.lbl_MailAlternativo_mod.TabIndex = 35
        Me.lbl_MailAlternativo_mod.Text = "Mail (Alternativo)"
        '
        'txt_Direccion_mod
        '
        Me.txt_Direccion_mod.Location = New System.Drawing.Point(111, 242)
        Me.txt_Direccion_mod.MaxLength = 255
        Me.txt_Direccion_mod.Name = "txt_Direccion_mod"
        Me.txt_Direccion_mod.Size = New System.Drawing.Size(263, 20)
        Me.txt_Direccion_mod.TabIndex = 31
        '
        'lbl_Direccion_mod
        '
        Me.lbl_Direccion_mod.AutoSize = True
        Me.lbl_Direccion_mod.Location = New System.Drawing.Point(6, 242)
        Me.lbl_Direccion_mod.Name = "lbl_Direccion_mod"
        Me.lbl_Direccion_mod.Size = New System.Drawing.Size(52, 13)
        Me.lbl_Direccion_mod.TabIndex = 34
        Me.lbl_Direccion_mod.Text = "Direccion"
        '
        'txt_Mail_mod
        '
        Me.txt_Mail_mod.Location = New System.Drawing.Point(111, 102)
        Me.txt_Mail_mod.MaxLength = 255
        Me.txt_Mail_mod.Name = "txt_Mail_mod"
        Me.txt_Mail_mod.Size = New System.Drawing.Size(263, 20)
        Me.txt_Mail_mod.TabIndex = 26
        '
        'lbl_Mail_mod
        '
        Me.lbl_Mail_mod.AutoSize = True
        Me.lbl_Mail_mod.Location = New System.Drawing.Point(6, 102)
        Me.lbl_Mail_mod.Name = "lbl_Mail_mod"
        Me.lbl_Mail_mod.Size = New System.Drawing.Size(39, 13)
        Me.lbl_Mail_mod.TabIndex = 32
        Me.lbl_Mail_mod.Text = "Mail (*)"
        '
        'txt_RazonSocial_mod
        '
        Me.txt_RazonSocial_mod.Location = New System.Drawing.Point(111, 67)
        Me.txt_RazonSocial_mod.MaxLength = 255
        Me.txt_RazonSocial_mod.Name = "txt_RazonSocial_mod"
        Me.txt_RazonSocial_mod.Size = New System.Drawing.Size(263, 20)
        Me.txt_RazonSocial_mod.TabIndex = 25
        '
        'lbl_RazonSocial_mod
        '
        Me.lbl_RazonSocial_mod.AutoSize = True
        Me.lbl_RazonSocial_mod.Location = New System.Drawing.Point(6, 67)
        Me.lbl_RazonSocial_mod.Name = "lbl_RazonSocial_mod"
        Me.lbl_RazonSocial_mod.Size = New System.Drawing.Size(83, 13)
        Me.lbl_RazonSocial_mod.TabIndex = 28
        Me.lbl_RazonSocial_mod.Text = "Razon Social (*)"
        '
        'chk_Habilitado_mod
        '
        Me.chk_Habilitado_mod.AutoSize = True
        Me.chk_Habilitado_mod.Checked = True
        Me.chk_Habilitado_mod.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Habilitado_mod.Location = New System.Drawing.Point(111, 277)
        Me.chk_Habilitado_mod.Name = "chk_Habilitado_mod"
        Me.chk_Habilitado_mod.Size = New System.Drawing.Size(15, 14)
        Me.chk_Habilitado_mod.TabIndex = 33
        Me.chk_Habilitado_mod.UseVisualStyleBackColor = True
        '
        'txt_Nombre_mod
        '
        Me.txt_Nombre_mod.Location = New System.Drawing.Point(111, 32)
        Me.txt_Nombre_mod.MaxLength = 255
        Me.txt_Nombre_mod.Name = "txt_Nombre_mod"
        Me.txt_Nombre_mod.Size = New System.Drawing.Size(264, 20)
        Me.txt_Nombre_mod.TabIndex = 22
        '
        'lbl_Habilitado_mod
        '
        Me.lbl_Habilitado_mod.AutoSize = True
        Me.lbl_Habilitado_mod.Location = New System.Drawing.Point(9, 277)
        Me.lbl_Habilitado_mod.Name = "lbl_Habilitado_mod"
        Me.lbl_Habilitado_mod.Size = New System.Drawing.Size(54, 13)
        Me.lbl_Habilitado_mod.TabIndex = 24
        Me.lbl_Habilitado_mod.Text = "Habilitado"
        '
        'lbl_Nombre_mod
        '
        Me.lbl_Nombre_mod.AutoSize = True
        Me.lbl_Nombre_mod.Location = New System.Drawing.Point(6, 32)
        Me.lbl_Nombre_mod.Name = "lbl_Nombre_mod"
        Me.lbl_Nombre_mod.Size = New System.Drawing.Size(57, 13)
        Me.lbl_Nombre_mod.TabIndex = 23
        Me.lbl_Nombre_mod.Text = "Nombre (*)"
        '
        'Btn_Eliminar
        '
        Me.Btn_Eliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Eliminar.Image = Global.SistemaCinderella.My.Resources.Recursos.Limpiar_32
        Me.Btn_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Eliminar.Location = New System.Drawing.Point(458, 474)
        Me.Btn_Eliminar.Name = "Btn_Eliminar"
        Me.Btn_Eliminar.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Eliminar.TabIndex = 14
        Me.Btn_Eliminar.Text = "Eliminar"
        Me.Btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Eliminar.UseVisualStyleBackColor = True
        '
        'Btn_Modificar
        '
        Me.Btn_Modificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Modificar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Modificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Modificar.Image = Global.SistemaCinderella.My.Resources.Recursos.Editar_24
        Me.Btn_Modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Modificar.Location = New System.Drawing.Point(564, 474)
        Me.Btn_Modificar.Name = "Btn_Modificar"
        Me.Btn_Modificar.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Modificar.TabIndex = 15
        Me.Btn_Modificar.Text = "Modificar"
        Me.Btn_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Modificar.UseVisualStyleBackColor = False
        '
        'ErrorProveedor
        '
        Me.ErrorProveedor.BlinkRate = 200
        Me.ErrorProveedor.ContainerControl = Me
        '
        'ToolProv
        '
        Me.ToolProv.IsBalloon = True
        Me.ToolProv.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolProv.ToolTipTitle = "Ayuda"
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Cancelar.Image = Global.SistemaCinderella.My.Resources.Recursos.desconectado_32
        Me.Btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Cancelar.Location = New System.Drawing.Point(352, 474)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Cancelar.TabIndex = 82
        Me.Btn_Cancelar.Text = "Cancelar"
        Me.Btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolProv.SetToolTip(Me.Btn_Cancelar, "Descarta los cambios y vuelve al listado de proveedores")
        Me.Btn_Cancelar.UseVisualStyleBackColor = True
        '
        'frmProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 572)
        Me.Controls.Add(Me.TabProveedores)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmProveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administración de Proveedores"
        Me.TabProveedores.ResumeLayout(False)
        Me.TbListado.ResumeLayout(False)
        Me.TbListado.PerformLayout()
        CType(Me.DG_Proveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_Buscar.ResumeLayout(False)
        Me.GB_Buscar.PerformLayout()
        Me.TbAlta.ResumeLayout(False)
        Me.GB_Alta.ResumeLayout(False)
        Me.GB_Alta.PerformLayout()
        Me.TbMod.ResumeLayout(False)
        Me.GB_Modificacion.ResumeLayout(False)
        Me.GB_Modificacion.PerformLayout()
        CType(Me.ErrorProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabProveedores As System.Windows.Forms.TabControl
    Friend WithEvents TbListado As System.Windows.Forms.TabPage
    Friend WithEvents DG_Proveedores As System.Windows.Forms.DataGridView
    Friend WithEvents GB_Buscar As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents txt_buscar As System.Windows.Forms.TextBox
    Friend WithEvents lbl_descripcion_bus As System.Windows.Forms.Label
    Friend WithEvents TbAlta As System.Windows.Forms.TabPage
    Friend WithEvents GB_Alta As System.Windows.Forms.GroupBox
    Friend WithEvents cb_CondicionIva As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_CondicionIva As System.Windows.Forms.Label
    Friend WithEvents txt_Telefono As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Telefono As System.Windows.Forms.Label
    Friend WithEvents txt_MailAlternativo As System.Windows.Forms.TextBox
    Friend WithEvents lbl_MailAlternativo As System.Windows.Forms.Label
    Friend WithEvents txt_Direccion As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Direccion As System.Windows.Forms.Label
    Friend WithEvents txt_Mail As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Mail As System.Windows.Forms.Label
    Friend WithEvents txt_RazonSocial As System.Windows.Forms.TextBox
    Friend WithEvents lbl_RazonSocial As System.Windows.Forms.Label
    Friend WithEvents chk_Habilitado As System.Windows.Forms.CheckBox
    Friend WithEvents txt_Nombre As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Habilitado As System.Windows.Forms.Label
    Friend WithEvents lbl_Nombre As System.Windows.Forms.Label
    Friend WithEvents Btn_Agregar As System.Windows.Forms.Button
    Friend WithEvents TbMod As System.Windows.Forms.TabPage
    Friend WithEvents GB_Modificacion As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents Btn_Modificar As System.Windows.Forms.Button
    Friend WithEvents cb_CondicionIva_mod As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_Condicion_mod As System.Windows.Forms.Label
    Friend WithEvents txt_Telefono_mod As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Telefono_mod As System.Windows.Forms.Label
    Friend WithEvents txt_MailAlternativo_mod As System.Windows.Forms.TextBox
    Friend WithEvents lbl_MailAlternativo_mod As System.Windows.Forms.Label
    Friend WithEvents txt_Direccion_mod As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Direccion_mod As System.Windows.Forms.Label
    Friend WithEvents txt_Mail_mod As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Mail_mod As System.Windows.Forms.Label
    Friend WithEvents txt_RazonSocial_mod As System.Windows.Forms.TextBox
    Friend WithEvents lbl_RazonSocial_mod As System.Windows.Forms.Label
    Friend WithEvents chk_Habilitado_mod As System.Windows.Forms.CheckBox
    Friend WithEvents txt_Nombre_mod As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Habilitado_mod As System.Windows.Forms.Label
    Friend WithEvents lbl_Nombre_mod As System.Windows.Forms.Label
    Friend WithEvents ErrorProveedor As System.Windows.Forms.ErrorProvider
    Friend WithEvents btn_Restablecer As System.Windows.Forms.Button
    Friend WithEvents lbl_Msg As System.Windows.Forms.Label
    Friend WithEvents ToolProv As System.Windows.Forms.ToolTip
    Friend WithEvents id_Proveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RazonSocial As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Telefono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Mail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Habilitado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Modificar As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Btn_Cancelar As System.Windows.Forms.Button
End Class
