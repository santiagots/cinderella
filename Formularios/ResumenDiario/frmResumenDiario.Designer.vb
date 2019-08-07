<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmResumenDiario
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.FrmResumenDiarioViewModelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Btn_Abrir = New System.Windows.Forms.Button()
        Me.Btn_Cerrar = New System.Windows.Forms.Button()
        Me.Btn_Salir = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Btn_Limpiar = New System.Windows.Forms.Button()
        Me.lblSucursalNombre = New System.Windows.Forms.Label()
        Me.lblSucursal = New System.Windows.Forms.Label()
        Me.txt_Fecha = New System.Windows.Forms.DateTimePicker()
        Me.Btn_Buscar = New System.Windows.Forms.Button()
        Me.lblFechaD = New System.Windows.Forms.Label()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.GB_Monto = New System.Windows.Forms.GroupBox()
        Me.lbl_Saldo = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lbl_DispoEfect = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_DispoCheq = New System.Windows.Forms.Label()
        Me.GB_Caja = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_Empleado = New System.Windows.Forms.Label()
        Me.lbl_Fecha = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SaldosSucursal = New SistemaCinderella.SaldosSucursal()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.FrmResumenDiarioViewModelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.GB_Monto.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GB_Caja.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel6.ColumnCount = 2
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.GroupBox3, 1, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.GroupBox2, 0, 0)
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(10, 12)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 159.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(962, 159)
        Me.TableLayoutPanel6.TabIndex = 75
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtMonto)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Btn_Abrir)
        Me.GroupBox3.Controls.Add(Me.Btn_Cerrar)
        Me.GroupBox3.Controls.Add(Me.Btn_Salir)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(484, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(475, 153)
        Me.GroupBox3.TabIndex = 71
        Me.GroupBox3.TabStop = False
        '
        'txtMonto
        '
        Me.txtMonto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMonto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmResumenDiarioViewModelBindingSource, "Importe", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.txtMonto.Location = New System.Drawing.Point(275, 83)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(194, 20)
        Me.txtMonto.TabIndex = 66
        '
        'FrmResumenDiarioViewModelBindingSource
        '
        Me.FrmResumenDiarioViewModelBindingSource.DataSource = GetType(SistemaCinderella.Formularios.ResumenDiario.frmResumenDiarioViewModel)
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(171, 86)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(98, 15)
        Me.Label14.TabIndex = 65
        Me.Label14.Text = "Importe Físico"
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(174, 17)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(295, 65)
        Me.Label13.TabIndex = 64
        Me.Label13.Text = "Por favor, ingrese el monto físico que se encuentra en la sucursal para cerrar la" &
    " caja."
        '
        'Btn_Abrir
        '
        Me.Btn_Abrir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Abrir.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.FrmResumenDiarioViewModelBindingSource, "HabilitarAbrirCaja", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Btn_Abrir.Enabled = False
        Me.Btn_Abrir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Abrir.Image = Global.SistemaCinderella.My.Resources.Recursos.AbrirCaja_32
        Me.Btn_Abrir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Abrir.Location = New System.Drawing.Point(12, 17)
        Me.Btn_Abrir.Name = "Btn_Abrir"
        Me.Btn_Abrir.Size = New System.Drawing.Size(140, 39)
        Me.Btn_Abrir.TabIndex = 63
        Me.Btn_Abrir.Text = "Abrir Caja"
        Me.Btn_Abrir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Abrir.UseVisualStyleBackColor = True
        '
        'Btn_Cerrar
        '
        Me.Btn_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Cerrar.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.FrmResumenDiarioViewModelBindingSource, "HabilitarCerrarCaja", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Btn_Cerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Cerrar.Image = Global.SistemaCinderella.My.Resources.Recursos.CerrarCaja_32
        Me.Btn_Cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Cerrar.Location = New System.Drawing.Point(12, 58)
        Me.Btn_Cerrar.Name = "Btn_Cerrar"
        Me.Btn_Cerrar.Size = New System.Drawing.Size(140, 39)
        Me.Btn_Cerrar.TabIndex = 62
        Me.Btn_Cerrar.Text = "Cerrar Caja"
        Me.Btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Cerrar.UseVisualStyleBackColor = True
        '
        'Btn_Salir
        '
        Me.Btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Salir.Image = Global.SistemaCinderella.My.Resources.Recursos.desconectado_32
        Me.Btn_Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Salir.Location = New System.Drawing.Point(12, 99)
        Me.Btn_Salir.Name = "Btn_Salir"
        Me.Btn_Salir.Size = New System.Drawing.Size(140, 39)
        Me.Btn_Salir.TabIndex = 17
        Me.Btn_Salir.Text = "Salir"
        Me.Btn_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Salir.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Btn_Limpiar)
        Me.GroupBox2.Controls.Add(Me.lblSucursalNombre)
        Me.GroupBox2.Controls.Add(Me.lblSucursal)
        Me.GroupBox2.Controls.Add(Me.txt_Fecha)
        Me.GroupBox2.Controls.Add(Me.Btn_Buscar)
        Me.GroupBox2.Controls.Add(Me.lblFechaD)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(475, 153)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Seleccione la fecha que desea visualizar el resumen diario."
        '
        'Btn_Limpiar
        '
        Me.Btn_Limpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Limpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Limpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Limpiar.Image = Global.SistemaCinderella.My.Resources.Recursos.Update_32
        Me.Btn_Limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Limpiar.Location = New System.Drawing.Point(337, 90)
        Me.Btn_Limpiar.Name = "Btn_Limpiar"
        Me.Btn_Limpiar.Size = New System.Drawing.Size(120, 39)
        Me.Btn_Limpiar.TabIndex = 3
        Me.Btn_Limpiar.Text = "Actualizar"
        Me.Btn_Limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Limpiar.UseVisualStyleBackColor = True
        '
        'lblSucursalNombre
        '
        Me.lblSucursalNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSucursalNombre.AutoSize = True
        Me.lblSucursalNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmResumenDiarioViewModelBindingSource, "Sucursal", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.lblSucursalNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSucursalNombre.Location = New System.Drawing.Point(70, 50)
        Me.lblSucursalNombre.Name = "lblSucursalNombre"
        Me.lblSucursalNombre.Size = New System.Drawing.Size(44, 16)
        Me.lblSucursalNombre.TabIndex = 1
        Me.lblSucursalNombre.Text = "- - - - "
        '
        'lblSucursal
        '
        Me.lblSucursal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSucursal.AutoSize = True
        Me.lblSucursal.Location = New System.Drawing.Point(6, 50)
        Me.lblSucursal.Name = "lblSucursal"
        Me.lblSucursal.Size = New System.Drawing.Size(55, 15)
        Me.lblSucursal.TabIndex = 14
        Me.lblSucursal.Text = "Sucursal"
        '
        'txt_Fecha
        '
        Me.txt_Fecha.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Fecha.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FrmResumenDiarioViewModelBindingSource, "Fecha", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_Fecha.Location = New System.Drawing.Point(73, 86)
        Me.txt_Fecha.Name = "txt_Fecha"
        Me.txt_Fecha.Size = New System.Drawing.Size(243, 21)
        Me.txt_Fecha.TabIndex = 2
        '
        'Btn_Buscar
        '
        Me.Btn_Buscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Buscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Buscar.Image = Global.SistemaCinderella.My.Resources.Recursos.IconoBuscar32
        Me.Btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Buscar.Location = New System.Drawing.Point(337, 27)
        Me.Btn_Buscar.Name = "Btn_Buscar"
        Me.Btn_Buscar.Size = New System.Drawing.Size(120, 39)
        Me.Btn_Buscar.TabIndex = 4
        Me.Btn_Buscar.Text = "Buscar"
        Me.Btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Buscar.UseVisualStyleBackColor = True
        '
        'lblFechaD
        '
        Me.lblFechaD.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblFechaD.AutoSize = True
        Me.lblFechaD.Location = New System.Drawing.Point(6, 91)
        Me.lblFechaD.Name = "lblFechaD"
        Me.lblFechaD.Size = New System.Drawing.Size(41, 15)
        Me.lblFechaD.TabIndex = 1
        Me.lblFechaD.Text = "Fecha"
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel5.ColumnCount = 4
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.22245!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.38461!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.80042!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.48857!))
        Me.TableLayoutPanel5.Controls.Add(Me.GB_Monto, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.GroupBox4, 3, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.GroupBox1, 2, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.GB_Caja, 0, 0)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(7, 466)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(962, 100)
        Me.TableLayoutPanel5.TabIndex = 76
        '
        'GB_Monto
        '
        Me.GB_Monto.Controls.Add(Me.lbl_Saldo)
        Me.GB_Monto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GB_Monto.Location = New System.Drawing.Point(515, 3)
        Me.GB_Monto.Name = "GB_Monto"
        Me.GB_Monto.Size = New System.Drawing.Size(142, 94)
        Me.GB_Monto.TabIndex = 66
        Me.GB_Monto.TabStop = False
        Me.GB_Monto.Text = "Caja Chica"
        '
        'lbl_Saldo
        '
        Me.lbl_Saldo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmResumenDiarioViewModelBindingSource, "CajaChica", True))
        Me.lbl_Saldo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Saldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Saldo.Location = New System.Drawing.Point(3, 16)
        Me.lbl_Saldo.Name = "lbl_Saldo"
        Me.lbl_Saldo.Size = New System.Drawing.Size(136, 75)
        Me.lbl_Saldo.TabIndex = 0
        Me.lbl_Saldo.Text = "$ 100.000.-"
        Me.lbl_Saldo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lbl_DispoEfect)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Location = New System.Drawing.Point(815, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(144, 94)
        Me.GroupBox4.TabIndex = 68
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Disp. Efectivo"
        '
        'lbl_DispoEfect
        '
        Me.lbl_DispoEfect.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmResumenDiarioViewModelBindingSource, "DisponibleEfectivo", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.lbl_DispoEfect.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_DispoEfect.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DispoEfect.Location = New System.Drawing.Point(3, 16)
        Me.lbl_DispoEfect.Name = "lbl_DispoEfect"
        Me.lbl_DispoEfect.Size = New System.Drawing.Size(138, 75)
        Me.lbl_DispoEfect.TabIndex = 0
        Me.lbl_DispoEfect.Text = "$ 100.000.-"
        Me.lbl_DispoEfect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_DispoCheq)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(663, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(146, 94)
        Me.GroupBox1.TabIndex = 67
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Disp. Cheque"
        '
        'lbl_DispoCheq
        '
        Me.lbl_DispoCheq.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmResumenDiarioViewModelBindingSource, "DisponibleCheque", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
        Me.lbl_DispoCheq.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_DispoCheq.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DispoCheq.Location = New System.Drawing.Point(3, 16)
        Me.lbl_DispoCheq.Name = "lbl_DispoCheq"
        Me.lbl_DispoCheq.Size = New System.Drawing.Size(140, 75)
        Me.lbl_DispoCheq.TabIndex = 0
        Me.lbl_DispoCheq.Text = "$ 100.000.-"
        Me.lbl_DispoCheq.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GB_Caja
        '
        Me.GB_Caja.Controls.Add(Me.Label1)
        Me.GB_Caja.Controls.Add(Me.Label2)
        Me.GB_Caja.Controls.Add(Me.lbl_Empleado)
        Me.GB_Caja.Controls.Add(Me.lbl_Fecha)
        Me.GB_Caja.Controls.Add(Me.Label9)
        Me.GB_Caja.Controls.Add(Me.Label7)
        Me.GB_Caja.DataBindings.Add(New System.Windows.Forms.Binding("Visible", Me.FrmResumenDiarioViewModelBindingSource, "VisibleCajaCerrada", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.GB_Caja.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GB_Caja.Location = New System.Drawing.Point(3, 3)
        Me.GB_Caja.Name = "GB_Caja"
        Me.GB_Caja.Size = New System.Drawing.Size(506, 94)
        Me.GB_Caja.TabIndex = 65
        Me.GB_Caja.TabStop = False
        Me.GB_Caja.Text = "Caja Cerrada"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmResumenDiarioViewModelBindingSource, "NombreEmpleadoCajaReabierta", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Label1.DataBindings.Add(New System.Windows.Forms.Binding("Visible", Me.FrmResumenDiarioViewModelBindingSource, "VisibleCajaReabierta", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(381, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 15)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Gutierrez"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.DataBindings.Add(New System.Windows.Forms.Binding("Visible", Me.FrmResumenDiarioViewModelBindingSource, "VisibleCajaReabierta", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(381, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 18)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "Reabierta por"
        '
        'lbl_Empleado
        '
        Me.lbl_Empleado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Empleado.AutoSize = True
        Me.lbl_Empleado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmResumenDiarioViewModelBindingSource, "NombreEmpleadoCierre", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.lbl_Empleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Empleado.Location = New System.Drawing.Point(192, 47)
        Me.lbl_Empleado.Name = "lbl_Empleado"
        Me.lbl_Empleado.Size = New System.Drawing.Size(57, 15)
        Me.lbl_Empleado.TabIndex = 69
        Me.lbl_Empleado.Text = "Gutierrez"
        '
        'lbl_Fecha
        '
        Me.lbl_Fecha.AutoSize = True
        Me.lbl_Fecha.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmResumenDiarioViewModelBindingSource, "FechaCierre", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "G"))
        Me.lbl_Fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Fecha.Location = New System.Drawing.Point(6, 47)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(69, 15)
        Me.lbl_Fecha.TabIndex = 67
        Me.lbl_Fecha.Text = "10/10/1987"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(192, 29)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 18)
        Me.Label9.TabIndex = 66
        Me.Label9.Text = "Cerrada por"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 18)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "Fecha"
        '
        'SaldosSucursal
        '
        Me.SaldosSucursal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaldosSucursal.Location = New System.Drawing.Point(10, 177)
        Me.SaldosSucursal.Name = "SaldosSucursal"
        Me.SaldosSucursal.Size = New System.Drawing.Size(962, 286)
        Me.SaldosSucursal.TabIndex = 77
        '
        'frmResumenDiario3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 578)
        Me.Controls.Add(Me.SaldosSucursal)
        Me.Controls.Add(Me.TableLayoutPanel5)
        Me.Controls.Add(Me.TableLayoutPanel6)
        Me.Name = "frmResumenDiario3"
        Me.Text = "frmResumenDiario3"
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.FrmResumenDiarioViewModelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.GB_Monto.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GB_Caja.ResumeLayout(False)
        Me.GB_Caja.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Btn_Abrir As Button
    Friend WithEvents Btn_Cerrar As Button
    Friend WithEvents Btn_Salir As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Btn_Limpiar As Button
    Friend WithEvents lblSucursalNombre As Label
    Friend WithEvents lblSucursal As Label
    Friend WithEvents txt_Fecha As DateTimePicker
    Friend WithEvents Btn_Buscar As Button
    Friend WithEvents lblFechaD As Label
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents GB_Monto As GroupBox
    Friend WithEvents lbl_Saldo As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents lbl_DispoEfect As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbl_DispoCheq As Label
    Friend WithEvents GB_Caja As GroupBox
    Friend WithEvents lbl_Empleado As Label
    Friend WithEvents lbl_Fecha As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents SaldosSucursal As SaldosSucursal
    Friend WithEvents FrmResumenDiarioViewModelBindingSource As BindingSource
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
