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
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chk_Proveedores = New System.Windows.Forms.CheckedListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cb_Categoria = New System.Windows.Forms.ComboBox()
        Me.cb_Subcategoria = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chk_Precios = New System.Windows.Forms.CheckedListBox()
        Me.CheckEtiquetas = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_Msg = New System.Windows.Forms.Label()
        Me.Chk_Productos = New System.Windows.Forms.CheckedListBox()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_Contador2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Ckb = New System.Windows.Forms.CheckBox()
        Me.lbl_Contador = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_Busqueda = New System.Windows.Forms.TextBox()
        Me.LsProductos = New System.Windows.Forms.CheckedListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.Btn_Quitar = New System.Windows.Forms.Button()
        Me.Btn_Agregar = New System.Windows.Forms.Button()
        Me.btn_Restablecer = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ToolPrecios = New System.Windows.Forms.ToolTip(Me.components)
        Me.Gb_Filtros.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gb_Filtros
        '
        Me.Gb_Filtros.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gb_Filtros.Controls.Add(Me.btnCancelar)
        Me.Gb_Filtros.Controls.Add(Me.Label4)
        Me.Gb_Filtros.Controls.Add(Me.btn_Buscar)
        Me.Gb_Filtros.Controls.Add(Me.TableLayoutPanel7)
        Me.Gb_Filtros.Location = New System.Drawing.Point(10, 6)
        Me.Gb_Filtros.Name = "Gb_Filtros"
        Me.Gb_Filtros.Size = New System.Drawing.Size(762, 634)
        Me.Gb_Filtros.TabIndex = 0
        Me.Gb_Filtros.TabStop = False
        Me.Gb_Filtros.Text = "Generar listados de precios de productos"
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = Global.SistemaCinderella.My.Resources.Recursos.desconectado_32
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(544, 584)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 40)
        Me.btnCancelar.TabIndex = 17
        Me.btnCancelar.Text = "Cerrar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.Location = New System.Drawing.Point(8, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(743, 32)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Seleccione los filtros que desee para generar la lista de precios que mejor se aj" &
    "uste a sus requerimientos. Recuerde que dicho proceso puede tardar algunos minut" &
    "os."
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Buscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Buscar.Image = Global.SistemaCinderella.My.Resources.Recursos.Conectado_32
        Me.btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Buscar.Location = New System.Drawing.Point(654, 584)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(100, 40)
        Me.btn_Buscar.TabIndex = 5
        Me.btn_Buscar.Text = "Ejecutar"
        Me.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolPrecios.SetToolTip(Me.btn_Buscar, "Haz click aquí para confeccionar el listado de precios según los criterios selecc" &
        "ionados.")
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel7.ColumnCount = 3
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.TableLayoutPanel1, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.TableLayoutPanel2, 2, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.TableLayoutPanel6, 1, 0)
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(6, 56)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(750, 522)
        Me.TableLayoutPanel7.TabIndex = 32
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.chk_Proveedores, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.cb_Categoria, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.cb_Subcategoria, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.chk_Precios, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.CheckEtiquetas, 0, 7)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 8
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(262, 516)
        Me.TableLayoutPanel1.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(256, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "¿Qué proveedores desea visualizar?"
        '
        'chk_Proveedores
        '
        Me.chk_Proveedores.CheckOnClick = True
        Me.chk_Proveedores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chk_Proveedores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chk_Proveedores.FormattingEnabled = True
        Me.chk_Proveedores.Location = New System.Drawing.Point(3, 39)
        Me.chk_Proveedores.Name = "chk_Proveedores"
        Me.chk_Proveedores.Size = New System.Drawing.Size(256, 153)
        Me.chk_Proveedores.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 195)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(256, 35)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "¿Qué categorías / subcategorías desea visualizar?"
        '
        'cb_Categoria
        '
        Me.cb_Categoria.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_Categoria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_Categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Categoria.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cb_Categoria.FormattingEnabled = True
        Me.cb_Categoria.Items.AddRange(New Object() {"Todas las Categorías."})
        Me.cb_Categoria.Location = New System.Drawing.Point(3, 235)
        Me.cb_Categoria.Name = "cb_Categoria"
        Me.cb_Categoria.Size = New System.Drawing.Size(256, 23)
        Me.cb_Categoria.TabIndex = 19
        '
        'cb_Subcategoria
        '
        Me.cb_Subcategoria.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_Subcategoria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_Subcategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Subcategoria.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cb_Subcategoria.FormattingEnabled = True
        Me.cb_Subcategoria.Items.AddRange(New Object() {"Todas las subcategorías."})
        Me.cb_Subcategoria.Location = New System.Drawing.Point(3, 265)
        Me.cb_Subcategoria.Name = "cb_Subcategoria"
        Me.cb_Subcategoria.Size = New System.Drawing.Size(256, 23)
        Me.cb_Subcategoria.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 301)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(256, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "¿Qué precios desea visualizar?"
        '
        'chk_Precios
        '
        Me.chk_Precios.CheckOnClick = True
        Me.chk_Precios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chk_Precios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chk_Precios.FormattingEnabled = True
        Me.chk_Precios.Items.AddRange(New Object() {"Costo", "Efectivo Tigre", "Tarjeta Tigre", "Efectivo Capital", "Tarjeta Capital", "Mayorista", "Alternativa"})
        Me.chk_Precios.Location = New System.Drawing.Point(3, 330)
        Me.chk_Precios.Name = "chk_Precios"
        Me.chk_Precios.Size = New System.Drawing.Size(256, 153)
        Me.chk_Precios.TabIndex = 2
        '
        'CheckEtiquetas
        '
        Me.CheckEtiquetas.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckEtiquetas.AutoSize = True
        Me.CheckEtiquetas.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckEtiquetas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckEtiquetas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckEtiquetas.Location = New System.Drawing.Point(3, 491)
        Me.CheckEtiquetas.Name = "CheckEtiquetas"
        Me.CheckEtiquetas.Size = New System.Drawing.Size(256, 19)
        Me.CheckEtiquetas.TabIndex = 15
        Me.CheckEtiquetas.Text = "Imprimir Etiquetas en reporte"
        Me.CheckEtiquetas.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Panel1, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel5, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel4, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.LsProductos, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(351, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 6
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(396, 516)
        Me.TableLayoutPanel2.TabIndex = 30
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lbl_Msg)
        Me.Panel1.Controls.Add(Me.Chk_Productos)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 69)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(390, 183)
        Me.Panel1.TabIndex = 33
        '
        'lbl_Msg
        '
        Me.lbl_Msg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Msg.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_Msg.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Msg.Location = New System.Drawing.Point(51, 79)
        Me.lbl_Msg.Name = "lbl_Msg"
        Me.lbl_Msg.Size = New System.Drawing.Size(289, 24)
        Me.lbl_Msg.TabIndex = 4
        Me.lbl_Msg.Text = "No se encontraron productos."
        Me.lbl_Msg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_Msg.Visible = False
        '
        'Chk_Productos
        '
        Me.Chk_Productos.CheckOnClick = True
        Me.Chk_Productos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Chk_Productos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Chk_Productos.FormattingEnabled = True
        Me.Chk_Productos.Location = New System.Drawing.Point(0, 0)
        Me.Chk_Productos.Name = "Chk_Productos"
        Me.Chk_Productos.Size = New System.Drawing.Size(390, 183)
        Me.Chk_Productos.TabIndex = 3
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.5!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5!))
        Me.TableLayoutPanel5.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.lbl_Contador2, 1, 0)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 483)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(240, 30)
        Me.TableLayoutPanel5.TabIndex = 31
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 15)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Productos seleccionados"
        '
        'lbl_Contador2
        '
        Me.lbl_Contador2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Contador2.AutoSize = True
        Me.lbl_Contador2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Contador2.Location = New System.Drawing.Point(153, 7)
        Me.lbl_Contador2.Name = "lbl_Contador2"
        Me.lbl_Contador2.Size = New System.Drawing.Size(84, 15)
        Me.lbl_Contador2.TabIndex = 24
        Me.lbl_Contador2.Text = "( 0 )"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.Ckb, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.lbl_Contador, 1, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 258)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(390, 30)
        Me.TableLayoutPanel4.TabIndex = 31
        '
        'Ckb
        '
        Me.Ckb.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Ckb.AutoSize = True
        Me.Ckb.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Ckb.Location = New System.Drawing.Point(3, 5)
        Me.Ckb.Name = "Ckb"
        Me.Ckb.Size = New System.Drawing.Size(189, 19)
        Me.Ckb.TabIndex = 14
        Me.Ckb.Text = "Seleccionar / Deseleccionar"
        Me.Ckb.UseVisualStyleBackColor = True
        '
        'lbl_Contador
        '
        Me.lbl_Contador.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Contador.AutoSize = True
        Me.lbl_Contador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Contador.Location = New System.Drawing.Point(198, 7)
        Me.lbl_Contador.Name = "lbl_Contador"
        Me.lbl_Contador.Size = New System.Drawing.Size(189, 15)
        Me.lbl_Contador.TabIndex = 16
        Me.lbl_Contador.Text = "Productos tildados ( 0 )"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label7, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.txt_Busqueda, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 39)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(390, 24)
        Me.TableLayoutPanel3.TabIndex = 31
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 4)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(194, 15)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Busqueda por Nombre / Código"
        '
        'txt_Busqueda
        '
        Me.txt_Busqueda.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Busqueda.Location = New System.Drawing.Point(203, 3)
        Me.txt_Busqueda.Name = "txt_Busqueda"
        Me.txt_Busqueda.Size = New System.Drawing.Size(184, 21)
        Me.txt_Busqueda.TabIndex = 26
        '
        'LsProductos
        '
        Me.LsProductos.CheckOnClick = True
        Me.LsProductos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LsProductos.FormattingEnabled = True
        Me.LsProductos.Location = New System.Drawing.Point(3, 294)
        Me.LsProductos.Name = "LsProductos"
        Me.LsProductos.Size = New System.Drawing.Size(390, 183)
        Me.LsProductos.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(390, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "¿Qué productos desea visualizar?"
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 1
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.Btn_Quitar, 0, 4)
        Me.TableLayoutPanel6.Controls.Add(Me.Btn_Agregar, 0, 3)
        Me.TableLayoutPanel6.Controls.Add(Me.btn_Restablecer, 0, 2)
        Me.TableLayoutPanel6.Controls.Add(Me.Button1, 0, 1)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(271, 3)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 6
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(74, 516)
        Me.TableLayoutPanel6.TabIndex = 31
        '
        'Btn_Quitar
        '
        Me.Btn_Quitar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Quitar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Quitar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Quitar.Image = Global.SistemaCinderella.My.Resources.Recursos.btn_quitar_32
        Me.Btn_Quitar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_Quitar.Location = New System.Drawing.Point(3, 321)
        Me.Btn_Quitar.Name = "Btn_Quitar"
        Me.Btn_Quitar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Btn_Quitar.Size = New System.Drawing.Size(68, 54)
        Me.Btn_Quitar.TabIndex = 27
        Me.Btn_Quitar.Text = "Quitar"
        Me.Btn_Quitar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolPrecios.SetToolTip(Me.Btn_Quitar, "Haz click aquí para agregar los productos tildados a la lista final de productos " &
        "seleccionados.")
        Me.Btn_Quitar.UseVisualStyleBackColor = True
        '
        'Btn_Agregar
        '
        Me.Btn_Agregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Agregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Agregar.Image = Global.SistemaCinderella.My.Resources.Recursos.Agregar2_32
        Me.Btn_Agregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_Agregar.Location = New System.Drawing.Point(3, 261)
        Me.Btn_Agregar.Name = "Btn_Agregar"
        Me.Btn_Agregar.Size = New System.Drawing.Size(68, 54)
        Me.Btn_Agregar.TabIndex = 22
        Me.Btn_Agregar.Text = "Agregar"
        Me.Btn_Agregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolPrecios.SetToolTip(Me.Btn_Agregar, "Haz click aquí para agregar los productos tildados a la lista final de productos " &
        "seleccionados.")
        Me.Btn_Agregar.UseVisualStyleBackColor = True
        '
        'btn_Restablecer
        '
        Me.btn_Restablecer.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Restablecer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Restablecer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Restablecer.Image = Global.SistemaCinderella.My.Resources.Recursos.Cancelar_32
        Me.btn_Restablecer.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Restablecer.Location = New System.Drawing.Point(3, 201)
        Me.btn_Restablecer.Name = "btn_Restablecer"
        Me.btn_Restablecer.Size = New System.Drawing.Size(68, 54)
        Me.btn_Restablecer.TabIndex = 4
        Me.btn_Restablecer.Text = "Limpiar"
        Me.btn_Restablecer.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolPrecios.SetToolTip(Me.btn_Restablecer, "Haz click aquí para restablecer los filtros de busqueda de productos.")
        Me.btn_Restablecer.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.SistemaCinderella.My.Resources.Recursos.Filtrar_32
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(3, 141)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(68, 54)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Filtrar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolPrecios.SetToolTip(Me.Button1, "Haz click aquí para filtrar los productos del sistema teniendo en cuenta los sigu" &
        "ientes parámetros: Proveedores, Categorías y Subcategorías seleccionadas.")
        Me.Button1.UseVisualStyleBackColor = True
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
        Me.ClientSize = New System.Drawing.Size(784, 652)
        Me.Controls.Add(Me.Gb_Filtros)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPlanillaPrecios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administración de listas de Precios"
        Me.Gb_Filtros.ResumeLayout(False)
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel6.ResumeLayout(False)
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Ckb As System.Windows.Forms.CheckBox
    Friend WithEvents CheckEtiquetas As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_Contador As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cb_Subcategoria As System.Windows.Forms.ComboBox
    Friend WithEvents cb_Categoria As System.Windows.Forms.ComboBox
    Friend WithEvents Btn_Agregar As System.Windows.Forms.Button
    Friend WithEvents lbl_Contador2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_Busqueda As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Btn_Quitar As Button
    Friend WithEvents LsProductos As CheckedListBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_Msg As Label
End Class
