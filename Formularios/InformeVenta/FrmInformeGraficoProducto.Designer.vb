<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInformeGraficoProducto
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
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title2 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title3 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title4 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea5 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend5 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title5 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea6 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend6 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title6 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInformeGraficoProducto))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.chtTopSubcategoriaCantidad = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.chtTopCategoriaMonto = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.chtTopSubcategoriaMonto = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.chtTopProductosMonto = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.chtTopProductosCantidad = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.chtTopCategoriaCantidad = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.chtTopSubcategoriaCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chtTopCategoriaMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chtTopSubcategoriaMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chtTopProductosMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chtTopProductosCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chtTopCategoriaCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.chtTopSubcategoriaCantidad, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.chtTopCategoriaMonto, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.chtTopSubcategoriaMonto, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.chtTopProductosMonto, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.chtTopProductosCantidad, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.chtTopCategoriaCantidad, 1, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(954, 737)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'chtTopSubcategoriaCantidad
        '
        ChartArea1.Name = "ChartArea1"
        Me.chtTopSubcategoriaCantidad.ChartAreas.Add(ChartArea1)
        Me.chtTopSubcategoriaCantidad.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Name = "Legend1"
        Me.chtTopSubcategoriaCantidad.Legends.Add(Legend1)
        Me.chtTopSubcategoriaCantidad.Location = New System.Drawing.Point(480, 248)
        Me.chtTopSubcategoriaCantidad.Name = "chtTopSubcategoriaCantidad"
        Me.chtTopSubcategoriaCantidad.RightToLeft = System.Windows.Forms.RightToLeft.No
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series1.Label = "#PERCENT{0.00 %}"
        Series1.Legend = "Legend1"
        Series1.LegendText = "#VALX"
        Series1.Name = "Cantidad"
        Series1.ToolTip = "#VAL - #VALX"
        Series1.XValueMember = "Nombre"
        Series1.YValueMembers = "Cantidad"
        Me.chtTopSubcategoriaCantidad.Series.Add(Series1)
        Me.chtTopSubcategoriaCantidad.Size = New System.Drawing.Size(471, 239)
        Me.chtTopSubcategoriaCantidad.TabIndex = 3
        Me.chtTopSubcategoriaCantidad.Text = "Chart1"
        Title1.Alignment = System.Drawing.ContentAlignment.TopCenter
        Title1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title1.Name = "Title1"
        Title1.Text = "Subcategoria Cantidad Top 10"
        Me.chtTopSubcategoriaCantidad.Titles.Add(Title1)
        '
        'chtTopCategoriaMonto
        '
        ChartArea2.Name = "ChartArea1"
        Me.chtTopCategoriaMonto.ChartAreas.Add(ChartArea2)
        Me.chtTopCategoriaMonto.Dock = System.Windows.Forms.DockStyle.Fill
        Legend2.Name = "Legend1"
        Me.chtTopCategoriaMonto.Legends.Add(Legend2)
        Me.chtTopCategoriaMonto.Location = New System.Drawing.Point(3, 493)
        Me.chtTopCategoriaMonto.Name = "chtTopCategoriaMonto"
        Me.chtTopCategoriaMonto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series2.Label = "#PERCENT{0.00 %}"
        Series2.Legend = "Legend1"
        Series2.LegendText = "#VALX"
        Series2.Name = "Monto"
        Series2.ToolTip = "#VAL{C} - #VALX"
        Series2.XValueMember = "Nombre"
        Series2.YValueMembers = "Monto"
        Me.chtTopCategoriaMonto.Series.Add(Series2)
        Me.chtTopCategoriaMonto.Size = New System.Drawing.Size(471, 241)
        Me.chtTopCategoriaMonto.TabIndex = 5
        Me.chtTopCategoriaMonto.Text = "Chart1"
        Title2.Alignment = System.Drawing.ContentAlignment.TopCenter
        Title2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title2.Name = "Title1"
        Title2.Text = "Categoria Monto Top 10"
        Me.chtTopCategoriaMonto.Titles.Add(Title2)
        '
        'chtTopSubcategoriaMonto
        '
        ChartArea3.Name = "ChartArea1"
        Me.chtTopSubcategoriaMonto.ChartAreas.Add(ChartArea3)
        Me.chtTopSubcategoriaMonto.Dock = System.Windows.Forms.DockStyle.Fill
        Legend3.Name = "Legend1"
        Me.chtTopSubcategoriaMonto.Legends.Add(Legend3)
        Me.chtTopSubcategoriaMonto.Location = New System.Drawing.Point(3, 248)
        Me.chtTopSubcategoriaMonto.Name = "chtTopSubcategoriaMonto"
        Me.chtTopSubcategoriaMonto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series3.Label = "#PERCENT{0.00 %}"
        Series3.Legend = "Legend1"
        Series3.LegendText = "#VALX"
        Series3.Name = "Monto"
        Series3.ToolTip = "#VAL{C} - #VALX"
        Series3.XValueMember = "Nombre"
        Series3.YValueMembers = "Monto"
        Me.chtTopSubcategoriaMonto.Series.Add(Series3)
        Me.chtTopSubcategoriaMonto.Size = New System.Drawing.Size(471, 239)
        Me.chtTopSubcategoriaMonto.TabIndex = 4
        Me.chtTopSubcategoriaMonto.Text = "Chart1"
        Title3.Alignment = System.Drawing.ContentAlignment.TopCenter
        Title3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title3.Name = "Title1"
        Title3.Text = "Subcategoria Monto Top 10"
        Me.chtTopSubcategoriaMonto.Titles.Add(Title3)
        '
        'chtTopProductosMonto
        '
        ChartArea4.Name = "ChartArea1"
        Me.chtTopProductosMonto.ChartAreas.Add(ChartArea4)
        Me.chtTopProductosMonto.Dock = System.Windows.Forms.DockStyle.Fill
        Legend4.Name = "Legend1"
        Me.chtTopProductosMonto.Legends.Add(Legend4)
        Me.chtTopProductosMonto.Location = New System.Drawing.Point(3, 3)
        Me.chtTopProductosMonto.Name = "chtTopProductosMonto"
        Me.chtTopProductosMonto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Series4.ChartArea = "ChartArea1"
        Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series4.Label = "#PERCENT{0.00 %}"
        Series4.Legend = "Legend1"
        Series4.LegendText = "#VALX"
        Series4.Name = "Monto"
        Series4.ToolTip = "#VAL{C} - #VALX"
        Series4.XValueMember = "Nombre"
        Series4.YValueMembers = "Monto"
        Me.chtTopProductosMonto.Series.Add(Series4)
        Me.chtTopProductosMonto.Size = New System.Drawing.Size(471, 239)
        Me.chtTopProductosMonto.TabIndex = 1
        Me.chtTopProductosMonto.Text = "Chart1"
        Title4.Alignment = System.Drawing.ContentAlignment.TopCenter
        Title4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title4.Name = "Title1"
        Title4.Text = "Productos Monto Top 10"
        Me.chtTopProductosMonto.Titles.Add(Title4)
        '
        'chtTopProductosCantidad
        '
        ChartArea5.Name = "ChartArea1"
        Me.chtTopProductosCantidad.ChartAreas.Add(ChartArea5)
        Me.chtTopProductosCantidad.Dock = System.Windows.Forms.DockStyle.Fill
        Legend5.Name = "Legend1"
        Me.chtTopProductosCantidad.Legends.Add(Legend5)
        Me.chtTopProductosCantidad.Location = New System.Drawing.Point(480, 3)
        Me.chtTopProductosCantidad.Name = "chtTopProductosCantidad"
        Me.chtTopProductosCantidad.RightToLeft = System.Windows.Forms.RightToLeft.No
        Series5.ChartArea = "ChartArea1"
        Series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series5.Label = "#PERCENT{0.00 %}"
        Series5.Legend = "Legend1"
        Series5.LegendText = "#VALX"
        Series5.Name = "Cantidad"
        Series5.ToolTip = "#VAL - #VALX"
        Series5.XValueMember = "Nombre"
        Series5.YValueMembers = "Cantidad"
        Me.chtTopProductosCantidad.Series.Add(Series5)
        Me.chtTopProductosCantidad.Size = New System.Drawing.Size(471, 239)
        Me.chtTopProductosCantidad.TabIndex = 2
        Me.chtTopProductosCantidad.Text = "Chart1"
        Title5.Alignment = System.Drawing.ContentAlignment.TopCenter
        Title5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title5.Name = "Title1"
        Title5.Text = "Productos Cantidad Top 10"
        Me.chtTopProductosCantidad.Titles.Add(Title5)
        '
        'chtTopCategoriaCantidad
        '
        ChartArea6.Name = "ChartArea1"
        Me.chtTopCategoriaCantidad.ChartAreas.Add(ChartArea6)
        Me.chtTopCategoriaCantidad.Dock = System.Windows.Forms.DockStyle.Fill
        Legend6.Name = "Legend1"
        Me.chtTopCategoriaCantidad.Legends.Add(Legend6)
        Me.chtTopCategoriaCantidad.Location = New System.Drawing.Point(480, 493)
        Me.chtTopCategoriaCantidad.Name = "chtTopCategoriaCantidad"
        Me.chtTopCategoriaCantidad.RightToLeft = System.Windows.Forms.RightToLeft.No
        Series6.ChartArea = "ChartArea1"
        Series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series6.Label = "#PERCENT{0.00 %}"
        Series6.Legend = "Legend1"
        Series6.LegendText = "#VALX"
        Series6.Name = "Cantidad"
        Series6.ToolTip = "#VAL - #VALX"
        Series6.XValueMember = "Nombre"
        Series6.YValueMembers = "Cantidad"
        Me.chtTopCategoriaCantidad.Series.Add(Series6)
        Me.chtTopCategoriaCantidad.Size = New System.Drawing.Size(471, 241)
        Me.chtTopCategoriaCantidad.TabIndex = 6
        Me.chtTopCategoriaCantidad.Text = "Chart1"
        Title6.Alignment = System.Drawing.ContentAlignment.TopCenter
        Title6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title6.Name = "Title1"
        Title6.Text = "Categoria Cantidad Top 10"
        Me.chtTopCategoriaCantidad.Titles.Add(Title6)
        '
        'FrmInformeGraficoProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(954, 737)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmInformeGraficoProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informe Productos"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.chtTopSubcategoriaCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chtTopCategoriaMonto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chtTopSubcategoriaMonto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chtTopProductosMonto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chtTopProductosCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chtTopCategoriaCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents chtTopSubcategoriaMonto As DataVisualization.Charting.Chart
    Friend WithEvents chtTopSubcategoriaCantidad As DataVisualization.Charting.Chart
    Friend WithEvents chtTopProductosMonto As DataVisualization.Charting.Chart
    Friend WithEvents chtTopCategoriaMonto As DataVisualization.Charting.Chart
    Friend WithEvents chtTopCategoriaCantidad As DataVisualization.Charting.Chart
    Friend WithEvents chtTopProductosCantidad As DataVisualization.Charting.Chart
End Class
