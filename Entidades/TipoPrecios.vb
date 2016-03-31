Public Class TipoPrecios
    Private id_ As Integer
    Public Property Id() As Integer
        Get
            Return id_
        End Get
        Set(ByVal value As Integer)
            id_ = value
        End Set
    End Property

    Private descripcion_ As String
    Public Property Descripcion() As String
        Get
            Return descripcion_
        End Get
        Set(ByVal value As String)
            descripcion_ = value
        End Set
    End Property

    Private grupo_ As Integer
    Public Property Grupo() As Integer
        Get
            Return grupo_
        End Get
        Set(ByVal value As Integer)
            grupo_ = value
        End Set
    End Property
End Class
