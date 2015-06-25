<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEtiquetasMasivas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEtiquetasMasivas))
        Me.Gb_Etiquetas = New System.Windows.Forms.GroupBox()
        Me.lbl_Cantidad = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstProductos = New System.Windows.Forms.ListBox()
        Me.CkPrecios = New System.Windows.Forms.CheckBox()
        Me.lbl_CantEtiquetas = New System.Windows.Forms.Label()
        Me.txt_Desde = New System.Windows.Forms.TextBox()
        Me.Btn_CrearReporte = New System.Windows.Forms.Button()
        Me.ErrorEtiquetas = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lbl_CantidadE = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Gb_Etiquetas.SuspendLayout()
        CType(Me.ErrorEtiquetas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Gb_Etiquetas
        '
        Me.Gb_Etiquetas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gb_Etiquetas.Controls.Add(Me.Label5)
        Me.Gb_Etiquetas.Controls.Add(Me.Label4)
        Me.Gb_Etiquetas.Controls.Add(Me.lbl_CantidadE)
        Me.Gb_Etiquetas.Controls.Add(Me.lbl_Cantidad)
        Me.Gb_Etiquetas.Controls.Add(Me.Label1)
        Me.Gb_Etiquetas.Controls.Add(Me.lstProductos)
        Me.Gb_Etiquetas.Controls.Add(Me.CkPrecios)
        Me.Gb_Etiquetas.Controls.Add(Me.lbl_CantEtiquetas)
        Me.Gb_Etiquetas.Controls.Add(Me.txt_Desde)
        Me.Gb_Etiquetas.Controls.Add(Me.Btn_CrearReporte)
        Me.Gb_Etiquetas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gb_Etiquetas.Location = New System.Drawing.Point(12, 12)
        Me.Gb_Etiquetas.Name = "Gb_Etiquetas"
        Me.Gb_Etiquetas.Size = New System.Drawing.Size(420, 248)
        Me.Gb_Etiquetas.TabIndex = 2
        Me.Gb_Etiquetas.TabStop = False
        Me.Gb_Etiquetas.Text = "Creación de Etiquetas"
        '
        'lbl_Cantidad
        '
        Me.lbl_Cantidad.AutoSize = True
        Me.lbl_Cantidad.Location = New System.Drawing.Point(178, 146)
        Me.lbl_Cantidad.Name = "lbl_Cantidad"
        Me.lbl_Cantidad.Size = New System.Drawing.Size(88, 15)
        Me.lbl_Cantidad.TabIndex = 18
        Me.lbl_Cantidad.Text = "150 productos."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Listado de productos"
        '
        'lstProductos
        '
        Me.lstProductos.BackColor = System.Drawing.SystemColors.Control
        Me.lstProductos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lstProductos.FormattingEnabled = True
        Me.lstProductos.ItemHeight = 15
        Me.lstProductos.Location = New System.Drawing.Point(178, 16)
        Me.lstProductos.Name = "lstProductos"
        Me.lstProductos.Size = New System.Drawing.Size(237, 94)
        Me.lstProductos.TabIndex = 1
        '
        'CkPrecios
        '
        Me.CkPrecios.AutoSize = True
        Me.CkPrecios.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CkPrecios.Checked = True
        Me.CkPrecios.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CkPrecios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CkPrecios.Location = New System.Drawing.Point(6, 198)
        Me.CkPrecios.Name = "CkPrecios"
        Me.CkPrecios.Size = New System.Drawing.Size(112, 19)
        Me.CkPrecios.TabIndex = 3
        Me.CkPrecios.Text = "Mostrar Precios"
        Me.CkPrecios.UseVisualStyleBackColor = True
        '
        'lbl_CantEtiquetas
        '
        Me.lbl_CantEtiquetas.AutoSize = True
        Me.lbl_CantEtiquetas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CantEtiquetas.Location = New System.Drawing.Point(6, 120)
        Me.lbl_CantEtiquetas.Name = "lbl_CantEtiquetas"
        Me.lbl_CantEtiquetas.Size = New System.Drawing.Size(143, 15)
        Me.lbl_CantEtiquetas.TabIndex = 17
        Me.lbl_CantEtiquetas.Text = "Imprimir etiquetas desde"
        '
        'txt_Desde
        '
        Me.txt_Desde.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Desde.Location = New System.Drawing.Point(178, 116)
        Me.txt_Desde.Name = "txt_Desde"
        Me.txt_Desde.Size = New System.Drawing.Size(51, 21)
        Me.txt_Desde.TabIndex = 2
        Me.txt_Desde.Text = "0"
        '
        'Btn_CrearReporte
        '
        Me.Btn_CrearReporte.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_CrearReporte.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_CrearReporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_CrearReporte.Image = Global.SistemaCinderella.My.Resources.Recursos.Boton_Agregar
        Me.Btn_CrearReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_CrearReporte.Location = New System.Drawing.Point(294, 207)
        Me.Btn_CrearReporte.Name = "Btn_CrearReporte"
        Me.Btn_CrearReporte.Size = New System.Drawing.Size(120, 35)
        Me.Btn_CrearReporte.TabIndex = 4
        Me.Btn_CrearReporte.Text = "Crear Etiquetas"
        Me.Btn_CrearReporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_CrearReporte.UseVisualStyleBackColor = True
        '
        'ErrorEtiquetas
        '
        Me.ErrorEtiquetas.BlinkRate = 200
        Me.ErrorEtiquetas.ContainerControl = Me
        '
        'lbl_CantidadE
        '
        Me.lbl_CantidadE.AutoSize = True
        Me.lbl_CantidadE.Location = New System.Drawing.Point(178, 172)
        Me.lbl_CantidadE.Name = "lbl_CantidadE"
        Me.lbl_CantidadE.Size = New System.Drawing.Size(84, 15)
        Me.lbl_CantidadE.TabIndex = 19
        Me.lbl_CantidadE.Text = "200 etiquetas."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 15)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Cantidad de Etiquetas:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 15)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Cantidad de Productos:"
        '
        'frmEtiquetasMasivas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 272)
        Me.Controls.Add(Me.Gb_Etiquetas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmEtiquetasMasivas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administración de Etiquetas Masivas"
        Me.Gb_Etiquetas.ResumeLayout(False)
        Me.Gb_Etiquetas.PerformLayout()
        CType(Me.ErrorEtiquetas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Gb_Etiquetas As System.Windows.Forms.GroupBox
    Friend WithEvents CkPrecios As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_CantEtiquetas As System.Windows.Forms.Label
    Friend WithEvents txt_Desde As System.Windows.Forms.TextBox
    Friend WithEvents Btn_CrearReporte As System.Windows.Forms.Button
    Friend WithEvents ErrorEtiquetas As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstProductos As System.Windows.Forms.ListBox
    Friend WithEvents lbl_Cantidad As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbl_CantidadE As System.Windows.Forms.Label
End Class
