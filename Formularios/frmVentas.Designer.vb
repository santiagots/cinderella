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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GB_Fecha = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_Hora = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_Sucursal = New System.Windows.Forms.Label()
        Me.lbl_Fecha = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Reloj = New System.Windows.Forms.Timer(Me.components)
        Me.ToolProd = New System.Windows.Forms.ToolTip(Me.components)
        Me.txt_Descuento = New System.Windows.Forms.TextBox()
        Me.BtnSenia = New System.Windows.Forms.Button()
        Me.txt_Senia = New System.Windows.Forms.TextBox()
        Me.Btn_NotaPedido = New System.Windows.Forms.Button()
        Me.btnAgregaFormaPago = New System.Windows.Forms.Button()
        Me.GB_ListaPrecio = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel9 = New System.Windows.Forms.TableLayoutPanel()
        Me.Cb_ListaPrecio = New System.Windows.Forms.ComboBox()
        Me.ListaPreciosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_IVA = New System.Windows.Forms.TextBox()
        Me.lblTotal4 = New System.Windows.Forms.Label()
        Me.TableLayoutPanelTotales = New System.Windows.Forms.TableLayoutPanel()
        Me.lblTotal2 = New System.Windows.Forms.Label()
        Me.lblTotal1 = New System.Windows.Forms.Label()
        Me.lblTotal6 = New System.Windows.Forms.Label()
        Me.lblTotal5 = New System.Windows.Forms.Label()
        Me.lblTotal3 = New System.Windows.Forms.Label()
        Me.txt_CFT = New System.Windows.Forms.TextBox()
        Me.txt_Subtotal = New System.Windows.Forms.TextBox()
        Me.txt_Total = New System.Windows.Forms.TextBox()
        Me.GB_Pagos = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.Cb_Banco = New System.Windows.Forms.ComboBox()
        Me.ListaBancosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Cb_FormaPago = New System.Windows.Forms.ComboBox()
        Me.FormasPagosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_MontoPago = New System.Windows.Forms.TextBox()
        Me.Cb_NroCuota = New System.Windows.Forms.ComboBox()
        Me.ListaCuotasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_TotalPago = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgPagos = New SistemaCinderella.CustomDataGrid()
        Me.FormaPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PagoMonto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PagoDescuentoRecargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PagoTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PagoQuitar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.CachedCrystalReport21 = New SistemaCinderella.CachedCrystalReport2()
        Me.DG_Productos = New SistemaCinderella.CustomDataGrid()
        Me.ProductoCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductoNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductoCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductoPrecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductoIVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductoMonto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductoSubtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductoQuitar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.GB_Fecha.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GB_ListaPrecio.SuspendLayout()
        Me.TableLayoutPanel9.SuspendLayout()
        CType(Me.ListaPreciosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanelTotales.SuspendLayout()
        Me.GB_Pagos.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        CType(Me.ListaBancosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormasPagosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaCuotasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel5.SuspendLayout()
        CType(Me.dgPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_Productos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Btn_Finalizar.Location = New System.Drawing.Point(844, 690)
        Me.Btn_Finalizar.Name = "Btn_Finalizar"
        Me.Btn_Finalizar.Size = New System.Drawing.Size(95, 40)
        Me.Btn_Finalizar.TabIndex = 17
        Me.Btn_Finalizar.Text = "Finalizar"
        Me.Btn_Finalizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolProd.SetToolTip(Me.Btn_Finalizar, "Finaliza la venta actual. ")
        Me.Btn_Finalizar.UseVisualStyleBackColor = True
        Me.Btn_Finalizar.Visible = False
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Cancelar.Image = Global.SistemaCinderella.My.Resources.Recursos.desconectado_32
        Me.Btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Cancelar.Location = New System.Drawing.Point(537, 690)
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
        Me.Gb_Producto.Location = New System.Drawing.Point(12, 237)
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
        Me.Gb_Cliente.Location = New System.Drawing.Point(12, 134)
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
        Me.txt_PorcentajeBonificacion.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VentasBindingSource, "ProcentajeBonificacion", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
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
        Me.Gb_Vendedor.Location = New System.Drawing.Point(12, 69)
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
        Me.VendedorBindingSource.DataMember = "Vendedor"
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
        Me.EncargadoBindingSource.DataMember = "Encargado"
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
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(349, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 15)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "FECHA:"
        '
        'GB_Fecha
        '
        Me.GB_Fecha.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_Fecha.Controls.Add(Me.TableLayoutPanel1)
        Me.GB_Fecha.Location = New System.Drawing.Point(12, 12)
        Me.GB_Fecha.Name = "GB_Fecha"
        Me.GB_Fecha.Size = New System.Drawing.Size(930, 51)
        Me.GB_Fecha.TabIndex = 14
        Me.GB_Fecha.TabStop = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 8
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_Hora, 7, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 6, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_Sucursal, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_Fecha, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 3, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(6, 15)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(913, 30)
        Me.TableLayoutPanel1.TabIndex = 30
        '
        'lbl_Hora
        '
        Me.lbl_Hora.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Hora.AutoSize = True
        Me.lbl_Hora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Hora.Location = New System.Drawing.Point(805, 7)
        Me.lbl_Hora.Name = "lbl_Hora"
        Me.lbl_Hora.Size = New System.Drawing.Size(105, 15)
        Me.lbl_Hora.TabIndex = 14
        Me.lbl_Hora.Text = "Label5"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(695, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 15)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "HORA:"
        '
        'lbl_Sucursal
        '
        Me.lbl_Sucursal.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl_Sucursal.AutoSize = True
        Me.lbl_Sucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Sucursal.Location = New System.Drawing.Point(113, 7)
        Me.lbl_Sucursal.Name = "lbl_Sucursal"
        Me.lbl_Sucursal.Size = New System.Drawing.Size(45, 15)
        Me.lbl_Sucursal.TabIndex = 18
        Me.lbl_Sucursal.Text = "Label5"
        '
        'lbl_Fecha
        '
        Me.lbl_Fecha.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl_Fecha.AutoSize = True
        Me.lbl_Fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Fecha.Location = New System.Drawing.Point(459, 7)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(45, 15)
        Me.lbl_Fecha.TabIndex = 15
        Me.lbl_Fecha.Text = "Label6"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 15)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "SUCURSAL:"
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
        'txt_Descuento
        '
        Me.txt_Descuento.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Descuento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasBindingSource, "Descuento", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "0", "C2"))
        Me.txt_Descuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Descuento.Location = New System.Drawing.Point(202, 3)
        Me.txt_Descuento.Name = "txt_Descuento"
        Me.txt_Descuento.Size = New System.Drawing.Size(194, 26)
        Me.txt_Descuento.TabIndex = 27
        Me.txt_Descuento.Text = "0,00"
        Me.txt_Descuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolProd.SetToolTip(Me.txt_Descuento, "Si desea agregar un descuento al pedido, sólo debe ingresar el monto en éste camp" &
        "o.")
        '
        'BtnSenia
        '
        Me.BtnSenia.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSenia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSenia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSenia.Image = Global.SistemaCinderella.My.Resources.Recursos.Agregar_24
        Me.BtnSenia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSenia.Location = New System.Drawing.Point(642, 690)
        Me.BtnSenia.Name = "BtnSenia"
        Me.BtnSenia.Size = New System.Drawing.Size(75, 40)
        Me.BtnSenia.TabIndex = 23
        Me.BtnSenia.Text = "Señar"
        Me.BtnSenia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolProd.SetToolTip(Me.BtnSenia, "Señar la venta actual. ")
        Me.BtnSenia.UseVisualStyleBackColor = True
        '
        'txt_Senia
        '
        Me.txt_Senia.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Senia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasBindingSource, "Senia", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "0", "C2"))
        Me.txt_Senia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Senia.Location = New System.Drawing.Point(202, 123)
        Me.txt_Senia.Name = "txt_Senia"
        Me.txt_Senia.ReadOnly = True
        Me.txt_Senia.Size = New System.Drawing.Size(194, 26)
        Me.txt_Senia.TabIndex = 35
        Me.txt_Senia.Text = "0,00"
        Me.txt_Senia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolProd.SetToolTip(Me.txt_Senia, "Ingrese un monto en case de querer realizar una seña.")
        Me.txt_Senia.Visible = False
        '
        'Btn_NotaPedido
        '
        Me.Btn_NotaPedido.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_NotaPedido.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_NotaPedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_NotaPedido.Image = Global.SistemaCinderella.My.Resources.Recursos.Agregar_24
        Me.Btn_NotaPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_NotaPedido.Location = New System.Drawing.Point(722, 690)
        Me.Btn_NotaPedido.Name = "Btn_NotaPedido"
        Me.Btn_NotaPedido.Size = New System.Drawing.Size(117, 40)
        Me.Btn_NotaPedido.TabIndex = 29
        Me.Btn_NotaPedido.Text = "Nota Pedido"
        Me.Btn_NotaPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolProd.SetToolTip(Me.Btn_NotaPedido, "Crear nota de pedido. ")
        Me.Btn_NotaPedido.UseVisualStyleBackColor = True
        Me.Btn_NotaPedido.Visible = False
        '
        'btnAgregaFormaPago
        '
        Me.btnAgregaFormaPago.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregaFormaPago.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregaFormaPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregaFormaPago.Image = Global.SistemaCinderella.My.Resources.Recursos.Agregar_24
        Me.btnAgregaFormaPago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregaFormaPago.Location = New System.Drawing.Point(413, 3)
        Me.btnAgregaFormaPago.Name = "btnAgregaFormaPago"
        Me.btnAgregaFormaPago.Size = New System.Drawing.Size(91, 33)
        Me.btnAgregaFormaPago.TabIndex = 24
        Me.btnAgregaFormaPago.Text = "Agregar"
        Me.btnAgregaFormaPago.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolProd.SetToolTip(Me.btnAgregaFormaPago, "Señar la venta actual. ")
        Me.btnAgregaFormaPago.UseVisualStyleBackColor = True
        '
        'GB_ListaPrecio
        '
        Me.GB_ListaPrecio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_ListaPrecio.Controls.Add(Me.TableLayoutPanel9)
        Me.GB_ListaPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_ListaPrecio.Location = New System.Drawing.Point(618, 134)
        Me.GB_ListaPrecio.Name = "GB_ListaPrecio"
        Me.GB_ListaPrecio.Size = New System.Drawing.Size(324, 97)
        Me.GB_ListaPrecio.TabIndex = 22
        Me.GB_ListaPrecio.TabStop = False
        Me.GB_ListaPrecio.Text = "LISTA PRECIOS"
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
        'txt_IVA
        '
        Me.txt_IVA.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_IVA.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasBindingSource, "IVA", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "0", "C2"))
        Me.txt_IVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_IVA.Location = New System.Drawing.Point(202, 93)
        Me.txt_IVA.Name = "txt_IVA"
        Me.txt_IVA.ReadOnly = True
        Me.txt_IVA.Size = New System.Drawing.Size(194, 26)
        Me.txt_IVA.TabIndex = 23
        Me.txt_IVA.Text = "0,00"
        Me.txt_IVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTotal4
        '
        Me.lblTotal4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblTotal4.AutoSize = True
        Me.lblTotal4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal4.Location = New System.Drawing.Point(3, 95)
        Me.lblTotal4.Name = "lblTotal4"
        Me.lblTotal4.Size = New System.Drawing.Size(77, 19)
        Me.lblTotal4.TabIndex = 24
        Me.lblTotal4.Text = "IVA 21%:"
        '
        'TableLayoutPanelTotales
        '
        Me.TableLayoutPanelTotales.ColumnCount = 2
        Me.TableLayoutPanelTotales.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelTotales.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelTotales.Controls.Add(Me.lblTotal2, 0, 1)
        Me.TableLayoutPanelTotales.Controls.Add(Me.lblTotal1, 0, 0)
        Me.TableLayoutPanelTotales.Controls.Add(Me.lblTotal6, 0, 5)
        Me.TableLayoutPanelTotales.Controls.Add(Me.lblTotal5, 0, 4)
        Me.TableLayoutPanelTotales.Controls.Add(Me.lblTotal4, 0, 3)
        Me.TableLayoutPanelTotales.Controls.Add(Me.lblTotal3, 0, 2)
        Me.TableLayoutPanelTotales.Controls.Add(Me.txt_Descuento, 1, 0)
        Me.TableLayoutPanelTotales.Controls.Add(Me.txt_CFT, 1, 1)
        Me.TableLayoutPanelTotales.Controls.Add(Me.txt_Subtotal, 1, 2)
        Me.TableLayoutPanelTotales.Controls.Add(Me.txt_IVA, 1, 3)
        Me.TableLayoutPanelTotales.Controls.Add(Me.txt_Senia, 1, 4)
        Me.TableLayoutPanelTotales.Controls.Add(Me.txt_Total, 1, 5)
        Me.TableLayoutPanelTotales.Location = New System.Drawing.Point(543, 499)
        Me.TableLayoutPanelTotales.Name = "TableLayoutPanelTotales"
        Me.TableLayoutPanelTotales.RowCount = 6
        Me.TableLayoutPanelTotales.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanelTotales.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanelTotales.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanelTotales.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanelTotales.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanelTotales.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanelTotales.Size = New System.Drawing.Size(399, 190)
        Me.TableLayoutPanelTotales.TabIndex = 31
        '
        'lblTotal2
        '
        Me.lblTotal2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblTotal2.AutoSize = True
        Me.lblTotal2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal2.Location = New System.Drawing.Point(3, 35)
        Me.lblTotal2.Name = "lblTotal2"
        Me.lblTotal2.Size = New System.Drawing.Size(176, 19)
        Me.lblTotal2.TabIndex = 38
        Me.lblTotal2.Text = "COSTO FINANCIERO:"
        '
        'lblTotal1
        '
        Me.lblTotal1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblTotal1.AutoSize = True
        Me.lblTotal1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal1.Location = New System.Drawing.Point(3, 5)
        Me.lblTotal1.Name = "lblTotal1"
        Me.lblTotal1.Size = New System.Drawing.Size(118, 19)
        Me.lblTotal1.TabIndex = 30
        Me.lblTotal1.Text = "DESCUENTO:"
        '
        'lblTotal6
        '
        Me.lblTotal6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblTotal6.AutoSize = True
        Me.lblTotal6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal6.Location = New System.Drawing.Point(3, 160)
        Me.lblTotal6.Name = "lblTotal6"
        Me.lblTotal6.Size = New System.Drawing.Size(174, 19)
        Me.lblTotal6.TabIndex = 26
        Me.lblTotal6.Text = "IMPORTE A ABONAR:"
        '
        'lblTotal5
        '
        Me.lblTotal5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblTotal5.AutoSize = True
        Me.lblTotal5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal5.Location = New System.Drawing.Point(3, 125)
        Me.lblTotal5.Name = "lblTotal5"
        Me.lblTotal5.Size = New System.Drawing.Size(60, 19)
        Me.lblTotal5.TabIndex = 36
        Me.lblTotal5.Text = "SEÑA:"
        Me.lblTotal5.Visible = False
        '
        'lblTotal3
        '
        Me.lblTotal3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblTotal3.AutoSize = True
        Me.lblTotal3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal3.Location = New System.Drawing.Point(3, 65)
        Me.lblTotal3.Name = "lblTotal3"
        Me.lblTotal3.Size = New System.Drawing.Size(102, 19)
        Me.lblTotal3.TabIndex = 31
        Me.lblTotal3.Text = "SUBTOTAL:"
        '
        'txt_CFT
        '
        Me.txt_CFT.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_CFT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasBindingSource, "CostoFinanciero", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "0", "C2"))
        Me.txt_CFT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CFT.Location = New System.Drawing.Point(202, 33)
        Me.txt_CFT.Name = "txt_CFT"
        Me.txt_CFT.ReadOnly = True
        Me.txt_CFT.Size = New System.Drawing.Size(194, 26)
        Me.txt_CFT.TabIndex = 40
        Me.txt_CFT.Text = "0,00"
        Me.txt_CFT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_Subtotal
        '
        Me.txt_Subtotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Subtotal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasBindingSource, "SubTotal", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "0", "C2"))
        Me.txt_Subtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Subtotal.Location = New System.Drawing.Point(202, 63)
        Me.txt_Subtotal.Name = "txt_Subtotal"
        Me.txt_Subtotal.ReadOnly = True
        Me.txt_Subtotal.Size = New System.Drawing.Size(194, 26)
        Me.txt_Subtotal.TabIndex = 28
        Me.txt_Subtotal.Text = "0,00"
        Me.txt_Subtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_Total
        '
        Me.txt_Total.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Total.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasBindingSource, "ImporteAbonar", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "0", "C2"))
        Me.txt_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Total.Location = New System.Drawing.Point(202, 157)
        Me.txt_Total.Name = "txt_Total"
        Me.txt_Total.ReadOnly = True
        Me.txt_Total.Size = New System.Drawing.Size(194, 26)
        Me.txt_Total.TabIndex = 29
        Me.txt_Total.Text = "0,00"
        Me.txt_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GB_Pagos
        '
        Me.GB_Pagos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GB_Pagos.Controls.Add(Me.TableLayoutPanel3)
        Me.GB_Pagos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Pagos.Location = New System.Drawing.Point(12, 499)
        Me.GB_Pagos.Name = "GB_Pagos"
        Me.GB_Pagos.Size = New System.Drawing.Size(519, 234)
        Me.GB_Pagos.TabIndex = 28
        Me.GB_Pagos.TabStop = False
        Me.GB_Pagos.Text = "PAGOS"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel7, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel5, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.dgPagos, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 17)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(513, 214)
        Me.TableLayoutPanel3.TabIndex = 33
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 4
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.99999!))
        Me.TableLayoutPanel7.Controls.Add(Me.Cb_Banco, 0, 1)
        Me.TableLayoutPanel7.Controls.Add(Me.Label9, 0, 1)
        Me.TableLayoutPanel7.Controls.Add(Me.Label8, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.Cb_FormaPago, 1, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.Label10, 2, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.Label11, 2, 1)
        Me.TableLayoutPanel7.Controls.Add(Me.txt_MontoPago, 3, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.Cb_NroCuota, 3, 1)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 2
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(507, 59)
        Me.TableLayoutPanel7.TabIndex = 33
        '
        'Cb_Banco
        '
        Me.Cb_Banco.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cb_Banco.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cb_Banco.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.VentasBindingSource, "ListaBancoSeleccionado", True))
        Me.Cb_Banco.DataSource = Me.ListaBancosBindingSource
        Me.Cb_Banco.DisplayMember = "Nombre"
        Me.Cb_Banco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Banco.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Cb_Banco.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_Banco.FormattingEnabled = True
        Me.Cb_Banco.Location = New System.Drawing.Point(93, 32)
        Me.Cb_Banco.Name = "Cb_Banco"
        Me.Cb_Banco.Size = New System.Drawing.Size(157, 23)
        Me.Cb_Banco.TabIndex = 18
        Me.Cb_Banco.ValueMember = "TarjetaId"
        '
        'ListaBancosBindingSource
        '
        Me.ListaBancosBindingSource.DataMember = "ListaBancos"
        Me.ListaBancosBindingSource.DataSource = Me.VentasBindingSource
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 36)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 15)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Banco"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 7)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 15)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Forma Pago"
        '
        'Cb_FormaPago
        '
        Me.Cb_FormaPago.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cb_FormaPago.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cb_FormaPago.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.VentasBindingSource, "FormaPagoSeleccionado", True))
        Me.Cb_FormaPago.DataSource = Me.FormasPagosBindingSource
        Me.Cb_FormaPago.DisplayMember = "Value"
        Me.Cb_FormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_FormaPago.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Cb_FormaPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_FormaPago.FormattingEnabled = True
        Me.Cb_FormaPago.Location = New System.Drawing.Point(93, 3)
        Me.Cb_FormaPago.Name = "Cb_FormaPago"
        Me.Cb_FormaPago.Size = New System.Drawing.Size(157, 23)
        Me.Cb_FormaPago.TabIndex = 12
        Me.Cb_FormaPago.ValueMember = "Key"
        '
        'FormasPagosBindingSource
        '
        Me.FormasPagosBindingSource.DataMember = "FormasPagos"
        Me.FormasPagosBindingSource.DataSource = Me.VentasBindingSource
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(256, 7)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 15)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Monto"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(256, 36)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 15)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "N° Cuotas"
        '
        'txt_MontoPago
        '
        Me.txt_MontoPago.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_MontoPago.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_MontoPago.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_MontoPago.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasBindingSource, "MontoPago", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.txt_MontoPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MontoPago.Location = New System.Drawing.Point(346, 4)
        Me.txt_MontoPago.Name = "txt_MontoPago"
        Me.txt_MontoPago.Size = New System.Drawing.Size(158, 21)
        Me.txt_MontoPago.TabIndex = 17
        Me.txt_MontoPago.Text = "0,00"
        '
        'Cb_NroCuota
        '
        Me.Cb_NroCuota.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cb_NroCuota.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cb_NroCuota.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.VentasBindingSource, "ListaCuotaSeleccionado", True))
        Me.Cb_NroCuota.DataSource = Me.ListaCuotasBindingSource
        Me.Cb_NroCuota.DisplayMember = "NumeroCuotas"
        Me.Cb_NroCuota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_NroCuota.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Cb_NroCuota.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_NroCuota.FormattingEnabled = True
        Me.Cb_NroCuota.Location = New System.Drawing.Point(346, 32)
        Me.Cb_NroCuota.Name = "Cb_NroCuota"
        Me.Cb_NroCuota.Size = New System.Drawing.Size(158, 23)
        Me.Cb_NroCuota.TabIndex = 14
        Me.Cb_NroCuota.ValueMember = "CostoFinancieroId"
        '
        'ListaCuotasBindingSource
        '
        Me.ListaCuotasBindingSource.DataMember = "ListaCuotas"
        Me.ListaCuotasBindingSource.DataSource = Me.VentasBindingSource
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 3
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.txt_TotalPago, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.btnAgregaFormaPago, 2, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 172)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(507, 39)
        Me.TableLayoutPanel5.TabIndex = 34
        '
        'txt_TotalPago
        '
        Me.txt_TotalPago.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_TotalPago.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasBindingSource, "TotalPago", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "0", "C2"))
        Me.txt_TotalPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TotalPago.Location = New System.Drawing.Point(206, 6)
        Me.txt_TotalPago.Name = "txt_TotalPago"
        Me.txt_TotalPago.ReadOnly = True
        Me.txt_TotalPago.Size = New System.Drawing.Size(197, 26)
        Me.txt_TotalPago.TabIndex = 41
        Me.txt_TotalPago.Text = "0,00"
        Me.txt_TotalPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 19)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "TOTAL:"
        '
        'dgPagos
        '
        Me.dgPagos.AllowUserToAddRows = False
        Me.dgPagos.AllowUserToDeleteRows = False
        Me.dgPagos.AutoGenerateColumns = False
        Me.dgPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPagos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FormaPago, Me.PagoMonto, Me.PagoDescuentoRecargo, Me.PagoTotal, Me.PagoQuitar})
        Me.dgPagos.DataSource = PagosBindingSource
        Me.dgPagos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgPagos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgPagos.Location = New System.Drawing.Point(3, 68)
        Me.dgPagos.Name = "dgPagos"
        Me.dgPagos.Size = New System.Drawing.Size(507, 98)
        Me.dgPagos.TabIndex = 35
        '
        'FormaPago
        '
        Me.FormaPago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FormaPago.DataPropertyName = "FormaPago"
        Me.FormaPago.HeaderText = "Forma Pago"
        Me.FormaPago.Name = "FormaPago"
        '
        'PagoMonto
        '
        Me.PagoMonto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PagoMonto.DataPropertyName = "Monto"
        DataGridViewCellStyle1.Format = "C2"
        Me.PagoMonto.DefaultCellStyle = DataGridViewCellStyle1
        Me.PagoMonto.HeaderText = "Monto"
        Me.PagoMonto.Name = "PagoMonto"
        Me.PagoMonto.ReadOnly = True
        Me.PagoMonto.Width = 72
        '
        'PagoDescuentoRecargo
        '
        Me.PagoDescuentoRecargo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PagoDescuentoRecargo.DataPropertyName = "DescuentoRecargo"
        DataGridViewCellStyle2.Format = "C2"
        Me.PagoDescuentoRecargo.DefaultCellStyle = DataGridViewCellStyle2
        Me.PagoDescuentoRecargo.HeaderText = "Desc./Rec."
        Me.PagoDescuentoRecargo.Name = "PagoDescuentoRecargo"
        Me.PagoDescuentoRecargo.ReadOnly = True
        Me.PagoDescuentoRecargo.Width = 101
        '
        'PagoTotal
        '
        Me.PagoTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PagoTotal.DataPropertyName = "Subtotal"
        DataGridViewCellStyle3.Format = "C2"
        Me.PagoTotal.DefaultCellStyle = DataGridViewCellStyle3
        Me.PagoTotal.HeaderText = "Subtotal"
        Me.PagoTotal.Name = "PagoTotal"
        Me.PagoTotal.ReadOnly = True
        Me.PagoTotal.Width = 85
        '
        'PagoQuitar
        '
        Me.PagoQuitar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PagoQuitar.HeaderText = ""
        Me.PagoQuitar.Image = Global.SistemaCinderella.My.Resources.Recursos.Boton_Eliminar
        Me.PagoQuitar.Name = "PagoQuitar"
        Me.PagoQuitar.Width = 5
        '
        'DG_Productos
        '
        Me.DG_Productos.AllowUserToAddRows = False
        Me.DG_Productos.AllowUserToDeleteRows = False
        Me.DG_Productos.AutoGenerateColumns = False
        Me.DG_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Productos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductoCodigo, Me.ProductoNombre, Me.ProductoCantidad, Me.ProductoPrecio, Me.ProductoIVA, Me.ProductoMonto, Me.ProductoSubtotal, Me.ProductoQuitar})
        Me.DG_Productos.DataSource = Me.ProductosBindingSource
        Me.DG_Productos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DG_Productos.Location = New System.Drawing.Point(12, 312)
        Me.DG_Productos.Name = "DG_Productos"
        Me.DG_Productos.Size = New System.Drawing.Size(930, 181)
        Me.DG_Productos.TabIndex = 32
        '
        'ProductoCodigo
        '
        Me.ProductoCodigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ProductoCodigo.DataPropertyName = "Codigo"
        Me.ProductoCodigo.HeaderText = "Código"
        Me.ProductoCodigo.Name = "ProductoCodigo"
        Me.ProductoCodigo.ReadOnly = True
        Me.ProductoCodigo.Width = 71
        '
        'ProductoNombre
        '
        Me.ProductoNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ProductoNombre.DataPropertyName = "Nombre"
        Me.ProductoNombre.HeaderText = "Nombre"
        Me.ProductoNombre.Name = "ProductoNombre"
        Me.ProductoNombre.ReadOnly = True
        '
        'ProductoCantidad
        '
        Me.ProductoCantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ProductoCantidad.DataPropertyName = "Cantidad"
        Me.ProductoCantidad.HeaderText = "Cantidad"
        Me.ProductoCantidad.Name = "ProductoCantidad"
        Me.ProductoCantidad.Width = 81
        '
        'ProductoPrecio
        '
        Me.ProductoPrecio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ProductoPrecio.DataPropertyName = "Precio"
        DataGridViewCellStyle4.Format = "C2"
        Me.ProductoPrecio.DefaultCellStyle = DataGridViewCellStyle4
        Me.ProductoPrecio.HeaderText = "Precio"
        Me.ProductoPrecio.Name = "ProductoPrecio"
        Me.ProductoPrecio.Width = 67
        '
        'ProductoIVA
        '
        Me.ProductoIVA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ProductoIVA.DataPropertyName = "IVA"
        DataGridViewCellStyle5.Format = "C2"
        Me.ProductoIVA.DefaultCellStyle = DataGridViewCellStyle5
        Me.ProductoIVA.HeaderText = "IVA"
        Me.ProductoIVA.Name = "ProductoIVA"
        Me.ProductoIVA.ReadOnly = True
        Me.ProductoIVA.Width = 49
        '
        'ProductoMonto
        '
        Me.ProductoMonto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ProductoMonto.DataPropertyName = "Monto"
        DataGridViewCellStyle6.Format = "C2"
        Me.ProductoMonto.DefaultCellStyle = DataGridViewCellStyle6
        Me.ProductoMonto.HeaderText = "Monto"
        Me.ProductoMonto.Name = "ProductoMonto"
        Me.ProductoMonto.ReadOnly = True
        Me.ProductoMonto.Width = 67
        '
        'ProductoSubtotal
        '
        Me.ProductoSubtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ProductoSubtotal.DataPropertyName = "Subtotal"
        DataGridViewCellStyle7.Format = "C2"
        Me.ProductoSubtotal.DefaultCellStyle = DataGridViewCellStyle7
        Me.ProductoSubtotal.HeaderText = "Subtotal"
        Me.ProductoSubtotal.Name = "ProductoSubtotal"
        Me.ProductoSubtotal.ReadOnly = True
        Me.ProductoSubtotal.Width = 77
        '
        'ProductoQuitar
        '
        Me.ProductoQuitar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ProductoQuitar.HeaderText = ""
        Me.ProductoQuitar.Image = Global.SistemaCinderella.My.Resources.Recursos.Boton_Eliminar
        Me.ProductoQuitar.Name = "ProductoQuitar"
        Me.ProductoQuitar.Width = 5
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "Productos"
        Me.ProductosBindingSource.DataSource = Me.VentasBindingSource
        '
        'frmVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(954, 737)
        Me.Controls.Add(Me.DG_Productos)
        Me.Controls.Add(Me.TableLayoutPanelTotales)
        Me.Controls.Add(Me.BtnSenia)
        Me.Controls.Add(Me.GB_ListaPrecio)
        Me.Controls.Add(Me.Gb_Producto)
        Me.Controls.Add(Me.Btn_NotaPedido)
        Me.Controls.Add(Me.GB_Pagos)
        Me.Controls.Add(Me.GB_Fecha)
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
        Me.GB_Fecha.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.GB_ListaPrecio.ResumeLayout(False)
        Me.TableLayoutPanel9.ResumeLayout(False)
        Me.TableLayoutPanel9.PerformLayout()
        CType(Me.ListaPreciosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanelTotales.ResumeLayout(False)
        Me.TableLayoutPanelTotales.PerformLayout()
        Me.GB_Pagos.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel7.PerformLayout()
        CType(Me.ListaBancosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FormasPagosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaCuotasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        CType(Me.dgPagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_Productos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GB_Fecha As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbl_Fecha As System.Windows.Forms.Label
    Friend WithEvents lbl_Hora As System.Windows.Forms.Label
    Friend WithEvents Reloj As System.Windows.Forms.Timer
    Friend WithEvents lbl_Sucursal As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ToolProd As System.Windows.Forms.ToolTip
    Friend WithEvents Btn_Cambiar As System.Windows.Forms.Button
    Friend WithEvents Cb_Encargados As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GB_ListaPrecio As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Cb_ListaPrecio As System.Windows.Forms.ComboBox
    Friend WithEvents txt_IVA As TextBox
    Friend WithEvents lblTotal4 As Label
    Friend WithEvents txt_Subtotal As TextBox
    Friend WithEvents lblTotal3 As Label
    Friend WithEvents txt_Total As TextBox
    Friend WithEvents txt_Descuento As TextBox
    Friend WithEvents lblTotal1 As Label
    Friend WithEvents lblTotal6 As Label
    Friend WithEvents GB_Pagos As GroupBox
    Friend WithEvents BtnSenia As Button
    Friend WithEvents lblTotal5 As Label
    Friend WithEvents txt_Senia As TextBox
    Friend WithEvents Btn_NotaPedido As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Label24 As Label
    Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
    Friend WithEvents txt_PorcentajeFacturacion As NumericUpDown
    Friend WithEvents TableLayoutPanelTotales As TableLayoutPanel
    Friend WithEvents txt_CFT As TextBox
    Friend WithEvents lblTotal2 As Label
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel12 As TableLayoutPanel
    Friend WithEvents txt_PorcentajeBonificacion As NumericUpDown
    Friend WithEvents Label33 As Label
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents btnAgregaFormaPago As Button
    Friend WithEvents VentasBindingSource As BindingSource
    Friend WithEvents VendedorBindingSource As BindingSource
    Friend WithEvents EncargadoBindingSource As BindingSource
    Friend WithEvents TipoClienteBindingSource As BindingSource
    Friend WithEvents ListaPreciosBindingSource As BindingSource
    Friend WithEvents FormasPagosBindingSource As BindingSource
    Friend WithEvents CachedCrystalReport21 As CachedCrystalReport2
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents txt_TotalPago As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dgPagos As CustomDataGrid
    Friend WithEvents DG_Productos As CustomDataGrid
    Friend WithEvents ProductosBindingSource As BindingSource
    Friend WithEvents ProductoCodigo As DataGridViewTextBoxColumn
    Friend WithEvents ProductoNombre As DataGridViewTextBoxColumn
    Friend WithEvents ProductoCantidad As DataGridViewTextBoxColumn
    Friend WithEvents ProductoPrecio As DataGridViewTextBoxColumn
    Friend WithEvents ProductoIVA As DataGridViewTextBoxColumn
    Friend WithEvents ProductoMonto As DataGridViewTextBoxColumn
    Friend WithEvents ProductoSubtotal As DataGridViewTextBoxColumn
    Friend WithEvents ProductoQuitar As DataGridViewImageColumn
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Cb_FormaPago As ComboBox
    Friend WithEvents Cb_NroCuota As ComboBox
    Friend WithEvents Cb_Banco As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_MontoPago As TextBox
    Friend WithEvents ListaBancosBindingSource As BindingSource
    Friend WithEvents ListaCuotasBindingSource As BindingSource
    Friend WithEvents FormaPago As DataGridViewTextBoxColumn
    Friend WithEvents PagoMonto As DataGridViewTextBoxColumn
    Friend WithEvents PagoDescuentoRecargo As DataGridViewTextBoxColumn
    Friend WithEvents PagoTotal As DataGridViewTextBoxColumn
    Friend WithEvents PagoQuitar As DataGridViewImageColumn
End Class
