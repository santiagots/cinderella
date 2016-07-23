<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVentas))
        Me.DG_Productos = New System.Windows.Forms.DataGridView()
        Me.txt_CodigoBarra = New System.Windows.Forms.TextBox()
        Me.Btn_Finalizar = New System.Windows.Forms.Button()
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.Btn_Agregar = New System.Windows.Forms.Button()
        Me.lbl_CodigoBarra = New System.Windows.Forms.Label()
        Me.lbl_DescrTot = New System.Windows.Forms.Label()
        Me.Gb_Producto = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Btn_Cambiar = New System.Windows.Forms.Button()
        Me.Gb_Cliente = New System.Windows.Forms.GroupBox()
        Me.Btn_BuscarCliente = New System.Windows.Forms.Button()
        Me.txt_RazonSocial = New System.Windows.Forms.TextBox()
        Me.txt_id_Cliente = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Gb_Vendedor = New System.Windows.Forms.GroupBox()
        Me.Cb_Encargados = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cb_Tipo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Cb_Vendedores = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GB_Fecha = New System.Windows.Forms.GroupBox()
        Me.lbl_Sucursal = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_Fecha = New System.Windows.Forms.Label()
        Me.lbl_Hora = New System.Windows.Forms.Label()
        Me.Reloj = New System.Windows.Forms.Timer(Me.components)
        Me.GB_TipoPago = New System.Windows.Forms.GroupBox()
        Me.Cb_TipoPago = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ToolProd = New System.Windows.Forms.ToolTip(Me.components)
        Me.txt_DescuentoMinorista = New System.Windows.Forms.TextBox()
        Me.lbl_DesTot = New System.Windows.Forms.Label()
        Me.txt_TotalMinorista = New System.Windows.Forms.TextBox()
        Me.txt_SubtotalMinorista = New System.Windows.Forms.TextBox()
        Me.lbl_subTotal = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GB_ListaPrecio = New System.Windows.Forms.GroupBox()
        Me.Cb_ListaPrecio = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_ivaTotalMayorista = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.PanelTotalMayorista = New System.Windows.Forms.Panel()
        Me.NUMERO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODIGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANTIDAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRECIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MONTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SUBTOTAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ELIMINAR = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Precio1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_SubtotalMayorista = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txt_TotalMayorista = New System.Windows.Forms.TextBox()
        Me.txt_DescuentoMayorista = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.PanelTotalMinorista = New System.Windows.Forms.Panel()
        CType(Me.DG_Productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gb_Producto.SuspendLayout()
        Me.Gb_Cliente.SuspendLayout()
        Me.Gb_Vendedor.SuspendLayout()
        Me.GB_Fecha.SuspendLayout()
        Me.GB_TipoPago.SuspendLayout()
        Me.GB_ListaPrecio.SuspendLayout()
        Me.PanelTotalMayorista.SuspendLayout()
        Me.PanelTotalMinorista.SuspendLayout()
        Me.SuspendLayout()
        '
        'DG_Productos
        '
        Me.DG_Productos.AllowUserToAddRows = False
        Me.DG_Productos.AllowUserToDeleteRows = False
        Me.DG_Productos.AllowUserToResizeColumns = False
        Me.DG_Productos.AllowUserToResizeRows = False
        Me.DG_Productos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_Productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_Productos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DG_Productos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DG_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Productos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NUMERO, Me.ID, Me.CODIGO, Me.NOMBRE, Me.CANTIDAD, Me.PRECIO, Me.IVA, Me.MONTO, Me.SUBTOTAL, Me.ELIMINAR, Me.Precio1, Me.Precio2, Me.Precio3, Me.Precio4, Me.Precio5, Me.Precio6})
        Me.DG_Productos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DG_Productos.Location = New System.Drawing.Point(17, 326)
        Me.DG_Productos.Name = "DG_Productos"
        Me.DG_Productos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DG_Productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Productos.Size = New System.Drawing.Size(922, 264)
        Me.DG_Productos.TabIndex = 12
        '
        'txt_CodigoBarra
        '
        Me.txt_CodigoBarra.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_CodigoBarra.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_CodigoBarra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CodigoBarra.Location = New System.Drawing.Point(229, 66)
        Me.txt_CodigoBarra.Name = "txt_CodigoBarra"
        Me.txt_CodigoBarra.Size = New System.Drawing.Size(187, 21)
        Me.txt_CodigoBarra.TabIndex = 7
        '
        'Btn_Finalizar
        '
        Me.Btn_Finalizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Finalizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Finalizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Finalizar.Image = Global.SistemaCinderella.My.Resources.Recursos.Conectado_32
        Me.Btn_Finalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Finalizar.Location = New System.Drawing.Point(838, 760)
        Me.Btn_Finalizar.Name = "Btn_Finalizar"
        Me.Btn_Finalizar.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Finalizar.TabIndex = 17
        Me.Btn_Finalizar.Text = "Finalizar"
        Me.Btn_Finalizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolProd.SetToolTip(Me.Btn_Finalizar, "Finaliza la venta actual. ")
        Me.Btn_Finalizar.UseVisualStyleBackColor = True
        Me.Btn_Finalizar.Visible = False
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Cancelar.Image = Global.SistemaCinderella.My.Resources.Recursos.desconectado_32
        Me.Btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Cancelar.Location = New System.Drawing.Point(10, 760)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Cancelar.TabIndex = 16
        Me.Btn_Cancelar.Text = "Cancelar"
        Me.Btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolProd.SetToolTip(Me.Btn_Cancelar, "Cancela la venta actual.")
        Me.Btn_Cancelar.UseVisualStyleBackColor = True
        '
        'Btn_Agregar
        '
        Me.Btn_Agregar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Btn_Agregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Agregar.Image = Global.SistemaCinderella.My.Resources.Recursos.Productos_32
        Me.Btn_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Agregar.Location = New System.Drawing.Point(459, 22)
        Me.Btn_Agregar.Name = "Btn_Agregar"
        Me.Btn_Agregar.Size = New System.Drawing.Size(103, 44)
        Me.Btn_Agregar.TabIndex = 8
        Me.Btn_Agregar.Text = "Agregar"
        Me.Btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolProd.SetToolTip(Me.Btn_Agregar, "Permite buscar productos en el sistema por nombre / código.")
        Me.Btn_Agregar.UseVisualStyleBackColor = True
        '
        'lbl_CodigoBarra
        '
        Me.lbl_CodigoBarra.AutoSize = True
        Me.lbl_CodigoBarra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CodigoBarra.Location = New System.Drawing.Point(10, 69)
        Me.lbl_CodigoBarra.Name = "lbl_CodigoBarra"
        Me.lbl_CodigoBarra.Size = New System.Drawing.Size(169, 15)
        Me.lbl_CodigoBarra.TabIndex = 7
        Me.lbl_CodigoBarra.Text = "Nombre / Código de Producto"
        '
        'lbl_DescrTot
        '
        Me.lbl_DescrTot.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_DescrTot.AutoSize = True
        Me.lbl_DescrTot.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DescrTot.Location = New System.Drawing.Point(89, 131)
        Me.lbl_DescrTot.Name = "lbl_DescrTot"
        Me.lbl_DescrTot.Size = New System.Drawing.Size(98, 29)
        Me.lbl_DescrTot.TabIndex = 9
        Me.lbl_DescrTot.Text = "TOTAL:"
        '
        'Gb_Producto
        '
        Me.Gb_Producto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gb_Producto.Controls.Add(Me.Label13)
        Me.Gb_Producto.Controls.Add(Me.Btn_Cambiar)
        Me.Gb_Producto.Controls.Add(Me.Btn_Agregar)
        Me.Gb_Producto.Controls.Add(Me.txt_CodigoBarra)
        Me.Gb_Producto.Controls.Add(Me.lbl_CodigoBarra)
        Me.Gb_Producto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gb_Producto.Location = New System.Drawing.Point(17, 195)
        Me.Gb_Producto.Name = "Gb_Producto"
        Me.Gb_Producto.Size = New System.Drawing.Size(569, 125)
        Me.Gb_Producto.TabIndex = 10
        Me.Gb_Producto.TabStop = False
        Me.Gb_Producto.Text = "PRODUCTO"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(8, 27)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(408, 15)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Ingrese el código de barra o el código de producto y luego presione enter."
        '
        'Btn_Cambiar
        '
        Me.Btn_Cambiar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Btn_Cambiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Cambiar.Image = Global.SistemaCinderella.My.Resources.Recursos.Cambios_32
        Me.Btn_Cambiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Cambiar.Location = New System.Drawing.Point(459, 68)
        Me.Btn_Cambiar.Name = "Btn_Cambiar"
        Me.Btn_Cambiar.Size = New System.Drawing.Size(103, 44)
        Me.Btn_Cambiar.TabIndex = 9
        Me.Btn_Cambiar.Text = "Cambiar"
        Me.Btn_Cambiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolProd.SetToolTip(Me.Btn_Cambiar, "Permite agregar productos que ingresan a la sucursal.")
        Me.Btn_Cambiar.UseVisualStyleBackColor = True
        '
        'Gb_Cliente
        '
        Me.Gb_Cliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gb_Cliente.Controls.Add(Me.Btn_BuscarCliente)
        Me.Gb_Cliente.Controls.Add(Me.txt_RazonSocial)
        Me.Gb_Cliente.Controls.Add(Me.txt_id_Cliente)
        Me.Gb_Cliente.Controls.Add(Me.Label3)
        Me.Gb_Cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gb_Cliente.Location = New System.Drawing.Point(17, 130)
        Me.Gb_Cliente.Name = "Gb_Cliente"
        Me.Gb_Cliente.Size = New System.Drawing.Size(921, 59)
        Me.Gb_Cliente.TabIndex = 11
        Me.Gb_Cliente.TabStop = False
        Me.Gb_Cliente.Text = "CLIENTE"
        '
        'Btn_BuscarCliente
        '
        Me.Btn_BuscarCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_BuscarCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_BuscarCliente.FlatAppearance.BorderSize = 0
        Me.Btn_BuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_BuscarCliente.Image = Global.SistemaCinderella.My.Resources.Recursos.Clientes_32
        Me.Btn_BuscarCliente.Location = New System.Drawing.Point(877, 16)
        Me.Btn_BuscarCliente.Name = "Btn_BuscarCliente"
        Me.Btn_BuscarCliente.Size = New System.Drawing.Size(37, 37)
        Me.Btn_BuscarCliente.TabIndex = 6
        Me.ToolProd.SetToolTip(Me.Btn_BuscarCliente, "Permite buscar clientes en el sistema por razon social.")
        Me.Btn_BuscarCliente.UseVisualStyleBackColor = True
        '
        'txt_RazonSocial
        '
        Me.txt_RazonSocial.BackColor = System.Drawing.SystemColors.Window
        Me.txt_RazonSocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_RazonSocial.Location = New System.Drawing.Point(315, 24)
        Me.txt_RazonSocial.Name = "txt_RazonSocial"
        Me.txt_RazonSocial.ReadOnly = True
        Me.txt_RazonSocial.Size = New System.Drawing.Size(556, 21)
        Me.txt_RazonSocial.TabIndex = 5
        '
        'txt_id_Cliente
        '
        Me.txt_id_Cliente.BackColor = System.Drawing.SystemColors.Window
        Me.txt_id_Cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id_Cliente.Location = New System.Drawing.Point(70, 24)
        Me.txt_id_Cliente.Name = "txt_id_Cliente"
        Me.txt_id_Cliente.ReadOnly = True
        Me.txt_id_Cliente.Size = New System.Drawing.Size(239, 21)
        Me.txt_id_Cliente.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Cliente"
        '
        'Gb_Vendedor
        '
        Me.Gb_Vendedor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gb_Vendedor.Controls.Add(Me.Cb_Encargados)
        Me.Gb_Vendedor.Controls.Add(Me.Label12)
        Me.Gb_Vendedor.Controls.Add(Me.cb_Tipo)
        Me.Gb_Vendedor.Controls.Add(Me.Label2)
        Me.Gb_Vendedor.Controls.Add(Me.Cb_Vendedores)
        Me.Gb_Vendedor.Controls.Add(Me.Label1)
        Me.Gb_Vendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gb_Vendedor.Location = New System.Drawing.Point(17, 65)
        Me.Gb_Vendedor.Name = "Gb_Vendedor"
        Me.Gb_Vendedor.Size = New System.Drawing.Size(921, 59)
        Me.Gb_Vendedor.TabIndex = 12
        Me.Gb_Vendedor.TabStop = False
        Me.Gb_Vendedor.Text = "TIPO, ENCARGADO Y VENDEDOR DE LA VENTA"
        '
        'Cb_Encargados
        '
        Me.Cb_Encargados.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Cb_Encargados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cb_Encargados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Encargados.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Cb_Encargados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_Encargados.FormattingEnabled = True
        Me.Cb_Encargados.Location = New System.Drawing.Point(385, 22)
        Me.Cb_Encargados.Name = "Cb_Encargados"
        Me.Cb_Encargados.Size = New System.Drawing.Size(220, 23)
        Me.Cb_Encargados.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(312, 25)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 15)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Encargado"
        '
        'cb_Tipo
        '
        Me.cb_Tipo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_Tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Tipo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cb_Tipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_Tipo.FormattingEnabled = True
        Me.cb_Tipo.Items.AddRange(New Object() {"Minorista", "Mayorista"})
        Me.cb_Tipo.Location = New System.Drawing.Point(111, 23)
        Me.cb_Tipo.Name = "cb_Tipo"
        Me.cb_Tipo.Size = New System.Drawing.Size(150, 23)
        Me.cb_Tipo.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tipo de Venta"
        '
        'Cb_Vendedores
        '
        Me.Cb_Vendedores.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Cb_Vendedores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cb_Vendedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Vendedores.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Cb_Vendedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_Vendedores.FormattingEnabled = True
        Me.Cb_Vendedores.Location = New System.Drawing.Point(694, 22)
        Me.Cb_Vendedores.Name = "Cb_Vendedores"
        Me.Cb_Vendedores.Size = New System.Drawing.Size(220, 23)
        Me.Cb_Vendedores.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(628, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Vendedor"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(527, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 15)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "FECHA:"
        '
        'GB_Fecha
        '
        Me.GB_Fecha.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_Fecha.Controls.Add(Me.lbl_Sucursal)
        Me.GB_Fecha.Controls.Add(Me.Label5)
        Me.GB_Fecha.Controls.Add(Me.Label7)
        Me.GB_Fecha.Controls.Add(Me.lbl_Fecha)
        Me.GB_Fecha.Controls.Add(Me.lbl_Hora)
        Me.GB_Fecha.Controls.Add(Me.Label4)
        Me.GB_Fecha.Location = New System.Drawing.Point(17, 8)
        Me.GB_Fecha.Name = "GB_Fecha"
        Me.GB_Fecha.Size = New System.Drawing.Size(922, 51)
        Me.GB_Fecha.TabIndex = 14
        Me.GB_Fecha.TabStop = False
        '
        'lbl_Sucursal
        '
        Me.lbl_Sucursal.AutoSize = True
        Me.lbl_Sucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Sucursal.Location = New System.Drawing.Point(93, 20)
        Me.lbl_Sucursal.Name = "lbl_Sucursal"
        Me.lbl_Sucursal.Size = New System.Drawing.Size(45, 15)
        Me.lbl_Sucursal.TabIndex = 18
        Me.lbl_Sucursal.Text = "Label5"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 15)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "SUCURSAL:"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(744, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 15)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "HORA:"
        '
        'lbl_Fecha
        '
        Me.lbl_Fecha.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_Fecha.AutoSize = True
        Me.lbl_Fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Fecha.Location = New System.Drawing.Point(588, 20)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(45, 15)
        Me.lbl_Fecha.TabIndex = 15
        Me.lbl_Fecha.Text = "Label6"
        '
        'lbl_Hora
        '
        Me.lbl_Hora.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_Hora.AutoSize = True
        Me.lbl_Hora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Hora.Location = New System.Drawing.Point(803, 20)
        Me.lbl_Hora.Name = "lbl_Hora"
        Me.lbl_Hora.Size = New System.Drawing.Size(45, 15)
        Me.lbl_Hora.TabIndex = 14
        Me.lbl_Hora.Text = "Label5"
        '
        'Reloj
        '
        Me.Reloj.Enabled = True
        '
        'GB_TipoPago
        '
        Me.GB_TipoPago.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_TipoPago.Controls.Add(Me.Cb_TipoPago)
        Me.GB_TipoPago.Controls.Add(Me.Label6)
        Me.GB_TipoPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_TipoPago.Location = New System.Drawing.Point(592, 196)
        Me.GB_TipoPago.Name = "GB_TipoPago"
        Me.GB_TipoPago.Size = New System.Drawing.Size(346, 59)
        Me.GB_TipoPago.TabIndex = 12
        Me.GB_TipoPago.TabStop = False
        Me.GB_TipoPago.Text = "TIPO DE PAGO"
        '
        'Cb_TipoPago
        '
        Me.Cb_TipoPago.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Cb_TipoPago.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cb_TipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_TipoPago.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Cb_TipoPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_TipoPago.FormattingEnabled = True
        Me.Cb_TipoPago.Location = New System.Drawing.Point(119, 20)
        Me.Cb_TipoPago.Name = "Cb_TipoPago"
        Me.Cb_TipoPago.Size = New System.Drawing.Size(220, 23)
        Me.Cb_TipoPago.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(7, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 15)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Tipo de Pago"
        '
        'ToolProd
        '
        Me.ToolProd.IsBalloon = True
        Me.ToolProd.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolProd.ToolTipTitle = "Ayuda"
        '
        'txt_DescuentoMinorista
        '
        Me.txt_DescuentoMinorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_DescuentoMinorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_DescuentoMinorista.Location = New System.Drawing.Point(257, 43)
        Me.txt_DescuentoMinorista.Name = "txt_DescuentoMinorista"
        Me.txt_DescuentoMinorista.Size = New System.Drawing.Size(139, 35)
        Me.txt_DescuentoMinorista.TabIndex = 13
        Me.txt_DescuentoMinorista.Text = "0,00"
        Me.txt_DescuentoMinorista.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolProd.SetToolTip(Me.txt_DescuentoMinorista, "Si desea agregar un descuento al pedido, sólo debe ingresar el monto en éste camp" &
        "o.")
        '
        'lbl_DesTot
        '
        Me.lbl_DesTot.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_DesTot.AutoSize = True
        Me.lbl_DesTot.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DesTot.Location = New System.Drawing.Point(3, 46)
        Me.lbl_DesTot.Name = "lbl_DesTot"
        Me.lbl_DesTot.Size = New System.Drawing.Size(169, 29)
        Me.lbl_DesTot.TabIndex = 16
        Me.lbl_DesTot.Text = "DESCUENTO:"
        '
        'txt_TotalMinorista
        '
        Me.txt_TotalMinorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_TotalMinorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TotalMinorista.Location = New System.Drawing.Point(257, 124)
        Me.txt_TotalMinorista.Name = "txt_TotalMinorista"
        Me.txt_TotalMinorista.ReadOnly = True
        Me.txt_TotalMinorista.Size = New System.Drawing.Size(139, 35)
        Me.txt_TotalMinorista.TabIndex = 15
        Me.txt_TotalMinorista.Text = "0,00"
        Me.txt_TotalMinorista.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_SubtotalMinorista
        '
        Me.txt_SubtotalMinorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_SubtotalMinorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SubtotalMinorista.Location = New System.Drawing.Point(257, 2)
        Me.txt_SubtotalMinorista.Name = "txt_SubtotalMinorista"
        Me.txt_SubtotalMinorista.ReadOnly = True
        Me.txt_SubtotalMinorista.Size = New System.Drawing.Size(139, 35)
        Me.txt_SubtotalMinorista.TabIndex = 14
        Me.txt_SubtotalMinorista.Text = "0,00"
        Me.txt_SubtotalMinorista.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_subTotal
        '
        Me.lbl_subTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_subTotal.AutoSize = True
        Me.lbl_subTotal.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_subTotal.Location = New System.Drawing.Point(3, 5)
        Me.lbl_subTotal.Name = "lbl_subTotal"
        Me.lbl_subTotal.Size = New System.Drawing.Size(148, 29)
        Me.lbl_subTotal.TabIndex = 17
        Me.lbl_subTotal.Text = "SUBTOTAL:"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(221, 46)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(26, 29)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "$"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(221, 6)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(26, 29)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "$"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(221, 130)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(26, 29)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "$"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GB_ListaPrecio
        '
        Me.GB_ListaPrecio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_ListaPrecio.Controls.Add(Me.Cb_ListaPrecio)
        Me.GB_ListaPrecio.Controls.Add(Me.Label14)
        Me.GB_ListaPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_ListaPrecio.Location = New System.Drawing.Point(592, 261)
        Me.GB_ListaPrecio.Name = "GB_ListaPrecio"
        Me.GB_ListaPrecio.Size = New System.Drawing.Size(346, 59)
        Me.GB_ListaPrecio.TabIndex = 22
        Me.GB_ListaPrecio.TabStop = False
        Me.GB_ListaPrecio.Text = "LISTA PRECIOS"
        '
        'Cb_ListaPrecio
        '
        Me.Cb_ListaPrecio.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Cb_ListaPrecio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cb_ListaPrecio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_ListaPrecio.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Cb_ListaPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_ListaPrecio.FormattingEnabled = True
        Me.Cb_ListaPrecio.Location = New System.Drawing.Point(119, 22)
        Me.Cb_ListaPrecio.Name = "Cb_ListaPrecio"
        Me.Cb_ListaPrecio.Size = New System.Drawing.Size(221, 23)
        Me.Cb_ListaPrecio.Sorted = True
        Me.Cb_ListaPrecio.TabIndex = 11
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(7, 30)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(94, 15)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Lista de Precios"
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(220, 87)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(26, 29)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "$"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_ivaTotalMayorista
        '
        Me.txt_ivaTotalMayorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_ivaTotalMayorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ivaTotalMayorista.Location = New System.Drawing.Point(256, 83)
        Me.txt_ivaTotalMayorista.Name = "txt_ivaTotalMayorista"
        Me.txt_ivaTotalMayorista.ReadOnly = True
        Me.txt_ivaTotalMayorista.Size = New System.Drawing.Size(139, 35)
        Me.txt_ivaTotalMayorista.TabIndex = 23
        Me.txt_ivaTotalMayorista.Text = "0,00"
        Me.txt_ivaTotalMayorista.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(12, 89)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(108, 29)
        Me.Label16.TabIndex = 24
        Me.Label16.Text = "IVA 21%:"
        '
        'PanelTotalMayorista
        '
        Me.PanelTotalMayorista.Controls.Add(Me.Label8)
        Me.PanelTotalMayorista.Controls.Add(Me.Label17)
        Me.PanelTotalMayorista.Controls.Add(Me.Label18)
        Me.PanelTotalMayorista.Controls.Add(Me.txt_SubtotalMayorista)
        Me.PanelTotalMayorista.Controls.Add(Me.Label19)
        Me.PanelTotalMayorista.Controls.Add(Me.txt_TotalMayorista)
        Me.PanelTotalMayorista.Controls.Add(Me.txt_DescuentoMayorista)
        Me.PanelTotalMayorista.Controls.Add(Me.Label20)
        Me.PanelTotalMayorista.Controls.Add(Me.Label21)
        Me.PanelTotalMayorista.Controls.Add(Me.txt_ivaTotalMayorista)
        Me.PanelTotalMayorista.Controls.Add(Me.Label15)
        Me.PanelTotalMayorista.Controls.Add(Me.Label16)
        Me.PanelTotalMayorista.Location = New System.Drawing.Point(17, 596)
        Me.PanelTotalMayorista.Name = "PanelTotalMayorista"
        Me.PanelTotalMayorista.Size = New System.Drawing.Size(399, 164)
        Me.PanelTotalMayorista.TabIndex = 26
        '
        'NUMERO
        '
        Me.NUMERO.HeaderText = "NUMERO"
        Me.NUMERO.Name = "NUMERO"
        Me.NUMERO.ReadOnly = True
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        '
        'CODIGO
        '
        Me.CODIGO.HeaderText = "CODIGO"
        Me.CODIGO.Name = "CODIGO"
        Me.CODIGO.ReadOnly = True
        '
        'NOMBRE
        '
        Me.NOMBRE.HeaderText = "NOMBRE"
        Me.NOMBRE.Name = "NOMBRE"
        Me.NOMBRE.ReadOnly = True
        '
        'CANTIDAD
        '
        Me.CANTIDAD.HeaderText = "CANTIDAD"
        Me.CANTIDAD.Name = "CANTIDAD"
        '
        'PRECIO
        '
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = "0"
        Me.PRECIO.DefaultCellStyle = DataGridViewCellStyle1
        Me.PRECIO.HeaderText = "PRECIO"
        Me.PRECIO.Name = "PRECIO"
        Me.PRECIO.ReadOnly = True
        '
        'IVA
        '
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = "0"
        Me.IVA.DefaultCellStyle = DataGridViewCellStyle2
        Me.IVA.HeaderText = "IVA"
        Me.IVA.Name = "IVA"
        Me.IVA.ReadOnly = True
        '
        'MONTO
        '
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.MONTO.DefaultCellStyle = DataGridViewCellStyle3
        Me.MONTO.HeaderText = "MONTO"
        Me.MONTO.Name = "MONTO"
        Me.MONTO.ReadOnly = True
        '
        'SUBTOTAL
        '
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = "0"
        Me.SUBTOTAL.DefaultCellStyle = DataGridViewCellStyle4
        Me.SUBTOTAL.HeaderText = "SUBTOTAL"
        Me.SUBTOTAL.Name = "SUBTOTAL"
        Me.SUBTOTAL.ReadOnly = True
        '
        'ELIMINAR
        '
        Me.ELIMINAR.HeaderText = "ELIMINAR"
        Me.ELIMINAR.Name = "ELIMINAR"
        Me.ELIMINAR.ReadOnly = True
        '
        'Precio1
        '
        Me.Precio1.HeaderText = "Precio1"
        Me.Precio1.Name = "Precio1"
        Me.Precio1.Visible = False
        '
        'Precio2
        '
        Me.Precio2.HeaderText = "Precio2"
        Me.Precio2.Name = "Precio2"
        Me.Precio2.Visible = False
        '
        'Precio3
        '
        Me.Precio3.HeaderText = "Precio3"
        Me.Precio3.Name = "Precio3"
        Me.Precio3.Visible = False
        '
        'Precio4
        '
        Me.Precio4.HeaderText = "Precio4"
        Me.Precio4.Name = "Precio4"
        Me.Precio4.Visible = False
        '
        'Precio5
        '
        Me.Precio5.HeaderText = "Precio5"
        Me.Precio5.Name = "Precio5"
        Me.Precio5.Visible = False
        '
        'Precio6
        '
        Me.Precio6.HeaderText = "Precio6"
        Me.Precio6.Name = "Precio6"
        Me.Precio6.Visible = False
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(221, 130)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 29)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "$"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(221, 46)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(26, 29)
        Me.Label17.TabIndex = 33
        Me.Label17.Text = "$"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(222, 10)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(26, 29)
        Me.Label18.TabIndex = 32
        Me.Label18.Text = "$"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_SubtotalMayorista
        '
        Me.txt_SubtotalMayorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_SubtotalMayorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SubtotalMayorista.Location = New System.Drawing.Point(257, 42)
        Me.txt_SubtotalMayorista.Name = "txt_SubtotalMayorista"
        Me.txt_SubtotalMayorista.ReadOnly = True
        Me.txt_SubtotalMayorista.Size = New System.Drawing.Size(139, 35)
        Me.txt_SubtotalMayorista.TabIndex = 28
        Me.txt_SubtotalMayorista.Text = "0,00"
        Me.txt_SubtotalMayorista.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(9, 49)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(148, 29)
        Me.Label19.TabIndex = 31
        Me.Label19.Text = "SUBTOTAL:"
        '
        'txt_TotalMayorista
        '
        Me.txt_TotalMayorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_TotalMayorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TotalMayorista.Location = New System.Drawing.Point(257, 124)
        Me.txt_TotalMayorista.Name = "txt_TotalMayorista"
        Me.txt_TotalMayorista.ReadOnly = True
        Me.txt_TotalMayorista.Size = New System.Drawing.Size(139, 35)
        Me.txt_TotalMayorista.TabIndex = 29
        Me.txt_TotalMayorista.Text = "0,00"
        Me.txt_TotalMayorista.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_DescuentoMayorista
        '
        Me.txt_DescuentoMayorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_DescuentoMayorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_DescuentoMayorista.Location = New System.Drawing.Point(258, 1)
        Me.txt_DescuentoMayorista.Name = "txt_DescuentoMayorista"
        Me.txt_DescuentoMayorista.Size = New System.Drawing.Size(139, 35)
        Me.txt_DescuentoMayorista.TabIndex = 27
        Me.txt_DescuentoMayorista.Text = "0,00"
        Me.txt_DescuentoMayorista.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolProd.SetToolTip(Me.txt_DescuentoMayorista, "Si desea agregar un descuento al pedido, sólo debe ingresar el monto en éste camp" &
        "o.")
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(10, 8)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(169, 29)
        Me.Label20.TabIndex = 30
        Me.Label20.Text = "DESCUENTO:"
        '
        'Label21
        '
        Me.Label21.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(9, 133)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(98, 29)
        Me.Label21.TabIndex = 26
        Me.Label21.Text = "TOTAL:"
        '
        'PanelTotalMinorista
        '
        Me.PanelTotalMinorista.Controls.Add(Me.lbl_DesTot)
        Me.PanelTotalMinorista.Controls.Add(Me.lbl_DescrTot)
        Me.PanelTotalMinorista.Controls.Add(Me.Label11)
        Me.PanelTotalMinorista.Controls.Add(Me.txt_DescuentoMinorista)
        Me.PanelTotalMinorista.Controls.Add(Me.Label10)
        Me.PanelTotalMinorista.Controls.Add(Me.txt_TotalMinorista)
        Me.PanelTotalMinorista.Controls.Add(Me.Label9)
        Me.PanelTotalMinorista.Controls.Add(Me.lbl_subTotal)
        Me.PanelTotalMinorista.Controls.Add(Me.txt_SubtotalMinorista)
        Me.PanelTotalMinorista.Location = New System.Drawing.Point(540, 596)
        Me.PanelTotalMinorista.Name = "PanelTotalMinorista"
        Me.PanelTotalMinorista.Size = New System.Drawing.Size(399, 164)
        Me.PanelTotalMinorista.TabIndex = 27
        '
        'frmVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(954, 812)
        Me.Controls.Add(Me.PanelTotalMayorista)
        Me.Controls.Add(Me.GB_ListaPrecio)
        Me.Controls.Add(Me.GB_TipoPago)
        Me.Controls.Add(Me.GB_Fecha)
        Me.Controls.Add(Me.Gb_Producto)
        Me.Controls.Add(Me.Gb_Vendedor)
        Me.Controls.Add(Me.Gb_Cliente)
        Me.Controls.Add(Me.Btn_Cancelar)
        Me.Controls.Add(Me.Btn_Finalizar)
        Me.Controls.Add(Me.DG_Productos)
        Me.Controls.Add(Me.PanelTotalMinorista)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Ventas"
        CType(Me.DG_Productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gb_Producto.ResumeLayout(False)
        Me.Gb_Producto.PerformLayout()
        Me.Gb_Cliente.ResumeLayout(False)
        Me.Gb_Cliente.PerformLayout()
        Me.Gb_Vendedor.ResumeLayout(False)
        Me.Gb_Vendedor.PerformLayout()
        Me.GB_Fecha.ResumeLayout(False)
        Me.GB_Fecha.PerformLayout()
        Me.GB_TipoPago.ResumeLayout(False)
        Me.GB_TipoPago.PerformLayout()
        Me.GB_ListaPrecio.ResumeLayout(False)
        Me.GB_ListaPrecio.PerformLayout()
        Me.PanelTotalMayorista.ResumeLayout(False)
        Me.PanelTotalMayorista.PerformLayout()
        Me.PanelTotalMinorista.ResumeLayout(False)
        Me.PanelTotalMinorista.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DG_Productos As System.Windows.Forms.DataGridView
    Friend WithEvents txt_CodigoBarra As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Finalizar As System.Windows.Forms.Button
    Friend WithEvents Btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents Btn_Agregar As System.Windows.Forms.Button
    Friend WithEvents lbl_CodigoBarra As System.Windows.Forms.Label
    Friend WithEvents lbl_DescrTot As System.Windows.Forms.Label
    Friend WithEvents Gb_Producto As System.Windows.Forms.GroupBox
    Friend WithEvents Gb_Cliente As System.Windows.Forms.GroupBox
    Friend WithEvents Gb_Vendedor As System.Windows.Forms.GroupBox
    Friend WithEvents Cb_Vendedores As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Btn_BuscarCliente As System.Windows.Forms.Button
    Friend WithEvents txt_RazonSocial As System.Windows.Forms.TextBox
    Friend WithEvents txt_id_Cliente As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cb_Tipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GB_Fecha As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbl_Fecha As System.Windows.Forms.Label
    Friend WithEvents lbl_Hora As System.Windows.Forms.Label
    Friend WithEvents Reloj As System.Windows.Forms.Timer
    Friend WithEvents lbl_Sucursal As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GB_TipoPago As System.Windows.Forms.GroupBox
    Friend WithEvents Cb_TipoPago As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ToolProd As System.Windows.Forms.ToolTip
    Friend WithEvents lbl_DesTot As System.Windows.Forms.Label
    Friend WithEvents txt_DescuentoMinorista As System.Windows.Forms.TextBox
    Friend WithEvents txt_TotalMinorista As System.Windows.Forms.TextBox
    Friend WithEvents txt_SubtotalMinorista As System.Windows.Forms.TextBox
    Friend WithEvents lbl_subTotal As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Btn_Cambiar As System.Windows.Forms.Button
    Friend WithEvents Cb_Encargados As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GB_ListaPrecio As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Cb_ListaPrecio As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txt_ivaTotalMayorista As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents PanelTotalMayorista As Panel
    Friend WithEvents NUMERO As DataGridViewTextBoxColumn
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents CODIGO As DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE As DataGridViewTextBoxColumn
    Friend WithEvents CANTIDAD As DataGridViewTextBoxColumn
    Friend WithEvents PRECIO As DataGridViewTextBoxColumn
    Friend WithEvents IVA As DataGridViewTextBoxColumn
    Friend WithEvents MONTO As DataGridViewTextBoxColumn
    Friend WithEvents SUBTOTAL As DataGridViewTextBoxColumn
    Friend WithEvents ELIMINAR As DataGridViewImageColumn
    Friend WithEvents Precio1 As DataGridViewTextBoxColumn
    Friend WithEvents Precio2 As DataGridViewTextBoxColumn
    Friend WithEvents Precio3 As DataGridViewTextBoxColumn
    Friend WithEvents Precio4 As DataGridViewTextBoxColumn
    Friend WithEvents Precio5 As DataGridViewTextBoxColumn
    Friend WithEvents Precio6 As DataGridViewTextBoxColumn
    Friend WithEvents Label8 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txt_SubtotalMayorista As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txt_TotalMayorista As TextBox
    Friend WithEvents txt_DescuentoMayorista As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents PanelTotalMinorista As Panel
End Class
