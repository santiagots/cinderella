<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReservaDetalle
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReservaDetalle))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.VentaDetalle1 = New SistemaCinderella.VentaDetalle()
        Me.ReservaDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MetodoEntregaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.GroupBox2.SuspendLayout()
        CType(Me.ReservaDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MetodoEntregaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.VentaDetalle1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 208)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(894, 538)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalle Reserva"
        '
        'VentaDetalle1
        '
        Me.VentaDetalle1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VentaDetalle1.Location = New System.Drawing.Point(3, 17)
        Me.VentaDetalle1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.VentaDetalle1.Name = "VentaDetalle1"
        Me.VentaDetalle1.Size = New System.Drawing.Size(888, 518)
        Me.VentaDetalle1.TabIndex = 0
        '
        'ReservaDetalleBindingSource
        '
        Me.ReservaDetalleBindingSource.DataSource = GetType(SistemaCinderella.VistaModelo.Ventas.ReservaDetalle)
        '
        'MetodoEntregaBindingSource
        '
        Me.MetodoEntregaBindingSource.DataMember = "MetodoEntrega"
        Me.MetodoEntregaBindingSource.DataSource = Me.ReservaDetalleBindingSource
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox1.Controls.Add(Me.txtObservaciones)
        Me.GroupBox1.Controls.Add(Me.Label35)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(894, 199)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Reserva"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 6
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46.0!))
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
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(882, 131)
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
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(561, 73)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(272, 24)
        Me.TableLayoutPanel3.TabIndex = 23
        '
        'rblEnvioPromocionesNo
        '
        Me.rblEnvioPromocionesNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rblEnvioPromocionesNo.AutoSize = True
        Me.rblEnvioPromocionesNo.Checked = True
        Me.rblEnvioPromocionesNo.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.ReservaDetalleBindingSource, "NoEnvioNovedades", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.rblEnvioPromocionesNo.Location = New System.Drawing.Point(3, 3)
        Me.rblEnvioPromocionesNo.Name = "rblEnvioPromocionesNo"
        Me.rblEnvioPromocionesNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.rblEnvioPromocionesNo.Size = New System.Drawing.Size(130, 18)
        Me.rblEnvioPromocionesNo.TabIndex = 7
        Me.rblEnvioPromocionesNo.TabStop = True
        Me.rblEnvioPromocionesNo.Text = "No"
        Me.rblEnvioPromocionesNo.UseVisualStyleBackColor = True
        '
        'rblEnvioPromocionesSi
        '
        Me.rblEnvioPromocionesSi.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rblEnvioPromocionesSi.AutoSize = True
        Me.rblEnvioPromocionesSi.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.ReservaDetalleBindingSource, "EnvioNovedades", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.rblEnvioPromocionesSi.Location = New System.Drawing.Point(139, 3)
        Me.rblEnvioPromocionesSi.Name = "rblEnvioPromocionesSi"
        Me.rblEnvioPromocionesSi.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.rblEnvioPromocionesSi.Size = New System.Drawing.Size(130, 18)
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
        Me.lblNombre.Size = New System.Drawing.Size(124, 15)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre (*):"
        '
        'Btn_BuscarConsumidorFinal
        '
        Me.Btn_BuscarConsumidorFinal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_BuscarConsumidorFinal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_BuscarConsumidorFinal.FlatAppearance.BorderSize = 0
        Me.Btn_BuscarConsumidorFinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_BuscarConsumidorFinal.Image = CType(resources.GetObject("Btn_BuscarConsumidorFinal.Image"), System.Drawing.Image)
        Me.Btn_BuscarConsumidorFinal.Location = New System.Drawing.Point(842, 3)
        Me.Btn_BuscarConsumidorFinal.Name = "Btn_BuscarConsumidorFinal"
        Me.Btn_BuscarConsumidorFinal.Size = New System.Drawing.Size(37, 34)
        Me.Btn_BuscarConsumidorFinal.TabIndex = 3
        Me.Btn_BuscarConsumidorFinal.UseVisualStyleBackColor = True
        '
        'txtDireccion
        '
        Me.txtDireccion.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDireccion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReservaDetalleBindingSource, "Direccion", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtDireccion.DataBindings.Add(New System.Windows.Forms.Binding("Visible", Me.ReservaDetalleBindingSource, "DireccionVisible", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtDireccion.Location = New System.Drawing.Point(561, 105)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(272, 21)
        Me.txtDireccion.TabIndex = 10
        '
        'txtNombre
        '
        Me.txtNombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReservaDetalleBindingSource, "Nombre", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtNombre.Location = New System.Drawing.Point(133, 9)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(272, 21)
        Me.txtNombre.TabIndex = 1
        '
        'Label34
        '
        Me.Label34.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label34.AutoSize = True
        Me.Label34.DataBindings.Add(New System.Windows.Forms.Binding("Visible", Me.ReservaDetalleBindingSource, "DireccionVisible", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(431, 108)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(124, 15)
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
        Me.Label29.Size = New System.Drawing.Size(124, 15)
        Me.Label29.TabIndex = 8
        Me.Label29.Text = "Telefono (*):"
        '
        'txtTelefono
        '
        Me.txtTelefono.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTelefono.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReservaDetalleBindingSource, "Telefono", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtTelefono.Location = New System.Drawing.Point(133, 44)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(272, 21)
        Me.txtTelefono.TabIndex = 4
        '
        'cmbModoEntrega
        '
        Me.cmbModoEntrega.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbModoEntrega.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.ReservaDetalleBindingSource, "MetodoEntregaSeleccionado", True))
        Me.cmbModoEntrega.DataSource = Me.MetodoEntregaBindingSource
        Me.cmbModoEntrega.DisplayMember = "Value"
        Me.cmbModoEntrega.FormattingEnabled = True
        Me.cmbModoEntrega.Location = New System.Drawing.Point(133, 105)
        Me.cmbModoEntrega.Name = "cmbModoEntrega"
        Me.cmbModoEntrega.Size = New System.Drawing.Size(272, 23)
        Me.cmbModoEntrega.TabIndex = 9
        Me.cmbModoEntrega.ValueMember = "Key"
        '
        'Label32
        '
        Me.Label32.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(431, 70)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(124, 30)
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
        Me.Label30.Size = New System.Drawing.Size(124, 15)
        Me.Label30.TabIndex = 10
        Me.Label30.Text = "Email:"
        '
        'Label33
        '
        Me.Label33.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(3, 108)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(124, 15)
        Me.Label33.TabIndex = 18
        Me.Label33.Text = "Metodo de entrega:"
        '
        'dpkFechaRetiro
        '
        Me.dpkFechaRetiro.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dpkFechaRetiro.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ReservaDetalleBindingSource, "FechaEstimadaRetiro", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.dpkFechaRetiro.Location = New System.Drawing.Point(561, 44)
        Me.dpkFechaRetiro.Name = "dpkFechaRetiro"
        Me.dpkFechaRetiro.Size = New System.Drawing.Size(272, 21)
        Me.dpkFechaRetiro.TabIndex = 5
        '
        'txtMail
        '
        Me.txtMail.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReservaDetalleBindingSource, "Email", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtMail.Location = New System.Drawing.Point(133, 74)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(272, 21)
        Me.txtMail.TabIndex = 6
        '
        'Label31
        '
        Me.Label31.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(431, 47)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(124, 15)
        Me.Label31.TabIndex = 12
        Me.Label31.Text = "F. estimada retiro (*):"
        '
        'lblApellido
        '
        Me.lblApellido.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido.Location = New System.Drawing.Point(431, 12)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(124, 15)
        Me.lblApellido.TabIndex = 2
        Me.lblApellido.Text = "Apellido (*):"
        '
        'txtApellido
        '
        Me.txtApellido.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtApellido.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReservaDetalleBindingSource, "Apellido", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtApellido.Location = New System.Drawing.Point(561, 9)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(272, 21)
        Me.txtApellido.TabIndex = 2
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtObservaciones.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReservaDetalleBindingSource, "Observaciones", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtObservaciones.Location = New System.Drawing.Point(139, 155)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(746, 38)
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
        'ReservaDetalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "ReservaDetalle"
        Me.Size = New System.Drawing.Size(900, 749)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.ReservaDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MetodoEntregaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents VentaDetalle1 As VentaDetalle
    Friend WithEvents ReservaDetalleBindingSource As BindingSource
    Friend WithEvents MetodoEntregaBindingSource As BindingSource
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents rblEnvioPromocionesNo As RadioButton
    Friend WithEvents rblEnvioPromocionesSi As RadioButton
    Friend WithEvents lblNombre As Label
    Friend WithEvents Btn_BuscarConsumidorFinal As Button
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents cmbModoEntrega As ComboBox
    Friend WithEvents Label32 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents dpkFechaRetiro As DateTimePicker
    Friend WithEvents txtMail As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents lblApellido As Label
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents Label35 As Label
End Class
