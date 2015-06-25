Public Class Movimientos
    Private id_Adelanto_, id_TipoEgreso_, id_Tipo_, id_Sucursal_ As Integer
    Private Descripcion_ As String
    Private Monto_ As Double
    Dim Fecha_ As Date

    Public Property id_Adelanto() As Integer
        Get
            Return id_Adelanto_
        End Get
        Set(ByVal value As Integer)
            id_Adelanto_ = value
        End Set
    End Property

    Public Property id_TipoEgreso() As Integer
        Get
            Return id_TipoEgreso_
        End Get
        Set(ByVal value As Integer)
            id_TipoEgreso_ = value
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

    Public Property Descripcion() As String
        Get
            Return Descripcion_
        End Get
        Set(ByVal value As String)
            Descripcion_ = value
        End Set
    End Property
End Class
