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
        Me.TableLayoutPanel11 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnProxima = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnInicio = New System.Windows.Forms.Button()
        Me.btnFin = New System.Windows.Forms.Button()
        Me.lblPaginas = New System.Windows.Forms.Label()
        Me.TableLayoutPanel11.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel11
        '
        Me.TableLayoutPanel11.ColumnCount = 5
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.55556!))
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel11.Controls.Add(Me.btnProxima, 3, 0)
        Me.TableLayoutPanel11.Controls.Add(Me.btnAnterior, 1, 0)
        Me.TableLayoutPanel11.Controls.Add(Me.btnInicio, 0, 0)
        Me.TableLayoutPanel11.Controls.Add(Me.btnFin, 4, 0)
        Me.TableLayoutPanel11.Controls.Add(Me.lblPaginas, 2, 0)
        Me.TableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel11.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel11.Name = "TableLayoutPanel11"
        Me.TableLayoutPanel11.RowCount = 1
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel11.Size = New System.Drawing.Size(642, 30)
        Me.TableLayoutPanel11.TabIndex = 4
        '
        'btnProxima
        '
        Me.btnProxima.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnProxima.Location = New System.Drawing.Point(501, 3)
        Me.btnProxima.Name = "btnProxima"
        Me.btnProxima.Size = New System.Drawing.Size(65, 23)
        Me.btnProxima.TabIndex = 4
        Me.btnProxima.Text = ">"
        Me.btnProxima.UseVisualStyleBackColor = True
        '
        'btnAnterior
        '
        Me.btnAnterior.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnAnterior.Location = New System.Drawing.Point(74, 3)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(65, 23)
        Me.btnAnterior.TabIndex = 2
        Me.btnAnterior.Text = "<"
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'btnInicio
        '
        Me.btnInicio.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnInicio.Location = New System.Drawing.Point(3, 3)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Size = New System.Drawing.Size(65, 23)
        Me.btnInicio.TabIndex = 1
        Me.btnInicio.Text = "<<"
        Me.btnInicio.UseVisualStyleBackColor = True
        '
        'btnFin
        '
        Me.btnFin.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnFin.Location = New System.Drawing.Point(572, 3)
        Me.btnFin.Name = "btnFin"
        Me.btnFin.Size = New System.Drawing.Size(67, 23)
        Me.btnFin.TabIndex = 0
        Me.btnFin.Text = ">>"
        Me.btnFin.UseVisualStyleBackColor = True
        '
        'lblPaginas
        '
        Me.lblPaginas.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPaginas.AutoSize = True
        Me.lblPaginas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaginas.Location = New System.Drawing.Point(145, 7)
        Me.lblPaginas.Name = "lblPaginas"
        Me.lblPaginas.Size = New System.Drawing.Size(350, 16)
        Me.lblPaginas.TabIndex = 5
        Me.lblPaginas.Text = "Página {0} de {1} "
        Me.lblPaginas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Paginado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel11)
        Me.Name = "Paginado"
        Me.Size = New System.Drawing.Size(642, 30)
        Me.TableLayoutPanel11.ResumeLayout(False)
        Me.TableLayoutPanel11.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel11 As TableLayoutPanel
    Friend WithEvents btnProxima As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnInicio As Button
    Friend WithEvents btnFin As Button
    Friend WithEvents lblPaginas As Label
End Class
