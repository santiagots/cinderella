Public Enum MoviminetoSocios
    Retiro
    Aporte
End Enum


Public Class MovSocios
    Private id_Movimiento_, id_Sucursal_ As Integer
    Private Monto_ As Double
    Private Descripcion_, Encargado_, Persona_ As String
    Dim Fecha_ As Date

    Public Property id_Movimiento() As Integer
        Get
            Return id_Movimiento_
        End Get
        Set(ByVal value As Integer)
            id_Movimiento_ = value
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

    Public Property Descripcion() As String
        Get
            Return Descripcion_
        End Get
        Set(ByVal value As String)
            Descripcion_ = value
        End Set
    End Property

    Public Property Encargado() As String
        Get
            Return Encargado_
        End Get
        Set(ByVal value As String)
            Encargado_ = value
        End Set
    End Property

    Public Property Persona() As String
        Get
            Return Persona_
        End Get
        Set(ByVal value As String)
            Persona_ = value
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

    Private _idTipoPago As String
    Public Property IdTipoPago() As String
        Get
            Return _idTipoPago
        End Get
        Set(ByVal value As String)
            _idTipoPago = value
        End Set
    End Property

    Private _IdCheque As Integer
    Public Property IdCheque() As Integer
        Get
            Return _IdCheque
        End Get
        Set(ByVal value As Integer)
            _IdCheque = value
        End Set
    End Property

End Class
