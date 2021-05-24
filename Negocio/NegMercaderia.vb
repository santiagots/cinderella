Imports Entidades
Imports System.Data.SqlClient
Imports Datos
Public Class NegMercaderia
    Dim clsDatos As New Datos.Conexion
    Dim ClsFunciones As New Funciones

    'Funcion para listar todos los productos.
    Function ListadoMercaderia(ByVal id_Sucursal As Integer) As DataSet
        Return clsDatos.ConsultarBaseLocal("execute sp_Mercaderia_ListadoSucursal @id_Sucursal=" & id_Sucursal)
    End Function

    'Funcion para consultar un detalle de pedido de mercadería.
    Function ObtenerDetalleMercaderia(ByVal id_Mercaderia As Int64) As DataSet
        Return clsDatos.ConsultarBaseLocal("execute sp_Mercaderia_DetalleProd @id_Mercaderia=" & id_Mercaderia)
    End Function

    'Funcion para consultar un pedido de mercadería.
    Public Function TraerMercaderia(ByVal id_Mercaderia As Int64)
        Return clsDatos.ConsultarBaseLocal("execute sp_Mercaderia_Detalle @id_Mercaderia=" & id_Mercaderia)
    End Function

    'Funcion para insertar una Mercaderia.
    Function AltaMercaderia(ByVal EMercaderia As Entidades.Mercaderias) As Int64
        'Declaro variables
        Dim cmd As New SqlCommand

        EMercaderia.id_Mercaderia = clsDatos.ObtenerCalveUnica(EMercaderia.id_Sucursal)
        EMercaderia.FechaEdicion = Date.Now()

        Try
            cmd.Connection = clsDatos.ConectarLocal()
            AltaMercaderia(EMercaderia, cmd)
            clsDatos.DesconectarLocal()

            'muestro el mensaje
            Return EMercaderia.id_Mercaderia
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Private Shared Function AltaMercaderia(EMercaderia As Mercaderias, ByRef cmd As SqlCommand) As String
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_Mercaderia_Alta"
        With cmd.Parameters
            .AddWithValue("@id_Mercaderia", EMercaderia.id_Mercaderia)
            .AddWithValue("@id_Sucursal", EMercaderia.id_Sucursal)
            .AddWithValue("@id_Proveedor", EMercaderia.id_Proveedor)
            .AddWithValue("@Fecha", EMercaderia.Fecha)
            .AddWithValue("@CantidadTotal", EMercaderia.CantidadTotal)
            .AddWithValue("@MontoTotal", EMercaderia.MontoTotal)
            .AddWithValue("@FechaEdicion", EMercaderia.FechaEdicion)
            .AddWithValue("@Habilitado", EMercaderia.Habilitado)
        End With
        Dim respuesta As New SqlParameter("@msg", SqlDbType.VarChar, 255)
        respuesta.Direction = ParameterDirection.Output
        cmd.Parameters.Add(respuesta)
        cmd.ExecuteNonQuery()
        Return respuesta.Value
    End Function

    Function AltaMercaderiaDetalle(ByVal EMercaderiaDetalle As Entidades.Mercaderias_Detalle, idSucursal As Integer) As String
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim msg As String = ""

        EMercaderiaDetalle.id_Detalle = clsDatos.ObtenerCalveUnica(idSucursal)
        EMercaderiaDetalle.FechaEdicion = Date.Now()

        Try
            cmd.Connection = clsDatos.ConectarLocal()
            msg = AltaMercaderiaDetalle(EMercaderiaDetalle, cmd)
            clsDatos.DesconectarLocal()

            Return msg
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Private Function AltaMercaderiaDetalle(EMercaderiaDetalle As Mercaderias_Detalle, ByRef cmd As SqlCommand) As String

        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_MercaderiaDetalle_Alta"
        With cmd.Parameters
            .AddWithValue("@id_Detalle", EMercaderiaDetalle.id_Detalle)
            .AddWithValue("@id_Mercaderia", EMercaderiaDetalle.id_Mercaderia)
            .AddWithValue("@id_Producto", EMercaderiaDetalle.id_Producto)
            .AddWithValue("@Costo", EMercaderiaDetalle.Costo)
            .AddWithValue("@Cantidad", EMercaderiaDetalle.Cantidad)
            .AddWithValue("@Total", EMercaderiaDetalle.Total)
            .AddWithValue("@FechaEdicion", EMercaderiaDetalle.FechaEdicion)
        End With
        Dim respuesta As New SqlParameter("@msg", SqlDbType.VarChar, 255)
        respuesta.Direction = ParameterDirection.Output
        cmd.Parameters.Add(respuesta)
        cmd.ExecuteNonQuery()
        Return respuesta.Value
    End Function

    Public Function TotalMercaderia(ByVal id_Sucursal As Integer, ByVal Fecha As String)
        Dim ds As New DataSet

        ds = clsDatos.ConsultarBaseLocal("execute sp_Mercaderia_Total @id_Sucursal=" & id_Sucursal & ", @Fecha='" & Fecha & "'")

        If ds.Tables(0).Rows.Count = 1 And ds.Tables(0).Rows(0).Item("Total").ToString <> "" Then
            Return ds.Tables(0).Rows(0).Item("Total").ToString
        Else
            Return 0
        End If
    End Function
End Class