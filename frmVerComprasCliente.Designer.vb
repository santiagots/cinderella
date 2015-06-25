<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVerComprasCliente
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVerComprasCliente))
        Me.TabCompras = New System.Windows.Forms.TabControl()
        Me.TabListado = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.DG_Compras = New System.Windows.Forms.DataGridView()
        Me.id_Venta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sucursal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Btn_Cerrar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblRazon = New System.Windows.Forms.Label()
        Me.lblCuit = New System.Windows.Forms.Label()
        Me.lblPrecios = New System.Windows.Forms.Label()
        Me.lblCondicion = New System.Windows.Forms.Label()
        Me.lbl_CondicionIva = New System.Windows.Forms.Label()
        Me.lbl_ListaPrecio = New System.Windows.Forms.Label()
        Me.lbl_Cuit = New System.Windows.Forms.Label()
        Me.lbl_RazonSocial = New System.Windows.Forms.Label()
        Me.TabDetalle = New System.Windows.Forms.TabPage()
        Me.lblcontenedor = New System.Windows.Forms.GroupBox()
        Me.lblEncargado = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblDescuento = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.BtnFactura = New System.Windows.Forms.Button()
        Me.lblFacturado = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.lblMonto = New System.Windows.Forms.Label()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.lblPago = New System.Windows.Forms.Label()
        Me.lblVenta = New System.Windows.Forms.Label()
        Me.lblVendedor = New System.Windows.Forms.Label()
        Me.lblSucursal = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DG_Productos = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolCompras = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblAnulado = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Btn_Cerrar2 = New System.Windows.Forms.Button()
        Me.NUMERO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODIGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANTIDAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRECIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SUBTOTAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabCompras.SuspendLayout()
        Me.TabListado.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DG_Compras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabDetalle.SuspendLayout()
        Me.lblcontenedor.SuspendLayout()
        CType(Me.DG_Productos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabCompras
        '
        Me.TabCompras.Controls.Add(Me.TabListado)
        Me.TabCompras.Controls.Add(Me.TabDetalle)
        Me.TabCompras.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TabCompras.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabCompras.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabCompras.Location = New System.Drawing.Point(0, 0)
        Me.TabCompras.Name = "TabCompras"
        Me.TabCompras.SelectedIndex = 0
        Me.TabCompras.Size = New System.Drawing.Size(544, 522)
        Me.TabCompras.TabIndex = 0
        '
        'TabListado
        '
        Me.TabListado.Controls.Add(Me.Label1)
        Me.TabListado.Controls.Add(Me.GroupBox2)
        Me.TabListado.Controls.Add(Me.Btn_Cerrar)
        Me.TabListado.Controls.Add(Me.GroupBox1)
        Me.TabListado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabListado.Location = New System.Drawing.Point(4, 29)
        Me.TabListado.Name = "TabListado"
        Me.TabListado.Padding = New System.Windows.Forms.Padding(3)
        Me.TabListado.Size = New System.Drawing.Size(536, 489)
        Me.TabListado.TabIndex = 0
        Me.TabListado.Text = "Compras"
        Me.TabListado.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 443)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(311, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "( ! ) Puede acceder al detalle de la compra haciendo doble click."
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.lblMsg)
        Me.GroupBox2.Controls.Add(Me.DG_Compras)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 141)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(518, 296)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Compras realizadas por el cliente hasta la fecha"
        '
        'lblMsg
        '
        Me.lblMsg.AutoSize = True
        Me.lblMsg.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg.Location = New System.Drawing.Point(118, 138)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(283, 24)
        Me.lblMsg.TabIndex = 1
        Me.lblMsg.Text = "El cliente no posee compras."
        Me.lblMsg.Visible = False
        '
        'DG_Compras
        '
        Me.DG_Compras.AllowUserToAddRows = False
        Me.DG_Compras.AllowUserToDeleteRows = False
        Me.DG_Compras.AllowUserToResizeRows = False
        Me.DG_Compras.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_Compras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_Compras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Compras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_Venta, Me.Fecha, Me.Importe, Me.Sucursal})
        Me.DG_Compras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DG_Compras.Location = New System.Drawing.Point(9, 21)
        Me.DG_Compras.MultiSelect = False
        Me.DG_Compras.Name = "DG_Compras"
        Me.DG_Compras.ReadOnly = True
        Me.DG_Compras.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DG_Compras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Compras.Size = New System.Drawing.Size(500, 265)
        Me.DG_Compras.TabIndex = 0
        Me.ToolCompras.SetToolTip(Me.DG_Compras, "Puede acceder al detalle de la compra haciendo doble click!")
        '
        'id_Venta
        '
        Me.id_Venta.DataPropertyName = "id_Venta"
        Me.id_Venta.HeaderText = "id_Venta"
        Me.id_Venta.Name = "id_Venta"
        Me.id_Venta.ReadOnly = True
        Me.id_Venta.Visible = False
        '
        'Fecha
        '
        Me.Fecha.DataPropertyName = "Fecha"
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Fecha.DefaultCellStyle = DataGridViewCellStyle1
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        '
        'Importe
        '
        Me.Importe.DataPropertyName = "MontoTotal"
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Importe.DefaultCellStyle = DataGridViewCellStyle2
        Me.Importe.HeaderText = "Importe"
        Me.Importe.Name = "Importe"
        Me.Importe.ReadOnly = True
        '
        'Sucursal
        '
        Me.Sucursal.DataPropertyName = "Sucursal"
        Me.Sucursal.HeaderText = "Sucursal"
        Me.Sucursal.Name = "Sucursal"
        Me.Sucursal.ReadOnly = True
        '
        'Btn_Cerrar
        '
        Me.Btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Cerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Cerrar.Image = Global.SistemaCinderella.My.Resources.Recursos.desconectado_32
        Me.Btn_Cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Cerrar.Location = New System.Drawing.Point(428, 443)
        Me.Btn_Cerrar.Name = "Btn_Cerrar"
        Me.Btn_Cerrar.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Cerrar.TabIndex = 17
        Me.Btn_Cerrar.Text = "Cerrar"
        Me.Btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolCompras.SetToolTip(Me.Btn_Cerrar, "Presione aquí para cerrar el formulario.")
        Me.Btn_Cerrar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.lblRazon)
        Me.GroupBox1.Controls.Add(Me.lblCuit)
        Me.GroupBox1.Controls.Add(Me.lblPrecios)
        Me.GroupBox1.Controls.Add(Me.lblCondicion)
        Me.GroupBox1.Controls.Add(Me.lbl_CondicionIva)
        Me.GroupBox1.Controls.Add(Me.lbl_ListaPrecio)
        Me.GroupBox1.Controls.Add(Me.lbl_Cuit)
        Me.GroupBox1.Controls.Add(Me.lbl_RazonSocial)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(518, 131)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ficha del cliente"
        '
        'lblRazon
        '
        Me.lblRazon.AutoSize = True
        Me.lblRazon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRazon.Location = New System.Drawing.Point(139, 31)
        Me.lblRazon.Name = "lblRazon"
        Me.lblRazon.Size = New System.Drawing.Size(39, 15)
        Me.lblRazon.TabIndex = 1
        Me.lblRazon.Text = "- - - - -"
        '
        'lblCuit
        '
        Me.lblCuit.AutoSize = True
        Me.lblCuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuit.Location = New System.Drawing.Point(139, 53)
        Me.lblCuit.Name = "lblCuit"
        Me.lblCuit.Size = New System.Drawing.Size(39, 15)
        Me.lblCuit.TabIndex = 2
        Me.lblCuit.Text = "- - - - -"
        '
        'lblPrecios
        '
        Me.lblPrecios.AutoSize = True
        Me.lblPrecios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecios.Location = New System.Drawing.Point(139, 75)
        Me.lblPrecios.Name = "lblPrecios"
        Me.lblPrecios.Size = New System.Drawing.Size(39, 15)
        Me.lblPrecios.TabIndex = 3
        Me.lblPrecios.Text = "- - - - -"
        '
        'lblCondicion
        '
        Me.lblCondicion.AutoSize = True
        Me.lblCondicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCondicion.Location = New System.Drawing.Point(139, 97)
        Me.lblCondicion.Name = "lblCondicion"
        Me.lblCondicion.Size = New System.Drawing.Size(39, 15)
        Me.lblCondicion.TabIndex = 4
        Me.lblCondicion.Text = "- - - - -"
        '
        'lbl_CondicionIva
        '
        Me.lbl_CondicionIva.AutoSize = True
        Me.lbl_CondicionIva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CondicionIva.Location = New System.Drawing.Point(6, 97)
        Me.lbl_CondicionIva.Name = "lbl_CondicionIva"
        Me.lbl_CondicionIva.Size = New System.Drawing.Size(123, 15)
        Me.lbl_CondicionIva.TabIndex = 24
        Me.lbl_CondicionIva.Text = "Condición de IVA :"
        '
        'lbl_ListaPrecio
        '
        Me.lbl_ListaPrecio.AutoSize = True
        Me.lbl_ListaPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ListaPrecio.Location = New System.Drawing.Point(6, 75)
        Me.lbl_ListaPrecio.Name = "lbl_ListaPrecio"
        Me.lbl_ListaPrecio.Size = New System.Drawing.Size(118, 15)
        Me.lbl_ListaPrecio.TabIndex = 23
        Me.lbl_ListaPrecio.Text = "Lista de Precios :"
        '
        'lbl_Cuit
        '
        Me.lbl_Cuit.AutoSize = True
        Me.lbl_Cuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Cuit.Location = New System.Drawing.Point(6, 53)
        Me.lbl_Cuit.Name = "lbl_Cuit"
        Me.lbl_Cuit.Size = New System.Drawing.Size(40, 15)
        Me.lbl_Cuit.TabIndex = 9
        Me.lbl_Cuit.Text = "Cuit :"
        '
        'lbl_RazonSocial
        '
        Me.lbl_RazonSocial.AutoSize = True
        Me.lbl_RazonSocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RazonSocial.Location = New System.Drawing.Point(6, 31)
        Me.lbl_RazonSocial.Name = "lbl_RazonSocial"
        Me.lbl_RazonSocial.Size = New System.Drawing.Size(100, 15)
        Me.lbl_RazonSocial.TabIndex = 8
        Me.lbl_RazonSocial.Text = "Razon Social :"
        '
        'TabDetalle
        '
        Me.TabDetalle.Controls.Add(Me.Btn_Cerrar2)
        Me.TabDetalle.Controls.Add(Me.lblcontenedor)
        Me.TabDetalle.Location = New System.Drawing.Point(4, 29)
        Me.TabDetalle.Name = "TabDetalle"
        Me.TabDetalle.Padding = New System.Windows.Forms.Padding(3)
        Me.TabDetalle.Size = New System.Drawing.Size(536, 489)
        Me.TabDetalle.TabIndex = 1
        Me.TabDetalle.Text = "Detalle"
        Me.TabDetalle.UseVisualStyleBackColor = True
        '
        'lblcontenedor
        '
        Me.lblcontenedor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblcontenedor.Controls.Add(Me.lblAnulado)
        Me.lblcontenedor.Controls.Add(Me.Label10)
        Me.lblcontenedor.Controls.Add(Me.lblEncargado)
        Me.lblcontenedor.Controls.Add(Me.Label16)
        Me.lblcontenedor.Controls.Add(Me.lblSubtotal)
        Me.lblcontenedor.Controls.Add(Me.Label15)
        Me.lblcontenedor.Controls.Add(Me.lblDescuento)
        Me.lblcontenedor.Controls.Add(Me.Label14)
        Me.lblcontenedor.Controls.Add(Me.BtnFactura)
        Me.lblcontenedor.Controls.Add(Me.lblFacturado)
        Me.lblcontenedor.Controls.Add(Me.label8)
        Me.lblcontenedor.Controls.Add(Me.lblMonto)
        Me.lblcontenedor.Controls.Add(Me.lblCantidad)
        Me.lblcontenedor.Controls.Add(Me.lblPago)
        Me.lblcontenedor.Controls.Add(Me.lblVenta)
        Me.lblcontenedor.Controls.Add(Me.lblVendedor)
        Me.lblcontenedor.Controls.Add(Me.lblSucursal)
        Me.lblcontenedor.Controls.Add(Me.lblFecha)
        Me.lblcontenedor.Controls.Add(Me.Label7)
        Me.lblcontenedor.Controls.Add(Me.Label2)
        Me.lblcontenedor.Controls.Add(Me.DG_Productos)
        Me.lblcontenedor.Controls.Add(Me.Label6)
        Me.lblcontenedor.Controls.Add(Me.Label5)
        Me.lblcontenedor.Controls.Add(Me.Label4)
        Me.lblcontenedor.Controls.Add(Me.Label3)
        Me.lblcontenedor.Controls.Add(Me.Label11)
        Me.lblcontenedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcontenedor.Location = New System.Drawing.Point(10, 6)
        Me.lblcontenedor.Name = "lblcontenedor"
        Me.lblcontenedor.Size = New System.Drawing.Size(518, 430)
        Me.lblcontenedor.TabIndex = 1
        Me.lblcontenedor.TabStop = False
        Me.lblcontenedor.Text = "Información de la venta realizada."
        '
        'lblEncargado
        '
        Me.lblEncargado.AutoSize = True
        Me.lblEncargado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEncargado.Location = New System.Drawing.Point(355, 33)
        Me.lblEncargado.Name = "lblEncargado"
        Me.lblEncargado.Size = New System.Drawing.Size(42, 15)
        Me.lblEncargado.TabIndex = 36
        Me.lblEncargado.Text = "- - - - - "
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(270, 33)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(84, 15)
        Me.Label16.TabIndex = 35
        Me.Label16.Text = "Encargado :"
        '
        'lblSubtotal
        '
        Me.lblSubtotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtotal.Location = New System.Drawing.Point(369, 353)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(42, 15)
        Me.lblSubtotal.TabIndex = 34
        Me.lblSubtotal.Text = "- - - - - "
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(281, 353)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(68, 15)
        Me.Label15.TabIndex = 33
        Me.Label15.Text = "Subtotal :"
        '
        'lblDescuento
        '
        Me.lblDescuento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDescuento.AutoSize = True
        Me.lblDescuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescuento.Location = New System.Drawing.Point(369, 329)
        Me.lblDescuento.Name = "lblDescuento"
        Me.lblDescuento.Size = New System.Drawing.Size(42, 15)
        Me.lblDescuento.TabIndex = 32
        Me.lblDescuento.Text = "- - - - - "
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(281, 329)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(83, 15)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "Descuento :"
        '
        'BtnFactura
        '
        Me.BtnFactura.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnFactura.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFactura.FlatAppearance.BorderSize = 0
        Me.BtnFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFactura.Image = Global.SistemaCinderella.My.Resources.Recursos.Detalle_Pequeno
        Me.BtnFactura.Location = New System.Drawing.Point(194, 350)
        Me.BtnFactura.Name = "BtnFactura"
        Me.BtnFactura.Size = New System.Drawing.Size(18, 18)
        Me.BtnFactura.TabIndex = 30
        Me.BtnFactura.Tag = "Ver Detalle"
        Me.BtnFactura.UseVisualStyleBackColor = True
        '
        'lblFacturado
        '
        Me.lblFacturado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblFacturado.AutoSize = True
        Me.lblFacturado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFacturado.Location = New System.Drawing.Point(146, 353)
        Me.lblFacturado.Name = "lblFacturado"
        Me.lblFacturado.Size = New System.Drawing.Size(42, 15)
        Me.lblFacturado.TabIndex = 25
        Me.lblFacturado.Text = "- - - - - "
        '
        'label8
        '
        Me.label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.Location = New System.Drawing.Point(6, 353)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(79, 15)
        Me.label8.TabIndex = 24
        Me.label8.Text = "Facturado :"
        '
        'lblMonto
        '
        Me.lblMonto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblMonto.AutoSize = True
        Me.lblMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonto.Location = New System.Drawing.Point(369, 377)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(42, 15)
        Me.lblMonto.TabIndex = 23
        Me.lblMonto.Text = "- - - - - "
        '
        'lblCantidad
        '
        Me.lblCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad.Location = New System.Drawing.Point(146, 377)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(42, 15)
        Me.lblCantidad.TabIndex = 22
        Me.lblCantidad.Text = "- - - - - "
        '
        'lblPago
        '
        Me.lblPago.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblPago.AutoSize = True
        Me.lblPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPago.Location = New System.Drawing.Point(146, 329)
        Me.lblPago.Name = "lblPago"
        Me.lblPago.Size = New System.Drawing.Size(42, 15)
        Me.lblPago.TabIndex = 21
        Me.lblPago.Text = "- - - - - "
        '
        'lblVenta
        '
        Me.lblVenta.AutoSize = True
        Me.lblVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVenta.Location = New System.Drawing.Point(121, 93)
        Me.lblVenta.Name = "lblVenta"
        Me.lblVenta.Size = New System.Drawing.Size(42, 15)
        Me.lblVenta.TabIndex = 20
        Me.lblVenta.Text = "- - - - - "
        '
        'lblVendedor
        '
        Me.lblVendedor.AutoSize = True
        Me.lblVendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVendedor.Location = New System.Drawing.Point(355, 63)
        Me.lblVendedor.Name = "lblVendedor"
        Me.lblVendedor.Size = New System.Drawing.Size(42, 15)
        Me.lblVendedor.TabIndex = 19
        Me.lblVendedor.Text = "- - - - - "
        '
        'lblSucursal
        '
        Me.lblSucursal.AutoSize = True
        Me.lblSucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSucursal.Location = New System.Drawing.Point(121, 33)
        Me.lblSucursal.Name = "lblSucursal"
        Me.lblSucursal.Size = New System.Drawing.Size(42, 15)
        Me.lblSucursal.TabIndex = 18
        Me.lblSucursal.Text = "- - - - - "
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(121, 63)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(42, 15)
        Me.lblFecha.TabIndex = 17
        Me.lblFecha.Text = "- - - - - "
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(281, 377)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 15)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Monto total :"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 377)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 15)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Cant. de productos :"
        '
        'DG_Productos
        '
        Me.DG_Productos.AllowUserToAddRows = False
        Me.DG_Productos.AllowUserToDeleteRows = False
        Me.DG_Productos.AllowUserToResizeRows = False
        Me.DG_Productos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_Productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_Productos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DG_Productos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DG_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Productos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NUMERO, Me.CODIGO, Me.NOMBRE, Me.CANTIDAD, Me.PRECIO, Me.SUBTOTAL})
        Me.DG_Productos.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.DG_Productos.Location = New System.Drawing.Point(6, 118)
        Me.DG_Productos.MultiSelect = False
        Me.DG_Productos.Name = "DG_Productos"
        Me.DG_Productos.ReadOnly = True
        Me.DG_Productos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DG_Productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Productos.Size = New System.Drawing.Size(506, 205)
        Me.DG_Productos.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Sucursal :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Fecha :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tipo de Venta :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(270, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Vendedor :"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 329)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 15)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Tipo de Pago :"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ToolCompras
        '
        Me.ToolCompras.IsBalloon = True
        Me.ToolCompras.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolCompras.ToolTipTitle = "Ayuda"
        '
        'lblAnulado
        '
        Me.lblAnulado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblAnulado.AutoSize = True
        Me.lblAnulado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnulado.Location = New System.Drawing.Point(146, 405)
        Me.lblAnulado.Name = "lblAnulado"
        Me.lblAnulado.Size = New System.Drawing.Size(42, 15)
        Me.lblAnulado.TabIndex = 38
        Me.lblAnulado.Text = "- - - - - "
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 405)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 15)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Anulada :"
        '
        'Btn_Cerrar2
        '
        Me.Btn_Cerrar2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Cerrar2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Cerrar2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Cerrar2.Image = Global.SistemaCinderella.My.Resources.Recursos.desconectado_32
        Me.Btn_Cerrar2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Cerrar2.Location = New System.Drawing.Point(428, 443)
        Me.Btn_Cerrar2.Name = "Btn_Cerrar2"
        Me.Btn_Cerrar2.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Cerrar2.TabIndex = 18
        Me.Btn_Cerrar2.Text = "Cerrar"
        Me.Btn_Cerrar2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolCompras.SetToolTip(Me.Btn_Cerrar2, "Presione aquí para cerrar el formulario.")
        Me.Btn_Cerrar2.UseVisualStyleBackColor = True
        '
        'NUMERO
        '
        Me.NUMERO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.NUMERO.FillWeight = 68.49864!
        Me.NUMERO.HeaderText = "N"
        Me.NUMERO.Name = "NUMERO"
        Me.NUMERO.ReadOnly = True
        Me.NUMERO.Width = 41
        '
        'CODIGO
        '
        Me.CODIGO.FillWeight = 107.5103!
        Me.CODIGO.HeaderText = "Código"
        Me.CODIGO.Name = "CODIGO"
        Me.CODIGO.ReadOnly = True
        '
        'NOMBRE
        '
        Me.NOMBRE.FillWeight = 177.4346!
        Me.NOMBRE.HeaderText = "Nombre"
        Me.NOMBRE.Name = "NOMBRE"
        Me.NOMBRE.ReadOnly = True
        '
        'CANTIDAD
        '
        Me.CANTIDAD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.CANTIDAD.DefaultCellStyle = DataGridViewCellStyle3
        Me.CANTIDAD.FillWeight = 73.49158!
        Me.CANTIDAD.HeaderText = "Cant."
        Me.CANTIDAD.Name = "CANTIDAD"
        Me.CANTIDAD.ReadOnly = True
        Me.CANTIDAD.Width = 60
        '
        'PRECIO
        '
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.PRECIO.DefaultCellStyle = DataGridViewCellStyle4
        Me.PRECIO.FillWeight = 81.69429!
        Me.PRECIO.HeaderText = "Precio"
        Me.PRECIO.Name = "PRECIO"
        Me.PRECIO.ReadOnly = True
        '
        'SUBTOTAL
        '
        DataGridViewCellStyle5.Format = "C2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.SUBTOTAL.DefaultCellStyle = DataGridViewCellStyle5
        Me.SUBTOTAL.FillWeight = 91.37056!
        Me.SUBTOTAL.HeaderText = "Subtotal"
        Me.SUBTOTAL.Name = "SUBTOTAL"
        Me.SUBTOTAL.ReadOnly = True
        '
        'frmVerComprasCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 522)
        Me.Controls.Add(Me.TabCompras)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmVerComprasCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compras realizadas"
        Me.TabCompras.ResumeLayout(False)
        Me.TabListado.ResumeLayout(False)
        Me.TabListado.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DG_Compras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabDetalle.ResumeLayout(False)
        Me.lblcontenedor.ResumeLayout(False)
        Me.lblcontenedor.PerformLayout()
        CType(Me.DG_Productos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabCompras As System.Windows.Forms.TabControl
    Friend WithEvents TabListado As System.Windows.Forms.TabPage
    Friend WithEvents TabDetalle As System.Windows.Forms.TabPage
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DG_Compras As System.Windows.Forms.DataGridView
    Friend WithEvents ToolCompras As System.Windows.Forms.ToolTip
    Friend WithEvents Btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Cuit As System.Windows.Forms.Label
    Friend WithEvents lbl_RazonSocial As System.Windows.Forms.Label
    Friend WithEvents lbl_CondicionIva As System.Windows.Forms.Label
    Friend WithEvents lbl_ListaPrecio As System.Windows.Forms.Label
    Friend WithEvents lblRazon As System.Windows.Forms.Label
    Friend WithEvents lblCuit As System.Windows.Forms.Label
    Friend WithEvents lblPrecios As System.Windows.Forms.Label
    Friend WithEvents lblCondicion As System.Windows.Forms.Label
    Friend WithEvents lblMsg As System.Windows.Forms.Label
    Friend WithEvents id_Venta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Importe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sucursal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblcontenedor As System.Windows.Forms.GroupBox
    Friend WithEvents lblEncargado As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblSubtotal As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblDescuento As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents BtnFactura As System.Windows.Forms.Button
    Friend WithEvents lblFacturado As System.Windows.Forms.Label
    Friend WithEvents label8 As System.Windows.Forms.Label
    Friend WithEvents lblMonto As System.Windows.Forms.Label
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents lblPago As System.Windows.Forms.Label
    Friend WithEvents lblVenta As System.Windows.Forms.Label
    Friend WithEvents lblVendedor As System.Windows.Forms.Label
    Friend WithEvents lblSucursal As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DG_Productos As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblAnulado As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Btn_Cerrar2 As System.Windows.Forms.Button
    Friend WithEvents NUMERO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CODIGO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CANTIDAD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRECIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SUBTOTAL As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
