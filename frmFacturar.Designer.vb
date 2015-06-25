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
        Me.Button1 = New System.Windows.Forms.Button()
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.GroupBox1.Controls.Add(Me.Button1)
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
        Me.GroupBox1.Location = New System.Drawing.Point(13, 92)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(368, 324)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información de la Venta"
        '
        'lbl_Subtotal
        '
        Me.lbl_Subtotal.AutoSize = True
        Me.lbl_Subtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Subtotal.Location = New System.Drawing.Point(138, 74)
        Me.lbl_Subtotal.Name = "lbl_Subtotal"
        Me.lbl_Subtotal.Size = New System.Drawing.Size(73, 16)
        Me.lbl_Subtotal.TabIndex = 21
        Me.lbl_Subtotal.Text = "$ 120.00.-"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 74)
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
        Me.lbl_Descuento.Location = New System.Drawing.Point(138, 49)
        Me.lbl_Descuento.Name = "lbl_Descuento"
        Me.lbl_Descuento.Size = New System.Drawing.Size(73, 16)
        Me.lbl_Descuento.TabIndex = 19
        Me.lbl_Descuento.Text = "$ 120.00.-"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 49)
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
        Me.lbl_TipoPago.Location = New System.Drawing.Point(138, 124)
        Me.lbl_TipoPago.Name = "lbl_TipoPago"
        Me.lbl_TipoPago.Size = New System.Drawing.Size(64, 15)
        Me.lbl_TipoPago.TabIndex = 17
        Me.lbl_TipoPago.Text = "EFECTIVO"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 124)
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
        Me.lbl_Fecha.Location = New System.Drawing.Point(138, 24)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(69, 15)
        Me.lbl_Fecha.TabIndex = 15
        Me.lbl_Fecha.Text = "04/05/2012"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 24)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 15)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Fecha"
        '
        'txt_Cuit
        '
        Me.txt_Cuit.Location = New System.Drawing.Point(141, 243)
        Me.txt_Cuit.Name = "txt_Cuit"
        Me.txt_Cuit.Size = New System.Drawing.Size(219, 21)
        Me.txt_Cuit.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 249)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 15)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "CUIT (sólo numeros)"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.SistemaCinderella.My.Resources.Recursos.Conectado_32
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(259, 277)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 40)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Facturar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt_Localidad
        '
        Me.txt_Localidad.Location = New System.Drawing.Point(140, 219)
        Me.txt_Localidad.Name = "txt_Localidad"
        Me.txt_Localidad.Size = New System.Drawing.Size(219, 21)
        Me.txt_Localidad.TabIndex = 4
        '
        'txt_Direccion
        '
        Me.txt_Direccion.Location = New System.Drawing.Point(141, 195)
        Me.txt_Direccion.Name = "txt_Direccion"
        Me.txt_Direccion.Size = New System.Drawing.Size(219, 21)
        Me.txt_Direccion.TabIndex = 3
        '
        'txt_Nombre
        '
        Me.txt_Nombre.Location = New System.Drawing.Point(141, 171)
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
        Me.Cb_IVA.Location = New System.Drawing.Point(140, 145)
        Me.Cb_IVA.Name = "Cb_IVA"
        Me.Cb_IVA.Size = New System.Drawing.Size(219, 23)
        Me.Cb_IVA.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 224)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 15)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Localidad"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 199)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Dirección"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nombre y Apellido"
        '
        'lbl_Total
        '
        Me.lbl_Total.AutoSize = True
        Me.lbl_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Total.Location = New System.Drawing.Point(138, 99)
        Me.lbl_Total.Name = "lbl_Total"
        Me.lbl_Total.Size = New System.Drawing.Size(73, 16)
        Me.lbl_Total.TabIndex = 3
        Me.lbl_Total.Text = "$ 120.00.-"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 149)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Condición de IVA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 99)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total"
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
        'frmFacturar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 429)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
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
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_Fecha As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_Cuit As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
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
End Class
