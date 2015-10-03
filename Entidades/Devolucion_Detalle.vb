Public Class Devolucion_Detalle
    Private id_Detalle_, id_Producto_, Cantidad_ As Integer
        Dim Precio_ As Double

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

        Public Property Precio() As Double
            Get
                Return Precio_
            End Get
            Set(ByVal value As Double)
                Precio_ = value
            End Set
        End Property

End Class
