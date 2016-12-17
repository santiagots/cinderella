Public Class NegTipoEmpleado
    Dim clsDatos As New Datos.Conexion
    Dim ClsFunciones As New Funciones

    'Funcion que lista los tipos de empleado.
    Function ListadoTipos() As DataSet
        If (Funciones.HayInternet) Then
            Return clsDatos.ConsultarBaseRemoto("execute sp_TipoEmpleados_Listado")
        Else
            Return clsDatos.ConsultarBaseLocal("execute sp_TipoEmpleados_Listado")
        End If
    End Function

End Class
