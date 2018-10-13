Public Class NegTipoPago
    Dim clsDatos As New Datos.Conexion
    Dim ClsFunciones As New Funciones

    Private Shared ListaProductosCache As DataSet

    'Funcion que lista los tipos de pago permitidos en el sistema.
    Function ListadoTiposPagos() As DataSet
        Return clsDatos.ConsultarBaseLocal("execute sp_TipoPagos_Listado")
    End Function

End Class
