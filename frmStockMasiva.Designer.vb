<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockMasiva
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStockMasiva))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabAlta = New System.Windows.Forms.TabPage()
        Me.Gb_Stock = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_Minimo = New System.Windows.Forms.Label()
        Me.txt_Actual = New System.Windows.Forms.TextBox()
        Me.txt_Minimo = New System.Windows.Forms.TextBox()
        Me.lbl_Actual = New System.Windows.Forms.Label()
        Me.txt_Optimo = New System.Windows.Forms.TextBox()
        Me.lbl_Optimo = New System.Windows.Forms.Label()
        Me.Gb_Producto = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_Producto = New System.Windows.Forms.Label()
        Me.Btn_Agregar = New System.Windows.Forms.Button()
        Me.Btn_BuscarCodigo = New System.Windows.Forms.Button()
        Me.txt_Cantidad = New System.Windows.Forms.TextBox()
        Me.txt_Costo = New System.Windows.Forms.TextBox()
        Me.lbl_ProductoNombre = New System.Windows.Forms.Label()
        Me.lbl_Prod = New System.Windows.Forms.Label()
        Me.lbl_Costo = New System.Windows.Forms.Label()
        Me.lbl_Cantidad = New System.Windows.Forms.Label()
        Me.txt_Codigo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_MontoTotal = New System.Windows.Forms.Label()
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.DG_Mercaderia = New System.Windows.Forms.DataGridView()
        Me.id_Producto_2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Producto_2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Costo_2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad_2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Stock_Minimo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Stock_Optimo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Stock_Actual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Eliminar_2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.lbl_Monto = New System.Windows.Forms.Label()
        Me.Btn_Ingreso = New System.Windows.Forms.Button()
        Me.lbl_Totales_Prod = New System.Windows.Forms.Label()
        Me.lbl_Totlaes = New System.Windows.Forms.Label()
        Me.Gb_Informacion = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Cb_Proveedor = New System.Windows.Forms.ComboBox()
        Me.lbl_Sucursal = New System.Windows.Forms.Label()
        Me.lbl_Proveedor = New System.Windows.Forms.Label()
        Me.lbl_Fecha = New System.Windows.Forms.Label()
        Me.FechaIngreso = New System.Windows.Forms.DateTimePicker()
        Me.txt_Sucursal = New System.Windows.Forms.Label()
        Me.TabListado = New System.Windows.Forms.TabPage()
        Me.lbl_Msg = New System.Windows.Forms.Label()
        Me.DG_Stock = New System.Windows.Forms.DataGridView()
        Me.id_Mercaderia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabStock = New System.Windows.Forms.TabControl()
        Me.TabDetalle = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lbl_MontoTotal2 = New System.Windows.Forms.Label()
        Me.DG_ProductosD = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductoD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_Totales_Prod2 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_ProveedorD = New System.Windows.Forms.Label()
        Me.lbl_FechaD = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl_SucursalD = New System.Windows.Forms.Label()
        Me.ErrorStock = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TabAlta.SuspendLayout()
        Me.Gb_Stock.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Gb_Producto.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DG_Mercaderia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gb_Informacion.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TabListado.SuspendLayout()
        CType(Me.DG_Stock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabStock.SuspendLayout()
        Me.TabDetalle.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DG_ProductosD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.ErrorStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabAlta
        '
        Me.TabAlta.Controls.Add(Me.Gb_Stock)
        Me.TabAlta.Controls.Add(Me.Gb_Producto)
        Me.TabAlta.Controls.Add(Me.GroupBox1)
        Me.TabAlta.Controls.Add(Me.Gb_Informacion)
        Me.TabAlta.Location = New System.Drawing.Point(4, 29)
        Me.TabAlta.Name = "TabAlta"
        Me.TabAlta.Padding = New System.Windows.Forms.Padding(3)
        Me.TabAlta.Size = New System.Drawing.Size(786, 639)
        Me.TabAlta.TabIndex = 1
        Me.TabAlta.Text = "Ingreso"
        Me.TabAlta.UseVisualStyleBackColor = True
        '
        'Gb_Stock
        '
        Me.Gb_Stock.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gb_Stock.Controls.Add(Me.TableLayoutPanel1)
        Me.Gb_Stock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gb_Stock.Location = New System.Drawing.Point(471, 102)
        Me.Gb_Stock.Name = "Gb_Stock"
        Me.Gb_Stock.Size = New System.Drawing.Size(307, 215)
        Me.Gb_Stock.TabIndex = 0
        Me.Gb_Stock.TabStop = False
        Me.Gb_Stock.Text = "Stock en Sucursal"
        Me.Gb_Stock.Visible = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_Minimo, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Actual, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Minimo, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_Actual, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Optimo, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_Optimo, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 17)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(301, 195)
        Me.TableLayoutPanel1.TabIndex = 12
        '
        'lbl_Minimo
        '
        Me.lbl_Minimo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl_Minimo.AutoSize = True
        Me.lbl_Minimo.Location = New System.Drawing.Point(3, 25)
        Me.lbl_Minimo.Name = "lbl_Minimo"
        Me.lbl_Minimo.Size = New System.Drawing.Size(82, 15)
        Me.lbl_Minimo.TabIndex = 7
        Me.lbl_Minimo.Text = "Stock Minimo"
        '
        'txt_Actual
        '
        Me.txt_Actual.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Actual.Location = New System.Drawing.Point(153, 152)
        Me.txt_Actual.Name = "txt_Actual"
        Me.txt_Actual.ReadOnly = True
        Me.txt_Actual.Size = New System.Drawing.Size(145, 21)
        Me.txt_Actual.TabIndex = 11
        '
        'txt_Minimo
        '
        Me.txt_Minimo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Minimo.Location = New System.Drawing.Point(153, 22)
        Me.txt_Minimo.Name = "txt_Minimo"
        Me.txt_Minimo.ReadOnly = True
        Me.txt_Minimo.Size = New System.Drawing.Size(145, 21)
        Me.txt_Minimo.TabIndex = 9
        '
        'lbl_Actual
        '
        Me.lbl_Actual.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl_Actual.AutoSize = True
        Me.lbl_Actual.Location = New System.Drawing.Point(3, 155)
        Me.lbl_Actual.Name = "lbl_Actual"
        Me.lbl_Actual.Size = New System.Drawing.Size(73, 15)
        Me.lbl_Actual.TabIndex = 8
        Me.lbl_Actual.Text = "Stock Actual"
        '
        'txt_Optimo
        '
        Me.txt_Optimo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Optimo.Location = New System.Drawing.Point(153, 87)
        Me.txt_Optimo.Name = "txt_Optimo"
        Me.txt_Optimo.ReadOnly = True
        Me.txt_Optimo.Size = New System.Drawing.Size(145, 21)
        Me.txt_Optimo.TabIndex = 10
        '
        'lbl_Optimo
        '
        Me.lbl_Optimo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl_Optimo.AutoSize = True
        Me.lbl_Optimo.Location = New System.Drawing.Point(3, 90)
        Me.lbl_Optimo.Name = "lbl_Optimo"
        Me.lbl_Optimo.Size = New System.Drawing.Size(80, 15)
        Me.lbl_Optimo.TabIndex = 9
        Me.lbl_Optimo.Text = "Stock Optimo"
        '
        'Gb_Producto
        '
        Me.Gb_Producto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gb_Producto.Controls.Add(Me.TableLayoutPanel3)
        Me.Gb_Producto.Controls.Add(Me.Label7)
        Me.Gb_Producto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gb_Producto.Location = New System.Drawing.Point(7, 102)
        Me.Gb_Producto.Name = "Gb_Producto"
        Me.Gb_Producto.Size = New System.Drawing.Size(458, 215)
        Me.Gb_Producto.TabIndex = 0
        Me.Gb_Producto.TabStop = False
        Me.Gb_Producto.Text = "Agregar productos al listado de mercadería."
        Me.Gb_Producto.Visible = False
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.lbl_Producto, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Btn_Agregar, 2, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.Btn_BuscarCodigo, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.txt_Cantidad, 1, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.txt_Costo, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.lbl_ProductoNombre, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.lbl_Prod, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.lbl_Costo, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.lbl_Cantidad, 0, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.txt_Codigo, 1, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(6, 71)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 4
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(446, 137)
        Me.TableLayoutPanel3.TabIndex = 19
        '
        'lbl_Producto
        '
        Me.lbl_Producto.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl_Producto.AutoSize = True
        Me.lbl_Producto.Location = New System.Drawing.Point(3, 0)
        Me.lbl_Producto.Name = "lbl_Producto"
        Me.lbl_Producto.Size = New System.Drawing.Size(100, 30)
        Me.lbl_Producto.TabIndex = 6
        Me.lbl_Producto.Text = "Código/ Nombre Producto (*)"
        '
        'Btn_Agregar
        '
        Me.Btn_Agregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Agregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Agregar.Image = CType(resources.GetObject("Btn_Agregar.Image"), System.Drawing.Image)
        Me.Btn_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Agregar.Location = New System.Drawing.Point(349, 94)
        Me.Btn_Agregar.Name = "Btn_Agregar"
        Me.Btn_Agregar.Size = New System.Drawing.Size(94, 40)
        Me.Btn_Agregar.TabIndex = 12
        Me.Btn_Agregar.Text = "Agregar"
        Me.Btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Agregar.UseVisualStyleBackColor = True
        '
        'Btn_BuscarCodigo
        '
        Me.Btn_BuscarCodigo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Btn_BuscarCodigo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_BuscarCodigo.FlatAppearance.BorderSize = 0
        Me.Btn_BuscarCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_BuscarCodigo.Image = Global.SistemaCinderella.My.Resources.Recursos.Lupa
        Me.Btn_BuscarCodigo.Location = New System.Drawing.Point(349, 4)
        Me.Btn_BuscarCodigo.Name = "Btn_BuscarCodigo"
        Me.Btn_BuscarCodigo.Size = New System.Drawing.Size(22, 22)
        Me.Btn_BuscarCodigo.TabIndex = 5
        Me.Btn_BuscarCodigo.UseVisualStyleBackColor = True
        '
        'txt_Cantidad
        '
        Me.txt_Cantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Cantidad.Location = New System.Drawing.Point(153, 103)
        Me.txt_Cantidad.Name = "txt_Cantidad"
        Me.txt_Cantidad.Size = New System.Drawing.Size(190, 21)
        Me.txt_Cantidad.TabIndex = 8
        '
        'txt_Costo
        '
        Me.txt_Costo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Costo.Location = New System.Drawing.Point(153, 64)
        Me.txt_Costo.Name = "txt_Costo"
        Me.txt_Costo.ReadOnly = True
        Me.txt_Costo.Size = New System.Drawing.Size(190, 21)
        Me.txt_Costo.TabIndex = 7
        '
        'lbl_ProductoNombre
        '
        Me.lbl_ProductoNombre.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl_ProductoNombre.AutoSize = True
        Me.lbl_ProductoNombre.Location = New System.Drawing.Point(153, 37)
        Me.lbl_ProductoNombre.Name = "lbl_ProductoNombre"
        Me.lbl_ProductoNombre.Size = New System.Drawing.Size(25, 15)
        Me.lbl_ProductoNombre.TabIndex = 6
        Me.lbl_ProductoNombre.Text = "- - -"
        '
        'lbl_Prod
        '
        Me.lbl_Prod.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl_Prod.AutoSize = True
        Me.lbl_Prod.Location = New System.Drawing.Point(3, 37)
        Me.lbl_Prod.Name = "lbl_Prod"
        Me.lbl_Prod.Size = New System.Drawing.Size(56, 15)
        Me.lbl_Prod.TabIndex = 22
        Me.lbl_Prod.Text = "Producto"
        '
        'lbl_Costo
        '
        Me.lbl_Costo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl_Costo.AutoSize = True
        Me.lbl_Costo.Location = New System.Drawing.Point(3, 67)
        Me.lbl_Costo.Name = "lbl_Costo"
        Me.lbl_Costo.Size = New System.Drawing.Size(84, 15)
        Me.lbl_Costo.TabIndex = 17
        Me.lbl_Costo.Text = "Costo Unitario"
        '
        'lbl_Cantidad
        '
        Me.lbl_Cantidad.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl_Cantidad.AutoSize = True
        Me.lbl_Cantidad.Location = New System.Drawing.Point(3, 106)
        Me.lbl_Cantidad.Name = "lbl_Cantidad"
        Me.lbl_Cantidad.Size = New System.Drawing.Size(72, 15)
        Me.lbl_Cantidad.TabIndex = 19
        Me.lbl_Cantidad.Text = "Cantidad (*)"
        '
        'txt_Codigo
        '
        Me.txt_Codigo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Codigo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_Codigo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_Codigo.Location = New System.Drawing.Point(153, 4)
        Me.txt_Codigo.Name = "txt_Codigo"
        Me.txt_Codigo.Size = New System.Drawing.Size(190, 21)
        Me.txt_Codigo.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(9, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(443, 50)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Para agregar productos al listado de mercaderías puede buscarlos a través del bus" &
    "cador (haciendo click en la lupa) o bien, ingresando el código o nombre de produ" &
    "cto manualmente."
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.lbl_MontoTotal)
        Me.GroupBox1.Controls.Add(Me.Btn_Cancelar)
        Me.GroupBox1.Controls.Add(Me.DG_Mercaderia)
        Me.GroupBox1.Controls.Add(Me.lbl_Monto)
        Me.GroupBox1.Controls.Add(Me.Btn_Ingreso)
        Me.GroupBox1.Controls.Add(Me.lbl_Totales_Prod)
        Me.GroupBox1.Controls.Add(Me.lbl_Totlaes)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(5, 316)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(773, 317)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mercadería a ingresar a la sucursal."
        '
        'lbl_MontoTotal
        '
        Me.lbl_MontoTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_MontoTotal.AutoSize = True
        Me.lbl_MontoTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MontoTotal.Location = New System.Drawing.Point(366, 278)
        Me.lbl_MontoTotal.Name = "lbl_MontoTotal"
        Me.lbl_MontoTotal.Size = New System.Drawing.Size(28, 18)
        Me.lbl_MontoTotal.TabIndex = 18
        Me.lbl_MontoTotal.Text = "$ 0"
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Cancelar.Image = Global.SistemaCinderella.My.Resources.Recursos.desconectado_32
        Me.Btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Cancelar.Location = New System.Drawing.Point(562, 271)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Cancelar.TabIndex = 13
        Me.Btn_Cancelar.Text = "Cancelar"
        Me.Btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Cancelar.UseVisualStyleBackColor = True
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
        Me.DG_Mercaderia.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_Producto_2, Me.Producto_2, Me.Costo_2, Me.Cantidad_2, Me.Subtotal, Me.Stock_Minimo, Me.Stock_Optimo, Me.Stock_Actual, Me.Eliminar_2})
        Me.DG_Mercaderia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DG_Mercaderia.Location = New System.Drawing.Point(6, 20)
        Me.DG_Mercaderia.Name = "DG_Mercaderia"
        Me.DG_Mercaderia.ReadOnly = True
        Me.DG_Mercaderia.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DG_Mercaderia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Mercaderia.Size = New System.Drawing.Size(762, 245)
        Me.DG_Mercaderia.TabIndex = 15
        '
        'id_Producto_2
        '
        Me.id_Producto_2.FillWeight = 116.9243!
        Me.id_Producto_2.HeaderText = "id_Producto"
        Me.id_Producto_2.Name = "id_Producto_2"
        Me.id_Producto_2.ReadOnly = True
        '
        'Producto_2
        '
        Me.Producto_2.FillWeight = 159.8985!
        Me.Producto_2.HeaderText = "Producto"
        Me.Producto_2.Name = "Producto_2"
        Me.Producto_2.ReadOnly = True
        '
        'Costo_2
        '
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = "0"
        Me.Costo_2.DefaultCellStyle = DataGridViewCellStyle1
        Me.Costo_2.FillWeight = 67.53368!
        Me.Costo_2.HeaderText = "Costo"
        Me.Costo_2.Name = "Costo_2"
        Me.Costo_2.ReadOnly = True
        '
        'Cantidad_2
        '
        Me.Cantidad_2.FillWeight = 67.84171!
        Me.Cantidad_2.HeaderText = "Cantidad"
        Me.Cantidad_2.Name = "Cantidad_2"
        Me.Cantidad_2.ReadOnly = True
        '
        'Subtotal
        '
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = "0"
        Me.Subtotal.DefaultCellStyle = DataGridViewCellStyle2
        Me.Subtotal.FillWeight = 87.00771!
        Me.Subtotal.HeaderText = "Subtotal"
        Me.Subtotal.Name = "Subtotal"
        Me.Subtotal.ReadOnly = True
        '
        'Stock_Minimo
        '
        Me.Stock_Minimo.FillWeight = 116.9243!
        Me.Stock_Minimo.HeaderText = "S. Minimo"
        Me.Stock_Minimo.Name = "Stock_Minimo"
        Me.Stock_Minimo.ReadOnly = True
        '
        'Stock_Optimo
        '
        Me.Stock_Optimo.FillWeight = 116.9243!
        Me.Stock_Optimo.HeaderText = "S. Optimo"
        Me.Stock_Optimo.Name = "Stock_Optimo"
        Me.Stock_Optimo.ReadOnly = True
        '
        'Stock_Actual
        '
        Me.Stock_Actual.FillWeight = 116.9243!
        Me.Stock_Actual.HeaderText = "S. Actual"
        Me.Stock_Actual.Name = "Stock_Actual"
        Me.Stock_Actual.ReadOnly = True
        '
        'Eliminar_2
        '
        Me.Eliminar_2.FillWeight = 50.02111!
        Me.Eliminar_2.HeaderText = "Eliminar"
        Me.Eliminar_2.Image = Global.SistemaCinderella.My.Resources.Recursos.Boton_Eliminar
        Me.Eliminar_2.Name = "Eliminar_2"
        Me.Eliminar_2.ReadOnly = True
        Me.Eliminar_2.ToolTipText = "Eliminar Producto"
        '
        'lbl_Monto
        '
        Me.lbl_Monto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_Monto.AutoSize = True
        Me.lbl_Monto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Monto.Location = New System.Drawing.Point(239, 278)
        Me.lbl_Monto.Name = "lbl_Monto"
        Me.lbl_Monto.Size = New System.Drawing.Size(104, 18)
        Me.lbl_Monto.TabIndex = 17
        Me.lbl_Monto.Text = "Monto Total:"
        '
        'Btn_Ingreso
        '
        Me.Btn_Ingreso.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Ingreso.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Ingreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Ingreso.Image = Global.SistemaCinderella.My.Resources.Recursos.Conectado_32
        Me.Btn_Ingreso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Ingreso.Location = New System.Drawing.Point(668, 271)
        Me.Btn_Ingreso.Name = "Btn_Ingreso"
        Me.Btn_Ingreso.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Ingreso.TabIndex = 14
        Me.Btn_Ingreso.Text = "Finalizar"
        Me.Btn_Ingreso.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Ingreso.UseVisualStyleBackColor = True
        '
        'lbl_Totales_Prod
        '
        Me.lbl_Totales_Prod.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_Totales_Prod.AutoSize = True
        Me.lbl_Totales_Prod.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Totales_Prod.Location = New System.Drawing.Point(181, 278)
        Me.lbl_Totales_Prod.Name = "lbl_Totales_Prod"
        Me.lbl_Totales_Prod.Size = New System.Drawing.Size(16, 18)
        Me.lbl_Totales_Prod.TabIndex = 16
        Me.lbl_Totales_Prod.Text = "0"
        '
        'lbl_Totlaes
        '
        Me.lbl_Totlaes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_Totlaes.AutoSize = True
        Me.lbl_Totlaes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Totlaes.Location = New System.Drawing.Point(3, 278)
        Me.lbl_Totlaes.Name = "lbl_Totlaes"
        Me.lbl_Totlaes.Size = New System.Drawing.Size(157, 18)
        Me.lbl_Totlaes.TabIndex = 15
        Me.lbl_Totlaes.Text = "Total de Productos:"
        '
        'Gb_Informacion
        '
        Me.Gb_Informacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gb_Informacion.Controls.Add(Me.TableLayoutPanel2)
        Me.Gb_Informacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gb_Informacion.Location = New System.Drawing.Point(7, 7)
        Me.Gb_Informacion.Name = "Gb_Informacion"
        Me.Gb_Informacion.Size = New System.Drawing.Size(771, 89)
        Me.Gb_Informacion.TabIndex = 24
        Me.Gb_Informacion.TabStop = False
        Me.Gb_Informacion.Text = "Información general."
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 5
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Cb_Proveedor, 4, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_Sucursal, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_Proveedor, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_Fecha, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.FechaIngreso, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_Sucursal, 1, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(6, 18)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(759, 60)
        Me.TableLayoutPanel2.TabIndex = 19
        '
        'Cb_Proveedor
        '
        Me.Cb_Proveedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cb_Proveedor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cb_Proveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Proveedor.FormattingEnabled = True
        Me.Cb_Proveedor.Location = New System.Drawing.Point(593, 33)
        Me.Cb_Proveedor.Name = "Cb_Proveedor"
        Me.Cb_Proveedor.Size = New System.Drawing.Size(163, 23)
        Me.Cb_Proveedor.TabIndex = 2
        '
        'lbl_Sucursal
        '
        Me.lbl_Sucursal.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl_Sucursal.AutoSize = True
        Me.lbl_Sucursal.Location = New System.Drawing.Point(3, 7)
        Me.lbl_Sucursal.Name = "lbl_Sucursal"
        Me.lbl_Sucursal.Size = New System.Drawing.Size(55, 15)
        Me.lbl_Sucursal.TabIndex = 5
        Me.lbl_Sucursal.Text = "Sucursal"
        '
        'lbl_Proveedor
        '
        Me.lbl_Proveedor.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl_Proveedor.AutoSize = True
        Me.lbl_Proveedor.Location = New System.Drawing.Point(493, 37)
        Me.lbl_Proveedor.Name = "lbl_Proveedor"
        Me.lbl_Proveedor.Size = New System.Drawing.Size(63, 15)
        Me.lbl_Proveedor.TabIndex = 15
        Me.lbl_Proveedor.Text = "Proveedor"
        '
        'lbl_Fecha
        '
        Me.lbl_Fecha.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl_Fecha.AutoSize = True
        Me.lbl_Fecha.Location = New System.Drawing.Point(3, 37)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(57, 15)
        Me.lbl_Fecha.TabIndex = 20
        Me.lbl_Fecha.Text = "Fecha (*)"
        '
        'FechaIngreso
        '
        Me.FechaIngreso.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FechaIngreso.CustomFormat = ""
        Me.FechaIngreso.Location = New System.Drawing.Point(103, 34)
        Me.FechaIngreso.MinDate = New Date(2011, 1, 1, 0, 0, 0, 0)
        Me.FechaIngreso.Name = "FechaIngreso"
        Me.FechaIngreso.Size = New System.Drawing.Size(273, 21)
        Me.FechaIngreso.TabIndex = 3
        '
        'txt_Sucursal
        '
        Me.txt_Sucursal.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_Sucursal.AutoSize = True
        Me.txt_Sucursal.Location = New System.Drawing.Point(103, 7)
        Me.txt_Sucursal.Name = "txt_Sucursal"
        Me.txt_Sucursal.Size = New System.Drawing.Size(72, 15)
        Me.txt_Sucursal.TabIndex = 1
        Me.txt_Sucursal.Text = "SUCURSAL"
        '
        'TabListado
        '
        Me.TabListado.Controls.Add(Me.lbl_Msg)
        Me.TabListado.Controls.Add(Me.DG_Stock)
        Me.TabListado.Location = New System.Drawing.Point(4, 29)
        Me.TabListado.Name = "TabListado"
        Me.TabListado.Padding = New System.Windows.Forms.Padding(3)
        Me.TabListado.Size = New System.Drawing.Size(786, 639)
        Me.TabListado.TabIndex = 0
        Me.TabListado.Text = "Mercadería"
        Me.TabListado.UseVisualStyleBackColor = True
        '
        'lbl_Msg
        '
        Me.lbl_Msg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Msg.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lbl_Msg.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Msg.Location = New System.Drawing.Point(112, 305)
        Me.lbl_Msg.Name = "lbl_Msg"
        Me.lbl_Msg.Size = New System.Drawing.Size(560, 29)
        Me.lbl_Msg.TabIndex = 5
        Me.lbl_Msg.Text = "No se han encontrado ingresos de mercadería."
        Me.lbl_Msg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DG_Stock
        '
        Me.DG_Stock.AllowUserToAddRows = False
        Me.DG_Stock.AllowUserToDeleteRows = False
        Me.DG_Stock.AllowUserToResizeColumns = False
        Me.DG_Stock.AllowUserToResizeRows = False
        Me.DG_Stock.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_Stock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_Stock.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_Mercaderia, Me.Proveedor, Me.Fecha, Me.CantidadTotal, Me.MontoTotal})
        Me.DG_Stock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DG_Stock.Location = New System.Drawing.Point(7, 7)
        Me.DG_Stock.MultiSelect = False
        Me.DG_Stock.Name = "DG_Stock"
        Me.DG_Stock.ReadOnly = True
        Me.DG_Stock.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DG_Stock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Stock.Size = New System.Drawing.Size(771, 624)
        Me.DG_Stock.TabIndex = 0
        '
        'id_Mercaderia
        '
        Me.id_Mercaderia.DataPropertyName = "id_Mercaderia"
        Me.id_Mercaderia.FillWeight = 86.29051!
        Me.id_Mercaderia.HeaderText = "ID"
        Me.id_Mercaderia.Name = "id_Mercaderia"
        Me.id_Mercaderia.ReadOnly = True
        Me.id_Mercaderia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Proveedor
        '
        Me.Proveedor.DataPropertyName = "Proveedor"
        Me.Proveedor.FillWeight = 121.8274!
        Me.Proveedor.HeaderText = "Proveedor"
        Me.Proveedor.Name = "Proveedor"
        Me.Proveedor.ReadOnly = True
        Me.Proveedor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Fecha
        '
        Me.Fecha.DataPropertyName = "Fecha"
        Me.Fecha.FillWeight = 98.52949!
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'CantidadTotal
        '
        Me.CantidadTotal.DataPropertyName = "CantidadTotal"
        Me.CantidadTotal.FillWeight = 93.35258!
        Me.CantidadTotal.HeaderText = "Cantidad de Productos"
        Me.CantidadTotal.Name = "CantidadTotal"
        Me.CantidadTotal.ReadOnly = True
        '
        'MontoTotal
        '
        Me.MontoTotal.DataPropertyName = "MontoTotal"
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.MontoTotal.DefaultCellStyle = DataGridViewCellStyle3
        Me.MontoTotal.HeaderText = "Monto Total"
        Me.MontoTotal.Name = "MontoTotal"
        Me.MontoTotal.ReadOnly = True
        '
        'TabStock
        '
        Me.TabStock.Controls.Add(Me.TabListado)
        Me.TabStock.Controls.Add(Me.TabAlta)
        Me.TabStock.Controls.Add(Me.TabDetalle)
        Me.TabStock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabStock.Location = New System.Drawing.Point(0, 0)
        Me.TabStock.Name = "TabStock"
        Me.TabStock.SelectedIndex = 0
        Me.TabStock.Size = New System.Drawing.Size(794, 672)
        Me.TabStock.TabIndex = 1
        '
        'TabDetalle
        '
        Me.TabDetalle.Controls.Add(Me.GroupBox3)
        Me.TabDetalle.Controls.Add(Me.GroupBox4)
        Me.TabDetalle.Location = New System.Drawing.Point(4, 29)
        Me.TabDetalle.Name = "TabDetalle"
        Me.TabDetalle.Size = New System.Drawing.Size(786, 639)
        Me.TabDetalle.TabIndex = 2
        Me.TabDetalle.Text = "Detalle"
        Me.TabDetalle.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.lbl_MontoTotal2)
        Me.GroupBox3.Controls.Add(Me.DG_ProductosD)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.lbl_Totales_Prod2)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(7, 97)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(771, 534)
        Me.GroupBox3.TabIndex = 25
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Mercadería Ingresada en la sucursal."
        '
        'lbl_MontoTotal2
        '
        Me.lbl_MontoTotal2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_MontoTotal2.AutoSize = True
        Me.lbl_MontoTotal2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MontoTotal2.Location = New System.Drawing.Point(421, 498)
        Me.lbl_MontoTotal2.Name = "lbl_MontoTotal2"
        Me.lbl_MontoTotal2.Size = New System.Drawing.Size(28, 18)
        Me.lbl_MontoTotal2.TabIndex = 18
        Me.lbl_MontoTotal2.Text = "$ 0"
        '
        'DG_ProductosD
        '
        Me.DG_ProductosD.AllowUserToAddRows = False
        Me.DG_ProductosD.AllowUserToDeleteRows = False
        Me.DG_ProductosD.AllowUserToResizeRows = False
        Me.DG_ProductosD.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_ProductosD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_ProductosD.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DG_ProductosD.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DG_ProductosD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_ProductosD.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.ProductoD, Me.CostoD, Me.CantidadD, Me.MontoD})
        Me.DG_ProductosD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DG_ProductosD.Location = New System.Drawing.Point(6, 20)
        Me.DG_ProductosD.Name = "DG_ProductosD"
        Me.DG_ProductosD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_ProductosD.Size = New System.Drawing.Size(759, 465)
        Me.DG_ProductosD.TabIndex = 15
        '
        'Codigo
        '
        Me.Codigo.DataPropertyName = "Codigo"
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        '
        'ProductoD
        '
        Me.ProductoD.DataPropertyName = "Nombre"
        Me.ProductoD.FillWeight = 203.0457!
        Me.ProductoD.HeaderText = "Producto"
        Me.ProductoD.Name = "ProductoD"
        '
        'CostoD
        '
        Me.CostoD.DataPropertyName = "Costo"
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = "0"
        Me.CostoD.DefaultCellStyle = DataGridViewCellStyle4
        Me.CostoD.FillWeight = 65.49438!
        Me.CostoD.HeaderText = "Costo"
        Me.CostoD.Name = "CostoD"
        '
        'CantidadD
        '
        Me.CantidadD.DataPropertyName = "Cantidad"
        Me.CantidadD.FillWeight = 62.87168!
        Me.CantidadD.HeaderText = "Cantidad"
        Me.CantidadD.Name = "CantidadD"
        '
        'MontoD
        '
        Me.MontoD.DataPropertyName = "Total"
        DataGridViewCellStyle5.Format = "C2"
        DataGridViewCellStyle5.NullValue = "0"
        Me.MontoD.DefaultCellStyle = DataGridViewCellStyle5
        Me.MontoD.FillWeight = 68.58823!
        Me.MontoD.HeaderText = "SubTotal"
        Me.MontoD.Name = "MontoD"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 498)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(157, 18)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Total de Productos:"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(311, 498)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 18)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Monto Total:"
        '
        'lbl_Totales_Prod2
        '
        Me.lbl_Totales_Prod2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_Totales_Prod2.AutoSize = True
        Me.lbl_Totales_Prod2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Totales_Prod2.Location = New System.Drawing.Point(166, 498)
        Me.lbl_Totales_Prod2.Name = "lbl_Totales_Prod2"
        Me.lbl_Totales_Prod2.Size = New System.Drawing.Size(16, 18)
        Me.lbl_Totales_Prod2.TabIndex = 16
        Me.lbl_Totales_Prod2.Text = "0"
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.TableLayoutPanel4)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(7, 7)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(771, 84)
        Me.GroupBox4.TabIndex = 24
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Información general."
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel4.ColumnCount = 5
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.Controls.Add(Me.lbl_ProveedorD, 4, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.lbl_FechaD, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label6, 3, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label8, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label9, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.lbl_SucursalD, 1, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(6, 17)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(759, 60)
        Me.TableLayoutPanel4.TabIndex = 19
        '
        'lbl_ProveedorD
        '
        Me.lbl_ProveedorD.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl_ProveedorD.AutoSize = True
        Me.lbl_ProveedorD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ProveedorD.Location = New System.Drawing.Point(575, 7)
        Me.lbl_ProveedorD.Name = "lbl_ProveedorD"
        Me.lbl_ProveedorD.Size = New System.Drawing.Size(44, 16)
        Me.lbl_ProveedorD.TabIndex = 21
        Me.lbl_ProveedorD.Text = "PEPE"
        '
        'lbl_FechaD
        '
        Me.lbl_FechaD.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl_FechaD.AutoSize = True
        Me.lbl_FechaD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_FechaD.Location = New System.Drawing.Point(103, 37)
        Me.lbl_FechaD.Name = "lbl_FechaD"
        Me.lbl_FechaD.Size = New System.Drawing.Size(72, 16)
        Me.lbl_FechaD.TabIndex = 22
        Me.lbl_FechaD.Text = "10/10/1987"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(475, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 16)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Proveedor:"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 7)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 16)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Sucursal:"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 37)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 16)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Fecha:"
        '
        'lbl_SucursalD
        '
        Me.lbl_SucursalD.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl_SucursalD.AutoSize = True
        Me.lbl_SucursalD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SucursalD.Location = New System.Drawing.Point(103, 7)
        Me.lbl_SucursalD.Name = "lbl_SucursalD"
        Me.lbl_SucursalD.Size = New System.Drawing.Size(81, 16)
        Me.lbl_SucursalD.TabIndex = 1
        Me.lbl_SucursalD.Text = "SUCURSAL"
        '
        'ErrorStock
        '
        Me.ErrorStock.BlinkRate = 200
        Me.ErrorStock.ContainerControl = Me
        '
        'frmStockMasiva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 672)
        Me.Controls.Add(Me.TabStock)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmStockMasiva"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso de Mercadería a la sucursal"
        Me.TabAlta.ResumeLayout(False)
        Me.Gb_Stock.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Gb_Producto.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DG_Mercaderia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gb_Informacion.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TabListado.ResumeLayout(False)
        CType(Me.DG_Stock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabStock.ResumeLayout(False)
        Me.TabDetalle.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DG_ProductosD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        CType(Me.ErrorStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabAlta As System.Windows.Forms.TabPage
    Friend WithEvents Btn_BuscarCodigo As System.Windows.Forms.Button
    Friend WithEvents txt_Codigo As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Agregar As System.Windows.Forms.Button
    Friend WithEvents lbl_Optimo As System.Windows.Forms.Label
    Friend WithEvents lbl_Actual As System.Windows.Forms.Label
    Friend WithEvents lbl_Minimo As System.Windows.Forms.Label
    Friend WithEvents lbl_Producto As System.Windows.Forms.Label
    Friend WithEvents lbl_Sucursal As System.Windows.Forms.Label
    Friend WithEvents txt_Sucursal As System.Windows.Forms.Label
    Friend WithEvents txt_Optimo As System.Windows.Forms.TextBox
    Friend WithEvents txt_Actual As System.Windows.Forms.TextBox
    Friend WithEvents txt_Minimo As System.Windows.Forms.TextBox
    Friend WithEvents TabListado As System.Windows.Forms.TabPage
    Friend WithEvents DG_Stock As System.Windows.Forms.DataGridView
    Friend WithEvents TabStock As System.Windows.Forms.TabControl
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents DG_Mercaderia As System.Windows.Forms.DataGridView
    Friend WithEvents Btn_Ingreso As System.Windows.Forms.Button
    Friend WithEvents lbl_Cantidad As System.Windows.Forms.Label
    Friend WithEvents txt_Cantidad As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Costo As System.Windows.Forms.Label
    Friend WithEvents txt_Costo As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Proveedor As System.Windows.Forms.Label
    Friend WithEvents Cb_Proveedor As System.Windows.Forms.ComboBox
    Friend WithEvents FechaIngreso As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Fecha As System.Windows.Forms.Label
    Friend WithEvents Gb_Stock As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_ProductoNombre As System.Windows.Forms.Label
    Friend WithEvents lbl_Prod As System.Windows.Forms.Label
    Friend WithEvents lbl_Totales_Prod As System.Windows.Forms.Label
    Friend WithEvents lbl_Totlaes As System.Windows.Forms.Label
    Friend WithEvents lbl_MontoTotal As System.Windows.Forms.Label
    Friend WithEvents lbl_Monto As System.Windows.Forms.Label
    Friend WithEvents Gb_Informacion As System.Windows.Forms.GroupBox
    Friend WithEvents TabDetalle As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_MontoTotal2 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_Totales_Prod2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DG_ProductosD As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_FechaD As System.Windows.Forms.Label
    Friend WithEvents lbl_ProveedorD As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbl_SucursalD As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents id_Mercaderia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Proveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MontoTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lbl_Msg As System.Windows.Forms.Label
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductoD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostoD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MontoD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ErrorStock As System.Windows.Forms.ErrorProvider
    Friend WithEvents Gb_Producto As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents id_Producto_2 As DataGridViewTextBoxColumn
    Friend WithEvents Producto_2 As DataGridViewTextBoxColumn
    Friend WithEvents Costo_2 As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad_2 As DataGridViewTextBoxColumn
    Friend WithEvents Subtotal As DataGridViewTextBoxColumn
    Friend WithEvents Stock_Minimo As DataGridViewTextBoxColumn
    Friend WithEvents Stock_Optimo As DataGridViewTextBoxColumn
    Friend WithEvents Stock_Actual As DataGridViewTextBoxColumn
    Friend WithEvents Eliminar_2 As DataGridViewImageColumn
End Class
