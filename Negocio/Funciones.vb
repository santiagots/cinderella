Public Class Funciones

    Public Function GotInternet() As Boolean
        Dim Url As New System.Uri("http://www.google.com")
        Dim peticion As System.Net.WebRequest
        Dim respuesta As System.Net.WebResponse

        Try
            'Creamos la peticion
            peticion = System.Net.WebRequest.Create(Url)

            'POnemos un tiempo limite
            peticion.Timeout = 15000

            'ejecutamos la peticion
            respuesta = peticion.GetResponse
            respuesta.Close()
            peticion = Nothing

            Return True
        Catch ex As Exception
            'si ocurre un error, devolvemos error
            peticion = Nothing
            Return False
        End Try
    End Function

End Class
