<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSucursalesSaldos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSucursalesSaldos))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Btn_Salir = New System.Windows.Forms.Button()
        Me.Btn_Limpiar = New System.Windows.Forms.Button()
        Me.lblSucursalNombre = New System.Windows.Forms.Label()
        Me.lblSucursal = New System.Windows.Forms.Label()
        Me.txt_FDesde = New System.Windows.Forms.DateTimePicker()
        Me.txt_FHasta = New System.Windows.Forms.DateTimePicker()
        Me.Btn_Buscar = New System.Windows.Forms.Button()
        Me.lblFechaH = New System.Windows.Forms.Label()
        Me.lblFechaD = New System.Windows.Forms.Label()
        Me.GbDetalle = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lbl_TotalIngresos = New System.Windows.Forms.Label()
        Me.lbl_DisponibleTotal = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblVentas = New System.Windows.Forms.Label()
        Me.Btn_Aporte = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.txt_Aporte = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_Venta = New System.Windows.Forms.TextBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Btn_Venta = New System.Windows.Forms.Button()
        Me.lblEfectivo = New System.Windows.Forms.Label()
        Me.txt_Efectivo = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Btn_EfectivoIngreso = New System.Windows.Forms.Button()
        Me.lblVarios = New System.Windows.Forms.Label()
        Me.txt_Sobrante = New System.Windows.Forms.TextBox()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Btn_Sobrante = New System.Windows.Forms.Button()
        Me.lblEgresos = New System.Windows.Forms.Label()
        Me.lblIngresos = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Btn_Devoluciones = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.txt_PendienteAutorizar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_DevolucionesEgr = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.lbl_Faltante = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.lbl_Retiro = New System.Windows.Forms.Label()
        Me.txt_Mercaderias = New System.Windows.Forms.TextBox()
        Me.Btn_Retiro = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_Sueldo = New System.Windows.Forms.TextBox()
        Me.txt_Gasto = New System.Windows.Forms.TextBox()
        Me.Btn_Faltante = New System.Windows.Forms.Button()
        Me.txt_Impuesto = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Btn_EfectivoEgreso = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.txt_EfectivoEgreso = New System.Windows.Forms.TextBox()
        Me.txt_Faltante = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.txt_Retiro = New System.Windows.Forms.TextBox()
        Me.Btn_Sueldo = New System.Windows.Forms.Button()
        Me.Btn_Gasto = New System.Windows.Forms.Button()
        Me.Btn_Impuesto = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lbl_TotalEgresos = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_Saldo = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_VentasFacturado = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_VentasCheque = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_VentasDebito = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_VentasCredito = New System.Windows.Forms.TextBox()
        Me.lbl_Efectivo = New System.Windows.Forms.Label()
        Me.txt_VentasEfectivo = New System.Windows.Forms.TextBox()
        Me.lblMayorista = New System.Windows.Forms.Label()
        Me.txt_VentaMayorista = New System.Windows.Forms.TextBox()
        Me.lblMinorista = New System.Windows.Forms.Label()
        Me.txt_VentaMinorista = New System.Windows.Forms.TextBox()
        Me.ToolEstado = New System.Windows.Forms.ToolTip(Me.components)
        Me.GbDetalleVenta = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel9 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox2.SuspendLayout()
        Me.GbDetalle.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GbDetalleVenta.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.TableLayoutPanel9.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Btn_Salir)
        Me.GroupBox2.Controls.Add(Me.Btn_Limpiar)
        Me.GroupBox2.Controls.Add(Me.lblSucursalNombre)
        Me.GroupBox2.Controls.Add(Me.lblSucursal)
        Me.GroupBox2.Controls.Add(Me.txt_FDesde)
        Me.GroupBox2.Controls.Add(Me.txt_FHasta)
        Me.GroupBox2.Controls.Add(Me.Btn_Buscar)
        Me.GroupBox2.Controls.Add(Me.lblFechaH)
        Me.GroupBox2.Controls.Add(Me.lblFechaD)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(10, 11)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1032, 120)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Seleccionar el rango de fechas para visualizar los movimientos."
        '
        'Btn_Salir
        '
        Me.Btn_Salir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Salir.Image = Global.SistemaCinderella.My.Resources.Recursos.desconectado_32
        Me.Btn_Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Salir.Location = New System.Drawing.Point(762, 44)
        Me.Btn_Salir.Name = "Btn_Salir"
        Me.Btn_Salir.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Salir.TabIndex = 15
        Me.Btn_Salir.Text = "Salir"
        Me.Btn_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Salir.UseVisualStyleBackColor = True
        '
        'Btn_Limpiar
        '
        Me.Btn_Limpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Limpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Limpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Limpiar.Image = Global.SistemaCinderella.My.Resources.Recursos.Limpiar_32
        Me.Btn_Limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Limpiar.Location = New System.Drawing.Point(639, 44)
        Me.Btn_Limpiar.Name = "Btn_Limpiar"
        Me.Btn_Limpiar.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Limpiar.TabIndex = 5
        Me.Btn_Limpiar.Text = "Borrar"
        Me.Btn_Limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Limpiar.UseVisualStyleBackColor = True
        '
        'lblSucursalNombre
        '
        Me.lblSucursalNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSucursalNombre.AutoSize = True
        Me.lblSucursalNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSucursalNombre.Location = New System.Drawing.Point(115, 27)
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
        Me.lblSucursal.Location = New System.Drawing.Point(15, 28)
        Me.lblSucursal.Name = "lblSucursal"
        Me.lblSucursal.Size = New System.Drawing.Size(55, 15)
        Me.lblSucursal.TabIndex = 14
        Me.lblSucursal.Text = "Sucursal"
        '
        'txt_FDesde
        '
        Me.txt_FDesde.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_FDesde.Location = New System.Drawing.Point(117, 51)
        Me.txt_FDesde.Name = "txt_FDesde"
        Me.txt_FDesde.Size = New System.Drawing.Size(245, 21)
        Me.txt_FDesde.TabIndex = 2
        '
        'txt_FHasta
        '
        Me.txt_FHasta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_FHasta.Location = New System.Drawing.Point(117, 86)
        Me.txt_FHasta.Name = "txt_FHasta"
        Me.txt_FHasta.Size = New System.Drawing.Size(245, 21)
        Me.txt_FHasta.TabIndex = 3
        '
        'Btn_Buscar
        '
        Me.Btn_Buscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Buscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Buscar.Image = Global.SistemaCinderella.My.Resources.Recursos.IconoBuscar32
        Me.Btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Buscar.Location = New System.Drawing.Point(517, 44)
        Me.Btn_Buscar.Name = "Btn_Buscar"
        Me.Btn_Buscar.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Buscar.TabIndex = 4
        Me.Btn_Buscar.Text = "Buscar"
        Me.Btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Buscar.UseVisualStyleBackColor = True
        '
        'lblFechaH
        '
        Me.lblFechaH.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblFechaH.AutoSize = True
        Me.lblFechaH.Location = New System.Drawing.Point(15, 91)
        Me.lblFechaH.Name = "lblFechaH"
        Me.lblFechaH.Size = New System.Drawing.Size(76, 15)
        Me.lblFechaH.TabIndex = 2
        Me.lblFechaH.Text = "Fecha Hasta"
        '
        'lblFechaD
        '
        Me.lblFechaD.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblFechaD.AutoSize = True
        Me.lblFechaD.Location = New System.Drawing.Point(15, 57)
        Me.lblFechaD.Name = "lblFechaD"
        Me.lblFechaD.Size = New System.Drawing.Size(80, 15)
        Me.lblFechaD.TabIndex = 1
        Me.lblFechaD.Text = "Fecha Desde"
        '
        'GbDetalle
        '
        Me.GbDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GbDetalle.Controls.Add(Me.TableLayoutPanel8)
        Me.GbDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbDetalle.Location = New System.Drawing.Point(3, 3)
        Me.GbDetalle.Name = "GbDetalle"
        Me.GbDetalle.Size = New System.Drawing.Size(818, 406)
        Me.GbDetalle.TabIndex = 2
        Me.GbDetalle.TabStop = False
        Me.GbDetalle.Text = "Detalle del período solicitado"
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.ColumnCount = 4
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.TableLayoutPanel6, 3, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.lblEgresos, 0, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.lblIngresos, 2, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.TableLayoutPanel3, 1, 0)
        Me.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(3, 17)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 1
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(812, 386)
        Me.TableLayoutPanel8.TabIndex = 4
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 1
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.TableLayoutPanel5, 0, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.TableLayoutPanel4, 0, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(449, 3)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 2
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(360, 380)
        Me.TableLayoutPanel6.TabIndex = 76
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.Label13, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.lbl_TotalIngresos, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.lbl_DisponibleTotal, 1, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.Label15, 0, 1)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 288)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(354, 89)
        Me.TableLayoutPanel5.TabIndex = 76
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(3, 10)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(171, 24)
        Me.Label13.TabIndex = 80
        Me.Label13.Text = "Total:"
        '
        'lbl_TotalIngresos
        '
        Me.lbl_TotalIngresos.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_TotalIngresos.AutoSize = True
        Me.lbl_TotalIngresos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TotalIngresos.Location = New System.Drawing.Point(180, 10)
        Me.lbl_TotalIngresos.Name = "lbl_TotalIngresos"
        Me.lbl_TotalIngresos.Size = New System.Drawing.Size(171, 24)
        Me.lbl_TotalIngresos.TabIndex = 81
        Me.lbl_TotalIngresos.Text = "$ 3.000.000.-"
        '
        'lbl_DisponibleTotal
        '
        Me.lbl_DisponibleTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_DisponibleTotal.AutoSize = True
        Me.lbl_DisponibleTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lbl_DisponibleTotal.Location = New System.Drawing.Point(180, 54)
        Me.lbl_DisponibleTotal.Name = "lbl_DisponibleTotal"
        Me.lbl_DisponibleTotal.Size = New System.Drawing.Size(171, 24)
        Me.lbl_DisponibleTotal.TabIndex = 85
        Me.lbl_DisponibleTotal.Text = "$ 3.000.000.-"
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(3, 52)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(171, 29)
        Me.Label15.TabIndex = 84
        Me.Label15.Text = "Disponible:"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 4
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.lblVentas, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Btn_Aporte, 3, 5)
        Me.TableLayoutPanel4.Controls.Add(Me.Button15, 2, 5)
        Me.TableLayoutPanel4.Controls.Add(Me.txt_Aporte, 1, 5)
        Me.TableLayoutPanel4.Controls.Add(Me.Label16, 0, 5)
        Me.TableLayoutPanel4.Controls.Add(Me.txt_Venta, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Button8, 2, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Btn_Venta, 3, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.lblEfectivo, 0, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.txt_Efectivo, 1, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.Button2, 2, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.Btn_EfectivoIngreso, 3, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.lblVarios, 0, 4)
        Me.TableLayoutPanel4.Controls.Add(Me.txt_Sobrante, 1, 4)
        Me.TableLayoutPanel4.Controls.Add(Me.Button10, 2, 4)
        Me.TableLayoutPanel4.Controls.Add(Me.Btn_Sobrante, 3, 4)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 9
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(354, 279)
        Me.TableLayoutPanel4.TabIndex = 104
        '
        'lblVentas
        '
        Me.lblVentas.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVentas.AutoSize = True
        Me.lblVentas.Location = New System.Drawing.Point(3, 8)
        Me.lblVentas.Name = "lblVentas"
        Me.lblVentas.Size = New System.Drawing.Size(134, 15)
        Me.lblVentas.TabIndex = 31
        Me.lblVentas.Text = "Totales Ventas"
        '
        'Btn_Aporte
        '
        Me.Btn_Aporte.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Aporte.FlatAppearance.BorderSize = 0
        Me.Btn_Aporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Aporte.Image = Global.SistemaCinderella.My.Resources.Recursos.Detalle_Pequeno
        Me.Btn_Aporte.Location = New System.Drawing.Point(325, 158)
        Me.Btn_Aporte.Name = "Btn_Aporte"
        Me.Btn_Aporte.Size = New System.Drawing.Size(21, 21)
        Me.Btn_Aporte.TabIndex = 90
        Me.Btn_Aporte.Tag = "Ver Detalle"
        Me.ToolEstado.SetToolTip(Me.Btn_Aporte, "Hace click aquí para ver un detalle completo de éste item.")
        Me.Btn_Aporte.UseVisualStyleBackColor = True
        '
        'Button15
        '
        Me.Button15.Cursor = System.Windows.Forms.Cursors.Help
        Me.Button15.FlatAppearance.BorderSize = 0
        Me.Button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button15.Image = CType(resources.GetObject("Button15.Image"), System.Drawing.Image)
        Me.Button15.Location = New System.Drawing.Point(293, 158)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(21, 21)
        Me.Button15.TabIndex = 89
        Me.Button15.Tag = "Ver Detalle"
        Me.ToolEstado.SetToolTip(Me.Button15, "Efectivo aportado por socios de la empresa.")
        Me.Button15.UseVisualStyleBackColor = True
        '
        'txt_Aporte
        '
        Me.txt_Aporte.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Aporte.Location = New System.Drawing.Point(143, 160)
        Me.txt_Aporte.Name = "txt_Aporte"
        Me.txt_Aporte.ReadOnly = True
        Me.txt_Aporte.Size = New System.Drawing.Size(144, 21)
        Me.txt_Aporte.TabIndex = 91
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(3, 163)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(134, 15)
        Me.Label16.TabIndex = 92
        Me.Label16.Text = "Aporte de Socios"
        '
        'txt_Venta
        '
        Me.txt_Venta.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Venta.Location = New System.Drawing.Point(143, 5)
        Me.txt_Venta.Name = "txt_Venta"
        Me.txt_Venta.ReadOnly = True
        Me.txt_Venta.Size = New System.Drawing.Size(144, 21)
        Me.txt_Venta.TabIndex = 6
        '
        'Button8
        '
        Me.Button8.Cursor = System.Windows.Forms.Cursors.Help
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Image = CType(resources.GetObject("Button8.Image"), System.Drawing.Image)
        Me.Button8.Location = New System.Drawing.Point(293, 3)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(21, 21)
        Me.Button8.TabIndex = 7
        Me.Button8.Tag = "Ver Detalle"
        Me.ToolEstado.SetToolTip(Me.Button8, "Ventas realizadas en la sucursal.")
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Btn_Venta
        '
        Me.Btn_Venta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Venta.FlatAppearance.BorderSize = 0
        Me.Btn_Venta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Venta.Image = Global.SistemaCinderella.My.Resources.Recursos.Detalle_Pequeno
        Me.Btn_Venta.Location = New System.Drawing.Point(325, 3)
        Me.Btn_Venta.Name = "Btn_Venta"
        Me.Btn_Venta.Size = New System.Drawing.Size(21, 21)
        Me.Btn_Venta.TabIndex = 8
        Me.Btn_Venta.Tag = "Ver Detalle"
        Me.ToolEstado.SetToolTip(Me.Btn_Venta, "Hace click aquí para ver un detalle completo de éste item.")
        Me.Btn_Venta.UseVisualStyleBackColor = True
        '
        'lblEfectivo
        '
        Me.lblEfectivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEfectivo.AutoSize = True
        Me.lblEfectivo.Location = New System.Drawing.Point(3, 93)
        Me.lblEfectivo.Name = "lblEfectivo"
        Me.lblEfectivo.Size = New System.Drawing.Size(134, 30)
        Me.lblEfectivo.TabIndex = 54
        Me.lblEfectivo.Text = "Recibidos de Sucursales"
        '
        'txt_Efectivo
        '
        Me.txt_Efectivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Efectivo.Location = New System.Drawing.Point(143, 98)
        Me.txt_Efectivo.Name = "txt_Efectivo"
        Me.txt_Efectivo.ReadOnly = True
        Me.txt_Efectivo.Size = New System.Drawing.Size(144, 21)
        Me.txt_Efectivo.TabIndex = 12
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Help
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(293, 96)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(21, 21)
        Me.Button2.TabIndex = 13
        Me.Button2.Tag = "Ver Detalle"
        Me.ToolEstado.SetToolTip(Me.Button2, "Efectivo enviado desde otra sucursal.")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Btn_EfectivoIngreso
        '
        Me.Btn_EfectivoIngreso.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_EfectivoIngreso.FlatAppearance.BorderSize = 0
        Me.Btn_EfectivoIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_EfectivoIngreso.Image = Global.SistemaCinderella.My.Resources.Recursos.Detalle_Pequeno
        Me.Btn_EfectivoIngreso.Location = New System.Drawing.Point(325, 96)
        Me.Btn_EfectivoIngreso.Name = "Btn_EfectivoIngreso"
        Me.Btn_EfectivoIngreso.Size = New System.Drawing.Size(21, 21)
        Me.Btn_EfectivoIngreso.TabIndex = 14
        Me.Btn_EfectivoIngreso.Tag = "Ver Detalle"
        Me.ToolEstado.SetToolTip(Me.Btn_EfectivoIngreso, "Hace click aquí para ver un detalle completo de éste item.")
        Me.Btn_EfectivoIngreso.UseVisualStyleBackColor = True
        '
        'lblVarios
        '
        Me.lblVarios.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVarios.AutoSize = True
        Me.lblVarios.Location = New System.Drawing.Point(3, 132)
        Me.lblVarios.Name = "lblVarios"
        Me.lblVarios.Size = New System.Drawing.Size(134, 15)
        Me.lblVarios.TabIndex = 32
        Me.lblVarios.Text = "Sobrante de Caja"
        '
        'txt_Sobrante
        '
        Me.txt_Sobrante.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Sobrante.Location = New System.Drawing.Point(143, 129)
        Me.txt_Sobrante.Name = "txt_Sobrante"
        Me.txt_Sobrante.ReadOnly = True
        Me.txt_Sobrante.Size = New System.Drawing.Size(144, 21)
        Me.txt_Sobrante.TabIndex = 9
        '
        'Button10
        '
        Me.Button10.Cursor = System.Windows.Forms.Cursors.Help
        Me.Button10.FlatAppearance.BorderSize = 0
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Image = CType(resources.GetObject("Button10.Image"), System.Drawing.Image)
        Me.Button10.Location = New System.Drawing.Point(293, 127)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(21, 21)
        Me.Button10.TabIndex = 10
        Me.Button10.Tag = "Ver Detalle"
        Me.ToolEstado.SetToolTip(Me.Button10, "Sobrantes de efectivo en la caja de la sucursal.")
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Btn_Sobrante
        '
        Me.Btn_Sobrante.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Sobrante.FlatAppearance.BorderSize = 0
        Me.Btn_Sobrante.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Sobrante.Image = Global.SistemaCinderella.My.Resources.Recursos.Detalle_Pequeno
        Me.Btn_Sobrante.Location = New System.Drawing.Point(325, 127)
        Me.Btn_Sobrante.Name = "Btn_Sobrante"
        Me.Btn_Sobrante.Size = New System.Drawing.Size(21, 21)
        Me.Btn_Sobrante.TabIndex = 11
        Me.Btn_Sobrante.Tag = "Ver Detalle"
        Me.ToolEstado.SetToolTip(Me.Btn_Sobrante, "Hace click aquí para ver un detalle completo de éste item.")
        Me.Btn_Sobrante.UseVisualStyleBackColor = True
        '
        'lblEgresos
        '
        Me.lblEgresos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEgresos.Image = Global.SistemaCinderella.My.Resources.Recursos.Egreso_32
        Me.lblEgresos.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblEgresos.Location = New System.Drawing.Point(3, 0)
        Me.lblEgresos.Name = "lblEgresos"
        Me.lblEgresos.Size = New System.Drawing.Size(34, 188)
        Me.lblEgresos.TabIndex = 73
        Me.lblEgresos.Text = "E" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "G" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "R" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "E" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "S" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "O" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "S"
        Me.lblEgresos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblIngresos
        '
        Me.lblIngresos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIngresos.Image = Global.SistemaCinderella.My.Resources.Recursos.Ingreso_32
        Me.lblIngresos.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblIngresos.Location = New System.Drawing.Point(409, 0)
        Me.lblIngresos.Name = "lblIngresos"
        Me.lblIngresos.Size = New System.Drawing.Size(34, 202)
        Me.lblIngresos.TabIndex = 72
        Me.lblIngresos.Text = "I" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "N" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "G" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "R" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "E" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "S" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "O" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "S"
        Me.lblIngresos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel1, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(43, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(360, 380)
        Me.TableLayoutPanel3.TabIndex = 103
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label11, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Button11, 3, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Button9, 2, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label12, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Btn_Devoluciones, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Button13, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_PendienteAutorizar, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Button14, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_DevolucionesEgr, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Button3, 2, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_Faltante, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Button5, 2, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_Retiro, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Mercaderias, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Btn_Retiro, 3, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Sueldo, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Gasto, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Btn_Faltante, 3, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Impuesto, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Button4, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Btn_EfectivoEgreso, 3, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Button7, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_EfectivoEgreso, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Faltante, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Button6, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Retiro, 1, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.Btn_Sueldo, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Btn_Gasto, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Btn_Impuesto, 3, 4)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 9
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(354, 279)
        Me.TableLayoutPanel1.TabIndex = 101
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 8)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(134, 15)
        Me.Label11.TabIndex = 93
        Me.Label11.Text = "Devoluciones"
        '
        'Button11
        '
        Me.Button11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button11.FlatAppearance.BorderSize = 0
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Image = Global.SistemaCinderella.My.Resources.Recursos.Detalle_Pequeno
        Me.Button11.Location = New System.Drawing.Point(325, 189)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(21, 21)
        Me.Button11.TabIndex = 99
        Me.Button11.Tag = "Ver Detalle"
        Me.ToolEstado.SetToolTip(Me.Button11, "Hace click aquí para ver un detalle completo de éste item.")
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Cursor = System.Windows.Forms.Cursors.Help
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Image = CType(resources.GetObject("Button9.Image"), System.Drawing.Image)
        Me.Button9.Location = New System.Drawing.Point(293, 189)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(21, 21)
        Me.Button9.TabIndex = 98
        Me.Button9.Tag = "Ver Detalle"
        Me.ToolEstado.SetToolTip(Me.Button9, "Efectivo empleado para pagar bienes a otras sucursales, envió de efectivo a otras" &
        " sucursales, etc. en estado pendiente de autorización por la sucursal destino")
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 39)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(134, 15)
        Me.Label12.TabIndex = 88
        Me.Label12.Text = "Mercaderías"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 194)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 15)
        Me.Label5.TabIndex = 100
        Me.Label5.Text = "Pend. de Autorización"
        '
        'Btn_Devoluciones
        '
        Me.Btn_Devoluciones.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Devoluciones.FlatAppearance.BorderSize = 0
        Me.Btn_Devoluciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Devoluciones.Image = Global.SistemaCinderella.My.Resources.Recursos.Detalle_Pequeno
        Me.Btn_Devoluciones.Location = New System.Drawing.Point(325, 3)
        Me.Btn_Devoluciones.Name = "Btn_Devoluciones"
        Me.Btn_Devoluciones.Size = New System.Drawing.Size(21, 21)
        Me.Btn_Devoluciones.TabIndex = 96
        Me.Btn_Devoluciones.Tag = "Ver Detalle"
        Me.ToolEstado.SetToolTip(Me.Btn_Devoluciones, "Hace click aquí para ver un detalle completo de éste item.")
        Me.Btn_Devoluciones.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.Cursor = System.Windows.Forms.Cursors.Help
        Me.Button13.FlatAppearance.BorderSize = 0
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button13.Image = CType(resources.GetObject("Button13.Image"), System.Drawing.Image)
        Me.Button13.Location = New System.Drawing.Point(293, 3)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(21, 21)
        Me.Button13.TabIndex = 95
        Me.Button13.Tag = "Ver Detalle"
        Me.ToolEstado.SetToolTip(Me.Button13, "Egresos de dinero por Devoluciones.")
        Me.Button13.UseVisualStyleBackColor = True
        '
        'txt_PendienteAutorizar
        '
        Me.txt_PendienteAutorizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_PendienteAutorizar.Location = New System.Drawing.Point(143, 191)
        Me.txt_PendienteAutorizar.Name = "txt_PendienteAutorizar"
        Me.txt_PendienteAutorizar.ReadOnly = True
        Me.txt_PendienteAutorizar.Size = New System.Drawing.Size(144, 21)
        Me.txt_PendienteAutorizar.TabIndex = 97
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 15)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Sueldos"
        '
        'Button14
        '
        Me.Button14.Cursor = System.Windows.Forms.Cursors.Help
        Me.Button14.FlatAppearance.BorderSize = 0
        Me.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button14.Image = CType(resources.GetObject("Button14.Image"), System.Drawing.Image)
        Me.Button14.Location = New System.Drawing.Point(293, 34)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(21, 21)
        Me.Button14.TabIndex = 87
        Me.Button14.Tag = "Ver Detalle"
        Me.ToolEstado.SetToolTip(Me.Button14, "Egresos de dinero por pago a proveedores.")
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 15)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Gastos"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 15)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Impuestos"
        '
        'txt_DevolucionesEgr
        '
        Me.txt_DevolucionesEgr.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_DevolucionesEgr.Location = New System.Drawing.Point(143, 5)
        Me.txt_DevolucionesEgr.Name = "txt_DevolucionesEgr"
        Me.txt_DevolucionesEgr.ReadOnly = True
        Me.txt_DevolucionesEgr.Size = New System.Drawing.Size(144, 21)
        Me.txt_DevolucionesEgr.TabIndex = 94
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 15)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Envíos a Sucursales"
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Help
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(293, 251)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(21, 21)
        Me.Button3.TabIndex = 31
        Me.Button3.Tag = "Ver Detalle"
        Me.ToolEstado.SetToolTip(Me.Button3, "Efectivo retirado por socios de la empresa.")
        Me.Button3.UseVisualStyleBackColor = True
        '
        'lbl_Faltante
        '
        Me.lbl_Faltante.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Faltante.AutoSize = True
        Me.lbl_Faltante.Location = New System.Drawing.Point(3, 225)
        Me.lbl_Faltante.Name = "lbl_Faltante"
        Me.lbl_Faltante.Size = New System.Drawing.Size(134, 15)
        Me.lbl_Faltante.TabIndex = 45
        Me.lbl_Faltante.Text = "Faltante de Caja"
        '
        'Button5
        '
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Help
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(293, 220)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(21, 21)
        Me.Button5.TabIndex = 25
        Me.Button5.Tag = "Ver Detalle"
        Me.ToolEstado.SetToolTip(Me.Button5, "Faltantes de efectivo en la caja de la sucursal.")
        Me.Button5.UseVisualStyleBackColor = True
        '
        'lbl_Retiro
        '
        Me.lbl_Retiro.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Retiro.AutoSize = True
        Me.lbl_Retiro.Location = New System.Drawing.Point(3, 256)
        Me.lbl_Retiro.Name = "lbl_Retiro"
        Me.lbl_Retiro.Size = New System.Drawing.Size(134, 15)
        Me.lbl_Retiro.TabIndex = 51
        Me.lbl_Retiro.Text = "Retiro de Socios"
        '
        'txt_Mercaderias
        '
        Me.txt_Mercaderias.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Mercaderias.Location = New System.Drawing.Point(143, 36)
        Me.txt_Mercaderias.Name = "txt_Mercaderias"
        Me.txt_Mercaderias.ReadOnly = True
        Me.txt_Mercaderias.Size = New System.Drawing.Size(144, 21)
        Me.txt_Mercaderias.TabIndex = 86
        '
        'Btn_Retiro
        '
        Me.Btn_Retiro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Retiro.FlatAppearance.BorderSize = 0
        Me.Btn_Retiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Retiro.Image = Global.SistemaCinderella.My.Resources.Recursos.Detalle_Pequeno
        Me.Btn_Retiro.Location = New System.Drawing.Point(325, 251)
        Me.Btn_Retiro.Name = "Btn_Retiro"
        Me.Btn_Retiro.Size = New System.Drawing.Size(21, 21)
        Me.Btn_Retiro.TabIndex = 32
        Me.Btn_Retiro.Tag = "Ver Detalle"
        Me.ToolEstado.SetToolTip(Me.Btn_Retiro, "Hace click aquí para ver un detalle completo de éste item.")
        Me.Btn_Retiro.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Help
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(293, 158)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(21, 21)
        Me.Button1.TabIndex = 34
        Me.Button1.Tag = "Ver Detalle"
        Me.ToolEstado.SetToolTip(Me.Button1, "Efectivo empleado para pagar bienes a otras sucursales, envio de efectivo a otras" &
        " sucursales, etc.")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt_Sueldo
        '
        Me.txt_Sueldo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Sueldo.Location = New System.Drawing.Point(143, 67)
        Me.txt_Sueldo.Name = "txt_Sueldo"
        Me.txt_Sueldo.ReadOnly = True
        Me.txt_Sueldo.Size = New System.Drawing.Size(144, 21)
        Me.txt_Sueldo.TabIndex = 18
        '
        'txt_Gasto
        '
        Me.txt_Gasto.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Gasto.Location = New System.Drawing.Point(143, 98)
        Me.txt_Gasto.Name = "txt_Gasto"
        Me.txt_Gasto.ReadOnly = True
        Me.txt_Gasto.Size = New System.Drawing.Size(144, 21)
        Me.txt_Gasto.TabIndex = 27
        '
        'Btn_Faltante
        '
        Me.Btn_Faltante.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Faltante.FlatAppearance.BorderSize = 0
        Me.Btn_Faltante.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Faltante.Image = Global.SistemaCinderella.My.Resources.Recursos.Detalle_Pequeno
        Me.Btn_Faltante.Location = New System.Drawing.Point(325, 220)
        Me.Btn_Faltante.Name = "Btn_Faltante"
        Me.Btn_Faltante.Size = New System.Drawing.Size(21, 21)
        Me.Btn_Faltante.TabIndex = 26
        Me.Btn_Faltante.Tag = "Ver Detalle"
        Me.ToolEstado.SetToolTip(Me.Btn_Faltante, "Hace click aquí para ver un detalle completo de éste item.")
        Me.Btn_Faltante.UseVisualStyleBackColor = True
        '
        'txt_Impuesto
        '
        Me.txt_Impuesto.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Impuesto.Location = New System.Drawing.Point(143, 129)
        Me.txt_Impuesto.Name = "txt_Impuesto"
        Me.txt_Impuesto.ReadOnly = True
        Me.txt_Impuesto.Size = New System.Drawing.Size(144, 21)
        Me.txt_Impuesto.TabIndex = 21
        '
        'Button4
        '
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Help
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(293, 96)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(21, 21)
        Me.Button4.TabIndex = 28
        Me.Button4.Tag = "Ver Detalle"
        Me.ToolEstado.SetToolTip(Me.Button4, "Gastos pagados por la sucursal.")
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Btn_EfectivoEgreso
        '
        Me.Btn_EfectivoEgreso.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_EfectivoEgreso.FlatAppearance.BorderSize = 0
        Me.Btn_EfectivoEgreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_EfectivoEgreso.Image = Global.SistemaCinderella.My.Resources.Recursos.Detalle_Pequeno
        Me.Btn_EfectivoEgreso.Location = New System.Drawing.Point(325, 158)
        Me.Btn_EfectivoEgreso.Name = "Btn_EfectivoEgreso"
        Me.Btn_EfectivoEgreso.Size = New System.Drawing.Size(21, 21)
        Me.Btn_EfectivoEgreso.TabIndex = 35
        Me.Btn_EfectivoEgreso.Tag = "Ver Detalle"
        Me.ToolEstado.SetToolTip(Me.Btn_EfectivoEgreso, "Hace click aquí para ver un detalle completo de éste item.")
        Me.Btn_EfectivoEgreso.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Cursor = System.Windows.Forms.Cursors.Help
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Image = CType(resources.GetObject("Button7.Image"), System.Drawing.Image)
        Me.Button7.Location = New System.Drawing.Point(293, 127)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(21, 21)
        Me.Button7.TabIndex = 22
        Me.Button7.Tag = "Ver Detalle"
        Me.ToolEstado.SetToolTip(Me.Button7, "Impuestos pagados por la sucursal.")
        Me.Button7.UseVisualStyleBackColor = True
        '
        'txt_EfectivoEgreso
        '
        Me.txt_EfectivoEgreso.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_EfectivoEgreso.Location = New System.Drawing.Point(143, 160)
        Me.txt_EfectivoEgreso.Name = "txt_EfectivoEgreso"
        Me.txt_EfectivoEgreso.ReadOnly = True
        Me.txt_EfectivoEgreso.Size = New System.Drawing.Size(144, 21)
        Me.txt_EfectivoEgreso.TabIndex = 33
        '
        'txt_Faltante
        '
        Me.txt_Faltante.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Faltante.Location = New System.Drawing.Point(143, 222)
        Me.txt_Faltante.Name = "txt_Faltante"
        Me.txt_Faltante.ReadOnly = True
        Me.txt_Faltante.Size = New System.Drawing.Size(144, 21)
        Me.txt_Faltante.TabIndex = 24
        '
        'Button6
        '
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Help
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.Location = New System.Drawing.Point(293, 65)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(21, 21)
        Me.Button6.TabIndex = 19
        Me.Button6.Tag = "Ver Detalle"
        Me.ToolEstado.SetToolTip(Me.Button6, "Sueldos a la fecha de los empleados de la sucursal.")
        Me.Button6.UseVisualStyleBackColor = True
        '
        'txt_Retiro
        '
        Me.txt_Retiro.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Retiro.Location = New System.Drawing.Point(143, 253)
        Me.txt_Retiro.Name = "txt_Retiro"
        Me.txt_Retiro.ReadOnly = True
        Me.txt_Retiro.Size = New System.Drawing.Size(144, 21)
        Me.txt_Retiro.TabIndex = 30
        '
        'Btn_Sueldo
        '
        Me.Btn_Sueldo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Sueldo.FlatAppearance.BorderSize = 0
        Me.Btn_Sueldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Sueldo.Image = Global.SistemaCinderella.My.Resources.Recursos.Detalle_Pequeno
        Me.Btn_Sueldo.Location = New System.Drawing.Point(325, 65)
        Me.Btn_Sueldo.Name = "Btn_Sueldo"
        Me.Btn_Sueldo.Size = New System.Drawing.Size(21, 21)
        Me.Btn_Sueldo.TabIndex = 20
        Me.Btn_Sueldo.Tag = "Ver Detalle"
        Me.ToolEstado.SetToolTip(Me.Btn_Sueldo, "Hace click aquí para ver un detalle completo de éste item.")
        Me.Btn_Sueldo.UseVisualStyleBackColor = True
        '
        'Btn_Gasto
        '
        Me.Btn_Gasto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Gasto.FlatAppearance.BorderSize = 0
        Me.Btn_Gasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Gasto.Image = Global.SistemaCinderella.My.Resources.Recursos.Detalle_Pequeno
        Me.Btn_Gasto.Location = New System.Drawing.Point(325, 96)
        Me.Btn_Gasto.Name = "Btn_Gasto"
        Me.Btn_Gasto.Size = New System.Drawing.Size(21, 21)
        Me.Btn_Gasto.TabIndex = 29
        Me.Btn_Gasto.Tag = "Ver Detalle"
        Me.ToolEstado.SetToolTip(Me.Btn_Gasto, "Hace click aquí para ver un detalle completo de éste item.")
        Me.Btn_Gasto.UseVisualStyleBackColor = True
        '
        'Btn_Impuesto
        '
        Me.Btn_Impuesto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Impuesto.FlatAppearance.BorderSize = 0
        Me.Btn_Impuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Impuesto.Image = Global.SistemaCinderella.My.Resources.Recursos.Detalle_Pequeno
        Me.Btn_Impuesto.Location = New System.Drawing.Point(325, 127)
        Me.Btn_Impuesto.Name = "Btn_Impuesto"
        Me.Btn_Impuesto.Size = New System.Drawing.Size(21, 21)
        Me.Btn_Impuesto.TabIndex = 23
        Me.Btn_Impuesto.Tag = "Ver Detalle"
        Me.ToolEstado.SetToolTip(Me.Btn_Impuesto, "Hace click aquí para ver un detalle completo de éste item.")
        Me.Btn_Impuesto.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label14, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_TotalEgresos, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label8, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_Saldo, 1, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 288)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(354, 89)
        Me.TableLayoutPanel2.TabIndex = 102
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(3, 10)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(171, 24)
        Me.Label14.TabIndex = 82
        Me.Label14.Text = "Total:"
        '
        'lbl_TotalEgresos
        '
        Me.lbl_TotalEgresos.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_TotalEgresos.AutoSize = True
        Me.lbl_TotalEgresos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TotalEgresos.Location = New System.Drawing.Point(180, 10)
        Me.lbl_TotalEgresos.Name = "lbl_TotalEgresos"
        Me.lbl_TotalEgresos.Size = New System.Drawing.Size(171, 24)
        Me.lbl_TotalEgresos.TabIndex = 83
        Me.lbl_TotalEgresos.Text = "$ 3.000.000.-"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(171, 29)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Saldo:"
        '
        'lbl_Saldo
        '
        Me.lbl_Saldo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Saldo.AutoSize = True
        Me.lbl_Saldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lbl_Saldo.Location = New System.Drawing.Point(180, 54)
        Me.lbl_Saldo.Name = "lbl_Saldo"
        Me.lbl_Saldo.Size = New System.Drawing.Size(171, 24)
        Me.lbl_Saldo.TabIndex = 36
        Me.lbl_Saldo.Text = "$ 3.000.000.-"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 240)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 15)
        Me.Label10.TabIndex = 75
        Me.Label10.Text = "Facturado"
        '
        'txt_VentasFacturado
        '
        Me.txt_VentasFacturado.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_VentasFacturado.Location = New System.Drawing.Point(78, 237)
        Me.txt_VentasFacturado.Name = "txt_VentasFacturado"
        Me.txt_VentasFacturado.ReadOnly = True
        Me.txt_VentasFacturado.Size = New System.Drawing.Size(113, 21)
        Me.txt_VentasFacturado.TabIndex = 74
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 75)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 15)
        Me.Label9.TabIndex = 71
        Me.Label9.Text = "Cheque"
        '
        'txt_VentasCheque
        '
        Me.txt_VentasCheque.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_VentasCheque.Location = New System.Drawing.Point(78, 72)
        Me.txt_VentasCheque.Name = "txt_VentasCheque"
        Me.txt_VentasCheque.ReadOnly = True
        Me.txt_VentasCheque.Size = New System.Drawing.Size(113, 21)
        Me.txt_VentasCheque.TabIndex = 70
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 185)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 15)
        Me.Label7.TabIndex = 69
        Me.Label7.Text = "Debito"
        '
        'txt_VentasDebito
        '
        Me.txt_VentasDebito.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_VentasDebito.Location = New System.Drawing.Point(78, 182)
        Me.txt_VentasDebito.Name = "txt_VentasDebito"
        Me.txt_VentasDebito.ReadOnly = True
        Me.txt_VentasDebito.Size = New System.Drawing.Size(113, 21)
        Me.txt_VentasDebito.TabIndex = 68
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 15)
        Me.Label6.TabIndex = 67
        Me.Label6.Text = "Credito"
        '
        'txt_VentasCredito
        '
        Me.txt_VentasCredito.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_VentasCredito.Location = New System.Drawing.Point(78, 127)
        Me.txt_VentasCredito.Name = "txt_VentasCredito"
        Me.txt_VentasCredito.ReadOnly = True
        Me.txt_VentasCredito.Size = New System.Drawing.Size(113, 21)
        Me.txt_VentasCredito.TabIndex = 66
        '
        'lbl_Efectivo
        '
        Me.lbl_Efectivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Efectivo.AutoSize = True
        Me.lbl_Efectivo.Location = New System.Drawing.Point(3, 20)
        Me.lbl_Efectivo.Name = "lbl_Efectivo"
        Me.lbl_Efectivo.Size = New System.Drawing.Size(69, 15)
        Me.lbl_Efectivo.TabIndex = 65
        Me.lbl_Efectivo.Text = "Efectivo "
        '
        'txt_VentasEfectivo
        '
        Me.txt_VentasEfectivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_VentasEfectivo.Location = New System.Drawing.Point(78, 17)
        Me.txt_VentasEfectivo.Name = "txt_VentasEfectivo"
        Me.txt_VentasEfectivo.ReadOnly = True
        Me.txt_VentasEfectivo.Size = New System.Drawing.Size(113, 21)
        Me.txt_VentasEfectivo.TabIndex = 64
        '
        'lblMayorista
        '
        Me.lblMayorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMayorista.AutoSize = True
        Me.lblMayorista.Location = New System.Drawing.Point(3, 350)
        Me.lblMayorista.Name = "lblMayorista"
        Me.lblMayorista.Size = New System.Drawing.Size(69, 15)
        Me.lblMayorista.TabIndex = 63
        Me.lblMayorista.Text = "Mayorista"
        '
        'txt_VentaMayorista
        '
        Me.txt_VentaMayorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_VentaMayorista.Location = New System.Drawing.Point(78, 347)
        Me.txt_VentaMayorista.Name = "txt_VentaMayorista"
        Me.txt_VentaMayorista.ReadOnly = True
        Me.txt_VentaMayorista.Size = New System.Drawing.Size(113, 21)
        Me.txt_VentaMayorista.TabIndex = 62
        '
        'lblMinorista
        '
        Me.lblMinorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMinorista.AutoSize = True
        Me.lblMinorista.Location = New System.Drawing.Point(3, 295)
        Me.lblMinorista.Name = "lblMinorista"
        Me.lblMinorista.Size = New System.Drawing.Size(69, 15)
        Me.lblMinorista.TabIndex = 56
        Me.lblMinorista.Text = "Minorista"
        '
        'txt_VentaMinorista
        '
        Me.txt_VentaMinorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_VentaMinorista.Location = New System.Drawing.Point(78, 292)
        Me.txt_VentaMinorista.Name = "txt_VentaMinorista"
        Me.txt_VentaMinorista.ReadOnly = True
        Me.txt_VentaMinorista.Size = New System.Drawing.Size(113, 21)
        Me.txt_VentaMinorista.TabIndex = 55
        '
        'ToolEstado
        '
        Me.ToolEstado.IsBalloon = True
        Me.ToolEstado.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolEstado.ToolTipTitle = "Ayuda"
        '
        'GbDetalleVenta
        '
        Me.GbDetalleVenta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GbDetalleVenta.Controls.Add(Me.TableLayoutPanel7)
        Me.GbDetalleVenta.Location = New System.Drawing.Point(827, 3)
        Me.GbDetalleVenta.Name = "GbDetalleVenta"
        Me.GbDetalleVenta.Size = New System.Drawing.Size(200, 406)
        Me.GbDetalleVenta.TabIndex = 3
        Me.GbDetalleVenta.TabStop = False
        Me.GbDetalleVenta.Text = "Detalle Ventas"
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 2
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.txt_VentaMayorista, 1, 6)
        Me.TableLayoutPanel7.Controls.Add(Me.lbl_Efectivo, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.lblMayorista, 0, 6)
        Me.TableLayoutPanel7.Controls.Add(Me.txt_VentaMinorista, 1, 5)
        Me.TableLayoutPanel7.Controls.Add(Me.txt_VentasEfectivo, 1, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.lblMinorista, 0, 5)
        Me.TableLayoutPanel7.Controls.Add(Me.Label9, 0, 1)
        Me.TableLayoutPanel7.Controls.Add(Me.txt_VentasCheque, 1, 1)
        Me.TableLayoutPanel7.Controls.Add(Me.txt_VentasFacturado, 1, 4)
        Me.TableLayoutPanel7.Controls.Add(Me.txt_VentasDebito, 1, 3)
        Me.TableLayoutPanel7.Controls.Add(Me.Label10, 0, 4)
        Me.TableLayoutPanel7.Controls.Add(Me.txt_VentasCredito, 1, 2)
        Me.TableLayoutPanel7.Controls.Add(Me.Label7, 0, 3)
        Me.TableLayoutPanel7.Controls.Add(Me.Label6, 0, 2)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(3, 17)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 7
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(194, 386)
        Me.TableLayoutPanel7.TabIndex = 4
        '
        'TableLayoutPanel9
        '
        Me.TableLayoutPanel9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel9.ColumnCount = 2
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel9.Controls.Add(Me.GbDetalle, 0, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.GbDetalleVenta, 1, 0)
        Me.TableLayoutPanel9.Location = New System.Drawing.Point(12, 137)
        Me.TableLayoutPanel9.Name = "TableLayoutPanel9"
        Me.TableLayoutPanel9.RowCount = 1
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel9.Size = New System.Drawing.Size(1030, 412)
        Me.TableLayoutPanel9.TabIndex = 4
        '
        'frmSucursalesSaldos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1054, 550)
        Me.Controls.Add(Me.TableLayoutPanel9)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSucursalesSaldos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estado de Cuenta de Sucursal"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GbDetalle.ResumeLayout(False)
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.GbDetalleVenta.ResumeLayout(False)
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel7.PerformLayout()
        Me.TableLayoutPanel9.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_FDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_FHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents lblFechaH As System.Windows.Forms.Label
    Friend WithEvents lblFechaD As System.Windows.Forms.Label
    Friend WithEvents GbDetalle As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_Sobrante As System.Windows.Forms.Button
    Friend WithEvents txt_Sobrante As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblSucursalNombre As System.Windows.Forms.Label
    Friend WithEvents lblSucursal As System.Windows.Forms.Label
    Friend WithEvents Btn_Venta As System.Windows.Forms.Button
    Friend WithEvents txt_Venta As System.Windows.Forms.TextBox
    Friend WithEvents lblVarios As System.Windows.Forms.Label
    Friend WithEvents lblVentas As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Btn_Impuesto As System.Windows.Forms.Button
    Friend WithEvents txt_Impuesto As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Saldo As System.Windows.Forms.Label
    Friend WithEvents ToolEstado As System.Windows.Forms.ToolTip
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Btn_Sueldo As System.Windows.Forms.Button
    Friend WithEvents txt_Sueldo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Btn_Gasto As System.Windows.Forms.Button
    Friend WithEvents txt_Gasto As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Faltante As System.Windows.Forms.Label
    Friend WithEvents Btn_Faltante As System.Windows.Forms.Button
    Friend WithEvents txt_Faltante As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Retiro As System.Windows.Forms.Label
    Friend WithEvents Btn_Retiro As System.Windows.Forms.Button
    Friend WithEvents txt_Retiro As System.Windows.Forms.TextBox
    Friend WithEvents lblEfectivo As System.Windows.Forms.Label
    Friend WithEvents Btn_EfectivoIngreso As System.Windows.Forms.Button
    Friend WithEvents txt_Efectivo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Btn_EfectivoEgreso As System.Windows.Forms.Button
    Friend WithEvents txt_EfectivoEgreso As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Btn_Limpiar As System.Windows.Forms.Button
    Friend WithEvents Btn_Salir As System.Windows.Forms.Button
    Friend WithEvents lblMinorista As System.Windows.Forms.Label
    Friend WithEvents txt_VentaMinorista As System.Windows.Forms.TextBox
    Friend WithEvents lblMayorista As System.Windows.Forms.Label
    Friend WithEvents txt_VentaMayorista As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Efectivo As System.Windows.Forms.Label
    Friend WithEvents txt_VentasEfectivo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_VentasCredito As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_VentasDebito As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_VentasCheque As System.Windows.Forms.TextBox
    Friend WithEvents lblIngresos As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_VentasFacturado As System.Windows.Forms.TextBox
    Friend WithEvents lblEgresos As System.Windows.Forms.Label
    Friend WithEvents lbl_TotalIngresos As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lbl_TotalEgresos As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lbl_DisponibleTotal As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_Mercaderias As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txt_Aporte As System.Windows.Forms.TextBox
    Friend WithEvents Button15 As System.Windows.Forms.Button
    Friend WithEvents Btn_Aporte As System.Windows.Forms.Button
    Friend WithEvents GbDetalleVenta As System.Windows.Forms.GroupBox
    Friend WithEvents txt_DevolucionesEgr As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents Btn_Devoluciones As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents txt_PendienteAutorizar As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
End Class
