Public Class frmVentasAdministracion
    Dim NegVentas As New Negocio.NegVentas
    Dim NegStock As New Negocio.NegStock
    Dim NegComisiones As New Negocio.NegComisiones
    Dim id_Sucursal As String
    Dim eVentas As New Entidades.Ventas
    Dim Funciones As New Funciones
    Dim NegErrores As New Negocio.NegManejadorErrores

    Dim id_VentaDetalle As Integer = 0
    Dim MontoTotalDetalle As Double = 0
    Dim DescuentoDetalle As Double = 0
    Dim SubTotalDetalle As Double = 0
    Dim TipoPagoDetalle As String = String.Empty

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
            Dim dsVentas As New DataSet
            dsVentas = NegVentas.ListadoVentasCompletoFecha(id_Sucursal, FDesde.Value.ToString("yyyy/MM/dd"), FHasta.Value.ToString("yyyy/MM/dd"))
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

                DG_Ventas.DataSource = dsVentas.Tables(0)
                DG_Ventas.AutoGenerateColumns = False
                DG_Ventas.ColumnHeadersVisible = True
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
                MontoTotalDetalle = CType(dsVentas.Tables(0).Rows(0).Item("Precio_Total").ToString, Decimal)
                lblMonto.Text = "$ " & Format(MontoTotalDetalle, "###0.00")
                lblFecha.Text = dsVentas.Tables(0).Rows(0).Item("Fecha").ToString
                lblSucursal.Text = dsVentas.Tables(0).Rows(0).Item("Sucursal").ToString
                SubTotalDetalle = CType(dsVentas.Tables(0).Rows(0).Item("Subtotal").ToString, Decimal)
                lblSubtotal.Text = "$ " & Format(SubTotalDetalle, "###0.00")
                DescuentoDetalle = CType(dsVentas.Tables(0).Rows(0).Item("Descuento").ToString, Decimal)
                lblDescuento.Text = "$ " & Format(DescuentoDetalle, "###0.00")
                lblVenta.Text = dsVentas.Tables(0).Rows(0).Item("TiposVenta").ToString
                TipoPagoDetalle = dsVentas.Tables(0).Rows(0).Item("TiposPago").ToString
                lblPago.Text = TipoPagoDetalle

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

                    'Creo la fila del producto.
                    Dim dgvRow As New DataGridViewRow
                    Dim dgvCell As DataGridViewCell

                    'Valor de la Columna Numero
                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = DG_Productos.Rows.Count + 1
                    dgvRow.Cells.Add(dgvCell)

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
                    dgvCell.Value = Format(CType(ventaDetalle.item("Precio").ToString, Decimal), "###0.00")
                    dgvRow.Cells.Add(dgvCell)

                    'Valor de la Columna Subtotal
                    dgvCell = New DataGridViewTextBoxCell()
                    dgvCell.Value = ventaDetalle.item("Precio").ToString * ventaDetalle.item("Cantidad").ToString
                    dgvRow.Cells.Add(dgvCell)

                    dgvRow.Height = "20"

                    'Inserto la fila
                    DG_Productos.Rows.Add(dgvRow)
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

    'Cuando realiza click en anular venta.
    Private Sub BtnAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAnular.Click
        Dim Result As DialogResult
        Dim ResultadoAnulado As Integer
        Result = MessageBox.Show("¿Está seguro que desea anular la venta?", "Administración de Ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Result = System.Windows.Forms.DialogResult.Yes Then 'Si acepta anular la venta
            'Cambio el cursor a "WAIT"
            TabVentas.Cursor = Cursors.WaitCursor

            Try
                'Actualizo el Producto.
                Dim TextoAnulado As String = Replace(Trim(txtDescripcionAnular.Text), vbCrLf, "<br />")
                ResultadoAnulado = NegVentas.AnularVenta(eVentas.id_Venta, TextoAnulado)

                If ResultadoAnulado = 1 Then 'Se anulo la venta en productos correctamente.

                    'Actualizo el Stock.
                    Dim dsVentasDetalle As DataSet
                    dsVentasDetalle = NegVentas.TraerVentaDetalle(eVentas.id_Venta)
                    For Each ventaDetalle In dsVentasDetalle.Tables(0).Rows
                        NegStock.AgregarStock(ventaDetalle.item("id_Producto").ToString(), eVentas.id_Sucursal, ventaDetalle.item("Cantidad").ToString())
                    Next

                    'Actualizo las comisiones.
                    NegComisiones.AnularComisiones(eVentas.id_Empleado, eVentas.id_Sucursal, eVentas.id_Venta)

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

            Catch ex As Exception
                'Muestro el resultado
                MessageBox.Show("Se ha encontrado un error al anular la venta. Por favor, contactese con el administrador.", "Administración de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            'Cambio el cursor a NORMAL.
            TabVentas.Cursor = Cursors.Arrow
        End If
    End Sub

    'Limpia el formulario.
    Sub LimpiarFormulario()
        DG_Productos.Rows.Clear()
        lblCantidad.Text = "- - - - -"
        lblMonto.Text = "- - - - -"
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

        'Cargo el datagrid
        Dim dsVentas As New DataSet
        dsVentas = NegVentas.ListadoVentasCompletoFecha(id_Sucursal, FDesde.Value.ToString("yyyy/MM/dd"), FHasta.Value.ToString("yyyy/MM/dd"))

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

        'Abro el form de datos de facturacion.
        frmFacturar.id_Venta = id_VentaDetalle
        frmFacturar.Monto = MontoTotalDetalle
        frmFacturar.Descuento = DescuentoDetalle
        frmFacturar.MontoSinDescuento = SubTotalDetalle
        frmFacturar.TipoPago = TipoPagoDetalle
        Funciones.ControlInstancia(frmFacturar).Show()

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
End Class