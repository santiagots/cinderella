Imports System.Configuration

Public Class NegPatentes
    Dim ClsDatos As New Datos.Conexion
    Dim ClsFunciones As New Funciones
    Dim HayInternet As Boolean = ClsFunciones.GotInternet

    Function ListadoPatentes() As DataSet
        If (HayInternet) Then
            Return ClsDatos.ConsultarBaseRemoto("Select * from PATENTES order by Descripcion")
        Else
            Return ClsDatos.ConsultarBaseLocal("Select * from PATENTES order by Descripcion")
        End If
    End Function

    Function ConsultarPatente(ByVal id_Patente As Integer) As DataSet
        If (HayInternet) Then
            Return ClsDatos.ConsultarBaseRemoto("Select * from PATENTES where id_Patente='" & id_Patente & "'")
        Else
            Return ClsDatos.ConsultarBaseLocal("Select * from PATENTES where id_Patente='" & id_Patente & "'")
        End If
    End Function

    Function ListadoPatentesPerfil(ByVal id_Perfil As Integer) As DataSet
        If (HayInternet) Then
            Return ClsDatos.ConsultarBaseRemoto("Select PATENTES.id_Patente,PATENTES.Descripcion from PATENTES inner join REL_PERFILES_PATENTES on PATENTES.id_Patente=REL_PERFILES_PATENTES.id_Patente where id_Perfil='" & id_Perfil & "'")
        Else
            Return ClsDatos.ConsultarBaseLocal("Select PATENTES.id_Patente,PATENTES.Descripcion from PATENTES inner join REL_PERFILES_PATENTES on PATENTES.id_Patente=REL_PERFILES_PATENTES.id_Patente where id_Perfil='" & id_Perfil & "'")
        End If
    End Function

    Function ListadoPatentesPorSucursal(ByVal id_Sucursal As Integer) As DataSet
        If (HayInternet) Then
            Return ClsDatos.ConsultarBaseRemoto("Select * from PATENTES where id_Sucursal='" & id_Sucursal & "'")
        Else
            Return ClsDatos.ConsultarBaseLocal("Select * from PATENTES where id_Sucursal='" & id_Sucursal & "'")
        End If
    End Function

    Function ListadoPatentesPorTipo(ByVal id_Tipo As Integer, ByVal id_Accion As Integer, ByVal id_Sucursal As Integer) As DataSet
        If (HayInternet) Then
            Return ClsDatos.ConsultarBaseRemoto("execute sp_Patentes_ListadoPorTipo @id_Tipo = '" & id_Tipo & "',@id_Accion = '" & id_Accion & "',@id_Sucursal = '" & id_Sucursal & "'")
        Else
            Return ClsDatos.ConsultarBaseLocal("execute sp_Patentes_ListadoPorTipo @id_Tipo = '" & id_Tipo & "',@id_Accion = '" & id_Accion & "',@id_Sucursal = '" & id_Sucursal & "'")
        End If
    End Function

    Function ListadoPatentesGenerales() As DataSet
        If (HayInternet) Then
            Return ClsDatos.ConsultarBaseRemoto("Select * from PATENTES where id_Sucursal='0'")
        Else
            Return ClsDatos.ConsultarBaseLocal("Select * from PATENTES where id_Sucursal='0'")
        End If
    End Function

    Function CargarPatentesPorUsuario(ByVal id_Usuario As Integer, ByVal id_Sucursal As Integer) As DataSet
        If (HayInternet) Then
            Return ClsDatos.ConsultarBaseRemoto("select PATENTES.id_Patente, PATENTES.Descripcion from PATENTES INNER JOIN REL_PERFILES_PATENTES ON PATENTES.id_Patente=REL_PERFILES_PATENTES.id_Patente INNER JOIN USUARIOS ON REL_PERFILES_PATENTES.id_Perfil=USUARIOS.id_Perfil WHERE id_Usuario='" & id_Usuario & "' and (PATENTES.id_Sucursal='0' or id_Sucursal='" & id_Sucursal & "') order by PATENTES.id_Patente ASC")
        Else
            Return ClsDatos.ConsultarBaseLocal("select PATENTES.id_Patente, PATENTES.Descripcion from PATENTES INNER JOIN REL_PERFILES_PATENTES ON PATENTES.id_Patente=REL_PERFILES_PATENTES.id_Patente INNER JOIN USUARIOS ON REL_PERFILES_PATENTES.id_Perfil=USUARIOS.id_Perfil WHERE id_Usuario='" & id_Usuario & "' and (PATENTES.id_Sucursal='0' or id_Sucursal='" & id_Sucursal & "') order by PATENTES.id_Patente ASC")
        End If
    End Function

    Function CargarPatentesPorUsuarioLocal(ByVal id_Usuario As Integer, ByVal id_Sucursal As Integer) As DataSet
            Return ClsDatos.ConsultarBaseLocal("select PATENTES.id_Patente, PATENTES.Descripcion from PATENTES INNER JOIN REL_PERFILES_PATENTES ON PATENTES.id_Patente=REL_PERFILES_PATENTES.id_Patente INNER JOIN USUARIOS ON REL_PERFILES_PATENTES.id_Perfil=USUARIOS.id_Perfil WHERE id_Usuario='" & id_Usuario & "' and (PATENTES.id_Sucursal='0' or id_Sucursal='" & id_Sucursal & "') order by PATENTES.id_Patente ASC")
    End Function

End Class
