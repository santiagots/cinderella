Imports System.Data.SqlClient
Public Class NegProductosCategorias
    Dim clsDatos As New Datos.Conexion
    Function ListadoCategorias() As DataSet
        Return clsDatos.ConsultarBaseRemoto("execute sp_ProductosCategorias_Listado")
    End Function

    Function ListadoCategoriasCompleto() As DataSet
        Return clsDatos.ConsultarBaseRemoto("execute sp_ProductosCategorias_ListadoCompleto")
    End Function

    Function ConsultarCategoria(ByVal id_Categoria As Integer) As DataSet
        Return clsDatos.ConsultarBaseRemoto("Select * from PRODUCTOS_CATEGORIAS where id_Categoria='" & id_Categoria & "'")
    End Function

    Function AltaCategorias(ByVal descripcion As String, ByVal habilitado As Integer) As String
        Dim cmd As New SqlCommand
        Try
            cmd.Connection = clsDatos.ConectarRemoto()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_ProductosCategorias_Alta"
            With cmd.Parameters
                .AddWithValue("@descrip", descripcion)
                .AddWithValue("@hab", habilitado)
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

    Function ModificacionCategorias(ByVal ecategorias As Entidades.Productos_Categorias) As String
        Dim cmd As New SqlCommand
        Try
            cmd.Connection = clsDatos.ConectarRemoto()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_ProductosCategorias_Modificacion"
            With cmd.Parameters
                .AddWithValue("@id_Categoria", ecategorias.id_Categoria)
                .AddWithValue("@descrip", ecategorias.Descripcion)
                .AddWithValue("@hab", ecategorias.Habilitado)
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

    Function EliminarCategorias(ByVal id_Categoria As Integer) As String
        Dim cmd As New SqlCommand
        Try
            cmd.Connection = clsDatos.ConectarRemoto()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_ProductosCategorias_Eliminar"
            With cmd.Parameters
                .AddWithValue("@id_Categoria", id_Categoria)
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
