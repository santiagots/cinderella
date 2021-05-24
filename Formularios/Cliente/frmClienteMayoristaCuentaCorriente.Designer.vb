<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmClienteMayoristaCuentaCorriente

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClienteMayoristaCuentaCorriente))
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel16 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.FrmClienteMayoristaCuentaCorrienteViewModelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.FHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.FDesde = New System.Windows.Forms.DateTimePicker()
        Me.lbl_Msg = New System.Windows.Forms.Label()
        Me.dgvMovimientos = New System.Windows.Forms.DataGridView()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sucursal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoMovimientoCuentaCorriente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoAccionCuentaCorriente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroComprobanteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Detalle = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Imprimir = New System.Windows.Forms.DataGridViewImageColumn()
        Me.MovimientosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnPagoDocumento = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvNotasPedidos = New System.Windows.Forms.DataGridView()
        Me.NumeroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VendedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NotasPedidosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PaginadoMovimientos = New SistemaCinderella.Paginado()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.PaginadoNotaPedido = New SistemaCinderella.Paginado()
        Me.GroupBox5.SuspendLayout()
        Me.TableLayoutPanel16.SuspendLayout()
        CType(Me.FrmClienteMayoristaCuentaCorrienteViewModelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgvMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MovimientosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvNotasPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NotasPedidosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.TableLayoutPanel16)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(770, 66)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Datos Cliente"
        '
        'TableLayoutPanel16
        '
        Me.TableLayoutPanel16.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel16.ColumnCount = 8
        Me.TableLayoutPanel16.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanel16.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.02659!))
        Me.TableLayoutPanel16.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel16.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.TableLayoutPanel16.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.98671!))
        Me.TableLayoutPanel16.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel16.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.TableLayoutPanel16.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.98671!))
        Me.TableLayoutPanel16.Controls.Add(Me.Label41, 3, 0)
        Me.TableLayoutPanel16.Controls.Add(Me.Label45, 0, 0)
        Me.TableLayoutPanel16.Controls.Add(Me.Label1, 6, 0)
        Me.TableLayoutPanel16.Controls.Add(Me.TextBox1, 1, 0)
        Me.TableLayoutPanel16.Controls.Add(Me.TextBox2, 4, 0)
        Me.TableLayoutPanel16.Controls.Add(Me.TextBox3, 7, 0)
        Me.TableLayoutPanel16.Location = New System.Drawing.Point(12, 20)
        Me.TableLayoutPanel16.Name = "TableLayoutPanel16"
        Me.TableLayoutPanel16.RowCount = 1
        Me.TableLayoutPanel16.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel16.Size = New System.Drawing.Size(749, 31)
        Me.TableLayoutPanel16.TabIndex = 0
        '
        'Label41
        '
        Me.Label41.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label41.Location = New System.Drawing.Point(198, 7)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(100, 16)
        Me.Label41.TabIndex = 75
        Me.Label41.Text = "Razón Social"
        '
        'Label45
        '
        Me.Label45.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label45.Location = New System.Drawing.Point(3, 7)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(58, 16)
        Me.Label45.TabIndex = 82
        Me.Label45.Text = "Código"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(489, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 16)
        Me.Label1.TabIndex = 99
        Me.Label1.Text = "Total Saldo"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmClienteMayoristaCuentaCorrienteViewModelBindingSource, "IdClienteMayorista", True))
        Me.TextBox1.Location = New System.Drawing.Point(73, 5)
        Me.TextBox1.MaxLength = 255
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(89, 21)
        Me.TextBox1.TabIndex = 0
        '
        'FrmClienteMayoristaCuentaCorrienteViewModelBindingSource
        '
        Me.FrmClienteMayoristaCuentaCorrienteViewModelBindingSource.DataSource = GetType(SistemaCinderella.Formularios.Cliente.frmClienteMayoristaCuentaCorrienteViewModel)
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmClienteMayoristaCuentaCorrienteViewModelBindingSource, "RazonSocial", True))
        Me.TextBox2.Location = New System.Drawing.Point(308, 5)
        Me.TextBox2.MaxLength = 255
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(145, 21)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmClienteMayoristaCuentaCorrienteViewModelBindingSource, "Saldo", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.TextBox3.Location = New System.Drawing.Point(599, 5)
        Me.TextBox3.MaxLength = 255
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(147, 21)
        Me.TextBox3.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox1.Controls.Add(Me.lbl_Msg)
        Me.GroupBox1.Controls.Add(Me.dgvMovimientos)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 84)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(770, 377)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Movimientos"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.FHasta, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label12, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label11, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.FDesde, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(6, 20)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(758, 35)
        Me.TableLayoutPanel1.TabIndex = 92
        '
        'FHasta
        '
        Me.FHasta.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FHasta.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FrmClienteMayoristaCuentaCorrienteViewModelBindingSource, "FechaBusquedaHasta", True))
        Me.FHasta.Location = New System.Drawing.Point(492, 7)
        Me.FHasta.Name = "FHasta"
        Me.FHasta.Size = New System.Drawing.Size(263, 21)
        Me.FHasta.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(3, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 16)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Fecha desde"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(382, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 16)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Fecha hasta"
        '
        'FDesde
        '
        Me.FDesde.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FDesde.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FrmClienteMayoristaCuentaCorrienteViewModelBindingSource, "FechaBusquedaDesde", True))
        Me.FDesde.Location = New System.Drawing.Point(113, 7)
        Me.FDesde.Name = "FDesde"
        Me.FDesde.Size = New System.Drawing.Size(263, 21)
        Me.FDesde.TabIndex = 4
        '
        'lbl_Msg
        '
        Me.lbl_Msg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Msg.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lbl_Msg.DataBindings.Add(New System.Windows.Forms.Binding("Visible", Me.FrmClienteMayoristaCuentaCorrienteViewModelBindingSource, "MovimientosSinResultados", True))
        Me.lbl_Msg.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Msg.Location = New System.Drawing.Point(223, 158)
        Me.lbl_Msg.Name = "lbl_Msg"
        Me.lbl_Msg.Size = New System.Drawing.Size(321, 117)
        Me.lbl_Msg.TabIndex = 91
        Me.lbl_Msg.Text = "No se han encontrado movimientos."
        Me.lbl_Msg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvMovimientos
        '
        Me.dgvMovimientos.AllowUserToAddRows = False
        Me.dgvMovimientos.AllowUserToDeleteRows = False
        Me.dgvMovimientos.AllowUserToResizeColumns = False
        Me.dgvMovimientos.AllowUserToResizeRows = False
        Me.dgvMovimientos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvMovimientos.AutoGenerateColumns = False
        Me.dgvMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMovimientos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FechaDataGridViewTextBoxColumn, Me.Sucursal, Me.TipoMovimientoCuentaCorriente, Me.TipoAccionCuentaCorriente, Me.NumeroComprobanteDataGridViewTextBoxColumn, Me.Monto, Me.SaldoDataGridViewTextBoxColumn, Me.Detalle, Me.Imprimir})
        Me.dgvMovimientos.DataSource = Me.MovimientosBindingSource
        Me.dgvMovimientos.Location = New System.Drawing.Point(3, 61)
        Me.dgvMovimientos.Name = "dgvMovimientos"
        Me.dgvMovimientos.ReadOnly = True
        Me.dgvMovimientos.RowHeadersVisible = False
        Me.dgvMovimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMovimientos.Size = New System.Drawing.Size(761, 310)
        Me.dgvMovimientos.TabIndex = 0
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.FechaDataGridViewTextBoxColumn.Width = 47
        '
        'Sucursal
        '
        Me.Sucursal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Sucursal.DataPropertyName = "Sucursal"
        Me.Sucursal.HeaderText = "Sucursal"
        Me.Sucursal.Name = "Sucursal"
        Me.Sucursal.ReadOnly = True
        Me.Sucursal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Sucursal.Width = 61
        '
        'TipoMovimientoCuentaCorriente
        '
        Me.TipoMovimientoCuentaCorriente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TipoMovimientoCuentaCorriente.DataPropertyName = "TipoMovimientoCuentaCorriente"
        Me.TipoMovimientoCuentaCorriente.HeaderText = "Tipo"
        Me.TipoMovimientoCuentaCorriente.Name = "TipoMovimientoCuentaCorriente"
        Me.TipoMovimientoCuentaCorriente.ReadOnly = True
        Me.TipoMovimientoCuentaCorriente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'TipoAccionCuentaCorriente
        '
        Me.TipoAccionCuentaCorriente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TipoAccionCuentaCorriente.DataPropertyName = "TipoAccionCuentaCorriente"
        Me.TipoAccionCuentaCorriente.HeaderText = "Acción"
        Me.TipoAccionCuentaCorriente.Name = "TipoAccionCuentaCorriente"
        Me.TipoAccionCuentaCorriente.ReadOnly = True
        Me.TipoAccionCuentaCorriente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.TipoAccionCuentaCorriente.Width = 49
        '
        'NumeroComprobanteDataGridViewTextBoxColumn
        '
        Me.NumeroComprobanteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NumeroComprobanteDataGridViewTextBoxColumn.DataPropertyName = "NumeroComprobante"
        Me.NumeroComprobanteDataGridViewTextBoxColumn.HeaderText = "Nro. Comprobante"
        Me.NumeroComprobanteDataGridViewTextBoxColumn.Name = "NumeroComprobanteDataGridViewTextBoxColumn"
        Me.NumeroComprobanteDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumeroComprobanteDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Monto
        '
        Me.Monto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Monto.DataPropertyName = "Monto"
        DataGridViewCellStyle1.Format = "c2"
        Me.Monto.DefaultCellStyle = DataGridViewCellStyle1
        Me.Monto.HeaderText = "Monto"
        Me.Monto.Name = "Monto"
        Me.Monto.ReadOnly = True
        Me.Monto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Monto.Width = 48
        '
        'SaldoDataGridViewTextBoxColumn
        '
        Me.SaldoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SaldoDataGridViewTextBoxColumn.DataPropertyName = "Saldo"
        DataGridViewCellStyle2.Format = "c2"
        Me.SaldoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.SaldoDataGridViewTextBoxColumn.HeaderText = "Saldo"
        Me.SaldoDataGridViewTextBoxColumn.Name = "SaldoDataGridViewTextBoxColumn"
        Me.SaldoDataGridViewTextBoxColumn.ReadOnly = True
        Me.SaldoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.SaldoDataGridViewTextBoxColumn.Width = 45
        '
        'Detalle
        '
        Me.Detalle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Detalle.HeaderText = ""
        Me.Detalle.Image = Global.SistemaCinderella.My.Resources.Recursos.Detalle_Pequeno
        Me.Detalle.Name = "Detalle"
        Me.Detalle.ReadOnly = True
        Me.Detalle.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Detalle.Width = 5
        '
        'Imprimir
        '
        Me.Imprimir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Imprimir.HeaderText = ""
        Me.Imprimir.Image = Global.SistemaCinderella.My.Resources.Recursos.icono_imprimir
        Me.Imprimir.Name = "Imprimir"
        Me.Imprimir.ReadOnly = True
        Me.Imprimir.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Imprimir.Width = 5
        '
        'MovimientosBindingSource
        '
        Me.MovimientosBindingSource.DataMember = "Movimientos"
        Me.MovimientosBindingSource.DataSource = Me.FrmClienteMayoristaCuentaCorrienteViewModelBindingSource
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Image = Global.SistemaCinderella.My.Resources.Recursos.icono_imprimir
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImprimir.Location = New System.Drawing.Point(576, 469)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(100, 40)
        Me.btnImprimir.TabIndex = 3
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnPagoDocumento
        '
        Me.btnPagoDocumento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPagoDocumento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPagoDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPagoDocumento.Image = Global.SistemaCinderella.My.Resources.Recursos.Precios
        Me.btnPagoDocumento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPagoDocumento.Location = New System.Drawing.Point(433, 469)
        Me.btnPagoDocumento.Name = "btnPagoDocumento"
        Me.btnPagoDocumento.Size = New System.Drawing.Size(137, 40)
        Me.btnPagoDocumento.TabIndex = 4
        Me.btnPagoDocumento.Text = "Pago de Doc."
        Me.btnPagoDocumento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPagoDocumento.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.dgvNotasPedidos)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 515)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(770, 207)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Notas de Pedido"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label2.DataBindings.Add(New System.Windows.Forms.Binding("Visible", Me.FrmClienteMayoristaCuentaCorrienteViewModelBindingSource, "NotasPedidoSinResultados", True))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(232, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(307, 76)
        Me.Label2.TabIndex = 92
        Me.Label2.Text = "No se han encontrado notas de pedido."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvNotasPedidos
        '
        Me.dgvNotasPedidos.AllowUserToAddRows = False
        Me.dgvNotasPedidos.AllowUserToDeleteRows = False
        Me.dgvNotasPedidos.AllowUserToResizeColumns = False
        Me.dgvNotasPedidos.AllowUserToResizeRows = False
        Me.dgvNotasPedidos.AutoGenerateColumns = False
        Me.dgvNotasPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNotasPedidos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumeroDataGridViewTextBoxColumn, Me.VendedorDataGridViewTextBoxColumn, Me.MontoTotalDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn1, Me.EstadoDataGridViewTextBoxColumn})
        Me.dgvNotasPedidos.DataSource = Me.NotasPedidosBindingSource
        Me.dgvNotasPedidos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvNotasPedidos.Location = New System.Drawing.Point(3, 17)
        Me.dgvNotasPedidos.Name = "dgvNotasPedidos"
        Me.dgvNotasPedidos.ReadOnly = True
        Me.dgvNotasPedidos.RowHeadersVisible = False
        Me.dgvNotasPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvNotasPedidos.Size = New System.Drawing.Size(764, 187)
        Me.dgvNotasPedidos.TabIndex = 0
        '
        'NumeroDataGridViewTextBoxColumn
        '
        Me.NumeroDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.NumeroDataGridViewTextBoxColumn.DataPropertyName = "Numero"
        Me.NumeroDataGridViewTextBoxColumn.HeaderText = "Numero"
        Me.NumeroDataGridViewTextBoxColumn.MinimumWidth = 85
        Me.NumeroDataGridViewTextBoxColumn.Name = "NumeroDataGridViewTextBoxColumn"
        Me.NumeroDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumeroDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.NumeroDataGridViewTextBoxColumn.Width = 85
        '
        'VendedorDataGridViewTextBoxColumn
        '
        Me.VendedorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.VendedorDataGridViewTextBoxColumn.DataPropertyName = "Vendedor"
        Me.VendedorDataGridViewTextBoxColumn.HeaderText = "Vendedor"
        Me.VendedorDataGridViewTextBoxColumn.Name = "VendedorDataGridViewTextBoxColumn"
        Me.VendedorDataGridViewTextBoxColumn.ReadOnly = True
        Me.VendedorDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'MontoTotalDataGridViewTextBoxColumn
        '
        Me.MontoTotalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.MontoTotalDataGridViewTextBoxColumn.DataPropertyName = "MontoTotal"
        Me.MontoTotalDataGridViewTextBoxColumn.HeaderText = "Monto Total"
        Me.MontoTotalDataGridViewTextBoxColumn.Name = "MontoTotalDataGridViewTextBoxColumn"
        Me.MontoTotalDataGridViewTextBoxColumn.ReadOnly = True
        Me.MontoTotalDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.MontoTotalDataGridViewTextBoxColumn.Width = 78
        '
        'FechaDataGridViewTextBoxColumn1
        '
        Me.FechaDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.FechaDataGridViewTextBoxColumn1.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn1.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn1.Name = "FechaDataGridViewTextBoxColumn1"
        Me.FechaDataGridViewTextBoxColumn1.ReadOnly = True
        Me.FechaDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.FechaDataGridViewTextBoxColumn1.Width = 66
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        Me.EstadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.EstadoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.EstadoDataGridViewTextBoxColumn.Width = 70
        '
        'NotasPedidosBindingSource
        '
        Me.NotasPedidosBindingSource.DataMember = "NotasPedidos"
        Me.NotasPedidosBindingSource.DataSource = Me.FrmClienteMayoristaCuentaCorrienteViewModelBindingSource
        '
        'PaginadoMovimientos
        '
        Me.PaginadoMovimientos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PaginadoMovimientos.DataBindings.Add(New System.Windows.Forms.Binding("TotalElementos", Me.FrmClienteMayoristaCuentaCorrienteViewModelBindingSource, "MovimientosTotalElementos", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.PaginadoMovimientos.Leyenda = "{0} de {1}"
        Me.PaginadoMovimientos.Location = New System.Drawing.Point(12, 467)
        Me.PaginadoMovimientos.Name = "PaginadoMovimientos"
        Me.PaginadoMovimientos.PaginaActual = 1
        Me.PaginadoMovimientos.Size = New System.Drawing.Size(209, 23)
        Me.PaginadoMovimientos.TabIndex = 2
        Me.PaginadoMovimientos.TotalElementos = 0
        '
        'btnBuscar
        '
        Me.btnBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Image = Global.SistemaCinderella.My.Resources.Recursos.IconoBuscar24
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(682, 469)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(100, 40)
        Me.btnBuscar.TabIndex = 6
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'PaginadoNotaPedido
        '
        Me.PaginadoNotaPedido.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PaginadoNotaPedido.DataBindings.Add(New System.Windows.Forms.Binding("TotalElementos", Me.FrmClienteMayoristaCuentaCorrienteViewModelBindingSource, "NotasPedidosTotalElementos", True))
        Me.PaginadoNotaPedido.Leyenda = "{0} de {1}"
        Me.PaginadoNotaPedido.Location = New System.Drawing.Point(15, 725)
        Me.PaginadoNotaPedido.Name = "PaginadoNotaPedido"
        Me.PaginadoNotaPedido.PaginaActual = 1
        Me.PaginadoNotaPedido.Size = New System.Drawing.Size(209, 23)
        Me.PaginadoNotaPedido.TabIndex = 7
        Me.PaginadoNotaPedido.TotalElementos = 0
        '
        'frmClienteMayoristaCuentaCorriente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 754)
        Me.Controls.Add(Me.PaginadoNotaPedido)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.PaginadoMovimientos)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnPagoDocumento)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmClienteMayoristaCuentaCorriente"
        Me.Text = "Cuenta Corriente"
        Me.GroupBox5.ResumeLayout(False)
        Me.TableLayoutPanel16.ResumeLayout(False)
        Me.TableLayoutPanel16.PerformLayout()
        CType(Me.FrmClienteMayoristaCuentaCorrienteViewModelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.dgvMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MovimientosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvNotasPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NotasPedidosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents TableLayoutPanel16 As TableLayoutPanel
    Friend WithEvents Label41 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvMovimientos As DataGridView
    Friend WithEvents btnImprimir As Button
    Friend WithEvents btnPagoDocumento As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvNotasPedidos As DataGridView
    Friend WithEvents FrmClienteMayoristaCuentaCorrienteViewModelBindingSource As BindingSource
    Friend WithEvents TipoDocumentoFiscalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MovimientosBindingSource As BindingSource
    Friend WithEvents PaginadoMovimientos As Paginado
    Friend WithEvents lbl_Msg As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CreditoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DebitoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label12 As Label
    Friend WithEvents FDesde As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents FHasta As DateTimePicker
    Friend WithEvents btnBuscar As Button
    Friend WithEvents PaginadoNotaPedido As Paginado
    Friend WithEvents NotasPedidosBindingSource As BindingSource
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Sucursal As DataGridViewTextBoxColumn
    Friend WithEvents TipoMovimientoCuentaCorriente As DataGridViewTextBoxColumn
    Friend WithEvents TipoAccionCuentaCorriente As DataGridViewTextBoxColumn
    Friend WithEvents NumeroComprobanteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Monto As DataGridViewTextBoxColumn
    Friend WithEvents SaldoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Detalle As DataGridViewImageColumn
    Friend WithEvents Imprimir As DataGridViewImageColumn
    Friend WithEvents NumeroDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VendedorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MontoTotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
