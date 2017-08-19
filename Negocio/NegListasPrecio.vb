Public Class NegListasPrecio
    Dim clsDatos As New Datos.Conexion
    Dim ClsFunciones As New Funciones

    Private Shared ListaPreciosPorGrupo As DataSet

    Function ListadoListasPrecios() As DataSet
        Dim dsListaPrecios As DataSet

        If (Funciones.HayInternet) Then
            dsListaPrecios = clsDatos.ConsultarBaseRemoto("execute sp_ListasPrecios_Listado")
        Else
            dsListaPrecios = clsDatos.ConsultarBaseLocal("execute sp_ListasPrecios_Listado")
        End If

        Return dsListaPrecios
    End Function

    Function ListadoGrupoPrecios() As DataSet
        Dim dsGrupoPrecios As DataSet

        If (Funciones.HayInternet) Then
            dsGrupoPrecios = clsDatos.ConsultarBaseRemoto("execute sp_GrupoPrecios_Listado")
        Else
            dsGrupoPrecios = clsDatos.ConsultarBaseLocal("execute sp_GrupoPrecios_Listado")
        End If

        Return dsGrupoPrecios
    End Function

    Function ListadoPreciosPorGrupo(GrupoPrecio As Integer) As DataSet
        Dim dsListaPrecios As DataSet

        If (Funciones.HayInternet) Then
            dsListaPrecios = clsDatos.ConsultarBaseRemoto("execute sp_ListasPrecios_Listado")
        Else
            dsListaPrecios = clsDatos.ConsultarBaseLocal("execute sp_ListasPrecios_Listado")
        End If

        Dim dv As DataView = dsListaPrecios.Tables(0).DefaultView
        dv.RowFilter = String.Format("Id_ListaGrupo = {0}", GrupoPrecio)
        Dim ds As DataSet = New DataSet()
        Dim dt As DataTable = dv.ToTable()
        ds.Tables.Add(dt)
        Return ds
    End Function

    Function ListadoPreciosPorGrupoCache(GrupoPrecio As Integer, usarCache As Boolean) As DataSet

        If (ListaPreciosPorGrupo Is Nothing OrElse Not usarCache) Then
            If (Funciones.HayInternet) Then
                ListaPreciosPorGrupo = clsDatos.ConsultarBaseRemoto("execute sp_ListasPrecios_Listado")
            Else
                ListaPreciosPorGrupo = clsDatos.ConsultarBaseLocal("execute sp_ListasPrecios_Listado")
            End If
        End If

        Dim dv As DataView = ListaPreciosPorGrupo.Tables(0).DefaultView
        dv.RowFilter = String.Format("Id_ListaGrupo = {0}", GrupoPrecio)
        Dim ds As DataSet = New DataSet()
        Dim dt As DataTable = dv.ToTable()
        ds.Tables.Add(dt)
        Return ds
    End Function

End Class
