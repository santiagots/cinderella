<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPagarMercaderia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPagarMercaderia))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Btn_Volver = New System.Windows.Forms.Button()
        Me.lbl_Cantidad = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Btn_Pagar = New System.Windows.Forms.Button()
        Me.txt_Monto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_Fecha = New System.Windows.Forms.Label()
        Me.lbl_MontoTotal = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_Proveedor = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ErrorPago = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolPago = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorPago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Btn_Volver)
        Me.GroupBox1.Controls.Add(Me.lbl_Cantidad)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Btn_Pagar)
        Me.GroupBox1.Controls.Add(Me.txt_Monto)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lbl_Fecha)
        Me.GroupBox1.Controls.Add(Me.lbl_MontoTotal)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lbl_Proveedor)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(310, 248)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Completa el formulario de pago."
        '
        'Btn_Volver
        '
        Me.Btn_Volver.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_Volver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Volver.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Volver.Image = Global.SistemaCinderella.My.Resources.Recursos.flecha_izq
        Me.Btn_Volver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Volver.Location = New System.Drawing.Point(9, 196)
        Me.Btn_Volver.Name = "Btn_Volver"
        Me.Btn_Volver.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Volver.TabIndex = 10
        Me.Btn_Volver.Text = "Volver"
        Me.Btn_Volver.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolPago.SetToolTip(Me.Btn_Volver, "Haz click aqui para volver a la pantalla de selección en caso que " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "desee pasar a" & _
                " cuenta corriente el ingreso de mercadería.")
        Me.Btn_Volver.UseVisualStyleBackColor = True
        '
        'lbl_Cantidad
        '
        Me.lbl_Cantidad.AutoSize = True
        Me.lbl_Cantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Cantidad.Location = New System.Drawing.Point(133, 93)
        Me.lbl_Cantidad.Name = "lbl_Cantidad"
        Me.lbl_Cantidad.Size = New System.Drawing.Size(14, 15)
        Me.lbl_Cantidad.TabIndex = 3
        Me.lbl_Cantidad.Text = "2"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Cant. de Prod. :"
        '
        'Btn_Pagar
        '
        Me.Btn_Pagar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Pagar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Pagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Pagar.Image = Global.SistemaCinderella.My.Resources.Recursos.Conectado_32
        Me.Btn_Pagar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Pagar.Location = New System.Drawing.Point(198, 196)
        Me.Btn_Pagar.Name = "Btn_Pagar"
        Me.Btn_Pagar.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Pagar.TabIndex = 7
        Me.Btn_Pagar.Text = "Pagar"
        Me.Btn_Pagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolPago.SetToolTip(Me.Btn_Pagar, "Haz click aquí si deseas pagar el ingreso de mercadería por el importe ingresado." & _
                " " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Recordá que podes abonar por el monto que desees.")
        Me.Btn_Pagar.UseVisualStyleBackColor = True
        '
        'txt_Monto
        '
        Me.txt_Monto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Monto.Location = New System.Drawing.Point(133, 150)
        Me.txt_Monto.Name = "txt_Monto"
        Me.txt_Monto.Size = New System.Drawing.Size(100, 21)
        Me.txt_Monto.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Monto a Pagar :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Fecha :"
        '
        'lbl_Fecha
        '
        Me.lbl_Fecha.AutoSize = True
        Me.lbl_Fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Fecha.Location = New System.Drawing.Point(133, 60)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(69, 15)
        Me.lbl_Fecha.TabIndex = 2
        Me.lbl_Fecha.Text = "10/10/1987"
        '
        'lbl_MontoTotal
        '
        Me.lbl_MontoTotal.AutoSize = True
        Me.lbl_MontoTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MontoTotal.Location = New System.Drawing.Point(133, 120)
        Me.lbl_MontoTotal.Name = "lbl_MontoTotal"
        Me.lbl_MontoTotal.Size = New System.Drawing.Size(45, 15)
        Me.lbl_MontoTotal.TabIndex = 4
        Me.lbl_MontoTotal.Text = "$ 100.-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Monto Total :"
        '
        'lbl_Proveedor
        '
        Me.lbl_Proveedor.AutoSize = True
        Me.lbl_Proveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Proveedor.Location = New System.Drawing.Point(133, 30)
        Me.lbl_Proveedor.Name = "lbl_Proveedor"
        Me.lbl_Proveedor.Size = New System.Drawing.Size(77, 15)
        Me.lbl_Proveedor.TabIndex = 1
        Me.lbl_Proveedor.Text = "ARAK MADU"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Proveedor :"
        '
        'ErrorPago
        '
        Me.ErrorPago.BlinkRate = 200
        Me.ErrorPago.ContainerControl = Me
        '
        'ToolPago
        '
        Me.ToolPago.IsBalloon = True
        Me.ToolPago.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolPago.ToolTipTitle = "Ayuda"
        '
        'frmPagarMercaderia
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
        Me.Name = "frmPagarMercaderia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pago de Mercadería Ingresada"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorPago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_Pagar As System.Windows.Forms.Button
    Friend WithEvents Btn_Volver As System.Windows.Forms.Button
    Friend WithEvents lbl_Cantidad As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_Monto As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbl_Fecha As System.Windows.Forms.Label
    Friend WithEvents lbl_MontoTotal As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbl_Proveedor As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ErrorPago As System.Windows.Forms.ErrorProvider
    Friend WithEvents ToolPago As System.Windows.Forms.ToolTip
End Class
