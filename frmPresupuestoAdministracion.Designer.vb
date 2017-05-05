<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPresupuestoAdministracion
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPresupuestoAdministracion))
        Me.lbl_Msg = New System.Windows.Forms.Label()
        Me.dgPresupuesto = New System.Windows.Forms.DataGridView()
        Me.IdPresupuestoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RazonSocialClienteMayoristaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnuladoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Imprimir = New System.Windows.Forms.DataGridViewImageColumn()
        Me.PresupuestoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtPresupuestoHasta = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtPresupuestoDesde = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtMontoHasta = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMontoDesde = New System.Windows.Forms.TextBox()
        Me.FDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.FHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.btn_Restablecer = New System.Windows.Forms.Button()
        Me.BtnFiltrar = New System.Windows.Forms.Button()
        Me.TabAdministracionPresupuesto = New System.Windows.Forms.TabControl()
        Me.TabPresupuesto = New System.Windows.Forms.TabPage()
        Me.TabDetalle = New System.Windows.Forms.TabPage()
        Me.lblcontenedor = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblPago = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.lblDescuento = New System.Windows.Forms.Label()
        Me.lblMonto = New System.Windows.Forms.Label()
        Me.lblMontoMayoristaDescripcion = New System.Windows.Forms.Label()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblSucursal = New System.Windows.Forms.Label()
        Me.lblEncargado = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblVenta = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblVendedor = New System.Windows.Forms.Label()
        Me.lblAnulado = New System.Windows.Forms.Label()
        Me.Gb_Anulado = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDescripcionAnular = New System.Windows.Forms.TextBox()
        Me.BtnAnular = New System.Windows.Forms.Button()
        Me.dgPresupuestoDetalle = New System.Windows.Forms.DataGridView()
        Me.Numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IvaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PresupuestoDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblCostoFinanciero = New System.Windows.Forms.Label()
        CType(Me.dgPresupuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TabAdministracionPresupuesto.SuspendLayout()
        Me.TabPresupuesto.SuspendLayout()
        Me.TabDetalle.SuspendLayout()
        Me.lblcontenedor.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.Gb_Anulado.SuspendLayout()
        CType(Me.dgPresupuestoDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresupuestoDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_Msg
        '
        Me.lbl_Msg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Msg.AutoSize = True
        Me.lbl_Msg.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lbl_Msg.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Msg.Location = New System.Drawing.Point(235, 352)
        Me.lbl_Msg.Name = "lbl_Msg"
        Me.lbl_Msg.Size = New System.Drawing.Size(402, 25)
        Me.lbl_Msg.TabIndex = 5
        Me.lbl_Msg.Text = "No se han encontrado Presupuestos."
        Me.lbl_Msg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgPresupuesto
        '
        Me.dgPresupuesto.AllowUserToAddRows = False
        Me.dgPresupuesto.AllowUserToDeleteRows = False
        Me.dgPresupuesto.AllowUserToResizeColumns = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgPresupuesto.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgPresupuesto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgPresupuesto.AutoGenerateColumns = False
        Me.dgPresupuesto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgPresupuesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPresupuesto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdPresupuestoDataGridViewTextBoxColumn, Me.RazonSocialClienteMayoristaDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn, Me.AnuladoDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.Imprimir})
        Me.dgPresupuesto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgPresupuesto.DataSource = Me.PresupuestoBindingSource
        Me.dgPresupuesto.Location = New System.Drawing.Point(6, 145)
        Me.dgPresupuesto.MultiSelect = False
        Me.dgPresupuesto.Name = "dgPresupuesto"
        Me.dgPresupuesto.ReadOnly = True
        Me.dgPresupuesto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgPresupuesto.Size = New System.Drawing.Size(861, 431)
        Me.dgPresupuesto.TabIndex = 4
        '
        'IdPresupuestoDataGridViewTextBoxColumn
        '
        Me.IdPresupuestoDataGridViewTextBoxColumn.DataPropertyName = "id_Presupuesto"
        Me.IdPresupuestoDataGridViewTextBoxColumn.HeaderText = "Numero"
        Me.IdPresupuestoDataGridViewTextBoxColumn.Name = "IdPresupuestoDataGridViewTextBoxColumn"
        Me.IdPresupuestoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RazonSocialClienteMayoristaDataGridViewTextBoxColumn
        '
        Me.RazonSocialClienteMayoristaDataGridViewTextBoxColumn.DataPropertyName = "RazonSocialClienteMayorista"
        Me.RazonSocialClienteMayoristaDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.RazonSocialClienteMayoristaDataGridViewTextBoxColumn.Name = "RazonSocialClienteMayoristaDataGridViewTextBoxColumn"
        Me.RazonSocialClienteMayoristaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "Total"
        DataGridViewCellStyle2.Format = "C2"
        Me.TotalDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        Me.TotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AnuladoDataGridViewTextBoxColumn
        '
        Me.AnuladoDataGridViewTextBoxColumn.DataPropertyName = "Anulado"
        Me.AnuladoDataGridViewTextBoxColumn.HeaderText = "Anulado"
        Me.AnuladoDataGridViewTextBoxColumn.Name = "AnuladoDataGridViewTextBoxColumn"
        Me.AnuladoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Imprimir
        '
        Me.Imprimir.HeaderText = "Imprimir"
        Me.Imprimir.Image = Global.SistemaCinderella.My.Resources.Recursos.icono_imprimir
        Me.Imprimir.Name = "Imprimir"
        Me.Imprimir.ReadOnly = True
        '
        'PresupuestoBindingSource
        '
        Me.PresupuestoBindingSource.DataSource = GetType(Entidades.Presupuesto)
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label13, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label19, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.FDesde, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label12, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.FHasta, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtCliente, 1, 2)
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(6, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(864, 90)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(3, 7)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(142, 16)
        Me.Label13.TabIndex = 421
        Me.Label13.Text = "N° Presupuesto"
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(3, 37)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(142, 16)
        Me.Label19.TabIndex = 430
        Me.Label19.Text = "Monto"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.txtPresupuestoHasta, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label29, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtPresupuestoDesde, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(151, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(217, 24)
        Me.TableLayoutPanel2.TabIndex = 431
        '
        'txtPresupuestoHasta
        '
        Me.txtPresupuestoHasta.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPresupuestoHasta.Location = New System.Drawing.Point(121, 3)
        Me.txtPresupuestoHasta.Name = "txtPresupuestoHasta"
        Me.txtPresupuestoHasta.Size = New System.Drawing.Size(93, 21)
        Me.txtPresupuestoHasta.TabIndex = 423
        '
        'Label29
        '
        Me.Label29.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(101, 4)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(14, 16)
        Me.Label29.TabIndex = 422
        Me.Label29.Text = "-"
        '
        'txtPresupuestoDesde
        '
        Me.txtPresupuestoDesde.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPresupuestoDesde.Location = New System.Drawing.Point(3, 3)
        Me.txtPresupuestoDesde.Name = "txtPresupuestoDesde"
        Me.txtPresupuestoDesde.Size = New System.Drawing.Size(92, 21)
        Me.txtPresupuestoDesde.TabIndex = 419
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.txtMontoHasta, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.txtMontoDesde, 0, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(151, 33)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(217, 24)
        Me.TableLayoutPanel3.TabIndex = 432
        '
        'txtMontoHasta
        '
        Me.txtMontoHasta.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMontoHasta.Location = New System.Drawing.Point(121, 3)
        Me.txtMontoHasta.Name = "txtMontoHasta"
        Me.txtMontoHasta.Size = New System.Drawing.Size(93, 21)
        Me.txtMontoHasta.TabIndex = 423
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(101, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 16)
        Me.Label1.TabIndex = 422
        Me.Label1.Text = "-"
        '
        'txtMontoDesde
        '
        Me.txtMontoDesde.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMontoDesde.Location = New System.Drawing.Point(3, 3)
        Me.txtMontoDesde.Name = "txtMontoDesde"
        Me.txtMontoDesde.Size = New System.Drawing.Size(92, 21)
        Me.txtMontoDesde.TabIndex = 419
        '
        'FDesde
        '
        Me.FDesde.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FDesde.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FDesde.Location = New System.Drawing.Point(642, 4)
        Me.FDesde.Name = "FDesde"
        Me.FDesde.Size = New System.Drawing.Size(219, 21)
        Me.FDesde.TabIndex = 434
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(494, 7)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(142, 16)
        Me.Label12.TabIndex = 433
        Me.Label12.Text = "Fecha desde"
        '
        'FHasta
        '
        Me.FHasta.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FHasta.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FHasta.Location = New System.Drawing.Point(642, 34)
        Me.FHasta.Name = "FHasta"
        Me.FHasta.Size = New System.Drawing.Size(219, 21)
        Me.FHasta.TabIndex = 436
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(494, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 16)
        Me.Label2.TabIndex = 435
        Me.Label2.Text = "Fecha Hasta"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 16)
        Me.Label3.TabIndex = 437
        Me.Label3.Text = "Cliente"
        '
        'txtCliente
        '
        Me.txtCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCliente.Location = New System.Drawing.Point(151, 64)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(217, 21)
        Me.txtCliente.TabIndex = 438
        '
        'btn_Restablecer
        '
        Me.btn_Restablecer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Restablecer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Restablecer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Restablecer.Location = New System.Drawing.Point(661, 99)
        Me.btn_Restablecer.Name = "btn_Restablecer"
        Me.btn_Restablecer.Size = New System.Drawing.Size(100, 40)
        Me.btn_Restablecer.TabIndex = 11
        Me.btn_Restablecer.Text = "Restablecer Busqueda"
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
        Me.BtnFiltrar.Location = New System.Drawing.Point(767, 99)
        Me.BtnFiltrar.Name = "BtnFiltrar"
        Me.BtnFiltrar.Size = New System.Drawing.Size(100, 40)
        Me.BtnFiltrar.TabIndex = 10
        Me.BtnFiltrar.Text = "Buscar"
        Me.BtnFiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnFiltrar.UseVisualStyleBackColor = True
        '
        'TabAdministracionPresupuesto
        '
        Me.TabAdministracionPresupuesto.Controls.Add(Me.TabPresupuesto)
        Me.TabAdministracionPresupuesto.Controls.Add(Me.TabDetalle)
        Me.TabAdministracionPresupuesto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabAdministracionPresupuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TabAdministracionPresupuesto.Location = New System.Drawing.Point(0, 0)
        Me.TabAdministracionPresupuesto.Name = "TabAdministracionPresupuesto"
        Me.TabAdministracionPresupuesto.SelectedIndex = 0
        Me.TabAdministracionPresupuesto.Size = New System.Drawing.Size(884, 617)
        Me.TabAdministracionPresupuesto.TabIndex = 12
        '
        'TabPresupuesto
        '
        Me.TabPresupuesto.Controls.Add(Me.TableLayoutPanel1)
        Me.TabPresupuesto.Controls.Add(Me.lbl_Msg)
        Me.TabPresupuesto.Controls.Add(Me.btn_Restablecer)
        Me.TabPresupuesto.Controls.Add(Me.dgPresupuesto)
        Me.TabPresupuesto.Controls.Add(Me.BtnFiltrar)
        Me.TabPresupuesto.Location = New System.Drawing.Point(4, 29)
        Me.TabPresupuesto.Name = "TabPresupuesto"
        Me.TabPresupuesto.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPresupuesto.Size = New System.Drawing.Size(876, 584)
        Me.TabPresupuesto.TabIndex = 0
        Me.TabPresupuesto.Text = "Presupuestos"
        Me.TabPresupuesto.UseVisualStyleBackColor = True
        '
        'TabDetalle
        '
        Me.TabDetalle.Controls.Add(Me.lblcontenedor)
        Me.TabDetalle.Location = New System.Drawing.Point(4, 29)
        Me.TabDetalle.Name = "TabDetalle"
        Me.TabDetalle.Padding = New System.Windows.Forms.Padding(3)
        Me.TabDetalle.Size = New System.Drawing.Size(876, 584)
        Me.TabDetalle.TabIndex = 1
        Me.TabDetalle.Text = "Detalle del presupuesto"
        Me.TabDetalle.UseVisualStyleBackColor = True
        '
        'lblcontenedor
        '
        Me.lblcontenedor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblcontenedor.Controls.Add(Me.TableLayoutPanel5)
        Me.lblcontenedor.Controls.Add(Me.TableLayoutPanel4)
        Me.lblcontenedor.Controls.Add(Me.lblAnulado)
        Me.lblcontenedor.Controls.Add(Me.Gb_Anulado)
        Me.lblcontenedor.Controls.Add(Me.dgPresupuestoDetalle)
        Me.lblcontenedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcontenedor.Location = New System.Drawing.Point(8, 10)
        Me.lblcontenedor.Name = "lblcontenedor"
        Me.lblcontenedor.Size = New System.Drawing.Size(860, 565)
        Me.lblcontenedor.TabIndex = 1
        Me.lblcontenedor.TabStop = False
        Me.lblcontenedor.Text = "Información de la venta realizada."
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.lblCostoFinanciero, 1, 4)
        Me.TableLayoutPanel5.Controls.Add(Me.Label8, 0, 4)
        Me.TableLayoutPanel5.Controls.Add(Me.Label17, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.lblPago, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.Label11, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.lblSubtotal, 1, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.Label22, 0, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.lblCantidad, 1, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.Label24, 0, 3)
        Me.TableLayoutPanel5.Controls.Add(Me.lblMontoMayoristaDescripcion, 0, 5)
        Me.TableLayoutPanel5.Controls.Add(Me.lblMonto, 1, 5)
        Me.TableLayoutPanel5.Controls.Add(Me.lblDescuento, 1, 3)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(6, 410)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 6
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(295, 150)
        Me.TableLayoutPanel5.TabIndex = 73
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(3, 10)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(100, 15)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "Tipo de Pago :"
        '
        'lblPago
        '
        Me.lblPago.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblPago.AutoSize = True
        Me.lblPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPago.Location = New System.Drawing.Point(150, 10)
        Me.lblPago.Name = "lblPago"
        Me.lblPago.Size = New System.Drawing.Size(42, 15)
        Me.lblPago.TabIndex = 21
        Me.lblPago.Text = "- - - - - "
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(3, 35)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(135, 15)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Cant. de productos :"
        '
        'lblSubtotal
        '
        Me.lblSubtotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtotal.Location = New System.Drawing.Point(150, 60)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(42, 15)
        Me.lblSubtotal.TabIndex = 40
        Me.lblSubtotal.Text = "- - - - - "
        '
        'Label22
        '
        Me.Label22.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(3, 60)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(68, 15)
        Me.Label22.TabIndex = 39
        Me.Label22.Text = "Subtotal :"
        '
        'lblCantidad
        '
        Me.lblCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad.Location = New System.Drawing.Point(150, 35)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(42, 15)
        Me.lblCantidad.TabIndex = 22
        Me.lblCantidad.Text = "- - - - - "
        '
        'Label24
        '
        Me.Label24.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(3, 85)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(83, 15)
        Me.Label24.TabIndex = 37
        Me.Label24.Text = "Descuento :"
        '
        'lblDescuento
        '
        Me.lblDescuento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDescuento.AutoSize = True
        Me.lblDescuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescuento.Location = New System.Drawing.Point(150, 85)
        Me.lblDescuento.Name = "lblDescuento"
        Me.lblDescuento.Size = New System.Drawing.Size(42, 15)
        Me.lblDescuento.TabIndex = 38
        Me.lblDescuento.Text = "- - - - - "
        '
        'lblMonto
        '
        Me.lblMonto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblMonto.AutoSize = True
        Me.lblMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonto.Location = New System.Drawing.Point(150, 135)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(42, 15)
        Me.lblMonto.TabIndex = 36
        Me.lblMonto.Text = "- - - - - "
        '
        'lblMontoMayoristaDescripcion
        '
        Me.lblMontoMayoristaDescripcion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblMontoMayoristaDescripcion.AutoSize = True
        Me.lblMontoMayoristaDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontoMayoristaDescripcion.Location = New System.Drawing.Point(3, 135)
        Me.lblMontoMayoristaDescripcion.Name = "lblMontoMayoristaDescripcion"
        Me.lblMontoMayoristaDescripcion.Size = New System.Drawing.Size(87, 15)
        Me.lblMontoMayoristaDescripcion.TabIndex = 35
        Me.lblMontoMayoristaDescripcion.Text = "Monto total :"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel4.ColumnCount = 6
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.lblSucursal, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.lblEncargado, 5, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label5, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label16, 4, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.lblFecha, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.lblCliente, 5, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label4, 2, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label7, 2, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.lblVenta, 3, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label10, 4, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.lblVendedor, 3, 1)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(6, 27)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(848, 60)
        Me.TableLayoutPanel4.TabIndex = 72
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
        Me.lblSucursal.Size = New System.Drawing.Size(166, 15)
        Me.lblSucursal.TabIndex = 18
        Me.lblSucursal.Text = "- - - - - "
        '
        'lblEncargado
        '
        Me.lblEncargado.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEncargado.AutoSize = True
        Me.lblEncargado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEncargado.Location = New System.Drawing.Point(677, 37)
        Me.lblEncargado.Name = "lblEncargado"
        Me.lblEncargado.Size = New System.Drawing.Size(168, 15)
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
        Me.Label16.Location = New System.Drawing.Point(567, 37)
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
        Me.lblFecha.Size = New System.Drawing.Size(166, 15)
        Me.lblFecha.TabIndex = 17
        Me.lblFecha.Text = "- - - - - "
        '
        'lblCliente
        '
        Me.lblCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.Location = New System.Drawing.Point(677, 7)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(168, 15)
        Me.lblCliente.TabIndex = 27
        Me.lblCliente.Text = "- - - - - "
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(285, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tipo de Venta :"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(285, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 15)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Vendedor :"
        '
        'lblVenta
        '
        Me.lblVenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVenta.AutoSize = True
        Me.lblVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVenta.Location = New System.Drawing.Point(395, 7)
        Me.lblVenta.Name = "lblVenta"
        Me.lblVenta.Size = New System.Drawing.Size(166, 15)
        Me.lblVenta.TabIndex = 20
        Me.lblVenta.Text = "- - - - - "
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(567, 7)
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
        Me.lblVendedor.Location = New System.Drawing.Point(395, 37)
        Me.lblVendedor.Name = "lblVendedor"
        Me.lblVendedor.Size = New System.Drawing.Size(166, 15)
        Me.lblVendedor.TabIndex = 19
        Me.lblVendedor.Text = "- - - - - "
        '
        'lblAnulado
        '
        Me.lblAnulado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAnulado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnulado.ForeColor = System.Drawing.Color.Red
        Me.lblAnulado.Location = New System.Drawing.Point(307, 410)
        Me.lblAnulado.Name = "lblAnulado"
        Me.lblAnulado.Size = New System.Drawing.Size(279, 143)
        Me.lblAnulado.TabIndex = 28
        Me.lblAnulado.Text = "PRESUPUESTO ANULADO."
        Me.lblAnulado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Gb_Anulado
        '
        Me.Gb_Anulado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gb_Anulado.Controls.Add(Me.Label9)
        Me.Gb_Anulado.Controls.Add(Me.txtDescripcionAnular)
        Me.Gb_Anulado.Controls.Add(Me.BtnAnular)
        Me.Gb_Anulado.Location = New System.Drawing.Point(592, 410)
        Me.Gb_Anulado.Name = "Gb_Anulado"
        Me.Gb_Anulado.Size = New System.Drawing.Size(262, 149)
        Me.Gb_Anulado.TabIndex = 16
        Me.Gb_Anulado.TabStop = False
        Me.Gb_Anulado.Text = "Anular Presupuesto"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 15)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Motivo"
        '
        'txtDescripcionAnular
        '
        Me.txtDescripcionAnular.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescripcionAnular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionAnular.Location = New System.Drawing.Point(55, 27)
        Me.txtDescripcionAnular.Multiline = True
        Me.txtDescripcionAnular.Name = "txtDescripcionAnular"
        Me.txtDescripcionAnular.Size = New System.Drawing.Size(194, 83)
        Me.txtDescripcionAnular.TabIndex = 15
        '
        'BtnAnular
        '
        Me.BtnAnular.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAnular.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAnular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAnular.Image = Global.SistemaCinderella.My.Resources.Recursos.Desconectado
        Me.BtnAnular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAnular.Location = New System.Drawing.Point(171, 116)
        Me.BtnAnular.Name = "BtnAnular"
        Me.BtnAnular.Size = New System.Drawing.Size(78, 27)
        Me.BtnAnular.TabIndex = 14
        Me.BtnAnular.Text = "Anular"
        Me.BtnAnular.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAnular.UseVisualStyleBackColor = True
        '
        'dgPresupuestoDetalle
        '
        Me.dgPresupuestoDetalle.AllowUserToAddRows = False
        Me.dgPresupuestoDetalle.AllowUserToDeleteRows = False
        Me.dgPresupuestoDetalle.AllowUserToResizeRows = False
        Me.dgPresupuestoDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgPresupuestoDetalle.AutoGenerateColumns = False
        Me.dgPresupuestoDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgPresupuestoDetalle.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgPresupuestoDetalle.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgPresupuestoDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPresupuestoDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Numero, Me.IdProductoDataGridViewTextBoxColumn, Me.NombreProducto, Me.CantidadDataGridViewTextBoxColumn, Me.PrecioDataGridViewTextBoxColumn, Me.IvaDataGridViewTextBoxColumn, Me.MontoDataGridViewTextBoxColumn, Me.Subtotal})
        Me.dgPresupuestoDetalle.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.dgPresupuestoDetalle.DataSource = Me.PresupuestoDetalleBindingSource
        Me.dgPresupuestoDetalle.Location = New System.Drawing.Point(6, 93)
        Me.dgPresupuestoDetalle.MultiSelect = False
        Me.dgPresupuestoDetalle.Name = "dgPresupuestoDetalle"
        Me.dgPresupuestoDetalle.ReadOnly = True
        Me.dgPresupuestoDetalle.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgPresupuestoDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgPresupuestoDetalle.Size = New System.Drawing.Size(848, 311)
        Me.dgPresupuestoDetalle.TabIndex = 11
        '
        'Numero
        '
        Me.Numero.HeaderText = "Número"
        Me.Numero.Name = "Numero"
        Me.Numero.ReadOnly = True
        '
        'IdProductoDataGridViewTextBoxColumn
        '
        Me.IdProductoDataGridViewTextBoxColumn.DataPropertyName = "CodigoProducto"
        Me.IdProductoDataGridViewTextBoxColumn.HeaderText = "Código"
        Me.IdProductoDataGridViewTextBoxColumn.Name = "IdProductoDataGridViewTextBoxColumn"
        Me.IdProductoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreProducto
        '
        Me.NombreProducto.DataPropertyName = "NombreProducto"
        Me.NombreProducto.HeaderText = "Nombre"
        Me.NombreProducto.Name = "NombreProducto"
        Me.NombreProducto.ReadOnly = True
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        Me.CantidadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrecioDataGridViewTextBoxColumn
        '
        Me.PrecioDataGridViewTextBoxColumn.DataPropertyName = "Precio"
        DataGridViewCellStyle3.Format = "C2"
        Me.PrecioDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.PrecioDataGridViewTextBoxColumn.HeaderText = "Precio"
        Me.PrecioDataGridViewTextBoxColumn.Name = "PrecioDataGridViewTextBoxColumn"
        Me.PrecioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IvaDataGridViewTextBoxColumn
        '
        Me.IvaDataGridViewTextBoxColumn.DataPropertyName = "Iva"
        DataGridViewCellStyle4.Format = "C2"
        Me.IvaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.IvaDataGridViewTextBoxColumn.HeaderText = "Iva"
        Me.IvaDataGridViewTextBoxColumn.Name = "IvaDataGridViewTextBoxColumn"
        Me.IvaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MontoDataGridViewTextBoxColumn
        '
        Me.MontoDataGridViewTextBoxColumn.DataPropertyName = "Monto"
        DataGridViewCellStyle5.Format = "C2"
        Me.MontoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.MontoDataGridViewTextBoxColumn.HeaderText = "Monto"
        Me.MontoDataGridViewTextBoxColumn.Name = "MontoDataGridViewTextBoxColumn"
        Me.MontoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Subtotal
        '
        DataGridViewCellStyle6.Format = "C2"
        Me.Subtotal.DefaultCellStyle = DataGridViewCellStyle6
        Me.Subtotal.HeaderText = "Subtotal"
        Me.Subtotal.Name = "Subtotal"
        Me.Subtotal.ReadOnly = True
        '
        'PresupuestoDetalleBindingSource
        '
        Me.PresupuestoDetalleBindingSource.DataSource = GetType(Entidades.Presupuesto_Detalle)
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 110)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(123, 15)
        Me.Label8.TabIndex = 74
        Me.Label8.Text = "Costo Financiero :"
        '
        'lblCostoFinanciero
        '
        Me.lblCostoFinanciero.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCostoFinanciero.AutoSize = True
        Me.lblCostoFinanciero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostoFinanciero.Location = New System.Drawing.Point(150, 110)
        Me.lblCostoFinanciero.Name = "lblCostoFinanciero"
        Me.lblCostoFinanciero.Size = New System.Drawing.Size(42, 15)
        Me.lblCostoFinanciero.TabIndex = 74
        Me.lblCostoFinanciero.Text = "- - - - - "
        '
        'frmPresupuestoAdministracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 617)
        Me.Controls.Add(Me.TabAdministracionPresupuesto)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPresupuestoAdministracion"
        Me.Text = "Presupuesto Administración"
        CType(Me.dgPresupuesto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TabAdministracionPresupuesto.ResumeLayout(False)
        Me.TabPresupuesto.ResumeLayout(False)
        Me.TabPresupuesto.PerformLayout()
        Me.TabDetalle.ResumeLayout(False)
        Me.lblcontenedor.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.Gb_Anulado.ResumeLayout(False)
        Me.Gb_Anulado.PerformLayout()
        CType(Me.dgPresupuestoDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresupuestoDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbl_Msg As Label
    Friend WithEvents dgPresupuesto As DataGridView
    Friend WithEvents PresupuestoBindingSource As BindingSource
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label13 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents txtPresupuestoDesde As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents txtPresupuestoHasta As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents FDesde As DateTimePicker
    Friend WithEvents btn_Restablecer As Button
    Friend WithEvents BtnFiltrar As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents txtMontoHasta As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMontoDesde As TextBox
    Friend WithEvents FHasta As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents TabAdministracionPresupuesto As TabControl
    Friend WithEvents TabPresupuesto As TabPage
    Friend WithEvents TabDetalle As TabPage
    Friend WithEvents lblcontenedor As GroupBox
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Label6 As Label
    Friend WithEvents lblSucursal As Label
    Friend WithEvents lblEncargado As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblCliente As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblVenta As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblVendedor As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents lblDescuento As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents lblMonto As Label
    Friend WithEvents lblMontoMayoristaDescripcion As Label
    Friend WithEvents lblAnulado As Label
    Friend WithEvents lblCantidad As Label
    Friend WithEvents lblPago As Label
    Friend WithEvents Gb_Anulado As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtDescripcionAnular As TextBox
    Friend WithEvents BtnAnular As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents dgPresupuestoDetalle As DataGridView
    Friend WithEvents Label17 As Label
    Friend WithEvents PresupuestoDetalleBindingSource As BindingSource
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents IdPresupuestoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RazonSocialClienteMayoristaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AnuladoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Imprimir As DataGridViewImageColumn
    Friend WithEvents Numero As DataGridViewTextBoxColumn
    Friend WithEvents IdProductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreProducto As DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IvaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MontoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Subtotal As DataGridViewTextBoxColumn
    Friend WithEvents lblCostoFinanciero As Label
    Friend WithEvents Label8 As Label
End Class
