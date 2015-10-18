<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMovimientoPlanilla
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMovimientoPlanilla))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.CbMeses = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CbAnios = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CbTipo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DG_Movimientos = New System.Windows.Forms.DataGridView()
        Me.ToolMov = New System.Windows.Forms.ToolTip(Me.components)
        Me.id_Movimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VerDetalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Eliminar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DG_Movimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.DG_Movimientos)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(670, 448)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "A continuación podrá visualizar un listado de todos los movimientos realizados en" & _
    " la sucursal."
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.BtnBuscar)
        Me.GroupBox2.Controls.Add(Me.CbMeses)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.CbAnios)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.CbTipo)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 22)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(658, 65)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtros de Busqueda"
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Image = Global.SistemaCinderella.My.Resources.Recursos.desconectado_32
        Me.Button1.Location = New System.Drawing.Point(568, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 40)
        Me.Button1.TabIndex = 7
        Me.ToolMov.SetToolTip(Me.Button1, "haz click aquí para restablecer los filtros y el listado de movimientos.")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBuscar.Image = Global.SistemaCinderella.My.Resources.Recursos.IconoBuscar32
        Me.BtnBuscar.Location = New System.Drawing.Point(612, 19)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(40, 40)
        Me.BtnBuscar.TabIndex = 6
        Me.ToolMov.SetToolTip(Me.BtnBuscar, "Haz click aquí para buscar movimientos con los criterios de busqueda seleccionado" & _
        "s.")
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'CbMeses
        '
        Me.CbMeses.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CbMeses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbMeses.FormattingEnabled = True
        Me.CbMeses.Location = New System.Drawing.Point(178, 29)
        Me.CbMeses.Name = "CbMeses"
        Me.CbMeses.Size = New System.Drawing.Size(90, 23)
        Me.CbMeses.TabIndex = 5
        Me.ToolMov.SetToolTip(Me.CbMeses, "Puede refinar los movimientos teniendo en cuenta en que mes se realizaron.")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(141, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Mes"
        '
        'CbAnios
        '
        Me.CbAnios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CbAnios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbAnios.FormattingEnabled = True
        Me.CbAnios.Location = New System.Drawing.Point(40, 29)
        Me.CbAnios.Name = "CbAnios"
        Me.CbAnios.Size = New System.Drawing.Size(80, 23)
        Me.CbAnios.TabIndex = 3
        Me.ToolMov.SetToolTip(Me.CbAnios, "Puede refinar los movimientos teniendo en cuenta en que año se realizaron.")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Año"
        '
        'CbTipo
        '
        Me.CbTipo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbTipo.FormattingEnabled = True
        Me.CbTipo.Items.AddRange(New Object() {"Todos los movimientos", "Diferencias de Caja", "Egresos", "Gastos", "Impuestos", "Movimiento de Socio", "Caja Fuerte"})
        Me.CbTipo.Location = New System.Drawing.Point(402, 29)
        Me.CbTipo.Name = "CbTipo"
        Me.CbTipo.Size = New System.Drawing.Size(160, 23)
        Me.CbTipo.TabIndex = 1
        Me.ToolMov.SetToolTip(Me.CbTipo, "Puede refinar los movimientos seleccionando que tipo desea visualizar aquí.")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(281, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tipo de movimiento"
        '
        'DG_Movimientos
        '
        Me.DG_Movimientos.AllowUserToAddRows = False
        Me.DG_Movimientos.AllowUserToDeleteRows = False
        Me.DG_Movimientos.AllowUserToResizeRows = False
        Me.DG_Movimientos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_Movimientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_Movimientos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DG_Movimientos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_Movimiento, Me.Fecha, Me.Tipo, Me.Descripcion, Me.Monto, Me.VerDetalle, Me.Eliminar})
        Me.DG_Movimientos.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.DG_Movimientos.Location = New System.Drawing.Point(6, 92)
        Me.DG_Movimientos.MultiSelect = False
        Me.DG_Movimientos.Name = "DG_Movimientos"
        Me.DG_Movimientos.ReadOnly = True
        Me.DG_Movimientos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DG_Movimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Movimientos.Size = New System.Drawing.Size(658, 350)
        Me.DG_Movimientos.TabIndex = 2
        '
        'ToolMov
        '
        Me.ToolMov.IsBalloon = True
        Me.ToolMov.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolMov.ToolTipTitle = "Ayuda"
        '
        'id_Movimiento
        '
        Me.id_Movimiento.FillWeight = 55.56035!
        Me.id_Movimiento.HeaderText = "id_Movimiento"
        Me.id_Movimiento.Name = "id_Movimiento"
        Me.id_Movimiento.ReadOnly = True
        Me.id_Movimiento.Visible = False
        '
        'Fecha
        '
        Me.Fecha.FillWeight = 90.7573!
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        '
        'Tipo
        '
        Me.Tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.Name = "Tipo"
        Me.Tipo.ReadOnly = True
        Me.Tipo.Width = 56
        '
        'Descripcion
        '
        Me.Descripcion.FillWeight = 223.2513!
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        '
        'Monto
        '
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Monto.DefaultCellStyle = DataGridViewCellStyle1
        Me.Monto.FillWeight = 80.0!
        Me.Monto.HeaderText = "Monto"
        Me.Monto.Name = "Monto"
        Me.Monto.ReadOnly = True
        '
        'VerDetalle
        '
        Me.VerDetalle.FillWeight = 39.74121!
        Me.VerDetalle.HeaderText = ""
        Me.VerDetalle.Name = "VerDetalle"
        Me.VerDetalle.ReadOnly = True
        Me.VerDetalle.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Eliminar
        '
        Me.Eliminar.FillWeight = 39.59391!
        Me.Eliminar.HeaderText = ""
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'frmMovimientoPlanilla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 472)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMovimientoPlanilla"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Movimientos | Listado"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DG_Movimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DG_Movimientos As System.Windows.Forms.DataGridView
    Friend WithEvents ToolMov As System.Windows.Forms.ToolTip
    Friend WithEvents CbMeses As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CbAnios As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents id_Movimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Monto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VerDetalle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
