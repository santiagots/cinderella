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
        Me.txt_FDesde = New System.Windows.Forms.DateTimePicker()
        Me.txt_FHasta = New System.Windows.Forms.DateTimePicker()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.CbEmpleados = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GbDetalle = New System.Windows.Forms.GroupBox()
        Me.btn_depositar = New System.Windows.Forms.Button()
        Me.txt_Deuda = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_sueldoMano = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_subto = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.BtnAdicionales = New System.Windows.Forms.Button()
        Me.txt_Adicionales = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.BtnVacaciones = New System.Windows.Forms.Button()
        Me.txt_Vacaciones = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BtnAguinaldo = New System.Windows.Forms.Button()
        Me.txt_Aguinaldo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbl_diasf = New System.Windows.Forms.Label()
        Me.lbl_diasn = New System.Windows.Forms.Label()
        Me.BtnFeriados = New System.Windows.Forms.Button()
        Me.BtnRegulares = New System.Windows.Forms.Button()
        Me.BtnAdelantos = New System.Windows.Forms.Button()
        Me.BtnComisiones = New System.Windows.Forms.Button()
        Me.txt_DiasFeriados = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_Saldo = New System.Windows.Forms.TextBox()
        Me.txt_Comisiones = New System.Windows.Forms.TextBox()
        Me.txt_Adelantos = New System.Windows.Forms.TextBox()
        Me.txt_Dias = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ToolEmpleados = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GbDetalle.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txt_FDesde)
        Me.GroupBox1.Controls.Add(Me.txt_FHasta)
        Me.GroupBox1.Controls.Add(Me.BtnBuscar)
        Me.GroupBox1.Controls.Add(Me.CbEmpleados)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(10, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(532, 137)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccionar el empleado y el rango de fechas para visualizar los movimientos."
        '
        'txt_FDesde
        '
        Me.txt_FDesde.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_FDesde.Location = New System.Drawing.Point(149, 64)
        Me.txt_FDesde.Name = "txt_FDesde"
        Me.txt_FDesde.Size = New System.Drawing.Size(245, 21)
        Me.txt_FDesde.TabIndex = 13
        '
        'txt_FHasta
        '
        Me.txt_FHasta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_FHasta.Location = New System.Drawing.Point(149, 100)
        Me.txt_FHasta.Name = "txt_FHasta"
        Me.txt_FHasta.Size = New System.Drawing.Size(245, 21)
        Me.txt_FHasta.TabIndex = 12
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.Image = Global.SistemaCinderella.My.Resources.Recursos.IconoBuscar32
        Me.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBuscar.Location = New System.Drawing.Point(414, 58)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(100, 40)
        Me.BtnBuscar.TabIndex = 11
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'CbEmpleados
        '
        Me.CbEmpleados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CbEmpleados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CbEmpleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbEmpleados.FormattingEnabled = True
        Me.CbEmpleados.Location = New System.Drawing.Point(149, 27)
        Me.CbEmpleados.Name = "CbEmpleados"
        Me.CbEmpleados.Size = New System.Drawing.Size(245, 23)
        Me.CbEmpleados.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha Hasta"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha Desde"
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
        'GbDetalle
        '
        Me.GbDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GbDetalle.Controls.Add(Me.btn_depositar)
        Me.GbDetalle.Controls.Add(Me.txt_Deuda)
        Me.GbDetalle.Controls.Add(Me.Label14)
        Me.GbDetalle.Controls.Add(Me.txt_sueldoMano)
        Me.GbDetalle.Controls.Add(Me.Label13)
        Me.GbDetalle.Controls.Add(Me.txt_subto)
        Me.GbDetalle.Controls.Add(Me.Label12)
        Me.GbDetalle.Controls.Add(Me.BtnAdicionales)
        Me.GbDetalle.Controls.Add(Me.txt_Adicionales)
        Me.GbDetalle.Controls.Add(Me.Label11)
        Me.GbDetalle.Controls.Add(Me.BtnVacaciones)
        Me.GbDetalle.Controls.Add(Me.txt_Vacaciones)
        Me.GbDetalle.Controls.Add(Me.Label9)
        Me.GbDetalle.Controls.Add(Me.BtnAguinaldo)
        Me.GbDetalle.Controls.Add(Me.txt_Aguinaldo)
        Me.GbDetalle.Controls.Add(Me.Label10)
        Me.GbDetalle.Controls.Add(Me.lbl_diasf)
        Me.GbDetalle.Controls.Add(Me.lbl_diasn)
        Me.GbDetalle.Controls.Add(Me.BtnFeriados)
        Me.GbDetalle.Controls.Add(Me.BtnRegulares)
        Me.GbDetalle.Controls.Add(Me.BtnAdelantos)
        Me.GbDetalle.Controls.Add(Me.BtnComisiones)
        Me.GbDetalle.Controls.Add(Me.txt_DiasFeriados)
        Me.GbDetalle.Controls.Add(Me.Label7)
        Me.GbDetalle.Controls.Add(Me.txt_Saldo)
        Me.GbDetalle.Controls.Add(Me.txt_Comisiones)
        Me.GbDetalle.Controls.Add(Me.txt_Adelantos)
        Me.GbDetalle.Controls.Add(Me.txt_Dias)
        Me.GbDetalle.Controls.Add(Me.Label8)
        Me.GbDetalle.Controls.Add(Me.Label6)
        Me.GbDetalle.Controls.Add(Me.Label5)
        Me.GbDetalle.Controls.Add(Me.Label4)
        Me.GbDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbDetalle.Location = New System.Drawing.Point(10, 149)
        Me.GbDetalle.Name = "GbDetalle"
        Me.GbDetalle.Size = New System.Drawing.Size(532, 381)
        Me.GbDetalle.TabIndex = 1
        Me.GbDetalle.TabStop = False
        Me.GbDetalle.Text = "Detalle del período solicitado"
        '
        'btn_depositar
        '
        Me.btn_depositar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_depositar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_depositar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_depositar.Image = Global.SistemaCinderella.My.Resources.Recursos.Pagar_48
        Me.btn_depositar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_depositar.Location = New System.Drawing.Point(414, 330)
        Me.btn_depositar.Name = "btn_depositar"
        Me.btn_depositar.Size = New System.Drawing.Size(112, 40)
        Me.btn_depositar.TabIndex = 36
        Me.btn_depositar.Text = "Depositar Sueldo"
        Me.btn_depositar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_depositar.UseVisualStyleBackColor = True
        '
        'txt_Deuda
        '
        Me.txt_Deuda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_Deuda.Location = New System.Drawing.Point(223, 339)
        Me.txt_Deuda.Name = "txt_Deuda"
        Me.txt_Deuda.ReadOnly = True
        Me.txt_Deuda.Size = New System.Drawing.Size(171, 21)
        Me.txt_Deuda.TabIndex = 35
        '
        'Label14
        '
        Me.Label14.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(15, 345)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(124, 15)
        Me.Label14.TabIndex = 34
        Me.Label14.Text = "Deuda Acumulada"
        '
        'txt_sueldoMano
        '
        Me.txt_sueldoMano.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_sueldoMano.Location = New System.Drawing.Point(223, 308)
        Me.txt_sueldoMano.Name = "txt_sueldoMano"
        Me.txt_sueldoMano.ReadOnly = True
        Me.txt_sueldoMano.Size = New System.Drawing.Size(171, 21)
        Me.txt_sueldoMano.TabIndex = 33
        '
        'Label13
        '
        Me.Label13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(15, 314)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(112, 15)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Sueldo en Mano"
        '
        'txt_subto
        '
        Me.txt_subto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_subto.Location = New System.Drawing.Point(223, 215)
        Me.txt_subto.Name = "txt_subto"
        Me.txt_subto.ReadOnly = True
        Me.txt_subto.Size = New System.Drawing.Size(171, 21)
        Me.txt_subto.TabIndex = 31
        '
        'Label12
        '
        Me.Label12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(15, 221)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(125, 15)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "Subtotal a percibir"
        '
        'BtnAdicionales
        '
        Me.BtnAdicionales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAdicionales.FlatAppearance.BorderSize = 0
        Me.BtnAdicionales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdicionales.Image = Global.SistemaCinderella.My.Resources.Recursos.Detalle_Pequeno
        Me.BtnAdicionales.Location = New System.Drawing.Point(400, 184)
        Me.BtnAdicionales.Name = "BtnAdicionales"
        Me.BtnAdicionales.Size = New System.Drawing.Size(18, 18)
        Me.BtnAdicionales.TabIndex = 29
        Me.BtnAdicionales.Tag = "Ver Detalle"
        Me.BtnAdicionales.UseVisualStyleBackColor = True
        '
        'txt_Adicionales
        '
        Me.txt_Adicionales.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_Adicionales.Location = New System.Drawing.Point(223, 184)
        Me.txt_Adicionales.Name = "txt_Adicionales"
        Me.txt_Adicionales.ReadOnly = True
        Me.txt_Adicionales.Size = New System.Drawing.Size(171, 21)
        Me.txt_Adicionales.TabIndex = 28
        '
        'Label11
        '
        Me.Label11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(15, 190)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 15)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Adicionales"
        '
        'BtnVacaciones
        '
        Me.BtnVacaciones.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnVacaciones.FlatAppearance.BorderSize = 0
        Me.BtnVacaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVacaciones.Image = Global.SistemaCinderella.My.Resources.Recursos.Detalle_Pequeno
        Me.BtnVacaciones.Location = New System.Drawing.Point(400, 153)
        Me.BtnVacaciones.Name = "BtnVacaciones"
        Me.BtnVacaciones.Size = New System.Drawing.Size(18, 18)
        Me.BtnVacaciones.TabIndex = 26
        Me.BtnVacaciones.Tag = "Ver Detalle"
        Me.BtnVacaciones.UseVisualStyleBackColor = True
        '
        'txt_Vacaciones
        '
        Me.txt_Vacaciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_Vacaciones.Location = New System.Drawing.Point(223, 153)
        Me.txt_Vacaciones.Name = "txt_Vacaciones"
        Me.txt_Vacaciones.ReadOnly = True
        Me.txt_Vacaciones.Size = New System.Drawing.Size(171, 21)
        Me.txt_Vacaciones.TabIndex = 25
        '
        'Label9
        '
        Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(15, 159)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 15)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Vacaciones"
        '
        'BtnAguinaldo
        '
        Me.BtnAguinaldo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAguinaldo.FlatAppearance.BorderSize = 0
        Me.BtnAguinaldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAguinaldo.Image = Global.SistemaCinderella.My.Resources.Recursos.Detalle_Pequeno
        Me.BtnAguinaldo.Location = New System.Drawing.Point(400, 122)
        Me.BtnAguinaldo.Name = "BtnAguinaldo"
        Me.BtnAguinaldo.Size = New System.Drawing.Size(18, 18)
        Me.BtnAguinaldo.TabIndex = 23
        Me.BtnAguinaldo.Tag = "Ver Detalle"
        Me.BtnAguinaldo.UseVisualStyleBackColor = True
        '
        'txt_Aguinaldo
        '
        Me.txt_Aguinaldo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_Aguinaldo.Location = New System.Drawing.Point(223, 122)
        Me.txt_Aguinaldo.Name = "txt_Aguinaldo"
        Me.txt_Aguinaldo.ReadOnly = True
        Me.txt_Aguinaldo.Size = New System.Drawing.Size(171, 21)
        Me.txt_Aguinaldo.TabIndex = 22
        '
        'Label10
        '
        Me.Label10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(15, 128)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 15)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Aguinaldo"
        '
        'lbl_diasf
        '
        Me.lbl_diasf.AutoSize = True
        Me.lbl_diasf.Location = New System.Drawing.Point(133, 64)
        Me.lbl_diasf.Name = "lbl_diasf"
        Me.lbl_diasf.Size = New System.Drawing.Size(81, 15)
        Me.lbl_diasf.TabIndex = 20
        Me.lbl_diasf.Text = "( 2 días trab. )"
        '
        'lbl_diasn
        '
        Me.lbl_diasn.AutoSize = True
        Me.lbl_diasn.Location = New System.Drawing.Point(123, 35)
        Me.lbl_diasn.Name = "lbl_diasn"
        Me.lbl_diasn.Size = New System.Drawing.Size(81, 15)
        Me.lbl_diasn.TabIndex = 19
        Me.lbl_diasn.Text = "( 2 días trab. )"
        '
        'BtnFeriados
        '
        Me.BtnFeriados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFeriados.FlatAppearance.BorderSize = 0
        Me.BtnFeriados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFeriados.Image = Global.SistemaCinderella.My.Resources.Recursos.Detalle_Pequeno
        Me.BtnFeriados.Location = New System.Drawing.Point(400, 60)
        Me.BtnFeriados.Name = "BtnFeriados"
        Me.BtnFeriados.Size = New System.Drawing.Size(18, 18)
        Me.BtnFeriados.TabIndex = 18
        Me.BtnFeriados.Tag = "Ver Detalle"
        Me.BtnFeriados.UseVisualStyleBackColor = True
        '
        'BtnRegulares
        '
        Me.BtnRegulares.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRegulares.FlatAppearance.BorderSize = 0
        Me.BtnRegulares.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegulares.Image = Global.SistemaCinderella.My.Resources.Recursos.Detalle_Pequeno
        Me.BtnRegulares.Location = New System.Drawing.Point(400, 29)
        Me.BtnRegulares.Name = "BtnRegulares"
        Me.BtnRegulares.Size = New System.Drawing.Size(18, 18)
        Me.BtnRegulares.TabIndex = 17
        Me.BtnRegulares.Tag = "Ver Detalle"
        Me.BtnRegulares.UseVisualStyleBackColor = True
        '
        'BtnAdelantos
        '
        Me.BtnAdelantos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAdelantos.FlatAppearance.BorderSize = 0
        Me.BtnAdelantos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdelantos.Image = Global.SistemaCinderella.My.Resources.Recursos.Detalle_Pequeno
        Me.BtnAdelantos.Location = New System.Drawing.Point(400, 246)
        Me.BtnAdelantos.Name = "BtnAdelantos"
        Me.BtnAdelantos.Size = New System.Drawing.Size(18, 18)
        Me.BtnAdelantos.TabIndex = 16
        Me.BtnAdelantos.Tag = "Ver Detalle"
        Me.BtnAdelantos.UseVisualStyleBackColor = True
        '
        'BtnComisiones
        '
        Me.BtnComisiones.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnComisiones.FlatAppearance.BorderSize = 0
        Me.BtnComisiones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnComisiones.Image = Global.SistemaCinderella.My.Resources.Recursos.Detalle_Pequeno
        Me.BtnComisiones.Location = New System.Drawing.Point(400, 91)
        Me.BtnComisiones.Name = "BtnComisiones"
        Me.BtnComisiones.Size = New System.Drawing.Size(18, 18)
        Me.BtnComisiones.TabIndex = 15
        Me.BtnComisiones.Tag = "Ver Detalle"
        Me.BtnComisiones.UseVisualStyleBackColor = True
        '
        'txt_DiasFeriados
        '
        Me.txt_DiasFeriados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_DiasFeriados.Location = New System.Drawing.Point(223, 60)
        Me.txt_DiasFeriados.Name = "txt_DiasFeriados"
        Me.txt_DiasFeriados.ReadOnly = True
        Me.txt_DiasFeriados.Size = New System.Drawing.Size(171, 21)
        Me.txt_DiasFeriados.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 15)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Sueldo Feriados"
        '
        'txt_Saldo
        '
        Me.txt_Saldo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_Saldo.Location = New System.Drawing.Point(223, 277)
        Me.txt_Saldo.Name = "txt_Saldo"
        Me.txt_Saldo.ReadOnly = True
        Me.txt_Saldo.Size = New System.Drawing.Size(171, 21)
        Me.txt_Saldo.TabIndex = 8
        '
        'txt_Comisiones
        '
        Me.txt_Comisiones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_Comisiones.Location = New System.Drawing.Point(223, 91)
        Me.txt_Comisiones.Name = "txt_Comisiones"
        Me.txt_Comisiones.ReadOnly = True
        Me.txt_Comisiones.Size = New System.Drawing.Size(171, 21)
        Me.txt_Comisiones.TabIndex = 7
        '
        'txt_Adelantos
        '
        Me.txt_Adelantos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_Adelantos.Location = New System.Drawing.Point(223, 246)
        Me.txt_Adelantos.Name = "txt_Adelantos"
        Me.txt_Adelantos.ReadOnly = True
        Me.txt_Adelantos.Size = New System.Drawing.Size(171, 21)
        Me.txt_Adelantos.TabIndex = 6
        '
        'txt_Dias
        '
        Me.txt_Dias.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_Dias.Location = New System.Drawing.Point(223, 29)
        Me.txt_Dias.Name = "txt_Dias"
        Me.txt_Dias.ReadOnly = True
        Me.txt_Dias.Size = New System.Drawing.Size(171, 21)
        Me.txt_Dias.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(15, 283)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 15)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Sueldo Depositar"
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 253)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(142, 15)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Adelantos Percibidos"
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 15)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Sueldo Normal"
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Comisiones"
        '
        'ToolEmpleados
        '
        Me.ToolEmpleados.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolEmpleados.ToolTipTitle = "Ayuda"
        '
        'frmEmpleadosSaldos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 542)
        Me.Controls.Add(Me.GbDetalle)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmEmpleadosSaldos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estado de Cuenta de Empleados"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GbDetalle.ResumeLayout(False)
        Me.GbDetalle.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_FDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_FHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents CbEmpleados As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GbDetalle As System.Windows.Forms.GroupBox
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
    Friend WithEvents lbl_diasf As System.Windows.Forms.Label
    Friend WithEvents lbl_diasn As System.Windows.Forms.Label
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
End Class
