<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClienteMayoristaCuentaCorriente
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClienteMayoristaCuentaCorriente))
        Me.GB_Buscar = New System.Windows.Forms.GroupBox()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.btn_Restablecer = New System.Windows.Forms.Button()
        Me.TableLayoutPanel15 = New System.Windows.Forms.TableLayoutPanel()
        Me.ddlTipo = New System.Windows.Forms.ComboBox()
        Me.txtComprobante = New System.Windows.Forms.TextBox()
        Me.txtPago = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtImporteHasta = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtImporteDesde = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.dtFechaVencimientoDesde = New System.Windows.Forms.DateTimePicker()
        Me.chkFechaVencimiento = New System.Windows.Forms.CheckBox()
        Me.dtFechaVencimientoHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ddlEmpresa = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_id_Cliente = New System.Windows.Forms.TextBox()
        Me.txt_Nombre = New System.Windows.Forms.TextBox()
        Me.txt_RazonSocial = New System.Windows.Forms.TextBox()
        Me.Btn_BuscarCliente = New System.Windows.Forms.Button()
        Me.DGMovimientos = New System.Windows.Forms.DataGridView()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoMovimientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoFacturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PuntoVentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComprobanteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpresaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovimientoCuentaCorrienteClienteMayoristaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Btn_Agregar = New System.Windows.Forms.Button()
        Me.btn_Imprimir = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txt_SaldoActual = New System.Windows.Forms.TextBox()
        Me.lbl_Msg = New System.Windows.Forms.Label()
        Me.GB_Buscar.SuspendLayout()
        Me.TableLayoutPanel15.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DGMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MovimientoCuentaCorrienteClienteMayoristaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GB_Buscar
        '
        Me.GB_Buscar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_Buscar.Controls.Add(Me.btn_Buscar)
        Me.GB_Buscar.Controls.Add(Me.btn_Restablecer)
        Me.GB_Buscar.Controls.Add(Me.TableLayoutPanel15)
        Me.GB_Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Buscar.Location = New System.Drawing.Point(14, 81)
        Me.GB_Buscar.Name = "GB_Buscar"
        Me.GB_Buscar.Size = New System.Drawing.Size(864, 164)
        Me.GB_Buscar.TabIndex = 4
        Me.GB_Buscar.TabStop = False
        Me.GB_Buscar.Text = "Buscar Movimiento"
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Buscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Buscar.Image = Global.SistemaCinderella.My.Resources.Recursos.IconoBuscar32
        Me.btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Buscar.Location = New System.Drawing.Point(758, 118)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(100, 40)
        Me.btn_Buscar.TabIndex = 6
        Me.btn_Buscar.Text = "Buscar"
        Me.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'btn_Restablecer
        '
        Me.btn_Restablecer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Restablecer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Restablecer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Restablecer.Location = New System.Drawing.Point(652, 119)
        Me.btn_Restablecer.Name = "btn_Restablecer"
        Me.btn_Restablecer.Size = New System.Drawing.Size(100, 40)
        Me.btn_Restablecer.TabIndex = 8
        Me.btn_Restablecer.Text = "Restablecer Busqueda"
        Me.btn_Restablecer.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel15
        '
        Me.TableLayoutPanel15.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel15.ColumnCount = 5
        Me.TableLayoutPanel15.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel15.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel15.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel15.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel15.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel15.Controls.Add(Me.ddlTipo, 1, 1)
        Me.TableLayoutPanel15.Controls.Add(Me.txtComprobante, 4, 1)
        Me.TableLayoutPanel15.Controls.Add(Me.txtPago, 1, 2)
        Me.TableLayoutPanel15.Controls.Add(Me.TableLayoutPanel3, 4, 0)
        Me.TableLayoutPanel15.Controls.Add(Me.Label3, 0, 1)
        Me.TableLayoutPanel15.Controls.Add(Me.Label7, 3, 0)
        Me.TableLayoutPanel15.Controls.Add(Me.TableLayoutPanel2, 1, 0)
        Me.TableLayoutPanel15.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel15.Controls.Add(Me.Label9, 3, 2)
        Me.TableLayoutPanel15.Controls.Add(Me.Label4, 3, 1)
        Me.TableLayoutPanel15.Controls.Add(Me.Label5, 0, 2)
        Me.TableLayoutPanel15.Controls.Add(Me.ddlEmpresa, 4, 2)
        Me.TableLayoutPanel15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel15.Location = New System.Drawing.Point(6, 19)
        Me.TableLayoutPanel15.Name = "TableLayoutPanel15"
        Me.TableLayoutPanel15.RowCount = 3
        Me.TableLayoutPanel15.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel15.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel15.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel15.Size = New System.Drawing.Size(852, 94)
        Me.TableLayoutPanel15.TabIndex = 4
        '
        'ddlTipo
        '
        Me.ddlTipo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ddlTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlTipo.FormattingEnabled = True
        Me.ddlTipo.Location = New System.Drawing.Point(133, 33)
        Me.ddlTipo.Name = "ddlTipo"
        Me.ddlTipo.Size = New System.Drawing.Size(265, 23)
        Me.ddlTipo.TabIndex = 424
        '
        'txtComprobante
        '
        Me.txtComprobante.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtComprobante.BackColor = System.Drawing.SystemColors.Window
        Me.txtComprobante.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComprobante.Location = New System.Drawing.Point(584, 34)
        Me.txtComprobante.Name = "txtComprobante"
        Me.txtComprobante.Size = New System.Drawing.Size(265, 21)
        Me.txtComprobante.TabIndex = 10
        '
        'txtPago
        '
        Me.txtPago.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPago.BackColor = System.Drawing.SystemColors.Window
        Me.txtPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPago.Location = New System.Drawing.Point(133, 66)
        Me.txtPago.Name = "txtPago"
        Me.txtPago.Size = New System.Drawing.Size(265, 21)
        Me.txtPago.TabIndex = 9
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.txtImporteHasta, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label29, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.txtImporteDesde, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(584, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(265, 24)
        Me.TableLayoutPanel3.TabIndex = 13
        '
        'txtImporteHasta
        '
        Me.txtImporteHasta.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtImporteHasta.Location = New System.Drawing.Point(145, 3)
        Me.txtImporteHasta.Name = "txtImporteHasta"
        Me.txtImporteHasta.Size = New System.Drawing.Size(117, 21)
        Me.txtImporteHasta.TabIndex = 419
        '
        'Label29
        '
        Me.Label29.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(125, 4)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(14, 16)
        Me.Label29.TabIndex = 420
        Me.Label29.Text = "-"
        '
        'txtImporteDesde
        '
        Me.txtImporteDesde.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtImporteDesde.Location = New System.Drawing.Point(3, 3)
        Me.txtImporteDesde.Name = "txtImporteDesde"
        Me.txtImporteDesde.Size = New System.Drawing.Size(116, 21)
        Me.txtImporteDesde.TabIndex = 418
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 16)
        Me.Label3.TabIndex = 418
        Me.Label3.Text = "Tipo"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(454, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 16)
        Me.Label7.TabIndex = 421
        Me.Label7.Text = "Importe"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.dtFechaVencimientoDesde, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.chkFechaVencimiento, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.dtFechaVencimientoHasta, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label27, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(133, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(265, 24)
        Me.TableLayoutPanel2.TabIndex = 419
        '
        'dtFechaVencimientoDesde
        '
        Me.dtFechaVencimientoDesde.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtFechaVencimientoDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaVencimientoDesde.Location = New System.Drawing.Point(3, 3)
        Me.dtFechaVencimientoDesde.Name = "dtFechaVencimientoDesde"
        Me.dtFechaVencimientoDesde.Size = New System.Drawing.Size(106, 21)
        Me.dtFechaVencimientoDesde.TabIndex = 414
        '
        'chkFechaVencimiento
        '
        Me.chkFechaVencimiento.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkFechaVencimiento.AutoSize = True
        Me.chkFechaVencimiento.Location = New System.Drawing.Point(247, 5)
        Me.chkFechaVencimiento.Name = "chkFechaVencimiento"
        Me.chkFechaVencimiento.Size = New System.Drawing.Size(15, 14)
        Me.chkFechaVencimiento.TabIndex = 416
        Me.chkFechaVencimiento.UseVisualStyleBackColor = True
        '
        'dtFechaVencimientoHasta
        '
        Me.dtFechaVencimientoHasta.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtFechaVencimientoHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaVencimientoHasta.Location = New System.Drawing.Point(135, 3)
        Me.dtFechaVencimientoHasta.Name = "dtFechaVencimientoHasta"
        Me.dtFechaVencimientoHasta.Size = New System.Drawing.Size(106, 21)
        Me.dtFechaVencimientoHasta.TabIndex = 415
        '
        'Label27
        '
        Me.Label27.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(115, 4)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(14, 16)
        Me.Label27.TabIndex = 418
        Me.Label27.Text = "-"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 16)
        Me.Label6.TabIndex = 417
        Me.Label6.Text = "Fecha Vencimiento"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(454, 69)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 16)
        Me.Label9.TabIndex = 422
        Me.Label9.Text = "Empresa"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(454, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 16)
        Me.Label4.TabIndex = 419
        Me.Label4.Text = "Comprobante"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(41, 16)
        Me.Label5.TabIndex = 420
        Me.Label5.Text = "Pago"
        '
        'ddlEmpresa
        '
        Me.ddlEmpresa.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ddlEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlEmpresa.FormattingEnabled = True
        Me.ddlEmpresa.Items.AddRange(New Object() {"Opciones no disponibles"})
        Me.ddlEmpresa.Location = New System.Drawing.Point(584, 65)
        Me.ddlEmpresa.Name = "ddlEmpresa"
        Me.ddlEmpresa.Size = New System.Drawing.Size(265, 23)
        Me.ddlEmpresa.TabIndex = 423
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(14, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(864, 63)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Cliente"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.txt_id_Cliente, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Nombre, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_RazonSocial, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Btn_BuscarCliente, 3, 0)
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(6, 19)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(852, 34)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'txt_id_Cliente
        '
        Me.txt_id_Cliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_id_Cliente.BackColor = System.Drawing.SystemColors.Control
        Me.txt_id_Cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id_Cliente.Location = New System.Drawing.Point(3, 6)
        Me.txt_id_Cliente.Name = "txt_id_Cliente"
        Me.txt_id_Cliente.ReadOnly = True
        Me.txt_id_Cliente.Size = New System.Drawing.Size(156, 21)
        Me.txt_id_Cliente.TabIndex = 4
        '
        'txt_Nombre
        '
        Me.txt_Nombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Nombre.BackColor = System.Drawing.SystemColors.Control
        Me.txt_Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Nombre.Location = New System.Drawing.Point(165, 6)
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.ReadOnly = True
        Me.txt_Nombre.Size = New System.Drawing.Size(318, 21)
        Me.txt_Nombre.TabIndex = 5
        '
        'txt_RazonSocial
        '
        Me.txt_RazonSocial.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_RazonSocial.BackColor = System.Drawing.SystemColors.Control
        Me.txt_RazonSocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_RazonSocial.Location = New System.Drawing.Point(489, 6)
        Me.txt_RazonSocial.Name = "txt_RazonSocial"
        Me.txt_RazonSocial.ReadOnly = True
        Me.txt_RazonSocial.Size = New System.Drawing.Size(318, 21)
        Me.txt_RazonSocial.TabIndex = 7
        '
        'Btn_BuscarCliente
        '
        Me.Btn_BuscarCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_BuscarCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_BuscarCliente.FlatAppearance.BorderSize = 0
        Me.Btn_BuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_BuscarCliente.Image = Global.SistemaCinderella.My.Resources.Recursos.Clientes_32
        Me.Btn_BuscarCliente.Location = New System.Drawing.Point(820, 3)
        Me.Btn_BuscarCliente.Name = "Btn_BuscarCliente"
        Me.Btn_BuscarCliente.Size = New System.Drawing.Size(29, 28)
        Me.Btn_BuscarCliente.TabIndex = 6
        Me.Btn_BuscarCliente.UseVisualStyleBackColor = True
        '
        'DGMovimientos
        '
        Me.DGMovimientos.AllowUserToAddRows = False
        Me.DGMovimientos.AllowUserToDeleteRows = False
        Me.DGMovimientos.AllowUserToResizeColumns = False
        Me.DGMovimientos.AllowUserToResizeRows = False
        Me.DGMovimientos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGMovimientos.AutoGenerateColumns = False
        Me.DGMovimientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGMovimientos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FechaDataGridViewTextBoxColumn, Me.TipoMovimientoDataGridViewTextBoxColumn, Me.TipoFacturaDataGridViewTextBoxColumn, Me.PuntoVentaDataGridViewTextBoxColumn, Me.ComprobanteDataGridViewTextBoxColumn, Me.Pago, Me.MontoDataGridViewTextBoxColumn, Me.SaldoGridViewTextBoxColumn, Me.EmpresaDataGridViewTextBoxColumn})
        Me.DGMovimientos.DataSource = Me.MovimientoCuentaCorrienteClienteMayoristaBindingSource
        Me.DGMovimientos.Location = New System.Drawing.Point(12, 251)
        Me.DGMovimientos.MultiSelect = False
        Me.DGMovimientos.Name = "DGMovimientos"
        Me.DGMovimientos.ReadOnly = True
        Me.DGMovimientos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DGMovimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGMovimientos.Size = New System.Drawing.Size(864, 445)
        Me.DGMovimientos.TabIndex = 6
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TipoMovimientoDataGridViewTextBoxColumn
        '
        Me.TipoMovimientoDataGridViewTextBoxColumn.DataPropertyName = "TipoMovimiento"
        Me.TipoMovimientoDataGridViewTextBoxColumn.HeaderText = "TipoMovimiento"
        Me.TipoMovimientoDataGridViewTextBoxColumn.Name = "TipoMovimientoDataGridViewTextBoxColumn"
        Me.TipoMovimientoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TipoFacturaDataGridViewTextBoxColumn
        '
        Me.TipoFacturaDataGridViewTextBoxColumn.DataPropertyName = "TipoFactura"
        Me.TipoFacturaDataGridViewTextBoxColumn.HeaderText = "TipoFactura"
        Me.TipoFacturaDataGridViewTextBoxColumn.Name = "TipoFacturaDataGridViewTextBoxColumn"
        Me.TipoFacturaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PuntoVentaDataGridViewTextBoxColumn
        '
        Me.PuntoVentaDataGridViewTextBoxColumn.DataPropertyName = "PuntoVenta"
        DataGridViewCellStyle1.Format = "D3"
        Me.PuntoVentaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.PuntoVentaDataGridViewTextBoxColumn.HeaderText = "PuntoVenta"
        Me.PuntoVentaDataGridViewTextBoxColumn.Name = "PuntoVentaDataGridViewTextBoxColumn"
        Me.PuntoVentaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ComprobanteDataGridViewTextBoxColumn
        '
        Me.ComprobanteDataGridViewTextBoxColumn.DataPropertyName = "Comprobante"
        DataGridViewCellStyle2.Format = "D9"
        Me.ComprobanteDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.ComprobanteDataGridViewTextBoxColumn.HeaderText = "Comprobante"
        Me.ComprobanteDataGridViewTextBoxColumn.Name = "ComprobanteDataGridViewTextBoxColumn"
        Me.ComprobanteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Pago
        '
        Me.Pago.DataPropertyName = "Pago"
        Me.Pago.HeaderText = "Pago"
        Me.Pago.Name = "Pago"
        Me.Pago.ReadOnly = True
        '
        'MontoDataGridViewTextBoxColumn
        '
        Me.MontoDataGridViewTextBoxColumn.DataPropertyName = "Monto"
        DataGridViewCellStyle3.Format = "C2"
        Me.MontoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.MontoDataGridViewTextBoxColumn.HeaderText = "Monto"
        Me.MontoDataGridViewTextBoxColumn.Name = "MontoDataGridViewTextBoxColumn"
        Me.MontoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SaldoGridViewTextBoxColumn
        '
        Me.SaldoGridViewTextBoxColumn.DataPropertyName = "Saldo"
        DataGridViewCellStyle4.Format = "C2"
        Me.SaldoGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.SaldoGridViewTextBoxColumn.HeaderText = "Saldo"
        Me.SaldoGridViewTextBoxColumn.Name = "SaldoGridViewTextBoxColumn"
        Me.SaldoGridViewTextBoxColumn.ReadOnly = True
        '
        'EmpresaDataGridViewTextBoxColumn
        '
        Me.EmpresaDataGridViewTextBoxColumn.DataPropertyName = "Empresa"
        Me.EmpresaDataGridViewTextBoxColumn.HeaderText = "Empresa"
        Me.EmpresaDataGridViewTextBoxColumn.Name = "EmpresaDataGridViewTextBoxColumn"
        Me.EmpresaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MovimientoCuentaCorrienteClienteMayoristaBindingSource
        '
        Me.MovimientoCuentaCorrienteClienteMayoristaBindingSource.DataSource = GetType(Entidades.MovimientoCuentaCorrienteClienteMayorista)
        '
        'Btn_Agregar
        '
        Me.Btn_Agregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Agregar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Agregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Agregar.Image = Global.SistemaCinderella.My.Resources.Recursos.Pagar_48
        Me.Btn_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Agregar.Location = New System.Drawing.Point(778, 702)
        Me.Btn_Agregar.Name = "Btn_Agregar"
        Me.Btn_Agregar.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Agregar.TabIndex = 27
        Me.Btn_Agregar.Text = "Pago"
        Me.Btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Agregar.UseVisualStyleBackColor = False
        '
        'btn_Imprimir
        '
        Me.btn_Imprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Imprimir.BackColor = System.Drawing.Color.Transparent
        Me.btn_Imprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Imprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Imprimir.Image = Global.SistemaCinderella.My.Resources.Recursos.icono_imprimir
        Me.btn_Imprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Imprimir.Location = New System.Drawing.Point(672, 702)
        Me.btn_Imprimir.Name = "btn_Imprimir"
        Me.btn_Imprimir.Size = New System.Drawing.Size(100, 40)
        Me.btn_Imprimir.TabIndex = 28
        Me.btn_Imprimir.Text = "Imprimir"
        Me.btn_Imprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Imprimir.UseVisualStyleBackColor = False
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(8, 710)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(166, 22)
        Me.Label19.TabIndex = 35
        Me.Label19.Text = "SALDO ACTUAL:"
        '
        'txt_SaldoActual
        '
        Me.txt_SaldoActual.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_SaldoActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SaldoActual.Location = New System.Drawing.Point(201, 706)
        Me.txt_SaldoActual.Name = "txt_SaldoActual"
        Me.txt_SaldoActual.ReadOnly = True
        Me.txt_SaldoActual.Size = New System.Drawing.Size(179, 29)
        Me.txt_SaldoActual.TabIndex = 34
        Me.txt_SaldoActual.Text = "0,00"
        Me.txt_SaldoActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl_Msg
        '
        Me.lbl_Msg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Msg.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lbl_Msg.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Msg.Location = New System.Drawing.Point(209, 461)
        Me.lbl_Msg.Name = "lbl_Msg"
        Me.lbl_Msg.Size = New System.Drawing.Size(470, 25)
        Me.lbl_Msg.TabIndex = 404
        Me.lbl_Msg.Text = "No se han encontrado movimientos en la cuenta"
        Me.lbl_Msg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_Msg.Visible = False
        '
        'frmClienteMayoristaCuentaCorriente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 754)
        Me.Controls.Add(Me.lbl_Msg)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txt_SaldoActual)
        Me.Controls.Add(Me.btn_Imprimir)
        Me.Controls.Add(Me.Btn_Agregar)
        Me.Controls.Add(Me.DGMovimientos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GB_Buscar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmClienteMayoristaCuentaCorriente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administración de Cuenta Corriente"
        Me.GB_Buscar.ResumeLayout(False)
        Me.TableLayoutPanel15.ResumeLayout(False)
        Me.TableLayoutPanel15.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.DGMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MovimientoCuentaCorrienteClienteMayoristaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GB_Buscar As GroupBox
    Friend WithEvents btn_Buscar As Button
    Friend WithEvents btn_Restablecer As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents txt_id_Cliente As TextBox
    Friend WithEvents txt_Nombre As TextBox
    Friend WithEvents txt_RazonSocial As TextBox
    Friend WithEvents TableLayoutPanel15 As TableLayoutPanel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents dtFechaVencimientoHasta As DateTimePicker
    Friend WithEvents chkFechaVencimiento As CheckBox
    Friend WithEvents dtFechaVencimientoDesde As DateTimePicker
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label9 As Label
    Friend WithEvents txtImporteHasta As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents txtImporteDesde As TextBox
    Friend WithEvents DGMovimientos As DataGridView
    Friend WithEvents Btn_BuscarCliente As Button
    Friend WithEvents Btn_Agregar As Button
    Friend WithEvents btn_Imprimir As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents txt_SaldoActual As TextBox
    Friend WithEvents ddlTipo As ComboBox
    Friend WithEvents txtComprobante As TextBox
    Friend WithEvents txtPago As TextBox
    Friend WithEvents ddlEmpresa As ComboBox
    Friend WithEvents MovimientoCuentaCorrienteClienteMayoristaBindingSource As BindingSource
    Friend WithEvents lbl_Msg As Label
    Friend WithEvents PagoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Saldo As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoMovimientoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoFacturaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PuntoVentaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ComprobanteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Pago As DataGridViewTextBoxColumn
    Friend WithEvents MontoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SaldoGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmpresaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
