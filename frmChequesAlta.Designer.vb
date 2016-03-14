<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChequesAlta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChequesAlta))
        Me.GroupBox = New System.Windows.Forms.GroupBox()
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
        Me.Btn_Salir = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.GroupBox.SuspendLayout()
        CType(Me.BancoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox
        '
        Me.GroupBox.Controls.Add(Me.Button1)
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
        Me.GroupBox.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(491, 386)
        Me.GroupBox.TabIndex = 34
        Me.GroupBox.TabStop = False
        Me.GroupBox.Text = "Alta de cheque en la sucursal"
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Image = Global.SistemaCinderella.My.Resources.Recursos.IconoBuscar24
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(396, 153)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 31)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Buscar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MarcaFacturado
        '
        Me.MarcaFacturado.AutoSize = True
        Me.MarcaFacturado.Enabled = False
        Me.MarcaFacturado.Location = New System.Drawing.Point(123, 54)
        Me.MarcaFacturado.Name = "MarcaFacturado"
        Me.MarcaFacturado.Size = New System.Drawing.Size(15, 14)
        Me.MarcaFacturado.TabIndex = 1
        Me.MarcaFacturado.UseVisualStyleBackColor = True
        '
        'LibradorID
        '
        Me.LibradorID.Location = New System.Drawing.Point(123, 159)
        Me.LibradorID.Name = "LibradorID"
        Me.LibradorID.Size = New System.Drawing.Size(80, 20)
        Me.LibradorID.TabIndex = 6
        '
        'ClienteID
        '
        Me.ClienteID.Location = New System.Drawing.Point(123, 123)
        Me.ClienteID.Name = "ClienteID"
        Me.ClienteID.Size = New System.Drawing.Size(80, 20)
        Me.ClienteID.TabIndex = 3
        '
        'FechaIngreso
        '
        Me.FechaIngreso.Location = New System.Drawing.Point(123, 87)
        Me.FechaIngreso.Name = "FechaIngreso"
        Me.FechaIngreso.ReadOnly = True
        Me.FechaIngreso.Size = New System.Drawing.Size(267, 20)
        Me.FechaIngreso.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "N° Orden"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 281)
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
        Me.Btn_Agregar_Banco.Location = New System.Drawing.Point(396, 191)
        Me.Btn_Agregar_Banco.Name = "Btn_Agregar_Banco"
        Me.Btn_Agregar_Banco.Size = New System.Drawing.Size(81, 31)
        Me.Btn_Agregar_Banco.TabIndex = 10
        Me.Btn_Agregar_Banco.Text = "Agregar"
        Me.Btn_Agregar_Banco.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Agregar_Banco.UseVisualStyleBackColor = True
        '
        'Importe
        '
        Me.Importe.Location = New System.Drawing.Point(123, 275)
        Me.Importe.Name = "Importe"
        Me.Importe.Size = New System.Drawing.Size(267, 20)
        Me.Importe.TabIndex = 12
        '
        'NumeroOrden
        '
        Me.NumeroOrden.Location = New System.Drawing.Point(123, 17)
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
        Me.Btn_Buscar_Cliente.Location = New System.Drawing.Point(396, 116)
        Me.Btn_Buscar_Cliente.Name = "Btn_Buscar_Cliente"
        Me.Btn_Buscar_Cliente.Size = New System.Drawing.Size(81, 31)
        Me.Btn_Buscar_Cliente.TabIndex = 5
        Me.Btn_Buscar_Cliente.Text = "Buscar"
        Me.Btn_Buscar_Cliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Buscar_Cliente.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 93)
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
        Me.BancoEmisor.FormattingEnabled = True
        Me.BancoEmisor.Location = New System.Drawing.Point(123, 197)
        Me.BancoEmisor.Name = "BancoEmisor"
        Me.BancoEmisor.Size = New System.Drawing.Size(267, 21)
        Me.BancoEmisor.TabIndex = 9
        Me.BancoEmisor.ValueMember = "BancoId"
        '
        'BancoBindingSource
        '
        Me.BancoBindingSource.DataSource = GetType(Entidades.Banco)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Cliente (*)"
        '
        'ClienteNombre
        '
        Me.ClienteNombre.Location = New System.Drawing.Point(209, 123)
        Me.ClienteNombre.Name = "ClienteNombre"
        Me.ClienteNombre.Size = New System.Drawing.Size(181, 20)
        Me.ClienteNombre.TabIndex = 4
        '
        'FechaDeposito
        '
        Me.FechaDeposito.Location = New System.Drawing.Point(123, 313)
        Me.FechaDeposito.Name = "FechaDeposito"
        Me.FechaDeposito.Size = New System.Drawing.Size(267, 20)
        Me.FechaDeposito.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Librador (*)"
        '
        'FechaVencimiento
        '
        Me.FechaVencimiento.Enabled = False
        Me.FechaVencimiento.Location = New System.Drawing.Point(123, 352)
        Me.FechaVencimiento.Name = "FechaVencimiento"
        Me.FechaVencimiento.Size = New System.Drawing.Size(267, 20)
        Me.FechaVencimiento.TabIndex = 14
        '
        'LibradorNombre
        '
        Me.LibradorNombre.Location = New System.Drawing.Point(209, 160)
        Me.LibradorNombre.Name = "LibradorNombre"
        Me.LibradorNombre.Size = New System.Drawing.Size(181, 20)
        Me.LibradorNombre.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 203)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 13)
        Me.Label8.TabIndex = 82
        Me.Label8.Text = "Banco Emisor (*)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 242)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 102
        Me.Label7.Text = "N° Cheque (*)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 59)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Marca Facturado"
        '
        'NumeroCheque
        '
        Me.NumeroCheque.Location = New System.Drawing.Point(123, 236)
        Me.NumeroCheque.Name = "NumeroCheque"
        Me.NumeroCheque.Size = New System.Drawing.Size(267, 20)
        Me.NumeroCheque.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 319)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 13)
        Me.Label6.TabIndex = 122
        Me.Label6.Text = "Fecha Deposito (*)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 358)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 13)
        Me.Label5.TabIndex = 142
        Me.Label5.Text = "Fecha Vencimiento (*)"
        '
        'Btn_Salir
        '
        Me.Btn_Salir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Salir.Image = Global.SistemaCinderella.My.Resources.Recursos.desconectado_32
        Me.Btn_Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Salir.Location = New System.Drawing.Point(297, 405)
        Me.Btn_Salir.Name = "Btn_Salir"
        Me.Btn_Salir.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Salir.TabIndex = 15
        Me.Btn_Salir.Text = "Salir"
        Me.Btn_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Salir.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Image = Global.SistemaCinderella.My.Resources.Recursos.Agregar_24
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.Location = New System.Drawing.Point(403, 405)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(100, 40)
        Me.btnAceptar.TabIndex = 16
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(18, 405)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(117, 13)
        Me.Label25.TabIndex = 68
        Me.Label25.Text = "(*) Campos obligatorios."
        '
        'frmChequesAlta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 457)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Btn_Salir)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.GroupBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmChequesAlta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta de Cheques"
        Me.GroupBox.ResumeLayout(False)
        Me.GroupBox.PerformLayout()
        CType(Me.BancoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Btn_Agregar_Banco As System.Windows.Forms.Button
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
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Importe As System.Windows.Forms.TextBox
    Friend WithEvents FechaIngreso As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Salir As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents ClienteID As System.Windows.Forms.TextBox
    Friend WithEvents LibradorID As System.Windows.Forms.TextBox
    Friend WithEvents MarcaFacturado As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BancoBindingSource As System.Windows.Forms.BindingSource
End Class
