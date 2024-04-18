<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmComexOrdenCompraAdministracion

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmComexOrdenCompraAdministracion))
        Me.lbl_Msg = New System.Windows.Forms.Label()
        Me.FrmComexOrdenCompraAdministracionViewModelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Paginado = New SistemaCinderella.Paginado()
        Me.DG_OrdenCompra = New System.Windows.Forms.DataGridView()
        Me.Numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SucursalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TerminosDePagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PenalidadesPorDemoraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDeEnvioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrdenesCompraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.SuppliersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.EstadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.FDesde = New System.Windows.Forms.DateTimePicker()
        Me.FHasta = New System.Windows.Forms.DateTimePicker()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_numero = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cb_Encargado = New System.Windows.Forms.ComboBox()
        Me.EncargadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CB_Supplier = New System.Windows.Forms.ComboBox()
        Me.SucursalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnFiltrar = New System.Windows.Forms.Button()
        Me.btn_Restablecer = New System.Windows.Forms.Button()
        CType(Me.FrmComexOrdenCompraAdministracionViewModelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DG_OrdenCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdenesCompraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.SuppliersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel8.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.EncargadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SucursalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_Msg
        '
        Me.lbl_Msg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Msg.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lbl_Msg.DataBindings.Add(New System.Windows.Forms.Binding("Visible", Me.FrmComexOrdenCompraAdministracionViewModelBindingSource, "SinResultados", True))
        Me.lbl_Msg.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Msg.Location = New System.Drawing.Point(9, 211)
        Me.lbl_Msg.Name = "lbl_Msg"
        Me.lbl_Msg.Size = New System.Drawing.Size(909, 125)
        Me.lbl_Msg.TabIndex = 2
        Me.lbl_Msg.Text = "No se han encontrado ordenes."
        Me.lbl_Msg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmComexOrdenCompraAdministracionViewModelBindingSource
        '
        Me.FrmComexOrdenCompraAdministracionViewModelBindingSource.DataSource = GetType(SistemaCinderella.Formularios.Comex.frmComexOrdenCompraAdministracionViewModel)
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Paginado)
        Me.GroupBox2.Controls.Add(Me.lbl_Msg)
        Me.GroupBox2.Controls.Add(Me.DG_OrdenCompra)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 192)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(930, 533)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ordenes"
        '
        'Paginado
        '
        Me.Paginado.DataBindings.Add(New System.Windows.Forms.Binding("TotalElementos", Me.FrmComexOrdenCompraAdministracionViewModelBindingSource, "TotalElementos", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Paginado.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Paginado.Leyenda = "{0} de {1}"
        Me.Paginado.Location = New System.Drawing.Point(3, 503)
        Me.Paginado.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Paginado.Name = "Paginado"
        Me.Paginado.PaginaActual = 1
        Me.Paginado.Size = New System.Drawing.Size(924, 27)
        Me.Paginado.TabIndex = 23
        Me.Paginado.TotalElementos = 0
        '
        'DG_OrdenCompra
        '
        Me.DG_OrdenCompra.AllowUserToAddRows = False
        Me.DG_OrdenCompra.AllowUserToDeleteRows = False
        Me.DG_OrdenCompra.AllowUserToResizeColumns = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DG_OrdenCompra.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DG_OrdenCompra.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_OrdenCompra.AutoGenerateColumns = False
        Me.DG_OrdenCompra.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Numero, Me.SucursalDataGridViewTextBoxColumn, Me.UsuarioDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn, Me.SupplierDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.TerminosDePagoDataGridViewTextBoxColumn, Me.PenalidadesPorDemoraDataGridViewTextBoxColumn, Me.FechaDeEnvioDataGridViewTextBoxColumn})
        Me.DG_OrdenCompra.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DG_OrdenCompra.DataSource = Me.OrdenesCompraBindingSource
        Me.DG_OrdenCompra.Location = New System.Drawing.Point(3, 17)
        Me.DG_OrdenCompra.MultiSelect = False
        Me.DG_OrdenCompra.Name = "DG_OrdenCompra"
        Me.DG_OrdenCompra.ReadOnly = True
        Me.DG_OrdenCompra.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DG_OrdenCompra.RowHeadersVisible = False
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DG_OrdenCompra.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DG_OrdenCompra.RowTemplate.Height = 30
        Me.DG_OrdenCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_OrdenCompra.Size = New System.Drawing.Size(924, 485)
        Me.DG_OrdenCompra.TabIndex = 0
        '
        'Numero
        '
        Me.Numero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Numero.DataPropertyName = "Numero"
        Me.Numero.HeaderText = "Nro."
        Me.Numero.Name = "Numero"
        Me.Numero.ReadOnly = True
        Me.Numero.Width = 55
        '
        'SucursalDataGridViewTextBoxColumn
        '
        Me.SucursalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SucursalDataGridViewTextBoxColumn.DataPropertyName = "Sucursal"
        Me.SucursalDataGridViewTextBoxColumn.HeaderText = "Sucursal"
        Me.SucursalDataGridViewTextBoxColumn.Name = "SucursalDataGridViewTextBoxColumn"
        Me.SucursalDataGridViewTextBoxColumn.ReadOnly = True
        Me.SucursalDataGridViewTextBoxColumn.Width = 80
        '
        'UsuarioDataGridViewTextBoxColumn
        '
        Me.UsuarioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.UsuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario"
        Me.UsuarioDataGridViewTextBoxColumn.HeaderText = "Usuario"
        Me.UsuarioDataGridViewTextBoxColumn.Name = "UsuarioDataGridViewTextBoxColumn"
        Me.UsuarioDataGridViewTextBoxColumn.ReadOnly = True
        Me.UsuarioDataGridViewTextBoxColumn.Width = 75
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        Me.EstadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.EstadoDataGridViewTextBoxColumn.Width = 70
        '
        'SupplierDataGridViewTextBoxColumn
        '
        Me.SupplierDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SupplierDataGridViewTextBoxColumn.DataPropertyName = "Supplier"
        Me.SupplierDataGridViewTextBoxColumn.HeaderText = "Supplier"
        Me.SupplierDataGridViewTextBoxColumn.Name = "SupplierDataGridViewTextBoxColumn"
        Me.SupplierDataGridViewTextBoxColumn.ReadOnly = True
        Me.SupplierDataGridViewTextBoxColumn.Width = 78
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaDataGridViewTextBoxColumn.Width = 66
        '
        'TerminosDePagoDataGridViewTextBoxColumn
        '
        Me.TerminosDePagoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TerminosDePagoDataGridViewTextBoxColumn.DataPropertyName = "TerminosDePago"
        Me.TerminosDePagoDataGridViewTextBoxColumn.FillWeight = 200.0!
        Me.TerminosDePagoDataGridViewTextBoxColumn.HeaderText = "Terminos Pago"
        Me.TerminosDePagoDataGridViewTextBoxColumn.Name = "TerminosDePagoDataGridViewTextBoxColumn"
        Me.TerminosDePagoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PenalidadesPorDemoraDataGridViewTextBoxColumn
        '
        Me.PenalidadesPorDemoraDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PenalidadesPorDemoraDataGridViewTextBoxColumn.DataPropertyName = "PenalidadesPorDemora"
        Me.PenalidadesPorDemoraDataGridViewTextBoxColumn.FillWeight = 200.0!
        Me.PenalidadesPorDemoraDataGridViewTextBoxColumn.HeaderText = "Penalidades Demora"
        Me.PenalidadesPorDemoraDataGridViewTextBoxColumn.Name = "PenalidadesPorDemoraDataGridViewTextBoxColumn"
        Me.PenalidadesPorDemoraDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaDeEnvioDataGridViewTextBoxColumn
        '
        Me.FechaDeEnvioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FechaDeEnvioDataGridViewTextBoxColumn.DataPropertyName = "FechaDeEnvio"
        Me.FechaDeEnvioDataGridViewTextBoxColumn.FillWeight = 200.0!
        Me.FechaDeEnvioDataGridViewTextBoxColumn.HeaderText = "Fecha Envio"
        Me.FechaDeEnvioDataGridViewTextBoxColumn.Name = "FechaDeEnvioDataGridViewTextBoxColumn"
        Me.FechaDeEnvioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OrdenesCompraBindingSource
        '
        Me.OrdenesCompraBindingSource.DataMember = "OrdenesCompra"
        Me.OrdenesCompraBindingSource.DataSource = Me.FrmComexOrdenCompraAdministracionViewModelBindingSource
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(9, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(933, 130)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtrar ordenes."
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel1, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 17)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(927, 110)
        Me.TableLayoutPanel2.TabIndex = 3
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label12, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label19, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ComboBox2, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ComboBox1, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel8, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(486, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(438, 104)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(3, 79)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(114, 16)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Supplier"
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(3, 9)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(114, 16)
        Me.Label19.TabIndex = 429
        Me.Label19.Text = "Fecha"
        '
        'ComboBox2
        '
        Me.ComboBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.FrmComexOrdenCompraAdministracionViewModelBindingSource, "SupplierSeleccionado", True))
        Me.ComboBox2.DataSource = Me.SuppliersBindingSource
        Me.ComboBox2.DisplayMember = "Value"
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(123, 76)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(312, 23)
        Me.ComboBox2.TabIndex = 433
        Me.ComboBox2.ValueMember = "Key"
        '
        'SuppliersBindingSource
        '
        Me.SuppliersBindingSource.DataMember = "Suppliers"
        Me.SuppliersBindingSource.DataSource = Me.FrmComexOrdenCompraAdministracionViewModelBindingSource
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 44)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 16)
        Me.Label9.TabIndex = 432
        Me.Label9.Text = "Estado"
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.FrmComexOrdenCompraAdministracionViewModelBindingSource, "EstadoSeleccionado", True))
        Me.ComboBox1.DataSource = Me.EstadosBindingSource
        Me.ComboBox1.DisplayMember = "Value"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(123, 41)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(312, 23)
        Me.ComboBox1.TabIndex = 41
        Me.ComboBox1.ValueMember = "Key"
        '
        'EstadosBindingSource
        '
        Me.EstadosBindingSource.DataMember = "Estados"
        Me.EstadosBindingSource.DataSource = Me.FrmComexOrdenCompraAdministracionViewModelBindingSource
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.ColumnCount = 3
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.Label18, 1, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.FDesde, 0, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.FHasta, 2, 0)
        Me.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(123, 3)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 1
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(312, 29)
        Me.TableLayoutPanel8.TabIndex = 424
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(149, 6)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(14, 16)
        Me.Label18.TabIndex = 421
        Me.Label18.Text = "-"
        '
        'FDesde
        '
        Me.FDesde.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FDesde.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FrmComexOrdenCompraAdministracionViewModelBindingSource, "FechaDesde", True))
        Me.FDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FDesde.Location = New System.Drawing.Point(3, 4)
        Me.FDesde.Name = "FDesde"
        Me.FDesde.Size = New System.Drawing.Size(140, 21)
        Me.FDesde.TabIndex = 0
        '
        'FHasta
        '
        Me.FHasta.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FHasta.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FrmComexOrdenCompraAdministracionViewModelBindingSource, "FechaHasta", True))
        Me.FHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FHasta.Location = New System.Drawing.Point(169, 4)
        Me.FHasta.Name = "FHasta"
        Me.FHasta.Size = New System.Drawing.Size(140, 21)
        Me.FHasta.TabIndex = 1
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.txt_numero, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label1, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Cb_Encargado, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Label13, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.CB_Supplier, 1, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(437, 104)
        Me.TableLayoutPanel3.TabIndex = 4
        '
        'txt_numero
        '
        Me.txt_numero.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_numero.BackColor = System.Drawing.SystemColors.Window
        Me.txt_numero.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmComexOrdenCompraAdministracionViewModelBindingSource, "Numero", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_numero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_numero.Location = New System.Drawing.Point(123, 7)
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.Size = New System.Drawing.Size(311, 21)
        Me.txt_numero.TabIndex = 88
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 16)
        Me.Label2.TabIndex = 421
        Me.Label2.Text = "Numero"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 16)
        Me.Label1.TabIndex = 430
        Me.Label1.Text = "Encargado"
        '
        'Cb_Encargado
        '
        Me.Cb_Encargado.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cb_Encargado.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.FrmComexOrdenCompraAdministracionViewModelBindingSource, "EncargadoSeleccionado", True))
        Me.Cb_Encargado.DataSource = Me.EncargadosBindingSource
        Me.Cb_Encargado.DisplayMember = "Value"
        Me.Cb_Encargado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Encargado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Cb_Encargado.FormattingEnabled = True
        Me.Cb_Encargado.Location = New System.Drawing.Point(123, 76)
        Me.Cb_Encargado.Name = "Cb_Encargado"
        Me.Cb_Encargado.Size = New System.Drawing.Size(311, 23)
        Me.Cb_Encargado.TabIndex = 432
        Me.Cb_Encargado.ValueMember = "Key"
        '
        'EncargadosBindingSource
        '
        Me.EncargadosBindingSource.DataMember = "Encargados"
        Me.EncargadosBindingSource.DataSource = Me.FrmComexOrdenCompraAdministracionViewModelBindingSource
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(3, 45)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(114, 16)
        Me.Label13.TabIndex = 420
        Me.Label13.Text = "Sucursal"
        '
        'CB_Supplier
        '
        Me.CB_Supplier.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CB_Supplier.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.FrmComexOrdenCompraAdministracionViewModelBindingSource, "SucursaleSeleccionado", True))
        Me.CB_Supplier.DataSource = Me.SucursalesBindingSource
        Me.CB_Supplier.DisplayMember = "Value"
        Me.CB_Supplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_Supplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.CB_Supplier.FormattingEnabled = True
        Me.CB_Supplier.Location = New System.Drawing.Point(123, 41)
        Me.CB_Supplier.Name = "CB_Supplier"
        Me.CB_Supplier.Size = New System.Drawing.Size(311, 23)
        Me.CB_Supplier.TabIndex = 431
        Me.CB_Supplier.ValueMember = "Key"
        '
        'SucursalesBindingSource
        '
        Me.SucursalesBindingSource.DataMember = "Sucursales"
        Me.SucursalesBindingSource.DataSource = Me.FrmComexOrdenCompraAdministracionViewModelBindingSource
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNuevo.FlatAppearance.BorderSize = 0
        Me.BtnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.Image = Global.SistemaCinderella.My.Resources.Recursos.Agregar_24
        Me.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNuevo.Location = New System.Drawing.Point(848, 145)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(94, 41)
        Me.BtnNuevo.TabIndex = 10
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnFiltrar
        '
        Me.BtnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFiltrar.FlatAppearance.BorderSize = 0
        Me.BtnFiltrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFiltrar.Image = Global.SistemaCinderella.My.Resources.Recursos.IconoBuscar32
        Me.BtnFiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnFiltrar.Location = New System.Drawing.Point(748, 145)
        Me.BtnFiltrar.Name = "BtnFiltrar"
        Me.BtnFiltrar.Size = New System.Drawing.Size(94, 41)
        Me.BtnFiltrar.TabIndex = 4
        Me.BtnFiltrar.Text = "Buscar"
        Me.BtnFiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnFiltrar.UseVisualStyleBackColor = True
        '
        'btn_Restablecer
        '
        Me.btn_Restablecer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Restablecer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Restablecer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Restablecer.Location = New System.Drawing.Point(648, 144)
        Me.btn_Restablecer.Name = "btn_Restablecer"
        Me.btn_Restablecer.Size = New System.Drawing.Size(94, 41)
        Me.btn_Restablecer.TabIndex = 9
        Me.btn_Restablecer.Text = "Restablecer Busqueda"
        Me.btn_Restablecer.UseVisualStyleBackColor = True
        '
        'frmComexOrdenCompraAdministracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(954, 737)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.BtnFiltrar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btn_Restablecer)
        Me.Controls.Add(Me.GroupBox1)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("WindowState", Me.FrmComexOrdenCompraAdministracionViewModelBindingSource, "FormState", True))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmComexOrdenCompraAdministracion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administración de Ordenes Compra COMEX"
        CType(Me.FrmComexOrdenCompraAdministracionViewModelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DG_OrdenCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdenesCompraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.SuppliersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel8.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.EncargadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SucursalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbl_Msg As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DG_OrdenCompra As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnFiltrar As Button
    Friend WithEvents btn_Restablecer As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label12 As Label
    Friend WithEvents FDesde As DateTimePicker
    Friend WithEvents FHasta As DateTimePicker
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label13 As Label
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents Label18 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents CB_Supplier As ComboBox
    Friend WithEvents Cb_Encargado As ComboBox
    Friend WithEvents OrdenesCompraBindingSource As BindingSource
    Friend WithEvents FrmComexOrdenCompraAdministracionViewModelBindingSource As BindingSource
    Friend WithEvents SuppliersBindingSource As BindingSource
    Friend WithEvents EstadosBindingSource As BindingSource
    Friend WithEvents SucursalesBindingSource As BindingSource
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents EncargadosBindingSource As BindingSource
    Friend WithEvents Paginado As Paginado
    Friend WithEvents Numero As DataGridViewTextBoxColumn
    Friend WithEvents SucursalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsuarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SupplierDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TerminosDePagoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PenalidadesPorDemoraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDeEnvioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_numero As TextBox
End Class
