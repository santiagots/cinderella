<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReserva
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReserva))
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.Btn_Finalizar = New System.Windows.Forms.Button()
        Me.ReservaDetalle1 = New SistemaCinderella.ReservaDetalle()
        Me.SuspendLayout()
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Cancelar.Image = CType(resources.GetObject("Btn_Cancelar.Image"), System.Drawing.Image)
        Me.Btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Cancelar.Location = New System.Drawing.Point(693, 721)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Cancelar.TabIndex = 27
        Me.Btn_Cancelar.Text = "Cancelar"
        Me.Btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Cancelar.UseVisualStyleBackColor = True
        '
        'Btn_Finalizar
        '
        Me.Btn_Finalizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Finalizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Finalizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Finalizar.Image = CType(resources.GetObject("Btn_Finalizar.Image"), System.Drawing.Image)
        Me.Btn_Finalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Finalizar.Location = New System.Drawing.Point(799, 721)
        Me.Btn_Finalizar.Name = "Btn_Finalizar"
        Me.Btn_Finalizar.Size = New System.Drawing.Size(81, 40)
        Me.Btn_Finalizar.TabIndex = 28
        Me.Btn_Finalizar.Text = "Crear"
        Me.Btn_Finalizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Finalizar.UseVisualStyleBackColor = True
        '
        'ReservaDetalle1
        '
        Me.ReservaDetalle1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReservaDetalle1.Location = New System.Drawing.Point(12, 12)
        Me.ReservaDetalle1.Name = "ReservaDetalle1"
        Me.ReservaDetalle1.Size = New System.Drawing.Size(868, 703)
        Me.ReservaDetalle1.TabIndex = 0
        '
        'frmReserva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(892, 773)
        Me.Controls.Add(Me.Btn_Cancelar)
        Me.Controls.Add(Me.Btn_Finalizar)
        Me.Controls.Add(Me.ReservaDetalle1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmReserva"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reserva"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReservaDetalle1 As ReservaDetalle
    Friend WithEvents Btn_Cancelar As Button
    Friend WithEvents Btn_Finalizar As Button
End Class
