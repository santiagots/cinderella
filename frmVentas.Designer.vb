﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVentas
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVentas))
        Me.DG_Productos = New System.Windows.Forms.DataGridView()
        Me.NUMERO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODIGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANTIDAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRECIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MONTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SUBTOTAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ELIMINAR = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Precio1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_CodigoBarra = New System.Windows.Forms.TextBox()
        Me.Btn_Finalizar = New System.Windows.Forms.Button()
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.Btn_Agregar = New System.Windows.Forms.Button()
        Me.lbl_CodigoBarra = New System.Windows.Forms.Label()
        Me.lbl_DescrTot = New System.Windows.Forms.Label()
        Me.Gb_Producto = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.Btn_Cambiar = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Gb_Cliente = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Btn_BuscarCliente = New System.Windows.Forms.Button()
        Me.txt_RazonSocial = New System.Windows.Forms.TextBox()
        Me.txt_id_Cliente = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_PorcentajeFacturacion = New System.Windows.Forms.NumericUpDown()
        Me.Gb_Vendedor = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Cb_Vendedores = New System.Windows.Forms.ComboBox()
        Me.Cb_Encargados = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cb_Tipo = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GB_Fecha = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_Hora = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_Sucursal = New System.Windows.Forms.Label()
        Me.lbl_Fecha = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Reloj = New System.Windows.Forms.Timer(Me.components)
        Me.GB_TipoPago = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.Cb_TipoPago = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ToolProd = New System.Windows.Forms.ToolTip(Me.components)
        Me.txt_DescuentoMinorista = New System.Windows.Forms.TextBox()
        Me.txt_DescuentoMayorista = New System.Windows.Forms.TextBox()
        Me.txt_Senia = New System.Windows.Forms.TextBox()
        Me.BtnSenia = New System.Windows.Forms.Button()
        Me.txt_SeniaMinorista = New System.Windows.Forms.TextBox()
        Me.txt_SeniaMayorista = New System.Windows.Forms.TextBox()
        Me.Btn_NotaPedido = New System.Windows.Forms.Button()
        Me.lbl_DesTot = New System.Windows.Forms.Label()
        Me.txt_TotalMinorista = New System.Windows.Forms.TextBox()
        Me.txt_SubtotalMinorista = New System.Windows.Forms.TextBox()
        Me.lbl_subTotal = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GB_ListaPrecio = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel9 = New System.Windows.Forms.TableLayoutPanel()
        Me.Cb_ListaPrecio = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_ivaTotalMayorista = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.PanelTotalMayorista = New System.Windows.Forms.Panel()
        Me.lblSeniaMayorista = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblSeniaMayoristaMoneda = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_SubtotalMayorista = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txt_TotalMayorista = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.PanelTotalMinorista = New System.Windows.Forms.Panel()
        Me.lblSeniaMinorista = New System.Windows.Forms.Label()
        Me.lblSeniaMinoristaMoneda = New System.Windows.Forms.Label()
        Me.GB_Reserva = New System.Windows.Forms.GroupBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.DG_Productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gb_Producto.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.Gb_Cliente.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.txt_PorcentajeFacturacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gb_Vendedor.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GB_Fecha.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GB_TipoPago.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.GB_ListaPrecio.SuspendLayout()
        Me.TableLayoutPanel9.SuspendLayout()
        Me.PanelTotalMayorista.SuspendLayout()
        Me.PanelTotalMinorista.SuspendLayout()
        Me.GB_Reserva.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'DG_Productos
        '
        Me.DG_Productos.AllowUserToAddRows = False
        Me.DG_Productos.AllowUserToDeleteRows = False
        Me.DG_Productos.AllowUserToResizeColumns = False
        Me.DG_Productos.AllowUserToResizeRows = False
        Me.DG_Productos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_Productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_Productos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DG_Productos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DG_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Productos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NUMERO, Me.ID, Me.CODIGO, Me.NOMBRE, Me.CANTIDAD, Me.PRECIO, Me.IVA, Me.MONTO, Me.SUBTOTAL, Me.ELIMINAR, Me.Precio1, Me.Precio2, Me.Precio3, Me.Precio4, Me.Precio5, Me.Precio6})
        Me.DG_Productos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DG_Productos.Location = New System.Drawing.Point(12, 345)
        Me.DG_Productos.Name = "DG_Productos"
        Me.DG_Productos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DG_Productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Productos.Size = New System.Drawing.Size(930, 205)
        Me.DG_Productos.TabIndex = 12
        '
        'NUMERO
        '
        Me.NUMERO.HeaderText = "NUMERO"
        Me.NUMERO.Name = "NUMERO"
        Me.NUMERO.ReadOnly = True
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        '
        'CODIGO
        '
        Me.CODIGO.HeaderText = "CODIGO"
        Me.CODIGO.Name = "CODIGO"
        Me.CODIGO.ReadOnly = True
        '
        'NOMBRE
        '
        Me.NOMBRE.HeaderText = "NOMBRE"
        Me.NOMBRE.Name = "NOMBRE"
        Me.NOMBRE.ReadOnly = True
        '
        'CANTIDAD
        '
        Me.CANTIDAD.HeaderText = "CANTIDAD"
        Me.CANTIDAD.Name = "CANTIDAD"
        '
        'PRECIO
        '
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = "0"
        Me.PRECIO.DefaultCellStyle = DataGridViewCellStyle1
        Me.PRECIO.HeaderText = "PRECIO"
        Me.PRECIO.Name = "PRECIO"
        Me.PRECIO.ReadOnly = True
        '
        'IVA
        '
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = "0"
        Me.IVA.DefaultCellStyle = DataGridViewCellStyle2
        Me.IVA.HeaderText = "IVA"
        Me.IVA.Name = "IVA"
        Me.IVA.ReadOnly = True
        '
        'MONTO
        '
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.MONTO.DefaultCellStyle = DataGridViewCellStyle3
        Me.MONTO.HeaderText = "MONTO"
        Me.MONTO.Name = "MONTO"
        Me.MONTO.ReadOnly = True
        '
        'SUBTOTAL
        '
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = "0"
        Me.SUBTOTAL.DefaultCellStyle = DataGridViewCellStyle4
        Me.SUBTOTAL.HeaderText = "SUBTOTAL"
        Me.SUBTOTAL.Name = "SUBTOTAL"
        Me.SUBTOTAL.ReadOnly = True
        '
        'ELIMINAR
        '
        Me.ELIMINAR.HeaderText = "ELIMINAR"
        Me.ELIMINAR.Name = "ELIMINAR"
        Me.ELIMINAR.ReadOnly = True
        '
        'Precio1
        '
        Me.Precio1.HeaderText = "Precio1"
        Me.Precio1.Name = "Precio1"
        Me.Precio1.Visible = False
        '
        'Precio2
        '
        Me.Precio2.HeaderText = "Precio2"
        Me.Precio2.Name = "Precio2"
        Me.Precio2.Visible = False
        '
        'Precio3
        '
        Me.Precio3.HeaderText = "Precio3"
        Me.Precio3.Name = "Precio3"
        Me.Precio3.Visible = False
        '
        'Precio4
        '
        Me.Precio4.HeaderText = "Precio4"
        Me.Precio4.Name = "Precio4"
        Me.Precio4.Visible = False
        '
        'Precio5
        '
        Me.Precio5.HeaderText = "Precio5"
        Me.Precio5.Name = "Precio5"
        Me.Precio5.Visible = False
        '
        'Precio6
        '
        Me.Precio6.HeaderText = "Precio6"
        Me.Precio6.Name = "Precio6"
        Me.Precio6.Visible = False
        '
        'txt_CodigoBarra
        '
        Me.txt_CodigoBarra.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_CodigoBarra.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_CodigoBarra.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_CodigoBarra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CodigoBarra.Location = New System.Drawing.Point(203, 34)
        Me.txt_CodigoBarra.Name = "txt_CodigoBarra"
        Me.txt_CodigoBarra.Size = New System.Drawing.Size(264, 21)
        Me.txt_CodigoBarra.TabIndex = 7
        '
        'Btn_Finalizar
        '
        Me.Btn_Finalizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Finalizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Finalizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Finalizar.Image = Global.SistemaCinderella.My.Resources.Recursos.Conectado_32
        Me.Btn_Finalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Finalizar.Location = New System.Drawing.Point(839, 770)
        Me.Btn_Finalizar.Name = "Btn_Finalizar"
        Me.Btn_Finalizar.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Finalizar.TabIndex = 17
        Me.Btn_Finalizar.Text = "Finalizar"
        Me.Btn_Finalizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolProd.SetToolTip(Me.Btn_Finalizar, "Finaliza la venta actual. ")
        Me.Btn_Finalizar.UseVisualStyleBackColor = True
        Me.Btn_Finalizar.Visible = False
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Cancelar.Image = Global.SistemaCinderella.My.Resources.Recursos.desconectado_32
        Me.Btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Cancelar.Location = New System.Drawing.Point(12, 770)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Cancelar.TabIndex = 16
        Me.Btn_Cancelar.Text = "Cancelar"
        Me.Btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolProd.SetToolTip(Me.Btn_Cancelar, "Cancela la venta actual.")
        Me.Btn_Cancelar.UseVisualStyleBackColor = True
        '
        'Btn_Agregar
        '
        Me.Btn_Agregar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Btn_Agregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Agregar.Image = Global.SistemaCinderella.My.Resources.Recursos.Productos_32
        Me.Btn_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Agregar.Location = New System.Drawing.Point(3, 3)
        Me.Btn_Agregar.Name = "Btn_Agregar"
        Me.Btn_Agregar.Size = New System.Drawing.Size(98, 36)
        Me.Btn_Agregar.TabIndex = 8
        Me.Btn_Agregar.Text = "Agregar"
        Me.Btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolProd.SetToolTip(Me.Btn_Agregar, "Permite buscar productos en el sistema por nombre / código.")
        Me.Btn_Agregar.UseVisualStyleBackColor = True
        '
        'lbl_CodigoBarra
        '
        Me.lbl_CodigoBarra.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_CodigoBarra.AutoSize = True
        Me.lbl_CodigoBarra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CodigoBarra.Location = New System.Drawing.Point(3, 37)
        Me.lbl_CodigoBarra.Name = "lbl_CodigoBarra"
        Me.lbl_CodigoBarra.Size = New System.Drawing.Size(194, 15)
        Me.lbl_CodigoBarra.TabIndex = 7
        Me.lbl_CodigoBarra.Text = "Nombre / Código de Producto"
        '
        'lbl_DescrTot
        '
        Me.lbl_DescrTot.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_DescrTot.AutoSize = True
        Me.lbl_DescrTot.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DescrTot.Location = New System.Drawing.Point(26, 164)
        Me.lbl_DescrTot.Name = "lbl_DescrTot"
        Me.lbl_DescrTot.Size = New System.Drawing.Size(261, 29)
        Me.lbl_DescrTot.TabIndex = 9
        Me.lbl_DescrTot.Text = "IMPORTE A ABONAR:"
        '
        'Gb_Producto
        '
        Me.Gb_Producto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gb_Producto.Controls.Add(Me.TableLayoutPanel4)
        Me.Gb_Producto.Controls.Add(Me.Label13)
        Me.Gb_Producto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gb_Producto.Location = New System.Drawing.Point(3, 3)
        Me.Gb_Producto.Name = "Gb_Producto"
        Me.Gb_Producto.Size = New System.Drawing.Size(599, 134)
        Me.Gb_Producto.TabIndex = 10
        Me.Gb_Producto.TabStop = False
        Me.Gb_Producto.Text = "PRODUCTO"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel4.ColumnCount = 3
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel5, 2, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.lbl_CodigoBarra, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.txt_CodigoBarra, 1, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(10, 33)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(580, 90)
        Me.TableLayoutPanel4.TabIndex = 30
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.Btn_Agregar, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.Btn_Cambiar, 0, 1)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(473, 3)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(104, 84)
        Me.TableLayoutPanel5.TabIndex = 31
        '
        'Btn_Cambiar
        '
        Me.Btn_Cambiar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Btn_Cambiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Cambiar.Image = Global.SistemaCinderella.My.Resources.Recursos.Cambios_32
        Me.Btn_Cambiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Cambiar.Location = New System.Drawing.Point(3, 45)
        Me.Btn_Cambiar.Name = "Btn_Cambiar"
        Me.Btn_Cambiar.Size = New System.Drawing.Size(98, 36)
        Me.Btn_Cambiar.TabIndex = 9
        Me.Btn_Cambiar.Text = "Cambiar"
        Me.Btn_Cambiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolProd.SetToolTip(Me.Btn_Cambiar, "Permite agregar productos que ingresan a la sucursal.")
        Me.Btn_Cambiar.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(7, 17)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(408, 15)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Ingrese el código de barra o el código de producto y luego presione enter."
        '
        'Gb_Cliente
        '
        Me.Gb_Cliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gb_Cliente.Controls.Add(Me.TableLayoutPanel3)
        Me.Gb_Cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gb_Cliente.Location = New System.Drawing.Point(11, 134)
        Me.Gb_Cliente.Name = "Gb_Cliente"
        Me.Gb_Cliente.Size = New System.Drawing.Size(930, 59)
        Me.Gb_Cliente.TabIndex = 11
        Me.Gb_Cliente.TabStop = False
        Me.Gb_Cliente.Text = "CLIENTE"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.ColumnCount = 7
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.71459!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.64413!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.64127!))
        Me.TableLayoutPanel3.Controls.Add(Me.Btn_BuscarCliente, 3, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.txt_RazonSocial, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.txt_id_Cliente, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label24, 5, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.txt_PorcentajeFacturacion, 6, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(6, 18)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(914, 35)
        Me.TableLayoutPanel3.TabIndex = 30
        '
        'Btn_BuscarCliente
        '
        Me.Btn_BuscarCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_BuscarCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_BuscarCliente.FlatAppearance.BorderSize = 0
        Me.Btn_BuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_BuscarCliente.Image = Global.SistemaCinderella.My.Resources.Recursos.Clientes_32
        Me.Btn_BuscarCliente.Location = New System.Drawing.Point(452, 3)
        Me.Btn_BuscarCliente.Name = "Btn_BuscarCliente"
        Me.Btn_BuscarCliente.Size = New System.Drawing.Size(34, 29)
        Me.Btn_BuscarCliente.TabIndex = 6
        Me.ToolProd.SetToolTip(Me.Btn_BuscarCliente, "Permite buscar clientes en el sistema por razon social.")
        Me.Btn_BuscarCliente.UseVisualStyleBackColor = True
        '
        'txt_RazonSocial
        '
        Me.txt_RazonSocial.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_RazonSocial.BackColor = System.Drawing.SystemColors.Window
        Me.txt_RazonSocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_RazonSocial.Location = New System.Drawing.Point(178, 7)
        Me.txt_RazonSocial.Name = "txt_RazonSocial"
        Me.txt_RazonSocial.ReadOnly = True
        Me.txt_RazonSocial.Size = New System.Drawing.Size(268, 21)
        Me.txt_RazonSocial.TabIndex = 5
        '
        'txt_id_Cliente
        '
        Me.txt_id_Cliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_id_Cliente.BackColor = System.Drawing.SystemColors.Window
        Me.txt_id_Cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id_Cliente.Location = New System.Drawing.Point(113, 7)
        Me.txt_id_Cliente.Name = "txt_id_Cliente"
        Me.txt_id_Cliente.ReadOnly = True
        Me.txt_id_Cliente.Size = New System.Drawing.Size(59, 21)
        Me.txt_id_Cliente.TabIndex = 4
        '
        'Label24
        '
        Me.Label24.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(532, 10)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(104, 15)
        Me.Label24.TabIndex = 7
        Me.Label24.Text = "Facturación %"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Cliente"
        '
        'txt_PorcentajeFacturacion
        '
        Me.txt_PorcentajeFacturacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_PorcentajeFacturacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PorcentajeFacturacion.Location = New System.Drawing.Point(642, 7)
        Me.txt_PorcentajeFacturacion.Name = "txt_PorcentajeFacturacion"
        Me.txt_PorcentajeFacturacion.Size = New System.Drawing.Size(269, 21)
        Me.txt_PorcentajeFacturacion.TabIndex = 8
        '
        'Gb_Vendedor
        '
        Me.Gb_Vendedor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gb_Vendedor.Controls.Add(Me.TableLayoutPanel2)
        Me.Gb_Vendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gb_Vendedor.Location = New System.Drawing.Point(12, 69)
        Me.Gb_Vendedor.Name = "Gb_Vendedor"
        Me.Gb_Vendedor.Size = New System.Drawing.Size(930, 59)
        Me.Gb_Vendedor.TabIndex = 12
        Me.Gb_Vendedor.TabStop = False
        Me.Gb_Vendedor.Text = "TIPO, ENCARGADO Y VENDEDOR DE LA VENTA"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 8
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.Controls.Add(Me.Cb_Vendedores, 7, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Cb_Encargados, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 6, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label12, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.cb_Tipo, 1, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(7, 20)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(917, 30)
        Me.TableLayoutPanel2.TabIndex = 30
        '
        'Cb_Vendedores
        '
        Me.Cb_Vendedores.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cb_Vendedores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cb_Vendedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Vendedores.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Cb_Vendedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_Vendedores.FormattingEnabled = True
        Me.Cb_Vendedores.Location = New System.Drawing.Point(751, 3)
        Me.Cb_Vendedores.Name = "Cb_Vendedores"
        Me.Cb_Vendedores.Size = New System.Drawing.Size(163, 23)
        Me.Cb_Vendedores.TabIndex = 3
        '
        'Cb_Encargados
        '
        Me.Cb_Encargados.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cb_Encargados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cb_Encargados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Encargados.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Cb_Encargados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_Encargados.FormattingEnabled = True
        Me.Cb_Encargados.Location = New System.Drawing.Point(422, 3)
        Me.Cb_Encargados.Name = "Cb_Encargados"
        Me.Cb_Encargados.Size = New System.Drawing.Size(163, 23)
        Me.Cb_Encargados.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(661, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Vendedor"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tipo de Venta"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(332, 7)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(84, 15)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Encargado"
        '
        'cb_Tipo
        '
        Me.cb_Tipo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_Tipo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_Tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Tipo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cb_Tipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_Tipo.FormattingEnabled = True
        Me.cb_Tipo.Items.AddRange(New Object() {"Minorista", "Mayorista"})
        Me.cb_Tipo.Location = New System.Drawing.Point(93, 3)
        Me.cb_Tipo.Name = "cb_Tipo"
        Me.cb_Tipo.Size = New System.Drawing.Size(163, 23)
        Me.cb_Tipo.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(349, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 15)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "FECHA:"
        '
        'GB_Fecha
        '
        Me.GB_Fecha.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_Fecha.Controls.Add(Me.TableLayoutPanel1)
        Me.GB_Fecha.Location = New System.Drawing.Point(12, 12)
        Me.GB_Fecha.Name = "GB_Fecha"
        Me.GB_Fecha.Size = New System.Drawing.Size(930, 51)
        Me.GB_Fecha.TabIndex = 14
        Me.GB_Fecha.TabStop = False
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
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_Hora, 7, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 6, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_Sucursal, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_Fecha, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 3, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(6, 15)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(913, 30)
        Me.TableLayoutPanel1.TabIndex = 30
        '
        'lbl_Hora
        '
        Me.lbl_Hora.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Hora.AutoSize = True
        Me.lbl_Hora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Hora.Location = New System.Drawing.Point(805, 7)
        Me.lbl_Hora.Name = "lbl_Hora"
        Me.lbl_Hora.Size = New System.Drawing.Size(105, 15)
        Me.lbl_Hora.TabIndex = 14
        Me.lbl_Hora.Text = "Label5"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(695, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 15)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "HORA:"
        '
        'lbl_Sucursal
        '
        Me.lbl_Sucursal.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl_Sucursal.AutoSize = True
        Me.lbl_Sucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Sucursal.Location = New System.Drawing.Point(113, 7)
        Me.lbl_Sucursal.Name = "lbl_Sucursal"
        Me.lbl_Sucursal.Size = New System.Drawing.Size(45, 15)
        Me.lbl_Sucursal.TabIndex = 18
        Me.lbl_Sucursal.Text = "Label5"
        '
        'lbl_Fecha
        '
        Me.lbl_Fecha.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl_Fecha.AutoSize = True
        Me.lbl_Fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Fecha.Location = New System.Drawing.Point(459, 7)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(45, 15)
        Me.lbl_Fecha.TabIndex = 15
        Me.lbl_Fecha.Text = "Label6"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 15)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "SUCURSAL:"
        '
        'Reloj
        '
        Me.Reloj.Enabled = True
        '
        'GB_TipoPago
        '
        Me.GB_TipoPago.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_TipoPago.Controls.Add(Me.TableLayoutPanel7)
        Me.GB_TipoPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_TipoPago.Location = New System.Drawing.Point(3, 4)
        Me.GB_TipoPago.Name = "GB_TipoPago"
        Me.GB_TipoPago.Size = New System.Drawing.Size(314, 59)
        Me.GB_TipoPago.TabIndex = 12
        Me.GB_TipoPago.TabStop = False
        Me.GB_TipoPago.Text = "TIPO DE PAGO"
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel7.ColumnCount = 2
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.Cb_TipoPago, 1, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(6, 20)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(302, 30)
        Me.TableLayoutPanel7.TabIndex = 31
        '
        'Cb_TipoPago
        '
        Me.Cb_TipoPago.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cb_TipoPago.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cb_TipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_TipoPago.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Cb_TipoPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_TipoPago.FormattingEnabled = True
        Me.Cb_TipoPago.Location = New System.Drawing.Point(113, 3)
        Me.Cb_TipoPago.Name = "Cb_TipoPago"
        Me.Cb_TipoPago.Size = New System.Drawing.Size(186, 23)
        Me.Cb_TipoPago.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 15)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Tipo de Pago"
        '
        'ToolProd
        '
        Me.ToolProd.IsBalloon = True
        Me.ToolProd.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolProd.ToolTipTitle = "Ayuda"
        '
        'txt_DescuentoMinorista
        '
        Me.txt_DescuentoMinorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_DescuentoMinorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_DescuentoMinorista.Location = New System.Drawing.Point(321, 44)
        Me.txt_DescuentoMinorista.Name = "txt_DescuentoMinorista"
        Me.txt_DescuentoMinorista.Size = New System.Drawing.Size(139, 35)
        Me.txt_DescuentoMinorista.TabIndex = 13
        Me.txt_DescuentoMinorista.Text = "0,00"
        Me.txt_DescuentoMinorista.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolProd.SetToolTip(Me.txt_DescuentoMinorista, "Si desea agregar un descuento al pedido, sólo debe ingresar el monto en éste camp" &
        "o.")
        '
        'txt_DescuentoMayorista
        '
        Me.txt_DescuentoMayorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_DescuentoMayorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_DescuentoMayorista.Location = New System.Drawing.Point(320, 4)
        Me.txt_DescuentoMayorista.Name = "txt_DescuentoMayorista"
        Me.txt_DescuentoMayorista.Size = New System.Drawing.Size(139, 35)
        Me.txt_DescuentoMayorista.TabIndex = 27
        Me.txt_DescuentoMayorista.Text = "0,00"
        Me.txt_DescuentoMayorista.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolProd.SetToolTip(Me.txt_DescuentoMayorista, "Si desea agregar un descuento al pedido, sólo debe ingresar el monto en éste camp" &
        "o.")
        '
        'txt_Senia
        '
        Me.txt_Senia.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Senia.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Senia.Location = New System.Drawing.Point(271, 25)
        Me.txt_Senia.Name = "txt_Senia"
        Me.txt_Senia.Size = New System.Drawing.Size(139, 35)
        Me.txt_Senia.TabIndex = 20
        Me.txt_Senia.Text = "0,00"
        Me.txt_Senia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolProd.SetToolTip(Me.txt_Senia, "Ingrese un monto en case de querer realizar una seña.")
        '
        'BtnSenia
        '
        Me.BtnSenia.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSenia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSenia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSenia.Image = Global.SistemaCinderella.My.Resources.Recursos.Agregar_24
        Me.BtnSenia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSenia.Location = New System.Drawing.Point(310, 79)
        Me.BtnSenia.Name = "BtnSenia"
        Me.BtnSenia.Size = New System.Drawing.Size(100, 40)
        Me.BtnSenia.TabIndex = 23
        Me.BtnSenia.Text = "Señar"
        Me.BtnSenia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolProd.SetToolTip(Me.BtnSenia, "Señar la venta actual. ")
        Me.BtnSenia.UseVisualStyleBackColor = True
        '
        'txt_SeniaMinorista
        '
        Me.txt_SeniaMinorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_SeniaMinorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SeniaMinorista.Location = New System.Drawing.Point(321, 85)
        Me.txt_SeniaMinorista.Name = "txt_SeniaMinorista"
        Me.txt_SeniaMinorista.ReadOnly = True
        Me.txt_SeniaMinorista.Size = New System.Drawing.Size(139, 35)
        Me.txt_SeniaMinorista.TabIndex = 23
        Me.txt_SeniaMinorista.Text = "0,00"
        Me.txt_SeniaMinorista.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolProd.SetToolTip(Me.txt_SeniaMinorista, "Ingrese un monto en case de querer realizar una seña.")
        Me.txt_SeniaMinorista.Visible = False
        '
        'txt_SeniaMayorista
        '
        Me.txt_SeniaMayorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_SeniaMayorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SeniaMayorista.Location = New System.Drawing.Point(318, 127)
        Me.txt_SeniaMayorista.Name = "txt_SeniaMayorista"
        Me.txt_SeniaMayorista.ReadOnly = True
        Me.txt_SeniaMayorista.Size = New System.Drawing.Size(139, 35)
        Me.txt_SeniaMayorista.TabIndex = 35
        Me.txt_SeniaMayorista.Text = "0,00"
        Me.txt_SeniaMayorista.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolProd.SetToolTip(Me.txt_SeniaMayorista, "Ingrese un monto en case de querer realizar una seña.")
        Me.txt_SeniaMayorista.Visible = False
        '
        'Btn_NotaPedido
        '
        Me.Btn_NotaPedido.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_NotaPedido.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_NotaPedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_NotaPedido.Image = Global.SistemaCinderella.My.Resources.Recursos.Agregar_24
        Me.Btn_NotaPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_NotaPedido.Location = New System.Drawing.Point(711, 770)
        Me.Btn_NotaPedido.Name = "Btn_NotaPedido"
        Me.Btn_NotaPedido.Size = New System.Drawing.Size(122, 40)
        Me.Btn_NotaPedido.TabIndex = 29
        Me.Btn_NotaPedido.Text = "Nota Pedido"
        Me.Btn_NotaPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolProd.SetToolTip(Me.Btn_NotaPedido, "Crear nota de pedido. ")
        Me.Btn_NotaPedido.UseVisualStyleBackColor = True
        Me.Btn_NotaPedido.Visible = False
        '
        'lbl_DesTot
        '
        Me.lbl_DesTot.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_DesTot.AutoSize = True
        Me.lbl_DesTot.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DesTot.Location = New System.Drawing.Point(26, 47)
        Me.lbl_DesTot.Name = "lbl_DesTot"
        Me.lbl_DesTot.Size = New System.Drawing.Size(169, 29)
        Me.lbl_DesTot.TabIndex = 16
        Me.lbl_DesTot.Text = "DESCUENTO:"
        '
        'txt_TotalMinorista
        '
        Me.txt_TotalMinorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_TotalMinorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TotalMinorista.Location = New System.Drawing.Point(321, 158)
        Me.txt_TotalMinorista.Name = "txt_TotalMinorista"
        Me.txt_TotalMinorista.ReadOnly = True
        Me.txt_TotalMinorista.Size = New System.Drawing.Size(139, 35)
        Me.txt_TotalMinorista.TabIndex = 15
        Me.txt_TotalMinorista.Text = "0,00"
        Me.txt_TotalMinorista.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_SubtotalMinorista
        '
        Me.txt_SubtotalMinorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_SubtotalMinorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SubtotalMinorista.Location = New System.Drawing.Point(321, 3)
        Me.txt_SubtotalMinorista.Name = "txt_SubtotalMinorista"
        Me.txt_SubtotalMinorista.ReadOnly = True
        Me.txt_SubtotalMinorista.Size = New System.Drawing.Size(139, 35)
        Me.txt_SubtotalMinorista.TabIndex = 14
        Me.txt_SubtotalMinorista.Text = "0,00"
        Me.txt_SubtotalMinorista.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_subTotal
        '
        Me.lbl_subTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_subTotal.AutoSize = True
        Me.lbl_subTotal.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_subTotal.Location = New System.Drawing.Point(26, 6)
        Me.lbl_subTotal.Name = "lbl_subTotal"
        Me.lbl_subTotal.Size = New System.Drawing.Size(148, 29)
        Me.lbl_subTotal.TabIndex = 17
        Me.lbl_subTotal.Text = "SUBTOTAL:"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(285, 47)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(26, 29)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "$"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(285, 7)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(26, 29)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "$"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(285, 164)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(26, 29)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "$"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GB_ListaPrecio
        '
        Me.GB_ListaPrecio.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_ListaPrecio.Controls.Add(Me.TableLayoutPanel9)
        Me.GB_ListaPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_ListaPrecio.Location = New System.Drawing.Point(3, 71)
        Me.GB_ListaPrecio.Name = "GB_ListaPrecio"
        Me.GB_ListaPrecio.Size = New System.Drawing.Size(314, 59)
        Me.GB_ListaPrecio.TabIndex = 22
        Me.GB_ListaPrecio.TabStop = False
        Me.GB_ListaPrecio.Text = "LISTA PRECIOS"
        '
        'TableLayoutPanel9
        '
        Me.TableLayoutPanel9.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel9.ColumnCount = 2
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel9.Controls.Add(Me.Cb_ListaPrecio, 1, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.Label14, 0, 0)
        Me.TableLayoutPanel9.Location = New System.Drawing.Point(6, 20)
        Me.TableLayoutPanel9.Name = "TableLayoutPanel9"
        Me.TableLayoutPanel9.RowCount = 1
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel9.Size = New System.Drawing.Size(299, 30)
        Me.TableLayoutPanel9.TabIndex = 31
        '
        'Cb_ListaPrecio
        '
        Me.Cb_ListaPrecio.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cb_ListaPrecio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cb_ListaPrecio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_ListaPrecio.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Cb_ListaPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_ListaPrecio.FormattingEnabled = True
        Me.Cb_ListaPrecio.Location = New System.Drawing.Point(113, 3)
        Me.Cb_ListaPrecio.Name = "Cb_ListaPrecio"
        Me.Cb_ListaPrecio.Size = New System.Drawing.Size(183, 23)
        Me.Cb_ListaPrecio.TabIndex = 11
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(3, 7)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(104, 15)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Lista de Precios"
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(283, 90)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(26, 29)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "$"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_ivaTotalMayorista
        '
        Me.txt_ivaTotalMayorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_ivaTotalMayorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ivaTotalMayorista.Location = New System.Drawing.Point(319, 86)
        Me.txt_ivaTotalMayorista.Name = "txt_ivaTotalMayorista"
        Me.txt_ivaTotalMayorista.ReadOnly = True
        Me.txt_ivaTotalMayorista.Size = New System.Drawing.Size(139, 35)
        Me.txt_ivaTotalMayorista.TabIndex = 23
        Me.txt_ivaTotalMayorista.Text = "0,00"
        Me.txt_ivaTotalMayorista.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(29, 89)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(108, 29)
        Me.Label16.TabIndex = 24
        Me.Label16.Text = "IVA 21%:"
        '
        'PanelTotalMayorista
        '
        Me.PanelTotalMayorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelTotalMayorista.Controls.Add(Me.lblSeniaMayorista)
        Me.PanelTotalMayorista.Controls.Add(Me.Label8)
        Me.PanelTotalMayorista.Controls.Add(Me.Label17)
        Me.PanelTotalMayorista.Controls.Add(Me.txt_SeniaMayorista)
        Me.PanelTotalMayorista.Controls.Add(Me.lblSeniaMayoristaMoneda)
        Me.PanelTotalMayorista.Controls.Add(Me.Label18)
        Me.PanelTotalMayorista.Controls.Add(Me.txt_SubtotalMayorista)
        Me.PanelTotalMayorista.Controls.Add(Me.Label19)
        Me.PanelTotalMayorista.Controls.Add(Me.txt_TotalMayorista)
        Me.PanelTotalMayorista.Controls.Add(Me.txt_DescuentoMayorista)
        Me.PanelTotalMayorista.Controls.Add(Me.Label20)
        Me.PanelTotalMayorista.Controls.Add(Me.Label21)
        Me.PanelTotalMayorista.Controls.Add(Me.txt_ivaTotalMayorista)
        Me.PanelTotalMayorista.Controls.Add(Me.Label15)
        Me.PanelTotalMayorista.Controls.Add(Me.Label16)
        Me.PanelTotalMayorista.Location = New System.Drawing.Point(474, 335)
        Me.PanelTotalMayorista.Name = "PanelTotalMayorista"
        Me.PanelTotalMayorista.Size = New System.Drawing.Size(462, 215)
        Me.PanelTotalMayorista.TabIndex = 26
        '
        'lblSeniaMayorista
        '
        Me.lblSeniaMayorista.AutoSize = True
        Me.lblSeniaMayorista.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeniaMayorista.Location = New System.Drawing.Point(27, 130)
        Me.lblSeniaMayorista.Name = "lblSeniaMayorista"
        Me.lblSeniaMayorista.Size = New System.Drawing.Size(86, 29)
        Me.lblSeniaMayorista.TabIndex = 36
        Me.lblSeniaMayorista.Text = "SEÑA:"
        Me.lblSeniaMayorista.Visible = False
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(284, 174)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 29)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "$"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(283, 48)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(26, 29)
        Me.Label17.TabIndex = 33
        Me.Label17.Text = "$"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSeniaMayoristaMoneda
        '
        Me.lblSeniaMayoristaMoneda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSeniaMayoristaMoneda.AutoSize = True
        Me.lblSeniaMayoristaMoneda.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeniaMayoristaMoneda.Location = New System.Drawing.Point(281, 130)
        Me.lblSeniaMayoristaMoneda.Name = "lblSeniaMayoristaMoneda"
        Me.lblSeniaMayoristaMoneda.Size = New System.Drawing.Size(26, 29)
        Me.lblSeniaMayoristaMoneda.TabIndex = 37
        Me.lblSeniaMayoristaMoneda.Text = "$"
        Me.lblSeniaMayoristaMoneda.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblSeniaMayoristaMoneda.Visible = False
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(284, 7)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(26, 29)
        Me.Label18.TabIndex = 32
        Me.Label18.Text = "$"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_SubtotalMayorista
        '
        Me.txt_SubtotalMayorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_SubtotalMayorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SubtotalMayorista.Location = New System.Drawing.Point(320, 45)
        Me.txt_SubtotalMayorista.Name = "txt_SubtotalMayorista"
        Me.txt_SubtotalMayorista.ReadOnly = True
        Me.txt_SubtotalMayorista.Size = New System.Drawing.Size(139, 35)
        Me.txt_SubtotalMayorista.TabIndex = 28
        Me.txt_SubtotalMayorista.Text = "0,00"
        Me.txt_SubtotalMayorista.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(26, 48)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(148, 29)
        Me.Label19.TabIndex = 31
        Me.Label19.Text = "SUBTOTAL:"
        '
        'txt_TotalMayorista
        '
        Me.txt_TotalMayorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_TotalMayorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TotalMayorista.Location = New System.Drawing.Point(320, 168)
        Me.txt_TotalMayorista.Name = "txt_TotalMayorista"
        Me.txt_TotalMayorista.ReadOnly = True
        Me.txt_TotalMayorista.Size = New System.Drawing.Size(139, 35)
        Me.txt_TotalMayorista.TabIndex = 29
        Me.txt_TotalMayorista.Text = "0,00"
        Me.txt_TotalMayorista.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(29, 7)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(169, 29)
        Me.Label20.TabIndex = 30
        Me.Label20.Text = "DESCUENTO:"
        '
        'Label21
        '
        Me.Label21.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(26, 174)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(261, 29)
        Me.Label21.TabIndex = 26
        Me.Label21.Text = "IMPORTE A ABONAR:"
        '
        'PanelTotalMinorista
        '
        Me.PanelTotalMinorista.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelTotalMinorista.Controls.Add(Me.lblSeniaMinorista)
        Me.PanelTotalMinorista.Controls.Add(Me.txt_SeniaMinorista)
        Me.PanelTotalMinorista.Controls.Add(Me.lblSeniaMinoristaMoneda)
        Me.PanelTotalMinorista.Controls.Add(Me.lbl_DesTot)
        Me.PanelTotalMinorista.Controls.Add(Me.lbl_DescrTot)
        Me.PanelTotalMinorista.Controls.Add(Me.Label11)
        Me.PanelTotalMinorista.Controls.Add(Me.txt_DescuentoMinorista)
        Me.PanelTotalMinorista.Controls.Add(Me.Label10)
        Me.PanelTotalMinorista.Controls.Add(Me.txt_TotalMinorista)
        Me.PanelTotalMinorista.Controls.Add(Me.Label9)
        Me.PanelTotalMinorista.Controls.Add(Me.lbl_subTotal)
        Me.PanelTotalMinorista.Controls.Add(Me.txt_SubtotalMinorista)
        Me.PanelTotalMinorista.Location = New System.Drawing.Point(476, 553)
        Me.PanelTotalMinorista.Name = "PanelTotalMinorista"
        Me.PanelTotalMinorista.Size = New System.Drawing.Size(463, 198)
        Me.PanelTotalMinorista.TabIndex = 27
        '
        'lblSeniaMinorista
        '
        Me.lblSeniaMinorista.AutoSize = True
        Me.lblSeniaMinorista.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeniaMinorista.Location = New System.Drawing.Point(26, 88)
        Me.lblSeniaMinorista.Name = "lblSeniaMinorista"
        Me.lblSeniaMinorista.Size = New System.Drawing.Size(86, 29)
        Me.lblSeniaMinorista.TabIndex = 24
        Me.lblSeniaMinorista.Text = "SEÑA:"
        Me.lblSeniaMinorista.Visible = False
        '
        'lblSeniaMinoristaMoneda
        '
        Me.lblSeniaMinoristaMoneda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSeniaMinoristaMoneda.AutoSize = True
        Me.lblSeniaMinoristaMoneda.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeniaMinoristaMoneda.Location = New System.Drawing.Point(285, 88)
        Me.lblSeniaMinoristaMoneda.Name = "lblSeniaMinoristaMoneda"
        Me.lblSeniaMinoristaMoneda.Size = New System.Drawing.Size(26, 29)
        Me.lblSeniaMinoristaMoneda.TabIndex = 25
        Me.lblSeniaMinoristaMoneda.Text = "$"
        Me.lblSeniaMinoristaMoneda.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblSeniaMinoristaMoneda.Visible = False
        '
        'GB_Reserva
        '
        Me.GB_Reserva.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GB_Reserva.Controls.Add(Me.BtnSenia)
        Me.GB_Reserva.Controls.Add(Me.Label22)
        Me.GB_Reserva.Controls.Add(Me.txt_Senia)
        Me.GB_Reserva.Controls.Add(Me.Label23)
        Me.GB_Reserva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Reserva.Location = New System.Drawing.Point(11, 556)
        Me.GB_Reserva.Name = "GB_Reserva"
        Me.GB_Reserva.Size = New System.Drawing.Size(416, 125)
        Me.GB_Reserva.TabIndex = 28
        Me.GB_Reserva.TabStop = False
        Me.GB_Reserva.Text = "RECERVA VENTA"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(17, 28)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(86, 29)
        Me.Label22.TabIndex = 21
        Me.Label22.Text = "SEÑA:"
        '
        'Label23
        '
        Me.Label23.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(235, 28)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(26, 29)
        Me.Label23.TabIndex = 22
        Me.Label23.Text = "$"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel6.ColumnCount = 2
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.TableLayoutPanel8, 1, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.Gb_Producto, 0, 0)
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(12, 199)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(931, 140)
        Me.TableLayoutPanel6.TabIndex = 30
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.ColumnCount = 1
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.GB_TipoPago, 0, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.GB_ListaPrecio, 0, 1)
        Me.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(608, 3)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 2
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(320, 134)
        Me.TableLayoutPanel8.TabIndex = 31
        '
        'frmVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(954, 812)
        Me.Controls.Add(Me.TableLayoutPanel6)
        Me.Controls.Add(Me.Btn_NotaPedido)
        Me.Controls.Add(Me.GB_Reserva)
        Me.Controls.Add(Me.PanelTotalMayorista)
        Me.Controls.Add(Me.GB_Fecha)
        Me.Controls.Add(Me.Gb_Vendedor)
        Me.Controls.Add(Me.Gb_Cliente)
        Me.Controls.Add(Me.Btn_Cancelar)
        Me.Controls.Add(Me.Btn_Finalizar)
        Me.Controls.Add(Me.DG_Productos)
        Me.Controls.Add(Me.PanelTotalMinorista)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Ventas"
        CType(Me.DG_Productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gb_Producto.ResumeLayout(False)
        Me.Gb_Producto.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.Gb_Cliente.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.txt_PorcentajeFacturacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gb_Vendedor.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.GB_Fecha.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.GB_TipoPago.ResumeLayout(False)
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel7.PerformLayout()
        Me.GB_ListaPrecio.ResumeLayout(False)
        Me.TableLayoutPanel9.ResumeLayout(False)
        Me.TableLayoutPanel9.PerformLayout()
        Me.PanelTotalMayorista.ResumeLayout(False)
        Me.PanelTotalMayorista.PerformLayout()
        Me.PanelTotalMinorista.ResumeLayout(False)
        Me.PanelTotalMinorista.PerformLayout()
        Me.GB_Reserva.ResumeLayout(False)
        Me.GB_Reserva.PerformLayout()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DG_Productos As System.Windows.Forms.DataGridView
    Friend WithEvents txt_CodigoBarra As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Finalizar As System.Windows.Forms.Button
    Friend WithEvents Btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents Btn_Agregar As System.Windows.Forms.Button
    Friend WithEvents lbl_CodigoBarra As System.Windows.Forms.Label
    Friend WithEvents lbl_DescrTot As System.Windows.Forms.Label
    Friend WithEvents Gb_Producto As System.Windows.Forms.GroupBox
    Friend WithEvents Gb_Cliente As System.Windows.Forms.GroupBox
    Friend WithEvents Gb_Vendedor As System.Windows.Forms.GroupBox
    Friend WithEvents Cb_Vendedores As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Btn_BuscarCliente As System.Windows.Forms.Button
    Friend WithEvents txt_RazonSocial As System.Windows.Forms.TextBox
    Friend WithEvents txt_id_Cliente As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cb_Tipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GB_Fecha As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbl_Fecha As System.Windows.Forms.Label
    Friend WithEvents lbl_Hora As System.Windows.Forms.Label
    Friend WithEvents Reloj As System.Windows.Forms.Timer
    Friend WithEvents lbl_Sucursal As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GB_TipoPago As System.Windows.Forms.GroupBox
    Friend WithEvents Cb_TipoPago As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ToolProd As System.Windows.Forms.ToolTip
    Friend WithEvents lbl_DesTot As System.Windows.Forms.Label
    Friend WithEvents txt_DescuentoMinorista As System.Windows.Forms.TextBox
    Friend WithEvents txt_TotalMinorista As System.Windows.Forms.TextBox
    Friend WithEvents txt_SubtotalMinorista As System.Windows.Forms.TextBox
    Friend WithEvents lbl_subTotal As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Btn_Cambiar As System.Windows.Forms.Button
    Friend WithEvents Cb_Encargados As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GB_ListaPrecio As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Cb_ListaPrecio As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txt_ivaTotalMayorista As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents PanelTotalMayorista As Panel
    Friend WithEvents NUMERO As DataGridViewTextBoxColumn
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents CODIGO As DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE As DataGridViewTextBoxColumn
    Friend WithEvents CANTIDAD As DataGridViewTextBoxColumn
    Friend WithEvents PRECIO As DataGridViewTextBoxColumn
    Friend WithEvents IVA As DataGridViewTextBoxColumn
    Friend WithEvents MONTO As DataGridViewTextBoxColumn
    Friend WithEvents SUBTOTAL As DataGridViewTextBoxColumn
    Friend WithEvents ELIMINAR As DataGridViewImageColumn
    Friend WithEvents Precio1 As DataGridViewTextBoxColumn
    Friend WithEvents Precio2 As DataGridViewTextBoxColumn
    Friend WithEvents Precio3 As DataGridViewTextBoxColumn
    Friend WithEvents Precio4 As DataGridViewTextBoxColumn
    Friend WithEvents Precio5 As DataGridViewTextBoxColumn
    Friend WithEvents Precio6 As DataGridViewTextBoxColumn
    Friend WithEvents Label8 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txt_SubtotalMayorista As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txt_TotalMayorista As TextBox
    Friend WithEvents txt_DescuentoMayorista As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents PanelTotalMinorista As Panel
    Friend WithEvents GB_Reserva As GroupBox
    Friend WithEvents BtnSenia As Button
    Friend WithEvents Label22 As Label
    Friend WithEvents txt_Senia As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents lblSeniaMayorista As Label
    Friend WithEvents txt_SeniaMayorista As TextBox
    Friend WithEvents lblSeniaMayoristaMoneda As Label
    Friend WithEvents lblSeniaMinorista As Label
    Friend WithEvents txt_SeniaMinorista As TextBox
    Friend WithEvents lblSeniaMinoristaMoneda As Label
    Friend WithEvents Btn_NotaPedido As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents Label24 As Label
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents txt_PorcentajeFacturacion As NumericUpDown
End Class
