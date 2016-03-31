Public Class ConsumidorFinal
    Private nombre_ As String
    Public Property Nombre() As String
        Get
            Return nombre_
        End Get
        Set(ByVal value As String)
            nombre_ = value
        End Set
    End Property

    Private apellido_ As String
    Public Property Apellido() As String
        Get
            Return apellido_
        End Get
        Set(ByVal value As String)
            apellido_ = value
        End Set
    End Property

    Private email_ As String
    Public Property Email() As String
        Get
            Return email_
        End Get
        Set(ByVal value As String)
            email_ = value
        End Set
    End Property


End Class
