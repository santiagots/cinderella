Public Class EntidadConfiguracion

    Private NombreSucursal_ As String
    Public Property NombreSucursal() As String
        Get
            Return NombreSucursal_
        End Get
        Set(ByVal value As String)
            NombreSucursal_ = value
        End Set
    End Property


    Private NombreGrupoPrecio_ As String
    Public Property NombreGrupoPrecio() As String
        Get
            Return NombreGrupoPrecio_
        End Get
        Set(ByVal value As String)
            NombreGrupoPrecio_ = value
        End Set
    End Property

    Private Id_Sucursal_ As Integer
    Public Property Id_Sucursal() As Integer
        Get
            Return Id_Sucursal_
        End Get
        Set(ByVal value As Integer)
            Id_Sucursal_ = value
        End Set
    End Property

    Private Id_GrupoPrecio_ As Integer
    Public Property Id_GrupoPrecio() As Integer
        Get
            Return Id_GrupoPrecio_
        End Get
        Set(ByVal value As Integer)
            Id_GrupoPrecio_ = value
        End Set
    End Property


End Class
