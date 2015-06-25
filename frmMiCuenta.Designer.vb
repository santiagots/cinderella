<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMiCuenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMiCuenta))
        Me.lbl_Nombre = New System.Windows.Forms.Label()
        Me.Usuario = New System.Windows.Forms.Label()
        Me.lbl_Apellido = New System.Windows.Forms.Label()
        Me.Nombre = New System.Windows.Forms.Label()
        Me.lbl_Mail = New System.Windows.Forms.Label()
        Me.lbl_Usuario = New System.Windows.Forms.Label()
        Me.GB_Usuario = New System.Windows.Forms.GroupBox()
        Me.Notificaciones = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Mensajes = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Fecha = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Mail = New System.Windows.Forms.Label()
        Me.Apellido = New System.Windows.Forms.Label()
        Me.GB_Usuario.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_Nombre
        '
        Me.lbl_Nombre.AutoSize = True
        Me.lbl_Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Nombre.Location = New System.Drawing.Point(6, 56)
        Me.lbl_Nombre.Name = "lbl_Nombre"
        Me.lbl_Nombre.Size = New System.Drawing.Size(67, 16)
        Me.lbl_Nombre.TabIndex = 0
        Me.lbl_Nombre.Text = "Nombre:"
        '
        'Usuario
        '
        Me.Usuario.AutoSize = True
        Me.Usuario.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Usuario.Location = New System.Drawing.Point(123, 28)
        Me.Usuario.Name = "Usuario"
        Me.Usuario.Size = New System.Drawing.Size(46, 15)
        Me.Usuario.TabIndex = 1
        Me.Usuario.Text = "Label2"
        '
        'lbl_Apellido
        '
        Me.lbl_Apellido.AutoSize = True
        Me.lbl_Apellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Apellido.Location = New System.Drawing.Point(6, 85)
        Me.lbl_Apellido.Name = "lbl_Apellido"
        Me.lbl_Apellido.Size = New System.Drawing.Size(70, 16)
        Me.lbl_Apellido.TabIndex = 2
        Me.lbl_Apellido.Text = "Apellido:"
        '
        'Nombre
        '
        Me.Nombre.AutoSize = True
        Me.Nombre.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nombre.Location = New System.Drawing.Point(123, 57)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(45, 15)
        Me.Nombre.TabIndex = 4
        Me.Nombre.Text = "Label5"
        '
        'lbl_Mail
        '
        Me.lbl_Mail.AutoSize = True
        Me.lbl_Mail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Mail.Location = New System.Drawing.Point(6, 114)
        Me.lbl_Mail.Name = "lbl_Mail"
        Me.lbl_Mail.Size = New System.Drawing.Size(41, 16)
        Me.lbl_Mail.TabIndex = 6
        Me.lbl_Mail.Text = "Mail:"
        '
        'lbl_Usuario
        '
        Me.lbl_Usuario.AutoSize = True
        Me.lbl_Usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Usuario.Location = New System.Drawing.Point(6, 27)
        Me.lbl_Usuario.Name = "lbl_Usuario"
        Me.lbl_Usuario.Size = New System.Drawing.Size(66, 16)
        Me.lbl_Usuario.TabIndex = 7
        Me.lbl_Usuario.Text = "Usuario:"
        '
        'GB_Usuario
        '
        Me.GB_Usuario.Controls.Add(Me.Notificaciones)
        Me.GB_Usuario.Controls.Add(Me.Label5)
        Me.GB_Usuario.Controls.Add(Me.Mensajes)
        Me.GB_Usuario.Controls.Add(Me.Label3)
        Me.GB_Usuario.Controls.Add(Me.Button1)
        Me.GB_Usuario.Controls.Add(Me.Fecha)
        Me.GB_Usuario.Controls.Add(Me.Label1)
        Me.GB_Usuario.Controls.Add(Me.Mail)
        Me.GB_Usuario.Controls.Add(Me.Apellido)
        Me.GB_Usuario.Controls.Add(Me.Nombre)
        Me.GB_Usuario.Controls.Add(Me.lbl_Usuario)
        Me.GB_Usuario.Controls.Add(Me.lbl_Nombre)
        Me.GB_Usuario.Controls.Add(Me.lbl_Mail)
        Me.GB_Usuario.Controls.Add(Me.Usuario)
        Me.GB_Usuario.Controls.Add(Me.lbl_Apellido)
        Me.GB_Usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Usuario.Location = New System.Drawing.Point(12, 12)
        Me.GB_Usuario.Name = "GB_Usuario"
        Me.GB_Usuario.Size = New System.Drawing.Size(370, 248)
        Me.GB_Usuario.TabIndex = 8
        Me.GB_Usuario.TabStop = False
        Me.GB_Usuario.Text = "Información de la Cuenta"
        '
        'Notificaciones
        '
        Me.Notificaciones.AutoSize = True
        Me.Notificaciones.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Notificaciones.Location = New System.Drawing.Point(123, 202)
        Me.Notificaciones.Name = "Notificaciones"
        Me.Notificaciones.Size = New System.Drawing.Size(46, 15)
        Me.Notificaciones.TabIndex = 16
        Me.Notificaciones.Text = "Label2"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 201)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 16)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Notificaciones:"
        '
        'Mensajes
        '
        Me.Mensajes.AutoSize = True
        Me.Mensajes.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mensajes.Location = New System.Drawing.Point(123, 173)
        Me.Mensajes.Name = "Mensajes"
        Me.Mensajes.Size = New System.Drawing.Size(46, 15)
        Me.Mensajes.TabIndex = 14
        Me.Mensajes.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 16)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Mensajes:"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.SistemaCinderella.My.Resources.Recursos.desconectado_32
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(264, 202)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 40)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Cerrar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Fecha
        '
        Me.Fecha.AutoSize = True
        Me.Fecha.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.Location = New System.Drawing.Point(123, 144)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(46, 15)
        Me.Fecha.TabIndex = 11
        Me.Fecha.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 143)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Fecha Alta:"
        '
        'Mail
        '
        Me.Mail.AutoSize = True
        Me.Mail.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mail.Location = New System.Drawing.Point(123, 115)
        Me.Mail.Name = "Mail"
        Me.Mail.Size = New System.Drawing.Size(46, 15)
        Me.Mail.TabIndex = 9
        Me.Mail.Text = "Label2"
        '
        'Apellido
        '
        Me.Apellido.AutoSize = True
        Me.Apellido.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Apellido.Location = New System.Drawing.Point(123, 86)
        Me.Apellido.Name = "Apellido"
        Me.Apellido.Size = New System.Drawing.Size(45, 15)
        Me.Apellido.TabIndex = 8
        Me.Apellido.Text = "Label1"
        '
        'frmMiCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 272)
        Me.Controls.Add(Me.GB_Usuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMiCuenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de Gestión Cinderella | Mi Cuenta"
        Me.GB_Usuario.ResumeLayout(False)
        Me.GB_Usuario.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_Nombre As System.Windows.Forms.Label
    Friend WithEvents Usuario As System.Windows.Forms.Label
    Friend WithEvents lbl_Apellido As System.Windows.Forms.Label
    Friend WithEvents Nombre As System.Windows.Forms.Label
    Friend WithEvents lbl_Mail As System.Windows.Forms.Label
    Friend WithEvents lbl_Usuario As System.Windows.Forms.Label
    Friend WithEvents GB_Usuario As System.Windows.Forms.GroupBox
    Friend WithEvents Fecha As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Mail As System.Windows.Forms.Label
    Friend WithEvents Apellido As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Notificaciones As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Mensajes As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
