<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmpleados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmpleados))
        Me.TabEmpleados = New System.Windows.Forms.TabControl()
        Me.TbListado = New System.Windows.Forms.TabPage()
        Me.lbl_Msg = New System.Windows.Forms.Label()
        Me.DG_Empleados = New System.Windows.Forms.DataGridView()
        Me.id_Empleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cuil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sucursal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Habilitado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Modificar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Eliminar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.GB_Buscar = New System.Windows.Forms.GroupBox()
        Me.btn_Restablecer = New System.Windows.Forms.Button()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.txt_buscar = New System.Windows.Forms.TextBox()
        Me.lbl_descripcion_bus = New System.Windows.Forms.Label()
        Me.TbAlta = New System.Windows.Forms.TabPage()
        Me.Group = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_Nombre = New System.Windows.Forms.Label()
        Me.lbl_Apellido = New System.Windows.Forms.Label()
        Me.txt_Nombre = New System.Windows.Forms.TextBox()
        Me.txt_Apellido = New System.Windows.Forms.TextBox()
        Me.lbl_Cuil = New System.Windows.Forms.Label()
        Me.txt_Cuil = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_Telefono = New System.Windows.Forms.Label()
        Me.txt_Telefono = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_Telefono2 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_Mail = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lbl_TipoComision = New System.Windows.Forms.Label()
        Me.cb_TipoEmpleado = New System.Windows.Forms.ComboBox()
        Me.lbl_Provincia = New System.Windows.Forms.Label()
        Me.cb_Provincia = New System.Windows.Forms.ComboBox()
        Me.cb_Localidad = New System.Windows.Forms.ComboBox()
        Me.lbl_Distrito = New System.Windows.Forms.Label()
        Me.txt_CodigoPostal = New System.Windows.Forms.TextBox()
        Me.lbl_Localidad = New System.Windows.Forms.Label()
        Me.lbl_CodigoPostal = New System.Windows.Forms.Label()
        Me.cb_Distrito = New System.Windows.Forms.ComboBox()
        Me.txt_Direccion = New System.Windows.Forms.TextBox()
        Me.lbl_Direccion = New System.Windows.Forms.Label()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_Observaciones = New System.Windows.Forms.TextBox()
        Me.lbl_Sucursal = New System.Windows.Forms.Label()
        Me.CheckSucursales = New System.Windows.Forms.CheckedListBox()
        Me.lbl_Observaciones = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.FechaIngreso = New System.Windows.Forms.DateTimePicker()
        Me.cb_Usuario = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.FechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.chk_Habilitado = New System.Windows.Forms.CheckBox()
        Me.txt_SueldoPresente = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txt_SueldoNormal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_SueldoFeriado = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btn_Agregar = New System.Windows.Forms.Button()
        Me.TbMod = New System.Windows.Forms.TabPage()
        Me.GB_Modificacion = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel10 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_Nombre_mod = New System.Windows.Forms.Label()
        Me.txt_Nombre_mod = New System.Windows.Forms.TextBox()
        Me.txt_Apellido_mod = New System.Windows.Forms.TextBox()
        Me.lbl_Apellido_mod = New System.Windows.Forms.Label()
        Me.txt_Cuil_mod = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_Cuil_mod = New System.Windows.Forms.Label()
        Me.txt_Telefono_mod = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_Telefono2_mod = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txt_Mail_mod = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cb_TipoEmpleado_mod = New System.Windows.Forms.ComboBox()
        Me.lbl_TipoEmpleado_mod = New System.Windows.Forms.Label()
        Me.cb_Provincia_mod = New System.Windows.Forms.ComboBox()
        Me.cb_Distrito_mod = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cb_Localidad_mod = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_CodigoPostal_mod = New System.Windows.Forms.TextBox()
        Me.txt_Direccion_mod = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel9 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.FechaIngreso_mod = New System.Windows.Forms.DateTimePicker()
        Me.cb_Usuario_Mod = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.FechaNacimiento_mod = New System.Windows.Forms.DateTimePicker()
        Me.txt_SueldoPresente_mod = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.chk_Habilitado_mod = New System.Windows.Forms.CheckBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_SueldoNormal_mod = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_SueldoFeriado_mod = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_Observaciones_mod = New System.Windows.Forms.TextBox()
        Me.lbl_Sucursal_mod = New System.Windows.Forms.Label()
        Me.CheckSucursales_mod = New System.Windows.Forms.CheckedListBox()
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.Btn_Eliminar = New System.Windows.Forms.Button()
        Me.Btn_Modificar = New System.Windows.Forms.Button()
        Me.ErrorEmpleados = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolEmpl = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabEmpleados.SuspendLayout()
        Me.TbListado.SuspendLayout()
        CType(Me.DG_Empleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_Buscar.SuspendLayout()
        Me.TbAlta.SuspendLayout()
        Me.Group.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TbMod.SuspendLayout()
        Me.GB_Modificacion.SuspendLayout()
        Me.TableLayoutPanel10.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TableLayoutPanel9.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        CType(Me.ErrorEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabEmpleados
        '
        Me.TabEmpleados.Controls.Add(Me.TbListado)
        Me.TabEmpleados.Controls.Add(Me.TbAlta)
        Me.TabEmpleados.Controls.Add(Me.TbMod)
        Me.TabEmpleados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabEmpleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabEmpleados.Location = New System.Drawing.Point(0, 0)
        Me.TabEmpleados.Name = "TabEmpleados"
        Me.TabEmpleados.SelectedIndex = 0
        Me.TabEmpleados.Size = New System.Drawing.Size(794, 549)
        Me.TabEmpleados.TabIndex = 2
        '
        'TbListado
        '
        Me.TbListado.Controls.Add(Me.lbl_Msg)
        Me.TbListado.Controls.Add(Me.DG_Empleados)
        Me.TbListado.Controls.Add(Me.GB_Buscar)
        Me.TbListado.Location = New System.Drawing.Point(4, 29)
        Me.TbListado.Name = "TbListado"
        Me.TbListado.Padding = New System.Windows.Forms.Padding(3)
        Me.TbListado.Size = New System.Drawing.Size(786, 516)
        Me.TbListado.TabIndex = 0
        Me.TbListado.Text = "Empleados"
        Me.TbListado.UseVisualStyleBackColor = True
        '
        'lbl_Msg
        '
        Me.lbl_Msg.AutoSize = True
        Me.lbl_Msg.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lbl_Msg.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Msg.Location = New System.Drawing.Point(187, 272)
        Me.lbl_Msg.Name = "lbl_Msg"
        Me.lbl_Msg.Size = New System.Drawing.Size(413, 29)
        Me.lbl_Msg.TabIndex = 4
        Me.lbl_Msg.Text = "No se han encontrado empleados."
        '
        'DG_Empleados
        '
        Me.DG_Empleados.AllowUserToAddRows = False
        Me.DG_Empleados.AllowUserToDeleteRows = False
        Me.DG_Empleados.AllowUserToResizeColumns = False
        Me.DG_Empleados.AllowUserToResizeRows = False
        Me.DG_Empleados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_Empleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_Empleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_Empleado, Me.Nombre, Me.Apellido, Me.Cuil, Me.Telefono, Me.Sucursal, Me.TipoEmpleado, Me.Usuario, Me.Habilitado, Me.Modificar, Me.Eliminar})
        Me.DG_Empleados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DG_Empleados.Location = New System.Drawing.Point(8, 85)
        Me.DG_Empleados.MultiSelect = False
        Me.DG_Empleados.Name = "DG_Empleados"
        Me.DG_Empleados.ReadOnly = True
        Me.DG_Empleados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DG_Empleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Empleados.Size = New System.Drawing.Size(770, 398)
        Me.DG_Empleados.TabIndex = 4
        '
        'id_Empleado
        '
        Me.id_Empleado.DataPropertyName = "id_Empleado"
        Me.id_Empleado.FillWeight = 118.6591!
        Me.id_Empleado.HeaderText = "ID"
        Me.id_Empleado.Name = "id_Empleado"
        Me.id_Empleado.ReadOnly = True
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.FillWeight = 118.6591!
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Apellido
        '
        Me.Apellido.DataPropertyName = "Apellido"
        Me.Apellido.FillWeight = 118.6591!
        Me.Apellido.HeaderText = "Apellido"
        Me.Apellido.Name = "Apellido"
        Me.Apellido.ReadOnly = True
        '
        'Cuil
        '
        Me.Cuil.DataPropertyName = "Cuil"
        Me.Cuil.FillWeight = 118.6591!
        Me.Cuil.HeaderText = "Cuil"
        Me.Cuil.Name = "Cuil"
        Me.Cuil.ReadOnly = True
        '
        'Telefono
        '
        Me.Telefono.DataPropertyName = "Telefono"
        Me.Telefono.FillWeight = 118.6591!
        Me.Telefono.HeaderText = "Telefono"
        Me.Telefono.Name = "Telefono"
        Me.Telefono.ReadOnly = True
        '
        'Sucursal
        '
        Me.Sucursal.DataPropertyName = "Sucursal"
        Me.Sucursal.FillWeight = 118.6591!
        Me.Sucursal.HeaderText = "Sucursal"
        Me.Sucursal.Name = "Sucursal"
        Me.Sucursal.ReadOnly = True
        '
        'TipoEmpleado
        '
        Me.TipoEmpleado.DataPropertyName = "TipoEmpleado"
        Me.TipoEmpleado.FillWeight = 118.6591!
        Me.TipoEmpleado.HeaderText = "Tipo de Empleado"
        Me.TipoEmpleado.Name = "TipoEmpleado"
        Me.TipoEmpleado.ReadOnly = True
        '
        'Usuario
        '
        Me.Usuario.DataPropertyName = "Usuario"
        Me.Usuario.HeaderText = "Usuario"
        Me.Usuario.Name = "Usuario"
        Me.Usuario.ReadOnly = True
        '
        'Habilitado
        '
        Me.Habilitado.DataPropertyName = "Habilitado"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Habilitado.DefaultCellStyle = DataGridViewCellStyle1
        Me.Habilitado.FillWeight = 57.03627!
        Me.Habilitado.HeaderText = "Habilitado"
        Me.Habilitado.Name = "Habilitado"
        Me.Habilitado.ReadOnly = True
        '
        'Modificar
        '
        Me.Modificar.FillWeight = 55.8376!
        Me.Modificar.HeaderText = "Modificar"
        Me.Modificar.Image = Global.SistemaCinderella.My.Resources.Recursos.Boton_Editar
        Me.Modificar.Name = "Modificar"
        Me.Modificar.ReadOnly = True
        Me.Modificar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Modificar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Eliminar
        '
        Me.Eliminar.FillWeight = 56.5132!
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Image = Global.SistemaCinderella.My.Resources.Recursos.Boton_Eliminar
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'GB_Buscar
        '
        Me.GB_Buscar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_Buscar.Controls.Add(Me.btn_Restablecer)
        Me.GB_Buscar.Controls.Add(Me.btn_Buscar)
        Me.GB_Buscar.Controls.Add(Me.txt_buscar)
        Me.GB_Buscar.Controls.Add(Me.lbl_descripcion_bus)
        Me.GB_Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Buscar.Location = New System.Drawing.Point(10, 6)
        Me.GB_Buscar.Name = "GB_Buscar"
        Me.GB_Buscar.Size = New System.Drawing.Size(770, 73)
        Me.GB_Buscar.TabIndex = 0
        Me.GB_Buscar.TabStop = False
        Me.GB_Buscar.Text = "Buscar Empleado"
        '
        'btn_Restablecer
        '
        Me.btn_Restablecer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Restablecer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Restablecer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Restablecer.Location = New System.Drawing.Point(558, 19)
        Me.btn_Restablecer.Name = "btn_Restablecer"
        Me.btn_Restablecer.Size = New System.Drawing.Size(100, 40)
        Me.btn_Restablecer.TabIndex = 2
        Me.btn_Restablecer.Text = "Restablecer Busqueda"
        Me.ToolEmpl.SetToolTip(Me.btn_Restablecer, "haz click aquí para restablecer los filtros y el listado de empleados.")
        Me.btn_Restablecer.UseVisualStyleBackColor = True
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btn_Buscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Buscar.Image = Global.SistemaCinderella.My.Resources.Recursos.IconoBuscar32
        Me.btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Buscar.Location = New System.Drawing.Point(664, 19)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(100, 40)
        Me.btn_Buscar.TabIndex = 3
        Me.btn_Buscar.Text = "Buscar"
        Me.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolEmpl.SetToolTip(Me.btn_Buscar, "Haz click aquí para buscar empleados con los criterios de busqueda seleccionados." &
        "")
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'txt_buscar
        '
        Me.txt_buscar.Location = New System.Drawing.Point(72, 30)
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(373, 21)
        Me.txt_buscar.TabIndex = 1
        Me.ToolEmpl.SetToolTip(Me.txt_buscar, "Usted puede realizar una busqueda por palabra completa  o parte de ella.")
        '
        'lbl_descripcion_bus
        '
        Me.lbl_descripcion_bus.AutoSize = True
        Me.lbl_descripcion_bus.Location = New System.Drawing.Point(15, 32)
        Me.lbl_descripcion_bus.Name = "lbl_descripcion_bus"
        Me.lbl_descripcion_bus.Size = New System.Drawing.Size(51, 15)
        Me.lbl_descripcion_bus.TabIndex = 0
        Me.lbl_descripcion_bus.Text = "Apellido"
        '
        'TbAlta
        '
        Me.TbAlta.Controls.Add(Me.Group)
        Me.TbAlta.Location = New System.Drawing.Point(4, 29)
        Me.TbAlta.Name = "TbAlta"
        Me.TbAlta.Padding = New System.Windows.Forms.Padding(3)
        Me.TbAlta.Size = New System.Drawing.Size(786, 516)
        Me.TbAlta.TabIndex = 1
        Me.TbAlta.Text = "Alta de Empleado"
        Me.TbAlta.UseVisualStyleBackColor = True
        '
        'Group
        '
        Me.Group.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Group.Controls.Add(Me.TableLayoutPanel4)
        Me.Group.Controls.Add(Me.Btn_Agregar)
        Me.Group.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Group.Location = New System.Drawing.Point(10, 6)
        Me.Group.Name = "Group"
        Me.Group.Size = New System.Drawing.Size(768, 502)
        Me.Group.TabIndex = 0
        Me.Group.TabStop = False
        Me.Group.Text = "Formulario de Alta"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel5, 1, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(6, 13)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(756, 437)
        Me.TableLayoutPanel4.TabIndex = 89
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_Nombre, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_Apellido, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_Nombre, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_Apellido, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_Cuil, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_Cuil, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_Telefono, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_Telefono, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label16, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_Telefono2, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Label14, 0, 12)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_Mail, 1, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.Label17, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_TipoComision, 0, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.cb_TipoEmpleado, 1, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_Provincia, 0, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.cb_Provincia, 1, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.cb_Localidad, 1, 9)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_Distrito, 0, 8)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_CodigoPostal, 1, 11)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_Localidad, 0, 9)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_CodigoPostal, 0, 11)
        Me.TableLayoutPanel2.Controls.Add(Me.cb_Distrito, 1, 8)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_Direccion, 1, 10)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_Direccion, 0, 10)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 13
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(372, 431)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'lbl_Nombre
        '
        Me.lbl_Nombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Nombre.AutoSize = True
        Me.lbl_Nombre.Location = New System.Drawing.Point(3, 7)
        Me.lbl_Nombre.Name = "lbl_Nombre"
        Me.lbl_Nombre.Size = New System.Drawing.Size(194, 15)
        Me.lbl_Nombre.TabIndex = 1
        Me.lbl_Nombre.Text = "Nombre (*)"
        '
        'lbl_Apellido
        '
        Me.lbl_Apellido.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Apellido.AutoSize = True
        Me.lbl_Apellido.Location = New System.Drawing.Point(3, 37)
        Me.lbl_Apellido.Name = "lbl_Apellido"
        Me.lbl_Apellido.Size = New System.Drawing.Size(194, 15)
        Me.lbl_Apellido.TabIndex = 5
        Me.lbl_Apellido.Text = "Apellido (*)"
        '
        'txt_Nombre
        '
        Me.txt_Nombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Nombre.Location = New System.Drawing.Point(203, 4)
        Me.txt_Nombre.MaxLength = 255
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.Size = New System.Drawing.Size(166, 21)
        Me.txt_Nombre.TabIndex = 1
        '
        'txt_Apellido
        '
        Me.txt_Apellido.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Apellido.Location = New System.Drawing.Point(203, 34)
        Me.txt_Apellido.MaxLength = 255
        Me.txt_Apellido.Name = "txt_Apellido"
        Me.txt_Apellido.Size = New System.Drawing.Size(166, 21)
        Me.txt_Apellido.TabIndex = 2
        '
        'lbl_Cuil
        '
        Me.lbl_Cuil.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Cuil.AutoSize = True
        Me.lbl_Cuil.Location = New System.Drawing.Point(3, 67)
        Me.lbl_Cuil.Name = "lbl_Cuil"
        Me.lbl_Cuil.Size = New System.Drawing.Size(194, 15)
        Me.lbl_Cuil.TabIndex = 7
        Me.lbl_Cuil.Text = "Cuil"
        '
        'txt_Cuil
        '
        Me.txt_Cuil.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Cuil.Location = New System.Drawing.Point(203, 64)
        Me.txt_Cuil.Mask = "99-99999999-9"
        Me.txt_Cuil.Name = "txt_Cuil"
        Me.txt_Cuil.Size = New System.Drawing.Size(166, 21)
        Me.txt_Cuil.TabIndex = 3
        '
        'lbl_Telefono
        '
        Me.lbl_Telefono.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Telefono.AutoSize = True
        Me.lbl_Telefono.Location = New System.Drawing.Point(3, 97)
        Me.lbl_Telefono.Name = "lbl_Telefono"
        Me.lbl_Telefono.Size = New System.Drawing.Size(194, 15)
        Me.lbl_Telefono.TabIndex = 15
        Me.lbl_Telefono.Text = "Teléfono"
        '
        'txt_Telefono
        '
        Me.txt_Telefono.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Telefono.Location = New System.Drawing.Point(203, 94)
        Me.txt_Telefono.MaxLength = 255
        Me.txt_Telefono.Name = "txt_Telefono"
        Me.txt_Telefono.Size = New System.Drawing.Size(166, 21)
        Me.txt_Telefono.TabIndex = 4
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(3, 127)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(194, 15)
        Me.Label16.TabIndex = 69
        Me.Label16.Text = "Teléfono (Alt.)"
        '
        'txt_Telefono2
        '
        Me.txt_Telefono2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Telefono2.Location = New System.Drawing.Point(203, 124)
        Me.txt_Telefono2.MaxLength = 255
        Me.txt_Telefono2.Name = "txt_Telefono2"
        Me.txt_Telefono2.Size = New System.Drawing.Size(166, 21)
        Me.txt_Telefono2.TabIndex = 5
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(3, 389)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(194, 13)
        Me.Label14.TabIndex = 67
        Me.Label14.Text = "(*) Campos obligatorios."
        '
        'txt_Mail
        '
        Me.txt_Mail.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Mail.Location = New System.Drawing.Point(203, 154)
        Me.txt_Mail.MaxLength = 255
        Me.txt_Mail.Name = "txt_Mail"
        Me.txt_Mail.Size = New System.Drawing.Size(166, 21)
        Me.txt_Mail.TabIndex = 6
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(3, 157)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(194, 15)
        Me.Label17.TabIndex = 71
        Me.Label17.Text = "Mail"
        '
        'lbl_TipoComision
        '
        Me.lbl_TipoComision.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_TipoComision.AutoSize = True
        Me.lbl_TipoComision.Location = New System.Drawing.Point(3, 187)
        Me.lbl_TipoComision.Name = "lbl_TipoComision"
        Me.lbl_TipoComision.Size = New System.Drawing.Size(194, 15)
        Me.lbl_TipoComision.TabIndex = 21
        Me.lbl_TipoComision.Text = "Tipo de Empleado (*)"
        '
        'cb_TipoEmpleado
        '
        Me.cb_TipoEmpleado.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_TipoEmpleado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_TipoEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_TipoEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cb_TipoEmpleado.FormattingEnabled = True
        Me.cb_TipoEmpleado.Location = New System.Drawing.Point(203, 184)
        Me.cb_TipoEmpleado.Name = "cb_TipoEmpleado"
        Me.cb_TipoEmpleado.Size = New System.Drawing.Size(166, 23)
        Me.cb_TipoEmpleado.TabIndex = 7
        '
        'lbl_Provincia
        '
        Me.lbl_Provincia.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Provincia.AutoSize = True
        Me.lbl_Provincia.Location = New System.Drawing.Point(3, 217)
        Me.lbl_Provincia.Name = "lbl_Provincia"
        Me.lbl_Provincia.Size = New System.Drawing.Size(194, 15)
        Me.lbl_Provincia.TabIndex = 27
        Me.lbl_Provincia.Text = "Provincia (*)"
        '
        'cb_Provincia
        '
        Me.cb_Provincia.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_Provincia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_Provincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Provincia.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cb_Provincia.FormattingEnabled = True
        Me.cb_Provincia.Location = New System.Drawing.Point(203, 214)
        Me.cb_Provincia.Name = "cb_Provincia"
        Me.cb_Provincia.Size = New System.Drawing.Size(166, 23)
        Me.cb_Provincia.TabIndex = 8
        '
        'cb_Localidad
        '
        Me.cb_Localidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_Localidad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_Localidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Localidad.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cb_Localidad.FormattingEnabled = True
        Me.cb_Localidad.Location = New System.Drawing.Point(203, 274)
        Me.cb_Localidad.Name = "cb_Localidad"
        Me.cb_Localidad.Size = New System.Drawing.Size(166, 23)
        Me.cb_Localidad.TabIndex = 10
        '
        'lbl_Distrito
        '
        Me.lbl_Distrito.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Distrito.AutoSize = True
        Me.lbl_Distrito.Location = New System.Drawing.Point(3, 247)
        Me.lbl_Distrito.Name = "lbl_Distrito"
        Me.lbl_Distrito.Size = New System.Drawing.Size(194, 15)
        Me.lbl_Distrito.TabIndex = 26
        Me.lbl_Distrito.Text = "Partido (*)"
        '
        'txt_CodigoPostal
        '
        Me.txt_CodigoPostal.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_CodigoPostal.Location = New System.Drawing.Point(203, 334)
        Me.txt_CodigoPostal.MaxLength = 255
        Me.txt_CodigoPostal.Name = "txt_CodigoPostal"
        Me.txt_CodigoPostal.Size = New System.Drawing.Size(166, 21)
        Me.txt_CodigoPostal.TabIndex = 12
        '
        'lbl_Localidad
        '
        Me.lbl_Localidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Localidad.AutoSize = True
        Me.lbl_Localidad.Location = New System.Drawing.Point(3, 277)
        Me.lbl_Localidad.Name = "lbl_Localidad"
        Me.lbl_Localidad.Size = New System.Drawing.Size(194, 15)
        Me.lbl_Localidad.TabIndex = 25
        Me.lbl_Localidad.Text = "Localidad (*)"
        '
        'lbl_CodigoPostal
        '
        Me.lbl_CodigoPostal.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_CodigoPostal.AutoSize = True
        Me.lbl_CodigoPostal.Location = New System.Drawing.Point(3, 337)
        Me.lbl_CodigoPostal.Name = "lbl_CodigoPostal"
        Me.lbl_CodigoPostal.Size = New System.Drawing.Size(194, 15)
        Me.lbl_CodigoPostal.TabIndex = 13
        Me.lbl_CodigoPostal.Text = "Código Postal (*)"
        '
        'cb_Distrito
        '
        Me.cb_Distrito.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_Distrito.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_Distrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Distrito.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cb_Distrito.FormattingEnabled = True
        Me.cb_Distrito.Location = New System.Drawing.Point(203, 244)
        Me.cb_Distrito.Name = "cb_Distrito"
        Me.cb_Distrito.Size = New System.Drawing.Size(166, 23)
        Me.cb_Distrito.TabIndex = 9
        '
        'txt_Direccion
        '
        Me.txt_Direccion.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Direccion.Location = New System.Drawing.Point(203, 304)
        Me.txt_Direccion.MaxLength = 255
        Me.txt_Direccion.Name = "txt_Direccion"
        Me.txt_Direccion.Size = New System.Drawing.Size(166, 21)
        Me.txt_Direccion.TabIndex = 11
        '
        'lbl_Direccion
        '
        Me.lbl_Direccion.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Direccion.AutoSize = True
        Me.lbl_Direccion.Location = New System.Drawing.Point(3, 307)
        Me.lbl_Direccion.Name = "lbl_Direccion"
        Me.lbl_Direccion.Size = New System.Drawing.Size(194, 15)
        Me.lbl_Direccion.TabIndex = 11
        Me.lbl_Direccion.Text = "Direccion (*)"
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel3, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel1, 0, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(381, 3)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 220.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(372, 431)
        Me.TableLayoutPanel5.TabIndex = 1
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.txt_Observaciones, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.lbl_Sucursal, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.CheckSucursales, 0, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.lbl_Observaciones, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 223)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 4
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(366, 205)
        Me.TableLayoutPanel3.TabIndex = 88
        '
        'txt_Observaciones
        '
        Me.txt_Observaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Observaciones.Location = New System.Drawing.Point(3, 33)
        Me.txt_Observaciones.MaxLength = 255
        Me.txt_Observaciones.Multiline = True
        Me.txt_Observaciones.Name = "txt_Observaciones"
        Me.txt_Observaciones.Size = New System.Drawing.Size(360, 37)
        Me.txt_Observaciones.TabIndex = 15
        '
        'lbl_Sucursal
        '
        Me.lbl_Sucursal.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Sucursal.AutoSize = True
        Me.lbl_Sucursal.Location = New System.Drawing.Point(3, 80)
        Me.lbl_Sucursal.Name = "lbl_Sucursal"
        Me.lbl_Sucursal.Size = New System.Drawing.Size(360, 15)
        Me.lbl_Sucursal.TabIndex = 29
        Me.lbl_Sucursal.Text = "Sucursales donde trabaja"
        '
        'CheckSucursales
        '
        Me.CheckSucursales.CheckOnClick = True
        Me.CheckSucursales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckSucursales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CheckSucursales.FormattingEnabled = True
        Me.CheckSucursales.Location = New System.Drawing.Point(3, 106)
        Me.CheckSucursales.Name = "CheckSucursales"
        Me.CheckSucursales.Size = New System.Drawing.Size(360, 96)
        Me.CheckSucursales.TabIndex = 16
        '
        'lbl_Observaciones
        '
        Me.lbl_Observaciones.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Observaciones.AutoSize = True
        Me.lbl_Observaciones.Location = New System.Drawing.Point(3, 7)
        Me.lbl_Observaciones.Name = "lbl_Observaciones"
        Me.lbl_Observaciones.Size = New System.Drawing.Size(360, 15)
        Me.lbl_Observaciones.TabIndex = 19
        Me.lbl_Observaciones.Text = "Observaciones"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label20, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.FechaIngreso, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cb_Usuario, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label21, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label27, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.FechaNacimiento, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.chk_Habilitado, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_SueldoPresente, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label25, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_SueldoNormal, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_SueldoFeriado, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 6)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 8
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(366, 214)
        Me.TableLayoutPanel1.TabIndex = 87
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(3, 7)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(194, 15)
        Me.Label20.TabIndex = 73
        Me.Label20.Text = "Fecha Ingreso (*)"
        '
        'FechaIngreso
        '
        Me.FechaIngreso.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaIngreso.Location = New System.Drawing.Point(203, 4)
        Me.FechaIngreso.Name = "FechaIngreso"
        Me.FechaIngreso.Size = New System.Drawing.Size(160, 21)
        Me.FechaIngreso.TabIndex = 13
        '
        'cb_Usuario
        '
        Me.cb_Usuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_Usuario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_Usuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Usuario.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cb_Usuario.FormattingEnabled = True
        Me.cb_Usuario.Location = New System.Drawing.Point(203, 154)
        Me.cb_Usuario.Name = "cb_Usuario"
        Me.cb_Usuario.Size = New System.Drawing.Size(160, 23)
        Me.cb_Usuario.TabIndex = 85
        '
        'Label21
        '
        Me.Label21.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(3, 37)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(194, 15)
        Me.Label21.TabIndex = 75
        Me.Label21.Text = "Fecha Nacimiento (*)"
        '
        'Label27
        '
        Me.Label27.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(3, 157)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(194, 15)
        Me.Label27.TabIndex = 86
        Me.Label27.Text = "Usuario (*)"
        '
        'FechaNacimiento
        '
        Me.FechaNacimiento.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FechaNacimiento.CustomFormat = ""
        Me.FechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaNacimiento.Location = New System.Drawing.Point(203, 34)
        Me.FechaNacimiento.Name = "FechaNacimiento"
        Me.FechaNacimiento.Size = New System.Drawing.Size(160, 21)
        Me.FechaNacimiento.TabIndex = 14
        '
        'chk_Habilitado
        '
        Me.chk_Habilitado.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chk_Habilitado.AutoSize = True
        Me.chk_Habilitado.Checked = True
        Me.chk_Habilitado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Habilitado.Location = New System.Drawing.Point(203, 188)
        Me.chk_Habilitado.Name = "chk_Habilitado"
        Me.chk_Habilitado.Size = New System.Drawing.Size(160, 14)
        Me.chk_Habilitado.TabIndex = 20
        Me.chk_Habilitado.UseVisualStyleBackColor = True
        '
        'txt_SueldoPresente
        '
        Me.txt_SueldoPresente.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_SueldoPresente.Location = New System.Drawing.Point(203, 124)
        Me.txt_SueldoPresente.Name = "txt_SueldoPresente"
        Me.txt_SueldoPresente.Size = New System.Drawing.Size(160, 21)
        Me.txt_SueldoPresente.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(194, 15)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Sueldo por día Normal (*)"
        '
        'Label25
        '
        Me.Label25.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(3, 127)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(194, 15)
        Me.Label25.TabIndex = 84
        Me.Label25.Text = "Premio Presentismo (*)"
        '
        'txt_SueldoNormal
        '
        Me.txt_SueldoNormal.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_SueldoNormal.Location = New System.Drawing.Point(203, 64)
        Me.txt_SueldoNormal.Name = "txt_SueldoNormal"
        Me.txt_SueldoNormal.Size = New System.Drawing.Size(160, 21)
        Me.txt_SueldoNormal.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(194, 15)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Sueldo por día Feriado (*)"
        '
        'txt_SueldoFeriado
        '
        Me.txt_SueldoFeriado.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_SueldoFeriado.Location = New System.Drawing.Point(203, 94)
        Me.txt_SueldoFeriado.Name = "txt_SueldoFeriado"
        Me.txt_SueldoFeriado.Size = New System.Drawing.Size(160, 21)
        Me.txt_SueldoFeriado.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(194, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Habilitado"
        '
        'Btn_Agregar
        '
        Me.Btn_Agregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Agregar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Agregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Agregar.Image = Global.SistemaCinderella.My.Resources.Recursos.Agregar_24
        Me.Btn_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Agregar.Location = New System.Drawing.Point(662, 456)
        Me.Btn_Agregar.Name = "Btn_Agregar"
        Me.Btn_Agregar.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Agregar.TabIndex = 21
        Me.Btn_Agregar.Text = "Agregar"
        Me.Btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolEmpl.SetToolTip(Me.Btn_Agregar, "Agrega el empleado al sistema.")
        Me.Btn_Agregar.UseVisualStyleBackColor = False
        '
        'TbMod
        '
        Me.TbMod.Controls.Add(Me.GB_Modificacion)
        Me.TbMod.Location = New System.Drawing.Point(4, 29)
        Me.TbMod.Name = "TbMod"
        Me.TbMod.Size = New System.Drawing.Size(786, 516)
        Me.TbMod.TabIndex = 2
        Me.TbMod.Text = "Modificación de Empleado"
        Me.TbMod.UseVisualStyleBackColor = True
        '
        'GB_Modificacion
        '
        Me.GB_Modificacion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_Modificacion.Controls.Add(Me.TableLayoutPanel10)
        Me.GB_Modificacion.Controls.Add(Me.Btn_Cancelar)
        Me.GB_Modificacion.Controls.Add(Me.Btn_Eliminar)
        Me.GB_Modificacion.Controls.Add(Me.Btn_Modificar)
        Me.GB_Modificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Modificacion.Location = New System.Drawing.Point(10, 6)
        Me.GB_Modificacion.Name = "GB_Modificacion"
        Me.GB_Modificacion.Size = New System.Drawing.Size(770, 502)
        Me.GB_Modificacion.TabIndex = 1
        Me.GB_Modificacion.TabStop = False
        Me.GB_Modificacion.Text = "Formulario de Modificación"
        '
        'TableLayoutPanel10
        '
        Me.TableLayoutPanel10.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel10.ColumnCount = 2
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel10.Controls.Add(Me.TableLayoutPanel6, 0, 0)
        Me.TableLayoutPanel10.Controls.Add(Me.TableLayoutPanel9, 1, 0)
        Me.TableLayoutPanel10.Location = New System.Drawing.Point(9, 20)
        Me.TableLayoutPanel10.Name = "TableLayoutPanel10"
        Me.TableLayoutPanel10.RowCount = 1
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel10.Size = New System.Drawing.Size(755, 430)
        Me.TableLayoutPanel10.TabIndex = 89
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel6.ColumnCount = 2
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.lbl_Nombre_mod, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.txt_Nombre_mod, 1, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.txt_Apellido_mod, 1, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.lbl_Apellido_mod, 0, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.txt_Cuil_mod, 1, 2)
        Me.TableLayoutPanel6.Controls.Add(Me.lbl_Cuil_mod, 0, 2)
        Me.TableLayoutPanel6.Controls.Add(Me.txt_Telefono_mod, 1, 3)
        Me.TableLayoutPanel6.Controls.Add(Me.Label9, 0, 3)
        Me.TableLayoutPanel6.Controls.Add(Me.txt_Telefono2_mod, 1, 4)
        Me.TableLayoutPanel6.Controls.Add(Me.Label19, 0, 4)
        Me.TableLayoutPanel6.Controls.Add(Me.txt_Mail_mod, 1, 5)
        Me.TableLayoutPanel6.Controls.Add(Me.Label13, 0, 12)
        Me.TableLayoutPanel6.Controls.Add(Me.Label18, 0, 5)
        Me.TableLayoutPanel6.Controls.Add(Me.cb_TipoEmpleado_mod, 1, 6)
        Me.TableLayoutPanel6.Controls.Add(Me.lbl_TipoEmpleado_mod, 0, 6)
        Me.TableLayoutPanel6.Controls.Add(Me.cb_Provincia_mod, 1, 7)
        Me.TableLayoutPanel6.Controls.Add(Me.cb_Distrito_mod, 1, 8)
        Me.TableLayoutPanel6.Controls.Add(Me.Label1, 0, 7)
        Me.TableLayoutPanel6.Controls.Add(Me.Label3, 0, 8)
        Me.TableLayoutPanel6.Controls.Add(Me.Label4, 0, 9)
        Me.TableLayoutPanel6.Controls.Add(Me.cb_Localidad_mod, 1, 9)
        Me.TableLayoutPanel6.Controls.Add(Me.Label10, 0, 11)
        Me.TableLayoutPanel6.Controls.Add(Me.txt_CodigoPostal_mod, 1, 11)
        Me.TableLayoutPanel6.Controls.Add(Me.txt_Direccion_mod, 1, 10)
        Me.TableLayoutPanel6.Controls.Add(Me.Label11, 0, 10)
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 13
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(371, 424)
        Me.TableLayoutPanel6.TabIndex = 85
        '
        'lbl_Nombre_mod
        '
        Me.lbl_Nombre_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Nombre_mod.AutoSize = True
        Me.lbl_Nombre_mod.Location = New System.Drawing.Point(3, 7)
        Me.lbl_Nombre_mod.Name = "lbl_Nombre_mod"
        Me.lbl_Nombre_mod.Size = New System.Drawing.Size(194, 15)
        Me.lbl_Nombre_mod.TabIndex = 29
        Me.lbl_Nombre_mod.Text = "Nombre (*)"
        '
        'txt_Nombre_mod
        '
        Me.txt_Nombre_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Nombre_mod.Location = New System.Drawing.Point(203, 4)
        Me.txt_Nombre_mod.MaxLength = 255
        Me.txt_Nombre_mod.Name = "txt_Nombre_mod"
        Me.txt_Nombre_mod.Size = New System.Drawing.Size(165, 21)
        Me.txt_Nombre_mod.TabIndex = 1
        '
        'txt_Apellido_mod
        '
        Me.txt_Apellido_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Apellido_mod.Location = New System.Drawing.Point(203, 34)
        Me.txt_Apellido_mod.MaxLength = 255
        Me.txt_Apellido_mod.Name = "txt_Apellido_mod"
        Me.txt_Apellido_mod.Size = New System.Drawing.Size(165, 21)
        Me.txt_Apellido_mod.TabIndex = 2
        '
        'lbl_Apellido_mod
        '
        Me.lbl_Apellido_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Apellido_mod.AutoSize = True
        Me.lbl_Apellido_mod.Location = New System.Drawing.Point(3, 37)
        Me.lbl_Apellido_mod.Name = "lbl_Apellido_mod"
        Me.lbl_Apellido_mod.Size = New System.Drawing.Size(194, 15)
        Me.lbl_Apellido_mod.TabIndex = 59
        Me.lbl_Apellido_mod.Text = "Apellido (*)"
        '
        'txt_Cuil_mod
        '
        Me.txt_Cuil_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Cuil_mod.Location = New System.Drawing.Point(203, 64)
        Me.txt_Cuil_mod.Mask = "99-99999999-9"
        Me.txt_Cuil_mod.Name = "txt_Cuil_mod"
        Me.txt_Cuil_mod.Size = New System.Drawing.Size(165, 21)
        Me.txt_Cuil_mod.TabIndex = 3
        '
        'lbl_Cuil_mod
        '
        Me.lbl_Cuil_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Cuil_mod.AutoSize = True
        Me.lbl_Cuil_mod.Location = New System.Drawing.Point(3, 67)
        Me.lbl_Cuil_mod.Name = "lbl_Cuil_mod"
        Me.lbl_Cuil_mod.Size = New System.Drawing.Size(194, 15)
        Me.lbl_Cuil_mod.TabIndex = 38
        Me.lbl_Cuil_mod.Text = "Cuil"
        '
        'txt_Telefono_mod
        '
        Me.txt_Telefono_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Telefono_mod.Location = New System.Drawing.Point(203, 94)
        Me.txt_Telefono_mod.MaxLength = 255
        Me.txt_Telefono_mod.Name = "txt_Telefono_mod"
        Me.txt_Telefono_mod.Size = New System.Drawing.Size(165, 21)
        Me.txt_Telefono_mod.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 97)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(194, 15)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "Teléfono"
        '
        'txt_Telefono2_mod
        '
        Me.txt_Telefono2_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Telefono2_mod.Location = New System.Drawing.Point(203, 124)
        Me.txt_Telefono2_mod.MaxLength = 255
        Me.txt_Telefono2_mod.Name = "txt_Telefono2_mod"
        Me.txt_Telefono2_mod.Size = New System.Drawing.Size(165, 21)
        Me.txt_Telefono2_mod.TabIndex = 5
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(3, 127)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(194, 15)
        Me.Label19.TabIndex = 73
        Me.Label19.Text = "Teléfono (Alt.)"
        '
        'txt_Mail_mod
        '
        Me.txt_Mail_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Mail_mod.Location = New System.Drawing.Point(203, 154)
        Me.txt_Mail_mod.MaxLength = 255
        Me.txt_Mail_mod.Name = "txt_Mail_mod"
        Me.txt_Mail_mod.Size = New System.Drawing.Size(165, 21)
        Me.txt_Mail_mod.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(3, 385)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(194, 13)
        Me.Label13.TabIndex = 66
        Me.Label13.Text = "(*) Campos obligatorios."
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(3, 157)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(194, 15)
        Me.Label18.TabIndex = 75
        Me.Label18.Text = "Mail"
        '
        'cb_TipoEmpleado_mod
        '
        Me.cb_TipoEmpleado_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_TipoEmpleado_mod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_TipoEmpleado_mod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_TipoEmpleado_mod.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cb_TipoEmpleado_mod.FormattingEnabled = True
        Me.cb_TipoEmpleado_mod.Location = New System.Drawing.Point(203, 184)
        Me.cb_TipoEmpleado_mod.Name = "cb_TipoEmpleado_mod"
        Me.cb_TipoEmpleado_mod.Size = New System.Drawing.Size(165, 23)
        Me.cb_TipoEmpleado_mod.TabIndex = 7
        '
        'lbl_TipoEmpleado_mod
        '
        Me.lbl_TipoEmpleado_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_TipoEmpleado_mod.AutoSize = True
        Me.lbl_TipoEmpleado_mod.Location = New System.Drawing.Point(3, 187)
        Me.lbl_TipoEmpleado_mod.Name = "lbl_TipoEmpleado_mod"
        Me.lbl_TipoEmpleado_mod.Size = New System.Drawing.Size(194, 15)
        Me.lbl_TipoEmpleado_mod.TabIndex = 53
        Me.lbl_TipoEmpleado_mod.Text = "Tipo de Empleado (*)"
        '
        'cb_Provincia_mod
        '
        Me.cb_Provincia_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_Provincia_mod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_Provincia_mod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Provincia_mod.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cb_Provincia_mod.FormattingEnabled = True
        Me.cb_Provincia_mod.Location = New System.Drawing.Point(203, 214)
        Me.cb_Provincia_mod.Name = "cb_Provincia_mod"
        Me.cb_Provincia_mod.Size = New System.Drawing.Size(165, 23)
        Me.cb_Provincia_mod.TabIndex = 8
        '
        'cb_Distrito_mod
        '
        Me.cb_Distrito_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_Distrito_mod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_Distrito_mod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Distrito_mod.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cb_Distrito_mod.FormattingEnabled = True
        Me.cb_Distrito_mod.Location = New System.Drawing.Point(203, 244)
        Me.cb_Distrito_mod.Name = "cb_Distrito_mod"
        Me.cb_Distrito_mod.Size = New System.Drawing.Size(165, 23)
        Me.cb_Distrito_mod.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 217)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 15)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Provincia (*)"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 247)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(194, 15)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Partido (*)"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 277)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(194, 15)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Localidad (*)"
        '
        'cb_Localidad_mod
        '
        Me.cb_Localidad_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_Localidad_mod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_Localidad_mod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Localidad_mod.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cb_Localidad_mod.FormattingEnabled = True
        Me.cb_Localidad_mod.Location = New System.Drawing.Point(203, 274)
        Me.cb_Localidad_mod.Name = "cb_Localidad_mod"
        Me.cb_Localidad_mod.Size = New System.Drawing.Size(165, 23)
        Me.cb_Localidad_mod.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 337)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(194, 15)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Código Postal (*)"
        '
        'txt_CodigoPostal_mod
        '
        Me.txt_CodigoPostal_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_CodigoPostal_mod.Location = New System.Drawing.Point(203, 334)
        Me.txt_CodigoPostal_mod.MaxLength = 255
        Me.txt_CodigoPostal_mod.Name = "txt_CodigoPostal_mod"
        Me.txt_CodigoPostal_mod.Size = New System.Drawing.Size(165, 21)
        Me.txt_CodigoPostal_mod.TabIndex = 12
        '
        'txt_Direccion_mod
        '
        Me.txt_Direccion_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Direccion_mod.Location = New System.Drawing.Point(203, 304)
        Me.txt_Direccion_mod.MaxLength = 255
        Me.txt_Direccion_mod.Name = "txt_Direccion_mod"
        Me.txt_Direccion_mod.Size = New System.Drawing.Size(165, 21)
        Me.txt_Direccion_mod.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 307)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(194, 15)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "Direccion (*)"
        '
        'TableLayoutPanel9
        '
        Me.TableLayoutPanel9.ColumnCount = 1
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel9.Controls.Add(Me.TableLayoutPanel7, 0, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.TableLayoutPanel8, 0, 1)
        Me.TableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel9.Location = New System.Drawing.Point(380, 3)
        Me.TableLayoutPanel9.Name = "TableLayoutPanel9"
        Me.TableLayoutPanel9.RowCount = 2
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 220.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel9.Size = New System.Drawing.Size(372, 424)
        Me.TableLayoutPanel9.TabIndex = 88
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 2
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.Label23, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.FechaIngreso_mod, 1, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.cb_Usuario_Mod, 1, 5)
        Me.TableLayoutPanel7.Controls.Add(Me.Label22, 0, 1)
        Me.TableLayoutPanel7.Controls.Add(Me.Label26, 0, 5)
        Me.TableLayoutPanel7.Controls.Add(Me.FechaNacimiento_mod, 1, 1)
        Me.TableLayoutPanel7.Controls.Add(Me.txt_SueldoPresente_mod, 1, 4)
        Me.TableLayoutPanel7.Controls.Add(Me.Label12, 0, 2)
        Me.TableLayoutPanel7.Controls.Add(Me.chk_Habilitado_mod, 1, 6)
        Me.TableLayoutPanel7.Controls.Add(Me.Label24, 0, 4)
        Me.TableLayoutPanel7.Controls.Add(Me.Label15, 0, 6)
        Me.TableLayoutPanel7.Controls.Add(Me.txt_SueldoNormal_mod, 1, 2)
        Me.TableLayoutPanel7.Controls.Add(Me.Label8, 0, 3)
        Me.TableLayoutPanel7.Controls.Add(Me.txt_SueldoFeriado_mod, 1, 3)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 7
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(366, 214)
        Me.TableLayoutPanel7.TabIndex = 86
        '
        'Label23
        '
        Me.Label23.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(3, 7)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(194, 15)
        Me.Label23.TabIndex = 77
        Me.Label23.Text = "Fecha Ingreso (*)"
        '
        'FechaIngreso_mod
        '
        Me.FechaIngreso_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FechaIngreso_mod.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaIngreso_mod.Location = New System.Drawing.Point(203, 4)
        Me.FechaIngreso_mod.Name = "FechaIngreso_mod"
        Me.FechaIngreso_mod.Size = New System.Drawing.Size(160, 21)
        Me.FechaIngreso_mod.TabIndex = 13
        '
        'cb_Usuario_Mod
        '
        Me.cb_Usuario_Mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_Usuario_Mod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_Usuario_Mod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Usuario_Mod.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cb_Usuario_Mod.FormattingEnabled = True
        Me.cb_Usuario_Mod.Location = New System.Drawing.Point(203, 154)
        Me.cb_Usuario_Mod.Name = "cb_Usuario_Mod"
        Me.cb_Usuario_Mod.Size = New System.Drawing.Size(160, 23)
        Me.cb_Usuario_Mod.TabIndex = 83
        '
        'Label22
        '
        Me.Label22.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(3, 37)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(194, 15)
        Me.Label22.TabIndex = 79
        Me.Label22.Text = "Fecha Nacimiento (*)"
        '
        'Label26
        '
        Me.Label26.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(3, 157)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(194, 15)
        Me.Label26.TabIndex = 84
        Me.Label26.Text = "Usuario (*)"
        '
        'FechaNacimiento_mod
        '
        Me.FechaNacimiento_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FechaNacimiento_mod.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaNacimiento_mod.Location = New System.Drawing.Point(203, 34)
        Me.FechaNacimiento_mod.Name = "FechaNacimiento_mod"
        Me.FechaNacimiento_mod.Size = New System.Drawing.Size(160, 21)
        Me.FechaNacimiento_mod.TabIndex = 14
        '
        'txt_SueldoPresente_mod
        '
        Me.txt_SueldoPresente_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_SueldoPresente_mod.Location = New System.Drawing.Point(203, 124)
        Me.txt_SueldoPresente_mod.Name = "txt_SueldoPresente_mod"
        Me.txt_SueldoPresente_mod.Size = New System.Drawing.Size(160, 21)
        Me.txt_SueldoPresente_mod.TabIndex = 19
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 67)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(194, 15)
        Me.Label12.TabIndex = 62
        Me.Label12.Text = "Sueldo por día Normal (*)"
        '
        'chk_Habilitado_mod
        '
        Me.chk_Habilitado_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chk_Habilitado_mod.AutoSize = True
        Me.chk_Habilitado_mod.Checked = True
        Me.chk_Habilitado_mod.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Habilitado_mod.Location = New System.Drawing.Point(203, 190)
        Me.chk_Habilitado_mod.Name = "chk_Habilitado_mod"
        Me.chk_Habilitado_mod.Size = New System.Drawing.Size(160, 14)
        Me.chk_Habilitado_mod.TabIndex = 20
        Me.chk_Habilitado_mod.UseVisualStyleBackColor = True
        '
        'Label24
        '
        Me.Label24.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(3, 127)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(194, 15)
        Me.Label24.TabIndex = 82
        Me.Label24.Text = "Premio Presentismo (*)"
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(3, 189)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(194, 15)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "Habilitado"
        '
        'txt_SueldoNormal_mod
        '
        Me.txt_SueldoNormal_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_SueldoNormal_mod.Location = New System.Drawing.Point(203, 64)
        Me.txt_SueldoNormal_mod.Name = "txt_SueldoNormal_mod"
        Me.txt_SueldoNormal_mod.Size = New System.Drawing.Size(160, 21)
        Me.txt_SueldoNormal_mod.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 97)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(194, 15)
        Me.Label8.TabIndex = 63
        Me.Label8.Text = "Sueldo por día Feriado (*)"
        '
        'txt_SueldoFeriado_mod
        '
        Me.txt_SueldoFeriado_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_SueldoFeriado_mod.Location = New System.Drawing.Point(203, 94)
        Me.txt_SueldoFeriado_mod.Name = "txt_SueldoFeriado_mod"
        Me.txt_SueldoFeriado_mod.Size = New System.Drawing.Size(160, 21)
        Me.txt_SueldoFeriado_mod.TabIndex = 18
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.ColumnCount = 1
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.Label7, 0, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.txt_Observaciones_mod, 0, 1)
        Me.TableLayoutPanel8.Controls.Add(Me.lbl_Sucursal_mod, 0, 2)
        Me.TableLayoutPanel8.Controls.Add(Me.CheckSucursales_mod, 0, 3)
        Me.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(3, 223)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 4
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(366, 198)
        Me.TableLayoutPanel8.TabIndex = 87
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(360, 15)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Observaciones"
        '
        'txt_Observaciones_mod
        '
        Me.txt_Observaciones_mod.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Observaciones_mod.Location = New System.Drawing.Point(3, 33)
        Me.txt_Observaciones_mod.MaxLength = 255
        Me.txt_Observaciones_mod.Multiline = True
        Me.txt_Observaciones_mod.Name = "txt_Observaciones_mod"
        Me.txt_Observaciones_mod.Size = New System.Drawing.Size(360, 35)
        Me.txt_Observaciones_mod.TabIndex = 15
        '
        'lbl_Sucursal_mod
        '
        Me.lbl_Sucursal_mod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Sucursal_mod.AutoSize = True
        Me.lbl_Sucursal_mod.Location = New System.Drawing.Point(3, 78)
        Me.lbl_Sucursal_mod.Name = "lbl_Sucursal_mod"
        Me.lbl_Sucursal_mod.Size = New System.Drawing.Size(360, 15)
        Me.lbl_Sucursal_mod.TabIndex = 61
        Me.lbl_Sucursal_mod.Text = "Sucursales donde trabaja"
        '
        'CheckSucursales_mod
        '
        Me.CheckSucursales_mod.CheckOnClick = True
        Me.CheckSucursales_mod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckSucursales_mod.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CheckSucursales_mod.FormattingEnabled = True
        Me.CheckSucursales_mod.Location = New System.Drawing.Point(3, 104)
        Me.CheckSucursales_mod.Name = "CheckSucursales_mod"
        Me.CheckSucursales_mod.Size = New System.Drawing.Size(360, 91)
        Me.CheckSucursales_mod.TabIndex = 16
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Cancelar.Image = Global.SistemaCinderella.My.Resources.Recursos.desconectado_32
        Me.Btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Cancelar.Location = New System.Drawing.Point(452, 456)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Cancelar.TabIndex = 21
        Me.Btn_Cancelar.Text = "Cancelar"
        Me.Btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolEmpl.SetToolTip(Me.Btn_Cancelar, "Descarta los cambios y vuelve al listado de empleados.")
        Me.Btn_Cancelar.UseVisualStyleBackColor = True
        '
        'Btn_Eliminar
        '
        Me.Btn_Eliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Eliminar.Image = Global.SistemaCinderella.My.Resources.Recursos.Limpiar_32
        Me.Btn_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Eliminar.Location = New System.Drawing.Point(558, 456)
        Me.Btn_Eliminar.Name = "Btn_Eliminar"
        Me.Btn_Eliminar.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Eliminar.TabIndex = 22
        Me.Btn_Eliminar.Text = "Eliminar"
        Me.Btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolEmpl.SetToolTip(Me.Btn_Eliminar, "Elimina el empleado del sistema.")
        Me.Btn_Eliminar.UseVisualStyleBackColor = True
        '
        'Btn_Modificar
        '
        Me.Btn_Modificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Modificar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Modificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Modificar.Image = Global.SistemaCinderella.My.Resources.Recursos.Editar_24
        Me.Btn_Modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Modificar.Location = New System.Drawing.Point(664, 456)
        Me.Btn_Modificar.Name = "Btn_Modificar"
        Me.Btn_Modificar.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Modificar.TabIndex = 23
        Me.Btn_Modificar.Text = "Modificar"
        Me.Btn_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolEmpl.SetToolTip(Me.Btn_Modificar, "Modifica el empleado en el sistema.")
        Me.Btn_Modificar.UseVisualStyleBackColor = False
        '
        'ErrorEmpleados
        '
        Me.ErrorEmpleados.BlinkRate = 200
        Me.ErrorEmpleados.ContainerControl = Me
        '
        'ToolEmpl
        '
        Me.ToolEmpl.IsBalloon = True
        Me.ToolEmpl.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolEmpl.ToolTipTitle = "Ayuda"
        '
        'frmEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 549)
        Me.Controls.Add(Me.TabEmpleados)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmEmpleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administración de Empleados"
        Me.TabEmpleados.ResumeLayout(False)
        Me.TbListado.ResumeLayout(False)
        Me.TbListado.PerformLayout()
        CType(Me.DG_Empleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_Buscar.ResumeLayout(False)
        Me.GB_Buscar.PerformLayout()
        Me.TbAlta.ResumeLayout(False)
        Me.Group.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TbMod.ResumeLayout(False)
        Me.GB_Modificacion.ResumeLayout(False)
        Me.TableLayoutPanel10.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.TableLayoutPanel9.ResumeLayout(False)
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel7.PerformLayout()
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel8.PerformLayout()
        CType(Me.ErrorEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabEmpleados As System.Windows.Forms.TabControl
    Friend WithEvents TbListado As System.Windows.Forms.TabPage
    Friend WithEvents GB_Buscar As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents txt_buscar As System.Windows.Forms.TextBox
    Friend WithEvents lbl_descripcion_bus As System.Windows.Forms.Label
    Friend WithEvents TbAlta As System.Windows.Forms.TabPage
    Friend WithEvents Group As System.Windows.Forms.GroupBox
    Friend WithEvents cb_Localidad As System.Windows.Forms.ComboBox
    Friend WithEvents cb_Distrito As System.Windows.Forms.ComboBox
    Friend WithEvents cb_Provincia As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_Provincia As System.Windows.Forms.Label
    Friend WithEvents lbl_Distrito As System.Windows.Forms.Label
    Friend WithEvents lbl_Localidad As System.Windows.Forms.Label
    Friend WithEvents cb_TipoEmpleado As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_TipoComision As System.Windows.Forms.Label
    Friend WithEvents txt_Observaciones As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Observaciones As System.Windows.Forms.Label
    Friend WithEvents txt_Telefono As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Telefono As System.Windows.Forms.Label
    Friend WithEvents txt_CodigoPostal As System.Windows.Forms.TextBox
    Friend WithEvents lbl_CodigoPostal As System.Windows.Forms.Label
    Friend WithEvents txt_Direccion As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Direccion As System.Windows.Forms.Label
    Friend WithEvents lbl_Cuil As System.Windows.Forms.Label
    Friend WithEvents txt_Apellido As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Apellido As System.Windows.Forms.Label
    Friend WithEvents chk_Habilitado As System.Windows.Forms.CheckBox
    Friend WithEvents txt_Nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_Nombre As System.Windows.Forms.Label
    Friend WithEvents Btn_Agregar As System.Windows.Forms.Button
    Friend WithEvents TbMod As System.Windows.Forms.TabPage
    Friend WithEvents GB_Modificacion As System.Windows.Forms.GroupBox
    Friend WithEvents cb_Localidad_mod As System.Windows.Forms.ComboBox
    Friend WithEvents cb_Distrito_mod As System.Windows.Forms.ComboBox
    Friend WithEvents cb_Provincia_mod As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cb_TipoEmpleado_mod As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_TipoEmpleado_mod As System.Windows.Forms.Label
    Friend WithEvents txt_Observaciones_mod As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_Telefono_mod As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_CodigoPostal_mod As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_Direccion_mod As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lbl_Cuil_mod As System.Windows.Forms.Label
    Friend WithEvents chk_Habilitado_mod As System.Windows.Forms.CheckBox
    Friend WithEvents txt_Nombre_mod As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lbl_Nombre_mod As System.Windows.Forms.Label
    Friend WithEvents Btn_Modificar As System.Windows.Forms.Button
    Friend WithEvents DG_Empleados As System.Windows.Forms.DataGridView
    Friend WithEvents ErrorEmpleados As System.Windows.Forms.ErrorProvider
    Friend WithEvents txt_Apellido_mod As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Apellido_mod As System.Windows.Forms.Label
    Friend WithEvents lbl_Sucursal As System.Windows.Forms.Label
    Friend WithEvents lbl_Sucursal_mod As System.Windows.Forms.Label
    Friend WithEvents Btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents txt_SueldoNormal As System.Windows.Forms.TextBox
    Friend WithEvents txt_SueldoFeriado As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_SueldoNormal_mod As System.Windows.Forms.TextBox
    Friend WithEvents txt_SueldoFeriado_mod As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ToolEmpl As System.Windows.Forms.ToolTip
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btn_Restablecer As System.Windows.Forms.Button
    Friend WithEvents txt_Mail As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txt_Telefono2 As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txt_Mail_mod As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txt_Telefono2_mod As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents CheckSucursales As System.Windows.Forms.CheckedListBox
    Friend WithEvents CheckSucursales_mod As System.Windows.Forms.CheckedListBox
    Friend WithEvents lbl_Msg As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents FechaNacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents FechaIngreso As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents FechaNacimiento_mod As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents FechaIngreso_mod As System.Windows.Forms.DateTimePicker
    Friend WithEvents Btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents txt_Cuil As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_Cuil_mod As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_SueldoPresente_mod As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txt_SueldoPresente As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents cb_Usuario_Mod As System.Windows.Forms.ComboBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents cb_Usuario As System.Windows.Forms.ComboBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents id_Empleado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Apellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cuil As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Telefono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sucursal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoEmpleado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Usuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Habilitado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Modificar As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel10 As TableLayoutPanel
End Class
