Imports System.Windows.Forms.DataVisualization.Charting
Imports Entidades
Imports Negocio

Public Class frmInformeVentas
    Dim NegSucursales As NegSucursales = New NegSucursales()
    Dim NegCategoria As NegProductosCategorias = New NegProductosCategorias()
    Dim NegSubcategoria As NegProductosSubcategorias = New NegProductosSubcategorias()
    Dim NegProductos As NegProductos = New NegProductos()
    Dim Funciones As Funciones = New Funciones()
    Dim dsProductos As DataSet

    Dim dtGraficoPorTotalTipoCliente As DataTable
    Dim dtGraficoPorTotalFacturado As DataTable
    Dim dtGraficoPorTotalFormaPago As DataTable
    Dim dtGraficoPorTotalFormaPagoMinorista As DataTable
    Dim dtGraficoPorTotalFormaPagoMayorista As DataTable
    Dim dtGraficoGastos As DataTable
    Dim dtGraficoCostos As DataTable

    Dim sucursalesId As List(Of Integer)
    Dim fechaDesde As Date
    Dim fechaHasta As Date
    Dim idProducto As String
    Dim idCategoria As String
    Dim idSubcategoria As String

    Private Sub frmInformeVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim Sucursales As List(Of Sucursales) = New List(Of Sucursales)

            If VariablesGlobales.objUsuario.id_Perfil = 1 Then 'si es administrador
                Sucursales = NegSucursales.ListadoSucursalesEntidad()

            Else
                Sucursales.Add(New Entidades.Sucursales() With {.Nombre = My.Settings.NombreSucursal, .id_Sucursal = My.Settings.Sucursal})
                cklSucursales.Enabled = False
            End If

            cklSucursales.DataSource = Sucursales
            cklSucursales.DisplayMember = "Nombre"
            cklSucursales.ValueMember = "id_Sucursal"

            For i = 0 To cklSucursales.Items.Count - 1
                cklSucursales.SetItemChecked(i, True)
            Next

            dtpFechaDesde.Value = Date.Now.AddDays(-30)

            Dim dsCategorias As DataSet = NegCategoria.ListadoCategorias()
            If dsCategorias.Tables(0).Rows.Count > 0 Then
                cmbCategoria.DataSource = Funciones.CrearDataTable("id_Categoria", "Descripcion", dsCategorias, "Todas las categorías.")
                cmbCategoria.DisplayMember = "Descripcion"
                cmbCategoria.ValueMember = "id_Categoria"
                cmbCategoria.SelectedValue = 0
            End If

            Dim dsSubcategorias As DataSet = NegSubcategoria.ListadoSubcategoriasCompleto()
            If dsSubcategorias.Tables(0).Rows.Count > 0 Then
                cmbSubcategoria.DataSource = Funciones.CrearDataTable("id_Subcategoria", "Descripcion", dsSubcategorias, "Todas las subcategorías.")
                cmbSubcategoria.DisplayMember = "Descripcion"
                cmbSubcategoria.ValueMember = "id_Subcategoria"
                cmbSubcategoria.SelectedValue = 0
            End If

            'Obtengo el listado de productos guardados en cache
            dsProductos = NegProductos.ListadoProductos(True)

            'Armo una lista que contiene los nombres y codigos de todos los producto
            Dim listaNombreCodigoProductos As AutoCompleteStringCollection = New AutoCompleteStringCollection()

            listaNombreCodigoProductos.AddRange(dsProductos.Tables(0).Rows.Cast(Of DataRow).Select(Function(x) x.Item("Nombre").ToString).ToArray())
            listaNombreCodigoProductos.AddRange(dsProductos.Tables(0).Rows.Cast(Of DataRow).Select(Function(x) x.Item("Codigo").ToString).ToArray())

            txtProducto.AutoCompleteCustomSource = listaNombreCodigoProductos

            LimpiarInformes()
            BuscarDatos()

        Catch ex As Exception
            MessageBox.Show("Se ha producido un error al consultar los productos. Por favor, Comuníquese con el administrador.", "Informe de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Me.Cursor = Cursors.Arrow
        End Try
    End Sub

    Private Sub cmbCategoria_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbCategoria.SelectionChangeCommitted
        Try
            Me.Cursor = Cursors.WaitCursor
            If cmbCategoria.SelectedValue <> 0 Then
                Dim dsSubcategorias As DataSet = NegSubcategoria.ListadoSubcategorias(cmbCategoria.SelectedValue)
                If dsSubcategorias.Tables(0).Rows.Count > 0 Then
                    cmbSubcategoria.DataSource = Funciones.CrearDataTable("id_Subcategoria", "Descripcion", dsSubcategorias, "Todas las subcategorías.")
                    cmbSubcategoria.DisplayMember = "Descripcion"
                    cmbSubcategoria.ValueMember = "id_Subcategoria"
                    cmbSubcategoria.SelectedValue = 0
                    cmbSubcategoria.Refresh()
                End If
            Else
                Dim dsSubcategorias As DataSet = NegSubcategoria.ListadoSubcategoriasCompleto()
                If dsSubcategorias.Tables(0).Rows.Count > 0 Then
                    cmbSubcategoria.DataSource = Funciones.CrearDataTable("id_Subcategoria", "Descripcion", dsSubcategorias, "Todas las subcategorías.")
                    cmbSubcategoria.DisplayMember = "Descripcion"
                    cmbSubcategoria.ValueMember = "id_Subcategoria"
                    cmbSubcategoria.SelectedValue = 0
                    cmbSubcategoria.Refresh()
                End If
            End If
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            MessageBox.Show("Se ha producido un error al consultar los productos. Por favor, Comuníquese con el administrador.", "Informe de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Me.Cursor = Cursors.Arrow
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        LimpiarInformes()
        BuscarDatos()
    End Sub

    Private Sub ucPaginadoProductos_btnInicioClick(sender As Object, e As EventArgs) Handles ucPaginadoProductos.btnInicioClick
        Productos()
    End Sub

    Private Sub ucPaginadoProductos_btnFinClick(sender As Object, e As EventArgs) Handles ucPaginadoProductos.btnFinClick
        Productos()
    End Sub

    Private Sub ucPaginadoProductos_btnProximaClick(sender As Object, e As EventArgs) Handles ucPaginadoProductos.btnProximaClick
        Productos()
    End Sub

    Private Sub ucPaginadoProductos_btnAnteriorClick(sender As Object, e As EventArgs) Handles ucPaginadoProductos.btnAnteriorClick
        Productos()
    End Sub

    Private Sub ucPaginadoSubcategoria_btnInicioClick(sender As Object, e As EventArgs) Handles ucPaginadoSubcategoria.btnInicioClick
        SubCategrias()
    End Sub

    Private Sub ucPaginadoSubcategoria_btnFinClick(sender As Object, e As EventArgs) Handles ucPaginadoSubcategoria.btnFinClick
        SubCategrias()
    End Sub

    Private Sub ucPaginadoSubcategoria_btnProximaClick(sender As Object, e As EventArgs) Handles ucPaginadoSubcategoria.btnProximaClick
        SubCategrias()
    End Sub

    Private Sub ucPaginadoSubcategoria_btnAnteriorClick(sender As Object, e As EventArgs) Handles ucPaginadoSubcategoria.btnAnteriorClick
        SubCategrias()
    End Sub

    Private Sub ucPaginadoVentas_btnInicioClick(sender As Object, e As EventArgs) Handles ucPaginadoVentas.btnInicioClick
        Ventas()
    End Sub

    Private Sub ucPaginadoVentas_btnFinClick(sender As Object, e As EventArgs) Handles ucPaginadoVentas.btnFinClick
        Ventas()
    End Sub

    Private Sub ucPaginadoVentas_btnProximaClick(sender As Object, e As EventArgs) Handles ucPaginadoVentas.btnProximaClick
        Ventas()
    End Sub

    Private Sub ucPaginadoVentas_btnAnteriorClick(sender As Object, e As EventArgs) Handles ucPaginadoVentas.btnAnteriorClick
        Ventas()
    End Sub

    Private Sub ucPaginadoDistribucionProveedores_btnInicioClick(sender As Object, e As EventArgs) Handles ucPaginadoMercaderiaRecibida.btnInicioClick
        MercaderiaRecibida()
    End Sub

    Private Sub ucPaginadoDistribucionProveedores_btnFinClick(sender As Object, e As EventArgs) Handles ucPaginadoMercaderiaRecibida.btnFinClick
        MercaderiaRecibida()
    End Sub

    Private Sub ucPaginadoDistribucionProveedores_btnProximaClick(sender As Object, e As EventArgs) Handles ucPaginadoMercaderiaRecibida.btnProximaClick
        MercaderiaRecibida()
    End Sub

    Private Sub ucPaginadoDistribucionProveedores_btnAnteriorClick(sender As Object, e As EventArgs) Handles ucPaginadoMercaderiaRecibida.btnAnteriorClick
        MercaderiaRecibida()
    End Sub


    Private Sub LimpiarInformes()
        dgvTotalVentas.DataSource = Nothing
        dgvFacturado.DataSource = Nothing
        dgvProductos.DataSource = Nothing
        dgvSubCategorias.DataSource = Nothing
        dgvTotalFormaPago.DataSource = Nothing
        dgvTotalPorCliente.DataSource = Nothing

        ucPaginadoProductos.OrdenColumna = dgvProductos.Columns(0).DataPropertyName
        ucPaginadoProductos.OrdenDireccion = SortOrder.Descending
        ucPaginadoProductos.PaginaTamaño = 50
        ucPaginadoProductos.PaginaActual = 1

        ucPaginadoCategoria.OrdenColumna = dgvSubCategorias.Columns(0).DataPropertyName
        ucPaginadoCategoria.OrdenDireccion = SortOrder.Descending
        ucPaginadoCategoria.PaginaTamaño = 50
        ucPaginadoCategoria.PaginaActual = 1

        ucPaginadoSubcategoria.OrdenColumna = dgvSubCategorias.Columns(0).DataPropertyName
        ucPaginadoSubcategoria.OrdenDireccion = SortOrder.Descending
        ucPaginadoSubcategoria.PaginaTamaño = 50
        ucPaginadoSubcategoria.PaginaActual = 1

        ucPaginadoVentas.OrdenColumna = dgvVentas.Columns(0).DataPropertyName
        ucPaginadoVentas.OrdenDireccion = SortOrder.Descending
        ucPaginadoVentas.PaginaTamaño = 50
        ucPaginadoVentas.PaginaActual = 1

        ucPaginadoMercaderiaRecibida.OrdenColumna = dgvMercaderiaRecibida.Columns(0).DataPropertyName
        ucPaginadoMercaderiaRecibida.OrdenDireccion = SortOrder.Descending
        ucPaginadoMercaderiaRecibida.PaginaTamaño = 50
        ucPaginadoMercaderiaRecibida.PaginaActual = 1
    End Sub

    Private Sub BuscarDatos()

        'Muestro el form de espera..
        Dim frmEspera As frmCargadorDeEspera = New frmCargadorDeEspera()
        frmEspera.Show()
        frmEspera.Text = "Generando Informe... "
        frmEspera.lbl_Descripcion.Text = "Obteniendo Total Ventas..."
        frmEspera.BarraProgreso.Minimum = 0
        frmEspera.BarraProgreso.Maximum = 10
        frmEspera.BarraProgreso.Value = 1
        frmEspera.Refresh()

        Try
            Me.Cursor = Cursors.WaitCursor
            sucursalesId = cklSucursales.CheckedItems.Cast(Of Sucursales).Select(Function(x) x.id_Sucursal).ToList()
            fechaDesde = dtpFechaDesde.Value
            fechaHasta = dtpFechaHasta.Value
            idProducto = BuscarProducto()
            idCategoria = BuscarCategoria()
            idSubcategoria = BuscarSubcategoria()


            Dim datosVentas As List(Of InformeVenta) = NegInformes.ObtenerVentas(sucursalesId, fechaDesde, fechaHasta)
            TotalGeneralVentas(datosVentas)

            frmEspera.lbl_Descripcion.Text = "Obteniendo Ventas Por Día..."
            frmEspera.BarraProgreso.Value += 1
            frmEspera.Refresh()

            Ventas()

            frmEspera.lbl_Descripcion.Text = "Obteniendo Total Ventas Por Cliente..."
            frmEspera.BarraProgreso.Value += 1
            frmEspera.Refresh()

            TotalVentasPorTipoCliente(datosVentas)

            frmEspera.lbl_Descripcion.Text = "Obteniendo Total Ventas Por Forma Pago..."
            frmEspera.BarraProgreso.Value += 1
            frmEspera.Refresh()

            TotalVentasPorFormaDePago(datosVentas)

            frmEspera.lbl_Descripcion.Text = "Obteniendo Total Ventas Por Facturacion..."
            frmEspera.BarraProgreso.Value += 1
            frmEspera.Refresh()

            TotalVentasPorFacturacion(datosVentas)

            frmEspera.lbl_Descripcion.Text = "Obteniendo Productos..."
            frmEspera.BarraProgreso.Value += 1
            frmEspera.Refresh()

            Productos()

            frmEspera.lbl_Descripcion.Text = "Obteniendo Subcategorias..."
            frmEspera.BarraProgreso.Value += 1
            frmEspera.Refresh()

            Categrias()

            frmEspera.lbl_Descripcion.Text = "Obteniendo Egresos..."
            frmEspera.BarraProgreso.Value += 1
            frmEspera.Refresh()

            SubCategrias()

            frmEspera.lbl_Descripcion.Text = "Obteniendo Egresos..."
            frmEspera.BarraProgreso.Value += 1
            frmEspera.Refresh()

            Costos(datosVentas)

            frmEspera.lbl_Descripcion.Text = "Obteniendo Distribución Gastos..."
            frmEspera.BarraProgreso.Value += 1
            frmEspera.Refresh()

            Gastos(datosVentas)

            frmEspera.lbl_Descripcion.Text = "Obteniendo Distribución Proveedores..."
            frmEspera.BarraProgreso.Value += 1
            frmEspera.Refresh()

            MercaderiaRecibida()

            frmEspera.Close()
            frmEspera.Dispose()

            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            frmEspera.Close()
            frmEspera.Dispose()
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
        Dim montoTotal As Decimal = datos.Sum(Function(x) x.MontoTotal)

        Dim montoTotalMinorista As Decimal = datos.Where(Function(x) x.TipoCliente = "Minorista").Sum(Function(x) x.MontoTotal)
        Dim cantidadTotalMinorista As Decimal = datos.Where(Function(x) x.TipoCliente = "Minorista").Sum(Function(x) x.CantidadTotal)
        Dim promedioVentasMinorista As Decimal = If(cantidadTotalMinorista > 0, montoTotalMinorista / cantidadTotalMinorista, 0)

        Dim montoTotalMayorista As Decimal = datos.Where(Function(x) x.TipoCliente = "Mayorista").Sum(Function(x) x.MontoTotal)
        Dim cantidadTotalMayorista As Decimal = datos.Where(Function(x) x.TipoCliente = "Mayorista").Sum(Function(x) x.CantidadTotal)
        Dim promedioVentasMayorista As Decimal = If(cantidadTotalMayorista > 0, montoTotalMayorista / cantidadTotalMayorista, 0)

        Dim dt As DataTable = New DataTable()
        dt.Columns.Add("Detalle")
        dt.Columns.Add("Monto")
        dt.Columns.Add("PorcentajeVenta")
        dt.Columns.Add("Cantidad")

        dtGraficoPorTotalTipoCliente = New DataTable()
        dtGraficoPorTotalTipoCliente.Columns.Add("Detalle")
        dtGraficoPorTotalTipoCliente.Columns.Add("Cantidad")

        dt.Rows.Add("Total Ventas Minorista", Math.Round(montoTotalMinorista, 2).ToString("c"), (montoTotalMinorista / montoTotal).ToString("p"), cantidadTotalMinorista)
        dtGraficoPorTotalTipoCliente.Rows.Add("Minorista", cantidadTotalMinorista)

        dt.Rows.Add("Promedio Ventas Minorista", Math.Round(promedioVentasMinorista, 2).ToString("c"), "")

        dt.Rows.Add("Total Ventas Mayorista", Math.Round(montoTotalMayorista, 2).ToString("c"), (montoTotalMayorista / montoTotal).ToString("p"), cantidadTotalMayorista)
        dtGraficoPorTotalTipoCliente.Rows.Add("Mayorista", cantidadTotalMayorista)

        dt.Rows.Add("Promedio Ventas Mayorista", Math.Round(promedioVentasMayorista, 2).ToString("c"), "")

        dgvTotalPorCliente.DataSource = dt
    End Sub

    Private Sub TotalVentasPorFormaDePago(datos As List(Of InformeVenta))

        Dim dt As DataTable = New DataTable()
        dt.Columns.Add("Grupo")
        dt.Columns.Add("Detalle")
        dt.Columns.Add("Monto")
        dt.Columns.Add("PorcentajeVenta")
        dt.Columns.Add("Cantidad")

        dtGraficoPorTotalFormaPago = New DataTable()
        dtGraficoPorTotalFormaPago.Columns.Add("Detalle")
        dtGraficoPorTotalFormaPago.Columns.Add("Cantidad")

        dtGraficoPorTotalFormaPagoMinorista = New DataTable()
        dtGraficoPorTotalFormaPagoMinorista.Columns.Add("Detalle")
        dtGraficoPorTotalFormaPagoMinorista.Columns.Add("Cantidad")

        dtGraficoPorTotalFormaPagoMayorista = New DataTable()
        dtGraficoPorTotalFormaPagoMayorista.Columns.Add("Detalle")
        dtGraficoPorTotalFormaPagoMayorista.Columns.Add("Cantidad")

        Dim montoTotal As Decimal = datos.Sum(Function(x) x.MontoTotal)

        ''Agrupado por forma de pago
        Dim formasPago As List(Of IGrouping(Of String, InformeVenta)) = datos.GroupBy(Of String)(Function(x) x.FormaPago).ToList()

        For Each item As IGrouping(Of String, InformeVenta) In formasPago
            Dim total As Decimal = item.Sum(Function(x) x.MontoTotal)
            Dim cantidad As Decimal = item.Sum(Function(x) x.CantidadTotal)
            dt.Rows.Add("Totales", item.Key, Math.Round(total, 2).ToString("c"), (total / montoTotal).ToString("p"), cantidad)
            dtGraficoPorTotalFormaPago.Rows.Add(item.Key, cantidad)
        Next

        ''Agrupado por tipo de cliente
        Dim tiposClientes As List(Of IGrouping(Of String, InformeVenta)) = datos.GroupBy(Of String)(Function(x) x.TipoCliente).ToList()

        For Each item As IGrouping(Of String, InformeVenta) In tiposClientes
            formasPago = item.GroupBy(Of String)(Function(x) x.FormaPago).ToList()
            For Each pagos As IGrouping(Of String, InformeVenta) In formasPago
                Dim total As Decimal = pagos.Sum(Function(x) x.MontoTotal)
                Dim cantidad As Decimal = pagos.Sum(Function(x) x.CantidadTotal)

                If item.Key = "Mayorista" Then
                    dt.Rows.Add("Mayorista", pagos.Key, Math.Round(total, 2).ToString("c"), (total / montoTotal).ToString("p"), cantidad)
                    dtGraficoPorTotalFormaPagoMayorista.Rows.Add(pagos.Key, cantidad)

                ElseIf item.Key = "Minorista" Then
                    dt.Rows.Add("Minorista", pagos.Key, Math.Round(total, 2).ToString("c"), (total / montoTotal).ToString("p"), cantidad)
                    dtGraficoPorTotalFormaPagoMinorista.Rows.Add(pagos.Key, cantidad)
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
        dt.Columns.Add("PorcentajeVenta")
        dt.Columns.Add("Cantidad")

        ''Agrupado por facturado
        Dim montoTotal As Decimal = datos.Sum(Function(x) x.MontoTotal)
        Dim facturados As List(Of IGrouping(Of String, InformeVenta)) = datos.GroupBy(Of String)(Function(x) x.Facturado).ToList()

        For Each item As IGrouping(Of String, InformeVenta) In facturados
            Dim total As Decimal = item.Sum(Function(x) x.MontoTotal)
            Dim cantidad As Decimal = item.Sum(Function(x) x.CantidadTotal)
            If item.Key = "1" Then
                dt.Rows.Add("Facturado", Math.Round(total, 2).ToString("c"), (total / montoTotal).ToString("p"), cantidad)
            Else
                dt.Rows.Add("Sin Facturar", Math.Round(total, 2).ToString("c"), (total / montoTotal).ToString("p"), cantidad)
            End If
        Next

        dtGraficoPorTotalFacturado = dt

        dgvFacturado.DataSource = Nothing
        dgvFacturado.DataSource = dt
    End Sub

    Private Sub Productos()
        Try
            Me.Cursor = Cursors.WaitCursor

            dgvProductos.AutoGenerateColumns = False
            dgvProductos.DataSource = NegInformes.ObtenerProductos(idProducto, idCategoria, idSubcategoria, sucursalesId, fechaDesde, fechaHasta, ucPaginadoProductos.PaginaActual, ucPaginadoProductos.PaginaTamaño, ucPaginadoProductos.OrdenColumna, ucPaginadoProductos.OrdenDireccion, ucPaginadoProductos.TotalElementos)

        Catch ex As Exception
            MessageBox.Show("Se ha producido un error al consultar los productos. Por favor, Comuníquese con el administrador.", "Informe de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Me.Cursor = Cursors.Arrow
        End Try


    End Sub

    Private Sub Categrias()
        Try
            Me.Cursor = Cursors.WaitCursor

            dgvCategorias.AutoGenerateColumns = False
            dgvCategorias.DataSource = NegInformes.ObtenerCategorias(idProducto, idCategoria, idSubcategoria, sucursalesId, fechaDesde, fechaHasta, ucPaginadoSubcategoria.PaginaActual, ucPaginadoSubcategoria.PaginaTamaño, ucPaginadoSubcategoria.OrdenColumna, ucPaginadoSubcategoria.OrdenDireccion, ucPaginadoSubcategoria.TotalElementos)

        Catch ex As Exception
            MessageBox.Show("Se ha producido un error al consultar las subcategorias. Por favor, Comuníquese con el administrador.", "Informe de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Me.Cursor = Cursors.Arrow
        End Try
    End Sub

    Private Sub SubCategrias()
        Try
            Me.Cursor = Cursors.WaitCursor

            dgvSubCategorias.AutoGenerateColumns = False
            dgvSubCategorias.DataSource = NegInformes.ObtenerSubcategorias(idProducto, idCategoria, idSubcategoria, sucursalesId, fechaDesde, fechaHasta, ucPaginadoSubcategoria.PaginaActual, ucPaginadoSubcategoria.PaginaTamaño, ucPaginadoSubcategoria.OrdenColumna, ucPaginadoSubcategoria.OrdenDireccion, ucPaginadoSubcategoria.TotalElementos)

        Catch ex As Exception
            MessageBox.Show("Se ha producido un error al consultar las subcategorias. Por favor, Comuníquese con el administrador.", "Informe de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Me.Cursor = Cursors.Arrow
        End Try
    End Sub

    Private Sub Ventas()
        Try
            Me.Cursor = Cursors.WaitCursor

            dgvVentas.AutoGenerateColumns = False
            dgvVentas.DataSource = NegInformes.ObtenerVentasDia(sucursalesId, fechaDesde, fechaHasta, ucPaginadoVentas.PaginaActual, ucPaginadoVentas.PaginaTamaño, ucPaginadoVentas.OrdenColumna, ucPaginadoVentas.OrdenDireccion, ucPaginadoVentas.TotalElementos)

        Catch ex As Exception
            MessageBox.Show("Se ha producido un error al consultar las ventas totales. Por favor, Comuníquese con el administrador.", "Informe de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Me.Cursor = Cursors.Arrow
        End Try
    End Sub

    Private Sub Costos(datos As List(Of InformeVenta))
        Try
            Me.Cursor = Cursors.WaitCursor

            dtGraficoCostos = New DataTable()
            dtGraficoCostos.Columns.Add("Detalle")
            dtGraficoCostos.Columns.Add("Monto")

            Dim dt As DataTable = New DataTable()
            dt.Columns.Add("Detalle")
            dt.Columns.Add("Monto")
            dt.Columns.Add("PorcentajeCosto")
            dt.Columns.Add("PorcentajeVenta")

            Dim sucursalesId As List(Of Integer) = cklSucursales.CheckedItems.Cast(Of Sucursales).Select(Function(x) x.id_Sucursal).ToList()
            Dim fechaDesde As Date = dtpFechaDesde.Value
            Dim fechaHasta As Date = dtpFechaHasta.Value


            Dim sueldosDevengados As Double = NegInformes.ObtenerSueldosDevengados(sucursalesId, fechaDesde, fechaHasta)
            Dim costos As DataTable = NegInformes.ObtenerCostos(sucursalesId, fechaDesde, fechaHasta)

            Dim montoTotal As Decimal = datos.Sum(Function(x) x.MontoTotal)
            Dim costoTotal As Decimal = costos.Rows.Cast(Of DataRow).Sum(Function(x) x("Monto")) + sueldosDevengados

            For Each row As DataRow In costos.Rows
                Dim monto As Double = row("Monto")
                dt.Rows.Add(row("Descripcion"), Math.Round(monto, 2).ToString("c"), If(costoTotal <> 0, (monto / costoTotal).ToString("P"), 0.ToString("P")), If(montoTotal <> 0, (monto / montoTotal).ToString("P"), 0.ToString("P")))
                dtGraficoCostos.Rows.Add(row("Descripcion"), Math.Round(monto, 2))
            Next

            dt.Rows.Add("Sueldo", Math.Round(sueldosDevengados, 2).ToString("c"), If(costoTotal <> 0, (sueldosDevengados / costoTotal).ToString("p"), 0.ToString("p")), If(montoTotal > 0, (sueldosDevengados / montoTotal).ToString("P"), 0.ToString("P")))
            dtGraficoCostos.Rows.Add("Sueldo", Math.Round(sueldosDevengados, 2))
            dt.Rows.Add("Total", Math.Round(costoTotal, 2).ToString("c"), If(costoTotal <> 0, (costoTotal / costoTotal).ToString("p"), 0.ToString("p")), If(montoTotal > 0, (costoTotal / montoTotal).ToString("P"), 0.ToString("P")))

            dgvTotalCostos.AutoGenerateColumns = False
            dgvTotalCostos.DataSource = dt

        Catch ex As Exception
            MessageBox.Show("Se ha producido un error al consultar los egresos. Por favor, Comuníquese con el administrador.", "Informe de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Me.Cursor = Cursors.Arrow
        End Try
    End Sub

    Private Sub MercaderiaRecibida()
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim mercaderiaRecivida As DataTable = NegInformes.ObtenerMercaderíaRecibida(sucursalesId, fechaDesde, fechaHasta, ucPaginadoMercaderiaRecibida.PaginaActual, ucPaginadoMercaderiaRecibida.PaginaTamaño, ucPaginadoMercaderiaRecibida.OrdenColumna, ucPaginadoMercaderiaRecibida.OrdenDireccion, ucPaginadoMercaderiaRecibida.TotalElementos)
            Dim totalMercaderiaRecivida As DataTable = mercaderiaRecivida.Clone()

            If (mercaderiaRecivida.Rows.Count > 0) Then
                totalMercaderiaRecivida.Rows.Add(0, "Total", mercaderiaRecivida.Rows(0)("TotalMonto"), mercaderiaRecivida.Rows(0)("TotalPorcentajeMonto"), mercaderiaRecivida.Rows(0)("TotalPorcentajeVentas"), 0)
            End If

            dgvMercaderiaRecibida.AutoGenerateColumns = False
            dgvMercaderiaRecibida.DataSource = mercaderiaRecivida

            dgvTotalMercaderiaRecibida.AutoGenerateColumns = False
            dgvTotalMercaderiaRecibida.DataSource = totalMercaderiaRecivida
        Catch ex As Exception
            MessageBox.Show("Se ha producido un error al consultar los egresos. Por favor, Comuníquese con el administrador.", "Informe de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Me.Cursor = Cursors.Arrow
        End Try
    End Sub

    Private Sub Gastos(datos As List(Of InformeVenta))
        Try
            Me.Cursor = Cursors.WaitCursor

            dtGraficoGastos = New DataTable()
            dtGraficoGastos.Columns.Add("Detalle")
            dtGraficoGastos.Columns.Add("Monto")

            Dim dt As DataTable = New DataTable()
            dt.Columns.Add("Detalle")
            dt.Columns.Add("Monto")
            dt.Columns.Add("PorcentajeGasto")
            dt.Columns.Add("PorcentajeVenta")

            Dim sucursalesId As List(Of Integer) = cklSucursales.CheckedItems.Cast(Of Sucursales).Select(Function(x) x.id_Sucursal).ToList()
            Dim fechaDesde As Date = dtpFechaDesde.Value
            Dim fechaHasta As Date = dtpFechaHasta.Value


            Dim sueldosPagos As Double = NegInformes.ObtenerSueldosPagos(sucursalesId, fechaDesde, fechaHasta)
            Dim gastos As DataTable = NegInformes.ObtenerGastos(sucursalesId, fechaDesde, fechaHasta)

            Dim montoTotal As Decimal = datos.Sum(Function(x) x.MontoTotal)
            Dim costoTotal As Decimal = gastos.Rows.Cast(Of DataRow).Sum(Function(x) x("Monto")) + sueldosPagos

            For Each row As DataRow In gastos.Rows
                Dim monto As Double = row("Monto")
                dt.Rows.Add(row("Descripcion"), Math.Round(monto, 2).ToString("c"), (monto / costoTotal).ToString("P"), (monto / montoTotal).ToString("P"))
                dtGraficoGastos.Rows.Add(row("Descripcion"), Math.Round(monto, 2))
            Next

            dt.Rows.Add("Sueldo", Math.Round(sueldosPagos, 2).ToString("c"), If(costoTotal <> 0, (sueldosPagos / costoTotal).ToString("p"), 0.ToString("p")), If(montoTotal > 0, (sueldosPagos / montoTotal).ToString("P"), 0.ToString("P")))
            dtGraficoGastos.Rows.Add("Sueldo", Math.Round(sueldosPagos, 2))
            dt.Rows.Add("Total", Math.Round(costoTotal, 2).ToString("c"), If(costoTotal <> 0, (costoTotal / costoTotal).ToString("p"), 0.ToString("p")), If(montoTotal > 0, (costoTotal / montoTotal).ToString("P"), 0.ToString("P")))

            dgvTotalGastos.AutoGenerateColumns = False
            dgvTotalGastos.DataSource = dt

        Catch ex As Exception
            MessageBox.Show("Se ha producido un error al consultar los egresos. Por favor, Comuníquese con el administrador.", "Informe de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Me.Cursor = Cursors.Arrow
        End Try
    End Sub


    Private Sub DesabilitarSeleccion(sender As Object, e As EventArgs) Handles dgvTotalVentas.SelectionChanged, dgvFacturado.SelectionChanged, dgvTotalFormaPago.SelectionChanged, dgvTotalPorCliente.SelectionChanged, dgvTotalMercaderiaRecibida.SelectionChanged, dgvTotalGastos.SelectionChanged, dgvTotalCostos.SelectionChanged, dgvMercaderiaRecibida.SelectionChanged
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

    Private Sub dgvCategorias_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvCategorias.DataBindingComplete
        lblMensajeCategoriasProductos.Visible = Not dgvProductos.RowCount > 0
    End Sub

    Private Sub dgvSubCategorias_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvSubCategorias.DataBindingComplete
        lblMensajeSubcategoriasProductos.Visible = Not dgvSubCategorias.RowCount > 0
    End Sub

    Private Sub dgvVentas_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvVentas.DataBindingComplete
        lblMensajeVentasDias.Visible = Not dgvVentas.RowCount > 0
    End Sub

    Private Sub dgvDistribucionProveedores_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvMercaderiaRecibida.DataBindingComplete
        lblMensajeDistribucionProveedores.Visible = Not dgvMercaderiaRecibida.RowCount > 0
    End Sub

    Private Sub dgvProductos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductos.CellDoubleClick
        ProductosDetalle(dgvProductos.CurrentRow.Cells("ProductoId").Value, idCategoria, idSubcategoria)
    End Sub

    Private Sub dgvProductos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductos.CellClick
        If (dgvProductos.Columns(e.ColumnIndex).Name = "ProductoDetalle") Then
            ProductosDetalle(dgvProductos.CurrentRow.Cells("ProductoId").Value, idCategoria, idSubcategoria)
        End If
    End Sub

    Private Sub dgvCategorias_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCategorias.CellDoubleClick
        ProductosDetalle(idProducto, dgvCategorias.CurrentRow.Cells("CategoriaId").Value, idSubcategoria)
    End Sub

    Private Sub dgvCategorias_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCategorias.CellClick
        If (dgvCategorias.Columns(e.ColumnIndex).Name = "CategoriaDetalle") Then
            ProductosDetalle(idProducto, dgvCategorias.CurrentRow.Cells("CategoriaId").Value, idSubcategoria)
        End If
    End Sub

    Private Sub dgvSubCategorias_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSubCategorias.CellDoubleClick
        ProductosDetalle(idProducto, idCategoria, dgvSubCategorias.CurrentRow.Cells("SubcategoriaId").Value)
    End Sub

    Private Sub dgvSubCategorias_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSubCategorias.CellClick
        If (dgvSubCategorias.Columns(e.ColumnIndex).Name = "SubcategoriaDetalle") Then
            ProductosDetalle(idProducto, idCategoria, dgvSubCategorias.CurrentRow.Cells("SubcategoriaId").Value)
        End If
    End Sub

    Private Sub dgvSubCategorias_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvSubCategorias.ColumnHeaderMouseClick
        ucPaginadoSubcategoria.OrdenColumna = dgvSubCategorias.Columns(e.ColumnIndex).DataPropertyName
        ucPaginadoSubcategoria.OrdenDireccion = If(ucPaginadoSubcategoria.OrdenDireccion = SortOrder.Ascending, SortOrder.Descending, SortOrder.Ascending)
        SubCategrias()
        dgvSubCategorias.Columns(e.ColumnIndex).HeaderCell.SortGlyphDirection = ucPaginadoSubcategoria.OrdenDireccion
    End Sub

    Private Sub dgvProductos_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvProductos.ColumnHeaderMouseClick
        ucPaginadoProductos.OrdenColumna = dgvProductos.Columns(e.ColumnIndex).DataPropertyName
        ucPaginadoProductos.OrdenDireccion = If(ucPaginadoProductos.OrdenDireccion = SortOrder.Ascending, SortOrder.Descending, SortOrder.Ascending)
        Productos()
        dgvProductos.Columns(e.ColumnIndex).HeaderCell.SortGlyphDirection = ucPaginadoProductos.OrdenDireccion
    End Sub

    Private Sub dgvVentas_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvVentas.ColumnHeaderMouseClick
        ucPaginadoVentas.OrdenColumna = dgvVentas.Columns(e.ColumnIndex).DataPropertyName
        ucPaginadoVentas.OrdenDireccion = If(ucPaginadoVentas.OrdenDireccion = SortOrder.Ascending, SortOrder.Descending, SortOrder.Ascending)
        Ventas()
        dgvVentas.Columns(e.ColumnIndex).HeaderCell.SortGlyphDirection = ucPaginadoVentas.OrdenDireccion
    End Sub

    Private Sub dgvMercaderiaRecibida_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvMercaderiaRecibida.ColumnHeaderMouseClick
        ucPaginadoMercaderiaRecibida.OrdenColumna = dgvMercaderiaRecibida.Columns(e.ColumnIndex).DataPropertyName
        ucPaginadoMercaderiaRecibida.OrdenDireccion = If(ucPaginadoMercaderiaRecibida.OrdenDireccion = SortOrder.Ascending, SortOrder.Descending, SortOrder.Ascending)
        MercaderiaRecibida()
        dgvMercaderiaRecibida.Columns(e.ColumnIndex).HeaderCell.SortGlyphDirection = ucPaginadoMercaderiaRecibida.OrdenDireccion
    End Sub

    Private Sub btnGrafico_Click(sender As Object, e As EventArgs) Handles btnGrafico.Click

        Dim cantidad As Integer = 0
        Dim Funciones As New Funciones

        If (TabInformes.SelectedTab.Name = tabVentas.Name) Then
            Dim informeGraficoVentas As FrmInformeGraficoVentas = Funciones.ControlInstancia(FrmInformeGraficoVentas)
            informeGraficoVentas.TotalTipoCliente = dtGraficoPorTotalTipoCliente
            informeGraficoVentas.TotalFacturado = dtGraficoPorTotalFacturado
            informeGraficoVentas.TotalCuotas = NegInformes.ObtenerCantidadCuotas(sucursalesId, fechaDesde, fechaHasta)
            informeGraficoVentas.TotalFormaPago = dtGraficoPorTotalFormaPago
            informeGraficoVentas.TotalFormaPagoMayorista = dtGraficoPorTotalFormaPagoMayorista
            informeGraficoVentas.TotalFormaPagoMinorista = dtGraficoPorTotalFormaPagoMinorista
            informeGraficoVentas.Ventas = ObtenerTodasLasPaginasVentasPorDia(sucursalesId, fechaDesde, fechaHasta)
            informeGraficoVentas.MdiParent = Me.MdiParent
            FrmInformeGraficoVentas.Show()
        End If

        If (TabInformes.SelectedTab.Name = tabProductos.Name) Then
            Dim informeGraficoProducto As FrmInformeGraficoProducto = Funciones.ControlInstancia(FrmInformeGraficoProducto)
            informeGraficoProducto.TopProductosMonto = NegInformes.ObtenerProductos(idProducto, idCategoria, idSubcategoria, sucursalesId, fechaDesde, fechaHasta, 1, 10, "Monto", SortOrder.Descending, cantidad)
            informeGraficoProducto.TopProductosCantidad = NegInformes.ObtenerProductos(idProducto, idCategoria, idSubcategoria, sucursalesId, fechaDesde, fechaHasta, 1, 10, "Cantidad", SortOrder.Descending, cantidad)
            informeGraficoProducto.TopCategoriaMonto = NegInformes.ObtenerCategorias(idProducto, idCategoria, idSubcategoria, sucursalesId, fechaDesde, fechaHasta, 1, 10, "Monto", SortOrder.Descending, cantidad)
            informeGraficoProducto.TopCategoriaCantidad = NegInformes.ObtenerCategorias(idProducto, idCategoria, idSubcategoria, sucursalesId, fechaDesde, fechaHasta, 1, 10, "Cantidad", SortOrder.Descending, cantidad)
            informeGraficoProducto.TopSubcategoriaMonto = NegInformes.ObtenerSubcategorias(idProducto, idCategoria, idSubcategoria, sucursalesId, fechaDesde, fechaHasta, 1, 10, "Monto", SortOrder.Descending, cantidad)
            informeGraficoProducto.TopSubcategoriaCantidad = NegInformes.ObtenerSubcategorias(idProducto, idCategoria, idSubcategoria, sucursalesId, fechaDesde, fechaHasta, 1, 10, "Cantidad", SortOrder.Descending, cantidad)
            informeGraficoProducto.MdiParent = Me.MdiParent
            informeGraficoProducto.Show()
        End If

        If (TabInformes.SelectedTab.Name = tabEgresos.Name) Then
            Dim informeGraficoEgresos As FrmInformeGraficoEgresos = Funciones.ControlInstancia(FrmInformeGraficoEgresos)
            informeGraficoEgresos.TopGastos = dtGraficoGastos
            informeGraficoEgresos.TopProveedor = dtGraficoCostos
            informeGraficoEgresos.MdiParent = Me.MdiParent
            informeGraficoEgresos.Show()
        End If

    End Sub

    Private Function ObtenerTodasLasPaginasVentasPorDia(id_Sucursales As List(Of Integer), FDesde As Date, FHasta As Date)

        Dim paginaActual As Integer = 1
        Dim tamañoPagina As Integer = 200
        Dim totalElementos As Integer = 0
        Dim resultado As DataTable = New DataTable()
        Do
            Dim temp As DataTable = NegInformes.ObtenerVentasDia(id_Sucursales, FDesde, FHasta, paginaActual, tamañoPagina, "", SortOrder.None, totalElementos)

            If temp.Rows.Count = 0 Then
                Exit Do
            End If

            If paginaActual = 1 Then
                resultado = temp.Clone()
            End If

            paginaActual += 1

            For Each item As DataRow In temp.Rows
                resultado.ImportRow(item)
            Next
        Loop

        Return resultado
    End Function

    Private Function BuscarProducto() As String
        Dim dr As DataRow = dsProductos.Tables(0).Rows.Cast(Of DataRow).Where(Function(x) x.Item("Nombre").ToString().ToUpper() = txtProducto.Text.ToUpper() Or x.Item("Codigo").ToString().ToUpper() = txtProducto.Text.ToUpper()).FirstOrDefault()
        If (dr IsNot Nothing) Then
            Return dr(3)
        Else
            Return Nothing
        End If
    End Function

    Private Function BuscarCategoria() As String
        If cmbCategoria.SelectedValue <> 0 Then
            Return cmbCategoria.SelectedValue
        Else
            Return Nothing
        End If
    End Function

    Private Function BuscarSubcategoria() As String
        If cmbSubcategoria.SelectedValue <> 0 Then
            Return cmbSubcategoria.SelectedValue
        Else
            Return Nothing
        End If
    End Function

    Private Sub ProductosDetalle(idProducto As String, idCategoria As String, idSubcategoria As String)
        Dim Funciones As New Funciones
        Dim frmInfProducto As frmInformeProducto = Funciones.ControlInstancia(frmInformeProducto)
        frmInfProducto.sucursalesId = cklSucursales.CheckedItems.Cast(Of Sucursales).Select(Function(x) x.id_Sucursal).ToList()
        frmInfProducto.fechaDesde = dtpFechaDesde.Value
        frmInfProducto.fechaHasta = dtpFechaHasta.Value
        frmInfProducto.idProducto = idProducto
        frmInfProducto.idCategoria = idCategoria
        frmInfProducto.idSubCategoria = idSubcategoria
        frmInfProducto.MdiParent = Me.MdiParent
        frmInfProducto.inicializar()
        If (frmInfProducto.WindowState = FormWindowState.Minimized) Then
            frmInfProducto.WindowState = FormWindowState.Normal
        End If
        frmInfProducto.Show()
    End Sub
End Class