Imports System.Data.SqlClient
Public Class NegAromas
    Dim clsDatos As New Datos.Conexion
    Function ListadoAromas() As DataSet
        Return clsDatos.ConsultarBaseRemoto("execute sp_Aromas_Listado")
    End Function

    Function ListadoAromasCompleto() As DataSet
        Return clsDatos.ConsultarBaseRemoto("execute sp_Aromas_ListadoCompleto")
    End Function

    Function ListadoAromasProducto(ByVal id_Producto As Integer) As DataSet
        Return clsDatos.ConsultarBaseRemoto("execute sp_ProductosAromas_Listado @id_Producto = " & id_Producto)
    End Function

    Function ConsultarAroma(ByVal id_Aroma As Integer) As DataSet
        Return clsDatos.ConsultarBaseRemoto("Select * from AROMAS where id_Aroma='" & id_Aroma & "'")
    End Function

    Function AltaAroma(ByVal descripcion As String, ByVal habilitado As Integer) As String
        Dim cmd As New SqlCommand
        Try
            cmd.Connection = clsDatos.ConectarRemoto()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_Aromas_Alta"
            With cmd.Parameters
                .AddWithValue("@Descripcion", descripcion)
                .AddWithValue("@Habilitado", habilitado)
            End With
            Dim respuesta As New SqlParameter("@msg", SqlDbType.VarChar, 255)
            respuesta.Direction = ParameterDirection.Output
            cmd.Parameters.Add(respuesta)

            cmd.ExecuteNonQuery()
            clsDatos.DesconectarRemoto()

            Return respuesta.Value
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Function ModificacionAroma(ByVal earomas As Entidades.Aromas) As String
        Dim cmd As New SqlCommand
        Try
            cmd.Connection = clsDatos.ConectarRemoto()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_Aromas_Modificacion"
            With cmd.Parameters
                .AddWithValue("@id_Aroma", earomas.id_Aroma)
                .AddWithValue("@Descripcion", earomas.Descripcion)
                .AddWithValue("@Habilitado", earomas.Habilitado)
            End With
            Dim respuesta As New SqlParameter("@msg", SqlDbType.VarChar, 255)
            respuesta.Direction = ParameterDirection.Output
            cmd.Parameters.Add(respuesta)

            cmd.ExecuteNonQuery()
            clsDatos.DesconectarRemoto()

            Return respuesta.Value
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Function EliminarAroma(ByVal id_Aroma As Integer) As String
        Dim cmd As New SqlCommand
        Try
            cmd.Connection = clsDatos.ConectarRemoto()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_Aromas_Eliminar"
            With cmd.Parameters
                .AddWithValue("@id_Aroma", id_Aroma)
            End With
            Dim respuesta As New SqlParameter("@msg", SqlDbType.VarChar, 255)
            respuesta.Direction = ParameterDirection.Output
            cmd.Parameters.Add(respuesta)

            cmd.ExecuteNonQuery()
            clsDatos.DesconectarRemoto()

            Return respuesta.Value
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function
End Class
