<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMailBandeja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMailBandeja))
        Me.Gb_Mail = New System.Windows.Forms.GroupBox()
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.DG_Mensajes = New System.Windows.Forms.DataGridView()
        Me.id_Mensaje = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Remitente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Asunto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Leido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Eliminar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Gb_Mail.SuspendLayout()
        CType(Me.DG_Mensajes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Gb_Mail
        '
        Me.Gb_Mail.Controls.Add(Me.Btn_Cancelar)
        Me.Gb_Mail.Controls.Add(Me.DG_Mensajes)
        Me.Gb_Mail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Gb_Mail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gb_Mail.Location = New System.Drawing.Point(0, 0)
        Me.Gb_Mail.Name = "Gb_Mail"
        Me.Gb_Mail.Size = New System.Drawing.Size(594, 472)
        Me.Gb_Mail.TabIndex = 0
        Me.Gb_Mail.TabStop = False
        Me.Gb_Mail.Text = "Bandeja de entrada de los mensajes recibidos."
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Cancelar.Image = Global.SistemaCinderella.My.Resources.Recursos.desconectado_32
        Me.Btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Cancelar.Location = New System.Drawing.Point(482, 426)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Cancelar.TabIndex = 5
        Me.Btn_Cancelar.Text = "Cerrar"
        Me.Btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Cancelar.UseVisualStyleBackColor = True
        '
        'DG_Mensajes
        '
        Me.DG_Mensajes.AllowUserToAddRows = False
        Me.DG_Mensajes.AllowUserToDeleteRows = False
        Me.DG_Mensajes.AllowUserToResizeColumns = False
        Me.DG_Mensajes.AllowUserToResizeRows = False
        Me.DG_Mensajes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_Mensajes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_Mensajes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DG_Mensajes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_Mensaje, Me.Remitente, Me.Asunto, Me.Leido, Me.Fecha, Me.Eliminar})
        Me.DG_Mensajes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DG_Mensajes.Location = New System.Drawing.Point(14, 23)
        Me.DG_Mensajes.Name = "DG_Mensajes"
        Me.DG_Mensajes.ReadOnly = True
        Me.DG_Mensajes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Mensajes.Size = New System.Drawing.Size(566, 397)
        Me.DG_Mensajes.TabIndex = 0
        '
        'id_Mensaje
        '
        Me.id_Mensaje.DataPropertyName = "id_Mensaje"
        Me.id_Mensaje.HeaderText = "-"
        Me.id_Mensaje.Name = "id_Mensaje"
        Me.id_Mensaje.ReadOnly = True
        Me.id_Mensaje.Visible = False
        '
        'Remitente
        '
        Me.Remitente.DataPropertyName = "Usuario"
        Me.Remitente.FillWeight = 130.1395!
        Me.Remitente.HeaderText = "Remitente"
        Me.Remitente.Name = "Remitente"
        Me.Remitente.ReadOnly = True
        '
        'Asunto
        '
        Me.Asunto.DataPropertyName = "Asunto"
        Me.Asunto.FillWeight = 130.1395!
        Me.Asunto.HeaderText = "Asunto"
        Me.Asunto.Name = "Asunto"
        Me.Asunto.ReadOnly = True
        '
        'Leido
        '
        Me.Leido.DataPropertyName = "Leido"
        Me.Leido.FillWeight = 50.76142!
        Me.Leido.HeaderText = "Leido"
        Me.Leido.Name = "Leido"
        Me.Leido.ReadOnly = True
        '
        'Fecha
        '
        Me.Fecha.DataPropertyName = "Fecha"
        Me.Fecha.FillWeight = 130.1395!
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        '
        'Eliminar
        '
        Me.Eliminar.FillWeight = 58.82011!
        Me.Eliminar.HeaderText = ""
        Me.Eliminar.Image = Global.SistemaCinderella.My.Resources.Recursos.Boton_Eliminar
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'frmMailBandeja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 472)
        Me.Controls.Add(Me.Gb_Mail)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMailBandeja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Centro de Mensajes | Bandeja de Entrada"
        Me.Gb_Mail.ResumeLayout(False)
        CType(Me.DG_Mensajes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Gb_Mail As System.Windows.Forms.GroupBox
    Friend WithEvents DG_Mensajes As System.Windows.Forms.DataGridView
    Friend WithEvents Btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents id_Mensaje As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Remitente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Asunto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Leido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewImageColumn
End Class
