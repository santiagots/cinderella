<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDatosClienteMinorista
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDatosClienteMinorista))
        Me.Gb_Etiquetas = New System.Windows.Forms.GroupBox()
        Me.lbl_ProductoNombre = New System.Windows.Forms.Label()
        Me.txt_Apellido = New System.Windows.Forms.TextBox()
        Me.lbl_ProductoCodigo = New System.Windows.Forms.Label()
        Me.txt_Nombre = New System.Windows.Forms.TextBox()
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.Btn_Finalizar = New System.Windows.Forms.Button()
        Me.Btn_BuscarConsumidorFinal = New System.Windows.Forms.Button()
        Me.Gb_Etiquetas.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gb_Etiquetas
        '
        Me.Gb_Etiquetas.Controls.Add(Me.Btn_BuscarConsumidorFinal)
        Me.Gb_Etiquetas.Controls.Add(Me.txt_Nombre)
        Me.Gb_Etiquetas.Controls.Add(Me.lbl_ProductoNombre)
        Me.Gb_Etiquetas.Controls.Add(Me.txt_Apellido)
        Me.Gb_Etiquetas.Controls.Add(Me.lbl_ProductoCodigo)
        Me.Gb_Etiquetas.Location = New System.Drawing.Point(12, 12)
        Me.Gb_Etiquetas.Name = "Gb_Etiquetas"
        Me.Gb_Etiquetas.Size = New System.Drawing.Size(411, 101)
        Me.Gb_Etiquetas.TabIndex = 2
        Me.Gb_Etiquetas.TabStop = False
        Me.Gb_Etiquetas.Text = "Datos Cliente Minorista"
        '
        'lbl_ProductoNombre
        '
        Me.lbl_ProductoNombre.AutoSize = True
        Me.lbl_ProductoNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ProductoNombre.Location = New System.Drawing.Point(6, 62)
        Me.lbl_ProductoNombre.Name = "lbl_ProductoNombre"
        Me.lbl_ProductoNombre.Size = New System.Drawing.Size(71, 15)
        Me.lbl_ProductoNombre.TabIndex = 15
        Me.lbl_ProductoNombre.Text = "Nombre (*):"
        '
        'txt_Apellido
        '
        Me.txt_Apellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Apellido.Location = New System.Drawing.Point(92, 29)
        Me.txt_Apellido.Name = "txt_Apellido"
        Me.txt_Apellido.Size = New System.Drawing.Size(260, 21)
        Me.txt_Apellido.TabIndex = 1
        '
        'lbl_ProductoCodigo
        '
        Me.lbl_ProductoCodigo.AutoSize = True
        Me.lbl_ProductoCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ProductoCodigo.Location = New System.Drawing.Point(6, 32)
        Me.lbl_ProductoCodigo.Name = "lbl_ProductoCodigo"
        Me.lbl_ProductoCodigo.Size = New System.Drawing.Size(70, 15)
        Me.lbl_ProductoCodigo.TabIndex = 3
        Me.lbl_ProductoCodigo.Text = "Apellido (*):"
        '
        'txt_Nombre
        '
        Me.txt_Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Nombre.Location = New System.Drawing.Point(92, 59)
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.Size = New System.Drawing.Size(260, 21)
        Me.txt_Nombre.TabIndex = 16
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Cancelar.Image = Global.SistemaCinderella.My.Resources.Recursos.desconectado_32
        Me.Btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Cancelar.Location = New System.Drawing.Point(12, 123)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Cancelar.TabIndex = 18
        Me.Btn_Cancelar.Text = "Cancelar"
        Me.Btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Cancelar.UseVisualStyleBackColor = True
        '
        'Btn_Finalizar
        '
        Me.Btn_Finalizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Finalizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Finalizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Finalizar.Image = Global.SistemaCinderella.My.Resources.Recursos.Conectado_32
        Me.Btn_Finalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Finalizar.Location = New System.Drawing.Point(323, 123)
        Me.Btn_Finalizar.Name = "Btn_Finalizar"
        Me.Btn_Finalizar.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Finalizar.TabIndex = 19
        Me.Btn_Finalizar.Text = "Finalizar"
        Me.Btn_Finalizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Finalizar.UseVisualStyleBackColor = True
        '
        'Btn_BuscarConsumidorFinal
        '
        Me.Btn_BuscarConsumidorFinal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_BuscarConsumidorFinal.FlatAppearance.BorderSize = 0
        Me.Btn_BuscarConsumidorFinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_BuscarConsumidorFinal.Image = Global.SistemaCinderella.My.Resources.Recursos.IconoBuscar32
        Me.Btn_BuscarConsumidorFinal.Location = New System.Drawing.Point(358, 19)
        Me.Btn_BuscarConsumidorFinal.Name = "Btn_BuscarConsumidorFinal"
        Me.Btn_BuscarConsumidorFinal.Size = New System.Drawing.Size(37, 37)
        Me.Btn_BuscarConsumidorFinal.TabIndex = 17
        Me.Btn_BuscarConsumidorFinal.UseVisualStyleBackColor = True
        '
        'frmDatosClienteMinorista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 175)
        Me.ControlBox = False
        Me.Controls.Add(Me.Btn_Cancelar)
        Me.Controls.Add(Me.Btn_Finalizar)
        Me.Controls.Add(Me.Gb_Etiquetas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDatosClienteMinorista"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos Cliente Minorista"
        Me.Gb_Etiquetas.ResumeLayout(False)
        Me.Gb_Etiquetas.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Gb_Etiquetas As GroupBox
    Friend WithEvents txt_Nombre As TextBox
    Friend WithEvents lbl_ProductoNombre As Label
    Friend WithEvents txt_Apellido As TextBox
    Friend WithEvents lbl_ProductoCodigo As Label
    Friend WithEvents Btn_Cancelar As Button
    Friend WithEvents Btn_Finalizar As Button
    Friend WithEvents Btn_BuscarConsumidorFinal As Button
End Class
