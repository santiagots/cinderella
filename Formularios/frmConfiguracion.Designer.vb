<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConfiguracion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfiguracion))
        Me.lbl_NombreSucursalActual = New System.Windows.Forms.Label()
        Me.lbl_SucursalActual = New System.Windows.Forms.Label()
        Me.Cb_Sucursales = New System.Windows.Forms.ComboBox()
        Me.lbl_NuevaSucursal = New System.Windows.Forms.Label()
        Me.Btn_Actualizar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.txt_DatosFiscalLocalidad = New System.Windows.Forms.TextBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.txt_DatosFiscalNombreFantasiaFuente = New System.Windows.Forms.Button()
        Me.txt_DatosFiscalEmail = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.txt_DatosFiscalTelefono = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.txt_DatosFiscalDireccion = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.dt_DatosFiscalInicioActividad = New System.Windows.Forms.DateTimePicker()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.txt_DatosFiscalIIBB = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txt_DatosFiscalCUIT = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txt_DatosFiscalRazonSocial = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txt_DatosFiscalNombreFantasia = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_descuentoMinorista = New System.Windows.Forms.NumericUpDown()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_NombreListaActual = New System.Windows.Forms.Label()
        Me.Btn_Precios = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cb_Precios = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.rbUtilizaSSLNo = New System.Windows.Forms.RadioButton()
        Me.rbUtilizaSSLSi = New System.Windows.Forms.RadioButton()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.txtSmtp = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnMailing = New System.Windows.Forms.Button()
        Me.lblPort = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Cb_ModeloControladora = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Cb_ConexionControladora = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RExentoSinIvaNo = New System.Windows.Forms.RadioButton()
        Me.RExentoSinIvaSI = New System.Windows.Forms.RadioButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.RContrSI = New System.Windows.Forms.RadioButton()
        Me.RContrNO = New System.Windows.Forms.RadioButton()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txt_MontoTopeElectronico = New System.Windows.Forms.TextBox()
        Me.txt_MontoTopeManual = New System.Windows.Forms.TextBox()
        Me.txt_MontoTopeTicket = New System.Windows.Forms.TextBox()
        Me.txt_MontoMaximoNotaCredito = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.txt_PuntoVentaElectronica = New System.Windows.Forms.TextBox()
        Me.txt_PuntoVentaManual = New System.Windows.Forms.TextBox()
        Me.txt_PuntoVentaControladora = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Btn_Controlador = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabSucursal = New System.Windows.Forms.TabPage()
        Me.TabPrecios = New System.Windows.Forms.TabPage()
        Me.TabMail = New System.Windows.Forms.TabPage()
        Me.TabFacturacion = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.btnCargarCertificadoAFIP = New System.Windows.Forms.Button()
        Me.btnObtenerArchivoCSR = New System.Windows.Forms.Button()
        Me.txt_facturacionElectronicaCertificadoVencimiento = New System.Windows.Forms.TextBox()
        Me.txt_facturacionElectronicaCertificadoNombre = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.TabNotificaciones = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Cb_TiempoComprobacionCheques = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cb_TiempoComprobacionMovimientos = New System.Windows.Forms.ComboBox()
        Me.BtnNotificaciones = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Cb_TiempoComprobacionMensajes = New System.Windows.Forms.ComboBox()
        Me.TabInternet = New System.Windows.Forms.TabPage()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.btn_ConfigurarBaseDatos = New System.Windows.Forms.Button()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Cb_HorasSincronizacion = New System.Windows.Forms.ComboBox()
        Me.btnVerificarDNS = New System.Windows.Forms.Button()
        Me.txt_IpPing = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Cb_TimeOut = New System.Windows.Forms.ComboBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Rb2 = New System.Windows.Forms.RadioButton()
        Me.Rb1 = New System.Windows.Forms.RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtnInternet = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Cb_SegundosInternet = New System.Windows.Forms.ComboBox()
        Me.TabHost = New System.Windows.Forms.TabPage()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.txtPuertoHost = New System.Windows.Forms.TextBox()
        Me.txtIPHost = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.btnModificarHost = New System.Windows.Forms.Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TabStock = New System.Windows.Forms.TabPage()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ROrdenCompraAutomaticaNo = New System.Windows.Forms.RadioButton()
        Me.ROrdenCompraAutomaticaSI = New System.Windows.Forms.RadioButton()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.btnCalcularVentaMensualProducto = New System.Windows.Forms.Button()
        Me.txtFechaUltimoCalculoventaMensual = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.CbPeriodoActualizacionVentaMensual = New System.Windows.Forms.ComboBox()
        Me.btnModificarStock = New System.Windows.Forms.Button()
        Me.FontDialog = New System.Windows.Forms.FontDialog()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txt_descuentoMinorista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabSucursal.SuspendLayout()
        Me.TabPrecios.SuspendLayout()
        Me.TabMail.SuspendLayout()
        Me.TabFacturacion.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.TabNotificaciones.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.TabInternet.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.TabHost.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.TabStock.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_NombreSucursalActual
        '
        Me.lbl_NombreSucursalActual.AutoSize = True
        Me.lbl_NombreSucursalActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NombreSucursalActual.Location = New System.Drawing.Point(183, 32)
        Me.lbl_NombreSucursalActual.Name = "lbl_NombreSucursalActual"
        Me.lbl_NombreSucursalActual.Size = New System.Drawing.Size(54, 13)
        Me.lbl_NombreSucursalActual.TabIndex = 0
        Me.lbl_NombreSucursalActual.Text = "sucursal"
        '
        'lbl_SucursalActual
        '
        Me.lbl_SucursalActual.AutoSize = True
        Me.lbl_SucursalActual.Location = New System.Drawing.Point(7, 32)
        Me.lbl_SucursalActual.Name = "lbl_SucursalActual"
        Me.lbl_SucursalActual.Size = New System.Drawing.Size(97, 15)
        Me.lbl_SucursalActual.TabIndex = 1
        Me.lbl_SucursalActual.Text = "Sucursal Actual: "
        '
        'Cb_Sucursales
        '
        Me.Cb_Sucursales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cb_Sucursales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Sucursales.FormattingEnabled = True
        Me.Cb_Sucursales.Location = New System.Drawing.Point(140, 70)
        Me.Cb_Sucursales.Name = "Cb_Sucursales"
        Me.Cb_Sucursales.Size = New System.Drawing.Size(258, 23)
        Me.Cb_Sucursales.TabIndex = 1
        '
        'lbl_NuevaSucursal
        '
        Me.lbl_NuevaSucursal.AutoSize = True
        Me.lbl_NuevaSucursal.Location = New System.Drawing.Point(9, 73)
        Me.lbl_NuevaSucursal.Name = "lbl_NuevaSucursal"
        Me.lbl_NuevaSucursal.Size = New System.Drawing.Size(112, 15)
        Me.lbl_NuevaSucursal.TabIndex = 3
        Me.lbl_NuevaSucursal.Text = "(*) Nueva Sucursal:"
        '
        'Btn_Actualizar
        '
        Me.Btn_Actualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Actualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Actualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Actualizar.Image = Global.SistemaCinderella.My.Resources.Recursos.Editar_24
        Me.Btn_Actualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Actualizar.Location = New System.Drawing.Point(304, 404)
        Me.Btn_Actualizar.Name = "Btn_Actualizar"
        Me.Btn_Actualizar.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Actualizar.TabIndex = 2
        Me.Btn_Actualizar.Text = "Modificar"
        Me.Btn_Actualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Actualizar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label35)
        Me.GroupBox1.Controls.Add(Me.GroupBox13)
        Me.GroupBox1.Controls.Add(Me.lbl_SucursalActual)
        Me.GroupBox1.Controls.Add(Me.lbl_NombreSucursalActual)
        Me.GroupBox1.Controls.Add(Me.Btn_Actualizar)
        Me.GroupBox1.Controls.Add(Me.lbl_NuevaSucursal)
        Me.GroupBox1.Controls.Add(Me.Cb_Sucursales)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(410, 450)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Configuración de Sucursal"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(9, 392)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(119, 15)
        Me.Label35.TabIndex = 11
        Me.Label35.Text = "Campo requerido (*)"
        '
        'GroupBox13
        '
        Me.GroupBox13.Controls.Add(Me.txt_DatosFiscalLocalidad)
        Me.GroupBox13.Controls.Add(Me.Label41)
        Me.GroupBox13.Controls.Add(Me.txt_DatosFiscalNombreFantasiaFuente)
        Me.GroupBox13.Controls.Add(Me.txt_DatosFiscalEmail)
        Me.GroupBox13.Controls.Add(Me.Label40)
        Me.GroupBox13.Controls.Add(Me.txt_DatosFiscalTelefono)
        Me.GroupBox13.Controls.Add(Me.Label39)
        Me.GroupBox13.Controls.Add(Me.txt_DatosFiscalDireccion)
        Me.GroupBox13.Controls.Add(Me.Label38)
        Me.GroupBox13.Controls.Add(Me.dt_DatosFiscalInicioActividad)
        Me.GroupBox13.Controls.Add(Me.Label37)
        Me.GroupBox13.Controls.Add(Me.txt_DatosFiscalIIBB)
        Me.GroupBox13.Controls.Add(Me.Label27)
        Me.GroupBox13.Controls.Add(Me.txt_DatosFiscalCUIT)
        Me.GroupBox13.Controls.Add(Me.Label26)
        Me.GroupBox13.Controls.Add(Me.txt_DatosFiscalRazonSocial)
        Me.GroupBox13.Controls.Add(Me.Label25)
        Me.GroupBox13.Controls.Add(Me.txt_DatosFiscalNombreFantasia)
        Me.GroupBox13.Controls.Add(Me.Label34)
        Me.GroupBox13.Location = New System.Drawing.Point(7, 99)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(397, 290)
        Me.GroupBox13.TabIndex = 8
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "Datos Fiscales"
        '
        'txt_DatosFiscalLocalidad
        '
        Me.txt_DatosFiscalLocalidad.Location = New System.Drawing.Point(133, 101)
        Me.txt_DatosFiscalLocalidad.Name = "txt_DatosFiscalLocalidad"
        Me.txt_DatosFiscalLocalidad.Size = New System.Drawing.Size(258, 21)
        Me.txt_DatosFiscalLocalidad.TabIndex = 4
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(6, 104)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(80, 15)
        Me.Label41.TabIndex = 27
        Me.Label41.Text = "(*) Localidad:"
        '
        'txt_DatosFiscalNombreFantasiaFuente
        '
        Me.txt_DatosFiscalNombreFantasiaFuente.Location = New System.Drawing.Point(335, 19)
        Me.txt_DatosFiscalNombreFantasiaFuente.Name = "txt_DatosFiscalNombreFantasiaFuente"
        Me.txt_DatosFiscalNombreFantasiaFuente.Size = New System.Drawing.Size(56, 23)
        Me.txt_DatosFiscalNombreFantasiaFuente.TabIndex = 1
        Me.txt_DatosFiscalNombreFantasiaFuente.Text = "Fuente"
        Me.txt_DatosFiscalNombreFantasiaFuente.UseVisualStyleBackColor = True
        '
        'txt_DatosFiscalEmail
        '
        Me.txt_DatosFiscalEmail.Location = New System.Drawing.Point(133, 155)
        Me.txt_DatosFiscalEmail.Name = "txt_DatosFiscalEmail"
        Me.txt_DatosFiscalEmail.Size = New System.Drawing.Size(258, 21)
        Me.txt_DatosFiscalEmail.TabIndex = 6
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(6, 158)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(42, 15)
        Me.Label40.TabIndex = 24
        Me.Label40.Text = "Email:"
        '
        'txt_DatosFiscalTelefono
        '
        Me.txt_DatosFiscalTelefono.Location = New System.Drawing.Point(133, 128)
        Me.txt_DatosFiscalTelefono.Name = "txt_DatosFiscalTelefono"
        Me.txt_DatosFiscalTelefono.Size = New System.Drawing.Size(258, 21)
        Me.txt_DatosFiscalTelefono.TabIndex = 5
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(6, 131)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(74, 15)
        Me.Label39.TabIndex = 22
        Me.Label39.Text = "(*) Teléfono:"
        '
        'txt_DatosFiscalDireccion
        '
        Me.txt_DatosFiscalDireccion.Location = New System.Drawing.Point(133, 74)
        Me.txt_DatosFiscalDireccion.Name = "txt_DatosFiscalDireccion"
        Me.txt_DatosFiscalDireccion.Size = New System.Drawing.Size(258, 21)
        Me.txt_DatosFiscalDireccion.TabIndex = 3
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(6, 77)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(78, 15)
        Me.Label38.TabIndex = 20
        Me.Label38.Text = "(*) Dirección:"
        '
        'dt_DatosFiscalInicioActividad
        '
        Me.dt_DatosFiscalInicioActividad.Location = New System.Drawing.Point(133, 239)
        Me.dt_DatosFiscalInicioActividad.Name = "dt_DatosFiscalInicioActividad"
        Me.dt_DatosFiscalInicioActividad.Size = New System.Drawing.Size(258, 21)
        Me.dt_DatosFiscalInicioActividad.TabIndex = 9
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(6, 239)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(106, 15)
        Me.Label37.TabIndex = 18
        Me.Label37.Text = "(*) Inicio Actividad:"
        '
        'txt_DatosFiscalIIBB
        '
        Me.txt_DatosFiscalIIBB.Location = New System.Drawing.Point(133, 209)
        Me.txt_DatosFiscalIIBB.Name = "txt_DatosFiscalIIBB"
        Me.txt_DatosFiscalIIBB.Size = New System.Drawing.Size(258, 21)
        Me.txt_DatosFiscalIIBB.TabIndex = 8
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(6, 212)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(48, 15)
        Me.Label27.TabIndex = 16
        Me.Label27.Text = "(*) IIBB:"
        '
        'txt_DatosFiscalCUIT
        '
        Me.txt_DatosFiscalCUIT.Location = New System.Drawing.Point(133, 182)
        Me.txt_DatosFiscalCUIT.Name = "txt_DatosFiscalCUIT"
        Me.txt_DatosFiscalCUIT.Size = New System.Drawing.Size(258, 21)
        Me.txt_DatosFiscalCUIT.TabIndex = 7
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(6, 185)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(53, 15)
        Me.Label26.TabIndex = 14
        Me.Label26.Text = "(*) CUIT:"
        '
        'txt_DatosFiscalRazonSocial
        '
        Me.txt_DatosFiscalRazonSocial.Location = New System.Drawing.Point(133, 47)
        Me.txt_DatosFiscalRazonSocial.Name = "txt_DatosFiscalRazonSocial"
        Me.txt_DatosFiscalRazonSocial.Size = New System.Drawing.Size(258, 21)
        Me.txt_DatosFiscalRazonSocial.TabIndex = 2
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(6, 50)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(99, 15)
        Me.Label25.TabIndex = 12
        Me.Label25.Text = "(*) Razón Social:"
        '
        'txt_DatosFiscalNombreFantasia
        '
        Me.txt_DatosFiscalNombreFantasia.Location = New System.Drawing.Point(133, 20)
        Me.txt_DatosFiscalNombreFantasia.Name = "txt_DatosFiscalNombreFantasia"
        Me.txt_DatosFiscalNombreFantasia.Size = New System.Drawing.Size(196, 21)
        Me.txt_DatosFiscalNombreFantasia.TabIndex = 0
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(6, 23)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(121, 15)
        Me.Label34.TabIndex = 10
        Me.Label34.Text = "(*) Nombre Fantasía:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_descuentoMinorista)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.lbl_NombreListaActual)
        Me.GroupBox2.Controls.Add(Me.Btn_Precios)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.cb_Precios)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(410, 450)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Configuración de Precios"
        '
        'txt_descuentoMinorista
        '
        Me.txt_descuentoMinorista.Location = New System.Drawing.Point(185, 114)
        Me.txt_descuentoMinorista.Name = "txt_descuentoMinorista"
        Me.txt_descuentoMinorista.Size = New System.Drawing.Size(219, 21)
        Me.txt_descuentoMinorista.TabIndex = 2
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(9, 107)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(158, 35)
        Me.Label24.TabIndex = 10
        Me.Label24.Text = "Bonificación % pago en efectivo minorista:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Lista de Precios Actual: "
        '
        'lbl_NombreListaActual
        '
        Me.lbl_NombreListaActual.AutoSize = True
        Me.lbl_NombreListaActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NombreListaActual.Location = New System.Drawing.Point(182, 34)
        Me.lbl_NombreListaActual.Name = "lbl_NombreListaActual"
        Me.lbl_NombreListaActual.Size = New System.Drawing.Size(30, 13)
        Me.lbl_NombreListaActual.TabIndex = 0
        Me.lbl_NombreListaActual.Text = "lista"
        '
        'Btn_Precios
        '
        Me.Btn_Precios.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Precios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Precios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Precios.Image = Global.SistemaCinderella.My.Resources.Recursos.Editar_24
        Me.Btn_Precios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Precios.Location = New System.Drawing.Point(304, 404)
        Me.Btn_Precios.Name = "Btn_Precios"
        Me.Btn_Precios.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Precios.TabIndex = 3
        Me.Btn_Precios.Text = "Modificar"
        Me.Btn_Precios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Precios.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nueva Lista de Precios:"
        '
        'cb_Precios
        '
        Me.cb_Precios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_Precios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Precios.FormattingEnabled = True
        Me.cb_Precios.Location = New System.Drawing.Point(185, 68)
        Me.cb_Precios.Name = "cb_Precios"
        Me.cb_Precios.Size = New System.Drawing.Size(219, 23)
        Me.cb_Precios.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label31)
        Me.GroupBox3.Controls.Add(Me.Panel5)
        Me.GroupBox3.Controls.Add(Me.txtPort)
        Me.GroupBox3.Controls.Add(Me.txtSmtp)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.BtnMailing)
        Me.GroupBox3.Controls.Add(Me.lblPort)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(416, 456)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Configuración del Servidor de Mail"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(8, 96)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(70, 15)
        Me.Label31.TabIndex = 31
        Me.Label31.Text = "Utiliza SSL:"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.rbUtilizaSSLNo)
        Me.Panel5.Controls.Add(Me.rbUtilizaSSLSi)
        Me.Panel5.Location = New System.Drawing.Point(119, 89)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(170, 27)
        Me.Panel5.TabIndex = 2
        '
        'rbUtilizaSSLNo
        '
        Me.rbUtilizaSSLNo.AutoSize = True
        Me.rbUtilizaSSLNo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbUtilizaSSLNo.Location = New System.Drawing.Point(124, 3)
        Me.rbUtilizaSSLNo.Name = "rbUtilizaSSLNo"
        Me.rbUtilizaSSLNo.Size = New System.Drawing.Size(43, 19)
        Me.rbUtilizaSSLNo.TabIndex = 26
        Me.rbUtilizaSSLNo.Tag = ""
        Me.rbUtilizaSSLNo.Text = "NO"
        Me.rbUtilizaSSLNo.UseVisualStyleBackColor = True
        '
        'rbUtilizaSSLSi
        '
        Me.rbUtilizaSSLSi.AutoSize = True
        Me.rbUtilizaSSLSi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbUtilizaSSLSi.Location = New System.Drawing.Point(11, 3)
        Me.rbUtilizaSSLSi.Name = "rbUtilizaSSLSi"
        Me.rbUtilizaSSLSi.Size = New System.Drawing.Size(36, 19)
        Me.rbUtilizaSSLSi.TabIndex = 25
        Me.rbUtilizaSSLSi.Tag = ""
        Me.rbUtilizaSSLSi.Text = "SI"
        Me.rbUtilizaSSLSi.UseVisualStyleBackColor = True
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(119, 62)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(289, 21)
        Me.txtPort.TabIndex = 1
        '
        'txtSmtp
        '
        Me.txtSmtp.Location = New System.Drawing.Point(119, 30)
        Me.txtSmtp.Name = "txtSmtp"
        Me.txtSmtp.Size = New System.Drawing.Size(289, 21)
        Me.txtSmtp.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Servidor SMTP:"
        '
        'BtnMailing
        '
        Me.BtnMailing.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMailing.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMailing.Image = Global.SistemaCinderella.My.Resources.Recursos.Editar_24
        Me.BtnMailing.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnMailing.Location = New System.Drawing.Point(308, 383)
        Me.BtnMailing.Name = "BtnMailing"
        Me.BtnMailing.Size = New System.Drawing.Size(100, 40)
        Me.BtnMailing.TabIndex = 3
        Me.BtnMailing.Text = "Modificar"
        Me.BtnMailing.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnMailing.UseVisualStyleBackColor = True
        '
        'lblPort
        '
        Me.lblPort.AutoSize = True
        Me.lblPort.Location = New System.Drawing.Point(7, 68)
        Me.lblPort.Name = "lblPort"
        Me.lblPort.Size = New System.Drawing.Size(46, 15)
        Me.lblPort.TabIndex = 3
        Me.lblPort.Text = "Puerto:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Cb_ModeloControladora)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Controls.Add(Me.Cb_ConexionControladora)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Panel1)
        Me.GroupBox4.Controls.Add(Me.Panel2)
        Me.GroupBox4.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(381, 141)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Configuración de Controlador Fiscal"
        '
        'Cb_ModeloControladora
        '
        Me.Cb_ModeloControladora.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cb_ModeloControladora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_ModeloControladora.FormattingEnabled = True
        Me.Cb_ModeloControladora.Items.AddRange(New Object() {"TM-U220AFII", "TM-T900FA"})
        Me.Cb_ModeloControladora.Location = New System.Drawing.Point(209, 80)
        Me.Cb_ModeloControladora.Name = "Cb_ModeloControladora"
        Me.Cb_ModeloControladora.Size = New System.Drawing.Size(166, 23)
        Me.Cb_ModeloControladora.TabIndex = 2
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(9, 83)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(119, 15)
        Me.Label19.TabIndex = 29
        Me.Label19.Text = "Modelo Controlador:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(9, 29)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(202, 15)
        Me.Label23.TabIndex = 24
        Me.Label23.Text = "Habilitar Condición ""Exento sin IVA"":"
        '
        'Cb_ConexionControladora
        '
        Me.Cb_ConexionControladora.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cb_ConexionControladora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_ConexionControladora.FormattingEnabled = True
        Me.Cb_ConexionControladora.Items.AddRange(New Object() {"USB", "COM1"})
        Me.Cb_ConexionControladora.Location = New System.Drawing.Point(209, 109)
        Me.Cb_ConexionControladora.Name = "Cb_ConexionControladora"
        Me.Cb_ConexionControladora.Size = New System.Drawing.Size(166, 23)
        Me.Cb_ConexionControladora.TabIndex = 3
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(9, 112)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(106, 15)
        Me.Label17.TabIndex = 21
        Me.Label17.Text = "Tipo de Conexión:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(210, 15)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "La sucursal utiliza Controlador Fiscal:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RExentoSinIvaNo)
        Me.Panel1.Controls.Add(Me.RExentoSinIvaSI)
        Me.Panel1.Location = New System.Drawing.Point(221, 20)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(154, 26)
        Me.Panel1.TabIndex = 0
        '
        'RExentoSinIvaNo
        '
        Me.RExentoSinIvaNo.AutoSize = True
        Me.RExentoSinIvaNo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RExentoSinIvaNo.Location = New System.Drawing.Point(108, 2)
        Me.RExentoSinIvaNo.Name = "RExentoSinIvaNo"
        Me.RExentoSinIvaNo.Size = New System.Drawing.Size(43, 19)
        Me.RExentoSinIvaNo.TabIndex = 26
        Me.RExentoSinIvaNo.Tag = ""
        Me.RExentoSinIvaNo.Text = "NO"
        Me.RExentoSinIvaNo.UseVisualStyleBackColor = True
        '
        'RExentoSinIvaSI
        '
        Me.RExentoSinIvaSI.AutoSize = True
        Me.RExentoSinIvaSI.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RExentoSinIvaSI.Location = New System.Drawing.Point(11, 3)
        Me.RExentoSinIvaSI.Name = "RExentoSinIvaSI"
        Me.RExentoSinIvaSI.Size = New System.Drawing.Size(36, 19)
        Me.RExentoSinIvaSI.TabIndex = 0
        Me.RExentoSinIvaSI.Tag = ""
        Me.RExentoSinIvaSI.Text = "SI"
        Me.RExentoSinIvaSI.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.RContrSI)
        Me.Panel2.Controls.Add(Me.RContrNO)
        Me.Panel2.Location = New System.Drawing.Point(221, 48)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(154, 26)
        Me.Panel2.TabIndex = 1
        '
        'RContrSI
        '
        Me.RContrSI.AutoSize = True
        Me.RContrSI.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RContrSI.Location = New System.Drawing.Point(10, 2)
        Me.RContrSI.Name = "RContrSI"
        Me.RContrSI.Size = New System.Drawing.Size(36, 19)
        Me.RContrSI.TabIndex = 0
        Me.RContrSI.Tag = ""
        Me.RContrSI.Text = "SI"
        Me.RContrSI.UseVisualStyleBackColor = True
        '
        'RContrNO
        '
        Me.RContrNO.AutoSize = True
        Me.RContrNO.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RContrNO.Location = New System.Drawing.Point(108, 2)
        Me.RContrNO.Name = "RContrNO"
        Me.RContrNO.Size = New System.Drawing.Size(43, 19)
        Me.RContrNO.TabIndex = 13
        Me.RContrNO.Tag = ""
        Me.RContrNO.Text = "NO"
        Me.RContrNO.UseVisualStyleBackColor = True
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.Label6)
        Me.GroupBox9.Controls.Add(Me.Label7)
        Me.GroupBox9.Controls.Add(Me.Label20)
        Me.GroupBox9.Controls.Add(Me.txt_MontoTopeElectronico)
        Me.GroupBox9.Controls.Add(Me.txt_MontoTopeManual)
        Me.GroupBox9.Controls.Add(Me.txt_MontoTopeTicket)
        Me.GroupBox9.Location = New System.Drawing.Point(3, 150)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(381, 113)
        Me.GroupBox9.TabIndex = 1
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Monto final tope "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 15)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Factura Electronica:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 15)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Factura Manual:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 23)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(116, 15)
        Me.Label20.TabIndex = 18
        Me.Label20.Text = "Controladora Fiscal:"
        '
        'txt_MontoTopeElectronico
        '
        Me.txt_MontoTopeElectronico.Location = New System.Drawing.Point(209, 74)
        Me.txt_MontoTopeElectronico.Name = "txt_MontoTopeElectronico"
        Me.txt_MontoTopeElectronico.Size = New System.Drawing.Size(166, 21)
        Me.txt_MontoTopeElectronico.TabIndex = 2
        '
        'txt_MontoTopeManual
        '
        Me.txt_MontoTopeManual.Location = New System.Drawing.Point(209, 47)
        Me.txt_MontoTopeManual.Name = "txt_MontoTopeManual"
        Me.txt_MontoTopeManual.Size = New System.Drawing.Size(166, 21)
        Me.txt_MontoTopeManual.TabIndex = 1
        '
        'txt_MontoTopeTicket
        '
        Me.txt_MontoTopeTicket.Location = New System.Drawing.Point(209, 20)
        Me.txt_MontoTopeTicket.Name = "txt_MontoTopeTicket"
        Me.txt_MontoTopeTicket.Size = New System.Drawing.Size(166, 21)
        Me.txt_MontoTopeTicket.TabIndex = 0
        '
        'txt_MontoMaximoNotaCredito
        '
        Me.txt_MontoMaximoNotaCredito.Location = New System.Drawing.Point(212, 278)
        Me.txt_MontoMaximoNotaCredito.Name = "txt_MontoMaximoNotaCredito"
        Me.txt_MontoMaximoNotaCredito.Size = New System.Drawing.Size(167, 21)
        Me.txt_MontoMaximoNotaCredito.TabIndex = 2
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(0, 266)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(205, 45)
        Me.Label16.TabIndex = 18
        Me.Label16.Text = "Se posibilita generar notas de crédito hasta un monto final total de: "
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.txt_PuntoVentaElectronica)
        Me.GroupBox7.Controls.Add(Me.txt_PuntoVentaManual)
        Me.GroupBox7.Controls.Add(Me.txt_PuntoVentaControladora)
        Me.GroupBox7.Controls.Add(Me.Label14)
        Me.GroupBox7.Controls.Add(Me.Label13)
        Me.GroupBox7.Controls.Add(Me.Label12)
        Me.GroupBox7.Location = New System.Drawing.Point(3, 305)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(381, 109)
        Me.GroupBox7.TabIndex = 3
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Puntos de venta"
        '
        'txt_PuntoVentaElectronica
        '
        Me.txt_PuntoVentaElectronica.Location = New System.Drawing.Point(209, 74)
        Me.txt_PuntoVentaElectronica.Name = "txt_PuntoVentaElectronica"
        Me.txt_PuntoVentaElectronica.Size = New System.Drawing.Size(166, 21)
        Me.txt_PuntoVentaElectronica.TabIndex = 2
        '
        'txt_PuntoVentaManual
        '
        Me.txt_PuntoVentaManual.Location = New System.Drawing.Point(209, 47)
        Me.txt_PuntoVentaManual.Name = "txt_PuntoVentaManual"
        Me.txt_PuntoVentaManual.Size = New System.Drawing.Size(166, 21)
        Me.txt_PuntoVentaManual.TabIndex = 1
        '
        'txt_PuntoVentaControladora
        '
        Me.txt_PuntoVentaControladora.Location = New System.Drawing.Point(209, 20)
        Me.txt_PuntoVentaControladora.Name = "txt_PuntoVentaControladora"
        Me.txt_PuntoVentaControladora.Size = New System.Drawing.Size(166, 21)
        Me.txt_PuntoVentaControladora.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 77)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(115, 15)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Factura Electronica:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 50)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 15)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Factura Manual:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 23)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(116, 15)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Controladora Fiscal:"
        '
        'Btn_Controlador
        '
        Me.Btn_Controlador.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Controlador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Controlador.Image = Global.SistemaCinderella.My.Resources.Recursos.Editar_24
        Me.Btn_Controlador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Controlador.Location = New System.Drawing.Point(284, 554)
        Me.Btn_Controlador.Name = "Btn_Controlador"
        Me.Btn_Controlador.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Controlador.TabIndex = 5
        Me.Btn_Controlador.Text = "Modificar"
        Me.Btn_Controlador.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Controlador.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabSucursal)
        Me.TabControl1.Controls.Add(Me.TabPrecios)
        Me.TabControl1.Controls.Add(Me.TabMail)
        Me.TabControl1.Controls.Add(Me.TabFacturacion)
        Me.TabControl1.Controls.Add(Me.TabNotificaciones)
        Me.TabControl1.Controls.Add(Me.TabInternet)
        Me.TabControl1.Controls.Add(Me.TabHost)
        Me.TabControl1.Controls.Add(Me.TabStock)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(424, 484)
        Me.TabControl1.TabIndex = 0
        '
        'TabSucursal
        '
        Me.TabSucursal.Controls.Add(Me.GroupBox1)
        Me.TabSucursal.Location = New System.Drawing.Point(4, 24)
        Me.TabSucursal.Name = "TabSucursal"
        Me.TabSucursal.Padding = New System.Windows.Forms.Padding(3)
        Me.TabSucursal.Size = New System.Drawing.Size(416, 456)
        Me.TabSucursal.TabIndex = 0
        Me.TabSucursal.Text = "Sucursal"
        Me.TabSucursal.UseVisualStyleBackColor = True
        '
        'TabPrecios
        '
        Me.TabPrecios.Controls.Add(Me.GroupBox2)
        Me.TabPrecios.Location = New System.Drawing.Point(4, 24)
        Me.TabPrecios.Name = "TabPrecios"
        Me.TabPrecios.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPrecios.Size = New System.Drawing.Size(416, 456)
        Me.TabPrecios.TabIndex = 1
        Me.TabPrecios.Text = "Precios"
        Me.TabPrecios.UseVisualStyleBackColor = True
        '
        'TabMail
        '
        Me.TabMail.Controls.Add(Me.GroupBox3)
        Me.TabMail.Location = New System.Drawing.Point(4, 24)
        Me.TabMail.Name = "TabMail"
        Me.TabMail.Size = New System.Drawing.Size(416, 456)
        Me.TabMail.TabIndex = 2
        Me.TabMail.Text = "Mail"
        Me.TabMail.UseVisualStyleBackColor = True
        '
        'TabFacturacion
        '
        Me.TabFacturacion.AutoScroll = True
        Me.TabFacturacion.Controls.Add(Me.Panel3)
        Me.TabFacturacion.Location = New System.Drawing.Point(4, 24)
        Me.TabFacturacion.Name = "TabFacturacion"
        Me.TabFacturacion.Size = New System.Drawing.Size(416, 456)
        Me.TabFacturacion.TabIndex = 3
        Me.TabFacturacion.Text = "Facturación"
        Me.TabFacturacion.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.AutoScroll = True
        Me.Panel3.Controls.Add(Me.GroupBox10)
        Me.Panel3.Controls.Add(Me.GroupBox4)
        Me.Panel3.Controls.Add(Me.GroupBox9)
        Me.Panel3.Controls.Add(Me.GroupBox7)
        Me.Panel3.Controls.Add(Me.Btn_Controlador)
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Controls.Add(Me.txt_MontoMaximoNotaCredito)
        Me.Panel3.Location = New System.Drawing.Point(8, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(389, 603)
        Me.Panel3.TabIndex = 31
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.btnCargarCertificadoAFIP)
        Me.GroupBox10.Controls.Add(Me.btnObtenerArchivoCSR)
        Me.GroupBox10.Controls.Add(Me.txt_facturacionElectronicaCertificadoVencimiento)
        Me.GroupBox10.Controls.Add(Me.txt_facturacionElectronicaCertificadoNombre)
        Me.GroupBox10.Controls.Add(Me.Label42)
        Me.GroupBox10.Controls.Add(Me.Label43)
        Me.GroupBox10.Location = New System.Drawing.Point(3, 420)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(381, 128)
        Me.GroupBox10.TabIndex = 4
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Certificado Facturacion Electrónico"
        '
        'btnCargarCertificadoAFIP
        '
        Me.btnCargarCertificadoAFIP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCargarCertificadoAFIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargarCertificadoAFIP.Image = Global.SistemaCinderella.My.Resources.Recursos.btn_certificado
        Me.btnCargarCertificadoAFIP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCargarCertificadoAFIP.Location = New System.Drawing.Point(72, 74)
        Me.btnCargarCertificadoAFIP.Name = "btnCargarCertificadoAFIP"
        Me.btnCargarCertificadoAFIP.Size = New System.Drawing.Size(153, 40)
        Me.btnCargarCertificadoAFIP.TabIndex = 2
        Me.btnCargarCertificadoAFIP.Text = "Cargar Certificado AFIP"
        Me.btnCargarCertificadoAFIP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCargarCertificadoAFIP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCargarCertificadoAFIP.UseVisualStyleBackColor = True
        '
        'btnObtenerArchivoCSR
        '
        Me.btnObtenerArchivoCSR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnObtenerArchivoCSR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnObtenerArchivoCSR.Image = Global.SistemaCinderella.My.Resources.Recursos.Archivo
        Me.btnObtenerArchivoCSR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnObtenerArchivoCSR.Location = New System.Drawing.Point(231, 74)
        Me.btnObtenerArchivoCSR.Name = "btnObtenerArchivoCSR"
        Me.btnObtenerArchivoCSR.Size = New System.Drawing.Size(141, 40)
        Me.btnObtenerArchivoCSR.TabIndex = 3
        Me.btnObtenerArchivoCSR.Text = "Generar Archivo CSR"
        Me.btnObtenerArchivoCSR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnObtenerArchivoCSR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnObtenerArchivoCSR.UseVisualStyleBackColor = True
        '
        'txt_facturacionElectronicaCertificadoVencimiento
        '
        Me.txt_facturacionElectronicaCertificadoVencimiento.BackColor = System.Drawing.SystemColors.Window
        Me.txt_facturacionElectronicaCertificadoVencimiento.Location = New System.Drawing.Point(127, 47)
        Me.txt_facturacionElectronicaCertificadoVencimiento.Name = "txt_facturacionElectronicaCertificadoVencimiento"
        Me.txt_facturacionElectronicaCertificadoVencimiento.ReadOnly = True
        Me.txt_facturacionElectronicaCertificadoVencimiento.Size = New System.Drawing.Size(245, 21)
        Me.txt_facturacionElectronicaCertificadoVencimiento.TabIndex = 1
        '
        'txt_facturacionElectronicaCertificadoNombre
        '
        Me.txt_facturacionElectronicaCertificadoNombre.BackColor = System.Drawing.SystemColors.Window
        Me.txt_facturacionElectronicaCertificadoNombre.Location = New System.Drawing.Point(127, 20)
        Me.txt_facturacionElectronicaCertificadoNombre.Name = "txt_facturacionElectronicaCertificadoNombre"
        Me.txt_facturacionElectronicaCertificadoNombre.ReadOnly = True
        Me.txt_facturacionElectronicaCertificadoNombre.Size = New System.Drawing.Size(245, 21)
        Me.txt_facturacionElectronicaCertificadoNombre.TabIndex = 0
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(6, 50)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(115, 15)
        Me.Label42.TabIndex = 1
        Me.Label42.Text = "Fecha Vencimiento:"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(6, 23)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(28, 15)
        Me.Label43.TabIndex = 0
        Me.Label43.Text = "DN:"
        '
        'TabNotificaciones
        '
        Me.TabNotificaciones.Controls.Add(Me.GroupBox5)
        Me.TabNotificaciones.Location = New System.Drawing.Point(4, 24)
        Me.TabNotificaciones.Name = "TabNotificaciones"
        Me.TabNotificaciones.Size = New System.Drawing.Size(416, 456)
        Me.TabNotificaciones.TabIndex = 4
        Me.TabNotificaciones.Text = "Alertas"
        Me.TabNotificaciones.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Controls.Add(Me.Cb_TiempoComprobacionCheques)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Controls.Add(Me.Cb_TiempoComprobacionMovimientos)
        Me.GroupBox5.Controls.Add(Me.BtnNotificaciones)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.Cb_TiempoComprobacionMensajes)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox5.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(416, 456)
        Me.GroupBox5.TabIndex = 7
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Configuración de Alertas"
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(9, 112)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(261, 36)
        Me.Label18.TabIndex = 7
        Me.Label18.Text = "Período de comprobación de cheques por vencer (Minutos)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Cb_TiempoComprobacionCheques
        '
        Me.Cb_TiempoComprobacionCheques.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cb_TiempoComprobacionCheques.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_TiempoComprobacionCheques.FormattingEnabled = True
        Me.Cb_TiempoComprobacionCheques.Items.AddRange(New Object() {"5", "10", "15", "30", "60"})
        Me.Cb_TiempoComprobacionCheques.Location = New System.Drawing.Point(276, 119)
        Me.Cb_TiempoComprobacionCheques.Name = "Cb_TiempoComprobacionCheques"
        Me.Cb_TiempoComprobacionCheques.Size = New System.Drawing.Size(131, 23)
        Me.Cb_TiempoComprobacionCheques.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(261, 36)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Período de comprobación de movimientos entre sucursales (Minutos)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Cb_TiempoComprobacionMovimientos
        '
        Me.Cb_TiempoComprobacionMovimientos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cb_TiempoComprobacionMovimientos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_TiempoComprobacionMovimientos.FormattingEnabled = True
        Me.Cb_TiempoComprobacionMovimientos.Items.AddRange(New Object() {"5", "10", "15", "30", "60"})
        Me.Cb_TiempoComprobacionMovimientos.Location = New System.Drawing.Point(275, 77)
        Me.Cb_TiempoComprobacionMovimientos.Name = "Cb_TiempoComprobacionMovimientos"
        Me.Cb_TiempoComprobacionMovimientos.Size = New System.Drawing.Size(132, 23)
        Me.Cb_TiempoComprobacionMovimientos.TabIndex = 1
        '
        'BtnNotificaciones
        '
        Me.BtnNotificaciones.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnNotificaciones.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNotificaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNotificaciones.Image = Global.SistemaCinderella.My.Resources.Recursos.Editar_24
        Me.BtnNotificaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNotificaciones.Location = New System.Drawing.Point(307, 407)
        Me.BtnNotificaciones.Name = "BtnNotificaciones"
        Me.BtnNotificaciones.Size = New System.Drawing.Size(100, 40)
        Me.BtnNotificaciones.TabIndex = 3
        Me.BtnNotificaciones.Text = "Modificar"
        Me.BtnNotificaciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNotificaciones.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(8, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(261, 36)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Período de comprobación de nuevos mensajes (Minutos)"
        '
        'Cb_TiempoComprobacionMensajes
        '
        Me.Cb_TiempoComprobacionMensajes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cb_TiempoComprobacionMensajes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_TiempoComprobacionMensajes.FormattingEnabled = True
        Me.Cb_TiempoComprobacionMensajes.Items.AddRange(New Object() {"5", "10", "15", "30", "60"})
        Me.Cb_TiempoComprobacionMensajes.Location = New System.Drawing.Point(275, 35)
        Me.Cb_TiempoComprobacionMensajes.Name = "Cb_TiempoComprobacionMensajes"
        Me.Cb_TiempoComprobacionMensajes.Size = New System.Drawing.Size(132, 23)
        Me.Cb_TiempoComprobacionMensajes.TabIndex = 0
        '
        'TabInternet
        '
        Me.TabInternet.Controls.Add(Me.GroupBox6)
        Me.TabInternet.Location = New System.Drawing.Point(4, 24)
        Me.TabInternet.Name = "TabInternet"
        Me.TabInternet.Size = New System.Drawing.Size(416, 456)
        Me.TabInternet.TabIndex = 5
        Me.TabInternet.Text = "Internet"
        Me.TabInternet.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.btn_ConfigurarBaseDatos)
        Me.GroupBox6.Controls.Add(Me.Label36)
        Me.GroupBox6.Controls.Add(Me.Cb_HorasSincronizacion)
        Me.GroupBox6.Controls.Add(Me.btnVerificarDNS)
        Me.GroupBox6.Controls.Add(Me.txt_IpPing)
        Me.GroupBox6.Controls.Add(Me.Label33)
        Me.GroupBox6.Controls.Add(Me.Cb_TimeOut)
        Me.GroupBox6.Controls.Add(Me.Label32)
        Me.GroupBox6.Controls.Add(Me.Rb2)
        Me.GroupBox6.Controls.Add(Me.Rb1)
        Me.GroupBox6.Controls.Add(Me.Label11)
        Me.GroupBox6.Controls.Add(Me.Label8)
        Me.GroupBox6.Controls.Add(Me.BtnInternet)
        Me.GroupBox6.Controls.Add(Me.Label10)
        Me.GroupBox6.Controls.Add(Me.Cb_SegundosInternet)
        Me.GroupBox6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox6.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(416, 456)
        Me.GroupBox6.TabIndex = 8
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Configuración de Internet"
        '
        'btn_ConfigurarBaseDatos
        '
        Me.btn_ConfigurarBaseDatos.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btn_ConfigurarBaseDatos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ConfigurarBaseDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ConfigurarBaseDatos.Image = Global.SistemaCinderella.My.Resources.Recursos.configurar_basedatos
        Me.btn_ConfigurarBaseDatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ConfigurarBaseDatos.Location = New System.Drawing.Point(255, 253)
        Me.btn_ConfigurarBaseDatos.Name = "btn_ConfigurarBaseDatos"
        Me.btn_ConfigurarBaseDatos.Size = New System.Drawing.Size(155, 40)
        Me.btn_ConfigurarBaseDatos.TabIndex = 27
        Me.btn_ConfigurarBaseDatos.Text = "Configurar Base Datos"
        Me.btn_ConfigurarBaseDatos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ConfigurarBaseDatos.UseVisualStyleBackColor = True
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(6, 130)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(193, 15)
        Me.Label36.TabIndex = 23
        Me.Label36.Text = "Período de Sincronización (horas)"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cb_HorasSincronizacion
        '
        Me.Cb_HorasSincronizacion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cb_HorasSincronizacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_HorasSincronizacion.FormattingEnabled = True
        Me.Cb_HorasSincronizacion.Items.AddRange(New Object() {"0", "1", "2", "4", "8"})
        Me.Cb_HorasSincronizacion.Location = New System.Drawing.Point(236, 122)
        Me.Cb_HorasSincronizacion.Name = "Cb_HorasSincronizacion"
        Me.Cb_HorasSincronizacion.Size = New System.Drawing.Size(171, 23)
        Me.Cb_HorasSincronizacion.TabIndex = 3
        '
        'btnVerificarDNS
        '
        Me.btnVerificarDNS.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnVerificarDNS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVerificarDNS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerificarDNS.Image = Global.SistemaCinderella.My.Resources.Recursos.Internet_32
        Me.btnVerificarDNS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVerificarDNS.Location = New System.Drawing.Point(255, 207)
        Me.btnVerificarDNS.Name = "btnVerificarDNS"
        Me.btnVerificarDNS.Size = New System.Drawing.Size(155, 40)
        Me.btnVerificarDNS.TabIndex = 6
        Me.btnVerificarDNS.Text = "Verificar DNS"
        Me.btnVerificarDNS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVerificarDNS.UseVisualStyleBackColor = True
        '
        'txt_IpPing
        '
        Me.txt_IpPing.Location = New System.Drawing.Point(236, 151)
        Me.txt_IpPing.Name = "txt_IpPing"
        Me.txt_IpPing.Size = New System.Drawing.Size(171, 21)
        Me.txt_IpPing.TabIndex = 4
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(6, 186)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(209, 15)
        Me.Label33.TabIndex = 19
        Me.Label33.Text = "Tiempo de espera (en milisegundos)"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cb_TimeOut
        '
        Me.Cb_TimeOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cb_TimeOut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_TimeOut.FormattingEnabled = True
        Me.Cb_TimeOut.Items.AddRange(New Object() {"500", "1000", "2000", "3000", "5000"})
        Me.Cb_TimeOut.Location = New System.Drawing.Point(236, 178)
        Me.Cb_TimeOut.Name = "Cb_TimeOut"
        Me.Cb_TimeOut.Size = New System.Drawing.Size(171, 23)
        Me.Cb_TimeOut.TabIndex = 5
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(6, 157)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(205, 15)
        Me.Label32.TabIndex = 17
        Me.Label32.Text = "IP de DNS verificar acceso a internet"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Rb2
        '
        Me.Rb2.AutoSize = True
        Me.Rb2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Rb2.Location = New System.Drawing.Point(364, 68)
        Me.Rb2.Name = "Rb2"
        Me.Rb2.Size = New System.Drawing.Size(43, 19)
        Me.Rb2.TabIndex = 1
        Me.Rb2.Text = "NO"
        Me.Rb2.UseVisualStyleBackColor = True
        '
        'Rb1
        '
        Me.Rb1.AutoSize = True
        Me.Rb1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Rb1.Location = New System.Drawing.Point(301, 68)
        Me.Rb1.Name = "Rb1"
        Me.Rb1.Size = New System.Drawing.Size(36, 19)
        Me.Rb1.TabIndex = 0
        Me.Rb1.Text = "SI"
        Me.Rb1.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 72)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(199, 15)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "La aplicación se conecta a internet:"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(9, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(398, 33)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Aquí podrá configurar si la aplicación se conecta a internet o no. En caso afirma" &
    "tivo, podrá modificar el período de comprobación de la conexión."
        '
        'BtnInternet
        '
        Me.BtnInternet.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnInternet.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnInternet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInternet.Image = Global.SistemaCinderella.My.Resources.Recursos.Editar_24
        Me.BtnInternet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnInternet.Location = New System.Drawing.Point(307, 407)
        Me.BtnInternet.Name = "BtnInternet"
        Me.BtnInternet.Size = New System.Drawing.Size(100, 40)
        Me.BtnInternet.TabIndex = 7
        Me.BtnInternet.Text = "Modificar"
        Me.BtnInternet.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnInternet.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 101)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(216, 15)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Período de Comprobación (segundos)"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cb_SegundosInternet
        '
        Me.Cb_SegundosInternet.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cb_SegundosInternet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_SegundosInternet.FormattingEnabled = True
        Me.Cb_SegundosInternet.Items.AddRange(New Object() {"5", "10", "15", "30", "60"})
        Me.Cb_SegundosInternet.Location = New System.Drawing.Point(236, 93)
        Me.Cb_SegundosInternet.Name = "Cb_SegundosInternet"
        Me.Cb_SegundosInternet.Size = New System.Drawing.Size(171, 23)
        Me.Cb_SegundosInternet.TabIndex = 2
        '
        'TabHost
        '
        Me.TabHost.Controls.Add(Me.GroupBox8)
        Me.TabHost.Location = New System.Drawing.Point(4, 24)
        Me.TabHost.Name = "TabHost"
        Me.TabHost.Padding = New System.Windows.Forms.Padding(3)
        Me.TabHost.Size = New System.Drawing.Size(416, 456)
        Me.TabHost.TabIndex = 6
        Me.TabHost.Text = "Host"
        Me.TabHost.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.txtPuertoHost)
        Me.GroupBox8.Controls.Add(Me.txtIPHost)
        Me.GroupBox8.Controls.Add(Me.Label21)
        Me.GroupBox8.Controls.Add(Me.btnModificarHost)
        Me.GroupBox8.Controls.Add(Me.Label22)
        Me.GroupBox8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox8.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(410, 450)
        Me.GroupBox8.TabIndex = 8
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Configuración del Host de Servicios"
        '
        'txtPuertoHost
        '
        Me.txtPuertoHost.Location = New System.Drawing.Point(140, 62)
        Me.txtPuertoHost.Name = "txtPuertoHost"
        Me.txtPuertoHost.Size = New System.Drawing.Size(264, 21)
        Me.txtPuertoHost.TabIndex = 1
        '
        'txtIPHost
        '
        Me.txtIPHost.Location = New System.Drawing.Point(140, 30)
        Me.txtIPHost.Name = "txtIPHost"
        Me.txtIPHost.Size = New System.Drawing.Size(264, 21)
        Me.txtIPHost.TabIndex = 0
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(7, 33)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(127, 15)
        Me.Label21.TabIndex = 1
        Me.Label21.Text = "IP de la computadora:"
        '
        'btnModificarHost
        '
        Me.btnModificarHost.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificarHost.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarHost.Image = Global.SistemaCinderella.My.Resources.Recursos.Editar_24
        Me.btnModificarHost.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificarHost.Location = New System.Drawing.Point(304, 380)
        Me.btnModificarHost.Name = "btnModificarHost"
        Me.btnModificarHost.Size = New System.Drawing.Size(100, 40)
        Me.btnModificarHost.TabIndex = 2
        Me.btnModificarHost.Text = "Modificar"
        Me.btnModificarHost.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnModificarHost.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(7, 68)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(46, 15)
        Me.Label22.TabIndex = 3
        Me.Label22.Text = "Puerto:"
        '
        'TabStock
        '
        Me.TabStock.Controls.Add(Me.GroupBox11)
        Me.TabStock.Location = New System.Drawing.Point(4, 24)
        Me.TabStock.Name = "TabStock"
        Me.TabStock.Padding = New System.Windows.Forms.Padding(3)
        Me.TabStock.Size = New System.Drawing.Size(416, 456)
        Me.TabStock.TabIndex = 7
        Me.TabStock.Text = "Stock"
        Me.TabStock.UseVisualStyleBackColor = True
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.Label28)
        Me.GroupBox11.Controls.Add(Me.Panel4)
        Me.GroupBox11.Controls.Add(Me.GroupBox12)
        Me.GroupBox11.Controls.Add(Me.btnModificarStock)
        Me.GroupBox11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox11.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(410, 450)
        Me.GroupBox11.TabIndex = 6
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Configuración de Stock"
        '
        'Label28
        '
        Me.Label28.Location = New System.Drawing.Point(12, 21)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(202, 34)
        Me.Label28.TabIndex = 28
        Me.Label28.Text = "Habilitar generación órdenes de compra automáticas:"
        Me.Label28.UseWaitCursor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.ROrdenCompraAutomaticaNo)
        Me.Panel4.Controls.Add(Me.ROrdenCompraAutomaticaSI)
        Me.Panel4.Location = New System.Drawing.Point(225, 28)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(173, 27)
        Me.Panel4.TabIndex = 0
        '
        'ROrdenCompraAutomaticaNo
        '
        Me.ROrdenCompraAutomaticaNo.AutoSize = True
        Me.ROrdenCompraAutomaticaNo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ROrdenCompraAutomaticaNo.Location = New System.Drawing.Point(127, 3)
        Me.ROrdenCompraAutomaticaNo.Name = "ROrdenCompraAutomaticaNo"
        Me.ROrdenCompraAutomaticaNo.Size = New System.Drawing.Size(43, 19)
        Me.ROrdenCompraAutomaticaNo.TabIndex = 26
        Me.ROrdenCompraAutomaticaNo.Tag = ""
        Me.ROrdenCompraAutomaticaNo.Text = "NO"
        Me.ROrdenCompraAutomaticaNo.UseVisualStyleBackColor = True
        '
        'ROrdenCompraAutomaticaSI
        '
        Me.ROrdenCompraAutomaticaSI.AutoSize = True
        Me.ROrdenCompraAutomaticaSI.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ROrdenCompraAutomaticaSI.Location = New System.Drawing.Point(11, 3)
        Me.ROrdenCompraAutomaticaSI.Name = "ROrdenCompraAutomaticaSI"
        Me.ROrdenCompraAutomaticaSI.Size = New System.Drawing.Size(36, 19)
        Me.ROrdenCompraAutomaticaSI.TabIndex = 25
        Me.ROrdenCompraAutomaticaSI.Tag = ""
        Me.ROrdenCompraAutomaticaSI.Text = "SI"
        Me.ROrdenCompraAutomaticaSI.UseVisualStyleBackColor = True
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.btnCalcularVentaMensualProducto)
        Me.GroupBox12.Controls.Add(Me.txtFechaUltimoCalculoventaMensual)
        Me.GroupBox12.Controls.Add(Me.Label30)
        Me.GroupBox12.Controls.Add(Me.Label29)
        Me.GroupBox12.Controls.Add(Me.CbPeriodoActualizacionVentaMensual)
        Me.GroupBox12.Location = New System.Drawing.Point(6, 61)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(398, 116)
        Me.GroupBox12.TabIndex = 7
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Calculo venta mensual"
        '
        'btnCalcularVentaMensualProducto
        '
        Me.btnCalcularVentaMensualProducto.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnCalcularVentaMensualProducto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCalcularVentaMensualProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcularVentaMensualProducto.Image = Global.SistemaCinderella.My.Resources.Recursos.btn_Update_24
        Me.btnCalcularVentaMensualProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCalcularVentaMensualProducto.Location = New System.Drawing.Point(198, 77)
        Me.btnCalcularVentaMensualProducto.Name = "btnCalcularVentaMensualProducto"
        Me.btnCalcularVentaMensualProducto.Size = New System.Drawing.Size(194, 34)
        Me.btnCalcularVentaMensualProducto.TabIndex = 2
        Me.btnCalcularVentaMensualProducto.Text = "Calcular Venta Mensual"
        Me.btnCalcularVentaMensualProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCalcularVentaMensualProducto.UseVisualStyleBackColor = True
        '
        'txtFechaUltimoCalculoventaMensual
        '
        Me.txtFechaUltimoCalculoventaMensual.Enabled = False
        Me.txtFechaUltimoCalculoventaMensual.Location = New System.Drawing.Point(218, 49)
        Me.txtFechaUltimoCalculoventaMensual.Name = "txtFechaUltimoCalculoventaMensual"
        Me.txtFechaUltimoCalculoventaMensual.ReadOnly = True
        Me.txtFechaUltimoCalculoventaMensual.Size = New System.Drawing.Size(174, 21)
        Me.txtFechaUltimoCalculoventaMensual.TabIndex = 1
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(6, 52)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(120, 15)
        Me.Label30.TabIndex = 10
        Me.Label30.Text = "Fecha ultimo calculo"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(6, 23)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(176, 15)
        Me.Label29.TabIndex = 5
        Me.Label29.Text = "Periodo de actualizacion (días)"
        '
        'CbPeriodoActualizacionVentaMensual
        '
        Me.CbPeriodoActualizacionVentaMensual.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CbPeriodoActualizacionVentaMensual.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbPeriodoActualizacionVentaMensual.FormattingEnabled = True
        Me.CbPeriodoActualizacionVentaMensual.Items.AddRange(New Object() {"7", "15", "30", "60"})
        Me.CbPeriodoActualizacionVentaMensual.Location = New System.Drawing.Point(219, 20)
        Me.CbPeriodoActualizacionVentaMensual.Name = "CbPeriodoActualizacionVentaMensual"
        Me.CbPeriodoActualizacionVentaMensual.Size = New System.Drawing.Size(173, 23)
        Me.CbPeriodoActualizacionVentaMensual.TabIndex = 0
        '
        'btnModificarStock
        '
        Me.btnModificarStock.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModificarStock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificarStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarStock.Image = Global.SistemaCinderella.My.Resources.Recursos.Editar_24
        Me.btnModificarStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificarStock.Location = New System.Drawing.Point(304, 404)
        Me.btnModificarStock.Name = "btnModificarStock"
        Me.btnModificarStock.Size = New System.Drawing.Size(100, 40)
        Me.btnModificarStock.TabIndex = 1
        Me.btnModificarStock.Text = "Modificar"
        Me.btnModificarStock.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnModificarStock.UseVisualStyleBackColor = True
        '
        'frmConfiguracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 484)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmConfiguracion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuración del Sistema"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox13.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txt_descuentoMinorista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabSucursal.ResumeLayout(False)
        Me.TabPrecios.ResumeLayout(False)
        Me.TabMail.ResumeLayout(False)
        Me.TabFacturacion.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.TabNotificaciones.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.TabInternet.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.TabHost.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.TabStock.ResumeLayout(False)
        Me.GroupBox11.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_NombreSucursalActual As System.Windows.Forms.Label
    Friend WithEvents lbl_SucursalActual As System.Windows.Forms.Label
    Friend WithEvents Cb_Sucursales As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_NuevaSucursal As System.Windows.Forms.Label
    Friend WithEvents Btn_Actualizar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_NombreListaActual As System.Windows.Forms.Label
    Friend WithEvents Btn_Precios As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cb_Precios As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPort As System.Windows.Forms.TextBox
    Friend WithEvents txtSmtp As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnMailing As System.Windows.Forms.Button
    Friend WithEvents lblPort As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents RContrNO As System.Windows.Forms.RadioButton
    Friend WithEvents RContrSI As System.Windows.Forms.RadioButton
    Friend WithEvents Btn_Controlador As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_MontoTopeTicket As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabSucursal As System.Windows.Forms.TabPage
    Friend WithEvents TabPrecios As System.Windows.Forms.TabPage
    Friend WithEvents TabMail As System.Windows.Forms.TabPage
    Friend WithEvents TabFacturacion As System.Windows.Forms.TabPage
    Friend WithEvents TabNotificaciones As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnNotificaciones As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Cb_TiempoComprobacionMensajes As System.Windows.Forms.ComboBox
    Friend WithEvents TabInternet As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BtnInternet As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Cb_SegundosInternet As System.Windows.Forms.ComboBox
    Friend WithEvents Rb2 As System.Windows.Forms.RadioButton
    Friend WithEvents Rb1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_PuntoVentaElectronica As System.Windows.Forms.TextBox
    Friend WithEvents txt_PuntoVentaManual As System.Windows.Forms.TextBox
    Friend WithEvents txt_PuntoVentaControladora As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_MontoMaximoNotaCredito As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Cb_ConexionControladora As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Cb_TiempoComprobacionCheques As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Cb_TiempoComprobacionMovimientos As System.Windows.Forms.ComboBox
    Friend WithEvents TabHost As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPuertoHost As System.Windows.Forms.TextBox
    Friend WithEvents txtIPHost As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents btnModificarHost As System.Windows.Forms.Button
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_MontoTopeElectronico As System.Windows.Forms.TextBox
    Friend WithEvents txt_MontoTopeManual As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents RExentoSinIvaNo As RadioButton
    Friend WithEvents RExentoSinIvaSI As RadioButton
    Friend WithEvents Label23 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label24 As Label
    Friend WithEvents txt_descuentoMinorista As NumericUpDown
    Friend WithEvents TabStock As TabPage
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents Label28 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents ROrdenCompraAutomaticaNo As RadioButton
    Friend WithEvents ROrdenCompraAutomaticaSI As RadioButton
    Friend WithEvents GroupBox12 As GroupBox
    Friend WithEvents txtFechaUltimoCalculoventaMensual As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents CbPeriodoActualizacionVentaMensual As ComboBox
    Friend WithEvents btnModificarStock As Button
    Friend WithEvents btnCalcularVentaMensualProducto As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents rbUtilizaSSLNo As RadioButton
    Friend WithEvents rbUtilizaSSLSi As RadioButton
    Friend WithEvents Label31 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Cb_TimeOut As ComboBox
    Friend WithEvents Label32 As Label
    Friend WithEvents txt_IpPing As TextBox
    Friend WithEvents btnVerificarDNS As Button
    Friend WithEvents GroupBox13 As GroupBox
    Friend WithEvents txt_DatosFiscalNombreFantasia As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Cb_HorasSincronizacion As ComboBox
    Friend WithEvents Cb_ModeloControladora As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txt_DatosFiscalCUIT As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents txt_DatosFiscalRazonSocial As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents txt_DatosFiscalIIBB As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents dt_DatosFiscalInicioActividad As DateTimePicker
    Friend WithEvents txt_DatosFiscalEmail As TextBox
    Friend WithEvents Label40 As Label
    Friend WithEvents txt_DatosFiscalTelefono As TextBox
    Friend WithEvents Label39 As Label
    Friend WithEvents txt_DatosFiscalDireccion As TextBox
    Friend WithEvents Label38 As Label
    Friend WithEvents txt_DatosFiscalNombreFantasiaFuente As Button
    Friend WithEvents FontDialog As FontDialog
    Friend WithEvents txt_DatosFiscalLocalidad As TextBox
    Friend WithEvents Label41 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents btnCargarCertificadoAFIP As Button
    Friend WithEvents btnObtenerArchivoCSR As Button
    Friend WithEvents txt_facturacionElectronicaCertificadoVencimiento As TextBox
    Friend WithEvents txt_facturacionElectronicaCertificadoNombre As TextBox
    Friend WithEvents Label42 As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents btn_ConfigurarBaseDatos As Button
End Class
