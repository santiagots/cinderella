<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmControladorFiscal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmControladorFiscal))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel10 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnCierreZPorFecha = New System.Windows.Forms.Button()
        Me.btnInformacionDeTransacciones = New System.Windows.Forms.Button()
        Me.btnResumenDeTotales = New System.Windows.Forms.Button()
        Me.btnDuplicadosDocumentosA = New System.Windows.Forms.Button()
        Me.btnCintaTestigoDigital = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.rbJornada = New System.Windows.Forms.RadioButton()
        Me.rbFecha = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtFechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtFechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtJornadaHasta = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtJornadaDesde = New System.Windows.Forms.TextBox()
        Me.btnCierreZ = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.FHasta = New System.Windows.Forms.DateTimePicker()
        Me.FDesde = New System.Windows.Forms.DateTimePicker()
        Me.btn_Exportar = New System.Windows.Forms.Button()
        Me.BtnFiltrar = New System.Windows.Forms.Button()
        Me.dgTickets = New System.Windows.Forms.DataGridView()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroFacturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocalidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FacturacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lbl_Msg = New System.Windows.Forms.Label()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.TableLayoutPanel10.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.dgTickets, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.btnCierreZ)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.lblEstado)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(860, 226)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Reportes Controlador Fiscal"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TableLayoutPanel7)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 58)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(836, 162)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Reportes"
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 1
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.TableLayoutPanel10, 0, 1)
        Me.TableLayoutPanel7.Controls.Add(Me.TableLayoutPanel1, 0, 0)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 2
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(830, 143)
        Me.TableLayoutPanel7.TabIndex = 0
        '
        'TableLayoutPanel10
        '
        Me.TableLayoutPanel10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel10.ColumnCount = 5
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel10.Controls.Add(Me.btnCierreZPorFecha, 0, 0)
        Me.TableLayoutPanel10.Controls.Add(Me.btnInformacionDeTransacciones, 4, 0)
        Me.TableLayoutPanel10.Controls.Add(Me.btnResumenDeTotales, 3, 0)
        Me.TableLayoutPanel10.Controls.Add(Me.btnDuplicadosDocumentosA, 2, 0)
        Me.TableLayoutPanel10.Controls.Add(Me.btnCintaTestigoDigital, 1, 0)
        Me.TableLayoutPanel10.Location = New System.Drawing.Point(3, 96)
        Me.TableLayoutPanel10.Name = "TableLayoutPanel10"
        Me.TableLayoutPanel10.RowCount = 1
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel10.Size = New System.Drawing.Size(824, 44)
        Me.TableLayoutPanel10.TabIndex = 7
        '
        'btnCierreZPorFecha
        '
        Me.btnCierreZPorFecha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCierreZPorFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCierreZPorFecha.Location = New System.Drawing.Point(3, 3)
        Me.btnCierreZPorFecha.Name = "btnCierreZPorFecha"
        Me.btnCierreZPorFecha.Size = New System.Drawing.Size(157, 38)
        Me.btnCierreZPorFecha.TabIndex = 12
        Me.btnCierreZPorFecha.Text = "Informe Cierre Z"
        Me.btnCierreZPorFecha.UseVisualStyleBackColor = True
        '
        'btnInformacionDeTransacciones
        '
        Me.btnInformacionDeTransacciones.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInformacionDeTransacciones.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInformacionDeTransacciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInformacionDeTransacciones.Location = New System.Drawing.Point(659, 3)
        Me.btnInformacionDeTransacciones.Name = "btnInformacionDeTransacciones"
        Me.btnInformacionDeTransacciones.Size = New System.Drawing.Size(162, 38)
        Me.btnInformacionDeTransacciones.TabIndex = 16
        Me.btnInformacionDeTransacciones.Text = "Información de Transacciones "
        Me.btnInformacionDeTransacciones.UseVisualStyleBackColor = True
        '
        'btnResumenDeTotales
        '
        Me.btnResumenDeTotales.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnResumenDeTotales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnResumenDeTotales.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResumenDeTotales.Location = New System.Drawing.Point(495, 3)
        Me.btnResumenDeTotales.Name = "btnResumenDeTotales"
        Me.btnResumenDeTotales.Size = New System.Drawing.Size(158, 38)
        Me.btnResumenDeTotales.TabIndex = 15
        Me.btnResumenDeTotales.Text = "Resumen de Totales"
        Me.btnResumenDeTotales.UseVisualStyleBackColor = True
        '
        'btnDuplicadosDocumentosA
        '
        Me.btnDuplicadosDocumentosA.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDuplicadosDocumentosA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDuplicadosDocumentosA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDuplicadosDocumentosA.Location = New System.Drawing.Point(331, 3)
        Me.btnDuplicadosDocumentosA.Name = "btnDuplicadosDocumentosA"
        Me.btnDuplicadosDocumentosA.Size = New System.Drawing.Size(158, 38)
        Me.btnDuplicadosDocumentosA.TabIndex = 14
        Me.btnDuplicadosDocumentosA.Text = "Duplicados documentos ""A"""
        Me.btnDuplicadosDocumentosA.UseVisualStyleBackColor = True
        '
        'btnCintaTestigoDigital
        '
        Me.btnCintaTestigoDigital.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCintaTestigoDigital.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnCintaTestigoDigital.Location = New System.Drawing.Point(167, 3)
        Me.btnCintaTestigoDigital.Name = "btnCintaTestigoDigital"
        Me.btnCintaTestigoDigital.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnCintaTestigoDigital.Size = New System.Drawing.Size(158, 38)
        Me.btnCintaTestigoDigital.TabIndex = 13
        Me.btnCintaTestigoDigital.Text = "Cinta testigo digital"
        Me.btnCintaTestigoDigital.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 127.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.44444!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 127.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.44444!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.dtFechaHasta, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.dtFechaDesde, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtJornadaHasta, 4, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtJornadaDesde, 4, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(824, 87)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.rbJornada, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.rbFecha, 0, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(130, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(247, 24)
        Me.TableLayoutPanel3.TabIndex = 6
        '
        'rbJornada
        '
        Me.rbJornada.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbJornada.AutoSize = True
        Me.rbJornada.Checked = True
        Me.rbJornada.Location = New System.Drawing.Point(126, 3)
        Me.rbJornada.Name = "rbJornada"
        Me.rbJornada.Size = New System.Drawing.Size(118, 17)
        Me.rbJornada.TabIndex = 16
        Me.rbJornada.TabStop = True
        Me.rbJornada.Text = "Jornada"
        Me.rbJornada.UseVisualStyleBackColor = True
        '
        'rbFecha
        '
        Me.rbFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbFecha.AutoSize = True
        Me.rbFecha.Location = New System.Drawing.Point(3, 3)
        Me.rbFecha.Name = "rbFecha"
        Me.rbFecha.Size = New System.Drawing.Size(117, 17)
        Me.rbFecha.TabIndex = 15
        Me.rbFecha.Text = "Fecha"
        Me.rbFecha.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 16)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Filtrar Por"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Fecha hasta"
        '
        'dtFechaHasta
        '
        Me.dtFechaHasta.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtFechaHasta.Location = New System.Drawing.Point(130, 63)
        Me.dtFechaHasta.Name = "dtFechaHasta"
        Me.dtFechaHasta.Size = New System.Drawing.Size(247, 20)
        Me.dtFechaHasta.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Fecha desde"
        '
        'dtFechaDesde
        '
        Me.dtFechaDesde.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtFechaDesde.Location = New System.Drawing.Point(130, 35)
        Me.dtFechaDesde.Name = "dtFechaDesde"
        Me.dtFechaDesde.Size = New System.Drawing.Size(247, 20)
        Me.dtFechaDesde.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(446, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 16)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Jornada hasta"
        '
        'txtJornadaHasta
        '
        Me.txtJornadaHasta.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtJornadaHasta.Location = New System.Drawing.Point(573, 63)
        Me.txtJornadaHasta.Name = "txtJornadaHasta"
        Me.txtJornadaHasta.Size = New System.Drawing.Size(248, 20)
        Me.txtJornadaHasta.TabIndex = 13
        Me.txtJornadaHasta.Text = "0"
        Me.txtJornadaHasta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(446, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Jornada desde"
        '
        'txtJornadaDesde
        '
        Me.txtJornadaDesde.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtJornadaDesde.Location = New System.Drawing.Point(573, 35)
        Me.txtJornadaDesde.Name = "txtJornadaDesde"
        Me.txtJornadaDesde.Size = New System.Drawing.Size(248, 20)
        Me.txtJornadaDesde.TabIndex = 12
        Me.txtJornadaDesde.Text = "0"
        Me.txtJornadaDesde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnCierreZ
        '
        Me.btnCierreZ.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnCierreZ.Location = New System.Drawing.Point(692, 14)
        Me.btnCierreZ.Name = "btnCierreZ"
        Me.btnCierreZ.Size = New System.Drawing.Size(156, 38)
        Me.btnCierreZ.TabIndex = 0
        Me.btnCierreZ.Text = "Cierre Z día"
        Me.btnCierreZ.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(18, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Estado"
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.Location = New System.Drawing.Point(145, 26)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(39, 15)
        Me.lblEstado.TabIndex = 1
        Me.lblEstado.Text = "- - - -"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox1.Controls.Add(Me.btn_Exportar)
        Me.GroupBox1.Controls.Add(Me.BtnFiltrar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 244)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(860, 83)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tickets"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label12, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label11, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.FHasta, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.FDesde, 1, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(6, 17)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(594, 60)
        Me.TableLayoutPanel2.TabIndex = 6
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(3, 7)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(194, 16)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Fecha desde"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(3, 37)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(194, 16)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Fecha hasta"
        '
        'FHasta
        '
        Me.FHasta.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FHasta.Location = New System.Drawing.Point(203, 35)
        Me.FHasta.Name = "FHasta"
        Me.FHasta.Size = New System.Drawing.Size(388, 20)
        Me.FHasta.TabIndex = 5
        '
        'FDesde
        '
        Me.FDesde.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FDesde.Location = New System.Drawing.Point(203, 5)
        Me.FDesde.Name = "FDesde"
        Me.FDesde.Size = New System.Drawing.Size(388, 20)
        Me.FDesde.TabIndex = 4
        '
        'btn_Exportar
        '
        Me.btn_Exportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Exportar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Exportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Exportar.Image = Global.SistemaCinderella.My.Resources.Recursos.export_excel
        Me.btn_Exportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Exportar.Location = New System.Drawing.Point(606, 26)
        Me.btn_Exportar.Name = "btn_Exportar"
        Me.btn_Exportar.Size = New System.Drawing.Size(121, 40)
        Me.btn_Exportar.TabIndex = 12
        Me.btn_Exportar.Text = "Exportar"
        Me.btn_Exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Exportar.UseVisualStyleBackColor = True
        '
        'BtnFiltrar
        '
        Me.BtnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFiltrar.FlatAppearance.BorderSize = 0
        Me.BtnFiltrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFiltrar.Image = Global.SistemaCinderella.My.Resources.Recursos.IconoBuscar32
        Me.BtnFiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnFiltrar.Location = New System.Drawing.Point(733, 26)
        Me.BtnFiltrar.Name = "BtnFiltrar"
        Me.BtnFiltrar.Size = New System.Drawing.Size(121, 40)
        Me.BtnFiltrar.TabIndex = 10
        Me.BtnFiltrar.Text = "Buscar"
        Me.BtnFiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnFiltrar.UseVisualStyleBackColor = True
        '
        'dgTickets
        '
        Me.dgTickets.AllowUserToAddRows = False
        Me.dgTickets.AllowUserToDeleteRows = False
        Me.dgTickets.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgTickets.AutoGenerateColumns = False
        Me.dgTickets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgTickets.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTickets.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FechaDataGridViewTextBoxColumn, Me.NumeroFacturaDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.DireccionDataGridViewTextBoxColumn, Me.LocalidadDataGridViewTextBoxColumn, Me.CuitDataGridViewTextBoxColumn, Me.SubTotal, Me.IVA, Me.Monto})
        Me.dgTickets.DataSource = Me.FacturacionBindingSource
        Me.dgTickets.Location = New System.Drawing.Point(12, 333)
        Me.dgTickets.Name = "dgTickets"
        Me.dgTickets.ReadOnly = True
        Me.dgTickets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgTickets.Size = New System.Drawing.Size(860, 520)
        Me.dgTickets.TabIndex = 4
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NumeroFacturaDataGridViewTextBoxColumn
        '
        Me.NumeroFacturaDataGridViewTextBoxColumn.DataPropertyName = "NumeroFactura"
        Me.NumeroFacturaDataGridViewTextBoxColumn.HeaderText = "N° Factura"
        Me.NumeroFacturaDataGridViewTextBoxColumn.Name = "NumeroFacturaDataGridViewTextBoxColumn"
        Me.NumeroFacturaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre/Razón Social"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DireccionDataGridViewTextBoxColumn
        '
        Me.DireccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion"
        Me.DireccionDataGridViewTextBoxColumn.HeaderText = "Dirección"
        Me.DireccionDataGridViewTextBoxColumn.Name = "DireccionDataGridViewTextBoxColumn"
        Me.DireccionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LocalidadDataGridViewTextBoxColumn
        '
        Me.LocalidadDataGridViewTextBoxColumn.DataPropertyName = "Localidad"
        Me.LocalidadDataGridViewTextBoxColumn.HeaderText = "Localidad"
        Me.LocalidadDataGridViewTextBoxColumn.Name = "LocalidadDataGridViewTextBoxColumn"
        Me.LocalidadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CuitDataGridViewTextBoxColumn
        '
        Me.CuitDataGridViewTextBoxColumn.DataPropertyName = "Cuit"
        Me.CuitDataGridViewTextBoxColumn.HeaderText = "CUIT"
        Me.CuitDataGridViewTextBoxColumn.Name = "CuitDataGridViewTextBoxColumn"
        Me.CuitDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SubTotal
        '
        Me.SubTotal.DataPropertyName = "SubTotal"
        DataGridViewCellStyle1.Format = "C2"
        Me.SubTotal.DefaultCellStyle = DataGridViewCellStyle1
        Me.SubTotal.HeaderText = "Sub Total"
        Me.SubTotal.Name = "SubTotal"
        Me.SubTotal.ReadOnly = True
        '
        'IVA
        '
        Me.IVA.DataPropertyName = "IVA"
        DataGridViewCellStyle2.Format = "C2"
        Me.IVA.DefaultCellStyle = DataGridViewCellStyle2
        Me.IVA.HeaderText = "IVA"
        Me.IVA.Name = "IVA"
        Me.IVA.ReadOnly = True
        '
        'Monto
        '
        Me.Monto.DataPropertyName = "Monto"
        DataGridViewCellStyle3.Format = "C2"
        Me.Monto.DefaultCellStyle = DataGridViewCellStyle3
        Me.Monto.HeaderText = "Monto Total"
        Me.Monto.Name = "Monto"
        Me.Monto.ReadOnly = True
        '
        'FacturacionBindingSource
        '
        Me.FacturacionBindingSource.DataSource = GetType(Entidades.Facturacion)
        '
        'lbl_Msg
        '
        Me.lbl_Msg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Msg.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lbl_Msg.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Msg.Location = New System.Drawing.Point(279, 529)
        Me.lbl_Msg.Name = "lbl_Msg"
        Me.lbl_Msg.Size = New System.Drawing.Size(327, 128)
        Me.lbl_Msg.TabIndex = 5
        Me.lbl_Msg.Text = "No se han encontrado tickets."
        Me.lbl_Msg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_Msg.Visible = False
        '
        'FolderBrowserDialog
        '
        Me.FolderBrowserDialog.Description = "Seleccione carpeta donde desea guardar el reporte"
        '
        'frmControladorFiscal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 865)
        Me.Controls.Add(Me.lbl_Msg)
        Me.Controls.Add(Me.dgTickets)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmControladorFiscal"
        Me.Text = "Controlador Fiscal"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel10.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.dgTickets, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents FHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents FDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnFiltrar As System.Windows.Forms.Button
    Friend WithEvents dgTickets As System.Windows.Forms.DataGridView
    Friend WithEvents FacturacionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents lbl_Msg As System.Windows.Forms.Label
    Friend WithEvents btn_Exportar As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtFechaHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFechaDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumeroFacturaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DireccionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LocalidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CuitDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SubTotal As DataGridViewTextBoxColumn
    Friend WithEvents IVA As DataGridViewTextBoxColumn
    Friend WithEvents Monto As DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btnInformacionDeTransacciones As Button
    Friend WithEvents btnResumenDeTotales As Button
    Friend WithEvents btnDuplicadosDocumentosA As Button
    Friend WithEvents btnCintaTestigoDigital As Button
    Friend WithEvents FolderBrowserDialog As FolderBrowserDialog
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents btnCierreZ As Button
    Friend WithEvents btnCierreZPorFecha As Button
    Friend WithEvents txtJornadaHasta As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtJornadaDesde As TextBox
    Friend WithEvents TableLayoutPanel10 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents rbJornada As RadioButton
    Friend WithEvents rbFecha As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox3 As GroupBox
End Class
