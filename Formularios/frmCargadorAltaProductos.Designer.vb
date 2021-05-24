<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCargadorAltaProductos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCargadorAltaProductos))
        Me.BarraProgreso = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'BarraProgreso
        '
        Me.BarraProgreso.Location = New System.Drawing.Point(15, 17)
        Me.BarraProgreso.Margin = New System.Windows.Forms.Padding(5)
        Me.BarraProgreso.MarqueeAnimationSpeed = 200
        Me.BarraProgreso.Name = "BarraProgreso"
        Me.BarraProgreso.Size = New System.Drawing.Size(455, 35)
        Me.BarraProgreso.TabIndex = 1
        '
        'frmCargadorAltaProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 66)
        Me.ControlBox = False
        Me.Controls.Add(Me.BarraProgreso)
        Me.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmCargadorAltaProductos"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "  Subiendo los productos... ésta operación puede tardar varios minutos..."
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BarraProgreso As System.Windows.Forms.ProgressBar
End Class
