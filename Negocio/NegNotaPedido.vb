Imports System.Data.SqlClient

Public Class NegNotaPedido

    Dim ClsDatos As New Datos.Conexion
    Dim ClsFunciones As New Funciones
    Dim HayInternet As Boolean = ClsFunciones.GotInternet

    'Funcion que inserta un nuevo registro en la tabla VENTAS.
    Public Function NuevaNotaPedido(ByVal EntNotaPedido As Entidades.NotaPedido, EntDetalleNotaPedido As List(Of Entidades.NotaPedido_Detalle)) As Boolean
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim msg As String = ""
        Dim dt As DataTable = New DataTable()

        'Cargo el detalle de la devolucion en un Tabla para pasarla por un campo al SP
        dt.Columns.Add("id_Producto", Type.GetType("System.Int32"))
        dt.Columns.Add("Cantidad", Type.GetType("System.Int32"))
        dt.Columns.Add("Precio", Type.GetType("System.Double"))

        For Each item As Entidades.NotaPedido_Detalle In EntDetalleNotaPedido
            dt.Rows.Add(item.id_Producto, item.Cantidad, item.Precio)
        Next

        Try
            'Conecto a la bdd.
            If HayInternet Then
                cmd.Connection = ClsDatos.ConectarRemoto()
            Else
                cmd.Connection = ClsDatos.ConectarLocal()
            End If

            'Cargo y ejecuto el stored.
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_NotaPedido_Alta"
            With cmd.Parameters
                .AddWithValue("@id_Cliente", EntNotaPedido.id_Cliente)
                .AddWithValue("@id_Empleado", EntNotaPedido.id_Empleado)
                .AddWithValue("@id_Sucursal", EntNotaPedido.id_Sucursal)
                .AddWithValue("@id_TipoPago", EntNotaPedido.id_TipoPago)
                .AddWithValue("@id_TipoVenta", EntNotaPedido.id_TipoVenta)
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

            'Desconecto la bdd.
            If HayInternet Then
                ClsDatos.DesconectarRemoto()
            Else
                ClsDatos.DesconectarLocal()
            End If

            'retorno valor
            Return CBool(respuesta.Value)
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
