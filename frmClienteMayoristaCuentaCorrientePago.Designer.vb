<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClienteMayoristaCuentaCorrientePago
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClienteMayoristaCuentaCorrientePago))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_id_Cliente = New System.Windows.Forms.TextBox()
        Me.txt_Nombre = New System.Windows.Forms.TextBox()
        Me.txt_RazonSocial = New System.Windows.Forms.TextBox()
        Me.Btn_BuscarCliente = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoMovimientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoFacturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PuntoVentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComprobanteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpresaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovimientoCuentaCorrienteClienteMayoristaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnCargarCheque = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmb_Empresa = New System.Windows.Forms.ComboBox()
        Me.txtFormaPago = New System.Windows.Forms.TextBox()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtComprobante = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txt_Saldo = New System.Windows.Forms.TextBox()
        Me.txt_SaldoNuevo = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MovimientoCuentaCorrienteClienteMayoristaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(864, 63)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Cliente"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.txt_id_Cliente, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Nombre, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_RazonSocial, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Btn_BuscarCliente, 3, 0)
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(6, 19)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(852, 34)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'txt_id_Cliente
        '
        Me.txt_id_Cliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_id_Cliente.BackColor = System.Drawing.SystemColors.Window
        Me.txt_id_Cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id_Cliente.Location = New System.Drawing.Point(3, 6)
        Me.txt_id_Cliente.Name = "txt_id_Cliente"
        Me.txt_id_Cliente.ReadOnly = True
        Me.txt_id_Cliente.Size = New System.Drawing.Size(157, 21)
        Me.txt_id_Cliente.TabIndex = 4
        '
        'txt_Nombre
        '
        Me.txt_Nombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Nombre.BackColor = System.Drawing.SystemColors.Window
        Me.txt_Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Nombre.Location = New System.Drawing.Point(166, 6)
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.ReadOnly = True
        Me.txt_Nombre.Size = New System.Drawing.Size(320, 21)
        Me.txt_Nombre.TabIndex = 5
        '
        'txt_RazonSocial
        '
        Me.txt_RazonSocial.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_RazonSocial.BackColor = System.Drawing.SystemColors.Window
        Me.txt_RazonSocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_RazonSocial.Location = New System.Drawing.Point(492, 6)
        Me.txt_RazonSocial.Name = "txt_RazonSocial"
        Me.txt_RazonSocial.ReadOnly = True
        Me.txt_RazonSocial.Size = New System.Drawing.Size(320, 21)
        Me.txt_RazonSocial.TabIndex = 7
        '
        'Btn_BuscarCliente
        '
        Me.Btn_BuscarCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_BuscarCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_BuscarCliente.FlatAppearance.BorderSize = 0
        Me.Btn_BuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_BuscarCliente.Image = Global.SistemaCinderella.My.Resources.Recursos.Clientes_32
        Me.Btn_BuscarCliente.Location = New System.Drawing.Point(820, 3)
        Me.Btn_BuscarCliente.Name = "Btn_BuscarCliente"
        Me.Btn_BuscarCliente.Size = New System.Drawing.Size(29, 28)
        Me.Btn_BuscarCliente.TabIndex = 6
        Me.Btn_BuscarCliente.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FechaDataGridViewTextBoxColumn, Me.TipoMovimientoDataGridViewTextBoxColumn, Me.TipoFacturaDataGridViewTextBoxColumn, Me.PuntoVentaDataGridViewTextBoxColumn, Me.ComprobanteDataGridViewTextBoxColumn, Me.PagoDataGridViewTextBoxColumn, Me.MontoDataGridViewTextBoxColumn, Me.SaldoDataGridViewTextBoxColumn, Me.EmpresaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MovimientoCuentaCorrienteClienteMayoristaBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(8, 81)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(864, 431)
        Me.DataGridView1.TabIndex = 7
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        '
        'TipoMovimientoDataGridViewTextBoxColumn
        '
        Me.TipoMovimientoDataGridViewTextBoxColumn.DataPropertyName = "TipoMovimiento"
        Me.TipoMovimientoDataGridViewTextBoxColumn.HeaderText = "TipoMovimiento"
        Me.TipoMovimientoDataGridViewTextBoxColumn.Name = "TipoMovimientoDataGridViewTextBoxColumn"
        '
        'TipoFacturaDataGridViewTextBoxColumn
        '
        Me.TipoFacturaDataGridViewTextBoxColumn.DataPropertyName = "TipoFactura"
        Me.TipoFacturaDataGridViewTextBoxColumn.HeaderText = "TipoFactura"
        Me.TipoFacturaDataGridViewTextBoxColumn.Name = "TipoFacturaDataGridViewTextBoxColumn"
        '
        'PuntoVentaDataGridViewTextBoxColumn
        '
        Me.PuntoVentaDataGridViewTextBoxColumn.DataPropertyName = "PuntoVenta"
        Me.PuntoVentaDataGridViewTextBoxColumn.HeaderText = "PuntoVenta"
        Me.PuntoVentaDataGridViewTextBoxColumn.Name = "PuntoVentaDataGridViewTextBoxColumn"
        '
        'ComprobanteDataGridViewTextBoxColumn
        '
        Me.ComprobanteDataGridViewTextBoxColumn.DataPropertyName = "Comprobante"
        Me.ComprobanteDataGridViewTextBoxColumn.HeaderText = "Comprobante"
        Me.ComprobanteDataGridViewTextBoxColumn.Name = "ComprobanteDataGridViewTextBoxColumn"
        '
        'PagoDataGridViewTextBoxColumn
        '
        Me.PagoDataGridViewTextBoxColumn.DataPropertyName = "Pago"
        Me.PagoDataGridViewTextBoxColumn.HeaderText = "Pago"
        Me.PagoDataGridViewTextBoxColumn.Name = "PagoDataGridViewTextBoxColumn"
        '
        'MontoDataGridViewTextBoxColumn
        '
        Me.MontoDataGridViewTextBoxColumn.DataPropertyName = "Monto"
        Me.MontoDataGridViewTextBoxColumn.HeaderText = "Monto"
        Me.MontoDataGridViewTextBoxColumn.Name = "MontoDataGridViewTextBoxColumn"
        '
        'SaldoDataGridViewTextBoxColumn
        '
        Me.SaldoDataGridViewTextBoxColumn.DataPropertyName = "Saldo"
        Me.SaldoDataGridViewTextBoxColumn.HeaderText = "Saldo"
        Me.SaldoDataGridViewTextBoxColumn.Name = "SaldoDataGridViewTextBoxColumn"
        '
        'EmpresaDataGridViewTextBoxColumn
        '
        Me.EmpresaDataGridViewTextBoxColumn.DataPropertyName = "Empresa"
        Me.EmpresaDataGridViewTextBoxColumn.HeaderText = "Empresa"
        Me.EmpresaDataGridViewTextBoxColumn.Name = "EmpresaDataGridViewTextBoxColumn"
        '
        'MovimientoCuentaCorrienteClienteMayoristaBindingSource
        '
        Me.MovimientoCuentaCorrienteClienteMayoristaBindingSource.DataSource = GetType(Entidades.MovimientoCuentaCorrienteClienteMayorista)
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 5
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnCargarCheque, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.cmb_Empresa, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtFormaPago, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtMonto, 4, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.dtpFecha, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtComprobante, 1, 2)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(8, 518)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(864, 102)
        Me.TableLayoutPanel2.TabIndex = 8
        '
        'btnCargarCheque
        '
        Me.btnCargarCheque.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCargarCheque.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCargarCheque.FlatAppearance.BorderSize = 0
        Me.btnCargarCheque.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCargarCheque.Image = Global.SistemaCinderella.My.Resources.Recursos.cehque_32
        Me.btnCargarCheque.Location = New System.Drawing.Point(410, 37)
        Me.btnCargarCheque.Name = "btnCargarCheque"
        Me.btnCargarCheque.Size = New System.Drawing.Size(44, 28)
        Me.btnCargarCheque.TabIndex = 31
        Me.btnCargarCheque.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Empresa"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Forma Pago"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(460, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(460, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Monto"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Comprobante"
        '
        'cmb_Empresa
        '
        Me.cmb_Empresa.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_Empresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Empresa.FormattingEnabled = True
        Me.cmb_Empresa.Items.AddRange(New Object() {"Opciones no disponibles"})
        Me.cmb_Empresa.Location = New System.Drawing.Point(103, 6)
        Me.cmb_Empresa.Name = "cmb_Empresa"
        Me.cmb_Empresa.Size = New System.Drawing.Size(301, 21)
        Me.cmb_Empresa.TabIndex = 5
        '
        'txtFormaPago
        '
        Me.txtFormaPago.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFormaPago.Location = New System.Drawing.Point(103, 41)
        Me.txtFormaPago.Name = "txtFormaPago"
        Me.txtFormaPago.Size = New System.Drawing.Size(301, 20)
        Me.txtFormaPago.TabIndex = 6
        '
        'txtMonto
        '
        Me.txtMonto.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMonto.Location = New System.Drawing.Point(560, 41)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(301, 20)
        Me.txtMonto.TabIndex = 7
        '
        'dtpFecha
        '
        Me.dtpFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpFecha.Location = New System.Drawing.Point(560, 7)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(301, 20)
        Me.dtpFecha.TabIndex = 8
        '
        'txtComprobante
        '
        Me.txtComprobante.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtComprobante.Location = New System.Drawing.Point(103, 75)
        Me.txtComprobante.Name = "txtComprobante"
        Me.txtComprobante.Size = New System.Drawing.Size(301, 20)
        Me.txtComprobante.TabIndex = 9
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label6, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label19, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.txt_Saldo, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.txt_SaldoNuevo, 1, 1)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(8, 626)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(358, 79)
        Me.TableLayoutPanel3.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(156, 22)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "SALDO NUEVO:"
        '
        'Label19
        '
        Me.Label19.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(3, 6)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(166, 22)
        Me.Label19.TabIndex = 37
        Me.Label19.Text = "SALDO ACTUAL:"
        '
        'txt_Saldo
        '
        Me.txt_Saldo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Saldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Saldo.Location = New System.Drawing.Point(182, 3)
        Me.txt_Saldo.Name = "txt_Saldo"
        Me.txt_Saldo.ReadOnly = True
        Me.txt_Saldo.Size = New System.Drawing.Size(173, 29)
        Me.txt_Saldo.TabIndex = 36
        Me.txt_Saldo.Text = "0,00"
        Me.txt_Saldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_SaldoNuevo
        '
        Me.txt_SaldoNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_SaldoNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SaldoNuevo.Location = New System.Drawing.Point(182, 42)
        Me.txt_SaldoNuevo.Name = "txt_SaldoNuevo"
        Me.txt_SaldoNuevo.ReadOnly = True
        Me.txt_SaldoNuevo.Size = New System.Drawing.Size(173, 29)
        Me.txt_SaldoNuevo.TabIndex = 39
        Me.txt_SaldoNuevo.Text = "0,00"
        Me.txt_SaldoNuevo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = Global.SistemaCinderella.My.Resources.Recursos.desconectado_32
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(666, 665)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 40)
        Me.btnCancelar.TabIndex = 30
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.BackColor = System.Drawing.Color.Transparent
        Me.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Image = Global.SistemaCinderella.My.Resources.Recursos.Conectado_32
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.Location = New System.Drawing.Point(772, 665)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(100, 40)
        Me.btnAceptar.TabIndex = 29
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'frmClienteMayoristaCuentaCorrientePago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(884, 717)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmClienteMayoristaCuentaCorrientePago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso de Pagos"
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MovimientoCuentaCorrienteClienteMayoristaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents txt_id_Cliente As TextBox
    Friend WithEvents txt_Nombre As TextBox
    Friend WithEvents txt_RazonSocial As TextBox
    Friend WithEvents Btn_BuscarCliente As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents txt_Saldo As TextBox
    Friend WithEvents txt_SaldoNuevo As TextBox
    Friend WithEvents cmb_Empresa As ComboBox
    Friend WithEvents txtFormaPago As TextBox
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents txtComprobante As TextBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnCargarCheque As Button
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoMovimientoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoFacturaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PuntoVentaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ComprobanteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PagoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MontoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SaldoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmpresaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MovimientoCuentaCorrienteClienteMayoristaBindingSource As BindingSource
End Class
