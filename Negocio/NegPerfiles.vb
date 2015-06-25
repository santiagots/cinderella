Imports System.Data.SqlClient

Public Class NegPerfiles
    Dim ClsDatos As New Datos.Conexion
    Dim ClsFunciones As New Funciones
    Dim HayInternet As Boolean = ClsFunciones.GotInternet

    Function ListadoPerfiles() As DataSet
        Return ClsDatos.ConsultarBaseRemoto("execute sp_Perfiles_ListadoCompleto")
    End Function

    Function ConsultarPerfil(ByVal id_Perfil As Integer) As DataSet
        Return ClsDatos.ConsultarBaseRemoto("execute sp_Perfiles_Obtener @id_Perfil=" & id_Perfil)
    End Function

    Function UltimoPerfil() As Integer
        Dim ds As DataSet
        If (HayInternet) Then
            ds = ClsDatos.ConsultarBaseRemoto("Select IDENT_CURRENT('PERFILES') as id_Perfil")
        Else
            ds = ClsDatos.ConsultarBaseLocal("Select IDENT_CURRENT('PERFILES')  as id_Perfil")
        End If

        If ds.Tables(0).Rows.Count = 1 And CInt(ds.Tables(0).Rows(0).Item("id_Perfil")) > 0 Then
            Return ds.Tables(0).Rows(0).Item("id_Perfil").ToString
        Else
            Return 1
        End If
    End Function

    Function AltaPerfiles(ByVal eperfiles As Entidades.Perfiles) As String
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim id_Perfil As Integer
        Dim id_Patente As Integer
        Dim msg As String = ""
        Dim checked_items As System.Windows.Forms.ListBox
        checked_items = eperfiles.Patentes

        Try
            'inserto el perfil
            cmd.Connection = ClsDatos.ConectarRemoto()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_AltaPerfiles"
            With cmd.Parameters
                .AddWithValue("@descrip", eperfiles.Descripcion)
                .AddWithValue("@hab", eperfiles.Habilitado)
            End With
            Dim respuesta As New SqlParameter("@msg", SqlDbType.VarChar, 255)
            respuesta.Direction = ParameterDirection.Output
            cmd.Parameters.Add(respuesta)
            cmd.ExecuteNonQuery()
            'desconecto la bdd
            ClsDatos.DesconectarRemoto()

            'Consulto cual fue el ultimo id ingresado.
            id_Perfil = UltimoPerfil()

            'inserto las patentes para el perfil
            For Each iten In eperfiles.Patentes.Items
                'conecto la bdd
                Dim cmd2 As New SqlCommand
                cmd2.Connection = ClsDatos.ConectarRemoto()
                id_Patente = DirectCast(iten.Row, System.Data.DataRow).ItemArray(0)
                cmd2.CommandType = CommandType.StoredProcedure
                cmd2.CommandText = "sp_AltaPerfilesPatentes"
                With cmd2.Parameters
                    .AddWithValue("@id_Perfil", id_Perfil)
                    .AddWithValue("@id_Patente", id_Patente)
                End With
                Dim respuesta2 As New SqlParameter("@msg", SqlDbType.VarChar, 255)
                respuesta2.Direction = ParameterDirection.Output
                cmd2.Parameters.Add(respuesta2)
                cmd2.ExecuteNonQuery()
                'desconecto la bdd
                ClsDatos.DesconectarRemoto()
            Next

            'muestro el mensaje
            Return respuesta.Value
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Function ModificacionPerfiles(ByVal eperfiles As Entidades.Perfiles) As String
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim id_Perfil As Integer
        Dim id_Patente As Integer
        Dim msg As String = ""
        Dim checked_items As System.Windows.Forms.ListBox
        checked_items = eperfiles.Patentes

        Try
            'MODIFICA EL PERFIL
            cmd.Connection = ClsDatos.ConectarRemoto()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_ModificacionPerfiles"
            With cmd.Parameters
                .AddWithValue("@id_Perfil", eperfiles.id_Perfil)
                .AddWithValue("@descrip", eperfiles.Descripcion)
                .AddWithValue("@hab", eperfiles.Habilitado)
            End With
            Dim respuesta As New SqlParameter("@msg", SqlDbType.VarChar, 255)
            respuesta.Direction = ParameterDirection.Output
            cmd.Parameters.Add(respuesta)
            cmd.ExecuteNonQuery()
            ClsDatos.DesconectarRemoto()

            'ELIMINO TODOS LAS PATENTES DEL PERFIL
            'conecto la bdd
            Dim cmd3 As New SqlCommand
            cmd3.Connection = ClsDatos.ConectarRemoto()
            cmd3.CommandType = CommandType.StoredProcedure
            cmd3.CommandText = "sp_EliminarPerfilesPatentes"
            With cmd3.Parameters
                .AddWithValue("@id_Perfil", eperfiles.id_Perfil)
            End With
            Dim respuesta3 As New SqlParameter("@msg", SqlDbType.VarChar, 255)
            respuesta3.Direction = ParameterDirection.Output
            cmd3.Parameters.Add(respuesta3)
            cmd3.ExecuteNonQuery()
            'desconecto la bdd
            ClsDatos.DesconectarRemoto()

            id_Perfil = eperfiles.id_Perfil

            'INSERTO TODAS LAS PATENTES NUEVAS DEL PERFIL
            'inserto las patentes para el perfil
            For Each iten In eperfiles.Patentes.Items
                'conecto la bdd
                Dim cmd2 As New SqlCommand
                cmd2.Connection = ClsDatos.ConectarRemoto()
                id_Patente = DirectCast(iten.Row, System.Data.DataRow).ItemArray(0)
                cmd2.CommandType = CommandType.StoredProcedure
                cmd2.CommandText = "sp_AltaPerfilesPatentes"
                With cmd2.Parameters
                    .AddWithValue("@id_Perfil", eperfiles.id_Perfil)
                    .AddWithValue("@id_Patente", id_Patente)
                End With
                Dim respuesta2 As New SqlParameter("@msg", SqlDbType.VarChar, 255)
                respuesta2.Direction = ParameterDirection.Output
                cmd2.Parameters.Add(respuesta2)
                cmd2.ExecuteNonQuery()
                'desconecto la bdd
                ClsDatos.DesconectarRemoto()
            Next

            'muestro el mensaje
            Return respuesta.Value
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Function EliminarPerfiles(ByVal id_Perfil As Integer) As String
        Dim cmd As New SqlCommand
        Try
            cmd.Connection = ClsDatos.ConectarRemoto()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_EliminarPerfiles"
            With cmd.Parameters
                .AddWithValue("@id_Perfil", id_Perfil)
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

End Class
