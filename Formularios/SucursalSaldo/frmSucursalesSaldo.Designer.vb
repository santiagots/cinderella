<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSucursalesSaldo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSucursalesSaldo))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Btn_Salir = New System.Windows.Forms.Button()
        Me.Btn_Limpiar = New System.Windows.Forms.Button()
        Me.lblSucursalNombre = New System.Windows.Forms.Label()
        Me.FrmSucursalesSaldoViewModelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblSucursal = New System.Windows.Forms.Label()
        Me.txt_FDesde = New System.Windows.Forms.DateTimePicker()
        Me.txt_FHasta = New System.Windows.Forms.DateTimePicker()
        Me.Btn_Buscar = New System.Windows.Forms.Button()
        Me.lblFechaH = New System.Windows.Forms.Label()
        Me.lblFechaD = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lbl_TotalEgresos = New System.Windows.Forms.Label()
        Me.lbl_TotalIngresos = New System.Windows.Forms.Label()
        Me.lbl_Saldo = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lbl_DisponibleTotal = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_TotalCajaFuerte = New System.Windows.Forms.Label()
        Me.SaldosSucursal = New SistemaCinderella.SaldosSucursal()
        Me.GroupBox2.SuspendLayout()
        CType(Me.FrmSucursalesSaldoViewModelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Btn_Salir)
        Me.GroupBox2.Controls.Add(Me.Btn_Limpiar)
        Me.GroupBox2.Controls.Add(Me.lblSucursalNombre)
        Me.GroupBox2.Controls.Add(Me.lblSucursal)
        Me.GroupBox2.Controls.Add(Me.txt_FDesde)
        Me.GroupBox2.Controls.Add(Me.txt_FHasta)
        Me.GroupBox2.Controls.Add(Me.Btn_Buscar)
        Me.GroupBox2.Controls.Add(Me.lblFechaH)
        Me.GroupBox2.Controls.Add(Me.lblFechaD)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(962, 120)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Seleccionar el rango de fechas para visualizar los movimientos."
        '
        'Btn_Salir
        '
        Me.Btn_Salir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Salir.Image = Global.SistemaCinderella.My.Resources.Recursos.desconectado_32
        Me.Btn_Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Salir.Location = New System.Drawing.Point(692, 44)
        Me.Btn_Salir.Name = "Btn_Salir"
        Me.Btn_Salir.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Salir.TabIndex = 15
        Me.Btn_Salir.Text = "Salir"
        Me.Btn_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Salir.UseVisualStyleBackColor = True
        '
        'Btn_Limpiar
        '
        Me.Btn_Limpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Limpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Limpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Limpiar.Image = Global.SistemaCinderella.My.Resources.Recursos.Limpiar_32
        Me.Btn_Limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Limpiar.Location = New System.Drawing.Point(569, 44)
        Me.Btn_Limpiar.Name = "Btn_Limpiar"
        Me.Btn_Limpiar.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Limpiar.TabIndex = 5
        Me.Btn_Limpiar.Text = "Borrar"
        Me.Btn_Limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Limpiar.UseVisualStyleBackColor = True
        '
        'lblSucursalNombre
        '
        Me.lblSucursalNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSucursalNombre.AutoSize = True
        Me.lblSucursalNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmSucursalesSaldoViewModelBindingSource, "Sucursal", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.lblSucursalNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSucursalNombre.Location = New System.Drawing.Point(115, 27)
        Me.lblSucursalNombre.Name = "lblSucursalNombre"
        Me.lblSucursalNombre.Size = New System.Drawing.Size(44, 16)
        Me.lblSucursalNombre.TabIndex = 1
        Me.lblSucursalNombre.Text = "- - - - "
        '
        'FrmSucursalesSaldoViewModelBindingSource
        '
        Me.FrmSucursalesSaldoViewModelBindingSource.DataSource = GetType(SistemaCinderella.Formularios.SucursalSaldo.frmSucursalesSaldoViewModel)
        '
        'lblSucursal
        '
        Me.lblSucursal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSucursal.AutoSize = True
        Me.lblSucursal.Location = New System.Drawing.Point(15, 28)
        Me.lblSucursal.Name = "lblSucursal"
        Me.lblSucursal.Size = New System.Drawing.Size(55, 15)
        Me.lblSucursal.TabIndex = 14
        Me.lblSucursal.Text = "Sucursal"
        '
        'txt_FDesde
        '
        Me.txt_FDesde.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_FDesde.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FrmSucursalesSaldoViewModelBindingSource, "FechaDesde", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_FDesde.Location = New System.Drawing.Point(117, 51)
        Me.txt_FDesde.Name = "txt_FDesde"
        Me.txt_FDesde.Size = New System.Drawing.Size(175, 21)
        Me.txt_FDesde.TabIndex = 2
        '
        'txt_FHasta
        '
        Me.txt_FHasta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_FHasta.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FrmSucursalesSaldoViewModelBindingSource, "FechaHasta", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_FHasta.Location = New System.Drawing.Point(117, 86)
        Me.txt_FHasta.Name = "txt_FHasta"
        Me.txt_FHasta.Size = New System.Drawing.Size(175, 21)
        Me.txt_FHasta.TabIndex = 3
        '
        'Btn_Buscar
        '
        Me.Btn_Buscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Buscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Buscar.Image = Global.SistemaCinderella.My.Resources.Recursos.IconoBuscar32
        Me.Btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Buscar.Location = New System.Drawing.Point(447, 44)
        Me.Btn_Buscar.Name = "Btn_Buscar"
        Me.Btn_Buscar.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Buscar.TabIndex = 4
        Me.Btn_Buscar.Text = "Buscar"
        Me.Btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Buscar.UseVisualStyleBackColor = True
        '
        'lblFechaH
        '
        Me.lblFechaH.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblFechaH.AutoSize = True
        Me.lblFechaH.Location = New System.Drawing.Point(15, 91)
        Me.lblFechaH.Name = "lblFechaH"
        Me.lblFechaH.Size = New System.Drawing.Size(76, 15)
        Me.lblFechaH.TabIndex = 2
        Me.lblFechaH.Text = "Fecha Hasta"
        '
        'lblFechaD
        '
        Me.lblFechaD.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblFechaD.AutoSize = True
        Me.lblFechaD.Location = New System.Drawing.Point(15, 57)
        Me.lblFechaD.Name = "lblFechaD"
        Me.lblFechaD.Size = New System.Drawing.Size(80, 15)
        Me.lblFechaD.TabIndex = 1
        Me.lblFechaD.Text = "Fecha Desde"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 392)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(962, 100)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Totales"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 8
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label14, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_TotalEgresos, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_TotalIngresos, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_Saldo, 7, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label13, 6, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_DisponibleTotal, 7, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label15, 6, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label8, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_TotalCajaFuerte, 4, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(956, 81)
        Me.TableLayoutPanel2.TabIndex = 103
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 20)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "Saldo:"
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(3, 10)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(144, 20)
        Me.Label14.TabIndex = 82
        Me.Label14.Text = "Total Egresos:"
        '
        'lbl_TotalEgresos
        '
        Me.lbl_TotalEgresos.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_TotalEgresos.AutoSize = True
        Me.lbl_TotalEgresos.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmSucursalesSaldoViewModelBindingSource, "TotalEgresos", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.lbl_TotalEgresos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TotalEgresos.Location = New System.Drawing.Point(153, 10)
        Me.lbl_TotalEgresos.Name = "lbl_TotalEgresos"
        Me.lbl_TotalEgresos.Size = New System.Drawing.Size(142, 20)
        Me.lbl_TotalEgresos.TabIndex = 83
        Me.lbl_TotalEgresos.Text = "$ 3.000.000.-"
        Me.lbl_TotalEgresos.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_TotalIngresos
        '
        Me.lbl_TotalIngresos.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_TotalIngresos.AutoSize = True
        Me.lbl_TotalIngresos.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmSucursalesSaldoViewModelBindingSource, "Saldo", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.lbl_TotalIngresos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TotalIngresos.Location = New System.Drawing.Point(153, 50)
        Me.lbl_TotalIngresos.Name = "lbl_TotalIngresos"
        Me.lbl_TotalIngresos.Size = New System.Drawing.Size(142, 20)
        Me.lbl_TotalIngresos.TabIndex = 86
        Me.lbl_TotalIngresos.Text = "$ 3.000.000.-"
        Me.lbl_TotalIngresos.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_Saldo
        '
        Me.lbl_Saldo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Saldo.AutoSize = True
        Me.lbl_Saldo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmSucursalesSaldoViewModelBindingSource, "TotalIngreso", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.lbl_Saldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Saldo.Location = New System.Drawing.Point(809, 10)
        Me.lbl_Saldo.Name = "lbl_Saldo"
        Me.lbl_Saldo.Size = New System.Drawing.Size(144, 20)
        Me.lbl_Saldo.TabIndex = 36
        Me.lbl_Saldo.Text = "$ 3.000.000.-"
        Me.lbl_Saldo.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(659, 10)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(144, 20)
        Me.Label13.TabIndex = 84
        Me.Label13.Text = "Tota Ingresos:"
        '
        'lbl_DisponibleTotal
        '
        Me.lbl_DisponibleTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_DisponibleTotal.AutoSize = True
        Me.lbl_DisponibleTotal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmSucursalesSaldoViewModelBindingSource, "Disponible", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.lbl_DisponibleTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DisponibleTotal.Location = New System.Drawing.Point(809, 50)
        Me.lbl_DisponibleTotal.Name = "lbl_DisponibleTotal"
        Me.lbl_DisponibleTotal.Size = New System.Drawing.Size(144, 20)
        Me.lbl_DisponibleTotal.TabIndex = 87
        Me.lbl_DisponibleTotal.Text = "$ 3.000.000.-"
        Me.lbl_DisponibleTotal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(659, 50)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(144, 20)
        Me.Label15.TabIndex = 85
        Me.Label15.Text = "Disponible:"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(331, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 20)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Total C. Fuerte:"
        '
        'lbl_TotalCajaFuerte
        '
        Me.lbl_TotalCajaFuerte.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_TotalCajaFuerte.AutoSize = True
        Me.lbl_TotalCajaFuerte.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmSucursalesSaldoViewModelBindingSource, "TotalCajaFuerte", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.lbl_TotalCajaFuerte.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TotalCajaFuerte.Location = New System.Drawing.Point(481, 50)
        Me.lbl_TotalCajaFuerte.Name = "lbl_TotalCajaFuerte"
        Me.lbl_TotalCajaFuerte.Size = New System.Drawing.Size(142, 20)
        Me.lbl_TotalCajaFuerte.TabIndex = 89
        Me.lbl_TotalCajaFuerte.Text = "$ 3.000.000.-"
        Me.lbl_TotalCajaFuerte.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'SaldosSucursal
        '
        Me.SaldosSucursal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaldosSucursal.Location = New System.Drawing.Point(12, 138)
        Me.SaldosSucursal.Name = "SaldosSucursal"
        Me.SaldosSucursal.Size = New System.Drawing.Size(962, 248)
        Me.SaldosSucursal.TabIndex = 0
        '
        'frmSucursalesSaldo2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 500)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.SaldosSucursal)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSucursalesSaldo2"
        Me.Text = "Estado de Cuenta de Sucursal"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.FrmSucursalesSaldoViewModelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Btn_Salir As Button
    Friend WithEvents Btn_Limpiar As Button
    Friend WithEvents lblSucursalNombre As Label
    Friend WithEvents lblSucursal As Label
    Friend WithEvents txt_FDesde As DateTimePicker
    Friend WithEvents txt_FHasta As DateTimePicker
    Friend WithEvents Btn_Buscar As Button
    Friend WithEvents lblFechaH As Label
    Friend WithEvents lblFechaD As Label
    Friend WithEvents SaldosSucursal As SaldosSucursal
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label14 As Label
    Friend WithEvents lbl_TotalEgresos As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lbl_Saldo As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents lbl_TotalIngresos As Label
    Friend WithEvents lbl_DisponibleTotal As Label
    Friend WithEvents FrmSucursalesSaldoViewModelBindingSource As BindingSource
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_TotalCajaFuerte As Label
End Class
