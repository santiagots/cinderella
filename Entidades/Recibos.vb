Public Class Recibos
    Private id_Recibo_, id_Empleado_, id_Sucursal_, Anio_ As Integer
    Private Mes_ As String
    Private Monto_, Aguinaldo_, Vacaciones_ As Double

    Public Property id_Recibo() As Integer
        Get
            Return id_Recibo_
        End Get
        Set(ByVal value As Integer)
            id_Recibo_ = value
        End Set
    End Property

    Public Property id_Empleado() As Integer
        Get
            Return id_Empleado_
        End Get
        Set(ByVal value As Integer)
            id_Empleado_ = value
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

    Public Property Anio() As Integer
        Get
            Return Anio_
        End Get
        Set(ByVal value As Integer)
            Anio_ = value
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

    Public Property Vacaciones() As Double
        Get
            Return Vacaciones_
        End Get
        Set(ByVal value As Double)
            Vacaciones_ = value
        End Set
    End Property

    Public Property Aguinaldo() As Double
        Get
            Return Aguinaldo_
        End Get
        Set(ByVal value As Double)
            Aguinaldo_ = value
        End Set
    End Property

    Public Property Mes() As String
        Get
            Return Mes_
        End Get
        Set(ByVal value As String)
            Mes_ = value
        End Set
    End Property

End Class
