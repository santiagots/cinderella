<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVentas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim PagosBindingSource As System.Windows.Forms.BindingSource
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVentas))
        Me.VentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txt_CodigoBarra = New System.Windows.Forms.TextBox()
        Me.Btn_Finalizar = New System.Windows.Forms.Button()
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.Btn_Agregar = New System.Windows.Forms.Button()
        Me.lbl_CodigoBarra = New System.Windows.Forms.Label()
        Me.Gb_Producto = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Btn_Cambiar = New System.Windows.Forms.Button()
        Me.Gb_Cliente = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txt_PorcentajeFacturacion = New System.Windows.Forms.NumericUpDown()
        Me.Btn_BuscarCliente = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_id_Cliente = New System.Windows.Forms.TextBox()
        Me.txt_RazonSocial = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel12 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_PorcentajeBonificacion = New System.Windows.Forms.NumericUpDown()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Gb_Vendedor = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Cb_Vendedores = New System.Windows.Forms.ComboBox()
        Me.VendedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cb_Encargados = New System.Windows.Forms.ComboBox()
        Me.EncargadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Cb_TipoCliente = New System.Windows.Forms.ComboBox()
        Me.TipoClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Reloj = New System.Windows.Forms.Timer(Me.components)
        Me.ToolProd = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnSenia = New System.Windows.Forms.Button()
        Me.Btn_NotaPedido = New System.Windows.Forms.Button()
        Me.btnAgregaPago = New System.Windows.Forms.Button()
        Me.btnRecargarPago = New System.Windows.Forms.Button()
        Me.GB_ListaPrecio = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel9 = New System.Windows.Forms.TableLayoutPanel()
        Me.Cb_ListaPrecio = New System.Windows.Forms.ComboBox()
        Me.ListaPreciosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GB_Pagos = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgPagosTotales = New SistemaCinderella.CustomDataGrid()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPagosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgPagos = New SistemaCinderella.CustomDataGrid()
        Me.FormaPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescuentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoFinancieroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IVADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PagoQuitar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_Subtotal = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_Descuento = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_CFT = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_IVA = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_Total = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.Cb_FormaPago = New System.Windows.Forms.ComboBox()
        Me.FormasPagosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Cb_Banco = New System.Windows.Forms.ComboBox()
        Me.ListaBancosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cb_NroCuota = New System.Windows.Forms.ComboBox()
        Me.ListaCuotasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.CachedCrystalReport21 = New SistemaCinderella.CachedCrystalReport2()
        Me.DG_Productos = New SistemaCinderella.CustomDataGrid()
        Me.ProductoCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductoNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PorcentajeBonificacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductoCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductoPrecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductoIVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductoMonto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PorcentajePago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductoSubtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductoQuitar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DG_ProductosTotales = New SistemaCinderella.CustomDataGrid()
        Me.TotalProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductoPrecioTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductoIVATotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        PagosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(PagosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gb_Producto.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.Gb_Cliente.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        CType(Me.txt_PorcentajeFacturacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel12.SuspendLayout()
        CType(Me.txt_PorcentajeBonificacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gb_Vendedor.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.VendedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EncargadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_ListaPrecio.SuspendLayout()
        Me.TableLayoutPanel9.SuspendLayout()
        CType(Me.ListaPreciosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_Pagos.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.dgPagosTotales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalPagosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        CType(Me.FormasPagosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaBancosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaCuotasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_Productos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_ProductosTotales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PagosBindingSource
        '
        PagosBindingSource.DataMember = "Pagos"
        PagosBindingSource.DataSource = Me.VentasBindingSource
        '
        'VentasBindingSource
        '
        Me.VentasBindingSource.DataSource = GetType(SistemaCinderella.VistaModelo.frmVentas.Venta)
        '
        'txt_CodigoBarra
        '
        Me.txt_CodigoBarra.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_CodigoBarra.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_CodigoBarra.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_CodigoBarra.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasBindingSource, "ProductoIngresado", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_CodigoBarra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CodigoBarra.Location = New System.Drawing.Point(203, 11)
        Me.txt_CodigoBarra.Name = "txt_CodigoBarra"
        Me.txt_CodigoBarra.Size = New System.Drawing.Size(491, 21)
        Me.txt_CodigoBarra.TabIndex = 7
        '
        'Btn_Finalizar
        '
        Me.Btn_Finalizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Finalizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Finalizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Finalizar.Image = Global.SistemaCinderella.My.Resources.Recursos.Conectado_32
        Me.Btn_Finalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Finalizar.Location = New System.Drawing.Point(847, 693)
        Me.Btn_Finalizar.Name = "Btn_Finalizar"
        Me.Btn_Finalizar.Size = New System.Drawing.Size(95, 35)
        Me.Btn_Finalizar.TabIndex = 17
        Me.Btn_Finalizar.Text = "Finalizar"
        Me.Btn_Finalizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolProd.SetToolTip(Me.Btn_Finalizar, "Finaliza la venta actual. ")
        Me.Btn_Finalizar.UseVisualStyleBackColor = True
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Cancelar.Image = Global.SistemaCinderella.My.Resources.Recursos.desconectado_32
        Me.Btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Cancelar.Location = New System.Drawing.Point(540, 693)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(100, 35)
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
        Me.Btn_Agregar.Location = New System.Drawing.Point(704, 5)
        Me.Btn_Agregar.Name = "Btn_Agregar"
        Me.Btn_Agregar.Size = New System.Drawing.Size(100, 34)
        Me.Btn_Agregar.TabIndex = 8
        Me.Btn_Agregar.Text = "Agregar"
        Me.Btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolProd.SetToolTip(Me.Btn_Agregar, "Permite buscar productos en el sistema por nombre / código.")
        Me.Btn_Agregar.UseVisualStyleBackColor = True
        '
        'lbl_CodigoBarra
        '
        Me.lbl_CodigoBarra.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_CodigoBarra.AutoSize = True
        Me.lbl_CodigoBarra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CodigoBarra.Location = New System.Drawing.Point(3, 14)
        Me.lbl_CodigoBarra.Name = "lbl_CodigoBarra"
        Me.lbl_CodigoBarra.Size = New System.Drawing.Size(194, 15)
        Me.lbl_CodigoBarra.TabIndex = 7
        Me.lbl_CodigoBarra.Text = "Nombre / Código de Producto"
        '
        'Gb_Producto
        '
        Me.Gb_Producto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gb_Producto.Controls.Add(Me.TableLayoutPanel4)
        Me.Gb_Producto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gb_Producto.Location = New System.Drawing.Point(12, 180)
        Me.Gb_Producto.Name = "Gb_Producto"
        Me.Gb_Producto.Size = New System.Drawing.Size(930, 69)
        Me.Gb_Producto.TabIndex = 10
        Me.Gb_Producto.TabStop = False
        Me.Gb_Producto.Text = "PRODUCTO"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel4.ColumnCount = 4
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.Btn_Agregar, 2, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Btn_Cambiar, 3, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.lbl_CodigoBarra, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.txt_CodigoBarra, 1, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(6, 19)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(917, 44)
        Me.TableLayoutPanel4.TabIndex = 30
        '
        'Btn_Cambiar
        '
        Me.Btn_Cambiar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Btn_Cambiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Cambiar.Image = Global.SistemaCinderella.My.Resources.Recursos.Cambios_32
        Me.Btn_Cambiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Cambiar.Location = New System.Drawing.Point(814, 5)
        Me.Btn_Cambiar.Name = "Btn_Cambiar"
        Me.Btn_Cambiar.Size = New System.Drawing.Size(100, 34)
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
        Me.Gb_Cliente.Controls.Add(Me.TableLayoutPanel6)
        Me.Gb_Cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gb_Cliente.Location = New System.Drawing.Point(12, 77)
        Me.Gb_Cliente.Name = "Gb_Cliente"
        Me.Gb_Cliente.Size = New System.Drawing.Size(600, 97)
        Me.Gb_Cliente.TabIndex = 11
        Me.Gb_Cliente.TabStop = False
        Me.Gb_Cliente.Text = "CLIENTE"
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel6.ColumnCount = 4
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.Label24, 0, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.txt_PorcentajeFacturacion, 1, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.Btn_BuscarCliente, 3, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.txt_id_Cliente, 1, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.txt_RazonSocial, 2, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.TableLayoutPanel12, 2, 1)
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(7, 20)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 2
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(587, 71)
        Me.TableLayoutPanel6.TabIndex = 0
        '
        'Label24
        '
        Me.Label24.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(3, 45)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(94, 15)
        Me.Label24.TabIndex = 7
        Me.Label24.Text = "Facturación %"
        '
        'txt_PorcentajeFacturacion
        '
        Me.txt_PorcentajeFacturacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_PorcentajeFacturacion.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VentasBindingSource, "ProcentajeFacturacionClienteMayorista", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_PorcentajeFacturacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PorcentajeFacturacion.Location = New System.Drawing.Point(103, 42)
        Me.txt_PorcentajeFacturacion.Name = "txt_PorcentajeFacturacion"
        Me.txt_PorcentajeFacturacion.Size = New System.Drawing.Size(104, 21)
        Me.txt_PorcentajeFacturacion.TabIndex = 8
        '
        'Btn_BuscarCliente
        '
        Me.Btn_BuscarCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_BuscarCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_BuscarCliente.FlatAppearance.BorderSize = 0
        Me.Btn_BuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_BuscarCliente.Image = Global.SistemaCinderella.My.Resources.Recursos.Clientes_32
        Me.Btn_BuscarCliente.Location = New System.Drawing.Point(545, 3)
        Me.Btn_BuscarCliente.Name = "Btn_BuscarCliente"
        Me.Btn_BuscarCliente.Size = New System.Drawing.Size(39, 29)
        Me.Btn_BuscarCliente.TabIndex = 6
        Me.ToolProd.SetToolTip(Me.Btn_BuscarCliente, "Permite buscar clientes en el sistema por razon social.")
        Me.Btn_BuscarCliente.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Cliente"
        '
        'txt_id_Cliente
        '
        Me.txt_id_Cliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_id_Cliente.BackColor = System.Drawing.SystemColors.Window
        Me.txt_id_Cliente.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasBindingSource, "IdClienteMayorista", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_id_Cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id_Cliente.Location = New System.Drawing.Point(103, 7)
        Me.txt_id_Cliente.Name = "txt_id_Cliente"
        Me.txt_id_Cliente.ReadOnly = True
        Me.txt_id_Cliente.Size = New System.Drawing.Size(104, 21)
        Me.txt_id_Cliente.TabIndex = 4
        '
        'txt_RazonSocial
        '
        Me.txt_RazonSocial.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_RazonSocial.BackColor = System.Drawing.SystemColors.Window
        Me.txt_RazonSocial.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasBindingSource, "NombreClienteMayorista", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_RazonSocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_RazonSocial.Location = New System.Drawing.Point(213, 7)
        Me.txt_RazonSocial.Name = "txt_RazonSocial"
        Me.txt_RazonSocial.ReadOnly = True
        Me.txt_RazonSocial.Size = New System.Drawing.Size(324, 21)
        Me.txt_RazonSocial.TabIndex = 5
        '
        'TableLayoutPanel12
        '
        Me.TableLayoutPanel12.ColumnCount = 2
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel12.Controls.Add(Me.txt_PorcentajeBonificacion, 0, 0)
        Me.TableLayoutPanel12.Controls.Add(Me.Label33, 0, 0)
        Me.TableLayoutPanel12.Location = New System.Drawing.Point(213, 38)
        Me.TableLayoutPanel12.Name = "TableLayoutPanel12"
        Me.TableLayoutPanel12.RowCount = 1
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel12.Size = New System.Drawing.Size(200, 30)
        Me.TableLayoutPanel12.TabIndex = 9
        '
        'txt_PorcentajeBonificacion
        '
        Me.txt_PorcentajeBonificacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_PorcentajeBonificacion.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VentasBindingSource, "ProcentajeBonificacionClienteMayorista", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_PorcentajeBonificacion.DecimalPlaces = 2
        Me.txt_PorcentajeBonificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PorcentajeBonificacion.Location = New System.Drawing.Point(103, 4)
        Me.txt_PorcentajeBonificacion.Name = "txt_PorcentajeBonificacion"
        Me.txt_PorcentajeBonificacion.Size = New System.Drawing.Size(94, 21)
        Me.txt_PorcentajeBonificacion.TabIndex = 9
        '
        'Label33
        '
        Me.Label33.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(3, 7)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(94, 15)
        Me.Label33.TabIndex = 8
        Me.Label33.Text = "Bonificación %"
        '
        'Gb_Vendedor
        '
        Me.Gb_Vendedor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gb_Vendedor.Controls.Add(Me.TableLayoutPanel2)
        Me.Gb_Vendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gb_Vendedor.Location = New System.Drawing.Point(12, 12)
        Me.Gb_Vendedor.Name = "Gb_Vendedor"
        Me.Gb_Vendedor.Size = New System.Drawing.Size(930, 59)
        Me.Gb_Vendedor.TabIndex = 12
        Me.Gb_Vendedor.TabStop = False
        Me.Gb_Vendedor.Text = "TIPO, ENCARGADO Y VENDEDOR DE LA VENTA"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 8
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.Controls.Add(Me.Cb_Vendedores, 7, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Cb_Encargados, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 6, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label12, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Cb_TipoCliente, 1, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(7, 20)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(912, 30)
        Me.TableLayoutPanel2.TabIndex = 30
        '
        'Cb_Vendedores
        '
        Me.Cb_Vendedores.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cb_Vendedores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cb_Vendedores.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.VentasBindingSource, "VendedorSeleccionado", True))
        Me.Cb_Vendedores.DataSource = Me.VendedorBindingSource
        Me.Cb_Vendedores.DisplayMember = "Value"
        Me.Cb_Vendedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Vendedores.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Cb_Vendedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_Vendedores.FormattingEnabled = True
        Me.Cb_Vendedores.Location = New System.Drawing.Point(747, 3)
        Me.Cb_Vendedores.Name = "Cb_Vendedores"
        Me.Cb_Vendedores.Size = New System.Drawing.Size(162, 23)
        Me.Cb_Vendedores.TabIndex = 3
        Me.Cb_Vendedores.ValueMember = "Key"
        '
        'VendedorBindingSource
        '
        Me.VendedorBindingSource.DataMember = "Vendedores"
        Me.VendedorBindingSource.DataSource = Me.VentasBindingSource
        '
        'Cb_Encargados
        '
        Me.Cb_Encargados.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cb_Encargados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cb_Encargados.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.VentasBindingSource, "EncargadoSeleccionado", True))
        Me.Cb_Encargados.DataSource = Me.EncargadoBindingSource
        Me.Cb_Encargados.DisplayMember = "Value"
        Me.Cb_Encargados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Encargados.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Cb_Encargados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_Encargados.FormattingEnabled = True
        Me.Cb_Encargados.Location = New System.Drawing.Point(420, 3)
        Me.Cb_Encargados.Name = "Cb_Encargados"
        Me.Cb_Encargados.Size = New System.Drawing.Size(161, 23)
        Me.Cb_Encargados.TabIndex = 2
        Me.Cb_Encargados.ValueMember = "Key"
        '
        'EncargadoBindingSource
        '
        Me.EncargadoBindingSource.DataMember = "Encargados"
        Me.EncargadoBindingSource.DataSource = Me.VentasBindingSource
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(657, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Vendedor"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tipo de Venta"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(330, 7)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(84, 15)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Encargado"
        '
        'Cb_TipoCliente
        '
        Me.Cb_TipoCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cb_TipoCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cb_TipoCliente.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.VentasBindingSource, "TipoClienteSeleccionado", True))
        Me.Cb_TipoCliente.DataSource = Me.TipoClienteBindingSource
        Me.Cb_TipoCliente.DisplayMember = "Value"
        Me.Cb_TipoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_TipoCliente.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Cb_TipoCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_TipoCliente.FormattingEnabled = True
        Me.Cb_TipoCliente.Location = New System.Drawing.Point(93, 3)
        Me.Cb_TipoCliente.Name = "Cb_TipoCliente"
        Me.Cb_TipoCliente.Size = New System.Drawing.Size(161, 23)
        Me.Cb_TipoCliente.TabIndex = 1
        Me.Cb_TipoCliente.ValueMember = "Key"
        '
        'TipoClienteBindingSource
        '
        Me.TipoClienteBindingSource.DataMember = "TipoCliente"
        Me.TipoClienteBindingSource.DataSource = Me.VentasBindingSource
        '
        'Reloj
        '
        Me.Reloj.Enabled = True
        '
        'ToolProd
        '
        Me.ToolProd.IsBalloon = True
        Me.ToolProd.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolProd.ToolTipTitle = "Ayuda"
        '
        'BtnSenia
        '
        Me.BtnSenia.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSenia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSenia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSenia.Image = Global.SistemaCinderella.My.Resources.Recursos.Agregar_24
        Me.BtnSenia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSenia.Location = New System.Drawing.Point(645, 693)
        Me.BtnSenia.Name = "BtnSenia"
        Me.BtnSenia.Size = New System.Drawing.Size(75, 35)
        Me.BtnSenia.TabIndex = 23
        Me.BtnSenia.Text = "Señar"
        Me.BtnSenia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolProd.SetToolTip(Me.BtnSenia, "Señar la venta actual. ")
        Me.BtnSenia.UseVisualStyleBackColor = True
        '
        'Btn_NotaPedido
        '
        Me.Btn_NotaPedido.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_NotaPedido.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_NotaPedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_NotaPedido.Image = Global.SistemaCinderella.My.Resources.Recursos.Agregar_24
        Me.Btn_NotaPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_NotaPedido.Location = New System.Drawing.Point(725, 693)
        Me.Btn_NotaPedido.Name = "Btn_NotaPedido"
        Me.Btn_NotaPedido.Size = New System.Drawing.Size(117, 35)
        Me.Btn_NotaPedido.TabIndex = 29
        Me.Btn_NotaPedido.Text = "Nota Pedido"
        Me.Btn_NotaPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolProd.SetToolTip(Me.Btn_NotaPedido, "Crear nota de pedido. ")
        Me.Btn_NotaPedido.UseVisualStyleBackColor = True
        '
        'btnAgregaPago
        '
        Me.btnAgregaPago.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregaPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregaPago.Image = Global.SistemaCinderella.My.Resources.Recursos.Agregar_24
        Me.btnAgregaPago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregaPago.Location = New System.Drawing.Point(708, 3)
        Me.btnAgregaPago.Name = "btnAgregaPago"
        Me.btnAgregaPago.Size = New System.Drawing.Size(96, 31)
        Me.btnAgregaPago.TabIndex = 24
        Me.btnAgregaPago.Text = "Agregar"
        Me.btnAgregaPago.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolProd.SetToolTip(Me.btnAgregaPago, "Señar la venta actual. ")
        Me.btnAgregaPago.UseVisualStyleBackColor = True
        '
        'btnRecargarPago
        '
        Me.btnRecargarPago.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRecargarPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecargarPago.Image = Global.SistemaCinderella.My.Resources.Recursos.btn_Update_24
        Me.btnRecargarPago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRecargarPago.Location = New System.Drawing.Point(810, 3)
        Me.btnRecargarPago.Name = "btnRecargarPago"
        Me.btnRecargarPago.Size = New System.Drawing.Size(96, 31)
        Me.btnRecargarPago.TabIndex = 25
        Me.btnRecargarPago.Text = "Recargar"
        Me.btnRecargarPago.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolProd.SetToolTip(Me.btnRecargarPago, "Señar la venta actual. ")
        Me.btnRecargarPago.UseVisualStyleBackColor = True
        '
        'GB_ListaPrecio
        '
        Me.GB_ListaPrecio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_ListaPrecio.Controls.Add(Me.TableLayoutPanel9)
        Me.GB_ListaPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_ListaPrecio.Location = New System.Drawing.Point(618, 77)
        Me.GB_ListaPrecio.Name = "GB_ListaPrecio"
        Me.GB_ListaPrecio.Size = New System.Drawing.Size(324, 97)
        Me.GB_ListaPrecio.TabIndex = 22
        Me.GB_ListaPrecio.TabStop = False
        Me.GB_ListaPrecio.Text = "LISTA PRECIOS"
        Me.GB_ListaPrecio.Visible = False
        '
        'TableLayoutPanel9
        '
        Me.TableLayoutPanel9.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel9.ColumnCount = 2
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel9.Controls.Add(Me.Cb_ListaPrecio, 1, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.Label14, 0, 0)
        Me.TableLayoutPanel9.Location = New System.Drawing.Point(6, 39)
        Me.TableLayoutPanel9.Name = "TableLayoutPanel9"
        Me.TableLayoutPanel9.RowCount = 1
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel9.Size = New System.Drawing.Size(309, 30)
        Me.TableLayoutPanel9.TabIndex = 31
        '
        'Cb_ListaPrecio
        '
        Me.Cb_ListaPrecio.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cb_ListaPrecio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cb_ListaPrecio.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.VentasBindingSource, "ListaPrecioSeleccionado", True))
        Me.Cb_ListaPrecio.DataSource = Me.ListaPreciosBindingSource
        Me.Cb_ListaPrecio.DisplayMember = "Value"
        Me.Cb_ListaPrecio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_ListaPrecio.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Cb_ListaPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_ListaPrecio.FormattingEnabled = True
        Me.Cb_ListaPrecio.Location = New System.Drawing.Point(113, 3)
        Me.Cb_ListaPrecio.Name = "Cb_ListaPrecio"
        Me.Cb_ListaPrecio.Size = New System.Drawing.Size(193, 23)
        Me.Cb_ListaPrecio.TabIndex = 11
        Me.Cb_ListaPrecio.ValueMember = "Key"
        '
        'ListaPreciosBindingSource
        '
        Me.ListaPreciosBindingSource.DataMember = "ListaPrecios"
        Me.ListaPreciosBindingSource.DataSource = Me.VentasBindingSource
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(3, 7)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(104, 15)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Lista de Precios"
        '
        'GB_Pagos
        '
        Me.GB_Pagos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_Pagos.Controls.Add(Me.TableLayoutPanel3)
        Me.GB_Pagos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Pagos.Location = New System.Drawing.Point(12, 465)
        Me.GB_Pagos.Name = "GB_Pagos"
        Me.GB_Pagos.Size = New System.Drawing.Size(930, 222)
        Me.GB_Pagos.TabIndex = 28
        Me.GB_Pagos.TabStop = False
        Me.GB_Pagos.Text = "PAGOS"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.dgPagosTotales, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.dgPagos, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel5, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 17)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(924, 202)
        Me.TableLayoutPanel3.TabIndex = 33
        '
        'dgPagosTotales
        '
        Me.dgPagosTotales.AllowUserToAddRows = False
        Me.dgPagosTotales.AllowUserToDeleteRows = False
        Me.dgPagosTotales.AutoGenerateColumns = False
        Me.dgPagosTotales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPagosTotales.ColumnHeadersVisible = False
        Me.dgPagosTotales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14})
        Me.dgPagosTotales.DataSource = Me.TotalPagosBindingSource
        Me.dgPagosTotales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgPagosTotales.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgPagosTotales.Enabled = False
        Me.dgPagosTotales.Location = New System.Drawing.Point(3, 175)
        Me.dgPagosTotales.Name = "dgPagosTotales"
        Me.dgPagosTotales.ReadOnly = True
        Me.dgPagosTotales.RowHeadersVisible = False
        Me.dgPagosTotales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgPagosTotales.Size = New System.Drawing.Size(918, 24)
        Me.dgPagosTotales.TabIndex = 37
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "FormaPagoDescripcion"
        Me.DataGridViewTextBoxColumn9.HeaderText = "FormaPago"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "SubTotal"
        DataGridViewCellStyle1.Format = "C2"
        Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn10.HeaderText = "SubTotal"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 90
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Descuento"
        DataGridViewCellStyle2.Format = "C2"
        Me.DataGridViewTextBoxColumn11.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn11.HeaderText = "Descuento"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 90
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "CostoFinanciero"
        DataGridViewCellStyle3.Format = "C2"
        Me.DataGridViewTextBoxColumn12.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn12.HeaderText = "CFT"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Width = 90
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "IVA"
        DataGridViewCellStyle4.Format = "C2"
        Me.DataGridViewTextBoxColumn13.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn13.HeaderText = "IVA"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Width = 90
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Total"
        DataGridViewCellStyle5.Format = "C2"
        Me.DataGridViewTextBoxColumn14.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn14.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Width = 120
        '
        'TotalPagosBindingSource
        '
        Me.TotalPagosBindingSource.DataMember = "TotalPagos"
        Me.TotalPagosBindingSource.DataSource = Me.VentasBindingSource
        '
        'dgPagos
        '
        Me.dgPagos.AllowUserToAddRows = False
        Me.dgPagos.AllowUserToDeleteRows = False
        Me.dgPagos.AutoGenerateColumns = False
        Me.dgPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPagos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FormaPagoDataGridViewTextBoxColumn, Me.SubTotalDataGridViewTextBoxColumn, Me.DescuentoDataGridViewTextBoxColumn, Me.CostoFinancieroDataGridViewTextBoxColumn, Me.IVADataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn, Me.PagoQuitar})
        Me.dgPagos.DataSource = PagosBindingSource
        Me.dgPagos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgPagos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgPagos.Location = New System.Drawing.Point(3, 88)
        Me.dgPagos.Name = "dgPagos"
        Me.dgPagos.ReadOnly = True
        Me.dgPagos.RowHeadersVisible = False
        Me.dgPagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgPagos.Size = New System.Drawing.Size(918, 81)
        Me.dgPagos.TabIndex = 35
        '
        'FormaPagoDataGridViewTextBoxColumn
        '
        Me.FormaPagoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FormaPagoDataGridViewTextBoxColumn.DataPropertyName = "FormaPagoDescripcion"
        Me.FormaPagoDataGridViewTextBoxColumn.HeaderText = "Forma de Pago"
        Me.FormaPagoDataGridViewTextBoxColumn.Name = "FormaPagoDataGridViewTextBoxColumn"
        Me.FormaPagoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SubTotalDataGridViewTextBoxColumn
        '
        Me.SubTotalDataGridViewTextBoxColumn.DataPropertyName = "SubTotal"
        DataGridViewCellStyle6.Format = "C2"
        Me.SubTotalDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.SubTotalDataGridViewTextBoxColumn.HeaderText = "SubTotal"
        Me.SubTotalDataGridViewTextBoxColumn.Name = "SubTotalDataGridViewTextBoxColumn"
        Me.SubTotalDataGridViewTextBoxColumn.ReadOnly = True
        Me.SubTotalDataGridViewTextBoxColumn.Width = 90
        '
        'DescuentoDataGridViewTextBoxColumn
        '
        Me.DescuentoDataGridViewTextBoxColumn.DataPropertyName = "Descuento"
        DataGridViewCellStyle7.Format = "C2"
        Me.DescuentoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle7
        Me.DescuentoDataGridViewTextBoxColumn.HeaderText = "Descuento"
        Me.DescuentoDataGridViewTextBoxColumn.Name = "DescuentoDataGridViewTextBoxColumn"
        Me.DescuentoDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescuentoDataGridViewTextBoxColumn.Width = 90
        '
        'CostoFinancieroDataGridViewTextBoxColumn
        '
        Me.CostoFinancieroDataGridViewTextBoxColumn.DataPropertyName = "CostoFinanciero"
        DataGridViewCellStyle8.Format = "C2"
        Me.CostoFinancieroDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle8
        Me.CostoFinancieroDataGridViewTextBoxColumn.HeaderText = "CFT"
        Me.CostoFinancieroDataGridViewTextBoxColumn.Name = "CostoFinancieroDataGridViewTextBoxColumn"
        Me.CostoFinancieroDataGridViewTextBoxColumn.ReadOnly = True
        Me.CostoFinancieroDataGridViewTextBoxColumn.Width = 90
        '
        'IVADataGridViewTextBoxColumn
        '
        Me.IVADataGridViewTextBoxColumn.DataPropertyName = "IVA"
        DataGridViewCellStyle9.Format = "C2"
        Me.IVADataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle9
        Me.IVADataGridViewTextBoxColumn.HeaderText = "IVA"
        Me.IVADataGridViewTextBoxColumn.Name = "IVADataGridViewTextBoxColumn"
        Me.IVADataGridViewTextBoxColumn.ReadOnly = True
        Me.IVADataGridViewTextBoxColumn.Width = 90
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "Total"
        DataGridViewCellStyle10.Format = "C2"
        Me.TotalDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle10
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        Me.TotalDataGridViewTextBoxColumn.ReadOnly = True
        Me.TotalDataGridViewTextBoxColumn.Width = 90
        '
        'PagoQuitar
        '
        Me.PagoQuitar.HeaderText = ""
        Me.PagoQuitar.Image = Global.SistemaCinderella.My.Resources.Recursos.Boton_Eliminar
        Me.PagoQuitar.Name = "PagoQuitar"
        Me.PagoQuitar.ReadOnly = True
        Me.PagoQuitar.Width = 30
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel7, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel8, 0, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(918, 79)
        Me.TableLayoutPanel5.TabIndex = 36
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 10
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.txt_Subtotal, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.Label16, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.Label15, 2, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.txt_Descuento, 3, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.Label13, 4, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.txt_CFT, 5, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.Label17, 6, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.txt_IVA, 7, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.Label10, 8, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.txt_Total, 9, 0)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(3, 46)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(912, 30)
        Me.TableLayoutPanel7.TabIndex = 33
        '
        'txt_Subtotal
        '
        Me.txt_Subtotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Subtotal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_Subtotal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_Subtotal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasBindingSource, "SubTotal", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.txt_Subtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Subtotal.Location = New System.Drawing.Point(83, 4)
        Me.txt_Subtotal.Name = "txt_Subtotal"
        Me.txt_Subtotal.Size = New System.Drawing.Size(96, 22)
        Me.txt_Subtotal.TabIndex = 27
        Me.txt_Subtotal.Text = "0,00"
        Me.txt_Subtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(3, 7)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(74, 16)
        Me.Label16.TabIndex = 21
        Me.Label16.Text = "Subtotal"
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(185, 7)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(74, 16)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "Desc."
        '
        'txt_Descuento
        '
        Me.txt_Descuento.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Descuento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_Descuento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_Descuento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasBindingSource, "Descuento", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.txt_Descuento.Enabled = False
        Me.txt_Descuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Descuento.Location = New System.Drawing.Point(265, 4)
        Me.txt_Descuento.Name = "txt_Descuento"
        Me.txt_Descuento.ReadOnly = True
        Me.txt_Descuento.Size = New System.Drawing.Size(96, 22)
        Me.txt_Descuento.TabIndex = 24
        Me.txt_Descuento.Text = "0,00"
        Me.txt_Descuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(367, 7)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 16)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "CFT"
        '
        'txt_CFT
        '
        Me.txt_CFT.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_CFT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_CFT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_CFT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasBindingSource, "CostoFinanciero", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.txt_CFT.Enabled = False
        Me.txt_CFT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CFT.Location = New System.Drawing.Point(447, 4)
        Me.txt_CFT.Name = "txt_CFT"
        Me.txt_CFT.ReadOnly = True
        Me.txt_CFT.Size = New System.Drawing.Size(96, 22)
        Me.txt_CFT.TabIndex = 25
        Me.txt_CFT.Text = "0,00"
        Me.txt_CFT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(549, 7)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(74, 16)
        Me.Label17.TabIndex = 22
        Me.Label17.Text = "IVA 21%"
        '
        'txt_IVA
        '
        Me.txt_IVA.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_IVA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_IVA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_IVA.BackColor = System.Drawing.SystemColors.Control
        Me.txt_IVA.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasBindingSource, "IVA", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.txt_IVA.Enabled = False
        Me.txt_IVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_IVA.Location = New System.Drawing.Point(629, 4)
        Me.txt_IVA.Name = "txt_IVA"
        Me.txt_IVA.ReadOnly = True
        Me.txt_IVA.Size = New System.Drawing.Size(96, 22)
        Me.txt_IVA.TabIndex = 26
        Me.txt_IVA.Text = "0,00"
        Me.txt_IVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(731, 7)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 16)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Total"
        '
        'txt_Total
        '
        Me.txt_Total.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Total.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_Total.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_Total.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasBindingSource, "Total", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.txt_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Total.Location = New System.Drawing.Point(811, 4)
        Me.txt_Total.Name = "txt_Total"
        Me.txt_Total.Size = New System.Drawing.Size(98, 22)
        Me.txt_Total.TabIndex = 17
        Me.txt_Total.Text = "0,00"
        Me.txt_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.ColumnCount = 9
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.Cb_FormaPago, 1, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.Label8, 0, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.Cb_Banco, 3, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.Cb_NroCuota, 5, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.Label9, 2, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.Label11, 4, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.btnAgregaPago, 7, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.btnRecargarPago, 8, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.TextBox1, 6, 0)
        Me.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 1
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(912, 37)
        Me.TableLayoutPanel8.TabIndex = 34
        '
        'Cb_FormaPago
        '
        Me.Cb_FormaPago.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cb_FormaPago.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cb_FormaPago.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.VentasBindingSource, "FormaPagoSeleccionado", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.Cb_FormaPago.DataSource = Me.FormasPagosBindingSource
        Me.Cb_FormaPago.DisplayMember = "Value"
        Me.Cb_FormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_FormaPago.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Cb_FormaPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_FormaPago.FormattingEnabled = True
        Me.Cb_FormaPago.Location = New System.Drawing.Point(73, 7)
        Me.Cb_FormaPago.Name = "Cb_FormaPago"
        Me.Cb_FormaPago.Size = New System.Drawing.Size(164, 23)
        Me.Cb_FormaPago.TabIndex = 12
        Me.Cb_FormaPago.ValueMember = "Key"
        '
        'FormasPagosBindingSource
        '
        Me.FormasPagosBindingSource.DataMember = "FormasPagos"
        Me.FormasPagosBindingSource.DataSource = Me.VentasBindingSource
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 11)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 15)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "F. Pago"
        '
        'Cb_Banco
        '
        Me.Cb_Banco.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cb_Banco.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cb_Banco.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.VentasBindingSource, "ListaBancoSeleccionado", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.Cb_Banco.DataSource = Me.ListaBancosBindingSource
        Me.Cb_Banco.DisplayMember = "Nombre"
        Me.Cb_Banco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Banco.Enabled = False
        Me.Cb_Banco.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Cb_Banco.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_Banco.FormattingEnabled = True
        Me.Cb_Banco.Location = New System.Drawing.Point(313, 7)
        Me.Cb_Banco.Name = "Cb_Banco"
        Me.Cb_Banco.Size = New System.Drawing.Size(164, 23)
        Me.Cb_Banco.TabIndex = 18
        Me.Cb_Banco.ValueMember = "TarjetaId"
        '
        'ListaBancosBindingSource
        '
        Me.ListaBancosBindingSource.DataMember = "ListaBancos"
        Me.ListaBancosBindingSource.DataSource = Me.VentasBindingSource
        '
        'Cb_NroCuota
        '
        Me.Cb_NroCuota.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cb_NroCuota.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cb_NroCuota.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.VentasBindingSource, "ListaCuotaSeleccionado", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.Cb_NroCuota.DataSource = Me.ListaCuotasBindingSource
        Me.Cb_NroCuota.DisplayMember = "NumeroCuotas"
        Me.Cb_NroCuota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_NroCuota.Enabled = False
        Me.Cb_NroCuota.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Cb_NroCuota.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_NroCuota.FormattingEnabled = True
        Me.Cb_NroCuota.Location = New System.Drawing.Point(553, 7)
        Me.Cb_NroCuota.Name = "Cb_NroCuota"
        Me.Cb_NroCuota.Size = New System.Drawing.Size(79, 23)
        Me.Cb_NroCuota.TabIndex = 14
        Me.Cb_NroCuota.ValueMember = "CostoFinancieroId"
        '
        'ListaCuotasBindingSource
        '
        Me.ListaCuotasBindingSource.DataMember = "ListaCuotas"
        Me.ListaCuotasBindingSource.DataSource = Me.VentasBindingSource
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(243, 11)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 15)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Banco"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(483, 11)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 15)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "N° Cuotas"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasBindingSource, "CFTCuota", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "P"))
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(638, 7)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(64, 22)
        Me.TextBox1.TabIndex = 26
        Me.TextBox1.Text = "0,00"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DG_Productos
        '
        Me.DG_Productos.AllowUserToAddRows = False
        Me.DG_Productos.AllowUserToDeleteRows = False
        Me.DG_Productos.AutoGenerateColumns = False
        Me.DG_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Productos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductoCodigo, Me.ProductoNombre, Me.PorcentajeBonificacion, Me.ProductoCantidad, Me.ProductoPrecio, Me.ProductoIVA, Me.ProductoMonto, Me.PorcentajePago, Me.ProductoSubtotal, Me.ProductoQuitar})
        Me.DG_Productos.DataSource = Me.ProductosBindingSource
        Me.DG_Productos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_Productos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DG_Productos.Location = New System.Drawing.Point(3, 3)
        Me.DG_Productos.Name = "DG_Productos"
        Me.DG_Productos.RowHeadersVisible = False
        Me.DG_Productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Productos.Size = New System.Drawing.Size(924, 171)
        Me.DG_Productos.TabIndex = 32
        '
        'ProductoCodigo
        '
        Me.ProductoCodigo.DataPropertyName = "Codigo"
        Me.ProductoCodigo.HeaderText = "Código"
        Me.ProductoCodigo.Name = "ProductoCodigo"
        Me.ProductoCodigo.ReadOnly = True
        Me.ProductoCodigo.Width = 90
        '
        'ProductoNombre
        '
        Me.ProductoNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ProductoNombre.DataPropertyName = "Nombre"
        Me.ProductoNombre.HeaderText = "Nombre"
        Me.ProductoNombre.Name = "ProductoNombre"
        Me.ProductoNombre.ReadOnly = True
        '
        'PorcentajeBonificacion
        '
        Me.PorcentajeBonificacion.DataPropertyName = "PorcentajeBonificacion"
        DataGridViewCellStyle11.Format = "P"
        Me.PorcentajeBonificacion.DefaultCellStyle = DataGridViewCellStyle11
        Me.PorcentajeBonificacion.HeaderText = "% Bonif."
        Me.PorcentajeBonificacion.Name = "PorcentajeBonificacion"
        Me.PorcentajeBonificacion.Width = 75
        '
        'ProductoCantidad
        '
        Me.ProductoCantidad.DataPropertyName = "Cantidad"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ProductoCantidad.DefaultCellStyle = DataGridViewCellStyle12
        Me.ProductoCantidad.HeaderText = "Cantidad"
        Me.ProductoCantidad.Name = "ProductoCantidad"
        Me.ProductoCantidad.Width = 75
        '
        'ProductoPrecio
        '
        Me.ProductoPrecio.DataPropertyName = "Precio"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle13.Format = "C2"
        Me.ProductoPrecio.DefaultCellStyle = DataGridViewCellStyle13
        Me.ProductoPrecio.HeaderText = "Precio"
        Me.ProductoPrecio.Name = "ProductoPrecio"
        Me.ProductoPrecio.ReadOnly = True
        Me.ProductoPrecio.Visible = False
        Me.ProductoPrecio.Width = 90
        '
        'ProductoIVA
        '
        Me.ProductoIVA.DataPropertyName = "IVA"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle14.Format = "C2"
        Me.ProductoIVA.DefaultCellStyle = DataGridViewCellStyle14
        Me.ProductoIVA.HeaderText = "IVA"
        Me.ProductoIVA.Name = "ProductoIVA"
        Me.ProductoIVA.ReadOnly = True
        Me.ProductoIVA.Visible = False
        Me.ProductoIVA.Width = 90
        '
        'ProductoMonto
        '
        Me.ProductoMonto.DataPropertyName = "Monto"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle15.Format = "C2"
        Me.ProductoMonto.DefaultCellStyle = DataGridViewCellStyle15
        Me.ProductoMonto.HeaderText = "Monto"
        Me.ProductoMonto.Name = "ProductoMonto"
        Me.ProductoMonto.Width = 90
        '
        'PorcentajePago
        '
        Me.PorcentajePago.DataPropertyName = "PorcentajePago"
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle16.Format = "P"
        Me.PorcentajePago.DefaultCellStyle = DataGridViewCellStyle16
        Me.PorcentajePago.HeaderText = "% Pago"
        Me.PorcentajePago.Name = "PorcentajePago"
        Me.PorcentajePago.ReadOnly = True
        Me.PorcentajePago.Width = 75
        '
        'ProductoSubtotal
        '
        Me.ProductoSubtotal.DataPropertyName = "Subtotal"
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle17.Format = "C2"
        Me.ProductoSubtotal.DefaultCellStyle = DataGridViewCellStyle17
        Me.ProductoSubtotal.HeaderText = "Subtotal"
        Me.ProductoSubtotal.Name = "ProductoSubtotal"
        Me.ProductoSubtotal.ReadOnly = True
        Me.ProductoSubtotal.Width = 90
        '
        'ProductoQuitar
        '
        Me.ProductoQuitar.HeaderText = ""
        Me.ProductoQuitar.Image = Global.SistemaCinderella.My.Resources.Recursos.Boton_Eliminar
        Me.ProductoQuitar.Name = "ProductoQuitar"
        Me.ProductoQuitar.Width = 30
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "Productos"
        Me.ProductosBindingSource.DataSource = Me.VentasBindingSource
        '
        'DG_ProductosTotales
        '
        Me.DG_ProductosTotales.AllowUserToAddRows = False
        Me.DG_ProductosTotales.AllowUserToDeleteRows = False
        Me.DG_ProductosTotales.AutoGenerateColumns = False
        Me.DG_ProductosTotales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_ProductosTotales.ColumnHeadersVisible = False
        Me.DG_ProductosTotales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.ProductoPrecioTotal, Me.ProductoIVATotal, Me.DataGridViewTextBoxColumn7})
        Me.DG_ProductosTotales.DataSource = Me.TotalProductosBindingSource
        Me.DG_ProductosTotales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_ProductosTotales.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DG_ProductosTotales.Enabled = False
        Me.DG_ProductosTotales.Location = New System.Drawing.Point(3, 180)
        Me.DG_ProductosTotales.Name = "DG_ProductosTotales"
        Me.DG_ProductosTotales.ReadOnly = True
        Me.DG_ProductosTotales.RowHeadersVisible = False
        Me.DG_ProductosTotales.Size = New System.Drawing.Size(924, 24)
        Me.DG_ProductosTotales.TabIndex = 33
        '
        'TotalProductosBindingSource
        '
        Me.TotalProductosBindingSource.DataMember = "TotalProductos"
        Me.TotalProductosBindingSource.DataSource = Me.VentasBindingSource
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.DG_Productos, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.DG_ProductosTotales, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 255)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(930, 207)
        Me.TableLayoutPanel1.TabIndex = 34
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Cantidad"
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle18
        Me.DataGridViewTextBoxColumn3.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 75
        '
        'ProductoPrecioTotal
        '
        Me.ProductoPrecioTotal.DataPropertyName = "Precio"
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle19.Format = "C2"
        Me.ProductoPrecioTotal.DefaultCellStyle = DataGridViewCellStyle19
        Me.ProductoPrecioTotal.HeaderText = "Precio"
        Me.ProductoPrecioTotal.Name = "ProductoPrecioTotal"
        Me.ProductoPrecioTotal.ReadOnly = True
        Me.ProductoPrecioTotal.Visible = False
        Me.ProductoPrecioTotal.Width = 90
        '
        'ProductoIVATotal
        '
        Me.ProductoIVATotal.DataPropertyName = "IVA"
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle20.Format = "C2"
        Me.ProductoIVATotal.DefaultCellStyle = DataGridViewCellStyle20
        Me.ProductoIVATotal.HeaderText = "IVA"
        Me.ProductoIVATotal.Name = "ProductoIVATotal"
        Me.ProductoIVATotal.ReadOnly = True
        Me.ProductoIVATotal.Visible = False
        Me.ProductoIVATotal.Width = 90
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Subtotal"
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle21.Format = "C2"
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle21
        Me.DataGridViewTextBoxColumn7.HeaderText = "Subtotal"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 285
        '
        'frmVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(954, 737)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.BtnSenia)
        Me.Controls.Add(Me.GB_ListaPrecio)
        Me.Controls.Add(Me.Gb_Producto)
        Me.Controls.Add(Me.Btn_NotaPedido)
        Me.Controls.Add(Me.GB_Pagos)
        Me.Controls.Add(Me.Gb_Vendedor)
        Me.Controls.Add(Me.Gb_Cliente)
        Me.Controls.Add(Me.Btn_Cancelar)
        Me.Controls.Add(Me.Btn_Finalizar)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Ventas"
        CType(PagosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gb_Producto.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.Gb_Cliente.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        CType(Me.txt_PorcentajeFacturacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel12.ResumeLayout(False)
        Me.TableLayoutPanel12.PerformLayout()
        CType(Me.txt_PorcentajeBonificacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gb_Vendedor.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.VendedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EncargadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_ListaPrecio.ResumeLayout(False)
        Me.TableLayoutPanel9.ResumeLayout(False)
        Me.TableLayoutPanel9.PerformLayout()
        CType(Me.ListaPreciosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_Pagos.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.dgPagosTotales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalPagosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgPagos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel7.PerformLayout()
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel8.PerformLayout()
        CType(Me.FormasPagosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaBancosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaCuotasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_Productos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_ProductosTotales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_CodigoBarra As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Finalizar As System.Windows.Forms.Button
    Friend WithEvents Btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents Btn_Agregar As System.Windows.Forms.Button
    Friend WithEvents lbl_CodigoBarra As System.Windows.Forms.Label
    Friend WithEvents Gb_Producto As System.Windows.Forms.GroupBox
    Friend WithEvents Gb_Cliente As System.Windows.Forms.GroupBox
    Friend WithEvents Gb_Vendedor As System.Windows.Forms.GroupBox
    Friend WithEvents Cb_Vendedores As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Btn_BuscarCliente As System.Windows.Forms.Button
    Friend WithEvents txt_RazonSocial As System.Windows.Forms.TextBox
    Friend WithEvents txt_id_Cliente As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Cb_TipoCliente As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Reloj As System.Windows.Forms.Timer
    Friend WithEvents ToolProd As System.Windows.Forms.ToolTip
    Friend WithEvents Btn_Cambiar As System.Windows.Forms.Button
    Friend WithEvents Cb_Encargados As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GB_ListaPrecio As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Cb_ListaPrecio As System.Windows.Forms.ComboBox
    Friend WithEvents GB_Pagos As GroupBox
    Friend WithEvents BtnSenia As Button
    Friend WithEvents Btn_NotaPedido As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Label24 As Label
    Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
    Friend WithEvents txt_PorcentajeFacturacion As NumericUpDown
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel12 As TableLayoutPanel
    Friend WithEvents txt_PorcentajeBonificacion As NumericUpDown
    Friend WithEvents Label33 As Label
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents btnAgregaPago As Button
    Friend WithEvents VentasBindingSource As BindingSource
    Friend WithEvents VendedorBindingSource As BindingSource
    Friend WithEvents EncargadoBindingSource As BindingSource
    Friend WithEvents TipoClienteBindingSource As BindingSource
    Friend WithEvents ListaPreciosBindingSource As BindingSource
    Friend WithEvents FormasPagosBindingSource As BindingSource
    Friend WithEvents CachedCrystalReport21 As CachedCrystalReport2
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents DG_Productos As CustomDataGrid
    Friend WithEvents ProductosBindingSource As BindingSource
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Cb_FormaPago As ComboBox
    Friend WithEvents Cb_NroCuota As ComboBox
    Friend WithEvents Cb_Banco As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_Total As TextBox
    Friend WithEvents ListaBancosBindingSource As BindingSource
    Friend WithEvents ListaCuotasBindingSource As BindingSource
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txt_Descuento As TextBox
    Friend WithEvents txt_CFT As TextBox
    Friend WithEvents txt_IVA As TextBox
    Friend WithEvents dgPagos As CustomDataGrid
    Friend WithEvents PagoMonto As DataGridViewTextBoxColumn
    Friend WithEvents PagoDescuentoRecargo As DataGridViewTextBoxColumn
    Friend WithEvents PagoTotal As DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents btnRecargarPago As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txt_Subtotal As TextBox
    Friend WithEvents DG_ProductosTotales As CustomDataGrid
    Friend WithEvents dgPagosTotales As CustomDataGrid
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TotalProductosBindingSource As BindingSource
    Friend WithEvents TotalPagosBindingSource As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents FormaPagoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SubTotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescuentoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CostoFinancieroDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IVADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PagoQuitar As DataGridViewImageColumn
    Friend WithEvents ProductoCodigo As DataGridViewTextBoxColumn
    Friend WithEvents ProductoNombre As DataGridViewTextBoxColumn
    Friend WithEvents PorcentajeBonificacion As DataGridViewTextBoxColumn
    Friend WithEvents ProductoCantidad As DataGridViewTextBoxColumn
    Friend WithEvents ProductoPrecio As DataGridViewTextBoxColumn
    Friend WithEvents ProductoIVA As DataGridViewTextBoxColumn
    Friend WithEvents ProductoMonto As DataGridViewTextBoxColumn
    Friend WithEvents PorcentajePago As DataGridViewTextBoxColumn
    Friend WithEvents ProductoSubtotal As DataGridViewTextBoxColumn
    Friend WithEvents ProductoQuitar As DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents ProductoPrecioTotal As DataGridViewTextBoxColumn
    Friend WithEvents ProductoIVATotal As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
End Class
