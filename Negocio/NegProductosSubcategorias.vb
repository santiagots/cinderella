Imports System.Data.SqlClient
Public Class NegProductosSubcategorias
    Dim clsDatos As New Datos.Conexion

    Function ListadoSubcategorias(ByVal id_Categoria As Integer) As DataSet
        Return clsDatos.ConsultarBaseRemoto("execute sp_ProductosSubcategorias_Listado  @id_Categoria = " & id_Categoria)
    End Function

    Function ListadoSubcategoriasCompleto() As DataSet
        Return clsDatos.ConsultarBaseRemoto("execute sp_ProductosSubcategorias_ListadoCompleto")
    End Function

    Function AltaSubcategorias(ByVal descripcion As String, ByVal categoria As Integer, ByVal habilitado As Integer) As String
        Dim cmd As New SqlCommand
        Try
            cmd.Connection = clsDatos.ConectarRemoto()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_ProductosSubcategorias_Alta"
            With cmd.Parameters
                .AddWithValue("@descrip", descripcion)
                .AddWithValue("@categoria", categoria)
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

    Function ModificacionSubcategorias(ByVal esubcategorias As Entidades.Productos_Subcategorias) As String
        Dim cmd As New SqlCommand
        Try
            cmd.Connection = clsDatos.ConectarRemoto()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_ProductosSubcategorias_Modificacion"
            With cmd.Parameters
                .AddWithValue("@id_Subcategoria", esubcategorias.id_Categoria)
                .AddWithValue("@descrip", esubcategorias.Descripcion)
                .AddWithValue("@id_Categoria", esubcategorias.id_Categoria)
                .AddWithValue("@hab", esubcategorias.Habilitado)
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

    Function EliminarSubCategorias(ByVal id_Subcategoria As Integer) As String
        Dim cmd As New SqlCommand
        Try
            cmd.Connection = clsDatos.ConectarRemoto()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_ProductosSubcategorias_Eliminar"
            With cmd.Parameters
                .AddWithValue("@id_Subcategoria", id_Subcategoria)
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

    Function ConsultarSubcategoria(ByVal id_Subcategoria As Integer) As DataSet
        Return clsDatos.ConsultarBaseRemoto("Select * from PRODUCTOS_SUBCATEGORIAS where id_Subcategoria='" & id_Subcategoria & "'")
    End Function

End Class
