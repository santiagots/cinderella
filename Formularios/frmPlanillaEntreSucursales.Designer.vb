<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPlanillaEntreSucursales
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPlanillaEntreSucursales))
        Me.DG_Planilla = New System.Windows.Forms.DataGridView()
        Me.ToolPlanilla = New System.Windows.Forms.ToolTip(Me.components)
        Me.GB1 = New System.Windows.Forms.GroupBox()
        Me.DG_Planilla2 = New System.Windows.Forms.DataGridView()
        Me.lbl_Total = New System.Windows.Forms.Label()
        Me.GB2 = New System.Windows.Forms.GroupBox()
        Me.id_Movimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_Sucu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_SucuDestino = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Subtipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VerDetalle = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.DG_Planilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB1.SuspendLayout()
        CType(Me.DG_Planilla2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DG_Planilla
        '
        Me.DG_Planilla.AllowUserToAddRows = False
        Me.DG_Planilla.AllowUserToDeleteRows = False
        Me.DG_Planilla.AllowUserToResizeRows = False
        Me.DG_Planilla.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_Planilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DG_Planilla.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DG_Planilla.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_Planilla.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DG_Planilla.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DG_Planilla.DefaultCellStyle = DataGridViewCellStyle2
        Me.DG_Planilla.GridColor = System.Drawing.SystemColors.ControlText
        Me.DG_Planilla.Location = New System.Drawing.Point(9, 20)
        Me.DG_Planilla.Name = "DG_Planilla"
        Me.DG_Planilla.ReadOnly = True
        Me.DG_Planilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Planilla.Size = New System.Drawing.Size(766, 226)
        Me.DG_Planilla.TabIndex = 11
        '
        'ToolPlanilla
        '
        Me.ToolPlanilla.IsBalloon = True
        Me.ToolPlanilla.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolPlanilla.ToolTipTitle = "Ayuda"
        '
        'GB1
        '
        Me.GB1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB1.Controls.Add(Me.DG_Planilla2)
        Me.GB1.Controls.Add(Me.lbl_Total)
        Me.GB1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB1.Location = New System.Drawing.Point(8, 279)
        Me.GB1.Name = "GB1"
        Me.GB1.Size = New System.Drawing.Size(775, 281)
        Me.GB1.TabIndex = 16
        Me.GB1.TabStop = False
        Me.GB1.Text = "CRÉDITOS DE XXX CON XXX."
        Me.GB1.Visible = False
        '
        'DG_Planilla2
        '
        Me.DG_Planilla2.AllowUserToAddRows = False
        Me.DG_Planilla2.AllowUserToDeleteRows = False
        Me.DG_Planilla2.AllowUserToResizeRows = False
        Me.DG_Planilla2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_Planilla2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_Planilla2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DG_Planilla2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_Planilla2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DG_Planilla2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_Movimiento, Me.id_Sucu, Me.id_SucuDestino, Me.Fecha, Me.Tipo, Me.Subtipo, Me.Monto, Me.VerDetalle})
        Me.DG_Planilla2.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DG_Planilla2.DefaultCellStyle = DataGridViewCellStyle6
        Me.DG_Planilla2.GridColor = System.Drawing.SystemColors.ControlText
        Me.DG_Planilla2.Location = New System.Drawing.Point(9, 27)
        Me.DG_Planilla2.Name = "DG_Planilla2"
        Me.DG_Planilla2.ReadOnly = True
        Me.DG_Planilla2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Planilla2.Size = New System.Drawing.Size(760, 220)
        Me.DG_Planilla2.TabIndex = 12
        '
        'lbl_Total
        '
        Me.lbl_Total.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_Total.AutoSize = True
        Me.lbl_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Total.Location = New System.Drawing.Point(6, 250)
        Me.lbl_Total.Name = "lbl_Total"
        Me.lbl_Total.Size = New System.Drawing.Size(266, 20)
        Me.lbl_Total.TabIndex = 1
        Me.lbl_Total.Text = "TOTAL CRÉDITOS: $ 1500000.-"
        '
        'GB2
        '
        Me.GB2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB2.Controls.Add(Me.DG_Planilla)
        Me.GB2.Location = New System.Drawing.Point(8, 12)
        Me.GB2.Name = "GB2"
        Me.GB2.Size = New System.Drawing.Size(779, 261)
        Me.GB2.TabIndex = 17
        Me.GB2.TabStop = False
        Me.GB2.Text = "CRÉDITOS ENTRE SUCURSALES"
        '
        'id_Movimiento
        '
        Me.id_Movimiento.DataPropertyName = "id_Movimiento"
        Me.id_Movimiento.FillWeight = 110.8629!
        Me.id_Movimiento.HeaderText = "id_Movimiento"
        Me.id_Movimiento.Name = "id_Movimiento"
        Me.id_Movimiento.ReadOnly = True
        '
        'id_Sucu
        '
        Me.id_Sucu.DataPropertyName = "id_Sucursal"
        Me.id_Sucu.HeaderText = "id_Sucu"
        Me.id_Sucu.Name = "id_Sucu"
        Me.id_Sucu.ReadOnly = True
        '
        'id_SucuDestino
        '
        Me.id_SucuDestino.DataPropertyName = "id_SucursalDestino"
        Me.id_SucuDestino.HeaderText = "id_SucuDestino"
        Me.id_SucuDestino.Name = "id_SucuDestino"
        Me.id_SucuDestino.ReadOnly = True
        '
        'Fecha
        '
        Me.Fecha.DataPropertyName = "Fecha"
        Me.Fecha.FillWeight = 110.8629!
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        '
        'Tipo
        '
        Me.Tipo.DataPropertyName = "Tipo"
        Me.Tipo.FillWeight = 110.8629!
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.Name = "Tipo"
        Me.Tipo.ReadOnly = True
        '
        'Subtipo
        '
        Me.Subtipo.DataPropertyName = "Subtipo"
        DataGridViewCellStyle4.NullValue = "-"
        Me.Subtipo.DefaultCellStyle = DataGridViewCellStyle4
        Me.Subtipo.FillWeight = 110.8629!
        Me.Subtipo.HeaderText = "Subtipo"
        Me.Subtipo.Name = "Subtipo"
        Me.Subtipo.ReadOnly = True
        '
        'Monto
        '
        Me.Monto.DataPropertyName = "Monto"
        DataGridViewCellStyle5.Format = "C2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.Monto.DefaultCellStyle = DataGridViewCellStyle5
        Me.Monto.FillWeight = 110.8629!
        Me.Monto.HeaderText = "Monto"
        Me.Monto.Name = "Monto"
        Me.Monto.ReadOnly = True
        '
        'VerDetalle
        '
        Me.VerDetalle.FillWeight = 45.68528!
        Me.VerDetalle.HeaderText = ""
        Me.VerDetalle.Image = Global.SistemaCinderella.My.Resources.Recursos.Detalle_Pequeno
        Me.VerDetalle.Name = "VerDetalle"
        Me.VerDetalle.ReadOnly = True
        Me.VerDetalle.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.VerDetalle.ToolTipText = "Ver Detalle"
        '
        'frmPlanillaEntreSucursales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 572)
        Me.Controls.Add(Me.GB2)
        Me.Controls.Add(Me.GB1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPlanillaEntreSucursales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Planilla de movimientos entre sucursales"
        CType(Me.DG_Planilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB1.ResumeLayout(False)
        Me.GB1.PerformLayout()
        CType(Me.DG_Planilla2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DG_Planilla As System.Windows.Forms.DataGridView
    Friend WithEvents ToolPlanilla As System.Windows.Forms.ToolTip
    Friend WithEvents GB1 As System.Windows.Forms.GroupBox
    Friend WithEvents DG_Planilla2 As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_Total As System.Windows.Forms.Label
    Friend WithEvents GB2 As System.Windows.Forms.GroupBox
    Friend WithEvents id_Movimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_Sucu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_SucuDestino As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Subtipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Monto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VerDetalle As System.Windows.Forms.DataGridViewImageColumn
End Class
