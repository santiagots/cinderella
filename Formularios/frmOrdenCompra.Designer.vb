<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrdenCompra
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrdenCompra))
        Me.tabOrdenCompra = New System.Windows.Forms.TabControl()
        Me.TabBusqueda = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lbl_Msg = New System.Windows.Forms.Label()
        Me.dgOrdenCompraBusqueda = New System.Windows.Forms.DataGridView()
        Me.NombreProveedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreEncargadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Eliminar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.BuscarOrdenCompraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btn_Restablecer = New System.Windows.Forms.Button()
        Me.BtnFiltrar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.dpHastaBusqueda = New System.Windows.Forms.DateTimePicker()
        Me.dpDesdeBusqueda = New System.Windows.Forms.DateTimePicker()
        Me.cbEstadoBusqueda = New System.Windows.Forms.ComboBox()
        Me.lblSucursalBusqueda = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cbProveedorBuscar = New System.Windows.Forms.ComboBox()
        Me.cbEncargadoBusqueda = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cbTipoBusqueda = New System.Windows.Forms.ComboBox()
        Me.TabAlta = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnEnviarAlta = New System.Windows.Forms.Button()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnCargaAutomaticaAlta = New System.Windows.Forms.Button()
        Me.BtnAgregarAlta = New System.Windows.Forms.Button()
        Me.lbl_CodigoBarra = New System.Windows.Forms.Label()
        Me.txtProductoAlta = New System.Windows.Forms.TextBox()
        Me.lblMontoTotalAlta = New System.Windows.Forms.Label()
        Me.dgMercaderiaAlta = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EliminarAlta = New System.Windows.Forms.DataGridViewImageColumn()
        Me.AdvertenciaAlta = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Verificado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.AltaDetallesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AltaOrdenCompraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnGuardarAlta = New System.Windows.Forms.Button()
        Me.lblTotalesAlta = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbProveedorAlta = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cbEncargadoAlta = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TabDetalle = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgMercaderiaDetalle = New System.Windows.Forms.DataGridView()
        Me.CodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EliminarDetalle = New System.Windows.Forms.DataGridViewImageColumn()
        Me.AdvertenciaDetalle = New System.Windows.Forms.DataGridViewImageColumn()
        Me.VerificadoDetalle = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ModificacionDetallesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ModificacionOrdenCompraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnRecibirModificacion = New System.Windows.Forms.Button()
        Me.btnEnviarModificacion = New System.Windows.Forms.Button()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnAgregarModificacion = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtProductoModificacion = New System.Windows.Forms.TextBox()
        Me.lblMontoTotalDetalle = New System.Windows.Forms.Label()
        Me.lbl_Monto = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.lblTotalesDetalle = New System.Windows.Forms.Label()
        Me.lbl_Totlaes = New System.Windows.Forms.Label()
        Me.Gb_Informacion = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lbl_Sucursal = New System.Windows.Forms.Label()
        Me.lbl_Proveedor = New System.Windows.Forms.Label()
        Me.lbl_Fecha = New System.Windows.Forms.Label()
        Me.FechaIngreso = New System.Windows.Forms.DateTimePicker()
        Me.txtSucursal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEncargado = New System.Windows.Forms.Label()
        Me.txtProveedor = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.DetallesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tabOrdenCompra.SuspendLayout()
        Me.TabBusqueda.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dgOrdenCompraBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuscarOrdenCompraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TabAlta.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        CType(Me.dgMercaderiaAlta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AltaDetallesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AltaOrdenCompraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TabDetalle.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgMercaderiaDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModificacionDetallesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModificacionOrdenCompraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.Gb_Informacion.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.DetallesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabOrdenCompra
        '
        Me.tabOrdenCompra.Controls.Add(Me.TabBusqueda)
        Me.tabOrdenCompra.Controls.Add(Me.TabAlta)
        Me.tabOrdenCompra.Controls.Add(Me.TabDetalle)
        Me.tabOrdenCompra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabOrdenCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tabOrdenCompra.Location = New System.Drawing.Point(0, 0)
        Me.tabOrdenCompra.Name = "tabOrdenCompra"
        Me.tabOrdenCompra.SelectedIndex = 0
        Me.tabOrdenCompra.Size = New System.Drawing.Size(794, 672)
        Me.tabOrdenCompra.TabIndex = 0
        '
        'TabBusqueda
        '
        Me.TabBusqueda.Controls.Add(Me.GroupBox5)
        Me.TabBusqueda.Controls.Add(Me.GroupBox4)
        Me.TabBusqueda.Location = New System.Drawing.Point(4, 29)
        Me.TabBusqueda.Name = "TabBusqueda"
        Me.TabBusqueda.Padding = New System.Windows.Forms.Padding(3)
        Me.TabBusqueda.Size = New System.Drawing.Size(786, 639)
        Me.TabBusqueda.TabIndex = 0
        Me.TabBusqueda.Text = "Ordenes de Compra"
        Me.TabBusqueda.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.lbl_Msg)
        Me.GroupBox5.Controls.Add(Me.dgOrdenCompraBusqueda)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.GroupBox5.Location = New System.Drawing.Point(8, 181)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(769, 450)
        Me.GroupBox5.TabIndex = 29
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Ordenes de Compra"
        '
        'lbl_Msg
        '
        Me.lbl_Msg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Msg.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_Msg.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Msg.Location = New System.Drawing.Point(121, 218)
        Me.lbl_Msg.Name = "lbl_Msg"
        Me.lbl_Msg.Size = New System.Drawing.Size(527, 29)
        Me.lbl_Msg.TabIndex = 5
        Me.lbl_Msg.Text = "No se han encontrado Ordenes de Compra."
        Me.lbl_Msg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgOrdenCompraBusqueda
        '
        Me.dgOrdenCompraBusqueda.AllowUserToAddRows = False
        Me.dgOrdenCompraBusqueda.AllowUserToDeleteRows = False
        Me.dgOrdenCompraBusqueda.AllowUserToResizeColumns = False
        Me.dgOrdenCompraBusqueda.AllowUserToResizeRows = False
        Me.dgOrdenCompraBusqueda.AutoGenerateColumns = False
        Me.dgOrdenCompraBusqueda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgOrdenCompraBusqueda.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgOrdenCompraBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgOrdenCompraBusqueda.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NombreProveedorDataGridViewTextBoxColumn, Me.NombreEncargadoDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn, Me.TipoDataGridViewTextBoxColumn, Me.Eliminar})
        Me.dgOrdenCompraBusqueda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgOrdenCompraBusqueda.DataSource = Me.BuscarOrdenCompraBindingSource
        Me.dgOrdenCompraBusqueda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgOrdenCompraBusqueda.Location = New System.Drawing.Point(3, 17)
        Me.dgOrdenCompraBusqueda.MultiSelect = False
        Me.dgOrdenCompraBusqueda.Name = "dgOrdenCompraBusqueda"
        Me.dgOrdenCompraBusqueda.ReadOnly = True
        Me.dgOrdenCompraBusqueda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgOrdenCompraBusqueda.Size = New System.Drawing.Size(763, 430)
        Me.dgOrdenCompraBusqueda.TabIndex = 0
        '
        'NombreProveedorDataGridViewTextBoxColumn
        '
        Me.NombreProveedorDataGridViewTextBoxColumn.DataPropertyName = "NombreProveedor"
        Me.NombreProveedorDataGridViewTextBoxColumn.HeaderText = "Proveedor"
        Me.NombreProveedorDataGridViewTextBoxColumn.Name = "NombreProveedorDataGridViewTextBoxColumn"
        Me.NombreProveedorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreEncargadoDataGridViewTextBoxColumn
        '
        Me.NombreEncargadoDataGridViewTextBoxColumn.DataPropertyName = "NombreEncargado"
        Me.NombreEncargadoDataGridViewTextBoxColumn.HeaderText = "Encargado"
        Me.NombreEncargadoDataGridViewTextBoxColumn.Name = "NombreEncargadoDataGridViewTextBoxColumn"
        Me.NombreEncargadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        Me.EstadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TipoDataGridViewTextBoxColumn
        '
        Me.TipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.HeaderText = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.Name = "TipoDataGridViewTextBoxColumn"
        Me.TipoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Image = Global.SistemaCinderella.My.Resources.Recursos.Boton_Eliminar
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'BuscarOrdenCompraBindingSource
        '
        Me.BuscarOrdenCompraBindingSource.DataSource = GetType(Entidades.OrdenCompra)
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.btn_Restablecer)
        Me.GroupBox4.Controls.Add(Me.BtnFiltrar)
        Me.GroupBox4.Controls.Add(Me.TableLayoutPanel5)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(771, 169)
        Me.GroupBox4.TabIndex = 27
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Buscar"
        '
        'btn_Restablecer
        '
        Me.btn_Restablecer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Restablecer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Restablecer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Restablecer.Location = New System.Drawing.Point(571, 123)
        Me.btn_Restablecer.Name = "btn_Restablecer"
        Me.btn_Restablecer.Size = New System.Drawing.Size(94, 41)
        Me.btn_Restablecer.TabIndex = 21
        Me.btn_Restablecer.Text = "Restablecer Busqueda"
        Me.btn_Restablecer.UseVisualStyleBackColor = True
        '
        'BtnFiltrar
        '
        Me.BtnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFiltrar.FlatAppearance.BorderSize = 0
        Me.BtnFiltrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFiltrar.Image = Global.SistemaCinderella.My.Resources.Recursos.IconoBuscar32
        Me.BtnFiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnFiltrar.Location = New System.Drawing.Point(671, 123)
        Me.BtnFiltrar.Name = "BtnFiltrar"
        Me.BtnFiltrar.Size = New System.Drawing.Size(94, 41)
        Me.BtnFiltrar.TabIndex = 20
        Me.BtnFiltrar.Text = "Buscar"
        Me.BtnFiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnFiltrar.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel5.ColumnCount = 5
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.44445!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.44445!))
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel6, 1, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.cbEstadoBusqueda, 1, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.lblSucursalBusqueda, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.Label8, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.Label9, 3, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.Label11, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.Label14, 3, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.cbProveedorBuscar, 4, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.cbEncargadoBusqueda, 4, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.Label13, 0, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.Label15, 3, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.cbTipoBusqueda, 4, 2)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(6, 18)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 3
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(759, 99)
        Me.TableLayoutPanel5.TabIndex = 19
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 2
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.dpHastaBusqueda, 1, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.dpDesdeBusqueda, 0, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(103, 33)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(242, 29)
        Me.TableLayoutPanel6.TabIndex = 22
        '
        'dpHastaBusqueda
        '
        Me.dpHastaBusqueda.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dpHastaBusqueda.CustomFormat = "yyyy/MM/dd"
        Me.dpHastaBusqueda.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dpHastaBusqueda.Location = New System.Drawing.Point(124, 4)
        Me.dpHastaBusqueda.MinDate = New Date(2011, 1, 1, 0, 0, 0, 0)
        Me.dpHastaBusqueda.Name = "dpHastaBusqueda"
        Me.dpHastaBusqueda.Size = New System.Drawing.Size(115, 21)
        Me.dpHastaBusqueda.TabIndex = 4
        '
        'dpDesdeBusqueda
        '
        Me.dpDesdeBusqueda.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dpDesdeBusqueda.CustomFormat = "yyyy/MM/dd"
        Me.dpDesdeBusqueda.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dpDesdeBusqueda.Location = New System.Drawing.Point(3, 4)
        Me.dpDesdeBusqueda.MinDate = New Date(2011, 1, 1, 0, 0, 0, 0)
        Me.dpDesdeBusqueda.Name = "dpDesdeBusqueda"
        Me.dpDesdeBusqueda.Size = New System.Drawing.Size(115, 21)
        Me.dpDesdeBusqueda.TabIndex = 3
        '
        'cbEstadoBusqueda
        '
        Me.cbEstadoBusqueda.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbEstadoBusqueda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbEstadoBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstadoBusqueda.FormattingEnabled = True
        Me.cbEstadoBusqueda.Location = New System.Drawing.Point(103, 71)
        Me.cbEstadoBusqueda.Name = "cbEstadoBusqueda"
        Me.cbEstadoBusqueda.Size = New System.Drawing.Size(242, 23)
        Me.cbEstadoBusqueda.TabIndex = 24
        '
        'lblSucursalBusqueda
        '
        Me.lblSucursalBusqueda.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblSucursalBusqueda.AutoSize = True
        Me.lblSucursalBusqueda.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuscarOrdenCompraBindingSource, "NombreSucursal", True))
        Me.lblSucursalBusqueda.Location = New System.Drawing.Point(103, 7)
        Me.lblSucursalBusqueda.Name = "lblSucursalBusqueda"
        Me.lblSucursalBusqueda.Size = New System.Drawing.Size(23, 15)
        Me.lblSucursalBusqueda.TabIndex = 29
        Me.lblSucursalBusqueda.Text = "----"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 7)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 15)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Sucursal"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(413, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 15)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Proveedor"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(3, 40)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 15)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Fecha"
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(413, 7)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(76, 15)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "Encargado"
        '
        'cbProveedorBuscar
        '
        Me.cbProveedorBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbProveedorBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbProveedorBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProveedorBuscar.FormattingEnabled = True
        Me.cbProveedorBuscar.Location = New System.Drawing.Point(513, 37)
        Me.cbProveedorBuscar.Name = "cbProveedorBuscar"
        Me.cbProveedorBuscar.Size = New System.Drawing.Size(243, 23)
        Me.cbProveedorBuscar.TabIndex = 23
        '
        'cbEncargadoBusqueda
        '
        Me.cbEncargadoBusqueda.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbEncargadoBusqueda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbEncargadoBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEncargadoBusqueda.FormattingEnabled = True
        Me.cbEncargadoBusqueda.Location = New System.Drawing.Point(513, 4)
        Me.cbEncargadoBusqueda.Name = "cbEncargadoBusqueda"
        Me.cbEncargadoBusqueda.Size = New System.Drawing.Size(243, 23)
        Me.cbEncargadoBusqueda.TabIndex = 24
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(3, 74)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 15)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Estado"
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(413, 74)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(35, 15)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "Tipo"
        '
        'cbTipoBusqueda
        '
        Me.cbTipoBusqueda.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbTipoBusqueda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbTipoBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoBusqueda.FormattingEnabled = True
        Me.cbTipoBusqueda.Location = New System.Drawing.Point(513, 71)
        Me.cbTipoBusqueda.Name = "cbTipoBusqueda"
        Me.cbTipoBusqueda.Size = New System.Drawing.Size(243, 23)
        Me.cbTipoBusqueda.TabIndex = 32
        '
        'TabAlta
        '
        Me.TabAlta.Controls.Add(Me.GroupBox3)
        Me.TabAlta.Controls.Add(Me.GroupBox2)
        Me.TabAlta.Location = New System.Drawing.Point(4, 29)
        Me.TabAlta.Name = "TabAlta"
        Me.TabAlta.Size = New System.Drawing.Size(786, 639)
        Me.TabAlta.TabIndex = 2
        Me.TabAlta.Text = "Alta"
        Me.TabAlta.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.btnEnviarAlta)
        Me.GroupBox3.Controls.Add(Me.TableLayoutPanel4)
        Me.GroupBox3.Controls.Add(Me.lblMontoTotalAlta)
        Me.GroupBox3.Controls.Add(Me.dgMercaderiaAlta)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.btnGuardarAlta)
        Me.GroupBox3.Controls.Add(Me.lblTotalesAlta)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(6, 137)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(773, 494)
        Me.GroupBox3.TabIndex = 28
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Productos"
        '
        'btnEnviarAlta
        '
        Me.btnEnviarAlta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEnviarAlta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEnviarAlta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviarAlta.Image = Global.SistemaCinderella.My.Resources.Recursos.Mensaje
        Me.btnEnviarAlta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEnviarAlta.Location = New System.Drawing.Point(567, 448)
        Me.btnEnviarAlta.Name = "btnEnviarAlta"
        Me.btnEnviarAlta.Size = New System.Drawing.Size(95, 40)
        Me.btnEnviarAlta.TabIndex = 34
        Me.btnEnviarAlta.Text = "Enviar"
        Me.btnEnviarAlta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEnviarAlta.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel4.ColumnCount = 3
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel7, 2, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.lbl_CodigoBarra, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.txtProductoAlta, 1, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(6, 2)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(761, 58)
        Me.TableLayoutPanel4.TabIndex = 31
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 2
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.93306!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.06694!))
        Me.TableLayoutPanel7.Controls.Add(Me.BtnCargaAutomaticaAlta, 1, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.BtnAgregarAlta, 0, 0)
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(524, 3)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(234, 52)
        Me.TableLayoutPanel7.TabIndex = 36
        '
        'BtnCargaAutomaticaAlta
        '
        Me.BtnCargaAutomaticaAlta.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BtnCargaAutomaticaAlta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCargaAutomaticaAlta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCargaAutomaticaAlta.Image = Global.SistemaCinderella.My.Resources.Recursos.ProductosMasivos_32
        Me.BtnCargaAutomaticaAlta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCargaAutomaticaAlta.Location = New System.Drawing.Point(110, 5)
        Me.BtnCargaAutomaticaAlta.Name = "BtnCargaAutomaticaAlta"
        Me.BtnCargaAutomaticaAlta.Size = New System.Drawing.Size(121, 42)
        Me.BtnCargaAutomaticaAlta.TabIndex = 35
        Me.BtnCargaAutomaticaAlta.Text = "Carga Automática"
        Me.BtnCargaAutomaticaAlta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCargaAutomaticaAlta.UseVisualStyleBackColor = True
        '
        'BtnAgregarAlta
        '
        Me.BtnAgregarAlta.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BtnAgregarAlta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAgregarAlta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregarAlta.Image = Global.SistemaCinderella.My.Resources.Recursos.Productos_32
        Me.BtnAgregarAlta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAgregarAlta.Location = New System.Drawing.Point(3, 5)
        Me.BtnAgregarAlta.Name = "BtnAgregarAlta"
        Me.BtnAgregarAlta.Size = New System.Drawing.Size(96, 42)
        Me.BtnAgregarAlta.TabIndex = 8
        Me.BtnAgregarAlta.Text = "Agregar"
        Me.BtnAgregarAlta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAgregarAlta.UseVisualStyleBackColor = True
        '
        'lbl_CodigoBarra
        '
        Me.lbl_CodigoBarra.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_CodigoBarra.AutoSize = True
        Me.lbl_CodigoBarra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CodigoBarra.Location = New System.Drawing.Point(3, 21)
        Me.lbl_CodigoBarra.Name = "lbl_CodigoBarra"
        Me.lbl_CodigoBarra.Size = New System.Drawing.Size(194, 15)
        Me.lbl_CodigoBarra.TabIndex = 7
        Me.lbl_CodigoBarra.Text = "Nombre / Código de Producto"
        '
        'txtProductoAlta
        '
        Me.txtProductoAlta.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtProductoAlta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtProductoAlta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtProductoAlta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductoAlta.Location = New System.Drawing.Point(203, 18)
        Me.txtProductoAlta.Name = "txtProductoAlta"
        Me.txtProductoAlta.Size = New System.Drawing.Size(315, 21)
        Me.txtProductoAlta.TabIndex = 7
        '
        'lblMontoTotalAlta
        '
        Me.lblMontoTotalAlta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblMontoTotalAlta.AutoSize = True
        Me.lblMontoTotalAlta.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontoTotalAlta.Location = New System.Drawing.Point(366, 455)
        Me.lblMontoTotalAlta.Name = "lblMontoTotalAlta"
        Me.lblMontoTotalAlta.Size = New System.Drawing.Size(28, 18)
        Me.lblMontoTotalAlta.TabIndex = 18
        Me.lblMontoTotalAlta.Text = "$ 0"
        '
        'dgMercaderiaAlta
        '
        Me.dgMercaderiaAlta.AllowUserToAddRows = False
        Me.dgMercaderiaAlta.AllowUserToDeleteRows = False
        Me.dgMercaderiaAlta.AllowUserToResizeRows = False
        Me.dgMercaderiaAlta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgMercaderiaAlta.AutoGenerateColumns = False
        Me.dgMercaderiaAlta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgMercaderiaAlta.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgMercaderiaAlta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgMercaderiaAlta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMercaderiaAlta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.EliminarAlta, Me.AdvertenciaAlta, Me.Verificado})
        Me.dgMercaderiaAlta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgMercaderiaAlta.DataSource = Me.AltaDetallesBindingSource
        Me.dgMercaderiaAlta.Location = New System.Drawing.Point(6, 63)
        Me.dgMercaderiaAlta.Name = "dgMercaderiaAlta"
        Me.dgMercaderiaAlta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgMercaderiaAlta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMercaderiaAlta.Size = New System.Drawing.Size(762, 379)
        Me.dgMercaderiaAlta.TabIndex = 15
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Codigo"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Código"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Costo"
        DataGridViewCellStyle1.Format = "C2"
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn3.HeaderText = "Costo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Cantidad"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Importe"
        DataGridViewCellStyle2.Format = "C2"
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn5.HeaderText = "Importe"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'EliminarAlta
        '
        Me.EliminarAlta.HeaderText = "Eliminar"
        Me.EliminarAlta.Image = Global.SistemaCinderella.My.Resources.Recursos.Boton_Eliminar
        Me.EliminarAlta.Name = "EliminarAlta"
        '
        'AdvertenciaAlta
        '
        Me.AdvertenciaAlta.HeaderText = "Advertencia"
        Me.AdvertenciaAlta.Image = Global.SistemaCinderella.My.Resources.Recursos.warning_24
        Me.AdvertenciaAlta.Name = "AdvertenciaAlta"
        '
        'Verificado
        '
        Me.Verificado.DataPropertyName = "Verificado"
        Me.Verificado.HeaderText = "Verificado"
        Me.Verificado.Name = "Verificado"
        Me.Verificado.Visible = False
        '
        'AltaDetallesBindingSource
        '
        Me.AltaDetallesBindingSource.DataMember = "Detalles"
        Me.AltaDetallesBindingSource.DataSource = Me.AltaOrdenCompraBindingSource
        '
        'AltaOrdenCompraBindingSource
        '
        Me.AltaOrdenCompraBindingSource.DataSource = GetType(Entidades.OrdenCompra)
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(239, 455)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 18)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Monto Total:"
        '
        'btnGuardarAlta
        '
        Me.btnGuardarAlta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardarAlta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardarAlta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarAlta.Image = Global.SistemaCinderella.My.Resources.Recursos.Conectado_32
        Me.btnGuardarAlta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardarAlta.Location = New System.Drawing.Point(668, 448)
        Me.btnGuardarAlta.Name = "btnGuardarAlta"
        Me.btnGuardarAlta.Size = New System.Drawing.Size(100, 40)
        Me.btnGuardarAlta.TabIndex = 14
        Me.btnGuardarAlta.Text = "Guardar"
        Me.btnGuardarAlta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardarAlta.UseVisualStyleBackColor = True
        '
        'lblTotalesAlta
        '
        Me.lblTotalesAlta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTotalesAlta.AutoSize = True
        Me.lblTotalesAlta.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalesAlta.Location = New System.Drawing.Point(181, 455)
        Me.lblTotalesAlta.Name = "lblTotalesAlta"
        Me.lblTotalesAlta.Size = New System.Drawing.Size(16, 18)
        Me.lblTotalesAlta.TabIndex = 16
        Me.lblTotalesAlta.Text = "0"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(3, 455)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(157, 18)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Total de Productos:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(771, 127)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Información general."
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.44444!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.44444!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label17, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.DateTimePicker1, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cbProveedorAlta, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label16, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label19, 4, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.cbEncargadoAlta, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label18, 1, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(6, 18)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(759, 90)
        Me.TableLayoutPanel1.TabIndex = 19
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(3, 67)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(51, 15)
        Me.Label17.TabIndex = 29
        Me.Label17.Text = "Estado"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Sucursal"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(413, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 15)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Proveedor"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 15)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Fecha"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimePicker1.CustomFormat = ""
        Me.DateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AltaOrdenCompraBindingSource, "Fecha", True))
        Me.DateTimePicker1.Location = New System.Drawing.Point(103, 34)
        Me.DateTimePicker1.MinDate = New Date(2011, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(242, 21)
        Me.DateTimePicker1.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AltaOrdenCompraBindingSource, "NombreSucursal", True))
        Me.Label5.Location = New System.Drawing.Point(103, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 15)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "----"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(413, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 15)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Encargado"
        '
        'cbProveedorAlta
        '
        Me.cbProveedorAlta.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbProveedorAlta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbProveedorAlta.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.AltaOrdenCompraBindingSource, "idProveedor", True))
        Me.cbProveedorAlta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AltaOrdenCompraBindingSource, "NombreProveedor", True))
        Me.cbProveedorAlta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProveedorAlta.FormattingEnabled = True
        Me.cbProveedorAlta.Location = New System.Drawing.Point(513, 34)
        Me.cbProveedorAlta.Name = "cbProveedorAlta"
        Me.cbProveedorAlta.Size = New System.Drawing.Size(243, 23)
        Me.cbProveedorAlta.TabIndex = 23
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(413, 67)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(35, 15)
        Me.Label16.TabIndex = 28
        Me.Label16.Text = "Tipo"
        '
        'Label19
        '
        Me.Label19.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label19.AutoSize = True
        Me.Label19.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AltaOrdenCompraBindingSource, "Tipo", True))
        Me.Label19.Location = New System.Drawing.Point(513, 67)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(23, 15)
        Me.Label19.TabIndex = 31
        Me.Label19.Text = "----"
        '
        'cbEncargadoAlta
        '
        Me.cbEncargadoAlta.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbEncargadoAlta.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.AltaOrdenCompraBindingSource, "idEncargado", True))
        Me.cbEncargadoAlta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AltaOrdenCompraBindingSource, "NombreProveedor", True))
        Me.cbEncargadoAlta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEncargadoAlta.FormattingEnabled = True
        Me.cbEncargadoAlta.Location = New System.Drawing.Point(513, 4)
        Me.cbEncargadoAlta.Name = "cbEncargadoAlta"
        Me.cbEncargadoAlta.Size = New System.Drawing.Size(243, 23)
        Me.cbEncargadoAlta.TabIndex = 32
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label18.AutoSize = True
        Me.Label18.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AltaOrdenCompraBindingSource, "Estado", True))
        Me.Label18.Location = New System.Drawing.Point(103, 67)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(23, 15)
        Me.Label18.TabIndex = 30
        Me.Label18.Text = "----"
        '
        'TabDetalle
        '
        Me.TabDetalle.Controls.Add(Me.GroupBox1)
        Me.TabDetalle.Controls.Add(Me.Gb_Informacion)
        Me.TabDetalle.Location = New System.Drawing.Point(4, 29)
        Me.TabDetalle.Name = "TabDetalle"
        Me.TabDetalle.Padding = New System.Windows.Forms.Padding(3)
        Me.TabDetalle.Size = New System.Drawing.Size(786, 639)
        Me.TabDetalle.TabIndex = 1
        Me.TabDetalle.Text = "Detalle"
        Me.TabDetalle.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.dgMercaderiaDetalle)
        Me.GroupBox1.Controls.Add(Me.btnRecibirModificacion)
        Me.GroupBox1.Controls.Add(Me.btnEnviarModificacion)
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel3)
        Me.GroupBox1.Controls.Add(Me.lblMontoTotalDetalle)
        Me.GroupBox1.Controls.Add(Me.lbl_Monto)
        Me.GroupBox1.Controls.Add(Me.btnModificar)
        Me.GroupBox1.Controls.Add(Me.lblTotalesDetalle)
        Me.GroupBox1.Controls.Add(Me.lbl_Totlaes)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(4, 131)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(773, 500)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Productos"
        '
        'dgMercaderiaDetalle
        '
        Me.dgMercaderiaDetalle.AllowUserToAddRows = False
        Me.dgMercaderiaDetalle.AllowUserToDeleteRows = False
        Me.dgMercaderiaDetalle.AllowUserToResizeColumns = False
        Me.dgMercaderiaDetalle.AllowUserToResizeRows = False
        Me.dgMercaderiaDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgMercaderiaDetalle.AutoGenerateColumns = False
        Me.dgMercaderiaDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgMercaderiaDetalle.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgMercaderiaDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMercaderiaDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.CostoDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn, Me.ImporteDataGridViewTextBoxColumn, Me.EliminarDetalle, Me.AdvertenciaDetalle, Me.VerificadoDetalle})
        Me.dgMercaderiaDetalle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgMercaderiaDetalle.DataSource = Me.ModificacionDetallesBindingSource
        Me.dgMercaderiaDetalle.Location = New System.Drawing.Point(6, 75)
        Me.dgMercaderiaDetalle.Name = "dgMercaderiaDetalle"
        Me.dgMercaderiaDetalle.Size = New System.Drawing.Size(762, 373)
        Me.dgMercaderiaDetalle.TabIndex = 35
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
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CostoDataGridViewTextBoxColumn
        '
        Me.CostoDataGridViewTextBoxColumn.DataPropertyName = "Costo"
        DataGridViewCellStyle3.Format = "C2"
        Me.CostoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.CostoDataGridViewTextBoxColumn.HeaderText = "Costo"
        Me.CostoDataGridViewTextBoxColumn.Name = "CostoDataGridViewTextBoxColumn"
        Me.CostoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        '
        'ImporteDataGridViewTextBoxColumn
        '
        Me.ImporteDataGridViewTextBoxColumn.DataPropertyName = "Importe"
        DataGridViewCellStyle4.Format = "C2"
        Me.ImporteDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.ImporteDataGridViewTextBoxColumn.HeaderText = "Importe"
        Me.ImporteDataGridViewTextBoxColumn.Name = "ImporteDataGridViewTextBoxColumn"
        Me.ImporteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EliminarDetalle
        '
        Me.EliminarDetalle.HeaderText = "Eliminar"
        Me.EliminarDetalle.Image = Global.SistemaCinderella.My.Resources.Recursos.Boton_Eliminar
        Me.EliminarDetalle.Name = "EliminarDetalle"
        '
        'AdvertenciaDetalle
        '
        Me.AdvertenciaDetalle.HeaderText = "Advertencia"
        Me.AdvertenciaDetalle.Image = Global.SistemaCinderella.My.Resources.Recursos.warning_24
        Me.AdvertenciaDetalle.Name = "AdvertenciaDetalle"
        '
        'VerificadoDetalle
        '
        Me.VerificadoDetalle.DataPropertyName = "Verificado"
        Me.VerificadoDetalle.HeaderText = "Verificado"
        Me.VerificadoDetalle.Name = "VerificadoDetalle"
        Me.VerificadoDetalle.Visible = False
        '
        'ModificacionDetallesBindingSource
        '
        Me.ModificacionDetallesBindingSource.DataMember = "Detalles"
        Me.ModificacionDetallesBindingSource.DataSource = Me.ModificacionOrdenCompraBindingSource
        '
        'ModificacionOrdenCompraBindingSource
        '
        Me.ModificacionOrdenCompraBindingSource.DataSource = GetType(Entidades.OrdenCompra)
        '
        'btnRecibirModificacion
        '
        Me.btnRecibirModificacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRecibirModificacion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRecibirModificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecibirModificacion.Image = Global.SistemaCinderella.My.Resources.Recursos.ProductosMasivos_32
        Me.btnRecibirModificacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRecibirModificacion.Location = New System.Drawing.Point(567, 454)
        Me.btnRecibirModificacion.Name = "btnRecibirModificacion"
        Me.btnRecibirModificacion.Size = New System.Drawing.Size(95, 40)
        Me.btnRecibirModificacion.TabIndex = 34
        Me.btnRecibirModificacion.Text = "Recibir"
        Me.btnRecibirModificacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRecibirModificacion.UseVisualStyleBackColor = True
        '
        'btnEnviarModificacion
        '
        Me.btnEnviarModificacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEnviarModificacion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEnviarModificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviarModificacion.Image = Global.SistemaCinderella.My.Resources.Recursos.Mensaje
        Me.btnEnviarModificacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEnviarModificacion.Location = New System.Drawing.Point(466, 454)
        Me.btnEnviarModificacion.Name = "btnEnviarModificacion"
        Me.btnEnviarModificacion.Size = New System.Drawing.Size(95, 40)
        Me.btnEnviarModificacion.TabIndex = 33
        Me.btnEnviarModificacion.Text = "Enviar"
        Me.btnEnviarModificacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEnviarModificacion.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.BtnAgregarModificacion, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label7, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.txtProductoModificacion, 1, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(6, 20)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(759, 49)
        Me.TableLayoutPanel3.TabIndex = 32
        '
        'BtnAgregarModificacion
        '
        Me.BtnAgregarModificacion.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BtnAgregarModificacion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAgregarModificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregarModificacion.Image = Global.SistemaCinderella.My.Resources.Recursos.Productos_32
        Me.BtnAgregarModificacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAgregarModificacion.Location = New System.Drawing.Point(656, 3)
        Me.BtnAgregarModificacion.Name = "BtnAgregarModificacion"
        Me.BtnAgregarModificacion.Size = New System.Drawing.Size(100, 42)
        Me.BtnAgregarModificacion.TabIndex = 8
        Me.BtnAgregarModificacion.Text = "Agregar"
        Me.BtnAgregarModificacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAgregarModificacion.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(194, 15)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Nombre / Código de Producto"
        '
        'txtProductoModificacion
        '
        Me.txtProductoModificacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtProductoModificacion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtProductoModificacion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtProductoModificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductoModificacion.Location = New System.Drawing.Point(203, 14)
        Me.txtProductoModificacion.Name = "txtProductoModificacion"
        Me.txtProductoModificacion.Size = New System.Drawing.Size(433, 21)
        Me.txtProductoModificacion.TabIndex = 7
        '
        'lblMontoTotalDetalle
        '
        Me.lblMontoTotalDetalle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblMontoTotalDetalle.AutoSize = True
        Me.lblMontoTotalDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontoTotalDetalle.Location = New System.Drawing.Point(366, 461)
        Me.lblMontoTotalDetalle.Name = "lblMontoTotalDetalle"
        Me.lblMontoTotalDetalle.Size = New System.Drawing.Size(28, 18)
        Me.lblMontoTotalDetalle.TabIndex = 18
        Me.lblMontoTotalDetalle.Text = "$ 0"
        '
        'lbl_Monto
        '
        Me.lbl_Monto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_Monto.AutoSize = True
        Me.lbl_Monto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Monto.Location = New System.Drawing.Point(239, 461)
        Me.lbl_Monto.Name = "lbl_Monto"
        Me.lbl_Monto.Size = New System.Drawing.Size(104, 18)
        Me.lbl_Monto.TabIndex = 17
        Me.lbl_Monto.Text = "Monto Total:"
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Image = Global.SistemaCinderella.My.Resources.Recursos.Editar_24
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.Location = New System.Drawing.Point(668, 454)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(100, 40)
        Me.btnModificar.TabIndex = 14
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'lblTotalesDetalle
        '
        Me.lblTotalesDetalle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTotalesDetalle.AutoSize = True
        Me.lblTotalesDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalesDetalle.Location = New System.Drawing.Point(181, 461)
        Me.lblTotalesDetalle.Name = "lblTotalesDetalle"
        Me.lblTotalesDetalle.Size = New System.Drawing.Size(16, 18)
        Me.lblTotalesDetalle.TabIndex = 16
        Me.lblTotalesDetalle.Text = "0"
        '
        'lbl_Totlaes
        '
        Me.lbl_Totlaes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_Totlaes.AutoSize = True
        Me.lbl_Totlaes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Totlaes.Location = New System.Drawing.Point(3, 461)
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
        Me.Gb_Informacion.Location = New System.Drawing.Point(6, 6)
        Me.Gb_Informacion.Name = "Gb_Informacion"
        Me.Gb_Informacion.Size = New System.Drawing.Size(771, 119)
        Me.Gb_Informacion.TabIndex = 25
        Me.Gb_Informacion.TabStop = False
        Me.Gb_Informacion.Text = "Información general."
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 5
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.44444!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.44444!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label23, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label21, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_Sucursal, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_Proveedor, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_Fecha, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.FechaIngreso, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtSucursal, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtEncargado, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtProveedor, 4, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label22, 3, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label24, 4, 2)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(6, 18)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(759, 90)
        Me.TableLayoutPanel2.TabIndex = 19
        '
        'Label23
        '
        Me.Label23.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label23.AutoSize = True
        Me.Label23.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ModificacionOrdenCompraBindingSource, "Estado", True))
        Me.Label23.Location = New System.Drawing.Point(103, 67)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(23, 15)
        Me.Label23.TabIndex = 26
        Me.Label23.Text = "----"
        '
        'Label21
        '
        Me.Label21.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(3, 67)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(51, 15)
        Me.Label21.TabIndex = 24
        Me.Label21.Text = "Estado"
        '
        'lbl_Sucursal
        '
        Me.lbl_Sucursal.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl_Sucursal.AutoSize = True
        Me.lbl_Sucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Sucursal.Location = New System.Drawing.Point(3, 7)
        Me.lbl_Sucursal.Name = "lbl_Sucursal"
        Me.lbl_Sucursal.Size = New System.Drawing.Size(63, 15)
        Me.lbl_Sucursal.TabIndex = 5
        Me.lbl_Sucursal.Text = "Sucursal"
        '
        'lbl_Proveedor
        '
        Me.lbl_Proveedor.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl_Proveedor.AutoSize = True
        Me.lbl_Proveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Proveedor.Location = New System.Drawing.Point(413, 37)
        Me.lbl_Proveedor.Name = "lbl_Proveedor"
        Me.lbl_Proveedor.Size = New System.Drawing.Size(72, 15)
        Me.lbl_Proveedor.TabIndex = 15
        Me.lbl_Proveedor.Text = "Proveedor"
        '
        'lbl_Fecha
        '
        Me.lbl_Fecha.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl_Fecha.AutoSize = True
        Me.lbl_Fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Fecha.Location = New System.Drawing.Point(3, 37)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(46, 15)
        Me.lbl_Fecha.TabIndex = 20
        Me.lbl_Fecha.Text = "Fecha"
        '
        'FechaIngreso
        '
        Me.FechaIngreso.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FechaIngreso.CustomFormat = ""
        Me.FechaIngreso.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ModificacionOrdenCompraBindingSource, "Fecha", True))
        Me.FechaIngreso.Enabled = False
        Me.FechaIngreso.Location = New System.Drawing.Point(103, 34)
        Me.FechaIngreso.MinDate = New Date(2011, 1, 1, 0, 0, 0, 0)
        Me.FechaIngreso.Name = "FechaIngreso"
        Me.FechaIngreso.Size = New System.Drawing.Size(242, 21)
        Me.FechaIngreso.TabIndex = 3
        '
        'txtSucursal
        '
        Me.txtSucursal.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtSucursal.AutoSize = True
        Me.txtSucursal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ModificacionOrdenCompraBindingSource, "NombreSucursal", True))
        Me.txtSucursal.Location = New System.Drawing.Point(103, 7)
        Me.txtSucursal.Name = "txtSucursal"
        Me.txtSucursal.Size = New System.Drawing.Size(23, 15)
        Me.txtSucursal.TabIndex = 1
        Me.txtSucursal.Text = "----"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(413, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 15)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Encargado"
        '
        'txtEncargado
        '
        Me.txtEncargado.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtEncargado.AutoSize = True
        Me.txtEncargado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ModificacionOrdenCompraBindingSource, "NombreEncargado", True))
        Me.txtEncargado.Location = New System.Drawing.Point(513, 7)
        Me.txtEncargado.Name = "txtEncargado"
        Me.txtEncargado.Size = New System.Drawing.Size(23, 15)
        Me.txtEncargado.TabIndex = 22
        Me.txtEncargado.Text = "----"
        '
        'txtProveedor
        '
        Me.txtProveedor.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtProveedor.AutoSize = True
        Me.txtProveedor.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ModificacionOrdenCompraBindingSource, "NombreProveedor", True))
        Me.txtProveedor.Location = New System.Drawing.Point(513, 37)
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.Size = New System.Drawing.Size(23, 15)
        Me.txtProveedor.TabIndex = 23
        Me.txtProveedor.Text = "----"
        '
        'Label22
        '
        Me.Label22.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(413, 67)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(35, 15)
        Me.Label22.TabIndex = 25
        Me.Label22.Text = "Tipo"
        '
        'Label24
        '
        Me.Label24.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label24.AutoSize = True
        Me.Label24.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ModificacionOrdenCompraBindingSource, "Tipo", True))
        Me.Label24.Location = New System.Drawing.Point(513, 67)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(23, 15)
        Me.Label24.TabIndex = 27
        Me.Label24.Text = "----"
        '
        'DetallesBindingSource
        '
        Me.DetallesBindingSource.DataMember = "Detalles"
        Me.DetallesBindingSource.DataSource = Me.ModificacionOrdenCompraBindingSource
        '
        'frmOrdenCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 672)
        Me.Controls.Add(Me.tabOrdenCompra)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmOrdenCompra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administración de ordenes de compra"
        Me.tabOrdenCompra.ResumeLayout(False)
        Me.TabBusqueda.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.dgOrdenCompraBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuscarOrdenCompraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TabAlta.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel7.ResumeLayout(False)
        CType(Me.dgMercaderiaAlta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AltaDetallesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AltaOrdenCompraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TabDetalle.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgMercaderiaDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModificacionDetallesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModificacionOrdenCompraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.Gb_Informacion.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.DetallesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabOrdenCompra As TabControl
    Friend WithEvents TabBusqueda As TabPage
    Friend WithEvents TabDetalle As TabPage
    Friend WithEvents Gb_Informacion As GroupBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents lbl_Sucursal As Label
    Friend WithEvents txtSucursal As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtEncargado As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblMontoTotalDetalle As Label
    Friend WithEvents lbl_Monto As Label
    Friend WithEvents btnModificar As Button
    Friend WithEvents lblTotalesDetalle As Label
    Friend WithEvents lbl_Totlaes As Label
    Friend WithEvents ModificacionOrdenCompraBindingSource As BindingSource
    Friend WithEvents ModificacionDetallesBindingSource As BindingSource
    Friend WithEvents TabAlta As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblMontoTotalAlta As Label
    Friend WithEvents dgMercaderiaAlta As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents btnGuardarAlta As Button
    Friend WithEvents lblTotalesAlta As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents AltaOrdenCompraBindingSource As BindingSource
    Friend WithEvents AltaDetallesBindingSource As BindingSource
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents BtnAgregarAlta As Button
    Friend WithEvents lbl_CodigoBarra As Label
    Friend WithEvents txtProductoAlta As TextBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents BtnAgregarModificacion As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtProductoModificacion As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents dpDesdeBusqueda As DateTimePicker
    Friend WithEvents Label14 As Label
    Friend WithEvents cbProveedorBuscar As ComboBox
    Friend WithEvents cbEncargadoBusqueda As ComboBox
    Friend WithEvents BuscarOrdenCompraBindingSource As BindingSource
    Friend WithEvents btn_Restablecer As Button
    Friend WithEvents BtnFiltrar As Button
    Friend WithEvents btnEnviarModificacion As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents cbProveedorAlta As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents lblSucursalBusqueda As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents lbl_Proveedor As Label
    Friend WithEvents lbl_Fecha As Label
    Friend WithEvents FechaIngreso As DateTimePicker
    Friend WithEvents txtProveedor As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents btnRecibirModificacion As Button
    Friend WithEvents cbEstadoBusqueda As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents cbTipoBusqueda As ComboBox
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents dpHastaBusqueda As DateTimePicker
    Friend WithEvents dgOrdenCompraBusqueda As DataGridView
    Friend WithEvents cbEncargadoAlta As ComboBox
    Friend WithEvents DetallesBindingSource As BindingSource
    Friend WithEvents NombreProveedorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreEncargadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Eliminar As DataGridViewImageColumn
    Friend WithEvents btnEnviarAlta As Button
    Friend WithEvents dgMercaderiaDetalle As DataGridView
    Friend WithEvents lbl_Msg As Label
    Friend WithEvents BtnCargaAutomaticaAlta As Button
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents EliminarAlta As DataGridViewImageColumn
    Friend WithEvents AdvertenciaAlta As DataGridViewImageColumn
    Friend WithEvents Verificado As DataGridViewCheckBoxColumn
    Friend WithEvents CodigoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CostoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImporteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EliminarDetalle As DataGridViewImageColumn
    Friend WithEvents AdvertenciaDetalle As DataGridViewImageColumn
    Friend WithEvents VerificadoDetalle As DataGridViewCheckBoxColumn
End Class
