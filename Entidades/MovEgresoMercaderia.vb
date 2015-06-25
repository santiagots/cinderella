Public Class MovEgresoMercaderia
    Private id_Movimiento_, id_Mercaderia_, id_Producto_, Cantidad_, id_Sucursal_ As Integer
    Private Costo_, Subtotal_ As Double
    Private Nombre_, Codigo_ As String

    Public Property id_Mercaderia() As Integer
        Get
            Return id_Mercaderia_
        End Get
        Set(ByVal value As Integer)
            id_Mercaderia_ = value
        End Set
    End Property

    Public Property id_Movimiento() As Integer
        Get
            Return id_Movimiento_
        End Get
        Set(ByVal value As Integer)
            id_Movimiento_ = value
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

    Public Property id_Producto() As Integer
        Get
            Return id_Producto_
        End Get
        Set(ByVal value As Integer)
            id_Producto_ = value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return Nombre_
        End Get
        Set(ByVal value As String)
            Nombre_ = value
        End Set
    End Property

    Public Property Codigo() As String
        Get
            Return Codigo_
        End Get
        Set(ByVal value As String)
            Codigo_ = value
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

    Public Property Cantidad() As Integer
        Get
            Return Cantidad_
        End Get
        Set(ByVal value As Integer)
            Cantidad_ = value
        End Set
    End Property

    Public Property Subtotal() As Double
        Get
            Return Subtotal_
        End Get
        Set(ByVal value As Double)
            Subtotal_ = value
        End Set
    End Property
End Class
