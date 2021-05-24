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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.Desc_Tigre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Efectivo_Capital = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Desc_Capital = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mayorista = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Alternativa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Habilitado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgProductosError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgProductosError
        '
        Me.dgProductosError.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgProductosError.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgProductosError.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Descripcion_Error, Me.Codigo, Me.Nombre, Me.Categoria, Me.SubCategoria, Me.Proveedor, Me.Origen, Me.Tamaño, Me.Costo, Me.CodigoBarra, Me.Efectivo_Tigre, Me.Desc_Tigre, Me.Efectivo_Capital, Me.Desc_Capital, Me.Mayorista, Me.Alternativa, Me.Descripcion, Me.Habilitado})
        Me.dgProductosError.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgProductosError.Location = New System.Drawing.Point(3, 16)
        Me.dgProductosError.Name = "dgProductosError"
        Me.dgProductosError.ReadOnly = True
        Me.dgProductosError.Size = New System.Drawing.Size(854, 444)
        Me.dgProductosError.TabIndex = 0
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = Global.SistemaCinderella.My.Resources.Recursos.desconectado_32
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(788, 481)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(84, 40)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "Cerrar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.dgProductosError)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(860, 463)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Productos con error de datos"
        '
        'Descripcion_Error
        '
        Me.Descripcion_Error.DataPropertyName = "Descripcion_Error"
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Descripcion_Error.DefaultCellStyle = DataGridViewCellStyle1
        Me.Descripcion_Error.HeaderText = "Descripción Error"
        Me.Descripcion_Error.Name = "Descripcion_Error"
        Me.Descripcion_Error.ReadOnly = True
        Me.Descripcion_Error.Width = 500
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
        Me.CodigoBarra.Width = 93
        '
        'Efectivo_Tigre
        '
        Me.Efectivo_Tigre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Efectivo_Tigre.DataPropertyName = "Efectivo_Tigre"
        DataGridViewCellStyle2.Format = "C2"
        Me.Efectivo_Tigre.DefaultCellStyle = DataGridViewCellStyle2
        Me.Efectivo_Tigre.HeaderText = "Efectivo Tigre"
        Me.Efectivo_Tigre.Name = "Efectivo_Tigre"
        Me.Efectivo_Tigre.ReadOnly = True
        Me.Efectivo_Tigre.Width = 98
        '
        'Desc_Tigre
        '
        Me.Desc_Tigre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Desc_Tigre.DataPropertyName = "Desc_Tigre"
        DataGridViewCellStyle3.Format = "P"
        Me.Desc_Tigre.DefaultCellStyle = DataGridViewCellStyle3
        Me.Desc_Tigre.HeaderText = "Descuento Tigre"
        Me.Desc_Tigre.Name = "Desc_Tigre"
        Me.Desc_Tigre.ReadOnly = True
        Me.Desc_Tigre.Width = 102
        '
        'Efectivo_Capital
        '
        Me.Efectivo_Capital.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Efectivo_Capital.DataPropertyName = "Efectivo_Capital"
        DataGridViewCellStyle4.Format = "C2"
        Me.Efectivo_Capital.DefaultCellStyle = DataGridViewCellStyle4
        Me.Efectivo_Capital.HeaderText = "Efectivo Capital"
        Me.Efectivo_Capital.Name = "Efectivo_Capital"
        Me.Efectivo_Capital.ReadOnly = True
        Me.Efectivo_Capital.Width = 97
        '
        'Desc_Capital
        '
        Me.Desc_Capital.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Desc_Capital.DataPropertyName = "Desc_Capital"
        DataGridViewCellStyle5.Format = "P"
        Me.Desc_Capital.DefaultCellStyle = DataGridViewCellStyle5
        Me.Desc_Capital.HeaderText = "Descuento Capital"
        Me.Desc_Capital.Name = "Desc_Capital"
        Me.Desc_Capital.ReadOnly = True
        Me.Desc_Capital.Width = 109
        '
        'Mayorista
        '
        Me.Mayorista.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Mayorista.DataPropertyName = "Mayorista"
        DataGridViewCellStyle6.Format = "C2"
        Me.Mayorista.DefaultCellStyle = DataGridViewCellStyle6
        Me.Mayorista.HeaderText = "Mayorista"
        Me.Mayorista.Name = "Mayorista"
        Me.Mayorista.ReadOnly = True
        Me.Mayorista.Width = 77
        '
        'Alternativa
        '
        Me.Alternativa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Alternativa.DataPropertyName = "Alternativa"
        DataGridViewCellStyle7.Format = "C2"
        Me.Alternativa.DefaultCellStyle = DataGridViewCellStyle7
        Me.Alternativa.HeaderText = "Alternativa"
        Me.Alternativa.Name = "Alternativa"
        Me.Alternativa.ReadOnly = True
        Me.Alternativa.Width = 82
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
        Me.ClientSize = New System.Drawing.Size(884, 533)
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
    Friend WithEvents Descripcion_Error As DataGridViewTextBoxColumn
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Categoria As DataGridViewTextBoxColumn
    Friend WithEvents SubCategoria As DataGridViewTextBoxColumn
    Friend WithEvents Proveedor As DataGridViewTextBoxColumn
    Friend WithEvents Origen As DataGridViewTextBoxColumn
    Friend WithEvents Tamaño As DataGridViewTextBoxColumn
    Friend WithEvents Costo As DataGridViewTextBoxColumn
    Friend WithEvents CodigoBarra As DataGridViewTextBoxColumn
    Friend WithEvents Efectivo_Tigre As DataGridViewTextBoxColumn
    Friend WithEvents Desc_Tigre As DataGridViewTextBoxColumn
    Friend WithEvents Efectivo_Capital As DataGridViewTextBoxColumn
    Friend WithEvents Desc_Capital As DataGridViewTextBoxColumn
    Friend WithEvents Mayorista As DataGridViewTextBoxColumn
    Friend WithEvents Alternativa As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Habilitado As DataGridViewTextBoxColumn
End Class
