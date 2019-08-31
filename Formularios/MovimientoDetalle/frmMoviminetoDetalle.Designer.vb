<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMoviminetoDetalle(Of T)
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
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.dgvMovimientosDetalle = New System.Windows.Forms.DataGridView()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.GroupBox.SuspendLayout()
        CType(Me.dgvMovimientosDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox
        '
        Me.GroupBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox.Controls.Add(Me.dgvMovimientosDetalle)
        Me.GroupBox.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(618, 559)
        Me.GroupBox.TabIndex = 0
        Me.GroupBox.TabStop = False
        Me.GroupBox.Text = "GroupBox"
        '
        'dgvMovimientosDetalle
        '
        Me.dgvMovimientosDetalle.AllowUserToAddRows = False
        Me.dgvMovimientosDetalle.AllowUserToDeleteRows = False
        Me.dgvMovimientosDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMovimientosDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMovimientosDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMovimientosDetalle.Location = New System.Drawing.Point(3, 16)
        Me.dgvMovimientosDetalle.Name = "dgvMovimientosDetalle"
        Me.dgvMovimientosDetalle.ReadOnly = True
        Me.dgvMovimientosDetalle.Size = New System.Drawing.Size(612, 540)
        Me.dgvMovimientosDetalle.TabIndex = 0
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = Global.SistemaCinderella.My.Resources.Recursos.desconectado_32
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(541, 574)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(86, 46)
        Me.btnCancelar.TabIndex = 8
        Me.btnCancelar.Text = "Cerrar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'frmMoviminetoDetalle
        '
        Me.ClientSize = New System.Drawing.Size(642, 623)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.GroupBox)
        Me.Name = "frmMoviminetoDetalle"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle Movimientos"
        Me.GroupBox.ResumeLayout(False)
        CType(Me.dgvMovimientosDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox As GroupBox
    Friend WithEvents dgvMovimientosDetalle As DataGridView
    Friend WithEvents btnCancelar As Button
End Class
