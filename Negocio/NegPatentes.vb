Imports System.Configuration
Imports System.Data.SqlClient

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

    Function ObtenerListadoCompoletoPorPerfil(ByVal id_Perfil As Integer) As DataTable
        Dim dsPatentes As New DataSet

        If HayInternet Then
            dsPatentes = ClsDatos.ConsultarBaseRemoto("execute sp_Patentes_ObtenerListadoCompletoPorPerfil @id_Perfil=" & id_Perfil)
        Else
            dsPatentes = ClsDatos.ConsultarBaseLocal("execute sp_Patentes_ObtenerListadoCompletoPorPerfil @id_Perfil=" & id_Perfil)
        End If

        Dim dtCloned As New DataTable
        dtCloned = dsPatentes.Tables(0).Clone()

        'Modifico el tipo de datos de las columnas de entero a booleano
        For Each col As DataColumn In dtCloned.Columns
            If (col.Ordinal > 1 And col.DataType Is GetType(Integer)) Then
                col.DataType = GetType(Boolean)
            End If
        Next

        'Agrego las de la tabla que se ultuvo a de la base de datos a la tabla con los tipo de columnas modificadas
        For Each row As DataRow In dsPatentes.Tables(0).Rows
            dtCloned.ImportRow(row)
        Next

        Return dtCloned
    End Function

    Function ObtenerPatentes(ByVal id_Usuario As Integer, ByVal id_Sucursal As Integer) As Dictionary(Of Integer, String)
        Dim dsPatentes As New DataSet

        If HayInternet Then
            dsPatentes = ClsDatos.ConsultarBaseRemoto("execute sp_Patentes_ObtenerPorUsuarioSucursal @id_Usuario=" & id_Usuario & ",@id_Sucursal=" & id_Usuario)
        Else
            dsPatentes = ClsDatos.ConsultarBaseLocal("execute sp_Patentes_ObtenerPorUsuarioSucursal @id_Usuario=" & id_Usuario & ",@id_Sucursal=" & id_Usuario)
        End If

        Dim patentes As Dictionary(Of Integer, String) = New Dictionary(Of Integer, String)()

        For Each row As DataRow In dsPatentes.Tables(0).Rows
            patentes.Add(row("id_Patente"), row("Descripcion"))
        Next

        Return patentes
    End Function

    Function ObtenerGrupos() As List(Of String)
        Dim dsGrupos As New DataSet
        Dim respuesta As List(Of String) = New List(Of String)

        If HayInternet Then
            dsGrupos = ClsDatos.ConsultarBaseRemoto("execute sp_Patentes_ObtenerGrupos")
        Else
            dsGrupos = ClsDatos.ConsultarBaseLocal("execute sp_Patentes_ObtenerGrupos")
        End If

        For Each row As DataRow In dsGrupos.Tables(0).Rows
            respuesta.Add(row(0))
        Next

        Return respuesta
    End Function
End Class
