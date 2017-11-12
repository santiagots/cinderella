<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChequesAdministracion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChequesAdministracion))
        Me.TabCheques = New System.Windows.Forms.TabControl()
        Me.BusquedaTab = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.chkSinSalida = New System.Windows.Forms.CheckBox()
        Me.chkOtros = New System.Windows.Forms.CheckBox()
        Me.chkDepositado = New System.Windows.Forms.CheckBox()
        Me.chkDevuelto = New System.Windows.Forms.CheckBox()
        Me.chkPasado = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.chkIngresado = New System.Windows.Forms.CheckBox()
        Me.ChkSalido = New System.Windows.Forms.CheckBox()
        Me.ChkReingresado = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.dtFechaDepositoDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.dtFechaDepositoHasta = New System.Windows.Forms.DateTimePicker()
        Me.chkFechaDeposito = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.dtFechaIngresoDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.dtFechaIngresoHasta = New System.Windows.Forms.DateTimePicker()
        Me.chkFechaIngreso = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.ChkMarcaFacturadoSi = New System.Windows.Forms.CheckBox()
        Me.ChkMarcaFacturadoNo = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtClienteNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLibradorNombre = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_TotalCartera = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.lbl_TotalPantalla = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.lbl_Msg = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_Exportar = New System.Windows.Forms.Button()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtImporteHasta = New System.Windows.Forms.TextBox()
        Me.dtFechaSalidaHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.dtFechaVencimientoHasta = New System.Windows.Forms.DateTimePicker()
        Me.chkFechaSalida = New System.Windows.Forms.CheckBox()
        Me.chkFechaVencimiento = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtFechaSalidaDesde = New System.Windows.Forms.DateTimePicker()
        Me.txtImporteDesde = New System.Windows.Forms.TextBox()
        Me.dtFechaVencimientoDesde = New System.Windows.Forms.DateTimePicker()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.cmbBancoEmisor = New System.Windows.Forms.ComboBox()
        Me.BancoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btn_Restablecer = New System.Windows.Forms.Button()
        Me.BtnFiltrar = New System.Windows.Forms.Button()
        Me.dgvCheques = New System.Windows.Forms.DataGridView()
        Me.ChequeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DetalleTab = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DetalleSalida = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cmbDestinoSalida = New System.Windows.Forms.ComboBox()
        Me.Btn_Salida = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.EstadoDetalle = New System.Windows.Forms.TextBox()
        Me.BancoEmisor = New System.Windows.Forms.ComboBox()
        Me.DetalleBancoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label30 = New System.Windows.Forms.Label()
        Me.DetalleFechaSalida = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.btn_Modificar = New System.Windows.Forms.Button()
        Me.Btn_Buscar_Librador = New System.Windows.Forms.Button()
        Me.chkDetalleMarcaFacturado = New System.Windows.Forms.CheckBox()
        Me.LibradorID = New System.Windows.Forms.TextBox()
        Me.ClienteID = New System.Windows.Forms.TextBox()
        Me.FechaIngreso = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Btn_Agregar_Banco = New System.Windows.Forms.Button()
        Me.Importe = New System.Windows.Forms.TextBox()
        Me.NumeroOrden = New System.Windows.Forms.TextBox()
        Me.Btn_Buscar_Cliente = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ClienteNombre = New System.Windows.Forms.TextBox()
        Me.FechaDeposito = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.FechaVencimiento = New System.Windows.Forms.DateTimePicker()
        Me.LibradorNombre = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.NumeroCheque = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel9 = New System.Windows.Forms.TableLayoutPanel()
        Me.IdChequeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroOrdenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarcaFacturado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteNombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LibradorNombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Banco = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.NumeroChequeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaIngresoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDespositoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaVencimientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaSalidaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DestinoSalida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabCheques.SuspendLayout()
        Me.BusquedaTab.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BancoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCheques, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChequeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DetalleTab.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox.SuspendLayout()
        CType(Me.DetalleBancoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        Me.TableLayoutPanel9.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabCheques
        '
        Me.TabCheques.Controls.Add(Me.BusquedaTab)
        Me.TabCheques.Controls.Add(Me.DetalleTab)
        Me.TabCheques.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabCheques.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TabCheques.Location = New System.Drawing.Point(0, 0)
        Me.TabCheques.Name = "TabCheques"
        Me.TabCheques.SelectedIndex = 0
        Me.TabCheques.Size = New System.Drawing.Size(984, 762)
        Me.TabCheques.TabIndex = 18
        '
        'BusquedaTab
        '
        Me.BusquedaTab.Controls.Add(Me.btn_Exportar)
        Me.BusquedaTab.Controls.Add(Me.lbl_TotalCartera)
        Me.BusquedaTab.Controls.Add(Me.btn_Restablecer)
        Me.BusquedaTab.Controls.Add(Me.Label35)
        Me.BusquedaTab.Controls.Add(Me.lbl_TotalPantalla)
        Me.BusquedaTab.Controls.Add(Me.BtnFiltrar)
        Me.BusquedaTab.Controls.Add(Me.Label33)
        Me.BusquedaTab.Controls.Add(Me.lbl_Msg)
        Me.BusquedaTab.Controls.Add(Me.GroupBox1)
        Me.BusquedaTab.Controls.Add(Me.dgvCheques)
        Me.BusquedaTab.Location = New System.Drawing.Point(4, 29)
        Me.BusquedaTab.Name = "BusquedaTab"
        Me.BusquedaTab.Padding = New System.Windows.Forms.Padding(3)
        Me.BusquedaTab.Size = New System.Drawing.Size(976, 729)
        Me.BusquedaTab.TabIndex = 0
        Me.BusquedaTab.Text = "Cheques"
        Me.BusquedaTab.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel9, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel8, 4, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel7, 4, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel6, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel5, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label31, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtClienteNombre, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 3, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtLibradorNombre, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbBancoEmisor, 4, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtNumero, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label12, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label11, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label23, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 3, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 17)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(956, 246)
        Me.TableLayoutPanel1.TabIndex = 408
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 3
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel6.Controls.Add(Me.chkSinSalida, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.chkOtros, 1, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.chkDepositado, 1, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.chkDevuelto, 0, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.chkPasado, 2, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(163, 186)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 2
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(272, 57)
        Me.TableLayoutPanel6.TabIndex = 426
        '
        'chkSinSalida
        '
        Me.chkSinSalida.AutoSize = True
        Me.chkSinSalida.Checked = True
        Me.chkSinSalida.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSinSalida.Location = New System.Drawing.Point(3, 3)
        Me.chkSinSalida.Name = "chkSinSalida"
        Me.chkSinSalida.Size = New System.Drawing.Size(82, 19)
        Me.chkSinSalida.TabIndex = 420
        Me.chkSinSalida.Text = "Sin Salida"
        Me.chkSinSalida.UseVisualStyleBackColor = True
        '
        'chkOtros
        '
        Me.chkOtros.AutoSize = True
        Me.chkOtros.Checked = True
        Me.chkOtros.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkOtros.Location = New System.Drawing.Point(93, 29)
        Me.chkOtros.Name = "chkOtros"
        Me.chkOtros.Size = New System.Drawing.Size(55, 19)
        Me.chkOtros.TabIndex = 425
        Me.chkOtros.Text = "Otros"
        Me.chkOtros.UseVisualStyleBackColor = True
        '
        'chkDepositado
        '
        Me.chkDepositado.AutoSize = True
        Me.chkDepositado.Checked = True
        Me.chkDepositado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDepositado.Location = New System.Drawing.Point(93, 3)
        Me.chkDepositado.Name = "chkDepositado"
        Me.chkDepositado.Size = New System.Drawing.Size(84, 19)
        Me.chkDepositado.TabIndex = 421
        Me.chkDepositado.Text = "Depositado"
        Me.chkDepositado.UseVisualStyleBackColor = True
        '
        'chkDevuelto
        '
        Me.chkDevuelto.AutoSize = True
        Me.chkDevuelto.Checked = True
        Me.chkDevuelto.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDevuelto.Location = New System.Drawing.Point(3, 29)
        Me.chkDevuelto.Name = "chkDevuelto"
        Me.chkDevuelto.Size = New System.Drawing.Size(74, 19)
        Me.chkDevuelto.TabIndex = 424
        Me.chkDevuelto.Text = "Devuelto"
        Me.chkDevuelto.UseVisualStyleBackColor = True
        '
        'chkPasado
        '
        Me.chkPasado.AutoSize = True
        Me.chkPasado.Checked = True
        Me.chkPasado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPasado.Location = New System.Drawing.Point(183, 3)
        Me.chkPasado.Name = "chkPasado"
        Me.chkPasado.Size = New System.Drawing.Size(68, 19)
        Me.chkPasado.TabIndex = 422
        Me.chkPasado.Text = "Pasado"
        Me.chkPasado.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 3
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel5.Controls.Add(Me.chkIngresado, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.ChkSalido, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.ChkReingresado, 2, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(163, 155)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(272, 25)
        Me.TableLayoutPanel5.TabIndex = 426
        '
        'chkIngresado
        '
        Me.chkIngresado.AutoSize = True
        Me.chkIngresado.Checked = True
        Me.chkIngresado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkIngresado.Location = New System.Drawing.Point(3, 3)
        Me.chkIngresado.Name = "chkIngresado"
        Me.chkIngresado.Size = New System.Drawing.Size(81, 19)
        Me.chkIngresado.TabIndex = 9
        Me.chkIngresado.Text = "Ingresado"
        Me.chkIngresado.UseVisualStyleBackColor = True
        '
        'ChkSalido
        '
        Me.ChkSalido.AutoSize = True
        Me.ChkSalido.Checked = True
        Me.ChkSalido.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkSalido.Location = New System.Drawing.Point(93, 3)
        Me.ChkSalido.Name = "ChkSalido"
        Me.ChkSalido.Size = New System.Drawing.Size(61, 19)
        Me.ChkSalido.TabIndex = 10
        Me.ChkSalido.Text = "Salido"
        Me.ChkSalido.UseVisualStyleBackColor = True
        '
        'ChkReingresado
        '
        Me.ChkReingresado.AutoSize = True
        Me.ChkReingresado.Checked = True
        Me.ChkReingresado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkReingresado.Location = New System.Drawing.Point(183, 3)
        Me.ChkReingresado.Name = "ChkReingresado"
        Me.ChkReingresado.Size = New System.Drawing.Size(86, 19)
        Me.ChkReingresado.TabIndex = 11
        Me.ChkReingresado.Text = "Reingresado"
        Me.ChkReingresado.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 4
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.dtFechaDepositoDesde, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label26, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.dtFechaDepositoHasta, 2, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.chkFechaDeposito, 3, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(163, 125)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(272, 24)
        Me.TableLayoutPanel4.TabIndex = 426
        '
        'dtFechaDepositoDesde
        '
        Me.dtFechaDepositoDesde.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtFechaDepositoDesde.Enabled = False
        Me.dtFechaDepositoDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaDepositoDesde.Location = New System.Drawing.Point(3, 3)
        Me.dtFechaDepositoDesde.Name = "dtFechaDepositoDesde"
        Me.dtFechaDepositoDesde.Size = New System.Drawing.Size(110, 21)
        Me.dtFechaDepositoDesde.TabIndex = 6
        '
        'Label26
        '
        Me.Label26.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(119, 4)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(14, 16)
        Me.Label26.TabIndex = 410
        Me.Label26.Text = "-"
        '
        'dtFechaDepositoHasta
        '
        Me.dtFechaDepositoHasta.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtFechaDepositoHasta.Enabled = False
        Me.dtFechaDepositoHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaDepositoHasta.Location = New System.Drawing.Point(139, 3)
        Me.dtFechaDepositoHasta.Name = "dtFechaDepositoHasta"
        Me.dtFechaDepositoHasta.Size = New System.Drawing.Size(110, 21)
        Me.dtFechaDepositoHasta.TabIndex = 7
        '
        'chkFechaDeposito
        '
        Me.chkFechaDeposito.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkFechaDeposito.AutoSize = True
        Me.chkFechaDeposito.Location = New System.Drawing.Point(255, 5)
        Me.chkFechaDeposito.Name = "chkFechaDeposito"
        Me.chkFechaDeposito.Size = New System.Drawing.Size(14, 14)
        Me.chkFechaDeposito.TabIndex = 8
        Me.chkFechaDeposito.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 4
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.dtFechaIngresoDesde, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label24, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.dtFechaIngresoHasta, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.chkFechaIngreso, 3, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(163, 95)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(272, 24)
        Me.TableLayoutPanel3.TabIndex = 426
        '
        'dtFechaIngresoDesde
        '
        Me.dtFechaIngresoDesde.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtFechaIngresoDesde.Enabled = False
        Me.dtFechaIngresoDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaIngresoDesde.Location = New System.Drawing.Point(3, 3)
        Me.dtFechaIngresoDesde.Name = "dtFechaIngresoDesde"
        Me.dtFechaIngresoDesde.Size = New System.Drawing.Size(110, 21)
        Me.dtFechaIngresoDesde.TabIndex = 3
        '
        'Label24
        '
        Me.Label24.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(119, 4)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(14, 16)
        Me.Label24.TabIndex = 409
        Me.Label24.Text = "-"
        '
        'dtFechaIngresoHasta
        '
        Me.dtFechaIngresoHasta.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtFechaIngresoHasta.Enabled = False
        Me.dtFechaIngresoHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaIngresoHasta.Location = New System.Drawing.Point(139, 3)
        Me.dtFechaIngresoHasta.Name = "dtFechaIngresoHasta"
        Me.dtFechaIngresoHasta.Size = New System.Drawing.Size(110, 21)
        Me.dtFechaIngresoHasta.TabIndex = 4
        '
        'chkFechaIngreso
        '
        Me.chkFechaIngreso.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkFechaIngreso.AutoSize = True
        Me.chkFechaIngreso.Location = New System.Drawing.Point(255, 5)
        Me.chkFechaIngreso.Name = "chkFechaIngreso"
        Me.chkFechaIngreso.Size = New System.Drawing.Size(14, 14)
        Me.chkFechaIngreso.TabIndex = 5
        Me.chkFechaIngreso.UseVisualStyleBackColor = True
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
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(272, 26)
        Me.TableLayoutPanel2.TabIndex = 426
        '
        'ChkMarcaFacturadoSi
        '
        Me.ChkMarcaFacturadoSi.AutoSize = True
        Me.ChkMarcaFacturadoSi.Checked = True
        Me.ChkMarcaFacturadoSi.CheckState = System.Windows.Forms.CheckState.Checked
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
        Me.ChkMarcaFacturadoNo.Location = New System.Drawing.Point(139, 3)
        Me.ChkMarcaFacturadoNo.Name = "ChkMarcaFacturadoNo"
        Me.ChkMarcaFacturadoNo.Size = New System.Drawing.Size(42, 19)
        Me.ChkMarcaFacturadoNo.TabIndex = 419
        Me.ChkMarcaFacturadoNo.Text = "No"
        Me.ChkMarcaFacturadoNo.UseVisualStyleBackColor = True
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
        'Label31
        '
        Me.Label31.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(3, 206)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(154, 16)
        Me.Label31.TabIndex = 423
        Me.Label31.Text = "Destino Salida"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 16)
        Me.Label2.TabIndex = 122
        Me.Label2.Text = "Cliente"
        '
        'txtClienteNombre
        '
        Me.txtClienteNombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtClienteNombre.Location = New System.Drawing.Point(163, 36)
        Me.txtClienteNombre.Name = "txtClienteNombre"
        Me.txtClienteNombre.Size = New System.Drawing.Size(272, 21)
        Me.txtClienteNombre.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 16)
        Me.Label3.TabIndex = 142
        Me.Label3.Text = "Librador"
        '
        'txtLibradorNombre
        '
        Me.txtLibradorNombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLibradorNombre.Location = New System.Drawing.Point(163, 66)
        Me.txtLibradorNombre.Name = "txtLibradorNombre"
        Me.txtLibradorNombre.Size = New System.Drawing.Size(272, 21)
        Me.txtLibradorNombre.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(3, 99)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(154, 16)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "Fecha Ingreso"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(521, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(154, 16)
        Me.Label6.TabIndex = 362
        Me.Label6.Text = "Fecha Vencimiento"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(521, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(154, 16)
        Me.Label7.TabIndex = 372
        Me.Label7.Text = "Importe"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(3, 129)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(154, 16)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Fecha Deposito"
        '
        'Label23
        '
        Me.Label23.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(3, 159)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(154, 16)
        Me.Label23.TabIndex = 404
        Me.Label23.Text = "Estado"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(521, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 16)
        Me.Label4.TabIndex = 322
        Me.Label4.Text = "Banco Emisor"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(521, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(154, 16)
        Me.Label5.TabIndex = 332
        Me.Label5.Text = "N° Cheque"
        '
        'lbl_TotalCartera
        '
        Me.lbl_TotalCartera.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_TotalCartera.AutoSize = True
        Me.lbl_TotalCartera.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TotalCartera.Location = New System.Drawing.Point(309, 695)
        Me.lbl_TotalCartera.Name = "lbl_TotalCartera"
        Me.lbl_TotalCartera.Size = New System.Drawing.Size(129, 24)
        Me.lbl_TotalCartera.TabIndex = 407
        Me.lbl_TotalCartera.Text = "$ 3.000.000.-"
        '
        'Label35
        '
        Me.Label35.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(4, 695)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(255, 24)
        Me.Label35.TabIndex = 406
        Me.Label35.Text = "Total Cheques en Cartera:"
        '
        'lbl_TotalPantalla
        '
        Me.lbl_TotalPantalla.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_TotalPantalla.AutoSize = True
        Me.lbl_TotalPantalla.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TotalPantalla.Location = New System.Drawing.Point(839, 695)
        Me.lbl_TotalPantalla.Name = "lbl_TotalPantalla"
        Me.lbl_TotalPantalla.Size = New System.Drawing.Size(129, 24)
        Me.lbl_TotalPantalla.TabIndex = 405
        Me.lbl_TotalPantalla.Text = "$ 3.000.000.-"
        '
        'Label33
        '
        Me.Label33.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(487, 695)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(261, 24)
        Me.Label33.TabIndex = 404
        Me.Label33.Text = "Total Cheques en Pantalla:"
        '
        'lbl_Msg
        '
        Me.lbl_Msg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Msg.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lbl_Msg.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Msg.Location = New System.Drawing.Point(161, 469)
        Me.lbl_Msg.Name = "lbl_Msg"
        Me.lbl_Msg.Size = New System.Drawing.Size(654, 25)
        Me.lbl_Msg.TabIndex = 403
        Me.lbl_Msg.Text = "No se han encontrado cheques con los filtros seleccionados."
        Me.lbl_Msg.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(962, 266)
        Me.GroupBox1.TabIndex = 17
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
        Me.btn_Exportar.Location = New System.Drawing.Point(651, 222)
        Me.btn_Exportar.Name = "btn_Exportar"
        Me.btn_Exportar.Size = New System.Drawing.Size(100, 40)
        Me.btn_Exportar.TabIndex = 19
        Me.btn_Exportar.Text = "Exportar"
        Me.btn_Exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Exportar.UseVisualStyleBackColor = True
        '
        'Label29
        '
        Me.Label29.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(129, 5)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(14, 16)
        Me.Label29.TabIndex = 417
        Me.Label29.Text = "-"
        '
        'txtImporteHasta
        '
        Me.txtImporteHasta.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtImporteHasta.Location = New System.Drawing.Point(149, 3)
        Me.txtImporteHasta.Name = "txtImporteHasta"
        Me.txtImporteHasta.Size = New System.Drawing.Size(120, 21)
        Me.txtImporteHasta.TabIndex = 13
        '
        'dtFechaSalidaHasta
        '
        Me.dtFechaSalidaHasta.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtFechaSalidaHasta.Enabled = False
        Me.dtFechaSalidaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaSalidaHasta.Location = New System.Drawing.Point(139, 3)
        Me.dtFechaSalidaHasta.Name = "dtFechaSalidaHasta"
        Me.dtFechaSalidaHasta.Size = New System.Drawing.Size(110, 21)
        Me.dtFechaSalidaHasta.TabIndex = 20
        '
        'Label28
        '
        Me.Label28.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(119, 4)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(14, 16)
        Me.Label28.TabIndex = 414
        Me.Label28.Text = "-"
        '
        'Label27
        '
        Me.Label27.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(119, 4)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(14, 16)
        Me.Label27.TabIndex = 413
        Me.Label27.Text = "-"
        '
        'dtFechaVencimientoHasta
        '
        Me.dtFechaVencimientoHasta.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtFechaVencimientoHasta.Enabled = False
        Me.dtFechaVencimientoHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaVencimientoHasta.Location = New System.Drawing.Point(139, 3)
        Me.dtFechaVencimientoHasta.Name = "dtFechaVencimientoHasta"
        Me.dtFechaVencimientoHasta.Size = New System.Drawing.Size(110, 21)
        Me.dtFechaVencimientoHasta.TabIndex = 17
        '
        'chkFechaSalida
        '
        Me.chkFechaSalida.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkFechaSalida.AutoSize = True
        Me.chkFechaSalida.Location = New System.Drawing.Point(255, 5)
        Me.chkFechaSalida.Name = "chkFechaSalida"
        Me.chkFechaSalida.Size = New System.Drawing.Size(14, 14)
        Me.chkFechaSalida.TabIndex = 21
        Me.chkFechaSalida.UseVisualStyleBackColor = True
        '
        'chkFechaVencimiento
        '
        Me.chkFechaVencimiento.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkFechaVencimiento.AutoSize = True
        Me.chkFechaVencimiento.Location = New System.Drawing.Point(255, 5)
        Me.chkFechaVencimiento.Name = "chkFechaVencimiento"
        Me.chkFechaVencimiento.Size = New System.Drawing.Size(14, 14)
        Me.chkFechaVencimiento.TabIndex = 18
        Me.chkFechaVencimiento.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(521, 129)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(154, 16)
        Me.Label8.TabIndex = 402
        Me.Label8.Text = "Fecha Salida"
        '
        'dtFechaSalidaDesde
        '
        Me.dtFechaSalidaDesde.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtFechaSalidaDesde.Enabled = False
        Me.dtFechaSalidaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaSalidaDesde.Location = New System.Drawing.Point(3, 3)
        Me.dtFechaSalidaDesde.Name = "dtFechaSalidaDesde"
        Me.dtFechaSalidaDesde.Size = New System.Drawing.Size(110, 21)
        Me.dtFechaSalidaDesde.TabIndex = 19
        '
        'txtImporteDesde
        '
        Me.txtImporteDesde.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtImporteDesde.Location = New System.Drawing.Point(3, 3)
        Me.txtImporteDesde.Name = "txtImporteDesde"
        Me.txtImporteDesde.Size = New System.Drawing.Size(120, 21)
        Me.txtImporteDesde.TabIndex = 12
        '
        'dtFechaVencimientoDesde
        '
        Me.dtFechaVencimientoDesde.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtFechaVencimientoDesde.Enabled = False
        Me.dtFechaVencimientoDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaVencimientoDesde.Location = New System.Drawing.Point(3, 3)
        Me.dtFechaVencimientoDesde.Name = "dtFechaVencimientoDesde"
        Me.dtFechaVencimientoDesde.Size = New System.Drawing.Size(110, 21)
        Me.dtFechaVencimientoDesde.TabIndex = 16
        '
        'txtNumero
        '
        Me.txtNumero.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNumero.Location = New System.Drawing.Point(681, 36)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(272, 21)
        Me.txtNumero.TabIndex = 14
        '
        'cmbBancoEmisor
        '
        Me.cmbBancoEmisor.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbBancoEmisor.DataSource = Me.BancoBindingSource
        Me.cmbBancoEmisor.DisplayMember = "Nombre"
        Me.cmbBancoEmisor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBancoEmisor.FormattingEnabled = True
        Me.cmbBancoEmisor.Location = New System.Drawing.Point(681, 65)
        Me.cmbBancoEmisor.Name = "cmbBancoEmisor"
        Me.cmbBancoEmisor.Size = New System.Drawing.Size(272, 23)
        Me.cmbBancoEmisor.TabIndex = 15
        Me.cmbBancoEmisor.ValueMember = "BancoId"
        '
        'BancoBindingSource
        '
        Me.BancoBindingSource.DataSource = GetType(Entidades.Banco)
        '
        'btn_Restablecer
        '
        Me.btn_Restablecer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Restablecer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Restablecer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Restablecer.Location = New System.Drawing.Point(757, 223)
        Me.btn_Restablecer.Name = "btn_Restablecer"
        Me.btn_Restablecer.Size = New System.Drawing.Size(100, 40)
        Me.btn_Restablecer.TabIndex = 22
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
        Me.BtnFiltrar.Location = New System.Drawing.Point(863, 223)
        Me.BtnFiltrar.Name = "BtnFiltrar"
        Me.BtnFiltrar.Size = New System.Drawing.Size(100, 40)
        Me.BtnFiltrar.TabIndex = 23
        Me.BtnFiltrar.Text = "Buscar"
        Me.BtnFiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnFiltrar.UseVisualStyleBackColor = True
        '
        'dgvCheques
        '
        Me.dgvCheques.AllowUserToAddRows = False
        Me.dgvCheques.AllowUserToDeleteRows = False
        Me.dgvCheques.AllowUserToResizeColumns = False
        Me.dgvCheques.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvCheques.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCheques.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCheques.AutoGenerateColumns = False
        Me.dgvCheques.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCheques.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdChequeDataGridViewTextBoxColumn, Me.NumeroOrdenDataGridViewTextBoxColumn, Me.MarcaFacturado, Me.ClienteNombreDataGridViewTextBoxColumn, Me.LibradorNombreDataGridViewTextBoxColumn, Me.Banco, Me.NumeroChequeDataGridViewTextBoxColumn, Me.ImporteDataGridViewTextBoxColumn, Me.FechaIngresoDataGridViewTextBoxColumn, Me.FechaDespositoDataGridViewTextBoxColumn, Me.FechaVencimientoDataGridViewTextBoxColumn, Me.FechaSalidaDataGridViewTextBoxColumn, Me.Estado, Me.DestinoSalida})
        Me.dgvCheques.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvCheques.DataSource = Me.ChequeBindingSource
        Me.dgvCheques.Location = New System.Drawing.Point(8, 278)
        Me.dgvCheques.MultiSelect = False
        Me.dgvCheques.Name = "dgvCheques"
        Me.dgvCheques.ReadOnly = True
        Me.dgvCheques.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCheques.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvCheques.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvCheques.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCheques.Size = New System.Drawing.Size(960, 406)
        Me.dgvCheques.TabIndex = 24
        '
        'ChequeBindingSource
        '
        Me.ChequeBindingSource.DataSource = GetType(Entidades.Cheque)
        '
        'DetalleTab
        '
        Me.DetalleTab.Controls.Add(Me.GroupBox2)
        Me.DetalleTab.Controls.Add(Me.Label25)
        Me.DetalleTab.Controls.Add(Me.GroupBox)
        Me.DetalleTab.Location = New System.Drawing.Point(4, 29)
        Me.DetalleTab.Name = "DetalleTab"
        Me.DetalleTab.Padding = New System.Windows.Forms.Padding(3)
        Me.DetalleTab.Size = New System.Drawing.Size(976, 729)
        Me.DetalleTab.TabIndex = 1
        Me.DetalleTab.Text = "Detalle del Cheques"
        Me.DetalleTab.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.DetalleSalida)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.cmbDestinoSalida)
        Me.GroupBox2.Controls.Add(Me.Btn_Salida)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(8, 523)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(960, 185)
        Me.GroupBox2.TabIndex = 92
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Información de salida"
        '
        'DetalleSalida
        '
        Me.DetalleSalida.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DetalleSalida.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DetalleSalida.Location = New System.Drawing.Point(128, 56)
        Me.DetalleSalida.Multiline = True
        Me.DetalleSalida.Name = "DetalleSalida"
        Me.DetalleSalida.Size = New System.Drawing.Size(736, 75)
        Me.DetalleSalida.TabIndex = 165
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(6, 56)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(72, 13)
        Me.Label22.TabIndex = 166
        Me.Label22.Text = "Detalle Salida"
        '
        'cmbDestinoSalida
        '
        Me.cmbDestinoSalida.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbDestinoSalida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDestinoSalida.FormattingEnabled = True
        Me.cmbDestinoSalida.Location = New System.Drawing.Point(128, 23)
        Me.cmbDestinoSalida.Name = "cmbDestinoSalida"
        Me.cmbDestinoSalida.Size = New System.Drawing.Size(736, 21)
        Me.cmbDestinoSalida.TabIndex = 9
        '
        'Btn_Salida
        '
        Me.Btn_Salida.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Salida.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Salida.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Salida.Image = Global.SistemaCinderella.My.Resources.Recursos.Ingreso_32
        Me.Btn_Salida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Salida.Location = New System.Drawing.Point(854, 139)
        Me.Btn_Salida.Name = "Btn_Salida"
        Me.Btn_Salida.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Salida.TabIndex = 88
        Me.Btn_Salida.Text = "Salida"
        Me.Btn_Salida.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Salida.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 26)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(88, 13)
        Me.Label16.TabIndex = 82
        Me.Label16.Text = "Destino Salida (*)"
        '
        'Label25
        '
        Me.Label25.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(3, 711)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(117, 13)
        Me.Label25.TabIndex = 91
        Me.Label25.Text = "(*) Campos obligatorios."
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Cancelar.Image = Global.SistemaCinderella.My.Resources.Recursos.desconectado_32
        Me.Btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Cancelar.Location = New System.Drawing.Point(748, 465)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Cancelar.TabIndex = 90
        Me.Btn_Cancelar.Text = "Cancelar"
        Me.Btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Cancelar.UseVisualStyleBackColor = True
        '
        'GroupBox
        '
        Me.GroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox.Controls.Add(Me.Label32)
        Me.GroupBox.Controls.Add(Me.EstadoDetalle)
        Me.GroupBox.Controls.Add(Me.Btn_Cancelar)
        Me.GroupBox.Controls.Add(Me.BancoEmisor)
        Me.GroupBox.Controls.Add(Me.Label30)
        Me.GroupBox.Controls.Add(Me.DetalleFechaSalida)
        Me.GroupBox.Controls.Add(Me.Label21)
        Me.GroupBox.Controls.Add(Me.btn_Modificar)
        Me.GroupBox.Controls.Add(Me.Btn_Buscar_Librador)
        Me.GroupBox.Controls.Add(Me.chkDetalleMarcaFacturado)
        Me.GroupBox.Controls.Add(Me.LibradorID)
        Me.GroupBox.Controls.Add(Me.ClienteID)
        Me.GroupBox.Controls.Add(Me.FechaIngreso)
        Me.GroupBox.Controls.Add(Me.Label9)
        Me.GroupBox.Controls.Add(Me.Label10)
        Me.GroupBox.Controls.Add(Me.Btn_Agregar_Banco)
        Me.GroupBox.Controls.Add(Me.Importe)
        Me.GroupBox.Controls.Add(Me.NumeroOrden)
        Me.GroupBox.Controls.Add(Me.Btn_Buscar_Cliente)
        Me.GroupBox.Controls.Add(Me.Label13)
        Me.GroupBox.Controls.Add(Me.Label14)
        Me.GroupBox.Controls.Add(Me.ClienteNombre)
        Me.GroupBox.Controls.Add(Me.FechaDeposito)
        Me.GroupBox.Controls.Add(Me.Label15)
        Me.GroupBox.Controls.Add(Me.FechaVencimiento)
        Me.GroupBox.Controls.Add(Me.LibradorNombre)
        Me.GroupBox.Controls.Add(Me.Label17)
        Me.GroupBox.Controls.Add(Me.Label18)
        Me.GroupBox.Controls.Add(Me.NumeroCheque)
        Me.GroupBox.Controls.Add(Me.Label19)
        Me.GroupBox.Controls.Add(Me.Label20)
        Me.GroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(960, 511)
        Me.GroupBox.TabIndex = 35
        Me.GroupBox.TabStop = False
        Me.GroupBox.Text = "Información del cheque"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(6, 26)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(45, 15)
        Me.Label32.TabIndex = 170
        Me.Label32.Text = "Estado"
        '
        'EstadoDetalle
        '
        Me.EstadoDetalle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EstadoDetalle.Location = New System.Drawing.Point(184, 21)
        Me.EstadoDetalle.Name = "EstadoDetalle"
        Me.EstadoDetalle.ReadOnly = True
        Me.EstadoDetalle.Size = New System.Drawing.Size(680, 21)
        Me.EstadoDetalle.TabIndex = 171
        '
        'BancoEmisor
        '
        Me.BancoEmisor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BancoEmisor.DataSource = Me.DetalleBancoBindingSource
        Me.BancoEmisor.DisplayMember = "Nombre"
        Me.BancoEmisor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BancoEmisor.FormattingEnabled = True
        Me.BancoEmisor.Location = New System.Drawing.Point(184, 234)
        Me.BancoEmisor.Name = "BancoEmisor"
        Me.BancoEmisor.Size = New System.Drawing.Size(680, 23)
        Me.BancoEmisor.TabIndex = 168
        Me.BancoEmisor.ValueMember = "BancoId"
        '
        'DetalleBancoBindingSource
        '
        Me.DetalleBancoBindingSource.DataSource = GetType(Entidades.Banco)
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(6, 242)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(100, 15)
        Me.Label30.TabIndex = 169
        Me.Label30.Text = "Banco Emisor (*)"
        '
        'DetalleFechaSalida
        '
        Me.DetalleFechaSalida.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DetalleFechaSalida.Location = New System.Drawing.Point(184, 432)
        Me.DetalleFechaSalida.Name = "DetalleFechaSalida"
        Me.DetalleFechaSalida.ReadOnly = True
        Me.DetalleFechaSalida.Size = New System.Drawing.Size(680, 21)
        Me.DetalleFechaSalida.TabIndex = 167
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(6, 435)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(82, 15)
        Me.Label21.TabIndex = 164
        Me.Label21.Text = "Fecha Salida "
        '
        'btn_Modificar
        '
        Me.btn_Modificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Modificar.BackColor = System.Drawing.Color.Transparent
        Me.btn_Modificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Modificar.Image = Global.SistemaCinderella.My.Resources.Recursos.Editar_24
        Me.btn_Modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Modificar.Location = New System.Drawing.Point(854, 465)
        Me.btn_Modificar.Name = "btn_Modificar"
        Me.btn_Modificar.Size = New System.Drawing.Size(100, 40)
        Me.btn_Modificar.TabIndex = 89
        Me.btn_Modificar.Text = "Modificar"
        Me.btn_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Modificar.UseVisualStyleBackColor = False
        '
        'Btn_Buscar_Librador
        '
        Me.Btn_Buscar_Librador.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Btn_Buscar_Librador.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Buscar_Librador.Image = Global.SistemaCinderella.My.Resources.Recursos.IconoBuscar24
        Me.Btn_Buscar_Librador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Buscar_Librador.Location = New System.Drawing.Point(873, 192)
        Me.Btn_Buscar_Librador.Name = "Btn_Buscar_Librador"
        Me.Btn_Buscar_Librador.Size = New System.Drawing.Size(81, 31)
        Me.Btn_Buscar_Librador.TabIndex = 8
        Me.Btn_Buscar_Librador.Text = "Buscar"
        Me.Btn_Buscar_Librador.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Buscar_Librador.UseVisualStyleBackColor = True
        '
        'chkDetalleMarcaFacturado
        '
        Me.chkDetalleMarcaFacturado.AutoSize = True
        Me.chkDetalleMarcaFacturado.Enabled = False
        Me.chkDetalleMarcaFacturado.Location = New System.Drawing.Point(184, 93)
        Me.chkDetalleMarcaFacturado.Name = "chkDetalleMarcaFacturado"
        Me.chkDetalleMarcaFacturado.Size = New System.Drawing.Size(15, 14)
        Me.chkDetalleMarcaFacturado.TabIndex = 1
        Me.chkDetalleMarcaFacturado.UseVisualStyleBackColor = True
        '
        'LibradorID
        '
        Me.LibradorID.Location = New System.Drawing.Point(184, 198)
        Me.LibradorID.Name = "LibradorID"
        Me.LibradorID.Size = New System.Drawing.Size(206, 21)
        Me.LibradorID.TabIndex = 6
        '
        'ClienteID
        '
        Me.ClienteID.Location = New System.Drawing.Point(184, 162)
        Me.ClienteID.Name = "ClienteID"
        Me.ClienteID.Size = New System.Drawing.Size(206, 21)
        Me.ClienteID.TabIndex = 3
        '
        'FechaIngreso
        '
        Me.FechaIngreso.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FechaIngreso.Location = New System.Drawing.Point(184, 126)
        Me.FechaIngreso.Name = "FechaIngreso"
        Me.FechaIngreso.ReadOnly = True
        Me.FechaIngreso.Size = New System.Drawing.Size(680, 21)
        Me.FechaIngreso.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 61)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 15)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "N° Orden"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 319)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 15)
        Me.Label10.TabIndex = 162
        Me.Label10.Text = "Importe (*)"
        '
        'Btn_Agregar_Banco
        '
        Me.Btn_Agregar_Banco.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Btn_Agregar_Banco.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Agregar_Banco.Image = Global.SistemaCinderella.My.Resources.Recursos.banco
        Me.Btn_Agregar_Banco.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Agregar_Banco.Location = New System.Drawing.Point(873, 229)
        Me.Btn_Agregar_Banco.Name = "Btn_Agregar_Banco"
        Me.Btn_Agregar_Banco.Size = New System.Drawing.Size(81, 31)
        Me.Btn_Agregar_Banco.TabIndex = 10
        Me.Btn_Agregar_Banco.Text = "Agregar"
        Me.Btn_Agregar_Banco.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Agregar_Banco.UseVisualStyleBackColor = True
        '
        'Importe
        '
        Me.Importe.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Importe.Location = New System.Drawing.Point(184, 314)
        Me.Importe.Name = "Importe"
        Me.Importe.Size = New System.Drawing.Size(680, 21)
        Me.Importe.TabIndex = 12
        '
        'NumeroOrden
        '
        Me.NumeroOrden.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumeroOrden.Location = New System.Drawing.Point(184, 56)
        Me.NumeroOrden.Name = "NumeroOrden"
        Me.NumeroOrden.ReadOnly = True
        Me.NumeroOrden.Size = New System.Drawing.Size(680, 21)
        Me.NumeroOrden.TabIndex = 0
        '
        'Btn_Buscar_Cliente
        '
        Me.Btn_Buscar_Cliente.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Btn_Buscar_Cliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Buscar_Cliente.Image = Global.SistemaCinderella.My.Resources.Recursos.IconoBuscar24
        Me.Btn_Buscar_Cliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Buscar_Cliente.Location = New System.Drawing.Point(873, 157)
        Me.Btn_Buscar_Cliente.Name = "Btn_Buscar_Cliente"
        Me.Btn_Buscar_Cliente.Size = New System.Drawing.Size(81, 31)
        Me.Btn_Buscar_Cliente.TabIndex = 5
        Me.Btn_Buscar_Cliente.Text = "Buscar"
        Me.Btn_Buscar_Cliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Buscar_Cliente.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 131)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(85, 15)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Fecha Ingreso"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 167)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(61, 15)
        Me.Label14.TabIndex = 42
        Me.Label14.Text = "Cliente (*)"
        '
        'ClienteNombre
        '
        Me.ClienteNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClienteNombre.Location = New System.Drawing.Point(396, 162)
        Me.ClienteNombre.Name = "ClienteNombre"
        Me.ClienteNombre.Size = New System.Drawing.Size(468, 21)
        Me.ClienteNombre.TabIndex = 4
        '
        'FechaDeposito
        '
        Me.FechaDeposito.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FechaDeposito.Location = New System.Drawing.Point(184, 352)
        Me.FechaDeposito.Name = "FechaDeposito"
        Me.FechaDeposito.Size = New System.Drawing.Size(680, 21)
        Me.FechaDeposito.TabIndex = 13
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 204)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(69, 15)
        Me.Label15.TabIndex = 62
        Me.Label15.Text = "Librador (*)"
        '
        'FechaVencimiento
        '
        Me.FechaVencimiento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FechaVencimiento.Location = New System.Drawing.Point(184, 391)
        Me.FechaVencimiento.Name = "FechaVencimiento"
        Me.FechaVencimiento.Size = New System.Drawing.Size(680, 21)
        Me.FechaVencimiento.TabIndex = 14
        '
        'LibradorNombre
        '
        Me.LibradorNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LibradorNombre.Location = New System.Drawing.Point(396, 199)
        Me.LibradorNombre.Name = "LibradorNombre"
        Me.LibradorNombre.Size = New System.Drawing.Size(468, 21)
        Me.LibradorNombre.TabIndex = 7
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 280)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(83, 15)
        Me.Label17.TabIndex = 102
        Me.Label17.Text = "N° Cheque (*)"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 97)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(100, 15)
        Me.Label18.TabIndex = 22
        Me.Label18.Text = "Marca Facturado"
        '
        'NumeroCheque
        '
        Me.NumeroCheque.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumeroCheque.Location = New System.Drawing.Point(184, 275)
        Me.NumeroCheque.Name = "NumeroCheque"
        Me.NumeroCheque.Size = New System.Drawing.Size(680, 21)
        Me.NumeroCheque.TabIndex = 11
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(6, 357)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(109, 15)
        Me.Label19.TabIndex = 122
        Me.Label19.Text = "Fecha Deposito (*)"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 396)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(128, 15)
        Me.Label20.TabIndex = 142
        Me.Label20.Text = "Fecha Vencimiento (*)"
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel7.ColumnCount = 4
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.dtFechaVencimientoDesde, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.Label27, 1, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.dtFechaVencimientoHasta, 2, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.chkFechaVencimiento, 3, 0)
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(681, 95)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(272, 24)
        Me.TableLayoutPanel7.TabIndex = 418
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel8.ColumnCount = 4
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.dtFechaSalidaDesde, 0, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.Label28, 1, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.dtFechaSalidaHasta, 2, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.chkFechaSalida, 3, 0)
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(681, 125)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 1
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(272, 24)
        Me.TableLayoutPanel8.TabIndex = 418
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
        Me.TableLayoutPanel9.Location = New System.Drawing.Point(681, 3)
        Me.TableLayoutPanel9.Name = "TableLayoutPanel9"
        Me.TableLayoutPanel9.RowCount = 1
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel9.Size = New System.Drawing.Size(272, 26)
        Me.TableLayoutPanel9.TabIndex = 418
        '
        'IdChequeDataGridViewTextBoxColumn
        '
        Me.IdChequeDataGridViewTextBoxColumn.DataPropertyName = "IdCheque"
        Me.IdChequeDataGridViewTextBoxColumn.HeaderText = "IdCheque"
        Me.IdChequeDataGridViewTextBoxColumn.Name = "IdChequeDataGridViewTextBoxColumn"
        Me.IdChequeDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdChequeDataGridViewTextBoxColumn.Visible = False
        Me.IdChequeDataGridViewTextBoxColumn.Width = 5
        '
        'NumeroOrdenDataGridViewTextBoxColumn
        '
        Me.NumeroOrdenDataGridViewTextBoxColumn.DataPropertyName = "NumeroOrden"
        Me.NumeroOrdenDataGridViewTextBoxColumn.FillWeight = 19.58897!
        Me.NumeroOrdenDataGridViewTextBoxColumn.HeaderText = "Orden"
        Me.NumeroOrdenDataGridViewTextBoxColumn.Name = "NumeroOrdenDataGridViewTextBoxColumn"
        Me.NumeroOrdenDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumeroOrdenDataGridViewTextBoxColumn.Width = 65
        '
        'MarcaFacturado
        '
        Me.MarcaFacturado.DataPropertyName = "MarcaFacturado"
        Me.MarcaFacturado.FillWeight = 19.52634!
        Me.MarcaFacturado.HeaderText = "Marca Fact."
        Me.MarcaFacturado.Name = "MarcaFacturado"
        Me.MarcaFacturado.ReadOnly = True
        Me.MarcaFacturado.Width = 65
        '
        'ClienteNombreDataGridViewTextBoxColumn
        '
        Me.ClienteNombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ClienteNombreDataGridViewTextBoxColumn.DataPropertyName = "ClienteNombre"
        Me.ClienteNombreDataGridViewTextBoxColumn.FillWeight = 35.63578!
        Me.ClienteNombreDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.ClienteNombreDataGridViewTextBoxColumn.Name = "ClienteNombreDataGridViewTextBoxColumn"
        Me.ClienteNombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LibradorNombreDataGridViewTextBoxColumn
        '
        Me.LibradorNombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.LibradorNombreDataGridViewTextBoxColumn.DataPropertyName = "LibradorNombre"
        Me.LibradorNombreDataGridViewTextBoxColumn.FillWeight = 38.51844!
        Me.LibradorNombreDataGridViewTextBoxColumn.HeaderText = "Librador"
        Me.LibradorNombreDataGridViewTextBoxColumn.Name = "LibradorNombreDataGridViewTextBoxColumn"
        Me.LibradorNombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Banco
        '
        Me.Banco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Banco.DataPropertyName = "BancoEmisorId"
        Me.Banco.DataSource = Me.BancoBindingSource
        Me.Banco.DisplayMember = "Nombre"
        Me.Banco.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.Banco.FillWeight = 41.91894!
        Me.Banco.HeaderText = "Banco"
        Me.Banco.Name = "Banco"
        Me.Banco.ReadOnly = True
        Me.Banco.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Banco.ValueMember = "BancoId"
        '
        'NumeroChequeDataGridViewTextBoxColumn
        '
        Me.NumeroChequeDataGridViewTextBoxColumn.DataPropertyName = "NumeroCheque"
        Me.NumeroChequeDataGridViewTextBoxColumn.FillWeight = 19.58897!
        Me.NumeroChequeDataGridViewTextBoxColumn.HeaderText = "Ch. Nro."
        Me.NumeroChequeDataGridViewTextBoxColumn.Name = "NumeroChequeDataGridViewTextBoxColumn"
        Me.NumeroChequeDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumeroChequeDataGridViewTextBoxColumn.Width = 75
        '
        'ImporteDataGridViewTextBoxColumn
        '
        Me.ImporteDataGridViewTextBoxColumn.DataPropertyName = "Importe"
        Me.ImporteDataGridViewTextBoxColumn.FillWeight = 19.58897!
        Me.ImporteDataGridViewTextBoxColumn.HeaderText = "Monto"
        Me.ImporteDataGridViewTextBoxColumn.Name = "ImporteDataGridViewTextBoxColumn"
        Me.ImporteDataGridViewTextBoxColumn.ReadOnly = True
        Me.ImporteDataGridViewTextBoxColumn.Width = 65
        '
        'FechaIngresoDataGridViewTextBoxColumn
        '
        Me.FechaIngresoDataGridViewTextBoxColumn.DataPropertyName = "FechaIngreso"
        Me.FechaIngresoDataGridViewTextBoxColumn.FillWeight = 19.58897!
        Me.FechaIngresoDataGridViewTextBoxColumn.HeaderText = "F. Ingreso"
        Me.FechaIngresoDataGridViewTextBoxColumn.Name = "FechaIngresoDataGridViewTextBoxColumn"
        Me.FechaIngresoDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaIngresoDataGridViewTextBoxColumn.Width = 80
        '
        'FechaDespositoDataGridViewTextBoxColumn
        '
        Me.FechaDespositoDataGridViewTextBoxColumn.DataPropertyName = "FechaDesposito"
        Me.FechaDespositoDataGridViewTextBoxColumn.FillWeight = 176.5132!
        Me.FechaDespositoDataGridViewTextBoxColumn.HeaderText = "F. Depósito"
        Me.FechaDespositoDataGridViewTextBoxColumn.Name = "FechaDespositoDataGridViewTextBoxColumn"
        Me.FechaDespositoDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaDespositoDataGridViewTextBoxColumn.Width = 90
        '
        'FechaVencimientoDataGridViewTextBoxColumn
        '
        Me.FechaVencimientoDataGridViewTextBoxColumn.DataPropertyName = "FechaVencimiento"
        Me.FechaVencimientoDataGridViewTextBoxColumn.FillWeight = 357.4712!
        Me.FechaVencimientoDataGridViewTextBoxColumn.HeaderText = "F. Vto."
        Me.FechaVencimientoDataGridViewTextBoxColumn.Name = "FechaVencimientoDataGridViewTextBoxColumn"
        Me.FechaVencimientoDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaVencimientoDataGridViewTextBoxColumn.Width = 70
        '
        'FechaSalidaDataGridViewTextBoxColumn
        '
        Me.FechaSalidaDataGridViewTextBoxColumn.DataPropertyName = "FechaSalida"
        Me.FechaSalidaDataGridViewTextBoxColumn.FillWeight = 368.3036!
        Me.FechaSalidaDataGridViewTextBoxColumn.HeaderText = "F. Salida"
        Me.FechaSalidaDataGridViewTextBoxColumn.Name = "FechaSalidaDataGridViewTextBoxColumn"
        Me.FechaSalidaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaSalidaDataGridViewTextBoxColumn.Width = 75
        '
        'Estado
        '
        Me.Estado.DataPropertyName = "Estado"
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        Me.Estado.Width = 75
        '
        'DestinoSalida
        '
        Me.DestinoSalida.DataPropertyName = "DestinoSalida"
        Me.DestinoSalida.HeaderText = "Dest. Sali"
        Me.DestinoSalida.Name = "DestinoSalida"
        Me.DestinoSalida.ReadOnly = True
        Me.DestinoSalida.Width = 80
        '
        'frmChequesAdministracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 762)
        Me.Controls.Add(Me.TabCheques)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmChequesAdministracion"
        Me.Text = "Administración de Cheques"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabCheques.ResumeLayout(False)
        Me.BusquedaTab.ResumeLayout(False)
        Me.BusquedaTab.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.BancoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCheques, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChequeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DetalleTab.ResumeLayout(False)
        Me.DetalleTab.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox.ResumeLayout(False)
        Me.GroupBox.PerformLayout()
        CType(Me.DetalleBancoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel7.PerformLayout()
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel8.PerformLayout()
        Me.TableLayoutPanel9.ResumeLayout(False)
        Me.TableLayoutPanel9.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabCheques As System.Windows.Forms.TabControl
    Friend WithEvents BusquedaTab As System.Windows.Forms.TabPage
    Friend WithEvents DetalleTab As System.Windows.Forms.TabPage
    Friend WithEvents dgvCheques As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Restablecer As System.Windows.Forms.Button
    Friend WithEvents BtnFiltrar As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dtFechaDepositoDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFechaIngresoDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtLibradorNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtClienteNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbBancoEmisor As System.Windows.Forms.ComboBox
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chkFechaSalida As System.Windows.Forms.CheckBox
    Friend WithEvents chkFechaVencimiento As System.Windows.Forms.CheckBox
    Friend WithEvents chkFechaDeposito As System.Windows.Forms.CheckBox
    Friend WithEvents chkFechaIngreso As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtFechaSalidaDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtImporteDesde As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtFechaVencimientoDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents BancoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ChequeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents lbl_Msg As System.Windows.Forms.Label
    Friend WithEvents GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_Buscar_Librador As System.Windows.Forms.Button
    Friend WithEvents chkDetalleMarcaFacturado As System.Windows.Forms.CheckBox
    Friend WithEvents LibradorID As System.Windows.Forms.TextBox
    Friend WithEvents ClienteID As System.Windows.Forms.TextBox
    Friend WithEvents FechaIngreso As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Btn_Agregar_Banco As System.Windows.Forms.Button
    Friend WithEvents Importe As System.Windows.Forms.TextBox
    Friend WithEvents NumeroOrden As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Buscar_Cliente As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmbDestinoSalida As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents ClienteNombre As System.Windows.Forms.TextBox
    Friend WithEvents FechaDeposito As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents FechaVencimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents LibradorNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents NumeroCheque As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents DetalleSalida As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents Btn_Salida As System.Windows.Forms.Button
    Friend WithEvents btn_Modificar As System.Windows.Forms.Button
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents DetalleFechaSalida As System.Windows.Forms.TextBox
    Friend WithEvents DetalleBancoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents chkIngresado As System.Windows.Forms.CheckBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents ChkSalido As System.Windows.Forms.CheckBox
    Friend WithEvents ChkReingresado As System.Windows.Forms.CheckBox
    Friend WithEvents dtFechaDepositoHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents dtFechaIngresoHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFechaSalidaHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents dtFechaVencimientoHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtImporteHasta As System.Windows.Forms.TextBox
    Friend WithEvents ChkMarcaFacturadoNo As System.Windows.Forms.CheckBox
    Friend WithEvents ChkMarcaFacturadoSi As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BancoEmisor As System.Windows.Forms.ComboBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents chkPasado As System.Windows.Forms.CheckBox
    Friend WithEvents chkDepositado As System.Windows.Forms.CheckBox
    Friend WithEvents chkSinSalida As System.Windows.Forms.CheckBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents btn_Exportar As System.Windows.Forms.Button
    Friend WithEvents chkOtros As System.Windows.Forms.CheckBox
    Friend WithEvents chkDevuelto As System.Windows.Forms.CheckBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents EstadoDetalle As System.Windows.Forms.TextBox
    Friend WithEvents lbl_TotalCartera As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents lbl_TotalPantalla As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents IdChequeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumeroOrdenDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MarcaFacturado As DataGridViewTextBoxColumn
    Friend WithEvents ClienteNombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LibradorNombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Banco As DataGridViewComboBoxColumn
    Friend WithEvents NumeroChequeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImporteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaIngresoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDespositoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaVencimientoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaSalidaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents DestinoSalida As DataGridViewTextBoxColumn
End Class
