<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportePrecios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportePrecios))
        Me.CrViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CrViewer
        '
        Me.CrViewer.ActiveViewIndex = -1
        Me.CrViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrViewer.Location = New System.Drawing.Point(0, 0)
        Me.CrViewer.Name = "CrViewer"
        Me.CrViewer.ShowCloseButton = False
        Me.CrViewer.ShowGroupTreeButton = False
        Me.CrViewer.ShowParameterPanelButton = False
        Me.CrViewer.ShowTextSearchButton = False
        Me.CrViewer.Size = New System.Drawing.Size(794, 572)
        Me.CrViewer.TabIndex = 1
        Me.CrViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmReportePrecios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 572)
        Me.Controls.Add(Me.CrViewer)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmReportePrecios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Precios"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
