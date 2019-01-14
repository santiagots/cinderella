Public Class EntidadProductoReducido
    Private Id_ As Integer
    Public Property Id As Integer
        Get
            Return Id_
        End Get
        Set(ByVal value As Integer)
            Id_ = value
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

    Private Codigo_ As String
    Public Property Codigo() As String
        Get
            Return Codigo_
        End Get
        Set(ByVal value As String)
            Codigo_ = value
        End Set
    End Property

    Private CodigoBarras_ As String
    Public Property CodigoBarras() As String
        Get
            Return CodigoBarras_
        End Get
        Set(ByVal value As String)
            CodigoBarras_ = value
        End Set
    End Property

End Class
