Public Class Patentes
    Private id_Patente_, Habilitado_ As Integer
    Private Descripcion_ As String

    Public Property id_Patente() As Integer
        Get
            Return id_Patente_
        End Get
        Set(ByVal value As Integer)
            id_Patente_ = value
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
