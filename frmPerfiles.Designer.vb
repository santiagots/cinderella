<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPerfiles
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPerfiles))
        Me.TabPerfiles = New System.Windows.Forms.TabControl()
        Me.TbListado = New System.Windows.Forms.TabPage()
        Me.lbl_Msg = New System.Windows.Forms.Label()
        Me.GB_Buscar = New System.Windows.Forms.GroupBox()
        Me.btn_Restablecer = New System.Windows.Forms.Button()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.txt_buscar = New System.Windows.Forms.TextBox()
        Me.lbl_descripcion_bus = New System.Windows.Forms.Label()
        Me.DG_Perfiles = New System.Windows.Forms.DataGridView()
        Me.id_Perfil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Habilitado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Modificar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Eliminar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TbAlta = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtPerfil = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GB_Alta = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btn_Restablecer_Alta = New System.Windows.Forms.Button()
        Me.ltbFiltroSucursal = New System.Windows.Forms.ListBox()
        Me.btnAltaBuscar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtFiltroNombre = New System.Windows.Forms.TextBox()
        Me.ltbFiltroGrupo = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgPatentes = New System.Windows.Forms.DataGridView()
        Me.Btn_Agregar = New System.Windows.Forms.Button()
        Me.TbMod = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkHabilitado = New System.Windows.Forms.CheckBox()
        Me.txtPerfilModificacion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btn_Restablecer_Alta_Modificacion = New System.Windows.Forms.Button()
        Me.ltbFiltroSucursalModificacion = New System.Windows.Forms.ListBox()
        Me.btnModificacionBuscar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFiltroNombreModificacion = New System.Windows.Forms.TextBox()
        Me.ltbFiltroGrupoModificacion = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgPatentesModificacion = New System.Windows.Forms.DataGridView()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TipAgregar = New System.Windows.Forms.ToolTip(Me.components)
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombrePermiso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Grupo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoMod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPerfiles.SuspendLayout()
        Me.TbListado.SuspendLayout()
        Me.GB_Buscar.SuspendLayout()
        CType(Me.DG_Perfiles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TbAlta.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GB_Alta.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgPatentes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TbMod.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dgPatentesModificacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabPerfiles
        '
        Me.TabPerfiles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabPerfiles.Controls.Add(Me.TbListado)
        Me.TabPerfiles.Controls.Add(Me.TbAlta)
        Me.TabPerfiles.Controls.Add(Me.TbMod)
        Me.TabPerfiles.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPerfiles.Location = New System.Drawing.Point(0, 0)
        Me.TabPerfiles.Name = "TabPerfiles"
        Me.TabPerfiles.SelectedIndex = 0
        Me.TabPerfiles.Size = New System.Drawing.Size(934, 662)
        Me.TabPerfiles.TabIndex = 1
        '
        'TbListado
        '
        Me.TbListado.Controls.Add(Me.lbl_Msg)
        Me.TbListado.Controls.Add(Me.GB_Buscar)
        Me.TbListado.Controls.Add(Me.DG_Perfiles)
        Me.TbListado.Location = New System.Drawing.Point(4, 29)
        Me.TbListado.Name = "TbListado"
        Me.TbListado.Padding = New System.Windows.Forms.Padding(3)
        Me.TbListado.Size = New System.Drawing.Size(926, 629)
        Me.TbListado.TabIndex = 0
        Me.TbListado.Text = "Perfiles"
        Me.TbListado.UseVisualStyleBackColor = True
        '
        'lbl_Msg
        '
        Me.lbl_Msg.AutoSize = True
        Me.lbl_Msg.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lbl_Msg.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Msg.Location = New System.Drawing.Point(285, 327)
        Me.lbl_Msg.Name = "lbl_Msg"
        Me.lbl_Msg.Size = New System.Drawing.Size(371, 29)
        Me.lbl_Msg.TabIndex = 4
        Me.lbl_Msg.Text = "No se han encontrado perfiles."
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
        Me.GB_Buscar.Size = New System.Drawing.Size(908, 70)
        Me.GB_Buscar.TabIndex = 3
        Me.GB_Buscar.TabStop = False
        Me.GB_Buscar.Text = "Buscador de perfiles por nombre."
        '
        'btn_Restablecer
        '
        Me.btn_Restablecer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Restablecer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Restablecer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Restablecer.Location = New System.Drawing.Point(696, 20)
        Me.btn_Restablecer.Name = "btn_Restablecer"
        Me.btn_Restablecer.Size = New System.Drawing.Size(100, 40)
        Me.btn_Restablecer.TabIndex = 9
        Me.btn_Restablecer.Text = "Restablecer Busqueda"
        Me.btn_Restablecer.UseVisualStyleBackColor = True
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Buscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Buscar.Image = Global.SistemaCinderella.My.Resources.Recursos.IconoBuscar32
        Me.btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Buscar.Location = New System.Drawing.Point(802, 20)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(100, 40)
        Me.btn_Buscar.TabIndex = 6
        Me.btn_Buscar.Text = "Buscar"
        Me.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TipAgregar.SetToolTip(Me.btn_Buscar, "Haz click aquí para buscar perfiles con los criterios de busqueda seleccionados.")
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'txt_buscar
        '
        Me.txt_buscar.Location = New System.Drawing.Point(93, 30)
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(243, 21)
        Me.txt_buscar.TabIndex = 1
        '
        'lbl_descripcion_bus
        '
        Me.lbl_descripcion_bus.AutoSize = True
        Me.lbl_descripcion_bus.Location = New System.Drawing.Point(6, 33)
        Me.lbl_descripcion_bus.Name = "lbl_descripcion_bus"
        Me.lbl_descripcion_bus.Size = New System.Drawing.Size(72, 15)
        Me.lbl_descripcion_bus.TabIndex = 0
        Me.lbl_descripcion_bus.Text = "Descripción"
        '
        'DG_Perfiles
        '
        Me.DG_Perfiles.AllowUserToAddRows = False
        Me.DG_Perfiles.AllowUserToDeleteRows = False
        Me.DG_Perfiles.AllowUserToResizeColumns = False
        Me.DG_Perfiles.AllowUserToResizeRows = False
        Me.DG_Perfiles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_Perfiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_Perfiles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_Perfil, Me.Descripcion, Me.Habilitado, Me.Modificar, Me.Eliminar})
        Me.DG_Perfiles.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DG_Perfiles.Location = New System.Drawing.Point(10, 82)
        Me.DG_Perfiles.MultiSelect = False
        Me.DG_Perfiles.Name = "DG_Perfiles"
        Me.DG_Perfiles.ReadOnly = True
        Me.DG_Perfiles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DG_Perfiles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DG_Perfiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Perfiles.Size = New System.Drawing.Size(908, 539)
        Me.DG_Perfiles.TabIndex = 0
        '
        'id_Perfil
        '
        Me.id_Perfil.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.id_Perfil.DataPropertyName = "id_Perfil"
        Me.id_Perfil.HeaderText = "ID"
        Me.id_Perfil.MaxInputLength = 10
        Me.id_Perfil.Name = "id_Perfil"
        Me.id_Perfil.ReadOnly = True
        Me.id_Perfil.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.id_Perfil.Width = 51
        '
        'Descripcion
        '
        Me.Descripcion.DataPropertyName = "Descripcion"
        Me.Descripcion.FillWeight = 290.8403!
        Me.Descripcion.HeaderText = "Descripción"
        Me.Descripcion.MaxInputLength = 150
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Habilitado
        '
        Me.Habilitado.DataPropertyName = "Habilitado"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Habilitado.DefaultCellStyle = DataGridViewCellStyle1
        Me.Habilitado.FillWeight = 36.36364!
        Me.Habilitado.HeaderText = "Habilitado"
        Me.Habilitado.MaxInputLength = 10
        Me.Habilitado.Name = "Habilitado"
        Me.Habilitado.ReadOnly = True
        Me.Habilitado.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Modificar
        '
        Me.Modificar.FillWeight = 36.52883!
        Me.Modificar.HeaderText = "Modificar"
        Me.Modificar.Image = Global.SistemaCinderella.My.Resources.Recursos.Boton_Editar
        Me.Modificar.Name = "Modificar"
        Me.Modificar.ReadOnly = True
        Me.Modificar.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Modificar.ToolTipText = "Modificar"
        '
        'Eliminar
        '
        Me.Eliminar.FillWeight = 36.26725!
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Image = Global.SistemaCinderella.My.Resources.Recursos.Boton_Eliminar
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Eliminar.ToolTipText = "Eliminar"
        '
        'TbAlta
        '
        Me.TbAlta.Controls.Add(Me.GroupBox1)
        Me.TbAlta.Controls.Add(Me.GB_Alta)
        Me.TbAlta.Controls.Add(Me.Btn_Agregar)
        Me.TbAlta.Location = New System.Drawing.Point(4, 29)
        Me.TbAlta.Name = "TbAlta"
        Me.TbAlta.Padding = New System.Windows.Forms.Padding(3)
        Me.TbAlta.Size = New System.Drawing.Size(926, 629)
        Me.TbAlta.TabIndex = 1
        Me.TbAlta.Text = "Alta de Perfiles"
        Me.TbAlta.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtPerfil)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(911, 64)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información Básica"
        '
        'txtPerfil
        '
        Me.txtPerfil.Location = New System.Drawing.Point(129, 23)
        Me.txtPerfil.Name = "txtPerfil"
        Me.txtPerfil.Size = New System.Drawing.Size(230, 21)
        Me.txtPerfil.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Descripción:"
        '
        'GB_Alta
        '
        Me.GB_Alta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_Alta.Controls.Add(Me.GroupBox4)
        Me.GB_Alta.Controls.Add(Me.dgPatentes)
        Me.GB_Alta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Alta.Location = New System.Drawing.Point(3, 76)
        Me.GB_Alta.Name = "GB_Alta"
        Me.GB_Alta.Size = New System.Drawing.Size(914, 501)
        Me.GB_Alta.TabIndex = 0
        Me.GB_Alta.TabStop = False
        Me.GB_Alta.Text = "Lista de Permisos"
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.btn_Restablecer_Alta)
        Me.GroupBox4.Controls.Add(Me.ltbFiltroSucursal)
        Me.GroupBox4.Controls.Add(Me.btnAltaBuscar)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.txtFiltroNombre)
        Me.GroupBox4.Controls.Add(Me.ltbFiltroGrupo)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(6, 20)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(902, 121)
        Me.GroupBox4.TabIndex = 22
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Filtro"
        '
        'btn_Restablecer_Alta
        '
        Me.btn_Restablecer_Alta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Restablecer_Alta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Restablecer_Alta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Restablecer_Alta.Location = New System.Drawing.Point(796, 20)
        Me.btn_Restablecer_Alta.Name = "btn_Restablecer_Alta"
        Me.btn_Restablecer_Alta.Size = New System.Drawing.Size(100, 40)
        Me.btn_Restablecer_Alta.TabIndex = 22
        Me.btn_Restablecer_Alta.Text = "Restablecer Busqueda"
        Me.btn_Restablecer_Alta.UseVisualStyleBackColor = True
        '
        'ltbFiltroSucursal
        '
        Me.ltbFiltroSucursal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ltbFiltroSucursal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ltbFiltroSucursal.FormattingEnabled = True
        Me.ltbFiltroSucursal.ItemHeight = 15
        Me.ltbFiltroSucursal.Location = New System.Drawing.Point(560, 21)
        Me.ltbFiltroSucursal.Name = "ltbFiltroSucursal"
        Me.ltbFiltroSucursal.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.ltbFiltroSucursal.Size = New System.Drawing.Size(230, 92)
        Me.ltbFiltroSucursal.TabIndex = 4
        '
        'btnAltaBuscar
        '
        Me.btnAltaBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAltaBuscar.BackColor = System.Drawing.Color.Transparent
        Me.btnAltaBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAltaBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAltaBuscar.Image = Global.SistemaCinderella.My.Resources.Recursos.IconoBuscar32
        Me.btnAltaBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAltaBuscar.Location = New System.Drawing.Point(796, 75)
        Me.btnAltaBuscar.Name = "btnAltaBuscar"
        Me.btnAltaBuscar.Size = New System.Drawing.Size(100, 40)
        Me.btnAltaBuscar.TabIndex = 5
        Me.btnAltaBuscar.Text = "Buscar"
        Me.btnAltaBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TipAgregar.SetToolTip(Me.btnAltaBuscar, "Click aquí para agregar el nuevo perfil en el sistema.")
        Me.btnAltaBuscar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 15)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Nombre:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(4, 51)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 15)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Grupo:"
        '
        'txtFiltroNombre
        '
        Me.txtFiltroNombre.Location = New System.Drawing.Point(126, 20)
        Me.txtFiltroNombre.Name = "txtFiltroNombre"
        Me.txtFiltroNombre.Size = New System.Drawing.Size(230, 21)
        Me.txtFiltroNombre.TabIndex = 2
        '
        'ltbFiltroGrupo
        '
        Me.ltbFiltroGrupo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ltbFiltroGrupo.FormattingEnabled = True
        Me.ltbFiltroGrupo.ItemHeight = 15
        Me.ltbFiltroGrupo.Location = New System.Drawing.Point(126, 51)
        Me.ltbFiltroGrupo.Name = "ltbFiltroGrupo"
        Me.ltbFiltroGrupo.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.ltbFiltroGrupo.Size = New System.Drawing.Size(230, 62)
        Me.ltbFiltroGrupo.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(470, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 15)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Sucursal:"
        '
        'dgPatentes
        '
        Me.dgPatentes.AllowUserToAddRows = False
        Me.dgPatentes.AllowUserToDeleteRows = False
        Me.dgPatentes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgPatentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPatentes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.NombrePermiso, Me.Grupo})
        Me.dgPatentes.Location = New System.Drawing.Point(6, 147)
        Me.dgPatentes.Name = "dgPatentes"
        Me.dgPatentes.Size = New System.Drawing.Size(902, 348)
        Me.dgPatentes.TabIndex = 6
        '
        'Btn_Agregar
        '
        Me.Btn_Agregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Agregar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Agregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Agregar.Image = Global.SistemaCinderella.My.Resources.Recursos.Agregar_24
        Me.Btn_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Agregar.Location = New System.Drawing.Point(817, 583)
        Me.Btn_Agregar.Name = "Btn_Agregar"
        Me.Btn_Agregar.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Agregar.TabIndex = 7
        Me.Btn_Agregar.Text = "Agregar"
        Me.Btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TipAgregar.SetToolTip(Me.Btn_Agregar, "Click aquí para agregar el nuevo perfil en el sistema.")
        Me.Btn_Agregar.UseVisualStyleBackColor = False
        '
        'TbMod
        '
        Me.TbMod.Controls.Add(Me.GroupBox2)
        Me.TbMod.Controls.Add(Me.GroupBox3)
        Me.TbMod.Controls.Add(Me.btnModificar)
        Me.TbMod.Location = New System.Drawing.Point(4, 29)
        Me.TbMod.Name = "TbMod"
        Me.TbMod.Size = New System.Drawing.Size(926, 629)
        Me.TbMod.TabIndex = 2
        Me.TbMod.Text = "Modificación de Perfiles"
        Me.TbMod.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.chkHabilitado)
        Me.GroupBox2.Controls.Add(Me.txtPerfilModificacion)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(911, 64)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Información Básica"
        '
        'chkHabilitado
        '
        Me.chkHabilitado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkHabilitado.AutoSize = True
        Me.chkHabilitado.Location = New System.Drawing.Point(476, 25)
        Me.chkHabilitado.Name = "chkHabilitado"
        Me.chkHabilitado.Size = New System.Drawing.Size(82, 19)
        Me.chkHabilitado.TabIndex = 4
        Me.chkHabilitado.Text = "Habilitado"
        Me.chkHabilitado.UseVisualStyleBackColor = True
        '
        'txtPerfilModificacion
        '
        Me.txtPerfilModificacion.Location = New System.Drawing.Point(129, 23)
        Me.txtPerfilModificacion.Name = "txtPerfilModificacion"
        Me.txtPerfilModificacion.Size = New System.Drawing.Size(230, 21)
        Me.txtPerfilModificacion.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Descripción:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.GroupBox5)
        Me.GroupBox3.Controls.Add(Me.dgPatentesModificacion)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(3, 76)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(914, 501)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Lista de Permisos"
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.btn_Restablecer_Alta_Modificacion)
        Me.GroupBox5.Controls.Add(Me.ltbFiltroSucursalModificacion)
        Me.GroupBox5.Controls.Add(Me.btnModificacionBuscar)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.txtFiltroNombreModificacion)
        Me.GroupBox5.Controls.Add(Me.ltbFiltroGrupoModificacion)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(6, 20)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(902, 121)
        Me.GroupBox5.TabIndex = 22
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Filtro"
        '
        'btn_Restablecer_Alta_Modificacion
        '
        Me.btn_Restablecer_Alta_Modificacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Restablecer_Alta_Modificacion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Restablecer_Alta_Modificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Restablecer_Alta_Modificacion.Location = New System.Drawing.Point(796, 20)
        Me.btn_Restablecer_Alta_Modificacion.Name = "btn_Restablecer_Alta_Modificacion"
        Me.btn_Restablecer_Alta_Modificacion.Size = New System.Drawing.Size(100, 40)
        Me.btn_Restablecer_Alta_Modificacion.TabIndex = 22
        Me.btn_Restablecer_Alta_Modificacion.Text = "Restablecer Busqueda"
        Me.btn_Restablecer_Alta_Modificacion.UseVisualStyleBackColor = True
        '
        'ltbFiltroSucursalModificacion
        '
        Me.ltbFiltroSucursalModificacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ltbFiltroSucursalModificacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ltbFiltroSucursalModificacion.FormattingEnabled = True
        Me.ltbFiltroSucursalModificacion.ItemHeight = 15
        Me.ltbFiltroSucursalModificacion.Location = New System.Drawing.Point(560, 21)
        Me.ltbFiltroSucursalModificacion.Name = "ltbFiltroSucursalModificacion"
        Me.ltbFiltroSucursalModificacion.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.ltbFiltroSucursalModificacion.Size = New System.Drawing.Size(230, 92)
        Me.ltbFiltroSucursalModificacion.TabIndex = 4
        '
        'btnModificacionBuscar
        '
        Me.btnModificacionBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModificacionBuscar.BackColor = System.Drawing.Color.Transparent
        Me.btnModificacionBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificacionBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificacionBuscar.Image = Global.SistemaCinderella.My.Resources.Recursos.IconoBuscar32
        Me.btnModificacionBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificacionBuscar.Location = New System.Drawing.Point(796, 75)
        Me.btnModificacionBuscar.Name = "btnModificacionBuscar"
        Me.btnModificacionBuscar.Size = New System.Drawing.Size(100, 40)
        Me.btnModificacionBuscar.TabIndex = 5
        Me.btnModificacionBuscar.Text = "Buscar"
        Me.btnModificacionBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TipAgregar.SetToolTip(Me.btnModificacionBuscar, "Click aquí para agregar el nuevo perfil en el sistema.")
        Me.btnModificacionBuscar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 15)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Nombre:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 15)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Grupo:"
        '
        'txtFiltroNombreModificacion
        '
        Me.txtFiltroNombreModificacion.Location = New System.Drawing.Point(126, 20)
        Me.txtFiltroNombreModificacion.Name = "txtFiltroNombreModificacion"
        Me.txtFiltroNombreModificacion.Size = New System.Drawing.Size(230, 21)
        Me.txtFiltroNombreModificacion.TabIndex = 2
        '
        'ltbFiltroGrupoModificacion
        '
        Me.ltbFiltroGrupoModificacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ltbFiltroGrupoModificacion.FormattingEnabled = True
        Me.ltbFiltroGrupoModificacion.ItemHeight = 15
        Me.ltbFiltroGrupoModificacion.Location = New System.Drawing.Point(126, 51)
        Me.ltbFiltroGrupoModificacion.Name = "ltbFiltroGrupoModificacion"
        Me.ltbFiltroGrupoModificacion.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.ltbFiltroGrupoModificacion.Size = New System.Drawing.Size(230, 62)
        Me.ltbFiltroGrupoModificacion.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(470, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 15)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Sucursal:"
        '
        'dgPatentesModificacion
        '
        Me.dgPatentesModificacion.AllowUserToAddRows = False
        Me.dgPatentesModificacion.AllowUserToDeleteRows = False
        Me.dgPatentesModificacion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgPatentesModificacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPatentesModificacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoMod, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.dgPatentesModificacion.Location = New System.Drawing.Point(6, 147)
        Me.dgPatentesModificacion.Name = "dgPatentesModificacion"
        Me.dgPatentesModificacion.Size = New System.Drawing.Size(902, 348)
        Me.dgPatentesModificacion.TabIndex = 6
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModificar.BackColor = System.Drawing.Color.Transparent
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Image = Global.SistemaCinderella.My.Resources.Recursos.btn_Update_24
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.Location = New System.Drawing.Point(817, 583)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(100, 40)
        Me.btnModificar.TabIndex = 12
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TipAgregar.SetToolTip(Me.btnModificar, "Click aquí para agregar el nuevo perfil en el sistema.")
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Image = Global.SistemaCinderella.My.Resources.Recursos.Boton_Editar
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewImageColumn1.ToolTipText = "Modificar Perfil"
        Me.DataGridViewImageColumn1.Width = 60
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.HeaderText = ""
        Me.DataGridViewImageColumn2.Image = Global.SistemaCinderella.My.Resources.Recursos.Boton_Eliminar
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.ReadOnly = True
        Me.DataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewImageColumn2.ToolTipText = "Eliminar Perfil"
        Me.DataGridViewImageColumn2.Width = 60
        '
        'TipAgregar
        '
        Me.TipAgregar.IsBalloon = True
        Me.TipAgregar.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.TipAgregar.ToolTipTitle = "Ayuda"
        '
        'Codigo
        '
        Me.Codigo.DataPropertyName = "Codigo"
        Me.Codigo.Frozen = True
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.Visible = False
        Me.Codigo.Width = 71
        '
        'NombrePermiso
        '
        Me.NombrePermiso.DataPropertyName = "NombrePermiso"
        Me.NombrePermiso.Frozen = True
        Me.NombrePermiso.HeaderText = "Nombre"
        Me.NombrePermiso.Name = "NombrePermiso"
        Me.NombrePermiso.Width = 350
        '
        'Grupo
        '
        Me.Grupo.DataPropertyName = "Grupo"
        Me.Grupo.HeaderText = "Grupo"
        Me.Grupo.Name = "Grupo"
        Me.Grupo.ReadOnly = True
        '
        'CodigoMod
        '
        Me.CodigoMod.DataPropertyName = "Codigo"
        Me.CodigoMod.Frozen = True
        Me.CodigoMod.HeaderText = "Codigo"
        Me.CodigoMod.Name = "CodigoMod"
        Me.CodigoMod.Visible = False
        Me.CodigoMod.Width = 71
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NombrePermiso"
        Me.DataGridViewTextBoxColumn2.Frozen = True
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 350
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Grupo"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Grupo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'frmPerfiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 662)
        Me.Controls.Add(Me.TabPerfiles)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPerfiles"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administración de Perfiles"
        Me.TabPerfiles.ResumeLayout(False)
        Me.TbListado.ResumeLayout(False)
        Me.TbListado.PerformLayout()
        Me.GB_Buscar.ResumeLayout(False)
        Me.GB_Buscar.PerformLayout()
        CType(Me.DG_Perfiles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TbAlta.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GB_Alta.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dgPatentes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TbMod.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.dgPatentesModificacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabPerfiles As System.Windows.Forms.TabControl
    Friend WithEvents TbListado As System.Windows.Forms.TabPage
    Friend WithEvents DG_Perfiles As System.Windows.Forms.DataGridView
    Friend WithEvents TbAlta As System.Windows.Forms.TabPage
    Friend WithEvents GB_Alta As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_Agregar As System.Windows.Forms.Button
    Friend WithEvents TbMod As System.Windows.Forms.TabPage
    Friend WithEvents GB_Buscar As System.Windows.Forms.GroupBox
    Friend WithEvents txt_buscar As System.Windows.Forms.TextBox
    Friend WithEvents lbl_descripcion_bus As System.Windows.Forms.Label
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents TipAgregar As System.Windows.Forms.ToolTip
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents btn_Restablecer As System.Windows.Forms.Button
    Friend WithEvents lbl_Msg As System.Windows.Forms.Label
    Friend WithEvents id_Perfil As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Habilitado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Modificar As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents dgPatentes As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPerfil As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ltbFiltroSucursal As System.Windows.Forms.ListBox
    Friend WithEvents txtFiltroNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAltaBuscar As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ltbFiltroGrupo As System.Windows.Forms.ListBox
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Restablecer_Alta As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPerfilModificacion As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Restablecer_Alta_Modificacion As System.Windows.Forms.Button
    Friend WithEvents ltbFiltroSucursalModificacion As System.Windows.Forms.ListBox
    Friend WithEvents btnModificacionBuscar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtFiltroNombreModificacion As System.Windows.Forms.TextBox
    Friend WithEvents ltbFiltroGrupoModificacion As System.Windows.Forms.ListBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dgPatentesModificacion As System.Windows.Forms.DataGridView
    Friend WithEvents chkHabilitado As System.Windows.Forms.CheckBox
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombrePermiso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Grupo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoMod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
