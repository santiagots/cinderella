<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChequeAlta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChequeAlta))
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.Btn_Salir = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.ucChequeDetalle = New SistemaCinderella.ChequeDetalle()
        Me.GroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox
        '
        Me.GroupBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox.Controls.Add(Me.ucChequeDetalle)
        Me.GroupBox.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(491, 386)
        Me.GroupBox.TabIndex = 34
        Me.GroupBox.TabStop = False
        Me.GroupBox.Text = "Alta de cheque en la sucursal"
        '
        'Btn_Salir
        '
        Me.Btn_Salir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Salir.Image = Global.SistemaCinderella.My.Resources.Recursos.desconectado_32
        Me.Btn_Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Salir.Location = New System.Drawing.Point(297, 405)
        Me.Btn_Salir.Name = "Btn_Salir"
        Me.Btn_Salir.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Salir.TabIndex = 15
        Me.Btn_Salir.Text = "Salir"
        Me.Btn_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Salir.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Image = Global.SistemaCinderella.My.Resources.Recursos.Agregar_24
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.Location = New System.Drawing.Point(403, 405)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(100, 40)
        Me.btnAceptar.TabIndex = 16
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'ucChequeDetalle
        '
        Me.ucChequeDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ucChequeDetalle.Location = New System.Drawing.Point(3, 16)
        Me.ucChequeDetalle.Name = "ucChequeDetalle"
        Me.ucChequeDetalle.Size = New System.Drawing.Size(485, 367)
        Me.ucChequeDetalle.TabIndex = 0
        '
        'frmChequesAlta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 457)
        Me.Controls.Add(Me.Btn_Salir)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.GroupBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmChequesAlta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta de Cheques"
        Me.GroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_Salir As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents ucChequeDetalle As ChequeDetalle
End Class
