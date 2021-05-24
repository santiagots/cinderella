<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ChequeDetalle
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.LibradorID = New System.Windows.Forms.TextBox()
        Me.ChequeDetalleViewModelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LibradorNombre = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.ClienteID = New System.Windows.Forms.TextBox()
        Me.ClienteNombre = New System.Windows.Forms.TextBox()
        Me.Btn_Buscar_Librador = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_Agregar_Banco = New System.Windows.Forms.Button()
        Me.MarcaFacturado = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Btn_Buscar_Cliente = New System.Windows.Forms.Button()
        Me.Importe = New System.Windows.Forms.TextBox()
        Me.FechaIngreso = New System.Windows.Forms.TextBox()
        Me.FechaVencimiento = New System.Windows.Forms.DateTimePicker()
        Me.FechaDeposito = New System.Windows.Forms.DateTimePicker()
        Me.NumeroOrden = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BancoEmisor = New System.Windows.Forms.ComboBox()
        Me.BancosEmisoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.NumeroCheque = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1.SuspendLayout
        Me.TableLayoutPanel3.SuspendLayout
        CType(Me.ChequeDetalleViewModelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.BancosEmisoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label25, 0, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Btn_Buscar_Librador, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Btn_Agregar_Banco, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.MarcaFacturado, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label12, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Btn_Buscar_Cliente, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Importe, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.FechaIngreso, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.FechaVencimiento, 1, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.FechaDeposito, 1, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.NumeroOrden, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.BancoEmisor, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.NumeroCheque, 1, 6)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 11
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.695652!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.695652!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.695652!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.04348!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.04348!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.04348!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.695652!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.695652!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.695652!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.695652!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(500, 444)
        Me.TableLayoutPanel1.TabIndex = 164
        '
        'Label25
        '
        Me.Label25.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(3, 424)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(134, 13)
        Me.Label25.TabIndex = 165
        Me.Label25.Text = "(*) Campos obligatorios."
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.LibradorID, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.LibradorNombre, 1, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(143, 175)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(264, 30)
        Me.TableLayoutPanel3.TabIndex = 164
        '
        'LibradorID
        '
        Me.LibradorID.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LibradorID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChequeDetalleViewModelBindingSource, "IdLibrador", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "N0"))
        Me.LibradorID.Location = New System.Drawing.Point(3, 5)
        Me.LibradorID.Name = "LibradorID"
        Me.LibradorID.Size = New System.Drawing.Size(73, 20)
        Me.LibradorID.TabIndex = 6
        '
        'ChequeDetalleViewModelBindingSource
        '
        Me.ChequeDetalleViewModelBindingSource.DataSource = GetType(SistemaCinderella.Formularios.Cheque.ChequeDetalleViewModel)
        '
        'LibradorNombre
        '
        Me.LibradorNombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LibradorNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChequeDetalleViewModelBindingSource, "LibradorNombre", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.LibradorNombre.Location = New System.Drawing.Point(82, 5)
        Me.LibradorNombre.Name = "LibradorNombre"
        Me.LibradorNombre.Size = New System.Drawing.Size(179, 20)
        Me.LibradorNombre.TabIndex = 7
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.ClienteID, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.ClienteNombre, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(143, 111)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(264, 49)
        Me.TableLayoutPanel2.TabIndex = 164
        '
        'ClienteID
        '
        Me.ClienteID.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClienteID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChequeDetalleViewModelBindingSource, "IdCliente", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "N0"))
        Me.ClienteID.Location = New System.Drawing.Point(3, 14)
        Me.ClienteID.Name = "ClienteID"
        Me.ClienteID.Size = New System.Drawing.Size(73, 20)
        Me.ClienteID.TabIndex = 3
        '
        'ClienteNombre
        '
        Me.ClienteNombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClienteNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChequeDetalleViewModelBindingSource, "ClienteNombre", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ClienteNombre.Location = New System.Drawing.Point(82, 14)
        Me.ClienteNombre.Name = "ClienteNombre"
        Me.ClienteNombre.Size = New System.Drawing.Size(179, 20)
        Me.ClienteNombre.TabIndex = 4
        '
        'Btn_Buscar_Librador
        '
        Me.Btn_Buscar_Librador.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Btn_Buscar_Librador.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Buscar_Librador.Image = Global.SistemaCinderella.My.Resources.Recursos.IconoBuscar24
        Me.Btn_Buscar_Librador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Buscar_Librador.Location = New System.Drawing.Point(416, 175)
        Me.Btn_Buscar_Librador.Name = "Btn_Buscar_Librador"
        Me.Btn_Buscar_Librador.Size = New System.Drawing.Size(81, 30)
        Me.Btn_Buscar_Librador.TabIndex = 8
        Me.Btn_Buscar_Librador.Text = "Buscar"
        Me.Btn_Buscar_Librador.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Buscar_Librador.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "N° Orden"
        '
        'Btn_Agregar_Banco
        '
        Me.Btn_Agregar_Banco.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btn_Agregar_Banco.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Agregar_Banco.Image = Global.SistemaCinderella.My.Resources.Recursos.banco
        Me.Btn_Agregar_Banco.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Agregar_Banco.Location = New System.Drawing.Point(414, 230)
        Me.Btn_Agregar_Banco.Name = "Btn_Agregar_Banco"
        Me.Btn_Agregar_Banco.Size = New System.Drawing.Size(81, 30)
        Me.Btn_Agregar_Banco.TabIndex = 10
        Me.Btn_Agregar_Banco.Text = "Agregar"
        Me.Btn_Agregar_Banco.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Agregar_Banco.UseVisualStyleBackColor = True
        '
        'MarcaFacturado
        '
        Me.MarcaFacturado.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MarcaFacturado.AutoSize = True
        Me.MarcaFacturado.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.ChequeDetalleViewModelBindingSource, "MarcaFacturado", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.MarcaFacturado.Enabled = False
        Me.MarcaFacturado.Location = New System.Drawing.Point(143, 47)
        Me.MarcaFacturado.Name = "MarcaFacturado"
        Me.MarcaFacturado.Size = New System.Drawing.Size(264, 14)
        Me.MarcaFacturado.TabIndex = 1
        Me.MarcaFacturado.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 47)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(134, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Marca Facturado"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 320)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(134, 13)
        Me.Label12.TabIndex = 162
        Me.Label12.Text = "Importe (*)"
        '
        'Btn_Buscar_Cliente
        '
        Me.Btn_Buscar_Cliente.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Btn_Buscar_Cliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Buscar_Cliente.Image = Global.SistemaCinderella.My.Resources.Recursos.IconoBuscar24
        Me.Btn_Buscar_Cliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Buscar_Cliente.Location = New System.Drawing.Point(416, 120)
        Me.Btn_Buscar_Cliente.Name = "Btn_Buscar_Cliente"
        Me.Btn_Buscar_Cliente.Size = New System.Drawing.Size(81, 30)
        Me.Btn_Buscar_Cliente.TabIndex = 5
        Me.Btn_Buscar_Cliente.Text = "Buscar"
        Me.Btn_Buscar_Cliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Buscar_Cliente.UseVisualStyleBackColor = True
        '
        'Importe
        '
        Me.Importe.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Importe.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChequeDetalleViewModelBindingSource, "Monto", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.Importe.Location = New System.Drawing.Point(143, 317)
        Me.Importe.Name = "Importe"
        Me.Importe.Size = New System.Drawing.Size(264, 20)
        Me.Importe.TabIndex = 12
        '
        'FechaIngreso
        '
        Me.FechaIngreso.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FechaIngreso.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChequeDetalleViewModelBindingSource, "FechaIngreso", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "-", "D"))
        Me.FechaIngreso.Location = New System.Drawing.Point(143, 80)
        Me.FechaIngreso.Name = "FechaIngreso"
        Me.FechaIngreso.ReadOnly = True
        Me.FechaIngreso.Size = New System.Drawing.Size(264, 20)
        Me.FechaIngreso.TabIndex = 2
        '
        'FechaVencimiento
        '
        Me.FechaVencimiento.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FechaVencimiento.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ChequeDetalleViewModelBindingSource, "FechaVencimiento", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "D"))
        Me.FechaVencimiento.Enabled = False
        Me.FechaVencimiento.Location = New System.Drawing.Point(143, 389)
        Me.FechaVencimiento.Name = "FechaVencimiento"
        Me.FechaVencimiento.Size = New System.Drawing.Size(264, 20)
        Me.FechaVencimiento.TabIndex = 14
        '
        'FechaDeposito
        '
        Me.FechaDeposito.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FechaDeposito.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ChequeDetalleViewModelBindingSource, "FechaDesposito", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "D"))
        Me.FechaDeposito.Location = New System.Drawing.Point(143, 353)
        Me.FechaDeposito.Name = "FechaDeposito"
        Me.FechaDeposito.Size = New System.Drawing.Size(264, 20)
        Me.FechaDeposito.TabIndex = 13
        '
        'NumeroOrden
        '
        Me.NumeroOrden.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumeroOrden.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChequeDetalleViewModelBindingSource, "NumeroOrden", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "N0"))
        Me.NumeroOrden.Location = New System.Drawing.Point(143, 8)
        Me.NumeroOrden.Name = "NumeroOrden"
        Me.NumeroOrden.ReadOnly = True
        Me.NumeroOrden.Size = New System.Drawing.Size(264, 20)
        Me.NumeroOrden.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 392)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 13)
        Me.Label5.TabIndex = 142
        Me.Label5.Text = "Fecha Vencimiento (*)"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Fecha Ingreso"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 13)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Cliente (*)"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 356)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 13)
        Me.Label6.TabIndex = 122
        Me.Label6.Text = "Fecha Deposito (*)"
        '
        'BancoEmisor
        '
        Me.BancoEmisor.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BancoEmisor.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.ChequeDetalleViewModelBindingSource, "BancoEmisorSeleccionado", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.BancoEmisor.DataSource = Me.BancosEmisoresBindingSource
        Me.BancoEmisor.DisplayMember = "Value"
        Me.BancoEmisor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BancoEmisor.FormattingEnabled = True
        Me.BancoEmisor.Location = New System.Drawing.Point(143, 235)
        Me.BancoEmisor.Name = "BancoEmisor"
        Me.BancoEmisor.Size = New System.Drawing.Size(264, 21)
        Me.BancoEmisor.TabIndex = 9
        Me.BancoEmisor.ValueMember = "Key"
        '
        'BancosEmisoresBindingSource
        '
        Me.BancosEmisoresBindingSource.DataMember = "BancosEmisores"
        Me.BancosEmisoresBindingSource.DataSource = Me.ChequeDetalleViewModelBindingSource
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 13)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Librador (*)"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 239)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(134, 13)
        Me.Label8.TabIndex = 82
        Me.Label8.Text = "Banco Emisor (*)"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 284)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(134, 13)
        Me.Label7.TabIndex = 102
        Me.Label7.Text = "N° Cheque (*)"
        '
        'NumeroCheque
        '
        Me.NumeroCheque.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumeroCheque.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChequeDetalleViewModelBindingSource, "NumeroCheque", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "N0"))
        Me.NumeroCheque.Location = New System.Drawing.Point(143, 281)
        Me.NumeroCheque.Name = "NumeroCheque"
        Me.NumeroCheque.Size = New System.Drawing.Size(264, 20)
        Me.NumeroCheque.TabIndex = 11
        '
        'ChequeDetalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "ChequeDetalle"
        Me.Size = New System.Drawing.Size(500, 444)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.ChequeDetalleViewModelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.BancosEmisoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents LibradorID As TextBox
    Friend WithEvents LibradorNombre As TextBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents ClienteID As TextBox
    Friend WithEvents ClienteNombre As TextBox
    Friend WithEvents Btn_Buscar_Librador As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_Agregar_Banco As Button
    Friend WithEvents MarcaFacturado As CheckBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Btn_Buscar_Cliente As Button
    Friend WithEvents Importe As TextBox
    Friend WithEvents FechaIngreso As TextBox
    Friend WithEvents FechaVencimiento As DateTimePicker
    Friend WithEvents FechaDeposito As DateTimePicker
    Friend WithEvents NumeroOrden As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BancoEmisor As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents NumeroCheque As TextBox
    Friend WithEvents ChequeDetalleViewModelBindingSource As BindingSource
    Friend WithEvents BancosEmisoresBindingSource As BindingSource
    Friend WithEvents Label25 As Label
End Class
