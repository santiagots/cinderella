<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarCodigoProducto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscarCodigoProducto))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_Msg = New System.Windows.Forms.Label()
        Me.Btn_Limpiar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_informacion = New System.Windows.Forms.Label()
        Me.DG_Productos = New System.Windows.Forms.DataGridView()
        Me.id_Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Habilitado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_Buscar = New System.Windows.Forms.TextBox()
        Me.ErrorProductos = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolBusqueda = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.DG_Productos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_Msg)
        Me.GroupBox1.Controls.Add(Me.Btn_Limpiar)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lbl_informacion)
        Me.GroupBox1.Controls.Add(Me.DG_Productos)
        Me.GroupBox1.Controls.Add(Me.btn_Buscar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_Buscar)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(570, 348)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar Producto"
        '
        'lbl_Msg
        '
        Me.lbl_Msg.AutoSize = True
        Me.lbl_Msg.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lbl_Msg.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Msg.Location = New System.Drawing.Point(86, 212)
        Me.lbl_Msg.Name = "lbl_Msg"
        Me.lbl_Msg.Size = New System.Drawing.Size(399, 29)
        Me.lbl_Msg.TabIndex = 12
        Me.lbl_Msg.Text = "No se han encontrado productos."
        '
        'Btn_Limpiar
        '
        Me.Btn_Limpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Limpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Limpiar.Image = Global.SistemaCinderella.My.Resources.Recursos.desconectado_32
        Me.Btn_Limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Limpiar.Location = New System.Drawing.Point(388, 65)
        Me.Btn_Limpiar.Name = "Btn_Limpiar"
        Me.Btn_Limpiar.Size = New System.Drawing.Size(85, 40)
        Me.Btn_Limpiar.TabIndex = 9
        Me.Btn_Limpiar.Text = "Limpiar"
        Me.Btn_Limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolBusqueda.SetToolTip(Me.Btn_Limpiar, "Limpia la grilla y los criterios de busqueda. Se vuelven a visualizar todos los p" & _
                "roductos.")
        Me.Btn_Limpiar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(232, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "La operación puede tardar unos minutos."
        '
        'lbl_informacion
        '
        Me.lbl_informacion.AutoSize = True
        Me.lbl_informacion.Location = New System.Drawing.Point(6, 26)
        Me.lbl_informacion.Name = "lbl_informacion"
        Me.lbl_informacion.Size = New System.Drawing.Size(514, 15)
        Me.lbl_informacion.TabIndex = 4
        Me.lbl_informacion.Text = "Por favor, complete el siguiente campo con el nombre de producto y luego presione" & _
            " ""Buscar""."
        '
        'DG_Productos
        '
        Me.DG_Productos.AllowUserToAddRows = False
        Me.DG_Productos.AllowUserToDeleteRows = False
        Me.DG_Productos.AllowUserToResizeColumns = False
        Me.DG_Productos.AllowUserToResizeRows = False
        Me.DG_Productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Productos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_Producto, Me.Nombre, Me.Codigo, Me.Habilitado})
        Me.DG_Productos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DG_Productos.Location = New System.Drawing.Point(9, 111)
        Me.DG_Productos.MultiSelect = False
        Me.DG_Productos.Name = "DG_Productos"
        Me.DG_Productos.ReadOnly = True
        Me.DG_Productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Productos.Size = New System.Drawing.Size(555, 221)
        Me.DG_Productos.TabIndex = 3
        '
        'id_Producto
        '
        Me.id_Producto.DataPropertyName = "id_Producto"
        Me.id_Producto.FillWeight = 52.11506!
        Me.id_Producto.HeaderText = "ID"
        Me.id_Producto.Name = "id_Producto"
        Me.id_Producto.ReadOnly = True
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.FillWeight = 243.6548!
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Codigo
        '
        Me.Codigo.DataPropertyName = "Codigo"
        Me.Codigo.FillWeight = 52.11506!
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        '
        'Habilitado
        '
        Me.Habilitado.DataPropertyName = "Habilitado"
        Me.Habilitado.FillWeight = 52.11506!
        Me.Habilitado.HeaderText = "Habilitado"
        Me.Habilitado.Name = "Habilitado"
        Me.Habilitado.ReadOnly = True
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Buscar.Image = Global.SistemaCinderella.My.Resources.Recursos.IconoBuscar32
        Me.btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Buscar.Location = New System.Drawing.Point(479, 65)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(85, 40)
        Me.btn_Buscar.TabIndex = 2
        Me.btn_Buscar.Text = "Buscar"
        Me.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolBusqueda.SetToolTip(Me.btn_Buscar, "Busca productos que posean en su nombre el criterio ingresado.")
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre"
        '
        'txt_Buscar
        '
        Me.txt_Buscar.Location = New System.Drawing.Point(66, 75)
        Me.txt_Buscar.Name = "txt_Buscar"
        Me.txt_Buscar.Size = New System.Drawing.Size(244, 21)
        Me.txt_Buscar.TabIndex = 1
        Me.ToolBusqueda.SetToolTip(Me.txt_Buscar, "Usted puede realizar una busqueda por palabra completa  o parte de ella.")
        '
        'ErrorProductos
        '
        Me.ErrorProductos.BlinkRate = 200
        Me.ErrorProductos.ContainerControl = Me
        '
        'ToolBusqueda
        '
        Me.ToolBusqueda.IsBalloon = True
        Me.ToolBusqueda.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolBusqueda.ToolTipTitle = "Ayuda"
        '
        'frmBuscarCodigoProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 372)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmBuscarCodigoProducto"
        Me.Text = "Buscar Código de Producto"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DG_Productos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_Buscar As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DG_Productos As System.Windows.Forms.DataGridView
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents ErrorProductos As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_informacion As System.Windows.Forms.Label
    Friend WithEvents id_Producto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Habilitado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolBusqueda As System.Windows.Forms.ToolTip
    Friend WithEvents Btn_Limpiar As System.Windows.Forms.Button
    Friend WithEvents lbl_Msg As System.Windows.Forms.Label
End Class
