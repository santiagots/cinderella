<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConfiguracionFacturacionImpuestos

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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfiguracionFacturacionImpuestos))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.FrmConfiguracionFacturacionImpuestosViewModelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RIVANo = New System.Windows.Forms.RadioButton()
        Me.RIVASi = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Btn_Agregar_Imp = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DG_Impuestos = New SistemaCinderella.CustomDataGrid()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PorcentajeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Modificar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Eliminar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.InpuestosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_Total = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_PorcentajeBonificacion = New Controles.PercentUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.RHabilitarNo = New System.Windows.Forms.RadioButton()
        Me.RHabilitarSi = New System.Windows.Forms.RadioButton()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.FrmConfiguracionFacturacionImpuestosViewModelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DG_Impuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InpuestosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.txt_PorcentajeBonificacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox2.Controls.Add(Me.Panel1)
        Me.GroupBox2.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.FrmConfiguracionFacturacionImpuestosViewModelBindingSource, "HabilitarImpuestosSi", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(15, 130)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox2.Size = New System.Drawing.Size(506, 103)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Discriminar Importe IVA"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 184.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBox8, 1, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(10, 51)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(485, 40)
        Me.TableLayoutPanel2.TabIndex = 35
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 12)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(176, 15)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "(*) Descripción a Imprimir"
        '
        'TextBox8
        '
        Me.TextBox8.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmConfiguracionFacturacionImpuestosViewModelBindingSource, "IVADescripcion", True))
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.FrmConfiguracionFacturacionImpuestosViewModelBindingSource, "IVADiscirimiarSi", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(188, 9)
        Me.TextBox8.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(293, 21)
        Me.TextBox8.TabIndex = 14
        '
        'FrmConfiguracionFacturacionImpuestosViewModelBindingSource
        '
        Me.FrmConfiguracionFacturacionImpuestosViewModelBindingSource.DataSource = GetType(SistemaCinderella.Formularios.Comun.frmConfiguracionFacturacionImpuestosViewModel)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RIVANo)
        Me.Panel1.Controls.Add(Me.RIVASi)
        Me.Panel1.Location = New System.Drawing.Point(10, 21)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(181, 30)
        Me.Panel1.TabIndex = 34
        '
        'RIVANo
        '
        Me.RIVANo.AutoSize = True
        Me.RIVANo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RIVANo.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.FrmConfiguracionFacturacionImpuestosViewModelBindingSource, "IVADiscirimiarNo", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.RIVANo.Location = New System.Drawing.Point(126, 2)
        Me.RIVANo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.RIVANo.Name = "RIVANo"
        Me.RIVANo.Size = New System.Drawing.Size(43, 19)
        Me.RIVANo.TabIndex = 26
        Me.RIVANo.Tag = ""
        Me.RIVANo.Text = "NO"
        Me.RIVANo.UseVisualStyleBackColor = True
        '
        'RIVASi
        '
        Me.RIVASi.AutoSize = True
        Me.RIVASi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RIVASi.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.FrmConfiguracionFacturacionImpuestosViewModelBindingSource, "IVADiscirimiarSi", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.RIVASi.Location = New System.Drawing.Point(13, 3)
        Me.RIVASi.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.RIVASi.Name = "RIVASi"
        Me.RIVASi.Size = New System.Drawing.Size(36, 19)
        Me.RIVASi.TabIndex = 0
        Me.RIVASi.Tag = ""
        Me.RIVASi.Text = "SI"
        Me.RIVASi.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Btn_Agregar_Imp)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox1.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.FrmConfiguracionFacturacionImpuestosViewModelBindingSource, "HabilitarImpuestosSi", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(14, 239)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(506, 289)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Configuración Otros Impuestos"
        '
        'Btn_Agregar_Imp
        '
        Me.Btn_Agregar_Imp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Agregar_Imp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Agregar_Imp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Agregar_Imp.Image = Global.SistemaCinderella.My.Resources.Recursos.Agregar_24
        Me.Btn_Agregar_Imp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Agregar_Imp.Location = New System.Drawing.Point(378, 137)
        Me.Btn_Agregar_Imp.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Btn_Agregar_Imp.Name = "Btn_Agregar_Imp"
        Me.Btn_Agregar_Imp.Size = New System.Drawing.Size(111, 40)
        Me.Btn_Agregar_Imp.TabIndex = 38
        Me.Btn_Agregar_Imp.Text = "Agregar"
        Me.Btn_Agregar_Imp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Agregar_Imp.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.DG_Impuestos)
        Me.GroupBox3.Location = New System.Drawing.Point(7, 185)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox3.Size = New System.Drawing.Size(499, 98)
        Me.GroupBox3.TabIndex = 37
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Impuestos Disponibles"
        '
        'DG_Impuestos
        '
        Me.DG_Impuestos.AllowUserToAddRows = False
        Me.DG_Impuestos.AllowUserToDeleteRows = False
        Me.DG_Impuestos.AutoGenerateColumns = False
        Me.DG_Impuestos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DG_Impuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Impuestos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DescripcionDataGridViewTextBoxColumn, Me.PorcentajeDataGridViewTextBoxColumn, Me.Monto, Me.Modificar, Me.Eliminar})
        Me.DG_Impuestos.DataSource = Me.InpuestosBindingSource
        Me.DG_Impuestos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_Impuestos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DG_Impuestos.Location = New System.Drawing.Point(4, 17)
        Me.DG_Impuestos.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DG_Impuestos.Name = "DG_Impuestos"
        Me.DG_Impuestos.ReadOnly = True
        Me.DG_Impuestos.RowHeadersVisible = False
        Me.DG_Impuestos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Impuestos.Size = New System.Drawing.Size(491, 78)
        Me.DG_Impuestos.TabIndex = 33
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PorcentajeDataGridViewTextBoxColumn
        '
        Me.PorcentajeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.PorcentajeDataGridViewTextBoxColumn.DataPropertyName = "Porcentaje"
        DataGridViewCellStyle1.Format = "P"
        Me.PorcentajeDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.PorcentajeDataGridViewTextBoxColumn.HeaderText = "Porcentaje"
        Me.PorcentajeDataGridViewTextBoxColumn.Name = "PorcentajeDataGridViewTextBoxColumn"
        Me.PorcentajeDataGridViewTextBoxColumn.ReadOnly = True
        Me.PorcentajeDataGridViewTextBoxColumn.Width = 91
        '
        'Monto
        '
        Me.Monto.DataPropertyName = "Monto"
        DataGridViewCellStyle2.Format = "C"
        Me.Monto.DefaultCellStyle = DataGridViewCellStyle2
        Me.Monto.HeaderText = "Monto"
        Me.Monto.Name = "Monto"
        Me.Monto.ReadOnly = True
        '
        'Modificar
        '
        Me.Modificar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Modificar.HeaderText = ""
        Me.Modificar.Image = Global.SistemaCinderella.My.Resources.Recursos.Boton_Editar
        Me.Modificar.MinimumWidth = 10
        Me.Modificar.Name = "Modificar"
        Me.Modificar.ReadOnly = True
        Me.Modificar.Width = 10
        '
        'Eliminar
        '
        Me.Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Eliminar.HeaderText = ""
        Me.Eliminar.Image = Global.SistemaCinderella.My.Resources.Recursos.Boton_Eliminar
        Me.Eliminar.MinimumWidth = 10
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.Width = 10
        '
        'InpuestosBindingSource
        '
        Me.InpuestosBindingSource.DataMember = "Inpuestos"
        Me.InpuestosBindingSource.DataSource = Me.FrmConfiguracionFacturacionImpuestosViewModelBindingSource
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 184.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Total, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_PorcentajeBonificacion, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox1, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(7, 22)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(485, 108)
        Me.TableLayoutPanel1.TabIndex = 36
        '
        'txt_Total
        '
        Me.txt_Total.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Total.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmConfiguracionFacturacionImpuestosViewModelBindingSource, "ImpuestoMonto", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.txt_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Total.Location = New System.Drawing.Point(188, 78)
        Me.txt_Total.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txt_Total.Name = "txt_Total"
        Me.txt_Total.Size = New System.Drawing.Size(293, 21)
        Me.txt_Total.TabIndex = 41
        Me.txt_Total.Text = "0,00"
        Me.txt_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 81)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(176, 15)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "(*) Monto Fijo a Aplicar"
        '
        'txt_PorcentajeBonificacion
        '
        Me.txt_PorcentajeBonificacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_PorcentajeBonificacion.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FrmConfiguracionFacturacionImpuestosViewModelBindingSource, "ImpuestoPorcentaje", True))
        Me.txt_PorcentajeBonificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PorcentajeBonificacion.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.txt_PorcentajeBonificacion.Location = New System.Drawing.Point(188, 42)
        Me.txt_PorcentajeBonificacion.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txt_PorcentajeBonificacion.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txt_PorcentajeBonificacion.Name = "txt_PorcentajeBonificacion"
        Me.txt_PorcentajeBonificacion.Size = New System.Drawing.Size(293, 21)
        Me.txt_PorcentajeBonificacion.TabIndex = 41
        Me.txt_PorcentajeBonificacion.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 45)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 15)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "(*) Porcentaje a Aplicar"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 15)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "(*) Descripción a Imprimir"
        '
        'txtCodigo
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmConfiguracionFacturacionImpuestosViewModelBindingSource, "ImpuestoDescripcion", True))
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(188, 7)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBox1.Name = "txtCodigo"
        Me.TextBox1.Size = New System.Drawing.Size(293, 21)
        Me.TextBox1.TabIndex = 14
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Cancelar.Image = Global.SistemaCinderella.My.Resources.Recursos.desconectado_32
        Me.Btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Cancelar.Location = New System.Drawing.Point(285, 534)
        Me.Btn_Cancelar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(117, 40)
        Me.Btn_Cancelar.TabIndex = 40
        Me.Btn_Cancelar.Text = "Cancelar"
        Me.Btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Cancelar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.Image = Global.SistemaCinderella.My.Resources.Recursos.Conectado_32
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(410, 534)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(111, 40)
        Me.BtnGuardar.TabIndex = 39
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.TableLayoutPanel3)
        Me.GroupBox4.Controls.Add(Me.Panel2)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(14, 12)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox4.Size = New System.Drawing.Size(506, 103)
        Me.GroupBox4.TabIndex = 41
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Habilitar Impuestos"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 184.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TextBox2, 1, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(10, 51)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(485, 40)
        Me.TableLayoutPanel3.TabIndex = 35
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 12)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(176, 15)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "(*) Encabezado a Imprimir"
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmConfiguracionFacturacionImpuestosViewModelBindingSource, "EncabezadoImpuestos", True))
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.FrmConfiguracionFacturacionImpuestosViewModelBindingSource, "HabilitarImpuestosSi", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(188, 9)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(293, 21)
        Me.TextBox2.TabIndex = 14
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.RHabilitarNo)
        Me.Panel2.Controls.Add(Me.RHabilitarSi)
        Me.Panel2.Location = New System.Drawing.Point(10, 21)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(181, 30)
        Me.Panel2.TabIndex = 34
        '
        'RHabilitarNo
        '
        Me.RHabilitarNo.AutoSize = True
        Me.RHabilitarNo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RHabilitarNo.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.FrmConfiguracionFacturacionImpuestosViewModelBindingSource, "HabilitarImpuestosNo", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.RHabilitarNo.Location = New System.Drawing.Point(126, 2)
        Me.RHabilitarNo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.RHabilitarNo.Name = "RHabilitarNo"
        Me.RHabilitarNo.Size = New System.Drawing.Size(43, 19)
        Me.RHabilitarNo.TabIndex = 26
        Me.RHabilitarNo.Tag = ""
        Me.RHabilitarNo.Text = "NO"
        Me.RHabilitarNo.UseVisualStyleBackColor = True
        '
        'RHabilitarSi
        '
        Me.RHabilitarSi.AutoSize = True
        Me.RHabilitarSi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RHabilitarSi.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.FrmConfiguracionFacturacionImpuestosViewModelBindingSource, "HabilitarImpuestosSi", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.RHabilitarSi.Location = New System.Drawing.Point(13, 3)
        Me.RHabilitarSi.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.RHabilitarSi.Name = "RHabilitarSi"
        Me.RHabilitarSi.Size = New System.Drawing.Size(36, 19)
        Me.RHabilitarSi.TabIndex = 0
        Me.RHabilitarSi.Tag = ""
        Me.RHabilitarSi.Text = "SI"
        Me.RHabilitarSi.UseVisualStyleBackColor = True
        '
        'frmConfiguracionFacturacionImpuestos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 586)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.Btn_Cancelar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmConfiguracionFacturacionImpuestos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuración Impuestos en Facturación"
        Me.GroupBox2.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.FrmConfiguracionFacturacionImpuestosViewModelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DG_Impuestos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InpuestosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.txt_PorcentajeBonificacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RIVANo As RadioButton
    Friend WithEvents RIVASi As RadioButton
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DG_Impuestos As CustomDataGrid
    Friend WithEvents Btn_Agregar_Imp As Button
    Friend WithEvents FrmConfiguracionFacturacionImpuestosViewModelBindingSource As BindingSource
    Friend WithEvents InpuestosBindingSource As BindingSource
    Friend WithEvents Btn_Cancelar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents txt_PorcentajeBonificacion As Controles.PercentUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_Total As TextBox
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PorcentajeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Monto As DataGridViewTextBoxColumn
    Friend WithEvents Modificar As DataGridViewImageColumn
    Friend WithEvents Eliminar As DataGridViewImageColumn
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents RHabilitarNo As RadioButton
    Friend WithEvents RHabilitarSi As RadioButton
End Class
