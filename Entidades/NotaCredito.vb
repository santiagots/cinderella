Public Class NotaCredito
    Private id_NotaCredito_ As Integer
    Public Property id_NotaCredito() As Integer
        Get
            Return id_NotaCredito_
        End Get
        Set(ByVal value As Integer)
            id_NotaCredito_ = value
        End Set
    End Property

    Private id_Devolucion_ As Integer
    Public Property id_Devolucion() As Integer
        Get
            Return id_Devolucion_
        End Get
        Set(ByVal value As Integer)
            id_Devolucion_ = value
        End Set
    End Property

    Private id_Factura_ As Integer
    Public Property id_Factura() As Integer
        Get
            Return id_Factura_
        End Get
        Set(ByVal value As Integer)
            id_Factura_ = value
        End Set
    End Property

    Private NumeroNotaCredito_ As String
    Public Property NumeroNotaCredito() As String
        Get
            Return NumeroNotaCredito_
        End Get
        Set(ByVal value As String)
            NumeroNotaCredito_ = value
        End Set
    End Property

    Private Monto_ As Double
    Public Property Monto() As Double
        Get
            Return Monto_
        End Get
        Set(ByVal value As Double)
            Monto_ = value
        End Set
    End Property

    Private Fecha_ As Date
    Public Property Fecha() As Date
        Get
            Return Fecha_
        End Get
        Set(ByVal value As Date)
            Fecha_ = value
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

    Private Direccion_ As String
    Public Property Direccion() As String
        Get
            Return Direccion_
        End Get
        Set(ByVal value As String)
            Direccion_ = value
        End Set
    End Property

    Private Localidad_ As String
    Public Property Localidad() As String
        Get
            Return Localidad_
        End Get
        Set(ByVal value As String)
            Localidad_ = value
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

    Private TipoRecibo_ As TipoFactura
    Public Property TipoRecibo() As TipoFactura
        Get
            Return TipoRecibo_
        End Get
        Set(ByVal value As TipoFactura)
            TipoRecibo_ = value
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

    Private id_Sucursal_ As Integer
    Public Property id_Sucursal() As Integer
        Get
            Return Id_Sucursal_
        End Get
        Set(ByVal value As Integer)
            Id_Sucursal_ = value
        End Set
    End Property
End Class
