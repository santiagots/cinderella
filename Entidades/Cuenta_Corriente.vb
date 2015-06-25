Public Class Cuenta_Corriente
    Private id_Mercaderia_, id_Sucursal_, id_Proveedor_, id_Registro_ As Integer
    Private Monto_ As Double
    Private Fecha_ As DateTime

    Public Property id_Registro() As Integer
        Get
            Return id_Registro_
        End Get
        Set(ByVal value As Integer)
            id_Registro_ = value
        End Set
    End Property

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

    Public Property Fecha() As DateTime
        Get
            Return Fecha_
        End Get
        Set(ByVal value As DateTime)
            Fecha_ = value
        End Set
    End Property

    Public Property Monto() As Double
        Get
            Return Monto_
        End Get
        Set(ByVal value As Double)
            Monto_ = value
        End Set
    End Property
End Class
