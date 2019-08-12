<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SaldosSucursal
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
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.GbDetalle = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblTotalVentas = New System.Windows.Forms.Label()
        Me.txt_Efectivo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_TotalVentas = New System.Windows.Forms.TextBox()
        Me.lblCaja = New System.Windows.Forms.Label()
        Me.txt_CajaInicial = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblVarios = New System.Windows.Forms.Label()
        Me.txt_Aporte = New System.Windows.Forms.TextBox()
        Me.txt_CajaFuerteIng = New System.Windows.Forms.TextBox()
        Me.txt_Sobrante = New System.Windows.Forms.TextBox()
        Me.lblEgresos = New System.Windows.Forms.Label()
        Me.lblIngresos = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_PendienteAutorizar = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txt_Devoluciones = New System.Windows.Forms.TextBox()
        Me.lblMercaderias = New System.Windows.Forms.Label()
        Me.txt_CajaFuerteEgr = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_Mercaderias = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_Sueldo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_Faltante = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_Gastos = New System.Windows.Forms.TextBox()
        Me.lblRetiros = New System.Windows.Forms.Label()
        Me.txt_RetirosCaja = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_Impuesto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_EfectivoEgreso = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_VentasDebito = New System.Windows.Forms.TextBox()
        Me.txt_VentasCredito = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_VentasEfectivo = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_VentasCheque = New System.Windows.Forms.TextBox()
        Me.lblMayorista = New System.Windows.Forms.Label()
        Me.txt_VentaMayorista = New System.Windows.Forms.TextBox()
        Me.lblMinorista = New System.Windows.Forms.Label()
        Me.txt_VentaMinorista = New System.Windows.Forms.TextBox()
        Me.lblTotalFacturado = New System.Windows.Forms.Label()
        Me.txt_TotalFacturado = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_VentasDeposito = New System.Windows.Forms.TextBox()
        Me.SaldoSucursalViewModelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableLayoutPanel7.SuspendLayout()
        Me.GbDetalle.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.SaldoSucursalViewModelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel7.ColumnCount = 2
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.77962!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.22038!))
        Me.TableLayoutPanel7.Controls.Add(Me.GbDetalle, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.GroupBox5, 1, 0)
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(962, 286)
        Me.TableLayoutPanel7.TabIndex = 75
        '
        'GbDetalle
        '
        Me.GbDetalle.Controls.Add(Me.TableLayoutPanel4)
        Me.GbDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GbDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbDetalle.Location = New System.Drawing.Point(3, 3)
        Me.GbDetalle.Name = "GbDetalle"
        Me.GbDetalle.Size = New System.Drawing.Size(722, 280)
        Me.GbDetalle.TabIndex = 5
        Me.GbDetalle.TabStop = False
        Me.GbDetalle.Text = "Saldos"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 4
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel2, 3, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.lblEgresos, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.lblIngresos, 2, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel1, 1, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 17)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(716, 260)
        Me.TableLayoutPanel4.TabIndex = 73
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.lblTotalVentas, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_Efectivo, 1, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.Label10, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_TotalVentas, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblCaja, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_CajaInicial, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label17, 0, 9)
        Me.TableLayoutPanel2.Controls.Add(Me.Label12, 0, 8)
        Me.TableLayoutPanel2.Controls.Add(Me.lblVarios, 0, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_Aporte, 1, 9)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_CajaFuerteIng, 1, 8)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_Sobrante, 1, 7)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(401, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 10
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(312, 254)
        Me.TableLayoutPanel2.TabIndex = 73
        '
        'lblTotalVentas
        '
        Me.lblTotalVentas.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalVentas.AutoSize = True
        Me.lblTotalVentas.Location = New System.Drawing.Point(3, 5)
        Me.lblTotalVentas.Name = "lblTotalVentas"
        Me.lblTotalVentas.Size = New System.Drawing.Size(154, 15)
        Me.lblTotalVentas.TabIndex = 61
        Me.lblTotalVentas.Text = "Total Ventas"
        '
        'txt_Efectivo
        '
        Me.txt_Efectivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Efectivo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SaldoSucursalViewModelBindingSource, "RecibidosSucursal", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.txt_Efectivo.Location = New System.Drawing.Point(163, 128)
        Me.txt_Efectivo.Name = "txt_Efectivo"
        Me.txt_Efectivo.ReadOnly = True
        Me.txt_Efectivo.Size = New System.Drawing.Size(146, 21)
        Me.txt_Efectivo.TabIndex = 72
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 130)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(154, 15)
        Me.Label10.TabIndex = 73
        Me.Label10.Text = "Recibidos de Sucursales"
        '
        'txt_TotalVentas
        '
        Me.txt_TotalVentas.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_TotalVentas.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SaldoSucursalViewModelBindingSource, "VentaTotal", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.txt_TotalVentas.Location = New System.Drawing.Point(163, 3)
        Me.txt_TotalVentas.Name = "txt_TotalVentas"
        Me.txt_TotalVentas.ReadOnly = True
        Me.txt_TotalVentas.Size = New System.Drawing.Size(146, 21)
        Me.txt_TotalVentas.TabIndex = 11
        '
        'lblCaja
        '
        Me.lblCaja.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCaja.AutoSize = True
        Me.lblCaja.Location = New System.Drawing.Point(3, 30)
        Me.lblCaja.Name = "lblCaja"
        Me.lblCaja.Size = New System.Drawing.Size(154, 15)
        Me.lblCaja.TabIndex = 31
        Me.lblCaja.Text = "Caja Inicial"
        '
        'txt_CajaInicial
        '
        Me.txt_CajaInicial.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_CajaInicial.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SaldoSucursalViewModelBindingSource, "CajaInical", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.txt_CajaInicial.Location = New System.Drawing.Point(163, 28)
        Me.txt_CajaInicial.Name = "txt_CajaInicial"
        Me.txt_CajaInicial.ReadOnly = True
        Me.txt_CajaInicial.Size = New System.Drawing.Size(146, 21)
        Me.txt_CajaInicial.TabIndex = 6
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(3, 232)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(154, 15)
        Me.Label17.TabIndex = 83
        Me.Label17.Text = "Aporte de Socios"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 205)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(154, 15)
        Me.Label12.TabIndex = 77
        Me.Label12.Text = "Egreso de Caja Fuerte"
        '
        'lblVarios
        '
        Me.lblVarios.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVarios.AutoSize = True
        Me.lblVarios.Location = New System.Drawing.Point(3, 180)
        Me.lblVarios.Name = "lblVarios"
        Me.lblVarios.Size = New System.Drawing.Size(154, 15)
        Me.lblVarios.TabIndex = 67
        Me.lblVarios.Text = "Sobrante de Caja"
        '
        'txt_Aporte
        '
        Me.txt_Aporte.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Aporte.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SaldoSucursalViewModelBindingSource, "AporteSocios", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.txt_Aporte.Location = New System.Drawing.Point(163, 229)
        Me.txt_Aporte.Name = "txt_Aporte"
        Me.txt_Aporte.ReadOnly = True
        Me.txt_Aporte.Size = New System.Drawing.Size(146, 21)
        Me.txt_Aporte.TabIndex = 82
        '
        'txt_CajaFuerteIng
        '
        Me.txt_CajaFuerteIng.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_CajaFuerteIng.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SaldoSucursalViewModelBindingSource, "EgresoCajaFuerte", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.txt_CajaFuerteIng.Location = New System.Drawing.Point(163, 203)
        Me.txt_CajaFuerteIng.Name = "txt_CajaFuerteIng"
        Me.txt_CajaFuerteIng.ReadOnly = True
        Me.txt_CajaFuerteIng.Size = New System.Drawing.Size(146, 21)
        Me.txt_CajaFuerteIng.TabIndex = 76
        '
        'txt_Sobrante
        '
        Me.txt_Sobrante.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Sobrante.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SaldoSucursalViewModelBindingSource, "SobranteCaja", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.txt_Sobrante.Location = New System.Drawing.Point(163, 178)
        Me.txt_Sobrante.Name = "txt_Sobrante"
        Me.txt_Sobrante.ReadOnly = True
        Me.txt_Sobrante.Size = New System.Drawing.Size(146, 21)
        Me.txt_Sobrante.TabIndex = 66
        '
        'lblEgresos
        '
        Me.lblEgresos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEgresos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEgresos.Image = Global.SistemaCinderella.My.Resources.Recursos.Egreso_32
        Me.lblEgresos.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblEgresos.Location = New System.Drawing.Point(3, 0)
        Me.lblEgresos.Name = "lblEgresos"
        Me.lblEgresos.Size = New System.Drawing.Size(34, 257)
        Me.lblEgresos.TabIndex = 69
        Me.lblEgresos.Text = "E" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "G" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "R" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "E" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "S" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "O" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "S"
        Me.lblEgresos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblIngresos
        '
        Me.lblIngresos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblIngresos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIngresos.Image = Global.SistemaCinderella.My.Resources.Recursos.Ingreso_32
        Me.lblIngresos.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblIngresos.Location = New System.Drawing.Point(361, 0)
        Me.lblIngresos.Name = "lblIngresos"
        Me.lblIngresos.Size = New System.Drawing.Size(34, 260)
        Me.lblIngresos.TabIndex = 68
        Me.lblIngresos.Text = "I" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "N" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "G" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "R" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "E" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "S" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "O" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "S"
        Me.lblIngresos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label15, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_PendienteAutorizar, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label20, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Devoluciones, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblMercaderias, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_CajaFuerteEgr, 1, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.Label11, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Mercaderias, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Sueldo, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Faltante, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Gastos, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lblRetiros, 0, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_RetirosCaja, 1, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Impuesto, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_EfectivoEgreso, 1, 5)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(43, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 10
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(312, 254)
        Me.TableLayoutPanel1.TabIndex = 86
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(3, 5)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(154, 15)
        Me.Label15.TabIndex = 78
        Me.Label15.Text = "Devoluciones"
        '
        'txt_PendienteAutorizar
        '
        Me.txt_PendienteAutorizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_PendienteAutorizar.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SaldoSucursalViewModelBindingSource, "PendienteAutorizacion", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.txt_PendienteAutorizar.Location = New System.Drawing.Point(163, 153)
        Me.txt_PendienteAutorizar.Name = "txt_PendienteAutorizar"
        Me.txt_PendienteAutorizar.ReadOnly = True
        Me.txt_PendienteAutorizar.Size = New System.Drawing.Size(146, 21)
        Me.txt_PendienteAutorizar.TabIndex = 84
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(3, 155)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(154, 15)
        Me.Label20.TabIndex = 85
        Me.Label20.Text = "Pend. de Autorización"
        '
        'txt_Devoluciones
        '
        Me.txt_Devoluciones.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Devoluciones.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SaldoSucursalViewModelBindingSource, "Devoluciones", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.txt_Devoluciones.Location = New System.Drawing.Point(163, 3)
        Me.txt_Devoluciones.Name = "txt_Devoluciones"
        Me.txt_Devoluciones.ReadOnly = True
        Me.txt_Devoluciones.Size = New System.Drawing.Size(146, 21)
        Me.txt_Devoluciones.TabIndex = 79
        '
        'lblMercaderias
        '
        Me.lblMercaderias.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMercaderias.AutoSize = True
        Me.lblMercaderias.Location = New System.Drawing.Point(3, 30)
        Me.lblMercaderias.Name = "lblMercaderias"
        Me.lblMercaderias.Size = New System.Drawing.Size(154, 15)
        Me.lblMercaderias.TabIndex = 37
        Me.lblMercaderias.Text = "Mercaderias"
        '
        'txt_CajaFuerteEgr
        '
        Me.txt_CajaFuerteEgr.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_CajaFuerteEgr.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SaldoSucursalViewModelBindingSource, "IngresosCajaFuerte", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.txt_CajaFuerteEgr.Location = New System.Drawing.Point(163, 203)
        Me.txt_CajaFuerteEgr.Name = "txt_CajaFuerteEgr"
        Me.txt_CajaFuerteEgr.ReadOnly = True
        Me.txt_CajaFuerteEgr.Size = New System.Drawing.Size(146, 21)
        Me.txt_CajaFuerteEgr.TabIndex = 74
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 205)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(154, 15)
        Me.Label11.TabIndex = 75
        Me.Label11.Text = "Ingreso a Caja Fuerte"
        '
        'txt_Mercaderias
        '
        Me.txt_Mercaderias.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Mercaderias.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SaldoSucursalViewModelBindingSource, "Mercaderia", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.txt_Mercaderias.Location = New System.Drawing.Point(163, 28)
        Me.txt_Mercaderias.Name = "txt_Mercaderias"
        Me.txt_Mercaderias.ReadOnly = True
        Me.txt_Mercaderias.Size = New System.Drawing.Size(146, 21)
        Me.txt_Mercaderias.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 15)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Sueldos"
        '
        'txt_Sueldo
        '
        Me.txt_Sueldo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Sueldo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SaldoSucursalViewModelBindingSource, "Sueldos", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.txt_Sueldo.Location = New System.Drawing.Point(163, 53)
        Me.txt_Sueldo.Name = "txt_Sueldo"
        Me.txt_Sueldo.ReadOnly = True
        Me.txt_Sueldo.Size = New System.Drawing.Size(146, 21)
        Me.txt_Sueldo.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 15)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Gastos"
        '
        'txt_Faltante
        '
        Me.txt_Faltante.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Faltante.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SaldoSucursalViewModelBindingSource, "FaltanteCaja", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.txt_Faltante.Location = New System.Drawing.Point(163, 178)
        Me.txt_Faltante.Name = "txt_Faltante"
        Me.txt_Faltante.ReadOnly = True
        Me.txt_Faltante.Size = New System.Drawing.Size(146, 21)
        Me.txt_Faltante.TabIndex = 70
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(154, 15)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "Faltante de Caja"
        '
        'txt_Gastos
        '
        Me.txt_Gastos.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Gastos.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SaldoSucursalViewModelBindingSource, "Gastos", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.txt_Gastos.Location = New System.Drawing.Point(163, 78)
        Me.txt_Gastos.Name = "txt_Gastos"
        Me.txt_Gastos.ReadOnly = True
        Me.txt_Gastos.Size = New System.Drawing.Size(146, 21)
        Me.txt_Gastos.TabIndex = 8
        '
        'lblRetiros
        '
        Me.lblRetiros.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRetiros.AutoSize = True
        Me.lblRetiros.Location = New System.Drawing.Point(3, 232)
        Me.lblRetiros.Name = "lblRetiros"
        Me.lblRetiros.Size = New System.Drawing.Size(154, 15)
        Me.lblRetiros.TabIndex = 32
        Me.lblRetiros.Text = "Retiros de Socios"
        '
        'txt_RetirosCaja
        '
        Me.txt_RetirosCaja.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_RetirosCaja.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SaldoSucursalViewModelBindingSource, "RetiroSocios", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.txt_RetirosCaja.Location = New System.Drawing.Point(163, 229)
        Me.txt_RetirosCaja.Name = "txt_RetirosCaja"
        Me.txt_RetirosCaja.ReadOnly = True
        Me.txt_RetirosCaja.Size = New System.Drawing.Size(146, 21)
        Me.txt_RetirosCaja.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 15)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Impuestos"
        '
        'txt_Impuesto
        '
        Me.txt_Impuesto.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Impuesto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SaldoSucursalViewModelBindingSource, "Impuestos", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.txt_Impuesto.Location = New System.Drawing.Point(163, 103)
        Me.txt_Impuesto.Name = "txt_Impuesto"
        Me.txt_Impuesto.ReadOnly = True
        Me.txt_Impuesto.Size = New System.Drawing.Size(146, 21)
        Me.txt_Impuesto.TabIndex = 62
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 15)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Envíos a Sucursales"
        '
        'txt_EfectivoEgreso
        '
        Me.txt_EfectivoEgreso.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_EfectivoEgreso.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SaldoSucursalViewModelBindingSource, "EnviosSucursales", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.txt_EfectivoEgreso.Location = New System.Drawing.Point(163, 128)
        Me.txt_EfectivoEgreso.Name = "txt_EfectivoEgreso"
        Me.txt_EfectivoEgreso.ReadOnly = True
        Me.txt_EfectivoEgreso.Size = New System.Drawing.Size(146, 21)
        Me.txt_EfectivoEgreso.TabIndex = 63
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.TableLayoutPanel3)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox5.Location = New System.Drawing.Point(731, 3)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(228, 280)
        Me.GroupBox5.TabIndex = 72
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Ventas"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.txt_VentasDebito, 1, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.txt_VentasCredito, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Label19, 0, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label16, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.txt_VentasEfectivo, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label18, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.txt_VentasCheque, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.lblMayorista, 0, 7)
        Me.TableLayoutPanel3.Controls.Add(Me.txt_VentaMayorista, 1, 7)
        Me.TableLayoutPanel3.Controls.Add(Me.lblMinorista, 0, 6)
        Me.TableLayoutPanel3.Controls.Add(Me.txt_VentaMinorista, 1, 6)
        Me.TableLayoutPanel3.Controls.Add(Me.lblTotalFacturado, 0, 5)
        Me.TableLayoutPanel3.Controls.Add(Me.txt_TotalFacturado, 1, 5)
        Me.TableLayoutPanel3.Controls.Add(Me.Label7, 0, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.txt_VentasDeposito, 1, 4)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 8
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.50328!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(222, 261)
        Me.TableLayoutPanel3.TabIndex = 87
        '
        'txt_VentasDebito
        '
        Me.txt_VentasDebito.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_VentasDebito.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SaldoSucursalViewModelBindingSource, "VentaDebito", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.txt_VentasDebito.Location = New System.Drawing.Point(78, 102)
        Me.txt_VentasDebito.Name = "txt_VentasDebito"
        Me.txt_VentasDebito.ReadOnly = True
        Me.txt_VentasDebito.Size = New System.Drawing.Size(141, 20)
        Me.txt_VentasDebito.TabIndex = 72
        '
        'txt_VentasCredito
        '
        Me.txt_VentasCredito.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_VentasCredito.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SaldoSucursalViewModelBindingSource, "VentaCredito", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.txt_VentasCredito.Location = New System.Drawing.Point(78, 70)
        Me.txt_VentasCredito.Name = "txt_VentasCredito"
        Me.txt_VentasCredito.ReadOnly = True
        Me.txt_VentasCredito.Size = New System.Drawing.Size(141, 20)
        Me.txt_VentasCredito.TabIndex = 70
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(3, 105)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(69, 13)
        Me.Label19.TabIndex = 73
        Me.Label19.Text = "Debito"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 13)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Efectivo"
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(3, 73)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(69, 13)
        Me.Label16.TabIndex = 71
        Me.Label16.Text = "Crédito"
        '
        'txt_VentasEfectivo
        '
        Me.txt_VentasEfectivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_VentasEfectivo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SaldoSucursalViewModelBindingSource, "VentaEfectivo", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.txt_VentasEfectivo.Location = New System.Drawing.Point(78, 6)
        Me.txt_VentasEfectivo.Name = "txt_VentasEfectivo"
        Me.txt_VentasEfectivo.ReadOnly = True
        Me.txt_VentasEfectivo.Size = New System.Drawing.Size(141, 20)
        Me.txt_VentasEfectivo.TabIndex = 12
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(3, 41)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(69, 13)
        Me.Label18.TabIndex = 59
        Me.Label18.Text = "Cheque"
        '
        'txt_VentasCheque
        '
        Me.txt_VentasCheque.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_VentasCheque.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SaldoSucursalViewModelBindingSource, "VentaCheque", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.txt_VentasCheque.Location = New System.Drawing.Point(78, 38)
        Me.txt_VentasCheque.Name = "txt_VentasCheque"
        Me.txt_VentasCheque.ReadOnly = True
        Me.txt_VentasCheque.Size = New System.Drawing.Size(141, 20)
        Me.txt_VentasCheque.TabIndex = 58
        '
        'lblMayorista
        '
        Me.lblMayorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMayorista.AutoSize = True
        Me.lblMayorista.Location = New System.Drawing.Point(3, 236)
        Me.lblMayorista.Name = "lblMayorista"
        Me.lblMayorista.Size = New System.Drawing.Size(69, 13)
        Me.lblMayorista.TabIndex = 57
        Me.lblMayorista.Text = "Mayorista"
        '
        'txt_VentaMayorista
        '
        Me.txt_VentaMayorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_VentaMayorista.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SaldoSucursalViewModelBindingSource, "VentaMayorista", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.txt_VentaMayorista.Location = New System.Drawing.Point(78, 232)
        Me.txt_VentaMayorista.Name = "txt_VentaMayorista"
        Me.txt_VentaMayorista.ReadOnly = True
        Me.txt_VentaMayorista.Size = New System.Drawing.Size(141, 20)
        Me.txt_VentaMayorista.TabIndex = 15
        '
        'lblMinorista
        '
        Me.lblMinorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMinorista.AutoSize = True
        Me.lblMinorista.Location = New System.Drawing.Point(3, 201)
        Me.lblMinorista.Name = "lblMinorista"
        Me.lblMinorista.Size = New System.Drawing.Size(69, 13)
        Me.lblMinorista.TabIndex = 54
        Me.lblMinorista.Text = "Minorista"
        '
        'txt_VentaMinorista
        '
        Me.txt_VentaMinorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_VentaMinorista.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SaldoSucursalViewModelBindingSource, "VentaMinorista", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.txt_VentaMinorista.Location = New System.Drawing.Point(78, 198)
        Me.txt_VentaMinorista.Name = "txt_VentaMinorista"
        Me.txt_VentaMinorista.ReadOnly = True
        Me.txt_VentaMinorista.Size = New System.Drawing.Size(141, 20)
        Me.txt_VentaMinorista.TabIndex = 16
        '
        'lblTotalFacturado
        '
        Me.lblTotalFacturado.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalFacturado.AutoSize = True
        Me.lblTotalFacturado.Location = New System.Drawing.Point(3, 169)
        Me.lblTotalFacturado.Name = "lblTotalFacturado"
        Me.lblTotalFacturado.Size = New System.Drawing.Size(69, 13)
        Me.lblTotalFacturado.TabIndex = 51
        Me.lblTotalFacturado.Text = "Facturado"
        '
        'txt_TotalFacturado
        '
        Me.txt_TotalFacturado.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_TotalFacturado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SaldoSucursalViewModelBindingSource, "VentaFacturado", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.txt_TotalFacturado.Location = New System.Drawing.Point(78, 166)
        Me.txt_TotalFacturado.Name = "txt_TotalFacturado"
        Me.txt_TotalFacturado.ReadOnly = True
        Me.txt_TotalFacturado.Size = New System.Drawing.Size(141, 20)
        Me.txt_TotalFacturado.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 137)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 13)
        Me.Label7.TabIndex = 74
        Me.Label7.Text = "Deposito"
        '
        'txt_VentasDeposito
        '
        Me.txt_VentasDeposito.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_VentasDeposito.BackColor = System.Drawing.SystemColors.Control
        Me.txt_VentasDeposito.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SaldoSucursalViewModelBindingSource, "VentaDeposito", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.txt_VentasDeposito.Location = New System.Drawing.Point(78, 134)
        Me.txt_VentasDeposito.Name = "txt_VentasDeposito"
        Me.txt_VentasDeposito.ReadOnly = True
        Me.txt_VentasDeposito.Size = New System.Drawing.Size(141, 20)
        Me.txt_VentasDeposito.TabIndex = 75
        '
        'SaldoSucursalViewModelBindingSource
        '
        Me.SaldoSucursalViewModelBindingSource.DataSource = GetType(SistemaCinderella.Comunes.SaldoSucursalViewModel)
        '
        'SaldosSucursal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel7)
        Me.Name = "SaldosSucursal"
        Me.Size = New System.Drawing.Size(962, 286)
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.GbDetalle.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.SaldoSucursalViewModelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents GbDetalle As GroupBox
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents lblTotalVentas As Label
    Friend WithEvents txt_Efectivo As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_CajaFuerteIng As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_Aporte As TextBox
    Friend WithEvents txt_TotalVentas As TextBox
    Friend WithEvents txt_Sobrante As TextBox
    Friend WithEvents lblVarios As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents lblCaja As Label
    Friend WithEvents txt_CajaInicial As TextBox
    Friend WithEvents lblEgresos As Label
    Friend WithEvents lblIngresos As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label15 As Label
    Friend WithEvents txt_PendienteAutorizar As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txt_Devoluciones As TextBox
    Friend WithEvents lblMercaderias As Label
    Friend WithEvents txt_CajaFuerteEgr As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_Mercaderias As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_Sueldo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_Faltante As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_Gastos As TextBox
    Friend WithEvents lblRetiros As Label
    Friend WithEvents txt_RetirosCaja As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_Impuesto As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_EfectivoEgreso As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents txt_VentaMayorista As TextBox
    Friend WithEvents txt_VentaMinorista As TextBox
    Friend WithEvents lblMayorista As Label
    Friend WithEvents txt_TotalFacturado As TextBox
    Friend WithEvents lblMinorista As Label
    Friend WithEvents txt_VentasDebito As TextBox
    Friend WithEvents lblTotalFacturado As Label
    Friend WithEvents txt_VentasCredito As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txt_VentasEfectivo As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txt_VentasCheque As TextBox
    Friend WithEvents SaldoSucursalViewModelBindingSource As BindingSource
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_VentasDeposito As TextBox
End Class
