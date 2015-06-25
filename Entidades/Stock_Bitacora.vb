Public Class Stock_Bitacora
    Private id_Bitacora_, id_Stock_, id_Usuario_, id_Sucursal_, id_Producto_, Stock_Minimo_, Stock_Optimo_, Stock_Actual_, Stock_Minimo_Ant_, Stock_Optimo_Ant_, Stock_Actual_Ant_, Habilitado_ As Integer
    Private Motivo_, Usuario_, Accion_ As String
    Private Fecha_ As DateTime

    Public Property id_Bitacora() As Integer
        Get
            Return id_Bitacora_
        End Get
        Set(ByVal value As Integer)
            id_Bitacora_ = value
        End Set
    End Property

    Public Property id_Stock() As Integer
        Get
            Return id_Stock_
        End Get
        Set(ByVal value As Integer)
            id_Stock_ = value
        End Set
    End Property

    Public Property id_Producto() As Integer
        Get
            Return id_Producto_
        End Get
        Set(ByVal value As Integer)
            id_Producto_ = value
        End Set
    End Property

    Public Property id_Sucursal() As Integer
        Get
            Return id_Sucursal_
        End Get
        Set(ByVal value As Integer)
            id_Sucursal_ = value
        End Set
    End Property

    Public Property Stock_Minimo() As Integer
        Get
            Return Stock_Minimo_
        End Get
        Set(ByVal value As Integer)
            Stock_Minimo_ = value
        End Set
    End Property

    Public Property Stock_Actual() As Integer
        Get
            Return Stock_Actual_
        End Get
        Set(ByVal value As Integer)
            Stock_Actual_ = value
        End Set
    End Property

    Public Property Stock_Optimo() As Integer
        Get
            Return Stock_Optimo_
        End Get
        Set(ByVal value As Integer)
            Stock_Optimo_ = value
        End Set
    End Property

    Public Property Stock_Minimo_Ant() As Integer
        Get
            Return Stock_Minimo_Ant_
        End Get
        Set(ByVal value As Integer)
            Stock_Minimo_Ant_ = value
        End Set
    End Property

    Public Property Stock_Actual_Ant() As Integer
        Get
            Return Stock_Actual_Ant_
        End Get
        Set(ByVal value As Integer)
            Stock_Actual_Ant_ = value
        End Set
    End Property

    Public Property Stock_Optimo_Ant() As Integer
        Get
            Return Stock_Optimo_Ant_
        End Get
        Set(ByVal value As Integer)
            Stock_Optimo_Ant_ = value
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

    Public Property Motivo() As String
        Get
            Return Motivo_
        End Get
        Set(ByVal value As String)
            Motivo_ = value
        End Set
    End Property

    Public Property id_Usuario() As Integer
        Get
            Return id_Usuario_
        End Get
        Set(ByVal value As Integer)
            id_Usuario_ = value
        End Set
    End Property

    Public Property Usuario() As String
        Get
            Return Usuario_
        End Get
        Set(ByVal value As String)
            Usuario_ = value
        End Set
    End Property

    Public Property Accion() As String
        Get
            Return Accion_
        End Get
        Set(ByVal value As String)
            Accion_ = value
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
