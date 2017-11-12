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
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.GB_Sucursal = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.chk_Habilitado = New System.Windows.Forms.CheckBox()
        Me.txt_CodigoVenta = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cb_Localidad = New System.Windows.Forms.ComboBox()
        Me.txt_CodigoPostal = New System.Windows.Forms.TextBox()
        Me.txt_Direccion = New System.Windows.Forms.TextBox()
        Me.txt_Nombre = New System.Windows.Forms.TextBox()
        Me.lbl_Habilitado = New System.Windows.Forms.Label()
        Me.cb_Distrito = New System.Windows.Forms.ComboBox()
        Me.lbl_Nombre = New System.Windows.Forms.Label()
        Me.cb_Provincia = New System.Windows.Forms.ComboBox()
        Me.lbl_Telefono = New System.Windows.Forms.Label()
        Me.lbl_Provincia = New System.Windows.Forms.Label()
        Me.lbl_Distrito = New System.Windows.Forms.Label()
        Me.txt_Telefono = New System.Windows.Forms.TextBox()
        Me.lbl_Localidad = New System.Windows.Forms.Label()
        Me.lbl_Direccion = New System.Windows.Forms.Label()
        Me.lbl_CodigoPostal = New System.Windows.Forms.Label()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.GB_Comisiones = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_ComisionEncargado = New System.Windows.Forms.TextBox()
        Me.lbl_ComisionVendedor = New System.Windows.Forms.Label()
        Me.txt_ComisionVendedor = New System.Windows.Forms.TextBox()
        Me.lbl_ComisionEncargado = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_ComisionEncargadoMayor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_ComisionVendedorMayor = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GB_Comisiones2 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_ComisionEncargadoFeriado = New System.Windows.Forms.TextBox()
        Me.lbl_ComisionVendedorFeriado = New System.Windows.Forms.Label()
        Me.txt_ComisionVendedorFeriado = New System.Windows.Forms.TextBox()
        Me.lbl_ComisionEncargadoFeriado = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_Agregar = New System.Windows.Forms.Button()
        Me.TbMod = New System.Windows.Forms.TabPage()
        Me.GB_Modificacion = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_Nombre_mod = New System.Windows.Forms.TextBox()
        Me.txt_CodigoPostal_mod = New System.Windows.Forms.TextBox()
        Me.txt_Direccion_mod = New System.Windows.Forms.TextBox()
        Me.cb_Localidad_mod = New System.Windows.Forms.ComboBox()
        Me.lbl_Habilitado_mod = New System.Windows.Forms.Label()
        Me.cb_Distrito_mod = New System.Windows.Forms.ComboBox()
        Me.lbl_Nombre_mod = New System.Windows.Forms.Label()
        Me.lbl_Telefono_mod = New System.Windows.Forms.Label()
        Me.cb_Provincia_mod = New System.Windows.Forms.ComboBox()
        Me.lbl_Provincia_mod = New System.Windows.Forms.Label()
        Me.lbl_Distrito_mod = New System.Windows.Forms.Label()
        Me.txt_Telefono_mod = New System.Windows.Forms.TextBox()
        Me.lbl_Localidad_mod = New System.Windows.Forms.Label()
        Me.lbl_Direccion_mod = New System.Windows.Forms.Label()
        Me.lbl_CodigoPostal_mod = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_ComisionEncargadoMayor_mod = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_ComisionVendedorMayor_mod = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GB_Sucursal_mod = New System.Windows.Forms.GroupBox()
        Me.txt_CodigoVenta_mod = New System.Windows.Forms.TextBox()
        Me.chk_Habilitado_mod = New System.Windows.Forms.CheckBox()
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
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel9 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel10 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel11 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel12 = New System.Windows.Forms.TableLayoutPanel()
        Me.TabSucursales.SuspendLayout()
        Me.TbListado.SuspendLayout()
        CType(Me.DG_Sucursales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TbAlta.SuspendLayout()
        Me.GB_Alta.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.GB_Sucursal.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.GB_Comisiones.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.GB_Comisiones2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TbMod.SuspendLayout()
        Me.GB_Modificacion.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GB_Sucursal_mod.SuspendLayout()
        Me.GB_Comisiones2_mod.SuspendLayout()
        Me.GB_Comisiones_mod.SuspendLayout()
        CType(Me.ErroresSucursal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel8.SuspendLayout()
        Me.TableLayoutPanel9.SuspendLayout()
        Me.TableLayoutPanel10.SuspendLayout()
        Me.TableLayoutPanel11.SuspendLayout()
        Me.TableLayoutPanel12.SuspendLayout()
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
        Me.GB_Alta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_Alta.Controls.Add(Me.TableLayoutPanel6)
        Me.GB_Alta.Controls.Add(Me.Label1)
        Me.GB_Alta.Controls.Add(Me.Btn_Agregar)
        Me.GB_Alta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Alta.Location = New System.Drawing.Point(12, 7)
        Me.GB_Alta.Name = "GB_Alta"
        Me.GB_Alta.Size = New System.Drawing.Size(764, 386)
        Me.GB_Alta.TabIndex = 0
        Me.GB_Alta.TabStop = False
        Me.GB_Alta.Text = "Formulario de alta de sucursal."
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel6.ColumnCount = 2
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.GB_Sucursal, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.TableLayoutPanel5, 1, 0)
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(6, 19)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(752, 316)
        Me.TableLayoutPanel6.TabIndex = 21
        '
        'GB_Sucursal
        '
        Me.GB_Sucursal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_Sucursal.Controls.Add(Me.TableLayoutPanel1)
        Me.GB_Sucursal.Location = New System.Drawing.Point(3, 3)
        Me.GB_Sucursal.Name = "GB_Sucursal"
        Me.GB_Sucursal.Size = New System.Drawing.Size(370, 310)
        Me.GB_Sucursal.TabIndex = 1
        Me.GB_Sucursal.TabStop = False
        Me.GB_Sucursal.Text = "Información del Establecimiento"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.chk_Habilitado, 1, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_CodigoVenta, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.cb_Localidad, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_CodigoPostal, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Direccion, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Nombre, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_Habilitado, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.cb_Distrito, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_Nombre, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cb_Provincia, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_Telefono, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_Provincia, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_Distrito, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Telefono, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_Localidad, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_Direccion, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_CodigoPostal, 0, 6)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(6, 19)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 9
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(358, 270)
        Me.TableLayoutPanel1.TabIndex = 20
        '
        'chk_Habilitado
        '
        Me.chk_Habilitado.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chk_Habilitado.AutoSize = True
        Me.chk_Habilitado.Checked = True
        Me.chk_Habilitado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Habilitado.Location = New System.Drawing.Point(143, 248)
        Me.chk_Habilitado.Name = "chk_Habilitado"
        Me.chk_Habilitado.Size = New System.Drawing.Size(212, 14)
        Me.chk_Habilitado.TabIndex = 9
        Me.chk_Habilitado.UseVisualStyleBackColor = True
        '
        'txt_CodigoVenta
        '
        Me.txt_CodigoVenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_CodigoVenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_CodigoVenta.Location = New System.Drawing.Point(143, 215)
        Me.txt_CodigoVenta.MaxLength = 2
        Me.txt_CodigoVenta.Name = "txt_CodigoVenta"
        Me.txt_CodigoVenta.Size = New System.Drawing.Size(212, 20)
        Me.txt_CodigoVenta.TabIndex = 60
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 218)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(134, 13)
        Me.Label8.TabIndex = 61
        Me.Label8.Text = "Código Venta (*)"
        '
        'cb_Localidad
        '
        Me.cb_Localidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_Localidad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_Localidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Localidad.FormattingEnabled = True
        Me.cb_Localidad.Location = New System.Drawing.Point(143, 124)
        Me.cb_Localidad.Name = "cb_Localidad"
        Me.cb_Localidad.Size = New System.Drawing.Size(212, 21)
        Me.cb_Localidad.TabIndex = 6
        '
        'txt_CodigoPostal
        '
        Me.txt_CodigoPostal.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_CodigoPostal.Location = New System.Drawing.Point(143, 185)
        Me.txt_CodigoPostal.MaxLength = 255
        Me.txt_CodigoPostal.Name = "txt_CodigoPostal"
        Me.txt_CodigoPostal.Size = New System.Drawing.Size(212, 20)
        Me.txt_CodigoPostal.TabIndex = 8
        '
        'txt_Direccion
        '
        Me.txt_Direccion.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Direccion.Location = New System.Drawing.Point(143, 155)
        Me.txt_Direccion.MaxLength = 255
        Me.txt_Direccion.Name = "txt_Direccion"
        Me.txt_Direccion.Size = New System.Drawing.Size(212, 20)
        Me.txt_Direccion.TabIndex = 6
        '
        'txt_Nombre
        '
        Me.txt_Nombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Nombre.Location = New System.Drawing.Point(143, 5)
        Me.txt_Nombre.MaxLength = 255
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.Size = New System.Drawing.Size(212, 20)
        Me.txt_Nombre.TabIndex = 2
        '
        'lbl_Habilitado
        '
        Me.lbl_Habilitado.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Habilitado.AutoSize = True
        Me.lbl_Habilitado.Location = New System.Drawing.Point(3, 248)
        Me.lbl_Habilitado.Name = "lbl_Habilitado"
        Me.lbl_Habilitado.Size = New System.Drawing.Size(134, 13)
        Me.lbl_Habilitado.TabIndex = 2
        Me.lbl_Habilitado.Text = "Habilitado"
        '
        'cb_Distrito
        '
        Me.cb_Distrito.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_Distrito.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_Distrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Distrito.FormattingEnabled = True
        Me.cb_Distrito.Location = New System.Drawing.Point(143, 94)
        Me.cb_Distrito.Name = "cb_Distrito"
        Me.cb_Distrito.Size = New System.Drawing.Size(212, 21)
        Me.cb_Distrito.TabIndex = 5
        '
        'lbl_Nombre
        '
        Me.lbl_Nombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Nombre.AutoSize = True
        Me.lbl_Nombre.Location = New System.Drawing.Point(3, 8)
        Me.lbl_Nombre.Name = "lbl_Nombre"
        Me.lbl_Nombre.Size = New System.Drawing.Size(134, 13)
        Me.lbl_Nombre.TabIndex = 1
        Me.lbl_Nombre.Text = "Nombre (*)"
        '
        'cb_Provincia
        '
        Me.cb_Provincia.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_Provincia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_Provincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Provincia.FormattingEnabled = True
        Me.cb_Provincia.Location = New System.Drawing.Point(143, 64)
        Me.cb_Provincia.Name = "cb_Provincia"
        Me.cb_Provincia.Size = New System.Drawing.Size(212, 21)
        Me.cb_Provincia.TabIndex = 4
        '
        'lbl_Telefono
        '
        Me.lbl_Telefono.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Telefono.AutoSize = True
        Me.lbl_Telefono.Location = New System.Drawing.Point(3, 38)
        Me.lbl_Telefono.Name = "lbl_Telefono"
        Me.lbl_Telefono.Size = New System.Drawing.Size(134, 13)
        Me.lbl_Telefono.TabIndex = 15
        Me.lbl_Telefono.Text = "Teléfono"
        '
        'lbl_Provincia
        '
        Me.lbl_Provincia.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Provincia.AutoSize = True
        Me.lbl_Provincia.Location = New System.Drawing.Point(3, 68)
        Me.lbl_Provincia.Name = "lbl_Provincia"
        Me.lbl_Provincia.Size = New System.Drawing.Size(134, 13)
        Me.lbl_Provincia.TabIndex = 27
        Me.lbl_Provincia.Text = "Provincia (*)"
        '
        'lbl_Distrito
        '
        Me.lbl_Distrito.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Distrito.AutoSize = True
        Me.lbl_Distrito.Location = New System.Drawing.Point(3, 98)
        Me.lbl_Distrito.Name = "lbl_Distrito"
        Me.lbl_Distrito.Size = New System.Drawing.Size(134, 13)
        Me.lbl_Distrito.TabIndex = 26
        Me.lbl_Distrito.Text = "Partido (*)"
        '
        'txt_Telefono
        '
        Me.txt_Telefono.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Telefono.Location = New System.Drawing.Point(143, 35)
        Me.txt_Telefono.MaxLength = 255
        Me.txt_Telefono.Name = "txt_Telefono"
        Me.txt_Telefono.Size = New System.Drawing.Size(212, 20)
        Me.txt_Telefono.TabIndex = 3
        '
        'lbl_Localidad
        '
        Me.lbl_Localidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Localidad.AutoSize = True
        Me.lbl_Localidad.Location = New System.Drawing.Point(3, 128)
        Me.lbl_Localidad.Name = "lbl_Localidad"
        Me.lbl_Localidad.Size = New System.Drawing.Size(134, 13)
        Me.lbl_Localidad.TabIndex = 25
        Me.lbl_Localidad.Text = "Localidad (*)"
        '
        'lbl_Direccion
        '
        Me.lbl_Direccion.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Direccion.AutoSize = True
        Me.lbl_Direccion.Location = New System.Drawing.Point(3, 158)
        Me.lbl_Direccion.Name = "lbl_Direccion"
        Me.lbl_Direccion.Size = New System.Drawing.Size(134, 13)
        Me.lbl_Direccion.TabIndex = 11
        Me.lbl_Direccion.Text = "Direccion (*)"
        '
        'lbl_CodigoPostal
        '
        Me.lbl_CodigoPostal.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_CodigoPostal.AutoSize = True
        Me.lbl_CodigoPostal.Location = New System.Drawing.Point(3, 188)
        Me.lbl_CodigoPostal.Name = "lbl_CodigoPostal"
        Me.lbl_CodigoPostal.Size = New System.Drawing.Size(134, 13)
        Me.lbl_CodigoPostal.TabIndex = 13
        Me.lbl_CodigoPostal.Text = "Código Postal (*)"
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.GB_Comisiones, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.GroupBox1, 0, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.GB_Comisiones2, 0, 1)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(379, 3)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 3
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(370, 310)
        Me.TableLayoutPanel5.TabIndex = 20
        '
        'GB_Comisiones
        '
        Me.GB_Comisiones.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_Comisiones.Controls.Add(Me.TableLayoutPanel2)
        Me.GB_Comisiones.Location = New System.Drawing.Point(3, 7)
        Me.GB_Comisiones.Name = "GB_Comisiones"
        Me.GB_Comisiones.Size = New System.Drawing.Size(364, 88)
        Me.GB_Comisiones.TabIndex = 10
        Me.GB_Comisiones.TabStop = False
        Me.GB_Comisiones.Text = "Comisiones Semanales"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.txt_ComisionEncargado, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_ComisionVendedor, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_ComisionVendedor, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_ComisionEncargado, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(358, 69)
        Me.TableLayoutPanel2.TabIndex = 21
        '
        'txt_ComisionEncargado
        '
        Me.txt_ComisionEncargado.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_ComisionEncargado.Location = New System.Drawing.Point(163, 41)
        Me.txt_ComisionEncargado.Name = "txt_ComisionEncargado"
        Me.txt_ComisionEncargado.Size = New System.Drawing.Size(192, 20)
        Me.txt_ComisionEncargado.TabIndex = 12
        '
        'lbl_ComisionVendedor
        '
        Me.lbl_ComisionVendedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_ComisionVendedor.AutoSize = True
        Me.lbl_ComisionVendedor.Location = New System.Drawing.Point(3, 10)
        Me.lbl_ComisionVendedor.Name = "lbl_ComisionVendedor"
        Me.lbl_ComisionVendedor.Size = New System.Drawing.Size(154, 13)
        Me.lbl_ComisionVendedor.TabIndex = 2
        Me.lbl_ComisionVendedor.Text = "Comisión Vendedor (*)"
        '
        'txt_ComisionVendedor
        '
        Me.txt_ComisionVendedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_ComisionVendedor.Location = New System.Drawing.Point(163, 7)
        Me.txt_ComisionVendedor.Name = "txt_ComisionVendedor"
        Me.txt_ComisionVendedor.Size = New System.Drawing.Size(192, 20)
        Me.txt_ComisionVendedor.TabIndex = 11
        '
        'lbl_ComisionEncargado
        '
        Me.lbl_ComisionEncargado.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_ComisionEncargado.AutoSize = True
        Me.lbl_ComisionEncargado.Location = New System.Drawing.Point(3, 45)
        Me.lbl_ComisionEncargado.Name = "lbl_ComisionEncargado"
        Me.lbl_ComisionEncargado.Size = New System.Drawing.Size(154, 13)
        Me.lbl_ComisionEncargado.TabIndex = 1
        Me.lbl_ComisionEncargado.Text = "Comisión Encargado (*)"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel4)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 215)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(364, 86)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Comisiones Ventas Mayoristas"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.txt_ComisionEncargadoMayor, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.txt_ComisionVendedorMayor, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label4, 0, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(358, 67)
        Me.TableLayoutPanel4.TabIndex = 20
        '
        'txt_ComisionEncargadoMayor
        '
        Me.txt_ComisionEncargadoMayor.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_ComisionEncargadoMayor.Location = New System.Drawing.Point(182, 40)
        Me.txt_ComisionEncargadoMayor.Name = "txt_ComisionEncargadoMayor"
        Me.txt_ComisionEncargadoMayor.Size = New System.Drawing.Size(173, 20)
        Me.txt_ComisionEncargadoMayor.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(173, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Comisión Vendedor (*)"
        '
        'txt_ComisionVendedorMayor
        '
        Me.txt_ComisionVendedorMayor.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_ComisionVendedorMayor.Location = New System.Drawing.Point(182, 6)
        Me.txt_ComisionVendedorMayor.Name = "txt_ComisionVendedorMayor"
        Me.txt_ComisionVendedorMayor.Size = New System.Drawing.Size(173, 20)
        Me.txt_ComisionVendedorMayor.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(173, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Comisión Encargado (*)"
        '
        'GB_Comisiones2
        '
        Me.GB_Comisiones2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_Comisiones2.Controls.Add(Me.TableLayoutPanel3)
        Me.GB_Comisiones2.Location = New System.Drawing.Point(3, 111)
        Me.GB_Comisiones2.Name = "GB_Comisiones2"
        Me.GB_Comisiones2.Size = New System.Drawing.Size(364, 87)
        Me.GB_Comisiones2.TabIndex = 13
        Me.GB_Comisiones2.TabStop = False
        Me.GB_Comisiones2.Text = "Comisiones Feriados y Fines de Semana"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.txt_ComisionEncargadoFeriado, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.lbl_ComisionVendedorFeriado, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.txt_ComisionVendedorFeriado, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.lbl_ComisionEncargadoFeriado, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(358, 68)
        Me.TableLayoutPanel3.TabIndex = 20
        '
        'txt_ComisionEncargadoFeriado
        '
        Me.txt_ComisionEncargadoFeriado.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_ComisionEncargadoFeriado.Location = New System.Drawing.Point(182, 41)
        Me.txt_ComisionEncargadoFeriado.Name = "txt_ComisionEncargadoFeriado"
        Me.txt_ComisionEncargadoFeriado.Size = New System.Drawing.Size(173, 20)
        Me.txt_ComisionEncargadoFeriado.TabIndex = 15
        '
        'lbl_ComisionVendedorFeriado
        '
        Me.lbl_ComisionVendedorFeriado.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_ComisionVendedorFeriado.AutoSize = True
        Me.lbl_ComisionVendedorFeriado.Location = New System.Drawing.Point(3, 10)
        Me.lbl_ComisionVendedorFeriado.Name = "lbl_ComisionVendedorFeriado"
        Me.lbl_ComisionVendedorFeriado.Size = New System.Drawing.Size(173, 13)
        Me.lbl_ComisionVendedorFeriado.TabIndex = 12
        Me.lbl_ComisionVendedorFeriado.Text = "Comisión Vendedor (*)"
        '
        'txt_ComisionVendedorFeriado
        '
        Me.txt_ComisionVendedorFeriado.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_ComisionVendedorFeriado.Location = New System.Drawing.Point(182, 7)
        Me.txt_ComisionVendedorFeriado.Name = "txt_ComisionVendedorFeriado"
        Me.txt_ComisionVendedorFeriado.Size = New System.Drawing.Size(173, 20)
        Me.txt_ComisionVendedorFeriado.TabIndex = 14
        '
        'lbl_ComisionEncargadoFeriado
        '
        Me.lbl_ComisionEncargadoFeriado.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_ComisionEncargadoFeriado.AutoSize = True
        Me.lbl_ComisionEncargadoFeriado.Location = New System.Drawing.Point(3, 44)
        Me.lbl_ComisionEncargadoFeriado.Name = "lbl_ComisionEncargadoFeriado"
        Me.lbl_ComisionEncargadoFeriado.Size = New System.Drawing.Size(173, 13)
        Me.lbl_ComisionEncargadoFeriado.TabIndex = 11
        Me.lbl_ComisionEncargadoFeriado.Text = "Comisión Encargado (*)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 341)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "(*) Campos obligatorios."
        '
        'Btn_Agregar
        '
        Me.Btn_Agregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Agregar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Agregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Agregar.Image = Global.SistemaCinderella.My.Resources.Recursos.Agregar_24
        Me.Btn_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Agregar.Location = New System.Drawing.Point(658, 340)
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
        Me.GB_Modificacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_Modificacion.Controls.Add(Me.TableLayoutPanel12)
        Me.GB_Modificacion.Controls.Add(Me.Label2)
        Me.GB_Modificacion.Controls.Add(Me.Btn_Eliminar)
        Me.GB_Modificacion.Controls.Add(Me.Btn_Modificar)
        Me.GB_Modificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Modificacion.Location = New System.Drawing.Point(12, 8)
        Me.GB_Modificacion.Name = "GB_Modificacion"
        Me.GB_Modificacion.Size = New System.Drawing.Size(764, 386)
        Me.GB_Modificacion.TabIndex = 1
        Me.GB_Modificacion.TabStop = False
        Me.GB_Modificacion.Text = "Formulario de modificación de sucursal."
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel7.ColumnCount = 2
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.chk_Habilitado_mod, 1, 8)
        Me.TableLayoutPanel7.Controls.Add(Me.txt_CodigoVenta_mod, 1, 7)
        Me.TableLayoutPanel7.Controls.Add(Me.Label7, 0, 7)
        Me.TableLayoutPanel7.Controls.Add(Me.txt_Nombre_mod, 1, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.txt_CodigoPostal_mod, 1, 6)
        Me.TableLayoutPanel7.Controls.Add(Me.txt_Direccion_mod, 1, 5)
        Me.TableLayoutPanel7.Controls.Add(Me.cb_Localidad_mod, 1, 4)
        Me.TableLayoutPanel7.Controls.Add(Me.lbl_Habilitado_mod, 0, 8)
        Me.TableLayoutPanel7.Controls.Add(Me.cb_Distrito_mod, 1, 3)
        Me.TableLayoutPanel7.Controls.Add(Me.lbl_Nombre_mod, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.lbl_Telefono_mod, 0, 1)
        Me.TableLayoutPanel7.Controls.Add(Me.cb_Provincia_mod, 1, 2)
        Me.TableLayoutPanel7.Controls.Add(Me.lbl_Provincia_mod, 0, 2)
        Me.TableLayoutPanel7.Controls.Add(Me.lbl_Distrito_mod, 0, 3)
        Me.TableLayoutPanel7.Controls.Add(Me.txt_Telefono_mod, 1, 1)
        Me.TableLayoutPanel7.Controls.Add(Me.lbl_Localidad_mod, 0, 4)
        Me.TableLayoutPanel7.Controls.Add(Me.lbl_Direccion_mod, 0, 5)
        Me.TableLayoutPanel7.Controls.Add(Me.lbl_CodigoPostal_mod, 0, 6)
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(6, 19)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 9
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(355, 270)
        Me.TableLayoutPanel7.TabIndex = 21
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 218)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(134, 13)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "Código Venta (*)"
        '
        'txt_Nombre_mod
        '
        Me.txt_Nombre_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Nombre_mod.Location = New System.Drawing.Point(143, 5)
        Me.txt_Nombre_mod.MaxLength = 255
        Me.txt_Nombre_mod.Name = "txt_Nombre_mod"
        Me.txt_Nombre_mod.ReadOnly = True
        Me.txt_Nombre_mod.Size = New System.Drawing.Size(209, 20)
        Me.txt_Nombre_mod.TabIndex = 2
        '
        'txt_CodigoPostal_mod
        '
        Me.txt_CodigoPostal_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_CodigoPostal_mod.Location = New System.Drawing.Point(143, 185)
        Me.txt_CodigoPostal_mod.MaxLength = 255
        Me.txt_CodigoPostal_mod.Name = "txt_CodigoPostal_mod"
        Me.txt_CodigoPostal_mod.Size = New System.Drawing.Size(209, 20)
        Me.txt_CodigoPostal_mod.TabIndex = 8
        '
        'txt_Direccion_mod
        '
        Me.txt_Direccion_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Direccion_mod.Location = New System.Drawing.Point(143, 155)
        Me.txt_Direccion_mod.MaxLength = 255
        Me.txt_Direccion_mod.Name = "txt_Direccion_mod"
        Me.txt_Direccion_mod.Size = New System.Drawing.Size(209, 20)
        Me.txt_Direccion_mod.TabIndex = 7
        '
        'cb_Localidad_mod
        '
        Me.cb_Localidad_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_Localidad_mod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_Localidad_mod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Localidad_mod.FormattingEnabled = True
        Me.cb_Localidad_mod.Location = New System.Drawing.Point(143, 124)
        Me.cb_Localidad_mod.Name = "cb_Localidad_mod"
        Me.cb_Localidad_mod.Size = New System.Drawing.Size(209, 21)
        Me.cb_Localidad_mod.TabIndex = 6
        '
        'lbl_Habilitado_mod
        '
        Me.lbl_Habilitado_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Habilitado_mod.AutoSize = True
        Me.lbl_Habilitado_mod.Location = New System.Drawing.Point(3, 248)
        Me.lbl_Habilitado_mod.Name = "lbl_Habilitado_mod"
        Me.lbl_Habilitado_mod.Size = New System.Drawing.Size(134, 13)
        Me.lbl_Habilitado_mod.TabIndex = 31
        Me.lbl_Habilitado_mod.Text = "Habilitado"
        '
        'cb_Distrito_mod
        '
        Me.cb_Distrito_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_Distrito_mod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_Distrito_mod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Distrito_mod.FormattingEnabled = True
        Me.cb_Distrito_mod.Location = New System.Drawing.Point(143, 94)
        Me.cb_Distrito_mod.Name = "cb_Distrito_mod"
        Me.cb_Distrito_mod.Size = New System.Drawing.Size(209, 21)
        Me.cb_Distrito_mod.TabIndex = 5
        '
        'lbl_Nombre_mod
        '
        Me.lbl_Nombre_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Nombre_mod.AutoSize = True
        Me.lbl_Nombre_mod.Location = New System.Drawing.Point(3, 8)
        Me.lbl_Nombre_mod.Name = "lbl_Nombre_mod"
        Me.lbl_Nombre_mod.Size = New System.Drawing.Size(134, 13)
        Me.lbl_Nombre_mod.TabIndex = 29
        Me.lbl_Nombre_mod.Text = "Nombre (*)"
        '
        'lbl_Telefono_mod
        '
        Me.lbl_Telefono_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Telefono_mod.AutoSize = True
        Me.lbl_Telefono_mod.Location = New System.Drawing.Point(3, 38)
        Me.lbl_Telefono_mod.Name = "lbl_Telefono_mod"
        Me.lbl_Telefono_mod.Size = New System.Drawing.Size(134, 13)
        Me.lbl_Telefono_mod.TabIndex = 50
        Me.lbl_Telefono_mod.Text = "Teléfono"
        '
        'cb_Provincia_mod
        '
        Me.cb_Provincia_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_Provincia_mod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_Provincia_mod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Provincia_mod.FormattingEnabled = True
        Me.cb_Provincia_mod.Location = New System.Drawing.Point(143, 64)
        Me.cb_Provincia_mod.Name = "cb_Provincia_mod"
        Me.cb_Provincia_mod.Size = New System.Drawing.Size(209, 21)
        Me.cb_Provincia_mod.TabIndex = 4
        '
        'lbl_Provincia_mod
        '
        Me.lbl_Provincia_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Provincia_mod.AutoSize = True
        Me.lbl_Provincia_mod.Location = New System.Drawing.Point(3, 68)
        Me.lbl_Provincia_mod.Name = "lbl_Provincia_mod"
        Me.lbl_Provincia_mod.Size = New System.Drawing.Size(134, 13)
        Me.lbl_Provincia_mod.TabIndex = 57
        Me.lbl_Provincia_mod.Text = "Provincia (*)"
        '
        'lbl_Distrito_mod
        '
        Me.lbl_Distrito_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Distrito_mod.AutoSize = True
        Me.lbl_Distrito_mod.Location = New System.Drawing.Point(3, 98)
        Me.lbl_Distrito_mod.Name = "lbl_Distrito_mod"
        Me.lbl_Distrito_mod.Size = New System.Drawing.Size(134, 13)
        Me.lbl_Distrito_mod.TabIndex = 56
        Me.lbl_Distrito_mod.Text = "Partido (*)"
        '
        'txt_Telefono_mod
        '
        Me.txt_Telefono_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Telefono_mod.Location = New System.Drawing.Point(143, 35)
        Me.txt_Telefono_mod.MaxLength = 255
        Me.txt_Telefono_mod.Name = "txt_Telefono_mod"
        Me.txt_Telefono_mod.Size = New System.Drawing.Size(209, 20)
        Me.txt_Telefono_mod.TabIndex = 3
        '
        'lbl_Localidad_mod
        '
        Me.lbl_Localidad_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Localidad_mod.AutoSize = True
        Me.lbl_Localidad_mod.Location = New System.Drawing.Point(3, 128)
        Me.lbl_Localidad_mod.Name = "lbl_Localidad_mod"
        Me.lbl_Localidad_mod.Size = New System.Drawing.Size(134, 13)
        Me.lbl_Localidad_mod.TabIndex = 55
        Me.lbl_Localidad_mod.Text = "Localidad (*)"
        '
        'lbl_Direccion_mod
        '
        Me.lbl_Direccion_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Direccion_mod.AutoSize = True
        Me.lbl_Direccion_mod.Location = New System.Drawing.Point(3, 158)
        Me.lbl_Direccion_mod.Name = "lbl_Direccion_mod"
        Me.lbl_Direccion_mod.Size = New System.Drawing.Size(134, 13)
        Me.lbl_Direccion_mod.TabIndex = 44
        Me.lbl_Direccion_mod.Text = "Direccion (*)"
        '
        'lbl_CodigoPostal_mod
        '
        Me.lbl_CodigoPostal_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_CodigoPostal_mod.AutoSize = True
        Me.lbl_CodigoPostal_mod.Location = New System.Drawing.Point(3, 188)
        Me.lbl_CodigoPostal_mod.Name = "lbl_CodigoPostal_mod"
        Me.lbl_CodigoPostal_mod.Size = New System.Drawing.Size(134, 13)
        Me.lbl_CodigoPostal_mod.TabIndex = 47
        Me.lbl_CodigoPostal_mod.Text = "Código Postal (*)"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TableLayoutPanel10)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(3, 209)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(364, 98)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Comisiones Ventas Mayoristas"
        '
        'txt_ComisionEncargadoMayor_mod
        '
        Me.txt_ComisionEncargadoMayor_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_ComisionEncargadoMayor_mod.Location = New System.Drawing.Point(182, 49)
        Me.txt_ComisionEncargadoMayor_mod.Name = "txt_ComisionEncargadoMayor_mod"
        Me.txt_ComisionEncargadoMayor_mod.Size = New System.Drawing.Size(173, 20)
        Me.txt_ComisionEncargadoMayor_mod.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(173, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Comisión Vendedor (*)"
        '
        'txt_ComisionVendedorMayor_mod
        '
        Me.txt_ComisionVendedorMayor_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_ComisionVendedorMayor_mod.Location = New System.Drawing.Point(182, 9)
        Me.txt_ComisionVendedorMayor_mod.Name = "txt_ComisionVendedorMayor_mod"
        Me.txt_ComisionVendedorMayor_mod.Size = New System.Drawing.Size(173, 20)
        Me.txt_ComisionVendedorMayor_mod.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(173, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Comisión Encargado (*)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 338)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "(*) Campos obligatorios."
        '
        'GB_Sucursal_mod
        '
        Me.GB_Sucursal_mod.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_Sucursal_mod.Controls.Add(Me.TableLayoutPanel7)
        Me.GB_Sucursal_mod.Location = New System.Drawing.Point(3, 3)
        Me.GB_Sucursal_mod.Name = "GB_Sucursal_mod"
        Me.GB_Sucursal_mod.Size = New System.Drawing.Size(370, 298)
        Me.GB_Sucursal_mod.TabIndex = 1
        Me.GB_Sucursal_mod.TabStop = False
        Me.GB_Sucursal_mod.Text = "Información del Establecimiento"
        '
        'txt_CodigoVenta_mod
        '
        Me.txt_CodigoVenta_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_CodigoVenta_mod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_CodigoVenta_mod.Location = New System.Drawing.Point(143, 215)
        Me.txt_CodigoVenta_mod.MaxLength = 2
        Me.txt_CodigoVenta_mod.Name = "txt_CodigoVenta_mod"
        Me.txt_CodigoVenta_mod.Size = New System.Drawing.Size(209, 20)
        Me.txt_CodigoVenta_mod.TabIndex = 58
        '
        'chk_Habilitado_mod
        '
        Me.chk_Habilitado_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chk_Habilitado_mod.AutoSize = True
        Me.chk_Habilitado_mod.Checked = True
        Me.chk_Habilitado_mod.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Habilitado_mod.Location = New System.Drawing.Point(143, 248)
        Me.chk_Habilitado_mod.Name = "chk_Habilitado_mod"
        Me.chk_Habilitado_mod.Size = New System.Drawing.Size(209, 14)
        Me.chk_Habilitado_mod.TabIndex = 9
        Me.chk_Habilitado_mod.UseVisualStyleBackColor = True
        '
        'GB_Comisiones2_mod
        '
        Me.GB_Comisiones2_mod.Controls.Add(Me.TableLayoutPanel9)
        Me.GB_Comisiones2_mod.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GB_Comisiones2_mod.Location = New System.Drawing.Point(3, 106)
        Me.GB_Comisiones2_mod.Name = "GB_Comisiones2_mod"
        Me.GB_Comisiones2_mod.Size = New System.Drawing.Size(364, 97)
        Me.GB_Comisiones2_mod.TabIndex = 13
        Me.GB_Comisiones2_mod.TabStop = False
        Me.GB_Comisiones2_mod.Text = "Comisiones Feriados y Fines de Semana"
        '
        'lbl_ComisionEncargadoFeriado_mod
        '
        Me.lbl_ComisionEncargadoFeriado_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_ComisionEncargadoFeriado_mod.AutoSize = True
        Me.lbl_ComisionEncargadoFeriado_mod.Location = New System.Drawing.Point(3, 52)
        Me.lbl_ComisionEncargadoFeriado_mod.Name = "lbl_ComisionEncargadoFeriado_mod"
        Me.lbl_ComisionEncargadoFeriado_mod.Size = New System.Drawing.Size(173, 13)
        Me.lbl_ComisionEncargadoFeriado_mod.TabIndex = 58
        Me.lbl_ComisionEncargadoFeriado_mod.Text = "Comisión Encargado (*)"
        '
        'txt_ComisionVendedorFeriado_mod
        '
        Me.txt_ComisionVendedorFeriado_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_ComisionVendedorFeriado_mod.Location = New System.Drawing.Point(182, 9)
        Me.txt_ComisionVendedorFeriado_mod.Name = "txt_ComisionVendedorFeriado_mod"
        Me.txt_ComisionVendedorFeriado_mod.Size = New System.Drawing.Size(173, 20)
        Me.txt_ComisionVendedorFeriado_mod.TabIndex = 14
        '
        'lbl_ComisionVendedorFeriado_mod
        '
        Me.lbl_ComisionVendedorFeriado_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_ComisionVendedorFeriado_mod.AutoSize = True
        Me.lbl_ComisionVendedorFeriado_mod.Location = New System.Drawing.Point(3, 13)
        Me.lbl_ComisionVendedorFeriado_mod.Name = "lbl_ComisionVendedorFeriado_mod"
        Me.lbl_ComisionVendedorFeriado_mod.Size = New System.Drawing.Size(173, 13)
        Me.lbl_ComisionVendedorFeriado_mod.TabIndex = 59
        Me.lbl_ComisionVendedorFeriado_mod.Text = "Comisión Vendedor (*)"
        '
        'txt_ComisionEncargadoFeriado_mod
        '
        Me.txt_ComisionEncargadoFeriado_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_ComisionEncargadoFeriado_mod.Location = New System.Drawing.Point(182, 48)
        Me.txt_ComisionEncargadoFeriado_mod.Name = "txt_ComisionEncargadoFeriado_mod"
        Me.txt_ComisionEncargadoFeriado_mod.Size = New System.Drawing.Size(173, 20)
        Me.txt_ComisionEncargadoFeriado_mod.TabIndex = 15
        '
        'GB_Comisiones_mod
        '
        Me.GB_Comisiones_mod.Controls.Add(Me.TableLayoutPanel8)
        Me.GB_Comisiones_mod.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GB_Comisiones_mod.Location = New System.Drawing.Point(3, 3)
        Me.GB_Comisiones_mod.Name = "GB_Comisiones_mod"
        Me.GB_Comisiones_mod.Size = New System.Drawing.Size(364, 97)
        Me.GB_Comisiones_mod.TabIndex = 10
        Me.GB_Comisiones_mod.TabStop = False
        Me.GB_Comisiones_mod.Text = "Comisiones Semanales"
        '
        'lbl_ComisionEncargado_mod
        '
        Me.lbl_ComisionEncargado_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_ComisionEncargado_mod.AutoSize = True
        Me.lbl_ComisionEncargado_mod.Location = New System.Drawing.Point(3, 52)
        Me.lbl_ComisionEncargado_mod.Name = "lbl_ComisionEncargado_mod"
        Me.lbl_ComisionEncargado_mod.Size = New System.Drawing.Size(154, 13)
        Me.lbl_ComisionEncargado_mod.TabIndex = 58
        Me.lbl_ComisionEncargado_mod.Text = "Comisión Encargado (*)"
        '
        'txt_ComisionVendedor_mod
        '
        Me.txt_ComisionVendedor_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_ComisionVendedor_mod.Location = New System.Drawing.Point(163, 9)
        Me.txt_ComisionVendedor_mod.Name = "txt_ComisionVendedor_mod"
        Me.txt_ComisionVendedor_mod.Size = New System.Drawing.Size(192, 20)
        Me.txt_ComisionVendedor_mod.TabIndex = 11
        '
        'lbl_ComisionVendedor_mod
        '
        Me.lbl_ComisionVendedor_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_ComisionVendedor_mod.AutoSize = True
        Me.lbl_ComisionVendedor_mod.Location = New System.Drawing.Point(3, 13)
        Me.lbl_ComisionVendedor_mod.Name = "lbl_ComisionVendedor_mod"
        Me.lbl_ComisionVendedor_mod.Size = New System.Drawing.Size(154, 13)
        Me.lbl_ComisionVendedor_mod.TabIndex = 59
        Me.lbl_ComisionVendedor_mod.Text = "Comisión Vendedor (*)"
        '
        'txt_ComisionEncargado_mod
        '
        Me.txt_ComisionEncargado_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_ComisionEncargado_mod.Location = New System.Drawing.Point(163, 48)
        Me.txt_ComisionEncargado_mod.Name = "txt_ComisionEncargado_mod"
        Me.txt_ComisionEncargado_mod.Size = New System.Drawing.Size(192, 20)
        Me.txt_ComisionEncargado_mod.TabIndex = 12
        '
        'Btn_Eliminar
        '
        Me.Btn_Eliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Eliminar.Image = Global.SistemaCinderella.My.Resources.Recursos.desconectado_32
        Me.Btn_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Eliminar.Location = New System.Drawing.Point(552, 338)
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
        Me.Btn_Modificar.Location = New System.Drawing.Point(658, 338)
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
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.ColumnCount = 2
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.txt_ComisionEncargado_mod, 1, 1)
        Me.TableLayoutPanel8.Controls.Add(Me.txt_ComisionVendedor_mod, 1, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.lbl_ComisionEncargado_mod, 0, 1)
        Me.TableLayoutPanel8.Controls.Add(Me.lbl_ComisionVendedor_mod, 0, 0)
        Me.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 2
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(358, 78)
        Me.TableLayoutPanel8.TabIndex = 22
        '
        'TableLayoutPanel9
        '
        Me.TableLayoutPanel9.ColumnCount = 2
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel9.Controls.Add(Me.txt_ComisionEncargadoFeriado_mod, 1, 1)
        Me.TableLayoutPanel9.Controls.Add(Me.txt_ComisionVendedorFeriado_mod, 1, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.lbl_ComisionEncargadoFeriado_mod, 0, 1)
        Me.TableLayoutPanel9.Controls.Add(Me.lbl_ComisionVendedorFeriado_mod, 0, 0)
        Me.TableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel9.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel9.Name = "TableLayoutPanel9"
        Me.TableLayoutPanel9.RowCount = 2
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel9.Size = New System.Drawing.Size(358, 78)
        Me.TableLayoutPanel9.TabIndex = 22
        '
        'TableLayoutPanel10
        '
        Me.TableLayoutPanel10.ColumnCount = 2
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel10.Controls.Add(Me.txt_ComisionEncargadoMayor_mod, 1, 1)
        Me.TableLayoutPanel10.Controls.Add(Me.Label5, 0, 0)
        Me.TableLayoutPanel10.Controls.Add(Me.txt_ComisionVendedorMayor_mod, 1, 0)
        Me.TableLayoutPanel10.Controls.Add(Me.Label6, 0, 1)
        Me.TableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel10.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel10.Name = "TableLayoutPanel10"
        Me.TableLayoutPanel10.RowCount = 2
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel10.Size = New System.Drawing.Size(358, 79)
        Me.TableLayoutPanel10.TabIndex = 21
        '
        'TableLayoutPanel11
        '
        Me.TableLayoutPanel11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel11.ColumnCount = 1
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel11.Controls.Add(Me.GroupBox2, 0, 2)
        Me.TableLayoutPanel11.Controls.Add(Me.GB_Comisiones2_mod, 0, 1)
        Me.TableLayoutPanel11.Controls.Add(Me.GB_Comisiones_mod, 0, 0)
        Me.TableLayoutPanel11.Location = New System.Drawing.Point(379, 3)
        Me.TableLayoutPanel11.Name = "TableLayoutPanel11"
        Me.TableLayoutPanel11.RowCount = 3
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel11.Size = New System.Drawing.Size(370, 310)
        Me.TableLayoutPanel11.TabIndex = 21
        '
        'TableLayoutPanel12
        '
        Me.TableLayoutPanel12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel12.ColumnCount = 2
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel12.Controls.Add(Me.GB_Sucursal_mod, 0, 0)
        Me.TableLayoutPanel12.Controls.Add(Me.TableLayoutPanel11, 1, 0)
        Me.TableLayoutPanel12.Location = New System.Drawing.Point(6, 19)
        Me.TableLayoutPanel12.Name = "TableLayoutPanel12"
        Me.TableLayoutPanel12.RowCount = 1
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel12.Size = New System.Drawing.Size(752, 316)
        Me.TableLayoutPanel12.TabIndex = 22
        '
        'frmSucursales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 522)
        Me.Controls.Add(Me.TabSucursales)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSucursales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administración de Sucursales"
        Me.TabSucursales.ResumeLayout(False)
        Me.TbListado.ResumeLayout(False)
        CType(Me.DG_Sucursales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TbAlta.ResumeLayout(False)
        Me.GB_Alta.ResumeLayout(False)
        Me.GB_Alta.PerformLayout()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.GB_Sucursal.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.GB_Comisiones.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.GB_Comisiones2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TbMod.ResumeLayout(False)
        Me.GB_Modificacion.ResumeLayout(False)
        Me.GB_Modificacion.PerformLayout()
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel7.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GB_Sucursal_mod.ResumeLayout(False)
        Me.GB_Comisiones2_mod.ResumeLayout(False)
        Me.GB_Comisiones_mod.ResumeLayout(False)
        CType(Me.ErroresSucursal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel8.PerformLayout()
        Me.TableLayoutPanel9.ResumeLayout(False)
        Me.TableLayoutPanel9.PerformLayout()
        Me.TableLayoutPanel10.ResumeLayout(False)
        Me.TableLayoutPanel10.PerformLayout()
        Me.TableLayoutPanel11.ResumeLayout(False)
        Me.TableLayoutPanel12.ResumeLayout(False)
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
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_CodigoVenta As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_CodigoVenta_mod As System.Windows.Forms.TextBox
    Friend WithEvents id_Sucursal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Direccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Telefono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Habilitado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Modificar As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel12 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel11 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel10 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
End Class
