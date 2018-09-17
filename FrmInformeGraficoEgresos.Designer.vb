<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmInformeGraficoEgresos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title2 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInformeGraficoEgresos))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.chtTopProveedor = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.chtTopGastos = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.chtTopProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chtTopGastos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.chtTopProveedor, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.chtTopGastos, 0, 1)
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
        'chtTopProveedor
        '
        ChartArea1.Name = "ChartArea1"
        Me.chtTopProveedor.ChartAreas.Add(ChartArea1)
        Me.chtTopProveedor.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Name = "Legend1"
        Me.chtTopProveedor.Legends.Add(Legend1)
        Me.chtTopProveedor.Location = New System.Drawing.Point(3, 3)
        Me.chtTopProveedor.Name = "chtTopProveedor"
        Me.chtTopProveedor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series1.Label = "#PERCENT{0.00 %}"
        Series1.Legend = "Legend1"
        Series1.LegendText = "#VALX"
        Series1.Name = "Monto"
        Series1.ToolTip = "#VAL{C} - #VALX"
        Series1.XValueMember = "Detalle"
        Series1.YValueMembers = "Monto"
        Me.chtTopProveedor.Series.Add(Series1)
        Me.chtTopProveedor.Size = New System.Drawing.Size(948, 362)
        Me.chtTopProveedor.TabIndex = 1
        Me.chtTopProveedor.Text = "Chart1"
        Title1.Alignment = System.Drawing.ContentAlignment.TopCenter
        Title1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title1.Name = "Title1"
        Title1.Text = "Costo"
        Me.chtTopProveedor.Titles.Add(Title1)
        '
        'chtTopGastos
        '
        ChartArea2.Name = "ChartArea1"
        Me.chtTopGastos.ChartAreas.Add(ChartArea2)
        Me.chtTopGastos.Dock = System.Windows.Forms.DockStyle.Fill
        Legend2.Name = "Legend1"
        Me.chtTopGastos.Legends.Add(Legend2)
        Me.chtTopGastos.Location = New System.Drawing.Point(3, 371)
        Me.chtTopGastos.Name = "chtTopGastos"
        Me.chtTopGastos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series2.Label = "#PERCENT{0.00 %}"
        Series2.Legend = "Legend1"
        Series2.LegendText = "#VALX"
        Series2.Name = "Monto"
        Series2.ToolTip = "#VAL{C} - #VALX"
        Series2.XValueMember = "Detalle"
        Series2.YValueMembers = "Monto"
        Me.chtTopGastos.Series.Add(Series2)
        Me.chtTopGastos.Size = New System.Drawing.Size(948, 363)
        Me.chtTopGastos.TabIndex = 2
        Me.chtTopGastos.Text = "Chart1"
        Title2.Alignment = System.Drawing.ContentAlignment.TopCenter
        Title2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title2.Name = "Title1"
        Title2.Text = "Gasto"
        Me.chtTopGastos.Titles.Add(Title2)
        '
        'FrmInformeGraficoEgresos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(954, 737)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmInformeGraficoEgresos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informe Egresos"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.chtTopProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chtTopGastos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents chtTopGastos As DataVisualization.Charting.Chart
    Friend WithEvents chtTopProveedor As DataVisualization.Charting.Chart
End Class
