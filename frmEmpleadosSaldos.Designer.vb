<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmpleadosSaldos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmpleadosSaldos))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtDate = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.CbEmpleados = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GbSueldoTrabajado = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnAdicionales = New System.Windows.Forms.Button()
        Me.txt_subto = New System.Windows.Forms.TextBox()
        Me.BtnVacaciones = New System.Windows.Forms.Button()
        Me.txt_Presentismo = New System.Windows.Forms.TextBox()
        Me.BtnAguinaldo = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnComisiones = New System.Windows.Forms.Button()
        Me.BtnFeriados = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnRegulares = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_Adicionales = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_Vacaciones = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_Aguinaldo = New System.Windows.Forms.TextBox()
        Me.txt_Dias = New System.Windows.Forms.TextBox()
        Me.txt_DiasFeriados = New System.Windows.Forms.TextBox()
        Me.txt_Comisiones = New System.Windows.Forms.TextBox()
        Me.btn_depositar = New System.Windows.Forms.Button()
        Me.txt_Deuda = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_sueldoMano = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.BtnAdelantos = New System.Windows.Forms.Button()
        Me.txt_Saldo = New System.Windows.Forms.TextBox()
        Me.txt_Adelantos = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ToolEmpleados = New System.Windows.Forms.ToolTip(Me.components)
        Me.GbSueldoAbonado = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnSueldosPagados = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_SueldosPagados = New System.Windows.Forms.TextBox()
        Me.GbSueldoLiquidar = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnPagoMano = New System.Windows.Forms.Button()
        Me.txtDescripcionPagoMano = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblSueldoDepositarMaximo = New System.Windows.Forms.Label()
        Me.lblSueldoPagarManoMaximo = New System.Windows.Forms.Label()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GbSueldoTrabajado.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GbSueldoAbonado.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GbSueldoLiquidar.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtDate)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.BtnBuscar)
        Me.GroupBox1.Controls.Add(Me.CbEmpleados)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(10, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(532, 89)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccionar el empleado y el rango de fechas para visualizar los movimientos."
        '
        'txtDate
        '
        Me.txtDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDate.Location = New System.Drawing.Point(96, 56)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(324, 21)
        Me.txtDate.TabIndex = 13
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(16, 59)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(47, 15)
        Me.Label16.TabIndex = 12
        Me.Label16.Text = "Mes (*)"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.Image = Global.SistemaCinderella.My.Resources.Recursos.IconoBuscar32
        Me.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBuscar.Location = New System.Drawing.Point(426, 39)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(100, 40)
        Me.BtnBuscar.TabIndex = 3
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'CbEmpleados
        '
        Me.CbEmpleados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CbEmpleados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CbEmpleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbEmpleados.FormattingEnabled = True
        Me.CbEmpleados.Location = New System.Drawing.Point(96, 27)
        Me.CbEmpleados.Name = "CbEmpleados"
        Me.CbEmpleados.Size = New System.Drawing.Size(324, 23)
        Me.CbEmpleados.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Empleado"
        '
        'GbSueldoTrabajado
        '
        Me.GbSueldoTrabajado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GbSueldoTrabajado.Controls.Add(Me.TableLayoutPanel1)
        Me.GbSueldoTrabajado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbSueldoTrabajado.Location = New System.Drawing.Point(10, 101)
        Me.GbSueldoTrabajado.Name = "GbSueldoTrabajado"
        Me.GbSueldoTrabajado.Size = New System.Drawing.Size(532, 280)
        Me.GbSueldoTrabajado.TabIndex = 1
        Me.GbSueldoTrabajado.TabStop = False
        Me.GbSueldoTrabajado.Text = "Sueldo Trabajado"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnAdicionales, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_subto, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnVacaciones, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Presentismo, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnAguinaldo, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnComisiones, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnFeriados, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnRegulares, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label12, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Adicionales, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Vacaciones, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label11, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Aguinaldo, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Dias, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_DiasFeriados, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Comisiones, 1, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 17)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 8
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(526, 260)
        Me.TableLayoutPanel1.TabIndex = 33
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(194, 15)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Sueldo Días Hábiles"
        '
        'BtnAdicionales
        '
        Me.BtnAdicionales.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BtnAdicionales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAdicionales.FlatAppearance.BorderSize = 0
        Me.BtnAdicionales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdicionales.Image = Global.SistemaCinderella.My.Resources.Recursos.Detalle_Pequeno
        Me.BtnAdicionales.Location = New System.Drawing.Point(399, 167)
        Me.BtnAdicionales.Name = "BtnAdicionales"
        Me.BtnAdicionales.Size = New System.Drawing.Size(18, 18)
        Me.BtnAdicionales.TabIndex = 29
        Me.BtnAdicionales.Tag = "Ver Detalle"
        Me.BtnAdicionales.UseVisualStyleBackColor = True
        '
        'txt_subto
        '
        Me.txt_subto.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_subto.Location = New System.Drawing.Point(203, 231)
        Me.txt_subto.Name = "txt_subto"
        Me.txt_subto.ReadOnly = True
        Me.txt_subto.Size = New System.Drawing.Size(190, 21)
        Me.txt_subto.TabIndex = 16
        '
        'BtnVacaciones
        '
        Me.BtnVacaciones.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BtnVacaciones.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnVacaciones.FlatAppearance.BorderSize = 0
        Me.BtnVacaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVacaciones.Image = Global.SistemaCinderella.My.Resources.Recursos.Detalle_Pequeno
        Me.BtnVacaciones.Location = New System.Drawing.Point(399, 135)
        Me.BtnVacaciones.Name = "BtnVacaciones"
        Me.BtnVacaciones.Size = New System.Drawing.Size(18, 18)
        Me.BtnVacaciones.TabIndex = 13
        Me.BtnVacaciones.Tag = "Ver Detalle"
        Me.BtnVacaciones.UseVisualStyleBackColor = True
        '
        'txt_Presentismo
        '
        Me.txt_Presentismo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Presentismo.Location = New System.Drawing.Point(203, 197)
        Me.txt_Presentismo.Name = "txt_Presentismo"
        Me.txt_Presentismo.ReadOnly = True
        Me.txt_Presentismo.Size = New System.Drawing.Size(190, 21)
        Me.txt_Presentismo.TabIndex = 15
        '
        'BtnAguinaldo
        '
        Me.BtnAguinaldo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BtnAguinaldo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAguinaldo.FlatAppearance.BorderSize = 0
        Me.BtnAguinaldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAguinaldo.Image = Global.SistemaCinderella.My.Resources.Recursos.Detalle_Pequeno
        Me.BtnAguinaldo.Location = New System.Drawing.Point(399, 103)
        Me.BtnAguinaldo.Name = "BtnAguinaldo"
        Me.BtnAguinaldo.Size = New System.Drawing.Size(18, 18)
        Me.BtnAguinaldo.TabIndex = 11
        Me.BtnAguinaldo.Tag = "Ver Detalle"
        Me.BtnAguinaldo.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(194, 15)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Sueldo Días Feriados"
        '
        'BtnComisiones
        '
        Me.BtnComisiones.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BtnComisiones.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnComisiones.FlatAppearance.BorderSize = 0
        Me.BtnComisiones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnComisiones.Image = Global.SistemaCinderella.My.Resources.Recursos.Detalle_Pequeno
        Me.BtnComisiones.Location = New System.Drawing.Point(399, 71)
        Me.BtnComisiones.Name = "BtnComisiones"
        Me.BtnComisiones.Size = New System.Drawing.Size(18, 18)
        Me.BtnComisiones.TabIndex = 9
        Me.BtnComisiones.Tag = "Ver Detalle"
        Me.BtnComisiones.UseVisualStyleBackColor = True
        '
        'BtnFeriados
        '
        Me.BtnFeriados.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BtnFeriados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFeriados.FlatAppearance.BorderSize = 0
        Me.BtnFeriados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFeriados.Image = Global.SistemaCinderella.My.Resources.Recursos.Detalle_Pequeno
        Me.BtnFeriados.Location = New System.Drawing.Point(399, 39)
        Me.BtnFeriados.Name = "BtnFeriados"
        Me.BtnFeriados.Size = New System.Drawing.Size(18, 18)
        Me.BtnFeriados.TabIndex = 7
        Me.BtnFeriados.Tag = "Ver Detalle"
        Me.BtnFeriados.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(194, 15)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Presentismo"
        '
        'BtnRegulares
        '
        Me.BtnRegulares.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BtnRegulares.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRegulares.FlatAppearance.BorderSize = 0
        Me.BtnRegulares.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegulares.Image = Global.SistemaCinderella.My.Resources.Recursos.Detalle_Pequeno
        Me.BtnRegulares.Location = New System.Drawing.Point(399, 7)
        Me.BtnRegulares.Name = "BtnRegulares"
        Me.BtnRegulares.Size = New System.Drawing.Size(18, 18)
        Me.BtnRegulares.TabIndex = 5
        Me.BtnRegulares.Tag = "Ver Detalle"
        Me.BtnRegulares.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(3, 234)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(194, 15)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "Subtotal a percibir"
        '
        'txt_Adicionales
        '
        Me.txt_Adicionales.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Adicionales.Location = New System.Drawing.Point(203, 165)
        Me.txt_Adicionales.Name = "txt_Adicionales"
        Me.txt_Adicionales.ReadOnly = True
        Me.txt_Adicionales.Size = New System.Drawing.Size(190, 21)
        Me.txt_Adicionales.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(194, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Comisiones"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(3, 104)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(194, 15)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Aguinaldo"
        '
        'txt_Vacaciones
        '
        Me.txt_Vacaciones.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Vacaciones.Location = New System.Drawing.Point(203, 133)
        Me.txt_Vacaciones.Name = "txt_Vacaciones"
        Me.txt_Vacaciones.ReadOnly = True
        Me.txt_Vacaciones.Size = New System.Drawing.Size(190, 21)
        Me.txt_Vacaciones.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 136)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(194, 15)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Vacaciones"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(3, 168)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(194, 15)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Adicionales"
        '
        'txt_Aguinaldo
        '
        Me.txt_Aguinaldo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Aguinaldo.Location = New System.Drawing.Point(203, 101)
        Me.txt_Aguinaldo.Name = "txt_Aguinaldo"
        Me.txt_Aguinaldo.ReadOnly = True
        Me.txt_Aguinaldo.Size = New System.Drawing.Size(190, 21)
        Me.txt_Aguinaldo.TabIndex = 10
        '
        'txt_Dias
        '
        Me.txt_Dias.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Dias.Location = New System.Drawing.Point(203, 5)
        Me.txt_Dias.Name = "txt_Dias"
        Me.txt_Dias.ReadOnly = True
        Me.txt_Dias.Size = New System.Drawing.Size(190, 21)
        Me.txt_Dias.TabIndex = 4
        '
        'txt_DiasFeriados
        '
        Me.txt_DiasFeriados.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_DiasFeriados.Location = New System.Drawing.Point(203, 37)
        Me.txt_DiasFeriados.Name = "txt_DiasFeriados"
        Me.txt_DiasFeriados.ReadOnly = True
        Me.txt_DiasFeriados.Size = New System.Drawing.Size(190, 21)
        Me.txt_DiasFeriados.TabIndex = 6
        '
        'txt_Comisiones
        '
        Me.txt_Comisiones.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Comisiones.Location = New System.Drawing.Point(203, 69)
        Me.txt_Comisiones.Name = "txt_Comisiones"
        Me.txt_Comisiones.ReadOnly = True
        Me.txt_Comisiones.Size = New System.Drawing.Size(190, 21)
        Me.txt_Comisiones.TabIndex = 8
        '
        'btn_depositar
        '
        Me.btn_depositar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_depositar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_depositar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_depositar.Image = Global.SistemaCinderella.My.Resources.Recursos.Pagar_48
        Me.btn_depositar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_depositar.Location = New System.Drawing.Point(414, 28)
        Me.btn_depositar.Name = "btn_depositar"
        Me.btn_depositar.Size = New System.Drawing.Size(112, 41)
        Me.btn_depositar.TabIndex = 36
        Me.btn_depositar.Text = "Depositar Sueldo"
        Me.btn_depositar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_depositar.UseVisualStyleBackColor = True
        '
        'txt_Deuda
        '
        Me.txt_Deuda.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Deuda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Deuda.Location = New System.Drawing.Point(203, 68)
        Me.txt_Deuda.Name = "txt_Deuda"
        Me.txt_Deuda.ReadOnly = True
        Me.txt_Deuda.Size = New System.Drawing.Size(190, 21)
        Me.txt_Deuda.TabIndex = 20
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(3, 71)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(194, 15)
        Me.Label14.TabIndex = 34
        Me.Label14.Text = "Deuda Acumulada"
        '
        'txt_sueldoMano
        '
        Me.txt_sueldoMano.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_sueldoMano.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_sueldoMano.Location = New System.Drawing.Point(203, 78)
        Me.txt_sueldoMano.Name = "txt_sueldoMano"
        Me.txt_sueldoMano.Size = New System.Drawing.Size(193, 21)
        Me.txt_sueldoMano.TabIndex = 22
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(3, 80)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(194, 15)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Sueldo a pagar en Mano (*)"
        '
        'BtnAdelantos
        '
        Me.BtnAdelantos.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BtnAdelantos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAdelantos.FlatAppearance.BorderSize = 0
        Me.BtnAdelantos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdelantos.Image = Global.SistemaCinderella.My.Resources.Recursos.Detalle_Pequeno
        Me.BtnAdelantos.Location = New System.Drawing.Point(399, 6)
        Me.BtnAdelantos.Name = "BtnAdelantos"
        Me.BtnAdelantos.Size = New System.Drawing.Size(18, 18)
        Me.BtnAdelantos.TabIndex = 18
        Me.BtnAdelantos.Tag = "Ver Detalle"
        Me.BtnAdelantos.UseVisualStyleBackColor = True
        '
        'txt_Saldo
        '
        Me.txt_Saldo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Saldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Saldo.Location = New System.Drawing.Point(203, 3)
        Me.txt_Saldo.Name = "txt_Saldo"
        Me.txt_Saldo.Size = New System.Drawing.Size(193, 21)
        Me.txt_Saldo.TabIndex = 21
        '
        'txt_Adelantos
        '
        Me.txt_Adelantos.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Adelantos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Adelantos.Location = New System.Drawing.Point(203, 5)
        Me.txt_Adelantos.Name = "txt_Adelantos"
        Me.txt_Adelantos.ReadOnly = True
        Me.txt_Adelantos.Size = New System.Drawing.Size(190, 21)
        Me.txt_Adelantos.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 5)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(194, 15)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Sueldo a Depositar (*)"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(194, 15)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Adelantos Pagados"
        '
        'ToolEmpleados
        '
        Me.ToolEmpleados.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolEmpleados.ToolTipTitle = "Ayuda"
        '
        'GbSueldoAbonado
        '
        Me.GbSueldoAbonado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GbSueldoAbonado.Controls.Add(Me.TableLayoutPanel2)
        Me.GbSueldoAbonado.Location = New System.Drawing.Point(10, 387)
        Me.GbSueldoAbonado.Name = "GbSueldoAbonado"
        Me.GbSueldoAbonado.Size = New System.Drawing.Size(532, 114)
        Me.GbSueldoAbonado.TabIndex = 2
        Me.GbSueldoAbonado.TabStop = False
        Me.GbSueldoAbonado.Text = "Sueldo Abonado"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnSueldosPagados, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label15, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnAdelantos, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_Deuda, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_SueldosPagados, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label14, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_Adelantos, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(526, 95)
        Me.TableLayoutPanel2.TabIndex = 40
        '
        'BtnSueldosPagados
        '
        Me.BtnSueldosPagados.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BtnSueldosPagados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSueldosPagados.FlatAppearance.BorderSize = 0
        Me.BtnSueldosPagados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSueldosPagados.Image = Global.SistemaCinderella.My.Resources.Recursos.Detalle_Pequeno
        Me.BtnSueldosPagados.Location = New System.Drawing.Point(399, 37)
        Me.BtnSueldosPagados.Name = "BtnSueldosPagados"
        Me.BtnSueldosPagados.Size = New System.Drawing.Size(18, 18)
        Me.BtnSueldosPagados.TabIndex = 39
        Me.BtnSueldosPagados.Tag = "Ver Detalle"
        Me.BtnSueldosPagados.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(3, 39)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(194, 15)
        Me.Label15.TabIndex = 38
        Me.Label15.Text = "Sueldos Pagados"
        '
        'txt_SueldosPagados
        '
        Me.txt_SueldosPagados.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_SueldosPagados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SueldosPagados.Location = New System.Drawing.Point(203, 36)
        Me.txt_SueldosPagados.Name = "txt_SueldosPagados"
        Me.txt_SueldosPagados.ReadOnly = True
        Me.txt_SueldosPagados.Size = New System.Drawing.Size(190, 21)
        Me.txt_SueldosPagados.TabIndex = 19
        '
        'GbSueldoLiquidar
        '
        Me.GbSueldoLiquidar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GbSueldoLiquidar.Controls.Add(Me.TableLayoutPanel4)
        Me.GbSueldoLiquidar.Controls.Add(Me.TableLayoutPanel3)
        Me.GbSueldoLiquidar.Location = New System.Drawing.Point(10, 507)
        Me.GbSueldoLiquidar.Name = "GbSueldoLiquidar"
        Me.GbSueldoLiquidar.Size = New System.Drawing.Size(532, 218)
        Me.GbSueldoLiquidar.TabIndex = 3
        Me.GbSueldoLiquidar.TabStop = False
        Me.GbSueldoLiquidar.Text = "Sueldos a Liquidar"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.Label17, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label2, 0, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.btnPagoMano, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.txtDescripcionPagoMano, 0, 1)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 126)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 3
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(529, 86)
        Me.TableLayoutPanel4.TabIndex = 43
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(3, 3)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(395, 13)
        Me.Label17.TabIndex = 40
        Me.Label17.Text = "Descripcion (*)"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(395, 13)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "(*) Datos Obligatorios."
        '
        'btnPagoMano
        '
        Me.btnPagoMano.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPagoMano.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPagoMano.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPagoMano.Image = Global.SistemaCinderella.My.Resources.Recursos.Pagar_48
        Me.btnPagoMano.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPagoMano.Location = New System.Drawing.Point(414, 23)
        Me.btnPagoMano.Name = "btnPagoMano"
        Me.btnPagoMano.Size = New System.Drawing.Size(112, 40)
        Me.btnPagoMano.TabIndex = 37
        Me.btnPagoMano.Text = "Pago en Mano"
        Me.btnPagoMano.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPagoMano.UseVisualStyleBackColor = True
        '
        'txtDescripcionPagoMano
        '
        Me.txtDescripcionPagoMano.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDescripcionPagoMano.Location = New System.Drawing.Point(3, 23)
        Me.txtDescripcionPagoMano.Multiline = True
        Me.txtDescripcionPagoMano.Name = "txtDescripcionPagoMano"
        Me.txtDescripcionPagoMano.Size = New System.Drawing.Size(395, 40)
        Me.txtDescripcionPagoMano.TabIndex = 39
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label8, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.txt_Saldo, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.lblSueldoDepositarMaximo, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btn_depositar, 2, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.lblSueldoPagarManoMaximo, 2, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Label13, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.txt_sueldoMano, 1, 2)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 19)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(529, 101)
        Me.TableLayoutPanel3.TabIndex = 42
        '
        'lblSueldoDepositarMaximo
        '
        Me.lblSueldoDepositarMaximo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSueldoDepositarMaximo.AutoSize = True
        Me.lblSueldoDepositarMaximo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSueldoDepositarMaximo.Location = New System.Drawing.Point(402, 5)
        Me.lblSueldoDepositarMaximo.Name = "lblSueldoDepositarMaximo"
        Me.lblSueldoDepositarMaximo.Size = New System.Drawing.Size(124, 15)
        Me.lblSueldoDepositarMaximo.TabIndex = 33
        Me.lblSueldoDepositarMaximo.Text = "Máximo"
        '
        'lblSueldoPagarManoMaximo
        '
        Me.lblSueldoPagarManoMaximo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSueldoPagarManoMaximo.AutoSize = True
        Me.lblSueldoPagarManoMaximo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSueldoPagarManoMaximo.Location = New System.Drawing.Point(402, 80)
        Me.lblSueldoPagarManoMaximo.Name = "lblSueldoPagarManoMaximo"
        Me.lblSueldoPagarManoMaximo.Size = New System.Drawing.Size(124, 15)
        Me.lblSueldoPagarManoMaximo.TabIndex = 38
        Me.lblSueldoPagarManoMaximo.Text = "Sugerido"
        '
        'ErrorProvider
        '
        Me.ErrorProvider.BlinkRate = 200
        Me.ErrorProvider.ContainerControl = Me
        Me.ErrorProvider.RightToLeft = True
        '
        'frmEmpleadosSaldos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 732)
        Me.Controls.Add(Me.GbSueldoLiquidar)
        Me.Controls.Add(Me.GbSueldoAbonado)
        Me.Controls.Add(Me.GbSueldoTrabajado)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(570, 771)
        Me.Name = "frmEmpleadosSaldos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estado de Cuenta de Empleados"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GbSueldoTrabajado.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.GbSueldoAbonado.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.GbSueldoLiquidar.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents CbEmpleados As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GbSueldoTrabajado As System.Windows.Forms.GroupBox
    Friend WithEvents txt_Saldo As System.Windows.Forms.TextBox
    Friend WithEvents txt_Comisiones As System.Windows.Forms.TextBox
    Friend WithEvents txt_Adelantos As System.Windows.Forms.TextBox
    Friend WithEvents txt_Dias As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_DiasFeriados As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BtnComisiones As System.Windows.Forms.Button
    Friend WithEvents BtnAdelantos As System.Windows.Forms.Button
    Friend WithEvents BtnFeriados As System.Windows.Forms.Button
    Friend WithEvents BtnRegulares As System.Windows.Forms.Button
    Friend WithEvents BtnAguinaldo As System.Windows.Forms.Button
    Friend WithEvents txt_Aguinaldo As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents BtnVacaciones As System.Windows.Forms.Button
    Friend WithEvents txt_Vacaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents BtnAdicionales As System.Windows.Forms.Button
    Friend WithEvents txt_Adicionales As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_sueldoMano As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_subto As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_Deuda As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btn_depositar As System.Windows.Forms.Button
    Friend WithEvents ToolEmpleados As System.Windows.Forms.ToolTip
    Friend WithEvents GbSueldoAbonado As System.Windows.Forms.GroupBox
    Friend WithEvents txt_SueldosPagados As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GbSueldoLiquidar As System.Windows.Forms.GroupBox
    Friend WithEvents txt_Presentismo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnSueldosPagados As System.Windows.Forms.Button
    Friend WithEvents lblSueldoDepositarMaximo As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblSueldoPagarManoMaximo As System.Windows.Forms.Label
    Friend WithEvents btnPagoMano As System.Windows.Forms.Button
    Friend WithEvents txtDescripcionPagoMano As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
End Class
