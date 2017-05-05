Public Class Tarjeta
    Private TarjetaId_ As Integer
    Public Property TarjetaId() As Integer
        Get
            Return TarjetaId_
        End Get
        Set(ByVal value As Integer)
            TarjetaId_ = value
        End Set
    End Property

    Private Nombre_ As String
    Public Property Nombre() As String
        Get
            Return Nombre_
        End Get
        Set(ByVal value As String)
            Nombre_ = value
        End Set
    End Property

    Private Habilitado_ As Boolean
    Public Property Habilitado() As Boolean
        Get
            Return Habilitado_
        End Get
        Set(ByVal value As Boolean)
            Habilitado_ = value
        End Set
    End Property

End Class
