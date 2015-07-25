Public Class EstadoCuenta

    Private CantidadDiasFeriados_ As Integer
    Public Property CantidadDiasFeriados() As Integer
        Get
            Return CantidadDiasFeriados_
        End Get
        Set(ByVal value As Integer)
            CantidadDiasFeriados_ = value
        End Set
    End Property

    Private CantidadDiasAusentes_ As Integer
    Public Property CantidadDiasAusente() As Integer
        Get
            Return CantidadDiasAusentes_
        End Get
        Set(ByVal value As Integer)
            CantidadDiasAusentes_ = value
        End Set
    End Property

    Private CantidadDiasNormales_ As Integer
    Public Property CantidadDiasNormales() As Integer
        Get
            Return CantidadDiasNormales_
        End Get
        Set(ByVal value As Integer)
            CantidadDiasNormales_ = value
        End Set
    End Property

    Private Vacaciones_ As Double
    Public Property Vacaciones() As Double
        Get
            Return Vacaciones_
        End Get
        Set(ByVal value As Double)
            Vacaciones_ = value
        End Set
    End Property

    Private Aguinaldo_ As Double
    Public Property Aguinaldo() As Double
        Get
            Return Aguinaldo_
        End Get
        Set(ByVal value As Double)
            Aguinaldo_ = value
        End Set
    End Property

    Private RecivoSueldo_ As Double
    Public Property RecivoSueldo() As Double
        Get
            Return RecivoSueldo_
        End Get
        Set(ByVal value As Double)
            RecivoSueldo_ = value
        End Set
    End Property

    Private Comisiones_ As Double

    Public Property Comisiones() As Double

        Get
            Return Comisiones_
        End Get
        Set(ByVal value As Double)
            Comisiones_ = value
        End Set
    End Property

    Private Adelantos_ As Double
    Public Property Adelantos() As Double
        Get
            Return Adelantos_
        End Get
        Set(ByVal value As Double)
            Adelantos_ = value
        End Set
    End Property

    Private SueldoPago_ As Double
    Public Property SueldoPago() As Double
        Get
            Return SueldoPago_
        End Get
        Set(ByVal value As Double)
            SueldoPago_ = value
        End Set
    End Property

    Private Deuda_ As Double?
    Public Property Deuda() As Double?
        Get
            Return Deuda_
        End Get
        Set(ByVal value As Double?)
            Deuda_ = value
        End Set
    End Property

    Private Adicionales_ As Double
    Public Property Adicionales() As Double
        Get
            Return Adicionales_
        End Get
        Set(ByVal value As Double)
            Adicionales_ = value
        End Set
    End Property


End Class
