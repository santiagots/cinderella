<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMailNuevo
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMailNuevo))
        Me.txt_Mensaje = New System.Windows.Forms.TextBox()
        Me.txt_Asunto = New System.Windows.Forms.TextBox()
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.Btn_Enviar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cb_Usuarios = New System.Windows.Forms.ComboBox()
        Me.Gb_Mail = New System.Windows.Forms.GroupBox()
        Me.ErrorMsg = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Gb_Mail.SuspendLayout()
        CType(Me.ErrorMsg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_Mensaje
        '
        Me.txt_Mensaje.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Mensaje.Location = New System.Drawing.Point(120, 106)
        Me.txt_Mensaje.Multiline = True
        Me.txt_Mensaje.Name = "txt_Mensaje"
        Me.txt_Mensaje.Size = New System.Drawing.Size(460, 210)
        Me.txt_Mensaje.TabIndex = 3
        '
        'txt_Asunto
        '
        Me.txt_Asunto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Asunto.Location = New System.Drawing.Point(120, 76)
        Me.txt_Asunto.Name = "txt_Asunto"
        Me.txt_Asunto.Size = New System.Drawing.Size(460, 21)
        Me.txt_Asunto.TabIndex = 2
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Cancelar.Image = Global.SistemaCinderella.My.Resources.Recursos.desconectado_32
        Me.Btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Cancelar.Location = New System.Drawing.Point(344, 322)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Cancelar.TabIndex = 4
        Me.Btn_Cancelar.Text = "Cerrar"
        Me.Btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Cancelar.UseVisualStyleBackColor = True
        '
        'Btn_Enviar
        '
        Me.Btn_Enviar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Enviar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Enviar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Enviar.Image = Global.SistemaCinderella.My.Resources.Recursos.Mail_Nuevo
        Me.Btn_Enviar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Enviar.Location = New System.Drawing.Point(450, 322)
        Me.Btn_Enviar.Name = "Btn_Enviar"
        Me.Btn_Enviar.Size = New System.Drawing.Size(130, 40)
        Me.Btn_Enviar.TabIndex = 5
        Me.Btn_Enviar.Text = "Enviar"
        Me.Btn_Enviar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Enviar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Destinatario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Asunto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Mensaje"
        '
        'cb_Usuarios
        '
        Me.cb_Usuarios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_Usuarios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_Usuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Usuarios.FormattingEnabled = True
        Me.cb_Usuarios.Location = New System.Drawing.Point(120, 45)
        Me.cb_Usuarios.Name = "cb_Usuarios"
        Me.cb_Usuarios.Size = New System.Drawing.Size(460, 23)
        Me.cb_Usuarios.TabIndex = 1
        '
        'Gb_Mail
        '
        Me.Gb_Mail.Controls.Add(Me.Btn_Enviar)
        Me.Gb_Mail.Controls.Add(Me.cb_Usuarios)
        Me.Gb_Mail.Controls.Add(Me.txt_Mensaje)
        Me.Gb_Mail.Controls.Add(Me.txt_Asunto)
        Me.Gb_Mail.Controls.Add(Me.Label3)
        Me.Gb_Mail.Controls.Add(Me.Btn_Cancelar)
        Me.Gb_Mail.Controls.Add(Me.Label2)
        Me.Gb_Mail.Controls.Add(Me.Label1)
        Me.Gb_Mail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Gb_Mail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gb_Mail.Location = New System.Drawing.Point(0, 0)
        Me.Gb_Mail.Name = "Gb_Mail"
        Me.Gb_Mail.Size = New System.Drawing.Size(594, 372)
        Me.Gb_Mail.TabIndex = 9
        Me.Gb_Mail.TabStop = False
        Me.Gb_Mail.Text = "Envíe un nuevo mensaje a usuarios del sistema."
        '
        'ErrorMsg
        '
        Me.ErrorMsg.BlinkRate = 200
        Me.ErrorMsg.ContainerControl = Me
        '
        'frmMailNuevo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 372)
        Me.Controls.Add(Me.Gb_Mail)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMailNuevo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Centro de Mensajes | Nuevo Mensaje"
        Me.Gb_Mail.ResumeLayout(False)
        Me.Gb_Mail.PerformLayout()
        CType(Me.ErrorMsg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_Mensaje As System.Windows.Forms.TextBox
    Friend WithEvents txt_Asunto As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents Btn_Enviar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cb_Usuarios As System.Windows.Forms.ComboBox
    Friend WithEvents Gb_Mail As System.Windows.Forms.GroupBox
    Friend WithEvents ErrorMsg As System.Windows.Forms.ErrorProvider
End Class
