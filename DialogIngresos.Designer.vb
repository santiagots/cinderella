<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DialogIngresos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DialogIngresos))
        Me.BtnPagar = New System.Windows.Forms.Button()
        Me.BtnCuentaCorriente = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolDialog = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'BtnPagar
        '
        Me.BtnPagar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPagar.Image = Global.SistemaCinderella.My.Resources.Recursos.Sueldos
        Me.BtnPagar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPagar.Location = New System.Drawing.Point(12, 44)
        Me.BtnPagar.Name = "BtnPagar"
        Me.BtnPagar.Size = New System.Drawing.Size(130, 40)
        Me.BtnPagar.TabIndex = 2
        Me.BtnPagar.Text = "Pagar Ahora"
        Me.BtnPagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolDialog.SetToolTip(Me.BtnPagar, "Al hacer click aquí la mercadería ingresada podrá ser abonada de manera parcial o" & _
                " total." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Dicho pago quedará registrado en la cuenta corriente del proveedor.")
        Me.BtnPagar.UseVisualStyleBackColor = True
        '
        'BtnCuentaCorriente
        '
        Me.BtnCuentaCorriente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCuentaCorriente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCuentaCorriente.Image = Global.SistemaCinderella.My.Resources.Recursos.Recibo_32
        Me.BtnCuentaCorriente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCuentaCorriente.Location = New System.Drawing.Point(168, 44)
        Me.BtnCuentaCorriente.Name = "BtnCuentaCorriente"
        Me.BtnCuentaCorriente.Size = New System.Drawing.Size(145, 40)
        Me.BtnCuentaCorriente.TabIndex = 3
        Me.BtnCuentaCorriente.Text = "Cuenta Corriente"
        Me.BtnCuentaCorriente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolDialog.SetToolTip(Me.BtnCuentaCorriente, "Al hacer click aquí la mercadería ingresada quedará registrada en la cuenta corri" & _
                "ente del proveedor.")
        Me.BtnCuentaCorriente.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(301, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "¿Qué desea hacer con la mercadería ingresada?"
        '
        'ToolDialog
        '
        Me.ToolDialog.IsBalloon = True
        Me.ToolDialog.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolDialog.ToolTipTitle = "Ayuda"
        '
        'DialogIngresos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(325, 96)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnCuentaCorriente)
        Me.Controls.Add(Me.BtnPagar)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DialogIngresos"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnPagar As System.Windows.Forms.Button
    Friend WithEvents BtnCuentaCorriente As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolDialog As System.Windows.Forms.ToolTip
End Class
