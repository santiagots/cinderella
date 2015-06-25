Imports Entidades
Imports System.Data.SqlClient
Imports Datos

Public Class Usuario
    Dim objUsuario As Entidades.Usuario
    Dim clsDatos As New Datos.Conexion
    Dim negFunciones As New Negocio.Funciones

    'Funcion que realiza el login del Usuario.
    Public Function Login(ByVal usuario As String, ByVal pwd As String)
        Dim EUsuario As New Entidades.Usuario
        Dim dsLogin As DataSet
        Dim HayInternet As Boolean = negFunciones.GotInternet

        Try
            'intento hacer la conexion al servidor remoto y luego al local.
            If (HayInternet) Then
                dsLogin = clsDatos.ConsultarBaseRemoto("execute sp_Usuario_Login @Usuario = '" & usuario & "',@PWD = '" & pwd & "'")
            Else
                dsLogin = clsDatos.ConsultarBaseLocal("execute sp_Usuario_Login @Usuario = '" & usuario & "',@PWD='" & pwd & "'")
            End If

            'Si el dataset tiene datos, traigo el usuario.
            If dsLogin.Tables(0).Rows.Count <> 0 Then
                EUsuario = TraerUsuario(dsLogin.Tables(0).Rows(0).Item("id_Usuario"))
                'CargarPatentes(dsUsuario.Tables(0).Rows(0).Item("id_Usuario"))
            End If
        Catch ex As Exception
            EUsuario.id_Usuario = 0
        End Try
        Return EUsuario
    End Function

    'Devuelve la entidad de un Usuario determinado.
    Public Function TraerUsuario(ByVal id_Usuario As Integer)
        Dim dsUsuario As New DataSet
        Dim entUsuario As New Entidades.Usuario
        Dim HayInternet As Boolean = negFunciones.GotInternet

        Try
            'intento hacer la conexion al servidor remoto y luego al local.
            If (HayInternet) Then
                dsUsuario = clsDatos.ConsultarBaseRemoto("execute sp_Usuario_Detalle @id_Usuario = '" & id_Usuario & "'")
            Else
                dsUsuario = clsDatos.ConsultarBaseLocal("execute sp_Usuario_Detalle @id_Usuario = '" & id_Usuario & "'")
            End If

            'Lleno la entidad Usuario.
            If dsUsuario.Tables(0).Rows.Count <> 0 Then
                entUsuario.Apellido = dsUsuario.Tables(0).Rows(0).Item("Apellido").ToString
                entUsuario.Nombre = dsUsuario.Tables(0).Rows(0).Item("Nombre").ToString
                entUsuario.Fecha = dsUsuario.Tables(0).Rows(0).Item("Fecha")
                entUsuario.Usuario = dsUsuario.Tables(0).Rows(0).Item("Usuario")
                entUsuario.id_Usuario = dsUsuario.Tables(0).Rows(0).Item("id_Usuario")
                entUsuario.Mail = dsUsuario.Tables(0).Rows(0).Item("Mail")
                entUsuario.Habilitado = dsUsuario.Tables(0).Rows(0).Item("Habilitado").ToString
                entUsuario.id_Perfil = dsUsuario.Tables(0).Rows(0).Item("id_Perfil").ToString
            End If
        Catch ex As Exception
            entUsuario.id_Usuario = 0
        End Try

        Return entUsuario
    End Function

    'Carga Patentes del Usuario.
    Public Function CargarPatentes(ByVal id_Usuario As Integer, ByVal id_Sucursal As Integer)
        Dim negPatentes As New NegPatentes
        Dim dsPatentes As New DataSet
        Dim ArrPatentes As New ArrayList
        Dim HayInternet As Boolean = negFunciones.GotInternet

        If HayInternet Then
            'cargo las patentes de la base remota
            dsPatentes = negPatentes.CargarPatentesPorUsuario(id_Usuario, id_Sucursal)
        Else
            'cargo las patentes de la base local
            dsPatentes = negPatentes.CargarPatentesPorUsuarioLocal(id_Usuario, id_Sucursal)
        End If

        For Each drPatente In dsPatentes.Tables(0).Rows
            ArrPatentes.Add(drPatente.item("id_Patente"))
        Next
        Return ArrPatentes
    End Function

    'Funcion que verifica si la patente está disponible para el usuario.
    Public Function EsPatenteValida(ByVal Patente As Integer, ByVal Patentes As ArrayList) As Boolean
        Dim retorno As Boolean = False
        If Patentes.Contains(Patente) Then
            retorno = True
        End If

        Return retorno
    End Function

    'Funcion que verifica si la patente está disponible para el usuario.
    Public Function EsPatenteValida(ByVal Patente As Integer, ByVal Patentes As ArrayList, ByVal id_Sucursal As Integer) As Boolean
        Dim retorno As Boolean = False
        If Patentes.Contains(Patente) Then
            retorno = True
        End If
        Return retorno
    End Function

    'Funcion que lista SOLO los usuarios habilitados del sistema.
    Function ListadoUsuarios() As DataSet
        Dim HayInternet As Boolean = negFunciones.GotInternet
        If HayInternet Then
            Return clsDatos.ConsultarBaseRemoto("Select id_Usuario,Usuario from USUARIOS where (Habilitado=1) order by Usuario")
        Else
            Return clsDatos.ConsultarBaseLocal("Select id_Usuario,Usuario from USUARIOS where (Habilitado=1) order by Usuario")
        End If
    End Function

    'Funcion que lista todos los usuarios del sistema.
    Function ListadoUsuariosCompleto() As DataSet
        Dim HayInternet As Boolean = negFunciones.GotInternet
        If HayInternet Then
            Return clsDatos.ConsultarBaseRemoto("Select id_Usuario,Nombre,Apellido,Usuario,CASE WHEN(Habilitado=1) THEN 'SI' ELSE 'NO' END AS Habilitado from USUARIOS order by Usuario")
        Else
            Return clsDatos.ConsultarBaseLocal("Select id_Usuario,Nombre,Apellido,Usuario,CASE WHEN(Habilitado=1) THEN 'SI' ELSE 'NO' END AS Habilitado from USUARIOS order by Usuario")
        End If
    End Function

    'Funcion que da de alta un Usuario.
    Function AltaUsuarios(ByVal eusuarios As Entidades.Usuario) As String
        Dim cmd As New SqlCommand
        Try
            cmd.Connection = clsDatos.ConectarRemoto()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_AltaUsuarios"
            With cmd.Parameters
                .AddWithValue("@nom", eusuarios.Nombre)
                .AddWithValue("@ape", eusuarios.Apellido)
                .AddWithValue("@email", eusuarios.Mail)
                .AddWithValue("@usu", eusuarios.Usuario)
                .AddWithValue("@pass", eusuarios.PWD)
                .AddWithValue("@idperfil", eusuarios.id_Perfil)
                .AddWithValue("@hab", eusuarios.Habilitado)
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

    'Funcion que elimina un Usuario.
    Function EliminarUsuarios(ByVal id_Usuario As Integer) As String
        Dim cmd As New SqlCommand
        Try
            cmd.Connection = clsDatos.ConectarRemoto()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_EliminarUsuarios"
            With cmd.Parameters
                .AddWithValue("@idusu", id_Usuario)
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

    'Funcion que modifica un Usuario.
    Function ModificacionUsuarios(ByVal eusuarios As Entidades.Usuario) As String
        Dim cmd As New SqlCommand
        Try
            cmd.Connection = clsDatos.ConectarRemoto()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_ModificacionUsuario"
            With cmd.Parameters
                .AddWithValue("@idusu", eusuarios.id_Usuario)
                .AddWithValue("@idperfil", eusuarios.id_Perfil)
                .AddWithValue("@nom", eusuarios.Nombre)
                .AddWithValue("@ape", eusuarios.Apellido)
                .AddWithValue("@email", eusuarios.Mail)
                .AddWithValue("@usu", eusuarios.Usuario)
                .AddWithValue("@pass", eusuarios.PWD)
                .AddWithValue("@hab", eusuarios.Habilitado)
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
