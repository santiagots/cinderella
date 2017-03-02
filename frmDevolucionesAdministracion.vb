Imports Entidades

Public Class frmDevolucionesAdministracion
    Dim NegDevolucion As New Negocio.NegDevolucion
    Dim NegStock As New Negocio.NegStock
    Dim NegComisiones As New Negocio.NegComisiones
    Dim id_Sucursal As String
    Dim eDevolucion As New Entidades.Devolucion
    Dim Funciones As New Funciones

    Dim id_DevolucionDetalle As Integer = 0
    Dim MontoTotalDetalle As Double = 0
    Dim DescuentoDetalle As Double = 0
    Dim SubTotalDetalle As Double = 0
    Dim TipoPagoDetalle As String = String.Empty

    Private Sub frmDevolucionesAdministracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            'seteo el font a 8px
            DG_Devolucion.AlternatingRowsDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DG_Devolucion.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DG_Devolucion.RowHeadersDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DG_Devolucion.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

            'seteo las imagenes
            Dim ListaImagenes = New ImageList
            ListaImagenes.ImageSize = New Size(32, 32)
            ListaImagenes.TransparentColor = Color.Blue
            ListaImagenes.ColorDepth = ColorDepth.Depth32Bit
            ListaImagenes.Images.Add(My.Resources.Recursos.Cambios_32)
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

            Dim TipoFactura As DataGridViewComboBoxColumn = DG_Devolucion.Columns("TipoNotaCredito")

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
            dsVentas = NegDevolucion.ListadoDevolucionesCompletoFecha(id_Sucursal, FDesde.Value.ToString("yyyy/MM/dd"), FHasta.Value.ToString("yyyy/MM/dd"))
            If dsVentas.Tables(0).Rows.Count > 0 Then
                DG_Devolucion.DataSource = dsVentas.Tables(0)
                DG_Devolucion.AutoGenerateColumns = False
                DG_Devolucion.ColumnHeadersVisible = True
                DG_Devolucion.Columns("id_Devolucion").Visible = False
                DG_Devolucion.Columns("Descuento").Visible = False
                DG_Devolucion.Columns("Empleado").DisplayIndex = 1
                DG_Devolucion.Columns("Cliente").DisplayIndex = 2
                DG_Devolucion.Columns("MontoTotal").DisplayIndex = 3
                DG_Devolucion.Columns("Fecha").DisplayIndex = 4
                DG_Devolucion.Columns("Anulado").DisplayIndex = 5
                DG_Devolucion.Columns("MontoTotal").DefaultCellStyle.Format = "C2"
                DG_Devolucion.Columns("Cliente").DefaultCellStyle.NullValue = "No Disponible"
                DG_Devolucion.Refresh()
                lbl_Msg.Visible = False
            Else
                DG_Devolucion.DataSource = Nothing
                DG_Devolucion.ColumnHeadersVisible = False
                DG_Devolucion.Refresh()
                lbl_Msg.Visible = True
            End If

            EvaluarPermisos()

            'Cambio el cursor a NORMAL.
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha encontrado un error al listar las devoluciones de la sucursal.", "Administración de Devoluciones", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnFiltrar_Click(sender As Object, e As EventArgs) Handles BtnFiltrar.Click
        'Cambio el cursor a "WAIT"
        Me.Cursor = Cursors.WaitCursor

        'Cargo el datagrid
        Dim dsVentas As New DataSet
        dsVentas = NegDevolucion.ListadoDevolucionesCompletoFecha(id_Sucursal, FDesde.Value.ToString("yyyy/MM/dd"), FHasta.Value.ToString("yyyy/MM/dd"))

        If dsVentas.Tables(0).Rows.Count > 0 Then
            DG_Devolucion.DataSource = dsVentas.Tables(0)
            DG_Devolucion.AutoGenerateColumns = False
            DG_Devolucion.ColumnHeadersVisible = True
            DG_Devolucion.Columns("id_Devolucion").Visible = False
            DG_Devolucion.Columns("Descuento").Visible = False
            DG_Devolucion.Columns("Empleado").DisplayIndex = 1
            DG_Devolucion.Columns("Cliente").DisplayIndex = 2
            DG_Devolucion.Columns("MontoTotal").DisplayIndex = 3
            DG_Devolucion.Columns("Fecha").DisplayIndex = 4
            DG_Devolucion.Columns("Anulado").DisplayIndex = 5
            DG_Devolucion.Columns("MontoTotal").DefaultCellStyle.Format = "C2"
            DG_Devolucion.Columns("Cliente").DefaultCellStyle.NullValue = "No Disponible"
            DG_Devolucion.Refresh()
            lbl_Msg.Visible = False
        Else
            DG_Devolucion.DataSource = Nothing
            DG_Devolucion.ColumnHeadersVisible = False
            DG_Devolucion.Refresh()
            lbl_Msg.Visible = True
        End If

        'Cambio el cursor a NORMAL.
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub btn_Restablecer_Click(sender As Object, e As EventArgs) Handles btn_Restablecer.Click
        'Cambio el cursor a "WAIT"
        Me.Cursor = Cursors.WaitCursor

        'Seteo fechas.
        FDesde.Value = Now.Date.AddDays(-30)
        FHasta.Value = Now.Date

        'Cargo el datagrid
        Dim dsVentas As New DataSet
        dsVentas = NegDevolucion.ListadoDevolucionesCompletoFecha(id_Sucursal, FDesde.Value.ToString("yyyy/MM/dd"), FHasta.Value.ToString("yyyy/MM/dd"))

        If dsVentas.Tables(0).Rows.Count > 0 Then
            DG_Devolucion.DataSource = dsVentas.Tables(0)
            DG_Devolucion.AutoGenerateColumns = False
            DG_Devolucion.ColumnHeadersVisible = True
            DG_Devolucion.Columns("id_Devolucion").Visible = False
            DG_Devolucion.Columns("Descuento").Visible = False
            DG_Devolucion.Columns("Empleado").DisplayIndex = 1
            DG_Devolucion.Columns("Cliente").DisplayIndex = 2
            DG_Devolucion.Columns("MontoTotal").DisplayIndex = 3
            DG_Devolucion.Columns("Fecha").DisplayIndex = 4
            DG_Devolucion.Columns("Anulado").DisplayIndex = 5
            DG_Devolucion.Columns("Facturado").DisplayIndex = 6
            DG_Devolucion.Columns("MontoTotal").DefaultCellStyle.Format = "C2"
            DG_Devolucion.Columns("Cliente").DefaultCellStyle.NullValue = "No Disponible"
            DG_Devolucion.Refresh()
            lbl_Msg.Visible = False
        Else
            DG_Devolucion.DataSource = Nothing
            DG_Devolucion.ColumnHeadersVisible = False
            DG_Devolucion.Refresh()
            lbl_Msg.Visible = True
        End If

        'Cambio el cursor a NORMAL.
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub DG_Ventas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_Devolucion.CellDoubleClick
        Try
            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            LimpiarFormulario()

            'Traigo la venta
            id_DevolucionDetalle = DG_Devolucion.Rows(e.RowIndex).Cells("id_Devolucion").Value()
            Dim dsDevolucionDetalle, dsDevolucion As DataSet
            dsDevolucion = NegDevolucion.TraerDevolucion(id_DevolucionDetalle)
            eDevolucion.id_Devolucion = id_DevolucionDetalle
            eDevolucion.id_Sucursal = dsDevolucion.Tables(0).Rows(0).Item("id_Sucursal").ToString
            eDevolucion.id_Empleado = dsDevolucion.Tables(0).Rows(0).Item("id_Empleado").ToString

            'Cargo los labels de la venta.
            If dsDevolucion.Tables(0).Rows.Count <> 0 Then
                lblCantidad.Text = dsDevolucion.Tables(0).Rows(0).Item("Cantidad_Total").ToString
                lblFecha.Text = dsDevolucion.Tables(0).Rows(0).Item("Fecha").ToString
                lblSucursal.Text = dsDevolucion.Tables(0).Rows(0).Item("Sucursal").ToString
                lblDevolucion.Text = dsDevolucion.Tables(0).Rows(0).Item("TiposDevolucion").ToString
                TipoPagoDetalle = dsDevolucion.Tables(0).Rows(0).Item("TiposPago").ToString
                lblPago.Text = TipoPagoDetalle

                MontoTotalDetalle = CType(dsDevolucion.Tables(0).Rows(0).Item("Precio_Total").ToString, Decimal)
                DescuentoDetalle = CType(dsDevolucion.Tables(0).Rows(0).Item("Descuento").ToString, Decimal)
                SubTotalDetalle = CType(dsDevolucion.Tables(0).Rows(0).Item("Subtotal").ToString, Decimal)

                CargarTotales(MontoTotalDetalle, DescuentoDetalle, SubTotalDetalle)

                If dsDevolucion.Tables(0).Rows(0).Item("RazonSocial").ToString <> "" Then
                    lblCliente.Text = dsDevolucion.Tables(0).Rows(0).Item("RazonSocial").ToString
                Else
                    lblCliente.Text = "- - - - - "
                End If

                If dsDevolucion.Tables(0).Rows(0).Item("Empleado").ToString <> "" Then
                    lblVendedor.Text = dsDevolucion.Tables(0).Rows(0).Item("Empleado").ToString
                Else
                    lblVendedor.Text = "- - - - - "
                End If

                If dsDevolucion.Tables(0).Rows(0).Item("Encargado").ToString <> "" Then
                    lblEncargado.Text = dsDevolucion.Tables(0).Rows(0).Item("Encargado").ToString
                Else
                    lblEncargado.Text = "- - - - - "
                End If

                Dim TipoNotaCredito As Integer = Integer.Parse(dsDevolucion.Tables(0).Rows(0).Item("NotaCredito").ToString)

                If TipoNotaCredito >= 0 Then
                    lblNotaCredito.Text = [Enum].GetName(GetType(Entidades.TipoFactura), TipoNotaCredito)
                    BtnNotaCredito.Visible = True
                    BtnEmitirFactura.Visible = False
                    FrmVerNotaCredito.id_Devolucion = id_DevolucionDetalle
                Else
                    lblNotaCredito.Text = "NO"
                    BtnNotaCredito.Visible = False
                    BtnEmitirFactura.Visible = True
                End If

                If dsDevolucion.Tables(0).Rows(0).Item("Anulado").ToString = "1" Then
                    lblAnulado.Text = "VENTA ANULADA EL " & String.Format("{0:d}", CDate(dsDevolucion.Tables(0).Rows(0).Item("FechaAnulado"))) & vbCrLf & Replace(Trim(dsDevolucion.Tables(0).Rows(0).Item("DescripcionAnulado").ToString), "<br />", vbCrLf)
                    lblAnulado.Visible = True
                    Gb_Anulado.Visible = False
                Else
                    lblAnulado.Visible = False
                    Gb_Anulado.Visible = True
                    txtDescripcionAnular.Clear()
                End If

                'Detalle de la venta.
                dsDevolucionDetalle = NegDevolucion.TraerDevolucionDetalle(id_DevolucionDetalle)
                For Each devolucionDetalle In dsDevolucionDetalle.Tables(0).Rows
                    'Inserto la fila
                    AgregarProducto(devolucionDetalle)
                Next
            End If

            'Cambio el cursor a NORMAL.
            Me.Cursor = Cursors.Arrow

            'hago foco en el tab_modificacion 
            TabVentas.SelectedTab = TabVentas.TabPages("TbDetalle")
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha encontrado un error al obtener la devolución.", "Administración de Devoluciones", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CargarTotales(MontoTotalDetalle As Double, DescuentoDetalle As Double, SubTotalDetalle As Double)
        If TipoDevolucion() = TipoCliente.Minorista Then
            CargarTotalesMinorista(MontoTotalDetalle, DescuentoDetalle, SubTotalDetalle)
            PanelTotalMayorista.Visible = False
            PanelTotalMinorista.Visible = True
        Else
            CargarTotalesMayorista(MontoTotalDetalle, DescuentoDetalle, SubTotalDetalle)
            PanelTotalMayorista.Visible = True
            PanelTotalMinorista.Visible = False
            PanelTotalMayorista.Location = PanelTotalMinorista.Location
        End If
    End Sub

    Private Sub AgregarProducto(ventaDetalle As Object)
        Dim precio As Decimal = CType(ventaDetalle.item("Precio").ToString, Decimal)

        If TipoDevolucion() = TipoCliente.Minorista Then
            AgregarProducto(ventaDetalle, 0, 0, precio)
        Else
            AgregarProducto(ventaDetalle, precio / 1.21, (precio / 1.21) * 0.21, precio)
        End If

    End Sub

    Private Sub AgregarProducto(ventaDetalle As Object, precio As Decimal, iva As Decimal, monto As Decimal)
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
        dgvCell.Value = Format(precio, "###0.00")
        'dgvCell.Value = Format(0, "###0.00")
        dgvRow.Cells.Add(dgvCell)

        'Valor de la Columna IVA
        dgvCell = New DataGridViewTextBoxCell()
        dgvCell.Value = Format(iva, "###0.00")
        'dgvCell.Value = Format(0, "###0.00")
        dgvRow.Cells.Add(dgvCell)

        'Valor de la Columna Monto
        dgvCell = New DataGridViewTextBoxCell()
        dgvCell.Value = Format(monto, "###0.00")
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

    Private Sub CargarTotalesMinorista(MontoTotalDetalle As Double, DescuentoDetalle As Double, SubTotalDetalle As Double)
        lblMontoMinorista.Text = "$ " & Format(MontoTotalDetalle, "###0.00")
        lblDescuentoMinorista.Text = "$ " & Format(DescuentoDetalle, "###0.00")
        lblSubtotalMinorista.Text = "$ " & Format(SubTotalDetalle, "###0.00")
    End Sub

    Private Sub CargarTotalesMayorista(MontoTotalDetalle As Double, DescuentoDetalle As Double, SubTotalDetalle As Double)
        lblDescuentoMayorista.Text = "$ " & Format(DescuentoDetalle, "###0.00")
        lblSubtotalMayorista.Text = "$ " & Format(SubTotalDetalle, "###0.00")
        lblIVAMayorista.Text = "$ " & Format(SubTotalDetalle * 0.21, "###0.00")
        lblMontoMayorista.Text = "$ " & Format(MontoTotalDetalle, "###0.00")
    End Sub

    Private Sub BtnAnular_Click(sender As Object, e As EventArgs) Handles BtnAnular.Click
        Dim Result As DialogResult
        Dim ResultadoAnulado As Integer
        Result = MessageBox.Show("¿Está seguro que desea anular la devolución?", "Administración de Devoluciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Result = System.Windows.Forms.DialogResult.Yes Then 'Si acepta anular la venta
            'Cambio el cursor a "WAIT"
            TabVentas.Cursor = Cursors.WaitCursor

            Try
                'Actualizo el Producto.
                Dim TextoAnulado As String = Replace(Trim(txtDescripcionAnular.Text), vbCrLf, "<br />")
                ResultadoAnulado = NegDevolucion.AnularDevolucion(eDevolucion.id_Devolucion, TextoAnulado)

                If ResultadoAnulado = 1 Then 'Se anulo la venta en productos correctamente.

                    'Actualizo el Stock.
                    Dim dsVentasDetalle As DataSet
                    dsVentasDetalle = NegDevolucion.TraerDevolucionDetalle(eDevolucion.id_Devolucion)
                    For Each ventaDetalle In dsVentasDetalle.Tables(0).Rows
                        NegStock.AgregarStock(ventaDetalle.item("id_Producto").ToString(), eDevolucion.id_Sucursal, -Integer.Parse(ventaDetalle.item("Cantidad").ToString()))
                    Next

                    'Limpio Formulario
                    txtDescripcionAnular.Clear()
                    Gb_Anulado.Visible = False
                    lblAnulado.Visible = True
                    lblAnulado.Text = "DEVOLUCIÓN ANULADA EL " & String.Format("{0:d}", DateTime.Now)

                    'Muestro el resultado
                    MessageBox.Show("Se ha anulado la devolución correctamente.", "Administración de Devoluciones", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else

                    'Muestro el resultado
                    MessageBox.Show("No ha podido ser anulada la devolución. Por favor, intente más tarde o contactese con el administrador.", "Administración de Devoluciones", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If

            Catch ex As Exception
                'Muestro el resultado
                MessageBox.Show("Se ha encontrado un error al anular la devolución. Por favor, contactese con el administrador.", "Administración de Devoluciones", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            'Cambio el cursor a NORMAL.
            TabVentas.Cursor = Cursors.Arrow
        End If
    End Sub

    'Limpia el formulario.
    Sub LimpiarFormulario()
        DG_Productos.Rows.Clear()
        lblCantidad.Text = "- - - - -"
        lblMontoMayorista.Text = "- - - - -"
        lblFecha.Text = "- - - - -"
        lblSucursal.Text = "- - - - -"
        lblVendedor.Text = "- - - - -"
        lblDevolucion.Text = "- - - - -"
        lblPago.Text = "- - - - -"
        lblNotaCredito.Text = "- - - - -"
        lblCliente.Text = "- - - - -"
        lblAnulado.Visible = False
        BtnNotaCredito.Visible = False
        Gb_Anulado.Visible = False
    End Sub

    Private Sub BtnNotaCredito_Click(sender As Object, e As EventArgs) Handles BtnNotaCredito.Click
        Me.Cursor = Cursors.WaitCursor
        Funciones.ControlInstancia(FrmVerNotaCredito).MdiParent = MDIContenedor
        Funciones.ControlInstancia(FrmVerNotaCredito).Show()
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub DG_Devolucion_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DG_Devolucion.CellFormatting
        If (e.ColumnIndex = DG_Devolucion.Columns("NumeroNotaCredito").Index And Not e.Value Is DBNull.Value) Then
            e.Value = e.Value.ToString().PadLeft(10, "0")
        End If
    End Sub

    Private Sub BtnEmitirFactura_Click(sender As Object, e As EventArgs) Handles BtnEmitirFactura.Click
        'Seteo el cursor.
        Me.Cursor = Cursors.WaitCursor

        'Abro el form de datos de facturacion.
        frmFacturar.id_Devolucion = id_DevolucionDetalle
        frmFacturar.Monto = MontoTotalDetalle
        frmFacturar.Descuento = DescuentoDetalle
        frmFacturar.MontoSinDescuento = SubTotalDetalle
        frmFacturar.TipoPago = TipoPagoDetalle
        frmFacturar.NotaCredito = True
        frmFacturar.TipoCliente = TipoDevolucion()
        Funciones.ControlInstancia(frmFacturar).Show()

        'Seteo el cursor.
        Me.Cursor = Cursors.Arrow
    End Sub

    Sub EvaluarPermisos()
        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Devoluciones_Administración_Detalle_Visualizar)) Then

        Else
            TabVentas.TabPages.Remove(TabVentas.TabPages("TbDetalle"))
            RemoveHandler DG_Devolucion.CellDoubleClick, AddressOf DG_Ventas_CellDoubleClick
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Devoluciones_Administración_Detalle_Anular)) Then
            BtnAnular.Enabled = True
        Else
            BtnAnular.Enabled = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Devoluciones_Administración_Detalle_NotaCrédito)) Then
            BtnNotaCredito.Enabled = True
        Else
            BtnNotaCredito.Enabled = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Devoluciones_Administración_Detalle_Facturar)) Then
            BtnEmitirFactura.Enabled = True
        Else
            BtnEmitirFactura.Enabled = False
        End If
    End Sub

    Private Function TipoDevolucion() As TipoCliente
        If (lblDevolucion.Text = "Minorista") Then
            Return TipoCliente.Minorista
        Else
            Return TipoCliente.Mayorista
        End If
    End Function
End Class