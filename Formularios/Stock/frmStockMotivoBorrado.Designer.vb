<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockMotivoBorrado
    Inherits Comun

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStockMotivoBorrado))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lbl_Usuario2 = New System.Windows.Forms.Label()
        Me.FrmStockMotivoViewModelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lbl_Fecha2 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_Motivo = New System.Windows.Forms.TextBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        CType(Me.FrmStockMotivoViewModelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lbl_Usuario2)
        Me.GroupBox3.Controls.Add(Me.lbl_Fecha2)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.txt_Motivo)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 7)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(349, 173)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        '
        'lbl_Usuario2
        '
        Me.lbl_Usuario2.AutoSize = True
        Me.lbl_Usuario2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmStockMotivoViewModelBindingSource, "UsuarioNombre", True))
        Me.lbl_Usuario2.Location = New System.Drawing.Point(87, 48)
        Me.lbl_Usuario2.Name = "lbl_Usuario2"
        Me.lbl_Usuario2.Size = New System.Drawing.Size(42, 15)
        Me.lbl_Usuario2.TabIndex = 5
        Me.lbl_Usuario2.Text = "- - - - - "
        '
        'FrmStockMotivoViewModelBindingSource
        '
        Me.FrmStockMotivoViewModelBindingSource.DataSource = GetType(SistemaCinderella.Formularios.Stock.frmStockMotivoViewModel)
        '
        'lbl_Fecha2
        '
        Me.lbl_Fecha2.AutoSize = True
        Me.lbl_Fecha2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmStockMotivoViewModelBindingSource, "Fecha", True))
        Me.lbl_Fecha2.Location = New System.Drawing.Point(87, 20)
        Me.lbl_Fecha2.Name = "lbl_Fecha2"
        Me.lbl_Fecha2.Size = New System.Drawing.Size(39, 15)
        Me.lbl_Fecha2.TabIndex = 4
        Me.lbl_Fecha2.Text = "- - - - -"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(7, 20)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 15)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Fecha"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(7, 48)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(50, 15)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Usuario"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(7, 77)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(59, 15)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Motivo (*)"
        '
        'txt_Motivo
        '
        Me.txt_Motivo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmStockMotivoViewModelBindingSource, "Motivo", True))
        Me.txt_Motivo.Location = New System.Drawing.Point(91, 78)
        Me.txt_Motivo.Multiline = True
        Me.txt_Motivo.Name = "txt_Motivo"
        Me.txt_Motivo.Size = New System.Drawing.Size(244, 78)
        Me.txt_Motivo.TabIndex = 0
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Image = Global.SistemaCinderella.My.Resources.Recursos.Agregar_24
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.Location = New System.Drawing.Point(244, 192)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(117, 46)
        Me.btnAceptar.TabIndex = 2
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = Global.SistemaCinderella.My.Resources.Recursos.desconectado_32
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(12, 192)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(117, 46)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'frmStockMotivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 252)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStockMotivo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Confirmación de la eliminación de stock"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.FrmStockMotivoViewModelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Usuario2 As System.Windows.Forms.Label
    Friend WithEvents lbl_Fecha2 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txt_Motivo As System.Windows.Forms.TextBox
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents FrmStockMotivoViewModelBindingSource As BindingSource
End Class
