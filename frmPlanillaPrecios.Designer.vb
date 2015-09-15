<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPlanillaPrecios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPlanillaPrecios))
        Me.Gb_Filtros = New System.Windows.Forms.GroupBox()
        Me.txt_Busqueda = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_Contador2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Btn_Agregar = New System.Windows.Forms.Button()
        Me.LsProductos = New System.Windows.Forms.ListBox()
        Me.cb_Subcategoria = New System.Windows.Forms.ComboBox()
        Me.cb_Categoria = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.lbl_Contador = New System.Windows.Forms.Label()
        Me.CheckEtiquetas = New System.Windows.Forms.CheckBox()
        Me.Ckb = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbl_Msg = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_Restablecer = New System.Windows.Forms.Button()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.Chk_Productos = New System.Windows.Forms.CheckedListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chk_Proveedores = New System.Windows.Forms.CheckedListBox()
        Me.chk_Precios = New System.Windows.Forms.CheckedListBox()
        Me.ToolPrecios = New System.Windows.Forms.ToolTip(Me.components)
        Me.Gb_Filtros.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gb_Filtros
        '
        Me.Gb_Filtros.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gb_Filtros.Controls.Add(Me.txt_Busqueda)
        Me.Gb_Filtros.Controls.Add(Me.Label7)
        Me.Gb_Filtros.Controls.Add(Me.lbl_Contador2)
        Me.Gb_Filtros.Controls.Add(Me.Label6)
        Me.Gb_Filtros.Controls.Add(Me.Btn_Agregar)
        Me.Gb_Filtros.Controls.Add(Me.LsProductos)
        Me.Gb_Filtros.Controls.Add(Me.cb_Subcategoria)
        Me.Gb_Filtros.Controls.Add(Me.cb_Categoria)
        Me.Gb_Filtros.Controls.Add(Me.Label5)
        Me.Gb_Filtros.Controls.Add(Me.btnCancelar)
        Me.Gb_Filtros.Controls.Add(Me.lbl_Contador)
        Me.Gb_Filtros.Controls.Add(Me.CheckEtiquetas)
        Me.Gb_Filtros.Controls.Add(Me.Ckb)
        Me.Gb_Filtros.Controls.Add(Me.Button1)
        Me.Gb_Filtros.Controls.Add(Me.lbl_Msg)
        Me.Gb_Filtros.Controls.Add(Me.Label4)
        Me.Gb_Filtros.Controls.Add(Me.btn_Restablecer)
        Me.Gb_Filtros.Controls.Add(Me.btn_Buscar)
        Me.Gb_Filtros.Controls.Add(Me.Chk_Productos)
        Me.Gb_Filtros.Controls.Add(Me.Label3)
        Me.Gb_Filtros.Controls.Add(Me.Label2)
        Me.Gb_Filtros.Controls.Add(Me.Label1)
        Me.Gb_Filtros.Controls.Add(Me.chk_Proveedores)
        Me.Gb_Filtros.Controls.Add(Me.chk_Precios)
        Me.Gb_Filtros.Location = New System.Drawing.Point(10, 6)
        Me.Gb_Filtros.Name = "Gb_Filtros"
        Me.Gb_Filtros.Size = New System.Drawing.Size(722, 634)
        Me.Gb_Filtros.TabIndex = 0
        Me.Gb_Filtros.TabStop = False
        Me.Gb_Filtros.Text = "Generar listados de precios de productos"
        '
        'txt_Busqueda
        '
        Me.txt_Busqueda.Location = New System.Drawing.Point(515, 86)
        Me.txt_Busqueda.Name = "txt_Busqueda"
        Me.txt_Busqueda.Size = New System.Drawing.Size(199, 21)
        Me.txt_Busqueda.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(329, 89)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(180, 15)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Busqueda por Nombre / Código"
        '
        'lbl_Contador2
        '
        Me.lbl_Contador2.AutoSize = True
        Me.lbl_Contador2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Contador2.Location = New System.Drawing.Point(481, 559)
        Me.lbl_Contador2.Name = "lbl_Contador2"
        Me.lbl_Contador2.Size = New System.Drawing.Size(28, 15)
        Me.lbl_Contador2.TabIndex = 24
        Me.lbl_Contador2.Text = "( 0 )"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(331, 559)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 15)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Productos seleccionados"
        '
        'Btn_Agregar
        '
        Me.Btn_Agregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Agregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Agregar.Image = Global.SistemaCinderella.My.Resources.Recursos.Agregar2_32
        Me.Btn_Agregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_Agregar.Location = New System.Drawing.Point(252, 315)
        Me.Btn_Agregar.Name = "Btn_Agregar"
        Me.Btn_Agregar.Size = New System.Drawing.Size(65, 60)
        Me.Btn_Agregar.TabIndex = 22
        Me.Btn_Agregar.Text = "Agregar"
        Me.Btn_Agregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolPrecios.SetToolTip(Me.Btn_Agregar, "Haz click aquí para agregar los productos tildados a la lista final de productos " & _
        "seleccionados.")
        Me.Btn_Agregar.UseVisualStyleBackColor = True
        '
        'LsProductos
        '
        Me.LsProductos.FormattingEnabled = True
        Me.LsProductos.ItemHeight = 15
        Me.LsProductos.Location = New System.Drawing.Point(332, 388)
        Me.LsProductos.Name = "LsProductos"
        Me.LsProductos.Size = New System.Drawing.Size(382, 169)
        Me.LsProductos.TabIndex = 21
        '
        'cb_Subcategoria
        '
        Me.cb_Subcategoria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_Subcategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Subcategoria.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cb_Subcategoria.FormattingEnabled = True
        Me.cb_Subcategoria.Items.AddRange(New Object() {"Todas las subcategorías."})
        Me.cb_Subcategoria.Location = New System.Drawing.Point(9, 374)
        Me.cb_Subcategoria.Name = "cb_Subcategoria"
        Me.cb_Subcategoria.Size = New System.Drawing.Size(228, 23)
        Me.cb_Subcategoria.TabIndex = 20
        '
        'cb_Categoria
        '
        Me.cb_Categoria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_Categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Categoria.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cb_Categoria.FormattingEnabled = True
        Me.cb_Categoria.Items.AddRange(New Object() {"Todas las Categorías."})
        Me.cb_Categoria.Location = New System.Drawing.Point(9, 343)
        Me.cb_Categoria.Name = "cb_Categoria"
        Me.cb_Categoria.Size = New System.Drawing.Size(228, 23)
        Me.cb_Categoria.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 305)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(231, 35)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "¿Qué categorías / subcategorías desea visualizar?"
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = Global.SistemaCinderella.My.Resources.Recursos.desconectado_32
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(504, 584)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 40)
        Me.btnCancelar.TabIndex = 17
        Me.btnCancelar.Text = "Cerrar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'lbl_Contador
        '
        Me.lbl_Contador.AutoSize = True
        Me.lbl_Contador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Contador.Location = New System.Drawing.Point(579, 361)
        Me.lbl_Contador.Name = "lbl_Contador"
        Me.lbl_Contador.Size = New System.Drawing.Size(132, 15)
        Me.lbl_Contador.TabIndex = 16
        Me.lbl_Contador.Text = "Productos tildados ( 0 )"
        '
        'CheckEtiquetas
        '
        Me.CheckEtiquetas.AutoSize = True
        Me.CheckEtiquetas.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckEtiquetas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckEtiquetas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckEtiquetas.Location = New System.Drawing.Point(9, 560)
        Me.CheckEtiquetas.Name = "CheckEtiquetas"
        Me.CheckEtiquetas.Size = New System.Drawing.Size(214, 19)
        Me.CheckEtiquetas.TabIndex = 15
        Me.CheckEtiquetas.Text = "Imprimir Etiquetas en reporte"
        Me.CheckEtiquetas.UseVisualStyleBackColor = True
        '
        'Ckb
        '
        Me.Ckb.AutoSize = True
        Me.Ckb.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Ckb.Location = New System.Drawing.Point(335, 360)
        Me.Ckb.Name = "Ckb"
        Me.Ckb.Size = New System.Drawing.Size(179, 19)
        Me.Ckb.TabIndex = 14
        Me.Ckb.Text = "Seleccionar / Deseleccionar"
        Me.Ckb.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.SistemaCinderella.My.Resources.Recursos.Filtrar_32
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(252, 183)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(65, 60)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Filtrar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolPrecios.SetToolTip(Me.Button1, "Haz click aquí para filtrar los productos del sistema teniendo en cuenta los sigu" & _
        "ientes parámetros: Proveedores, Categorías y Subcategorías seleccionadas.")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lbl_Msg
        '
        Me.lbl_Msg.BackColor = System.Drawing.SystemColors.Window
        Me.lbl_Msg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Msg.Location = New System.Drawing.Point(335, 223)
        Me.lbl_Msg.Name = "lbl_Msg"
        Me.lbl_Msg.Size = New System.Drawing.Size(376, 20)
        Me.lbl_Msg.TabIndex = 10
        Me.lbl_Msg.Text = "Sin productos disponibles."
        Me.lbl_Msg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(596, 32)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Seleccione los filtros que desee para generar la lista de precios que mejor se aj" & _
    "uste a sus requerimientos. Recuerde que dicho proceso puede tardar algunos minut" & _
    "os."
        '
        'btn_Restablecer
        '
        Me.btn_Restablecer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Restablecer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Restablecer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Restablecer.Image = Global.SistemaCinderella.My.Resources.Recursos.Cancelar_32
        Me.btn_Restablecer.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Restablecer.Location = New System.Drawing.Point(252, 249)
        Me.btn_Restablecer.Name = "btn_Restablecer"
        Me.btn_Restablecer.Size = New System.Drawing.Size(65, 60)
        Me.btn_Restablecer.TabIndex = 4
        Me.btn_Restablecer.Text = "Limpiar"
        Me.btn_Restablecer.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolPrecios.SetToolTip(Me.btn_Restablecer, "Haz click aquí para restablecer los filtros de busqueda de productos.")
        Me.btn_Restablecer.UseVisualStyleBackColor = True
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Buscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Buscar.Image = Global.SistemaCinderella.My.Resources.Recursos.Conectado_32
        Me.btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Buscar.Location = New System.Drawing.Point(614, 584)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(100, 40)
        Me.btn_Buscar.TabIndex = 5
        Me.btn_Buscar.Text = "Ejecutar"
        Me.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolPrecios.SetToolTip(Me.btn_Buscar, "Haz click aquí para confeccionar el listado de precios según los criterios selecc" & _
        "ionados.")
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'Chk_Productos
        '
        Me.Chk_Productos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chk_Productos.CheckOnClick = True
        Me.Chk_Productos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chk_Productos.FormattingEnabled = True
        Me.Chk_Productos.Location = New System.Drawing.Point(332, 113)
        Me.Chk_Productos.Name = "Chk_Productos"
        Me.Chk_Productos.Size = New System.Drawing.Size(382, 244)
        Me.Chk_Productos.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(329, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(224, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "¿Qué productos desea visualizar?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 409)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(208, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "¿Qué precios desea visualizar?"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "¿Qué proveedores desea visualizar?"
        '
        'chk_Proveedores
        '
        Me.chk_Proveedores.CheckOnClick = True
        Me.chk_Proveedores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chk_Proveedores.FormattingEnabled = True
        Me.chk_Proveedores.Location = New System.Drawing.Point(9, 83)
        Me.chk_Proveedores.Name = "chk_Proveedores"
        Me.chk_Proveedores.Size = New System.Drawing.Size(228, 212)
        Me.chk_Proveedores.TabIndex = 1
        '
        'chk_Precios
        '
        Me.chk_Precios.CheckOnClick = True
        Me.chk_Precios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chk_Precios.FormattingEnabled = True
        Me.chk_Precios.Items.AddRange(New Object() {"Costo", "Efectivo Tigre", "Tarjeta Tigre", "Efectivo Capital", "Tarjeta Capital", "Mayorista SF", "Mayorista CF"})
        Me.chk_Precios.Location = New System.Drawing.Point(9, 428)
        Me.chk_Precios.Name = "chk_Precios"
        Me.chk_Precios.Size = New System.Drawing.Size(228, 116)
        Me.chk_Precios.TabIndex = 2
        '
        'ToolPrecios
        '
        Me.ToolPrecios.IsBalloon = True
        Me.ToolPrecios.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolPrecios.ToolTipTitle = "Ayuda"
        '
        'frmPlanillaPrecios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(744, 652)
        Me.Controls.Add(Me.Gb_Filtros)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmPlanillaPrecios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administración de listas de Precios"
        Me.Gb_Filtros.ResumeLayout(False)
        Me.Gb_Filtros.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Gb_Filtros As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chk_Proveedores As System.Windows.Forms.CheckedListBox
    Friend WithEvents chk_Precios As System.Windows.Forms.CheckedListBox
    Friend WithEvents Chk_Productos As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_Restablecer As System.Windows.Forms.Button
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents ToolPrecios As System.Windows.Forms.ToolTip
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbl_Msg As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Ckb As System.Windows.Forms.CheckBox
    Friend WithEvents CheckEtiquetas As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_Contador As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cb_Subcategoria As System.Windows.Forms.ComboBox
    Friend WithEvents cb_Categoria As System.Windows.Forms.ComboBox
    Friend WithEvents LsProductos As System.Windows.Forms.ListBox
    Friend WithEvents Btn_Agregar As System.Windows.Forms.Button
    Friend WithEvents lbl_Contador2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_Busqueda As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
