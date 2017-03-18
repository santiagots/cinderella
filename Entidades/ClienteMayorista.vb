Public Class ClienteMayorista

    Private Id_ As Integer
    Public Property Id() As Integer
        Get
            Return Id_
        End Get
        Set(ByVal value As Integer)
            Id_ = value
        End Set
    End Property

    Private RazonSocial_ As String
    Public Property RazonSocial() As String
        Get
            Return RazonSocial_
        End Get
        Set(ByVal value As String)
            RazonSocial_ = value
        End Set
    End Property

    Private Nombre_ As String
    Public Property Nombre() As String
        Get
            Return Nombre_
        End Get
        Set(ByVal value As String)
            Nombre_ = value
        End Set
    End Property

    Private Cuit_ As String
    Public Property Cuit() As String
        Get
            Return Cuit_
        End Get
        Set(ByVal value As String)
            Cuit_ = value
        End Set
    End Property

    Private IdCondicionIva_ As Integer
    Public Property IdCondicionIva() As Integer
        Get
            Return IdCondicionIva_
        End Get
        Set(ByVal value As Integer)
            IdCondicionIva_ = value
        End Set
    End Property

    Private Comision_ As Integer?
    Public Property Comision() As Integer?
        Get
            Return Comision_
        End Get
        Set(ByVal value As Integer?)
            Comision_ = value
        End Set
    End Property

    Private IdCorredor_ As Integer
    Public Property IdCorredor() As Integer
        Get
            Return IdCorredor_
        End Get
        Set(ByVal value As Integer)
            IdCorredor_ = value
        End Set
    End Property

    Private Transporte_ As String
    Public Property Transporte() As String
        Get
            Return Transporte_
        End Get
        Set(ByVal value As String)
            Transporte_ = value
        End Set
    End Property

    Private Bonificacion_ As Integer?
    Public Property Bonificacion() As Integer?
        Get
            Return Bonificacion_
        End Get
        Set(ByVal value As Integer?)
            Bonificacion_ = value
        End Set
    End Property

    Private Lista_ As Integer?
    Public Property Lista() As Integer?
        Get
            Return Lista_
        End Get
        Set(ByVal value As Integer?)
            Lista_ = value
        End Set
    End Property

    Private CondicionPago_ As String
    Public Property CondicionPago() As String
        Get
            Return CondicionPago_
        End Get
        Set(ByVal value As String)
            CondicionPago_ = value
        End Set
    End Property

    Private IdEmpresa_ As Integer
    Public Property IdEmpresa() As Integer
        Get
            Return IdEmpresa_
        End Get
        Set(ByVal value As Integer)
            IdEmpresa_ = value
        End Set
    End Property

    Private IdListaPrecio_ As Integer
    Public Property IdListaPrecio() As Integer
        Get
            Return IdListaPrecio_
        End Get
        Set(ByVal value As Integer)
            IdListaPrecio_ = value
        End Set
    End Property

    Private Observaciones_ As String
    Public Property Observaciones() As String
        Get
            Return Observaciones_
        End Get
        Set(ByVal value As String)
            Observaciones_ = value
        End Set
    End Property

    Private IdDireccionFacturacion_ As Integer
    Public Property IdDireccionFacturacion() As Integer
        Get
            Return IdDireccionFacturacion_
        End Get
        Set(ByVal value As Integer)
            IdDireccionFacturacion_ = value
        End Set
    End Property

    Private IdDireccionEntrega_ As Integer
    Public Property IdDireccionEntrega() As Integer
        Get
            Return IdDireccionEntrega_
        End Get
        Set(ByVal value As Integer)
            IdDireccionEntrega_ = value
        End Set
    End Property

    Private Habilitado_ As Boolean
    Public Property Habilitado() As Boolean
        Get
            Return Habilitado_
        End Get
        Set(ByVal value As Boolean)
            Habilitado_ = value
        End Set
    End Property

    Private SaldoNotaPedido_ As Decimal
    Public Property SaldoNotaPedido() As Decimal
        Get
            Return SaldoNotaPedido_
        End Get
        Set(ByVal value As Decimal)
            SaldoNotaPedido_ = value
        End Set
    End Property

    Private SaldoCuentaCorriente_ As Decimal
    Public Property SaldoCuentaCorriente() As Decimal
        Get
            Return SaldoCuentaCorriente_
        End Get
        Set(ByVal value As Decimal)
            SaldoCuentaCorriente_ = value
        End Set
    End Property

    Sub New()
        Id_ = 0
        RazonSocial_ = String.Empty
        Nombre_ = String.Empty
        Cuit_ = Nothing
        IdCondicionIva_ = 0
        Comision_ = Nothing
        IdCorredor_ = 0
        Transporte_ = String.Empty
        Bonificacion_ = Nothing
        Lista_ = Nothing
        CondicionPago_ = String.Empty
        IdEmpresa_ = 0
        IdListaPrecio_ = 0
        Observaciones_ = String.Empty
        IdDireccionFacturacion_ = 0
        IdDireccionEntrega_ = 0
        Habilitado_ = False
        SaldoNotaPedido_ = 0
        SaldoCuentaCorriente_ = 0
    End Sub

End Class
