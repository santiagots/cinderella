<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockBitacora
    Inherits Comun

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStockBitacora))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Paginado = New SistemaCinderella.Paginado()
        Me.FrmStockBitacoraViewModelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.FechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_Total = New System.Windows.Forms.TextBox()
        Me.lbl_DescrTot = New System.Windows.Forms.Label()
        Me.lbl_Msg = New System.Windows.Forms.Label()
        Me.btn_Restablecer = New System.Windows.Forms.Button()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.DG_Stock = New System.Windows.Forms.DataGridView()
        Me.BitacorasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductoCodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductoNombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockMinimoAnteriorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockOptimoAnteriorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockActualAnteriorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockMinimoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockOptimo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockActualDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MotivoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.FrmStockBitacoraViewModelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DG_Stock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BitacorasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Paginado)
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox1.Controls.Add(Me.txt_Total)
        Me.GroupBox1.Controls.Add(Me.lbl_DescrTot)
        Me.GroupBox1.Controls.Add(Me.lbl_Msg)
        Me.GroupBox1.Controls.Add(Me.btn_Restablecer)
        Me.GroupBox1.Controls.Add(Me.btn_Buscar)
        Me.GroupBox1.Controls.Add(Me.DG_Stock)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(998, 600)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Paginado
        '
        Me.Paginado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Paginado.DataBindings.Add(New System.Windows.Forms.Binding("TotalElementos", Me.FrmStockBitacoraViewModelBindingSource, "TotalElementos", True))
        Me.Paginado.Leyenda = "{0} de {1}"
        Me.Paginado.Location = New System.Drawing.Point(6, 552)
        Me.Paginado.Name = "Paginado"
        Me.Paginado.PaginaActual = 1
        Me.Paginado.Size = New System.Drawing.Size(229, 31)
        Me.Paginado.TabIndex = 26
        Me.Paginado.TotalElementos = 0
        '
        'FrmStockBitacoraViewModelBindingSource
        '
        Me.FrmStockBitacoraViewModelBindingSource.DataSource = GetType(SistemaCinderella.Formularios.Stock.frmStockBitacoraViewModel)
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.FechaDesde, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.FechaHasta, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 3, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(6, 20)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(986, 42)
        Me.TableLayoutPanel1.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 15)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Fecha Desde"
        '
        'FechaDesde
        '
        Me.FechaDesde.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FechaDesde.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FrmStockBitacoraViewModelBindingSource, "FechaDesde", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "D"))
        Me.FechaDesde.Location = New System.Drawing.Point(163, 10)
        Me.FechaDesde.Name = "FechaDesde"
        Me.FechaDesde.Size = New System.Drawing.Size(307, 21)
        Me.FechaDesde.TabIndex = 2
        '
        'FechaHasta
        '
        Me.FechaHasta.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FechaHasta.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FrmStockBitacoraViewModelBindingSource, "FechaHasta", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "D"))
        Me.FechaHasta.Location = New System.Drawing.Point(676, 10)
        Me.FechaHasta.Name = "FechaHasta"
        Me.FechaHasta.Size = New System.Drawing.Size(307, 21)
        Me.FechaHasta.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(516, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 15)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Fecha Hasta"
        '
        'txt_Total
        '
        Me.txt_Total.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Total.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmStockBitacoraViewModelBindingSource, "Total", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.txt_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Total.Location = New System.Drawing.Point(650, 555)
        Me.txt_Total.Name = "txt_Total"
        Me.txt_Total.ReadOnly = True
        Me.txt_Total.Size = New System.Drawing.Size(342, 35)
        Me.txt_Total.TabIndex = 23
        Me.txt_Total.Text = "0,00"
        '
        'lbl_DescrTot
        '
        Me.lbl_DescrTot.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_DescrTot.AutoSize = True
        Me.lbl_DescrTot.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DescrTot.Location = New System.Drawing.Point(546, 558)
        Me.lbl_DescrTot.Name = "lbl_DescrTot"
        Me.lbl_DescrTot.Size = New System.Drawing.Size(98, 29)
        Me.lbl_DescrTot.TabIndex = 22
        Me.lbl_DescrTot.Text = "TOTAL:"
        '
        'lbl_Msg
        '
        Me.lbl_Msg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Msg.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lbl_Msg.DataBindings.Add(New System.Windows.Forms.Binding("Visible", Me.FrmStockBitacoraViewModelBindingSource, "SinResultados", True))
        Me.lbl_Msg.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Msg.Location = New System.Drawing.Point(81, 243)
        Me.lbl_Msg.Name = "lbl_Msg"
        Me.lbl_Msg.Size = New System.Drawing.Size(836, 175)
        Me.lbl_Msg.TabIndex = 4
        Me.lbl_Msg.Text = "No se ha encontrado stocks cargados."
        Me.lbl_Msg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_Restablecer
        '
        Me.btn_Restablecer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Restablecer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Restablecer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Restablecer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Restablecer.Location = New System.Drawing.Point(786, 68)
        Me.btn_Restablecer.Name = "btn_Restablecer"
        Me.btn_Restablecer.Size = New System.Drawing.Size(100, 40)
        Me.btn_Restablecer.TabIndex = 5
        Me.btn_Restablecer.Text = "Restablecer Filtros"
        Me.btn_Restablecer.UseVisualStyleBackColor = True
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Buscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Buscar.Image = Global.SistemaCinderella.My.Resources.Recursos.IconoBuscar32
        Me.btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Buscar.Location = New System.Drawing.Point(892, 68)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(100, 40)
        Me.btn_Buscar.TabIndex = 4
        Me.btn_Buscar.Text = "Buscar"
        Me.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'DG_Stock
        '
        Me.DG_Stock.AllowUserToAddRows = False
        Me.DG_Stock.AllowUserToDeleteRows = False
        Me.DG_Stock.AllowUserToResizeRows = False
        Me.DG_Stock.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_Stock.AutoGenerateColumns = False
        Me.DG_Stock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_Stock.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Fecha, Me.ProductoCodigoDataGridViewTextBoxColumn, Me.ProductoNombreDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn, Me.AccionDataGridViewTextBoxColumn, Me.StockMinimoAnteriorDataGridViewTextBoxColumn, Me.StockOptimoAnteriorDataGridViewTextBoxColumn, Me.StockActualAnteriorDataGridViewTextBoxColumn, Me.StockMinimoDataGridViewTextBoxColumn, Me.StockOptimo, Me.StockActualDataGridViewTextBoxColumn, Me.UsuarioDataGridViewTextBoxColumn, Me.MotivoDataGridViewTextBoxColumn})
        Me.DG_Stock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DG_Stock.DataSource = Me.BitacorasBindingSource
        Me.DG_Stock.Location = New System.Drawing.Point(6, 114)
        Me.DG_Stock.MultiSelect = False
        Me.DG_Stock.Name = "DG_Stock"
        Me.DG_Stock.ReadOnly = True
        Me.DG_Stock.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DG_Stock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Stock.Size = New System.Drawing.Size(986, 432)
        Me.DG_Stock.TabIndex = 6
        '
        'BitacorasBindingSource
        '
        Me.BitacorasBindingSource.DataMember = "Bitacoras"
        Me.BitacorasBindingSource.DataSource = Me.FrmStockBitacoraViewModelBindingSource
        '
        'Fecha
        '
        Me.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Fecha.DataPropertyName = "Fecha"
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Width = 66
        '
        'ProductoCodigoDataGridViewTextBoxColumn
        '
        Me.ProductoCodigoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.ProductoCodigoDataGridViewTextBoxColumn.DataPropertyName = "ProductoCodigo"
        Me.ProductoCodigoDataGridViewTextBoxColumn.HeaderText = "Cód."
        Me.ProductoCodigoDataGridViewTextBoxColumn.Name = "ProductoCodigoDataGridViewTextBoxColumn"
        Me.ProductoCodigoDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductoCodigoDataGridViewTextBoxColumn.Width = 57
        '
        'ProductoNombreDataGridViewTextBoxColumn
        '
        Me.ProductoNombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.ProductoNombreDataGridViewTextBoxColumn.DataPropertyName = "ProductoNombre"
        Me.ProductoNombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.ProductoNombreDataGridViewTextBoxColumn.Name = "ProductoNombreDataGridViewTextBoxColumn"
        Me.ProductoNombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductoNombreDataGridViewTextBoxColumn.Width = 77
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "Total"
        DataGridViewCellStyle1.Format = "c2"
        Me.TotalDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "SubTotal"
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        Me.TotalDataGridViewTextBoxColumn.ReadOnly = True
        Me.TotalDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.TotalDataGridViewTextBoxColumn.Width = 62
        '
        'AccionDataGridViewTextBoxColumn
        '
        Me.AccionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.AccionDataGridViewTextBoxColumn.DataPropertyName = "Accion"
        Me.AccionDataGridViewTextBoxColumn.HeaderText = "Acción"
        Me.AccionDataGridViewTextBoxColumn.Name = "AccionDataGridViewTextBoxColumn"
        Me.AccionDataGridViewTextBoxColumn.ReadOnly = True
        Me.AccionDataGridViewTextBoxColumn.Width = 68
        '
        'StockMinimoAnteriorDataGridViewTextBoxColumn
        '
        Me.StockMinimoAnteriorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.StockMinimoAnteriorDataGridViewTextBoxColumn.DataPropertyName = "StockMinimoAnterior"
        Me.StockMinimoAnteriorDataGridViewTextBoxColumn.HeaderText = "Min. (Ant.)"
        Me.StockMinimoAnteriorDataGridViewTextBoxColumn.Name = "StockMinimoAnteriorDataGridViewTextBoxColumn"
        Me.StockMinimoAnteriorDataGridViewTextBoxColumn.ReadOnly = True
        Me.StockMinimoAnteriorDataGridViewTextBoxColumn.Width = 87
        '
        'StockOptimoAnteriorDataGridViewTextBoxColumn
        '
        Me.StockOptimoAnteriorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.StockOptimoAnteriorDataGridViewTextBoxColumn.DataPropertyName = "StockOptimoAnterior"
        Me.StockOptimoAnteriorDataGridViewTextBoxColumn.HeaderText = "Opt. (Ant.)"
        Me.StockOptimoAnteriorDataGridViewTextBoxColumn.Name = "StockOptimoAnteriorDataGridViewTextBoxColumn"
        Me.StockOptimoAnteriorDataGridViewTextBoxColumn.ReadOnly = True
        Me.StockOptimoAnteriorDataGridViewTextBoxColumn.Width = 85
        '
        'StockActualAnteriorDataGridViewTextBoxColumn
        '
        Me.StockActualAnteriorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.StockActualAnteriorDataGridViewTextBoxColumn.DataPropertyName = "StockActualAnterior"
        Me.StockActualAnteriorDataGridViewTextBoxColumn.HeaderText = "Act. (Ant.)"
        Me.StockActualAnteriorDataGridViewTextBoxColumn.Name = "StockActualAnteriorDataGridViewTextBoxColumn"
        Me.StockActualAnteriorDataGridViewTextBoxColumn.ReadOnly = True
        Me.StockActualAnteriorDataGridViewTextBoxColumn.Width = 82
        '
        'StockMinimoDataGridViewTextBoxColumn
        '
        Me.StockMinimoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.StockMinimoDataGridViewTextBoxColumn.DataPropertyName = "StockMinimo"
        Me.StockMinimoDataGridViewTextBoxColumn.HeaderText = "Min,"
        Me.StockMinimoDataGridViewTextBoxColumn.Name = "StockMinimoDataGridViewTextBoxColumn"
        Me.StockMinimoDataGridViewTextBoxColumn.ReadOnly = True
        Me.StockMinimoDataGridViewTextBoxColumn.Width = 56
        '
        'StockOptimo
        '
        Me.StockOptimo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.StockOptimo.DataPropertyName = "StockOptimo"
        Me.StockOptimo.HeaderText = "Opt."
        Me.StockOptimo.Name = "StockOptimo"
        Me.StockOptimo.ReadOnly = True
        Me.StockOptimo.Width = 54
        '
        'StockActualDataGridViewTextBoxColumn
        '
        Me.StockActualDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.StockActualDataGridViewTextBoxColumn.DataPropertyName = "StockActual"
        Me.StockActualDataGridViewTextBoxColumn.HeaderText = "Act."
        Me.StockActualDataGridViewTextBoxColumn.Name = "StockActualDataGridViewTextBoxColumn"
        Me.StockActualDataGridViewTextBoxColumn.ReadOnly = True
        Me.StockActualDataGridViewTextBoxColumn.Width = 51
        '
        'UsuarioDataGridViewTextBoxColumn
        '
        Me.UsuarioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.UsuarioDataGridViewTextBoxColumn.DataPropertyName = "usuario"
        Me.UsuarioDataGridViewTextBoxColumn.HeaderText = "Usuario"
        Me.UsuarioDataGridViewTextBoxColumn.Name = "UsuarioDataGridViewTextBoxColumn"
        Me.UsuarioDataGridViewTextBoxColumn.ReadOnly = True
        Me.UsuarioDataGridViewTextBoxColumn.Width = 75
        '
        'MotivoDataGridViewTextBoxColumn
        '
        Me.MotivoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MotivoDataGridViewTextBoxColumn.DataPropertyName = "Motivo"
        Me.MotivoDataGridViewTextBoxColumn.HeaderText = "Motivo"
        Me.MotivoDataGridViewTextBoxColumn.MinimumWidth = 125
        Me.MotivoDataGridViewTextBoxColumn.Name = "MotivoDataGridViewTextBoxColumn"
        Me.MotivoDataGridViewTextBoxColumn.ReadOnly = True
        Me.MotivoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'frmStockBitacora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 610)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmStockBitacora"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de Stocks Modificados / Eliminados"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.FrmStockBitacoraViewModelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.DG_Stock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BitacorasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Msg As System.Windows.Forms.Label
    Friend WithEvents btn_Restablecer As System.Windows.Forms.Button
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents DG_Stock As System.Windows.Forms.DataGridView
    Friend WithEvents FechaHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents FechaDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_Total As System.Windows.Forms.TextBox
    Friend WithEvents lbl_DescrTot As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents FrmStockBitacoraViewModelBindingSource As BindingSource
    Friend WithEvents BitacorasBindingSource As BindingSource
    Friend WithEvents Paginado As Paginado
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents ProductoCodigoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductoNombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AccionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StockMinimoAnteriorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StockOptimoAnteriorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StockActualAnteriorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StockMinimoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StockOptimo As DataGridViewTextBoxColumn
    Friend WithEvents StockActualDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsuarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MotivoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
