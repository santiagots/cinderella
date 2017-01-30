<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteNotaPedido
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReporteNotaPedido))
        Me.CrViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.ReporteNotaPedido1 = New SistemaCinderella.ReporteNotaPedidoMayorista()
        Me.SuspendLayout()
        '
        'CrViewer
        '
        Me.CrViewer.ActiveViewIndex = -1
        Me.CrViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrViewer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.CrViewer.Location = New System.Drawing.Point(0, 0)
        Me.CrViewer.Name = "CrViewer"
        Me.CrViewer.ShowCloseButton = False
        Me.CrViewer.ShowGroupTreeButton = False
        Me.CrViewer.ShowParameterPanelButton = False
        Me.CrViewer.ShowRefreshButton = False
        Me.CrViewer.ShowTextSearchButton = False
        Me.CrViewer.Size = New System.Drawing.Size(794, 572)
        Me.CrViewer.TabIndex = 0
        Me.CrViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmReporteNotaPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 572)
        Me.Controls.Add(Me.CrViewer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmReporteNotaPedido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Nota de Pedido"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents ReporteNotaPedido1 As ReporteNotaPedidoMayorista
End Class
