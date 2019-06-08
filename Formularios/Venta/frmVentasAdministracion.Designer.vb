<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVentasAdministracion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVentasAdministracion))
        Me.TabVentas = New System.Windows.Forms.TabControl()
        Me.TbListado = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbl_Msg = New System.Windows.Forms.Label()
        Me.FrmVentasAdministracionViewModelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DG_Ventas = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreClienteMayoristaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreVendedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoFacturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Anulado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_Restablecer = New System.Windows.Forms.Button()
        Me.BtnFiltrar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lbTipoFactura = New System.Windows.Forms.ListBox()
        Me.TiposFacturasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.ChkAnuladoSi = New System.Windows.Forms.CheckBox()
        Me.ChkAnuladoNo = New System.Windows.Forms.CheckBox()
        Me.FDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.FHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbFormaPago = New System.Windows.Forms.ListBox()
        Me.TiposPagosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtMontoDesde = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtMontoHasta = New System.Windows.Forms.TextBox()
        Me.lbTipoCliente = New System.Windows.Forms.ListBox()
        Me.TiposClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtFacturaDesde = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtFacturaHasta = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TbDetalle = New System.Windows.Forms.TabPage()
        Me.Gb_Anulado = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDescripcionAnular = New System.Windows.Forms.TextBox()
        Me.BtnAnular = New System.Windows.Forms.Button()
        Me.lblcontenedor = New System.Windows.Forms.GroupBox()
        Me.BtnNotaCreditoDetalle = New System.Windows.Forms.Button()
        Me.BtnFacturaDetalle = New System.Windows.Forms.Button()
        Me.btnReporteVenta = New System.Windows.Forms.Button()
        Me.BtnEmitirFactura = New System.Windows.Forms.Button()
        Me.VentaDetalle = New SistemaCinderella.VentaDetalle()
        Me.TipoFacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabVentas.SuspendLayout()
        Me.TbListado.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.FrmVentasAdministracionViewModelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_Ventas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.TiposFacturasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.TiposPagosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel8.SuspendLayout()
        CType(Me.TiposClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.TbDetalle.SuspendLayout()
        Me.Gb_Anulado.SuspendLayout()
        Me.lblcontenedor.SuspendLayout()
        CType(Me.TipoFacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabVentas
        '
        Me.TabVentas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabVentas.Controls.Add(Me.TbListado)
        Me.TabVentas.Controls.Add(Me.TbDetalle)
        Me.TabVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabVentas.Location = New System.Drawing.Point(0, 0)
        Me.TabVentas.Name = "TabVentas"
        Me.TabVentas.SelectedIndex = 0
        Me.TabVentas.Size = New System.Drawing.Size(954, 737)
        Me.TabVentas.TabIndex = 2
        '
        'TbListado
        '
        Me.TbListado.Controls.Add(Me.GroupBox2)
        Me.TbListado.Controls.Add(Me.GroupBox1)
        Me.TbListado.Location = New System.Drawing.Point(4, 29)
        Me.TbListado.Name = "TbListado"
        Me.TbListado.Padding = New System.Windows.Forms.Padding(3)
        Me.TbListado.Size = New System.Drawing.Size(946, 704)
        Me.TbListado.TabIndex = 0
        Me.TbListado.Text = "Ventas"
        Me.TbListado.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.lbl_Msg)
        Me.GroupBox2.Controls.Add(Me.DG_Ventas)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 246)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(930, 450)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ventas"
        '
        'lbl_Msg
        '
        Me.lbl_Msg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Msg.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lbl_Msg.DataBindings.Add(New System.Windows.Forms.Binding("Visible", Me.FrmVentasAdministracionViewModelBindingSource, "SinResultados", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.lbl_Msg.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Msg.Location = New System.Drawing.Point(257, 211)
        Me.lbl_Msg.Name = "lbl_Msg"
        Me.lbl_Msg.Size = New System.Drawing.Size(417, 42)
        Me.lbl_Msg.TabIndex = 2
        Me.lbl_Msg.Text = "No se han encontrado ventas."
        Me.lbl_Msg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmVentasAdministracionViewModelBindingSource
        '
        Me.FrmVentasAdministracionViewModelBindingSource.DataSource = GetType(SistemaCinderella.Formularios.Venta.frmVentasAdministracionViewModel)
        '
        'DG_Ventas
        '
        Me.DG_Ventas.AllowUserToAddRows = False
        Me.DG_Ventas.AllowUserToDeleteRows = False
        Me.DG_Ventas.AllowUserToResizeColumns = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DG_Ventas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DG_Ventas.AutoGenerateColumns = False
        Me.DG_Ventas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.FechaDataGridViewTextBoxColumn, Me.TipoClienteDataGridViewTextBoxColumn, Me.NombreClienteMayoristaDataGridViewTextBoxColumn, Me.NombreVendedorDataGridViewTextBoxColumn, Me.TipoPagoDataGridViewTextBoxColumn, Me.MontoTotalDataGridViewTextBoxColumn, Me.TipoFacturaDataGridViewTextBoxColumn, Me.NumeroFactura, Me.Anulado})
        Me.DG_Ventas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DG_Ventas.DataSource = Me.VentasBindingSource
        Me.DG_Ventas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_Ventas.Location = New System.Drawing.Point(3, 17)
        Me.DG_Ventas.MultiSelect = False
        Me.DG_Ventas.Name = "DG_Ventas"
        Me.DG_Ventas.ReadOnly = True
        Me.DG_Ventas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DG_Ventas.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DG_Ventas.RowTemplate.Height = 30
        Me.DG_Ventas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Ventas.Size = New System.Drawing.Size(924, 430)
        Me.DG_Ventas.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Numero"
        Me.DataGridViewTextBoxColumn1.HeaderText = "N° Venta"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
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
        'TipoClienteDataGridViewTextBoxColumn
        '
        Me.TipoClienteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TipoClienteDataGridViewTextBoxColumn.DataPropertyName = "TipoCliente"
        Me.TipoClienteDataGridViewTextBoxColumn.HeaderText = "Tipo Cliente"
        Me.TipoClienteDataGridViewTextBoxColumn.Name = "TipoClienteDataGridViewTextBoxColumn"
        Me.TipoClienteDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoClienteDataGridViewTextBoxColumn.Width = 97
        '
        'NombreClienteMayoristaDataGridViewTextBoxColumn
        '
        Me.NombreClienteMayoristaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NombreClienteMayoristaDataGridViewTextBoxColumn.DataPropertyName = "NombreClienteMayorista"
        Me.NombreClienteMayoristaDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.NombreClienteMayoristaDataGridViewTextBoxColumn.Name = "NombreClienteMayoristaDataGridViewTextBoxColumn"
        Me.NombreClienteMayoristaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreVendedorDataGridViewTextBoxColumn
        '
        Me.NombreVendedorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NombreVendedorDataGridViewTextBoxColumn.DataPropertyName = "NombreVendedor"
        Me.NombreVendedorDataGridViewTextBoxColumn.HeaderText = "Vendedor"
        Me.NombreVendedorDataGridViewTextBoxColumn.Name = "NombreVendedorDataGridViewTextBoxColumn"
        Me.NombreVendedorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TipoPagoDataGridViewTextBoxColumn
        '
        Me.TipoPagoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TipoPagoDataGridViewTextBoxColumn.DataPropertyName = "TipoPago"
        Me.TipoPagoDataGridViewTextBoxColumn.HeaderText = "Forma Pago"
        Me.TipoPagoDataGridViewTextBoxColumn.Name = "TipoPagoDataGridViewTextBoxColumn"
        Me.TipoPagoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MontoTotalDataGridViewTextBoxColumn
        '
        Me.MontoTotalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MontoTotalDataGridViewTextBoxColumn.DataPropertyName = "MontoTotal"
        DataGridViewCellStyle2.Format = "C2"
        Me.MontoTotalDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.MontoTotalDataGridViewTextBoxColumn.HeaderText = "Monto Total"
        Me.MontoTotalDataGridViewTextBoxColumn.Name = "MontoTotalDataGridViewTextBoxColumn"
        Me.MontoTotalDataGridViewTextBoxColumn.ReadOnly = True
        Me.MontoTotalDataGridViewTextBoxColumn.Width = 97
        '
        'TipoFacturaDataGridViewTextBoxColumn
        '
        Me.TipoFacturaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TipoFacturaDataGridViewTextBoxColumn.DataPropertyName = "TipoFactura"
        Me.TipoFacturaDataGridViewTextBoxColumn.HeaderText = "Tipo Factura"
        Me.TipoFacturaDataGridViewTextBoxColumn.Name = "TipoFacturaDataGridViewTextBoxColumn"
        Me.TipoFacturaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NumeroFactura
        '
        Me.NumeroFactura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NumeroFactura.DataPropertyName = "NumeroFactura"
        Me.NumeroFactura.HeaderText = "N° Factura"
        Me.NumeroFactura.Name = "NumeroFactura"
        Me.NumeroFactura.ReadOnly = True
        Me.NumeroFactura.Width = 90
        '
        'Anulado
        '
        Me.Anulado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Anulado.DataPropertyName = "Anulado"
        Me.Anulado.HeaderText = "Anulado"
        Me.Anulado.Name = "Anulado"
        Me.Anulado.ReadOnly = True
        Me.Anulado.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Anulado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Anulado.Width = 58
        '
        'VentasBindingSource
        '
        Me.VentasBindingSource.DataMember = "Ventas"
        Me.VentasBindingSource.DataSource = Me.FrmVentasAdministracionViewModelBindingSource
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btn_Restablecer)
        Me.GroupBox1.Controls.Add(Me.BtnFiltrar)
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(10, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(930, 234)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtrar ventas."
        '
        'btn_Restablecer
        '
        Me.btn_Restablecer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Restablecer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Restablecer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Restablecer.Location = New System.Drawing.Point(730, 187)
        Me.btn_Restablecer.Name = "btn_Restablecer"
        Me.btn_Restablecer.Size = New System.Drawing.Size(94, 41)
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
        Me.BtnFiltrar.Location = New System.Drawing.Point(830, 187)
        Me.BtnFiltrar.Name = "BtnFiltrar"
        Me.BtnFiltrar.Size = New System.Drawing.Size(94, 41)
        Me.BtnFiltrar.TabIndex = 4
        Me.BtnFiltrar.Text = "Buscar"
        Me.BtnFiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnFiltrar.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel1, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 17)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 211.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(924, 211)
        Me.TableLayoutPanel2.TabIndex = 3
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label17, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label12, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbTipoFactura, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.FDesde, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label11, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.FHasta, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label20, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(485, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(436, 205)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(3, 124)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(212, 16)
        Me.Label17.TabIndex = 422
        Me.Label17.Text = "Facturado"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(3, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(212, 16)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Fecha desde"
        '
        'lbTipoFactura
        '
        Me.lbTipoFactura.DataSource = Me.TiposFacturasBindingSource
        Me.lbTipoFactura.DisplayMember = "Value"
        Me.lbTipoFactura.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbTipoFactura.FormattingEnabled = True
        Me.lbTipoFactura.ItemHeight = 15
        Me.lbTipoFactura.Location = New System.Drawing.Point(221, 108)
        Me.lbTipoFactura.Name = "lbTipoFactura"
        Me.lbTipoFactura.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lbTipoFactura.Size = New System.Drawing.Size(212, 49)
        Me.lbTipoFactura.TabIndex = 437
        Me.lbTipoFactura.ValueMember = "Key"
        '
        'TiposFacturasBindingSource
        '
        Me.TiposFacturasBindingSource.DataMember = "TiposFacturas"
        Me.TiposFacturasBindingSource.DataSource = Me.FrmVentasAdministracionViewModelBindingSource
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.ChkAnuladoSi, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.ChkAnuladoNo, 1, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(221, 73)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(212, 29)
        Me.TableLayoutPanel4.TabIndex = 435
        '
        'ChkAnuladoSi
        '
        Me.ChkAnuladoSi.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkAnuladoSi.AutoSize = True
        Me.ChkAnuladoSi.Checked = True
        Me.ChkAnuladoSi.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkAnuladoSi.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.FrmVentasAdministracionViewModelBindingSource, "AnuladoSi", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ChkAnuladoSi.Location = New System.Drawing.Point(3, 5)
        Me.ChkAnuladoSi.Name = "ChkAnuladoSi"
        Me.ChkAnuladoSi.Size = New System.Drawing.Size(100, 19)
        Me.ChkAnuladoSi.TabIndex = 432
        Me.ChkAnuladoSi.Text = "Si"
        Me.ChkAnuladoSi.UseVisualStyleBackColor = True
        '
        'ChkAnuladoNo
        '
        Me.ChkAnuladoNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkAnuladoNo.AutoSize = True
        Me.ChkAnuladoNo.Checked = True
        Me.ChkAnuladoNo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkAnuladoNo.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.FrmVentasAdministracionViewModelBindingSource, "AnuladoNo", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ChkAnuladoNo.Location = New System.Drawing.Point(109, 5)
        Me.ChkAnuladoNo.Name = "ChkAnuladoNo"
        Me.ChkAnuladoNo.Size = New System.Drawing.Size(100, 19)
        Me.ChkAnuladoNo.TabIndex = 433
        Me.ChkAnuladoNo.Text = "No"
        Me.ChkAnuladoNo.UseVisualStyleBackColor = True
        '
        'FDesde
        '
        Me.FDesde.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FDesde.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FrmVentasAdministracionViewModelBindingSource, "FechaDesde", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "D"))
        Me.FDesde.Location = New System.Drawing.Point(221, 7)
        Me.FDesde.Name = "FDesde"
        Me.FDesde.Size = New System.Drawing.Size(212, 21)
        Me.FDesde.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(3, 44)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(212, 16)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Fecha hasta"
        '
        'FHasta
        '
        Me.FHasta.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FHasta.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FrmVentasAdministracionViewModelBindingSource, "NumeroFacturaHasta", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "D"))
        Me.FHasta.Location = New System.Drawing.Point(221, 42)
        Me.FHasta.Name = "FHasta"
        Me.FHasta.Size = New System.Drawing.Size(212, 21)
        Me.FHasta.TabIndex = 1
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(3, 79)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(212, 16)
        Me.Label20.TabIndex = 431
        Me.Label20.Text = "Anulado"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.lbFormaPago, 1, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.Label25, 0, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.Label13, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel8, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.lbTipoCliente, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Label9, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel7, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label19, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 4
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(436, 205)
        Me.TableLayoutPanel3.TabIndex = 4
        '
        'lbFormaPago
        '
        Me.lbFormaPago.DataSource = Me.TiposPagosBindingSource
        Me.lbFormaPago.DisplayMember = "Value"
        Me.lbFormaPago.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbFormaPago.FormattingEnabled = True
        Me.lbFormaPago.ItemHeight = 15
        Me.lbFormaPago.Location = New System.Drawing.Point(221, 113)
        Me.lbFormaPago.Name = "lbFormaPago"
        Me.lbFormaPago.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lbFormaPago.Size = New System.Drawing.Size(212, 89)
        Me.lbFormaPago.TabIndex = 438
        Me.lbFormaPago.ValueMember = "Key"
        '
        'TiposPagosBindingSource
        '
        Me.TiposPagosBindingSource.DataMember = "TiposPagos"
        Me.TiposPagosBindingSource.DataSource = Me.FrmVentasAdministracionViewModelBindingSource
        '
        'Label25
        '
        Me.Label25.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(3, 149)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(212, 16)
        Me.Label25.TabIndex = 437
        Me.Label25.Text = "Forma Pago"
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(3, 9)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(212, 16)
        Me.Label13.TabIndex = 420
        Me.Label13.Text = "N° Factura"
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.ColumnCount = 3
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.txtMontoDesde, 0, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.Label18, 1, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.txtMontoHasta, 2, 0)
        Me.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(221, 38)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 1
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(212, 29)
        Me.TableLayoutPanel8.TabIndex = 424
        '
        'txtMontoDesde
        '
        Me.txtMontoDesde.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMontoDesde.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmVentasAdministracionViewModelBindingSource, "MontoDesde", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.txtMontoDesde.Location = New System.Drawing.Point(3, 4)
        Me.txtMontoDesde.Name = "txtMontoDesde"
        Me.txtMontoDesde.Size = New System.Drawing.Size(90, 21)
        Me.txtMontoDesde.TabIndex = 418
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(99, 6)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(14, 16)
        Me.Label18.TabIndex = 421
        Me.Label18.Text = "-"
        '
        'txtMontoHasta
        '
        Me.txtMontoHasta.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMontoHasta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmVentasAdministracionViewModelBindingSource, "MontoHasta", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.txtMontoHasta.Location = New System.Drawing.Point(119, 4)
        Me.txtMontoHasta.Name = "txtMontoHasta"
        Me.txtMontoHasta.Size = New System.Drawing.Size(90, 21)
        Me.txtMontoHasta.TabIndex = 419
        '
        'lbTipoCliente
        '
        Me.lbTipoCliente.DataSource = Me.TiposClientesBindingSource
        Me.lbTipoCliente.DisplayMember = "Value"
        Me.lbTipoCliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbTipoCliente.FormattingEnabled = True
        Me.lbTipoCliente.ItemHeight = 15
        Me.lbTipoCliente.Location = New System.Drawing.Point(221, 73)
        Me.lbTipoCliente.Name = "lbTipoCliente"
        Me.lbTipoCliente.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lbTipoCliente.Size = New System.Drawing.Size(212, 34)
        Me.lbTipoCliente.TabIndex = 439
        Me.lbTipoCliente.ValueMember = "Key"
        '
        'TiposClientesBindingSource
        '
        Me.TiposClientesBindingSource.DataMember = "TiposClientes"
        Me.TiposClientesBindingSource.DataSource = Me.FrmVentasAdministracionViewModelBindingSource
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 82)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(212, 16)
        Me.Label9.TabIndex = 432
        Me.Label9.Text = "Tipo Cliente"
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 3
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.txtFacturaDesde, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.Label29, 1, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.txtFacturaHasta, 2, 0)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(221, 3)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(212, 29)
        Me.TableLayoutPanel7.TabIndex = 423
        '
        'txtFacturaDesde
        '
        Me.txtFacturaDesde.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFacturaDesde.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmVentasAdministracionViewModelBindingSource, "NumeroFacturaDesde", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtFacturaDesde.Location = New System.Drawing.Point(3, 4)
        Me.txtFacturaDesde.Name = "txtFacturaDesde"
        Me.txtFacturaDesde.Size = New System.Drawing.Size(90, 21)
        Me.txtFacturaDesde.TabIndex = 418
        '
        'Label29
        '
        Me.Label29.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(99, 6)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(14, 16)
        Me.Label29.TabIndex = 421
        Me.Label29.Text = "-"
        '
        'txtFacturaHasta
        '
        Me.txtFacturaHasta.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFacturaHasta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmVentasAdministracionViewModelBindingSource, "NumeroFacturaHasta", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtFacturaHasta.Location = New System.Drawing.Point(119, 4)
        Me.txtFacturaHasta.Name = "txtFacturaHasta"
        Me.txtFacturaHasta.Size = New System.Drawing.Size(90, 21)
        Me.txtFacturaHasta.TabIndex = 419
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(3, 44)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(212, 16)
        Me.Label19.TabIndex = 429
        Me.Label19.Text = "Monto"
        '
        'TbDetalle
        '
        Me.TbDetalle.Controls.Add(Me.Gb_Anulado)
        Me.TbDetalle.Controls.Add(Me.lblcontenedor)
        Me.TbDetalle.Location = New System.Drawing.Point(4, 29)
        Me.TbDetalle.Name = "TbDetalle"
        Me.TbDetalle.Size = New System.Drawing.Size(946, 704)
        Me.TbDetalle.TabIndex = 2
        Me.TbDetalle.Text = "Detalle de la Venta"
        Me.TbDetalle.UseVisualStyleBackColor = True
        '
        'Gb_Anulado
        '
        Me.Gb_Anulado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gb_Anulado.Controls.Add(Me.TextBox1)
        Me.Gb_Anulado.Controls.Add(Me.Label1)
        Me.Gb_Anulado.Controls.Add(Me.txtDescripcionAnular)
        Me.Gb_Anulado.Controls.Add(Me.BtnAnular)
        Me.Gb_Anulado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Gb_Anulado.Location = New System.Drawing.Point(10, 548)
        Me.Gb_Anulado.Name = "Gb_Anulado"
        Me.Gb_Anulado.Size = New System.Drawing.Size(928, 148)
        Me.Gb_Anulado.TabIndex = 16
        Me.Gb_Anulado.TabStop = False
        Me.Gb_Anulado.Text = "Anular Venta - Motivo"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmVentasAdministracionViewModelBindingSource, "FechaAnulacion", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "G"))
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(104, 117)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(179, 21)
        Me.TextBox1.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 15)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Fecha Anulado:"
        '
        'txtDescripcionAnular
        '
        Me.txtDescripcionAnular.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescripcionAnular.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmVentasAdministracionViewModelBindingSource, "MotivoAnulacion", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtDescripcionAnular.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.FrmVentasAdministracionViewModelBindingSource, "HabilitarAnular", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
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
        Me.BtnAnular.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.FrmVentasAdministracionViewModelBindingSource, "HabilitarAnular", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
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
        Me.lblcontenedor.Location = New System.Drawing.Point(10, 6)
        Me.lblcontenedor.Name = "lblcontenedor"
        Me.lblcontenedor.Size = New System.Drawing.Size(928, 536)
        Me.lblcontenedor.TabIndex = 0
        Me.lblcontenedor.TabStop = False
        Me.lblcontenedor.Text = "Información de la venta realizada."
        '
        'BtnNotaCreditoDetalle
        '
        Me.BtnNotaCreditoDetalle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnNotaCreditoDetalle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNotaCreditoDetalle.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.FrmVentasAdministracionViewModelBindingSource, "HabilitarDetalleNotaCredito", True))
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
        Me.BtnFacturaDetalle.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.FrmVentasAdministracionViewModelBindingSource, "HabilitarDetalleFacturar", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
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
        Me.BtnEmitirFactura.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.FrmVentasAdministracionViewModelBindingSource, "HabilitarFacturar", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
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
        'frmVentasAdministracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(954, 737)
        Me.Controls.Add(Me.TabVentas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmVentasAdministracion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administración de Ventas"
        Me.TabVentas.ResumeLayout(False)
        Me.TbListado.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.FrmVentasAdministracionViewModelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_Ventas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.TiposFacturasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.TiposPagosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel8.PerformLayout()
        CType(Me.TiposClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel7.PerformLayout()
        Me.TbDetalle.ResumeLayout(False)
        Me.Gb_Anulado.ResumeLayout(False)
        Me.Gb_Anulado.PerformLayout()
        Me.lblcontenedor.ResumeLayout(False)
        CType(Me.TipoFacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabVentas As System.Windows.Forms.TabControl
    Friend WithEvents TbListado As System.Windows.Forms.TabPage
    Friend WithEvents DG_Ventas As System.Windows.Forms.DataGridView
    Friend WithEvents TbDetalle As System.Windows.Forms.TabPage
    Friend WithEvents lblcontenedor As System.Windows.Forms.GroupBox
    Friend WithEvents Gb_Anulado As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescripcionAnular As System.Windows.Forms.TextBox
    Friend WithEvents BtnAnular As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnFiltrar As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents FHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents FDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Msg As System.Windows.Forms.Label
    Friend WithEvents btn_Restablecer As System.Windows.Forms.Button
    Friend WithEvents TipoFacturaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtFacturaHasta As System.Windows.Forms.TextBox
    Friend WithEvents txtFacturaDesde As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents btnReporteVenta As Button
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents txtMontoDesde As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtMontoHasta As TextBox
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents ChkAnuladoSi As CheckBox
    Friend WithEvents ChkAnuladoNo As CheckBox
    Friend WithEvents lbTipoFactura As ListBox
    Friend WithEvents lbFormaPago As ListBox
    Friend WithEvents lbTipoCliente As ListBox
    Friend WithEvents FrmVentasAdministracionViewModelBindingSource As BindingSource
    Friend WithEvents TiposFacturasBindingSource As BindingSource
    Friend WithEvents TiposPagosBindingSource As BindingSource
    Friend WithEvents TiposClientesBindingSource As BindingSource
    Friend WithEvents VentasBindingSource As BindingSource
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents NumeroVentaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VentaDetalle As VentaDetalle
    Friend WithEvents BtnFacturaDetalle As Button
    Friend WithEvents BtnEmitirFactura As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreClienteMayoristaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreVendedorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoPagoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MontoTotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoFacturaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumeroFactura As DataGridViewTextBoxColumn
    Friend WithEvents Anulado As DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents BtnNotaCreditoDetalle As Button
End Class
