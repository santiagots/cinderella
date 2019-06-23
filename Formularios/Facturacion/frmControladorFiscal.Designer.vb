<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmControladorFiscal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmControladorFiscal))
        Me.btnCierreZ = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FHastaCierreZ = New System.Windows.Forms.DateTimePicker()
        Me.FrmControladorFiscalViewModelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FDesdeCierreZ = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.btnCierreZPorFecha = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.FHasta = New System.Windows.Forms.DateTimePicker()
        Me.FDesde = New System.Windows.Forms.DateTimePicker()
        Me.btn_Exportar = New System.Windows.Forms.Button()
        Me.BtnFiltrar = New System.Windows.Forms.Button()
        Me.dgTickets = New System.Windows.Forms.DataGridView()
        Me.NumeroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PuntoVentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoFacturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CondicionIVADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUITDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreYApellidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocalidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FacturasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lbl_Msg = New System.Windows.Forms.Label()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.FrmControladorFiscalViewModelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.dgTickets, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCierreZ
        '
        Me.btnCierreZ.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCierreZ.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnCierreZ.Location = New System.Drawing.Point(733, 19)
        Me.btnCierreZ.Name = "btnCierreZ"
        Me.btnCierreZ.Size = New System.Drawing.Size(121, 40)
        Me.btnCierreZ.TabIndex = 0
        Me.btnCierreZ.Text = "Cierre Z día"
        Me.btnCierreZ.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox2.Controls.Add(Me.btnCierreZPorFecha)
        Me.GroupBox2.Controls.Add(Me.btnCierreZ)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(860, 120)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Controlador Fiscal"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.FHastaCierreZ, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.FDesdeCierreZ, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblEstado, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(6, 20)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(721, 90)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(3, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(194, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Estado"
        '
        'FHastaCierreZ
        '
        Me.FHastaCierreZ.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FHastaCierreZ.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FrmControladorFiscalViewModelBindingSource, "ControladorFiscalFechaHasta", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "D"))
        Me.FHastaCierreZ.Location = New System.Drawing.Point(203, 65)
        Me.FHastaCierreZ.Name = "FHastaCierreZ"
        Me.FHastaCierreZ.Size = New System.Drawing.Size(515, 20)
        Me.FHastaCierreZ.TabIndex = 9
        '
        'FrmControladorFiscalViewModelBindingSource
        '
        Me.FrmControladorFiscalViewModelBindingSource.DataSource = GetType(SistemaCinderella.Formularios.Facturacion.frmControladorFiscalViewModel)
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(194, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Fecha hasta"
        '
        'FDesdeCierreZ
        '
        Me.FDesdeCierreZ.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FDesdeCierreZ.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FrmControladorFiscalViewModelBindingSource, "ControladorFiscalFechaDesde", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "D"))
        Me.FDesdeCierreZ.Location = New System.Drawing.Point(203, 35)
        Me.FDesdeCierreZ.Name = "FDesdeCierreZ"
        Me.FDesdeCierreZ.Size = New System.Drawing.Size(515, 20)
        Me.FDesdeCierreZ.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Fecha desde"
        '
        'lblEstado
        '
        Me.lblEstado.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.Location = New System.Drawing.Point(203, 7)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(515, 15)
        Me.lblEstado.TabIndex = 1
        Me.lblEstado.Text = "- - - -"
        '
        'btnCierreZPorFecha
        '
        Me.btnCierreZPorFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCierreZPorFecha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCierreZPorFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCierreZPorFecha.Location = New System.Drawing.Point(733, 70)
        Me.btnCierreZPorFecha.Name = "btnCierreZPorFecha"
        Me.btnCierreZPorFecha.Size = New System.Drawing.Size(121, 40)
        Me.btnCierreZPorFecha.TabIndex = 12
        Me.btnCierreZPorFecha.Text = "Cierre Z por rango de fecha"
        Me.btnCierreZPorFecha.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox1.Controls.Add(Me.btn_Exportar)
        Me.GroupBox1.Controls.Add(Me.BtnFiltrar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 138)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(860, 83)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tickets"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label12, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label11, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.FHasta, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.FDesde, 1, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(6, 17)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(594, 60)
        Me.TableLayoutPanel2.TabIndex = 6
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(3, 7)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(194, 16)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Fecha desde"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(3, 37)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(194, 16)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Fecha hasta"
        '
        'FHasta
        '
        Me.FHasta.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FHasta.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FrmControladorFiscalViewModelBindingSource, "TicketFechaHasta", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "D"))
        Me.FHasta.Location = New System.Drawing.Point(203, 35)
        Me.FHasta.Name = "FHasta"
        Me.FHasta.Size = New System.Drawing.Size(388, 20)
        Me.FHasta.TabIndex = 5
        '
        'FDesde
        '
        Me.FDesde.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FDesde.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FrmControladorFiscalViewModelBindingSource, "TicketFechaDesde", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "D"))
        Me.FDesde.Location = New System.Drawing.Point(203, 5)
        Me.FDesde.Name = "FDesde"
        Me.FDesde.Size = New System.Drawing.Size(388, 20)
        Me.FDesde.TabIndex = 4
        '
        'btn_Exportar
        '
        Me.btn_Exportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Exportar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Exportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Exportar.Image = Global.SistemaCinderella.My.Resources.Recursos.export_excel
        Me.btn_Exportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Exportar.Location = New System.Drawing.Point(606, 26)
        Me.btn_Exportar.Name = "btn_Exportar"
        Me.btn_Exportar.Size = New System.Drawing.Size(121, 40)
        Me.btn_Exportar.TabIndex = 12
        Me.btn_Exportar.Text = "Exportar"
        Me.btn_Exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Exportar.UseVisualStyleBackColor = True
        '
        'BtnFiltrar
        '
        Me.BtnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFiltrar.FlatAppearance.BorderSize = 0
        Me.BtnFiltrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFiltrar.Image = Global.SistemaCinderella.My.Resources.Recursos.IconoBuscar32
        Me.BtnFiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnFiltrar.Location = New System.Drawing.Point(733, 26)
        Me.BtnFiltrar.Name = "BtnFiltrar"
        Me.BtnFiltrar.Size = New System.Drawing.Size(121, 40)
        Me.BtnFiltrar.TabIndex = 10
        Me.BtnFiltrar.Text = "Buscar"
        Me.BtnFiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnFiltrar.UseVisualStyleBackColor = True
        '
        'dgTickets
        '
        Me.dgTickets.AllowUserToAddRows = False
        Me.dgTickets.AllowUserToDeleteRows = False
        Me.dgTickets.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgTickets.AutoGenerateColumns = False
        Me.dgTickets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgTickets.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTickets.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumeroDataGridViewTextBoxColumn, Me.PuntoVentaDataGridViewTextBoxColumn, Me.TipoFacturaDataGridViewTextBoxColumn, Me.CondicionIVADataGridViewTextBoxColumn, Me.CUITDataGridViewTextBoxColumn, Me.NombreYApellidoDataGridViewTextBoxColumn, Me.DireccionDataGridViewTextBoxColumn, Me.LocalidadDataGridViewTextBoxColumn, Me.MontoDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn})
        Me.dgTickets.DataSource = Me.FacturasBindingSource
        Me.dgTickets.Location = New System.Drawing.Point(12, 227)
        Me.dgTickets.Name = "dgTickets"
        Me.dgTickets.ReadOnly = True
        Me.dgTickets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgTickets.Size = New System.Drawing.Size(860, 523)
        Me.dgTickets.TabIndex = 4
        '
        'NumeroDataGridViewTextBoxColumn
        '
        Me.NumeroDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NumeroDataGridViewTextBoxColumn.DataPropertyName = "Numero"
        Me.NumeroDataGridViewTextBoxColumn.HeaderText = "Numero"
        Me.NumeroDataGridViewTextBoxColumn.Name = "NumeroDataGridViewTextBoxColumn"
        Me.NumeroDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumeroDataGridViewTextBoxColumn.Width = 69
        '
        'PuntoVentaDataGridViewTextBoxColumn
        '
        Me.PuntoVentaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PuntoVentaDataGridViewTextBoxColumn.DataPropertyName = "PuntoVenta"
        Me.PuntoVentaDataGridViewTextBoxColumn.HeaderText = "P. Venta"
        Me.PuntoVentaDataGridViewTextBoxColumn.Name = "PuntoVentaDataGridViewTextBoxColumn"
        Me.PuntoVentaDataGridViewTextBoxColumn.ReadOnly = True
        Me.PuntoVentaDataGridViewTextBoxColumn.Width = 73
        '
        'TipoFacturaDataGridViewTextBoxColumn
        '
        Me.TipoFacturaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TipoFacturaDataGridViewTextBoxColumn.DataPropertyName = "TipoFactura"
        Me.TipoFacturaDataGridViewTextBoxColumn.HeaderText = "T. Factura"
        Me.TipoFacturaDataGridViewTextBoxColumn.Name = "TipoFacturaDataGridViewTextBoxColumn"
        Me.TipoFacturaDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoFacturaDataGridViewTextBoxColumn.Width = 81
        '
        'CondicionIVADataGridViewTextBoxColumn
        '
        Me.CondicionIVADataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CondicionIVADataGridViewTextBoxColumn.DataPropertyName = "CondicionIVA"
        Me.CondicionIVADataGridViewTextBoxColumn.HeaderText = "Condición IVA"
        Me.CondicionIVADataGridViewTextBoxColumn.Name = "CondicionIVADataGridViewTextBoxColumn"
        Me.CondicionIVADataGridViewTextBoxColumn.ReadOnly = True
        Me.CondicionIVADataGridViewTextBoxColumn.Width = 99
        '
        'CUITDataGridViewTextBoxColumn
        '
        Me.CUITDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CUITDataGridViewTextBoxColumn.DataPropertyName = "CUIT"
        Me.CUITDataGridViewTextBoxColumn.HeaderText = "CUIT"
        Me.CUITDataGridViewTextBoxColumn.Name = "CUITDataGridViewTextBoxColumn"
        Me.CUITDataGridViewTextBoxColumn.ReadOnly = True
        Me.CUITDataGridViewTextBoxColumn.Width = 57
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
        DataGridViewCellStyle1.Format = "C"
        Me.MontoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.MontoDataGridViewTextBoxColumn.HeaderText = "Monto"
        Me.MontoDataGridViewTextBoxColumn.Name = "MontoDataGridViewTextBoxColumn"
        Me.MontoDataGridViewTextBoxColumn.ReadOnly = True
        Me.MontoDataGridViewTextBoxColumn.Width = 62
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaDataGridViewTextBoxColumn.Width = 62
        '
        'FacturasBindingSource
        '
        Me.FacturasBindingSource.DataMember = "Facturas"
        Me.FacturasBindingSource.DataSource = Me.FrmControladorFiscalViewModelBindingSource
        '
        'lbl_Msg
        '
        Me.lbl_Msg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Msg.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lbl_Msg.DataBindings.Add(New System.Windows.Forms.Binding("Visible", Me.FrmControladorFiscalViewModelBindingSource, "SinResultados", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.lbl_Msg.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Msg.Location = New System.Drawing.Point(279, 476)
        Me.lbl_Msg.Name = "lbl_Msg"
        Me.lbl_Msg.Size = New System.Drawing.Size(327, 25)
        Me.lbl_Msg.TabIndex = 5
        Me.lbl_Msg.Text = "No se han encontrado tickets."
        Me.lbl_Msg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_Msg.Visible = False
        '
        'frmControladorFiscal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 762)
        Me.Controls.Add(Me.lbl_Msg)
        Me.Controls.Add(Me.dgTickets)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmControladorFiscal"
        Me.Text = "Controlador Fiscal"
        Me.GroupBox2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.FrmControladorFiscalViewModelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.dgTickets, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCierreZ As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents FHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents FDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnFiltrar As System.Windows.Forms.Button
    Friend WithEvents dgTickets As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_Msg As System.Windows.Forms.Label
    Friend WithEvents btn_Exportar As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btnCierreZPorFecha As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents FHastaCierreZ As System.Windows.Forms.DateTimePicker
    Friend WithEvents FDesdeCierreZ As System.Windows.Forms.DateTimePicker
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents FrmControladorFiscalViewModelBindingSource As BindingSource
    Friend WithEvents FacturasBindingSource As BindingSource
    Friend WithEvents NumeroDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PuntoVentaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoFacturaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CondicionIVADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CUITDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreYApellidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DireccionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LocalidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MontoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
