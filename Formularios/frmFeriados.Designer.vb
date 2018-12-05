<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFeriados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFeriados))
        Me.Calendario = New System.Windows.Forms.MonthCalendar()
        Me.lbl_CantFeriados = New System.Windows.Forms.Label()
        Me.GB_Informacion = New System.Windows.Forms.GroupBox()
        Me.Btn_Limpiar = New System.Windows.Forms.Button()
        Me.Btn_Agregar = New System.Windows.Forms.Button()
        Me.FechaSeleccionada = New System.Windows.Forms.Label()
        Me.lbl_FechaSeleccionada = New System.Windows.Forms.Label()
        Me.link_Visualizar = New System.Windows.Forms.LinkLabel()
        Me.lbl_Visualizar = New System.Windows.Forms.Label()
        Me.lbl_Cant = New System.Windows.Forms.Label()
        Me.GB_Informacion.SuspendLayout()
        Me.SuspendLayout()
        '
        'Calendario
        '
        Me.Calendario.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Calendario.BackColor = System.Drawing.SystemColors.Window
        Me.Calendario.CalendarDimensions = New System.Drawing.Size(3, 4)
        Me.Calendario.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Calendario.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Calendario.Location = New System.Drawing.Point(0, 0)
        Me.Calendario.MaxDate = New Date(2012, 12, 31, 0, 0, 0, 0)
        Me.Calendario.MinDate = New Date(2012, 1, 1, 0, 0, 0, 0)
        Me.Calendario.Name = "Calendario"
        Me.Calendario.ShowToday = False
        Me.Calendario.ShowTodayCircle = False
        Me.Calendario.TabIndex = 0
        '
        'lbl_CantFeriados
        '
        Me.lbl_CantFeriados.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_CantFeriados.AutoSize = True
        Me.lbl_CantFeriados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CantFeriados.Location = New System.Drawing.Point(11, 33)
        Me.lbl_CantFeriados.Name = "lbl_CantFeriados"
        Me.lbl_CantFeriados.Size = New System.Drawing.Size(188, 15)
        Me.lbl_CantFeriados.TabIndex = 1
        Me.lbl_CantFeriados.Text = "Cantidad feriados seleccionados:"
        '
        'GB_Informacion
        '
        Me.GB_Informacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_Informacion.Controls.Add(Me.Btn_Limpiar)
        Me.GB_Informacion.Controls.Add(Me.Btn_Agregar)
        Me.GB_Informacion.Controls.Add(Me.FechaSeleccionada)
        Me.GB_Informacion.Controls.Add(Me.lbl_FechaSeleccionada)
        Me.GB_Informacion.Controls.Add(Me.link_Visualizar)
        Me.GB_Informacion.Controls.Add(Me.lbl_Visualizar)
        Me.GB_Informacion.Controls.Add(Me.lbl_Cant)
        Me.GB_Informacion.Controls.Add(Me.lbl_CantFeriados)
        Me.GB_Informacion.Location = New System.Drawing.Point(12, 612)
        Me.GB_Informacion.Name = "GB_Informacion"
        Me.GB_Informacion.Size = New System.Drawing.Size(727, 83)
        Me.GB_Informacion.TabIndex = 2
        Me.GB_Informacion.TabStop = False
        Me.GB_Informacion.Text = "Información de los Elemenos Seleccionados"
        '
        'Btn_Limpiar
        '
        Me.Btn_Limpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Limpiar.Image = Global.SistemaCinderella.My.Resources.Recursos.Boton_Eliminar
        Me.Btn_Limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Limpiar.Location = New System.Drawing.Point(601, 48)
        Me.Btn_Limpiar.Name = "Btn_Limpiar"
        Me.Btn_Limpiar.Size = New System.Drawing.Size(120, 30)
        Me.Btn_Limpiar.TabIndex = 8
        Me.Btn_Limpiar.Text = "Limpiar Formulario"
        Me.Btn_Limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Limpiar.UseVisualStyleBackColor = True
        '
        'Btn_Agregar
        '
        Me.Btn_Agregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Agregar.Image = Global.SistemaCinderella.My.Resources.Recursos.Boton_Agregar
        Me.Btn_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Agregar.Location = New System.Drawing.Point(601, 12)
        Me.Btn_Agregar.Name = "Btn_Agregar"
        Me.Btn_Agregar.Size = New System.Drawing.Size(120, 30)
        Me.Btn_Agregar.TabIndex = 7
        Me.Btn_Agregar.Text = "Guardar Feriados"
        Me.Btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Agregar.UseVisualStyleBackColor = True
        '
        'FechaSeleccionada
        '
        Me.FechaSeleccionada.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.FechaSeleccionada.AutoSize = True
        Me.FechaSeleccionada.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaSeleccionada.Location = New System.Drawing.Point(435, 33)
        Me.FechaSeleccionada.Name = "FechaSeleccionada"
        Me.FechaSeleccionada.Size = New System.Drawing.Size(12, 15)
        Me.FechaSeleccionada.TabIndex = 6
        Me.FechaSeleccionada.Text = "-"
        '
        'lbl_FechaSeleccionada
        '
        Me.lbl_FechaSeleccionada.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lbl_FechaSeleccionada.AutoSize = True
        Me.lbl_FechaSeleccionada.Location = New System.Drawing.Point(294, 35)
        Me.lbl_FechaSeleccionada.Name = "lbl_FechaSeleccionada"
        Me.lbl_FechaSeleccionada.Size = New System.Drawing.Size(135, 13)
        Me.lbl_FechaSeleccionada.TabIndex = 5
        Me.lbl_FechaSeleccionada.Text = "Ultima fecha seleccionada:"
        '
        'link_Visualizar
        '
        Me.link_Visualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.link_Visualizar.AutoSize = True
        Me.link_Visualizar.Location = New System.Drawing.Point(236, 62)
        Me.link_Visualizar.Name = "link_Visualizar"
        Me.link_Visualizar.Size = New System.Drawing.Size(48, 13)
        Me.link_Visualizar.TabIndex = 4
        Me.link_Visualizar.TabStop = True
        Me.link_Visualizar.Text = "Ver Lista"
        '
        'lbl_Visualizar
        '
        Me.lbl_Visualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_Visualizar.AutoSize = True
        Me.lbl_Visualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Visualizar.Location = New System.Drawing.Point(11, 60)
        Me.lbl_Visualizar.Name = "lbl_Visualizar"
        Me.lbl_Visualizar.Size = New System.Drawing.Size(221, 15)
        Me.lbl_Visualizar.TabIndex = 3
        Me.lbl_Visualizar.Text = "Ver lista de los feriados seleccionados: "
        '
        'lbl_Cant
        '
        Me.lbl_Cant.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_Cant.AutoSize = True
        Me.lbl_Cant.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Cant.Location = New System.Drawing.Point(236, 33)
        Me.lbl_Cant.Name = "lbl_Cant"
        Me.lbl_Cant.Size = New System.Drawing.Size(15, 15)
        Me.lbl_Cant.TabIndex = 2
        Me.lbl_Cant.Text = "0"
        '
        'frmFeriados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(751, 707)
        Me.Controls.Add(Me.GB_Informacion)
        Me.Controls.Add(Me.Calendario)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmFeriados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administración de Feriados"
        Me.GB_Informacion.ResumeLayout(False)
        Me.GB_Informacion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Calendario As System.Windows.Forms.MonthCalendar
    Friend WithEvents lbl_CantFeriados As System.Windows.Forms.Label
    Friend WithEvents GB_Informacion As System.Windows.Forms.GroupBox
    Friend WithEvents link_Visualizar As System.Windows.Forms.LinkLabel
    Friend WithEvents lbl_Visualizar As System.Windows.Forms.Label
    Friend WithEvents lbl_Cant As System.Windows.Forms.Label
    Friend WithEvents lbl_FechaSeleccionada As System.Windows.Forms.Label
    Friend WithEvents FechaSeleccionada As System.Windows.Forms.Label
    Friend WithEvents Btn_Limpiar As System.Windows.Forms.Button
    Friend WithEvents Btn_Agregar As System.Windows.Forms.Button
End Class
