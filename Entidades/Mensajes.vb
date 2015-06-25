Public Class Mensajes
    Dim id_Mensaje_, id_Usuario_, id_UsuarioDestino_, Habilitado_ As Integer
    Dim Mensaje_, Asunto_, Leido_ As String
    Dim Fecha_ As DateTime

    Public Property id_Mensaje() As Integer
        Get
            Return id_Mensaje_
        End Get
        Set(ByVal value As Integer)
            id_Mensaje_ = value
        End Set
    End Property

    Public Property id_Usuario() As Integer
        Get
            Return id_Usuario_
        End Get
        Set(ByVal value As Integer)
            id_Usuario_ = value
        End Set
    End Property

    Public Property id_UsuarioDestino() As Integer
        Get
            Return id_UsuarioDestino_
        End Get
        Set(ByVal value As Integer)
            id_UsuarioDestino_ = value
        End Set
    End Property

    Public Property Asunto() As String
        Get
            Return Asunto_
        End Get
        Set(ByVal value As String)
            Asunto_ = value
        End Set
    End Property

    Public Property Mensaje() As String
        Get
            Return Mensaje_
        End Get
        Set(ByVal value As String)
            Mensaje_ = value
        End Set
    End Property

    Public Property Leido() As String
        Get
            Return Leido_
        End Get
        Set(ByVal value As String)
            Leido_ = value
        End Set
    End Property

    Public Property Fecha() As DateTime
        Get
            Return Fecha_
        End Get
        Set(ByVal value As DateTime)
            Fecha_ = value
        End Set
    End Property

    Public Property Habilitado() As Integer
        Get
            Return Habilitado_
        End Get
        Set(ByVal value As Integer)
            Habilitado_ = value
        End Set
    End Property
End Class
