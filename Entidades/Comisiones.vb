Public Class Comisiones
    Dim id_Comision_, id_Empleado_, id_Venta_, id_Sucursal_ As Integer
    Dim Comision_, Monto_ As Double

    Public Property id_Comision() As Integer
        Get
            Return id_Comision_
        End Get
        Set(ByVal value As Integer)
            id_Comision_ = value
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

    Public Property id_Venta() As Integer
        Get
            Return id_Venta_
        End Get
        Set(ByVal value As Integer)
            id_Venta_ = value
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

    Public Property Comision() As Double
        Get
            Return Comision_
        End Get
        Set(ByVal value As Double)
            Comision_ = value
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
