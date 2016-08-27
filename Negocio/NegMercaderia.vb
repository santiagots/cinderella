Imports Entidades
Imports System.Data.SqlClient
Imports Datos
Public Class NegMercaderia
    Dim clsDatos As New Datos.Conexion
    Dim ClsFunciones As New Funciones

    'Funcion para listar todos los productos.
    Function ListadoMercaderia(ByVal id_Sucursal As Integer) As DataSet
        If (Funciones.HayInternet) Then
            Return clsDatos.ConsultarBaseRemoto("execute sp_Mercaderia_ListadoSucursal @id_Sucursal=" & id_Sucursal)
        Else
            Return clsDatos.ConsultarBaseLocal("execute sp_Mercaderia_ListadoSucursal @id_Sucursal=" & id_Sucursal)
        End If
    End Function

    'Funcion para consultar un detalle de pedido de mercadería.
    Function ObtenerDetalleMercaderia(ByVal id_Mercaderia As Integer) As DataSet
        If (Funciones.HayInternet) Then
            Return clsDatos.ConsultarBaseRemoto("execute sp_Mercaderia_DetalleProd @id_Mercaderia=" & id_Mercaderia)
        Else
            Return clsDatos.ConsultarBaseLocal("execute sp_Mercaderia_DetalleProd @id_Mercaderia=" & id_Mercaderia)
        End If
    End Function

    'Funcion que me trae el id del ultimo producto.
    Function UltimaMercaderia() As Integer
        Dim ds As DataSet
        If (Funciones.HayInternet) Then
            ds = clsDatos.ConsultarBaseRemoto("Select IDENT_CURRENT('MERCADERIAS') as id_Mercaderia")
        Else
            ds = clsDatos.ConsultarBaseLocal("Select IDENT_CURRENT('MERCADERIAS')  as id_Mercaderia")
        End If

        If ds.Tables(0).Rows.Count = 1 And CInt(ds.Tables(0).Rows(0).Item("id_Mercaderia")) > 0 Then
            Return ds.Tables(0).Rows(0).Item("id_Mercaderia").ToString
        Else
            Return 1
        End If
    End Function

    'Funcion para consultar un pedido de mercadería.
    Public Function TraerMercaderia(ByVal id_Mercaderia As Integer)
        Dim dsStock As New DataSet
        If (Funciones.HayInternet) Then
            dsStock = clsDatos.ConsultarBaseRemoto("execute sp_Mercaderia_Detalle @id_Mercaderia=" & id_Mercaderia)
        Else
            dsStock = clsDatos.ConsultarBaseLocal("execute sp_Mercaderia_Detalle @id_Mercaderia=" & id_Mercaderia)
        End If
        Return dsStock
    End Function

    'Funcion para insertar una Mercaderia.
    Function AltaMercaderia(ByVal EMercaderia As Entidades.Mercaderias) As String
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim msg As String = ""

        Try
            cmd.Connection = clsDatos.ConectarRemoto()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_Mercaderia_Alta"
            With cmd.Parameters
                .AddWithValue("@id_Sucursal", EMercaderia.id_Sucursal)
                .AddWithValue("@id_Proveedor", EMercaderia.id_Proveedor)
                .AddWithValue("@Fecha", EMercaderia.Fecha)
                .AddWithValue("@CantidadTotal", EMercaderia.CantidadTotal)
                .AddWithValue("@MontoTotal", EMercaderia.MontoTotal)
                .AddWithValue("@Habilitado", EMercaderia.Habilitado)
            End With

            Dim respuesta As New SqlParameter("@msg", SqlDbType.VarChar, 255)
            respuesta.Direction = ParameterDirection.Output
            cmd.Parameters.Add(respuesta)
            cmd.ExecuteNonQuery()
            'desconecto la bdd
            clsDatos.DesconectarRemoto()

            'muestro el mensaje
            Return respuesta.Value
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Function AltaMercaderiaDetalle(ByVal EMercaderiaDetalle As Entidades.Mercaderias_Detalle) As String
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim msg As String = ""

        Try
            cmd.Connection = clsDatos.ConectarRemoto()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_MercaderiaDetalle_Alta"
            With cmd.Parameters
                .AddWithValue("@id_Mercaderia", EMercaderiaDetalle.id_Mercaderia)
                .AddWithValue("@id_Producto", EMercaderiaDetalle.id_Producto)
                .AddWithValue("@Costo", EMercaderiaDetalle.Costo)
                .AddWithValue("@Cantidad", EMercaderiaDetalle.Cantidad)
                .AddWithValue("@Total", EMercaderiaDetalle.Total)
            End With

            Dim respuesta As New SqlParameter("@msg", SqlDbType.VarChar, 255)
            respuesta.Direction = ParameterDirection.Output
            cmd.Parameters.Add(respuesta)
            cmd.ExecuteNonQuery()
            'desconecto la bdd
            clsDatos.DesconectarRemoto()

            'muestro el mensaje
            Return respuesta.Value
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Function TotalMercaderia(ByVal id_Sucursal As Integer, ByVal Fecha As String)
        Dim ds As New DataSet
        If Funciones.HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_Mercaderia_Total @id_Sucursal=" & id_Sucursal & ", @Fecha='" & Fecha & "'")
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_Mercaderia_Total @id_Sucursal=" & id_Sucursal & ", @Fecha='" & Fecha & "'")
        End If

        If ds.Tables(0).Rows.Count = 1 And ds.Tables(0).Rows(0).Item("Total").ToString <> "" Then
            Return ds.Tables(0).Rows(0).Item("Total").ToString
        Else
            Return 0
        End If
    End Function
End Class