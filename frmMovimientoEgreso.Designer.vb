<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMovimientoEgreso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMovimientoEgreso))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblMercaderias = New System.Windows.Forms.Label()
        Me.Btn_CargarMercaderia = New System.Windows.Forms.Button()
        Me.CbSucursal = New System.Windows.Forms.ComboBox()
        Me.lbl_Sucursal2 = New System.Windows.Forms.Label()
        Me.CbSubtipo = New System.Windows.Forms.ComboBox()
        Me.lbl_Subtipo = New System.Windows.Forms.Label()
        Me.CbTipo = New System.Windows.Forms.ComboBox()
        Me.lbl_SucursalNombre = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.txtDate = New System.Windows.Forms.DateTimePicker()
        Me.lbl_Fecha = New System.Windows.Forms.Label()
        Me.lbl_Descripcion = New System.Windows.Forms.Label()
        Me.lbl_Monto = New System.Windows.Forms.Label()
        Me.lbl_Tipo = New System.Windows.Forms.Label()
        Me.lbl_Sucursal = New System.Windows.Forms.Label()
        Me.ErrorEgresos = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolEgresos = New System.Windows.Forms.ToolTip(Me.components)
        Me.Btn_Salir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorEgresos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(229, 336)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 15)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "(*) Datos Obligatorios."
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = Global.SistemaCinderella.My.Resources.Recursos.Limpiar_32
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(133, 358)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 40)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolEgresos.SetToolTip(Me.btnCancelar, "Al cancelar el formulario se restablecerán todas las opciones del formulario.")
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Image = Global.SistemaCinderella.My.Resources.Recursos.Agregar_24
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.Location = New System.Drawing.Point(256, 358)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(100, 40)
        Me.btnAceptar.TabIndex = 8
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolEgresos.SetToolTip(Me.btnAceptar, "Al aceptar el formulario se registrará en el sistema el egreso seleccionado.")
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Btn_Salir)
        Me.GroupBox1.Controls.Add(Me.btnCancelar)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.btnAceptar)
        Me.GroupBox1.Controls.Add(Me.lblMercaderias)
        Me.GroupBox1.Controls.Add(Me.Btn_CargarMercaderia)
        Me.GroupBox1.Controls.Add(Me.CbSucursal)
        Me.GroupBox1.Controls.Add(Me.lbl_Sucursal2)
        Me.GroupBox1.Controls.Add(Me.CbSubtipo)
        Me.GroupBox1.Controls.Add(Me.lbl_Subtipo)
        Me.GroupBox1.Controls.Add(Me.CbTipo)
        Me.GroupBox1.Controls.Add(Me.lbl_SucursalNombre)
        Me.GroupBox1.Controls.Add(Me.txtDescripcion)
        Me.GroupBox1.Controls.Add(Me.txtMonto)
        Me.GroupBox1.Controls.Add(Me.txtDate)
        Me.GroupBox1.Controls.Add(Me.lbl_Fecha)
        Me.GroupBox1.Controls.Add(Me.lbl_Descripcion)
        Me.GroupBox1.Controls.Add(Me.lbl_Monto)
        Me.GroupBox1.Controls.Add(Me.lbl_Tipo)
        Me.GroupBox1.Controls.Add(Me.lbl_Sucursal)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(10, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(372, 404)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Alta de movimientos de ""Egresos"" en la sucursal."
        '
        'lblMercaderias
        '
        Me.lblMercaderias.AutoSize = True
        Me.lblMercaderias.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMercaderias.Location = New System.Drawing.Point(12, 200)
        Me.lblMercaderias.Name = "lblMercaderias"
        Me.lblMercaderias.Size = New System.Drawing.Size(205, 15)
        Me.lblMercaderias.TabIndex = 11
        Me.lblMercaderias.Text = "(Total de Mercadería: 20 producto/s.)"
        Me.lblMercaderias.Visible = False
        '
        'Btn_CargarMercaderia
        '
        Me.Btn_CargarMercaderia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_CargarMercaderia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_CargarMercaderia.Image = Global.SistemaCinderella.My.Resources.Recursos.Proveedores_2
        Me.Btn_CargarMercaderia.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_CargarMercaderia.Location = New System.Drawing.Point(253, 163)
        Me.Btn_CargarMercaderia.Name = "Btn_CargarMercaderia"
        Me.Btn_CargarMercaderia.Size = New System.Drawing.Size(103, 45)
        Me.Btn_CargarMercaderia.TabIndex = 10
        Me.Btn_CargarMercaderia.Text = "Cargar Mercadería"
        Me.Btn_CargarMercaderia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolEgresos.SetToolTip(Me.Btn_CargarMercaderia, "Al hacer click aquí accederá al formulario para la carga de mercadería a enviar a" & _
                " la sucursal destino.")
        Me.Btn_CargarMercaderia.UseVisualStyleBackColor = True
        Me.Btn_CargarMercaderia.Visible = False
        '
        'CbSucursal
        '
        Me.CbSucursal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CbSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbSucursal.FormattingEnabled = True
        Me.CbSucursal.Items.AddRange(New Object() {"Ingresos", "Egresos", "Gastos", "Dif. de Caja"})
        Me.CbSucursal.Location = New System.Drawing.Point(146, 54)
        Me.CbSucursal.Name = "CbSucursal"
        Me.CbSucursal.Size = New System.Drawing.Size(210, 23)
        Me.CbSucursal.TabIndex = 1
        '
        'lbl_Sucursal2
        '
        Me.lbl_Sucursal2.AutoSize = True
        Me.lbl_Sucursal2.Location = New System.Drawing.Point(10, 62)
        Me.lbl_Sucursal2.Name = "lbl_Sucursal2"
        Me.lbl_Sucursal2.Size = New System.Drawing.Size(119, 15)
        Me.lbl_Sucursal2.TabIndex = 9
        Me.lbl_Sucursal2.Text = "Sucursal Destino. (*)"
        '
        'CbSubtipo
        '
        Me.CbSubtipo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CbSubtipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbSubtipo.Enabled = False
        Me.CbSubtipo.FormattingEnabled = True
        Me.CbSubtipo.Items.AddRange(New Object() {"Seleccione un tipo."})
        Me.CbSubtipo.Location = New System.Drawing.Point(146, 134)
        Me.CbSubtipo.Name = "CbSubtipo"
        Me.CbSubtipo.Size = New System.Drawing.Size(210, 23)
        Me.CbSubtipo.TabIndex = 4
        '
        'lbl_Subtipo
        '
        Me.lbl_Subtipo.AutoSize = True
        Me.lbl_Subtipo.Location = New System.Drawing.Point(10, 140)
        Me.lbl_Subtipo.Name = "lbl_Subtipo"
        Me.lbl_Subtipo.Size = New System.Drawing.Size(49, 15)
        Me.lbl_Subtipo.TabIndex = 7
        Me.lbl_Subtipo.Text = "Subtipo"
        '
        'CbTipo
        '
        Me.CbTipo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbTipo.FormattingEnabled = True
        Me.CbTipo.Items.AddRange(New Object() {"Ingresos", "Egresos", "Gastos", "Dif. de Caja"})
        Me.CbTipo.Location = New System.Drawing.Point(146, 107)
        Me.CbTipo.Name = "CbTipo"
        Me.CbTipo.Size = New System.Drawing.Size(210, 23)
        Me.CbTipo.TabIndex = 3
        '
        'lbl_SucursalNombre
        '
        Me.lbl_SucursalNombre.AutoSize = True
        Me.lbl_SucursalNombre.Location = New System.Drawing.Point(143, 36)
        Me.lbl_SucursalNombre.Name = "lbl_SucursalNombre"
        Me.lbl_SucursalNombre.Size = New System.Drawing.Size(39, 15)
        Me.lbl_SucursalNombre.TabIndex = 0
        Me.lbl_SucursalNombre.Text = "- - - - -"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(13, 241)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(343, 92)
        Me.txtDescripcion.TabIndex = 6
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(146, 163)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(101, 21)
        Me.txtMonto.TabIndex = 5
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(146, 82)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(210, 21)
        Me.txtDate.TabIndex = 2
        '
        'lbl_Fecha
        '
        Me.lbl_Fecha.AutoSize = True
        Me.lbl_Fecha.Location = New System.Drawing.Point(10, 88)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(57, 15)
        Me.lbl_Fecha.TabIndex = 5
        Me.lbl_Fecha.Text = "Fecha (*)"
        '
        'lbl_Descripcion
        '
        Me.lbl_Descripcion.AutoSize = True
        Me.lbl_Descripcion.Location = New System.Drawing.Point(12, 224)
        Me.lbl_Descripcion.Name = "lbl_Descripcion"
        Me.lbl_Descripcion.Size = New System.Drawing.Size(72, 15)
        Me.lbl_Descripcion.TabIndex = 4
        Me.lbl_Descripcion.Text = "Descripción"
        '
        'lbl_Monto
        '
        Me.lbl_Monto.AutoSize = True
        Me.lbl_Monto.Location = New System.Drawing.Point(10, 166)
        Me.lbl_Monto.Name = "lbl_Monto"
        Me.lbl_Monto.Size = New System.Drawing.Size(45, 15)
        Me.lbl_Monto.TabIndex = 3
        Me.lbl_Monto.Text = "Monto "
        '
        'lbl_Tipo
        '
        Me.lbl_Tipo.AutoSize = True
        Me.lbl_Tipo.Location = New System.Drawing.Point(10, 114)
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
        'ErrorEgresos
        '
        Me.ErrorEgresos.BlinkRate = 200
        Me.ErrorEgresos.ContainerControl = Me
        '
        'ToolEgresos
        '
        Me.ToolEgresos.IsBalloon = True
        Me.ToolEgresos.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolEgresos.ToolTipTitle = "Ayuda"
        '
        'Btn_Salir
        '
        Me.Btn_Salir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Salir.Image = Global.SistemaCinderella.My.Resources.Recursos.desconectado_32
        Me.Btn_Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Salir.Location = New System.Drawing.Point(13, 358)
        Me.Btn_Salir.Name = "Btn_Salir"
        Me.Btn_Salir.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Salir.TabIndex = 23
        Me.Btn_Salir.Text = "Salir"
        Me.Btn_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolEgresos.SetToolTip(Me.Btn_Salir, "Al cancelar el formulario se restablecerán todas las opciones del formulario.")
        Me.Btn_Salir.UseVisualStyleBackColor = True
        '
        'frmMovimientoEgreso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 422)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMovimientoEgreso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Movimientos | Egresos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorEgresos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_SucursalNombre As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents txtDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Fecha As System.Windows.Forms.Label
    Friend WithEvents lbl_Descripcion As System.Windows.Forms.Label
    Friend WithEvents lbl_Monto As System.Windows.Forms.Label
    Friend WithEvents lbl_Tipo As System.Windows.Forms.Label
    Friend WithEvents lbl_Sucursal As System.Windows.Forms.Label
    Friend WithEvents CbSucursal As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_Sucursal2 As System.Windows.Forms.Label
    Friend WithEvents CbSubtipo As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_Subtipo As System.Windows.Forms.Label
    Friend WithEvents ErrorEgresos As System.Windows.Forms.ErrorProvider
    Friend WithEvents ToolEgresos As System.Windows.Forms.ToolTip
    Friend WithEvents Btn_CargarMercaderia As System.Windows.Forms.Button
    Friend WithEvents lblMercaderias As System.Windows.Forms.Label
    Friend WithEvents Btn_Salir As System.Windows.Forms.Button
End Class
