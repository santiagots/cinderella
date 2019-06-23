<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFacturaAdministracion
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFacturaAdministracion))
        Me.DG_facturas = New System.Windows.Forms.DataGridView()
        Me.NumeroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PuntoVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoFacturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CondicionIVADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUITDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreYApellidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocalidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FacturasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FrmFacturaAdministracionViewModelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lbl_Msg = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtFacturaNro = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.ChkMarcaManual = New System.Windows.Forms.CheckBox()
        Me.ChkMarcaTicket = New System.Windows.Forms.CheckBox()
        Me.ChkMarcaElectronica = New System.Windows.Forms.CheckBox()
        Me.FDesde = New System.Windows.Forms.DateTimePicker()
        Me.FHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.BtnFiltrar = New System.Windows.Forms.Button()
        Me.btn_Restablecer = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtMontoDesde = New System.Windows.Forms.TextBox()
        Me.txtMontoHasta = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtCUIT = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabAdministracionFacturas = New System.Windows.Forms.TabControl()
        Me.TabFacturas = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TabDetalle = New System.Windows.Forms.TabPage()
        Me.Gb_Anulado = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDescripcionAnular = New System.Windows.Forms.TextBox()
        Me.BtnAnular = New System.Windows.Forms.Button()
        Me.lblcontenedor = New System.Windows.Forms.GroupBox()
        Me.BtnNotaCreditoDetalle = New System.Windows.Forms.Button()
        Me.BtnFacturaDetalle = New System.Windows.Forms.Button()
        Me.btnReporteVenta = New System.Windows.Forms.Button()
        Me.BtnEmitirFactura = New System.Windows.Forms.Button()
        Me.VentaDetalle = New SistemaCinderella.VentaDetalle()
        CType(Me.DG_facturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FrmFacturaAdministracionViewModelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TabAdministracionFacturas.SuspendLayout()
        Me.TabFacturas.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabDetalle.SuspendLayout()
        Me.Gb_Anulado.SuspendLayout()
        Me.lblcontenedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'DG_facturas
        '
        Me.DG_facturas.AllowUserToAddRows = False
        Me.DG_facturas.AllowUserToDeleteRows = False
        Me.DG_facturas.AllowUserToResizeColumns = False
        Me.DG_facturas.AutoGenerateColumns = False
        Me.DG_facturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_facturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_facturas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumeroDataGridViewTextBoxColumn, Me.PuntoVenta, Me.TipoFacturaDataGridViewTextBoxColumn, Me.CondicionIVADataGridViewTextBoxColumn, Me.CUITDataGridViewTextBoxColumn, Me.NombreYApellidoDataGridViewTextBoxColumn, Me.DireccionDataGridViewTextBoxColumn, Me.LocalidadDataGridViewTextBoxColumn, Me.MontoDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn})
        Me.DG_facturas.DataSource = Me.FacturasBindingSource
        Me.DG_facturas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_facturas.Location = New System.Drawing.Point(3, 17)
        Me.DG_facturas.MultiSelect = False
        Me.DG_facturas.Name = "DG_facturas"
        Me.DG_facturas.ReadOnly = True
        Me.DG_facturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_facturas.Size = New System.Drawing.Size(928, 485)
        Me.DG_facturas.TabIndex = 0
        '
        'NumeroDataGridViewTextBoxColumn
        '
        Me.NumeroDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NumeroDataGridViewTextBoxColumn.DataPropertyName = "Numero"
        Me.NumeroDataGridViewTextBoxColumn.HeaderText = "Numero"
        Me.NumeroDataGridViewTextBoxColumn.Name = "NumeroDataGridViewTextBoxColumn"
        Me.NumeroDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumeroDataGridViewTextBoxColumn.Width = 77
        '
        'PuntoVenta
        '
        Me.PuntoVenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PuntoVenta.DataPropertyName = "PuntoVenta"
        Me.PuntoVenta.HeaderText = "P. Venta"
        Me.PuntoVenta.Name = "PuntoVenta"
        Me.PuntoVenta.ReadOnly = True
        Me.PuntoVenta.Width = 71
        '
        'TipoFacturaDataGridViewTextBoxColumn
        '
        Me.TipoFacturaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TipoFacturaDataGridViewTextBoxColumn.DataPropertyName = "TipoFactura"
        Me.TipoFacturaDataGridViewTextBoxColumn.HeaderText = "T. Factura"
        Me.TipoFacturaDataGridViewTextBoxColumn.Name = "TipoFacturaDataGridViewTextBoxColumn"
        Me.TipoFacturaDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoFacturaDataGridViewTextBoxColumn.Width = 79
        '
        'CondicionIVADataGridViewTextBoxColumn
        '
        Me.CondicionIVADataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CondicionIVADataGridViewTextBoxColumn.DataPropertyName = "CondicionIVA"
        Me.CondicionIVADataGridViewTextBoxColumn.HeaderText = "Condición IVA"
        Me.CondicionIVADataGridViewTextBoxColumn.Name = "CondicionIVADataGridViewTextBoxColumn"
        Me.CondicionIVADataGridViewTextBoxColumn.ReadOnly = True
        Me.CondicionIVADataGridViewTextBoxColumn.Width = 98
        '
        'CUITDataGridViewTextBoxColumn
        '
        Me.CUITDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CUITDataGridViewTextBoxColumn.DataPropertyName = "CUIT"
        Me.CUITDataGridViewTextBoxColumn.HeaderText = "CUIT"
        Me.CUITDataGridViewTextBoxColumn.Name = "CUITDataGridViewTextBoxColumn"
        Me.CUITDataGridViewTextBoxColumn.ReadOnly = True
        Me.CUITDataGridViewTextBoxColumn.Width = 59
        '
        'NombreYApellidoDataGridViewTextBoxColumn
        '
        Me.NombreYApellidoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NombreYApellidoDataGridViewTextBoxColumn.DataPropertyName = "NombreYApellido"
        Me.NombreYApellidoDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreYApellidoDataGridViewTextBoxColumn.Name = "NombreYApellidoDataGridViewTextBoxColumn"
        Me.NombreYApellidoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DireccionDataGridViewTextBoxColumn
        '
        Me.DireccionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DireccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion"
        Me.DireccionDataGridViewTextBoxColumn.HeaderText = "Dirección"
        Me.DireccionDataGridViewTextBoxColumn.Name = "DireccionDataGridViewTextBoxColumn"
        Me.DireccionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LocalidadDataGridViewTextBoxColumn
        '
        Me.LocalidadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.LocalidadDataGridViewTextBoxColumn.DataPropertyName = "Localidad"
        Me.LocalidadDataGridViewTextBoxColumn.HeaderText = "Localidad"
        Me.LocalidadDataGridViewTextBoxColumn.Name = "LocalidadDataGridViewTextBoxColumn"
        Me.LocalidadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MontoDataGridViewTextBoxColumn
        '
        Me.MontoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MontoDataGridViewTextBoxColumn.DataPropertyName = "Monto"
        Me.MontoDataGridViewTextBoxColumn.HeaderText = "Monto"
        Me.MontoDataGridViewTextBoxColumn.Name = "MontoDataGridViewTextBoxColumn"
        Me.MontoDataGridViewTextBoxColumn.ReadOnly = True
        Me.MontoDataGridViewTextBoxColumn.Width = 67
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
        'FacturasBindingSource
        '
        Me.FacturasBindingSource.DataMember = "Facturas"
        Me.FacturasBindingSource.DataSource = Me.FrmFacturaAdministracionViewModelBindingSource
        '
        'FrmFacturaAdministracionViewModelBindingSource
        '
        Me.FrmFacturaAdministracionViewModelBindingSource.DataSource = GetType(Formularios.Facturacion.frmFacturaAdministracionViewModel)
        '
        'lbl_Msg
        '
        Me.lbl_Msg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Msg.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lbl_Msg.DataBindings.Add(New System.Windows.Forms.Binding("Visible", Me.FrmFacturaAdministracionViewModelBindingSource, "SinResultados", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.lbl_Msg.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Msg.Location = New System.Drawing.Point(286, 236)
        Me.lbl_Msg.MinimumSize = New System.Drawing.Size(343, 26)
        Me.lbl_Msg.Name = "lbl_Msg"
        Me.lbl_Msg.Size = New System.Drawing.Size(362, 52)
        Me.lbl_Msg.TabIndex = 3
        Me.lbl_Msg.Text = "No se han encontrado facturas."
        Me.lbl_Msg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(3, 7)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(134, 16)
        Me.Label13.TabIndex = 420
        Me.Label13.Text = "N° Factura"
        '
        'txtFacturaNro
        '
        Me.txtFacturaNro.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFacturaNro.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmFacturaAdministracionViewModelBindingSource, "NumeroFactura", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "N0"))
        Me.txtFacturaNro.Location = New System.Drawing.Point(143, 4)
        Me.txtFacturaNro.Name = "txtFacturaNro"
        Me.txtFacturaNro.Size = New System.Drawing.Size(275, 21)
        Me.txtFacturaNro.TabIndex = 418
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(504, 69)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(134, 16)
        Me.Label17.TabIndex = 422
        Me.Label17.Text = "Comprobante"
        '
        'ChkMarcaManual
        '
        Me.ChkMarcaManual.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkMarcaManual.AutoSize = True
        Me.ChkMarcaManual.Checked = True
        Me.ChkMarcaManual.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkMarcaManual.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.FrmFacturaAdministracionViewModelBindingSource, "FacturaManual", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ChkMarcaManual.Location = New System.Drawing.Point(3, 3)
        Me.ChkMarcaManual.Name = "ChkMarcaManual"
        Me.ChkMarcaManual.Size = New System.Drawing.Size(74, 18)
        Me.ChkMarcaManual.TabIndex = 424
        Me.ChkMarcaManual.Text = "Manual"
        Me.ChkMarcaManual.UseVisualStyleBackColor = True
        '
        'ChkMarcaTicket
        '
        Me.ChkMarcaTicket.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkMarcaTicket.AutoSize = True
        Me.ChkMarcaTicket.Checked = True
        Me.ChkMarcaTicket.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkMarcaTicket.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.FrmFacturaAdministracionViewModelBindingSource, "FacturaElectronica", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ChkMarcaTicket.Location = New System.Drawing.Point(83, 3)
        Me.ChkMarcaTicket.Name = "ChkMarcaTicket"
        Me.ChkMarcaTicket.Size = New System.Drawing.Size(74, 18)
        Me.ChkMarcaTicket.TabIndex = 425
        Me.ChkMarcaTicket.Text = "Ticket"
        Me.ChkMarcaTicket.UseVisualStyleBackColor = True
        '
        'ChkMarcaElectronica
        '
        Me.ChkMarcaElectronica.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkMarcaElectronica.AutoSize = True
        Me.ChkMarcaElectronica.Checked = True
        Me.ChkMarcaElectronica.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkMarcaElectronica.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.FrmFacturaAdministracionViewModelBindingSource, "FacturaElectronica", True))
        Me.ChkMarcaElectronica.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.FrmFacturaAdministracionViewModelBindingSource, "VentaDetalleSeleccionada", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ChkMarcaElectronica.Location = New System.Drawing.Point(163, 3)
        Me.ChkMarcaElectronica.Name = "ChkMarcaElectronica"
        Me.ChkMarcaElectronica.Size = New System.Drawing.Size(109, 18)
        Me.ChkMarcaElectronica.TabIndex = 426
        Me.ChkMarcaElectronica.Text = "Electronica"
        Me.ChkMarcaElectronica.UseVisualStyleBackColor = True
        '
        'FDesde
        '
        Me.FDesde.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FDesde.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FrmFacturaAdministracionViewModelBindingSource, "FechaDesde", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "D"))
        Me.FDesde.Location = New System.Drawing.Point(644, 4)
        Me.FDesde.Name = "FDesde"
        Me.FDesde.Size = New System.Drawing.Size(275, 21)
        Me.FDesde.TabIndex = 0
        '
        'FHasta
        '
        Me.FHasta.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FHasta.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FrmFacturaAdministracionViewModelBindingSource, "FechaHasta", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "D"))
        Me.FHasta.Location = New System.Drawing.Point(644, 35)
        Me.FHasta.Name = "FHasta"
        Me.FHasta.Size = New System.Drawing.Size(275, 21)
        Me.FHasta.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(504, 38)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(134, 16)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Fecha hasta"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(504, 7)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(134, 16)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Fecha desde"
        '
        'BtnFiltrar
        '
        Me.BtnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFiltrar.FlatAppearance.BorderSize = 0
        Me.BtnFiltrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFiltrar.Image = Global.SistemaCinderella.My.Resources.Recursos.IconoBuscar32
        Me.BtnFiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnFiltrar.Location = New System.Drawing.Point(828, 133)
        Me.BtnFiltrar.Name = "BtnFiltrar"
        Me.BtnFiltrar.Size = New System.Drawing.Size(100, 40)
        Me.BtnFiltrar.TabIndex = 4
        Me.BtnFiltrar.Text = "Buscar"
        Me.BtnFiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnFiltrar.UseVisualStyleBackColor = True
        '
        'btn_Restablecer
        '
        Me.btn_Restablecer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Restablecer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Restablecer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Restablecer.Location = New System.Drawing.Point(722, 133)
        Me.btn_Restablecer.Name = "btn_Restablecer"
        Me.btn_Restablecer.Size = New System.Drawing.Size(100, 40)
        Me.btn_Restablecer.TabIndex = 9
        Me.btn_Restablecer.Text = "Restablecer Busqueda"
        Me.btn_Restablecer.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(3, 38)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(134, 16)
        Me.Label19.TabIndex = 429
        Me.Label19.Text = "Monto"
        '
        'txtMontoDesde
        '
        Me.txtMontoDesde.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMontoDesde.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmFacturaAdministracionViewModelBindingSource, "MontoDesde", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.txtMontoDesde.Location = New System.Drawing.Point(3, 3)
        Me.txtMontoDesde.Name = "txtMontoDesde"
        Me.txtMontoDesde.Size = New System.Drawing.Size(121, 21)
        Me.txtMontoDesde.TabIndex = 427
        '
        'txtMontoHasta
        '
        Me.txtMontoHasta.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMontoHasta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmFacturaAdministracionViewModelBindingSource, "MontoHasta", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.txtMontoHasta.Location = New System.Drawing.Point(150, 3)
        Me.txtMontoHasta.Name = "txtMontoHasta"
        Me.txtMontoHasta.Size = New System.Drawing.Size(122, 21)
        Me.txtMontoHasta.TabIndex = 428
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(130, 5)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(14, 16)
        Me.Label18.TabIndex = 430
        Me.Label18.Text = "-"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 16)
        Me.Label1.TabIndex = 432
        Me.Label1.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmFacturaAdministracionViewModelBindingSource, "Nombre", True))
        Me.txtNombre.Location = New System.Drawing.Point(143, 66)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(275, 21)
        Me.txtNombre.TabIndex = 431
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btn_Restablecer)
        Me.GroupBox1.Controls.Add(Me.BtnFiltrar)
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(934, 179)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtrar facturas."
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 5
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel5, 4, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.FHasta, 4, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.FDesde, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label17, 3, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label11, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label13, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtCUIT, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.txtFacturaNro, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label12, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label19, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtNombre, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 2)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(6, 20)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(922, 122)
        Me.TableLayoutPanel2.TabIndex = 435
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 3
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.ChkMarcaManual, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.ChkMarcaTicket, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.ChkMarcaElectronica, 2, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(644, 65)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(275, 24)
        Me.TableLayoutPanel5.TabIndex = 437
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.txtMontoDesde, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label18, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.txtMontoHasta, 2, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(143, 33)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(275, 26)
        Me.TableLayoutPanel3.TabIndex = 436
        '
        'txtCUIT
        '
        Me.txtCUIT.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCUIT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmFacturaAdministracionViewModelBindingSource, "Cuit", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "N2"))
        Me.txtCUIT.Location = New System.Drawing.Point(143, 96)
        Me.txtCUIT.Name = "txtCUIT"
        Me.txtCUIT.Size = New System.Drawing.Size(275, 21)
        Me.txtCUIT.TabIndex = 433
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 16)
        Me.Label2.TabIndex = 434
        Me.Label2.Text = "CUIT"
        '
        'TabAdministracionFacturas
        '
        Me.TabAdministracionFacturas.Controls.Add(Me.TabFacturas)
        Me.TabAdministracionFacturas.Controls.Add(Me.TabDetalle)
        Me.TabAdministracionFacturas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabAdministracionFacturas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TabAdministracionFacturas.Location = New System.Drawing.Point(0, 0)
        Me.TabAdministracionFacturas.Name = "TabAdministracionFacturas"
        Me.TabAdministracionFacturas.SelectedIndex = 0
        Me.TabAdministracionFacturas.Size = New System.Drawing.Size(954, 737)
        Me.TabAdministracionFacturas.TabIndex = 5
        '
        'TabFacturas
        '
        Me.TabFacturas.Controls.Add(Me.GroupBox2)
        Me.TabFacturas.Controls.Add(Me.GroupBox1)
        Me.TabFacturas.Location = New System.Drawing.Point(4, 29)
        Me.TabFacturas.Name = "TabFacturas"
        Me.TabFacturas.Padding = New System.Windows.Forms.Padding(3)
        Me.TabFacturas.Size = New System.Drawing.Size(946, 704)
        Me.TabFacturas.TabIndex = 0
        Me.TabFacturas.Text = "Facturas"
        Me.TabFacturas.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbl_Msg)
        Me.GroupBox2.Controls.Add(Me.DG_facturas)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 191)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(934, 505)
        Me.GroupBox2.TabIndex = 436
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Facturas"
        '
        'TabDetalle
        '
        Me.TabDetalle.Controls.Add(Me.Gb_Anulado)
        Me.TabDetalle.Controls.Add(Me.lblcontenedor)
        Me.TabDetalle.Location = New System.Drawing.Point(4, 29)
        Me.TabDetalle.Name = "TabDetalle"
        Me.TabDetalle.Padding = New System.Windows.Forms.Padding(3)
        Me.TabDetalle.Size = New System.Drawing.Size(946, 704)
        Me.TabDetalle.TabIndex = 1
        Me.TabDetalle.Text = "Detalle Factura"
        Me.TabDetalle.UseVisualStyleBackColor = True
        '
        'Gb_Anulado
        '
        Me.Gb_Anulado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gb_Anulado.Controls.Add(Me.TextBox1)
        Me.Gb_Anulado.Controls.Add(Me.Label3)
        Me.Gb_Anulado.Controls.Add(Me.txtDescripcionAnular)
        Me.Gb_Anulado.Controls.Add(Me.BtnAnular)
        Me.Gb_Anulado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Gb_Anulado.Location = New System.Drawing.Point(8, 548)
        Me.Gb_Anulado.Name = "Gb_Anulado"
        Me.Gb_Anulado.Size = New System.Drawing.Size(928, 148)
        Me.Gb_Anulado.TabIndex = 17
        Me.Gb_Anulado.TabStop = False
        Me.Gb_Anulado.Text = "Anular Venta - Motivo"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmFacturaAdministracionViewModelBindingSource, "FechaAnulacion", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "G"))
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(104, 117)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(179, 21)
        Me.TextBox1.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 15)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Fecha Anulado:"
        '
        'txtDescripcionAnular
        '
        Me.txtDescripcionAnular.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescripcionAnular.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmFacturaAdministracionViewModelBindingSource, "MotivoAnulacion", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtDescripcionAnular.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.FrmFacturaAdministracionViewModelBindingSource, "HabilitarAnular", True))
        Me.txtDescripcionAnular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionAnular.Location = New System.Drawing.Point(9, 21)
        Me.txtDescripcionAnular.Multiline = True
        Me.txtDescripcionAnular.Name = "txtDescripcionAnular"
        Me.txtDescripcionAnular.Size = New System.Drawing.Size(913, 88)
        Me.txtDescripcionAnular.TabIndex = 15
        '
        'BtnAnular
        '
        Me.BtnAnular.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAnular.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAnular.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.FrmFacturaAdministracionViewModelBindingSource, "HabilitarAnular", True))
        Me.BtnAnular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAnular.Image = Global.SistemaCinderella.My.Resources.Recursos.Desconectado
        Me.BtnAnular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAnular.Location = New System.Drawing.Point(844, 114)
        Me.BtnAnular.Name = "BtnAnular"
        Me.BtnAnular.Size = New System.Drawing.Size(78, 27)
        Me.BtnAnular.TabIndex = 14
        Me.BtnAnular.Text = "Anular"
        Me.BtnAnular.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAnular.UseVisualStyleBackColor = True
        '
        'lblcontenedor
        '
        Me.lblcontenedor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblcontenedor.Controls.Add(Me.BtnNotaCreditoDetalle)
        Me.lblcontenedor.Controls.Add(Me.BtnFacturaDetalle)
        Me.lblcontenedor.Controls.Add(Me.btnReporteVenta)
        Me.lblcontenedor.Controls.Add(Me.BtnEmitirFactura)
        Me.lblcontenedor.Controls.Add(Me.VentaDetalle)
        Me.lblcontenedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcontenedor.Location = New System.Drawing.Point(8, 6)
        Me.lblcontenedor.Name = "lblcontenedor"
        Me.lblcontenedor.Size = New System.Drawing.Size(928, 536)
        Me.lblcontenedor.TabIndex = 1
        Me.lblcontenedor.TabStop = False
        Me.lblcontenedor.Text = "Información de la venta realizada."
        '
        'BtnNotaCreditoDetalle
        '
        Me.BtnNotaCreditoDetalle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnNotaCreditoDetalle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNotaCreditoDetalle.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.FrmFacturaAdministracionViewModelBindingSource, "HabilitarDetalleNotaCredito", True))
        Me.BtnNotaCreditoDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNotaCreditoDetalle.Image = Global.SistemaCinderella.My.Resources.Recursos.Detalle_Pequeno
        Me.BtnNotaCreditoDetalle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNotaCreditoDetalle.Location = New System.Drawing.Point(567, 497)
        Me.BtnNotaCreditoDetalle.Name = "BtnNotaCreditoDetalle"
        Me.BtnNotaCreditoDetalle.Size = New System.Drawing.Size(136, 27)
        Me.BtnNotaCreditoDetalle.TabIndex = 21
        Me.BtnNotaCreditoDetalle.Text = "Detalle N. Créd."
        Me.BtnNotaCreditoDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNotaCreditoDetalle.UseVisualStyleBackColor = True
        '
        'BtnFacturaDetalle
        '
        Me.BtnFacturaDetalle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnFacturaDetalle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFacturaDetalle.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.FrmFacturaAdministracionViewModelBindingSource, "HabilitarDetalleFacturar", True))
        Me.BtnFacturaDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFacturaDetalle.Image = Global.SistemaCinderella.My.Resources.Recursos.Detalle_Pequeno
        Me.BtnFacturaDetalle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnFacturaDetalle.Location = New System.Drawing.Point(709, 497)
        Me.BtnFacturaDetalle.Name = "BtnFacturaDetalle"
        Me.BtnFacturaDetalle.Size = New System.Drawing.Size(117, 27)
        Me.BtnFacturaDetalle.TabIndex = 19
        Me.BtnFacturaDetalle.Text = "Detalle Fact."
        Me.BtnFacturaDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnFacturaDetalle.UseVisualStyleBackColor = True
        '
        'btnReporteVenta
        '
        Me.btnReporteVenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReporteVenta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReporteVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReporteVenta.Image = Global.SistemaCinderella.My.Resources.Recursos.icono_imprimir
        Me.btnReporteVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReporteVenta.Location = New System.Drawing.Point(471, 497)
        Me.btnReporteVenta.Name = "btnReporteVenta"
        Me.btnReporteVenta.Size = New System.Drawing.Size(90, 27)
        Me.btnReporteVenta.TabIndex = 16
        Me.btnReporteVenta.Text = "Imprimir"
        Me.btnReporteVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReporteVenta.UseVisualStyleBackColor = True
        '
        'BtnEmitirFactura
        '
        Me.BtnEmitirFactura.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEmitirFactura.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEmitirFactura.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.FrmFacturaAdministracionViewModelBindingSource, "HabilitarFacturar", True))
        Me.BtnEmitirFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnEmitirFactura.Image = Global.SistemaCinderella.My.Resources.Recursos.TicketPequeño
        Me.BtnEmitirFactura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEmitirFactura.Location = New System.Drawing.Point(832, 497)
        Me.BtnEmitirFactura.Name = "BtnEmitirFactura"
        Me.BtnEmitirFactura.Size = New System.Drawing.Size(90, 27)
        Me.BtnEmitirFactura.TabIndex = 18
        Me.BtnEmitirFactura.Text = "Facturar"
        Me.BtnEmitirFactura.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEmitirFactura.UseVisualStyleBackColor = True
        '
        'VentaDetalle
        '
        Me.VentaDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VentaDetalle.Location = New System.Drawing.Point(6, 20)
        Me.VentaDetalle.Name = "VentaDetalle"
        Me.VentaDetalle.Size = New System.Drawing.Size(916, 471)
        Me.VentaDetalle.TabIndex = 0
        '
        'frmFacturaAdministracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(954, 737)
        Me.Controls.Add(Me.TabAdministracionFacturas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(900, 650)
        Me.Name = "frmFacturaAdministracion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administración de Facturas"
        CType(Me.DG_facturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FrmFacturaAdministracionViewModelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TabAdministracionFacturas.ResumeLayout(False)
        Me.TabFacturas.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.TabDetalle.ResumeLayout(False)
        Me.Gb_Anulado.ResumeLayout(False)
        Me.Gb_Anulado.PerformLayout()
        Me.lblcontenedor.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DG_facturas As DataGridView
    Friend WithEvents lbl_Msg As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtFacturaNro As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents ChkMarcaManual As CheckBox
    Friend WithEvents ChkMarcaTicket As CheckBox
    Friend WithEvents ChkMarcaElectronica As CheckBox
    Friend WithEvents FDesde As DateTimePicker
    Friend WithEvents FHasta As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents BtnFiltrar As Button
    Friend WithEvents btn_Restablecer As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents txtMontoDesde As TextBox
    Friend WithEvents txtMontoHasta As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtCUIT As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TabAdministracionFacturas As TabControl
    Friend WithEvents TabFacturas As TabPage
    Friend WithEvents TabDetalle As TabPage
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblcontenedor As GroupBox
    Friend WithEvents BtnNotaCreditoDetalle As Button
    Friend WithEvents BtnFacturaDetalle As Button
    Friend WithEvents btnReporteVenta As Button
    Friend WithEvents BtnEmitirFactura As Button
    Friend WithEvents VentaDetalle As VentaDetalle
    Friend WithEvents Gb_Anulado As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDescripcionAnular As TextBox
    Friend WithEvents BtnAnular As Button
    Friend WithEvents FrmFacturaAdministracionViewModelBindingSource As BindingSource
    Friend WithEvents FacturasBindingSource As BindingSource
    Friend WithEvents NumeroDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PuntoVenta As DataGridViewTextBoxColumn
    Friend WithEvents TipoFacturaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CondicionIVADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CUITDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreYApellidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DireccionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LocalidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MontoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
