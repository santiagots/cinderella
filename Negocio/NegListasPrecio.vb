Public Class NegListasPrecio
    Dim clsDatos As New Datos.Conexion

    Public Shared dsListaPrecios As DataSet
    Public Shared dsGrupoPrecios As DataSet

    Function ListadoListasPrecios() As DataSet
        If (dsListaPrecios Is Nothing) Then
            dsListaPrecios = clsDatos.ConsultarBaseRemoto("execute sp_ListasPrecios_Listado")
        End If
        Return dsListaPrecios
    End Function

    Function ListadoGrupoPrecios() As DataSet
        If (dsGrupoPrecios Is Nothing) Then
            dsGrupoPrecios = clsDatos.ConsultarBaseRemoto("execute sp_GrupoPrecios_Listado")
        End If
        Return dsGrupoPrecios
    End Function

    Function ListadoPreciosPorGrupo(GrupoPrecio As Integer) As DataSet
        If (dsListaPrecios Is Nothing) Then
            dsListaPrecios = clsDatos.ConsultarBaseRemoto("execute sp_ListasPrecios_Listado")
        End If
        Dim dv As DataView = dsListaPrecios.Tables(0).DefaultView
        dv.RowFilter = String.Format("Id_ListaGrupo = {0}", GrupoPrecio)
        Dim ds As DataSet = New DataSet()
        Dim dt As DataTable = dv.ToTable()
        ds.Tables.Add(dt)
        Return ds
    End Function

End Class
