Imports SistemaCinderella.Formularios.Reserva

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReservaAdministracion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReservaAdministracion))
        Me.tabAdministracionReservas = New System.Windows.Forms.TabControl()
        Me.tabAdministracion = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.dpkRetiro = New System.Windows.Forms.DateTimePicker()
        Me.FrmReservaAdministracionViewModelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.chkFRetiro = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.dpkAlta = New System.Windows.Forms.DateTimePicker()
        Me.chkFAlta = New System.Windows.Forms.CheckBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtNombreFiltro = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.cmbModoEntrega = New System.Windows.Forms.ComboBox()
        Me.MetodoEntregaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btn_Restablecer = New System.Windows.Forms.Button()
        Me.BtnFiltrar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbl_Msg = New System.Windows.Forms.Label()
        Me.dgReservas = New System.Windows.Forms.DataGridView()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoReservaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaAltaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaEstimadaRetiroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MetodoEntregaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReservaImprimir = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ReservaEliminar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ReservasDetallesItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tabDetalle = New System.Windows.Forms.TabPage()
        Me.ReservaDetalle1 = New SistemaCinderella.ReservaDetalle()
        Me.btnRetirar = New System.Windows.Forms.Button()
        Me.tabAdministracionReservas.SuspendLayout()
        Me.tabAdministracion.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.FrmReservaAdministracionViewModelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.MetodoEntregaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgReservas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservasDetallesItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDetalle.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabAdministracionReservas
        '
        Me.tabAdministracionReservas.Controls.Add(Me.tabAdministracion)
        Me.tabAdministracionReservas.Controls.Add(Me.tabDetalle)
        Me.tabAdministracionReservas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabAdministracionReservas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tabAdministracionReservas.Location = New System.Drawing.Point(0, 0)
        Me.tabAdministracionReservas.Name = "tabAdministracionReservas"
        Me.tabAdministracionReservas.SelectedIndex = 0
        Me.tabAdministracionReservas.Size = New System.Drawing.Size(884, 761)
        Me.tabAdministracionReservas.TabIndex = 0
        '
        'tabAdministracion
        '
        Me.tabAdministracion.Controls.Add(Me.TableLayoutPanel1)
        Me.tabAdministracion.Location = New System.Drawing.Point(4, 29)
        Me.tabAdministracion.Name = "tabAdministracion"
        Me.tabAdministracion.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAdministracion.Size = New System.Drawing.Size(876, 728)
        Me.tabAdministracion.TabIndex = 0
        Me.tabAdministracion.Text = "Reserva"
        Me.tabAdministracion.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox2, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 136.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(870, 722)
        Me.TableLayoutPanel1.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox1.Controls.Add(Me.btn_Restablecer)
        Me.GroupBox1.Controls.Add(Me.BtnFiltrar)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(864, 130)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtrar reservas"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 5
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel4, 4, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label13, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtNombreFiltro, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label33, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.cmbModoEntrega, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label12, 3, 0)
        Me.TableLayoutPanel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(6, 17)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(852, 60)
        Me.TableLayoutPanel2.TabIndex = 429
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.dpkRetiro, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.chkFRetiro, 1, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(609, 33)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(240, 24)
        Me.TableLayoutPanel4.TabIndex = 429
        '
        'dpkRetiro
        '
        Me.dpkRetiro.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dpkRetiro.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FrmReservaAdministracionViewModelBindingSource, "FechaRetiro", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "D"))
        Me.dpkRetiro.Location = New System.Drawing.Point(3, 3)
        Me.dpkRetiro.Name = "dpkRetiro"
        Me.dpkRetiro.Size = New System.Drawing.Size(214, 21)
        Me.dpkRetiro.TabIndex = 6
        '
        'FrmReservaAdministracionViewModelBindingSource
        '
        Me.FrmReservaAdministracionViewModelBindingSource.DataSource = GetType(SistemaCinderella.Formularios.Reserva.frmReservaAdministracionViewModel)
        '
        'chkFRetiro
        '
        Me.chkFRetiro.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkFRetiro.AutoSize = True
        Me.chkFRetiro.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.FrmReservaAdministracionViewModelBindingSource, "FechaRetiroSeleccionada", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.chkFRetiro.Location = New System.Drawing.Point(223, 5)
        Me.chkFRetiro.Name = "chkFRetiro"
        Me.chkFRetiro.Size = New System.Drawing.Size(14, 14)
        Me.chkFRetiro.TabIndex = 428
        Me.chkFRetiro.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.dpkAlta, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.chkFAlta, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(609, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(240, 24)
        Me.TableLayoutPanel3.TabIndex = 429
        '
        'dpkAlta
        '
        Me.dpkAlta.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dpkAlta.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FrmReservaAdministracionViewModelBindingSource, "FechaAlta", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "D"))
        Me.dpkAlta.Location = New System.Drawing.Point(3, 3)
        Me.dpkAlta.Name = "dpkAlta"
        Me.dpkAlta.Size = New System.Drawing.Size(214, 21)
        Me.dpkAlta.TabIndex = 4
        '
        'chkFAlta
        '
        Me.chkFAlta.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkFAlta.AutoSize = True
        Me.chkFAlta.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.FrmReservaAdministracionViewModelBindingSource, "FechaAltaSeleccionada", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.chkFAlta.Location = New System.Drawing.Point(223, 5)
        Me.chkFAlta.Name = "chkFAlta"
        Me.chkFAlta.Size = New System.Drawing.Size(14, 14)
        Me.chkFAlta.TabIndex = 427
        Me.chkFAlta.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(3, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(134, 30)
        Me.Label13.TabIndex = 422
        Me.Label13.Text = "Nombre/R. Social"
        '
        'txtNombreFiltro
        '
        Me.txtNombreFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreFiltro.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmReservaAdministracionViewModelBindingSource, "Nombre", True))
        Me.txtNombreFiltro.Location = New System.Drawing.Point(143, 4)
        Me.txtNombreFiltro.Name = "txtNombreFiltro"
        Me.txtNombreFiltro.Size = New System.Drawing.Size(240, 21)
        Me.txtNombreFiltro.TabIndex = 421
        '
        'Label33
        '
        Me.Label33.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label33.Location = New System.Drawing.Point(3, 37)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(134, 16)
        Me.Label33.TabIndex = 424
        Me.Label33.Text = "Forma de entrega"
        '
        'cmbModoEntrega
        '
        Me.cmbModoEntrega.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbModoEntrega.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.FrmReservaAdministracionViewModelBindingSource, "MetodoEntregaSeleccionado", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cmbModoEntrega.DataSource = Me.MetodoEntregaBindingSource
        Me.cmbModoEntrega.DisplayMember = "Value"
        Me.cmbModoEntrega.FormattingEnabled = True
        Me.cmbModoEntrega.Location = New System.Drawing.Point(143, 34)
        Me.cmbModoEntrega.Name = "cmbModoEntrega"
        Me.cmbModoEntrega.Size = New System.Drawing.Size(240, 23)
        Me.cmbModoEntrega.TabIndex = 423
        Me.cmbModoEntrega.ValueMember = "Key"
        '
        'MetodoEntregaBindingSource
        '
        Me.MetodoEntregaBindingSource.DataMember = "MetodoEntrega"
        Me.MetodoEntregaBindingSource.DataSource = Me.FrmReservaAdministracionViewModelBindingSource
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(469, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Fecha Retiro"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(469, 7)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(134, 16)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Fecha Alta"
        '
        'btn_Restablecer
        '
        Me.btn_Restablecer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Restablecer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Restablecer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Restablecer.Location = New System.Drawing.Point(652, 84)
        Me.btn_Restablecer.Name = "btn_Restablecer"
        Me.btn_Restablecer.Size = New System.Drawing.Size(100, 40)
        Me.btn_Restablecer.TabIndex = 426
        Me.btn_Restablecer.Text = "Restablecer Busqueda"
        Me.btn_Restablecer.UseVisualStyleBackColor = True
        '
        'BtnFiltrar
        '
        Me.BtnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFiltrar.FlatAppearance.BorderSize = 0
        Me.BtnFiltrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFiltrar.Image = Global.SistemaCinderella.My.Resources.Recursos.IconoBuscar32
        Me.BtnFiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnFiltrar.Location = New System.Drawing.Point(758, 84)
        Me.BtnFiltrar.Name = "BtnFiltrar"
        Me.BtnFiltrar.Size = New System.Drawing.Size(100, 40)
        Me.BtnFiltrar.TabIndex = 425
        Me.BtnFiltrar.Text = "Buscar"
        Me.BtnFiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnFiltrar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbl_Msg)
        Me.GroupBox2.Controls.Add(Me.dgReservas)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 139)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(864, 580)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultado"
        '
        'lbl_Msg
        '
        Me.lbl_Msg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Msg.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lbl_Msg.DataBindings.Add(New System.Windows.Forms.Binding("Visible", Me.FrmReservaAdministracionViewModelBindingSource, "SinResultados", True))
        Me.lbl_Msg.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Msg.Location = New System.Drawing.Point(230, 228)
        Me.lbl_Msg.Name = "lbl_Msg"
        Me.lbl_Msg.Size = New System.Drawing.Size(404, 138)
        Me.lbl_Msg.TabIndex = 5
        Me.lbl_Msg.Text = "No se han encontrado Reservas."
        Me.lbl_Msg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgReservas
        '
        Me.dgReservas.AllowUserToAddRows = False
        Me.dgReservas.AllowUserToDeleteRows = False
        Me.dgReservas.AutoGenerateColumns = False
        Me.dgReservas.BackgroundColor = System.Drawing.SystemColors.ControlDark
        Me.dgReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgReservas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NombreDataGridViewTextBoxColumn, Me.MontoTotalDataGridViewTextBoxColumn, Me.MontoReservaDataGridViewTextBoxColumn, Me.FechaAltaDataGridViewTextBoxColumn, Me.FechaEstimadaRetiroDataGridViewTextBoxColumn, Me.MetodoEntregaDataGridViewTextBoxColumn, Me.ReservaImprimir, Me.ReservaEliminar})
        Me.dgReservas.DataSource = Me.ReservasDetallesItemsBindingSource
        Me.dgReservas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgReservas.Location = New System.Drawing.Point(3, 17)
        Me.dgReservas.Name = "dgReservas"
        Me.dgReservas.ReadOnly = True
        Me.dgReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgReservas.Size = New System.Drawing.Size(858, 560)
        Me.dgReservas.TabIndex = 4
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MontoTotalDataGridViewTextBoxColumn
        '
        Me.MontoTotalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MontoTotalDataGridViewTextBoxColumn.DataPropertyName = "MontoTotal"
        Me.MontoTotalDataGridViewTextBoxColumn.HeaderText = "Monto Total"
        Me.MontoTotalDataGridViewTextBoxColumn.Name = "MontoTotalDataGridViewTextBoxColumn"
        Me.MontoTotalDataGridViewTextBoxColumn.ReadOnly = True
        Me.MontoTotalDataGridViewTextBoxColumn.Width = 89
        '
        'MontoReservaDataGridViewTextBoxColumn
        '
        Me.MontoReservaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MontoReservaDataGridViewTextBoxColumn.DataPropertyName = "MontoReserva"
        Me.MontoReservaDataGridViewTextBoxColumn.HeaderText = "Monto Reserva"
        Me.MontoReservaDataGridViewTextBoxColumn.Name = "MontoReservaDataGridViewTextBoxColumn"
        Me.MontoReservaDataGridViewTextBoxColumn.ReadOnly = True
        Me.MontoReservaDataGridViewTextBoxColumn.Width = 105
        '
        'FechaAltaDataGridViewTextBoxColumn
        '
        Me.FechaAltaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FechaAltaDataGridViewTextBoxColumn.DataPropertyName = "FechaAlta"
        Me.FechaAltaDataGridViewTextBoxColumn.HeaderText = "F. Alta"
        Me.FechaAltaDataGridViewTextBoxColumn.Name = "FechaAltaDataGridViewTextBoxColumn"
        Me.FechaAltaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaAltaDataGridViewTextBoxColumn.Width = 60
        '
        'FechaEstimadaRetiroDataGridViewTextBoxColumn
        '
        Me.FechaEstimadaRetiroDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FechaEstimadaRetiroDataGridViewTextBoxColumn.DataPropertyName = "FechaEstimadaRetiro"
        Me.FechaEstimadaRetiroDataGridViewTextBoxColumn.HeaderText = "F. Est. Retiro"
        Me.FechaEstimadaRetiroDataGridViewTextBoxColumn.Name = "FechaEstimadaRetiroDataGridViewTextBoxColumn"
        Me.FechaEstimadaRetiroDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaEstimadaRetiroDataGridViewTextBoxColumn.Width = 93
        '
        'MetodoEntregaDataGridViewTextBoxColumn
        '
        Me.MetodoEntregaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MetodoEntregaDataGridViewTextBoxColumn.DataPropertyName = "MetodoEntrega"
        Me.MetodoEntregaDataGridViewTextBoxColumn.HeaderText = "M. Entrega"
        Me.MetodoEntregaDataGridViewTextBoxColumn.Name = "MetodoEntregaDataGridViewTextBoxColumn"
        Me.MetodoEntregaDataGridViewTextBoxColumn.ReadOnly = True
        Me.MetodoEntregaDataGridViewTextBoxColumn.Width = 85
        '
        'ReservaImprimir
        '
        Me.ReservaImprimir.HeaderText = ""
        Me.ReservaImprimir.Image = Global.SistemaCinderella.My.Resources.Recursos.icono_imprimir
        Me.ReservaImprimir.Name = "ReservaImprimir"
        Me.ReservaImprimir.ReadOnly = True
        Me.ReservaImprimir.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ReservaImprimir.Width = 30
        '
        'ReservaEliminar
        '
        Me.ReservaEliminar.HeaderText = ""
        Me.ReservaEliminar.Image = Global.SistemaCinderella.My.Resources.Recursos.Boton_Eliminar
        Me.ReservaEliminar.Name = "ReservaEliminar"
        Me.ReservaEliminar.ReadOnly = True
        Me.ReservaEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ReservaEliminar.Width = 30
        '
        'ReservasDetallesItemsBindingSource
        '
        Me.ReservasDetallesItemsBindingSource.DataMember = "ReservasDetallesItems"
        Me.ReservasDetallesItemsBindingSource.DataSource = Me.FrmReservaAdministracionViewModelBindingSource
        '
        'tabDetalle
        '
        Me.tabDetalle.Controls.Add(Me.ReservaDetalle1)
        Me.tabDetalle.Controls.Add(Me.btnRetirar)
        Me.tabDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabDetalle.Location = New System.Drawing.Point(4, 29)
        Me.tabDetalle.Name = "tabDetalle"
        Me.tabDetalle.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDetalle.Size = New System.Drawing.Size(876, 728)
        Me.tabDetalle.TabIndex = 1
        Me.tabDetalle.Text = "Detalle de la reserva"
        Me.tabDetalle.UseVisualStyleBackColor = True
        '
        'ReservaDetalle1
        '
        Me.ReservaDetalle1.Location = New System.Drawing.Point(8, 6)
        Me.ReservaDetalle1.Name = "ReservaDetalle1"
        Me.ReservaDetalle1.Size = New System.Drawing.Size(867, 680)
        Me.ReservaDetalle1.TabIndex = 2
        '
        'btnRetirar
        '
        Me.btnRetirar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnRetirar.Image = Global.SistemaCinderella.My.Resources.Recursos.Conectado_32
        Me.btnRetirar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRetirar.Location = New System.Drawing.Point(794, 692)
        Me.btnRetirar.Name = "btnRetirar"
        Me.btnRetirar.Size = New System.Drawing.Size(81, 40)
        Me.btnRetirar.TabIndex = 1
        Me.btnRetirar.Text = "Retirar"
        Me.btnRetirar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRetirar.UseVisualStyleBackColor = True
        '
        'frmReservaAdministracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 761)
        Me.Controls.Add(Me.tabAdministracionReservas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(900, 800)
        Me.MinimumSize = New System.Drawing.Size(900, 800)
        Me.Name = "frmReservaAdministracion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administración de Reservas"
        Me.tabAdministracionReservas.ResumeLayout(False)
        Me.tabAdministracion.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        CType(Me.FrmReservaAdministracionViewModelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.MetodoEntregaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgReservas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservasDetallesItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDetalle.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabAdministracionReservas As TabControl
    Friend WithEvents tabAdministracion As TabPage
    Friend WithEvents tabDetalle As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents dpkRetiro As DateTimePicker
    Friend WithEvents chkFRetiro As CheckBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents dpkAlta As DateTimePicker
    Friend WithEvents chkFAlta As CheckBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtNombreFiltro As TextBox
    Friend WithEvents Label33 As Label
    Friend WithEvents cmbModoEntrega As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents btn_Restablecer As Button
    Friend WithEvents BtnFiltrar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lbl_Msg As Label
    Friend WithEvents dgReservas As DataGridView
    Friend WithEvents btnRetirar As Button
    Friend WithEvents FrmReservaAdministracionViewModelBindingSource As BindingSource
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MontoTotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MontoReservaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaAltaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaEstimadaRetiroDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MetodoEntregaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReservaImprimir As DataGridViewImageColumn
    Friend WithEvents ReservaEliminar As DataGridViewImageColumn
    Friend WithEvents ReservasDetallesItemsBindingSource As BindingSource
    Friend WithEvents MetodoEntregaBindingSource As BindingSource
    Friend WithEvents ReservaDetalle1 As ReservaDetalle
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
