Public Class Materiales
    Private id_Material_, Habilitado_ As Integer
    Private Descripcion_ As String

    Public Property id_Material() As Integer
        Get
            Return id_Material_
        End Get
        Set(ByVal value As Integer)
            id_Material_ = value
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
