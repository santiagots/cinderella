Public Class PagoCuentaCorrienteClienteMayorista
    Private id_Pago_ As Int16
    Public Property Id_Pago() As Int16
        Get
            Return id_Pago_
        End Get
        Set(ByVal value As Int16)
            id_Pago_ = value
        End Set
    End Property

    Private id_Empresa_ As Integer
    Public Property id_Empresa() As Integer
        Get
            Return id_Empresa_
        End Get
        Set(ByVal value As Integer)
            id_Empresa_ = value
        End Set
    End Property

    Private id_Cheque_ As Integer
    Public Property id_Cheque() As String
        Get
            Return id_Cheque_
        End Get
        Set(ByVal value As String)
            id_Cheque_ = value
        End Set
    End Property

    Private Fecha_ As DateTime
    Public Property Fecha() As DateTime
        Get
            Return Fecha_
        End Get
        Set(ByVal value As DateTime)
            Fecha_ = value
        End Set
    End Property

    Private FormaPago_ As String
    Public Property FormaPago() As String
        Get
            Return FormaPago_
        End Get
        Set(ByVal value As String)
            FormaPago_ = value
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

    Private Comprobante_ As Integer
    Public Property Comprobante() As Integer
        Get
            Return Comprobante_
        End Get
        Set(ByVal value As Integer)
            Comprobante_ = value
        End Set
    End Property
End Class
