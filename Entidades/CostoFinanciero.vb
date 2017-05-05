Public Class CostoFinanciero
    Private CostoFinancieroId_ As Integer
    Public Property CostoFinancieroId() As Integer
        Get
            Return CostoFinancieroId_
        End Get
        Set(ByVal value As Integer)
            CostoFinancieroId_ = value
        End Set
    End Property

    Private TarjetaId_ As Integer
    Public Property Tarjeta() As Integer
        Get
            Return TarjetaId_
        End Get
        Set(ByVal value As Integer)
            TarjetaId_ = value
        End Set
    End Property

    Private numeroCuotas_ As Integer
    Public Property NumeroCuotas() As Integer
        Get
            Return numeroCuotas_
        End Get
        Set(ByVal value As Integer)
            numeroCuotas_ = value
        End Set
    End Property

    Private porcentajeRecargo_ As Double
    Public Property PorcentajeRecargo() As Double
        Get
            Return porcentajeRecargo_
        End Get
        Set(ByVal value As Double)
            porcentajeRecargo_ = value
        End Set
    End Property

End Class
