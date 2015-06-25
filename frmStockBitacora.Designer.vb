<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockBitacora
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStockBitacora))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_Total = New System.Windows.Forms.TextBox()
        Me.lbl_DescrTot = New System.Windows.Forms.Label()
        Me.FechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.FechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Cb_Sucursal = New System.Windows.Forms.ComboBox()
        Me.lbl_Msg = New System.Windows.Forms.Label()
        Me.btn_Restablecer = New System.Windows.Forms.Button()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.DG_Stock = New System.Windows.Forms.DataGridView()
        Me.PRODUCTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Empleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Accion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Minimo_Ant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Optimo_Ant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Actual_Ant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Minimo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Actual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Optimo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DG_Stock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txt_Total)
        Me.GroupBox1.Controls.Add(Me.lbl_DescrTot)
        Me.GroupBox1.Controls.Add(Me.FechaHasta)
        Me.GroupBox1.Controls.Add(Me.FechaDesde)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Cb_Sucursal)
        Me.GroupBox1.Controls.Add(Me.lbl_Msg)
        Me.GroupBox1.Controls.Add(Me.btn_Restablecer)
        Me.GroupBox1.Controls.Add(Me.btn_Buscar)
        Me.GroupBox1.Controls.Add(Me.DG_Stock)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(620, 454)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(443, 412)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(26, 29)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "$"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Total
        '
        Me.txt_Total.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Total.Location = New System.Drawing.Point(475, 409)
        Me.txt_Total.Name = "txt_Total"
        Me.txt_Total.ReadOnly = True
        Me.txt_Total.Size = New System.Drawing.Size(139, 35)
        Me.txt_Total.TabIndex = 23
        Me.txt_Total.Text = "0,00"
        Me.txt_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_DescrTot
        '
        Me.lbl_DescrTot.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_DescrTot.AutoSize = True
        Me.lbl_DescrTot.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DescrTot.Location = New System.Drawing.Point(329, 412)
        Me.lbl_DescrTot.Name = "lbl_DescrTot"
        Me.lbl_DescrTot.Size = New System.Drawing.Size(98, 29)
        Me.lbl_DescrTot.TabIndex = 22
        Me.lbl_DescrTot.Text = "TOTAL:"
        '
        'FechaHasta
        '
        Me.FechaHasta.Location = New System.Drawing.Point(117, 79)
        Me.FechaHasta.Name = "FechaHasta"
        Me.FechaHasta.Size = New System.Drawing.Size(227, 21)
        Me.FechaHasta.TabIndex = 3
        '
        'FechaDesde
        '
        Me.FechaDesde.Location = New System.Drawing.Point(117, 51)
        Me.FechaDesde.Name = "FechaDesde"
        Me.FechaDesde.Size = New System.Drawing.Size(227, 21)
        Me.FechaDesde.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 15)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Fecha Hasta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 15)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Fecha Desde"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 15)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Sucursal"
        '
        'Cb_Sucursal
        '
        Me.Cb_Sucursal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cb_Sucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Sucursal.FormattingEnabled = True
        Me.Cb_Sucursal.Items.AddRange(New Object() {"Mes Completo", "Primera Quincena", "Segunda Quincena"})
        Me.Cb_Sucursal.Location = New System.Drawing.Point(117, 22)
        Me.Cb_Sucursal.Name = "Cb_Sucursal"
        Me.Cb_Sucursal.Size = New System.Drawing.Size(227, 23)
        Me.Cb_Sucursal.TabIndex = 1
        '
        'lbl_Msg
        '
        Me.lbl_Msg.AutoSize = True
        Me.lbl_Msg.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lbl_Msg.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Msg.Location = New System.Drawing.Point(83, 231)
        Me.lbl_Msg.Name = "lbl_Msg"
        Me.lbl_Msg.Size = New System.Drawing.Size(458, 29)
        Me.lbl_Msg.TabIndex = 4
        Me.lbl_Msg.Text = "No se ha encontrado stocks cargados."
        '
        'btn_Restablecer
        '
        Me.btn_Restablecer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Restablecer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Restablecer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Restablecer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Restablecer.Location = New System.Drawing.Point(514, 71)
        Me.btn_Restablecer.Name = "btn_Restablecer"
        Me.btn_Restablecer.Size = New System.Drawing.Size(100, 40)
        Me.btn_Restablecer.TabIndex = 5
        Me.btn_Restablecer.Text = "Restablecer Filtros"
        Me.btn_Restablecer.UseVisualStyleBackColor = True
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Buscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Buscar.Image = Global.SistemaCinderella.My.Resources.Recursos.IconoBuscar32
        Me.btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Buscar.Location = New System.Drawing.Point(514, 22)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(100, 40)
        Me.btn_Buscar.TabIndex = 4
        Me.btn_Buscar.Text = "Buscar"
        Me.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'DG_Stock
        '
        Me.DG_Stock.AllowUserToAddRows = False
        Me.DG_Stock.AllowUserToDeleteRows = False
        Me.DG_Stock.AllowUserToResizeRows = False
        Me.DG_Stock.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_Stock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_Stock.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PRODUCTO, Me.Empleado, Me.Subtotal, Me.Costo, Me.Codigo, Me.Fecha, Me.Accion, Me.Minimo_Ant, Me.Optimo_Ant, Me.Actual_Ant, Me.Minimo, Me.Actual, Me.Optimo})
        Me.DG_Stock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DG_Stock.Location = New System.Drawing.Point(6, 127)
        Me.DG_Stock.MultiSelect = False
        Me.DG_Stock.Name = "DG_Stock"
        Me.DG_Stock.ReadOnly = True
        Me.DG_Stock.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DG_Stock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Stock.Size = New System.Drawing.Size(608, 273)
        Me.DG_Stock.TabIndex = 6
        '
        'PRODUCTO
        '
        Me.PRODUCTO.DataPropertyName = "Nombre"
        Me.PRODUCTO.FillWeight = 145.4872!
        Me.PRODUCTO.HeaderText = "Producto"
        Me.PRODUCTO.Name = "PRODUCTO"
        Me.PRODUCTO.ReadOnly = True
        Me.PRODUCTO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Empleado
        '
        Me.Empleado.DataPropertyName = "Usuario"
        Me.Empleado.HeaderText = "Empleado"
        Me.Empleado.Name = "Empleado"
        Me.Empleado.ReadOnly = True
        '
        'Subtotal
        '
        Me.Subtotal.DataPropertyName = "Subtotal"
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Subtotal.DefaultCellStyle = DataGridViewCellStyle1
        Me.Subtotal.HeaderText = "Subtotal"
        Me.Subtotal.Name = "Subtotal"
        Me.Subtotal.ReadOnly = True
        '
        'Costo
        '
        Me.Costo.DataPropertyName = "Costo"
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Costo.DefaultCellStyle = DataGridViewCellStyle2
        Me.Costo.HeaderText = "Costo"
        Me.Costo.Name = "Costo"
        Me.Costo.ReadOnly = True
        '
        'Codigo
        '
        Me.Codigo.DataPropertyName = "Codigo"
        Me.Codigo.FillWeight = 145.4872!
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        Me.Codigo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Fecha
        '
        Me.Fecha.DataPropertyName = "Fecha"
        Me.Fecha.FillWeight = 145.4872!
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Accion
        '
        Me.Accion.DataPropertyName = "Accion"
        Me.Accion.HeaderText = "Accion"
        Me.Accion.Name = "Accion"
        Me.Accion.ReadOnly = True
        '
        'Minimo_Ant
        '
        Me.Minimo_Ant.DataPropertyName = "Stock_Minimo_Ant"
        Me.Minimo_Ant.HeaderText = "Minimo (Ant.)"
        Me.Minimo_Ant.Name = "Minimo_Ant"
        Me.Minimo_Ant.ReadOnly = True
        '
        'Optimo_Ant
        '
        Me.Optimo_Ant.DataPropertyName = "Stock_Optimo_Ant"
        Me.Optimo_Ant.HeaderText = "Optimo (Ant.)"
        Me.Optimo_Ant.Name = "Optimo_Ant"
        Me.Optimo_Ant.ReadOnly = True
        '
        'Actual_Ant
        '
        Me.Actual_Ant.DataPropertyName = "Stock_Actual_Ant"
        Me.Actual_Ant.HeaderText = "Actual (Ant.)"
        Me.Actual_Ant.Name = "Actual_Ant"
        Me.Actual_Ant.ReadOnly = True
        '
        'Minimo
        '
        Me.Minimo.DataPropertyName = "Stock_Minimo"
        DataGridViewCellStyle3.Format = "N0"
        DataGridViewCellStyle3.NullValue = "0"
        Me.Minimo.DefaultCellStyle = DataGridViewCellStyle3
        Me.Minimo.FillWeight = 68.06424!
        Me.Minimo.HeaderText = "Minimo"
        Me.Minimo.Name = "Minimo"
        Me.Minimo.ReadOnly = True
        Me.Minimo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Actual
        '
        Me.Actual.DataPropertyName = "Stock_Actual"
        DataGridViewCellStyle4.Format = "N0"
        DataGridViewCellStyle4.NullValue = "0"
        Me.Actual.DefaultCellStyle = DataGridViewCellStyle4
        Me.Actual.FillWeight = 66.77616!
        Me.Actual.HeaderText = "Actual"
        Me.Actual.Name = "Actual"
        Me.Actual.ReadOnly = True
        Me.Actual.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Optimo
        '
        Me.Optimo.DataPropertyName = "Stock_Optimo"
        DataGridViewCellStyle5.Format = "N0"
        DataGridViewCellStyle5.NullValue = "0"
        Me.Optimo.DefaultCellStyle = DataGridViewCellStyle5
        Me.Optimo.FillWeight = 65.48048!
        Me.Optimo.HeaderText = "Optimo"
        Me.Optimo.Name = "Optimo"
        Me.Optimo.ReadOnly = True
        Me.Optimo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'frmStockBitacora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 472)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmStockBitacora"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de Stocks Modificados / Eliminados"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DG_Stock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Msg As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Cb_Sucursal As System.Windows.Forms.ComboBox
    Friend WithEvents btn_Restablecer As System.Windows.Forms.Button
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents DG_Stock As System.Windows.Forms.DataGridView
    Friend WithEvents FechaHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents FechaDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_Total As System.Windows.Forms.TextBox
    Friend WithEvents lbl_DescrTot As System.Windows.Forms.Label
    Friend WithEvents PRODUCTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Empleado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Subtotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Costo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Accion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Minimo_Ant As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Optimo_Ant As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Actual_Ant As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Minimo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Actual As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Optimo As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
