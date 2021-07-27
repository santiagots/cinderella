<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockEnNotaPedido
    Inherits Comun

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
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.dgvMovimientosDetalle = New System.Windows.Forms.DataGridView()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroNotaPedidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Detalle = New System.Windows.Forms.DataGridViewImageColumn()
        Me.StockEnNotaPedidoItemViewModelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Paginado = New SistemaCinderella.Paginado()
        Me.GroupBox.SuspendLayout()
        CType(Me.dgvMovimientosDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockEnNotaPedidoItemViewModelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox
        '
        Me.GroupBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox.Controls.Add(Me.dgvMovimientosDetalle)
        Me.GroupBox.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(618, 559)
        Me.GroupBox.TabIndex = 1
        Me.GroupBox.TabStop = False
        Me.GroupBox.Text = "Notas de Pedido"
        '
        'dgvMovimientosDetalle
        '
        Me.dgvMovimientosDetalle.AllowUserToAddRows = False
        Me.dgvMovimientosDetalle.AllowUserToDeleteRows = False
        Me.dgvMovimientosDetalle.AllowUserToResizeColumns = False
        Me.dgvMovimientosDetalle.AllowUserToResizeRows = False
        Me.dgvMovimientosDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvMovimientosDetalle.AutoGenerateColumns = False
        Me.dgvMovimientosDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMovimientosDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMovimientosDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Fecha, Me.NumeroNotaPedidoDataGridViewTextBoxColumn, Me.ClienteDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn, Me.Estado, Me.Detalle})
        Me.dgvMovimientosDetalle.DataSource = Me.StockEnNotaPedidoItemViewModelBindingSource
        Me.dgvMovimientosDetalle.Location = New System.Drawing.Point(3, 16)
        Me.dgvMovimientosDetalle.MultiSelect = False
        Me.dgvMovimientosDetalle.Name = "dgvMovimientosDetalle"
        Me.dgvMovimientosDetalle.ReadOnly = True
        Me.dgvMovimientosDetalle.RowHeadersVisible = False
        Me.dgvMovimientosDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMovimientosDetalle.Size = New System.Drawing.Size(612, 540)
        Me.dgvMovimientosDetalle.TabIndex = 0
        '
        'Fecha
        '
        Me.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Fecha.DataPropertyName = "Fecha"
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Width = 62
        '
        'NumeroNotaPedidoDataGridViewTextBoxColumn
        '
        Me.NumeroNotaPedidoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.NumeroNotaPedidoDataGridViewTextBoxColumn.DataPropertyName = "NumeroNotaPedido"
        Me.NumeroNotaPedidoDataGridViewTextBoxColumn.HeaderText = "Nro. N. Pedido"
        Me.NumeroNotaPedidoDataGridViewTextBoxColumn.MinimumWidth = 105
        Me.NumeroNotaPedidoDataGridViewTextBoxColumn.Name = "NumeroNotaPedidoDataGridViewTextBoxColumn"
        Me.NumeroNotaPedidoDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumeroNotaPedidoDataGridViewTextBoxColumn.Width = 105
        '
        'ClienteDataGridViewTextBoxColumn
        '
        Me.ClienteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ClienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn.Name = "ClienteDataGridViewTextBoxColumn"
        Me.ClienteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        Me.CantidadDataGridViewTextBoxColumn.ReadOnly = True
        Me.CantidadDataGridViewTextBoxColumn.Width = 74
        '
        'Estado
        '
        Me.Estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Estado.DataPropertyName = "Estado"
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        Me.Estado.Width = 65
        '
        'Detalle
        '
        Me.Detalle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Detalle.HeaderText = ""
        Me.Detalle.Image = Global.SistemaCinderella.My.Resources.Recursos.IconoBuscar24
        Me.Detalle.Name = "Detalle"
        Me.Detalle.ReadOnly = True
        Me.Detalle.Width = 5
        '
        'StockEnNotaPedidoItemViewModelBindingSource
        '
        Me.StockEnNotaPedidoItemViewModelBindingSource.DataSource = GetType(SistemaCinderella.Formularios.Stock.StockEnNotaPedidoItemViewModel)
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = Global.SistemaCinderella.My.Resources.Recursos.desconectado_32
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(541, 574)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(86, 46)
        Me.btnCancelar.TabIndex = 9
        Me.btnCancelar.Text = "Cerrar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'Paginado
        '
        Me.Paginado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Paginado.Leyenda = "{0} de {1}"
        Me.Paginado.Location = New System.Drawing.Point(15, 574)
        Me.Paginado.Name = "Paginado"
        Me.Paginado.PaginaActual = 1
        Me.Paginado.Size = New System.Drawing.Size(520, 27)
        Me.Paginado.TabIndex = 24
        Me.Paginado.TotalElementos = 0
        '
        'frmStockEnNotaPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 623)
        Me.Controls.Add(Me.Paginado)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.GroupBox)
        Me.Name = "frmStockEnNotaPedido"
        Me.ShowIcon = False
        Me.Text = "Notas de Pedido"
        Me.GroupBox.ResumeLayout(False)
        CType(Me.dgvMovimientosDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockEnNotaPedidoItemViewModelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox As GroupBox
    Friend WithEvents dgvMovimientosDetalle As DataGridView
    Friend WithEvents btnCancelar As Button
    Friend WithEvents StockEnNotaPedidoItemViewModelBindingSource As BindingSource
    Friend WithEvents Paginado As Paginado
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents NumeroNotaPedidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents Detalle As DataGridViewImageColumn
End Class
