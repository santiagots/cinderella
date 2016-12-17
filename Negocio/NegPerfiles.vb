Imports System.Data.SqlClient

Public Class NegPerfiles
    Dim ClsDatos As New Datos.Conexion
    Dim ClsFunciones As New Funciones

    Function ListadoPerfiles() As DataSet
        Return ClsDatos.ConsultarBaseRemoto("execute sp_Perfiles_ListadoCompleto")
    End Function

    Function UltimoPerfil() As Integer
        Dim ds As DataSet
        Dim HayInternet As Boolean = Funciones.HayInternet

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

    'Funcion agrega un nuevo perfil con sus correspondientes termisos.
    Public Function InsertarPerfil(EntPatente As List(Of Entidades.Patentes), ByVal Descripcion As String, ByVal Habilitado As Boolean) As String
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim msg As String = ""
        Dim dt As DataTable = New DataTable()
        Dim HayInternet As Boolean = Funciones.HayInternet

        'Cargo la informacion de la relacion entre la patente el perfil y la sucursal para pasarla por un campo al SP
        dt.Columns.Add("id_Perfil", Type.GetType("System.Int32"))
        dt.Columns.Add("id_Patente", Type.GetType("System.Int32"))
        dt.Columns.Add("id_Sucursal", Type.GetType("System.Int32"))

        For Each item As Entidades.Patentes In EntPatente
            If (item.id_Sucursal <> -1) Then
                dt.Rows.Add(item.id_Perfil, item.id_Patente, item.id_Sucursal)
            Else
                dt.Rows.Add(item.id_Perfil, item.id_Patente, DBNull.Value)
            End If
        Next

        Try
            'Conecto a la bdd.
            If HayInternet Then
                cmd.Connection = ClsDatos.ConectarRemoto()
            Else
                cmd.Connection = ClsDatos.ConectarLocal()
            End If

            'Cargo y ejecuto el stored.
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_Perfiles_Alta"
            With cmd.Parameters
                .AddWithValue("@descripcion", Descripcion)
                .AddWithValue("@habilitado", If(Habilitado, 1, 0))
            End With

            'Declaro el tipo de dato para los permisos
            Dim param = cmd.Parameters.AddWithValue("@Permisos", dt)
            param.SqlDbType = SqlDbType.Structured
            param.TypeName = "dbo.PERFIL_PATENTE_TYPE"

            'Respuesta del stored.
            Dim respuesta As New SqlParameter("@msg", SqlDbType.VarChar, 255)
            respuesta.Direction = ParameterDirection.Output
            cmd.Parameters.Add(respuesta)
            cmd.ExecuteNonQuery()

            'Desconecto la bdd.
            If HayInternet Then
                ClsDatos.DesconectarRemoto()
            Else
                ClsDatos.DesconectarLocal()
            End If

            'retorno valor
            Return respuesta.Value
        Catch ex As Exception
            Return False
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
