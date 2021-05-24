<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDevoluciones
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDevoluciones))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolCamb = New System.Windows.Forms.ToolTip(Me.components)
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.Btn_Finalizar = New System.Windows.Forms.Button()
        Me.GB_Fecha = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_Hora = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_Sucursal = New System.Windows.Forms.Label()
        Me.lbl_Fecha = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Gb_Vendedor = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Cb_Vendedores = New System.Windows.Forms.ComboBox()
        Me.Cb_Encargados = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cb_Tipo = New System.Windows.Forms.ComboBox()
        Me.Gb_Cliente = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_BuscarCliente = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_RazonSocial = New System.Windows.Forms.TextBox()
        Me.txt_id_Cliente = New System.Windows.Forms.TextBox()
        Me.txt_PorcentajeFacturacion = New System.Windows.Forms.NumericUpDown()
        Me.TableLayoutPanel12 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_PorcentajeBonificacion = New System.Windows.Forms.NumericUpDown()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.Btn_Agregar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_CodigoBarra = New System.Windows.Forms.TextBox()
        Me.GB_ListaPrecio = New System.Windows.Forms.GroupBox()
        Me.Cb_ListaPrecio = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GB_TipoPago = New System.Windows.Forms.GroupBox()
        Me.Cb_TipoPago = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DG_Productos = New System.Windows.Forms.DataGridView()
        Me.NUMERO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODIGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANTIDAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRECIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MONTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SUBTOTAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ELIMINAR = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Precio1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanelTotalMayorista = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txt_SubtotalMayorista = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txt_TotalMayorista = New System.Windows.Forms.TextBox()
        Me.txt_DescuentoMayorista = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txt_ivaTotalMayorista = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.PanelTotalMinorista = New System.Windows.Forms.Panel()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.lbl_DescrTot = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txt_DescuentoMinorista = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txt_TotalMinorista = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.lbl_subTotal = New System.Windows.Forms.Label()
        Me.txt_SubtotalMinorista = New System.Windows.Forms.TextBox()
        Me.GB_Fecha.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.Gb_Vendedor.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Gb_Cliente.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.txt_PorcentajeFacturacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel12.SuspendLayout()
        CType(Me.txt_PorcentajeBonificacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.GB_ListaPrecio.SuspendLayout()
        Me.GB_TipoPago.SuspendLayout()
        CType(Me.DG_Productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTotalMayorista.SuspendLayout()
        Me.PanelTotalMinorista.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'ToolCamb
        '
        Me.ToolCamb.IsBalloon = True
        Me.ToolCamb.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolCamb.ToolTipTitle = "Ayuda"
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Cancelar.Image = Global.SistemaCinderella.My.Resources.Recursos.desconectado_32
        Me.Btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Cancelar.Location = New System.Drawing.Point(735, 690)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Cancelar.TabIndex = 7
        Me.Btn_Cancelar.Text = "Cancelar"
        Me.Btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolCamb.SetToolTip(Me.Btn_Cancelar, "Cancela la devolucion de los articulos. Se borrarán los productos cargados en la " &
        "grilla.")
        Me.Btn_Cancelar.UseVisualStyleBackColor = True
        '
        'Btn_Finalizar
        '
        Me.Btn_Finalizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Finalizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Finalizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Finalizar.Image = Global.SistemaCinderella.My.Resources.Recursos.Conectado_32
        Me.Btn_Finalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Finalizar.Location = New System.Drawing.Point(841, 690)
        Me.Btn_Finalizar.Name = "Btn_Finalizar"
        Me.Btn_Finalizar.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Finalizar.TabIndex = 8
        Me.Btn_Finalizar.Text = "Finalizar"
        Me.Btn_Finalizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolCamb.SetToolTip(Me.Btn_Finalizar, "Finaliza la devolucion de los articulos.")
        Me.Btn_Finalizar.UseVisualStyleBackColor = True
        '
        'GB_Fecha
        '
        Me.GB_Fecha.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_Fecha.Controls.Add(Me.TableLayoutPanel3)
        Me.GB_Fecha.Location = New System.Drawing.Point(16, 12)
        Me.GB_Fecha.Name = "GB_Fecha"
        Me.GB_Fecha.Size = New System.Drawing.Size(920, 44)
        Me.GB_Fecha.TabIndex = 26
        Me.GB_Fecha.TabStop = False
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 8
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.Controls.Add(Me.lbl_Hora, 7, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label7, 6, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.lbl_Sucursal, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.lbl_Fecha, 4, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label5, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label4, 3, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(914, 25)
        Me.TableLayoutPanel3.TabIndex = 44
        '
        'lbl_Hora
        '
        Me.lbl_Hora.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Hora.AutoSize = True
        Me.lbl_Hora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Hora.Location = New System.Drawing.Point(799, 5)
        Me.lbl_Hora.Name = "lbl_Hora"
        Me.lbl_Hora.Size = New System.Drawing.Size(112, 15)
        Me.lbl_Hora.TabIndex = 14
        Me.lbl_Hora.Text = "Label5"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(679, 5)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 15)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "HORA:"
        '
        'lbl_Sucursal
        '
        Me.lbl_Sucursal.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Sucursal.AutoSize = True
        Me.lbl_Sucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Sucursal.Location = New System.Drawing.Point(123, 5)
        Me.lbl_Sucursal.Name = "lbl_Sucursal"
        Me.lbl_Sucursal.Size = New System.Drawing.Size(112, 15)
        Me.lbl_Sucursal.TabIndex = 18
        Me.lbl_Sucursal.Text = "Label5"
        '
        'lbl_Fecha
        '
        Me.lbl_Fecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Fecha.AutoSize = True
        Me.lbl_Fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Fecha.Location = New System.Drawing.Point(461, 5)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(112, 15)
        Me.lbl_Fecha.TabIndex = 15
        Me.lbl_Fecha.Text = "Label6"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 15)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "SUCURSAL:"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(341, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 15)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "FECHA:"
        '
        'Gb_Vendedor
        '
        Me.Gb_Vendedor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gb_Vendedor.Controls.Add(Me.TableLayoutPanel2)
        Me.Gb_Vendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gb_Vendedor.Location = New System.Drawing.Point(16, 62)
        Me.Gb_Vendedor.Name = "Gb_Vendedor"
        Me.Gb_Vendedor.Size = New System.Drawing.Size(921, 59)
        Me.Gb_Vendedor.TabIndex = 27
        Me.Gb_Vendedor.TabStop = False
        Me.Gb_Vendedor.Text = "TIPO, ENCARGADO Y VENDEDOR DE LA VENTA"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 8
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.Controls.Add(Me.Cb_Vendedores, 7, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Cb_Encargados, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 6, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label12, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.cb_Tipo, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 17)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(915, 39)
        Me.TableLayoutPanel2.TabIndex = 44
        '
        'Cb_Vendedores
        '
        Me.Cb_Vendedores.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cb_Vendedores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cb_Vendedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Vendedores.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Cb_Vendedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_Vendedores.FormattingEnabled = True
        Me.Cb_Vendedores.Location = New System.Drawing.Point(739, 8)
        Me.Cb_Vendedores.Name = "Cb_Vendedores"
        Me.Cb_Vendedores.Size = New System.Drawing.Size(173, 23)
        Me.Cb_Vendedores.TabIndex = 3
        '
        'Cb_Encargados
        '
        Me.Cb_Encargados.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cb_Encargados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cb_Encargados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Encargados.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Cb_Encargados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_Encargados.FormattingEnabled = True
        Me.Cb_Encargados.Location = New System.Drawing.Point(421, 8)
        Me.Cb_Encargados.Name = "Cb_Encargados"
        Me.Cb_Encargados.Size = New System.Drawing.Size(172, 23)
        Me.Cb_Encargados.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(639, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 15)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Vendedor"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tipo de Venta"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(321, 12)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 15)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Encargado"
        '
        'cb_Tipo
        '
        Me.cb_Tipo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_Tipo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_Tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Tipo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cb_Tipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_Tipo.FormattingEnabled = True
        Me.cb_Tipo.Items.AddRange(New Object() {"Minorista", "Mayorista"})
        Me.cb_Tipo.Location = New System.Drawing.Point(103, 8)
        Me.cb_Tipo.Name = "cb_Tipo"
        Me.cb_Tipo.Size = New System.Drawing.Size(172, 23)
        Me.cb_Tipo.TabIndex = 1
        '
        'Gb_Cliente
        '
        Me.Gb_Cliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gb_Cliente.Controls.Add(Me.TableLayoutPanel1)
        Me.Gb_Cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gb_Cliente.Location = New System.Drawing.Point(16, 127)
        Me.Gb_Cliente.Name = "Gb_Cliente"
        Me.Gb_Cliente.Size = New System.Drawing.Size(922, 96)
        Me.Gb_Cliente.TabIndex = 28
        Me.Gb_Cliente.TabStop = False
        Me.Gb_Cliente.Text = "CLIENTE"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Btn_BuscarCliente, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_RazonSocial, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_id_Cliente, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_PorcentajeFacturacion, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel12, 2, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 17)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(916, 76)
        Me.TableLayoutPanel1.TabIndex = 44
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 15)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Facturación %"
        '
        'Btn_BuscarCliente
        '
        Me.Btn_BuscarCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_BuscarCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_BuscarCliente.FlatAppearance.BorderSize = 0
        Me.Btn_BuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_BuscarCliente.Image = Global.SistemaCinderella.My.Resources.Recursos.Clientes_32
        Me.Btn_BuscarCliente.Location = New System.Drawing.Point(876, 3)
        Me.Btn_BuscarCliente.Name = "Btn_BuscarCliente"
        Me.Btn_BuscarCliente.Size = New System.Drawing.Size(37, 29)
        Me.Btn_BuscarCliente.TabIndex = 6
        Me.Btn_BuscarCliente.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 15)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Cliente"
        '
        'txt_RazonSocial
        '
        Me.txt_RazonSocial.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_RazonSocial.BackColor = System.Drawing.SystemColors.Window
        Me.txt_RazonSocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_RazonSocial.Location = New System.Drawing.Point(334, 7)
        Me.txt_RazonSocial.Name = "txt_RazonSocial"
        Me.txt_RazonSocial.ReadOnly = True
        Me.txt_RazonSocial.Size = New System.Drawing.Size(533, 21)
        Me.txt_RazonSocial.TabIndex = 5
        '
        'txt_id_Cliente
        '
        Me.txt_id_Cliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_id_Cliente.BackColor = System.Drawing.SystemColors.Window
        Me.txt_id_Cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id_Cliente.Location = New System.Drawing.Point(103, 7)
        Me.txt_id_Cliente.Name = "txt_id_Cliente"
        Me.txt_id_Cliente.ReadOnly = True
        Me.txt_id_Cliente.Size = New System.Drawing.Size(225, 21)
        Me.txt_id_Cliente.TabIndex = 4
        '
        'txt_PorcentajeFacturacion
        '
        Me.txt_PorcentajeFacturacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_PorcentajeFacturacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PorcentajeFacturacion.Location = New System.Drawing.Point(103, 45)
        Me.txt_PorcentajeFacturacion.Name = "txt_PorcentajeFacturacion"
        Me.txt_PorcentajeFacturacion.Size = New System.Drawing.Size(225, 21)
        Me.txt_PorcentajeFacturacion.TabIndex = 9
        '
        'TableLayoutPanel12
        '
        Me.TableLayoutPanel12.ColumnCount = 2
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel12.Controls.Add(Me.txt_PorcentajeBonificacion, 0, 0)
        Me.TableLayoutPanel12.Controls.Add(Me.Label33, 0, 0)
        Me.TableLayoutPanel12.Location = New System.Drawing.Point(334, 38)
        Me.TableLayoutPanel12.Name = "TableLayoutPanel12"
        Me.TableLayoutPanel12.RowCount = 1
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel12.Size = New System.Drawing.Size(352, 30)
        Me.TableLayoutPanel12.TabIndex = 10
        '
        'txt_PorcentajeBonificacion
        '
        Me.txt_PorcentajeBonificacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_PorcentajeBonificacion.DecimalPlaces = 2
        Me.txt_PorcentajeBonificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PorcentajeBonificacion.Location = New System.Drawing.Point(103, 4)
        Me.txt_PorcentajeBonificacion.Name = "txt_PorcentajeBonificacion"
        Me.txt_PorcentajeBonificacion.Size = New System.Drawing.Size(246, 21)
        Me.txt_PorcentajeBonificacion.TabIndex = 9
        '
        'Label33
        '
        Me.Label33.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(3, 7)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(94, 15)
        Me.Label33.TabIndex = 8
        Me.Label33.Text = "Bonificación %"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel4)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 229)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(572, 104)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PRODUCTO"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel5, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label9, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.txt_CodigoBarra, 1, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 17)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(566, 84)
        Me.TableLayoutPanel4.TabIndex = 44
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 3
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.Btn_Agregar, 2, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(203, 33)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(360, 48)
        Me.TableLayoutPanel5.TabIndex = 45
        '
        'Btn_Agregar
        '
        Me.Btn_Agregar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Btn_Agregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Agregar.Image = Global.SistemaCinderella.My.Resources.Recursos.Productos_32
        Me.Btn_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Agregar.Location = New System.Drawing.Point(257, 7)
        Me.Btn_Agregar.Name = "Btn_Agregar"
        Me.Btn_Agregar.Size = New System.Drawing.Size(100, 34)
        Me.Btn_Agregar.TabIndex = 12
        Me.Btn_Agregar.Text = "Agregar"
        Me.Btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Agregar.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 7)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(194, 15)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Nombre / Código de Producto"
        '
        'txt_CodigoBarra
        '
        Me.txt_CodigoBarra.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_CodigoBarra.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_CodigoBarra.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_CodigoBarra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CodigoBarra.Location = New System.Drawing.Point(203, 4)
        Me.txt_CodigoBarra.Name = "txt_CodigoBarra"
        Me.txt_CodigoBarra.Size = New System.Drawing.Size(360, 21)
        Me.txt_CodigoBarra.TabIndex = 8
        '
        'GB_ListaPrecio
        '
        Me.GB_ListaPrecio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_ListaPrecio.Controls.Add(Me.Cb_ListaPrecio)
        Me.GB_ListaPrecio.Controls.Add(Me.Label14)
        Me.GB_ListaPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_ListaPrecio.Location = New System.Drawing.Point(592, 286)
        Me.GB_ListaPrecio.Name = "GB_ListaPrecio"
        Me.GB_ListaPrecio.Size = New System.Drawing.Size(344, 44)
        Me.GB_ListaPrecio.TabIndex = 31
        Me.GB_ListaPrecio.TabStop = False
        Me.GB_ListaPrecio.Text = "LISTA PRECIOS"
        '
        'Cb_ListaPrecio
        '
        Me.Cb_ListaPrecio.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cb_ListaPrecio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cb_ListaPrecio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_ListaPrecio.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Cb_ListaPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_ListaPrecio.FormattingEnabled = True
        Me.Cb_ListaPrecio.Location = New System.Drawing.Point(121, 15)
        Me.Cb_ListaPrecio.Name = "Cb_ListaPrecio"
        Me.Cb_ListaPrecio.Size = New System.Drawing.Size(217, 23)
        Me.Cb_ListaPrecio.TabIndex = 12
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(7, 23)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(94, 15)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Lista de Precios"
        '
        'GB_TipoPago
        '
        Me.GB_TipoPago.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_TipoPago.Controls.Add(Me.Cb_TipoPago)
        Me.GB_TipoPago.Controls.Add(Me.Label10)
        Me.GB_TipoPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_TipoPago.Location = New System.Drawing.Point(594, 229)
        Me.GB_TipoPago.Name = "GB_TipoPago"
        Me.GB_TipoPago.Size = New System.Drawing.Size(345, 44)
        Me.GB_TipoPago.TabIndex = 30
        Me.GB_TipoPago.TabStop = False
        Me.GB_TipoPago.Text = "TIPO DE PAGO"
        '
        'Cb_TipoPago
        '
        Me.Cb_TipoPago.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Cb_TipoPago.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cb_TipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_TipoPago.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Cb_TipoPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_TipoPago.FormattingEnabled = True
        Me.Cb_TipoPago.Location = New System.Drawing.Point(119, 13)
        Me.Cb_TipoPago.Name = "Cb_TipoPago"
        Me.Cb_TipoPago.Size = New System.Drawing.Size(219, 23)
        Me.Cb_TipoPago.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(7, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 15)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Tipo de Pago"
        '
        'DG_Productos
        '
        Me.DG_Productos.AllowUserToAddRows = False
        Me.DG_Productos.AllowUserToDeleteRows = False
        Me.DG_Productos.AllowUserToResizeColumns = False
        Me.DG_Productos.AllowUserToResizeRows = False
        Me.DG_Productos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_Productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_Productos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DG_Productos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DG_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Productos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NUMERO, Me.ID, Me.CODIGO, Me.NOMBRE, Me.CANTIDAD, Me.PRECIO, Me.IVA, Me.MONTO, Me.SUBTOTAL, Me.ELIMINAR, Me.Precio1, Me.Precio2, Me.Precio3, Me.Precio4, Me.Precio5, Me.Precio6})
        Me.DG_Productos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DG_Productos.Location = New System.Drawing.Point(16, 339)
        Me.DG_Productos.Name = "DG_Productos"
        Me.DG_Productos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DG_Productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Productos.Size = New System.Drawing.Size(922, 189)
        Me.DG_Productos.TabIndex = 41
        '
        'NUMERO
        '
        Me.NUMERO.HeaderText = "NUMERO"
        Me.NUMERO.Name = "NUMERO"
        Me.NUMERO.ReadOnly = True
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        '
        'CODIGO
        '
        Me.CODIGO.HeaderText = "CODIGO"
        Me.CODIGO.Name = "CODIGO"
        Me.CODIGO.ReadOnly = True
        '
        'NOMBRE
        '
        Me.NOMBRE.HeaderText = "NOMBRE"
        Me.NOMBRE.Name = "NOMBRE"
        Me.NOMBRE.ReadOnly = True
        '
        'CANTIDAD
        '
        Me.CANTIDAD.HeaderText = "CANTIDAD"
        Me.CANTIDAD.Name = "CANTIDAD"
        '
        'PRECIO
        '
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = "0"
        Me.PRECIO.DefaultCellStyle = DataGridViewCellStyle1
        Me.PRECIO.HeaderText = "PRECIO"
        Me.PRECIO.Name = "PRECIO"
        Me.PRECIO.ReadOnly = True
        '
        'IVA
        '
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = "0"
        Me.IVA.DefaultCellStyle = DataGridViewCellStyle2
        Me.IVA.HeaderText = "IVA"
        Me.IVA.Name = "IVA"
        Me.IVA.ReadOnly = True
        '
        'MONTO
        '
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.MONTO.DefaultCellStyle = DataGridViewCellStyle3
        Me.MONTO.HeaderText = "MONTO"
        Me.MONTO.Name = "MONTO"
        Me.MONTO.ReadOnly = True
        '
        'SUBTOTAL
        '
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = "0"
        Me.SUBTOTAL.DefaultCellStyle = DataGridViewCellStyle4
        Me.SUBTOTAL.HeaderText = "SUBTOTAL"
        Me.SUBTOTAL.Name = "SUBTOTAL"
        Me.SUBTOTAL.ReadOnly = True
        '
        'ELIMINAR
        '
        Me.ELIMINAR.HeaderText = "ELIMINAR"
        Me.ELIMINAR.Name = "ELIMINAR"
        Me.ELIMINAR.ReadOnly = True
        '
        'Precio1
        '
        Me.Precio1.HeaderText = "Precio1"
        Me.Precio1.Name = "Precio1"
        Me.Precio1.Visible = False
        '
        'Precio2
        '
        Me.Precio2.HeaderText = "Precio2"
        Me.Precio2.Name = "Precio2"
        Me.Precio2.Visible = False
        '
        'Precio3
        '
        Me.Precio3.HeaderText = "Precio3"
        Me.Precio3.Name = "Precio3"
        Me.Precio3.Visible = False
        '
        'Precio4
        '
        Me.Precio4.HeaderText = "Precio4"
        Me.Precio4.Name = "Precio4"
        Me.Precio4.Visible = False
        '
        'Precio5
        '
        Me.Precio5.HeaderText = "Precio5"
        Me.Precio5.Name = "Precio5"
        Me.Precio5.Visible = False
        '
        'Precio6
        '
        Me.Precio6.HeaderText = "Precio6"
        Me.Precio6.Name = "Precio6"
        Me.Precio6.Visible = False
        '
        'PanelTotalMayorista
        '
        Me.PanelTotalMayorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelTotalMayorista.Controls.Add(Me.Label2)
        Me.PanelTotalMayorista.Controls.Add(Me.Label11)
        Me.PanelTotalMayorista.Controls.Add(Me.Label19)
        Me.PanelTotalMayorista.Controls.Add(Me.txt_SubtotalMayorista)
        Me.PanelTotalMayorista.Controls.Add(Me.Label20)
        Me.PanelTotalMayorista.Controls.Add(Me.txt_TotalMayorista)
        Me.PanelTotalMayorista.Controls.Add(Me.txt_DescuentoMayorista)
        Me.PanelTotalMayorista.Controls.Add(Me.Label21)
        Me.PanelTotalMayorista.Controls.Add(Me.Label22)
        Me.PanelTotalMayorista.Controls.Add(Me.txt_ivaTotalMayorista)
        Me.PanelTotalMayorista.Controls.Add(Me.Label23)
        Me.PanelTotalMayorista.Controls.Add(Me.Label24)
        Me.PanelTotalMayorista.Location = New System.Drawing.Point(15, 534)
        Me.PanelTotalMayorista.Name = "PanelTotalMayorista"
        Me.PanelTotalMayorista.Size = New System.Drawing.Size(399, 150)
        Me.PanelTotalMayorista.TabIndex = 42
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(221, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 22)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "$"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(221, 45)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(21, 22)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "$"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(222, 14)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(21, 22)
        Me.Label19.TabIndex = 32
        Me.Label19.Text = "$"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_SubtotalMayorista
        '
        Me.txt_SubtotalMayorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_SubtotalMayorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SubtotalMayorista.Location = New System.Drawing.Point(257, 41)
        Me.txt_SubtotalMayorista.Name = "txt_SubtotalMayorista"
        Me.txt_SubtotalMayorista.ReadOnly = True
        Me.txt_SubtotalMayorista.Size = New System.Drawing.Size(139, 29)
        Me.txt_SubtotalMayorista.TabIndex = 28
        Me.txt_SubtotalMayorista.Text = "0,00"
        Me.txt_SubtotalMayorista.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(9, 48)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(122, 22)
        Me.Label20.TabIndex = 31
        Me.Label20.Text = "SUBTOTAL:"
        '
        'txt_TotalMayorista
        '
        Me.txt_TotalMayorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_TotalMayorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TotalMayorista.Location = New System.Drawing.Point(257, 110)
        Me.txt_TotalMayorista.Name = "txt_TotalMayorista"
        Me.txt_TotalMayorista.ReadOnly = True
        Me.txt_TotalMayorista.Size = New System.Drawing.Size(139, 29)
        Me.txt_TotalMayorista.TabIndex = 29
        Me.txt_TotalMayorista.Text = "0,00"
        Me.txt_TotalMayorista.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_DescuentoMayorista
        '
        Me.txt_DescuentoMayorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_DescuentoMayorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_DescuentoMayorista.Location = New System.Drawing.Point(258, 5)
        Me.txt_DescuentoMayorista.Name = "txt_DescuentoMayorista"
        Me.txt_DescuentoMayorista.Size = New System.Drawing.Size(139, 29)
        Me.txt_DescuentoMayorista.TabIndex = 27
        Me.txt_DescuentoMayorista.Text = "0,00"
        Me.txt_DescuentoMayorista.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label21
        '
        Me.Label21.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(10, 12)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(138, 22)
        Me.Label21.TabIndex = 30
        Me.Label21.Text = "DESCUENTO:"
        '
        'Label22
        '
        Me.Label22.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(9, 119)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(82, 22)
        Me.Label22.TabIndex = 26
        Me.Label22.Text = "TOTAL:"
        '
        'txt_ivaTotalMayorista
        '
        Me.txt_ivaTotalMayorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_ivaTotalMayorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ivaTotalMayorista.Location = New System.Drawing.Point(256, 76)
        Me.txt_ivaTotalMayorista.Name = "txt_ivaTotalMayorista"
        Me.txt_ivaTotalMayorista.ReadOnly = True
        Me.txt_ivaTotalMayorista.Size = New System.Drawing.Size(139, 29)
        Me.txt_ivaTotalMayorista.TabIndex = 23
        Me.txt_ivaTotalMayorista.Text = "0,00"
        Me.txt_ivaTotalMayorista.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label23
        '
        Me.Label23.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(220, 80)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(21, 22)
        Me.Label23.TabIndex = 25
        Me.Label23.Text = "$"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label24
        '
        Me.Label24.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(12, 82)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(90, 22)
        Me.Label24.TabIndex = 24
        Me.Label24.Text = "IVA 21%:"
        '
        'PanelTotalMinorista
        '
        Me.PanelTotalMinorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelTotalMinorista.Controls.Add(Me.Label25)
        Me.PanelTotalMinorista.Controls.Add(Me.lbl_DescrTot)
        Me.PanelTotalMinorista.Controls.Add(Me.Label26)
        Me.PanelTotalMinorista.Controls.Add(Me.txt_DescuentoMinorista)
        Me.PanelTotalMinorista.Controls.Add(Me.Label27)
        Me.PanelTotalMinorista.Controls.Add(Me.txt_TotalMinorista)
        Me.PanelTotalMinorista.Controls.Add(Me.Label28)
        Me.PanelTotalMinorista.Controls.Add(Me.lbl_subTotal)
        Me.PanelTotalMinorista.Controls.Add(Me.txt_SubtotalMinorista)
        Me.PanelTotalMinorista.Location = New System.Drawing.Point(542, 534)
        Me.PanelTotalMinorista.Name = "PanelTotalMinorista"
        Me.PanelTotalMinorista.Size = New System.Drawing.Size(399, 150)
        Me.PanelTotalMinorista.TabIndex = 43
        '
        'Label25
        '
        Me.Label25.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(3, 44)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(138, 22)
        Me.Label25.TabIndex = 16
        Me.Label25.Text = "DESCUENTO:"
        '
        'lbl_DescrTot
        '
        Me.lbl_DescrTot.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_DescrTot.AutoSize = True
        Me.lbl_DescrTot.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DescrTot.Location = New System.Drawing.Point(3, 119)
        Me.lbl_DescrTot.Name = "lbl_DescrTot"
        Me.lbl_DescrTot.Size = New System.Drawing.Size(82, 22)
        Me.lbl_DescrTot.TabIndex = 9
        Me.lbl_DescrTot.Text = "TOTAL:"
        '
        'Label26
        '
        Me.Label26.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(221, 116)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(21, 22)
        Me.Label26.TabIndex = 21
        Me.Label26.Text = "$"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_DescuentoMinorista
        '
        Me.txt_DescuentoMinorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_DescuentoMinorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_DescuentoMinorista.Location = New System.Drawing.Point(257, 41)
        Me.txt_DescuentoMinorista.Name = "txt_DescuentoMinorista"
        Me.txt_DescuentoMinorista.Size = New System.Drawing.Size(139, 29)
        Me.txt_DescuentoMinorista.TabIndex = 13
        Me.txt_DescuentoMinorista.Text = "0,00"
        Me.txt_DescuentoMinorista.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label27
        '
        Me.Label27.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(221, 9)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(21, 22)
        Me.Label27.TabIndex = 20
        Me.Label27.Text = "$"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_TotalMinorista
        '
        Me.txt_TotalMinorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_TotalMinorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TotalMinorista.Location = New System.Drawing.Point(257, 110)
        Me.txt_TotalMinorista.Name = "txt_TotalMinorista"
        Me.txt_TotalMinorista.ReadOnly = True
        Me.txt_TotalMinorista.Size = New System.Drawing.Size(139, 29)
        Me.txt_TotalMinorista.TabIndex = 15
        Me.txt_TotalMinorista.Text = "0,00"
        Me.txt_TotalMinorista.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label28
        '
        Me.Label28.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(221, 44)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(21, 22)
        Me.Label28.TabIndex = 19
        Me.Label28.Text = "$"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_subTotal
        '
        Me.lbl_subTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_subTotal.AutoSize = True
        Me.lbl_subTotal.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_subTotal.Location = New System.Drawing.Point(3, 8)
        Me.lbl_subTotal.Name = "lbl_subTotal"
        Me.lbl_subTotal.Size = New System.Drawing.Size(122, 22)
        Me.lbl_subTotal.TabIndex = 17
        Me.lbl_subTotal.Text = "SUBTOTAL:"
        '
        'txt_SubtotalMinorista
        '
        Me.txt_SubtotalMinorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_SubtotalMinorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SubtotalMinorista.Location = New System.Drawing.Point(257, 5)
        Me.txt_SubtotalMinorista.Name = "txt_SubtotalMinorista"
        Me.txt_SubtotalMinorista.ReadOnly = True
        Me.txt_SubtotalMinorista.Size = New System.Drawing.Size(139, 29)
        Me.txt_SubtotalMinorista.TabIndex = 14
        Me.txt_SubtotalMinorista.Text = "0,00"
        Me.txt_SubtotalMinorista.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmDevoluciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(954, 737)
        Me.Controls.Add(Me.PanelTotalMayorista)
        Me.Controls.Add(Me.PanelTotalMinorista)
        Me.Controls.Add(Me.DG_Productos)
        Me.Controls.Add(Me.GB_ListaPrecio)
        Me.Controls.Add(Me.GB_TipoPago)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Gb_Cliente)
        Me.Controls.Add(Me.Gb_Vendedor)
        Me.Controls.Add(Me.GB_Fecha)
        Me.Controls.Add(Me.Btn_Cancelar)
        Me.Controls.Add(Me.Btn_Finalizar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDevoluciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administración de Devoluciones"
        Me.GB_Fecha.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.Gb_Vendedor.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.Gb_Cliente.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.txt_PorcentajeFacturacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel12.ResumeLayout(False)
        Me.TableLayoutPanel12.PerformLayout()
        CType(Me.txt_PorcentajeBonificacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.GB_ListaPrecio.ResumeLayout(False)
        Me.GB_ListaPrecio.PerformLayout()
        Me.GB_TipoPago.ResumeLayout(False)
        Me.GB_TipoPago.PerformLayout()
        CType(Me.DG_Productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTotalMayorista.ResumeLayout(False)
        Me.PanelTotalMayorista.PerformLayout()
        Me.PanelTotalMinorista.ResumeLayout(False)
        Me.PanelTotalMinorista.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ToolCamb As System.Windows.Forms.ToolTip
    Friend WithEvents GB_Fecha As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Sucursal As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbl_Fecha As System.Windows.Forms.Label
    Friend WithEvents lbl_Hora As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents Btn_Finalizar As System.Windows.Forms.Button
    Friend WithEvents Gb_Vendedor As System.Windows.Forms.GroupBox
    Friend WithEvents Cb_Encargados As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cb_Tipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Cb_Vendedores As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Gb_Cliente As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_BuscarCliente As System.Windows.Forms.Button
    Friend WithEvents txt_RazonSocial As System.Windows.Forms.TextBox
    Friend WithEvents txt_id_Cliente As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GB_ListaPrecio As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GB_TipoPago As System.Windows.Forms.GroupBox
    Friend WithEvents Cb_TipoPago As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DG_Productos As DataGridView
    Friend WithEvents NUMERO As DataGridViewTextBoxColumn
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents CODIGO As DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE As DataGridViewTextBoxColumn
    Friend WithEvents CANTIDAD As DataGridViewTextBoxColumn
    Friend WithEvents PRECIO As DataGridViewTextBoxColumn
    Friend WithEvents IVA As DataGridViewTextBoxColumn
    Friend WithEvents MONTO As DataGridViewTextBoxColumn
    Friend WithEvents SUBTOTAL As DataGridViewTextBoxColumn
    Friend WithEvents ELIMINAR As DataGridViewImageColumn
    Friend WithEvents Precio1 As DataGridViewTextBoxColumn
    Friend WithEvents Precio2 As DataGridViewTextBoxColumn
    Friend WithEvents Precio3 As DataGridViewTextBoxColumn
    Friend WithEvents Precio4 As DataGridViewTextBoxColumn
    Friend WithEvents Precio5 As DataGridViewTextBoxColumn
    Friend WithEvents Precio6 As DataGridViewTextBoxColumn
    Friend WithEvents PanelTotalMayorista As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents txt_SubtotalMayorista As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txt_TotalMayorista As TextBox
    Friend WithEvents txt_DescuentoMayorista As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents txt_ivaTotalMayorista As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents PanelTotalMinorista As Panel
    Friend WithEvents Label25 As Label
    Friend WithEvents lbl_DescrTot As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents txt_DescuentoMinorista As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents txt_TotalMinorista As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents lbl_subTotal As Label
    Friend WithEvents txt_SubtotalMinorista As TextBox
    Friend WithEvents Btn_Agregar As Button
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents txt_CodigoBarra As TextBox
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_PorcentajeFacturacion As NumericUpDown
    Friend WithEvents TableLayoutPanel12 As TableLayoutPanel
    Friend WithEvents Label33 As Label
    Friend WithEvents Cb_ListaPrecio As ComboBox
    Friend WithEvents txt_PorcentajeBonificacion As NumericUpDown
End Class
