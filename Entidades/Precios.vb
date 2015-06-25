Public Class Precios
    Private id_Categoria_, id_Producto_, id_Precio_, Habilitado_ As Integer
    Private Precio_ As Double

    Public Property id_Precio() As Integer
        Get
            Return id_Precio_
        End Get
        Set(ByVal value As Integer)
            id_Precio_ = value
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

    Public Property id_Categoria() As Integer
        Get
            Return id_Categoria_
        End Get
        Set(ByVal value As Integer)
            id_Categoria_ = value
        End Set
    End Property

    Public Property Precio() As Double
        Get
            Return Precio_
        End Get
        Set(ByVal value As Double)
            Precio_ = value
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
