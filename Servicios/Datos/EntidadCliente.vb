Public Class EntidadClientes

    Private id_Cliente_, Codigo_Postal_, Habilitado_ As Integer
    Private RazonSocial_, Cuit_, Mail_, Telefono_, Observaciones_, Direccion_ As String
    Dim Fecha_ As DateTime

    Public Property id_Cliente() As Integer
        Get
            Return id_Cliente_
        End Get
        Set(ByVal value As Integer)
            id_Cliente_ = value
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

    Public Property Cuit() As String
        Get
            Return Cuit_
        End Get
        Set(ByVal value As String)
            Cuit_ = value
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
