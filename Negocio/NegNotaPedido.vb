Imports Entidades
Imports System.Data.SqlClient
Imports Datos

Public Class NegNotaPedido

    Dim ClsDatos As New Datos.Conexion
    Dim ClsFunciones As New Funciones

    'Funcion que inserta un nuevo registro en la tabla VENTAS.
    Public Function NuevaNotaPedido(ByVal EntNotaPedido As Entidades.NotaPedido, EntDetalleNotaPedido As List(Of Entidades.NotaPedido_Detalle), sucursal As Integer) As Int64
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim resultadoOk As Boolean
        Dim dt As DataTable = New DataTable()

        'Cargo el detalle de la devolucion en un Tabla para pasarla por un campo al SP
        dt.Columns.Add("id_Detalle", Type.GetType("System.Int64"))
        dt.Columns.Add("id_Producto", Type.GetType("System.Int32"))
        dt.Columns.Add("Cantidad", Type.GetType("System.Int32"))
        dt.Columns.Add("Precio", Type.GetType("System.Double"))
        dt.Columns.Add("Iva", Type.GetType("System.Double"))
        dt.Columns.Add("Monto", Type.GetType("System.Double"))

        For Each item As Entidades.NotaPedido_Detalle In EntDetalleNotaPedido
            dt.Rows.Add(ClsDatos.ObtenerCalveUnica(sucursal), item.id_Producto, item.Cantidad, item.Precio, item.Iva, item.Monto)
        Next

        EntNotaPedido.Numero = ConsultarProximoNumero(EntNotaPedido.id_Sucursal)
        EntNotaPedido.id_NotaPedido = ClsDatos.ObtenerCalveUnica(sucursal)
        EntNotaPedido.FechaEdicion = DateTime.Now

        Try
            cmd.Connection = ClsDatos.ConectarLocal()
            resultadoOk = NuevaNotaPedido(EntNotaPedido, cmd, dt)
            ClsDatos.DesconectarLocal()

            If Not resultadoOk Then
                Throw New Exception("No se ha podido dar de alta la nota de pedido en la base local.")
            End If

            Return EntNotaPedido.id_NotaPedido
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Shared Function NuevaNotaPedido(EntNotaPedido As NotaPedido, ByRef cmd As SqlCommand, dt As DataTable) As Boolean
        'Cargo y ejecuto el stored.
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_NotaPedido_Alta"
        With cmd.Parameters
            .AddWithValue("@id_NotaPedido", EntNotaPedido.id_NotaPedido)
            .AddWithValue("@id_Cliente", EntNotaPedido.id_Cliente)
            .AddWithValue("@PorcentajeFacturacion", EntNotaPedido.PorcentajeFacturacion)
            .AddWithValue("@PorcentajeDescuento", EntNotaPedido.PorcentajeDescuento)
            .AddWithValue("@id_Empleado", EntNotaPedido.id_Empleado)
            .AddWithValue("@id_Encargado", EntNotaPedido.id_Encargado)
            .AddWithValue("@id_Sucursal", EntNotaPedido.id_Sucursal)
            .AddWithValue("@id_TipoPago", EntNotaPedido.id_TipoPago)
            .AddWithValue("@id_TipoVenta", EntNotaPedido.id_TipoVenta)
            .AddWithValue("@id_ListaPrecio", EntNotaPedido.id_ListaPrecio)
            .AddWithValue("@id_ConsumidorFinal", EntNotaPedido.Id_ConsumidorFinal)
            .AddWithValue("@id_tarjeta", EntNotaPedido.Id_Tarjeta)
            .AddWithValue("@Numero", EntNotaPedido.Numero)
            .AddWithValue("@CantidadCuotas", EntNotaPedido.CantidadCuotas)
            .AddWithValue("@PrecioTotal", EntNotaPedido.PrecioTotal)
            .AddWithValue("@Vendida", If(EntNotaPedido.Vendida, 1, 0))
            .AddWithValue("@Fecha_Edicion", EntNotaPedido.FechaEdicion)
        End With

        'Declaro el tipo de dato para el detalle de la venta
        Dim param = cmd.Parameters.AddWithValue("@Detalle", dt)
        param.SqlDbType = SqlDbType.Structured
        param.TypeName = "dbo.NOTAPEDIDO_DETALLE_TYPE"

        'Respuesta del stored.
        Dim respuesta As New SqlParameter("@msg", SqlDbType.Bit, 255)
        respuesta.Direction = ParameterDirection.Output
        cmd.Parameters.Add(respuesta)
        cmd.ExecuteNonQuery()
        Return respuesta.Value
    End Function

    Public Function ActualizarNotaPedido(ByVal EntNotaPedido As Entidades.NotaPedido, EntDetalleNotaPedido As List(Of Entidades.NotaPedido_Detalle), sucursal As Integer) As Boolean
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim resultadoOk As Boolean
        Dim dt As DataTable = New DataTable()

        'Cargo el detalle de la devolucion en un Tabla para pasarla por un campo al SP
        dt.Columns.Add("id_Detalle", Type.GetType("System.Int64"))
        dt.Columns.Add("id_Producto", Type.GetType("System.Int32"))
        dt.Columns.Add("Cantidad", Type.GetType("System.Int32"))
        dt.Columns.Add("Precio", Type.GetType("System.Double"))
        dt.Columns.Add("Iva", Type.GetType("System.Double"))
        dt.Columns.Add("Monto", Type.GetType("System.Double"))

        For Each item As Entidades.NotaPedido_Detalle In EntDetalleNotaPedido
            dt.Rows.Add(ClsDatos.ObtenerCalveUnica(sucursal), item.id_Producto, item.Cantidad, item.Precio, item.Iva, item.Monto)
        Next

        EntNotaPedido.FechaEdicion = DateTime.Now

        Try
            cmd.Connection = ClsDatos.ConectarLocal()
            resultadoOk = ActualizarNotaPedido(EntNotaPedido, cmd, dt)
            ClsDatos.DesconectarLocal()

            If Not resultadoOk Then
                Throw New Exception("No se ha podido actualizar la nota de pedido en la base local.")
            End If

            Return resultadoOk
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Shared Function ActualizarNotaPedido(EntNotaPedido As NotaPedido, ByRef cmd As SqlCommand, dt As DataTable) As Int64
        'Cargo y ejecuto el stored.
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_NotaPedido_Actualizar"
        With cmd.Parameters
            .AddWithValue("@id_NotaPedido", EntNotaPedido.id_NotaPedido)
            .AddWithValue("@id_Cliente", EntNotaPedido.id_Cliente)
            .AddWithValue("@PorcentajeFacturacion", EntNotaPedido.PorcentajeFacturacion)
            .AddWithValue("@id_Empleado", EntNotaPedido.id_Empleado)
            .AddWithValue("@id_Encargado", EntNotaPedido.id_Encargado)
            .AddWithValue("@id_Sucursal", EntNotaPedido.id_Sucursal)
            .AddWithValue("@id_TipoPago", EntNotaPedido.id_TipoPago)
            .AddWithValue("@id_TipoVenta", EntNotaPedido.id_TipoVenta)
            .AddWithValue("@id_ListaPrecio", EntNotaPedido.id_ListaPrecio)
            .AddWithValue("@id_ConsumidorFinal", EntNotaPedido.Id_ConsumidorFinal)
            .AddWithValue("@id_tarjeta", EntNotaPedido.Id_Tarjeta)
            .AddWithValue("@CantidadCuotas", EntNotaPedido.CantidadCuotas)
            .AddWithValue("@PrecioTotal", EntNotaPedido.PrecioTotal)
            .AddWithValue("@Vendida", If(EntNotaPedido.Vendida, 1, 0))
            .AddWithValue("@Fecha_Edicion", EntNotaPedido.FechaEdicion)
        End With

        'Declaro el tipo de dato para el detalle de la venta
        Dim param = cmd.Parameters.AddWithValue("@Detalle", dt)
        param.SqlDbType = SqlDbType.Structured
        param.TypeName = "dbo.NOTAPEDIDO_DETALLE_TYPE"

        'Respuesta del stored.
        Dim respuesta As New SqlParameter("@msg", SqlDbType.BigInt, 255)
        respuesta.Direction = ParameterDirection.Output
        cmd.Parameters.Add(respuesta)
        cmd.ExecuteNonQuery()
        Return respuesta.Value
    End Function

    Public Function TraerNotas(ByVal SucursalId As Integer) As List(Of NotaPedido)
        'Declaro variables
        Dim cmd As SqlCommand = New SqlCommand()
        Dim dsNotaPedidos As DataSet
        Dim respuesta As List(Of NotaPedido) = New List(Of NotaPedido)()

        dsNotaPedidos = ClsDatos.ConsultarBaseLocal("execute sp_NotaPedido_Consulta_Sucursal @SucursalId=" & SucursalId)

        If dsNotaPedidos.Tables(0).Rows.Count > 0 Then
            For Each row As DataRow In dsNotaPedidos.Tables(0).Rows
                respuesta.Add(GetNotaPedidoFromRow(row))
            Next
        End If

        'retorno valor
        Return respuesta
    End Function

    Public Function TraerDetalle(ByVal NotaPedidoId As Int64) As List(Of NotaPedido_Detalle)
        'Declaro variables
        Dim cmd As SqlCommand = New SqlCommand()
        Dim dsNotaPedidos As DataSet
        Dim respuesta As List(Of NotaPedido_Detalle) = New List(Of NotaPedido_Detalle)()

        dsNotaPedidos = ClsDatos.ConsultarBaseLocal("execute sp_NotaPedido_Consulta_Detalle @NotaPedidoId=" & NotaPedidoId)

        If dsNotaPedidos.Tables(0).Rows.Count > 0 Then
            For Each row As DataRow In dsNotaPedidos.Tables(0).Rows
                respuesta.Add(GetNotaPedidoDetalleFromRow(row))
            Next
        End If

        'retorno valor
        Return respuesta
    End Function

    Public Function BorrarNota(ByVal NotaPedidoId As Int64) As Boolean
        'Declaro variables
        Dim msg As Boolean
        Dim cmd As SqlCommand = New SqlCommand()

        Dim fechaEdicion As DateTime = DateTime.Now

        cmd.Connection = ClsDatos.ConectarLocal()
        msg = BorrarNota(NotaPedidoId, fechaEdicion, cmd)
        ClsDatos.DesconectarLocal()

        Return msg
    End Function

    Private Shared Function BorrarNota(NotaPedidoId As Int64, FechaEdicion As Date, ByRef cmd As SqlCommand) As Boolean
        'Cargo y ejecuto el stored.
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_NotaPedido_Eliminar"
        With cmd.Parameters
            .AddWithValue("@id_NotaPedido", NotaPedidoId)
            .AddWithValue("@Fecha_Edicion", FechaEdicion)
        End With

        'Respuesta del stored.
        Dim respuesta As New SqlParameter("@msg", SqlDbType.Bit, 1)
        respuesta.Direction = ParameterDirection.Output
        cmd.Parameters.Add(respuesta)
        cmd.ExecuteNonQuery()
        Return respuesta.Value
    End Function

    Private Function ConsultarProximoNumero(IdSucursal As Integer) As Integer
        Dim cmd As SqlCommand = New SqlCommand()
        cmd.Connection = ClsDatos.ConectarLocal()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_NotaPedido_Consulta_Numero"
        With cmd.Parameters
            .AddWithValue("@id_Sucursal", IdSucursal)
        End With

        'Respuesta del stored.
        Dim respuesta As New SqlParameter("@numero", SqlDbType.Int)
        respuesta.Direction = ParameterDirection.Output
        cmd.Parameters.Add(respuesta)
        cmd.ExecuteNonQuery()
        Return respuesta.Value
    End Function

    Private Function GetNotaPedidoFromRow(row As DataRow) As NotaPedido
        Dim notaPedido As NotaPedido = New NotaPedido()

        notaPedido.ConsumidorFinalNombreYApellido = row.Item("ConsumidorFinalNombreYApellido").ToString
        notaPedido.EmpleadoNombreyApellido = row.Item("EmpleadoNombreyApellido").ToString
        notaPedido.Fecha = row.Item("Fecha").ToString
        notaPedido.id_Cliente = If(row.Item("id_Cliente") Is DBNull.Value, 0, row.Item("id_Cliente"))
        notaPedido.PorcentajeFacturacion = If(row.Item("PorcentajeFacturacion") Is DBNull.Value, 0, row.Item("PorcentajeFacturacion"))
        notaPedido.PorcentajeDescuento = If(row.Item("PorcentajeDescuento") Is DBNull.Value, 0, row.Item("PorcentajeDescuento"))
        notaPedido.Id_ConsumidorFinal = If(row.Item("Id_ConsumidorFinal") Is DBNull.Value, 0, row.Item("Id_ConsumidorFinal"))
        notaPedido.id_Empleado = If(row.Item("id_Empleado") Is DBNull.Value, 0, row.Item("id_Empleado"))
        notaPedido.id_Encargado = If(row.Item("id_Encargado") Is DBNull.Value, 0, row.Item("id_Encargado"))
        notaPedido.id_NotaPedido = If(row.Item("id_NotaPedido") Is DBNull.Value, 0, row.Item("id_NotaPedido"))
        notaPedido.id_Sucursal = If(row.Item("id_Sucursal") Is DBNull.Value, 0, row.Item("id_Sucursal"))
        notaPedido.id_TipoPago = If(row.Item("id_TipoPago") Is DBNull.Value, 0, row.Item("id_TipoPago"))
        notaPedido.id_TipoVenta = If(row.Item("id_TipoVenta") Is DBNull.Value, 0, row.Item("id_TipoVenta"))
        notaPedido.id_ListaPrecio = If(row.Item("id_ListaPrecio") Is DBNull.Value, 0, row.Item("id_ListaPrecio"))
        notaPedido.Id_Tarjeta = If(row.Item("id_Tarjeta") Is DBNull.Value, 0, row.Item("id_Tarjeta"))
        notaPedido.CantidadCuotas = If(row.Item("CantidadCuotas") Is DBNull.Value, 0, row.Item("CantidadCuotas"))
        notaPedido.PrecioTotal = row.Item("PrecioTotal").ToString
        notaPedido.RazonSocialCliente = row.Item("RazonSocialCliente").ToString
        notaPedido.Vendida = row.Item("Vendida").ToString
        notaPedido.TipoVentaDescripcion = row.Item("TipoVentaDescripcion").ToString()
        notaPedido.TipoPagoDescripcion = row.Item("TipoPagoDescripcion").ToString()
        notaPedido.Numero = row.Item("Numero")

        Return notaPedido
    End Function

    Private Function GetNotaPedidoDetalleFromRow(row As DataRow) As NotaPedido_Detalle
        Dim notaPedidoDetalle As NotaPedido_Detalle = New NotaPedido_Detalle()

        notaPedidoDetalle.Cantidad = row.Item("Cantidad")
        notaPedidoDetalle.id_Detalle = row.Item("id_Detalle")
        notaPedidoDetalle.id_Producto = row.Item("id_Producto")
        notaPedidoDetalle.id_NotaPedido = row.Item("id_NotaPedido")
        notaPedidoDetalle.Precio = row.Item("Precio")
        notaPedidoDetalle.Iva = row.Item("Iva")
        notaPedidoDetalle.Monto = row.Item("Monto")

        Return notaPedidoDetalle
    End Function

End Class
