<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBuscarClienteMinorista
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscarClienteMinorista))
        Me.GB_Clientes = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lbl_Msg = New System.Windows.Forms.Label()
        Me.Btn_Limpiar = New System.Windows.Forms.Button()
        Me.lbl_informacion = New System.Windows.Forms.Label()
        Me.DG_Clientes = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteMinoristaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.ToolCliente = New System.Windows.Forms.ToolTip(Me.components)
        Me.GB_Clientes.SuspendLayout()
        CType(Me.DG_Clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteMinoristaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GB_Clientes
        '
        Me.GB_Clientes.Controls.Add(Me.Label2)
        Me.GB_Clientes.Controls.Add(Me.txtNombre)
        Me.GB_Clientes.Controls.Add(Me.lbl_Msg)
        Me.GB_Clientes.Controls.Add(Me.Btn_Limpiar)
        Me.GB_Clientes.Controls.Add(Me.lbl_informacion)
        Me.GB_Clientes.Controls.Add(Me.DG_Clientes)
        Me.GB_Clientes.Controls.Add(Me.btn_Buscar)
        Me.GB_Clientes.Controls.Add(Me.Label1)
        Me.GB_Clientes.Controls.Add(Me.txtApellido)
        Me.GB_Clientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Clientes.Location = New System.Drawing.Point(12, 12)
        Me.GB_Clientes.Name = "GB_Clientes"
        Me.GB_Clientes.Size = New System.Drawing.Size(570, 386)
        Me.GB_Clientes.TabIndex = 1
        Me.GB_Clientes.TabStop = False
        Me.GB_Clientes.Text = "Buscar Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 15)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(91, 102)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(244, 21)
        Me.txtNombre.TabIndex = 15
        Me.ToolCliente.SetToolTip(Me.txtNombre, "Usted puede realizar una busqueda por palabra completa  o parte de ella.")
        '
        'lbl_Msg
        '
        Me.lbl_Msg.AutoSize = True
        Me.lbl_Msg.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lbl_Msg.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Msg.Location = New System.Drawing.Point(99, 259)
        Me.lbl_Msg.Name = "lbl_Msg"
        Me.lbl_Msg.Size = New System.Drawing.Size(374, 29)
        Me.lbl_Msg.TabIndex = 13
        Me.lbl_Msg.Text = "No se han encontrado clientes."
        '
        'Btn_Limpiar
        '
        Me.Btn_Limpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Limpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Limpiar.Image = Global.SistemaCinderella.My.Resources.Recursos.desconectado_32
        Me.Btn_Limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Limpiar.Location = New System.Drawing.Point(388, 75)
        Me.Btn_Limpiar.Name = "Btn_Limpiar"
        Me.Btn_Limpiar.Size = New System.Drawing.Size(85, 40)
        Me.Btn_Limpiar.TabIndex = 10
        Me.Btn_Limpiar.Text = "Limpiar"
        Me.Btn_Limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolCliente.SetToolTip(Me.Btn_Limpiar, "Limpia la grilla y los criterios de busqueda. Se vuelven a visualizar todos los c" &
        "lientes.")
        Me.Btn_Limpiar.UseVisualStyleBackColor = True
        '
        'lbl_informacion
        '
        Me.lbl_informacion.Location = New System.Drawing.Point(8, 27)
        Me.lbl_informacion.Name = "lbl_informacion"
        Me.lbl_informacion.Size = New System.Drawing.Size(556, 35)
        Me.lbl_informacion.TabIndex = 6
        Me.lbl_informacion.Text = "Por favor, complete el/los siguientes campos con la nombre y o apellido del clien" &
    "te y luego presione ""Buscar"". La operación puede tardar unos minutos."
        '
        'DG_Clientes
        '
        Me.DG_Clientes.AllowUserToAddRows = False
        Me.DG_Clientes.AllowUserToDeleteRows = False
        Me.DG_Clientes.AllowUserToResizeColumns = False
        Me.DG_Clientes.AllowUserToResizeRows = False
        Me.DG_Clientes.AutoGenerateColumns = False
        Me.DG_Clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Clientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.ApellidoDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn})
        Me.DG_Clientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DG_Clientes.DataSource = Me.ClienteMinoristaBindingSource
        Me.DG_Clientes.Location = New System.Drawing.Point(9, 129)
        Me.DG_Clientes.MultiSelect = False
        Me.DG_Clientes.Name = "DG_Clientes"
        Me.DG_Clientes.ReadOnly = True
        Me.DG_Clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Clientes.Size = New System.Drawing.Size(555, 251)
        Me.DG_Clientes.TabIndex = 3
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Visible = False
        '
        'ApellidoDataGridViewTextBoxColumn
        '
        Me.ApellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido"
        Me.ApellidoDataGridViewTextBoxColumn.HeaderText = "Apellido"
        Me.ApellidoDataGridViewTextBoxColumn.Name = "ApellidoDataGridViewTextBoxColumn"
        Me.ApellidoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        Me.TelefonoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ClienteMinoristaBindingSource
        '
        Me.ClienteMinoristaBindingSource.DataSource = GetType(Entidades.ClienteMinorista)
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Buscar.Image = Global.SistemaCinderella.My.Resources.Recursos.IconoBuscar32
        Me.btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Buscar.Location = New System.Drawing.Point(479, 75)
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
        Me.Label1.Size = New System.Drawing.Size(51, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Apellido"
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(91, 75)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(244, 21)
        Me.txtApellido.TabIndex = 1
        Me.ToolCliente.SetToolTip(Me.txtApellido, "Usted puede realizar una busqueda por palabra completa  o parte de ella.")
        '
        'ToolCliente
        '
        Me.ToolCliente.IsBalloon = True
        Me.ToolCliente.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolCliente.ToolTipTitle = "Ayuda"
        '
        'frmBuscarClienteMinorista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 410)
        Me.Controls.Add(Me.GB_Clientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmBuscarClienteMinorista"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Cliente"
        Me.GB_Clientes.ResumeLayout(False)
        Me.GB_Clientes.PerformLayout()
        CType(Me.DG_Clientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteMinoristaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GB_Clientes As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_informacion As System.Windows.Forms.Label
    Friend WithEvents ToolCliente As System.Windows.Forms.ToolTip
    Friend WithEvents Btn_Limpiar As System.Windows.Forms.Button
    Friend WithEvents lbl_Msg As System.Windows.Forms.Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApellidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClienteMinoristaBindingSource As BindingSource
    Friend WithEvents DG_Clientes As DataGridView
End Class
