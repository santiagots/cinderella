Public Class NegListasPrecio
    Dim clsDatos As New Datos.Conexion
    Function ListadoListasPrecios() As DataSet
        Return clsDatos.ConsultarBaseRemoto("execute sp_ListasPrecios_Listado")
    End Function
End Class
