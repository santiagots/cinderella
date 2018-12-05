Imports Entidades
Imports Negocio

Public Class frmFacturaAdministracion

    Dim NegFacturacion As New Negocio.NegFacturacion

    Dim NegVentas As New Negocio.NegVentas
    Dim NegStock As New Negocio.NegStock
    Dim NegComisiones As New Negocio.NegComisiones
    Dim NegSenia As New Negocio.NegSenia
    Dim id_Sucursal As String
    Dim eVentas As New Entidades.Ventas
    Dim Funciones As New Funciones
    Dim NegErrores As New Negocio.NegManejadorErrores

    Dim id_VentaDetalle As Int64 = 0
    Dim MontoTotalDetalle As Double = 0
    Dim DescuentoDetalle As Double = 0
    Dim SubTotalDetalle As Double = 0
    Dim MontoSenia As Double = 0
    Dim porcentajeFacturacion As Double = 0
    Dim VentaSeniada As Boolean
    Dim TipoPagoDetalle As String = String.Empty
    Dim id_Cliente As Integer

    Private Sub frmFacturaAdministracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'seteo el font a 8px
        DG_facturas.AlternatingRowsDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DG_facturas.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DG_facturas.RowHeadersDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DG_facturas.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))


        FDesde.Value = Now.Date.AddDays(-30)
        FHasta.Value = Now.Date.AddDays(1)

        FacturacionBindingSource.DataSource = NegFacturacion.ObtenerListado(My.Settings.Sucursal, FDesde.Value.ToString("yyyy/MM/dd"), FHasta.Value.ToString("yyyy/MM/dd"))

    End Sub

    Private Sub DataGridView1_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DG_facturas.DataBindingComplete
        lbl_Msg.Visible = DG_facturas.Rows.Count = 0
    End Sub

    Private Sub TabAdministracionFacturas_Selected(ByVal sender As Object, ByVal e As System.Windows.Forms.TabControlEventArgs) Handles TabAdministracionFacturas.Selected
        'Cambio el cursor a "WAIT"
        Me.Cursor = Cursors.WaitCursor

        If TabAdministracionFacturas.SelectedIndex = 0 Then
            BuscarFacturas()
        End If

        'Cambio el cursor a NORMAL.
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub BtnFiltrar_Click(sender As Object, e As EventArgs) Handles BtnFiltrar.Click
        'Cambio el cursor a "WAIT"
        Me.Cursor = Cursors.WaitCursor

        BuscarFacturas()

        'Cambio el cursor a NORMAL.
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub BuscarFacturas()
        'Cargo el datagrid
        Dim facturas As New List(Of Entidades.Facturacion)
        facturas = NegFacturacion.ObtenerListado(My.Settings.Sucursal, FDesde.Value.ToString("yyyy/MM/dd"), FHasta.Value.ToString("yyyy/MM/dd"))

        Dim facturasTicket As New List(Of Entidades.Facturacion)
        If ChkMarcaTicket.Checked Then
            facturasTicket = facturas.Where(Function(x) x.TipoRecibo = Entidades.TipoFactura.Ticket).ToList()
        End If

        Dim facturasElectronica As New List(Of Entidades.Facturacion)
        If ChkMarcaElectronica.Checked Then
            facturasElectronica = facturas.Where(Function(x) x.TipoRecibo = Entidades.TipoFactura.Electronica).ToList()
        End If

        Dim facturasManual As New List(Of Entidades.Facturacion)
        If ChkMarcaManual.Checked Then
            facturasManual = facturas.Where(Function(x) x.TipoRecibo = Entidades.TipoFactura.Manual).ToList()
        End If

        If ChkMarcaTicket.Checked Or ChkMarcaElectronica.Checked Or ChkMarcaManual.Checked Then
            facturas.Clear()
            facturas.AddRange(facturasTicket)
            facturas.AddRange(facturasElectronica)
            facturas.AddRange(facturasManual)
        End If

        If Not String.IsNullOrEmpty(txtFacturaNro.Text) Then
            facturas = facturas.Where(Function(x) x.NumeroFactura = txtFacturaNro.Text).ToList()
        End If

        If Not String.IsNullOrEmpty(txtMontoDesde.Text) Then
            facturas = facturas.Where(Function(x) x.Monto >= CType(txtMontoDesde.Text, Double)).ToList()
        End If

        If Not String.IsNullOrEmpty(txtMontoHasta.Text) Then
            facturas = facturas.Where(Function(x) x.Monto <= CType(txtMontoHasta.Text, Double)).ToList()
        End If

        If Not String.IsNullOrEmpty(txtNombre.Text) Then
            facturas = facturas.Where(Function(x) x.Nombre.Contains(txtNombre.Text)).ToList()
        End If

        If Not String.IsNullOrEmpty(txtCUIT.Text) Then
            facturas = facturas.Where(Function(x) x.Cuit.Contains(txtCUIT.Text)).ToList()
        End If

        FacturacionBindingSource.DataSource = facturas
    End Sub

    Private Sub DG_facturas_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DG_facturas.CellFormatting
        'Elimino el boton de detalla nota credito en caso de que la factura no tenga nota credito asociada
        If (DG_facturas.Columns(e.ColumnIndex).Name = "NotaCredito" And FacturacionBindingSource.List.Count > e.RowIndex) Then
            Dim factura As Entidades.Facturacion = FacturacionBindingSource.List(e.RowIndex)
            If (factura.id_NotaCredito = 0) Then
                e.CellStyle.Padding = New Padding(1000, 1000, 0, 0)
            End If
        End If
    End Sub

    Private Sub DG_facturas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_facturas.CellContentClick
        If (DG_facturas.Columns(e.ColumnIndex).Name = "NotaCredito") Then
            Dim frmVerNotaCredito As FrmVerNotaCredito = New FrmVerNotaCredito()
            frmVerNotaCredito.id_NotaCreadito = CType(DG_facturas.CurrentRow.DataBoundItem, Entidades.Facturacion).id_NotaCredito
            frmVerNotaCredito.ShowDialog()
        End If
    End Sub

    Private Sub btn_Restablecer_Click(sender As Object, e As EventArgs) Handles btn_Restablecer.Click
        FDesde.Value = Now.Date.AddDays(-30)
        FHasta.Value = Now.Date.AddDays(1)
        ChkMarcaElectronica.Checked = True
        ChkMarcaManual.Checked = True
        ChkMarcaTicket.Checked = True
        txtCUIT.Clear()
        txtFacturaNro.Clear()
        txtMontoDesde.Clear()
        txtMontoHasta.Clear()
        txtNombre.Clear()

        FacturacionBindingSource.DataSource = NegFacturacion.ObtenerListado(My.Settings.Sucursal, FDesde.Value.ToString("yyyy/MM/dd"), FHasta.Value.ToString("yyyy/MM/dd"))
    End Sub

    Private Sub DG_facturas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_facturas.CellDoubleClick
        Try
            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            'Traigo la venta
            Dim facturacion As Facturacion = DG_facturas.CurrentRow.DataBoundItem
            id_VentaDetalle = facturacion.id_Venta
            Dim dsVentasDetalle, dsVentas As DataSet
            dsVentas = NegVentas.TraerVenta(id_VentaDetalle)
            eVentas.id_Venta = id_VentaDetalle
            eVentas.id_Sucursal = dsVentas.Tables(0).Rows(0).Item("id_Sucursal").ToString
            eVentas.id_Empleado = dsVentas.Tables(0).Rows(0).Item("id_Empleado").ToString

            'Cargo los labels de la venta.
            If dsVentas.Tables(0).Rows.Count <> 0 Then
                lblCantidad.Text = dsVentas.Tables(0).Rows(0).Item("Cantidad_Total").ToString
                lblFecha.Text = dsVentas.Tables(0).Rows(0).Item("Fecha").ToString
                lblSucursal.Text = dsVentas.Tables(0).Rows(0).Item("Sucursal").ToString
                lblVenta.Text = dsVentas.Tables(0).Rows(0).Item("TiposVenta").ToString
                TipoPagoDetalle = dsVentas.Tables(0).Rows(0).Item("TiposPago").ToString
                lblPorcentajeFacturacion.Text = dsVentas.Tables(0).Rows(0).Item("PorcentajeFacturacion").ToString
                lblPago.Text = TipoPagoDetalle

                MontoTotalDetalle = CType(dsVentas.Tables(0).Rows(0).Item("Precio_Total").ToString, Decimal)
                DescuentoDetalle = CType(dsVentas.Tables(0).Rows(0).Item("Descuento").ToString, Decimal)
                SubTotalDetalle = CType(dsVentas.Tables(0).Rows(0).Item("Subtotal").ToString, Decimal)
                MontoSenia = CType(dsVentas.Tables(0).Rows(0).Item("MontoSenia").ToString, Decimal)
                porcentajeFacturacion = CType(dsVentas.Tables(0).Rows(0).Item("PorcentajeFacturacion").ToString, Decimal) / 100
                VentaSeniada = CType(dsVentas.Tables(0).Rows(0).Item("Senia").ToString, Boolean)
                id_Cliente = If(dsVentas.Tables(0).Rows(0).Item("id_Cliente") Is DBNull.Value, 0, CType(dsVentas.Tables(0).Rows(0).Item("id_Cliente").ToString, Integer))

                CargarTotales(MontoTotalDetalle, DescuentoDetalle, SubTotalDetalle, MontoSenia, porcentajeFacturacion, VentaSeniada)

                If dsVentas.Tables(0).Rows(0).Item("RazonSocial").ToString <> "" Then
                    lblCliente.Text = dsVentas.Tables(0).Rows(0).Item("RazonSocial").ToString
                Else
                    lblCliente.Text = "- - - - - "
                End If

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
                    frmVerFactura.id_Venta = id_VentaDetalle
                Else
                    lblFacturado.Text = "NO"
                End If

                If dsVentas.Tables(0).Rows(0).Item("Anulado").ToString = "1" Then
                    lblAnulado.Text = "VENTA ANULADA EL " & String.Format("{0:d}", CDate(dsVentas.Tables(0).Rows(0).Item("FechaAnulado"))) & vbCrLf & Replace(Trim(dsVentas.Tables(0).Rows(0).Item("DescripcionAnulado").ToString), "<br />", vbCrLf)
                    lblAnulado.Visible = True
                    Gb_Anulado.Visible = False
                Else
                    lblAnulado.Visible = False
                    Gb_Anulado.Visible = True
                    txtDescripcionAnular.Clear()
                End If

                DG_Productos.Rows.Clear()

                'Detalle de la venta.
                dsVentasDetalle = NegVentas.TraerVentaDetalle(id_VentaDetalle)
                For Each ventaDetalle In dsVentasDetalle.Tables(0).Rows
                    AgregarProducto(ventaDetalle)
                Next
            End If

            'Cambio el cursor a NORMAL.
            Me.Cursor = Cursors.Arrow

            'hago foco en el tab_modificacion 
            TabAdministracionFacturas.SelectedTab = TabDetalle
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha encontrado un error al obtener la venta.", "Administración de Facturas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CargarTotales(MontoTotalDetalle As Double, DescuentoDetalle As Double, SubTotalDetalle As Double, Senia As Double, PorcentajeFacturacion As Double, VentaSeniada As Boolean)
        If TipoCliente() = TipoCliente.Minorista Then
            CargarTotalesMinorista(MontoTotalDetalle, DescuentoDetalle, SubTotalDetalle, Senia)
            If (Not VentaSeniada) Then
                Dim posiscion1 As Point = lblSeniaMinorista.Location
                Dim posiscion2 As Point = lblSeniaMinoristaDescripcion.Location
                lblSeniaMinorista.Location = lblMontoMinorista.Location
                lblSeniaMinoristaDescripcion.Location = lblMontoMinoristaDescripcion.Location

                lblMontoMinorista.Location = posiscion1
                lblMontoMinoristaDescripcion.Location = posiscion2

                lblPendienteAbonarMinoristaDescripcion.Visible = False
                lblPendienteAbonarMinorista.Visible = False
            End If
            PanelTotalMayorista.Visible = False
            PanelTotalMinoristaSenia.Visible = True
        Else
            CargarTotalesMayorista(MontoTotalDetalle, DescuentoDetalle, SubTotalDetalle, Senia, PorcentajeFacturacion)
            If (Not VentaSeniada) Then
                Dim posiscion1 As Point = lblSeniaMayorista.Location
                Dim posiscion2 As Point = lblSeniaMayoristaDescripcion.Location
                lblSeniaMayorista.Location = lblMontoMayorista.Location
                lblSeniaMayoristaDescripcion.Location = lblMontoMayoristaDescripcion.Location

                lblMontoMayorista.Location = posiscion1
                lblMontoMayoristaDescripcion.Location = posiscion2

                lblPendienteAbonarMayoristaDescripcion.Visible = False
                lblPendienteAbonarMayorista.Visible = False
            End If

            PanelTotalMayorista.Visible = True
            PanelTotalMinoristaSenia.Visible = False
            PanelTotalMayorista.Location = PanelTotalMinoristaSenia.Location
        End If
    End Sub

    Private Sub CargarTotalesMinorista(MontoTotalDetalle As Double, DescuentoDetalle As Double, SubTotalDetalle As Double, Senia As Double)
        lblMontoMinorista.Text = "$ " & Format(MontoTotalDetalle, "###0.00")
        lblDescuentoMinorista.Text = "$ " & Format(DescuentoDetalle, "###0.00")
        lblSubtotalMinorista.Text = "$ " & Format(SubTotalDetalle, "###0.00")
        lblSeniaMinorista.Text = "$ " & Format(Senia, "###0.00")
        lblPendienteAbonarMinorista.Text = "$ " & Format(MontoTotalDetalle - Senia, "###0.00")
    End Sub

    Private Sub CargarTotalesMayorista(MontoTotalDetalle As Double, DescuentoDetalle As Double, SubTotalDetalle As Double, Senia As Double, PorcentajeFacturacion As Double)
        lblDescuentoMayorista.Text = "$ " & Format(DescuentoDetalle, "###0.00")
        lblSubtotalMayorista.Text = "$ " & Format(SubTotalDetalle, "###0.00")
        lblIVAMayorista.Text = "$ " & Format(SubTotalDetalle * 0.21 * PorcentajeFacturacion, "###0.00")
        lblMontoMayorista.Text = "$ " & Format(MontoTotalDetalle, "###0.00")
        lblSeniaMayorista.Text = "$ " & Format(Senia, "###0.00")
        lblPendienteAbonarMayorista.Text = "$ " & Format(MontoTotalDetalle - Senia, "###0.00")
    End Sub

    Private Sub AgregarProducto(ventaDetalle As Object)
        'Creo la fila del producto.
        Dim dgvRow As New DataGridViewRow
        Dim dgvCell As DataGridViewCell

        'Valor de la Columna Numero
        dgvCell = New DataGridViewTextBoxCell()
        dgvCell.Value = DG_Productos.Rows.Count + 1
        dgvRow.Cells.Add(dgvCell)

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
        If (lblVenta.Text = "Minorista") Then
            Return TipoCliente.Minorista
        Else
            Return TipoCliente.Mayorista
        End If
    End Function

    Private Sub BtnAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAnular.Click
        Dim Result As DialogResult
        Result = MessageBox.Show("¿Está seguro que desea anular la venta?", "Administración de Ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Result = System.Windows.Forms.DialogResult.Yes Then 'Si acepta anular la venta
            'Cambio el cursor a "WAIT"
            TabAdministracionFacturas.Cursor = Cursors.WaitCursor

            Try
                Dim senia As Senia = NegSenia.ConsultarSeniaPorVenta(eVentas.id_Venta)

                'Si la venta esta relacionada a una senia
                If (senia IsNot Nothing) Then
                    AnularVentaSenia(senia)
                Else
                    AnularVenta()
                End If

            Catch ex As Exception
                'Muestro el resultado
                MessageBox.Show("Se ha encontrado un error al anular la venta. Por favor, contactese con el administrador.", "Administración de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            'Cambio el cursor a NORMAL.
            TabAdministracionFacturas.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub AnularVenta()
        Dim ResultadoAnulado As Integer
        Dim TextoAnulado As String = Replace(Trim(txtDescripcionAnular.Text), vbCrLf, "<br />")

        ResultadoAnulado = NegVentas.AnularVenta(eVentas.id_Venta, TextoAnulado)

        If ResultadoAnulado = 1 Then 'Se anulo la venta en productos correctamente.

            'Actualizo el Stock.
            AgregarStock(eVentas.id_Venta)

            'Quito las comisiones
            NegComisiones.EliminarComisiones(eVentas.id_Venta)

            Dim dsVentas As DataSet = NegVentas.TraerVenta(eVentas.id_Venta)
            Dim PorcentajeFacturacion = CType(dsVentas.Tables(0).Rows(0).Item("PorcentajeFacturacion").ToString, Decimal) / 100
            Dim TipoFactura As Integer = CType(dsVentas.Tables(0).Rows(0).Item("TipoFactura").ToString, Integer)
            Dim TipoPago As String = dsVentas.Tables(0).Rows(0).Item("TiposPago").ToString()
            Dim Total As Double = CType(dsVentas.Tables(0).Rows(0).Item("Precio_Total").ToString, Double)
            Dim Descuento As Double = CType(dsVentas.Tables(0).Rows(0).Item("Descuento").ToString, Double)
            Dim SubTotal As Double = CType(dsVentas.Tables(0).Rows(0).Item("Subtotal").ToString, Double)
            Dim SeniaMonto As Double = CType(dsVentas.Tables(0).Rows(0).Item("MontoSenia").ToString, Double)
            Dim id_Cliente As Integer = If(dsVentas.Tables(0).Rows(0).Item("id_Cliente") Is DBNull.Value, 0, CType(dsVentas.Tables(0).Rows(0).Item("id_Cliente").ToString, Integer))

            'Genero una nota de credito si la venta fue facturada
            GenerarNotaCredito("La venta se encuentra facturada, desea realizar una nota de crédito?.", TipoFactura, eVentas.id_Venta, Total, Descuento, SeniaMonto, SubTotal * 0.21, SubTotal, PorcentajeFacturacion, TipoPago, id_Cliente, False)

            AnularPresupuesto(eVentas.id_Venta, "La venta se encuentra presupuestada, desea anular el presupuesto.")

            'Limpio Formulario
            txtDescripcionAnular.Clear()
            Gb_Anulado.Visible = False
            lblAnulado.Visible = True
            lblAnulado.Text = "VENTA ANULADA EL " & String.Format("{0:d}", DateTime.Now)

            'Muestro el resultado
            MessageBox.Show("Se ha anulado la venta correctamente.", "Administración de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            'Muestro el resultado
            MessageBox.Show("No ha podido ser anulada la venta. Por favor, intente más tarde o contactese con el administrador.", "Administración de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub AnularVentaSenia(senia As Senia)
        Dim ResultadoAnulado As Integer
        Dim TextoAnulado As String = Replace(Trim(txtDescripcionAnular.Text), vbCrLf, "<br />")

        'Si la reserva tiene una seña anulo dicha venta 
        If (senia.IdVentaSenia > 0) Then
            ResultadoAnulado = NegVentas.AnularVenta(senia.IdVentaSenia, TextoAnulado)
        End If

        'Si la reserva tambien tiene su retiro anulo dicha venta
        If (senia.IdVentaRetiro > 0) Then
            ResultadoAnulado = NegVentas.AnularVenta(senia.IdVentaRetiro, TextoAnulado)
        End If

        If ResultadoAnulado = 1 Then 'Se anulo la venta en productos correctamente.
            'Anulo la seña
            senia.Anulada = True
            NegSenia.ActualizarSenia(senia)

            'Si la reserva se retiro, solo tengo que incrementar el stock de dicha venta. Si la venta todavia no se retiro tengo que incrementar el sotck de la reserva
            If (senia.IdVentaRetiro > 0) Then
                AgregarStock(senia.IdVentaRetiro)
            ElseIf (senia.IdVentaSenia > 0) Then
                AgregarStock(senia.IdVentaSenia)
            End If

            'Si la reserva se retiro, tengo que anular la comision por la reserva y venta. Si la venta todavia no se retiro tengo que anular la comision por la reserva solamante
            If (senia.IdVentaRetiro > 0) Then
                NegComisiones.EliminarComisiones(senia.IdVentaSenia)
                NegComisiones.EliminarComisiones(senia.IdVentaRetiro)
            ElseIf (senia.IdVentaSenia > 0) Then
                NegComisiones.EliminarComisiones(senia.IdVentaSenia)
            End If

            GenerarNotaCreditoSenia(senia)

            If (senia.IdVentaSenia > 0) Then
                AnularPresupuesto(senia.IdVentaSenia, "La venta esta asociada a una reserva presupuestada, desea anular el presupuesto?")
            End If

            GenerarNotaCreditoVenta(senia)

            If (senia.IdVentaRetiro > 0) Then
                AnularPresupuesto(senia.IdVentaRetiro, "La venta esta asociada a una reserva la cual a sido retirada y presupuestada, desea realizar una nota de presupuesto?")
            End If

            'Limpio Formulario
            txtDescripcionAnular.Clear()
            Gb_Anulado.Visible = False
            lblAnulado.Visible = True
            lblAnulado.Text = "VENTA ANULADA EL " & String.Format("{0:d}", DateTime.Now)

            'Muestro el resultado
            MessageBox.Show("Se ha anulado la venta correctamente.", "Administración de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            'Muestro el resultado
            MessageBox.Show("No ha podido ser anulada la venta. Por favor, intente más tarde o contactese con el administrador.", "Administración de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub GenerarNotaCreditoVenta(senia As Senia)
        If (senia.IdVentaRetiro > 0) Then
            Dim dsVentas As DataSet = NegVentas.TraerVenta(senia.IdVentaRetiro)

            Dim TipoFactura As Integer = CType(dsVentas.Tables(0).Rows(0).Item("TipoFactura").ToString, Integer)
            Dim TipoPago As String = dsVentas.Tables(0).Rows(0).Item("TiposPago").ToString()
            Dim Total As Double = CType(dsVentas.Tables(0).Rows(0).Item("Precio_Total").ToString, Double)
            Dim Descuento As Double = CType(dsVentas.Tables(0).Rows(0).Item("Descuento").ToString, Double)
            Dim SubTotal As Double = CType(dsVentas.Tables(0).Rows(0).Item("Subtotal").ToString, Double)
            Dim SeniaMonto As Double = CType(dsVentas.Tables(0).Rows(0).Item("MontoSenia").ToString, Double)
            Dim id_Venta As Integer = CType(dsVentas.Tables(0).Rows(0).Item("id_Venta").ToString, Integer)
            Dim id_Cliente As Integer = If(dsVentas.Tables(0).Rows(0).Item("id_Cliente") Is DBNull.Value, 0, CType(dsVentas.Tables(0).Rows(0).Item("id_Cliente").ToString, Integer))

            GenerarNotaCredito("La venta esta asociada a una reserva la cual a sido retirada y facturada, desea realizar una nota de crédito?", TipoFactura, id_Venta, Total, Descuento, SeniaMonto, SubTotal * 0.21, SubTotal, porcentajeFacturacion, TipoPago, id_Cliente, False)
        End If
    End Sub

    Private Sub GenerarNotaCreditoSenia(senia As Senia)
        If (senia.IdVentaSenia > 0) Then
            Dim dsVentas As DataSet = NegVentas.TraerVenta(senia.IdVentaSenia)

            Dim PorcentajeFacturacion = CType(dsVentas.Tables(0).Rows(0).Item("PorcentajeFacturacion").ToString, Decimal) / 100
            Dim TipoFactura As Integer = CType(dsVentas.Tables(0).Rows(0).Item("TipoFactura").ToString, Integer)
            Dim TipoPago As String = dsVentas.Tables(0).Rows(0).Item("TiposPago").ToString()
            Dim Total As Double = CType(dsVentas.Tables(0).Rows(0).Item("Precio_Total").ToString, Double)
            Dim Descuento As Double = CType(dsVentas.Tables(0).Rows(0).Item("Descuento").ToString, Double)
            Dim SubTotal As Double = CType(dsVentas.Tables(0).Rows(0).Item("Subtotal").ToString, Double)
            Dim SeniaMonto As Double = CType(dsVentas.Tables(0).Rows(0).Item("MontoSenia").ToString, Double)
            Dim id_Venta As Integer = CType(dsVentas.Tables(0).Rows(0).Item("id_Venta").ToString, Integer)
            Dim id_Cliente As Integer = If(dsVentas.Tables(0).Rows(0).Item("id_Cliente") Is DBNull.Value, 0, CType(dsVentas.Tables(0).Rows(0).Item("id_Cliente").ToString, Integer))

            GenerarNotaCredito("La venta esta asociada a una reserva facturada, desea realizar una nota de crédito?", TipoFactura, id_Venta, 0, 0, SeniaMonto, 0, 0, PorcentajeFacturacion, TipoPago, id_Cliente, True)
        End If
    End Sub


    Private Sub AnularPresupuesto(idventa As Int64, MensajeConsuta As String)
        Dim NegPresupuesto As Negocio.NegPresupuesto = New Negocio.NegPresupuesto()
        Dim presupuesto As Presupuesto = NegPresupuesto.TraerPresupuestoPorVenta(idventa)

        If (presupuesto.id_Presupuesto > 0 AndAlso Not presupuesto.Anulado AndAlso MessageBox.Show(MensajeConsuta, "Administración de Reservas", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes) Then
            presupuesto.Anulado = True
            presupuesto.FechaAnulado = DateTime.Now
            presupuesto.DescripcionAnulado = txtDescripcionAnular.Text
            NegPresupuesto.Anula(presupuesto)

            Dim frmReportePresupuesto As frmReportePresupuesto = New frmReportePresupuesto()
            frmReportePresupuesto.presupuesto = presupuesto
            frmReportePresupuesto.ShowDialog()
        End If
    End Sub

    Private Sub AgregarStock(IdVenta As Int64)
        'Actualizo el Stock.
        Dim dsVentasDetalle As DataSet = NegVentas.TraerVentaDetalle(IdVenta)
        For Each ventaDetalle In dsVentasDetalle.Tables(0).Rows
            NegStock.AgregarStock(ventaDetalle.item("id_Producto").ToString(), eVentas.id_Sucursal, ventaDetalle.item("Cantidad").ToString())
        Next
    End Sub

    Private Sub GenerarNotaCredito(mensaje As String, Tipofactura As Integer, IdVenta As Int64, Total As Double, Descuento As Double, SeniaMonto As Double, IVA As Double, SubTotal As Double, PorcentajeFacturacion As Double, TipoPago As String, id_Cliente As Integer, esSenia As Boolean)
        If (Tipofactura >= 0) Then
            If (MessageBox.Show(mensaje, "Administración de Reservas", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes) Then

                Dim frmNotaCredito As frmNotaCredito = New frmNotaCredito()
                frmNotaCredito.DevolucionDetalle = New List(Of Devolucion_Detalle)()

                If (TipoCliente() = Entidades.TipoCliente.Minorista) Then
                    'Abro el form de datos de facturacion.

                    frmNotaCredito.Monto = Total
                    frmNotaCredito.Descuento = Descuento + SeniaMonto
                    frmNotaCredito.SubTotal = SubTotal
                    frmNotaCredito.TipoPago = TipoPago
                    frmNotaCredito.TipoCliente = TipoCliente.Minorista
                    frmNotaCredito.EsSenia = esSenia
                    frmNotaCredito.PorcentajeFacturacion = 1
                Else

                    Dim MontoSeñaSinIva As Double = SeniaMonto / ((0.21 * PorcentajeFacturacion) + 1)
                    Dim DescuentoTotal As Double = Descuento + MontoSeñaSinIva
                    'Abro el form de datos de facturacion.

                    frmNotaCredito.id_Cliente = id_Cliente
                    frmNotaCredito.Descuento = Math.Round(DescuentoTotal * PorcentajeFacturacion, 2)
                    frmNotaCredito.SubTotal = Math.Round((SubTotal - MontoSeñaSinIva) * PorcentajeFacturacion, 2)
                    frmNotaCredito.IvaTotal = Math.Round(IVA * PorcentajeFacturacion, 2)
                    frmNotaCredito.Monto = Math.Round(frmNotaCredito.SubTotal + frmNotaCredito.IvaTotal, 2)
                    frmNotaCredito.MontoSenia = Math.Round(MontoSeñaSinIva * PorcentajeFacturacion * 1.21, 2)
                    frmNotaCredito.TipoPago = TipoPago
                    frmNotaCredito.TipoCliente = TipoCliente.Mayorista
                    frmNotaCredito.EsSenia = esSenia
                    frmNotaCredito.PorcentajeFacturacion = PorcentajeFacturacion
                End If

                frmNotaCredito.NumeroFactura = NegFacturacion.TraerFacturacionPorIdVenta(IdVenta)?.NumeroFactura

                Dim dsDetalle As DataSet = NegVentas.TraerVentaDetalle(IdVenta)

                For Each prod In dsDetalle.Tables(0).Rows
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
                    NegNotaCredito.NuevaNotaCredito(notaCredito)
                Next
            End If
        End If
    End Sub
End Class