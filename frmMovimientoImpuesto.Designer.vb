<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMovimientoImpuesto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMovimientoImpuesto))
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CbTipo = New System.Windows.Forms.ComboBox()
        Me.lbl_SucursalNombre = New System.Windows.Forms.Label()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.txtDate = New System.Windows.Forms.DateTimePicker()
        Me.lbl_Fecha = New System.Windows.Forms.Label()
        Me.lbl_Monto = New System.Windows.Forms.Label()
        Me.lbl_Tipo = New System.Windows.Forms.Label()
        Me.lbl_Sucursal = New System.Windows.Forms.Label()
        Me.ToolImpuestos = New System.Windows.Forms.ToolTip(Me.components)
        Me.ErrorImpuestos = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorImpuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = Global.SistemaCinderella.My.Resources.Recursos.desconectado_32
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(13, 168)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 40)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolImpuestos.SetToolTip(Me.btnCancelar, "Al cancelar el formulario se restablecerán todas las opciones del formulario.")
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Image = Global.SistemaCinderella.My.Resources.Recursos.Agregar_24
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.Location = New System.Drawing.Point(256, 168)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(100, 40)
        Me.btnAceptar.TabIndex = 6
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolImpuestos.SetToolTip(Me.btnAceptar, "Al aceptar el formulario se registrará en el sistema el impuesto de la sucursal.")
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnAceptar)
        Me.GroupBox1.Controls.Add(Me.btnCancelar)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.CbTipo)
        Me.GroupBox1.Controls.Add(Me.lbl_SucursalNombre)
        Me.GroupBox1.Controls.Add(Me.txtMonto)
        Me.GroupBox1.Controls.Add(Me.txtDate)
        Me.GroupBox1.Controls.Add(Me.lbl_Fecha)
        Me.GroupBox1.Controls.Add(Me.lbl_Monto)
        Me.GroupBox1.Controls.Add(Me.lbl_Tipo)
        Me.GroupBox1.Controls.Add(Me.lbl_Sucursal)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(10, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(372, 214)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Alta de movimientos de ""Impuestos"" de la sucursal."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(229, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 15)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "(*) Datos Obligatorios."
        '
        'CbTipo
        '
        Me.CbTipo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbTipo.FormattingEnabled = True
        Me.CbTipo.Items.AddRange(New Object() {"Ingresos", "Egresos", "Gastos", "Dif. de Caja"})
        Me.CbTipo.Location = New System.Drawing.Point(127, 82)
        Me.CbTipo.Name = "CbTipo"
        Me.CbTipo.Size = New System.Drawing.Size(229, 23)
        Me.CbTipo.TabIndex = 3
        '
        'lbl_SucursalNombre
        '
        Me.lbl_SucursalNombre.AutoSize = True
        Me.lbl_SucursalNombre.Location = New System.Drawing.Point(127, 36)
        Me.lbl_SucursalNombre.Name = "lbl_SucursalNombre"
        Me.lbl_SucursalNombre.Size = New System.Drawing.Size(39, 15)
        Me.lbl_SucursalNombre.TabIndex = 0
        Me.lbl_SucursalNombre.Text = "- - - - -"
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(127, 111)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(120, 21)
        Me.txtMonto.TabIndex = 4
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(127, 58)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(229, 21)
        Me.txtDate.TabIndex = 1
        '
        'lbl_Fecha
        '
        Me.lbl_Fecha.AutoSize = True
        Me.lbl_Fecha.Location = New System.Drawing.Point(10, 63)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(57, 15)
        Me.lbl_Fecha.TabIndex = 5
        Me.lbl_Fecha.Text = "Fecha (*)"
        '
        'lbl_Monto
        '
        Me.lbl_Monto.AutoSize = True
        Me.lbl_Monto.Location = New System.Drawing.Point(10, 117)
        Me.lbl_Monto.Name = "lbl_Monto"
        Me.lbl_Monto.Size = New System.Drawing.Size(58, 15)
        Me.lbl_Monto.TabIndex = 3
        Me.lbl_Monto.Text = "Monto (*)"
        '
        'lbl_Tipo
        '
        Me.lbl_Tipo.AutoSize = True
        Me.lbl_Tipo.Location = New System.Drawing.Point(10, 90)
        Me.lbl_Tipo.Name = "lbl_Tipo"
        Me.lbl_Tipo.Size = New System.Drawing.Size(47, 15)
        Me.lbl_Tipo.TabIndex = 2
        Me.lbl_Tipo.Text = "Tipo (*)"
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
        'ToolImpuestos
        '
        Me.ToolImpuestos.IsBalloon = True
        Me.ToolImpuestos.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolImpuestos.ToolTipTitle = "Ayuda"
        '
        'ErrorImpuestos
        '
        Me.ErrorImpuestos.BlinkRate = 200
        Me.ErrorImpuestos.ContainerControl = Me
        '
        'frmMovimientoImpuesto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 232)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMovimientoImpuesto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Movimientos | Impuestos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorImpuestos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_SucursalNombre As System.Windows.Forms.Label
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents txtDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Fecha As System.Windows.Forms.Label
    Friend WithEvents lbl_Monto As System.Windows.Forms.Label
    Friend WithEvents lbl_Tipo As System.Windows.Forms.Label
    Friend WithEvents lbl_Sucursal As System.Windows.Forms.Label
    Friend WithEvents ToolImpuestos As System.Windows.Forms.ToolTip
    Friend WithEvents ErrorImpuestos As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
