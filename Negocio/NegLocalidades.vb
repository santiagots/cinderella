Public Class NegLocalidades
    Dim clsDatos As New Datos.Conexion
    Dim ClsFunciones As New Funciones

    'Lista todas las localidades correspondientes a un distrito.
    Function ListadoLocalidades(ByVal id_Distrito As Integer) As DataSet
        If Funciones.HayInternet Then
            Return clsDatos.ConsultarBaseRemoto("execute sp_Localidades_Listado @id_Distrito = " & id_Distrito)
        Else
            Return clsDatos.ConsultarBaseLocal("execute sp_Localidades_Listado @id_Distrito = " & id_Distrito)
        End If
    End Function

    'Lista todas las localidades.
    Function ListadoLocalidades() As DataSet
        If Funciones.HayInternet Then
            Return clsDatos.ConsultarBaseRemoto("execute sp_Localidades_Listado_Completo")
        Else
            Return clsDatos.ConsultarBaseLocal("execute sp_Localidades_Listado_Completo")
        End If
    End Function

End Class
