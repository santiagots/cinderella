<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrdenCompraProductoRepetido
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrdenCompraProductoRepetido))
        Me.dgwOrdenCompra = New System.Windows.Forms.DataGridView()
        Me.NombreEncargadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrdenCompraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCantidadIngresada = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTotalPedido = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDiferencia = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnMantener = New System.Windows.Forms.Button()
        Me.btnDiferencia = New System.Windows.Forms.Button()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgwOrdenCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdenCompraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgwOrdenCompra
        '
        Me.dgwOrdenCompra.AllowUserToAddRows = False
        Me.dgwOrdenCompra.AllowUserToDeleteRows = False
        Me.dgwOrdenCompra.AllowUserToResizeColumns = False
        Me.dgwOrdenCompra.AllowUserToResizeRows = False
        Me.dgwOrdenCompra.AutoGenerateColumns = False
        Me.dgwOrdenCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgwOrdenCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwOrdenCompra.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NombreEncargadoDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn, Me.TipoDataGridViewTextBoxColumn, Me.Cantidad})
        Me.dgwOrdenCompra.DataSource = Me.OrdenCompraBindingSource
        Me.dgwOrdenCompra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgwOrdenCompra.Location = New System.Drawing.Point(3, 16)
        Me.dgwOrdenCompra.Name = "dgwOrdenCompra"
        Me.dgwOrdenCompra.Size = New System.Drawing.Size(765, 235)
        Me.dgwOrdenCompra.TabIndex = 0
        '
        'NombreEncargadoDataGridViewTextBoxColumn
        '
        Me.NombreEncargadoDataGridViewTextBoxColumn.DataPropertyName = "NombreEncargado"
        Me.NombreEncargadoDataGridViewTextBoxColumn.HeaderText = "Encargado"
        Me.NombreEncargadoDataGridViewTextBoxColumn.Name = "NombreEncargadoDataGridViewTextBoxColumn"
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        '
        'TipoDataGridViewTextBoxColumn
        '
        Me.TipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.HeaderText = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.Name = "TipoDataGridViewTextBoxColumn"
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        '
        'OrdenCompraBindingSource
        '
        Me.OrdenCompraBindingSource.DataSource = GetType(Entidades.OrdenCompra)
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 54)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(771, 126)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Información producto."
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.44445!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.44445!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtCantidadIngresada, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtNombre, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtCodigo, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtTotalPedido, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtDiferencia, 4, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(6, 18)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(759, 90)
        Me.TableLayoutPanel1.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 15)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Total Pedido"
        '
        'txtCantidadIngresada
        '
        Me.txtCantidadIngresada.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtCantidadIngresada.AutoSize = True
        Me.txtCantidadIngresada.Location = New System.Drawing.Point(123, 37)
        Me.txtCantidadIngresada.Name = "txtCantidadIngresada"
        Me.txtCantidadIngresada.Size = New System.Drawing.Size(23, 15)
        Me.txtCantidadIngresada.TabIndex = 31
        Me.txtCantidadIngresada.Text = "----"
        '
        'txtNombre
        '
        Me.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtNombre.AutoSize = True
        Me.txtNombre.Location = New System.Drawing.Point(530, 7)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(23, 15)
        Me.txtNombre.TabIndex = 29
        Me.txtNombre.Text = "----"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Código"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 15)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Cant. Ingresada"
        '
        'txtCodigo
        '
        Me.txtCodigo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtCodigo.AutoSize = True
        Me.txtCodigo.Location = New System.Drawing.Point(123, 7)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(23, 15)
        Me.txtCodigo.TabIndex = 1
        Me.txtCodigo.Text = "----"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(410, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 15)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Nombre"
        '
        'txtTotalPedido
        '
        Me.txtTotalPedido.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtTotalPedido.AutoSize = True
        Me.txtTotalPedido.Location = New System.Drawing.Point(123, 67)
        Me.txtTotalPedido.Name = "txtTotalPedido"
        Me.txtTotalPedido.Size = New System.Drawing.Size(23, 15)
        Me.txtTotalPedido.TabIndex = 34
        Me.txtTotalPedido.Text = "----"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(410, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 15)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Diferencia"
        '
        'txtDiferencia
        '
        Me.txtDiferencia.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtDiferencia.AutoSize = True
        Me.txtDiferencia.Location = New System.Drawing.Point(530, 67)
        Me.txtDiferencia.Name = "txtDiferencia"
        Me.txtDiferencia.Size = New System.Drawing.Size(23, 15)
        Me.txtDiferencia.TabIndex = 32
        Me.txtDiferencia.Text = "----"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.dgwOrdenCompra)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 186)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(771, 254)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ordenes de compras activas que contienen el producto"
        '
        'btnMantener
        '
        Me.btnMantener.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMantener.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMantener.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMantener.Image = Global.SistemaCinderella.My.Resources.Recursos.Conectado_32
        Me.btnMantener.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMantener.Location = New System.Drawing.Point(643, 447)
        Me.btnMantener.Name = "btnMantener"
        Me.btnMantener.Size = New System.Drawing.Size(137, 40)
        Me.btnMantener.TabIndex = 29
        Me.btnMantener.Text = "Mantener cant. ingresada"
        Me.btnMantener.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMantener.UseVisualStyleBackColor = True
        '
        'btnDiferencia
        '
        Me.btnDiferencia.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDiferencia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDiferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDiferencia.Image = Global.SistemaCinderella.My.Resources.Recursos.Editar_24
        Me.btnDiferencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDiferencia.Location = New System.Drawing.Point(528, 447)
        Me.btnDiferencia.Name = "btnDiferencia"
        Me.btnDiferencia.Size = New System.Drawing.Size(109, 40)
        Me.btnDiferencia.TabIndex = 30
        Me.btnDiferencia.Text = "Cargar Diferencia"
        Me.btnDiferencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDiferencia.UseVisualStyleBackColor = True
        '
        'btnQuitar
        '
        Me.btnQuitar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuitar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnQuitar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitar.Image = Global.SistemaCinderella.My.Resources.Recursos.desconectado_32
        Me.btnQuitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnQuitar.Location = New System.Drawing.Point(417, 446)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(105, 40)
        Me.btnQuitar.TabIndex = 31
        Me.btnQuitar.Text = "Quitar Producto"
        Me.btnQuitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnQuitar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(771, 42)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "El producto ingresado ya está incluido en una orden de compra la cual está en est" &
    "ado Activa o Enviada. Revise la información de la pantalla para tomar una acción" &
    "."
        '
        'frmOrdenCompraProductoRepetido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 499)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnQuitar)
        Me.Controls.Add(Me.btnDiferencia)
        Me.Controls.Add(Me.btnMantener)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmOrdenCompraProductoRepetido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Advertencias ordenes de compra "
        CType(Me.dgwOrdenCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdenCompraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgwOrdenCompra As DataGridView
    Friend WithEvents OrdenCompraBindingSource As BindingSource
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCodigo As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtCantidadIngresada As Label
    Friend WithEvents txtNombre As Label
    Friend WithEvents txtDiferencia As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnMantener As Button
    Friend WithEvents btnDiferencia As Button
    Friend WithEvents btnQuitar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents NombreEncargadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Label7 As Label
    Friend WithEvents txtTotalPedido As Label
End Class
