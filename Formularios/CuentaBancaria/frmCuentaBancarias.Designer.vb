<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCuentaBancarias

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCuentaBancarias))
        Me.TabCuentasBancarias = New System.Windows.Forms.TabControl()
        Me.TbListado = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.FrmCuentaBancariasViewModelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HabilitadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.BancosBusquedaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.DG_CuentasBancarias = New System.Windows.Forms.DataGridView()
        Me.TbAlta = New System.Windows.Forms.TabPage()
        Me.GB_Alta = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.MaskedTextBox5 = New System.Windows.Forms.MaskedTextBox()
        Me.AltaCuentaBancariaViewModelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MaskedTextBox4 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_descripcion = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Btn_Agregar_Banco = New System.Windows.Forms.Button()
        Me.cbBancoAlta = New System.Windows.Forms.ComboBox()
        Me.BancosAltaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Btn_Agregar = New System.Windows.Forms.Button()
        Me.TbMod = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.MaskedTextBox6 = New System.Windows.Forms.MaskedTextBox()
        Me.ModificacionCuentaBancariaViewModelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MaskedTextBox3 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.Btn_Agregar_Banco2 = New System.Windows.Forms.Button()
        Me.cbBancoModificacion = New System.Windows.Forms.ComboBox()
        Me.BancosModificacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Btn_Modificar = New System.Windows.Forms.Button()
        Me.CuentasBancariasListadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BancoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CBUDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CBUAliasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitularDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUITDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EsCuentaCorrienteDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.HabilitadoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Modificar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TabCuentasBancarias.SuspendLayout()
        Me.TbListado.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.FrmCuentaBancariasViewModelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HabilitadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BancosBusquedaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_CuentasBancarias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TbAlta.SuspendLayout()
        Me.GB_Alta.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.AltaCuentaBancariaViewModelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.BancosAltaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TbMod.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.ModificacionCuentaBancariaViewModelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel5.SuspendLayout()
        CType(Me.BancosModificacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuentasBancariasListadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabCuentasBancarias
        '
        Me.TabCuentasBancarias.Controls.Add(Me.TbListado)
        Me.TabCuentasBancarias.Controls.Add(Me.TbAlta)
        Me.TabCuentasBancarias.Controls.Add(Me.TbMod)
        Me.TabCuentasBancarias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabCuentasBancarias.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabCuentasBancarias.Location = New System.Drawing.Point(0, 0)
        Me.TabCuentasBancarias.Name = "TabCuentasBancarias"
        Me.TabCuentasBancarias.SelectedIndex = 0
        Me.TabCuentasBancarias.Size = New System.Drawing.Size(715, 611)
        Me.TabCuentasBancarias.TabIndex = 0
        '
        'TbListado
        '
        Me.TbListado.Controls.Add(Me.GroupBox1)
        Me.TbListado.Controls.Add(Me.DG_CuentasBancarias)
        Me.TbListado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbListado.Location = New System.Drawing.Point(4, 29)
        Me.TbListado.Name = "TbListado"
        Me.TbListado.Padding = New System.Windows.Forms.Padding(3)
        Me.TbListado.Size = New System.Drawing.Size(707, 578)
        Me.TbListado.TabIndex = 0
        Me.TbListado.Text = "Cuentas"
        Me.TbListado.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel3)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(698, 65)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar Cuenta"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 6
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.44445!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.44445!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 173.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.ComboBox2, 4, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.ComboBox1, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label9, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label7, 3, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnBuscar, 5, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(692, 46)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'ComboBox2
        '
        Me.ComboBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.FrmCuentaBancariasViewModelBindingSource, "HabilitadosSeleccionado", True))
        Me.ComboBox2.DataSource = Me.HabilitadosBindingSource
        Me.ComboBox2.DisplayMember = "Value"
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(356, 12)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(157, 21)
        Me.ComboBox2.TabIndex = 1
        Me.ComboBox2.ValueMember = "Key"
        '
        'FrmCuentaBancariasViewModelBindingSource
        '
        Me.FrmCuentaBancariasViewModelBindingSource.DataSource = GetType(SistemaCinderella.Formularios.CuentaBancaria.frmCuentaBancariasViewModel)
        '
        'HabilitadosBindingSource
        '
        Me.HabilitadosBindingSource.DataMember = "Habilitados"
        Me.HabilitadosBindingSource.DataSource = Me.FrmCuentaBancariasViewModelBindingSource
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.FrmCuentaBancariasViewModelBindingSource, "BancoBusquedaSeleccionado", True))
        Me.ComboBox1.DataSource = Me.BancosBusquedaBindingSource
        Me.ComboBox1.DisplayMember = "Value"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(78, 12)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(157, 21)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.ValueMember = "Key"
        '
        'BancosBusquedaBindingSource
        '
        Me.BancosBusquedaBindingSource.DataMember = "BancosBusqueda"
        Me.BancosBusquedaBindingSource.DataSource = Me.FrmCuentaBancariasViewModelBindingSource
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Banco"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(281, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Habilitado"
        '
        'btnBuscar
        '
        Me.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Image = Global.SistemaCinderella.My.Resources.Recursos.IconoBuscar32
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(592, 4)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(97, 38)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'DG_CuentasBancarias
        '
        Me.DG_CuentasBancarias.AllowUserToAddRows = False
        Me.DG_CuentasBancarias.AllowUserToDeleteRows = False
        Me.DG_CuentasBancarias.AllowUserToResizeColumns = False
        Me.DG_CuentasBancarias.AllowUserToResizeRows = False
        Me.DG_CuentasBancarias.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_CuentasBancarias.AutoGenerateColumns = False
        Me.DG_CuentasBancarias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_CuentasBancarias.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DG_CuentasBancarias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_CuentasBancarias.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DG_CuentasBancarias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_CuentasBancarias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BancoDataGridViewTextBoxColumn, Me.CBUDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn1, Me.CBUAliasDataGridViewTextBoxColumn, Me.TitularDataGridViewTextBoxColumn, Me.CUITDataGridViewTextBoxColumn, Me.EsCuentaCorrienteDataGridViewCheckBoxColumn, Me.HabilitadoDataGridViewCheckBoxColumn, Me.Modificar})
        Me.DG_CuentasBancarias.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DG_CuentasBancarias.DataSource = Me.CuentasBancariasListadoBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DG_CuentasBancarias.DefaultCellStyle = DataGridViewCellStyle2
        Me.DG_CuentasBancarias.Location = New System.Drawing.Point(3, 77)
        Me.DG_CuentasBancarias.MultiSelect = False
        Me.DG_CuentasBancarias.Name = "DG_CuentasBancarias"
        Me.DG_CuentasBancarias.ReadOnly = True
        Me.DG_CuentasBancarias.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_CuentasBancarias.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DG_CuentasBancarias.RowHeadersVisible = False
        Me.DG_CuentasBancarias.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DG_CuentasBancarias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_CuentasBancarias.Size = New System.Drawing.Size(698, 470)
        Me.DG_CuentasBancarias.TabIndex = 1
        '
        'TbAlta
        '
        Me.TbAlta.Controls.Add(Me.GB_Alta)
        Me.TbAlta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbAlta.Location = New System.Drawing.Point(4, 29)
        Me.TbAlta.Name = "TbAlta"
        Me.TbAlta.Padding = New System.Windows.Forms.Padding(3)
        Me.TbAlta.Size = New System.Drawing.Size(707, 578)
        Me.TbAlta.TabIndex = 1
        Me.TbAlta.Text = "Alta de Cuentas"
        Me.TbAlta.UseVisualStyleBackColor = True
        '
        'GB_Alta
        '
        Me.GB_Alta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_Alta.Controls.Add(Me.TableLayoutPanel1)
        Me.GB_Alta.Controls.Add(Me.Btn_Agregar)
        Me.GB_Alta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Alta.Location = New System.Drawing.Point(6, 6)
        Me.GB_Alta.Name = "GB_Alta"
        Me.GB_Alta.Size = New System.Drawing.Size(695, 325)
        Me.GB_Alta.TabIndex = 0
        Me.GB_Alta.TabStop = False
        Me.GB_Alta.Text = "Formulario de Alta"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.MaskedTextBox5, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.MaskedTextBox4, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.MaskedTextBox1, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_descripcion, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label15, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.CheckBox3, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label14, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox4, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox3, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(6, 20)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(683, 253)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'MaskedTextBox5
        '
        Me.MaskedTextBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaskedTextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AltaCuentaBancariaViewModelBindingSource, "NumeroCuenta", True))
        Me.MaskedTextBox5.Location = New System.Drawing.Point(207, 82)
        Me.MaskedTextBox5.Mask = "99999-999999/9"
        Me.MaskedTextBox5.Name = "MaskedTextBox5"
        Me.MaskedTextBox5.Size = New System.Drawing.Size(473, 21)
        Me.MaskedTextBox5.TabIndex = 1
        '
        'AltaCuentaBancariaViewModelBindingSource
        '
        Me.AltaCuentaBancariaViewModelBindingSource.DataSource = GetType(SistemaCinderella.Formularios.CuentaBancaria.CuentaBancariaViewModel)
        '
        'MaskedTextBox4
        '
        Me.MaskedTextBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaskedTextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AltaCuentaBancariaViewModelBindingSource, "CBU", True))
        Me.MaskedTextBox4.Location = New System.Drawing.Point(207, 47)
        Me.MaskedTextBox4.Mask = "9999999999999999999999"
        Me.MaskedTextBox4.Name = "MaskedTextBox4"
        Me.MaskedTextBox4.Size = New System.Drawing.Size(473, 21)
        Me.MaskedTextBox4.TabIndex = 0
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AltaCuentaBancariaViewModelBindingSource, "CUIT", True))
        Me.MaskedTextBox1.Location = New System.Drawing.Point(207, 187)
        Me.MaskedTextBox1.Mask = "99-99999999-9"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(473, 21)
        Me.MaskedTextBox1.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(198, 15)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Nro. Cuenta  (*)"
        '
        'lbl_descripcion
        '
        Me.lbl_descripcion.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_descripcion.AutoSize = True
        Me.lbl_descripcion.Location = New System.Drawing.Point(3, 50)
        Me.lbl_descripcion.Name = "lbl_descripcion"
        Me.lbl_descripcion.Size = New System.Drawing.Size(198, 15)
        Me.lbl_descripcion.TabIndex = 1
        Me.lbl_descripcion.Text = "CBU (*)"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Banco (*)"
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(3, 226)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(198, 15)
        Me.Label15.TabIndex = 11
        Me.Label15.Text = "Es Cuenta Corriente"
        '
        'CheckBox3
        '
        Me.CheckBox3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.AltaCuentaBancariaViewModelBindingSource, "EsCuentaCorriente", True))
        Me.CheckBox3.Location = New System.Drawing.Point(207, 227)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox3.TabIndex = 5
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(3, 190)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(198, 15)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = "CUIT  (*)"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(198, 15)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Titular  (*)"
        '
        'TextBox4
        '
        Me.TextBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AltaCuentaBancariaViewModelBindingSource, "Titular", True))
        Me.TextBox4.Location = New System.Drawing.Point(207, 152)
        Me.TextBox4.MaxLength = 255
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(473, 21)
        Me.TextBox4.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(198, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Alias  (*)"
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AltaCuentaBancariaViewModelBindingSource, "CBUAlias", True))
        Me.TextBox3.Location = New System.Drawing.Point(207, 117)
        Me.TextBox3.MaxLength = 255
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(473, 21)
        Me.TextBox3.TabIndex = 2
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.Btn_Agregar_Banco, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.cbBancoAlta, 0, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(207, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(473, 34)
        Me.TableLayoutPanel4.TabIndex = 12
        '
        'Btn_Agregar_Banco
        '
        Me.Btn_Agregar_Banco.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btn_Agregar_Banco.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Agregar_Banco.Image = Global.SistemaCinderella.My.Resources.Recursos.banco
        Me.Btn_Agregar_Banco.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Agregar_Banco.Location = New System.Drawing.Point(382, 3)
        Me.Btn_Agregar_Banco.Name = "Btn_Agregar_Banco"
        Me.Btn_Agregar_Banco.Size = New System.Drawing.Size(81, 28)
        Me.Btn_Agregar_Banco.TabIndex = 1
        Me.Btn_Agregar_Banco.Text = "Agregar"
        Me.Btn_Agregar_Banco.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Agregar_Banco.UseVisualStyleBackColor = True
        '
        'cbBancoAlta
        '
        Me.cbBancoAlta.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbBancoAlta.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.AltaCuentaBancariaViewModelBindingSource, "BancoSeleccionado", True))
        Me.cbBancoAlta.DataSource = Me.BancosAltaBindingSource
        Me.cbBancoAlta.DisplayMember = "Value"
        Me.cbBancoAlta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBancoAlta.FormattingEnabled = True
        Me.cbBancoAlta.Location = New System.Drawing.Point(3, 6)
        Me.cbBancoAlta.Name = "cbBancoAlta"
        Me.cbBancoAlta.Size = New System.Drawing.Size(367, 23)
        Me.cbBancoAlta.TabIndex = 0
        Me.cbBancoAlta.ValueMember = "Key"
        '
        'BancosAltaBindingSource
        '
        Me.BancosAltaBindingSource.DataMember = "Bancos"
        Me.BancosAltaBindingSource.DataSource = Me.AltaCuentaBancariaViewModelBindingSource
        '
        'Btn_Agregar
        '
        Me.Btn_Agregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Agregar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Agregar.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Btn_Agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Agregar.Image = Global.SistemaCinderella.My.Resources.Recursos.Agregar_24
        Me.Btn_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Agregar.Location = New System.Drawing.Point(586, 279)
        Me.Btn_Agregar.Name = "Btn_Agregar"
        Me.Btn_Agregar.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Agregar.TabIndex = 0
        Me.Btn_Agregar.Text = "Agregar"
        Me.Btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Agregar.UseVisualStyleBackColor = False
        '
        'TbMod
        '
        Me.TbMod.Controls.Add(Me.GroupBox2)
        Me.TbMod.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbMod.Location = New System.Drawing.Point(4, 29)
        Me.TbMod.Name = "TbMod"
        Me.TbMod.Size = New System.Drawing.Size(707, 578)
        Me.TbMod.TabIndex = 2
        Me.TbMod.Text = "Modificación de Cuentas"
        Me.TbMod.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox2.Controls.Add(Me.Btn_Modificar)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(4, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(695, 360)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Formulario de Modificación"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.MaskedTextBox6, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.MaskedTextBox3, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.MaskedTextBox2, 1, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.Label8, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label10, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label16, 0, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.Label13, 0, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.Label12, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.Label11, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.CheckBox2, 1, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.CheckBox4, 1, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBox8, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBox7, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel5, 1, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(6, 20)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 8
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(683, 288)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'MaskedTextBox6
        '
        Me.MaskedTextBox6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaskedTextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ModificacionCuentaBancariaViewModelBindingSource, "NumeroCuenta", True))
        Me.MaskedTextBox6.Location = New System.Drawing.Point(207, 82)
        Me.MaskedTextBox6.Mask = "99999-999999/9"
        Me.MaskedTextBox6.Name = "MaskedTextBox6"
        Me.MaskedTextBox6.Size = New System.Drawing.Size(473, 21)
        Me.MaskedTextBox6.TabIndex = 2
        '
        'ModificacionCuentaBancariaViewModelBindingSource
        '
        Me.ModificacionCuentaBancariaViewModelBindingSource.DataSource = GetType(SistemaCinderella.Formularios.CuentaBancaria.CuentaBancariaViewModel)
        '
        'MaskedTextBox3
        '
        Me.MaskedTextBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaskedTextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ModificacionCuentaBancariaViewModelBindingSource, "CBU", True))
        Me.MaskedTextBox3.Location = New System.Drawing.Point(207, 47)
        Me.MaskedTextBox3.Mask = "9999999999999999999999"
        Me.MaskedTextBox3.Name = "MaskedTextBox3"
        Me.MaskedTextBox3.Size = New System.Drawing.Size(473, 21)
        Me.MaskedTextBox3.TabIndex = 1
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaskedTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ModificacionCuentaBancariaViewModelBindingSource, "CUIT", True))
        Me.MaskedTextBox2.Location = New System.Drawing.Point(207, 187)
        Me.MaskedTextBox2.Mask = "99-99999999-9"
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(473, 21)
        Me.MaskedTextBox2.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 85)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(198, 15)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Nro. Cuenta  (*)"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(198, 15)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "CBU  (*)"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(198, 15)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Banco  (*)"
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(3, 261)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(198, 15)
        Me.Label16.TabIndex = 14
        Me.Label16.Text = "Habilitado"
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(3, 225)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(198, 15)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Es Cuenta Corriente"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 190)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(198, 15)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "CUIT  (*)"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 155)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(198, 15)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Titular  (*)"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(198, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Alias  (*)"
        '
        'CheckBox2
        '
        Me.CheckBox2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.ModificacionCuentaBancariaViewModelBindingSource, "Habilitado", True))
        Me.CheckBox2.Location = New System.Drawing.Point(207, 262)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox2.TabIndex = 7
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.ModificacionCuentaBancariaViewModelBindingSource, "EsCuentaCorriente", True))
        Me.CheckBox4.Location = New System.Drawing.Point(207, 225)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox4.TabIndex = 6
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'TextBox8
        '
        Me.TextBox8.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ModificacionCuentaBancariaViewModelBindingSource, "Titular", True))
        Me.TextBox8.Location = New System.Drawing.Point(207, 152)
        Me.TextBox8.MaxLength = 255
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(473, 21)
        Me.TextBox8.TabIndex = 4
        '
        'TextBox7
        '
        Me.TextBox7.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ModificacionCuentaBancariaViewModelBindingSource, "CBUAlias", True))
        Me.TextBox7.Location = New System.Drawing.Point(207, 117)
        Me.TextBox7.MaxLength = 255
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(473, 21)
        Me.TextBox7.TabIndex = 3
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.Btn_Agregar_Banco2, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.cbBancoModificacion, 0, 0)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(207, 3)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(473, 34)
        Me.TableLayoutPanel5.TabIndex = 0
        '
        'Btn_Agregar_Banco2
        '
        Me.Btn_Agregar_Banco2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btn_Agregar_Banco2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Agregar_Banco2.Image = Global.SistemaCinderella.My.Resources.Recursos.banco
        Me.Btn_Agregar_Banco2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Agregar_Banco2.Location = New System.Drawing.Point(382, 3)
        Me.Btn_Agregar_Banco2.Name = "Btn_Agregar_Banco2"
        Me.Btn_Agregar_Banco2.Size = New System.Drawing.Size(81, 28)
        Me.Btn_Agregar_Banco2.TabIndex = 1
        Me.Btn_Agregar_Banco2.Text = "Agregar"
        Me.Btn_Agregar_Banco2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Agregar_Banco2.UseVisualStyleBackColor = True
        '
        'cbBancoModificacion
        '
        Me.cbBancoModificacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbBancoModificacion.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.ModificacionCuentaBancariaViewModelBindingSource, "BancoSeleccionado", True))
        Me.cbBancoModificacion.DataSource = Me.BancosModificacionBindingSource
        Me.cbBancoModificacion.DisplayMember = "Value"
        Me.cbBancoModificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBancoModificacion.FormattingEnabled = True
        Me.cbBancoModificacion.Location = New System.Drawing.Point(3, 6)
        Me.cbBancoModificacion.Name = "cbBancoModificacion"
        Me.cbBancoModificacion.Size = New System.Drawing.Size(367, 23)
        Me.cbBancoModificacion.TabIndex = 0
        Me.cbBancoModificacion.ValueMember = "Key"
        '
        'BancosModificacionBindingSource
        '
        Me.BancosModificacionBindingSource.DataMember = "Bancos"
        Me.BancosModificacionBindingSource.DataSource = Me.ModificacionCuentaBancariaViewModelBindingSource
        '
        'Btn_Modificar
        '
        Me.Btn_Modificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Modificar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Modificar.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Btn_Modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Modificar.Image = Global.SistemaCinderella.My.Resources.Recursos.Editar_24
        Me.Btn_Modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Modificar.Location = New System.Drawing.Point(586, 314)
        Me.Btn_Modificar.Name = "Btn_Modificar"
        Me.Btn_Modificar.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Modificar.TabIndex = 0
        Me.Btn_Modificar.Text = "Modificar"
        Me.Btn_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Modificar.UseVisualStyleBackColor = False
        '
        'CuentasBancariasListadoBindingSource
        '
        Me.CuentasBancariasListadoBindingSource.DataMember = "CuentasBancariasListado"
        Me.CuentasBancariasListadoBindingSource.DataSource = Me.FrmCuentaBancariasViewModelBindingSource
        '
        'BancoDataGridViewTextBoxColumn
        '
        Me.BancoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.BancoDataGridViewTextBoxColumn.DataPropertyName = "Banco"
        Me.BancoDataGridViewTextBoxColumn.HeaderText = "Banco"
        Me.BancoDataGridViewTextBoxColumn.Name = "BancoDataGridViewTextBoxColumn"
        Me.BancoDataGridViewTextBoxColumn.ReadOnly = True
        Me.BancoDataGridViewTextBoxColumn.Width = 63
        '
        'CBUDataGridViewTextBoxColumn
        '
        Me.CBUDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CBUDataGridViewTextBoxColumn.DataPropertyName = "CBU"
        Me.CBUDataGridViewTextBoxColumn.HeaderText = "CBU"
        Me.CBUDataGridViewTextBoxColumn.Name = "CBUDataGridViewTextBoxColumn"
        Me.CBUDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NumeroCuenta"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nro. Cuenta"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 89
        '
        'CBUAliasDataGridViewTextBoxColumn
        '
        Me.CBUAliasDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CBUAliasDataGridViewTextBoxColumn.DataPropertyName = "CBUAlias"
        Me.CBUAliasDataGridViewTextBoxColumn.HeaderText = "Alias"
        Me.CBUAliasDataGridViewTextBoxColumn.Name = "CBUAliasDataGridViewTextBoxColumn"
        Me.CBUAliasDataGridViewTextBoxColumn.ReadOnly = True
        Me.CBUAliasDataGridViewTextBoxColumn.Width = 54
        '
        'TitularDataGridViewTextBoxColumn
        '
        Me.TitularDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TitularDataGridViewTextBoxColumn.DataPropertyName = "Titular"
        Me.TitularDataGridViewTextBoxColumn.HeaderText = "Titular"
        Me.TitularDataGridViewTextBoxColumn.Name = "TitularDataGridViewTextBoxColumn"
        Me.TitularDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CUITDataGridViewTextBoxColumn
        '
        Me.CUITDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CUITDataGridViewTextBoxColumn.DataPropertyName = "CUIT"
        Me.CUITDataGridViewTextBoxColumn.HeaderText = "CUIT"
        Me.CUITDataGridViewTextBoxColumn.Name = "CUITDataGridViewTextBoxColumn"
        Me.CUITDataGridViewTextBoxColumn.ReadOnly = True
        Me.CUITDataGridViewTextBoxColumn.Width = 57
        '
        'EsCuentaCorrienteDataGridViewCheckBoxColumn
        '
        Me.EsCuentaCorrienteDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.EsCuentaCorrienteDataGridViewCheckBoxColumn.DataPropertyName = "EsCuentaCorriente"
        Me.EsCuentaCorrienteDataGridViewCheckBoxColumn.FalseValue = ""
        Me.EsCuentaCorrienteDataGridViewCheckBoxColumn.HeaderText = "Cta. Cte."
        Me.EsCuentaCorrienteDataGridViewCheckBoxColumn.Name = "EsCuentaCorrienteDataGridViewCheckBoxColumn"
        Me.EsCuentaCorrienteDataGridViewCheckBoxColumn.ReadOnly = True
        Me.EsCuentaCorrienteDataGridViewCheckBoxColumn.TrueValue = ""
        Me.EsCuentaCorrienteDataGridViewCheckBoxColumn.Width = 54
        '
        'HabilitadoDataGridViewCheckBoxColumn
        '
        Me.HabilitadoDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.HabilitadoDataGridViewCheckBoxColumn.DataPropertyName = "Habilitado"
        Me.HabilitadoDataGridViewCheckBoxColumn.HeaderText = "Habilitado"
        Me.HabilitadoDataGridViewCheckBoxColumn.Name = "HabilitadoDataGridViewCheckBoxColumn"
        Me.HabilitadoDataGridViewCheckBoxColumn.ReadOnly = True
        Me.HabilitadoDataGridViewCheckBoxColumn.Width = 60
        '
        'Modificar
        '
        Me.Modificar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Modificar.FillWeight = 60.34863!
        Me.Modificar.HeaderText = ""
        Me.Modificar.Image = Global.SistemaCinderella.My.Resources.Recursos.Boton_Editar
        Me.Modificar.Name = "Modificar"
        Me.Modificar.ReadOnly = True
        Me.Modificar.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Modificar.Width = 5
        '
        'frmCuentaBancarias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 611)
        Me.Controls.Add(Me.TabCuentasBancarias)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCuentaBancarias"
        Me.Text = "Administración de Cuentas Bancarias"
        Me.TabCuentasBancarias.ResumeLayout(False)
        Me.TbListado.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.FrmCuentaBancariasViewModelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HabilitadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BancosBusquedaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_CuentasBancarias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TbAlta.ResumeLayout(False)
        Me.GB_Alta.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.AltaCuentaBancariaViewModelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel4.ResumeLayout(False)
        CType(Me.BancosAltaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TbMod.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.ModificacionCuentaBancariaViewModelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel5.ResumeLayout(False)
        CType(Me.BancosModificacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuentasBancariasListadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabCuentasBancarias As TabControl
    Friend WithEvents TbListado As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents btnBuscar As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DG_CuentasBancarias As DataGridView
    Friend WithEvents TbAlta As TabPage
    Friend WithEvents GB_Alta As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents cbBancoAlta As ComboBox
    Friend WithEvents lbl_descripcion As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_Agregar As Button
    Friend WithEvents TbMod As TabPage
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label16 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbBancoModificacion As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents Btn_Modificar As Button
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents NumeroCuentaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FrmCuentaBancariasViewModelBindingSource As BindingSource
    Friend WithEvents BancosBusquedaBindingSource As BindingSource
    Friend WithEvents AltaCuentaBancariaViewModelBindingSource As BindingSource
    Friend WithEvents BancosAltaBindingSource As BindingSource
    Friend WithEvents ModificacionCuentaBancariaViewModelBindingSource As BindingSource
    Friend WithEvents BancosModificacionBindingSource As BindingSource
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents MaskedTextBox2 As MaskedTextBox
    Friend WithEvents MaskedTextBox5 As MaskedTextBox
    Friend WithEvents MaskedTextBox4 As MaskedTextBox
    Friend WithEvents MaskedTextBox6 As MaskedTextBox
    Friend WithEvents MaskedTextBox3 As MaskedTextBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents HabilitadosBindingSource As BindingSource
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Btn_Agregar_Banco As Button
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents Btn_Agregar_Banco2 As Button
    Friend WithEvents CuentasBancariasListadoBindingSource As BindingSource
    Friend WithEvents BancoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CBUDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CBUAliasDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TitularDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CUITDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EsCuentaCorrienteDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents HabilitadoDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents Modificar As DataGridViewImageColumn
End Class
