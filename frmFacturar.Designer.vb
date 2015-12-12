<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFacturar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFacturar))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_Comprobante_Origen = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lbl_Subtotal = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lbl_Descuento = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbl_TipoPago = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbl_Fecha = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_Cuit = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_Localidad = New System.Windows.Forms.TextBox()
        Me.txt_Direccion = New System.Windows.Forms.TextBox()
        Me.txt_Nombre = New System.Windows.Forms.TextBox()
        Me.Cb_IVA = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_Total = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnFacturar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Cb_TipoFacturacion = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GB_FacturacionManual = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.QuitarNumeroFactura = New System.Windows.Forms.Button()
        Me.AgregarNumeroFactura = New System.Windows.Forms.Button()
        Me.FacturasList = New System.Windows.Forms.ListBox()
        Me.txt_NumeroFacturaManual = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnNotaCredito = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GB_FacturacionManual.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txt_Comprobante_Origen)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.lbl_Subtotal)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.lbl_Descuento)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.lbl_TipoPago)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.lbl_Fecha)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txt_Cuit)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_Localidad)
        Me.GroupBox1.Controls.Add(Me.txt_Direccion)
        Me.GroupBox1.Controls.Add(Me.txt_Nombre)
        Me.GroupBox1.Controls.Add(Me.Cb_IVA)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lbl_Total)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 89)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(368, 294)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información"
        '
        'txt_Comprobante_Origen
        '
        Me.txt_Comprobante_Origen.Location = New System.Drawing.Point(139, 265)
        Me.txt_Comprobante_Origen.Name = "txt_Comprobante_Origen"
        Me.txt_Comprobante_Origen.Size = New System.Drawing.Size(219, 21)
        Me.txt_Comprobante_Origen.TabIndex = 6
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 267)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(122, 15)
        Me.Label15.TabIndex = 23
        Me.Label15.Text = "Comprobante Origen"
        '
        'lbl_Subtotal
        '
        Me.lbl_Subtotal.AutoSize = True
        Me.lbl_Subtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Subtotal.Location = New System.Drawing.Point(137, 72)
        Me.lbl_Subtotal.Name = "lbl_Subtotal"
        Me.lbl_Subtotal.Size = New System.Drawing.Size(73, 16)
        Me.lbl_Subtotal.TabIndex = 21
        Me.lbl_Subtotal.Text = "$ 120.00.-"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 72)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 15)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Subtotal"
        '
        'lbl_Descuento
        '
        Me.lbl_Descuento.AutoSize = True
        Me.lbl_Descuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Descuento.Location = New System.Drawing.Point(137, 47)
        Me.lbl_Descuento.Name = "lbl_Descuento"
        Me.lbl_Descuento.Size = New System.Drawing.Size(73, 16)
        Me.lbl_Descuento.TabIndex = 19
        Me.lbl_Descuento.Text = "$ 120.00.-"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 47)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 15)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Descuento"
        '
        'lbl_TipoPago
        '
        Me.lbl_TipoPago.AutoSize = True
        Me.lbl_TipoPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TipoPago.Location = New System.Drawing.Point(137, 122)
        Me.lbl_TipoPago.Name = "lbl_TipoPago"
        Me.lbl_TipoPago.Size = New System.Drawing.Size(64, 15)
        Me.lbl_TipoPago.TabIndex = 17
        Me.lbl_TipoPago.Text = "EFECTIVO"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 122)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 15)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Tipo de Pago"
        '
        'lbl_Fecha
        '
        Me.lbl_Fecha.AutoSize = True
        Me.lbl_Fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Fecha.Location = New System.Drawing.Point(137, 22)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(69, 15)
        Me.lbl_Fecha.TabIndex = 15
        Me.lbl_Fecha.Text = "04/05/2012"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 22)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 15)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Fecha"
        '
        'txt_Cuit
        '
        Me.txt_Cuit.Location = New System.Drawing.Point(140, 241)
        Me.txt_Cuit.Name = "txt_Cuit"
        Me.txt_Cuit.Size = New System.Drawing.Size(219, 21)
        Me.txt_Cuit.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 247)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 15)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "CUIT (sólo numeros)"
        '
        'txt_Localidad
        '
        Me.txt_Localidad.Location = New System.Drawing.Point(139, 217)
        Me.txt_Localidad.Name = "txt_Localidad"
        Me.txt_Localidad.Size = New System.Drawing.Size(219, 21)
        Me.txt_Localidad.TabIndex = 4
        '
        'txt_Direccion
        '
        Me.txt_Direccion.Location = New System.Drawing.Point(140, 193)
        Me.txt_Direccion.Name = "txt_Direccion"
        Me.txt_Direccion.Size = New System.Drawing.Size(219, 21)
        Me.txt_Direccion.TabIndex = 3
        '
        'txt_Nombre
        '
        Me.txt_Nombre.Location = New System.Drawing.Point(140, 169)
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.Size = New System.Drawing.Size(219, 21)
        Me.txt_Nombre.TabIndex = 2
        '
        'Cb_IVA
        '
        Me.Cb_IVA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cb_IVA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_IVA.FormattingEnabled = True
        Me.Cb_IVA.Items.AddRange(New Object() {"Responsable Inscripto", "Consumidor Final"})
        Me.Cb_IVA.Location = New System.Drawing.Point(139, 143)
        Me.Cb_IVA.Name = "Cb_IVA"
        Me.Cb_IVA.Size = New System.Drawing.Size(219, 23)
        Me.Cb_IVA.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 222)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 15)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Localidad"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 197)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Dirección"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 172)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nombre y Apellido"
        '
        'lbl_Total
        '
        Me.lbl_Total.AutoSize = True
        Me.lbl_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Total.Location = New System.Drawing.Point(137, 97)
        Me.lbl_Total.Name = "lbl_Total"
        Me.lbl_Total.Size = New System.Drawing.Size(73, 16)
        Me.lbl_Total.TabIndex = 3
        Me.lbl_Total.Text = "$ 120.00.-"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 147)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Condición de IVA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 97)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total"
        '
        'btnFacturar
        '
        Me.btnFacturar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFacturar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFacturar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFacturar.Image = Global.SistemaCinderella.My.Resources.Recursos.Conectado_32
        Me.btnFacturar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFacturar.Location = New System.Drawing.Point(655, 389)
        Me.btnFacturar.Name = "btnFacturar"
        Me.btnFacturar.Size = New System.Drawing.Size(100, 40)
        Me.btnFacturar.TabIndex = 13
        Me.btnFacturar.Text = "Facturar"
        Me.btnFacturar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFacturar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblEstado)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(368, 70)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Controlador Fiscal"
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.Location = New System.Drawing.Point(69, 34)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(39, 15)
        Me.lblEstado.TabIndex = 1
        Me.lblEstado.Text = "- - - -"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Estado"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Cb_TipoFacturacion)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Location = New System.Drawing.Point(387, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(368, 70)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Factura"
        '
        'Cb_TipoFacturacion
        '
        Me.Cb_TipoFacturacion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cb_TipoFacturacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_TipoFacturacion.FormattingEnabled = True
        Me.Cb_TipoFacturacion.Location = New System.Drawing.Point(140, 31)
        Me.Cb_TipoFacturacion.Name = "Cb_TipoFacturacion"
        Me.Cb_TipoFacturacion.Size = New System.Drawing.Size(219, 23)
        Me.Cb_TipoFacturacion.TabIndex = 7
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(7, 34)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(31, 15)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Tipo"
        '
        'GB_FacturacionManual
        '
        Me.GB_FacturacionManual.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_FacturacionManual.Controls.Add(Me.Label14)
        Me.GB_FacturacionManual.Controls.Add(Me.QuitarNumeroFactura)
        Me.GB_FacturacionManual.Controls.Add(Me.AgregarNumeroFactura)
        Me.GB_FacturacionManual.Controls.Add(Me.FacturasList)
        Me.GB_FacturacionManual.Controls.Add(Me.txt_NumeroFacturaManual)
        Me.GB_FacturacionManual.Controls.Add(Me.Label8)
        Me.GB_FacturacionManual.Location = New System.Drawing.Point(388, 89)
        Me.GB_FacturacionManual.Name = "GB_FacturacionManual"
        Me.GB_FacturacionManual.Size = New System.Drawing.Size(367, 294)
        Me.GB_FacturacionManual.TabIndex = 3
        Me.GB_FacturacionManual.TabStop = False
        Me.GB_FacturacionManual.Text = "Información Facturación Manual"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 78)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(54, 15)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "Facturas"
        '
        'QuitarNumeroFactura
        '
        Me.QuitarNumeroFactura.Location = New System.Drawing.Point(283, 178)
        Me.QuitarNumeroFactura.Name = "QuitarNumeroFactura"
        Me.QuitarNumeroFactura.Size = New System.Drawing.Size(75, 23)
        Me.QuitarNumeroFactura.TabIndex = 11
        Me.QuitarNumeroFactura.Text = "Quitar"
        Me.QuitarNumeroFactura.UseVisualStyleBackColor = True
        '
        'AgregarNumeroFactura
        '
        Me.AgregarNumeroFactura.Location = New System.Drawing.Point(283, 49)
        Me.AgregarNumeroFactura.Name = "AgregarNumeroFactura"
        Me.AgregarNumeroFactura.Size = New System.Drawing.Size(75, 23)
        Me.AgregarNumeroFactura.TabIndex = 9
        Me.AgregarNumeroFactura.Text = "Agregar"
        Me.AgregarNumeroFactura.UseVisualStyleBackColor = True
        '
        'FacturasList
        '
        Me.FacturasList.FormattingEnabled = True
        Me.FacturasList.ItemHeight = 15
        Me.FacturasList.Location = New System.Drawing.Point(139, 78)
        Me.FacturasList.Name = "FacturasList"
        Me.FacturasList.Size = New System.Drawing.Size(219, 94)
        Me.FacturasList.TabIndex = 10
        '
        'txt_NumeroFacturaManual
        '
        Me.txt_NumeroFacturaManual.Location = New System.Drawing.Point(139, 22)
        Me.txt_NumeroFacturaManual.Name = "txt_NumeroFacturaManual"
        Me.txt_NumeroFacturaManual.Size = New System.Drawing.Size(219, 21)
        Me.txt_NumeroFacturaManual.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 15)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Numero Factura"
        '
        'btnNotaCredito
        '
        Me.btnNotaCredito.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNotaCredito.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNotaCredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotaCredito.Image = Global.SistemaCinderella.My.Resources.Recursos.nota_credito
        Me.btnNotaCredito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNotaCredito.Location = New System.Drawing.Point(549, 389)
        Me.btnNotaCredito.Name = "btnNotaCredito"
        Me.btnNotaCredito.Size = New System.Drawing.Size(100, 40)
        Me.btnNotaCredito.TabIndex = 12
        Me.btnNotaCredito.Text = "Nota Cred"
        Me.btnNotaCredito.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNotaCredito.UseVisualStyleBackColor = True
        '
        'frmFacturar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(766, 440)
        Me.Controls.Add(Me.btnNotaCredito)
        Me.Controls.Add(Me.GB_FacturacionManual)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnFacturar)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmFacturar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturación de Venta"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GB_FacturacionManual.ResumeLayout(False)
        Me.GB_FacturacionManual.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_Fecha As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_Cuit As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnFacturar As System.Windows.Forms.Button
    Friend WithEvents txt_Localidad As System.Windows.Forms.TextBox
    Friend WithEvents txt_Direccion As System.Windows.Forms.TextBox
    Friend WithEvents txt_Nombre As System.Windows.Forms.TextBox
    Friend WithEvents Cb_IVA As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbl_Total As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbl_TipoPago As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lbl_Descuento As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lbl_Subtotal As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Cb_TipoFacturacion As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GB_FacturacionManual As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents QuitarNumeroFactura As System.Windows.Forms.Button
    Friend WithEvents AgregarNumeroFactura As System.Windows.Forms.Button
    Friend WithEvents FacturasList As System.Windows.Forms.ListBox
    Friend WithEvents txt_NumeroFacturaManual As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnNotaCredito As System.Windows.Forms.Button
    Friend WithEvents txt_Comprobante_Origen As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
End Class
