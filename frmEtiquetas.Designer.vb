<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEtiquetas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEtiquetas))
        Me.ErrorEtiquetas = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.EtiquetaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Btn_CrearReporte = New System.Windows.Forms.Button()
        Me.CkPrecios = New System.Windows.Forms.CheckBox()
        Me.dgEtiquetas = New System.Windows.Forms.DataGridView()
        Me.Btn_Agregar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_ProductoCodigo = New System.Windows.Forms.Label()
        Me.txt_Codigo = New System.Windows.Forms.TextBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Gb_Etiquetas = New System.Windows.Forms.GroupBox()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantiadadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.ErrorEtiquetas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EtiquetaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgEtiquetas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Gb_Etiquetas.SuspendLayout()
        Me.SuspendLayout()
        '
        'ErrorEtiquetas
        '
        Me.ErrorEtiquetas.BlinkRate = 200
        Me.ErrorEtiquetas.ContainerControl = Me
        '
        'EtiquetaBindingSource
        '
        Me.EtiquetaBindingSource.DataSource = GetType(Entidades.Etiqueta)
        '
        'Btn_CrearReporte
        '
        Me.Btn_CrearReporte.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_CrearReporte.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_CrearReporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_CrearReporte.Image = Global.SistemaCinderella.My.Resources.Recursos.Boton_Agregar
        Me.Btn_CrearReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_CrearReporte.Location = New System.Drawing.Point(545, 460)
        Me.Btn_CrearReporte.Name = "Btn_CrearReporte"
        Me.Btn_CrearReporte.Size = New System.Drawing.Size(135, 35)
        Me.Btn_CrearReporte.TabIndex = 7
        Me.Btn_CrearReporte.Text = "Crear Etiquetas"
        Me.Btn_CrearReporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_CrearReporte.UseVisualStyleBackColor = True
        '
        'CkPrecios
        '
        Me.CkPrecios.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CkPrecios.AutoSize = True
        Me.CkPrecios.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CkPrecios.Checked = True
        Me.CkPrecios.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CkPrecios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CkPrecios.Location = New System.Drawing.Point(427, 469)
        Me.CkPrecios.Name = "CkPrecios"
        Me.CkPrecios.Size = New System.Drawing.Size(112, 19)
        Me.CkPrecios.TabIndex = 6
        Me.CkPrecios.Text = "Mostrar Precios"
        Me.CkPrecios.UseVisualStyleBackColor = True
        '
        'dgEtiquetas
        '
        Me.dgEtiquetas.AllowUserToAddRows = False
        Me.dgEtiquetas.AllowUserToDeleteRows = False
        Me.dgEtiquetas.AllowUserToResizeColumns = False
        Me.dgEtiquetas.AllowUserToResizeRows = False
        Me.dgEtiquetas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgEtiquetas.AutoGenerateColumns = False
        Me.dgEtiquetas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgEtiquetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgEtiquetas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.NombreDataGridViewTextBoxColumn, Me.CantiadadDataGridViewTextBoxColumn})
        Me.dgEtiquetas.DataSource = Me.EtiquetaBindingSource
        Me.dgEtiquetas.Location = New System.Drawing.Point(9, 100)
        Me.dgEtiquetas.Name = "dgEtiquetas"
        Me.dgEtiquetas.Size = New System.Drawing.Size(674, 354)
        Me.dgEtiquetas.TabIndex = 18
        '
        'Btn_Agregar
        '
        Me.Btn_Agregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Agregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Agregar.Image = Global.SistemaCinderella.My.Resources.Recursos.Productos_32
        Me.Btn_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Agregar.Location = New System.Drawing.Point(580, 60)
        Me.Btn_Agregar.Name = "Btn_Agregar"
        Me.Btn_Agregar.Size = New System.Drawing.Size(100, 34)
        Me.Btn_Agregar.TabIndex = 21
        Me.Btn_Agregar.Text = "Agregar"
        Me.Btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Agregar.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_ProductoCodigo, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Codigo, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtCantidad, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 3, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(9, 19)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(674, 35)
        Me.TableLayoutPanel1.TabIndex = 22
        '
        'lbl_ProductoCodigo
        '
        Me.lbl_ProductoCodigo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_ProductoCodigo.AutoSize = True
        Me.lbl_ProductoCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ProductoCodigo.Location = New System.Drawing.Point(3, 2)
        Me.lbl_ProductoCodigo.Name = "lbl_ProductoCodigo"
        Me.lbl_ProductoCodigo.Size = New System.Drawing.Size(114, 30)
        Me.lbl_ProductoCodigo.TabIndex = 3
        Me.lbl_ProductoCodigo.Text = "Nombre / Código de Producto:"
        '
        'txt_Codigo
        '
        Me.txt_Codigo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Codigo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_Codigo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_Codigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Codigo.Location = New System.Drawing.Point(123, 7)
        Me.txt_Codigo.Name = "txt_Codigo"
        Me.txt_Codigo.Size = New System.Drawing.Size(171, 21)
        Me.txt_Codigo.TabIndex = 1
        '
        'txtCantidad
        '
        Me.txtCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.Location = New System.Drawing.Point(500, 7)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(171, 21)
        Me.txtCantidad.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(380, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 15)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Cantidad:"
        '
        'Gb_Etiquetas
        '
        Me.Gb_Etiquetas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gb_Etiquetas.Controls.Add(Me.TableLayoutPanel1)
        Me.Gb_Etiquetas.Controls.Add(Me.Btn_Agregar)
        Me.Gb_Etiquetas.Controls.Add(Me.dgEtiquetas)
        Me.Gb_Etiquetas.Controls.Add(Me.CkPrecios)
        Me.Gb_Etiquetas.Controls.Add(Me.Btn_CrearReporte)
        Me.Gb_Etiquetas.Location = New System.Drawing.Point(12, 12)
        Me.Gb_Etiquetas.Name = "Gb_Etiquetas"
        Me.Gb_Etiquetas.Size = New System.Drawing.Size(686, 501)
        Me.Gb_Etiquetas.TabIndex = 1
        Me.Gb_Etiquetas.TabStop = False
        Me.Gb_Etiquetas.Text = "Creación de Etiquetas"
        '
        'Codigo
        '
        Me.Codigo.DataPropertyName = "Codigo"
        Me.Codigo.FillWeight = 25.0!
        Me.Codigo.HeaderText = "Código"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.FillWeight = 73.85786!
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CantiadadDataGridViewTextBoxColumn
        '
        Me.CantiadadDataGridViewTextBoxColumn.DataPropertyName = "Cantiadad"
        Me.CantiadadDataGridViewTextBoxColumn.FillWeight = 25.0!
        Me.CantiadadDataGridViewTextBoxColumn.HeaderText = "Cantiadad"
        Me.CantiadadDataGridViewTextBoxColumn.Name = "CantiadadDataGridViewTextBoxColumn"
        '
        'frmEtiquetas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 525)
        Me.Controls.Add(Me.Gb_Etiquetas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmEtiquetas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administración de Etiquetas"
        CType(Me.ErrorEtiquetas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EtiquetaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgEtiquetas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Gb_Etiquetas.ResumeLayout(False)
        Me.Gb_Etiquetas.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ErrorEtiquetas As System.Windows.Forms.ErrorProvider
    Friend WithEvents EtiquetaBindingSource As BindingSource
    Friend WithEvents Gb_Etiquetas As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lbl_ProductoCodigo As Label
    Friend WithEvents txt_Codigo As TextBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_Agregar As Button
    Friend WithEvents dgEtiquetas As DataGridView
    Friend WithEvents CkPrecios As CheckBox
    Friend WithEvents Btn_CrearReporte As Button
    Friend WithEvents CodigoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantiadadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
