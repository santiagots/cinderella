Imports System.Data.SqlClient

Public Class NegDevolucion
    Dim ClsDatos As New Datos.Conexion
    Dim ClsFunciones As New Funciones

    Public Function NuevaDevolucion(ByVal Devolucion As Entidades.Devolucion) As String
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim msg As String = ""
        Dim dt As DataTable = New DataTable()

        'Cargo el detalle de la devolucion en un Tabla para pasarla por un campo al SP
        dt.Columns.Add("id_Detalle", Type.GetType("System.Int64"))
        dt.Columns.Add("id_Producto", Type.GetType("System.Int32"))
        dt.Columns.Add("Cantidad", Type.GetType("System.Int32"))
        dt.Columns.Add("Precio", Type.GetType("System.Double"))
        dt.Columns.Add("Iva", Type.GetType("System.Double"))
        dt.Columns.Add("Monto", Type.GetType("System.Double"))

        For Each item As Entidades.Devolucion_Detalle In Devolucion.Detalle
            dt.Rows.Add(ClsDatos.ObtenerCalveUnica(Devolucion.id_Sucursal), item.id_Producto, item.Cantidad, item.Precio, item.Iva, item.Monto)
        Next

        Devolucion.id_Devolucion = ClsDatos.ObtenerCalveUnica(Devolucion.id_Sucursal)
        Devolucion.FechaEdicion = DateTime.Now

        Try
            cmd.Connection = ClsDatos.ConectarLocal()
            msg = NuevaDevolucion(Devolucion, cmd, dt)
            ClsDatos.DesconectarLocal()

            'retorno valor
            Return msg
        Catch ex As Exception
            Return "0"
        End Try
    End Function

    Private Shared Function NuevaDevolucion(Devolucion As Entidades.Devolucion, ByRef cmd As SqlCommand, dt As DataTable) As String
        'Cargo y ejecuto el stored.
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_Devolucion_Alta"

        With cmd.Parameters
            .AddWithValue("@id_Devolucion", Devolucion.id_Devolucion)
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
            .AddWithValue("@PorcentajeFacturacion", Devolucion.PorcentajeFacturacion)
            .AddWithValue("@Habilitado", Devolucion.Habilitado)
            .AddWithValue("@NotaCredito", Devolucion.NotaCredito)
            .AddWithValue("@FechaEdicion", Devolucion.FechaEdicion)
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
        Return respuesta.Value
    End Function

    'Funcion que obtiene el listado de devoluciones de una sucursal.
    Public Function ObtenerDevolucionesSucursalListado(ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String)
        Return ClsDatos.ConsultarBaseLocal("execute sp_Devolucion_SucursalObtenerListado @id_Sucursal=" & id_Sucursal & ", @FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
    End Function

    'Funcion para consultar un detalle de laa venta.
    Public Function TraerDevolucionDetalle(ByVal id_Devolucion As Int64)
        Return ClsDatos.ConsultarBaseLocal("execute sp_DevolucionDetalle_Listado @id_Devolucion=" & id_Devolucion)
    End Function

    'Funcion para listar todas las devoluciones por FECHA.
    Function ListadoDevolucionesCompletoFecha(ByVal id_Sucursal As Integer, ByVal FDesde As String, ByVal FHasta As String) As DataSet
        Return ClsDatos.ConsultarBaseLocal("execute sp_Devolucion_ListadoCompletoFecha @id_Sucursal=" & id_Sucursal & ",@FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")
    End Function

    'Funcion para consultar una devolucion.
    Public Function TraerDevolucion(ByVal id_Devolucion As Int64)
        Return ClsDatos.ConsultarBaseLocal("execute sp_Devolucion_Detalle @id_Devolucion=" & id_Devolucion)
    End Function

    Function AnularDevolucion(id_Devolucion As Int64, Texto As String) As Integer
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim msg As Integer
        Dim FechaEdicion As DateTime = DateTime.Now()

        If (Texto = "") Then
            Texto = "No se ingreso el motivo."
        End If

        Try
            cmd.Connection = ClsDatos.ConectarLocal()
            msg = AnularDevolucion(id_Devolucion, Texto, FechaEdicion, cmd)
            ClsDatos.DesconectarLocal()

            'retorno valor
            Return msg
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Private Shared Function AnularDevolucion(id_Devolucion As Int64, Texto As String, FechaEdicion As DateTime, ByRef cmd As SqlCommand) As Integer
        'Cargo y ejecuto el stored.
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_Devolucion_Anular"
        With cmd.Parameters
            .AddWithValue("@id_Devolucion", id_Devolucion)
            .AddWithValue("@Texto", Texto)
            .AddWithValue("@Fecha", Now.Date.ToString("yyyy/MM/dd"))
            .AddWithValue("@FechaEdicion", FechaEdicion)
        End With

        'Respuesta del stored.
        Dim respuesta As New SqlParameter("@msg", SqlDbType.Int, 255)
        respuesta.Direction = ParameterDirection.Output
        cmd.Parameters.Add(respuesta)
        cmd.ExecuteNonQuery()

        Return respuesta.Value
    End Function

    'Funcion que actualiza una venta como facturada o no facturada.
    Public Function GeneracionNotaCredito(ByVal credito As Boolean, ByVal id_Devolucion As Int64)
        Dim notaCredito As Integer = 0
        Dim cmd As New SqlCommand
        Dim msg As Boolean
        Dim fechaEdicion As DateTime = DateTime.Now

        If credito Then
            notaCredito = 1
        Else
            notaCredito = 0
        End If

        Try
            cmd.Connection = ClsDatos.ConectarLocal()
            msg = GenerarNotaCredito(id_Devolucion, notaCredito, fechaEdicion, cmd)
            ClsDatos.DesconectarLocal()

            'retorno valor
            Return msg
        Catch ex As Exception
            Return 0
        End Try

    End Function

    Private Shared Function GenerarNotaCredito(id_Devolucion As Int64, notaCredito As Integer, fechaEdicion As DateTime, ByRef cmd As SqlCommand) As Boolean
        'Cargo y ejecuto el stored.
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_Devolucion_GeneracionNotaCredito"
        With cmd.Parameters
            .AddWithValue("@id_Devolucion", id_Devolucion)
            .AddWithValue("@NotaCredito", notaCredito)
            .AddWithValue("@FechaEdicion", fechaEdicion)
        End With

        'Respuesta del stored.
        Dim respuesta As New SqlParameter("@msg", SqlDbType.Int, 255)
        respuesta.Direction = ParameterDirection.Output
        cmd.Parameters.Add(respuesta)
        cmd.ExecuteNonQuery()
        Return CBool(respuesta.Value)
    End Function

    Public Function TotalDevolucionesEfectivo(ByVal id_Sucursal As Integer, ByVal FDesde As String, FHasta As String)
        Dim ds As New DataSet
        ds = ClsDatos.ConsultarBaseLocal("execute sp_Devolucion_TotalDevolucionesEfectivo @id_Sucursal=" & id_Sucursal & ",@FDesde='" & FDesde & "', @FHasta='" & FHasta & "'")

        If ds.Tables(0).Rows.Count = 1 And ds.Tables(0).Rows(0).Item("DevolucionesTotales").ToString <> "" Then
            Return ds.Tables(0).Rows(0).Item("DevolucionesTotales").ToString
        Else
            Return 0
        End If
    End Function

End Class
