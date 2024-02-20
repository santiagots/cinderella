<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTransporte

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTransporte))
        Me.TabTransporte = New System.Windows.Forms.TabControl()
        Me.TbListado = New System.Windows.Forms.TabPage()
        Me.Paginado = New SistemaCinderella.Paginado()
        Me.FrmTrasporteViewModelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MaskedTextBox3 = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Btn_Buscar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DG_Transporte = New System.Windows.Forms.DataGridView()
        Me.RazonSocialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUITDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HabilitadoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Modificar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TransportesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbAlta = New System.Windows.Forms.TabPage()
        Me.GB_Alta = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.chk_Habilitado = New System.Windows.Forms.CheckBox()
        Me.NuevoTransporteViewModelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Cb_Alt_Localidad = New System.Windows.Forms.ComboBox()
        Me.LocalidadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Cb_Alt_Distrito = New System.Windows.Forms.ComboBox()
        Me.DistritosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Cb_Alt_Provincia = New System.Windows.Forms.ComboBox()
        Me.ProvinciasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_Direccion_Entrega = New System.Windows.Forms.TextBox()
        Me.txt_Cuit_Mod = New System.Windows.Forms.MaskedTextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txt_CodigoPostal_Entrega = New System.Windows.Forms.TextBox()
        Me.Btn_Agregar = New System.Windows.Forms.Button()
        Me.TbMod = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Btn_Modificar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.ModificarTransporteViewModelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Cb_Mod_Localidad = New System.Windows.Forms.ComboBox()
        Me.LocalidadesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Cb_Mod_Distrito = New System.Windows.Forms.ComboBox()
        Me.DistritosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Cb_Mod_Provincia = New System.Windows.Forms.ComboBox()
        Me.ProvinciasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TabTransporte.SuspendLayout()
        Me.TbListado.SuspendLayout()
        CType(Me.FrmTrasporteViewModelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.DG_Transporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransportesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TbAlta.SuspendLayout()
        Me.GB_Alta.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        CType(Me.NuevoTransporteViewModelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocalidadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DistritosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProvinciasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TbMod.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.ModificarTransporteViewModelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocalidadesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DistritosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProvinciasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabTransporte
        '
        Me.TabTransporte.Controls.Add(Me.TbListado)
        Me.TabTransporte.Controls.Add(Me.TbAlta)
        Me.TabTransporte.Controls.Add(Me.TbMod)
        Me.TabTransporte.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabTransporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabTransporte.Location = New System.Drawing.Point(0, 0)
        Me.TabTransporte.Name = "TabTransporte"
        Me.TabTransporte.SelectedIndex = 0
        Me.TabTransporte.Size = New System.Drawing.Size(715, 737)
        Me.TabTransporte.TabIndex = 0
        '
        'TbListado
        '
        Me.TbListado.Controls.Add(Me.Paginado)
        Me.TbListado.Controls.Add(Me.GroupBox1)
        Me.TbListado.Controls.Add(Me.DG_Transporte)
        Me.TbListado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbListado.Location = New System.Drawing.Point(4, 29)
        Me.TbListado.Name = "TbListado"
        Me.TbListado.Padding = New System.Windows.Forms.Padding(3)
        Me.TbListado.Size = New System.Drawing.Size(707, 704)
        Me.TbListado.TabIndex = 0
        Me.TbListado.Text = "Transporte"
        Me.TbListado.UseVisualStyleBackColor = True
        '
        'Paginado
        '
        Me.Paginado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Paginado.DataBindings.Add(New System.Windows.Forms.Binding("TotalElementos", Me.FrmTrasporteViewModelBindingSource, "TotalElementos", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Paginado.Leyenda = "{0} de {1}"
        Me.Paginado.Location = New System.Drawing.Point(3, 678)
        Me.Paginado.Name = "Paginado"
        Me.Paginado.PaginaActual = 1
        Me.Paginado.Size = New System.Drawing.Size(698, 23)
        Me.Paginado.TabIndex = 1
        Me.Paginado.TotalElementos = 0
        '
        'FrmTrasporteViewModelBindingSource
        '
        Me.FrmTrasporteViewModelBindingSource.DataSource = GetType(SistemaCinderella.Formularios.Cliente.frmTrasporteViewModel)
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel3)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(693, 94)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar Transporte"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 6
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.44445!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.44445!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.CheckBox1, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label8, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.MaskedTextBox3, 4, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label7, 3, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Btn_Buscar, 5, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TextBox1, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(687, 75)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'CheckBox1
        '
        Me.CheckBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.FrmTrasporteViewModelBindingSource, "BuscarHabilitado", True))
        Me.CheckBox1.Location = New System.Drawing.Point(88, 33)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 39)
        Me.CheckBox1.TabIndex = 2
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 46)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Habilitado"
        '
        'MaskedTextBox3
        '
        Me.MaskedTextBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaskedTextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmTrasporteViewModelBindingSource, "BuscarCUIT", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N0"))
        Me.MaskedTextBox3.Location = New System.Drawing.Point(386, 5)
        Me.MaskedTextBox3.Mask = "99-99999999-9"
        Me.MaskedTextBox3.Name = "MaskedTextBox3"
        Me.MaskedTextBox3.Size = New System.Drawing.Size(165, 20)
        Me.MaskedTextBox3.TabIndex = 1
        Me.MaskedTextBox3.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(301, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "CUIT"
        '
        'Btn_Buscar
        '
        Me.Btn_Buscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Buscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Buscar.Image = Global.SistemaCinderella.My.Resources.Recursos.IconoBuscar32
        Me.Btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Buscar.Location = New System.Drawing.Point(587, 33)
        Me.Btn_Buscar.Name = "Btn_Buscar"
        Me.Btn_Buscar.Size = New System.Drawing.Size(97, 39)
        Me.Btn_Buscar.TabIndex = 3
        Me.Btn_Buscar.Text = "Buscar"
        Me.Btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Buscar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Razón Social"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmTrasporteViewModelBindingSource, "BuscarRazonSocial", True))
        Me.TextBox1.Location = New System.Drawing.Point(88, 5)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(165, 20)
        Me.TextBox1.TabIndex = 0
        '
        'DG_Transporte
        '
        Me.DG_Transporte.AllowUserToAddRows = False
        Me.DG_Transporte.AllowUserToDeleteRows = False
        Me.DG_Transporte.AllowUserToResizeColumns = False
        Me.DG_Transporte.AllowUserToResizeRows = False
        Me.DG_Transporte.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_Transporte.AutoGenerateColumns = False
        Me.DG_Transporte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_Transporte.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_Transporte.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DG_Transporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Transporte.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RazonSocialDataGridViewTextBoxColumn, Me.CUITDataGridViewTextBoxColumn, Me.HabilitadoDataGridViewCheckBoxColumn, Me.Modificar})
        Me.DG_Transporte.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DG_Transporte.DataSource = Me.TransportesBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DG_Transporte.DefaultCellStyle = DataGridViewCellStyle2
        Me.DG_Transporte.Location = New System.Drawing.Point(3, 106)
        Me.DG_Transporte.MultiSelect = False
        Me.DG_Transporte.Name = "DG_Transporte"
        Me.DG_Transporte.ReadOnly = True
        Me.DG_Transporte.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_Transporte.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DG_Transporte.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DG_Transporte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Transporte.Size = New System.Drawing.Size(698, 567)
        Me.DG_Transporte.TabIndex = 0
        '
        'RazonSocialDataGridViewTextBoxColumn
        '
        Me.RazonSocialDataGridViewTextBoxColumn.DataPropertyName = "RazonSocial"
        Me.RazonSocialDataGridViewTextBoxColumn.HeaderText = "Razón Social"
        Me.RazonSocialDataGridViewTextBoxColumn.Name = "RazonSocialDataGridViewTextBoxColumn"
        Me.RazonSocialDataGridViewTextBoxColumn.ReadOnly = True
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
        'TransportesBindingSource
        '
        Me.TransportesBindingSource.DataMember = "Transportes"
        Me.TransportesBindingSource.DataSource = Me.FrmTrasporteViewModelBindingSource
        '
        'TbAlta
        '
        Me.TbAlta.Controls.Add(Me.GB_Alta)
        Me.TbAlta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbAlta.Location = New System.Drawing.Point(4, 29)
        Me.TbAlta.Name = "TbAlta"
        Me.TbAlta.Padding = New System.Windows.Forms.Padding(3)
        Me.TbAlta.Size = New System.Drawing.Size(707, 704)
        Me.TbAlta.TabIndex = 1
        Me.TbAlta.Text = "Alta de Transporte"
        Me.TbAlta.UseVisualStyleBackColor = True
        '
        'GB_Alta
        '
        Me.GB_Alta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_Alta.Controls.Add(Me.TableLayoutPanel6)
        Me.GB_Alta.Controls.Add(Me.Btn_Agregar)
        Me.GB_Alta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Alta.Location = New System.Drawing.Point(6, 6)
        Me.GB_Alta.Name = "GB_Alta"
        Me.GB_Alta.Size = New System.Drawing.Size(693, 319)
        Me.GB_Alta.TabIndex = 0
        Me.GB_Alta.TabStop = False
        Me.GB_Alta.Text = "Formulario de Alta"
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel6.ColumnCount = 2
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.chk_Habilitado, 1, 7)
        Me.TableLayoutPanel6.Controls.Add(Me.Label10, 0, 7)
        Me.TableLayoutPanel6.Controls.Add(Me.Cb_Alt_Localidad, 1, 5)
        Me.TableLayoutPanel6.Controls.Add(Me.Label30, 0, 6)
        Me.TableLayoutPanel6.Controls.Add(Me.Label25, 0, 2)
        Me.TableLayoutPanel6.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.Label26, 0, 5)
        Me.TableLayoutPanel6.Controls.Add(Me.Cb_Alt_Distrito, 1, 4)
        Me.TableLayoutPanel6.Controls.Add(Me.TextBox10, 1, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.Cb_Alt_Provincia, 1, 3)
        Me.TableLayoutPanel6.Controls.Add(Me.Label27, 0, 4)
        Me.TableLayoutPanel6.Controls.Add(Me.Label4, 0, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.txt_Direccion_Entrega, 1, 2)
        Me.TableLayoutPanel6.Controls.Add(Me.txt_Cuit_Mod, 1, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.Label28, 0, 3)
        Me.TableLayoutPanel6.Controls.Add(Me.txt_CodigoPostal_Entrega, 1, 6)
        Me.TableLayoutPanel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 20)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 8
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(684, 246)
        Me.TableLayoutPanel6.TabIndex = 5
        '
        'chk_Habilitado
        '
        Me.chk_Habilitado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chk_Habilitado.AutoSize = True
        Me.chk_Habilitado.Checked = True
        Me.chk_Habilitado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Habilitado.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.NuevoTransporteViewModelBindingSource, "Habilitado", True))
        Me.chk_Habilitado.Location = New System.Drawing.Point(143, 213)
        Me.chk_Habilitado.Name = "chk_Habilitado"
        Me.chk_Habilitado.Size = New System.Drawing.Size(15, 30)
        Me.chk_Habilitado.TabIndex = 7
        Me.chk_Habilitado.UseVisualStyleBackColor = True
        '
        'NuevoTransporteViewModelBindingSource
        '
        Me.NuevoTransporteViewModelBindingSource.DataSource = GetType(SistemaCinderella.Formularios.Cliente.TransporteViewModel)
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 220)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(134, 15)
        Me.Label10.TabIndex = 104
        Me.Label10.Text = "Habilitado"
        '
        'Cb_Alt_Localidad
        '
        Me.Cb_Alt_Localidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cb_Alt_Localidad.CausesValidation = False
        Me.Cb_Alt_Localidad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cb_Alt_Localidad.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.NuevoTransporteViewModelBindingSource, "LocalidadesSaleccionada", True))
        Me.Cb_Alt_Localidad.DataSource = Me.LocalidadesBindingSource
        Me.Cb_Alt_Localidad.DisplayMember = "Value"
        Me.Cb_Alt_Localidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Alt_Localidad.FormattingEnabled = True
        Me.Cb_Alt_Localidad.Location = New System.Drawing.Point(143, 154)
        Me.Cb_Alt_Localidad.Name = "Cb_Alt_Localidad"
        Me.Cb_Alt_Localidad.Size = New System.Drawing.Size(538, 23)
        Me.Cb_Alt_Localidad.TabIndex = 5
        Me.Cb_Alt_Localidad.ValueMember = "Key"
        '
        'LocalidadesBindingSource
        '
        Me.LocalidadesBindingSource.DataMember = "Localidades"
        Me.LocalidadesBindingSource.DataSource = Me.NuevoTransporteViewModelBindingSource
        '
        'Label30
        '
        Me.Label30.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(3, 187)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(83, 15)
        Me.Label30.TabIndex = 13
        Me.Label30.Text = "Código Postal"
        '
        'Label25
        '
        Me.Label25.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(3, 67)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(59, 15)
        Me.Label25.TabIndex = 11
        Me.Label25.Text = "Dirección"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 15)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Nombre"
        '
        'Label26
        '
        Me.Label26.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(3, 157)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(61, 15)
        Me.Label26.TabIndex = 25
        Me.Label26.Text = "Localidad"
        '
        'Cb_Alt_Distrito
        '
        Me.Cb_Alt_Distrito.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cb_Alt_Distrito.CausesValidation = False
        Me.Cb_Alt_Distrito.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cb_Alt_Distrito.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.NuevoTransporteViewModelBindingSource, "DistritosSaleccionada", True))
        Me.Cb_Alt_Distrito.DataSource = Me.DistritosBindingSource
        Me.Cb_Alt_Distrito.DisplayMember = "Value"
        Me.Cb_Alt_Distrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Alt_Distrito.FormattingEnabled = True
        Me.Cb_Alt_Distrito.Location = New System.Drawing.Point(143, 124)
        Me.Cb_Alt_Distrito.Name = "Cb_Alt_Distrito"
        Me.Cb_Alt_Distrito.Size = New System.Drawing.Size(538, 23)
        Me.Cb_Alt_Distrito.TabIndex = 4
        Me.Cb_Alt_Distrito.ValueMember = "Key"
        '
        'DistritosBindingSource
        '
        Me.DistritosBindingSource.DataMember = "Distritos"
        Me.DistritosBindingSource.DataSource = Me.NuevoTransporteViewModelBindingSource
        '
        'TextBox10
        '
        Me.TextBox10.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NuevoTransporteViewModelBindingSource, "RazonSocial", True))
        Me.TextBox10.Location = New System.Drawing.Point(143, 4)
        Me.TextBox10.MaxLength = 255
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(538, 21)
        Me.TextBox10.TabIndex = 0
        '
        'Cb_Alt_Provincia
        '
        Me.Cb_Alt_Provincia.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cb_Alt_Provincia.CausesValidation = False
        Me.Cb_Alt_Provincia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cb_Alt_Provincia.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.NuevoTransporteViewModelBindingSource, "ProvinciasSaleccionada", True))
        Me.Cb_Alt_Provincia.DataSource = Me.ProvinciasBindingSource
        Me.Cb_Alt_Provincia.DisplayMember = "Value"
        Me.Cb_Alt_Provincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Alt_Provincia.FormattingEnabled = True
        Me.Cb_Alt_Provincia.Location = New System.Drawing.Point(143, 94)
        Me.Cb_Alt_Provincia.Name = "Cb_Alt_Provincia"
        Me.Cb_Alt_Provincia.Size = New System.Drawing.Size(538, 23)
        Me.Cb_Alt_Provincia.TabIndex = 3
        Me.Cb_Alt_Provincia.ValueMember = "Key"
        '
        'ProvinciasBindingSource
        '
        Me.ProvinciasBindingSource.DataMember = "Provincias"
        Me.ProvinciasBindingSource.DataSource = Me.NuevoTransporteViewModelBindingSource
        '
        'Label27
        '
        Me.Label27.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(3, 127)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(45, 15)
        Me.Label27.TabIndex = 26
        Me.Label27.Text = "Distrito"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 15)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "CUIT"
        '
        'txt_Direccion_Entrega
        '
        Me.txt_Direccion_Entrega.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Direccion_Entrega.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NuevoTransporteViewModelBindingSource, "Direccion", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_Direccion_Entrega.Location = New System.Drawing.Point(143, 64)
        Me.txt_Direccion_Entrega.MaxLength = 255
        Me.txt_Direccion_Entrega.Name = "txt_Direccion_Entrega"
        Me.txt_Direccion_Entrega.Size = New System.Drawing.Size(538, 21)
        Me.txt_Direccion_Entrega.TabIndex = 2
        '
        'txt_Cuit_Mod
        '
        Me.txt_Cuit_Mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Cuit_Mod.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NuevoTransporteViewModelBindingSource, "CUIT", True))
        Me.txt_Cuit_Mod.Location = New System.Drawing.Point(143, 34)
        Me.txt_Cuit_Mod.Mask = "99-99999999-9"
        Me.txt_Cuit_Mod.Name = "txt_Cuit_Mod"
        Me.txt_Cuit_Mod.Size = New System.Drawing.Size(538, 21)
        Me.txt_Cuit_Mod.TabIndex = 1
        Me.txt_Cuit_Mod.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Label28
        '
        Me.Label28.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(3, 97)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(57, 15)
        Me.Label28.TabIndex = 27
        Me.Label28.Text = "Provincia"
        '
        'txt_CodigoPostal_Entrega
        '
        Me.txt_CodigoPostal_Entrega.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_CodigoPostal_Entrega.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NuevoTransporteViewModelBindingSource, "CodigoPostal", True))
        Me.txt_CodigoPostal_Entrega.Location = New System.Drawing.Point(143, 184)
        Me.txt_CodigoPostal_Entrega.MaxLength = 255
        Me.txt_CodigoPostal_Entrega.Name = "txt_CodigoPostal_Entrega"
        Me.txt_CodigoPostal_Entrega.Size = New System.Drawing.Size(538, 21)
        Me.txt_CodigoPostal_Entrega.TabIndex = 6
        '
        'Btn_Agregar
        '
        Me.Btn_Agregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Agregar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Agregar.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Btn_Agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Agregar.Image = Global.SistemaCinderella.My.Resources.Recursos.Agregar_24
        Me.Btn_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Agregar.Location = New System.Drawing.Point(587, 273)
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
        Me.TbMod.Size = New System.Drawing.Size(707, 704)
        Me.TbMod.TabIndex = 2
        Me.TbMod.Text = "Modificación de Transporte"
        Me.TbMod.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Btn_Modificar)
        Me.GroupBox2.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(6, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(693, 324)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Modificación de Transporte"
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
        Me.Btn_Modificar.Location = New System.Drawing.Point(586, 276)
        Me.Btn_Modificar.Name = "Btn_Modificar"
        Me.Btn_Modificar.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Modificar.TabIndex = 1
        Me.Btn_Modificar.Text = "Modificar"
        Me.Btn_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Modificar.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.CheckBox3, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Cb_Mod_Localidad, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label14, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label15, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label16, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label17, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Cb_Mod_Distrito, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox3, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cb_Mod_Provincia, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label18, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label19, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox4, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.MaskedTextBox1, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label20, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox5, 1, 6)
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(2, 20)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 8
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(684, 246)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'CheckBox3
        '
        Me.CheckBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Checked = True
        Me.CheckBox3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox3.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.ModificarTransporteViewModelBindingSource, "Habilitado", True))
        Me.CheckBox3.Location = New System.Drawing.Point(143, 213)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(15, 30)
        Me.CheckBox3.TabIndex = 7
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'ModificarTransporteViewModelBindingSource
        '
        Me.ModificarTransporteViewModelBindingSource.DataSource = GetType(SistemaCinderella.Formularios.Cliente.TransporteViewModel)
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 220)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 15)
        Me.Label2.TabIndex = 104
        Me.Label2.Text = "Habilitado"
        '
        'Cb_Mod_Localidad
        '
        Me.Cb_Mod_Localidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cb_Mod_Localidad.CausesValidation = False
        Me.Cb_Mod_Localidad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cb_Mod_Localidad.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ModificarTransporteViewModelBindingSource, "LocalidadesSaleccionada", True))
        Me.Cb_Mod_Localidad.DataSource = Me.LocalidadesBindingSource1
        Me.Cb_Mod_Localidad.DisplayMember = "Value"
        Me.Cb_Mod_Localidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Mod_Localidad.FormattingEnabled = True
        Me.Cb_Mod_Localidad.Location = New System.Drawing.Point(143, 153)
        Me.Cb_Mod_Localidad.Name = "Cb_Mod_Localidad"
        Me.Cb_Mod_Localidad.Size = New System.Drawing.Size(538, 23)
        Me.Cb_Mod_Localidad.TabIndex = 5
        Me.Cb_Mod_Localidad.ValueMember = "Key"
        '
        'LocalidadesBindingSource1
        '
        Me.LocalidadesBindingSource1.DataMember = "Localidades"
        Me.LocalidadesBindingSource1.DataSource = Me.ModificarTransporteViewModelBindingSource
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(3, 187)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(83, 15)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Código Postal"
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(3, 67)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(59, 15)
        Me.Label15.TabIndex = 11
        Me.Label15.Text = "Dirección"
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(3, 7)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(52, 15)
        Me.Label16.TabIndex = 11
        Me.Label16.Text = "Nombre"
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(3, 157)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(61, 15)
        Me.Label17.TabIndex = 25
        Me.Label17.Text = "Localidad"
        '
        'Cb_Mod_Distrito
        '
        Me.Cb_Mod_Distrito.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cb_Mod_Distrito.CausesValidation = False
        Me.Cb_Mod_Distrito.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cb_Mod_Distrito.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ModificarTransporteViewModelBindingSource, "DistritosSaleccionada", True))
        Me.Cb_Mod_Distrito.DataSource = Me.DistritosBindingSource1
        Me.Cb_Mod_Distrito.DisplayMember = "Value"
        Me.Cb_Mod_Distrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Mod_Distrito.FormattingEnabled = True
        Me.Cb_Mod_Distrito.Location = New System.Drawing.Point(143, 123)
        Me.Cb_Mod_Distrito.Name = "Cb_Mod_Distrito"
        Me.Cb_Mod_Distrito.Size = New System.Drawing.Size(538, 23)
        Me.Cb_Mod_Distrito.TabIndex = 4
        Me.Cb_Mod_Distrito.ValueMember = "Key"
        '
        'DistritosBindingSource1
        '
        Me.DistritosBindingSource1.DataMember = "Distritos"
        Me.DistritosBindingSource1.DataSource = Me.ModificarTransporteViewModelBindingSource
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ModificarTransporteViewModelBindingSource, "RazonSocial", True))
        Me.TextBox3.Location = New System.Drawing.Point(143, 4)
        Me.TextBox3.MaxLength = 255
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(538, 21)
        Me.TextBox3.TabIndex = 0
        '
        'Cb_Mod_Provincia
        '
        Me.Cb_Mod_Provincia.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cb_Mod_Provincia.CausesValidation = False
        Me.Cb_Mod_Provincia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cb_Mod_Provincia.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ModificarTransporteViewModelBindingSource, "ProvinciasSaleccionada", True))
        Me.Cb_Mod_Provincia.DataSource = Me.ProvinciasBindingSource1
        Me.Cb_Mod_Provincia.DisplayMember = "Value"
        Me.Cb_Mod_Provincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Mod_Provincia.FormattingEnabled = True
        Me.Cb_Mod_Provincia.Location = New System.Drawing.Point(143, 93)
        Me.Cb_Mod_Provincia.Name = "Cb_Mod_Provincia"
        Me.Cb_Mod_Provincia.Size = New System.Drawing.Size(538, 23)
        Me.Cb_Mod_Provincia.TabIndex = 3
        Me.Cb_Mod_Provincia.ValueMember = "Key"
        '
        'ProvinciasBindingSource1
        '
        Me.ProvinciasBindingSource1.DataMember = "Provincias"
        Me.ProvinciasBindingSource1.DataSource = Me.ModificarTransporteViewModelBindingSource
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(3, 127)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(45, 15)
        Me.Label18.TabIndex = 26
        Me.Label18.Text = "Distrito"
        '
        'Label19
        '
        Me.Label19.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(3, 37)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(34, 15)
        Me.Label19.TabIndex = 31
        Me.Label19.Text = "CUIT"
        '
        'TextBox4
        '
        Me.TextBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ModificarTransporteViewModelBindingSource, "Direccion", True))
        Me.TextBox4.Location = New System.Drawing.Point(143, 64)
        Me.TextBox4.MaxLength = 255
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(538, 21)
        Me.TextBox4.TabIndex = 2
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ModificarTransporteViewModelBindingSource, "CUIT", True))
        Me.MaskedTextBox1.Location = New System.Drawing.Point(143, 34)
        Me.MaskedTextBox1.Mask = "99-99999999-9"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(538, 21)
        Me.MaskedTextBox1.TabIndex = 1
        Me.MaskedTextBox1.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Label20
        '
        Me.Label20.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(3, 97)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(57, 15)
        Me.Label20.TabIndex = 27
        Me.Label20.Text = "Provincia"
        '
        'TextBox5
        '
        Me.TextBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ModificarTransporteViewModelBindingSource, "CodigoPostal", True))
        Me.TextBox5.Location = New System.Drawing.Point(143, 184)
        Me.TextBox5.MaxLength = 255
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(538, 21)
        Me.TextBox5.TabIndex = 6
        '
        'frmTransporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 737)
        Me.Controls.Add(Me.TabTransporte)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTransporte"
        Me.Text = "Administración de Trasnportes"
        Me.TabTransporte.ResumeLayout(False)
        Me.TbListado.ResumeLayout(False)
        CType(Me.FrmTrasporteViewModelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.DG_Transporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransportesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TbAlta.ResumeLayout(False)
        Me.GB_Alta.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        CType(Me.NuevoTransporteViewModelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocalidadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DistritosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProvinciasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TbMod.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.ModificarTransporteViewModelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocalidadesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DistritosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProvinciasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabTransporte As TabControl
    Friend WithEvents TbListado As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Btn_Buscar As Button
    Friend WithEvents DG_Transporte As DataGridView
    Friend WithEvents TbAlta As TabPage
    Friend WithEvents GB_Alta As GroupBox
    Friend WithEvents Btn_Agregar As Button
    Friend WithEvents TbMod As TabPage
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_Cuit_Mod As MaskedTextBox
    Friend WithEvents Cb_Alt_Localidad As ComboBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Cb_Alt_Distrito As ComboBox
    Friend WithEvents Cb_Alt_Provincia As ComboBox
    Friend WithEvents Label27 As Label
    Friend WithEvents txt_Direccion_Entrega As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Btn_Modificar As Button
    Friend WithEvents Label30 As Label
    Friend WithEvents txt_CodigoPostal_Entrega As TextBox
    Friend WithEvents chk_Habilitado As CheckBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Cb_Mod_Localidad As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Cb_Mod_Distrito As ComboBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Cb_Mod_Provincia As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label8 As Label
    Friend WithEvents MaskedTextBox3 As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents FrmTrasporteViewModelBindingSource As BindingSource
    Friend WithEvents TransportesBindingSource As BindingSource
    Friend WithEvents LocalidadesBindingSource As BindingSource
    Friend WithEvents DistritosBindingSource As BindingSource
    Friend WithEvents NuevoTransporteViewModelBindingSource As BindingSource
    Friend WithEvents ProvinciasBindingSource As BindingSource
    Friend WithEvents ModificarTransporteViewModelBindingSource As BindingSource
    Friend WithEvents LocalidadesBindingSource1 As BindingSource
    Friend WithEvents DistritosBindingSource1 As BindingSource
    Friend WithEvents ProvinciasBindingSource1 As BindingSource
    Friend WithEvents Paginado As Paginado
    Friend WithEvents RazonSocialDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CUITDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HabilitadoDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents Modificar As DataGridViewImageColumn
End Class
