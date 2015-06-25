Public Class Aromas
    Private id_Aroma_, Habilitado_ As Integer
    Private Descripcion_ As String

    Public Property id_Aroma() As Integer
        Get
            Return id_Aroma_
        End Get
        Set(ByVal value As Integer)
            id_Aroma_ = value
        End Set
    End Property

    Public Property Descripcion() As String
        Get
            Return Descripcion_
        End Get
        Set(ByVal value As String)
            Descripcion_ = value
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
