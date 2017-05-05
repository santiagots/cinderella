Imports Entidades
Imports Negocio

Public Class frmPresupuestoAdministracion

    Dim NegPresupuesto As NegPresupuesto = New NegPresupuesto()
    Dim NegErrores As NegManejadorErrores = New NegManejadorErrores()

    Private Sub PresupuestoAdministracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgPresupuesto.AlternatingRowsDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        dgPresupuesto.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        dgPresupuesto.RowHeadersDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        dgPresupuesto.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        'Seteo fechas.
        FDesde.Value = Now.Date.AddDays(-30)
        FHasta.Value = Now.Date

        BuscarPresupuesto()
        EvaluarPermisos()
    End Sub

    Private Sub dgPresupuesto_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgPresupuesto.DataBindingComplete
        lbl_Msg.Visible = dgPresupuesto.RowCount = 0
    End Sub

    Private Sub BtnFiltrar_Click(sender As Object, e As EventArgs) Handles BtnFiltrar.Click
        BuscarPresupuesto()
    End Sub

    Private Sub dgPresupuesto_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgPresupuesto.CellDoubleClick
        CargarDetallePresupuesto()
        'hago foco en el tab_modificacion 
        TabAdministracionPresupuesto.SelectedTab = TabDetalle
    End Sub

    Private Sub CargarDetallePresupuesto()
        Me.Cursor = Cursors.WaitCursor

        If (dgPresupuesto.CurrentRow Is Nothing) Then
            TabDetalle.Enabled = False
            Return
        End If

        TabDetalle.Enabled = True

        Dim presupuestoSeleccionado As Presupuesto = dgPresupuesto.CurrentRow.DataBoundItem

        Try
            Dim detallePresupuestoSeleccionado As List(Of Presupuesto_Detalle) = NegPresupuesto.TraerDetalle(presupuestoSeleccionado.id_Presupuesto)
            PresupuestoDetalleBindingSource.DataSource = NegPresupuesto.TraerDetalle(presupuestoSeleccionado.id_Presupuesto)

            lblSucursal.Text = presupuestoSeleccionado.NombreSucursal
            lblFecha.Text = presupuestoSeleccionado.Fecha
            lblVenta.Text = If(presupuestoSeleccionado.id_TipoVenta = 1, "Minorista", "Mayorista")
            lblVendedor.Text = presupuestoSeleccionado.VendedorNombreyApellido
            lblCliente.Text = presupuestoSeleccionado.RazonSocialClienteMayorista
            lblEncargado.Text = presupuestoSeleccionado.EncargadoNombreyApellido
            lblPago.Text = presupuestoSeleccionado.DescripcionTipoPago
            lblCantidad.Text = detallePresupuestoSeleccionado.Count
            lblDescuento.Text = "$ " & Format(presupuestoSeleccionado.Descuento, "###0.00")
            lblCostoFinanciero.Text = "$ " & Format(presupuestoSeleccionado.CostoFinanciero, "###0.00")
            lblSubtotal.Text = "$ " & Format(presupuestoSeleccionado.SubTotal, "###0.00")
            lblMonto.Text = "$ " & Format(presupuestoSeleccionado.Total, "###0.00")

            If (presupuestoSeleccionado.Anulado) Then
                lblAnulado.Visible = True
                txtDescripcionAnular.Text = presupuestoSeleccionado.DescripcionAnulado
                lblAnulado.Text = "PRESUPUESTO ANULADO EL " & String.Format("{0:d}", presupuestoSeleccionado.FechaAnulado)
                BtnAnular.Enabled = False
            Else
                lblAnulado.Visible = False
                BtnAnular.Enabled = True
            End If

            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha producido un al cargar el detalle del presupuesto. Por favor, vuelva a intentar más tarde o contáctese con el Administrador.", "Administración de Presupuestos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BuscarPresupuesto()
        'Cambio el cursor a "WAIT"
        Me.Cursor = Cursors.WaitCursor

        Try
            'recupero los presupuesto de la base para la sucursal correspondinte
            Dim presupuesto As List(Of Presupuesto) = NegPresupuesto.TraerPresupuestos(My.Settings("Sucursal"))

            If Not String.IsNullOrEmpty(txtPresupuestoDesde.Text) Then
                presupuesto = presupuesto.Where(Function(x) x.id_Presupuesto >= Integer.Parse(txtPresupuestoDesde.Text)).ToList()
            End If

            If Not String.IsNullOrEmpty(txtPresupuestoHasta.Text) Then
                presupuesto = presupuesto.Where(Function(x) x.id_Presupuesto <= Integer.Parse(txtPresupuestoHasta.Text)).ToList()
            End If

            If Not String.IsNullOrEmpty(txtMontoDesde.Text) Then
                presupuesto = presupuesto.Where(Function(x) x.Total >= Double.Parse(txtMontoDesde.Text)).ToList().ToList()
            End If

            If Not String.IsNullOrEmpty(txtMontoHasta.Text) Then
                presupuesto = presupuesto.Where(Function(x) x.Total <= Double.Parse(txtMontoHasta.Text)).ToList().ToList()
            End If

            If Not String.IsNullOrEmpty(txtCliente.Text) Then
                presupuesto = presupuesto.Where(Function(x) txtCliente.Text.Contains(x.RazonSocialClienteMayorista)).ToList().ToList()
            End If

            presupuesto = presupuesto.Where(Function(x) FDesde.Value.Date <= x.Fecha.Date AndAlso x.Fecha.Date <= FHasta.Value.Date).ToList().ToList()

            PresupuestoBindingSource.DataSource = presupuesto

        Catch ex As Exception
            'Cambio el cursor a NORMAL.
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha encontrado un error al buscar los presupuestos. Por favor, vuelva a intentar más tarde o contáctese con el Administrador ", "Administración de Presupuestos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'Cambio el cursor a NORMAL.
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub SoloNumeros_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPresupuestoDesde.KeyPress, txtPresupuestoHasta.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub SoloMoneda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMontoHasta.KeyPress, txtMontoDesde.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloCurrency(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub dgPresupuesto_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgPresupuesto.CellFormatting
        If (dgPresupuesto.Columns(e.ColumnIndex).Name = "AnuladoDataGridViewTextBoxColumn" And PresupuestoBindingSource.List.Count > e.RowIndex) Then
            Dim presupuesto As Presupuesto = dgPresupuesto.Rows(e.RowIndex).DataBoundItem
            If (presupuesto.Anulado) Then
                e.Value = "Si"
            Else
                e.Value = "No"
            End If
        End If
    End Sub

    Private Sub dgPresupuestoDetalle_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgPresupuestoDetalle.CellFormatting
        If (dgPresupuestoDetalle.Columns(e.ColumnIndex).Name = "Numero" And PresupuestoDetalleBindingSource.List.Count > e.RowIndex) Then
            e.Value = e.RowIndex + 1
        End If
        If (dgPresupuestoDetalle.Columns(e.ColumnIndex).Name = "Subtotal" And PresupuestoDetalleBindingSource.List.Count > e.RowIndex) Then
            Dim presupuestoDetalle As Presupuesto_Detalle = dgPresupuestoDetalle.Rows(e.RowIndex).DataBoundItem
            e.Value = presupuestoDetalle.Cantidad * presupuestoDetalle.Monto
        End If
    End Sub

    Private Sub dgPresupuesto_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgPresupuesto.CellContentClick
        If dgPresupuesto.Columns(e.ColumnIndex).Name = "Imprimir" Then 'Si se hace click en el boton "eliminar" de la fila.
            Me.Cursor = Cursors.WaitCursor
            Dim frmReportePresupuesto As frmReportePresupuesto = New frmReportePresupuesto()
            frmReportePresupuesto.presupuesto = dgPresupuesto.CurrentRow.DataBoundItem
            frmReportePresupuesto.ShowDialog()
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub TabAdministracionPresupuesto_Selected(sender As Object, e As TabControlEventArgs) Handles TabAdministracionPresupuesto.Selected
        If TabAdministracionPresupuesto.SelectedIndex = 1 AndAlso dgPresupuesto.CurrentRow Is Nothing Then
            MessageBox.Show("Debe seleccionar previamente una presupuestos.", "Administración de Presupuestos", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            TabAdministracionPresupuesto.SelectedIndex = 0
        Else
            CargarDetallePresupuesto()
        End If
    End Sub

    Private Sub BtnAnular_Click(sender As Object, e As EventArgs) Handles BtnAnular.Click
        If MessageBox.Show("¿Está seguro que desea anular el presupuesto?", "Administración de Presupuestos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then 'Si acepta anular la venta
            Me.Cursor = Cursors.WaitCursor

            Dim presupuesto As Presupuesto = dgPresupuesto.CurrentRow.DataBoundItem
            presupuesto.DescripcionAnulado = txtDescripcionAnular.Text
            presupuesto.Anulado = True
            presupuesto.FechaAnulado = DateTime.Now
            Try
                NegPresupuesto.Anula(presupuesto)
                lblAnulado.Text = "PRESUPUESTO ANULADO EL " & String.Format("{0:d}", DateTime.Now)
            Catch ex As Exception
                presupuesto.DescripcionAnulado = String.Empty
                presupuesto.Anulado = False
                presupuesto.FechaAnulado = Nothing
                MessageBox.Show("Se ha encontrado un error al anular el presupuesto. Por favor, contactese con el administrador.", "Administración de Presupuestos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Sub EvaluarPermisos()
        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Presupuesto_Administración_Visualizar)) Then

        Else
            TabAdministracionPresupuesto.TabPages.Remove(TabDetalle)
            RemoveHandler dgPresupuesto.CellDoubleClick, AddressOf dgPresupuesto_CellDoubleClick
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Presupuesto_Administración_Detalle_Anular)) Then
            BtnAnular.Visible = True
        Else
            BtnAnular.Visible = False
        End If
    End Sub
End Class