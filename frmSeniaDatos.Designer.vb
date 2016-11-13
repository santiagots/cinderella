<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSeniaDatos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSeniaDatos))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PanelTotalMinorista = New System.Windows.Forms.Panel()
        Me.lblImporteSaldarMinorista = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblSeniaMinorista = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblMontoMinorista = New System.Windows.Forms.Label()
        Me.lblDescuentoMinorista = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblSubtotalMinorista = New System.Windows.Forms.Label()
        Me.PanelTotalMayorista = New System.Windows.Forms.Panel()
        Me.lblImporteSaldarMayorista = New System.Windows.Forms.Label()
        Me.lblMontoMayorista = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lblIVAMayorista = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.lblSubtotalMayorista = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lblDescuentoMayorista = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.lblSeniaMayorista = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.lblFacturado = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.lblPago = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblEncargado = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTipoVenta = New System.Windows.Forms.Label()
        Me.lblVendedor = New System.Windows.Forms.Label()
        Me.lblFechaSeña = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.DG_Productos = New System.Windows.Forms.DataGridView()
        Me.CODIGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANTIDAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRECIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MONTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SUBTOTAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.cmbModoEntrega = New System.Windows.Forms.ComboBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.rblEnvioPromocionesSi = New System.Windows.Forms.RadioButton()
        Me.rblEnvioPromocionesNo = New System.Windows.Forms.RadioButton()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.dpkFechaRetiro = New System.Windows.Forms.DateTimePicker()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Btn_BuscarConsumidorFinal = New System.Windows.Forms.Button()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.Btn_Finalizar = New System.Windows.Forms.Button()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox2.SuspendLayout()
        Me.PanelTotalMinorista.SuspendLayout()
        Me.PanelTotalMayorista.SuspendLayout()
        CType(Me.DG_Productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.PanelTotalMinorista)
        Me.GroupBox2.Controls.Add(Me.PanelTotalMayorista)
        Me.GroupBox2.Controls.Add(Me.lblFacturado)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.lblCantidad)
        Me.GroupBox2.Controls.Add(Me.lblPago)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.lblEncargado)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.lblTipoVenta)
        Me.GroupBox2.Controls.Add(Me.lblVendedor)
        Me.GroupBox2.Controls.Add(Me.lblFechaSeña)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.DG_Productos)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 210)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(860, 440)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalle de la seña"
        '
        'PanelTotalMinorista
        '
        Me.PanelTotalMinorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelTotalMinorista.Controls.Add(Me.lblImporteSaldarMinorista)
        Me.PanelTotalMinorista.Controls.Add(Me.Label7)
        Me.PanelTotalMinorista.Controls.Add(Me.lblSeniaMinorista)
        Me.PanelTotalMinorista.Controls.Add(Me.Label23)
        Me.PanelTotalMinorista.Controls.Add(Me.Label6)
        Me.PanelTotalMinorista.Controls.Add(Me.Label10)
        Me.PanelTotalMinorista.Controls.Add(Me.lblMontoMinorista)
        Me.PanelTotalMinorista.Controls.Add(Me.lblDescuentoMinorista)
        Me.PanelTotalMinorista.Controls.Add(Me.Label16)
        Me.PanelTotalMinorista.Controls.Add(Me.lblSubtotalMinorista)
        Me.PanelTotalMinorista.Location = New System.Drawing.Point(342, 305)
        Me.PanelTotalMinorista.Name = "PanelTotalMinorista"
        Me.PanelTotalMinorista.Size = New System.Drawing.Size(258, 128)
        Me.PanelTotalMinorista.TabIndex = 68
        '
        'lblImporteSaldarMinorista
        '
        Me.lblImporteSaldarMinorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblImporteSaldarMinorista.AutoSize = True
        Me.lblImporteSaldarMinorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImporteSaldarMinorista.Location = New System.Drawing.Point(193, 91)
        Me.lblImporteSaldarMinorista.Name = "lblImporteSaldarMinorista"
        Me.lblImporteSaldarMinorista.Size = New System.Drawing.Size(42, 15)
        Me.lblImporteSaldarMinorista.TabIndex = 48
        Me.lblImporteSaldarMinorista.Text = "- - - - - "
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 91)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 15)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "Importe a saldar :"
        '
        'lblSeniaMinorista
        '
        Me.lblSeniaMinorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSeniaMinorista.AutoSize = True
        Me.lblSeniaMinorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeniaMinorista.Location = New System.Drawing.Point(193, 69)
        Me.lblSeniaMinorista.Name = "lblSeniaMinorista"
        Me.lblSeniaMinorista.Size = New System.Drawing.Size(42, 15)
        Me.lblSeniaMinorista.TabIndex = 46
        Me.lblSeniaMinorista.Text = "- - - - - "
        '
        'Label23
        '
        Me.Label23.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(3, 69)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(42, 15)
        Me.Label23.TabIndex = 45
        Me.Label23.Text = "Seña :"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 15)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Descuento :"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(3, 47)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 15)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Monto total :"
        '
        'lblMontoMinorista
        '
        Me.lblMontoMinorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblMontoMinorista.AutoSize = True
        Me.lblMontoMinorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontoMinorista.Location = New System.Drawing.Point(193, 47)
        Me.lblMontoMinorista.Name = "lblMontoMinorista"
        Me.lblMontoMinorista.Size = New System.Drawing.Size(42, 15)
        Me.lblMontoMinorista.TabIndex = 23
        Me.lblMontoMinorista.Text = "- - - - - "
        '
        'lblDescuentoMinorista
        '
        Me.lblDescuentoMinorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDescuentoMinorista.AutoSize = True
        Me.lblDescuentoMinorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescuentoMinorista.Location = New System.Drawing.Point(193, 26)
        Me.lblDescuentoMinorista.Name = "lblDescuentoMinorista"
        Me.lblDescuentoMinorista.Size = New System.Drawing.Size(42, 15)
        Me.lblDescuentoMinorista.TabIndex = 32
        Me.lblDescuentoMinorista.Text = "- - - - - "
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(3, 3)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(58, 15)
        Me.Label16.TabIndex = 33
        Me.Label16.Text = "Subtotal :"
        '
        'lblSubtotalMinorista
        '
        Me.lblSubtotalMinorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSubtotalMinorista.AutoSize = True
        Me.lblSubtotalMinorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtotalMinorista.Location = New System.Drawing.Point(193, 3)
        Me.lblSubtotalMinorista.Name = "lblSubtotalMinorista"
        Me.lblSubtotalMinorista.Size = New System.Drawing.Size(42, 15)
        Me.lblSubtotalMinorista.TabIndex = 34
        Me.lblSubtotalMinorista.Text = "- - - - - "
        '
        'PanelTotalMayorista
        '
        Me.PanelTotalMayorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelTotalMayorista.Controls.Add(Me.lblImporteSaldarMayorista)
        Me.PanelTotalMayorista.Controls.Add(Me.lblMontoMayorista)
        Me.PanelTotalMayorista.Controls.Add(Me.Label9)
        Me.PanelTotalMayorista.Controls.Add(Me.Label20)
        Me.PanelTotalMayorista.Controls.Add(Me.lblIVAMayorista)
        Me.PanelTotalMayorista.Controls.Add(Me.Label28)
        Me.PanelTotalMayorista.Controls.Add(Me.lblSubtotalMayorista)
        Me.PanelTotalMayorista.Controls.Add(Me.Label22)
        Me.PanelTotalMayorista.Controls.Add(Me.lblDescuentoMayorista)
        Me.PanelTotalMayorista.Controls.Add(Me.Label24)
        Me.PanelTotalMayorista.Controls.Add(Me.lblSeniaMayorista)
        Me.PanelTotalMayorista.Controls.Add(Me.Label26)
        Me.PanelTotalMayorista.Location = New System.Drawing.Point(606, 304)
        Me.PanelTotalMayorista.Name = "PanelTotalMayorista"
        Me.PanelTotalMayorista.Size = New System.Drawing.Size(251, 129)
        Me.PanelTotalMayorista.TabIndex = 67
        '
        'lblImporteSaldarMayorista
        '
        Me.lblImporteSaldarMayorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblImporteSaldarMayorista.AutoSize = True
        Me.lblImporteSaldarMayorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImporteSaldarMayorista.Location = New System.Drawing.Point(196, 109)
        Me.lblImporteSaldarMayorista.Name = "lblImporteSaldarMayorista"
        Me.lblImporteSaldarMayorista.Size = New System.Drawing.Size(42, 15)
        Me.lblImporteSaldarMayorista.TabIndex = 50
        Me.lblImporteSaldarMayorista.Text = "- - - - - "
        '
        'lblMontoMayorista
        '
        Me.lblMontoMayorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblMontoMayorista.AutoSize = True
        Me.lblMontoMayorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontoMayorista.Location = New System.Drawing.Point(195, 68)
        Me.lblMontoMayorista.Name = "lblMontoMayorista"
        Me.lblMontoMayorista.Size = New System.Drawing.Size(42, 15)
        Me.lblMontoMayorista.TabIndex = 44
        Me.lblMontoMayorista.Text = "- - - - - "
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 109)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 15)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Importe a saldar :"
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(6, 68)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(74, 15)
        Me.Label20.TabIndex = 43
        Me.Label20.Text = "Monto total :"
        '
        'lblIVAMayorista
        '
        Me.lblIVAMayorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblIVAMayorista.AutoSize = True
        Me.lblIVAMayorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIVAMayorista.Location = New System.Drawing.Point(195, 47)
        Me.lblIVAMayorista.Name = "lblIVAMayorista"
        Me.lblIVAMayorista.Size = New System.Drawing.Size(42, 15)
        Me.lblIVAMayorista.TabIndex = 42
        Me.lblIVAMayorista.Text = "- - - - - "
        '
        'Label28
        '
        Me.Label28.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(6, 47)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(58, 15)
        Me.Label28.TabIndex = 41
        Me.Label28.Text = "IVA 21% :"
        '
        'lblSubtotalMayorista
        '
        Me.lblSubtotalMayorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSubtotalMayorista.AutoSize = True
        Me.lblSubtotalMayorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtotalMayorista.Location = New System.Drawing.Point(195, 24)
        Me.lblSubtotalMayorista.Name = "lblSubtotalMayorista"
        Me.lblSubtotalMayorista.Size = New System.Drawing.Size(42, 15)
        Me.lblSubtotalMayorista.TabIndex = 40
        Me.lblSubtotalMayorista.Text = "- - - - - "
        '
        'Label22
        '
        Me.Label22.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(5, 24)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(58, 15)
        Me.Label22.TabIndex = 39
        Me.Label22.Text = "Subtotal :"
        '
        'lblDescuentoMayorista
        '
        Me.lblDescuentoMayorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDescuentoMayorista.AutoSize = True
        Me.lblDescuentoMayorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescuentoMayorista.Location = New System.Drawing.Point(195, 4)
        Me.lblDescuentoMayorista.Name = "lblDescuentoMayorista"
        Me.lblDescuentoMayorista.Size = New System.Drawing.Size(42, 15)
        Me.lblDescuentoMayorista.TabIndex = 38
        Me.lblDescuentoMayorista.Text = "- - - - - "
        '
        'Label24
        '
        Me.Label24.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(5, 4)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(72, 15)
        Me.Label24.TabIndex = 37
        Me.Label24.Text = "Descuento :"
        '
        'lblSeniaMayorista
        '
        Me.lblSeniaMayorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSeniaMayorista.AutoSize = True
        Me.lblSeniaMayorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeniaMayorista.Location = New System.Drawing.Point(195, 89)
        Me.lblSeniaMayorista.Name = "lblSeniaMayorista"
        Me.lblSeniaMayorista.Size = New System.Drawing.Size(42, 15)
        Me.lblSeniaMayorista.TabIndex = 36
        Me.lblSeniaMayorista.Text = "- - - - - "
        '
        'Label26
        '
        Me.Label26.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(5, 89)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(39, 15)
        Me.Label26.TabIndex = 35
        Me.Label26.Text = "Seña:"
        '
        'lblFacturado
        '
        Me.lblFacturado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblFacturado.AutoSize = True
        Me.lblFacturado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFacturado.Location = New System.Drawing.Point(202, 332)
        Me.lblFacturado.Name = "lblFacturado"
        Me.lblFacturado.Size = New System.Drawing.Size(42, 15)
        Me.lblFacturado.TabIndex = 66
        Me.lblFacturado.Text = "- - - - - "
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 332)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 15)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Facturado :"
        '
        'lblCantidad
        '
        Me.lblCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad.Location = New System.Drawing.Point(202, 356)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(42, 15)
        Me.lblCantidad.TabIndex = 64
        Me.lblCantidad.Text = "- - - - - "
        '
        'lblPago
        '
        Me.lblPago.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblPago.AutoSize = True
        Me.lblPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPago.Location = New System.Drawing.Point(202, 308)
        Me.lblPago.Name = "lblPago"
        Me.lblPago.Size = New System.Drawing.Size(42, 15)
        Me.lblPago.TabIndex = 63
        Me.lblPago.Text = "- - - - - "
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 356)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 15)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "Cant. de productos :"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 308)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 15)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "Tipo de Pago :"
        '
        'lblEncargado
        '
        Me.lblEncargado.AutoSize = True
        Me.lblEncargado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEncargado.Location = New System.Drawing.Point(417, 53)
        Me.lblEncargado.Name = "lblEncargado"
        Me.lblEncargado.Size = New System.Drawing.Size(42, 15)
        Me.lblEncargado.TabIndex = 60
        Me.lblEncargado.Text = "- - - - - "
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(325, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 15)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Encargado :"
        '
        'lblTipoVenta
        '
        Me.lblTipoVenta.AutoSize = True
        Me.lblTipoVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoVenta.Location = New System.Drawing.Point(109, 26)
        Me.lblTipoVenta.Name = "lblTipoVenta"
        Me.lblTipoVenta.Size = New System.Drawing.Size(42, 15)
        Me.lblTipoVenta.TabIndex = 56
        Me.lblTipoVenta.Text = "- - - - - "
        '
        'lblVendedor
        '
        Me.lblVendedor.AutoSize = True
        Me.lblVendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVendedor.Location = New System.Drawing.Point(108, 53)
        Me.lblVendedor.Name = "lblVendedor"
        Me.lblVendedor.Size = New System.Drawing.Size(42, 15)
        Me.lblVendedor.TabIndex = 55
        Me.lblVendedor.Text = "- - - - - "
        '
        'lblFechaSeña
        '
        Me.lblFechaSeña.AutoSize = True
        Me.lblFechaSeña.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaSeña.Location = New System.Drawing.Point(418, 26)
        Me.lblFechaSeña.Name = "lblFechaSeña"
        Me.lblFechaSeña.Size = New System.Drawing.Size(42, 15)
        Me.lblFechaSeña.TabIndex = 53
        Me.lblFechaSeña.Text = "- - - - - "
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(325, 26)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(79, 15)
        Me.Label15.TabIndex = 51
        Me.Label15.Text = "Fecha Seña :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(6, 26)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(88, 15)
        Me.Label17.TabIndex = 50
        Me.Label17.Text = "Tipo de Venta :"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(6, 53)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(66, 15)
        Me.Label18.TabIndex = 49
        Me.Label18.Text = "Vendedor :"
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
        Me.DG_Productos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CODIGO, Me.NOMBRE, Me.CANTIDAD, Me.PRECIO, Me.IVA, Me.MONTO, Me.SUBTOTAL})
        Me.DG_Productos.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.DG_Productos.Location = New System.Drawing.Point(3, 83)
        Me.DG_Productos.MultiSelect = False
        Me.DG_Productos.Name = "DG_Productos"
        Me.DG_Productos.ReadOnly = True
        Me.DG_Productos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DG_Productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Productos.Size = New System.Drawing.Size(854, 215)
        Me.DG_Productos.TabIndex = 12
        '
        'CODIGO
        '
        Me.CODIGO.DataPropertyName = "CODIGO"
        Me.CODIGO.FillWeight = 107.5103!
        Me.CODIGO.HeaderText = "Código"
        Me.CODIGO.Name = "CODIGO"
        Me.CODIGO.ReadOnly = True
        '
        'NOMBRE
        '
        Me.NOMBRE.DataPropertyName = "NOMBRE"
        Me.NOMBRE.FillWeight = 177.4346!
        Me.NOMBRE.HeaderText = "Nombre"
        Me.NOMBRE.Name = "NOMBRE"
        Me.NOMBRE.ReadOnly = True
        '
        'CANTIDAD
        '
        Me.CANTIDAD.DataPropertyName = "CANTIDAD"
        Me.CANTIDAD.FillWeight = 73.49158!
        Me.CANTIDAD.HeaderText = "Cantidad"
        Me.CANTIDAD.Name = "CANTIDAD"
        Me.CANTIDAD.ReadOnly = True
        '
        'PRECIO
        '
        Me.PRECIO.DataPropertyName = "PRECIO"
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.PRECIO.DefaultCellStyle = DataGridViewCellStyle1
        Me.PRECIO.FillWeight = 81.69429!
        Me.PRECIO.HeaderText = "Precio"
        Me.PRECIO.Name = "PRECIO"
        Me.PRECIO.ReadOnly = True
        '
        'IVA
        '
        Me.IVA.DataPropertyName = "IVA"
        Me.IVA.HeaderText = "Iva"
        Me.IVA.Name = "IVA"
        Me.IVA.ReadOnly = True
        '
        'MONTO
        '
        Me.MONTO.DataPropertyName = "MONTO"
        Me.MONTO.HeaderText = "Monto"
        Me.MONTO.Name = "MONTO"
        Me.MONTO.ReadOnly = True
        '
        'SUBTOTAL
        '
        Me.SUBTOTAL.DataPropertyName = "SUBTOTAL"
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.SUBTOTAL.DefaultCellStyle = DataGridViewCellStyle2
        Me.SUBTOTAL.FillWeight = 91.37056!
        Me.SUBTOTAL.HeaderText = "Subtotal"
        Me.SUBTOTAL.Name = "SUBTOTAL"
        Me.SUBTOTAL.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtObservaciones)
        Me.GroupBox1.Controls.Add(Me.Label35)
        Me.GroupBox1.Controls.Add(Me.txtDireccion)
        Me.GroupBox1.Controls.Add(Me.Label34)
        Me.GroupBox1.Controls.Add(Me.cmbModoEntrega)
        Me.GroupBox1.Controls.Add(Me.Label33)
        Me.GroupBox1.Controls.Add(Me.rblEnvioPromocionesSi)
        Me.GroupBox1.Controls.Add(Me.rblEnvioPromocionesNo)
        Me.GroupBox1.Controls.Add(Me.Label32)
        Me.GroupBox1.Controls.Add(Me.dpkFechaRetiro)
        Me.GroupBox1.Controls.Add(Me.Label31)
        Me.GroupBox1.Controls.Add(Me.txtMail)
        Me.GroupBox1.Controls.Add(Me.Label30)
        Me.GroupBox1.Controls.Add(Me.txtTelefono)
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.Controls.Add(Me.Btn_BuscarConsumidorFinal)
        Me.GroupBox1.Controls.Add(Me.txtApellido)
        Me.GroupBox1.Controls.Add(Me.lblApellido)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.lblNombre)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(857, 192)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de la seña"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtObservaciones.Location = New System.Drawing.Point(139, 138)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(659, 48)
        Me.txtObservaciones.TabIndex = 11
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(6, 141)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(94, 15)
        Me.Label35.TabIndex = 22
        Me.Label35.Text = "Observaciones :"
        '
        'txtDireccion
        '
        Me.txtDireccion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDireccion.Location = New System.Drawing.Point(535, 106)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(263, 21)
        Me.txtDireccion.TabIndex = 10
        '
        'Label34
        '
        Me.Label34.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(412, 109)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(78, 15)
        Me.Label34.TabIndex = 20
        Me.Label34.Text = "Dirección (*):"
        '
        'cmbModoEntrega
        '
        Me.cmbModoEntrega.FormattingEnabled = True
        Me.cmbModoEntrega.Items.AddRange(New Object() {"Seleccione una opción", "Envió a domicilio", "Retira de la sucursal", "A convenir"})
        Me.cmbModoEntrega.Location = New System.Drawing.Point(139, 109)
        Me.cmbModoEntrega.Name = "cmbModoEntrega"
        Me.cmbModoEntrega.Size = New System.Drawing.Size(260, 23)
        Me.cmbModoEntrega.TabIndex = 9
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(3, 112)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(130, 15)
        Me.Label33.TabIndex = 18
        Me.Label33.Text = "Metodo de entrega (*):"
        '
        'rblEnvioPromocionesSi
        '
        Me.rblEnvioPromocionesSi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rblEnvioPromocionesSi.AutoSize = True
        Me.rblEnvioPromocionesSi.Location = New System.Drawing.Point(692, 85)
        Me.rblEnvioPromocionesSi.Name = "rblEnvioPromocionesSi"
        Me.rblEnvioPromocionesSi.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.rblEnvioPromocionesSi.Size = New System.Drawing.Size(38, 19)
        Me.rblEnvioPromocionesSi.TabIndex = 8
        Me.rblEnvioPromocionesSi.Text = "Si"
        Me.rblEnvioPromocionesSi.UseVisualStyleBackColor = True
        '
        'rblEnvioPromocionesNo
        '
        Me.rblEnvioPromocionesNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rblEnvioPromocionesNo.AutoSize = True
        Me.rblEnvioPromocionesNo.Checked = True
        Me.rblEnvioPromocionesNo.Location = New System.Drawing.Point(623, 85)
        Me.rblEnvioPromocionesNo.Name = "rblEnvioPromocionesNo"
        Me.rblEnvioPromocionesNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.rblEnvioPromocionesNo.Size = New System.Drawing.Size(43, 19)
        Me.rblEnvioPromocionesNo.TabIndex = 7
        Me.rblEnvioPromocionesNo.TabStop = True
        Me.rblEnvioPromocionesNo.Text = "No"
        Me.rblEnvioPromocionesNo.UseVisualStyleBackColor = True
        '
        'Label32
        '
        Me.Label32.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(412, 85)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(190, 15)
        Me.Label32.TabIndex = 15
        Me.Label32.Text = "Enviar novedades y promociones:"
        '
        'dpkFechaRetiro
        '
        Me.dpkFechaRetiro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dpkFechaRetiro.Location = New System.Drawing.Point(538, 54)
        Me.dpkFechaRetiro.Name = "dpkFechaRetiro"
        Me.dpkFechaRetiro.Size = New System.Drawing.Size(260, 21)
        Me.dpkFechaRetiro.TabIndex = 5
        '
        'Label31
        '
        Me.Label31.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(412, 57)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(121, 15)
        Me.Label31.TabIndex = 12
        Me.Label31.Text = "F. estimada retiro (*):"
        '
        'txtMail
        '
        Me.txtMail.Location = New System.Drawing.Point(139, 81)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(260, 21)
        Me.txtMail.TabIndex = 6
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(6, 87)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(58, 15)
        Me.Label30.TabIndex = 10
        Me.Label30.Text = "Email (*):"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(139, 54)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(260, 21)
        Me.txtTelefono.TabIndex = 4
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(3, 57)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(74, 15)
        Me.Label29.TabIndex = 8
        Me.Label29.Text = "Telefono (*):"
        '
        'Btn_BuscarConsumidorFinal
        '
        Me.Btn_BuscarConsumidorFinal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_BuscarConsumidorFinal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_BuscarConsumidorFinal.FlatAppearance.BorderSize = 0
        Me.Btn_BuscarConsumidorFinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_BuscarConsumidorFinal.Image = Global.SistemaCinderella.My.Resources.Recursos.IconoBuscar32
        Me.Btn_BuscarConsumidorFinal.Location = New System.Drawing.Point(804, 19)
        Me.Btn_BuscarConsumidorFinal.Name = "Btn_BuscarConsumidorFinal"
        Me.Btn_BuscarConsumidorFinal.Size = New System.Drawing.Size(37, 37)
        Me.Btn_BuscarConsumidorFinal.TabIndex = 3
        Me.Btn_BuscarConsumidorFinal.UseVisualStyleBackColor = True
        '
        'txtApellido
        '
        Me.txtApellido.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtApellido.Location = New System.Drawing.Point(538, 27)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(260, 21)
        Me.txtApellido.TabIndex = 2
        '
        'lblApellido
        '
        Me.lblApellido.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido.Location = New System.Drawing.Point(412, 30)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(70, 15)
        Me.lblApellido.TabIndex = 2
        Me.lblApellido.Text = "Apellido (*):"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(139, 27)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(260, 21)
        Me.txtNombre.TabIndex = 1
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(3, 30)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(71, 15)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre (*):"
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Cancelar.Image = Global.SistemaCinderella.My.Resources.Recursos.desconectado_32
        Me.Btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Cancelar.Location = New System.Drawing.Point(654, 656)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Cancelar.TabIndex = 18
        Me.Btn_Cancelar.Text = "Cancelar"
        Me.Btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Cancelar.UseVisualStyleBackColor = True
        '
        'Btn_Finalizar
        '
        Me.Btn_Finalizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Finalizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Finalizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Finalizar.Image = Global.SistemaCinderella.My.Resources.Recursos.Conectado_32
        Me.Btn_Finalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Finalizar.Location = New System.Drawing.Point(760, 656)
        Me.Btn_Finalizar.Name = "Btn_Finalizar"
        Me.Btn_Finalizar.Size = New System.Drawing.Size(112, 40)
        Me.Btn_Finalizar.TabIndex = 19
        Me.Btn_Finalizar.Text = "Crear Seña"
        Me.Btn_Finalizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Finalizar.UseVisualStyleBackColor = True
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'frmSeniaDatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 702)
        Me.Controls.Add(Me.Btn_Cancelar)
        Me.Controls.Add(Me.Btn_Finalizar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSeniaDatos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Información de la seña"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.PanelTotalMinorista.ResumeLayout(False)
        Me.PanelTotalMinorista.PerformLayout()
        Me.PanelTotalMayorista.ResumeLayout(False)
        Me.PanelTotalMayorista.PerformLayout()
        CType(Me.DG_Productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblEncargado As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTipoVenta As Label
    Friend WithEvents lblVendedor As Label
    Friend WithEvents lblFechaSeña As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents lblFacturado As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblCantidad As Label
    Friend WithEvents lblPago As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PanelTotalMinorista As Panel
    Friend WithEvents lblSeniaMinorista As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblMontoMinorista As Label
    Friend WithEvents lblDescuentoMinorista As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents lblSubtotalMinorista As Label
    Friend WithEvents PanelTotalMayorista As Panel
    Friend WithEvents lblMontoMayorista As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents lblIVAMayorista As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents lblSubtotalMayorista As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents lblDescuentoMayorista As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents lblSeniaMayorista As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents lblApellido As Label
    Friend WithEvents dpkFechaRetiro As DateTimePicker
    Friend WithEvents Label31 As Label
    Friend WithEvents txtMail As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents Btn_BuscarConsumidorFinal As Button
    Friend WithEvents cmbModoEntrega As ComboBox
    Friend WithEvents rblEnvioPromocionesSi As RadioButton
    Friend WithEvents rblEnvioPromocionesNo As RadioButton
    Friend WithEvents Label32 As Label
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents Label35 As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents Btn_Cancelar As Button
    Friend WithEvents Btn_Finalizar As Button
    Friend WithEvents lblImporteSaldarMinorista As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblImporteSaldarMayorista As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents DG_Productos As DataGridView
    Friend WithEvents CODIGO As DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE As DataGridViewTextBoxColumn
    Friend WithEvents CANTIDAD As DataGridViewTextBoxColumn
    Friend WithEvents PRECIO As DataGridViewTextBoxColumn
    Friend WithEvents IVA As DataGridViewTextBoxColumn
    Friend WithEvents MONTO As DataGridViewTextBoxColumn
    Friend WithEvents SUBTOTAL As DataGridViewTextBoxColumn
    Friend WithEvents ErrorProvider As ErrorProvider
    Friend WithEvents Label33 As Label
End Class
