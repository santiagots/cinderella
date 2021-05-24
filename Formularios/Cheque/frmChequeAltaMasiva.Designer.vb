<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChequeAltaMasiva
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChequeAltaMasiva))
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.FrmChequeAltaMasivaViewModelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnAgregarConsecutivo = New System.Windows.Forms.Button()
        Me.ucChequeDetalle = New SistemaCinderella.ChequeDetalle()
        Me.txt_Total = New System.Windows.Forms.TextBox()
        Me.lbl_DescrTot = New System.Windows.Forms.Label()
        Me.dgCheques = New System.Windows.Forms.DataGridView()
        Me.ChequesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_Salir = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.NumeroOrdenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarcaFacturado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteNombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LibradorNombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BancoEmisorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroChequeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaIngresoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDespositoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaVencimientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quitar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.GroupBox.SuspendLayout()
        CType(Me.FrmChequeAltaMasivaViewModelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgCheques, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChequesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox
        '
        Me.GroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox.Controls.Add(Me.btnAgregar)
        Me.GroupBox.Controls.Add(Me.btnAgregarConsecutivo)
        Me.GroupBox.Controls.Add(Me.ucChequeDetalle)
        Me.GroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(860, 420)
        Me.GroupBox.TabIndex = 72
        Me.GroupBox.TabStop = False
        Me.GroupBox.Text = "INFORMACIÓ DE CHEQUE"
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregar.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.FrmChequeAltaMasivaViewModelBindingSource, "HabilitarAgregar", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Image = Global.SistemaCinderella.My.Resources.Recursos.Agregar_24
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.Location = New System.Drawing.Point(637, 374)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(94, 40)
        Me.btnAgregar.TabIndex = 164
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'FrmChequeAltaMasivaViewModelBindingSource
        '
        Me.FrmChequeAltaMasivaViewModelBindingSource.DataSource = GetType(SistemaCinderella.Formularios.Cheque.frmChequeAltaMasivaViewModel)
        '
        'btnAgregarConsecutivo
        '
        Me.btnAgregarConsecutivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarConsecutivo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregarConsecutivo.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.FrmChequeAltaMasivaViewModelBindingSource, "HabilitarAgregar", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnAgregarConsecutivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarConsecutivo.Image = Global.SistemaCinderella.My.Resources.Recursos.Agregar_24
        Me.btnAgregarConsecutivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregarConsecutivo.Location = New System.Drawing.Point(737, 374)
        Me.btnAgregarConsecutivo.Name = "btnAgregarConsecutivo"
        Me.btnAgregarConsecutivo.Size = New System.Drawing.Size(117, 40)
        Me.btnAgregarConsecutivo.TabIndex = 163
        Me.btnAgregarConsecutivo.Text = "Agregar Consecutivo"
        Me.btnAgregarConsecutivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregarConsecutivo.UseVisualStyleBackColor = True
        '
        'ucChequeDetalle
        '
        Me.ucChequeDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ucChequeDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ucChequeDetalle.Location = New System.Drawing.Point(11, 20)
        Me.ucChequeDetalle.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ucChequeDetalle.Name = "ucChequeDetalle"
        Me.ucChequeDetalle.Size = New System.Drawing.Size(842, 379)
        Me.ucChequeDetalle.TabIndex = 0
        '
        'txt_Total
        '
        Me.txt_Total.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Total.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmChequeAltaMasivaViewModelBindingSource, "Total", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.txt_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Total.Location = New System.Drawing.Point(519, 6)
        Me.txt_Total.Name = "txt_Total"
        Me.txt_Total.ReadOnly = True
        Me.txt_Total.Size = New System.Drawing.Size(138, 26)
        Me.txt_Total.TabIndex = 80
        Me.txt_Total.Text = "0,00"
        Me.txt_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl_DescrTot
        '
        Me.lbl_DescrTot.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_DescrTot.AutoSize = True
        Me.lbl_DescrTot.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DescrTot.Location = New System.Drawing.Point(349, 10)
        Me.lbl_DescrTot.Name = "lbl_DescrTot"
        Me.lbl_DescrTot.Size = New System.Drawing.Size(164, 19)
        Me.lbl_DescrTot.TabIndex = 79
        Me.lbl_DescrTot.Text = "TOTAL:"
        '
        'dgCheques
        '
        Me.dgCheques.AllowUserToAddRows = False
        Me.dgCheques.AllowUserToDeleteRows = False
        Me.dgCheques.AllowUserToResizeColumns = False
        Me.dgCheques.AllowUserToResizeRows = False
        Me.dgCheques.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgCheques.AutoGenerateColumns = False
        Me.dgCheques.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCheques.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumeroOrdenDataGridViewTextBoxColumn, Me.MarcaFacturado, Me.ClienteNombreDataGridViewTextBoxColumn, Me.LibradorNombreDataGridViewTextBoxColumn, Me.BancoEmisorDataGridViewTextBoxColumn, Me.NumeroChequeDataGridViewTextBoxColumn, Me.FechaIngresoDataGridViewTextBoxColumn, Me.FechaDespositoDataGridViewTextBoxColumn, Me.FechaVencimientoDataGridViewTextBoxColumn, Me.MontoDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn, Me.Quitar})
        Me.dgCheques.DataSource = Me.ChequesBindingSource
        Me.dgCheques.Location = New System.Drawing.Point(12, 438)
        Me.dgCheques.Name = "dgCheques"
        Me.dgCheques.ReadOnly = True
        Me.dgCheques.Size = New System.Drawing.Size(860, 281)
        Me.dgCheques.TabIndex = 78
        '
        'ChequesBindingSource
        '
        Me.ChequesBindingSource.DataMember = "Cheques"
        Me.ChequesBindingSource.DataSource = Me.FrmChequeAltaMasivaViewModelBindingSource
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 7
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Total, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_DescrTot, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Btn_Salir, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnAceptar, 6, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 725)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(860, 39)
        Me.TableLayoutPanel1.TabIndex = 82
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmChequeAltaMasivaViewModelBindingSource, "TotalAPagar", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(173, 6)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(138, 26)
        Me.TextBox1.TabIndex = 82
        Me.TextBox1.Text = "0,00"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 19)
        Me.Label1.TabIndex = 81
        Me.Label1.Text = "TOTAL A PAGAR:"
        '
        'Btn_Salir
        '
        Me.Btn_Salir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Salir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Btn_Salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Salir.Image = Global.SistemaCinderella.My.Resources.Recursos.desconectado_32
        Me.Btn_Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Salir.Location = New System.Drawing.Point(663, 3)
        Me.Btn_Salir.Name = "Btn_Salir"
        Me.Btn_Salir.Size = New System.Drawing.Size(94, 33)
        Me.Btn_Salir.TabIndex = 83
        Me.Btn_Salir.Text = "Salir"
        Me.Btn_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Salir.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAceptar.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.FrmChequeAltaMasivaViewModelBindingSource, "HabilitarFinalizar", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Image = Global.SistemaCinderella.My.Resources.Recursos.Conectado_32
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.Location = New System.Drawing.Point(763, 3)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(94, 33)
        Me.btnAceptar.TabIndex = 84
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'NumeroOrdenDataGridViewTextBoxColumn
        '
        Me.NumeroOrdenDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.NumeroOrdenDataGridViewTextBoxColumn.DataPropertyName = "NumeroOrden"
        Me.NumeroOrdenDataGridViewTextBoxColumn.HeaderText = "N°"
        Me.NumeroOrdenDataGridViewTextBoxColumn.Name = "NumeroOrdenDataGridViewTextBoxColumn"
        Me.NumeroOrdenDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumeroOrdenDataGridViewTextBoxColumn.Width = 5
        '
        'MarcaFacturado
        '
        Me.MarcaFacturado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MarcaFacturado.DataPropertyName = "MarcaFacturado"
        Me.MarcaFacturado.HeaderText = "M. Fact"
        Me.MarcaFacturado.Name = "MarcaFacturado"
        Me.MarcaFacturado.ReadOnly = True
        Me.MarcaFacturado.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MarcaFacturado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.MarcaFacturado.Width = 49
        '
        'ClienteNombreDataGridViewTextBoxColumn
        '
        Me.ClienteNombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ClienteNombreDataGridViewTextBoxColumn.DataPropertyName = "ClienteNombre"
        Me.ClienteNombreDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.ClienteNombreDataGridViewTextBoxColumn.Name = "ClienteNombreDataGridViewTextBoxColumn"
        Me.ClienteNombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LibradorNombreDataGridViewTextBoxColumn
        '
        Me.LibradorNombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.LibradorNombreDataGridViewTextBoxColumn.DataPropertyName = "LibradorNombre"
        Me.LibradorNombreDataGridViewTextBoxColumn.HeaderText = "Librador"
        Me.LibradorNombreDataGridViewTextBoxColumn.Name = "LibradorNombreDataGridViewTextBoxColumn"
        Me.LibradorNombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BancoEmisorDataGridViewTextBoxColumn
        '
        Me.BancoEmisorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.BancoEmisorDataGridViewTextBoxColumn.DataPropertyName = "BancoEmisor"
        Me.BancoEmisorDataGridViewTextBoxColumn.HeaderText = "Banco"
        Me.BancoEmisorDataGridViewTextBoxColumn.Name = "BancoEmisorDataGridViewTextBoxColumn"
        Me.BancoEmisorDataGridViewTextBoxColumn.ReadOnly = True
        Me.BancoEmisorDataGridViewTextBoxColumn.Width = 63
        '
        'NumeroChequeDataGridViewTextBoxColumn
        '
        Me.NumeroChequeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NumeroChequeDataGridViewTextBoxColumn.DataPropertyName = "NumeroCheque"
        Me.NumeroChequeDataGridViewTextBoxColumn.HeaderText = "Num."
        Me.NumeroChequeDataGridViewTextBoxColumn.Name = "NumeroChequeDataGridViewTextBoxColumn"
        Me.NumeroChequeDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumeroChequeDataGridViewTextBoxColumn.Width = 57
        '
        'FechaIngresoDataGridViewTextBoxColumn
        '
        Me.FechaIngresoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FechaIngresoDataGridViewTextBoxColumn.DataPropertyName = "FechaIngreso"
        DataGridViewCellStyle1.Format = "dd/MM/yyyy"
        Me.FechaIngresoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.FechaIngresoDataGridViewTextBoxColumn.HeaderText = "F. Ingreso"
        Me.FechaIngresoDataGridViewTextBoxColumn.Name = "FechaIngresoDataGridViewTextBoxColumn"
        Me.FechaIngresoDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaIngresoDataGridViewTextBoxColumn.Width = 79
        '
        'FechaDespositoDataGridViewTextBoxColumn
        '
        Me.FechaDespositoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FechaDespositoDataGridViewTextBoxColumn.DataPropertyName = "FechaDesposito"
        DataGridViewCellStyle2.Format = "dd/MM/yyyy"
        Me.FechaDespositoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.FechaDespositoDataGridViewTextBoxColumn.HeaderText = "F. Despósito"
        Me.FechaDespositoDataGridViewTextBoxColumn.Name = "FechaDespositoDataGridViewTextBoxColumn"
        Me.FechaDespositoDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaDespositoDataGridViewTextBoxColumn.Width = 91
        '
        'FechaVencimientoDataGridViewTextBoxColumn
        '
        Me.FechaVencimientoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FechaVencimientoDataGridViewTextBoxColumn.DataPropertyName = "FechaVencimiento"
        DataGridViewCellStyle3.Format = "dd/MM/yyyy"
        Me.FechaVencimientoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.FechaVencimientoDataGridViewTextBoxColumn.HeaderText = "F. Vto"
        Me.FechaVencimientoDataGridViewTextBoxColumn.Name = "FechaVencimientoDataGridViewTextBoxColumn"
        Me.FechaVencimientoDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaVencimientoDataGridViewTextBoxColumn.Width = 60
        '
        'MontoDataGridViewTextBoxColumn
        '
        Me.MontoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MontoDataGridViewTextBoxColumn.DataPropertyName = "Monto"
        DataGridViewCellStyle4.Format = "C2"
        Me.MontoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.MontoDataGridViewTextBoxColumn.HeaderText = "Monto"
        Me.MontoDataGridViewTextBoxColumn.Name = "MontoDataGridViewTextBoxColumn"
        Me.MontoDataGridViewTextBoxColumn.ReadOnly = True
        Me.MontoDataGridViewTextBoxColumn.Width = 62
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        Me.EstadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.EstadoDataGridViewTextBoxColumn.Width = 65
        '
        'Quitar
        '
        Me.Quitar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Quitar.HeaderText = ""
        Me.Quitar.Image = Global.SistemaCinderella.My.Resources.Recursos.Boton_Eliminar
        Me.Quitar.Name = "Quitar"
        Me.Quitar.ReadOnly = True
        Me.Quitar.Width = 5
        '
        'frmChequeAltaMasiva
        '
        Me.AcceptButton = Me.btnAgregarConsecutivo
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Btn_Salir
        Me.ClientSize = New System.Drawing.Size(892, 773)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.dgCheques)
        Me.Controls.Add(Me.GroupBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmChequeAltaMasiva"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta de Cheques"
        Me.GroupBox.ResumeLayout(False)
        CType(Me.FrmChequeAltaMasivaViewModelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgCheques, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChequesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucChequeDetalle As ChequeDetalle
    Friend WithEvents GroupBox As GroupBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnAgregarConsecutivo As Button
    Friend WithEvents txt_Total As TextBox
    Friend WithEvents lbl_DescrTot As Label
    Friend WithEvents dgCheques As DataGridView
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents FrmChequeAltaMasivaViewModelBindingSource As BindingSource
    Friend WithEvents ChequesBindingSource As BindingSource
    Friend WithEvents Btn_Salir As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents NumeroOrdenDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MarcaFacturado As DataGridViewTextBoxColumn
    Friend WithEvents ClienteNombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LibradorNombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BancoEmisorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumeroChequeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaIngresoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDespositoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaVencimientoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MontoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Quitar As DataGridViewImageColumn
End Class
