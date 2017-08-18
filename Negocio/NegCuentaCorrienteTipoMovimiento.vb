Public Class NegCuentaCorrienteTipoMovimiento
    Dim clsDatos As New Datos.Conexion
    Dim ClsFunciones As New Funciones

    'Funcion que lista los tipos de pago permitidos en el sistema.
    Function Listado() As List(Of KeyValuePair(Of Integer, String))

        Dim ds As DataSet

        If (Funciones.HayInternet) Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_TipoMovimientoCuentaCorriente_Listado")
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_TipoMovimientoCuentaCorriente_Listado")
        End If

        Dim respuesta As List(Of KeyValuePair(Of Integer, String)) = New List(Of KeyValuePair(Of Integer, String))()
        respuesta.Add(New KeyValuePair(Of Integer, String)(0, "Seleccione una opción"))

        If (ds.Tables.Count > 0) Then

            For Each row As DataRow In ds.Tables(0).Rows
                Dim item As KeyValuePair(Of Integer, String) = New KeyValuePair(Of Integer, String)(row("Id_TipoMovimiento"), row("Descripcion"))
                respuesta.Add(item)
            Next

        End If

        Return respuesta
    End Function
End Class
