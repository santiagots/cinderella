<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductosPrecios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductosPrecios))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.Cb_Proveedor = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DG_Productos = New System.Windows.Forms.DataGridView()
        Me.id_Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Btn_Finalizar = New System.Windows.Forms.Button()
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DG_Productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btn_Buscar)
        Me.GroupBox1.Controls.Add(Me.Cb_Proveedor)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(670, 81)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione un proveedor de la lista y luego haga click en ""buscar"" para obtener e" &
    "l listado de todos los productos."
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Buscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Buscar.Image = Global.SistemaCinderella.My.Resources.Recursos.IconoBuscar32
        Me.btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Buscar.Location = New System.Drawing.Point(564, 23)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(100, 40)
        Me.btn_Buscar.TabIndex = 2
        Me.btn_Buscar.Text = "Buscar"
        Me.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'Cb_Proveedor
        '
        Me.Cb_Proveedor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cb_Proveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Proveedor.FormattingEnabled = True
        Me.Cb_Proveedor.Location = New System.Drawing.Point(89, 33)
        Me.Cb_Proveedor.Name = "Cb_Proveedor"
        Me.Cb_Proveedor.Size = New System.Drawing.Size(453, 23)
        Me.Cb_Proveedor.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Proveedor"
        '
        'DG_Productos
        '
        Me.DG_Productos.AllowUserToAddRows = False
        Me.DG_Productos.AllowUserToDeleteRows = False
        Me.DG_Productos.AllowUserToResizeColumns = False
        Me.DG_Productos.AllowUserToResizeRows = False
        Me.DG_Productos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_Productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Productos.ColumnHeadersVisible = False
        Me.DG_Productos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_Producto, Me.Nombre, Me.Codigo, Me.Costo, Me.Precio1, Me.Precio2, Me.Precio3, Me.Precio4, Me.Precio5, Me.Precio6})
        Me.DG_Productos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DG_Productos.Location = New System.Drawing.Point(12, 99)
        Me.DG_Productos.Name = "DG_Productos"
        Me.DG_Productos.Size = New System.Drawing.Size(670, 306)
        Me.DG_Productos.TabIndex = 1
        '
        'id_Producto
        '
        Me.id_Producto.FillWeight = 28.5068!
        Me.id_Producto.HeaderText = "id_Producto"
        Me.id_Producto.Name = "id_Producto"
        '
        'Nombre
        '
        Me.Nombre.FillWeight = 319.7969!
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.ToolTipText = "Nombre"
        '
        'Codigo
        '
        Me.Codigo.FillWeight = 124.3166!
        Me.Codigo.HeaderText = "Código"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        Me.Codigo.ToolTipText = "Código"
        '
        'Costo
        '
        Me.Costo.HeaderText = "Costo"
        Me.Costo.Name = "Costo"
        '
        'Precio1
        '
        Me.Precio1.FillWeight = 71.22996!
        Me.Precio1.HeaderText = "Efect. Tigre"
        Me.Precio1.Name = "Precio1"
        Me.Precio1.ToolTipText = "Efectivo Tigre"
        '
        'Precio2
        '
        Me.Precio2.FillWeight = 71.22996!
        Me.Precio2.HeaderText = "Tarj. Tigre"
        Me.Precio2.Name = "Precio2"
        Me.Precio2.ToolTipText = "Tarjeta Tigre"
        '
        'Precio3
        '
        Me.Precio3.FillWeight = 71.22996!
        Me.Precio3.HeaderText = "Efect. Capital"
        Me.Precio3.Name = "Precio3"
        Me.Precio3.ToolTipText = "Efectivo Capital"
        '
        'Precio4
        '
        Me.Precio4.FillWeight = 71.22996!
        Me.Precio4.HeaderText = "Tarj. Capital"
        Me.Precio4.Name = "Precio4"
        Me.Precio4.ToolTipText = "Tarjeta Capital"
        '
        'Precio5
        '
        Me.Precio5.FillWeight = 71.22996!
        Me.Precio5.HeaderText = "Mayorista"
        Me.Precio5.Name = "Precio5"
        Me.Precio5.ToolTipText = "Mayorista"
        '
        'Precio6
        '
        Me.Precio6.FillWeight = 71.22996!
        Me.Precio6.HeaderText = "Alternativa"
        Me.Precio6.Name = "Precio6"
        Me.Precio6.ToolTipText = "Alternativa"
        '
        'Btn_Finalizar
        '
        Me.Btn_Finalizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Finalizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Finalizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Finalizar.Image = Global.SistemaCinderella.My.Resources.Recursos.Editar_24
        Me.Btn_Finalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Finalizar.Location = New System.Drawing.Point(522, 420)
        Me.Btn_Finalizar.Name = "Btn_Finalizar"
        Me.Btn_Finalizar.Size = New System.Drawing.Size(160, 40)
        Me.Btn_Finalizar.TabIndex = 4
        Me.Btn_Finalizar.Text = "Modificar Precios"
        Me.Btn_Finalizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Finalizar.UseVisualStyleBackColor = True
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Cancelar.Image = CType(resources.GetObject("Btn_Cancelar.Image"), System.Drawing.Image)
        Me.Btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Cancelar.Location = New System.Drawing.Point(356, 420)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(160, 40)
        Me.Btn_Cancelar.TabIndex = 3
        Me.Btn_Cancelar.Text = "Cancelar cambios"
        Me.Btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Cancelar.UseVisualStyleBackColor = True
        '
        'frmProductosPrecios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 472)
        Me.Controls.Add(Me.Btn_Cancelar)
        Me.Controls.Add(Me.Btn_Finalizar)
        Me.Controls.Add(Me.DG_Productos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmProductosPrecios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administración de Precios de Productos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DG_Productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Cb_Proveedor As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DG_Productos As System.Windows.Forms.DataGridView
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents Btn_Finalizar As System.Windows.Forms.Button
    Friend WithEvents Btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents id_Producto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Costo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio6 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
