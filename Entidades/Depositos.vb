Public Class Depositos
    Private id_Deposito_, id_Empleado_, id_Sucursal_, Habilitado_ As Integer
    Private Anio_, Mes_ As String
    Private Monto_ As Double
    Dim Fecha_, FHasta_, FDesde_ As Date

    Public Property id_Deposito() As Integer
        Get
            Return id_Deposito_
        End Get
        Set(ByVal value As Integer)
            id_Deposito_ = value
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

    Public Property Mes() As String
        Get
            Return Mes_
        End Get
        Set(ByVal value As String)
            Mes_ = value
        End Set
    End Property

    Public Property Anio() As String
        Get
            Return Anio_
        End Get
        Set(ByVal value As String)
            Anio_ = value
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
