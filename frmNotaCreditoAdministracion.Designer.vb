<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNotaCreditoAdministracion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNotaCreditoAdministracion))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCUIT = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtMontoHasta = New System.Windows.Forms.TextBox()
        Me.txtMontoDesde = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btn_Restablecer = New System.Windows.Forms.Button()
        Me.BtnFiltrar = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.FHasta = New System.Windows.Forms.DateTimePicker()
        Me.FDesde = New System.Windows.Forms.DateTimePicker()
        Me.ChkMarcaElectronica = New System.Windows.Forms.CheckBox()
        Me.ChkMarcaTicket = New System.Windows.Forms.CheckBox()
        Me.ChkMarcaManual = New System.Windows.Forms.CheckBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtNotaCreditoNro = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lbl_Msg = New System.Windows.Forms.Label()
        Me.DG_NotaCredito = New System.Windows.Forms.DataGridView()
        Me.NumeroNotaCreditoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PuntoVentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocalidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoFacturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoReciboDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Factura = New System.Windows.Forms.DataGridViewImageColumn()
        Me.NotaCreditoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.DG_NotaCredito, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NotaCreditoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.GroupBox1.Controls.Add(Me.txtNotaCreditoNro)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(860, 188)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtrar notas cédito."
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
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(126, 88)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(250, 21)
        Me.txtNombre.TabIndex = 431
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
        'txtMontoHasta
        '
        Me.txtMontoHasta.Location = New System.Drawing.Point(273, 56)
        Me.txtMontoHasta.Name = "txtMontoHasta"
        Me.txtMontoHasta.Size = New System.Drawing.Size(103, 21)
        Me.txtMontoHasta.TabIndex = 428
        '
        'txtMontoDesde
        '
        Me.txtMontoDesde.Location = New System.Drawing.Point(126, 56)
        Me.txtMontoDesde.Name = "txtMontoDesde"
        Me.txtMontoDesde.Size = New System.Drawing.Size(103, 21)
        Me.txtMontoDesde.TabIndex = 427
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
        'FHasta
        '
        Me.FHasta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FHasta.Location = New System.Drawing.Point(604, 56)
        Me.FHasta.Name = "FHasta"
        Me.FHasta.Size = New System.Drawing.Size(250, 21)
        Me.FHasta.TabIndex = 1
        '
        'FDesde
        '
        Me.FDesde.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FDesde.Location = New System.Drawing.Point(604, 24)
        Me.FDesde.Name = "FDesde"
        Me.FDesde.Size = New System.Drawing.Size(250, 21)
        Me.FDesde.TabIndex = 0
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
        'txtNotaCreditoNro
        '
        Me.txtNotaCreditoNro.Location = New System.Drawing.Point(126, 26)
        Me.txtNotaCreditoNro.Name = "txtNotaCreditoNro"
        Me.txtNotaCreditoNro.Size = New System.Drawing.Size(250, 21)
        Me.txtNotaCreditoNro.TabIndex = 418
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(6, 29)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(110, 16)
        Me.Label13.TabIndex = 420
        Me.Label13.Text = "N° Nota Cédito"
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
        Me.lbl_Msg.Size = New System.Drawing.Size(395, 25)
        Me.lbl_Msg.TabIndex = 436
        Me.lbl_Msg.Text = "No se han encontrado notas crédito."
        '
        'DG_NotaCredito
        '
        Me.DG_NotaCredito.AllowUserToAddRows = False
        Me.DG_NotaCredito.AllowUserToDeleteRows = False
        Me.DG_NotaCredito.AllowUserToResizeColumns = False
        Me.DG_NotaCredito.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_NotaCredito.AutoGenerateColumns = False
        Me.DG_NotaCredito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_NotaCredito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_NotaCredito.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumeroNotaCreditoDataGridViewTextBoxColumn, Me.PuntoVentaDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.CuitDataGridViewTextBoxColumn, Me.DireccionDataGridViewTextBoxColumn, Me.LocalidadDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.TipoFacturaDataGridViewTextBoxColumn, Me.TipoReciboDataGridViewTextBoxColumn, Me.MontoDataGridViewTextBoxColumn, Me.Factura})
        Me.DG_NotaCredito.DataSource = Me.NotaCreditoBindingSource
        Me.DG_NotaCredito.Location = New System.Drawing.Point(12, 211)
        Me.DG_NotaCredito.MultiSelect = False
        Me.DG_NotaCredito.Name = "DG_NotaCredito"
        Me.DG_NotaCredito.ReadOnly = True
        Me.DG_NotaCredito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_NotaCredito.Size = New System.Drawing.Size(860, 389)
        Me.DG_NotaCredito.TabIndex = 435
        '
        'NumeroNotaCreditoDataGridViewTextBoxColumn
        '
        Me.NumeroNotaCreditoDataGridViewTextBoxColumn.DataPropertyName = "NumeroNotaCredito"
        Me.NumeroNotaCreditoDataGridViewTextBoxColumn.HeaderText = "Nro"
        Me.NumeroNotaCreditoDataGridViewTextBoxColumn.Name = "NumeroNotaCreditoDataGridViewTextBoxColumn"
        Me.NumeroNotaCreditoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PuntoVentaDataGridViewTextBoxColumn
        '
        Me.PuntoVentaDataGridViewTextBoxColumn.DataPropertyName = "PuntoVenta"
        Me.PuntoVentaDataGridViewTextBoxColumn.HeaderText = "Pt. Venta"
        Me.PuntoVentaDataGridViewTextBoxColumn.Name = "PuntoVentaDataGridViewTextBoxColumn"
        Me.PuntoVentaDataGridViewTextBoxColumn.ReadOnly = True
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
        'MontoDataGridViewTextBoxColumn
        '
        Me.MontoDataGridViewTextBoxColumn.DataPropertyName = "Monto"
        DataGridViewCellStyle1.Format = "C2"
        Me.MontoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.MontoDataGridViewTextBoxColumn.HeaderText = "Monto"
        Me.MontoDataGridViewTextBoxColumn.Name = "MontoDataGridViewTextBoxColumn"
        Me.MontoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Factura
        '
        Me.Factura.HeaderText = "Factura"
        Me.Factura.Image = Global.SistemaCinderella.My.Resources.Recursos.Detalle_Pequeno
        Me.Factura.Name = "Factura"
        Me.Factura.ReadOnly = True
        '
        'NotaCreditoBindingSource
        '
        Me.NotaCreditoBindingSource.DataSource = GetType(Entidades.NotaCredito)
        '
        'frmNotaCreditoAdministracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 612)
        Me.Controls.Add(Me.lbl_Msg)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DG_NotaCredito)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmNotaCreditoAdministracion"
        Me.Text = "Administración de Notas de Crédito"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DG_NotaCredito, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NotaCreditoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtCUIT As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txtMontoHasta As TextBox
    Friend WithEvents txtMontoDesde As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents btn_Restablecer As Button
    Friend WithEvents BtnFiltrar As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents FHasta As DateTimePicker
    Friend WithEvents FDesde As DateTimePicker
    Friend WithEvents ChkMarcaElectronica As CheckBox
    Friend WithEvents ChkMarcaTicket As CheckBox
    Friend WithEvents ChkMarcaManual As CheckBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtNotaCreditoNro As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents lbl_Msg As Label
    Friend WithEvents DG_NotaCredito As DataGridView
    Friend WithEvents NotaCreditoBindingSource As BindingSource
    Friend WithEvents NumeroNotaCreditoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PuntoVentaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CuitDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DireccionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LocalidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoFacturaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoReciboDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MontoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Factura As DataGridViewImageColumn
End Class
