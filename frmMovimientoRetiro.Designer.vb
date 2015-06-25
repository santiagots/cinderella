<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMovimientoRetiro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMovimientoRetiro))
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEncargado = New System.Windows.Forms.TextBox()
        Me.txtPersona = New System.Windows.Forms.TextBox()
        Me.lbl_SucursalNombre = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.txtDate = New System.Windows.Forms.DateTimePicker()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_Sucursal = New System.Windows.Forms.Label()
        Me.ErrorRetiros = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolRetiros = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorRetiros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = Global.SistemaCinderella.My.Resources.Recursos.desconectado_32
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(13, 308)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 40)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolRetiros.SetToolTip(Me.btnCancelar, "Al cancelar el formulario se restablecerán todas las opciones del formulario.")
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Image = Global.SistemaCinderella.My.Resources.Recursos.Agregar_24
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.Location = New System.Drawing.Point(278, 308)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(100, 40)
        Me.btnAceptar.TabIndex = 7
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolRetiros.SetToolTip(Me.btnAceptar, "Al aceptar el formulario se registrará en el sistema el retiro de dinero del soci" & _
                "o.")
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtEncargado)
        Me.GroupBox1.Controls.Add(Me.btnAceptar)
        Me.GroupBox1.Controls.Add(Me.btnCancelar)
        Me.GroupBox1.Controls.Add(Me.txtPersona)
        Me.GroupBox1.Controls.Add(Me.lbl_SucursalNombre)
        Me.GroupBox1.Controls.Add(Me.txtDescripcion)
        Me.GroupBox1.Controls.Add(Me.txtMonto)
        Me.GroupBox1.Controls.Add(Me.txtDate)
        Me.GroupBox1.Controls.Add(Me.lblFecha)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lbl_Sucursal)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(10, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(390, 354)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Retiro de efectivo por parte de socios de la empresa."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(251, 279)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 15)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "(*) Datos Obligatorios."
        '
        'txtEncargado
        '
        Me.txtEncargado.Location = New System.Drawing.Point(152, 85)
        Me.txtEncargado.Name = "txtEncargado"
        Me.txtEncargado.Size = New System.Drawing.Size(226, 21)
        Me.txtEncargado.TabIndex = 2
        '
        'txtPersona
        '
        Me.txtPersona.Location = New System.Drawing.Point(152, 108)
        Me.txtPersona.Name = "txtPersona"
        Me.txtPersona.Size = New System.Drawing.Size(226, 21)
        Me.txtPersona.TabIndex = 3
        '
        'lbl_SucursalNombre
        '
        Me.lbl_SucursalNombre.AutoSize = True
        Me.lbl_SucursalNombre.Location = New System.Drawing.Point(152, 36)
        Me.lbl_SucursalNombre.Name = "lbl_SucursalNombre"
        Me.lbl_SucursalNombre.Size = New System.Drawing.Size(39, 15)
        Me.lbl_SucursalNombre.TabIndex = 0
        Me.lbl_SucursalNombre.Text = "- - - - -"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(13, 184)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(365, 92)
        Me.txtDescripcion.TabIndex = 5
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(152, 134)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(120, 21)
        Me.txtMonto.TabIndex = 4
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(152, 57)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(226, 21)
        Me.txtDate.TabIndex = 1
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(10, 62)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(57, 15)
        Me.lblFecha.TabIndex = 5
        Me.lblFecha.Text = "Fecha (*)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Descripción"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Monto (*)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Encargado Retirante (*)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Persona Retirante (*)"
        '
        'lbl_Sucursal
        '
        Me.lbl_Sucursal.AutoSize = True
        Me.lbl_Sucursal.Location = New System.Drawing.Point(10, 36)
        Me.lbl_Sucursal.Name = "lbl_Sucursal"
        Me.lbl_Sucursal.Size = New System.Drawing.Size(55, 15)
        Me.lbl_Sucursal.TabIndex = 0
        Me.lbl_Sucursal.Text = "Sucursal"
        '
        'ErrorRetiros
        '
        Me.ErrorRetiros.BlinkRate = 200
        Me.ErrorRetiros.ContainerControl = Me
        '
        'ToolRetiros
        '
        Me.ToolRetiros.IsBalloon = True
        Me.ToolRetiros.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolRetiros.ToolTipTitle = "Ayuda"
        '
        'frmMovimientoRetiro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 372)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMovimientoRetiro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Movimientos | Retiro de Socios"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorRetiros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtEncargado As System.Windows.Forms.TextBox
    Friend WithEvents txtPersona As System.Windows.Forms.TextBox
    Friend WithEvents lbl_SucursalNombre As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents txtDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_Sucursal As System.Windows.Forms.Label
    Friend WithEvents ErrorRetiros As System.Windows.Forms.ErrorProvider
    Friend WithEvents ToolRetiros As System.Windows.Forms.ToolTip
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
