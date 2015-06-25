<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProveedoresCuentaCorriente
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProveedoresCuentaCorriente))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_referencias = New System.Windows.Forms.Label()
        Me.DG_Cuentas2 = New System.Windows.Forms.DataGridView()
        Me.Btn_Pagar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_Total = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_Msg = New System.Windows.Forms.Label()
        Me.DG_Cuentas = New System.Windows.Forms.DataGridView()
        Me.id_Proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Saldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabCuenta = New System.Windows.Forms.TabControl()
        Me.TabListado = New System.Windows.Forms.TabPage()
        Me.TabDetalle = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_Total2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_Proveedor = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_Sucursal = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DG_Detalle = New System.Windows.Forms.DataGridView()
        Me.id_Mercaderia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Concepto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabMercaderia = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lbl_Total3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_Proveedor2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl_Fecha = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DG_Mercaderia = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Btn_Limpiar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DG_Cuentas2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_Cuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabCuenta.SuspendLayout()
        Me.TabListado.SuspendLayout()
        Me.TabDetalle.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DG_Detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabMercaderia.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DG_Mercaderia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Btn_Limpiar)
        Me.GroupBox1.Controls.Add(Me.lbl_referencias)
        Me.GroupBox1.Controls.Add(Me.DG_Cuentas2)
        Me.GroupBox1.Controls.Add(Me.Btn_Pagar)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lbl_Total)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lbl_Msg)
        Me.GroupBox1.Controls.Add(Me.DG_Cuentas)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(10, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(620, 470)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cuentas corrientes con los proveedores del sistema."
        '
        'lbl_referencias
        '
        Me.lbl_referencias.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_referencias.AutoSize = True
        Me.lbl_referencias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_referencias.Location = New System.Drawing.Point(369, 399)
        Me.lbl_referencias.Name = "lbl_referencias"
        Me.lbl_referencias.Size = New System.Drawing.Size(242, 13)
        Me.lbl_referencias.TabIndex = 10
        Me.lbl_referencias.Text = "(*) Puede acceder al detalle haciendo doble click."
        '
        'DG_Cuentas2
        '
        Me.DG_Cuentas2.AllowUserToAddRows = False
        Me.DG_Cuentas2.AllowUserToDeleteRows = False
        Me.DG_Cuentas2.AllowUserToResizeRows = False
        Me.DG_Cuentas2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_Cuentas2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_Cuentas2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DG_Cuentas2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Cuentas2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DG_Cuentas2.Location = New System.Drawing.Point(6, 66)
        Me.DG_Cuentas2.Name = "DG_Cuentas2"
        Me.DG_Cuentas2.ReadOnly = True
        Me.DG_Cuentas2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Cuentas2.Size = New System.Drawing.Size(605, 325)
        Me.DG_Cuentas2.TabIndex = 9
        '
        'Btn_Pagar
        '
        Me.Btn_Pagar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Pagar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Pagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Pagar.Image = Global.SistemaCinderella.My.Resources.Recursos.Sueldos
        Me.Btn_Pagar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Btn_Pagar.Location = New System.Drawing.Point(451, 420)
        Me.Btn_Pagar.Name = "Btn_Pagar"
        Me.Btn_Pagar.Size = New System.Drawing.Size(160, 40)
        Me.Btn_Pagar.TabIndex = 1
        Me.Btn_Pagar.Text = "Pagar en Cuenta Corriente"
        Me.Btn_Pagar.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Btn_Pagar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(6, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(505, 22)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Haz click en un proveedor determinado para visualizar el detalle de la cuenta cor" & _
            "riente."
        '
        'lbl_Total
        '
        Me.lbl_Total.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_Total.AutoSize = True
        Me.lbl_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Total.Location = New System.Drawing.Point(199, 429)
        Me.lbl_Total.Name = "lbl_Total"
        Me.lbl_Total.Size = New System.Drawing.Size(79, 25)
        Me.lbl_Total.TabIndex = 7
        Me.lbl_Total.Text = "$ 100.-"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 424)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 30)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "TOTAL DE DEUDAS " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "EN CUENTA CORRIENTE :"
        '
        'lbl_Msg
        '
        Me.lbl_Msg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Msg.AutoSize = True
        Me.lbl_Msg.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lbl_Msg.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Msg.Location = New System.Drawing.Point(109, 206)
        Me.lbl_Msg.Name = "lbl_Msg"
        Me.lbl_Msg.Size = New System.Drawing.Size(402, 24)
        Me.lbl_Msg.TabIndex = 5
        Me.lbl_Msg.Text = "No se han encontrado cuentas corrientes."
        '
        'DG_Cuentas
        '
        Me.DG_Cuentas.AllowUserToAddRows = False
        Me.DG_Cuentas.AllowUserToDeleteRows = False
        Me.DG_Cuentas.AllowUserToResizeColumns = False
        Me.DG_Cuentas.AllowUserToResizeRows = False
        Me.DG_Cuentas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_Cuentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_Cuentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DG_Cuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Cuentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_Proveedor, Me.Proveedor, Me.Saldo})
        Me.DG_Cuentas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DG_Cuentas.Location = New System.Drawing.Point(6, 66)
        Me.DG_Cuentas.Name = "DG_Cuentas"
        Me.DG_Cuentas.ReadOnly = True
        Me.DG_Cuentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Cuentas.Size = New System.Drawing.Size(605, 330)
        Me.DG_Cuentas.TabIndex = 0
        '
        'id_Proveedor
        '
        Me.id_Proveedor.DataPropertyName = "id_Proveedor"
        Me.id_Proveedor.HeaderText = "id_Proveedor"
        Me.id_Proveedor.Name = "id_Proveedor"
        Me.id_Proveedor.ReadOnly = True
        Me.id_Proveedor.Visible = False
        '
        'Proveedor
        '
        Me.Proveedor.DataPropertyName = "RazonSocial"
        Me.Proveedor.HeaderText = "Proveedor"
        Me.Proveedor.Name = "Proveedor"
        Me.Proveedor.ReadOnly = True
        '
        'Saldo
        '
        Me.Saldo.DataPropertyName = "Saldo"
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = "0"
        Me.Saldo.DefaultCellStyle = DataGridViewCellStyle1
        Me.Saldo.HeaderText = "Saldo"
        Me.Saldo.Name = "Saldo"
        Me.Saldo.ReadOnly = True
        '
        'TabCuenta
        '
        Me.TabCuenta.Controls.Add(Me.TabListado)
        Me.TabCuenta.Controls.Add(Me.TabDetalle)
        Me.TabCuenta.Controls.Add(Me.TabMercaderia)
        Me.TabCuenta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabCuenta.Location = New System.Drawing.Point(0, 0)
        Me.TabCuenta.Name = "TabCuenta"
        Me.TabCuenta.SelectedIndex = 0
        Me.TabCuenta.Size = New System.Drawing.Size(644, 522)
        Me.TabCuenta.TabIndex = 1
        '
        'TabListado
        '
        Me.TabListado.Controls.Add(Me.GroupBox1)
        Me.TabListado.Location = New System.Drawing.Point(4, 29)
        Me.TabListado.Name = "TabListado"
        Me.TabListado.Padding = New System.Windows.Forms.Padding(3)
        Me.TabListado.Size = New System.Drawing.Size(636, 489)
        Me.TabListado.TabIndex = 0
        Me.TabListado.Text = "Cuenta Corriente"
        Me.TabListado.UseVisualStyleBackColor = True
        '
        'TabDetalle
        '
        Me.TabDetalle.Controls.Add(Me.GroupBox2)
        Me.TabDetalle.Location = New System.Drawing.Point(4, 29)
        Me.TabDetalle.Name = "TabDetalle"
        Me.TabDetalle.Padding = New System.Windows.Forms.Padding(3)
        Me.TabDetalle.Size = New System.Drawing.Size(636, 489)
        Me.TabDetalle.TabIndex = 1
        Me.TabDetalle.Text = "Detalle"
        Me.TabDetalle.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.lbl_Total2)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.lbl_Proveedor)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.lbl_Sucursal)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.DG_Detalle)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(10, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(620, 470)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cuentas corrientes con los proveedores del sistema."
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(372, 412)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(242, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "(*) Puede acceder al detalle haciendo doble click."
        '
        'lbl_Total2
        '
        Me.lbl_Total2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_Total2.AutoSize = True
        Me.lbl_Total2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Total2.Location = New System.Drawing.Point(207, 431)
        Me.lbl_Total2.Name = "lbl_Total2"
        Me.lbl_Total2.Size = New System.Drawing.Size(79, 25)
        Me.lbl_Total2.TabIndex = 8
        Me.lbl_Total2.Text = "$ 100.-"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 435)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(198, 15)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "TOTAL CUENTA CORRIENTE :"
        '
        'lbl_Proveedor
        '
        Me.lbl_Proveedor.AutoSize = True
        Me.lbl_Proveedor.Location = New System.Drawing.Point(324, 38)
        Me.lbl_Proveedor.Name = "lbl_Proveedor"
        Me.lbl_Proveedor.Size = New System.Drawing.Size(66, 15)
        Me.lbl_Proveedor.TabIndex = 5
        Me.lbl_Proveedor.Text = "Arak Madu"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(238, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Proveedor :"
        '
        'lbl_Sucursal
        '
        Me.lbl_Sucursal.AutoSize = True
        Me.lbl_Sucursal.Location = New System.Drawing.Point(83, 38)
        Me.lbl_Sucursal.Name = "lbl_Sucursal"
        Me.lbl_Sucursal.Size = New System.Drawing.Size(46, 15)
        Me.lbl_Sucursal.TabIndex = 3
        Me.lbl_Sucursal.Text = "Sarasa"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Sucursal :"
        '
        'DG_Detalle
        '
        Me.DG_Detalle.AllowUserToAddRows = False
        Me.DG_Detalle.AllowUserToDeleteRows = False
        Me.DG_Detalle.AllowUserToResizeColumns = False
        Me.DG_Detalle.AllowUserToResizeRows = False
        Me.DG_Detalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_Detalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_Detalle.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DG_Detalle.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DG_Detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Detalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_Mercaderia, Me.Fecha, Me.Concepto, Me.Importe})
        Me.DG_Detalle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DG_Detalle.Location = New System.Drawing.Point(6, 74)
        Me.DG_Detalle.Name = "DG_Detalle"
        Me.DG_Detalle.ReadOnly = True
        Me.DG_Detalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Detalle.Size = New System.Drawing.Size(608, 335)
        Me.DG_Detalle.TabIndex = 1
        '
        'id_Mercaderia
        '
        Me.id_Mercaderia.DataPropertyName = "id_Mercaderia"
        Me.id_Mercaderia.HeaderText = "id_Mercaderia"
        Me.id_Mercaderia.Name = "id_Mercaderia"
        Me.id_Mercaderia.ReadOnly = True
        Me.id_Mercaderia.Visible = False
        '
        'Fecha
        '
        Me.Fecha.DataPropertyName = "Fecha"
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        '
        'Concepto
        '
        Me.Concepto.DataPropertyName = "Concepto"
        Me.Concepto.HeaderText = "Concepto"
        Me.Concepto.Name = "Concepto"
        Me.Concepto.ReadOnly = True
        '
        'Importe
        '
        Me.Importe.DataPropertyName = "Saldo"
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = "0"
        Me.Importe.DefaultCellStyle = DataGridViewCellStyle2
        Me.Importe.HeaderText = "Importe"
        Me.Importe.Name = "Importe"
        Me.Importe.ReadOnly = True
        '
        'TabMercaderia
        '
        Me.TabMercaderia.Controls.Add(Me.GroupBox3)
        Me.TabMercaderia.Location = New System.Drawing.Point(4, 29)
        Me.TabMercaderia.Name = "TabMercaderia"
        Me.TabMercaderia.Size = New System.Drawing.Size(636, 489)
        Me.TabMercaderia.TabIndex = 2
        Me.TabMercaderia.Text = "Mercadería"
        Me.TabMercaderia.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.lbl_Total3)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.lbl_Proveedor2)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.lbl_Fecha)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.DG_Mercaderia)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(10, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(618, 420)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Cuentas corrientes con los proveedores del sistema."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(324, 27)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(76, 15)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Mercaderías"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(238, 27)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 15)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "Concepto :"
        '
        'lbl_Total3
        '
        Me.lbl_Total3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_Total3.AutoSize = True
        Me.lbl_Total3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Total3.Location = New System.Drawing.Point(80, 383)
        Me.lbl_Total3.Name = "lbl_Total3"
        Me.lbl_Total3.Size = New System.Drawing.Size(79, 25)
        Me.lbl_Total3.TabIndex = 8
        Me.lbl_Total3.Text = "$ 100.-"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(5, 387)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 15)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "TOTAL :"
        '
        'lbl_Proveedor2
        '
        Me.lbl_Proveedor2.AutoSize = True
        Me.lbl_Proveedor2.Location = New System.Drawing.Point(89, 55)
        Me.lbl_Proveedor2.Name = "lbl_Proveedor2"
        Me.lbl_Proveedor2.Size = New System.Drawing.Size(66, 15)
        Me.lbl_Proveedor2.TabIndex = 5
        Me.lbl_Proveedor2.Text = "Arak Madu"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 55)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 15)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Proveedor :"
        '
        'lbl_Fecha
        '
        Me.lbl_Fecha.AutoSize = True
        Me.lbl_Fecha.Location = New System.Drawing.Point(89, 27)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(46, 15)
        Me.lbl_Fecha.TabIndex = 3
        Me.lbl_Fecha.Text = "Sarasa"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(3, 27)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 15)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Fecha :"
        '
        'DG_Mercaderia
        '
        Me.DG_Mercaderia.AllowUserToAddRows = False
        Me.DG_Mercaderia.AllowUserToDeleteRows = False
        Me.DG_Mercaderia.AllowUserToResizeRows = False
        Me.DG_Mercaderia.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_Mercaderia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_Mercaderia.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DG_Mercaderia.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DG_Mercaderia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Mercaderia.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Producto, Me.Cantidad, Me.Costo, Me.Total})
        Me.DG_Mercaderia.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.DG_Mercaderia.Location = New System.Drawing.Point(6, 83)
        Me.DG_Mercaderia.Name = "DG_Mercaderia"
        Me.DG_Mercaderia.ReadOnly = True
        Me.DG_Mercaderia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Mercaderia.Size = New System.Drawing.Size(606, 276)
        Me.DG_Mercaderia.TabIndex = 1
        '
        'Codigo
        '
        Me.Codigo.DataPropertyName = "Codigo"
        Me.Codigo.FillWeight = 76.14212!
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        '
        'Producto
        '
        Me.Producto.DataPropertyName = "Nombre"
        Me.Producto.FillWeight = 221.8605!
        Me.Producto.HeaderText = "Producto"
        Me.Producto.Name = "Producto"
        Me.Producto.ReadOnly = True
        '
        'Cantidad
        '
        Me.Cantidad.DataPropertyName = "Cantidad"
        Me.Cantidad.FillWeight = 61.18604!
        Me.Cantidad.HeaderText = "Cant."
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        '
        'Costo
        '
        Me.Costo.DataPropertyName = "Costo"
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.Costo.DefaultCellStyle = DataGridViewCellStyle3
        Me.Costo.FillWeight = 70.27398!
        Me.Costo.HeaderText = "Costo"
        Me.Costo.Name = "Costo"
        Me.Costo.ReadOnly = True
        '
        'Total
        '
        Me.Total.DataPropertyName = "Total"
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = "0"
        Me.Total.DefaultCellStyle = DataGridViewCellStyle4
        Me.Total.FillWeight = 70.53728!
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        '
        'Btn_Limpiar
        '
        Me.Btn_Limpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Limpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Limpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Limpiar.Image = Global.SistemaCinderella.My.Resources.Recursos.Update_32
        Me.Btn_Limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Limpiar.Location = New System.Drawing.Point(494, 14)
        Me.Btn_Limpiar.Name = "Btn_Limpiar"
        Me.Btn_Limpiar.Size = New System.Drawing.Size(120, 39)
        Me.Btn_Limpiar.TabIndex = 4
        Me.Btn_Limpiar.Text = "Actualizar"
        Me.Btn_Limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Limpiar.UseVisualStyleBackColor = True
        '
        'frmProveedoresCuentaCorriente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 522)
        Me.Controls.Add(Me.TabCuenta)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmProveedoresCuentaCorriente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cuenta Corriente con Proveedores"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DG_Cuentas2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_Cuentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabCuenta.ResumeLayout(False)
        Me.TabListado.ResumeLayout(False)
        Me.TabDetalle.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DG_Detalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabMercaderia.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DG_Mercaderia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DG_Cuentas As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_Msg As System.Windows.Forms.Label
    Friend WithEvents lbl_Total As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TabCuenta As System.Windows.Forms.TabControl
    Friend WithEvents TabListado As System.Windows.Forms.TabPage
    Friend WithEvents TabDetalle As System.Windows.Forms.TabPage
    Friend WithEvents DG_Detalle As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Total2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbl_Proveedor As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbl_Sucursal As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TabMercaderia As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lbl_Total3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbl_Proveedor2 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lbl_Fecha As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DG_Mercaderia As System.Windows.Forms.DataGridView
    Friend WithEvents id_Mercaderia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Concepto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Importe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Producto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Costo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Btn_Pagar As System.Windows.Forms.Button
    Friend WithEvents id_Proveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Proveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Saldo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DG_Cuentas2 As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_referencias As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Btn_Limpiar As System.Windows.Forms.Button
End Class
