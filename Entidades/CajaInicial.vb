Public Class CajaInicial
    Private Fecha_ As Date
    Private Hora_ As DateTime
    Private id_Caja_, id_Sucursal_, id_Empleado_, Abierta_ As Integer
    Private Monto_ As Double
    Private Empleado_ As String

    Public Property id_Caja() As Integer
        Get
            Return id_Caja_
        End Get
        Set(ByVal value As Integer)
            id_Caja_ = value
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

    Public Property id_Empleado() As Integer
        Get
            Return id_Empleado_
        End Get
        Set(ByVal value As Integer)
            id_Empleado_ = value
        End Set
    End Property

    Public Property Empleado() As String
        Get
            Return Empleado_
        End Get
        Set(ByVal value As String)
            Empleado_ = value
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

    Public Property Hora() As DateTime
        Get
            Return Hora_
        End Get
        Set(ByVal value As DateTime)
            Hora_ = value
        End Set
    End Property

    Public Property Abierta() As Integer
        Get
            Return Abierta_
        End Get
        Set(ByVal value As Integer)
            Abierta_ = value
        End Set
    End Property
End Class
