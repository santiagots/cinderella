Public Class NegTipoPago
    Dim clsDatos As New Datos.Conexion
    Dim ClsFunciones As New Funciones
    Dim HayInternet As Boolean = ClsFunciones.GotInternet

    'Funcion que lista los tipos de pago permitidos en el sistema.
    Function ListadoTiposPagos() As DataSet
        If (HayInternet) Then
            Return clsDatos.ConsultarBaseRemoto("execute sp_TipoPagos_Listado")
        Else
            Return clsDatos.ConsultarBaseLocal("execute sp_TipoPagos_Listado")
        End If
    End Function

End Class
