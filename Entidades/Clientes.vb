Public Class Clientes

    Private id_Cliente_, id_Precio_, id_CondicionIva_, id_Provincia_, id_Distrito_, id_Localidad_, Codigo_Postal_, Habilitado_ As Integer
    Private RazonSocial_, Contacto_, Cuit_, Transporte_, Direccion_, Mail_, Telefono_, Observaciones_ As String
    Dim Fecha_ As DateTime

    Public Property id_Cliente() As Integer
        Get
            Return id_Cliente_
        End Get
        Set(ByVal value As Integer)
            id_Cliente_ = value
        End Set
    End Property

    Public Property id_Precio() As Integer
        Get
            Return id_Precio_
        End Get
        Set(ByVal value As Integer)
            id_Precio_ = value
        End Set
    End Property

    Public Property id_CondicionIva() As Integer
        Get
            Return id_CondicionIva_
        End Get
        Set(ByVal value As Integer)
            id_CondicionIva_ = value
        End Set
    End Property

    Public Property id_Provincia() As Integer
        Get
            Return id_Provincia_
        End Get
        Set(ByVal value As Integer)
            id_Provincia_ = value
        End Set
    End Property

    Public Property id_Distrito() As Integer
        Get
            Return id_Distrito_
        End Get
        Set(ByVal value As Integer)
            id_Distrito_ = value
        End Set
    End Property

    Public Property id_Localidad() As Integer
        Get
            Return id_Localidad_
        End Get
        Set(ByVal value As Integer)
            id_Localidad_ = value
        End Set
    End Property

    Public Property RazonSocial() As String
        Get
            Return RazonSocial_
        End Get
        Set(ByVal value As String)
            RazonSocial_ = value
        End Set
    End Property

    Public Property Contacto() As String
        Get
            Return Contacto_
        End Get
        Set(ByVal value As String)
            Contacto_ = value
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

    Public Property Transporte() As String
        Get
            Return Transporte_
        End Get
        Set(ByVal value As String)
            Transporte_ = value
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

    Public Property Codigo_Postal() As Integer
        Get
            Return Codigo_Postal_
        End Get
        Set(ByVal value As Integer)
            Codigo_Postal_ = value
        End Set
    End Property

    Public Property Mail() As String
        Get
            Return Mail_
        End Get
        Set(ByVal value As String)
            Mail_ = value
        End Set
    End Property

    Public Property Telefono() As String
        Get
            Return Telefono_
        End Get
        Set(ByVal value As String)
            Telefono_ = value
        End Set
    End Property

    Public Property Observaciones() As String
        Get
            Return Observaciones_
        End Get
        Set(ByVal value As String)
            Observaciones_ = value
        End Set
    End Property

    Public Property Habilitado() As Integer
        Get
            Return Habilitado_
        End Get
        Set(ByVal value As Integer)
            Habilitado_ = value
        End Set
    End Property

    Public Property Fecha() As DateTime
        Get
            Return Fecha_
        End Get
        Set(ByVal value As DateTime)
            Fecha_ = value
        End Set
    End Property
End Class
