Imports Entidades

Public Class frmSeniaAdministracion

    Private NegComisiones As New Negocio.NegComisiones
    Private NegStock As New Negocio.NegStock
    Private NegSenia As New Negocio.NegSenia
    Private NegClienteMinorista As New Negocio.NegClienteMinorista
    Private NegClienteMayorista As New Negocio.NegClienteMayorista
    Private negDireccion As New Negocio.NegDireccion
    Private NegVentas As New Negocio.NegVentas
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

                    'Agrego el stock del producto en la sucursal.
                    Dim dsVentasDetalle = NegVentas.TraerVentaDetalle(senia.IdVentaSenia)
                    For Each ventaDetalle As DataRow In dsVentasDetalle.Tables(0).Rows
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
                            'Abro el form de datos de facturacion.
                            Dim frmFacturar As frmFacturar = New frmFacturar()
                            frmFacturar.NotaCredito = True
                            frmFacturar.id_Devolucion = Integer.Parse(senia.IdVentaSenia)
                            frmFacturar.Monto = senia.MontoSenia
                            frmFacturar.Descuento = 0
                            frmFacturar.IvaTotal = 0
                            frmFacturar.MontoSinDescuento = 0
                            frmFacturar.TipoPago = TiposPago
                            frmFacturar.TipoCliente = TipoCliente()
                            frmFacturar.ShowDialog()
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

                Btn_BuscarConsumidorFinal.Visible = False
                txtApellido.Visible = False
                lblApellido.Visible = False
                lblNombre.Text = "Razón Social"
                txtNombre.Enabled = False
                txtNombre.Text = ClienteMayorista.RazonSocial
                txtMail.Enabled = False
                txtMail.Text = direccion.Email
                txtDireccion.Enabled = False
                txtDireccion.Text = direccion.Direccion
                txtTelefono.Enabled = False
                txtTelefono.Text = direccion.Telefono
                rblEnvioPromocionesNo.Enabled = False
                rblEnvioPromocionesSi.Enabled = False
            Else
                Dim ClienteMinorista As Entidades.ClienteMinorista = NegClienteMinorista.TraerCliente(SeniaSeleccionada.IdClienteMinorista)
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

                For Each ventaDetalle In dsVentasDetalle.Tables(0).Rows
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
        lblDescuentoMayorista.Text = "$ " & Format(DescuentoDetalle, "###0.00")
        lblSubtotalMayorista.Text = "$ " & Format(SubTotalDetalle, "###0.00")
        lblIVAMayorista.Text = "$ " & Format(SubTotalDetalle * 0.21, "###0.00")
        lblMontoMayorista.Text = "$ " & Format(MontoTotalDetalle, "###0.00")
        lblSeniaMayorista.Text = "$ " & Format(Senia, "###0.00")
        lblImporteSaldarMayorista.Text = "$ " & Format(MontoTotalDetalle - Senia, "###0.00")
    End Sub

    Private Sub AgregarProducto(ventaDetalle As Object)
        Dim precio As Decimal = CType(ventaDetalle.item("Precio").ToString, Decimal)

        If TipoCliente() = TipoCliente.Minorista Then
            AgregarProducto(ventaDetalle, 0, 0, precio)
        Else
            AgregarProducto(ventaDetalle, precio / 1.21, (precio / 1.21) * 0.21, precio)
        End If

    End Sub

    Private Sub AgregarProducto(ventaDetalle As Object, precio As Decimal, iva As Decimal, monto As Decimal)
        'Creo la fila del producto.
        Dim dgvRow As New DataGridViewRow
        Dim dgvCell As DataGridViewCell

        'Valor de la Columna Codigo
        dgvCell = New DataGridViewTextBoxCell()
        dgvCell.Value = ventaDetalle.item("Codigo").ToString
        dgvRow.Cells.Add(dgvCell)

        'Valor de la Columna Nombre
        dgvCell = New DataGridViewTextBoxCell()
        dgvCell.Value = ventaDetalle.item("Nombre").ToString
        dgvRow.Cells.Add(dgvCell)

        'Valor de la Columna Cantidad
        dgvCell = New DataGridViewTextBoxCell()
        dgvCell.Value = ventaDetalle.item("Cantidad").ToString
        dgvRow.Cells.Add(dgvCell)

        'Valor de la Columna Precio
        dgvCell = New DataGridViewTextBoxCell()
        dgvCell.Value = precio
        'dgvCell.Value = Format(0, "###0.00")
        dgvRow.Cells.Add(dgvCell)

        'Valor de la Columna IVA
        dgvCell = New DataGridViewTextBoxCell()
        dgvCell.Value = iva
        'dgvCell.Value = Format(0, "###0.00")
        dgvRow.Cells.Add(dgvCell)

        'Valor de la Columna Monto
        dgvCell = New DataGridViewTextBoxCell()
        dgvCell.Value = monto
        'dgvCell.Value = Format(CType(ventaDetalle.item("Precio").ToString, Decimal), "###0.00")
        dgvRow.Cells.Add(dgvCell)

        'Valor de la Columna Subtotal
        dgvCell = New DataGridViewTextBoxCell()
        dgvCell.Value = monto * ventaDetalle.item("Cantidad").ToString
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