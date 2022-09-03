<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVentas

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
        Me.txt_CodigoBarra = New System.Windows.Forms.TextBox()
        Me.VentaViewModelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Btn_Finalizar = New System.Windows.Forms.Button()
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.Btn_Agregar = New System.Windows.Forms.Button()
        Me.lbl_CodigoBarra = New System.Windows.Forms.Label()
        Me.Gb_Producto = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Btn_Buscar = New System.Windows.Forms.Button()
        Me.Btn_Cambiar = New System.Windows.Forms.Button()
        Me.Gb_ClienteMayorista = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_RazonSocial = New System.Windows.Forms.TextBox()
        Me.Btn_BuscarCliente = New System.Windows.Forms.Button()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_id_Cliente = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txt_PorcentajeBonificacion = New Controles.PercentUpDown()
        Me.txt_PorcentajeFacturacion = New Controles.PercentUpDown()
        Me.Gb_Vendedor = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Cb_Vendedores = New System.Windows.Forms.ComboBox()
        Me.VendedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cb_Encargados = New System.Windows.Forms.ComboBox()
        Me.EncargadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Cb_TipoCliente = New System.Windows.Forms.ComboBox()
        Me.TipoClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolProd = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnReserva = New System.Windows.Forms.Button()
        Me.Btn_NotaPedido = New System.Windows.Forms.Button()
        Me.btnRecargarPago = New System.Windows.Forms.Button()
        Me.btnAgregaPago = New System.Windows.Forms.Button()
        Me.GB_Pagos = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgPagosTotales = New SistemaCinderella.CustomDataGrid()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescuentoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CFTDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IVADataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPagoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgPagos = New SistemaCinderella.CustomDataGrid()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescuentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CFTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IVADataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Resto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PagoQuitar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.PagoCorregir = New System.Windows.Forms.DataGridViewImageColumn()
        Me.PagosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.FormaPagoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Cb_Trajeta = New System.Windows.Forms.ComboBox()
        Me.TarjetaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cb_NroCuota = New System.Windows.Forms.ComboBox()
        Me.CuotaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCuotaCFT = New System.Windows.Forms.TextBox()
        Me.DG_Productos = New SistemaCinderella.CustomDataGrid()
        Me.Seleccionado = New SistemaCinderella.DataGridViewCheckBoxHeaderColumn()
        Me.CodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductosCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductosMonto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IvaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductosPorcentajeBonificacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PorcentajePagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductosQuitar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.VentaItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DG_ProductosTotales = New SistemaCinderella.CustomDataGrid()
        Me.TotalSeleccionado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IvaDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PorcentajePagoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalVentaItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel9 = New System.Windows.Forms.TableLayoutPanel()
        Me.Cb_ListaPrecio = New System.Windows.Forms.ComboBox()
        Me.ListaPrecioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.VentaViewModelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gb_Producto.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.Gb_ClienteMayorista.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        CType(Me.txt_PorcentajeBonificacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_PorcentajeFacturacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gb_Vendedor.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.VendedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EncargadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_Pagos.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.dgPagosTotales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalPagoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        CType(Me.FormaPagoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TarjetaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuotaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_Productos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentaItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_ProductosTotales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalVentaItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel9.SuspendLayout()
        CType(Me.ListaPrecioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_CodigoBarra
        '
        Me.txt_CodigoBarra.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_CodigoBarra.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_CodigoBarra.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_CodigoBarra.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentaViewModelBindingSource, "NombreCodigoProductoBusqueda", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_CodigoBarra.Enabled = False
        Me.txt_CodigoBarra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CodigoBarra.Location = New System.Drawing.Point(69, 11)
        Me.txt_CodigoBarra.Name = "txt_CodigoBarra"
        Me.txt_CodigoBarra.Size = New System.Drawing.Size(395, 21)
        Me.txt_CodigoBarra.TabIndex = 0
        '
        'VentaViewModelBindingSource
        '
        Me.VentaViewModelBindingSource.DataSource = GetType(SistemaCinderella.Formularios.Venta.frmVentasViewModel)
        '
        'Btn_Finalizar
        '
        Me.Btn_Finalizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Finalizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Finalizar.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.VentaViewModelBindingSource, "HabilitarVenta", True))
        Me.Btn_Finalizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Finalizar.Image = Global.SistemaCinderella.My.Resources.Recursos.Conectado_32
        Me.Btn_Finalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Finalizar.Location = New System.Drawing.Point(847, 693)
        Me.Btn_Finalizar.Name = "Btn_Finalizar"
        Me.Btn_Finalizar.Size = New System.Drawing.Size(95, 35)
        Me.Btn_Finalizar.TabIndex = 3
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
        Me.Btn_Cancelar.Location = New System.Drawing.Point(523, 693)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(100, 35)
        Me.Btn_Cancelar.TabIndex = 0
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
        Me.Btn_Agregar.Location = New System.Drawing.Point(474, 5)
        Me.Btn_Agregar.Name = "Btn_Agregar"
        Me.Btn_Agregar.Size = New System.Drawing.Size(100, 34)
        Me.Btn_Agregar.TabIndex = 1
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
        Me.lbl_CodigoBarra.Location = New System.Drawing.Point(3, 7)
        Me.lbl_CodigoBarra.Name = "lbl_CodigoBarra"
        Me.lbl_CodigoBarra.Size = New System.Drawing.Size(60, 30)
        Me.lbl_CodigoBarra.TabIndex = 7
        Me.lbl_CodigoBarra.Text = "Nombre / Código"
        '
        'Gb_Producto
        '
        Me.Gb_Producto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gb_Producto.Controls.Add(Me.TableLayoutPanel4)
        Me.Gb_Producto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gb_Producto.Location = New System.Drawing.Point(12, 144)
        Me.Gb_Producto.Name = "Gb_Producto"
        Me.Gb_Producto.Size = New System.Drawing.Size(740, 69)
        Me.Gb_Producto.TabIndex = 10
        Me.Gb_Producto.TabStop = False
        Me.Gb_Producto.Text = "PRODUCTO"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel4.ColumnCount = 5
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.Btn_Buscar, 4, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.lbl_CodigoBarra, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Btn_Agregar, 2, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Btn_Cambiar, 3, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.txt_CodigoBarra, 1, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(6, 19)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(727, 44)
        Me.TableLayoutPanel4.TabIndex = 30
        '
        'Btn_Buscar
        '
        Me.Btn_Buscar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Btn_Buscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Buscar.Image = Global.SistemaCinderella.My.Resources.Recursos.IconoBuscar24
        Me.Btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Buscar.Location = New System.Drawing.Point(690, 5)
        Me.Btn_Buscar.Name = "Btn_Buscar"
        Me.Btn_Buscar.Size = New System.Drawing.Size(34, 34)
        Me.Btn_Buscar.TabIndex = 9
        Me.Btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolProd.SetToolTip(Me.Btn_Buscar, "Permite buscar productos en el sistema por nombre / código.")
        Me.Btn_Buscar.UseVisualStyleBackColor = True
        '
        'Btn_Cambiar
        '
        Me.Btn_Cambiar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Btn_Cambiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Cambiar.Image = Global.SistemaCinderella.My.Resources.Recursos.Cambios_32
        Me.Btn_Cambiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Cambiar.Location = New System.Drawing.Point(584, 5)
        Me.Btn_Cambiar.Name = "Btn_Cambiar"
        Me.Btn_Cambiar.Size = New System.Drawing.Size(100, 34)
        Me.Btn_Cambiar.TabIndex = 2
        Me.Btn_Cambiar.Text = "Cambiar"
        Me.Btn_Cambiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolProd.SetToolTip(Me.Btn_Cambiar, "Permite agregar productos que ingresan a la sucursal.")
        Me.Btn_Cambiar.UseVisualStyleBackColor = True
        '
        'Gb_ClienteMayorista
        '
        Me.Gb_ClienteMayorista.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gb_ClienteMayorista.Controls.Add(Me.TableLayoutPanel6)
        Me.Gb_ClienteMayorista.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.VentaViewModelBindingSource, "EsClienteMayorista", True))
        Me.Gb_ClienteMayorista.Enabled = False
        Me.Gb_ClienteMayorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gb_ClienteMayorista.Location = New System.Drawing.Point(12, 77)
        Me.Gb_ClienteMayorista.Name = "Gb_ClienteMayorista"
        Me.Gb_ClienteMayorista.Size = New System.Drawing.Size(930, 61)
        Me.Gb_ClienteMayorista.TabIndex = 11
        Me.Gb_ClienteMayorista.TabStop = False
        Me.Gb_ClienteMayorista.Text = "CLIENTE"
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel6.ColumnCount = 8
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.txt_RazonSocial, 2, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.Btn_BuscarCliente, 3, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.Label33, 6, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.txt_id_Cliente, 1, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.Label24, 4, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.txt_PorcentajeBonificacion, 7, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.txt_PorcentajeFacturacion, 5, 0)
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(7, 20)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(917, 34)
        Me.TableLayoutPanel6.TabIndex = 0
        '
        'txt_RazonSocial
        '
        Me.txt_RazonSocial.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_RazonSocial.BackColor = System.Drawing.SystemColors.Window
        Me.txt_RazonSocial.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentaViewModelBindingSource, "NombreClienteMayorista", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_RazonSocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_RazonSocial.Location = New System.Drawing.Point(158, 7)
        Me.txt_RazonSocial.Name = "txt_RazonSocial"
        Me.txt_RazonSocial.ReadOnly = True
        Me.txt_RazonSocial.Size = New System.Drawing.Size(319, 21)
        Me.txt_RazonSocial.TabIndex = 1
        '
        'Btn_BuscarCliente
        '
        Me.Btn_BuscarCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_BuscarCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_BuscarCliente.FlatAppearance.BorderSize = 0
        Me.Btn_BuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_BuscarCliente.Image = Global.SistemaCinderella.My.Resources.Recursos.Clientes_32
        Me.Btn_BuscarCliente.Location = New System.Drawing.Point(483, 3)
        Me.Btn_BuscarCliente.Name = "Btn_BuscarCliente"
        Me.Btn_BuscarCliente.Size = New System.Drawing.Size(41, 29)
        Me.Btn_BuscarCliente.TabIndex = 2
        Me.ToolProd.SetToolTip(Me.Btn_BuscarCliente, "Permite buscar clientes en el sistema por razon social.")
        Me.Btn_BuscarCliente.UseVisualStyleBackColor = True
        '
        'Label33
        '
        Me.Label33.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(725, 10)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(89, 15)
        Me.Label33.TabIndex = 8
        Me.Label33.Text = "Bonificación"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Cliente"
        '
        'txt_id_Cliente
        '
        Me.txt_id_Cliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_id_Cliente.BackColor = System.Drawing.SystemColors.Window
        Me.txt_id_Cliente.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentaViewModelBindingSource, "IdClienteMayorista", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_id_Cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id_Cliente.Location = New System.Drawing.Point(58, 7)
        Me.txt_id_Cliente.Name = "txt_id_Cliente"
        Me.txt_id_Cliente.ReadOnly = True
        Me.txt_id_Cliente.Size = New System.Drawing.Size(94, 21)
        Me.txt_id_Cliente.TabIndex = 0
        '
        'Label24
        '
        Me.Label24.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(530, 10)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(89, 15)
        Me.Label24.TabIndex = 7
        Me.Label24.Text = "Facturación"
        '
        'txt_PorcentajeBonificacion
        '
        Me.txt_PorcentajeBonificacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_PorcentajeBonificacion.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VentaViewModelBindingSource, "PorcentajeBonificacion", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_PorcentajeBonificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PorcentajeBonificacion.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.txt_PorcentajeBonificacion.Location = New System.Drawing.Point(820, 7)
        Me.txt_PorcentajeBonificacion.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txt_PorcentajeBonificacion.Name = "txt_PorcentajeBonificacion"
        Me.txt_PorcentajeBonificacion.Size = New System.Drawing.Size(94, 21)
        Me.txt_PorcentajeBonificacion.TabIndex = 4
        Me.txt_PorcentajeBonificacion.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txt_PorcentajeFacturacion
        '
        Me.txt_PorcentajeFacturacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_PorcentajeFacturacion.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VentaViewModelBindingSource, "PorcentajeFacturacion", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_PorcentajeFacturacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PorcentajeFacturacion.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.txt_PorcentajeFacturacion.Location = New System.Drawing.Point(625, 7)
        Me.txt_PorcentajeFacturacion.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txt_PorcentajeFacturacion.Name = "txt_PorcentajeFacturacion"
        Me.txt_PorcentajeFacturacion.Size = New System.Drawing.Size(94, 21)
        Me.txt_PorcentajeFacturacion.TabIndex = 3
        Me.txt_PorcentajeFacturacion.Value = New Decimal(New Integer() {0, 0, 0, 0})
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
        Me.Cb_Vendedores.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.VentaViewModelBindingSource, "VendedoresSeleccionado", True))
        Me.Cb_Vendedores.DataSource = Me.VendedoresBindingSource
        Me.Cb_Vendedores.DisplayMember = "ApellidoYNombre"
        Me.Cb_Vendedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Vendedores.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Cb_Vendedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_Vendedores.FormattingEnabled = True
        Me.Cb_Vendedores.Location = New System.Drawing.Point(747, 3)
        Me.Cb_Vendedores.Name = "Cb_Vendedores"
        Me.Cb_Vendedores.Size = New System.Drawing.Size(162, 23)
        Me.Cb_Vendedores.TabIndex = 2
        Me.Cb_Vendedores.ValueMember = "Id"
        '
        'VendedoresBindingSource
        '
        Me.VendedoresBindingSource.DataMember = "Vendedores"
        Me.VendedoresBindingSource.DataSource = Me.VentaViewModelBindingSource
        '
        'Cb_Encargados
        '
        Me.Cb_Encargados.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cb_Encargados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cb_Encargados.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.VentaViewModelBindingSource, "EncargadoSeleccionado", True))
        Me.Cb_Encargados.DataSource = Me.EncargadosBindingSource
        Me.Cb_Encargados.DisplayMember = "ApellidoYNombre"
        Me.Cb_Encargados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Encargados.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Cb_Encargados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_Encargados.FormattingEnabled = True
        Me.Cb_Encargados.Location = New System.Drawing.Point(420, 3)
        Me.Cb_Encargados.Name = "Cb_Encargados"
        Me.Cb_Encargados.Size = New System.Drawing.Size(161, 23)
        Me.Cb_Encargados.TabIndex = 1
        Me.Cb_Encargados.ValueMember = "Id"
        '
        'EncargadosBindingSource
        '
        Me.EncargadosBindingSource.DataMember = "Encargados"
        Me.EncargadosBindingSource.DataSource = Me.VentaViewModelBindingSource
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
        Me.Cb_TipoCliente.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.VentaViewModelBindingSource, "TipoClienteSeleccionado", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Cb_TipoCliente.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.VentaViewModelBindingSource, "HabilitarTipoCliente", True))
        Me.Cb_TipoCliente.DataSource = Me.TipoClienteBindingSource
        Me.Cb_TipoCliente.DisplayMember = "Key"
        Me.Cb_TipoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_TipoCliente.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Cb_TipoCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_TipoCliente.FormattingEnabled = True
        Me.Cb_TipoCliente.Location = New System.Drawing.Point(93, 3)
        Me.Cb_TipoCliente.Name = "Cb_TipoCliente"
        Me.Cb_TipoCliente.Size = New System.Drawing.Size(161, 23)
        Me.Cb_TipoCliente.TabIndex = 0
        Me.Cb_TipoCliente.ValueMember = "Key"
        '
        'TipoClienteBindingSource
        '
        Me.TipoClienteBindingSource.DataMember = "TipoCliente"
        Me.TipoClienteBindingSource.DataSource = Me.VentaViewModelBindingSource
        '
        'ToolProd
        '
        Me.ToolProd.IsBalloon = True
        Me.ToolProd.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolProd.ToolTipTitle = "Ayuda"
        '
        'BtnReserva
        '
        Me.BtnReserva.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnReserva.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnReserva.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.VentaViewModelBindingSource, "HabilitarReserva", True))
        Me.BtnReserva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReserva.Image = Global.SistemaCinderella.My.Resources.Recursos.Agregar_24
        Me.BtnReserva.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnReserva.Location = New System.Drawing.Point(629, 693)
        Me.BtnReserva.Name = "BtnReserva"
        Me.BtnReserva.Size = New System.Drawing.Size(91, 35)
        Me.BtnReserva.TabIndex = 1
        Me.BtnReserva.Text = "Reserva"
        Me.BtnReserva.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolProd.SetToolTip(Me.BtnReserva, "Señar la venta actual. ")
        Me.BtnReserva.UseVisualStyleBackColor = True
        '
        'Btn_NotaPedido
        '
        Me.Btn_NotaPedido.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_NotaPedido.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_NotaPedido.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.VentaViewModelBindingSource, "HabilitarNotaPedido", True))
        Me.Btn_NotaPedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_NotaPedido.Image = Global.SistemaCinderella.My.Resources.Recursos.Agregar_24
        Me.Btn_NotaPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_NotaPedido.Location = New System.Drawing.Point(725, 693)
        Me.Btn_NotaPedido.Name = "Btn_NotaPedido"
        Me.Btn_NotaPedido.Size = New System.Drawing.Size(117, 35)
        Me.Btn_NotaPedido.TabIndex = 2
        Me.Btn_NotaPedido.Text = "Nota Pedido"
        Me.Btn_NotaPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolProd.SetToolTip(Me.Btn_NotaPedido, "Crear nota de pedido. ")
        Me.Btn_NotaPedido.UseVisualStyleBackColor = True
        '
        'btnRecargarPago
        '
        Me.btnRecargarPago.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRecargarPago.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.VentaViewModelBindingSource, "NoEstaPaga", True))
        Me.btnRecargarPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecargarPago.Image = Global.SistemaCinderella.My.Resources.Recursos.btn_Update_24
        Me.btnRecargarPago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRecargarPago.Location = New System.Drawing.Point(810, 3)
        Me.btnRecargarPago.Name = "btnRecargarPago"
        Me.btnRecargarPago.Size = New System.Drawing.Size(96, 31)
        Me.btnRecargarPago.TabIndex = 5
        Me.btnRecargarPago.Text = "Recargar"
        Me.btnRecargarPago.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolProd.SetToolTip(Me.btnRecargarPago, "Señar la venta actual. ")
        Me.btnRecargarPago.UseVisualStyleBackColor = True
        '
        'btnAgregaPago
        '
        Me.btnAgregaPago.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregaPago.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.VentaViewModelBindingSource, "NoEstaPaga", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnAgregaPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregaPago.Image = Global.SistemaCinderella.My.Resources.Recursos.Agregar_24
        Me.btnAgregaPago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregaPago.Location = New System.Drawing.Point(708, 3)
        Me.btnAgregaPago.Name = "btnAgregaPago"
        Me.btnAgregaPago.Size = New System.Drawing.Size(96, 31)
        Me.btnAgregaPago.TabIndex = 4
        Me.btnAgregaPago.Text = "Agregar"
        Me.btnAgregaPago.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolProd.SetToolTip(Me.btnAgregaPago, "Señar la venta actual. ")
        Me.btnAgregaPago.UseVisualStyleBackColor = True
        '
        'GB_Pagos
        '
        Me.GB_Pagos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_Pagos.Controls.Add(Me.TableLayoutPanel3)
        Me.GB_Pagos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Pagos.Location = New System.Drawing.Point(12, 447)
        Me.GB_Pagos.Name = "GB_Pagos"
        Me.GB_Pagos.Size = New System.Drawing.Size(930, 240)
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
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(924, 220)
        Me.TableLayoutPanel3.TabIndex = 33
        '
        'dgPagosTotales
        '
        Me.dgPagosTotales.AllowUserToAddRows = False
        Me.dgPagosTotales.AllowUserToDeleteRows = False
        Me.dgPagosTotales.AutoGenerateColumns = False
        Me.dgPagosTotales.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgPagosTotales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPagosTotales.ColumnHeadersVisible = False
        Me.dgPagosTotales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.MontoDataGridViewTextBoxColumn3, Me.DescuentoDataGridViewTextBoxColumn1, Me.CFTDataGridViewTextBoxColumn1, Me.IVADataGridViewTextBoxColumn3, Me.TotalDataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn2, Me.Column3, Me.Column4})
        Me.dgPagosTotales.DataSource = Me.TotalPagoBindingSource
        Me.dgPagosTotales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgPagosTotales.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgPagosTotales.Enabled = False
        Me.dgPagosTotales.Location = New System.Drawing.Point(3, 193)
        Me.dgPagosTotales.Name = "dgPagosTotales"
        Me.dgPagosTotales.ReadOnly = True
        Me.dgPagosTotales.RowHeadersVisible = False
        Me.dgPagosTotales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgPagosTotales.Size = New System.Drawing.Size(918, 24)
        Me.dgPagosTotales.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Descripcion"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'MontoDataGridViewTextBoxColumn3
        '
        Me.MontoDataGridViewTextBoxColumn3.DataPropertyName = "Monto"
        DataGridViewCellStyle1.Format = "C"
        Me.MontoDataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle1
        Me.MontoDataGridViewTextBoxColumn3.HeaderText = "Monto"
        Me.MontoDataGridViewTextBoxColumn3.Name = "MontoDataGridViewTextBoxColumn3"
        Me.MontoDataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DescuentoDataGridViewTextBoxColumn1
        '
        Me.DescuentoDataGridViewTextBoxColumn1.DataPropertyName = "Descuento"
        DataGridViewCellStyle2.Format = "C"
        Me.DescuentoDataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DescuentoDataGridViewTextBoxColumn1.HeaderText = "Descuento"
        Me.DescuentoDataGridViewTextBoxColumn1.Name = "DescuentoDataGridViewTextBoxColumn1"
        Me.DescuentoDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'CFTDataGridViewTextBoxColumn1
        '
        Me.CFTDataGridViewTextBoxColumn1.DataPropertyName = "CFT"
        DataGridViewCellStyle3.Format = "C"
        Me.CFTDataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle3
        Me.CFTDataGridViewTextBoxColumn1.HeaderText = "CFT"
        Me.CFTDataGridViewTextBoxColumn1.Name = "CFTDataGridViewTextBoxColumn1"
        Me.CFTDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'IVADataGridViewTextBoxColumn3
        '
        Me.IVADataGridViewTextBoxColumn3.DataPropertyName = "IVA"
        DataGridViewCellStyle4.Format = "C"
        Me.IVADataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle4
        Me.IVADataGridViewTextBoxColumn3.HeaderText = "IVA"
        Me.IVADataGridViewTextBoxColumn3.Name = "IVADataGridViewTextBoxColumn3"
        Me.IVADataGridViewTextBoxColumn3.ReadOnly = True
        '
        'TotalDataGridViewTextBoxColumn3
        '
        Me.TotalDataGridViewTextBoxColumn3.DataPropertyName = "Total"
        DataGridViewCellStyle5.Format = "C"
        Me.TotalDataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle5
        Me.TotalDataGridViewTextBoxColumn3.HeaderText = "Total"
        Me.TotalDataGridViewTextBoxColumn3.Name = "TotalDataGridViewTextBoxColumn3"
        Me.TotalDataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Resto"
        DataGridViewCellStyle6.Format = "C2"
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn2.HeaderText = "Resto"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = ""
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 30
        '
        'Column4
        '
        Me.Column4.HeaderText = ""
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 30
        '
        'TotalPagoBindingSource
        '
        Me.TotalPagoBindingSource.DataMember = "TotalPago"
        Me.TotalPagoBindingSource.DataSource = Me.VentaViewModelBindingSource
        '
        'dgPagos
        '
        Me.dgPagos.AllowUserToAddRows = False
        Me.dgPagos.AllowUserToDeleteRows = False
        Me.dgPagos.AutoGenerateColumns = False
        Me.dgPagos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPagos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Descripcion, Me.MontoDataGridViewTextBoxColumn1, Me.DescuentoDataGridViewTextBoxColumn, Me.CFTDataGridViewTextBoxColumn, Me.IVADataGridViewTextBoxColumn1, Me.TotalDataGridViewTextBoxColumn1, Me.Resto, Me.PagoQuitar, Me.PagoCorregir})
        Me.dgPagos.DataSource = Me.PagosBindingSource
        Me.dgPagos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgPagos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgPagos.Location = New System.Drawing.Point(3, 88)
        Me.dgPagos.Name = "dgPagos"
        Me.dgPagos.ReadOnly = True
        Me.dgPagos.RowHeadersVisible = False
        Me.dgPagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgPagos.Size = New System.Drawing.Size(918, 99)
        Me.dgPagos.TabIndex = 0
        '
        'Descripcion
        '
        Me.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Descripcion.DataPropertyName = "Descripcion"
        Me.Descripcion.HeaderText = "Descripción"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        '
        'MontoDataGridViewTextBoxColumn1
        '
        Me.MontoDataGridViewTextBoxColumn1.DataPropertyName = "Monto"
        DataGridViewCellStyle7.Format = "C"
        Me.MontoDataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle7
        Me.MontoDataGridViewTextBoxColumn1.HeaderText = "Monto"
        Me.MontoDataGridViewTextBoxColumn1.Name = "MontoDataGridViewTextBoxColumn1"
        Me.MontoDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DescuentoDataGridViewTextBoxColumn
        '
        Me.DescuentoDataGridViewTextBoxColumn.DataPropertyName = "Descuento"
        DataGridViewCellStyle8.Format = "C"
        Me.DescuentoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle8
        Me.DescuentoDataGridViewTextBoxColumn.HeaderText = "Desc."
        Me.DescuentoDataGridViewTextBoxColumn.Name = "DescuentoDataGridViewTextBoxColumn"
        Me.DescuentoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CFTDataGridViewTextBoxColumn
        '
        Me.CFTDataGridViewTextBoxColumn.DataPropertyName = "CFT"
        DataGridViewCellStyle9.Format = "C"
        Me.CFTDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle9
        Me.CFTDataGridViewTextBoxColumn.HeaderText = "CFT"
        Me.CFTDataGridViewTextBoxColumn.Name = "CFTDataGridViewTextBoxColumn"
        Me.CFTDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IVADataGridViewTextBoxColumn1
        '
        Me.IVADataGridViewTextBoxColumn1.DataPropertyName = "IVA"
        DataGridViewCellStyle10.Format = "C"
        Me.IVADataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle10
        Me.IVADataGridViewTextBoxColumn1.HeaderText = "IVA"
        Me.IVADataGridViewTextBoxColumn1.Name = "IVADataGridViewTextBoxColumn1"
        Me.IVADataGridViewTextBoxColumn1.ReadOnly = True
        '
        'TotalDataGridViewTextBoxColumn1
        '
        Me.TotalDataGridViewTextBoxColumn1.DataPropertyName = "Total"
        DataGridViewCellStyle11.Format = "C"
        Me.TotalDataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle11
        Me.TotalDataGridViewTextBoxColumn1.HeaderText = "Total"
        Me.TotalDataGridViewTextBoxColumn1.Name = "TotalDataGridViewTextBoxColumn1"
        Me.TotalDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'Resto
        '
        Me.Resto.DataPropertyName = "Resto"
        DataGridViewCellStyle12.Format = "C2"
        Me.Resto.DefaultCellStyle = DataGridViewCellStyle12
        Me.Resto.HeaderText = "Resto"
        Me.Resto.Name = "Resto"
        Me.Resto.ReadOnly = True
        '
        'PagoQuitar
        '
        Me.PagoQuitar.HeaderText = ""
        Me.PagoQuitar.Image = Global.SistemaCinderella.My.Resources.Recursos.Boton_Eliminar
        Me.PagoQuitar.Name = "PagoQuitar"
        Me.PagoQuitar.ReadOnly = True
        Me.PagoQuitar.Width = 30
        '
        'PagoCorregir
        '
        Me.PagoCorregir.HeaderText = ""
        Me.PagoCorregir.Image = Global.SistemaCinderella.My.Resources.Recursos.btn_Update_24
        Me.PagoCorregir.Name = "PagoCorregir"
        Me.PagoCorregir.ReadOnly = True
        Me.PagoCorregir.Width = 30
        '
        'PagosBindingSource
        '
        Me.PagosBindingSource.DataMember = "Pagos"
        Me.PagosBindingSource.DataSource = Me.VentaViewModelBindingSource
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
        Me.txt_Subtotal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentaViewModelBindingSource, "Subtotal", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.txt_Subtotal.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.VentaViewModelBindingSource, "NoEstaPaga", True))
        Me.txt_Subtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Subtotal.Location = New System.Drawing.Point(83, 4)
        Me.txt_Subtotal.Name = "txt_Subtotal"
        Me.txt_Subtotal.Size = New System.Drawing.Size(96, 22)
        Me.txt_Subtotal.TabIndex = 1
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
        Me.Label16.TabIndex = 0
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
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Desc."
        '
        'txt_Descuento
        '
        Me.txt_Descuento.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Descuento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentaViewModelBindingSource, "Descuento", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.txt_Descuento.Enabled = False
        Me.txt_Descuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Descuento.Location = New System.Drawing.Point(265, 4)
        Me.txt_Descuento.Name = "txt_Descuento"
        Me.txt_Descuento.ReadOnly = True
        Me.txt_Descuento.Size = New System.Drawing.Size(96, 22)
        Me.txt_Descuento.TabIndex = 3
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
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "CFT"
        '
        'txt_CFT
        '
        Me.txt_CFT.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_CFT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentaViewModelBindingSource, "Cft", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.txt_CFT.Enabled = False
        Me.txt_CFT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CFT.Location = New System.Drawing.Point(447, 4)
        Me.txt_CFT.Name = "txt_CFT"
        Me.txt_CFT.ReadOnly = True
        Me.txt_CFT.Size = New System.Drawing.Size(96, 22)
        Me.txt_CFT.TabIndex = 5
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
        Me.Label17.TabIndex = 6
        Me.Label17.Text = "IVA 21%"
        '
        'txt_IVA
        '
        Me.txt_IVA.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_IVA.BackColor = System.Drawing.SystemColors.Control
        Me.txt_IVA.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentaViewModelBindingSource, "Iva", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.txt_IVA.Enabled = False
        Me.txt_IVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_IVA.Location = New System.Drawing.Point(629, 4)
        Me.txt_IVA.Name = "txt_IVA"
        Me.txt_IVA.ReadOnly = True
        Me.txt_IVA.Size = New System.Drawing.Size(96, 22)
        Me.txt_IVA.TabIndex = 7
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
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Total"
        '
        'txt_Total
        '
        Me.txt_Total.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Total.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentaViewModelBindingSource, "Total", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.txt_Total.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.VentaViewModelBindingSource, "NoEstaPaga", True))
        Me.txt_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Total.Location = New System.Drawing.Point(811, 4)
        Me.txt_Total.Name = "txt_Total"
        Me.txt_Total.Size = New System.Drawing.Size(98, 22)
        Me.txt_Total.TabIndex = 9
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
        Me.TableLayoutPanel8.Controls.Add(Me.Cb_Trajeta, 3, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.Cb_NroCuota, 5, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.Label9, 2, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.Label11, 4, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.btnAgregaPago, 7, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.btnRecargarPago, 8, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.txtCuotaCFT, 6, 0)
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
        Me.Cb_FormaPago.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.VentaViewModelBindingSource, "FormaPagoSeleccionado", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Cb_FormaPago.DataSource = Me.FormaPagoBindingSource
        Me.Cb_FormaPago.DisplayMember = "Value"
        Me.Cb_FormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_FormaPago.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Cb_FormaPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_FormaPago.FormattingEnabled = True
        Me.Cb_FormaPago.Location = New System.Drawing.Point(73, 7)
        Me.Cb_FormaPago.Name = "Cb_FormaPago"
        Me.Cb_FormaPago.Size = New System.Drawing.Size(164, 23)
        Me.Cb_FormaPago.TabIndex = 0
        Me.Cb_FormaPago.ValueMember = "Key"
        '
        'FormaPagoBindingSource
        '
        Me.FormaPagoBindingSource.DataMember = "FormaPago"
        Me.FormaPagoBindingSource.DataSource = Me.VentaViewModelBindingSource
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
        'Cb_Trajeta
        '
        Me.Cb_Trajeta.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cb_Trajeta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cb_Trajeta.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.VentaViewModelBindingSource, "TarjetaSeleccionada", True))
        Me.Cb_Trajeta.DataSource = Me.TarjetaBindingSource
        Me.Cb_Trajeta.DisplayMember = "Value"
        Me.Cb_Trajeta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Trajeta.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Cb_Trajeta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_Trajeta.FormattingEnabled = True
        Me.Cb_Trajeta.Location = New System.Drawing.Point(313, 7)
        Me.Cb_Trajeta.Name = "Cb_Trajeta"
        Me.Cb_Trajeta.Size = New System.Drawing.Size(164, 23)
        Me.Cb_Trajeta.TabIndex = 1
        Me.Cb_Trajeta.ValueMember = "Key"
        '
        'TarjetaBindingSource
        '
        Me.TarjetaBindingSource.DataMember = "Tarjeta"
        Me.TarjetaBindingSource.DataSource = Me.VentaViewModelBindingSource
        '
        'Cb_NroCuota
        '
        Me.Cb_NroCuota.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cb_NroCuota.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cb_NroCuota.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.VentaViewModelBindingSource, "CuotaSeleccionado", True))
        Me.Cb_NroCuota.DataSource = Me.CuotaBindingSource
        Me.Cb_NroCuota.DisplayMember = "Value"
        Me.Cb_NroCuota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_NroCuota.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Cb_NroCuota.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_NroCuota.FormattingEnabled = True
        Me.Cb_NroCuota.Location = New System.Drawing.Point(553, 7)
        Me.Cb_NroCuota.Name = "Cb_NroCuota"
        Me.Cb_NroCuota.Size = New System.Drawing.Size(79, 23)
        Me.Cb_NroCuota.TabIndex = 2
        Me.Cb_NroCuota.ValueMember = "Key"
        '
        'CuotaBindingSource
        '
        Me.CuotaBindingSource.DataMember = "Cuota"
        Me.CuotaBindingSource.DataSource = Me.VentaViewModelBindingSource
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
        Me.Label9.Text = "Tarjeta"
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
        'txtCuotaCFT
        '
        Me.txtCuotaCFT.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCuotaCFT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtCuotaCFT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCuotaCFT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentaViewModelBindingSource, "CuotaCft", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "P"))
        Me.txtCuotaCFT.Enabled = False
        Me.txtCuotaCFT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuotaCFT.Location = New System.Drawing.Point(638, 7)
        Me.txtCuotaCFT.Name = "txtCuotaCFT"
        Me.txtCuotaCFT.ReadOnly = True
        Me.txtCuotaCFT.Size = New System.Drawing.Size(64, 22)
        Me.txtCuotaCFT.TabIndex = 3
        Me.txtCuotaCFT.Text = "0,00"
        Me.txtCuotaCFT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DG_Productos
        '
        Me.DG_Productos.AllowUserToAddRows = False
        Me.DG_Productos.AllowUserToDeleteRows = False
        Me.DG_Productos.AutoGenerateColumns = False
        Me.DG_Productos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DG_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Productos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Seleccionado, Me.CodigoDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.ProductosCantidad, Me.ProductosMonto, Me.IvaDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn, Me.ProductosPorcentajeBonificacion, Me.PorcentajePagoDataGridViewTextBoxColumn, Me.ProductosQuitar})
        Me.DG_Productos.DataSource = Me.VentaItemBindingSource
        Me.DG_Productos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_Productos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DG_Productos.Location = New System.Drawing.Point(3, 3)
        Me.DG_Productos.Name = "DG_Productos"
        Me.DG_Productos.RowHeadersVisible = False
        Me.DG_Productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Productos.Size = New System.Drawing.Size(924, 186)
        Me.DG_Productos.TabIndex = 0
        '
        'Seleccionado
        '
        Me.Seleccionado.DataPropertyName = "Seleccionado"
        Me.Seleccionado.HeaderText = ""
        Me.Seleccionado.Name = "Seleccionado"
        Me.Seleccionado.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Seleccionado.Width = 30
        '
        'CodigoDataGridViewTextBoxColumn
        '
        Me.CodigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.HeaderText = "Código"
        Me.CodigoDataGridViewTextBoxColumn.Name = "CodigoDataGridViewTextBoxColumn"
        Me.CodigoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductosCantidad
        '
        Me.ProductosCantidad.DataPropertyName = "Cantidad"
        Me.ProductosCantidad.HeaderText = "Cantidad"
        Me.ProductosCantidad.Name = "ProductosCantidad"
        Me.ProductosCantidad.Width = 75
        '
        'ProductosMonto
        '
        Me.ProductosMonto.DataPropertyName = "Monto"
        DataGridViewCellStyle13.Format = "C"
        Me.ProductosMonto.DefaultCellStyle = DataGridViewCellStyle13
        Me.ProductosMonto.HeaderText = "Monto"
        Me.ProductosMonto.Name = "ProductosMonto"
        '
        'IvaDataGridViewTextBoxColumn
        '
        Me.IvaDataGridViewTextBoxColumn.DataPropertyName = "Iva"
        DataGridViewCellStyle14.Format = "C"
        Me.IvaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle14
        Me.IvaDataGridViewTextBoxColumn.HeaderText = "Iva"
        Me.IvaDataGridViewTextBoxColumn.Name = "IvaDataGridViewTextBoxColumn"
        Me.IvaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "Total"
        DataGridViewCellStyle15.Format = "C"
        Me.TotalDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle15
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        Me.TotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductosPorcentajeBonificacion
        '
        Me.ProductosPorcentajeBonificacion.DataPropertyName = "PorcentajeBonificacion"
        DataGridViewCellStyle16.Format = "P"
        Me.ProductosPorcentajeBonificacion.DefaultCellStyle = DataGridViewCellStyle16
        Me.ProductosPorcentajeBonificacion.HeaderText = "% Bonif."
        Me.ProductosPorcentajeBonificacion.Name = "ProductosPorcentajeBonificacion"
        Me.ProductosPorcentajeBonificacion.Width = 75
        '
        'PorcentajePagoDataGridViewTextBoxColumn
        '
        Me.PorcentajePagoDataGridViewTextBoxColumn.DataPropertyName = "PorcentajePago"
        DataGridViewCellStyle17.Format = "P"
        Me.PorcentajePagoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle17
        Me.PorcentajePagoDataGridViewTextBoxColumn.HeaderText = "% Pago"
        Me.PorcentajePagoDataGridViewTextBoxColumn.Name = "PorcentajePagoDataGridViewTextBoxColumn"
        Me.PorcentajePagoDataGridViewTextBoxColumn.ReadOnly = True
        Me.PorcentajePagoDataGridViewTextBoxColumn.Width = 75
        '
        'ProductosQuitar
        '
        Me.ProductosQuitar.HeaderText = ""
        Me.ProductosQuitar.Image = Global.SistemaCinderella.My.Resources.Recursos.Boton_Eliminar
        Me.ProductosQuitar.Name = "ProductosQuitar"
        Me.ProductosQuitar.Width = 30
        '
        'VentaItemBindingSource
        '
        Me.VentaItemBindingSource.DataMember = "VentaItems"
        Me.VentaItemBindingSource.DataSource = Me.VentaViewModelBindingSource
        '
        'DG_ProductosTotales
        '
        Me.DG_ProductosTotales.AllowUserToAddRows = False
        Me.DG_ProductosTotales.AllowUserToDeleteRows = False
        Me.DG_ProductosTotales.AutoGenerateColumns = False
        Me.DG_ProductosTotales.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DG_ProductosTotales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_ProductosTotales.ColumnHeadersVisible = False
        Me.DG_ProductosTotales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TotalSeleccionado, Me.CodigoDataGridViewTextBoxColumn1, Me.NombreDataGridViewTextBoxColumn1, Me.CantidadDataGridViewTextBoxColumn1, Me.MontoDataGridViewTextBoxColumn2, Me.IvaDataGridViewTextBoxColumn2, Me.TotalDataGridViewTextBoxColumn2, Me.Column1, Me.PorcentajePagoDataGridViewTextBoxColumn1, Me.Column2})
        Me.DG_ProductosTotales.DataSource = Me.TotalVentaItemBindingSource
        Me.DG_ProductosTotales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_ProductosTotales.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DG_ProductosTotales.Enabled = False
        Me.DG_ProductosTotales.Location = New System.Drawing.Point(3, 195)
        Me.DG_ProductosTotales.Name = "DG_ProductosTotales"
        Me.DG_ProductosTotales.ReadOnly = True
        Me.DG_ProductosTotales.RowHeadersVisible = False
        Me.DG_ProductosTotales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_ProductosTotales.Size = New System.Drawing.Size(924, 24)
        Me.DG_ProductosTotales.TabIndex = 1
        '
        'TotalSeleccionado
        '
        Me.TotalSeleccionado.HeaderText = "TotalSeleccionado"
        Me.TotalSeleccionado.Name = "TotalSeleccionado"
        Me.TotalSeleccionado.ReadOnly = True
        Me.TotalSeleccionado.Width = 30
        '
        'CodigoDataGridViewTextBoxColumn1
        '
        Me.CodigoDataGridViewTextBoxColumn1.HeaderText = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn1.Name = "CodigoDataGridViewTextBoxColumn1"
        Me.CodigoDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn1
        '
        Me.NombreDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NombreDataGridViewTextBoxColumn1.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn1.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn1.Name = "NombreDataGridViewTextBoxColumn1"
        Me.NombreDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'CantidadDataGridViewTextBoxColumn1
        '
        Me.CantidadDataGridViewTextBoxColumn1.DataPropertyName = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn1.HeaderText = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn1.Name = "CantidadDataGridViewTextBoxColumn1"
        Me.CantidadDataGridViewTextBoxColumn1.ReadOnly = True
        Me.CantidadDataGridViewTextBoxColumn1.Width = 75
        '
        'MontoDataGridViewTextBoxColumn2
        '
        Me.MontoDataGridViewTextBoxColumn2.DataPropertyName = "Monto"
        DataGridViewCellStyle18.Format = "C"
        Me.MontoDataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle18
        Me.MontoDataGridViewTextBoxColumn2.HeaderText = "Monto"
        Me.MontoDataGridViewTextBoxColumn2.Name = "MontoDataGridViewTextBoxColumn2"
        Me.MontoDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'IvaDataGridViewTextBoxColumn2
        '
        Me.IvaDataGridViewTextBoxColumn2.DataPropertyName = "Iva"
        DataGridViewCellStyle19.Format = "C"
        Me.IvaDataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle19
        Me.IvaDataGridViewTextBoxColumn2.HeaderText = "Iva"
        Me.IvaDataGridViewTextBoxColumn2.Name = "IvaDataGridViewTextBoxColumn2"
        Me.IvaDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'TotalDataGridViewTextBoxColumn2
        '
        Me.TotalDataGridViewTextBoxColumn2.DataPropertyName = "Total"
        DataGridViewCellStyle20.Format = "C"
        Me.TotalDataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle20
        Me.TotalDataGridViewTextBoxColumn2.HeaderText = "Total"
        Me.TotalDataGridViewTextBoxColumn2.Name = "TotalDataGridViewTextBoxColumn2"
        Me.TotalDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "% Bonif."
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 75
        '
        'PorcentajePagoDataGridViewTextBoxColumn1
        '
        DataGridViewCellStyle21.Format = "P"
        Me.PorcentajePagoDataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle21
        Me.PorcentajePagoDataGridViewTextBoxColumn1.HeaderText = "% Pago"
        Me.PorcentajePagoDataGridViewTextBoxColumn1.Name = "PorcentajePagoDataGridViewTextBoxColumn1"
        Me.PorcentajePagoDataGridViewTextBoxColumn1.ReadOnly = True
        Me.PorcentajePagoDataGridViewTextBoxColumn1.Width = 75
        '
        'Column2
        '
        Me.Column2.HeaderText = ""
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 30
        '
        'TotalVentaItemBindingSource
        '
        Me.TotalVentaItemBindingSource.DataMember = "TotalVentaItem"
        Me.TotalVentaItemBindingSource.DataSource = Me.VentaViewModelBindingSource
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 219)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(930, 222)
        Me.TableLayoutPanel1.TabIndex = 34
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel9)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(755, 144)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(187, 69)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "LISTA PRECIO"
        '
        'TableLayoutPanel9
        '
        Me.TableLayoutPanel9.ColumnCount = 2
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel9.Controls.Add(Me.Cb_ListaPrecio, 0, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel9.Location = New System.Drawing.Point(3, 17)
        Me.TableLayoutPanel9.Name = "TableLayoutPanel9"
        Me.TableLayoutPanel9.RowCount = 1
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel9.Size = New System.Drawing.Size(181, 49)
        Me.TableLayoutPanel9.TabIndex = 0
        '
        'Cb_ListaPrecio
        '
        Me.Cb_ListaPrecio.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cb_ListaPrecio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cb_ListaPrecio.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.VentaViewModelBindingSource, "ListaPrecioSeleccionado", True))
        Me.Cb_ListaPrecio.DataSource = Me.ListaPrecioBindingSource
        Me.Cb_ListaPrecio.DisplayMember = "Nombre"
        Me.Cb_ListaPrecio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_ListaPrecio.Enabled = False
        Me.Cb_ListaPrecio.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Cb_ListaPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_ListaPrecio.FormattingEnabled = True
        Me.Cb_ListaPrecio.Location = New System.Drawing.Point(53, 13)
        Me.Cb_ListaPrecio.Name = "Cb_ListaPrecio"
        Me.Cb_ListaPrecio.Size = New System.Drawing.Size(125, 23)
        Me.Cb_ListaPrecio.TabIndex = 0
        Me.Cb_ListaPrecio.ValueMember = "Id"
        '
        'ListaPrecioBindingSource
        '
        Me.ListaPrecioBindingSource.DataMember = "ListaPrecio"
        Me.ListaPrecioBindingSource.DataSource = Me.VentaViewModelBindingSource
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 15)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Lista"
        '
        'frmVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(954, 737)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.BtnReserva)
        Me.Controls.Add(Me.Gb_Producto)
        Me.Controls.Add(Me.Btn_NotaPedido)
        Me.Controls.Add(Me.GB_Pagos)
        Me.Controls.Add(Me.Gb_Vendedor)
        Me.Controls.Add(Me.Gb_ClienteMayorista)
        Me.Controls.Add(Me.Btn_Cancelar)
        Me.Controls.Add(Me.Btn_Finalizar)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Ventas"
        CType(Me.VentaViewModelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gb_Producto.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.Gb_ClienteMayorista.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        CType(Me.txt_PorcentajeBonificacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_PorcentajeFacturacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gb_Vendedor.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.VendedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EncargadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_Pagos.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.dgPagosTotales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalPagoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgPagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel7.PerformLayout()
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel8.PerformLayout()
        CType(Me.FormaPagoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TarjetaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuotaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_Productos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentaItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_ProductosTotales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalVentaItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel9.ResumeLayout(False)
        Me.TableLayoutPanel9.PerformLayout()
        CType(Me.ListaPrecioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_CodigoBarra As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Finalizar As System.Windows.Forms.Button
    Friend WithEvents Btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents Btn_Agregar As System.Windows.Forms.Button
    Friend WithEvents lbl_CodigoBarra As System.Windows.Forms.Label
    Friend WithEvents Gb_Producto As System.Windows.Forms.GroupBox
    Friend WithEvents Gb_ClienteMayorista As System.Windows.Forms.GroupBox
    Friend WithEvents Gb_Vendedor As System.Windows.Forms.GroupBox
    Friend WithEvents Cb_Vendedores As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Btn_BuscarCliente As System.Windows.Forms.Button
    Friend WithEvents txt_RazonSocial As System.Windows.Forms.TextBox
    Friend WithEvents txt_id_Cliente As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Cb_TipoCliente As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToolProd As System.Windows.Forms.ToolTip
    Friend WithEvents Btn_Cambiar As System.Windows.Forms.Button
    Friend WithEvents Cb_Encargados As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GB_Pagos As GroupBox
    Friend WithEvents BtnReserva As Button
    Friend WithEvents Btn_NotaPedido As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Label24 As Label
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents Label33 As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents DG_Productos As CustomDataGrid
    Friend WithEvents dgPagos As CustomDataGrid
    Friend WithEvents PagoMonto As DataGridViewTextBoxColumn
    Friend WithEvents PagoDescuentoRecargo As DataGridViewTextBoxColumn
    Friend WithEvents PagoTotal As DataGridViewTextBoxColumn
    Friend WithEvents DG_ProductosTotales As CustomDataGrid
    Friend WithEvents dgPagosTotales As CustomDataGrid
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
    Friend WithEvents Cb_ListaPrecio As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents MontoPagoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents txt_Subtotal As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txt_Descuento As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_CFT As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txt_IVA As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_Total As TextBox
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents Cb_FormaPago As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Cb_Trajeta As ComboBox
    Friend WithEvents Cb_NroCuota As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btnAgregaPago As Button
    Friend WithEvents btnRecargarPago As Button
    Friend WithEvents txtCuotaCFT As TextBox
    Friend WithEvents VendedoresBindingSource As BindingSource
    Friend WithEvents VentaViewModelBindingSource As BindingSource
    Friend WithEvents EncargadosBindingSource As BindingSource
    Friend WithEvents TipoClienteBindingSource As BindingSource
    Friend WithEvents FormaPagoBindingSource As BindingSource
    Friend WithEvents TarjetaBindingSource As BindingSource
    Friend WithEvents CuotaBindingSource As BindingSource
    Friend WithEvents ListaPrecioBindingSource As BindingSource
    Friend WithEvents PagosBindingSource As BindingSource
    Friend WithEvents VentaItemBindingSource As BindingSource
    Friend WithEvents TotalVentaItemBindingSource As BindingSource
    Friend WithEvents TotalPagoBindingSource As BindingSource
    Friend WithEvents txt_PorcentajeBonificacion As Controles.PercentUpDown
    Friend WithEvents txt_PorcentajeFacturacion As Controles.PercentUpDown
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents MontoDataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DescuentoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CFTDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents IVADataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents MontoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DescuentoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CFTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IVADataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Resto As DataGridViewTextBoxColumn
    Friend WithEvents PagoQuitar As DataGridViewImageColumn
    Friend WithEvents PagoCorregir As DataGridViewImageColumn
    Friend WithEvents Facturar As DataGridViewCheckBoxHeaderColumn
    Friend WithEvents Seleccionado As DataGridViewCheckBoxHeaderColumn
    Friend WithEvents CodigoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductosCantidad As DataGridViewTextBoxColumn
    Friend WithEvents ProductosMonto As DataGridViewTextBoxColumn
    Friend WithEvents IvaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductosPorcentajeBonificacion As DataGridViewTextBoxColumn
    Friend WithEvents PorcentajePagoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductosQuitar As DataGridViewImageColumn
    Friend WithEvents TotalSeleccionado As DataGridViewTextBoxColumn
    Friend WithEvents CodigoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents MontoDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents IvaDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents PorcentajePagoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Btn_Buscar As Button
End Class
