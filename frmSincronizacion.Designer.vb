<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSincronizacion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSincronizacion))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_Cerrar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Progreso = New System.Windows.Forms.ProgressBar()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ListaEstado = New System.Windows.Forms.ListView()
        Me.Proceso = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Estado = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblEstadoRemota = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblEstadoLocal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSincronizar = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_Cerrar)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Progreso)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.lblEstadoRemota)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblEstadoLocal)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnSincronizar)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(583, 448)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sincronización de datos"
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Cerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cerrar.Image = Global.SistemaCinderella.My.Resources.Recursos.desconectado_32
        Me.btn_Cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Cerrar.Location = New System.Drawing.Point(368, 26)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(100, 40)
        Me.btn_Cerrar.TabIndex = 8
        Me.btn_Cerrar.Text = "Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        Me.btn_Cerrar.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 394)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Indicador de progreso:"
        '
        'Progreso
        '
        Me.Progreso.Location = New System.Drawing.Point(13, 410)
        Me.Progreso.Name = "Progreso"
        Me.Progreso.Size = New System.Drawing.Size(561, 29)
        Me.Progreso.TabIndex = 6
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ListaEstado)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 76)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(561, 315)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Proceso de sincronización"
        '
        'ListaEstado
        '
        Me.ListaEstado.AutoArrange = False
        Me.ListaEstado.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Proceso, Me.Estado})
        Me.ListaEstado.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListaEstado.Location = New System.Drawing.Point(3, 19)
        Me.ListaEstado.Name = "ListaEstado"
        Me.ListaEstado.Size = New System.Drawing.Size(552, 290)
        Me.ListaEstado.TabIndex = 1
        Me.ListaEstado.UseCompatibleStateImageBehavior = False
        Me.ListaEstado.View = System.Windows.Forms.View.Details
        '
        'Proceso
        '
        Me.Proceso.Text = "Proceso"
        Me.Proceso.Width = 380
        '
        'Estado
        '
        Me.Estado.Text = "Estado"
        Me.Estado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Estado.Width = 156
        '
        'lblEstadoRemota
        '
        Me.lblEstadoRemota.AutoSize = True
        Me.lblEstadoRemota.Location = New System.Drawing.Point(171, 44)
        Me.lblEstadoRemota.Name = "lblEstadoRemota"
        Me.lblEstadoRemota.Size = New System.Drawing.Size(44, 15)
        Me.lblEstadoRemota.TabIndex = 4
        Me.lblEstadoRemota.Text = "estado"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Conexion SERVIDOR:"
        '
        'lblEstadoLocal
        '
        Me.lblEstadoLocal.AutoSize = True
        Me.lblEstadoLocal.Location = New System.Drawing.Point(171, 26)
        Me.lblEstadoLocal.Name = "lblEstadoLocal"
        Me.lblEstadoLocal.Size = New System.Drawing.Size(44, 15)
        Me.lblEstadoLocal.TabIndex = 2
        Me.lblEstadoLocal.Text = "estado"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Conexion LOCAL:"
        '
        'btnSincronizar
        '
        Me.btnSincronizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSincronizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSincronizar.Image = Global.SistemaCinderella.My.Resources.Recursos.Conectado_32
        Me.btnSincronizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSincronizar.Location = New System.Drawing.Point(474, 26)
        Me.btnSincronizar.Name = "btnSincronizar"
        Me.btnSincronizar.Size = New System.Drawing.Size(100, 40)
        Me.btnSincronizar.TabIndex = 0
        Me.btnSincronizar.Text = "Iniciar"
        Me.btnSincronizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSincronizar.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "ok")
        Me.ImageList1.Images.SetKeyName(1, "error")
        Me.ImageList1.Images.SetKeyName(2, "enproceso.png")
        '
        'frmSincronizacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 463)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmSincronizacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sincronización de Bases de Datos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblEstadoRemota As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblEstadoLocal As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSincronizar As System.Windows.Forms.Button
    Friend WithEvents Progreso As System.Windows.Forms.ProgressBar
    Friend WithEvents ListaEstado As System.Windows.Forms.ListView
    Friend WithEvents Proceso As System.Windows.Forms.ColumnHeader
    Friend WithEvents Estado As System.Windows.Forms.ColumnHeader
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
