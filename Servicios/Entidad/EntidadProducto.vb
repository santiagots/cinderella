Public Class EntidadProducto
    Private id_Producto_ As Integer
    Private Nombre_, Codigo_ As String
    Private Precio1_, Precio2_, Precio3_, Precio4_, Precio5_, Precio6_ As Double

    Private EliminarFoto_ As Boolean

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

    Public Property Precio1() As Double
        Get
            Return Precio1_
        End Get
        Set(ByVal value As Double)
            Precio1_ = value
        End Set
    End Property

    Public Property Precio2() As Double
        Get
            Return Precio2_
        End Get
        Set(ByVal value As Double)
            Precio2_ = value
        End Set
    End Property

    Public Property Precio3() As Double
        Get
            Return Precio3_
        End Get
        Set(ByVal value As Double)
            Precio3_ = value
        End Set
    End Property

    Public Property Precio4() As Double
        Get
            Return Precio4_
        End Get
        Set(ByVal value As Double)
            Precio4_ = value
        End Set
    End Property

    Public Property Precio5() As Double
        Get
            Return Precio5_
        End Get
        Set(ByVal value As Double)
            Precio5_ = value
        End Set
    End Property

    Public Property Precio6() As Double
        Get
            Return Precio6_
        End Get
        Set(ByVal value As Double)
            Precio6_ = value
        End Set
    End Property
End Class
