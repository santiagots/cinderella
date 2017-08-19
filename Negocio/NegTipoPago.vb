Public Class NegTipoPago
    Dim clsDatos As New Datos.Conexion
    Dim ClsFunciones As New Funciones

    Private Shared ListaProductosCache As DataSet

    'Funcion que lista los tipos de pago permitidos en el sistema.
    Function ListadoTiposPagos() As DataSet
        If (Funciones.HayInternet) Then
            Return clsDatos.ConsultarBaseRemoto("execute sp_TipoPagos_Listado")
        Else
            Return clsDatos.ConsultarBaseLocal("execute sp_TipoPagos_Listado")
        End If
    End Function

    'Funcion que lista los tipos de pago permitidos en el sistema utilizando memoria cache.
    Function ListadoTiposPagosCache(usarCache As Boolean) As DataSet
        If (ListaProductosCache Is Nothing OrElse Not usarCache) Then
            ListaProductosCache = ListadoTiposPagos()
        End If
        Return ListaProductosCache

    End Function
End Class
