﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblTotalVentas = New System.Windows.Forms.Label()
        Me.txt_Efectivo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_CajaFuerteIng = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_Aporte = New System.Windows.Forms.TextBox()
        Me.txt_TotalVentas = New System.Windows.Forms.TextBox()
        Me.txt_Sobrante = New System.Windows.Forms.TextBox()
        Me.lblVarios = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblCaja = New System.Windows.Forms.Label()
        Me.txt_CajaInicial = New System.Windows.Forms.TextBox()
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
        Me.lblMayorista = New System.Windows.Forms.Label()
        Me.txt_VentaMayorista = New System.Windows.Forms.TextBox()
        Me.lblMinorista = New System.Windows.Forms.Label()
        Me.txt_VentaMinorista = New System.Windows.Forms.TextBox()
        Me.lblTotalFacturado = New System.Windows.Forms.Label()
        Me.txt_TotalFacturado = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_VentasEfectivo = New System.Windows.Forms.TextBox()
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
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_VentasDebito = New System.Windows.Forms.TextBox()
        Me.txt_VentasCredito = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_VentasCheque = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.GbDetalle.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GB_Caja.SuspendLayout()
        Me.GB_Monto.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ErrorResumen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.SuspendLayout()
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
        Me.GbDetalle.Text = "Resumen Diario"
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
        Me.TableLayoutPanel2.Controls.Add(Me.txt_CajaFuerteIng, 1, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.Label12, 0, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_Aporte, 1, 8)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_TotalVentas, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_Sobrante, 1, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.lblVarios, 0, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.Label17, 0, 8)
        Me.TableLayoutPanel2.Controls.Add(Me.lblCaja, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_CajaInicial, 1, 1)
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
        'txt_CajaFuerteIng
        '
        Me.txt_CajaFuerteIng.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_CajaFuerteIng.Location = New System.Drawing.Point(163, 178)
        Me.txt_CajaFuerteIng.Name = "txt_CajaFuerteIng"
        Me.txt_CajaFuerteIng.ReadOnly = True
        Me.txt_CajaFuerteIng.Size = New System.Drawing.Size(146, 21)
        Me.txt_CajaFuerteIng.TabIndex = 76
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 180)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(154, 15)
        Me.Label12.TabIndex = 77
        Me.Label12.Text = "Egreso de Caja Fuerte"
        '
        'txt_Aporte
        '
        Me.txt_Aporte.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Aporte.Location = New System.Drawing.Point(163, 203)
        Me.txt_Aporte.Name = "txt_Aporte"
        Me.txt_Aporte.ReadOnly = True
        Me.txt_Aporte.Size = New System.Drawing.Size(146, 21)
        Me.txt_Aporte.TabIndex = 82
        '
        'txt_TotalVentas
        '
        Me.txt_TotalVentas.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_TotalVentas.Location = New System.Drawing.Point(163, 3)
        Me.txt_TotalVentas.Name = "txt_TotalVentas"
        Me.txt_TotalVentas.ReadOnly = True
        Me.txt_TotalVentas.Size = New System.Drawing.Size(146, 21)
        Me.txt_TotalVentas.TabIndex = 11
        '
        'txt_Sobrante
        '
        Me.txt_Sobrante.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Sobrante.Location = New System.Drawing.Point(163, 153)
        Me.txt_Sobrante.Name = "txt_Sobrante"
        Me.txt_Sobrante.ReadOnly = True
        Me.txt_Sobrante.Size = New System.Drawing.Size(146, 21)
        Me.txt_Sobrante.TabIndex = 66
        '
        'lblVarios
        '
        Me.lblVarios.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVarios.AutoSize = True
        Me.lblVarios.Location = New System.Drawing.Point(3, 155)
        Me.lblVarios.Name = "lblVarios"
        Me.lblVarios.Size = New System.Drawing.Size(154, 15)
        Me.lblVarios.TabIndex = 67
        Me.lblVarios.Text = "Sobrante de Caja"
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(3, 205)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(154, 15)
        Me.Label17.TabIndex = 83
        Me.Label17.Text = "Aporte de Socios"
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
        Me.txt_CajaInicial.Location = New System.Drawing.Point(163, 28)
        Me.txt_CajaInicial.Name = "txt_CajaInicial"
        Me.txt_CajaInicial.ReadOnly = True
        Me.txt_CajaInicial.Size = New System.Drawing.Size(146, 21)
        Me.txt_CajaInicial.TabIndex = 6
        '
        'lblEgresos
        '
        Me.lblEgresos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEgresos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEgresos.Image = Global.SistemaCinderella.My.Resources.Recursos.Egreso_32
        Me.lblEgresos.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblEgresos.Location = New System.Drawing.Point(3, 0)
        Me.lblEgresos.Name = "lblEgresos"
        Me.lblEgresos.Size = New System.Drawing.Size(34, 188)
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
        Me.lblIngresos.Size = New System.Drawing.Size(34, 202)
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
        Me.txt_EfectivoEgreso.Location = New System.Drawing.Point(163, 128)
        Me.txt_EfectivoEgreso.Name = "txt_EfectivoEgreso"
        Me.txt_EfectivoEgreso.ReadOnly = True
        Me.txt_EfectivoEgreso.Size = New System.Drawing.Size(146, 21)
        Me.txt_EfectivoEgreso.TabIndex = 63
        '
        'lblMayorista
        '
        Me.lblMayorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMayorista.AutoSize = True
        Me.lblMayorista.Location = New System.Drawing.Point(3, 233)
        Me.lblMayorista.Name = "lblMayorista"
        Me.lblMayorista.Size = New System.Drawing.Size(69, 15)
        Me.lblMayorista.TabIndex = 57
        Me.lblMayorista.Text = "Mayorista"
        '
        'txt_VentaMayorista
        '
        Me.txt_VentaMayorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_VentaMayorista.Location = New System.Drawing.Point(78, 230)
        Me.txt_VentaMayorista.Name = "txt_VentaMayorista"
        Me.txt_VentaMayorista.ReadOnly = True
        Me.txt_VentaMayorista.Size = New System.Drawing.Size(141, 21)
        Me.txt_VentaMayorista.TabIndex = 15
        '
        'lblMinorista
        '
        Me.lblMinorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMinorista.AutoSize = True
        Me.lblMinorista.Location = New System.Drawing.Point(3, 196)
        Me.lblMinorista.Name = "lblMinorista"
        Me.lblMinorista.Size = New System.Drawing.Size(69, 15)
        Me.lblMinorista.TabIndex = 54
        Me.lblMinorista.Text = "Minorista"
        '
        'txt_VentaMinorista
        '
        Me.txt_VentaMinorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_VentaMinorista.Location = New System.Drawing.Point(78, 193)
        Me.txt_VentaMinorista.Name = "txt_VentaMinorista"
        Me.txt_VentaMinorista.ReadOnly = True
        Me.txt_VentaMinorista.Size = New System.Drawing.Size(141, 21)
        Me.txt_VentaMinorista.TabIndex = 16
        '
        'lblTotalFacturado
        '
        Me.lblTotalFacturado.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalFacturado.AutoSize = True
        Me.lblTotalFacturado.Location = New System.Drawing.Point(3, 159)
        Me.lblTotalFacturado.Name = "lblTotalFacturado"
        Me.lblTotalFacturado.Size = New System.Drawing.Size(69, 15)
        Me.lblTotalFacturado.TabIndex = 51
        Me.lblTotalFacturado.Text = "Facturado"
        '
        'txt_TotalFacturado
        '
        Me.txt_TotalFacturado.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_TotalFacturado.Location = New System.Drawing.Point(78, 156)
        Me.txt_TotalFacturado.Name = "txt_TotalFacturado"
        Me.txt_TotalFacturado.ReadOnly = True
        Me.txt_TotalFacturado.Size = New System.Drawing.Size(141, 21)
        Me.txt_TotalFacturado.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 15)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Efectivo"
        '
        'txt_VentasEfectivo
        '
        Me.txt_VentasEfectivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_VentasEfectivo.Location = New System.Drawing.Point(78, 8)
        Me.txt_VentasEfectivo.Name = "txt_VentasEfectivo"
        Me.txt_VentasEfectivo.ReadOnly = True
        Me.txt_VentasEfectivo.Size = New System.Drawing.Size(141, 21)
        Me.txt_VentasEfectivo.TabIndex = 12
        '
        'Btn_Salir
        '
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
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(475, 153)
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
        Me.txt_Fecha.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.ToolResumen.SetToolTip(Me.Btn_Cerrar, "Permite cerrar la caja diaria. Tener en cuenta que ésta operación deberá " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "llevar" &
        "se a cabo sólo al finalizar el día.")
        Me.Btn_Cerrar.UseVisualStyleBackColor = True
        '
        'Btn_Abrir
        '
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
        Me.GB_Caja.Controls.Add(Me.lbl_Empleado)
        Me.GB_Caja.Controls.Add(Me.lbl_Abierta)
        Me.GB_Caja.Controls.Add(Me.lbl_Hora)
        Me.GB_Caja.Controls.Add(Me.lbl_Fecha)
        Me.GB_Caja.Controls.Add(Me.Label9)
        Me.GB_Caja.Controls.Add(Me.Label8)
        Me.GB_Caja.Controls.Add(Me.Label7)
        Me.GB_Caja.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GB_Caja.Location = New System.Drawing.Point(3, 3)
        Me.GB_Caja.Name = "GB_Caja"
        Me.GB_Caja.Size = New System.Drawing.Size(506, 94)
        Me.GB_Caja.TabIndex = 65
        Me.GB_Caja.TabStop = False
        Me.GB_Caja.Text = "Caja Cerrada"
        Me.GB_Caja.Visible = False
        '
        'lbl_Empleado
        '
        Me.lbl_Empleado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.lbl_Hora.Anchor = System.Windows.Forms.AnchorStyles.Top
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
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
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
        Me.GB_Monto.Controls.Add(Me.lbl_Saldo)
        Me.GB_Monto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GB_Monto.Location = New System.Drawing.Point(515, 3)
        Me.GB_Monto.Name = "GB_Monto"
        Me.GB_Monto.Size = New System.Drawing.Size(142, 94)
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
        Me.lbl_Saldo.Size = New System.Drawing.Size(136, 74)
        Me.lbl_Saldo.TabIndex = 0
        Me.lbl_Saldo.Text = "$ 100.000.-"
        Me.lbl_Saldo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_DispoCheq)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(663, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(146, 94)
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
        Me.lbl_DispoCheq.Size = New System.Drawing.Size(140, 74)
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
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(484, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(475, 153)
        Me.GroupBox3.TabIndex = 71
        Me.GroupBox3.TabStop = False
        '
        'txtMonto
        '
        Me.txtMonto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.Label13.Text = "Por favor, ingrese el monto físico que se encuentra en la sucursal para cerrar la" &
    " caja."
        '
        'ErrorResumen
        '
        Me.ErrorResumen.BlinkRate = 200
        Me.ErrorResumen.ContainerControl = Me
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lbl_DispoEfect)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Location = New System.Drawing.Point(815, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(144, 94)
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
        Me.lbl_DispoEfect.Size = New System.Drawing.Size(138, 74)
        Me.lbl_DispoEfect.TabIndex = 0
        Me.lbl_DispoEfect.Text = "$ 100.000.-"
        Me.lbl_DispoEfect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.GroupBox5.Text = "Detalle Ventas"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.txt_VentaMayorista, 1, 6)
        Me.TableLayoutPanel3.Controls.Add(Me.txt_VentaMinorista, 1, 5)
        Me.TableLayoutPanel3.Controls.Add(Me.lblMayorista, 0, 6)
        Me.TableLayoutPanel3.Controls.Add(Me.txt_TotalFacturado, 1, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.lblMinorista, 0, 5)
        Me.TableLayoutPanel3.Controls.Add(Me.txt_VentasDebito, 1, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.lblTotalFacturado, 0, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.txt_VentasCredito, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Label19, 0, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label16, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.txt_VentasEfectivo, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label18, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.txt_VentasCheque, 1, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 17)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 7
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(222, 260)
        Me.TableLayoutPanel3.TabIndex = 87
        '
        'txt_VentasDebito
        '
        Me.txt_VentasDebito.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_VentasDebito.Location = New System.Drawing.Point(78, 119)
        Me.txt_VentasDebito.Name = "txt_VentasDebito"
        Me.txt_VentasDebito.ReadOnly = True
        Me.txt_VentasDebito.Size = New System.Drawing.Size(141, 21)
        Me.txt_VentasDebito.TabIndex = 72
        '
        'txt_VentasCredito
        '
        Me.txt_VentasCredito.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_VentasCredito.Location = New System.Drawing.Point(78, 82)
        Me.txt_VentasCredito.Name = "txt_VentasCredito"
        Me.txt_VentasCredito.ReadOnly = True
        Me.txt_VentasCredito.Size = New System.Drawing.Size(141, 21)
        Me.txt_VentasCredito.TabIndex = 70
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(3, 122)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(69, 15)
        Me.Label19.TabIndex = 73
        Me.Label19.Text = "Debito"
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(3, 85)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(69, 15)
        Me.Label16.TabIndex = 71
        Me.Label16.Text = "Credito"
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(3, 48)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(69, 15)
        Me.Label18.TabIndex = 59
        Me.Label18.Text = "Cheque"
        '
        'txt_VentasCheque
        '
        Me.txt_VentasCheque.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_VentasCheque.Location = New System.Drawing.Point(78, 45)
        Me.txt_VentasCheque.Name = "txt_VentasCheque"
        Me.txt_VentasCheque.ReadOnly = True
        Me.txt_VentasCheque.Size = New System.Drawing.Size(141, 21)
        Me.txt_VentasCheque.TabIndex = 58
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel5.ColumnCount = 4
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.22245!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.38461!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.80042!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.48857!))
        Me.TableLayoutPanel5.Controls.Add(Me.GB_Monto, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.GroupBox4, 3, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.GroupBox1, 2, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.GB_Caja, 0, 0)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(12, 454)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(962, 100)
        Me.TableLayoutPanel5.TabIndex = 73
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel6.ColumnCount = 2
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.GroupBox3, 1, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.GroupBox2, 0, 0)
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(12, 3)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 159.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(962, 159)
        Me.TableLayoutPanel6.TabIndex = 74
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
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(12, 165)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(962, 286)
        Me.TableLayoutPanel7.TabIndex = 74
        '
        'frmResumenDiario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 562)
        Me.Controls.Add(Me.TableLayoutPanel7)
        Me.Controls.Add(Me.TableLayoutPanel6)
        Me.Controls.Add(Me.TableLayoutPanel5)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmResumenDiario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Resumen Diario"
        Me.GbDetalle.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
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
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel7.ResumeLayout(False)
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
    Friend WithEvents txt_Devoluciones As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_DispoEfect As System.Windows.Forms.Label
    Friend WithEvents txt_Aporte As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_VentasCheque As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txt_VentasCredito As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txt_VentasDebito As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txt_PendienteAutorizar As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
End Class