Public Enum TipoFactura
    Ticket = 0
    Manual = 1
    Electronica = 2
End Enum


Public Class Facturacion
    Private id_Venta_, id_Facturacion_ As Integer
    Dim Monto_ As Double
    Dim NumeroFactura_, TipoFactura_, CondicionIva_, Direccion_, Nombre_, Localidad_, Cuit_ As String
    Dim Fecha_ As Date

    Public Property id_Facturacion() As Integer
        Get
            Return id_Facturacion_
        End Get
        Set(ByVal value As Integer)
            id_Facturacion_ = value
        End Set
    End Property
    Public Property id_Venta() As Integer
        Get
            Return id_Venta_
        End Get
        Set(ByVal value As Integer)
            id_Venta_ = value
        End Set
    End Property
    Public Property NumeroFactura() As String
        Get
            Return NumeroFactura_
        End Get
        Set(ByVal value As String)
            NumeroFactura_ = value
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

    Public Property TipoFactura() As String
        Get
            Return TipoFactura_
        End Get
        Set(ByVal value As String)
            TipoFactura_ = value
        End Set
    End Property

    Public Property CondicionIva() As String
        Get
            Return CondicionIva_
        End Get
        Set(ByVal value As String)
            CondicionIva_ = value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return Nombre_
        End Get
        Set(ByVal value As String)
            Nombre_ = value
        End Set
    End Property

    Public Property Direccion() As String
        Get
            Return Direccion_
        End Get
        Set(ByVal value As String)
            Direccion_ = value
        End Set
    End Property

    Public Property Localidad() As String
        Get
            Return Localidad_
        End Get
        Set(ByVal value As String)
            Localidad_ = value
        End Set
    End Property

    Public Property Cuit() As String
        Get
            Return Cuit_
        End Get
        Set(ByVal value As String)
            Cuit_ = value
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

    Private _TipoRecibo As TipoFactura
    Public Property TipoRecibo() As TipoFactura
        Get
            Return _TipoRecibo
        End Get
        Set(ByVal value As TipoFactura)
            _TipoRecibo = value
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

    Private _PuntoVenta As Integer
    Public Property PuntoVenta() As Integer
        Get
            Return _PuntoVenta
        End Get
        Set(ByVal value As Integer)
            _PuntoVenta = value
        End Set
    End Property


End Class
