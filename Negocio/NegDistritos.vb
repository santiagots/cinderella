Public Class NegDistritos
    Dim clsDatos As New Datos.Conexion
    Dim ClsFunciones As New Funciones

    'Funcion que trae todos los distritos de una determinada provincia.
    Function ListadoDistritos(ByVal id_Provincia As Integer) As DataSet
        If Funciones.HayInternet Then
            Return clsDatos.ConsultarBaseRemoto("execute sp_Distritos_Listado  @id_Provincia = " & id_Provincia)
        Else
            Return clsDatos.ConsultarBaseLocal("execute sp_Distritos_Listado  @id_Provincia = " & id_Provincia)
        End If
    End Function

    Public Function ListadoDistritos() As DataSet
        If Funciones.HayInternet Then
            Return clsDatos.ConsultarBaseRemoto("execute sp_Distritos_Listado_Completo")
        Else
            Return clsDatos.ConsultarBaseLocal("execute sp_Distritos_Listado_Completo")
        End If
    End Function
End Class
