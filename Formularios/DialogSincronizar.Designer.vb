<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DialogSincronizar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DialogSincronizar))
        Me.lblConexion = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_Aceptar = New System.Windows.Forms.Button()
        Me.btn_Posponer = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblConexion
        '
        Me.lblConexion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConexion.Location = New System.Drawing.Point(141, 36)
        Me.lblConexion.Name = "lblConexion"
        Me.lblConexion.Size = New System.Drawing.Size(274, 52)
        Me.lblConexion.TabIndex = 6
        Me.lblConexion.Text = "Se requiere la sincronización de datos. ¿Desea realizarlo ahora?"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SistemaCinderella.My.Resources.Recursos.Sync
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(143, 138)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'btn_Aceptar
        '
        Me.btn_Aceptar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_Aceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Aceptar.Image = Global.SistemaCinderella.My.Resources.Recursos.Conectado_32
        Me.btn_Aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Aceptar.Location = New System.Drawing.Point(304, 110)
        Me.btn_Aceptar.Name = "btn_Aceptar"
        Me.btn_Aceptar.Size = New System.Drawing.Size(100, 40)
        Me.btn_Aceptar.TabIndex = 5
        Me.btn_Aceptar.Text = "Aceptar"
        Me.btn_Aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_Posponer
        '
        Me.btn_Posponer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_Posponer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Posponer.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Posponer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Posponer.Image = Global.SistemaCinderella.My.Resources.Recursos.desconectado_32
        Me.btn_Posponer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Posponer.Location = New System.Drawing.Point(198, 110)
        Me.btn_Posponer.Name = "btn_Posponer"
        Me.btn_Posponer.Size = New System.Drawing.Size(100, 40)
        Me.btn_Posponer.TabIndex = 8
        Me.btn_Posponer.Text = "Posponer"
        Me.btn_Posponer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DialogSincronizar
        '
        Me.AcceptButton = Me.btn_Aceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_Posponer
        Me.ClientSize = New System.Drawing.Size(415, 156)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_Aceptar)
        Me.Controls.Add(Me.btn_Posponer)
        Me.Controls.Add(Me.lblConexion)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DialogSincronizar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sincronización de Bases de Datos"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblConexion As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_Aceptar As Button
    Friend WithEvents btn_Posponer As Button
End Class
