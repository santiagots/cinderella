Public Class Adelantos
    Private id_Adelanto_, id_Empleado_, id_Sucursal_ As Integer
    Private Descripcion_ As String
    Private Monto_ As Double
    Dim Fecha_, FHasta_, FDesde_ As Date

    Public Property id_Adelanto() As Integer
        Get
            Return id_Adelanto_
        End Get
        Set(ByVal value As Integer)
            id_Adelanto_ = value
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

    Public Property FDesde() As Date
        Get
            Return FDesde_
        End Get
        Set(ByVal value As Date)
            FDesde_ = value
        End Set
    End Property

    Public Property FHasta() As Date
        Get
            Return FHasta_
        End Get
        Set(ByVal value As Date)
            FHasta_ = value
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
