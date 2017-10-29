<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFacturar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFacturar))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PanelTotalMayorista = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lbl_CostoFinancieroMayorista = New System.Windows.Forms.Label()
        Me.lbl_TotalMayorista = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lbl_DescuentoMayorista = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lbl_IvaMayorista = New System.Windows.Forms.Label()
        Me.lbl_SubtotalMayorista = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_Factura_Origen = New System.Windows.Forms.TextBox()
        Me.txt_Pago = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_Cuit = New System.Windows.Forms.TextBox()
        Me.lbl_TipoPago = New System.Windows.Forms.Label()
        Me.txt_Localidad = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_Direccion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_Nombre = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Cb_IVA = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PanelTotalMinorista = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_CostoFinancieroMinorista = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lbl_TotalMinorista = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_DescuentoMinorista = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbl_SubtotalMinorista = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lbl_Fecha = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnFacturar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Cb_TipoFacturacion = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GB_FacturacionManual = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.QuitarNumeroFactura = New System.Windows.Forms.Button()
        Me.AgregarNumeroFactura = New System.Windows.Forms.Button()
        Me.FacturasList = New System.Windows.Forms.ListBox()
        Me.txt_NumeroFacturaManual = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnNotaCredito = New System.Windows.Forms.Button()
        Me.lblError = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.PanelTotalMayorista.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.PanelTotalMinorista.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GB_FacturacionManual.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.PanelTotalMayorista)
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox1.Controls.Add(Me.PanelTotalMinorista)
        Me.GroupBox1.Controls.Add(Me.lbl_Fecha)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 89)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(368, 395)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información"
        '
        'PanelTotalMayorista
        '
        Me.PanelTotalMayorista.Controls.Add(Me.TableLayoutPanel2)
        Me.PanelTotalMayorista.Location = New System.Drawing.Point(226, 11)
        Me.PanelTotalMayorista.Name = "PanelTotalMayorista"
        Me.PanelTotalMayorista.Size = New System.Drawing.Size(358, 130)
        Me.PanelTotalMayorista.TabIndex = 27
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.113!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.887!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label20, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_CostoFinancieroMayorista, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_TotalMayorista, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Label23, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_DescuentoMayorista, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label21, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label18, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_IvaMayorista, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_SubtotalMayorista, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label17, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(4, 5)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 5
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(354, 125)
        Me.TableLayoutPanel2.TabIndex = 12
        '
        'Label20
        '
        Me.Label20.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(4, 30)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(99, 15)
        Me.Label20.TabIndex = 19
        Me.Label20.Text = "Costo Financiero"
        '
        'lbl_CostoFinancieroMayorista
        '
        Me.lbl_CostoFinancieroMayorista.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl_CostoFinancieroMayorista.AutoSize = True
        Me.lbl_CostoFinancieroMayorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CostoFinancieroMayorista.Location = New System.Drawing.Point(145, 29)
        Me.lbl_CostoFinancieroMayorista.Name = "lbl_CostoFinancieroMayorista"
        Me.lbl_CostoFinancieroMayorista.Size = New System.Drawing.Size(73, 16)
        Me.lbl_CostoFinancieroMayorista.TabIndex = 20
        Me.lbl_CostoFinancieroMayorista.Text = "$ 120.00.-"
        '
        'lbl_TotalMayorista
        '
        Me.lbl_TotalMayorista.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl_TotalMayorista.AutoSize = True
        Me.lbl_TotalMayorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TotalMayorista.Location = New System.Drawing.Point(145, 104)
        Me.lbl_TotalMayorista.Name = "lbl_TotalMayorista"
        Me.lbl_TotalMayorista.Size = New System.Drawing.Size(73, 16)
        Me.lbl_TotalMayorista.TabIndex = 23
        Me.lbl_TotalMayorista.Text = "$ 120.00.-"
        '
        'Label23
        '
        Me.Label23.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(4, 105)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(34, 15)
        Me.Label23.TabIndex = 22
        Me.Label23.Text = "Total"
        '
        'lbl_DescuentoMayorista
        '
        Me.lbl_DescuentoMayorista.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl_DescuentoMayorista.AutoSize = True
        Me.lbl_DescuentoMayorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DescuentoMayorista.Location = New System.Drawing.Point(145, 4)
        Me.lbl_DescuentoMayorista.Name = "lbl_DescuentoMayorista"
        Me.lbl_DescuentoMayorista.Size = New System.Drawing.Size(73, 16)
        Me.lbl_DescuentoMayorista.TabIndex = 19
        Me.lbl_DescuentoMayorista.Text = "$ 120.00.-"
        '
        'Label21
        '
        Me.Label21.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(4, 55)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(52, 15)
        Me.Label21.TabIndex = 20
        Me.Label21.Text = "Subtotal"
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(4, 80)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(50, 15)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Iva 21%"
        '
        'lbl_IvaMayorista
        '
        Me.lbl_IvaMayorista.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl_IvaMayorista.AutoSize = True
        Me.lbl_IvaMayorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_IvaMayorista.Location = New System.Drawing.Point(145, 79)
        Me.lbl_IvaMayorista.Name = "lbl_IvaMayorista"
        Me.lbl_IvaMayorista.Size = New System.Drawing.Size(73, 16)
        Me.lbl_IvaMayorista.TabIndex = 3
        Me.lbl_IvaMayorista.Text = "$ 120.00.-"
        '
        'lbl_SubtotalMayorista
        '
        Me.lbl_SubtotalMayorista.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl_SubtotalMayorista.AutoSize = True
        Me.lbl_SubtotalMayorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SubtotalMayorista.Location = New System.Drawing.Point(145, 54)
        Me.lbl_SubtotalMayorista.Name = "lbl_SubtotalMayorista"
        Me.lbl_SubtotalMayorista.Size = New System.Drawing.Size(73, 16)
        Me.lbl_SubtotalMayorista.TabIndex = 21
        Me.lbl_SubtotalMayorista.Text = "$ 120.00.-"
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(4, 5)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(66, 15)
        Me.Label17.TabIndex = 18
        Me.Label17.Text = "Descuento"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label16, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Factura_Origen, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Pago, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Cuit, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_TipoPago, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Localidad, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label15, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Direccion, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Nombre, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Cb_IVA, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 6)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(7, 178)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 8
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(354, 205)
        Me.TableLayoutPanel1.TabIndex = 14
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(3, 30)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(36, 15)
        Me.Label16.TabIndex = 25
        Me.Label16.Text = "Pago"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(4, 5)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 15)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Tipo de Pago"
        '
        'txt_Factura_Origen
        '
        Me.txt_Factura_Origen.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Factura_Origen.Location = New System.Drawing.Point(144, 179)
        Me.txt_Factura_Origen.Name = "txt_Factura_Origen"
        Me.txt_Factura_Origen.Size = New System.Drawing.Size(207, 21)
        Me.txt_Factura_Origen.TabIndex = 6
        '
        'txt_Pago
        '
        Me.txt_Pago.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Pago.Location = New System.Drawing.Point(144, 28)
        Me.txt_Pago.Name = "txt_Pago"
        Me.txt_Pago.Size = New System.Drawing.Size(207, 21)
        Me.txt_Pago.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 55)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Condición de IVA"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nombre y Apellido"
        '
        'txt_Cuit
        '
        Me.txt_Cuit.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Cuit.Location = New System.Drawing.Point(144, 153)
        Me.txt_Cuit.Name = "txt_Cuit"
        Me.txt_Cuit.Size = New System.Drawing.Size(207, 21)
        Me.txt_Cuit.TabIndex = 5
        '
        'lbl_TipoPago
        '
        Me.lbl_TipoPago.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl_TipoPago.AutoSize = True
        Me.lbl_TipoPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TipoPago.Location = New System.Drawing.Point(144, 5)
        Me.lbl_TipoPago.Name = "lbl_TipoPago"
        Me.lbl_TipoPago.Size = New System.Drawing.Size(64, 15)
        Me.lbl_TipoPago.TabIndex = 17
        Me.lbl_TipoPago.Text = "EFECTIVO"
        '
        'txt_Localidad
        '
        Me.txt_Localidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Localidad.Location = New System.Drawing.Point(144, 128)
        Me.txt_Localidad.Name = "txt_Localidad"
        Me.txt_Localidad.Size = New System.Drawing.Size(207, 21)
        Me.txt_Localidad.TabIndex = 4
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(3, 182)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(88, 15)
        Me.Label15.TabIndex = 23
        Me.Label15.Text = "Factura Origen"
        '
        'txt_Direccion
        '
        Me.txt_Direccion.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Direccion.Location = New System.Drawing.Point(144, 103)
        Me.txt_Direccion.Name = "txt_Direccion"
        Me.txt_Direccion.Size = New System.Drawing.Size(207, 21)
        Me.txt_Direccion.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Dirección"
        '
        'txt_Nombre
        '
        Me.txt_Nombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Nombre.Location = New System.Drawing.Point(144, 78)
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.Size = New System.Drawing.Size(207, 21)
        Me.txt_Nombre.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 130)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 15)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Localidad"
        '
        'Cb_IVA
        '
        Me.Cb_IVA.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cb_IVA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cb_IVA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_IVA.FormattingEnabled = True
        Me.Cb_IVA.Location = New System.Drawing.Point(144, 53)
        Me.Cb_IVA.Name = "Cb_IVA"
        Me.Cb_IVA.Size = New System.Drawing.Size(207, 23)
        Me.Cb_IVA.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 15)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "CUIT (sólo numeros)"
        '
        'PanelTotalMinorista
        '
        Me.PanelTotalMinorista.Controls.Add(Me.TableLayoutPanel3)
        Me.PanelTotalMinorista.Location = New System.Drawing.Point(3, 40)
        Me.PanelTotalMinorista.Name = "PanelTotalMinorista"
        Me.PanelTotalMinorista.Size = New System.Drawing.Size(358, 130)
        Me.PanelTotalMinorista.TabIndex = 26
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.113!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.887!))
        Me.TableLayoutPanel3.Controls.Add(Me.lbl_CostoFinancieroMinorista, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Label22, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.lbl_TotalMinorista, 1, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.Label1, 0, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.lbl_DescuentoMinorista, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label11, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.lbl_SubtotalMinorista, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label12, 0, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(4, 5)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 5
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(354, 125)
        Me.TableLayoutPanel3.TabIndex = 14
        '
        'lbl_CostoFinancieroMinorista
        '
        Me.lbl_CostoFinancieroMinorista.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl_CostoFinancieroMinorista.AutoSize = True
        Me.lbl_CostoFinancieroMinorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CostoFinancieroMinorista.Location = New System.Drawing.Point(145, 54)
        Me.lbl_CostoFinancieroMinorista.Name = "lbl_CostoFinancieroMinorista"
        Me.lbl_CostoFinancieroMinorista.Size = New System.Drawing.Size(73, 16)
        Me.lbl_CostoFinancieroMinorista.TabIndex = 23
        Me.lbl_CostoFinancieroMinorista.Text = "$ 120.00.-"
        '
        'Label22
        '
        Me.Label22.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(4, 55)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(99, 15)
        Me.Label22.TabIndex = 22
        Me.Label22.Text = "Costo Financiero"
        '
        'lbl_TotalMinorista
        '
        Me.lbl_TotalMinorista.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl_TotalMinorista.AutoSize = True
        Me.lbl_TotalMinorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TotalMinorista.Location = New System.Drawing.Point(145, 104)
        Me.lbl_TotalMinorista.Name = "lbl_TotalMinorista"
        Me.lbl_TotalMinorista.Size = New System.Drawing.Size(73, 16)
        Me.lbl_TotalMinorista.TabIndex = 3
        Me.lbl_TotalMinorista.Text = "$ 120.00.-"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 105)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total"
        '
        'lbl_DescuentoMinorista
        '
        Me.lbl_DescuentoMinorista.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl_DescuentoMinorista.AutoSize = True
        Me.lbl_DescuentoMinorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DescuentoMinorista.Location = New System.Drawing.Point(145, 29)
        Me.lbl_DescuentoMinorista.Name = "lbl_DescuentoMinorista"
        Me.lbl_DescuentoMinorista.Size = New System.Drawing.Size(73, 16)
        Me.lbl_DescuentoMinorista.TabIndex = 19
        Me.lbl_DescuentoMinorista.Text = "$ 120.00.-"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(4, 30)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 15)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Descuento"
        '
        'lbl_SubtotalMinorista
        '
        Me.lbl_SubtotalMinorista.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl_SubtotalMinorista.AutoSize = True
        Me.lbl_SubtotalMinorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SubtotalMinorista.Location = New System.Drawing.Point(145, 4)
        Me.lbl_SubtotalMinorista.Name = "lbl_SubtotalMinorista"
        Me.lbl_SubtotalMinorista.Size = New System.Drawing.Size(73, 16)
        Me.lbl_SubtotalMinorista.TabIndex = 21
        Me.lbl_SubtotalMinorista.Text = "$ 120.00.-"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(4, 5)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 15)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Subtotal"
        '
        'lbl_Fecha
        '
        Me.lbl_Fecha.AutoSize = True
        Me.lbl_Fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Fecha.Location = New System.Drawing.Point(151, 22)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(69, 15)
        Me.lbl_Fecha.TabIndex = 15
        Me.lbl_Fecha.Text = "04/05/2012"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 22)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 15)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Fecha"
        '
        'btnFacturar
        '
        Me.btnFacturar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFacturar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFacturar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFacturar.Image = Global.SistemaCinderella.My.Resources.Recursos.Conectado_32
        Me.btnFacturar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFacturar.Location = New System.Drawing.Point(655, 446)
        Me.btnFacturar.Name = "btnFacturar"
        Me.btnFacturar.Size = New System.Drawing.Size(100, 40)
        Me.btnFacturar.TabIndex = 13
        Me.btnFacturar.Text = "Facturar"
        Me.btnFacturar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFacturar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblEstado)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(368, 70)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Controlador Fiscal"
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.Location = New System.Drawing.Point(69, 34)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(39, 15)
        Me.lblEstado.TabIndex = 1
        Me.lblEstado.Text = "- - - -"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Estado"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Cb_TipoFacturacion)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Location = New System.Drawing.Point(387, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(368, 70)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Factura"
        '
        'Cb_TipoFacturacion
        '
        Me.Cb_TipoFacturacion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cb_TipoFacturacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_TipoFacturacion.FormattingEnabled = True
        Me.Cb_TipoFacturacion.Location = New System.Drawing.Point(140, 31)
        Me.Cb_TipoFacturacion.Name = "Cb_TipoFacturacion"
        Me.Cb_TipoFacturacion.Size = New System.Drawing.Size(219, 23)
        Me.Cb_TipoFacturacion.TabIndex = 7
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(7, 34)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(31, 15)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Tipo"
        '
        'GB_FacturacionManual
        '
        Me.GB_FacturacionManual.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_FacturacionManual.Controls.Add(Me.Label14)
        Me.GB_FacturacionManual.Controls.Add(Me.QuitarNumeroFactura)
        Me.GB_FacturacionManual.Controls.Add(Me.AgregarNumeroFactura)
        Me.GB_FacturacionManual.Controls.Add(Me.FacturasList)
        Me.GB_FacturacionManual.Controls.Add(Me.txt_NumeroFacturaManual)
        Me.GB_FacturacionManual.Controls.Add(Me.Label8)
        Me.GB_FacturacionManual.Location = New System.Drawing.Point(388, 89)
        Me.GB_FacturacionManual.Name = "GB_FacturacionManual"
        Me.GB_FacturacionManual.Size = New System.Drawing.Size(367, 246)
        Me.GB_FacturacionManual.TabIndex = 3
        Me.GB_FacturacionManual.TabStop = False
        Me.GB_FacturacionManual.Text = "Información Facturación Manual"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 78)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(54, 15)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "Facturas"
        '
        'QuitarNumeroFactura
        '
        Me.QuitarNumeroFactura.Location = New System.Drawing.Point(283, 178)
        Me.QuitarNumeroFactura.Name = "QuitarNumeroFactura"
        Me.QuitarNumeroFactura.Size = New System.Drawing.Size(75, 23)
        Me.QuitarNumeroFactura.TabIndex = 11
        Me.QuitarNumeroFactura.Text = "Quitar"
        Me.QuitarNumeroFactura.UseVisualStyleBackColor = True
        '
        'AgregarNumeroFactura
        '
        Me.AgregarNumeroFactura.Location = New System.Drawing.Point(283, 49)
        Me.AgregarNumeroFactura.Name = "AgregarNumeroFactura"
        Me.AgregarNumeroFactura.Size = New System.Drawing.Size(75, 23)
        Me.AgregarNumeroFactura.TabIndex = 9
        Me.AgregarNumeroFactura.Text = "Agregar"
        Me.AgregarNumeroFactura.UseVisualStyleBackColor = True
        '
        'FacturasList
        '
        Me.FacturasList.FormattingEnabled = True
        Me.FacturasList.ItemHeight = 15
        Me.FacturasList.Location = New System.Drawing.Point(139, 78)
        Me.FacturasList.Name = "FacturasList"
        Me.FacturasList.Size = New System.Drawing.Size(219, 94)
        Me.FacturasList.TabIndex = 10
        '
        'txt_NumeroFacturaManual
        '
        Me.txt_NumeroFacturaManual.Location = New System.Drawing.Point(139, 22)
        Me.txt_NumeroFacturaManual.Name = "txt_NumeroFacturaManual"
        Me.txt_NumeroFacturaManual.Size = New System.Drawing.Size(219, 21)
        Me.txt_NumeroFacturaManual.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 15)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Numero Factura"
        '
        'btnNotaCredito
        '
        Me.btnNotaCredito.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNotaCredito.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNotaCredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotaCredito.Image = Global.SistemaCinderella.My.Resources.Recursos.nota_credito
        Me.btnNotaCredito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNotaCredito.Location = New System.Drawing.Point(549, 446)
        Me.btnNotaCredito.Name = "btnNotaCredito"
        Me.btnNotaCredito.Size = New System.Drawing.Size(100, 40)
        Me.btnNotaCredito.TabIndex = 12
        Me.btnNotaCredito.Text = "Nota Cred"
        Me.btnNotaCredito.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNotaCredito.UseVisualStyleBackColor = True
        '
        'lblError
        '
        Me.lblError.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(396, 344)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(350, 85)
        Me.lblError.TabIndex = 12
        Me.lblError.Text = "Se ha alcanzado el máximo permitido para realizar una factura con el tipo de fact" &
    "uración seleccionada. Por favor, seleccione otro tipo de facturación."
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = Global.SistemaCinderella.My.Resources.Recursos.desconectado_32
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(443, 446)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 40)
        Me.btnCancelar.TabIndex = 14
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'frmFacturar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(766, 497)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.btnNotaCredito)
        Me.Controls.Add(Me.GB_FacturacionManual)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnFacturar)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmFacturar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturación de Venta"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PanelTotalMayorista.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.PanelTotalMinorista.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GB_FacturacionManual.ResumeLayout(False)
        Me.GB_FacturacionManual.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_Fecha As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_Cuit As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnFacturar As System.Windows.Forms.Button
    Friend WithEvents txt_Localidad As System.Windows.Forms.TextBox
    Friend WithEvents txt_Direccion As System.Windows.Forms.TextBox
    Friend WithEvents txt_Nombre As System.Windows.Forms.TextBox
    Friend WithEvents Cb_IVA As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbl_TotalMinorista As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbl_TipoPago As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lbl_DescuentoMinorista As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lbl_SubtotalMinorista As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Cb_TipoFacturacion As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GB_FacturacionManual As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents QuitarNumeroFactura As System.Windows.Forms.Button
    Friend WithEvents AgregarNumeroFactura As System.Windows.Forms.Button
    Friend WithEvents FacturasList As System.Windows.Forms.ListBox
    Friend WithEvents txt_NumeroFacturaManual As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnNotaCredito As System.Windows.Forms.Button
    Friend WithEvents txt_Factura_Origen As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txt_Pago As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents PanelTotalMayorista As Panel
    Friend WithEvents Label23 As Label
    Friend WithEvents lbl_TotalMayorista As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents lbl_IvaMayorista As Label
    Friend WithEvents lbl_DescuentoMayorista As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents lbl_SubtotalMayorista As Label
    Friend WithEvents PanelTotalMinorista As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label20 As Label
    Friend WithEvents lbl_CostoFinancieroMayorista As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents lbl_CostoFinancieroMinorista As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents btnCancelar As Button
End Class
