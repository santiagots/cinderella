Imports Entidades
Imports Negocio

Public Class frmClienteMayoristaCuentaCorriente

    Private SaldoActual As Decimal

    Private Sub Btn_BuscarCliente_Click(sender As Object, e As EventArgs) Handles Btn_BuscarCliente.Click
        Me.Cursor = Cursors.WaitCursor
        Dim frmBuscarClienteMayorista As frmBuscarClienteMayorista = New frmBuscarClienteMayorista()
        frmBuscarClienteMayorista.ShowDialog()


        If frmBuscarClienteMayorista.clienteMayorista IsNot Nothing Then
            txt_id_Cliente.Clear()
            txt_Nombre.Clear()
            txt_id_Cliente.Text = frmBuscarClienteMayorista.clienteMayorista.Id
            txt_Nombre.Text = frmBuscarClienteMayorista.clienteMayorista.Nombre
            txt_RazonSocial.Text = frmBuscarClienteMayorista.clienteMayorista.RazonSocial

            LimpiarFiltros()

            Dim negCuentaCorrienteClientesMayoristas As NegCuentaCorrienteClientesMayoristas = New NegCuentaCorrienteClientesMayoristas()
            Dim movimientos As List(Of MovimientoCuentaCorrienteClienteMayorista) = negCuentaCorrienteClientesMayoristas.Movimientos(frmBuscarClienteMayorista.clienteMayorista.Id)
            MovimientoCuentaCorrienteClienteMayoristaBindingSource.DataSource = movimientos
            SaldoActual = If(movimientos.Count > 0, movimientos.Last().Saldo, 0)
            txt_SaldoActual.Text = SaldoActual.ToString("C2")
        End If
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub DGMovimientos_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DGMovimientos.DataBindingComplete
        lbl_Msg.Visible = DGMovimientos.Rows.Count = 0
    End Sub

    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
        Buscar(Integer.Parse(txt_id_Cliente.Text))
    End Sub

    Private Sub Buscar(id_cliente As Integer)
        Me.Cursor = Cursors.WaitCursor
        Dim negCuentaCorrienteClientesMayoristas As NegCuentaCorrienteClientesMayoristas = New NegCuentaCorrienteClientesMayoristas()
        Dim movimientos As List(Of MovimientoCuentaCorrienteClienteMayorista) = negCuentaCorrienteClientesMayoristas.Movimientos(id_cliente)

        If (chkFechaVencimiento.Checked) Then
            movimientos = movimientos.Where(Function(x) dtFechaVencimientoDesde.Value.Date <= x.Fecha.Date AndAlso dtFechaVencimientoHasta.Value.Date >= x.Fecha.Date).ToList()
        End If

        If (Not String.IsNullOrEmpty(txtImporteDesde.Text)) Then
            movimientos = movimientos.Where(Function(x) Decimal.Parse(txtImporteDesde.Text) <= x.Monto).ToList()
        End If

        If (Not String.IsNullOrEmpty(txtImporteHasta.Text)) Then
            movimientos = movimientos.Where(Function(x) Decimal.Parse(txtImporteHasta.Text) >= x.Monto).ToList()
        End If

        If (Not String.IsNullOrEmpty(txtComprobante.Text)) Then
            movimientos = movimientos.Where(Function(x) Integer.Parse(txtComprobante.Text) = x.Comprobante).ToList()
        End If

        If (Not String.IsNullOrEmpty(txtPago.Text)) Then
            movimientos = movimientos.Where(Function(x) x.Pago.Contains(txtPago.Text)).ToList()
        End If

        If (ddlTipo.SelectedValue > 0) Then
            movimientos = movimientos.Where(Function(x) x.Id_TipoMovimiento = ddlTipo.SelectedValue).ToList()
        End If

        MovimientoCuentaCorrienteClienteMayoristaBindingSource.DataSource = movimientos
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub frmClienteMayoristaCuentaCorriente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim NegTipoMovimientoCuentaCorriente As NegCuentaCorrienteTipoMovimiento = New NegCuentaCorrienteTipoMovimiento()

        ddlTipo.DataSource = NegTipoMovimientoCuentaCorriente.Listado()
        ddlTipo.DisplayMember = "Value"
        ddlTipo.ValueMember = "Key"

        ddlEmpresa.SelectedIndex = 0
    End Sub

    Private Sub DGMovimientos_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DGMovimientos.CellFormatting
        If (DGMovimientos.Columns(e.ColumnIndex).Name = "ComprobanteDataGridViewTextBoxColumn" And MovimientoCuentaCorrienteClienteMayoristaBindingSource.List.Count > e.RowIndex) Then
            Dim movimiento As MovimientoCuentaCorrienteClienteMayorista = DGMovimientos.Rows(e.RowIndex).DataBoundItem
            If (movimiento.Comprobante = 0) Then
                e.Value = ""
            End If
        End If
        If (DGMovimientos.Columns(e.ColumnIndex).Name = "PuntoVentaDataGridViewTextBoxColumn" And MovimientoCuentaCorrienteClienteMayoristaBindingSource.List.Count > e.RowIndex) Then
            Dim movimiento As MovimientoCuentaCorrienteClienteMayorista = DGMovimientos.Rows(e.RowIndex).DataBoundItem
            If (movimiento.PuntoVenta = 0) Then
                e.Value = ""
            End If
        End If
    End Sub

    Private Sub btn_Restablecer_Click(sender As Object, e As EventArgs) Handles btn_Restablecer.Click
        LimpiarFiltros()
        Buscar(Integer.Parse(txt_id_Cliente.Text))
    End Sub

    Private Sub validarMoneda(sender As Object, e As KeyPressEventArgs) Handles txtImporteDesde.KeyPress, txtImporteHasta.KeyPress
        If e.KeyChar.ToString() = "." Then
            e.KeyChar = CChar(",")
        End If
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        Dim NegErrores As NegManejadorErrores = New NegManejadorErrores()
        KeyAscii = CShort(NegErrores.SoloCurrency(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub validarNumero(sender As Object, e As KeyPressEventArgs) Handles txtComprobante.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        Dim NegErrores As NegManejadorErrores = New NegManejadorErrores()
        KeyAscii = CShort(NegErrores.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub LimpiarFiltros()
        chkFechaVencimiento.Checked = False
        dtFechaVencimientoDesde.Value = DateTime.Now
        dtFechaVencimientoHasta.Value = DateTime.Now
        txtImporteDesde.Clear()
        txtImporteHasta.Clear()
        txtComprobante.Clear()
        txtPago.Clear()
        ddlTipo.SelectedIndex = 0
        SaldoActual = 0
    End Sub

    Private Sub btn_Imprimir_Click(sender As Object, e As EventArgs) Handles btn_Imprimir.Click
        Dim reporte = New frmReporteCuentaCorrienteClienteMayorista()
        reporte.Id_Cliente = Integer.Parse(txt_id_Cliente.Text)
        reporte.Nombre = txt_Nombre.Text
        reporte.RazonSocial = txt_RazonSocial.Text
        reporte.Movimientos = MovimientoCuentaCorrienteClienteMayoristaBindingSource.List
        reporte.FiltroFecha = chkFechaVencimiento.Checked
        reporte.FechaDesde = dtFechaVencimientoDesde.Value
        reporte.FechaHasta = dtFechaVencimientoHasta.Value
        reporte.Saldo = SaldoActual

        reporte.ShowDialog()
    End Sub

    Private Sub Btn_Agregar_Click(sender As Object, e As EventArgs) Handles Btn_Agregar.Click
        If (String.IsNullOrEmpty(txt_id_Cliente.Text)) Then
            MessageBox.Show("No se encuentra seleccionado una cuenta corriente. Por favor, seleccione una cuenta corriente para realizar un pago. ", "Administración de Cuenta Corriente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim frmClienteMayoristaCuentaCorrientePago As frmClienteMayoristaCuentaCorrientePago = New frmClienteMayoristaCuentaCorrientePago()
        frmClienteMayoristaCuentaCorrientePago.Id_Cliente = txt_id_Cliente.Text
        frmClienteMayoristaCuentaCorrientePago.NombreCliente = txt_Nombre.Text
        frmClienteMayoristaCuentaCorrientePago.RazonSocialCliente = txt_RazonSocial.Text
        frmClienteMayoristaCuentaCorrientePago.MdiParent = Me.MdiParent
        frmClienteMayoristaCuentaCorrientePago.Show()
    End Sub
End Class