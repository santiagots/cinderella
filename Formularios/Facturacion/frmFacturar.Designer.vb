<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFacturar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFacturar))
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.FacturarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Cb_TipoFacturacion = New System.Windows.Forms.ComboBox()
        Me.TiposFacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_TotalMinorista = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbl_Fecha = New System.Windows.Forms.Label()
        Me.lbl_CostoFinancieroMinorista = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl_IvaMayorista = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lbl_DescuentoMinorista = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbl_SubtotalMinorista = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_Cuit = New System.Windows.Forms.TextBox()
        Me.txt_Localidad = New System.Windows.Forms.TextBox()
        Me.txt_Direccion = New System.Windows.Forms.TextBox()
        Me.txt_Nombre = New System.Windows.Forms.TextBox()
        Me.Cb_IVA = New System.Windows.Forms.ComboBox()
        Me.CondicionesIVABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txt_FacturaOrigen = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.GB_FacturacionManual = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.QuitarNumeroFactura = New System.Windows.Forms.Button()
        Me.AgregarNumeroFactura = New System.Windows.Forms.Button()
        Me.FacturasList = New System.Windows.Forms.ListBox()
        Me.NumerosfacturasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txt_NumeroFacturaManual = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblError = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnFacturar = New System.Windows.Forms.Button()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.btnNotaCredito = New System.Windows.Forms.Button()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.FacturarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.TiposFacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.CondicionesIVABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.GB_FacturacionManual.SuspendLayout()
        CType(Me.NumerosfacturasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.GroupBox2, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.GroupBox3, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.GroupBox1, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel5, 1, 1)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(12, 12)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(742, 484)
        Me.TableLayoutPanel4.TabIndex = 16
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblEstado)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(365, 52)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Controlador Fiscal"
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturarBindingSource, "EstadoControladorFiscal", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.lblEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.Location = New System.Drawing.Point(68, 21)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(39, 15)
        Me.lblEstado.TabIndex = 1
        Me.lblEstado.Text = "- - - -"
        '
        'FacturarBindingSource
        '
        Me.FacturarBindingSource.DataSource = GetType(SistemaCinderella.Formularios.Facturacion.frmFacturarViewModel)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Estado"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Cb_TipoFacturacion)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(374, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(365, 52)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Factura"
        '
        'Cb_TipoFacturacion
        '
        Me.Cb_TipoFacturacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cb_TipoFacturacion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cb_TipoFacturacion.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.FacturarBindingSource, "TiposFacturaSeleccionada", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Cb_TipoFacturacion.DataSource = Me.TiposFacturaBindingSource
        Me.Cb_TipoFacturacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_TipoFacturacion.FormattingEnabled = True
        Me.Cb_TipoFacturacion.Location = New System.Drawing.Point(114, 18)
        Me.Cb_TipoFacturacion.Name = "Cb_TipoFacturacion"
        Me.Cb_TipoFacturacion.Size = New System.Drawing.Size(245, 21)
        Me.Cb_TipoFacturacion.TabIndex = 7
        '
        'TiposFacturaBindingSource
        '
        Me.TiposFacturaBindingSource.DataMember = "TiposFactura"
        Me.TiposFacturaBindingSource.DataSource = Me.FacturarBindingSource
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(12, 21)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(28, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Tipo"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 62)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(363, 418)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_TotalMinorista, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 0, 12)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_Fecha, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_CostoFinancieroMinorista, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_IvaMayorista, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.Label22, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_DescuentoMinorista, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.Label11, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_SubtotalMinorista, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.Label12, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Label18, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Cuit, 1, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Localidad, 1, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Direccion, 1, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Nombre, 1, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.Cb_IVA, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_FacturaOrigen, 1, 12)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(4, 17)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 13
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.332501!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.3325!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.3325!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.3325!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.3325!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.3325!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.334166!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.334166!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.334166!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.334166!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.334166!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.334166!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(355, 397)
        Me.TableLayoutPanel1.TabIndex = 14
        '
        'lbl_TotalMinorista
        '
        Me.lbl_TotalMinorista.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl_TotalMinorista.AutoSize = True
        Me.lbl_TotalMinorista.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturarBindingSource, "Total", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.lbl_TotalMinorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TotalMinorista.Location = New System.Drawing.Point(143, 162)
        Me.lbl_TotalMinorista.Name = "lbl_TotalMinorista"
        Me.lbl_TotalMinorista.Size = New System.Drawing.Size(73, 16)
        Me.lbl_TotalMinorista.TabIndex = 3
        Me.lbl_TotalMinorista.Text = "$ 120.00.-"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 378)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 13)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Factura Origen (*)"
        '
        'lbl_Fecha
        '
        Me.lbl_Fecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Fecha.AutoSize = True
        Me.lbl_Fecha.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturarBindingSource, "Fecha", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "g"))
        Me.lbl_Fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lbl_Fecha.Location = New System.Drawing.Point(143, 7)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(209, 16)
        Me.lbl_Fecha.TabIndex = 15
        Me.lbl_Fecha.Text = "04/05/2012"
        '
        'lbl_CostoFinancieroMinorista
        '
        Me.lbl_CostoFinancieroMinorista.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl_CostoFinancieroMinorista.AutoSize = True
        Me.lbl_CostoFinancieroMinorista.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturarBindingSource, "CostoFinanciero", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.lbl_CostoFinancieroMinorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CostoFinancieroMinorista.Location = New System.Drawing.Point(143, 100)
        Me.lbl_CostoFinancieroMinorista.Name = "lbl_CostoFinancieroMinorista"
        Me.lbl_CostoFinancieroMinorista.Size = New System.Drawing.Size(73, 16)
        Me.lbl_CostoFinancieroMinorista.TabIndex = 23
        Me.lbl_CostoFinancieroMinorista.Text = "$ 120.00.-"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(4, 9)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(132, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Fecha"
        '
        'lbl_IvaMayorista
        '
        Me.lbl_IvaMayorista.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl_IvaMayorista.AutoSize = True
        Me.lbl_IvaMayorista.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturarBindingSource, "Iva", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.lbl_IvaMayorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_IvaMayorista.Location = New System.Drawing.Point(143, 131)
        Me.lbl_IvaMayorista.Name = "lbl_IvaMayorista"
        Me.lbl_IvaMayorista.Size = New System.Drawing.Size(73, 16)
        Me.lbl_IvaMayorista.TabIndex = 3
        Me.lbl_IvaMayorista.Text = "$ 120.00.-"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 350)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "CUIT (sólo numeros) (*)"
        '
        'Label22
        '
        Me.Label22.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(4, 102)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(86, 13)
        Me.Label22.TabIndex = 22
        Me.Label22.Text = "Costo Financiero"
        '
        'lbl_DescuentoMinorista
        '
        Me.lbl_DescuentoMinorista.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl_DescuentoMinorista.AutoSize = True
        Me.lbl_DescuentoMinorista.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturarBindingSource, "Descuento", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.lbl_DescuentoMinorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DescuentoMinorista.Location = New System.Drawing.Point(143, 69)
        Me.lbl_DescuentoMinorista.Name = "lbl_DescuentoMinorista"
        Me.lbl_DescuentoMinorista.Size = New System.Drawing.Size(73, 16)
        Me.lbl_DescuentoMinorista.TabIndex = 19
        Me.lbl_DescuentoMinorista.Text = "$ 120.00.-"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 319)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Localidad (*)"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(4, 71)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 13)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Descuento"
        '
        'lbl_SubtotalMinorista
        '
        Me.lbl_SubtotalMinorista.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl_SubtotalMinorista.AutoSize = True
        Me.lbl_SubtotalMinorista.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturarBindingSource, "Subtotal", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.lbl_SubtotalMinorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SubtotalMinorista.Location = New System.Drawing.Point(143, 38)
        Me.lbl_SubtotalMinorista.Name = "lbl_SubtotalMinorista"
        Me.lbl_SubtotalMinorista.Size = New System.Drawing.Size(73, 16)
        Me.lbl_SubtotalMinorista.TabIndex = 21
        Me.lbl_SubtotalMinorista.Text = "$ 120.00.-"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 288)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Dirección (*)"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(4, 40)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 13)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Subtotal"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 164)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 257)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nombre y Apellido (*)"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 226)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Condición de IVA (*)"
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(4, 133)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(45, 13)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Iva 21%"
        '
        'txt_Cuit
        '
        Me.txt_Cuit.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Cuit.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturarBindingSource, "CUIT", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "N0"))
        Me.txt_Cuit.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.FacturarBindingSource, "HabilitarDatosCliente", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_Cuit.Location = New System.Drawing.Point(143, 346)
        Me.txt_Cuit.Name = "txt_Cuit"
        Me.txt_Cuit.Size = New System.Drawing.Size(209, 20)
        Me.txt_Cuit.TabIndex = 5
        '
        'txt_Localidad
        '
        Me.txt_Localidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Localidad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturarBindingSource, "Localidad", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_Localidad.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.FacturarBindingSource, "HabilitarDatosCliente", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_Localidad.Location = New System.Drawing.Point(143, 315)
        Me.txt_Localidad.Name = "txt_Localidad"
        Me.txt_Localidad.Size = New System.Drawing.Size(209, 20)
        Me.txt_Localidad.TabIndex = 4
        '
        'txt_Direccion
        '
        Me.txt_Direccion.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Direccion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturarBindingSource, "Direccion", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_Direccion.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.FacturarBindingSource, "HabilitarDatosCliente", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_Direccion.Location = New System.Drawing.Point(143, 284)
        Me.txt_Direccion.Name = "txt_Direccion"
        Me.txt_Direccion.Size = New System.Drawing.Size(209, 20)
        Me.txt_Direccion.TabIndex = 3
        '
        'txt_Nombre
        '
        Me.txt_Nombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Nombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturarBindingSource, "NombreYApellido", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_Nombre.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.FacturarBindingSource, "HabilitarDatosCliente", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_Nombre.Location = New System.Drawing.Point(143, 253)
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.Size = New System.Drawing.Size(209, 20)
        Me.txt_Nombre.TabIndex = 2
        '
        'Cb_IVA
        '
        Me.Cb_IVA.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cb_IVA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cb_IVA.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.FacturarBindingSource, "CondicionesIVASeleccionada", True))
        Me.Cb_IVA.DataSource = Me.CondicionesIVABindingSource
        Me.Cb_IVA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_IVA.FormattingEnabled = True
        Me.Cb_IVA.Location = New System.Drawing.Point(143, 222)
        Me.Cb_IVA.Name = "Cb_IVA"
        Me.Cb_IVA.Size = New System.Drawing.Size(209, 21)
        Me.Cb_IVA.TabIndex = 1
        '
        'CondicionesIVABindingSource
        '
        Me.CondicionesIVABindingSource.DataMember = "CondicionesIVA"
        Me.CondicionesIVABindingSource.DataSource = Me.FacturarBindingSource
        '
        'txt_FacturaOrigen
        '
        Me.txt_FacturaOrigen.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_FacturaOrigen.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.FacturarBindingSource, "HabilitarNotaCredito", True))
        Me.txt_FacturaOrigen.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturarBindingSource, "NumeroFacturaOrigen", True))
        Me.txt_FacturaOrigen.Location = New System.Drawing.Point(143, 375)
        Me.txt_FacturaOrigen.Name = "txt_FacturaOrigen"
        Me.txt_FacturaOrigen.Size = New System.Drawing.Size(209, 20)
        Me.txt_FacturaOrigen.TabIndex = 25
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.GB_FacturacionManual, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.lblError, 0, 1)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(374, 61)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(365, 420)
        Me.TableLayoutPanel5.TabIndex = 3
        '
        'GB_FacturacionManual
        '
        Me.GB_FacturacionManual.Controls.Add(Me.Label14)
        Me.GB_FacturacionManual.Controls.Add(Me.QuitarNumeroFactura)
        Me.GB_FacturacionManual.Controls.Add(Me.AgregarNumeroFactura)
        Me.GB_FacturacionManual.Controls.Add(Me.FacturasList)
        Me.GB_FacturacionManual.Controls.Add(Me.txt_NumeroFacturaManual)
        Me.GB_FacturacionManual.Controls.Add(Me.Label8)
        Me.GB_FacturacionManual.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.FacturarBindingSource, "HabilitarFacturacionManual", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.GB_FacturacionManual.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GB_FacturacionManual.Location = New System.Drawing.Point(3, 3)
        Me.GB_FacturacionManual.Name = "GB_FacturacionManual"
        Me.GB_FacturacionManual.Size = New System.Drawing.Size(359, 246)
        Me.GB_FacturacionManual.TabIndex = 3
        Me.GB_FacturacionManual.TabStop = False
        Me.GB_FacturacionManual.Text = "Información Facturación Manual"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 78)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 13)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "Facturas"
        '
        'QuitarNumeroFactura
        '
        Me.QuitarNumeroFactura.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.QuitarNumeroFactura.Location = New System.Drawing.Point(281, 211)
        Me.QuitarNumeroFactura.Name = "QuitarNumeroFactura"
        Me.QuitarNumeroFactura.Size = New System.Drawing.Size(75, 23)
        Me.QuitarNumeroFactura.TabIndex = 11
        Me.QuitarNumeroFactura.Text = "Quitar"
        Me.QuitarNumeroFactura.UseVisualStyleBackColor = True
        '
        'AgregarNumeroFactura
        '
        Me.AgregarNumeroFactura.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AgregarNumeroFactura.Location = New System.Drawing.Point(281, 49)
        Me.AgregarNumeroFactura.Name = "AgregarNumeroFactura"
        Me.AgregarNumeroFactura.Size = New System.Drawing.Size(75, 23)
        Me.AgregarNumeroFactura.TabIndex = 9
        Me.AgregarNumeroFactura.Text = "Agregar"
        Me.AgregarNumeroFactura.UseVisualStyleBackColor = True
        '
        'FacturasList
        '
        Me.FacturasList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FacturasList.DataSource = Me.NumerosfacturasBindingSource
        Me.FacturasList.FormattingEnabled = True
        Me.FacturasList.Location = New System.Drawing.Point(111, 78)
        Me.FacturasList.Name = "FacturasList"
        Me.FacturasList.Size = New System.Drawing.Size(245, 121)
        Me.FacturasList.TabIndex = 10
        '
        'NumerosfacturasBindingSource
        '
        Me.NumerosfacturasBindingSource.DataMember = "Numerosfacturas"
        Me.NumerosfacturasBindingSource.DataSource = Me.FacturarBindingSource
        '
        'txt_NumeroFacturaManual
        '
        Me.txt_NumeroFacturaManual.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_NumeroFacturaManual.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturarBindingSource, "Numerofactura", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "N0"))
        Me.txt_NumeroFacturaManual.Location = New System.Drawing.Point(111, 22)
        Me.txt_NumeroFacturaManual.Name = "txt_NumeroFacturaManual"
        Me.txt_NumeroFacturaManual.Size = New System.Drawing.Size(245, 20)
        Me.txt_NumeroFacturaManual.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Numero Factura"
        '
        'lblError
        '
        Me.lblError.DataBindings.Add(New System.Windows.Forms.Binding("Visible", Me.FacturarBindingSource, "LimiteFacturacion", True))
        Me.lblError.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblError.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(3, 252)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(359, 168)
        Me.lblError.TabIndex = 12
        Me.lblError.Text = "Se ha alcanzado el máximo permitido para realizar una factura con el tipo de fact" &
    "uración seleccionada. Por favor, seleccione otro tipo de facturación."
        Me.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = Global.SistemaCinderella.My.Resources.Recursos.desconectado_32
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(423, 499)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 40)
        Me.btnCancelar.TabIndex = 18
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnFacturar
        '
        Me.btnFacturar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFacturar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFacturar.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.FacturarBindingSource, "HabilitarFacturar", True))
        Me.btnFacturar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFacturar.Image = Global.SistemaCinderella.My.Resources.Recursos.Conectado_32
        Me.btnFacturar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFacturar.Location = New System.Drawing.Point(654, 499)
        Me.btnFacturar.Name = "btnFacturar"
        Me.btnFacturar.Size = New System.Drawing.Size(100, 40)
        Me.btnFacturar.TabIndex = 17
        Me.btnFacturar.Text = "Facturar"
        Me.btnFacturar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFacturar.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(13, 499)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(117, 13)
        Me.Label25.TabIndex = 69
        Me.Label25.Text = "(*) Campos obligatorios."
        '
        'btnNotaCredito
        '
        Me.btnNotaCredito.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNotaCredito.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNotaCredito.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.FacturarBindingSource, "HabilitarNotaCredito", True))
        Me.btnNotaCredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotaCredito.Image = Global.SistemaCinderella.My.Resources.Recursos.nota_credito
        Me.btnNotaCredito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNotaCredito.Location = New System.Drawing.Point(529, 499)
        Me.btnNotaCredito.Name = "btnNotaCredito"
        Me.btnNotaCredito.Size = New System.Drawing.Size(119, 40)
        Me.btnNotaCredito.TabIndex = 70
        Me.btnNotaCredito.Text = "Nota Crédito"
        Me.btnNotaCredito.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNotaCredito.UseVisualStyleBackColor = True
        '
        'frmFacturar
        '
        Me.AcceptButton = Me.btnFacturar
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(766, 544)
        Me.Controls.Add(Me.btnNotaCredito)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnFacturar)
        Me.Controls.Add(Me.TableLayoutPanel4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmFacturar"
        Me.Text = "Facturación de Venta"
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.FacturarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.TiposFacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.CondicionesIVABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.GB_FacturacionManual.ResumeLayout(False)
        Me.GB_FacturacionManual.PerformLayout()
        CType(Me.NumerosfacturasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblEstado As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Cb_TipoFacturacion As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label18 As Label
    Friend WithEvents lbl_IvaMayorista As Label
    Friend WithEvents lbl_CostoFinancieroMinorista As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents lbl_TotalMinorista As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_DescuentoMinorista As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lbl_SubtotalMinorista As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_Cuit As TextBox
    Friend WithEvents txt_Localidad As TextBox
    Friend WithEvents txt_Direccion As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_Nombre As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Cb_IVA As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_Fecha As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents GB_FacturacionManual As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents QuitarNumeroFactura As Button
    Friend WithEvents AgregarNumeroFactura As Button
    Friend WithEvents FacturasList As ListBox
    Friend WithEvents txt_NumeroFacturaManual As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lblError As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnFacturar As Button
    Friend WithEvents FacturarBindingSource As BindingSource
    Friend WithEvents CondicionesIVABindingSource As BindingSource
    Friend WithEvents TiposFacturaBindingSource As BindingSource
    Friend WithEvents NumerosfacturasBindingSource As BindingSource
    Friend WithEvents Label25 As Label
    Friend WithEvents btnNotaCredito As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_FacturaOrigen As TextBox
End Class
