Public Class NegProvincias
    Dim clsDatos As New Datos.Conexion
    Dim ClsFunciones As New Funciones

    'Lista todas las provincias del sistema.
    Function ListadoProvincias() As DataSet
        If Funciones.HayInternet Then
            Return clsDatos.ConsultarBaseRemoto("execute sp_Provincias_Listado")
        Else
            Return clsDatos.ConsultarBaseLocal("execute sp_Provincias_Listado")
        End If
    End Function

End Class
