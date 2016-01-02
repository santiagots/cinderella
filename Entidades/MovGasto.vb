Public Class MovGasto
    Private id_Movimiento_, id_Tipo_, id_Sucursal_, id_Registro_ As Integer
    Private Monto_ As Double
    Dim Fecha_ As Date

    Public Property id_Movimiento() As Integer
        Get
            Return id_Movimiento_
        End Get
        Set(ByVal value As Integer)
            id_Movimiento_ = value
        End Set
    End Property

    Public Property id_Tipo() As Integer
        Get
            Return id_Tipo_
        End Get
        Set(ByVal value As Integer)
            id_Tipo_ = value
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

    Public Property id_Registro() As Integer
        Get
            Return id_Registro_
        End Get
        Set(ByVal value As Integer)
            id_Registro_ = value
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

    Public Property Fecha() As Date
        Get
            Return Fecha_
        End Get
        Set(ByVal value As Date)
            Fecha_ = value
        End Set
    End Property

    Private SoloLectura_ As Boolean
    Public Property SoloLectura() As Boolean
        Get
            Return SoloLectura_
        End Get
        Set(ByVal value As Boolean)
            SoloLectura_ = value
        End Set
    End Property

End Class
