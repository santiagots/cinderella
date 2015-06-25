Public Class Colores
    Private id_Color_, Habilitado_ As Integer
    Private Descripcion_ As String

    Public Property id_Color() As Integer
        Get
            Return id_Color_
        End Get
        Set(ByVal value As Integer)
            id_Color_ = value
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
