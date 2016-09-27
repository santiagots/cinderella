Imports Entidades
Imports System.Data.SqlClient
Imports Datos

Public Class NegNotaPedido

    Dim ClsDatos As New Datos.Conexion
    Dim ClsFunciones As New Funciones

    'Funcion que inserta un nuevo registro en la tabla VENTAS.
    Public Function NuevaNotaPedido(ByVal EntNotaPedido As Entidades.NotaPedido, EntDetalleNotaPedido As List(Of Entidades.NotaPedido_Detalle)) As Boolean
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim msg As Boolean
        Dim dt As DataTable = New DataTable()
        Dim HayInternet As Boolean = Funciones.HayInternet

        'Cargo el detalle de la devolucion en un Tabla para pasarla por un campo al SP
        dt.Columns.Add("id_Producto", Type.GetType("System.Int32"))
        dt.Columns.Add("Cantidad", Type.GetType("System.Int32"))
        dt.Columns.Add("Precio", Type.GetType("System.Double"))

        For Each item As Entidades.NotaPedido_Detalle In EntDetalleNotaPedido
            dt.Rows.Add(item.id_Producto, item.Cantidad, item.Precio)
        Next

        Try
            cmd.Connection = ClsDatos.ConectarLocal()
            msg = NuevaNotaPedido(EntNotaPedido, cmd, dt)
            ClsDatos.DesconectarLocal()

            If HayInternet Then
                cmd = New SqlCommand()
                cmd.Connection = ClsDatos.ConectarLocal()
                msg = NuevaNotaPedido(EntNotaPedido, cmd, dt)
                ClsDatos.DesconectarLocal()
            End If

            Return msg
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Shared Function NuevaNotaPedido(EntNotaPedido As NotaPedido, ByRef cmd As SqlCommand, dt As DataTable) As Boolean
        'Cargo y ejecuto el stored.
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_NotaPedido_Alta"
        With cmd.Parameters
            .AddWithValue("@id_Cliente", EntNotaPedido.id_Cliente)
            .AddWithValue("@id_Empleado", EntNotaPedido.id_Empleado)
            .AddWithValue("@id_Sucursal", EntNotaPedido.id_Sucursal)
            .AddWithValue("@id_TipoPago", EntNotaPedido.id_TipoPago)
            .AddWithValue("@id_TipoVenta", EntNotaPedido.id_TipoVenta)
            .AddWithValue("@id_ListaPrecio", EntNotaPedido.id_ListaPrecio)
            .AddWithValue("@id_ConsumidorFinal", EntNotaPedido.Id_ConsumidorFinal)
            .AddWithValue("@PrecioTotal", EntNotaPedido.PrecioTotal)
            .AddWithValue("@Vendida", If(EntNotaPedido.Vendida, 1, 0))
        End With

        'Declaro el tipo de dato para el detalle de la venta
        Dim param = cmd.Parameters.AddWithValue("@Detalle", dt)
        param.SqlDbType = SqlDbType.Structured
        param.TypeName = "dbo.VENTA_DETALLE_TYPE"

        'Respuesta del stored.
        Dim respuesta As New SqlParameter("@msg", SqlDbType.Int, 255)
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
        Dim HayInternet As Boolean = Funciones.HayInternet

        'Conecto a la bdd.
        If (HayInternet) Then
            dsNotaPedidos = clsDatos.ConsultarBaseRemoto("execute sp_NotaPedido_Consulta_Sucursal @SucursalId=" & SucursalId)
        Else
            dsNotaPedidos = clsDatos.ConsultarBaseLocal("execute sp_NotaPedido_Consulta_Sucursal @SucursalId=" & SucursalId)
        End If

        If dsNotaPedidos.Tables(0).Rows.Count > 0 Then
            For Each row As DataRow In dsNotaPedidos.Tables(0).Rows
                respuesta.Add(GetNotaPedidoFromRow(row))
            Next
        End If

        'retorno valor
        Return respuesta
    End Function

    Public Function TraerDetalle(ByVal NotaPedidoId As Integer) As List(Of NotaPedido_Detalle)
        'Declaro variables
        Dim cmd As SqlCommand = New SqlCommand()
        Dim dsNotaPedidos As DataSet
        Dim respuesta As List(Of NotaPedido_Detalle) = New List(Of NotaPedido_Detalle)()
        Dim HayInternet As Boolean = Funciones.HayInternet

        'Conecto a la bdd.
        If (HayInternet) Then
            dsNotaPedidos = ClsDatos.ConsultarBaseRemoto("execute sp_NotaPedido_Consulta_Detalle @NotaPedidoId=" & NotaPedidoId)
        Else
            dsNotaPedidos = ClsDatos.ConsultarBaseLocal("execute sp_NotaPedido_Consulta_Detalle @NotaPedidoId=" & NotaPedidoId)
        End If

        If dsNotaPedidos.Tables(0).Rows.Count > 0 Then
            For Each row As DataRow In dsNotaPedidos.Tables(0).Rows
                respuesta.Add(GetNotaPedidoDetalleFromRow(row))
            Next
        End If

        'retorno valor
        Return respuesta
    End Function

    Public Function BorrarNota(ByVal NotaPedidoId As Integer) As Boolean
        'Declaro variables
        Dim msg As Boolean
        Dim cmd As SqlCommand = New SqlCommand()
        Dim HayInternet As Boolean = Funciones.HayInternet

        cmd.Connection = ClsDatos.ConectarLocal()
        msg = BorrarNota(NotaPedidoId, cmd)
        ClsDatos.DesconectarLocal()

        If HayInternet Then
            cmd = New SqlCommand()
            cmd.Connection = ClsDatos.ConectarRemoto()
            msg = BorrarNota(NotaPedidoId, cmd)
            ClsDatos.DesconectarRemoto()
        End If

        Return msg
    End Function

    Private Shared Function BorrarNota(NotaPedidoId As Integer, ByRef cmd As SqlCommand) As Boolean
        'Cargo y ejecuto el stored.
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_NotaPedido_Eliminar"
        With cmd.Parameters
            .AddWithValue("@NotaPedidoId", NotaPedidoId)
        End With

        'Respuesta del stored.
        Dim respuesta As New SqlParameter("@msg", SqlDbType.Bit, 1)
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
        notaPedido.Id_ConsumidorFinal = If(row.Item("Id_ConsumidorFinal") Is DBNull.Value, 0, row.Item("Id_ConsumidorFinal"))
        notaPedido.id_Empleado = If(row.Item("id_Empleado") Is DBNull.Value, 0, row.Item("id_Empleado"))
        notaPedido.id_NotaPedido = If(row.Item("id_NotaPedido") Is DBNull.Value, 0, row.Item("id_NotaPedido"))
        notaPedido.id_Sucursal = If(row.Item("id_Sucursal") Is DBNull.Value, 0, row.Item("id_Sucursal"))
        notaPedido.id_TipoPago = If(row.Item("id_TipoPago") Is DBNull.Value, 0, row.Item("id_TipoPago"))
        notaPedido.id_TipoVenta = If(row.Item("id_TipoVenta") Is DBNull.Value, 0, row.Item("id_TipoVenta"))
        notaPedido.id_ListaPrecio = If(row.Item("id_ListaPrecio") Is DBNull.Value, 0, row.Item("id_ListaPrecio"))
        notaPedido.PrecioTotal = row.Item("PrecioTotal").ToString
        notaPedido.RazonSocialCliente = row.Item("RazonSocialCliente").ToString
        notaPedido.Vendida = row.Item("Vendida").ToString
        notaPedido.TipoVentaDescripcion = row.Item("TipoVentaDescripcion").ToString()
        notaPedido.TipoPagoDescripcion = row.Item("TipoPagoDescripcion").ToString()

        Return notaPedido
    End Function

    Private Function GetNotaPedidoDetalleFromRow(row As DataRow) As NotaPedido_Detalle
        Dim notaPedidoDetalle As NotaPedido_Detalle = New NotaPedido_Detalle()

        notaPedidoDetalle.Cantidad = row.Item("Cantidad")
        notaPedidoDetalle.id_Detalle = row.Item("id_Detalle")
        notaPedidoDetalle.id_Producto = row.Item("id_Producto")
        notaPedidoDetalle.id_NotaPedido = row.Item("id_NotaPedido")
        notaPedidoDetalle.Precio = row.Item("Precio")

        Return notaPedidoDetalle
    End Function

End Class
