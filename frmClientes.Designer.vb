<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientes
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClientes))
        Me.TabClientes = New System.Windows.Forms.TabControl()
        Me.TbListado = New System.Windows.Forms.TabPage()
        Me.GB_Buscar = New System.Windows.Forms.GroupBox()
        Me.btn_Restablecer = New System.Windows.Forms.Button()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.txt_buscar = New System.Windows.Forms.TextBox()
        Me.lbl_descripcion_bus = New System.Windows.Forms.Label()
        Me.DG_Clientes = New System.Windows.Forms.DataGridView()
        Me.id_Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RazonSocial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cuit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListaPrecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Habilitado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Modificar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Eliminar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Compras = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TbAlta = New System.Windows.Forms.TabPage()
        Me.GB_Alta = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cb_Localidad = New System.Windows.Forms.ComboBox()
        Me.cb_Distrito = New System.Windows.Forms.ComboBox()
        Me.cb_Provincia = New System.Windows.Forms.ComboBox()
        Me.lbl_Provincia = New System.Windows.Forms.Label()
        Me.lbl_Distrito = New System.Windows.Forms.Label()
        Me.lbl_Localidad = New System.Windows.Forms.Label()
        Me.cb_CondicionIva = New System.Windows.Forms.ComboBox()
        Me.cb_ListaPrecios = New System.Windows.Forms.ComboBox()
        Me.lbl_CondicionIva = New System.Windows.Forms.Label()
        Me.lbl_ListaPrecio = New System.Windows.Forms.Label()
        Me.txt_Observaciones = New System.Windows.Forms.TextBox()
        Me.lbl_Observaciones = New System.Windows.Forms.Label()
        Me.txt_Mail = New System.Windows.Forms.TextBox()
        Me.lbl_Mail = New System.Windows.Forms.Label()
        Me.txt_Telefono = New System.Windows.Forms.TextBox()
        Me.lbl_Telefono = New System.Windows.Forms.Label()
        Me.txt_CodigoPostal = New System.Windows.Forms.TextBox()
        Me.lbl_CodigoPostal = New System.Windows.Forms.Label()
        Me.txt_Direccion = New System.Windows.Forms.TextBox()
        Me.lbl_Direccion = New System.Windows.Forms.Label()
        Me.txt_Transporte = New System.Windows.Forms.TextBox()
        Me.lbl_Transporte = New System.Windows.Forms.Label()
        Me.lbl_Cuit = New System.Windows.Forms.Label()
        Me.txt_Contacto = New System.Windows.Forms.TextBox()
        Me.lbl_Contacto = New System.Windows.Forms.Label()
        Me.chk_Habilitado = New System.Windows.Forms.CheckBox()
        Me.txt_RazonSocial = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_RazonSocial = New System.Windows.Forms.Label()
        Me.Btn_Agregar = New System.Windows.Forms.Button()
        Me.TbMod = New System.Windows.Forms.TabPage()
        Me.GB_Modificacion = New System.Windows.Forms.GroupBox()
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Btn_Eliminar = New System.Windows.Forms.Button()
        Me.cb_Localidad_mod = New System.Windows.Forms.ComboBox()
        Me.cb_Distrito_mod = New System.Windows.Forms.ComboBox()
        Me.cb_Provincia_mod = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cb_CondicionIva_mod = New System.Windows.Forms.ComboBox()
        Me.cb_ListaPrecios_mod = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_Observaciones_mod = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_Mail_mod = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_Telefono_mod = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_CodigoPostal_mod = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_Direccion_mod = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_Transporte_mod = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_Contacto_mod = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.chk_Habilitado_mod = New System.Windows.Forms.CheckBox()
        Me.txt_RazonSocial_mod = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Btn_Modificar = New System.Windows.Forms.Button()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ErroresClie = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolCliente = New System.Windows.Forms.ToolTip(Me.components)
        Me.txt_Cuit = New System.Windows.Forms.MaskedTextBox()
        Me.txt_cuit_mod = New System.Windows.Forms.MaskedTextBox()
        Me.TabClientes.SuspendLayout()
        Me.TbListado.SuspendLayout()
        Me.GB_Buscar.SuspendLayout()
        CType(Me.DG_Clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TbAlta.SuspendLayout()
        Me.GB_Alta.SuspendLayout()
        Me.TbMod.SuspendLayout()
        Me.GB_Modificacion.SuspendLayout()
        CType(Me.ErroresClie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabClientes
        '
        Me.TabClientes.Controls.Add(Me.TbListado)
        Me.TabClientes.Controls.Add(Me.TbAlta)
        Me.TabClientes.Controls.Add(Me.TbMod)
        Me.TabClientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabClientes.Location = New System.Drawing.Point(0, 0)
        Me.TabClientes.Name = "TabClientes"
        Me.TabClientes.SelectedIndex = 0
        Me.TabClientes.Size = New System.Drawing.Size(794, 472)
        Me.TabClientes.TabIndex = 1
        '
        'TbListado
        '
        Me.TbListado.Controls.Add(Me.GB_Buscar)
        Me.TbListado.Controls.Add(Me.DG_Clientes)
        Me.TbListado.Location = New System.Drawing.Point(4, 29)
        Me.TbListado.Name = "TbListado"
        Me.TbListado.Padding = New System.Windows.Forms.Padding(3)
        Me.TbListado.Size = New System.Drawing.Size(786, 439)
        Me.TbListado.TabIndex = 0
        Me.TbListado.Text = "Clientes"
        Me.TbListado.UseVisualStyleBackColor = True
        '
        'GB_Buscar
        '
        Me.GB_Buscar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_Buscar.Controls.Add(Me.btn_Restablecer)
        Me.GB_Buscar.Controls.Add(Me.btn_Buscar)
        Me.GB_Buscar.Controls.Add(Me.txt_buscar)
        Me.GB_Buscar.Controls.Add(Me.lbl_descripcion_bus)
        Me.GB_Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Buscar.Location = New System.Drawing.Point(10, 6)
        Me.GB_Buscar.Name = "GB_Buscar"
        Me.GB_Buscar.Size = New System.Drawing.Size(770, 73)
        Me.GB_Buscar.TabIndex = 3
        Me.GB_Buscar.TabStop = False
        Me.GB_Buscar.Text = "Buscar Cliente"
        '
        'btn_Restablecer
        '
        Me.btn_Restablecer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Restablecer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Restablecer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Restablecer.Location = New System.Drawing.Point(558, 19)
        Me.btn_Restablecer.Name = "btn_Restablecer"
        Me.btn_Restablecer.Size = New System.Drawing.Size(100, 40)
        Me.btn_Restablecer.TabIndex = 8
        Me.btn_Restablecer.Text = "Restablecer Busqueda"
        Me.ToolCliente.SetToolTip(Me.btn_Restablecer, "haz click aquí para restablecer los filtros y el listado de clientes.")
        Me.btn_Restablecer.UseVisualStyleBackColor = True
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Buscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Buscar.Image = Global.SistemaCinderella.My.Resources.Recursos.IconoBuscar32
        Me.btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Buscar.Location = New System.Drawing.Point(664, 19)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(100, 40)
        Me.btn_Buscar.TabIndex = 6
        Me.btn_Buscar.Text = "Buscar"
        Me.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolCliente.SetToolTip(Me.btn_Buscar, "Haz click aquí para buscar clientes con los criterios de busqueda seleccionados.")
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'txt_buscar
        '
        Me.txt_buscar.Location = New System.Drawing.Point(105, 29)
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(373, 21)
        Me.txt_buscar.TabIndex = 1
        '
        'lbl_descripcion_bus
        '
        Me.lbl_descripcion_bus.AutoSize = True
        Me.lbl_descripcion_bus.Location = New System.Drawing.Point(15, 32)
        Me.lbl_descripcion_bus.Name = "lbl_descripcion_bus"
        Me.lbl_descripcion_bus.Size = New System.Drawing.Size(80, 15)
        Me.lbl_descripcion_bus.TabIndex = 0
        Me.lbl_descripcion_bus.Text = "Razon Social"
        '
        'DG_Clientes
        '
        Me.DG_Clientes.AllowUserToAddRows = False
        Me.DG_Clientes.AllowUserToDeleteRows = False
        Me.DG_Clientes.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DG_Clientes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DG_Clientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_Clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_Clientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_Cliente, Me.RazonSocial, Me.Cuit, Me.Telefono, Me.Direccion, Me.Mail, Me.ListaPrecio, Me.Habilitado, Me.Modificar, Me.Eliminar, Me.Compras})
        Me.DG_Clientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DG_Clientes.Location = New System.Drawing.Point(8, 85)
        Me.DG_Clientes.MultiSelect = False
        Me.DG_Clientes.Name = "DG_Clientes"
        Me.DG_Clientes.ReadOnly = True
        Me.DG_Clientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DG_Clientes.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DG_Clientes.RowTemplate.Height = 30
        Me.DG_Clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Clientes.Size = New System.Drawing.Size(770, 346)
        Me.DG_Clientes.TabIndex = 0
        '
        'id_Cliente
        '
        Me.id_Cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.id_Cliente.DataPropertyName = "id_Cliente"
        Me.id_Cliente.HeaderText = "ID"
        Me.id_Cliente.MaxInputLength = 10
        Me.id_Cliente.Name = "id_Cliente"
        Me.id_Cliente.ReadOnly = True
        Me.id_Cliente.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.id_Cliente.Width = 51
        '
        'RazonSocial
        '
        Me.RazonSocial.DataPropertyName = "RazonSocial"
        Me.RazonSocial.FillWeight = 114.3049!
        Me.RazonSocial.HeaderText = "Razon Social"
        Me.RazonSocial.Name = "RazonSocial"
        Me.RazonSocial.ReadOnly = True
        '
        'Cuit
        '
        Me.Cuit.DataPropertyName = "Cuit"
        Me.Cuit.FillWeight = 114.3049!
        Me.Cuit.HeaderText = "Cuit"
        Me.Cuit.Name = "Cuit"
        Me.Cuit.ReadOnly = True
        '
        'Telefono
        '
        Me.Telefono.DataPropertyName = "Telefono"
        Me.Telefono.FillWeight = 114.3049!
        Me.Telefono.HeaderText = "Telefono"
        Me.Telefono.Name = "Telefono"
        Me.Telefono.ReadOnly = True
        '
        'Direccion
        '
        Me.Direccion.DataPropertyName = "Direccion"
        Me.Direccion.FillWeight = 114.3049!
        Me.Direccion.HeaderText = "Direccion"
        Me.Direccion.Name = "Direccion"
        Me.Direccion.ReadOnly = True
        '
        'Mail
        '
        Me.Mail.DataPropertyName = "Mail"
        Me.Mail.FillWeight = 114.3049!
        Me.Mail.HeaderText = "Mail"
        Me.Mail.Name = "Mail"
        Me.Mail.ReadOnly = True
        '
        'ListaPrecio
        '
        Me.ListaPrecio.DataPropertyName = "ListaPrecio"
        Me.ListaPrecio.FillWeight = 114.3049!
        Me.ListaPrecio.HeaderText = "Lista de Precio"
        Me.ListaPrecio.Name = "ListaPrecio"
        Me.ListaPrecio.ReadOnly = True
        '
        'Habilitado
        '
        Me.Habilitado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Habilitado.DataPropertyName = "Habilitado"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Habilitado.DefaultCellStyle = DataGridViewCellStyle2
        Me.Habilitado.FillWeight = 75.0!
        Me.Habilitado.HeaderText = "Habilitado"
        Me.Habilitado.MaxInputLength = 10
        Me.Habilitado.Name = "Habilitado"
        Me.Habilitado.ReadOnly = True
        Me.Habilitado.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Habilitado.Width = 105
        '
        'Modificar
        '
        Me.Modificar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Modificar.FillWeight = 78.88012!
        Me.Modificar.HeaderText = "Modificar"
        Me.Modificar.Image = Global.SistemaCinderella.My.Resources.Recursos.Boton_Editar
        Me.Modificar.Name = "Modificar"
        Me.Modificar.ReadOnly = True
        Me.Modificar.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Modificar.Width = 79
        '
        'Eliminar
        '
        Me.Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Eliminar.FillWeight = 77.92205!
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Image = Global.SistemaCinderella.My.Resources.Recursos.Boton_Eliminar
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Eliminar.Width = 71
        '
        'Compras
        '
        Me.Compras.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Compras.FillWeight = 79.20232!
        Me.Compras.HeaderText = "Compras"
        Me.Compras.Image = Global.SistemaCinderella.My.Resources.Recursos.Boton_Ventas
        Me.Compras.Name = "Compras"
        Me.Compras.ReadOnly = True
        Me.Compras.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Compras.Width = 79
        '
        'TbAlta
        '
        Me.TbAlta.Controls.Add(Me.GB_Alta)
        Me.TbAlta.Location = New System.Drawing.Point(4, 29)
        Me.TbAlta.Name = "TbAlta"
        Me.TbAlta.Padding = New System.Windows.Forms.Padding(3)
        Me.TbAlta.Size = New System.Drawing.Size(786, 439)
        Me.TbAlta.TabIndex = 1
        Me.TbAlta.Text = "Alta de Cliente"
        Me.TbAlta.UseVisualStyleBackColor = True
        '
        'GB_Alta
        '
        Me.GB_Alta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_Alta.Controls.Add(Me.txt_Cuit)
        Me.GB_Alta.Controls.Add(Me.Label17)
        Me.GB_Alta.Controls.Add(Me.cb_Localidad)
        Me.GB_Alta.Controls.Add(Me.cb_Distrito)
        Me.GB_Alta.Controls.Add(Me.cb_Provincia)
        Me.GB_Alta.Controls.Add(Me.lbl_Provincia)
        Me.GB_Alta.Controls.Add(Me.lbl_Distrito)
        Me.GB_Alta.Controls.Add(Me.lbl_Localidad)
        Me.GB_Alta.Controls.Add(Me.cb_CondicionIva)
        Me.GB_Alta.Controls.Add(Me.cb_ListaPrecios)
        Me.GB_Alta.Controls.Add(Me.lbl_CondicionIva)
        Me.GB_Alta.Controls.Add(Me.lbl_ListaPrecio)
        Me.GB_Alta.Controls.Add(Me.txt_Observaciones)
        Me.GB_Alta.Controls.Add(Me.lbl_Observaciones)
        Me.GB_Alta.Controls.Add(Me.txt_Mail)
        Me.GB_Alta.Controls.Add(Me.lbl_Mail)
        Me.GB_Alta.Controls.Add(Me.txt_Telefono)
        Me.GB_Alta.Controls.Add(Me.lbl_Telefono)
        Me.GB_Alta.Controls.Add(Me.txt_CodigoPostal)
        Me.GB_Alta.Controls.Add(Me.lbl_CodigoPostal)
        Me.GB_Alta.Controls.Add(Me.txt_Direccion)
        Me.GB_Alta.Controls.Add(Me.lbl_Direccion)
        Me.GB_Alta.Controls.Add(Me.txt_Transporte)
        Me.GB_Alta.Controls.Add(Me.lbl_Transporte)
        Me.GB_Alta.Controls.Add(Me.lbl_Cuit)
        Me.GB_Alta.Controls.Add(Me.txt_Contacto)
        Me.GB_Alta.Controls.Add(Me.lbl_Contacto)
        Me.GB_Alta.Controls.Add(Me.chk_Habilitado)
        Me.GB_Alta.Controls.Add(Me.txt_RazonSocial)
        Me.GB_Alta.Controls.Add(Me.Label2)
        Me.GB_Alta.Controls.Add(Me.lbl_RazonSocial)
        Me.GB_Alta.Controls.Add(Me.Btn_Agregar)
        Me.GB_Alta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Alta.Location = New System.Drawing.Point(10, 6)
        Me.GB_Alta.Name = "GB_Alta"
        Me.GB_Alta.Size = New System.Drawing.Size(768, 425)
        Me.GB_Alta.TabIndex = 0
        Me.GB_Alta.TabStop = False
        Me.GB_Alta.Text = "Formulario de Alta"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(6, 383)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(117, 13)
        Me.Label17.TabIndex = 68
        Me.Label17.Text = "(*) Campos obligatorios."
        '
        'cb_Localidad
        '
        Me.cb_Localidad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_Localidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Localidad.FormattingEnabled = True
        Me.cb_Localidad.Location = New System.Drawing.Point(152, 247)
        Me.cb_Localidad.Name = "cb_Localidad"
        Me.cb_Localidad.Size = New System.Drawing.Size(208, 23)
        Me.cb_Localidad.TabIndex = 7
        '
        'cb_Distrito
        '
        Me.cb_Distrito.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_Distrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Distrito.FormattingEnabled = True
        Me.cb_Distrito.Location = New System.Drawing.Point(151, 211)
        Me.cb_Distrito.Name = "cb_Distrito"
        Me.cb_Distrito.Size = New System.Drawing.Size(209, 23)
        Me.cb_Distrito.TabIndex = 6
        '
        'cb_Provincia
        '
        Me.cb_Provincia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_Provincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Provincia.FormattingEnabled = True
        Me.cb_Provincia.Location = New System.Drawing.Point(151, 175)
        Me.cb_Provincia.Name = "cb_Provincia"
        Me.cb_Provincia.Size = New System.Drawing.Size(209, 23)
        Me.cb_Provincia.TabIndex = 5
        '
        'lbl_Provincia
        '
        Me.lbl_Provincia.AutoSize = True
        Me.lbl_Provincia.Location = New System.Drawing.Point(5, 182)
        Me.lbl_Provincia.Name = "lbl_Provincia"
        Me.lbl_Provincia.Size = New System.Drawing.Size(73, 15)
        Me.lbl_Provincia.TabIndex = 27
        Me.lbl_Provincia.Text = "Provincia (*)"
        '
        'lbl_Distrito
        '
        Me.lbl_Distrito.AutoSize = True
        Me.lbl_Distrito.Location = New System.Drawing.Point(5, 217)
        Me.lbl_Distrito.Name = "lbl_Distrito"
        Me.lbl_Distrito.Size = New System.Drawing.Size(61, 15)
        Me.lbl_Distrito.TabIndex = 26
        Me.lbl_Distrito.Text = "Distrito (*)"
        '
        'lbl_Localidad
        '
        Me.lbl_Localidad.AutoSize = True
        Me.lbl_Localidad.Location = New System.Drawing.Point(5, 252)
        Me.lbl_Localidad.Name = "lbl_Localidad"
        Me.lbl_Localidad.Size = New System.Drawing.Size(77, 15)
        Me.lbl_Localidad.TabIndex = 25
        Me.lbl_Localidad.Text = "Localidad (*)"
        '
        'cb_CondicionIva
        '
        Me.cb_CondicionIva.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_CondicionIva.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_CondicionIva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_CondicionIva.FormattingEnabled = True
        Me.cb_CondicionIva.Location = New System.Drawing.Point(568, 178)
        Me.cb_CondicionIva.Name = "cb_CondicionIva"
        Me.cb_CondicionIva.Size = New System.Drawing.Size(164, 23)
        Me.cb_CondicionIva.TabIndex = 13
        '
        'cb_ListaPrecios
        '
        Me.cb_ListaPrecios.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_ListaPrecios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_ListaPrecios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_ListaPrecios.FormattingEnabled = True
        Me.cb_ListaPrecios.Location = New System.Drawing.Point(568, 147)
        Me.cb_ListaPrecios.Name = "cb_ListaPrecios"
        Me.cb_ListaPrecios.Size = New System.Drawing.Size(164, 23)
        Me.cb_ListaPrecios.TabIndex = 12
        '
        'lbl_CondicionIva
        '
        Me.lbl_CondicionIva.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_CondicionIva.AutoSize = True
        Me.lbl_CondicionIva.Location = New System.Drawing.Point(425, 185)
        Me.lbl_CondicionIva.Name = "lbl_CondicionIva"
        Me.lbl_CondicionIva.Size = New System.Drawing.Size(115, 15)
        Me.lbl_CondicionIva.TabIndex = 22
        Me.lbl_CondicionIva.Text = "Condición de IVA (*)"
        '
        'lbl_ListaPrecio
        '
        Me.lbl_ListaPrecio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_ListaPrecio.AutoSize = True
        Me.lbl_ListaPrecio.Location = New System.Drawing.Point(425, 147)
        Me.lbl_ListaPrecio.Name = "lbl_ListaPrecio"
        Me.lbl_ListaPrecio.Size = New System.Drawing.Size(110, 15)
        Me.lbl_ListaPrecio.TabIndex = 21
        Me.lbl_ListaPrecio.Text = "Lista de Precios (*)"
        '
        'txt_Observaciones
        '
        Me.txt_Observaciones.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Observaciones.Location = New System.Drawing.Point(428, 60)
        Me.txt_Observaciones.MaxLength = 255
        Me.txt_Observaciones.Multiline = True
        Me.txt_Observaciones.Name = "txt_Observaciones"
        Me.txt_Observaciones.Size = New System.Drawing.Size(304, 70)
        Me.txt_Observaciones.TabIndex = 10
        '
        'lbl_Observaciones
        '
        Me.lbl_Observaciones.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Observaciones.AutoSize = True
        Me.lbl_Observaciones.Location = New System.Drawing.Point(425, 42)
        Me.lbl_Observaciones.Name = "lbl_Observaciones"
        Me.lbl_Observaciones.Size = New System.Drawing.Size(88, 15)
        Me.lbl_Observaciones.TabIndex = 19
        Me.lbl_Observaciones.Text = "Observaciones"
        '
        'txt_Mail
        '
        Me.txt_Mail.Location = New System.Drawing.Point(152, 141)
        Me.txt_Mail.MaxLength = 255
        Me.txt_Mail.Name = "txt_Mail"
        Me.txt_Mail.Size = New System.Drawing.Size(208, 21)
        Me.txt_Mail.TabIndex = 4
        '
        'lbl_Mail
        '
        Me.lbl_Mail.AutoSize = True
        Me.lbl_Mail.Location = New System.Drawing.Point(5, 147)
        Me.lbl_Mail.Name = "lbl_Mail"
        Me.lbl_Mail.Size = New System.Drawing.Size(47, 15)
        Me.lbl_Mail.TabIndex = 17
        Me.lbl_Mail.Text = "Mail (*)"
        '
        'txt_Telefono
        '
        Me.txt_Telefono.Location = New System.Drawing.Point(151, 107)
        Me.txt_Telefono.MaxLength = 255
        Me.txt_Telefono.Name = "txt_Telefono"
        Me.txt_Telefono.Size = New System.Drawing.Size(209, 21)
        Me.txt_Telefono.TabIndex = 3
        '
        'lbl_Telefono
        '
        Me.lbl_Telefono.AutoSize = True
        Me.lbl_Telefono.Location = New System.Drawing.Point(5, 112)
        Me.lbl_Telefono.Name = "lbl_Telefono"
        Me.lbl_Telefono.Size = New System.Drawing.Size(55, 15)
        Me.lbl_Telefono.TabIndex = 15
        Me.lbl_Telefono.Text = "Teléfono"
        '
        'txt_CodigoPostal
        '
        Me.txt_CodigoPostal.Location = New System.Drawing.Point(153, 317)
        Me.txt_CodigoPostal.MaxLength = 255
        Me.txt_CodigoPostal.Name = "txt_CodigoPostal"
        Me.txt_CodigoPostal.Size = New System.Drawing.Size(207, 21)
        Me.txt_CodigoPostal.TabIndex = 9
        '
        'lbl_CodigoPostal
        '
        Me.lbl_CodigoPostal.AutoSize = True
        Me.lbl_CodigoPostal.Location = New System.Drawing.Point(5, 322)
        Me.lbl_CodigoPostal.Name = "lbl_CodigoPostal"
        Me.lbl_CodigoPostal.Size = New System.Drawing.Size(99, 15)
        Me.lbl_CodigoPostal.TabIndex = 13
        Me.lbl_CodigoPostal.Text = "Código Postal (*)"
        '
        'txt_Direccion
        '
        Me.txt_Direccion.Location = New System.Drawing.Point(153, 283)
        Me.txt_Direccion.MaxLength = 255
        Me.txt_Direccion.Name = "txt_Direccion"
        Me.txt_Direccion.Size = New System.Drawing.Size(207, 21)
        Me.txt_Direccion.TabIndex = 8
        '
        'lbl_Direccion
        '
        Me.lbl_Direccion.AutoSize = True
        Me.lbl_Direccion.Location = New System.Drawing.Point(5, 287)
        Me.lbl_Direccion.Name = "lbl_Direccion"
        Me.lbl_Direccion.Size = New System.Drawing.Size(75, 15)
        Me.lbl_Direccion.TabIndex = 11
        Me.lbl_Direccion.Text = "Direccion (*)"
        '
        'txt_Transporte
        '
        Me.txt_Transporte.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Transporte.Location = New System.Drawing.Point(568, 246)
        Me.txt_Transporte.MaxLength = 255
        Me.txt_Transporte.Name = "txt_Transporte"
        Me.txt_Transporte.Size = New System.Drawing.Size(164, 21)
        Me.txt_Transporte.TabIndex = 15
        '
        'lbl_Transporte
        '
        Me.lbl_Transporte.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Transporte.AutoSize = True
        Me.lbl_Transporte.Location = New System.Drawing.Point(425, 252)
        Me.lbl_Transporte.Name = "lbl_Transporte"
        Me.lbl_Transporte.Size = New System.Drawing.Size(66, 15)
        Me.lbl_Transporte.TabIndex = 9
        Me.lbl_Transporte.Text = "Transporte"
        '
        'lbl_Cuit
        '
        Me.lbl_Cuit.AutoSize = True
        Me.lbl_Cuit.Location = New System.Drawing.Point(5, 77)
        Me.lbl_Cuit.Name = "lbl_Cuit"
        Me.lbl_Cuit.Size = New System.Drawing.Size(44, 15)
        Me.lbl_Cuit.TabIndex = 7
        Me.lbl_Cuit.Text = "Cuit (*)"
        '
        'txt_Contacto
        '
        Me.txt_Contacto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Contacto.Location = New System.Drawing.Point(568, 214)
        Me.txt_Contacto.MaxLength = 255
        Me.txt_Contacto.Name = "txt_Contacto"
        Me.txt_Contacto.Size = New System.Drawing.Size(164, 21)
        Me.txt_Contacto.TabIndex = 14
        '
        'lbl_Contacto
        '
        Me.lbl_Contacto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Contacto.AutoSize = True
        Me.lbl_Contacto.Location = New System.Drawing.Point(425, 223)
        Me.lbl_Contacto.Name = "lbl_Contacto"
        Me.lbl_Contacto.Size = New System.Drawing.Size(55, 15)
        Me.lbl_Contacto.TabIndex = 5
        Me.lbl_Contacto.Text = "Contacto"
        '
        'chk_Habilitado
        '
        Me.chk_Habilitado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chk_Habilitado.AutoSize = True
        Me.chk_Habilitado.Checked = True
        Me.chk_Habilitado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Habilitado.Location = New System.Drawing.Point(568, 288)
        Me.chk_Habilitado.Name = "chk_Habilitado"
        Me.chk_Habilitado.Size = New System.Drawing.Size(15, 14)
        Me.chk_Habilitado.TabIndex = 11
        Me.chk_Habilitado.UseVisualStyleBackColor = True
        '
        'txt_RazonSocial
        '
        Me.txt_RazonSocial.Location = New System.Drawing.Point(152, 39)
        Me.txt_RazonSocial.MaxLength = 255
        Me.txt_RazonSocial.Name = "txt_RazonSocial"
        Me.txt_RazonSocial.Size = New System.Drawing.Size(208, 21)
        Me.txt_RazonSocial.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(425, 287)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Habilitado"
        '
        'lbl_RazonSocial
        '
        Me.lbl_RazonSocial.AutoSize = True
        Me.lbl_RazonSocial.Location = New System.Drawing.Point(5, 42)
        Me.lbl_RazonSocial.Name = "lbl_RazonSocial"
        Me.lbl_RazonSocial.Size = New System.Drawing.Size(96, 15)
        Me.lbl_RazonSocial.TabIndex = 1
        Me.lbl_RazonSocial.Text = "Razon Social (*)"
        '
        'Btn_Agregar
        '
        Me.Btn_Agregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Agregar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Agregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Agregar.Image = Global.SistemaCinderella.My.Resources.Recursos.Agregar_24
        Me.Btn_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Agregar.Location = New System.Drawing.Point(632, 368)
        Me.Btn_Agregar.Name = "Btn_Agregar"
        Me.Btn_Agregar.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Agregar.TabIndex = 16
        Me.Btn_Agregar.Text = "Agregar"
        Me.Btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Agregar.UseVisualStyleBackColor = False
        '
        'TbMod
        '
        Me.TbMod.Controls.Add(Me.GB_Modificacion)
        Me.TbMod.Location = New System.Drawing.Point(4, 29)
        Me.TbMod.Name = "TbMod"
        Me.TbMod.Size = New System.Drawing.Size(786, 439)
        Me.TbMod.TabIndex = 2
        Me.TbMod.Text = "Modificación de Cliente"
        Me.TbMod.UseVisualStyleBackColor = True
        '
        'GB_Modificacion
        '
        Me.GB_Modificacion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_Modificacion.Controls.Add(Me.txt_cuit_mod)
        Me.GB_Modificacion.Controls.Add(Me.Btn_Cancelar)
        Me.GB_Modificacion.Controls.Add(Me.Label18)
        Me.GB_Modificacion.Controls.Add(Me.Btn_Eliminar)
        Me.GB_Modificacion.Controls.Add(Me.cb_Localidad_mod)
        Me.GB_Modificacion.Controls.Add(Me.cb_Distrito_mod)
        Me.GB_Modificacion.Controls.Add(Me.cb_Provincia_mod)
        Me.GB_Modificacion.Controls.Add(Me.Label1)
        Me.GB_Modificacion.Controls.Add(Me.Label3)
        Me.GB_Modificacion.Controls.Add(Me.Label4)
        Me.GB_Modificacion.Controls.Add(Me.cb_CondicionIva_mod)
        Me.GB_Modificacion.Controls.Add(Me.cb_ListaPrecios_mod)
        Me.GB_Modificacion.Controls.Add(Me.Label5)
        Me.GB_Modificacion.Controls.Add(Me.Label6)
        Me.GB_Modificacion.Controls.Add(Me.txt_Observaciones_mod)
        Me.GB_Modificacion.Controls.Add(Me.Label7)
        Me.GB_Modificacion.Controls.Add(Me.txt_Mail_mod)
        Me.GB_Modificacion.Controls.Add(Me.Label8)
        Me.GB_Modificacion.Controls.Add(Me.txt_Telefono_mod)
        Me.GB_Modificacion.Controls.Add(Me.Label9)
        Me.GB_Modificacion.Controls.Add(Me.txt_CodigoPostal_mod)
        Me.GB_Modificacion.Controls.Add(Me.Label10)
        Me.GB_Modificacion.Controls.Add(Me.txt_Direccion_mod)
        Me.GB_Modificacion.Controls.Add(Me.Label11)
        Me.GB_Modificacion.Controls.Add(Me.txt_Transporte_mod)
        Me.GB_Modificacion.Controls.Add(Me.Label12)
        Me.GB_Modificacion.Controls.Add(Me.Label13)
        Me.GB_Modificacion.Controls.Add(Me.txt_Contacto_mod)
        Me.GB_Modificacion.Controls.Add(Me.Label14)
        Me.GB_Modificacion.Controls.Add(Me.chk_Habilitado_mod)
        Me.GB_Modificacion.Controls.Add(Me.txt_RazonSocial_mod)
        Me.GB_Modificacion.Controls.Add(Me.Label15)
        Me.GB_Modificacion.Controls.Add(Me.Label16)
        Me.GB_Modificacion.Controls.Add(Me.Btn_Modificar)
        Me.GB_Modificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Modificacion.Location = New System.Drawing.Point(10, 6)
        Me.GB_Modificacion.Name = "GB_Modificacion"
        Me.GB_Modificacion.Size = New System.Drawing.Size(770, 425)
        Me.GB_Modificacion.TabIndex = 1
        Me.GB_Modificacion.TabStop = False
        Me.GB_Modificacion.Text = "Formulario de Modificación"
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Cancelar.Image = Global.SistemaCinderella.My.Resources.Recursos.desconectado_32
        Me.Btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Cancelar.Location = New System.Drawing.Point(420, 368)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Cancelar.TabIndex = 81
        Me.Btn_Cancelar.Text = "Cancelar"
        Me.Btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolCliente.SetToolTip(Me.Btn_Cancelar, "Descarta los cambios y vuelve al listado de clientes")
        Me.Btn_Cancelar.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(6, 383)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(117, 13)
        Me.Label18.TabIndex = 69
        Me.Label18.Text = "(*) Campos obligatorios."
        '
        'Btn_Eliminar
        '
        Me.Btn_Eliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Eliminar.Image = Global.SistemaCinderella.My.Resources.Recursos.Limpiar_32
        Me.Btn_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Eliminar.Location = New System.Drawing.Point(526, 368)
        Me.Btn_Eliminar.Name = "Btn_Eliminar"
        Me.Btn_Eliminar.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Eliminar.TabIndex = 16
        Me.Btn_Eliminar.Text = "Eliminar"
        Me.Btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Eliminar.UseVisualStyleBackColor = True
        '
        'cb_Localidad_mod
        '
        Me.cb_Localidad_mod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_Localidad_mod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Localidad_mod.FormattingEnabled = True
        Me.cb_Localidad_mod.Location = New System.Drawing.Point(152, 247)
        Me.cb_Localidad_mod.Name = "cb_Localidad_mod"
        Me.cb_Localidad_mod.Size = New System.Drawing.Size(208, 23)
        Me.cb_Localidad_mod.TabIndex = 7
        '
        'cb_Distrito_mod
        '
        Me.cb_Distrito_mod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_Distrito_mod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Distrito_mod.FormattingEnabled = True
        Me.cb_Distrito_mod.Location = New System.Drawing.Point(151, 211)
        Me.cb_Distrito_mod.Name = "cb_Distrito_mod"
        Me.cb_Distrito_mod.Size = New System.Drawing.Size(209, 23)
        Me.cb_Distrito_mod.TabIndex = 6
        '
        'cb_Provincia_mod
        '
        Me.cb_Provincia_mod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_Provincia_mod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Provincia_mod.FormattingEnabled = True
        Me.cb_Provincia_mod.Location = New System.Drawing.Point(151, 175)
        Me.cb_Provincia_mod.Name = "cb_Provincia_mod"
        Me.cb_Provincia_mod.Size = New System.Drawing.Size(209, 23)
        Me.cb_Provincia_mod.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 182)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 15)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Provincia (*)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 217)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 15)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Distrito (*)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 252)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 15)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Localidad (*)"
        '
        'cb_CondicionIva_mod
        '
        Me.cb_CondicionIva_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_CondicionIva_mod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_CondicionIva_mod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_CondicionIva_mod.FormattingEnabled = True
        Me.cb_CondicionIva_mod.Location = New System.Drawing.Point(568, 178)
        Me.cb_CondicionIva_mod.Name = "cb_CondicionIva_mod"
        Me.cb_CondicionIva_mod.Size = New System.Drawing.Size(164, 23)
        Me.cb_CondicionIva_mod.TabIndex = 13
        '
        'cb_ListaPrecios_mod
        '
        Me.cb_ListaPrecios_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_ListaPrecios_mod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_ListaPrecios_mod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_ListaPrecios_mod.FormattingEnabled = True
        Me.cb_ListaPrecios_mod.Location = New System.Drawing.Point(568, 147)
        Me.cb_ListaPrecios_mod.Name = "cb_ListaPrecios_mod"
        Me.cb_ListaPrecios_mod.Size = New System.Drawing.Size(164, 23)
        Me.cb_ListaPrecios_mod.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(425, 185)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 15)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "Condición de IVA (*)"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(425, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 15)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "Lista de Precios (*)"
        '
        'txt_Observaciones_mod
        '
        Me.txt_Observaciones_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Observaciones_mod.Location = New System.Drawing.Point(428, 60)
        Me.txt_Observaciones_mod.MaxLength = 255
        Me.txt_Observaciones_mod.Multiline = True
        Me.txt_Observaciones_mod.Name = "txt_Observaciones_mod"
        Me.txt_Observaciones_mod.Size = New System.Drawing.Size(304, 70)
        Me.txt_Observaciones_mod.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(425, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 15)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Observaciones"
        '
        'txt_Mail_mod
        '
        Me.txt_Mail_mod.Location = New System.Drawing.Point(152, 141)
        Me.txt_Mail_mod.MaxLength = 255
        Me.txt_Mail_mod.Name = "txt_Mail_mod"
        Me.txt_Mail_mod.Size = New System.Drawing.Size(208, 21)
        Me.txt_Mail_mod.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(5, 147)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 15)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "Mail (*)"
        '
        'txt_Telefono_mod
        '
        Me.txt_Telefono_mod.Location = New System.Drawing.Point(151, 107)
        Me.txt_Telefono_mod.MaxLength = 255
        Me.txt_Telefono_mod.Name = "txt_Telefono_mod"
        Me.txt_Telefono_mod.Size = New System.Drawing.Size(209, 21)
        Me.txt_Telefono_mod.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(5, 112)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 15)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "Teléfono"
        '
        'txt_CodigoPostal_mod
        '
        Me.txt_CodigoPostal_mod.Location = New System.Drawing.Point(153, 317)
        Me.txt_CodigoPostal_mod.MaxLength = 255
        Me.txt_CodigoPostal_mod.Name = "txt_CodigoPostal_mod"
        Me.txt_CodigoPostal_mod.Size = New System.Drawing.Size(207, 21)
        Me.txt_CodigoPostal_mod.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(5, 322)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 15)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Código Postal (*)"
        '
        'txt_Direccion_mod
        '
        Me.txt_Direccion_mod.Location = New System.Drawing.Point(153, 283)
        Me.txt_Direccion_mod.MaxLength = 255
        Me.txt_Direccion_mod.Name = "txt_Direccion_mod"
        Me.txt_Direccion_mod.Size = New System.Drawing.Size(207, 21)
        Me.txt_Direccion_mod.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(5, 287)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 15)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "Direccion (*)"
        '
        'txt_Transporte_mod
        '
        Me.txt_Transporte_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Transporte_mod.Location = New System.Drawing.Point(568, 246)
        Me.txt_Transporte_mod.MaxLength = 255
        Me.txt_Transporte_mod.Name = "txt_Transporte_mod"
        Me.txt_Transporte_mod.Size = New System.Drawing.Size(164, 21)
        Me.txt_Transporte_mod.TabIndex = 15
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(425, 252)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 15)
        Me.Label12.TabIndex = 40
        Me.Label12.Text = "Transporte"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(5, 77)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(44, 15)
        Me.Label13.TabIndex = 38
        Me.Label13.Text = "Cuit (*)"
        '
        'txt_Contacto_mod
        '
        Me.txt_Contacto_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Contacto_mod.Location = New System.Drawing.Point(568, 214)
        Me.txt_Contacto_mod.MaxLength = 255
        Me.txt_Contacto_mod.Name = "txt_Contacto_mod"
        Me.txt_Contacto_mod.Size = New System.Drawing.Size(164, 21)
        Me.txt_Contacto_mod.TabIndex = 14
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(425, 223)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(55, 15)
        Me.Label14.TabIndex = 35
        Me.Label14.Text = "Contacto"
        '
        'chk_Habilitado_mod
        '
        Me.chk_Habilitado_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chk_Habilitado_mod.AutoSize = True
        Me.chk_Habilitado_mod.Checked = True
        Me.chk_Habilitado_mod.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Habilitado_mod.Location = New System.Drawing.Point(568, 288)
        Me.chk_Habilitado_mod.Name = "chk_Habilitado_mod"
        Me.chk_Habilitado_mod.Size = New System.Drawing.Size(15, 14)
        Me.chk_Habilitado_mod.TabIndex = 11
        Me.chk_Habilitado_mod.UseVisualStyleBackColor = True
        '
        'txt_RazonSocial_mod
        '
        Me.txt_RazonSocial_mod.Location = New System.Drawing.Point(152, 39)
        Me.txt_RazonSocial_mod.MaxLength = 255
        Me.txt_RazonSocial_mod.Name = "txt_RazonSocial_mod"
        Me.txt_RazonSocial_mod.Size = New System.Drawing.Size(208, 21)
        Me.txt_RazonSocial_mod.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(425, 287)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(63, 15)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "Habilitado"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(5, 42)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(96, 15)
        Me.Label16.TabIndex = 29
        Me.Label16.Text = "Razon Social (*)"
        '
        'Btn_Modificar
        '
        Me.Btn_Modificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Modificar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Modificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Modificar.Image = Global.SistemaCinderella.My.Resources.Recursos.Editar_24
        Me.Btn_Modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Modificar.Location = New System.Drawing.Point(632, 368)
        Me.Btn_Modificar.Name = "Btn_Modificar"
        Me.Btn_Modificar.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Modificar.TabIndex = 17
        Me.Btn_Modificar.Text = "Modificar"
        Me.Btn_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'ErroresClie
        '
        Me.ErroresClie.BlinkRate = 200
        Me.ErroresClie.ContainerControl = Me
        '
        'ToolCliente
        '
        Me.ToolCliente.IsBalloon = True
        Me.ToolCliente.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolCliente.ToolTipTitle = "Ayuda."
        '
        'txt_Cuit
        '
        Me.txt_Cuit.Location = New System.Drawing.Point(151, 71)
        Me.txt_Cuit.Mask = "99-99999999-9"
        Me.txt_Cuit.Name = "txt_Cuit"
        Me.txt_Cuit.Size = New System.Drawing.Size(209, 21)
        Me.txt_Cuit.TabIndex = 2
        '
        'txt_cuit_mod
        '
        Me.txt_cuit_mod.Location = New System.Drawing.Point(151, 71)
        Me.txt_cuit_mod.Mask = "99-99999999-9"
        Me.txt_cuit_mod.Name = "txt_cuit_mod"
        Me.txt_cuit_mod.Size = New System.Drawing.Size(209, 21)
        Me.txt_cuit_mod.TabIndex = 2
        '
        'frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 472)
        Me.Controls.Add(Me.TabClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administración de Clientes"
        Me.TabClientes.ResumeLayout(False)
        Me.TbListado.ResumeLayout(False)
        Me.GB_Buscar.ResumeLayout(False)
        Me.GB_Buscar.PerformLayout()
        CType(Me.DG_Clientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TbAlta.ResumeLayout(False)
        Me.GB_Alta.ResumeLayout(False)
        Me.GB_Alta.PerformLayout()
        Me.TbMod.ResumeLayout(False)
        Me.GB_Modificacion.ResumeLayout(False)
        Me.GB_Modificacion.PerformLayout()
        CType(Me.ErroresClie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabClientes As System.Windows.Forms.TabControl
    Friend WithEvents TbListado As System.Windows.Forms.TabPage
    Friend WithEvents DG_Clientes As System.Windows.Forms.DataGridView
    Friend WithEvents TbAlta As System.Windows.Forms.TabPage
    Friend WithEvents GB_Alta As System.Windows.Forms.GroupBox
    Friend WithEvents chk_Habilitado As System.Windows.Forms.CheckBox
    Friend WithEvents txt_RazonSocial As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_RazonSocial As System.Windows.Forms.Label
    Friend WithEvents Btn_Agregar As System.Windows.Forms.Button
    Friend WithEvents TbMod As System.Windows.Forms.TabPage
    Friend WithEvents GB_Modificacion As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_Modificar As System.Windows.Forms.Button
    Friend WithEvents GB_Buscar As System.Windows.Forms.GroupBox
    Friend WithEvents txt_buscar As System.Windows.Forms.TextBox
    Friend WithEvents lbl_descripcion_bus As System.Windows.Forms.Label
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents txt_CodigoPostal As System.Windows.Forms.TextBox
    Friend WithEvents lbl_CodigoPostal As System.Windows.Forms.Label
    Friend WithEvents txt_Direccion As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Direccion As System.Windows.Forms.Label
    Friend WithEvents txt_Transporte As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Transporte As System.Windows.Forms.Label
    Friend WithEvents lbl_Cuit As System.Windows.Forms.Label
    Friend WithEvents txt_Contacto As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Contacto As System.Windows.Forms.Label
    Friend WithEvents txt_Observaciones As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Observaciones As System.Windows.Forms.Label
    Friend WithEvents txt_Mail As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Mail As System.Windows.Forms.Label
    Friend WithEvents txt_Telefono As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Telefono As System.Windows.Forms.Label
    Friend WithEvents cb_Localidad As System.Windows.Forms.ComboBox
    Friend WithEvents cb_Distrito As System.Windows.Forms.ComboBox
    Friend WithEvents cb_Provincia As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_Provincia As System.Windows.Forms.Label
    Friend WithEvents lbl_Distrito As System.Windows.Forms.Label
    Friend WithEvents lbl_Localidad As System.Windows.Forms.Label
    Friend WithEvents cb_CondicionIva As System.Windows.Forms.ComboBox
    Friend WithEvents cb_ListaPrecios As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_CondicionIva As System.Windows.Forms.Label
    Friend WithEvents lbl_ListaPrecio As System.Windows.Forms.Label
    Friend WithEvents ErroresClie As System.Windows.Forms.ErrorProvider
    Friend WithEvents cb_Localidad_mod As System.Windows.Forms.ComboBox
    Friend WithEvents cb_Distrito_mod As System.Windows.Forms.ComboBox
    Friend WithEvents cb_Provincia_mod As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cb_CondicionIva_mod As System.Windows.Forms.ComboBox
    Friend WithEvents cb_ListaPrecios_mod As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_Observaciones_mod As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_Mail_mod As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_Telefono_mod As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_CodigoPostal_mod As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_Direccion_mod As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_Transporte_mod As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_Contacto_mod As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents chk_Habilitado_mod As System.Windows.Forms.CheckBox
    Friend WithEvents txt_RazonSocial_mod As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents Btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents btn_Restablecer As System.Windows.Forms.Button
    Friend WithEvents id_Cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RazonSocial As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cuit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Telefono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Direccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Mail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ListaPrecio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Habilitado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Modificar As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Compras As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents ToolCliente As System.Windows.Forms.ToolTip
    Friend WithEvents Btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents txt_Cuit As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_cuit_mod As System.Windows.Forms.MaskedTextBox
End Class
