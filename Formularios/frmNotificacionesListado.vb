Public Class frmNotificacionesListado
    Dim NegMovimiento As New Negocio.NegMovimientos
    Dim NegCajaInicial As New Negocio.NegCajaInicial
    Dim Functions As New Funciones

#Region "Region de Eventos"
    'Load del formulario.
    Private Sub frmNotificacionesListado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            'Seteo el titulo del formulario
            Me.Text = "Notificaciones de la sucursal " & My.Settings.NombreSucursal

            'Oculto Columnas en el DG_Productos
            DG_Notificaciones.Columns("id_Movimiento").Visible = False
            DG_Notificaciones.Columns("id_Tipo").Visible = False
            DG_Notificaciones.Columns("id_Sucursal").Visible = False
            DG_Notificaciones.Columns("Aceptado").Visible = False
            DG_Notificaciones.Columns("Comentarios").Visible = False

            'Cargo el datagrid de movimientos
            CargarPlanilla()

            EvaluarPermisos()

            'Cambio el cursor a NORMAL.
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show(ex.Message, "Notificaciones de la sucursal " & My.Settings.NombreSucursal, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Boton que cierra la ventana
    Private Sub Btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cancelar.Click
        Me.Close()
    End Sub

    'Cuando realiza un click dentro del datagrid de movimientos.
    Private Sub DG_Notificaciones_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Notificaciones.CellContentClick
        If e.RowIndex >= 0 And e.ColumnIndex > 0 Then
            If DG_Notificaciones.Columns(e.ColumnIndex).Name = "Aceptar" And DG_Notificaciones.Rows(e.RowIndex).Cells("Aceptado").Value = "NO" Then 'Si se hace click en el boton "Aceptar".
                If MessageBox.Show("¿Está seguro que desea aceptar el movimiento?", "Notificaciones de la sucursal " & My.Settings.NombreSucursal, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    Try
                        'Cambio el cursor a "WAIT"
                        Me.Cursor = Cursors.WaitCursor

                        'Seteo las variables
                        Dim id_Mov As Integer = DG_Notificaciones.Rows(e.RowIndex).Cells("id_Movimiento").Value()
                        Dim id_Tipo As Integer = DG_Notificaciones.Rows(e.RowIndex).Cells("id_Tipo").Value()
                        Dim id_Subtipo As Integer = DG_Notificaciones.Rows(e.RowIndex).Cells("id_Subtipo").Value()
                        Dim id_Sucu As Integer = DG_Notificaciones.Rows(e.RowIndex).Cells("id_Sucursal").Value()
                        Dim Monto As Decimal = DG_Notificaciones.Rows(e.RowIndex).Cells("Monto").Value()

                        If NegMovimiento.AceptarMovimiento(id_Mov, id_Tipo, id_Subtipo, id_Sucu, My.Settings.Sucursal, Monto) Then
                            CargarPlanilla() 'Recargo la planilla.
                            Functions.ActualizarNotificaciones() 'Actualizo las notificaciones.
                            MessageBox.Show("El movimiento se ha aceptado correctamente.", "Notificaciones de la sucursal " & My.Settings.NombreSucursal, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Se ha producido un error al aceptar el movimiento.", "Notificaciones de la sucursal " & My.Settings.NombreSucursal, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If

                        'Cambio el cursor a NORMAL.
                        Me.Cursor = Cursors.Arrow
                    Catch ex As Exception
                        Me.Cursor = Cursors.Arrow
                        MessageBox.Show("Se ha producido un error al aceptar el movimiento.", "Notificaciones de la sucursal " & My.Settings.NombreSucursal, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
            ElseIf DG_Notificaciones.Columns(e.ColumnIndex).Name = "Eliminar" And DG_Notificaciones.Rows(e.RowIndex).Cells("Aceptado").Value = "NO" Then 'Si se hace click en el boton "Eliminar".
                If MessageBox.Show("¿Está seguro que desea rechazar el movimiento?", "Notificaciones de la sucursal " & My.Settings.NombreSucursal, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    Try
                        'Cambio el cursor a "WAIT"
                        Me.Cursor = Cursors.WaitCursor

                        'Seteo las variables
                        Dim id_Mov As Integer = DG_Notificaciones.Rows(e.RowIndex).Cells("id_Movimiento").Value()
                        Dim id_Sucu As Integer = DG_Notificaciones.Rows(e.RowIndex).Cells("id_Sucursal").Value()
                        Dim id_Tipo As Integer = DG_Notificaciones.Rows(e.RowIndex).Cells("id_Tipo").Value()

                        If NegMovimiento.RechazarMovimiento(id_Mov, id_Tipo, id_Sucu, My.Settings.Sucursal) Then
                            CargarPlanilla() 'Recargo la planilla.
                            Functions.ActualizarNotificaciones() 'Actualizo las notificaciones.
                            MessageBox.Show("El movimiento se ha rechazado correctamente.", "Notificaciones de la sucursal " & My.Settings.NombreSucursal, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Se ha producido un error al rechazar el movimiento.", "Notificaciones de la sucursal " & My.Settings.NombreSucursal, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If

                        'Cambio el cursor a NORMAL.
                        Me.Cursor = Cursors.Arrow
                    Catch ex As Exception
                        Me.Cursor = Cursors.Arrow
                        MessageBox.Show("Se ha producido un error al aceptar el movimiento.", "Notificaciones de la sucursal " & My.Settings.NombreSucursal, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
            End If
        End If
    End Sub

    'Hago aparecer la manito loca!
    Private Sub DG_Notificaciones_CellMouseEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Notificaciones.CellMouseEnter
        If e.ColumnIndex < 0 Or e.RowIndex < 0 Then
            Return
        Else
            If (e.ColumnIndex = 11 And DG_Notificaciones.Rows(e.RowIndex).Cells("Aceptado").Value = "NO") Or (e.ColumnIndex = 12 And DG_Notificaciones.Rows(e.RowIndex).Cells("Aceptado").Value = "NO") Then
                DG_Notificaciones.Cursor = Cursors.Hand
            Else
                DG_Notificaciones.Cursor = Cursors.Arrow
            End If
        End If
    End Sub

    'Bold en la fila seleccionada.
    Private Sub DG_Notificaciones_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Notificaciones.RowEnter
        DG_Notificaciones.Rows(e.RowIndex).DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold)

        'Muestro el detalle y lo cargo con los datos.
        Me.Cursor = Cursors.WaitCursor

        Gb_Detalle.Visible = True
        lblAceptado.Text = DG_Notificaciones.Rows(e.RowIndex).Cells("Aceptado").Value
        lblDescripcion.Text = Replace(DG_Notificaciones.Rows(e.RowIndex).Cells("Descripcion").Value, "<br />", vbCrLf)
        lblFecha.Text = DG_Notificaciones.Rows(e.RowIndex).Cells("Fecha").Value
        lblMonto.Text = DG_Notificaciones.Rows(e.RowIndex).Cells("Monto").Value
        lblSucursal.Text = DG_Notificaciones.Rows(e.RowIndex).Cells("Sucursal").Value
        lblTipo.Text = DG_Notificaciones.Rows(e.RowIndex).Cells("Tipo").Value

        If DG_Notificaciones.Rows(e.RowIndex).Cells("Comentarios").Value <> "" Then
            lblComentarios.Text = Replace(DG_Notificaciones.Rows(e.RowIndex).Cells("Comentarios").Value, "<br />", vbCrLf)
        Else
            lblComentarios.Text = "Sin comentarios."
        End If
        Me.Cursor = Cursors.Arrow

    End Sub

    'Sin Bold en la fila no seleccionada.
    Private Sub DG_Notificaciones_RowLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Notificaciones.RowLeave
        DG_Notificaciones.Rows(e.RowIndex).DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Regular)

        'Oculto el detalle y borro todos los datos
        Gb_Detalle.Visible = False
        lblAceptado.Text = ""
        lblDescripcion.Text = ""
        lblFecha.Text = ""
        lblMonto.Text = ""
        lblSucursal.Text = ""
        lblTipo.Text = ""
        lblComentarios.Text = ""
        
    End Sub
#End Region

#Region "Region de Funciones"
    Sub AgregarMovimiento(ByVal id_Movimiento As Integer, ByVal id_Tipo As Integer, ByVal id_Subtipo As Integer, ByVal id_Sucursal As Integer, ByVal Sucu As String, ByVal Fecha As String, ByVal Tipo As String, ByVal Descripcion As String, ByVal Monto As Double, ByVal Aceptado As String, ByVal Comentarios As String)

        'Creo la fila del producto.
        Dim dgvRow As New DataGridViewRow
        Dim dgvCell As DataGridViewCell

        'Valor de la Columna Id
        dgvCell = New DataGridViewTextBoxCell()
        dgvCell.Value = id_Movimiento
        dgvRow.Cells.Add(dgvCell)

        'Valor de la Columna id_Tipo
        dgvCell = New DataGridViewTextBoxCell()
        dgvCell.Value = id_Tipo
        dgvRow.Cells.Add(dgvCell)

        'Valor de la Columna id_Subtipo
        dgvCell = New DataGridViewTextBoxCell()
        dgvCell.Value = id_Subtipo
        dgvRow.Cells.Add(dgvCell)

        'Valor de la Columna id_Sucursal
        dgvCell = New DataGridViewTextBoxCell()
        dgvCell.Value = id_Sucursal
        dgvRow.Cells.Add(dgvCell)

        'Valor de la Columna Fecha
        dgvCell = New DataGridViewTextBoxCell()
        dgvCell.Value = Fecha
        dgvRow.Cells.Add(dgvCell)

        'Valor de la Columna Sucursal
        dgvCell = New DataGridViewTextBoxCell()
        dgvCell.Value = Sucu
        dgvRow.Cells.Add(dgvCell)

        'Valor de la Columna Tipo
        dgvCell = New DataGridViewTextBoxCell()
        dgvCell.Value = Tipo
        dgvRow.Cells.Add(dgvCell)

        'Valor de la Columna Descripcion
        dgvCell = New DataGridViewTextBoxCell()
        dgvCell.Value = Descripcion
        dgvRow.Cells.Add(dgvCell)

        'Valor de la Columna Monto
        dgvCell = New DataGridViewTextBoxCell()
        dgvCell.Value = "$ " & Format(CType(Monto, Decimal), "###0.00")
        dgvRow.Cells.Add(dgvCell)

        'Valor de la Columna Aceptado
        dgvCell = New DataGridViewTextBoxCell()
        dgvCell.Value = Aceptado
        dgvRow.Cells.Add(dgvCell)

        'Valor de la Columna Comentarios
        dgvCell = New DataGridViewTextBoxCell()
        dgvCell.Value = Comentarios
        dgvRow.Cells.Add(dgvCell)

        'Valor de la Columna Comentario
        dgvCell = New DataGridViewImageCell()
        If Comentarios <> "" Then
            dgvCell.Value = My.Resources.Recursos.Comentario_16
            dgvCell.ToolTipText = "Con comentarios."
        Else
            dgvCell.Value = My.Resources.Recursos.Comentario_delete_16
            dgvCell.ToolTipText = "Sin comentarios."
        End If
        dgvCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvRow.Cells.Add(dgvCell)

        'Valor de la Columna Aceptar
        dgvCell = New DataGridViewImageCell()
        If Aceptado = "NO" Then
            dgvCell.Value = My.Resources.Recursos.Standby_16
            dgvCell.ToolTipText = "Haga click aquí para aceptar éste movimiento"
        Else
            dgvCell.Value = My.Resources.Recursos.Conectado
            dgvCell.ToolTipText = "Aceptado"
        End If
        dgvCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvRow.Cells.Add(dgvCell)

        'Valor de la Columna Eliminar
        If Aceptado = "NO" Then
            dgvCell = New DataGridViewImageCell()
            dgvCell.Value = My.Resources.Recursos.Desconectado
            dgvCell.ToolTipText = "Haga click aquí para rechazar éste movimiento"
        Else
            dgvCell = New DataGridViewTextBoxCell()
            dgvCell.Value = ""
        End If
        dgvCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvRow.Cells.Add(dgvCell)

        If Aceptado = "NO" Then
            dgvRow.DefaultCellStyle.BackColor = Color.LightCoral
            dgvRow.DefaultCellStyle.SelectionBackColor = Color.LightCoral
        Else
            dgvRow.DefaultCellStyle.BackColor = Color.White
            dgvRow.DefaultCellStyle.SelectionBackColor = Color.White
        End If

        dgvRow.DefaultCellStyle.SelectionForeColor = Color.Black
        dgvRow.Height = "30"

        'Inserto la fila
        DG_Notificaciones.Rows.Add(dgvRow)

    End Sub

    Sub CargarPlanilla()
        'Cambio el cursor a "WAIT"
        Me.Cursor = Cursors.WaitCursor

        'Limpio el datagrid
        DG_Notificaciones.Rows.Clear()
        DG_Notificaciones.Refresh()

        'Cargo los movimientos.
        Dim dsMovimientos As New DataSet
        dsMovimientos = NegMovimiento.ObtenerListadoNotificaciones(My.Settings.Sucursal)
        If dsMovimientos IsNot Nothing Then
            If dsMovimientos.Tables(0).Rows.Count > 0 Then
                For Each mov In dsMovimientos.Tables(0).Rows
                    AgregarMovimiento(mov.item("id_Movimiento"), mov.item("id_Tipo"), mov.item("id_Subtipo"), mov.item("id_Sucursal"), mov.item("Sucursal"), mov.item("Fecha"), mov.item("Tipo"), mov.item("Descrip"), mov.item("Monto"), mov.item("Acept"), mov.item("Descripcion"))
                Next
            End If
        End If

        'Ordeno las filas, por fecha descendientemente.
        DG_Notificaciones.ClearSelection()

        'Cambio el cursor a NORMAL.
        Me.Cursor = Cursors.Arrow
    End Sub

    Sub EvaluarPermisos()
        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Sistema_Notificación_AceptarCancelar)) Then
            DG_Notificaciones.Columns("Aceptar").Visible = True
            DG_Notificaciones.Columns("Eliminar").Visible = True
        Else
            DG_Notificaciones.Columns("Aceptar").Visible = False
            DG_Notificaciones.Columns("Eliminar").Visible = False
        End If
    End Sub
#End Region

End Class
