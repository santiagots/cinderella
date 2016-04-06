<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNotaPedidoAdministracion
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNotaPedidoAdministracion))
        Me.dgvNotaPedidos = New System.Windows.Forms.DataGridView()
        Me.IdTipoVentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdTipoPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpleadoNombreyApellidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Eliminar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.NotaPedidoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label12 = New System.Windows.Forms.Label()
        Me.BtnFiltrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.chkSinSalida = New System.Windows.Forms.CheckBox()
        Me.chkDepositado = New System.Windows.Forms.CheckBox()
        Me.chkPasado = New System.Windows.Forms.CheckBox()
        Me.chkDevuelto = New System.Windows.Forms.CheckBox()
        Me.chkOtros = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_Restablecer = New System.Windows.Forms.Button()
        Me.cmbVendedor = New System.Windows.Forms.ComboBox()
        Me.txtNombreCliente = New System.Windows.Forms.TextBox()
        Me.cmbTiposPago = New System.Windows.Forms.ComboBox()
        Me.cmbTipoVenta = New System.Windows.Forms.ComboBox()
        CType(Me.dgvNotaPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NotaPedidoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvNotaPedidos
        '
        Me.dgvNotaPedidos.AllowUserToAddRows = False
        Me.dgvNotaPedidos.AllowUserToDeleteRows = False
        Me.dgvNotaPedidos.AllowUserToResizeColumns = False
        Me.dgvNotaPedidos.AllowUserToResizeRows = False
        Me.dgvNotaPedidos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvNotaPedidos.AutoGenerateColumns = False
        Me.dgvNotaPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvNotaPedidos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvNotaPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNotaPedidos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdTipoVentaDataGridViewTextBoxColumn, Me.IdTipoPagoDataGridViewTextBoxColumn, Me.EmpleadoNombreyApellidoDataGridViewTextBoxColumn, Me.NombreCliente, Me.PrecioTotalDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.Eliminar})
        Me.dgvNotaPedidos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvNotaPedidos.DataSource = Me.NotaPedidoBindingSource
        Me.dgvNotaPedidos.Location = New System.Drawing.Point(12, 149)
        Me.dgvNotaPedidos.MultiSelect = False
        Me.dgvNotaPedidos.Name = "dgvNotaPedidos"
        Me.dgvNotaPedidos.ReadOnly = True
        Me.dgvNotaPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvNotaPedidos.Size = New System.Drawing.Size(760, 501)
        Me.dgvNotaPedidos.TabIndex = 0
        '
        'IdTipoVentaDataGridViewTextBoxColumn
        '
        Me.IdTipoVentaDataGridViewTextBoxColumn.DataPropertyName = "TipoVentaDescripcion"
        Me.IdTipoVentaDataGridViewTextBoxColumn.HeaderText = "TIPO VENTA"
        Me.IdTipoVentaDataGridViewTextBoxColumn.Name = "IdTipoVentaDataGridViewTextBoxColumn"
        Me.IdTipoVentaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdTipoPagoDataGridViewTextBoxColumn
        '
        Me.IdTipoPagoDataGridViewTextBoxColumn.DataPropertyName = "TipoPagoDescripcion"
        Me.IdTipoPagoDataGridViewTextBoxColumn.HeaderText = "TIPO PAGO"
        Me.IdTipoPagoDataGridViewTextBoxColumn.Name = "IdTipoPagoDataGridViewTextBoxColumn"
        Me.IdTipoPagoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmpleadoNombreyApellidoDataGridViewTextBoxColumn
        '
        Me.EmpleadoNombreyApellidoDataGridViewTextBoxColumn.DataPropertyName = "EmpleadoNombreyApellido"
        Me.EmpleadoNombreyApellidoDataGridViewTextBoxColumn.HeaderText = "VENDEDOR"
        Me.EmpleadoNombreyApellidoDataGridViewTextBoxColumn.Name = "EmpleadoNombreyApellidoDataGridViewTextBoxColumn"
        Me.EmpleadoNombreyApellidoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreCliente
        '
        Me.NombreCliente.HeaderText = "NOMBRE CLIENTE"
        Me.NombreCliente.Name = "NombreCliente"
        Me.NombreCliente.ReadOnly = True
        '
        'PrecioTotalDataGridViewTextBoxColumn
        '
        Me.PrecioTotalDataGridViewTextBoxColumn.DataPropertyName = "PrecioTotal"
        Me.PrecioTotalDataGridViewTextBoxColumn.HeaderText = "PRECIO TOTAL"
        Me.PrecioTotalDataGridViewTextBoxColumn.Name = "PrecioTotalDataGridViewTextBoxColumn"
        Me.PrecioTotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "FECHA"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "ELIMINAR"
        Me.Eliminar.Image = Global.SistemaCinderella.My.Resources.Recursos.Boton_Eliminar
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'NotaPedidoBindingSource
        '
        Me.NotaPedidoBindingSource.DataSource = GetType(Entidades.NotaPedido)
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(452, 56)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 16)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "Nombre"
        '
        'BtnFiltrar
        '
        Me.BtnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFiltrar.FlatAppearance.BorderSize = 0
        Me.BtnFiltrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFiltrar.Image = Global.SistemaCinderella.My.Resources.Recursos.IconoBuscar32
        Me.BtnFiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnFiltrar.Location = New System.Drawing.Point(654, 85)
        Me.BtnFiltrar.Name = "BtnFiltrar"
        Me.BtnFiltrar.Size = New System.Drawing.Size(100, 40)
        Me.BtnFiltrar.TabIndex = 23
        Me.BtnFiltrar.Text = "Buscar"
        Me.BtnFiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnFiltrar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 16)
        Me.Label1.TabIndex = 112
        Me.Label1.Text = "Tipo de Venta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 16)
        Me.Label2.TabIndex = 122
        Me.Label2.Text = "Tipo de Pago"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(452, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 16)
        Me.Label3.TabIndex = 142
        Me.Label3.Text = "Vendedor"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(8, 192)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(110, 16)
        Me.Label31.TabIndex = 423
        Me.Label31.Text = "Destino Salida"
        '
        'chkSinSalida
        '
        Me.chkSinSalida.AutoSize = True
        Me.chkSinSalida.Checked = True
        Me.chkSinSalida.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSinSalida.Location = New System.Drawing.Point(154, 192)
        Me.chkSinSalida.Name = "chkSinSalida"
        Me.chkSinSalida.Size = New System.Drawing.Size(82, 19)
        Me.chkSinSalida.TabIndex = 420
        Me.chkSinSalida.Text = "Sin Salida"
        Me.chkSinSalida.UseVisualStyleBackColor = True
        '
        'chkDepositado
        '
        Me.chkDepositado.AutoSize = True
        Me.chkDepositado.Checked = True
        Me.chkDepositado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDepositado.Location = New System.Drawing.Point(241, 192)
        Me.chkDepositado.Name = "chkDepositado"
        Me.chkDepositado.Size = New System.Drawing.Size(89, 19)
        Me.chkDepositado.TabIndex = 421
        Me.chkDepositado.Text = "Depositado"
        Me.chkDepositado.UseVisualStyleBackColor = True
        '
        'chkPasado
        '
        Me.chkPasado.AutoSize = True
        Me.chkPasado.Checked = True
        Me.chkPasado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPasado.Location = New System.Drawing.Point(336, 192)
        Me.chkPasado.Name = "chkPasado"
        Me.chkPasado.Size = New System.Drawing.Size(68, 19)
        Me.chkPasado.TabIndex = 422
        Me.chkPasado.Text = "Pasado"
        Me.chkPasado.UseVisualStyleBackColor = True
        '
        'chkDevuelto
        '
        Me.chkDevuelto.AutoSize = True
        Me.chkDevuelto.Checked = True
        Me.chkDevuelto.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDevuelto.Location = New System.Drawing.Point(410, 192)
        Me.chkDevuelto.Name = "chkDevuelto"
        Me.chkDevuelto.Size = New System.Drawing.Size(74, 19)
        Me.chkDevuelto.TabIndex = 424
        Me.chkDevuelto.Text = "Devuelto"
        Me.chkDevuelto.UseVisualStyleBackColor = True
        '
        'chkOtros
        '
        Me.chkOtros.AutoSize = True
        Me.chkOtros.Checked = True
        Me.chkOtros.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkOtros.Location = New System.Drawing.Point(490, 192)
        Me.chkOtros.Name = "chkOtros"
        Me.chkOtros.Size = New System.Drawing.Size(55, 19)
        Me.chkOtros.TabIndex = 425
        Me.chkOtros.Text = "Otros"
        Me.chkOtros.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btn_Restablecer)
        Me.GroupBox1.Controls.Add(Me.cmbVendedor)
        Me.GroupBox1.Controls.Add(Me.txtNombreCliente)
        Me.GroupBox1.Controls.Add(Me.cmbTiposPago)
        Me.GroupBox1.Controls.Add(Me.cmbTipoVenta)
        Me.GroupBox1.Controls.Add(Me.chkOtros)
        Me.GroupBox1.Controls.Add(Me.chkDevuelto)
        Me.GroupBox1.Controls.Add(Me.chkPasado)
        Me.GroupBox1.Controls.Add(Me.chkDepositado)
        Me.GroupBox1.Controls.Add(Me.chkSinSalida)
        Me.GroupBox1.Controls.Add(Me.Label31)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.BtnFiltrar)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(760, 131)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtrar Nota Pedido"
        '
        'btn_Restablecer
        '
        Me.btn_Restablecer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Restablecer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Restablecer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Restablecer.Location = New System.Drawing.Point(548, 85)
        Me.btn_Restablecer.Name = "btn_Restablecer"
        Me.btn_Restablecer.Size = New System.Drawing.Size(100, 40)
        Me.btn_Restablecer.TabIndex = 431
        Me.btn_Restablecer.Text = "Restablecer Busqueda"
        Me.btn_Restablecer.UseVisualStyleBackColor = True
        '
        'cmbVendedor
        '
        Me.cmbVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbVendedor.FormattingEnabled = True
        Me.cmbVendedor.Items.AddRange(New Object() {"Seleccione un tipo de venta...", "Minorista", "Mayorista"})
        Me.cmbVendedor.Location = New System.Drawing.Point(554, 24)
        Me.cmbVendedor.Name = "cmbVendedor"
        Me.cmbVendedor.Size = New System.Drawing.Size(200, 23)
        Me.cmbVendedor.TabIndex = 430
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreCliente.Location = New System.Drawing.Point(554, 52)
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.Size = New System.Drawing.Size(200, 21)
        Me.txtNombreCliente.TabIndex = 429
        '
        'cmbTiposPago
        '
        Me.cmbTiposPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTiposPago.FormattingEnabled = True
        Me.cmbTiposPago.Location = New System.Drawing.Point(120, 53)
        Me.cmbTiposPago.Name = "cmbTiposPago"
        Me.cmbTiposPago.Size = New System.Drawing.Size(200, 23)
        Me.cmbTiposPago.TabIndex = 427
        '
        'cmbTipoVenta
        '
        Me.cmbTipoVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoVenta.FormattingEnabled = True
        Me.cmbTipoVenta.Items.AddRange(New Object() {"Seleccione un tipo de venta...", "Minorista", "Mayorista"})
        Me.cmbTipoVenta.Location = New System.Drawing.Point(120, 24)
        Me.cmbTipoVenta.Name = "cmbTipoVenta"
        Me.cmbTipoVenta.Size = New System.Drawing.Size(200, 23)
        Me.cmbTipoVenta.TabIndex = 426
        '
        'frmNotaPedidoAdministracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 662)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvNotaPedidos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmNotaPedidoAdministracion"
        Me.Text = "Administracion Nota Pedido"
        CType(Me.dgvNotaPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NotaPedidoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvNotaPedidos As System.Windows.Forms.DataGridView
    Friend WithEvents NotaPedidoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents BtnFiltrar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents chkSinSalida As System.Windows.Forms.CheckBox
    Friend WithEvents chkDepositado As System.Windows.Forms.CheckBox
    Friend WithEvents chkPasado As System.Windows.Forms.CheckBox
    Friend WithEvents chkDevuelto As System.Windows.Forms.CheckBox
    Friend WithEvents chkOtros As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNombreCliente As System.Windows.Forms.TextBox
    Friend WithEvents cmbTiposPago As System.Windows.Forms.ComboBox
    Friend WithEvents cmbTipoVenta As System.Windows.Forms.ComboBox
    Friend WithEvents cmbVendedor As System.Windows.Forms.ComboBox
    Friend WithEvents btn_Restablecer As System.Windows.Forms.Button
    Friend WithEvents IdTipoVentaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdTipoPagoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmpleadoNombreyApellidoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioTotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewImageColumn
End Class
