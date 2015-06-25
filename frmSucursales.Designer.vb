<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSucursales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSucursales))
        Me.TabSucursales = New System.Windows.Forms.TabControl()
        Me.TbListado = New System.Windows.Forms.TabPage()
        Me.DG_Sucursales = New System.Windows.Forms.DataGridView()
        Me.id_Sucursal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Habilitado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Modificar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Eliminar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TbAlta = New System.Windows.Forms.TabPage()
        Me.GB_Alta = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_ComisionEncargadoMayor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_ComisionVendedorMayor = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GB_Sucursal = New System.Windows.Forms.GroupBox()
        Me.lbl_Nombre = New System.Windows.Forms.Label()
        Me.lbl_Habilitado = New System.Windows.Forms.Label()
        Me.txt_Nombre = New System.Windows.Forms.TextBox()
        Me.cb_Localidad = New System.Windows.Forms.ComboBox()
        Me.chk_Habilitado = New System.Windows.Forms.CheckBox()
        Me.cb_Distrito = New System.Windows.Forms.ComboBox()
        Me.lbl_Direccion = New System.Windows.Forms.Label()
        Me.cb_Provincia = New System.Windows.Forms.ComboBox()
        Me.txt_Direccion = New System.Windows.Forms.TextBox()
        Me.lbl_Provincia = New System.Windows.Forms.Label()
        Me.lbl_CodigoPostal = New System.Windows.Forms.Label()
        Me.lbl_Distrito = New System.Windows.Forms.Label()
        Me.txt_CodigoPostal = New System.Windows.Forms.TextBox()
        Me.lbl_Localidad = New System.Windows.Forms.Label()
        Me.lbl_Telefono = New System.Windows.Forms.Label()
        Me.txt_Telefono = New System.Windows.Forms.TextBox()
        Me.GB_Comisiones2 = New System.Windows.Forms.GroupBox()
        Me.txt_ComisionEncargadoFeriado = New System.Windows.Forms.TextBox()
        Me.lbl_ComisionVendedorFeriado = New System.Windows.Forms.Label()
        Me.txt_ComisionVendedorFeriado = New System.Windows.Forms.TextBox()
        Me.lbl_ComisionEncargadoFeriado = New System.Windows.Forms.Label()
        Me.GB_Comisiones = New System.Windows.Forms.GroupBox()
        Me.txt_ComisionEncargado = New System.Windows.Forms.TextBox()
        Me.txt_ComisionVendedor = New System.Windows.Forms.TextBox()
        Me.lbl_ComisionEncargado = New System.Windows.Forms.Label()
        Me.lbl_ComisionVendedor = New System.Windows.Forms.Label()
        Me.Btn_Agregar = New System.Windows.Forms.Button()
        Me.TbMod = New System.Windows.Forms.TabPage()
        Me.GB_Modificacion = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_ComisionEncargadoMayor_mod = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_ComisionVendedorMayor_mod = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GB_Sucursal_mod = New System.Windows.Forms.GroupBox()
        Me.lbl_Nombre_mod = New System.Windows.Forms.Label()
        Me.lbl_Habilitado_mod = New System.Windows.Forms.Label()
        Me.txt_Nombre_mod = New System.Windows.Forms.TextBox()
        Me.chk_Habilitado_mod = New System.Windows.Forms.CheckBox()
        Me.cb_Localidad_mod = New System.Windows.Forms.ComboBox()
        Me.lbl_Direccion_mod = New System.Windows.Forms.Label()
        Me.cb_Distrito_mod = New System.Windows.Forms.ComboBox()
        Me.txt_Direccion_mod = New System.Windows.Forms.TextBox()
        Me.cb_Provincia_mod = New System.Windows.Forms.ComboBox()
        Me.lbl_CodigoPostal_mod = New System.Windows.Forms.Label()
        Me.lbl_Provincia_mod = New System.Windows.Forms.Label()
        Me.txt_CodigoPostal_mod = New System.Windows.Forms.TextBox()
        Me.lbl_Distrito_mod = New System.Windows.Forms.Label()
        Me.lbl_Telefono_mod = New System.Windows.Forms.Label()
        Me.lbl_Localidad_mod = New System.Windows.Forms.Label()
        Me.txt_Telefono_mod = New System.Windows.Forms.TextBox()
        Me.GB_Comisiones2_mod = New System.Windows.Forms.GroupBox()
        Me.lbl_ComisionEncargadoFeriado_mod = New System.Windows.Forms.Label()
        Me.txt_ComisionVendedorFeriado_mod = New System.Windows.Forms.TextBox()
        Me.lbl_ComisionVendedorFeriado_mod = New System.Windows.Forms.Label()
        Me.txt_ComisionEncargadoFeriado_mod = New System.Windows.Forms.TextBox()
        Me.GB_Comisiones_mod = New System.Windows.Forms.GroupBox()
        Me.lbl_ComisionEncargado_mod = New System.Windows.Forms.Label()
        Me.txt_ComisionVendedor_mod = New System.Windows.Forms.TextBox()
        Me.lbl_ComisionVendedor_mod = New System.Windows.Forms.Label()
        Me.txt_ComisionEncargado_mod = New System.Windows.Forms.TextBox()
        Me.Btn_Eliminar = New System.Windows.Forms.Button()
        Me.Btn_Modificar = New System.Windows.Forms.Button()
        Me.ErroresSucursal = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolSucursal = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabSucursales.SuspendLayout()
        Me.TbListado.SuspendLayout()
        CType(Me.DG_Sucursales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TbAlta.SuspendLayout()
        Me.GB_Alta.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GB_Sucursal.SuspendLayout()
        Me.GB_Comisiones2.SuspendLayout()
        Me.GB_Comisiones.SuspendLayout()
        Me.TbMod.SuspendLayout()
        Me.GB_Modificacion.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GB_Sucursal_mod.SuspendLayout()
        Me.GB_Comisiones2_mod.SuspendLayout()
        Me.GB_Comisiones_mod.SuspendLayout()
        CType(Me.ErroresSucursal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabSucursales
        '
        Me.TabSucursales.Controls.Add(Me.TbListado)
        Me.TabSucursales.Controls.Add(Me.TbAlta)
        Me.TabSucursales.Controls.Add(Me.TbMod)
        Me.TabSucursales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabSucursales.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabSucursales.Location = New System.Drawing.Point(0, 0)
        Me.TabSucursales.Name = "TabSucursales"
        Me.TabSucursales.SelectedIndex = 0
        Me.TabSucursales.Size = New System.Drawing.Size(794, 522)
        Me.TabSucursales.TabIndex = 2
        '
        'TbListado
        '
        Me.TbListado.Controls.Add(Me.DG_Sucursales)
        Me.TbListado.Location = New System.Drawing.Point(4, 29)
        Me.TbListado.Name = "TbListado"
        Me.TbListado.Padding = New System.Windows.Forms.Padding(3)
        Me.TbListado.Size = New System.Drawing.Size(786, 489)
        Me.TbListado.TabIndex = 0
        Me.TbListado.Text = "Sucursales"
        Me.TbListado.UseVisualStyleBackColor = True
        '
        'DG_Sucursales
        '
        Me.DG_Sucursales.AllowUserToAddRows = False
        Me.DG_Sucursales.AllowUserToDeleteRows = False
        Me.DG_Sucursales.AllowUserToResizeColumns = False
        Me.DG_Sucursales.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DG_Sucursales.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DG_Sucursales.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_Sucursales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_Sucursales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_Sucursal, Me.Nombre, Me.Direccion, Me.Telefono, Me.Habilitado, Me.Modificar, Me.Eliminar})
        Me.DG_Sucursales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DG_Sucursales.Location = New System.Drawing.Point(9, 7)
        Me.DG_Sucursales.MultiSelect = False
        Me.DG_Sucursales.Name = "DG_Sucursales"
        Me.DG_Sucursales.ReadOnly = True
        Me.DG_Sucursales.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DG_Sucursales.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DG_Sucursales.RowTemplate.Height = 30
        Me.DG_Sucursales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Sucursales.Size = New System.Drawing.Size(766, 454)
        Me.DG_Sucursales.TabIndex = 0
        '
        'id_Sucursal
        '
        Me.id_Sucursal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.id_Sucursal.DataPropertyName = "id_Sucursal"
        Me.id_Sucursal.HeaderText = "ID"
        Me.id_Sucursal.MaxInputLength = 10
        Me.id_Sucursal.Name = "id_Sucursal"
        Me.id_Sucursal.ReadOnly = True
        Me.id_Sucursal.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.id_Sucursal.Width = 51
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.FillWeight = 172.4676!
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Direccion
        '
        Me.Direccion.DataPropertyName = "Direccion"
        Me.Direccion.FillWeight = 141.4971!
        Me.Direccion.HeaderText = "Dirección"
        Me.Direccion.Name = "Direccion"
        Me.Direccion.ReadOnly = True
        '
        'Telefono
        '
        Me.Telefono.DataPropertyName = "Telefono"
        Me.Telefono.FillWeight = 124.3305!
        Me.Telefono.HeaderText = "Teléfono"
        Me.Telefono.Name = "Telefono"
        Me.Telefono.ReadOnly = True
        '
        'Habilitado
        '
        Me.Habilitado.DataPropertyName = "estado"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Habilitado.DefaultCellStyle = DataGridViewCellStyle2
        Me.Habilitado.FillWeight = 54.33104!
        Me.Habilitado.HeaderText = "Habilitado"
        Me.Habilitado.MaxInputLength = 10
        Me.Habilitado.Name = "Habilitado"
        Me.Habilitado.ReadOnly = True
        Me.Habilitado.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Modificar
        '
        Me.Modificar.FillWeight = 52.82832!
        Me.Modificar.HeaderText = "Modificar"
        Me.Modificar.Image = Global.SistemaCinderella.My.Resources.Recursos.Boton_Editar
        Me.Modificar.Name = "Modificar"
        Me.Modificar.ReadOnly = True
        Me.Modificar.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Modificar.ToolTipText = "Modificar Sucursal"
        '
        'Eliminar
        '
        Me.Eliminar.FillWeight = 54.54546!
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Image = Global.SistemaCinderella.My.Resources.Recursos.Boton_Eliminar
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Eliminar.ToolTipText = "Eliminar Sucursal"
        '
        'TbAlta
        '
        Me.TbAlta.Controls.Add(Me.GB_Alta)
        Me.TbAlta.Location = New System.Drawing.Point(4, 29)
        Me.TbAlta.Name = "TbAlta"
        Me.TbAlta.Padding = New System.Windows.Forms.Padding(3)
        Me.TbAlta.Size = New System.Drawing.Size(786, 489)
        Me.TbAlta.TabIndex = 1
        Me.TbAlta.Text = "Alta de Sucursal"
        Me.TbAlta.UseVisualStyleBackColor = True
        '
        'GB_Alta
        '
        Me.GB_Alta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_Alta.Controls.Add(Me.GroupBox1)
        Me.GB_Alta.Controls.Add(Me.Label1)
        Me.GB_Alta.Controls.Add(Me.GB_Sucursal)
        Me.GB_Alta.Controls.Add(Me.GB_Comisiones2)
        Me.GB_Alta.Controls.Add(Me.GB_Comisiones)
        Me.GB_Alta.Controls.Add(Me.Btn_Agregar)
        Me.GB_Alta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Alta.Location = New System.Drawing.Point(12, 7)
        Me.GB_Alta.Name = "GB_Alta"
        Me.GB_Alta.Size = New System.Drawing.Size(764, 465)
        Me.GB_Alta.TabIndex = 0
        Me.GB_Alta.TabStop = False
        Me.GB_Alta.Text = "Formulario de alta de sucursal."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_ComisionEncargadoMayor)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_ComisionVendedorMayor)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(443, 276)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(300, 115)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Comisiones Ventas Mayoristas"
        '
        'txt_ComisionEncargadoMayor
        '
        Me.txt_ComisionEncargadoMayor.Location = New System.Drawing.Point(152, 68)
        Me.txt_ComisionEncargadoMayor.Name = "txt_ComisionEncargadoMayor"
        Me.txt_ComisionEncargadoMayor.Size = New System.Drawing.Size(128, 20)
        Me.txt_ComisionEncargadoMayor.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Comisión Vendedor (*)"
        '
        'txt_ComisionVendedorMayor
        '
        Me.txt_ComisionVendedorMayor.Location = New System.Drawing.Point(152, 30)
        Me.txt_ComisionVendedorMayor.Name = "txt_ComisionVendedorMayor"
        Me.txt_ComisionVendedorMayor.Size = New System.Drawing.Size(128, 20)
        Me.txt_ComisionVendedorMayor.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Comisión Encargado (*)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(309, 399)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "(*) Campos obligatorios."
        '
        'GB_Sucursal
        '
        Me.GB_Sucursal.Controls.Add(Me.lbl_Nombre)
        Me.GB_Sucursal.Controls.Add(Me.lbl_Habilitado)
        Me.GB_Sucursal.Controls.Add(Me.txt_Nombre)
        Me.GB_Sucursal.Controls.Add(Me.cb_Localidad)
        Me.GB_Sucursal.Controls.Add(Me.chk_Habilitado)
        Me.GB_Sucursal.Controls.Add(Me.cb_Distrito)
        Me.GB_Sucursal.Controls.Add(Me.lbl_Direccion)
        Me.GB_Sucursal.Controls.Add(Me.cb_Provincia)
        Me.GB_Sucursal.Controls.Add(Me.txt_Direccion)
        Me.GB_Sucursal.Controls.Add(Me.lbl_Provincia)
        Me.GB_Sucursal.Controls.Add(Me.lbl_CodigoPostal)
        Me.GB_Sucursal.Controls.Add(Me.lbl_Distrito)
        Me.GB_Sucursal.Controls.Add(Me.txt_CodigoPostal)
        Me.GB_Sucursal.Controls.Add(Me.lbl_Localidad)
        Me.GB_Sucursal.Controls.Add(Me.lbl_Telefono)
        Me.GB_Sucursal.Controls.Add(Me.txt_Telefono)
        Me.GB_Sucursal.Location = New System.Drawing.Point(14, 34)
        Me.GB_Sucursal.Name = "GB_Sucursal"
        Me.GB_Sucursal.Size = New System.Drawing.Size(412, 351)
        Me.GB_Sucursal.TabIndex = 1
        Me.GB_Sucursal.TabStop = False
        Me.GB_Sucursal.Text = "Información del Establecimiento"
        '
        'lbl_Nombre
        '
        Me.lbl_Nombre.AutoSize = True
        Me.lbl_Nombre.Location = New System.Drawing.Point(7, 39)
        Me.lbl_Nombre.Name = "lbl_Nombre"
        Me.lbl_Nombre.Size = New System.Drawing.Size(57, 13)
        Me.lbl_Nombre.TabIndex = 1
        Me.lbl_Nombre.Text = "Nombre (*)"
        '
        'lbl_Habilitado
        '
        Me.lbl_Habilitado.AutoSize = True
        Me.lbl_Habilitado.Location = New System.Drawing.Point(7, 302)
        Me.lbl_Habilitado.Name = "lbl_Habilitado"
        Me.lbl_Habilitado.Size = New System.Drawing.Size(54, 13)
        Me.lbl_Habilitado.TabIndex = 2
        Me.lbl_Habilitado.Text = "Habilitado"
        '
        'txt_Nombre
        '
        Me.txt_Nombre.Location = New System.Drawing.Point(139, 31)
        Me.txt_Nombre.MaxLength = 255
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.Size = New System.Drawing.Size(242, 20)
        Me.txt_Nombre.TabIndex = 2
        '
        'cb_Localidad
        '
        Me.cb_Localidad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_Localidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Localidad.FormattingEnabled = True
        Me.cb_Localidad.Location = New System.Drawing.Point(138, 186)
        Me.cb_Localidad.Name = "cb_Localidad"
        Me.cb_Localidad.Size = New System.Drawing.Size(242, 21)
        Me.cb_Localidad.TabIndex = 6
        '
        'chk_Habilitado
        '
        Me.chk_Habilitado.AutoSize = True
        Me.chk_Habilitado.Checked = True
        Me.chk_Habilitado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Habilitado.Location = New System.Drawing.Point(139, 301)
        Me.chk_Habilitado.Name = "chk_Habilitado"
        Me.chk_Habilitado.Size = New System.Drawing.Size(15, 14)
        Me.chk_Habilitado.TabIndex = 9
        Me.chk_Habilitado.UseVisualStyleBackColor = True
        '
        'cb_Distrito
        '
        Me.cb_Distrito.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_Distrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Distrito.FormattingEnabled = True
        Me.cb_Distrito.Location = New System.Drawing.Point(138, 147)
        Me.cb_Distrito.Name = "cb_Distrito"
        Me.cb_Distrito.Size = New System.Drawing.Size(242, 21)
        Me.cb_Distrito.TabIndex = 5
        '
        'lbl_Direccion
        '
        Me.lbl_Direccion.AutoSize = True
        Me.lbl_Direccion.Location = New System.Drawing.Point(7, 233)
        Me.lbl_Direccion.Name = "lbl_Direccion"
        Me.lbl_Direccion.Size = New System.Drawing.Size(65, 13)
        Me.lbl_Direccion.TabIndex = 11
        Me.lbl_Direccion.Text = "Direccion (*)"
        '
        'cb_Provincia
        '
        Me.cb_Provincia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_Provincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Provincia.FormattingEnabled = True
        Me.cb_Provincia.Location = New System.Drawing.Point(139, 107)
        Me.cb_Provincia.Name = "cb_Provincia"
        Me.cb_Provincia.Size = New System.Drawing.Size(242, 21)
        Me.cb_Provincia.TabIndex = 4
        '
        'txt_Direccion
        '
        Me.txt_Direccion.Location = New System.Drawing.Point(138, 225)
        Me.txt_Direccion.MaxLength = 255
        Me.txt_Direccion.Name = "txt_Direccion"
        Me.txt_Direccion.Size = New System.Drawing.Size(241, 20)
        Me.txt_Direccion.TabIndex = 6
        '
        'lbl_Provincia
        '
        Me.lbl_Provincia.AutoSize = True
        Me.lbl_Provincia.Location = New System.Drawing.Point(7, 117)
        Me.lbl_Provincia.Name = "lbl_Provincia"
        Me.lbl_Provincia.Size = New System.Drawing.Size(64, 13)
        Me.lbl_Provincia.TabIndex = 27
        Me.lbl_Provincia.Text = "Provincia (*)"
        '
        'lbl_CodigoPostal
        '
        Me.lbl_CodigoPostal.AutoSize = True
        Me.lbl_CodigoPostal.Location = New System.Drawing.Point(7, 271)
        Me.lbl_CodigoPostal.Name = "lbl_CodigoPostal"
        Me.lbl_CodigoPostal.Size = New System.Drawing.Size(85, 13)
        Me.lbl_CodigoPostal.TabIndex = 13
        Me.lbl_CodigoPostal.Text = "Código Postal (*)"
        '
        'lbl_Distrito
        '
        Me.lbl_Distrito.AutoSize = True
        Me.lbl_Distrito.Location = New System.Drawing.Point(7, 156)
        Me.lbl_Distrito.Name = "lbl_Distrito"
        Me.lbl_Distrito.Size = New System.Drawing.Size(53, 13)
        Me.lbl_Distrito.TabIndex = 26
        Me.lbl_Distrito.Text = "Partido (*)"
        '
        'txt_CodigoPostal
        '
        Me.txt_CodigoPostal.Location = New System.Drawing.Point(138, 263)
        Me.txt_CodigoPostal.MaxLength = 255
        Me.txt_CodigoPostal.Name = "txt_CodigoPostal"
        Me.txt_CodigoPostal.Size = New System.Drawing.Size(241, 20)
        Me.txt_CodigoPostal.TabIndex = 8
        '
        'lbl_Localidad
        '
        Me.lbl_Localidad.AutoSize = True
        Me.lbl_Localidad.Location = New System.Drawing.Point(7, 195)
        Me.lbl_Localidad.Name = "lbl_Localidad"
        Me.lbl_Localidad.Size = New System.Drawing.Size(66, 13)
        Me.lbl_Localidad.TabIndex = 25
        Me.lbl_Localidad.Text = "Localidad (*)"
        '
        'lbl_Telefono
        '
        Me.lbl_Telefono.AutoSize = True
        Me.lbl_Telefono.Location = New System.Drawing.Point(7, 77)
        Me.lbl_Telefono.Name = "lbl_Telefono"
        Me.lbl_Telefono.Size = New System.Drawing.Size(49, 13)
        Me.lbl_Telefono.TabIndex = 15
        Me.lbl_Telefono.Text = "Teléfono"
        '
        'txt_Telefono
        '
        Me.txt_Telefono.Location = New System.Drawing.Point(139, 69)
        Me.txt_Telefono.MaxLength = 255
        Me.txt_Telefono.Name = "txt_Telefono"
        Me.txt_Telefono.Size = New System.Drawing.Size(242, 20)
        Me.txt_Telefono.TabIndex = 3
        '
        'GB_Comisiones2
        '
        Me.GB_Comisiones2.Controls.Add(Me.txt_ComisionEncargadoFeriado)
        Me.GB_Comisiones2.Controls.Add(Me.lbl_ComisionVendedorFeriado)
        Me.GB_Comisiones2.Controls.Add(Me.txt_ComisionVendedorFeriado)
        Me.GB_Comisiones2.Controls.Add(Me.lbl_ComisionEncargadoFeriado)
        Me.GB_Comisiones2.Location = New System.Drawing.Point(443, 155)
        Me.GB_Comisiones2.Name = "GB_Comisiones2"
        Me.GB_Comisiones2.Size = New System.Drawing.Size(300, 115)
        Me.GB_Comisiones2.TabIndex = 13
        Me.GB_Comisiones2.TabStop = False
        Me.GB_Comisiones2.Text = "Comisiones Feriados y Fines de Semana"
        '
        'txt_ComisionEncargadoFeriado
        '
        Me.txt_ComisionEncargadoFeriado.Location = New System.Drawing.Point(152, 68)
        Me.txt_ComisionEncargadoFeriado.Name = "txt_ComisionEncargadoFeriado"
        Me.txt_ComisionEncargadoFeriado.Size = New System.Drawing.Size(128, 20)
        Me.txt_ComisionEncargadoFeriado.TabIndex = 15
        '
        'lbl_ComisionVendedorFeriado
        '
        Me.lbl_ComisionVendedorFeriado.AutoSize = True
        Me.lbl_ComisionVendedorFeriado.Location = New System.Drawing.Point(8, 33)
        Me.lbl_ComisionVendedorFeriado.Name = "lbl_ComisionVendedorFeriado"
        Me.lbl_ComisionVendedorFeriado.Size = New System.Drawing.Size(111, 13)
        Me.lbl_ComisionVendedorFeriado.TabIndex = 12
        Me.lbl_ComisionVendedorFeriado.Text = "Comisión Vendedor (*)"
        '
        'txt_ComisionVendedorFeriado
        '
        Me.txt_ComisionVendedorFeriado.Location = New System.Drawing.Point(152, 30)
        Me.txt_ComisionVendedorFeriado.Name = "txt_ComisionVendedorFeriado"
        Me.txt_ComisionVendedorFeriado.Size = New System.Drawing.Size(128, 20)
        Me.txt_ComisionVendedorFeriado.TabIndex = 14
        '
        'lbl_ComisionEncargadoFeriado
        '
        Me.lbl_ComisionEncargadoFeriado.AutoSize = True
        Me.lbl_ComisionEncargadoFeriado.Location = New System.Drawing.Point(8, 72)
        Me.lbl_ComisionEncargadoFeriado.Name = "lbl_ComisionEncargadoFeriado"
        Me.lbl_ComisionEncargadoFeriado.Size = New System.Drawing.Size(117, 13)
        Me.lbl_ComisionEncargadoFeriado.TabIndex = 11
        Me.lbl_ComisionEncargadoFeriado.Text = "Comisión Encargado (*)"
        '
        'GB_Comisiones
        '
        Me.GB_Comisiones.Controls.Add(Me.txt_ComisionEncargado)
        Me.GB_Comisiones.Controls.Add(Me.txt_ComisionVendedor)
        Me.GB_Comisiones.Controls.Add(Me.lbl_ComisionEncargado)
        Me.GB_Comisiones.Controls.Add(Me.lbl_ComisionVendedor)
        Me.GB_Comisiones.Location = New System.Drawing.Point(443, 34)
        Me.GB_Comisiones.Name = "GB_Comisiones"
        Me.GB_Comisiones.Size = New System.Drawing.Size(300, 115)
        Me.GB_Comisiones.TabIndex = 10
        Me.GB_Comisiones.TabStop = False
        Me.GB_Comisiones.Text = "Comisiones Semanales"
        '
        'txt_ComisionEncargado
        '
        Me.txt_ComisionEncargado.Location = New System.Drawing.Point(152, 69)
        Me.txt_ComisionEncargado.Name = "txt_ComisionEncargado"
        Me.txt_ComisionEncargado.Size = New System.Drawing.Size(128, 20)
        Me.txt_ComisionEncargado.TabIndex = 12
        '
        'txt_ComisionVendedor
        '
        Me.txt_ComisionVendedor.Location = New System.Drawing.Point(152, 31)
        Me.txt_ComisionVendedor.Name = "txt_ComisionVendedor"
        Me.txt_ComisionVendedor.Size = New System.Drawing.Size(128, 20)
        Me.txt_ComisionVendedor.TabIndex = 11
        '
        'lbl_ComisionEncargado
        '
        Me.lbl_ComisionEncargado.AutoSize = True
        Me.lbl_ComisionEncargado.Location = New System.Drawing.Point(8, 73)
        Me.lbl_ComisionEncargado.Name = "lbl_ComisionEncargado"
        Me.lbl_ComisionEncargado.Size = New System.Drawing.Size(117, 13)
        Me.lbl_ComisionEncargado.TabIndex = 1
        Me.lbl_ComisionEncargado.Text = "Comisión Encargado (*)"
        '
        'lbl_ComisionVendedor
        '
        Me.lbl_ComisionVendedor.AutoSize = True
        Me.lbl_ComisionVendedor.Location = New System.Drawing.Point(8, 35)
        Me.lbl_ComisionVendedor.Name = "lbl_ComisionVendedor"
        Me.lbl_ComisionVendedor.Size = New System.Drawing.Size(111, 13)
        Me.lbl_ComisionVendedor.TabIndex = 2
        Me.lbl_ComisionVendedor.Text = "Comisión Vendedor (*)"
        '
        'Btn_Agregar
        '
        Me.Btn_Agregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Agregar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Agregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Agregar.Image = Global.SistemaCinderella.My.Resources.Recursos.Agregar_24
        Me.Btn_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Agregar.Location = New System.Drawing.Point(643, 409)
        Me.Btn_Agregar.Name = "Btn_Agregar"
        Me.Btn_Agregar.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Agregar.TabIndex = 19
        Me.Btn_Agregar.Text = "Agregar"
        Me.Btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolSucursal.SetToolTip(Me.Btn_Agregar, "Click aquí para agregar la sucursal al sistema.")
        Me.Btn_Agregar.UseVisualStyleBackColor = False
        '
        'TbMod
        '
        Me.TbMod.Controls.Add(Me.GB_Modificacion)
        Me.TbMod.Location = New System.Drawing.Point(4, 29)
        Me.TbMod.Name = "TbMod"
        Me.TbMod.Size = New System.Drawing.Size(786, 489)
        Me.TbMod.TabIndex = 2
        Me.TbMod.Text = "Modificación de Sucursal"
        Me.TbMod.UseVisualStyleBackColor = True
        '
        'GB_Modificacion
        '
        Me.GB_Modificacion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_Modificacion.Controls.Add(Me.GroupBox2)
        Me.GB_Modificacion.Controls.Add(Me.Label2)
        Me.GB_Modificacion.Controls.Add(Me.GB_Sucursal_mod)
        Me.GB_Modificacion.Controls.Add(Me.GB_Comisiones2_mod)
        Me.GB_Modificacion.Controls.Add(Me.GB_Comisiones_mod)
        Me.GB_Modificacion.Controls.Add(Me.Btn_Eliminar)
        Me.GB_Modificacion.Controls.Add(Me.Btn_Modificar)
        Me.GB_Modificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Modificacion.Location = New System.Drawing.Point(12, 7)
        Me.GB_Modificacion.Name = "GB_Modificacion"
        Me.GB_Modificacion.Size = New System.Drawing.Size(764, 465)
        Me.GB_Modificacion.TabIndex = 1
        Me.GB_Modificacion.TabStop = False
        Me.GB_Modificacion.Text = "Formulario de modificación de sucursal."
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_ComisionEncargadoMayor_mod)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txt_ComisionVendedorMayor_mod)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(443, 276)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(300, 115)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Comisiones Ventas Mayoristas"
        '
        'txt_ComisionEncargadoMayor_mod
        '
        Me.txt_ComisionEncargadoMayor_mod.Location = New System.Drawing.Point(152, 68)
        Me.txt_ComisionEncargadoMayor_mod.Name = "txt_ComisionEncargadoMayor_mod"
        Me.txt_ComisionEncargadoMayor_mod.Size = New System.Drawing.Size(128, 20)
        Me.txt_ComisionEncargadoMayor_mod.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Comisión Vendedor (*)"
        '
        'txt_ComisionVendedorMayor_mod
        '
        Me.txt_ComisionVendedorMayor_mod.Location = New System.Drawing.Point(152, 30)
        Me.txt_ComisionVendedorMayor_mod.Name = "txt_ComisionVendedorMayor_mod"
        Me.txt_ComisionVendedorMayor_mod.Size = New System.Drawing.Size(128, 20)
        Me.txt_ComisionVendedorMayor_mod.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Comisión Encargado (*)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(309, 399)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "(*) Campos obligatorios."
        '
        'GB_Sucursal_mod
        '
        Me.GB_Sucursal_mod.Controls.Add(Me.lbl_Nombre_mod)
        Me.GB_Sucursal_mod.Controls.Add(Me.lbl_Habilitado_mod)
        Me.GB_Sucursal_mod.Controls.Add(Me.txt_Nombre_mod)
        Me.GB_Sucursal_mod.Controls.Add(Me.chk_Habilitado_mod)
        Me.GB_Sucursal_mod.Controls.Add(Me.cb_Localidad_mod)
        Me.GB_Sucursal_mod.Controls.Add(Me.lbl_Direccion_mod)
        Me.GB_Sucursal_mod.Controls.Add(Me.cb_Distrito_mod)
        Me.GB_Sucursal_mod.Controls.Add(Me.txt_Direccion_mod)
        Me.GB_Sucursal_mod.Controls.Add(Me.cb_Provincia_mod)
        Me.GB_Sucursal_mod.Controls.Add(Me.lbl_CodigoPostal_mod)
        Me.GB_Sucursal_mod.Controls.Add(Me.lbl_Provincia_mod)
        Me.GB_Sucursal_mod.Controls.Add(Me.txt_CodigoPostal_mod)
        Me.GB_Sucursal_mod.Controls.Add(Me.lbl_Distrito_mod)
        Me.GB_Sucursal_mod.Controls.Add(Me.lbl_Telefono_mod)
        Me.GB_Sucursal_mod.Controls.Add(Me.lbl_Localidad_mod)
        Me.GB_Sucursal_mod.Controls.Add(Me.txt_Telefono_mod)
        Me.GB_Sucursal_mod.Location = New System.Drawing.Point(14, 34)
        Me.GB_Sucursal_mod.Name = "GB_Sucursal_mod"
        Me.GB_Sucursal_mod.Size = New System.Drawing.Size(412, 351)
        Me.GB_Sucursal_mod.TabIndex = 1
        Me.GB_Sucursal_mod.TabStop = False
        Me.GB_Sucursal_mod.Text = "Información del Establecimiento"
        '
        'lbl_Nombre_mod
        '
        Me.lbl_Nombre_mod.AutoSize = True
        Me.lbl_Nombre_mod.Location = New System.Drawing.Point(7, 39)
        Me.lbl_Nombre_mod.Name = "lbl_Nombre_mod"
        Me.lbl_Nombre_mod.Size = New System.Drawing.Size(57, 13)
        Me.lbl_Nombre_mod.TabIndex = 29
        Me.lbl_Nombre_mod.Text = "Nombre (*)"
        '
        'lbl_Habilitado_mod
        '
        Me.lbl_Habilitado_mod.AutoSize = True
        Me.lbl_Habilitado_mod.Location = New System.Drawing.Point(7, 302)
        Me.lbl_Habilitado_mod.Name = "lbl_Habilitado_mod"
        Me.lbl_Habilitado_mod.Size = New System.Drawing.Size(54, 13)
        Me.lbl_Habilitado_mod.TabIndex = 31
        Me.lbl_Habilitado_mod.Text = "Habilitado"
        '
        'txt_Nombre_mod
        '
        Me.txt_Nombre_mod.Location = New System.Drawing.Point(140, 31)
        Me.txt_Nombre_mod.MaxLength = 255
        Me.txt_Nombre_mod.Name = "txt_Nombre_mod"
        Me.txt_Nombre_mod.ReadOnly = True
        Me.txt_Nombre_mod.Size = New System.Drawing.Size(242, 20)
        Me.txt_Nombre_mod.TabIndex = 2
        '
        'chk_Habilitado_mod
        '
        Me.chk_Habilitado_mod.AutoSize = True
        Me.chk_Habilitado_mod.Checked = True
        Me.chk_Habilitado_mod.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Habilitado_mod.Location = New System.Drawing.Point(140, 302)
        Me.chk_Habilitado_mod.Name = "chk_Habilitado_mod"
        Me.chk_Habilitado_mod.Size = New System.Drawing.Size(15, 14)
        Me.chk_Habilitado_mod.TabIndex = 9
        Me.chk_Habilitado_mod.UseVisualStyleBackColor = True
        '
        'cb_Localidad_mod
        '
        Me.cb_Localidad_mod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_Localidad_mod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Localidad_mod.FormattingEnabled = True
        Me.cb_Localidad_mod.Location = New System.Drawing.Point(140, 186)
        Me.cb_Localidad_mod.Name = "cb_Localidad_mod"
        Me.cb_Localidad_mod.Size = New System.Drawing.Size(242, 21)
        Me.cb_Localidad_mod.TabIndex = 6
        '
        'lbl_Direccion_mod
        '
        Me.lbl_Direccion_mod.AutoSize = True
        Me.lbl_Direccion_mod.Location = New System.Drawing.Point(7, 233)
        Me.lbl_Direccion_mod.Name = "lbl_Direccion_mod"
        Me.lbl_Direccion_mod.Size = New System.Drawing.Size(65, 13)
        Me.lbl_Direccion_mod.TabIndex = 44
        Me.lbl_Direccion_mod.Text = "Direccion (*)"
        '
        'cb_Distrito_mod
        '
        Me.cb_Distrito_mod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_Distrito_mod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Distrito_mod.FormattingEnabled = True
        Me.cb_Distrito_mod.Location = New System.Drawing.Point(140, 147)
        Me.cb_Distrito_mod.Name = "cb_Distrito_mod"
        Me.cb_Distrito_mod.Size = New System.Drawing.Size(243, 21)
        Me.cb_Distrito_mod.TabIndex = 5
        '
        'txt_Direccion_mod
        '
        Me.txt_Direccion_mod.Location = New System.Drawing.Point(140, 225)
        Me.txt_Direccion_mod.MaxLength = 255
        Me.txt_Direccion_mod.Name = "txt_Direccion_mod"
        Me.txt_Direccion_mod.Size = New System.Drawing.Size(241, 20)
        Me.txt_Direccion_mod.TabIndex = 7
        '
        'cb_Provincia_mod
        '
        Me.cb_Provincia_mod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_Provincia_mod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Provincia_mod.FormattingEnabled = True
        Me.cb_Provincia_mod.Location = New System.Drawing.Point(140, 107)
        Me.cb_Provincia_mod.Name = "cb_Provincia_mod"
        Me.cb_Provincia_mod.Size = New System.Drawing.Size(243, 21)
        Me.cb_Provincia_mod.TabIndex = 4
        '
        'lbl_CodigoPostal_mod
        '
        Me.lbl_CodigoPostal_mod.AutoSize = True
        Me.lbl_CodigoPostal_mod.Location = New System.Drawing.Point(7, 271)
        Me.lbl_CodigoPostal_mod.Name = "lbl_CodigoPostal_mod"
        Me.lbl_CodigoPostal_mod.Size = New System.Drawing.Size(85, 13)
        Me.lbl_CodigoPostal_mod.TabIndex = 47
        Me.lbl_CodigoPostal_mod.Text = "Código Postal (*)"
        '
        'lbl_Provincia_mod
        '
        Me.lbl_Provincia_mod.AutoSize = True
        Me.lbl_Provincia_mod.Location = New System.Drawing.Point(7, 117)
        Me.lbl_Provincia_mod.Name = "lbl_Provincia_mod"
        Me.lbl_Provincia_mod.Size = New System.Drawing.Size(64, 13)
        Me.lbl_Provincia_mod.TabIndex = 57
        Me.lbl_Provincia_mod.Text = "Provincia (*)"
        '
        'txt_CodigoPostal_mod
        '
        Me.txt_CodigoPostal_mod.Location = New System.Drawing.Point(140, 263)
        Me.txt_CodigoPostal_mod.MaxLength = 255
        Me.txt_CodigoPostal_mod.Name = "txt_CodigoPostal_mod"
        Me.txt_CodigoPostal_mod.Size = New System.Drawing.Size(241, 20)
        Me.txt_CodigoPostal_mod.TabIndex = 8
        '
        'lbl_Distrito_mod
        '
        Me.lbl_Distrito_mod.AutoSize = True
        Me.lbl_Distrito_mod.Location = New System.Drawing.Point(7, 156)
        Me.lbl_Distrito_mod.Name = "lbl_Distrito_mod"
        Me.lbl_Distrito_mod.Size = New System.Drawing.Size(53, 13)
        Me.lbl_Distrito_mod.TabIndex = 56
        Me.lbl_Distrito_mod.Text = "Partido (*)"
        '
        'lbl_Telefono_mod
        '
        Me.lbl_Telefono_mod.AutoSize = True
        Me.lbl_Telefono_mod.Location = New System.Drawing.Point(7, 77)
        Me.lbl_Telefono_mod.Name = "lbl_Telefono_mod"
        Me.lbl_Telefono_mod.Size = New System.Drawing.Size(49, 13)
        Me.lbl_Telefono_mod.TabIndex = 50
        Me.lbl_Telefono_mod.Text = "Teléfono"
        '
        'lbl_Localidad_mod
        '
        Me.lbl_Localidad_mod.AutoSize = True
        Me.lbl_Localidad_mod.Location = New System.Drawing.Point(7, 195)
        Me.lbl_Localidad_mod.Name = "lbl_Localidad_mod"
        Me.lbl_Localidad_mod.Size = New System.Drawing.Size(66, 13)
        Me.lbl_Localidad_mod.TabIndex = 55
        Me.lbl_Localidad_mod.Text = "Localidad (*)"
        '
        'txt_Telefono_mod
        '
        Me.txt_Telefono_mod.Location = New System.Drawing.Point(140, 69)
        Me.txt_Telefono_mod.MaxLength = 255
        Me.txt_Telefono_mod.Name = "txt_Telefono_mod"
        Me.txt_Telefono_mod.Size = New System.Drawing.Size(243, 20)
        Me.txt_Telefono_mod.TabIndex = 3
        '
        'GB_Comisiones2_mod
        '
        Me.GB_Comisiones2_mod.Controls.Add(Me.lbl_ComisionEncargadoFeriado_mod)
        Me.GB_Comisiones2_mod.Controls.Add(Me.txt_ComisionVendedorFeriado_mod)
        Me.GB_Comisiones2_mod.Controls.Add(Me.lbl_ComisionVendedorFeriado_mod)
        Me.GB_Comisiones2_mod.Controls.Add(Me.txt_ComisionEncargadoFeriado_mod)
        Me.GB_Comisiones2_mod.Location = New System.Drawing.Point(443, 155)
        Me.GB_Comisiones2_mod.Name = "GB_Comisiones2_mod"
        Me.GB_Comisiones2_mod.Size = New System.Drawing.Size(300, 115)
        Me.GB_Comisiones2_mod.TabIndex = 13
        Me.GB_Comisiones2_mod.TabStop = False
        Me.GB_Comisiones2_mod.Text = "Comisiones Feriados y Fines de Semana"
        '
        'lbl_ComisionEncargadoFeriado_mod
        '
        Me.lbl_ComisionEncargadoFeriado_mod.AutoSize = True
        Me.lbl_ComisionEncargadoFeriado_mod.Location = New System.Drawing.Point(8, 72)
        Me.lbl_ComisionEncargadoFeriado_mod.Name = "lbl_ComisionEncargadoFeriado_mod"
        Me.lbl_ComisionEncargadoFeriado_mod.Size = New System.Drawing.Size(117, 13)
        Me.lbl_ComisionEncargadoFeriado_mod.TabIndex = 58
        Me.lbl_ComisionEncargadoFeriado_mod.Text = "Comisión Encargado (*)"
        '
        'txt_ComisionVendedorFeriado_mod
        '
        Me.txt_ComisionVendedorFeriado_mod.Location = New System.Drawing.Point(152, 30)
        Me.txt_ComisionVendedorFeriado_mod.Name = "txt_ComisionVendedorFeriado_mod"
        Me.txt_ComisionVendedorFeriado_mod.Size = New System.Drawing.Size(128, 20)
        Me.txt_ComisionVendedorFeriado_mod.TabIndex = 14
        '
        'lbl_ComisionVendedorFeriado_mod
        '
        Me.lbl_ComisionVendedorFeriado_mod.AutoSize = True
        Me.lbl_ComisionVendedorFeriado_mod.Location = New System.Drawing.Point(8, 33)
        Me.lbl_ComisionVendedorFeriado_mod.Name = "lbl_ComisionVendedorFeriado_mod"
        Me.lbl_ComisionVendedorFeriado_mod.Size = New System.Drawing.Size(111, 13)
        Me.lbl_ComisionVendedorFeriado_mod.TabIndex = 59
        Me.lbl_ComisionVendedorFeriado_mod.Text = "Comisión Vendedor (*)"
        '
        'txt_ComisionEncargadoFeriado_mod
        '
        Me.txt_ComisionEncargadoFeriado_mod.Location = New System.Drawing.Point(152, 68)
        Me.txt_ComisionEncargadoFeriado_mod.Name = "txt_ComisionEncargadoFeriado_mod"
        Me.txt_ComisionEncargadoFeriado_mod.Size = New System.Drawing.Size(128, 20)
        Me.txt_ComisionEncargadoFeriado_mod.TabIndex = 15
        '
        'GB_Comisiones_mod
        '
        Me.GB_Comisiones_mod.Controls.Add(Me.lbl_ComisionEncargado_mod)
        Me.GB_Comisiones_mod.Controls.Add(Me.txt_ComisionVendedor_mod)
        Me.GB_Comisiones_mod.Controls.Add(Me.lbl_ComisionVendedor_mod)
        Me.GB_Comisiones_mod.Controls.Add(Me.txt_ComisionEncargado_mod)
        Me.GB_Comisiones_mod.Location = New System.Drawing.Point(443, 34)
        Me.GB_Comisiones_mod.Name = "GB_Comisiones_mod"
        Me.GB_Comisiones_mod.Size = New System.Drawing.Size(300, 115)
        Me.GB_Comisiones_mod.TabIndex = 10
        Me.GB_Comisiones_mod.TabStop = False
        Me.GB_Comisiones_mod.Text = "Comisiones Semanales"
        '
        'lbl_ComisionEncargado_mod
        '
        Me.lbl_ComisionEncargado_mod.AutoSize = True
        Me.lbl_ComisionEncargado_mod.Location = New System.Drawing.Point(8, 73)
        Me.lbl_ComisionEncargado_mod.Name = "lbl_ComisionEncargado_mod"
        Me.lbl_ComisionEncargado_mod.Size = New System.Drawing.Size(117, 13)
        Me.lbl_ComisionEncargado_mod.TabIndex = 58
        Me.lbl_ComisionEncargado_mod.Text = "Comisión Encargado (*)"
        '
        'txt_ComisionVendedor_mod
        '
        Me.txt_ComisionVendedor_mod.Location = New System.Drawing.Point(152, 31)
        Me.txt_ComisionVendedor_mod.Name = "txt_ComisionVendedor_mod"
        Me.txt_ComisionVendedor_mod.Size = New System.Drawing.Size(128, 20)
        Me.txt_ComisionVendedor_mod.TabIndex = 11
        '
        'lbl_ComisionVendedor_mod
        '
        Me.lbl_ComisionVendedor_mod.AutoSize = True
        Me.lbl_ComisionVendedor_mod.Location = New System.Drawing.Point(8, 35)
        Me.lbl_ComisionVendedor_mod.Name = "lbl_ComisionVendedor_mod"
        Me.lbl_ComisionVendedor_mod.Size = New System.Drawing.Size(111, 13)
        Me.lbl_ComisionVendedor_mod.TabIndex = 59
        Me.lbl_ComisionVendedor_mod.Text = "Comisión Vendedor (*)"
        '
        'txt_ComisionEncargado_mod
        '
        Me.txt_ComisionEncargado_mod.Location = New System.Drawing.Point(152, 69)
        Me.txt_ComisionEncargado_mod.Name = "txt_ComisionEncargado_mod"
        Me.txt_ComisionEncargado_mod.Size = New System.Drawing.Size(128, 20)
        Me.txt_ComisionEncargado_mod.TabIndex = 12
        '
        'Btn_Eliminar
        '
        Me.Btn_Eliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Eliminar.Image = Global.SistemaCinderella.My.Resources.Recursos.desconectado_32
        Me.Btn_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Eliminar.Location = New System.Drawing.Point(537, 409)
        Me.Btn_Eliminar.Name = "Btn_Eliminar"
        Me.Btn_Eliminar.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Eliminar.TabIndex = 19
        Me.Btn_Eliminar.Text = "Eliminar"
        Me.Btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolSucursal.SetToolTip(Me.Btn_Eliminar, "Click aquí para eliminar la sucursal del sistema.")
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
        Me.Btn_Modificar.Location = New System.Drawing.Point(643, 409)
        Me.Btn_Modificar.Name = "Btn_Modificar"
        Me.Btn_Modificar.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Modificar.TabIndex = 20
        Me.Btn_Modificar.Text = "Modificar"
        Me.Btn_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolSucursal.SetToolTip(Me.Btn_Modificar, "Click aquí para modificar la sucursal en el sistema.")
        Me.Btn_Modificar.UseVisualStyleBackColor = False
        '
        'ErroresSucursal
        '
        Me.ErroresSucursal.BlinkRate = 200
        Me.ErroresSucursal.ContainerControl = Me
        '
        'ToolSucursal
        '
        Me.ToolSucursal.IsBalloon = True
        Me.ToolSucursal.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolSucursal.ToolTipTitle = "Ayuda"
        '
        'frmSucursales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 522)
        Me.Controls.Add(Me.TabSucursales)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmSucursales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administración de Sucursales"
        Me.TabSucursales.ResumeLayout(False)
        Me.TbListado.ResumeLayout(False)
        CType(Me.DG_Sucursales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TbAlta.ResumeLayout(False)
        Me.GB_Alta.ResumeLayout(False)
        Me.GB_Alta.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GB_Sucursal.ResumeLayout(False)
        Me.GB_Sucursal.PerformLayout()
        Me.GB_Comisiones2.ResumeLayout(False)
        Me.GB_Comisiones2.PerformLayout()
        Me.GB_Comisiones.ResumeLayout(False)
        Me.GB_Comisiones.PerformLayout()
        Me.TbMod.ResumeLayout(False)
        Me.GB_Modificacion.ResumeLayout(False)
        Me.GB_Modificacion.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GB_Sucursal_mod.ResumeLayout(False)
        Me.GB_Sucursal_mod.PerformLayout()
        Me.GB_Comisiones2_mod.ResumeLayout(False)
        Me.GB_Comisiones2_mod.PerformLayout()
        Me.GB_Comisiones_mod.ResumeLayout(False)
        Me.GB_Comisiones_mod.PerformLayout()
        CType(Me.ErroresSucursal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabSucursales As System.Windows.Forms.TabControl
    Friend WithEvents TbListado As System.Windows.Forms.TabPage
    Friend WithEvents DG_Sucursales As System.Windows.Forms.DataGridView
    Friend WithEvents TbAlta As System.Windows.Forms.TabPage
    Friend WithEvents GB_Alta As System.Windows.Forms.GroupBox
    Friend WithEvents cb_Localidad As System.Windows.Forms.ComboBox
    Friend WithEvents cb_Distrito As System.Windows.Forms.ComboBox
    Friend WithEvents cb_Provincia As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_Provincia As System.Windows.Forms.Label
    Friend WithEvents lbl_Distrito As System.Windows.Forms.Label
    Friend WithEvents lbl_Localidad As System.Windows.Forms.Label
    Friend WithEvents txt_Telefono As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Telefono As System.Windows.Forms.Label
    Friend WithEvents txt_CodigoPostal As System.Windows.Forms.TextBox
    Friend WithEvents lbl_CodigoPostal As System.Windows.Forms.Label
    Friend WithEvents txt_Direccion As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Direccion As System.Windows.Forms.Label
    Friend WithEvents chk_Habilitado As System.Windows.Forms.CheckBox
    Friend WithEvents txt_Nombre As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Habilitado As System.Windows.Forms.Label
    Friend WithEvents lbl_Nombre As System.Windows.Forms.Label
    Friend WithEvents Btn_Agregar As System.Windows.Forms.Button
    Friend WithEvents TbMod As System.Windows.Forms.TabPage
    Friend WithEvents GB_Modificacion As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents cb_Localidad_mod As System.Windows.Forms.ComboBox
    Friend WithEvents cb_Distrito_mod As System.Windows.Forms.ComboBox
    Friend WithEvents cb_Provincia_mod As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_Provincia_mod As System.Windows.Forms.Label
    Friend WithEvents lbl_Distrito_mod As System.Windows.Forms.Label
    Friend WithEvents lbl_Localidad_mod As System.Windows.Forms.Label
    Friend WithEvents txt_Telefono_mod As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Telefono_mod As System.Windows.Forms.Label
    Friend WithEvents txt_CodigoPostal_mod As System.Windows.Forms.TextBox
    Friend WithEvents lbl_CodigoPostal_mod As System.Windows.Forms.Label
    Friend WithEvents txt_Direccion_mod As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Direccion_mod As System.Windows.Forms.Label
    Friend WithEvents chk_Habilitado_mod As System.Windows.Forms.CheckBox
    Friend WithEvents txt_Nombre_mod As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Habilitado_mod As System.Windows.Forms.Label
    Friend WithEvents lbl_Nombre_mod As System.Windows.Forms.Label
    Friend WithEvents Btn_Modificar As System.Windows.Forms.Button
    Friend WithEvents ErroresSucursal As System.Windows.Forms.ErrorProvider
    Friend WithEvents lbl_ComisionEncargado As System.Windows.Forms.Label
    Friend WithEvents lbl_ComisionVendedor As System.Windows.Forms.Label
    Friend WithEvents txt_ComisionEncargado As System.Windows.Forms.TextBox
    Friend WithEvents txt_ComisionVendedor As System.Windows.Forms.TextBox
    Friend WithEvents lbl_ComisionEncargado_mod As System.Windows.Forms.Label
    Friend WithEvents lbl_ComisionVendedor_mod As System.Windows.Forms.Label
    Friend WithEvents txt_ComisionEncargado_mod As System.Windows.Forms.TextBox
    Friend WithEvents txt_ComisionVendedor_mod As System.Windows.Forms.TextBox
    Friend WithEvents GB_Sucursal As System.Windows.Forms.GroupBox
    Friend WithEvents GB_Comisiones2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_ComisionEncargadoFeriado As System.Windows.Forms.TextBox
    Friend WithEvents lbl_ComisionVendedorFeriado As System.Windows.Forms.Label
    Friend WithEvents txt_ComisionVendedorFeriado As System.Windows.Forms.TextBox
    Friend WithEvents lbl_ComisionEncargadoFeriado As System.Windows.Forms.Label
    Friend WithEvents GB_Comisiones As System.Windows.Forms.GroupBox
    Friend WithEvents GB_Sucursal_mod As System.Windows.Forms.GroupBox
    Friend WithEvents GB_Comisiones_mod As System.Windows.Forms.GroupBox
    Friend WithEvents GB_Comisiones2_mod As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_ComisionEncargadoFeriado_mod As System.Windows.Forms.Label
    Friend WithEvents txt_ComisionVendedorFeriado_mod As System.Windows.Forms.TextBox
    Friend WithEvents lbl_ComisionVendedorFeriado_mod As System.Windows.Forms.Label
    Friend WithEvents txt_ComisionEncargadoFeriado_mod As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToolSucursal As System.Windows.Forms.ToolTip
    Friend WithEvents id_Sucursal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Direccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Telefono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Habilitado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Modificar As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_ComisionEncargadoMayor As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_ComisionVendedorMayor As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_ComisionEncargadoMayor_mod As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_ComisionVendedorMayor_mod As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
