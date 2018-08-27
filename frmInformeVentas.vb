Imports System.Windows.Forms.DataVisualization.Charting
Imports Entidades
Imports Negocio

Public Class frmInformeVentas
    Dim NegSucursales As NegSucursales = New NegSucursales()
    Dim datosProductos As List(Of InformeProductos) = New List(Of InformeProductos)()
    Private Sub frmInformeVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim Sucursales As List(Of Sucursales) = NegSucursales.ListadoSucursalesEntidad()
            cklSucursales.DataSource = sucursales
            cklSucursales.DisplayMember = "Nombre"
            cklSucursales.ValueMember = "id_Sucursal"

            For i = 0 To cklSucursales.Items.Count - 1
                cklSucursales.SetItemChecked(i, True)
            Next

            dtpFechaDesde.Value = Date.Now.AddDays(-30)

            BuscarDatos()

            Me.Cursor = Cursors.Arrow
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LimpiarInformes()
        BuscarDatos()
    End Sub

    Private Sub ucPaginadoProductos_btnInicioClick(sender As Object, e As EventArgs) Handles ucPaginadoProductos.btnInicioClick
        Dim sucursalesId As List(Of Integer) = cklSucursales.CheckedItems.Cast(Of Sucursales).Select(Function(x) x.id_Sucursal).ToList()
        Dim fechaDesde As Date = dtpFechaDesde.Value
        Dim fechaHasta As Date = dtpFechaHasta.Value
        datosProductos = NegInformes.ObtenerProductos(sucursalesId, fechaDesde, fechaHasta, ucPaginadoProductos.PaginaActual, ucPaginadoProductos.TotalPagina)
        TotalProductos(datosProductos)
    End Sub

    Private Sub ucPaginadoProductos_btnFinClick(sender As Object, e As EventArgs) Handles ucPaginadoProductos.btnFinClick
        Dim sucursalesId As List(Of Integer) = cklSucursales.CheckedItems.Cast(Of Sucursales).Select(Function(x) x.id_Sucursal).ToList()
        Dim fechaDesde As Date = dtpFechaDesde.Value
        Dim fechaHasta As Date = dtpFechaHasta.Value
        datosProductos = NegInformes.ObtenerProductos(sucursalesId, fechaDesde, fechaHasta, ucPaginadoProductos.PaginaActual, ucPaginadoProductos.TotalPagina)
        TotalProductos(datosProductos)
    End Sub

    Private Sub ucPaginadoProductos_btnProximaClick(sender As Object, e As EventArgs) Handles ucPaginadoProductos.btnProximaClick
        Dim sucursalesId As List(Of Integer) = cklSucursales.CheckedItems.Cast(Of Sucursales).Select(Function(x) x.id_Sucursal).ToList()
        Dim fechaDesde As Date = dtpFechaDesde.Value
        Dim fechaHasta As Date = dtpFechaHasta.Value
        datosProductos = NegInformes.ObtenerProductos(sucursalesId, fechaDesde, fechaHasta, ucPaginadoProductos.PaginaActual, ucPaginadoProductos.TotalPagina)
        TotalProductos(datosProductos)
    End Sub

    Private Sub ucPaginadoProductos_btnAnteriorClick(sender As Object, e As EventArgs) Handles ucPaginadoProductos.btnAnteriorClick
        Dim sucursalesId As List(Of Integer) = cklSucursales.CheckedItems.Cast(Of Sucursales).Select(Function(x) x.id_Sucursal).ToList()
        Dim fechaDesde As Date = dtpFechaDesde.Value
        Dim fechaHasta As Date = dtpFechaHasta.Value
        datosProductos = NegInformes.ObtenerProductos(sucursalesId, fechaDesde, fechaHasta, ucPaginadoProductos.PaginaActual, ucPaginadoProductos.TotalPagina)
        TotalProductos(datosProductos)
    End Sub

    Private Sub LimpiarInformes()
        chtTotalPorCliente.Series("Cliente").Points.Clear()

        chtTotalFormaPago.Series("FormaPago").Points.Clear()
        chtTotalMayorista.Series("Mayorista").Points.Clear()
        chtTotalMinorista.Series("Minorista").Points.Clear()

        chtFacturado.Series("Facturado").Points.Clear()

        chtTotalCuotas.Series("Cuotas").Points.Clear()

        chtProductosMonto.Series("producto").Points.Clear()
        chtProductosCantidad.Series("producto").Points.Clear()

        chtSubCategoriasMonto.Series("subCategoria").Points.Clear()
        chtSubCategoriasCantidad.Series("subCategoria").Points.Clear()

        chtVentaEvolucion.Series("Monto").Points.Clear()
        chtVentaEvolucion.Series("Cantidad").Points.Clear()

        chtProductosEvolucion.Series("Monto").Points.Clear()
        chtProductosEvolucion.Series("Cantidad").Points.Clear()

        chtSubcategoriaEvolucion.Series("Monto").Points.Clear()
        chtSubcategoriaEvolucion.Series("Cantidad").Points.Clear()

        dgvTotalVentas.DataSource = Nothing
        dgvFacturado.DataSource = Nothing
        dgvProductoEvolucion.DataSource = New DataTable()
        dgvSubproductoEvolucion.DataSource = New DataTable()
        dgvProductos.DataSource = Nothing
        dgvSubCategorias.DataSource = Nothing
        dgvTotalFormaPago.DataSource = Nothing
        dgvTotalPorCliente.DataSource = Nothing
        dgvVentaEvolucion.DataSource = Nothing
    End Sub

    Private Sub BuscarDatos()
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim sucursalesId As List(Of Integer) = cklSucursales.CheckedItems.Cast(Of Sucursales).Select(Function(x) x.id_Sucursal).ToList()
            Dim fechaDesde As Date = dtpFechaDesde.Value
            Dim fechaHasta As Date = dtpFechaHasta.Value

            Dim datosVentas As List(Of InformeVenta) = NegInformes.ObtenerVentas(sucursalesId, fechaDesde, fechaHasta)
            Dim datosCuotas As List(Of InformeCuotas) = NegInformes.ObtenerCantidadCuotas(sucursalesId, fechaDesde, fechaHasta)
            datosProductos = NegInformes.ObtenerProductos(sucursalesId, fechaDesde, fechaHasta, 1, 100)
            Dim datosSubcategoria As List(Of InformeSubcategoria) = NegInformes.ObtenerSubcategorias(sucursalesId, fechaDesde, fechaHasta, 1, 100)

            TotalGeneralVentas(datosVentas)
            TotalVentasPorTipoCliente(datosVentas)
            TotalVentasPorFormaDePago(datosVentas)
            TotalVentasPorFacturacion(datosVentas)
            TotalCuotas(datosCuotas)
            TotalProductos(datosProductos)
            TotalSubCategrias(datosSubcategoria)
            EvolucionVentas(datosProductos)
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TotalGeneralVentas(datos As List(Of InformeVenta))
        Dim montoTotal As Decimal = datos.Sum(Function(x) x.MontoTotal)
        Dim cantidadTotal As Decimal = datos.Sum(Function(x) x.CantidadTotal)
        Dim promedioVentas As Double = If(cantidadTotal > 0, montoTotal / cantidadTotal, 0)

        Dim dt As DataTable = New DataTable()
        dt.Columns.Add("Detalle")
        dt.Columns.Add("Monto")
        dt.Columns.Add("Cantidad")

        dt.Rows.Add("Total Ventas", Math.Round(montoTotal, 2).ToString("c"), cantidadTotal)
        dt.Rows.Add("Promedio Ventas", Math.Round(promedioVentas, 2).ToString("c"), "")

        dgvTotalVentas.DataSource = dt
    End Sub

    Private Sub TotalVentasPorTipoCliente(datos As List(Of InformeVenta))
        Dim montoTotalMinorista As Decimal = datos.Where(Function(x) x.TipoCliente = "Minorista").Sum(Function(x) x.MontoTotal)
        Dim cantidadTotalMinorista As Decimal = datos.Where(Function(x) x.TipoCliente = "Minorista").Sum(Function(x) x.CantidadTotal)
        Dim promedioVentasMinorista As Decimal = If(cantidadTotalMinorista > 0, montoTotalMinorista / cantidadTotalMinorista, 0)

        Dim montoTotalMayorista As Decimal = datos.Where(Function(x) x.TipoCliente = "Mayorista").Sum(Function(x) x.MontoTotal)
        Dim cantidadTotalMayorista As Decimal = datos.Where(Function(x) x.TipoCliente = "Mayorista").Sum(Function(x) x.CantidadTotal)
        Dim promedioVentasMayorista As Decimal = If(cantidadTotalMayorista > 0, montoTotalMayorista / cantidadTotalMayorista, 0)



        Dim dataPoint As DataPoint = chtTotalPorCliente.Series("Cliente").Points.Add(cantidadTotalMinorista)
        dataPoint.AxisLabel = "Minorista"
        dataPoint.LegendText = "Minorista"
        dataPoint.Label = "#PERCENT{0 %}"

        Dim dataPoint2 As DataPoint = chtTotalPorCliente.Series("Cliente").Points.Add(cantidadTotalMayorista)
        dataPoint2.AxisLabel = "Mayorista"
        dataPoint2.LegendText = "Mayorista"
        dataPoint2.Label = "#PERCENT{0 %}"

        Dim dt As DataTable = New DataTable()
        dt.Columns.Add("Detalle")
        dt.Columns.Add("Monto")
        dt.Columns.Add("Cantidad")

        dt.Rows.Add("Total Ventas Minorista", Math.Round(montoTotalMinorista, 2).ToString("c"), cantidadTotalMinorista)
        dt.Rows.Add("Promedio Ventas Minorista", Math.Round(promedioVentasMinorista, 2).ToString("c"), "")
        dt.Rows.Add("Total Ventas Mayorista", Math.Round(montoTotalMayorista, 2).ToString("c"), cantidadTotalMayorista)
        dt.Rows.Add("Promedio Ventas Minorista", Math.Round(promedioVentasMayorista, 2).ToString("c"), "")

        dgvTotalPorCliente.DataSource = dt
    End Sub

    Private Sub TotalVentasPorFormaDePago(datos As List(Of InformeVenta))

        Dim dt As DataTable = New DataTable()
        dt.Columns.Add("Grupo")
        dt.Columns.Add("Detalle")
        dt.Columns.Add("Monto")
        dt.Columns.Add("Cantidad")

        ''Agrupado por forma de pago
        Dim formasPago As List(Of IGrouping(Of String, InformeVenta)) = datos.GroupBy(Of String)(Function(x) x.FormaPago).ToList()

        For Each item As IGrouping(Of String, InformeVenta) In formasPago
            Dim total As Decimal = item.Sum(Function(x) x.MontoTotal)
            Dim cantidad As Decimal = item.Sum(Function(x) x.CantidadTotal)
            Dim dataPoint As DataPoint = chtTotalFormaPago.Series("FormaPago").Points.Add(total)
            dataPoint.AxisLabel = item.Key
            dataPoint.LegendText = item.Key
            dataPoint.Label = "#PERCENT{0 %}"

            dt.Rows.Add("Totales", item.Key, Math.Round(total, 2).ToString("c"), cantidad)
        Next

        ''Agrupado por tipo de cliente
        Dim tiposClientes As List(Of IGrouping(Of String, InformeVenta)) = datos.GroupBy(Of String)(Function(x) x.TipoCliente).ToList()

        For Each item As IGrouping(Of String, InformeVenta) In tiposClientes
            formasPago = item.GroupBy(Of String)(Function(x) x.FormaPago).ToList()
            For Each pagos As IGrouping(Of String, InformeVenta) In formasPago
                Dim dataPoint As DataPoint
                Dim total As Decimal = item.Sum(Function(x) x.MontoTotal)
                Dim cantidad As Decimal = item.Sum(Function(x) x.CantidadTotal)

                If item.Key = "Mayorista" Then
                    dataPoint = chtTotalMayorista.Series(item.Key).Points.Add(total)
                    dataPoint.AxisLabel = pagos.Key
                    dataPoint.LegendText = pagos.Key
                    dataPoint.Label = "#PERCENT{0 %}"

                    dt.Rows.Add("Mayorista", pagos.Key, Math.Round(total, 2).ToString("c"), cantidad)

                ElseIf item.Key = "Minorista" Then
                    dataPoint = chtTotalMinorista.Series(item.Key).Points.Add(total)
                    dataPoint.AxisLabel = pagos.Key
                    dataPoint.LegendText = pagos.Key
                    dataPoint.Label = "#PERCENT{0 %}"

                    dt.Rows.Add("Minorista", pagos.Key, Math.Round(total, 2).ToString("c"), cantidad)
                End If
            Next
        Next
        dgvTotalFormaPago.DataSource = Nothing
        dgvTotalFormaPago.DataSource = dt
    End Sub

    Private Sub TotalVentasPorFacturacion(datos As List(Of InformeVenta))
        Dim dt As DataTable = New DataTable()
        dt.Columns.Add("Detalle")
        dt.Columns.Add("Monto")
        dt.Columns.Add("Cantidad")



        ''Agrupado por facturado
        Dim facturados As List(Of IGrouping(Of String, InformeVenta)) = datos.GroupBy(Of String)(Function(x) x.Facturado).ToList()

        For Each item As IGrouping(Of String, InformeVenta) In facturados
            Dim total As Decimal = item.Sum(Function(x) x.MontoTotal)
            Dim cantidad As Decimal = item.Sum(Function(x) x.CantidadTotal)
            Dim dataPoint As DataPoint = chtFacturado.Series("Facturado").Points.Add(total)
            If item.Key = "1" Then
                dataPoint.AxisLabel = "Facturado"
                dataPoint.LegendText = "Facturado"
                dataPoint.Label = "#PERCENT{0 %}"
                dt.Rows.Add("Facturado", Math.Round(total, 2).ToString("c"), cantidad)
            Else
                dataPoint.AxisLabel = "Sin Facturar"
                dataPoint.LegendText = "Sin Facturar"
                dataPoint.Label = "#PERCENT{0 %}"
                dt.Rows.Add("Sin Facturar", Math.Round(total, 2).ToString("c"), cantidad)
            End If
        Next

        dgvFacturado.DataSource = Nothing
        dgvFacturado.DataSource = dt
    End Sub

    Private Sub TotalCuotas(datosCuotas As List(Of InformeCuotas))



        For Each item As InformeCuotas In datosCuotas
            Dim dataPoint As DataPoint = chtTotalCuotas.Series("Cuotas").Points.Add(item.Cantidad)
            dataPoint.AxisLabel = item.NroCuota
            dataPoint.LegendText = item.NroCuota
            dataPoint.Label = "#PERCENT{0 %}"
        Next
    End Sub

    Private Sub TotalProductos(datosProducto As List(Of InformeProductos))

        Dim dt As DataTable = New DataTable()
        dt.Columns.Add("Nombre")
        dt.Columns.Add("Monto", Type.GetType("System.Decimal"))
        dt.Columns.Add("Cantidad", Type.GetType("System.Int32"))

        Dim productos As List(Of InformeProductos) = datosProducto.OrderByDescending(Function(x) x.Monto).ToList()

        For Each producto As InformeProductos In productos
            dt.Rows.Add(producto.Nombre, Math.Round(producto.Monto, 2), producto.Cantidad)
        Next

        dgvProductos.DataSource = dt
        dgvProductos.Sort(dgvProductos.Columns(2), System.ComponentModel.ListSortDirection.Descending)

        productos = datosProducto.OrderByDescending(Function(x) x.Monto).Take(10).ToList()

        For Each producto As InformeProductos In productos
            Dim DataPointMonto As DataPoint = chtProductosMonto.Series("producto").Points.Add(producto.Monto)
            DataPointMonto.AxisLabel = producto.Nombre
            DataPointMonto.LegendText = producto.Nombre
            DataPointMonto.Label = "#PERCENT{0 %}"
        Next

        productos = datosProducto.OrderByDescending(Function(x) x.Cantidad).Take(10).ToList()

        For Each producto As InformeProductos In productos
            Dim DataPointCant As DataPoint = chtProductosCantidad.Series("producto").Points.Add(producto.Cantidad)
            DataPointCant.AxisLabel = producto.Nombre
            DataPointCant.LegendText = producto.Nombre
            DataPointCant.Label = "#PERCENT{0 %}"
        Next
    End Sub

    Private Sub TotalSubCategrias(datosSubcategoria As List(Of InformeSubcategoria))
        Dim dt As DataTable = New DataTable()
        dt.Columns.Add("Nombre")
        dt.Columns.Add("Monto", Type.GetType("System.Decimal"))
        dt.Columns.Add("Cantidad", Type.GetType("System.Int32"))

        Dim subcategorias As List(Of InformeSubcategoria) = datosSubcategoria.OrderByDescending(Function(x) x.Monto).ToList()

        For Each subcategoria As InformeSubcategoria In subcategorias
            dt.Rows.Add(subcategoria.Nombre, Math.Round(subcategoria.Monto, 2), subcategoria.Cantidad)
        Next

        dgvSubCategorias.DataSource = dt
        dgvSubCategorias.Sort(dgvSubCategorias.Columns(2), System.ComponentModel.ListSortDirection.Descending)

        subcategorias = datosSubcategoria.OrderByDescending(Function(x) x.Monto).Take(10).ToList()

        For Each subcategoria As InformeSubcategoria In subcategorias
            Dim DataPointMonto As DataPoint = chtSubCategoriasMonto.Series("subCategoria").Points.Add(subcategoria.Monto)
            DataPointMonto.AxisLabel = subcategoria.Nombre
            DataPointMonto.LegendText = subcategoria.Nombre
            DataPointMonto.Label = "#PERCENT{0 %}"
        Next

        subcategorias = datosSubcategoria.OrderByDescending(Function(x) x.Cantidad).Take(10).ToList()

        For Each subcategoria As InformeSubcategoria In subcategorias
            Dim DataPointCant As DataPoint = chtSubCategoriasCantidad.Series("producto").Points.Add(subcategoria.Cantidad)
            DataPointCant.AxisLabel = subcategoria.Nombre
            DataPointCant.LegendText = subcategoria.Nombre
            DataPointCant.Label = "#PERCENT{0 %}"
        Next
    End Sub

    Private Sub EvolucionVentas(datosProducto As List(Of InformeProductos))

        'Dim dt As DataTable = New DataTable()
        'dt.Columns.Add("Fecha")
        'dt.Columns.Add("Monto")
        'dt.Columns.Add("Cantidad")

        'Dim montoValues As List(Of Decimal) = New List(Of Decimal)()
        'Dim cantidadValues As List(Of Decimal) = New List(Of Decimal)()

        'Dim ventasPorFecha As List(Of IGrouping(Of Date, InformeProductos)) = datosProducto.GroupBy(Of Date)(Function(x) x.Fecha).ToList()

        'For Each ventasFecha As IGrouping(Of Date, InformeProductos) In ventasPorFecha
        '    Dim monto As Decimal = ventasFecha.Sum(Function(x) x.Monto * x.Cantidad)
        '    Dim cantidad As Decimal = ventasFecha.Sum(Function(x) x.Cantidad)

        '    montoValues.Add(monto)
        '    cantidadValues.Add(cantidad)

        '    dt.Rows.Add(ventasFecha.Key.ToString("dd/MM/yy"), Math.Round(monto, 2).ToString("c"), cantidad)

        '    Dim DataPointMonto As DataPoint = chtVentaEvolucion.Series("Monto").Points.Add(monto)
        '    DataPointMonto.AxisLabel = ventasFecha.Key.ToString("MM/dd")
        '    DataPointMonto.LegendText = ventasFecha.Key.ToString("MM/dd")

        '    Dim DataPointCantidad As DataPoint = chtVentaEvolucion.Series("Cantidad").Points.Add(cantidad)
        '    DataPointCantidad.AxisLabel = ventasFecha.Key.ToString("MM/dd")
        '    DataPointCantidad.LegendText = ventasFecha.Key.ToString("MM/dd")
        'Next

        'dgvVentaEvolucion.DataSource = dt
    End Sub

    Private Sub EvolucionProductos(datosProducto As List(Of InformeProductos), producto As String)

        'Dim dt As DataTable = New DataTable()
        'dt.Columns.Add("Nombre")
        'dt.Columns.Add("Fecha")
        'dt.Columns.Add("Monto")
        'dt.Columns.Add("Cantidad")

        'chtProductosEvolucion.Series("Monto").Points.Clear()
        'chtProductosEvolucion.Series("Cantidad").Points.Clear()

        'Dim productosPorFecha As List(Of IGrouping(Of Date, InformeProductos)) = datosProducto.Where(Function(x) x.Producto = producto).GroupBy(Of Date)(Function(x) x.Fecha).ToList()

        'For Each productoFecha As IGrouping(Of Date, InformeProductos) In productosPorFecha
        '    Dim monto As Decimal = productoFecha.Sum(Function(x) x.Monto * x.Cantidad)
        '    Dim cantidad As Decimal = productoFecha.Sum(Function(x) x.Cantidad)

        '    dt.Rows.Add(producto, productoFecha.Key.ToString("dd/MM/yy"), Math.Round(monto, 2).ToString("c"), cantidad)

        '    Dim DataPointMonto As DataPoint = chtProductosEvolucion.Series("Monto").Points.Add(monto)
        '    DataPointMonto.AxisLabel = productoFecha.Key.ToString("MM/dd")
        '    DataPointMonto.LegendText = productoFecha.Key.ToString("MM/dd")

        '    Dim DataPointCantidad As DataPoint = chtProductosEvolucion.Series("Cantidad").Points.Add(cantidad)
        '    DataPointCantidad.AxisLabel = productoFecha.Key.ToString("MM/dd")
        '    DataPointCantidad.LegendText = productoFecha.Key.ToString("MM/dd")
        'Next

        'dgvProductoEvolucion.DataSource = dt
    End Sub

    Private Sub EvolucionSubcategoria(datosProducto As List(Of InformeProductos), subCategoria As String)

        'Dim dt As DataTable = New DataTable()
        'dt.Columns.Add("Nombre")
        'dt.Columns.Add("Fecha")
        'dt.Columns.Add("Monto")
        'dt.Columns.Add("Cantidad")

        'chtSubcategoriaEvolucion.Series("Monto").Points.Clear()
        'chtSubcategoriaEvolucion.Series("Cantidad").Points.Clear()

        'Dim subCategoriaPorFecha As List(Of IGrouping(Of Date, InformeProductos)) = datosProducto.Where(Function(x) x.SubCategoria = subCategoria).GroupBy(Of Date)(Function(x) x.Fecha).ToList()

        'For Each subcategoriaFecha As IGrouping(Of Date, InformeProductos) In subCategoriaPorFecha
        '    Dim monto As Decimal = subcategoriaFecha.Sum(Function(x) x.Monto * x.Cantidad)
        '    Dim cantidad As Decimal = subcategoriaFecha.Sum(Function(x) x.Cantidad)

        '    dt.Rows.Add(subCategoria, subcategoriaFecha.Key.ToString("dd/MM/yy"), Math.Round(monto, 2).ToString("c"), cantidad)

        '    Dim DataPointMonto As DataPoint = chtSubcategoriaEvolucion.Series("Monto").Points.Add(monto)
        '    DataPointMonto.AxisLabel = subcategoriaFecha.Key.ToString("MM/dd")
        '    DataPointMonto.LegendText = subcategoriaFecha.Key.ToString("MM/dd")

        '    Dim DataPointCantidad As DataPoint = chtSubcategoriaEvolucion.Series("Cantidad").Points.Add(cantidad)
        '    DataPointCantidad.AxisLabel = subcategoriaFecha.Key.ToString("MM/dd")
        '    DataPointCantidad.LegendText = subcategoriaFecha.Key.ToString("MM/dd")
        'Next

        'dgvSubproductoEvolucion.DataSource = dt
    End Sub


    Private Sub DesabilitarSeleccion(sender As Object, e As EventArgs) Handles dgvTotalVentas.SelectionChanged, dgvFacturado.SelectionChanged, dgvTotalFormaPago.SelectionChanged, dgvTotalPorCliente.SelectionChanged, dgvProductoEvolucion.SelectionChanged, dgvSubproductoEvolucion.SelectionChanged, dgvVentaEvolucion.SelectionChanged
        sender.ClearSelection()
    End Sub

    Private Sub dgvTotalVentas_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvTotalVentas.DataBindingComplete
        lblMensajeTotalVentasVentas.Visible = Not dgvTotalVentas.RowCount > 0
    End Sub

    Private Sub dgvTotalPorCliente_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvTotalPorCliente.DataBindingComplete
        lblMensajeTipoClienteVentas.Visible = Not dgvTotalPorCliente.RowCount > 0
    End Sub

    Private Sub dgvTotalFormaPago_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvTotalFormaPago.DataBindingComplete
        lblMensajeFormaPagoVentas.Visible = Not dgvTotalFormaPago.RowCount > 0
    End Sub

    Private Sub dgvFacturado_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvFacturado.DataBindingComplete
        lblMensajeFacturadoVentas.Visible = Not dgvFacturado.RowCount > 0
    End Sub

    Private Sub dgvProductos_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvProductos.DataBindingComplete
        lblMensajeProductosProductos.Visible = Not dgvProductos.RowCount > 0
    End Sub

    Private Sub dgvSubCategorias_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvSubCategorias.DataBindingComplete
        lblMensajeSubcategoriasProductos.Visible = Not dgvSubCategorias.RowCount > 0
    End Sub

    Private Sub dgvVentaEvolucion_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvVentaEvolucion.DataBindingComplete
        lblMensajeEvolucionVentas.Visible = Not dgvVentaEvolucion.RowCount > 0
    End Sub

    Private Sub dgvProductoEvolucion_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvProductoEvolucion.DataBindingComplete
        lblMensajeProductoEvolucion.Visible = Not dgvProductoEvolucion.RowCount > 0
    End Sub

    Private Sub dgvSubproductoEvolucion_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvSubproductoEvolucion.DataBindingComplete
        lblMensajeSubcategoriaVentas.Visible = Not dgvSubproductoEvolucion.RowCount > 0
    End Sub

    Private Sub dgvProductos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductos.CellDoubleClick
        Me.Cursor = Cursors.WaitCursor
        Dim productoSeleccionado As String = dgvProductos.CurrentRow.DataBoundItem("Nombre")
        EvolucionProductos(datosProductos, productoSeleccionado)
        TabInformes.SelectedTab = tabEvolucion
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub dgvProductos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductos.CellClick
        Me.Cursor = Cursors.WaitCursor
        Dim productoSeleccionado As String = dgvProductos.CurrentRow.DataBoundItem("Nombre")
        EvolucionProductos(datosProductos, productoSeleccionado)
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub dgvSubCategorias_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSubCategorias.CellClick
        Me.Cursor = Cursors.WaitCursor
        Dim subCategoriaSeleccionada As String = dgvSubCategorias.CurrentRow.DataBoundItem("Nombre")
        EvolucionSubcategoria(datosProductos, subCategoriaSeleccionada)
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub dgvSubCategorias_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSubCategorias.CellDoubleClick
        Me.Cursor = Cursors.WaitCursor
        Dim subCategoriaSeleccionada As String = dgvSubCategorias.CurrentRow.DataBoundItem("Nombre")
        EvolucionSubcategoria(datosProductos, subCategoriaSeleccionada)
        TabInformes.SelectedTab = tabEvolucion
        Me.Cursor = Cursors.Arrow
    End Sub

End Class