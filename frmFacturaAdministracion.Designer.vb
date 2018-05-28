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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtCUIT = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabAdministracionFacturas = New System.Windows.Forms.TabControl()
        Me.TabFacturas = New System.Windows.Forms.TabPage()
        Me.TabDetalle = New System.Windows.Forms.TabPage()
        Me.lblcontenedor = New System.Windows.Forms.GroupBox()
        Me.Gb_Anulado = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDescripcionAnular = New System.Windows.Forms.TextBox()
        Me.BtnAnular = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblPorcentajeFacturacion = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblSucursal = New System.Windows.Forms.Label()
        Me.lblEncargado = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblVenta = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblVendedor = New System.Windows.Forms.Label()
        Me.PanelTotalMinoristaSenia = New System.Windows.Forms.Panel()
        Me.lblPendienteAbonarMinorista = New System.Windows.Forms.Label()
        Me.lblPendienteAbonarMinoristaDescripcion = New System.Windows.Forms.Label()
        Me.lblSeniaMinorista = New System.Windows.Forms.Label()
        Me.lblSeniaMinoristaDescripcion = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblMontoMinoristaDescripcion = New System.Windows.Forms.Label()
        Me.lblMontoMinorista = New System.Windows.Forms.Label()
        Me.lblDescuentoMinorista = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblSubtotalMinorista = New System.Windows.Forms.Label()
        Me.PanelTotalMayorista = New System.Windows.Forms.Panel()
        Me.lblPendienteAbonarMayorista = New System.Windows.Forms.Label()
        Me.lblPendienteAbonarMayoristaDescripcion = New System.Windows.Forms.Label()
        Me.lblSeniaMayorista = New System.Windows.Forms.Label()
        Me.lblSeniaMayoristaDescripcion = New System.Windows.Forms.Label()
        Me.lblIVAMayorista = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.lblSubtotalMayorista = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lblDescuentoMayorista = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.lblMontoMayorista = New System.Windows.Forms.Label()
        Me.lblMontoMayoristaDescripcion = New System.Windows.Forms.Label()
        Me.lblFacturado = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.lblPago = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DG_Productos = New System.Windows.Forms.DataGridView()
        Me.NUMERO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODIGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANTIDAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRECIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MONTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SUBTOTAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lblAnulado = New System.Windows.Forms.Label()
        CType(Me.DG_facturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TabAdministracionFacturas.SuspendLayout()
        Me.TabFacturas.SuspendLayout()
        Me.TabDetalle.SuspendLayout()
        Me.lblcontenedor.SuspendLayout()
        Me.Gb_Anulado.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.PanelTotalMinoristaSenia.SuspendLayout()
        Me.PanelTotalMayorista.SuspendLayout()
        CType(Me.DG_Productos, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DG_facturas.Location = New System.Drawing.Point(3, 191)
        Me.DG_facturas.MultiSelect = False
        Me.DG_facturas.Name = "DG_facturas"
        Me.DG_facturas.ReadOnly = True
        Me.DG_facturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_facturas.Size = New System.Drawing.Size(867, 382)
        Me.DG_facturas.TabIndex = 0
        '
        'NumeroFacturaDataGridViewTextBoxColumn
        '
        Me.NumeroFacturaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.NumeroFacturaDataGridViewTextBoxColumn.DataPropertyName = "NumeroFactura"
        Me.NumeroFacturaDataGridViewTextBoxColumn.HeaderText = "Nro"
        Me.NumeroFacturaDataGridViewTextBoxColumn.Name = "NumeroFacturaDataGridViewTextBoxColumn"
        Me.NumeroFacturaDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumeroFacturaDataGridViewTextBoxColumn.Width = 60
        '
        'PuntoVenta
        '
        Me.PuntoVenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.PuntoVenta.DataPropertyName = "PuntoVenta"
        Me.PuntoVenta.HeaderText = "Pt. Venta"
        Me.PuntoVenta.Name = "PuntoVenta"
        Me.PuntoVenta.ReadOnly = True
        Me.PuntoVenta.Width = 50
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
        Me.TipoFacturaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.TipoFacturaDataGridViewTextBoxColumn.DataPropertyName = "TipoFactura"
        Me.TipoFacturaDataGridViewTextBoxColumn.HeaderText = "Tipo"
        Me.TipoFacturaDataGridViewTextBoxColumn.Name = "TipoFacturaDataGridViewTextBoxColumn"
        Me.TipoFacturaDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoFacturaDataGridViewTextBoxColumn.Width = 40
        '
        'TipoReciboDataGridViewTextBoxColumn
        '
        Me.TipoReciboDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.TipoReciboDataGridViewTextBoxColumn.DataPropertyName = "TipoRecibo"
        Me.TipoReciboDataGridViewTextBoxColumn.HeaderText = "Recibo"
        Me.TipoReciboDataGridViewTextBoxColumn.Name = "TipoReciboDataGridViewTextBoxColumn"
        Me.TipoReciboDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoReciboDataGridViewTextBoxColumn.Width = 50
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
        Me.NotaCredito.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.NotaCredito.HeaderText = "Nota Crédito"
        Me.NotaCredito.Image = Global.SistemaCinderella.My.Resources.Recursos.Detalle_Pequeno
        Me.NotaCredito.Name = "NotaCredito"
        Me.NotaCredito.ReadOnly = True
        Me.NotaCredito.Width = 50
        '
        'FacturacionBindingSource
        '
        Me.FacturacionBindingSource.DataSource = GetType(Entidades.Facturacion)
        '
        'lbl_Msg
        '
        Me.lbl_Msg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Msg.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lbl_Msg.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Msg.Location = New System.Drawing.Point(265, 373)
        Me.lbl_Msg.MinimumSize = New System.Drawing.Size(343, 26)
        Me.lbl_Msg.Name = "lbl_Msg"
        Me.lbl_Msg.Size = New System.Drawing.Size(343, 26)
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
        Me.txtFacturaNro.Location = New System.Drawing.Point(143, 4)
        Me.txtFacturaNro.Name = "txtFacturaNro"
        Me.txtFacturaNro.Size = New System.Drawing.Size(240, 21)
        Me.txtFacturaNro.TabIndex = 418
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(469, 69)
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
        Me.ChkMarcaElectronica.Location = New System.Drawing.Point(163, 3)
        Me.ChkMarcaElectronica.Name = "ChkMarcaElectronica"
        Me.ChkMarcaElectronica.Size = New System.Drawing.Size(74, 18)
        Me.ChkMarcaElectronica.TabIndex = 426
        Me.ChkMarcaElectronica.Text = "Electronica"
        Me.ChkMarcaElectronica.UseVisualStyleBackColor = True
        '
        'FDesde
        '
        Me.FDesde.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FDesde.Location = New System.Drawing.Point(609, 4)
        Me.FDesde.Name = "FDesde"
        Me.FDesde.Size = New System.Drawing.Size(240, 21)
        Me.FDesde.TabIndex = 0
        '
        'FHasta
        '
        Me.FHasta.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FHasta.Location = New System.Drawing.Point(609, 35)
        Me.FHasta.Name = "FHasta"
        Me.FHasta.Size = New System.Drawing.Size(240, 21)
        Me.FHasta.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(469, 38)
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
        Me.Label12.Location = New System.Drawing.Point(469, 7)
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
        Me.BtnFiltrar.Location = New System.Drawing.Point(758, 133)
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
        Me.btn_Restablecer.Location = New System.Drawing.Point(652, 133)
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
        Me.txtMontoDesde.Location = New System.Drawing.Point(3, 3)
        Me.txtMontoDesde.Name = "txtMontoDesde"
        Me.txtMontoDesde.Size = New System.Drawing.Size(104, 21)
        Me.txtMontoDesde.TabIndex = 427
        '
        'txtMontoHasta
        '
        Me.txtMontoHasta.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMontoHasta.Location = New System.Drawing.Point(133, 3)
        Me.txtMontoHasta.Name = "txtMontoHasta"
        Me.txtMontoHasta.Size = New System.Drawing.Size(104, 21)
        Me.txtMontoHasta.TabIndex = 428
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(113, 5)
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
        Me.txtNombre.Location = New System.Drawing.Point(143, 66)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(240, 21)
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
        Me.GroupBox1.Size = New System.Drawing.Size(864, 179)
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
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(852, 122)
        Me.TableLayoutPanel2.TabIndex = 435
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 3
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.ChkMarcaManual, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.ChkMarcaTicket, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.ChkMarcaElectronica, 2, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(609, 65)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(240, 24)
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
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(240, 26)
        Me.TableLayoutPanel3.TabIndex = 436
        '
        'txtCUIT
        '
        Me.txtCUIT.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCUIT.Location = New System.Drawing.Point(143, 96)
        Me.txtCUIT.Name = "txtCUIT"
        Me.txtCUIT.Size = New System.Drawing.Size(240, 21)
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
        Me.TabAdministracionFacturas.Size = New System.Drawing.Size(884, 612)
        Me.TabAdministracionFacturas.TabIndex = 5
        '
        'TabFacturas
        '
        Me.TabFacturas.Controls.Add(Me.GroupBox1)
        Me.TabFacturas.Controls.Add(Me.lbl_Msg)
        Me.TabFacturas.Controls.Add(Me.DG_facturas)
        Me.TabFacturas.Location = New System.Drawing.Point(4, 29)
        Me.TabFacturas.Name = "TabFacturas"
        Me.TabFacturas.Padding = New System.Windows.Forms.Padding(3)
        Me.TabFacturas.Size = New System.Drawing.Size(876, 579)
        Me.TabFacturas.TabIndex = 0
        Me.TabFacturas.Text = "Facturas"
        Me.TabFacturas.UseVisualStyleBackColor = True
        '
        'TabDetalle
        '
        Me.TabDetalle.Controls.Add(Me.lblcontenedor)
        Me.TabDetalle.Location = New System.Drawing.Point(4, 29)
        Me.TabDetalle.Name = "TabDetalle"
        Me.TabDetalle.Padding = New System.Windows.Forms.Padding(3)
        Me.TabDetalle.Size = New System.Drawing.Size(876, 579)
        Me.TabDetalle.TabIndex = 1
        Me.TabDetalle.Text = "Detalle Factura"
        Me.TabDetalle.UseVisualStyleBackColor = True
        '
        'lblcontenedor
        '
        Me.lblcontenedor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblcontenedor.Controls.Add(Me.Gb_Anulado)
        Me.lblcontenedor.Controls.Add(Me.TableLayoutPanel1)
        Me.lblcontenedor.Controls.Add(Me.PanelTotalMinoristaSenia)
        Me.lblcontenedor.Controls.Add(Me.PanelTotalMayorista)
        Me.lblcontenedor.Controls.Add(Me.lblFacturado)
        Me.lblcontenedor.Controls.Add(Me.label8)
        Me.lblcontenedor.Controls.Add(Me.lblCantidad)
        Me.lblcontenedor.Controls.Add(Me.lblPago)
        Me.lblcontenedor.Controls.Add(Me.Label7)
        Me.lblcontenedor.Controls.Add(Me.DG_Productos)
        Me.lblcontenedor.Controls.Add(Me.Label20)
        Me.lblcontenedor.Controls.Add(Me.lblAnulado)
        Me.lblcontenedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcontenedor.Location = New System.Drawing.Point(8, 7)
        Me.lblcontenedor.Name = "lblcontenedor"
        Me.lblcontenedor.Size = New System.Drawing.Size(860, 565)
        Me.lblcontenedor.TabIndex = 1
        Me.lblcontenedor.TabStop = False
        Me.lblcontenedor.Text = "Información de la venta realizada."
        '
        'Gb_Anulado
        '
        Me.Gb_Anulado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gb_Anulado.Controls.Add(Me.Label9)
        Me.Gb_Anulado.Controls.Add(Me.txtDescripcionAnular)
        Me.Gb_Anulado.Controls.Add(Me.BtnAnular)
        Me.Gb_Anulado.Location = New System.Drawing.Point(589, 403)
        Me.Gb_Anulado.Name = "Gb_Anulado"
        Me.Gb_Anulado.Size = New System.Drawing.Size(262, 149)
        Me.Gb_Anulado.TabIndex = 73
        Me.Gb_Anulado.TabStop = False
        Me.Gb_Anulado.Text = "Anular Venta"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 15)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Motivo"
        '
        'txtDescripcionAnular
        '
        Me.txtDescripcionAnular.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescripcionAnular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionAnular.Location = New System.Drawing.Point(55, 27)
        Me.txtDescripcionAnular.Multiline = True
        Me.txtDescripcionAnular.Name = "txtDescripcionAnular"
        Me.txtDescripcionAnular.Size = New System.Drawing.Size(194, 83)
        Me.txtDescripcionAnular.TabIndex = 15
        '
        'BtnAnular
        '
        Me.BtnAnular.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAnular.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAnular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAnular.Image = Global.SistemaCinderella.My.Resources.Recursos.Desconectado
        Me.BtnAnular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAnular.Location = New System.Drawing.Point(171, 116)
        Me.BtnAnular.Name = "BtnAnular"
        Me.BtnAnular.Size = New System.Drawing.Size(78, 27)
        Me.BtnAnular.TabIndex = 14
        Me.BtnAnular.Text = "Anular"
        Me.BtnAnular.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAnular.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 8
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblPorcentajeFacturacion, 7, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label21, 6, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblSucursal, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblEncargado, 5, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label16, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblFecha, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblCliente, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblVenta, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblVendedor, 3, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(6, 27)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(848, 60)
        Me.TableLayoutPanel1.TabIndex = 72
        '
        'lblPorcentajeFacturacion
        '
        Me.lblPorcentajeFacturacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPorcentajeFacturacion.AutoSize = True
        Me.lblPorcentajeFacturacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPorcentajeFacturacion.Location = New System.Drawing.Point(749, 7)
        Me.lblPorcentajeFacturacion.Name = "lblPorcentajeFacturacion"
        Me.lblPorcentajeFacturacion.Size = New System.Drawing.Size(96, 15)
        Me.lblPorcentajeFacturacion.TabIndex = 70
        Me.lblPorcentajeFacturacion.Text = "- - - - - "
        '
        'Label21
        '
        Me.Label21.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label21.Location = New System.Drawing.Point(639, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(104, 30)
        Me.Label21.TabIndex = 69
        Me.Label21.Text = "Porcentaje Facturación :"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Sucursal :"
        '
        'lblSucursal
        '
        Me.lblSucursal.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSucursal.AutoSize = True
        Me.lblSucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSucursal.Location = New System.Drawing.Point(113, 7)
        Me.lblSucursal.Name = "lblSucursal"
        Me.lblSucursal.Size = New System.Drawing.Size(96, 15)
        Me.lblSucursal.TabIndex = 18
        Me.lblSucursal.Text = "- - - - - "
        '
        'lblEncargado
        '
        Me.lblEncargado.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEncargado.AutoSize = True
        Me.lblEncargado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEncargado.Location = New System.Drawing.Point(537, 37)
        Me.lblEncargado.Name = "lblEncargado"
        Me.lblEncargado.Size = New System.Drawing.Size(96, 15)
        Me.lblEncargado.TabIndex = 36
        Me.lblEncargado.Text = "- - - - - "
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Fecha :"
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(427, 37)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(104, 15)
        Me.Label16.TabIndex = 35
        Me.Label16.Text = "Encargado :"
        '
        'lblFecha
        '
        Me.lblFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(113, 37)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(96, 15)
        Me.lblFecha.TabIndex = 17
        Me.lblFecha.Text = "- - - - - "
        '
        'lblCliente
        '
        Me.lblCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.Location = New System.Drawing.Point(537, 7)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(96, 15)
        Me.lblCliente.TabIndex = 27
        Me.lblCliente.Text = "- - - - - "
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(215, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tipo de Venta :"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(215, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Vendedor :"
        '
        'lblVenta
        '
        Me.lblVenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVenta.AutoSize = True
        Me.lblVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVenta.Location = New System.Drawing.Point(325, 7)
        Me.lblVenta.Name = "lblVenta"
        Me.lblVenta.Size = New System.Drawing.Size(96, 15)
        Me.lblVenta.TabIndex = 20
        Me.lblVenta.Text = "- - - - - "
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(427, 7)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 15)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Cliente :"
        '
        'lblVendedor
        '
        Me.lblVendedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVendedor.AutoSize = True
        Me.lblVendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVendedor.Location = New System.Drawing.Point(325, 37)
        Me.lblVendedor.Name = "lblVendedor"
        Me.lblVendedor.Size = New System.Drawing.Size(96, 15)
        Me.lblVendedor.TabIndex = 19
        Me.lblVendedor.Text = "- - - - - "
        '
        'PanelTotalMinoristaSenia
        '
        Me.PanelTotalMinoristaSenia.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelTotalMinoristaSenia.Controls.Add(Me.lblPendienteAbonarMinorista)
        Me.PanelTotalMinoristaSenia.Controls.Add(Me.lblPendienteAbonarMinoristaDescripcion)
        Me.PanelTotalMinoristaSenia.Controls.Add(Me.lblSeniaMinorista)
        Me.PanelTotalMinoristaSenia.Controls.Add(Me.lblSeniaMinoristaDescripcion)
        Me.PanelTotalMinoristaSenia.Controls.Add(Me.Label14)
        Me.PanelTotalMinoristaSenia.Controls.Add(Me.lblMontoMinoristaDescripcion)
        Me.PanelTotalMinoristaSenia.Controls.Add(Me.lblMontoMinorista)
        Me.PanelTotalMinoristaSenia.Controls.Add(Me.lblDescuentoMinorista)
        Me.PanelTotalMinoristaSenia.Controls.Add(Me.Label15)
        Me.PanelTotalMinoristaSenia.Controls.Add(Me.lblSubtotalMinorista)
        Me.PanelTotalMinoristaSenia.Location = New System.Drawing.Point(4, 403)
        Me.PanelTotalMinoristaSenia.Name = "PanelTotalMinoristaSenia"
        Me.PanelTotalMinoristaSenia.Size = New System.Drawing.Size(258, 141)
        Me.PanelTotalMinoristaSenia.TabIndex = 40
        '
        'lblPendienteAbonarMinorista
        '
        Me.lblPendienteAbonarMinorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblPendienteAbonarMinorista.AutoSize = True
        Me.lblPendienteAbonarMinorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPendienteAbonarMinorista.Location = New System.Drawing.Point(193, 119)
        Me.lblPendienteAbonarMinorista.Name = "lblPendienteAbonarMinorista"
        Me.lblPendienteAbonarMinorista.Size = New System.Drawing.Size(42, 15)
        Me.lblPendienteAbonarMinorista.TabIndex = 52
        Me.lblPendienteAbonarMinorista.Text = "- - - - - "
        '
        'lblPendienteAbonarMinoristaDescripcion
        '
        Me.lblPendienteAbonarMinoristaDescripcion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblPendienteAbonarMinoristaDescripcion.AutoSize = True
        Me.lblPendienteAbonarMinoristaDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblPendienteAbonarMinoristaDescripcion.Location = New System.Drawing.Point(3, 119)
        Me.lblPendienteAbonarMinoristaDescripcion.Name = "lblPendienteAbonarMinoristaDescripcion"
        Me.lblPendienteAbonarMinoristaDescripcion.Size = New System.Drawing.Size(141, 15)
        Me.lblPendienteAbonarMinoristaDescripcion.TabIndex = 51
        Me.lblPendienteAbonarMinoristaDescripcion.Text = "Pendiente a Abonar :"
        '
        'lblSeniaMinorista
        '
        Me.lblSeniaMinorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSeniaMinorista.AutoSize = True
        Me.lblSeniaMinorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeniaMinorista.Location = New System.Drawing.Point(193, 94)
        Me.lblSeniaMinorista.Name = "lblSeniaMinorista"
        Me.lblSeniaMinorista.Size = New System.Drawing.Size(42, 15)
        Me.lblSeniaMinorista.TabIndex = 50
        Me.lblSeniaMinorista.Text = "- - - - - "
        '
        'lblSeniaMinoristaDescripcion
        '
        Me.lblSeniaMinoristaDescripcion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSeniaMinoristaDescripcion.AutoSize = True
        Me.lblSeniaMinoristaDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSeniaMinoristaDescripcion.Location = New System.Drawing.Point(3, 94)
        Me.lblSeniaMinoristaDescripcion.Name = "lblSeniaMinoristaDescripcion"
        Me.lblSeniaMinoristaDescripcion.Size = New System.Drawing.Size(48, 15)
        Me.lblSeniaMinoristaDescripcion.TabIndex = 49
        Me.lblSeniaMinoristaDescripcion.Text = "Seña :"
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(3, 38)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(83, 15)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "Descuento :"
        '
        'lblMontoMinoristaDescripcion
        '
        Me.lblMontoMinoristaDescripcion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblMontoMinoristaDescripcion.AutoSize = True
        Me.lblMontoMinoristaDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontoMinoristaDescripcion.Location = New System.Drawing.Point(3, 66)
        Me.lblMontoMinoristaDescripcion.Name = "lblMontoMinoristaDescripcion"
        Me.lblMontoMinoristaDescripcion.Size = New System.Drawing.Size(87, 15)
        Me.lblMontoMinoristaDescripcion.TabIndex = 13
        Me.lblMontoMinoristaDescripcion.Text = "Monto total :"
        '
        'lblMontoMinorista
        '
        Me.lblMontoMinorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblMontoMinorista.AutoSize = True
        Me.lblMontoMinorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontoMinorista.Location = New System.Drawing.Point(193, 66)
        Me.lblMontoMinorista.Name = "lblMontoMinorista"
        Me.lblMontoMinorista.Size = New System.Drawing.Size(42, 15)
        Me.lblMontoMinorista.TabIndex = 23
        Me.lblMontoMinorista.Text = "- - - - - "
        '
        'lblDescuentoMinorista
        '
        Me.lblDescuentoMinorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDescuentoMinorista.AutoSize = True
        Me.lblDescuentoMinorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescuentoMinorista.Location = New System.Drawing.Point(193, 38)
        Me.lblDescuentoMinorista.Name = "lblDescuentoMinorista"
        Me.lblDescuentoMinorista.Size = New System.Drawing.Size(42, 15)
        Me.lblDescuentoMinorista.TabIndex = 32
        Me.lblDescuentoMinorista.Text = "- - - - - "
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(3, 11)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(68, 15)
        Me.Label15.TabIndex = 33
        Me.Label15.Text = "Subtotal :"
        '
        'lblSubtotalMinorista
        '
        Me.lblSubtotalMinorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSubtotalMinorista.AutoSize = True
        Me.lblSubtotalMinorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtotalMinorista.Location = New System.Drawing.Point(193, 11)
        Me.lblSubtotalMinorista.Name = "lblSubtotalMinorista"
        Me.lblSubtotalMinorista.Size = New System.Drawing.Size(42, 15)
        Me.lblSubtotalMinorista.TabIndex = 34
        Me.lblSubtotalMinorista.Text = "- - - - - "
        '
        'PanelTotalMayorista
        '
        Me.PanelTotalMayorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelTotalMayorista.Controls.Add(Me.lblPendienteAbonarMayorista)
        Me.PanelTotalMayorista.Controls.Add(Me.lblPendienteAbonarMayoristaDescripcion)
        Me.PanelTotalMayorista.Controls.Add(Me.lblSeniaMayorista)
        Me.PanelTotalMayorista.Controls.Add(Me.lblSeniaMayoristaDescripcion)
        Me.PanelTotalMayorista.Controls.Add(Me.lblIVAMayorista)
        Me.PanelTotalMayorista.Controls.Add(Me.Label28)
        Me.PanelTotalMayorista.Controls.Add(Me.lblSubtotalMayorista)
        Me.PanelTotalMayorista.Controls.Add(Me.Label22)
        Me.PanelTotalMayorista.Controls.Add(Me.lblDescuentoMayorista)
        Me.PanelTotalMayorista.Controls.Add(Me.Label24)
        Me.PanelTotalMayorista.Controls.Add(Me.lblMontoMayorista)
        Me.PanelTotalMayorista.Controls.Add(Me.lblMontoMayoristaDescripcion)
        Me.PanelTotalMayorista.Location = New System.Drawing.Point(268, 403)
        Me.PanelTotalMayorista.Name = "PanelTotalMayorista"
        Me.PanelTotalMayorista.Size = New System.Drawing.Size(298, 140)
        Me.PanelTotalMayorista.TabIndex = 39
        '
        'lblPendienteAbonarMayorista
        '
        Me.lblPendienteAbonarMayorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblPendienteAbonarMayorista.AutoSize = True
        Me.lblPendienteAbonarMayorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPendienteAbonarMayorista.Location = New System.Drawing.Point(193, 119)
        Me.lblPendienteAbonarMayorista.Name = "lblPendienteAbonarMayorista"
        Me.lblPendienteAbonarMayorista.Size = New System.Drawing.Size(42, 15)
        Me.lblPendienteAbonarMayorista.TabIndex = 56
        Me.lblPendienteAbonarMayorista.Text = "- - - - - "
        '
        'lblPendienteAbonarMayoristaDescripcion
        '
        Me.lblPendienteAbonarMayoristaDescripcion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblPendienteAbonarMayoristaDescripcion.AutoSize = True
        Me.lblPendienteAbonarMayoristaDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblPendienteAbonarMayoristaDescripcion.Location = New System.Drawing.Point(3, 119)
        Me.lblPendienteAbonarMayoristaDescripcion.Name = "lblPendienteAbonarMayoristaDescripcion"
        Me.lblPendienteAbonarMayoristaDescripcion.Size = New System.Drawing.Size(141, 15)
        Me.lblPendienteAbonarMayoristaDescripcion.TabIndex = 55
        Me.lblPendienteAbonarMayoristaDescripcion.Text = "Pendiente a Abonar :"
        '
        'lblSeniaMayorista
        '
        Me.lblSeniaMayorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSeniaMayorista.AutoSize = True
        Me.lblSeniaMayorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeniaMayorista.Location = New System.Drawing.Point(193, 97)
        Me.lblSeniaMayorista.Name = "lblSeniaMayorista"
        Me.lblSeniaMayorista.Size = New System.Drawing.Size(42, 15)
        Me.lblSeniaMayorista.TabIndex = 54
        Me.lblSeniaMayorista.Text = "- - - - - "
        '
        'lblSeniaMayoristaDescripcion
        '
        Me.lblSeniaMayoristaDescripcion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSeniaMayoristaDescripcion.AutoSize = True
        Me.lblSeniaMayoristaDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSeniaMayoristaDescripcion.Location = New System.Drawing.Point(3, 97)
        Me.lblSeniaMayoristaDescripcion.Name = "lblSeniaMayoristaDescripcion"
        Me.lblSeniaMayoristaDescripcion.Size = New System.Drawing.Size(48, 15)
        Me.lblSeniaMayoristaDescripcion.TabIndex = 53
        Me.lblSeniaMayoristaDescripcion.Text = "Seña :"
        '
        'lblIVAMayorista
        '
        Me.lblIVAMayorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblIVAMayorista.AutoSize = True
        Me.lblIVAMayorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIVAMayorista.Location = New System.Drawing.Point(193, 53)
        Me.lblIVAMayorista.Name = "lblIVAMayorista"
        Me.lblIVAMayorista.Size = New System.Drawing.Size(42, 15)
        Me.lblIVAMayorista.TabIndex = 42
        Me.lblIVAMayorista.Text = "- - - - - "
        '
        'Label28
        '
        Me.Label28.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(3, 53)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(67, 15)
        Me.Label28.TabIndex = 41
        Me.Label28.Text = "IVA 21% :"
        '
        'lblSubtotalMayorista
        '
        Me.lblSubtotalMayorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSubtotalMayorista.AutoSize = True
        Me.lblSubtotalMayorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtotalMayorista.Location = New System.Drawing.Point(193, 31)
        Me.lblSubtotalMayorista.Name = "lblSubtotalMayorista"
        Me.lblSubtotalMayorista.Size = New System.Drawing.Size(42, 15)
        Me.lblSubtotalMayorista.TabIndex = 40
        Me.lblSubtotalMayorista.Text = "- - - - - "
        '
        'Label22
        '
        Me.Label22.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(3, 31)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(68, 15)
        Me.Label22.TabIndex = 39
        Me.Label22.Text = "Subtotal :"
        '
        'lblDescuentoMayorista
        '
        Me.lblDescuentoMayorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDescuentoMayorista.AutoSize = True
        Me.lblDescuentoMayorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescuentoMayorista.Location = New System.Drawing.Point(193, 9)
        Me.lblDescuentoMayorista.Name = "lblDescuentoMayorista"
        Me.lblDescuentoMayorista.Size = New System.Drawing.Size(42, 15)
        Me.lblDescuentoMayorista.TabIndex = 38
        Me.lblDescuentoMayorista.Text = "- - - - - "
        '
        'Label24
        '
        Me.Label24.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(3, 9)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(83, 15)
        Me.Label24.TabIndex = 37
        Me.Label24.Text = "Descuento :"
        '
        'lblMontoMayorista
        '
        Me.lblMontoMayorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblMontoMayorista.AutoSize = True
        Me.lblMontoMayorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontoMayorista.Location = New System.Drawing.Point(193, 75)
        Me.lblMontoMayorista.Name = "lblMontoMayorista"
        Me.lblMontoMayorista.Size = New System.Drawing.Size(42, 15)
        Me.lblMontoMayorista.TabIndex = 36
        Me.lblMontoMayorista.Text = "- - - - - "
        '
        'lblMontoMayoristaDescripcion
        '
        Me.lblMontoMayoristaDescripcion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblMontoMayoristaDescripcion.AutoSize = True
        Me.lblMontoMayoristaDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontoMayoristaDescripcion.Location = New System.Drawing.Point(3, 75)
        Me.lblMontoMayoristaDescripcion.Name = "lblMontoMayoristaDescripcion"
        Me.lblMontoMayoristaDescripcion.Size = New System.Drawing.Size(87, 15)
        Me.lblMontoMayoristaDescripcion.TabIndex = 35
        Me.lblMontoMayoristaDescripcion.Text = "Monto total :"
        '
        'lblFacturado
        '
        Me.lblFacturado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblFacturado.AutoSize = True
        Me.lblFacturado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFacturado.Location = New System.Drawing.Point(196, 361)
        Me.lblFacturado.Name = "lblFacturado"
        Me.lblFacturado.Size = New System.Drawing.Size(42, 15)
        Me.lblFacturado.TabIndex = 25
        Me.lblFacturado.Text = "- - - - - "
        '
        'label8
        '
        Me.label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.Location = New System.Drawing.Point(6, 361)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(79, 15)
        Me.label8.TabIndex = 24
        Me.label8.Text = "Facturado :"
        '
        'lblCantidad
        '
        Me.lblCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad.Location = New System.Drawing.Point(196, 385)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(42, 15)
        Me.lblCantidad.TabIndex = 22
        Me.lblCantidad.Text = "- - - - - "
        '
        'lblPago
        '
        Me.lblPago.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblPago.AutoSize = True
        Me.lblPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPago.Location = New System.Drawing.Point(196, 337)
        Me.lblPago.Name = "lblPago"
        Me.lblPago.Size = New System.Drawing.Size(42, 15)
        Me.lblPago.TabIndex = 21
        Me.lblPago.Text = "- - - - - "
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 385)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(135, 15)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Cant. de productos :"
        '
        'DG_Productos
        '
        Me.DG_Productos.AllowUserToAddRows = False
        Me.DG_Productos.AllowUserToDeleteRows = False
        Me.DG_Productos.AllowUserToResizeRows = False
        Me.DG_Productos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_Productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_Productos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DG_Productos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DG_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Productos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NUMERO, Me.CODIGO, Me.NOMBRE, Me.CANTIDAD, Me.PRECIO, Me.IVA, Me.MONTO, Me.SUBTOTAL})
        Me.DG_Productos.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.DG_Productos.Location = New System.Drawing.Point(6, 93)
        Me.DG_Productos.MultiSelect = False
        Me.DG_Productos.Name = "DG_Productos"
        Me.DG_Productos.ReadOnly = True
        Me.DG_Productos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DG_Productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Productos.Size = New System.Drawing.Size(848, 232)
        Me.DG_Productos.TabIndex = 11
        '
        'NUMERO
        '
        Me.NUMERO.FillWeight = 68.49864!
        Me.NUMERO.HeaderText = "Número"
        Me.NUMERO.Name = "NUMERO"
        Me.NUMERO.ReadOnly = True
        '
        'CODIGO
        '
        Me.CODIGO.FillWeight = 107.5103!
        Me.CODIGO.HeaderText = "Código"
        Me.CODIGO.Name = "CODIGO"
        Me.CODIGO.ReadOnly = True
        '
        'NOMBRE
        '
        Me.NOMBRE.FillWeight = 177.4346!
        Me.NOMBRE.HeaderText = "Nombre"
        Me.NOMBRE.Name = "NOMBRE"
        Me.NOMBRE.ReadOnly = True
        '
        'CANTIDAD
        '
        Me.CANTIDAD.FillWeight = 73.49158!
        Me.CANTIDAD.HeaderText = "Cantidad"
        Me.CANTIDAD.Name = "CANTIDAD"
        Me.CANTIDAD.ReadOnly = True
        '
        'PRECIO
        '
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.PRECIO.DefaultCellStyle = DataGridViewCellStyle4
        Me.PRECIO.FillWeight = 81.69429!
        Me.PRECIO.HeaderText = "Precio"
        Me.PRECIO.Name = "PRECIO"
        Me.PRECIO.ReadOnly = True
        '
        'IVA
        '
        DataGridViewCellStyle5.Format = "C2"
        Me.IVA.DefaultCellStyle = DataGridViewCellStyle5
        Me.IVA.HeaderText = "Iva"
        Me.IVA.Name = "IVA"
        Me.IVA.ReadOnly = True
        '
        'MONTO
        '
        DataGridViewCellStyle6.Format = "C2"
        Me.MONTO.DefaultCellStyle = DataGridViewCellStyle6
        Me.MONTO.HeaderText = "Monto"
        Me.MONTO.Name = "MONTO"
        Me.MONTO.ReadOnly = True
        '
        'SUBTOTAL
        '
        DataGridViewCellStyle7.Format = "C2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.SUBTOTAL.DefaultCellStyle = DataGridViewCellStyle7
        Me.SUBTOTAL.FillWeight = 91.37056!
        Me.SUBTOTAL.HeaderText = "Subtotal"
        Me.SUBTOTAL.Name = "SUBTOTAL"
        Me.SUBTOTAL.ReadOnly = True
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(6, 337)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(100, 15)
        Me.Label20.TabIndex = 1
        Me.Label20.Text = "Tipo de Pago :"
        '
        'lblAnulado
        '
        Me.lblAnulado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAnulado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnulado.ForeColor = System.Drawing.Color.Red
        Me.lblAnulado.Location = New System.Drawing.Point(264, 337)
        Me.lblAnulado.Name = "lblAnulado"
        Me.lblAnulado.Size = New System.Drawing.Size(315, 209)
        Me.lblAnulado.TabIndex = 74
        Me.lblAnulado.Text = "VENTA ANULADA."
        Me.lblAnulado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmFacturaAdministracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 612)
        Me.Controls.Add(Me.TabAdministracionFacturas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(900, 650)
        Me.Name = "frmFacturaAdministracion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administración de Facturas"
        CType(Me.DG_facturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TabAdministracionFacturas.ResumeLayout(False)
        Me.TabFacturas.ResumeLayout(False)
        Me.TabDetalle.ResumeLayout(False)
        Me.lblcontenedor.ResumeLayout(False)
        Me.lblcontenedor.PerformLayout()
        Me.Gb_Anulado.ResumeLayout(False)
        Me.Gb_Anulado.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.PanelTotalMinoristaSenia.ResumeLayout(False)
        Me.PanelTotalMinoristaSenia.PerformLayout()
        Me.PanelTotalMayorista.ResumeLayout(False)
        Me.PanelTotalMayorista.PerformLayout()
        CType(Me.DG_Productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

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
    Friend WithEvents TabAdministracionFacturas As TabControl
    Friend WithEvents TabFacturas As TabPage
    Friend WithEvents TabDetalle As TabPage
    Friend WithEvents lblcontenedor As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblPorcentajeFacturacion As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblSucursal As Label
    Friend WithEvents lblEncargado As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblCliente As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblVenta As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblVendedor As Label
    Friend WithEvents PanelTotalMinoristaSenia As Panel
    Friend WithEvents lblPendienteAbonarMinorista As Label
    Friend WithEvents lblPendienteAbonarMinoristaDescripcion As Label
    Friend WithEvents lblSeniaMinorista As Label
    Friend WithEvents lblSeniaMinoristaDescripcion As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lblMontoMinoristaDescripcion As Label
    Friend WithEvents lblMontoMinorista As Label
    Friend WithEvents lblDescuentoMinorista As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents lblSubtotalMinorista As Label
    Friend WithEvents PanelTotalMayorista As Panel
    Friend WithEvents lblPendienteAbonarMayorista As Label
    Friend WithEvents lblPendienteAbonarMayoristaDescripcion As Label
    Friend WithEvents lblSeniaMayorista As Label
    Friend WithEvents lblSeniaMayoristaDescripcion As Label
    Friend WithEvents lblIVAMayorista As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents lblSubtotalMayorista As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents lblDescuentoMayorista As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents lblMontoMayorista As Label
    Friend WithEvents lblMontoMayoristaDescripcion As Label
    Friend WithEvents lblFacturado As Label
    Friend WithEvents label8 As Label
    Friend WithEvents lblCantidad As Label
    Friend WithEvents lblPago As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DG_Productos As DataGridView
    Friend WithEvents NUMERO As DataGridViewTextBoxColumn
    Friend WithEvents CODIGO As DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE As DataGridViewTextBoxColumn
    Friend WithEvents CANTIDAD As DataGridViewTextBoxColumn
    Friend WithEvents PRECIO As DataGridViewTextBoxColumn
    Friend WithEvents IVA As DataGridViewTextBoxColumn
    Friend WithEvents MONTO As DataGridViewTextBoxColumn
    Friend WithEvents SUBTOTAL As DataGridViewTextBoxColumn
    Friend WithEvents Label20 As Label
    Friend WithEvents lblAnulado As Label
    Friend WithEvents Gb_Anulado As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtDescripcionAnular As TextBox
    Friend WithEvents BtnAnular As Button
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
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
End Class
