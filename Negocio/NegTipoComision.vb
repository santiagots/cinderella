Public Class NegTipoComision
    Dim clsDatos As New Datos.Conexion
    Dim ClsFunciones As New Funciones

    'Funcion que lista todas las comisiones del sistema.
    Function ListadoComisiones() As DataSet
        If (Funciones.HayInternet) Then
            Return clsDatos.ConsultarBaseRemoto("execute sp_TipoComisiones_Listado")
        Else
            Return clsDatos.ConsultarBaseLocal("execute sp_TipoComisiones_Listado")
        End If
    End Function

End Class
