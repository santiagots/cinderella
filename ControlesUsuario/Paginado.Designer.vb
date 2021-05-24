<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Paginado
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnPaginaInical = New System.Windows.Forms.ToolStripButton()
        Me.btnPaginaAnterior = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.lbTotalPaginas = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnPaginaSiguiente = New System.Windows.Forms.ToolStripButton()
        Me.btnPaginaFinal = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPaginaInical, Me.btnPaginaAnterior, Me.ToolStripSeparator1, Me.lbTotalPaginas, Me.ToolStripSeparator2, Me.btnPaginaSiguiente, Me.btnPaginaFinal})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStrip1.Size = New System.Drawing.Size(209, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnPaginaInical
        '
        Me.btnPaginaInical.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPaginaInical.Image = Global.SistemaCinderella.My.Resources.Recursos.NavigatorFirstItem
        Me.btnPaginaInical.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPaginaInical.Name = "btnPaginaInical"
        Me.btnPaginaInical.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnPaginaInical.Size = New System.Drawing.Size(23, 22)
        Me.btnPaginaInical.Text = "ToolStripButton1"
        Me.btnPaginaInical.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnPaginaAnterior
        '
        Me.btnPaginaAnterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPaginaAnterior.Image = Global.SistemaCinderella.My.Resources.Recursos.NavigatorPreviousItem
        Me.btnPaginaAnterior.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPaginaAnterior.Name = "btnPaginaAnterior"
        Me.btnPaginaAnterior.Size = New System.Drawing.Size(23, 22)
        Me.btnPaginaAnterior.Text = "ToolStripButton2"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'lbTotalPaginas
        '
        Me.lbTotalPaginas.Name = "lbTotalPaginas"
        Me.lbTotalPaginas.Size = New System.Drawing.Size(54, 22)
        Me.lbTotalPaginas.Text = "{0} de {1}"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnPaginaSiguiente
        '
        Me.btnPaginaSiguiente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPaginaSiguiente.Image = Global.SistemaCinderella.My.Resources.Recursos.NavigatorNextItem
        Me.btnPaginaSiguiente.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPaginaSiguiente.Name = "btnPaginaSiguiente"
        Me.btnPaginaSiguiente.Size = New System.Drawing.Size(23, 22)
        Me.btnPaginaSiguiente.Text = "ToolStripButton4"
        '
        'btnPaginaFinal
        '
        Me.btnPaginaFinal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPaginaFinal.Image = Global.SistemaCinderella.My.Resources.Recursos.NavigatorLastItem
        Me.btnPaginaFinal.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPaginaFinal.Name = "btnPaginaFinal"
        Me.btnPaginaFinal.Size = New System.Drawing.Size(23, 22)
        Me.btnPaginaFinal.Text = "ToolStripButton5"
        '
        'Paginado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "Paginado"
        Me.Size = New System.Drawing.Size(209, 23)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnPaginaInical As ToolStripButton
    Friend WithEvents btnPaginaAnterior As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents lbTotalPaginas As ToolStripLabel
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents btnPaginaSiguiente As ToolStripButton
    Friend WithEvents btnPaginaFinal As ToolStripButton
End Class
