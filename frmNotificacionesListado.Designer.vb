<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNotificacionesListado
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNotificacionesListado))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Gb_Detalle = New System.Windows.Forms.GroupBox()
        Me.lblAceptado = New System.Windows.Forms.Label()
        Me.lblMonto = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblComentarios = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblSucursal = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.DG_Notificaciones = New System.Windows.Forms.DataGridView()
        Me.ToolNotif = New System.Windows.Forms.ToolTip(Me.components)
        Me.id_Movimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_Subtipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_Sucursal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sucursal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Aceptado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Comentarios = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Comentario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Aceptar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Eliminar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.Gb_Detalle.SuspendLayout()
        CType(Me.DG_Notificaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Gb_Detalle)
        Me.GroupBox1.Controls.Add(Me.Btn_Cancelar)
        Me.GroupBox1.Controls.Add(Me.DG_Notificaciones)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(620, 505)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Debajo se listarán todas las notificaciones. Generalmente serán movimientos que l" & _
    "levaron a cabo otras sucursales con ésta sucursal. Deberán ser ""aceptadas"" para " & _
    "que surjan efecto."
        '
        'Gb_Detalle
        '
        Me.Gb_Detalle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Gb_Detalle.Controls.Add(Me.lblAceptado)
        Me.Gb_Detalle.Controls.Add(Me.lblMonto)
        Me.Gb_Detalle.Controls.Add(Me.Label7)
        Me.Gb_Detalle.Controls.Add(Me.Label2)
        Me.Gb_Detalle.Controls.Add(Me.Label4)
        Me.Gb_Detalle.Controls.Add(Me.lblComentarios)
        Me.Gb_Detalle.Controls.Add(Me.lblDescripcion)
        Me.Gb_Detalle.Controls.Add(Me.lblTipo)
        Me.Gb_Detalle.Controls.Add(Me.Label6)
        Me.Gb_Detalle.Controls.Add(Me.Label5)
        Me.Gb_Detalle.Controls.Add(Me.lblSucursal)
        Me.Gb_Detalle.Controls.Add(Me.Label3)
        Me.Gb_Detalle.Controls.Add(Me.lblFecha)
        Me.Gb_Detalle.Controls.Add(Me.Label1)
        Me.Gb_Detalle.Location = New System.Drawing.Point(10, 365)
        Me.Gb_Detalle.Name = "Gb_Detalle"
        Me.Gb_Detalle.Size = New System.Drawing.Size(494, 133)
        Me.Gb_Detalle.TabIndex = 17
        Me.Gb_Detalle.TabStop = False
        Me.Gb_Detalle.Text = "Detalle del movimiento seleccionado"
        Me.Gb_Detalle.Visible = False
        '
        'lblAceptado
        '
        Me.lblAceptado.AutoSize = True
        Me.lblAceptado.Location = New System.Drawing.Point(96, 104)
        Me.lblAceptado.Name = "lblAceptado"
        Me.lblAceptado.Size = New System.Drawing.Size(25, 15)
        Me.lblAceptado.TabIndex = 13
        Me.lblAceptado.Text = "- - -"
        '
        'lblMonto
        '
        Me.lblMonto.AutoSize = True
        Me.lblMonto.Location = New System.Drawing.Point(96, 88)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(25, 15)
        Me.lblMonto.TabIndex = 12
        Me.lblMonto.Text = "- - -"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 15)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Aceptado:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 15)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Monto:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(279, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Comentarios:"
        '
        'lblComentarios
        '
        Me.lblComentarios.Location = New System.Drawing.Point(279, 39)
        Me.lblComentarios.MaximumSize = New System.Drawing.Size(200, 80)
        Me.lblComentarios.Name = "lblComentarios"
        Me.lblComentarios.Size = New System.Drawing.Size(200, 80)
        Me.lblComentarios.TabIndex = 8
        Me.lblComentarios.Text = "Sin comentarios."
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(96, 72)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(25, 15)
        Me.lblDescripcion.TabIndex = 7
        Me.lblDescripcion.Text = "- - -"
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Location = New System.Drawing.Point(96, 56)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(25, 15)
        Me.lblTipo.TabIndex = 6
        Me.lblTipo.Text = "- - -"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Descripción:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tipo:"
        '
        'lblSucursal
        '
        Me.lblSucursal.AutoSize = True
        Me.lblSucursal.Location = New System.Drawing.Point(96, 40)
        Me.lblSucursal.Name = "lblSucursal"
        Me.lblSucursal.Size = New System.Drawing.Size(25, 15)
        Me.lblSucursal.TabIndex = 3
        Me.lblSucursal.Text = "- - -"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Sucursal:"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(96, 24)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(25, 15)
        Me.lblFecha.TabIndex = 1
        Me.lblFecha.Text = "- - -"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha:"
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Cancelar.Image = Global.SistemaCinderella.My.Resources.Recursos.desconectado_32
        Me.Btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Cancelar.Location = New System.Drawing.Point(510, 415)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Cancelar.TabIndex = 16
        Me.Btn_Cancelar.Text = "Cerrar"
        Me.Btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolNotif.SetToolTip(Me.Btn_Cancelar, "Cerrar ventana de notificaciones.")
        Me.Btn_Cancelar.UseVisualStyleBackColor = True
        '
        'DG_Notificaciones
        '
        Me.DG_Notificaciones.AllowUserToAddRows = False
        Me.DG_Notificaciones.AllowUserToDeleteRows = False
        Me.DG_Notificaciones.AllowUserToResizeRows = False
        Me.DG_Notificaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_Notificaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_Notificaciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DG_Notificaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_Movimiento, Me.id_Tipo, Me.id_Subtipo, Me.id_Sucursal, Me.Fecha, Me.Sucursal, Me.Tipo, Me.Descripcion, Me.Monto, Me.Aceptado, Me.Comentarios, Me.Comentario, Me.Aceptar, Me.Eliminar})
        Me.DG_Notificaciones.Location = New System.Drawing.Point(10, 34)
        Me.DG_Notificaciones.MultiSelect = False
        Me.DG_Notificaciones.Name = "DG_Notificaciones"
        Me.DG_Notificaciones.ReadOnly = True
        Me.DG_Notificaciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DG_Notificaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Notificaciones.Size = New System.Drawing.Size(600, 325)
        Me.DG_Notificaciones.TabIndex = 0
        '
        'ToolNotif
        '
        Me.ToolNotif.IsBalloon = True
        Me.ToolNotif.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolNotif.ToolTipTitle = "Ayuda"
        '
        'id_Movimiento
        '
        Me.id_Movimiento.FillWeight = 108.6396!
        Me.id_Movimiento.HeaderText = "id_Movimiento"
        Me.id_Movimiento.Name = "id_Movimiento"
        Me.id_Movimiento.ReadOnly = True
        '
        'id_Tipo
        '
        Me.id_Tipo.FillWeight = 98.27411!
        Me.id_Tipo.HeaderText = "id_Tipo"
        Me.id_Tipo.Name = "id_Tipo"
        Me.id_Tipo.ReadOnly = True
        '
        'id_Subtipo
        '
        Me.id_Subtipo.HeaderText = "id_Subtipo"
        Me.id_Subtipo.Name = "id_Subtipo"
        Me.id_Subtipo.ReadOnly = True
        Me.id_Subtipo.Visible = False
        '
        'id_Sucursal
        '
        Me.id_Sucursal.FillWeight = 98.27411!
        Me.id_Sucursal.HeaderText = "id_Sucursal"
        Me.id_Sucursal.Name = "id_Sucursal"
        Me.id_Sucursal.ReadOnly = True
        '
        'Fecha
        '
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Fecha.DefaultCellStyle = DataGridViewCellStyle1
        Me.Fecha.FillWeight = 108.6396!
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        '
        'Sucursal
        '
        Me.Sucursal.FillWeight = 108.6396!
        Me.Sucursal.HeaderText = "Sucursal"
        Me.Sucursal.Name = "Sucursal"
        Me.Sucursal.ReadOnly = True
        '
        'Tipo
        '
        Me.Tipo.FillWeight = 108.6396!
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.Name = "Tipo"
        Me.Tipo.ReadOnly = True
        '
        'Descripcion
        '
        Me.Descripcion.FillWeight = 108.6396!
        Me.Descripcion.HeaderText = "Descripción"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        '
        'Monto
        '
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Monto.DefaultCellStyle = DataGridViewCellStyle2
        Me.Monto.FillWeight = 108.6396!
        Me.Monto.HeaderText = "Monto"
        Me.Monto.Name = "Monto"
        Me.Monto.ReadOnly = True
        '
        'Aceptado
        '
        Me.Aceptado.FillWeight = 94.44729!
        Me.Aceptado.HeaderText = "Aceptad"
        Me.Aceptado.Name = "Aceptado"
        Me.Aceptado.ReadOnly = True
        '
        'Comentarios
        '
        Me.Comentarios.HeaderText = "Comentarios"
        Me.Comentarios.Name = "Comentarios"
        Me.Comentarios.ReadOnly = True
        '
        'Comentario
        '
        Me.Comentario.FillWeight = 40.0!
        Me.Comentario.HeaderText = ""
        Me.Comentario.Name = "Comentario"
        Me.Comentario.ReadOnly = True
        '
        'Aceptar
        '
        Me.Aceptar.FillWeight = 40.0!
        Me.Aceptar.HeaderText = ""
        Me.Aceptar.Name = "Aceptar"
        Me.Aceptar.ReadOnly = True
        Me.Aceptar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Eliminar
        '
        Me.Eliminar.FillWeight = 40.0!
        Me.Eliminar.HeaderText = ""
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'frmNotificacionesListado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 522)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNotificacionesListado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Notificaciones de la Sucursal"
        Me.GroupBox1.ResumeLayout(False)
        Me.Gb_Detalle.ResumeLayout(False)
        Me.Gb_Detalle.PerformLayout()
        CType(Me.DG_Notificaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DG_Notificaciones As System.Windows.Forms.DataGridView
    Friend WithEvents Btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents ToolNotif As System.Windows.Forms.ToolTip
    Friend WithEvents Gb_Detalle As System.Windows.Forms.GroupBox
    Friend WithEvents lblAceptado As System.Windows.Forms.Label
    Friend WithEvents lblMonto As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblComentarios As System.Windows.Forms.Label
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblSucursal As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents id_Movimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_Tipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_Subtipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_Sucursal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sucursal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Monto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Aceptado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Comentarios As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Comentario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Aceptar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
