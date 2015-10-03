Imports System.Data.SqlClient

Public Class NegDevolucion
    Dim ClsDatos As New Datos.Conexion
    Dim ClsFunciones As New Funciones
    Dim HayInternet As Boolean = ClsFunciones.GotInternet

    Public Function NuevaDevolucion(ByVal Devolucion As Entidades.Devolucion) As Boolean
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim msg As String = ""
        Dim dt As DataTable = New DataTable()

        'Cargo el detalle de la devolucion en un Tabla para pasarla por un campo al SP
        dt.Columns.Add("id_Producto", Type.GetType("System.Int32"))
        dt.Columns.Add("Cantidad", Type.GetType("System.Int32"))
        dt.Columns.Add("Precio", Type.GetType("System.Double"))

        For Each item As Entidades.Devolucion_Detalle In Devolucion.Detalle
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
            cmd.CommandText = "sp_Devoluion_Alta"

            With cmd.Parameters
                .AddWithValue("@id_Cliente", Devolucion.id_Cliente)
                .AddWithValue("@id_Empleado", Devolucion.id_Empleado)
                .AddWithValue("@id_Encargado", Devolucion.id_Encargado)
                .AddWithValue("@id_Sucursal", Devolucion.id_Sucursal)
                .AddWithValue("@id_TipoPago", Devolucion.id_TipoPago)
                .AddWithValue("@id_TipoDevolucion", Devolucion.id_TipoDevolucion)
                .AddWithValue("@PrecioTotal", Devolucion.PrecioTotal)
                .AddWithValue("@Subtotal", Devolucion.SubTotal)
                .AddWithValue("@CantidadTotal", Devolucion.CantidadTotal)
                .AddWithValue("@Descuento", Devolucion.Descuento)
                .AddWithValue("@Habilitado", Devolucion.Habilitado)
                .AddWithValue("@NotaCredito", Devolucion.NotaCredito)
            End With

            'Declaro el tipo de dato para el detalle de la devolucion
            Dim param = cmd.Parameters.AddWithValue("@Detalle", dt)
            param.SqlDbType = SqlDbType.Structured
            param.TypeName = "dbo.DEVOLUCIONES_DETALLE_TYPE"

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
