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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInformeGraficoProducto))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.chtTopSubcategoriaMonto = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.chtTopSubcategoriaCantidad = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.chtTopProductosMonto = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.chtTopProductosCantidad = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.chtTopSubcategoriaMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chtTopSubcategoriaCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chtTopProductosMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chtTopProductosCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.chtTopSubcategoriaMonto, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.chtTopSubcategoriaCantidad, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.chtTopProductosMonto, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.chtTopProductosCantidad, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(954, 737)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'chtTopSubcategoriaMonto
        '
        ChartArea1.Name = "ChartArea1"
        Me.chtTopSubcategoriaMonto.ChartAreas.Add(ChartArea1)
        Me.chtTopSubcategoriaMonto.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Name = "Legend1"
        Me.chtTopSubcategoriaMonto.Legends.Add(Legend1)
        Me.chtTopSubcategoriaMonto.Location = New System.Drawing.Point(3, 371)
        Me.chtTopSubcategoriaMonto.Name = "chtTopSubcategoriaMonto"
        Me.chtTopSubcategoriaMonto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series1.Label = "#PERCENT{0.00 %}"
        Series1.Legend = "Legend1"
        Series1.LegendText = "#VALX"
        Series1.Name = "Monto"
        Series1.ToolTip = "#VAL{C} - #VALX"
        Series1.XValueMember = "Nombre"
        Series1.YValueMembers = "Monto"
        Me.chtTopSubcategoriaMonto.Series.Add(Series1)
        Me.chtTopSubcategoriaMonto.Size = New System.Drawing.Size(471, 363)
        Me.chtTopSubcategoriaMonto.TabIndex = 4
        Me.chtTopSubcategoriaMonto.Text = "Chart1"
        Title1.Alignment = System.Drawing.ContentAlignment.TopCenter
        Title1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title1.Name = "Title1"
        Title1.Text = "Subcategoria Monto Top 10"
        Me.chtTopSubcategoriaMonto.Titles.Add(Title1)
        '
        'chtTopSubcategoriaCantidad
        '
        ChartArea2.Name = "ChartArea1"
        Me.chtTopSubcategoriaCantidad.ChartAreas.Add(ChartArea2)
        Me.chtTopSubcategoriaCantidad.Dock = System.Windows.Forms.DockStyle.Fill
        Legend2.Name = "Legend1"
        Me.chtTopSubcategoriaCantidad.Legends.Add(Legend2)
        Me.chtTopSubcategoriaCantidad.Location = New System.Drawing.Point(480, 371)
        Me.chtTopSubcategoriaCantidad.Name = "chtTopSubcategoriaCantidad"
        Me.chtTopSubcategoriaCantidad.RightToLeft = System.Windows.Forms.RightToLeft.No
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series2.Label = "#PERCENT{0.00 %}"
        Series2.Legend = "Legend1"
        Series2.LegendText = "#VALX"
        Series2.Name = "Cantidad"
        Series2.ToolTip = "#VAL - #VALX"
        Series2.XValueMember = "Nombre"
        Series2.YValueMembers = "Cantidad"
        Me.chtTopSubcategoriaCantidad.Series.Add(Series2)
        Me.chtTopSubcategoriaCantidad.Size = New System.Drawing.Size(471, 363)
        Me.chtTopSubcategoriaCantidad.TabIndex = 3
        Me.chtTopSubcategoriaCantidad.Text = "Chart1"
        Title2.Alignment = System.Drawing.ContentAlignment.TopCenter
        Title2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title2.Name = "Title1"
        Title2.Text = "Subcategoria Cantidad Top 10"
        Me.chtTopSubcategoriaCantidad.Titles.Add(Title2)
        '
        'chtTopProductosMonto
        '
        ChartArea3.Name = "ChartArea1"
        Me.chtTopProductosMonto.ChartAreas.Add(ChartArea3)
        Me.chtTopProductosMonto.Dock = System.Windows.Forms.DockStyle.Fill
        Legend3.Name = "Legend1"
        Me.chtTopProductosMonto.Legends.Add(Legend3)
        Me.chtTopProductosMonto.Location = New System.Drawing.Point(3, 3)
        Me.chtTopProductosMonto.Name = "chtTopProductosMonto"
        Me.chtTopProductosMonto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series3.Label = "#PERCENT{0.00 %}"
        Series3.Legend = "Legend1"
        Series3.LegendText = "#VALX"
        Series3.Name = "Monto"
        Series3.ToolTip = "#VAL{C} - #VALX"
        Series3.XValueMember = "Nombre"
        Series3.YValueMembers = "Monto"
        Me.chtTopProductosMonto.Series.Add(Series3)
        Me.chtTopProductosMonto.Size = New System.Drawing.Size(471, 362)
        Me.chtTopProductosMonto.TabIndex = 1
        Me.chtTopProductosMonto.Text = "Chart1"
        Title3.Alignment = System.Drawing.ContentAlignment.TopCenter
        Title3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title3.Name = "Title1"
        Title3.Text = "Productos Monto Top 10"
        Me.chtTopProductosMonto.Titles.Add(Title3)
        '
        'chtTopProductosCantidad
        '
        ChartArea4.Name = "ChartArea1"
        Me.chtTopProductosCantidad.ChartAreas.Add(ChartArea4)
        Me.chtTopProductosCantidad.Dock = System.Windows.Forms.DockStyle.Fill
        Legend4.Name = "Legend1"
        Me.chtTopProductosCantidad.Legends.Add(Legend4)
        Me.chtTopProductosCantidad.Location = New System.Drawing.Point(480, 3)
        Me.chtTopProductosCantidad.Name = "chtTopProductosCantidad"
        Me.chtTopProductosCantidad.RightToLeft = System.Windows.Forms.RightToLeft.No
        Series4.ChartArea = "ChartArea1"
        Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series4.Label = "#PERCENT{0.00 %}"
        Series4.Legend = "Legend1"
        Series4.LegendText = "#VALX"
        Series4.Name = "Cantidad"
        Series4.ToolTip = "#VAL - #VALX"
        Series4.XValueMember = "Nombre"
        Series4.YValueMembers = "Cantidad"
        Me.chtTopProductosCantidad.Series.Add(Series4)
        Me.chtTopProductosCantidad.Size = New System.Drawing.Size(471, 362)
        Me.chtTopProductosCantidad.TabIndex = 2
        Me.chtTopProductosCantidad.Text = "Chart1"
        Title4.Alignment = System.Drawing.ContentAlignment.TopCenter
        Title4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title4.Name = "Title1"
        Title4.Text = "Productos Cantidad Top 10"
        Me.chtTopProductosCantidad.Titles.Add(Title4)
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
        CType(Me.chtTopSubcategoriaMonto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chtTopSubcategoriaCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chtTopProductosMonto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chtTopProductosCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents chtTopSubcategoriaMonto As DataVisualization.Charting.Chart
    Friend WithEvents chtTopSubcategoriaCantidad As DataVisualization.Charting.Chart
    Friend WithEvents chtTopProductosMonto As DataVisualization.Charting.Chart
    Friend WithEvents chtTopProductosCantidad As DataVisualization.Charting.Chart
End Class
