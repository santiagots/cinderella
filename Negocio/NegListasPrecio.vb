Public Class NegListasPrecio
    Dim clsDatos As New Datos.Conexion
    Dim ClsFunciones As New Funciones

    Function ListadoListasPrecios() As DataSet
        Dim dsListaPrecios As DataSet

        dsListaPrecios = clsDatos.ConsultarBaseLocal("execute sp_ListasPrecios_Listado")

        Return dsListaPrecios
    End Function

    Function ListadoGrupoPrecios() As DataSet
        Dim dsGrupoPrecios As DataSet

        dsGrupoPrecios = clsDatos.ConsultarBaseLocal("execute sp_GrupoPrecios_Listado")

        Return dsGrupoPrecios
    End Function

    Function ListadoPreciosPorGrupo(GrupoPrecio As Integer) As DataSet
        Dim dsListaPrecios As DataSet

        dsListaPrecios = clsDatos.ConsultarBaseLocal("execute sp_ListasPrecios_Listado")

        Dim dv As DataView = dsListaPrecios.Tables(0).DefaultView
        dv.RowFilter = String.Format("Id_ListaGrupo = {0}", GrupoPrecio)
        Dim ds As DataSet = New DataSet()
        Dim dt As DataTable = dv.ToTable()
        ds.Tables.Add(dt)
        Return ds
    End Function

End Class
