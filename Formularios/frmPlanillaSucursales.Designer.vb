﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPlanillaSucursales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPlanillaSucursales))
        Me.DG_Planilla = New System.Windows.Forms.DataGridView()
        Me.GB_Controles = New System.Windows.Forms.GroupBox()
        Me.Btn_Excel = New System.Windows.Forms.Button()
        Me.btn_Filtrar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_FHasta = New System.Windows.Forms.DateTimePicker()
        Me.Cb_Sucursal = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_FDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.DG_Planilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_Controles.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DG_Planilla
        '
        Me.DG_Planilla.AllowUserToAddRows = False
        Me.DG_Planilla.AllowUserToDeleteRows = False
        Me.DG_Planilla.AllowUserToResizeRows = False
        Me.DG_Planilla.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_Planilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DG_Planilla.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_Planilla.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DG_Planilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Planilla.Cursor = System.Windows.Forms.Cursors.Default
        Me.DG_Planilla.GridColor = System.Drawing.SystemColors.ControlText
        Me.DG_Planilla.Location = New System.Drawing.Point(14, 121)
        Me.DG_Planilla.Name = "DG_Planilla"
        Me.DG_Planilla.ReadOnly = True
        Me.DG_Planilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Planilla.Size = New System.Drawing.Size(956, 439)
        Me.DG_Planilla.TabIndex = 1
        '
        'GB_Controles
        '
        Me.GB_Controles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_Controles.Controls.Add(Me.Btn_Excel)
        Me.GB_Controles.Controls.Add(Me.btn_Filtrar)
        Me.GB_Controles.Controls.Add(Me.TableLayoutPanel1)
        Me.GB_Controles.Location = New System.Drawing.Point(14, 14)
        Me.GB_Controles.Name = "GB_Controles"
        Me.GB_Controles.Size = New System.Drawing.Size(958, 101)
        Me.GB_Controles.TabIndex = 9
        Me.GB_Controles.TabStop = False
        Me.GB_Controles.Text = "Seleccione los diferentes filtros si desea refinar su planilla de movimientos."
        '
        'Btn_Excel
        '
        Me.Btn_Excel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Excel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Excel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Excel.Image = Global.SistemaCinderella.My.Resources.Recursos.Btn_Excel
        Me.Btn_Excel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Excel.Location = New System.Drawing.Point(866, 57)
        Me.Btn_Excel.Name = "Btn_Excel"
        Me.Btn_Excel.Size = New System.Drawing.Size(40, 40)
        Me.Btn_Excel.TabIndex = 15
        Me.Btn_Excel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.Btn_Excel, "Exportar Planilla a Excel")
        Me.Btn_Excel.UseVisualStyleBackColor = True
        '
        'btn_Filtrar
        '
        Me.btn_Filtrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Filtrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Filtrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Filtrar.Image = Global.SistemaCinderella.My.Resources.Recursos.IconoBuscar32
        Me.btn_Filtrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Filtrar.Location = New System.Drawing.Point(912, 57)
        Me.btn_Filtrar.Name = "btn_Filtrar"
        Me.btn_Filtrar.Size = New System.Drawing.Size(40, 40)
        Me.btn_Filtrar.TabIndex = 12
        Me.btn_Filtrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btn_Filtrar, "Refinar la planilla. Se tomarán en cuenta, las diferentes opciones seleccionadas." &
        "")
        Me.btn_Filtrar.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.txt_FHasta, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cb_Sucursal, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_FDesde, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 3, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(6, 20)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(946, 60)
        Me.TableLayoutPanel1.TabIndex = 10
        '
        'txt_FHasta
        '
        Me.txt_FHasta.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_FHasta.Location = New System.Drawing.Point(656, 4)
        Me.txt_FHasta.Name = "txt_FHasta"
        Me.txt_FHasta.Size = New System.Drawing.Size(287, 21)
        Me.txt_FHasta.TabIndex = 17
        '
        'Cb_Sucursal
        '
        Me.Cb_Sucursal.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cb_Sucursal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cb_Sucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Sucursal.FormattingEnabled = True
        Me.Cb_Sucursal.Items.AddRange(New Object() {"Mes Completo", "Primera Quincena", "Segunda Quincena"})
        Me.Cb_Sucursal.Location = New System.Drawing.Point(143, 34)
        Me.Cb_Sucursal.Name = "Cb_Sucursal"
        Me.Cb_Sucursal.Size = New System.Drawing.Size(287, 23)
        Me.Cb_Sucursal.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 15)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Sucursal"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 15)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Período Inicio"
        '
        'txt_FDesde
        '
        Me.txt_FDesde.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_FDesde.Location = New System.Drawing.Point(143, 4)
        Me.txt_FDesde.Name = "txt_FDesde"
        Me.txt_FDesde.Size = New System.Drawing.Size(287, 21)
        Me.txt_FDesde.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(516, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 15)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Período Fin"
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Ayuda"
        '
        'frmPlanillaSucursales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 572)
        Me.Controls.Add(Me.GB_Controles)
        Me.Controls.Add(Me.DG_Planilla)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPlanillaSucursales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Planilla de Movimientos de sucursal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DG_Planilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_Controles.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DG_Planilla As System.Windows.Forms.DataGridView
    Friend WithEvents GB_Controles As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_Filtrar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Cb_Sucursal As System.Windows.Forms.ComboBox
    Friend WithEvents Btn_Excel As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents txt_FHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_FDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
