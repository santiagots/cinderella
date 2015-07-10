<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmpleadosRegistro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmpleadosRegistro))
        Me.Gb_Fechas = New System.Windows.Forms.GroupBox()
        Me.Btn_Eliminar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LstFechas = New System.Windows.Forms.ListBox()
        Me.Tcontrol = New System.Windows.Forms.TabControl()
        Me.TabIngresar = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CheckListEmpleadosAusentes = New System.Windows.Forms.CheckedListBox()
        Me.Btn_Agregar = New System.Windows.Forms.Button()
        Me.CheckListEmpleadosPresentes = New System.Windows.Forms.CheckedListBox()
        Me.DT_Fecha = New System.Windows.Forms.DateTimePicker()
        Me.lbl_Fecha = New System.Windows.Forms.Label()
        Me.TabVisualizar = New System.Windows.Forms.TabPage()
        Me.Btn_Editar = New System.Windows.Forms.Button()
        Me.CheckListEmpleadosPresentesEdit = New System.Windows.Forms.CheckedListBox()
        Me.DT_FechaEdit = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Gb_Fechas2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CheckListEmpleadosAusentesEdit = New System.Windows.Forms.CheckedListBox()
        Me.Gb_Fechas.SuspendLayout()
        Me.Tcontrol.SuspendLayout()
        Me.TabIngresar.SuspendLayout()
        Me.TabVisualizar.SuspendLayout()
        Me.Gb_Fechas2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gb_Fechas
        '
        Me.Gb_Fechas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Gb_Fechas.Controls.Add(Me.Btn_Eliminar)
        Me.Gb_Fechas.Controls.Add(Me.Label1)
        Me.Gb_Fechas.Controls.Add(Me.LstFechas)
        Me.Gb_Fechas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gb_Fechas.Location = New System.Drawing.Point(12, 14)
        Me.Gb_Fechas.Name = "Gb_Fechas"
        Me.Gb_Fechas.Size = New System.Drawing.Size(434, 452)
        Me.Gb_Fechas.TabIndex = 0
        Me.Gb_Fechas.TabStop = False
        Me.Gb_Fechas.Text = "Fechas Ingresas"
        '
        'Btn_Eliminar
        '
        Me.Btn_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Eliminar.Image = Global.SistemaCinderella.My.Resources.Recursos.Boton_Eliminar
        Me.Btn_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Eliminar.Location = New System.Drawing.Point(296, 19)
        Me.Btn_Eliminar.Name = "Btn_Eliminar"
        Me.Btn_Eliminar.Size = New System.Drawing.Size(130, 35)
        Me.Btn_Eliminar.TabIndex = 1
        Me.Btn_Eliminar.Text = "Eliminar Fecha"
        Me.Btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Eliminar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Empleados asignados por fecha."
        '
        'LstFechas
        '
        Me.LstFechas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LstFechas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LstFechas.FormattingEnabled = True
        Me.LstFechas.ItemHeight = 15
        Me.LstFechas.Location = New System.Drawing.Point(10, 60)
        Me.LstFechas.Name = "LstFechas"
        Me.LstFechas.Size = New System.Drawing.Size(416, 379)
        Me.LstFechas.TabIndex = 2
        '
        'Tcontrol
        '
        Me.Tcontrol.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tcontrol.Controls.Add(Me.TabIngresar)
        Me.Tcontrol.Controls.Add(Me.TabVisualizar)
        Me.Tcontrol.Location = New System.Drawing.Point(7, 23)
        Me.Tcontrol.Name = "Tcontrol"
        Me.Tcontrol.SelectedIndex = 0
        Me.Tcontrol.Size = New System.Drawing.Size(416, 420)
        Me.Tcontrol.TabIndex = 4
        '
        'TabIngresar
        '
        Me.TabIngresar.Controls.Add(Me.Label4)
        Me.TabIngresar.Controls.Add(Me.Label3)
        Me.TabIngresar.Controls.Add(Me.CheckListEmpleadosAusentes)
        Me.TabIngresar.Controls.Add(Me.Btn_Agregar)
        Me.TabIngresar.Controls.Add(Me.CheckListEmpleadosPresentes)
        Me.TabIngresar.Controls.Add(Me.DT_Fecha)
        Me.TabIngresar.Controls.Add(Me.lbl_Fecha)
        Me.TabIngresar.Location = New System.Drawing.Point(4, 24)
        Me.TabIngresar.Name = "TabIngresar"
        Me.TabIngresar.Padding = New System.Windows.Forms.Padding(3)
        Me.TabIngresar.Size = New System.Drawing.Size(408, 392)
        Me.TabIngresar.TabIndex = 0
        Me.TabIngresar.Text = "Ingreso"
        Me.TabIngresar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(204, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Ausencias"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Asistencias"
        '
        'CheckListEmpleadosAusentes
        '
        Me.CheckListEmpleadosAusentes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckListEmpleadosAusentes.CheckOnClick = True
        Me.CheckListEmpleadosAusentes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckListEmpleadosAusentes.FormattingEnabled = True
        Me.CheckListEmpleadosAusentes.Location = New System.Drawing.Point(207, 57)
        Me.CheckListEmpleadosAusentes.Name = "CheckListEmpleadosAusentes"
        Me.CheckListEmpleadosAusentes.Size = New System.Drawing.Size(190, 324)
        Me.CheckListEmpleadosAusentes.TabIndex = 6
        '
        'Btn_Agregar
        '
        Me.Btn_Agregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Agregar.Image = Global.SistemaCinderella.My.Resources.Recursos.Agregar_24
        Me.Btn_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Agregar.Location = New System.Drawing.Point(290, 9)
        Me.Btn_Agregar.Name = "Btn_Agregar"
        Me.Btn_Agregar.Size = New System.Drawing.Size(90, 30)
        Me.Btn_Agregar.TabIndex = 4
        Me.Btn_Agregar.Text = "Ingresar"
        Me.Btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Agregar.UseVisualStyleBackColor = True
        '
        'CheckListEmpleadosPresentes
        '
        Me.CheckListEmpleadosPresentes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckListEmpleadosPresentes.CheckOnClick = True
        Me.CheckListEmpleadosPresentes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckListEmpleadosPresentes.FormattingEnabled = True
        Me.CheckListEmpleadosPresentes.Location = New System.Drawing.Point(10, 57)
        Me.CheckListEmpleadosPresentes.Name = "CheckListEmpleadosPresentes"
        Me.CheckListEmpleadosPresentes.Size = New System.Drawing.Size(190, 324)
        Me.CheckListEmpleadosPresentes.TabIndex = 5
        '
        'DT_Fecha
        '
        Me.DT_Fecha.Location = New System.Drawing.Point(54, 12)
        Me.DT_Fecha.Name = "DT_Fecha"
        Me.DT_Fecha.Size = New System.Drawing.Size(227, 21)
        Me.DT_Fecha.TabIndex = 3
        '
        'lbl_Fecha
        '
        Me.lbl_Fecha.AutoSize = True
        Me.lbl_Fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Fecha.Location = New System.Drawing.Point(7, 17)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(41, 15)
        Me.lbl_Fecha.TabIndex = 1
        Me.lbl_Fecha.Text = "Fecha"
        '
        'TabVisualizar
        '
        Me.TabVisualizar.Controls.Add(Me.Label6)
        Me.TabVisualizar.Controls.Add(Me.CheckListEmpleadosAusentesEdit)
        Me.TabVisualizar.Controls.Add(Me.Label5)
        Me.TabVisualizar.Controls.Add(Me.Btn_Editar)
        Me.TabVisualizar.Controls.Add(Me.CheckListEmpleadosPresentesEdit)
        Me.TabVisualizar.Controls.Add(Me.DT_FechaEdit)
        Me.TabVisualizar.Controls.Add(Me.Label2)
        Me.TabVisualizar.Location = New System.Drawing.Point(4, 24)
        Me.TabVisualizar.Name = "TabVisualizar"
        Me.TabVisualizar.Padding = New System.Windows.Forms.Padding(3)
        Me.TabVisualizar.Size = New System.Drawing.Size(408, 392)
        Me.TabVisualizar.TabIndex = 1
        Me.TabVisualizar.Text = "Editar / Detalle"
        Me.TabVisualizar.UseVisualStyleBackColor = True
        '
        'Btn_Editar
        '
        Me.Btn_Editar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Editar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Editar.Image = Global.SistemaCinderella.My.Resources.Recursos.Editar_24
        Me.Btn_Editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Editar.Location = New System.Drawing.Point(290, 9)
        Me.Btn_Editar.Name = "Btn_Editar"
        Me.Btn_Editar.Size = New System.Drawing.Size(90, 30)
        Me.Btn_Editar.TabIndex = 8
        Me.Btn_Editar.Text = "Editar"
        Me.Btn_Editar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Editar.UseVisualStyleBackColor = True
        '
        'CheckListEmpleadosPresentesEdit
        '
        Me.CheckListEmpleadosPresentesEdit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckListEmpleadosPresentesEdit.CheckOnClick = True
        Me.CheckListEmpleadosPresentesEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckListEmpleadosPresentesEdit.FormattingEnabled = True
        Me.CheckListEmpleadosPresentesEdit.Location = New System.Drawing.Point(10, 57)
        Me.CheckListEmpleadosPresentesEdit.Name = "CheckListEmpleadosPresentesEdit"
        Me.CheckListEmpleadosPresentesEdit.Size = New System.Drawing.Size(190, 324)
        Me.CheckListEmpleadosPresentesEdit.TabIndex = 9
        '
        'DT_FechaEdit
        '
        Me.DT_FechaEdit.Location = New System.Drawing.Point(54, 12)
        Me.DT_FechaEdit.Name = "DT_FechaEdit"
        Me.DT_FechaEdit.Size = New System.Drawing.Size(227, 21)
        Me.DT_FechaEdit.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Fecha"
        '
        'Gb_Fechas2
        '
        Me.Gb_Fechas2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gb_Fechas2.Controls.Add(Me.Tcontrol)
        Me.Gb_Fechas2.Location = New System.Drawing.Point(452, 15)
        Me.Gb_Fechas2.Name = "Gb_Fechas2"
        Me.Gb_Fechas2.Size = New System.Drawing.Size(430, 451)
        Me.Gb_Fechas2.TabIndex = 5
        Me.Gb_Fechas2.TabStop = False
        Me.Gb_Fechas2.Text = "Ingresar/Visualizar Fechas y Empleados"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Asistencias"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(204, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 15)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Ausencias"
        '
        'CheckListEmpleadosAusentesEdit
        '
        Me.CheckListEmpleadosAusentesEdit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckListEmpleadosAusentesEdit.CheckOnClick = True
        Me.CheckListEmpleadosAusentesEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckListEmpleadosAusentesEdit.FormattingEnabled = True
        Me.CheckListEmpleadosAusentesEdit.Location = New System.Drawing.Point(207, 57)
        Me.CheckListEmpleadosAusentesEdit.Name = "CheckListEmpleadosAusentesEdit"
        Me.CheckListEmpleadosAusentesEdit.Size = New System.Drawing.Size(190, 324)
        Me.CheckListEmpleadosAusentesEdit.TabIndex = 11
        '
        'frmEmpleadosRegistro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(894, 472)
        Me.Controls.Add(Me.Gb_Fechas2)
        Me.Controls.Add(Me.Gb_Fechas)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmEmpleadosRegistro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Empleados"
        Me.Gb_Fechas.ResumeLayout(False)
        Me.Gb_Fechas.PerformLayout()
        Me.Tcontrol.ResumeLayout(False)
        Me.TabIngresar.ResumeLayout(False)
        Me.TabIngresar.PerformLayout()
        Me.TabVisualizar.ResumeLayout(False)
        Me.TabVisualizar.PerformLayout()
        Me.Gb_Fechas2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Gb_Fechas As System.Windows.Forms.GroupBox
    Friend WithEvents LstFechas As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents Tcontrol As System.Windows.Forms.TabControl
    Friend WithEvents TabIngresar As System.Windows.Forms.TabPage
    Friend WithEvents Btn_Agregar As System.Windows.Forms.Button
    Friend WithEvents CheckListEmpleadosPresentes As System.Windows.Forms.CheckedListBox
    Friend WithEvents DT_Fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Fecha As System.Windows.Forms.Label
    Friend WithEvents TabVisualizar As System.Windows.Forms.TabPage
    Friend WithEvents Gb_Fechas2 As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_Editar As System.Windows.Forms.Button
    Friend WithEvents CheckListEmpleadosPresentesEdit As System.Windows.Forms.CheckedListBox
    Friend WithEvents DT_FechaEdit As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CheckListEmpleadosAusentes As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CheckListEmpleadosAusentesEdit As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
