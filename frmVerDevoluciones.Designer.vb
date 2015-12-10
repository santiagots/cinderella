<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVerDevoluciones
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Gb_Comisiones = New System.Windows.Forms.GroupBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.DG_Comisiones = New System.Windows.Forms.DataGridView()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo_Pago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_devolucion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Gb_Comisiones.SuspendLayout()
        CType(Me.DG_Comisiones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Gb_Comisiones
        '
        Me.Gb_Comisiones.Controls.Add(Me.btnCancelar)
        Me.Gb_Comisiones.Controls.Add(Me.DG_Comisiones)
        Me.Gb_Comisiones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Gb_Comisiones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gb_Comisiones.Location = New System.Drawing.Point(0, 0)
        Me.Gb_Comisiones.Name = "Gb_Comisiones"
        Me.Gb_Comisiones.Size = New System.Drawing.Size(494, 422)
        Me.Gb_Comisiones.TabIndex = 7
        Me.Gb_Comisiones.TabStop = False
        Me.Gb_Comisiones.Text = "Devoluciones registradas"
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = Global.SistemaCinderella.My.Resources.Recursos.desconectado_32
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(370, 369)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(117, 46)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'DG_Comisiones
        '
        Me.DG_Comisiones.AllowUserToAddRows = False
        Me.DG_Comisiones.AllowUserToDeleteRows = False
        Me.DG_Comisiones.AllowUserToResizeRows = False
        Me.DG_Comisiones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_Comisiones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_Comisiones.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DG_Comisiones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DG_Comisiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Comisiones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Fecha, Me.Monto, Me.Tipo_Pago, Me.id_devolucion})
        Me.DG_Comisiones.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DG_Comisiones.Location = New System.Drawing.Point(7, 23)
        Me.DG_Comisiones.Name = "DG_Comisiones"
        Me.DG_Comisiones.ReadOnly = True
        Me.DG_Comisiones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DG_Comisiones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Comisiones.Size = New System.Drawing.Size(480, 340)
        Me.DG_Comisiones.TabIndex = 0
        '
        'Fecha
        '
        Me.Fecha.DataPropertyName = "Fecha"
        Me.Fecha.FillWeight = 76.14214!
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        '
        'Monto
        '
        Me.Monto.DataPropertyName = "Precio_Total"
        Me.Monto.FillWeight = 111.9289!
        Me.Monto.HeaderText = "Monto de la Devolución"
        Me.Monto.Name = "Monto"
        Me.Monto.ReadOnly = True
        '
        'Tipo_Pago
        '
        Me.Tipo_Pago.DataPropertyName = "Tipo_Pago"
        Me.Tipo_Pago.HeaderText = "Forma de Pago"
        Me.Tipo_Pago.Name = "Tipo_Pago"
        Me.Tipo_Pago.ReadOnly = True
        '
        'id_devolucion
        '
        Me.id_devolucion.DataPropertyName = "id_devolucion"
        Me.id_devolucion.HeaderText = "id_devolucion"
        Me.id_devolucion.Name = "id_devolucion"
        Me.id_devolucion.ReadOnly = True
        Me.id_devolucion.Visible = False
        '
        'frmVerDevoluciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 422)
        Me.Controls.Add(Me.Gb_Comisiones)
        Me.Name = "frmVerDevoluciones"
        Me.Text = "Devoluciones"
        Me.Gb_Comisiones.ResumeLayout(False)
        CType(Me.DG_Comisiones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Gb_Comisiones As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents DG_Comisiones As System.Windows.Forms.DataGridView
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Monto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tipo_Pago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_devolucion As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
