<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPresupuestoAdministracion

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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPresupuestoAdministracion))
        Me.lbl_Msg = New System.Windows.Forms.Label()
        Me.FrmPresupuestoAdministracionViewModelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgPresupuesto = New System.Windows.Forms.DataGridView()
        Me.NumeroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnuladaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Imprimir = New System.Windows.Forms.DataGridViewImageColumn()
        Me.PresupuestosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtNumeroPresupuesto = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.FDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.FHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.btn_Restablecer = New System.Windows.Forms.Button()
        Me.BtnFiltrar = New System.Windows.Forms.Button()
        Me.TabAdministracionPresupuesto = New System.Windows.Forms.TabControl()
        Me.TabPresupuesto = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Paginado = New SistemaCinderella.Paginado()
        Me.TabDetalle = New System.Windows.Forms.TabPage()
        Me.Gb_Anulado = New System.Windows.Forms.GroupBox()
        Me.txtDescripcionAnular = New System.Windows.Forms.TextBox()
        Me.FrmPresupuestoDetalleViewModelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BtnAnular = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PresupuestoItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.CodigoDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPresupuestoItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.CodigoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PorcentajeBonificacionDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quitar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductosQuitar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.FrmPresupuestoAdministracionViewModelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgPresupuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TabAdministracionPresupuesto.SuspendLayout()
        Me.TabPresupuesto.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabDetalle.SuspendLayout()
        Me.Gb_Anulado.SuspendLayout()
        CType(Me.FrmPresupuestoDetalleViewModelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalPresupuestoItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_Msg
        '
        Me.lbl_Msg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Msg.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lbl_Msg.DataBindings.Add(New System.Windows.Forms.Binding("Visible", Me.FrmPresupuestoAdministracionViewModelBindingSource, "SinResultados", True))
        Me.lbl_Msg.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Msg.Location = New System.Drawing.Point(92, 261)
        Me.lbl_Msg.Name = "lbl_Msg"
        Me.lbl_Msg.Size = New System.Drawing.Size(678, 229)
        Me.lbl_Msg.TabIndex = 2
        Me.lbl_Msg.Text = "No se han encontrado Presupuestos."
        Me.lbl_Msg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmPresupuestoAdministracionViewModelBindingSource
        '
        Me.FrmPresupuestoAdministracionViewModelBindingSource.DataSource = GetType(SistemaCinderella.Formularios.Venta.frmPresupuestoAdministracionViewModel)
        '
        'dgPresupuesto
        '
        Me.dgPresupuesto.AllowUserToAddRows = False
        Me.dgPresupuesto.AllowUserToDeleteRows = False
        Me.dgPresupuesto.AllowUserToResizeColumns = False
        Me.dgPresupuesto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgPresupuesto.AutoGenerateColumns = False
        Me.dgPresupuesto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgPresupuesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPresupuesto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumeroDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.ClienteDataGridViewTextBoxColumn, Me.AnuladaDataGridViewTextBoxColumn, Me.Imprimir})
        Me.dgPresupuesto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgPresupuesto.DataSource = Me.PresupuestosBindingSource
        Me.dgPresupuesto.Location = New System.Drawing.Point(3, 137)
        Me.dgPresupuesto.MultiSelect = False
        Me.dgPresupuesto.Name = "dgPresupuesto"
        Me.dgPresupuesto.ReadOnly = True
        Me.dgPresupuesto.RowHeadersVisible = False
        Me.dgPresupuesto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgPresupuesto.Size = New System.Drawing.Size(864, 403)
        Me.dgPresupuesto.TabIndex = 4
        '
        'NumeroDataGridViewTextBoxColumn
        '
        Me.NumeroDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NumeroDataGridViewTextBoxColumn.DataPropertyName = "Numero"
        Me.NumeroDataGridViewTextBoxColumn.HeaderText = "Nro."
        Me.NumeroDataGridViewTextBoxColumn.Name = "NumeroDataGridViewTextBoxColumn"
        Me.NumeroDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumeroDataGridViewTextBoxColumn.Width = 55
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaDataGridViewTextBoxColumn.Width = 66
        '
        'ClienteDataGridViewTextBoxColumn
        '
        Me.ClienteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ClienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn.Name = "ClienteDataGridViewTextBoxColumn"
        Me.ClienteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AnuladaDataGridViewTextBoxColumn
        '
        Me.AnuladaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.AnuladaDataGridViewTextBoxColumn.DataPropertyName = "Anulada"
        Me.AnuladaDataGridViewTextBoxColumn.HeaderText = "Anulada"
        Me.AnuladaDataGridViewTextBoxColumn.Name = "AnuladaDataGridViewTextBoxColumn"
        Me.AnuladaDataGridViewTextBoxColumn.ReadOnly = True
        Me.AnuladaDataGridViewTextBoxColumn.Width = 77
        '
        'Imprimir
        '
        Me.Imprimir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Imprimir.HeaderText = ""
        Me.Imprimir.Image = Global.SistemaCinderella.My.Resources.Recursos.icono_imprimir
        Me.Imprimir.Name = "Imprimir"
        Me.Imprimir.ReadOnly = True
        Me.Imprimir.Width = 5
        '
        'PresupuestosBindingSource
        '
        Me.PresupuestosBindingSource.DataMember = "Presupuestos"
        Me.PresupuestosBindingSource.DataSource = Me.FrmPresupuestoAdministracionViewModelBindingSource
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.txtNumeroPresupuesto, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label13, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.FDesde, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label12, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.FHasta, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtCliente, 1, 1)
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 20)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(864, 65)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'txtNumeroPresupuesto
        '
        Me.txtNumeroPresupuesto.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNumeroPresupuesto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmPresupuestoAdministracionViewModelBindingSource, "Numero", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N0"))
        Me.txtNumeroPresupuesto.Location = New System.Drawing.Point(143, 4)
        Me.txtNumeroPresupuesto.Name = "txtNumeroPresupuesto"
        Me.txtNumeroPresupuesto.Size = New System.Drawing.Size(226, 21)
        Me.txtNumeroPresupuesto.TabIndex = 0
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label13.Location = New System.Drawing.Point(3, 7)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(134, 15)
        Me.Label13.TabIndex = 421
        Me.Label13.Text = "N° Presupuesto"
        '
        'FDesde
        '
        Me.FDesde.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FDesde.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FDesde.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FrmPresupuestoAdministracionViewModelBindingSource, "FechaDesde", True))
        Me.FDesde.Location = New System.Drawing.Point(635, 4)
        Me.FDesde.Name = "FDesde"
        Me.FDesde.Size = New System.Drawing.Size(226, 21)
        Me.FDesde.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label12.Location = New System.Drawing.Point(495, 7)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(134, 15)
        Me.Label12.TabIndex = 433
        Me.Label12.Text = "Fecha desde"
        '
        'FHasta
        '
        Me.FHasta.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FHasta.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FHasta.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FrmPresupuestoAdministracionViewModelBindingSource, "FechaHasta", True))
        Me.FHasta.Location = New System.Drawing.Point(635, 37)
        Me.FHasta.Name = "FHasta"
        Me.FHasta.Size = New System.Drawing.Size(226, 21)
        Me.FHasta.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(495, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 15)
        Me.Label2.TabIndex = 435
        Me.Label2.Text = "Fecha Hasta"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(3, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 15)
        Me.Label3.TabIndex = 437
        Me.Label3.Text = "Cliente"
        '
        'txtCliente
        '
        Me.txtCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCliente.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmPresupuestoAdministracionViewModelBindingSource, "Cliente", True))
        Me.txtCliente.Location = New System.Drawing.Point(143, 37)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(226, 21)
        Me.txtCliente.TabIndex = 1
        '
        'btn_Restablecer
        '
        Me.btn_Restablecer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Restablecer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Restablecer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Restablecer.Location = New System.Drawing.Point(658, 90)
        Me.btn_Restablecer.Name = "btn_Restablecer"
        Me.btn_Restablecer.Size = New System.Drawing.Size(100, 40)
        Me.btn_Restablecer.TabIndex = 0
        Me.btn_Restablecer.Text = "Restablecer Busqueda"
        Me.btn_Restablecer.UseVisualStyleBackColor = True
        '
        'BtnFiltrar
        '
        Me.BtnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFiltrar.FlatAppearance.BorderSize = 0
        Me.BtnFiltrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFiltrar.Image = Global.SistemaCinderella.My.Resources.Recursos.IconoBuscar32
        Me.BtnFiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnFiltrar.Location = New System.Drawing.Point(764, 91)
        Me.BtnFiltrar.Name = "BtnFiltrar"
        Me.BtnFiltrar.Size = New System.Drawing.Size(100, 40)
        Me.BtnFiltrar.TabIndex = 1
        Me.BtnFiltrar.Text = "Buscar"
        Me.BtnFiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnFiltrar.UseVisualStyleBackColor = True
        '
        'TabAdministracionPresupuesto
        '
        Me.TabAdministracionPresupuesto.Controls.Add(Me.TabPresupuesto)
        Me.TabAdministracionPresupuesto.Controls.Add(Me.TabDetalle)
        Me.TabAdministracionPresupuesto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabAdministracionPresupuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TabAdministracionPresupuesto.Location = New System.Drawing.Point(0, 0)
        Me.TabAdministracionPresupuesto.Name = "TabAdministracionPresupuesto"
        Me.TabAdministracionPresupuesto.SelectedIndex = 0
        Me.TabAdministracionPresupuesto.Size = New System.Drawing.Size(884, 617)
        Me.TabAdministracionPresupuesto.TabIndex = 0
        '
        'TabPresupuesto
        '
        Me.TabPresupuesto.Controls.Add(Me.GroupBox2)
        Me.TabPresupuesto.Location = New System.Drawing.Point(4, 29)
        Me.TabPresupuesto.Name = "TabPresupuesto"
        Me.TabPresupuesto.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPresupuesto.Size = New System.Drawing.Size(876, 584)
        Me.TabPresupuesto.TabIndex = 0
        Me.TabPresupuesto.Text = "Presupuestos"
        Me.TabPresupuesto.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Paginado)
        Me.GroupBox2.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox2.Controls.Add(Me.lbl_Msg)
        Me.GroupBox2.Controls.Add(Me.btn_Restablecer)
        Me.GroupBox2.Controls.Add(Me.dgPresupuesto)
        Me.GroupBox2.Controls.Add(Me.BtnFiltrar)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(870, 578)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtrar Presupuesto"
        '
        'Paginado
        '
        Me.Paginado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Paginado.DataBindings.Add(New System.Windows.Forms.Binding("TotalElementos", Me.FrmPresupuestoAdministracionViewModelBindingSource, "TotalElementos", True))
        Me.Paginado.Leyenda = "{0} de {1}"
        Me.Paginado.Location = New System.Drawing.Point(1, 546)
        Me.Paginado.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Paginado.Name = "Paginado"
        Me.Paginado.PaginaActual = 1
        Me.Paginado.Size = New System.Drawing.Size(155, 27)
        Me.Paginado.TabIndex = 23
        Me.Paginado.TotalElementos = 0
        '
        'TabDetalle
        '
        Me.TabDetalle.Controls.Add(Me.Gb_Anulado)
        Me.TabDetalle.Controls.Add(Me.GroupBox1)
        Me.TabDetalle.Location = New System.Drawing.Point(4, 29)
        Me.TabDetalle.Name = "TabDetalle"
        Me.TabDetalle.Padding = New System.Windows.Forms.Padding(3)
        Me.TabDetalle.Size = New System.Drawing.Size(876, 584)
        Me.TabDetalle.TabIndex = 1
        Me.TabDetalle.Text = "Detalle del Presupuesto"
        Me.TabDetalle.UseVisualStyleBackColor = True
        '
        'Gb_Anulado
        '
        Me.Gb_Anulado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gb_Anulado.Controls.Add(Me.txtDescripcionAnular)
        Me.Gb_Anulado.Controls.Add(Me.BtnAnular)
        Me.Gb_Anulado.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.FrmPresupuestoDetalleViewModelBindingSource, "AnuladaMotivoHabilitado", True))
        Me.Gb_Anulado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gb_Anulado.Location = New System.Drawing.Point(6, 482)
        Me.Gb_Anulado.Name = "Gb_Anulado"
        Me.Gb_Anulado.Size = New System.Drawing.Size(858, 94)
        Me.Gb_Anulado.TabIndex = 16
        Me.Gb_Anulado.TabStop = False
        Me.Gb_Anulado.Text = "Anular Presupuesto - Motivo"
        '
        'txtDescripcionAnular
        '
        Me.txtDescripcionAnular.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescripcionAnular.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmPresupuestoDetalleViewModelBindingSource, "AnuladaMotivo", True))
        Me.txtDescripcionAnular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionAnular.Location = New System.Drawing.Point(6, 20)
        Me.txtDescripcionAnular.Multiline = True
        Me.txtDescripcionAnular.Name = "txtDescripcionAnular"
        Me.txtDescripcionAnular.Size = New System.Drawing.Size(762, 68)
        Me.txtDescripcionAnular.TabIndex = 0
        '
        'FrmPresupuestoDetalleViewModelBindingSource
        '
        Me.FrmPresupuestoDetalleViewModelBindingSource.DataSource = GetType(SistemaCinderella.Formularios.Venta.frmPresupuestoDetalleViewModel)
        '
        'BtnAnular
        '
        Me.BtnAnular.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAnular.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAnular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAnular.Image = Global.SistemaCinderella.My.Resources.Recursos.Desconectado
        Me.BtnAnular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAnular.Location = New System.Drawing.Point(774, 20)
        Me.BtnAnular.Name = "BtnAnular"
        Me.BtnAnular.Size = New System.Drawing.Size(78, 27)
        Me.BtnAnular.TabIndex = 1
        Me.BtnAnular.Text = "Anular"
        Me.BtnAnular.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAnular.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel7)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(864, 470)
        Me.GroupBox1.TabIndex = 78
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Presupuesto"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.DataGridView1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.DataGridView2, 0, 1)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 95)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(855, 369)
        Me.TableLayoutPanel2.TabIndex = 85
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn, Me.MontoDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PresupuestoItemsBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(849, 333)
        Me.DataGridView1.TabIndex = 0
        '
        'CodigoDataGridViewTextBoxColumn
        '
        Me.CodigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.Name = "CodigoDataGridViewTextBoxColumn"
        Me.CodigoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        Me.CantidadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MontoDataGridViewTextBoxColumn
        '
        Me.MontoDataGridViewTextBoxColumn.DataPropertyName = "Monto"
        DataGridViewCellStyle1.Format = "c"
        Me.MontoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.MontoDataGridViewTextBoxColumn.HeaderText = "Monto"
        Me.MontoDataGridViewTextBoxColumn.Name = "MontoDataGridViewTextBoxColumn"
        Me.MontoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "Total"
        DataGridViewCellStyle2.Format = "c"
        Me.TotalDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        Me.TotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PresupuestoItemsBindingSource
        '
        Me.PresupuestoItemsBindingSource.DataMember = "PresupuestoItems"
        Me.PresupuestoItemsBindingSource.DataSource = Me.FrmPresupuestoDetalleViewModelBindingSource
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.ColumnHeadersVisible = False
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoDataGridViewTextBoxColumn2, Me.NombreDataGridViewTextBoxColumn1, Me.CantidadDataGridViewTextBoxColumn2, Me.MontoDataGridViewTextBoxColumn1, Me.TotalDataGridViewTextBoxColumn1})
        Me.DataGridView2.DataSource = Me.TotalPresupuestoItemsBindingSource
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.Location = New System.Drawing.Point(3, 342)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(849, 24)
        Me.DataGridView2.TabIndex = 1
        '
        'CodigoDataGridViewTextBoxColumn2
        '
        Me.CodigoDataGridViewTextBoxColumn2.DataPropertyName = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn2.HeaderText = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn2.Name = "CodigoDataGridViewTextBoxColumn2"
        Me.CodigoDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn1
        '
        Me.NombreDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NombreDataGridViewTextBoxColumn1.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn1.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn1.Name = "NombreDataGridViewTextBoxColumn1"
        Me.NombreDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'CantidadDataGridViewTextBoxColumn2
        '
        Me.CantidadDataGridViewTextBoxColumn2.DataPropertyName = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn2.HeaderText = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn2.Name = "CantidadDataGridViewTextBoxColumn2"
        Me.CantidadDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'MontoDataGridViewTextBoxColumn1
        '
        Me.MontoDataGridViewTextBoxColumn1.DataPropertyName = "Monto"
        DataGridViewCellStyle3.Format = "c"
        Me.MontoDataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle3
        Me.MontoDataGridViewTextBoxColumn1.HeaderText = "Monto"
        Me.MontoDataGridViewTextBoxColumn1.Name = "MontoDataGridViewTextBoxColumn1"
        Me.MontoDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'TotalDataGridViewTextBoxColumn1
        '
        Me.TotalDataGridViewTextBoxColumn1.DataPropertyName = "Total"
        DataGridViewCellStyle4.Format = "c"
        Me.TotalDataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle4
        Me.TotalDataGridViewTextBoxColumn1.HeaderText = "Total"
        Me.TotalDataGridViewTextBoxColumn1.Name = "TotalDataGridViewTextBoxColumn1"
        Me.TotalDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'TotalPresupuestoItemsBindingSource
        '
        Me.TotalPresupuestoItemsBindingSource.DataMember = "TotalPresupuestoItems"
        Me.TotalPresupuestoItemsBindingSource.DataSource = Me.FrmPresupuestoDetalleViewModelBindingSource
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel7.ColumnCount = 8
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.99813!))
        Me.TableLayoutPanel7.Controls.Add(Me.TextBox1, 1, 1)
        Me.TableLayoutPanel7.Controls.Add(Me.Label1, 0, 1)
        Me.TableLayoutPanel7.Controls.Add(Me.btnImprimir, 7, 1)
        Me.TableLayoutPanel7.Controls.Add(Me.TextBox10, 3, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.Label14, 2, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.Label15, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.TextBox9, 1, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.Label18, 6, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.TextBox5, 7, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.TextBox8, 5, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.Label19, 4, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.TextBox6, 5, 1)
        Me.TableLayoutPanel7.Controls.Add(Me.Label23, 4, 1)
        Me.TableLayoutPanel7.Controls.Add(Me.TextBox7, 3, 1)
        Me.TableLayoutPanel7.Controls.Add(Me.Label20, 2, 1)
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(3, 17)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 2
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(852, 72)
        Me.TableLayoutPanel7.TabIndex = 73
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmPresupuestoDetalleViewModelBindingSource, "CondicionPago", True))
        Me.TextBox1.Location = New System.Drawing.Point(88, 40)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(122, 21)
        Me.TextBox1.TabIndex = 79
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 15)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Condición:"
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Image = Global.SistemaCinderella.My.Resources.Recursos.icono_imprimir
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImprimir.Location = New System.Drawing.Point(749, 33)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(100, 36)
        Me.btnImprimir.TabIndex = 4
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'TextBox10
        '
        Me.TextBox10.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox10.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmPresupuestoDetalleViewModelBindingSource, "Estado", True))
        Me.TextBox10.Location = New System.Drawing.Point(301, 4)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.ReadOnly = True
        Me.TextBox10.Size = New System.Drawing.Size(122, 21)
        Me.TextBox10.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(216, 7)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(79, 15)
        Me.Label14.TabIndex = 77
        Me.Label14.Text = "Estado :"
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(3, 7)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(79, 15)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "Nro :"
        '
        'TextBox9
        '
        Me.TextBox9.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox9.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmPresupuestoDetalleViewModelBindingSource, "Numero", True))
        Me.TextBox9.Location = New System.Drawing.Point(88, 4)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.ReadOnly = True
        Me.TextBox9.Size = New System.Drawing.Size(122, 21)
        Me.TextBox9.TabIndex = 0
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(642, 7)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(79, 15)
        Me.Label18.TabIndex = 4
        Me.Label18.Text = "Fecha :"
        '
        'TextBox5
        '
        Me.TextBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox5.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmPresupuestoDetalleViewModelBindingSource, "Fecha", True))
        Me.TextBox5.Location = New System.Drawing.Point(727, 4)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(122, 21)
        Me.TextBox5.TabIndex = 5
        '
        'TextBox8
        '
        Me.TextBox8.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox8.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmPresupuestoDetalleViewModelBindingSource, "TipoCliente", True))
        Me.TextBox8.Location = New System.Drawing.Point(514, 4)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ReadOnly = True
        Me.TextBox8.Size = New System.Drawing.Size(122, 21)
        Me.TextBox8.TabIndex = 4
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(429, 7)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(79, 15)
        Me.Label19.TabIndex = 3
        Me.Label19.Text = "Tipo Venta :"
        '
        'TextBox6
        '
        Me.TextBox6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox6.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmPresupuestoDetalleViewModelBindingSource, "Encargado", True))
        Me.TextBox6.Location = New System.Drawing.Point(514, 40)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(122, 21)
        Me.TextBox6.TabIndex = 3
        '
        'Label23
        '
        Me.Label23.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(429, 43)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(79, 15)
        Me.Label23.TabIndex = 35
        Me.Label23.Text = "Encargado :"
        '
        'TextBox7
        '
        Me.TextBox7.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox7.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmPresupuestoDetalleViewModelBindingSource, "Vendedor", True))
        Me.TextBox7.Location = New System.Drawing.Point(301, 40)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(122, 21)
        Me.TextBox7.TabIndex = 2
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(216, 43)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(79, 15)
        Me.Label20.TabIndex = 2
        Me.Label20.Text = "Vendedor :"
        '
        'CodigoDataGridViewTextBoxColumn1
        '
        Me.CodigoDataGridViewTextBoxColumn1.HeaderText = "Código"
        Me.CodigoDataGridViewTextBoxColumn1.Name = "CodigoDataGridViewTextBoxColumn1"
        Me.CodigoDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'CantidadDataGridViewTextBoxColumn1
        '
        Me.CantidadDataGridViewTextBoxColumn1.HeaderText = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn1.Name = "CantidadDataGridViewTextBoxColumn1"
        Me.CantidadDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'PorcentajeBonificacionDataGridViewTextBoxColumn1
        '
        DataGridViewCellStyle5.Format = "p"
        Me.PorcentajeBonificacionDataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle5
        Me.PorcentajeBonificacionDataGridViewTextBoxColumn1.HeaderText = "PorcentajeBonificacion"
        Me.PorcentajeBonificacionDataGridViewTextBoxColumn1.Name = "PorcentajeBonificacionDataGridViewTextBoxColumn1"
        Me.PorcentajeBonificacionDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'Quitar
        '
        Me.Quitar.HeaderText = ""
        Me.Quitar.Name = "Quitar"
        Me.Quitar.ReadOnly = True
        Me.Quitar.Width = 30
        '
        'ProductosQuitar
        '
        Me.ProductosQuitar.HeaderText = ""
        Me.ProductosQuitar.Image = Global.SistemaCinderella.My.Resources.Recursos.Boton_Eliminar
        Me.ProductosQuitar.Name = "ProductosQuitar"
        Me.ProductosQuitar.Width = 30
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "Imprimir"
        Me.DataGridViewImageColumn1.Image = Global.SistemaCinderella.My.Resources.Recursos.icono_imprimir
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Width = 818
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Número"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 413
        '
        'DataGridViewTextBoxColumn2
        '
        DataGridViewCellStyle6.Format = "C2"
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn2.HeaderText = "Subtotal"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 412
        '
        'frmPresupuestoAdministracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 617)
        Me.Controls.Add(Me.TabAdministracionPresupuesto)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPresupuestoAdministracion"
        Me.Text = "Presupuesto Administración"
        CType(Me.FrmPresupuestoAdministracionViewModelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgPresupuesto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TabAdministracionPresupuesto.ResumeLayout(False)
        Me.TabPresupuesto.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.TabDetalle.ResumeLayout(False)
        Me.Gb_Anulado.ResumeLayout(False)
        Me.Gb_Anulado.PerformLayout()
        CType(Me.FrmPresupuestoDetalleViewModelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalPresupuestoItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbl_Msg As Label
    Friend WithEvents dgPresupuesto As DataGridView
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents FDesde As DateTimePicker
    Friend WithEvents btn_Restablecer As Button
    Friend WithEvents BtnFiltrar As Button
    Friend WithEvents FHasta As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents TabAdministracionPresupuesto As TabControl
    Friend WithEvents TabPresupuesto As TabPage
    Friend WithEvents TabDetalle As TabPage
    Friend WithEvents Gb_Anulado As GroupBox
    Friend WithEvents txtDescripcionAnular As TextBox
    Friend WithEvents BtnAnular As Button
    Friend WithEvents txtNumeroPresupuesto As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents DG_ProductosTotales As CustomDataGrid
    Friend WithEvents CodigoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PorcentajeBonificacionDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Quitar As DataGridViewTextBoxColumn
    Friend WithEvents DG_Productos As CustomDataGrid
    Friend WithEvents ProductosQuitar As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents FrmPresupuestoAdministracionViewModelBindingSource As BindingSource
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Paginado As Paginado
    Friend WithEvents PresupuestosBindingSource As BindingSource
    Friend WithEvents FrmPresupuestoDetalleViewModelBindingSource As BindingSource
    Friend WithEvents TotalPresupuestoItemsBindingSource As BindingSource
    Friend WithEvents PresupuestoItemsBindingSource As BindingSource
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents NumeroDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AnuladaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Imprimir As DataGridViewImageColumn
    Friend WithEvents CodigoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MontoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodigoDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents MontoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents btnImprimir As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
End Class
