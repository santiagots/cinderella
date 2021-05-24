<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDevolucionesAdministracion
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDevolucionesAdministracion))
        Me.TabVentas = New System.Windows.Forms.TabControl()
        Me.TbListado = New System.Windows.Forms.TabPage()
        Me.lbl_Msg = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_Restablecer = New System.Windows.Forms.Button()
        Me.BtnFiltrar = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.FHasta = New System.Windows.Forms.DateTimePicker()
        Me.FDesde = New System.Windows.Forms.DateTimePicker()
        Me.DG_Devolucion = New System.Windows.Forms.DataGridView()
        Me.id_Devolucion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Empleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Anulado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoNotaCredito = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.NumeroNotaCredito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbDetalle = New System.Windows.Forms.TabPage()
        Me.lblcontenedor = New System.Windows.Forms.GroupBox()
        Me.PanelTotalMinorista = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblMontoMinorista = New System.Windows.Forms.Label()
        Me.lblDescuentoMinorista = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblSubtotalMinorista = New System.Windows.Forms.Label()
        Me.PanelTotalMayorista = New System.Windows.Forms.Panel()
        Me.lblIVAMayorista = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.lblSubtotalMayorista = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lblDescuentoMayorista = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.lblMontoMayorista = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.BtnEmitirFactura = New System.Windows.Forms.Button()
        Me.lblEncargado = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.BtnNotaCredito = New System.Windows.Forms.Button()
        Me.lblAnulado = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblNotaCredito = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.lblPago = New System.Windows.Forms.Label()
        Me.lblDevolucion = New System.Windows.Forms.Label()
        Me.lblVendedor = New System.Windows.Forms.Label()
        Me.lblSucursal = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.Gb_Anulado = New System.Windows.Forms.GroupBox()
        Me.txtDescripcionAnular = New System.Windows.Forms.TextBox()
        Me.BtnAnular = New System.Windows.Forms.Button()
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TabVentas.SuspendLayout()
        Me.TbListado.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DG_Devolucion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TbDetalle.SuspendLayout()
        Me.lblcontenedor.SuspendLayout()
        Me.PanelTotalMinorista.SuspendLayout()
        Me.PanelTotalMayorista.SuspendLayout()
        Me.Gb_Anulado.SuspendLayout()
        CType(Me.DG_Productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
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
        Me.TabVentas.Location = New System.Drawing.Point(8, 8)
        Me.TabVentas.Name = "TabVentas"
        Me.TabVentas.SelectedIndex = 0
        Me.TabVentas.Size = New System.Drawing.Size(806, 557)
        Me.TabVentas.TabIndex = 3
        '
        'TbListado
        '
        Me.TbListado.Controls.Add(Me.lbl_Msg)
        Me.TbListado.Controls.Add(Me.GroupBox1)
        Me.TbListado.Controls.Add(Me.DG_Devolucion)
        Me.TbListado.Location = New System.Drawing.Point(4, 29)
        Me.TbListado.Name = "TbListado"
        Me.TbListado.Padding = New System.Windows.Forms.Padding(3)
        Me.TbListado.Size = New System.Drawing.Size(798, 524)
        Me.TbListado.TabIndex = 0
        Me.TbListado.Text = "Devoluciones"
        Me.TbListado.UseVisualStyleBackColor = True
        '
        'lbl_Msg
        '
        Me.lbl_Msg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Msg.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lbl_Msg.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Msg.Location = New System.Drawing.Point(46, 294)
        Me.lbl_Msg.Name = "lbl_Msg"
        Me.lbl_Msg.Size = New System.Drawing.Size(710, 25)
        Me.lbl_Msg.TabIndex = 2
        Me.lbl_Msg.Text = "No se han encontrado ventas en el rango de fechas seleccionado."
        Me.lbl_Msg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btn_Restablecer)
        Me.GroupBox1.Controls.Add(Me.BtnFiltrar)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.FHasta)
        Me.GroupBox1.Controls.Add(Me.FDesde)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(10, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(782, 93)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtrar Devoluciones por fecha."
        '
        'btn_Restablecer
        '
        Me.btn_Restablecer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Restablecer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Restablecer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Restablecer.Location = New System.Drawing.Point(570, 30)
        Me.btn_Restablecer.Name = "btn_Restablecer"
        Me.btn_Restablecer.Size = New System.Drawing.Size(100, 40)
        Me.btn_Restablecer.TabIndex = 9
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
        Me.BtnFiltrar.Location = New System.Drawing.Point(676, 30)
        Me.BtnFiltrar.Name = "BtnFiltrar"
        Me.BtnFiltrar.Size = New System.Drawing.Size(100, 40)
        Me.BtnFiltrar.TabIndex = 4
        Me.BtnFiltrar.Text = "Buscar"
        Me.BtnFiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnFiltrar.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 29)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(99, 16)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Fecha desde"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 61)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 16)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Fecha hasta"
        '
        'FHasta
        '
        Me.FHasta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FHasta.Location = New System.Drawing.Point(126, 56)
        Me.FHasta.Name = "FHasta"
        Me.FHasta.Size = New System.Drawing.Size(438, 21)
        Me.FHasta.TabIndex = 1
        '
        'FDesde
        '
        Me.FDesde.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FDesde.Location = New System.Drawing.Point(126, 24)
        Me.FDesde.Name = "FDesde"
        Me.FDesde.Size = New System.Drawing.Size(438, 21)
        Me.FDesde.TabIndex = 0
        '
        'DG_Devolucion
        '
        Me.DG_Devolucion.AllowUserToAddRows = False
        Me.DG_Devolucion.AllowUserToDeleteRows = False
        Me.DG_Devolucion.AllowUserToResizeColumns = False
        Me.DG_Devolucion.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DG_Devolucion.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DG_Devolucion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_Devolucion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_Devolucion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_Devolucion, Me.Empleado, Me.Cliente, Me.MontoTotal, Me.Anulado, Me.Fecha, Me.TipoNotaCredito, Me.NumeroNotaCredito})
        Me.DG_Devolucion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DG_Devolucion.Location = New System.Drawing.Point(10, 105)
        Me.DG_Devolucion.MultiSelect = False
        Me.DG_Devolucion.Name = "DG_Devolucion"
        Me.DG_Devolucion.ReadOnly = True
        Me.DG_Devolucion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DG_Devolucion.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DG_Devolucion.RowTemplate.Height = 30
        Me.DG_Devolucion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Devolucion.Size = New System.Drawing.Size(782, 402)
        Me.DG_Devolucion.TabIndex = 0
        '
        'id_Devolucion
        '
        Me.id_Devolucion.DataPropertyName = "id_Devolucion"
        Me.id_Devolucion.FillWeight = 17.30346!
        Me.id_Devolucion.HeaderText = "ID"
        Me.id_Devolucion.MaxInputLength = 10
        Me.id_Devolucion.Name = "id_Devolucion"
        Me.id_Devolucion.ReadOnly = True
        '
        'Empleado
        '
        Me.Empleado.DataPropertyName = "Empleado"
        Me.Empleado.FillWeight = 162.2804!
        Me.Empleado.HeaderText = "Empleado"
        Me.Empleado.Name = "Empleado"
        Me.Empleado.ReadOnly = True
        '
        'Cliente
        '
        Me.Cliente.DataPropertyName = "Cliente"
        Me.Cliente.FillWeight = 128.2283!
        Me.Cliente.HeaderText = "Cliente"
        Me.Cliente.Name = "Cliente"
        Me.Cliente.ReadOnly = True
        '
        'MontoTotal
        '
        Me.MontoTotal.DataPropertyName = "MontoTotal"
        Me.MontoTotal.FillWeight = 141.8023!
        Me.MontoTotal.HeaderText = "Monto Total"
        Me.MontoTotal.Name = "MontoTotal"
        Me.MontoTotal.ReadOnly = True
        '
        'Anulado
        '
        Me.Anulado.DataPropertyName = "Anulado"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Anulado.DefaultCellStyle = DataGridViewCellStyle2
        Me.Anulado.FillWeight = 49.88074!
        Me.Anulado.HeaderText = "Anulado"
        Me.Anulado.MaxInputLength = 10
        Me.Anulado.Name = "Anulado"
        Me.Anulado.ReadOnly = True
        '
        'Fecha
        '
        Me.Fecha.DataPropertyName = "Fecha"
        Me.Fecha.FillWeight = 129.4388!
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        '
        'TipoNotaCredito
        '
        Me.TipoNotaCredito.DataPropertyName = "TipoRecibo"
        Me.TipoNotaCredito.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.TipoNotaCredito.HeaderText = "Nota Crédito"
        Me.TipoNotaCredito.Name = "TipoNotaCredito"
        Me.TipoNotaCredito.ReadOnly = True
        '
        'NumeroNotaCredito
        '
        Me.NumeroNotaCredito.DataPropertyName = "NumeroNotaCredito"
        Me.NumeroNotaCredito.HeaderText = "Numero"
        Me.NumeroNotaCredito.Name = "NumeroNotaCredito"
        Me.NumeroNotaCredito.ReadOnly = True
        '
        'TbDetalle
        '
        Me.TbDetalle.Controls.Add(Me.lblcontenedor)
        Me.TbDetalle.Location = New System.Drawing.Point(4, 29)
        Me.TbDetalle.Name = "TbDetalle"
        Me.TbDetalle.Size = New System.Drawing.Size(798, 524)
        Me.TbDetalle.TabIndex = 2
        Me.TbDetalle.Text = "Detalle de la Devolución"
        Me.TbDetalle.UseVisualStyleBackColor = True
        '
        'lblcontenedor
        '
        Me.lblcontenedor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblcontenedor.Controls.Add(Me.TableLayoutPanel2)
        Me.lblcontenedor.Controls.Add(Me.TableLayoutPanel1)
        Me.lblcontenedor.Controls.Add(Me.PanelTotalMinorista)
        Me.lblcontenedor.Controls.Add(Me.PanelTotalMayorista)
        Me.lblcontenedor.Controls.Add(Me.BtnEmitirFactura)
        Me.lblcontenedor.Controls.Add(Me.BtnNotaCredito)
        Me.lblcontenedor.Controls.Add(Me.lblNotaCredito)
        Me.lblcontenedor.Controls.Add(Me.label8)
        Me.lblcontenedor.Controls.Add(Me.lblCantidad)
        Me.lblcontenedor.Controls.Add(Me.lblPago)
        Me.lblcontenedor.Controls.Add(Me.Label1)
        Me.lblcontenedor.Controls.Add(Me.DG_Productos)
        Me.lblcontenedor.Controls.Add(Me.Label2)
        Me.lblcontenedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcontenedor.Location = New System.Drawing.Point(10, 6)
        Me.lblcontenedor.Name = "lblcontenedor"
        Me.lblcontenedor.Size = New System.Drawing.Size(782, 512)
        Me.lblcontenedor.TabIndex = 0
        Me.lblcontenedor.TabStop = False
        Me.lblcontenedor.Text = "Información de la devolución realizada."
        '
        'PanelTotalMinorista
        '
        Me.PanelTotalMinorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelTotalMinorista.Controls.Add(Me.Label13)
        Me.PanelTotalMinorista.Controls.Add(Me.Label17)
        Me.PanelTotalMinorista.Controls.Add(Me.lblMontoMinorista)
        Me.PanelTotalMinorista.Controls.Add(Me.lblDescuentoMinorista)
        Me.PanelTotalMinorista.Controls.Add(Me.Label18)
        Me.PanelTotalMinorista.Controls.Add(Me.lblSubtotalMinorista)
        Me.PanelTotalMinorista.Location = New System.Drawing.Point(3, 406)
        Me.PanelTotalMinorista.Name = "PanelTotalMinorista"
        Me.PanelTotalMinorista.Size = New System.Drawing.Size(258, 100)
        Me.PanelTotalMinorista.TabIndex = 42
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(3, 32)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 15)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "Descuento :"
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(3, 60)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(87, 15)
        Me.Label17.TabIndex = 13
        Me.Label17.Text = "Monto total :"
        '
        'lblMontoMinorista
        '
        Me.lblMontoMinorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblMontoMinorista.AutoSize = True
        Me.lblMontoMinorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontoMinorista.Location = New System.Drawing.Point(193, 60)
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
        Me.lblDescuentoMinorista.Location = New System.Drawing.Point(193, 32)
        Me.lblDescuentoMinorista.Name = "lblDescuentoMinorista"
        Me.lblDescuentoMinorista.Size = New System.Drawing.Size(42, 15)
        Me.lblDescuentoMinorista.TabIndex = 32
        Me.lblDescuentoMinorista.Text = "- - - - - "
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(3, 5)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(68, 15)
        Me.Label18.TabIndex = 33
        Me.Label18.Text = "Subtotal :"
        '
        'lblSubtotalMinorista
        '
        Me.lblSubtotalMinorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSubtotalMinorista.AutoSize = True
        Me.lblSubtotalMinorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtotalMinorista.Location = New System.Drawing.Point(193, 5)
        Me.lblSubtotalMinorista.Name = "lblSubtotalMinorista"
        Me.lblSubtotalMinorista.Size = New System.Drawing.Size(42, 15)
        Me.lblSubtotalMinorista.TabIndex = 34
        Me.lblSubtotalMinorista.Text = "- - - - - "
        '
        'PanelTotalMayorista
        '
        Me.PanelTotalMayorista.Controls.Add(Me.lblIVAMayorista)
        Me.PanelTotalMayorista.Controls.Add(Me.Label28)
        Me.PanelTotalMayorista.Controls.Add(Me.lblSubtotalMayorista)
        Me.PanelTotalMayorista.Controls.Add(Me.Label22)
        Me.PanelTotalMayorista.Controls.Add(Me.lblDescuentoMayorista)
        Me.PanelTotalMayorista.Controls.Add(Me.Label24)
        Me.PanelTotalMayorista.Controls.Add(Me.lblMontoMayorista)
        Me.PanelTotalMayorista.Controls.Add(Me.Label26)
        Me.PanelTotalMayorista.Location = New System.Drawing.Point(9, 225)
        Me.PanelTotalMayorista.Name = "PanelTotalMayorista"
        Me.PanelTotalMayorista.Size = New System.Drawing.Size(251, 100)
        Me.PanelTotalMayorista.TabIndex = 41
        '
        'lblIVAMayorista
        '
        Me.lblIVAMayorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblIVAMayorista.AutoSize = True
        Me.lblIVAMayorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIVAMayorista.Location = New System.Drawing.Point(195, 53)
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
        Me.Label28.Location = New System.Drawing.Point(5, 53)
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
        Me.lblSubtotalMayorista.Location = New System.Drawing.Point(195, 29)
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
        Me.Label22.Location = New System.Drawing.Point(5, 29)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(68, 15)
        Me.Label22.TabIndex = 39
        Me.Label22.Text = "Subtotal :"
        '
        'lblDescuentoMayorista
        '
        Me.lblDescuentoMayorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDescuentoMayorista.AutoSize = True
        Me.lblDescuentoMayorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescuentoMayorista.Location = New System.Drawing.Point(195, 5)
        Me.lblDescuentoMayorista.Name = "lblDescuentoMayorista"
        Me.lblDescuentoMayorista.Size = New System.Drawing.Size(42, 15)
        Me.lblDescuentoMayorista.TabIndex = 38
        Me.lblDescuentoMayorista.Text = "- - - - - "
        '
        'Label24
        '
        Me.Label24.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(5, 5)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(83, 15)
        Me.Label24.TabIndex = 37
        Me.Label24.Text = "Descuento :"
        '
        'lblMontoMayorista
        '
        Me.lblMontoMayorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblMontoMayorista.AutoSize = True
        Me.lblMontoMayorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontoMayorista.Location = New System.Drawing.Point(195, 77)
        Me.lblMontoMayorista.Name = "lblMontoMayorista"
        Me.lblMontoMayorista.Size = New System.Drawing.Size(42, 15)
        Me.lblMontoMayorista.TabIndex = 36
        Me.lblMontoMayorista.Text = "- - - - - "
        '
        'Label26
        '
        Me.Label26.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(5, 77)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(87, 15)
        Me.Label26.TabIndex = 35
        Me.Label26.Text = "Monto total :"
        '
        'BtnEmitirFactura
        '
        Me.BtnEmitirFactura.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnEmitirFactura.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEmitirFactura.FlatAppearance.BorderSize = 0
        Me.BtnEmitirFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEmitirFactura.Image = Global.SistemaCinderella.My.Resources.Recursos.TicketPequeño
        Me.BtnEmitirFactura.Location = New System.Drawing.Point(268, 363)
        Me.BtnEmitirFactura.Name = "BtnEmitirFactura"
        Me.BtnEmitirFactura.Size = New System.Drawing.Size(18, 18)
        Me.BtnEmitirFactura.TabIndex = 38
        Me.BtnEmitirFactura.Tag = "Ver Detalle"
        Me.BtnEmitirFactura.UseVisualStyleBackColor = True
        '
        'lblEncargado
        '
        Me.lblEncargado.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEncargado.AutoSize = True
        Me.lblEncargado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEncargado.Location = New System.Drawing.Point(669, 40)
        Me.lblEncargado.Name = "lblEncargado"
        Me.lblEncargado.Size = New System.Drawing.Size(98, 15)
        Me.lblEncargado.TabIndex = 36
        Me.lblEncargado.Text = "- - - - - "
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(569, 40)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(94, 15)
        Me.Label16.TabIndex = 35
        Me.Label16.Text = "Encargado :"
        '
        'BtnNotaCredito
        '
        Me.BtnNotaCredito.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnNotaCredito.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNotaCredito.FlatAppearance.BorderSize = 0
        Me.BtnNotaCredito.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNotaCredito.Image = Global.SistemaCinderella.My.Resources.Recursos.Detalle_Pequeno
        Me.BtnNotaCredito.Location = New System.Drawing.Point(244, 363)
        Me.BtnNotaCredito.Name = "BtnNotaCredito"
        Me.BtnNotaCredito.Size = New System.Drawing.Size(18, 18)
        Me.BtnNotaCredito.TabIndex = 30
        Me.BtnNotaCredito.Tag = "Ver Detalle"
        Me.BtnNotaCredito.UseVisualStyleBackColor = True
        '
        'lblAnulado
        '
        Me.lblAnulado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblAnulado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnulado.ForeColor = System.Drawing.Color.Red
        Me.lblAnulado.Location = New System.Drawing.Point(3, 0)
        Me.lblAnulado.Name = "lblAnulado"
        Me.lblAnulado.Size = New System.Drawing.Size(232, 169)
        Me.lblAnulado.TabIndex = 28
        Me.lblAnulado.Text = "DEVOLUCIÓN ANULADA."
        Me.lblAnulado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCliente
        '
        Me.lblCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.Location = New System.Drawing.Point(669, 8)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(98, 15)
        Me.lblCliente.TabIndex = 27
        Me.lblCliente.Text = "- - - - - "
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(569, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 15)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Cliente :"
        '
        'lblNotaCredito
        '
        Me.lblNotaCredito.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblNotaCredito.AutoSize = True
        Me.lblNotaCredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotaCredito.Location = New System.Drawing.Point(196, 369)
        Me.lblNotaCredito.Name = "lblNotaCredito"
        Me.lblNotaCredito.Size = New System.Drawing.Size(42, 15)
        Me.lblNotaCredito.TabIndex = 25
        Me.lblNotaCredito.Text = "- - - - - "
        '
        'label8
        '
        Me.label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.Location = New System.Drawing.Point(6, 369)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(95, 15)
        Me.label8.TabIndex = 24
        Me.label8.Text = "Nota Crédito :"
        '
        'lblCantidad
        '
        Me.lblCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad.Location = New System.Drawing.Point(196, 393)
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
        Me.lblPago.Location = New System.Drawing.Point(196, 345)
        Me.lblPago.Name = "lblPago"
        Me.lblPago.Size = New System.Drawing.Size(42, 15)
        Me.lblPago.TabIndex = 21
        Me.lblPago.Text = "- - - - - "
        '
        'lblDevolucion
        '
        Me.lblDevolucion.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDevolucion.AutoSize = True
        Me.lblDevolucion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDevolucion.Location = New System.Drawing.Point(386, 8)
        Me.lblDevolucion.Name = "lblDevolucion"
        Me.lblDevolucion.Size = New System.Drawing.Size(97, 15)
        Me.lblDevolucion.TabIndex = 20
        Me.lblDevolucion.Text = "- - - - - "
        '
        'lblVendedor
        '
        Me.lblVendedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVendedor.AutoSize = True
        Me.lblVendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVendedor.Location = New System.Drawing.Point(386, 40)
        Me.lblVendedor.Name = "lblVendedor"
        Me.lblVendedor.Size = New System.Drawing.Size(97, 15)
        Me.lblVendedor.TabIndex = 19
        Me.lblVendedor.Text = "- - - - - "
        '
        'lblSucursal
        '
        Me.lblSucursal.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSucursal.AutoSize = True
        Me.lblSucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSucursal.Location = New System.Drawing.Point(103, 8)
        Me.lblSucursal.Name = "lblSucursal"
        Me.lblSucursal.Size = New System.Drawing.Size(97, 15)
        Me.lblSucursal.TabIndex = 18
        Me.lblSucursal.Text = "- - - - - "
        '
        'lblFecha
        '
        Me.lblFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(103, 40)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(97, 15)
        Me.lblFecha.TabIndex = 17
        Me.lblFecha.Text = "- - - - - "
        '
        'Gb_Anulado
        '
        Me.Gb_Anulado.Controls.Add(Me.txtDescripcionAnular)
        Me.Gb_Anulado.Controls.Add(Me.BtnAnular)
        Me.Gb_Anulado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Gb_Anulado.Location = New System.Drawing.Point(241, 3)
        Me.Gb_Anulado.Name = "Gb_Anulado"
        Me.Gb_Anulado.Size = New System.Drawing.Size(233, 163)
        Me.Gb_Anulado.TabIndex = 16
        Me.Gb_Anulado.TabStop = False
        Me.Gb_Anulado.Text = "Anular Devolucion - Motivo"
        '
        'txtDescripcionAnular
        '
        Me.txtDescripcionAnular.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescripcionAnular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionAnular.Location = New System.Drawing.Point(6, 20)
        Me.txtDescripcionAnular.Multiline = True
        Me.txtDescripcionAnular.Name = "txtDescripcionAnular"
        Me.txtDescripcionAnular.Size = New System.Drawing.Size(221, 104)
        Me.txtDescripcionAnular.TabIndex = 15
        '
        'BtnAnular
        '
        Me.BtnAnular.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAnular.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAnular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAnular.Image = Global.SistemaCinderella.My.Resources.Recursos.Desconectado
        Me.BtnAnular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAnular.Location = New System.Drawing.Point(149, 130)
        Me.BtnAnular.Name = "BtnAnular"
        Me.BtnAnular.Size = New System.Drawing.Size(78, 27)
        Me.BtnAnular.TabIndex = 14
        Me.BtnAnular.Text = "Anular"
        Me.BtnAnular.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAnular.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 393)
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
        Me.DG_Productos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NUMERO, Me.CODIGO, Me.NOMBRE, Me.CANTIDAD, Me.PRECIO, Me.IVA, Me.MONTO, Me.SUBTOTAL})
        Me.DG_Productos.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.DG_Productos.Location = New System.Drawing.Point(6, 93)
        Me.DG_Productos.MultiSelect = False
        Me.DG_Productos.Name = "DG_Productos"
        Me.DG_Productos.ReadOnly = True
        Me.DG_Productos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DG_Productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Productos.Size = New System.Drawing.Size(770, 232)
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
        Me.IVA.HeaderText = "Iva"
        Me.IVA.Name = "IVA"
        Me.IVA.ReadOnly = True
        '
        'MONTO
        '
        Me.MONTO.HeaderText = "Monto"
        Me.MONTO.Name = "MONTO"
        Me.MONTO.ReadOnly = True
        '
        'SUBTOTAL
        '
        DataGridViewCellStyle5.Format = "C2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.SUBTOTAL.DefaultCellStyle = DataGridViewCellStyle5
        Me.SUBTOTAL.FillWeight = 91.37056!
        Me.SUBTOTAL.HeaderText = "Subtotal"
        Me.SUBTOTAL.Name = "SUBTOTAL"
        Me.SUBTOTAL.ReadOnly = True
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Sucursal :"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Fecha :"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(286, 1)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 30)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tipo de Devolución :"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(286, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Vendedor :"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 345)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tipo de Pago :"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 8
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblSucursal, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblDevolucion, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblEncargado, 7, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 6, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label16, 6, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblCliente, 7, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblFecha, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblVendedor, 4, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(6, 23)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(770, 64)
        Me.TableLayoutPanel1.TabIndex = 43
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.lblAnulado, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Gb_Anulado, 1, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(295, 337)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(477, 169)
        Me.TableLayoutPanel2.TabIndex = 44
        '
        'frmDevolucionesAdministracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(806, 557)
        Me.Controls.Add(Me.TabVentas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDevolucionesAdministracion"
        Me.Text = "Administración de Devoluciones"
        Me.TabVentas.ResumeLayout(False)
        Me.TbListado.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DG_Devolucion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TbDetalle.ResumeLayout(False)
        Me.lblcontenedor.ResumeLayout(False)
        Me.lblcontenedor.PerformLayout()
        Me.PanelTotalMinorista.ResumeLayout(False)
        Me.PanelTotalMinorista.PerformLayout()
        Me.PanelTotalMayorista.ResumeLayout(False)
        Me.PanelTotalMayorista.PerformLayout()
        Me.Gb_Anulado.ResumeLayout(False)
        Me.Gb_Anulado.PerformLayout()
        CType(Me.DG_Productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabVentas As System.Windows.Forms.TabControl
    Friend WithEvents TbListado As System.Windows.Forms.TabPage
    Friend WithEvents lbl_Msg As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Restablecer As System.Windows.Forms.Button
    Friend WithEvents BtnFiltrar As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents FHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents FDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents DG_Devolucion As System.Windows.Forms.DataGridView
    Friend WithEvents TbDetalle As System.Windows.Forms.TabPage
    Friend WithEvents id_Devolucion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Empleado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MontoTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Anulado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoNotaCredito As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents NumeroNotaCredito As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblcontenedor As GroupBox
    Friend WithEvents PanelTotalMinorista As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents lblMontoMinorista As Label
    Friend WithEvents lblDescuentoMinorista As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents lblSubtotalMinorista As Label
    Friend WithEvents PanelTotalMayorista As Panel
    Friend WithEvents lblIVAMayorista As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents lblSubtotalMayorista As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents lblDescuentoMayorista As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents lblMontoMayorista As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents BtnEmitirFactura As Button
    Friend WithEvents lblEncargado As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents BtnNotaCredito As Button
    Friend WithEvents lblAnulado As Label
    Friend WithEvents lblCliente As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblNotaCredito As Label
    Friend WithEvents label8 As Label
    Friend WithEvents lblCantidad As Label
    Friend WithEvents lblPago As Label
    Friend WithEvents lblDevolucion As Label
    Friend WithEvents lblVendedor As Label
    Friend WithEvents lblSucursal As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents Gb_Anulado As GroupBox
    Friend WithEvents txtDescripcionAnular As TextBox
    Friend WithEvents BtnAnular As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DG_Productos As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents NUMERO As DataGridViewTextBoxColumn
    Friend WithEvents CODIGO As DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE As DataGridViewTextBoxColumn
    Friend WithEvents CANTIDAD As DataGridViewTextBoxColumn
    Friend WithEvents PRECIO As DataGridViewTextBoxColumn
    Friend WithEvents IVA As DataGridViewTextBoxColumn
    Friend WithEvents MONTO As DataGridViewTextBoxColumn
    Friend WithEvents SUBTOTAL As DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
