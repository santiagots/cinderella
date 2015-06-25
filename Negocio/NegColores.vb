Imports System.Data.SqlClient
Public Class NegColores
    Dim ClsDatos As New Datos.Conexion
    Function AltaColores(ByVal descripcion As String, ByVal habilitado As Integer) As String
        Dim cmd As New SqlCommand
        Try
            cmd.Connection = ClsDatos.ConectarRemoto()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_AltaColores"
            With cmd.Parameters
                .AddWithValue("@descrip", descripcion)
                .AddWithValue("@hab", habilitado)
            End With
            Dim respuesta As New SqlParameter("@msg", SqlDbType.VarChar, 255)
            respuesta.Direction = ParameterDirection.Output
            cmd.Parameters.Add(respuesta)

            cmd.ExecuteNonQuery()
            ClsDatos.DesconectarRemoto()

            Return respuesta.Value
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Function ModificacionColores(ByVal ecolores As Entidades.Colores) As String
        Dim cmd As New SqlCommand
        Try
            cmd.Connection = ClsDatos.ConectarRemoto()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_ModificacionColores"
            With cmd.Parameters
                .AddWithValue("@idcolores", ecolores.id_Color)
                .AddWithValue("@descrip", ecolores.Descripcion)
                .AddWithValue("@hab", ecolores.Habilitado)
            End With
            Dim respuesta As New SqlParameter("@msg", SqlDbType.VarChar, 255)
            respuesta.Direction = ParameterDirection.Output
            cmd.Parameters.Add(respuesta)

            cmd.ExecuteNonQuery()
            ClsDatos.DesconectarRemoto()

            Return respuesta.Value
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Function EliminarColores(ByVal id_Color As Integer) As String
        Dim cmd As New SqlCommand
        Try
            cmd.Connection = ClsDatos.ConectarRemoto()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_EliminarColores"
            With cmd.Parameters
                .AddWithValue("@id_Color", id_Color)
            End With
            Dim respuesta As New SqlParameter("@msg", SqlDbType.VarChar, 255)
            respuesta.Direction = ParameterDirection.Output
            cmd.Parameters.Add(respuesta)

            cmd.ExecuteNonQuery()
            ClsDatos.DesconectarRemoto()

            Return respuesta.Value
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Function ListadoColoresProducto(ByVal id_Producto As Integer) As DataSet
        Return ClsDatos.ConsultarBaseRemoto("execute sp_ProductosColores_Listado @id_Producto = " & id_Producto)
    End Function

    Function ListadoColores() As DataSet
        Return ClsDatos.ConsultarBaseRemoto("Select * from COLORES order by Descripcion")
    End Function

    Function ConsultarColor(ByVal id_Color As Integer) As DataSet
        Return ClsDatos.ConsultarBaseRemoto("Select * from COLORES where id_Color='" & id_Color & "'")
    End Function

End Class
