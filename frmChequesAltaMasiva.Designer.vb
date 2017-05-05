<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChequesAltaMasiva
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChequesAltaMasiva))
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Btn_Salir = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnAgregarConsecutivo = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MarcaFacturado = New System.Windows.Forms.CheckBox()
        Me.LibradorID = New System.Windows.Forms.TextBox()
        Me.ClienteID = New System.Windows.Forms.TextBox()
        Me.FechaIngreso = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Btn_Agregar_Banco = New System.Windows.Forms.Button()
        Me.Importe = New System.Windows.Forms.TextBox()
        Me.NumeroOrden = New System.Windows.Forms.TextBox()
        Me.Btn_Buscar_Cliente = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BancoEmisor = New System.Windows.Forms.ComboBox()
        Me.BancoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ClienteNombre = New System.Windows.Forms.TextBox()
        Me.FechaDeposito = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FechaVencimiento = New System.Windows.Forms.DateTimePicker()
        Me.LibradorNombre = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.NumeroCheque = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgCheques = New System.Windows.Forms.DataGridView()
        Me.NumeroOrdenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarcaFact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteNombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LibradorNombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Banco = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.NumeroChequeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDespositoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaVencimientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quitar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ChequeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.MontoPagar = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_Total = New System.Windows.Forms.TextBox()
        Me.lbl_DescrTot = New System.Windows.Forms.Label()
        Me.GroupBox.SuspendLayout()
        CType(Me.BancoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgCheques, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChequeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(13, 214)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(117, 13)
        Me.Label25.TabIndex = 72
        Me.Label25.Text = "(*) Campos obligatorios."
        '
        'Btn_Salir
        '
        Me.Btn_Salir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Salir.Image = Global.SistemaCinderella.My.Resources.Recursos.desconectado_32
        Me.Btn_Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Salir.Location = New System.Drawing.Point(766, 624)
        Me.Btn_Salir.Name = "Btn_Salir"
        Me.Btn_Salir.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Salir.TabIndex = 69
        Me.Btn_Salir.Text = "Salir"
        Me.Btn_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Salir.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Image = Global.SistemaCinderella.My.Resources.Recursos.Conectado_32
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.Location = New System.Drawing.Point(872, 624)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(100, 40)
        Me.btnAceptar.TabIndex = 70
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'GroupBox
        '
        Me.GroupBox.Controls.Add(Me.btnAgregar)
        Me.GroupBox.Controls.Add(Me.btnAgregarConsecutivo)
        Me.GroupBox.Controls.Add(Me.Button1)
        Me.GroupBox.Controls.Add(Me.Label25)
        Me.GroupBox.Controls.Add(Me.MarcaFacturado)
        Me.GroupBox.Controls.Add(Me.LibradorID)
        Me.GroupBox.Controls.Add(Me.ClienteID)
        Me.GroupBox.Controls.Add(Me.FechaIngreso)
        Me.GroupBox.Controls.Add(Me.Label1)
        Me.GroupBox.Controls.Add(Me.Label12)
        Me.GroupBox.Controls.Add(Me.Btn_Agregar_Banco)
        Me.GroupBox.Controls.Add(Me.Importe)
        Me.GroupBox.Controls.Add(Me.NumeroOrden)
        Me.GroupBox.Controls.Add(Me.Btn_Buscar_Cliente)
        Me.GroupBox.Controls.Add(Me.Label2)
        Me.GroupBox.Controls.Add(Me.BancoEmisor)
        Me.GroupBox.Controls.Add(Me.Label4)
        Me.GroupBox.Controls.Add(Me.ClienteNombre)
        Me.GroupBox.Controls.Add(Me.FechaDeposito)
        Me.GroupBox.Controls.Add(Me.Label3)
        Me.GroupBox.Controls.Add(Me.FechaVencimiento)
        Me.GroupBox.Controls.Add(Me.LibradorNombre)
        Me.GroupBox.Controls.Add(Me.Label8)
        Me.GroupBox.Controls.Add(Me.Label7)
        Me.GroupBox.Controls.Add(Me.Label9)
        Me.GroupBox.Controls.Add(Me.NumeroCheque)
        Me.GroupBox.Controls.Add(Me.Label6)
        Me.GroupBox.Controls.Add(Me.Label5)
        Me.GroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox.Location = New System.Drawing.Point(12, 91)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(960, 245)
        Me.GroupBox.TabIndex = 71
        Me.GroupBox.TabStop = False
        Me.GroupBox.Text = "INFORMACIÓ DE CHEQUE"
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Image = Global.SistemaCinderella.My.Resources.Recursos.Agregar_24
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.Location = New System.Drawing.Point(727, 199)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(94, 40)
        Me.btnAgregar.TabIndex = 164
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnAgregarConsecutivo
        '
        Me.btnAgregarConsecutivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarConsecutivo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregarConsecutivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarConsecutivo.Image = Global.SistemaCinderella.My.Resources.Recursos.Agregar_24
        Me.btnAgregarConsecutivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregarConsecutivo.Location = New System.Drawing.Point(827, 199)
        Me.btnAgregarConsecutivo.Name = "btnAgregarConsecutivo"
        Me.btnAgregarConsecutivo.Size = New System.Drawing.Size(117, 40)
        Me.btnAgregarConsecutivo.TabIndex = 163
        Me.btnAgregarConsecutivo.Text = "Agregar Consecutivo"
        Me.btnAgregarConsecutivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregarConsecutivo.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Image = Global.SistemaCinderella.My.Resources.Recursos.IconoBuscar24
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(857, 55)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 31)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Buscar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MarcaFacturado
        '
        Me.MarcaFacturado.AutoSize = True
        Me.MarcaFacturado.Enabled = False
        Me.MarcaFacturado.Location = New System.Drawing.Point(130, 62)
        Me.MarcaFacturado.Name = "MarcaFacturado"
        Me.MarcaFacturado.Size = New System.Drawing.Size(15, 14)
        Me.MarcaFacturado.TabIndex = 1
        Me.MarcaFacturado.UseVisualStyleBackColor = True
        '
        'LibradorID
        '
        Me.LibradorID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LibradorID.Location = New System.Drawing.Point(551, 60)
        Me.LibradorID.Name = "LibradorID"
        Me.LibradorID.Size = New System.Drawing.Size(80, 20)
        Me.LibradorID.TabIndex = 6
        '
        'ClienteID
        '
        Me.ClienteID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClienteID.Location = New System.Drawing.Point(551, 24)
        Me.ClienteID.Name = "ClienteID"
        Me.ClienteID.Size = New System.Drawing.Size(80, 20)
        Me.ClienteID.TabIndex = 3
        '
        'FechaIngreso
        '
        Me.FechaIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaIngreso.Location = New System.Drawing.Point(130, 95)
        Me.FechaIngreso.Name = "FechaIngreso"
        Me.FechaIngreso.ReadOnly = True
        Me.FechaIngreso.Size = New System.Drawing.Size(267, 20)
        Me.FechaIngreso.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "N° Orden"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(434, 142)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 13)
        Me.Label12.TabIndex = 162
        Me.Label12.Text = "Importe (*)"
        '
        'Btn_Agregar_Banco
        '
        Me.Btn_Agregar_Banco.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Btn_Agregar_Banco.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Agregar_Banco.Image = Global.SistemaCinderella.My.Resources.Recursos.banco
        Me.Btn_Agregar_Banco.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Agregar_Banco.Location = New System.Drawing.Point(857, 92)
        Me.Btn_Agregar_Banco.Name = "Btn_Agregar_Banco"
        Me.Btn_Agregar_Banco.Size = New System.Drawing.Size(87, 31)
        Me.Btn_Agregar_Banco.TabIndex = 10
        Me.Btn_Agregar_Banco.Text = "Agregar"
        Me.Btn_Agregar_Banco.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Agregar_Banco.UseVisualStyleBackColor = True
        '
        'Importe
        '
        Me.Importe.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Importe.Location = New System.Drawing.Point(551, 136)
        Me.Importe.Name = "Importe"
        Me.Importe.Size = New System.Drawing.Size(267, 20)
        Me.Importe.TabIndex = 12
        '
        'NumeroOrden
        '
        Me.NumeroOrden.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroOrden.Location = New System.Drawing.Point(130, 25)
        Me.NumeroOrden.Name = "NumeroOrden"
        Me.NumeroOrden.ReadOnly = True
        Me.NumeroOrden.Size = New System.Drawing.Size(267, 20)
        Me.NumeroOrden.TabIndex = 0
        '
        'Btn_Buscar_Cliente
        '
        Me.Btn_Buscar_Cliente.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Btn_Buscar_Cliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Buscar_Cliente.Image = Global.SistemaCinderella.My.Resources.Recursos.IconoBuscar24
        Me.Btn_Buscar_Cliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Buscar_Cliente.Location = New System.Drawing.Point(857, 18)
        Me.Btn_Buscar_Cliente.Name = "Btn_Buscar_Cliente"
        Me.Btn_Buscar_Cliente.Size = New System.Drawing.Size(87, 31)
        Me.Btn_Buscar_Cliente.TabIndex = 5
        Me.Btn_Buscar_Cliente.Text = "Buscar"
        Me.Btn_Buscar_Cliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Buscar_Cliente.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Fecha Ingreso"
        '
        'BancoEmisor
        '
        Me.BancoEmisor.DataSource = Me.BancoBindingSource
        Me.BancoEmisor.DisplayMember = "Nombre"
        Me.BancoEmisor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BancoEmisor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BancoEmisor.FormattingEnabled = True
        Me.BancoEmisor.Location = New System.Drawing.Point(551, 98)
        Me.BancoEmisor.Name = "BancoEmisor"
        Me.BancoEmisor.Size = New System.Drawing.Size(267, 21)
        Me.BancoEmisor.TabIndex = 9
        Me.BancoEmisor.ValueMember = "BancoId"
        '
        'BancoBindingSource
        '
        Me.BancoBindingSource.DataSource = GetType(Entidades.Tarjeta)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(434, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Cliente (*)"
        '
        'ClienteNombre
        '
        Me.ClienteNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClienteNombre.Location = New System.Drawing.Point(637, 24)
        Me.ClienteNombre.Name = "ClienteNombre"
        Me.ClienteNombre.Size = New System.Drawing.Size(181, 20)
        Me.ClienteNombre.TabIndex = 4
        '
        'FechaDeposito
        '
        Me.FechaDeposito.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaDeposito.Location = New System.Drawing.Point(130, 173)
        Me.FechaDeposito.Name = "FechaDeposito"
        Me.FechaDeposito.Size = New System.Drawing.Size(267, 20)
        Me.FechaDeposito.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(434, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Librador (*)"
        '
        'FechaVencimiento
        '
        Me.FechaVencimiento.Enabled = False
        Me.FechaVencimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaVencimiento.Location = New System.Drawing.Point(551, 173)
        Me.FechaVencimiento.Name = "FechaVencimiento"
        Me.FechaVencimiento.Size = New System.Drawing.Size(267, 20)
        Me.FechaVencimiento.TabIndex = 14
        '
        'LibradorNombre
        '
        Me.LibradorNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LibradorNombre.Location = New System.Drawing.Point(637, 61)
        Me.LibradorNombre.Name = "LibradorNombre"
        Me.LibradorNombre.Size = New System.Drawing.Size(181, 20)
        Me.LibradorNombre.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(434, 104)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 13)
        Me.Label8.TabIndex = 82
        Me.Label8.Text = "Banco Emisor (*)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(13, 142)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 102
        Me.Label7.Text = "N° Cheque (*)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(13, 67)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Marca Facturado"
        '
        'NumeroCheque
        '
        Me.NumeroCheque.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroCheque.Location = New System.Drawing.Point(130, 136)
        Me.NumeroCheque.Name = "NumeroCheque"
        Me.NumeroCheque.Size = New System.Drawing.Size(267, 20)
        Me.NumeroCheque.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 179)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 13)
        Me.Label6.TabIndex = 122
        Me.Label6.Text = "Fecha Deposito (*)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(434, 179)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 13)
        Me.Label5.TabIndex = 142
        Me.Label5.Text = "Fecha Vencimiento (*)"
        '
        'dgCheques
        '
        Me.dgCheques.AllowUserToAddRows = False
        Me.dgCheques.AllowUserToDeleteRows = False
        Me.dgCheques.AllowUserToResizeColumns = False
        Me.dgCheques.AllowUserToResizeRows = False
        Me.dgCheques.AutoGenerateColumns = False
        Me.dgCheques.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCheques.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumeroOrdenDataGridViewTextBoxColumn, Me.MarcaFact, Me.ClienteNombreDataGridViewTextBoxColumn, Me.LibradorNombreDataGridViewTextBoxColumn, Me.Banco, Me.NumeroChequeDataGridViewTextBoxColumn, Me.ImporteDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn1, Me.FechaDespositoDataGridViewTextBoxColumn, Me.FechaVencimientoDataGridViewTextBoxColumn, Me.Quitar})
        Me.dgCheques.DataSource = Me.ChequeBindingSource
        Me.dgCheques.Location = New System.Drawing.Point(12, 342)
        Me.dgCheques.Name = "dgCheques"
        Me.dgCheques.ReadOnly = True
        Me.dgCheques.Size = New System.Drawing.Size(960, 217)
        Me.dgCheques.TabIndex = 73
        '
        'NumeroOrdenDataGridViewTextBoxColumn
        '
        Me.NumeroOrdenDataGridViewTextBoxColumn.DataPropertyName = "NumeroOrden"
        Me.NumeroOrdenDataGridViewTextBoxColumn.HeaderText = "Orden"
        Me.NumeroOrdenDataGridViewTextBoxColumn.Name = "NumeroOrdenDataGridViewTextBoxColumn"
        Me.NumeroOrdenDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumeroOrdenDataGridViewTextBoxColumn.Width = 65
        '
        'MarcaFact
        '
        Me.MarcaFact.DataPropertyName = "MarcaFacturado"
        Me.MarcaFact.HeaderText = "Marca Fact."
        Me.MarcaFact.Name = "MarcaFact"
        Me.MarcaFact.ReadOnly = True
        Me.MarcaFact.Width = 65
        '
        'ClienteNombreDataGridViewTextBoxColumn
        '
        Me.ClienteNombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ClienteNombreDataGridViewTextBoxColumn.DataPropertyName = "ClienteNombre"
        Me.ClienteNombreDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.ClienteNombreDataGridViewTextBoxColumn.Name = "ClienteNombreDataGridViewTextBoxColumn"
        Me.ClienteNombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LibradorNombreDataGridViewTextBoxColumn
        '
        Me.LibradorNombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.LibradorNombreDataGridViewTextBoxColumn.DataPropertyName = "LibradorNombre"
        Me.LibradorNombreDataGridViewTextBoxColumn.HeaderText = "Librador"
        Me.LibradorNombreDataGridViewTextBoxColumn.Name = "LibradorNombreDataGridViewTextBoxColumn"
        Me.LibradorNombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Banco
        '
        Me.Banco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Banco.DataPropertyName = "BancoEmisorId"
        Me.Banco.DataSource = Me.BancoBindingSource
        Me.Banco.DisplayMember = "Nombre"
        Me.Banco.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.Banco.HeaderText = "Banco"
        Me.Banco.Name = "Banco"
        Me.Banco.ReadOnly = True
        Me.Banco.ValueMember = "BancoId"
        '
        'NumeroChequeDataGridViewTextBoxColumn
        '
        Me.NumeroChequeDataGridViewTextBoxColumn.DataPropertyName = "NumeroCheque"
        Me.NumeroChequeDataGridViewTextBoxColumn.HeaderText = "Ch. Nro."
        Me.NumeroChequeDataGridViewTextBoxColumn.Name = "NumeroChequeDataGridViewTextBoxColumn"
        Me.NumeroChequeDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumeroChequeDataGridViewTextBoxColumn.Width = 75
        '
        'ImporteDataGridViewTextBoxColumn
        '
        Me.ImporteDataGridViewTextBoxColumn.DataPropertyName = "Importe"
        Me.ImporteDataGridViewTextBoxColumn.HeaderText = "Monto"
        Me.ImporteDataGridViewTextBoxColumn.Name = "ImporteDataGridViewTextBoxColumn"
        Me.ImporteDataGridViewTextBoxColumn.ReadOnly = True
        Me.ImporteDataGridViewTextBoxColumn.Width = 65
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "FechaIngreso"
        Me.DataGridViewTextBoxColumn1.HeaderText = "F. Ingreso"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 80
        '
        'FechaDespositoDataGridViewTextBoxColumn
        '
        Me.FechaDespositoDataGridViewTextBoxColumn.DataPropertyName = "FechaDesposito"
        Me.FechaDespositoDataGridViewTextBoxColumn.HeaderText = "F. Depósito"
        Me.FechaDespositoDataGridViewTextBoxColumn.Name = "FechaDespositoDataGridViewTextBoxColumn"
        Me.FechaDespositoDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaDespositoDataGridViewTextBoxColumn.Width = 90
        '
        'FechaVencimientoDataGridViewTextBoxColumn
        '
        Me.FechaVencimientoDataGridViewTextBoxColumn.DataPropertyName = "FechaVencimiento"
        Me.FechaVencimientoDataGridViewTextBoxColumn.HeaderText = "F. Vto."
        Me.FechaVencimientoDataGridViewTextBoxColumn.Name = "FechaVencimientoDataGridViewTextBoxColumn"
        Me.FechaVencimientoDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaVencimientoDataGridViewTextBoxColumn.Width = 80
        '
        'Quitar
        '
        Me.Quitar.HeaderText = "Quitar"
        Me.Quitar.Image = Global.SistemaCinderella.My.Resources.Recursos.Boton_Eliminar
        Me.Quitar.Name = "Quitar"
        Me.Quitar.ReadOnly = True
        Me.Quitar.Width = 55
        '
        'ChequeBindingSource
        '
        Me.ChequeBindingSource.DataSource = GetType(Entidades.Cheque)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.MontoPagar)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(960, 73)
        Me.GroupBox1.TabIndex = 74
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INFORMACIÓN VENTA"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(13, 35)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Monto a Pagar"
        '
        'MontoPagar
        '
        Me.MontoPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MontoPagar.Location = New System.Drawing.Point(130, 29)
        Me.MontoPagar.Name = "MontoPagar"
        Me.MontoPagar.ReadOnly = True
        Me.MontoPagar.Size = New System.Drawing.Size(267, 20)
        Me.MontoPagar.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(797, 582)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(26, 29)
        Me.Label13.TabIndex = 77
        Me.Label13.Text = "$"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Total
        '
        Me.txt_Total.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Total.Location = New System.Drawing.Point(833, 576)
        Me.txt_Total.Name = "txt_Total"
        Me.txt_Total.ReadOnly = True
        Me.txt_Total.Size = New System.Drawing.Size(139, 35)
        Me.txt_Total.TabIndex = 76
        Me.txt_Total.Text = "0,00"
        Me.txt_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_DescrTot
        '
        Me.lbl_DescrTot.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_DescrTot.AutoSize = True
        Me.lbl_DescrTot.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DescrTot.Location = New System.Drawing.Point(585, 585)
        Me.lbl_DescrTot.Name = "lbl_DescrTot"
        Me.lbl_DescrTot.Size = New System.Drawing.Size(98, 29)
        Me.lbl_DescrTot.TabIndex = 75
        Me.lbl_DescrTot.Text = "TOTAL:"
        '
        'frmChequesAltaMasiva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 676)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txt_Total)
        Me.Controls.Add(Me.lbl_DescrTot)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgCheques)
        Me.Controls.Add(Me.Btn_Salir)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.GroupBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmChequesAltaMasiva"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta de Cheques"
        Me.GroupBox.ResumeLayout(False)
        Me.GroupBox.PerformLayout()
        CType(Me.BancoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgCheques, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChequeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Btn_Salir As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MarcaFacturado As System.Windows.Forms.CheckBox
    Friend WithEvents LibradorID As System.Windows.Forms.TextBox
    Friend WithEvents ClienteID As System.Windows.Forms.TextBox
    Friend WithEvents FechaIngreso As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Btn_Agregar_Banco As System.Windows.Forms.Button
    Friend WithEvents Importe As System.Windows.Forms.TextBox
    Friend WithEvents NumeroOrden As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Buscar_Cliente As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BancoEmisor As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ClienteNombre As System.Windows.Forms.TextBox
    Friend WithEvents FechaDeposito As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents FechaVencimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents LibradorNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents NumeroCheque As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dgCheques As System.Windows.Forms.DataGridView
    Friend WithEvents ChequeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BancoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnAgregarConsecutivo As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents MontoPagar As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_Total As System.Windows.Forms.TextBox
    Friend WithEvents lbl_DescrTot As System.Windows.Forms.Label
    Friend WithEvents NumeroOrdenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MarcaFact As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClienteNombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LibradorNombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Banco As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents NumeroChequeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImporteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDespositoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaVencimientoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Quitar As System.Windows.Forms.DataGridViewImageColumn
End Class
