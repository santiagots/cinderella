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
        Me.txt_Numero = New System.Windows.Forms.TextBox()
        Me.Btn_CrearReporte = New System.Windows.Forms.Button()
        Me.lbl_Etiquetas = New System.Windows.Forms.Label()
        Me.Gb_Etiquetas = New System.Windows.Forms.GroupBox()
        Me.CkPrecios = New System.Windows.Forms.CheckBox()
        Me.lbl_CantEtiquetas = New System.Windows.Forms.Label()
        Me.txt_Desde = New System.Windows.Forms.TextBox()
        Me.lbl_Producto = New System.Windows.Forms.Label()
        Me.lbl_ProductoNombre = New System.Windows.Forms.Label()
        Me.Btn_BuscarCodigo = New System.Windows.Forms.Button()
        Me.txt_Codigo = New System.Windows.Forms.TextBox()
        Me.lbl_ProductoCodigo = New System.Windows.Forms.Label()
        Me.ErrorEtiquetas = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Gb_Etiquetas.SuspendLayout()
        CType(Me.ErrorEtiquetas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_Numero
        '
        Me.txt_Numero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Numero.Location = New System.Drawing.Point(164, 92)
        Me.txt_Numero.Name = "txt_Numero"
        Me.txt_Numero.Size = New System.Drawing.Size(51, 21)
        Me.txt_Numero.TabIndex = 4
        Me.txt_Numero.Text = "66"
        '
        'Btn_CrearReporte
        '
        Me.Btn_CrearReporte.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_CrearReporte.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_CrearReporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_CrearReporte.Image = Global.SistemaCinderella.My.Resources.Recursos.Boton_Agregar
        Me.Btn_CrearReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_CrearReporte.Location = New System.Drawing.Point(294, 169)
        Me.Btn_CrearReporte.Name = "Btn_CrearReporte"
        Me.Btn_CrearReporte.Size = New System.Drawing.Size(120, 35)
        Me.Btn_CrearReporte.TabIndex = 7
        Me.Btn_CrearReporte.Text = "Crear Etiquetas"
        Me.Btn_CrearReporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_CrearReporte.UseVisualStyleBackColor = True
        '
        'lbl_Etiquetas
        '
        Me.lbl_Etiquetas.AutoSize = True
        Me.lbl_Etiquetas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Etiquetas.Location = New System.Drawing.Point(6, 95)
        Me.lbl_Etiquetas.Name = "lbl_Etiquetas"
        Me.lbl_Etiquetas.Size = New System.Drawing.Size(125, 15)
        Me.lbl_Etiquetas.TabIndex = 0
        Me.lbl_Etiquetas.Text = "Número de etiquetas:"
        '
        'Gb_Etiquetas
        '
        Me.Gb_Etiquetas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gb_Etiquetas.Controls.Add(Me.CkPrecios)
        Me.Gb_Etiquetas.Controls.Add(Me.lbl_CantEtiquetas)
        Me.Gb_Etiquetas.Controls.Add(Me.txt_Desde)
        Me.Gb_Etiquetas.Controls.Add(Me.lbl_Producto)
        Me.Gb_Etiquetas.Controls.Add(Me.lbl_ProductoNombre)
        Me.Gb_Etiquetas.Controls.Add(Me.Btn_CrearReporte)
        Me.Gb_Etiquetas.Controls.Add(Me.Btn_BuscarCodigo)
        Me.Gb_Etiquetas.Controls.Add(Me.lbl_Etiquetas)
        Me.Gb_Etiquetas.Controls.Add(Me.txt_Codigo)
        Me.Gb_Etiquetas.Controls.Add(Me.txt_Numero)
        Me.Gb_Etiquetas.Controls.Add(Me.lbl_ProductoCodigo)
        Me.Gb_Etiquetas.Location = New System.Drawing.Point(12, 12)
        Me.Gb_Etiquetas.Name = "Gb_Etiquetas"
        Me.Gb_Etiquetas.Size = New System.Drawing.Size(420, 210)
        Me.Gb_Etiquetas.TabIndex = 1
        Me.Gb_Etiquetas.TabStop = False
        Me.Gb_Etiquetas.Text = "Creación de Etiquetas"
        '
        'CkPrecios
        '
        Me.CkPrecios.AutoSize = True
        Me.CkPrecios.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CkPrecios.Checked = True
        Me.CkPrecios.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CkPrecios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CkPrecios.Location = New System.Drawing.Point(6, 169)
        Me.CkPrecios.Name = "CkPrecios"
        Me.CkPrecios.Size = New System.Drawing.Size(112, 19)
        Me.CkPrecios.TabIndex = 6
        Me.CkPrecios.Text = "Mostrar Precios"
        Me.CkPrecios.UseVisualStyleBackColor = True
        '
        'lbl_CantEtiquetas
        '
        Me.lbl_CantEtiquetas.AutoSize = True
        Me.lbl_CantEtiquetas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CantEtiquetas.Location = New System.Drawing.Point(6, 131)
        Me.lbl_CantEtiquetas.Name = "lbl_CantEtiquetas"
        Me.lbl_CantEtiquetas.Size = New System.Drawing.Size(149, 15)
        Me.lbl_CantEtiquetas.TabIndex = 17
        Me.lbl_CantEtiquetas.Text = "Imprimir etiquetas desde: "
        '
        'txt_Desde
        '
        Me.txt_Desde.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Desde.Location = New System.Drawing.Point(164, 128)
        Me.txt_Desde.Name = "txt_Desde"
        Me.txt_Desde.Size = New System.Drawing.Size(51, 21)
        Me.txt_Desde.TabIndex = 5
        Me.txt_Desde.Text = "0"
        '
        'lbl_Producto
        '
        Me.lbl_Producto.AutoSize = True
        Me.lbl_Producto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Producto.Location = New System.Drawing.Point(161, 62)
        Me.lbl_Producto.Name = "lbl_Producto"
        Me.lbl_Producto.Size = New System.Drawing.Size(25, 15)
        Me.lbl_Producto.TabIndex = 3
        Me.lbl_Producto.Text = "- - -"
        '
        'lbl_ProductoNombre
        '
        Me.lbl_ProductoNombre.AutoSize = True
        Me.lbl_ProductoNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ProductoNombre.Location = New System.Drawing.Point(6, 62)
        Me.lbl_ProductoNombre.Name = "lbl_ProductoNombre"
        Me.lbl_ProductoNombre.Size = New System.Drawing.Size(59, 15)
        Me.lbl_ProductoNombre.TabIndex = 15
        Me.lbl_ProductoNombre.Text = "Producto:"
        '
        'Btn_BuscarCodigo
        '
        Me.Btn_BuscarCodigo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_BuscarCodigo.FlatAppearance.BorderSize = 0
        Me.Btn_BuscarCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_BuscarCodigo.Image = Global.SistemaCinderella.My.Resources.Recursos.Lupa
        Me.Btn_BuscarCodigo.Location = New System.Drawing.Point(270, 26)
        Me.Btn_BuscarCodigo.Name = "Btn_BuscarCodigo"
        Me.Btn_BuscarCodigo.Size = New System.Drawing.Size(24, 24)
        Me.Btn_BuscarCodigo.TabIndex = 2
        Me.Btn_BuscarCodigo.UseVisualStyleBackColor = True
        '
        'txt_Codigo
        '
        Me.txt_Codigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Codigo.Location = New System.Drawing.Point(164, 29)
        Me.txt_Codigo.Name = "txt_Codigo"
        Me.txt_Codigo.Size = New System.Drawing.Size(100, 21)
        Me.txt_Codigo.TabIndex = 1
        '
        'lbl_ProductoCodigo
        '
        Me.lbl_ProductoCodigo.AutoSize = True
        Me.lbl_ProductoCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ProductoCodigo.Location = New System.Drawing.Point(6, 32)
        Me.lbl_ProductoCodigo.Name = "lbl_ProductoCodigo"
        Me.lbl_ProductoCodigo.Size = New System.Drawing.Size(118, 15)
        Me.lbl_ProductoCodigo.TabIndex = 3
        Me.lbl_ProductoCodigo.Text = "Código de Producto:"
        '
        'ErrorEtiquetas
        '
        Me.ErrorEtiquetas.BlinkRate = 200
        Me.ErrorEtiquetas.ContainerControl = Me
        '
        'frmEtiquetas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 234)
        Me.Controls.Add(Me.Gb_Etiquetas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmEtiquetas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administración de Etiquetas"
        Me.Gb_Etiquetas.ResumeLayout(False)
        Me.Gb_Etiquetas.PerformLayout()
        CType(Me.ErrorEtiquetas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_Numero As System.Windows.Forms.TextBox
    Friend WithEvents Btn_CrearReporte As System.Windows.Forms.Button
    Friend WithEvents lbl_Etiquetas As System.Windows.Forms.Label
    Friend WithEvents lbl_ProductoCodigo As System.Windows.Forms.Label
    Friend WithEvents Gb_Etiquetas As System.Windows.Forms.GroupBox
    Friend WithEvents ErrorEtiquetas As System.Windows.Forms.ErrorProvider
    Friend WithEvents txt_Codigo As System.Windows.Forms.TextBox
    Friend WithEvents Btn_BuscarCodigo As System.Windows.Forms.Button
    Friend WithEvents lbl_ProductoNombre As System.Windows.Forms.Label
    Friend WithEvents lbl_Producto As System.Windows.Forms.Label
    Friend WithEvents lbl_CantEtiquetas As System.Windows.Forms.Label
    Friend WithEvents txt_Desde As System.Windows.Forms.TextBox
    Friend WithEvents CkPrecios As System.Windows.Forms.CheckBox
End Class
