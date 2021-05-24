<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmChequeAdministracion
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChequeAdministracion))
        Me.tabAdministracion = New System.Windows.Forms.TabControl()
        Me.TabCheques = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel13 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lbl_Msg = New System.Windows.Forms.Label()
        Me.FrmChequeAdministracionViewModelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgvCheques = New System.Windows.Forms.DataGridView()
        Me.NumeroOrden = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarcaFacturado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteNombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LibradorNombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BancoEmisorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroChequeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaIngresoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDespositoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaVencimientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaSalida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DestinoSalida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChequesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableLayoutPanel12 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.lbl_TotalCartera = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.lbl_TotalPantalla = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_Exportar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.dtFechaSalidaDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.dtFechaSalidaHasta = New System.Windows.Forms.DateTimePicker()
        Me.chkFechaSalida = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel9 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtImporteDesde = New System.Windows.Forms.TextBox()
        Me.txtImporteHasta = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.dtFechaVencimientoDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.dtFechaVencimientoHasta = New System.Windows.Forms.DateTimePicker()
        Me.chkFechaVencimiento = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbBancoEmisor = New System.Windows.Forms.ComboBox()
        Me.BancosEmisoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ListBoxDestinoSalida = New System.Windows.Forms.ListBox()
        Me.DestinosSalidasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableLayoutPanel10 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.dtFechaDepositoDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.dtFechaDepositoHasta = New System.Windows.Forms.DateTimePicker()
        Me.chkFechaDeposito = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.dtFechaIngresoDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.dtFechaIngresoHasta = New System.Windows.Forms.DateTimePicker()
        Me.chkFechaIngreso = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLibradorNombre = New System.Windows.Forms.TextBox()
        Me.txtClienteNombre = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.ChkMarcaFacturadoSi = New System.Windows.Forms.CheckBox()
        Me.ChkMarcaFacturadoNo = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ListBoxEstado = New System.Windows.Forms.ListBox()
        Me.EstadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btn_Restablecer = New System.Windows.Forms.Button()
        Me.TabDetalle = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.ucChequeDetalle = New SistemaCinderella.ChequeDetalle()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel11 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.DetalleSalida = New System.Windows.Forms.TextBox()
        Me.cmbDestinoSalida = New System.Windows.Forms.ComboBox()
        Me.DestinosSalidasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel14 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_Modificar = New System.Windows.Forms.Button()
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.tabAdministracion.SuspendLayout()
        Me.TabCheques.SuspendLayout()
        Me.TableLayoutPanel13.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.FrmChequeAdministracionViewModelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCheques, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChequesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel12.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        Me.TableLayoutPanel9.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        CType(Me.BancosEmisoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DestinosSalidasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel10.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.EstadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabDetalle.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel11.SuspendLayout()
        CType(Me.DestinosSalidasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel14.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabAdministracion
        '
        Me.tabAdministracion.Controls.Add(Me.TabCheques)
        Me.tabAdministracion.Controls.Add(Me.TabDetalle)
        Me.tabAdministracion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabAdministracion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabAdministracion.Location = New System.Drawing.Point(0, 0)
        Me.tabAdministracion.Name = "tabAdministracion"
        Me.tabAdministracion.SelectedIndex = 0
        Me.tabAdministracion.Size = New System.Drawing.Size(984, 762)
        Me.tabAdministracion.TabIndex = 0
        '
        'TabCheques
        '
        Me.TabCheques.Controls.Add(Me.TableLayoutPanel13)
        Me.TabCheques.Location = New System.Drawing.Point(4, 29)
        Me.TabCheques.Name = "TabCheques"
        Me.TabCheques.Padding = New System.Windows.Forms.Padding(3)
        Me.TabCheques.Size = New System.Drawing.Size(976, 729)
        Me.TabCheques.TabIndex = 0
        Me.TabCheques.Text = "Cheques"
        Me.TabCheques.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel13
        '
        Me.TableLayoutPanel13.ColumnCount = 1
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel13.Controls.Add(Me.GroupBox3, 0, 1)
        Me.TableLayoutPanel13.Controls.Add(Me.TableLayoutPanel12, 0, 2)
        Me.TableLayoutPanel13.Controls.Add(Me.GroupBox1, 0, 0)
        Me.TableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel13.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel13.Name = "TableLayoutPanel13"
        Me.TableLayoutPanel13.RowCount = 3
        Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 330.0!))
        Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.TableLayoutPanel13.Size = New System.Drawing.Size(970, 723)
        Me.TableLayoutPanel13.TabIndex = 413
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lbl_Msg)
        Me.GroupBox3.Controls.Add(Me.dgvCheques)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(3, 333)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(964, 353)
        Me.GroupBox3.TabIndex = 409
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Cheques"
        '
        'lbl_Msg
        '
        Me.lbl_Msg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Msg.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lbl_Msg.DataBindings.Add(New System.Windows.Forms.Binding("Visible", Me.FrmChequeAdministracionViewModelBindingSource, "SinResultados", True))
        Me.lbl_Msg.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Msg.Location = New System.Drawing.Point(55, 102)
        Me.lbl_Msg.Name = "lbl_Msg"
        Me.lbl_Msg.Size = New System.Drawing.Size(855, 162)
        Me.lbl_Msg.TabIndex = 403
        Me.lbl_Msg.Text = "No se han encontrado cheques con los filtros seleccionados."
        Me.lbl_Msg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmChequeAdministracionViewModelBindingSource
        '
        Me.FrmChequeAdministracionViewModelBindingSource.DataSource = GetType(SistemaCinderella.Formularios.Cheque.frmChequeAdministracionViewModel)
        '
        'dgvCheques
        '
        Me.dgvCheques.AllowUserToAddRows = False
        Me.dgvCheques.AllowUserToDeleteRows = False
        Me.dgvCheques.AllowUserToResizeColumns = False
        Me.dgvCheques.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvCheques.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCheques.AutoGenerateColumns = False
        Me.dgvCheques.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCheques.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumeroOrden, Me.MarcaFacturado, Me.ClienteNombreDataGridViewTextBoxColumn, Me.LibradorNombreDataGridViewTextBoxColumn, Me.BancoEmisorDataGridViewTextBoxColumn, Me.NumeroChequeDataGridViewTextBoxColumn, Me.FechaIngresoDataGridViewTextBoxColumn, Me.FechaDespositoDataGridViewTextBoxColumn, Me.FechaVencimientoDataGridViewTextBoxColumn, Me.FechaSalida, Me.Estado, Me.DestinoSalida, Me.MontoDataGridViewTextBoxColumn})
        Me.dgvCheques.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvCheques.DataSource = Me.ChequesBindingSource
        Me.dgvCheques.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCheques.Location = New System.Drawing.Point(3, 17)
        Me.dgvCheques.MultiSelect = False
        Me.dgvCheques.Name = "dgvCheques"
        Me.dgvCheques.ReadOnly = True
        Me.dgvCheques.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCheques.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvCheques.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvCheques.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCheques.Size = New System.Drawing.Size(958, 333)
        Me.dgvCheques.TabIndex = 24
        '
        'NumeroOrden
        '
        Me.NumeroOrden.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NumeroOrden.DataPropertyName = "NumeroOrden"
        Me.NumeroOrden.HeaderText = "Orden"
        Me.NumeroOrden.Name = "NumeroOrden"
        Me.NumeroOrden.ReadOnly = True
        Me.NumeroOrden.Width = 66
        '
        'MarcaFacturado
        '
        Me.MarcaFacturado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MarcaFacturado.DataPropertyName = "MarcaFacturado"
        Me.MarcaFacturado.HeaderText = "M. Fact"
        Me.MarcaFacturado.Name = "MarcaFacturado"
        Me.MarcaFacturado.ReadOnly = True
        Me.MarcaFacturado.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MarcaFacturado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.MarcaFacturado.Width = 53
        '
        'ClienteNombreDataGridViewTextBoxColumn
        '
        Me.ClienteNombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ClienteNombreDataGridViewTextBoxColumn.DataPropertyName = "ClienteNombre"
        Me.ClienteNombreDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.ClienteNombreDataGridViewTextBoxColumn.Name = "ClienteNombreDataGridViewTextBoxColumn"
        Me.ClienteNombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LibradorNombreDataGridViewTextBoxColumn
        '
        Me.LibradorNombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.LibradorNombreDataGridViewTextBoxColumn.DataPropertyName = "LibradorNombre"
        Me.LibradorNombreDataGridViewTextBoxColumn.HeaderText = "Librador"
        Me.LibradorNombreDataGridViewTextBoxColumn.Name = "LibradorNombreDataGridViewTextBoxColumn"
        Me.LibradorNombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BancoEmisorDataGridViewTextBoxColumn
        '
        Me.BancoEmisorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.BancoEmisorDataGridViewTextBoxColumn.DataPropertyName = "BancoEmisor"
        Me.BancoEmisorDataGridViewTextBoxColumn.HeaderText = "Banco"
        Me.BancoEmisorDataGridViewTextBoxColumn.Name = "BancoEmisorDataGridViewTextBoxColumn"
        Me.BancoEmisorDataGridViewTextBoxColumn.ReadOnly = True
        Me.BancoEmisorDataGridViewTextBoxColumn.Width = 67
        '
        'NumeroChequeDataGridViewTextBoxColumn
        '
        Me.NumeroChequeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NumeroChequeDataGridViewTextBoxColumn.DataPropertyName = "NumeroCheque"
        Me.NumeroChequeDataGridViewTextBoxColumn.HeaderText = "Num."
        Me.NumeroChequeDataGridViewTextBoxColumn.Name = "NumeroChequeDataGridViewTextBoxColumn"
        Me.NumeroChequeDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumeroChequeDataGridViewTextBoxColumn.Width = 62
        '
        'FechaIngresoDataGridViewTextBoxColumn
        '
        Me.FechaIngresoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FechaIngresoDataGridViewTextBoxColumn.DataPropertyName = "FechaIngreso"
        DataGridViewCellStyle2.Format = "dd/MM/yyyy"
        Me.FechaIngresoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.FechaIngresoDataGridViewTextBoxColumn.HeaderText = "F. Ingreso"
        Me.FechaIngresoDataGridViewTextBoxColumn.Name = "FechaIngresoDataGridViewTextBoxColumn"
        Me.FechaIngresoDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaIngresoDataGridViewTextBoxColumn.Width = 86
        '
        'FechaDespositoDataGridViewTextBoxColumn
        '
        Me.FechaDespositoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FechaDespositoDataGridViewTextBoxColumn.DataPropertyName = "FechaDesposito"
        DataGridViewCellStyle3.Format = "dd/MM/yyyy"
        Me.FechaDespositoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.FechaDespositoDataGridViewTextBoxColumn.HeaderText = "F. Despósito"
        Me.FechaDespositoDataGridViewTextBoxColumn.Name = "FechaDespositoDataGridViewTextBoxColumn"
        Me.FechaDespositoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaVencimientoDataGridViewTextBoxColumn
        '
        Me.FechaVencimientoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FechaVencimientoDataGridViewTextBoxColumn.DataPropertyName = "FechaVencimiento"
        DataGridViewCellStyle4.Format = "dd/MM/yyyy"
        Me.FechaVencimientoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.FechaVencimientoDataGridViewTextBoxColumn.HeaderText = "F. Vto"
        Me.FechaVencimientoDataGridViewTextBoxColumn.Name = "FechaVencimientoDataGridViewTextBoxColumn"
        Me.FechaVencimientoDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaVencimientoDataGridViewTextBoxColumn.Width = 62
        '
        'FechaSalida
        '
        Me.FechaSalida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FechaSalida.DataPropertyName = "FechaSalida"
        DataGridViewCellStyle5.Format = "dd/MM/yyyy"
        Me.FechaSalida.DefaultCellStyle = DataGridViewCellStyle5
        Me.FechaSalida.HeaderText = "F. Salida"
        Me.FechaSalida.Name = "FechaSalida"
        Me.FechaSalida.ReadOnly = True
        Me.FechaSalida.Width = 80
        '
        'Estado
        '
        Me.Estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Estado.DataPropertyName = "Estado"
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        Me.Estado.Width = 70
        '
        'DestinoSalida
        '
        Me.DestinoSalida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DestinoSalida.DataPropertyName = "DestinoSalida"
        Me.DestinoSalida.HeaderText = "D. Salida"
        Me.DestinoSalida.Name = "DestinoSalida"
        Me.DestinoSalida.ReadOnly = True
        Me.DestinoSalida.Width = 82
        '
        'MontoDataGridViewTextBoxColumn
        '
        Me.MontoDataGridViewTextBoxColumn.DataPropertyName = "Monto"
        DataGridViewCellStyle6.Format = "C2"
        Me.MontoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.MontoDataGridViewTextBoxColumn.HeaderText = "Monto"
        Me.MontoDataGridViewTextBoxColumn.Name = "MontoDataGridViewTextBoxColumn"
        Me.MontoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ChequesBindingSource
        '
        Me.ChequesBindingSource.DataMember = "Cheques"
        Me.ChequesBindingSource.DataSource = Me.FrmChequeAdministracionViewModelBindingSource
        '
        'TableLayoutPanel12
        '
        Me.TableLayoutPanel12.ColumnCount = 5
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel12.Controls.Add(Me.Label35, 0, 0)
        Me.TableLayoutPanel12.Controls.Add(Me.lbl_TotalCartera, 1, 0)
        Me.TableLayoutPanel12.Controls.Add(Me.Label33, 3, 0)
        Me.TableLayoutPanel12.Controls.Add(Me.lbl_TotalPantalla, 4, 0)
        Me.TableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel12.Location = New System.Drawing.Point(3, 692)
        Me.TableLayoutPanel12.Name = "TableLayoutPanel12"
        Me.TableLayoutPanel12.RowCount = 1
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel12.Size = New System.Drawing.Size(964, 28)
        Me.TableLayoutPanel12.TabIndex = 412
        '
        'Label35
        '
        Me.Label35.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(3, 2)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(295, 24)
        Me.Label35.TabIndex = 410
        Me.Label35.Text = "Total Cheques en Cartera:"
        '
        'lbl_TotalCartera
        '
        Me.lbl_TotalCartera.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_TotalCartera.AutoSize = True
        Me.lbl_TotalCartera.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmChequeAdministracionViewModelBindingSource, "TotalChequeCartera", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.lbl_TotalCartera.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TotalCartera.Location = New System.Drawing.Point(304, 2)
        Me.lbl_TotalCartera.Name = "lbl_TotalCartera"
        Me.lbl_TotalCartera.Size = New System.Drawing.Size(144, 24)
        Me.lbl_TotalCartera.TabIndex = 411
        Me.lbl_TotalCartera.Text = "$ 3.000.000.-"
        '
        'Label33
        '
        Me.Label33.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(514, 2)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(295, 24)
        Me.Label33.TabIndex = 408
        Me.Label33.Text = "Total Cheques en Pantalla:"
        '
        'lbl_TotalPantalla
        '
        Me.lbl_TotalPantalla.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_TotalPantalla.AutoSize = True
        Me.lbl_TotalPantalla.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmChequeAdministracionViewModelBindingSource, "TotalChequePantalla", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.lbl_TotalPantalla.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TotalPantalla.Location = New System.Drawing.Point(815, 2)
        Me.lbl_TotalPantalla.Name = "lbl_TotalPantalla"
        Me.lbl_TotalPantalla.Size = New System.Drawing.Size(146, 24)
        Me.lbl_TotalPantalla.TabIndex = 409
        Me.lbl_TotalPantalla.Text = "$ 3.000.000.-"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_Exportar)
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel5)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.btn_Restablecer)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(964, 324)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtrar Cheques"
        '
        'btn_Exportar
        '
        Me.btn_Exportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Exportar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Exportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Exportar.Image = Global.SistemaCinderella.My.Resources.Recursos.export_excel
        Me.btn_Exportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Exportar.Location = New System.Drawing.Point(645, 280)
        Me.btn_Exportar.Name = "btn_Exportar"
        Me.btn_Exportar.Size = New System.Drawing.Size(100, 40)
        Me.btn_Exportar.TabIndex = 19
        Me.btn_Exportar.Text = "Exportar"
        Me.btn_Exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Exportar.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel5.ColumnCount = 3
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel6, 2, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel10, 0, 0)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(6, 20)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 258.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(951, 258)
        Me.TableLayoutPanel5.TabIndex = 408
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 2
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.Label31, 0, 5)
        Me.TableLayoutPanel6.Controls.Add(Me.TableLayoutPanel8, 1, 4)
        Me.TableLayoutPanel6.Controls.Add(Me.TableLayoutPanel9, 1, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.TableLayoutPanel7, 1, 3)
        Me.TableLayoutPanel6.Controls.Add(Me.Label7, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.Label5, 0, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.txtNumero, 1, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.Label4, 0, 2)
        Me.TableLayoutPanel6.Controls.Add(Me.cmbBancoEmisor, 1, 2)
        Me.TableLayoutPanel6.Controls.Add(Me.Label8, 0, 4)
        Me.TableLayoutPanel6.Controls.Add(Me.Label6, 0, 3)
        Me.TableLayoutPanel6.Controls.Add(Me.ListBoxDestinoSalida, 1, 5)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(498, 3)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 6
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(450, 252)
        Me.TableLayoutPanel6.TabIndex = 0
        '
        'Label31
        '
        Me.Label31.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(3, 160)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(154, 16)
        Me.Label31.TabIndex = 429
        Me.Label31.Text = "Destino Salida"
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel8.ColumnCount = 4
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.dtFechaSalidaDesde, 0, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.Label28, 1, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.dtFechaSalidaHasta, 2, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.chkFechaSalida, 3, 0)
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(163, 132)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 1
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(284, 24)
        Me.TableLayoutPanel8.TabIndex = 418
        '
        'dtFechaSalidaDesde
        '
        Me.dtFechaSalidaDesde.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtFechaSalidaDesde.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FrmChequeAdministracionViewModelBindingSource, "FechaSalidaHasta", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "D"))
        Me.dtFechaSalidaDesde.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.FrmChequeAdministracionViewModelBindingSource, "FechaSalidaFiltro", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.dtFechaSalidaDesde.Enabled = False
        Me.dtFechaSalidaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaSalidaDesde.Location = New System.Drawing.Point(3, 3)
        Me.dtFechaSalidaDesde.Name = "dtFechaSalidaDesde"
        Me.dtFechaSalidaDesde.Size = New System.Drawing.Size(115, 21)
        Me.dtFechaSalidaDesde.TabIndex = 19
        '
        'Label28
        '
        Me.Label28.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(124, 4)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(14, 16)
        Me.Label28.TabIndex = 414
        Me.Label28.Text = "-"
        '
        'dtFechaSalidaHasta
        '
        Me.dtFechaSalidaHasta.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtFechaSalidaHasta.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FrmChequeAdministracionViewModelBindingSource, "FechaSalidaHasta", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "D"))
        Me.dtFechaSalidaHasta.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.FrmChequeAdministracionViewModelBindingSource, "FechaSalidaFiltro", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.dtFechaSalidaHasta.Enabled = False
        Me.dtFechaSalidaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaSalidaHasta.Location = New System.Drawing.Point(144, 3)
        Me.dtFechaSalidaHasta.Name = "dtFechaSalidaHasta"
        Me.dtFechaSalidaHasta.Size = New System.Drawing.Size(115, 21)
        Me.dtFechaSalidaHasta.TabIndex = 20
        '
        'chkFechaSalida
        '
        Me.chkFechaSalida.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkFechaSalida.AutoSize = True
        Me.chkFechaSalida.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.FrmChequeAdministracionViewModelBindingSource, "FechaSalidaFiltro", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.chkFechaSalida.Location = New System.Drawing.Point(265, 5)
        Me.chkFechaSalida.Name = "chkFechaSalida"
        Me.chkFechaSalida.Size = New System.Drawing.Size(16, 14)
        Me.chkFechaSalida.TabIndex = 21
        Me.chkFechaSalida.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel9
        '
        Me.TableLayoutPanel9.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel9.ColumnCount = 3
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel9.Controls.Add(Me.txtImporteDesde, 0, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.txtImporteHasta, 2, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.Label29, 1, 0)
        Me.TableLayoutPanel9.Location = New System.Drawing.Point(163, 3)
        Me.TableLayoutPanel9.Name = "TableLayoutPanel9"
        Me.TableLayoutPanel9.RowCount = 1
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel9.Size = New System.Drawing.Size(284, 26)
        Me.TableLayoutPanel9.TabIndex = 418
        '
        'txtImporteDesde
        '
        Me.txtImporteDesde.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtImporteDesde.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmChequeAdministracionViewModelBindingSource, "ImporteDesde", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.txtImporteDesde.Location = New System.Drawing.Point(3, 3)
        Me.txtImporteDesde.Name = "txtImporteDesde"
        Me.txtImporteDesde.Size = New System.Drawing.Size(126, 21)
        Me.txtImporteDesde.TabIndex = 12
        '
        'txtImporteHasta
        '
        Me.txtImporteHasta.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtImporteHasta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmChequeAdministracionViewModelBindingSource, "ImporteHasta", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.txtImporteHasta.Location = New System.Drawing.Point(155, 3)
        Me.txtImporteHasta.Name = "txtImporteHasta"
        Me.txtImporteHasta.Size = New System.Drawing.Size(126, 21)
        Me.txtImporteHasta.TabIndex = 13
        '
        'Label29
        '
        Me.Label29.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(135, 5)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(14, 16)
        Me.Label29.TabIndex = 417
        Me.Label29.Text = "-"
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel7.ColumnCount = 4
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.dtFechaVencimientoDesde, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.Label27, 1, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.dtFechaVencimientoHasta, 2, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.chkFechaVencimiento, 3, 0)
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(163, 100)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(284, 24)
        Me.TableLayoutPanel7.TabIndex = 418
        '
        'dtFechaVencimientoDesde
        '
        Me.dtFechaVencimientoDesde.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtFechaVencimientoDesde.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FrmChequeAdministracionViewModelBindingSource, "FechaVencimientoDesde", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "D"))
        Me.dtFechaVencimientoDesde.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.FrmChequeAdministracionViewModelBindingSource, "FechaVencimientoFiltro", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.dtFechaVencimientoDesde.Enabled = False
        Me.dtFechaVencimientoDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaVencimientoDesde.Location = New System.Drawing.Point(3, 3)
        Me.dtFechaVencimientoDesde.Name = "dtFechaVencimientoDesde"
        Me.dtFechaVencimientoDesde.Size = New System.Drawing.Size(115, 21)
        Me.dtFechaVencimientoDesde.TabIndex = 16
        '
        'Label27
        '
        Me.Label27.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(124, 4)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(14, 16)
        Me.Label27.TabIndex = 413
        Me.Label27.Text = "-"
        '
        'dtFechaVencimientoHasta
        '
        Me.dtFechaVencimientoHasta.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtFechaVencimientoHasta.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FrmChequeAdministracionViewModelBindingSource, "FechaVencimientoHasta", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "D"))
        Me.dtFechaVencimientoHasta.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.FrmChequeAdministracionViewModelBindingSource, "FechaVencimientoFiltro", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.dtFechaVencimientoHasta.Enabled = False
        Me.dtFechaVencimientoHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaVencimientoHasta.Location = New System.Drawing.Point(144, 3)
        Me.dtFechaVencimientoHasta.Name = "dtFechaVencimientoHasta"
        Me.dtFechaVencimientoHasta.Size = New System.Drawing.Size(115, 21)
        Me.dtFechaVencimientoHasta.TabIndex = 17
        '
        'chkFechaVencimiento
        '
        Me.chkFechaVencimiento.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkFechaVencimiento.AutoSize = True
        Me.chkFechaVencimiento.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.FrmChequeAdministracionViewModelBindingSource, "FechaVencimientoFiltro", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.chkFechaVencimiento.Location = New System.Drawing.Point(265, 5)
        Me.chkFechaVencimiento.Name = "chkFechaVencimiento"
        Me.chkFechaVencimiento.Size = New System.Drawing.Size(16, 14)
        Me.chkFechaVencimiento.TabIndex = 18
        Me.chkFechaVencimiento.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(154, 16)
        Me.Label7.TabIndex = 372
        Me.Label7.Text = "Importe"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(154, 16)
        Me.Label5.TabIndex = 332
        Me.Label5.Text = "N° Cheque"
        '
        'txtNumero
        '
        Me.txtNumero.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNumero.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmChequeAdministracionViewModelBindingSource, "NumeroCheque", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "N0"))
        Me.txtNumero.Location = New System.Drawing.Point(163, 37)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(284, 21)
        Me.txtNumero.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 16)
        Me.Label4.TabIndex = 322
        Me.Label4.Text = "Banco Emisor"
        '
        'cmbBancoEmisor
        '
        Me.cmbBancoEmisor.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbBancoEmisor.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.FrmChequeAdministracionViewModelBindingSource, "BancoEmisorSeleccionado", True))
        Me.cmbBancoEmisor.DataSource = Me.BancosEmisoresBindingSource
        Me.cmbBancoEmisor.DisplayMember = "Value"
        Me.cmbBancoEmisor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBancoEmisor.FormattingEnabled = True
        Me.cmbBancoEmisor.Location = New System.Drawing.Point(163, 68)
        Me.cmbBancoEmisor.Name = "cmbBancoEmisor"
        Me.cmbBancoEmisor.Size = New System.Drawing.Size(284, 23)
        Me.cmbBancoEmisor.TabIndex = 15
        Me.cmbBancoEmisor.ValueMember = "Key"
        '
        'BancosEmisoresBindingSource
        '
        Me.BancosEmisoresBindingSource.DataMember = "BancosEmisores"
        Me.BancosEmisoresBindingSource.DataSource = Me.FrmChequeAdministracionViewModelBindingSource
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 136)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(154, 16)
        Me.Label8.TabIndex = 402
        Me.Label8.Text = "Fecha Salida"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(154, 16)
        Me.Label6.TabIndex = 362
        Me.Label6.Text = "Fecha Vencimiento"
        '
        'ListBoxDestinoSalida
        '
        Me.ListBoxDestinoSalida.DataSource = Me.DestinosSalidasBindingSource
        Me.ListBoxDestinoSalida.DisplayMember = "Key"
        Me.ListBoxDestinoSalida.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBoxDestinoSalida.FormattingEnabled = True
        Me.ListBoxDestinoSalida.ItemHeight = 15
        Me.ListBoxDestinoSalida.Location = New System.Drawing.Point(163, 163)
        Me.ListBoxDestinoSalida.Name = "ListBoxDestinoSalida"
        Me.ListBoxDestinoSalida.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.ListBoxDestinoSalida.Size = New System.Drawing.Size(284, 86)
        Me.ListBoxDestinoSalida.TabIndex = 430
        Me.ListBoxDestinoSalida.ValueMember = "Value"
        '
        'DestinosSalidasBindingSource
        '
        Me.DestinosSalidasBindingSource.DataMember = "DestinosSalidas"
        Me.DestinosSalidasBindingSource.DataSource = Me.FrmChequeAdministracionViewModelBindingSource
        '
        'TableLayoutPanel10
        '
        Me.TableLayoutPanel10.ColumnCount = 2
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel10.Controls.Add(Me.Label23, 0, 5)
        Me.TableLayoutPanel10.Controls.Add(Me.TableLayoutPanel4, 1, 4)
        Me.TableLayoutPanel10.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel10.Controls.Add(Me.TableLayoutPanel3, 1, 3)
        Me.TableLayoutPanel10.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel10.Controls.Add(Me.txtLibradorNombre, 1, 2)
        Me.TableLayoutPanel10.Controls.Add(Me.txtClienteNombre, 1, 1)
        Me.TableLayoutPanel10.Controls.Add(Me.TableLayoutPanel2, 1, 0)
        Me.TableLayoutPanel10.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel10.Controls.Add(Me.Label12, 0, 3)
        Me.TableLayoutPanel10.Controls.Add(Me.Label11, 0, 4)
        Me.TableLayoutPanel10.Controls.Add(Me.ListBoxEstado, 1, 5)
        Me.TableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel10.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel10.Name = "TableLayoutPanel10"
        Me.TableLayoutPanel10.RowCount = 6
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel10.Size = New System.Drawing.Size(449, 252)
        Me.TableLayoutPanel10.TabIndex = 1
        '
        'Label23
        '
        Me.Label23.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(3, 160)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(154, 16)
        Me.Label23.TabIndex = 428
        Me.Label23.Text = "Estado"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 4
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.dtFechaDepositoDesde, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label26, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.dtFechaDepositoHasta, 2, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.chkFechaDeposito, 3, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(163, 131)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(283, 26)
        Me.TableLayoutPanel4.TabIndex = 426
        '
        'dtFechaDepositoDesde
        '
        Me.dtFechaDepositoDesde.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtFechaDepositoDesde.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FrmChequeAdministracionViewModelBindingSource, "FechaDepostioDesde", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "D"))
        Me.dtFechaDepositoDesde.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.FrmChequeAdministracionViewModelBindingSource, "FechaDepostioFiltro", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.dtFechaDepositoDesde.Enabled = False
        Me.dtFechaDepositoDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaDepositoDesde.Location = New System.Drawing.Point(3, 3)
        Me.dtFechaDepositoDesde.Name = "dtFechaDepositoDesde"
        Me.dtFechaDepositoDesde.Size = New System.Drawing.Size(115, 21)
        Me.dtFechaDepositoDesde.TabIndex = 6
        '
        'Label26
        '
        Me.Label26.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(124, 5)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(14, 16)
        Me.Label26.TabIndex = 410
        Me.Label26.Text = "-"
        '
        'dtFechaDepositoHasta
        '
        Me.dtFechaDepositoHasta.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtFechaDepositoHasta.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FrmChequeAdministracionViewModelBindingSource, "FechaDepostioHasta", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "D"))
        Me.dtFechaDepositoHasta.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.FrmChequeAdministracionViewModelBindingSource, "FechaDepostioFiltro", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.dtFechaDepositoHasta.Enabled = False
        Me.dtFechaDepositoHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaDepositoHasta.Location = New System.Drawing.Point(144, 3)
        Me.dtFechaDepositoHasta.Name = "dtFechaDepositoHasta"
        Me.dtFechaDepositoHasta.Size = New System.Drawing.Size(115, 21)
        Me.dtFechaDepositoHasta.TabIndex = 7
        '
        'chkFechaDeposito
        '
        Me.chkFechaDeposito.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkFechaDeposito.AutoSize = True
        Me.chkFechaDeposito.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.FrmChequeAdministracionViewModelBindingSource, "FechaDepostioFiltro", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.chkFechaDeposito.Location = New System.Drawing.Point(265, 6)
        Me.chkFechaDeposito.Name = "chkFechaDeposito"
        Me.chkFechaDeposito.Size = New System.Drawing.Size(15, 14)
        Me.chkFechaDeposito.TabIndex = 8
        Me.chkFechaDeposito.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 16)
        Me.Label1.TabIndex = 112
        Me.Label1.Text = "Marca Facturado"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 4
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.dtFechaIngresoDesde, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label24, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.dtFechaIngresoHasta, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.chkFechaIngreso, 3, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(163, 99)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(283, 26)
        Me.TableLayoutPanel3.TabIndex = 426
        '
        'dtFechaIngresoDesde
        '
        Me.dtFechaIngresoDesde.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtFechaIngresoDesde.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FrmChequeAdministracionViewModelBindingSource, "FechaIngresoDesde", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "D"))
        Me.dtFechaIngresoDesde.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.FrmChequeAdministracionViewModelBindingSource, "FechaIngresoFiltro", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.dtFechaIngresoDesde.Enabled = False
        Me.dtFechaIngresoDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaIngresoDesde.Location = New System.Drawing.Point(3, 3)
        Me.dtFechaIngresoDesde.Name = "dtFechaIngresoDesde"
        Me.dtFechaIngresoDesde.Size = New System.Drawing.Size(115, 21)
        Me.dtFechaIngresoDesde.TabIndex = 3
        '
        'Label24
        '
        Me.Label24.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(124, 5)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(14, 16)
        Me.Label24.TabIndex = 409
        Me.Label24.Text = "-"
        '
        'dtFechaIngresoHasta
        '
        Me.dtFechaIngresoHasta.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtFechaIngresoHasta.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FrmChequeAdministracionViewModelBindingSource, "FechaIngresoHasta", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "D"))
        Me.dtFechaIngresoHasta.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.FrmChequeAdministracionViewModelBindingSource, "FechaIngresoFiltro", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.dtFechaIngresoHasta.Enabled = False
        Me.dtFechaIngresoHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaIngresoHasta.Location = New System.Drawing.Point(144, 3)
        Me.dtFechaIngresoHasta.Name = "dtFechaIngresoHasta"
        Me.dtFechaIngresoHasta.Size = New System.Drawing.Size(115, 21)
        Me.dtFechaIngresoHasta.TabIndex = 4
        '
        'chkFechaIngreso
        '
        Me.chkFechaIngreso.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkFechaIngreso.AutoSize = True
        Me.chkFechaIngreso.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.FrmChequeAdministracionViewModelBindingSource, "FechaIngresoFiltro", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.chkFechaIngreso.Location = New System.Drawing.Point(265, 6)
        Me.chkFechaIngreso.Name = "chkFechaIngreso"
        Me.chkFechaIngreso.Size = New System.Drawing.Size(15, 14)
        Me.chkFechaIngreso.TabIndex = 5
        Me.chkFechaIngreso.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 16)
        Me.Label2.TabIndex = 122
        Me.Label2.Text = "Cliente"
        '
        'txtLibradorNombre
        '
        Me.txtLibradorNombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLibradorNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmChequeAdministracionViewModelBindingSource, "Librado", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtLibradorNombre.Location = New System.Drawing.Point(163, 69)
        Me.txtLibradorNombre.Name = "txtLibradorNombre"
        Me.txtLibradorNombre.Size = New System.Drawing.Size(283, 21)
        Me.txtLibradorNombre.TabIndex = 2
        '
        'txtClienteNombre
        '
        Me.txtClienteNombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtClienteNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmChequeAdministracionViewModelBindingSource, "Cliente", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtClienteNombre.Location = New System.Drawing.Point(163, 37)
        Me.txtClienteNombre.Name = "txtClienteNombre"
        Me.txtClienteNombre.Size = New System.Drawing.Size(283, 21)
        Me.txtClienteNombre.TabIndex = 1
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.ChkMarcaFacturadoSi, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.ChkMarcaFacturadoNo, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(163, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(283, 26)
        Me.TableLayoutPanel2.TabIndex = 426
        '
        'ChkMarcaFacturadoSi
        '
        Me.ChkMarcaFacturadoSi.AutoSize = True
        Me.ChkMarcaFacturadoSi.Checked = True
        Me.ChkMarcaFacturadoSi.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkMarcaFacturadoSi.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.FrmChequeAdministracionViewModelBindingSource, "FacturadoSi", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ChkMarcaFacturadoSi.Location = New System.Drawing.Point(3, 3)
        Me.ChkMarcaFacturadoSi.Name = "ChkMarcaFacturadoSi"
        Me.ChkMarcaFacturadoSi.Size = New System.Drawing.Size(37, 19)
        Me.ChkMarcaFacturadoSi.TabIndex = 418
        Me.ChkMarcaFacturadoSi.Text = "Si"
        Me.ChkMarcaFacturadoSi.UseVisualStyleBackColor = True
        '
        'ChkMarcaFacturadoNo
        '
        Me.ChkMarcaFacturadoNo.AutoSize = True
        Me.ChkMarcaFacturadoNo.Checked = True
        Me.ChkMarcaFacturadoNo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkMarcaFacturadoNo.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.FrmChequeAdministracionViewModelBindingSource, "FacturadoNo", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ChkMarcaFacturadoNo.Location = New System.Drawing.Point(144, 3)
        Me.ChkMarcaFacturadoNo.Name = "ChkMarcaFacturadoNo"
        Me.ChkMarcaFacturadoNo.Size = New System.Drawing.Size(42, 19)
        Me.ChkMarcaFacturadoNo.TabIndex = 419
        Me.ChkMarcaFacturadoNo.Text = "No"
        Me.ChkMarcaFacturadoNo.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 16)
        Me.Label3.TabIndex = 142
        Me.Label3.Text = "Librador"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(3, 104)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(154, 16)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "Fecha Ingreso"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(3, 136)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(154, 16)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Fecha Deposito"
        '
        'ListBoxEstado
        '
        Me.ListBoxEstado.DataSource = Me.EstadosBindingSource
        Me.ListBoxEstado.DisplayMember = "Key"
        Me.ListBoxEstado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBoxEstado.FormattingEnabled = True
        Me.ListBoxEstado.ItemHeight = 15
        Me.ListBoxEstado.Location = New System.Drawing.Point(163, 163)
        Me.ListBoxEstado.Name = "ListBoxEstado"
        Me.ListBoxEstado.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.ListBoxEstado.Size = New System.Drawing.Size(283, 86)
        Me.ListBoxEstado.TabIndex = 429
        Me.ListBoxEstado.ValueMember = "Value"
        '
        'EstadosBindingSource
        '
        Me.EstadosBindingSource.DataMember = "Estados"
        Me.EstadosBindingSource.DataSource = Me.FrmChequeAdministracionViewModelBindingSource
        '
        'btnBuscar
        '
        Me.btnBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.FlatAppearance.BorderSize = 0
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Image = Global.SistemaCinderella.My.Resources.Recursos.IconoBuscar32
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(857, 281)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(100, 40)
        Me.btnBuscar.TabIndex = 23
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btn_Restablecer
        '
        Me.btn_Restablecer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Restablecer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Restablecer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Restablecer.Location = New System.Drawing.Point(751, 281)
        Me.btn_Restablecer.Name = "btn_Restablecer"
        Me.btn_Restablecer.Size = New System.Drawing.Size(100, 40)
        Me.btn_Restablecer.TabIndex = 22
        Me.btn_Restablecer.Text = "Restablecer Busqueda"
        Me.btn_Restablecer.UseVisualStyleBackColor = True
        '
        'TabDetalle
        '
        Me.TabDetalle.Controls.Add(Me.TableLayoutPanel1)
        Me.TabDetalle.Location = New System.Drawing.Point(4, 29)
        Me.TabDetalle.Name = "TabDetalle"
        Me.TabDetalle.Padding = New System.Windows.Forms.Padding(3)
        Me.TabDetalle.Size = New System.Drawing.Size(976, 729)
        Me.TabDetalle.TabIndex = 1
        Me.TabDetalle.Text = "Detalle del Cheque"
        Me.TabDetalle.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel14, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(970, 723)
        Me.TableLayoutPanel1.TabIndex = 97
        '
        'GroupBox
        '
        Me.GroupBox.Controls.Add(Me.ucChequeDetalle)
        Me.GroupBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(964, 498)
        Me.GroupBox.TabIndex = 95
        Me.GroupBox.TabStop = False
        Me.GroupBox.Text = "Información del cheque"
        '
        'ucChequeDetalle
        '
        Me.ucChequeDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ucChequeDetalle.Location = New System.Drawing.Point(12, 20)
        Me.ucChequeDetalle.Name = "ucChequeDetalle"
        Me.ucChequeDetalle.Size = New System.Drawing.Size(946, 478)
        Me.ucChequeDetalle.TabIndex = 91
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TableLayoutPanel11)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(3, 507)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(964, 162)
        Me.GroupBox2.TabIndex = 96
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Información de salida"
        '
        'TableLayoutPanel11
        '
        Me.TableLayoutPanel11.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel11.ColumnCount = 2
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.26714!))
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.73286!))
        Me.TableLayoutPanel11.Controls.Add(Me.Label16, 0, 0)
        Me.TableLayoutPanel11.Controls.Add(Me.DetalleSalida, 1, 1)
        Me.TableLayoutPanel11.Controls.Add(Me.cmbDestinoSalida, 1, 0)
        Me.TableLayoutPanel11.Controls.Add(Me.Label22, 0, 1)
        Me.TableLayoutPanel11.Location = New System.Drawing.Point(6, 19)
        Me.TableLayoutPanel11.Name = "TableLayoutPanel11"
        Me.TableLayoutPanel11.RowCount = 2
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.33333!))
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.66666!))
        Me.TableLayoutPanel11.Size = New System.Drawing.Size(846, 143)
        Me.TableLayoutPanel11.TabIndex = 167
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(3, 10)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(156, 13)
        Me.Label16.TabIndex = 82
        Me.Label16.Text = "Destino Salida (*)"
        '
        'DetalleSalida
        '
        Me.DetalleSalida.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DetalleSalida.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmChequeAdministracionViewModelBindingSource, "DestinoSalidaComentarioDetalle", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DetalleSalida.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DetalleSalida.Location = New System.Drawing.Point(165, 36)
        Me.DetalleSalida.Multiline = True
        Me.DetalleSalida.Name = "DetalleSalida"
        Me.DetalleSalida.Size = New System.Drawing.Size(678, 104)
        Me.DetalleSalida.TabIndex = 165
        '
        'cmbDestinoSalida
        '
        Me.cmbDestinoSalida.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbDestinoSalida.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.FrmChequeAdministracionViewModelBindingSource, "DestinoSalidaDetalleSeleccionado", True))
        Me.cmbDestinoSalida.DataSource = Me.DestinosSalidasBindingSource1
        Me.cmbDestinoSalida.DisplayMember = "Value"
        Me.cmbDestinoSalida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDestinoSalida.FormattingEnabled = True
        Me.cmbDestinoSalida.Location = New System.Drawing.Point(165, 6)
        Me.cmbDestinoSalida.Name = "cmbDestinoSalida"
        Me.cmbDestinoSalida.Size = New System.Drawing.Size(678, 21)
        Me.cmbDestinoSalida.TabIndex = 9
        Me.cmbDestinoSalida.ValueMember = "Key"
        '
        'DestinosSalidasBindingSource1
        '
        Me.DestinosSalidasBindingSource1.DataMember = "DestinosSalidas"
        Me.DestinosSalidasBindingSource1.DataSource = Me.FrmChequeAdministracionViewModelBindingSource
        '
        'Label22
        '
        Me.Label22.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(3, 33)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(156, 13)
        Me.Label22.TabIndex = 166
        Me.Label22.Text = "Detalle Salida"
        '
        'TableLayoutPanel14
        '
        Me.TableLayoutPanel14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel14.ColumnCount = 2
        Me.TableLayoutPanel14.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel14.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel14.Controls.Add(Me.btn_Modificar, 1, 0)
        Me.TableLayoutPanel14.Controls.Add(Me.Btn_Cancelar, 0, 0)
        Me.TableLayoutPanel14.Location = New System.Drawing.Point(751, 675)
        Me.TableLayoutPanel14.Name = "TableLayoutPanel14"
        Me.TableLayoutPanel14.RowCount = 1
        Me.TableLayoutPanel14.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel14.Size = New System.Drawing.Size(216, 45)
        Me.TableLayoutPanel14.TabIndex = 97
        '
        'btn_Modificar
        '
        Me.btn_Modificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Modificar.BackColor = System.Drawing.Color.Transparent
        Me.btn_Modificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Modificar.Image = Global.SistemaCinderella.My.Resources.Recursos.Editar_24
        Me.btn_Modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Modificar.Location = New System.Drawing.Point(113, 3)
        Me.btn_Modificar.Name = "btn_Modificar"
        Me.btn_Modificar.Size = New System.Drawing.Size(100, 39)
        Me.btn_Modificar.TabIndex = 89
        Me.btn_Modificar.Text = "Modificar"
        Me.btn_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Modificar.UseVisualStyleBackColor = False
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Cancelar.Image = Global.SistemaCinderella.My.Resources.Recursos.desconectado_32
        Me.Btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Cancelar.Location = New System.Drawing.Point(5, 3)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(100, 39)
        Me.Btn_Cancelar.TabIndex = 90
        Me.Btn_Cancelar.Text = "Cancelar"
        Me.Btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Cancelar.UseVisualStyleBackColor = True
        '
        'frmChequeAdministracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 762)
        Me.Controls.Add(Me.tabAdministracion)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmChequeAdministracion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administración de Cheques"
        Me.tabAdministracion.ResumeLayout(False)
        Me.TabCheques.ResumeLayout(False)
        Me.TableLayoutPanel13.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.FrmChequeAdministracionViewModelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCheques, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChequesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel12.ResumeLayout(False)
        Me.TableLayoutPanel12.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel8.PerformLayout()
        Me.TableLayoutPanel9.ResumeLayout(False)
        Me.TableLayoutPanel9.PerformLayout()
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel7.PerformLayout()
        CType(Me.BancosEmisoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DestinosSalidasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel10.ResumeLayout(False)
        Me.TableLayoutPanel10.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.EstadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabDetalle.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.TableLayoutPanel11.ResumeLayout(False)
        Me.TableLayoutPanel11.PerformLayout()
        CType(Me.DestinosSalidasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel14.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabAdministracion As TabControl
    Friend WithEvents TabCheques As TabPage
    Friend WithEvents TabDetalle As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_Exportar As Button
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents Label31 As Label
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents dtFechaSalidaDesde As DateTimePicker
    Friend WithEvents Label28 As Label
    Friend WithEvents dtFechaSalidaHasta As DateTimePicker
    Friend WithEvents chkFechaSalida As CheckBox
    Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
    Friend WithEvents txtImporteDesde As TextBox
    Friend WithEvents txtImporteHasta As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents dtFechaVencimientoDesde As DateTimePicker
    Friend WithEvents Label27 As Label
    Friend WithEvents dtFechaVencimientoHasta As DateTimePicker
    Friend WithEvents chkFechaVencimiento As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbBancoEmisor As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ListBoxDestinoSalida As ListBox
    Friend WithEvents TableLayoutPanel10 As TableLayoutPanel
    Friend WithEvents Label23 As Label
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents dtFechaDepositoDesde As DateTimePicker
    Friend WithEvents Label26 As Label
    Friend WithEvents dtFechaDepositoHasta As DateTimePicker
    Friend WithEvents chkFechaDeposito As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents dtFechaIngresoDesde As DateTimePicker
    Friend WithEvents Label24 As Label
    Friend WithEvents dtFechaIngresoHasta As DateTimePicker
    Friend WithEvents chkFechaIngreso As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtLibradorNombre As TextBox
    Friend WithEvents txtClienteNombre As TextBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents ChkMarcaFacturadoSi As CheckBox
    Friend WithEvents ChkMarcaFacturadoNo As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents ListBoxEstado As ListBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btn_Restablecer As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lbl_Msg As Label
    Friend WithEvents dgvCheques As DataGridView
    Friend WithEvents lbl_TotalCartera As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents lbl_TotalPantalla As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents GroupBox As GroupBox
    Friend WithEvents Btn_Cancelar As Button
    Friend WithEvents btn_Modificar As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DetalleSalida As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents cmbDestinoSalida As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents TableLayoutPanel11 As TableLayoutPanel
    Friend WithEvents FrmChequeAdministracionViewModelBindingSource As BindingSource
    Friend WithEvents DestinosSalidasBindingSource As BindingSource
    Friend WithEvents EstadosBindingSource As BindingSource
    Friend WithEvents NumeroOrdenDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ChequesBindingSource As BindingSource
    Friend WithEvents TableLayoutPanel13 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel12 As TableLayoutPanel
    Friend WithEvents BancosEmisoresBindingSource As BindingSource
    Friend WithEvents ucChequeDetalle As ChequeDetalle
    Friend WithEvents TableLayoutPanel14 As TableLayoutPanel
    Friend WithEvents DestinosSalidasBindingSource1 As BindingSource
    Friend WithEvents SaveFileDialog As SaveFileDialog
    Friend WithEvents NumeroOrden As DataGridViewTextBoxColumn
    Friend WithEvents MarcaFacturado As DataGridViewTextBoxColumn
    Friend WithEvents ClienteNombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LibradorNombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BancoEmisorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumeroChequeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaIngresoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDespositoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaVencimientoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaSalida As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents DestinoSalida As DataGridViewTextBoxColumn
    Friend WithEvents MontoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
