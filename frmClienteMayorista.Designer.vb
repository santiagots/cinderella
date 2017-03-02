<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmClienteMayorista
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClienteMayorista))
        Me.tabControl = New System.Windows.Forms.TabControl()
        Me.TbListado = New System.Windows.Forms.TabPage()
        Me.lbl_Msg = New System.Windows.Forms.Label()
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
        Me.txt_Comision_Buscar = New System.Windows.Forms.TextBox()
        Me.ClienteMayoristaModificacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txt_Bonificacion_Buscar = New System.Windows.Forms.TextBox()
        Me.txt_Lista_Buscar = New System.Windows.Forms.TextBox()
        Me.txt_Direccion_Buscar = New System.Windows.Forms.TextBox()
        Me.DireccionFacturacionModificacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txt_Telefono_Buscar = New System.Windows.Forms.TextBox()
        Me.cmb_ListaPrecio_Buscar = New System.Windows.Forms.ComboBox()
        Me.cmb_CondicionIVA_Buscar = New System.Windows.Forms.ComboBox()
        Me.cmb_Corredor_Buscar = New System.Windows.Forms.ComboBox()
        Me.txt_Mail_Buscar = New System.Windows.Forms.TextBox()
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
        Me.Label54 = New System.Windows.Forms.Label()
        Me.cmb_ListaPrecios_Filtro = New System.Windows.Forms.ComboBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel17 = New System.Windows.Forms.TableLayoutPanel()
        Me.Rb_Habilitado_Si = New System.Windows.Forms.RadioButton()
        Me.Rb_Habilitado_No = New System.Windows.Forms.RadioButton()
        Me.Rb_Habilitado_Todos = New System.Windows.Forms.RadioButton()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.cmb_Empresa_Filtro = New System.Windows.Forms.ComboBox()
        Me.DG_Clientes = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RazonSocialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoCuentaCorriente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Eliminar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Modificar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ClienteMayoristaGrillaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbAlta = New System.Windows.Forms.TabPage()
        Me.GB_Alta = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.cb_Localidad_Entrega = New System.Windows.Forms.ComboBox()
        Me.DireccionEntregaAltaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txt_CodigoPostal_Entrega = New System.Windows.Forms.TextBox()
        Me.cb_Distrito_Entrega = New System.Windows.Forms.ComboBox()
        Me.cb_Provincia_Entrega = New System.Windows.Forms.ComboBox()
        Me.txt_Direccion_Entrega = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_Mail_Facturacion = New System.Windows.Forms.TextBox()
        Me.DireccionFacturacionAltaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txt_Telefono_Facturacion = New System.Windows.Forms.TextBox()
        Me.cb_Localidad_Facturacion = New System.Windows.Forms.ComboBox()
        Me.txt_CodigoPostal_Facturacion = New System.Windows.Forms.TextBox()
        Me.cb_Distrito_Facturacion = New System.Windows.Forms.ComboBox()
        Me.cb_Provincia_Facturacion = New System.Windows.Forms.ComboBox()
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
        Me.ClientesMayoristaAltaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.cmb_Empresa = New System.Windows.Forms.ComboBox()
        Me.lbl_ListaPrecio = New System.Windows.Forms.Label()
        Me.cb_ListaPrecios = New System.Windows.Forms.ComboBox()
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
        Me.txt_Lista = New System.Windows.Forms.TextBox()
        Me.cmb_Corredor = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txt_Comision = New System.Windows.Forms.TextBox()
        Me.txt_Bonificacion = New System.Windows.Forms.TextBox()
        Me.txt_Nombre = New System.Windows.Forms.TextBox()
        Me.cb_CondicionIva = New System.Windows.Forms.ComboBox()
        Me.txt_Transporte = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lbl_CondicionIva = New System.Windows.Forms.Label()
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
        Me.DireccionEntregaModificacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txt_CodigoPostal_Entrega_Mod = New System.Windows.Forms.TextBox()
        Me.cb_Distrito_Entrega_Mod = New System.Windows.Forms.ComboBox()
        Me.cb_Provincia_Entrega_Mod = New System.Windows.Forms.ComboBox()
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
        Me.txt_CodigoPostal_Facturacion_Mod = New System.Windows.Forms.TextBox()
        Me.cb_Distrito_Facturacion_Mod = New System.Windows.Forms.ComboBox()
        Me.cb_Provincia_Facturacion_Mod = New System.Windows.Forms.ComboBox()
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
        Me.txt_Lista_Mod = New System.Windows.Forms.TextBox()
        Me.cmb_Corredor_Mod = New System.Windows.Forms.ComboBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txt_Comision_Mod = New System.Windows.Forms.TextBox()
        Me.txt_Bonificacion_Mod = New System.Windows.Forms.TextBox()
        Me.txt_Nombre_Mod = New System.Windows.Forms.TextBox()
        Me.cb_CondicionIva_Mod = New System.Windows.Forms.ComboBox()
        Me.txt_Transporte_Mod = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.Btn_Eliminar = New System.Windows.Forms.Button()
        Me.Btn_Modificar = New System.Windows.Forms.Button()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ErrorCliente = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolCliente = New System.Windows.Forms.ToolTip(Me.components)
        Me.tabControl.SuspendLayout()
        Me.TbListado.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.TableLayoutPanel16.SuspendLayout()
        CType(Me.ClienteMayoristaModificacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DireccionFacturacionModificacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_Buscar.SuspendLayout()
        Me.TableLayoutPanel15.SuspendLayout()
        Me.TableLayoutPanel17.SuspendLayout()
        CType(Me.DG_Clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteMayoristaGrillaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TbAlta.SuspendLayout()
        Me.GB_Alta.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        CType(Me.DireccionEntregaAltaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.DireccionFacturacionAltaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel6.SuspendLayout()
        CType(Me.ClientesMayoristaAltaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TbMod.SuspendLayout()
        Me.GB_Modificacion.SuspendLayout()
        Me.TableLayoutPanel18.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TableLayoutPanel9.SuspendLayout()
        CType(Me.DireccionEntregaModificacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.TableLayoutPanel10.SuspendLayout()
        Me.TableLayoutPanel11.SuspendLayout()
        Me.TableLayoutPanel12.SuspendLayout()
        Me.TableLayoutPanel13.SuspendLayout()
        Me.TableLayoutPanel14.SuspendLayout()
        CType(Me.ErrorCliente, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TbListado.Controls.Add(Me.lbl_Msg)
        Me.TbListado.Controls.Add(Me.Label49)
        Me.TbListado.Controls.Add(Me.txt_TotalSaldoCuentaCorriente)
        Me.TbListado.Controls.Add(Me.GroupBox5)
        Me.TbListado.Controls.Add(Me.GB_Buscar)
        Me.TbListado.Controls.Add(Me.DG_Clientes)
        Me.TbListado.Location = New System.Drawing.Point(4, 29)
        Me.TbListado.Name = "TbListado"
        Me.TbListado.Padding = New System.Windows.Forms.Padding(3)
        Me.TbListado.Size = New System.Drawing.Size(786, 721)
        Me.TbListado.TabIndex = 0
        Me.TbListado.Text = "Clientes"
        Me.TbListado.UseVisualStyleBackColor = True
        '
        'lbl_Msg
        '
        Me.lbl_Msg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Msg.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lbl_Msg.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Msg.Location = New System.Drawing.Point(206, 322)
        Me.lbl_Msg.Name = "lbl_Msg"
        Me.lbl_Msg.Size = New System.Drawing.Size(374, 29)
        Me.lbl_Msg.TabIndex = 90
        Me.lbl_Msg.Text = "No se han encontrado clientes."
        Me.lbl_Msg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.txt_TotalSaldoCuentaCorriente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TotalSaldoCuentaCorriente.Location = New System.Drawing.Point(569, 503)
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
        Me.TableLayoutPanel16.Controls.Add(Me.txt_Comision_Buscar, 4, 0)
        Me.TableLayoutPanel16.Controls.Add(Me.txt_Bonificacion_Buscar, 1, 1)
        Me.TableLayoutPanel16.Controls.Add(Me.txt_Lista_Buscar, 4, 1)
        Me.TableLayoutPanel16.Controls.Add(Me.txt_Direccion_Buscar, 1, 3)
        Me.TableLayoutPanel16.Controls.Add(Me.txt_Telefono_Buscar, 4, 4)
        Me.TableLayoutPanel16.Controls.Add(Me.cmb_ListaPrecio_Buscar, 1, 2)
        Me.TableLayoutPanel16.Controls.Add(Me.cmb_CondicionIVA_Buscar, 4, 2)
        Me.TableLayoutPanel16.Controls.Add(Me.cmb_Corredor_Buscar, 1, 0)
        Me.TableLayoutPanel16.Controls.Add(Me.txt_Mail_Buscar, 1, 4)
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
        'txt_Comision_Buscar
        '
        Me.txt_Comision_Buscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Comision_Buscar.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteMayoristaModificacionBindingSource, "Comision", True))
        Me.txt_Comision_Buscar.Location = New System.Drawing.Point(540, 4)
        Me.txt_Comision_Buscar.MaxLength = 255
        Me.txt_Comision_Buscar.Name = "txt_Comision_Buscar"
        Me.txt_Comision_Buscar.ReadOnly = True
        Me.txt_Comision_Buscar.Size = New System.Drawing.Size(211, 21)
        Me.txt_Comision_Buscar.TabIndex = 87
        '
        'ClienteMayoristaModificacionBindingSource
        '
        Me.ClienteMayoristaModificacionBindingSource.DataSource = GetType(Entidades.ClienteMayorista)
        '
        'txt_Bonificacion_Buscar
        '
        Me.txt_Bonificacion_Buscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Bonificacion_Buscar.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteMayoristaModificacionBindingSource, "Bonificacion", True))
        Me.txt_Bonificacion_Buscar.Location = New System.Drawing.Point(143, 34)
        Me.txt_Bonificacion_Buscar.MaxLength = 255
        Me.txt_Bonificacion_Buscar.Name = "txt_Bonificacion_Buscar"
        Me.txt_Bonificacion_Buscar.ReadOnly = True
        Me.txt_Bonificacion_Buscar.Size = New System.Drawing.Size(211, 21)
        Me.txt_Bonificacion_Buscar.TabIndex = 88
        '
        'txt_Lista_Buscar
        '
        Me.txt_Lista_Buscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Lista_Buscar.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteMayoristaModificacionBindingSource, "RazonSocial", True))
        Me.txt_Lista_Buscar.Location = New System.Drawing.Point(540, 34)
        Me.txt_Lista_Buscar.MaxLength = 255
        Me.txt_Lista_Buscar.Name = "txt_Lista_Buscar"
        Me.txt_Lista_Buscar.ReadOnly = True
        Me.txt_Lista_Buscar.Size = New System.Drawing.Size(211, 21)
        Me.txt_Lista_Buscar.TabIndex = 89
        '
        'txt_Direccion_Buscar
        '
        Me.txt_Direccion_Buscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Direccion_Buscar.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DireccionFacturacionModificacionBindingSource, "Direccion", True))
        Me.txt_Direccion_Buscar.Location = New System.Drawing.Point(143, 94)
        Me.txt_Direccion_Buscar.MaxLength = 255
        Me.txt_Direccion_Buscar.Name = "txt_Direccion_Buscar"
        Me.txt_Direccion_Buscar.ReadOnly = True
        Me.txt_Direccion_Buscar.Size = New System.Drawing.Size(211, 21)
        Me.txt_Direccion_Buscar.TabIndex = 90
        '
        'DireccionFacturacionModificacionBindingSource
        '
        Me.DireccionFacturacionModificacionBindingSource.DataSource = GetType(Entidades.Direccion)
        '
        'txt_Telefono_Buscar
        '
        Me.txt_Telefono_Buscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Telefono_Buscar.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DireccionFacturacionModificacionBindingSource, "Telefono", True))
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
        Me.cmb_ListaPrecio_Buscar.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ClienteMayoristaModificacionBindingSource, "IdListaPrecio", True))
        Me.cmb_ListaPrecio_Buscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ListaPrecio_Buscar.Enabled = False
        Me.cmb_ListaPrecio_Buscar.FormattingEnabled = True
        Me.cmb_ListaPrecio_Buscar.Location = New System.Drawing.Point(143, 63)
        Me.cmb_ListaPrecio_Buscar.Name = "cmb_ListaPrecio_Buscar"
        Me.cmb_ListaPrecio_Buscar.Size = New System.Drawing.Size(211, 23)
        Me.cmb_ListaPrecio_Buscar.TabIndex = 93
        '
        'cmb_CondicionIVA_Buscar
        '
        Me.cmb_CondicionIVA_Buscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_CondicionIVA_Buscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmb_CondicionIVA_Buscar.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ClienteMayoristaModificacionBindingSource, "IdCondicionIva", True))
        Me.cmb_CondicionIVA_Buscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_CondicionIVA_Buscar.Enabled = False
        Me.cmb_CondicionIVA_Buscar.FormattingEnabled = True
        Me.cmb_CondicionIVA_Buscar.Location = New System.Drawing.Point(540, 63)
        Me.cmb_CondicionIVA_Buscar.Name = "cmb_CondicionIVA_Buscar"
        Me.cmb_CondicionIVA_Buscar.Size = New System.Drawing.Size(211, 23)
        Me.cmb_CondicionIVA_Buscar.TabIndex = 94
        '
        'cmb_Corredor_Buscar
        '
        Me.cmb_Corredor_Buscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_Corredor_Buscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmb_Corredor_Buscar.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ClienteMayoristaModificacionBindingSource, "IdCorredor", True))
        Me.cmb_Corredor_Buscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Corredor_Buscar.Enabled = False
        Me.cmb_Corredor_Buscar.FormattingEnabled = True
        Me.cmb_Corredor_Buscar.Location = New System.Drawing.Point(143, 3)
        Me.cmb_Corredor_Buscar.Name = "cmb_Corredor_Buscar"
        Me.cmb_Corredor_Buscar.Size = New System.Drawing.Size(211, 23)
        Me.cmb_Corredor_Buscar.TabIndex = 95
        '
        'txt_Mail_Buscar
        '
        Me.txt_Mail_Buscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Mail_Buscar.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DireccionFacturacionModificacionBindingSource, "Email", True))
        Me.txt_Mail_Buscar.Location = New System.Drawing.Point(143, 124)
        Me.txt_Mail_Buscar.MaxLength = 255
        Me.txt_Mail_Buscar.Name = "txt_Mail_Buscar"
        Me.txt_Mail_Buscar.ReadOnly = True
        Me.txt_Mail_Buscar.Size = New System.Drawing.Size(211, 21)
        Me.txt_Mail_Buscar.TabIndex = 91
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
        Me.TableLayoutPanel15.Controls.Add(Me.TableLayoutPanel17, 1, 3)
        Me.TableLayoutPanel15.Controls.Add(Me.Label55, 0, 2)
        Me.TableLayoutPanel15.Controls.Add(Me.cmb_Empresa_Filtro, 1, 2)
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
        Me.cmb_Corredor_Filtro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Corredor_Filtro.FormattingEnabled = True
        Me.cmb_Corredor_Filtro.Items.AddRange(New Object() {"Opciones no disponibles"})
        Me.cmb_Corredor_Filtro.Location = New System.Drawing.Point(565, 4)
        Me.cmb_Corredor_Filtro.Name = "cmb_Corredor_Filtro"
        Me.cmb_Corredor_Filtro.Size = New System.Drawing.Size(194, 23)
        Me.cmb_Corredor_Filtro.TabIndex = 7
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
        Me.cmb_CondicionIVA_Filtro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_CondicionIVA_Filtro.FormattingEnabled = True
        Me.cmb_CondicionIVA_Filtro.Location = New System.Drawing.Point(565, 34)
        Me.cmb_CondicionIVA_Filtro.Name = "cmb_CondicionIVA_Filtro"
        Me.cmb_CondicionIVA_Filtro.Size = New System.Drawing.Size(194, 23)
        Me.cmb_CondicionIVA_Filtro.TabIndex = 24
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
        Me.cmb_ListaPrecios_Filtro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ListaPrecios_Filtro.FormattingEnabled = True
        Me.cmb_ListaPrecios_Filtro.Location = New System.Drawing.Point(565, 64)
        Me.cmb_ListaPrecios_Filtro.Name = "cmb_ListaPrecios_Filtro"
        Me.cmb_ListaPrecios_Filtro.Size = New System.Drawing.Size(194, 23)
        Me.cmb_ListaPrecios_Filtro.TabIndex = 26
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
        'TableLayoutPanel17
        '
        Me.TableLayoutPanel17.ColumnCount = 3
        Me.TableLayoutPanel17.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel17.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel17.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel17.Controls.Add(Me.Rb_Habilitado_Si, 0, 0)
        Me.TableLayoutPanel17.Controls.Add(Me.Rb_Habilitado_No, 1, 0)
        Me.TableLayoutPanel17.Controls.Add(Me.Rb_Habilitado_Todos, 2, 0)
        Me.TableLayoutPanel17.Location = New System.Drawing.Point(143, 93)
        Me.TableLayoutPanel17.Name = "TableLayoutPanel17"
        Me.TableLayoutPanel17.RowCount = 1
        Me.TableLayoutPanel17.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel17.Size = New System.Drawing.Size(194, 24)
        Me.TableLayoutPanel17.TabIndex = 5
        '
        'Rb_Habilitado_Si
        '
        Me.Rb_Habilitado_Si.AutoSize = True
        Me.Rb_Habilitado_Si.Location = New System.Drawing.Point(3, 3)
        Me.Rb_Habilitado_Si.Name = "Rb_Habilitado_Si"
        Me.Rb_Habilitado_Si.Size = New System.Drawing.Size(36, 18)
        Me.Rb_Habilitado_Si.TabIndex = 0
        Me.Rb_Habilitado_Si.Text = "Si"
        Me.Rb_Habilitado_Si.UseVisualStyleBackColor = True
        '
        'Rb_Habilitado_No
        '
        Me.Rb_Habilitado_No.AutoSize = True
        Me.Rb_Habilitado_No.Location = New System.Drawing.Point(67, 3)
        Me.Rb_Habilitado_No.Name = "Rb_Habilitado_No"
        Me.Rb_Habilitado_No.Size = New System.Drawing.Size(41, 18)
        Me.Rb_Habilitado_No.TabIndex = 1
        Me.Rb_Habilitado_No.Text = "No"
        Me.Rb_Habilitado_No.UseVisualStyleBackColor = True
        '
        'Rb_Habilitado_Todos
        '
        Me.Rb_Habilitado_Todos.AutoSize = True
        Me.Rb_Habilitado_Todos.Checked = True
        Me.Rb_Habilitado_Todos.Location = New System.Drawing.Point(131, 3)
        Me.Rb_Habilitado_Todos.Name = "Rb_Habilitado_Todos"
        Me.Rb_Habilitado_Todos.Size = New System.Drawing.Size(59, 18)
        Me.Rb_Habilitado_Todos.TabIndex = 2
        Me.Rb_Habilitado_Todos.TabStop = True
        Me.Rb_Habilitado_Todos.Text = "Todos"
        Me.Rb_Habilitado_Todos.UseVisualStyleBackColor = True
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
        Me.cmb_Empresa_Filtro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Empresa_Filtro.FormattingEnabled = True
        Me.cmb_Empresa_Filtro.Items.AddRange(New Object() {"Opciones no disponibles"})
        Me.cmb_Empresa_Filtro.Location = New System.Drawing.Point(143, 64)
        Me.cmb_Empresa_Filtro.Name = "cmb_Empresa_Filtro"
        Me.cmb_Empresa_Filtro.Size = New System.Drawing.Size(194, 23)
        Me.cmb_Empresa_Filtro.TabIndex = 28
        '
        'DG_Clientes
        '
        Me.DG_Clientes.AllowUserToAddRows = False
        Me.DG_Clientes.AllowUserToDeleteRows = False
        Me.DG_Clientes.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DG_Clientes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DG_Clientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_Clientes.AutoGenerateColumns = False
        Me.DG_Clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_Clientes.ColumnHeadersHeight = 30
        Me.DG_Clientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.RazonSocialDataGridViewTextBoxColumn, Me.CuitDataGridViewTextBoxColumn, Me.SaldoCuentaCorriente, Me.Eliminar, Me.Modificar})
        Me.DG_Clientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DG_Clientes.DataSource = Me.ClienteMayoristaGrillaBindingSource
        Me.DG_Clientes.Location = New System.Drawing.Point(6, 176)
        Me.DG_Clientes.MultiSelect = False
        Me.DG_Clientes.Name = "DG_Clientes"
        Me.DG_Clientes.ReadOnly = True
        Me.DG_Clientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DG_Clientes.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DG_Clientes.RowTemplate.Height = 30
        Me.DG_Clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Clientes.Size = New System.Drawing.Size(774, 321)
        Me.DG_Clientes.TabIndex = 0
        '
        'Id
        '
        Me.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Id.DataPropertyName = "Id"
        Me.Id.FillWeight = 294.7368!
        Me.Id.HeaderText = "Código"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Width = 80
        '
        'RazonSocialDataGridViewTextBoxColumn
        '
        Me.RazonSocialDataGridViewTextBoxColumn.DataPropertyName = "RazonSocial"
        Me.RazonSocialDataGridViewTextBoxColumn.FillWeight = 35.08772!
        Me.RazonSocialDataGridViewTextBoxColumn.HeaderText = "Razon Social"
        Me.RazonSocialDataGridViewTextBoxColumn.Name = "RazonSocialDataGridViewTextBoxColumn"
        Me.RazonSocialDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CuitDataGridViewTextBoxColumn
        '
        Me.CuitDataGridViewTextBoxColumn.DataPropertyName = "Cuit"
        Me.CuitDataGridViewTextBoxColumn.FillWeight = 35.08772!
        Me.CuitDataGridViewTextBoxColumn.HeaderText = "Cuit"
        Me.CuitDataGridViewTextBoxColumn.Name = "CuitDataGridViewTextBoxColumn"
        Me.CuitDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SaldoCuentaCorriente
        '
        Me.SaldoCuentaCorriente.DataPropertyName = "SaldoCuentaCorriente"
        DataGridViewCellStyle2.Format = "C2"
        Me.SaldoCuentaCorriente.DefaultCellStyle = DataGridViewCellStyle2
        Me.SaldoCuentaCorriente.FillWeight = 35.08772!
        Me.SaldoCuentaCorriente.HeaderText = "Saldo"
        Me.SaldoCuentaCorriente.Name = "SaldoCuentaCorriente"
        Me.SaldoCuentaCorriente.ReadOnly = True
        '
        'Eliminar
        '
        Me.Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Image = Global.SistemaCinderella.My.Resources.Recursos.Boton_Eliminar
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.Width = 70
        '
        'Modificar
        '
        Me.Modificar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Modificar.HeaderText = "Modificar"
        Me.Modificar.Image = Global.SistemaCinderella.My.Resources.Recursos.Boton_Editar
        Me.Modificar.Name = "Modificar"
        Me.Modificar.ReadOnly = True
        Me.Modificar.Width = 70
        '
        'ClienteMayoristaGrillaBindingSource
        '
        Me.ClienteMayoristaGrillaBindingSource.DataSource = GetType(Entidades.ClienteMayorista)
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
        Me.cb_Localidad_Entrega.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DireccionEntregaAltaBindingSource, "IdLocalidad", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cb_Localidad_Entrega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Localidad_Entrega.FormattingEnabled = True
        Me.cb_Localidad_Entrega.Location = New System.Drawing.Point(143, 93)
        Me.cb_Localidad_Entrega.Name = "cb_Localidad_Entrega"
        Me.cb_Localidad_Entrega.Size = New System.Drawing.Size(214, 23)
        Me.cb_Localidad_Entrega.TabIndex = 23
        '
        'DireccionEntregaAltaBindingSource
        '
        Me.DireccionEntregaAltaBindingSource.DataSource = GetType(Entidades.Direccion)
        '
        'txt_CodigoPostal_Entrega
        '
        Me.txt_CodigoPostal_Entrega.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_CodigoPostal_Entrega.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DireccionEntregaAltaBindingSource, "CodigoPostal", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
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
        Me.cb_Distrito_Entrega.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DireccionEntregaAltaBindingSource, "IdDistito", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cb_Distrito_Entrega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Distrito_Entrega.FormattingEnabled = True
        Me.cb_Distrito_Entrega.Location = New System.Drawing.Point(143, 63)
        Me.cb_Distrito_Entrega.Name = "cb_Distrito_Entrega"
        Me.cb_Distrito_Entrega.Size = New System.Drawing.Size(214, 23)
        Me.cb_Distrito_Entrega.TabIndex = 22
        '
        'cb_Provincia_Entrega
        '
        Me.cb_Provincia_Entrega.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_Provincia_Entrega.CausesValidation = False
        Me.cb_Provincia_Entrega.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_Provincia_Entrega.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DireccionEntregaAltaBindingSource, "IdProvincia", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cb_Provincia_Entrega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Provincia_Entrega.FormattingEnabled = True
        Me.cb_Provincia_Entrega.Location = New System.Drawing.Point(143, 33)
        Me.cb_Provincia_Entrega.Name = "cb_Provincia_Entrega"
        Me.cb_Provincia_Entrega.Size = New System.Drawing.Size(214, 23)
        Me.cb_Provincia_Entrega.TabIndex = 21
        '
        'txt_Direccion_Entrega
        '
        Me.txt_Direccion_Entrega.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Direccion_Entrega.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DireccionEntregaAltaBindingSource, "Direccion", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
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
        Me.txt_Mail_Facturacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DireccionFacturacionAltaBindingSource, "Email", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_Mail_Facturacion.Location = New System.Drawing.Point(143, 186)
        Me.txt_Mail_Facturacion.MaxLength = 255
        Me.txt_Mail_Facturacion.Name = "txt_Mail_Facturacion"
        Me.txt_Mail_Facturacion.Size = New System.Drawing.Size(214, 21)
        Me.txt_Mail_Facturacion.TabIndex = 19
        '
        'DireccionFacturacionAltaBindingSource
        '
        Me.DireccionFacturacionAltaBindingSource.DataSource = GetType(Entidades.Direccion)
        '
        'txt_Telefono_Facturacion
        '
        Me.txt_Telefono_Facturacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Telefono_Facturacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DireccionFacturacionAltaBindingSource, "Telefono", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
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
        Me.cb_Localidad_Facturacion.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DireccionFacturacionAltaBindingSource, "IdLocalidad", True))
        Me.cb_Localidad_Facturacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Localidad_Facturacion.FormattingEnabled = True
        Me.cb_Localidad_Facturacion.ItemHeight = 15
        Me.cb_Localidad_Facturacion.Location = New System.Drawing.Point(143, 93)
        Me.cb_Localidad_Facturacion.Name = "cb_Localidad_Facturacion"
        Me.cb_Localidad_Facturacion.Size = New System.Drawing.Size(214, 23)
        Me.cb_Localidad_Facturacion.TabIndex = 16
        '
        'txt_CodigoPostal_Facturacion
        '
        Me.txt_CodigoPostal_Facturacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_CodigoPostal_Facturacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DireccionFacturacionAltaBindingSource, "CodigoPostal", True))
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
        Me.cb_Distrito_Facturacion.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DireccionFacturacionAltaBindingSource, "IdDistito", True))
        Me.cb_Distrito_Facturacion.DisplayMember = "-1"
        Me.cb_Distrito_Facturacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Distrito_Facturacion.FormattingEnabled = True
        Me.cb_Distrito_Facturacion.Location = New System.Drawing.Point(143, 63)
        Me.cb_Distrito_Facturacion.Name = "cb_Distrito_Facturacion"
        Me.cb_Distrito_Facturacion.Size = New System.Drawing.Size(214, 23)
        Me.cb_Distrito_Facturacion.TabIndex = 15
        Me.cb_Distrito_Facturacion.ValueMember = "-1"
        '
        'cb_Provincia_Facturacion
        '
        Me.cb_Provincia_Facturacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_Provincia_Facturacion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_Provincia_Facturacion.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DireccionFacturacionAltaBindingSource, "IdProvincia", True))
        Me.cb_Provincia_Facturacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Provincia_Facturacion.FormattingEnabled = True
        Me.cb_Provincia_Facturacion.ItemHeight = 15
        Me.cb_Provincia_Facturacion.Location = New System.Drawing.Point(143, 33)
        Me.cb_Provincia_Facturacion.Name = "cb_Provincia_Facturacion"
        Me.cb_Provincia_Facturacion.Size = New System.Drawing.Size(214, 23)
        Me.cb_Provincia_Facturacion.TabIndex = 14
        '
        'txt_Direccion_Facturacion
        '
        Me.txt_Direccion_Facturacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Direccion_Facturacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DireccionFacturacionAltaBindingSource, "Direccion", True))
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
        Me.Label32.Size = New System.Drawing.Size(75, 15)
        Me.Label32.TabIndex = 85
        Me.Label32.Text = "Observacion"
        '
        'txt_Observaciones
        '
        Me.txt_Observaciones.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesMayoristaAltaBindingSource, "Observaciones", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_Observaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Observaciones.Location = New System.Drawing.Point(143, 3)
        Me.txt_Observaciones.MaxLength = 255
        Me.txt_Observaciones.Multiline = True
        Me.txt_Observaciones.Name = "txt_Observaciones"
        Me.txt_Observaciones.Size = New System.Drawing.Size(610, 71)
        Me.txt_Observaciones.TabIndex = 25
        '
        'ClientesMayoristaAltaBindingSource
        '
        Me.ClientesMayoristaAltaBindingSource.DataSource = GetType(Entidades.ClienteMayorista)
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
        Me.cmb_Empresa.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ClientesMayoristaAltaBindingSource, "IdEmpresa", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cmb_Empresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Empresa.FormattingEnabled = True
        Me.cmb_Empresa.Items.AddRange(New Object() {"Opciones no disponibles"})
        Me.cmb_Empresa.Location = New System.Drawing.Point(143, 8)
        Me.cmb_Empresa.Name = "cmb_Empresa"
        Me.cmb_Empresa.Size = New System.Drawing.Size(212, 23)
        Me.cmb_Empresa.TabIndex = 11
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
        Me.cb_ListaPrecios.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ClientesMayoristaAltaBindingSource, "IdListaPrecio", True))
        Me.cb_ListaPrecios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_ListaPrecios.FormattingEnabled = True
        Me.cb_ListaPrecios.Location = New System.Drawing.Point(541, 8)
        Me.cb_ListaPrecios.Name = "cb_ListaPrecios"
        Me.cb_ListaPrecios.Size = New System.Drawing.Size(212, 23)
        Me.cb_ListaPrecios.TabIndex = 12
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
        Me.txt_CondicionPago.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesMayoristaAltaBindingSource, "CondicionPago", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
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
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Lista, 4, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.cmb_Corredor, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label23, 3, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Comision, 4, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Bonificacion, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Nombre, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cb_CondicionIva, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Transporte, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label20, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label21, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label19, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_CondicionIva, 3, 1)
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
        Me.lbl_RazonSocial.Text = "Razon Social (*)"
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
        Me.txt_RazonSocial.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesMayoristaAltaBindingSource, "RazonSocial", True))
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
        Me.txt_Cuit.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesMayoristaAltaBindingSource, "Cuit", True))
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
        'txt_Lista
        '
        Me.txt_Lista.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Lista.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesMayoristaAltaBindingSource, "Lista", True))
        Me.txt_Lista.Location = New System.Drawing.Point(541, 131)
        Me.txt_Lista.MaxLength = 255
        Me.txt_Lista.Name = "txt_Lista"
        Me.txt_Lista.Size = New System.Drawing.Size(212, 21)
        Me.txt_Lista.TabIndex = 9
        '
        'cmb_Corredor
        '
        Me.cmb_Corredor.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_Corredor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmb_Corredor.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ClientesMayoristaAltaBindingSource, "IdCorredor", True))
        Me.cmb_Corredor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Corredor.FormattingEnabled = True
        Me.cmb_Corredor.Items.AddRange(New Object() {"Opciones no disponibles"})
        Me.cmb_Corredor.Location = New System.Drawing.Point(143, 63)
        Me.cmb_Corredor.Name = "cmb_Corredor"
        Me.cmb_Corredor.Size = New System.Drawing.Size(212, 23)
        Me.cmb_Corredor.TabIndex = 5
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
        'txt_Comision
        '
        Me.txt_Comision.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Comision.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesMayoristaAltaBindingSource, "Comision", True))
        Me.txt_Comision.Location = New System.Drawing.Point(541, 64)
        Me.txt_Comision.MaxLength = 255
        Me.txt_Comision.Name = "txt_Comision"
        Me.txt_Comision.Size = New System.Drawing.Size(212, 21)
        Me.txt_Comision.TabIndex = 6
        '
        'txt_Bonificacion
        '
        Me.txt_Bonificacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Bonificacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesMayoristaAltaBindingSource, "Bonificacion", True))
        Me.txt_Bonificacion.Location = New System.Drawing.Point(143, 131)
        Me.txt_Bonificacion.MaxLength = 255
        Me.txt_Bonificacion.Name = "txt_Bonificacion"
        Me.txt_Bonificacion.Size = New System.Drawing.Size(212, 21)
        Me.txt_Bonificacion.TabIndex = 8
        '
        'txt_Nombre
        '
        Me.txt_Nombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Nombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesMayoristaAltaBindingSource, "Nombre", True))
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
        Me.cb_CondicionIva.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ClientesMayoristaAltaBindingSource, "IdCondicionIva", True))
        Me.cb_CondicionIva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_CondicionIva.FormattingEnabled = True
        Me.cb_CondicionIva.Location = New System.Drawing.Point(541, 33)
        Me.cb_CondicionIva.Name = "cb_CondicionIva"
        Me.cb_CondicionIva.Size = New System.Drawing.Size(212, 23)
        Me.cb_CondicionIva.TabIndex = 4
        '
        'txt_Transporte
        '
        Me.txt_Transporte.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Transporte.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesMayoristaAltaBindingSource, "Transporte", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
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
        Me.GB_Modificacion.Controls.Add(Me.Btn_Eliminar)
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
        Me.chk_Habilitado_Mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chk_Habilitado_Mod.AutoSize = True
        Me.chk_Habilitado_Mod.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.ClienteMayoristaModificacionBindingSource, "Habilitado", True))
        Me.chk_Habilitado_Mod.Location = New System.Drawing.Point(143, 13)
        Me.chk_Habilitado_Mod.Name = "chk_Habilitado_Mod"
        Me.chk_Habilitado_Mod.Size = New System.Drawing.Size(237, 14)
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
        Me.cb_Localidad_Entrega_Mod.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DireccionEntregaModificacionBindingSource, "IdLocalidad", True))
        Me.cb_Localidad_Entrega_Mod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Localidad_Entrega_Mod.FormattingEnabled = True
        Me.cb_Localidad_Entrega_Mod.Location = New System.Drawing.Point(143, 93)
        Me.cb_Localidad_Entrega_Mod.Name = "cb_Localidad_Entrega_Mod"
        Me.cb_Localidad_Entrega_Mod.Size = New System.Drawing.Size(214, 23)
        Me.cb_Localidad_Entrega_Mod.TabIndex = 122
        '
        'DireccionEntregaModificacionBindingSource
        '
        Me.DireccionEntregaModificacionBindingSource.DataSource = GetType(Entidades.Direccion)
        '
        'txt_CodigoPostal_Entrega_Mod
        '
        Me.txt_CodigoPostal_Entrega_Mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_CodigoPostal_Entrega_Mod.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DireccionEntregaModificacionBindingSource, "CodigoPostal", True))
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
        Me.cb_Distrito_Entrega_Mod.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DireccionEntregaModificacionBindingSource, "IdDistito", True))
        Me.cb_Distrito_Entrega_Mod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Distrito_Entrega_Mod.FormattingEnabled = True
        Me.cb_Distrito_Entrega_Mod.Location = New System.Drawing.Point(143, 63)
        Me.cb_Distrito_Entrega_Mod.Name = "cb_Distrito_Entrega_Mod"
        Me.cb_Distrito_Entrega_Mod.Size = New System.Drawing.Size(214, 23)
        Me.cb_Distrito_Entrega_Mod.TabIndex = 121
        '
        'cb_Provincia_Entrega_Mod
        '
        Me.cb_Provincia_Entrega_Mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_Provincia_Entrega_Mod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_Provincia_Entrega_Mod.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DireccionEntregaModificacionBindingSource, "IdProvincia", True))
        Me.cb_Provincia_Entrega_Mod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Provincia_Entrega_Mod.FormattingEnabled = True
        Me.cb_Provincia_Entrega_Mod.Location = New System.Drawing.Point(143, 33)
        Me.cb_Provincia_Entrega_Mod.Name = "cb_Provincia_Entrega_Mod"
        Me.cb_Provincia_Entrega_Mod.Size = New System.Drawing.Size(214, 23)
        Me.cb_Provincia_Entrega_Mod.TabIndex = 120
        '
        'txt_Direccion_Entrega_Mod
        '
        Me.txt_Direccion_Entrega_Mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Direccion_Entrega_Mod.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DireccionEntregaModificacionBindingSource, "Direccion", True))
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
        Me.txt_Mail_Facturacion_Mod.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DireccionFacturacionModificacionBindingSource, "Email", True))
        Me.txt_Mail_Facturacion_Mod.Location = New System.Drawing.Point(143, 186)
        Me.txt_Mail_Facturacion_Mod.MaxLength = 255
        Me.txt_Mail_Facturacion_Mod.Name = "txt_Mail_Facturacion_Mod"
        Me.txt_Mail_Facturacion_Mod.Size = New System.Drawing.Size(214, 21)
        Me.txt_Mail_Facturacion_Mod.TabIndex = 118
        '
        'txt_Telefono_Facturacion_Mod
        '
        Me.txt_Telefono_Facturacion_Mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Telefono_Facturacion_Mod.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DireccionFacturacionModificacionBindingSource, "Telefono", True))
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
        Me.cb_Localidad_Facturacion_Mod.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DireccionFacturacionModificacionBindingSource, "IdLocalidad", True))
        Me.cb_Localidad_Facturacion_Mod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Localidad_Facturacion_Mod.FormattingEnabled = True
        Me.cb_Localidad_Facturacion_Mod.Location = New System.Drawing.Point(143, 93)
        Me.cb_Localidad_Facturacion_Mod.Name = "cb_Localidad_Facturacion_Mod"
        Me.cb_Localidad_Facturacion_Mod.Size = New System.Drawing.Size(214, 23)
        Me.cb_Localidad_Facturacion_Mod.TabIndex = 115
        '
        'txt_CodigoPostal_Facturacion_Mod
        '
        Me.txt_CodigoPostal_Facturacion_Mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_CodigoPostal_Facturacion_Mod.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DireccionFacturacionModificacionBindingSource, "CodigoPostal", True))
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
        Me.cb_Distrito_Facturacion_Mod.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DireccionFacturacionModificacionBindingSource, "IdDistito", True))
        Me.cb_Distrito_Facturacion_Mod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Distrito_Facturacion_Mod.FormattingEnabled = True
        Me.cb_Distrito_Facturacion_Mod.Location = New System.Drawing.Point(143, 63)
        Me.cb_Distrito_Facturacion_Mod.Name = "cb_Distrito_Facturacion_Mod"
        Me.cb_Distrito_Facturacion_Mod.Size = New System.Drawing.Size(214, 23)
        Me.cb_Distrito_Facturacion_Mod.TabIndex = 114
        '
        'cb_Provincia_Facturacion_Mod
        '
        Me.cb_Provincia_Facturacion_Mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_Provincia_Facturacion_Mod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_Provincia_Facturacion_Mod.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DireccionFacturacionModificacionBindingSource, "IdProvincia", True))
        Me.cb_Provincia_Facturacion_Mod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Provincia_Facturacion_Mod.FormattingEnabled = True
        Me.cb_Provincia_Facturacion_Mod.Location = New System.Drawing.Point(143, 33)
        Me.cb_Provincia_Facturacion_Mod.Name = "cb_Provincia_Facturacion_Mod"
        Me.cb_Provincia_Facturacion_Mod.Size = New System.Drawing.Size(214, 23)
        Me.cb_Provincia_Facturacion_Mod.TabIndex = 113
        '
        'txt_Direccion_Facturacion_Mod
        '
        Me.txt_Direccion_Facturacion_Mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Direccion_Facturacion_Mod.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DireccionFacturacionModificacionBindingSource, "Direccion", True))
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
        Me.cmb_Empresa_Mod.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ClienteMayoristaModificacionBindingSource, "IdEmpresa", True))
        Me.cmb_Empresa_Mod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Empresa_Mod.FormattingEnabled = True
        Me.cmb_Empresa_Mod.ItemHeight = 15
        Me.cmb_Empresa_Mod.Items.AddRange(New Object() {"Opciones no disponibles"})
        Me.cmb_Empresa_Mod.Location = New System.Drawing.Point(143, 8)
        Me.cmb_Empresa_Mod.Name = "cmb_Empresa_Mod"
        Me.cmb_Empresa_Mod.Size = New System.Drawing.Size(212, 23)
        Me.cmb_Empresa_Mod.TabIndex = 19
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
        Me.cb_ListaPrecios_Mod.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ClienteMayoristaModificacionBindingSource, "IdListaPrecio", True))
        Me.cb_ListaPrecios_Mod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_ListaPrecios_Mod.FormattingEnabled = True
        Me.cb_ListaPrecios_Mod.ItemHeight = 15
        Me.cb_ListaPrecios_Mod.Location = New System.Drawing.Point(541, 8)
        Me.cb_ListaPrecios_Mod.Name = "cb_ListaPrecios_Mod"
        Me.cb_ListaPrecios_Mod.Size = New System.Drawing.Size(212, 23)
        Me.cb_ListaPrecios_Mod.TabIndex = 12
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
        Me.txt_CondicionPago_Mod.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteMayoristaModificacionBindingSource, "CondicionPago", True))
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
        Me.TableLayoutPanel14.Controls.Add(Me.txt_Lista_Mod, 4, 4)
        Me.TableLayoutPanel14.Controls.Add(Me.cmb_Corredor_Mod, 1, 2)
        Me.TableLayoutPanel14.Controls.Add(Me.Label34, 3, 4)
        Me.TableLayoutPanel14.Controls.Add(Me.txt_Comision_Mod, 4, 2)
        Me.TableLayoutPanel14.Controls.Add(Me.txt_Bonificacion_Mod, 1, 4)
        Me.TableLayoutPanel14.Controls.Add(Me.txt_Nombre_Mod, 4, 0)
        Me.TableLayoutPanel14.Controls.Add(Me.cb_CondicionIva_Mod, 4, 1)
        Me.TableLayoutPanel14.Controls.Add(Me.txt_Transporte_Mod, 1, 3)
        Me.TableLayoutPanel14.Controls.Add(Me.Label35, 0, 2)
        Me.TableLayoutPanel14.Controls.Add(Me.Label36, 3, 2)
        Me.TableLayoutPanel14.Controls.Add(Me.Label37, 3, 0)
        Me.TableLayoutPanel14.Controls.Add(Me.Label38, 3, 1)
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
        Me.Label18.Text = "Razon Social (*)"
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
        Me.txt_RazonSocial_mod.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteMayoristaModificacionBindingSource, "RazonSocial", True))
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
        Me.txt_Cuit_Mod.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteMayoristaModificacionBindingSource, "Cuit", True))
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
        'txt_Lista_Mod
        '
        Me.txt_Lista_Mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Lista_Mod.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteMayoristaModificacionBindingSource, "Lista", True))
        Me.txt_Lista_Mod.Location = New System.Drawing.Point(541, 131)
        Me.txt_Lista_Mod.MaxLength = 255
        Me.txt_Lista_Mod.Name = "txt_Lista_Mod"
        Me.txt_Lista_Mod.Size = New System.Drawing.Size(212, 21)
        Me.txt_Lista_Mod.TabIndex = 108
        '
        'cmb_Corredor_Mod
        '
        Me.cmb_Corredor_Mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_Corredor_Mod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmb_Corredor_Mod.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ClienteMayoristaModificacionBindingSource, "IdCorredor", True))
        Me.cmb_Corredor_Mod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Corredor_Mod.FormattingEnabled = True
        Me.cmb_Corredor_Mod.Items.AddRange(New Object() {"Opciones no disponibles"})
        Me.cmb_Corredor_Mod.Location = New System.Drawing.Point(143, 63)
        Me.cmb_Corredor_Mod.Name = "cmb_Corredor_Mod"
        Me.cmb_Corredor_Mod.Size = New System.Drawing.Size(212, 23)
        Me.cmb_Corredor_Mod.TabIndex = 104
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
        'txt_Comision_Mod
        '
        Me.txt_Comision_Mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Comision_Mod.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteMayoristaModificacionBindingSource, "Comision", True))
        Me.txt_Comision_Mod.Location = New System.Drawing.Point(541, 64)
        Me.txt_Comision_Mod.MaxLength = 255
        Me.txt_Comision_Mod.Name = "txt_Comision_Mod"
        Me.txt_Comision_Mod.Size = New System.Drawing.Size(212, 21)
        Me.txt_Comision_Mod.TabIndex = 105
        '
        'txt_Bonificacion_Mod
        '
        Me.txt_Bonificacion_Mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Bonificacion_Mod.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteMayoristaModificacionBindingSource, "Bonificacion", True))
        Me.txt_Bonificacion_Mod.Location = New System.Drawing.Point(143, 131)
        Me.txt_Bonificacion_Mod.MaxLength = 255
        Me.txt_Bonificacion_Mod.Name = "txt_Bonificacion_Mod"
        Me.txt_Bonificacion_Mod.Size = New System.Drawing.Size(212, 21)
        Me.txt_Bonificacion_Mod.TabIndex = 107
        '
        'txt_Nombre_Mod
        '
        Me.txt_Nombre_Mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Nombre_Mod.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteMayoristaModificacionBindingSource, "Nombre", True))
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
        Me.cb_CondicionIva_Mod.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ClienteMayoristaModificacionBindingSource, "IdCondicionIva", True))
        Me.cb_CondicionIva_Mod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_CondicionIva_Mod.FormattingEnabled = True
        Me.cb_CondicionIva_Mod.Location = New System.Drawing.Point(541, 33)
        Me.cb_CondicionIva_Mod.Name = "cb_CondicionIva_Mod"
        Me.cb_CondicionIva_Mod.Size = New System.Drawing.Size(212, 23)
        Me.cb_CondicionIva_Mod.TabIndex = 103
        '
        'txt_Transporte_Mod
        '
        Me.txt_Transporte_Mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Transporte_Mod.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteMayoristaModificacionBindingSource, "Transporte", True))
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
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Cancelar.Image = Global.SistemaCinderella.My.Resources.Recursos.desconectado_32
        Me.Btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Cancelar.Location = New System.Drawing.Point(450, 650)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Cancelar.TabIndex = 128
        Me.Btn_Cancelar.Text = "Cancelar"
        Me.Btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolCliente.SetToolTip(Me.Btn_Cancelar, "Descarta los cambios y vuelve al listado de clientes")
        Me.Btn_Cancelar.UseVisualStyleBackColor = True
        '
        'Btn_Eliminar
        '
        Me.Btn_Eliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Eliminar.Image = Global.SistemaCinderella.My.Resources.Recursos.Limpiar_32
        Me.Btn_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Eliminar.Location = New System.Drawing.Point(556, 650)
        Me.Btn_Eliminar.Name = "Btn_Eliminar"
        Me.Btn_Eliminar.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Eliminar.TabIndex = 127
        Me.Btn_Eliminar.Text = "Eliminar"
        Me.Btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolCliente.SetToolTip(Me.Btn_Eliminar, "Haz click aquí para eliminar el cliente")
        Me.Btn_Eliminar.UseVisualStyleBackColor = True
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
        'ErrorCliente
        '
        Me.ErrorCliente.BlinkRate = 200
        Me.ErrorCliente.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorCliente.ContainerControl = Me
        Me.ErrorCliente.RightToLeft = True
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
        Me.GroupBox5.ResumeLayout(False)
        Me.TableLayoutPanel16.ResumeLayout(False)
        Me.TableLayoutPanel16.PerformLayout()
        CType(Me.ClienteMayoristaModificacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DireccionFacturacionModificacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_Buscar.ResumeLayout(False)
        Me.TableLayoutPanel15.ResumeLayout(False)
        Me.TableLayoutPanel15.PerformLayout()
        Me.TableLayoutPanel17.ResumeLayout(False)
        Me.TableLayoutPanel17.PerformLayout()
        CType(Me.DG_Clientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteMayoristaGrillaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TbAlta.ResumeLayout(False)
        Me.GB_Alta.ResumeLayout(False)
        Me.GB_Alta.PerformLayout()
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        CType(Me.DireccionEntregaAltaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        CType(Me.DireccionFacturacionAltaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        CType(Me.ClientesMayoristaAltaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TbMod.ResumeLayout(False)
        Me.GB_Modificacion.ResumeLayout(False)
        Me.TableLayoutPanel18.ResumeLayout(False)
        Me.TableLayoutPanel18.PerformLayout()
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.TableLayoutPanel9.ResumeLayout(False)
        Me.TableLayoutPanel9.PerformLayout()
        CType(Me.DireccionEntregaModificacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.TableLayoutPanel10.ResumeLayout(False)
        Me.TableLayoutPanel10.PerformLayout()
        Me.TableLayoutPanel11.ResumeLayout(False)
        Me.TableLayoutPanel11.PerformLayout()
        Me.TableLayoutPanel12.ResumeLayout(False)
        Me.TableLayoutPanel12.PerformLayout()
        Me.TableLayoutPanel13.ResumeLayout(False)
        Me.TableLayoutPanel13.PerformLayout()
        Me.TableLayoutPanel14.ResumeLayout(False)
        Me.TableLayoutPanel14.PerformLayout()
        CType(Me.ErrorCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabControl As System.Windows.Forms.TabControl
    Friend WithEvents TbListado As System.Windows.Forms.TabPage
    Friend WithEvents DG_Clientes As System.Windows.Forms.DataGridView
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
    Friend WithEvents ErrorCliente As System.Windows.Forms.ErrorProvider
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents Btn_Eliminar As System.Windows.Forms.Button
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
    Friend WithEvents txt_Lista_Mod As TextBox
    Friend WithEvents cmb_Corredor_Mod As ComboBox
    Friend WithEvents Label34 As Label
    Friend WithEvents txt_Comision_Mod As TextBox
    Friend WithEvents txt_Bonificacion_Mod As TextBox
    Friend WithEvents txt_Nombre_Mod As TextBox
    Friend WithEvents cb_CondicionIva_Mod As ComboBox
    Friend WithEvents txt_Transporte_Mod As TextBox
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents ClientesMayoristaAltaBindingSource As BindingSource
    Friend WithEvents DireccionFacturacionAltaBindingSource As BindingSource
    Friend WithEvents DireccionEntregaAltaBindingSource As BindingSource
    Friend WithEvents txt_Lista As TextBox
    Friend WithEvents txt_Comision As TextBox
    Friend WithEvents txt_Bonificacion As TextBox
    Friend WithEvents ClienteMayoristaGrillaBindingSource As BindingSource
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
    Friend WithEvents txt_Comision_Buscar As TextBox
    Friend WithEvents txt_Bonificacion_Buscar As TextBox
    Friend WithEvents txt_Lista_Buscar As TextBox
    Friend WithEvents txt_Direccion_Buscar As TextBox
    Friend WithEvents txt_Telefono_Buscar As TextBox
    Friend WithEvents cmb_ListaPrecio_Buscar As ComboBox
    Friend WithEvents cmb_CondicionIVA_Buscar As ComboBox
    Friend WithEvents Label49 As Label
    Friend WithEvents txt_TotalSaldoCuentaCorriente As TextBox
    Friend WithEvents Label50 As Label
    Friend WithEvents TableLayoutPanel17 As TableLayoutPanel
    Friend WithEvents Rb_Habilitado_Si As RadioButton
    Friend WithEvents Rb_Habilitado_No As RadioButton
    Friend WithEvents Rb_Habilitado_Todos As RadioButton
    Friend WithEvents txt_Cuit_Filtro As TextBox
    Friend WithEvents Label39 As Label
    Friend WithEvents ClienteMayoristaModificacionBindingSource As BindingSource
    Friend WithEvents cmb_Corredor_Buscar As ComboBox
    Friend WithEvents DireccionEntregaModificacionBindingSource As BindingSource
    Friend WithEvents DireccionFacturacionModificacionBindingSource As BindingSource
    Friend WithEvents lbl_Msg As Label
    Friend WithEvents TableLayoutPanel18 As TableLayoutPanel
    Friend WithEvents Label51 As Label
    Friend WithEvents chk_Habilitado_Mod As CheckBox
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents RazonSocialDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CuitDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SaldoCuentaCorriente As DataGridViewTextBoxColumn
    Friend WithEvents Eliminar As DataGridViewImageColumn
    Friend WithEvents Modificar As DataGridViewImageColumn
    Friend WithEvents Label52 As Label
    Friend WithEvents cmb_Corredor_Filtro As ComboBox
    Friend WithEvents Label53 As Label
    Friend WithEvents cmb_CondicionIVA_Filtro As ComboBox
    Friend WithEvents Label54 As Label
    Friend WithEvents cmb_ListaPrecios_Filtro As ComboBox
    Friend WithEvents Label55 As Label
    Friend WithEvents cmb_Empresa_Filtro As ComboBox
End Class
