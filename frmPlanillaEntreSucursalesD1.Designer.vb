<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPlanillaEntreSucursalesD1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPlanillaEntreSucursalesD1))
        Me.GB1 = New System.Windows.Forms.GroupBox()
        Me.lblMonto = New System.Windows.Forms.Label()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblComentarios = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblSucursal = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblSucursalDestino = New System.Windows.Forms.Label()
        Me.GB1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GB1
        '
        Me.GB1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB1.Controls.Add(Me.Label7)
        Me.GB1.Controls.Add(Me.lblSucursalDestino)
        Me.GB1.Controls.Add(Me.lblMonto)
        Me.GB1.Controls.Add(Me.BtnCerrar)
        Me.GB1.Controls.Add(Me.Label2)
        Me.GB1.Controls.Add(Me.Label1)
        Me.GB1.Controls.Add(Me.Label4)
        Me.GB1.Controls.Add(Me.lblFecha)
        Me.GB1.Controls.Add(Me.lblComentarios)
        Me.GB1.Controls.Add(Me.Label3)
        Me.GB1.Controls.Add(Me.lblDescripcion)
        Me.GB1.Controls.Add(Me.lblSucursal)
        Me.GB1.Controls.Add(Me.lblTipo)
        Me.GB1.Controls.Add(Me.Label5)
        Me.GB1.Controls.Add(Me.Label6)
        Me.GB1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB1.Location = New System.Drawing.Point(10, 10)
        Me.GB1.Name = "GB1"
        Me.GB1.Size = New System.Drawing.Size(572, 300)
        Me.GB1.TabIndex = 0
        Me.GB1.TabStop = False
        Me.GB1.Text = "DETALLE DEL MOV. SELECCIONADO"
        '
        'lblMonto
        '
        Me.lblMonto.AutoSize = True
        Me.lblMonto.Location = New System.Drawing.Point(19, 230)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(26, 16)
        Me.lblMonto.TabIndex = 12
        Me.lblMonto.Text = "- - -"
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrar.Image = Global.SistemaCinderella.My.Resources.Recursos.desconectado_32
        Me.BtnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCerrar.Location = New System.Drawing.Point(455, 252)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(100, 40)
        Me.BtnCerrar.TabIndex = 0
        Me.BtnCerrar.Text = "Cerrar"
        Me.BtnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 212)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 15)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Monto"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(305, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Comentarios:"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(19, 45)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(26, 16)
        Me.lblFecha.TabIndex = 1
        Me.lblFecha.Text = "- - -"
        '
        'lblComentarios
        '
        Me.lblComentarios.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblComentarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblComentarios.Location = New System.Drawing.Point(305, 43)
        Me.lblComentarios.MaximumSize = New System.Drawing.Size(250, 250)
        Me.lblComentarios.Name = "lblComentarios"
        Me.lblComentarios.Size = New System.Drawing.Size(250, 200)
        Me.lblComentarios.TabIndex = 8
        Me.lblComentarios.Text = "Sin comentarios."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Sucursal"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(19, 193)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(26, 16)
        Me.lblDescripcion.TabIndex = 7
        Me.lblDescripcion.Text = "- - -"
        '
        'lblSucursal
        '
        Me.lblSucursal.AutoSize = True
        Me.lblSucursal.Location = New System.Drawing.Point(19, 82)
        Me.lblSucursal.Name = "lblSucursal"
        Me.lblSucursal.Size = New System.Drawing.Size(26, 16)
        Me.lblSucursal.TabIndex = 3
        Me.lblSucursal.Text = "- - -"
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Location = New System.Drawing.Point(19, 156)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(26, 16)
        Me.lblTipo.TabIndex = 6
        Me.lblTipo.Text = "- - -"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tipo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(19, 175)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Descripción"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(19, 101)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 15)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Sucursal Destino"
        '
        'lblSucursalDestino
        '
        Me.lblSucursalDestino.AutoSize = True
        Me.lblSucursalDestino.Location = New System.Drawing.Point(19, 119)
        Me.lblSucursalDestino.Name = "lblSucursalDestino"
        Me.lblSucursalDestino.Size = New System.Drawing.Size(26, 16)
        Me.lblSucursalDestino.TabIndex = 14
        Me.lblSucursalDestino.Text = "- - -"
        '
        'frmPlanillaEntreSucursalesD1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 322)
        Me.Controls.Add(Me.GB1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPlanillaEntreSucursalesD1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mov. entre Sucursales | Detalle"
        Me.GB1.ResumeLayout(False)
        Me.GB1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GB1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnCerrar As System.Windows.Forms.Button
    Friend WithEvents lblMonto As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents lblComentarios As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents lblSucursal As System.Windows.Forms.Label
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblSucursalDestino As System.Windows.Forms.Label
End Class
