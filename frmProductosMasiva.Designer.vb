<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductosMasiva
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductosMasiva))
        Me.Btn_Procesar = New System.Windows.Forms.Button()
        Me.dgProductos = New System.Windows.Forms.DataGridView()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Origen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tamano = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Categoria = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Subcategoria = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Proveedor = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Material = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Color = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Aroma = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Precio1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Web = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Habilitado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Novedad = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Btn_Limpiar = New System.Windows.Forms.Button()
        CType(Me.dgProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_Procesar
        '
        Me.Btn_Procesar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Procesar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Procesar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Procesar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Procesar.Image = Global.SistemaCinderella.My.Resources.Recursos.Conectado_32
        Me.Btn_Procesar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Procesar.Location = New System.Drawing.Point(680, 515)
        Me.Btn_Procesar.Name = "Btn_Procesar"
        Me.Btn_Procesar.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Procesar.TabIndex = 21
        Me.Btn_Procesar.Text = "Procesar"
        Me.Btn_Procesar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Procesar.UseVisualStyleBackColor = False
        '
        'dgProductos
        '
        Me.dgProductos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgProductos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.Origen, Me.Tamano, Me.Codigo, Me.Costo, Me.Descripcion, Me.Categoria, Me.Subcategoria, Me.Proveedor, Me.Material, Me.Color, Me.Aroma, Me.Precio1, Me.Precio2, Me.Precio3, Me.Precio4, Me.Precio5, Me.Precio6, Me.Web, Me.Habilitado, Me.Novedad})
        Me.dgProductos.Location = New System.Drawing.Point(-4, 2)
        Me.dgProductos.Name = "dgProductos"
        Me.dgProductos.Size = New System.Drawing.Size(784, 497)
        Me.dgProductos.TabIndex = 0
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Width = 80
        '
        'Origen
        '
        Me.Origen.HeaderText = "Origen"
        Me.Origen.Name = "Origen"
        Me.Origen.Width = 80
        '
        'Tamano
        '
        Me.Tamano.HeaderText = "Tamaño"
        Me.Tamano.Name = "Tamano"
        Me.Tamano.Width = 70
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.Width = 80
        '
        'Costo
        '
        Me.Costo.HeaderText = "Costo"
        Me.Costo.Name = "Costo"
        Me.Costo.Width = 60
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        '
        'Categoria
        '
        Me.Categoria.HeaderText = "Categoria"
        Me.Categoria.Name = "Categoria"
        Me.Categoria.Width = 150
        '
        'Subcategoria
        '
        Me.Subcategoria.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Subcategoria.HeaderText = "Subcategoria"
        Me.Subcategoria.Name = "Subcategoria"
        Me.Subcategoria.Width = 150
        '
        'Proveedor
        '
        Me.Proveedor.HeaderText = "Proveedor"
        Me.Proveedor.Name = "Proveedor"
        Me.Proveedor.Width = 150
        '
        'Material
        '
        Me.Material.HeaderText = "Material"
        Me.Material.Name = "Material"
        Me.Material.Width = 150
        '
        'Color
        '
        Me.Color.HeaderText = "Color"
        Me.Color.Name = "Color"
        Me.Color.Width = 150
        '
        'Aroma
        '
        Me.Aroma.HeaderText = "Aroma"
        Me.Aroma.Name = "Aroma"
        Me.Aroma.Width = 150
        '
        'Precio1
        '
        Me.Precio1.HeaderText = "Público Tigre"
        Me.Precio1.Name = "Precio1"
        Me.Precio1.Width = 60
        '
        'Precio2
        '
        Me.Precio2.HeaderText = "Público Sarmiento"
        Me.Precio2.Name = "Precio2"
        Me.Precio2.Width = 60
        '
        'Precio3
        '
        Me.Precio3.HeaderText = "Público Capital"
        Me.Precio3.Name = "Precio3"
        Me.Precio3.Width = 60
        '
        'Precio4
        '
        Me.Precio4.HeaderText = "Mayorista SF"
        Me.Precio4.Name = "Precio4"
        Me.Precio4.Width = 60
        '
        'Precio5
        '
        Me.Precio5.HeaderText = "Mayorista CF"
        Me.Precio5.Name = "Precio5"
        Me.Precio5.Width = 60
        '
        'Precio6
        '
        Me.Precio6.HeaderText = "Mayorista CFR"
        Me.Precio6.Name = "Precio6"
        Me.Precio6.Width = 60
        '
        'Web
        '
        Me.Web.HeaderText = "Web"
        Me.Web.Name = "Web"
        Me.Web.Width = 60
        '
        'Habilitado
        '
        Me.Habilitado.HeaderText = "Habilitado"
        Me.Habilitado.Name = "Habilitado"
        Me.Habilitado.Width = 60
        '
        'Novedad
        '
        Me.Novedad.HeaderText = "Novedad"
        Me.Novedad.Name = "Novedad"
        Me.Novedad.Width = 60
        '
        'Btn_Limpiar
        '
        Me.Btn_Limpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Limpiar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Limpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Limpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Limpiar.Image = Global.SistemaCinderella.My.Resources.Recursos.desconectado_32
        Me.Btn_Limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Limpiar.Location = New System.Drawing.Point(574, 515)
        Me.Btn_Limpiar.Name = "Btn_Limpiar"
        Me.Btn_Limpiar.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Limpiar.TabIndex = 22
        Me.Btn_Limpiar.Text = "Limpiar"
        Me.Btn_Limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Limpiar.UseVisualStyleBackColor = False
        '
        'frmProductosMasiva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.Btn_Limpiar)
        Me.Controls.Add(Me.Btn_Procesar)
        Me.Controls.Add(Me.dgProductos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmProductosMasiva"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administración de Productos | Alta Masiva"
        CType(Me.dgProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgProductos As System.Windows.Forms.DataGridView
    Friend WithEvents Btn_Procesar As System.Windows.Forms.Button
    Friend WithEvents Btn_Limpiar As System.Windows.Forms.Button
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Origen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tamano As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Costo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Categoria As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Subcategoria As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Proveedor As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Material As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Color As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Aroma As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Precio1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Web As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Habilitado As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Novedad As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
