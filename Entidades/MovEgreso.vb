Public Class MovEgreso
    Private id_Movimiento_, id_MovimientoPadre_, id_Tipo_, id_Subtipo_, id_Sucursal_, id_SucursalDestino_, Aceptado_ As Integer
    Private Monto_ As Double
    Private Descripcion_ As String
    Dim Fecha_ As Date

    Public Property id_Movimiento() As Integer
        Get
            Return id_Movimiento_
        End Get
        Set(ByVal value As Integer)
            id_Movimiento_ = value
        End Set
    End Property

    Public Property id_MovimientoPadre() As Integer
        Get
            Return id_MovimientoPadre_
        End Get
        Set(ByVal value As Integer)
            id_MovimientoPadre_ = value
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

    Public Property id_Subtipo() As Integer
        Get
            Return id_Subtipo_
        End Get
        Set(ByVal value As Integer)
            id_Subtipo_ = value
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
    Public Property id_SucursalDestino() As Integer
        Get
            Return id_SucursalDestino_
        End Get
        Set(ByVal value As Integer)
            id_SucursalDestino_ = value
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
    Public Property Aceptado() As Integer
        Get
            Return Aceptado_
        End Get
        Set(ByVal value As Integer)
            Aceptado_ = value
        End Set
    End Property
End Class
