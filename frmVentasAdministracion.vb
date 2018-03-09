Imports Entidades

Public Class frmVentasAdministracion
    Dim NegVentas As New Negocio.NegVentas
    Dim NegStock As New Negocio.NegStock
    Dim NegComisiones As New Negocio.NegComisiones
    Dim NegSenia As New Negocio.NegSenia
    Dim NegTiposPagos As New Negocio.NegTipoPago
    Dim id_Sucursal As String
    Dim eVentas As New Entidades.Ventas
    Dim Funciones As New Funciones
    Dim NegErrores As New Negocio.NegManejadorErrores

    Dim id_VentaDetalle As Int64 = 0
    Dim MontoTotalDetalle As Double = 0
    Dim DescuentoDetalle As Double = 0
    Dim CostoFinancieroDetalle As Double = 0
    Dim SubTotalDetalle As Double = 0
    Dim MontoSenia As Double = 0
    Dim porcentajeFacturacion As Double = 0
    Dim VentaSeniada As Boolean
    Dim TipoPagoDetalle As String = String.Empty
    Dim id_Cliente As Integer

    'Cuando carga el formulario.
    Private Sub frmVentasAdministracion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            'seteo el font a 8px
            DG_Ventas.AlternatingRowsDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DG_Ventas.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DG_Ventas.RowHeadersDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DG_Ventas.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

            'seteo las imagenes
            Dim ListaImagenes = New ImageList
            ListaImagenes.ImageSize = New Size(32, 32)
            ListaImagenes.TransparentColor = Color.Blue
            ListaImagenes.ColorDepth = ColorDepth.Depth32Bit
            ListaImagenes.Images.Add(My.Resources.Recursos.Ventas)
            ListaImagenes.Images.Add(My.Resources.Recursos.Lapiz)
            TabVentas.ImageList = ListaImagenes

            'Sucursal default
            id_Sucursal = My.Settings("Sucursal")

            'icono de clientes
            TbListado.ImageIndex = 0
            'icono de detalle
            TbDetalle.ImageIndex = 1

            'Seteo fechas.
            FDesde.Value = Now.Date.AddDays(-30)
            FHasta.Value = Now.Date.AddDays(1)

            Dim TipoFactura As DataGridViewComboBoxColumn = DG_Ventas.Columns("TipoFactura")

            TipoFactura.ValueMember = "Key"
            TipoFactura.DisplayMember = "Value"

            Dim TiposPago As List(Of KeyValuePair(Of Integer, String)) = New List(Of KeyValuePair(Of Integer, String))()
            For Each tipo As Entidades.TipoFactura In [Enum].GetValues(GetType(Entidades.TipoFactura))
                Dim value As String = [Enum].GetName(GetType(Entidades.TipoFactura), tipo)
                Dim Key As Integer = tipo
                TiposPago.Add(New KeyValuePair(Of Integer, String)(Key, value.ToUpper()))
            Next

            TiposPago.Add(New KeyValuePair(Of Integer, String)(-1, "NO"))
            TipoFactura.DataSource = TiposPago

            'Cargo el datagrid
            Dim dsVentas As New DataSet
            dsVentas = NegVentas.ListadoVentasCompletoFecha(id_Sucursal, FDesde.Value.ToString("yyyy/MM/dd"), FHasta.Value.ToString("yyyy/MM/dd"))
            If dsVentas.Tables(0).Rows.Count > 0 Then
                DG_Ventas.DataSource = dsVentas.Tables(0)
                DG_Ventas.AutoGenerateColumns = False
                DG_Ventas.ColumnHeadersVisible = True
                DG_Ventas.Columns("Descuento").Visible = False
                DG_Ventas.Columns("MontoTotal").DefaultCellStyle.Format = "C2"
                DG_Ventas.Columns("Cliente").DefaultCellStyle.NullValue = "No Disponible"
                DG_Ventas.Columns("NumFactura").DefaultCellStyle.Format = "D5"
                DG_Ventas.Columns("NumFactura").ValueType = GetType(Integer)
                DG_Ventas.Refresh()
                lbl_Msg.Visible = False
            Else
                DG_Ventas.DataSource = Nothing
                DG_Ventas.Refresh()
                lbl_Msg.Visible = True
            End If

            Dim DsTiposPagos As DataSet = NegTiposPagos.ListadoTiposPagosCache(My.Settings.UsarMemoriaCache)
            If DsTiposPagos.Tables(0).Rows.Count > 0 Then
                cmbFormaPago.DataSource = Nothing
                cmbFormaPago.DataSource = Funciones.CrearDataTable("id_TipoPago", "Descripcion", DsTiposPagos, "Todas")
                cmbFormaPago.DisplayMember = "Descripcion"
                cmbFormaPago.ValueMember = "id_TipoPago"
                cmbFormaPago.SelectedValue = 0
                cmbFormaPago.Refresh()
            End If

            EvaluarPermisos()

            'Cambio el cursor a NORMAL.
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha encontrado un error al listar las ventas de la sucursal.", "Administración de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Cuando selecciona un tab.
    Private Sub TabVentas_Selected(ByVal sender As Object, ByVal e As System.Windows.Forms.TabControlEventArgs) Handles TabVentas.Selected
        'Cambio el cursor a "WAIT"
        Me.Cursor = Cursors.WaitCursor

        If TabVentas.SelectedIndex = 0 Then 'TAB LISTADO DE VENTAS

            'Actualizo el datagrid si se selecciona el tab del listado
            Buscar()

            'Seteo el id_CLiente en cero
            eVentas.id_Venta = 0

            'Limpio Formulario.
            LimpiarFormulario()

        ElseIf TabVentas.SelectedIndex = 1 Then 'TAB DETALLE DE LA VENTA
            If eVentas.id_Venta > 0 Or eVentas.id_Venta <> Nothing Then

            Else
                MessageBox.Show("Debe seleccionar previamente una venta.", "Administración de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                TabVentas.SelectedIndex = 0
            End If
        End If

        'Cambio el cursor a NORMAL.
        Me.Cursor = Cursors.Arrow
    End Sub

    'Cuando realiza doble click en el DG_Ventas.
    Private Sub DG_Ventas_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Ventas.CellDoubleClick
        Try
            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            'Traigo la venta
            id_VentaDetalle = DG_Ventas.Rows(e.RowIndex).Cells("id_Venta").Value()
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
                CostoFinancieroDetalle = CType(dsVentas.Tables(0).Rows(0).Item("CostoFinanciero").ToString, Decimal)
                SubTotalDetalle = CType(dsVentas.Tables(0).Rows(0).Item("Subtotal").ToString, Decimal)
                MontoSenia = CType(dsVentas.Tables(0).Rows(0).Item("MontoSenia").ToString, Decimal)
                PorcentajeFacturacion = CType(dsVentas.Tables(0).Rows(0).Item("PorcentajeFacturacion").ToString, Decimal) / 100
                VentaSeniada = CType(dsVentas.Tables(0).Rows(0).Item("Senia").ToString, Boolean)
                id_Cliente = If(dsVentas.Tables(0).Rows(0).Item("id_Cliente") Is DBNull.Value, 0, CType(dsVentas.Tables(0).Rows(0).Item("id_Cliente").ToString, Integer))

                CargarTotales(MontoTotalDetalle, DescuentoDetalle, SubTotalDetalle, CostoFinancieroDetalle, MontoSenia, porcentajeFacturacion, VentaSeniada)

                If dsVentas.Tables(0).Rows(0).Item("RazonSocial").ToString <> "" Then
                    lblCliente.Text = dsVentas.Tables(0).Rows(0).Item("RazonSocial").ToString
                ElseIf dsVentas.Tables(0).Rows(0).Item("NombreClienteMinorista").ToString <> "" Then
                    lblCliente.Text = dsVentas.Tables(0).Rows(0).Item("NombreClienteMinorista").ToString
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
                    BtnFactura.Visible = True
                    BtnEmitirFactura.Visible = False
                    frmVerFactura.id_Venta = id_VentaDetalle
                Else
                    lblFacturado.Text = "NO"
                    BtnFactura.Visible = False
                    BtnEmitirFactura.Visible = True
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

                'Detalle de la venta.
                dsVentasDetalle = NegVentas.TraerVentaDetalle(id_VentaDetalle)
                For Each ventaDetalle In dsVentasDetalle.Tables(0).Rows
                    AgregarProducto(ventaDetalle)
                Next
            End If

            'Cambio el cursor a NORMAL.
            Me.Cursor = Cursors.Arrow

            'hago foco en el tab_modificacion 
            TabVentas.SelectedTab = TabVentas.TabPages("TbDetalle")
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha encontrado un error al obtener la venta.", "Administración de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CargarTotales(MontoTotalDetalle As Double, DescuentoDetalle As Double, SubTotalDetalle As Double, CostoFinancieroDetalle As Double, Senia As Double, PorcentajeFacturacion As Double, VentaSeniada As Boolean)
        If TipoCliente() = TipoCliente.Minorista Then
            CargarTotalesMinorista(MontoTotalDetalle, DescuentoDetalle, CostoFinancieroDetalle, SubTotalDetalle, Senia)
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
            CargarTotalesMayorista(MontoTotalDetalle, DescuentoDetalle, CostoFinancieroDetalle, SubTotalDetalle, Senia, PorcentajeFacturacion)
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

    Private Sub CargarTotalesMinorista(MontoTotalDetalle As Double, DescuentoDetalle As Double, CostoFinancieroDetalle As Double, SubTotalDetalle As Double, Senia As Double)
        lblMontoMinorista.Text = "$ " & Format(MontoTotalDetalle, "###0.00")
        lblDescuentoMinorista.Text = "$ " & Format(DescuentoDetalle, "###0.00")
        lblCostoFinancieroMinorista.Text = "$ " & Format(CostoFinancieroDetalle, "###0.00")
        lblSubtotalMinorista.Text = "$ " & Format(SubTotalDetalle, "###0.00")
        lblSeniaMinorista.Text = "$ " & Format(Senia, "###0.00")
        lblPendienteAbonarMinorista.Text = "$ " & Format(MontoTotalDetalle - Senia, "###0.00")
    End Sub

    Private Sub CargarTotalesMayorista(MontoTotalDetalle As Double, DescuentoDetalle As Double, CostoFinancieroDetalle As Double, SubTotalDetalle As Double, Senia As Double, PorcentajeFacturacion As Double)
        lblDescuentoMayorista.Text = "$ " & Format(DescuentoDetalle, "###0.00")
        lblCostoFinancieroMayorista.Text = "$ " & Format(CostoFinancieroDetalle, "###0.00")
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
        dgvCell.Value = ventaDetalle.Item("Codigo")
        dgvRow.Cells.Add(dgvCell)

        'Valor de la Columna Nombre
        dgvCell = New DataGridViewTextBoxCell()
        dgvCell.Value = ventaDetalle.Item("Nombre").ToString
        dgvRow.Cells.Add(dgvCell)

        'Valor de la Columna Cantidad
        dgvCell = New DataGridViewTextBoxCell()
        dgvCell.Value = ventaDetalle.Item("Cantidad")
        dgvRow.Cells.Add(dgvCell)

        'Valor de la Columna Precio
        dgvCell = New DataGridViewTextBoxCell()
        dgvCell.Value = ventaDetalle.Item("Precio")
        'dgvCell.Value = Format(0, "###0.00")
        dgvRow.Cells.Add(dgvCell)

        'Valor de la Columna IVA
        dgvCell = New DataGridViewTextBoxCell()
        dgvCell.Value = ventaDetalle.Item("Iva")
        'dgvCell.Value = Format(0, "###0.00")
        dgvRow.Cells.Add(dgvCell)

        'Valor de la Columna Monto
        dgvCell = New DataGridViewTextBoxCell()
        dgvCell.Value = ventaDetalle.Item("Monto")
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

    'Cuando realiza click en anular venta.
    Private Sub BtnAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAnular.Click
        Dim Result As DialogResult
        Result = MessageBox.Show("¿Está seguro que desea anular la venta?", "Administración de Ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Result = System.Windows.Forms.DialogResult.Yes Then 'Si acepta anular la venta
            'Cambio el cursor a "WAIT"
            TabVentas.Cursor = Cursors.WaitCursor

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
            TabVentas.Cursor = Cursors.Arrow
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
            Dim CostoFinanciero As Double = CType(dsVentas.Tables(0).Rows(0).Item("CostoFinanciero").ToString, Double)
            Dim SubTotal As Double = CType(dsVentas.Tables(0).Rows(0).Item("Subtotal").ToString, Double)
            Dim SeniaMonto As Double = CType(dsVentas.Tables(0).Rows(0).Item("MontoSenia").ToString, Double)
            Dim id_Cliente As Integer = If(dsVentas.Tables(0).Rows(0).Item("id_Cliente") Is DBNull.Value, 0, CType(dsVentas.Tables(0).Rows(0).Item("id_Cliente").ToString, Integer))

            'Genero una nota de credito si la venta fue facturada
            GenerarNotaCredito("La venta se encuentra facturada, desea realizar una nota de crédito?.", TipoFactura, eVentas.id_Venta, Total, Descuento, CostoFinanciero, SeniaMonto, SubTotal * 0.21, SubTotal, PorcentajeFacturacion, TipoPago, id_Cliente)

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
            Dim CostoFinanciero As Double = CType(dsVentas.Tables(0).Rows(0).Item("CostoFinanciero").ToString, Double)
            Dim SubTotal As Double = CType(dsVentas.Tables(0).Rows(0).Item("Subtotal").ToString, Double)
            Dim SeniaMonto As Double = CType(dsVentas.Tables(0).Rows(0).Item("MontoSenia").ToString, Double)
            Dim id_Venta As Int64 = CType(dsVentas.Tables(0).Rows(0).Item("id_Venta").ToString, Int64)
            Dim id_Cliente As Integer = If(dsVentas.Tables(0).Rows(0).Item("id_Cliente") Is DBNull.Value, 0, CType(dsVentas.Tables(0).Rows(0).Item("id_Cliente").ToString, Integer))

            GenerarNotaCredito("La venta esta asociada a una reserva la cual a sido retirada y facturada, desea realizar una nota de crédito?", TipoFactura, id_Venta, Total, Descuento, CostoFinanciero, SeniaMonto, SubTotal * 0.21, SubTotal, porcentajeFacturacion, TipoPago, id_Cliente)
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
            Dim CostoFinanciero As Double = CType(dsVentas.Tables(0).Rows(0).Item("CostoFinanciero").ToString, Double)
            Dim SubTotal As Double = CType(dsVentas.Tables(0).Rows(0).Item("Subtotal").ToString, Double)
            Dim SeniaMonto As Double = CType(dsVentas.Tables(0).Rows(0).Item("MontoSenia").ToString, Double)
            Dim id_Venta As Int64 = CType(dsVentas.Tables(0).Rows(0).Item("id_Venta").ToString, Int64)
            Dim id_Cliente As Integer = If(dsVentas.Tables(0).Rows(0).Item("id_Cliente") Is DBNull.Value, 0, CType(dsVentas.Tables(0).Rows(0).Item("id_Cliente").ToString, Integer))

            GenerarNotaCreditoSenia("La venta esta asociada a una reserva facturada, desea realizar una nota de crédito?", TipoFactura, id_Cliente, SeniaMonto, CostoFinanciero, id_Venta, TipoPago, PorcentajeFacturacion)
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

    Private Sub GenerarNotaCredito(mensaje As String, Tipofactura As Integer, IdVenta As Int64, Total As Double, Descuento As Double, CostoFinanciero As Double, SeniaMonto As Double, IVA As Double, SubTotal As Double, PorcentajeFacturacion As Double, TipoPago As String, id_Cliente As Integer)
        If (Tipofactura >= 0) Then
            If (MessageBox.Show(mensaje, "Administración de Reservas", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes) Then
                If (TipoCliente() = Entidades.TipoCliente.Minorista) Then
                    'Abro el form de datos de facturacion.
                    Dim frmFacturar As frmFacturar = New frmFacturar()
                    frmFacturar.id_Venta = IdVenta
                    frmFacturar.Monto = Total
                    frmFacturar.Descuento = Descuento + SeniaMonto
                    frmFacturar.CostoFinanciero = CostoFinanciero
                    frmFacturar.SubTotal = SubTotal
                    frmFacturar.TipoPago = TipoPago
                    frmFacturar.TipoCliente = TipoCliente.Minorista
                    frmFacturar.EsSenia = False
                    frmFacturar.NotaCredito = True
                    frmFacturar.PorcentajeFacturacion = 1
                    frmFacturar.ShowDialog()
                Else
                    Dim MontoSeñaSinIva As Double = SeniaMonto / ((0.21 * PorcentajeFacturacion) + 1)
                    Dim DescuentoTotal As Double = Descuento + MontoSeñaSinIva
                    'Abro el form de datos de facturacion.
                    Dim frmFacturar As frmFacturar = New frmFacturar()
                    frmFacturar.id_Venta = id_VentaDetalle
                    frmFacturar.id_Cliente = id_Cliente
                    frmFacturar.Descuento = Math.Round(DescuentoTotal * PorcentajeFacturacion, 2)
                    frmFacturar.CostoFinanciero = Math.Round(CostoFinanciero * PorcentajeFacturacion, 2)
                    frmFacturar.SubTotal = Math.Round((SubTotal - MontoSeñaSinIva) * PorcentajeFacturacion, 2)
                    frmFacturar.IvaTotal = Math.Round(frmFacturar.SubTotal * 0.21, 2)
                    frmFacturar.Monto = Math.Round(frmFacturar.SubTotal + frmFacturar.IvaTotal, 2)
                    frmFacturar.MontoSenia = Math.Round(MontoSeñaSinIva * PorcentajeFacturacion * 1.21, 2)
                    frmFacturar.TipoPago = TipoPago
                    frmFacturar.TipoCliente = TipoCliente.Mayorista
                    frmFacturar.EsSenia = False
                    frmFacturar.NotaCredito = True
                    frmFacturar.PorcentajeFacturacion = PorcentajeFacturacion
                    frmFacturar.ShowDialog()
                End If
            End If
        End If
    End Sub

    Private Sub GenerarNotaCreditoSenia(mensaje As String, Tipofactura As Integer, id_Cliente As Integer, MontoSenia As Double, CostoFinanciero As Double, id_Venta As Int64, TipoPago As String, PorcentajeFacturacion As Double)
        If (Tipofactura >= 0) Then
            If (MessageBox.Show(mensaje, "Administración de Reservas", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes) Then
                If (TipoCliente() = Entidades.TipoCliente.Minorista) Then
                    'Abro el form de datos de facturacion.
                    Dim frmFacturar As frmFacturar = New frmFacturar()
                    frmFacturar.id_Venta = id_Venta
                    frmFacturar.id_Cliente = id_Cliente
                    frmFacturar.TipoPago = TipoPago
                    frmFacturar.TipoCliente = TipoCliente.Minorista
                    frmFacturar.CostoFinanciero = CostoFinanciero
                    frmFacturar.SubTotal = MontoSenia
                    frmFacturar.Monto = MontoSenia + CostoFinanciero
                    frmFacturar.MontoSenia = MontoSenia
                    frmFacturar.EsSenia = True
                    frmFacturar.NotaCredito = True
                    frmFacturar.PorcentajeFacturacion = 1
                    frmFacturar.ShowDialog()
                Else

                    Dim MontoSeñaSinIva As Double = MontoSenia / ((0.21 * PorcentajeFacturacion) + 1)
                    Dim CostoFinancieroSinIva As Double = CostoFinanciero / ((0.21 * PorcentajeFacturacion) + 1)

                    'Abro el form de datos de facturacion.
                    Dim frmFacturar As frmFacturar = New frmFacturar()
                    frmFacturar.id_Venta = id_Venta
                    frmFacturar.id_Cliente = id_Cliente
                    frmFacturar.TipoPago = TipoPago
                    frmFacturar.TipoCliente = TipoCliente.Mayorista
                    frmFacturar.CostoFinanciero = Math.Round(CostoFinancieroSinIva, 2)
                    frmFacturar.SubTotal = Math.Round((MontoSeñaSinIva + CostoFinancieroSinIva) * PorcentajeFacturacion, 2)
                    frmFacturar.IvaTotal = Math.Round(frmFacturar.SubTotal * 0.21, 2)
                    frmFacturar.Monto = Math.Round(frmFacturar.SubTotal + frmFacturar.IvaTotal, 2)
                    frmFacturar.MontoSenia = Math.Round(MontoSeñaSinIva * PorcentajeFacturacion * 1.21, 2)
                    frmFacturar.EsSenia = True
                    frmFacturar.NotaCredito = True
                    frmFacturar.PorcentajeFacturacion = PorcentajeFacturacion
                    frmFacturar.ShowDialog()
                End If
            End If
        End If
    End Sub

    'Limpia el formulario.
    Sub LimpiarFormulario()
        DG_Productos.Rows.Clear()
        lblCantidad.Text = "- - - - -"
        lblMontoMinorista.Text = "- - - - -"
        lblFecha.Text = "- - - - -"
        lblSucursal.Text = "- - - - -"
        lblVendedor.Text = "- - - - -"
        lblVenta.Text = "- - - - -"
        lblPago.Text = "- - - - -"
        lblFacturado.Text = "- - - - -"
        lblCliente.Text = "- - - - -"
        lblAnulado.Visible = False
        BtnFactura.Visible = False
        Gb_Anulado.Visible = False
    End Sub

    'Filtra las ventas.
    Private Sub BtnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFiltrar.Click
        'Cambio el cursor a "WAIT"
        Me.Cursor = Cursors.WaitCursor

        Buscar()

        'Cambio el cursor a NORMAL.
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub Buscar()
        'Cargo el datagrid
        Dim dsVentas As DataSet = NegVentas.ListadoVentasCompletoFecha(id_Sucursal, FDesde.Value.ToString("yyyy/MM/dd"), FHasta.Value.ToString("yyyy/MM/dd"))

        If dsVentas.Tables(0).Rows.Count > 0 Then

            If Not String.IsNullOrEmpty(txtFacturaDesde.Text) Then
                For Each venta As DataRow In dsVentas.Tables(0).Rows.Cast(Of DataRow).Where(Function(x) If(x("NumeroFactura") Is DBNull.Value, True, Integer.Parse(x("NumeroFactura")) < Integer.Parse(txtFacturaDesde.Text))).ToList()
                    dsVentas.Tables(0).Rows.Remove(venta)
                Next
            End If

            If Not String.IsNullOrEmpty(txtFacturaHasta.Text) Then
                For Each venta As DataRow In dsVentas.Tables(0).Rows.Cast(Of DataRow).Where(Function(x) If(x("NumeroFactura") Is DBNull.Value, True, Integer.Parse(x("NumeroFactura")) > Integer.Parse(txtFacturaHasta.Text))).ToList()
                    dsVentas.Tables(0).Rows.Remove(venta)
                Next
            End If

            If Not String.IsNullOrEmpty(txtMontoDesde.Text) Then
                For Each venta As DataRow In dsVentas.Tables(0).Rows.Cast(Of DataRow).Where(Function(x) Double.Parse(x("MontoTotal")) < Double.Parse(txtMontoDesde.Text)).ToList()
                    dsVentas.Tables(0).Rows.Remove(venta)
                Next
            End If

            If Not String.IsNullOrEmpty(txtMontoHasta.Text) Then
                For Each venta As DataRow In dsVentas.Tables(0).Rows.Cast(Of DataRow).Where(Function(x) Double.Parse(x("MontoTotal")) > Double.Parse(txtMontoHasta.Text)).ToList()
                    dsVentas.Tables(0).Rows.Remove(venta)
                Next
            End If

            If Not ChkMarcaSinFacturar.Checked Then
                For Each venta As DataRow In dsVentas.Tables(0).Rows.Cast(Of DataRow).Where(Function(x) Integer.Parse(x("TipoRecibo")) = -1).ToList()
                    dsVentas.Tables(0).Rows.Remove(venta)
                Next
            End If

            If Not ChkMarcaTicket.Checked Then
                For Each venta As DataRow In dsVentas.Tables(0).Rows.Cast(Of DataRow).Where(Function(x) Integer.Parse(x("TipoRecibo")) = 0).ToList()
                    dsVentas.Tables(0).Rows.Remove(venta)
                Next
            End If

            If Not ChkMarcaElectronica.Checked Then
                For Each venta As DataRow In dsVentas.Tables(0).Rows.Cast(Of DataRow).Where(Function(x) Integer.Parse(x("TipoRecibo")) = 2).ToList()
                    dsVentas.Tables(0).Rows.Remove(venta)
                Next
            End If

            If Not ChkMarcaManual.Checked Then
                For Each venta As DataRow In dsVentas.Tables(0).Rows.Cast(Of DataRow).Where(Function(x) Integer.Parse(x("TipoRecibo")) = 1).ToList()
                    dsVentas.Tables(0).Rows.Remove(venta)
                Next
            End If

            If Not ChkAnuladoSi.Checked Then
                For Each venta As DataRow In dsVentas.Tables(0).Rows.Cast(Of DataRow).Where(Function(x) x("Anulado") = "SI").ToList()
                    dsVentas.Tables(0).Rows.Remove(venta)
                Next
            End If

            If Not ChkAnuladoNo.Checked Then
                For Each venta As DataRow In dsVentas.Tables(0).Rows.Cast(Of DataRow).Where(Function(x) x("Anulado") = "NO").ToList()
                    dsVentas.Tables(0).Rows.Remove(venta)
                Next
            End If

            If Not chkMenor.Checked Then
                For Each venta As DataRow In dsVentas.Tables(0).Rows.Cast(Of DataRow).Where(Function(x) x("TipoVenta") = "Menor").ToList()
                    dsVentas.Tables(0).Rows.Remove(venta)
                Next
            End If

            If Not chkMayor.Checked Then
                For Each venta As DataRow In dsVentas.Tables(0).Rows.Cast(Of DataRow).Where(Function(x) x("TipoVenta") = "Mayor").ToList()
                    dsVentas.Tables(0).Rows.Remove(venta)
                Next
            End If

            If cmbFormaPago.Text <> "Todas" Then
                For Each venta As DataRow In dsVentas.Tables(0).Rows.Cast(Of DataRow).Where(Function(x) x("FormaPago") <> cmbFormaPago.Text).ToList()
                    dsVentas.Tables(0).Rows.Remove(venta)
                Next
            End If

            DG_Ventas.DataSource = dsVentas.Tables(0)
            DG_Ventas.AutoGenerateColumns = False
            DG_Ventas.ColumnHeadersVisible = True
            DG_Ventas.Columns("id_Venta").Visible = False
            DG_Ventas.Columns("Descuento").Visible = False
            DG_Ventas.Columns("MontoTotal").DefaultCellStyle.Format = "C2"
            DG_Ventas.Columns("Cliente").DefaultCellStyle.NullValue = "No Disponible"
            DG_Ventas.Refresh()
            lbl_Msg.Visible = False
        Else
            DG_Ventas.DataSource = Nothing
            DG_Ventas.Refresh()
            lbl_Msg.Visible = True
        End If
    End Sub

    'Click en "Ver Detalle de Factura"
    Private Sub BtnComisiones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFactura.Click
        Me.Cursor = Cursors.WaitCursor
        Funciones.ControlInstancia(frmVerFactura).MdiParent = MDIContenedor
        Funciones.ControlInstancia(frmVerFactura).Show()
        Me.Cursor = Cursors.Arrow
    End Sub

    'Boton reestablecer.
    Private Sub btn_Restablecer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Restablecer.Click
        'Cambio el cursor a "WAIT"
        Me.Cursor = Cursors.WaitCursor

        'Seteo fechas.
        FDesde.Value = Now.Date.AddDays(-30)
        FHasta.Value = Now.Date

        'Limpio los filtros
        txtFacturaDesde.Clear()
        txtFacturaHasta.Clear()
        txtMontoDesde.Clear()
        txtMontoHasta.Clear()
        ChkAnuladoNo.Checked = True
        ChkAnuladoSi.Checked = True
        chkMayor.Checked = True
        chkMenor.Checked = True
        ChkMarcaElectronica.Checked = True
        ChkMarcaManual.Checked = True
        ChkMarcaSinFacturar.Checked = True
        ChkMarcaTicket.Checked = True

        'Cargo el datagrid
        Dim dsVentas As New DataSet
        dsVentas = NegVentas.ListadoVentasCompletoFecha(id_Sucursal, FDesde.Value.ToString("yyyy/MM/dd"), FHasta.Value.ToString("yyyy/MM/dd"))

        If dsVentas.Tables(0).Rows.Count > 0 Then
            DG_Ventas.DataSource = dsVentas.Tables(0)
            DG_Ventas.AutoGenerateColumns = False
            DG_Ventas.ColumnHeadersVisible = True
            DG_Ventas.Columns("id_Venta").Visible = False
            DG_Ventas.Columns("Descuento").Visible = False
            DG_Ventas.Columns("MontoTotal").DefaultCellStyle.Format = "C2"
            DG_Ventas.Columns("Cliente").DefaultCellStyle.NullValue = "No Disponible"
            DG_Ventas.Refresh()
            lbl_Msg.Visible = False
        Else
            DG_Ventas.DataSource = Nothing
            DG_Ventas.Refresh()
            lbl_Msg.Visible = True
        End If

        'Cambio el cursor a NORMAL.
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub BtnEmitirFactura_Click(sender As Object, e As EventArgs) Handles BtnEmitirFactura.Click
        'Seteo el cursor.
        Me.Cursor = Cursors.WaitCursor

        If (TipoCliente() = Entidades.TipoCliente.Minorista) Then
            'Abro el form de datos de facturacion.
            Dim frmFacturar As frmFacturar = New frmFacturar()
            frmFacturar.id_Venta = id_VentaDetalle
            frmFacturar.Monto = MontoTotalDetalle
            frmFacturar.Descuento = DescuentoDetalle - MontoSenia
            frmFacturar.SubTotal = SubTotalDetalle
            frmFacturar.TipoPago = TipoPagoDetalle
            frmFacturar.TipoCliente = TipoCliente.Minorista
            frmFacturar.EsSenia = False
            frmFacturar.PorcentajeFacturacion = 1
            frmFacturar.ShowDialog()
        Else

            Dim MontoSeñaSinIva As Double = MontoSenia / ((0.21 * porcentajeFacturacion) + 1)
            Dim DescuentoTotal As Double = DescuentoDetalle + MontoSeñaSinIva
            'Abro el form de datos de facturacion.
            Dim frmFacturar As frmFacturar = New frmFacturar()
            frmFacturar.id_Venta = id_VentaDetalle
            frmFacturar.id_Cliente = id_Cliente
            frmFacturar.Descuento = Math.Round(DescuentoTotal * porcentajeFacturacion, 2)
            frmFacturar.SubTotal = Math.Round((SubTotalDetalle - DescuentoTotal) * porcentajeFacturacion, 2)
            frmFacturar.IvaTotal = Math.Round(frmFacturar.SubTotal * 0.21, 2)
            frmFacturar.Monto = Math.Round(frmFacturar.SubTotal + frmFacturar.IvaTotal, 2)
            frmFacturar.TipoPago = TipoPagoDetalle
            frmFacturar.TipoCliente = TipoCliente.Mayorista
            frmFacturar.EsSenia = False
            frmFacturar.PorcentajeFacturacion = porcentajeFacturacion
            frmFacturar.ShowDialog()
        End If

        'Seteo el cursor.
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub DG_Ventas_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DG_Ventas.CellFormatting
        If (e.ColumnIndex = DG_Ventas.Columns("NumFactura").Index And Not e.Value Is DBNull.Value) Then
            e.Value = e.Value.ToString().PadLeft(10, "0")
        End If
    End Sub

    Private Sub txtImporteDesde_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFacturaDesde.KeyPress, txtFacturaHasta.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtMontoHasta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMontoHasta.KeyPress, txtMontoDesde.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloCurrency(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Sub EvaluarPermisos()
        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Ventas_Administración_Detalle_Visualizar)) Then

        Else
            TabVentas.TabPages.Remove(TabVentas.TabPages("TbDetalle"))
            RemoveHandler DG_Ventas.CellDoubleClick, AddressOf DG_Ventas_CellDoubleClick
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Ventas_Administración_Detalle_Anular)) Then
            BtnAnular.Enabled = True
        Else
            BtnAnular.Enabled = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Ventas_Administración_Detalle_Facturar)) Then
            BtnFactura.Enabled = True
        Else
            BtnFactura.Enabled = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Ventas_Administración_Detalle_NotaCrédito)) Then
            BtnEmitirFactura.Enabled = True
        Else
            BtnEmitirFactura.Enabled = False
        End If
    End Sub

    Private Function TipoCliente() As TipoCliente
        If (lblVenta.Text = "Minorista") Then
            Return TipoCliente.Minorista
        Else
            Return TipoCliente.Mayorista
        End If
    End Function

End Class