Public Class Provincias
    Private id_Provincia_, Habilitado_ As Integer
    Private Descripcion_ As String

    Public Property id_Provincia() As Integer
        Get
            Return id_Provincia_
        End Get
        Set(ByVal value As Integer)
            id_Provincia_ = value
        End Set
    End Property
    Public Property Descripcion() As Integer
        Get
            Return Descripcion_
        End Get
        Set(ByVal value As Integer)
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
