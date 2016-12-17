Public Class Senia
    Private _Id As Integer
    Public Property Id() As Integer
        Get
            Return _Id
        End Get
        Set(ByVal value As Integer)
            _Id = value
        End Set
    End Property

    Private _IdSucursal As Integer
    Public Property IdSucursal() As Integer
        Get
            Return _IdSucursal
        End Get
        Set(ByVal value As Integer)
            _IdSucursal = value
        End Set
    End Property

    Private _IdClienteMinorista As Integer
    Public Property IdClienteMinorista() As Integer
        Get
            Return _IdClienteMinorista
        End Get
        Set(ByVal value As Integer)
            _IdClienteMinorista = value
        End Set
    End Property

    Private _IdClienteMayorista As Integer
    Public Property IdClienteMayorista() As Integer
        Get
            Return _IdClienteMayorista
        End Get
        Set(ByVal value As Integer)
            _IdClienteMayorista = value
        End Set
    End Property

    Private _ApellidoNombreClienteMinorista As String
    Public Property ApellidoNombreClienteMinorista() As String
        Get
            Return _ApellidoNombreClienteMinorista
        End Get
        Set(ByVal value As String)
            _ApellidoNombreClienteMinorista = value
        End Set
    End Property

    Private _RazonSocial As String
    Public Property RazonSocial() As String
        Get
            Return _RazonSocial
        End Get
        Set(ByVal value As String)
            _RazonSocial = value
        End Set
    End Property

    Private _MontoTotal As Decimal
    Public Property MontoTotal() As Decimal
        Get
            Return _MontoTotal
        End Get
        Set(ByVal value As Decimal)
            _MontoTotal = value
        End Set
    End Property

    Private _MontoSenia As Decimal
    Public Property MontoSenia() As Decimal
        Get
            Return _MontoSenia
        End Get
        Set(ByVal value As Decimal)
            _MontoSenia = value
        End Set
    End Property

    Private _idVentaSenia As Integer
    Public Property IdVentaSenia() As Integer
        Get
            Return _idVentaSenia
        End Get
        Set(ByVal value As Integer)
            _idVentaSenia = value
        End Set
    End Property


    Private _idVentaRetiro As Integer
    Public Property IdVentaRetiro() As Integer
        Get
            Return _idVentaRetiro
        End Get
        Set(ByVal value As Integer)
            _idVentaRetiro = value
        End Set
    End Property

    Private _FechaAlta As Date
    Public Property FechaAlta() As Date
        Get
            Return _FechaAlta
        End Get
        Set(ByVal value As Date)
            _FechaAlta = value
        End Set
    End Property

    Private _FechaEstimadaRetiro As Date
    Public Property FechaEstimadaRetiro() As Date
        Get
            Return _FechaEstimadaRetiro
        End Get
        Set(ByVal value As Date)
            _FechaEstimadaRetiro = value
        End Set
    End Property

    Private _FormaEntrega As String
    Public Property FormaEntrega() As String
        Get
            Return _FormaEntrega
        End Get
        Set(ByVal value As String)
            _FormaEntrega = value
        End Set
    End Property

    Private _Observaciones As String
    Public Property Observaciones() As String
        Get
            Return _Observaciones
        End Get
        Set(ByVal value As String)
            _Observaciones = value
        End Set
    End Property

    Private _Entregada As Boolean
    Public Property Entregada() As Boolean
        Get
            Return _Entregada
        End Get
        Set(ByVal value As Boolean)
            _Entregada = value
        End Set
    End Property

    Private _Anulada As Boolean
    Public Property Anulada() As Boolean
        Get
            Return _Anulada
        End Get
        Set(ByVal value As Boolean)
            _Anulada = value
        End Set
    End Property
End Class
