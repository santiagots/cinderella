<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVentasAdministracion
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVentasAdministracion))
        Me.TabVentas = New System.Windows.Forms.TabControl()
        Me.TbListado = New System.Windows.Forms.TabPage()
        Me.lbl_Msg = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.cmbFormaPago = New System.Windows.Forms.ComboBox()
        Me.btn_Restablecer = New System.Windows.Forms.Button()
        Me.BtnFiltrar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.chkMenor = New System.Windows.Forms.CheckBox()
        Me.chkMayor = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ChkMarcaManual = New System.Windows.Forms.CheckBox()
        Me.ChkMarcaSinFacturar = New System.Windows.Forms.CheckBox()
        Me.ChkMarcaElectronica = New System.Windows.Forms.CheckBox()
        Me.ChkMarcaTicket = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.ChkAnuladoSi = New System.Windows.Forms.CheckBox()
        Me.ChkAnuladoNo = New System.Windows.Forms.CheckBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtFacturaDesde = New System.Windows.Forms.TextBox()
        Me.FHasta = New System.Windows.Forms.DateTimePicker()
        Me.txtMontoHasta = New System.Windows.Forms.TextBox()
        Me.FDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtMontoDesde = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtFacturaHasta = New System.Windows.Forms.TextBox()
        Me.DG_Ventas = New System.Windows.Forms.DataGridView()
        Me.id_Venta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FormaPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Empleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Anulado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoFactura = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.NumFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbDetalle = New System.Windows.Forms.TabPage()
        Me.lblcontenedor = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblAnulado = New System.Windows.Forms.Label()
        Me.Gb_Anulado = New System.Windows.Forms.GroupBox()
        Me.btnReporteVenta = New System.Windows.Forms.Button()
        Me.txtDescripcionAnular = New System.Windows.Forms.TextBox()
        Me.BtnAnular = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblPorcentajeFacturacion = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblSucursal = New System.Windows.Forms.Label()
        Me.lblEncargado = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblVenta = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblVendedor = New System.Windows.Forms.Label()
        Me.PanelTotalMinoristaSenia = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblCostoFinancieroMinorista = New System.Windows.Forms.Label()
        Me.lblPendienteAbonarMinorista = New System.Windows.Forms.Label()
        Me.lblPendienteAbonarMinoristaDescripcion = New System.Windows.Forms.Label()
        Me.lblSeniaMinorista = New System.Windows.Forms.Label()
        Me.lblSeniaMinoristaDescripcion = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblMontoMinoristaDescripcion = New System.Windows.Forms.Label()
        Me.lblMontoMinorista = New System.Windows.Forms.Label()
        Me.lblDescuentoMinorista = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblSubtotalMinorista = New System.Windows.Forms.Label()
        Me.PanelTotalMayorista = New System.Windows.Forms.Panel()
        Me.lblDescuentoMayorista = New System.Windows.Forms.Label()
        Me.lblPendienteAbonarMayorista = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lblPendienteAbonarMayoristaDescripcion = New System.Windows.Forms.Label()
        Me.lblSeniaMayorista = New System.Windows.Forms.Label()
        Me.lblSeniaMayoristaDescripcion = New System.Windows.Forms.Label()
        Me.lblIVAMayorista = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.lblSubtotalMayorista = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lblCostoFinancieroMayorista = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.lblMontoMayorista = New System.Windows.Forms.Label()
        Me.lblMontoMayoristaDescripcion = New System.Windows.Forms.Label()
        Me.BtnEmitirFactura = New System.Windows.Forms.Button()
        Me.BtnFactura = New System.Windows.Forms.Button()
        Me.lblFacturado = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.lblPago = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DG_Productos = New System.Windows.Forms.DataGridView()
        Me.NUMERO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODIGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANTIDAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRECIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MONTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SUBTOTAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TipoFacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolVentas = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabVentas.SuspendLayout()
        Me.TbListado.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.DG_Ventas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TbDetalle.SuspendLayout()
        Me.lblcontenedor.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.Gb_Anulado.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.PanelTotalMinoristaSenia.SuspendLayout()
        Me.PanelTotalMayorista.SuspendLayout()
        CType(Me.DG_Productos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoFacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabVentas
        '
        Me.TabVentas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabVentas.Controls.Add(Me.TbListado)
        Me.TabVentas.Controls.Add(Me.TbDetalle)
        Me.TabVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabVentas.Location = New System.Drawing.Point(0, 0)
        Me.TabVentas.Name = "TabVentas"
        Me.TabVentas.SelectedIndex = 0
        Me.TabVentas.Size = New System.Drawing.Size(884, 612)
        Me.TabVentas.TabIndex = 2
        '
        'TbListado
        '
        Me.TbListado.Controls.Add(Me.lbl_Msg)
        Me.TbListado.Controls.Add(Me.GroupBox1)
        Me.TbListado.Controls.Add(Me.DG_Ventas)
        Me.TbListado.Location = New System.Drawing.Point(4, 29)
        Me.TbListado.Name = "TbListado"
        Me.TbListado.Padding = New System.Windows.Forms.Padding(3)
        Me.TbListado.Size = New System.Drawing.Size(876, 579)
        Me.TbListado.TabIndex = 0
        Me.TbListado.Text = "Ventas"
        Me.TbListado.UseVisualStyleBackColor = True
        '
        'lbl_Msg
        '
        Me.lbl_Msg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Msg.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lbl_Msg.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Msg.Location = New System.Drawing.Point(278, 362)
        Me.lbl_Msg.Name = "lbl_Msg"
        Me.lbl_Msg.Size = New System.Drawing.Size(328, 25)
        Me.lbl_Msg.TabIndex = 2
        Me.lbl_Msg.Text = "No se han encontrado ventas."
        Me.lbl_Msg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel3)
        Me.GroupBox1.Controls.Add(Me.btn_Restablecer)
        Me.GroupBox1.Controls.Add(Me.BtnFiltrar)
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(10, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(860, 193)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtrar ventas."
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label25, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.cmbFormaPago, 1, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 138)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(349, 30)
        Me.TableLayoutPanel3.TabIndex = 10
        '
        'Label25
        '
        Me.Label25.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(3, 7)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(134, 16)
        Me.Label25.TabIndex = 437
        Me.Label25.Text = "Forma Pago"
        '
        'cmbFormaPago
        '
        Me.cmbFormaPago.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbFormaPago.FormattingEnabled = True
        Me.cmbFormaPago.Location = New System.Drawing.Point(143, 3)
        Me.cmbFormaPago.Name = "cmbFormaPago"
        Me.cmbFormaPago.Size = New System.Drawing.Size(203, 23)
        Me.cmbFormaPago.TabIndex = 438
        '
        'btn_Restablecer
        '
        Me.btn_Restablecer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Restablecer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Restablecer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Restablecer.Location = New System.Drawing.Point(660, 144)
        Me.btn_Restablecer.Name = "btn_Restablecer"
        Me.btn_Restablecer.Size = New System.Drawing.Size(94, 41)
        Me.btn_Restablecer.TabIndex = 9
        Me.btn_Restablecer.Text = "Restablecer Busqueda"
        Me.ToolVentas.SetToolTip(Me.btn_Restablecer, "haz click aquí para restablecer los filtros y el listado de ventas.")
        Me.btn_Restablecer.UseVisualStyleBackColor = True
        '
        'BtnFiltrar
        '
        Me.BtnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFiltrar.FlatAppearance.BorderSize = 0
        Me.BtnFiltrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFiltrar.Image = Global.SistemaCinderella.My.Resources.Recursos.IconoBuscar32
        Me.BtnFiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnFiltrar.Location = New System.Drawing.Point(760, 144)
        Me.BtnFiltrar.Name = "BtnFiltrar"
        Me.BtnFiltrar.Size = New System.Drawing.Size(94, 41)
        Me.BtnFiltrar.TabIndex = 4
        Me.BtnFiltrar.Text = "Buscar"
        Me.BtnFiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolVentas.SetToolTip(Me.BtnFiltrar, "Haz click aquí para buscar ventas con los criterios de busqueda seleccionados.")
        Me.BtnFiltrar.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 7
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.99999!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel6, 6, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label9, 5, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.ChkMarcaManual, 3, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.ChkMarcaSinFacturar, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.ChkMarcaElectronica, 3, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.ChkMarcaTicket, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel4, 6, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label13, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label19, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label20, 5, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.txtFacturaDesde, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.FHasta, 6, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtMontoHasta, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.FDesde, 6, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label18, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label11, 5, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label12, 5, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtMontoDesde, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label17, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label29, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtFacturaHasta, 3, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 17)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(854, 121)
        Me.TableLayoutPanel2.TabIndex = 3
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 2
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.chkMenor, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.chkMayor, 1, 0)
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(571, 93)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(200, 24)
        Me.TableLayoutPanel6.TabIndex = 436
        '
        'chkMenor
        '
        Me.chkMenor.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkMenor.AutoSize = True
        Me.chkMenor.Checked = True
        Me.chkMenor.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMenor.Location = New System.Drawing.Point(3, 3)
        Me.chkMenor.Name = "chkMenor"
        Me.chkMenor.Size = New System.Drawing.Size(94, 18)
        Me.chkMenor.TabIndex = 432
        Me.chkMenor.Text = "Menor"
        Me.chkMenor.UseVisualStyleBackColor = True
        '
        'chkMayor
        '
        Me.chkMayor.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkMayor.AutoSize = True
        Me.chkMayor.Checked = True
        Me.chkMayor.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMayor.Location = New System.Drawing.Point(103, 3)
        Me.chkMayor.Name = "chkMayor"
        Me.chkMayor.Size = New System.Drawing.Size(94, 18)
        Me.chkMayor.TabIndex = 433
        Me.chkMayor.Text = "Mayor"
        Me.chkMayor.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(431, 97)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(134, 16)
        Me.Label9.TabIndex = 432
        Me.Label9.Text = "Tipo Cliente"
        '
        'ChkMarcaManual
        '
        Me.ChkMarcaManual.AutoSize = True
        Me.ChkMarcaManual.Checked = True
        Me.ChkMarcaManual.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkMarcaManual.Location = New System.Drawing.Point(257, 63)
        Me.ChkMarcaManual.Name = "ChkMarcaManual"
        Me.ChkMarcaManual.Size = New System.Drawing.Size(68, 19)
        Me.ChkMarcaManual.TabIndex = 424
        Me.ChkMarcaManual.Text = "Manual"
        Me.ChkMarcaManual.UseVisualStyleBackColor = True
        '
        'ChkMarcaSinFacturar
        '
        Me.ChkMarcaSinFacturar.AutoSize = True
        Me.ChkMarcaSinFacturar.Checked = True
        Me.ChkMarcaSinFacturar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkMarcaSinFacturar.Location = New System.Drawing.Point(143, 63)
        Me.ChkMarcaSinFacturar.Name = "ChkMarcaSinFacturar"
        Me.ChkMarcaSinFacturar.Size = New System.Drawing.Size(88, 19)
        Me.ChkMarcaSinFacturar.TabIndex = 423
        Me.ChkMarcaSinFacturar.Text = "Sin Facturar"
        Me.ChkMarcaSinFacturar.UseVisualStyleBackColor = True
        '
        'ChkMarcaElectronica
        '
        Me.ChkMarcaElectronica.AutoSize = True
        Me.ChkMarcaElectronica.Checked = True
        Me.ChkMarcaElectronica.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkMarcaElectronica.Location = New System.Drawing.Point(257, 93)
        Me.ChkMarcaElectronica.Name = "ChkMarcaElectronica"
        Me.ChkMarcaElectronica.Size = New System.Drawing.Size(87, 19)
        Me.ChkMarcaElectronica.TabIndex = 426
        Me.ChkMarcaElectronica.Text = "Electronica"
        Me.ChkMarcaElectronica.UseVisualStyleBackColor = True
        '
        'ChkMarcaTicket
        '
        Me.ChkMarcaTicket.AutoSize = True
        Me.ChkMarcaTicket.Checked = True
        Me.ChkMarcaTicket.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkMarcaTicket.Location = New System.Drawing.Point(143, 93)
        Me.ChkMarcaTicket.Name = "ChkMarcaTicket"
        Me.ChkMarcaTicket.Size = New System.Drawing.Size(58, 19)
        Me.ChkMarcaTicket.TabIndex = 425
        Me.ChkMarcaTicket.Text = "Ticket"
        Me.ChkMarcaTicket.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.ChkAnuladoSi, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.ChkAnuladoNo, 1, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(571, 63)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(200, 24)
        Me.TableLayoutPanel4.TabIndex = 435
        '
        'ChkAnuladoSi
        '
        Me.ChkAnuladoSi.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkAnuladoSi.AutoSize = True
        Me.ChkAnuladoSi.Checked = True
        Me.ChkAnuladoSi.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkAnuladoSi.Location = New System.Drawing.Point(3, 3)
        Me.ChkAnuladoSi.Name = "ChkAnuladoSi"
        Me.ChkAnuladoSi.Size = New System.Drawing.Size(94, 18)
        Me.ChkAnuladoSi.TabIndex = 432
        Me.ChkAnuladoSi.Text = "Si"
        Me.ChkAnuladoSi.UseVisualStyleBackColor = True
        '
        'ChkAnuladoNo
        '
        Me.ChkAnuladoNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkAnuladoNo.AutoSize = True
        Me.ChkAnuladoNo.Checked = True
        Me.ChkAnuladoNo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkAnuladoNo.Location = New System.Drawing.Point(103, 3)
        Me.ChkAnuladoNo.Name = "ChkAnuladoNo"
        Me.ChkAnuladoNo.Size = New System.Drawing.Size(94, 18)
        Me.ChkAnuladoNo.TabIndex = 433
        Me.ChkAnuladoNo.Text = "No"
        Me.ChkAnuladoNo.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(3, 7)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(134, 16)
        Me.Label13.TabIndex = 420
        Me.Label13.Text = "N° Factura"
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(3, 37)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(134, 16)
        Me.Label19.TabIndex = 429
        Me.Label19.Text = "Monto"
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(431, 67)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(134, 16)
        Me.Label20.TabIndex = 431
        Me.Label20.Text = "Anulado"
        '
        'txtFacturaDesde
        '
        Me.txtFacturaDesde.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFacturaDesde.Location = New System.Drawing.Point(143, 4)
        Me.txtFacturaDesde.Name = "txtFacturaDesde"
        Me.txtFacturaDesde.Size = New System.Drawing.Size(88, 21)
        Me.txtFacturaDesde.TabIndex = 418
        '
        'FHasta
        '
        Me.FHasta.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FHasta.Location = New System.Drawing.Point(571, 34)
        Me.FHasta.Name = "FHasta"
        Me.FHasta.Size = New System.Drawing.Size(280, 21)
        Me.FHasta.TabIndex = 1
        '
        'txtMontoHasta
        '
        Me.txtMontoHasta.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMontoHasta.Location = New System.Drawing.Point(257, 34)
        Me.txtMontoHasta.Name = "txtMontoHasta"
        Me.txtMontoHasta.Size = New System.Drawing.Size(88, 21)
        Me.txtMontoHasta.TabIndex = 428
        '
        'FDesde
        '
        Me.FDesde.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FDesde.Location = New System.Drawing.Point(571, 4)
        Me.FDesde.Name = "FDesde"
        Me.FDesde.Size = New System.Drawing.Size(280, 21)
        Me.FDesde.TabIndex = 0
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(237, 37)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(14, 16)
        Me.Label18.TabIndex = 430
        Me.Label18.Text = "-"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(431, 37)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(134, 16)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Fecha hasta"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(431, 7)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(134, 16)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Fecha desde"
        '
        'txtMontoDesde
        '
        Me.txtMontoDesde.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMontoDesde.Location = New System.Drawing.Point(143, 34)
        Me.txtMontoDesde.Name = "txtMontoDesde"
        Me.txtMontoDesde.Size = New System.Drawing.Size(88, 21)
        Me.txtMontoDesde.TabIndex = 427
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(3, 67)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(134, 16)
        Me.Label17.TabIndex = 422
        Me.Label17.Text = "Facturado"
        '
        'Label29
        '
        Me.Label29.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(237, 7)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(14, 16)
        Me.Label29.TabIndex = 421
        Me.Label29.Text = "-"
        '
        'txtFacturaHasta
        '
        Me.txtFacturaHasta.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFacturaHasta.Location = New System.Drawing.Point(257, 4)
        Me.txtFacturaHasta.Name = "txtFacturaHasta"
        Me.txtFacturaHasta.Size = New System.Drawing.Size(88, 21)
        Me.txtFacturaHasta.TabIndex = 419
        '
        'DG_Ventas
        '
        Me.DG_Ventas.AllowUserToAddRows = False
        Me.DG_Ventas.AllowUserToDeleteRows = False
        Me.DG_Ventas.AllowUserToResizeColumns = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DG_Ventas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DG_Ventas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_Ventas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_Venta, Me.NumeroVenta, Me.TipoVenta, Me.FormaPago, Me.Empleado, Me.Cliente, Me.MontoTotal, Me.Fecha, Me.Anulado, Me.TipoFactura, Me.NumFactura})
        Me.DG_Ventas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DG_Ventas.Location = New System.Drawing.Point(10, 200)
        Me.DG_Ventas.MultiSelect = False
        Me.DG_Ventas.Name = "DG_Ventas"
        Me.DG_Ventas.ReadOnly = True
        Me.DG_Ventas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DG_Ventas.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DG_Ventas.RowTemplate.Height = 30
        Me.DG_Ventas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Ventas.Size = New System.Drawing.Size(860, 362)
        Me.DG_Ventas.TabIndex = 0
        '
        'id_Venta
        '
        Me.id_Venta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.id_Venta.DataPropertyName = "id_Venta"
        Me.id_Venta.HeaderText = "id_Venta"
        Me.id_Venta.MaxInputLength = 10
        Me.id_Venta.Name = "id_Venta"
        Me.id_Venta.ReadOnly = True
        Me.id_Venta.Visible = False
        '
        'NumeroVenta
        '
        Me.NumeroVenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.NumeroVenta.DataPropertyName = "NumeroVenta"
        Me.NumeroVenta.HeaderText = "N° Venta"
        Me.NumeroVenta.Name = "NumeroVenta"
        Me.NumeroVenta.ReadOnly = True
        Me.NumeroVenta.Width = 5
        '
        'TipoVenta
        '
        Me.TipoVenta.DataPropertyName = "TipoVenta"
        Me.TipoVenta.HeaderText = "Tipo"
        Me.TipoVenta.Name = "TipoVenta"
        Me.TipoVenta.ReadOnly = True
        Me.TipoVenta.Width = 80
        '
        'FormaPago
        '
        Me.FormaPago.DataPropertyName = "FormaPago"
        Me.FormaPago.HeaderText = "Forma Pago"
        Me.FormaPago.Name = "FormaPago"
        Me.FormaPago.ReadOnly = True
        '
        'Empleado
        '
        Me.Empleado.DataPropertyName = "Empleado"
        Me.Empleado.FillWeight = 146.539!
        Me.Empleado.HeaderText = "Empleado"
        Me.Empleado.Name = "Empleado"
        Me.Empleado.ReadOnly = True
        Me.Empleado.Width = 215
        '
        'Cliente
        '
        Me.Cliente.DataPropertyName = "Cliente"
        Me.Cliente.FillWeight = 115.79!
        Me.Cliente.HeaderText = "Cliente"
        Me.Cliente.Name = "Cliente"
        Me.Cliente.ReadOnly = True
        Me.Cliente.Width = 170
        '
        'MontoTotal
        '
        Me.MontoTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MontoTotal.DataPropertyName = "MontoTotal"
        Me.MontoTotal.FillWeight = 128.0473!
        Me.MontoTotal.HeaderText = "Monto Total"
        Me.MontoTotal.Name = "MontoTotal"
        Me.MontoTotal.ReadOnly = True
        Me.MontoTotal.Width = 118
        '
        'Fecha
        '
        Me.Fecha.DataPropertyName = "Fecha"
        Me.Fecha.FillWeight = 116.8831!
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Width = 150
        '
        'Anulado
        '
        Me.Anulado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Anulado.DataPropertyName = "Anulado"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Anulado.DefaultCellStyle = DataGridViewCellStyle2
        Me.Anulado.FillWeight = 55.0!
        Me.Anulado.HeaderText = "Anulado"
        Me.Anulado.MaxInputLength = 10
        Me.Anulado.Name = "Anulado"
        Me.Anulado.ReadOnly = True
        Me.Anulado.Width = 93
        '
        'TipoFactura
        '
        Me.TipoFactura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TipoFactura.DataPropertyName = "TipoRecibo"
        Me.TipoFactura.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.TipoFactura.HeaderText = "Facturado"
        Me.TipoFactura.Name = "TipoFactura"
        Me.TipoFactura.ReadOnly = True
        Me.TipoFactura.Width = 88
        '
        'NumFactura
        '
        Me.NumFactura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NumFactura.DataPropertyName = "NumeroFactura"
        Me.NumFactura.HeaderText = "N° Factura"
        Me.NumFactura.Name = "NumFactura"
        Me.NumFactura.ReadOnly = True
        Me.NumFactura.Width = 109
        '
        'TbDetalle
        '
        Me.TbDetalle.Controls.Add(Me.lblcontenedor)
        Me.TbDetalle.Location = New System.Drawing.Point(4, 29)
        Me.TbDetalle.Name = "TbDetalle"
        Me.TbDetalle.Size = New System.Drawing.Size(876, 579)
        Me.TbDetalle.TabIndex = 2
        Me.TbDetalle.Text = "Detalle de la Venta"
        Me.TbDetalle.UseVisualStyleBackColor = True
        '
        'lblcontenedor
        '
        Me.lblcontenedor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblcontenedor.Controls.Add(Me.TableLayoutPanel5)
        Me.lblcontenedor.Controls.Add(Me.TableLayoutPanel1)
        Me.lblcontenedor.Controls.Add(Me.PanelTotalMinoristaSenia)
        Me.lblcontenedor.Controls.Add(Me.PanelTotalMayorista)
        Me.lblcontenedor.Controls.Add(Me.BtnEmitirFactura)
        Me.lblcontenedor.Controls.Add(Me.BtnFactura)
        Me.lblcontenedor.Controls.Add(Me.lblFacturado)
        Me.lblcontenedor.Controls.Add(Me.label8)
        Me.lblcontenedor.Controls.Add(Me.lblCantidad)
        Me.lblcontenedor.Controls.Add(Me.lblPago)
        Me.lblcontenedor.Controls.Add(Me.Label1)
        Me.lblcontenedor.Controls.Add(Me.DG_Productos)
        Me.lblcontenedor.Controls.Add(Me.Label2)
        Me.lblcontenedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcontenedor.Location = New System.Drawing.Point(10, 6)
        Me.lblcontenedor.Name = "lblcontenedor"
        Me.lblcontenedor.Size = New System.Drawing.Size(860, 565)
        Me.lblcontenedor.TabIndex = 0
        Me.lblcontenedor.TabStop = False
        Me.lblcontenedor.Text = "Información de la venta realizada."
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.lblAnulado, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.Gb_Anulado, 1, 0)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(302, 331)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 213.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(552, 213)
        Me.TableLayoutPanel5.TabIndex = 73
        '
        'lblAnulado
        '
        Me.lblAnulado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblAnulado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnulado.ForeColor = System.Drawing.Color.Red
        Me.lblAnulado.Location = New System.Drawing.Point(3, 0)
        Me.lblAnulado.Name = "lblAnulado"
        Me.lblAnulado.Size = New System.Drawing.Size(270, 213)
        Me.lblAnulado.TabIndex = 28
        Me.lblAnulado.Text = "VENTA ANULADA."
        Me.lblAnulado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Gb_Anulado
        '
        Me.Gb_Anulado.Controls.Add(Me.btnReporteVenta)
        Me.Gb_Anulado.Controls.Add(Me.txtDescripcionAnular)
        Me.Gb_Anulado.Controls.Add(Me.BtnAnular)
        Me.Gb_Anulado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Gb_Anulado.Location = New System.Drawing.Point(279, 3)
        Me.Gb_Anulado.Name = "Gb_Anulado"
        Me.Gb_Anulado.Size = New System.Drawing.Size(270, 207)
        Me.Gb_Anulado.TabIndex = 16
        Me.Gb_Anulado.TabStop = False
        Me.Gb_Anulado.Text = "Anular Venta - Motivo"
        '
        'btnReporteVenta
        '
        Me.btnReporteVenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReporteVenta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReporteVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReporteVenta.Image = Global.SistemaCinderella.My.Resources.Recursos.icono_imprimir
        Me.btnReporteVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReporteVenta.Location = New System.Drawing.Point(9, 174)
        Me.btnReporteVenta.Name = "btnReporteVenta"
        Me.btnReporteVenta.Size = New System.Drawing.Size(90, 27)
        Me.btnReporteVenta.TabIndex = 16
        Me.btnReporteVenta.Text = "Imprimir"
        Me.btnReporteVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolVentas.SetToolTip(Me.btnReporteVenta, "Anular venta")
        Me.btnReporteVenta.UseVisualStyleBackColor = True
        '
        'txtDescripcionAnular
        '
        Me.txtDescripcionAnular.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescripcionAnular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionAnular.Location = New System.Drawing.Point(9, 21)
        Me.txtDescripcionAnular.Multiline = True
        Me.txtDescripcionAnular.Name = "txtDescripcionAnular"
        Me.txtDescripcionAnular.Size = New System.Drawing.Size(255, 147)
        Me.txtDescripcionAnular.TabIndex = 15
        '
        'BtnAnular
        '
        Me.BtnAnular.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAnular.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAnular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAnular.Image = Global.SistemaCinderella.My.Resources.Recursos.Desconectado
        Me.BtnAnular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAnular.Location = New System.Drawing.Point(186, 173)
        Me.BtnAnular.Name = "BtnAnular"
        Me.BtnAnular.Size = New System.Drawing.Size(78, 27)
        Me.BtnAnular.TabIndex = 14
        Me.BtnAnular.Text = "Anular"
        Me.BtnAnular.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolVentas.SetToolTip(Me.BtnAnular, "Anular venta")
        Me.BtnAnular.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 8
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblPorcentajeFacturacion, 7, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label21, 6, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblSucursal, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblEncargado, 5, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label16, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblFecha, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblCliente, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblVenta, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblVendedor, 3, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(6, 27)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(848, 60)
        Me.TableLayoutPanel1.TabIndex = 72
        '
        'lblPorcentajeFacturacion
        '
        Me.lblPorcentajeFacturacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPorcentajeFacturacion.AutoSize = True
        Me.lblPorcentajeFacturacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPorcentajeFacturacion.Location = New System.Drawing.Point(749, 7)
        Me.lblPorcentajeFacturacion.Name = "lblPorcentajeFacturacion"
        Me.lblPorcentajeFacturacion.Size = New System.Drawing.Size(96, 15)
        Me.lblPorcentajeFacturacion.TabIndex = 70
        Me.lblPorcentajeFacturacion.Text = "- - - - - "
        '
        'Label21
        '
        Me.Label21.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label21.Location = New System.Drawing.Point(639, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(104, 30)
        Me.Label21.TabIndex = 69
        Me.Label21.Text = "Porcentaje Facturación :"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Sucursal :"
        '
        'lblSucursal
        '
        Me.lblSucursal.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSucursal.AutoSize = True
        Me.lblSucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSucursal.Location = New System.Drawing.Point(113, 7)
        Me.lblSucursal.Name = "lblSucursal"
        Me.lblSucursal.Size = New System.Drawing.Size(96, 15)
        Me.lblSucursal.TabIndex = 18
        Me.lblSucursal.Text = "- - - - - "
        '
        'lblEncargado
        '
        Me.lblEncargado.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEncargado.AutoSize = True
        Me.lblEncargado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEncargado.Location = New System.Drawing.Point(537, 37)
        Me.lblEncargado.Name = "lblEncargado"
        Me.lblEncargado.Size = New System.Drawing.Size(96, 15)
        Me.lblEncargado.TabIndex = 36
        Me.lblEncargado.Text = "- - - - - "
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Fecha :"
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(427, 37)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(104, 15)
        Me.Label16.TabIndex = 35
        Me.Label16.Text = "Encargado :"
        '
        'lblFecha
        '
        Me.lblFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(113, 37)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(96, 15)
        Me.lblFecha.TabIndex = 17
        Me.lblFecha.Text = "- - - - - "
        '
        'lblCliente
        '
        Me.lblCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.Location = New System.Drawing.Point(537, 7)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(96, 15)
        Me.lblCliente.TabIndex = 27
        Me.lblCliente.Text = "- - - - - "
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(215, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tipo de Venta :"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(215, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Vendedor :"
        '
        'lblVenta
        '
        Me.lblVenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVenta.AutoSize = True
        Me.lblVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVenta.Location = New System.Drawing.Point(325, 7)
        Me.lblVenta.Name = "lblVenta"
        Me.lblVenta.Size = New System.Drawing.Size(96, 15)
        Me.lblVenta.TabIndex = 20
        Me.lblVenta.Text = "- - - - - "
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(427, 7)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 15)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Cliente :"
        '
        'lblVendedor
        '
        Me.lblVendedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVendedor.AutoSize = True
        Me.lblVendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVendedor.Location = New System.Drawing.Point(325, 37)
        Me.lblVendedor.Name = "lblVendedor"
        Me.lblVendedor.Size = New System.Drawing.Size(96, 15)
        Me.lblVendedor.TabIndex = 19
        Me.lblVendedor.Text = "- - - - - "
        '
        'PanelTotalMinoristaSenia
        '
        Me.PanelTotalMinoristaSenia.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelTotalMinoristaSenia.Controls.Add(Me.Label7)
        Me.PanelTotalMinoristaSenia.Controls.Add(Me.lblCostoFinancieroMinorista)
        Me.PanelTotalMinoristaSenia.Controls.Add(Me.lblPendienteAbonarMinorista)
        Me.PanelTotalMinoristaSenia.Controls.Add(Me.lblPendienteAbonarMinoristaDescripcion)
        Me.PanelTotalMinoristaSenia.Controls.Add(Me.lblSeniaMinorista)
        Me.PanelTotalMinoristaSenia.Controls.Add(Me.lblSeniaMinoristaDescripcion)
        Me.PanelTotalMinoristaSenia.Controls.Add(Me.Label14)
        Me.PanelTotalMinoristaSenia.Controls.Add(Me.lblMontoMinoristaDescripcion)
        Me.PanelTotalMinoristaSenia.Controls.Add(Me.lblMontoMinorista)
        Me.PanelTotalMinoristaSenia.Controls.Add(Me.lblDescuentoMinorista)
        Me.PanelTotalMinoristaSenia.Controls.Add(Me.Label15)
        Me.PanelTotalMinoristaSenia.Controls.Add(Me.lblSubtotalMinorista)
        Me.PanelTotalMinoristaSenia.Location = New System.Drawing.Point(4, 403)
        Me.PanelTotalMinoristaSenia.Name = "PanelTotalMinoristaSenia"
        Me.PanelTotalMinoristaSenia.Size = New System.Drawing.Size(258, 141)
        Me.PanelTotalMinoristaSenia.TabIndex = 40
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 15)
        Me.Label7.TabIndex = 73
        Me.Label7.Text = "Costo Financiero :"
        '
        'lblCostoFinancieroMinorista
        '
        Me.lblCostoFinancieroMinorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCostoFinancieroMinorista.AutoSize = True
        Me.lblCostoFinancieroMinorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostoFinancieroMinorista.Location = New System.Drawing.Point(193, 52)
        Me.lblCostoFinancieroMinorista.Name = "lblCostoFinancieroMinorista"
        Me.lblCostoFinancieroMinorista.Size = New System.Drawing.Size(42, 15)
        Me.lblCostoFinancieroMinorista.TabIndex = 74
        Me.lblCostoFinancieroMinorista.Text = "- - - - - "
        '
        'lblPendienteAbonarMinorista
        '
        Me.lblPendienteAbonarMinorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblPendienteAbonarMinorista.AutoSize = True
        Me.lblPendienteAbonarMinorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPendienteAbonarMinorista.Location = New System.Drawing.Point(193, 119)
        Me.lblPendienteAbonarMinorista.Name = "lblPendienteAbonarMinorista"
        Me.lblPendienteAbonarMinorista.Size = New System.Drawing.Size(42, 15)
        Me.lblPendienteAbonarMinorista.TabIndex = 52
        Me.lblPendienteAbonarMinorista.Text = "- - - - - "
        '
        'lblPendienteAbonarMinoristaDescripcion
        '
        Me.lblPendienteAbonarMinoristaDescripcion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblPendienteAbonarMinoristaDescripcion.AutoSize = True
        Me.lblPendienteAbonarMinoristaDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblPendienteAbonarMinoristaDescripcion.Location = New System.Drawing.Point(3, 119)
        Me.lblPendienteAbonarMinoristaDescripcion.Name = "lblPendienteAbonarMinoristaDescripcion"
        Me.lblPendienteAbonarMinoristaDescripcion.Size = New System.Drawing.Size(141, 15)
        Me.lblPendienteAbonarMinoristaDescripcion.TabIndex = 51
        Me.lblPendienteAbonarMinoristaDescripcion.Text = "Pendiente a Abonar :"
        '
        'lblSeniaMinorista
        '
        Me.lblSeniaMinorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSeniaMinorista.AutoSize = True
        Me.lblSeniaMinorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeniaMinorista.Location = New System.Drawing.Point(193, 97)
        Me.lblSeniaMinorista.Name = "lblSeniaMinorista"
        Me.lblSeniaMinorista.Size = New System.Drawing.Size(42, 15)
        Me.lblSeniaMinorista.TabIndex = 50
        Me.lblSeniaMinorista.Text = "- - - - - "
        '
        'lblSeniaMinoristaDescripcion
        '
        Me.lblSeniaMinoristaDescripcion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSeniaMinoristaDescripcion.AutoSize = True
        Me.lblSeniaMinoristaDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSeniaMinoristaDescripcion.Location = New System.Drawing.Point(3, 97)
        Me.lblSeniaMinoristaDescripcion.Name = "lblSeniaMinoristaDescripcion"
        Me.lblSeniaMinoristaDescripcion.Size = New System.Drawing.Size(48, 15)
        Me.lblSeniaMinoristaDescripcion.TabIndex = 49
        Me.lblSeniaMinoristaDescripcion.Text = "Seña :"
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(3, 30)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(83, 15)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "Descuento :"
        '
        'lblMontoMinoristaDescripcion
        '
        Me.lblMontoMinoristaDescripcion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblMontoMinoristaDescripcion.AutoSize = True
        Me.lblMontoMinoristaDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontoMinoristaDescripcion.Location = New System.Drawing.Point(3, 75)
        Me.lblMontoMinoristaDescripcion.Name = "lblMontoMinoristaDescripcion"
        Me.lblMontoMinoristaDescripcion.Size = New System.Drawing.Size(87, 15)
        Me.lblMontoMinoristaDescripcion.TabIndex = 13
        Me.lblMontoMinoristaDescripcion.Text = "Monto total :"
        '
        'lblMontoMinorista
        '
        Me.lblMontoMinorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblMontoMinorista.AutoSize = True
        Me.lblMontoMinorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontoMinorista.Location = New System.Drawing.Point(193, 75)
        Me.lblMontoMinorista.Name = "lblMontoMinorista"
        Me.lblMontoMinorista.Size = New System.Drawing.Size(42, 15)
        Me.lblMontoMinorista.TabIndex = 23
        Me.lblMontoMinorista.Text = "- - - - - "
        '
        'lblDescuentoMinorista
        '
        Me.lblDescuentoMinorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDescuentoMinorista.AutoSize = True
        Me.lblDescuentoMinorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescuentoMinorista.Location = New System.Drawing.Point(193, 30)
        Me.lblDescuentoMinorista.Name = "lblDescuentoMinorista"
        Me.lblDescuentoMinorista.Size = New System.Drawing.Size(42, 15)
        Me.lblDescuentoMinorista.TabIndex = 32
        Me.lblDescuentoMinorista.Text = "- - - - - "
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(3, 9)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(68, 15)
        Me.Label15.TabIndex = 33
        Me.Label15.Text = "Subtotal :"
        '
        'lblSubtotalMinorista
        '
        Me.lblSubtotalMinorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSubtotalMinorista.AutoSize = True
        Me.lblSubtotalMinorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtotalMinorista.Location = New System.Drawing.Point(193, 9)
        Me.lblSubtotalMinorista.Name = "lblSubtotalMinorista"
        Me.lblSubtotalMinorista.Size = New System.Drawing.Size(42, 15)
        Me.lblSubtotalMinorista.TabIndex = 34
        Me.lblSubtotalMinorista.Text = "- - - - - "
        '
        'PanelTotalMayorista
        '
        Me.PanelTotalMayorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelTotalMayorista.Controls.Add(Me.lblDescuentoMayorista)
        Me.PanelTotalMayorista.Controls.Add(Me.lblPendienteAbonarMayorista)
        Me.PanelTotalMayorista.Controls.Add(Me.Label23)
        Me.PanelTotalMayorista.Controls.Add(Me.lblPendienteAbonarMayoristaDescripcion)
        Me.PanelTotalMayorista.Controls.Add(Me.lblSeniaMayorista)
        Me.PanelTotalMayorista.Controls.Add(Me.lblSeniaMayoristaDescripcion)
        Me.PanelTotalMayorista.Controls.Add(Me.lblIVAMayorista)
        Me.PanelTotalMayorista.Controls.Add(Me.Label28)
        Me.PanelTotalMayorista.Controls.Add(Me.lblSubtotalMayorista)
        Me.PanelTotalMayorista.Controls.Add(Me.Label22)
        Me.PanelTotalMayorista.Controls.Add(Me.lblCostoFinancieroMayorista)
        Me.PanelTotalMayorista.Controls.Add(Me.Label24)
        Me.PanelTotalMayorista.Controls.Add(Me.lblMontoMayorista)
        Me.PanelTotalMayorista.Controls.Add(Me.lblMontoMayoristaDescripcion)
        Me.PanelTotalMayorista.Location = New System.Drawing.Point(0, 169)
        Me.PanelTotalMayorista.Name = "PanelTotalMayorista"
        Me.PanelTotalMayorista.Size = New System.Drawing.Size(298, 156)
        Me.PanelTotalMayorista.TabIndex = 39
        '
        'lblDescuentoMayorista
        '
        Me.lblDescuentoMayorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDescuentoMayorista.AutoSize = True
        Me.lblDescuentoMayorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescuentoMayorista.Location = New System.Drawing.Point(193, 3)
        Me.lblDescuentoMayorista.Name = "lblDescuentoMayorista"
        Me.lblDescuentoMayorista.Size = New System.Drawing.Size(42, 15)
        Me.lblDescuentoMayorista.TabIndex = 74
        Me.lblDescuentoMayorista.Text = "- - - - - "
        '
        'lblPendienteAbonarMayorista
        '
        Me.lblPendienteAbonarMayorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblPendienteAbonarMayorista.AutoSize = True
        Me.lblPendienteAbonarMayorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPendienteAbonarMayorista.Location = New System.Drawing.Point(193, 135)
        Me.lblPendienteAbonarMayorista.Name = "lblPendienteAbonarMayorista"
        Me.lblPendienteAbonarMayorista.Size = New System.Drawing.Size(42, 15)
        Me.lblPendienteAbonarMayorista.TabIndex = 56
        Me.lblPendienteAbonarMayorista.Text = "- - - - - "
        '
        'Label23
        '
        Me.Label23.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(3, 3)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(83, 15)
        Me.Label23.TabIndex = 73
        Me.Label23.Text = "Descuento :"
        '
        'lblPendienteAbonarMayoristaDescripcion
        '
        Me.lblPendienteAbonarMayoristaDescripcion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblPendienteAbonarMayoristaDescripcion.AutoSize = True
        Me.lblPendienteAbonarMayoristaDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblPendienteAbonarMayoristaDescripcion.Location = New System.Drawing.Point(3, 135)
        Me.lblPendienteAbonarMayoristaDescripcion.Name = "lblPendienteAbonarMayoristaDescripcion"
        Me.lblPendienteAbonarMayoristaDescripcion.Size = New System.Drawing.Size(141, 15)
        Me.lblPendienteAbonarMayoristaDescripcion.TabIndex = 55
        Me.lblPendienteAbonarMayoristaDescripcion.Text = "Pendiente a Abonar :"
        '
        'lblSeniaMayorista
        '
        Me.lblSeniaMayorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSeniaMayorista.AutoSize = True
        Me.lblSeniaMayorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeniaMayorista.Location = New System.Drawing.Point(193, 113)
        Me.lblSeniaMayorista.Name = "lblSeniaMayorista"
        Me.lblSeniaMayorista.Size = New System.Drawing.Size(42, 15)
        Me.lblSeniaMayorista.TabIndex = 54
        Me.lblSeniaMayorista.Text = "- - - - - "
        '
        'lblSeniaMayoristaDescripcion
        '
        Me.lblSeniaMayoristaDescripcion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSeniaMayoristaDescripcion.AutoSize = True
        Me.lblSeniaMayoristaDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSeniaMayoristaDescripcion.Location = New System.Drawing.Point(3, 113)
        Me.lblSeniaMayoristaDescripcion.Name = "lblSeniaMayoristaDescripcion"
        Me.lblSeniaMayoristaDescripcion.Size = New System.Drawing.Size(48, 15)
        Me.lblSeniaMayoristaDescripcion.TabIndex = 53
        Me.lblSeniaMayoristaDescripcion.Text = "Seña :"
        '
        'lblIVAMayorista
        '
        Me.lblIVAMayorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblIVAMayorista.AutoSize = True
        Me.lblIVAMayorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIVAMayorista.Location = New System.Drawing.Point(193, 69)
        Me.lblIVAMayorista.Name = "lblIVAMayorista"
        Me.lblIVAMayorista.Size = New System.Drawing.Size(42, 15)
        Me.lblIVAMayorista.TabIndex = 42
        Me.lblIVAMayorista.Text = "- - - - - "
        '
        'Label28
        '
        Me.Label28.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(3, 69)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(67, 15)
        Me.Label28.TabIndex = 41
        Me.Label28.Text = "IVA 21% :"
        '
        'lblSubtotalMayorista
        '
        Me.lblSubtotalMayorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSubtotalMayorista.AutoSize = True
        Me.lblSubtotalMayorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtotalMayorista.Location = New System.Drawing.Point(193, 47)
        Me.lblSubtotalMayorista.Name = "lblSubtotalMayorista"
        Me.lblSubtotalMayorista.Size = New System.Drawing.Size(42, 15)
        Me.lblSubtotalMayorista.TabIndex = 40
        Me.lblSubtotalMayorista.Text = "- - - - - "
        '
        'Label22
        '
        Me.Label22.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(3, 47)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(68, 15)
        Me.Label22.TabIndex = 39
        Me.Label22.Text = "Subtotal :"
        '
        'lblCostoFinancieroMayorista
        '
        Me.lblCostoFinancieroMayorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCostoFinancieroMayorista.AutoSize = True
        Me.lblCostoFinancieroMayorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostoFinancieroMayorista.Location = New System.Drawing.Point(193, 25)
        Me.lblCostoFinancieroMayorista.Name = "lblCostoFinancieroMayorista"
        Me.lblCostoFinancieroMayorista.Size = New System.Drawing.Size(42, 15)
        Me.lblCostoFinancieroMayorista.TabIndex = 38
        Me.lblCostoFinancieroMayorista.Text = "- - - - - "
        '
        'Label24
        '
        Me.Label24.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(3, 25)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(123, 15)
        Me.Label24.TabIndex = 37
        Me.Label24.Text = "Costo Financiero :"
        '
        'lblMontoMayorista
        '
        Me.lblMontoMayorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblMontoMayorista.AutoSize = True
        Me.lblMontoMayorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontoMayorista.Location = New System.Drawing.Point(193, 91)
        Me.lblMontoMayorista.Name = "lblMontoMayorista"
        Me.lblMontoMayorista.Size = New System.Drawing.Size(42, 15)
        Me.lblMontoMayorista.TabIndex = 36
        Me.lblMontoMayorista.Text = "- - - - - "
        '
        'lblMontoMayoristaDescripcion
        '
        Me.lblMontoMayoristaDescripcion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblMontoMayoristaDescripcion.AutoSize = True
        Me.lblMontoMayoristaDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontoMayoristaDescripcion.Location = New System.Drawing.Point(3, 91)
        Me.lblMontoMayoristaDescripcion.Name = "lblMontoMayoristaDescripcion"
        Me.lblMontoMayoristaDescripcion.Size = New System.Drawing.Size(87, 15)
        Me.lblMontoMayoristaDescripcion.TabIndex = 35
        Me.lblMontoMayoristaDescripcion.Text = "Monto total :"
        '
        'BtnEmitirFactura
        '
        Me.BtnEmitirFactura.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnEmitirFactura.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEmitirFactura.FlatAppearance.BorderSize = 0
        Me.BtnEmitirFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEmitirFactura.Image = Global.SistemaCinderella.My.Resources.Recursos.TicketPequeño
        Me.BtnEmitirFactura.Location = New System.Drawing.Point(268, 355)
        Me.BtnEmitirFactura.Name = "BtnEmitirFactura"
        Me.BtnEmitirFactura.Size = New System.Drawing.Size(18, 18)
        Me.BtnEmitirFactura.TabIndex = 37
        Me.BtnEmitirFactura.Tag = "Ver Detalle"
        Me.ToolVentas.SetToolTip(Me.BtnEmitirFactura, "Generar factura")
        Me.BtnEmitirFactura.UseVisualStyleBackColor = True
        '
        'BtnFactura
        '
        Me.BtnFactura.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnFactura.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFactura.FlatAppearance.BorderSize = 0
        Me.BtnFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFactura.Image = Global.SistemaCinderella.My.Resources.Recursos.Detalle_Pequeno
        Me.BtnFactura.Location = New System.Drawing.Point(244, 355)
        Me.BtnFactura.Name = "BtnFactura"
        Me.BtnFactura.Size = New System.Drawing.Size(18, 18)
        Me.BtnFactura.TabIndex = 30
        Me.BtnFactura.Tag = "Ver Detalle"
        Me.ToolVentas.SetToolTip(Me.BtnFactura, "Ver detalle factura")
        Me.BtnFactura.UseVisualStyleBackColor = True
        '
        'lblFacturado
        '
        Me.lblFacturado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblFacturado.AutoSize = True
        Me.lblFacturado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFacturado.Location = New System.Drawing.Point(196, 361)
        Me.lblFacturado.Name = "lblFacturado"
        Me.lblFacturado.Size = New System.Drawing.Size(42, 15)
        Me.lblFacturado.TabIndex = 25
        Me.lblFacturado.Text = "- - - - - "
        '
        'label8
        '
        Me.label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.Location = New System.Drawing.Point(6, 361)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(79, 15)
        Me.label8.TabIndex = 24
        Me.label8.Text = "Facturado :"
        '
        'lblCantidad
        '
        Me.lblCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad.Location = New System.Drawing.Point(196, 385)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(42, 15)
        Me.lblCantidad.TabIndex = 22
        Me.lblCantidad.Text = "- - - - - "
        '
        'lblPago
        '
        Me.lblPago.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblPago.AutoSize = True
        Me.lblPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPago.Location = New System.Drawing.Point(196, 337)
        Me.lblPago.Name = "lblPago"
        Me.lblPago.Size = New System.Drawing.Size(42, 15)
        Me.lblPago.TabIndex = 21
        Me.lblPago.Text = "- - - - - "
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 385)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 15)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Cant. de productos :"
        '
        'DG_Productos
        '
        Me.DG_Productos.AllowUserToAddRows = False
        Me.DG_Productos.AllowUserToDeleteRows = False
        Me.DG_Productos.AllowUserToResizeRows = False
        Me.DG_Productos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_Productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_Productos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DG_Productos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DG_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Productos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NUMERO, Me.CODIGO, Me.NOMBRE, Me.CANTIDAD, Me.PRECIO, Me.IVA, Me.MONTO, Me.SUBTOTAL, Me.ID})
        Me.DG_Productos.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.DG_Productos.Location = New System.Drawing.Point(6, 93)
        Me.DG_Productos.MultiSelect = False
        Me.DG_Productos.Name = "DG_Productos"
        Me.DG_Productos.ReadOnly = True
        Me.DG_Productos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DG_Productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Productos.Size = New System.Drawing.Size(848, 232)
        Me.DG_Productos.TabIndex = 11
        '
        'NUMERO
        '
        Me.NUMERO.FillWeight = 68.49864!
        Me.NUMERO.HeaderText = "Número"
        Me.NUMERO.Name = "NUMERO"
        Me.NUMERO.ReadOnly = True
        '
        'CODIGO
        '
        Me.CODIGO.FillWeight = 107.5103!
        Me.CODIGO.HeaderText = "Código"
        Me.CODIGO.Name = "CODIGO"
        Me.CODIGO.ReadOnly = True
        '
        'NOMBRE
        '
        Me.NOMBRE.FillWeight = 177.4346!
        Me.NOMBRE.HeaderText = "Nombre"
        Me.NOMBRE.Name = "NOMBRE"
        Me.NOMBRE.ReadOnly = True
        '
        'CANTIDAD
        '
        Me.CANTIDAD.FillWeight = 73.49158!
        Me.CANTIDAD.HeaderText = "Cantidad"
        Me.CANTIDAD.Name = "CANTIDAD"
        Me.CANTIDAD.ReadOnly = True
        '
        'PRECIO
        '
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.PRECIO.DefaultCellStyle = DataGridViewCellStyle4
        Me.PRECIO.FillWeight = 81.69429!
        Me.PRECIO.HeaderText = "Precio"
        Me.PRECIO.Name = "PRECIO"
        Me.PRECIO.ReadOnly = True
        '
        'IVA
        '
        DataGridViewCellStyle5.Format = "C2"
        Me.IVA.DefaultCellStyle = DataGridViewCellStyle5
        Me.IVA.HeaderText = "Iva"
        Me.IVA.Name = "IVA"
        Me.IVA.ReadOnly = True
        '
        'MONTO
        '
        DataGridViewCellStyle6.Format = "C2"
        Me.MONTO.DefaultCellStyle = DataGridViewCellStyle6
        Me.MONTO.HeaderText = "Monto"
        Me.MONTO.Name = "MONTO"
        Me.MONTO.ReadOnly = True
        '
        'SUBTOTAL
        '
        DataGridViewCellStyle7.Format = "C2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.SUBTOTAL.DefaultCellStyle = DataGridViewCellStyle7
        Me.SUBTOTAL.FillWeight = 91.37056!
        Me.SUBTOTAL.HeaderText = "Subtotal"
        Me.SUBTOTAL.Name = "SUBTOTAL"
        Me.SUBTOTAL.ReadOnly = True
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 337)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tipo de Pago :"
        '
        'ToolVentas
        '
        Me.ToolVentas.IsBalloon = True
        Me.ToolVentas.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolVentas.ToolTipTitle = "Ayuda."
        '
        'frmVentasAdministracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 612)
        Me.Controls.Add(Me.TabVentas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmVentasAdministracion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administración de Ventas"
        Me.TabVentas.ResumeLayout(False)
        Me.TbListado.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        CType(Me.DG_Ventas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TbDetalle.ResumeLayout(False)
        Me.lblcontenedor.ResumeLayout(False)
        Me.lblcontenedor.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.Gb_Anulado.ResumeLayout(False)
        Me.Gb_Anulado.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.PanelTotalMinoristaSenia.ResumeLayout(False)
        Me.PanelTotalMinoristaSenia.PerformLayout()
        Me.PanelTotalMayorista.ResumeLayout(False)
        Me.PanelTotalMayorista.PerformLayout()
        CType(Me.DG_Productos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoFacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabVentas As System.Windows.Forms.TabControl
    Friend WithEvents TbListado As System.Windows.Forms.TabPage
    Friend WithEvents DG_Ventas As System.Windows.Forms.DataGridView
    Friend WithEvents TbDetalle As System.Windows.Forms.TabPage
    Friend WithEvents lblcontenedor As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Gb_Anulado As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescripcionAnular As System.Windows.Forms.TextBox
    Friend WithEvents BtnAnular As System.Windows.Forms.Button
    Friend WithEvents lblMontoMinoristaDescripcion As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DG_Productos As System.Windows.Forms.DataGridView
    Friend WithEvents lblPago As System.Windows.Forms.Label
    Friend WithEvents lblMontoMinorista As System.Windows.Forms.Label
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents lblFacturado As System.Windows.Forms.Label
    Friend WithEvents label8 As System.Windows.Forms.Label
    Friend WithEvents lblAnulado As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnFiltrar As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents FHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents FDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnFactura As System.Windows.Forms.Button
    Friend WithEvents lblDescuentoMinorista As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblSubtotalMinorista As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lbl_Msg As System.Windows.Forms.Label
    Friend WithEvents btn_Restablecer As System.Windows.Forms.Button
    Friend WithEvents ToolVentas As System.Windows.Forms.ToolTip
    Friend WithEvents BtnEmitirFactura As System.Windows.Forms.Button
    Friend WithEvents TipoFacturaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtFacturaHasta As System.Windows.Forms.TextBox
    Friend WithEvents txtFacturaDesde As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents ChkMarcaManual As System.Windows.Forms.CheckBox
    Friend WithEvents ChkMarcaSinFacturar As System.Windows.Forms.CheckBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents ChkMarcaElectronica As System.Windows.Forms.CheckBox
    Friend WithEvents ChkMarcaTicket As System.Windows.Forms.CheckBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtMontoHasta As System.Windows.Forms.TextBox
    Friend WithEvents txtMontoDesde As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents ChkAnuladoNo As System.Windows.Forms.CheckBox
    Friend WithEvents ChkAnuladoSi As System.Windows.Forms.CheckBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents PanelTotalMayorista As Panel
    Friend WithEvents lblSubtotalMayorista As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents lblCostoFinancieroMayorista As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents lblMontoMayorista As Label
    Friend WithEvents lblMontoMayoristaDescripcion As Label
    Friend WithEvents lblIVAMayorista As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents PanelTotalMinoristaSenia As Panel
    Friend WithEvents lblPendienteAbonarMinorista As Label
    Friend WithEvents lblPendienteAbonarMinoristaDescripcion As Label
    Friend WithEvents lblSeniaMinorista As Label
    Friend WithEvents lblSeniaMinoristaDescripcion As Label
    Friend WithEvents lblPendienteAbonarMayorista As Label
    Friend WithEvents lblPendienteAbonarMayoristaDescripcion As Label
    Friend WithEvents lblSeniaMayorista As Label
    Friend WithEvents lblSeniaMayoristaDescripcion As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label21 As Label
    Friend WithEvents lblSucursal As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblVenta As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblVendedor As Label
    Friend WithEvents lblEncargado As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents lblCliente As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblPorcentajeFacturacion As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblDescuentoMayorista As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblCostoFinancieroMinorista As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents chkMenor As CheckBox
    Friend WithEvents chkMayor As CheckBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label25 As Label
    Friend WithEvents cmbFormaPago As ComboBox
    Friend WithEvents id_Venta As DataGridViewTextBoxColumn
    Friend WithEvents NumeroVenta As DataGridViewTextBoxColumn
    Friend WithEvents TipoVenta As DataGridViewTextBoxColumn
    Friend WithEvents FormaPago As DataGridViewTextBoxColumn
    Friend WithEvents Empleado As DataGridViewTextBoxColumn
    Friend WithEvents Cliente As DataGridViewTextBoxColumn
    Friend WithEvents MontoTotal As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Anulado As DataGridViewTextBoxColumn
    Friend WithEvents TipoFactura As DataGridViewComboBoxColumn
    Friend WithEvents NumFactura As DataGridViewTextBoxColumn
    Friend WithEvents btnReporteVenta As Button
    Friend WithEvents NUMERO As DataGridViewTextBoxColumn
    Friend WithEvents CODIGO As DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE As DataGridViewTextBoxColumn
    Friend WithEvents CANTIDAD As DataGridViewTextBoxColumn
    Friend WithEvents PRECIO As DataGridViewTextBoxColumn
    Friend WithEvents IVA As DataGridViewTextBoxColumn
    Friend WithEvents MONTO As DataGridViewTextBoxColumn
    Friend WithEvents SUBTOTAL As DataGridViewTextBoxColumn
    Friend WithEvents ID As DataGridViewTextBoxColumn
End Class
