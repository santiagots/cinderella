<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDevoluciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDevoluciones))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolCamb = New System.Windows.Forms.ToolTip(Me.components)
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.Btn_Finalizar = New System.Windows.Forms.Button()
        Me.Btn_Buscar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GB_Fecha = New System.Windows.Forms.GroupBox()
        Me.lbl_Sucursal = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_Fecha = New System.Windows.Forms.Label()
        Me.lbl_Hora = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_Cantidad = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_Total = New System.Windows.Forms.TextBox()
        Me.lbl_DescrTot = New System.Windows.Forms.Label()
        Me.DG_Productos = New System.Windows.Forms.DataGridView()
        Me.NUMERO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODIGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESCRIPCION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRECIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ELIMINAR = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Gb_Producto = New System.Windows.Forms.GroupBox()
        Me.txt_CodigoBarra = New System.Windows.Forms.TextBox()
        Me.lbl_CodigoBarra = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GB_Fecha.SuspendLayout()
        CType(Me.DG_Productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gb_Producto.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'ToolCamb
        '
        Me.ToolCamb.IsBalloon = True
        Me.ToolCamb.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolCamb.ToolTipTitle = "Ayuda"
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Cancelar.Image = Global.SistemaCinderella.My.Resources.Recursos.desconectado_32
        Me.Btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Cancelar.Location = New System.Drawing.Point(7, 502)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Cancelar.TabIndex = 7
        Me.Btn_Cancelar.Text = "Cancelar"
        Me.Btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolCamb.SetToolTip(Me.Btn_Cancelar, "Cancela la devolucion de los articulos. Se borrarán los productos cargados en la " & _
                "grilla.")
        Me.Btn_Cancelar.UseVisualStyleBackColor = True
        '
        'Btn_Finalizar
        '
        Me.Btn_Finalizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Finalizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Finalizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Finalizar.Image = Global.SistemaCinderella.My.Resources.Recursos.Conectado_32
        Me.Btn_Finalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Finalizar.Location = New System.Drawing.Point(566, 502)
        Me.Btn_Finalizar.Name = "Btn_Finalizar"
        Me.Btn_Finalizar.Size = New System.Drawing.Size(100, 40)
        Me.Btn_Finalizar.TabIndex = 8
        Me.Btn_Finalizar.Text = "Finalizar"
        Me.Btn_Finalizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolCamb.SetToolTip(Me.Btn_Finalizar, "Finaliza la devolucion de los articulos.")
        Me.Btn_Finalizar.UseVisualStyleBackColor = True
        '
        'Btn_Buscar
        '
        Me.Btn_Buscar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Btn_Buscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Buscar.Image = Global.SistemaCinderella.My.Resources.Recursos.IconoBuscar32
        Me.Btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Buscar.Location = New System.Drawing.Point(494, 26)
        Me.Btn_Buscar.Name = "Btn_Buscar"
        Me.Btn_Buscar.Size = New System.Drawing.Size(160, 44)
        Me.Btn_Buscar.TabIndex = 3
        Me.Btn_Buscar.Text = "Buscar Producto"
        Me.Btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolCamb.SetToolTip(Me.Btn_Buscar, "Permite buscar productos en el sistema por nombre / código.")
        Me.Btn_Buscar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.GB_Fecha)
        Me.GroupBox2.Controls.Add(Me.txt_Cantidad)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txt_Total)
        Me.GroupBox2.Controls.Add(Me.lbl_DescrTot)
        Me.GroupBox2.Controls.Add(Me.Btn_Cancelar)
        Me.GroupBox2.Controls.Add(Me.Btn_Finalizar)
        Me.GroupBox2.Controls.Add(Me.DG_Productos)
        Me.GroupBox2.Controls.Add(Me.Gb_Producto)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(10, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(672, 548)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Devoluciones de Productos"
        '
        'GB_Fecha
        '
        Me.GB_Fecha.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_Fecha.Controls.Add(Me.lbl_Sucursal)
        Me.GB_Fecha.Controls.Add(Me.Label5)
        Me.GB_Fecha.Controls.Add(Me.Label7)
        Me.GB_Fecha.Controls.Add(Me.lbl_Fecha)
        Me.GB_Fecha.Controls.Add(Me.lbl_Hora)
        Me.GB_Fecha.Controls.Add(Me.Label4)
        Me.GB_Fecha.Location = New System.Drawing.Point(6, 20)
        Me.GB_Fecha.Name = "GB_Fecha"
        Me.GB_Fecha.Size = New System.Drawing.Size(660, 44)
        Me.GB_Fecha.TabIndex = 26
        Me.GB_Fecha.TabStop = False
        '
        'lbl_Sucursal
        '
        Me.lbl_Sucursal.AutoSize = True
        Me.lbl_Sucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Sucursal.Location = New System.Drawing.Point(93, 17)
        Me.lbl_Sucursal.Name = "lbl_Sucursal"
        Me.lbl_Sucursal.Size = New System.Drawing.Size(45, 15)
        Me.lbl_Sucursal.TabIndex = 18
        Me.lbl_Sucursal.Text = "Label5"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 15)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "SUCURSAL:"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(507, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 15)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "HORA:"
        '
        'lbl_Fecha
        '
        Me.lbl_Fecha.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_Fecha.AutoSize = True
        Me.lbl_Fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Fecha.Location = New System.Drawing.Point(382, 16)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(45, 15)
        Me.lbl_Fecha.TabIndex = 15
        Me.lbl_Fecha.Text = "Label6"
        '
        'lbl_Hora
        '
        Me.lbl_Hora.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_Hora.AutoSize = True
        Me.lbl_Hora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Hora.Location = New System.Drawing.Point(562, 17)
        Me.lbl_Hora.Name = "lbl_Hora"
        Me.lbl_Hora.Size = New System.Drawing.Size(45, 15)
        Me.lbl_Hora.TabIndex = 14
        Me.lbl_Hora.Text = "Label5"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(321, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 15)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "FECHA:"
        '
        'txt_Cantidad
        '
        Me.txt_Cantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Cantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Cantidad.Location = New System.Drawing.Point(546, 408)
        Me.txt_Cantidad.Name = "txt_Cantidad"
        Me.txt_Cantidad.ReadOnly = True
        Me.txt_Cantidad.Size = New System.Drawing.Size(120, 35)
        Me.txt_Cantidad.TabIndex = 5
        Me.txt_Cantidad.Text = "0"
        Me.txt_Cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(367, 414)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 29)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "CANTIDAD:"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(517, 453)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(26, 29)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "$"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Total
        '
        Me.txt_Total.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Total.Location = New System.Drawing.Point(546, 450)
        Me.txt_Total.Name = "txt_Total"
        Me.txt_Total.ReadOnly = True
        Me.txt_Total.Size = New System.Drawing.Size(120, 35)
        Me.txt_Total.TabIndex = 6
        Me.txt_Total.Text = "0,00"
        Me.txt_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_DescrTot
        '
        Me.lbl_DescrTot.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_DescrTot.AutoSize = True
        Me.lbl_DescrTot.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DescrTot.Location = New System.Drawing.Point(367, 456)
        Me.lbl_DescrTot.Name = "lbl_DescrTot"
        Me.lbl_DescrTot.Size = New System.Drawing.Size(98, 29)
        Me.lbl_DescrTot.TabIndex = 22
        Me.lbl_DescrTot.Text = "TOTAL:"
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
        Me.DG_Productos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NUMERO, Me.ID, Me.CODIGO, Me.NOMBRE, Me.DESCRIPCION, Me.PRECIO, Me.ELIMINAR})
        Me.DG_Productos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DG_Productos.Location = New System.Drawing.Point(6, 165)
        Me.DG_Productos.Name = "DG_Productos"
        Me.DG_Productos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DG_Productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Productos.Size = New System.Drawing.Size(660, 237)
        Me.DG_Productos.TabIndex = 4
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
        '
        'NOMBRE
        '
        Me.NOMBRE.HeaderText = "NOMBRE"
        Me.NOMBRE.Name = "NOMBRE"
        Me.NOMBRE.ReadOnly = True
        '
        'DESCRIPCION
        '
        Me.DESCRIPCION.HeaderText = "DESCRIPCION"
        Me.DESCRIPCION.Name = "DESCRIPCION"
        Me.DESCRIPCION.ReadOnly = True
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
        'ELIMINAR
        '
        Me.ELIMINAR.HeaderText = "ELIMINAR"
        Me.ELIMINAR.Name = "ELIMINAR"
        Me.ELIMINAR.ReadOnly = True
        '
        'Gb_Producto
        '
        Me.Gb_Producto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gb_Producto.Controls.Add(Me.Btn_Buscar)
        Me.Gb_Producto.Controls.Add(Me.txt_CodigoBarra)
        Me.Gb_Producto.Controls.Add(Me.lbl_CodigoBarra)
        Me.Gb_Producto.Controls.Add(Me.Label1)
        Me.Gb_Producto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gb_Producto.Location = New System.Drawing.Point(7, 70)
        Me.Gb_Producto.Name = "Gb_Producto"
        Me.Gb_Producto.Size = New System.Drawing.Size(660, 89)
        Me.Gb_Producto.TabIndex = 1
        Me.Gb_Producto.TabStop = False
        Me.Gb_Producto.Text = "PRODUCTO"
        '
        'txt_CodigoBarra
        '
        Me.txt_CodigoBarra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CodigoBarra.Location = New System.Drawing.Point(225, 48)
        Me.txt_CodigoBarra.Name = "txt_CodigoBarra"
        Me.txt_CodigoBarra.Size = New System.Drawing.Size(150, 20)
        Me.txt_CodigoBarra.TabIndex = 2
        '
        'lbl_CodigoBarra
        '
        Me.lbl_CodigoBarra.AutoSize = True
        Me.lbl_CodigoBarra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CodigoBarra.Location = New System.Drawing.Point(6, 49)
        Me.lbl_CodigoBarra.Name = "lbl_CodigoBarra"
        Me.lbl_CodigoBarra.Size = New System.Drawing.Size(213, 15)
        Me.lbl_CodigoBarra.TabIndex = 7
        Me.lbl_CodigoBarra.Text = "Código de Barra / Código de Producto"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(408, 15)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Ingrese el código de barra o el código de producto y luego presione enter."
        '
        'frmDevoluciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 572)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDevoluciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administración de Devoluciones"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GB_Fecha.ResumeLayout(False)
        Me.GB_Fecha.PerformLayout()
        CType(Me.DG_Productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gb_Producto.ResumeLayout(False)
        Me.Gb_Producto.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ToolCamb As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GB_Fecha As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Sucursal As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbl_Fecha As System.Windows.Forms.Label
    Friend WithEvents lbl_Hora As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_Cantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_Total As System.Windows.Forms.TextBox
    Friend WithEvents lbl_DescrTot As System.Windows.Forms.Label
    Friend WithEvents Btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents Btn_Finalizar As System.Windows.Forms.Button
    Friend WithEvents DG_Productos As System.Windows.Forms.DataGridView
    Friend WithEvents Gb_Producto As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents txt_CodigoBarra As System.Windows.Forms.TextBox
    Friend WithEvents lbl_CodigoBarra As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NUMERO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CODIGO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESCRIPCION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRECIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ELIMINAR As System.Windows.Forms.DataGridViewImageColumn
End Class
