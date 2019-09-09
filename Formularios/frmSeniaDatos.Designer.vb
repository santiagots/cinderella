<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSeniaDatos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSeniaDatos))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.rblEnvioPromocionesNo = New System.Windows.Forms.RadioButton()
        Me.rblEnvioPromocionesSi = New System.Windows.Forms.RadioButton()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.Btn_BuscarConsumidorFinal = New System.Windows.Forms.Button()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.cmbModoEntrega = New System.Windows.Forms.ComboBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.dpkFechaRetiro = New System.Windows.Forms.DateTimePicker()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.Btn_Finalizar = New System.Windows.Forms.Button()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.DG_Productos = New System.Windows.Forms.DataGridView()
        Me.CODIGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANTIDAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRECIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MONTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SUBTOTAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblPago = New System.Windows.Forms.Label()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblFacturado = New System.Windows.Forms.Label()
        Me.PanelTotalMayorista = New System.Windows.Forms.Panel()
        Me.lblImporteSaldarMayorista = New System.Windows.Forms.Label()
        Me.lblMontoMayorista = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lblIVAMayorista = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.lblSubtotalMayorista = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lblDescuentoMayorista = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.lblSeniaMayorista = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.PanelTotalMinorista = New System.Windows.Forms.Panel()
        Me.lblImporteSaldarMinorista = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblSeniaMinorista = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblMontoMinorista = New System.Windows.Forms.Label()
        Me.lblDescuentoMinorista = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblSubtotalMinorista = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblPorcentajeFacturacion = New System.Windows.Forms.Label()
        Me.lblTipoVenta = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblVendedor = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblFechaSeña = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblEncargado = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_Productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTotalMayorista.SuspendLayout()
        Me.PanelTotalMinorista.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox1.Controls.Add(Me.txtObservaciones)
        Me.GroupBox1.Controls.Add(Me.Label35)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(857, 199)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de la seña"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 6
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 4, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.lblNombre, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Btn_BuscarConsumidorFinal, 5, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtDireccion, 4, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.txtNombre, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label34, 3, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label29, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtTelefono, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.cmbModoEntrega, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label32, 3, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label30, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label33, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.dpkFechaRetiro, 4, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtMail, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label31, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lblApellido, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtApellido, 4, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(6, 18)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(845, 131)
        Me.TableLayoutPanel2.TabIndex = 73
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.rblEnvioPromocionesNo, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.rblEnvioPromocionesSi, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(533, 73)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(264, 24)
        Me.TableLayoutPanel3.TabIndex = 23
        '
        'rblEnvioPromocionesNo
        '
        Me.rblEnvioPromocionesNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rblEnvioPromocionesNo.AutoSize = True
        Me.rblEnvioPromocionesNo.Checked = True
        Me.rblEnvioPromocionesNo.Location = New System.Drawing.Point(3, 3)
        Me.rblEnvioPromocionesNo.Name = "rblEnvioPromocionesNo"
        Me.rblEnvioPromocionesNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.rblEnvioPromocionesNo.Size = New System.Drawing.Size(126, 18)
        Me.rblEnvioPromocionesNo.TabIndex = 7
        Me.rblEnvioPromocionesNo.TabStop = True
        Me.rblEnvioPromocionesNo.Text = "No"
        Me.rblEnvioPromocionesNo.UseVisualStyleBackColor = True
        '
        'rblEnvioPromocionesSi
        '
        Me.rblEnvioPromocionesSi.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rblEnvioPromocionesSi.AutoSize = True
        Me.rblEnvioPromocionesSi.Location = New System.Drawing.Point(135, 3)
        Me.rblEnvioPromocionesSi.Name = "rblEnvioPromocionesSi"
        Me.rblEnvioPromocionesSi.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.rblEnvioPromocionesSi.Size = New System.Drawing.Size(126, 18)
        Me.rblEnvioPromocionesSi.TabIndex = 8
        Me.rblEnvioPromocionesSi.Text = "Si"
        Me.rblEnvioPromocionesSi.UseVisualStyleBackColor = True
        '
        'lblNombre
        '
        Me.lblNombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(3, 12)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(94, 15)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre (*):"
        '
        'Btn_BuscarConsumidorFinal
        '
        Me.Btn_BuscarConsumidorFinal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_BuscarConsumidorFinal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_BuscarConsumidorFinal.FlatAppearance.BorderSize = 0
        Me.Btn_BuscarConsumidorFinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_BuscarConsumidorFinal.Image = Global.SistemaCinderella.My.Resources.Recursos.IconoBuscar32
        Me.Btn_BuscarConsumidorFinal.Location = New System.Drawing.Point(805, 3)
        Me.Btn_BuscarConsumidorFinal.Name = "Btn_BuscarConsumidorFinal"
        Me.Btn_BuscarConsumidorFinal.Size = New System.Drawing.Size(37, 34)
        Me.Btn_BuscarConsumidorFinal.TabIndex = 3
        Me.Btn_BuscarConsumidorFinal.UseVisualStyleBackColor = True
        '
        'txtDireccion
        '
        Me.txtDireccion.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDireccion.Location = New System.Drawing.Point(533, 105)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(264, 21)
        Me.txtDireccion.TabIndex = 10
        '
        'txtNombre
        '
        Me.txtNombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombre.Location = New System.Drawing.Point(103, 9)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(264, 21)
        Me.txtNombre.TabIndex = 1
        '
        'Label34
        '
        Me.Label34.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(433, 108)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(94, 15)
        Me.Label34.TabIndex = 20
        Me.Label34.Text = "Dirección (*):"
        '
        'Label29
        '
        Me.Label29.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(3, 47)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(94, 15)
        Me.Label29.TabIndex = 8
        Me.Label29.Text = "Telefono (*):"
        '
        'txtTelefono
        '
        Me.txtTelefono.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTelefono.Location = New System.Drawing.Point(103, 44)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(264, 21)
        Me.txtTelefono.TabIndex = 4
        '
        'cmbModoEntrega
        '
        Me.cmbModoEntrega.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbModoEntrega.FormattingEnabled = True
        Me.cmbModoEntrega.Items.AddRange(New Object() {"Seleccione una opción", "Envió a domicilio", "Retira de la sucursal", "A convenir"})
        Me.cmbModoEntrega.Location = New System.Drawing.Point(103, 104)
        Me.cmbModoEntrega.Name = "cmbModoEntrega"
        Me.cmbModoEntrega.Size = New System.Drawing.Size(264, 23)
        Me.cmbModoEntrega.TabIndex = 9
        '
        'Label32
        '
        Me.Label32.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(433, 70)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(94, 30)
        Me.Label32.TabIndex = 15
        Me.Label32.Text = "Enviar novedades y promociones:"
        '
        'Label30
        '
        Me.Label30.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(3, 77)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(94, 15)
        Me.Label30.TabIndex = 10
        Me.Label30.Text = "Email:"
        '
        'Label33
        '
        Me.Label33.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(3, 100)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(94, 30)
        Me.Label33.TabIndex = 18
        Me.Label33.Text = "Metodo de entrega:"
        '
        'dpkFechaRetiro
        '
        Me.dpkFechaRetiro.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dpkFechaRetiro.Location = New System.Drawing.Point(533, 44)
        Me.dpkFechaRetiro.Name = "dpkFechaRetiro"
        Me.dpkFechaRetiro.Size = New System.Drawing.Size(264, 21)
        Me.dpkFechaRetiro.TabIndex = 5
        '
        'txtMail
        '
        Me.txtMail.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMail.Location = New System.Drawing.Point(103, 74)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(264, 21)
        Me.txtMail.TabIndex = 6
        '
        'Label31
        '
        Me.Label31.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(433, 40)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(94, 30)
        Me.Label31.TabIndex = 12
        Me.Label31.Text = "F. estimada retiro (*):"
        '
        'lblApellido
        '
        Me.lblApellido.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido.Location = New System.Drawing.Point(433, 12)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(94, 15)
        Me.lblApellido.TabIndex = 2
        Me.lblApellido.Text = "Apellido (*):"
        '
        'txtApellido
        '
        Me.txtApellido.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtApellido.Location = New System.Drawing.Point(533, 9)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(264, 21)
        Me.txtApellido.TabIndex = 2
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtObservaciones.Location = New System.Drawing.Point(106, 155)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(745, 38)
        Me.txtObservaciones.TabIndex = 11
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(6, 155)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(94, 15)
        Me.Label35.TabIndex = 22
        Me.Label35.Text = "Observaciones :"
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Cancelar.Image = Global.SistemaCinderella.My.Resources.Recursos.desconectado_32
        Me.Btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Cancelar.Location = New System.Drawing.Point(654, 656)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Cancelar.TabIndex = 18
        Me.Btn_Cancelar.Text = "Cancelar"
        Me.Btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Cancelar.UseVisualStyleBackColor = True
        '
        'Btn_Finalizar
        '
        Me.Btn_Finalizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Finalizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Finalizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Finalizar.Image = Global.SistemaCinderella.My.Resources.Recursos.Conectado_32
        Me.Btn_Finalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Finalizar.Location = New System.Drawing.Point(760, 656)
        Me.Btn_Finalizar.Name = "Btn_Finalizar"
        Me.Btn_Finalizar.Size = New System.Drawing.Size(112, 40)
        Me.Btn_Finalizar.TabIndex = 19
        Me.Btn_Finalizar.Text = "Crear Seña"
        Me.Btn_Finalizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Finalizar.UseVisualStyleBackColor = True
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
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
        Me.DG_Productos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CODIGO, Me.NOMBRE, Me.CANTIDAD, Me.PRECIO, Me.IVA, Me.MONTO, Me.SUBTOTAL})
        Me.DG_Productos.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.DG_Productos.Location = New System.Drawing.Point(3, 83)
        Me.DG_Productos.MultiSelect = False
        Me.DG_Productos.Name = "DG_Productos"
        Me.DG_Productos.ReadOnly = True
        Me.DG_Productos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DG_Productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Productos.Size = New System.Drawing.Size(854, 208)
        Me.DG_Productos.TabIndex = 12
        '
        'CODIGO
        '
        Me.CODIGO.DataPropertyName = "CODIGO"
        Me.CODIGO.FillWeight = 107.5103!
        Me.CODIGO.HeaderText = "Código"
        Me.CODIGO.Name = "CODIGO"
        Me.CODIGO.ReadOnly = True
        '
        'NOMBRE
        '
        Me.NOMBRE.DataPropertyName = "NOMBRE"
        Me.NOMBRE.FillWeight = 177.4346!
        Me.NOMBRE.HeaderText = "Nombre"
        Me.NOMBRE.Name = "NOMBRE"
        Me.NOMBRE.ReadOnly = True
        '
        'CANTIDAD
        '
        Me.CANTIDAD.DataPropertyName = "CANTIDAD"
        Me.CANTIDAD.FillWeight = 73.49158!
        Me.CANTIDAD.HeaderText = "Cantidad"
        Me.CANTIDAD.Name = "CANTIDAD"
        Me.CANTIDAD.ReadOnly = True
        '
        'PRECIO
        '
        Me.PRECIO.DataPropertyName = "PRECIO"
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.PRECIO.DefaultCellStyle = DataGridViewCellStyle1
        Me.PRECIO.FillWeight = 81.69429!
        Me.PRECIO.HeaderText = "Precio"
        Me.PRECIO.Name = "PRECIO"
        Me.PRECIO.ReadOnly = True
        '
        'IVA
        '
        Me.IVA.DataPropertyName = "IVA"
        DataGridViewCellStyle2.Format = "2C"
        Me.IVA.DefaultCellStyle = DataGridViewCellStyle2
        Me.IVA.HeaderText = "Iva"
        Me.IVA.Name = "IVA"
        Me.IVA.ReadOnly = True
        '
        'MONTO
        '
        Me.MONTO.DataPropertyName = "MONTO"
        DataGridViewCellStyle3.Format = "2C"
        Me.MONTO.DefaultCellStyle = DataGridViewCellStyle3
        Me.MONTO.HeaderText = "Monto"
        Me.MONTO.Name = "MONTO"
        Me.MONTO.ReadOnly = True
        '
        'SUBTOTAL
        '
        Me.SUBTOTAL.DataPropertyName = "SUBTOTAL"
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.SUBTOTAL.DefaultCellStyle = DataGridViewCellStyle4
        Me.SUBTOTAL.FillWeight = 91.37056!
        Me.SUBTOTAL.HeaderText = "Subtotal"
        Me.SUBTOTAL.Name = "SUBTOTAL"
        Me.SUBTOTAL.ReadOnly = True
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 301)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 15)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "Tipo de Pago :"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 349)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 15)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "Cant. de productos :"
        '
        'lblPago
        '
        Me.lblPago.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblPago.AutoSize = True
        Me.lblPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPago.Location = New System.Drawing.Point(202, 301)
        Me.lblPago.Name = "lblPago"
        Me.lblPago.Size = New System.Drawing.Size(42, 15)
        Me.lblPago.TabIndex = 63
        Me.lblPago.Text = "- - - - - "
        '
        'lblCantidad
        '
        Me.lblCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad.Location = New System.Drawing.Point(202, 349)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(42, 15)
        Me.lblCantidad.TabIndex = 64
        Me.lblCantidad.Text = "- - - - - "
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 325)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 15)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Facturado :"
        '
        'lblFacturado
        '
        Me.lblFacturado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblFacturado.AutoSize = True
        Me.lblFacturado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFacturado.Location = New System.Drawing.Point(202, 325)
        Me.lblFacturado.Name = "lblFacturado"
        Me.lblFacturado.Size = New System.Drawing.Size(42, 15)
        Me.lblFacturado.TabIndex = 66
        Me.lblFacturado.Text = "- - - - - "
        '
        'PanelTotalMayorista
        '
        Me.PanelTotalMayorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelTotalMayorista.Controls.Add(Me.lblImporteSaldarMayorista)
        Me.PanelTotalMayorista.Controls.Add(Me.lblMontoMayorista)
        Me.PanelTotalMayorista.Controls.Add(Me.Label9)
        Me.PanelTotalMayorista.Controls.Add(Me.Label20)
        Me.PanelTotalMayorista.Controls.Add(Me.lblIVAMayorista)
        Me.PanelTotalMayorista.Controls.Add(Me.Label28)
        Me.PanelTotalMayorista.Controls.Add(Me.lblSubtotalMayorista)
        Me.PanelTotalMayorista.Controls.Add(Me.Label22)
        Me.PanelTotalMayorista.Controls.Add(Me.lblDescuentoMayorista)
        Me.PanelTotalMayorista.Controls.Add(Me.Label24)
        Me.PanelTotalMayorista.Controls.Add(Me.lblSeniaMayorista)
        Me.PanelTotalMayorista.Controls.Add(Me.Label26)
        Me.PanelTotalMayorista.Location = New System.Drawing.Point(606, 297)
        Me.PanelTotalMayorista.Name = "PanelTotalMayorista"
        Me.PanelTotalMayorista.Size = New System.Drawing.Size(251, 129)
        Me.PanelTotalMayorista.TabIndex = 67
        '
        'lblImporteSaldarMayorista
        '
        Me.lblImporteSaldarMayorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblImporteSaldarMayorista.AutoSize = True
        Me.lblImporteSaldarMayorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImporteSaldarMayorista.Location = New System.Drawing.Point(196, 109)
        Me.lblImporteSaldarMayorista.Name = "lblImporteSaldarMayorista"
        Me.lblImporteSaldarMayorista.Size = New System.Drawing.Size(42, 15)
        Me.lblImporteSaldarMayorista.TabIndex = 50
        Me.lblImporteSaldarMayorista.Text = "- - - - - "
        '
        'lblMontoMayorista
        '
        Me.lblMontoMayorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblMontoMayorista.AutoSize = True
        Me.lblMontoMayorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontoMayorista.Location = New System.Drawing.Point(195, 68)
        Me.lblMontoMayorista.Name = "lblMontoMayorista"
        Me.lblMontoMayorista.Size = New System.Drawing.Size(42, 15)
        Me.lblMontoMayorista.TabIndex = 44
        Me.lblMontoMayorista.Text = "- - - - - "
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 109)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 15)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Importe a saldar :"
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(6, 68)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(74, 15)
        Me.Label20.TabIndex = 43
        Me.Label20.Text = "Monto total :"
        '
        'lblIVAMayorista
        '
        Me.lblIVAMayorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblIVAMayorista.AutoSize = True
        Me.lblIVAMayorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIVAMayorista.Location = New System.Drawing.Point(195, 47)
        Me.lblIVAMayorista.Name = "lblIVAMayorista"
        Me.lblIVAMayorista.Size = New System.Drawing.Size(42, 15)
        Me.lblIVAMayorista.TabIndex = 42
        Me.lblIVAMayorista.Text = "- - - - - "
        '
        'Label28
        '
        Me.Label28.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(6, 47)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(58, 15)
        Me.Label28.TabIndex = 41
        Me.Label28.Text = "IVA 21% :"
        '
        'lblSubtotalMayorista
        '
        Me.lblSubtotalMayorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSubtotalMayorista.AutoSize = True
        Me.lblSubtotalMayorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtotalMayorista.Location = New System.Drawing.Point(195, 24)
        Me.lblSubtotalMayorista.Name = "lblSubtotalMayorista"
        Me.lblSubtotalMayorista.Size = New System.Drawing.Size(42, 15)
        Me.lblSubtotalMayorista.TabIndex = 40
        Me.lblSubtotalMayorista.Text = "- - - - - "
        '
        'Label22
        '
        Me.Label22.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(5, 24)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(58, 15)
        Me.Label22.TabIndex = 39
        Me.Label22.Text = "Subtotal :"
        '
        'lblDescuentoMayorista
        '
        Me.lblDescuentoMayorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDescuentoMayorista.AutoSize = True
        Me.lblDescuentoMayorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescuentoMayorista.Location = New System.Drawing.Point(195, 4)
        Me.lblDescuentoMayorista.Name = "lblDescuentoMayorista"
        Me.lblDescuentoMayorista.Size = New System.Drawing.Size(42, 15)
        Me.lblDescuentoMayorista.TabIndex = 38
        Me.lblDescuentoMayorista.Text = "- - - - - "
        '
        'Label24
        '
        Me.Label24.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(5, 4)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(72, 15)
        Me.Label24.TabIndex = 37
        Me.Label24.Text = "Descuento :"
        '
        'lblSeniaMayorista
        '
        Me.lblSeniaMayorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSeniaMayorista.AutoSize = True
        Me.lblSeniaMayorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeniaMayorista.Location = New System.Drawing.Point(195, 89)
        Me.lblSeniaMayorista.Name = "lblSeniaMayorista"
        Me.lblSeniaMayorista.Size = New System.Drawing.Size(42, 15)
        Me.lblSeniaMayorista.TabIndex = 36
        Me.lblSeniaMayorista.Text = "- - - - - "
        '
        'Label26
        '
        Me.Label26.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(5, 89)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(39, 15)
        Me.Label26.TabIndex = 35
        Me.Label26.Text = "Seña:"
        '
        'PanelTotalMinorista
        '
        Me.PanelTotalMinorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelTotalMinorista.Controls.Add(Me.lblImporteSaldarMinorista)
        Me.PanelTotalMinorista.Controls.Add(Me.Label7)
        Me.PanelTotalMinorista.Controls.Add(Me.lblSeniaMinorista)
        Me.PanelTotalMinorista.Controls.Add(Me.Label23)
        Me.PanelTotalMinorista.Controls.Add(Me.Label6)
        Me.PanelTotalMinorista.Controls.Add(Me.Label10)
        Me.PanelTotalMinorista.Controls.Add(Me.lblMontoMinorista)
        Me.PanelTotalMinorista.Controls.Add(Me.lblDescuentoMinorista)
        Me.PanelTotalMinorista.Controls.Add(Me.Label16)
        Me.PanelTotalMinorista.Controls.Add(Me.lblSubtotalMinorista)
        Me.PanelTotalMinorista.Location = New System.Drawing.Point(342, 298)
        Me.PanelTotalMinorista.Name = "PanelTotalMinorista"
        Me.PanelTotalMinorista.Size = New System.Drawing.Size(258, 128)
        Me.PanelTotalMinorista.TabIndex = 68
        '
        'lblImporteSaldarMinorista
        '
        Me.lblImporteSaldarMinorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblImporteSaldarMinorista.AutoSize = True
        Me.lblImporteSaldarMinorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImporteSaldarMinorista.Location = New System.Drawing.Point(193, 91)
        Me.lblImporteSaldarMinorista.Name = "lblImporteSaldarMinorista"
        Me.lblImporteSaldarMinorista.Size = New System.Drawing.Size(42, 15)
        Me.lblImporteSaldarMinorista.TabIndex = 48
        Me.lblImporteSaldarMinorista.Text = "- - - - - "
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 91)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 15)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "Importe a saldar :"
        '
        'lblSeniaMinorista
        '
        Me.lblSeniaMinorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSeniaMinorista.AutoSize = True
        Me.lblSeniaMinorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeniaMinorista.Location = New System.Drawing.Point(193, 69)
        Me.lblSeniaMinorista.Name = "lblSeniaMinorista"
        Me.lblSeniaMinorista.Size = New System.Drawing.Size(42, 15)
        Me.lblSeniaMinorista.TabIndex = 46
        Me.lblSeniaMinorista.Text = "- - - - - "
        '
        'Label23
        '
        Me.Label23.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(3, 69)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(42, 15)
        Me.Label23.TabIndex = 45
        Me.Label23.Text = "Seña :"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 15)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Descuento :"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(3, 47)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 15)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Monto total :"
        '
        'lblMontoMinorista
        '
        Me.lblMontoMinorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblMontoMinorista.AutoSize = True
        Me.lblMontoMinorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontoMinorista.Location = New System.Drawing.Point(193, 47)
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
        Me.lblDescuentoMinorista.Location = New System.Drawing.Point(193, 26)
        Me.lblDescuentoMinorista.Name = "lblDescuentoMinorista"
        Me.lblDescuentoMinorista.Size = New System.Drawing.Size(42, 15)
        Me.lblDescuentoMinorista.TabIndex = 32
        Me.lblDescuentoMinorista.Text = "- - - - - "
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(3, 3)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(58, 15)
        Me.Label16.TabIndex = 33
        Me.Label16.Text = "Subtotal :"
        '
        'lblSubtotalMinorista
        '
        Me.lblSubtotalMinorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSubtotalMinorista.AutoSize = True
        Me.lblSubtotalMinorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtotalMinorista.Location = New System.Drawing.Point(193, 3)
        Me.lblSubtotalMinorista.Name = "lblSubtotalMinorista"
        Me.lblSubtotalMinorista.Size = New System.Drawing.Size(42, 15)
        Me.lblSubtotalMinorista.TabIndex = 34
        Me.lblSubtotalMinorista.Text = "- - - - - "
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox2.Controls.Add(Me.PanelTotalMinorista)
        Me.GroupBox2.Controls.Add(Me.PanelTotalMayorista)
        Me.GroupBox2.Controls.Add(Me.lblFacturado)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.lblCantidad)
        Me.GroupBox2.Controls.Add(Me.lblPago)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.DG_Productos)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 217)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(860, 433)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalle de la seña"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 8
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label17, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblPorcentajeFacturacion, 7, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblTipoVenta, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label14, 6, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label18, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblVendedor, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label15, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblFechaSeña, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblEncargado, 4, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(6, 16)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(851, 60)
        Me.TableLayoutPanel1.TabIndex = 72
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(3, 7)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(104, 15)
        Me.Label17.TabIndex = 50
        Me.Label17.Text = "Tipo de Venta :"
        '
        'lblPorcentajeFacturacion
        '
        Me.lblPorcentajeFacturacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPorcentajeFacturacion.AutoSize = True
        Me.lblPorcentajeFacturacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPorcentajeFacturacion.Location = New System.Drawing.Point(741, 7)
        Me.lblPorcentajeFacturacion.Name = "lblPorcentajeFacturacion"
        Me.lblPorcentajeFacturacion.Size = New System.Drawing.Size(107, 15)
        Me.lblPorcentajeFacturacion.TabIndex = 70
        Me.lblPorcentajeFacturacion.Text = "- - - - - "
        '
        'lblTipoVenta
        '
        Me.lblTipoVenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTipoVenta.AutoSize = True
        Me.lblTipoVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoVenta.Location = New System.Drawing.Point(113, 7)
        Me.lblTipoVenta.Name = "lblTipoVenta"
        Me.lblTipoVenta.Size = New System.Drawing.Size(104, 15)
        Me.lblTipoVenta.TabIndex = 56
        Me.lblTipoVenta.Text = "- - - - - "
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(631, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(104, 30)
        Me.Label14.TabIndex = 69
        Me.Label14.Text = "Porcentaje Facturación :"
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(3, 37)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(104, 15)
        Me.Label18.TabIndex = 49
        Me.Label18.Text = "Vendedor :"
        '
        'lblVendedor
        '
        Me.lblVendedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVendedor.AutoSize = True
        Me.lblVendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVendedor.Location = New System.Drawing.Point(113, 37)
        Me.lblVendedor.Name = "lblVendedor"
        Me.lblVendedor.Size = New System.Drawing.Size(104, 15)
        Me.lblVendedor.TabIndex = 55
        Me.lblVendedor.Text = "- - - - - "
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(317, 7)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(104, 15)
        Me.Label15.TabIndex = 51
        Me.Label15.Text = "Fecha Seña :"
        '
        'lblFechaSeña
        '
        Me.lblFechaSeña.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFechaSeña.AutoSize = True
        Me.lblFechaSeña.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaSeña.Location = New System.Drawing.Point(427, 7)
        Me.lblFechaSeña.Name = "lblFechaSeña"
        Me.lblFechaSeña.Size = New System.Drawing.Size(104, 15)
        Me.lblFechaSeña.TabIndex = 53
        Me.lblFechaSeña.Text = "- - - - - "
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(317, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 15)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Encargado :"
        '
        'lblEncargado
        '
        Me.lblEncargado.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEncargado.AutoSize = True
        Me.lblEncargado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEncargado.Location = New System.Drawing.Point(427, 37)
        Me.lblEncargado.Name = "lblEncargado"
        Me.lblEncargado.Size = New System.Drawing.Size(104, 15)
        Me.lblEncargado.TabIndex = 60
        Me.lblEncargado.Text = "- - - - - "
        '
        'frmSeniaDatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 702)
        Me.Controls.Add(Me.Btn_Cancelar)
        Me.Controls.Add(Me.Btn_Finalizar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSeniaDatos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Información de la seña"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_Productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTotalMayorista.ResumeLayout(False)
        Me.PanelTotalMayorista.PerformLayout()
        Me.PanelTotalMinorista.ResumeLayout(False)
        Me.PanelTotalMinorista.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents lblApellido As Label
    Friend WithEvents dpkFechaRetiro As DateTimePicker
    Friend WithEvents Label31 As Label
    Friend WithEvents txtMail As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents Btn_BuscarConsumidorFinal As Button
    Friend WithEvents cmbModoEntrega As ComboBox
    Friend WithEvents rblEnvioPromocionesSi As RadioButton
    Friend WithEvents rblEnvioPromocionesNo As RadioButton
    Friend WithEvents Label32 As Label
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents Label35 As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents Btn_Cancelar As Button
    Friend WithEvents Btn_Finalizar As Button
    Friend WithEvents ErrorProvider As ErrorProvider
    Friend WithEvents Label33 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label17 As Label
    Friend WithEvents lblPorcentajeFacturacion As Label
    Friend WithEvents lblTipoVenta As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents lblVendedor As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents lblFechaSeña As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblEncargado As Label
    Friend WithEvents PanelTotalMinorista As Panel
    Friend WithEvents lblImporteSaldarMinorista As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblSeniaMinorista As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblMontoMinorista As Label
    Friend WithEvents lblDescuentoMinorista As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents lblSubtotalMinorista As Label
    Friend WithEvents PanelTotalMayorista As Panel
    Friend WithEvents lblImporteSaldarMayorista As Label
    Friend WithEvents lblMontoMayorista As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents lblIVAMayorista As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents lblSubtotalMayorista As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents lblDescuentoMayorista As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents lblSeniaMayorista As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents lblFacturado As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblCantidad As Label
    Friend WithEvents lblPago As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DG_Productos As DataGridView
    Friend WithEvents CODIGO As DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE As DataGridViewTextBoxColumn
    Friend WithEvents CANTIDAD As DataGridViewTextBoxColumn
    Friend WithEvents PRECIO As DataGridViewTextBoxColumn
    Friend WithEvents IVA As DataGridViewTextBoxColumn
    Friend WithEvents MONTO As DataGridViewTextBoxColumn
    Friend WithEvents SUBTOTAL As DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
End Class
