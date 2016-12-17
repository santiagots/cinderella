Public Class NegCondicionesIva
    Dim clsDatos As New Datos.Conexion
    Dim ClsFunciones As New Funciones

    'Funcion que lista todas las condiciones de iva del sistema.
    Function ListadoCondiciones() As DataSet
        If Funciones.HayInternet Then
            Return clsDatos.ConsultarBaseRemoto("execute sp_Condiciones_Listado")
        Else
            Return clsDatos.ConsultarBaseLocal("execute sp_Condiciones_Listado")
        End If
    End Function

End Class
