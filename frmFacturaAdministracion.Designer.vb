<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFacturaAdministracion
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFacturaAdministracion))
        Me.DG_facturas = New System.Windows.Forms.DataGridView()
        Me.NumeroFacturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PuntoVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocalidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoFacturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoReciboDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IVADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NotaCredito = New System.Windows.Forms.DataGridViewImageColumn()
        Me.FacturacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.txtCUIT = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DG_facturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DG_facturas
        '
        Me.DG_facturas.AllowUserToAddRows = False
        Me.DG_facturas.AllowUserToDeleteRows = False
        Me.DG_facturas.AllowUserToResizeColumns = False
        Me.DG_facturas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_facturas.AutoGenerateColumns = False
        Me.DG_facturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_facturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_facturas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumeroFacturaDataGridViewTextBoxColumn, Me.PuntoVenta, Me.NombreDataGridViewTextBoxColumn, Me.CuitDataGridViewTextBoxColumn, Me.DireccionDataGridViewTextBoxColumn, Me.LocalidadDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.TipoFacturaDataGridViewTextBoxColumn, Me.TipoReciboDataGridViewTextBoxColumn, Me.SubTotalDataGridViewTextBoxColumn, Me.IVADataGridViewTextBoxColumn, Me.MontoDataGridViewTextBoxColumn, Me.NotaCredito})
        Me.DG_facturas.DataSource = Me.FacturacionBindingSource
        Me.DG_facturas.Location = New System.Drawing.Point(12, 211)
        Me.DG_facturas.MultiSelect = False
        Me.DG_facturas.Name = "DG_facturas"
        Me.DG_facturas.ReadOnly = True
        Me.DG_facturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_facturas.Size = New System.Drawing.Size(860, 389)
        Me.DG_facturas.TabIndex = 0
        '
        'NumeroFacturaDataGridViewTextBoxColumn
        '
        Me.NumeroFacturaDataGridViewTextBoxColumn.DataPropertyName = "NumeroFactura"
        Me.NumeroFacturaDataGridViewTextBoxColumn.HeaderText = "Nro"
        Me.NumeroFacturaDataGridViewTextBoxColumn.Name = "NumeroFacturaDataGridViewTextBoxColumn"
        Me.NumeroFacturaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PuntoVenta
        '
        Me.PuntoVenta.DataPropertyName = "PuntoVenta"
        Me.PuntoVenta.HeaderText = "Pt. Venta"
        Me.PuntoVenta.Name = "PuntoVenta"
        Me.PuntoVenta.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CuitDataGridViewTextBoxColumn
        '
        Me.CuitDataGridViewTextBoxColumn.DataPropertyName = "Cuit"
        Me.CuitDataGridViewTextBoxColumn.HeaderText = "Cuit"
        Me.CuitDataGridViewTextBoxColumn.Name = "CuitDataGridViewTextBoxColumn"
        Me.CuitDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DireccionDataGridViewTextBoxColumn
        '
        Me.DireccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion"
        Me.DireccionDataGridViewTextBoxColumn.HeaderText = "Dirección"
        Me.DireccionDataGridViewTextBoxColumn.Name = "DireccionDataGridViewTextBoxColumn"
        Me.DireccionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LocalidadDataGridViewTextBoxColumn
        '
        Me.LocalidadDataGridViewTextBoxColumn.DataPropertyName = "Localidad"
        Me.LocalidadDataGridViewTextBoxColumn.HeaderText = "Localidad"
        Me.LocalidadDataGridViewTextBoxColumn.Name = "LocalidadDataGridViewTextBoxColumn"
        Me.LocalidadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TipoFacturaDataGridViewTextBoxColumn
        '
        Me.TipoFacturaDataGridViewTextBoxColumn.DataPropertyName = "TipoFactura"
        Me.TipoFacturaDataGridViewTextBoxColumn.HeaderText = "Tipo"
        Me.TipoFacturaDataGridViewTextBoxColumn.Name = "TipoFacturaDataGridViewTextBoxColumn"
        Me.TipoFacturaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TipoReciboDataGridViewTextBoxColumn
        '
        Me.TipoReciboDataGridViewTextBoxColumn.DataPropertyName = "TipoRecibo"
        Me.TipoReciboDataGridViewTextBoxColumn.HeaderText = "Recibo"
        Me.TipoReciboDataGridViewTextBoxColumn.Name = "TipoReciboDataGridViewTextBoxColumn"
        Me.TipoReciboDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SubTotalDataGridViewTextBoxColumn
        '
        Me.SubTotalDataGridViewTextBoxColumn.DataPropertyName = "SubTotal"
        DataGridViewCellStyle1.Format = "C2"
        Me.SubTotalDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.SubTotalDataGridViewTextBoxColumn.HeaderText = "Sub Total"
        Me.SubTotalDataGridViewTextBoxColumn.Name = "SubTotalDataGridViewTextBoxColumn"
        Me.SubTotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IVADataGridViewTextBoxColumn
        '
        Me.IVADataGridViewTextBoxColumn.DataPropertyName = "IVA"
        DataGridViewCellStyle2.Format = "C2"
        Me.IVADataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.IVADataGridViewTextBoxColumn.HeaderText = "IVA"
        Me.IVADataGridViewTextBoxColumn.Name = "IVADataGridViewTextBoxColumn"
        Me.IVADataGridViewTextBoxColumn.ReadOnly = True
        '
        'MontoDataGridViewTextBoxColumn
        '
        Me.MontoDataGridViewTextBoxColumn.DataPropertyName = "Monto"
        DataGridViewCellStyle3.Format = "C2"
        Me.MontoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.MontoDataGridViewTextBoxColumn.HeaderText = "Monto"
        Me.MontoDataGridViewTextBoxColumn.Name = "MontoDataGridViewTextBoxColumn"
        Me.MontoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NotaCredito
        '
        Me.NotaCredito.HeaderText = "Nota Crédito"
        Me.NotaCredito.Image = Global.SistemaCinderella.My.Resources.Recursos.Detalle_Pequeno
        Me.NotaCredito.Name = "NotaCredito"
        Me.NotaCredito.ReadOnly = True
        '
        'FacturacionBindingSource
        '
        Me.FacturacionBindingSource.DataSource = GetType(Entidades.Facturacion)
        '
        'lbl_Msg
        '
        Me.lbl_Msg.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Msg.AutoSize = True
        Me.lbl_Msg.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lbl_Msg.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Msg.Location = New System.Drawing.Point(253, 369)
        Me.lbl_Msg.Name = "lbl_Msg"
        Me.lbl_Msg.Size = New System.Drawing.Size(343, 25)
        Me.lbl_Msg.TabIndex = 3
        Me.lbl_Msg.Text = "No se han encontrado facturas."
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(6, 29)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 16)
        Me.Label13.TabIndex = 420
        Me.Label13.Text = "N° Factura"
        '
        'txtFacturaNro
        '
        Me.txtFacturaNro.Location = New System.Drawing.Point(126, 26)
        Me.txtFacturaNro.Name = "txtFacturaNro"
        Me.txtFacturaNro.Size = New System.Drawing.Size(250, 21)
        Me.txtFacturaNro.TabIndex = 418
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(484, 91)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(101, 16)
        Me.Label17.TabIndex = 422
        Me.Label17.Text = "Comprobante"
        '
        'ChkMarcaManual
        '
        Me.ChkMarcaManual.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkMarcaManual.AutoSize = True
        Me.ChkMarcaManual.Checked = True
        Me.ChkMarcaManual.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkMarcaManual.Location = New System.Drawing.Point(604, 88)
        Me.ChkMarcaManual.Name = "ChkMarcaManual"
        Me.ChkMarcaManual.Size = New System.Drawing.Size(68, 19)
        Me.ChkMarcaManual.TabIndex = 424
        Me.ChkMarcaManual.Text = "Manual"
        Me.ChkMarcaManual.UseVisualStyleBackColor = True
        '
        'ChkMarcaTicket
        '
        Me.ChkMarcaTicket.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkMarcaTicket.AutoSize = True
        Me.ChkMarcaTicket.Checked = True
        Me.ChkMarcaTicket.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkMarcaTicket.Location = New System.Drawing.Point(690, 88)
        Me.ChkMarcaTicket.Name = "ChkMarcaTicket"
        Me.ChkMarcaTicket.Size = New System.Drawing.Size(58, 19)
        Me.ChkMarcaTicket.TabIndex = 425
        Me.ChkMarcaTicket.Text = "Ticket"
        Me.ChkMarcaTicket.UseVisualStyleBackColor = True
        '
        'ChkMarcaElectronica
        '
        Me.ChkMarcaElectronica.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkMarcaElectronica.AutoSize = True
        Me.ChkMarcaElectronica.Checked = True
        Me.ChkMarcaElectronica.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkMarcaElectronica.Location = New System.Drawing.Point(767, 88)
        Me.ChkMarcaElectronica.Name = "ChkMarcaElectronica"
        Me.ChkMarcaElectronica.Size = New System.Drawing.Size(87, 19)
        Me.ChkMarcaElectronica.TabIndex = 426
        Me.ChkMarcaElectronica.Text = "Electronica"
        Me.ChkMarcaElectronica.UseVisualStyleBackColor = True
        '
        'FDesde
        '
        Me.FDesde.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FDesde.Location = New System.Drawing.Point(604, 24)
        Me.FDesde.Name = "FDesde"
        Me.FDesde.Size = New System.Drawing.Size(250, 21)
        Me.FDesde.TabIndex = 0
        '
        'FHasta
        '
        Me.FHasta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FHasta.Location = New System.Drawing.Point(604, 56)
        Me.FHasta.Name = "FHasta"
        Me.FHasta.Size = New System.Drawing.Size(250, 21)
        Me.FHasta.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(484, 61)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 16)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Fecha hasta"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(484, 29)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(99, 16)
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
        Me.BtnFiltrar.Location = New System.Drawing.Point(754, 141)
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
        Me.btn_Restablecer.Location = New System.Drawing.Point(648, 141)
        Me.btn_Restablecer.Name = "btn_Restablecer"
        Me.btn_Restablecer.Size = New System.Drawing.Size(100, 40)
        Me.btn_Restablecer.TabIndex = 9
        Me.btn_Restablecer.Text = "Restablecer Busqueda"
        Me.btn_Restablecer.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(6, 59)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(50, 16)
        Me.Label19.TabIndex = 429
        Me.Label19.Text = "Monto"
        '
        'txtMontoDesde
        '
        Me.txtMontoDesde.Location = New System.Drawing.Point(126, 56)
        Me.txtMontoDesde.Name = "txtMontoDesde"
        Me.txtMontoDesde.Size = New System.Drawing.Size(103, 21)
        Me.txtMontoDesde.TabIndex = 427
        '
        'txtMontoHasta
        '
        Me.txtMontoHasta.Location = New System.Drawing.Point(273, 56)
        Me.txtMontoHasta.Name = "txtMontoHasta"
        Me.txtMontoHasta.Size = New System.Drawing.Size(103, 21)
        Me.txtMontoHasta.TabIndex = 428
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(243, 59)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(13, 16)
        Me.Label18.TabIndex = 430
        Me.Label18.Text = "-"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 16)
        Me.Label1.TabIndex = 432
        Me.Label1.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(126, 88)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(250, 21)
        Me.txtNombre.TabIndex = 431
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtCUIT)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.txtMontoHasta)
        Me.GroupBox1.Controls.Add(Me.txtMontoDesde)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.btn_Restablecer)
        Me.GroupBox1.Controls.Add(Me.BtnFiltrar)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.FHasta)
        Me.GroupBox1.Controls.Add(Me.FDesde)
        Me.GroupBox1.Controls.Add(Me.ChkMarcaElectronica)
        Me.GroupBox1.Controls.Add(Me.ChkMarcaTicket)
        Me.GroupBox1.Controls.Add(Me.ChkMarcaManual)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.txtFacturaNro)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(860, 188)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtrar facturas."
        '
        'txtCUIT
        '
        Me.txtCUIT.Location = New System.Drawing.Point(126, 117)
        Me.txtCUIT.Name = "txtCUIT"
        Me.txtCUIT.Size = New System.Drawing.Size(250, 21)
        Me.txtCUIT.TabIndex = 433
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 16)
        Me.Label2.TabIndex = 434
        Me.Label2.Text = "CUIT"
        '
        'frmFacturaAdministracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 612)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbl_Msg)
        Me.Controls.Add(Me.DG_facturas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmFacturaAdministracion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administración de Facturas"
        CType(Me.DG_facturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DG_facturas As DataGridView
    Friend WithEvents FacturacionBindingSource As BindingSource
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
    Friend WithEvents NumeroFacturaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PuntoVenta As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CuitDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DireccionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LocalidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoFacturaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoReciboDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SubTotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IVADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MontoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NotaCredito As DataGridViewImageColumn
End Class
