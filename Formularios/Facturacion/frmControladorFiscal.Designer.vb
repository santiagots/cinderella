<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmControladorFiscal
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmControladorFiscal))
        Me.btnCierreZ = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnInformacionTransaccionesPorFiltro = New System.Windows.Forms.Button()
        Me.btnResumenTotalesPorFiltro = New System.Windows.Forms.Button()
        Me.btnDuplicadosDocumentosAPorFiltro = New System.Windows.Forms.Button()
        Me.btnCintaTestigoDigitalPorFiltro = New System.Windows.Forms.Button()
        Me.btnCierreZPorFiltro = New System.Windows.Forms.Button()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FDesdeCierreZ = New System.Windows.Forms.DateTimePicker()
        Me.FrmControladorFiscalViewModelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FHastaCierreZ = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.rblFiltroPorFecha = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.FHasta = New System.Windows.Forms.DateTimePicker()
        Me.FDesde = New System.Windows.Forms.DateTimePicker()
        Me.btn_Exportar = New System.Windows.Forms.Button()
        Me.BtnFiltrar = New System.Windows.Forms.Button()
        Me.dgTickets = New System.Windows.Forms.DataGridView()
        Me.NumeroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PuntoVentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoFacturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CondicionIVADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUITDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreYApellidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocalidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FacturasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lbl_Msg = New System.Windows.Forms.Label()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.FrmControladorFiscalViewModelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.dgTickets, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCierreZ
        '
        Me.btnCierreZ.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCierreZ.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnCierreZ.Location = New System.Drawing.Point(733, 11)
        Me.btnCierreZ.Name = "btnCierreZ"
        Me.btnCierreZ.Size = New System.Drawing.Size(121, 40)
        Me.btnCierreZ.TabIndex = 0
        Me.btnCierreZ.Text = "Cierre Z día"
        Me.btnCierreZ.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.btnCierreZ)
        Me.GroupBox2.Controls.Add(Me.lblEstado)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(860, 218)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Controlador Fiscal"
        '
        'lblEstado
        '
        Me.lblEstado.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.Location = New System.Drawing.Point(165, 24)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(39, 15)
        Me.lblEstado.TabIndex = 1
        Me.lblEstado.Text = "- - - -"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TableLayoutPanel5)
        Me.GroupBox3.Controls.Add(Me.TableLayoutPanel3)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 47)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(848, 165)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Reportes"
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 5
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.btnInformacionTransaccionesPorFiltro, 4, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.btnResumenTotalesPorFiltro, 3, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.btnDuplicadosDocumentosAPorFiltro, 2, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.btnCintaTestigoDigitalPorFiltro, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.btnCierreZPorFiltro, 0, 0)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(6, 110)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(830, 49)
        Me.TableLayoutPanel5.TabIndex = 1
        '
        'btnInformacionTransaccionesPorFiltro
        '
        Me.btnInformacionTransaccionesPorFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInformacionTransaccionesPorFiltro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInformacionTransaccionesPorFiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInformacionTransaccionesPorFiltro.Location = New System.Drawing.Point(667, 4)
        Me.btnInformacionTransaccionesPorFiltro.Name = "btnInformacionTransaccionesPorFiltro"
        Me.btnInformacionTransaccionesPorFiltro.Size = New System.Drawing.Size(160, 40)
        Me.btnInformacionTransaccionesPorFiltro.TabIndex = 16
        Me.btnInformacionTransaccionesPorFiltro.Text = "Información de Transacciones"
        Me.btnInformacionTransaccionesPorFiltro.UseVisualStyleBackColor = True
        '
        'btnResumenTotalesPorFiltro
        '
        Me.btnResumenTotalesPorFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnResumenTotalesPorFiltro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnResumenTotalesPorFiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResumenTotalesPorFiltro.Location = New System.Drawing.Point(501, 4)
        Me.btnResumenTotalesPorFiltro.Name = "btnResumenTotalesPorFiltro"
        Me.btnResumenTotalesPorFiltro.Size = New System.Drawing.Size(160, 40)
        Me.btnResumenTotalesPorFiltro.TabIndex = 15
        Me.btnResumenTotalesPorFiltro.Text = "Resumen de Totales"
        Me.btnResumenTotalesPorFiltro.UseVisualStyleBackColor = True
        '
        'btnDuplicadosDocumentosAPorFiltro
        '
        Me.btnDuplicadosDocumentosAPorFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDuplicadosDocumentosAPorFiltro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDuplicadosDocumentosAPorFiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDuplicadosDocumentosAPorFiltro.Location = New System.Drawing.Point(335, 4)
        Me.btnDuplicadosDocumentosAPorFiltro.Name = "btnDuplicadosDocumentosAPorFiltro"
        Me.btnDuplicadosDocumentosAPorFiltro.Size = New System.Drawing.Size(160, 40)
        Me.btnDuplicadosDocumentosAPorFiltro.TabIndex = 14
        Me.btnDuplicadosDocumentosAPorFiltro.Text = "Duplicados documentos ""A"""
        Me.btnDuplicadosDocumentosAPorFiltro.UseVisualStyleBackColor = True
        '
        'btnCintaTestigoDigitalPorFiltro
        '
        Me.btnCintaTestigoDigitalPorFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCintaTestigoDigitalPorFiltro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCintaTestigoDigitalPorFiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCintaTestigoDigitalPorFiltro.Location = New System.Drawing.Point(169, 4)
        Me.btnCintaTestigoDigitalPorFiltro.Name = "btnCintaTestigoDigitalPorFiltro"
        Me.btnCintaTestigoDigitalPorFiltro.Size = New System.Drawing.Size(160, 40)
        Me.btnCintaTestigoDigitalPorFiltro.TabIndex = 13
        Me.btnCintaTestigoDigitalPorFiltro.Text = "Cinta testigo digital"
        Me.btnCintaTestigoDigitalPorFiltro.UseVisualStyleBackColor = True
        '
        'btnCierreZPorFiltro
        '
        Me.btnCierreZPorFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCierreZPorFiltro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCierreZPorFiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCierreZPorFiltro.Location = New System.Drawing.Point(3, 4)
        Me.btnCierreZPorFiltro.Name = "btnCierreZPorFiltro"
        Me.btnCierreZPorFiltro.Size = New System.Drawing.Size(160, 40)
        Me.btnCierreZPorFiltro.TabIndex = 12
        Me.btnCierreZPorFiltro.Text = "Cierre Z por rango de fecha"
        Me.btnCierreZPorFiltro.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 5
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label1, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.FDesdeCierreZ, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.FHastaCierreZ, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Label2, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Label3, 3, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label5, 3, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.TextBox2, 4, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.TextBox1, 4, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel4, 1, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(6, 19)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(830, 90)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 16)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Filtrar Por"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Fecha desde"
        '
        'FDesdeCierreZ
        '
        Me.FDesdeCierreZ.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FDesdeCierreZ.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FrmControladorFiscalViewModelBindingSource, "ControladorFiscalFechaDesde", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "D"))
        Me.FDesdeCierreZ.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.FrmControladorFiscalViewModelBindingSource, "ControladorFiscalFiltrarPorFecha", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.FDesdeCierreZ.Location = New System.Drawing.Point(153, 35)
        Me.FDesdeCierreZ.Name = "FDesdeCierreZ"
        Me.FDesdeCierreZ.Size = New System.Drawing.Size(239, 20)
        Me.FDesdeCierreZ.TabIndex = 8
        '
        'FrmControladorFiscalViewModelBindingSource
        '
        Me.FrmControladorFiscalViewModelBindingSource.DataSource = GetType(SistemaCinderella.Formularios.Facturacion.frmControladorFiscalViewModel)
        '
        'FHastaCierreZ
        '
        Me.FHastaCierreZ.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FHastaCierreZ.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FrmControladorFiscalViewModelBindingSource, "ControladorFiscalFechaHasta", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "D"))
        Me.FHastaCierreZ.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.FrmControladorFiscalViewModelBindingSource, "ControladorFiscalFiltrarPorFecha", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.FHastaCierreZ.Location = New System.Drawing.Point(153, 65)
        Me.FHastaCierreZ.Name = "FHastaCierreZ"
        Me.FHastaCierreZ.Size = New System.Drawing.Size(239, 20)
        Me.FHastaCierreZ.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Fecha hasta"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(438, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Jornada desde"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(438, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Jornada hasta"
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmControladorFiscalViewModelBindingSource, "ControladorFiscalJornadaDesde", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "N0"))
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.FrmControladorFiscalViewModelBindingSource, "ControladorFiscalFiltrarPorJornada", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox2.Location = New System.Drawing.Point(588, 35)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(239, 20)
        Me.TextBox2.TabIndex = 15
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmControladorFiscalViewModelBindingSource, "ControladorFiscalJornadaHasta", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "N0"))
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.FrmControladorFiscalViewModelBindingSource, "ControladorFiscalFiltrarPorJornada", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox1.Location = New System.Drawing.Point(588, 65)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(239, 20)
        Me.TextBox1.TabIndex = 14
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.RadioButton2, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.rblFiltroPorFecha, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(153, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(239, 24)
        Me.TableLayoutPanel4.TabIndex = 17
        '
        'RadioButton2
        '
        Me.RadioButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.FrmControladorFiscalViewModelBindingSource, "ControladorFiscalFiltrarPorJornada", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.RadioButton2.Location = New System.Drawing.Point(122, 3)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(114, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Jornada"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'rblFiltroPorFecha
        '
        Me.rblFiltroPorFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rblFiltroPorFecha.AutoSize = True
        Me.rblFiltroPorFecha.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.FrmControladorFiscalViewModelBindingSource, "ControladorFiscalFiltrarPorFecha", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.rblFiltroPorFecha.Location = New System.Drawing.Point(3, 3)
        Me.rblFiltroPorFecha.Name = "rblFiltroPorFecha"
        Me.rblFiltroPorFecha.Size = New System.Drawing.Size(113, 17)
        Me.rblFiltroPorFecha.TabIndex = 0
        Me.rblFiltroPorFecha.TabStop = True
        Me.rblFiltroPorFecha.Text = "Fecha"
        Me.rblFiltroPorFecha.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(15, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Estado"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox1.Controls.Add(Me.btn_Exportar)
        Me.GroupBox1.Controls.Add(Me.BtnFiltrar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 236)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(860, 83)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tickets"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label12, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label11, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.FHasta, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.FDesde, 1, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(6, 17)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(594, 60)
        Me.TableLayoutPanel2.TabIndex = 6
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(3, 7)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(194, 16)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Fecha desde"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(3, 37)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(194, 16)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Fecha hasta"
        '
        'FHasta
        '
        Me.FHasta.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FHasta.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FrmControladorFiscalViewModelBindingSource, "TicketFechaHasta", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "D"))
        Me.FHasta.Location = New System.Drawing.Point(203, 35)
        Me.FHasta.Name = "FHasta"
        Me.FHasta.Size = New System.Drawing.Size(388, 20)
        Me.FHasta.TabIndex = 5
        '
        'FDesde
        '
        Me.FDesde.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FDesde.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FrmControladorFiscalViewModelBindingSource, "TicketFechaDesde", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "D"))
        Me.FDesde.Location = New System.Drawing.Point(203, 5)
        Me.FDesde.Name = "FDesde"
        Me.FDesde.Size = New System.Drawing.Size(388, 20)
        Me.FDesde.TabIndex = 4
        '
        'btn_Exportar
        '
        Me.btn_Exportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Exportar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Exportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Exportar.Image = Global.SistemaCinderella.My.Resources.Recursos.export_excel
        Me.btn_Exportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Exportar.Location = New System.Drawing.Point(606, 26)
        Me.btn_Exportar.Name = "btn_Exportar"
        Me.btn_Exportar.Size = New System.Drawing.Size(121, 40)
        Me.btn_Exportar.TabIndex = 12
        Me.btn_Exportar.Text = "Exportar"
        Me.btn_Exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Exportar.UseVisualStyleBackColor = True
        '
        'BtnFiltrar
        '
        Me.BtnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFiltrar.FlatAppearance.BorderSize = 0
        Me.BtnFiltrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFiltrar.Image = Global.SistemaCinderella.My.Resources.Recursos.IconoBuscar32
        Me.BtnFiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnFiltrar.Location = New System.Drawing.Point(733, 26)
        Me.BtnFiltrar.Name = "BtnFiltrar"
        Me.BtnFiltrar.Size = New System.Drawing.Size(121, 40)
        Me.BtnFiltrar.TabIndex = 10
        Me.BtnFiltrar.Text = "Buscar"
        Me.BtnFiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnFiltrar.UseVisualStyleBackColor = True
        '
        'dgTickets
        '
        Me.dgTickets.AllowUserToAddRows = False
        Me.dgTickets.AllowUserToDeleteRows = False
        Me.dgTickets.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgTickets.AutoGenerateColumns = False
        Me.dgTickets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgTickets.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTickets.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumeroDataGridViewTextBoxColumn, Me.PuntoVentaDataGridViewTextBoxColumn, Me.TipoFacturaDataGridViewTextBoxColumn, Me.CondicionIVADataGridViewTextBoxColumn, Me.CUITDataGridViewTextBoxColumn, Me.NombreYApellidoDataGridViewTextBoxColumn, Me.DireccionDataGridViewTextBoxColumn, Me.LocalidadDataGridViewTextBoxColumn, Me.MontoDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn})
        Me.dgTickets.DataSource = Me.FacturasBindingSource
        Me.dgTickets.Location = New System.Drawing.Point(12, 325)
        Me.dgTickets.Name = "dgTickets"
        Me.dgTickets.ReadOnly = True
        Me.dgTickets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgTickets.Size = New System.Drawing.Size(860, 471)
        Me.dgTickets.TabIndex = 4
        '
        'NumeroDataGridViewTextBoxColumn
        '
        Me.NumeroDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NumeroDataGridViewTextBoxColumn.DataPropertyName = "Numero"
        Me.NumeroDataGridViewTextBoxColumn.HeaderText = "Numero"
        Me.NumeroDataGridViewTextBoxColumn.Name = "NumeroDataGridViewTextBoxColumn"
        Me.NumeroDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumeroDataGridViewTextBoxColumn.Width = 69
        '
        'PuntoVentaDataGridViewTextBoxColumn
        '
        Me.PuntoVentaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PuntoVentaDataGridViewTextBoxColumn.DataPropertyName = "PuntoVenta"
        Me.PuntoVentaDataGridViewTextBoxColumn.HeaderText = "P. Venta"
        Me.PuntoVentaDataGridViewTextBoxColumn.Name = "PuntoVentaDataGridViewTextBoxColumn"
        Me.PuntoVentaDataGridViewTextBoxColumn.ReadOnly = True
        Me.PuntoVentaDataGridViewTextBoxColumn.Width = 73
        '
        'TipoFacturaDataGridViewTextBoxColumn
        '
        Me.TipoFacturaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TipoFacturaDataGridViewTextBoxColumn.DataPropertyName = "TipoFactura"
        Me.TipoFacturaDataGridViewTextBoxColumn.HeaderText = "T. Factura"
        Me.TipoFacturaDataGridViewTextBoxColumn.Name = "TipoFacturaDataGridViewTextBoxColumn"
        Me.TipoFacturaDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoFacturaDataGridViewTextBoxColumn.Width = 81
        '
        'CondicionIVADataGridViewTextBoxColumn
        '
        Me.CondicionIVADataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CondicionIVADataGridViewTextBoxColumn.DataPropertyName = "CondicionIVA"
        Me.CondicionIVADataGridViewTextBoxColumn.HeaderText = "Condición IVA"
        Me.CondicionIVADataGridViewTextBoxColumn.Name = "CondicionIVADataGridViewTextBoxColumn"
        Me.CondicionIVADataGridViewTextBoxColumn.ReadOnly = True
        Me.CondicionIVADataGridViewTextBoxColumn.Width = 99
        '
        'CUITDataGridViewTextBoxColumn
        '
        Me.CUITDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CUITDataGridViewTextBoxColumn.DataPropertyName = "CUIT"
        Me.CUITDataGridViewTextBoxColumn.HeaderText = "CUIT"
        Me.CUITDataGridViewTextBoxColumn.Name = "CUITDataGridViewTextBoxColumn"
        Me.CUITDataGridViewTextBoxColumn.ReadOnly = True
        Me.CUITDataGridViewTextBoxColumn.Width = 57
        '
        'NombreYApellidoDataGridViewTextBoxColumn
        '
        Me.NombreYApellidoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NombreYApellidoDataGridViewTextBoxColumn.DataPropertyName = "NombreYApellido"
        Me.NombreYApellidoDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreYApellidoDataGridViewTextBoxColumn.Name = "NombreYApellidoDataGridViewTextBoxColumn"
        Me.NombreYApellidoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DireccionDataGridViewTextBoxColumn
        '
        Me.DireccionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DireccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion"
        Me.DireccionDataGridViewTextBoxColumn.HeaderText = "Dirección"
        Me.DireccionDataGridViewTextBoxColumn.Name = "DireccionDataGridViewTextBoxColumn"
        Me.DireccionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LocalidadDataGridViewTextBoxColumn
        '
        Me.LocalidadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.LocalidadDataGridViewTextBoxColumn.DataPropertyName = "Localidad"
        Me.LocalidadDataGridViewTextBoxColumn.HeaderText = "Localidad"
        Me.LocalidadDataGridViewTextBoxColumn.Name = "LocalidadDataGridViewTextBoxColumn"
        Me.LocalidadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MontoDataGridViewTextBoxColumn
        '
        Me.MontoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MontoDataGridViewTextBoxColumn.DataPropertyName = "Monto"
        DataGridViewCellStyle1.Format = "C"
        Me.MontoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.MontoDataGridViewTextBoxColumn.HeaderText = "Monto"
        Me.MontoDataGridViewTextBoxColumn.Name = "MontoDataGridViewTextBoxColumn"
        Me.MontoDataGridViewTextBoxColumn.ReadOnly = True
        Me.MontoDataGridViewTextBoxColumn.Width = 62
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaDataGridViewTextBoxColumn.Width = 62
        '
        'FacturasBindingSource
        '
        Me.FacturasBindingSource.DataMember = "Facturas"
        Me.FacturasBindingSource.DataSource = Me.FrmControladorFiscalViewModelBindingSource
        '
        'lbl_Msg
        '
        Me.lbl_Msg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Msg.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lbl_Msg.DataBindings.Add(New System.Windows.Forms.Binding("Visible", Me.FrmControladorFiscalViewModelBindingSource, "SinResultados", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.lbl_Msg.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Msg.Location = New System.Drawing.Point(279, 525)
        Me.lbl_Msg.Name = "lbl_Msg"
        Me.lbl_Msg.Size = New System.Drawing.Size(327, 71)
        Me.lbl_Msg.TabIndex = 5
        Me.lbl_Msg.Text = "No se han encontrado tickets."
        Me.lbl_Msg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_Msg.Visible = False
        '
        'FolderBrowserDialog
        '
        Me.FolderBrowserDialog.Description = "Seleccione una carpeta en donde se guardara el archivo"
        '
        'frmControladorFiscal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 808)
        Me.Controls.Add(Me.lbl_Msg)
        Me.Controls.Add(Me.dgTickets)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmControladorFiscal"
        Me.Text = "Controlador Fiscal"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.FrmControladorFiscalViewModelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.dgTickets, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCierreZ As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents FHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents FDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnFiltrar As System.Windows.Forms.Button
    Friend WithEvents dgTickets As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_Msg As System.Windows.Forms.Label
    Friend WithEvents btn_Exportar As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btnCierreZPorFiltro As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents FHastaCierreZ As System.Windows.Forms.DateTimePicker
    Friend WithEvents FDesdeCierreZ As System.Windows.Forms.DateTimePicker
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents FrmControladorFiscalViewModelBindingSource As BindingSource
    Friend WithEvents FacturasBindingSource As BindingSource
    Friend WithEvents NumeroDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PuntoVentaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoFacturaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CondicionIVADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CUITDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreYApellidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DireccionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LocalidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MontoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents btnInformacionTransaccionesPorFiltro As Button
    Friend WithEvents btnResumenTotalesPorFiltro As Button
    Friend WithEvents btnDuplicadosDocumentosAPorFiltro As Button
    Friend WithEvents btnCintaTestigoDigitalPorFiltro As Button
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents rblFiltroPorFecha As RadioButton
    Friend WithEvents FolderBrowserDialog As FolderBrowserDialog
End Class
