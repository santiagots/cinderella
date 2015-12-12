<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfiguracion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfiguracion))
        Me.lbl_NombreSucursalActual = New System.Windows.Forms.Label()
        Me.lbl_SucursalActual = New System.Windows.Forms.Label()
        Me.Cb_Sucursales = New System.Windows.Forms.ComboBox()
        Me.lbl_NuevaSucursal = New System.Windows.Forms.Label()
        Me.Btn_Actualizar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_NombreListaActual = New System.Windows.Forms.Label()
        Me.Btn_Precios = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cb_Precios = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.txtSmtp = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnMailing = New System.Windows.Forms.Button()
        Me.lblPort = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_MontoMaximoNotaCredito = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.txt_PuntoVentaElectronica = New System.Windows.Forms.TextBox()
        Me.txt_PuntoVentaManual = New System.Windows.Forms.TextBox()
        Me.txt_PuntoVentaControladora = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_MontoControlador = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RContrNO = New System.Windows.Forms.RadioButton()
        Me.RContrSI = New System.Windows.Forms.RadioButton()
        Me.Btn_Controlador = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabSucursal = New System.Windows.Forms.TabPage()
        Me.TabPrecios = New System.Windows.Forms.TabPage()
        Me.TabMail = New System.Windows.Forms.TabPage()
        Me.TabFacturacion = New System.Windows.Forms.TabPage()
        Me.TabNotificaciones = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnNotificaciones = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Cb_Segundos = New System.Windows.Forms.ComboBox()
        Me.TabInternet = New System.Windows.Forms.TabPage()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Rb2 = New System.Windows.Forms.RadioButton()
        Me.Rb1 = New System.Windows.Forms.RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtnInternet = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Cb_SegundosInternet = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabSucursal.SuspendLayout()
        Me.TabPrecios.SuspendLayout()
        Me.TabMail.SuspendLayout()
        Me.TabFacturacion.SuspendLayout()
        Me.TabNotificaciones.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.TabInternet.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_NombreSucursalActual
        '
        Me.lbl_NombreSucursalActual.AutoSize = True
        Me.lbl_NombreSucursalActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NombreSucursalActual.Location = New System.Drawing.Point(115, 32)
        Me.lbl_NombreSucursalActual.Name = "lbl_NombreSucursalActual"
        Me.lbl_NombreSucursalActual.Size = New System.Drawing.Size(54, 13)
        Me.lbl_NombreSucursalActual.TabIndex = 2
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
        Me.Cb_Sucursales.Location = New System.Drawing.Point(119, 68)
        Me.Cb_Sucursales.Name = "Cb_Sucursales"
        Me.Cb_Sucursales.Size = New System.Drawing.Size(189, 23)
        Me.Cb_Sucursales.TabIndex = 3
        '
        'lbl_NuevaSucursal
        '
        Me.lbl_NuevaSucursal.AutoSize = True
        Me.lbl_NuevaSucursal.Location = New System.Drawing.Point(9, 73)
        Me.lbl_NuevaSucursal.Name = "lbl_NuevaSucursal"
        Me.lbl_NuevaSucursal.Size = New System.Drawing.Size(96, 15)
        Me.lbl_NuevaSucursal.TabIndex = 3
        Me.lbl_NuevaSucursal.Text = "Nueva Sucursal:"
        '
        'Btn_Actualizar
        '
        Me.Btn_Actualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Actualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Actualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Actualizar.Image = Global.SistemaCinderella.My.Resources.Recursos.Editar_24
        Me.Btn_Actualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Actualizar.Location = New System.Drawing.Point(274, 247)
        Me.Btn_Actualizar.Name = "Btn_Actualizar"
        Me.Btn_Actualizar.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Actualizar.TabIndex = 4
        Me.Btn_Actualizar.Text = "Modificar"
        Me.Btn_Actualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Actualizar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_SucursalActual)
        Me.GroupBox1.Controls.Add(Me.lbl_NombreSucursalActual)
        Me.GroupBox1.Controls.Add(Me.Btn_Actualizar)
        Me.GroupBox1.Controls.Add(Me.lbl_NuevaSucursal)
        Me.GroupBox1.Controls.Add(Me.Cb_Sucursales)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(380, 293)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Configuración de Sucursal"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.lbl_NombreListaActual)
        Me.GroupBox2.Controls.Add(Me.Btn_Precios)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.cb_Precios)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(380, 293)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Configuración de Precios"
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
        Me.lbl_NombreListaActual.Location = New System.Drawing.Point(153, 34)
        Me.lbl_NombreListaActual.Name = "lbl_NombreListaActual"
        Me.lbl_NombreListaActual.Size = New System.Drawing.Size(30, 13)
        Me.lbl_NombreListaActual.TabIndex = 2
        Me.lbl_NombreListaActual.Text = "lista"
        '
        'Btn_Precios
        '
        Me.Btn_Precios.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Precios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Precios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Precios.Image = Global.SistemaCinderella.My.Resources.Recursos.Editar_24
        Me.Btn_Precios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Precios.Location = New System.Drawing.Point(274, 247)
        Me.Btn_Precios.Name = "Btn_Precios"
        Me.Btn_Precios.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Precios.TabIndex = 4
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
        Me.cb_Precios.Location = New System.Drawing.Point(156, 68)
        Me.cb_Precios.Name = "cb_Precios"
        Me.cb_Precios.Size = New System.Drawing.Size(189, 23)
        Me.cb_Precios.TabIndex = 3
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtPort)
        Me.GroupBox3.Controls.Add(Me.txtSmtp)
        Me.GroupBox3.Controls.Add(Me.txtUsuario)
        Me.GroupBox3.Controls.Add(Me.txtPassword)
        Me.GroupBox3.Controls.Add(Me.lblPassword)
        Me.GroupBox3.Controls.Add(Me.lblUsuario)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.BtnMailing)
        Me.GroupBox3.Controls.Add(Me.lblPort)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(386, 299)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Configuración del Servidor de Mail"
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(119, 62)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(75, 21)
        Me.txtPort.TabIndex = 10
        '
        'txtSmtp
        '
        Me.txtSmtp.Location = New System.Drawing.Point(119, 30)
        Me.txtSmtp.Name = "txtSmtp"
        Me.txtSmtp.Size = New System.Drawing.Size(189, 21)
        Me.txtSmtp.TabIndex = 9
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(119, 95)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(189, 21)
        Me.txtUsuario.TabIndex = 8
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(119, 125)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(189, 21)
        Me.txtPassword.TabIndex = 7
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(7, 131)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(73, 15)
        Me.lblPassword.TabIndex = 6
        Me.lblPassword.Text = "Contraseña:"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(7, 101)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(53, 15)
        Me.lblUsuario.TabIndex = 5
        Me.lblUsuario.Text = "Usuario:"
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
        Me.BtnMailing.Location = New System.Drawing.Point(278, 251)
        Me.BtnMailing.Name = "BtnMailing"
        Me.BtnMailing.Size = New System.Drawing.Size(100, 40)
        Me.BtnMailing.TabIndex = 4
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
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.txt_MontoMaximoNotaCredito)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.GroupBox7)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.txt_MontoControlador)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.RContrNO)
        Me.GroupBox4.Controls.Add(Me.RContrSI)
        Me.GroupBox4.Controls.Add(Me.Btn_Controlador)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(386, 299)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Configuración de Controlador Fiscal"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(9, 107)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(170, 15)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = " hasta un monto final total de: "
        '
        'txt_MontoMaximoNotaCredito
        '
        Me.txt_MontoMaximoNotaCredito.Location = New System.Drawing.Point(236, 99)
        Me.txt_MontoMaximoNotaCredito.Name = "txt_MontoMaximoNotaCredito"
        Me.txt_MontoMaximoNotaCredito.Size = New System.Drawing.Size(111, 21)
        Me.txt_MontoMaximoNotaCredito.TabIndex = 19
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(9, 92)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(210, 15)
        Me.Label16.TabIndex = 18
        Me.Label16.Text = "Se posibilita generar notas de crédito"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.txt_PuntoVentaElectronica)
        Me.GroupBox7.Controls.Add(Me.txt_PuntoVentaManual)
        Me.GroupBox7.Controls.Add(Me.txt_PuntoVentaControladora)
        Me.GroupBox7.Controls.Add(Me.Label14)
        Me.GroupBox7.Controls.Add(Me.Label13)
        Me.GroupBox7.Controls.Add(Me.Label12)
        Me.GroupBox7.Location = New System.Drawing.Point(14, 135)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(366, 109)
        Me.GroupBox7.TabIndex = 17
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Puntos de venta"
        '
        'txt_PuntoVentaElectronica
        '
        Me.txt_PuntoVentaElectronica.Location = New System.Drawing.Point(224, 74)
        Me.txt_PuntoVentaElectronica.Name = "txt_PuntoVentaElectronica"
        Me.txt_PuntoVentaElectronica.Size = New System.Drawing.Size(111, 21)
        Me.txt_PuntoVentaElectronica.TabIndex = 18
        '
        'txt_PuntoVentaManual
        '
        Me.txt_PuntoVentaManual.Location = New System.Drawing.Point(224, 47)
        Me.txt_PuntoVentaManual.Name = "txt_PuntoVentaManual"
        Me.txt_PuntoVentaManual.Size = New System.Drawing.Size(111, 21)
        Me.txt_PuntoVentaManual.TabIndex = 17
        '
        'txt_PuntoVentaControladora
        '
        Me.txt_PuntoVentaControladora.Location = New System.Drawing.Point(224, 20)
        Me.txt_PuntoVentaControladora.Name = "txt_PuntoVentaControladora"
        Me.txt_PuntoVentaControladora.Size = New System.Drawing.Size(111, 21)
        Me.txt_PuntoVentaControladora.TabIndex = 16
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(137, 15)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = " un monto final total de: "
        '
        'txt_MontoControlador
        '
        Me.txt_MontoControlador.Location = New System.Drawing.Point(236, 62)
        Me.txt_MontoControlador.Name = "txt_MontoControlador"
        Me.txt_MontoControlador.Size = New System.Drawing.Size(111, 21)
        Me.txt_MontoControlador.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(189, 15)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Se posibilita facturar ventas hasta"
        '
        'RContrNO
        '
        Me.RContrNO.AutoSize = True
        Me.RContrNO.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RContrNO.Location = New System.Drawing.Point(304, 33)
        Me.RContrNO.Name = "RContrNO"
        Me.RContrNO.Size = New System.Drawing.Size(43, 19)
        Me.RContrNO.TabIndex = 13
        Me.RContrNO.Text = "NO"
        Me.RContrNO.UseVisualStyleBackColor = True
        '
        'RContrSI
        '
        Me.RContrSI.AutoSize = True
        Me.RContrSI.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RContrSI.Location = New System.Drawing.Point(236, 31)
        Me.RContrSI.Name = "RContrSI"
        Me.RContrSI.Size = New System.Drawing.Size(36, 19)
        Me.RContrSI.TabIndex = 12
        Me.RContrSI.Text = "SI"
        Me.RContrSI.UseVisualStyleBackColor = True
        '
        'Btn_Controlador
        '
        Me.Btn_Controlador.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Controlador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Controlador.Image = Global.SistemaCinderella.My.Resources.Recursos.Editar_24
        Me.Btn_Controlador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Controlador.Location = New System.Drawing.Point(278, 251)
        Me.Btn_Controlador.Name = "Btn_Controlador"
        Me.Btn_Controlador.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Controlador.TabIndex = 11
        Me.Btn_Controlador.Text = "Modificar"
        Me.Btn_Controlador.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Controlador.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(210, 15)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "La sucursal utiliza Controlador Fiscal:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabSucursal)
        Me.TabControl1.Controls.Add(Me.TabPrecios)
        Me.TabControl1.Controls.Add(Me.TabMail)
        Me.TabControl1.Controls.Add(Me.TabFacturacion)
        Me.TabControl1.Controls.Add(Me.TabNotificaciones)
        Me.TabControl1.Controls.Add(Me.TabInternet)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(394, 327)
        Me.TabControl1.TabIndex = 9
        '
        'TabSucursal
        '
        Me.TabSucursal.Controls.Add(Me.GroupBox1)
        Me.TabSucursal.Location = New System.Drawing.Point(4, 24)
        Me.TabSucursal.Name = "TabSucursal"
        Me.TabSucursal.Padding = New System.Windows.Forms.Padding(3)
        Me.TabSucursal.Size = New System.Drawing.Size(386, 299)
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
        Me.TabPrecios.Size = New System.Drawing.Size(386, 299)
        Me.TabPrecios.TabIndex = 1
        Me.TabPrecios.Text = "Precios"
        Me.TabPrecios.UseVisualStyleBackColor = True
        '
        'TabMail
        '
        Me.TabMail.Controls.Add(Me.GroupBox3)
        Me.TabMail.Location = New System.Drawing.Point(4, 24)
        Me.TabMail.Name = "TabMail"
        Me.TabMail.Size = New System.Drawing.Size(386, 299)
        Me.TabMail.TabIndex = 2
        Me.TabMail.Text = "Mail"
        Me.TabMail.UseVisualStyleBackColor = True
        '
        'TabFacturacion
        '
        Me.TabFacturacion.Controls.Add(Me.GroupBox4)
        Me.TabFacturacion.Location = New System.Drawing.Point(4, 24)
        Me.TabFacturacion.Name = "TabFacturacion"
        Me.TabFacturacion.Size = New System.Drawing.Size(386, 299)
        Me.TabFacturacion.TabIndex = 3
        Me.TabFacturacion.Text = "Facturación"
        Me.TabFacturacion.UseVisualStyleBackColor = True
        '
        'TabNotificaciones
        '
        Me.TabNotificaciones.Controls.Add(Me.GroupBox5)
        Me.TabNotificaciones.Location = New System.Drawing.Point(4, 24)
        Me.TabNotificaciones.Name = "TabNotificaciones"
        Me.TabNotificaciones.Size = New System.Drawing.Size(386, 299)
        Me.TabNotificaciones.TabIndex = 4
        Me.TabNotificaciones.Text = "Notificaciones"
        Me.TabNotificaciones.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Controls.Add(Me.BtnNotificaciones)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.Cb_Segundos)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox5.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(386, 299)
        Me.GroupBox5.TabIndex = 7
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Configuración de Notificaciones"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(9, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(371, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Las notificaciones que recibe el sistema  son todos aquellos movimientos que otra" & _
    "s sucursales hacen con el sistema."
        '
        'BtnNotificaciones
        '
        Me.BtnNotificaciones.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnNotificaciones.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNotificaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNotificaciones.Image = Global.SistemaCinderella.My.Resources.Recursos.Editar_24
        Me.BtnNotificaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNotificaciones.Location = New System.Drawing.Point(276, 249)
        Me.BtnNotificaciones.Name = "BtnNotificaciones"
        Me.BtnNotificaciones.Size = New System.Drawing.Size(100, 40)
        Me.BtnNotificaciones.TabIndex = 4
        Me.BtnNotificaciones.Text = "Modificar"
        Me.BtnNotificaciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNotificaciones.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(9, 90)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(153, 36)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Período de Comprobación ( en segundos )"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Cb_Segundos
        '
        Me.Cb_Segundos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cb_Segundos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Segundos.FormattingEnabled = True
        Me.Cb_Segundos.Items.AddRange(New Object() {"30", "60", "120", "300"})
        Me.Cb_Segundos.Location = New System.Drawing.Point(241, 90)
        Me.Cb_Segundos.Name = "Cb_Segundos"
        Me.Cb_Segundos.Size = New System.Drawing.Size(101, 23)
        Me.Cb_Segundos.TabIndex = 3
        '
        'TabInternet
        '
        Me.TabInternet.Controls.Add(Me.GroupBox6)
        Me.TabInternet.Location = New System.Drawing.Point(4, 24)
        Me.TabInternet.Name = "TabInternet"
        Me.TabInternet.Size = New System.Drawing.Size(386, 299)
        Me.TabInternet.TabIndex = 5
        Me.TabInternet.Text = "Internet"
        Me.TabInternet.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
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
        Me.GroupBox6.Size = New System.Drawing.Size(386, 299)
        Me.GroupBox6.TabIndex = 8
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Configuración de Internet"
        '
        'Rb2
        '
        Me.Rb2.AutoSize = True
        Me.Rb2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Rb2.Location = New System.Drawing.Point(299, 70)
        Me.Rb2.Name = "Rb2"
        Me.Rb2.Size = New System.Drawing.Size(43, 19)
        Me.Rb2.TabIndex = 16
        Me.Rb2.Text = "NO"
        Me.Rb2.UseVisualStyleBackColor = True
        '
        'Rb1
        '
        Me.Rb1.AutoSize = True
        Me.Rb1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Rb1.Location = New System.Drawing.Point(236, 70)
        Me.Rb1.Name = "Rb1"
        Me.Rb1.Size = New System.Drawing.Size(36, 19)
        Me.Rb1.TabIndex = 15
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
        Me.Label8.Size = New System.Drawing.Size(371, 33)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Aquí podrá configurar si la aplicación se conecta a internet o no. En caso afirma" & _
    "tivo, podrá modificar el período de comprobación de la conexión."
        '
        'BtnInternet
        '
        Me.BtnInternet.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnInternet.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnInternet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInternet.Image = Global.SistemaCinderella.My.Resources.Recursos.Editar_24
        Me.BtnInternet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnInternet.Location = New System.Drawing.Point(276, 249)
        Me.BtnInternet.Name = "BtnInternet"
        Me.BtnInternet.Size = New System.Drawing.Size(100, 40)
        Me.BtnInternet.TabIndex = 4
        Me.BtnInternet.Text = "Modificar"
        Me.BtnInternet.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnInternet.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(6, 110)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(153, 36)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Período de Comprobación ( en segundos )"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Cb_SegundosInternet
        '
        Me.Cb_SegundosInternet.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cb_SegundosInternet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_SegundosInternet.FormattingEnabled = True
        Me.Cb_SegundosInternet.Items.AddRange(New Object() {"25", "30", "60", "120", "300"})
        Me.Cb_SegundosInternet.Location = New System.Drawing.Point(236, 110)
        Me.Cb_SegundosInternet.Name = "Cb_SegundosInternet"
        Me.Cb_SegundosInternet.Size = New System.Drawing.Size(101, 23)
        Me.Cb_SegundosInternet.TabIndex = 3
        '
        'frmConfiguracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 327)
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
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabSucursal.ResumeLayout(False)
        Me.TabPrecios.ResumeLayout(False)
        Me.TabMail.ResumeLayout(False)
        Me.TabFacturacion.ResumeLayout(False)
        Me.TabNotificaciones.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.TabInternet.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
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
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnMailing As System.Windows.Forms.Button
    Friend WithEvents lblPort As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents RContrNO As System.Windows.Forms.RadioButton
    Friend WithEvents RContrSI As System.Windows.Forms.RadioButton
    Friend WithEvents Btn_Controlador As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_MontoControlador As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabSucursal As System.Windows.Forms.TabPage
    Friend WithEvents TabPrecios As System.Windows.Forms.TabPage
    Friend WithEvents TabMail As System.Windows.Forms.TabPage
    Friend WithEvents TabFacturacion As System.Windows.Forms.TabPage
    Friend WithEvents TabNotificaciones As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnNotificaciones As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Cb_Segundos As System.Windows.Forms.ComboBox
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
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txt_MontoMaximoNotaCredito As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
End Class
