<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductosErrorImportar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductosErrorImportar))
        Me.dgProductosError = New System.Windows.Forms.DataGridView()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Descripcion_Error = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubCategoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Origen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tamaño = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoBarra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Efectivo_Tigre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tarjeta_Tigre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Efectivo_Capital = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tarjeta_Capital = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mayor_SF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mayor_CF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Habilitado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgProductosError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgProductosError
        '
        Me.dgProductosError.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgProductosError.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Descripcion_Error, Me.Codigo, Me.Nombre, Me.Categoria, Me.SubCategoria, Me.Proveedor, Me.Origen, Me.Tamaño, Me.Costo, Me.CodigoBarra, Me.Efectivo_Tigre, Me.Tarjeta_Tigre, Me.Efectivo_Capital, Me.Tarjeta_Capital, Me.Mayor_SF, Me.Mayor_CF, Me.Descripcion, Me.Habilitado})
        Me.dgProductosError.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgProductosError.Location = New System.Drawing.Point(3, 16)
        Me.dgProductosError.Name = "dgProductosError"
        Me.dgProductosError.Size = New System.Drawing.Size(584, 454)
        Me.dgProductosError.TabIndex = 0
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = Global.SistemaCinderella.My.Resources.Recursos.desconectado_32
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(502, 491)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 40)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgProductosError)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(590, 473)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Productos con error de datos"
        '
        'Descripcion_Error
        '
        Me.Descripcion_Error.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Descripcion_Error.DataPropertyName = "Descripcion_Error"
        Me.Descripcion_Error.HeaderText = "Descripción Error"
        Me.Descripcion_Error.Name = "Descripcion_Error"
        Me.Descripcion_Error.Width = 104
        '
        'Codigo
        '
        Me.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Codigo.DataPropertyName = "Codigo"
        Me.Codigo.HeaderText = "Código"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        Me.Codigo.Width = 65
        '
        'Nombre
        '
        Me.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 69
        '
        'Categoria
        '
        Me.Categoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Categoria.DataPropertyName = "Categoria"
        Me.Categoria.HeaderText = "Categoría"
        Me.Categoria.Name = "Categoria"
        Me.Categoria.ReadOnly = True
        Me.Categoria.Width = 79
        '
        'SubCategoria
        '
        Me.SubCategoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SubCategoria.DataPropertyName = "SubCategoria"
        Me.SubCategoria.HeaderText = "Subcategoría"
        Me.SubCategoria.Name = "SubCategoria"
        Me.SubCategoria.ReadOnly = True
        Me.SubCategoria.Width = 97
        '
        'Proveedor
        '
        Me.Proveedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Proveedor.DataPropertyName = "Proveedor"
        Me.Proveedor.HeaderText = "Proveedor"
        Me.Proveedor.Name = "Proveedor"
        Me.Proveedor.ReadOnly = True
        Me.Proveedor.Width = 81
        '
        'Origen
        '
        Me.Origen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Origen.DataPropertyName = "Origen"
        Me.Origen.HeaderText = "Origen"
        Me.Origen.Name = "Origen"
        Me.Origen.ReadOnly = True
        Me.Origen.Width = 63
        '
        'Tamaño
        '
        Me.Tamaño.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Tamaño.DataPropertyName = "Tamaño"
        Me.Tamaño.HeaderText = "Tamaño"
        Me.Tamaño.Name = "Tamaño"
        Me.Tamaño.ReadOnly = True
        Me.Tamaño.Width = 71
        '
        'Costo
        '
        Me.Costo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Costo.DataPropertyName = "Costo"
        Me.Costo.HeaderText = "Costo"
        Me.Costo.Name = "Costo"
        Me.Costo.ReadOnly = True
        Me.Costo.Width = 59
        '
        'CodigoBarra
        '
        Me.CodigoBarra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CodigoBarra.DataPropertyName = "CodigoBarra"
        Me.CodigoBarra.HeaderText = "Codigo Barra"
        Me.CodigoBarra.Name = "CodigoBarra"
        Me.CodigoBarra.ReadOnly = True
        Me.CodigoBarra.Width = 86
        '
        'Efectivo_Tigre
        '
        Me.Efectivo_Tigre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Efectivo_Tigre.DataPropertyName = "Efectivo_Tigre"
        Me.Efectivo_Tigre.HeaderText = "Efectivo Tigre"
        Me.Efectivo_Tigre.Name = "Efectivo_Tigre"
        Me.Efectivo_Tigre.ReadOnly = True
        Me.Efectivo_Tigre.Width = 90
        '
        'Tarjeta_Tigre
        '
        Me.Tarjeta_Tigre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Tarjeta_Tigre.DataPropertyName = "Tarjeta_Tigre"
        Me.Tarjeta_Tigre.HeaderText = "Tarjeta Tigre"
        Me.Tarjeta_Tigre.Name = "Tarjeta_Tigre"
        Me.Tarjeta_Tigre.ReadOnly = True
        Me.Tarjeta_Tigre.Width = 85
        '
        'Efectivo_Capital
        '
        Me.Efectivo_Capital.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Efectivo_Capital.DataPropertyName = "Efectivo_Capital"
        Me.Efectivo_Capital.HeaderText = "Efectivo Capital"
        Me.Efectivo_Capital.Name = "Efectivo_Capital"
        Me.Efectivo_Capital.ReadOnly = True
        Me.Efectivo_Capital.Width = 97
        '
        'Tarjeta_Capital
        '
        Me.Tarjeta_Capital.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Tarjeta_Capital.DataPropertyName = "Tarjeta_Capital"
        Me.Tarjeta_Capital.HeaderText = "Tarjeta Capital"
        Me.Tarjeta_Capital.Name = "Tarjeta_Capital"
        Me.Tarjeta_Capital.ReadOnly = True
        Me.Tarjeta_Capital.Width = 92
        '
        'Mayor_SF
        '
        Me.Mayor_SF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Mayor_SF.DataPropertyName = "Mayor_SF"
        Me.Mayor_SF.HeaderText = "Mayor SF"
        Me.Mayor_SF.Name = "Mayor_SF"
        Me.Mayor_SF.ReadOnly = True
        Me.Mayor_SF.Width = 71
        '
        'Mayor_CF
        '
        Me.Mayor_CF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Mayor_CF.DataPropertyName = "Mayor_CF"
        Me.Mayor_CF.HeaderText = "Mayor CF"
        Me.Mayor_CF.Name = "Mayor_CF"
        Me.Mayor_CF.ReadOnly = True
        Me.Mayor_CF.Width = 71
        '
        'Descripcion
        '
        Me.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Descripcion.DataPropertyName = "Descripcion"
        Me.Descripcion.HeaderText = "Descripción"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Width = 88
        '
        'Habilitado
        '
        Me.Habilitado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Habilitado.DataPropertyName = "Habilitado"
        Me.Habilitado.HeaderText = "Habilitado"
        Me.Habilitado.Name = "Habilitado"
        Me.Habilitado.ReadOnly = True
        Me.Habilitado.Width = 79
        '
        'frmProductosErrorImportar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 543)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmProductosErrorImportar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Productos con Errores en Importación"
        CType(Me.dgProductosError, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgProductosError As System.Windows.Forms.DataGridView
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Descripcion_Error As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Categoria As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubCategoria As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Proveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Origen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tamaño As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Costo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoBarra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Efectivo_Tigre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tarjeta_Tigre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Efectivo_Capital As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tarjeta_Capital As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Mayor_SF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Mayor_CF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Habilitado As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
