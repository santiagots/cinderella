<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCuentaBancariasBuscar

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
        Me.GB_Clientes = New System.Windows.Forms.GroupBox()
        Me.cmbBanco = New System.Windows.Forms.ComboBox()
        Me.BancosBusquedaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FrmCuentaBancariasBuscarViewModelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lbl_Msg = New System.Windows.Forms.Label()
        Me.Btn_Limpiar = New System.Windows.Forms.Button()
        Me.DG_CuentasBancarias = New System.Windows.Forms.DataGridView()
        Me.CuentasBancariasListadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BancoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CBUDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroCuentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CBUAliasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitularDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUITDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EsCuentaCorrienteDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GB_Clientes.SuspendLayout()
        CType(Me.BancosBusquedaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FrmCuentaBancariasBuscarViewModelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_CuentasBancarias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuentasBancariasListadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GB_Clientes
        '
        Me.GB_Clientes.Controls.Add(Me.cmbBanco)
        Me.GB_Clientes.Controls.Add(Me.lbl_Msg)
        Me.GB_Clientes.Controls.Add(Me.Btn_Limpiar)
        Me.GB_Clientes.Controls.Add(Me.DG_CuentasBancarias)
        Me.GB_Clientes.Controls.Add(Me.btn_Buscar)
        Me.GB_Clientes.Controls.Add(Me.Label1)
        Me.GB_Clientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GB_Clientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Clientes.Location = New System.Drawing.Point(0, 0)
        Me.GB_Clientes.Name = "GB_Clientes"
        Me.GB_Clientes.Size = New System.Drawing.Size(594, 378)
        Me.GB_Clientes.TabIndex = 0
        Me.GB_Clientes.TabStop = False
        Me.GB_Clientes.Text = "Buscar Cuentas Bancarias"
        '
        'cmbBanco
        '
        Me.cmbBanco.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbBanco.DataSource = Me.BancosBusquedaBindingSource
        Me.cmbBanco.DisplayMember = "Value"
        Me.cmbBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBanco.FormattingEnabled = True
        Me.cmbBanco.Location = New System.Drawing.Point(56, 30)
        Me.cmbBanco.Name = "cmbBanco"
        Me.cmbBanco.Size = New System.Drawing.Size(338, 23)
        Me.cmbBanco.TabIndex = 0
        Me.cmbBanco.ValueMember = "Key"
        '
        'BancosBusquedaBindingSource
        '
        Me.BancosBusquedaBindingSource.DataMember = "BancosBusqueda"
        Me.BancosBusquedaBindingSource.DataSource = Me.FrmCuentaBancariasBuscarViewModelBindingSource
        '
        'FrmCuentaBancariasBuscarViewModelBindingSource
        '
        Me.FrmCuentaBancariasBuscarViewModelBindingSource.DataSource = GetType(SistemaCinderella.Formularios.CuentaBancaria.frmCuentaBancariasBuscarViewModel)
        '
        'lbl_Msg
        '
        Me.lbl_Msg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Msg.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lbl_Msg.DataBindings.Add(New System.Windows.Forms.Binding("Visible", Me.FrmCuentaBancariasBuscarViewModelBindingSource, "SinResultados", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.lbl_Msg.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Msg.Location = New System.Drawing.Point(99, 185)
        Me.lbl_Msg.Name = "lbl_Msg"
        Me.lbl_Msg.Size = New System.Drawing.Size(398, 59)
        Me.lbl_Msg.TabIndex = 13
        Me.lbl_Msg.Text = "No se han encontrado bancos."
        Me.lbl_Msg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Btn_Limpiar
        '
        Me.Btn_Limpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Limpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Limpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Limpiar.Image = Global.SistemaCinderella.My.Resources.Recursos.Limpiar_32
        Me.Btn_Limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Limpiar.Location = New System.Drawing.Point(400, 20)
        Me.Btn_Limpiar.Name = "Btn_Limpiar"
        Me.Btn_Limpiar.Size = New System.Drawing.Size(97, 40)
        Me.Btn_Limpiar.TabIndex = 1
        Me.Btn_Limpiar.Text = "Limpiar"
        Me.Btn_Limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Limpiar.UseVisualStyleBackColor = True
        '
        'DG_CuentasBancarias
        '
        Me.DG_CuentasBancarias.AllowUserToAddRows = False
        Me.DG_CuentasBancarias.AllowUserToDeleteRows = False
        Me.DG_CuentasBancarias.AllowUserToResizeColumns = False
        Me.DG_CuentasBancarias.AllowUserToResizeRows = False
        Me.DG_CuentasBancarias.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_CuentasBancarias.AutoGenerateColumns = False
        Me.DG_CuentasBancarias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_CuentasBancarias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_CuentasBancarias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BancoDataGridViewTextBoxColumn, Me.CBUDataGridViewTextBoxColumn, Me.NumeroCuentaDataGridViewTextBoxColumn, Me.CBUAliasDataGridViewTextBoxColumn, Me.TitularDataGridViewTextBoxColumn, Me.CUITDataGridViewTextBoxColumn, Me.EsCuentaCorrienteDataGridViewCheckBoxColumn})
        Me.DG_CuentasBancarias.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DG_CuentasBancarias.DataSource = Me.CuentasBancariasListadoBindingSource
        Me.DG_CuentasBancarias.Location = New System.Drawing.Point(9, 66)
        Me.DG_CuentasBancarias.MultiSelect = False
        Me.DG_CuentasBancarias.Name = "DG_CuentasBancarias"
        Me.DG_CuentasBancarias.ReadOnly = True
        Me.DG_CuentasBancarias.RowHeadersVisible = False
        Me.DG_CuentasBancarias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_CuentasBancarias.Size = New System.Drawing.Size(579, 296)
        Me.DG_CuentasBancarias.TabIndex = 3
        '
        'CuentasBancariasListadoBindingSource
        '
        Me.CuentasBancariasListadoBindingSource.DataMember = "CuentasBancariasListado"
        Me.CuentasBancariasListadoBindingSource.DataSource = Me.FrmCuentaBancariasBuscarViewModelBindingSource
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Buscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Buscar.Image = Global.SistemaCinderella.My.Resources.Recursos.IconoBuscar32
        Me.btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Buscar.Location = New System.Drawing.Point(503, 20)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(85, 40)
        Me.btn_Buscar.TabIndex = 2
        Me.btn_Buscar.Text = "Buscar"
        Me.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Banco"
        '
        'BancoDataGridViewTextBoxColumn
        '
        Me.BancoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.BancoDataGridViewTextBoxColumn.DataPropertyName = "Banco"
        Me.BancoDataGridViewTextBoxColumn.HeaderText = "Banco"
        Me.BancoDataGridViewTextBoxColumn.Name = "BancoDataGridViewTextBoxColumn"
        Me.BancoDataGridViewTextBoxColumn.ReadOnly = True
        Me.BancoDataGridViewTextBoxColumn.Width = 67
        '
        'CBUDataGridViewTextBoxColumn
        '
        Me.CBUDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CBUDataGridViewTextBoxColumn.DataPropertyName = "CBU"
        Me.CBUDataGridViewTextBoxColumn.HeaderText = "CBU"
        Me.CBUDataGridViewTextBoxColumn.Name = "CBUDataGridViewTextBoxColumn"
        Me.CBUDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NumeroCuentaDataGridViewTextBoxColumn
        '
        Me.NumeroCuentaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.NumeroCuentaDataGridViewTextBoxColumn.DataPropertyName = "NumeroCuenta"
        Me.NumeroCuentaDataGridViewTextBoxColumn.HeaderText = "Nro Cuenta"
        Me.NumeroCuentaDataGridViewTextBoxColumn.Name = "NumeroCuentaDataGridViewTextBoxColumn"
        Me.NumeroCuentaDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumeroCuentaDataGridViewTextBoxColumn.Width = 94
        '
        'CBUAliasDataGridViewTextBoxColumn
        '
        Me.CBUAliasDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CBUAliasDataGridViewTextBoxColumn.DataPropertyName = "CBUAlias"
        Me.CBUAliasDataGridViewTextBoxColumn.HeaderText = "Alias"
        Me.CBUAliasDataGridViewTextBoxColumn.Name = "CBUAliasDataGridViewTextBoxColumn"
        Me.CBUAliasDataGridViewTextBoxColumn.ReadOnly = True
        Me.CBUAliasDataGridViewTextBoxColumn.Width = 58
        '
        'TitularDataGridViewTextBoxColumn
        '
        Me.TitularDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TitularDataGridViewTextBoxColumn.DataPropertyName = "Titular"
        Me.TitularDataGridViewTextBoxColumn.HeaderText = "Titular"
        Me.TitularDataGridViewTextBoxColumn.Name = "TitularDataGridViewTextBoxColumn"
        Me.TitularDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CUITDataGridViewTextBoxColumn
        '
        Me.CUITDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CUITDataGridViewTextBoxColumn.DataPropertyName = "CUIT"
        Me.CUITDataGridViewTextBoxColumn.HeaderText = "CUIT"
        Me.CUITDataGridViewTextBoxColumn.Name = "CUITDataGridViewTextBoxColumn"
        Me.CUITDataGridViewTextBoxColumn.ReadOnly = True
        Me.CUITDataGridViewTextBoxColumn.Width = 59
        '
        'EsCuentaCorrienteDataGridViewCheckBoxColumn
        '
        Me.EsCuentaCorrienteDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.EsCuentaCorrienteDataGridViewCheckBoxColumn.DataPropertyName = "EsCuentaCorriente"
        Me.EsCuentaCorrienteDataGridViewCheckBoxColumn.HeaderText = "Cta. Cte."
        Me.EsCuentaCorrienteDataGridViewCheckBoxColumn.Name = "EsCuentaCorrienteDataGridViewCheckBoxColumn"
        Me.EsCuentaCorrienteDataGridViewCheckBoxColumn.ReadOnly = True
        Me.EsCuentaCorrienteDataGridViewCheckBoxColumn.Width = 58
        '
        'frmCuentaBancariasBuscar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 378)
        Me.Controls.Add(Me.GB_Clientes)
        Me.Name = "frmCuentaBancariasBuscar"
        Me.Text = "Buscar Cuentas Bancarias"
        Me.GB_Clientes.ResumeLayout(False)
        Me.GB_Clientes.PerformLayout()
        CType(Me.BancosBusquedaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FrmCuentaBancariasBuscarViewModelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_CuentasBancarias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuentasBancariasListadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GB_Clientes As GroupBox
    Friend WithEvents lbl_Msg As Label
    Friend WithEvents DG_CuentasBancarias As DataGridView
    Friend WithEvents btn_Buscar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents FrmCuentaBancariasBuscarViewModelBindingSource As BindingSource
    Friend WithEvents cmbBanco As ComboBox
    Friend WithEvents BancosBusquedaBindingSource As BindingSource
    Friend WithEvents Btn_Limpiar As Button
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BancoSeleccionadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BancoNombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CuentasBancariasListadoBindingSource As BindingSource
    Friend WithEvents BancoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CBUDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumeroCuentaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CBUAliasDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TitularDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CUITDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EsCuentaCorrienteDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
End Class
