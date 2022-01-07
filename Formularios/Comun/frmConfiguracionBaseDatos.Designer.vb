<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConfiguracionBaseDatos

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfiguracionBaseDatos))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DG_Servidores = New SistemaCinderella.CustomDataGrid()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InstanciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VersionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServidoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FrmConfiguracionBaseDatosViewModelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.btnCrearBaseLocal = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.btnVerificarBaseLocal = New System.Windows.Forms.Button()
        Me.btnDescargarBaseRemota = New System.Windows.Forms.Button()
        Me.Btn_Aceptar = New System.Windows.Forms.Button()
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Chk_Red = New System.Windows.Forms.RadioButton()
        Me.Chk_Aislado = New System.Windows.Forms.RadioButton()
        Me.btnVerificarBaseRemota = New System.Windows.Forms.Button()
        Me.txt_StringDeConexionBaseRemota = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DG_Servidores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServidoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FrmConfiguracionBaseDatosViewModelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox13.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DG_Servidores)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(492, 142)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Servidores SQL Locales Disponibles"
        '
        'DG_Servidores
        '
        Me.DG_Servidores.AllowUserToAddRows = False
        Me.DG_Servidores.AllowUserToDeleteRows = False
        Me.DG_Servidores.AutoGenerateColumns = False
        Me.DG_Servidores.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DG_Servidores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Servidores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NombreDataGridViewTextBoxColumn, Me.InstanciaDataGridViewTextBoxColumn, Me.VersionDataGridViewTextBoxColumn})
        Me.DG_Servidores.DataSource = Me.ServidoresBindingSource
        Me.DG_Servidores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_Servidores.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DG_Servidores.Location = New System.Drawing.Point(3, 16)
        Me.DG_Servidores.Name = "DG_Servidores"
        Me.DG_Servidores.ReadOnly = True
        Me.DG_Servidores.RowHeadersVisible = False
        Me.DG_Servidores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Servidores.Size = New System.Drawing.Size(486, 123)
        Me.DG_Servidores.TabIndex = 33
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InstanciaDataGridViewTextBoxColumn
        '
        Me.InstanciaDataGridViewTextBoxColumn.DataPropertyName = "Instancia"
        Me.InstanciaDataGridViewTextBoxColumn.HeaderText = "Instancia"
        Me.InstanciaDataGridViewTextBoxColumn.Name = "InstanciaDataGridViewTextBoxColumn"
        Me.InstanciaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VersionDataGridViewTextBoxColumn
        '
        Me.VersionDataGridViewTextBoxColumn.DataPropertyName = "Version"
        Me.VersionDataGridViewTextBoxColumn.HeaderText = "Versión"
        Me.VersionDataGridViewTextBoxColumn.Name = "VersionDataGridViewTextBoxColumn"
        Me.VersionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ServidoresBindingSource
        '
        Me.ServidoresBindingSource.DataMember = "Servidores"
        Me.ServidoresBindingSource.DataSource = Me.FrmConfiguracionBaseDatosViewModelBindingSource
        '
        'FrmConfiguracionBaseDatosViewModelBindingSource
        '
        Me.FrmConfiguracionBaseDatosViewModelBindingSource.DataSource = GetType(SistemaCinderella.Formularios.Comun.frmConfiguracionBaseDatosViewModel)
        '
        'GroupBox13
        '
        Me.GroupBox13.Controls.Add(Me.btnCrearBaseLocal)
        Me.GroupBox13.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox13.Controls.Add(Me.btnVerificarBaseLocal)
        Me.GroupBox13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.GroupBox13.Location = New System.Drawing.Point(3, 151)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(492, 174)
        Me.GroupBox13.TabIndex = 9
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "Datos Fiscales"
        '
        'btnCrearBaseLocal
        '
        Me.btnCrearBaseLocal.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnCrearBaseLocal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCrearBaseLocal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrearBaseLocal.Image = Global.SistemaCinderella.My.Resources.Recursos.Crear_Base
        Me.btnCrearBaseLocal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCrearBaseLocal.Location = New System.Drawing.Point(374, 74)
        Me.btnCrearBaseLocal.Name = "btnCrearBaseLocal"
        Me.btnCrearBaseLocal.Size = New System.Drawing.Size(115, 48)
        Me.btnCrearBaseLocal.TabIndex = 35
        Me.btnCrearBaseLocal.Text = "Crear         Base Dat."
        Me.btnCrearBaseLocal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCrearBaseLocal.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox5, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox4, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label25, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox3, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label34, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox2, 1, 3)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(6, 20)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(365, 148)
        Me.TableLayoutPanel1.TabIndex = 34
        '
        'TextBox5
        '
        Me.TextBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmConfiguracionBaseDatosViewModelBindingSource, "NombreBaseDatosLocalRed", True))
        Me.TextBox5.Location = New System.Drawing.Point(133, 64)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(229, 21)
        Me.TextBox5.TabIndex = 35
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 15)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "(*) Nombre Base Dat."
        '
        'TextBox4
        '
        Me.TextBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmConfiguracionBaseDatosViewModelBindingSource, "InstanciaLocalRed", True))
        Me.TextBox4.Location = New System.Drawing.Point(133, 34)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(229, 21)
        Me.TextBox4.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 15)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "(*) Instancia"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmConfiguracionBaseDatosViewModelBindingSource, "ServidorLocalRed", True))
        Me.TextBox1.Location = New System.Drawing.Point(133, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(229, 21)
        Me.TextBox1.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 15)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "(*) Servidor"
        '
        'Label25
        '
        Me.Label25.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(3, 127)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(124, 15)
        Me.Label25.TabIndex = 12
        Me.Label25.Text = "(*) Contraseña"
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmConfiguracionBaseDatosViewModelBindingSource, "ContraseniaLocalRed", True))
        Me.TextBox3.Location = New System.Drawing.Point(133, 124)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox3.Size = New System.Drawing.Size(229, 21)
        Me.TextBox3.TabIndex = 2
        '
        'Label34
        '
        Me.Label34.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(3, 97)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(124, 15)
        Me.Label34.TabIndex = 10
        Me.Label34.Text = "(*) Usuario"
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmConfiguracionBaseDatosViewModelBindingSource, "UsuarioLocalRed", True))
        Me.TextBox2.Location = New System.Drawing.Point(133, 94)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(229, 21)
        Me.TextBox2.TabIndex = 0
        '
        'btnVerificarBaseLocal
        '
        Me.btnVerificarBaseLocal.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnVerificarBaseLocal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVerificarBaseLocal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerificarBaseLocal.Image = Global.SistemaCinderella.My.Resources.Recursos.conectar_basedatos
        Me.btnVerificarBaseLocal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVerificarBaseLocal.Location = New System.Drawing.Point(374, 20)
        Me.btnVerificarBaseLocal.Name = "btnVerificarBaseLocal"
        Me.btnVerificarBaseLocal.Size = New System.Drawing.Size(115, 48)
        Me.btnVerificarBaseLocal.TabIndex = 27
        Me.btnVerificarBaseLocal.Text = "Verificar Conexión"
        Me.btnVerificarBaseLocal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVerificarBaseLocal.UseVisualStyleBackColor = True
        '
        'btnDescargarBaseRemota
        '
        Me.btnDescargarBaseRemota.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnDescargarBaseRemota.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDescargarBaseRemota.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDescargarBaseRemota.Image = Global.SistemaCinderella.My.Resources.Recursos.Descargar_Base
        Me.btnDescargarBaseRemota.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDescargarBaseRemota.Location = New System.Drawing.Point(383, 74)
        Me.btnDescargarBaseRemota.Name = "btnDescargarBaseRemota"
        Me.btnDescargarBaseRemota.Size = New System.Drawing.Size(115, 48)
        Me.btnDescargarBaseRemota.TabIndex = 33
        Me.btnDescargarBaseRemota.Text = "Copiar       Base Dat."
        Me.btnDescargarBaseRemota.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDescargarBaseRemota.UseVisualStyleBackColor = True
        '
        'Btn_Aceptar
        '
        Me.Btn_Aceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Aceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Aceptar.Image = Global.SistemaCinderella.My.Resources.Recursos.Conectado_32
        Me.Btn_Aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Aceptar.Location = New System.Drawing.Point(427, 539)
        Me.Btn_Aceptar.Name = "Btn_Aceptar"
        Me.Btn_Aceptar.Size = New System.Drawing.Size(95, 35)
        Me.Btn_Aceptar.TabIndex = 28
        Me.Btn_Aceptar.Text = "Aceptar"
        Me.Btn_Aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Aceptar.UseVisualStyleBackColor = True
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Cancelar.Image = Global.SistemaCinderella.My.Resources.Recursos.desconectado_32
        Me.Btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Cancelar.Location = New System.Drawing.Point(321, 539)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(100, 35)
        Me.Btn_Cancelar.TabIndex = 29
        Me.Btn_Cancelar.Text = "Cancelar"
        Me.Btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Cancelar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.TableLayoutPanel3)
        Me.GroupBox2.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(510, 384)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Conexion Base De Datos Local"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.GroupBox13, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.GroupBox1, 0, 0)
        Me.TableLayoutPanel3.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.FrmConfiguracionBaseDatosViewModelBindingSource, "HabilitarServidoresRed", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(6, 50)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 180.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(498, 328)
        Me.TableLayoutPanel3.TabIndex = 33
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Chk_Red, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Chk_Aislado, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(6, 19)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(256, 25)
        Me.TableLayoutPanel2.TabIndex = 33
        '
        'Chk_Red
        '
        Me.Chk_Red.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chk_Red.AutoSize = True
        Me.Chk_Red.Location = New System.Drawing.Point(131, 4)
        Me.Chk_Red.Name = "Chk_Red"
        Me.Chk_Red.Size = New System.Drawing.Size(122, 17)
        Me.Chk_Red.TabIndex = 1
        Me.Chk_Red.TabStop = True
        Me.Chk_Red.Text = "Red"
        Me.Chk_Red.UseVisualStyleBackColor = True
        '
        'Chk_Aislado
        '
        Me.Chk_Aislado.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chk_Aislado.AutoSize = True
        Me.Chk_Aislado.Location = New System.Drawing.Point(3, 4)
        Me.Chk_Aislado.Name = "Chk_Aislado"
        Me.Chk_Aislado.Size = New System.Drawing.Size(122, 17)
        Me.Chk_Aislado.TabIndex = 0
        Me.Chk_Aislado.TabStop = True
        Me.Chk_Aislado.Text = "Aislado"
        Me.Chk_Aislado.UseVisualStyleBackColor = True
        '
        'btnVerificarBaseRemota
        '
        Me.btnVerificarBaseRemota.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVerificarBaseRemota.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVerificarBaseRemota.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerificarBaseRemota.Image = Global.SistemaCinderella.My.Resources.Recursos.conectar_basedatos
        Me.btnVerificarBaseRemota.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVerificarBaseRemota.Location = New System.Drawing.Point(383, 21)
        Me.btnVerificarBaseRemota.Name = "btnVerificarBaseRemota"
        Me.btnVerificarBaseRemota.Size = New System.Drawing.Size(115, 48)
        Me.btnVerificarBaseRemota.TabIndex = 35
        Me.btnVerificarBaseRemota.Text = "Verificar Conexión"
        Me.btnVerificarBaseRemota.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVerificarBaseRemota.UseVisualStyleBackColor = True
        '
        'txt_StringDeConexionBaseRemota
        '
        Me.txt_StringDeConexionBaseRemota.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmConfiguracionBaseDatosViewModelBindingSource, "StringConeccionBaseRemota", True))
        Me.txt_StringDeConexionBaseRemota.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_StringDeConexionBaseRemota.Location = New System.Drawing.Point(104, 3)
        Me.txt_StringDeConexionBaseRemota.Multiline = True
        Me.txt_StringDeConexionBaseRemota.Name = "txt_StringDeConexionBaseRemota"
        Me.txt_StringDeConexionBaseRemota.Size = New System.Drawing.Size(267, 100)
        Me.txt_StringDeConexionBaseRemota.TabIndex = 34
        '
        'Label15
        '
        Me.Label15.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(3, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(95, 26)
        Me.Label15.TabIndex = 33
        Me.Label15.Text = "(*) Conexión base remota:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.btnDescargarBaseRemota)
        Me.GroupBox3.Controls.Add(Me.TableLayoutPanel4)
        Me.GroupBox3.Controls.Add(Me.btnVerificarBaseRemota)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 402)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(510, 131)
        Me.GroupBox3.TabIndex = 36
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Conexion Base De Datos Remota"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.12329!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.87671!))
        Me.TableLayoutPanel4.Controls.Add(Me.Label15, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.txt_StringDeConexionBaseRemota, 1, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(6, 19)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 106.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 106.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 106.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 106.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(374, 106)
        Me.TableLayoutPanel4.TabIndex = 37
        '
        'frmConfiguracionBaseDatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 586)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Btn_Cancelar)
        Me.Controls.Add(Me.Btn_Aceptar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConfiguracionBaseDatos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuración Base Datos"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DG_Servidores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServidoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FrmConfiguracionBaseDatosViewModelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox13.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DG_Servidores As CustomDataGrid
    Friend WithEvents GroupBox13 As GroupBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents btnVerificarBaseLocal As Button
    Friend WithEvents Btn_Aceptar As Button
    Friend WithEvents Btn_Cancelar As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents FrmConfiguracionBaseDatosViewModelBindingSource As BindingSource
    Friend WithEvents ServidoresBindingSource As BindingSource
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InstanciaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VersionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Chk_Red As RadioButton
    Friend WithEvents Chk_Aislado As RadioButton
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents btnDescargarBaseRemota As Button
    Friend WithEvents btnVerificarBaseRemota As Button
    Friend WithEvents txt_StringDeConexionBaseRemota As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCrearBaseLocal As Button
End Class
