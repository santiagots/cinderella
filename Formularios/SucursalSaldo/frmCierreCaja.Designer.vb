<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCierreCaja
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCierreCaja))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.FDesde = New System.Windows.Forms.DateTimePicker()
        Me.FrmCierreCajaViewModelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label11 = New System.Windows.Forms.Label()
        Me.FHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SituacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btn_Restablecer = New System.Windows.Forms.Button()
        Me.BtnFiltrar = New System.Windows.Forms.Button()
        Me.txt_Total = New System.Windows.Forms.TextBox()
        Me.lbl_DescrTot = New System.Windows.Forms.Label()
        Me.lbl_Msg = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DG_Ventas = New System.Windows.Forms.DataGridView()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiferenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SituacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComentariosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CierresCajasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.FrmCierreCajaViewModelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SituacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DG_Ventas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CierresCajasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox1.Controls.Add(Me.btn_Restablecer)
        Me.GroupBox1.Controls.Add(Me.BtnFiltrar)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(718, 137)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtrar cierre caja"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.94771!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.05228!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label12, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.FDesde, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label11, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.FHasta, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label20, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.ComboBox1, 1, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 20)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(600, 105)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(3, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(209, 16)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Fecha desde"
        '
        'FDesde
        '
        Me.FDesde.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FDesde.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FrmCierreCajaViewModelBindingSource, "FechaDesde", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "D"))
        Me.FDesde.Location = New System.Drawing.Point(218, 7)
        Me.FDesde.Name = "FDesde"
        Me.FDesde.Size = New System.Drawing.Size(379, 21)
        Me.FDesde.TabIndex = 0
        '
        'FrmCierreCajaViewModelBindingSource
        '
        Me.FrmCierreCajaViewModelBindingSource.DataSource = GetType(SistemaCinderella.Formularios.SucursalSaldo.frmCierreCajaViewModel)
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(3, 44)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(209, 16)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Fecha hasta"
        '
        'FHasta
        '
        Me.FHasta.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FHasta.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FrmCierreCajaViewModelBindingSource, "FechaHasta", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "D"))
        Me.FHasta.Location = New System.Drawing.Point(218, 42)
        Me.FHasta.Name = "FHasta"
        Me.FHasta.Size = New System.Drawing.Size(379, 21)
        Me.FHasta.TabIndex = 1
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(3, 79)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(209, 16)
        Me.Label20.TabIndex = 431
        Me.Label20.Text = "Situación"
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.FrmCierreCajaViewModelBindingSource, "SituacionSeleccionada", True))
        Me.ComboBox1.DataSource = Me.SituacionBindingSource
        Me.ComboBox1.DisplayMember = "Value"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(218, 76)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(379, 23)
        Me.ComboBox1.TabIndex = 432
        Me.ComboBox1.ValueMember = "Key"
        '
        'SituacionBindingSource
        '
        Me.SituacionBindingSource.DataMember = "Situacion"
        Me.SituacionBindingSource.DataSource = Me.FrmCierreCajaViewModelBindingSource
        '
        'btn_Restablecer
        '
        Me.btn_Restablecer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Restablecer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Restablecer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Restablecer.Location = New System.Drawing.Point(618, 20)
        Me.btn_Restablecer.Name = "btn_Restablecer"
        Me.btn_Restablecer.Size = New System.Drawing.Size(94, 41)
        Me.btn_Restablecer.TabIndex = 9
        Me.btn_Restablecer.Text = "Restablecer Busqueda"
        Me.btn_Restablecer.UseVisualStyleBackColor = True
        '
        'BtnFiltrar
        '
        Me.BtnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFiltrar.FlatAppearance.BorderSize = 0
        Me.BtnFiltrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFiltrar.Image = Global.SistemaCinderella.My.Resources.Recursos.IconoBuscar32
        Me.BtnFiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnFiltrar.Location = New System.Drawing.Point(618, 84)
        Me.BtnFiltrar.Name = "BtnFiltrar"
        Me.BtnFiltrar.Size = New System.Drawing.Size(94, 41)
        Me.BtnFiltrar.TabIndex = 4
        Me.BtnFiltrar.Text = "Buscar"
        Me.BtnFiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnFiltrar.UseVisualStyleBackColor = True
        '
        'txt_Total
        '
        Me.txt_Total.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Total.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmCierreCajaViewModelBindingSource, "TotalDiferencia", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.txt_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Total.Location = New System.Drawing.Point(530, 476)
        Me.txt_Total.Name = "txt_Total"
        Me.txt_Total.ReadOnly = True
        Me.txt_Total.Size = New System.Drawing.Size(200, 35)
        Me.txt_Total.TabIndex = 32
        Me.txt_Total.Text = "0,00"
        Me.txt_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_DescrTot
        '
        Me.lbl_DescrTot.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_DescrTot.AutoSize = True
        Me.lbl_DescrTot.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DescrTot.Location = New System.Drawing.Point(326, 482)
        Me.lbl_DescrTot.Name = "lbl_DescrTot"
        Me.lbl_DescrTot.Size = New System.Drawing.Size(198, 29)
        Me.lbl_DescrTot.TabIndex = 31
        Me.lbl_DescrTot.Text = "Total Diferencia:"
        '
        'lbl_Msg
        '
        Me.lbl_Msg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Msg.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lbl_Msg.DataBindings.Add(New System.Windows.Forms.Binding("Visible", Me.FrmCierreCajaViewModelBindingSource, "SinResultados", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.lbl_Msg.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Msg.Location = New System.Drawing.Point(146, 138)
        Me.lbl_Msg.Name = "lbl_Msg"
        Me.lbl_Msg.Size = New System.Drawing.Size(426, 65)
        Me.lbl_Msg.TabIndex = 2
        Me.lbl_Msg.Text = "No se han encontrado cierres de caja."
        Me.lbl_Msg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.lbl_Msg)
        Me.GroupBox2.Controls.Add(Me.DG_Ventas)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 143)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(718, 327)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ventas"
        '
        'DG_Ventas
        '
        Me.DG_Ventas.AllowUserToAddRows = False
        Me.DG_Ventas.AllowUserToDeleteRows = False
        Me.DG_Ventas.AllowUserToResizeColumns = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DG_Ventas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DG_Ventas.AutoGenerateColumns = False
        Me.DG_Ventas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FechaDataGridViewTextBoxColumn, Me.MontoDataGridViewTextBoxColumn, Me.DiferenciaDataGridViewTextBoxColumn, Me.SituacionDataGridViewTextBoxColumn, Me.ComentariosDataGridViewTextBoxColumn})
        Me.DG_Ventas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DG_Ventas.DataSource = Me.CierresCajasBindingSource
        Me.DG_Ventas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_Ventas.Location = New System.Drawing.Point(3, 17)
        Me.DG_Ventas.MultiSelect = False
        Me.DG_Ventas.Name = "DG_Ventas"
        Me.DG_Ventas.ReadOnly = True
        Me.DG_Ventas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DG_Ventas.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DG_Ventas.RowTemplate.Height = 30
        Me.DG_Ventas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Ventas.Size = New System.Drawing.Size(712, 307)
        Me.DG_Ventas.TabIndex = 0
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaDataGridViewTextBoxColumn.Width = 66
        '
        'MontoDataGridViewTextBoxColumn
        '
        Me.MontoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MontoDataGridViewTextBoxColumn.DataPropertyName = "Monto"
        Me.MontoDataGridViewTextBoxColumn.HeaderText = "Monto"
        Me.MontoDataGridViewTextBoxColumn.Name = "MontoDataGridViewTextBoxColumn"
        Me.MontoDataGridViewTextBoxColumn.ReadOnly = True
        Me.MontoDataGridViewTextBoxColumn.Width = 67
        '
        'DiferenciaDataGridViewTextBoxColumn
        '
        Me.DiferenciaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DiferenciaDataGridViewTextBoxColumn.DataPropertyName = "Diferencia"
        Me.DiferenciaDataGridViewTextBoxColumn.HeaderText = "Diferencia"
        Me.DiferenciaDataGridViewTextBoxColumn.Name = "DiferenciaDataGridViewTextBoxColumn"
        Me.DiferenciaDataGridViewTextBoxColumn.ReadOnly = True
        Me.DiferenciaDataGridViewTextBoxColumn.Width = 88
        '
        'SituacionDataGridViewTextBoxColumn
        '
        Me.SituacionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SituacionDataGridViewTextBoxColumn.DataPropertyName = "Situacion"
        Me.SituacionDataGridViewTextBoxColumn.HeaderText = "Situacion"
        Me.SituacionDataGridViewTextBoxColumn.Name = "SituacionDataGridViewTextBoxColumn"
        Me.SituacionDataGridViewTextBoxColumn.ReadOnly = True
        Me.SituacionDataGridViewTextBoxColumn.Width = 83
        '
        'ComentariosDataGridViewTextBoxColumn
        '
        Me.ComentariosDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ComentariosDataGridViewTextBoxColumn.DataPropertyName = "Comentarios"
        Me.ComentariosDataGridViewTextBoxColumn.HeaderText = "Comentarios"
        Me.ComentariosDataGridViewTextBoxColumn.Name = "ComentariosDataGridViewTextBoxColumn"
        Me.ComentariosDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CierresCajasBindingSource
        '
        Me.CierresCajasBindingSource.DataMember = "CierresCajas"
        Me.CierresCajasBindingSource.DataSource = Me.FrmCierreCajaViewModelBindingSource
        '
        'frmCierreCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(742, 523)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txt_Total)
        Me.Controls.Add(Me.lbl_DescrTot)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCierreCaja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Historial Cierre Caja"
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.FrmCierreCajaViewModelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SituacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DG_Ventas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CierresCajasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label12 As Label
    Friend WithEvents FDesde As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents FHasta As DateTimePicker
    Friend WithEvents Label20 As Label
    Friend WithEvents btn_Restablecer As Button
    Friend WithEvents BtnFiltrar As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents txt_Total As TextBox
    Friend WithEvents lbl_DescrTot As Label
    Friend WithEvents lbl_Msg As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DG_Ventas As DataGridView
    Friend WithEvents FrmCierreCajaViewModelBindingSource As BindingSource
    Friend WithEvents SituacionBindingSource As BindingSource
    Friend WithEvents CierresCajasBindingSource As BindingSource
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MontoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiferenciaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SituacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ComentariosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
