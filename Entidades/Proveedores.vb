Public Class Proveedores
    Private id_Proveedor_, id_CondicionIva_, Habilitado_ As Integer
    Private Nombre_, Direccion_, Mail_, Telefono_, RazonSocial_, Mail_Alternativo_ As String
    Public Property id_Proveedor() As Integer
        Get
            Return id_Proveedor_
        End Get
        Set(ByVal value As Integer)
            id_Proveedor_ = value
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

    Public Property RazonSocial() As String
        Get
            Return RazonSocial_
        End Get
        Set(ByVal value As String)
            RazonSocial_ = value
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

    Public Property Mail_Alternativo() As String
        Get
            Return Mail_Alternativo_
        End Get
        Set(ByVal value As String)
            Mail_Alternativo_ = value
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

End Class
