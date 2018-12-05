Imports Entidades
Imports Negocio

Public Class frmSeniaAdministracion

    Private NegComisiones As New NegComisiones
    Private NegStock As New NegStock
    Private NegSenia As New NegSenia
    Private NegClienteMinorista As New NegClienteMinorista
    Private NegClienteMayorista As New NegClienteMayorista
    Private negDireccion As New NegDireccion
    Private NegVentas As New NegVentas
    Private NegFacturacion As New NegFacturacion

    Private Sub frmSeniaAdministracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.WaitCursor
        Try
            dgSenia.AlternatingRowsDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            dgSenia.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            dgSenia.RowHeadersDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            dgSenia.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

            cmbModoEntrega.SelectedIndex = 0

            SeniaBindingSource.DataSource = NegSenia.ConsultarSeniaActivas(My.Settings.Sucursal)

            CargarDetalleSenia()
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha encontrado un error al listar las reservas. Por favor, vuelva a intentar más tarde o contáctese con el Administrador.", "Administración de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgSenia_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgSenia.CellFormatting
        If (dgSenia.Columns(e.ColumnIndex).Name = "Nombre" And SeniaBindingSource.List.Count > e.RowIndex) Then
            Dim senias As Entidades.Senia = dgSenia.Rows(e.RowIndex).DataBoundItem
            If (senias.IdClienteMinorista <> 0) Then
                e.Value = senias.ApellidoNombreClienteMinorista
            Else
                e.Value = senias.RazonSocial
            End If
        End If
    End Sub

    Private Sub BtnFiltrar_Click(sender As Object, e As EventArgs) Handles BtnFiltrar.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim senias As List(Of Entidades.Senia) = NegSenia.ConsultarSeniaActivas(My.Settings.Sucursal)

            If (Not String.IsNullOrWhiteSpace(txtNombreFiltro.Text)) Then
                senias = senias.Where(Function(x) x.ApellidoNombreClienteMinorista.ToUpper().Contains(txtNombreFiltro.Text.ToUpper()) Or x.RazonSocial.ToUpper().Contains(txtNombreFiltro.Text.ToUpper())).ToList()
            End If
            If (cmbModoEntrega.SelectedIndex > 0) Then
                senias = senias.Where(Function(x) x.FormaEntrega = cmbModoEntrega.SelectedItem).ToList()
            End If
            If (cmbModoEntrega.SelectedIndex > 0) Then
                senias = senias.Where(Function(x) x.FormaEntrega = cmbModoEntrega.SelectedItem).ToList()
            End If
            If chkFAlta.Checked Then
                senias = senias.Where(Function(x) x.FechaAlta.Date.CompareTo(dpkAlta.Value.Date) = 0).ToList()
            End If
            If chkFRetiro.Checked Then
                senias = senias.Where(Function(x) x.FechaEstimadaRetiro.Date.CompareTo(dpkRetiro.Value.Date) = 0).ToList()
            End If

            SeniaBindingSource.DataSource = senias
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha encontrado un error al filtrar las reservas. Por favor, vuelva a intentar más tarde o contáctese con el Administrador.", "Administración de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgSenia_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgSenia.DataBindingComplete
        lbl_Msg.Visible = dgSenia.Rows.Count = 0
    End Sub

    Private Sub dgSenia_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgSenia.CellContentClick
        If dgSenia.Columns(e.ColumnIndex).Name = "Eliminar" Then 'Si se hace click en el boton "eliminar" de la fila.
            Dim Result As DialogResult
            Result = MessageBox.Show("¿Está seguro que desea eliminar la reserva?", "Administración de Reservas", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If Result = System.Windows.Forms.DialogResult.Yes Then 'Si acepta eliminar el item
                Try
                    'Cambio el cursor a "WAIT"
                    Me.Cursor = Cursors.WaitCursor

                    'Elimino la senia
                    Dim senia As Entidades.Senia = dgSenia.CurrentRow.DataBoundItem
                    NegSenia.EliminarSenia(senia.Id)

                    'Anulo venta
                    NegVentas.AnularVenta(senia.IdVentaRetiro, "Por eliminacion de reserva")

                    'Agrego el stock del producto en la sucursal.
                    Dim dsVentaSeniaDetalle = NegVentas.TraerVentaDetalle(senia.IdVentaSenia)
                    For Each ventaDetalle As DataRow In dsVentaSeniaDetalle.Tables(0).Rows
                        NegStock.AgregarStock(ventaDetalle("id_Producto"), My.Settings.Sucursal, ventaDetalle("CANTIDAD"))
                    Next

                    'Elimina las comisiones asociadas a la venta
                    NegComisiones.EliminarComisiones(senia.IdVentaSenia)

                    MessageBox.Show("La reserva ha sido eliminada.", "Administración de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Dim dsVentas As DataSet = NegVentas.TraerVenta(senia.IdVentaSenia)
                    Dim TipoFactura As Integer = CType(dsVentas.Tables(0).Rows(0).Item("TipoFactura").ToString, Integer)
                    Dim TiposPago As String = dsVentas.Tables(0).Rows(0).Item("TiposPago").ToString()

                    If (TipoFactura >= 0) Then
                        If (MessageBox.Show("La reserva se encuentra facturada, deseha realizar una nota de credito?.", "Administración de Reservas", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes) Then

                            Dim PorcentajeFacturacion = CType(dsVentas.Tables(0).Rows(0).Item("PorcentajeFacturacion").ToString, Decimal) / 100
                            Dim TipoPago As String = dsVentas.Tables(0).Rows(0).Item("TiposPago").ToString()
                            Dim Total As Double = CType(dsVentas.Tables(0).Rows(0).Item("Precio_Total").ToString, Double)
                            Dim Descuento As Double = CType(dsVentas.Tables(0).Rows(0).Item("Descuento").ToString, Double)
                            Dim CostoFinanciero As Double = CType(dsVentas.Tables(0).Rows(0).Item("CostoFinanciero").ToString, Double)
                            Dim SubTotal As Double = CType(dsVentas.Tables(0).Rows(0).Item("Subtotal").ToString, Double)
                            Dim MontoSenia As Double = CType(dsVentas.Tables(0).Rows(0).Item("MontoSenia").ToString, Double)
                            Dim id_Venta As Int64 = CType(dsVentas.Tables(0).Rows(0).Item("id_Venta").ToString, Int64)
                            Dim id_Cliente As Integer = If(dsVentas.Tables(0).Rows(0).Item("id_Cliente") Is DBNull.Value, 0, CType(dsVentas.Tables(0).Rows(0).Item("id_Cliente").ToString, Integer))
                            Dim Factura As Facturacion = NegFacturacion.TraerFacturacionPorIdVenta(id_Venta)

                            Dim frmNotaCredito As frmNotaCredito = New frmNotaCredito()

                            If (TipoCliente() = Entidades.TipoCliente.Minorista) Then
                                frmNotaCredito.TipoCliente = TipoCliente.Minorista
                                frmNotaCredito.CostoFinanciero = CostoFinanciero
                                frmNotaCredito.SubTotal = MontoSenia
                                frmNotaCredito.Monto = MontoSenia + CostoFinanciero
                                frmNotaCredito.MontoSenia = MontoSenia
                                frmNotaCredito.PorcentajeFacturacion = 1
                            Else

                                Dim MontoSeñaSinIva As Double = MontoSenia / ((0.21 * PorcentajeFacturacion) + 1)
                                Dim CostoFinancieroSinIva As Double = CostoFinanciero / ((0.21 * PorcentajeFacturacion) + 1)

                                frmNotaCredito.TipoCliente = TipoCliente.Mayorista
                                frmNotaCredito.CostoFinanciero = Math.Round(CostoFinancieroSinIva, 2)
                                frmNotaCredito.SubTotal = Math.Round((MontoSeñaSinIva + CostoFinancieroSinIva) * PorcentajeFacturacion, 2)
                                frmNotaCredito.IvaTotal = Math.Round(frmNotaCredito.SubTotal * 0.21, 2)
                                frmNotaCredito.Monto = Math.Round(frmNotaCredito.SubTotal + frmNotaCredito.IvaTotal, 2)
                                frmNotaCredito.MontoSenia = Math.Round(MontoSeñaSinIva * PorcentajeFacturacion * 1.21, 2)
                                frmNotaCredito.PorcentajeFacturacion = PorcentajeFacturacion
                            End If

                            frmNotaCredito.TipoPago = TipoPago
                            frmNotaCredito.id_Cliente = id_Cliente
                            frmNotaCredito.EsSenia = True
                            frmNotaCredito.NumeroFactura = Factura?.NumeroFactura

                            For Each prod In dsVentaSeniaDetalle.Tables(0).Rows
                                Dim Detalle As Devolucion_Detalle = New Devolucion_Detalle()
                                Detalle.Nombre = prod.Item("Nombre").ToString()
                                Detalle.Cantidad = prod.Item("Cantidad").ToString()
                                Detalle.Precio = prod.Item("Precio").ToString()
                                Detalle.Iva = prod.Item("Iva").ToString()
                                Detalle.Monto = prod.Item("Monto").ToString()
                                frmNotaCredito.DevolucionDetalle.Add(Detalle)
                            Next

                            frmNotaCredito.ShowDialog()

                            Dim NegNotaCredito As NegNotaCredito = New NegNotaCredito()

                            For Each notaCredito As NotaCredito In frmNotaCredito.NotasCreditos
                                notaCredito.id_Factura = Factura?.id_Facturacion
                                NegNotaCredito.NuevaNotaCredito(notaCredito)
                            Next
                        End If
                    End If

                    dgSenia.Rows.Remove(dgSenia.CurrentRow)

                    'Cambio el cursor a NORMAL.
                    Me.Cursor = Cursors.Arrow

                Catch ex As Exception
                    Me.Cursor = Cursors.Arrow
                    MessageBox.Show("Se ha producido un error al eliminar el reserva. Por favor, vuelva a intentar más tarde o contáctese con el Administrador.", "Administración de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        ElseIf dgSenia.Columns(e.ColumnIndex).Name = "Imprimir" Then
            'Cambio el cursor a "WAIT".
            Me.Cursor = Cursors.WaitCursor

            Dim senias As Entidades.Senia = dgSenia.CurrentRow.DataBoundItem

            Dim frmReporteResumenReserva As frmReporteResumenReserva = New frmReporteResumenReserva()
            frmReporteResumenReserva.idReserva = senias.IdVentaSenia
            frmReporteResumenReserva.MontoSenia = senias.MontoSenia
            frmReporteResumenReserva.MdiParent = Me.MdiParent
            frmReporteResumenReserva.Show()
            Me.Cursor = Cursors.Arrow
        Else
            CargarDetalleSenia()
        End If
    End Sub

    Private Sub dgSenia_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgSenia.CellDoubleClick
        CargarDetalleSenia()
        'hago foco en el tab_modificacion 
        tabAdministracionReservas.SelectedTab = tabDetalle
    End Sub

    Private Sub CargarDetalleSenia()
        Me.Cursor = Cursors.WaitCursor

        LimpiarDetalleSenia()

        If (dgSenia.CurrentRow Is Nothing) Then
            tabDetalle.Enabled = False
            Return
        End If

        tabDetalle.Enabled = True

        Dim SeniaSeleccionada As Entidades.Senia = dgSenia.CurrentRow.DataBoundItem
        ddlEntrega.SelectedItem = SeniaSeleccionada.FormaEntrega
        txtObservaciones.Text = SeniaSeleccionada.Observaciones
        lblFechaSeña.Text = SeniaSeleccionada.FechaAlta
        Try
            If (TipoCliente() = TipoCliente.Mayorista) Then

                Dim ClienteMayorista As Entidades.ClienteMayorista = NegClienteMayorista.TraerCliente(SeniaSeleccionada.IdClienteMayorista)
                Dim direccion As Direccion = negDireccion.Consulta(ClienteMayorista.IdDireccionFacturacion)

                txtApellido.Visible = False
                lblApellido.Visible = False
                lblNombre.Text = "Razón Social"
                txtNombre.Text = ClienteMayorista.RazonSocial
                txtMail.Text = direccion.Email
                txtDireccion.Text = direccion.Direccion
                txtTelefono.Text = direccion.Telefono
            Else
                Dim ClienteMinorista As Entidades.ClienteMinorista = NegClienteMinorista.TraerCliente(SeniaSeleccionada.IdClienteMinorista)
                txtApellido.Visible = True
                lblApellido.Visible = True
                txtApellido.Text = ClienteMinorista.Apellido
                txtNombre.Text = ClienteMinorista.Nombre
                txtMail.Text = ClienteMinorista.Email
                txtDireccion.Text = ClienteMinorista.Direccion
                txtTelefono.Text = ClienteMinorista.Telefono
                rblEnvioPromocionesNo.Checked = Not ClienteMinorista.EnviarNovedades
                rblEnvioPromocionesSi.Checked = ClienteMinorista.EnviarNovedades

                DG_Productos.Columns("IVA").Visible = False
                DG_Productos.Columns("PRECIO").Visible = False
            End If

            Dim dsVentas As DataSet = NegVentas.TraerVenta(SeniaSeleccionada.IdVentaSenia)

            'Cargo los labels de la venta.
            If dsVentas.Tables(0).Rows.Count <> 0 Then
                lblCantidad.Text = dsVentas.Tables(0).Rows(0).Item("Cantidad_Total").ToString
                lblTipoVenta.Text = dsVentas.Tables(0).Rows(0).Item("TiposVenta").ToString
                lblPago.Text = dsVentas.Tables(0).Rows(0).Item("TiposPago").ToString
                lblPorcentajeFacturacion.Text = dsVentas.Tables(0).Rows(0).Item("PorcentajeFacturacion").ToString

                Dim MontoTotalDetalle As Decimal = CType(dsVentas.Tables(0).Rows(0).Item("Precio_Total").ToString, Decimal)
                Dim DescuentoDetalle As Decimal = CType(dsVentas.Tables(0).Rows(0).Item("Descuento").ToString, Decimal)
                Dim SubTotalDetalle As Decimal = CType(dsVentas.Tables(0).Rows(0).Item("Subtotal").ToString, Decimal)

                CargarTotales(MontoTotalDetalle, DescuentoDetalle, SubTotalDetalle)

                If dsVentas.Tables(0).Rows(0).Item("Empleado").ToString <> "" Then
                    lblVendedor.Text = dsVentas.Tables(0).Rows(0).Item("Empleado").ToString
                Else
                    lblVendedor.Text = "- - - - - "
                End If

                If dsVentas.Tables(0).Rows(0).Item("Encargado").ToString <> "" Then
                    lblEncargado.Text = dsVentas.Tables(0).Rows(0).Item("Encargado").ToString
                Else
                    lblEncargado.Text = "- - - - - "
                End If

                Dim TipoFactura As Integer = Integer.Parse(dsVentas.Tables(0).Rows(0).Item("TipoFactura").ToString)

                If TipoFactura >= 0 Then
                    lblFacturado.Text = [Enum].GetName(GetType(Entidades.TipoFactura), TipoFactura)
                Else
                    lblFacturado.Text = "NO"
                End If


                'Detalle de la venta.
                Dim dsVentasDetalle As DataSet = NegVentas.TraerVentaDetalle(SeniaSeleccionada.IdVentaSenia)

                For Each ventaDetalle As DataRow In dsVentasDetalle.Tables(0).Rows
                    AgregarProducto(ventaDetalle)
                Next

                lblCantidad.Text = dsVentasDetalle.Tables(0).Rows.Count

            End If
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha producido un error al eliminar el reserva. Por favor, vuelva a intentar más tarde o contáctese con el Administrador.", "Administración de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LimpiarDetalleSenia()
        txtApellido.Text = String.Empty
        txtNombre.Text = String.Empty
        txtMail.Text = String.Empty
        txtDireccion.Text = String.Empty
        txtTelefono.Text = String.Empty
        rblEnvioPromocionesNo.Checked = True
        rblEnvioPromocionesSi.Checked = False
        lblCantidad.Text = "- - - - - "
        lblTipoVenta.Text = "- - - - - "
        lblPago.Text = "- - - - - "
        lblVendedor.Text = "- - - - - "
        lblEncargado.Text = "- - - - - "
        lblFacturado.Text = "- - - - - "
        DG_Productos.Rows.Clear()
    End Sub

    Private Sub CargarTotales(MontoTotalDetalle As Double, DescuentoDetalle As Double, SubTotalDetalle As Double)
        Dim SeniaSeleccionada = dgSenia.CurrentRow.DataBoundItem

        If TipoCliente() = TipoCliente.Minorista Then
            CargarTotalesMinorista(MontoTotalDetalle, DescuentoDetalle, SubTotalDetalle, SeniaSeleccionada.MontoSenia)
            PanelTotalMayorista.Visible = False
            PanelTotalMinorista.Visible = True
        Else
            CargarTotalesMayorista(MontoTotalDetalle, DescuentoDetalle, SubTotalDetalle, SeniaSeleccionada.MontoSenia)
            PanelTotalMayorista.Visible = True
            PanelTotalMinorista.Visible = False
            PanelTotalMayorista.Location = PanelTotalMinorista.Location
        End If
    End Sub

    Private Sub CargarTotalesMinorista(MontoTotalDetalle As Double, DescuentoDetalle As Double, SubTotalDetalle As Double, Senia As Double)
        lblMontoMinorista.Text = "$ " & Format(MontoTotalDetalle, "###0.00")
        lblDescuentoMinorista.Text = "$ " & Format(DescuentoDetalle, "###0.00")
        lblSubtotalMinorista.Text = "$ " & Format(SubTotalDetalle, "###0.00")
        lblSeniaMinorista.Text = "$ " & Format(Senia, "###0.00")
        lblImporteSaldarMinorista.Text = "$ " & Format(MontoTotalDetalle - Senia, "###0.00")
    End Sub

    Private Sub CargarTotalesMayorista(MontoTotalDetalle As Double, DescuentoDetalle As Double, SubTotalDetalle As Double, Senia As Double)
        Dim PorcentajeFacturacion As Double = Double.Parse(lblPorcentajeFacturacion.Text) / 100
        lblDescuentoMayorista.Text = "$ " & Format(DescuentoDetalle, "###0.00")
        lblSubtotalMayorista.Text = "$ " & Format(SubTotalDetalle, "###0.00")
        lblIVAMayorista.Text = "$ " & Format(SubTotalDetalle * 0.21 * PorcentajeFacturacion, "###0.00")
        lblMontoMayorista.Text = "$ " & Format(MontoTotalDetalle, "###0.00")
        lblSeniaMayorista.Text = "$ " & Format(Senia, "###0.00")
        lblImporteSaldarMayorista.Text = "$ " & Format(MontoTotalDetalle - Senia, "###0.00")
    End Sub

    Private Sub AgregarProducto(ventaDetalle As DataRow)
        'Creo la fila del producto.
        Dim dgvRow As New DataGridViewRow
        Dim dgvCell As DataGridViewCell

        'Valor de la Columna Codigo
        dgvCell = New DataGridViewTextBoxCell()
        dgvCell.Value = ventaDetalle.Item("Codigo").ToString
        dgvRow.Cells.Add(dgvCell)

        'Valor de la Columna Nombre
        dgvCell = New DataGridViewTextBoxCell()
        dgvCell.Value = ventaDetalle.Item("Nombre").ToString
        dgvRow.Cells.Add(dgvCell)

        'Valor de la Columna Cantidad
        dgvCell = New DataGridViewTextBoxCell()
        dgvCell.Value = ventaDetalle.Item("Cantidad").ToString
        dgvRow.Cells.Add(dgvCell)

        'Valor de la Columna Precio
        dgvCell = New DataGridViewTextBoxCell()
        dgvCell.Value = ventaDetalle.Item("Precio").ToString
        'dgvCell.Value = Format(0, "###0.00")
        dgvRow.Cells.Add(dgvCell)

        'Valor de la Columna IVA
        dgvCell = New DataGridViewTextBoxCell()
        dgvCell.Value = ventaDetalle.Item("Iva").ToString
        'dgvCell.Value = Format(0, "###0.00")
        dgvRow.Cells.Add(dgvCell)

        'Valor de la Columna Monto
        dgvCell = New DataGridViewTextBoxCell()
        dgvCell.Value = ventaDetalle.Item("Monto").ToString
        'dgvCell.Value = Format(CType(ventaDetalle.item("Precio").ToString, Decimal), "###0.00")
        dgvRow.Cells.Add(dgvCell)

        'Valor de la Columna Subtotal
        dgvCell = New DataGridViewTextBoxCell()
        dgvCell.Value = ventaDetalle.Item("Monto") * ventaDetalle.Item("Cantidad")
        dgvRow.Cells.Add(dgvCell)

        dgvRow.Height = "20"

        'Inserto la fila
        DG_Productos.Rows.Add(dgvRow)
    End Sub


    Private Function TipoCliente() As TipoCliente
        Dim SeniaSeleccionada = dgSenia.CurrentRow.DataBoundItem

        If (SeniaSeleccionada.IdClienteMinorista > 0) Then
            Return TipoCliente.Minorista
        Else
            Return TipoCliente.Mayorista
        End If
    End Function

    Private Sub Btn_Finalizar_Click(sender As Object, e As EventArgs) Handles Btn_Finalizar.Click
        Dim frmVentas As frmVentas = New frmVentas()
        Dim SeniaSeleccionada = dgSenia.CurrentRow.DataBoundItem

        frmVentas.Senia = SeniaSeleccionada
        frmVentas.MdiParent = Me.MdiParent
        frmVentas.Show()
    End Sub

    Private Sub tabAdministracionReservas_Selected(sender As Object, e As TabControlEventArgs) Handles tabAdministracionReservas.Selected
        If tabAdministracionReservas.SelectedIndex = 1 AndAlso dgSenia.CurrentRow Is Nothing Then
            MessageBox.Show("Debe seleccionar previamente una recerva.", "Administración de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            tabAdministracionReservas.SelectedIndex = 0
        End If
    End Sub
End Class