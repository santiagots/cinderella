<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPagarCuentaCorriente
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPagarCuentaCorriente))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Cb_Proveedores = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_Fecha = New System.Windows.Forms.DateTimePicker()
        Me.Btn_Volver = New System.Windows.Forms.Button()
        Me.Btn_Pagar = New System.Windows.Forms.Button()
        Me.txt_Monto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ErrorPago = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Cb_Sucursales = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorPago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Cb_Sucursales)
        Me.GroupBox1.Controls.Add(Me.Cb_Proveedores)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_Fecha)
        Me.GroupBox1.Controls.Add(Me.Btn_Volver)
        Me.GroupBox1.Controls.Add(Me.Btn_Pagar)
        Me.GroupBox1.Controls.Add(Me.txt_Monto)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(312, 260)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Completa el formulario de pago."
        '
        'Cb_Proveedores
        '
        Me.Cb_Proveedores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cb_Proveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Proveedores.FormattingEnabled = True
        Me.Cb_Proveedores.Location = New System.Drawing.Point(121, 63)
        Me.Cb_Proveedores.Name = "Cb_Proveedores"
        Me.Cb_Proveedores.Size = New System.Drawing.Size(183, 23)
        Me.Cb_Proveedores.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 15)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Proveedor :"
        '
        'txt_Fecha
        '
        Me.txt_Fecha.Location = New System.Drawing.Point(121, 103)
        Me.txt_Fecha.Name = "txt_Fecha"
        Me.txt_Fecha.Size = New System.Drawing.Size(183, 21)
        Me.txt_Fecha.TabIndex = 3
        '
        'Btn_Volver
        '
        Me.Btn_Volver.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_Volver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Volver.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Volver.Image = Global.SistemaCinderella.My.Resources.Recursos.desconectado_32
        Me.Btn_Volver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Volver.Location = New System.Drawing.Point(10, 200)
        Me.Btn_Volver.Name = "Btn_Volver"
        Me.Btn_Volver.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Volver.TabIndex = 5
        Me.Btn_Volver.Text = "Cancelar"
        Me.Btn_Volver.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Volver.UseVisualStyleBackColor = True
        '
        'Btn_Pagar
        '
        Me.Btn_Pagar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Pagar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Pagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Pagar.Image = Global.SistemaCinderella.My.Resources.Recursos.Conectado_32
        Me.Btn_Pagar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Pagar.Location = New System.Drawing.Point(204, 200)
        Me.Btn_Pagar.Name = "Btn_Pagar"
        Me.Btn_Pagar.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Pagar.TabIndex = 6
        Me.Btn_Pagar.Text = "Pagar"
        Me.Btn_Pagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Pagar.UseVisualStyleBackColor = True
        '
        'txt_Monto
        '
        Me.txt_Monto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Monto.Location = New System.Drawing.Point(121, 141)
        Me.txt_Monto.Name = "txt_Monto"
        Me.txt_Monto.Size = New System.Drawing.Size(183, 21)
        Me.txt_Monto.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Monto a Pagar :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(7, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Fecha :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sucursal :"
        '
        'ErrorPago
        '
        Me.ErrorPago.BlinkRate = 200
        Me.ErrorPago.ContainerControl = Me
        '
        'Cb_Sucursales
        '
        Me.Cb_Sucursales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cb_Sucursales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Sucursales.FormattingEnabled = True
        Me.Cb_Sucursales.Location = New System.Drawing.Point(121, 30)
        Me.Cb_Sucursales.Name = "Cb_Sucursales"
        Me.Cb_Sucursales.Size = New System.Drawing.Size(183, 23)
        Me.Cb_Sucursales.TabIndex = 13
        '
        'frmPagarCuentaCorriente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 272)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPagarCuentaCorriente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pagar Cuenta Corriente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorPago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_Pagar As System.Windows.Forms.Button
    Friend WithEvents txt_Monto As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Btn_Volver As System.Windows.Forms.Button
    Friend WithEvents Cb_Proveedores As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_Fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents ErrorPago As System.Windows.Forms.ErrorProvider
    Friend WithEvents Cb_Sucursales As System.Windows.Forms.ComboBox
End Class
