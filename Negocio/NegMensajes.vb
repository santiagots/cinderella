Imports System.Data.SqlClient
Public Class NegMensajes
    Dim ClsDatos As New Datos.Conexion

    Public Function ComprobarMensajes(ByVal id_Usuario As Integer)
        Dim dsMensajes As New DataSet
        dsMensajes = ClsDatos.ConsultarBaseRemoto("execute sp_Mensajes_ConsultarNuevos @id_Usuario=" & id_Usuario)

        If dsMensajes.Tables(0).Rows.Count <> 0 Then
            Return dsMensajes.Tables(0).Rows(0).Item("Total").ToString
        Else
            Return 0
        End If
    End Function

    Function EnviarMensaje(ByVal Asunto As String, ByVal Mensaje As String, ByVal id_Usuario As Integer, ByVal id_UsuarioDestino As Integer) As String
        Dim cmd As New SqlCommand
        Try
            cmd.Connection = ClsDatos.ConectarRemoto()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_Mensajes_Alta"
            With cmd.Parameters
                .AddWithValue("@Asunto", Asunto)
                .AddWithValue("@Mensaje", Mensaje)
                .AddWithValue("@id_Usuario", id_Usuario)
                .AddWithValue("@id_UsuarioDestino", id_UsuarioDestino)
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

    Function EliminarMensaje(ByVal id_Mensaje As Integer) As String
        Dim cmd As New SqlCommand
        Try
            cmd.Connection = ClsDatos.ConectarRemoto()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_Mensajes_Eliminar"
            With cmd.Parameters
                .AddWithValue("@id_Mensaje", id_Mensaje)
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

    Function ListarMensajes(ByVal id_Usuario As Integer) As DataSet
        Return ClsDatos.ConsultarBaseRemoto("execute sp_Mensajes_Listado @id_Usuario=" & id_Usuario)
    End Function

    Public Function TraerMensaje(ByVal id_Mensaje As Integer)
        Dim dsMensajes As New DataSet
        Dim entMensajes As New Entidades.Mensajes
        dsMensajes = ClsDatos.ConsultarBaseRemoto("execute sp_Mensajes_Detalle @id_Mensaje=" & id_Mensaje)
        If dsMensajes.Tables(0).Rows.Count <> 0 Then
            entMensajes.id_Mensaje = dsMensajes.Tables(0).Rows(0).Item("id_Mensaje").ToString
            entMensajes.id_Usuario = dsMensajes.Tables(0).Rows(0).Item("id_Usuario").ToString
            entMensajes.id_UsuarioDestino = dsMensajes.Tables(0).Rows(0).Item("id_UsuarioDestino").ToString
            entMensajes.Asunto = dsMensajes.Tables(0).Rows(0).Item("Asunto").ToString
            entMensajes.Mensaje = dsMensajes.Tables(0).Rows(0).Item("Mensaje").ToString
            entMensajes.Leido = dsMensajes.Tables(0).Rows(0).Item("Leido").ToString
            entMensajes.Fecha = dsMensajes.Tables(0).Rows(0).Item("Fecha").ToString
            entMensajes.Habilitado = dsMensajes.Tables(0).Rows(0).Item("Habilitado").ToString
        End If
        Return entMensajes
    End Function

    Public Function MensajeLeido(ByVal id_Mensaje As Integer)
        Return ClsDatos.ConsultarBaseRemoto("execute sp_Mensajes_CambiarLeido @id_Mensaje=" & id_Mensaje)
    End Function

End Class
