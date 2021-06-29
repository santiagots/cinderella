<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTransporteBuscar

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTransporteBuscar))
        Me.GB_Transportes = New System.Windows.Forms.GroupBox()
        Me.lbl_Msg = New System.Windows.Forms.Label()
        Me.FrmTransporteBuscarViewModelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Btn_Limpiar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_informacion = New System.Windows.Forms.Label()
        Me.DG_Clientes = New System.Windows.Forms.DataGridView()
        Me.TransportesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_Buscar = New System.Windows.Forms.TextBox()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RazonSocialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUITDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GB_Transportes.SuspendLayout()
        CType(Me.FrmTransporteBuscarViewModelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_Clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransportesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GB_Transportes
        '
        Me.GB_Transportes.Controls.Add(Me.lbl_Msg)
        Me.GB_Transportes.Controls.Add(Me.Btn_Limpiar)
        Me.GB_Transportes.Controls.Add(Me.Label2)
        Me.GB_Transportes.Controls.Add(Me.lbl_informacion)
        Me.GB_Transportes.Controls.Add(Me.DG_Clientes)
        Me.GB_Transportes.Controls.Add(Me.btn_Buscar)
        Me.GB_Transportes.Controls.Add(Me.Label1)
        Me.GB_Transportes.Controls.Add(Me.txt_Buscar)
        Me.GB_Transportes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GB_Transportes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Transportes.Location = New System.Drawing.Point(0, 0)
        Me.GB_Transportes.Name = "GB_Transportes"
        Me.GB_Transportes.Size = New System.Drawing.Size(594, 378)
        Me.GB_Transportes.TabIndex = 2
        Me.GB_Transportes.TabStop = False
        Me.GB_Transportes.Text = "Buscar Transporte"
        '
        'lbl_Msg
        '
        Me.lbl_Msg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Msg.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lbl_Msg.DataBindings.Add(New System.Windows.Forms.Binding("Visible", Me.FrmTransporteBuscarViewModelBindingSource, "SinResultados", True))
        Me.lbl_Msg.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Msg.Location = New System.Drawing.Point(99, 207)
        Me.lbl_Msg.Name = "lbl_Msg"
        Me.lbl_Msg.Size = New System.Drawing.Size(398, 59)
        Me.lbl_Msg.TabIndex = 13
        Me.lbl_Msg.Text = "No se han encontrado Transportes."
        Me.lbl_Msg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmTransporteBuscarViewModelBindingSource
        '
        Me.FrmTransporteBuscarViewModelBindingSource.DataSource = GetType(SistemaCinderella.Formularios.Cliente.frmTransporteBuscarViewModel)
        '
        'Btn_Limpiar
        '
        Me.Btn_Limpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Limpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Limpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Limpiar.Image = Global.SistemaCinderella.My.Resources.Recursos.Limpiar_32
        Me.Btn_Limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Limpiar.Location = New System.Drawing.Point(400, 65)
        Me.Btn_Limpiar.Name = "Btn_Limpiar"
        Me.Btn_Limpiar.Size = New System.Drawing.Size(97, 40)
        Me.Btn_Limpiar.TabIndex = 10
        Me.Btn_Limpiar.Text = "Limpiar"
        Me.Btn_Limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Limpiar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(232, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "La operación puede tardar unos minutos."
        '
        'lbl_informacion
        '
        Me.lbl_informacion.AutoSize = True
        Me.lbl_informacion.Location = New System.Drawing.Point(8, 27)
        Me.lbl_informacion.Name = "lbl_informacion"
        Me.lbl_informacion.Size = New System.Drawing.Size(547, 15)
        Me.lbl_informacion.TabIndex = 6
        Me.lbl_informacion.Text = "Por favor, complete el siguiente campo con la razón social del transporte y luego" &
    " presione ""Buscar""."
        '
        'DG_Clientes
        '
        Me.DG_Clientes.AllowUserToAddRows = False
        Me.DG_Clientes.AllowUserToDeleteRows = False
        Me.DG_Clientes.AllowUserToResizeColumns = False
        Me.DG_Clientes.AllowUserToResizeRows = False
        Me.DG_Clientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_Clientes.AutoGenerateColumns = False
        Me.DG_Clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Clientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.RazonSocialDataGridViewTextBoxColumn, Me.CUITDataGridViewTextBoxColumn})
        Me.DG_Clientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DG_Clientes.DataSource = Me.TransportesBindingSource
        Me.DG_Clientes.Location = New System.Drawing.Point(9, 111)
        Me.DG_Clientes.MultiSelect = False
        Me.DG_Clientes.Name = "DG_Clientes"
        Me.DG_Clientes.ReadOnly = True
        Me.DG_Clientes.RowHeadersVisible = False
        Me.DG_Clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Clientes.Size = New System.Drawing.Size(579, 251)
        Me.DG_Clientes.TabIndex = 3
        '
        'TransportesBindingSource
        '
        Me.TransportesBindingSource.DataMember = "Transportes"
        Me.TransportesBindingSource.DataSource = Me.FrmTransporteBuscarViewModelBindingSource
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Buscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Buscar.Image = Global.SistemaCinderella.My.Resources.Recursos.IconoBuscar32
        Me.btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Buscar.Location = New System.Drawing.Point(503, 65)
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
        Me.Label1.Location = New System.Drawing.Point(8, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Razón Social"
        '
        'txt_Buscar
        '
        Me.txt_Buscar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Buscar.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmTransporteBuscarViewModelBindingSource, "RazonSocial", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_Buscar.Location = New System.Drawing.Point(91, 75)
        Me.txt_Buscar.Name = "txt_Buscar"
        Me.txt_Buscar.Size = New System.Drawing.Size(303, 21)
        Me.txt_Buscar.TabIndex = 1
        '
        'Id
        '
        Me.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Id.DataPropertyName = "Id"
        Me.Id.HeaderText = "Cód."
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Width = 57
        '
        'RazonSocialDataGridViewTextBoxColumn
        '
        Me.RazonSocialDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.RazonSocialDataGridViewTextBoxColumn.DataPropertyName = "RazonSocial"
        Me.RazonSocialDataGridViewTextBoxColumn.HeaderText = "Razón Social"
        Me.RazonSocialDataGridViewTextBoxColumn.Name = "RazonSocialDataGridViewTextBoxColumn"
        Me.RazonSocialDataGridViewTextBoxColumn.ReadOnly = True
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
        'frmTransporteBuscar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 378)
        Me.Controls.Add(Me.GB_Transportes)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTransporteBuscar"
        Me.Text = "Buscar Transporte"
        Me.GB_Transportes.ResumeLayout(False)
        Me.GB_Transportes.PerformLayout()
        CType(Me.FrmTransporteBuscarViewModelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_Clientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransportesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GB_Transportes As GroupBox
    Friend WithEvents lbl_Msg As Label
    Friend WithEvents Btn_Limpiar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_informacion As Label
    Friend WithEvents DG_Clientes As DataGridView
    Friend WithEvents btn_Buscar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_Buscar As TextBox
    Friend WithEvents FrmTransporteBuscarViewModelBindingSource As BindingSource
    Friend WithEvents TransportesBindingSource As BindingSource
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents RazonSocialDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CUITDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
