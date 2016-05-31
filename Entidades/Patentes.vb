Public Class Patentes

    Private id_Patente_ As Integer
    Public Property id_Patente() As Integer
        Get
            Return id_Patente_
        End Get
        Set(ByVal value As Integer)
            id_Patente_ = value
        End Set
    End Property

    Private id_Sucursal_ As Integer
    Public Property id_Sucursal() As Integer
        Get
            Return id_Sucursal_
        End Get
        Set(ByVal value As Integer)
            id_Sucursal_ = value
        End Set
    End Property

    Private id_Perfil_ As Integer
    Public Property id_Perfil() As Integer
        Get
            Return id_Perfil_
        End Get
        Set(ByVal value As Integer)
            id_Perfil_ = value
        End Set
    End Property

End Class
