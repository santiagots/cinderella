<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInformeProducto
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInformeProducto))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.chtVentasProducto = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TableLayoutPanel10 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.lblMensajeProducto = New System.Windows.Forms.Label()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ucPaginadoProductos = New SistemaCinderella.Paginado()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.chtVentasProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel10.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.chtVentasProducto, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel10, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(954, 737)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'chtVentasProducto
        '
        ChartArea1.AxisX.LabelStyle.Format = "dd/MM/yy"
        ChartArea1.AxisX.MajorGrid.Enabled = False
        ChartArea1.AxisX.ScaleView.SmallScrollSize = 1.0R
        ChartArea1.AxisX2.MajorGrid.Enabled = False
        ChartArea1.AxisY.ScrollBar.IsPositionedInside = False
        ChartArea1.AxisY2.MajorGrid.Enabled = False
        ChartArea1.CursorX.IsUserEnabled = True
        ChartArea1.CursorX.IsUserSelectionEnabled = True
        ChartArea1.Name = "ChartArea1"
        Me.chtVentasProducto.ChartAreas.Add(ChartArea1)
        Me.chtVentasProducto.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Enabled = False
        Legend1.Name = "Legend1"
        Me.chtVentasProducto.Legends.Add(Legend1)
        Me.chtVentasProducto.Location = New System.Drawing.Point(3, 371)
        Me.chtVentasProducto.Name = "chtVentasProducto"
        Series1.BorderWidth = 3
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.LabelToolTip = "#VAL"
        Series1.Legend = "Legend1"
        Series1.MarkerSize = 6
        Series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle
        Series1.Name = "Series1"
        Series1.ShadowColor = System.Drawing.Color.Silver
        Series1.ToolTip = "#VAL{C} - #VALX"
        Series1.XValueMember = "Fecha"
        Series1.YValueMembers = "Monto"
        Series2.BorderWidth = 3
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series2.Legend = "Legend1"
        Series2.MarkerSize = 6
        Series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle
        Series2.Name = "Series2"
        Series2.ShadowColor = System.Drawing.Color.Silver
        Series2.ToolTip = "#VAL{N}"
        Series2.XValueMember = "Fecha"
        Series2.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary
        Series2.YValueMembers = "Cantidad"
        Me.chtVentasProducto.Series.Add(Series1)
        Me.chtVentasProducto.Series.Add(Series2)
        Me.chtVentasProducto.Size = New System.Drawing.Size(948, 363)
        Me.chtVentasProducto.TabIndex = 17
        Me.chtVentasProducto.Text = "chtVentasProducto"
        Title1.Alignment = System.Drawing.ContentAlignment.TopCenter
        Title1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title1.Name = "Title1"
        Title1.Text = "Ventas"
        Me.chtVentasProducto.Titles.Add(Title1)
        '
        'TableLayoutPanel10
        '
        Me.TableLayoutPanel10.ColumnCount = 1
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel10.Controls.Add(Me.GroupBox6, 0, 0)
        Me.TableLayoutPanel10.Controls.Add(Me.ucPaginadoProductos, 0, 1)
        Me.TableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel10.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel10.Name = "TableLayoutPanel10"
        Me.TableLayoutPanel10.RowCount = 2
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel10.Size = New System.Drawing.Size(948, 362)
        Me.TableLayoutPanel10.TabIndex = 16
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.lblMensajeProducto)
        Me.GroupBox6.Controls.Add(Me.dgvProductos)
        Me.GroupBox6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.GroupBox6.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(942, 306)
        Me.GroupBox6.TabIndex = 2
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Ventas Producto"
        '
        'lblMensajeProducto
        '
        Me.lblMensajeProducto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMensajeProducto.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblMensajeProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensajeProducto.Location = New System.Drawing.Point(52, 143)
        Me.lblMensajeProducto.Name = "lblMensajeProducto"
        Me.lblMensajeProducto.Size = New System.Drawing.Size(865, 52)
        Me.lblMensajeProducto.TabIndex = 14
        Me.lblMensajeProducto.Text = "No se han encontrado datos."
        Me.lblMensajeProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvProductos
        '
        Me.dgvProductos.AllowUserToAddRows = False
        Me.dgvProductos.AllowUserToDeleteRows = False
        Me.dgvProductos.AllowUserToResizeColumns = False
        Me.dgvProductos.AllowUserToResizeRows = False
        Me.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvProductos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.dgvProductos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvProductos.Location = New System.Drawing.Point(3, 18)
        Me.dgvProductos.MultiSelect = False
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.ReadOnly = True
        Me.dgvProductos.RowHeadersVisible = False
        Me.dgvProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProductos.ShowCellErrors = False
        Me.dgvProductos.ShowCellToolTips = False
        Me.dgvProductos.ShowEditingIcon = False
        Me.dgvProductos.ShowRowErrors = False
        Me.dgvProductos.Size = New System.Drawing.Size(936, 285)
        Me.dgvProductos.TabIndex = 10
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Fecha"
        Me.DataGridViewTextBoxColumn10.FillWeight = 102.6978!
        Me.DataGridViewTextBoxColumn10.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Monto"
        DataGridViewCellStyle1.Format = "C2"
        Me.DataGridViewTextBoxColumn11.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn11.FillWeight = 73.54653!
        Me.DataGridViewTextBoxColumn11.HeaderText = "Monto"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Cantidad"
        Me.DataGridViewTextBoxColumn12.FillWeight = 45.0!
        Me.DataGridViewTextBoxColumn12.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'ucPaginadoProductos
        '
        Me.ucPaginadoProductos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ucPaginadoProductos.Location = New System.Drawing.Point(4, 317)
        Me.ucPaginadoProductos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucPaginadoProductos.Name = "ucPaginadoProductos"
        Me.ucPaginadoProductos.OrdenColumna = Nothing
        Me.ucPaginadoProductos.OrdenDireccion = System.Windows.Forms.SortOrder.None
        Me.ucPaginadoProductos.PaginaActual = 0
        Me.ucPaginadoProductos.PaginaTamaño = 1
        Me.ucPaginadoProductos.Size = New System.Drawing.Size(940, 40)
        Me.ucPaginadoProductos.TabIndex = 3
        Me.ucPaginadoProductos.TotalElementos = 0
        '
        'frmInformeProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(954, 737)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmInformeProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informe Producto"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.chtVentasProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel10.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel10 As TableLayoutPanel
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents lblMensajeProducto As Label
    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents ucPaginadoProductos As Paginado
    Friend WithEvents chtVentasProducto As DataVisualization.Charting.Chart
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
End Class
