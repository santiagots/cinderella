<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMailVisor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMailVisor))
        Me.Gb_Mail = New System.Windows.Forms.GroupBox()
        Me.cb_Usuarios = New System.Windows.Forms.ComboBox()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lbl_Fecha = New System.Windows.Forms.Label()
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.lblAsunto = New System.Windows.Forms.Label()
        Me.Btn_Responder = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Btn_Cerrar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Gb_Mail.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gb_Mail
        '
        Me.Gb_Mail.Controls.Add(Me.cb_Usuarios)
        Me.Gb_Mail.Controls.Add(Me.lblFecha)
        Me.Gb_Mail.Controls.Add(Me.lbl_Fecha)
        Me.Gb_Mail.Controls.Add(Me.lblMensaje)
        Me.Gb_Mail.Controls.Add(Me.lblAsunto)
        Me.Gb_Mail.Controls.Add(Me.Btn_Responder)
        Me.Gb_Mail.Controls.Add(Me.Label3)
        Me.Gb_Mail.Controls.Add(Me.Btn_Cerrar)
        Me.Gb_Mail.Controls.Add(Me.Label2)
        Me.Gb_Mail.Controls.Add(Me.Label1)
        Me.Gb_Mail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Gb_Mail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gb_Mail.Location = New System.Drawing.Point(0, 0)
        Me.Gb_Mail.Name = "Gb_Mail"
        Me.Gb_Mail.Size = New System.Drawing.Size(594, 372)
        Me.Gb_Mail.TabIndex = 10
        Me.Gb_Mail.TabStop = False
        Me.Gb_Mail.Text = "Detalle del  mensaje recibido."
        '
        'cb_Usuarios
        '
        Me.cb_Usuarios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_Usuarios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_Usuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Usuarios.Enabled = False
        Me.cb_Usuarios.FormattingEnabled = True
        Me.cb_Usuarios.Location = New System.Drawing.Point(100, 45)
        Me.cb_Usuarios.Name = "cb_Usuarios"
        Me.cb_Usuarios.Size = New System.Drawing.Size(482, 23)
        Me.cb_Usuarios.TabIndex = 12
        '
        'lblFecha
        '
        Me.lblFecha.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFecha.Location = New System.Drawing.Point(100, 106)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(482, 23)
        Me.lblFecha.TabIndex = 11
        Me.lblFecha.Text = "Label6"
        '
        'lbl_Fecha
        '
        Me.lbl_Fecha.AutoSize = True
        Me.lbl_Fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Fecha.Location = New System.Drawing.Point(10, 106)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(46, 15)
        Me.lbl_Fecha.TabIndex = 10
        Me.lbl_Fecha.Text = "Fecha"
        '
        'lblMensaje
        '
        Me.lblMensaje.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMensaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMensaje.Location = New System.Drawing.Point(100, 135)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(482, 182)
        Me.lblMensaje.TabIndex = 9
        Me.lblMensaje.Text = "Label6"
        '
        'lblAsunto
        '
        Me.lblAsunto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAsunto.Location = New System.Drawing.Point(100, 77)
        Me.lblAsunto.Name = "lblAsunto"
        Me.lblAsunto.Size = New System.Drawing.Size(482, 23)
        Me.lblAsunto.TabIndex = 8
        Me.lblAsunto.Text = "Label5"
        '
        'Btn_Responder
        '
        Me.Btn_Responder.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Responder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Responder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Responder.Image = Global.SistemaCinderella.My.Resources.Recursos.Mail_Inbox
        Me.Btn_Responder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Responder.Location = New System.Drawing.Point(442, 324)
        Me.Btn_Responder.Name = "Btn_Responder"
        Me.Btn_Responder.Size = New System.Drawing.Size(140, 40)
        Me.Btn_Responder.TabIndex = 5
        Me.Btn_Responder.Text = "Responder"
        Me.Btn_Responder.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Responder.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Mensaje"
        '
        'Btn_Cerrar
        '
        Me.Btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Cerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Cerrar.Image = Global.SistemaCinderella.My.Resources.Recursos.desconectado_32
        Me.Btn_Cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Cerrar.Location = New System.Drawing.Point(336, 324)
        Me.Btn_Cerrar.Name = "Btn_Cerrar"
        Me.Btn_Cerrar.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Cerrar.TabIndex = 4
        Me.Btn_Cerrar.Text = "Cerrar"
        Me.Btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Cerrar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Asunto"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Usuario"
        '
        'frmMailVisor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 372)
        Me.Controls.Add(Me.Gb_Mail)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMailVisor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Centro de Mensajes | Visor de Mensajes"
        Me.Gb_Mail.ResumeLayout(False)
        Me.Gb_Mail.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Gb_Mail As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_Responder As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblMensaje As System.Windows.Forms.Label
    Friend WithEvents lblAsunto As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents lbl_Fecha As System.Windows.Forms.Label
    Friend WithEvents cb_Usuarios As System.Windows.Forms.ComboBox
End Class
