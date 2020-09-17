<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmClienteMayorista

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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClienteMayorista))
        Me.tabControl = New System.Windows.Forms.TabControl()
        Me.TbListado = New System.Windows.Forms.TabPage()
        Me.Paginado = New SistemaCinderella.Paginado()
        Me.FrmClienteMayoristaViewModelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.lbl_Msg = New System.Windows.Forms.Label()
        Me.DG_Clientes = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RazonSocialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NotaPedidoMontoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuentaCorrienteMontoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Modificar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Eliminar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.AltaClienteFiltroClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label49 = New System.Windows.Forms.Label()
        Me.txt_TotalSaldoCuentaCorriente = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel16 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.txt_Direccion_Buscar = New System.Windows.Forms.TextBox()
        Me.ModificacionClienteMayoristaDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txt_Telefono_Buscar = New System.Windows.Forms.TextBox()
        Me.cmb_ListaPrecio_Buscar = New System.Windows.Forms.ComboBox()
        Me.ModificacionClienteListasPreciosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmb_CondicionIVA_Buscar = New System.Windows.Forms.ComboBox()
        Me.ModificacionClienteCondicionesIVABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmb_Corredor_Buscar = New System.Windows.Forms.ComboBox()
        Me.CorredoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txt_Mail_Buscar = New System.Windows.Forms.TextBox()
        Me.PercentUpDown5 = New Controles.PercentUpDown()
        Me.PercentUpDown6 = New Controles.PercentUpDown()
        Me.PercentUpDown7 = New Controles.PercentUpDown()
        Me.GB_Buscar = New System.Windows.Forms.GroupBox()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.btn_Restablecer = New System.Windows.Forms.Button()
        Me.TableLayoutPanel15 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_Cuit_Filtro = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.lbl_descripcion_bus = New System.Windows.Forms.Label()
        Me.txt_RazonSocial_Filtro = New System.Windows.Forms.TextBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.cmb_Corredor_Filtro = New System.Windows.Forms.ComboBox()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.cmb_CondicionIVA_Filtro = New System.Windows.Forms.ComboBox()
        Me.FiltroCondicionesIVABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label54 = New System.Windows.Forms.Label()
        Me.cmb_ListaPrecios_Filtro = New System.Windows.Forms.ComboBox()
        Me.FiltroListasPreciosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.cmb_Empresa_Filtro = New System.Windows.Forms.ComboBox()
        Me.EmpresasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmb_Habilitado_Filtro = New System.Windows.Forms.ComboBox()
        Me.HabilitadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbAlta = New System.Windows.Forms.TabPage()
        Me.GB_Alta = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.cb_Localidad_Entrega = New System.Windows.Forms.ComboBox()
        Me.AltaClienteMayoristaDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AltaClienteEntregaLocalidadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txt_CodigoPostal_Entrega = New System.Windows.Forms.TextBox()
        Me.cb_Distrito_Entrega = New System.Windows.Forms.ComboBox()
        Me.AltaClienteEntregaDistritosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cb_Provincia_Entrega = New System.Windows.Forms.ComboBox()
        Me.AltaClienteEntregaProvinciasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txt_Direccion_Entrega = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_Mail_Facturacion = New System.Windows.Forms.TextBox()
        Me.txt_Telefono_Facturacion = New System.Windows.Forms.TextBox()
        Me.cb_Localidad_Facturacion = New System.Windows.Forms.ComboBox()
        Me.AltaClienteFacturacionLocalidadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txt_CodigoPostal_Facturacion = New System.Windows.Forms.TextBox()
        Me.cb_Distrito_Facturacion = New System.Windows.Forms.ComboBox()
        Me.AltaClienteFacturacionDistritosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cb_Provincia_Facturacion = New System.Windows.Forms.ComboBox()
        Me.AltaClienteFacturacionProvinciasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txt_Direccion_Facturacion = New System.Windows.Forms.TextBox()
        Me.lbl_Provincia = New System.Windows.Forms.Label()
        Me.lbl_Distrito = New System.Windows.Forms.Label()
        Me.lbl_Localidad = New System.Windows.Forms.Label()
        Me.lbl_CodigoPostal = New System.Windows.Forms.Label()
        Me.lbl_Telefono = New System.Windows.Forms.Label()
        Me.lbl_Mail = New System.Windows.Forms.Label()
        Me.lbl_Direccion = New System.Windows.Forms.Label()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txt_Observaciones = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.cmb_Empresa = New System.Windows.Forms.ComboBox()
        Me.lbl_ListaPrecio = New System.Windows.Forms.Label()
        Me.cb_ListaPrecios = New System.Windows.Forms.ComboBox()
        Me.AltaClienteListasPreciosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_Observaciones = New System.Windows.Forms.Label()
        Me.txt_CondicionPago = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_RazonSocial = New System.Windows.Forms.Label()
        Me.lbl_Cuit = New System.Windows.Forms.Label()
        Me.txt_RazonSocial = New System.Windows.Forms.TextBox()
        Me.lbl_Transporte = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txt_Cuit = New System.Windows.Forms.MaskedTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmb_Corredor = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txt_Nombre = New System.Windows.Forms.TextBox()
        Me.cb_CondicionIva = New System.Windows.Forms.ComboBox()
        Me.AltaClienteCondicionesIVABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txt_Transporte = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lbl_CondicionIva = New System.Windows.Forms.Label()
        Me.PercentUpDown2 = New Controles.PercentUpDown()
        Me.PercentUpDown3 = New Controles.PercentUpDown()
        Me.PercentUpDown4 = New Controles.PercentUpDown()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Btn_Agregar = New System.Windows.Forms.Button()
        Me.TbMod = New System.Windows.Forms.TabPage()
        Me.GB_Modificacion = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel18 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.chk_Habilitado_Mod = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel9 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cb_Localidad_Entrega_Mod = New System.Windows.Forms.ComboBox()
        Me.ModificacionClienteEntregaLocalidadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txt_CodigoPostal_Entrega_Mod = New System.Windows.Forms.TextBox()
        Me.cb_Distrito_Entrega_Mod = New System.Windows.Forms.ComboBox()
        Me.ModificacionClienteEntregaDistritosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cb_Provincia_Entrega_Mod = New System.Windows.Forms.ComboBox()
        Me.ModificacionClienteEntregaProvinciasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txt_Direccion_Entrega_Mod = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel10 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_Mail_Facturacion_Mod = New System.Windows.Forms.TextBox()
        Me.txt_Telefono_Facturacion_Mod = New System.Windows.Forms.TextBox()
        Me.cb_Localidad_Facturacion_Mod = New System.Windows.Forms.ComboBox()
        Me.ModificacionClienteFacturacionLocalidadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txt_CodigoPostal_Facturacion_Mod = New System.Windows.Forms.TextBox()
        Me.cb_Distrito_Facturacion_Mod = New System.Windows.Forms.ComboBox()
        Me.ModificacionClienteFacturacionDistritosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cb_Provincia_Facturacion_Mod = New System.Windows.Forms.ComboBox()
        Me.ModificacionClienteFacturacionProvinciasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txt_Direccion_Facturacion_Mod = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel11 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_Observaciones_Mod = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel12 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmb_Empresa_Mod = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cb_ListaPrecios_Mod = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel13 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_CondicionPago_Mod = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel14 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txt_RazonSocial_mod = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txt_Cuit_Mod = New System.Windows.Forms.MaskedTextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cmb_Corredor_Mod = New System.Windows.Forms.ComboBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txt_Nombre_Mod = New System.Windows.Forms.TextBox()
        Me.cb_CondicionIva_Mod = New System.Windows.Forms.ComboBox()
        Me.txt_Transporte_Mod = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.txt_Comision_Mod = New Controles.PercentUpDown()
        Me.txt_Lista_Mod = New Controles.PercentUpDown()
        Me.PercentUpDown1 = New Controles.PercentUpDown()
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.Btn_Modificar = New System.Windows.Forms.Button()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ToolCliente = New System.Windows.Forms.ToolTip(Me.components)
        Me.tabControl.SuspendLayout()
        Me.TbListado.SuspendLayout()
        CType(Me.FrmClienteMayoristaViewModelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        CType(Me.DG_Clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AltaClienteFiltroClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.TableLayoutPanel16.SuspendLayout()
        CType(Me.ModificacionClienteMayoristaDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModificacionClienteListasPreciosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModificacionClienteCondicionesIVABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CorredoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PercentUpDown5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PercentUpDown6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PercentUpDown7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_Buscar.SuspendLayout()
        Me.TableLayoutPanel15.SuspendLayout()
        CType(Me.FiltroCondicionesIVABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FiltroListasPreciosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HabilitadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TbAlta.SuspendLayout()
        Me.GB_Alta.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        CType(Me.AltaClienteMayoristaDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AltaClienteEntregaLocalidadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AltaClienteEntregaDistritosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AltaClienteEntregaProvinciasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.AltaClienteFacturacionLocalidadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AltaClienteFacturacionDistritosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AltaClienteFacturacionProvinciasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.AltaClienteListasPreciosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.AltaClienteCondicionesIVABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PercentUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PercentUpDown3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PercentUpDown4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TbMod.SuspendLayout()
        Me.GB_Modificacion.SuspendLayout()
        Me.TableLayoutPanel18.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TableLayoutPanel9.SuspendLayout()
        CType(Me.ModificacionClienteEntregaLocalidadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModificacionClienteEntregaDistritosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModificacionClienteEntregaProvinciasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.TableLayoutPanel10.SuspendLayout()
        CType(Me.ModificacionClienteFacturacionLocalidadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModificacionClienteFacturacionDistritosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModificacionClienteFacturacionProvinciasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel11.SuspendLayout()
        Me.TableLayoutPanel12.SuspendLayout()
        Me.TableLayoutPanel13.SuspendLayout()
        Me.TableLayoutPanel14.SuspendLayout()
        CType(Me.txt_Comision_Mod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Lista_Mod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PercentUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabControl
        '
        Me.tabControl.Controls.Add(Me.TbListado)
        Me.tabControl.Controls.Add(Me.TbAlta)
        Me.tabControl.Controls.Add(Me.TbMod)
        Me.tabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabControl.Location = New System.Drawing.Point(0, 0)
        Me.tabControl.Name = "tabControl"
        Me.tabControl.SelectedIndex = 0
        Me.tabControl.Size = New System.Drawing.Size(794, 754)
        Me.tabControl.TabIndex = 1
        '
        'TbListado
        '
        Me.TbListado.Controls.Add(Me.Paginado)
        Me.TbListado.Controls.Add(Me.GroupBox6)
        Me.TbListado.Controls.Add(Me.Label49)
        Me.TbListado.Controls.Add(Me.txt_TotalSaldoCuentaCorriente)
        Me.TbListado.Controls.Add(Me.GroupBox5)
        Me.TbListado.Controls.Add(Me.GB_Buscar)
        Me.TbListado.Location = New System.Drawing.Point(4, 29)
        Me.TbListado.Name = "TbListado"
        Me.TbListado.Padding = New System.Windows.Forms.Padding(3)
        Me.TbListado.Size = New System.Drawing.Size(786, 721)
        Me.TbListado.TabIndex = 0
        Me.TbListado.Text = "Clientes"
        Me.TbListado.UseVisualStyleBackColor = True
        '
        'Paginado
        '
        Me.Paginado.DataBindings.Add(New System.Windows.Forms.Binding("TotalElementos", Me.FrmClienteMayoristaViewModelBindingSource, "TotalElementos", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Paginado.Leyenda = "{0} de {1}"
        Me.Paginado.Location = New System.Drawing.Point(11, 472)
        Me.Paginado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 5)
        Me.Paginado.Name = "Paginado"
        Me.Paginado.PaginaActual = 1
        Me.Paginado.Size = New System.Drawing.Size(768, 23)
        Me.Paginado.TabIndex = 92
        Me.Paginado.TotalElementos = 0
        '
        'FrmClienteMayoristaViewModelBindingSource
        '
        Me.FrmClienteMayoristaViewModelBindingSource.DataSource = GetType(SistemaCinderella.Formularios.Cliente.frmClienteMayoristaViewModel)
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.lbl_Msg)
        Me.GroupBox6.Controls.Add(Me.DG_Clientes)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(6, 176)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(774, 293)
        Me.GroupBox6.TabIndex = 91
        Me.GroupBox6.TabStop = False
        '
        'lbl_Msg
        '
        Me.lbl_Msg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Msg.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lbl_Msg.DataBindings.Add(New System.Windows.Forms.Binding("Visible", Me.FrmClienteMayoristaViewModelBindingSource, "SinResultados", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.lbl_Msg.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Msg.Location = New System.Drawing.Point(200, 125)
        Me.lbl_Msg.Name = "lbl_Msg"
        Me.lbl_Msg.Size = New System.Drawing.Size(374, 58)
        Me.lbl_Msg.TabIndex = 90
        Me.lbl_Msg.Text = "No se han encontrado clientes."
        Me.lbl_Msg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DG_Clientes
        '
        Me.DG_Clientes.AllowUserToAddRows = False
        Me.DG_Clientes.AllowUserToDeleteRows = False
        Me.DG_Clientes.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DG_Clientes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DG_Clientes.AutoGenerateColumns = False
        Me.DG_Clientes.ColumnHeadersHeight = 30
        Me.DG_Clientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.RazonSocialDataGridViewTextBoxColumn, Me.CuitDataGridViewTextBoxColumn, Me.NotaPedidoMontoDataGridViewTextBoxColumn, Me.CuentaCorrienteMontoDataGridViewTextBoxColumn, Me.Modificar, Me.Eliminar})
        Me.DG_Clientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DG_Clientes.DataSource = Me.AltaClienteFiltroClientesBindingSource
        Me.DG_Clientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_Clientes.Location = New System.Drawing.Point(3, 17)
        Me.DG_Clientes.MultiSelect = False
        Me.DG_Clientes.Name = "DG_Clientes"
        Me.DG_Clientes.ReadOnly = True
        Me.DG_Clientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DG_Clientes.RowHeadersVisible = False
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DG_Clientes.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DG_Clientes.RowTemplate.Height = 30
        Me.DG_Clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Clientes.ShowCellErrors = False
        Me.DG_Clientes.ShowEditingIcon = False
        Me.DG_Clientes.ShowRowErrors = False
        Me.DG_Clientes.Size = New System.Drawing.Size(768, 273)
        Me.DG_Clientes.TabIndex = 0
        '
        'Id
        '
        Me.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Id.DataPropertyName = "Id"
        Me.Id.HeaderText = "Código"
        Me.Id.MinimumWidth = 80
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Width = 80
        '
        'RazonSocialDataGridViewTextBoxColumn
        '
        Me.RazonSocialDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.RazonSocialDataGridViewTextBoxColumn.DataPropertyName = "RazonSocial"
        Me.RazonSocialDataGridViewTextBoxColumn.HeaderText = "Razón Social"
        Me.RazonSocialDataGridViewTextBoxColumn.Name = "RazonSocialDataGridViewTextBoxColumn"
        Me.RazonSocialDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CuitDataGridViewTextBoxColumn
        '
        Me.CuitDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CuitDataGridViewTextBoxColumn.DataPropertyName = "Cuit"
        Me.CuitDataGridViewTextBoxColumn.HeaderText = "Cuit"
        Me.CuitDataGridViewTextBoxColumn.Name = "CuitDataGridViewTextBoxColumn"
        Me.CuitDataGridViewTextBoxColumn.ReadOnly = True
        Me.CuitDataGridViewTextBoxColumn.Width = 53
        '
        'NotaPedidoMontoDataGridViewTextBoxColumn
        '
        Me.NotaPedidoMontoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.NotaPedidoMontoDataGridViewTextBoxColumn.DataPropertyName = "NotaPedidoMonto"
        DataGridViewCellStyle2.Format = "C2"
        Me.NotaPedidoMontoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.NotaPedidoMontoDataGridViewTextBoxColumn.HeaderText = "N. Pedido"
        Me.NotaPedidoMontoDataGridViewTextBoxColumn.Name = "NotaPedidoMontoDataGridViewTextBoxColumn"
        Me.NotaPedidoMontoDataGridViewTextBoxColumn.ReadOnly = True
        Me.NotaPedidoMontoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.NotaPedidoMontoDataGridViewTextBoxColumn.Width = 67
        '
        'CuentaCorrienteMontoDataGridViewTextBoxColumn
        '
        Me.CuentaCorrienteMontoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CuentaCorrienteMontoDataGridViewTextBoxColumn.DataPropertyName = "CuentaCorrienteMonto"
        DataGridViewCellStyle3.Format = "C2"
        Me.CuentaCorrienteMontoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.CuentaCorrienteMontoDataGridViewTextBoxColumn.HeaderText = "Cta. Cte."
        Me.CuentaCorrienteMontoDataGridViewTextBoxColumn.Name = "CuentaCorrienteMontoDataGridViewTextBoxColumn"
        Me.CuentaCorrienteMontoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CuentaCorrienteMontoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CuentaCorrienteMontoDataGridViewTextBoxColumn.Width = 58
        '
        'Modificar
        '
        Me.Modificar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Modificar.HeaderText = ""
        Me.Modificar.Image = Global.SistemaCinderella.My.Resources.Recursos.Boton_Editar
        Me.Modificar.Name = "Modificar"
        Me.Modificar.ReadOnly = True
        Me.Modificar.Width = 5
        '
        'Eliminar
        '
        Me.Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Eliminar.HeaderText = ""
        Me.Eliminar.Image = Global.SistemaCinderella.My.Resources.Recursos.Boton_Eliminar
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.Width = 5
        '
        'AltaClienteFiltroClientesBindingSource
        '
        Me.AltaClienteFiltroClientesBindingSource.DataMember = "FiltroClientes"
        Me.AltaClienteFiltroClientesBindingSource.DataSource = Me.FrmClienteMayoristaViewModelBindingSource
        '
        'Label49
        '
        Me.Label49.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label49.AutoSize = True
        Me.Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.Location = New System.Drawing.Point(422, 506)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(69, 15)
        Me.Label49.TabIndex = 88
        Me.Label49.Text = "Total Saldo"
        '
        'txt_TotalSaldoCuentaCorriente
        '
        Me.txt_TotalSaldoCuentaCorriente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_TotalSaldoCuentaCorriente.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmClienteMayoristaViewModelBindingSource, "FiltroTotalSaldo", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.txt_TotalSaldoCuentaCorriente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TotalSaldoCuentaCorriente.Location = New System.Drawing.Point(558, 503)
        Me.txt_TotalSaldoCuentaCorriente.MaxLength = 255
        Me.txt_TotalSaldoCuentaCorriente.Name = "txt_TotalSaldoCuentaCorriente"
        Me.txt_TotalSaldoCuentaCorriente.ReadOnly = True
        Me.txt_TotalSaldoCuentaCorriente.Size = New System.Drawing.Size(211, 21)
        Me.txt_TotalSaldoCuentaCorriente.TabIndex = 89
        Me.txt_TotalSaldoCuentaCorriente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.TableLayoutPanel16)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(6, 530)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(772, 185)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Datos Cliente"
        '
        'TableLayoutPanel16
        '
        Me.TableLayoutPanel16.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel16.ColumnCount = 5
        Me.TableLayoutPanel16.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.TableLayoutPanel16.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel16.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel16.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.TableLayoutPanel16.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel16.Controls.Add(Me.Label48, 0, 4)
        Me.TableLayoutPanel16.Controls.Add(Me.Label41, 3, 0)
        Me.TableLayoutPanel16.Controls.Add(Me.Label42, 0, 1)
        Me.TableLayoutPanel16.Controls.Add(Me.Label43, 3, 1)
        Me.TableLayoutPanel16.Controls.Add(Me.Label44, 0, 2)
        Me.TableLayoutPanel16.Controls.Add(Me.Label40, 3, 2)
        Me.TableLayoutPanel16.Controls.Add(Me.Label45, 0, 0)
        Me.TableLayoutPanel16.Controls.Add(Me.Label46, 0, 3)
        Me.TableLayoutPanel16.Controls.Add(Me.Label47, 3, 4)
        Me.TableLayoutPanel16.Controls.Add(Me.txt_Direccion_Buscar, 1, 3)
        Me.TableLayoutPanel16.Controls.Add(Me.txt_Telefono_Buscar, 4, 4)
        Me.TableLayoutPanel16.Controls.Add(Me.cmb_ListaPrecio_Buscar, 1, 2)
        Me.TableLayoutPanel16.Controls.Add(Me.cmb_CondicionIVA_Buscar, 4, 2)
        Me.TableLayoutPanel16.Controls.Add(Me.cmb_Corredor_Buscar, 1, 0)
        Me.TableLayoutPanel16.Controls.Add(Me.txt_Mail_Buscar, 1, 4)
        Me.TableLayoutPanel16.Controls.Add(Me.PercentUpDown5, 1, 1)
        Me.TableLayoutPanel16.Controls.Add(Me.PercentUpDown6, 4, 0)
        Me.TableLayoutPanel16.Controls.Add(Me.PercentUpDown7, 4, 1)
        Me.TableLayoutPanel16.Location = New System.Drawing.Point(12, 20)
        Me.TableLayoutPanel16.Name = "TableLayoutPanel16"
        Me.TableLayoutPanel16.RowCount = 5
        Me.TableLayoutPanel16.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel16.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel16.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel16.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel16.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel16.Size = New System.Drawing.Size(754, 150)
        Me.TableLayoutPanel16.TabIndex = 0
        '
        'Label48
        '
        Me.Label48.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(3, 127)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(31, 15)
        Me.Label48.TabIndex = 85
        Me.Label48.Text = "Mail"
        '
        'Label41
        '
        Me.Label41.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(400, 7)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(73, 15)
        Me.Label41.TabIndex = 75
        Me.Label41.Text = "Comisión %"
        '
        'Label42
        '
        Me.Label42.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(3, 37)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(88, 15)
        Me.Label42.TabIndex = 78
        Me.Label42.Text = "Bonificación %"
        '
        'Label43
        '
        Me.Label43.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(400, 37)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(47, 15)
        Me.Label43.TabIndex = 80
        Me.Label43.Text = "Lista %"
        '
        'Label44
        '
        Me.Label44.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(3, 67)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(94, 15)
        Me.Label44.TabIndex = 81
        Me.Label44.Text = "Lista de Precios"
        '
        'Label40
        '
        Me.Label40.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(400, 67)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(99, 15)
        Me.Label40.TabIndex = 23
        Me.Label40.Text = "Condición de IVA"
        '
        'Label45
        '
        Me.Label45.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(3, 7)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(55, 15)
        Me.Label45.TabIndex = 82
        Me.Label45.Text = "Corredor"
        '
        'Label46
        '
        Me.Label46.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(3, 97)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(59, 15)
        Me.Label46.TabIndex = 83
        Me.Label46.Text = "Dirección"
        '
        'Label47
        '
        Me.Label47.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(400, 127)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(55, 15)
        Me.Label47.TabIndex = 84
        Me.Label47.Text = "Teléfono"
        '
        'txt_Direccion_Buscar
        '
        Me.txt_Direccion_Buscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Direccion_Buscar.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ModificacionClienteMayoristaDetalleBindingSource, "FacturacionDireccion", True))
        Me.txt_Direccion_Buscar.Location = New System.Drawing.Point(143, 94)
        Me.txt_Direccion_Buscar.MaxLength = 255
        Me.txt_Direccion_Buscar.Name = "txt_Direccion_Buscar"
        Me.txt_Direccion_Buscar.ReadOnly = True
        Me.txt_Direccion_Buscar.Size = New System.Drawing.Size(211, 21)
        Me.txt_Direccion_Buscar.TabIndex = 90
        '
        'ModificacionClienteMayoristaDetalleBindingSource
        '
        Me.ModificacionClienteMayoristaDetalleBindingSource.DataSource = GetType(SistemaCinderella.Formularios.Cliente.ClienteMayoristaDetalleViewModel)
        '
        'txt_Telefono_Buscar
        '
        Me.txt_Telefono_Buscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Telefono_Buscar.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ModificacionClienteMayoristaDetalleBindingSource, "FacturacionTelefono", True))
        Me.txt_Telefono_Buscar.Location = New System.Drawing.Point(540, 124)
        Me.txt_Telefono_Buscar.MaxLength = 255
        Me.txt_Telefono_Buscar.Name = "txt_Telefono_Buscar"
        Me.txt_Telefono_Buscar.ReadOnly = True
        Me.txt_Telefono_Buscar.Size = New System.Drawing.Size(211, 21)
        Me.txt_Telefono_Buscar.TabIndex = 92
        '
        'cmb_ListaPrecio_Buscar
        '
        Me.cmb_ListaPrecio_Buscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_ListaPrecio_Buscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmb_ListaPrecio_Buscar.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.ModificacionClienteMayoristaDetalleBindingSource, "ListaPreciosSaleccionada", True))
        Me.cmb_ListaPrecio_Buscar.DataSource = Me.ModificacionClienteListasPreciosBindingSource
        Me.cmb_ListaPrecio_Buscar.DisplayMember = "Value"
        Me.cmb_ListaPrecio_Buscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ListaPrecio_Buscar.Enabled = False
        Me.cmb_ListaPrecio_Buscar.FormattingEnabled = True
        Me.cmb_ListaPrecio_Buscar.Location = New System.Drawing.Point(143, 64)
        Me.cmb_ListaPrecio_Buscar.Name = "cmb_ListaPrecio_Buscar"
        Me.cmb_ListaPrecio_Buscar.Size = New System.Drawing.Size(211, 23)
        Me.cmb_ListaPrecio_Buscar.TabIndex = 93
        Me.cmb_ListaPrecio_Buscar.ValueMember = "Key"
        '
        'ModificacionClienteListasPreciosBindingSource
        '
        Me.ModificacionClienteListasPreciosBindingSource.DataMember = "ListasPrecios"
        Me.ModificacionClienteListasPreciosBindingSource.DataSource = Me.ModificacionClienteMayoristaDetalleBindingSource
        '
        'cmb_CondicionIVA_Buscar
        '
        Me.cmb_CondicionIVA_Buscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_CondicionIVA_Buscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmb_CondicionIVA_Buscar.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.ModificacionClienteMayoristaDetalleBindingSource, "CondicionesIVASaleccionada", True))
        Me.cmb_CondicionIVA_Buscar.DataSource = Me.ModificacionClienteCondicionesIVABindingSource
        Me.cmb_CondicionIVA_Buscar.DisplayMember = "Value"
        Me.cmb_CondicionIVA_Buscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_CondicionIVA_Buscar.Enabled = False
        Me.cmb_CondicionIVA_Buscar.FormattingEnabled = True
        Me.cmb_CondicionIVA_Buscar.Location = New System.Drawing.Point(540, 64)
        Me.cmb_CondicionIVA_Buscar.Name = "cmb_CondicionIVA_Buscar"
        Me.cmb_CondicionIVA_Buscar.Size = New System.Drawing.Size(211, 23)
        Me.cmb_CondicionIVA_Buscar.TabIndex = 94
        Me.cmb_CondicionIVA_Buscar.ValueMember = "Key"
        '
        'ModificacionClienteCondicionesIVABindingSource
        '
        Me.ModificacionClienteCondicionesIVABindingSource.DataMember = "CondicionesIVA"
        Me.ModificacionClienteCondicionesIVABindingSource.DataSource = Me.ModificacionClienteMayoristaDetalleBindingSource
        '
        'cmb_Corredor_Buscar
        '
        Me.cmb_Corredor_Buscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_Corredor_Buscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmb_Corredor_Buscar.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.ModificacionClienteMayoristaDetalleBindingSource, "CorredorSaleccionada", True))
        Me.cmb_Corredor_Buscar.DataSource = Me.CorredoresBindingSource
        Me.cmb_Corredor_Buscar.DisplayMember = "Value"
        Me.cmb_Corredor_Buscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Corredor_Buscar.Enabled = False
        Me.cmb_Corredor_Buscar.FormattingEnabled = True
        Me.cmb_Corredor_Buscar.Location = New System.Drawing.Point(143, 4)
        Me.cmb_Corredor_Buscar.Name = "cmb_Corredor_Buscar"
        Me.cmb_Corredor_Buscar.Size = New System.Drawing.Size(211, 23)
        Me.cmb_Corredor_Buscar.TabIndex = 95
        Me.cmb_Corredor_Buscar.ValueMember = "Key"
        '
        'CorredoresBindingSource
        '
        Me.CorredoresBindingSource.DataMember = "Corredores"
        Me.CorredoresBindingSource.DataSource = Me.FrmClienteMayoristaViewModelBindingSource
        '
        'txt_Mail_Buscar
        '
        Me.txt_Mail_Buscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Mail_Buscar.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ModificacionClienteMayoristaDetalleBindingSource, "FacturacionMail", True))
        Me.txt_Mail_Buscar.Location = New System.Drawing.Point(143, 124)
        Me.txt_Mail_Buscar.MaxLength = 255
        Me.txt_Mail_Buscar.Name = "txt_Mail_Buscar"
        Me.txt_Mail_Buscar.ReadOnly = True
        Me.txt_Mail_Buscar.Size = New System.Drawing.Size(211, 21)
        Me.txt_Mail_Buscar.TabIndex = 91
        '
        'PercentUpDown5
        '
        Me.PercentUpDown5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PercentUpDown5.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ModificacionClienteMayoristaDetalleBindingSource, "PorcentajeBonificacion", True))
        Me.PercentUpDown5.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.PercentUpDown5.Location = New System.Drawing.Point(143, 34)
        Me.PercentUpDown5.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.PercentUpDown5.Name = "PercentUpDown5"
        Me.PercentUpDown5.Size = New System.Drawing.Size(211, 21)
        Me.PercentUpDown5.TabIndex = 96
        Me.PercentUpDown5.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'PercentUpDown6
        '
        Me.PercentUpDown6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PercentUpDown6.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ModificacionClienteMayoristaDetalleBindingSource, "PorcentajeComision", True))
        Me.PercentUpDown6.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.PercentUpDown6.Location = New System.Drawing.Point(540, 4)
        Me.PercentUpDown6.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.PercentUpDown6.Name = "PercentUpDown6"
        Me.PercentUpDown6.Size = New System.Drawing.Size(211, 21)
        Me.PercentUpDown6.TabIndex = 97
        Me.PercentUpDown6.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'PercentUpDown7
        '
        Me.PercentUpDown7.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PercentUpDown7.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ModificacionClienteMayoristaDetalleBindingSource, "PorcentajeLista", True))
        Me.PercentUpDown7.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.PercentUpDown7.Location = New System.Drawing.Point(540, 34)
        Me.PercentUpDown7.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.PercentUpDown7.Name = "PercentUpDown7"
        Me.PercentUpDown7.Size = New System.Drawing.Size(211, 21)
        Me.PercentUpDown7.TabIndex = 98
        Me.PercentUpDown7.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'GB_Buscar
        '
        Me.GB_Buscar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_Buscar.Controls.Add(Me.btn_Buscar)
        Me.GB_Buscar.Controls.Add(Me.btn_Restablecer)
        Me.GB_Buscar.Controls.Add(Me.TableLayoutPanel15)
        Me.GB_Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Buscar.Location = New System.Drawing.Point(6, 6)
        Me.GB_Buscar.Name = "GB_Buscar"
        Me.GB_Buscar.Size = New System.Drawing.Size(774, 164)
        Me.GB_Buscar.TabIndex = 3
        Me.GB_Buscar.TabStop = False
        Me.GB_Buscar.Text = "Buscar Cliente"
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Buscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Buscar.Image = Global.SistemaCinderella.My.Resources.Recursos.IconoBuscar32
        Me.btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Buscar.Location = New System.Drawing.Point(668, 118)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(100, 40)
        Me.btn_Buscar.TabIndex = 6
        Me.btn_Buscar.Text = "Buscar"
        Me.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolCliente.SetToolTip(Me.btn_Buscar, "Haz click aquí para buscar clientes con los criterios de busqueda seleccionados.")
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'btn_Restablecer
        '
        Me.btn_Restablecer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Restablecer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Restablecer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Restablecer.Location = New System.Drawing.Point(562, 119)
        Me.btn_Restablecer.Name = "btn_Restablecer"
        Me.btn_Restablecer.Size = New System.Drawing.Size(100, 40)
        Me.btn_Restablecer.TabIndex = 8
        Me.btn_Restablecer.Text = "Restablecer Busqueda"
        Me.ToolCliente.SetToolTip(Me.btn_Restablecer, "haz click aquí para restablecer los filtros y el listado de clientes.")
        Me.btn_Restablecer.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel15
        '
        Me.TableLayoutPanel15.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel15.ColumnCount = 5
        Me.TableLayoutPanel15.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.TableLayoutPanel15.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel15.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel15.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.TableLayoutPanel15.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel15.Controls.Add(Me.txt_Cuit_Filtro, 1, 1)
        Me.TableLayoutPanel15.Controls.Add(Me.Label39, 0, 1)
        Me.TableLayoutPanel15.Controls.Add(Me.lbl_descripcion_bus, 0, 0)
        Me.TableLayoutPanel15.Controls.Add(Me.txt_RazonSocial_Filtro, 1, 0)
        Me.TableLayoutPanel15.Controls.Add(Me.Label52, 3, 0)
        Me.TableLayoutPanel15.Controls.Add(Me.cmb_Corredor_Filtro, 4, 0)
        Me.TableLayoutPanel15.Controls.Add(Me.Label53, 3, 1)
        Me.TableLayoutPanel15.Controls.Add(Me.cmb_CondicionIVA_Filtro, 4, 1)
        Me.TableLayoutPanel15.Controls.Add(Me.Label54, 3, 2)
        Me.TableLayoutPanel15.Controls.Add(Me.cmb_ListaPrecios_Filtro, 4, 2)
        Me.TableLayoutPanel15.Controls.Add(Me.Label50, 0, 3)
        Me.TableLayoutPanel15.Controls.Add(Me.Label55, 0, 2)
        Me.TableLayoutPanel15.Controls.Add(Me.cmb_Empresa_Filtro, 1, 2)
        Me.TableLayoutPanel15.Controls.Add(Me.cmb_Habilitado_Filtro, 1, 3)
        Me.TableLayoutPanel15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel15.Location = New System.Drawing.Point(6, 19)
        Me.TableLayoutPanel15.Name = "TableLayoutPanel15"
        Me.TableLayoutPanel15.RowCount = 4
        Me.TableLayoutPanel15.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel15.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel15.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel15.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel15.Size = New System.Drawing.Size(762, 124)
        Me.TableLayoutPanel15.TabIndex = 4
        '
        'txt_Cuit_Filtro
        '
        Me.txt_Cuit_Filtro.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Cuit_Filtro.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmClienteMayoristaViewModelBindingSource, "FiltroCuit", True))
        Me.txt_Cuit_Filtro.Location = New System.Drawing.Point(143, 34)
        Me.txt_Cuit_Filtro.Name = "txt_Cuit_Filtro"
        Me.txt_Cuit_Filtro.Size = New System.Drawing.Size(194, 21)
        Me.txt_Cuit_Filtro.TabIndex = 3
        '
        'Label39
        '
        Me.Label39.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(3, 37)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(134, 15)
        Me.Label39.TabIndex = 2
        Me.Label39.Text = "Cuit"
        '
        'lbl_descripcion_bus
        '
        Me.lbl_descripcion_bus.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_descripcion_bus.AutoSize = True
        Me.lbl_descripcion_bus.Location = New System.Drawing.Point(3, 7)
        Me.lbl_descripcion_bus.Name = "lbl_descripcion_bus"
        Me.lbl_descripcion_bus.Size = New System.Drawing.Size(134, 15)
        Me.lbl_descripcion_bus.TabIndex = 0
        Me.lbl_descripcion_bus.Text = "Razon Social"
        '
        'txt_RazonSocial_Filtro
        '
        Me.txt_RazonSocial_Filtro.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_RazonSocial_Filtro.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmClienteMayoristaViewModelBindingSource, "FiltroRazonSocial", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_RazonSocial_Filtro.Location = New System.Drawing.Point(143, 4)
        Me.txt_RazonSocial_Filtro.Name = "txt_RazonSocial_Filtro"
        Me.txt_RazonSocial_Filtro.Size = New System.Drawing.Size(194, 21)
        Me.txt_RazonSocial_Filtro.TabIndex = 1
        '
        'Label52
        '
        Me.Label52.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(425, 7)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(134, 15)
        Me.Label52.TabIndex = 6
        Me.Label52.Text = "Corredor"
        '
        'cmb_Corredor_Filtro
        '
        Me.cmb_Corredor_Filtro.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_Corredor_Filtro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmb_Corredor_Filtro.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.FrmClienteMayoristaViewModelBindingSource, "FiltroCorredorSaleccionada", True))
        Me.cmb_Corredor_Filtro.DataSource = Me.CorredoresBindingSource
        Me.cmb_Corredor_Filtro.DisplayMember = "Value"
        Me.cmb_Corredor_Filtro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Corredor_Filtro.FormattingEnabled = True
        Me.cmb_Corredor_Filtro.Location = New System.Drawing.Point(565, 4)
        Me.cmb_Corredor_Filtro.Name = "cmb_Corredor_Filtro"
        Me.cmb_Corredor_Filtro.Size = New System.Drawing.Size(194, 23)
        Me.cmb_Corredor_Filtro.TabIndex = 7
        Me.cmb_Corredor_Filtro.ValueMember = "Key"
        '
        'Label53
        '
        Me.Label53.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label53.AutoSize = True
        Me.Label53.Location = New System.Drawing.Point(425, 37)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(99, 15)
        Me.Label53.TabIndex = 23
        Me.Label53.Text = "Condición de IVA"
        '
        'cmb_CondicionIVA_Filtro
        '
        Me.cmb_CondicionIVA_Filtro.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_CondicionIVA_Filtro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmb_CondicionIVA_Filtro.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.FrmClienteMayoristaViewModelBindingSource, "FiltroCondicionesIVASaleccionada", True))
        Me.cmb_CondicionIVA_Filtro.DataSource = Me.FiltroCondicionesIVABindingSource
        Me.cmb_CondicionIVA_Filtro.DisplayMember = "Value"
        Me.cmb_CondicionIVA_Filtro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_CondicionIVA_Filtro.Location = New System.Drawing.Point(565, 34)
        Me.cmb_CondicionIVA_Filtro.Name = "cmb_CondicionIVA_Filtro"
        Me.cmb_CondicionIVA_Filtro.Size = New System.Drawing.Size(194, 23)
        Me.cmb_CondicionIVA_Filtro.TabIndex = 24
        Me.cmb_CondicionIVA_Filtro.ValueMember = "Key"
        '
        'FiltroCondicionesIVABindingSource
        '
        Me.FiltroCondicionesIVABindingSource.DataMember = "CondicionesIVA"
        Me.FiltroCondicionesIVABindingSource.DataSource = Me.FrmClienteMayoristaViewModelBindingSource
        '
        'Label54
        '
        Me.Label54.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label54.AutoSize = True
        Me.Label54.Location = New System.Drawing.Point(425, 67)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(94, 15)
        Me.Label54.TabIndex = 25
        Me.Label54.Text = "Lista de Precios"
        '
        'cmb_ListaPrecios_Filtro
        '
        Me.cmb_ListaPrecios_Filtro.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_ListaPrecios_Filtro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmb_ListaPrecios_Filtro.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.FrmClienteMayoristaViewModelBindingSource, "FiltroListaPreciosSaleccionada", True))
        Me.cmb_ListaPrecios_Filtro.DataSource = Me.FiltroListasPreciosBindingSource
        Me.cmb_ListaPrecios_Filtro.DisplayMember = "Value"
        Me.cmb_ListaPrecios_Filtro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ListaPrecios_Filtro.FormattingEnabled = True
        Me.cmb_ListaPrecios_Filtro.Location = New System.Drawing.Point(565, 64)
        Me.cmb_ListaPrecios_Filtro.Name = "cmb_ListaPrecios_Filtro"
        Me.cmb_ListaPrecios_Filtro.Size = New System.Drawing.Size(194, 23)
        Me.cmb_ListaPrecios_Filtro.TabIndex = 26
        Me.cmb_ListaPrecios_Filtro.ValueMember = "Key"
        '
        'FiltroListasPreciosBindingSource
        '
        Me.FiltroListasPreciosBindingSource.DataMember = "ListasPrecios"
        Me.FiltroListasPreciosBindingSource.DataSource = Me.FrmClienteMayoristaViewModelBindingSource
        '
        'Label50
        '
        Me.Label50.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(3, 99)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(134, 15)
        Me.Label50.TabIndex = 4
        Me.Label50.Text = "Habilitado"
        '
        'Label55
        '
        Me.Label55.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label55.AutoSize = True
        Me.Label55.Location = New System.Drawing.Point(3, 67)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(57, 15)
        Me.Label55.TabIndex = 27
        Me.Label55.Text = "Empresa"
        '
        'cmb_Empresa_Filtro
        '
        Me.cmb_Empresa_Filtro.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_Empresa_Filtro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmb_Empresa_Filtro.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.FrmClienteMayoristaViewModelBindingSource, "FiltroEmpresaSaleccionada", True))
        Me.cmb_Empresa_Filtro.DataSource = Me.EmpresasBindingSource
        Me.cmb_Empresa_Filtro.DisplayMember = "Value"
        Me.cmb_Empresa_Filtro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Empresa_Filtro.FormattingEnabled = True
        Me.cmb_Empresa_Filtro.Location = New System.Drawing.Point(143, 64)
        Me.cmb_Empresa_Filtro.Name = "cmb_Empresa_Filtro"
        Me.cmb_Empresa_Filtro.Size = New System.Drawing.Size(194, 23)
        Me.cmb_Empresa_Filtro.TabIndex = 28
        Me.cmb_Empresa_Filtro.ValueMember = "Key"
        '
        'EmpresasBindingSource
        '
        Me.EmpresasBindingSource.DataMember = "Empresas"
        Me.EmpresasBindingSource.DataSource = Me.FrmClienteMayoristaViewModelBindingSource
        '
        'cmb_Habilitado_Filtro
        '
        Me.cmb_Habilitado_Filtro.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_Habilitado_Filtro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmb_Habilitado_Filtro.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.FrmClienteMayoristaViewModelBindingSource, "FiltroHabilitadoSaleccionada", True))
        Me.cmb_Habilitado_Filtro.DataSource = Me.HabilitadosBindingSource
        Me.cmb_Habilitado_Filtro.DisplayMember = "Value"
        Me.cmb_Habilitado_Filtro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Habilitado_Filtro.FormattingEnabled = True
        Me.cmb_Habilitado_Filtro.Location = New System.Drawing.Point(143, 96)
        Me.cmb_Habilitado_Filtro.Name = "cmb_Habilitado_Filtro"
        Me.cmb_Habilitado_Filtro.Size = New System.Drawing.Size(194, 23)
        Me.cmb_Habilitado_Filtro.TabIndex = 29
        Me.cmb_Habilitado_Filtro.ValueMember = "Key"
        '
        'HabilitadosBindingSource
        '
        Me.HabilitadosBindingSource.DataMember = "Habilitados"
        Me.HabilitadosBindingSource.DataSource = Me.FrmClienteMayoristaViewModelBindingSource
        '
        'TbAlta
        '
        Me.TbAlta.CausesValidation = False
        Me.TbAlta.Controls.Add(Me.GB_Alta)
        Me.TbAlta.Location = New System.Drawing.Point(4, 29)
        Me.TbAlta.Name = "TbAlta"
        Me.TbAlta.Padding = New System.Windows.Forms.Padding(3)
        Me.TbAlta.Size = New System.Drawing.Size(786, 721)
        Me.TbAlta.TabIndex = 1
        Me.TbAlta.Text = "Alta de Cliente"
        Me.TbAlta.UseVisualStyleBackColor = True
        '
        'GB_Alta
        '
        Me.GB_Alta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_Alta.Controls.Add(Me.TableLayoutPanel7)
        Me.GB_Alta.Controls.Add(Me.TableLayoutPanel6)
        Me.GB_Alta.Controls.Add(Me.TableLayoutPanel3)
        Me.GB_Alta.Controls.Add(Me.TableLayoutPanel2)
        Me.GB_Alta.Controls.Add(Me.TableLayoutPanel1)
        Me.GB_Alta.Controls.Add(Me.Label17)
        Me.GB_Alta.Controls.Add(Me.Btn_Agregar)
        Me.GB_Alta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Alta.Location = New System.Drawing.Point(10, 6)
        Me.GB_Alta.Name = "GB_Alta"
        Me.GB_Alta.Size = New System.Drawing.Size(768, 707)
        Me.GB_Alta.TabIndex = 0
        Me.GB_Alta.TabStop = False
        Me.GB_Alta.Text = "Formulario de Alta"
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel7.ColumnCount = 2
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.GroupBox2, 1, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.GroupBox1, 0, 0)
        Me.TableLayoutPanel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(6, 315)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(756, 248)
        Me.TableLayoutPanel7.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.TableLayoutPanel5)
        Me.GroupBox2.Location = New System.Drawing.Point(381, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(372, 239)
        Me.GroupBox2.TabIndex = 83
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Dirección Entrega"
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.Label25, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.cb_Localidad_Entrega, 1, 3)
        Me.TableLayoutPanel5.Controls.Add(Me.txt_CodigoPostal_Entrega, 1, 4)
        Me.TableLayoutPanel5.Controls.Add(Me.cb_Distrito_Entrega, 1, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.cb_Provincia_Entrega, 1, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.txt_Direccion_Entrega, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.Label28, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.Label26, 0, 3)
        Me.TableLayoutPanel5.Controls.Add(Me.Label27, 0, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.Label30, 0, 4)
        Me.TableLayoutPanel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(6, 20)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 7
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(360, 214)
        Me.TableLayoutPanel5.TabIndex = 1
        '
        'Label25
        '
        Me.Label25.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(3, 7)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(59, 15)
        Me.Label25.TabIndex = 11
        Me.Label25.Text = "Dirección"
        '
        'cb_Localidad_Entrega
        '
        Me.cb_Localidad_Entrega.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_Localidad_Entrega.CausesValidation = False
        Me.cb_Localidad_Entrega.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_Localidad_Entrega.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.AltaClienteMayoristaDetalleBindingSource, "EntregaLocalidadesSaleccionada", True))
        Me.cb_Localidad_Entrega.DataSource = Me.AltaClienteEntregaLocalidadesBindingSource
        Me.cb_Localidad_Entrega.DisplayMember = "Value"
        Me.cb_Localidad_Entrega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Localidad_Entrega.FormattingEnabled = True
        Me.cb_Localidad_Entrega.Location = New System.Drawing.Point(143, 94)
        Me.cb_Localidad_Entrega.Name = "cb_Localidad_Entrega"
        Me.cb_Localidad_Entrega.Size = New System.Drawing.Size(214, 23)
        Me.cb_Localidad_Entrega.TabIndex = 23
        Me.cb_Localidad_Entrega.ValueMember = "Key"
        '
        'AltaClienteMayoristaDetalleBindingSource
        '
        Me.AltaClienteMayoristaDetalleBindingSource.DataSource = GetType(SistemaCinderella.Formularios.Cliente.ClienteMayoristaDetalleViewModel)
        '
        'AltaClienteEntregaLocalidadesBindingSource
        '
        Me.AltaClienteEntregaLocalidadesBindingSource.DataMember = "EntregaLocalidades"
        Me.AltaClienteEntregaLocalidadesBindingSource.DataSource = Me.AltaClienteMayoristaDetalleBindingSource
        '
        'txt_CodigoPostal_Entrega
        '
        Me.txt_CodigoPostal_Entrega.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_CodigoPostal_Entrega.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AltaClienteMayoristaDetalleBindingSource, "EntregaCodigoPostal", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_CodigoPostal_Entrega.Location = New System.Drawing.Point(143, 124)
        Me.txt_CodigoPostal_Entrega.MaxLength = 255
        Me.txt_CodigoPostal_Entrega.Name = "txt_CodigoPostal_Entrega"
        Me.txt_CodigoPostal_Entrega.Size = New System.Drawing.Size(214, 21)
        Me.txt_CodigoPostal_Entrega.TabIndex = 24
        '
        'cb_Distrito_Entrega
        '
        Me.cb_Distrito_Entrega.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_Distrito_Entrega.CausesValidation = False
        Me.cb_Distrito_Entrega.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_Distrito_Entrega.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.AltaClienteMayoristaDetalleBindingSource, "EntregaDistritosSaleccionada", True))
        Me.cb_Distrito_Entrega.DataSource = Me.AltaClienteEntregaDistritosBindingSource
        Me.cb_Distrito_Entrega.DisplayMember = "Value"
        Me.cb_Distrito_Entrega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Distrito_Entrega.FormattingEnabled = True
        Me.cb_Distrito_Entrega.Location = New System.Drawing.Point(143, 64)
        Me.cb_Distrito_Entrega.Name = "cb_Distrito_Entrega"
        Me.cb_Distrito_Entrega.Size = New System.Drawing.Size(214, 23)
        Me.cb_Distrito_Entrega.TabIndex = 22
        Me.cb_Distrito_Entrega.ValueMember = "Key"
        '
        'AltaClienteEntregaDistritosBindingSource
        '
        Me.AltaClienteEntregaDistritosBindingSource.DataMember = "EntregaDistritos"
        Me.AltaClienteEntregaDistritosBindingSource.DataSource = Me.AltaClienteMayoristaDetalleBindingSource
        '
        'cb_Provincia_Entrega
        '
        Me.cb_Provincia_Entrega.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_Provincia_Entrega.CausesValidation = False
        Me.cb_Provincia_Entrega.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_Provincia_Entrega.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.AltaClienteMayoristaDetalleBindingSource, "EntregaProvinciasSaleccionada", True))
        Me.cb_Provincia_Entrega.DataSource = Me.AltaClienteEntregaProvinciasBindingSource
        Me.cb_Provincia_Entrega.DisplayMember = "Value"
        Me.cb_Provincia_Entrega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Provincia_Entrega.FormattingEnabled = True
        Me.cb_Provincia_Entrega.Location = New System.Drawing.Point(143, 34)
        Me.cb_Provincia_Entrega.Name = "cb_Provincia_Entrega"
        Me.cb_Provincia_Entrega.Size = New System.Drawing.Size(214, 23)
        Me.cb_Provincia_Entrega.TabIndex = 21
        Me.cb_Provincia_Entrega.ValueMember = "Key"
        '
        'AltaClienteEntregaProvinciasBindingSource
        '
        Me.AltaClienteEntregaProvinciasBindingSource.DataMember = "EntregaProvincias"
        Me.AltaClienteEntregaProvinciasBindingSource.DataSource = Me.AltaClienteMayoristaDetalleBindingSource
        '
        'txt_Direccion_Entrega
        '
        Me.txt_Direccion_Entrega.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Direccion_Entrega.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AltaClienteMayoristaDetalleBindingSource, "EntregaDireccion", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_Direccion_Entrega.Location = New System.Drawing.Point(143, 4)
        Me.txt_Direccion_Entrega.MaxLength = 255
        Me.txt_Direccion_Entrega.Name = "txt_Direccion_Entrega"
        Me.txt_Direccion_Entrega.Size = New System.Drawing.Size(214, 21)
        Me.txt_Direccion_Entrega.TabIndex = 20
        '
        'Label28
        '
        Me.Label28.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(3, 37)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(57, 15)
        Me.Label28.TabIndex = 27
        Me.Label28.Text = "Provincia"
        '
        'Label26
        '
        Me.Label26.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(3, 97)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(61, 15)
        Me.Label26.TabIndex = 25
        Me.Label26.Text = "Localidad"
        '
        'Label27
        '
        Me.Label27.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(3, 67)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(45, 15)
        Me.Label27.TabIndex = 26
        Me.Label27.Text = "Distrito"
        '
        'Label30
        '
        Me.Label30.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(3, 127)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(83, 15)
        Me.Label30.TabIndex = 13
        Me.Label30.Text = "Código Postal"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel4)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(372, 239)
        Me.GroupBox1.TabIndex = 82
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dirección Facturación"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.txt_Mail_Facturacion, 1, 6)
        Me.TableLayoutPanel4.Controls.Add(Me.txt_Telefono_Facturacion, 1, 5)
        Me.TableLayoutPanel4.Controls.Add(Me.cb_Localidad_Facturacion, 1, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.txt_CodigoPostal_Facturacion, 1, 4)
        Me.TableLayoutPanel4.Controls.Add(Me.cb_Distrito_Facturacion, 1, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.cb_Provincia_Facturacion, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.txt_Direccion_Facturacion, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.lbl_Provincia, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.lbl_Distrito, 0, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.lbl_Localidad, 0, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.lbl_CodigoPostal, 0, 4)
        Me.TableLayoutPanel4.Controls.Add(Me.lbl_Telefono, 0, 5)
        Me.TableLayoutPanel4.Controls.Add(Me.lbl_Mail, 0, 6)
        Me.TableLayoutPanel4.Controls.Add(Me.lbl_Direccion, 0, 0)
        Me.TableLayoutPanel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(6, 20)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 7
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(360, 214)
        Me.TableLayoutPanel4.TabIndex = 1
        '
        'txt_Mail_Facturacion
        '
        Me.txt_Mail_Facturacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Mail_Facturacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AltaClienteMayoristaDetalleBindingSource, "FacturacionMail", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_Mail_Facturacion.Location = New System.Drawing.Point(143, 186)
        Me.txt_Mail_Facturacion.MaxLength = 255
        Me.txt_Mail_Facturacion.Name = "txt_Mail_Facturacion"
        Me.txt_Mail_Facturacion.Size = New System.Drawing.Size(214, 21)
        Me.txt_Mail_Facturacion.TabIndex = 19
        '
        'txt_Telefono_Facturacion
        '
        Me.txt_Telefono_Facturacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Telefono_Facturacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AltaClienteMayoristaDetalleBindingSource, "FacturacionTelefono", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_Telefono_Facturacion.Location = New System.Drawing.Point(143, 154)
        Me.txt_Telefono_Facturacion.MaxLength = 255
        Me.txt_Telefono_Facturacion.Name = "txt_Telefono_Facturacion"
        Me.txt_Telefono_Facturacion.Size = New System.Drawing.Size(214, 21)
        Me.txt_Telefono_Facturacion.TabIndex = 18
        '
        'cb_Localidad_Facturacion
        '
        Me.cb_Localidad_Facturacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_Localidad_Facturacion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_Localidad_Facturacion.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.AltaClienteMayoristaDetalleBindingSource, "FacturacionLocalidadesSaleccionada", True))
        Me.cb_Localidad_Facturacion.DataSource = Me.AltaClienteFacturacionLocalidadesBindingSource
        Me.cb_Localidad_Facturacion.DisplayMember = "Value"
        Me.cb_Localidad_Facturacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Localidad_Facturacion.FormattingEnabled = True
        Me.cb_Localidad_Facturacion.ItemHeight = 15
        Me.cb_Localidad_Facturacion.Location = New System.Drawing.Point(143, 94)
        Me.cb_Localidad_Facturacion.Name = "cb_Localidad_Facturacion"
        Me.cb_Localidad_Facturacion.Size = New System.Drawing.Size(214, 23)
        Me.cb_Localidad_Facturacion.TabIndex = 16
        Me.cb_Localidad_Facturacion.ValueMember = "Key"
        '
        'AltaClienteFacturacionLocalidadesBindingSource
        '
        Me.AltaClienteFacturacionLocalidadesBindingSource.DataMember = "FacturacionLocalidades"
        Me.AltaClienteFacturacionLocalidadesBindingSource.DataSource = Me.AltaClienteMayoristaDetalleBindingSource
        '
        'txt_CodigoPostal_Facturacion
        '
        Me.txt_CodigoPostal_Facturacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_CodigoPostal_Facturacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AltaClienteMayoristaDetalleBindingSource, "FacturacionCodigoPostal", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_CodigoPostal_Facturacion.Location = New System.Drawing.Point(143, 124)
        Me.txt_CodigoPostal_Facturacion.MaxLength = 255
        Me.txt_CodigoPostal_Facturacion.Name = "txt_CodigoPostal_Facturacion"
        Me.txt_CodigoPostal_Facturacion.Size = New System.Drawing.Size(214, 21)
        Me.txt_CodigoPostal_Facturacion.TabIndex = 17
        '
        'cb_Distrito_Facturacion
        '
        Me.cb_Distrito_Facturacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_Distrito_Facturacion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_Distrito_Facturacion.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.AltaClienteMayoristaDetalleBindingSource, "FacturacionDistritosSaleccionada", True))
        Me.cb_Distrito_Facturacion.DataSource = Me.AltaClienteFacturacionDistritosBindingSource
        Me.cb_Distrito_Facturacion.DisplayMember = "Value"
        Me.cb_Distrito_Facturacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Distrito_Facturacion.FormattingEnabled = True
        Me.cb_Distrito_Facturacion.Location = New System.Drawing.Point(143, 64)
        Me.cb_Distrito_Facturacion.Name = "cb_Distrito_Facturacion"
        Me.cb_Distrito_Facturacion.Size = New System.Drawing.Size(214, 23)
        Me.cb_Distrito_Facturacion.TabIndex = 15
        Me.cb_Distrito_Facturacion.ValueMember = "Key"
        '
        'AltaClienteFacturacionDistritosBindingSource
        '
        Me.AltaClienteFacturacionDistritosBindingSource.DataMember = "FacturacionDistritos"
        Me.AltaClienteFacturacionDistritosBindingSource.DataSource = Me.AltaClienteMayoristaDetalleBindingSource
        '
        'cb_Provincia_Facturacion
        '
        Me.cb_Provincia_Facturacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_Provincia_Facturacion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_Provincia_Facturacion.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.AltaClienteMayoristaDetalleBindingSource, "FacturacionProvinciasSaleccionada", True))
        Me.cb_Provincia_Facturacion.DataSource = Me.AltaClienteFacturacionProvinciasBindingSource
        Me.cb_Provincia_Facturacion.DisplayMember = "Value"
        Me.cb_Provincia_Facturacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Provincia_Facturacion.FormattingEnabled = True
        Me.cb_Provincia_Facturacion.ItemHeight = 15
        Me.cb_Provincia_Facturacion.Location = New System.Drawing.Point(143, 34)
        Me.cb_Provincia_Facturacion.Name = "cb_Provincia_Facturacion"
        Me.cb_Provincia_Facturacion.Size = New System.Drawing.Size(214, 23)
        Me.cb_Provincia_Facturacion.TabIndex = 14
        Me.cb_Provincia_Facturacion.ValueMember = "Key"
        '
        'AltaClienteFacturacionProvinciasBindingSource
        '
        Me.AltaClienteFacturacionProvinciasBindingSource.DataMember = "FacturacionProvincias"
        Me.AltaClienteFacturacionProvinciasBindingSource.DataSource = Me.AltaClienteMayoristaDetalleBindingSource
        '
        'txt_Direccion_Facturacion
        '
        Me.txt_Direccion_Facturacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Direccion_Facturacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AltaClienteMayoristaDetalleBindingSource, "FacturacionDireccion", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_Direccion_Facturacion.Location = New System.Drawing.Point(143, 4)
        Me.txt_Direccion_Facturacion.MaxLength = 255
        Me.txt_Direccion_Facturacion.Name = "txt_Direccion_Facturacion"
        Me.txt_Direccion_Facturacion.Size = New System.Drawing.Size(214, 21)
        Me.txt_Direccion_Facturacion.TabIndex = 13
        '
        'lbl_Provincia
        '
        Me.lbl_Provincia.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl_Provincia.AutoSize = True
        Me.lbl_Provincia.Location = New System.Drawing.Point(3, 37)
        Me.lbl_Provincia.Name = "lbl_Provincia"
        Me.lbl_Provincia.Size = New System.Drawing.Size(73, 15)
        Me.lbl_Provincia.TabIndex = 27
        Me.lbl_Provincia.Text = "Provincia (*)"
        '
        'lbl_Distrito
        '
        Me.lbl_Distrito.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl_Distrito.AutoSize = True
        Me.lbl_Distrito.Location = New System.Drawing.Point(3, 67)
        Me.lbl_Distrito.Name = "lbl_Distrito"
        Me.lbl_Distrito.Size = New System.Drawing.Size(61, 15)
        Me.lbl_Distrito.TabIndex = 26
        Me.lbl_Distrito.Text = "Distrito (*)"
        '
        'lbl_Localidad
        '
        Me.lbl_Localidad.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl_Localidad.AutoSize = True
        Me.lbl_Localidad.Location = New System.Drawing.Point(3, 97)
        Me.lbl_Localidad.Name = "lbl_Localidad"
        Me.lbl_Localidad.Size = New System.Drawing.Size(77, 15)
        Me.lbl_Localidad.TabIndex = 25
        Me.lbl_Localidad.Text = "Localidad (*)"
        '
        'lbl_CodigoPostal
        '
        Me.lbl_CodigoPostal.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl_CodigoPostal.AutoSize = True
        Me.lbl_CodigoPostal.Location = New System.Drawing.Point(3, 127)
        Me.lbl_CodigoPostal.Name = "lbl_CodigoPostal"
        Me.lbl_CodigoPostal.Size = New System.Drawing.Size(99, 15)
        Me.lbl_CodigoPostal.TabIndex = 13
        Me.lbl_CodigoPostal.Text = "Código Postal (*)"
        '
        'lbl_Telefono
        '
        Me.lbl_Telefono.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl_Telefono.AutoSize = True
        Me.lbl_Telefono.Location = New System.Drawing.Point(3, 157)
        Me.lbl_Telefono.Name = "lbl_Telefono"
        Me.lbl_Telefono.Size = New System.Drawing.Size(55, 15)
        Me.lbl_Telefono.TabIndex = 15
        Me.lbl_Telefono.Text = "Teléfono"
        '
        'lbl_Mail
        '
        Me.lbl_Mail.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl_Mail.AutoSize = True
        Me.lbl_Mail.Location = New System.Drawing.Point(3, 189)
        Me.lbl_Mail.Name = "lbl_Mail"
        Me.lbl_Mail.Size = New System.Drawing.Size(31, 15)
        Me.lbl_Mail.TabIndex = 17
        Me.lbl_Mail.Text = "Mail"
        '
        'lbl_Direccion
        '
        Me.lbl_Direccion.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl_Direccion.AutoSize = True
        Me.lbl_Direccion.Location = New System.Drawing.Point(3, 7)
        Me.lbl_Direccion.Name = "lbl_Direccion"
        Me.lbl_Direccion.Size = New System.Drawing.Size(75, 15)
        Me.lbl_Direccion.TabIndex = 11
        Me.lbl_Direccion.Text = "Dirección (*)"
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel6.ColumnCount = 2
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.Label32, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.txt_Observaciones, 1, 0)
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(6, 567)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(756, 77)
        Me.TableLayoutPanel6.TabIndex = 1
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(3, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(88, 15)
        Me.Label32.TabIndex = 85
        Me.Label32.Text = "Observaciones"
        '
        'txt_Observaciones
        '
        Me.txt_Observaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Observaciones.Location = New System.Drawing.Point(143, 3)
        Me.txt_Observaciones.MaxLength = 255
        Me.txt_Observaciones.Multiline = True
        Me.txt_Observaciones.Name = "txt_Observaciones"
        Me.txt_Observaciones.Size = New System.Drawing.Size(610, 71)
        Me.txt_Observaciones.TabIndex = 25
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.ColumnCount = 5
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label24, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.cmb_Empresa, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.lbl_ListaPrecio, 3, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.cb_ListaPrecios, 4, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(6, 268)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(756, 39)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'Label24
        '
        Me.Label24.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(3, 12)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(57, 15)
        Me.Label24.TabIndex = 81
        Me.Label24.Text = "Empresa"
        '
        'cmb_Empresa
        '
        Me.cmb_Empresa.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_Empresa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmb_Empresa.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.AltaClienteMayoristaDetalleBindingSource, "EmpresaSaleccionada", True))
        Me.cmb_Empresa.DataSource = Me.EmpresasBindingSource
        Me.cmb_Empresa.DisplayMember = "Value"
        Me.cmb_Empresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Empresa.FormattingEnabled = True
        Me.cmb_Empresa.Location = New System.Drawing.Point(143, 9)
        Me.cmb_Empresa.Name = "cmb_Empresa"
        Me.cmb_Empresa.Size = New System.Drawing.Size(212, 23)
        Me.cmb_Empresa.TabIndex = 11
        Me.cmb_Empresa.ValueMember = "Key"
        '
        'lbl_ListaPrecio
        '
        Me.lbl_ListaPrecio.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl_ListaPrecio.AutoSize = True
        Me.lbl_ListaPrecio.Location = New System.Drawing.Point(401, 12)
        Me.lbl_ListaPrecio.Name = "lbl_ListaPrecio"
        Me.lbl_ListaPrecio.Size = New System.Drawing.Size(110, 15)
        Me.lbl_ListaPrecio.TabIndex = 21
        Me.lbl_ListaPrecio.Text = "Lista de Precios (*)"
        '
        'cb_ListaPrecios
        '
        Me.cb_ListaPrecios.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_ListaPrecios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_ListaPrecios.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.AltaClienteMayoristaDetalleBindingSource, "ListaPreciosSaleccionada", True))
        Me.cb_ListaPrecios.DataSource = Me.AltaClienteListasPreciosBindingSource
        Me.cb_ListaPrecios.DisplayMember = "Value"
        Me.cb_ListaPrecios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_ListaPrecios.FormattingEnabled = True
        Me.cb_ListaPrecios.Location = New System.Drawing.Point(541, 9)
        Me.cb_ListaPrecios.Name = "cb_ListaPrecios"
        Me.cb_ListaPrecios.Size = New System.Drawing.Size(212, 23)
        Me.cb_ListaPrecios.TabIndex = 12
        Me.cb_ListaPrecios.ValueMember = "Key"
        '
        'AltaClienteListasPreciosBindingSource
        '
        Me.AltaClienteListasPreciosBindingSource.DataMember = "ListasPrecios"
        Me.AltaClienteListasPreciosBindingSource.DataSource = Me.AltaClienteMayoristaDetalleBindingSource
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_Observaciones, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_CondicionPago, 1, 0)
        Me.TableLayoutPanel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(6, 185)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(756, 77)
        Me.TableLayoutPanel2.TabIndex = 85
        '
        'lbl_Observaciones
        '
        Me.lbl_Observaciones.AutoSize = True
        Me.lbl_Observaciones.Location = New System.Drawing.Point(3, 0)
        Me.lbl_Observaciones.Name = "lbl_Observaciones"
        Me.lbl_Observaciones.Size = New System.Drawing.Size(110, 15)
        Me.lbl_Observaciones.TabIndex = 19
        Me.lbl_Observaciones.Text = "Condición de pago"
        '
        'txt_CondicionPago
        '
        Me.txt_CondicionPago.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AltaClienteMayoristaDetalleBindingSource, "CondicionPago", True))
        Me.txt_CondicionPago.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_CondicionPago.Location = New System.Drawing.Point(143, 3)
        Me.txt_CondicionPago.MaxLength = 255
        Me.txt_CondicionPago.Multiline = True
        Me.txt_CondicionPago.Name = "txt_CondicionPago"
        Me.txt_CondicionPago.Size = New System.Drawing.Size(610, 71)
        Me.txt_CondicionPago.TabIndex = 10
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_RazonSocial, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_Cuit, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_RazonSocial, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_Transporte, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label22, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Cuit, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.cmb_Corredor, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label23, 3, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Nombre, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cb_CondicionIva, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Transporte, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label20, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label21, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label19, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_CondicionIva, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.PercentUpDown2, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.PercentUpDown3, 4, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.PercentUpDown4, 4, 2)
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(6, 20)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(756, 159)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'lbl_RazonSocial
        '
        Me.lbl_RazonSocial.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl_RazonSocial.AutoSize = True
        Me.lbl_RazonSocial.Location = New System.Drawing.Point(3, 7)
        Me.lbl_RazonSocial.Name = "lbl_RazonSocial"
        Me.lbl_RazonSocial.Size = New System.Drawing.Size(96, 15)
        Me.lbl_RazonSocial.TabIndex = 1
        Me.lbl_RazonSocial.Text = "Razón Social (*)"
        '
        'lbl_Cuit
        '
        Me.lbl_Cuit.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl_Cuit.AutoSize = True
        Me.lbl_Cuit.Location = New System.Drawing.Point(3, 37)
        Me.lbl_Cuit.Name = "lbl_Cuit"
        Me.lbl_Cuit.Size = New System.Drawing.Size(44, 15)
        Me.lbl_Cuit.TabIndex = 7
        Me.lbl_Cuit.Text = "Cuit (*)"
        '
        'txt_RazonSocial
        '
        Me.txt_RazonSocial.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_RazonSocial.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AltaClienteMayoristaDetalleBindingSource, "RazonSocial", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_RazonSocial.Location = New System.Drawing.Point(143, 4)
        Me.txt_RazonSocial.MaxLength = 255
        Me.txt_RazonSocial.Name = "txt_RazonSocial"
        Me.txt_RazonSocial.Size = New System.Drawing.Size(212, 21)
        Me.txt_RazonSocial.TabIndex = 1
        '
        'lbl_Transporte
        '
        Me.lbl_Transporte.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl_Transporte.AutoSize = True
        Me.lbl_Transporte.Location = New System.Drawing.Point(3, 99)
        Me.lbl_Transporte.Name = "lbl_Transporte"
        Me.lbl_Transporte.Size = New System.Drawing.Size(66, 15)
        Me.lbl_Transporte.TabIndex = 9
        Me.lbl_Transporte.Text = "Transporte"
        '
        'Label22
        '
        Me.Label22.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(3, 134)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(104, 15)
        Me.Label22.TabIndex = 77
        Me.Label22.Text = "Bonificación % (*)"
        '
        'txt_Cuit
        '
        Me.txt_Cuit.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Cuit.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AltaClienteMayoristaDetalleBindingSource, "Cuit", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_Cuit.Location = New System.Drawing.Point(143, 34)
        Me.txt_Cuit.Mask = "99-99999999-9"
        Me.txt_Cuit.Name = "txt_Cuit"
        Me.txt_Cuit.Size = New System.Drawing.Size(212, 21)
        Me.txt_Cuit.TabIndex = 3
        Me.txt_Cuit.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Button1
        '
        Me.Button1.Image = Global.SistemaCinderella.My.Resources.Recursos.IconoBuscar24
        Me.Button1.Location = New System.Drawing.Point(361, 93)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(33, 28)
        Me.Button1.TabIndex = 75
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmb_Corredor
        '
        Me.cmb_Corredor.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_Corredor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmb_Corredor.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.AltaClienteMayoristaDetalleBindingSource, "CorredorSaleccionada", True))
        Me.cmb_Corredor.DataSource = Me.CorredoresBindingSource
        Me.cmb_Corredor.DisplayMember = "Value"
        Me.cmb_Corredor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Corredor.FormattingEnabled = True
        Me.cmb_Corredor.Location = New System.Drawing.Point(143, 64)
        Me.cmb_Corredor.Name = "cmb_Corredor"
        Me.cmb_Corredor.Size = New System.Drawing.Size(212, 23)
        Me.cmb_Corredor.TabIndex = 5
        Me.cmb_Corredor.ValueMember = "Key"
        '
        'Label23
        '
        Me.Label23.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(401, 134)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(63, 15)
        Me.Label23.TabIndex = 79
        Me.Label23.Text = "Lista % (*)"
        '
        'txt_Nombre
        '
        Me.txt_Nombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Nombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AltaClienteMayoristaDetalleBindingSource, "Nombre", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_Nombre.Location = New System.Drawing.Point(541, 4)
        Me.txt_Nombre.MaxLength = 255
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.Size = New System.Drawing.Size(212, 21)
        Me.txt_Nombre.TabIndex = 2
        '
        'cb_CondicionIva
        '
        Me.cb_CondicionIva.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_CondicionIva.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_CondicionIva.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.AltaClienteMayoristaDetalleBindingSource, "CondicionesIVASaleccionada", True))
        Me.cb_CondicionIva.DataSource = Me.AltaClienteCondicionesIVABindingSource
        Me.cb_CondicionIva.DisplayMember = "Value"
        Me.cb_CondicionIva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_CondicionIva.Location = New System.Drawing.Point(541, 34)
        Me.cb_CondicionIva.Name = "cb_CondicionIva"
        Me.cb_CondicionIva.Size = New System.Drawing.Size(212, 23)
        Me.cb_CondicionIva.TabIndex = 4
        Me.cb_CondicionIva.ValueMember = "Key"
        '
        'AltaClienteCondicionesIVABindingSource
        '
        Me.AltaClienteCondicionesIVABindingSource.DataMember = "CondicionesIVA"
        Me.AltaClienteCondicionesIVABindingSource.DataSource = Me.AltaClienteMayoristaDetalleBindingSource
        '
        'txt_Transporte
        '
        Me.txt_Transporte.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Transporte.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AltaClienteMayoristaDetalleBindingSource, "Transporte", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_Transporte.Location = New System.Drawing.Point(143, 96)
        Me.txt_Transporte.MaxLength = 255
        Me.txt_Transporte.Name = "txt_Transporte"
        Me.txt_Transporte.Size = New System.Drawing.Size(212, 21)
        Me.txt_Transporte.TabIndex = 7
        '
        'Label20
        '
        Me.Label20.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(3, 67)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(55, 15)
        Me.Label20.TabIndex = 72
        Me.Label20.Text = "Corredor"
        '
        'Label21
        '
        Me.Label21.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(401, 67)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(89, 15)
        Me.Label21.TabIndex = 74
        Me.Label21.Text = "Comisión % (*)"
        '
        'Label19
        '
        Me.Label19.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(401, 7)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(68, 15)
        Me.Label19.TabIndex = 70
        Me.Label19.Text = "Nombre (*)"
        '
        'lbl_CondicionIva
        '
        Me.lbl_CondicionIva.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl_CondicionIva.AutoSize = True
        Me.lbl_CondicionIva.Location = New System.Drawing.Point(401, 37)
        Me.lbl_CondicionIva.Name = "lbl_CondicionIva"
        Me.lbl_CondicionIva.Size = New System.Drawing.Size(115, 15)
        Me.lbl_CondicionIva.TabIndex = 22
        Me.lbl_CondicionIva.Text = "Condición de IVA (*)"
        '
        'PercentUpDown2
        '
        Me.PercentUpDown2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PercentUpDown2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AltaClienteMayoristaDetalleBindingSource, "PorcentajeBonificacion", True))
        Me.PercentUpDown2.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.PercentUpDown2.Location = New System.Drawing.Point(143, 131)
        Me.PercentUpDown2.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.PercentUpDown2.Name = "PercentUpDown2"
        Me.PercentUpDown2.Size = New System.Drawing.Size(212, 21)
        Me.PercentUpDown2.TabIndex = 80
        Me.PercentUpDown2.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'PercentUpDown3
        '
        Me.PercentUpDown3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PercentUpDown3.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AltaClienteMayoristaDetalleBindingSource, "PorcentajeLista", True))
        Me.PercentUpDown3.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.PercentUpDown3.Location = New System.Drawing.Point(541, 131)
        Me.PercentUpDown3.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.PercentUpDown3.Name = "PercentUpDown3"
        Me.PercentUpDown3.Size = New System.Drawing.Size(212, 21)
        Me.PercentUpDown3.TabIndex = 81
        Me.PercentUpDown3.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'PercentUpDown4
        '
        Me.PercentUpDown4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PercentUpDown4.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AltaClienteMayoristaDetalleBindingSource, "PorcentajeComision", True))
        Me.PercentUpDown4.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.PercentUpDown4.Location = New System.Drawing.Point(541, 64)
        Me.PercentUpDown4.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.PercentUpDown4.Name = "PercentUpDown4"
        Me.PercentUpDown4.Size = New System.Drawing.Size(212, 21)
        Me.PercentUpDown4.TabIndex = 82
        Me.PercentUpDown4.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(5, 788)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(117, 13)
        Me.Label17.TabIndex = 68
        Me.Label17.Text = "(*) Campos obligatorios."
        '
        'Btn_Agregar
        '
        Me.Btn_Agregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Agregar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Agregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Agregar.Image = Global.SistemaCinderella.My.Resources.Recursos.Agregar_24
        Me.Btn_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Agregar.Location = New System.Drawing.Point(662, 650)
        Me.Btn_Agregar.Name = "Btn_Agregar"
        Me.Btn_Agregar.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Agregar.TabIndex = 26
        Me.Btn_Agregar.Text = "Agregar"
        Me.Btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolCliente.SetToolTip(Me.Btn_Agregar, "Haz click aquí para dar de alta un nuevo cliente")
        Me.Btn_Agregar.UseVisualStyleBackColor = False
        '
        'TbMod
        '
        Me.TbMod.Controls.Add(Me.GB_Modificacion)
        Me.TbMod.Location = New System.Drawing.Point(4, 29)
        Me.TbMod.Name = "TbMod"
        Me.TbMod.Size = New System.Drawing.Size(786, 721)
        Me.TbMod.TabIndex = 2
        Me.TbMod.Text = "Modificación de Cliente"
        Me.TbMod.UseVisualStyleBackColor = True
        '
        'GB_Modificacion
        '
        Me.GB_Modificacion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_Modificacion.Controls.Add(Me.TableLayoutPanel18)
        Me.GB_Modificacion.Controls.Add(Me.TableLayoutPanel8)
        Me.GB_Modificacion.Controls.Add(Me.TableLayoutPanel11)
        Me.GB_Modificacion.Controls.Add(Me.TableLayoutPanel12)
        Me.GB_Modificacion.Controls.Add(Me.TableLayoutPanel13)
        Me.GB_Modificacion.Controls.Add(Me.TableLayoutPanel14)
        Me.GB_Modificacion.Controls.Add(Me.Btn_Cancelar)
        Me.GB_Modificacion.Controls.Add(Me.Btn_Modificar)
        Me.GB_Modificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Modificacion.Location = New System.Drawing.Point(10, 6)
        Me.GB_Modificacion.Name = "GB_Modificacion"
        Me.GB_Modificacion.Size = New System.Drawing.Size(768, 707)
        Me.GB_Modificacion.TabIndex = 1
        Me.GB_Modificacion.TabStop = False
        Me.GB_Modificacion.Text = "Formulario de Modificación"
        '
        'TableLayoutPanel18
        '
        Me.TableLayoutPanel18.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel18.ColumnCount = 2
        Me.TableLayoutPanel18.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.TableLayoutPanel18.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel18.Controls.Add(Me.Label51, 0, 0)
        Me.TableLayoutPanel18.Controls.Add(Me.chk_Habilitado_Mod, 1, 0)
        Me.TableLayoutPanel18.Location = New System.Drawing.Point(6, 650)
        Me.TableLayoutPanel18.Name = "TableLayoutPanel18"
        Me.TableLayoutPanel18.RowCount = 1
        Me.TableLayoutPanel18.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel18.Size = New System.Drawing.Size(383, 40)
        Me.TableLayoutPanel18.TabIndex = 91
        '
        'Label51
        '
        Me.Label51.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label51.AutoSize = True
        Me.Label51.Location = New System.Drawing.Point(3, 12)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(63, 15)
        Me.Label51.TabIndex = 80
        Me.Label51.Text = "Habilitado"
        '
        'chk_Habilitado_Mod
        '
        Me.chk_Habilitado_Mod.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chk_Habilitado_Mod.AutoSize = True
        Me.chk_Habilitado_Mod.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.ModificacionClienteMayoristaDetalleBindingSource, "Habilitado", True))
        Me.chk_Habilitado_Mod.Location = New System.Drawing.Point(143, 13)
        Me.chk_Habilitado_Mod.Name = "chk_Habilitado_Mod"
        Me.chk_Habilitado_Mod.Size = New System.Drawing.Size(15, 14)
        Me.chk_Habilitado_Mod.TabIndex = 125
        Me.chk_Habilitado_Mod.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel8.ColumnCount = 2
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.GroupBox3, 1, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.GroupBox4, 0, 0)
        Me.TableLayoutPanel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(6, 315)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 1
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(754, 248)
        Me.TableLayoutPanel8.TabIndex = 86
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.TableLayoutPanel9)
        Me.GroupBox3.Location = New System.Drawing.Point(380, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(371, 239)
        Me.GroupBox3.TabIndex = 83
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Dirección Entrega"
        '
        'TableLayoutPanel9
        '
        Me.TableLayoutPanel9.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel9.ColumnCount = 2
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel9.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.cb_Localidad_Entrega_Mod, 1, 3)
        Me.TableLayoutPanel9.Controls.Add(Me.txt_CodigoPostal_Entrega_Mod, 1, 4)
        Me.TableLayoutPanel9.Controls.Add(Me.cb_Distrito_Entrega_Mod, 1, 2)
        Me.TableLayoutPanel9.Controls.Add(Me.cb_Provincia_Entrega_Mod, 1, 1)
        Me.TableLayoutPanel9.Controls.Add(Me.txt_Direccion_Entrega_Mod, 1, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel9.Controls.Add(Me.Label3, 0, 3)
        Me.TableLayoutPanel9.Controls.Add(Me.Label4, 0, 2)
        Me.TableLayoutPanel9.Controls.Add(Me.Label5, 0, 4)
        Me.TableLayoutPanel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel9.Location = New System.Drawing.Point(6, 20)
        Me.TableLayoutPanel9.Name = "TableLayoutPanel9"
        Me.TableLayoutPanel9.RowCount = 7
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel9.Size = New System.Drawing.Size(360, 214)
        Me.TableLayoutPanel9.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 15)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Direccion"
        '
        'cb_Localidad_Entrega_Mod
        '
        Me.cb_Localidad_Entrega_Mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_Localidad_Entrega_Mod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_Localidad_Entrega_Mod.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ModificacionClienteMayoristaDetalleBindingSource, "EntregaLocalidadesSaleccionada", True))
        Me.cb_Localidad_Entrega_Mod.DataSource = Me.ModificacionClienteEntregaLocalidadesBindingSource
        Me.cb_Localidad_Entrega_Mod.DisplayMember = "Value"
        Me.cb_Localidad_Entrega_Mod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Localidad_Entrega_Mod.FormattingEnabled = True
        Me.cb_Localidad_Entrega_Mod.Location = New System.Drawing.Point(143, 94)
        Me.cb_Localidad_Entrega_Mod.Name = "cb_Localidad_Entrega_Mod"
        Me.cb_Localidad_Entrega_Mod.Size = New System.Drawing.Size(214, 23)
        Me.cb_Localidad_Entrega_Mod.TabIndex = 122
        Me.cb_Localidad_Entrega_Mod.ValueMember = "Key"
        '
        'ModificacionClienteEntregaLocalidadesBindingSource
        '
        Me.ModificacionClienteEntregaLocalidadesBindingSource.DataMember = "EntregaLocalidades"
        Me.ModificacionClienteEntregaLocalidadesBindingSource.DataSource = Me.ModificacionClienteMayoristaDetalleBindingSource
        '
        'txt_CodigoPostal_Entrega_Mod
        '
        Me.txt_CodigoPostal_Entrega_Mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_CodigoPostal_Entrega_Mod.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ModificacionClienteMayoristaDetalleBindingSource, "EntregaCodigoPostal", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_CodigoPostal_Entrega_Mod.Location = New System.Drawing.Point(143, 124)
        Me.txt_CodigoPostal_Entrega_Mod.MaxLength = 255
        Me.txt_CodigoPostal_Entrega_Mod.Name = "txt_CodigoPostal_Entrega_Mod"
        Me.txt_CodigoPostal_Entrega_Mod.Size = New System.Drawing.Size(214, 21)
        Me.txt_CodigoPostal_Entrega_Mod.TabIndex = 123
        '
        'cb_Distrito_Entrega_Mod
        '
        Me.cb_Distrito_Entrega_Mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_Distrito_Entrega_Mod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_Distrito_Entrega_Mod.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ModificacionClienteMayoristaDetalleBindingSource, "EntregaDistritosSaleccionada", True))
        Me.cb_Distrito_Entrega_Mod.DataSource = Me.ModificacionClienteEntregaDistritosBindingSource
        Me.cb_Distrito_Entrega_Mod.DisplayMember = "Value"
        Me.cb_Distrito_Entrega_Mod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Distrito_Entrega_Mod.FormattingEnabled = True
        Me.cb_Distrito_Entrega_Mod.Location = New System.Drawing.Point(143, 64)
        Me.cb_Distrito_Entrega_Mod.Name = "cb_Distrito_Entrega_Mod"
        Me.cb_Distrito_Entrega_Mod.Size = New System.Drawing.Size(214, 23)
        Me.cb_Distrito_Entrega_Mod.TabIndex = 121
        Me.cb_Distrito_Entrega_Mod.ValueMember = "Key"
        '
        'ModificacionClienteEntregaDistritosBindingSource
        '
        Me.ModificacionClienteEntregaDistritosBindingSource.DataMember = "EntregaDistritos"
        Me.ModificacionClienteEntregaDistritosBindingSource.DataSource = Me.ModificacionClienteMayoristaDetalleBindingSource
        '
        'cb_Provincia_Entrega_Mod
        '
        Me.cb_Provincia_Entrega_Mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_Provincia_Entrega_Mod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_Provincia_Entrega_Mod.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ModificacionClienteMayoristaDetalleBindingSource, "EntregaProvinciasSaleccionada", True))
        Me.cb_Provincia_Entrega_Mod.DataSource = Me.ModificacionClienteEntregaProvinciasBindingSource
        Me.cb_Provincia_Entrega_Mod.DisplayMember = "Value"
        Me.cb_Provincia_Entrega_Mod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Provincia_Entrega_Mod.FormattingEnabled = True
        Me.cb_Provincia_Entrega_Mod.Location = New System.Drawing.Point(143, 34)
        Me.cb_Provincia_Entrega_Mod.Name = "cb_Provincia_Entrega_Mod"
        Me.cb_Provincia_Entrega_Mod.Size = New System.Drawing.Size(214, 23)
        Me.cb_Provincia_Entrega_Mod.TabIndex = 120
        Me.cb_Provincia_Entrega_Mod.ValueMember = "Key"
        '
        'ModificacionClienteEntregaProvinciasBindingSource
        '
        Me.ModificacionClienteEntregaProvinciasBindingSource.DataMember = "EntregaProvincias"
        Me.ModificacionClienteEntregaProvinciasBindingSource.DataSource = Me.ModificacionClienteMayoristaDetalleBindingSource
        '
        'txt_Direccion_Entrega_Mod
        '
        Me.txt_Direccion_Entrega_Mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Direccion_Entrega_Mod.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ModificacionClienteMayoristaDetalleBindingSource, "EntregaDireccion", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_Direccion_Entrega_Mod.Location = New System.Drawing.Point(143, 4)
        Me.txt_Direccion_Entrega_Mod.MaxLength = 255
        Me.txt_Direccion_Entrega_Mod.Name = "txt_Direccion_Entrega_Mod"
        Me.txt_Direccion_Entrega_Mod.Size = New System.Drawing.Size(214, 21)
        Me.txt_Direccion_Entrega_Mod.TabIndex = 119
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 15)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Provincia"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 15)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Localidad"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 15)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Distrito"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 15)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Código Postal"
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.TableLayoutPanel10)
        Me.GroupBox4.Location = New System.Drawing.Point(3, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(371, 239)
        Me.GroupBox4.TabIndex = 82
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Dirección Facturación"
        '
        'TableLayoutPanel10
        '
        Me.TableLayoutPanel10.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel10.ColumnCount = 2
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel10.Controls.Add(Me.txt_Mail_Facturacion_Mod, 1, 6)
        Me.TableLayoutPanel10.Controls.Add(Me.txt_Telefono_Facturacion_Mod, 1, 5)
        Me.TableLayoutPanel10.Controls.Add(Me.cb_Localidad_Facturacion_Mod, 1, 3)
        Me.TableLayoutPanel10.Controls.Add(Me.txt_CodigoPostal_Facturacion_Mod, 1, 4)
        Me.TableLayoutPanel10.Controls.Add(Me.cb_Distrito_Facturacion_Mod, 1, 2)
        Me.TableLayoutPanel10.Controls.Add(Me.cb_Provincia_Facturacion_Mod, 1, 1)
        Me.TableLayoutPanel10.Controls.Add(Me.txt_Direccion_Facturacion_Mod, 1, 0)
        Me.TableLayoutPanel10.Controls.Add(Me.Label6, 0, 1)
        Me.TableLayoutPanel10.Controls.Add(Me.Label7, 0, 2)
        Me.TableLayoutPanel10.Controls.Add(Me.Label8, 0, 3)
        Me.TableLayoutPanel10.Controls.Add(Me.Label9, 0, 4)
        Me.TableLayoutPanel10.Controls.Add(Me.Label10, 0, 5)
        Me.TableLayoutPanel10.Controls.Add(Me.Label11, 0, 6)
        Me.TableLayoutPanel10.Controls.Add(Me.Label12, 0, 0)
        Me.TableLayoutPanel10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel10.Location = New System.Drawing.Point(6, 20)
        Me.TableLayoutPanel10.Name = "TableLayoutPanel10"
        Me.TableLayoutPanel10.RowCount = 7
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel10.Size = New System.Drawing.Size(360, 214)
        Me.TableLayoutPanel10.TabIndex = 1
        '
        'txt_Mail_Facturacion_Mod
        '
        Me.txt_Mail_Facturacion_Mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Mail_Facturacion_Mod.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ModificacionClienteMayoristaDetalleBindingSource, "FacturacionMail", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_Mail_Facturacion_Mod.Location = New System.Drawing.Point(143, 186)
        Me.txt_Mail_Facturacion_Mod.MaxLength = 255
        Me.txt_Mail_Facturacion_Mod.Name = "txt_Mail_Facturacion_Mod"
        Me.txt_Mail_Facturacion_Mod.Size = New System.Drawing.Size(214, 21)
        Me.txt_Mail_Facturacion_Mod.TabIndex = 118
        '
        'txt_Telefono_Facturacion_Mod
        '
        Me.txt_Telefono_Facturacion_Mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Telefono_Facturacion_Mod.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ModificacionClienteMayoristaDetalleBindingSource, "FacturacionTelefono", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_Telefono_Facturacion_Mod.Location = New System.Drawing.Point(143, 154)
        Me.txt_Telefono_Facturacion_Mod.MaxLength = 255
        Me.txt_Telefono_Facturacion_Mod.Name = "txt_Telefono_Facturacion_Mod"
        Me.txt_Telefono_Facturacion_Mod.Size = New System.Drawing.Size(214, 21)
        Me.txt_Telefono_Facturacion_Mod.TabIndex = 117
        '
        'cb_Localidad_Facturacion_Mod
        '
        Me.cb_Localidad_Facturacion_Mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_Localidad_Facturacion_Mod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_Localidad_Facturacion_Mod.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ModificacionClienteMayoristaDetalleBindingSource, "FacturacionLocalidadesSaleccionada", True))
        Me.cb_Localidad_Facturacion_Mod.DataSource = Me.ModificacionClienteFacturacionLocalidadesBindingSource
        Me.cb_Localidad_Facturacion_Mod.DisplayMember = "Value"
        Me.cb_Localidad_Facturacion_Mod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Localidad_Facturacion_Mod.FormattingEnabled = True
        Me.cb_Localidad_Facturacion_Mod.Location = New System.Drawing.Point(143, 94)
        Me.cb_Localidad_Facturacion_Mod.Name = "cb_Localidad_Facturacion_Mod"
        Me.cb_Localidad_Facturacion_Mod.Size = New System.Drawing.Size(214, 23)
        Me.cb_Localidad_Facturacion_Mod.TabIndex = 115
        Me.cb_Localidad_Facturacion_Mod.ValueMember = "Key"
        '
        'ModificacionClienteFacturacionLocalidadesBindingSource
        '
        Me.ModificacionClienteFacturacionLocalidadesBindingSource.DataMember = "FacturacionLocalidades"
        Me.ModificacionClienteFacturacionLocalidadesBindingSource.DataSource = Me.ModificacionClienteMayoristaDetalleBindingSource
        '
        'txt_CodigoPostal_Facturacion_Mod
        '
        Me.txt_CodigoPostal_Facturacion_Mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_CodigoPostal_Facturacion_Mod.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ModificacionClienteMayoristaDetalleBindingSource, "FacturacionCodigoPostal", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_CodigoPostal_Facturacion_Mod.Location = New System.Drawing.Point(143, 124)
        Me.txt_CodigoPostal_Facturacion_Mod.MaxLength = 255
        Me.txt_CodigoPostal_Facturacion_Mod.Name = "txt_CodigoPostal_Facturacion_Mod"
        Me.txt_CodigoPostal_Facturacion_Mod.Size = New System.Drawing.Size(214, 21)
        Me.txt_CodigoPostal_Facturacion_Mod.TabIndex = 116
        '
        'cb_Distrito_Facturacion_Mod
        '
        Me.cb_Distrito_Facturacion_Mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_Distrito_Facturacion_Mod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_Distrito_Facturacion_Mod.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ModificacionClienteMayoristaDetalleBindingSource, "FacturacionDistritosSaleccionada", True))
        Me.cb_Distrito_Facturacion_Mod.DataSource = Me.ModificacionClienteFacturacionDistritosBindingSource
        Me.cb_Distrito_Facturacion_Mod.DisplayMember = "Value"
        Me.cb_Distrito_Facturacion_Mod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Distrito_Facturacion_Mod.FormattingEnabled = True
        Me.cb_Distrito_Facturacion_Mod.Location = New System.Drawing.Point(143, 64)
        Me.cb_Distrito_Facturacion_Mod.Name = "cb_Distrito_Facturacion_Mod"
        Me.cb_Distrito_Facturacion_Mod.Size = New System.Drawing.Size(214, 23)
        Me.cb_Distrito_Facturacion_Mod.TabIndex = 114
        Me.cb_Distrito_Facturacion_Mod.ValueMember = "Key"
        '
        'ModificacionClienteFacturacionDistritosBindingSource
        '
        Me.ModificacionClienteFacturacionDistritosBindingSource.DataMember = "FacturacionDistritos"
        Me.ModificacionClienteFacturacionDistritosBindingSource.DataSource = Me.ModificacionClienteMayoristaDetalleBindingSource
        '
        'cb_Provincia_Facturacion_Mod
        '
        Me.cb_Provincia_Facturacion_Mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_Provincia_Facturacion_Mod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_Provincia_Facturacion_Mod.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ModificacionClienteMayoristaDetalleBindingSource, "FacturacionProvinciasSaleccionada", True))
        Me.cb_Provincia_Facturacion_Mod.DataSource = Me.ModificacionClienteFacturacionProvinciasBindingSource
        Me.cb_Provincia_Facturacion_Mod.DisplayMember = "Value"
        Me.cb_Provincia_Facturacion_Mod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Provincia_Facturacion_Mod.FormattingEnabled = True
        Me.cb_Provincia_Facturacion_Mod.Location = New System.Drawing.Point(143, 34)
        Me.cb_Provincia_Facturacion_Mod.Name = "cb_Provincia_Facturacion_Mod"
        Me.cb_Provincia_Facturacion_Mod.Size = New System.Drawing.Size(214, 23)
        Me.cb_Provincia_Facturacion_Mod.TabIndex = 113
        Me.cb_Provincia_Facturacion_Mod.ValueMember = "Key"
        '
        'ModificacionClienteFacturacionProvinciasBindingSource
        '
        Me.ModificacionClienteFacturacionProvinciasBindingSource.DataMember = "FacturacionProvincias"
        Me.ModificacionClienteFacturacionProvinciasBindingSource.DataSource = Me.ModificacionClienteMayoristaDetalleBindingSource
        '
        'txt_Direccion_Facturacion_Mod
        '
        Me.txt_Direccion_Facturacion_Mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Direccion_Facturacion_Mod.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ModificacionClienteMayoristaDetalleBindingSource, "FacturacionDireccion", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_Direccion_Facturacion_Mod.Location = New System.Drawing.Point(143, 4)
        Me.txt_Direccion_Facturacion_Mod.MaxLength = 255
        Me.txt_Direccion_Facturacion_Mod.Name = "txt_Direccion_Facturacion_Mod"
        Me.txt_Direccion_Facturacion_Mod.Size = New System.Drawing.Size(214, 21)
        Me.txt_Direccion_Facturacion_Mod.TabIndex = 112
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 15)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Provincia (*)"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 15)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Distrito (*)"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 97)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 15)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Localidad (*)"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 127)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 15)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Código Postal (*)"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 157)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 15)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Teléfono"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 189)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 15)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Mail"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 7)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 15)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Direccion (*)"
        '
        'TableLayoutPanel11
        '
        Me.TableLayoutPanel11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel11.ColumnCount = 2
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel11.Controls.Add(Me.Label13, 0, 0)
        Me.TableLayoutPanel11.Controls.Add(Me.txt_Observaciones_Mod, 1, 0)
        Me.TableLayoutPanel11.Location = New System.Drawing.Point(6, 567)
        Me.TableLayoutPanel11.Name = "TableLayoutPanel11"
        Me.TableLayoutPanel11.RowCount = 1
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel11.Size = New System.Drawing.Size(756, 77)
        Me.TableLayoutPanel11.TabIndex = 87
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(3, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 15)
        Me.Label13.TabIndex = 85
        Me.Label13.Text = "Observaciones"
        '
        'txt_Observaciones_Mod
        '
        Me.txt_Observaciones_Mod.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ModificacionClienteMayoristaDetalleBindingSource, "Observaciones", True))
        Me.txt_Observaciones_Mod.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Observaciones_Mod.Location = New System.Drawing.Point(143, 3)
        Me.txt_Observaciones_Mod.MaxLength = 255
        Me.txt_Observaciones_Mod.Multiline = True
        Me.txt_Observaciones_Mod.Name = "txt_Observaciones_Mod"
        Me.txt_Observaciones_Mod.Size = New System.Drawing.Size(610, 71)
        Me.txt_Observaciones_Mod.TabIndex = 124
        '
        'TableLayoutPanel12
        '
        Me.TableLayoutPanel12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel12.ColumnCount = 5
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel12.Controls.Add(Me.Label14, 0, 0)
        Me.TableLayoutPanel12.Controls.Add(Me.cmb_Empresa_Mod, 1, 0)
        Me.TableLayoutPanel12.Controls.Add(Me.Label15, 3, 0)
        Me.TableLayoutPanel12.Controls.Add(Me.cb_ListaPrecios_Mod, 4, 0)
        Me.TableLayoutPanel12.Location = New System.Drawing.Point(6, 268)
        Me.TableLayoutPanel12.Name = "TableLayoutPanel12"
        Me.TableLayoutPanel12.RowCount = 1
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39.0!))
        Me.TableLayoutPanel12.Size = New System.Drawing.Size(756, 39)
        Me.TableLayoutPanel12.TabIndex = 88
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(3, 12)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 15)
        Me.Label14.TabIndex = 81
        Me.Label14.Text = "Empresa"
        '
        'cmb_Empresa_Mod
        '
        Me.cmb_Empresa_Mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_Empresa_Mod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmb_Empresa_Mod.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.ModificacionClienteMayoristaDetalleBindingSource, "EmpresaSaleccionada", True))
        Me.cmb_Empresa_Mod.DataSource = Me.EmpresasBindingSource
        Me.cmb_Empresa_Mod.DisplayMember = "Value"
        Me.cmb_Empresa_Mod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Empresa_Mod.FormattingEnabled = True
        Me.cmb_Empresa_Mod.ItemHeight = 15
        Me.cmb_Empresa_Mod.Location = New System.Drawing.Point(143, 9)
        Me.cmb_Empresa_Mod.Name = "cmb_Empresa_Mod"
        Me.cmb_Empresa_Mod.Size = New System.Drawing.Size(212, 23)
        Me.cmb_Empresa_Mod.TabIndex = 19
        Me.cmb_Empresa_Mod.ValueMember = "Key"
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(401, 12)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(110, 15)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "Lista de Precios (*)"
        '
        'cb_ListaPrecios_Mod
        '
        Me.cb_ListaPrecios_Mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_ListaPrecios_Mod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_ListaPrecios_Mod.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.ModificacionClienteMayoristaDetalleBindingSource, "ListaPreciosSaleccionada", True))
        Me.cb_ListaPrecios_Mod.DataSource = Me.ModificacionClienteListasPreciosBindingSource
        Me.cb_ListaPrecios_Mod.DisplayMember = "Value"
        Me.cb_ListaPrecios_Mod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_ListaPrecios_Mod.FormattingEnabled = True
        Me.cb_ListaPrecios_Mod.ItemHeight = 15
        Me.cb_ListaPrecios_Mod.Location = New System.Drawing.Point(541, 9)
        Me.cb_ListaPrecios_Mod.Name = "cb_ListaPrecios_Mod"
        Me.cb_ListaPrecios_Mod.Size = New System.Drawing.Size(212, 23)
        Me.cb_ListaPrecios_Mod.TabIndex = 12
        Me.cb_ListaPrecios_Mod.ValueMember = "Key"
        '
        'TableLayoutPanel13
        '
        Me.TableLayoutPanel13.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel13.ColumnCount = 2
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel13.Controls.Add(Me.Label16, 0, 0)
        Me.TableLayoutPanel13.Controls.Add(Me.txt_CondicionPago_Mod, 1, 0)
        Me.TableLayoutPanel13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel13.Location = New System.Drawing.Point(6, 185)
        Me.TableLayoutPanel13.Name = "TableLayoutPanel13"
        Me.TableLayoutPanel13.RowCount = 1
        Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel13.Size = New System.Drawing.Size(756, 77)
        Me.TableLayoutPanel13.TabIndex = 90
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(3, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(110, 15)
        Me.Label16.TabIndex = 19
        Me.Label16.Text = "Condición de pago"
        '
        'txt_CondicionPago_Mod
        '
        Me.txt_CondicionPago_Mod.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ModificacionClienteMayoristaDetalleBindingSource, "CondicionPago", True))
        Me.txt_CondicionPago_Mod.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_CondicionPago_Mod.Location = New System.Drawing.Point(143, 3)
        Me.txt_CondicionPago_Mod.MaxLength = 255
        Me.txt_CondicionPago_Mod.Multiline = True
        Me.txt_CondicionPago_Mod.Name = "txt_CondicionPago_Mod"
        Me.txt_CondicionPago_Mod.Size = New System.Drawing.Size(610, 71)
        Me.txt_CondicionPago_Mod.TabIndex = 109
        '
        'TableLayoutPanel14
        '
        Me.TableLayoutPanel14.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel14.ColumnCount = 5
        Me.TableLayoutPanel14.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.TableLayoutPanel14.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel14.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel14.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.TableLayoutPanel14.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel14.Controls.Add(Me.Label18, 0, 0)
        Me.TableLayoutPanel14.Controls.Add(Me.Label29, 0, 1)
        Me.TableLayoutPanel14.Controls.Add(Me.txt_RazonSocial_mod, 1, 0)
        Me.TableLayoutPanel14.Controls.Add(Me.Label31, 0, 3)
        Me.TableLayoutPanel14.Controls.Add(Me.Label33, 0, 4)
        Me.TableLayoutPanel14.Controls.Add(Me.txt_Cuit_Mod, 1, 1)
        Me.TableLayoutPanel14.Controls.Add(Me.Button2, 2, 3)
        Me.TableLayoutPanel14.Controls.Add(Me.cmb_Corredor_Mod, 1, 2)
        Me.TableLayoutPanel14.Controls.Add(Me.Label34, 3, 4)
        Me.TableLayoutPanel14.Controls.Add(Me.txt_Nombre_Mod, 4, 0)
        Me.TableLayoutPanel14.Controls.Add(Me.cb_CondicionIva_Mod, 4, 1)
        Me.TableLayoutPanel14.Controls.Add(Me.txt_Transporte_Mod, 1, 3)
        Me.TableLayoutPanel14.Controls.Add(Me.Label35, 0, 2)
        Me.TableLayoutPanel14.Controls.Add(Me.Label36, 3, 2)
        Me.TableLayoutPanel14.Controls.Add(Me.Label37, 3, 0)
        Me.TableLayoutPanel14.Controls.Add(Me.Label38, 3, 1)
        Me.TableLayoutPanel14.Controls.Add(Me.txt_Comision_Mod, 4, 2)
        Me.TableLayoutPanel14.Controls.Add(Me.txt_Lista_Mod, 4, 4)
        Me.TableLayoutPanel14.Controls.Add(Me.PercentUpDown1, 1, 4)
        Me.TableLayoutPanel14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel14.Location = New System.Drawing.Point(6, 20)
        Me.TableLayoutPanel14.Name = "TableLayoutPanel14"
        Me.TableLayoutPanel14.RowCount = 5
        Me.TableLayoutPanel14.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel14.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel14.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel14.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.TableLayoutPanel14.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel14.Size = New System.Drawing.Size(756, 159)
        Me.TableLayoutPanel14.TabIndex = 89
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(3, 7)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(96, 15)
        Me.Label18.TabIndex = 1
        Me.Label18.Text = "Razón Social (*)"
        '
        'Label29
        '
        Me.Label29.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(3, 37)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(44, 15)
        Me.Label29.TabIndex = 7
        Me.Label29.Text = "Cuit (*)"
        '
        'txt_RazonSocial_mod
        '
        Me.txt_RazonSocial_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_RazonSocial_mod.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ModificacionClienteMayoristaDetalleBindingSource, "RazonSocial", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_RazonSocial_mod.Location = New System.Drawing.Point(143, 4)
        Me.txt_RazonSocial_mod.MaxLength = 255
        Me.txt_RazonSocial_mod.Name = "txt_RazonSocial_mod"
        Me.txt_RazonSocial_mod.Size = New System.Drawing.Size(212, 21)
        Me.txt_RazonSocial_mod.TabIndex = 100
        '
        'Label31
        '
        Me.Label31.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(3, 99)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(66, 15)
        Me.Label31.TabIndex = 9
        Me.Label31.Text = "Transporte"
        '
        'Label33
        '
        Me.Label33.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(3, 134)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(104, 15)
        Me.Label33.TabIndex = 77
        Me.Label33.Text = "Bonificación % (*)"
        '
        'txt_Cuit_Mod
        '
        Me.txt_Cuit_Mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Cuit_Mod.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ModificacionClienteMayoristaDetalleBindingSource, "Cuit", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_Cuit_Mod.Location = New System.Drawing.Point(143, 34)
        Me.txt_Cuit_Mod.Mask = "99-99999999-9"
        Me.txt_Cuit_Mod.Name = "txt_Cuit_Mod"
        Me.txt_Cuit_Mod.Size = New System.Drawing.Size(212, 21)
        Me.txt_Cuit_Mod.TabIndex = 102
        Me.txt_Cuit_Mod.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Button2
        '
        Me.Button2.Image = Global.SistemaCinderella.My.Resources.Recursos.IconoBuscar24
        Me.Button2.Location = New System.Drawing.Point(361, 93)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(33, 28)
        Me.Button2.TabIndex = 129
        Me.ToolCliente.SetToolTip(Me.Button2, "Buscar transporte")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cmb_Corredor_Mod
        '
        Me.cmb_Corredor_Mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_Corredor_Mod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmb_Corredor_Mod.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.ModificacionClienteMayoristaDetalleBindingSource, "CorredorSaleccionada", True))
        Me.cmb_Corredor_Mod.DataSource = Me.CorredoresBindingSource
        Me.cmb_Corredor_Mod.DisplayMember = "Value"
        Me.cmb_Corredor_Mod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Corredor_Mod.FormattingEnabled = True
        Me.cmb_Corredor_Mod.Location = New System.Drawing.Point(143, 64)
        Me.cmb_Corredor_Mod.Name = "cmb_Corredor_Mod"
        Me.cmb_Corredor_Mod.Size = New System.Drawing.Size(212, 23)
        Me.cmb_Corredor_Mod.TabIndex = 104
        Me.cmb_Corredor_Mod.ValueMember = "Key"
        '
        'Label34
        '
        Me.Label34.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(401, 134)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(63, 15)
        Me.Label34.TabIndex = 79
        Me.Label34.Text = "Lista % (*)"
        '
        'txt_Nombre_Mod
        '
        Me.txt_Nombre_Mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Nombre_Mod.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ModificacionClienteMayoristaDetalleBindingSource, "Nombre", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_Nombre_Mod.Location = New System.Drawing.Point(541, 4)
        Me.txt_Nombre_Mod.MaxLength = 255
        Me.txt_Nombre_Mod.Name = "txt_Nombre_Mod"
        Me.txt_Nombre_Mod.Size = New System.Drawing.Size(212, 21)
        Me.txt_Nombre_Mod.TabIndex = 101
        '
        'cb_CondicionIva_Mod
        '
        Me.cb_CondicionIva_Mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_CondicionIva_Mod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_CondicionIva_Mod.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.ModificacionClienteMayoristaDetalleBindingSource, "CondicionesIVASaleccionada", True))
        Me.cb_CondicionIva_Mod.DataSource = Me.ModificacionClienteCondicionesIVABindingSource
        Me.cb_CondicionIva_Mod.DisplayMember = "Value"
        Me.cb_CondicionIva_Mod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_CondicionIva_Mod.FormattingEnabled = True
        Me.cb_CondicionIva_Mod.Location = New System.Drawing.Point(541, 34)
        Me.cb_CondicionIva_Mod.Name = "cb_CondicionIva_Mod"
        Me.cb_CondicionIva_Mod.Size = New System.Drawing.Size(212, 23)
        Me.cb_CondicionIva_Mod.TabIndex = 103
        Me.cb_CondicionIva_Mod.ValueMember = "Key"
        '
        'txt_Transporte_Mod
        '
        Me.txt_Transporte_Mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Transporte_Mod.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ModificacionClienteMayoristaDetalleBindingSource, "Transporte", True))
        Me.txt_Transporte_Mod.Location = New System.Drawing.Point(143, 96)
        Me.txt_Transporte_Mod.MaxLength = 255
        Me.txt_Transporte_Mod.Name = "txt_Transporte_Mod"
        Me.txt_Transporte_Mod.Size = New System.Drawing.Size(212, 21)
        Me.txt_Transporte_Mod.TabIndex = 106
        '
        'Label35
        '
        Me.Label35.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(3, 67)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(55, 15)
        Me.Label35.TabIndex = 72
        Me.Label35.Text = "Corredor"
        '
        'Label36
        '
        Me.Label36.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(401, 67)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(89, 15)
        Me.Label36.TabIndex = 74
        Me.Label36.Text = "Comisión % (*)"
        '
        'Label37
        '
        Me.Label37.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(401, 7)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(68, 15)
        Me.Label37.TabIndex = 70
        Me.Label37.Text = "Nombre (*)"
        '
        'Label38
        '
        Me.Label38.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(401, 37)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(115, 15)
        Me.Label38.TabIndex = 22
        Me.Label38.Text = "Condición de IVA (*)"
        '
        'txt_Comision_Mod
        '
        Me.txt_Comision_Mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Comision_Mod.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ModificacionClienteMayoristaDetalleBindingSource, "PorcentajeComision", True))
        Me.txt_Comision_Mod.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.txt_Comision_Mod.Location = New System.Drawing.Point(541, 64)
        Me.txt_Comision_Mod.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txt_Comision_Mod.Name = "txt_Comision_Mod"
        Me.txt_Comision_Mod.Size = New System.Drawing.Size(212, 21)
        Me.txt_Comision_Mod.TabIndex = 130
        Me.txt_Comision_Mod.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txt_Lista_Mod
        '
        Me.txt_Lista_Mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Lista_Mod.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ModificacionClienteMayoristaDetalleBindingSource, "PorcentajeLista", True))
        Me.txt_Lista_Mod.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.txt_Lista_Mod.Location = New System.Drawing.Point(541, 131)
        Me.txt_Lista_Mod.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txt_Lista_Mod.Name = "txt_Lista_Mod"
        Me.txt_Lista_Mod.Size = New System.Drawing.Size(212, 21)
        Me.txt_Lista_Mod.TabIndex = 131
        Me.txt_Lista_Mod.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'PercentUpDown1
        '
        Me.PercentUpDown1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PercentUpDown1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ModificacionClienteMayoristaDetalleBindingSource, "PorcentajeBonificacion", True))
        Me.PercentUpDown1.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.PercentUpDown1.Location = New System.Drawing.Point(143, 131)
        Me.PercentUpDown1.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.PercentUpDown1.Name = "PercentUpDown1"
        Me.PercentUpDown1.Size = New System.Drawing.Size(212, 21)
        Me.PercentUpDown1.TabIndex = 132
        Me.PercentUpDown1.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Cancelar.Image = Global.SistemaCinderella.My.Resources.Recursos.desconectado_32
        Me.Btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Cancelar.Location = New System.Drawing.Point(556, 650)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Cancelar.TabIndex = 128
        Me.Btn_Cancelar.Text = "Cancelar"
        Me.Btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolCliente.SetToolTip(Me.Btn_Cancelar, "Descarta los cambios y vuelve al listado de clientes")
        Me.Btn_Cancelar.UseVisualStyleBackColor = True
        '
        'Btn_Modificar
        '
        Me.Btn_Modificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Modificar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Modificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Modificar.Image = Global.SistemaCinderella.My.Resources.Recursos.Editar_24
        Me.Btn_Modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Modificar.Location = New System.Drawing.Point(662, 650)
        Me.Btn_Modificar.Name = "Btn_Modificar"
        Me.Btn_Modificar.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Modificar.TabIndex = 126
        Me.Btn_Modificar.Text = "Modificar"
        Me.Btn_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolCliente.SetToolTip(Me.Btn_Modificar, "Haz click aquí para modificar el cliente")
        Me.Btn_Modificar.UseVisualStyleBackColor = False
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Image = Global.SistemaCinderella.My.Resources.Recursos.Boton_Editar
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewImageColumn1.ToolTipText = "Modificar Perfil"
        Me.DataGridViewImageColumn1.Width = 60
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.HeaderText = ""
        Me.DataGridViewImageColumn2.Image = Global.SistemaCinderella.My.Resources.Recursos.Boton_Eliminar
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.ReadOnly = True
        Me.DataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewImageColumn2.ToolTipText = "Eliminar Perfil"
        Me.DataGridViewImageColumn2.Width = 60
        '
        'ToolCliente
        '
        Me.ToolCliente.IsBalloon = True
        Me.ToolCliente.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolCliente.ToolTipTitle = "Ayuda."
        '
        'frmClienteMayorista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(794, 754)
        Me.Controls.Add(Me.tabControl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmClienteMayorista"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administración de Clientes"
        Me.tabControl.ResumeLayout(False)
        Me.TbListado.ResumeLayout(False)
        Me.TbListado.PerformLayout()
        CType(Me.FrmClienteMayoristaViewModelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.DG_Clientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AltaClienteFiltroClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.TableLayoutPanel16.ResumeLayout(False)
        Me.TableLayoutPanel16.PerformLayout()
        CType(Me.ModificacionClienteMayoristaDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModificacionClienteListasPreciosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModificacionClienteCondicionesIVABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CorredoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PercentUpDown5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PercentUpDown6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PercentUpDown7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_Buscar.ResumeLayout(False)
        Me.TableLayoutPanel15.ResumeLayout(False)
        Me.TableLayoutPanel15.PerformLayout()
        CType(Me.FiltroCondicionesIVABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FiltroListasPreciosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HabilitadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TbAlta.ResumeLayout(False)
        Me.GB_Alta.ResumeLayout(False)
        Me.GB_Alta.PerformLayout()
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        CType(Me.AltaClienteMayoristaDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AltaClienteEntregaLocalidadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AltaClienteEntregaDistritosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AltaClienteEntregaProvinciasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        CType(Me.AltaClienteFacturacionLocalidadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AltaClienteFacturacionDistritosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AltaClienteFacturacionProvinciasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.AltaClienteListasPreciosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.AltaClienteCondicionesIVABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PercentUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PercentUpDown3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PercentUpDown4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TbMod.ResumeLayout(False)
        Me.GB_Modificacion.ResumeLayout(False)
        Me.TableLayoutPanel18.ResumeLayout(False)
        Me.TableLayoutPanel18.PerformLayout()
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.TableLayoutPanel9.ResumeLayout(False)
        Me.TableLayoutPanel9.PerformLayout()
        CType(Me.ModificacionClienteEntregaLocalidadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModificacionClienteEntregaDistritosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModificacionClienteEntregaProvinciasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.TableLayoutPanel10.ResumeLayout(False)
        Me.TableLayoutPanel10.PerformLayout()
        CType(Me.ModificacionClienteFacturacionLocalidadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModificacionClienteFacturacionDistritosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModificacionClienteFacturacionProvinciasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel11.ResumeLayout(False)
        Me.TableLayoutPanel11.PerformLayout()
        Me.TableLayoutPanel12.ResumeLayout(False)
        Me.TableLayoutPanel12.PerformLayout()
        Me.TableLayoutPanel13.ResumeLayout(False)
        Me.TableLayoutPanel13.PerformLayout()
        Me.TableLayoutPanel14.ResumeLayout(False)
        Me.TableLayoutPanel14.PerformLayout()
        CType(Me.txt_Comision_Mod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Lista_Mod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PercentUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabControl As System.Windows.Forms.TabControl
    Friend WithEvents TbListado As System.Windows.Forms.TabPage
    Friend WithEvents TbAlta As System.Windows.Forms.TabPage
    Friend WithEvents GB_Alta As System.Windows.Forms.GroupBox
    Friend WithEvents txt_RazonSocial As System.Windows.Forms.TextBox
    Friend WithEvents lbl_RazonSocial As System.Windows.Forms.Label
    Friend WithEvents Btn_Agregar As System.Windows.Forms.Button
    Friend WithEvents TbMod As System.Windows.Forms.TabPage
    Friend WithEvents GB_Modificacion As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_Modificar As System.Windows.Forms.Button
    Friend WithEvents GB_Buscar As System.Windows.Forms.GroupBox
    Friend WithEvents txt_RazonSocial_Filtro As System.Windows.Forms.TextBox
    Friend WithEvents lbl_descripcion_bus As System.Windows.Forms.Label
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents txt_CodigoPostal_Facturacion As System.Windows.Forms.TextBox
    Friend WithEvents lbl_CodigoPostal As System.Windows.Forms.Label
    Friend WithEvents txt_Direccion_Facturacion As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Direccion As System.Windows.Forms.Label
    Friend WithEvents txt_Transporte As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Transporte As System.Windows.Forms.Label
    Friend WithEvents lbl_Cuit As System.Windows.Forms.Label
    Friend WithEvents txt_Observaciones As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Observaciones As System.Windows.Forms.Label
    Friend WithEvents txt_Mail_Facturacion As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Mail As System.Windows.Forms.Label
    Friend WithEvents txt_Telefono_Facturacion As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Telefono As System.Windows.Forms.Label
    Friend WithEvents cb_Localidad_Facturacion As System.Windows.Forms.ComboBox
    Friend WithEvents cb_Distrito_Facturacion As System.Windows.Forms.ComboBox
    Friend WithEvents cb_Provincia_Facturacion As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_Provincia As System.Windows.Forms.Label
    Friend WithEvents lbl_Distrito As System.Windows.Forms.Label
    Friend WithEvents lbl_Localidad As System.Windows.Forms.Label
    Friend WithEvents cb_CondicionIva As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_CondicionIva As System.Windows.Forms.Label
    Friend WithEvents lbl_ListaPrecio As System.Windows.Forms.Label
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents btn_Restablecer As System.Windows.Forms.Button
    Friend WithEvents ToolCliente As System.Windows.Forms.ToolTip
    Friend WithEvents Btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents txt_Cuit As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_Nombre As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label21 As Label
    Friend WithEvents cmb_Corredor As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents txt_CondicionPago As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txt_Direccion_Entrega As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents cb_Provincia_Entrega As ComboBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents cb_Distrito_Entrega As ComboBox
    Friend WithEvents cb_Localidad_Entrega As ComboBox
    Friend WithEvents txt_CodigoPostal_Entrega As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmb_Empresa As ComboBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents cb_ListaPrecios As ComboBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents cb_Localidad_Entrega_Mod As ComboBox
    Friend WithEvents txt_CodigoPostal_Entrega_Mod As TextBox
    Friend WithEvents cb_Distrito_Entrega_Mod As ComboBox
    Friend WithEvents cb_Provincia_Entrega_Mod As ComboBox
    Friend WithEvents txt_Direccion_Entrega_Mod As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TableLayoutPanel10 As TableLayoutPanel
    Friend WithEvents txt_Mail_Facturacion_Mod As TextBox
    Friend WithEvents txt_Telefono_Facturacion_Mod As TextBox
    Friend WithEvents cb_Localidad_Facturacion_Mod As ComboBox
    Friend WithEvents txt_CodigoPostal_Facturacion_Mod As TextBox
    Friend WithEvents cb_Distrito_Facturacion_Mod As ComboBox
    Friend WithEvents cb_Provincia_Facturacion_Mod As ComboBox
    Friend WithEvents txt_Direccion_Facturacion_Mod As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TableLayoutPanel11 As TableLayoutPanel
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_Observaciones_Mod As TextBox
    Friend WithEvents TableLayoutPanel12 As TableLayoutPanel
    Friend WithEvents Label14 As Label
    Friend WithEvents cmb_Empresa_Mod As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents cb_ListaPrecios_Mod As ComboBox
    Friend WithEvents TableLayoutPanel13 As TableLayoutPanel
    Friend WithEvents Label16 As Label
    Friend WithEvents txt_CondicionPago_Mod As TextBox
    Friend WithEvents TableLayoutPanel14 As TableLayoutPanel
    Friend WithEvents Label18 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents txt_RazonSocial_mod As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents txt_Cuit_Mod As MaskedTextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents cmb_Corredor_Mod As ComboBox
    Friend WithEvents Label34 As Label
    Friend WithEvents txt_Nombre_Mod As TextBox
    Friend WithEvents cb_CondicionIva_Mod As ComboBox
    Friend WithEvents txt_Transporte_Mod As TextBox
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents TableLayoutPanel15 As TableLayoutPanel
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents TableLayoutPanel16 As TableLayoutPanel
    Friend WithEvents Label48 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents Label47 As Label
    Friend WithEvents txt_Mail_Buscar As TextBox
    Friend WithEvents txt_Direccion_Buscar As TextBox
    Friend WithEvents txt_Telefono_Buscar As TextBox
    Friend WithEvents cmb_ListaPrecio_Buscar As ComboBox
    Friend WithEvents cmb_CondicionIVA_Buscar As ComboBox
    Friend WithEvents Label49 As Label
    Friend WithEvents txt_TotalSaldoCuentaCorriente As TextBox
    Friend WithEvents Label50 As Label
    Friend WithEvents txt_Cuit_Filtro As TextBox
    Friend WithEvents Label39 As Label
    Friend WithEvents cmb_Corredor_Buscar As ComboBox
    Friend WithEvents lbl_Msg As Label
    Friend WithEvents TableLayoutPanel18 As TableLayoutPanel
    Friend WithEvents Label51 As Label
    Friend WithEvents chk_Habilitado_Mod As CheckBox
    Friend WithEvents Label52 As Label
    Friend WithEvents cmb_Corredor_Filtro As ComboBox
    Friend WithEvents Label53 As Label
    Friend WithEvents cmb_CondicionIVA_Filtro As ComboBox
    Friend WithEvents Label54 As Label
    Friend WithEvents cmb_ListaPrecios_Filtro As ComboBox
    Friend WithEvents Label55 As Label
    Friend WithEvents cmb_Empresa_Filtro As ComboBox
    Friend WithEvents FrmClienteMayoristaViewModelBindingSource As BindingSource
    Friend WithEvents cmb_Habilitado_Filtro As ComboBox
    Friend WithEvents KeyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValueDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ComisionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BonificacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ListaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CondicionPagoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FiltroCondicionesIVASaleccionadaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FiltroCorredorSaleccionadaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TransporteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmpresaSaleccionadaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ListaPreciosSaleccionadaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DireccionFacturacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DireccionEntregaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ObservacionesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AltaClienteMayoristaDetalleBindingSource As BindingSource
    Friend WithEvents AltaClienteFiltroClientesBindingSource As BindingSource
    Friend WithEvents CorredoresBindingSource As BindingSource
    Friend WithEvents FiltroCondicionesIVABindingSource As BindingSource
    Friend WithEvents FiltroListasPreciosBindingSource As BindingSource
    Friend WithEvents EmpresasBindingSource As BindingSource
    Friend WithEvents HabilitadosBindingSource As BindingSource
    Friend WithEvents ModificacionClienteMayoristaDetalleBindingSource As BindingSource
    Friend WithEvents AltaClienteEntregaLocalidadesBindingSource As BindingSource
    Friend WithEvents AltaClienteEntregaDistritosBindingSource As BindingSource
    Friend WithEvents AltaClienteEntregaProvinciasBindingSource As BindingSource
    Friend WithEvents AltaClienteFacturacionLocalidadesBindingSource As BindingSource
    Friend WithEvents AltaClienteFacturacionDistritosBindingSource As BindingSource
    Friend WithEvents ModificacionClienteEntregaLocalidadesBindingSource As BindingSource
    Friend WithEvents ModificacionClienteEntregaDistritosBindingSource As BindingSource
    Friend WithEvents ModificacionClienteEntregaProvinciasBindingSource As BindingSource
    Friend WithEvents ModificacionClienteFacturacionLocalidadesBindingSource As BindingSource
    Friend WithEvents ModificacionClienteFacturacionDistritosBindingSource As BindingSource
    Friend WithEvents ModificacionClienteFacturacionProvinciasBindingSource As BindingSource
    Friend WithEvents AltaClienteFacturacionProvinciasBindingSource As BindingSource
    Friend WithEvents Paginado As Paginado
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents DG_Clientes As DataGridView
    Friend WithEvents CodigoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AltaClienteListasPreciosBindingSource As BindingSource
    Friend WithEvents AltaClienteCondicionesIVABindingSource As BindingSource
    Friend WithEvents ModificacionClienteListasPreciosBindingSource As BindingSource
    Friend WithEvents ModificacionClienteCondicionesIVABindingSource As BindingSource
    Friend WithEvents txt_Comision_Mod As Controles.PercentUpDown
    Friend WithEvents txt_Lista_Mod As Controles.PercentUpDown
    Friend WithEvents PercentUpDown1 As Controles.PercentUpDown
    Friend WithEvents PercentUpDown2 As Controles.PercentUpDown
    Friend WithEvents PercentUpDown3 As Controles.PercentUpDown
    Friend WithEvents PercentUpDown4 As Controles.PercentUpDown
    Friend WithEvents PercentUpDown5 As Controles.PercentUpDown
    Friend WithEvents PercentUpDown6 As Controles.PercentUpDown
    Friend WithEvents PercentUpDown7 As Controles.PercentUpDown
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents RazonSocialDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CuitDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NotaPedidoMontoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CuentaCorrienteMontoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Modificar As DataGridViewImageColumn
    Friend WithEvents Eliminar As DataGridViewImageColumn
End Class
