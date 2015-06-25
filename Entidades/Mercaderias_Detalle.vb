Public Class Mercaderias_Detalle
    Private id_Mercaderia_, id_Detalle_, id_Producto_, Cantidad_ As Integer
    Private Costo_, Total_ As Double
    Public Property id_Mercaderia() As Integer
        Get
            Return id_Mercaderia_
        End Get
        Set(ByVal value As Integer)
            id_Mercaderia_ = value
        End Set
    End Property

    Public Property id_Detalle() As Integer
        Get
            Return id_Detalle_
        End Get
        Set(ByVal value As Integer)
            id_Detalle_ = value
        End Set
    End Property

    Public Property id_Producto() As Integer
        Get
            Return id_Producto_
        End Get
        Set(ByVal value As Integer)
            id_Producto_ = value
        End Set
    End Property


    Public Property Cantidad() As Integer
        Get
            Return Cantidad_
        End Get
        Set(ByVal value As Integer)
            Cantidad_ = value
        End Set
    End Property

    Public Property Costo() As Double
        Get
            Return Costo_
        End Get
        Set(ByVal value As Double)
            Costo_ = value
        End Set
    End Property

    Public Property Total() As Double
        Get
            Return Total_
        End Get
        Set(ByVal value As Double)
            Total_ = value
        End Set
    End Property
End Class
