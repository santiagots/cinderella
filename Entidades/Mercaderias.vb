Public Class Mercaderias
    Private id_Mercaderia_, id_Sucursal_, id_Proveedor_, Habilitado_, CantidadTotal_ As Integer
    Private MontoTotal_ As Double
    Private Fecha_ As DateTime

    Public Property id_Mercaderia() As Integer
        Get
            Return id_Mercaderia_
        End Get
        Set(ByVal value As Integer)
            id_Mercaderia_ = value
        End Set
    End Property

    Public Property id_Sucursal() As Integer
        Get
            Return id_Sucursal_
        End Get
        Set(ByVal value As Integer)
            id_Sucursal_ = value
        End Set
    End Property

    Public Property id_Proveedor() As Integer
        Get
            Return id_Proveedor_
        End Get
        Set(ByVal value As Integer)
            id_Proveedor_ = value
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

    Public Property CantidadTotal() As Integer
        Get
            Return CantidadTotal_
        End Get
        Set(ByVal value As Integer)
            CantidadTotal_ = value
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

    Public Property MontoTotal() As Double
        Get
            Return MontoTotal_
        End Get
        Set(ByVal value As Double)
            MontoTotal_ = value
        End Set
    End Property
End Class
