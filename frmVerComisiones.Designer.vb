<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVerComisiones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVerComisiones))
        Me.Gb_Comisiones = New System.Windows.Forms.GroupBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.DG_Comisiones = New System.Windows.Forms.DataGridView()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Porcentaje = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Comision = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio_Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.Gb_Comisiones.TabIndex = 0
        Me.Gb_Comisiones.TabStop = False
        Me.Gb_Comisiones.Text = "Comisiones registradas"
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = Global.SistemaCinderella.My.Resources.Recursos.desconectado_32
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(387, 376)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 40)
        Me.btnCancelar.TabIndex = 5
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
        Me.DG_Comisiones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Fecha, Me.Porcentaje, Me.Comision, Me.Precio_Total})
        Me.DG_Comisiones.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DG_Comisiones.Location = New System.Drawing.Point(7, 23)
        Me.DG_Comisiones.Name = "DG_Comisiones"
        Me.DG_Comisiones.ReadOnly = True
        Me.DG_Comisiones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Comisiones.Size = New System.Drawing.Size(480, 350)
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
        'Porcentaje
        '
        Me.Porcentaje.DataPropertyName = "Comision"
        Me.Porcentaje.FillWeight = 111.9289!
        Me.Porcentaje.HeaderText = "Porcentaje"
        Me.Porcentaje.Name = "Porcentaje"
        Me.Porcentaje.ReadOnly = True
        '
        'Comision
        '
        Me.Comision.DataPropertyName = "Monto"
        Me.Comision.FillWeight = 111.9289!
        Me.Comision.HeaderText = "Comision"
        Me.Comision.Name = "Comision"
        Me.Comision.ReadOnly = True
        '
        'Precio_Total
        '
        Me.Precio_Total.DataPropertyName = "Precio_Total"
        Me.Precio_Total.HeaderText = "Monto de la Venta"
        Me.Precio_Total.Name = "Precio_Total"
        Me.Precio_Total.ReadOnly = True
        '
        'frmVerComisiones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 422)
        Me.Controls.Add(Me.Gb_Comisiones)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVerComisiones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Comisiones"
        Me.Gb_Comisiones.ResumeLayout(False)
        CType(Me.DG_Comisiones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Gb_Comisiones As System.Windows.Forms.GroupBox
    Friend WithEvents DG_Comisiones As System.Windows.Forms.DataGridView
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Porcentaje As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Comision As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio_Total As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
