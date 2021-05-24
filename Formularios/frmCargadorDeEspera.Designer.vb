<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCargadorDeEspera
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCargadorDeEspera))
        Me.BarraProgreso = New System.Windows.Forms.ProgressBar()
        Me.lbl_Descripcion = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BarraProgreso
        '
        Me.BarraProgreso.Location = New System.Drawing.Point(14, 26)
        Me.BarraProgreso.Margin = New System.Windows.Forms.Padding(5)
        Me.BarraProgreso.MarqueeAnimationSpeed = 200
        Me.BarraProgreso.Name = "BarraProgreso"
        Me.BarraProgreso.Size = New System.Drawing.Size(455, 35)
        Me.BarraProgreso.TabIndex = 1
        '
        'lbl_Descripcion
        '
        Me.lbl_Descripcion.AutoSize = True
        Me.lbl_Descripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Descripcion.Location = New System.Drawing.Point(12, 9)
        Me.lbl_Descripcion.Name = "lbl_Descripcion"
        Me.lbl_Descripcion.Size = New System.Drawing.Size(153, 16)
        Me.lbl_Descripcion.TabIndex = 2
        Me.lbl_Descripcion.Text = "Cargando los ingresos..."
        '
        'frmCargadorDeEspera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 76)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbl_Descripcion)
        Me.Controls.Add(Me.BarraProgreso)
        Me.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCargadorDeEspera"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cargando..."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BarraProgreso As System.Windows.Forms.ProgressBar
    Friend WithEvents lbl_Descripcion As System.Windows.Forms.Label
End Class
