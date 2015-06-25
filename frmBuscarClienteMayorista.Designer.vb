<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarClienteMayorista
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscarClienteMayorista))
        Me.GB_Clientes = New System.Windows.Forms.GroupBox()
        Me.Btn_Limpiar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_informacion = New System.Windows.Forms.Label()
        Me.DG_Clientes = New System.Windows.Forms.DataGridView()
        Me.id_Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RazonSocial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_Buscar = New System.Windows.Forms.TextBox()
        Me.ErroresClie = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolCliente = New System.Windows.Forms.ToolTip(Me.components)
        Me.lbl_Msg = New System.Windows.Forms.Label()
        Me.GB_Clientes.SuspendLayout()
        CType(Me.DG_Clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErroresClie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GB_Clientes
        '
        Me.GB_Clientes.Controls.Add(Me.lbl_Msg)
        Me.GB_Clientes.Controls.Add(Me.Btn_Limpiar)
        Me.GB_Clientes.Controls.Add(Me.Label2)
        Me.GB_Clientes.Controls.Add(Me.lbl_informacion)
        Me.GB_Clientes.Controls.Add(Me.DG_Clientes)
        Me.GB_Clientes.Controls.Add(Me.btn_Buscar)
        Me.GB_Clientes.Controls.Add(Me.Label1)
        Me.GB_Clientes.Controls.Add(Me.txt_Buscar)
        Me.GB_Clientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Clientes.Location = New System.Drawing.Point(12, 12)
        Me.GB_Clientes.Name = "GB_Clientes"
        Me.GB_Clientes.Size = New System.Drawing.Size(570, 348)
        Me.GB_Clientes.TabIndex = 1
        Me.GB_Clientes.TabStop = False
        Me.GB_Clientes.Text = "Buscar Cliente"
        '
        'Btn_Limpiar
        '
        Me.Btn_Limpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Limpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Limpiar.Image = Global.SistemaCinderella.My.Resources.Recursos.desconectado_32
        Me.Btn_Limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Limpiar.Location = New System.Drawing.Point(388, 65)
        Me.Btn_Limpiar.Name = "Btn_Limpiar"
        Me.Btn_Limpiar.Size = New System.Drawing.Size(85, 40)
        Me.Btn_Limpiar.TabIndex = 10
        Me.Btn_Limpiar.Text = "Limpiar"
        Me.Btn_Limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolCliente.SetToolTip(Me.Btn_Limpiar, "Limpia la grilla y los criterios de busqueda. Se vuelven a visualizar todos los c" & _
                "lientes.")
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
        Me.lbl_informacion.Size = New System.Drawing.Size(528, 15)
        Me.lbl_informacion.TabIndex = 6
        Me.lbl_informacion.Text = "Por favor, complete el siguiente campo con la razon social del cliente y luego pr" & _
            "esione ""Buscar""."
        '
        'DG_Clientes
        '
        Me.DG_Clientes.AllowUserToAddRows = False
        Me.DG_Clientes.AllowUserToDeleteRows = False
        Me.DG_Clientes.AllowUserToResizeColumns = False
        Me.DG_Clientes.AllowUserToResizeRows = False
        Me.DG_Clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Clientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_Cliente, Me.RazonSocial, Me.Mail, Me.Telefono})
        Me.DG_Clientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DG_Clientes.Location = New System.Drawing.Point(9, 111)
        Me.DG_Clientes.MultiSelect = False
        Me.DG_Clientes.Name = "DG_Clientes"
        Me.DG_Clientes.ReadOnly = True
        Me.DG_Clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Clientes.Size = New System.Drawing.Size(555, 221)
        Me.DG_Clientes.TabIndex = 3
        '
        'id_Cliente
        '
        Me.id_Cliente.DataPropertyName = "id_Cliente"
        Me.id_Cliente.FillWeight = 12.22914!
        Me.id_Cliente.HeaderText = "ID"
        Me.id_Cliente.Name = "id_Cliente"
        Me.id_Cliente.ReadOnly = True
        '
        'RazonSocial
        '
        Me.RazonSocial.DataPropertyName = "RazonSocial"
        Me.RazonSocial.FillWeight = 151.6849!
        Me.RazonSocial.HeaderText = "Razon Social"
        Me.RazonSocial.Name = "RazonSocial"
        Me.RazonSocial.ReadOnly = True
        '
        'Mail
        '
        Me.Mail.DataPropertyName = "Mail"
        Me.Mail.FillWeight = 121.8274!
        Me.Mail.HeaderText = "Mail"
        Me.Mail.Name = "Mail"
        Me.Mail.ReadOnly = True
        '
        'Telefono
        '
        Me.Telefono.DataPropertyName = "Telefono"
        Me.Telefono.FillWeight = 114.2586!
        Me.Telefono.HeaderText = "Telefono"
        Me.Telefono.Name = "Telefono"
        Me.Telefono.ReadOnly = True
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Buscar.Image = Global.SistemaCinderella.My.Resources.Recursos.IconoBuscar32
        Me.btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Buscar.Location = New System.Drawing.Point(479, 65)
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
        Me.Label1.Size = New System.Drawing.Size(77, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "RazonSocial"
        '
        'txt_Buscar
        '
        Me.txt_Buscar.Location = New System.Drawing.Point(91, 75)
        Me.txt_Buscar.Name = "txt_Buscar"
        Me.txt_Buscar.Size = New System.Drawing.Size(244, 21)
        Me.txt_Buscar.TabIndex = 1
        Me.ToolCliente.SetToolTip(Me.txt_Buscar, "Usted puede realizar una busqueda por palabra completa  o parte de ella.")
        '
        'ErroresClie
        '
        Me.ErroresClie.BlinkRate = 200
        Me.ErroresClie.ContainerControl = Me
        '
        'ToolCliente
        '
        Me.ToolCliente.IsBalloon = True
        Me.ToolCliente.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolCliente.ToolTipTitle = "Ayuda"
        '
        'lbl_Msg
        '
        Me.lbl_Msg.AutoSize = True
        Me.lbl_Msg.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lbl_Msg.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Msg.Location = New System.Drawing.Point(98, 209)
        Me.lbl_Msg.Name = "lbl_Msg"
        Me.lbl_Msg.Size = New System.Drawing.Size(374, 29)
        Me.lbl_Msg.TabIndex = 13
        Me.lbl_Msg.Text = "No se han encontrado clientes."
        '
        'frmBuscarClienteMayorista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 372)
        Me.Controls.Add(Me.GB_Clientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmBuscarClienteMayorista"
        Me.Text = "Buscar Cliente"
        Me.GB_Clientes.ResumeLayout(False)
        Me.GB_Clientes.PerformLayout()
        CType(Me.DG_Clientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErroresClie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GB_Clientes As System.Windows.Forms.GroupBox
    Friend WithEvents DG_Clientes As System.Windows.Forms.DataGridView
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents txt_Buscar As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ErroresClie As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_informacion As System.Windows.Forms.Label
    Friend WithEvents ToolCliente As System.Windows.Forms.ToolTip
    Friend WithEvents id_Cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RazonSocial As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Mail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Telefono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Btn_Limpiar As System.Windows.Forms.Button
    Friend WithEvents lbl_Msg As System.Windows.Forms.Label
End Class
