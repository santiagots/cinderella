Public Class NegCondicionesIva
    Dim clsDatos As New Datos.Conexion
    Dim ClsFunciones As New Funciones

    'Funcion que lista todas las condiciones de iva del sistema.
    Function ListadoCondiciones() As DataSet
        Return clsDatos.ConsultarBaseLocal("execute sp_Condiciones_Listado")
    End Function

End Class
