<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReciboSueldo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReciboSueldo))
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtAguinaldo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtVacaciones = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Cb_Anios = New System.Windows.Forms.ComboBox()
        Me.Cb_Meses = New System.Windows.Forms.ComboBox()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.cb_Empleados = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbl_MSG = New System.Windows.Forms.Label()
        Me.Lst_Anteriores = New System.Windows.Forms.ListBox()
        Me.ErrorRecibos = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ErrorRecibos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = Global.SistemaCinderella.My.Resources.Recursos.desconectado_32
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(10, 168)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 40)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnCancelar, "Al cancelar el formulario se restablecerán todas las opciones del formulario.")
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Image = Global.SistemaCinderella.My.Resources.Recursos.Agregar_24
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.Location = New System.Drawing.Point(357, 168)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(100, 40)
        Me.btnAceptar.TabIndex = 5
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnAceptar, "Al aceptar el formulario se registrará en el sistema el recibo de sueldo del empl" & _
        "eado seleccionado.")
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtAguinaldo)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtVacaciones)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Cb_Anios)
        Me.GroupBox1.Controls.Add(Me.Cb_Meses)
        Me.GroupBox1.Controls.Add(Me.btnCancelar)
        Me.GroupBox1.Controls.Add(Me.btnAceptar)
        Me.GroupBox1.Controls.Add(Me.txtMonto)
        Me.GroupBox1.Controls.Add(Me.cb_Empleados)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(10, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(469, 214)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Alta / Modificación de recibo de sueldo, vacaciones y aguinaldo."
        '
        'txtAguinaldo
        '
        Me.txtAguinaldo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAguinaldo.Location = New System.Drawing.Point(144, 136)
        Me.txtAguinaldo.Name = "txtAguinaldo"
        Me.txtAguinaldo.Size = New System.Drawing.Size(140, 21)
        Me.txtAguinaldo.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.txtAguinaldo, "Si ingresa un monto para un mes y año ya cargado, éste será modificado por el nue" & _
        "vo valor ingresado.")
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 138)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 15)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Aguinaldo"
        '
        'txtVacaciones
        '
        Me.txtVacaciones.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtVacaciones.Location = New System.Drawing.Point(144, 109)
        Me.txtVacaciones.Name = "txtVacaciones"
        Me.txtVacaciones.Size = New System.Drawing.Size(140, 21)
        Me.txtVacaciones.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.txtVacaciones, "Si ingresa un monto para un mes y año ya cargado, éste será modificado por el nue" & _
        "vo valor ingresado.")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 110)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 15)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Vacaciones"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(295, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 15)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Año (*)"
        '
        'Cb_Anios
        '
        Me.Cb_Anios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cb_Anios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Anios.FormattingEnabled = True
        Me.Cb_Anios.Location = New System.Drawing.Point(363, 51)
        Me.Cb_Anios.Name = "Cb_Anios"
        Me.Cb_Anios.Size = New System.Drawing.Size(94, 23)
        Me.Cb_Anios.TabIndex = 10
        '
        'Cb_Meses
        '
        Me.Cb_Meses.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cb_Meses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Meses.FormattingEnabled = True
        Me.Cb_Meses.Location = New System.Drawing.Point(144, 51)
        Me.Cb_Meses.Name = "Cb_Meses"
        Me.Cb_Meses.Size = New System.Drawing.Size(140, 23)
        Me.Cb_Meses.TabIndex = 9
        '
        'txtMonto
        '
        Me.txtMonto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMonto.Location = New System.Drawing.Point(144, 82)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(140, 21)
        Me.txtMonto.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.txtMonto, "Si ingresa un monto para un mes y año ya cargado, éste será modificado por el nue" & _
        "vo valor ingresado.")
        '
        'cb_Empleados
        '
        Me.cb_Empleados.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_Empleados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_Empleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Empleados.FormattingEnabled = True
        Me.cb_Empleados.Location = New System.Drawing.Point(144, 23)
        Me.cb_Empleados.Name = "cb_Empleados"
        Me.cb_Empleados.Size = New System.Drawing.Size(313, 23)
        Me.cb_Empleados.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Mes (*)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Recibo de sueldo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Empleado (*)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(352, 223)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "(*) Datos Obligatorios."
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbl_MSG)
        Me.GroupBox2.Controls.Add(Me.Lst_Anteriores)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(10, 241)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(469, 219)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Recibo de sueldo de meses anteriores"
        '
        'lbl_MSG
        '
        Me.lbl_MSG.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MSG.Location = New System.Drawing.Point(7, 92)
        Me.lbl_MSG.Name = "lbl_MSG"
        Me.lbl_MSG.Size = New System.Drawing.Size(456, 20)
        Me.lbl_MSG.TabIndex = 1
        Me.lbl_MSG.Text = "Debe seleccionar un empleado."
        Me.lbl_MSG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lst_Anteriores
        '
        Me.Lst_Anteriores.FormattingEnabled = True
        Me.Lst_Anteriores.ItemHeight = 15
        Me.Lst_Anteriores.Items.AddRange(New Object() {"2012 - Agosto - $1000.-", "2012 - Julio - $1000.-", "2012 - Junio - $1000.-", "2012 - Mayo - $1000.-", "2012 - Abril - $1000.-", "2012 - Marzo - $500.-", "2012 - Febrero - $1500.-", "2012 - Enero - $2010.-"})
        Me.Lst_Anteriores.Location = New System.Drawing.Point(7, 22)
        Me.Lst_Anteriores.Name = "Lst_Anteriores"
        Me.Lst_Anteriores.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.Lst_Anteriores.Size = New System.Drawing.Size(456, 184)
        Me.Lst_Anteriores.TabIndex = 0
        Me.Lst_Anteriores.Visible = False
        '
        'ErrorRecibos
        '
        Me.ErrorRecibos.BlinkRate = 200
        Me.ErrorRecibos.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink
        Me.ErrorRecibos.ContainerControl = Me
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Ayuda"
        '
        'frmReciboSueldo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 472)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmReciboSueldo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recibo de Sueldo, Vacaciones y Aguinaldo de Empleados"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.ErrorRecibos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents cb_Empleados As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Cb_Meses As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Lst_Anteriores As System.Windows.Forms.ListBox
    Friend WithEvents lbl_MSG As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Cb_Anios As System.Windows.Forms.ComboBox
    Friend WithEvents ErrorRecibos As System.Windows.Forms.ErrorProvider
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents txtAguinaldo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtVacaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
