Public Class Sucursales

    Private id_Sucursal_, Habilitado_, id_Provincia_, id_Distrito_, id_Localidad_, Codigo_Postal_ As Integer
    Private Nombre_, Direccion_, Telefono_ As String
    Private ComisionEncargado_, ComisionVendedor_, ComisionEncargadoFeriado_, ComisionVendedorFeriado_, ComisionEncargadoMayor_, ComisionVendedorMayor_ As Double
    Public Property id_Sucursal() As Integer
        Get
            Return id_Sucursal_
        End Get
        Set(ByVal value As Integer)
            id_Sucursal_ = value
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

    Public Property ComisionVendedor() As Double
        Get
            Return ComisionVendedor_
        End Get
        Set(ByVal value As Double)
            ComisionVendedor_ = value
        End Set
    End Property

    Public Property ComisionEncargado() As Double
        Get
            Return ComisionEncargado_
        End Get
        Set(ByVal value As Double)
            ComisionEncargado_ = value
        End Set
    End Property

    Public Property ComisionVendedorFeriado() As Double
        Get
            Return ComisionVendedorFeriado_
        End Get
        Set(ByVal value As Double)
            ComisionVendedorFeriado_ = value
        End Set
    End Property

    Public Property ComisionEncargadoFeriado() As Double
        Get
            Return ComisionEncargadoFeriado_
        End Get
        Set(ByVal value As Double)
            ComisionEncargadoFeriado_ = value
        End Set
    End Property

    Public Property ComisionVendedorMayor() As Double
        Get
            Return ComisionVendedorMayor_
        End Get
        Set(ByVal value As Double)
            ComisionVendedorMayor_ = value
        End Set
    End Property

    Public Property ComisionEncargadoMayor() As Double
        Get
            Return ComisionEncargadoMayor_
        End Get
        Set(ByVal value As Double)
            ComisionEncargadoMayor_ = value
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
    Public Property Codigo_Postal() As Integer
        Get
            Return Codigo_Postal_
        End Get
        Set(ByVal value As Integer)
            Codigo_Postal_ = value
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

    Public Property Telefono() As String
        Get
            Return Telefono_
        End Get
        Set(ByVal value As String)
            Telefono_ = value
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
