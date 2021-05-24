<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVerNotaCredito
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbl_Cuit = New System.Windows.Forms.Label()
        Me.lbl_Condicion = New System.Windows.Forms.Label()
        Me.lbl_Nombre = New System.Windows.Forms.Label()
        Me.lbl_Localidad = New System.Windows.Forms.Label()
        Me.lbl_Direccion = New System.Windows.Forms.Label()
        Me.lbl_NumeroNota = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbl_Fecha = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_Total = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.lbl_Cuit)
        Me.GroupBox1.Controls.Add(Me.lbl_Condicion)
        Me.GroupBox1.Controls.Add(Me.lbl_Nombre)
        Me.GroupBox1.Controls.Add(Me.lbl_Localidad)
        Me.GroupBox1.Controls.Add(Me.lbl_Direccion)
        Me.GroupBox1.Controls.Add(Me.lbl_NumeroNota)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.lbl_Fecha)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lbl_Total)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(369, 249)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información de la nota de crédito"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.SistemaCinderella.My.Resources.Recursos.Desconectado
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(288, 203)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 40)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Cerrar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lbl_Cuit
        '
        Me.lbl_Cuit.AutoSize = True
        Me.lbl_Cuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Cuit.Location = New System.Drawing.Point(145, 210)
        Me.lbl_Cuit.Name = "lbl_Cuit"
        Me.lbl_Cuit.Size = New System.Drawing.Size(64, 15)
        Me.lbl_Cuit.TabIndex = 38
        Me.lbl_Cuit.Text = "EFECTIVO"
        '
        'lbl_Condicion
        '
        Me.lbl_Condicion.AutoSize = True
        Me.lbl_Condicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Condicion.Location = New System.Drawing.Point(145, 98)
        Me.lbl_Condicion.Name = "lbl_Condicion"
        Me.lbl_Condicion.Size = New System.Drawing.Size(64, 15)
        Me.lbl_Condicion.TabIndex = 37
        Me.lbl_Condicion.Text = "EFECTIVO"
        '
        'lbl_Nombre
        '
        Me.lbl_Nombre.AutoSize = True
        Me.lbl_Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Nombre.Location = New System.Drawing.Point(145, 126)
        Me.lbl_Nombre.Name = "lbl_Nombre"
        Me.lbl_Nombre.Size = New System.Drawing.Size(64, 15)
        Me.lbl_Nombre.TabIndex = 36
        Me.lbl_Nombre.Text = "EFECTIVO"
        '
        'lbl_Localidad
        '
        Me.lbl_Localidad.AutoSize = True
        Me.lbl_Localidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Localidad.Location = New System.Drawing.Point(145, 182)
        Me.lbl_Localidad.Name = "lbl_Localidad"
        Me.lbl_Localidad.Size = New System.Drawing.Size(64, 15)
        Me.lbl_Localidad.TabIndex = 35
        Me.lbl_Localidad.Text = "EFECTIVO"
        '
        'lbl_Direccion
        '
        Me.lbl_Direccion.AutoSize = True
        Me.lbl_Direccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Direccion.Location = New System.Drawing.Point(145, 154)
        Me.lbl_Direccion.Name = "lbl_Direccion"
        Me.lbl_Direccion.Size = New System.Drawing.Size(64, 15)
        Me.lbl_Direccion.TabIndex = 34
        Me.lbl_Direccion.Text = "EFECTIVO"
        '
        'lbl_NumeroNota
        '
        Me.lbl_NumeroNota.AutoSize = True
        Me.lbl_NumeroNota.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NumeroNota.Location = New System.Drawing.Point(145, 70)
        Me.lbl_NumeroNota.Name = "lbl_NumeroNota"
        Me.lbl_NumeroNota.Size = New System.Drawing.Size(64, 15)
        Me.lbl_NumeroNota.TabIndex = 33
        Me.lbl_NumeroNota.Text = "EFECTIVO"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(17, 72)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 13)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Número de Nota"
        '
        'lbl_Fecha
        '
        Me.lbl_Fecha.AutoSize = True
        Me.lbl_Fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Fecha.Location = New System.Drawing.Point(145, 16)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(69, 15)
        Me.lbl_Fecha.TabIndex = 31
        Me.lbl_Fecha.Text = "04/05/2012"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 18)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 13)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Fecha / Hora"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 212)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "CUIT"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 184)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Localidad"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 156)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Dirección"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Nombre y Apellido"
        '
        'lbl_Total
        '
        Me.lbl_Total.AutoSize = True
        Me.lbl_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Total.Location = New System.Drawing.Point(145, 41)
        Me.lbl_Total.Name = "lbl_Total"
        Me.lbl_Total.Size = New System.Drawing.Size(73, 16)
        Me.lbl_Total.TabIndex = 23
        Me.lbl_Total.Text = "$ 120.00.-"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 100)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Condición de IVA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 44)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Total"
        '
        'FrmVerNotaCredito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 272)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmVerNotaCredito"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle de Nota Crédito N° 15"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lbl_Cuit As System.Windows.Forms.Label
    Friend WithEvents lbl_Condicion As System.Windows.Forms.Label
    Friend WithEvents lbl_Nombre As System.Windows.Forms.Label
    Friend WithEvents lbl_Localidad As System.Windows.Forms.Label
    Friend WithEvents lbl_Direccion As System.Windows.Forms.Label
    Friend WithEvents lbl_NumeroNota As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lbl_Fecha As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbl_Total As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
