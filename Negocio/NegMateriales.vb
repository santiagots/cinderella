Imports System.Data.SqlClient
Public Class NegMateriales
    Dim clsDatos As New Datos.Conexion
    Function ListadoMateriales() As DataSet
        Return clsDatos.ConsultarBaseRemoto("execute sp_Materiales_Listado")
    End Function

    Function ListadoMaterialesCompleto() As DataSet
        Return clsDatos.ConsultarBaseRemoto("execute sp_Materiales_ListadoCompleto")
    End Function

    Function ListadoMaterialesProducto(ByVal id_Producto As Integer) As DataSet
        Return clsDatos.ConsultarBaseRemoto("execute sp_ProductosMateriales_Listado @id_Producto = " & id_Producto)
    End Function

    Function ConsultarMaterial(ByVal id_Material As Integer) As DataSet
        Return clsDatos.ConsultarBaseRemoto("Select * from MATERIALES where id_Material='" & id_Material & "'")
    End Function

    Function AltaMaterial(ByVal descripcion As String, ByVal habilitado As Integer) As String
        Dim cmd As New SqlCommand
        Try
            cmd.Connection = clsDatos.ConectarRemoto()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_Materiales_Alta"
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

    Function ModificacionMaterial(ByVal emateriales As Entidades.Materiales) As String
        Dim cmd As New SqlCommand
        Try
            cmd.Connection = clsDatos.ConectarRemoto()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_Materiales_Modificacion"
            With cmd.Parameters
                .AddWithValue("@id_Material", emateriales.id_Material)
                .AddWithValue("@Descripcion", emateriales.Descripcion)
                .AddWithValue("@Habilitado", emateriales.Habilitado)
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

    Function EliminarMaterial(ByVal id_Material As Integer) As String
        Dim cmd As New SqlCommand
        Try
            cmd.Connection = clsDatos.ConectarRemoto()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_Materiales_Eliminar"
            With cmd.Parameters
                .AddWithValue("@id_Material", id_Material)
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
