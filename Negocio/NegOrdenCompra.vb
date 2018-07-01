Imports System.Data.SqlClient
Imports System.Globalization
Imports Entidades

Public Class NegOrdenCompra
    Dim clsDatos As New Datos.Conexion
    Public Function Obtener(idStockPedido As Int64) As OrdenCompra
        Dim dsStockPedido As New DataSet
        Dim dsStockPedidoDetalle As New DataSet
        Dim entStockPedido As OrdenCompra = New OrdenCompra()
        entStockPedido.Detalles = New List(Of OrdenCompraDetalle)()

        dsStockPedido = clsDatos.ConsultarBaseLocal("execute sp_OrdenCompra_Obtener @id_StockNotaPedido=" & idStockPedido)

        If dsStockPedido.Tables(0).Rows.Count <> 0 Then
            entStockPedido = ObtenerStockPedido(dsStockPedido.Tables(0).Rows(0))
            For Each drStockPedidoDetalle As DataRow In dsStockPedido.Tables(0).Rows
                entStockPedido.Detalles.Add(ObtenerStockPedidoDetalle(drStockPedidoDetalle))
            Next
        End If
        Return entStockPedido
    End Function

    Public Function Obtener(idSucursal As Integer, fechaDesde As Date, fechaHasta As Date) As List(Of OrdenCompra)
        Dim dsStockPedido As New DataSet
        Dim entStockPedido As List(Of OrdenCompra) = New List(Of OrdenCompra)

        dsStockPedido = clsDatos.ConsultarBaseRemoto("execute sp_OrdenCompra_Obtener_Listado @id_Sucursal=" & idSucursal & " ,@fechaDesde='" & fechaDesde.ToString("yyyy/MM/dd") & "' ,@fechaHasta='" & fechaHasta.ToString("yyyy/MM/dd") & "'")

        If dsStockPedido.Tables(0).Rows.Count <> 0 Then
            For Each row As DataRow In dsStockPedido.Tables(0).Rows
                Dim stockPedido As OrdenCompra = entStockPedido.FirstOrDefault(Function(x) x.idOrdenCompra = row("idOrdenCompra"))
                If stockPedido Is Nothing Then
                    stockPedido = ObtenerStockPedido(row)
                    entStockPedido.Add(stockPedido)
                End If
                stockPedido.Detalles.Add(ObtenerStockPedidoDetalle(row))
            Next
        End If
        Return entStockPedido
    End Function

    Public Function Obtener(idSucursal As Integer, estado As OrdenCompraPedidoEstado) As List(Of OrdenCompra)
        Dim dsStockPedido As New DataSet
        Dim entStockPedido As List(Of OrdenCompra) = New List(Of OrdenCompra)

        dsStockPedido = clsDatos.ConsultarBaseRemoto("execute sp_OrdenCompra_Obtener_ListadoEstado @id_Sucursal=" & idSucursal & " ,@estado=" & estado)

        If dsStockPedido.Tables(0).Rows.Count <> 0 Then
            For Each row As DataRow In dsStockPedido.Tables(0).Rows
                Dim stockPedido As OrdenCompra = entStockPedido.FirstOrDefault(Function(x) x.idOrdenCompra = row("idOrdenCompra"))
                If stockPedido Is Nothing Then
                    stockPedido = ObtenerStockPedido(row)
                    entStockPedido.Add(stockPedido)
                End If
                stockPedido.Detalles.Add(ObtenerStockPedidoDetalle(row))
            Next
        End If
        Return entStockPedido
    End Function

    Public Function Obtener(idSucursal As Integer, idProveedor As Integer) As List(Of OrdenCompra)
        Dim dsStockPedido As New DataSet
        Dim entStockPedido As List(Of OrdenCompra) = New List(Of OrdenCompra)

        dsStockPedido = clsDatos.ConsultarBaseRemoto("execute sp_OrdenCompra_Obtener_ListadoProveedor @id_Sucursal=" & idSucursal & " ,@id_Proveedor=" & idProveedor)

        If dsStockPedido.Tables(0).Rows.Count <> 0 Then
            For Each row As DataRow In dsStockPedido.Tables(0).Rows
                Dim stockPedido As OrdenCompra = entStockPedido.FirstOrDefault(Function(x) x.idOrdenCompra = row("idOrdenCompra"))
                If stockPedido Is Nothing Then
                    stockPedido = ObtenerStockPedido(row)
                    entStockPedido.Add(stockPedido)
                End If
                stockPedido.Detalles.Add(ObtenerStockPedidoDetalle(row))
            Next
        End If
        Return entStockPedido
    End Function

    Public Function Guardar(stockNotaPedido As OrdenCompra) As Int64
        Dim cmd As New SqlCommand

        stockNotaPedido.idOrdenCompra = clsDatos.ObtenerCalveUnica(stockNotaPedido.idSucursal)
        stockNotaPedido.FechaEdicion = DateTime.Now

        For Each item As OrdenCompraDetalle In stockNotaPedido.Detalles
            item.idOrdenCompraDetalle = clsDatos.ObtenerCalveUnica(stockNotaPedido.idSucursal)
            item.FechaEdicion = stockNotaPedido.FechaEdicion
        Next

        Dim dt As DataTable = CrearDetalleDT(stockNotaPedido)

        cmd.Connection = clsDatos.ConectarLocal()
        Guardar(stockNotaPedido, cmd, dt)
        clsDatos.DesconectarLocal()

        'retorno valor
        Return stockNotaPedido.idOrdenCompra
    End Function

    Private Shared Function Guardar(stockNotaPedido As OrdenCompra, ByRef cmd As SqlCommand, dt As DataTable) As Boolean
        'Cargo y ejecuto el stored.
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_OrdenCompra_Alta"
        With cmd.Parameters
            .AddWithValue("@idEncargado", stockNotaPedido.idEncargado)
            .AddWithValue("@idProveedor", stockNotaPedido.idProveedor)
            .AddWithValue("@idOrdenCompra", stockNotaPedido.idOrdenCompra)
            .AddWithValue("@idSucursal", stockNotaPedido.idSucursal)
            .AddWithValue("@estado", stockNotaPedido.Estado)
            .AddWithValue("@tipo", stockNotaPedido.Tipo)
            .AddWithValue("@fecha", stockNotaPedido.Fecha)
            .AddWithValue("@fechaEdicion", stockNotaPedido.FechaEdicion)
        End With

        'Declaro el tipo de dato para el detalle de la venta
        Dim param = cmd.Parameters.AddWithValue("@Detalle", dt)
        param.SqlDbType = SqlDbType.Structured
        param.TypeName = "dbo.ORDEN_COMPRA_DETALLE"

        Dim respuesta As New SqlParameter("@msg", SqlDbType.Int, 255)
        respuesta.Direction = ParameterDirection.Output
        cmd.Parameters.Add(respuesta)
        cmd.ExecuteNonQuery()

        Return CBool(respuesta.Value)
    End Function

    Public Sub Eliminar(StockNotaPedido As OrdenCompra)
        Dim cmd As New SqlCommand

        StockNotaPedido.FechaEdicion = DateTime.Now

        cmd.Connection = clsDatos.ConectarLocal()
        Eliminar(StockNotaPedido, cmd)
        clsDatos.DesconectarLocal()

    End Sub

    Private Shared Function Eliminar(stockNotaPedido As OrdenCompra, ByRef cmd As SqlCommand) As Boolean
        'Cargo y ejecuto el stored.
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_OrdenCompra_Eliminar"
        With cmd.Parameters
            .AddWithValue("@idOrdenCompra", stockNotaPedido.idOrdenCompra)
        End With

        Dim respuesta As New SqlParameter("@msg", SqlDbType.Int, 255)
        respuesta.Direction = ParameterDirection.Output
        cmd.Parameters.Add(respuesta)
        cmd.ExecuteNonQuery()

        Return CBool(respuesta.Value)
    End Function

    Private Shared Function ObtenerStockPedido(drStockPedido As DataRow) As OrdenCompra
        Return New OrdenCompra With {
            .Detalles = New List(Of OrdenCompraDetalle)(),
            .NombreSucursal = drStockPedido("NombreSucursal"),
            .NombreProveedor = drStockPedido("NombreProveedor"),
            .NombreEncargado = drStockPedido("NombreEncargado"),
            .idSucursal = drStockPedido("idSucursal"),
            .idOrdenCompra = drStockPedido("idOrdenCompra"),
            .idProveedor = drStockPedido("idProveedor"),
            .idEncargado = drStockPedido("idEncargado"),
            .Estado = drStockPedido("Estado"),
            .Tipo = drStockPedido("Tipo"),
            .FechaEdicion = drStockPedido("FechaEdicion"),
            .Fecha = drStockPedido("Fecha")
        }
    End Function

    Private Shared Function ObtenerStockPedidoDetalle(drStockPedidoDetalle As DataRow) As OrdenCompraDetalle
        Return New OrdenCompraDetalle With {
            .Cantidad = drStockPedidoDetalle("Cantidad"),
            .Costo = drStockPedidoDetalle("Costo"),
            .Codigo = drStockPedidoDetalle("Codigo"),
            .FechaEdicion = drStockPedidoDetalle("FechaEdicion"),
            .idProducto = drStockPedidoDetalle("idProducto"),
            .idOrdenCompra = drStockPedidoDetalle("idOrdenCompra"),
            .idOrdenCompraDetalle = drStockPedidoDetalle("idOrdenCompraDetalle"),
            .Nombre = drStockPedidoDetalle("Nombre"),
            .Verificado = If(drStockPedidoDetalle("Verificado") Is DBNull.Value, False, drStockPedidoDetalle("Verificado")),
            .Importe = .Cantidad * .Costo
        }
    End Function

    Public Function Modificar(stockNotaPedido As OrdenCompra) As Int64
        Dim cmd As New SqlCommand

        stockNotaPedido.FechaEdicion = DateTime.Now

        For Each item As OrdenCompraDetalle In stockNotaPedido.Detalles
            If item.idOrdenCompraDetalle = 0 Then
                item.idOrdenCompraDetalle = clsDatos.ObtenerCalveUnica(stockNotaPedido.idSucursal)
            End If
            item.FechaEdicion = stockNotaPedido.FechaEdicion
        Next

        Dim dt As DataTable = CrearDetalleDT(stockNotaPedido)

        cmd.Connection = clsDatos.ConectarLocal()
        Modificar(stockNotaPedido, cmd, dt)
        clsDatos.DesconectarLocal()

        'retorno valor
        Return stockNotaPedido.idOrdenCompra
    End Function

    Private Shared Function Modificar(stockNotaPedido As OrdenCompra, ByRef cmd As SqlCommand, dt As DataTable) As Boolean
        'Cargo y ejecuto el stored.
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_OrdenCompra_Modificar"
        With cmd.Parameters
            .AddWithValue("@idEncargado", stockNotaPedido.idEncargado)
            .AddWithValue("@idProveedor", stockNotaPedido.idProveedor)
            .AddWithValue("@idOrdenCompra", stockNotaPedido.idOrdenCompra)
            .AddWithValue("@idSucursal", stockNotaPedido.idSucursal)
            .AddWithValue("@estado", stockNotaPedido.Estado)
            .AddWithValue("@tipo", stockNotaPedido.Tipo)
            .AddWithValue("@fecha", stockNotaPedido.Fecha)
            .AddWithValue("@fechaEdicion", stockNotaPedido.FechaEdicion)
        End With

        'Declaro el tipo de dato para el detalle de la venta
        Dim param = cmd.Parameters.AddWithValue("@Detalle", dt)
        param.SqlDbType = SqlDbType.Structured
        param.TypeName = "dbo.ORDEN_COMPRA_DETALLE"

        Dim respuesta As New SqlParameter("@msg", SqlDbType.Int, 255)
        respuesta.Direction = ParameterDirection.Output
        cmd.Parameters.Add(respuesta)
        cmd.ExecuteNonQuery()

        Return CBool(respuesta.Value)
    End Function

    Public Function Recibir(stockNotaPedido As OrdenCompra) As Int64
        Dim cmd As New SqlCommand

        stockNotaPedido.FechaEdicion = DateTime.Now

        For Each item As OrdenCompraDetalle In stockNotaPedido.Detalles
            item.FechaEdicion = stockNotaPedido.FechaEdicion
        Next

        Dim dt As DataTable = CrearDetalleDT(stockNotaPedido)

        cmd.Connection = clsDatos.ConectarLocal()
        Recibir(stockNotaPedido, cmd, dt)
        clsDatos.DesconectarLocal()

        'retorno valor
        Return stockNotaPedido.idOrdenCompra
    End Function

    Private Shared Function Recibir(stockNotaPedido As OrdenCompra, ByRef cmd As SqlCommand, dt As DataTable) As Boolean
        'Cargo y ejecuto el stored.
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_OrdenCompra_Recibir"
        With cmd.Parameters
            .AddWithValue("@idOrdenCompra", stockNotaPedido.idOrdenCompra)
            .AddWithValue("@idSucursal", stockNotaPedido.idSucursal)
            .AddWithValue("@estado", stockNotaPedido.Estado)
            .AddWithValue("@fechaEdicion", stockNotaPedido.FechaEdicion)
        End With

        'Declaro el tipo de dato para el detalle de la venta
        Dim param = cmd.Parameters.AddWithValue("@Detalle", dt)
        param.SqlDbType = SqlDbType.Structured
        param.TypeName = "dbo.ORDEN_COMPRA_DETALLE"

        Dim respuesta As New SqlParameter("@msg", SqlDbType.Int, 255)
        respuesta.Direction = ParameterDirection.Output
        cmd.Parameters.Add(respuesta)
        cmd.ExecuteNonQuery()

        Return CBool(respuesta.Value)
    End Function

    Private Shared Function CrearDetalleDT(stockNotaPedido As OrdenCompra) As DataTable
        Dim dt As DataTable = New DataTable()

        'Cargo el detalle de la devolucion en un Tabla para pasarla por un campo al SP
        dt.Columns.Add("idOrdenCompraDetalle", Type.GetType("System.Int64"))
        dt.Columns.Add("idOrdenCompra", Type.GetType("System.Int64"))
        dt.Columns.Add("idProducto", Type.GetType("System.Int32"))
        dt.Columns.Add("Cantidad", Type.GetType("System.Int32"))
        dt.Columns.Add("Costo", Type.GetType("System.Double"))
        dt.Columns.Add("FechaEdicion", Type.GetType("System.DateTime"))
        dt.Columns.Add("Verificado", Type.GetType("System.Boolean"))

        For Each item As OrdenCompraDetalle In stockNotaPedido.Detalles
            dt.Rows.Add(item.idOrdenCompraDetalle, stockNotaPedido.idOrdenCompra, item.idProducto, item.Cantidad, item.Costo, item.FechaEdicion, item.Verificado)
        Next

        Return dt
    End Function
End Class
