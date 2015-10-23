<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResumenDiario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmResumenDiario))
        Me.GbDetalle = New System.Windows.Forms.GroupBox()
        Me.txt_Aporte = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_Adicional = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_DevolucionesEgr = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_CajaFuerteIng = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_CajaFuerteEgr = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_Efectivo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_Faltante = New System.Windows.Forms.TextBox()
        Me.lblEgresos = New System.Windows.Forms.Label()
        Me.lblIngresos = New System.Windows.Forms.Label()
        Me.lblVarios = New System.Windows.Forms.Label()
        Me.txt_Sobrante = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_EfectivoEgreso = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_Impuesto = New System.Windows.Forms.TextBox()
        Me.txt_TotalVentas = New System.Windows.Forms.TextBox()
        Me.lblTotalVentas = New System.Windows.Forms.Label()
        Me.lblMayorista = New System.Windows.Forms.Label()
        Me.txt_VentaMayorista = New System.Windows.Forms.TextBox()
        Me.lblMinorista = New System.Windows.Forms.Label()
        Me.txt_VentaMinorista = New System.Windows.Forms.TextBox()
        Me.lblTotalFacturado = New System.Windows.Forms.Label()
        Me.txt_TotalFacturado = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_Gastos = New System.Windows.Forms.TextBox()
        Me.lbl_Faltante = New System.Windows.Forms.Label()
        Me.txt_VentasTarjeta = New System.Windows.Forms.TextBox()
        Me.txt_Sueldo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblMercaderias = New System.Windows.Forms.Label()
        Me.txt_VentasEfectivo = New System.Windows.Forms.TextBox()
        Me.txt_CajaInicial = New System.Windows.Forms.TextBox()
        Me.lblRetiros = New System.Windows.Forms.Label()
        Me.lblCaja = New System.Windows.Forms.Label()
        Me.txt_RetirosCaja = New System.Windows.Forms.TextBox()
        Me.txt_Mercaderias = New System.Windows.Forms.TextBox()
        Me.Btn_Salir = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Btn_Limpiar = New System.Windows.Forms.Button()
        Me.lblSucursalNombre = New System.Windows.Forms.Label()
        Me.lblSucursal = New System.Windows.Forms.Label()
        Me.txt_Fecha = New System.Windows.Forms.DateTimePicker()
        Me.Btn_Buscar = New System.Windows.Forms.Button()
        Me.lblFechaD = New System.Windows.Forms.Label()
        Me.ToolResumen = New System.Windows.Forms.ToolTip(Me.components)
        Me.Btn_Cerrar = New System.Windows.Forms.Button()
        Me.Btn_Abrir = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GB_Caja = New System.Windows.Forms.GroupBox()
        Me.lbl_Empleado = New System.Windows.Forms.Label()
        Me.lbl_Abierta = New System.Windows.Forms.Label()
        Me.lbl_Hora = New System.Windows.Forms.Label()
        Me.lbl_Fecha = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GB_Monto = New System.Windows.Forms.GroupBox()
        Me.lbl_Saldo = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_DispoCheq = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ErrorResumen = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lbl_DispoEfect = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txt_VentasCheque = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GbDetalle.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GB_Caja.SuspendLayout()
        Me.GB_Monto.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ErrorResumen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GbDetalle
        '
        Me.GbDetalle.Controls.Add(Me.txt_Aporte)
        Me.GbDetalle.Controls.Add(Me.Label17)
        Me.GbDetalle.Controls.Add(Me.txt_Adicional)
        Me.GbDetalle.Controls.Add(Me.Label16)
        Me.GbDetalle.Controls.Add(Me.txt_DevolucionesEgr)
        Me.GbDetalle.Controls.Add(Me.Label15)
        Me.GbDetalle.Controls.Add(Me.Label12)
        Me.GbDetalle.Controls.Add(Me.txt_CajaFuerteIng)
        Me.GbDetalle.Controls.Add(Me.Label11)
        Me.GbDetalle.Controls.Add(Me.txt_CajaFuerteEgr)
        Me.GbDetalle.Controls.Add(Me.Label10)
        Me.GbDetalle.Controls.Add(Me.txt_Efectivo)
        Me.GbDetalle.Controls.Add(Me.Label5)
        Me.GbDetalle.Controls.Add(Me.txt_Faltante)
        Me.GbDetalle.Controls.Add(Me.lblEgresos)
        Me.GbDetalle.Controls.Add(Me.lblIngresos)
        Me.GbDetalle.Controls.Add(Me.lblVarios)
        Me.GbDetalle.Controls.Add(Me.txt_Sobrante)
        Me.GbDetalle.Controls.Add(Me.Label3)
        Me.GbDetalle.Controls.Add(Me.txt_EfectivoEgreso)
        Me.GbDetalle.Controls.Add(Me.Label1)
        Me.GbDetalle.Controls.Add(Me.txt_Impuesto)
        Me.GbDetalle.Controls.Add(Me.txt_TotalVentas)
        Me.GbDetalle.Controls.Add(Me.lblTotalVentas)
        Me.GbDetalle.Controls.Add(Me.Label4)
        Me.GbDetalle.Controls.Add(Me.txt_Gastos)
        Me.GbDetalle.Controls.Add(Me.txt_Sueldo)
        Me.GbDetalle.Controls.Add(Me.Label2)
        Me.GbDetalle.Controls.Add(Me.lblMercaderias)
        Me.GbDetalle.Controls.Add(Me.txt_CajaInicial)
        Me.GbDetalle.Controls.Add(Me.lblRetiros)
        Me.GbDetalle.Controls.Add(Me.lblCaja)
        Me.GbDetalle.Controls.Add(Me.txt_RetirosCaja)
        Me.GbDetalle.Controls.Add(Me.txt_Mercaderias)
        Me.GbDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbDetalle.Location = New System.Drawing.Point(12, 168)
        Me.GbDetalle.Name = "GbDetalle"
        Me.GbDetalle.Size = New System.Drawing.Size(727, 296)
        Me.GbDetalle.TabIndex = 5
        Me.GbDetalle.TabStop = False
        Me.GbDetalle.Text = "Resumen Diario"
        '
        'txt_Aporte
        '
        Me.txt_Aporte.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_Aporte.Location = New System.Drawing.Point(596, 258)
        Me.txt_Aporte.Name = "txt_Aporte"
        Me.txt_Aporte.ReadOnly = True
        Me.txt_Aporte.Size = New System.Drawing.Size(125, 21)
        Me.txt_Aporte.TabIndex = 82
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(417, 264)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(99, 15)
        Me.Label17.TabIndex = 83
        Me.Label17.Text = "Aporte de Socios"
        '
        'txt_Adicional
        '
        Me.txt_Adicional.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_Adicional.Location = New System.Drawing.Point(216, 204)
        Me.txt_Adicional.Name = "txt_Adicional"
        Me.txt_Adicional.ReadOnly = True
        Me.txt_Adicional.Size = New System.Drawing.Size(125, 21)
        Me.txt_Adicional.TabIndex = 80
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(56, 207)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(146, 15)
        Me.Label16.TabIndex = 81
        Me.Label16.Text = "Adicionales a Empleados"
        '
        'txt_DevolucionesEgr
        '
        Me.txt_DevolucionesEgr.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_DevolucionesEgr.Location = New System.Drawing.Point(216, 18)
        Me.txt_DevolucionesEgr.Name = "txt_DevolucionesEgr"
        Me.txt_DevolucionesEgr.ReadOnly = True
        Me.txt_DevolucionesEgr.Size = New System.Drawing.Size(125, 21)
        Me.txt_DevolucionesEgr.TabIndex = 79
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(56, 20)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(81, 15)
        Me.Label15.TabIndex = 78
        Me.Label15.Text = "Devoluciones"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(418, 234)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(129, 15)
        Me.Label12.TabIndex = 77
        Me.Label12.Text = "Egreso de Caja Fuerte"
        '
        'txt_CajaFuerteIng
        '
        Me.txt_CajaFuerteIng.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_CajaFuerteIng.Location = New System.Drawing.Point(596, 231)
        Me.txt_CajaFuerteIng.Name = "txt_CajaFuerteIng"
        Me.txt_CajaFuerteIng.ReadOnly = True
        Me.txt_CajaFuerteIng.Size = New System.Drawing.Size(125, 21)
        Me.txt_CajaFuerteIng.TabIndex = 76
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(56, 234)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(124, 15)
        Me.Label11.TabIndex = 75
        Me.Label11.Text = "Ingreso a Caja Fuerte"
        '
        'txt_CajaFuerteEgr
        '
        Me.txt_CajaFuerteEgr.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_CajaFuerteEgr.Location = New System.Drawing.Point(216, 231)
        Me.txt_CajaFuerteEgr.Name = "txt_CajaFuerteEgr"
        Me.txt_CajaFuerteEgr.ReadOnly = True
        Me.txt_CajaFuerteEgr.Size = New System.Drawing.Size(125, 21)
        Me.txt_CajaFuerteEgr.TabIndex = 74
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(418, 154)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(171, 15)
        Me.Label10.TabIndex = 73
        Me.Label10.Text = "Recibidos de otras sucursales"
        '
        'txt_Efectivo
        '
        Me.txt_Efectivo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_Efectivo.Location = New System.Drawing.Point(596, 148)
        Me.txt_Efectivo.Name = "txt_Efectivo"
        Me.txt_Efectivo.ReadOnly = True
        Me.txt_Efectivo.Size = New System.Drawing.Size(125, 21)
        Me.txt_Efectivo.TabIndex = 72
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(56, 181)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 15)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "Faltante de Caja"
        '
        'txt_Faltante
        '
        Me.txt_Faltante.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_Faltante.Location = New System.Drawing.Point(216, 178)
        Me.txt_Faltante.Name = "txt_Faltante"
        Me.txt_Faltante.ReadOnly = True
        Me.txt_Faltante.Size = New System.Drawing.Size(125, 21)
        Me.txt_Faltante.TabIndex = 70
        '
        'lblEgresos
        '
        Me.lblEgresos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEgresos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEgresos.Image = Global.SistemaCinderella.My.Resources.Recursos.Egreso_32
        Me.lblEgresos.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblEgresos.Location = New System.Drawing.Point(9, 30)
        Me.lblEgresos.Name = "lblEgresos"
        Me.lblEgresos.Size = New System.Drawing.Size(41, 188)
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
        Me.lblIngresos.Location = New System.Drawing.Point(360, 23)
        Me.lblIngresos.Name = "lblIngresos"
        Me.lblIngresos.Size = New System.Drawing.Size(41, 202)
        Me.lblIngresos.TabIndex = 68
        Me.lblIngresos.Text = "I" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "N" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "G" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "R" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "E" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "S" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "O" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "S"
        Me.lblIngresos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblVarios
        '
        Me.lblVarios.AutoSize = True
        Me.lblVarios.Location = New System.Drawing.Point(418, 178)
        Me.lblVarios.Name = "lblVarios"
        Me.lblVarios.Size = New System.Drawing.Size(102, 15)
        Me.lblVarios.TabIndex = 67
        Me.lblVarios.Text = "Sobrante de Caja"
        '
        'txt_Sobrante
        '
        Me.txt_Sobrante.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_Sobrante.Location = New System.Drawing.Point(596, 175)
        Me.txt_Sobrante.Name = "txt_Sobrante"
        Me.txt_Sobrante.ReadOnly = True
        Me.txt_Sobrante.Size = New System.Drawing.Size(125, 21)
        Me.txt_Sobrante.TabIndex = 66
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 15)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Envíos a otras sucursales"
        '
        'txt_EfectivoEgreso
        '
        Me.txt_EfectivoEgreso.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_EfectivoEgreso.Location = New System.Drawing.Point(216, 151)
        Me.txt_EfectivoEgreso.Name = "txt_EfectivoEgreso"
        Me.txt_EfectivoEgreso.ReadOnly = True
        Me.txt_EfectivoEgreso.Size = New System.Drawing.Size(125, 21)
        Me.txt_EfectivoEgreso.TabIndex = 63
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 15)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Impuestos"
        '
        'txt_Impuesto
        '
        Me.txt_Impuesto.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_Impuesto.Location = New System.Drawing.Point(216, 125)
        Me.txt_Impuesto.Name = "txt_Impuesto"
        Me.txt_Impuesto.ReadOnly = True
        Me.txt_Impuesto.Size = New System.Drawing.Size(125, 21)
        Me.txt_Impuesto.TabIndex = 62
        '
        'txt_TotalVentas
        '
        Me.txt_TotalVentas.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_TotalVentas.Location = New System.Drawing.Point(596, 18)
        Me.txt_TotalVentas.Name = "txt_TotalVentas"
        Me.txt_TotalVentas.ReadOnly = True
        Me.txt_TotalVentas.Size = New System.Drawing.Size(125, 21)
        Me.txt_TotalVentas.TabIndex = 11
        '
        'lblTotalVentas
        '
        Me.lblTotalVentas.AutoSize = True
        Me.lblTotalVentas.Location = New System.Drawing.Point(418, 24)
        Me.lblTotalVentas.Name = "lblTotalVentas"
        Me.lblTotalVentas.Size = New System.Drawing.Size(74, 15)
        Me.lblTotalVentas.TabIndex = 61
        Me.lblTotalVentas.Text = "Total Ventas"
        '
        'lblMayorista
        '
        Me.lblMayorista.AutoSize = True
        Me.lblMayorista.Location = New System.Drawing.Point(7, 132)
        Me.lblMayorista.Name = "lblMayorista"
        Me.lblMayorista.Size = New System.Drawing.Size(60, 15)
        Me.lblMayorista.TabIndex = 57
        Me.lblMayorista.Text = "Mayorista"
        '
        'txt_VentaMayorista
        '
        Me.txt_VentaMayorista.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_VentaMayorista.Location = New System.Drawing.Point(96, 126)
        Me.txt_VentaMayorista.Name = "txt_VentaMayorista"
        Me.txt_VentaMayorista.ReadOnly = True
        Me.txt_VentaMayorista.Size = New System.Drawing.Size(125, 21)
        Me.txt_VentaMayorista.TabIndex = 15
        '
        'lblMinorista
        '
        Me.lblMinorista.AutoSize = True
        Me.lblMinorista.Location = New System.Drawing.Point(7, 159)
        Me.lblMinorista.Name = "lblMinorista"
        Me.lblMinorista.Size = New System.Drawing.Size(58, 15)
        Me.lblMinorista.TabIndex = 54
        Me.lblMinorista.Text = "Minorista"
        '
        'txt_VentaMinorista
        '
        Me.txt_VentaMinorista.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_VentaMinorista.Location = New System.Drawing.Point(96, 153)
        Me.txt_VentaMinorista.Name = "txt_VentaMinorista"
        Me.txt_VentaMinorista.ReadOnly = True
        Me.txt_VentaMinorista.Size = New System.Drawing.Size(125, 21)
        Me.txt_VentaMinorista.TabIndex = 16
        '
        'lblTotalFacturado
        '
        Me.lblTotalFacturado.AutoSize = True
        Me.lblTotalFacturado.Location = New System.Drawing.Point(6, 105)
        Me.lblTotalFacturado.Name = "lblTotalFacturado"
        Me.lblTotalFacturado.Size = New System.Drawing.Size(62, 15)
        Me.lblTotalFacturado.TabIndex = 51
        Me.lblTotalFacturado.Text = "Facturado"
        '
        'txt_TotalFacturado
        '
        Me.txt_TotalFacturado.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_TotalFacturado.Location = New System.Drawing.Point(95, 99)
        Me.txt_TotalFacturado.Name = "txt_TotalFacturado"
        Me.txt_TotalFacturado.ReadOnly = True
        Me.txt_TotalFacturado.Size = New System.Drawing.Size(125, 21)
        Me.txt_TotalFacturado.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(56, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 15)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Gastos"
        '
        'txt_Gastos
        '
        Me.txt_Gastos.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_Gastos.Location = New System.Drawing.Point(216, 99)
        Me.txt_Gastos.Name = "txt_Gastos"
        Me.txt_Gastos.ReadOnly = True
        Me.txt_Gastos.Size = New System.Drawing.Size(125, 21)
        Me.txt_Gastos.TabIndex = 8
        '
        'lbl_Faltante
        '
        Me.lbl_Faltante.AutoSize = True
        Me.lbl_Faltante.Location = New System.Drawing.Point(6, 80)
        Me.lbl_Faltante.Name = "lbl_Faltante"
        Me.lbl_Faltante.Size = New System.Drawing.Size(45, 15)
        Me.lbl_Faltante.TabIndex = 45
        Me.lbl_Faltante.Text = "Tarjeta"
        '
        'txt_VentasTarjeta
        '
        Me.txt_VentasTarjeta.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_VentasTarjeta.Location = New System.Drawing.Point(95, 72)
        Me.txt_VentasTarjeta.Name = "txt_VentasTarjeta"
        Me.txt_VentasTarjeta.ReadOnly = True
        Me.txt_VentasTarjeta.Size = New System.Drawing.Size(125, 21)
        Me.txt_VentasTarjeta.TabIndex = 13
        '
        'txt_Sueldo
        '
        Me.txt_Sueldo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_Sueldo.Location = New System.Drawing.Point(216, 72)
        Me.txt_Sueldo.Name = "txt_Sueldo"
        Me.txt_Sueldo.ReadOnly = True
        Me.txt_Sueldo.Size = New System.Drawing.Size(125, 21)
        Me.txt_Sueldo.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 15)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Sueldos"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 15)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Efectivo"
        '
        'lblMercaderias
        '
        Me.lblMercaderias.AutoSize = True
        Me.lblMercaderias.Location = New System.Drawing.Point(56, 48)
        Me.lblMercaderias.Name = "lblMercaderias"
        Me.lblMercaderias.Size = New System.Drawing.Size(76, 15)
        Me.lblMercaderias.TabIndex = 37
        Me.lblMercaderias.Text = "Mercaderias"
        '
        'txt_VentasEfectivo
        '
        Me.txt_VentasEfectivo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_VentasEfectivo.Location = New System.Drawing.Point(95, 18)
        Me.txt_VentasEfectivo.Name = "txt_VentasEfectivo"
        Me.txt_VentasEfectivo.ReadOnly = True
        Me.txt_VentasEfectivo.Size = New System.Drawing.Size(125, 21)
        Me.txt_VentasEfectivo.TabIndex = 12
        '
        'txt_CajaInicial
        '
        Me.txt_CajaInicial.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_CajaInicial.Location = New System.Drawing.Point(596, 45)
        Me.txt_CajaInicial.Name = "txt_CajaInicial"
        Me.txt_CajaInicial.ReadOnly = True
        Me.txt_CajaInicial.Size = New System.Drawing.Size(125, 21)
        Me.txt_CajaInicial.TabIndex = 6
        '
        'lblRetiros
        '
        Me.lblRetiros.AutoSize = True
        Me.lblRetiros.Location = New System.Drawing.Point(56, 261)
        Me.lblRetiros.Name = "lblRetiros"
        Me.lblRetiros.Size = New System.Drawing.Size(103, 15)
        Me.lblRetiros.TabIndex = 32
        Me.lblRetiros.Text = "Retiros de Socios"
        '
        'lblCaja
        '
        Me.lblCaja.AutoSize = True
        Me.lblCaja.Location = New System.Drawing.Point(418, 51)
        Me.lblCaja.Name = "lblCaja"
        Me.lblCaja.Size = New System.Drawing.Size(67, 15)
        Me.lblCaja.TabIndex = 31
        Me.lblCaja.Text = "Caja Inicial"
        '
        'txt_RetirosCaja
        '
        Me.txt_RetirosCaja.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_RetirosCaja.Location = New System.Drawing.Point(216, 258)
        Me.txt_RetirosCaja.Name = "txt_RetirosCaja"
        Me.txt_RetirosCaja.ReadOnly = True
        Me.txt_RetirosCaja.Size = New System.Drawing.Size(125, 21)
        Me.txt_RetirosCaja.TabIndex = 7
        '
        'txt_Mercaderias
        '
        Me.txt_Mercaderias.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_Mercaderias.Location = New System.Drawing.Point(216, 45)
        Me.txt_Mercaderias.Name = "txt_Mercaderias"
        Me.txt_Mercaderias.ReadOnly = True
        Me.txt_Mercaderias.Size = New System.Drawing.Size(125, 21)
        Me.txt_Mercaderias.TabIndex = 10
        '
        'Btn_Salir
        '
        Me.Btn_Salir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Salir.Image = Global.SistemaCinderella.My.Resources.Recursos.desconectado_32
        Me.Btn_Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Salir.Location = New System.Drawing.Point(12, 99)
        Me.Btn_Salir.Name = "Btn_Salir"
        Me.Btn_Salir.Size = New System.Drawing.Size(140, 39)
        Me.Btn_Salir.TabIndex = 17
        Me.Btn_Salir.Text = "Salir"
        Me.Btn_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolResumen.SetToolTip(Me.Btn_Salir, "Cerrar formulario")
        Me.Btn_Salir.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Btn_Limpiar)
        Me.GroupBox2.Controls.Add(Me.lblSucursalNombre)
        Me.GroupBox2.Controls.Add(Me.lblSucursal)
        Me.GroupBox2.Controls.Add(Me.txt_Fecha)
        Me.GroupBox2.Controls.Add(Me.Btn_Buscar)
        Me.GroupBox2.Controls.Add(Me.lblFechaD)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(475, 150)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Seleccione la fecha que desea visualizar el resumen diario."
        '
        'Btn_Limpiar
        '
        Me.Btn_Limpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Limpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Limpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Limpiar.Image = Global.SistemaCinderella.My.Resources.Recursos.Update_32
        Me.Btn_Limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Limpiar.Location = New System.Drawing.Point(337, 90)
        Me.Btn_Limpiar.Name = "Btn_Limpiar"
        Me.Btn_Limpiar.Size = New System.Drawing.Size(120, 39)
        Me.Btn_Limpiar.TabIndex = 3
        Me.Btn_Limpiar.Text = "Actualizar"
        Me.Btn_Limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolResumen.SetToolTip(Me.Btn_Limpiar, "Limpiar Formulario")
        Me.Btn_Limpiar.UseVisualStyleBackColor = True
        '
        'lblSucursalNombre
        '
        Me.lblSucursalNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSucursalNombre.AutoSize = True
        Me.lblSucursalNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSucursalNombre.Location = New System.Drawing.Point(70, 50)
        Me.lblSucursalNombre.Name = "lblSucursalNombre"
        Me.lblSucursalNombre.Size = New System.Drawing.Size(44, 16)
        Me.lblSucursalNombre.TabIndex = 1
        Me.lblSucursalNombre.Text = "- - - - "
        '
        'lblSucursal
        '
        Me.lblSucursal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSucursal.AutoSize = True
        Me.lblSucursal.Location = New System.Drawing.Point(6, 50)
        Me.lblSucursal.Name = "lblSucursal"
        Me.lblSucursal.Size = New System.Drawing.Size(55, 15)
        Me.lblSucursal.TabIndex = 14
        Me.lblSucursal.Text = "Sucursal"
        '
        'txt_Fecha
        '
        Me.txt_Fecha.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_Fecha.Location = New System.Drawing.Point(73, 86)
        Me.txt_Fecha.Name = "txt_Fecha"
        Me.txt_Fecha.Size = New System.Drawing.Size(243, 21)
        Me.txt_Fecha.TabIndex = 2
        '
        'Btn_Buscar
        '
        Me.Btn_Buscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Buscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Buscar.Image = Global.SistemaCinderella.My.Resources.Recursos.IconoBuscar32
        Me.Btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Buscar.Location = New System.Drawing.Point(337, 27)
        Me.Btn_Buscar.Name = "Btn_Buscar"
        Me.Btn_Buscar.Size = New System.Drawing.Size(120, 39)
        Me.Btn_Buscar.TabIndex = 4
        Me.Btn_Buscar.Text = "Buscar"
        Me.Btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolResumen.SetToolTip(Me.Btn_Buscar, "Consultar el resumen diario de otro día en particular.")
        Me.Btn_Buscar.UseVisualStyleBackColor = True
        '
        'lblFechaD
        '
        Me.lblFechaD.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblFechaD.AutoSize = True
        Me.lblFechaD.Location = New System.Drawing.Point(6, 91)
        Me.lblFechaD.Name = "lblFechaD"
        Me.lblFechaD.Size = New System.Drawing.Size(41, 15)
        Me.lblFechaD.TabIndex = 1
        Me.lblFechaD.Text = "Fecha"
        '
        'ToolResumen
        '
        Me.ToolResumen.IsBalloon = True
        Me.ToolResumen.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolResumen.ToolTipTitle = "Ayuda"
        '
        'Btn_Cerrar
        '
        Me.Btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Cerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Cerrar.Image = Global.SistemaCinderella.My.Resources.Recursos.CerrarCaja_32
        Me.Btn_Cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Cerrar.Location = New System.Drawing.Point(12, 58)
        Me.Btn_Cerrar.Name = "Btn_Cerrar"
        Me.Btn_Cerrar.Size = New System.Drawing.Size(140, 39)
        Me.Btn_Cerrar.TabIndex = 62
        Me.Btn_Cerrar.Text = "Cerrar Caja"
        Me.Btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolResumen.SetToolTip(Me.Btn_Cerrar, "Permite cerrar la caja diaria. Tener en cuenta que ésta operación deberá " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "llevar" & _
        "se a cabo sólo al finalizar el día.")
        Me.Btn_Cerrar.UseVisualStyleBackColor = True
        '
        'Btn_Abrir
        '
        Me.Btn_Abrir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Abrir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Abrir.Enabled = False
        Me.Btn_Abrir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Abrir.Image = Global.SistemaCinderella.My.Resources.Recursos.AbrirCaja_32
        Me.Btn_Abrir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Abrir.Location = New System.Drawing.Point(12, 17)
        Me.Btn_Abrir.Name = "Btn_Abrir"
        Me.Btn_Abrir.Size = New System.Drawing.Size(140, 39)
        Me.Btn_Abrir.TabIndex = 63
        Me.Btn_Abrir.Text = "Abrir Caja"
        Me.Btn_Abrir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolResumen.SetToolTip(Me.Btn_Abrir, resources.GetString("Btn_Abrir.ToolTip"))
        Me.Btn_Abrir.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 15)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "Fecha"
        '
        'GB_Caja
        '
        Me.GB_Caja.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_Caja.Controls.Add(Me.lbl_Empleado)
        Me.GB_Caja.Controls.Add(Me.lbl_Abierta)
        Me.GB_Caja.Controls.Add(Me.lbl_Hora)
        Me.GB_Caja.Controls.Add(Me.lbl_Fecha)
        Me.GB_Caja.Controls.Add(Me.Label9)
        Me.GB_Caja.Controls.Add(Me.Label8)
        Me.GB_Caja.Controls.Add(Me.Label7)
        Me.GB_Caja.Location = New System.Drawing.Point(13, 468)
        Me.GB_Caja.Name = "GB_Caja"
        Me.GB_Caja.Size = New System.Drawing.Size(521, 87)
        Me.GB_Caja.TabIndex = 65
        Me.GB_Caja.TabStop = False
        Me.GB_Caja.Text = "Caja Cerrada"
        Me.GB_Caja.Visible = False
        '
        'lbl_Empleado
        '
        Me.lbl_Empleado.AutoSize = True
        Me.lbl_Empleado.Location = New System.Drawing.Point(358, 46)
        Me.lbl_Empleado.Name = "lbl_Empleado"
        Me.lbl_Empleado.Size = New System.Drawing.Size(57, 15)
        Me.lbl_Empleado.TabIndex = 69
        Me.lbl_Empleado.Text = "Gutierrez"
        '
        'lbl_Abierta
        '
        Me.lbl_Abierta.AutoSize = True
        Me.lbl_Abierta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Abierta.ForeColor = System.Drawing.Color.Red
        Me.lbl_Abierta.Location = New System.Drawing.Point(418, 67)
        Me.lbl_Abierta.Name = "lbl_Abierta"
        Me.lbl_Abierta.Size = New System.Drawing.Size(92, 15)
        Me.lbl_Abierta.TabIndex = 70
        Me.lbl_Abierta.Text = "Caja Reabierta."
        '
        'lbl_Hora
        '
        Me.lbl_Hora.AutoSize = True
        Me.lbl_Hora.Location = New System.Drawing.Point(199, 44)
        Me.lbl_Hora.Name = "lbl_Hora"
        Me.lbl_Hora.Size = New System.Drawing.Size(59, 15)
        Me.lbl_Hora.TabIndex = 68
        Me.lbl_Hora.Text = "12:30 AM"
        '
        'lbl_Fecha
        '
        Me.lbl_Fecha.AutoSize = True
        Me.lbl_Fecha.Location = New System.Drawing.Point(6, 44)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(69, 15)
        Me.lbl_Fecha.TabIndex = 67
        Me.lbl_Fecha.Text = "10/10/1987"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(358, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 15)
        Me.Label9.TabIndex = 66
        Me.Label9.Text = "Cerrada por"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(199, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 15)
        Me.Label8.TabIndex = 65
        Me.Label8.Text = "Hora"
        '
        'GB_Monto
        '
        Me.GB_Monto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_Monto.Controls.Add(Me.lbl_Saldo)
        Me.GB_Monto.Location = New System.Drawing.Point(540, 470)
        Me.GB_Monto.Name = "GB_Monto"
        Me.GB_Monto.Size = New System.Drawing.Size(140, 85)
        Me.GB_Monto.TabIndex = 66
        Me.GB_Monto.TabStop = False
        Me.GB_Monto.Text = "Caja Chica"
        '
        'lbl_Saldo
        '
        Me.lbl_Saldo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Saldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Saldo.Location = New System.Drawing.Point(3, 17)
        Me.lbl_Saldo.Name = "lbl_Saldo"
        Me.lbl_Saldo.Size = New System.Drawing.Size(134, 65)
        Me.lbl_Saldo.TabIndex = 0
        Me.lbl_Saldo.Text = "$ 100.000.-"
        Me.lbl_Saldo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.lbl_DispoCheq)
        Me.GroupBox1.Location = New System.Drawing.Point(686, 470)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(140, 85)
        Me.GroupBox1.TabIndex = 67
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Disp. Cheque"
        '
        'lbl_DispoCheq
        '
        Me.lbl_DispoCheq.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_DispoCheq.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DispoCheq.Location = New System.Drawing.Point(3, 17)
        Me.lbl_DispoCheq.Name = "lbl_DispoCheq"
        Me.lbl_DispoCheq.Size = New System.Drawing.Size(134, 65)
        Me.lbl_DispoCheq.TabIndex = 0
        Me.lbl_DispoCheq.Text = "$ 100.000.-"
        Me.lbl_DispoCheq.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtMonto)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Btn_Abrir)
        Me.GroupBox3.Controls.Add(Me.Btn_Cerrar)
        Me.GroupBox3.Controls.Add(Me.Btn_Salir)
        Me.GroupBox3.Location = New System.Drawing.Point(494, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(475, 150)
        Me.GroupBox3.TabIndex = 71
        Me.GroupBox3.TabStop = False
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(275, 83)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(194, 21)
        Me.txtMonto.TabIndex = 66
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(171, 86)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(98, 15)
        Me.Label14.TabIndex = 65
        Me.Label14.Text = "Importe Físico"
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(174, 17)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(295, 65)
        Me.Label13.TabIndex = 64
        Me.Label13.Text = "Por favor, ingrese el monto físico que se encuentra en la sucursal para cerrar la" & _
    " caja."
        '
        'ErrorResumen
        '
        Me.ErrorResumen.BlinkRate = 200
        Me.ErrorResumen.ContainerControl = Me
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.lbl_DispoEfect)
        Me.GroupBox4.Location = New System.Drawing.Point(832, 470)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(140, 85)
        Me.GroupBox4.TabIndex = 68
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Disp. Efectivo"
        '
        'lbl_DispoEfect
        '
        Me.lbl_DispoEfect.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_DispoEfect.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DispoEfect.Location = New System.Drawing.Point(3, 17)
        Me.lbl_DispoEfect.Name = "lbl_DispoEfect"
        Me.lbl_DispoEfect.Size = New System.Drawing.Size(134, 65)
        Me.lbl_DispoEfect.TabIndex = 0
        Me.lbl_DispoEfect.Text = "$ 100.000.-"
        Me.lbl_DispoEfect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txt_VentasCheque)
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Controls.Add(Me.txt_VentasEfectivo)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.txt_VentasTarjeta)
        Me.GroupBox5.Controls.Add(Me.lbl_Faltante)
        Me.GroupBox5.Controls.Add(Me.txt_TotalFacturado)
        Me.GroupBox5.Controls.Add(Me.lblTotalFacturado)
        Me.GroupBox5.Controls.Add(Me.txt_VentaMinorista)
        Me.GroupBox5.Controls.Add(Me.lblMinorista)
        Me.GroupBox5.Controls.Add(Me.txt_VentaMayorista)
        Me.GroupBox5.Controls.Add(Me.lblMayorista)
        Me.GroupBox5.Location = New System.Drawing.Point(745, 169)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(226, 295)
        Me.GroupBox5.TabIndex = 72
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Detalle Ventas"
        '
        'txt_VentasCheque
        '
        Me.txt_VentasCheque.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_VentasCheque.Location = New System.Drawing.Point(96, 45)
        Me.txt_VentasCheque.Name = "txt_VentasCheque"
        Me.txt_VentasCheque.ReadOnly = True
        Me.txt_VentasCheque.Size = New System.Drawing.Size(125, 21)
        Me.txt_VentasCheque.TabIndex = 58
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(8, 51)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(50, 15)
        Me.Label18.TabIndex = 59
        Me.Label18.Text = "Cheque"
        '
        'frmResumenDiario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 566)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GB_Monto)
        Me.Controls.Add(Me.GB_Caja)
        Me.Controls.Add(Me.GbDetalle)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmResumenDiario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Resumen Diario"
        Me.GbDetalle.ResumeLayout(False)
        Me.GbDetalle.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GB_Caja.ResumeLayout(False)
        Me.GB_Caja.PerformLayout()
        Me.GB_Monto.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.ErrorResumen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GbDetalle As System.Windows.Forms.GroupBox
    Friend WithEvents txt_TotalVentas As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalVentas As System.Windows.Forms.Label
    Friend WithEvents lblMayorista As System.Windows.Forms.Label
    Friend WithEvents txt_VentaMayorista As System.Windows.Forms.TextBox
    Friend WithEvents lblMinorista As System.Windows.Forms.Label
    Friend WithEvents txt_VentaMinorista As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalFacturado As System.Windows.Forms.Label
    Friend WithEvents txt_TotalFacturado As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_Gastos As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Faltante As System.Windows.Forms.Label
    Friend WithEvents txt_VentasTarjeta As System.Windows.Forms.TextBox
    Friend WithEvents txt_Sueldo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblMercaderias As System.Windows.Forms.Label
    Friend WithEvents txt_VentasEfectivo As System.Windows.Forms.TextBox
    Friend WithEvents txt_CajaInicial As System.Windows.Forms.TextBox
    Friend WithEvents lblRetiros As System.Windows.Forms.Label
    Friend WithEvents lblCaja As System.Windows.Forms.Label
    Friend WithEvents txt_RetirosCaja As System.Windows.Forms.TextBox
    Friend WithEvents txt_Mercaderias As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_Limpiar As System.Windows.Forms.Button
    Friend WithEvents lblSucursalNombre As System.Windows.Forms.Label
    Friend WithEvents lblSucursal As System.Windows.Forms.Label
    Friend WithEvents txt_Fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents lblFechaD As System.Windows.Forms.Label
    Friend WithEvents Btn_Salir As System.Windows.Forms.Button
    Friend WithEvents ToolResumen As System.Windows.Forms.ToolTip
    Friend WithEvents Btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents Btn_Abrir As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_EfectivoEgreso As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_Impuesto As System.Windows.Forms.TextBox
    Friend WithEvents lblVarios As System.Windows.Forms.Label
    Friend WithEvents txt_Sobrante As System.Windows.Forms.TextBox
    Friend WithEvents lblEgresos As System.Windows.Forms.Label
    Friend WithEvents lblIngresos As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_Faltante As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GB_Caja As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Empleado As System.Windows.Forms.Label
    Friend WithEvents lbl_Hora As System.Windows.Forms.Label
    Friend WithEvents lbl_Fecha As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GB_Monto As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Saldo As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_Efectivo As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Abierta As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_DispoCheq As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_CajaFuerteIng As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_CajaFuerteEgr As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents ErrorResumen As System.Windows.Forms.ErrorProvider
    Friend WithEvents txt_DevolucionesEgr As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txt_Adicional As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_DispoEfect As System.Windows.Forms.Label
    Friend WithEvents txt_Aporte As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_VentasCheque As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
End Class
