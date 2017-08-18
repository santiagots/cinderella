Public Class MovimientoCuentaCorrienteClienteMayorista
    Private Fecha_ As DateTime
    Public Property Fecha() As DateTime
        Get
            Return Fecha_
        End Get
        Set(ByVal value As DateTime)
            Fecha_ = value
        End Set
    End Property

    Private Id_TipoMovimiento_ As Integer
    Public Property Id_TipoMovimiento() As Integer
        Get
            Return Id_TipoMovimiento_
        End Get
        Set(ByVal value As Integer)
            Id_TipoMovimiento_ = value
        End Set
    End Property

    Private TipoMovimiento_ As String
    Public Property TipoMovimiento() As String
        Get
            Return TipoMovimiento_
        End Get
        Set(ByVal value As String)
            TipoMovimiento_ = value
        End Set
    End Property

    Private TipoFactura_ As String
    Public Property TipoFactura() As String
        Get
            Return TipoFactura_
        End Get
        Set(ByVal value As String)
            TipoFactura_ = value
        End Set
    End Property

    Private PuntoVenta_ As Integer
    Public Property PuntoVenta() As Integer
        Get
            Return PuntoVenta_
        End Get
        Set(ByVal value As Integer)
            PuntoVenta_ = value
        End Set
    End Property

    Private Comprobante_ As Integer
    Public Property Comprobante() As Integer
        Get
            Return Comprobante_
        End Get
        Set(ByVal value As Integer)
            Comprobante_ = value
        End Set
    End Property

    Private Pago_ As String
    Public Property Pago() As String
        Get
            Return Pago_
        End Get
        Set(ByVal value As String)
            Pago_ = value
        End Set
    End Property

    Private Monto_ As Decimal
    Public Property Monto() As Decimal
        Get
            Return Monto_
        End Get
        Set(ByVal value As Decimal)
            Monto_ = value
        End Set
    End Property

    Private Empresa_ As String
    Public Property Empresa() As String
        Get
            Return Empresa_
        End Get
        Set(ByVal value As String)
            Empresa_ = value
        End Set
    End Property

    Private Saldo_ As Decimal
    Public Property Saldo() As Decimal
        Get
            Return Saldo_
        End Get
        Set(ByVal value As Decimal)
            Saldo_ = value
        End Set
    End Property

End Class
