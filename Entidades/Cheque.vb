Public Enum ChequeEstado
    Ingresado = 0
    Salido = 1
    Reingresado = 2
End Enum

Public Enum ChequeDestinoSalida
    SinSalida = 0
    Depositado = 1
    Pasado = 2
    Devuelto = 3
    Otro = 4
End Enum

Public Class Cheque

    Private IdCheque_ As Integer
    Public Property IdCheque() As Integer
        Get
            Return IdCheque_
        End Get
        Set(ByVal value As Integer)
            IdCheque_ = value
        End Set
    End Property


    Private NumeroOrden_ As Integer
    Public Property NumeroOrden() As Integer
        Get
            Return NumeroOrden_
        End Get
        Set(ByVal value As Integer)
            NumeroOrden_ = value
        End Set
    End Property

    Private MarcaFacturado_ As Boolean
    Public Property MarcaFacturado() As Boolean
        Get
            Return MarcaFacturado_
        End Get
        Set(ByVal value As Boolean)
            MarcaFacturado_ = value
        End Set
    End Property

    Private FechaIngreso_ As Date
    Public Property FechaIngreso() As Date
        Get
            Return FechaIngreso_
        End Get
        Set(ByVal value As Date)
            FechaIngreso_ = value
        End Set
    End Property

    Private ClienteId_ As Integer
    Public Property ClienteId() As Integer
        Get
            Return ClienteId_
        End Get
        Set(ByVal value As Integer)
            ClienteId_ = value
        End Set
    End Property

    Private ClienteNombre_ As String
    Public Property ClienteNombre() As String
        Get
            Return ClienteNombre_
        End Get
        Set(ByVal value As String)
            ClienteNombre_ = value
        End Set
    End Property

    Private LibradorId_ As Integer
    Public Property LibradorId() As Integer
        Get
            Return LibradorId_
        End Get
        Set(ByVal value As Integer)
            LibradorId_ = value
        End Set
    End Property

    Private LibradorNombre_ As String
    Public Property LibradorNombre() As String
        Get
            Return LibradorNombre_
        End Get
        Set(ByVal value As String)
            LibradorNombre_ = value
        End Set
    End Property

    Private BancoEmisorId_ As Integer
    Public Property BancoEmisorId() As Integer
        Get
            Return BancoEmisorId_
        End Get
        Set(ByVal value As Integer)
            BancoEmisorId_ = value
        End Set
    End Property

    Private NumeroCheque_ As Integer
    Public Property NumeroCheque() As Integer
        Get
            Return NumeroCheque_
        End Get
        Set(ByVal value As Integer)
            NumeroCheque_ = value
        End Set
    End Property

    Private FechaDeposito_ As Date
    Public Property FechaDesposito() As Date
        Get
            Return FechaDeposito_
        End Get
        Set(ByVal value As Date)
            FechaDeposito_ = value
        End Set
    End Property

    Private FechaVencimiento_ As Date
    Public Property FechaVencimiento() As Date
        Get
            Return FechaVencimiento_
        End Get
        Set(ByVal value As Date)
            FechaVencimiento_ = value
        End Set
    End Property

    Private Importe_ As Double
    Public Property Importe() As Double
        Get
            Return Importe_
        End Get
        Set(ByVal value As Double)
            Importe_ = value
        End Set
    End Property

    Private FechaSalida_ As Date?
    Public Property FechaSalida() As Date?
        Get
            Return FechaSalida_
        End Get
        Set(ByVal value As Date?)
            FechaSalida_ = value
        End Set
    End Property

    Private DetalleSalida_ As String
    Public Property DetalleSalida() As String
        Get
            Return DetalleSalida_
        End Get
        Set(ByVal value As String)
            DetalleSalida_ = value
        End Set
    End Property

    Private SucursalId_ As Integer
    Public Property SucursalId() As Integer
        Get
            Return SucursalId_
        End Get
        Set(ByVal value As Integer)
            SucursalId_ = value
        End Set
    End Property

    Private Estado_ As ChequeEstado
    Public Property Estado() As ChequeEstado
        Get
            Return Estado_
        End Get
        Set(ByVal value As ChequeEstado)
            Estado_ = value
        End Set
    End Property

    Private DestinoSalida_ As ChequeDestinoSalida
    Public Property DestinoSalida() As ChequeDestinoSalida
        Get
            Return DestinoSalida_
        End Get
        Set(ByVal value As ChequeDestinoSalida)
            DestinoSalida_ = value
        End Set
    End Property



End Class
