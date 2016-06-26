Public Class Empleados

    Private id_Empleado_, id_Sucursal_, id_TipoEmpleado_, id_Provincia_, id_Distrito_, id_Localidad_, Codigo_Postal_, Habilitado_ As Integer
    Private Nombre_, Apellido_, Direccion_, Telefono_, Telefono2_, Mail_, Observaciones_, Cuil_ As String
    Private SueldoNormal_, SueldoFeriado_, SueldoPresentismo_ As Double
    Private Sucursales_ As Object
    Private FechaNacimiento_, FechaIngreso_ As Date
    Dim Fecha_ As DateTime

    Public Property id_Empleado() As Integer
        Get
            Return id_Empleado_
        End Get
        Set(ByVal value As Integer)
            id_Empleado_ = value
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

    Public Property id_TipoEmpleado() As Integer
        Get
            Return id_TipoEmpleado_
        End Get
        Set(ByVal value As Integer)
            id_TipoEmpleado_ = value
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

    Public Property Apellido() As String
        Get
            Return Apellido_
        End Get
        Set(ByVal value As String)
            Apellido_ = value
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

    Public Property Codigo_Postal() As Integer
        Get
            Return Codigo_Postal_
        End Get
        Set(ByVal value As Integer)
            Codigo_Postal_ = value
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

    Public Property Telefono2() As String
        Get
            Return Telefono2_
        End Get
        Set(ByVal value As String)
            Telefono2_ = value
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

    Public Property Cuil() As String
        Get
            Return Cuil_
        End Get
        Set(ByVal value As String)
            Cuil_ = value
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

    Public Property SueldoNormal() As Double
        Get
            Return SueldoNormal_
        End Get
        Set(ByVal value As Double)
            SueldoNormal_ = value
        End Set
    End Property

    Public Property SueldoFeriado() As Double
        Get
            Return SueldoFeriado_
        End Get
        Set(ByVal value As Double)
            SueldoFeriado_ = value
        End Set
    End Property

    Public Property SueldoPresentismo() As Double
        Get
            Return SueldoPresentismo_
        End Get
        Set(ByVal value As Double)
            SueldoPresentismo_ = value
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

    Public Property FechaNacimiento() As Date
        Get
            Return FechaNacimiento_
        End Get
        Set(ByVal value As Date)
            FechaNacimiento_ = value
        End Set
    End Property

    Public Property FechaIngreso() As Date
        Get
            Return FechaIngreso_
        End Get
        Set(ByVal value As Date)
            FechaIngreso_ = value
        End Set
    End Property

    Public Property Sucursales() As System.Windows.Forms.CheckedListBox
        Get
            Return Sucursales_
        End Get
        Set(ByVal value As System.Windows.Forms.CheckedListBox)
            Sucursales_ = value
        End Set
    End Property

    Private id_Usuario_ As Integer
    Public Property id_Usuario() As Integer
        Get
            Return id_Usuario_
        End Get
        Set(ByVal value As Integer)
            id_Usuario_ = value
        End Set
    End Property


End Class
